using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecForProviderArmRoleReceiver
{
    /// <summary>The name of the ARM role receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The arm role id.</summary>
    [JsonPropertyName("roleId")]
    public string? RoleId { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecForProviderAutomationRunbookReceiver
{
    /// <summary>The automation account ID which holds this runbook and authenticates to Azure resources.</summary>
    [JsonPropertyName("automationAccountId")]
    public string? AutomationAccountId { get; set; }

    /// <summary>Indicates whether this instance is global runbook.</summary>
    [JsonPropertyName("isGlobalRunbook")]
    public bool? IsGlobalRunbook { get; set; }

    /// <summary>The name of the automation runbook receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name for this runbook.</summary>
    [JsonPropertyName("runbookName")]
    public string? RunbookName { get; set; }

    /// <summary>The URI where webhooks should be sent.</summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }

    /// <summary>The resource id for webhook linked to this runbook.</summary>
    [JsonPropertyName("webhookResourceId")]
    public string? WebhookResourceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecForProviderAzureAppPushReceiver
{
    /// <summary>The email address of the user signed into the mobile app who will receive push notifications from this receiver.</summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary>The name of the Azure app push receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecForProviderAzureFunctionReceiver
{
    /// <summary>The Azure resource ID of the function app.</summary>
    [JsonPropertyName("functionAppResourceId")]
    public string? FunctionAppResourceId { get; set; }

    /// <summary>The function name in the function app.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>The HTTP trigger url where HTTP request sent to.</summary>
    [JsonPropertyName("httpTriggerUrl")]
    public string? HttpTriggerUrl { get; set; }

    /// <summary>The name of the Azure Function receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecForProviderEmailReceiver
{
    /// <summary>The email address of this receiver.</summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary>The name of the email receiver. Names must be unique (case-insensitive) across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecForProviderEventHubReceiver
{
    /// <summary>The name of the specific Event Hub queue.</summary>
    [JsonPropertyName("eventHubName")]
    public string? EventHubName { get; set; }

    /// <summary>The namespace name of the Event Hub.</summary>
    [JsonPropertyName("eventHubNamespace")]
    public string? EventHubNamespace { get; set; }

    /// <summary>The name of the EventHub Receiver, must be unique within action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID for the subscription containing this Event Hub. Default to the subscription ID of the Action Group.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>The Tenant ID for the subscription containing this Event Hub.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Indicates whether to use common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecForProviderItsmReceiver
{
    /// <summary>The unique connection identifier of the ITSM connection.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>The name of the ITSM receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The region of the workspace.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>A JSON blob for the configurations of the ITSM action. CreateMultipleWorkItems option will be part of this blob as well.</summary>
    [JsonPropertyName("ticketConfiguration")]
    public string? TicketConfiguration { get; set; }

    /// <summary>The Azure Log Analytics workspace ID where this connection is defined. Format is &lt;subscription id&gt;|&lt;workspace id&gt;, for example 00000000-0000-0000-0000-000000000000|00000000-0000-0000-0000-000000000000.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecForProviderLogicAppReceiver
{
    /// <summary>The callback url where HTTP request sent to.</summary>
    [JsonPropertyName("callbackUrl")]
    public string? CallbackUrl { get; set; }

    /// <summary>The name of the logic app receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Azure resource ID of the logic app.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActionGroupSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActionGroupSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecForProviderSmsReceiver
{
    /// <summary>The country code of the SMS receiver.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>The name of the SMS receiver. Names must be unique (case-insensitive) across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The phone number of the SMS receiver.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecForProviderVoiceReceiver
{
    /// <summary>The country code of the voice receiver.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>The name of the voice receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The phone number of the voice receiver.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecForProviderWebhookReceiverAadAuth
{
    /// <summary>The identifier URI for AAD auth.</summary>
    [JsonPropertyName("identifierUri")]
    public string? IdentifierUri { get; set; }

    /// <summary>The webhook application object Id for AAD auth.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The tenant id for AAD auth.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecForProviderWebhookReceiver
{
    /// <summary>The aad_auth block as defined below.</summary>
    [JsonPropertyName("aadAuth")]
    public IList<V1beta1MonitorActionGroupSpecForProviderWebhookReceiverAadAuth>? AadAuth { get; set; }

    /// <summary>The name of the webhook receiver. Names must be unique (case-insensitive) across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The URI where webhooks should be sent.</summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecForProvider
{
    /// <summary>One or more arm_role_receiver blocks as defined below.</summary>
    [JsonPropertyName("armRoleReceiver")]
    public IList<V1beta1MonitorActionGroupSpecForProviderArmRoleReceiver>? ArmRoleReceiver { get; set; }

    /// <summary>One or more automation_runbook_receiver blocks as defined below.</summary>
    [JsonPropertyName("automationRunbookReceiver")]
    public IList<V1beta1MonitorActionGroupSpecForProviderAutomationRunbookReceiver>? AutomationRunbookReceiver { get; set; }

    /// <summary>One or more azure_app_push_receiver blocks as defined below.</summary>
    [JsonPropertyName("azureAppPushReceiver")]
    public IList<V1beta1MonitorActionGroupSpecForProviderAzureAppPushReceiver>? AzureAppPushReceiver { get; set; }

    /// <summary>One or more azure_function_receiver blocks as defined below.</summary>
    [JsonPropertyName("azureFunctionReceiver")]
    public IList<V1beta1MonitorActionGroupSpecForProviderAzureFunctionReceiver>? AzureFunctionReceiver { get; set; }

    /// <summary>One or more email_receiver blocks as defined below.</summary>
    [JsonPropertyName("emailReceiver")]
    public IList<V1beta1MonitorActionGroupSpecForProviderEmailReceiver>? EmailReceiver { get; set; }

    /// <summary>Whether this action group is enabled. If an action group is not enabled, then none of its receivers will receive communications. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more event_hub_receiver blocks as defined below.</summary>
    [JsonPropertyName("eventHubReceiver")]
    public IList<V1beta1MonitorActionGroupSpecForProviderEventHubReceiver>? EventHubReceiver { get; set; }

    /// <summary>One or more itsm_receiver blocks as defined below.</summary>
    [JsonPropertyName("itsmReceiver")]
    public IList<V1beta1MonitorActionGroupSpecForProviderItsmReceiver>? ItsmReceiver { get; set; }

    /// <summary>The Azure Region where the Action Group should exist. Changing this forces a new Action Group to be created. Defaults to global.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more logic_app_receiver blocks as defined below.</summary>
    [JsonPropertyName("logicAppReceiver")]
    public IList<V1beta1MonitorActionGroupSpecForProviderLogicAppReceiver>? LogicAppReceiver { get; set; }

    /// <summary>The name of the resource group in which to create the Action Group instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1MonitorActionGroupSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1MonitorActionGroupSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The short name of the action group. This will be used in SMS messages.</summary>
    [JsonPropertyName("shortName")]
    public string? ShortName { get; set; }

    /// <summary>One or more sms_receiver blocks as defined below.</summary>
    [JsonPropertyName("smsReceiver")]
    public IList<V1beta1MonitorActionGroupSpecForProviderSmsReceiver>? SmsReceiver { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more voice_receiver blocks as defined below.</summary>
    [JsonPropertyName("voiceReceiver")]
    public IList<V1beta1MonitorActionGroupSpecForProviderVoiceReceiver>? VoiceReceiver { get; set; }

    /// <summary>One or more webhook_receiver blocks as defined below.</summary>
    [JsonPropertyName("webhookReceiver")]
    public IList<V1beta1MonitorActionGroupSpecForProviderWebhookReceiver>? WebhookReceiver { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecInitProviderArmRoleReceiver
{
    /// <summary>The name of the ARM role receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The arm role id.</summary>
    [JsonPropertyName("roleId")]
    public string? RoleId { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecInitProviderAutomationRunbookReceiver
{
    /// <summary>The automation account ID which holds this runbook and authenticates to Azure resources.</summary>
    [JsonPropertyName("automationAccountId")]
    public string? AutomationAccountId { get; set; }

    /// <summary>Indicates whether this instance is global runbook.</summary>
    [JsonPropertyName("isGlobalRunbook")]
    public bool? IsGlobalRunbook { get; set; }

    /// <summary>The name of the automation runbook receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name for this runbook.</summary>
    [JsonPropertyName("runbookName")]
    public string? RunbookName { get; set; }

    /// <summary>The URI where webhooks should be sent.</summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }

    /// <summary>The resource id for webhook linked to this runbook.</summary>
    [JsonPropertyName("webhookResourceId")]
    public string? WebhookResourceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecInitProviderAzureAppPushReceiver
{
    /// <summary>The email address of the user signed into the mobile app who will receive push notifications from this receiver.</summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary>The name of the Azure app push receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecInitProviderAzureFunctionReceiver
{
    /// <summary>The Azure resource ID of the function app.</summary>
    [JsonPropertyName("functionAppResourceId")]
    public string? FunctionAppResourceId { get; set; }

    /// <summary>The function name in the function app.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>The HTTP trigger url where HTTP request sent to.</summary>
    [JsonPropertyName("httpTriggerUrl")]
    public string? HttpTriggerUrl { get; set; }

    /// <summary>The name of the Azure Function receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecInitProviderEmailReceiver
{
    /// <summary>The email address of this receiver.</summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary>The name of the email receiver. Names must be unique (case-insensitive) across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecInitProviderEventHubReceiver
{
    /// <summary>The name of the specific Event Hub queue.</summary>
    [JsonPropertyName("eventHubName")]
    public string? EventHubName { get; set; }

    /// <summary>The namespace name of the Event Hub.</summary>
    [JsonPropertyName("eventHubNamespace")]
    public string? EventHubNamespace { get; set; }

    /// <summary>The name of the EventHub Receiver, must be unique within action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID for the subscription containing this Event Hub. Default to the subscription ID of the Action Group.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>The Tenant ID for the subscription containing this Event Hub.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Indicates whether to use common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecInitProviderItsmReceiver
{
    /// <summary>The unique connection identifier of the ITSM connection.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>The name of the ITSM receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The region of the workspace.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>A JSON blob for the configurations of the ITSM action. CreateMultipleWorkItems option will be part of this blob as well.</summary>
    [JsonPropertyName("ticketConfiguration")]
    public string? TicketConfiguration { get; set; }

    /// <summary>The Azure Log Analytics workspace ID where this connection is defined. Format is &lt;subscription id&gt;|&lt;workspace id&gt;, for example 00000000-0000-0000-0000-000000000000|00000000-0000-0000-0000-000000000000.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecInitProviderLogicAppReceiver
{
    /// <summary>The callback url where HTTP request sent to.</summary>
    [JsonPropertyName("callbackUrl")]
    public string? CallbackUrl { get; set; }

    /// <summary>The name of the logic app receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Azure resource ID of the logic app.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecInitProviderSmsReceiver
{
    /// <summary>The country code of the SMS receiver.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>The name of the SMS receiver. Names must be unique (case-insensitive) across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The phone number of the SMS receiver.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecInitProviderVoiceReceiver
{
    /// <summary>The country code of the voice receiver.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>The name of the voice receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The phone number of the voice receiver.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecInitProviderWebhookReceiverAadAuth
{
    /// <summary>The identifier URI for AAD auth.</summary>
    [JsonPropertyName("identifierUri")]
    public string? IdentifierUri { get; set; }

    /// <summary>The webhook application object Id for AAD auth.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The tenant id for AAD auth.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecInitProviderWebhookReceiver
{
    /// <summary>The aad_auth block as defined below.</summary>
    [JsonPropertyName("aadAuth")]
    public IList<V1beta1MonitorActionGroupSpecInitProviderWebhookReceiverAadAuth>? AadAuth { get; set; }

    /// <summary>The name of the webhook receiver. Names must be unique (case-insensitive) across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The URI where webhooks should be sent.</summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecInitProvider
{
    /// <summary>One or more arm_role_receiver blocks as defined below.</summary>
    [JsonPropertyName("armRoleReceiver")]
    public IList<V1beta1MonitorActionGroupSpecInitProviderArmRoleReceiver>? ArmRoleReceiver { get; set; }

    /// <summary>One or more automation_runbook_receiver blocks as defined below.</summary>
    [JsonPropertyName("automationRunbookReceiver")]
    public IList<V1beta1MonitorActionGroupSpecInitProviderAutomationRunbookReceiver>? AutomationRunbookReceiver { get; set; }

    /// <summary>One or more azure_app_push_receiver blocks as defined below.</summary>
    [JsonPropertyName("azureAppPushReceiver")]
    public IList<V1beta1MonitorActionGroupSpecInitProviderAzureAppPushReceiver>? AzureAppPushReceiver { get; set; }

    /// <summary>One or more azure_function_receiver blocks as defined below.</summary>
    [JsonPropertyName("azureFunctionReceiver")]
    public IList<V1beta1MonitorActionGroupSpecInitProviderAzureFunctionReceiver>? AzureFunctionReceiver { get; set; }

    /// <summary>One or more email_receiver blocks as defined below.</summary>
    [JsonPropertyName("emailReceiver")]
    public IList<V1beta1MonitorActionGroupSpecInitProviderEmailReceiver>? EmailReceiver { get; set; }

    /// <summary>Whether this action group is enabled. If an action group is not enabled, then none of its receivers will receive communications. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more event_hub_receiver blocks as defined below.</summary>
    [JsonPropertyName("eventHubReceiver")]
    public IList<V1beta1MonitorActionGroupSpecInitProviderEventHubReceiver>? EventHubReceiver { get; set; }

    /// <summary>One or more itsm_receiver blocks as defined below.</summary>
    [JsonPropertyName("itsmReceiver")]
    public IList<V1beta1MonitorActionGroupSpecInitProviderItsmReceiver>? ItsmReceiver { get; set; }

    /// <summary>The Azure Region where the Action Group should exist. Changing this forces a new Action Group to be created. Defaults to global.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more logic_app_receiver blocks as defined below.</summary>
    [JsonPropertyName("logicAppReceiver")]
    public IList<V1beta1MonitorActionGroupSpecInitProviderLogicAppReceiver>? LogicAppReceiver { get; set; }

    /// <summary>The short name of the action group. This will be used in SMS messages.</summary>
    [JsonPropertyName("shortName")]
    public string? ShortName { get; set; }

    /// <summary>One or more sms_receiver blocks as defined below.</summary>
    [JsonPropertyName("smsReceiver")]
    public IList<V1beta1MonitorActionGroupSpecInitProviderSmsReceiver>? SmsReceiver { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more voice_receiver blocks as defined below.</summary>
    [JsonPropertyName("voiceReceiver")]
    public IList<V1beta1MonitorActionGroupSpecInitProviderVoiceReceiver>? VoiceReceiver { get; set; }

    /// <summary>One or more webhook_receiver blocks as defined below.</summary>
    [JsonPropertyName("webhookReceiver")]
    public IList<V1beta1MonitorActionGroupSpecInitProviderWebhookReceiver>? WebhookReceiver { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecProviderConfigRefPolicy
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
public partial class V1beta1MonitorActionGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActionGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>MonitorActionGroupSpec defines the desired state of MonitorActionGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MonitorActionGroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MonitorActionGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MonitorActionGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MonitorActionGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupStatusAtProviderArmRoleReceiver
{
    /// <summary>The name of the ARM role receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The arm role id.</summary>
    [JsonPropertyName("roleId")]
    public string? RoleId { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupStatusAtProviderAutomationRunbookReceiver
{
    /// <summary>The automation account ID which holds this runbook and authenticates to Azure resources.</summary>
    [JsonPropertyName("automationAccountId")]
    public string? AutomationAccountId { get; set; }

    /// <summary>Indicates whether this instance is global runbook.</summary>
    [JsonPropertyName("isGlobalRunbook")]
    public bool? IsGlobalRunbook { get; set; }

    /// <summary>The name of the automation runbook receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name for this runbook.</summary>
    [JsonPropertyName("runbookName")]
    public string? RunbookName { get; set; }

    /// <summary>The URI where webhooks should be sent.</summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }

    /// <summary>The resource id for webhook linked to this runbook.</summary>
    [JsonPropertyName("webhookResourceId")]
    public string? WebhookResourceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupStatusAtProviderAzureAppPushReceiver
{
    /// <summary>The email address of the user signed into the mobile app who will receive push notifications from this receiver.</summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary>The name of the Azure app push receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupStatusAtProviderAzureFunctionReceiver
{
    /// <summary>The Azure resource ID of the function app.</summary>
    [JsonPropertyName("functionAppResourceId")]
    public string? FunctionAppResourceId { get; set; }

    /// <summary>The function name in the function app.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>The HTTP trigger url where HTTP request sent to.</summary>
    [JsonPropertyName("httpTriggerUrl")]
    public string? HttpTriggerUrl { get; set; }

    /// <summary>The name of the Azure Function receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupStatusAtProviderEmailReceiver
{
    /// <summary>The email address of this receiver.</summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary>The name of the email receiver. Names must be unique (case-insensitive) across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupStatusAtProviderEventHubReceiver
{
    /// <summary>The name of the specific Event Hub queue.</summary>
    [JsonPropertyName("eventHubName")]
    public string? EventHubName { get; set; }

    /// <summary>The namespace name of the Event Hub.</summary>
    [JsonPropertyName("eventHubNamespace")]
    public string? EventHubNamespace { get; set; }

    /// <summary>The name of the EventHub Receiver, must be unique within action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID for the subscription containing this Event Hub. Default to the subscription ID of the Action Group.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>The Tenant ID for the subscription containing this Event Hub.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Indicates whether to use common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupStatusAtProviderItsmReceiver
{
    /// <summary>The unique connection identifier of the ITSM connection.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>The name of the ITSM receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The region of the workspace.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>A JSON blob for the configurations of the ITSM action. CreateMultipleWorkItems option will be part of this blob as well.</summary>
    [JsonPropertyName("ticketConfiguration")]
    public string? TicketConfiguration { get; set; }

    /// <summary>The Azure Log Analytics workspace ID where this connection is defined. Format is &lt;subscription id&gt;|&lt;workspace id&gt;, for example 00000000-0000-0000-0000-000000000000|00000000-0000-0000-0000-000000000000.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupStatusAtProviderLogicAppReceiver
{
    /// <summary>The callback url where HTTP request sent to.</summary>
    [JsonPropertyName("callbackUrl")]
    public string? CallbackUrl { get; set; }

    /// <summary>The name of the logic app receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Azure resource ID of the logic app.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupStatusAtProviderSmsReceiver
{
    /// <summary>The country code of the SMS receiver.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>The name of the SMS receiver. Names must be unique (case-insensitive) across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The phone number of the SMS receiver.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupStatusAtProviderVoiceReceiver
{
    /// <summary>The country code of the voice receiver.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>The name of the voice receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The phone number of the voice receiver.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupStatusAtProviderWebhookReceiverAadAuth
{
    /// <summary>The identifier URI for AAD auth.</summary>
    [JsonPropertyName("identifierUri")]
    public string? IdentifierUri { get; set; }

    /// <summary>The webhook application object Id for AAD auth.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The tenant id for AAD auth.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupStatusAtProviderWebhookReceiver
{
    /// <summary>The aad_auth block as defined below.</summary>
    [JsonPropertyName("aadAuth")]
    public IList<V1beta1MonitorActionGroupStatusAtProviderWebhookReceiverAadAuth>? AadAuth { get; set; }

    /// <summary>The name of the webhook receiver. Names must be unique (case-insensitive) across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The URI where webhooks should be sent.</summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupStatusAtProvider
{
    /// <summary>One or more arm_role_receiver blocks as defined below.</summary>
    [JsonPropertyName("armRoleReceiver")]
    public IList<V1beta1MonitorActionGroupStatusAtProviderArmRoleReceiver>? ArmRoleReceiver { get; set; }

    /// <summary>One or more automation_runbook_receiver blocks as defined below.</summary>
    [JsonPropertyName("automationRunbookReceiver")]
    public IList<V1beta1MonitorActionGroupStatusAtProviderAutomationRunbookReceiver>? AutomationRunbookReceiver { get; set; }

    /// <summary>One or more azure_app_push_receiver blocks as defined below.</summary>
    [JsonPropertyName("azureAppPushReceiver")]
    public IList<V1beta1MonitorActionGroupStatusAtProviderAzureAppPushReceiver>? AzureAppPushReceiver { get; set; }

    /// <summary>One or more azure_function_receiver blocks as defined below.</summary>
    [JsonPropertyName("azureFunctionReceiver")]
    public IList<V1beta1MonitorActionGroupStatusAtProviderAzureFunctionReceiver>? AzureFunctionReceiver { get; set; }

    /// <summary>One or more email_receiver blocks as defined below.</summary>
    [JsonPropertyName("emailReceiver")]
    public IList<V1beta1MonitorActionGroupStatusAtProviderEmailReceiver>? EmailReceiver { get; set; }

    /// <summary>Whether this action group is enabled. If an action group is not enabled, then none of its receivers will receive communications. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more event_hub_receiver blocks as defined below.</summary>
    [JsonPropertyName("eventHubReceiver")]
    public IList<V1beta1MonitorActionGroupStatusAtProviderEventHubReceiver>? EventHubReceiver { get; set; }

    /// <summary>The ID of the Action Group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>One or more itsm_receiver blocks as defined below.</summary>
    [JsonPropertyName("itsmReceiver")]
    public IList<V1beta1MonitorActionGroupStatusAtProviderItsmReceiver>? ItsmReceiver { get; set; }

    /// <summary>The Azure Region where the Action Group should exist. Changing this forces a new Action Group to be created. Defaults to global.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more logic_app_receiver blocks as defined below.</summary>
    [JsonPropertyName("logicAppReceiver")]
    public IList<V1beta1MonitorActionGroupStatusAtProviderLogicAppReceiver>? LogicAppReceiver { get; set; }

    /// <summary>The name of the resource group in which to create the Action Group instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The short name of the action group. This will be used in SMS messages.</summary>
    [JsonPropertyName("shortName")]
    public string? ShortName { get; set; }

    /// <summary>One or more sms_receiver blocks as defined below.</summary>
    [JsonPropertyName("smsReceiver")]
    public IList<V1beta1MonitorActionGroupStatusAtProviderSmsReceiver>? SmsReceiver { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more voice_receiver blocks as defined below.</summary>
    [JsonPropertyName("voiceReceiver")]
    public IList<V1beta1MonitorActionGroupStatusAtProviderVoiceReceiver>? VoiceReceiver { get; set; }

    /// <summary>One or more webhook_receiver blocks as defined below.</summary>
    [JsonPropertyName("webhookReceiver")]
    public IList<V1beta1MonitorActionGroupStatusAtProviderWebhookReceiver>? WebhookReceiver { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupStatusConditions
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

/// <summary>MonitorActionGroupStatus defines the observed state of MonitorActionGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionGroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MonitorActionGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MonitorActionGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MonitorActionGroup is the Schema for the MonitorActionGroups API. Manages an Action Group within Azure Monitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitorActionGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MonitorActionGroupSpec>, IStatus<V1beta1MonitorActionGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitorActionGroup";
    public const string KubeGroup = "insights.azure.upbound.io";
    public const string KubePluralName = "monitoractiongroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MonitorActionGroupSpec defines the desired state of MonitorActionGroup</summary>
    [JsonPropertyName("spec")]
    public V1beta1MonitorActionGroupSpec Spec { get; set; }

    /// <summary>MonitorActionGroupStatus defines the observed state of MonitorActionGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1MonitorActionGroupStatus? Status { get; set; }
}

/// <summary>MonitorActionGroup is the Schema for the MonitorActionGroups API. Manages an Action Group within Azure Monitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitorActionGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MonitorActionGroup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitorActionGroupList";
    public const string KubeGroup = "insights.azure.upbound.io";
    public const string KubePluralName = "monitoractiongroups";
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
    public IList<V1beta1MonitorActionGroup> Items { get; set; }
}