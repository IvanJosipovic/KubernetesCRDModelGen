using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kinesisanalytics.aws.m.upbound.io;
/// <summary>Application is the Schema for the Applications API. Provides a AWS Kinesis Analytics Application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ApplicationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Application>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ApplicationList";
    public const string KubeGroup = "kinesisanalytics.aws.m.upbound.io";
    public const string KubePluralName = "applications";
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
    public IList<V1beta1Application> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Stream in cloudwatchlogs to populate logStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Stream in cloudwatchlogs to populate logStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelector
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
    public V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnSelector
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
    public V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch log stream options to monitor application errors. See CloudWatch Logging Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderCloudwatchLoggingOptions
{
    /// <summary>The ARN of the CloudWatch Log Stream.</summary>
    [JsonPropertyName("logStreamArn")]
    public string? LogStreamArn { get; set; }

    /// <summary>Reference to a Stream in cloudwatchlogs to populate logStreamArn.</summary>
    [JsonPropertyName("logStreamArnRef")]
    public V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRef? LogStreamArnRef { get; set; }

    /// <summary>Selector for a Stream in cloudwatchlogs to populate logStreamArn.</summary>
    [JsonPropertyName("logStreamArnSelector")]
    public V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelector? LogStreamArnSelector { get; set; }

    /// <summary>The ARN of the IAM Role used to send application messages.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>The Kinesis Firehose configuration for the streaming source. Conflicts with kinesis_stream. See Kinesis Firehose below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInputsKinesisFirehose
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInputsKinesisStreamResourceArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Stream in kinesis to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInputsKinesisStreamResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecForProviderInputsKinesisStreamResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInputsKinesisStreamResourceArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Stream in kinesis to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInputsKinesisStreamResourceArnSelector
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
    public V1beta1ApplicationSpecForProviderInputsKinesisStreamResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInputsKinesisStreamRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInputsKinesisStreamRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecForProviderInputsKinesisStreamRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInputsKinesisStreamRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInputsKinesisStreamRoleArnSelector
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
    public V1beta1ApplicationSpecForProviderInputsKinesisStreamRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The Kinesis Stream configuration for the streaming source. Conflicts with kinesis_firehose. See Kinesis Stream below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInputsKinesisStream
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a Stream in kinesis to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta1ApplicationSpecForProviderInputsKinesisStreamResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a Stream in kinesis to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta1ApplicationSpecForProviderInputsKinesisStreamResourceArnSelector? ResourceArnSelector { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1ApplicationSpecForProviderInputsKinesisStreamRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1ApplicationSpecForProviderInputsKinesisStreamRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>The number of Parallel in-application streams to create. See Parallelism below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInputsParallelism
{
    /// <summary>The Count of streams.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>The Lambda function configuration. See Lambda below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInputsProcessingConfigurationLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Processing Configuration to transform records as they are received from the stream. See Processing Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInputsProcessingConfiguration
{
    /// <summary>The Lambda function configuration. See Lambda below for more details.</summary>
    [JsonPropertyName("lambda")]
    public V1beta1ApplicationSpecForProviderInputsProcessingConfigurationLambda? Lambda { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInputsSchemaRecordColumns
{
    /// <summary>The Mapping reference to the data element.</summary>
    [JsonPropertyName("mapping")]
    public string? Mapping { get; set; }

    /// <summary>Name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The SQL Type of the column.</summary>
    [JsonPropertyName("sqlType")]
    public string? SqlType { get; set; }
}

/// <summary>Mapping information when the record format uses delimiters. See CSV Mapping Parameters below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInputsSchemaRecordFormatMappingParametersCsv
{
    /// <summary>The Column Delimiter.</summary>
    [JsonPropertyName("recordColumnDelimiter")]
    public string? RecordColumnDelimiter { get; set; }

    /// <summary>The Row Delimiter.</summary>
    [JsonPropertyName("recordRowDelimiter")]
    public string? RecordRowDelimiter { get; set; }
}

/// <summary>Mapping information when JSON is the record format on the streaming source. See JSON Mapping Parameters below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInputsSchemaRecordFormatMappingParametersJson
{
    /// <summary>Path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>The Mapping Information for the record format. See Mapping Parameters below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInputsSchemaRecordFormatMappingParameters
{
    /// <summary>Mapping information when the record format uses delimiters. See CSV Mapping Parameters below for more details.</summary>
    [JsonPropertyName("csv")]
    public V1beta1ApplicationSpecForProviderInputsSchemaRecordFormatMappingParametersCsv? Csv { get; set; }

    /// <summary>Mapping information when JSON is the record format on the streaming source. See JSON Mapping Parameters below for more details.</summary>
    [JsonPropertyName("json")]
    public V1beta1ApplicationSpecForProviderInputsSchemaRecordFormatMappingParametersJson? Json { get; set; }
}

/// <summary>The Record Format and mapping information to schematize a record. See Record Format below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInputsSchemaRecordFormat
{
    /// <summary>The Mapping Information for the record format. See Mapping Parameters below for more details.</summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta1ApplicationSpecForProviderInputsSchemaRecordFormatMappingParameters? MappingParameters { get; set; }
}

/// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInputsSchema
{
    /// <summary>The Record Column mapping for the streaming source data element. See Record Columns below for more details.</summary>
    [JsonPropertyName("recordColumns")]
    public IList<V1beta1ApplicationSpecForProviderInputsSchemaRecordColumns>? RecordColumns { get; set; }

    /// <summary>The Encoding of the record in the streaming source.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>The Record Format and mapping information to schematize a record. See Record Format below for more details.</summary>
    [JsonPropertyName("recordFormat")]
    public V1beta1ApplicationSpecForProviderInputsSchemaRecordFormat? RecordFormat { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInputsStartingPositionConfiguration
{
    /// <summary>The starting position on the stream. Valid values: LAST_STOPPED_POINT, NOW, TRIM_HORIZON.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }
}

/// <summary>Input configuration of the application. See Inputs below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInputs
{
    /// <summary>The Kinesis Firehose configuration for the streaming source. Conflicts with kinesis_stream. See Kinesis Firehose below for more details.</summary>
    [JsonPropertyName("kinesisFirehose")]
    public V1beta1ApplicationSpecForProviderInputsKinesisFirehose? KinesisFirehose { get; set; }

    /// <summary>The Kinesis Stream configuration for the streaming source. Conflicts with kinesis_firehose. See Kinesis Stream below for more details.</summary>
    [JsonPropertyName("kinesisStream")]
    public V1beta1ApplicationSpecForProviderInputsKinesisStream? KinesisStream { get; set; }

    /// <summary>The Name Prefix to use when creating an in-application stream.</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>The number of Parallel in-application streams to create. See Parallelism below for more details.</summary>
    [JsonPropertyName("parallelism")]
    public V1beta1ApplicationSpecForProviderInputsParallelism? Parallelism { get; set; }

    /// <summary>The Processing Configuration to transform records as they are received from the stream. See Processing Configuration below for more details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1ApplicationSpecForProviderInputsProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
    [JsonPropertyName("schema")]
    public V1beta1ApplicationSpecForProviderInputsSchema? Schema { get; set; }

    /// <summary>The point at which the application starts processing records from the streaming source. See Starting Position Configuration below for more details.</summary>
    [JsonPropertyName("startingPositionConfiguration")]
    public IList<V1beta1ApplicationSpecForProviderInputsStartingPositionConfiguration>? StartingPositionConfiguration { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnSelector
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
    public V1beta1ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnSelector
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
    public V1beta1ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The Kinesis Firehose configuration for the destination stream. Conflicts with kinesis_stream. See Kinesis Firehose below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderOutputsKinesisFirehose
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta1ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta1ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnSelector? ResourceArnSelector { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>The Kinesis Stream configuration for the destination stream. Conflicts with kinesis_firehose. See Kinesis Stream below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderOutputsKinesisStream
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Lambda function destination. See Lambda below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderOutputsLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Schema format of the data written to the destination. See Destination Schema below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderOutputsSchema
{
    /// <summary>The Format Type of the records on the output stream. Can be CSV or JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderOutputs
{
    /// <summary>The Kinesis Firehose configuration for the destination stream. Conflicts with kinesis_stream. See Kinesis Firehose below for more details.</summary>
    [JsonPropertyName("kinesisFirehose")]
    public V1beta1ApplicationSpecForProviderOutputsKinesisFirehose? KinesisFirehose { get; set; }

    /// <summary>The Kinesis Stream configuration for the destination stream. Conflicts with kinesis_firehose. See Kinesis Stream below for more details.</summary>
    [JsonPropertyName("kinesisStream")]
    public V1beta1ApplicationSpecForProviderOutputsKinesisStream? KinesisStream { get; set; }

    /// <summary>The Lambda function destination. See Lambda below for more details.</summary>
    [JsonPropertyName("lambda")]
    public V1beta1ApplicationSpecForProviderOutputsLambda? Lambda { get; set; }

    /// <summary>The Name of the in-application stream.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Schema format of the data written to the destination. See Destination Schema below for more details.</summary>
    [JsonPropertyName("schema")]
    public V1beta1ApplicationSpecForProviderOutputsSchema? Schema { get; set; }
}

/// <summary>The S3 configuration for the reference data source. See S3 Reference below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderReferenceDataSourcesS3
{
    /// <summary>The S3 Bucket ARN.</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>The File Key name containing reference data.</summary>
    [JsonPropertyName("fileKey")]
    public string? FileKey { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderReferenceDataSourcesSchemaRecordColumns
{
    /// <summary>The Mapping reference to the data element.</summary>
    [JsonPropertyName("mapping")]
    public string? Mapping { get; set; }

    /// <summary>Name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The SQL Type of the column.</summary>
    [JsonPropertyName("sqlType")]
    public string? SqlType { get; set; }
}

/// <summary>Mapping information when the record format uses delimiters. See CSV Mapping Parameters below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderReferenceDataSourcesSchemaRecordFormatMappingParametersCsv
{
    /// <summary>The Column Delimiter.</summary>
    [JsonPropertyName("recordColumnDelimiter")]
    public string? RecordColumnDelimiter { get; set; }

    /// <summary>The Row Delimiter.</summary>
    [JsonPropertyName("recordRowDelimiter")]
    public string? RecordRowDelimiter { get; set; }
}

/// <summary>Mapping information when JSON is the record format on the streaming source. See JSON Mapping Parameters below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderReferenceDataSourcesSchemaRecordFormatMappingParametersJson
{
    /// <summary>Path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>The Mapping Information for the record format. See Mapping Parameters below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderReferenceDataSourcesSchemaRecordFormatMappingParameters
{
    /// <summary>Mapping information when the record format uses delimiters. See CSV Mapping Parameters below for more details.</summary>
    [JsonPropertyName("csv")]
    public V1beta1ApplicationSpecForProviderReferenceDataSourcesSchemaRecordFormatMappingParametersCsv? Csv { get; set; }

    /// <summary>Mapping information when JSON is the record format on the streaming source. See JSON Mapping Parameters below for more details.</summary>
    [JsonPropertyName("json")]
    public V1beta1ApplicationSpecForProviderReferenceDataSourcesSchemaRecordFormatMappingParametersJson? Json { get; set; }
}

/// <summary>The Record Format and mapping information to schematize a record. See Record Format below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderReferenceDataSourcesSchemaRecordFormat
{
    /// <summary>The Mapping Information for the record format. See Mapping Parameters below for more details.</summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta1ApplicationSpecForProviderReferenceDataSourcesSchemaRecordFormatMappingParameters? MappingParameters { get; set; }
}

/// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderReferenceDataSourcesSchema
{
    /// <summary>The Record Column mapping for the streaming source data element. See Record Columns below for more details.</summary>
    [JsonPropertyName("recordColumns")]
    public IList<V1beta1ApplicationSpecForProviderReferenceDataSourcesSchemaRecordColumns>? RecordColumns { get; set; }

    /// <summary>The Encoding of the record in the streaming source.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>The Record Format and mapping information to schematize a record. See Record Format below for more details.</summary>
    [JsonPropertyName("recordFormat")]
    public V1beta1ApplicationSpecForProviderReferenceDataSourcesSchemaRecordFormat? RecordFormat { get; set; }
}

/// <summary>An S3 Reference Data Source for the application. See Reference Data Sources below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderReferenceDataSources
{
    /// <summary>The S3 configuration for the reference data source. See S3 Reference below for more details.</summary>
    [JsonPropertyName("s3")]
    public V1beta1ApplicationSpecForProviderReferenceDataSourcesS3? S3 { get; set; }

    /// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
    [JsonPropertyName("schema")]
    public V1beta1ApplicationSpecForProviderReferenceDataSourcesSchema? Schema { get; set; }

    /// <summary>The in-application Table Name.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProvider
{
    /// <summary>The CloudWatch log stream options to monitor application errors. See CloudWatch Logging Options below for more details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1ApplicationSpecForProviderCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>SQL Code to transform input data, and generate output.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Description of the application.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Input configuration of the application. See Inputs below for more details.</summary>
    [JsonPropertyName("inputs")]
    public V1beta1ApplicationSpecForProviderInputs? Inputs { get; set; }

    /// <summary>Output destination configuration of the application. See Outputs below for more details.</summary>
    [JsonPropertyName("outputs")]
    public IList<V1beta1ApplicationSpecForProviderOutputs>? Outputs { get; set; }

    /// <summary>An S3 Reference Data Source for the application. See Reference Data Sources below for more details.</summary>
    [JsonPropertyName("referenceDataSources")]
    public V1beta1ApplicationSpecForProviderReferenceDataSources? ReferenceDataSources { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Whether to start or stop the Kinesis Analytics Application. To start an application, an input with a defined starting_position must be configured. To modify an application's starting position, first stop the application by setting start_application = false, then update starting_position and set start_application = true.</summary>
    [JsonPropertyName("startApplication")]
    public bool? StartApplication { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Stream in cloudwatchlogs to populate logStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Stream in cloudwatchlogs to populate logStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelector
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
    public V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnSelector
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
    public V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch log stream options to monitor application errors. See CloudWatch Logging Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptions
{
    /// <summary>The ARN of the CloudWatch Log Stream.</summary>
    [JsonPropertyName("logStreamArn")]
    public string? LogStreamArn { get; set; }

    /// <summary>Reference to a Stream in cloudwatchlogs to populate logStreamArn.</summary>
    [JsonPropertyName("logStreamArnRef")]
    public V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRef? LogStreamArnRef { get; set; }

    /// <summary>Selector for a Stream in cloudwatchlogs to populate logStreamArn.</summary>
    [JsonPropertyName("logStreamArnSelector")]
    public V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelector? LogStreamArnSelector { get; set; }

    /// <summary>The ARN of the IAM Role used to send application messages.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>The Kinesis Firehose configuration for the streaming source. Conflicts with kinesis_stream. See Kinesis Firehose below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInputsKinesisFirehose
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInputsKinesisStreamResourceArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Stream in kinesis to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInputsKinesisStreamResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecInitProviderInputsKinesisStreamResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInputsKinesisStreamResourceArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Stream in kinesis to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInputsKinesisStreamResourceArnSelector
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
    public V1beta1ApplicationSpecInitProviderInputsKinesisStreamResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInputsKinesisStreamRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInputsKinesisStreamRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecInitProviderInputsKinesisStreamRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInputsKinesisStreamRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInputsKinesisStreamRoleArnSelector
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
    public V1beta1ApplicationSpecInitProviderInputsKinesisStreamRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The Kinesis Stream configuration for the streaming source. Conflicts with kinesis_firehose. See Kinesis Stream below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInputsKinesisStream
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a Stream in kinesis to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta1ApplicationSpecInitProviderInputsKinesisStreamResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a Stream in kinesis to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta1ApplicationSpecInitProviderInputsKinesisStreamResourceArnSelector? ResourceArnSelector { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1ApplicationSpecInitProviderInputsKinesisStreamRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1ApplicationSpecInitProviderInputsKinesisStreamRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>The number of Parallel in-application streams to create. See Parallelism below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInputsParallelism
{
    /// <summary>The Count of streams.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>The Lambda function configuration. See Lambda below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInputsProcessingConfigurationLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Processing Configuration to transform records as they are received from the stream. See Processing Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInputsProcessingConfiguration
{
    /// <summary>The Lambda function configuration. See Lambda below for more details.</summary>
    [JsonPropertyName("lambda")]
    public V1beta1ApplicationSpecInitProviderInputsProcessingConfigurationLambda? Lambda { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInputsSchemaRecordColumns
{
    /// <summary>The Mapping reference to the data element.</summary>
    [JsonPropertyName("mapping")]
    public string? Mapping { get; set; }

    /// <summary>Name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The SQL Type of the column.</summary>
    [JsonPropertyName("sqlType")]
    public string? SqlType { get; set; }
}

/// <summary>Mapping information when the record format uses delimiters. See CSV Mapping Parameters below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInputsSchemaRecordFormatMappingParametersCsv
{
    /// <summary>The Column Delimiter.</summary>
    [JsonPropertyName("recordColumnDelimiter")]
    public string? RecordColumnDelimiter { get; set; }

    /// <summary>The Row Delimiter.</summary>
    [JsonPropertyName("recordRowDelimiter")]
    public string? RecordRowDelimiter { get; set; }
}

/// <summary>Mapping information when JSON is the record format on the streaming source. See JSON Mapping Parameters below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInputsSchemaRecordFormatMappingParametersJson
{
    /// <summary>Path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>The Mapping Information for the record format. See Mapping Parameters below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInputsSchemaRecordFormatMappingParameters
{
    /// <summary>Mapping information when the record format uses delimiters. See CSV Mapping Parameters below for more details.</summary>
    [JsonPropertyName("csv")]
    public V1beta1ApplicationSpecInitProviderInputsSchemaRecordFormatMappingParametersCsv? Csv { get; set; }

    /// <summary>Mapping information when JSON is the record format on the streaming source. See JSON Mapping Parameters below for more details.</summary>
    [JsonPropertyName("json")]
    public V1beta1ApplicationSpecInitProviderInputsSchemaRecordFormatMappingParametersJson? Json { get; set; }
}

/// <summary>The Record Format and mapping information to schematize a record. See Record Format below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInputsSchemaRecordFormat
{
    /// <summary>The Mapping Information for the record format. See Mapping Parameters below for more details.</summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta1ApplicationSpecInitProviderInputsSchemaRecordFormatMappingParameters? MappingParameters { get; set; }
}

/// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInputsSchema
{
    /// <summary>The Record Column mapping for the streaming source data element. See Record Columns below for more details.</summary>
    [JsonPropertyName("recordColumns")]
    public IList<V1beta1ApplicationSpecInitProviderInputsSchemaRecordColumns>? RecordColumns { get; set; }

    /// <summary>The Encoding of the record in the streaming source.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>The Record Format and mapping information to schematize a record. See Record Format below for more details.</summary>
    [JsonPropertyName("recordFormat")]
    public V1beta1ApplicationSpecInitProviderInputsSchemaRecordFormat? RecordFormat { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInputsStartingPositionConfiguration
{
    /// <summary>The starting position on the stream. Valid values: LAST_STOPPED_POINT, NOW, TRIM_HORIZON.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }
}

/// <summary>Input configuration of the application. See Inputs below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInputs
{
    /// <summary>The Kinesis Firehose configuration for the streaming source. Conflicts with kinesis_stream. See Kinesis Firehose below for more details.</summary>
    [JsonPropertyName("kinesisFirehose")]
    public V1beta1ApplicationSpecInitProviderInputsKinesisFirehose? KinesisFirehose { get; set; }

    /// <summary>The Kinesis Stream configuration for the streaming source. Conflicts with kinesis_firehose. See Kinesis Stream below for more details.</summary>
    [JsonPropertyName("kinesisStream")]
    public V1beta1ApplicationSpecInitProviderInputsKinesisStream? KinesisStream { get; set; }

    /// <summary>The Name Prefix to use when creating an in-application stream.</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>The number of Parallel in-application streams to create. See Parallelism below for more details.</summary>
    [JsonPropertyName("parallelism")]
    public V1beta1ApplicationSpecInitProviderInputsParallelism? Parallelism { get; set; }

    /// <summary>The Processing Configuration to transform records as they are received from the stream. See Processing Configuration below for more details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1ApplicationSpecInitProviderInputsProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
    [JsonPropertyName("schema")]
    public V1beta1ApplicationSpecInitProviderInputsSchema? Schema { get; set; }

    /// <summary>The point at which the application starts processing records from the streaming source. See Starting Position Configuration below for more details.</summary>
    [JsonPropertyName("startingPositionConfiguration")]
    public IList<V1beta1ApplicationSpecInitProviderInputsStartingPositionConfiguration>? StartingPositionConfiguration { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnSelector
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
    public V1beta1ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnSelector
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
    public V1beta1ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The Kinesis Firehose configuration for the destination stream. Conflicts with kinesis_stream. See Kinesis Firehose below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderOutputsKinesisFirehose
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta1ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta1ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnSelector? ResourceArnSelector { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>The Kinesis Stream configuration for the destination stream. Conflicts with kinesis_firehose. See Kinesis Stream below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderOutputsKinesisStream
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Lambda function destination. See Lambda below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderOutputsLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Schema format of the data written to the destination. See Destination Schema below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderOutputsSchema
{
    /// <summary>The Format Type of the records on the output stream. Can be CSV or JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderOutputs
{
    /// <summary>The Kinesis Firehose configuration for the destination stream. Conflicts with kinesis_stream. See Kinesis Firehose below for more details.</summary>
    [JsonPropertyName("kinesisFirehose")]
    public V1beta1ApplicationSpecInitProviderOutputsKinesisFirehose? KinesisFirehose { get; set; }

    /// <summary>The Kinesis Stream configuration for the destination stream. Conflicts with kinesis_firehose. See Kinesis Stream below for more details.</summary>
    [JsonPropertyName("kinesisStream")]
    public V1beta1ApplicationSpecInitProviderOutputsKinesisStream? KinesisStream { get; set; }

    /// <summary>The Lambda function destination. See Lambda below for more details.</summary>
    [JsonPropertyName("lambda")]
    public V1beta1ApplicationSpecInitProviderOutputsLambda? Lambda { get; set; }

    /// <summary>The Name of the in-application stream.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Schema format of the data written to the destination. See Destination Schema below for more details.</summary>
    [JsonPropertyName("schema")]
    public V1beta1ApplicationSpecInitProviderOutputsSchema? Schema { get; set; }
}

/// <summary>The S3 configuration for the reference data source. See S3 Reference below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderReferenceDataSourcesS3
{
    /// <summary>The S3 Bucket ARN.</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>The File Key name containing reference data.</summary>
    [JsonPropertyName("fileKey")]
    public string? FileKey { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderReferenceDataSourcesSchemaRecordColumns
{
    /// <summary>The Mapping reference to the data element.</summary>
    [JsonPropertyName("mapping")]
    public string? Mapping { get; set; }

    /// <summary>Name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The SQL Type of the column.</summary>
    [JsonPropertyName("sqlType")]
    public string? SqlType { get; set; }
}

/// <summary>Mapping information when the record format uses delimiters. See CSV Mapping Parameters below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderReferenceDataSourcesSchemaRecordFormatMappingParametersCsv
{
    /// <summary>The Column Delimiter.</summary>
    [JsonPropertyName("recordColumnDelimiter")]
    public string? RecordColumnDelimiter { get; set; }

    /// <summary>The Row Delimiter.</summary>
    [JsonPropertyName("recordRowDelimiter")]
    public string? RecordRowDelimiter { get; set; }
}

/// <summary>Mapping information when JSON is the record format on the streaming source. See JSON Mapping Parameters below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderReferenceDataSourcesSchemaRecordFormatMappingParametersJson
{
    /// <summary>Path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>The Mapping Information for the record format. See Mapping Parameters below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderReferenceDataSourcesSchemaRecordFormatMappingParameters
{
    /// <summary>Mapping information when the record format uses delimiters. See CSV Mapping Parameters below for more details.</summary>
    [JsonPropertyName("csv")]
    public V1beta1ApplicationSpecInitProviderReferenceDataSourcesSchemaRecordFormatMappingParametersCsv? Csv { get; set; }

    /// <summary>Mapping information when JSON is the record format on the streaming source. See JSON Mapping Parameters below for more details.</summary>
    [JsonPropertyName("json")]
    public V1beta1ApplicationSpecInitProviderReferenceDataSourcesSchemaRecordFormatMappingParametersJson? Json { get; set; }
}

/// <summary>The Record Format and mapping information to schematize a record. See Record Format below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderReferenceDataSourcesSchemaRecordFormat
{
    /// <summary>The Mapping Information for the record format. See Mapping Parameters below for more details.</summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta1ApplicationSpecInitProviderReferenceDataSourcesSchemaRecordFormatMappingParameters? MappingParameters { get; set; }
}

/// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderReferenceDataSourcesSchema
{
    /// <summary>The Record Column mapping for the streaming source data element. See Record Columns below for more details.</summary>
    [JsonPropertyName("recordColumns")]
    public IList<V1beta1ApplicationSpecInitProviderReferenceDataSourcesSchemaRecordColumns>? RecordColumns { get; set; }

    /// <summary>The Encoding of the record in the streaming source.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>The Record Format and mapping information to schematize a record. See Record Format below for more details.</summary>
    [JsonPropertyName("recordFormat")]
    public V1beta1ApplicationSpecInitProviderReferenceDataSourcesSchemaRecordFormat? RecordFormat { get; set; }
}

/// <summary>An S3 Reference Data Source for the application. See Reference Data Sources below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderReferenceDataSources
{
    /// <summary>The S3 configuration for the reference data source. See S3 Reference below for more details.</summary>
    [JsonPropertyName("s3")]
    public V1beta1ApplicationSpecInitProviderReferenceDataSourcesS3? S3 { get; set; }

    /// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
    [JsonPropertyName("schema")]
    public V1beta1ApplicationSpecInitProviderReferenceDataSourcesSchema? Schema { get; set; }

    /// <summary>The in-application Table Name.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProvider
{
    /// <summary>The CloudWatch log stream options to monitor application errors. See CloudWatch Logging Options below for more details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1ApplicationSpecInitProviderCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>SQL Code to transform input data, and generate output.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Description of the application.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Input configuration of the application. See Inputs below for more details.</summary>
    [JsonPropertyName("inputs")]
    public V1beta1ApplicationSpecInitProviderInputs? Inputs { get; set; }

    /// <summary>Output destination configuration of the application. See Outputs below for more details.</summary>
    [JsonPropertyName("outputs")]
    public IList<V1beta1ApplicationSpecInitProviderOutputs>? Outputs { get; set; }

    /// <summary>An S3 Reference Data Source for the application. See Reference Data Sources below for more details.</summary>
    [JsonPropertyName("referenceDataSources")]
    public V1beta1ApplicationSpecInitProviderReferenceDataSources? ReferenceDataSources { get; set; }

    /// <summary>Whether to start or stop the Kinesis Analytics Application. To start an application, an input with a defined starting_position must be configured. To modify an application's starting position, first stop the application by setting start_application = false, then update starting_position and set start_application = true.</summary>
    [JsonPropertyName("startApplication")]
    public bool? StartApplication { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecProviderConfigRef
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
public partial class V1beta1ApplicationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ApplicationSpec defines the desired state of Application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ApplicationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ApplicationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ApplicationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ApplicationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The CloudWatch log stream options to monitor application errors. See CloudWatch Logging Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderCloudwatchLoggingOptions
{
    /// <summary>The ARN of the Kinesis Analytics Application.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ARN of the CloudWatch Log Stream.</summary>
    [JsonPropertyName("logStreamArn")]
    public string? LogStreamArn { get; set; }

    /// <summary>The ARN of the IAM Role used to send application messages.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Kinesis Firehose configuration for the streaming source. Conflicts with kinesis_stream. See Kinesis Firehose below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderInputsKinesisFirehose
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Kinesis Stream configuration for the streaming source. Conflicts with kinesis_firehose. See Kinesis Stream below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderInputsKinesisStream
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The number of Parallel in-application streams to create. See Parallelism below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderInputsParallelism
{
    /// <summary>The Count of streams.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>The Lambda function configuration. See Lambda below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderInputsProcessingConfigurationLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Processing Configuration to transform records as they are received from the stream. See Processing Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderInputsProcessingConfiguration
{
    /// <summary>The Lambda function configuration. See Lambda below for more details.</summary>
    [JsonPropertyName("lambda")]
    public V1beta1ApplicationStatusAtProviderInputsProcessingConfigurationLambda? Lambda { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderInputsSchemaRecordColumns
{
    /// <summary>The Mapping reference to the data element.</summary>
    [JsonPropertyName("mapping")]
    public string? Mapping { get; set; }

    /// <summary>Name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The SQL Type of the column.</summary>
    [JsonPropertyName("sqlType")]
    public string? SqlType { get; set; }
}

/// <summary>Mapping information when the record format uses delimiters. See CSV Mapping Parameters below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderInputsSchemaRecordFormatMappingParametersCsv
{
    /// <summary>The Column Delimiter.</summary>
    [JsonPropertyName("recordColumnDelimiter")]
    public string? RecordColumnDelimiter { get; set; }

    /// <summary>The Row Delimiter.</summary>
    [JsonPropertyName("recordRowDelimiter")]
    public string? RecordRowDelimiter { get; set; }
}

/// <summary>Mapping information when JSON is the record format on the streaming source. See JSON Mapping Parameters below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderInputsSchemaRecordFormatMappingParametersJson
{
    /// <summary>Path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>The Mapping Information for the record format. See Mapping Parameters below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderInputsSchemaRecordFormatMappingParameters
{
    /// <summary>Mapping information when the record format uses delimiters. See CSV Mapping Parameters below for more details.</summary>
    [JsonPropertyName("csv")]
    public V1beta1ApplicationStatusAtProviderInputsSchemaRecordFormatMappingParametersCsv? Csv { get; set; }

    /// <summary>Mapping information when JSON is the record format on the streaming source. See JSON Mapping Parameters below for more details.</summary>
    [JsonPropertyName("json")]
    public V1beta1ApplicationStatusAtProviderInputsSchemaRecordFormatMappingParametersJson? Json { get; set; }
}

/// <summary>The Record Format and mapping information to schematize a record. See Record Format below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderInputsSchemaRecordFormat
{
    /// <summary>The Mapping Information for the record format. See Mapping Parameters below for more details.</summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta1ApplicationStatusAtProviderInputsSchemaRecordFormatMappingParameters? MappingParameters { get; set; }

    /// <summary>The Format Type of the records on the output stream. Can be CSV or JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderInputsSchema
{
    /// <summary>The Record Column mapping for the streaming source data element. See Record Columns below for more details.</summary>
    [JsonPropertyName("recordColumns")]
    public IList<V1beta1ApplicationStatusAtProviderInputsSchemaRecordColumns>? RecordColumns { get; set; }

    /// <summary>The Encoding of the record in the streaming source.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>The Record Format and mapping information to schematize a record. See Record Format below for more details.</summary>
    [JsonPropertyName("recordFormat")]
    public V1beta1ApplicationStatusAtProviderInputsSchemaRecordFormat? RecordFormat { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderInputsStartingPositionConfiguration
{
    /// <summary>The starting position on the stream. Valid values: LAST_STOPPED_POINT, NOW, TRIM_HORIZON.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }
}

/// <summary>Input configuration of the application. See Inputs below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderInputs
{
    /// <summary>The ARN of the Kinesis Analytics Application.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Kinesis Firehose configuration for the streaming source. Conflicts with kinesis_stream. See Kinesis Firehose below for more details.</summary>
    [JsonPropertyName("kinesisFirehose")]
    public V1beta1ApplicationStatusAtProviderInputsKinesisFirehose? KinesisFirehose { get; set; }

    /// <summary>The Kinesis Stream configuration for the streaming source. Conflicts with kinesis_firehose. See Kinesis Stream below for more details.</summary>
    [JsonPropertyName("kinesisStream")]
    public V1beta1ApplicationStatusAtProviderInputsKinesisStream? KinesisStream { get; set; }

    /// <summary>The Name Prefix to use when creating an in-application stream.</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>The number of Parallel in-application streams to create. See Parallelism below for more details.</summary>
    [JsonPropertyName("parallelism")]
    public V1beta1ApplicationStatusAtProviderInputsParallelism? Parallelism { get; set; }

    /// <summary>The Processing Configuration to transform records as they are received from the stream. See Processing Configuration below for more details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1ApplicationStatusAtProviderInputsProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
    [JsonPropertyName("schema")]
    public V1beta1ApplicationStatusAtProviderInputsSchema? Schema { get; set; }

    /// <summary>The point at which the application starts processing records from the streaming source. See Starting Position Configuration below for more details.</summary>
    [JsonPropertyName("startingPositionConfiguration")]
    public IList<V1beta1ApplicationStatusAtProviderInputsStartingPositionConfiguration>? StartingPositionConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("streamNames")]
    public IList<string>? StreamNames { get; set; }
}

/// <summary>The Kinesis Firehose configuration for the destination stream. Conflicts with kinesis_stream. See Kinesis Firehose below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderOutputsKinesisFirehose
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Kinesis Stream configuration for the destination stream. Conflicts with kinesis_firehose. See Kinesis Stream below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderOutputsKinesisStream
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Lambda function destination. See Lambda below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderOutputsLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Schema format of the data written to the destination. See Destination Schema below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderOutputsSchema
{
    /// <summary>The Format Type of the records on the output stream. Can be CSV or JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderOutputs
{
    /// <summary>The ARN of the Kinesis Analytics Application.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Kinesis Firehose configuration for the destination stream. Conflicts with kinesis_stream. See Kinesis Firehose below for more details.</summary>
    [JsonPropertyName("kinesisFirehose")]
    public V1beta1ApplicationStatusAtProviderOutputsKinesisFirehose? KinesisFirehose { get; set; }

    /// <summary>The Kinesis Stream configuration for the destination stream. Conflicts with kinesis_firehose. See Kinesis Stream below for more details.</summary>
    [JsonPropertyName("kinesisStream")]
    public V1beta1ApplicationStatusAtProviderOutputsKinesisStream? KinesisStream { get; set; }

    /// <summary>The Lambda function destination. See Lambda below for more details.</summary>
    [JsonPropertyName("lambda")]
    public V1beta1ApplicationStatusAtProviderOutputsLambda? Lambda { get; set; }

    /// <summary>The Name of the in-application stream.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Schema format of the data written to the destination. See Destination Schema below for more details.</summary>
    [JsonPropertyName("schema")]
    public V1beta1ApplicationStatusAtProviderOutputsSchema? Schema { get; set; }
}

/// <summary>The S3 configuration for the reference data source. See S3 Reference below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderReferenceDataSourcesS3
{
    /// <summary>The S3 Bucket ARN.</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>The File Key name containing reference data.</summary>
    [JsonPropertyName("fileKey")]
    public string? FileKey { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderReferenceDataSourcesSchemaRecordColumns
{
    /// <summary>The Mapping reference to the data element.</summary>
    [JsonPropertyName("mapping")]
    public string? Mapping { get; set; }

    /// <summary>Name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The SQL Type of the column.</summary>
    [JsonPropertyName("sqlType")]
    public string? SqlType { get; set; }
}

/// <summary>Mapping information when the record format uses delimiters. See CSV Mapping Parameters below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderReferenceDataSourcesSchemaRecordFormatMappingParametersCsv
{
    /// <summary>The Column Delimiter.</summary>
    [JsonPropertyName("recordColumnDelimiter")]
    public string? RecordColumnDelimiter { get; set; }

    /// <summary>The Row Delimiter.</summary>
    [JsonPropertyName("recordRowDelimiter")]
    public string? RecordRowDelimiter { get; set; }
}

/// <summary>Mapping information when JSON is the record format on the streaming source. See JSON Mapping Parameters below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderReferenceDataSourcesSchemaRecordFormatMappingParametersJson
{
    /// <summary>Path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>The Mapping Information for the record format. See Mapping Parameters below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderReferenceDataSourcesSchemaRecordFormatMappingParameters
{
    /// <summary>Mapping information when the record format uses delimiters. See CSV Mapping Parameters below for more details.</summary>
    [JsonPropertyName("csv")]
    public V1beta1ApplicationStatusAtProviderReferenceDataSourcesSchemaRecordFormatMappingParametersCsv? Csv { get; set; }

    /// <summary>Mapping information when JSON is the record format on the streaming source. See JSON Mapping Parameters below for more details.</summary>
    [JsonPropertyName("json")]
    public V1beta1ApplicationStatusAtProviderReferenceDataSourcesSchemaRecordFormatMappingParametersJson? Json { get; set; }
}

/// <summary>The Record Format and mapping information to schematize a record. See Record Format below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderReferenceDataSourcesSchemaRecordFormat
{
    /// <summary>The Mapping Information for the record format. See Mapping Parameters below for more details.</summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta1ApplicationStatusAtProviderReferenceDataSourcesSchemaRecordFormatMappingParameters? MappingParameters { get; set; }

    /// <summary>The Format Type of the records on the output stream. Can be CSV or JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderReferenceDataSourcesSchema
{
    /// <summary>The Record Column mapping for the streaming source data element. See Record Columns below for more details.</summary>
    [JsonPropertyName("recordColumns")]
    public IList<V1beta1ApplicationStatusAtProviderReferenceDataSourcesSchemaRecordColumns>? RecordColumns { get; set; }

    /// <summary>The Encoding of the record in the streaming source.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>The Record Format and mapping information to schematize a record. See Record Format below for more details.</summary>
    [JsonPropertyName("recordFormat")]
    public V1beta1ApplicationStatusAtProviderReferenceDataSourcesSchemaRecordFormat? RecordFormat { get; set; }
}

/// <summary>An S3 Reference Data Source for the application. See Reference Data Sources below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderReferenceDataSources
{
    /// <summary>The ARN of the Kinesis Analytics Application.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The S3 configuration for the reference data source. See S3 Reference below for more details.</summary>
    [JsonPropertyName("s3")]
    public V1beta1ApplicationStatusAtProviderReferenceDataSourcesS3? S3 { get; set; }

    /// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
    [JsonPropertyName("schema")]
    public V1beta1ApplicationStatusAtProviderReferenceDataSourcesSchema? Schema { get; set; }

    /// <summary>The in-application Table Name.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProvider
{
    /// <summary>The ARN of the Kinesis Analytics Appliation.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The CloudWatch log stream options to monitor application errors. See CloudWatch Logging Options below for more details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1ApplicationStatusAtProviderCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>SQL Code to transform input data, and generate output.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>The Timestamp when the application version was created.</summary>
    [JsonPropertyName("createTimestamp")]
    public string? CreateTimestamp { get; set; }

    /// <summary>Description of the application.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ARN of the Kinesis Analytics Application.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Input configuration of the application. See Inputs below for more details.</summary>
    [JsonPropertyName("inputs")]
    public V1beta1ApplicationStatusAtProviderInputs? Inputs { get; set; }

    /// <summary>The Timestamp when the application was last updated.</summary>
    [JsonPropertyName("lastUpdateTimestamp")]
    public string? LastUpdateTimestamp { get; set; }

    /// <summary>Output destination configuration of the application. See Outputs below for more details.</summary>
    [JsonPropertyName("outputs")]
    public IList<V1beta1ApplicationStatusAtProviderOutputs>? Outputs { get; set; }

    /// <summary>An S3 Reference Data Source for the application. See Reference Data Sources below for more details.</summary>
    [JsonPropertyName("referenceDataSources")]
    public V1beta1ApplicationStatusAtProviderReferenceDataSources? ReferenceDataSources { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Whether to start or stop the Kinesis Analytics Application. To start an application, an input with a defined starting_position must be configured. To modify an application's starting position, first stop the application by setting start_application = false, then update starting_position and set start_application = true.</summary>
    [JsonPropertyName("startApplication")]
    public bool? StartApplication { get; set; }

    /// <summary>The Status of the application.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The Version of the application.</summary>
    [JsonPropertyName("version")]
    public double? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusConditions
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

/// <summary>ApplicationStatus defines the observed state of Application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ApplicationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ApplicationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Application is the Schema for the Applications API. Provides a AWS Kinesis Analytics Application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Application : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ApplicationSpec>, IStatus<V1beta1ApplicationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Application";
    public const string KubeGroup = "kinesisanalytics.aws.m.upbound.io";
    public const string KubePluralName = "applications";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ApplicationSpec defines the desired state of Application</summary>
    [JsonPropertyName("spec")]
    public V1beta1ApplicationSpec Spec { get; set; }

    /// <summary>ApplicationStatus defines the observed state of Application.</summary>
    [JsonPropertyName("status")]
    public V1beta1ApplicationStatus? Status { get; set; }
}