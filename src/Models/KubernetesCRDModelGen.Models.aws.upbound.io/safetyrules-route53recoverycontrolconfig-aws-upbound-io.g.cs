using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.route53recoverycontrolconfig.aws.upbound.io;
public enum V1beta1SafetyRuleSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1SafetyRuleSpecForProviderAssertedControlsRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SafetyRuleSpecForProviderAssertedControlsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SafetyRuleSpecForProviderAssertedControlsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SafetyRuleSpecForProviderAssertedControlsRefsPolicyResolutionEnum>))]
    public V1beta1SafetyRuleSpecForProviderAssertedControlsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SafetyRuleSpecForProviderAssertedControlsRefsPolicyResolveEnum>))]
    public V1beta1SafetyRuleSpecForProviderAssertedControlsRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SafetyRuleSpecForProviderAssertedControlsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SafetyRuleSpecForProviderAssertedControlsRefsPolicy? Policy { get; set; }
}

public enum V1beta1SafetyRuleSpecForProviderAssertedControlsSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SafetyRuleSpecForProviderAssertedControlsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SafetyRuleSpecForProviderAssertedControlsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SafetyRuleSpecForProviderAssertedControlsSelectorPolicyResolutionEnum>))]
    public V1beta1SafetyRuleSpecForProviderAssertedControlsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SafetyRuleSpecForProviderAssertedControlsSelectorPolicyResolveEnum>))]
    public V1beta1SafetyRuleSpecForProviderAssertedControlsSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SafetyRuleSpecForProviderAssertedControlsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SafetyRuleSpecForProviderAssertedControlsSelectorPolicy? Policy { get; set; }
}

public enum V1beta1SafetyRuleSpecForProviderControlPanelArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SafetyRuleSpecForProviderControlPanelArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SafetyRuleSpecForProviderControlPanelArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SafetyRuleSpecForProviderControlPanelArnRefPolicyResolutionEnum>))]
    public V1beta1SafetyRuleSpecForProviderControlPanelArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SafetyRuleSpecForProviderControlPanelArnRefPolicyResolveEnum>))]
    public V1beta1SafetyRuleSpecForProviderControlPanelArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SafetyRuleSpecForProviderControlPanelArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SafetyRuleSpecForProviderControlPanelArnRefPolicy? Policy { get; set; }
}

public enum V1beta1SafetyRuleSpecForProviderControlPanelArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SafetyRuleSpecForProviderControlPanelArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SafetyRuleSpecForProviderControlPanelArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SafetyRuleSpecForProviderControlPanelArnSelectorPolicyResolutionEnum>))]
    public V1beta1SafetyRuleSpecForProviderControlPanelArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SafetyRuleSpecForProviderControlPanelArnSelectorPolicyResolveEnum>))]
    public V1beta1SafetyRuleSpecForProviderControlPanelArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SafetyRuleSpecForProviderControlPanelArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SafetyRuleSpecForProviderControlPanelArnSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1SafetyRuleSpecForProviderRuleConfig
{
    /// <summary>Logical negation of the rule.</summary>
    [JsonPropertyName("inverted")]
    public bool? Inverted { get; set; }

    /// <summary>Number of controls that must be set when you specify an ATLEAST type rule.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>Rule type. Valid values are ATLEAST, AND, and OR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1SafetyRuleSpecForProvider
{
    /// <summary>Routing controls that are part of transactions that are evaluated to determine if a request to change a routing control state is allowed.</summary>
    [JsonPropertyName("assertedControls")]
    public IList<string>? AssertedControls { get; set; }

    /// <summary>References to RoutingControl in route53recoverycontrolconfig to populate assertedControls.</summary>
    [JsonPropertyName("assertedControlsRefs")]
    public IList<V1beta1SafetyRuleSpecForProviderAssertedControlsRefs>? AssertedControlsRefs { get; set; }

    /// <summary>Selector for a list of RoutingControl in route53recoverycontrolconfig to populate assertedControls.</summary>
    [JsonPropertyName("assertedControlsSelector")]
    public V1beta1SafetyRuleSpecForProviderAssertedControlsSelector? AssertedControlsSelector { get; set; }

    /// <summary>ARN of the control panel in which this safety rule will reside.</summary>
    [JsonPropertyName("controlPanelArn")]
    public string? ControlPanelArn { get; set; }

    /// <summary>Reference to a ControlPanel in route53recoverycontrolconfig to populate controlPanelArn.</summary>
    [JsonPropertyName("controlPanelArnRef")]
    public V1beta1SafetyRuleSpecForProviderControlPanelArnRef? ControlPanelArnRef { get; set; }

    /// <summary>Selector for a ControlPanel in route53recoverycontrolconfig to populate controlPanelArn.</summary>
    [JsonPropertyName("controlPanelArnSelector")]
    public V1beta1SafetyRuleSpecForProviderControlPanelArnSelector? ControlPanelArnSelector { get; set; }

    /// <summary>Gating controls for the new gating rule. That is, routing controls that are evaluated by the rule configuration that you specify.</summary>
    [JsonPropertyName("gatingControls")]
    public IList<string>? GatingControls { get; set; }

    /// <summary>Name describing the safety rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Configuration block for safety rule criteria. See below.</summary>
    [JsonPropertyName("ruleConfig")]
    public IList<V1beta1SafetyRuleSpecForProviderRuleConfig>? RuleConfig { get; set; }

    /// <summary>Routing controls that can only be set or unset if the specified rule_config evaluates to true for the specified gating_controls.</summary>
    [JsonPropertyName("targetControls")]
    public IList<string>? TargetControls { get; set; }

    /// <summary>Evaluation period, in milliseconds (ms), during which any request against the target routing controls will fail.</summary>
    [JsonPropertyName("waitPeriodMs")]
    public double? WaitPeriodMs { get; set; }
}

public enum V1beta1SafetyRuleSpecInitProviderAssertedControlsRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SafetyRuleSpecInitProviderAssertedControlsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SafetyRuleSpecInitProviderAssertedControlsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SafetyRuleSpecInitProviderAssertedControlsRefsPolicyResolutionEnum>))]
    public V1beta1SafetyRuleSpecInitProviderAssertedControlsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SafetyRuleSpecInitProviderAssertedControlsRefsPolicyResolveEnum>))]
    public V1beta1SafetyRuleSpecInitProviderAssertedControlsRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SafetyRuleSpecInitProviderAssertedControlsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SafetyRuleSpecInitProviderAssertedControlsRefsPolicy? Policy { get; set; }
}

