using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.s3control.aws.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationSupportingAccessPointRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a AccessPoint in s3control to populate supportingAccessPoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationSupportingAccessPointRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationSupportingAccessPointRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationSupportingAccessPointSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a AccessPoint in s3control to populate supportingAccessPoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationSupportingAccessPointSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationSupportingAccessPointSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationTransformationConfigurationContentTransformationAwsLambdaFunctionArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate functionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationTransformationConfigurationContentTransformationAwsLambdaFunctionArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationTransformationConfigurationContentTransformationAwsLambdaFunctionArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationTransformationConfigurationContentTransformationAwsLambdaFunctionArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate functionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationTransformationConfigurationContentTransformationAwsLambdaFunctionArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationTransformationConfigurationContentTransformationAwsLambdaFunctionArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationTransformationConfigurationContentTransformationAwsLambda
{
    /// <summary>The Amazon Resource Name (ARN) of the AWS Lambda function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate functionArn.</summary>
    [JsonPropertyName("functionArnRef")]
    public V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationTransformationConfigurationContentTransformationAwsLambdaFunctionArnRef? FunctionArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate functionArn.</summary>
    [JsonPropertyName("functionArnSelector")]
    public V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationTransformationConfigurationContentTransformationAwsLambdaFunctionArnSelector? FunctionArnSelector { get; set; }

    /// <summary>Additional JSON that provides supplemental data to the Lambda function used to transform objects.</summary>
    [JsonPropertyName("functionPayload")]
    public string? FunctionPayload { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationTransformationConfigurationContentTransformation
{
    /// <summary>Configuration for an AWS Lambda function. See AWS Lambda below for more details.</summary>
    [JsonPropertyName("awsLambda")]
    public IList<V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationTransformationConfigurationContentTransformationAwsLambda>? AwsLambda { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationTransformationConfiguration
{
    /// <summary>The actions of an Object Lambda Access Point configuration. Valid values: GetObject.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }

    /// <summary>The content transformation of an Object Lambda Access Point configuration. See Content Transformation below for more details.</summary>
    [JsonPropertyName("contentTransformation")]
    public IList<V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationTransformationConfigurationContentTransformation>? ContentTransformation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecForProviderConfiguration
{
    /// <summary>Allowed features. Valid values: GetObject-Range, GetObject-PartNumber.</summary>
    [JsonPropertyName("allowedFeatures")]
    public IList<string>? AllowedFeatures { get; set; }

    /// <summary>Whether or not the CloudWatch metrics configuration is enabled.</summary>
    [JsonPropertyName("cloudWatchMetricsEnabled")]
    public bool? CloudWatchMetricsEnabled { get; set; }

    /// <summary>Standard access point associated with the Object Lambda Access Point.</summary>
    [JsonPropertyName("supportingAccessPoint")]
    public string? SupportingAccessPoint { get; set; }

    /// <summary>Reference to a AccessPoint in s3control to populate supportingAccessPoint.</summary>
    [JsonPropertyName("supportingAccessPointRef")]
    public V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationSupportingAccessPointRef? SupportingAccessPointRef { get; set; }

    /// <summary>Selector for a AccessPoint in s3control to populate supportingAccessPoint.</summary>
    [JsonPropertyName("supportingAccessPointSelector")]
    public V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationSupportingAccessPointSelector? SupportingAccessPointSelector { get; set; }

    /// <summary>List of transformation configurations for the Object Lambda Access Point. See Transformation Configuration below for more details.</summary>
    [JsonPropertyName("transformationConfiguration")]
    public IList<V1beta1ObjectLambdaAccessPointSpecForProviderConfigurationTransformationConfiguration>? TransformationConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecForProvider
{
    /// <summary>The AWS account ID for the owner of the bucket for which you want to create an Object Lambda Access Point.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>A configuration block containing details about the Object Lambda Access Point. See Configuration below for more details.</summary>
    [JsonPropertyName("configuration")]
    public IList<V1beta1ObjectLambdaAccessPointSpecForProviderConfiguration>? Configuration { get; set; }

    /// <summary>The name for this Object Lambda Access Point.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationSupportingAccessPointRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a AccessPoint in s3control to populate supportingAccessPoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationSupportingAccessPointRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationSupportingAccessPointRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationSupportingAccessPointSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a AccessPoint in s3control to populate supportingAccessPoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationSupportingAccessPointSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationSupportingAccessPointSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationTransformationConfigurationContentTransformationAwsLambdaFunctionArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate functionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationTransformationConfigurationContentTransformationAwsLambdaFunctionArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationTransformationConfigurationContentTransformationAwsLambdaFunctionArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationTransformationConfigurationContentTransformationAwsLambdaFunctionArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate functionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationTransformationConfigurationContentTransformationAwsLambdaFunctionArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationTransformationConfigurationContentTransformationAwsLambdaFunctionArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationTransformationConfigurationContentTransformationAwsLambda
{
    /// <summary>The Amazon Resource Name (ARN) of the AWS Lambda function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate functionArn.</summary>
    [JsonPropertyName("functionArnRef")]
    public V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationTransformationConfigurationContentTransformationAwsLambdaFunctionArnRef? FunctionArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate functionArn.</summary>
    [JsonPropertyName("functionArnSelector")]
    public V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationTransformationConfigurationContentTransformationAwsLambdaFunctionArnSelector? FunctionArnSelector { get; set; }

    /// <summary>Additional JSON that provides supplemental data to the Lambda function used to transform objects.</summary>
    [JsonPropertyName("functionPayload")]
    public string? FunctionPayload { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationTransformationConfigurationContentTransformation
{
    /// <summary>Configuration for an AWS Lambda function. See AWS Lambda below for more details.</summary>
    [JsonPropertyName("awsLambda")]
    public IList<V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationTransformationConfigurationContentTransformationAwsLambda>? AwsLambda { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationTransformationConfiguration
{
    /// <summary>The actions of an Object Lambda Access Point configuration. Valid values: GetObject.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }

    /// <summary>The content transformation of an Object Lambda Access Point configuration. See Content Transformation below for more details.</summary>
    [JsonPropertyName("contentTransformation")]
    public IList<V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationTransformationConfigurationContentTransformation>? ContentTransformation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecInitProviderConfiguration
{
    /// <summary>Allowed features. Valid values: GetObject-Range, GetObject-PartNumber.</summary>
    [JsonPropertyName("allowedFeatures")]
    public IList<string>? AllowedFeatures { get; set; }

    /// <summary>Whether or not the CloudWatch metrics configuration is enabled.</summary>
    [JsonPropertyName("cloudWatchMetricsEnabled")]
    public bool? CloudWatchMetricsEnabled { get; set; }

    /// <summary>Standard access point associated with the Object Lambda Access Point.</summary>
    [JsonPropertyName("supportingAccessPoint")]
    public string? SupportingAccessPoint { get; set; }

    /// <summary>Reference to a AccessPoint in s3control to populate supportingAccessPoint.</summary>
    [JsonPropertyName("supportingAccessPointRef")]
    public V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationSupportingAccessPointRef? SupportingAccessPointRef { get; set; }

    /// <summary>Selector for a AccessPoint in s3control to populate supportingAccessPoint.</summary>
    [JsonPropertyName("supportingAccessPointSelector")]
    public V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationSupportingAccessPointSelector? SupportingAccessPointSelector { get; set; }

    /// <summary>List of transformation configurations for the Object Lambda Access Point. See Transformation Configuration below for more details.</summary>
    [JsonPropertyName("transformationConfiguration")]
    public IList<V1beta1ObjectLambdaAccessPointSpecInitProviderConfigurationTransformationConfiguration>? TransformationConfiguration { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecInitProvider
{
    /// <summary>The AWS account ID for the owner of the bucket for which you want to create an Object Lambda Access Point.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>A configuration block containing details about the Object Lambda Access Point. See Configuration below for more details.</summary>
    [JsonPropertyName("configuration")]
    public IList<V1beta1ObjectLambdaAccessPointSpecInitProviderConfiguration>? Configuration { get; set; }

    /// <summary>The name for this Object Lambda Access Point.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecProviderConfigRefPolicy
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
public partial class V1beta1ObjectLambdaAccessPointSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ObjectLambdaAccessPointSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1ObjectLambdaAccessPointSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ObjectLambdaAccessPointSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ObjectLambdaAccessPointSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ObjectLambdaAccessPointSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ObjectLambdaAccessPointSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ObjectLambdaAccessPointSpec defines the desired state of ObjectLambdaAccessPoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ObjectLambdaAccessPointSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ObjectLambdaAccessPointSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ObjectLambdaAccessPointSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ObjectLambdaAccessPointSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ObjectLambdaAccessPointSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointStatusAtProviderConfigurationTransformationConfigurationContentTransformationAwsLambda
{
    /// <summary>The Amazon Resource Name (ARN) of the AWS Lambda function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }

    /// <summary>Additional JSON that provides supplemental data to the Lambda function used to transform objects.</summary>
    [JsonPropertyName("functionPayload")]
    public string? FunctionPayload { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointStatusAtProviderConfigurationTransformationConfigurationContentTransformation
{
    /// <summary>Configuration for an AWS Lambda function. See AWS Lambda below for more details.</summary>
    [JsonPropertyName("awsLambda")]
    public IList<V1beta1ObjectLambdaAccessPointStatusAtProviderConfigurationTransformationConfigurationContentTransformationAwsLambda>? AwsLambda { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointStatusAtProviderConfigurationTransformationConfiguration
{
    /// <summary>The actions of an Object Lambda Access Point configuration. Valid values: GetObject.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }

    /// <summary>The content transformation of an Object Lambda Access Point configuration. See Content Transformation below for more details.</summary>
    [JsonPropertyName("contentTransformation")]
    public IList<V1beta1ObjectLambdaAccessPointStatusAtProviderConfigurationTransformationConfigurationContentTransformation>? ContentTransformation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointStatusAtProviderConfiguration
{
    /// <summary>Allowed features. Valid values: GetObject-Range, GetObject-PartNumber.</summary>
    [JsonPropertyName("allowedFeatures")]
    public IList<string>? AllowedFeatures { get; set; }

    /// <summary>Whether or not the CloudWatch metrics configuration is enabled.</summary>
    [JsonPropertyName("cloudWatchMetricsEnabled")]
    public bool? CloudWatchMetricsEnabled { get; set; }

    /// <summary>Standard access point associated with the Object Lambda Access Point.</summary>
    [JsonPropertyName("supportingAccessPoint")]
    public string? SupportingAccessPoint { get; set; }

    /// <summary>List of transformation configurations for the Object Lambda Access Point. See Transformation Configuration below for more details.</summary>
    [JsonPropertyName("transformationConfiguration")]
    public IList<V1beta1ObjectLambdaAccessPointStatusAtProviderConfigurationTransformationConfiguration>? TransformationConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointStatusAtProvider
{
    /// <summary>The AWS account ID for the owner of the bucket for which you want to create an Object Lambda Access Point.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Alias for the S3 Object Lambda Access Point.</summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Object Lambda Access Point.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A configuration block containing details about the Object Lambda Access Point. See Configuration below for more details.</summary>
    [JsonPropertyName("configuration")]
    public IList<V1beta1ObjectLambdaAccessPointStatusAtProviderConfiguration>? Configuration { get; set; }

    /// <summary>The AWS account ID and access point name separated by a colon (:).</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name for this Object Lambda Access Point.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointStatusConditions
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

/// <summary>ObjectLambdaAccessPointStatus defines the observed state of ObjectLambdaAccessPoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectLambdaAccessPointStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ObjectLambdaAccessPointStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ObjectLambdaAccessPointStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ObjectLambdaAccessPoint is the Schema for the ObjectLambdaAccessPoints API. Provides a resource to manage an S3 Object Lambda Access Point.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ObjectLambdaAccessPoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ObjectLambdaAccessPointSpec>, IStatus<V1beta1ObjectLambdaAccessPointStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ObjectLambdaAccessPoint";
    public const string KubeGroup = "s3control.aws.upbound.io";
    public const string KubePluralName = "objectlambdaaccesspoints";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ObjectLambdaAccessPointSpec defines the desired state of ObjectLambdaAccessPoint</summary>
    [JsonPropertyName("spec")]
    public V1beta1ObjectLambdaAccessPointSpec Spec { get; set; }

    /// <summary>ObjectLambdaAccessPointStatus defines the observed state of ObjectLambdaAccessPoint.</summary>
    [JsonPropertyName("status")]
    public V1beta1ObjectLambdaAccessPointStatus? Status { get; set; }
}