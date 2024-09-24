using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lambda.aws.upbound.io;
public enum V1beta1PermissionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1PermissionSpecForProviderFunctionNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionSpecForProviderFunctionNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PermissionSpecForProviderFunctionNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionSpecForProviderFunctionNameRefPolicyResolutionEnum>))]
    public V1beta1PermissionSpecForProviderFunctionNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionSpecForProviderFunctionNameRefPolicyResolveEnum>))]
    public V1beta1PermissionSpecForProviderFunctionNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PermissionSpecForProviderFunctionNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionSpecForProviderFunctionNameRefPolicy? Policy { get; set; }
}

public enum V1beta1PermissionSpecForProviderFunctionNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionSpecForProviderFunctionNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PermissionSpecForProviderFunctionNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionSpecForProviderFunctionNameSelectorPolicyResolutionEnum>))]
    public V1beta1PermissionSpecForProviderFunctionNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionSpecForProviderFunctionNameSelectorPolicyResolveEnum>))]
    public V1beta1PermissionSpecForProviderFunctionNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PermissionSpecForProviderFunctionNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionSpecForProviderFunctionNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1PermissionSpecForProviderQualifierRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionSpecForProviderQualifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PermissionSpecForProviderQualifierRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionSpecForProviderQualifierRefPolicyResolutionEnum>))]
    public V1beta1PermissionSpecForProviderQualifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionSpecForProviderQualifierRefPolicyResolveEnum>))]
    public V1beta1PermissionSpecForProviderQualifierRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PermissionSpecForProviderQualifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionSpecForProviderQualifierRefPolicy? Policy { get; set; }
}

public enum V1beta1PermissionSpecForProviderQualifierSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionSpecForProviderQualifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PermissionSpecForProviderQualifierSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionSpecForProviderQualifierSelectorPolicyResolutionEnum>))]
    public V1beta1PermissionSpecForProviderQualifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionSpecForProviderQualifierSelectorPolicyResolveEnum>))]
    public V1beta1PermissionSpecForProviderQualifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PermissionSpecForProviderQualifierSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionSpecForProviderQualifierSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1PermissionSpecForProvider
{
    /// <summary>The AWS Lambda action you want to allow in this statement. (e.g., lambda:InvokeFunction)</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Event Source Token to validate.  Used with Alexa Skills.</summary>
    [JsonPropertyName("eventSourceToken")]
    public string? EventSourceToken { get; set; }

    /// <summary>Name of the Lambda function whose resource policy you are updating</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>Reference to a Function in lambda to populate functionName.</summary>
    [JsonPropertyName("functionNameRef")]
    public V1beta1PermissionSpecForProviderFunctionNameRef? FunctionNameRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate functionName.</summary>
    [JsonPropertyName("functionNameSelector")]
    public V1beta1PermissionSpecForProviderFunctionNameSelector? FunctionNameSelector { get; set; }

    /// <summary>Lambda Function URLs authentication type. Valid values are: AWS_IAM or NONE. Only supported for lambda:InvokeFunctionUrl action.</summary>
    [JsonPropertyName("functionUrlAuthType")]
    public string? FunctionUrlAuthType { get; set; }

    /// <summary>The principal who is getting this permission e.g., s3.amazonaws.com, an AWS account ID, or AWS IAM principal, or AWS service principal such as events.amazonaws.com or sns.amazonaws.com.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }

    /// <summary>The identifier for your organization in AWS Organizations. Use this to grant permissions to all the AWS accounts under this organization.</summary>
    [JsonPropertyName("principalOrgId")]
    public string? PrincipalOrgId { get; set; }

    /// <summary>Query parameter to specify function version or alias name. The permission will then apply to the specific qualified ARN e.g., arn:aws:lambda:aws-region:acct-id:function:function-name:2</summary>
    [JsonPropertyName("qualifier")]
    public string? Qualifier { get; set; }

    /// <summary>Reference to a Alias in lambda to populate qualifier.</summary>
    [JsonPropertyName("qualifierRef")]
    public V1beta1PermissionSpecForProviderQualifierRef? QualifierRef { get; set; }

    /// <summary>Selector for a Alias in lambda to populate qualifier.</summary>
    [JsonPropertyName("qualifierSelector")]
    public V1beta1PermissionSpecForProviderQualifierSelector? QualifierSelector { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>This parameter is used when allowing cross-account access, or for S3 and SES. The AWS account ID (without a hyphen) of the source owner.</summary>
    [JsonPropertyName("sourceAccount")]
    public string? SourceAccount { get; set; }

    /// <summary>When the principal is an AWS service, the ARN of the specific resource within that service to grant permission to. Without this, any resource from principal will be granted permission – even if that resource is from another account. For S3, this should be the ARN of the S3 Bucket. For EventBridge events, this should be the ARN of the EventBridge Rule. For API Gateway, this should be the ARN of the API, as described here.</summary>
    [JsonPropertyName("sourceArn")]
    public string? SourceArn { get; set; }

    /// <summary>A unique statement identifier.</summary>
    [JsonPropertyName("statementId")]
    public string? StatementId { get; set; }

    /// <summary>A statement identifier prefix. Conflicts with statement_id.</summary>
    [JsonPropertyName("statementIdPrefix")]
    public string? StatementIdPrefix { get; set; }
}

public enum V1beta1PermissionSpecInitProviderFunctionNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionSpecInitProviderFunctionNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PermissionSpecInitProviderFunctionNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionSpecInitProviderFunctionNameRefPolicyResolutionEnum>))]
    public V1beta1PermissionSpecInitProviderFunctionNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionSpecInitProviderFunctionNameRefPolicyResolveEnum>))]
    public V1beta1PermissionSpecInitProviderFunctionNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PermissionSpecInitProviderFunctionNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionSpecInitProviderFunctionNameRefPolicy? Policy { get; set; }
}

