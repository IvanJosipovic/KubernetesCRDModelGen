using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lambda.aws.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderDeadLetterConfigTargetArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Queue in sqs to populate targetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderDeadLetterConfigTargetArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecForProviderDeadLetterConfigTargetArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderDeadLetterConfigTargetArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Queue in sqs to populate targetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderDeadLetterConfigTargetArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecForProviderDeadLetterConfigTargetArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderDeadLetterConfig
{
    /// <summary>ARN of an SNS topic or SQS queue to notify when an invocation fails.</summary>
    [JsonPropertyName("targetArn")]
    public string? TargetArn { get; set; }

    /// <summary>Reference to a Queue in sqs to populate targetArn.</summary>
    [JsonPropertyName("targetArnRef")]
    public V1beta1FunctionSpecForProviderDeadLetterConfigTargetArnRef? TargetArnRef { get; set; }

    /// <summary>Selector for a Queue in sqs to populate targetArn.</summary>
    [JsonPropertyName("targetArnSelector")]
    public V1beta1FunctionSpecForProviderDeadLetterConfigTargetArnSelector? TargetArnSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderEnvironment
{
    /// <summary>Map of environment variables available to your Lambda function during execution.</summary>
    [JsonPropertyName("variables")]
    public IDictionary<string, string>? Variables { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderEphemeralStorage
{
    /// <summary>Amount of ephemeral storage (/tmp) in MB. Valid between 512 MB and 10,240 MB (10 GB).</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderFileSystemConfigArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a AccessPoint in efs to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderFileSystemConfigArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecForProviderFileSystemConfigArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderFileSystemConfigArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a AccessPoint in efs to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderFileSystemConfigArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecForProviderFileSystemConfigArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderFileSystemConfig
{
    /// <summary>ARN of the Amazon EFS Access Point.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a AccessPoint in efs to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1FunctionSpecForProviderFileSystemConfigArnRef? ArnRef { get; set; }

    /// <summary>Selector for a AccessPoint in efs to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1FunctionSpecForProviderFileSystemConfigArnSelector? ArnSelector { get; set; }

    /// <summary>Path where the function can access the file system. Must start with /mnt/.</summary>
    [JsonPropertyName("localMountPath")]
    public string? LocalMountPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderImageConfig
{
    /// <summary>Parameters to pass to the container image.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Entry point to your application.</summary>
    [JsonPropertyName("entryPoint")]
    public IList<string>? EntryPoint { get; set; }

    /// <summary>Working directory for the container image.</summary>
    [JsonPropertyName("workingDirectory")]
    public string? WorkingDirectory { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderKmsKeyArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecForProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderKmsKeyArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderKmsKeyArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecForProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderLayersRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderLayersRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecForProviderLayersRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderLayersSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of LayerVersion in lambda to populate layers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderLayersSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecForProviderLayersSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderLoggingConfig
{
    /// <summary>Detail level of application logs. Valid values: TRACE, DEBUG, INFO, WARN, ERROR, FATAL.</summary>
    [JsonPropertyName("applicationLogLevel")]
    public string? ApplicationLogLevel { get; set; }

    /// <summary>Log format. Valid values: Text, JSON.</summary>
    [JsonPropertyName("logFormat")]
    public string? LogFormat { get; set; }

    /// <summary>CloudWatch log group where logs are sent.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }

    /// <summary>Detail level of Lambda platform logs. Valid values: DEBUG, INFO, WARN.</summary>
    [JsonPropertyName("systemLogLevel")]
    public string? SystemLogLevel { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderReplacementSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderReplacementSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecForProviderReplacementSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderReplacementSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate replacementSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderReplacementSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecForProviderReplacementSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderRoleRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecForProviderRoleRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderRoleSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderRoleSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecForProviderRoleSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderS3BucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate s3Bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderS3BucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecForProviderS3BucketRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderS3BucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate s3Bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderS3BucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecForProviderS3BucketSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderSnapStart
{
    /// <summary>When to apply snap start optimization. Valid value: PublishedVersions.</summary>
    [JsonPropertyName("applyOn")]
    public string? ApplyOn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderTracingConfig
{
    /// <summary>X-Ray tracing mode. Valid values: Active, PassThrough.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderVpcConfigSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderVpcConfigSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecForProviderVpcConfigSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderVpcConfigSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderVpcConfigSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecForProviderVpcConfigSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderVpcConfigSubnetIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderVpcConfigSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecForProviderVpcConfigSubnetIdRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderVpcConfigSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderVpcConfigSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecForProviderVpcConfigSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProviderVpcConfig
{
    /// <summary>Whether to allow outbound IPv6 traffic on VPC functions connected to dual-stack subnets. Default: false.</summary>
    [JsonPropertyName("ipv6AllowedForDualStack")]
    public bool? Ipv6AllowedForDualStack { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdRefs")]
    public IList<V1beta1FunctionSpecForProviderVpcConfigSecurityGroupIdRefs>? SecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta1FunctionSpecForProviderVpcConfigSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>List of security group IDs associated with the Lambda function.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta1FunctionSpecForProviderVpcConfigSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1FunctionSpecForProviderVpcConfigSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>List of subnet IDs associated with the Lambda function.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecForProvider
{
    /// <summary>Instruction set architecture for your Lambda function. Valid values are ["x86_64"] and ["arm64"]. Default is ["x86_64"]. Removing this attribute, function's architecture stays the same.</summary>
    [JsonPropertyName("architectures")]
    public IList<string>? Architectures { get; set; }

    /// <summary>ARN of a code-signing configuration to enable code signing for this function.</summary>
    [JsonPropertyName("codeSigningConfigArn")]
    public string? CodeSigningConfigArn { get; set; }

    /// <summary>Configuration block for dead letter queue. See below.</summary>
    [JsonPropertyName("deadLetterConfig")]
    public IList<V1beta1FunctionSpecForProviderDeadLetterConfig>? DeadLetterConfig { get; set; }

    /// <summary>Description of what your Lambda Function does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configuration block for environment variables. See below.</summary>
    [JsonPropertyName("environment")]
    public IList<V1beta1FunctionSpecForProviderEnvironment>? Environment { get; set; }

    /// <summary>Amount of ephemeral storage (/tmp) to allocate for the Lambda Function. See below.</summary>
    [JsonPropertyName("ephemeralStorage")]
    public IList<V1beta1FunctionSpecForProviderEphemeralStorage>? EphemeralStorage { get; set; }

    /// <summary>Configuration block for EFS file system. See below.</summary>
    [JsonPropertyName("fileSystemConfig")]
    public IList<V1beta1FunctionSpecForProviderFileSystemConfig>? FileSystemConfig { get; set; }

    /// <summary>Function entry point in your code. Required if package_type is Zip.</summary>
    [JsonPropertyName("handler")]
    public string? Handler { get; set; }

    /// <summary>Container image configuration values. See below.</summary>
    [JsonPropertyName("imageConfig")]
    public IList<V1beta1FunctionSpecForProviderImageConfig>? ImageConfig { get; set; }

    /// <summary>ECR image URI containing the function's deployment package. Conflicts with filename and s3_bucket. One of filename, image_uri, or s3_bucket must be specified.</summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }

    /// <summary>ARN of the AWS Key Management Service key used to encrypt environment variables. If not provided when environment variables are in use, AWS Lambda uses a default service key. If provided when environment variables are not in use, the AWS Lambda API does not save this configuration.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1FunctionSpecForProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1FunctionSpecForProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>List of Lambda Layer Version ARNs (maximum of 5) to attach to your Lambda Function.</summary>
    [JsonPropertyName("layers")]
    public IList<string>? Layers { get; set; }

    /// <summary>References to LayerVersion in lambda to populate layers.</summary>
    [JsonPropertyName("layersRefs")]
    public IList<V1beta1FunctionSpecForProviderLayersRefs>? LayersRefs { get; set; }

    /// <summary>Selector for a list of LayerVersion in lambda to populate layers.</summary>
    [JsonPropertyName("layersSelector")]
    public V1beta1FunctionSpecForProviderLayersSelector? LayersSelector { get; set; }

    /// <summary>Configuration block for advanced logging settings. See below.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1FunctionSpecForProviderLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>Amount of memory in MB your Lambda Function can use at runtime. Valid value between 128 MB to 10,240 MB (10 GB), in 1 MB increments. Defaults to 128.</summary>
    [JsonPropertyName("memorySize")]
    public double? MemorySize { get; set; }

    /// <summary>Lambda deployment package type. Valid values are Zip and Image. Defaults to Zip.</summary>
    [JsonPropertyName("packageType")]
    public string? PackageType { get; set; }

    /// <summary>Whether to publish creation/change as new Lambda Function Version. Defaults to false.</summary>
    [JsonPropertyName("publish")]
    public bool? Publish { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Whether to replace the security groups on the function's VPC configuration prior to destruction. Default is false.</summary>
    [JsonPropertyName("replaceSecurityGroupsOnDestroy")]
    public bool? ReplaceSecurityGroupsOnDestroy { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate replacementSecurityGroupIds.</summary>
    [JsonPropertyName("replacementSecurityGroupIdRefs")]
    public IList<V1beta1FunctionSpecForProviderReplacementSecurityGroupIdRefs>? ReplacementSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate replacementSecurityGroupIds.</summary>
    [JsonPropertyName("replacementSecurityGroupIdSelector")]
    public V1beta1FunctionSpecForProviderReplacementSecurityGroupIdSelector? ReplacementSecurityGroupIdSelector { get; set; }

    /// <summary>List of security group IDs to assign to the function's VPC configuration prior to destruction. Required if replace_security_groups_on_destroy is true.</summary>
    [JsonPropertyName("replacementSecurityGroupIds")]
    public IList<string>? ReplacementSecurityGroupIds { get; set; }

    /// <summary>Amount of reserved concurrent executions for this lambda function. A value of 0 disables lambda from being triggered and -1 removes any concurrency limitations. Defaults to Unreserved Concurrency Limits -1.</summary>
    [JsonPropertyName("reservedConcurrentExecutions")]
    public double? ReservedConcurrentExecutions { get; set; }

    /// <summary>ARN of the function's execution role. The role provides the function's identity and access to AWS services and resources.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Reference to a Role in iam to populate role.</summary>
    [JsonPropertyName("roleRef")]
    public V1beta1FunctionSpecForProviderRoleRef? RoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate role.</summary>
    [JsonPropertyName("roleSelector")]
    public V1beta1FunctionSpecForProviderRoleSelector? RoleSelector { get; set; }

    /// <summary>Identifier of the function's runtime. Required if package_type is Zip. See Runtimes for valid values.</summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>S3 bucket location containing the function's deployment package. Conflicts with filename and image_uri. One of filename, image_uri, or s3_bucket must be specified.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate s3Bucket.</summary>
    [JsonPropertyName("s3BucketRef")]
    public V1beta1FunctionSpecForProviderS3BucketRef? S3BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate s3Bucket.</summary>
    [JsonPropertyName("s3BucketSelector")]
    public V1beta1FunctionSpecForProviderS3BucketSelector? S3BucketSelector { get; set; }

    /// <summary>S3 key of an object containing the function's deployment package. Required if s3_bucket is set.</summary>
    [JsonPropertyName("s3Key")]
    public string? S3Key { get; set; }

    /// <summary>Object version containing the function's deployment package. Conflicts with filename and image_uri.</summary>
    [JsonPropertyName("s3ObjectVersion")]
    public string? S3ObjectVersion { get; set; }

    /// <summary>Whether to retain the old version of a previously deployed Lambda Layer. Default is false.</summary>
    [JsonPropertyName("skipDestroy")]
    public bool? SkipDestroy { get; set; }

    /// <summary>Configuration block for snap start settings. See below.</summary>
    [JsonPropertyName("snapStart")]
    public IList<V1beta1FunctionSpecForProviderSnapStart>? SnapStart { get; set; }

    /// <summary>Used to trigger updates. Must be set to a base64 encoded SHA256 hash of the package file specified with either filename or s3_key. If you have specified this field manually, it should be the actual (computed) hash of the underlying lambda function specified in the filename, image_uri, s3_bucket fields.</summary>
    [JsonPropertyName("sourceCodeHash")]
    public string? SourceCodeHash { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Amount of time your Lambda Function has to run in seconds. Defaults to 3. Valid between 1 and 900.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Configuration block for X-Ray tracing. See below.</summary>
    [JsonPropertyName("tracingConfig")]
    public IList<V1beta1FunctionSpecForProviderTracingConfig>? TracingConfig { get; set; }

    /// <summary>Configuration block for VPC. See below.</summary>
    [JsonPropertyName("vpcConfig")]
    public IList<V1beta1FunctionSpecForProviderVpcConfig>? VpcConfig { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderDeadLetterConfigTargetArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Queue in sqs to populate targetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderDeadLetterConfigTargetArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecInitProviderDeadLetterConfigTargetArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderDeadLetterConfigTargetArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Queue in sqs to populate targetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderDeadLetterConfigTargetArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecInitProviderDeadLetterConfigTargetArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderDeadLetterConfig
{
    /// <summary>ARN of an SNS topic or SQS queue to notify when an invocation fails.</summary>
    [JsonPropertyName("targetArn")]
    public string? TargetArn { get; set; }

    /// <summary>Reference to a Queue in sqs to populate targetArn.</summary>
    [JsonPropertyName("targetArnRef")]
    public V1beta1FunctionSpecInitProviderDeadLetterConfigTargetArnRef? TargetArnRef { get; set; }

    /// <summary>Selector for a Queue in sqs to populate targetArn.</summary>
    [JsonPropertyName("targetArnSelector")]
    public V1beta1FunctionSpecInitProviderDeadLetterConfigTargetArnSelector? TargetArnSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderEnvironment
{
    /// <summary>Map of environment variables available to your Lambda function during execution.</summary>
    [JsonPropertyName("variables")]
    public IDictionary<string, string>? Variables { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderEphemeralStorage
{
    /// <summary>Amount of ephemeral storage (/tmp) in MB. Valid between 512 MB and 10,240 MB (10 GB).</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderFileSystemConfigArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a AccessPoint in efs to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderFileSystemConfigArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecInitProviderFileSystemConfigArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderFileSystemConfigArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a AccessPoint in efs to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderFileSystemConfigArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecInitProviderFileSystemConfigArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderFileSystemConfig
{
    /// <summary>ARN of the Amazon EFS Access Point.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a AccessPoint in efs to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1FunctionSpecInitProviderFileSystemConfigArnRef? ArnRef { get; set; }

    /// <summary>Selector for a AccessPoint in efs to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1FunctionSpecInitProviderFileSystemConfigArnSelector? ArnSelector { get; set; }

    /// <summary>Path where the function can access the file system. Must start with /mnt/.</summary>
    [JsonPropertyName("localMountPath")]
    public string? LocalMountPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderImageConfig
{
    /// <summary>Parameters to pass to the container image.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Entry point to your application.</summary>
    [JsonPropertyName("entryPoint")]
    public IList<string>? EntryPoint { get; set; }

    /// <summary>Working directory for the container image.</summary>
    [JsonPropertyName("workingDirectory")]
    public string? WorkingDirectory { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderKmsKeyArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecInitProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderKmsKeyArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderKmsKeyArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecInitProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderLayersRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderLayersRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecInitProviderLayersRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderLayersSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of LayerVersion in lambda to populate layers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderLayersSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecInitProviderLayersSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderLoggingConfig
{
    /// <summary>Detail level of application logs. Valid values: TRACE, DEBUG, INFO, WARN, ERROR, FATAL.</summary>
    [JsonPropertyName("applicationLogLevel")]
    public string? ApplicationLogLevel { get; set; }

    /// <summary>Log format. Valid values: Text, JSON.</summary>
    [JsonPropertyName("logFormat")]
    public string? LogFormat { get; set; }

    /// <summary>CloudWatch log group where logs are sent.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }

    /// <summary>Detail level of Lambda platform logs. Valid values: DEBUG, INFO, WARN.</summary>
    [JsonPropertyName("systemLogLevel")]
    public string? SystemLogLevel { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderReplacementSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderReplacementSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecInitProviderReplacementSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderReplacementSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate replacementSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderReplacementSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecInitProviderReplacementSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderRoleRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecInitProviderRoleRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderRoleSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderRoleSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecInitProviderRoleSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderS3BucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate s3Bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderS3BucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecInitProviderS3BucketRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderS3BucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate s3Bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderS3BucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecInitProviderS3BucketSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderSnapStart
{
    /// <summary>When to apply snap start optimization. Valid value: PublishedVersions.</summary>
    [JsonPropertyName("applyOn")]
    public string? ApplyOn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderTracingConfig
{
    /// <summary>X-Ray tracing mode. Valid values: Active, PassThrough.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderVpcConfigSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderVpcConfigSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecInitProviderVpcConfigSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderVpcConfigSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderVpcConfigSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecInitProviderVpcConfigSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderVpcConfigSubnetIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderVpcConfigSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecInitProviderVpcConfigSubnetIdRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderVpcConfigSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderVpcConfigSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecInitProviderVpcConfigSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProviderVpcConfig
{
    /// <summary>Whether to allow outbound IPv6 traffic on VPC functions connected to dual-stack subnets. Default: false.</summary>
    [JsonPropertyName("ipv6AllowedForDualStack")]
    public bool? Ipv6AllowedForDualStack { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdRefs")]
    public IList<V1beta1FunctionSpecInitProviderVpcConfigSecurityGroupIdRefs>? SecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta1FunctionSpecInitProviderVpcConfigSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>List of security group IDs associated with the Lambda function.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta1FunctionSpecInitProviderVpcConfigSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1FunctionSpecInitProviderVpcConfigSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>List of subnet IDs associated with the Lambda function.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecInitProvider
{
    /// <summary>Instruction set architecture for your Lambda function. Valid values are ["x86_64"] and ["arm64"]. Default is ["x86_64"]. Removing this attribute, function's architecture stays the same.</summary>
    [JsonPropertyName("architectures")]
    public IList<string>? Architectures { get; set; }

    /// <summary>ARN of a code-signing configuration to enable code signing for this function.</summary>
    [JsonPropertyName("codeSigningConfigArn")]
    public string? CodeSigningConfigArn { get; set; }

    /// <summary>Configuration block for dead letter queue. See below.</summary>
    [JsonPropertyName("deadLetterConfig")]
    public IList<V1beta1FunctionSpecInitProviderDeadLetterConfig>? DeadLetterConfig { get; set; }

    /// <summary>Description of what your Lambda Function does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configuration block for environment variables. See below.</summary>
    [JsonPropertyName("environment")]
    public IList<V1beta1FunctionSpecInitProviderEnvironment>? Environment { get; set; }

    /// <summary>Amount of ephemeral storage (/tmp) to allocate for the Lambda Function. See below.</summary>
    [JsonPropertyName("ephemeralStorage")]
    public IList<V1beta1FunctionSpecInitProviderEphemeralStorage>? EphemeralStorage { get; set; }

    /// <summary>Configuration block for EFS file system. See below.</summary>
    [JsonPropertyName("fileSystemConfig")]
    public IList<V1beta1FunctionSpecInitProviderFileSystemConfig>? FileSystemConfig { get; set; }

    /// <summary>Function entry point in your code. Required if package_type is Zip.</summary>
    [JsonPropertyName("handler")]
    public string? Handler { get; set; }

    /// <summary>Container image configuration values. See below.</summary>
    [JsonPropertyName("imageConfig")]
    public IList<V1beta1FunctionSpecInitProviderImageConfig>? ImageConfig { get; set; }

    /// <summary>ECR image URI containing the function's deployment package. Conflicts with filename and s3_bucket. One of filename, image_uri, or s3_bucket must be specified.</summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }

    /// <summary>ARN of the AWS Key Management Service key used to encrypt environment variables. If not provided when environment variables are in use, AWS Lambda uses a default service key. If provided when environment variables are not in use, the AWS Lambda API does not save this configuration.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1FunctionSpecInitProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1FunctionSpecInitProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>List of Lambda Layer Version ARNs (maximum of 5) to attach to your Lambda Function.</summary>
    [JsonPropertyName("layers")]
    public IList<string>? Layers { get; set; }

    /// <summary>References to LayerVersion in lambda to populate layers.</summary>
    [JsonPropertyName("layersRefs")]
    public IList<V1beta1FunctionSpecInitProviderLayersRefs>? LayersRefs { get; set; }

    /// <summary>Selector for a list of LayerVersion in lambda to populate layers.</summary>
    [JsonPropertyName("layersSelector")]
    public V1beta1FunctionSpecInitProviderLayersSelector? LayersSelector { get; set; }

    /// <summary>Configuration block for advanced logging settings. See below.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1FunctionSpecInitProviderLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>Amount of memory in MB your Lambda Function can use at runtime. Valid value between 128 MB to 10,240 MB (10 GB), in 1 MB increments. Defaults to 128.</summary>
    [JsonPropertyName("memorySize")]
    public double? MemorySize { get; set; }

    /// <summary>Lambda deployment package type. Valid values are Zip and Image. Defaults to Zip.</summary>
    [JsonPropertyName("packageType")]
    public string? PackageType { get; set; }

    /// <summary>Whether to publish creation/change as new Lambda Function Version. Defaults to false.</summary>
    [JsonPropertyName("publish")]
    public bool? Publish { get; set; }

    /// <summary>Whether to replace the security groups on the function's VPC configuration prior to destruction. Default is false.</summary>
    [JsonPropertyName("replaceSecurityGroupsOnDestroy")]
    public bool? ReplaceSecurityGroupsOnDestroy { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate replacementSecurityGroupIds.</summary>
    [JsonPropertyName("replacementSecurityGroupIdRefs")]
    public IList<V1beta1FunctionSpecInitProviderReplacementSecurityGroupIdRefs>? ReplacementSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate replacementSecurityGroupIds.</summary>
    [JsonPropertyName("replacementSecurityGroupIdSelector")]
    public V1beta1FunctionSpecInitProviderReplacementSecurityGroupIdSelector? ReplacementSecurityGroupIdSelector { get; set; }

    /// <summary>List of security group IDs to assign to the function's VPC configuration prior to destruction. Required if replace_security_groups_on_destroy is true.</summary>
    [JsonPropertyName("replacementSecurityGroupIds")]
    public IList<string>? ReplacementSecurityGroupIds { get; set; }

    /// <summary>Amount of reserved concurrent executions for this lambda function. A value of 0 disables lambda from being triggered and -1 removes any concurrency limitations. Defaults to Unreserved Concurrency Limits -1.</summary>
    [JsonPropertyName("reservedConcurrentExecutions")]
    public double? ReservedConcurrentExecutions { get; set; }

    /// <summary>ARN of the function's execution role. The role provides the function's identity and access to AWS services and resources.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Reference to a Role in iam to populate role.</summary>
    [JsonPropertyName("roleRef")]
    public V1beta1FunctionSpecInitProviderRoleRef? RoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate role.</summary>
    [JsonPropertyName("roleSelector")]
    public V1beta1FunctionSpecInitProviderRoleSelector? RoleSelector { get; set; }

    /// <summary>Identifier of the function's runtime. Required if package_type is Zip. See Runtimes for valid values.</summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>S3 bucket location containing the function's deployment package. Conflicts with filename and image_uri. One of filename, image_uri, or s3_bucket must be specified.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate s3Bucket.</summary>
    [JsonPropertyName("s3BucketRef")]
    public V1beta1FunctionSpecInitProviderS3BucketRef? S3BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate s3Bucket.</summary>
    [JsonPropertyName("s3BucketSelector")]
    public V1beta1FunctionSpecInitProviderS3BucketSelector? S3BucketSelector { get; set; }

    /// <summary>S3 key of an object containing the function's deployment package. Required if s3_bucket is set.</summary>
    [JsonPropertyName("s3Key")]
    public string? S3Key { get; set; }

    /// <summary>Object version containing the function's deployment package. Conflicts with filename and image_uri.</summary>
    [JsonPropertyName("s3ObjectVersion")]
    public string? S3ObjectVersion { get; set; }

    /// <summary>Whether to retain the old version of a previously deployed Lambda Layer. Default is false.</summary>
    [JsonPropertyName("skipDestroy")]
    public bool? SkipDestroy { get; set; }

    /// <summary>Configuration block for snap start settings. See below.</summary>
    [JsonPropertyName("snapStart")]
    public IList<V1beta1FunctionSpecInitProviderSnapStart>? SnapStart { get; set; }

    /// <summary>Used to trigger updates. Must be set to a base64 encoded SHA256 hash of the package file specified with either filename or s3_key. If you have specified this field manually, it should be the actual (computed) hash of the underlying lambda function specified in the filename, image_uri, s3_bucket fields.</summary>
    [JsonPropertyName("sourceCodeHash")]
    public string? SourceCodeHash { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Amount of time your Lambda Function has to run in seconds. Defaults to 3. Valid between 1 and 900.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Configuration block for X-Ray tracing. See below.</summary>
    [JsonPropertyName("tracingConfig")]
    public IList<V1beta1FunctionSpecInitProviderTracingConfig>? TracingConfig { get; set; }

    /// <summary>Configuration block for VPC. See below.</summary>
    [JsonPropertyName("vpcConfig")]
    public IList<V1beta1FunctionSpecInitProviderVpcConfig>? VpcConfig { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecProviderConfigRefPolicy
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
public partial class V1beta1FunctionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>FunctionSpec defines the desired state of Function</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FunctionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FunctionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FunctionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FunctionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionStatusAtProviderDeadLetterConfig
{
    /// <summary>ARN of an SNS topic or SQS queue to notify when an invocation fails.</summary>
    [JsonPropertyName("targetArn")]
    public string? TargetArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionStatusAtProviderEnvironment
{
    /// <summary>Map of environment variables available to your Lambda function during execution.</summary>
    [JsonPropertyName("variables")]
    public IDictionary<string, string>? Variables { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionStatusAtProviderEphemeralStorage
{
    /// <summary>Amount of ephemeral storage (/tmp) in MB. Valid between 512 MB and 10,240 MB (10 GB).</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionStatusAtProviderFileSystemConfig
{
    /// <summary>ARN of the Amazon EFS Access Point.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Path where the function can access the file system. Must start with /mnt/.</summary>
    [JsonPropertyName("localMountPath")]
    public string? LocalMountPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionStatusAtProviderImageConfig
{
    /// <summary>Parameters to pass to the container image.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Entry point to your application.</summary>
    [JsonPropertyName("entryPoint")]
    public IList<string>? EntryPoint { get; set; }

    /// <summary>Working directory for the container image.</summary>
    [JsonPropertyName("workingDirectory")]
    public string? WorkingDirectory { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionStatusAtProviderLoggingConfig
{
    /// <summary>Detail level of application logs. Valid values: TRACE, DEBUG, INFO, WARN, ERROR, FATAL.</summary>
    [JsonPropertyName("applicationLogLevel")]
    public string? ApplicationLogLevel { get; set; }

    /// <summary>Log format. Valid values: Text, JSON.</summary>
    [JsonPropertyName("logFormat")]
    public string? LogFormat { get; set; }

    /// <summary>CloudWatch log group where logs are sent.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }

    /// <summary>Detail level of Lambda platform logs. Valid values: DEBUG, INFO, WARN.</summary>
    [JsonPropertyName("systemLogLevel")]
    public string? SystemLogLevel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionStatusAtProviderSnapStart
{
    /// <summary>When to apply snap start optimization. Valid value: PublishedVersions.</summary>
    [JsonPropertyName("applyOn")]
    public string? ApplyOn { get; set; }

    /// <summary>Optimization status of the snap start configuration. Valid values are On and Off.</summary>
    [JsonPropertyName("optimizationStatus")]
    public string? OptimizationStatus { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionStatusAtProviderTracingConfig
{
    /// <summary>X-Ray tracing mode. Valid values: Active, PassThrough.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionStatusAtProviderVpcConfig
{
    /// <summary>Whether to allow outbound IPv6 traffic on VPC functions connected to dual-stack subnets. Default: false.</summary>
    [JsonPropertyName("ipv6AllowedForDualStack")]
    public bool? Ipv6AllowedForDualStack { get; set; }

    /// <summary>List of security group IDs associated with the Lambda function.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>List of subnet IDs associated with the Lambda function.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>ID of the VPC.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionStatusAtProvider
{
    /// <summary>Instruction set architecture for your Lambda function. Valid values are ["x86_64"] and ["arm64"]. Default is ["x86_64"]. Removing this attribute, function's architecture stays the same.</summary>
    [JsonPropertyName("architectures")]
    public IList<string>? Architectures { get; set; }

    /// <summary>ARN identifying your Lambda Function.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Base64-encoded representation of raw SHA-256 sum of the zip file.</summary>
    [JsonPropertyName("codeSha256")]
    public string? CodeSha256 { get; set; }

    /// <summary>ARN of a code-signing configuration to enable code signing for this function.</summary>
    [JsonPropertyName("codeSigningConfigArn")]
    public string? CodeSigningConfigArn { get; set; }

    /// <summary>Configuration block for dead letter queue. See below.</summary>
    [JsonPropertyName("deadLetterConfig")]
    public IList<V1beta1FunctionStatusAtProviderDeadLetterConfig>? DeadLetterConfig { get; set; }

    /// <summary>Description of what your Lambda Function does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configuration block for environment variables. See below.</summary>
    [JsonPropertyName("environment")]
    public IList<V1beta1FunctionStatusAtProviderEnvironment>? Environment { get; set; }

    /// <summary>Amount of ephemeral storage (/tmp) to allocate for the Lambda Function. See below.</summary>
    [JsonPropertyName("ephemeralStorage")]
    public IList<V1beta1FunctionStatusAtProviderEphemeralStorage>? EphemeralStorage { get; set; }

    /// <summary>Configuration block for EFS file system. See below.</summary>
    [JsonPropertyName("fileSystemConfig")]
    public IList<V1beta1FunctionStatusAtProviderFileSystemConfig>? FileSystemConfig { get; set; }

    /// <summary>Function entry point in your code. Required if package_type is Zip.</summary>
    [JsonPropertyName("handler")]
    public string? Handler { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Container image configuration values. See below.</summary>
    [JsonPropertyName("imageConfig")]
    public IList<V1beta1FunctionStatusAtProviderImageConfig>? ImageConfig { get; set; }

    /// <summary>ECR image URI containing the function's deployment package. Conflicts with filename and s3_bucket. One of filename, image_uri, or s3_bucket must be specified.</summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }

    /// <summary>ARN to be used for invoking Lambda Function from API Gateway - to be used in aws_api_gateway_integration's uri.</summary>
    [JsonPropertyName("invokeArn")]
    public string? InvokeArn { get; set; }

    /// <summary>ARN of the AWS Key Management Service key used to encrypt environment variables. If not provided when environment variables are in use, AWS Lambda uses a default service key. If provided when environment variables are not in use, the AWS Lambda API does not save this configuration.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Date this resource was last modified.</summary>
    [JsonPropertyName("lastModified")]
    public string? LastModified { get; set; }

    /// <summary>List of Lambda Layer Version ARNs (maximum of 5) to attach to your Lambda Function.</summary>
    [JsonPropertyName("layers")]
    public IList<string>? Layers { get; set; }

    /// <summary>Configuration block for advanced logging settings. See below.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1FunctionStatusAtProviderLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>Amount of memory in MB your Lambda Function can use at runtime. Valid value between 128 MB to 10,240 MB (10 GB), in 1 MB increments. Defaults to 128.</summary>
    [JsonPropertyName("memorySize")]
    public double? MemorySize { get; set; }

    /// <summary>Lambda deployment package type. Valid values are Zip and Image. Defaults to Zip.</summary>
    [JsonPropertyName("packageType")]
    public string? PackageType { get; set; }

    /// <summary>Whether to publish creation/change as new Lambda Function Version. Defaults to false.</summary>
    [JsonPropertyName("publish")]
    public bool? Publish { get; set; }

    /// <summary>ARN identifying your Lambda Function Version (if versioning is enabled via publish = true).</summary>
    [JsonPropertyName("qualifiedArn")]
    public string? QualifiedArn { get; set; }

    /// <summary>Qualified ARN (ARN with lambda version number) to be used for invoking Lambda Function from API Gateway - to be used in aws_api_gateway_integration's uri.</summary>
    [JsonPropertyName("qualifiedInvokeArn")]
    public string? QualifiedInvokeArn { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Whether to replace the security groups on the function's VPC configuration prior to destruction. Default is false.</summary>
    [JsonPropertyName("replaceSecurityGroupsOnDestroy")]
    public bool? ReplaceSecurityGroupsOnDestroy { get; set; }

    /// <summary>List of security group IDs to assign to the function's VPC configuration prior to destruction. Required if replace_security_groups_on_destroy is true.</summary>
    [JsonPropertyName("replacementSecurityGroupIds")]
    public IList<string>? ReplacementSecurityGroupIds { get; set; }

    /// <summary>Amount of reserved concurrent executions for this lambda function. A value of 0 disables lambda from being triggered and -1 removes any concurrency limitations. Defaults to Unreserved Concurrency Limits -1.</summary>
    [JsonPropertyName("reservedConcurrentExecutions")]
    public double? ReservedConcurrentExecutions { get; set; }

    /// <summary>ARN of the function's execution role. The role provides the function's identity and access to AWS services and resources.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Identifier of the function's runtime. Required if package_type is Zip. See Runtimes for valid values.</summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>S3 bucket location containing the function's deployment package. Conflicts with filename and image_uri. One of filename, image_uri, or s3_bucket must be specified.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }

    /// <summary>S3 key of an object containing the function's deployment package. Required if s3_bucket is set.</summary>
    [JsonPropertyName("s3Key")]
    public string? S3Key { get; set; }

    /// <summary>Object version containing the function's deployment package. Conflicts with filename and image_uri.</summary>
    [JsonPropertyName("s3ObjectVersion")]
    public string? S3ObjectVersion { get; set; }

    /// <summary>ARN of the signing job.</summary>
    [JsonPropertyName("signingJobArn")]
    public string? SigningJobArn { get; set; }

    /// <summary>ARN of the signing profile version.</summary>
    [JsonPropertyName("signingProfileVersionArn")]
    public string? SigningProfileVersionArn { get; set; }

    /// <summary>Whether to retain the old version of a previously deployed Lambda Layer. Default is false.</summary>
    [JsonPropertyName("skipDestroy")]
    public bool? SkipDestroy { get; set; }

    /// <summary>Configuration block for snap start settings. See below.</summary>
    [JsonPropertyName("snapStart")]
    public IList<V1beta1FunctionStatusAtProviderSnapStart>? SnapStart { get; set; }

    /// <summary>Used to trigger updates. Must be set to a base64 encoded SHA256 hash of the package file specified with either filename or s3_key. If you have specified this field manually, it should be the actual (computed) hash of the underlying lambda function specified in the filename, image_uri, s3_bucket fields.</summary>
    [JsonPropertyName("sourceCodeHash")]
    public string? SourceCodeHash { get; set; }

    /// <summary>Size in bytes of the function .zip file.</summary>
    [JsonPropertyName("sourceCodeSize")]
    public double? SourceCodeSize { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Amount of time your Lambda Function has to run in seconds. Defaults to 3. Valid between 1 and 900.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Configuration block for X-Ray tracing. See below.</summary>
    [JsonPropertyName("tracingConfig")]
    public IList<V1beta1FunctionStatusAtProviderTracingConfig>? TracingConfig { get; set; }

    /// <summary>Latest published version of your Lambda Function.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Configuration block for VPC. See below.</summary>
    [JsonPropertyName("vpcConfig")]
    public IList<V1beta1FunctionStatusAtProviderVpcConfig>? VpcConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionStatusConditions
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

/// <summary>FunctionStatus defines the observed state of Function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FunctionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FunctionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Function is the Schema for the Functions API. Manages an AWS Lambda Function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Function : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FunctionSpec>, IStatus<V1beta1FunctionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Function";
    public const string KubeGroup = "lambda.aws.upbound.io";
    public const string KubePluralName = "functions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FunctionSpec defines the desired state of Function</summary>
    [JsonPropertyName("spec")]
    public V1beta1FunctionSpec Spec { get; set; }

    /// <summary>FunctionStatus defines the observed state of Function.</summary>
    [JsonPropertyName("status")]
    public V1beta1FunctionStatus? Status { get; set; }
}

/// <summary>Function is the Schema for the Functions API. Manages an AWS Lambda Function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FunctionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Function>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FunctionList";
    public const string KubeGroup = "lambda.aws.upbound.io";
    public const string KubePluralName = "functions";
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
    public IList<V1beta1Function> Items { get; set; }
}