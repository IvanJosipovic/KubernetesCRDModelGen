using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.unity.databricks.crossplane.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecForProviderCustomMetrics
{
    /// <summary>create metric definition</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Columns on the monitored table to apply the custom metrics to.</summary>
    [JsonPropertyName("inputColumns")]
    public IList<string>? InputColumns { get; set; }

    /// <summary>Name of the custom metric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The output type of the custom metric.</summary>
    [JsonPropertyName("outputDataType")]
    public string? OutputDataType { get; set; }

    /// <summary>The type of the custom metric.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecForProviderDataClassificationConfig
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecForProviderInferenceLog
{
    /// <summary>List of granularities to use when aggregating data into time windows based on their timestamp.</summary>
    [JsonPropertyName("granularities")]
    public IList<string>? Granularities { get; set; }

    /// <summary>Column of the model label</summary>
    [JsonPropertyName("labelCol")]
    public string? LabelCol { get; set; }

    /// <summary>Column of the model id or version</summary>
    [JsonPropertyName("modelIdCol")]
    public string? ModelIdCol { get; set; }

    /// <summary>Column of the model prediction</summary>
    [JsonPropertyName("predictionCol")]
    public string? PredictionCol { get; set; }

    /// <summary>Column of the model prediction probabilities</summary>
    [JsonPropertyName("predictionProbaCol")]
    public string? PredictionProbaCol { get; set; }

    /// <summary>Problem type the model aims to solve. Either PROBLEM_TYPE_CLASSIFICATION or PROBLEM_TYPE_REGRESSION</summary>
    [JsonPropertyName("problemType")]
    public string? ProblemType { get; set; }

    /// <summary>Column of the timestamp of predictions</summary>
    [JsonPropertyName("timestampCol")]
    public string? TimestampCol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecForProviderNotificationsOnFailure
{
    /// <summary></summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecForProviderNotificationsOnNewClassificationTagDetected
{
    /// <summary></summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecForProviderNotifications
{
    /// <summary>who to send notifications to on monitor failure.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1alpha1QualityMonitorSpecForProviderNotificationsOnFailure>? OnFailure { get; set; }

    /// <summary>Who to send notifications to when new data classification tags are detected.</summary>
    [JsonPropertyName("onNewClassificationTagDetected")]
    public IList<V1alpha1QualityMonitorSpecForProviderNotificationsOnNewClassificationTagDetected>? OnNewClassificationTagDetected { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecForProviderSchedule
{
    /// <summary>string expression that determines when to run the monitor. See Quartz documentation for examples.</summary>
    [JsonPropertyName("quartzCronExpression")]
    public string? QuartzCronExpression { get; set; }

    /// <summary>string with timezone id (e.g., PST) in which to evaluate the Quartz expression.</summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecForProviderSnapshot
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecForProviderTimeSeries
{
    /// <summary>List of granularities to use when aggregating data into time windows based on their timestamp.</summary>
    [JsonPropertyName("granularities")]
    public IList<string>? Granularities { get; set; }

    /// <summary>Column of the timestamp of predictions</summary>
    [JsonPropertyName("timestampCol")]
    public string? TimestampCol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecForProvider
{
    /// <summary>- The directory to store the monitoring assets (Eg. Dashboard and Metric Tables)</summary>
    [JsonPropertyName("assetsDir")]
    public string? AssetsDir { get; set; }

    /// <summary>Name of the baseline table from which drift metrics are computed from.Columns in the monitored table should also be present in the baseline table.</summary>
    [JsonPropertyName("baselineTableName")]
    public string? BaselineTableName { get; set; }

    /// <summary>Custom metrics to compute on the monitored table. These can be aggregate metrics, derived metrics (from already computed aggregate metrics), or drift metrics (comparing metrics across time windows).</summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1alpha1QualityMonitorSpecForProviderCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>The data classification config for the monitor</summary>
    [JsonPropertyName("dataClassificationConfig")]
    public IList<V1alpha1QualityMonitorSpecForProviderDataClassificationConfig>? DataClassificationConfig { get; set; }

    /// <summary>Configuration for the inference log monitor</summary>
    [JsonPropertyName("inferenceLog")]
    public IList<V1alpha1QualityMonitorSpecForProviderInferenceLog>? InferenceLog { get; set; }

    /// <summary></summary>
    [JsonPropertyName("latestMonitorFailureMsg")]
    public string? LatestMonitorFailureMsg { get; set; }

    /// <summary>The notification settings for the monitor.  The following optional blocks are supported, each consisting of the single string array field with name email_addresses containing a list of emails to notify:</summary>
    [JsonPropertyName("notifications")]
    public IList<V1alpha1QualityMonitorSpecForProviderNotifications>? Notifications { get; set; }

    /// <summary>- Schema where output metric tables are created</summary>
    [JsonPropertyName("outputSchemaName")]
    public string? OutputSchemaName { get; set; }

    /// <summary>The schedule for automatically updating and refreshing metric tables.  This block consists of following fields:</summary>
    [JsonPropertyName("schedule")]
    public IList<V1alpha1QualityMonitorSpecForProviderSchedule>? Schedule { get; set; }

    /// <summary>Whether to skip creating a default dashboard summarizing data quality metrics.  (Can't be updated after creation).</summary>
    [JsonPropertyName("skipBuiltinDashboard")]
    public bool? SkipBuiltinDashboard { get; set; }

    /// <summary>List of column expressions to slice data with for targeted analysis. The data is grouped by each expression independently, resulting in a separate slice for each predicate and its complements. For high-cardinality columns, only the top 100 unique values by frequency will generate slices.</summary>
    [JsonPropertyName("slicingExprs")]
    public IList<string>? SlicingExprs { get; set; }

    /// <summary>Configuration for monitoring snapshot tables.</summary>
    [JsonPropertyName("snapshot")]
    public IList<V1alpha1QualityMonitorSpecForProviderSnapshot>? Snapshot { get; set; }

    /// <summary>- The full name of the table to attach the monitor too. Its of the format {catalog}.{schema}.{tableName}</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Configuration for monitoring timeseries tables.</summary>
    [JsonPropertyName("timeSeries")]
    public IList<V1alpha1QualityMonitorSpecForProviderTimeSeries>? TimeSeries { get; set; }

    /// <summary>Optional argument to specify the warehouse for dashboard creation. If not specified, the first running warehouse will be used.  (Can't be updated after creation)</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecInitProviderCustomMetrics
{
    /// <summary>create metric definition</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Columns on the monitored table to apply the custom metrics to.</summary>
    [JsonPropertyName("inputColumns")]
    public IList<string>? InputColumns { get; set; }

    /// <summary>Name of the custom metric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The output type of the custom metric.</summary>
    [JsonPropertyName("outputDataType")]
    public string? OutputDataType { get; set; }

    /// <summary>The type of the custom metric.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecInitProviderDataClassificationConfig
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecInitProviderInferenceLog
{
    /// <summary>List of granularities to use when aggregating data into time windows based on their timestamp.</summary>
    [JsonPropertyName("granularities")]
    public IList<string>? Granularities { get; set; }

    /// <summary>Column of the model label</summary>
    [JsonPropertyName("labelCol")]
    public string? LabelCol { get; set; }

    /// <summary>Column of the model id or version</summary>
    [JsonPropertyName("modelIdCol")]
    public string? ModelIdCol { get; set; }

    /// <summary>Column of the model prediction</summary>
    [JsonPropertyName("predictionCol")]
    public string? PredictionCol { get; set; }

    /// <summary>Column of the model prediction probabilities</summary>
    [JsonPropertyName("predictionProbaCol")]
    public string? PredictionProbaCol { get; set; }

    /// <summary>Problem type the model aims to solve. Either PROBLEM_TYPE_CLASSIFICATION or PROBLEM_TYPE_REGRESSION</summary>
    [JsonPropertyName("problemType")]
    public string? ProblemType { get; set; }

    /// <summary>Column of the timestamp of predictions</summary>
    [JsonPropertyName("timestampCol")]
    public string? TimestampCol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecInitProviderNotificationsOnFailure
{
    /// <summary></summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecInitProviderNotificationsOnNewClassificationTagDetected
{
    /// <summary></summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecInitProviderNotifications
{
    /// <summary>who to send notifications to on monitor failure.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1alpha1QualityMonitorSpecInitProviderNotificationsOnFailure>? OnFailure { get; set; }

    /// <summary>Who to send notifications to when new data classification tags are detected.</summary>
    [JsonPropertyName("onNewClassificationTagDetected")]
    public IList<V1alpha1QualityMonitorSpecInitProviderNotificationsOnNewClassificationTagDetected>? OnNewClassificationTagDetected { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecInitProviderSchedule
{
    /// <summary>string expression that determines when to run the monitor. See Quartz documentation for examples.</summary>
    [JsonPropertyName("quartzCronExpression")]
    public string? QuartzCronExpression { get; set; }

    /// <summary>string with timezone id (e.g., PST) in which to evaluate the Quartz expression.</summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecInitProviderSnapshot
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecInitProviderTimeSeries
{
    /// <summary>List of granularities to use when aggregating data into time windows based on their timestamp.</summary>
    [JsonPropertyName("granularities")]
    public IList<string>? Granularities { get; set; }

    /// <summary>Column of the timestamp of predictions</summary>
    [JsonPropertyName("timestampCol")]
    public string? TimestampCol { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecInitProvider
{
    /// <summary>- The directory to store the monitoring assets (Eg. Dashboard and Metric Tables)</summary>
    [JsonPropertyName("assetsDir")]
    public string? AssetsDir { get; set; }

    /// <summary>Name of the baseline table from which drift metrics are computed from.Columns in the monitored table should also be present in the baseline table.</summary>
    [JsonPropertyName("baselineTableName")]
    public string? BaselineTableName { get; set; }

    /// <summary>Custom metrics to compute on the monitored table. These can be aggregate metrics, derived metrics (from already computed aggregate metrics), or drift metrics (comparing metrics across time windows).</summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1alpha1QualityMonitorSpecInitProviderCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>The data classification config for the monitor</summary>
    [JsonPropertyName("dataClassificationConfig")]
    public IList<V1alpha1QualityMonitorSpecInitProviderDataClassificationConfig>? DataClassificationConfig { get; set; }

    /// <summary>Configuration for the inference log monitor</summary>
    [JsonPropertyName("inferenceLog")]
    public IList<V1alpha1QualityMonitorSpecInitProviderInferenceLog>? InferenceLog { get; set; }

    /// <summary></summary>
    [JsonPropertyName("latestMonitorFailureMsg")]
    public string? LatestMonitorFailureMsg { get; set; }

    /// <summary>The notification settings for the monitor.  The following optional blocks are supported, each consisting of the single string array field with name email_addresses containing a list of emails to notify:</summary>
    [JsonPropertyName("notifications")]
    public IList<V1alpha1QualityMonitorSpecInitProviderNotifications>? Notifications { get; set; }

    /// <summary>- Schema where output metric tables are created</summary>
    [JsonPropertyName("outputSchemaName")]
    public string? OutputSchemaName { get; set; }

    /// <summary>The schedule for automatically updating and refreshing metric tables.  This block consists of following fields:</summary>
    [JsonPropertyName("schedule")]
    public IList<V1alpha1QualityMonitorSpecInitProviderSchedule>? Schedule { get; set; }

    /// <summary>Whether to skip creating a default dashboard summarizing data quality metrics.  (Can't be updated after creation).</summary>
    [JsonPropertyName("skipBuiltinDashboard")]
    public bool? SkipBuiltinDashboard { get; set; }

    /// <summary>List of column expressions to slice data with for targeted analysis. The data is grouped by each expression independently, resulting in a separate slice for each predicate and its complements. For high-cardinality columns, only the top 100 unique values by frequency will generate slices.</summary>
    [JsonPropertyName("slicingExprs")]
    public IList<string>? SlicingExprs { get; set; }

    /// <summary>Configuration for monitoring snapshot tables.</summary>
    [JsonPropertyName("snapshot")]
    public IList<V1alpha1QualityMonitorSpecInitProviderSnapshot>? Snapshot { get; set; }

    /// <summary>- The full name of the table to attach the monitor too. Its of the format {catalog}.{schema}.{tableName}</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Configuration for monitoring timeseries tables.</summary>
    [JsonPropertyName("timeSeries")]
    public IList<V1alpha1QualityMonitorSpecInitProviderTimeSeries>? TimeSeries { get; set; }

    /// <summary>Optional argument to specify the warehouse for dashboard creation. If not specified, the first running warehouse will be used.  (Can't be updated after creation)</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecProviderConfigRefPolicy
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
public partial class V1alpha1QualityMonitorSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1QualityMonitorSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1alpha1QualityMonitorSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1QualityMonitorSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecPublishConnectionDetailsToMetadata
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
public partial class V1alpha1QualityMonitorSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1QualityMonitorSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1QualityMonitorSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>QualityMonitorSpec defines the desired state of QualityMonitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1QualityMonitorSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1QualityMonitorSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1QualityMonitorSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1QualityMonitorSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1QualityMonitorSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorStatusAtProviderCustomMetrics
{
    /// <summary>create metric definition</summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>Columns on the monitored table to apply the custom metrics to.</summary>
    [JsonPropertyName("inputColumns")]
    public IList<string>? InputColumns { get; set; }

    /// <summary>Name of the custom metric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The output type of the custom metric.</summary>
    [JsonPropertyName("outputDataType")]
    public string? OutputDataType { get; set; }

    /// <summary>The type of the custom metric.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorStatusAtProviderDataClassificationConfig
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorStatusAtProviderInferenceLog
{
    /// <summary>List of granularities to use when aggregating data into time windows based on their timestamp.</summary>
    [JsonPropertyName("granularities")]
    public IList<string>? Granularities { get; set; }

    /// <summary>Column of the model label</summary>
    [JsonPropertyName("labelCol")]
    public string? LabelCol { get; set; }

    /// <summary>Column of the model id or version</summary>
    [JsonPropertyName("modelIdCol")]
    public string? ModelIdCol { get; set; }

    /// <summary>Column of the model prediction</summary>
    [JsonPropertyName("predictionCol")]
    public string? PredictionCol { get; set; }

    /// <summary>Column of the model prediction probabilities</summary>
    [JsonPropertyName("predictionProbaCol")]
    public string? PredictionProbaCol { get; set; }

    /// <summary>Problem type the model aims to solve. Either PROBLEM_TYPE_CLASSIFICATION or PROBLEM_TYPE_REGRESSION</summary>
    [JsonPropertyName("problemType")]
    public string? ProblemType { get; set; }

    /// <summary>Column of the timestamp of predictions</summary>
    [JsonPropertyName("timestampCol")]
    public string? TimestampCol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorStatusAtProviderNotificationsOnFailure
{
    /// <summary></summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorStatusAtProviderNotificationsOnNewClassificationTagDetected
{
    /// <summary></summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorStatusAtProviderNotifications
{
    /// <summary>who to send notifications to on monitor failure.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1alpha1QualityMonitorStatusAtProviderNotificationsOnFailure>? OnFailure { get; set; }

    /// <summary>Who to send notifications to when new data classification tags are detected.</summary>
    [JsonPropertyName("onNewClassificationTagDetected")]
    public IList<V1alpha1QualityMonitorStatusAtProviderNotificationsOnNewClassificationTagDetected>? OnNewClassificationTagDetected { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorStatusAtProviderSchedule
{
    /// <summary>Status of the Monitor</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }

    /// <summary>string expression that determines when to run the monitor. See Quartz documentation for examples.</summary>
    [JsonPropertyName("quartzCronExpression")]
    public string? QuartzCronExpression { get; set; }

    /// <summary>string with timezone id (e.g., PST) in which to evaluate the Quartz expression.</summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorStatusAtProviderSnapshot
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorStatusAtProviderTimeSeries
{
    /// <summary>List of granularities to use when aggregating data into time windows based on their timestamp.</summary>
    [JsonPropertyName("granularities")]
    public IList<string>? Granularities { get; set; }

    /// <summary>Column of the timestamp of predictions</summary>
    [JsonPropertyName("timestampCol")]
    public string? TimestampCol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorStatusAtProvider
{
    /// <summary>- The directory to store the monitoring assets (Eg. Dashboard and Metric Tables)</summary>
    [JsonPropertyName("assetsDir")]
    public string? AssetsDir { get; set; }

    /// <summary>Name of the baseline table from which drift metrics are computed from.Columns in the monitored table should also be present in the baseline table.</summary>
    [JsonPropertyName("baselineTableName")]
    public string? BaselineTableName { get; set; }

    /// <summary>Custom metrics to compute on the monitored table. These can be aggregate metrics, derived metrics (from already computed aggregate metrics), or drift metrics (comparing metrics across time windows).</summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1alpha1QualityMonitorStatusAtProviderCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>The ID of the generated dashboard.</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>The data classification config for the monitor</summary>
    [JsonPropertyName("dataClassificationConfig")]
    public IList<V1alpha1QualityMonitorStatusAtProviderDataClassificationConfig>? DataClassificationConfig { get; set; }

    /// <summary>The full name of the drift metrics table. Format: catalog_name.schema_name.table_name.</summary>
    [JsonPropertyName("driftMetricsTableName")]
    public string? DriftMetricsTableName { get; set; }

    /// <summary>ID of this monitor is the same as the full table name of the format {catalog}.{schema_name}.{table_name}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration for the inference log monitor</summary>
    [JsonPropertyName("inferenceLog")]
    public IList<V1alpha1QualityMonitorStatusAtProviderInferenceLog>? InferenceLog { get; set; }

    /// <summary></summary>
    [JsonPropertyName("latestMonitorFailureMsg")]
    public string? LatestMonitorFailureMsg { get; set; }

    /// <summary>The version of the monitor config (e.g. 1,2,3). If negative, the monitor may be corrupted</summary>
    [JsonPropertyName("monitorVersion")]
    public string? MonitorVersion { get; set; }

    /// <summary>The notification settings for the monitor.  The following optional blocks are supported, each consisting of the single string array field with name email_addresses containing a list of emails to notify:</summary>
    [JsonPropertyName("notifications")]
    public IList<V1alpha1QualityMonitorStatusAtProviderNotifications>? Notifications { get; set; }

    /// <summary>- Schema where output metric tables are created</summary>
    [JsonPropertyName("outputSchemaName")]
    public string? OutputSchemaName { get; set; }

    /// <summary>The full name of the profile metrics table. Format: catalog_name.schema_name.table_name.</summary>
    [JsonPropertyName("profileMetricsTableName")]
    public string? ProfileMetricsTableName { get; set; }

    /// <summary>The schedule for automatically updating and refreshing metric tables.  This block consists of following fields:</summary>
    [JsonPropertyName("schedule")]
    public IList<V1alpha1QualityMonitorStatusAtProviderSchedule>? Schedule { get; set; }

    /// <summary>Whether to skip creating a default dashboard summarizing data quality metrics.  (Can't be updated after creation).</summary>
    [JsonPropertyName("skipBuiltinDashboard")]
    public bool? SkipBuiltinDashboard { get; set; }

    /// <summary>List of column expressions to slice data with for targeted analysis. The data is grouped by each expression independently, resulting in a separate slice for each predicate and its complements. For high-cardinality columns, only the top 100 unique values by frequency will generate slices.</summary>
    [JsonPropertyName("slicingExprs")]
    public IList<string>? SlicingExprs { get; set; }

    /// <summary>Configuration for monitoring snapshot tables.</summary>
    [JsonPropertyName("snapshot")]
    public IList<V1alpha1QualityMonitorStatusAtProviderSnapshot>? Snapshot { get; set; }

    /// <summary>Status of the Monitor</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>- The full name of the table to attach the monitor too. Its of the format {catalog}.{schema}.{tableName}</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Configuration for monitoring timeseries tables.</summary>
    [JsonPropertyName("timeSeries")]
    public IList<V1alpha1QualityMonitorStatusAtProviderTimeSeries>? TimeSeries { get; set; }

    /// <summary>Optional argument to specify the warehouse for dashboard creation. If not specified, the first running warehouse will be used.  (Can't be updated after creation)</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorStatusConditions
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

/// <summary>QualityMonitorStatus defines the observed state of QualityMonitor.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1QualityMonitorStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1QualityMonitorStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1QualityMonitorStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>QualityMonitor is the Schema for the QualityMonitors API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1QualityMonitor : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1QualityMonitorSpec>, IStatus<V1alpha1QualityMonitorStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "QualityMonitor";
    public const string KubeGroup = "unity.databricks.crossplane.io";
    public const string KubePluralName = "qualitymonitors";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>QualityMonitorSpec defines the desired state of QualityMonitor</summary>
    [JsonPropertyName("spec")]
    public V1alpha1QualityMonitorSpec Spec { get; set; }

    /// <summary>QualityMonitorStatus defines the observed state of QualityMonitor.</summary>
    [JsonPropertyName("status")]
    public V1alpha1QualityMonitorStatus? Status { get; set; }
}

/// <summary>QualityMonitor is the Schema for the QualityMonitors API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1QualityMonitorList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1QualityMonitor>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "QualityMonitorList";
    public const string KubeGroup = "unity.databricks.crossplane.io";
    public const string KubePluralName = "qualitymonitors";
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
    public IList<V1alpha1QualityMonitor> Items { get; set; }
}