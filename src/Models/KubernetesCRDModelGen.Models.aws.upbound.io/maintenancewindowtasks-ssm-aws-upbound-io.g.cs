using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ssm.aws.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderServiceRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderServiceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecForProviderServiceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderServiceRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderServiceRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecForProviderServiceRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTargets
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The array of strings.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate taskArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecForProviderTaskArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate taskArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecForProviderTaskArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersAutomationParametersParameter
{
    /// <summary>The name of the maintenance window task.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The array of strings.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersAutomationParameters
{
    /// <summary>The version of an Automation document to use during task execution.</summary>
    [JsonPropertyName("documentVersion")]
    public string? DocumentVersion { get; set; }

    /// <summary>The parameters for the RUN_COMMAND task execution. Documented below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersAutomationParametersParameter>? Parameter { get; set; }
}

/// <summary>JSON to provide to your Lambda function as input.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersLambdaParametersPayloadSecretRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersLambdaParameters
{
    /// <summary>Pass client-specific information to the Lambda function that you are invoking.</summary>
    [JsonPropertyName("clientContext")]
    public string? ClientContext { get; set; }

    /// <summary>JSON to provide to your Lambda function as input.</summary>
    [JsonPropertyName("payloadSecretRef")]
    public V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersLambdaParametersPayloadSecretRef? PayloadSecretRef { get; set; }

    /// <summary>Specify a Lambda function version or alias name.</summary>
    [JsonPropertyName("qualifier")]
    public string? Qualifier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersCloudwatchConfig
{
    /// <summary>The name of the CloudWatch log group where you want to send command output. If you don't specify a group name, Systems Manager automatically creates a log group for you. The log group uses the following naming format: aws/ssm/SystemsManagerDocumentName.</summary>
    [JsonPropertyName("cloudwatchLogGroupName")]
    public string? CloudwatchLogGroupName { get; set; }

    /// <summary>Enables Systems Manager to send command output to CloudWatch Logs.</summary>
    [JsonPropertyName("cloudwatchOutputEnabled")]
    public bool? CloudwatchOutputEnabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersNotificationConfigNotificationArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate notificationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersNotificationConfigNotificationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersNotificationConfigNotificationArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersNotificationConfigNotificationArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate notificationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersNotificationConfigNotificationArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersNotificationConfigNotificationArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersNotificationConfig
{
    /// <summary>An Amazon Resource Name (ARN) for a Simple Notification Service (SNS) topic. Run Command pushes notifications about command status changes to this topic.</summary>
    [JsonPropertyName("notificationArn")]
    public string? NotificationArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate notificationArn.</summary>
    [JsonPropertyName("notificationArnRef")]
    public V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersNotificationConfigNotificationArnRef? NotificationArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate notificationArn.</summary>
    [JsonPropertyName("notificationArnSelector")]
    public V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersNotificationConfigNotificationArnSelector? NotificationArnSelector { get; set; }

    /// <summary>The different events for which you can receive notifications. Valid values: All, InProgress, Success, TimedOut, Cancelled, and Failed</summary>
    [JsonPropertyName("notificationEvents")]
    public IList<string>? NotificationEvents { get; set; }

    /// <summary>When specified with Command, receive notification when the status of a command changes. When specified with Invocation, for commands sent to multiple instances, receive notification on a per-instance basis when the status of a command changes. Valid values: Command and Invocation</summary>
    [JsonPropertyName("notificationType")]
    public string? NotificationType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersOutputS3BucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate outputS3Bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersOutputS3BucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersOutputS3BucketRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersOutputS3BucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate outputS3Bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersOutputS3BucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersOutputS3BucketSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersParameter
{
    /// <summary>The name of the maintenance window task.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The array of strings.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersServiceRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersServiceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersServiceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersServiceRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersServiceRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersServiceRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParameters
{
    /// <summary>Configuration options for sending command output to CloudWatch Logs. Documented below.</summary>
    [JsonPropertyName("cloudwatchConfig")]
    public IList<V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersCloudwatchConfig>? CloudwatchConfig { get; set; }

    /// <summary>Information about the command(s) to execute.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>The SHA-256 or SHA-1 hash created by the system when the document was created. SHA-1 hashes have been deprecated.</summary>
    [JsonPropertyName("documentHash")]
    public string? DocumentHash { get; set; }

    /// <summary>SHA-256 or SHA-1. SHA-1 hashes have been deprecated. Valid values: Sha256 and Sha1</summary>
    [JsonPropertyName("documentHashType")]
    public string? DocumentHashType { get; set; }

    /// <summary>The version of an Automation document to use during task execution.</summary>
    [JsonPropertyName("documentVersion")]
    public string? DocumentVersion { get; set; }

    /// <summary>Configurations for sending notifications about command status changes on a per-instance basis. Documented below.</summary>
    [JsonPropertyName("notificationConfig")]
    public IList<V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersNotificationConfig>? NotificationConfig { get; set; }

    /// <summary>The name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("outputS3Bucket")]
    public string? OutputS3Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate outputS3Bucket.</summary>
    [JsonPropertyName("outputS3BucketRef")]
    public V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersOutputS3BucketRef? OutputS3BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate outputS3Bucket.</summary>
    [JsonPropertyName("outputS3BucketSelector")]
    public V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersOutputS3BucketSelector? OutputS3BucketSelector { get; set; }

    /// <summary>The Amazon S3 bucket subfolder.</summary>
    [JsonPropertyName("outputS3KeyPrefix")]
    public string? OutputS3KeyPrefix { get; set; }

    /// <summary>The parameters for the RUN_COMMAND task execution. Documented below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersParameter>? Parameter { get; set; }

    /// <summary>The role that should be assumed when executing the task. If a role is not provided, Systems Manager uses your account's service-linked role. If no service-linked role for Systems Manager exists in your account, it is created for you.</summary>
    [JsonPropertyName("serviceRoleArn")]
    public string? ServiceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnRef")]
    public V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersServiceRoleArnRef? ServiceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnSelector")]
    public V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParametersServiceRoleArnSelector? ServiceRoleArnSelector { get; set; }

    /// <summary>If this time is reached and the command has not already started executing, it doesn't run.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

/// <summary>The inputs for the STEP_FUNCTION task.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersStepFunctionsParametersInputSecretRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersStepFunctionsParameters
{
    /// <summary>The inputs for the STEP_FUNCTION task.</summary>
    [JsonPropertyName("inputSecretRef")]
    public V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersStepFunctionsParametersInputSecretRef? InputSecretRef { get; set; }

    /// <summary>The name of the maintenance window task.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParameters
{
    /// <summary>The parameters for an AUTOMATION task type. Documented below.</summary>
    [JsonPropertyName("automationParameters")]
    public IList<V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersAutomationParameters>? AutomationParameters { get; set; }

    /// <summary>The parameters for a LAMBDA task type. Documented below.</summary>
    [JsonPropertyName("lambdaParameters")]
    public IList<V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersLambdaParameters>? LambdaParameters { get; set; }

    /// <summary>The parameters for a RUN_COMMAND task type. Documented below.</summary>
    [JsonPropertyName("runCommandParameters")]
    public IList<V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersRunCommandParameters>? RunCommandParameters { get; set; }

    /// <summary>The parameters for a STEP_FUNCTIONS task type. Documented below.</summary>
    [JsonPropertyName("stepFunctionsParameters")]
    public IList<V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParametersStepFunctionsParameters>? StepFunctionsParameters { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderWindowIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a MaintenanceWindow in ssm to populate windowId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderWindowIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecForProviderWindowIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderWindowIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a MaintenanceWindow in ssm to populate windowId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProviderWindowIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecForProviderWindowIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecForProvider
{
    /// <summary>Indicates whether tasks should continue to run after the cutoff time specified in the maintenance windows is reached. Valid values are CONTINUE_TASK and CANCEL_TASK.</summary>
    [JsonPropertyName("cutoffBehavior")]
    public string? CutoffBehavior { get; set; }

    /// <summary>The description of the maintenance window task.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The maximum number of targets this task can be run for in parallel.</summary>
    [JsonPropertyName("maxConcurrency")]
    public string? MaxConcurrency { get; set; }

    /// <summary>The maximum number of errors allowed before this task stops being scheduled.</summary>
    [JsonPropertyName("maxErrors")]
    public string? MaxErrors { get; set; }

    /// <summary>The name of the maintenance window task.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority of the task in the Maintenance Window, the lower the number the higher the priority. Tasks in a Maintenance Window are scheduled in priority order with tasks that have the same priority scheduled in parallel.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The role that should be assumed when executing the task. If a role is not provided, Systems Manager uses your account's service-linked role. If no service-linked role for Systems Manager exists in your account, it is created for you.</summary>
    [JsonPropertyName("serviceRoleArn")]
    public string? ServiceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnRef")]
    public V1beta1MaintenanceWindowTaskSpecForProviderServiceRoleArnRef? ServiceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnSelector")]
    public V1beta1MaintenanceWindowTaskSpecForProviderServiceRoleArnSelector? ServiceRoleArnSelector { get; set; }

    /// <summary>The targets (either instances or window target ids). Instances are specified using Key=InstanceIds,Values=instanceid1,instanceid2. Window target ids are specified using Key=WindowTargetIds,Values=window target id1, window target id2.</summary>
    [JsonPropertyName("targets")]
    public IList<V1beta1MaintenanceWindowTaskSpecForProviderTargets>? Targets { get; set; }

    /// <summary>The ARN of the task to execute.</summary>
    [JsonPropertyName("taskArn")]
    public string? TaskArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate taskArn.</summary>
    [JsonPropertyName("taskArnRef")]
    public V1beta1MaintenanceWindowTaskSpecForProviderTaskArnRef? TaskArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate taskArn.</summary>
    [JsonPropertyName("taskArnSelector")]
    public V1beta1MaintenanceWindowTaskSpecForProviderTaskArnSelector? TaskArnSelector { get; set; }

    /// <summary>Configuration block with parameters for task execution.</summary>
    [JsonPropertyName("taskInvocationParameters")]
    public IList<V1beta1MaintenanceWindowTaskSpecForProviderTaskInvocationParameters>? TaskInvocationParameters { get; set; }

    /// <summary>The type of task being registered. Valid values: AUTOMATION, LAMBDA, RUN_COMMAND or STEP_FUNCTIONS.</summary>
    [JsonPropertyName("taskType")]
    public string? TaskType { get; set; }

    /// <summary>The Id of the maintenance window to register the task with.</summary>
    [JsonPropertyName("windowId")]
    public string? WindowId { get; set; }

    /// <summary>Reference to a MaintenanceWindow in ssm to populate windowId.</summary>
    [JsonPropertyName("windowIdRef")]
    public V1beta1MaintenanceWindowTaskSpecForProviderWindowIdRef? WindowIdRef { get; set; }

    /// <summary>Selector for a MaintenanceWindow in ssm to populate windowId.</summary>
    [JsonPropertyName("windowIdSelector")]
    public V1beta1MaintenanceWindowTaskSpecForProviderWindowIdSelector? WindowIdSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderServiceRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderServiceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderServiceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderServiceRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderServiceRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderServiceRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTargets
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The array of strings.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate taskArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderTaskArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate taskArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderTaskArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersAutomationParametersParameter
{
    /// <summary>The name of the maintenance window task.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The array of strings.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersAutomationParameters
{
    /// <summary>The version of an Automation document to use during task execution.</summary>
    [JsonPropertyName("documentVersion")]
    public string? DocumentVersion { get; set; }

    /// <summary>The parameters for the RUN_COMMAND task execution. Documented below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersAutomationParametersParameter>? Parameter { get; set; }
}

/// <summary>JSON to provide to your Lambda function as input.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersLambdaParametersPayloadSecretRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersLambdaParameters
{
    /// <summary>Pass client-specific information to the Lambda function that you are invoking.</summary>
    [JsonPropertyName("clientContext")]
    public string? ClientContext { get; set; }

    /// <summary>JSON to provide to your Lambda function as input.</summary>
    [JsonPropertyName("payloadSecretRef")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersLambdaParametersPayloadSecretRef? PayloadSecretRef { get; set; }

    /// <summary>Specify a Lambda function version or alias name.</summary>
    [JsonPropertyName("qualifier")]
    public string? Qualifier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersCloudwatchConfig
{
    /// <summary>The name of the CloudWatch log group where you want to send command output. If you don't specify a group name, Systems Manager automatically creates a log group for you. The log group uses the following naming format: aws/ssm/SystemsManagerDocumentName.</summary>
    [JsonPropertyName("cloudwatchLogGroupName")]
    public string? CloudwatchLogGroupName { get; set; }

    /// <summary>Enables Systems Manager to send command output to CloudWatch Logs.</summary>
    [JsonPropertyName("cloudwatchOutputEnabled")]
    public bool? CloudwatchOutputEnabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersNotificationConfigNotificationArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate notificationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersNotificationConfigNotificationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersNotificationConfigNotificationArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersNotificationConfigNotificationArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate notificationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersNotificationConfigNotificationArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersNotificationConfigNotificationArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersNotificationConfig
{
    /// <summary>An Amazon Resource Name (ARN) for a Simple Notification Service (SNS) topic. Run Command pushes notifications about command status changes to this topic.</summary>
    [JsonPropertyName("notificationArn")]
    public string? NotificationArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate notificationArn.</summary>
    [JsonPropertyName("notificationArnRef")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersNotificationConfigNotificationArnRef? NotificationArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate notificationArn.</summary>
    [JsonPropertyName("notificationArnSelector")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersNotificationConfigNotificationArnSelector? NotificationArnSelector { get; set; }

    /// <summary>The different events for which you can receive notifications. Valid values: All, InProgress, Success, TimedOut, Cancelled, and Failed</summary>
    [JsonPropertyName("notificationEvents")]
    public IList<string>? NotificationEvents { get; set; }

    /// <summary>When specified with Command, receive notification when the status of a command changes. When specified with Invocation, for commands sent to multiple instances, receive notification on a per-instance basis when the status of a command changes. Valid values: Command and Invocation</summary>
    [JsonPropertyName("notificationType")]
    public string? NotificationType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersOutputS3BucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate outputS3Bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersOutputS3BucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersOutputS3BucketRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersOutputS3BucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate outputS3Bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersOutputS3BucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersOutputS3BucketSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersParameter
{
    /// <summary>The name of the maintenance window task.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The array of strings.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersServiceRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersServiceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersServiceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersServiceRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersServiceRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersServiceRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParameters
{
    /// <summary>Configuration options for sending command output to CloudWatch Logs. Documented below.</summary>
    [JsonPropertyName("cloudwatchConfig")]
    public IList<V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersCloudwatchConfig>? CloudwatchConfig { get; set; }

    /// <summary>Information about the command(s) to execute.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>The SHA-256 or SHA-1 hash created by the system when the document was created. SHA-1 hashes have been deprecated.</summary>
    [JsonPropertyName("documentHash")]
    public string? DocumentHash { get; set; }

    /// <summary>SHA-256 or SHA-1. SHA-1 hashes have been deprecated. Valid values: Sha256 and Sha1</summary>
    [JsonPropertyName("documentHashType")]
    public string? DocumentHashType { get; set; }

    /// <summary>The version of an Automation document to use during task execution.</summary>
    [JsonPropertyName("documentVersion")]
    public string? DocumentVersion { get; set; }

    /// <summary>Configurations for sending notifications about command status changes on a per-instance basis. Documented below.</summary>
    [JsonPropertyName("notificationConfig")]
    public IList<V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersNotificationConfig>? NotificationConfig { get; set; }

    /// <summary>The name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("outputS3Bucket")]
    public string? OutputS3Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate outputS3Bucket.</summary>
    [JsonPropertyName("outputS3BucketRef")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersOutputS3BucketRef? OutputS3BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate outputS3Bucket.</summary>
    [JsonPropertyName("outputS3BucketSelector")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersOutputS3BucketSelector? OutputS3BucketSelector { get; set; }

    /// <summary>The Amazon S3 bucket subfolder.</summary>
    [JsonPropertyName("outputS3KeyPrefix")]
    public string? OutputS3KeyPrefix { get; set; }

    /// <summary>The parameters for the RUN_COMMAND task execution. Documented below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersParameter>? Parameter { get; set; }

    /// <summary>The role that should be assumed when executing the task. If a role is not provided, Systems Manager uses your account's service-linked role. If no service-linked role for Systems Manager exists in your account, it is created for you.</summary>
    [JsonPropertyName("serviceRoleArn")]
    public string? ServiceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnRef")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersServiceRoleArnRef? ServiceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnSelector")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParametersServiceRoleArnSelector? ServiceRoleArnSelector { get; set; }

    /// <summary>If this time is reached and the command has not already started executing, it doesn't run.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

/// <summary>The inputs for the STEP_FUNCTION task.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersStepFunctionsParametersInputSecretRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersStepFunctionsParameters
{
    /// <summary>The inputs for the STEP_FUNCTION task.</summary>
    [JsonPropertyName("inputSecretRef")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersStepFunctionsParametersInputSecretRef? InputSecretRef { get; set; }

    /// <summary>The name of the maintenance window task.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParameters
{
    /// <summary>The parameters for an AUTOMATION task type. Documented below.</summary>
    [JsonPropertyName("automationParameters")]
    public IList<V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersAutomationParameters>? AutomationParameters { get; set; }

    /// <summary>The parameters for a LAMBDA task type. Documented below.</summary>
    [JsonPropertyName("lambdaParameters")]
    public IList<V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersLambdaParameters>? LambdaParameters { get; set; }

    /// <summary>The parameters for a RUN_COMMAND task type. Documented below.</summary>
    [JsonPropertyName("runCommandParameters")]
    public IList<V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersRunCommandParameters>? RunCommandParameters { get; set; }

    /// <summary>The parameters for a STEP_FUNCTIONS task type. Documented below.</summary>
    [JsonPropertyName("stepFunctionsParameters")]
    public IList<V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParametersStepFunctionsParameters>? StepFunctionsParameters { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderWindowIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a MaintenanceWindow in ssm to populate windowId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderWindowIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderWindowIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderWindowIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a MaintenanceWindow in ssm to populate windowId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProviderWindowIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderWindowIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecInitProvider
{
    /// <summary>Indicates whether tasks should continue to run after the cutoff time specified in the maintenance windows is reached. Valid values are CONTINUE_TASK and CANCEL_TASK.</summary>
    [JsonPropertyName("cutoffBehavior")]
    public string? CutoffBehavior { get; set; }

    /// <summary>The description of the maintenance window task.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The maximum number of targets this task can be run for in parallel.</summary>
    [JsonPropertyName("maxConcurrency")]
    public string? MaxConcurrency { get; set; }

    /// <summary>The maximum number of errors allowed before this task stops being scheduled.</summary>
    [JsonPropertyName("maxErrors")]
    public string? MaxErrors { get; set; }

    /// <summary>The name of the maintenance window task.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority of the task in the Maintenance Window, the lower the number the higher the priority. Tasks in a Maintenance Window are scheduled in priority order with tasks that have the same priority scheduled in parallel.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The role that should be assumed when executing the task. If a role is not provided, Systems Manager uses your account's service-linked role. If no service-linked role for Systems Manager exists in your account, it is created for you.</summary>
    [JsonPropertyName("serviceRoleArn")]
    public string? ServiceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnRef")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderServiceRoleArnRef? ServiceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnSelector")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderServiceRoleArnSelector? ServiceRoleArnSelector { get; set; }

    /// <summary>The targets (either instances or window target ids). Instances are specified using Key=InstanceIds,Values=instanceid1,instanceid2. Window target ids are specified using Key=WindowTargetIds,Values=window target id1, window target id2.</summary>
    [JsonPropertyName("targets")]
    public IList<V1beta1MaintenanceWindowTaskSpecInitProviderTargets>? Targets { get; set; }

    /// <summary>The ARN of the task to execute.</summary>
    [JsonPropertyName("taskArn")]
    public string? TaskArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate taskArn.</summary>
    [JsonPropertyName("taskArnRef")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderTaskArnRef? TaskArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate taskArn.</summary>
    [JsonPropertyName("taskArnSelector")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderTaskArnSelector? TaskArnSelector { get; set; }

    /// <summary>Configuration block with parameters for task execution.</summary>
    [JsonPropertyName("taskInvocationParameters")]
    public IList<V1beta1MaintenanceWindowTaskSpecInitProviderTaskInvocationParameters>? TaskInvocationParameters { get; set; }

    /// <summary>The type of task being registered. Valid values: AUTOMATION, LAMBDA, RUN_COMMAND or STEP_FUNCTIONS.</summary>
    [JsonPropertyName("taskType")]
    public string? TaskType { get; set; }

    /// <summary>The Id of the maintenance window to register the task with.</summary>
    [JsonPropertyName("windowId")]
    public string? WindowId { get; set; }

    /// <summary>Reference to a MaintenanceWindow in ssm to populate windowId.</summary>
    [JsonPropertyName("windowIdRef")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderWindowIdRef? WindowIdRef { get; set; }

    /// <summary>Selector for a MaintenanceWindow in ssm to populate windowId.</summary>
    [JsonPropertyName("windowIdSelector")]
    public V1beta1MaintenanceWindowTaskSpecInitProviderWindowIdSelector? WindowIdSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecProviderConfigRefPolicy
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
public partial class V1beta1MaintenanceWindowTaskSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1MaintenanceWindowTaskSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceWindowTaskSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1MaintenanceWindowTaskSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1MaintenanceWindowTaskSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1MaintenanceWindowTaskSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>MaintenanceWindowTaskSpec defines the desired state of MaintenanceWindowTask</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MaintenanceWindowTaskSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MaintenanceWindowTaskSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MaintenanceWindowTaskSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1MaintenanceWindowTaskSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MaintenanceWindowTaskSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskStatusAtProviderTargets
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The array of strings.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskStatusAtProviderTaskInvocationParametersAutomationParametersParameter
{
    /// <summary>The name of the maintenance window task.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The array of strings.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskStatusAtProviderTaskInvocationParametersAutomationParameters
{
    /// <summary>The version of an Automation document to use during task execution.</summary>
    [JsonPropertyName("documentVersion")]
    public string? DocumentVersion { get; set; }

    /// <summary>The parameters for the RUN_COMMAND task execution. Documented below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1MaintenanceWindowTaskStatusAtProviderTaskInvocationParametersAutomationParametersParameter>? Parameter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskStatusAtProviderTaskInvocationParametersLambdaParameters
{
    /// <summary>Pass client-specific information to the Lambda function that you are invoking.</summary>
    [JsonPropertyName("clientContext")]
    public string? ClientContext { get; set; }

    /// <summary>Specify a Lambda function version or alias name.</summary>
    [JsonPropertyName("qualifier")]
    public string? Qualifier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskStatusAtProviderTaskInvocationParametersRunCommandParametersCloudwatchConfig
{
    /// <summary>The name of the CloudWatch log group where you want to send command output. If you don't specify a group name, Systems Manager automatically creates a log group for you. The log group uses the following naming format: aws/ssm/SystemsManagerDocumentName.</summary>
    [JsonPropertyName("cloudwatchLogGroupName")]
    public string? CloudwatchLogGroupName { get; set; }

    /// <summary>Enables Systems Manager to send command output to CloudWatch Logs.</summary>
    [JsonPropertyName("cloudwatchOutputEnabled")]
    public bool? CloudwatchOutputEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskStatusAtProviderTaskInvocationParametersRunCommandParametersNotificationConfig
{
    /// <summary>An Amazon Resource Name (ARN) for a Simple Notification Service (SNS) topic. Run Command pushes notifications about command status changes to this topic.</summary>
    [JsonPropertyName("notificationArn")]
    public string? NotificationArn { get; set; }

    /// <summary>The different events for which you can receive notifications. Valid values: All, InProgress, Success, TimedOut, Cancelled, and Failed</summary>
    [JsonPropertyName("notificationEvents")]
    public IList<string>? NotificationEvents { get; set; }

    /// <summary>When specified with Command, receive notification when the status of a command changes. When specified with Invocation, for commands sent to multiple instances, receive notification on a per-instance basis when the status of a command changes. Valid values: Command and Invocation</summary>
    [JsonPropertyName("notificationType")]
    public string? NotificationType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskStatusAtProviderTaskInvocationParametersRunCommandParametersParameter
{
    /// <summary>The name of the maintenance window task.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The array of strings.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskStatusAtProviderTaskInvocationParametersRunCommandParameters
{
    /// <summary>Configuration options for sending command output to CloudWatch Logs. Documented below.</summary>
    [JsonPropertyName("cloudwatchConfig")]
    public IList<V1beta1MaintenanceWindowTaskStatusAtProviderTaskInvocationParametersRunCommandParametersCloudwatchConfig>? CloudwatchConfig { get; set; }

    /// <summary>Information about the command(s) to execute.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>The SHA-256 or SHA-1 hash created by the system when the document was created. SHA-1 hashes have been deprecated.</summary>
    [JsonPropertyName("documentHash")]
    public string? DocumentHash { get; set; }

    /// <summary>SHA-256 or SHA-1. SHA-1 hashes have been deprecated. Valid values: Sha256 and Sha1</summary>
    [JsonPropertyName("documentHashType")]
    public string? DocumentHashType { get; set; }

    /// <summary>The version of an Automation document to use during task execution.</summary>
    [JsonPropertyName("documentVersion")]
    public string? DocumentVersion { get; set; }

    /// <summary>Configurations for sending notifications about command status changes on a per-instance basis. Documented below.</summary>
    [JsonPropertyName("notificationConfig")]
    public IList<V1beta1MaintenanceWindowTaskStatusAtProviderTaskInvocationParametersRunCommandParametersNotificationConfig>? NotificationConfig { get; set; }

    /// <summary>The name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("outputS3Bucket")]
    public string? OutputS3Bucket { get; set; }

    /// <summary>The Amazon S3 bucket subfolder.</summary>
    [JsonPropertyName("outputS3KeyPrefix")]
    public string? OutputS3KeyPrefix { get; set; }

    /// <summary>The parameters for the RUN_COMMAND task execution. Documented below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1MaintenanceWindowTaskStatusAtProviderTaskInvocationParametersRunCommandParametersParameter>? Parameter { get; set; }

    /// <summary>The role that should be assumed when executing the task. If a role is not provided, Systems Manager uses your account's service-linked role. If no service-linked role for Systems Manager exists in your account, it is created for you.</summary>
    [JsonPropertyName("serviceRoleArn")]
    public string? ServiceRoleArn { get; set; }

    /// <summary>If this time is reached and the command has not already started executing, it doesn't run.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskStatusAtProviderTaskInvocationParametersStepFunctionsParameters
{
    /// <summary>The name of the maintenance window task.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskStatusAtProviderTaskInvocationParameters
{
    /// <summary>The parameters for an AUTOMATION task type. Documented below.</summary>
    [JsonPropertyName("automationParameters")]
    public IList<V1beta1MaintenanceWindowTaskStatusAtProviderTaskInvocationParametersAutomationParameters>? AutomationParameters { get; set; }

    /// <summary>The parameters for a LAMBDA task type. Documented below.</summary>
    [JsonPropertyName("lambdaParameters")]
    public IList<V1beta1MaintenanceWindowTaskStatusAtProviderTaskInvocationParametersLambdaParameters>? LambdaParameters { get; set; }

    /// <summary>The parameters for a RUN_COMMAND task type. Documented below.</summary>
    [JsonPropertyName("runCommandParameters")]
    public IList<V1beta1MaintenanceWindowTaskStatusAtProviderTaskInvocationParametersRunCommandParameters>? RunCommandParameters { get; set; }

    /// <summary>The parameters for a STEP_FUNCTIONS task type. Documented below.</summary>
    [JsonPropertyName("stepFunctionsParameters")]
    public IList<V1beta1MaintenanceWindowTaskStatusAtProviderTaskInvocationParametersStepFunctionsParameters>? StepFunctionsParameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskStatusAtProvider
{
    /// <summary>The ARN of the maintenance window task.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Indicates whether tasks should continue to run after the cutoff time specified in the maintenance windows is reached. Valid values are CONTINUE_TASK and CANCEL_TASK.</summary>
    [JsonPropertyName("cutoffBehavior")]
    public string? CutoffBehavior { get; set; }

    /// <summary>The description of the maintenance window task.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of the maintenance window task.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The maximum number of targets this task can be run for in parallel.</summary>
    [JsonPropertyName("maxConcurrency")]
    public string? MaxConcurrency { get; set; }

    /// <summary>The maximum number of errors allowed before this task stops being scheduled.</summary>
    [JsonPropertyName("maxErrors")]
    public string? MaxErrors { get; set; }

    /// <summary>The name of the maintenance window task.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority of the task in the Maintenance Window, the lower the number the higher the priority. Tasks in a Maintenance Window are scheduled in priority order with tasks that have the same priority scheduled in parallel.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The role that should be assumed when executing the task. If a role is not provided, Systems Manager uses your account's service-linked role. If no service-linked role for Systems Manager exists in your account, it is created for you.</summary>
    [JsonPropertyName("serviceRoleArn")]
    public string? ServiceRoleArn { get; set; }

    /// <summary>The targets (either instances or window target ids). Instances are specified using Key=InstanceIds,Values=instanceid1,instanceid2. Window target ids are specified using Key=WindowTargetIds,Values=window target id1, window target id2.</summary>
    [JsonPropertyName("targets")]
    public IList<V1beta1MaintenanceWindowTaskStatusAtProviderTargets>? Targets { get; set; }

    /// <summary>The ARN of the task to execute.</summary>
    [JsonPropertyName("taskArn")]
    public string? TaskArn { get; set; }

    /// <summary>Configuration block with parameters for task execution.</summary>
    [JsonPropertyName("taskInvocationParameters")]
    public IList<V1beta1MaintenanceWindowTaskStatusAtProviderTaskInvocationParameters>? TaskInvocationParameters { get; set; }

    /// <summary>The type of task being registered. Valid values: AUTOMATION, LAMBDA, RUN_COMMAND or STEP_FUNCTIONS.</summary>
    [JsonPropertyName("taskType")]
    public string? TaskType { get; set; }

    /// <summary>The Id of the maintenance window to register the task with.</summary>
    [JsonPropertyName("windowId")]
    public string? WindowId { get; set; }

    /// <summary>The ID of the maintenance window task.</summary>
    [JsonPropertyName("windowTaskId")]
    public string? WindowTaskId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskStatusConditions
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

/// <summary>MaintenanceWindowTaskStatus defines the observed state of MaintenanceWindowTask.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MaintenanceWindowTaskStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MaintenanceWindowTaskStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MaintenanceWindowTaskStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MaintenanceWindowTask is the Schema for the MaintenanceWindowTasks API. Provides an SSM Maintenance Window Task resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MaintenanceWindowTask : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MaintenanceWindowTaskSpec>, IStatus<V1beta1MaintenanceWindowTaskStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MaintenanceWindowTask";
    public const string KubeGroup = "ssm.aws.upbound.io";
    public const string KubePluralName = "maintenancewindowtasks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MaintenanceWindowTaskSpec defines the desired state of MaintenanceWindowTask</summary>
    [JsonPropertyName("spec")]
    public V1beta1MaintenanceWindowTaskSpec Spec { get; set; }

    /// <summary>MaintenanceWindowTaskStatus defines the observed state of MaintenanceWindowTask.</summary>
    [JsonPropertyName("status")]
    public V1beta1MaintenanceWindowTaskStatus? Status { get; set; }
}