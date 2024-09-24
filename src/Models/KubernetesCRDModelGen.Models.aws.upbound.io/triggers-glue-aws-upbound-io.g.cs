using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.glue.aws.upbound.io;
public enum V1beta1TriggerSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1TriggerSpecForProviderActionsCrawlerNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerSpecForProviderActionsCrawlerNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerSpecForProviderActionsCrawlerNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderActionsCrawlerNameRefPolicyResolutionEnum>))]
    public V1beta1TriggerSpecForProviderActionsCrawlerNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderActionsCrawlerNameRefPolicyResolveEnum>))]
    public V1beta1TriggerSpecForProviderActionsCrawlerNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerSpecForProviderActionsCrawlerNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecForProviderActionsCrawlerNameRefPolicy? Policy { get; set; }
}

public enum V1beta1TriggerSpecForProviderActionsCrawlerNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerSpecForProviderActionsCrawlerNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerSpecForProviderActionsCrawlerNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderActionsCrawlerNameSelectorPolicyResolutionEnum>))]
    public V1beta1TriggerSpecForProviderActionsCrawlerNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderActionsCrawlerNameSelectorPolicyResolveEnum>))]
    public V1beta1TriggerSpecForProviderActionsCrawlerNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerSpecForProviderActionsCrawlerNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecForProviderActionsCrawlerNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1TriggerSpecForProviderActionsJobNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerSpecForProviderActionsJobNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerSpecForProviderActionsJobNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderActionsJobNameRefPolicyResolutionEnum>))]
    public V1beta1TriggerSpecForProviderActionsJobNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderActionsJobNameRefPolicyResolveEnum>))]
    public V1beta1TriggerSpecForProviderActionsJobNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerSpecForProviderActionsJobNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecForProviderActionsJobNameRefPolicy? Policy { get; set; }
}

public enum V1beta1TriggerSpecForProviderActionsJobNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerSpecForProviderActionsJobNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerSpecForProviderActionsJobNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderActionsJobNameSelectorPolicyResolutionEnum>))]
    public V1beta1TriggerSpecForProviderActionsJobNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderActionsJobNameSelectorPolicyResolveEnum>))]
    public V1beta1TriggerSpecForProviderActionsJobNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerSpecForProviderActionsJobNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecForProviderActionsJobNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1TriggerSpecForProviderActionsNotificationProperty
{
    /// <summary>After a job run starts, the number of minutes to wait before sending a job run delay notification.</summary>
    [JsonPropertyName("notifyDelayAfter")]
    public double? NotifyDelayAfter { get; set; }
}

public partial class V1beta1TriggerSpecForProviderActions
{
    /// <summary>Arguments to be passed to the job. You can specify arguments here that your own job-execution script consumes, as well as arguments that AWS Glue itself consumes.</summary>
    [JsonPropertyName("arguments")]
    public IDictionary<string, string>? Arguments { get; set; }

    /// <summary>The name of the crawler to be executed. Conflicts with job_name.</summary>
    [JsonPropertyName("crawlerName")]
    public string? CrawlerName { get; set; }

    /// <summary>Reference to a Crawler in glue to populate crawlerName.</summary>
    [JsonPropertyName("crawlerNameRef")]
    public V1beta1TriggerSpecForProviderActionsCrawlerNameRef? CrawlerNameRef { get; set; }

    /// <summary>Selector for a Crawler in glue to populate crawlerName.</summary>
    [JsonPropertyName("crawlerNameSelector")]
    public V1beta1TriggerSpecForProviderActionsCrawlerNameSelector? CrawlerNameSelector { get; set; }

    /// <summary>The name of a job to be executed. Conflicts with crawler_name.</summary>
    [JsonPropertyName("jobName")]
    public string? JobName { get; set; }

    /// <summary>Reference to a Job in glue to populate jobName.</summary>
    [JsonPropertyName("jobNameRef")]
    public V1beta1TriggerSpecForProviderActionsJobNameRef? JobNameRef { get; set; }

    /// <summary>Selector for a Job in glue to populate jobName.</summary>
    [JsonPropertyName("jobNameSelector")]
    public V1beta1TriggerSpecForProviderActionsJobNameSelector? JobNameSelector { get; set; }

