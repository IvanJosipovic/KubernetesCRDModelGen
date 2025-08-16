using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appplatform.azure.m.upbound.io;
/// <summary>SpringCloudAPIPortal is the Schema for the SpringCloudAPIPortals API. Manages a Spring Cloud API Portal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpringCloudAPIPortalList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SpringCloudAPIPortal>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpringCloudAPIPortalList";
    public const string KubeGroup = "appplatform.azure.m.upbound.io";
    public const string KubePluralName = "springcloudapiportals";
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
    public IList<V1beta1SpringCloudAPIPortal> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalSpecForProviderGatewayIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalSpecForProviderGatewayIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAPIPortalSpecForProviderGatewayIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalSpecForProviderGatewayIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of SpringCloudGateway in appplatform to populate gatewayIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalSpecForProviderGatewayIdsSelector
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
    public V1beta1SpringCloudAPIPortalSpecForProviderGatewayIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalSpecForProviderSpringCloudServiceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a SpringCloudService in appplatform to populate springCloudServiceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalSpecForProviderSpringCloudServiceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAPIPortalSpecForProviderSpringCloudServiceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalSpecForProviderSpringCloudServiceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a SpringCloudService in appplatform to populate springCloudServiceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalSpecForProviderSpringCloudServiceIdSelector
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
    public V1beta1SpringCloudAPIPortalSpecForProviderSpringCloudServiceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A sso block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalSpecForProviderSso
{
    /// <summary>The public identifier for the application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The secret known only to the application and the authorization server.</summary>
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    /// <summary>The URI of Issuer Identifier.</summary>
    [JsonPropertyName("issuerUri")]
    public string? IssuerUri { get; set; }

    /// <summary>It defines the specific actions applications can be allowed to do on a user's behalf.</summary>
    [JsonPropertyName("scope")]
    public IList<string>? Scope { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalSpecForProvider
{
    /// <summary>Specifies whether the API try-out feature is enabled. When enabled, users can try out the API by sending requests and viewing responses in API portal.</summary>
    [JsonPropertyName("apiTryOutEnabled")]
    public bool? ApiTryOutEnabled { get; set; }

    /// <summary>Specifies a list of Spring Cloud Gateway.</summary>
    [JsonPropertyName("gatewayIds")]
    public IList<string>? GatewayIds { get; set; }

    /// <summary>References to SpringCloudGateway in appplatform to populate gatewayIds.</summary>
    [JsonPropertyName("gatewayIdsRefs")]
    public IList<V1beta1SpringCloudAPIPortalSpecForProviderGatewayIdsRefs>? GatewayIdsRefs { get; set; }

    /// <summary>Selector for a list of SpringCloudGateway in appplatform to populate gatewayIds.</summary>
    [JsonPropertyName("gatewayIdsSelector")]
    public V1beta1SpringCloudAPIPortalSpecForProviderGatewayIdsSelector? GatewayIdsSelector { get; set; }

    /// <summary>is only https is allowed?</summary>
    [JsonPropertyName("httpsOnlyEnabled")]
    public bool? HttpsOnlyEnabled { get; set; }

    /// <summary>Specifies the required instance count of the Spring Cloud API Portal. Possible Values are between 1 and 500. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>Is the public network access enabled?</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The ID of the Spring Cloud Service. Changing this forces a new Spring Cloud API Portal to be created.</summary>
    [JsonPropertyName("springCloudServiceId")]
    public string? SpringCloudServiceId { get; set; }

    /// <summary>Reference to a SpringCloudService in appplatform to populate springCloudServiceId.</summary>
    [JsonPropertyName("springCloudServiceIdRef")]
    public V1beta1SpringCloudAPIPortalSpecForProviderSpringCloudServiceIdRef? SpringCloudServiceIdRef { get; set; }

    /// <summary>Selector for a SpringCloudService in appplatform to populate springCloudServiceId.</summary>
    [JsonPropertyName("springCloudServiceIdSelector")]
    public V1beta1SpringCloudAPIPortalSpecForProviderSpringCloudServiceIdSelector? SpringCloudServiceIdSelector { get; set; }

    /// <summary>A sso block as defined below.</summary>
    [JsonPropertyName("sso")]
    public V1beta1SpringCloudAPIPortalSpecForProviderSso? Sso { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalSpecInitProviderGatewayIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalSpecInitProviderGatewayIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAPIPortalSpecInitProviderGatewayIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalSpecInitProviderGatewayIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of SpringCloudGateway in appplatform to populate gatewayIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalSpecInitProviderGatewayIdsSelector
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
    public V1beta1SpringCloudAPIPortalSpecInitProviderGatewayIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>A sso block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalSpecInitProviderSso
{
    /// <summary>The public identifier for the application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The secret known only to the application and the authorization server.</summary>
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    /// <summary>The URI of Issuer Identifier.</summary>
    [JsonPropertyName("issuerUri")]
    public string? IssuerUri { get; set; }

    /// <summary>It defines the specific actions applications can be allowed to do on a user's behalf.</summary>
    [JsonPropertyName("scope")]
    public IList<string>? Scope { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalSpecInitProvider
{
    /// <summary>Specifies whether the API try-out feature is enabled. When enabled, users can try out the API by sending requests and viewing responses in API portal.</summary>
    [JsonPropertyName("apiTryOutEnabled")]
    public bool? ApiTryOutEnabled { get; set; }

    /// <summary>Specifies a list of Spring Cloud Gateway.</summary>
    [JsonPropertyName("gatewayIds")]
    public IList<string>? GatewayIds { get; set; }

    /// <summary>References to SpringCloudGateway in appplatform to populate gatewayIds.</summary>
    [JsonPropertyName("gatewayIdsRefs")]
    public IList<V1beta1SpringCloudAPIPortalSpecInitProviderGatewayIdsRefs>? GatewayIdsRefs { get; set; }

    /// <summary>Selector for a list of SpringCloudGateway in appplatform to populate gatewayIds.</summary>
    [JsonPropertyName("gatewayIdsSelector")]
    public V1beta1SpringCloudAPIPortalSpecInitProviderGatewayIdsSelector? GatewayIdsSelector { get; set; }

    /// <summary>is only https is allowed?</summary>
    [JsonPropertyName("httpsOnlyEnabled")]
    public bool? HttpsOnlyEnabled { get; set; }

    /// <summary>Specifies the required instance count of the Spring Cloud API Portal. Possible Values are between 1 and 500. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>Is the public network access enabled?</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A sso block as defined below.</summary>
    [JsonPropertyName("sso")]
    public V1beta1SpringCloudAPIPortalSpecInitProviderSso? Sso { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalSpecProviderConfigRef
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
public partial class V1beta1SpringCloudAPIPortalSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SpringCloudAPIPortalSpec defines the desired state of SpringCloudAPIPortal</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SpringCloudAPIPortalSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SpringCloudAPIPortalSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SpringCloudAPIPortalSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SpringCloudAPIPortalSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A sso block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalStatusAtProviderSso
{
    /// <summary>The public identifier for the application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The secret known only to the application and the authorization server.</summary>
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    /// <summary>The URI of Issuer Identifier.</summary>
    [JsonPropertyName("issuerUri")]
    public string? IssuerUri { get; set; }

    /// <summary>It defines the specific actions applications can be allowed to do on a user's behalf.</summary>
    [JsonPropertyName("scope")]
    public IList<string>? Scope { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalStatusAtProvider
{
    /// <summary>Specifies whether the API try-out feature is enabled. When enabled, users can try out the API by sending requests and viewing responses in API portal.</summary>
    [JsonPropertyName("apiTryOutEnabled")]
    public bool? ApiTryOutEnabled { get; set; }

    /// <summary>Specifies a list of Spring Cloud Gateway.</summary>
    [JsonPropertyName("gatewayIds")]
    public IList<string>? GatewayIds { get; set; }

    /// <summary>is only https is allowed?</summary>
    [JsonPropertyName("httpsOnlyEnabled")]
    public bool? HttpsOnlyEnabled { get; set; }

    /// <summary>The ID of the Spring Cloud API Portal.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the required instance count of the Spring Cloud API Portal. Possible Values are between 1 and 500. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>Is the public network access enabled?</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The ID of the Spring Cloud Service. Changing this forces a new Spring Cloud API Portal to be created.</summary>
    [JsonPropertyName("springCloudServiceId")]
    public string? SpringCloudServiceId { get; set; }

    /// <summary>A sso block as defined below.</summary>
    [JsonPropertyName("sso")]
    public V1beta1SpringCloudAPIPortalStatusAtProviderSso? Sso { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalStatusConditions
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

/// <summary>SpringCloudAPIPortalStatus defines the observed state of SpringCloudAPIPortal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAPIPortalStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SpringCloudAPIPortalStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SpringCloudAPIPortalStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SpringCloudAPIPortal is the Schema for the SpringCloudAPIPortals API. Manages a Spring Cloud API Portal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpringCloudAPIPortal : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpringCloudAPIPortalSpec>, IStatus<V1beta1SpringCloudAPIPortalStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpringCloudAPIPortal";
    public const string KubeGroup = "appplatform.azure.m.upbound.io";
    public const string KubePluralName = "springcloudapiportals";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpringCloudAPIPortalSpec defines the desired state of SpringCloudAPIPortal</summary>
    [JsonPropertyName("spec")]
    public V1beta1SpringCloudAPIPortalSpec Spec { get; set; }

    /// <summary>SpringCloudAPIPortalStatus defines the observed state of SpringCloudAPIPortal.</summary>
    [JsonPropertyName("status")]
    public V1beta1SpringCloudAPIPortalStatus? Status { get; set; }
}