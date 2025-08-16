using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lambda.aws.m.upbound.io;
/// <summary>FunctionEventInvokeConfig is the Schema for the FunctionEventInvokeConfigs API. Manages an AWS Lambda Function Event Invoke Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FunctionEventInvokeConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta1FunctionEventInvokeConfig>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FunctionEventInvokeConfigList";
    public const string KubeGroup = "lambda.aws.m.upbound.io";
    public const string KubePluralName = "functioneventinvokeconfigs";
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
    public IList<V1beta1FunctionEventInvokeConfig> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfigOnFailureDestinationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Queue in sqs to populate destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfigOnFailureDestinationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfigOnFailureDestinationRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfigOnFailureDestinationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Queue in sqs to populate destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfigOnFailureDestinationSelector
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
    public V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfigOnFailureDestinationSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block with destination configuration for failed asynchronous invocations. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfigOnFailure
{
    /// <summary>ARN of the destination resource. See the Lambda Developer Guide for acceptable resource types and associated IAM permissions.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Reference to a Queue in sqs to populate destination.</summary>
    [JsonPropertyName("destinationRef")]
    public V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfigOnFailureDestinationRef? DestinationRef { get; set; }

    /// <summary>Selector for a Queue in sqs to populate destination.</summary>
    [JsonPropertyName("destinationSelector")]
    public V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfigOnFailureDestinationSelector? DestinationSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfigOnSuccessDestinationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfigOnSuccessDestinationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfigOnSuccessDestinationRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfigOnSuccessDestinationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfigOnSuccessDestinationSelector
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
    public V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfigOnSuccessDestinationSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block with destination configuration for successful asynchronous invocations. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfigOnSuccess
{
    /// <summary>ARN of the destination resource. See the Lambda Developer Guide for acceptable resource types and associated IAM permissions.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Reference to a Topic in sns to populate destination.</summary>
    [JsonPropertyName("destinationRef")]
    public V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfigOnSuccessDestinationRef? DestinationRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate destination.</summary>
    [JsonPropertyName("destinationSelector")]
    public V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfigOnSuccessDestinationSelector? DestinationSelector { get; set; }
}

/// <summary>Configuration block with destination configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfig
{
    /// <summary>Configuration block with destination configuration for failed asynchronous invocations. See below.</summary>
    [JsonPropertyName("onFailure")]
    public V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfigOnFailure? OnFailure { get; set; }

    /// <summary>Configuration block with destination configuration for successful asynchronous invocations. See below.</summary>
    [JsonPropertyName("onSuccess")]
    public V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfigOnSuccess? OnSuccess { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecForProvider
{
    /// <summary>Configuration block with destination configuration. See below.</summary>
    [JsonPropertyName("destinationConfig")]
    public V1beta1FunctionEventInvokeConfigSpecForProviderDestinationConfig? DestinationConfig { get; set; }

    /// <summary>Name or ARN of the Lambda Function, omitting any version or alias qualifier.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>Maximum age of a request that Lambda sends to a function for processing in seconds. Valid values between 60 and 21600.</summary>
    [JsonPropertyName("maximumEventAgeInSeconds")]
    public double? MaximumEventAgeInSeconds { get; set; }

    /// <summary>Maximum number of times to retry when the function returns an error. Valid values between 0 and 2. Defaults to 2.</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }

    /// <summary>Lambda Function published version, $LATEST, or Lambda Alias name.</summary>
    [JsonPropertyName("qualifier")]
    public string? Qualifier { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfigOnFailureDestinationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Queue in sqs to populate destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfigOnFailureDestinationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfigOnFailureDestinationRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfigOnFailureDestinationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Queue in sqs to populate destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfigOnFailureDestinationSelector
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
    public V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfigOnFailureDestinationSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block with destination configuration for failed asynchronous invocations. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfigOnFailure
{
    /// <summary>ARN of the destination resource. See the Lambda Developer Guide for acceptable resource types and associated IAM permissions.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Reference to a Queue in sqs to populate destination.</summary>
    [JsonPropertyName("destinationRef")]
    public V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfigOnFailureDestinationRef? DestinationRef { get; set; }

    /// <summary>Selector for a Queue in sqs to populate destination.</summary>
    [JsonPropertyName("destinationSelector")]
    public V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfigOnFailureDestinationSelector? DestinationSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfigOnSuccessDestinationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfigOnSuccessDestinationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfigOnSuccessDestinationRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfigOnSuccessDestinationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfigOnSuccessDestinationSelector
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
    public V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfigOnSuccessDestinationSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block with destination configuration for successful asynchronous invocations. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfigOnSuccess
{
    /// <summary>ARN of the destination resource. See the Lambda Developer Guide for acceptable resource types and associated IAM permissions.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Reference to a Topic in sns to populate destination.</summary>
    [JsonPropertyName("destinationRef")]
    public V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfigOnSuccessDestinationRef? DestinationRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate destination.</summary>
    [JsonPropertyName("destinationSelector")]
    public V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfigOnSuccessDestinationSelector? DestinationSelector { get; set; }
}

/// <summary>Configuration block with destination configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfig
{
    /// <summary>Configuration block with destination configuration for failed asynchronous invocations. See below.</summary>
    [JsonPropertyName("onFailure")]
    public V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfigOnFailure? OnFailure { get; set; }

    /// <summary>Configuration block with destination configuration for successful asynchronous invocations. See below.</summary>
    [JsonPropertyName("onSuccess")]
    public V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfigOnSuccess? OnSuccess { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecInitProvider
{
    /// <summary>Configuration block with destination configuration. See below.</summary>
    [JsonPropertyName("destinationConfig")]
    public V1beta1FunctionEventInvokeConfigSpecInitProviderDestinationConfig? DestinationConfig { get; set; }

    /// <summary>Name or ARN of the Lambda Function, omitting any version or alias qualifier.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>Maximum age of a request that Lambda sends to a function for processing in seconds. Valid values between 60 and 21600.</summary>
    [JsonPropertyName("maximumEventAgeInSeconds")]
    public double? MaximumEventAgeInSeconds { get; set; }

    /// <summary>Maximum number of times to retry when the function returns an error. Valid values between 0 and 2. Defaults to 2.</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }

    /// <summary>Lambda Function published version, $LATEST, or Lambda Alias name.</summary>
    [JsonPropertyName("qualifier")]
    public string? Qualifier { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpecProviderConfigRef
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
public partial class V1beta1FunctionEventInvokeConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>FunctionEventInvokeConfigSpec defines the desired state of FunctionEventInvokeConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FunctionEventInvokeConfigSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FunctionEventInvokeConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FunctionEventInvokeConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FunctionEventInvokeConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block with destination configuration for failed asynchronous invocations. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigStatusAtProviderDestinationConfigOnFailure
{
    /// <summary>ARN of the destination resource. See the Lambda Developer Guide for acceptable resource types and associated IAM permissions.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary>Configuration block with destination configuration for successful asynchronous invocations. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigStatusAtProviderDestinationConfigOnSuccess
{
    /// <summary>ARN of the destination resource. See the Lambda Developer Guide for acceptable resource types and associated IAM permissions.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary>Configuration block with destination configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigStatusAtProviderDestinationConfig
{
    /// <summary>Configuration block with destination configuration for failed asynchronous invocations. See below.</summary>
    [JsonPropertyName("onFailure")]
    public V1beta1FunctionEventInvokeConfigStatusAtProviderDestinationConfigOnFailure? OnFailure { get; set; }

    /// <summary>Configuration block with destination configuration for successful asynchronous invocations. See below.</summary>
    [JsonPropertyName("onSuccess")]
    public V1beta1FunctionEventInvokeConfigStatusAtProviderDestinationConfigOnSuccess? OnSuccess { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigStatusAtProvider
{
    /// <summary>Configuration block with destination configuration. See below.</summary>
    [JsonPropertyName("destinationConfig")]
    public V1beta1FunctionEventInvokeConfigStatusAtProviderDestinationConfig? DestinationConfig { get; set; }

    /// <summary>Name or ARN of the Lambda Function, omitting any version or alias qualifier.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>Fully qualified Lambda Function name or ARN.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Maximum age of a request that Lambda sends to a function for processing in seconds. Valid values between 60 and 21600.</summary>
    [JsonPropertyName("maximumEventAgeInSeconds")]
    public double? MaximumEventAgeInSeconds { get; set; }

    /// <summary>Maximum number of times to retry when the function returns an error. Valid values between 0 and 2. Defaults to 2.</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }

    /// <summary>Lambda Function published version, $LATEST, or Lambda Alias name.</summary>
    [JsonPropertyName("qualifier")]
    public string? Qualifier { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigStatusConditions
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

/// <summary>FunctionEventInvokeConfigStatus defines the observed state of FunctionEventInvokeConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionEventInvokeConfigStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FunctionEventInvokeConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FunctionEventInvokeConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FunctionEventInvokeConfig is the Schema for the FunctionEventInvokeConfigs API. Manages an AWS Lambda Function Event Invoke Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FunctionEventInvokeConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FunctionEventInvokeConfigSpec>, IStatus<V1beta1FunctionEventInvokeConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FunctionEventInvokeConfig";
    public const string KubeGroup = "lambda.aws.m.upbound.io";
    public const string KubePluralName = "functioneventinvokeconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FunctionEventInvokeConfigSpec defines the desired state of FunctionEventInvokeConfig</summary>
    [JsonPropertyName("spec")]
    public V1beta1FunctionEventInvokeConfigSpec Spec { get; set; }

    /// <summary>FunctionEventInvokeConfigStatus defines the observed state of FunctionEventInvokeConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1FunctionEventInvokeConfigStatus? Status { get; set; }
}