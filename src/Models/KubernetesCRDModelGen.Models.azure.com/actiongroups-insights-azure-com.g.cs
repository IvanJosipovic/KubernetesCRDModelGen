using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.com;
/// <summary>Storage version of v1api20230101.ArmRoleReceiver An arm role receiver.</summary>
public partial class V1api20230101storageActionGroupSpecArmRoleReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("roleId")]
    public string? RoleId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>WebhookResourceReference: The resource id for webhook linked to this runbook.</summary>
public partial class V1api20230101storageActionGroupSpecAutomationRunbookReceiversWebhookResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230101.AutomationRunbookReceiver The Azure Automation Runbook notification receiver.</summary>
public partial class V1api20230101storageActionGroupSpecAutomationRunbookReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("automationAccountId")]
    public string? AutomationAccountId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isGlobalRunbook")]
    public bool? IsGlobalRunbook { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runbookName")]
    public string? RunbookName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }

    /// <summary>WebhookResourceReference: The resource id for webhook linked to this runbook.</summary>
    [JsonPropertyName("webhookResourceReference")]
    public V1api20230101storageActionGroupSpecAutomationRunbookReceiversWebhookResourceReference WebhookResourceReference { get; set; }
}

/// <summary>Storage version of v1api20230101.AzureAppPushReceiver The Azure mobile App push notification receiver.</summary>
public partial class V1api20230101storageActionGroupSpecAzureAppPushReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>FunctionAppResourceReference: The azure resource id of the function app.</summary>
public partial class V1api20230101storageActionGroupSpecAzureFunctionReceiversFunctionAppResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230101.AzureFunctionReceiver An azure function receiver.</summary>
public partial class V1api20230101storageActionGroupSpecAzureFunctionReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>FunctionAppResourceReference: The azure resource id of the function app.</summary>
    [JsonPropertyName("functionAppResourceReference")]
    public V1api20230101storageActionGroupSpecAzureFunctionReceiversFunctionAppResourceReference FunctionAppResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpTriggerUrl")]
    public string? HttpTriggerUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>Storage version of v1api20230101.EmailReceiver An email receiver.</summary>
public partial class V1api20230101storageActionGroupSpecEmailReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>Storage version of v1api20230101.EventHubReceiver An Event hub receiver.</summary>
public partial class V1api20230101storageActionGroupSpecEventHubReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventHubName")]
    public string? EventHubName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventHubNameSpace")]
    public string? EventHubNameSpace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>Storage version of v1api20230101.ItsmReceiver An Itsm receiver.</summary>
public partial class V1api20230101storageActionGroupSpecItsmReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ticketConfiguration")]
    public string? TicketConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>ResourceReference: The azure resource id of the logic app receiver.</summary>
public partial class V1api20230101storageActionGroupSpecLogicAppReceiversResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230101.LogicAppReceiver A logic app receiver.</summary>
public partial class V1api20230101storageActionGroupSpecLogicAppReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("callbackUrl")]
    public string? CallbackUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ResourceReference: The azure resource id of the logic app receiver.</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20230101storageActionGroupSpecLogicAppReceiversResourceReference ResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
public partial class V1api20230101storageActionGroupSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230101.SmsReceiver An SMS receiver.</summary>
public partial class V1api20230101storageActionGroupSpecSmsReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>Storage version of v1api20230101.VoiceReceiver A voice receiver.</summary>
public partial class V1api20230101storageActionGroupSpecVoiceReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>Storage version of v1api20230101.WebhookReceiver A webhook receiver.</summary>
public partial class V1api20230101storageActionGroupSpecWebhookReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identifierUri")]
    public string? IdentifierUri { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useAadAuth")]
    public bool? UseAadAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>Storage version of v1api20230101.ActionGroup_Spec</summary>
public partial class V1api20230101storageActionGroupSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("armRoleReceivers")]
    public IList<V1api20230101storageActionGroupSpecArmRoleReceivers>? ArmRoleReceivers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("automationRunbookReceivers")]
    public IList<V1api20230101storageActionGroupSpecAutomationRunbookReceivers>? AutomationRunbookReceivers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAppPushReceivers")]
    public IList<V1api20230101storageActionGroupSpecAzureAppPushReceivers>? AzureAppPushReceivers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureFunctionReceivers")]
    public IList<V1api20230101storageActionGroupSpecAzureFunctionReceivers>? AzureFunctionReceivers { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("emailReceivers")]
    public IList<V1api20230101storageActionGroupSpecEmailReceivers>? EmailReceivers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventHubReceivers")]
    public IList<V1api20230101storageActionGroupSpecEventHubReceivers>? EventHubReceivers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groupShortName")]
    public string? GroupShortName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("itsmReceivers")]
    public IList<V1api20230101storageActionGroupSpecItsmReceivers>? ItsmReceivers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logicAppReceivers")]
    public IList<V1api20230101storageActionGroupSpecLogicAppReceivers>? LogicAppReceivers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20230101storageActionGroupSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("smsReceivers")]
    public IList<V1api20230101storageActionGroupSpecSmsReceivers>? SmsReceivers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("voiceReceivers")]
    public IList<V1api20230101storageActionGroupSpecVoiceReceivers>? VoiceReceivers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("webhookReceivers")]
    public IList<V1api20230101storageActionGroupSpecWebhookReceivers>? WebhookReceivers { get; set; }
}