    /// <summary>Specifies configuration properties of a job run notification. See Notification Property details below.</summary>
    [JsonPropertyName("notificationProperty")]
    public IList<V1beta1TriggerSpecForProviderActionsNotificationProperty>? NotificationProperty { get; set; }

    /// <summary>The name of the Security Configuration structure to be used with this action.</summary>
    [JsonPropertyName("securityConfiguration")]
    public string? SecurityConfiguration { get; set; }

    /// <summary>The job run timeout in minutes. It overrides the timeout value of the job.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }
}

public partial class V1beta1TriggerSpecForProviderEventBatchingCondition
{
    /// <summary>Number of events that must be received from Amazon EventBridge before EventBridge  event trigger fires.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>Window of time in seconds after which EventBridge event trigger fires. Window starts when first event is received. Default value is 900.</summary>
    [JsonPropertyName("batchWindow")]
    public double? BatchWindow { get; set; }
}

public enum V1beta1TriggerSpecForProviderPredicateConditionsCrawlerNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerSpecForProviderPredicateConditionsCrawlerNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerSpecForProviderPredicateConditionsCrawlerNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderPredicateConditionsCrawlerNameRefPolicyResolutionEnum>))]
    public V1beta1TriggerSpecForProviderPredicateConditionsCrawlerNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderPredicateConditionsCrawlerNameRefPolicyResolveEnum>))]
    public V1beta1TriggerSpecForProviderPredicateConditionsCrawlerNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerSpecForProviderPredicateConditionsCrawlerNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecForProviderPredicateConditionsCrawlerNameRefPolicy? Policy { get; set; }
}

public enum V1beta1TriggerSpecForProviderPredicateConditionsCrawlerNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerSpecForProviderPredicateConditionsCrawlerNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerSpecForProviderPredicateConditionsCrawlerNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderPredicateConditionsCrawlerNameSelectorPolicyResolutionEnum>))]
    public V1beta1TriggerSpecForProviderPredicateConditionsCrawlerNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderPredicateConditionsCrawlerNameSelectorPolicyResolveEnum>))]
    public V1beta1TriggerSpecForProviderPredicateConditionsCrawlerNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerSpecForProviderPredicateConditionsCrawlerNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecForProviderPredicateConditionsCrawlerNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1TriggerSpecForProviderPredicateConditionsJobNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerSpecForProviderPredicateConditionsJobNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerSpecForProviderPredicateConditionsJobNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderPredicateConditionsJobNameRefPolicyResolutionEnum>))]
    public V1beta1TriggerSpecForProviderPredicateConditionsJobNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderPredicateConditionsJobNameRefPolicyResolveEnum>))]
    public V1beta1TriggerSpecForProviderPredicateConditionsJobNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerSpecForProviderPredicateConditionsJobNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecForProviderPredicateConditionsJobNameRefPolicy? Policy { get; set; }
}

