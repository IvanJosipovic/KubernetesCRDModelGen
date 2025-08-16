using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.signalrservice.azure.m.upbound.io;
/// <summary>WebPubsubNetworkACL is the Schema for the WebPubsubNetworkACLs API. Manages the Network ACL for a Web Pubsub service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WebPubsubNetworkACLList : IKubernetesObject<V1ListMeta>, IItems<V1beta1WebPubsubNetworkACL>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WebPubsubNetworkACLList";
    public const string KubeGroup = "signalrservice.azure.m.upbound.io";
    public const string KubePluralName = "webpubsubnetworkacls";
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
    public IList<V1beta1WebPubsubNetworkACL> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecForProviderPrivateEndpointIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a PrivateEndpoint in network to populate id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecForProviderPrivateEndpointIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubNetworkACLSpecForProviderPrivateEndpointIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecForProviderPrivateEndpointIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a PrivateEndpoint in network to populate id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecForProviderPrivateEndpointIdSelector
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
    public V1beta1WebPubsubNetworkACLSpecForProviderPrivateEndpointIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecForProviderPrivateEndpoint
{
    /// <summary>The allowed request types for the Private Endpoint Connection. Possible values are ClientConnection, ServerConnection, RESTAPI and Trace.</summary>
    [JsonPropertyName("allowedRequestTypes")]
    public IList<string>? AllowedRequestTypes { get; set; }

    /// <summary>The denied request types for the Private Endpoint Connection. Possible values are ClientConnection, ServerConnection, RESTAPI and Trace.</summary>
    [JsonPropertyName("deniedRequestTypes")]
    public IList<string>? DeniedRequestTypes { get; set; }

    /// <summary>The ID of the Private Endpoint which is based on the Web Pubsub service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Reference to a PrivateEndpoint in network to populate id.</summary>
    [JsonPropertyName("idRef")]
    public V1beta1WebPubsubNetworkACLSpecForProviderPrivateEndpointIdRef? IdRef { get; set; }

    /// <summary>Selector for a PrivateEndpoint in network to populate id.</summary>
    [JsonPropertyName("idSelector")]
    public V1beta1WebPubsubNetworkACLSpecForProviderPrivateEndpointIdSelector? IdSelector { get; set; }
}

