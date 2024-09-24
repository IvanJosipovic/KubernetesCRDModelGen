using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.securityinsights.azure.upbound.io;
public enum V1beta1SentinelAutomationRuleSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1SentinelAutomationRuleSpecForProviderActionIncident
{
    /// <summary>The classification of the incident, when closing it. Possible values are: BenignPositive_SuspiciousButExpected, FalsePositive_InaccurateData, FalsePositive_IncorrectAlertLogic, TruePositive_SuspiciousActivity and Undetermined.</summary>
    [JsonPropertyName("classification")]
    public string? Classification { get; set; }

    /// <summary>The comment why the incident is to be closed.</summary>
    [JsonPropertyName("classificationComment")]
    public string? ClassificationComment { get; set; }

    /// <summary>Specifies a list of labels to add to the incident.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>The execution order of this action.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>The object ID of the entity this incident is assigned to.</summary>
    [JsonPropertyName("ownerId")]
    public string? OwnerId { get; set; }

    /// <summary>The severity to add to the incident. Possible values are High, Informational, Low and Medium.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>The status to set to the incident. Possible values are: Active, Closed, New.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

public partial class V1beta1SentinelAutomationRuleSpecForProviderActionPlaybook
{
    /// <summary>The ID of the Logic App that defines the playbook's logic.</summary>
    [JsonPropertyName("logicAppId")]
    public string? LogicAppId { get; set; }

    /// <summary>The execution order of this action.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>The ID of the Tenant that owns the playbook.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

public partial class V1beta1SentinelAutomationRuleSpecForProviderCondition
{
    /// <summary>The operator to use for evaluate the condition. Possible values include: Equals, NotEquals, Contains, NotContains, StartsWith, NotStartsWith, EndsWith, NotEndsWith.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The property to use for evaluate the condition. Possible values are AccountAadTenantId, AccountAadUserId, AccountNTDomain, AccountName, AccountObjectGuid, AccountPUID, AccountSid, AccountUPNSuffix, AlertAnalyticRuleIds, AlertProductNames, AzureResourceResourceId, AzureResourceSubscriptionId, CloudApplicationAppId, CloudApplicationAppName, DNSDomainName, FileDirectory, FileHashValue, FileName, HostAzureID, HostNTDomain, HostName, HostNetBiosName, HostOSVersion, IPAddress, IncidentCustomDetailsKey, IncidentCustomDetailsValue, IncidentDescription, IncidentLabel, IncidentProviderName, IncidentRelatedAnalyticRuleIds, IncidentSeverity, IncidentStatus, IncidentTactics, IncidentTitle, IncidentUpdatedBySource, IoTDeviceId, IoTDeviceModel, IoTDeviceName, IoTDeviceOperatingSystem, IoTDeviceType, IoTDeviceVendor, MailMessageDeliveryAction, MailMessageDeliveryLocation, MailMessageP1Sender, MailMessageP2Sender, MailMessageRecipient, MailMessageSenderIP, MailMessageSubject, MailboxDisplayName, MailboxPrimaryAddress, MailboxUPN, MalwareCategory, MalwareName, ProcessCommandLine, ProcessId, RegistryKey, RegistryValueData and Url.</summary>
    [JsonPropertyName("property")]
    public string? Property { get; set; }