public enum V1beta1TriggerSpecForProviderPredicateConditionsJobNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerSpecForProviderPredicateConditionsJobNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerSpecForProviderPredicateConditionsJobNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderPredicateConditionsJobNameSelectorPolicyResolutionEnum>))]
    public V1beta1TriggerSpecForProviderPredicateConditionsJobNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderPredicateConditionsJobNameSelectorPolicyResolveEnum>))]
    public V1beta1TriggerSpecForProviderPredicateConditionsJobNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerSpecForProviderPredicateConditionsJobNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecForProviderPredicateConditionsJobNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1TriggerSpecForProviderPredicateConditions
{
    /// <summary>The condition crawl state. Currently, the values supported are RUNNING, SUCCEEDED, CANCELLED, and FAILED. If this is specified, crawler_name must also be specified. Conflicts with state.</summary>
    [JsonPropertyName("crawlState")]
    public string? CrawlState { get; set; }

    /// <summary>The name of the crawler to be executed. Conflicts with job_name.</summary>
    [JsonPropertyName("crawlerName")]
    public string? CrawlerName { get; set; }

    /// <summary>Reference to a Crawler in glue to populate crawlerName.</summary>
    [JsonPropertyName("crawlerNameRef")]
    public V1beta1TriggerSpecForProviderPredicateConditionsCrawlerNameRef? CrawlerNameRef { get; set; }

    /// <summary>Selector for a Crawler in glue to populate crawlerName.</summary>
    [JsonPropertyName("crawlerNameSelector")]
    public V1beta1TriggerSpecForProviderPredicateConditionsCrawlerNameSelector? CrawlerNameSelector { get; set; }

    /// <summary>The name of a job to be executed. Conflicts with crawler_name.</summary>
    [JsonPropertyName("jobName")]
    public string? JobName { get; set; }

    /// <summary>Reference to a Job in glue to populate jobName.</summary>
    [JsonPropertyName("jobNameRef")]
    public V1beta1TriggerSpecForProviderPredicateConditionsJobNameRef? JobNameRef { get; set; }

    /// <summary>Selector for a Job in glue to populate jobName.</summary>
    [JsonPropertyName("jobNameSelector")]
    public V1beta1TriggerSpecForProviderPredicateConditionsJobNameSelector? JobNameSelector { get; set; }

    /// <summary>A logical operator. Defaults to EQUALS.</summary>
    [JsonPropertyName("logicalOperator")]
    public string? LogicalOperator { get; set; }

    /// <summary>The condition job state. Currently, the values supported are SUCCEEDED, STOPPED, TIMEOUT and FAILED. If this is specified, job_name must also be specified. Conflicts with crawler_state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

public partial class V1beta1TriggerSpecForProviderPredicate
{
    /// <summary>A list of the conditions that determine when the trigger will fire. See Conditions.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TriggerSpecForProviderPredicateConditions>? Conditions { get; set; }

    /// <summary>How to handle multiple conditions. Defaults to AND. Valid values are AND or ANY.</summary>
    [JsonPropertyName("logical")]
    public string? Logical { get; set; }
}

public partial class V1beta1TriggerSpecForProvider
{
    /// <summary>–  List of actions initiated by this trigger when it fires. See Actions Below.</summary>
    [JsonPropertyName("actions")]
    public IList<V1beta1TriggerSpecForProviderActions>? Actions { get; set; }

    /// <summary>–  A description of the new trigger.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>–  Start the trigger. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Batch condition that must be met (specified number of events received or batch time window expired) before EventBridge event trigger fires. See Event Batching Condition.</summary>
    [JsonPropertyName("eventBatchingCondition")]
    public IList<V1beta1TriggerSpecForProviderEventBatchingCondition>? EventBatchingCondition { get; set; }

    /// <summary>–  A predicate to specify when the new trigger should fire. Required when trigger type is CONDITIONAL. See Predicate Below.</summary>
    [JsonPropertyName("predicate")]
    public IList<V1beta1TriggerSpecForProviderPredicate>? Predicate { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Based Schedules for Jobs and Crawlers</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>–  Set to true to start SCHEDULED and CONDITIONAL triggers when created. True is not supported for ON_DEMAND triggers.</summary>
    [JsonPropertyName("startOnCreation")]
    public bool? StartOnCreation { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>–  The type of trigger. Valid values are CONDITIONAL, EVENT, ON_DEMAND, and SCHEDULED.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>A workflow to which the trigger should be associated to. Every workflow graph (DAG) needs a starting trigger (ON_DEMAND or SCHEDULED type) and can contain multiple additional CONDITIONAL triggers.</summary>
    [JsonPropertyName("workflowName")]
    public string? WorkflowName { get; set; }
}

public enum V1beta1TriggerSpecInitProviderActionsCrawlerNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerSpecInitProviderActionsCrawlerNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerSpecInitProviderActionsCrawlerNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderActionsCrawlerNameRefPolicyResolutionEnum>))]
    public V1beta1TriggerSpecInitProviderActionsCrawlerNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderActionsCrawlerNameRefPolicyResolveEnum>))]
    public V1beta1TriggerSpecInitProviderActionsCrawlerNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerSpecInitProviderActionsCrawlerNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecInitProviderActionsCrawlerNameRefPolicy? Policy { get; set; }
}

