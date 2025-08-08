using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.botservice.azure.m.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelDirectLineSpecForProviderBotNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BotChannelsRegistration in botservice to populate botName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelDirectLineSpecForProviderBotNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BotChannelDirectLineSpecForProviderBotNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelDirectLineSpecForProviderBotNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BotChannelsRegistration in botservice to populate botName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelDirectLineSpecForProviderBotNameSelector
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
    public V1beta1BotChannelDirectLineSpecForProviderBotNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameSelector
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
    public V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelDirectLineSpecForProviderSite
{
    /// <summary>Enables/Disables this site. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Is the endpoint parameters enabled for this site?</summary>
    [JsonPropertyName("endpointParametersEnabled")]
    public bool? EndpointParametersEnabled { get; set; }

    /// <summary>Enables additional security measures for this site, see Enhanced Directline Authentication Features. Disabled by default.</summary>
    [JsonPropertyName("enhancedAuthenticationEnabled")]
    public bool? EnhancedAuthenticationEnabled { get; set; }

    /// <summary>The name of the site</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is the storage site enabled for detailed logging? Defaults to true.</summary>
    [JsonPropertyName("storageEnabled")]
    public bool? StorageEnabled { get; set; }

    /// <summary>This field is required when is_secure_site_enabled is enabled. Determines which origins can establish a Directline conversation for this site.</summary>
    [JsonPropertyName("trustedOrigins")]
    public IList<string>? TrustedOrigins { get; set; }

    /// <summary>Is the user upload enabled for this site? Defaults to true.</summary>
    [JsonPropertyName("userUploadEnabled")]
    public bool? UserUploadEnabled { get; set; }

    /// <summary>Enables v1 of the Directline protocol for this site. Defaults to true.</summary>
    [JsonPropertyName("v1Allowed")]
    public bool? V1Allowed { get; set; }

    /// <summary>Enables v3 of the Directline protocol for this site. Defaults to true.</summary>
    [JsonPropertyName("v3Allowed")]
    public bool? V3Allowed { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelDirectLineSpecForProvider
{
    /// <summary>The name of the Bot Resource this channel will be associated with. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("botName")]
    public string? BotName { get; set; }

    /// <summary>Reference to a BotChannelsRegistration in botservice to populate botName.</summary>
    [JsonPropertyName("botNameRef")]
    public V1beta1BotChannelDirectLineSpecForProviderBotNameRef? BotNameRef { get; set; }

    /// <summary>Selector for a BotChannelsRegistration in botservice to populate botName.</summary>
    [JsonPropertyName("botNameSelector")]
    public V1beta1BotChannelDirectLineSpecForProviderBotNameSelector? BotNameSelector { get; set; }

    /// <summary>The supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the resource group in which to create the Bot Channel. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1BotChannelDirectLineSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A site represents a client application that you want to connect to your bot. One or more site blocks as defined below.</summary>
    [JsonPropertyName("site")]
    public IList<V1beta1BotChannelDirectLineSpecForProviderSite>? Site { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelDirectLineSpecInitProviderSite
{
    /// <summary>Enables/Disables this site. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Is the endpoint parameters enabled for this site?</summary>
    [JsonPropertyName("endpointParametersEnabled")]
    public bool? EndpointParametersEnabled { get; set; }

    /// <summary>Enables additional security measures for this site, see Enhanced Directline Authentication Features. Disabled by default.</summary>
    [JsonPropertyName("enhancedAuthenticationEnabled")]
    public bool? EnhancedAuthenticationEnabled { get; set; }

    /// <summary>The name of the site</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is the storage site enabled for detailed logging? Defaults to true.</summary>
    [JsonPropertyName("storageEnabled")]
    public bool? StorageEnabled { get; set; }

    /// <summary>This field is required when is_secure_site_enabled is enabled. Determines which origins can establish a Directline conversation for this site.</summary>
    [JsonPropertyName("trustedOrigins")]
    public IList<string>? TrustedOrigins { get; set; }

    /// <summary>Is the user upload enabled for this site? Defaults to true.</summary>
    [JsonPropertyName("userUploadEnabled")]
    public bool? UserUploadEnabled { get; set; }

    /// <summary>Enables v1 of the Directline protocol for this site. Defaults to true.</summary>
    [JsonPropertyName("v1Allowed")]
    public bool? V1Allowed { get; set; }

    /// <summary>Enables v3 of the Directline protocol for this site. Defaults to true.</summary>
    [JsonPropertyName("v3Allowed")]
    public bool? V3Allowed { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelDirectLineSpecInitProvider
{
    /// <summary>The supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A site represents a client application that you want to connect to your bot. One or more site blocks as defined below.</summary>
    [JsonPropertyName("site")]
    public IList<V1beta1BotChannelDirectLineSpecInitProviderSite>? Site { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelDirectLineSpecProviderConfigRef
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
public partial class V1beta1BotChannelDirectLineSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>BotChannelDirectLineSpec defines the desired state of BotChannelDirectLine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelDirectLineSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BotChannelDirectLineSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BotChannelDirectLineSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BotChannelDirectLineSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BotChannelDirectLineSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelDirectLineStatusAtProviderSite
{
    /// <summary>Enables/Disables this site. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Is the endpoint parameters enabled for this site?</summary>
    [JsonPropertyName("endpointParametersEnabled")]
    public bool? EndpointParametersEnabled { get; set; }

    /// <summary>Enables additional security measures for this site, see Enhanced Directline Authentication Features. Disabled by default.</summary>
    [JsonPropertyName("enhancedAuthenticationEnabled")]
    public bool? EnhancedAuthenticationEnabled { get; set; }

    /// <summary>Id for the site</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the site</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is the storage site enabled for detailed logging? Defaults to true.</summary>
    [JsonPropertyName("storageEnabled")]
    public bool? StorageEnabled { get; set; }

    /// <summary>This field is required when is_secure_site_enabled is enabled. Determines which origins can establish a Directline conversation for this site.</summary>
    [JsonPropertyName("trustedOrigins")]
    public IList<string>? TrustedOrigins { get; set; }

    /// <summary>Is the user upload enabled for this site? Defaults to true.</summary>
    [JsonPropertyName("userUploadEnabled")]
    public bool? UserUploadEnabled { get; set; }

    /// <summary>Enables v1 of the Directline protocol for this site. Defaults to true.</summary>
    [JsonPropertyName("v1Allowed")]
    public bool? V1Allowed { get; set; }

    /// <summary>Enables v3 of the Directline protocol for this site. Defaults to true.</summary>
    [JsonPropertyName("v3Allowed")]
    public bool? V3Allowed { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelDirectLineStatusAtProvider
{
    /// <summary>The name of the Bot Resource this channel will be associated with. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("botName")]
    public string? BotName { get; set; }

    /// <summary>The Bot Channel ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the resource group in which to create the Bot Channel. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A site represents a client application that you want to connect to your bot. One or more site blocks as defined below.</summary>
    [JsonPropertyName("site")]
    public IList<V1beta1BotChannelDirectLineStatusAtProviderSite>? Site { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelDirectLineStatusConditions
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

/// <summary>BotChannelDirectLineStatus defines the observed state of BotChannelDirectLine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelDirectLineStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BotChannelDirectLineStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BotChannelDirectLineStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BotChannelDirectLine is the Schema for the BotChannelDirectLines API. Manages an Directline integration for a Bot Channel</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BotChannelDirectLine : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BotChannelDirectLineSpec>, IStatus<V1beta1BotChannelDirectLineStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BotChannelDirectLine";
    public const string KubeGroup = "botservice.azure.m.upbound.io";
    public const string KubePluralName = "botchanneldirectlines";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BotChannelDirectLineSpec defines the desired state of BotChannelDirectLine</summary>
    [JsonPropertyName("spec")]
    public V1beta1BotChannelDirectLineSpec Spec { get; set; }

    /// <summary>BotChannelDirectLineStatus defines the observed state of BotChannelDirectLine.</summary>
    [JsonPropertyName("status")]
    public V1beta1BotChannelDirectLineStatus? Status { get; set; }
}

/// <summary>BotChannelDirectLine is the Schema for the BotChannelDirectLines API. Manages an Directline integration for a Bot Channel</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BotChannelDirectLineList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BotChannelDirectLine>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BotChannelDirectLineList";
    public const string KubeGroup = "botservice.azure.m.upbound.io";
    public const string KubePluralName = "botchanneldirectlines";
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
    public IList<V1beta1BotChannelDirectLine> Items { get; set; }
}