public enum V1beta1PermissionSpecInitProviderFunctionNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionSpecInitProviderFunctionNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PermissionSpecInitProviderFunctionNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionSpecInitProviderFunctionNameSelectorPolicyResolutionEnum>))]
    public V1beta1PermissionSpecInitProviderFunctionNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionSpecInitProviderFunctionNameSelectorPolicyResolveEnum>))]
    public V1beta1PermissionSpecInitProviderFunctionNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PermissionSpecInitProviderFunctionNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionSpecInitProviderFunctionNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1PermissionSpecInitProviderQualifierRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionSpecInitProviderQualifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PermissionSpecInitProviderQualifierRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionSpecInitProviderQualifierRefPolicyResolutionEnum>))]
    public V1beta1PermissionSpecInitProviderQualifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionSpecInitProviderQualifierRefPolicyResolveEnum>))]
    public V1beta1PermissionSpecInitProviderQualifierRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PermissionSpecInitProviderQualifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionSpecInitProviderQualifierRefPolicy? Policy { get; set; }
}

public enum V1beta1PermissionSpecInitProviderQualifierSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionSpecInitProviderQualifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PermissionSpecInitProviderQualifierSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionSpecInitProviderQualifierSelectorPolicyResolutionEnum>))]
    public V1beta1PermissionSpecInitProviderQualifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionSpecInitProviderQualifierSelectorPolicyResolveEnum>))]
    public V1beta1PermissionSpecInitProviderQualifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PermissionSpecInitProviderQualifierSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionSpecInitProviderQualifierSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1PermissionSpecInitProvider
{
    /// <summary>The AWS Lambda action you want to allow in this statement. (e.g., lambda:InvokeFunction)</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Event Source Token to validate.  Used with Alexa Skills.</summary>
    [JsonPropertyName("eventSourceToken")]
    public string? EventSourceToken { get; set; }

    /// <summary>Name of the Lambda function whose resource policy you are updating</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>Reference to a Function in lambda to populate functionName.</summary>
    [JsonPropertyName("functionNameRef")]
    public V1beta1PermissionSpecInitProviderFunctionNameRef? FunctionNameRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate functionName.</summary>
    [JsonPropertyName("functionNameSelector")]
    public V1beta1PermissionSpecInitProviderFunctionNameSelector? FunctionNameSelector { get; set; }

    /// <summary>Lambda Function URLs authentication type. Valid values are: AWS_IAM or NONE. Only supported for lambda:InvokeFunctionUrl action.</summary>
    [JsonPropertyName("functionUrlAuthType")]
    public string? FunctionUrlAuthType { get; set; }

    /// <summary>The principal who is getting this permission e.g., s3.amazonaws.com, an AWS account ID, or AWS IAM principal, or AWS service principal such as events.amazonaws.com or sns.amazonaws.com.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }

    /// <summary>The identifier for your organization in AWS Organizations. Use this to grant permissions to all the AWS accounts under this organization.</summary>
    [JsonPropertyName("principalOrgId")]
    public string? PrincipalOrgId { get; set; }

    /// <summary>Query parameter to specify function version or alias name. The permission will then apply to the specific qualified ARN e.g., arn:aws:lambda:aws-region:acct-id:function:function-name:2</summary>
    [JsonPropertyName("qualifier")]
    public string? Qualifier { get; set; }

    /// <summary>Reference to a Alias in lambda to populate qualifier.</summary>
    [JsonPropertyName("qualifierRef")]
    public V1beta1PermissionSpecInitProviderQualifierRef? QualifierRef { get; set; }

    /// <summary>Selector for a Alias in lambda to populate qualifier.</summary>
    [JsonPropertyName("qualifierSelector")]
    public V1beta1PermissionSpecInitProviderQualifierSelector? QualifierSelector { get; set; }

    /// <summary>This parameter is used when allowing cross-account access, or for S3 and SES. The AWS account ID (without a hyphen) of the source owner.</summary>
    [JsonPropertyName("sourceAccount")]
    public string? SourceAccount { get; set; }

    /// <summary>When the principal is an AWS service, the ARN of the specific resource within that service to grant permission to. Without this, any resource from principal will be granted permission – even if that resource is from another account. For S3, this should be the ARN of the S3 Bucket. For EventBridge events, this should be the ARN of the EventBridge Rule. For API Gateway, this should be the ARN of the API, as described here.</summary>
    [JsonPropertyName("sourceArn")]
    public string? SourceArn { get; set; }

    /// <summary>A unique statement identifier.</summary>
    [JsonPropertyName("statementId")]
    public string? StatementId { get; set; }

    /// <summary>A statement identifier prefix. Conflicts with statement_id.</summary>
    [JsonPropertyName("statementIdPrefix")]
    public string? StatementIdPrefix { get; set; }
}

