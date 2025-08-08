using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ses.aws.m.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleSpecForProviderAddHeaderAction
{
    /// <summary>The name of the header to add</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>The position of the action in the receipt rule</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleSpecForProviderBounceAction
{
    /// <summary>The message to send</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The position of the action in the receipt rule</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

    /// <summary>The email address of the sender</summary>
    [JsonPropertyName("sender")]
    public string? Sender { get; set; }

    /// <summary>The RFC 5321 SMTP reply code</summary>
    [JsonPropertyName("smtpReplyCode")]
    public string? SmtpReplyCode { get; set; }

    /// <summary>The RFC 3463 SMTP enhanced status code</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }

    /// <summary>The ARN of an SNS topic to notify</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleSpecForProviderLambdaAction
{
    /// <summary>The ARN of the Lambda function to invoke</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }

    /// <summary>Event or RequestResponse</summary>
    [JsonPropertyName("invocationType")]
    public string? InvocationType { get; set; }

    /// <summary>The position of the action in the receipt rule</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

    /// <summary>The ARN of an SNS topic to notify</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleSpecForProviderS3Action
{
    /// <summary>The name of the S3 bucket</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The ARN of the IAM role to be used by Amazon Simple Email Service while writing to the Amazon S3 bucket, optionally encrypting your mail via the provided customer managed key, and publishing to the Amazon SNS topic</summary>
    [JsonPropertyName("iamRoleArn")]
    public string? IamRoleArn { get; set; }

    /// <summary>The ARN of the KMS key</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The key prefix of the S3 bucket</summary>
    [JsonPropertyName("objectKeyPrefix")]
    public string? ObjectKeyPrefix { get; set; }

    /// <summary>The position of the action in the receipt rule</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

    /// <summary>The ARN of an SNS topic to notify</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleSpecForProviderSnsAction
{
    /// <summary>The encoding to use for the email within the Amazon SNS notification. Default value is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The position of the action in the receipt rule</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

    /// <summary>The ARN of an SNS topic to notify</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleSpecForProviderStopAction
{
    /// <summary>The position of the action in the receipt rule</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

    /// <summary>The scope to apply. The only acceptable value is RuleSet.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>The ARN of an SNS topic to notify</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleSpecForProviderWorkmailAction
{
    /// <summary>The ARN of the WorkMail organization</summary>
    [JsonPropertyName("organizationArn")]
    public string? OrganizationArn { get; set; }

    /// <summary>The position of the action in the receipt rule</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

    /// <summary>The ARN of an SNS topic to notify</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleSpecForProvider
{
    /// <summary>A list of Add Header Action blocks. Documented below.</summary>
    [JsonPropertyName("addHeaderAction")]
    public IList<V1beta1ReceiptRuleSpecForProviderAddHeaderAction>? AddHeaderAction { get; set; }

    /// <summary>The name of the rule to place this rule after</summary>
    [JsonPropertyName("after")]
    public string? After { get; set; }

    /// <summary>A list of Bounce Action blocks. Documented below.</summary>
    [JsonPropertyName("bounceAction")]
    public IList<V1beta1ReceiptRuleSpecForProviderBounceAction>? BounceAction { get; set; }

    /// <summary>If true, the rule will be enabled</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A list of Lambda Action blocks. Documented below.</summary>
    [JsonPropertyName("lambdaAction")]
    public IList<V1beta1ReceiptRuleSpecForProviderLambdaAction>? LambdaAction { get; set; }

    /// <summary>The name of the rule</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of email addresses</summary>
    [JsonPropertyName("recipients")]
    public IList<string>? Recipients { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The name of the rule set</summary>
    [JsonPropertyName("ruleSetName")]
    public string? RuleSetName { get; set; }

    /// <summary>A list of S3 Action blocks. Documented below.</summary>
    [JsonPropertyName("s3Action")]
    public IList<V1beta1ReceiptRuleSpecForProviderS3Action>? S3Action { get; set; }

    /// <summary>If true, incoming emails will be scanned for spam and viruses</summary>
    [JsonPropertyName("scanEnabled")]
    public bool? ScanEnabled { get; set; }

    /// <summary>A list of SNS Action blocks. Documented below.</summary>
    [JsonPropertyName("snsAction")]
    public IList<V1beta1ReceiptRuleSpecForProviderSnsAction>? SnsAction { get; set; }

    /// <summary>A list of Stop Action blocks. Documented below.</summary>
    [JsonPropertyName("stopAction")]
    public IList<V1beta1ReceiptRuleSpecForProviderStopAction>? StopAction { get; set; }

    /// <summary>Require or Optional</summary>
    [JsonPropertyName("tlsPolicy")]
    public string? TlsPolicy { get; set; }

    /// <summary>A list of WorkMail Action blocks. Documented below.</summary>
    [JsonPropertyName("workmailAction")]
    public IList<V1beta1ReceiptRuleSpecForProviderWorkmailAction>? WorkmailAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleSpecInitProviderAddHeaderAction
{
    /// <summary>The name of the header to add</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>The position of the action in the receipt rule</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleSpecInitProviderBounceAction
{
    /// <summary>The message to send</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The position of the action in the receipt rule</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

    /// <summary>The email address of the sender</summary>
    [JsonPropertyName("sender")]
    public string? Sender { get; set; }

    /// <summary>The RFC 5321 SMTP reply code</summary>
    [JsonPropertyName("smtpReplyCode")]
    public string? SmtpReplyCode { get; set; }

    /// <summary>The RFC 3463 SMTP enhanced status code</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }

    /// <summary>The ARN of an SNS topic to notify</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleSpecInitProviderLambdaAction
{
    /// <summary>The ARN of the Lambda function to invoke</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }

    /// <summary>Event or RequestResponse</summary>
    [JsonPropertyName("invocationType")]
    public string? InvocationType { get; set; }

    /// <summary>The position of the action in the receipt rule</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

    /// <summary>The ARN of an SNS topic to notify</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleSpecInitProviderS3Action
{
    /// <summary>The name of the S3 bucket</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The ARN of the IAM role to be used by Amazon Simple Email Service while writing to the Amazon S3 bucket, optionally encrypting your mail via the provided customer managed key, and publishing to the Amazon SNS topic</summary>
    [JsonPropertyName("iamRoleArn")]
    public string? IamRoleArn { get; set; }

    /// <summary>The ARN of the KMS key</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The key prefix of the S3 bucket</summary>
    [JsonPropertyName("objectKeyPrefix")]
    public string? ObjectKeyPrefix { get; set; }

    /// <summary>The position of the action in the receipt rule</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

    /// <summary>The ARN of an SNS topic to notify</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleSpecInitProviderSnsAction
{
    /// <summary>The encoding to use for the email within the Amazon SNS notification. Default value is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The position of the action in the receipt rule</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

    /// <summary>The ARN of an SNS topic to notify</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleSpecInitProviderStopAction
{
    /// <summary>The position of the action in the receipt rule</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

    /// <summary>The scope to apply. The only acceptable value is RuleSet.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>The ARN of an SNS topic to notify</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleSpecInitProviderWorkmailAction
{
    /// <summary>The ARN of the WorkMail organization</summary>
    [JsonPropertyName("organizationArn")]
    public string? OrganizationArn { get; set; }

    /// <summary>The position of the action in the receipt rule</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

    /// <summary>The ARN of an SNS topic to notify</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleSpecInitProvider
{
    /// <summary>A list of Add Header Action blocks. Documented below.</summary>
    [JsonPropertyName("addHeaderAction")]
    public IList<V1beta1ReceiptRuleSpecInitProviderAddHeaderAction>? AddHeaderAction { get; set; }

    /// <summary>The name of the rule to place this rule after</summary>
    [JsonPropertyName("after")]
    public string? After { get; set; }

    /// <summary>A list of Bounce Action blocks. Documented below.</summary>
    [JsonPropertyName("bounceAction")]
    public IList<V1beta1ReceiptRuleSpecInitProviderBounceAction>? BounceAction { get; set; }

    /// <summary>If true, the rule will be enabled</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A list of Lambda Action blocks. Documented below.</summary>
    [JsonPropertyName("lambdaAction")]
    public IList<V1beta1ReceiptRuleSpecInitProviderLambdaAction>? LambdaAction { get; set; }

    /// <summary>The name of the rule</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of email addresses</summary>
    [JsonPropertyName("recipients")]
    public IList<string>? Recipients { get; set; }

    /// <summary>The name of the rule set</summary>
    [JsonPropertyName("ruleSetName")]
    public string? RuleSetName { get; set; }

    /// <summary>A list of S3 Action blocks. Documented below.</summary>
    [JsonPropertyName("s3Action")]
    public IList<V1beta1ReceiptRuleSpecInitProviderS3Action>? S3Action { get; set; }

    /// <summary>If true, incoming emails will be scanned for spam and viruses</summary>
    [JsonPropertyName("scanEnabled")]
    public bool? ScanEnabled { get; set; }

    /// <summary>A list of SNS Action blocks. Documented below.</summary>
    [JsonPropertyName("snsAction")]
    public IList<V1beta1ReceiptRuleSpecInitProviderSnsAction>? SnsAction { get; set; }

    /// <summary>A list of Stop Action blocks. Documented below.</summary>
    [JsonPropertyName("stopAction")]
    public IList<V1beta1ReceiptRuleSpecInitProviderStopAction>? StopAction { get; set; }

    /// <summary>Require or Optional</summary>
    [JsonPropertyName("tlsPolicy")]
    public string? TlsPolicy { get; set; }

    /// <summary>A list of WorkMail Action blocks. Documented below.</summary>
    [JsonPropertyName("workmailAction")]
    public IList<V1beta1ReceiptRuleSpecInitProviderWorkmailAction>? WorkmailAction { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleSpecProviderConfigRef
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
public partial class V1beta1ReceiptRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ReceiptRuleSpec defines the desired state of ReceiptRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ReceiptRuleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ReceiptRuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ReceiptRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ReceiptRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleStatusAtProviderAddHeaderAction
{
    /// <summary>The name of the header to add</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>The position of the action in the receipt rule</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleStatusAtProviderBounceAction
{
    /// <summary>The message to send</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The position of the action in the receipt rule</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

    /// <summary>The email address of the sender</summary>
    [JsonPropertyName("sender")]
    public string? Sender { get; set; }

    /// <summary>The RFC 5321 SMTP reply code</summary>
    [JsonPropertyName("smtpReplyCode")]
    public string? SmtpReplyCode { get; set; }

    /// <summary>The RFC 3463 SMTP enhanced status code</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }

    /// <summary>The ARN of an SNS topic to notify</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleStatusAtProviderLambdaAction
{
    /// <summary>The ARN of the Lambda function to invoke</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }

    /// <summary>Event or RequestResponse</summary>
    [JsonPropertyName("invocationType")]
    public string? InvocationType { get; set; }

    /// <summary>The position of the action in the receipt rule</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

    /// <summary>The ARN of an SNS topic to notify</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleStatusAtProviderS3Action
{
    /// <summary>The name of the S3 bucket</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The ARN of the IAM role to be used by Amazon Simple Email Service while writing to the Amazon S3 bucket, optionally encrypting your mail via the provided customer managed key, and publishing to the Amazon SNS topic</summary>
    [JsonPropertyName("iamRoleArn")]
    public string? IamRoleArn { get; set; }

    /// <summary>The ARN of the KMS key</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The key prefix of the S3 bucket</summary>
    [JsonPropertyName("objectKeyPrefix")]
    public string? ObjectKeyPrefix { get; set; }

    /// <summary>The position of the action in the receipt rule</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

    /// <summary>The ARN of an SNS topic to notify</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleStatusAtProviderSnsAction
{
    /// <summary>The encoding to use for the email within the Amazon SNS notification. Default value is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The position of the action in the receipt rule</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

    /// <summary>The ARN of an SNS topic to notify</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleStatusAtProviderStopAction
{
    /// <summary>The position of the action in the receipt rule</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

    /// <summary>The scope to apply. The only acceptable value is RuleSet.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>The ARN of an SNS topic to notify</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleStatusAtProviderWorkmailAction
{
    /// <summary>The ARN of the WorkMail organization</summary>
    [JsonPropertyName("organizationArn")]
    public string? OrganizationArn { get; set; }

    /// <summary>The position of the action in the receipt rule</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

    /// <summary>The ARN of an SNS topic to notify</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleStatusAtProvider
{
    /// <summary>A list of Add Header Action blocks. Documented below.</summary>
    [JsonPropertyName("addHeaderAction")]
    public IList<V1beta1ReceiptRuleStatusAtProviderAddHeaderAction>? AddHeaderAction { get; set; }

    /// <summary>The name of the rule to place this rule after</summary>
    [JsonPropertyName("after")]
    public string? After { get; set; }

    /// <summary>The SES receipt rule ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A list of Bounce Action blocks. Documented below.</summary>
    [JsonPropertyName("bounceAction")]
    public IList<V1beta1ReceiptRuleStatusAtProviderBounceAction>? BounceAction { get; set; }

    /// <summary>If true, the rule will be enabled</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The SES receipt rule name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of Lambda Action blocks. Documented below.</summary>
    [JsonPropertyName("lambdaAction")]
    public IList<V1beta1ReceiptRuleStatusAtProviderLambdaAction>? LambdaAction { get; set; }

    /// <summary>The name of the rule</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of email addresses</summary>
    [JsonPropertyName("recipients")]
    public IList<string>? Recipients { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The name of the rule set</summary>
    [JsonPropertyName("ruleSetName")]
    public string? RuleSetName { get; set; }

    /// <summary>A list of S3 Action blocks. Documented below.</summary>
    [JsonPropertyName("s3Action")]
    public IList<V1beta1ReceiptRuleStatusAtProviderS3Action>? S3Action { get; set; }

    /// <summary>If true, incoming emails will be scanned for spam and viruses</summary>
    [JsonPropertyName("scanEnabled")]
    public bool? ScanEnabled { get; set; }

    /// <summary>A list of SNS Action blocks. Documented below.</summary>
    [JsonPropertyName("snsAction")]
    public IList<V1beta1ReceiptRuleStatusAtProviderSnsAction>? SnsAction { get; set; }

    /// <summary>A list of Stop Action blocks. Documented below.</summary>
    [JsonPropertyName("stopAction")]
    public IList<V1beta1ReceiptRuleStatusAtProviderStopAction>? StopAction { get; set; }

    /// <summary>Require or Optional</summary>
    [JsonPropertyName("tlsPolicy")]
    public string? TlsPolicy { get; set; }

    /// <summary>A list of WorkMail Action blocks. Documented below.</summary>
    [JsonPropertyName("workmailAction")]
    public IList<V1beta1ReceiptRuleStatusAtProviderWorkmailAction>? WorkmailAction { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleStatusConditions
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

/// <summary>ReceiptRuleStatus defines the observed state of ReceiptRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReceiptRuleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ReceiptRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ReceiptRuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ReceiptRule is the Schema for the ReceiptRules API. Provides an SES receipt rule resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ReceiptRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ReceiptRuleSpec>, IStatus<V1beta1ReceiptRuleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ReceiptRule";
    public const string KubeGroup = "ses.aws.m.upbound.io";
    public const string KubePluralName = "receiptrules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ReceiptRuleSpec defines the desired state of ReceiptRule</summary>
    [JsonPropertyName("spec")]
    public V1beta1ReceiptRuleSpec Spec { get; set; }

    /// <summary>ReceiptRuleStatus defines the observed state of ReceiptRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1ReceiptRuleStatus? Status { get; set; }
}

/// <summary>ReceiptRule is the Schema for the ReceiptRules API. Provides an SES receipt rule resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ReceiptRuleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ReceiptRule>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ReceiptRuleList";
    public const string KubeGroup = "ses.aws.m.upbound.io";
    public const string KubePluralName = "receiptrules";
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
    public IList<V1beta1ReceiptRule> Items { get; set; }
}