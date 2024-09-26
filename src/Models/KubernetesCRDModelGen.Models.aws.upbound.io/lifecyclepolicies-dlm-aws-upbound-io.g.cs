using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dlm.aws.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderExecutionRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LifecyclePolicySpecForProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderExecutionRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LifecyclePolicySpecForProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderPolicyDetailsActionCrossRegionCopyEncryptionConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) of the AWS KMS key to use for EBS encryption. If this parameter is not specified, the default KMS key for the account is used.</summary>
    [JsonPropertyName("cmkArn")]
    public string? CmkArn { get; set; }

    /// <summary>To encrypt a copy of an unencrypted snapshot when encryption by default is not enabled, enable encryption using this parameter. Copies of encrypted snapshots are encrypted, even if this parameter is false or when encryption by default is not enabled.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderPolicyDetailsActionCrossRegionCopyRetainRule
{
    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderPolicyDetailsActionCrossRegionCopy
{
    /// <summary>The encryption settings for the copied snapshot. See the encryption_configuration block. Max of 1 per action.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public IList<V1beta1LifecyclePolicySpecForProviderPolicyDetailsActionCrossRegionCopyEncryptionConfiguration>? EncryptionConfiguration { get; set; }

    /// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
    [JsonPropertyName("retainRule")]
    public IList<V1beta1LifecyclePolicySpecForProviderPolicyDetailsActionCrossRegionCopyRetainRule>? RetainRule { get; set; }

    /// <summary>The target Region or the Amazon Resource Name (ARN) of the target Outpost for the snapshot copies.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderPolicyDetailsAction
{
    /// <summary>The rule for copying shared snapshots across Regions. See the cross_region_copy configuration block.</summary>
    [JsonPropertyName("crossRegionCopy")]
    public IList<V1beta1LifecyclePolicySpecForProviderPolicyDetailsActionCrossRegionCopy>? CrossRegionCopy { get; set; }

    /// <summary>A descriptive name for the action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderPolicyDetailsEventSourceParameters
{
    /// <summary>The snapshot description that can trigger the policy. The description pattern is specified using a regular expression. The policy runs only if a snapshot with a description that matches the specified pattern is shared with your account.</summary>
    [JsonPropertyName("descriptionRegex")]
    public string? DescriptionRegex { get; set; }

    /// <summary>The type of event. Currently, only shareSnapshot events are supported.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>The IDs of the AWS accounts that can trigger policy by sharing snapshots with your account. The policy only runs if one of the specified AWS accounts shares a snapshot with your account.</summary>
    [JsonPropertyName("snapshotOwner")]
    public IList<string>? SnapshotOwner { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderPolicyDetailsEventSource
{
    /// <summary>A set of optional parameters for snapshot and AMI lifecycle policies. See the parameters configuration block.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1LifecyclePolicySpecForProviderPolicyDetailsEventSourceParameters>? Parameters { get; set; }

    /// <summary>The source of the event. Currently only managed CloudWatch Events rules are supported. Valid values are MANAGED_CWE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderPolicyDetailsParameters
{
    /// <summary>Indicates whether to exclude the root volume from snapshots created using CreateSnapshots. The default is false.</summary>
    [JsonPropertyName("excludeBootVolume")]
    public bool? ExcludeBootVolume { get; set; }

    /// <summary>Applies to AMI lifecycle policies only. Indicates whether targeted instances are rebooted when the lifecycle policy runs. true indicates that targeted instances are not rebooted when the policy runs. false indicates that target instances are rebooted when the policy runs. The default is true (instances are not rebooted).</summary>
    [JsonPropertyName("noReboot")]
    public bool? NoReboot { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleCreateRule
{
    /// <summary>The schedule, as a Cron expression. The schedule interval must be between 1 hour and 1 year. Conflicts with interval, interval_unit, and times.</summary>
    [JsonPropertyName("cronExpression")]
    public string? CronExpression { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }

    /// <summary>Specifies the destination for snapshots created by the policy. To create snapshots in the same Region as the source resource, specify CLOUD. To create snapshots on the same Outpost as the source resource, specify OUTPOST_LOCAL. If you omit this parameter, CLOUD is used by default. If the policy targets resources in an AWS Region, then you must create snapshots in the same Region as the source resource. If the policy targets resources on an Outpost, then you can create snapshots on the same Outpost as the source resource, or in the Region of that Outpost. Valid values are CLOUD and OUTPOST_LOCAL.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A list of times in 24 hour clock format that sets when the lifecycle policy should be evaluated. Max of 1. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("times")]
    public IList<string>? Times { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate cmkArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate cmkArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleDeprecateRule
{
    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleRetainRule
{
    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRule
{
    /// <summary>The Amazon Resource Name (ARN) of the AWS KMS key to use for EBS encryption. If this parameter is not specified, the default KMS key for the account is used.</summary>
    [JsonPropertyName("cmkArn")]
    public string? CmkArn { get; set; }

    /// <summary>Reference to a Key in kms to populate cmkArn.</summary>
    [JsonPropertyName("cmkArnRef")]
    public V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRef? CmkArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate cmkArn.</summary>
    [JsonPropertyName("cmkArnSelector")]
    public V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelector? CmkArnSelector { get; set; }

    /// <summary>Copy all user-defined tags on a source volume to snapshots of the volume created by this policy.</summary>
    [JsonPropertyName("copyTags")]
    public bool? CopyTags { get; set; }

    /// <summary>See the deprecate_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("deprecateRule")]
    public IList<V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleDeprecateRule>? DeprecateRule { get; set; }

    /// <summary>To encrypt a copy of an unencrypted snapshot when encryption by default is not enabled, enable encryption using this parameter. Copies of encrypted snapshots are encrypted, even if this parameter is false or when encryption by default is not enabled.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
    [JsonPropertyName("retainRule")]
    public IList<V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleRetainRule>? RetainRule { get; set; }

    /// <summary>The target Region or the Amazon Resource Name (ARN) of the target Outpost for the snapshot copies.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleDeprecateRule
{
    /// <summary>Specifies the number of oldest AMIs to deprecate. Must be an integer between 1 and 1000. Conflicts with interval and interval_unit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleFastRestoreRule
{
    /// <summary>The Availability Zones in which to enable fast snapshot restore.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>Specifies the number of oldest AMIs to deprecate. Must be an integer between 1 and 1000. Conflicts with interval and interval_unit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleRetainRule
{
    /// <summary>Specifies the number of oldest AMIs to deprecate. Must be an integer between 1 and 1000. Conflicts with interval and interval_unit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleShareRule
{
    /// <summary>The IDs of the AWS accounts with which to share the snapshots.</summary>
    [JsonPropertyName("targetAccounts")]
    public IList<string>? TargetAccounts { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("unshareInterval")]
    public double? UnshareInterval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("unshareIntervalUnit")]
    public string? UnshareIntervalUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderPolicyDetailsSchedule
{
    /// <summary>Copy all user-defined tags on a source volume to snapshots of the volume created by this policy.</summary>
    [JsonPropertyName("copyTags")]
    public bool? CopyTags { get; set; }

    /// <summary>See the create_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("createRule")]
    public IList<V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleCreateRule>? CreateRule { get; set; }

    /// <summary>See the cross_region_copy_rule block. Max of 3 per schedule.</summary>
    [JsonPropertyName("crossRegionCopyRule")]
    public IList<V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRule>? CrossRegionCopyRule { get; set; }

    /// <summary>See the deprecate_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("deprecateRule")]
    public IList<V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleDeprecateRule>? DeprecateRule { get; set; }

    /// <summary>See the fast_restore_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("fastRestoreRule")]
    public IList<V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleFastRestoreRule>? FastRestoreRule { get; set; }

    /// <summary>A descriptive name for the action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
    [JsonPropertyName("retainRule")]
    public IList<V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleRetainRule>? RetainRule { get; set; }

    /// <summary>See the share_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("shareRule")]
    public IList<V1beta1LifecyclePolicySpecForProviderPolicyDetailsScheduleShareRule>? ShareRule { get; set; }

    /// <summary>A map of tag keys and their values. DLM lifecycle policies will already tag the snapshot with the tags on the volume. This configuration adds extra tags on top of these.</summary>
    [JsonPropertyName("tagsToAdd")]
    public IDictionary<string, string>? TagsToAdd { get; set; }

    /// <summary>A map of tag keys and variable values, where the values are determined when the policy is executed. Only $(instance-id) or $(timestamp) are valid values. Can only be used when resource_types is INSTANCE.</summary>
    [JsonPropertyName("variableTags")]
    public IDictionary<string, string>? VariableTags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProviderPolicyDetails
{
    /// <summary>The actions to be performed when the event-based policy is triggered. You can specify only one action per policy. This parameter is required for event-based policies only. If you are creating a snapshot or AMI policy, omit this parameter. See the action configuration block.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1LifecyclePolicySpecForProviderPolicyDetailsAction>? Action { get; set; }

    /// <summary>The event that triggers the event-based policy. This parameter is required for event-based policies only. If you are creating a snapshot or AMI policy, omit this parameter. See the event_source configuration block.</summary>
    [JsonPropertyName("eventSource")]
    public IList<V1beta1LifecyclePolicySpecForProviderPolicyDetailsEventSource>? EventSource { get; set; }

    /// <summary>A set of optional parameters for snapshot and AMI lifecycle policies. See the parameters configuration block.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1LifecyclePolicySpecForProviderPolicyDetailsParameters>? Parameters { get; set; }

    /// <summary>The valid target resource types and actions a policy can manage. Specify EBS_SNAPSHOT_MANAGEMENT to create a lifecycle policy that manages the lifecycle of Amazon EBS snapshots. Specify IMAGE_MANAGEMENT to create a lifecycle policy that manages the lifecycle of EBS-backed AMIs. Specify EVENT_BASED_POLICY to create an event-based policy that performs specific actions when a defined event occurs in your AWS account. Default value is EBS_SNAPSHOT_MANAGEMENT.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>The location of the resources to backup. If the source resources are located in an AWS Region, specify CLOUD. If the source resources are located on an Outpost in your account, specify OUTPOST. If you specify OUTPOST, Amazon Data Lifecycle Manager backs up all resources of the specified type with matching target tags across all of the Outposts in your account. Valid values are CLOUD and OUTPOST.</summary>
    [JsonPropertyName("resourceLocations")]
    public IList<string>? ResourceLocations { get; set; }

    /// <summary>A list of resource types that should be targeted by the lifecycle policy. Valid values are VOLUME and INSTANCE.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }

    /// <summary>See the schedule configuration block.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1LifecyclePolicySpecForProviderPolicyDetailsSchedule>? Schedule { get; set; }

    /// <summary>A map of tag keys and their values. Any resources that match the resource_types and are tagged with any of these tags will be targeted.</summary>
    [JsonPropertyName("targetTags")]
    public IDictionary<string, string>? TargetTags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecForProvider
{
    /// <summary>A description for the DLM lifecycle policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ARN of an IAM role that is able to be assumed by the DLM service.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta1LifecyclePolicySpecForProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta1LifecyclePolicySpecForProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>See the policy_details configuration block. Max of 1.</summary>
    [JsonPropertyName("policyDetails")]
    public IList<V1beta1LifecyclePolicySpecForProviderPolicyDetails>? PolicyDetails { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Whether the lifecycle policy should be enabled or disabled. ENABLED or DISABLED are valid values. Defaults to ENABLED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderExecutionRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LifecyclePolicySpecInitProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderExecutionRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LifecyclePolicySpecInitProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderPolicyDetailsActionCrossRegionCopyEncryptionConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) of the AWS KMS key to use for EBS encryption. If this parameter is not specified, the default KMS key for the account is used.</summary>
    [JsonPropertyName("cmkArn")]
    public string? CmkArn { get; set; }

    /// <summary>To encrypt a copy of an unencrypted snapshot when encryption by default is not enabled, enable encryption using this parameter. Copies of encrypted snapshots are encrypted, even if this parameter is false or when encryption by default is not enabled.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderPolicyDetailsActionCrossRegionCopyRetainRule
{
    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderPolicyDetailsActionCrossRegionCopy
{
    /// <summary>The encryption settings for the copied snapshot. See the encryption_configuration block. Max of 1 per action.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public IList<V1beta1LifecyclePolicySpecInitProviderPolicyDetailsActionCrossRegionCopyEncryptionConfiguration>? EncryptionConfiguration { get; set; }

    /// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
    [JsonPropertyName("retainRule")]
    public IList<V1beta1LifecyclePolicySpecInitProviderPolicyDetailsActionCrossRegionCopyRetainRule>? RetainRule { get; set; }

    /// <summary>The target Region or the Amazon Resource Name (ARN) of the target Outpost for the snapshot copies.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderPolicyDetailsAction
{
    /// <summary>The rule for copying shared snapshots across Regions. See the cross_region_copy configuration block.</summary>
    [JsonPropertyName("crossRegionCopy")]
    public IList<V1beta1LifecyclePolicySpecInitProviderPolicyDetailsActionCrossRegionCopy>? CrossRegionCopy { get; set; }

    /// <summary>A descriptive name for the action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderPolicyDetailsEventSourceParameters
{
    /// <summary>The snapshot description that can trigger the policy. The description pattern is specified using a regular expression. The policy runs only if a snapshot with a description that matches the specified pattern is shared with your account.</summary>
    [JsonPropertyName("descriptionRegex")]
    public string? DescriptionRegex { get; set; }

    /// <summary>The type of event. Currently, only shareSnapshot events are supported.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>The IDs of the AWS accounts that can trigger policy by sharing snapshots with your account. The policy only runs if one of the specified AWS accounts shares a snapshot with your account.</summary>
    [JsonPropertyName("snapshotOwner")]
    public IList<string>? SnapshotOwner { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderPolicyDetailsEventSource
{
    /// <summary>A set of optional parameters for snapshot and AMI lifecycle policies. See the parameters configuration block.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1LifecyclePolicySpecInitProviderPolicyDetailsEventSourceParameters>? Parameters { get; set; }

    /// <summary>The source of the event. Currently only managed CloudWatch Events rules are supported. Valid values are MANAGED_CWE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderPolicyDetailsParameters
{
    /// <summary>Indicates whether to exclude the root volume from snapshots created using CreateSnapshots. The default is false.</summary>
    [JsonPropertyName("excludeBootVolume")]
    public bool? ExcludeBootVolume { get; set; }

    /// <summary>Applies to AMI lifecycle policies only. Indicates whether targeted instances are rebooted when the lifecycle policy runs. true indicates that targeted instances are not rebooted when the policy runs. false indicates that target instances are rebooted when the policy runs. The default is true (instances are not rebooted).</summary>
    [JsonPropertyName("noReboot")]
    public bool? NoReboot { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleCreateRule
{
    /// <summary>The schedule, as a Cron expression. The schedule interval must be between 1 hour and 1 year. Conflicts with interval, interval_unit, and times.</summary>
    [JsonPropertyName("cronExpression")]
    public string? CronExpression { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }

    /// <summary>Specifies the destination for snapshots created by the policy. To create snapshots in the same Region as the source resource, specify CLOUD. To create snapshots on the same Outpost as the source resource, specify OUTPOST_LOCAL. If you omit this parameter, CLOUD is used by default. If the policy targets resources in an AWS Region, then you must create snapshots in the same Region as the source resource. If the policy targets resources on an Outpost, then you can create snapshots on the same Outpost as the source resource, or in the Region of that Outpost. Valid values are CLOUD and OUTPOST_LOCAL.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A list of times in 24 hour clock format that sets when the lifecycle policy should be evaluated. Max of 1. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("times")]
    public IList<string>? Times { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate cmkArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate cmkArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleDeprecateRule
{
    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleRetainRule
{
    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRule
{
    /// <summary>The Amazon Resource Name (ARN) of the AWS KMS key to use for EBS encryption. If this parameter is not specified, the default KMS key for the account is used.</summary>
    [JsonPropertyName("cmkArn")]
    public string? CmkArn { get; set; }

    /// <summary>Reference to a Key in kms to populate cmkArn.</summary>
    [JsonPropertyName("cmkArnRef")]
    public V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRef? CmkArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate cmkArn.</summary>
    [JsonPropertyName("cmkArnSelector")]
    public V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelector? CmkArnSelector { get; set; }

    /// <summary>Copy all user-defined tags on a source volume to snapshots of the volume created by this policy.</summary>
    [JsonPropertyName("copyTags")]
    public bool? CopyTags { get; set; }

    /// <summary>See the deprecate_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("deprecateRule")]
    public IList<V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleDeprecateRule>? DeprecateRule { get; set; }

    /// <summary>To encrypt a copy of an unencrypted snapshot when encryption by default is not enabled, enable encryption using this parameter. Copies of encrypted snapshots are encrypted, even if this parameter is false or when encryption by default is not enabled.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
    [JsonPropertyName("retainRule")]
    public IList<V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleRetainRule>? RetainRule { get; set; }

    /// <summary>The target Region or the Amazon Resource Name (ARN) of the target Outpost for the snapshot copies.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleDeprecateRule
{
    /// <summary>Specifies the number of oldest AMIs to deprecate. Must be an integer between 1 and 1000. Conflicts with interval and interval_unit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleFastRestoreRule
{
    /// <summary>The Availability Zones in which to enable fast snapshot restore.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>Specifies the number of oldest AMIs to deprecate. Must be an integer between 1 and 1000. Conflicts with interval and interval_unit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleRetainRule
{
    /// <summary>Specifies the number of oldest AMIs to deprecate. Must be an integer between 1 and 1000. Conflicts with interval and interval_unit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleShareRule
{
    /// <summary>The IDs of the AWS accounts with which to share the snapshots.</summary>
    [JsonPropertyName("targetAccounts")]
    public IList<string>? TargetAccounts { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("unshareInterval")]
    public double? UnshareInterval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("unshareIntervalUnit")]
    public string? UnshareIntervalUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderPolicyDetailsSchedule
{
    /// <summary>Copy all user-defined tags on a source volume to snapshots of the volume created by this policy.</summary>
    [JsonPropertyName("copyTags")]
    public bool? CopyTags { get; set; }

    /// <summary>See the create_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("createRule")]
    public IList<V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleCreateRule>? CreateRule { get; set; }

    /// <summary>See the cross_region_copy_rule block. Max of 3 per schedule.</summary>
    [JsonPropertyName("crossRegionCopyRule")]
    public IList<V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRule>? CrossRegionCopyRule { get; set; }

    /// <summary>See the deprecate_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("deprecateRule")]
    public IList<V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleDeprecateRule>? DeprecateRule { get; set; }

    /// <summary>See the fast_restore_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("fastRestoreRule")]
    public IList<V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleFastRestoreRule>? FastRestoreRule { get; set; }

    /// <summary>A descriptive name for the action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
    [JsonPropertyName("retainRule")]
    public IList<V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleRetainRule>? RetainRule { get; set; }

    /// <summary>See the share_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("shareRule")]
    public IList<V1beta1LifecyclePolicySpecInitProviderPolicyDetailsScheduleShareRule>? ShareRule { get; set; }

    /// <summary>A map of tag keys and their values. DLM lifecycle policies will already tag the snapshot with the tags on the volume. This configuration adds extra tags on top of these.</summary>
    [JsonPropertyName("tagsToAdd")]
    public IDictionary<string, string>? TagsToAdd { get; set; }

    /// <summary>A map of tag keys and variable values, where the values are determined when the policy is executed. Only $(instance-id) or $(timestamp) are valid values. Can only be used when resource_types is INSTANCE.</summary>
    [JsonPropertyName("variableTags")]
    public IDictionary<string, string>? VariableTags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProviderPolicyDetails
{
    /// <summary>The actions to be performed when the event-based policy is triggered. You can specify only one action per policy. This parameter is required for event-based policies only. If you are creating a snapshot or AMI policy, omit this parameter. See the action configuration block.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1LifecyclePolicySpecInitProviderPolicyDetailsAction>? Action { get; set; }

    /// <summary>The event that triggers the event-based policy. This parameter is required for event-based policies only. If you are creating a snapshot or AMI policy, omit this parameter. See the event_source configuration block.</summary>
    [JsonPropertyName("eventSource")]
    public IList<V1beta1LifecyclePolicySpecInitProviderPolicyDetailsEventSource>? EventSource { get; set; }

    /// <summary>A set of optional parameters for snapshot and AMI lifecycle policies. See the parameters configuration block.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1LifecyclePolicySpecInitProviderPolicyDetailsParameters>? Parameters { get; set; }

    /// <summary>The valid target resource types and actions a policy can manage. Specify EBS_SNAPSHOT_MANAGEMENT to create a lifecycle policy that manages the lifecycle of Amazon EBS snapshots. Specify IMAGE_MANAGEMENT to create a lifecycle policy that manages the lifecycle of EBS-backed AMIs. Specify EVENT_BASED_POLICY to create an event-based policy that performs specific actions when a defined event occurs in your AWS account. Default value is EBS_SNAPSHOT_MANAGEMENT.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>The location of the resources to backup. If the source resources are located in an AWS Region, specify CLOUD. If the source resources are located on an Outpost in your account, specify OUTPOST. If you specify OUTPOST, Amazon Data Lifecycle Manager backs up all resources of the specified type with matching target tags across all of the Outposts in your account. Valid values are CLOUD and OUTPOST.</summary>
    [JsonPropertyName("resourceLocations")]
    public IList<string>? ResourceLocations { get; set; }

    /// <summary>A list of resource types that should be targeted by the lifecycle policy. Valid values are VOLUME and INSTANCE.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }

    /// <summary>See the schedule configuration block.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1LifecyclePolicySpecInitProviderPolicyDetailsSchedule>? Schedule { get; set; }

    /// <summary>A map of tag keys and their values. Any resources that match the resource_types and are tagged with any of these tags will be targeted.</summary>
    [JsonPropertyName("targetTags")]
    public IDictionary<string, string>? TargetTags { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecInitProvider
{
    /// <summary>A description for the DLM lifecycle policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ARN of an IAM role that is able to be assumed by the DLM service.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta1LifecyclePolicySpecInitProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta1LifecyclePolicySpecInitProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>See the policy_details configuration block. Max of 1.</summary>
    [JsonPropertyName("policyDetails")]
    public IList<V1beta1LifecyclePolicySpecInitProviderPolicyDetails>? PolicyDetails { get; set; }

    /// <summary>Whether the lifecycle policy should be enabled or disabled. ENABLED or DISABLED are valid values. Defaults to ENABLED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecProviderConfigRefPolicy
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
public partial class V1beta1LifecyclePolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LifecyclePolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1LifecyclePolicySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LifecyclePolicySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1LifecyclePolicySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1LifecyclePolicySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1LifecyclePolicySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>LifecyclePolicySpec defines the desired state of LifecyclePolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LifecyclePolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LifecyclePolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LifecyclePolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1LifecyclePolicySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LifecyclePolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsActionCrossRegionCopyEncryptionConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) of the AWS KMS key to use for EBS encryption. If this parameter is not specified, the default KMS key for the account is used.</summary>
    [JsonPropertyName("cmkArn")]
    public string? CmkArn { get; set; }

    /// <summary>To encrypt a copy of an unencrypted snapshot when encryption by default is not enabled, enable encryption using this parameter. Copies of encrypted snapshots are encrypted, even if this parameter is false or when encryption by default is not enabled.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsActionCrossRegionCopyRetainRule
{
    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsActionCrossRegionCopy
{
    /// <summary>The encryption settings for the copied snapshot. See the encryption_configuration block. Max of 1 per action.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public IList<V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsActionCrossRegionCopyEncryptionConfiguration>? EncryptionConfiguration { get; set; }

    /// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
    [JsonPropertyName("retainRule")]
    public IList<V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsActionCrossRegionCopyRetainRule>? RetainRule { get; set; }

    /// <summary>The target Region or the Amazon Resource Name (ARN) of the target Outpost for the snapshot copies.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsAction
{
    /// <summary>The rule for copying shared snapshots across Regions. See the cross_region_copy configuration block.</summary>
    [JsonPropertyName("crossRegionCopy")]
    public IList<V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsActionCrossRegionCopy>? CrossRegionCopy { get; set; }

    /// <summary>A descriptive name for the action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsEventSourceParameters
{
    /// <summary>The snapshot description that can trigger the policy. The description pattern is specified using a regular expression. The policy runs only if a snapshot with a description that matches the specified pattern is shared with your account.</summary>
    [JsonPropertyName("descriptionRegex")]
    public string? DescriptionRegex { get; set; }

    /// <summary>The type of event. Currently, only shareSnapshot events are supported.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>The IDs of the AWS accounts that can trigger policy by sharing snapshots with your account. The policy only runs if one of the specified AWS accounts shares a snapshot with your account.</summary>
    [JsonPropertyName("snapshotOwner")]
    public IList<string>? SnapshotOwner { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsEventSource
{
    /// <summary>A set of optional parameters for snapshot and AMI lifecycle policies. See the parameters configuration block.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsEventSourceParameters>? Parameters { get; set; }

    /// <summary>The source of the event. Currently only managed CloudWatch Events rules are supported. Valid values are MANAGED_CWE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsParameters
{
    /// <summary>Indicates whether to exclude the root volume from snapshots created using CreateSnapshots. The default is false.</summary>
    [JsonPropertyName("excludeBootVolume")]
    public bool? ExcludeBootVolume { get; set; }

    /// <summary>Applies to AMI lifecycle policies only. Indicates whether targeted instances are rebooted when the lifecycle policy runs. true indicates that targeted instances are not rebooted when the policy runs. false indicates that target instances are rebooted when the policy runs. The default is true (instances are not rebooted).</summary>
    [JsonPropertyName("noReboot")]
    public bool? NoReboot { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsScheduleCreateRule
{
    /// <summary>The schedule, as a Cron expression. The schedule interval must be between 1 hour and 1 year. Conflicts with interval, interval_unit, and times.</summary>
    [JsonPropertyName("cronExpression")]
    public string? CronExpression { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }

    /// <summary>Specifies the destination for snapshots created by the policy. To create snapshots in the same Region as the source resource, specify CLOUD. To create snapshots on the same Outpost as the source resource, specify OUTPOST_LOCAL. If you omit this parameter, CLOUD is used by default. If the policy targets resources in an AWS Region, then you must create snapshots in the same Region as the source resource. If the policy targets resources on an Outpost, then you can create snapshots on the same Outpost as the source resource, or in the Region of that Outpost. Valid values are CLOUD and OUTPOST_LOCAL.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A list of times in 24 hour clock format that sets when the lifecycle policy should be evaluated. Max of 1. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("times")]
    public IList<string>? Times { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsScheduleCrossRegionCopyRuleDeprecateRule
{
    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsScheduleCrossRegionCopyRuleRetainRule
{
    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsScheduleCrossRegionCopyRule
{
    /// <summary>The Amazon Resource Name (ARN) of the AWS KMS key to use for EBS encryption. If this parameter is not specified, the default KMS key for the account is used.</summary>
    [JsonPropertyName("cmkArn")]
    public string? CmkArn { get; set; }

    /// <summary>Copy all user-defined tags on a source volume to snapshots of the volume created by this policy.</summary>
    [JsonPropertyName("copyTags")]
    public bool? CopyTags { get; set; }

    /// <summary>See the deprecate_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("deprecateRule")]
    public IList<V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsScheduleCrossRegionCopyRuleDeprecateRule>? DeprecateRule { get; set; }

    /// <summary>To encrypt a copy of an unencrypted snapshot when encryption by default is not enabled, enable encryption using this parameter. Copies of encrypted snapshots are encrypted, even if this parameter is false or when encryption by default is not enabled.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
    [JsonPropertyName("retainRule")]
    public IList<V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsScheduleCrossRegionCopyRuleRetainRule>? RetainRule { get; set; }

    /// <summary>The target Region or the Amazon Resource Name (ARN) of the target Outpost for the snapshot copies.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsScheduleDeprecateRule
{
    /// <summary>Specifies the number of oldest AMIs to deprecate. Must be an integer between 1 and 1000. Conflicts with interval and interval_unit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsScheduleFastRestoreRule
{
    /// <summary>The Availability Zones in which to enable fast snapshot restore.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>Specifies the number of oldest AMIs to deprecate. Must be an integer between 1 and 1000. Conflicts with interval and interval_unit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsScheduleRetainRule
{
    /// <summary>Specifies the number of oldest AMIs to deprecate. Must be an integer between 1 and 1000. Conflicts with interval and interval_unit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsScheduleShareRule
{
    /// <summary>The IDs of the AWS accounts with which to share the snapshots.</summary>
    [JsonPropertyName("targetAccounts")]
    public IList<string>? TargetAccounts { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("unshareInterval")]
    public double? UnshareInterval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("unshareIntervalUnit")]
    public string? UnshareIntervalUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsSchedule
{
    /// <summary>Copy all user-defined tags on a source volume to snapshots of the volume created by this policy.</summary>
    [JsonPropertyName("copyTags")]
    public bool? CopyTags { get; set; }

    /// <summary>See the create_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("createRule")]
    public IList<V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsScheduleCreateRule>? CreateRule { get; set; }

    /// <summary>See the cross_region_copy_rule block. Max of 3 per schedule.</summary>
    [JsonPropertyName("crossRegionCopyRule")]
    public IList<V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsScheduleCrossRegionCopyRule>? CrossRegionCopyRule { get; set; }

    /// <summary>See the deprecate_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("deprecateRule")]
    public IList<V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsScheduleDeprecateRule>? DeprecateRule { get; set; }

    /// <summary>See the fast_restore_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("fastRestoreRule")]
    public IList<V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsScheduleFastRestoreRule>? FastRestoreRule { get; set; }

    /// <summary>A descriptive name for the action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
    [JsonPropertyName("retainRule")]
    public IList<V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsScheduleRetainRule>? RetainRule { get; set; }

    /// <summary>See the share_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("shareRule")]
    public IList<V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsScheduleShareRule>? ShareRule { get; set; }

    /// <summary>A map of tag keys and their values. DLM lifecycle policies will already tag the snapshot with the tags on the volume. This configuration adds extra tags on top of these.</summary>
    [JsonPropertyName("tagsToAdd")]
    public IDictionary<string, string>? TagsToAdd { get; set; }

    /// <summary>A map of tag keys and variable values, where the values are determined when the policy is executed. Only $(instance-id) or $(timestamp) are valid values. Can only be used when resource_types is INSTANCE.</summary>
    [JsonPropertyName("variableTags")]
    public IDictionary<string, string>? VariableTags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicyStatusAtProviderPolicyDetails
{
    /// <summary>The actions to be performed when the event-based policy is triggered. You can specify only one action per policy. This parameter is required for event-based policies only. If you are creating a snapshot or AMI policy, omit this parameter. See the action configuration block.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsAction>? Action { get; set; }

    /// <summary>The event that triggers the event-based policy. This parameter is required for event-based policies only. If you are creating a snapshot or AMI policy, omit this parameter. See the event_source configuration block.</summary>
    [JsonPropertyName("eventSource")]
    public IList<V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsEventSource>? EventSource { get; set; }

    /// <summary>A set of optional parameters for snapshot and AMI lifecycle policies. See the parameters configuration block.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsParameters>? Parameters { get; set; }

    /// <summary>The valid target resource types and actions a policy can manage. Specify EBS_SNAPSHOT_MANAGEMENT to create a lifecycle policy that manages the lifecycle of Amazon EBS snapshots. Specify IMAGE_MANAGEMENT to create a lifecycle policy that manages the lifecycle of EBS-backed AMIs. Specify EVENT_BASED_POLICY to create an event-based policy that performs specific actions when a defined event occurs in your AWS account. Default value is EBS_SNAPSHOT_MANAGEMENT.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>The location of the resources to backup. If the source resources are located in an AWS Region, specify CLOUD. If the source resources are located on an Outpost in your account, specify OUTPOST. If you specify OUTPOST, Amazon Data Lifecycle Manager backs up all resources of the specified type with matching target tags across all of the Outposts in your account. Valid values are CLOUD and OUTPOST.</summary>
    [JsonPropertyName("resourceLocations")]
    public IList<string>? ResourceLocations { get; set; }

    /// <summary>A list of resource types that should be targeted by the lifecycle policy. Valid values are VOLUME and INSTANCE.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }

    /// <summary>See the schedule configuration block.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1LifecyclePolicyStatusAtProviderPolicyDetailsSchedule>? Schedule { get; set; }

    /// <summary>A map of tag keys and their values. Any resources that match the resource_types and are tagged with any of these tags will be targeted.</summary>
    [JsonPropertyName("targetTags")]
    public IDictionary<string, string>? TargetTags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicyStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of the DLM Lifecycle Policy.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A description for the DLM lifecycle policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ARN of an IAM role that is able to be assumed by the DLM service.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Identifier of the DLM Lifecycle Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>See the policy_details configuration block. Max of 1.</summary>
    [JsonPropertyName("policyDetails")]
    public IList<V1beta1LifecyclePolicyStatusAtProviderPolicyDetails>? PolicyDetails { get; set; }

    /// <summary>Whether the lifecycle policy should be enabled or disabled. ENABLED or DISABLED are valid values. Defaults to ENABLED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicyStatusConditions
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

/// <summary>LifecyclePolicyStatus defines the observed state of LifecyclePolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LifecyclePolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LifecyclePolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LifecyclePolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LifecyclePolicy is the Schema for the LifecyclePolicys API. Provides a Data Lifecycle Manager (DLM) lifecycle policy for managing snapshots.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LifecyclePolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LifecyclePolicySpec>, IStatus<V1beta1LifecyclePolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LifecyclePolicy";
    public const string KubeGroup = "dlm.aws.upbound.io";
    public const string KubePluralName = "lifecyclepolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LifecyclePolicySpec defines the desired state of LifecyclePolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1LifecyclePolicySpec Spec { get; set; }

    /// <summary>LifecyclePolicyStatus defines the observed state of LifecyclePolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1LifecyclePolicyStatus? Status { get; set; }
}