public enum V1beta1TriggerSpecInitProviderActionsCrawlerNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerSpecInitProviderActionsCrawlerNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerSpecInitProviderActionsCrawlerNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderActionsCrawlerNameSelectorPolicyResolutionEnum>))]
    public V1beta1TriggerSpecInitProviderActionsCrawlerNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderActionsCrawlerNameSelectorPolicyResolveEnum>))]
    public V1beta1TriggerSpecInitProviderActionsCrawlerNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerSpecInitProviderActionsCrawlerNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecInitProviderActionsCrawlerNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1TriggerSpecInitProviderActionsJobNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerSpecInitProviderActionsJobNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerSpecInitProviderActionsJobNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderActionsJobNameRefPolicyResolutionEnum>))]
    public V1beta1TriggerSpecInitProviderActionsJobNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderActionsJobNameRefPolicyResolveEnum>))]
    public V1beta1TriggerSpecInitProviderActionsJobNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerSpecInitProviderActionsJobNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecInitProviderActionsJobNameRefPolicy? Policy { get; set; }
}

public enum V1beta1TriggerSpecInitProviderActionsJobNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerSpecInitProviderActionsJobNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerSpecInitProviderActionsJobNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderActionsJobNameSelectorPolicyResolutionEnum>))]
    public V1beta1TriggerSpecInitProviderActionsJobNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderActionsJobNameSelectorPolicyResolveEnum>))]
    public V1beta1TriggerSpecInitProviderActionsJobNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerSpecInitProviderActionsJobNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecInitProviderActionsJobNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1TriggerSpecInitProviderActionsNotificationProperty
{
    /// <summary>After a job run starts, the number of minutes to wait before sending a job run delay notification.</summary>
    [JsonPropertyName("notifyDelayAfter")]
    public double? NotifyDelayAfter { get; set; }
}

public partial class V1beta1TriggerSpecInitProviderActions
{
    /// <summary>Arguments to be passed to the job. You can specify arguments here that your own job-execution script consumes, as well as arguments that AWS Glue itself consumes.</summary>
    [JsonPropertyName("arguments")]
    public IDictionary<string, string>? Arguments { get; set; }

    /// <summary>The name of the crawler to be executed. Conflicts with job_name.</summary>
    [JsonPropertyName("crawlerName")]
    public string? CrawlerName { get; set; }

    /// <summary>Reference to a Crawler in glue to populate crawlerName.</summary>
    [JsonPropertyName("crawlerNameRef")]
    public V1beta1TriggerSpecInitProviderActionsCrawlerNameRef? CrawlerNameRef { get; set; }

    /// <summary>Selector for a Crawler in glue to populate crawlerName.</summary>
    [JsonPropertyName("crawlerNameSelector")]
    public V1beta1TriggerSpecInitProviderActionsCrawlerNameSelector? CrawlerNameSelector { get; set; }

    /// <summary>The name of a job to be executed. Conflicts with crawler_name.</summary>
    [JsonPropertyName("jobName")]
    public string? JobName { get; set; }

    /// <summary>Reference to a Job in glue to populate jobName.</summary>
    [JsonPropertyName("jobNameRef")]
    public V1beta1TriggerSpecInitProviderActionsJobNameRef? JobNameRef { get; set; }

    /// <summary>Selector for a Job in glue to populate jobName.</summary>
    [JsonPropertyName("jobNameSelector")]
    public V1beta1TriggerSpecInitProviderActionsJobNameSelector? JobNameSelector { get; set; }

    /// <summary>Specifies configuration properties of a job run notification. See Notification Property details below.</summary>
    [JsonPropertyName("notificationProperty")]
    public IList<V1beta1TriggerSpecInitProviderActionsNotificationProperty>? NotificationProperty { get; set; }

    /// <summary>The name of the Security Configuration structure to be used with this action.</summary>
    [JsonPropertyName("securityConfiguration")]
    public string? SecurityConfiguration { get; set; }

    /// <summary>The job run timeout in minutes. It overrides the timeout value of the job.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }
}

public partial class V1beta1TriggerSpecInitProviderEventBatchingCondition
{
    /// <summary>Number of events that must be received from Amazon EventBridge before EventBridge  event trigger fires.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>Window of time in seconds after which EventBridge event trigger fires. Window starts when first event is received. Default value is 900.</summary>
    [JsonPropertyName("batchWindow")]
    public double? BatchWindow { get; set; }
}