public enum V1beta1PermissionSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

public enum V1beta1PermissionSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PermissionSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1PermissionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1PermissionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PermissionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1PermissionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PermissionSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1PermissionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1PermissionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PermissionSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1PermissionSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1PermissionSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1PermissionSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1PermissionSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1PermissionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1PermissionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionSpecDeletionPolicyEnum>))]
    public V1beta1PermissionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PermissionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PermissionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PermissionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PermissionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1PermissionSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PermissionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1PermissionStatusAtProvider
{
    /// <summary>The AWS Lambda action you want to allow in this statement. (e.g., lambda:InvokeFunction)</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Event Source Token to validate.  Used with Alexa Skills.</summary>
    [JsonPropertyName("eventSourceToken")]
    public string? EventSourceToken { get; set; }

    /// <summary>Name of the Lambda function whose resource policy you are updating</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>Lambda Function URLs authentication type. Valid values are: AWS_IAM or NONE. Only supported for lambda:InvokeFunctionUrl action.</summary>
    [JsonPropertyName("functionUrlAuthType")]
    public string? FunctionUrlAuthType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The principal who is getting this permission e.g., s3.amazonaws.com, an AWS account ID, or AWS IAM principal, or AWS service principal such as events.amazonaws.com or sns.amazonaws.com.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }

    /// <summary>The identifier for your organization in AWS Organizations. Use this to grant permissions to all the AWS accounts under this organization.</summary>
    [JsonPropertyName("principalOrgId")]
    public string? PrincipalOrgId { get; set; }

    /// <summary>Query parameter to specify function version or alias name. The permission will then apply to the specific qualified ARN e.g., arn:aws:lambda:aws-region:acct-id:function:function-name:2</summary>
    [JsonPropertyName("qualifier")]
    public string? Qualifier { get; set; }

    /// <summary>This parameter is used when allowing cross-account access, or for S3 and SES. The AWS account ID (without a hyphen) of the source owner.</summary>
    [JsonPropertyName("sourceAccount")]
    public string? SourceAccount { get; set; }

    /// <summary>When the principal is an AWS service, the ARN of the specific resource within that service to grant permission to. Without this, any resource from principal will be granted permission – even if that resource is from another account. For S3, this should be the ARN of the S3 Bucket. For EventBridge events, this should be the ARN of the EventBridge Rule. For API Gateway, this should be the ARN of the API, as described here.</summary>
    [JsonPropertyName("sourceArn")]
    public string? SourceArn { get; set; }

    /// <summary>A unique statement identifier.</summary>
    [JsonPropertyName("statementId")]
    public string? StatementId { get; set; }

    /// <summary>A statement identifier prefix. Conflicts with statement_id.</summary>
    [JsonPropertyName("statementIdPrefix")]
    public string? StatementIdPrefix { get; set; }
}

public partial class V1beta1PermissionStatusConditions
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

public partial class V1beta1PermissionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PermissionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PermissionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Permission : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PermissionSpec>, IStatus<V1beta1PermissionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Permission";
    public const string KubeGroup = "lambda.aws.upbound.io";
    public const string KubePluralName = "permissions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PermissionSpec defines the desired state of Permission</summary>
    [JsonPropertyName("spec")]
    public V1beta1PermissionSpec Spec { get; set; }

    /// <summary>PermissionStatus defines the observed state of Permission.</summary>
    [JsonPropertyName("status")]
    public V1beta1PermissionStatus? Status { get; set; }
}