/// <summary>A public_network block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecForProviderPublicNetwork
{
    /// <summary>The allowed request types for the public network. Possible values are ClientConnection, ServerConnection, RESTAPI and Trace.</summary>
    [JsonPropertyName("allowedRequestTypes")]
    public IList<string>? AllowedRequestTypes { get; set; }

    /// <summary>The denied request types for the public network. Possible values are ClientConnection, ServerConnection, RESTAPI and Trace.</summary>
    [JsonPropertyName("deniedRequestTypes")]
    public IList<string>? DeniedRequestTypes { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecForProviderWebPubsubIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a WebPubsub in signalrservice to populate webPubsubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecForProviderWebPubsubIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubNetworkACLSpecForProviderWebPubsubIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecForProviderWebPubsubIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a WebPubsub in signalrservice to populate webPubsubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecForProviderWebPubsubIdSelector
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
    public V1beta1WebPubsubNetworkACLSpecForProviderWebPubsubIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecForProvider
{
    /// <summary>The default action to control the network access when no other rule matches. Possible values are Allow and Deny. Defaults to Deny.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>A private_endpoint block as defined below.</summary>
    [JsonPropertyName("privateEndpoint")]
    public IList<V1beta1WebPubsubNetworkACLSpecForProviderPrivateEndpoint>? PrivateEndpoint { get; set; }

    /// <summary>A public_network block as defined below.</summary>
    [JsonPropertyName("publicNetwork")]
    public V1beta1WebPubsubNetworkACLSpecForProviderPublicNetwork? PublicNetwork { get; set; }

    /// <summary>The ID of the Web Pubsub service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("webPubsubId")]
    public string? WebPubsubId { get; set; }

    /// <summary>Reference to a WebPubsub in signalrservice to populate webPubsubId.</summary>
    [JsonPropertyName("webPubsubIdRef")]
    public V1beta1WebPubsubNetworkACLSpecForProviderWebPubsubIdRef? WebPubsubIdRef { get; set; }

    /// <summary>Selector for a WebPubsub in signalrservice to populate webPubsubId.</summary>
    [JsonPropertyName("webPubsubIdSelector")]
    public V1beta1WebPubsubNetworkACLSpecForProviderWebPubsubIdSelector? WebPubsubIdSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecInitProviderPrivateEndpointIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a PrivateEndpoint in network to populate id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecInitProviderPrivateEndpointIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubNetworkACLSpecInitProviderPrivateEndpointIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecInitProviderPrivateEndpointIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a PrivateEndpoint in network to populate id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecInitProviderPrivateEndpointIdSelector
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
    public V1beta1WebPubsubNetworkACLSpecInitProviderPrivateEndpointIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecInitProviderPrivateEndpoint
{
    /// <summary>The allowed request types for the Private Endpoint Connection. Possible values are ClientConnection, ServerConnection, RESTAPI and Trace.</summary>
    [JsonPropertyName("allowedRequestTypes")]
    public IList<string>? AllowedRequestTypes { get; set; }

    /// <summary>The denied request types for the Private Endpoint Connection. Possible values are ClientConnection, ServerConnection, RESTAPI and Trace.</summary>
    [JsonPropertyName("deniedRequestTypes")]
    public IList<string>? DeniedRequestTypes { get; set; }

    /// <summary>The ID of the Private Endpoint which is based on the Web Pubsub service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Reference to a PrivateEndpoint in network to populate id.</summary>
    [JsonPropertyName("idRef")]
    public V1beta1WebPubsubNetworkACLSpecInitProviderPrivateEndpointIdRef? IdRef { get; set; }

    /// <summary>Selector for a PrivateEndpoint in network to populate id.</summary>
    [JsonPropertyName("idSelector")]
    public V1beta1WebPubsubNetworkACLSpecInitProviderPrivateEndpointIdSelector? IdSelector { get; set; }
}

/// <summary>A public_network block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecInitProviderPublicNetwork
{
    /// <summary>The allowed request types for the public network. Possible values are ClientConnection, ServerConnection, RESTAPI and Trace.</summary>
    [JsonPropertyName("allowedRequestTypes")]
    public IList<string>? AllowedRequestTypes { get; set; }

    /// <summary>The denied request types for the public network. Possible values are ClientConnection, ServerConnection, RESTAPI and Trace.</summary>
    [JsonPropertyName("deniedRequestTypes")]
    public IList<string>? DeniedRequestTypes { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecInitProviderWebPubsubIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a WebPubsub in signalrservice to populate webPubsubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecInitProviderWebPubsubIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubNetworkACLSpecInitProviderWebPubsubIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecInitProviderWebPubsubIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a WebPubsub in signalrservice to populate webPubsubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecInitProviderWebPubsubIdSelector
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
    public V1beta1WebPubsubNetworkACLSpecInitProviderWebPubsubIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecInitProvider
{
    /// <summary>The default action to control the network access when no other rule matches. Possible values are Allow and Deny. Defaults to Deny.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>A private_endpoint block as defined below.</summary>
    [JsonPropertyName("privateEndpoint")]
    public IList<V1beta1WebPubsubNetworkACLSpecInitProviderPrivateEndpoint>? PrivateEndpoint { get; set; }

    /// <summary>A public_network block as defined below.</summary>
    [JsonPropertyName("publicNetwork")]
    public V1beta1WebPubsubNetworkACLSpecInitProviderPublicNetwork? PublicNetwork { get; set; }

    /// <summary>The ID of the Web Pubsub service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("webPubsubId")]
    public string? WebPubsubId { get; set; }

    /// <summary>Reference to a WebPubsub in signalrservice to populate webPubsubId.</summary>
    [JsonPropertyName("webPubsubIdRef")]
    public V1beta1WebPubsubNetworkACLSpecInitProviderWebPubsubIdRef? WebPubsubIdRef { get; set; }

    /// <summary>Selector for a WebPubsub in signalrservice to populate webPubsubId.</summary>
    [JsonPropertyName("webPubsubIdSelector")]
    public V1beta1WebPubsubNetworkACLSpecInitProviderWebPubsubIdSelector? WebPubsubIdSelector { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpecProviderConfigRef
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
public partial class V1beta1WebPubsubNetworkACLSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WebPubsubNetworkACLSpec defines the desired state of WebPubsubNetworkACL</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1WebPubsubNetworkACLSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1WebPubsubNetworkACLSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WebPubsubNetworkACLSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WebPubsubNetworkACLSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLStatusAtProviderPrivateEndpoint
{
    /// <summary>The allowed request types for the Private Endpoint Connection. Possible values are ClientConnection, ServerConnection, RESTAPI and Trace.</summary>
    [JsonPropertyName("allowedRequestTypes")]
    public IList<string>? AllowedRequestTypes { get; set; }

    /// <summary>The denied request types for the Private Endpoint Connection. Possible values are ClientConnection, ServerConnection, RESTAPI and Trace.</summary>
    [JsonPropertyName("deniedRequestTypes")]
    public IList<string>? DeniedRequestTypes { get; set; }

    /// <summary>The ID of the Private Endpoint which is based on the Web Pubsub service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>A public_network block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLStatusAtProviderPublicNetwork
{
    /// <summary>The allowed request types for the public network. Possible values are ClientConnection, ServerConnection, RESTAPI and Trace.</summary>
    [JsonPropertyName("allowedRequestTypes")]
    public IList<string>? AllowedRequestTypes { get; set; }

    /// <summary>The denied request types for the public network. Possible values are ClientConnection, ServerConnection, RESTAPI and Trace.</summary>
    [JsonPropertyName("deniedRequestTypes")]
    public IList<string>? DeniedRequestTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLStatusAtProvider
{
    /// <summary>The default action to control the network access when no other rule matches. Possible values are Allow and Deny. Defaults to Deny.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>The ID of the Web Pubsub service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A private_endpoint block as defined below.</summary>
    [JsonPropertyName("privateEndpoint")]
    public IList<V1beta1WebPubsubNetworkACLStatusAtProviderPrivateEndpoint>? PrivateEndpoint { get; set; }

    /// <summary>A public_network block as defined below.</summary>
    [JsonPropertyName("publicNetwork")]
    public V1beta1WebPubsubNetworkACLStatusAtProviderPublicNetwork? PublicNetwork { get; set; }

    /// <summary>The ID of the Web Pubsub service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("webPubsubId")]
    public string? WebPubsubId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLStatusConditions
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

/// <summary>WebPubsubNetworkACLStatus defines the observed state of WebPubsubNetworkACL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubNetworkACLStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1WebPubsubNetworkACLStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WebPubsubNetworkACLStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>WebPubsubNetworkACL is the Schema for the WebPubsubNetworkACLs API. Manages the Network ACL for a Web Pubsub service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WebPubsubNetworkACL : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WebPubsubNetworkACLSpec>, IStatus<V1beta1WebPubsubNetworkACLStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WebPubsubNetworkACL";
    public const string KubeGroup = "signalrservice.azure.m.upbound.io";
    public const string KubePluralName = "webpubsubnetworkacls";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WebPubsubNetworkACLSpec defines the desired state of WebPubsubNetworkACL</summary>
    [JsonPropertyName("spec")]
    public V1beta1WebPubsubNetworkACLSpec Spec { get; set; }

    /// <summary>WebPubsubNetworkACLStatus defines the observed state of WebPubsubNetworkACL.</summary>
    [JsonPropertyName("status")]
    public V1beta1WebPubsubNetworkACLStatus? Status { get; set; }
}