    /// <summary>Specifies a list of values to use for evaluate the condition.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

public enum V1beta1SentinelAutomationRuleSpecForProviderLogAnalyticsWorkspaceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SentinelAutomationRuleSpecForProviderLogAnalyticsWorkspaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SentinelAutomationRuleSpecForProviderLogAnalyticsWorkspaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAutomationRuleSpecForProviderLogAnalyticsWorkspaceIdRefPolicyResolutionEnum>))]
    public V1beta1SentinelAutomationRuleSpecForProviderLogAnalyticsWorkspaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAutomationRuleSpecForProviderLogAnalyticsWorkspaceIdRefPolicyResolveEnum>))]
    public V1beta1SentinelAutomationRuleSpecForProviderLogAnalyticsWorkspaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SentinelAutomationRuleSpecForProviderLogAnalyticsWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SentinelAutomationRuleSpecForProviderLogAnalyticsWorkspaceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SentinelAutomationRuleSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SentinelAutomationRuleSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SentinelAutomationRuleSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAutomationRuleSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicyResolutionEnum>))]
    public V1beta1SentinelAutomationRuleSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAutomationRuleSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicyResolveEnum>))]
    public V1beta1SentinelAutomationRuleSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SentinelAutomationRuleSpecForProviderLogAnalyticsWorkspaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SentinelAutomationRuleSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1SentinelAutomationRuleSpecForProvider
{
    /// <summary>One or more action_incident blocks as defined below.</summary>
    [JsonPropertyName("actionIncident")]
    public IList<V1beta1SentinelAutomationRuleSpecForProviderActionIncident>? ActionIncident { get; set; }

    /// <summary>One or more action_playbook blocks as defined below.</summary>
    [JsonPropertyName("actionPlaybook")]
    public IList<V1beta1SentinelAutomationRuleSpecForProviderActionPlaybook>? ActionPlaybook { get; set; }

    /// <summary>One or more condition blocks as defined below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1SentinelAutomationRuleSpecForProviderCondition>? Condition { get; set; }

    /// <summary>A JSON array of one or more condition JSON objects as is defined here.</summary>
    [JsonPropertyName("conditionJson")]
    public string? ConditionJson { get; set; }

    /// <summary>The display name which should be used for this Sentinel Automation Rule.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Whether this Sentinel Automation Rule is enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The time in RFC3339 format of kind UTC that determines when this Automation Rule should expire and be disabled.</summary>
    [JsonPropertyName("expiration")]
    public string? Expiration { get; set; }

    /// <summary>The ID of the Log Analytics Workspace where this Sentinel applies to. Changing this forces a new Sentinel Automation Rule to be created.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>Reference to a SentinelLogAnalyticsWorkspaceOnboarding in securityinsights to populate logAnalyticsWorkspaceId.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceIdRef")]
    public V1beta1SentinelAutomationRuleSpecForProviderLogAnalyticsWorkspaceIdRef? LogAnalyticsWorkspaceIdRef { get; set; }

    /// <summary>Selector for a SentinelLogAnalyticsWorkspaceOnboarding in securityinsights to populate logAnalyticsWorkspaceId.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceIdSelector")]
    public V1beta1SentinelAutomationRuleSpecForProviderLogAnalyticsWorkspaceIdSelector? LogAnalyticsWorkspaceIdSelector { get; set; }

    /// <summary>The UUID which should be used for this Sentinel Automation Rule. Changing this forces a new Sentinel Automation Rule to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The order of this Sentinel Automation Rule. Possible values varies between 1 and 1000.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Specifies what triggers this automation rule. Possible values are Alerts and Incidents. Defaults to Incidents.</summary>
    [JsonPropertyName("triggersOn")]
    public string? TriggersOn { get; set; }

    /// <summary>Specifies when will this automation rule be triggered. Possible values are Created and Updated. Defaults to Created.</summary>
    [JsonPropertyName("triggersWhen")]
    public string? TriggersWhen { get; set; }
}

public partial class V1beta1SentinelAutomationRuleSpecInitProviderActionIncident
{
    /// <summary>The classification of the incident, when closing it. Possible values are: BenignPositive_SuspiciousButExpected, FalsePositive_InaccurateData, FalsePositive_IncorrectAlertLogic, TruePositive_SuspiciousActivity and Undetermined.</summary>
    [JsonPropertyName("classification")]
    public string? Classification { get; set; }

    /// <summary>The comment why the incident is to be closed.</summary>
    [JsonPropertyName("classificationComment")]
    public string? ClassificationComment { get; set; }

    /// <summary>Specifies a list of labels to add to the incident.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>The execution order of this action.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>The object ID of the entity this incident is assigned to.</summary>
    [JsonPropertyName("ownerId")]
    public string? OwnerId { get; set; }

    /// <summary>The severity to add to the incident. Possible values are High, Informational, Low and Medium.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>The status to set to the incident. Possible values are: Active, Closed, New.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

public partial class V1beta1SentinelAutomationRuleSpecInitProviderActionPlaybook
{
    /// <summary>The ID of the Logic App that defines the playbook's logic.</summary>
    [JsonPropertyName("logicAppId")]
    public string? LogicAppId { get; set; }

