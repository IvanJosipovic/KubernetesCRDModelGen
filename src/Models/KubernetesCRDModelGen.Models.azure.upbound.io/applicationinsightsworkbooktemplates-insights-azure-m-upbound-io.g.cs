using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.m.upbound.io;
#nullable enable
/// <summary>ApplicationInsightsWorkbookTemplate is the Schema for the ApplicationInsightsWorkbookTemplates API. Manages an Application Insights Workbook Template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ApplicationInsightsWorkbookTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ApplicationInsightsWorkbookTemplate>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ApplicationInsightsWorkbookTemplateList";
    public const string KubeGroup = "insights.azure.m.upbound.io";
    public const string KubePluralName = "applicationinsightsworkbooktemplates";
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
    public IList<V1beta1ApplicationInsightsWorkbookTemplate> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsWorkbookTemplateSpecForProviderGalleries
{
    /// <summary>Category for the gallery.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>Name of the workbook template in the gallery.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Order of the template within the gallery. Defaults to 0.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Azure resource type supported by the gallery. Defaults to Azure Monitor.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>Type of workbook supported by the workbook template. Defaults to workbook.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsWorkbookTemplateSpecForProviderResourceGroupNameRefPolicy
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
/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsWorkbookTemplateSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationInsightsWorkbookTemplateSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsWorkbookTemplateSpecForProviderResourceGroupNameSelectorPolicy
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
/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsWorkbookTemplateSpecForProviderResourceGroupNameSelector
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
    public V1beta1ApplicationInsightsWorkbookTemplateSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsWorkbookTemplateSpecForProvider
{
    /// <summary>Information about the author of the workbook template.</summary>
    [JsonPropertyName("author")]
    public string? Author { get; set; }

    /// <summary>A galleries block as defined below.</summary>
    [JsonPropertyName("galleries")]
    public IList<V1beta1ApplicationInsightsWorkbookTemplateSpecForProviderGalleries>? Galleries { get; set; }

    /// <summary>Key value pairs of localized gallery. Each key is the locale code of languages supported by the Azure portal.</summary>
    [JsonPropertyName("localized")]
    public string? Localized { get; set; }

    /// <summary>Specifies the Azure Region where the Application Insights Workbook Template should exist. Changing this forces a new Application Insights Workbook Template to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the name which should be used for this Application Insights Workbook Template. Changing this forces a new Application Insights Workbook Template to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority of the template. Determines which template to open when a workbook gallery is opened in viewer mode. Defaults to 0.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Specifies the name of the Resource Group where the Application Insights Workbook Template should exist. Changing this forces a new Application Insights Workbook Template to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1ApplicationInsightsWorkbookTemplateSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1ApplicationInsightsWorkbookTemplateSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Application Insights Workbook Template.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Valid JSON object containing workbook template payload.</summary>
    [JsonPropertyName("templateData")]
    public string? TemplateData { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsWorkbookTemplateSpecInitProviderGalleries
{
    /// <summary>Category for the gallery.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>Name of the workbook template in the gallery.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Order of the template within the gallery. Defaults to 0.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Azure resource type supported by the gallery. Defaults to Azure Monitor.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>Type of workbook supported by the workbook template. Defaults to workbook.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsWorkbookTemplateSpecInitProviderResourceGroupNameRefPolicy
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
/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsWorkbookTemplateSpecInitProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationInsightsWorkbookTemplateSpecInitProviderResourceGroupNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsWorkbookTemplateSpecInitProviderResourceGroupNameSelectorPolicy
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
/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsWorkbookTemplateSpecInitProviderResourceGroupNameSelector
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
    public V1beta1ApplicationInsightsWorkbookTemplateSpecInitProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsWorkbookTemplateSpecInitProvider
{
    /// <summary>Information about the author of the workbook template.</summary>
    [JsonPropertyName("author")]
    public string? Author { get; set; }

    /// <summary>A galleries block as defined below.</summary>
    [JsonPropertyName("galleries")]
    public IList<V1beta1ApplicationInsightsWorkbookTemplateSpecInitProviderGalleries>? Galleries { get; set; }

    /// <summary>Key value pairs of localized gallery. Each key is the locale code of languages supported by the Azure portal.</summary>
    [JsonPropertyName("localized")]
    public string? Localized { get; set; }

    /// <summary>Specifies the Azure Region where the Application Insights Workbook Template should exist. Changing this forces a new Application Insights Workbook Template to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the name which should be used for this Application Insights Workbook Template. Changing this forces a new Application Insights Workbook Template to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority of the template. Determines which template to open when a workbook gallery is opened in viewer mode. Defaults to 0.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Specifies the name of the Resource Group where the Application Insights Workbook Template should exist. Changing this forces a new Application Insights Workbook Template to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1ApplicationInsightsWorkbookTemplateSpecInitProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1ApplicationInsightsWorkbookTemplateSpecInitProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Application Insights Workbook Template.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Valid JSON object containing workbook template payload.</summary>
    [JsonPropertyName("templateData")]
    public string? TemplateData { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsWorkbookTemplateSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsWorkbookTemplateSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ApplicationInsightsWorkbookTemplateSpec defines the desired state of ApplicationInsightsWorkbookTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsWorkbookTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ApplicationInsightsWorkbookTemplateSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ApplicationInsightsWorkbookTemplateSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ApplicationInsightsWorkbookTemplateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ApplicationInsightsWorkbookTemplateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsWorkbookTemplateStatusAtProviderGalleries
{
    /// <summary>Category for the gallery.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>Name of the workbook template in the gallery.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Order of the template within the gallery. Defaults to 0.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Azure resource type supported by the gallery. Defaults to Azure Monitor.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>Type of workbook supported by the workbook template. Defaults to workbook.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsWorkbookTemplateStatusAtProvider
{
    /// <summary>Information about the author of the workbook template.</summary>
    [JsonPropertyName("author")]
    public string? Author { get; set; }

    /// <summary>A galleries block as defined below.</summary>
    [JsonPropertyName("galleries")]
    public IList<V1beta1ApplicationInsightsWorkbookTemplateStatusAtProviderGalleries>? Galleries { get; set; }

    /// <summary>The ID of the Application Insights Workbook Template.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Key value pairs of localized gallery. Each key is the locale code of languages supported by the Azure portal.</summary>
    [JsonPropertyName("localized")]
    public string? Localized { get; set; }

    /// <summary>Specifies the Azure Region where the Application Insights Workbook Template should exist. Changing this forces a new Application Insights Workbook Template to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the name which should be used for this Application Insights Workbook Template. Changing this forces a new Application Insights Workbook Template to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority of the template. Determines which template to open when a workbook gallery is opened in viewer mode. Defaults to 0.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Specifies the name of the Resource Group where the Application Insights Workbook Template should exist. Changing this forces a new Application Insights Workbook Template to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Application Insights Workbook Template.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Valid JSON object containing workbook template payload.</summary>
    [JsonPropertyName("templateData")]
    public string? TemplateData { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsWorkbookTemplateStatusConditions
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
/// <summary>ApplicationInsightsWorkbookTemplateStatus defines the observed state of ApplicationInsightsWorkbookTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationInsightsWorkbookTemplateStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ApplicationInsightsWorkbookTemplateStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ApplicationInsightsWorkbookTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ApplicationInsightsWorkbookTemplate is the Schema for the ApplicationInsightsWorkbookTemplates API. Manages an Application Insights Workbook Template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ApplicationInsightsWorkbookTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ApplicationInsightsWorkbookTemplateSpec>, IStatus<V1beta1ApplicationInsightsWorkbookTemplateStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ApplicationInsightsWorkbookTemplate";
    public const string KubeGroup = "insights.azure.m.upbound.io";
    public const string KubePluralName = "applicationinsightsworkbooktemplates";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ApplicationInsightsWorkbookTemplateSpec defines the desired state of ApplicationInsightsWorkbookTemplate</summary>
    [JsonPropertyName("spec")]
    public V1beta1ApplicationInsightsWorkbookTemplateSpec Spec { get; set; }

    /// <summary>ApplicationInsightsWorkbookTemplateStatus defines the observed state of ApplicationInsightsWorkbookTemplate.</summary>
    [JsonPropertyName("status")]
    public V1beta1ApplicationInsightsWorkbookTemplateStatus? Status { get; set; }
}
#nullable disable
