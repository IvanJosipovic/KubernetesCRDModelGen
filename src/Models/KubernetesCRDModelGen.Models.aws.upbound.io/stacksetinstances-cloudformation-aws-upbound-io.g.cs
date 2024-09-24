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
public enum V1beta1StackSetInstanceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecForProviderDeploymentTargets
{
    /// <summary>Limit deployment targets to individual accounts or include additional accounts with provided OUs. Valid values: INTERSECTION, DIFFERENCE, UNION, NONE.</summary>
    [JsonPropertyName("accountFilterType")]
    public string? AccountFilterType { get; set; }

    /// <summary>List of accounts to deploy stack set updates.</summary>
    [JsonPropertyName("accounts")]
    public IList<string>? Accounts { get; set; }

    /// <summary>S3 URL of the file containing the list of accounts.</summary>
    [JsonPropertyName("accountsUrl")]
    public string? AccountsUrl { get; set; }

    /// <summary>The organization root ID or organizational unit (OU) IDs to which StackSets deploys.</summary>
    [JsonPropertyName("organizationalUnitIds")]
    public IList<string>? OrganizationalUnitIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecForProviderOperationPreferences
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

    /// <summary>The concurrency type of deploying StackSets operations in Regions, could be in parallel or one Region at a time. Valid values are SEQUENTIAL and PARALLEL.</summary>
    [JsonPropertyName("regionConcurrencyType")]
    public string? RegionConcurrencyType { get; set; }