    /// <summary>The execution order of this action.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>The ID of the Tenant that owns the playbook.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

public partial class V1beta1SentinelAutomationRuleSpecInitProviderCondition
{
    /// <summary>The operator to use for evaluate the condition. Possible values include: Equals, NotEquals, Contains, NotContains, StartsWith, NotStartsWith, EndsWith, NotEndsWith.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The property to use for evaluate the condition. Possible values are AccountAadTenantId, AccountAadUserId, AccountNTDomain, AccountName, AccountObjectGuid, AccountPUID, AccountSid, AccountUPNSuffix, AlertAnalyticRuleIds, AlertProductNames, AzureResourceResourceId, AzureResourceSubscriptionId, CloudApplicationAppId, CloudApplicationAppName, DNSDomainName, FileDirectory, FileHashValue, FileName, HostAzureID, HostNTDomain, HostName, HostNetBiosName, HostOSVersion, IPAddress, IncidentCustomDetailsKey, IncidentCustomDetailsValue, IncidentDescription, IncidentLabel, IncidentProviderName, IncidentRelatedAnalyticRuleIds, IncidentSeverity, IncidentStatus, IncidentTactics, IncidentTitle, IncidentUpdatedBySource, IoTDeviceId, IoTDeviceModel, IoTDeviceName, IoTDeviceOperatingSystem, IoTDeviceType, IoTDeviceVendor, MailMessageDeliveryAction, MailMessageDeliveryLocation, MailMessageP1Sender, MailMessageP2Sender, MailMessageRecipient, MailMessageSenderIP, MailMessageSubject, MailboxDisplayName, MailboxPrimaryAddress, MailboxUPN, MalwareCategory, MalwareName, ProcessCommandLine, ProcessId, RegistryKey, RegistryValueData and Url.</summary>
    [JsonPropertyName("property")]
    public string? Property { get; set; }

    /// <summary>Specifies a list of values to use for evaluate the condition.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

public enum V1beta1SentinelAutomationRuleSpecInitProviderLogAnalyticsWorkspaceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SentinelAutomationRuleSpecInitProviderLogAnalyticsWorkspaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SentinelAutomationRuleSpecInitProviderLogAnalyticsWorkspaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAutomationRuleSpecInitProviderLogAnalyticsWorkspaceIdRefPolicyResolutionEnum>))]
    public V1beta1SentinelAutomationRuleSpecInitProviderLogAnalyticsWorkspaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAutomationRuleSpecInitProviderLogAnalyticsWorkspaceIdRefPolicyResolveEnum>))]
    public V1beta1SentinelAutomationRuleSpecInitProviderLogAnalyticsWorkspaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SentinelAutomationRuleSpecInitProviderLogAnalyticsWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SentinelAutomationRuleSpecInitProviderLogAnalyticsWorkspaceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1SentinelAutomationRuleSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SentinelAutomationRuleSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SentinelAutomationRuleSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAutomationRuleSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicyResolutionEnum>))]
    public V1beta1SentinelAutomationRuleSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAutomationRuleSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicyResolveEnum>))]
    public V1beta1SentinelAutomationRuleSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SentinelAutomationRuleSpecInitProviderLogAnalyticsWorkspaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SentinelAutomationRuleSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1SentinelAutomationRuleSpecInitProvider
{
    /// <summary>One or more action_incident blocks as defined below.</summary>
    [JsonPropertyName("actionIncident")]
    public IList<V1beta1SentinelAutomationRuleSpecInitProviderActionIncident>? ActionIncident { get; set; }

    /// <summary>One or more action_playbook blocks as defined below.</summary>
    [JsonPropertyName("actionPlaybook")]
    public IList<V1beta1SentinelAutomationRuleSpecInitProviderActionPlaybook>? ActionPlaybook { get; set; }

    /// <summary>One or more condition blocks as defined below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1SentinelAutomationRuleSpecInitProviderCondition>? Condition { get; set; }

    /// <summary>A JSON array of one or more condition JSON objects as is defined here.</summary>
    [JsonPropertyName("conditionJson")]
    public string? ConditionJson { get; set; }

    /// <summary>The display name which should be used for this Sentinel Automation Rule.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Whether this Sentinel Automation Rule is enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The time in RFC3339 format of kind UTC that determines when this Automation Rule should expire and be disabled.</summary>
    [JsonPropertyName("expiration")]
    public string? Expiration { get; set; }

    /// <summary>The ID of the Log Analytics Workspace where this Sentinel applies to. Changing this forces a new Sentinel Automation Rule to be created.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>Reference to a SentinelLogAnalyticsWorkspaceOnboarding in securityinsights to populate logAnalyticsWorkspaceId.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceIdRef")]
    public V1beta1SentinelAutomationRuleSpecInitProviderLogAnalyticsWorkspaceIdRef? LogAnalyticsWorkspaceIdRef { get; set; }

    /// <summary>Selector for a SentinelLogAnalyticsWorkspaceOnboarding in securityinsights to populate logAnalyticsWorkspaceId.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceIdSelector")]
    public V1beta1SentinelAutomationRuleSpecInitProviderLogAnalyticsWorkspaceIdSelector? LogAnalyticsWorkspaceIdSelector { get; set; }

    /// <summary>The UUID which should be used for this Sentinel Automation Rule. Changing this forces a new Sentinel Automation Rule to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The order of this Sentinel Automation Rule. Possible values varies between 1 and 1000.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Specifies what triggers this automation rule. Possible values are Alerts and Incidents. Defaults to Incidents.</summary>
    [JsonPropertyName("triggersOn")]
    public string? TriggersOn { get; set; }

    /// <summary>Specifies when will this automation rule be triggered. Possible values are Created and Updated. Defaults to Created.</summary>
    [JsonPropertyName("triggersWhen")]
    public string? TriggersWhen { get; set; }
}

