using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dialogflowcx.cnrm.cloud.google.com;
/// <summary>Configuration for a generic web service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXWebhookSpecGenericWebService
{
    /// <summary>Specifies a list of allowed custom CA certificates (in DER format) for HTTPS verification.</summary>
    [JsonPropertyName("allowedCaCerts")]
    public IList<string>? AllowedCaCerts { get; set; }

    /// <summary>Immutable. The HTTP request headers to send together with webhook requests.</summary>
    [JsonPropertyName("requestHeaders")]
    public IDictionary<string, string>? RequestHeaders { get; set; }

    /// <summary>Whether to use speech adaptation for speech recognition.</summary>
    [JsonPropertyName("uri")]
    public string Uri { get; set; }
}

/// <summary>The name of Service Directory service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXWebhookSpecServiceDirectoryGenericWebService
{
    /// <summary>Specifies a list of allowed custom CA certificates (in DER format) for HTTPS verification.</summary>
    [JsonPropertyName("allowedCaCerts")]
    public IList<string>? AllowedCaCerts { get; set; }

    /// <summary>Immutable. The HTTP request headers to send together with webhook requests.</summary>
    [JsonPropertyName("requestHeaders")]
    public IDictionary<string, string>? RequestHeaders { get; set; }

    /// <summary>Whether to use speech adaptation for speech recognition.</summary>
    [JsonPropertyName("uri")]
    public string Uri { get; set; }
}

/// <summary>Configuration for a Service Directory service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXWebhookSpecServiceDirectory
{
    /// <summary>The name of Service Directory service.</summary>
    [JsonPropertyName("genericWebService")]
    public V1alpha1DialogflowCXWebhookSpecServiceDirectoryGenericWebService GenericWebService { get; set; }

    /// <summary>The name of Service Directory service.</summary>
    [JsonPropertyName("service")]
    public string Service { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXWebhookSpec
{
    /// <summary>Indicates whether the webhook is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The human-readable name of the webhook, unique within the agent.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>Indicates if automatic spell correction is enabled in detect intent requests.</summary>
    [JsonPropertyName("enableSpellCorrection")]
    public bool? EnableSpellCorrection { get; set; }

    /// <summary>Determines whether this agent should log conversation queries.</summary>
    [JsonPropertyName("enableStackdriverLogging")]
    public bool? EnableStackdriverLogging { get; set; }

    /// <summary>Configuration for a generic web service.</summary>
    [JsonPropertyName("genericWebService")]
    public V1alpha1DialogflowCXWebhookSpecGenericWebService? GenericWebService { get; set; }

    /// <summary>Immutable. The agent to create a webhook for. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Name of the SecuritySettings reference for the agent. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/securitySettings/&lt;Security Settings ID&gt;.</summary>
    [JsonPropertyName("securitySettings")]
    public string? SecuritySettings { get; set; }

    /// <summary>Configuration for a Service Directory service.</summary>
    [JsonPropertyName("serviceDirectory")]
    public V1alpha1DialogflowCXWebhookSpecServiceDirectory? ServiceDirectory { get; set; }

    /// <summary>Webhook execution timeout.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXWebhookStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXWebhookStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DialogflowCXWebhookStatusConditions>? Conditions { get; set; }

    /// <summary>The unique identifier of the webhook. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/webhooks/&lt;Webhook ID&gt;.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Name of the start flow in this agent. A start flow will be automatically created when the agent is created, and can only be deleted by deleting the agent. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/flows/&lt;Flow ID&gt;.</summary>
    [JsonPropertyName("startFlow")]
    public string? StartFlow { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DialogflowCXWebhook : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DialogflowCXWebhookSpec>, IStatus<V1alpha1DialogflowCXWebhookStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DialogflowCXWebhook";
    public const string KubeGroup = "dialogflowcx.cnrm.cloud.google.com";
    public const string KubePluralName = "dialogflowcxwebhooks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1DialogflowCXWebhookSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1DialogflowCXWebhookStatus? Status { get; set; }
}