public enum V1beta1SafetyRuleSpecInitProviderAssertedControlsSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SafetyRuleSpecInitProviderAssertedControlsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SafetyRuleSpecInitProviderAssertedControlsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SafetyRuleSpecInitProviderAssertedControlsSelectorPolicyResolutionEnum>))]
    public V1beta1SafetyRuleSpecInitProviderAssertedControlsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SafetyRuleSpecInitProviderAssertedControlsSelectorPolicyResolveEnum>))]
    public V1beta1SafetyRuleSpecInitProviderAssertedControlsSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SafetyRuleSpecInitProviderAssertedControlsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SafetyRuleSpecInitProviderAssertedControlsSelectorPolicy? Policy { get; set; }
}

public enum V1beta1SafetyRuleSpecInitProviderControlPanelArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SafetyRuleSpecInitProviderControlPanelArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SafetyRuleSpecInitProviderControlPanelArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SafetyRuleSpecInitProviderControlPanelArnRefPolicyResolutionEnum>))]
    public V1beta1SafetyRuleSpecInitProviderControlPanelArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SafetyRuleSpecInitProviderControlPanelArnRefPolicyResolveEnum>))]
    public V1beta1SafetyRuleSpecInitProviderControlPanelArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SafetyRuleSpecInitProviderControlPanelArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SafetyRuleSpecInitProviderControlPanelArnRefPolicy? Policy { get; set; }
}

