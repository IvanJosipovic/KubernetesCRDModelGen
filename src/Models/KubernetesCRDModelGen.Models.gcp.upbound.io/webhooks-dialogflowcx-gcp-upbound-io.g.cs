using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dialogflowcx.gcp.upbound.io;
#nullable enable
/// <summary>Webhook is the Schema for the Webhooks API. Webhooks host the developer's business logic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WebhookList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Webhook>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WebhookList";
    public const string KubeGroup = "dialogflowcx.gcp.upbound.io";
    public const string KubePluralName = "webhooks";
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
    public IList<V1beta1Webhook> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderGenericWebService
{
    /// <summary>Specifies a list of allowed custom CA certificates (in DER format) for HTTPS verification.</summary>
    [JsonPropertyName("allowedCaCerts")]
    public IList<string>? AllowedCaCerts { get; set; }

    /// <summary>The HTTP request headers to send together with webhook requests.</summary>
    [JsonPropertyName("requestHeaders")]
    public IDictionary<string, string>? RequestHeaders { get; set; }

    /// <summary>Whether to use speech adaptation for speech recognition.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderParentRefPolicy
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
/// <summary>Reference to a Agent in dialogflowcx to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderParentRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebhookSpecForProviderParentRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderParentSelectorPolicy
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
/// <summary>Selector for a Agent in dialogflowcx to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderParentSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebhookSpecForProviderParentSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderServiceDirectoryGenericWebService
{
    /// <summary>Specifies a list of allowed custom CA certificates (in DER format) for HTTPS verification.</summary>
    [JsonPropertyName("allowedCaCerts")]
    public IList<string>? AllowedCaCerts { get; set; }

    /// <summary>The HTTP request headers to send together with webhook requests.</summary>
    [JsonPropertyName("requestHeaders")]
    public IDictionary<string, string>? RequestHeaders { get; set; }

    /// <summary>Whether to use speech adaptation for speech recognition.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderServiceDirectory
{
    /// <summary>The name of Service Directory service. Structure is documented below.</summary>
    [JsonPropertyName("genericWebService")]
    public IList<V1beta1WebhookSpecForProviderServiceDirectoryGenericWebService>? GenericWebService { get; set; }

    /// <summary>The name of Service Directory service.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProvider
{
    /// <summary>Indicates whether the webhook is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The human-readable name of the webhook, unique within the agent.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Indicates if automatic spell correction is enabled in detect intent requests.</summary>
    [JsonPropertyName("enableSpellCorrection")]
    public bool? EnableSpellCorrection { get; set; }

    /// <summary>Determines whether this agent should log conversation queries.</summary>
    [JsonPropertyName("enableStackdriverLogging")]
    public bool? EnableStackdriverLogging { get; set; }

    /// <summary>Configuration for a generic web service. Structure is documented below.</summary>
    [JsonPropertyName("genericWebService")]
    public IList<V1beta1WebhookSpecForProviderGenericWebService>? GenericWebService { get; set; }

    /// <summary>The agent to create a webhook for. Format: projects//locations//agents/.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Reference to a Agent in dialogflowcx to populate parent.</summary>
    [JsonPropertyName("parentRef")]
    public V1beta1WebhookSpecForProviderParentRef? ParentRef { get; set; }

    /// <summary>Selector for a Agent in dialogflowcx to populate parent.</summary>
    [JsonPropertyName("parentSelector")]
    public V1beta1WebhookSpecForProviderParentSelector? ParentSelector { get; set; }

    /// <summary>Name of the SecuritySettings reference for the agent. Format: projects//locations//securitySettings/.</summary>
    [JsonPropertyName("securitySettings")]
    public string? SecuritySettings { get; set; }

    /// <summary>Configuration for a Service Directory service. Structure is documented below.</summary>
    [JsonPropertyName("serviceDirectory")]
    public IList<V1beta1WebhookSpecForProviderServiceDirectory>? ServiceDirectory { get; set; }

    /// <summary>Webhook execution timeout.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderGenericWebService
{
    /// <summary>Specifies a list of allowed custom CA certificates (in DER format) for HTTPS verification.</summary>
    [JsonPropertyName("allowedCaCerts")]
    public IList<string>? AllowedCaCerts { get; set; }

    /// <summary>The HTTP request headers to send together with webhook requests.</summary>
    [JsonPropertyName("requestHeaders")]
    public IDictionary<string, string>? RequestHeaders { get; set; }

    /// <summary>Whether to use speech adaptation for speech recognition.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderParentRefPolicy
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
/// <summary>Reference to a Agent in dialogflowcx to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderParentRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebhookSpecInitProviderParentRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderParentSelectorPolicy
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
/// <summary>Selector for a Agent in dialogflowcx to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderParentSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebhookSpecInitProviderParentSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderServiceDirectoryGenericWebService
{
    /// <summary>Specifies a list of allowed custom CA certificates (in DER format) for HTTPS verification.</summary>
    [JsonPropertyName("allowedCaCerts")]
    public IList<string>? AllowedCaCerts { get; set; }

    /// <summary>The HTTP request headers to send together with webhook requests.</summary>
    [JsonPropertyName("requestHeaders")]
    public IDictionary<string, string>? RequestHeaders { get; set; }

    /// <summary>Whether to use speech adaptation for speech recognition.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderServiceDirectory
{
    /// <summary>The name of Service Directory service. Structure is documented below.</summary>
    [JsonPropertyName("genericWebService")]
    public IList<V1beta1WebhookSpecInitProviderServiceDirectoryGenericWebService>? GenericWebService { get; set; }

    /// <summary>The name of Service Directory service.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProvider
{
    /// <summary>Indicates whether the webhook is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The human-readable name of the webhook, unique within the agent.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Indicates if automatic spell correction is enabled in detect intent requests.</summary>
    [JsonPropertyName("enableSpellCorrection")]
    public bool? EnableSpellCorrection { get; set; }

    /// <summary>Determines whether this agent should log conversation queries.</summary>
    [JsonPropertyName("enableStackdriverLogging")]
    public bool? EnableStackdriverLogging { get; set; }

    /// <summary>Configuration for a generic web service. Structure is documented below.</summary>
    [JsonPropertyName("genericWebService")]
    public IList<V1beta1WebhookSpecInitProviderGenericWebService>? GenericWebService { get; set; }

    /// <summary>The agent to create a webhook for. Format: projects//locations//agents/.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Reference to a Agent in dialogflowcx to populate parent.</summary>
    [JsonPropertyName("parentRef")]
    public V1beta1WebhookSpecInitProviderParentRef? ParentRef { get; set; }

    /// <summary>Selector for a Agent in dialogflowcx to populate parent.</summary>
    [JsonPropertyName("parentSelector")]
    public V1beta1WebhookSpecInitProviderParentSelector? ParentSelector { get; set; }

    /// <summary>Name of the SecuritySettings reference for the agent. Format: projects//locations//securitySettings/.</summary>
    [JsonPropertyName("securitySettings")]
    public string? SecuritySettings { get; set; }

    /// <summary>Configuration for a Service Directory service. Structure is documented below.</summary>
    [JsonPropertyName("serviceDirectory")]
    public IList<V1beta1WebhookSpecInitProviderServiceDirectory>? ServiceDirectory { get; set; }

    /// <summary>Webhook execution timeout.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecProviderConfigRefPolicy
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
public partial class V1beta1WebhookSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebhookSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecWriteConnectionSecretToRef
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
/// <summary>WebhookSpec defines the desired state of Webhook</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1WebhookSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1WebhookSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WebhookSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WebhookSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatusAtProviderGenericWebService
{
    /// <summary>Specifies a list of allowed custom CA certificates (in DER format) for HTTPS verification.</summary>
    [JsonPropertyName("allowedCaCerts")]
    public IList<string>? AllowedCaCerts { get; set; }

    /// <summary>The HTTP request headers to send together with webhook requests.</summary>
    [JsonPropertyName("requestHeaders")]
    public IDictionary<string, string>? RequestHeaders { get; set; }

    /// <summary>Whether to use speech adaptation for speech recognition.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatusAtProviderServiceDirectoryGenericWebService
{
    /// <summary>Specifies a list of allowed custom CA certificates (in DER format) for HTTPS verification.</summary>
    [JsonPropertyName("allowedCaCerts")]
    public IList<string>? AllowedCaCerts { get; set; }

    /// <summary>The HTTP request headers to send together with webhook requests.</summary>
    [JsonPropertyName("requestHeaders")]
    public IDictionary<string, string>? RequestHeaders { get; set; }

    /// <summary>Whether to use speech adaptation for speech recognition.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatusAtProviderServiceDirectory
{
    /// <summary>The name of Service Directory service. Structure is documented below.</summary>
    [JsonPropertyName("genericWebService")]
    public IList<V1beta1WebhookStatusAtProviderServiceDirectoryGenericWebService>? GenericWebService { get; set; }

    /// <summary>The name of Service Directory service.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatusAtProvider
{
    /// <summary>Indicates whether the webhook is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The human-readable name of the webhook, unique within the agent.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Indicates if automatic spell correction is enabled in detect intent requests.</summary>
    [JsonPropertyName("enableSpellCorrection")]
    public bool? EnableSpellCorrection { get; set; }

    /// <summary>Determines whether this agent should log conversation queries.</summary>
    [JsonPropertyName("enableStackdriverLogging")]
    public bool? EnableStackdriverLogging { get; set; }

    /// <summary>Configuration for a generic web service. Structure is documented below.</summary>
    [JsonPropertyName("genericWebService")]
    public IList<V1beta1WebhookStatusAtProviderGenericWebService>? GenericWebService { get; set; }

    /// <summary>an identifier for the resource with format {{parent}}/webhooks/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The unique identifier of the webhook. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The agent to create a webhook for. Format: projects//locations//agents/.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Name of the SecuritySettings reference for the agent. Format: projects//locations//securitySettings/.</summary>
    [JsonPropertyName("securitySettings")]
    public string? SecuritySettings { get; set; }

    /// <summary>Configuration for a Service Directory service. Structure is documented below.</summary>
    [JsonPropertyName("serviceDirectory")]
    public IList<V1beta1WebhookStatusAtProviderServiceDirectory>? ServiceDirectory { get; set; }

    /// <summary>Name of the start flow in this agent. A start flow will be automatically created when the agent is created, and can only be deleted by deleting the agent. Format: projects//locations//agents//flows/.</summary>
    [JsonPropertyName("startFlow")]
    public string? StartFlow { get; set; }

    /// <summary>Webhook execution timeout.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatusConditions
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
/// <summary>WebhookStatus defines the observed state of Webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1WebhookStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WebhookStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Webhook is the Schema for the Webhooks API. Webhooks host the developer's business logic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Webhook : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WebhookSpec>, IStatus<V1beta1WebhookStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Webhook";
    public const string KubeGroup = "dialogflowcx.gcp.upbound.io";
    public const string KubePluralName = "webhooks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WebhookSpec defines the desired state of Webhook</summary>
    [JsonPropertyName("spec")]
    public V1beta1WebhookSpec Spec { get; set; }

    /// <summary>WebhookStatus defines the observed state of Webhook.</summary>
    [JsonPropertyName("status")]
    public V1beta1WebhookStatus? Status { get; set; }
}
#nullable disable