public enum V1beta1TriggerSpecInitProviderPredicateConditionsCrawlerNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerSpecInitProviderPredicateConditionsCrawlerNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerSpecInitProviderPredicateConditionsCrawlerNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderPredicateConditionsCrawlerNameRefPolicyResolutionEnum>))]
    public V1beta1TriggerSpecInitProviderPredicateConditionsCrawlerNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderPredicateConditionsCrawlerNameRefPolicyResolveEnum>))]
    public V1beta1TriggerSpecInitProviderPredicateConditionsCrawlerNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerSpecInitProviderPredicateConditionsCrawlerNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecInitProviderPredicateConditionsCrawlerNameRefPolicy? Policy { get; set; }
}

public enum V1beta1TriggerSpecInitProviderPredicateConditionsCrawlerNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerSpecInitProviderPredicateConditionsCrawlerNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerSpecInitProviderPredicateConditionsCrawlerNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderPredicateConditionsCrawlerNameSelectorPolicyResolutionEnum>))]
    public V1beta1TriggerSpecInitProviderPredicateConditionsCrawlerNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderPredicateConditionsCrawlerNameSelectorPolicyResolveEnum>))]
    public V1beta1TriggerSpecInitProviderPredicateConditionsCrawlerNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerSpecInitProviderPredicateConditionsCrawlerNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecInitProviderPredicateConditionsCrawlerNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1TriggerSpecInitProviderPredicateConditionsJobNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerSpecInitProviderPredicateConditionsJobNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerSpecInitProviderPredicateConditionsJobNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderPredicateConditionsJobNameRefPolicyResolutionEnum>))]
    public V1beta1TriggerSpecInitProviderPredicateConditionsJobNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderPredicateConditionsJobNameRefPolicyResolveEnum>))]
    public V1beta1TriggerSpecInitProviderPredicateConditionsJobNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerSpecInitProviderPredicateConditionsJobNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecInitProviderPredicateConditionsJobNameRefPolicy? Policy { get; set; }
}

