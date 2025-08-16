using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.logic.azure.m.upbound.io;
/// <summary>AppActionHTTP is the Schema for the AppActionHTTPs API. Manages an HTTP Action within a Logic App Workflow</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AppActionHTTPList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AppActionHTTP>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AppActionHTTPList";
    public const string KubeGroup = "logic.azure.m.upbound.io";
    public const string KubePluralName = "appactionhttps";
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
    public IList<V1beta1AppActionHTTP> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppActionHTTPSpecForProviderLogicAppIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a AppWorkflow in logic to populate logicAppId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppActionHTTPSpecForProviderLogicAppIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppActionHTTPSpecForProviderLogicAppIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppActionHTTPSpecForProviderLogicAppIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a AppWorkflow in logic to populate logicAppId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppActionHTTPSpecForProviderLogicAppIdSelector
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
    public V1beta1AppActionHTTPSpecForProviderLogicAppIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppActionHTTPSpecForProviderRunAfter
{
    /// <summary>Specifies the name of the precedent HTTP Action.</summary>
    [JsonPropertyName("actionName")]
    public string? ActionName { get; set; }

    /// <summary>Specifies the expected result of the precedent HTTP Action, only after which the current HTTP Action will be triggered. Possible values include Succeeded, Failed, Skipped and TimedOut.</summary>
    [JsonPropertyName("actionResult")]
    public string? ActionResult { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppActionHTTPSpecForProvider
{
    /// <summary>Specifies the HTTP Body that should be sent to the uri when this HTTP Action is triggered.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Specifies a Map of Key-Value Pairs that should be sent to the uri when this HTTP Action is triggered.</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>Specifies the ID of the Logic App Workflow. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("logicAppId")]
    public string? LogicAppId { get; set; }

    /// <summary>Reference to a AppWorkflow in logic to populate logicAppId.</summary>
    [JsonPropertyName("logicAppIdRef")]
    public V1beta1AppActionHTTPSpecForProviderLogicAppIdRef? LogicAppIdRef { get; set; }

    /// <summary>Selector for a AppWorkflow in logic to populate logicAppId.</summary>
    [JsonPropertyName("logicAppIdSelector")]
    public V1beta1AppActionHTTPSpecForProviderLogicAppIdSelector? LogicAppIdSelector { get; set; }

    /// <summary>Specifies the HTTP Method which should be used for this HTTP Action. Possible values include DELETE, GET, PATCH, POST and PUT.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Specifies a Map of Key-Value Pairs that should be sent to the uri when this HTTP Action is triggered.</summary>
    [JsonPropertyName("queries")]
    public IDictionary<string, string>? Queries { get; set; }

    /// <summary>Specifies the place of the HTTP Action in the Logic App Workflow. If not specified, the HTTP Action is right after the Trigger. A run_after block is as defined below.</summary>
    [JsonPropertyName("runAfter")]
    public IList<V1beta1AppActionHTTPSpecForProviderRunAfter>? RunAfter { get; set; }

    /// <summary>Specifies the URI which will be called when this HTTP Action is triggered.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppActionHTTPSpecInitProviderRunAfter
{
    /// <summary>Specifies the name of the precedent HTTP Action.</summary>
    [JsonPropertyName("actionName")]
    public string? ActionName { get; set; }

    /// <summary>Specifies the expected result of the precedent HTTP Action, only after which the current HTTP Action will be triggered. Possible values include Succeeded, Failed, Skipped and TimedOut.</summary>
    [JsonPropertyName("actionResult")]
    public string? ActionResult { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppActionHTTPSpecInitProvider
{
    /// <summary>Specifies the HTTP Body that should be sent to the uri when this HTTP Action is triggered.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Specifies a Map of Key-Value Pairs that should be sent to the uri when this HTTP Action is triggered.</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>Specifies the HTTP Method which should be used for this HTTP Action. Possible values include DELETE, GET, PATCH, POST and PUT.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Specifies a Map of Key-Value Pairs that should be sent to the uri when this HTTP Action is triggered.</summary>
    [JsonPropertyName("queries")]
    public IDictionary<string, string>? Queries { get; set; }

    /// <summary>Specifies the place of the HTTP Action in the Logic App Workflow. If not specified, the HTTP Action is right after the Trigger. A run_after block is as defined below.</summary>
    [JsonPropertyName("runAfter")]
    public IList<V1beta1AppActionHTTPSpecInitProviderRunAfter>? RunAfter { get; set; }

    /// <summary>Specifies the URI which will be called when this HTTP Action is triggered.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppActionHTTPSpecProviderConfigRef
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
public partial class V1beta1AppActionHTTPSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>AppActionHTTPSpec defines the desired state of AppActionHTTP</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppActionHTTPSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AppActionHTTPSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AppActionHTTPSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AppActionHTTPSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AppActionHTTPSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppActionHTTPStatusAtProviderRunAfter
{
    /// <summary>Specifies the name of the precedent HTTP Action.</summary>
    [JsonPropertyName("actionName")]
    public string? ActionName { get; set; }

    /// <summary>Specifies the expected result of the precedent HTTP Action, only after which the current HTTP Action will be triggered. Possible values include Succeeded, Failed, Skipped and TimedOut.</summary>
    [JsonPropertyName("actionResult")]
    public string? ActionResult { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppActionHTTPStatusAtProvider
{
    /// <summary>Specifies the HTTP Body that should be sent to the uri when this HTTP Action is triggered.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Specifies a Map of Key-Value Pairs that should be sent to the uri when this HTTP Action is triggered.</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>The ID of the HTTP Action within the Logic App Workflow.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the ID of the Logic App Workflow. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("logicAppId")]
    public string? LogicAppId { get; set; }

    /// <summary>Specifies the HTTP Method which should be used for this HTTP Action. Possible values include DELETE, GET, PATCH, POST and PUT.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Specifies a Map of Key-Value Pairs that should be sent to the uri when this HTTP Action is triggered.</summary>
    [JsonPropertyName("queries")]
    public IDictionary<string, string>? Queries { get; set; }

    /// <summary>Specifies the place of the HTTP Action in the Logic App Workflow. If not specified, the HTTP Action is right after the Trigger. A run_after block is as defined below.</summary>
    [JsonPropertyName("runAfter")]
    public IList<V1beta1AppActionHTTPStatusAtProviderRunAfter>? RunAfter { get; set; }

    /// <summary>Specifies the URI which will be called when this HTTP Action is triggered.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppActionHTTPStatusConditions
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

/// <summary>AppActionHTTPStatus defines the observed state of AppActionHTTP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppActionHTTPStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AppActionHTTPStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AppActionHTTPStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AppActionHTTP is the Schema for the AppActionHTTPs API. Manages an HTTP Action within a Logic App Workflow</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AppActionHTTP : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AppActionHTTPSpec>, IStatus<V1beta1AppActionHTTPStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AppActionHTTP";
    public const string KubeGroup = "logic.azure.m.upbound.io";
    public const string KubePluralName = "appactionhttps";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AppActionHTTPSpec defines the desired state of AppActionHTTP</summary>
    [JsonPropertyName("spec")]
    public V1beta1AppActionHTTPSpec Spec { get; set; }

    /// <summary>AppActionHTTPStatus defines the observed state of AppActionHTTP.</summary>
    [JsonPropertyName("status")]
    public V1beta1AppActionHTTPStatus? Status { get; set; }
}