/// <summary>Storage version of v1api20230101.ArmRoleReceiver_STATUS An arm role receiver.</summary>
public partial class V1api20230101storageActionGroupStatusArmRoleReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("roleId")]
    public string? RoleId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>Storage version of v1api20230101.AutomationRunbookReceiver_STATUS The Azure Automation Runbook notification receiver.</summary>
public partial class V1api20230101storageActionGroupStatusAutomationRunbookReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("automationAccountId")]
    public string? AutomationAccountId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isGlobalRunbook")]
    public bool? IsGlobalRunbook { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runbookName")]
    public string? RunbookName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }

    /// <summary></summary>
    [JsonPropertyName("webhookResourceId")]
    public string? WebhookResourceId { get; set; }
}

/// <summary>Storage version of v1api20230101.AzureAppPushReceiver_STATUS The Azure mobile App push notification receiver.</summary>
public partial class V1api20230101storageActionGroupStatusAzureAppPushReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230101.AzureFunctionReceiver_STATUS An azure function receiver.</summary>
public partial class V1api20230101storageActionGroupStatusAzureFunctionReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("functionAppResourceId")]
    public string? FunctionAppResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpTriggerUrl")]
    public string? HttpTriggerUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
public partial class V1api20230101storageActionGroupStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason for the condition's last transition. Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False. This is omitted in all cases when Status == Unknown</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Storage version of v1api20230101.EmailReceiver_STATUS An email receiver.</summary>
public partial class V1api20230101storageActionGroupStatusEmailReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>Storage version of v1api20230101.EventHubReceiver_STATUS An Event hub receiver.</summary>
public partial class V1api20230101storageActionGroupStatusEventHubReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventHubName")]
    public string? EventHubName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventHubNameSpace")]
    public string? EventHubNameSpace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>Storage version of v1api20230101.ItsmReceiver_STATUS An Itsm receiver.</summary>
public partial class V1api20230101storageActionGroupStatusItsmReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ticketConfiguration")]
    public string? TicketConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>Storage version of v1api20230101.LogicAppReceiver_STATUS A logic app receiver.</summary>
public partial class V1api20230101storageActionGroupStatusLogicAppReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("callbackUrl")]
    public string? CallbackUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>Storage version of v1api20230101.SmsReceiver_STATUS An SMS receiver.</summary>
public partial class V1api20230101storageActionGroupStatusSmsReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Storage version of v1api20230101.VoiceReceiver_STATUS A voice receiver.</summary>
public partial class V1api20230101storageActionGroupStatusVoiceReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>Storage version of v1api20230101.WebhookReceiver_STATUS A webhook receiver.</summary>
public partial class V1api20230101storageActionGroupStatusWebhookReceivers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identifierUri")]
    public string? IdentifierUri { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useAadAuth")]
    public bool? UseAadAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>Storage version of v1api20230101.ActionGroupResource_STATUS An action group resource.</summary>
public partial class V1api20230101storageActionGroupStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("armRoleReceivers")]
    public IList<V1api20230101storageActionGroupStatusArmRoleReceivers>? ArmRoleReceivers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("automationRunbookReceivers")]
    public IList<V1api20230101storageActionGroupStatusAutomationRunbookReceivers>? AutomationRunbookReceivers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAppPushReceivers")]
    public IList<V1api20230101storageActionGroupStatusAzureAppPushReceivers>? AzureAppPushReceivers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureFunctionReceivers")]
    public IList<V1api20230101storageActionGroupStatusAzureFunctionReceivers>? AzureFunctionReceivers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230101storageActionGroupStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("emailReceivers")]
    public IList<V1api20230101storageActionGroupStatusEmailReceivers>? EmailReceivers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventHubReceivers")]
    public IList<V1api20230101storageActionGroupStatusEventHubReceivers>? EventHubReceivers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groupShortName")]
    public string? GroupShortName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("itsmReceivers")]
    public IList<V1api20230101storageActionGroupStatusItsmReceivers>? ItsmReceivers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logicAppReceivers")]
    public IList<V1api20230101storageActionGroupStatusLogicAppReceivers>? LogicAppReceivers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("smsReceivers")]
    public IList<V1api20230101storageActionGroupStatusSmsReceivers>? SmsReceivers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("voiceReceivers")]
    public IList<V1api20230101storageActionGroupStatusVoiceReceivers>? VoiceReceivers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("webhookReceivers")]
    public IList<V1api20230101storageActionGroupStatusWebhookReceivers>? WebhookReceivers { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Storage version of v1api20230101.ActionGroup Generator information: - Generated from: /monitor/resource-manager/Microsoft.Insights/stable/2023-01-01/actionGroups_API.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/actionGroups/{actionGroupName}</summary>
public partial class V1api20230101storageActionGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230101storageActionGroupSpec>, IStatus<V1api20230101storageActionGroupStatus>
{
    public const string KubeApiVersion = "v1api20230101storage";
    public const string KubeKind = "ActionGroup";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "actiongroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20230101.ActionGroup_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20230101storageActionGroupSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20230101.ActionGroupResource_STATUS An action group resource.</summary>
    [JsonPropertyName("status")]
    public V1api20230101storageActionGroupStatus? Status { get; set; }
}