public enum V1beta1TriggerSpecInitProviderPredicateConditionsJobNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerSpecInitProviderPredicateConditionsJobNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerSpecInitProviderPredicateConditionsJobNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderPredicateConditionsJobNameSelectorPolicyResolutionEnum>))]
    public V1beta1TriggerSpecInitProviderPredicateConditionsJobNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderPredicateConditionsJobNameSelectorPolicyResolveEnum>))]
    public V1beta1TriggerSpecInitProviderPredicateConditionsJobNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerSpecInitProviderPredicateConditionsJobNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecInitProviderPredicateConditionsJobNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1TriggerSpecInitProviderPredicateConditions
{
    /// <summary>The condition crawl state. Currently, the values supported are RUNNING, SUCCEEDED, CANCELLED, and FAILED. If this is specified, crawler_name must also be specified. Conflicts with state.</summary>
    [JsonPropertyName("crawlState")]
    public string? CrawlState { get; set; }

    /// <summary>The name of the crawler to be executed. Conflicts with job_name.</summary>
    [JsonPropertyName("crawlerName")]
    public string? CrawlerName { get; set; }

    /// <summary>Reference to a Crawler in glue to populate crawlerName.</summary>
    [JsonPropertyName("crawlerNameRef")]
    public V1beta1TriggerSpecInitProviderPredicateConditionsCrawlerNameRef? CrawlerNameRef { get; set; }

    /// <summary>Selector for a Crawler in glue to populate crawlerName.</summary>
    [JsonPropertyName("crawlerNameSelector")]
    public V1beta1TriggerSpecInitProviderPredicateConditionsCrawlerNameSelector? CrawlerNameSelector { get; set; }

    /// <summary>The name of a job to be executed. Conflicts with crawler_name.</summary>
    [JsonPropertyName("jobName")]
    public string? JobName { get; set; }

    /// <summary>Reference to a Job in glue to populate jobName.</summary>
    [JsonPropertyName("jobNameRef")]
    public V1beta1TriggerSpecInitProviderPredicateConditionsJobNameRef? JobNameRef { get; set; }

    /// <summary>Selector for a Job in glue to populate jobName.</summary>
    [JsonPropertyName("jobNameSelector")]
    public V1beta1TriggerSpecInitProviderPredicateConditionsJobNameSelector? JobNameSelector { get; set; }

    /// <summary>A logical operator. Defaults to EQUALS.</summary>
    [JsonPropertyName("logicalOperator")]
    public string? LogicalOperator { get; set; }

    /// <summary>The condition job state. Currently, the values supported are SUCCEEDED, STOPPED, TIMEOUT and FAILED. If this is specified, job_name must also be specified. Conflicts with crawler_state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

public partial class V1beta1TriggerSpecInitProviderPredicate
{
    /// <summary>A list of the conditions that determine when the trigger will fire. See Conditions.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TriggerSpecInitProviderPredicateConditions>? Conditions { get; set; }

    /// <summary>How to handle multiple conditions. Defaults to AND. Valid values are AND or ANY.</summary>
    [JsonPropertyName("logical")]
    public string? Logical { get; set; }
}

public partial class V1beta1TriggerSpecInitProvider
{
    /// <summary>–  List of actions initiated by this trigger when it fires. See Actions Below.</summary>
    [JsonPropertyName("actions")]
    public IList<V1beta1TriggerSpecInitProviderActions>? Actions { get; set; }

    /// <summary>–  A description of the new trigger.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>–  Start the trigger. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Batch condition that must be met (specified number of events received or batch time window expired) before EventBridge event trigger fires. See Event Batching Condition.</summary>
    [JsonPropertyName("eventBatchingCondition")]
    public IList<V1beta1TriggerSpecInitProviderEventBatchingCondition>? EventBatchingCondition { get; set; }

    /// <summary>–  A predicate to specify when the new trigger should fire. Required when trigger type is CONDITIONAL. See Predicate Below.</summary>
    [JsonPropertyName("predicate")]
    public IList<V1beta1TriggerSpecInitProviderPredicate>? Predicate { get; set; }

    /// <summary>Based Schedules for Jobs and Crawlers</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>–  Set to true to start SCHEDULED and CONDITIONAL triggers when created. True is not supported for ON_DEMAND triggers.</summary>
    [JsonPropertyName("startOnCreation")]
    public bool? StartOnCreation { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>–  The type of trigger. Valid values are CONDITIONAL, EVENT, ON_DEMAND, and SCHEDULED.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>A workflow to which the trigger should be associated to. Every workflow graph (DAG) needs a starting trigger (ON_DEMAND or SCHEDULED type) and can contain multiple additional CONDITIONAL triggers.</summary>
    [JsonPropertyName("workflowName")]
    public string? WorkflowName { get; set; }
}

public enum V1beta1TriggerSpecManagementPoliciesEnum
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

public enum V1beta1TriggerSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1TriggerSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1TriggerSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1TriggerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1TriggerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1TriggerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1TriggerSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1TriggerSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1TriggerSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1TriggerSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1TriggerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1TriggerSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecDeletionPolicyEnum>))]
    public V1beta1TriggerSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TriggerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TriggerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1TriggerSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TriggerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1TriggerSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TriggerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1TriggerStatusAtProviderActionsNotificationProperty
{
    /// <summary>After a job run starts, the number of minutes to wait before sending a job run delay notification.</summary>
    [JsonPropertyName("notifyDelayAfter")]
    public double? NotifyDelayAfter { get; set; }
}

public partial class V1beta1TriggerStatusAtProviderActions
{
    /// <summary>Arguments to be passed to the job. You can specify arguments here that your own job-execution script consumes, as well as arguments that AWS Glue itself consumes.</summary>
    [JsonPropertyName("arguments")]
    public IDictionary<string, string>? Arguments { get; set; }

    /// <summary>The name of the crawler to be executed. Conflicts with job_name.</summary>
    [JsonPropertyName("crawlerName")]
    public string? CrawlerName { get; set; }

    /// <summary>The name of a job to be executed. Conflicts with crawler_name.</summary>
    [JsonPropertyName("jobName")]
    public string? JobName { get; set; }

    /// <summary>Specifies configuration properties of a job run notification. See Notification Property details below.</summary>
    [JsonPropertyName("notificationProperty")]
    public IList<V1beta1TriggerStatusAtProviderActionsNotificationProperty>? NotificationProperty { get; set; }

    /// <summary>The name of the Security Configuration structure to be used with this action.</summary>
    [JsonPropertyName("securityConfiguration")]
    public string? SecurityConfiguration { get; set; }

    /// <summary>The job run timeout in minutes. It overrides the timeout value of the job.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }
}

public partial class V1beta1TriggerStatusAtProviderEventBatchingCondition
{
    /// <summary>Number of events that must be received from Amazon EventBridge before EventBridge  event trigger fires.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>Window of time in seconds after which EventBridge event trigger fires. Window starts when first event is received. Default value is 900.</summary>
    [JsonPropertyName("batchWindow")]
    public double? BatchWindow { get; set; }
}

