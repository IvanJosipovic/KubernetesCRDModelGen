using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudwatch.aws.upbound.io;
#nullable enable
/// <summary>CompositeAlarm is the Schema for the CompositeAlarms API. Provides a CloudWatch Composite Alarm resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CompositeAlarmList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CompositeAlarm>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CompositeAlarmList";
    public const string KubeGroup = "cloudwatch.aws.upbound.io";
    public const string KubePluralName = "compositealarms";
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
    public IList<V1beta1CompositeAlarm> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecForProviderActionsSuppressor
{
    /// <summary>Can be an AlarmName or an Amazon Resource Name (ARN) from an existing alarm.</summary>
    [JsonPropertyName("alarm")]
    public string? Alarm { get; set; }

    /// <summary>The maximum time in seconds that the composite alarm waits after suppressor alarm goes out of the ALARM state. After this time, the composite alarm performs its actions.</summary>
    [JsonPropertyName("extensionPeriod")]
    public double? ExtensionPeriod { get; set; }

    /// <summary>The maximum time in seconds that the composite alarm waits for the suppressor alarm to go into the ALARM state. After this time, the composite alarm performs its actions.</summary>
    [JsonPropertyName("waitPeriod")]
    public double? WaitPeriod { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecForProviderAlarmActionsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecForProviderAlarmActionsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CompositeAlarmSpecForProviderAlarmActionsRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecForProviderAlarmActionsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a list of Topic in sns to populate alarmActions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecForProviderAlarmActionsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CompositeAlarmSpecForProviderAlarmActionsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecForProviderOkActionsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecForProviderOkActionsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CompositeAlarmSpecForProviderOkActionsRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecForProviderOkActionsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a list of Topic in sns to populate okActions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecForProviderOkActionsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CompositeAlarmSpecForProviderOkActionsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecForProvider
{
    /// <summary>Indicates whether actions should be executed during any changes to the alarm state of the composite alarm. Defaults to true.</summary>
    [JsonPropertyName("actionsEnabled")]
    public bool? ActionsEnabled { get; set; }

    /// <summary>Actions will be suppressed if the suppressor alarm is in the ALARM state.</summary>
    [JsonPropertyName("actionsSuppressor")]
    public IList<V1beta1CompositeAlarmSpecForProviderActionsSuppressor>? ActionsSuppressor { get; set; }

    /// <summary>The set of actions to execute when this alarm transitions to the ALARM state from any other state. Each action is specified as an ARN. Up to 5 actions are allowed.</summary>
    [JsonPropertyName("alarmActions")]
    public IList<string>? AlarmActions { get; set; }

    /// <summary>References to Topic in sns to populate alarmActions.</summary>
    [JsonPropertyName("alarmActionsRefs")]
    public IList<V1beta1CompositeAlarmSpecForProviderAlarmActionsRefs>? AlarmActionsRefs { get; set; }

    /// <summary>Selector for a list of Topic in sns to populate alarmActions.</summary>
    [JsonPropertyName("alarmActionsSelector")]
    public V1beta1CompositeAlarmSpecForProviderAlarmActionsSelector? AlarmActionsSelector { get; set; }

    /// <summary>The description for the composite alarm.</summary>
    [JsonPropertyName("alarmDescription")]
    public string? AlarmDescription { get; set; }

    /// <summary>An expression that specifies which other alarms are to be evaluated to determine this composite alarm's state. For syntax, see Creating a Composite Alarm. The maximum length is 10240 characters.</summary>
    [JsonPropertyName("alarmRule")]
    public string? AlarmRule { get; set; }

    /// <summary>The set of actions to execute when this alarm transitions to the INSUFFICIENT_DATA state from any other state. Each action is specified as an ARN. Up to 5 actions are allowed.</summary>
    [JsonPropertyName("insufficientDataActions")]
    public IList<string>? InsufficientDataActions { get; set; }

    /// <summary>The set of actions to execute when this alarm transitions to an OK state from any other state. Each action is specified as an ARN. Up to 5 actions are allowed.</summary>
    [JsonPropertyName("okActions")]
    public IList<string>? OkActions { get; set; }

    /// <summary>References to Topic in sns to populate okActions.</summary>
    [JsonPropertyName("okActionsRefs")]
    public IList<V1beta1CompositeAlarmSpecForProviderOkActionsRefs>? OkActionsRefs { get; set; }

    /// <summary>Selector for a list of Topic in sns to populate okActions.</summary>
    [JsonPropertyName("okActionsSelector")]
    public V1beta1CompositeAlarmSpecForProviderOkActionsSelector? OkActionsSelector { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecInitProviderActionsSuppressor
{
    /// <summary>Can be an AlarmName or an Amazon Resource Name (ARN) from an existing alarm.</summary>
    [JsonPropertyName("alarm")]
    public string? Alarm { get; set; }

    /// <summary>The maximum time in seconds that the composite alarm waits after suppressor alarm goes out of the ALARM state. After this time, the composite alarm performs its actions.</summary>
    [JsonPropertyName("extensionPeriod")]
    public double? ExtensionPeriod { get; set; }

    /// <summary>The maximum time in seconds that the composite alarm waits for the suppressor alarm to go into the ALARM state. After this time, the composite alarm performs its actions.</summary>
    [JsonPropertyName("waitPeriod")]
    public double? WaitPeriod { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecInitProviderAlarmActionsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecInitProviderAlarmActionsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CompositeAlarmSpecInitProviderAlarmActionsRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecInitProviderAlarmActionsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a list of Topic in sns to populate alarmActions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecInitProviderAlarmActionsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CompositeAlarmSpecInitProviderAlarmActionsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecInitProviderOkActionsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecInitProviderOkActionsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CompositeAlarmSpecInitProviderOkActionsRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecInitProviderOkActionsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a list of Topic in sns to populate okActions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecInitProviderOkActionsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CompositeAlarmSpecInitProviderOkActionsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecInitProvider
{
    /// <summary>Indicates whether actions should be executed during any changes to the alarm state of the composite alarm. Defaults to true.</summary>
    [JsonPropertyName("actionsEnabled")]
    public bool? ActionsEnabled { get; set; }

    /// <summary>Actions will be suppressed if the suppressor alarm is in the ALARM state.</summary>
    [JsonPropertyName("actionsSuppressor")]
    public IList<V1beta1CompositeAlarmSpecInitProviderActionsSuppressor>? ActionsSuppressor { get; set; }

    /// <summary>The set of actions to execute when this alarm transitions to the ALARM state from any other state. Each action is specified as an ARN. Up to 5 actions are allowed.</summary>
    [JsonPropertyName("alarmActions")]
    public IList<string>? AlarmActions { get; set; }

    /// <summary>References to Topic in sns to populate alarmActions.</summary>
    [JsonPropertyName("alarmActionsRefs")]
    public IList<V1beta1CompositeAlarmSpecInitProviderAlarmActionsRefs>? AlarmActionsRefs { get; set; }

    /// <summary>Selector for a list of Topic in sns to populate alarmActions.</summary>
    [JsonPropertyName("alarmActionsSelector")]
    public V1beta1CompositeAlarmSpecInitProviderAlarmActionsSelector? AlarmActionsSelector { get; set; }

    /// <summary>The description for the composite alarm.</summary>
    [JsonPropertyName("alarmDescription")]
    public string? AlarmDescription { get; set; }

    /// <summary>An expression that specifies which other alarms are to be evaluated to determine this composite alarm's state. For syntax, see Creating a Composite Alarm. The maximum length is 10240 characters.</summary>
    [JsonPropertyName("alarmRule")]
    public string? AlarmRule { get; set; }

    /// <summary>The set of actions to execute when this alarm transitions to the INSUFFICIENT_DATA state from any other state. Each action is specified as an ARN. Up to 5 actions are allowed.</summary>
    [JsonPropertyName("insufficientDataActions")]
    public IList<string>? InsufficientDataActions { get; set; }

    /// <summary>The set of actions to execute when this alarm transitions to an OK state from any other state. Each action is specified as an ARN. Up to 5 actions are allowed.</summary>
    [JsonPropertyName("okActions")]
    public IList<string>? OkActions { get; set; }

    /// <summary>References to Topic in sns to populate okActions.</summary>
    [JsonPropertyName("okActionsRefs")]
    public IList<V1beta1CompositeAlarmSpecInitProviderOkActionsRefs>? OkActionsRefs { get; set; }

    /// <summary>Selector for a list of Topic in sns to populate okActions.</summary>
    [JsonPropertyName("okActionsSelector")]
    public V1beta1CompositeAlarmSpecInitProviderOkActionsSelector? OkActionsSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CompositeAlarmSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CompositeAlarmSpec defines the desired state of CompositeAlarm</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CompositeAlarmSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CompositeAlarmSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CompositeAlarmSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CompositeAlarmSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmStatusAtProviderActionsSuppressor
{
    /// <summary>Can be an AlarmName or an Amazon Resource Name (ARN) from an existing alarm.</summary>
    [JsonPropertyName("alarm")]
    public string? Alarm { get; set; }

    /// <summary>The maximum time in seconds that the composite alarm waits after suppressor alarm goes out of the ALARM state. After this time, the composite alarm performs its actions.</summary>
    [JsonPropertyName("extensionPeriod")]
    public double? ExtensionPeriod { get; set; }

    /// <summary>The maximum time in seconds that the composite alarm waits for the suppressor alarm to go into the ALARM state. After this time, the composite alarm performs its actions.</summary>
    [JsonPropertyName("waitPeriod")]
    public double? WaitPeriod { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmStatusAtProvider
{
    /// <summary>Indicates whether actions should be executed during any changes to the alarm state of the composite alarm. Defaults to true.</summary>
    [JsonPropertyName("actionsEnabled")]
    public bool? ActionsEnabled { get; set; }

    /// <summary>Actions will be suppressed if the suppressor alarm is in the ALARM state.</summary>
    [JsonPropertyName("actionsSuppressor")]
    public IList<V1beta1CompositeAlarmStatusAtProviderActionsSuppressor>? ActionsSuppressor { get; set; }

    /// <summary>The set of actions to execute when this alarm transitions to the ALARM state from any other state. Each action is specified as an ARN. Up to 5 actions are allowed.</summary>
    [JsonPropertyName("alarmActions")]
    public IList<string>? AlarmActions { get; set; }

    /// <summary>The description for the composite alarm.</summary>
    [JsonPropertyName("alarmDescription")]
    public string? AlarmDescription { get; set; }

    /// <summary>An expression that specifies which other alarms are to be evaluated to determine this composite alarm's state. For syntax, see Creating a Composite Alarm. The maximum length is 10240 characters.</summary>
    [JsonPropertyName("alarmRule")]
    public string? AlarmRule { get; set; }

    /// <summary>The ARN of the composite alarm.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The ID of the composite alarm resource, which is equivalent to its alarm_name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The set of actions to execute when this alarm transitions to the INSUFFICIENT_DATA state from any other state. Each action is specified as an ARN. Up to 5 actions are allowed.</summary>
    [JsonPropertyName("insufficientDataActions")]
    public IList<string>? InsufficientDataActions { get; set; }

    /// <summary>The set of actions to execute when this alarm transitions to an OK state from any other state. Each action is specified as an ARN. Up to 5 actions are allowed.</summary>
    [JsonPropertyName("okActions")]
    public IList<string>? OkActions { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmStatusConditions
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
#nullable disable

#nullable enable
/// <summary>CompositeAlarmStatus defines the observed state of CompositeAlarm.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CompositeAlarmStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CompositeAlarmStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CompositeAlarmStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CompositeAlarm is the Schema for the CompositeAlarms API. Provides a CloudWatch Composite Alarm resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CompositeAlarm : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CompositeAlarmSpec>, IStatus<V1beta1CompositeAlarmStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CompositeAlarm";
    public const string KubeGroup = "cloudwatch.aws.upbound.io";
    public const string KubePluralName = "compositealarms";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CompositeAlarmSpec defines the desired state of CompositeAlarm</summary>
    [JsonPropertyName("spec")]
    public V1beta1CompositeAlarmSpec Spec { get; set; }

    /// <summary>CompositeAlarmStatus defines the observed state of CompositeAlarm.</summary>
    [JsonPropertyName("status")]
    public V1beta1CompositeAlarmStatus? Status { get; set; }
}
#nullable disable