    /// <summary>The order of the Regions in where you want to perform the stack operation.</summary>
    [JsonPropertyName("regionOrder")]
    public IList<string>? RegionOrder { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetInstanceSpecForProviderStackSetNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetInstanceSpecForProviderStackSetNameRefPolicyResolveEnum
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
public partial class V1beta1StackSetInstanceSpecForProviderStackSetNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecForProviderStackSetNameRefPolicyResolutionEnum>))]
    public V1beta1StackSetInstanceSpecForProviderStackSetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecForProviderStackSetNameRefPolicyResolveEnum>))]
    public V1beta1StackSetInstanceSpecForProviderStackSetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a StackSet in cloudformation to populate stackSetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecForProviderStackSetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSetInstanceSpecForProviderStackSetNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetInstanceSpecForProviderStackSetNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetInstanceSpecForProviderStackSetNameSelectorPolicyResolveEnum
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
public partial class V1beta1StackSetInstanceSpecForProviderStackSetNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecForProviderStackSetNameSelectorPolicyResolutionEnum>))]
    public V1beta1StackSetInstanceSpecForProviderStackSetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecForProviderStackSetNameSelectorPolicyResolveEnum>))]
    public V1beta1StackSetInstanceSpecForProviderStackSetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a StackSet in cloudformation to populate stackSetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecForProviderStackSetNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSetInstanceSpecForProviderStackSetNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecForProvider
{
    /// <summary>Target AWS Account ID to create a Stack based on the StackSet. Defaults to current account.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Specifies whether you are acting as an account administrator in the organization's management account or as a delegated administrator in a member account. Valid values: SELF (default), DELEGATED_ADMIN.</summary>
    [JsonPropertyName("callAs")]
    public string? CallAs { get; set; }

    /// <summary>The AWS Organizations accounts to which StackSets deploys. StackSets doesn't deploy stack instances to the organization management account, even if the organization management account is in your organization or in an OU in your organization. Drift detection is not possible for this argument. See deployment_targets below.</summary>
    [JsonPropertyName("deploymentTargets")]
    public IList<V1beta1StackSetInstanceSpecForProviderDeploymentTargets>? DeploymentTargets { get; set; }

    /// <summary>Preferences for how AWS CloudFormation performs a stack set operation.</summary>
    [JsonPropertyName("operationPreferences")]
    public IList<V1beta1StackSetInstanceSpecForProviderOperationPreferences>? OperationPreferences { get; set; }

    /// <summary>Key-value map of input parameters to override from the StackSet for this Instance.</summary>
    [JsonPropertyName("parameterOverrides")]
    public IDictionary<string, string>? ParameterOverrides { get; set; }

    /// <summary>Target AWS Region to create a Stack based on the StackSet. Defaults to current region. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>You cannot reassociate a retained Stack or add an existing, saved Stack to a new StackSet. Defaults to false.</summary>
    [JsonPropertyName("retainStack")]
    public bool? RetainStack { get; set; }

    /// <summary>Name of the StackSet.</summary>
    [JsonPropertyName("stackSetName")]
    public string? StackSetName { get; set; }

    /// <summary>Reference to a StackSet in cloudformation to populate stackSetName.</summary>
    [JsonPropertyName("stackSetNameRef")]
    public V1beta1StackSetInstanceSpecForProviderStackSetNameRef? StackSetNameRef { get; set; }

    /// <summary>Selector for a StackSet in cloudformation to populate stackSetName.</summary>
    [JsonPropertyName("stackSetNameSelector")]
    public V1beta1StackSetInstanceSpecForProviderStackSetNameSelector? StackSetNameSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecInitProviderDeploymentTargets
{
    /// <summary>Limit deployment targets to individual accounts or include additional accounts with provided OUs. Valid values: INTERSECTION, DIFFERENCE, UNION, NONE.</summary>
    [JsonPropertyName("accountFilterType")]
    public string? AccountFilterType { get; set; }

    /// <summary>List of accounts to deploy stack set updates.</summary>
    [JsonPropertyName("accounts")]
    public IList<string>? Accounts { get; set; }

    /// <summary>S3 URL of the file containing the list of accounts.</summary>
    [JsonPropertyName("accountsUrl")]
    public string? AccountsUrl { get; set; }

    /// <summary>The organization root ID or organizational unit (OU) IDs to which StackSets deploys.</summary>
    [JsonPropertyName("organizationalUnitIds")]
    public IList<string>? OrganizationalUnitIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecInitProviderOperationPreferences
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

    /// <summary>The concurrency type of deploying StackSets operations in Regions, could be in parallel or one Region at a time. Valid values are SEQUENTIAL and PARALLEL.</summary>
    [JsonPropertyName("regionConcurrencyType")]
    public string? RegionConcurrencyType { get; set; }

    /// <summary>The order of the Regions in where you want to perform the stack operation.</summary>
    [JsonPropertyName("regionOrder")]
    public IList<string>? RegionOrder { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetInstanceSpecInitProviderStackSetNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetInstanceSpecInitProviderStackSetNameRefPolicyResolveEnum
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
public partial class V1beta1StackSetInstanceSpecInitProviderStackSetNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecInitProviderStackSetNameRefPolicyResolutionEnum>))]
    public V1beta1StackSetInstanceSpecInitProviderStackSetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecInitProviderStackSetNameRefPolicyResolveEnum>))]
    public V1beta1StackSetInstanceSpecInitProviderStackSetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a StackSet in cloudformation to populate stackSetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecInitProviderStackSetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSetInstanceSpecInitProviderStackSetNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetInstanceSpecInitProviderStackSetNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetInstanceSpecInitProviderStackSetNameSelectorPolicyResolveEnum
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
public partial class V1beta1StackSetInstanceSpecInitProviderStackSetNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecInitProviderStackSetNameSelectorPolicyResolutionEnum>))]
    public V1beta1StackSetInstanceSpecInitProviderStackSetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecInitProviderStackSetNameSelectorPolicyResolveEnum>))]
    public V1beta1StackSetInstanceSpecInitProviderStackSetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a StackSet in cloudformation to populate stackSetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecInitProviderStackSetNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSetInstanceSpecInitProviderStackSetNameSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecInitProvider
{
    /// <summary>Target AWS Account ID to create a Stack based on the StackSet. Defaults to current account.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Specifies whether you are acting as an account administrator in the organization's management account or as a delegated administrator in a member account. Valid values: SELF (default), DELEGATED_ADMIN.</summary>
    [JsonPropertyName("callAs")]
    public string? CallAs { get; set; }

    /// <summary>The AWS Organizations accounts to which StackSets deploys. StackSets doesn't deploy stack instances to the organization management account, even if the organization management account is in your organization or in an OU in your organization. Drift detection is not possible for this argument. See deployment_targets below.</summary>
    [JsonPropertyName("deploymentTargets")]
    public IList<V1beta1StackSetInstanceSpecInitProviderDeploymentTargets>? DeploymentTargets { get; set; }

    /// <summary>Preferences for how AWS CloudFormation performs a stack set operation.</summary>
    [JsonPropertyName("operationPreferences")]
    public IList<V1beta1StackSetInstanceSpecInitProviderOperationPreferences>? OperationPreferences { get; set; }

    /// <summary>Key-value map of input parameters to override from the StackSet for this Instance.</summary>
    [JsonPropertyName("parameterOverrides")]
    public IDictionary<string, string>? ParameterOverrides { get; set; }

    /// <summary>You cannot reassociate a retained Stack or add an existing, saved Stack to a new StackSet. Defaults to false.</summary>
    [JsonPropertyName("retainStack")]
    public bool? RetainStack { get; set; }

    /// <summary>Name of the StackSet.</summary>
    [JsonPropertyName("stackSetName")]
    public string? StackSetName { get; set; }

    /// <summary>Reference to a StackSet in cloudformation to populate stackSetName.</summary>
    [JsonPropertyName("stackSetNameRef")]
    public V1beta1StackSetInstanceSpecInitProviderStackSetNameRef? StackSetNameRef { get; set; }

    /// <summary>Selector for a StackSet in cloudformation to populate stackSetName.</summary>
    [JsonPropertyName("stackSetNameSelector")]
    public V1beta1StackSetInstanceSpecInitProviderStackSetNameSelector? StackSetNameSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetInstanceSpecManagementPoliciesEnum
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
public enum V1beta1StackSetInstanceSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetInstanceSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1StackSetInstanceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1StackSetInstanceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1StackSetInstanceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSetInstanceSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetInstanceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StackSetInstanceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1StackSetInstanceSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1StackSetInstanceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1StackSetInstanceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSetInstanceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1StackSetInstanceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1StackSetInstanceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1StackSetInstanceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>StackSetInstanceSpec defines the desired state of StackSetInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecDeletionPolicyEnum>))]
    public V1beta1StackSetInstanceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1StackSetInstanceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1StackSetInstanceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1StackSetInstanceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1StackSetInstanceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1StackSetInstanceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1StackSetInstanceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceStatusAtProviderDeploymentTargets
{
    /// <summary>Limit deployment targets to individual accounts or include additional accounts with provided OUs. Valid values: INTERSECTION, DIFFERENCE, UNION, NONE.</summary>
    [JsonPropertyName("accountFilterType")]
    public string? AccountFilterType { get; set; }

    /// <summary>List of accounts to deploy stack set updates.</summary>
    [JsonPropertyName("accounts")]
    public IList<string>? Accounts { get; set; }

    /// <summary>S3 URL of the file containing the list of accounts.</summary>
    [JsonPropertyName("accountsUrl")]
    public string? AccountsUrl { get; set; }

    /// <summary>The organization root ID or organizational unit (OU) IDs to which StackSets deploys.</summary>
    [JsonPropertyName("organizationalUnitIds")]
    public IList<string>? OrganizationalUnitIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceStatusAtProviderOperationPreferences
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

    /// <summary>The concurrency type of deploying StackSets operations in Regions, could be in parallel or one Region at a time. Valid values are SEQUENTIAL and PARALLEL.</summary>
    [JsonPropertyName("regionConcurrencyType")]
    public string? RegionConcurrencyType { get; set; }

    /// <summary>The order of the Regions in where you want to perform the stack operation.</summary>
    [JsonPropertyName("regionOrder")]
    public IList<string>? RegionOrder { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceStatusAtProviderStackInstanceSummaries
{
    /// <summary>Target AWS Account ID to create a Stack based on the StackSet. Defaults to current account.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The organization root ID or organizational unit (OU) ID in which the stack is deployed.</summary>
    [JsonPropertyName("organizationalUnitId")]
    public string? OrganizationalUnitId { get; set; }

    /// <summary>Stack identifier.</summary>
    [JsonPropertyName("stackId")]
    public string? StackId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceStatusAtProvider
{
    /// <summary>Target AWS Account ID to create a Stack based on the StackSet. Defaults to current account.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Specifies whether you are acting as an account administrator in the organization's management account or as a delegated administrator in a member account. Valid values: SELF (default), DELEGATED_ADMIN.</summary>
    [JsonPropertyName("callAs")]
    public string? CallAs { get; set; }

    /// <summary>The AWS Organizations accounts to which StackSets deploys. StackSets doesn't deploy stack instances to the organization management account, even if the organization management account is in your organization or in an OU in your organization. Drift detection is not possible for this argument. See deployment_targets below.</summary>
    [JsonPropertyName("deploymentTargets")]
    public IList<V1beta1StackSetInstanceStatusAtProviderDeploymentTargets>? DeploymentTargets { get; set; }

    /// <summary>Unique identifier for the resource. If deployment_targets is set, this is a comma-delimited string combining stack set name, organizational unit IDs (/-delimited), and region (ie. mystack,ou-123/ou-456,us-east-1). Otherwise, this is a comma-delimited string combining stack set name, AWS account ID, and region (ie. mystack,123456789012,us-east-1).</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Preferences for how AWS CloudFormation performs a stack set operation.</summary>
    [JsonPropertyName("operationPreferences")]
    public IList<V1beta1StackSetInstanceStatusAtProviderOperationPreferences>? OperationPreferences { get; set; }

    /// <summary>The organization root ID or organizational unit (OU) ID in which the stack is deployed.</summary>
    [JsonPropertyName("organizationalUnitId")]
    public string? OrganizationalUnitId { get; set; }

    /// <summary>Key-value map of input parameters to override from the StackSet for this Instance.</summary>
    [JsonPropertyName("parameterOverrides")]
    public IDictionary<string, string>? ParameterOverrides { get; set; }

    /// <summary>You cannot reassociate a retained Stack or add an existing, saved Stack to a new StackSet. Defaults to false.</summary>
    [JsonPropertyName("retainStack")]
    public bool? RetainStack { get; set; }

    /// <summary>Stack identifier.</summary>
    [JsonPropertyName("stackId")]
    public string? StackId { get; set; }

    /// <summary>List of stack instances created from an organizational unit deployment target. This will only be populated when deployment_targets is set. See stack_instance_summaries. List of stack instances created from an organizational unit deployment target. This will only be populated when `deployment_targets` is set.</summary>
    [JsonPropertyName("stackInstanceSummaries")]
    public IList<V1beta1StackSetInstanceStatusAtProviderStackInstanceSummaries>? StackInstanceSummaries { get; set; }

    /// <summary>Name of the StackSet.</summary>
    [JsonPropertyName("stackSetName")]
    public string? StackSetName { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceStatusConditions
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

/// <summary>StackSetInstanceStatus defines the observed state of StackSetInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1StackSetInstanceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StackSetInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>StackSetInstance is the Schema for the StackSetInstances API. Manages a CloudFormation StackSet Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StackSetInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StackSetInstanceSpec>, IStatus<V1beta1StackSetInstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StackSetInstance";
    public const string KubeGroup = "cloudformation.aws.upbound.io";
    public const string KubePluralName = "stacksetinstances";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>StackSetInstanceSpec defines the desired state of StackSetInstance</summary>
    [JsonPropertyName("spec")]
    public V1beta1StackSetInstanceSpec Spec { get; set; }

    /// <summary>StackSetInstanceStatus defines the observed state of StackSetInstance.</summary>
    [JsonPropertyName("status")]
    public V1beta1StackSetInstanceStatus? Status { get; set; }
}