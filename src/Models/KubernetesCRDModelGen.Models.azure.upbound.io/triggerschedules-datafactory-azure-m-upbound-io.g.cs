using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datafactory.azure.m.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpecForProviderDataFactoryIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpecForProviderDataFactoryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerScheduleSpecForProviderDataFactoryIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpecForProviderDataFactoryIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpecForProviderDataFactoryIdSelector
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
    public V1beta1TriggerScheduleSpecForProviderDataFactoryIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpecForProviderPipeline
{
    /// <summary>Reference pipeline name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The pipeline parameters that the trigger will act upon.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpecForProviderPipelineNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Pipeline in datafactory to populate pipelineName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpecForProviderPipelineNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerScheduleSpecForProviderPipelineNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpecForProviderPipelineNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Pipeline in datafactory to populate pipelineName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpecForProviderPipelineNameSelector
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
    public V1beta1TriggerScheduleSpecForProviderPipelineNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpecForProviderScheduleMonthly
{
    /// <summary>The occurrence of the specified day during the month. For example, a monthly property with weekday and week values of Sunday, -1 means the last Sunday of the month.</summary>
    [JsonPropertyName("week")]
    public double? Week { get; set; }

    /// <summary>The day of the week on which the trigger runs. For example, a monthly property with a weekday value of Sunday means every Sunday of the month.</summary>
    [JsonPropertyName("weekday")]
    public string? Weekday { get; set; }
}

/// <summary>A schedule block as defined below, which further specifies the recurrence schedule for the trigger. A schedule is capable of limiting or increasing the number of trigger executions specified by the frequency and interval properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpecForProviderSchedule
{
    /// <summary>Day(s) of the month on which the trigger is scheduled. This value can be specified with a monthly frequency only.</summary>
    [JsonPropertyName("daysOfMonth")]
    public IList<double>? DaysOfMonth { get; set; }

    /// <summary>Days of the week on which the trigger is scheduled. This value can be specified only with a weekly frequency.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Hours of the day on which the trigger is scheduled.</summary>
    [JsonPropertyName("hours")]
    public IList<double>? Hours { get; set; }

    /// <summary>Minutes of the hour on which the trigger is scheduled.</summary>
    [JsonPropertyName("minutes")]
    public IList<double>? Minutes { get; set; }

    /// <summary>A monthly block as documented below, which specifies the days of the month on which the trigger is scheduled. The value can be specified only with a monthly frequency.</summary>
    [JsonPropertyName("monthly")]
    public IList<V1beta1TriggerScheduleSpecForProviderScheduleMonthly>? Monthly { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpecForProvider
{
    /// <summary>Specifies if the Data Factory Schedule Trigger is activated. Defaults to true.</summary>
    [JsonPropertyName("activated")]
    public bool? Activated { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Schedule Trigger.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The Data Factory ID in which to associate the Linked Service with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdRef")]
    public V1beta1TriggerScheduleSpecForProviderDataFactoryIdRef? DataFactoryIdRef { get; set; }

    /// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdSelector")]
    public V1beta1TriggerScheduleSpecForProviderDataFactoryIdSelector? DataFactoryIdSelector { get; set; }

    /// <summary>The Schedule Trigger's description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The time the Schedule Trigger should end. The time will be represented in UTC.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>The trigger frequency. Valid values include Minute, Hour, Day, Week, Month. Defaults to Minute.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The interval for how often the trigger occurs. This defaults to 1.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>A pipeline block as defined below.</summary>
    [JsonPropertyName("pipeline")]
    public IList<V1beta1TriggerScheduleSpecForProviderPipeline>? Pipeline { get; set; }

    /// <summary>The Data Factory Pipeline name that the trigger will act on.</summary>
    [JsonPropertyName("pipelineName")]
    public string? PipelineName { get; set; }

    /// <summary>Reference to a Pipeline in datafactory to populate pipelineName.</summary>
    [JsonPropertyName("pipelineNameRef")]
    public V1beta1TriggerScheduleSpecForProviderPipelineNameRef? PipelineNameRef { get; set; }

    /// <summary>Selector for a Pipeline in datafactory to populate pipelineName.</summary>
    [JsonPropertyName("pipelineNameSelector")]
    public V1beta1TriggerScheduleSpecForProviderPipelineNameSelector? PipelineNameSelector { get; set; }

    /// <summary>The pipeline parameters that the trigger will act upon.</summary>
    [JsonPropertyName("pipelineParameters")]
    public IDictionary<string, string>? PipelineParameters { get; set; }

    /// <summary>A schedule block as defined below, which further specifies the recurrence schedule for the trigger. A schedule is capable of limiting or increasing the number of trigger executions specified by the frequency and interval properties.</summary>
    [JsonPropertyName("schedule")]
    public V1beta1TriggerScheduleSpecForProviderSchedule? Schedule { get; set; }

    /// <summary>The time the Schedule Trigger will start. This defaults to the current time. The time will be represented in UTC.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The timezone of the start/end time.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpecInitProviderPipeline
{
    /// <summary>Reference pipeline name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The pipeline parameters that the trigger will act upon.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpecInitProviderPipelineNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Pipeline in datafactory to populate pipelineName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpecInitProviderPipelineNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerScheduleSpecInitProviderPipelineNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpecInitProviderPipelineNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Pipeline in datafactory to populate pipelineName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpecInitProviderPipelineNameSelector
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
    public V1beta1TriggerScheduleSpecInitProviderPipelineNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpecInitProviderScheduleMonthly
{
    /// <summary>The occurrence of the specified day during the month. For example, a monthly property with weekday and week values of Sunday, -1 means the last Sunday of the month.</summary>
    [JsonPropertyName("week")]
    public double? Week { get; set; }

    /// <summary>The day of the week on which the trigger runs. For example, a monthly property with a weekday value of Sunday means every Sunday of the month.</summary>
    [JsonPropertyName("weekday")]
    public string? Weekday { get; set; }
}

/// <summary>A schedule block as defined below, which further specifies the recurrence schedule for the trigger. A schedule is capable of limiting or increasing the number of trigger executions specified by the frequency and interval properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpecInitProviderSchedule
{
    /// <summary>Day(s) of the month on which the trigger is scheduled. This value can be specified with a monthly frequency only.</summary>
    [JsonPropertyName("daysOfMonth")]
    public IList<double>? DaysOfMonth { get; set; }

    /// <summary>Days of the week on which the trigger is scheduled. This value can be specified only with a weekly frequency.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Hours of the day on which the trigger is scheduled.</summary>
    [JsonPropertyName("hours")]
    public IList<double>? Hours { get; set; }

    /// <summary>Minutes of the hour on which the trigger is scheduled.</summary>
    [JsonPropertyName("minutes")]
    public IList<double>? Minutes { get; set; }

    /// <summary>A monthly block as documented below, which specifies the days of the month on which the trigger is scheduled. The value can be specified only with a monthly frequency.</summary>
    [JsonPropertyName("monthly")]
    public IList<V1beta1TriggerScheduleSpecInitProviderScheduleMonthly>? Monthly { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpecInitProvider
{
    /// <summary>Specifies if the Data Factory Schedule Trigger is activated. Defaults to true.</summary>
    [JsonPropertyName("activated")]
    public bool? Activated { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Schedule Trigger.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The Schedule Trigger's description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The time the Schedule Trigger should end. The time will be represented in UTC.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>The trigger frequency. Valid values include Minute, Hour, Day, Week, Month. Defaults to Minute.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The interval for how often the trigger occurs. This defaults to 1.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>A pipeline block as defined below.</summary>
    [JsonPropertyName("pipeline")]
    public IList<V1beta1TriggerScheduleSpecInitProviderPipeline>? Pipeline { get; set; }

    /// <summary>The Data Factory Pipeline name that the trigger will act on.</summary>
    [JsonPropertyName("pipelineName")]
    public string? PipelineName { get; set; }

    /// <summary>Reference to a Pipeline in datafactory to populate pipelineName.</summary>
    [JsonPropertyName("pipelineNameRef")]
    public V1beta1TriggerScheduleSpecInitProviderPipelineNameRef? PipelineNameRef { get; set; }

    /// <summary>Selector for a Pipeline in datafactory to populate pipelineName.</summary>
    [JsonPropertyName("pipelineNameSelector")]
    public V1beta1TriggerScheduleSpecInitProviderPipelineNameSelector? PipelineNameSelector { get; set; }

    /// <summary>The pipeline parameters that the trigger will act upon.</summary>
    [JsonPropertyName("pipelineParameters")]
    public IDictionary<string, string>? PipelineParameters { get; set; }

    /// <summary>A schedule block as defined below, which further specifies the recurrence schedule for the trigger. A schedule is capable of limiting or increasing the number of trigger executions specified by the frequency and interval properties.</summary>
    [JsonPropertyName("schedule")]
    public V1beta1TriggerScheduleSpecInitProviderSchedule? Schedule { get; set; }

    /// <summary>The time the Schedule Trigger will start. This defaults to the current time. The time will be represented in UTC.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The timezone of the start/end time.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpecProviderConfigRef
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
public partial class V1beta1TriggerScheduleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>TriggerScheduleSpec defines the desired state of TriggerSchedule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TriggerScheduleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TriggerScheduleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TriggerScheduleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TriggerScheduleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleStatusAtProviderPipeline
{
    /// <summary>Reference pipeline name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The pipeline parameters that the trigger will act upon.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleStatusAtProviderScheduleMonthly
{
    /// <summary>The occurrence of the specified day during the month. For example, a monthly property with weekday and week values of Sunday, -1 means the last Sunday of the month.</summary>
    [JsonPropertyName("week")]
    public double? Week { get; set; }

    /// <summary>The day of the week on which the trigger runs. For example, a monthly property with a weekday value of Sunday means every Sunday of the month.</summary>
    [JsonPropertyName("weekday")]
    public string? Weekday { get; set; }
}

/// <summary>A schedule block as defined below, which further specifies the recurrence schedule for the trigger. A schedule is capable of limiting or increasing the number of trigger executions specified by the frequency and interval properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleStatusAtProviderSchedule
{
    /// <summary>Day(s) of the month on which the trigger is scheduled. This value can be specified with a monthly frequency only.</summary>
    [JsonPropertyName("daysOfMonth")]
    public IList<double>? DaysOfMonth { get; set; }

    /// <summary>Days of the week on which the trigger is scheduled. This value can be specified only with a weekly frequency.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Hours of the day on which the trigger is scheduled.</summary>
    [JsonPropertyName("hours")]
    public IList<double>? Hours { get; set; }

    /// <summary>Minutes of the hour on which the trigger is scheduled.</summary>
    [JsonPropertyName("minutes")]
    public IList<double>? Minutes { get; set; }

    /// <summary>A monthly block as documented below, which specifies the days of the month on which the trigger is scheduled. The value can be specified only with a monthly frequency.</summary>
    [JsonPropertyName("monthly")]
    public IList<V1beta1TriggerScheduleStatusAtProviderScheduleMonthly>? Monthly { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleStatusAtProvider
{
    /// <summary>Specifies if the Data Factory Schedule Trigger is activated. Defaults to true.</summary>
    [JsonPropertyName("activated")]
    public bool? Activated { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Schedule Trigger.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The Data Factory ID in which to associate the Linked Service with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>The Schedule Trigger's description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The time the Schedule Trigger should end. The time will be represented in UTC.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>The trigger frequency. Valid values include Minute, Hour, Day, Week, Month. Defaults to Minute.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The ID of the Data Factory Schedule Trigger.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The interval for how often the trigger occurs. This defaults to 1.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>A pipeline block as defined below.</summary>
    [JsonPropertyName("pipeline")]
    public IList<V1beta1TriggerScheduleStatusAtProviderPipeline>? Pipeline { get; set; }

    /// <summary>The Data Factory Pipeline name that the trigger will act on.</summary>
    [JsonPropertyName("pipelineName")]
    public string? PipelineName { get; set; }

    /// <summary>The pipeline parameters that the trigger will act upon.</summary>
    [JsonPropertyName("pipelineParameters")]
    public IDictionary<string, string>? PipelineParameters { get; set; }

    /// <summary>A schedule block as defined below, which further specifies the recurrence schedule for the trigger. A schedule is capable of limiting or increasing the number of trigger executions specified by the frequency and interval properties.</summary>
    [JsonPropertyName("schedule")]
    public V1beta1TriggerScheduleStatusAtProviderSchedule? Schedule { get; set; }

    /// <summary>The time the Schedule Trigger will start. This defaults to the current time. The time will be represented in UTC.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The timezone of the start/end time.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleStatusConditions
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

/// <summary>TriggerScheduleStatus defines the observed state of TriggerSchedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerScheduleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TriggerScheduleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TriggerScheduleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>TriggerSchedule is the Schema for the TriggerSchedules API. Manages a Trigger Schedule inside a Azure Data Factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TriggerSchedule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TriggerScheduleSpec>, IStatus<V1beta1TriggerScheduleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TriggerSchedule";
    public const string KubeGroup = "datafactory.azure.m.upbound.io";
    public const string KubePluralName = "triggerschedules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TriggerScheduleSpec defines the desired state of TriggerSchedule</summary>
    [JsonPropertyName("spec")]
    public V1beta1TriggerScheduleSpec Spec { get; set; }

    /// <summary>TriggerScheduleStatus defines the observed state of TriggerSchedule.</summary>
    [JsonPropertyName("status")]
    public V1beta1TriggerScheduleStatus? Status { get; set; }
}

/// <summary>TriggerSchedule is the Schema for the TriggerSchedules API. Manages a Trigger Schedule inside a Azure Data Factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TriggerScheduleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1TriggerSchedule>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TriggerScheduleList";
    public const string KubeGroup = "datafactory.azure.m.upbound.io";
    public const string KubePluralName = "triggerschedules";
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
    public IList<V1beta1TriggerSchedule> Items { get; set; }
}