public enum V1beta1SafetyRuleSpecInitProviderControlPanelArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SafetyRuleSpecInitProviderControlPanelArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SafetyRuleSpecInitProviderControlPanelArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SafetyRuleSpecInitProviderControlPanelArnSelectorPolicyResolutionEnum>))]
    public V1beta1SafetyRuleSpecInitProviderControlPanelArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SafetyRuleSpecInitProviderControlPanelArnSelectorPolicyResolveEnum>))]
    public V1beta1SafetyRuleSpecInitProviderControlPanelArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SafetyRuleSpecInitProviderControlPanelArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SafetyRuleSpecInitProviderControlPanelArnSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1SafetyRuleSpecInitProviderRuleConfig
{
    /// <summary>Logical negation of the rule.</summary>
    [JsonPropertyName("inverted")]
    public bool? Inverted { get; set; }

    /// <summary>Number of controls that must be set when you specify an ATLEAST type rule.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>Rule type. Valid values are ATLEAST, AND, and OR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1SafetyRuleSpecInitProvider
{
    /// <summary>Routing controls that are part of transactions that are evaluated to determine if a request to change a routing control state is allowed.</summary>
    [JsonPropertyName("assertedControls")]
    public IList<string>? AssertedControls { get; set; }

    /// <summary>References to RoutingControl in route53recoverycontrolconfig to populate assertedControls.</summary>
    [JsonPropertyName("assertedControlsRefs")]
    public IList<V1beta1SafetyRuleSpecInitProviderAssertedControlsRefs>? AssertedControlsRefs { get; set; }

    /// <summary>Selector for a list of RoutingControl in route53recoverycontrolconfig to populate assertedControls.</summary>
    [JsonPropertyName("assertedControlsSelector")]
    public V1beta1SafetyRuleSpecInitProviderAssertedControlsSelector? AssertedControlsSelector { get; set; }

    /// <summary>ARN of the control panel in which this safety rule will reside.</summary>
    [JsonPropertyName("controlPanelArn")]
    public string? ControlPanelArn { get; set; }

    /// <summary>Reference to a ControlPanel in route53recoverycontrolconfig to populate controlPanelArn.</summary>
    [JsonPropertyName("controlPanelArnRef")]
    public V1beta1SafetyRuleSpecInitProviderControlPanelArnRef? ControlPanelArnRef { get; set; }

    /// <summary>Selector for a ControlPanel in route53recoverycontrolconfig to populate controlPanelArn.</summary>
    [JsonPropertyName("controlPanelArnSelector")]
    public V1beta1SafetyRuleSpecInitProviderControlPanelArnSelector? ControlPanelArnSelector { get; set; }

    /// <summary>Gating controls for the new gating rule. That is, routing controls that are evaluated by the rule configuration that you specify.</summary>
    [JsonPropertyName("gatingControls")]
    public IList<string>? GatingControls { get; set; }

    /// <summary>Name describing the safety rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block for safety rule criteria. See below.</summary>
    [JsonPropertyName("ruleConfig")]
    public IList<V1beta1SafetyRuleSpecInitProviderRuleConfig>? RuleConfig { get; set; }

    /// <summary>Routing controls that can only be set or unset if the specified rule_config evaluates to true for the specified gating_controls.</summary>
    [JsonPropertyName("targetControls")]
    public IList<string>? TargetControls { get; set; }

    /// <summary>Evaluation period, in milliseconds (ms), during which any request against the target routing controls will fail.</summary>
    [JsonPropertyName("waitPeriodMs")]
    public double? WaitPeriodMs { get; set; }
}

public enum V1beta1SafetyRuleSpecManagementPoliciesEnum
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

public enum V1beta1SafetyRuleSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SafetyRuleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SafetyRuleSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SafetyRuleSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1SafetyRuleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SafetyRuleSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1SafetyRuleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SafetyRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SafetyRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1SafetyRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SafetyRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SafetyRuleSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SafetyRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1SafetyRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SafetyRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1SafetyRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SafetyRuleSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SafetyRuleSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1SafetyRuleSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1SafetyRuleSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SafetyRuleSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SafetyRuleSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1SafetyRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1SafetyRuleSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SafetyRuleSpecDeletionPolicyEnum>))]
    public V1beta1SafetyRuleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SafetyRuleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SafetyRuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SafetyRuleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SafetyRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SafetyRuleSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SafetyRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1SafetyRuleStatusAtProviderRuleConfig
{
    /// <summary>Logical negation of the rule.</summary>
    [JsonPropertyName("inverted")]
    public bool? Inverted { get; set; }

    /// <summary>Number of controls that must be set when you specify an ATLEAST type rule.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>Rule type. Valid values are ATLEAST, AND, and OR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1SafetyRuleStatusAtProvider
{
    /// <summary>ARN of the safety rule.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Routing controls that are part of transactions that are evaluated to determine if a request to change a routing control state is allowed.</summary>
    [JsonPropertyName("assertedControls")]
    public IList<string>? AssertedControls { get; set; }

    /// <summary>ARN of the control panel in which this safety rule will reside.</summary>
    [JsonPropertyName("controlPanelArn")]
    public string? ControlPanelArn { get; set; }

    /// <summary>Gating controls for the new gating rule. That is, routing controls that are evaluated by the rule configuration that you specify.</summary>
    [JsonPropertyName("gatingControls")]
    public IList<string>? GatingControls { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name describing the safety rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block for safety rule criteria. See below.</summary>
    [JsonPropertyName("ruleConfig")]
    public IList<V1beta1SafetyRuleStatusAtProviderRuleConfig>? RuleConfig { get; set; }

    /// <summary>Status of the safety rule. PENDING when it is being created/updated, PENDING_DELETION when it is being deleted, and DEPLOYED otherwise.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Routing controls that can only be set or unset if the specified rule_config evaluates to true for the specified gating_controls.</summary>
    [JsonPropertyName("targetControls")]
    public IList<string>? TargetControls { get; set; }

    /// <summary>Evaluation period, in milliseconds (ms), during which any request against the target routing controls will fail.</summary>
    [JsonPropertyName("waitPeriodMs")]
    public double? WaitPeriodMs { get; set; }
}

public partial class V1beta1SafetyRuleStatusConditions
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

public partial class V1beta1SafetyRuleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SafetyRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SafetyRuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SafetyRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SafetyRuleSpec>, IStatus<V1beta1SafetyRuleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SafetyRule";
    public const string KubeGroup = "route53recoverycontrolconfig.aws.upbound.io";
    public const string KubePluralName = "safetyrules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SafetyRuleSpec defines the desired state of SafetyRule</summary>
    [JsonPropertyName("spec")]
    public V1beta1SafetyRuleSpec Spec { get; set; }

    /// <summary>SafetyRuleStatus defines the observed state of SafetyRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1SafetyRuleStatus? Status { get; set; }
}