public partial class V1beta1TriggerStatusAtProviderPredicateConditions
{
    /// <summary>The condition crawl state. Currently, the values supported are RUNNING, SUCCEEDED, CANCELLED, and FAILED. If this is specified, crawler_name must also be specified. Conflicts with state.</summary>
    [JsonPropertyName("crawlState")]
    public string? CrawlState { get; set; }

    /// <summary>The name of the crawler to be executed. Conflicts with job_name.</summary>
    [JsonPropertyName("crawlerName")]
    public string? CrawlerName { get; set; }

    /// <summary>The name of a job to be executed. Conflicts with crawler_name.</summary>
    [JsonPropertyName("jobName")]
    public string? JobName { get; set; }

    /// <summary>A logical operator. Defaults to EQUALS.</summary>
    [JsonPropertyName("logicalOperator")]
    public string? LogicalOperator { get; set; }

    /// <summary>The condition job state. Currently, the values supported are SUCCEEDED, STOPPED, TIMEOUT and FAILED. If this is specified, job_name must also be specified. Conflicts with crawler_state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

public partial class V1beta1TriggerStatusAtProviderPredicate
{
    /// <summary>A list of the conditions that determine when the trigger will fire. See Conditions.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TriggerStatusAtProviderPredicateConditions>? Conditions { get; set; }

    /// <summary>How to handle multiple conditions. Defaults to AND. Valid values are AND or ANY.</summary>
    [JsonPropertyName("logical")]
    public string? Logical { get; set; }
}

public partial class V1beta1TriggerStatusAtProvider
{
    /// <summary>–  List of actions initiated by this trigger when it fires. See Actions Below.</summary>
    [JsonPropertyName("actions")]
    public IList<V1beta1TriggerStatusAtProviderActions>? Actions { get; set; }

    /// <summary>Amazon Resource Name (ARN) of Glue Trigger</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>–  A description of the new trigger.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>–  Start the trigger. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Batch condition that must be met (specified number of events received or batch time window expired) before EventBridge event trigger fires. See Event Batching Condition.</summary>
    [JsonPropertyName("eventBatchingCondition")]
    public IList<V1beta1TriggerStatusAtProviderEventBatchingCondition>? EventBatchingCondition { get; set; }

    /// <summary>Trigger name</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>–  A predicate to specify when the new trigger should fire. Required when trigger type is CONDITIONAL. See Predicate Below.</summary>
    [JsonPropertyName("predicate")]
    public IList<V1beta1TriggerStatusAtProviderPredicate>? Predicate { get; set; }

    /// <summary>Based Schedules for Jobs and Crawlers</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>–  Set to true to start SCHEDULED and CONDITIONAL triggers when created. True is not supported for ON_DEMAND triggers.</summary>
    [JsonPropertyName("startOnCreation")]
    public bool? StartOnCreation { get; set; }

    /// <summary>The condition job state. Currently, the values supported are SUCCEEDED, STOPPED, TIMEOUT and FAILED. If this is specified, job_name must also be specified. Conflicts with crawler_state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>–  The type of trigger. Valid values are CONDITIONAL, EVENT, ON_DEMAND, and SCHEDULED.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>A workflow to which the trigger should be associated to. Every workflow graph (DAG) needs a starting trigger (ON_DEMAND or SCHEDULED type) and can contain multiple additional CONDITIONAL triggers.</summary>
    [JsonPropertyName("workflowName")]
    public string? WorkflowName { get; set; }
}

public partial class V1beta1TriggerStatusConditions
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

public partial class V1beta1TriggerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TriggerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TriggerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Trigger : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TriggerSpec>, IStatus<V1beta1TriggerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Trigger";
    public const string KubeGroup = "glue.aws.upbound.io";
    public const string KubePluralName = "triggers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TriggerSpec defines the desired state of Trigger</summary>
    [JsonPropertyName("spec")]
    public V1beta1TriggerSpec Spec { get; set; }

    /// <summary>TriggerStatus defines the observed state of Trigger.</summary>
    [JsonPropertyName("status")]
    public V1beta1TriggerStatus? Status { get; set; }
}