public enum V1beta1SentinelAutomationRuleSpecManagementPoliciesEnum
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

public enum V1beta1SentinelAutomationRuleSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SentinelAutomationRuleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SentinelAutomationRuleSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAutomationRuleSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1SentinelAutomationRuleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAutomationRuleSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1SentinelAutomationRuleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SentinelAutomationRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SentinelAutomationRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1SentinelAutomationRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SentinelAutomationRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SentinelAutomationRuleSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAutomationRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1SentinelAutomationRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAutomationRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1SentinelAutomationRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SentinelAutomationRuleSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SentinelAutomationRuleSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1SentinelAutomationRuleSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1SentinelAutomationRuleSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SentinelAutomationRuleSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SentinelAutomationRuleSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1SentinelAutomationRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1SentinelAutomationRuleSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAutomationRuleSpecDeletionPolicyEnum>))]
    public V1beta1SentinelAutomationRuleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SentinelAutomationRuleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SentinelAutomationRuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SentinelAutomationRuleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SentinelAutomationRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SentinelAutomationRuleSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SentinelAutomationRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1SentinelAutomationRuleStatusAtProviderActionIncident
{
    /// <summary>The classification of the incident, when closing it. Possible values are: BenignPositive_SuspiciousButExpected, FalsePositive_InaccurateData, FalsePositive_IncorrectAlertLogic, TruePositive_SuspiciousActivity and Undetermined.</summary>
    [JsonPropertyName("classification")]
    public string? Classification { get; set; }

    /// <summary>The comment why the incident is to be closed.</summary>
    [JsonPropertyName("classificationComment")]
    public string? ClassificationComment { get; set; }

    /// <summary>Specifies a list of labels to add to the incident.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>The execution order of this action.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>The object ID of the entity this incident is assigned to.</summary>
    [JsonPropertyName("ownerId")]
    public string? OwnerId { get; set; }

    /// <summary>The severity to add to the incident. Possible values are High, Informational, Low and Medium.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>The status to set to the incident. Possible values are: Active, Closed, New.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

public partial class V1beta1SentinelAutomationRuleStatusAtProviderActionPlaybook
{
    /// <summary>The ID of the Logic App that defines the playbook's logic.</summary>
    [JsonPropertyName("logicAppId")]
    public string? LogicAppId { get; set; }

    /// <summary>The execution order of this action.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>The ID of the Tenant that owns the playbook.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

public partial class V1beta1SentinelAutomationRuleStatusAtProviderCondition
{
    /// <summary>The operator to use for evaluate the condition. Possible values include: Equals, NotEquals, Contains, NotContains, StartsWith, NotStartsWith, EndsWith, NotEndsWith.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The property to use for evaluate the condition. Possible values are AccountAadTenantId, AccountAadUserId, AccountNTDomain, AccountName, AccountObjectGuid, AccountPUID, AccountSid, AccountUPNSuffix, AlertAnalyticRuleIds, AlertProductNames, AzureResourceResourceId, AzureResourceSubscriptionId, CloudApplicationAppId, CloudApplicationAppName, DNSDomainName, FileDirectory, FileHashValue, FileName, HostAzureID, HostNTDomain, HostName, HostNetBiosName, HostOSVersion, IPAddress, IncidentCustomDetailsKey, IncidentCustomDetailsValue, IncidentDescription, IncidentLabel, IncidentProviderName, IncidentRelatedAnalyticRuleIds, IncidentSeverity, IncidentStatus, IncidentTactics, IncidentTitle, IncidentUpdatedBySource, IoTDeviceId, IoTDeviceModel, IoTDeviceName, IoTDeviceOperatingSystem, IoTDeviceType, IoTDeviceVendor, MailMessageDeliveryAction, MailMessageDeliveryLocation, MailMessageP1Sender, MailMessageP2Sender, MailMessageRecipient, MailMessageSenderIP, MailMessageSubject, MailboxDisplayName, MailboxPrimaryAddress, MailboxUPN, MalwareCategory, MalwareName, ProcessCommandLine, ProcessId, RegistryKey, RegistryValueData and Url.</summary>
    [JsonPropertyName("property")]
    public string? Property { get; set; }

    /// <summary>Specifies a list of values to use for evaluate the condition.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

public partial class V1beta1SentinelAutomationRuleStatusAtProvider
{
    /// <summary>One or more action_incident blocks as defined below.</summary>
    [JsonPropertyName("actionIncident")]
    public IList<V1beta1SentinelAutomationRuleStatusAtProviderActionIncident>? ActionIncident { get; set; }

    /// <summary>One or more action_playbook blocks as defined below.</summary>
    [JsonPropertyName("actionPlaybook")]
    public IList<V1beta1SentinelAutomationRuleStatusAtProviderActionPlaybook>? ActionPlaybook { get; set; }

    /// <summary>One or more condition blocks as defined below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1SentinelAutomationRuleStatusAtProviderCondition>? Condition { get; set; }

    /// <summary>A JSON array of one or more condition JSON objects as is defined here.</summary>
    [JsonPropertyName("conditionJson")]
    public string? ConditionJson { get; set; }

    /// <summary>The display name which should be used for this Sentinel Automation Rule.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Whether this Sentinel Automation Rule is enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The time in RFC3339 format of kind UTC that determines when this Automation Rule should expire and be disabled.</summary>
    [JsonPropertyName("expiration")]
    public string? Expiration { get; set; }

    /// <summary>The ID of the Sentinel Automation Rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the Log Analytics Workspace where this Sentinel applies to. Changing this forces a new Sentinel Automation Rule to be created.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>The UUID which should be used for this Sentinel Automation Rule. Changing this forces a new Sentinel Automation Rule to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The order of this Sentinel Automation Rule. Possible values varies between 1 and 1000.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Specifies what triggers this automation rule. Possible values are Alerts and Incidents. Defaults to Incidents.</summary>
    [JsonPropertyName("triggersOn")]
    public string? TriggersOn { get; set; }

    /// <summary>Specifies when will this automation rule be triggered. Possible values are Created and Updated. Defaults to Created.</summary>
    [JsonPropertyName("triggersWhen")]
    public string? TriggersWhen { get; set; }
}

public partial class V1beta1SentinelAutomationRuleStatusConditions
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

public partial class V1beta1SentinelAutomationRuleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SentinelAutomationRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SentinelAutomationRuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SentinelAutomationRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SentinelAutomationRuleSpec>, IStatus<V1beta1SentinelAutomationRuleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SentinelAutomationRule";
    public const string KubeGroup = "securityinsights.azure.upbound.io";
    public const string KubePluralName = "sentinelautomationrules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SentinelAutomationRuleSpec defines the desired state of SentinelAutomationRule</summary>
    [JsonPropertyName("spec")]
    public V1beta1SentinelAutomationRuleSpec Spec { get; set; }

    /// <summary>SentinelAutomationRuleStatus defines the observed state of SentinelAutomationRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1SentinelAutomationRuleStatus? Status { get; set; }
}