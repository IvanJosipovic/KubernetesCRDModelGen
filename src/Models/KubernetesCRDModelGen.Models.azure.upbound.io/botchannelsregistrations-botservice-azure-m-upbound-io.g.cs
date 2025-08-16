using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.botservice.azure.m.upbound.io;
/// <summary>BotChannelsRegistration is the Schema for the BotChannelsRegistrations API. Manages a Bot Channels Registration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BotChannelsRegistrationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BotChannelsRegistration>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BotChannelsRegistrationList";
    public const string KubeGroup = "botservice.azure.m.upbound.io";
    public const string KubePluralName = "botchannelsregistrations";
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
    public IList<V1beta1BotChannelsRegistration> Items { get; set; }
}

/// <summary>The Application Insights API Key to associate with the Bot Channels Registration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelsRegistrationSpecForProviderDeveloperAppInsightsApiKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelsRegistrationSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1BotChannelsRegistrationSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BotChannelsRegistrationSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelsRegistrationSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1BotChannelsRegistrationSpecForProviderResourceGroupNameSelector
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
    public V1beta1BotChannelsRegistrationSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelsRegistrationSpecForProvider
{
    /// <summary>The CMK Key Vault Key URL to encrypt the Bot Channels Registration with the Customer Managed Encryption Key.</summary>
    [JsonPropertyName("cmkKeyVaultUrl")]
    public string? CmkKeyVaultUrl { get; set; }

    /// <summary>The description of the Bot Channels Registration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Application Insights API Key to associate with the Bot Channels Registration.</summary>
    [JsonPropertyName("developerAppInsightsApiKeySecretRef")]
    public V1beta1BotChannelsRegistrationSpecForProviderDeveloperAppInsightsApiKeySecretRef? DeveloperAppInsightsApiKeySecretRef { get; set; }

    /// <summary>The Application Insights Application ID to associate with the Bot Channels Registration.</summary>
    [JsonPropertyName("developerAppInsightsApplicationId")]
    public string? DeveloperAppInsightsApplicationId { get; set; }

    /// <summary>The Application Insights Key to associate with the Bot Channels Registration.</summary>
    [JsonPropertyName("developerAppInsightsKey")]
    public string? DeveloperAppInsightsKey { get; set; }

    /// <summary>The name of the Bot Channels Registration will be displayed as. This defaults to name if not specified.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The Bot Channels Registration endpoint.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The icon URL to visually identify the Bot Channels Registration. Defaults to https://docs.botframework.com/static/devportal/client/images/bot-framework-default.png.</summary>
    [JsonPropertyName("iconUrl")]
    public string? IconUrl { get; set; }

    /// <summary>The supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The Microsoft Application ID for the Bot Channels Registration. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("microsoftAppId")]
    public string? MicrosoftAppId { get; set; }

    /// <summary>Specifies the name of the Bot Channels Registration. Changing this forces a new resource to be created. Must be globally unique.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is the Bot Channels Registration in an isolated network?</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the Bot Channels Registration. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1BotChannelsRegistrationSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1BotChannelsRegistrationSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The SKU of the Bot Channels Registration. Valid values include F0 or S1. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>Is the streaming endpoint enabled for the Bot Channels Registration. Defaults to false.</summary>
    [JsonPropertyName("streamingEndpointEnabled")]
    public bool? StreamingEndpointEnabled { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>The Application Insights API Key to associate with the Bot Channels Registration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelsRegistrationSpecInitProviderDeveloperAppInsightsApiKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelsRegistrationSpecInitProviderResourceGroupNameRefPolicy
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
public partial class V1beta1BotChannelsRegistrationSpecInitProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BotChannelsRegistrationSpecInitProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelsRegistrationSpecInitProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1BotChannelsRegistrationSpecInitProviderResourceGroupNameSelector
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
    public V1beta1BotChannelsRegistrationSpecInitProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelsRegistrationSpecInitProvider
{
    /// <summary>The CMK Key Vault Key URL to encrypt the Bot Channels Registration with the Customer Managed Encryption Key.</summary>
    [JsonPropertyName("cmkKeyVaultUrl")]
    public string? CmkKeyVaultUrl { get; set; }

    /// <summary>The description of the Bot Channels Registration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Application Insights API Key to associate with the Bot Channels Registration.</summary>
    [JsonPropertyName("developerAppInsightsApiKeySecretRef")]
    public V1beta1BotChannelsRegistrationSpecInitProviderDeveloperAppInsightsApiKeySecretRef? DeveloperAppInsightsApiKeySecretRef { get; set; }

    /// <summary>The Application Insights Application ID to associate with the Bot Channels Registration.</summary>
    [JsonPropertyName("developerAppInsightsApplicationId")]
    public string? DeveloperAppInsightsApplicationId { get; set; }

    /// <summary>The Application Insights Key to associate with the Bot Channels Registration.</summary>
    [JsonPropertyName("developerAppInsightsKey")]
    public string? DeveloperAppInsightsKey { get; set; }

    /// <summary>The name of the Bot Channels Registration will be displayed as. This defaults to name if not specified.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The Bot Channels Registration endpoint.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The icon URL to visually identify the Bot Channels Registration. Defaults to https://docs.botframework.com/static/devportal/client/images/bot-framework-default.png.</summary>
    [JsonPropertyName("iconUrl")]
    public string? IconUrl { get; set; }

    /// <summary>The supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The Microsoft Application ID for the Bot Channels Registration. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("microsoftAppId")]
    public string? MicrosoftAppId { get; set; }

    /// <summary>Specifies the name of the Bot Channels Registration. Changing this forces a new resource to be created. Must be globally unique.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is the Bot Channels Registration in an isolated network?</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the Bot Channels Registration. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1BotChannelsRegistrationSpecInitProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1BotChannelsRegistrationSpecInitProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The SKU of the Bot Channels Registration. Valid values include F0 or S1. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>Is the streaming endpoint enabled for the Bot Channels Registration. Defaults to false.</summary>
    [JsonPropertyName("streamingEndpointEnabled")]
    public bool? StreamingEndpointEnabled { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelsRegistrationSpecProviderConfigRef
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
public partial class V1beta1BotChannelsRegistrationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>BotChannelsRegistrationSpec defines the desired state of BotChannelsRegistration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelsRegistrationSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BotChannelsRegistrationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BotChannelsRegistrationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BotChannelsRegistrationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BotChannelsRegistrationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelsRegistrationStatusAtProvider
{
    /// <summary>The CMK Key Vault Key URL to encrypt the Bot Channels Registration with the Customer Managed Encryption Key.</summary>
    [JsonPropertyName("cmkKeyVaultUrl")]
    public string? CmkKeyVaultUrl { get; set; }

    /// <summary>The description of the Bot Channels Registration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Application Insights Application ID to associate with the Bot Channels Registration.</summary>
    [JsonPropertyName("developerAppInsightsApplicationId")]
    public string? DeveloperAppInsightsApplicationId { get; set; }

    /// <summary>The Application Insights Key to associate with the Bot Channels Registration.</summary>
    [JsonPropertyName("developerAppInsightsKey")]
    public string? DeveloperAppInsightsKey { get; set; }

    /// <summary>The name of the Bot Channels Registration will be displayed as. This defaults to name if not specified.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The Bot Channels Registration endpoint.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The icon URL to visually identify the Bot Channels Registration. Defaults to https://docs.botframework.com/static/devportal/client/images/bot-framework-default.png.</summary>
    [JsonPropertyName("iconUrl")]
    public string? IconUrl { get; set; }

    /// <summary>The ID of the Bot Channels Registration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The Microsoft Application ID for the Bot Channels Registration. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("microsoftAppId")]
    public string? MicrosoftAppId { get; set; }

    /// <summary>Specifies the name of the Bot Channels Registration. Changing this forces a new resource to be created. Must be globally unique.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is the Bot Channels Registration in an isolated network?</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the Bot Channels Registration. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The SKU of the Bot Channels Registration. Valid values include F0 or S1. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>Is the streaming endpoint enabled for the Bot Channels Registration. Defaults to false.</summary>
    [JsonPropertyName("streamingEndpointEnabled")]
    public bool? StreamingEndpointEnabled { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelsRegistrationStatusConditions
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

/// <summary>BotChannelsRegistrationStatus defines the observed state of BotChannelsRegistration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotChannelsRegistrationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BotChannelsRegistrationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BotChannelsRegistrationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BotChannelsRegistration is the Schema for the BotChannelsRegistrations API. Manages a Bot Channels Registration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BotChannelsRegistration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BotChannelsRegistrationSpec>, IStatus<V1beta1BotChannelsRegistrationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BotChannelsRegistration";
    public const string KubeGroup = "botservice.azure.m.upbound.io";
    public const string KubePluralName = "botchannelsregistrations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BotChannelsRegistrationSpec defines the desired state of BotChannelsRegistration</summary>
    [JsonPropertyName("spec")]
    public V1beta1BotChannelsRegistrationSpec Spec { get; set; }

    /// <summary>BotChannelsRegistrationStatus defines the observed state of BotChannelsRegistration.</summary>
    [JsonPropertyName("status")]
    public V1beta1BotChannelsRegistrationStatus? Status { get; set; }
}