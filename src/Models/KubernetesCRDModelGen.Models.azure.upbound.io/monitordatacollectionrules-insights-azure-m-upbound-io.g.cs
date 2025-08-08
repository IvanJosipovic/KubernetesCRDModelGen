using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.m.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a MonitorDataCollectionEndpoint in insights to populate dataCollectionEndpointId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a MonitorDataCollectionEndpoint in insights to populate dataCollectionEndpointId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdSelector
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
    public V1beta1MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDataFlow
{
    /// <summary>The built-in transform to transform stream data.</summary>
    [JsonPropertyName("builtInTransform")]
    public string? BuiltInTransform { get; set; }

    /// <summary>Specifies a list of destination names. A azure_monitor_metrics data source only allows for stream of kind Microsoft-InsightsMetrics.</summary>
    [JsonPropertyName("destinations")]
    public IList<string>? Destinations { get; set; }

    /// <summary>The output stream of the transform. Only required if the data flow changes data to a different stream.</summary>
    [JsonPropertyName("outputStream")]
    public string? OutputStream { get; set; }

    /// <summary>Specifies a list of streams. Possible values include but not limited to Microsoft-Event, Microsoft-InsightsMetrics, Microsoft-Perf, Microsoft-Syslog, Microsoft-WindowsEvent, and Microsoft-PrometheusMetrics.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>The KQL query to transform stream data.</summary>
    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesDataImportEventHubDataSource
{
    /// <summary>The Event Hub consumer group name.</summary>
    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The stream to collect from Event Hub. Possible value should be a custom stream name.</summary>
    [JsonPropertyName("stream")]
    public string? Stream { get; set; }
}

/// <summary>A data_import block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesDataImport
{
    /// <summary>An event_hub_data_source block as defined below.</summary>
    [JsonPropertyName("eventHubDataSource")]
    public IList<V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesDataImportEventHubDataSource>? EventHubDataSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesExtension
{
    /// <summary>A JSON String which specifies the extension setting.</summary>
    [JsonPropertyName("extensionJson")]
    public string? ExtensionJson { get; set; }

    /// <summary>The name of the VM extension.</summary>
    [JsonPropertyName("extensionName")]
    public string? ExtensionName { get; set; }

    /// <summary>Specifies a list of data sources this extension needs data from. An item should be a name of a supported data source which produces only one stream. Supported data sources type: performance_counter, windows_event_log,and syslog.</summary>
    [JsonPropertyName("inputDataSources")]
    public IList<string>? InputDataSources { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesIisLog
{
    /// <summary>Specifies a list of absolute paths where the log files are located.</summary>
    [JsonPropertyName("logDirectories")]
    public IList<string>? LogDirectories { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>A text block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesLogFileSettingsText
{
    /// <summary>The timestamp format of the text log files. Possible values are ISO 8601, YYYY-MM-DD HH:MM:SS, M/D/YYYY HH:MM:SS AM/PM, Mon DD, YYYY HH:MM:SS, yyMMdd HH:mm:ss, ddMMyy HH:mm:ss, MMM d hh:mm:ss, dd/MMM/yyyy:HH:mm:ss zzz,and yyyy-MM-ddTHH:mm:ssK.</summary>
    [JsonPropertyName("recordStartTimestampFormat")]
    public string? RecordStartTimestampFormat { get; set; }
}

/// <summary>A settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesLogFileSettings
{
    /// <summary>A text block as defined below.</summary>
    [JsonPropertyName("text")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesLogFileSettingsText? Text { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesLogFile
{
    /// <summary>Specifies a list of file patterns where the log files are located. For example, C:\\JavaLogs\\*.log.</summary>
    [JsonPropertyName("filePatterns")]
    public IList<string>? FilePatterns { get; set; }

    /// <summary>The data format of the log files. Possible values are text and json.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A settings block as defined below.</summary>
    [JsonPropertyName("settings")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesLogFileSettings? Settings { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesPerformanceCounter
{
    /// <summary>Specifies a list of specifier names of the performance counters you want to collect. To get a list of performance counters on Windows, run the command typeperf. Please see this document for more information.</summary>
    [JsonPropertyName("counterSpecifiers")]
    public IList<string>? CounterSpecifiers { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The number of seconds between consecutive counter measurements (samples). The value should be integer between 1 and 1800 inclusive. sampling_frequency_in_seconds must be equal to 60 seconds for counters collected with Microsoft-InsightsMetrics stream.</summary>
    [JsonPropertyName("samplingFrequencyInSeconds")]
    public double? SamplingFrequencyInSeconds { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesPlatformTelemetry
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesPrometheusForwarderLabelIncludeFilter
{
    /// <summary>The label of the filter. This label should be unique across all label_include_fileter block. Possible value is microsoft_metrics_include_label.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The value of the filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesPrometheusForwarder
{
    /// <summary>One or more label_include_filter blocks as defined above.</summary>
    [JsonPropertyName("labelIncludeFilter")]
    public IList<V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesPrometheusForwarderLabelIncludeFilter>? LabelIncludeFilter { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesSyslog
{
    /// <summary>Specifies a list of facility names. Use a wildcard * to collect logs for all facility names. Possible values are alert, *, audit, auth, authpriv, clock, cron, daemon, ftp, kern, local5, local4, local1, local7, local6, local3, local2, local0, lpr, mail, mark, news, nopri, ntp, syslog, user and uucp.</summary>
    [JsonPropertyName("facilityNames")]
    public IList<string>? FacilityNames { get; set; }

    /// <summary>Specifies a list of log levels. Use a wildcard * to collect logs for all log levels. Possible values are Debug, Info, Notice, Warning, Error, Critical, Alert, Emergency,and *.</summary>
    [JsonPropertyName("logLevels")]
    public IList<string>? LogLevels { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesWindowsEventLog
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>Specifies a list of Windows Event Log queries in XPath expression. Please see this document for more information.</summary>
    [JsonPropertyName("xPathQueries")]
    public IList<string>? XPathQueries { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesWindowsFirewallLog
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>A data_sources block as defined below. This property is optional and can be omitted if the rule is meant to be used via direct calls to the provisioned endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDataSources
{
    /// <summary>A data_import block as defined above.</summary>
    [JsonPropertyName("dataImport")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesDataImport? DataImport { get; set; }

    /// <summary>One or more extension blocks as defined below.</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesExtension>? Extension { get; set; }

    /// <summary>One or more iis_log blocks as defined below.</summary>
    [JsonPropertyName("iisLog")]
    public IList<V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesIisLog>? IisLog { get; set; }

    /// <summary>One or more log_file blocks as defined below.</summary>
    [JsonPropertyName("logFile")]
    public IList<V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesLogFile>? LogFile { get; set; }

    /// <summary>One or more performance_counter blocks as defined below.</summary>
    [JsonPropertyName("performanceCounter")]
    public IList<V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesPerformanceCounter>? PerformanceCounter { get; set; }

    /// <summary>One or more platform_telemetry blocks as defined below.</summary>
    [JsonPropertyName("platformTelemetry")]
    public IList<V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesPlatformTelemetry>? PlatformTelemetry { get; set; }

    /// <summary>One or more prometheus_forwarder blocks as defined below.</summary>
    [JsonPropertyName("prometheusForwarder")]
    public IList<V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesPrometheusForwarder>? PrometheusForwarder { get; set; }

    /// <summary>One or more syslog blocks as defined below.</summary>
    [JsonPropertyName("syslog")]
    public IList<V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesSyslog>? Syslog { get; set; }

    /// <summary>One or more windows_event_log blocks as defined below.</summary>
    [JsonPropertyName("windowsEventLog")]
    public IList<V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesWindowsEventLog>? WindowsEventLog { get; set; }

    /// <summary>One or more windows_firewall_log blocks as defined below.</summary>
    [JsonPropertyName("windowsFirewallLog")]
    public IList<V1beta1MonitorDataCollectionRuleSpecForProviderDataSourcesWindowsFirewallLog>? WindowsFirewallLog { get; set; }
}

/// <summary>A azure_monitor_metrics block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsAzureMonitorMetrics
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a EventHub in eventhub to populate eventHubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a EventHub in eventhub to populate eventHubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdSelector
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
    public V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdSelectorPolicy? Policy { get; set; }
}

/// <summary>One or more event_hub blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsEventHub
{
    /// <summary>The resource ID of the Event Hub.</summary>
    [JsonPropertyName("eventHubId")]
    public string? EventHubId { get; set; }

    /// <summary>Reference to a EventHub in eventhub to populate eventHubId.</summary>
    [JsonPropertyName("eventHubIdRef")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdRef? EventHubIdRef { get; set; }

    /// <summary>Selector for a EventHub in eventhub to populate eventHubId.</summary>
    [JsonPropertyName("eventHubIdSelector")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsEventHubEventHubIdSelector? EventHubIdSelector { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>One or more event_hub blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsEventHubDirect
{
    /// <summary>The resource ID of the Event Hub.</summary>
    [JsonPropertyName("eventHubId")]
    public string? EventHubId { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Workspace in operationalinsights to populate workspaceResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Workspace in operationalinsights to populate workspaceResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdSelector
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
    public V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalytics
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of a Log Analytic Workspace resource.</summary>
    [JsonPropertyName("workspaceResourceId")]
    public string? WorkspaceResourceId { get; set; }

    /// <summary>Reference to a Workspace in operationalinsights to populate workspaceResourceId.</summary>
    [JsonPropertyName("workspaceResourceIdRef")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdRef? WorkspaceResourceIdRef { get; set; }

    /// <summary>Selector for a Workspace in operationalinsights to populate workspaceResourceId.</summary>
    [JsonPropertyName("workspaceResourceIdSelector")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalyticsWorkspaceResourceIdSelector? WorkspaceResourceIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsMonitorAccount
{
    /// <summary>The resource ID of the Monitor Account.</summary>
    [JsonPropertyName("monitorAccountId")]
    public string? MonitorAccountId { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Container in storage to populate containerName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Container in storage to populate containerName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameSelector
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
    public V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdRefPolicy
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
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdSelectorPolicy
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
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdSelector
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
    public V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlob
{
    /// <summary>The Storage Container name.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Reference to a Container in storage to populate containerName.</summary>
    [JsonPropertyName("containerNameRef")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameRef? ContainerNameRef { get; set; }

    /// <summary>Selector for a Container in storage to populate containerName.</summary>
    [JsonPropertyName("containerNameSelector")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobContainerNameSelector? ContainerNameSelector { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource ID of the Storage Account.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdRef")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdRef? StorageAccountIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdSelector")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobStorageAccountIdSelector? StorageAccountIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobDirect
{
    /// <summary>The Storage Container name.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource ID of the Storage Account.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageTableDirect
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource ID of the Storage Account.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>The Storage Table name.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>A destinations block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderDestinations
{
    /// <summary>A azure_monitor_metrics block as defined above.</summary>
    [JsonPropertyName("azureMonitorMetrics")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsAzureMonitorMetrics? AzureMonitorMetrics { get; set; }

    /// <summary>One or more event_hub blocks as defined below.</summary>
    [JsonPropertyName("eventHub")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsEventHub? EventHub { get; set; }

    /// <summary>One or more event_hub blocks as defined below.</summary>
    [JsonPropertyName("eventHubDirect")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsEventHubDirect? EventHubDirect { get; set; }

    /// <summary>One or more log_analytics blocks as defined below.</summary>
    [JsonPropertyName("logAnalytics")]
    public IList<V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsLogAnalytics>? LogAnalytics { get; set; }

    /// <summary>One or more monitor_account blocks as defined below.</summary>
    [JsonPropertyName("monitorAccount")]
    public IList<V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsMonitorAccount>? MonitorAccount { get; set; }

    /// <summary>One or more storage_blob blocks as defined below.</summary>
    [JsonPropertyName("storageBlob")]
    public IList<V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlob>? StorageBlob { get; set; }

    /// <summary>One or more storage_blob_direct blocks as defined below.</summary>
    [JsonPropertyName("storageBlobDirect")]
    public IList<V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageBlobDirect>? StorageBlobDirect { get; set; }

    /// <summary>One or more storage_table_direct blocks as defined below.</summary>
    [JsonPropertyName("storageTableDirect")]
    public IList<V1beta1MonitorDataCollectionRuleSpecForProviderDestinationsStorageTableDirect>? StorageTableDirect { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsRefsPolicy
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
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsSelector
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
    public V1beta1MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Data Collection Rule. Currently, up to 1 identity is supported.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>References to UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsRefs")]
    public IList<V1beta1MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsRefs>? IdentityIdsRefs { get; set; }

    /// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsSelector")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderIdentityIdentityIdsSelector? IdentityIdsSelector { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Data Collection Rule. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderResourceGroupNameSelector
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
    public V1beta1MonitorDataCollectionRuleSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderStreamDeclarationColumn
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Data Collection Rule. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProviderStreamDeclaration
{
    /// <summary>One or more column blocks as defined above.</summary>
    [JsonPropertyName("column")]
    public IList<V1beta1MonitorDataCollectionRuleSpecForProviderStreamDeclarationColumn>? Column { get; set; }

    /// <summary>The name of the custom stream. This name should be unique across all stream_declaration blocks and must begin with a prefix of Custom-.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecForProvider
{
    /// <summary>The resource ID of the Data Collection Endpoint that this rule can be used with.</summary>
    [JsonPropertyName("dataCollectionEndpointId")]
    public string? DataCollectionEndpointId { get; set; }

    /// <summary>Reference to a MonitorDataCollectionEndpoint in insights to populate dataCollectionEndpointId.</summary>
    [JsonPropertyName("dataCollectionEndpointIdRef")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdRef? DataCollectionEndpointIdRef { get; set; }

    /// <summary>Selector for a MonitorDataCollectionEndpoint in insights to populate dataCollectionEndpointId.</summary>
    [JsonPropertyName("dataCollectionEndpointIdSelector")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDataCollectionEndpointIdSelector? DataCollectionEndpointIdSelector { get; set; }

    /// <summary>One or more data_flow blocks as defined below.</summary>
    [JsonPropertyName("dataFlow")]
    public IList<V1beta1MonitorDataCollectionRuleSpecForProviderDataFlow>? DataFlow { get; set; }

    /// <summary>A data_sources block as defined below. This property is optional and can be omitted if the rule is meant to be used via direct calls to the provisioned endpoint.</summary>
    [JsonPropertyName("dataSources")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDataSources? DataSources { get; set; }

    /// <summary>The description of the Data Collection Rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A destinations block as defined below.</summary>
    [JsonPropertyName("destinations")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderDestinations? Destinations { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderIdentity? Identity { get; set; }

    /// <summary>The kind of the Data Collection Rule. Possible values are Linux, Windows, AgentDirectToStore and WorkspaceTransforms. A rule of kind Linux does not allow for windows_event_log data sources. And a rule of kind Windows does not allow for syslog data sources. If kind is not specified, all kinds of data sources are allowed.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The Azure Region where the Data Collection Rule should exist. Changing this forces a new Data Collection Rule to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the Resource Group where the Data Collection Rule should exist. Changing this forces a new Data Collection Rule to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1MonitorDataCollectionRuleSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A stream_declaration block as defined below.</summary>
    [JsonPropertyName("streamDeclaration")]
    public IList<V1beta1MonitorDataCollectionRuleSpecForProviderStreamDeclaration>? StreamDeclaration { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Data Collection Rule.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a MonitorDataCollectionEndpoint in insights to populate dataCollectionEndpointId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a MonitorDataCollectionEndpoint in insights to populate dataCollectionEndpointId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdSelector
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
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDataFlow
{
    /// <summary>The built-in transform to transform stream data.</summary>
    [JsonPropertyName("builtInTransform")]
    public string? BuiltInTransform { get; set; }

    /// <summary>Specifies a list of destination names. A azure_monitor_metrics data source only allows for stream of kind Microsoft-InsightsMetrics.</summary>
    [JsonPropertyName("destinations")]
    public IList<string>? Destinations { get; set; }

    /// <summary>The output stream of the transform. Only required if the data flow changes data to a different stream.</summary>
    [JsonPropertyName("outputStream")]
    public string? OutputStream { get; set; }

    /// <summary>Specifies a list of streams. Possible values include but not limited to Microsoft-Event, Microsoft-InsightsMetrics, Microsoft-Perf, Microsoft-Syslog, Microsoft-WindowsEvent, and Microsoft-PrometheusMetrics.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>The KQL query to transform stream data.</summary>
    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesDataImportEventHubDataSource
{
    /// <summary>The Event Hub consumer group name.</summary>
    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The stream to collect from Event Hub. Possible value should be a custom stream name.</summary>
    [JsonPropertyName("stream")]
    public string? Stream { get; set; }
}

/// <summary>A data_import block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesDataImport
{
    /// <summary>An event_hub_data_source block as defined below.</summary>
    [JsonPropertyName("eventHubDataSource")]
    public IList<V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesDataImportEventHubDataSource>? EventHubDataSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesExtension
{
    /// <summary>A JSON String which specifies the extension setting.</summary>
    [JsonPropertyName("extensionJson")]
    public string? ExtensionJson { get; set; }

    /// <summary>The name of the VM extension.</summary>
    [JsonPropertyName("extensionName")]
    public string? ExtensionName { get; set; }

    /// <summary>Specifies a list of data sources this extension needs data from. An item should be a name of a supported data source which produces only one stream. Supported data sources type: performance_counter, windows_event_log,and syslog.</summary>
    [JsonPropertyName("inputDataSources")]
    public IList<string>? InputDataSources { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesIisLog
{
    /// <summary>Specifies a list of absolute paths where the log files are located.</summary>
    [JsonPropertyName("logDirectories")]
    public IList<string>? LogDirectories { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>A text block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesLogFileSettingsText
{
    /// <summary>The timestamp format of the text log files. Possible values are ISO 8601, YYYY-MM-DD HH:MM:SS, M/D/YYYY HH:MM:SS AM/PM, Mon DD, YYYY HH:MM:SS, yyMMdd HH:mm:ss, ddMMyy HH:mm:ss, MMM d hh:mm:ss, dd/MMM/yyyy:HH:mm:ss zzz,and yyyy-MM-ddTHH:mm:ssK.</summary>
    [JsonPropertyName("recordStartTimestampFormat")]
    public string? RecordStartTimestampFormat { get; set; }
}

/// <summary>A settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesLogFileSettings
{
    /// <summary>A text block as defined below.</summary>
    [JsonPropertyName("text")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesLogFileSettingsText? Text { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesLogFile
{
    /// <summary>Specifies a list of file patterns where the log files are located. For example, C:\\JavaLogs\\*.log.</summary>
    [JsonPropertyName("filePatterns")]
    public IList<string>? FilePatterns { get; set; }

    /// <summary>The data format of the log files. Possible values are text and json.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A settings block as defined below.</summary>
    [JsonPropertyName("settings")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesLogFileSettings? Settings { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesPerformanceCounter
{
    /// <summary>Specifies a list of specifier names of the performance counters you want to collect. To get a list of performance counters on Windows, run the command typeperf. Please see this document for more information.</summary>
    [JsonPropertyName("counterSpecifiers")]
    public IList<string>? CounterSpecifiers { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The number of seconds between consecutive counter measurements (samples). The value should be integer between 1 and 1800 inclusive. sampling_frequency_in_seconds must be equal to 60 seconds for counters collected with Microsoft-InsightsMetrics stream.</summary>
    [JsonPropertyName("samplingFrequencyInSeconds")]
    public double? SamplingFrequencyInSeconds { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesPlatformTelemetry
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesPrometheusForwarderLabelIncludeFilter
{
    /// <summary>The label of the filter. This label should be unique across all label_include_fileter block. Possible value is microsoft_metrics_include_label.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The value of the filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesPrometheusForwarder
{
    /// <summary>One or more label_include_filter blocks as defined above.</summary>
    [JsonPropertyName("labelIncludeFilter")]
    public IList<V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesPrometheusForwarderLabelIncludeFilter>? LabelIncludeFilter { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesSyslog
{
    /// <summary>Specifies a list of facility names. Use a wildcard * to collect logs for all facility names. Possible values are alert, *, audit, auth, authpriv, clock, cron, daemon, ftp, kern, local5, local4, local1, local7, local6, local3, local2, local0, lpr, mail, mark, news, nopri, ntp, syslog, user and uucp.</summary>
    [JsonPropertyName("facilityNames")]
    public IList<string>? FacilityNames { get; set; }

    /// <summary>Specifies a list of log levels. Use a wildcard * to collect logs for all log levels. Possible values are Debug, Info, Notice, Warning, Error, Critical, Alert, Emergency,and *.</summary>
    [JsonPropertyName("logLevels")]
    public IList<string>? LogLevels { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesWindowsEventLog
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>Specifies a list of Windows Event Log queries in XPath expression. Please see this document for more information.</summary>
    [JsonPropertyName("xPathQueries")]
    public IList<string>? XPathQueries { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesWindowsFirewallLog
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>A data_sources block as defined below. This property is optional and can be omitted if the rule is meant to be used via direct calls to the provisioned endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDataSources
{
    /// <summary>A data_import block as defined above.</summary>
    [JsonPropertyName("dataImport")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesDataImport? DataImport { get; set; }

    /// <summary>One or more extension blocks as defined below.</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesExtension>? Extension { get; set; }

    /// <summary>One or more iis_log blocks as defined below.</summary>
    [JsonPropertyName("iisLog")]
    public IList<V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesIisLog>? IisLog { get; set; }

    /// <summary>One or more log_file blocks as defined below.</summary>
    [JsonPropertyName("logFile")]
    public IList<V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesLogFile>? LogFile { get; set; }

    /// <summary>One or more performance_counter blocks as defined below.</summary>
    [JsonPropertyName("performanceCounter")]
    public IList<V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesPerformanceCounter>? PerformanceCounter { get; set; }

    /// <summary>One or more platform_telemetry blocks as defined below.</summary>
    [JsonPropertyName("platformTelemetry")]
    public IList<V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesPlatformTelemetry>? PlatformTelemetry { get; set; }

    /// <summary>One or more prometheus_forwarder blocks as defined below.</summary>
    [JsonPropertyName("prometheusForwarder")]
    public IList<V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesPrometheusForwarder>? PrometheusForwarder { get; set; }

    /// <summary>One or more syslog blocks as defined below.</summary>
    [JsonPropertyName("syslog")]
    public IList<V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesSyslog>? Syslog { get; set; }

    /// <summary>One or more windows_event_log blocks as defined below.</summary>
    [JsonPropertyName("windowsEventLog")]
    public IList<V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesWindowsEventLog>? WindowsEventLog { get; set; }

    /// <summary>One or more windows_firewall_log blocks as defined below.</summary>
    [JsonPropertyName("windowsFirewallLog")]
    public IList<V1beta1MonitorDataCollectionRuleSpecInitProviderDataSourcesWindowsFirewallLog>? WindowsFirewallLog { get; set; }
}

/// <summary>A azure_monitor_metrics block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsAzureMonitorMetrics
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a EventHub in eventhub to populate eventHubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a EventHub in eventhub to populate eventHubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdSelector
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
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdSelectorPolicy? Policy { get; set; }
}

/// <summary>One or more event_hub blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsEventHub
{
    /// <summary>The resource ID of the Event Hub.</summary>
    [JsonPropertyName("eventHubId")]
    public string? EventHubId { get; set; }

    /// <summary>Reference to a EventHub in eventhub to populate eventHubId.</summary>
    [JsonPropertyName("eventHubIdRef")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdRef? EventHubIdRef { get; set; }

    /// <summary>Selector for a EventHub in eventhub to populate eventHubId.</summary>
    [JsonPropertyName("eventHubIdSelector")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubEventHubIdSelector? EventHubIdSelector { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>One or more event_hub blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubDirect
{
    /// <summary>The resource ID of the Event Hub.</summary>
    [JsonPropertyName("eventHubId")]
    public string? EventHubId { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Workspace in operationalinsights to populate workspaceResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Workspace in operationalinsights to populate workspaceResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdSelector
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
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalytics
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of a Log Analytic Workspace resource.</summary>
    [JsonPropertyName("workspaceResourceId")]
    public string? WorkspaceResourceId { get; set; }

    /// <summary>Reference to a Workspace in operationalinsights to populate workspaceResourceId.</summary>
    [JsonPropertyName("workspaceResourceIdRef")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdRef? WorkspaceResourceIdRef { get; set; }

    /// <summary>Selector for a Workspace in operationalinsights to populate workspaceResourceId.</summary>
    [JsonPropertyName("workspaceResourceIdSelector")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalyticsWorkspaceResourceIdSelector? WorkspaceResourceIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsMonitorAccount
{
    /// <summary>The resource ID of the Monitor Account.</summary>
    [JsonPropertyName("monitorAccountId")]
    public string? MonitorAccountId { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Container in storage to populate containerName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Container in storage to populate containerName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameSelector
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
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdRefPolicy
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
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdSelectorPolicy
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
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdSelector
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
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlob
{
    /// <summary>The Storage Container name.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Reference to a Container in storage to populate containerName.</summary>
    [JsonPropertyName("containerNameRef")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameRef? ContainerNameRef { get; set; }

    /// <summary>Selector for a Container in storage to populate containerName.</summary>
    [JsonPropertyName("containerNameSelector")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobContainerNameSelector? ContainerNameSelector { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource ID of the Storage Account.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdRef")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdRef? StorageAccountIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdSelector")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobStorageAccountIdSelector? StorageAccountIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobDirect
{
    /// <summary>The Storage Container name.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource ID of the Storage Account.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageTableDirect
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource ID of the Storage Account.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>The Storage Table name.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>A destinations block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderDestinations
{
    /// <summary>A azure_monitor_metrics block as defined above.</summary>
    [JsonPropertyName("azureMonitorMetrics")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsAzureMonitorMetrics? AzureMonitorMetrics { get; set; }

    /// <summary>One or more event_hub blocks as defined below.</summary>
    [JsonPropertyName("eventHub")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsEventHub? EventHub { get; set; }

    /// <summary>One or more event_hub blocks as defined below.</summary>
    [JsonPropertyName("eventHubDirect")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsEventHubDirect? EventHubDirect { get; set; }

    /// <summary>One or more log_analytics blocks as defined below.</summary>
    [JsonPropertyName("logAnalytics")]
    public IList<V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsLogAnalytics>? LogAnalytics { get; set; }

    /// <summary>One or more monitor_account blocks as defined below.</summary>
    [JsonPropertyName("monitorAccount")]
    public IList<V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsMonitorAccount>? MonitorAccount { get; set; }

    /// <summary>One or more storage_blob blocks as defined below.</summary>
    [JsonPropertyName("storageBlob")]
    public IList<V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlob>? StorageBlob { get; set; }

    /// <summary>One or more storage_blob_direct blocks as defined below.</summary>
    [JsonPropertyName("storageBlobDirect")]
    public IList<V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageBlobDirect>? StorageBlobDirect { get; set; }

    /// <summary>One or more storage_table_direct blocks as defined below.</summary>
    [JsonPropertyName("storageTableDirect")]
    public IList<V1beta1MonitorDataCollectionRuleSpecInitProviderDestinationsStorageTableDirect>? StorageTableDirect { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsRefsPolicy
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
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsSelector
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
    public V1beta1MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Data Collection Rule. Currently, up to 1 identity is supported.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>References to UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsRefs")]
    public IList<V1beta1MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsRefs>? IdentityIdsRefs { get; set; }

    /// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsSelector")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderIdentityIdentityIdsSelector? IdentityIdsSelector { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Data Collection Rule. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderStreamDeclarationColumn
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Data Collection Rule. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProviderStreamDeclaration
{
    /// <summary>One or more column blocks as defined above.</summary>
    [JsonPropertyName("column")]
    public IList<V1beta1MonitorDataCollectionRuleSpecInitProviderStreamDeclarationColumn>? Column { get; set; }

    /// <summary>The name of the custom stream. This name should be unique across all stream_declaration blocks and must begin with a prefix of Custom-.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecInitProvider
{
    /// <summary>The resource ID of the Data Collection Endpoint that this rule can be used with.</summary>
    [JsonPropertyName("dataCollectionEndpointId")]
    public string? DataCollectionEndpointId { get; set; }

    /// <summary>Reference to a MonitorDataCollectionEndpoint in insights to populate dataCollectionEndpointId.</summary>
    [JsonPropertyName("dataCollectionEndpointIdRef")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdRef? DataCollectionEndpointIdRef { get; set; }

    /// <summary>Selector for a MonitorDataCollectionEndpoint in insights to populate dataCollectionEndpointId.</summary>
    [JsonPropertyName("dataCollectionEndpointIdSelector")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDataCollectionEndpointIdSelector? DataCollectionEndpointIdSelector { get; set; }

    /// <summary>One or more data_flow blocks as defined below.</summary>
    [JsonPropertyName("dataFlow")]
    public IList<V1beta1MonitorDataCollectionRuleSpecInitProviderDataFlow>? DataFlow { get; set; }

    /// <summary>A data_sources block as defined below. This property is optional and can be omitted if the rule is meant to be used via direct calls to the provisioned endpoint.</summary>
    [JsonPropertyName("dataSources")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDataSources? DataSources { get; set; }

    /// <summary>The description of the Data Collection Rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A destinations block as defined below.</summary>
    [JsonPropertyName("destinations")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderDestinations? Destinations { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1MonitorDataCollectionRuleSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>The kind of the Data Collection Rule. Possible values are Linux, Windows, AgentDirectToStore and WorkspaceTransforms. A rule of kind Linux does not allow for windows_event_log data sources. And a rule of kind Windows does not allow for syslog data sources. If kind is not specified, all kinds of data sources are allowed.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The Azure Region where the Data Collection Rule should exist. Changing this forces a new Data Collection Rule to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A stream_declaration block as defined below.</summary>
    [JsonPropertyName("streamDeclaration")]
    public IList<V1beta1MonitorDataCollectionRuleSpecInitProviderStreamDeclaration>? StreamDeclaration { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Data Collection Rule.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpecProviderConfigRef
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
public partial class V1beta1MonitorDataCollectionRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>MonitorDataCollectionRuleSpec defines the desired state of MonitorDataCollectionRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MonitorDataCollectionRuleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MonitorDataCollectionRuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MonitorDataCollectionRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MonitorDataCollectionRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDataFlow
{
    /// <summary>The built-in transform to transform stream data.</summary>
    [JsonPropertyName("builtInTransform")]
    public string? BuiltInTransform { get; set; }

    /// <summary>Specifies a list of destination names. A azure_monitor_metrics data source only allows for stream of kind Microsoft-InsightsMetrics.</summary>
    [JsonPropertyName("destinations")]
    public IList<string>? Destinations { get; set; }

    /// <summary>The output stream of the transform. Only required if the data flow changes data to a different stream.</summary>
    [JsonPropertyName("outputStream")]
    public string? OutputStream { get; set; }

    /// <summary>Specifies a list of streams. Possible values include but not limited to Microsoft-Event, Microsoft-InsightsMetrics, Microsoft-Perf, Microsoft-Syslog, Microsoft-WindowsEvent, and Microsoft-PrometheusMetrics.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>The KQL query to transform stream data.</summary>
    [JsonPropertyName("transformKql")]
    public string? TransformKql { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesDataImportEventHubDataSource
{
    /// <summary>The Event Hub consumer group name.</summary>
    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The stream to collect from Event Hub. Possible value should be a custom stream name.</summary>
    [JsonPropertyName("stream")]
    public string? Stream { get; set; }
}

/// <summary>A data_import block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesDataImport
{
    /// <summary>An event_hub_data_source block as defined below.</summary>
    [JsonPropertyName("eventHubDataSource")]
    public IList<V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesDataImportEventHubDataSource>? EventHubDataSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesExtension
{
    /// <summary>A JSON String which specifies the extension setting.</summary>
    [JsonPropertyName("extensionJson")]
    public string? ExtensionJson { get; set; }

    /// <summary>The name of the VM extension.</summary>
    [JsonPropertyName("extensionName")]
    public string? ExtensionName { get; set; }

    /// <summary>Specifies a list of data sources this extension needs data from. An item should be a name of a supported data source which produces only one stream. Supported data sources type: performance_counter, windows_event_log,and syslog.</summary>
    [JsonPropertyName("inputDataSources")]
    public IList<string>? InputDataSources { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesIisLog
{
    /// <summary>Specifies a list of absolute paths where the log files are located.</summary>
    [JsonPropertyName("logDirectories")]
    public IList<string>? LogDirectories { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>A text block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesLogFileSettingsText
{
    /// <summary>The timestamp format of the text log files. Possible values are ISO 8601, YYYY-MM-DD HH:MM:SS, M/D/YYYY HH:MM:SS AM/PM, Mon DD, YYYY HH:MM:SS, yyMMdd HH:mm:ss, ddMMyy HH:mm:ss, MMM d hh:mm:ss, dd/MMM/yyyy:HH:mm:ss zzz,and yyyy-MM-ddTHH:mm:ssK.</summary>
    [JsonPropertyName("recordStartTimestampFormat")]
    public string? RecordStartTimestampFormat { get; set; }
}

/// <summary>A settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesLogFileSettings
{
    /// <summary>A text block as defined below.</summary>
    [JsonPropertyName("text")]
    public V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesLogFileSettingsText? Text { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesLogFile
{
    /// <summary>Specifies a list of file patterns where the log files are located. For example, C:\\JavaLogs\\*.log.</summary>
    [JsonPropertyName("filePatterns")]
    public IList<string>? FilePatterns { get; set; }

    /// <summary>The data format of the log files. Possible values are text and json.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A settings block as defined below.</summary>
    [JsonPropertyName("settings")]
    public V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesLogFileSettings? Settings { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesPerformanceCounter
{
    /// <summary>Specifies a list of specifier names of the performance counters you want to collect. To get a list of performance counters on Windows, run the command typeperf. Please see this document for more information.</summary>
    [JsonPropertyName("counterSpecifiers")]
    public IList<string>? CounterSpecifiers { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The number of seconds between consecutive counter measurements (samples). The value should be integer between 1 and 1800 inclusive. sampling_frequency_in_seconds must be equal to 60 seconds for counters collected with Microsoft-InsightsMetrics stream.</summary>
    [JsonPropertyName("samplingFrequencyInSeconds")]
    public double? SamplingFrequencyInSeconds { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesPlatformTelemetry
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesPrometheusForwarderLabelIncludeFilter
{
    /// <summary>The label of the filter. This label should be unique across all label_include_fileter block. Possible value is microsoft_metrics_include_label.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The value of the filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesPrometheusForwarder
{
    /// <summary>One or more label_include_filter blocks as defined above.</summary>
    [JsonPropertyName("labelIncludeFilter")]
    public IList<V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesPrometheusForwarderLabelIncludeFilter>? LabelIncludeFilter { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesSyslog
{
    /// <summary>Specifies a list of facility names. Use a wildcard * to collect logs for all facility names. Possible values are alert, *, audit, auth, authpriv, clock, cron, daemon, ftp, kern, local5, local4, local1, local7, local6, local3, local2, local0, lpr, mail, mark, news, nopri, ntp, syslog, user and uucp.</summary>
    [JsonPropertyName("facilityNames")]
    public IList<string>? FacilityNames { get; set; }

    /// <summary>Specifies a list of log levels. Use a wildcard * to collect logs for all log levels. Possible values are Debug, Info, Notice, Warning, Error, Critical, Alert, Emergency,and *.</summary>
    [JsonPropertyName("logLevels")]
    public IList<string>? LogLevels { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesWindowsEventLog
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }

    /// <summary>Specifies a list of Windows Event Log queries in XPath expression. Please see this document for more information.</summary>
    [JsonPropertyName("xPathQueries")]
    public IList<string>? XPathQueries { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesWindowsFirewallLog
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a list of streams that this data source will be sent to. A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.</summary>
    [JsonPropertyName("streams")]
    public IList<string>? Streams { get; set; }
}

/// <summary>A data_sources block as defined below. This property is optional and can be omitted if the rule is meant to be used via direct calls to the provisioned endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDataSources
{
    /// <summary>A data_import block as defined above.</summary>
    [JsonPropertyName("dataImport")]
    public V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesDataImport? DataImport { get; set; }

    /// <summary>One or more extension blocks as defined below.</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesExtension>? Extension { get; set; }

    /// <summary>One or more iis_log blocks as defined below.</summary>
    [JsonPropertyName("iisLog")]
    public IList<V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesIisLog>? IisLog { get; set; }

    /// <summary>One or more log_file blocks as defined below.</summary>
    [JsonPropertyName("logFile")]
    public IList<V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesLogFile>? LogFile { get; set; }

    /// <summary>One or more performance_counter blocks as defined below.</summary>
    [JsonPropertyName("performanceCounter")]
    public IList<V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesPerformanceCounter>? PerformanceCounter { get; set; }

    /// <summary>One or more platform_telemetry blocks as defined below.</summary>
    [JsonPropertyName("platformTelemetry")]
    public IList<V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesPlatformTelemetry>? PlatformTelemetry { get; set; }

    /// <summary>One or more prometheus_forwarder blocks as defined below.</summary>
    [JsonPropertyName("prometheusForwarder")]
    public IList<V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesPrometheusForwarder>? PrometheusForwarder { get; set; }

    /// <summary>One or more syslog blocks as defined below.</summary>
    [JsonPropertyName("syslog")]
    public IList<V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesSyslog>? Syslog { get; set; }

    /// <summary>One or more windows_event_log blocks as defined below.</summary>
    [JsonPropertyName("windowsEventLog")]
    public IList<V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesWindowsEventLog>? WindowsEventLog { get; set; }

    /// <summary>One or more windows_firewall_log blocks as defined below.</summary>
    [JsonPropertyName("windowsFirewallLog")]
    public IList<V1beta1MonitorDataCollectionRuleStatusAtProviderDataSourcesWindowsFirewallLog>? WindowsFirewallLog { get; set; }
}

/// <summary>A azure_monitor_metrics block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDestinationsAzureMonitorMetrics
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>One or more event_hub blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDestinationsEventHub
{
    /// <summary>The resource ID of the Event Hub.</summary>
    [JsonPropertyName("eventHubId")]
    public string? EventHubId { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>One or more event_hub blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDestinationsEventHubDirect
{
    /// <summary>The resource ID of the Event Hub.</summary>
    [JsonPropertyName("eventHubId")]
    public string? EventHubId { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDestinationsLogAnalytics
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of a Log Analytic Workspace resource.</summary>
    [JsonPropertyName("workspaceResourceId")]
    public string? WorkspaceResourceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDestinationsMonitorAccount
{
    /// <summary>The resource ID of the Monitor Account.</summary>
    [JsonPropertyName("monitorAccountId")]
    public string? MonitorAccountId { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDestinationsStorageBlob
{
    /// <summary>The Storage Container name.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource ID of the Storage Account.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDestinationsStorageBlobDirect
{
    /// <summary>The Storage Container name.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource ID of the Storage Account.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDestinationsStorageTableDirect
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource ID of the Storage Account.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>The Storage Table name.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>A destinations block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderDestinations
{
    /// <summary>A azure_monitor_metrics block as defined above.</summary>
    [JsonPropertyName("azureMonitorMetrics")]
    public V1beta1MonitorDataCollectionRuleStatusAtProviderDestinationsAzureMonitorMetrics? AzureMonitorMetrics { get; set; }

    /// <summary>One or more event_hub blocks as defined below.</summary>
    [JsonPropertyName("eventHub")]
    public V1beta1MonitorDataCollectionRuleStatusAtProviderDestinationsEventHub? EventHub { get; set; }

    /// <summary>One or more event_hub blocks as defined below.</summary>
    [JsonPropertyName("eventHubDirect")]
    public V1beta1MonitorDataCollectionRuleStatusAtProviderDestinationsEventHubDirect? EventHubDirect { get; set; }

    /// <summary>One or more log_analytics blocks as defined below.</summary>
    [JsonPropertyName("logAnalytics")]
    public IList<V1beta1MonitorDataCollectionRuleStatusAtProviderDestinationsLogAnalytics>? LogAnalytics { get; set; }

    /// <summary>One or more monitor_account blocks as defined below.</summary>
    [JsonPropertyName("monitorAccount")]
    public IList<V1beta1MonitorDataCollectionRuleStatusAtProviderDestinationsMonitorAccount>? MonitorAccount { get; set; }

    /// <summary>One or more storage_blob blocks as defined below.</summary>
    [JsonPropertyName("storageBlob")]
    public IList<V1beta1MonitorDataCollectionRuleStatusAtProviderDestinationsStorageBlob>? StorageBlob { get; set; }

    /// <summary>One or more storage_blob_direct blocks as defined below.</summary>
    [JsonPropertyName("storageBlobDirect")]
    public IList<V1beta1MonitorDataCollectionRuleStatusAtProviderDestinationsStorageBlobDirect>? StorageBlobDirect { get; set; }

    /// <summary>One or more storage_table_direct blocks as defined below.</summary>
    [JsonPropertyName("storageTableDirect")]
    public IList<V1beta1MonitorDataCollectionRuleStatusAtProviderDestinationsStorageTableDirect>? StorageTableDirect { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Data Collection Rule. Currently, up to 1 identity is supported.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Data Collection Rule. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderStreamDeclarationColumn
{
    /// <summary>The name which should be used for this data source. This name should be unique across all data sources regardless of type within the Data Collection Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Data Collection Rule. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProviderStreamDeclaration
{
    /// <summary>One or more column blocks as defined above.</summary>
    [JsonPropertyName("column")]
    public IList<V1beta1MonitorDataCollectionRuleStatusAtProviderStreamDeclarationColumn>? Column { get; set; }

    /// <summary>The name of the custom stream. This name should be unique across all stream_declaration blocks and must begin with a prefix of Custom-.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusAtProvider
{
    /// <summary>The resource ID of the Data Collection Endpoint that this rule can be used with.</summary>
    [JsonPropertyName("dataCollectionEndpointId")]
    public string? DataCollectionEndpointId { get; set; }

    /// <summary>One or more data_flow blocks as defined below.</summary>
    [JsonPropertyName("dataFlow")]
    public IList<V1beta1MonitorDataCollectionRuleStatusAtProviderDataFlow>? DataFlow { get; set; }

    /// <summary>A data_sources block as defined below. This property is optional and can be omitted if the rule is meant to be used via direct calls to the provisioned endpoint.</summary>
    [JsonPropertyName("dataSources")]
    public V1beta1MonitorDataCollectionRuleStatusAtProviderDataSources? DataSources { get; set; }

    /// <summary>The description of the Data Collection Rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A destinations block as defined below.</summary>
    [JsonPropertyName("destinations")]
    public V1beta1MonitorDataCollectionRuleStatusAtProviderDestinations? Destinations { get; set; }

    /// <summary>The ID of the Data Collection Rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1MonitorDataCollectionRuleStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>The immutable ID of the Data Collection Rule.</summary>
    [JsonPropertyName("immutableId")]
    public string? ImmutableId { get; set; }

    /// <summary>The kind of the Data Collection Rule. Possible values are Linux, Windows, AgentDirectToStore and WorkspaceTransforms. A rule of kind Linux does not allow for windows_event_log data sources. And a rule of kind Windows does not allow for syslog data sources. If kind is not specified, all kinds of data sources are allowed.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The Azure Region where the Data Collection Rule should exist. Changing this forces a new Data Collection Rule to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the Resource Group where the Data Collection Rule should exist. Changing this forces a new Data Collection Rule to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A stream_declaration block as defined below.</summary>
    [JsonPropertyName("streamDeclaration")]
    public IList<V1beta1MonitorDataCollectionRuleStatusAtProviderStreamDeclaration>? StreamDeclaration { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Data Collection Rule.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatusConditions
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

/// <summary>MonitorDataCollectionRuleStatus defines the observed state of MonitorDataCollectionRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorDataCollectionRuleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MonitorDataCollectionRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MonitorDataCollectionRuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MonitorDataCollectionRule is the Schema for the MonitorDataCollectionRules API. Manages a Data Collection Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitorDataCollectionRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MonitorDataCollectionRuleSpec>, IStatus<V1beta1MonitorDataCollectionRuleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitorDataCollectionRule";
    public const string KubeGroup = "insights.azure.m.upbound.io";
    public const string KubePluralName = "monitordatacollectionrules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MonitorDataCollectionRuleSpec defines the desired state of MonitorDataCollectionRule</summary>
    [JsonPropertyName("spec")]
    public V1beta1MonitorDataCollectionRuleSpec Spec { get; set; }

    /// <summary>MonitorDataCollectionRuleStatus defines the observed state of MonitorDataCollectionRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1MonitorDataCollectionRuleStatus? Status { get; set; }
}

/// <summary>MonitorDataCollectionRule is the Schema for the MonitorDataCollectionRules API. Manages a Data Collection Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitorDataCollectionRuleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MonitorDataCollectionRule>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitorDataCollectionRuleList";
    public const string KubeGroup = "insights.azure.m.upbound.io";
    public const string KubePluralName = "monitordatacollectionrules";
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
    public IList<V1beta1MonitorDataCollectionRule> Items { get; set; }
}