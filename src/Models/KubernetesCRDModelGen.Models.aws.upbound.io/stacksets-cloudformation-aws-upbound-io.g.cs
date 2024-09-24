using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudformation.aws.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetSpecForProviderAdministrationRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetSpecForProviderAdministrationRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecForProviderAdministrationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetSpecForProviderAdministrationRoleArnRefPolicyResolutionEnum>))]
    public V1beta1StackSetSpecForProviderAdministrationRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetSpecForProviderAdministrationRoleArnRefPolicyResolveEnum>))]
    public V1beta1StackSetSpecForProviderAdministrationRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate administrationRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecForProviderAdministrationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSetSpecForProviderAdministrationRoleArnRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetSpecForProviderAdministrationRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetSpecForProviderAdministrationRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecForProviderAdministrationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetSpecForProviderAdministrationRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1StackSetSpecForProviderAdministrationRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetSpecForProviderAdministrationRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1StackSetSpecForProviderAdministrationRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate administrationRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecForProviderAdministrationRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSetSpecForProviderAdministrationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecForProviderAutoDeployment
{
    /// <summary>Whether or not auto-deployment is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether or not to retain stacks when the account is removed.</summary>
    [JsonPropertyName("retainStacksOnAccountRemoval")]
    public bool? RetainStacksOnAccountRemoval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecForProviderManagedExecution
{
    /// <summary>When set to true, StackSets performs non-conflicting operations concurrently and queues conflicting operations. After conflicting operations finish, StackSets starts queued operations in request order. Default is false.</summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecForProviderOperationPreferences
{
    /// <summary>The number of accounts, per Region, for which this operation can fail before AWS CloudFormation stops the operation in that Region.</summary>
    [JsonPropertyName("failureToleranceCount")]
    public double? FailureToleranceCount { get; set; }

    /// <summary>The percentage of accounts, per Region, for which this stack operation can fail before AWS CloudFormation stops the operation in that Region.</summary>
    [JsonPropertyName("failureTolerancePercentage")]
    public double? FailureTolerancePercentage { get; set; }

    /// <summary>The maximum number of accounts in which to perform this operation at one time.</summary>
    [JsonPropertyName("maxConcurrentCount")]
    public double? MaxConcurrentCount { get; set; }

    /// <summary>The maximum percentage of accounts in which to perform this operation at one time.</summary>
    [JsonPropertyName("maxConcurrentPercentage")]
    public double? MaxConcurrentPercentage { get; set; }

    /// <summary>The concurrency type of deploying StackSets operations in Regions, could be in parallel or one Region at a time.</summary>
    [JsonPropertyName("regionConcurrencyType")]
    public string? RegionConcurrencyType { get; set; }

    /// <summary>The order of the Regions in where you want to perform the stack operation.</summary>
    [JsonPropertyName("regionOrder")]
    public IList<string>? RegionOrder { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecForProvider
{
    /// <summary>Amazon Resource Number (ARN) of the IAM Role in the administrator account. This must be defined when using the SELF_MANAGED permission model.</summary>
    [JsonPropertyName("administrationRoleArn")]
    public string? AdministrationRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate administrationRoleArn.</summary>
    [JsonPropertyName("administrationRoleArnRef")]
    public V1beta1StackSetSpecForProviderAdministrationRoleArnRef? AdministrationRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate administrationRoleArn.</summary>
    [JsonPropertyName("administrationRoleArnSelector")]
    public V1beta1StackSetSpecForProviderAdministrationRoleArnSelector? AdministrationRoleArnSelector { get; set; }

    /// <summary>Configuration block containing the auto-deployment model for your StackSet. This can only be defined when using the SERVICE_MANAGED permission model.</summary>
    [JsonPropertyName("autoDeployment")]
    public IList<V1beta1StackSetSpecForProviderAutoDeployment>? AutoDeployment { get; set; }

    /// <summary>Specifies whether you are acting as an account administrator in the organization's management account or as a delegated administrator in a member account. Valid values: SELF (default), DELEGATED_ADMIN.</summary>
    [JsonPropertyName("callAs")]
    public string? CallAs { get; set; }

    /// <summary>A list of capabilities. Valid values: CAPABILITY_IAM, CAPABILITY_NAMED_IAM, CAPABILITY_AUTO_EXPAND.</summary>
    [JsonPropertyName("capabilities")]
    public IList<string>? Capabilities { get; set; }

    /// <summary>Description of the StackSet.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the IAM Role in all target accounts for StackSet operations. Defaults to AWSCloudFormationStackSetExecutionRole when using the SELF_MANAGED permission model. This should not be defined when using the SERVICE_MANAGED permission model.</summary>
    [JsonPropertyName("executionRoleName")]
    public string? ExecutionRoleName { get; set; }

    /// <summary>Configuration block to allow StackSets to perform non-conflicting operations concurrently and queues conflicting operations.</summary>
    [JsonPropertyName("managedExecution")]
    public IList<V1beta1StackSetSpecForProviderManagedExecution>? ManagedExecution { get; set; }

    /// <summary>Preferences for how AWS CloudFormation performs a stack set update.</summary>
    [JsonPropertyName("operationPreferences")]
    public IList<V1beta1StackSetSpecForProviderOperationPreferences>? OperationPreferences { get; set; }

    /// <summary>Key-value map of input parameters for the StackSet template. All template parameters, including those with a Default, must be configured or ignored with lifecycle configuration block ignore_changes argument. All NoEcho template parameters must be ignored with the lifecycle configuration block ignore_changes argument.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Describes how the IAM roles required for your StackSet are created. Valid values: SELF_MANAGED (default), SERVICE_MANAGED.</summary>
    [JsonPropertyName("permissionModel")]
    public string? PermissionModel { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>String containing the CloudFormation template body. Maximum size: 51,200 bytes. Conflicts with template_url.</summary>
    [JsonPropertyName("templateBody")]
    public string? TemplateBody { get; set; }

    /// <summary>String containing the location of a file containing the CloudFormation template body. The URL must point to a template that is located in an Amazon S3 bucket. Maximum location file size: 460,800 bytes. Conflicts with template_body.</summary>
    [JsonPropertyName("templateUrl")]
    public string? TemplateUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetSpecInitProviderAdministrationRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetSpecInitProviderAdministrationRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecInitProviderAdministrationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetSpecInitProviderAdministrationRoleArnRefPolicyResolutionEnum>))]
    public V1beta1StackSetSpecInitProviderAdministrationRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetSpecInitProviderAdministrationRoleArnRefPolicyResolveEnum>))]
    public V1beta1StackSetSpecInitProviderAdministrationRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate administrationRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecInitProviderAdministrationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSetSpecInitProviderAdministrationRoleArnRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetSpecInitProviderAdministrationRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetSpecInitProviderAdministrationRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecInitProviderAdministrationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetSpecInitProviderAdministrationRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1StackSetSpecInitProviderAdministrationRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetSpecInitProviderAdministrationRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1StackSetSpecInitProviderAdministrationRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate administrationRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecInitProviderAdministrationRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSetSpecInitProviderAdministrationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecInitProviderAutoDeployment
{
    /// <summary>Whether or not auto-deployment is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether or not to retain stacks when the account is removed.</summary>
    [JsonPropertyName("retainStacksOnAccountRemoval")]
    public bool? RetainStacksOnAccountRemoval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecInitProviderManagedExecution
{
    /// <summary>When set to true, StackSets performs non-conflicting operations concurrently and queues conflicting operations. After conflicting operations finish, StackSets starts queued operations in request order. Default is false.</summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecInitProviderOperationPreferences
{
    /// <summary>The number of accounts, per Region, for which this operation can fail before AWS CloudFormation stops the operation in that Region.</summary>
    [JsonPropertyName("failureToleranceCount")]
    public double? FailureToleranceCount { get; set; }

    /// <summary>The percentage of accounts, per Region, for which this stack operation can fail before AWS CloudFormation stops the operation in that Region.</summary>
    [JsonPropertyName("failureTolerancePercentage")]
    public double? FailureTolerancePercentage { get; set; }

    /// <summary>The maximum number of accounts in which to perform this operation at one time.</summary>
    [JsonPropertyName("maxConcurrentCount")]
    public double? MaxConcurrentCount { get; set; }

    /// <summary>The maximum percentage of accounts in which to perform this operation at one time.</summary>
    [JsonPropertyName("maxConcurrentPercentage")]
    public double? MaxConcurrentPercentage { get; set; }

    /// <summary>The concurrency type of deploying StackSets operations in Regions, could be in parallel or one Region at a time.</summary>
    [JsonPropertyName("regionConcurrencyType")]
    public string? RegionConcurrencyType { get; set; }

    /// <summary>The order of the Regions in where you want to perform the stack operation.</summary>
    [JsonPropertyName("regionOrder")]
    public IList<string>? RegionOrder { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecInitProvider
{
    /// <summary>Amazon Resource Number (ARN) of the IAM Role in the administrator account. This must be defined when using the SELF_MANAGED permission model.</summary>
    [JsonPropertyName("administrationRoleArn")]
    public string? AdministrationRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate administrationRoleArn.</summary>
    [JsonPropertyName("administrationRoleArnRef")]
    public V1beta1StackSetSpecInitProviderAdministrationRoleArnRef? AdministrationRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate administrationRoleArn.</summary>
    [JsonPropertyName("administrationRoleArnSelector")]
    public V1beta1StackSetSpecInitProviderAdministrationRoleArnSelector? AdministrationRoleArnSelector { get; set; }

    /// <summary>Configuration block containing the auto-deployment model for your StackSet. This can only be defined when using the SERVICE_MANAGED permission model.</summary>
    [JsonPropertyName("autoDeployment")]
    public IList<V1beta1StackSetSpecInitProviderAutoDeployment>? AutoDeployment { get; set; }

    /// <summary>Specifies whether you are acting as an account administrator in the organization's management account or as a delegated administrator in a member account. Valid values: SELF (default), DELEGATED_ADMIN.</summary>
    [JsonPropertyName("callAs")]
    public string? CallAs { get; set; }

    /// <summary>A list of capabilities. Valid values: CAPABILITY_IAM, CAPABILITY_NAMED_IAM, CAPABILITY_AUTO_EXPAND.</summary>
    [JsonPropertyName("capabilities")]
    public IList<string>? Capabilities { get; set; }

    /// <summary>Description of the StackSet.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the IAM Role in all target accounts for StackSet operations. Defaults to AWSCloudFormationStackSetExecutionRole when using the SELF_MANAGED permission model. This should not be defined when using the SERVICE_MANAGED permission model.</summary>
    [JsonPropertyName("executionRoleName")]
    public string? ExecutionRoleName { get; set; }

    /// <summary>Configuration block to allow StackSets to perform non-conflicting operations concurrently and queues conflicting operations.</summary>
    [JsonPropertyName("managedExecution")]
    public IList<V1beta1StackSetSpecInitProviderManagedExecution>? ManagedExecution { get; set; }

    /// <summary>Preferences for how AWS CloudFormation performs a stack set update.</summary>
    [JsonPropertyName("operationPreferences")]
    public IList<V1beta1StackSetSpecInitProviderOperationPreferences>? OperationPreferences { get; set; }

    /// <summary>Key-value map of input parameters for the StackSet template. All template parameters, including those with a Default, must be configured or ignored with lifecycle configuration block ignore_changes argument. All NoEcho template parameters must be ignored with the lifecycle configuration block ignore_changes argument.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Describes how the IAM roles required for your StackSet are created. Valid values: SELF_MANAGED (default), SERVICE_MANAGED.</summary>
    [JsonPropertyName("permissionModel")]
    public string? PermissionModel { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>String containing the CloudFormation template body. Maximum size: 51,200 bytes. Conflicts with template_url.</summary>
    [JsonPropertyName("templateBody")]
    public string? TemplateBody { get; set; }

    /// <summary>String containing the location of a file containing the CloudFormation template body. The URL must point to a template that is located in an Amazon S3 bucket. Maximum location file size: 460,800 bytes. Conflicts with template_body.</summary>
    [JsonPropertyName("templateUrl")]
    public string? TemplateUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetSpecManagementPoliciesEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1StackSetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1StackSetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSetSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1StackSetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1StackSetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSetSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1StackSetSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1StackSetSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1StackSetSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>StackSetSpec defines the desired state of StackSet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetSpecDeletionPolicyEnum>))]
    public V1beta1StackSetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1StackSetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1StackSetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1StackSetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1StackSetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1StackSetSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1StackSetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetStatusAtProviderAutoDeployment
{
    /// <summary>Whether or not auto-deployment is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether or not to retain stacks when the account is removed.</summary>
    [JsonPropertyName("retainStacksOnAccountRemoval")]
    public bool? RetainStacksOnAccountRemoval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetStatusAtProviderManagedExecution
{
    /// <summary>When set to true, StackSets performs non-conflicting operations concurrently and queues conflicting operations. After conflicting operations finish, StackSets starts queued operations in request order. Default is false.</summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetStatusAtProviderOperationPreferences
{
    /// <summary>The number of accounts, per Region, for which this operation can fail before AWS CloudFormation stops the operation in that Region.</summary>
    [JsonPropertyName("failureToleranceCount")]
    public double? FailureToleranceCount { get; set; }

    /// <summary>The percentage of accounts, per Region, for which this stack operation can fail before AWS CloudFormation stops the operation in that Region.</summary>
    [JsonPropertyName("failureTolerancePercentage")]
    public double? FailureTolerancePercentage { get; set; }

    /// <summary>The maximum number of accounts in which to perform this operation at one time.</summary>
    [JsonPropertyName("maxConcurrentCount")]
    public double? MaxConcurrentCount { get; set; }

    /// <summary>The maximum percentage of accounts in which to perform this operation at one time.</summary>
    [JsonPropertyName("maxConcurrentPercentage")]
    public double? MaxConcurrentPercentage { get; set; }

    /// <summary>The concurrency type of deploying StackSets operations in Regions, could be in parallel or one Region at a time.</summary>
    [JsonPropertyName("regionConcurrencyType")]
    public string? RegionConcurrencyType { get; set; }

    /// <summary>The order of the Regions in where you want to perform the stack operation.</summary>
    [JsonPropertyName("regionOrder")]
    public IList<string>? RegionOrder { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetStatusAtProvider
{
    /// <summary>Amazon Resource Number (ARN) of the IAM Role in the administrator account. This must be defined when using the SELF_MANAGED permission model.</summary>
    [JsonPropertyName("administrationRoleArn")]
    public string? AdministrationRoleArn { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the StackSet.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Configuration block containing the auto-deployment model for your StackSet. This can only be defined when using the SERVICE_MANAGED permission model.</summary>
    [JsonPropertyName("autoDeployment")]
    public IList<V1beta1StackSetStatusAtProviderAutoDeployment>? AutoDeployment { get; set; }

    /// <summary>Specifies whether you are acting as an account administrator in the organization's management account or as a delegated administrator in a member account. Valid values: SELF (default), DELEGATED_ADMIN.</summary>
    [JsonPropertyName("callAs")]
    public string? CallAs { get; set; }

    /// <summary>A list of capabilities. Valid values: CAPABILITY_IAM, CAPABILITY_NAMED_IAM, CAPABILITY_AUTO_EXPAND.</summary>
    [JsonPropertyName("capabilities")]
    public IList<string>? Capabilities { get; set; }

    /// <summary>Description of the StackSet.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the IAM Role in all target accounts for StackSet operations. Defaults to AWSCloudFormationStackSetExecutionRole when using the SELF_MANAGED permission model. This should not be defined when using the SERVICE_MANAGED permission model.</summary>
    [JsonPropertyName("executionRoleName")]
    public string? ExecutionRoleName { get; set; }

    /// <summary>Name of the StackSet.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block to allow StackSets to perform non-conflicting operations concurrently and queues conflicting operations.</summary>
    [JsonPropertyName("managedExecution")]
    public IList<V1beta1StackSetStatusAtProviderManagedExecution>? ManagedExecution { get; set; }

    /// <summary>Preferences for how AWS CloudFormation performs a stack set update.</summary>
    [JsonPropertyName("operationPreferences")]
    public IList<V1beta1StackSetStatusAtProviderOperationPreferences>? OperationPreferences { get; set; }

    /// <summary>Key-value map of input parameters for the StackSet template. All template parameters, including those with a Default, must be configured or ignored with lifecycle configuration block ignore_changes argument. All NoEcho template parameters must be ignored with the lifecycle configuration block ignore_changes argument.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Describes how the IAM roles required for your StackSet are created. Valid values: SELF_MANAGED (default), SERVICE_MANAGED.</summary>
    [JsonPropertyName("permissionModel")]
    public string? PermissionModel { get; set; }

    /// <summary>Unique identifier of the StackSet.</summary>
    [JsonPropertyName("stackSetId")]
    public string? StackSetId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>String containing the CloudFormation template body. Maximum size: 51,200 bytes. Conflicts with template_url.</summary>
    [JsonPropertyName("templateBody")]
    public string? TemplateBody { get; set; }

    /// <summary>String containing the location of a file containing the CloudFormation template body. The URL must point to a template that is located in an Amazon S3 bucket. Maximum location file size: 460,800 bytes. Conflicts with template_body.</summary>
    [JsonPropertyName("templateUrl")]
    public string? TemplateUrl { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetStatusConditions
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

/// <summary>StackSetStatus defines the observed state of StackSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1StackSetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StackSetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>StackSet is the Schema for the StackSets API. Manages a CloudFormation StackSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StackSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StackSetSpec>, IStatus<V1beta1StackSetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StackSet";
    public const string KubeGroup = "cloudformation.aws.upbound.io";
    public const string KubePluralName = "stacksets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>StackSetSpec defines the desired state of StackSet</summary>
    [JsonPropertyName("spec")]
    public V1beta1StackSetSpec Spec { get; set; }

    /// <summary>StackSetStatus defines the observed state of StackSet.</summary>
    [JsonPropertyName("status")]
    public V1beta1StackSetStatus? Status { get; set; }
}