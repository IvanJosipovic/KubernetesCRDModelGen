using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.m.upbound.io;
/// <summary>SubnetServiceEndpointStoragePolicy is the Schema for the SubnetServiceEndpointStoragePolicys API. Manages a Subnet Service Endpoint Storage Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SubnetServiceEndpointStoragePolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SubnetServiceEndpointStoragePolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SubnetServiceEndpointStoragePolicyList";
    public const string KubeGroup = "network.azure.m.upbound.io";
    public const string KubePluralName = "subnetserviceendpointstoragepolicies";
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
    public IList<V1beta1SubnetServiceEndpointStoragePolicy> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetServiceEndpointStoragePolicySpecForProviderDefinitionServiceResourcesRefsPolicy
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
public partial class V1beta1SubnetServiceEndpointStoragePolicySpecForProviderDefinitionServiceResourcesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubnetServiceEndpointStoragePolicySpecForProviderDefinitionServiceResourcesRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetServiceEndpointStoragePolicySpecForProviderDefinitionServiceResourcesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of ResourceGroup in azure to populate serviceResources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetServiceEndpointStoragePolicySpecForProviderDefinitionServiceResourcesSelector
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
    public V1beta1SubnetServiceEndpointStoragePolicySpecForProviderDefinitionServiceResourcesSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetServiceEndpointStoragePolicySpecForProviderDefinition
{
    /// <summary>The description of this Subnet Service Endpoint Storage Policy Definition.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name which should be used for this Subnet Service Endpoint Storage Policy Definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of service resources. Valid values are Microsoft.Storage or Global. When the service_resources property contains resource IDs, this property must be Microsoft.Storage. When the service_resources property contains Aliases, this property must be Global. Defaults to Microsoft.Storage.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Specifies a list of resources or aliases that this Subnet Service Endpoint Storage Policy Definition applies to.</summary>
    [JsonPropertyName("serviceResources")]
    public IList<string>? ServiceResources { get; set; }

    /// <summary>References to ResourceGroup in azure to populate serviceResources.</summary>
    [JsonPropertyName("serviceResourcesRefs")]
    public IList<V1beta1SubnetServiceEndpointStoragePolicySpecForProviderDefinitionServiceResourcesRefs>? ServiceResourcesRefs { get; set; }

    /// <summary>Selector for a list of ResourceGroup in azure to populate serviceResources.</summary>
    [JsonPropertyName("serviceResourcesSelector")]
    public V1beta1SubnetServiceEndpointStoragePolicySpecForProviderDefinitionServiceResourcesSelector? ServiceResourcesSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetServiceEndpointStoragePolicySpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1SubnetServiceEndpointStoragePolicySpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubnetServiceEndpointStoragePolicySpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetServiceEndpointStoragePolicySpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1SubnetServiceEndpointStoragePolicySpecForProviderResourceGroupNameSelector
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
    public V1beta1SubnetServiceEndpointStoragePolicySpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetServiceEndpointStoragePolicySpecForProvider
{
    /// <summary>A definition block as defined below</summary>
    [JsonPropertyName("definition")]
    public IList<V1beta1SubnetServiceEndpointStoragePolicySpecForProviderDefinition>? Definition { get; set; }

    /// <summary>The Azure Region where the Subnet Service Endpoint Storage Policy should exist. Changing this forces a new Subnet Service Endpoint Storage Policy to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the Resource Group where the Subnet Service Endpoint Storage Policy should exist. Changing this forces a new Subnet Service Endpoint Storage Policy to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1SubnetServiceEndpointStoragePolicySpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1SubnetServiceEndpointStoragePolicySpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Subnet Service Endpoint Storage Policy.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetServiceEndpointStoragePolicySpecInitProviderDefinitionServiceResourcesRefsPolicy
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
public partial class V1beta1SubnetServiceEndpointStoragePolicySpecInitProviderDefinitionServiceResourcesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubnetServiceEndpointStoragePolicySpecInitProviderDefinitionServiceResourcesRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetServiceEndpointStoragePolicySpecInitProviderDefinitionServiceResourcesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of ResourceGroup in azure to populate serviceResources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetServiceEndpointStoragePolicySpecInitProviderDefinitionServiceResourcesSelector
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
    public V1beta1SubnetServiceEndpointStoragePolicySpecInitProviderDefinitionServiceResourcesSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetServiceEndpointStoragePolicySpecInitProviderDefinition
{
    /// <summary>The description of this Subnet Service Endpoint Storage Policy Definition.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name which should be used for this Subnet Service Endpoint Storage Policy Definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of service resources. Valid values are Microsoft.Storage or Global. When the service_resources property contains resource IDs, this property must be Microsoft.Storage. When the service_resources property contains Aliases, this property must be Global. Defaults to Microsoft.Storage.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Specifies a list of resources or aliases that this Subnet Service Endpoint Storage Policy Definition applies to.</summary>
    [JsonPropertyName("serviceResources")]
    public IList<string>? ServiceResources { get; set; }

    /// <summary>References to ResourceGroup in azure to populate serviceResources.</summary>
    [JsonPropertyName("serviceResourcesRefs")]
    public IList<V1beta1SubnetServiceEndpointStoragePolicySpecInitProviderDefinitionServiceResourcesRefs>? ServiceResourcesRefs { get; set; }

    /// <summary>Selector for a list of ResourceGroup in azure to populate serviceResources.</summary>
    [JsonPropertyName("serviceResourcesSelector")]
    public V1beta1SubnetServiceEndpointStoragePolicySpecInitProviderDefinitionServiceResourcesSelector? ServiceResourcesSelector { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetServiceEndpointStoragePolicySpecInitProvider
{
    /// <summary>A definition block as defined below</summary>
    [JsonPropertyName("definition")]
    public IList<V1beta1SubnetServiceEndpointStoragePolicySpecInitProviderDefinition>? Definition { get; set; }

    /// <summary>The Azure Region where the Subnet Service Endpoint Storage Policy should exist. Changing this forces a new Subnet Service Endpoint Storage Policy to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Subnet Service Endpoint Storage Policy.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetServiceEndpointStoragePolicySpecProviderConfigRef
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
public partial class V1beta1SubnetServiceEndpointStoragePolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SubnetServiceEndpointStoragePolicySpec defines the desired state of SubnetServiceEndpointStoragePolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetServiceEndpointStoragePolicySpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SubnetServiceEndpointStoragePolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SubnetServiceEndpointStoragePolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SubnetServiceEndpointStoragePolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SubnetServiceEndpointStoragePolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetServiceEndpointStoragePolicyStatusAtProviderDefinition
{
    /// <summary>The description of this Subnet Service Endpoint Storage Policy Definition.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name which should be used for this Subnet Service Endpoint Storage Policy Definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of service resources. Valid values are Microsoft.Storage or Global. When the service_resources property contains resource IDs, this property must be Microsoft.Storage. When the service_resources property contains Aliases, this property must be Global. Defaults to Microsoft.Storage.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Specifies a list of resources or aliases that this Subnet Service Endpoint Storage Policy Definition applies to.</summary>
    [JsonPropertyName("serviceResources")]
    public IList<string>? ServiceResources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetServiceEndpointStoragePolicyStatusAtProvider
{
    /// <summary>A definition block as defined below</summary>
    [JsonPropertyName("definition")]
    public IList<V1beta1SubnetServiceEndpointStoragePolicyStatusAtProviderDefinition>? Definition { get; set; }

    /// <summary>The ID of the Subnet Service Endpoint Storage Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Azure Region where the Subnet Service Endpoint Storage Policy should exist. Changing this forces a new Subnet Service Endpoint Storage Policy to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the Resource Group where the Subnet Service Endpoint Storage Policy should exist. Changing this forces a new Subnet Service Endpoint Storage Policy to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Subnet Service Endpoint Storage Policy.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetServiceEndpointStoragePolicyStatusConditions
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

/// <summary>SubnetServiceEndpointStoragePolicyStatus defines the observed state of SubnetServiceEndpointStoragePolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubnetServiceEndpointStoragePolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SubnetServiceEndpointStoragePolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SubnetServiceEndpointStoragePolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SubnetServiceEndpointStoragePolicy is the Schema for the SubnetServiceEndpointStoragePolicys API. Manages a Subnet Service Endpoint Storage Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SubnetServiceEndpointStoragePolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SubnetServiceEndpointStoragePolicySpec>, IStatus<V1beta1SubnetServiceEndpointStoragePolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SubnetServiceEndpointStoragePolicy";
    public const string KubeGroup = "network.azure.m.upbound.io";
    public const string KubePluralName = "subnetserviceendpointstoragepolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SubnetServiceEndpointStoragePolicySpec defines the desired state of SubnetServiceEndpointStoragePolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1SubnetServiceEndpointStoragePolicySpec Spec { get; set; }

    /// <summary>SubnetServiceEndpointStoragePolicyStatus defines the observed state of SubnetServiceEndpointStoragePolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1SubnetServiceEndpointStoragePolicyStatus? Status { get; set; }
}