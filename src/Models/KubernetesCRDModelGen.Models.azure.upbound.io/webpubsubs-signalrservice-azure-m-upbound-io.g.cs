using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.signalrservice.azure.m.upbound.io;
/// <summary>WebPubsub is the Schema for the WebPubsubs API. Manages an Azure Web PubSub service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WebPubsubList : IKubernetesObject<V1ListMeta>, IItems<V1beta1WebPubsub>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WebPubsubList";
    public const string KubeGroup = "signalrservice.azure.m.upbound.io";
    public const string KubePluralName = "webpubsubs";
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
    public IList<V1beta1WebPubsub> Items { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Web PubSub.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Web PubSub. Possible values are SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A live_trace block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubSpecForProviderLiveTrace
{
    /// <summary>Whether the log category ConnectivityLogs is enabled? Defaults to true</summary>
    [JsonPropertyName("connectivityLogsEnabled")]
    public bool? ConnectivityLogsEnabled { get; set; }

    /// <summary>Whether the live trace is enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether the log category HttpRequestLogs is enabled? Defaults to true</summary>
    [JsonPropertyName("httpRequestLogsEnabled")]
    public bool? HttpRequestLogsEnabled { get; set; }

    /// <summary>Whether the log category MessagingLogs is enabled? Defaults to true</summary>
    [JsonPropertyName("messagingLogsEnabled")]
    public bool? MessagingLogsEnabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1WebPubsubSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1WebPubsubSpecForProviderResourceGroupNameSelector
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
    public V1beta1WebPubsubSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubSpecForProvider
{
    /// <summary>Whether to enable AAD auth? Defaults to true.</summary>
    [JsonPropertyName("aadAuthEnabled")]
    public bool? AadAuthEnabled { get; set; }

    /// <summary>Specifies the number of units associated with this Web PubSub resource. Valid values are 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 500, 600, 700, 800, 900 and 1000.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1WebPubsubSpecForProviderIdentity? Identity { get; set; }

    /// <summary>A live_trace block as defined below.</summary>
    [JsonPropertyName("liveTrace")]
    public V1beta1WebPubsubSpecForProviderLiveTrace? LiveTrace { get; set; }

    /// <summary>Whether to enable local auth? Defaults to true.</summary>
    [JsonPropertyName("localAuthEnabled")]
    public bool? LocalAuthEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the Web PubSub service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the Web PubSub service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether to enable public network access? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the Web PubSub service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1WebPubsubSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1WebPubsubSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Specifies which SKU to use. Possible values are Free_F1, Standard_S1, Premium_P1 and Premium_P2.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Whether to request client certificate during TLS handshake? Defaults to false.</summary>
    [JsonPropertyName("tlsClientCertEnabled")]
    public bool? TlsClientCertEnabled { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Web PubSub.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Web PubSub. Possible values are SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A live_trace block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubSpecInitProviderLiveTrace
{
    /// <summary>Whether the log category ConnectivityLogs is enabled? Defaults to true</summary>
    [JsonPropertyName("connectivityLogsEnabled")]
    public bool? ConnectivityLogsEnabled { get; set; }

    /// <summary>Whether the live trace is enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether the log category HttpRequestLogs is enabled? Defaults to true</summary>
    [JsonPropertyName("httpRequestLogsEnabled")]
    public bool? HttpRequestLogsEnabled { get; set; }

    /// <summary>Whether the log category MessagingLogs is enabled? Defaults to true</summary>
    [JsonPropertyName("messagingLogsEnabled")]
    public bool? MessagingLogsEnabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubSpecInitProviderResourceGroupNameRefPolicy
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
public partial class V1beta1WebPubsubSpecInitProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebPubsubSpecInitProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubSpecInitProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1WebPubsubSpecInitProviderResourceGroupNameSelector
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
    public V1beta1WebPubsubSpecInitProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubSpecInitProvider
{
    /// <summary>Whether to enable AAD auth? Defaults to true.</summary>
    [JsonPropertyName("aadAuthEnabled")]
    public bool? AadAuthEnabled { get; set; }

    /// <summary>Specifies the number of units associated with this Web PubSub resource. Valid values are 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 500, 600, 700, 800, 900 and 1000.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1WebPubsubSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>A live_trace block as defined below.</summary>
    [JsonPropertyName("liveTrace")]
    public V1beta1WebPubsubSpecInitProviderLiveTrace? LiveTrace { get; set; }

    /// <summary>Whether to enable local auth? Defaults to true.</summary>
    [JsonPropertyName("localAuthEnabled")]
    public bool? LocalAuthEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the Web PubSub service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the Web PubSub service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether to enable public network access? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the Web PubSub service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1WebPubsubSpecInitProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1WebPubsubSpecInitProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Specifies which SKU to use. Possible values are Free_F1, Standard_S1, Premium_P1 and Premium_P2.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Whether to request client certificate during TLS handshake? Defaults to false.</summary>
    [JsonPropertyName("tlsClientCertEnabled")]
    public bool? TlsClientCertEnabled { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubSpecProviderConfigRef
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
public partial class V1beta1WebPubsubSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WebPubsubSpec defines the desired state of WebPubsub</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1WebPubsubSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1WebPubsubSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WebPubsubSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WebPubsubSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Web PubSub.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Web PubSub. Possible values are SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A live_trace block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubStatusAtProviderLiveTrace
{
    /// <summary>Whether the log category ConnectivityLogs is enabled? Defaults to true</summary>
    [JsonPropertyName("connectivityLogsEnabled")]
    public bool? ConnectivityLogsEnabled { get; set; }

    /// <summary>Whether the live trace is enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether the log category HttpRequestLogs is enabled? Defaults to true</summary>
    [JsonPropertyName("httpRequestLogsEnabled")]
    public bool? HttpRequestLogsEnabled { get; set; }

    /// <summary>Whether the log category MessagingLogs is enabled? Defaults to true</summary>
    [JsonPropertyName("messagingLogsEnabled")]
    public bool? MessagingLogsEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubStatusAtProvider
{
    /// <summary>Whether to enable AAD auth? Defaults to true.</summary>
    [JsonPropertyName("aadAuthEnabled")]
    public bool? AadAuthEnabled { get; set; }

    /// <summary>Specifies the number of units associated with this Web PubSub resource. Valid values are 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 500, 600, 700, 800, 900 and 1000.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The publicly accessible IP of the Web PubSub service.</summary>
    [JsonPropertyName("externalIp")]
    public string? ExternalIp { get; set; }

    /// <summary>The FQDN of the Web PubSub service.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>The ID of the Web PubSub service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1WebPubsubStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>A live_trace block as defined below.</summary>
    [JsonPropertyName("liveTrace")]
    public V1beta1WebPubsubStatusAtProviderLiveTrace? LiveTrace { get; set; }

    /// <summary>Whether to enable local auth? Defaults to true.</summary>
    [JsonPropertyName("localAuthEnabled")]
    public bool? LocalAuthEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the Web PubSub service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the Web PubSub service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether to enable public network access? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The publicly accessible port of the Web PubSub service which is designed for browser/client use.</summary>
    [JsonPropertyName("publicPort")]
    public double? PublicPort { get; set; }

    /// <summary>The name of the resource group in which to create the Web PubSub service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The publicly accessible port of the Web PubSub service which is designed for customer server side use.</summary>
    [JsonPropertyName("serverPort")]
    public double? ServerPort { get; set; }

    /// <summary>Specifies which SKU to use. Possible values are Free_F1, Standard_S1, Premium_P1 and Premium_P2.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Whether to request client certificate during TLS handshake? Defaults to false.</summary>
    [JsonPropertyName("tlsClientCertEnabled")]
    public bool? TlsClientCertEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubStatusConditions
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

/// <summary>WebPubsubStatus defines the observed state of WebPubsub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebPubsubStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1WebPubsubStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WebPubsubStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>WebPubsub is the Schema for the WebPubsubs API. Manages an Azure Web PubSub service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WebPubsub : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WebPubsubSpec>, IStatus<V1beta1WebPubsubStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WebPubsub";
    public const string KubeGroup = "signalrservice.azure.m.upbound.io";
    public const string KubePluralName = "webpubsubs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WebPubsubSpec defines the desired state of WebPubsub</summary>
    [JsonPropertyName("spec")]
    public V1beta1WebPubsubSpec Spec { get; set; }

    /// <summary>WebPubsubStatus defines the observed state of WebPubsub.</summary>
    [JsonPropertyName("status")]
    public V1beta1WebPubsubStatus? Status { get; set; }
}