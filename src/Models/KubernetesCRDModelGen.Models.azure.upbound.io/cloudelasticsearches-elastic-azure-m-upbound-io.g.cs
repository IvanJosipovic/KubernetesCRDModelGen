using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.elastic.azure.m.upbound.io;
#nullable enable
/// <summary>CloudElasticsearch is the Schema for the CloudElasticsearchs API. Manages an Elasticsearch cluster in Elastic Cloud.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CloudElasticsearchList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CloudElasticsearch>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CloudElasticsearchList";
    public const string KubeGroup = "elastic.azure.m.upbound.io";
    public const string KubePluralName = "cloudelasticsearches";
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
    public IList<V1beta1CloudElasticsearch> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudElasticsearchSpecForProviderLogsFilteringTag
{
    /// <summary>Specifies the type of action which should be taken when the Tag matches the name and value. Possible values are Exclude and Include.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name which should be used for this Elasticsearch resource. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the value of the Tag which should be filtered.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A logs block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudElasticsearchSpecForProviderLogs
{
    /// <summary>A list of filtering_tag blocks as defined above.</summary>
    [JsonPropertyName("filteringTag")]
    public IList<V1beta1CloudElasticsearchSpecForProviderLogsFilteringTag>? FilteringTag { get; set; }

    /// <summary>Specifies if the Azure Activity Logs should be sent to the Elasticsearch cluster. Defaults to false.</summary>
    [JsonPropertyName("sendActivityLogs")]
    public bool? SendActivityLogs { get; set; }

    /// <summary>Specifies if the AzureAD Logs should be sent to the Elasticsearch cluster. Defaults to false.</summary>
    [JsonPropertyName("sendAzureadLogs")]
    public bool? SendAzureadLogs { get; set; }

    /// <summary>Specifies if the Azure Subscription Logs should be sent to the Elasticsearch cluster. Defaults to false.</summary>
    [JsonPropertyName("sendSubscriptionLogs")]
    public bool? SendSubscriptionLogs { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudElasticsearchSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1CloudElasticsearchSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CloudElasticsearchSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudElasticsearchSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1CloudElasticsearchSpecForProviderResourceGroupNameSelector
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
    public V1beta1CloudElasticsearchSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudElasticsearchSpecForProvider
{
    /// <summary>Specifies the Email Address which should be associated with this Elasticsearch account. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("elasticCloudEmailAddress")]
    public string? ElasticCloudEmailAddress { get; set; }

    /// <summary>The Azure Region where the Elasticsearch resource should exist. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A logs block as defined below.</summary>
    [JsonPropertyName("logs")]
    public V1beta1CloudElasticsearchSpecForProviderLogs? Logs { get; set; }

    /// <summary>Specifies if the Elasticsearch should have monitoring configured? Defaults to true. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("monitoringEnabled")]
    public bool? MonitoringEnabled { get; set; }

    /// <summary>The name of the Resource Group where the Elasticsearch resource should exist. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1CloudElasticsearchSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1CloudElasticsearchSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Specifies the name of the SKU for this Elasticsearch. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Elasticsearch resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudElasticsearchSpecInitProviderLogsFilteringTag
{
    /// <summary>Specifies the type of action which should be taken when the Tag matches the name and value. Possible values are Exclude and Include.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name which should be used for this Elasticsearch resource. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the value of the Tag which should be filtered.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A logs block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudElasticsearchSpecInitProviderLogs
{
    /// <summary>A list of filtering_tag blocks as defined above.</summary>
    [JsonPropertyName("filteringTag")]
    public IList<V1beta1CloudElasticsearchSpecInitProviderLogsFilteringTag>? FilteringTag { get; set; }

    /// <summary>Specifies if the Azure Activity Logs should be sent to the Elasticsearch cluster. Defaults to false.</summary>
    [JsonPropertyName("sendActivityLogs")]
    public bool? SendActivityLogs { get; set; }

    /// <summary>Specifies if the AzureAD Logs should be sent to the Elasticsearch cluster. Defaults to false.</summary>
    [JsonPropertyName("sendAzureadLogs")]
    public bool? SendAzureadLogs { get; set; }

    /// <summary>Specifies if the Azure Subscription Logs should be sent to the Elasticsearch cluster. Defaults to false.</summary>
    [JsonPropertyName("sendSubscriptionLogs")]
    public bool? SendSubscriptionLogs { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudElasticsearchSpecInitProvider
{
    /// <summary>Specifies the Email Address which should be associated with this Elasticsearch account. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("elasticCloudEmailAddress")]
    public string? ElasticCloudEmailAddress { get; set; }

    /// <summary>The Azure Region where the Elasticsearch resource should exist. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A logs block as defined below.</summary>
    [JsonPropertyName("logs")]
    public V1beta1CloudElasticsearchSpecInitProviderLogs? Logs { get; set; }

    /// <summary>Specifies if the Elasticsearch should have monitoring configured? Defaults to true. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("monitoringEnabled")]
    public bool? MonitoringEnabled { get; set; }

    /// <summary>Specifies the name of the SKU for this Elasticsearch. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Elasticsearch resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudElasticsearchSpecProviderConfigRef
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
public partial class V1beta1CloudElasticsearchSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CloudElasticsearchSpec defines the desired state of CloudElasticsearch</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudElasticsearchSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CloudElasticsearchSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CloudElasticsearchSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CloudElasticsearchSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CloudElasticsearchSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudElasticsearchStatusAtProviderLogsFilteringTag
{
    /// <summary>Specifies the type of action which should be taken when the Tag matches the name and value. Possible values are Exclude and Include.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name which should be used for this Elasticsearch resource. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the value of the Tag which should be filtered.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A logs block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudElasticsearchStatusAtProviderLogs
{
    /// <summary>A list of filtering_tag blocks as defined above.</summary>
    [JsonPropertyName("filteringTag")]
    public IList<V1beta1CloudElasticsearchStatusAtProviderLogsFilteringTag>? FilteringTag { get; set; }

    /// <summary>Specifies if the Azure Activity Logs should be sent to the Elasticsearch cluster. Defaults to false.</summary>
    [JsonPropertyName("sendActivityLogs")]
    public bool? SendActivityLogs { get; set; }

    /// <summary>Specifies if the AzureAD Logs should be sent to the Elasticsearch cluster. Defaults to false.</summary>
    [JsonPropertyName("sendAzureadLogs")]
    public bool? SendAzureadLogs { get; set; }

    /// <summary>Specifies if the Azure Subscription Logs should be sent to the Elasticsearch cluster. Defaults to false.</summary>
    [JsonPropertyName("sendSubscriptionLogs")]
    public bool? SendSubscriptionLogs { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudElasticsearchStatusAtProvider
{
    /// <summary>The ID of the Deployment within Elastic Cloud.</summary>
    [JsonPropertyName("elasticCloudDeploymentId")]
    public string? ElasticCloudDeploymentId { get; set; }

    /// <summary>Specifies the Email Address which should be associated with this Elasticsearch account. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("elasticCloudEmailAddress")]
    public string? ElasticCloudEmailAddress { get; set; }

    /// <summary>The Default URL used for Single Sign On (SSO) to Elastic Cloud.</summary>
    [JsonPropertyName("elasticCloudSsoDefaultUrl")]
    public string? ElasticCloudSsoDefaultUrl { get; set; }

    /// <summary>The ID of the User Account within Elastic Cloud.</summary>
    [JsonPropertyName("elasticCloudUserId")]
    public string? ElasticCloudUserId { get; set; }

    /// <summary>The URL to the Elasticsearch Service associated with this Elasticsearch.</summary>
    [JsonPropertyName("elasticsearchServiceUrl")]
    public string? ElasticsearchServiceUrl { get; set; }

    /// <summary>The ID of the Elasticsearch.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The URL to the Kibana Dashboard associated with this Elasticsearch.</summary>
    [JsonPropertyName("kibanaServiceUrl")]
    public string? KibanaServiceUrl { get; set; }

    /// <summary>The URI used for SSO to the Kibana Dashboard associated with this Elasticsearch.</summary>
    [JsonPropertyName("kibanaSsoUri")]
    public string? KibanaSsoUri { get; set; }

    /// <summary>The Azure Region where the Elasticsearch resource should exist. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A logs block as defined below.</summary>
    [JsonPropertyName("logs")]
    public V1beta1CloudElasticsearchStatusAtProviderLogs? Logs { get; set; }

    /// <summary>Specifies if the Elasticsearch should have monitoring configured? Defaults to true. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("monitoringEnabled")]
    public bool? MonitoringEnabled { get; set; }

    /// <summary>The name of the Resource Group where the Elasticsearch resource should exist. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Specifies the name of the SKU for this Elasticsearch. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Elasticsearch resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudElasticsearchStatusConditions
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
/// <summary>CloudElasticsearchStatus defines the observed state of CloudElasticsearch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudElasticsearchStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CloudElasticsearchStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CloudElasticsearchStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CloudElasticsearch is the Schema for the CloudElasticsearchs API. Manages an Elasticsearch cluster in Elastic Cloud.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CloudElasticsearch : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CloudElasticsearchSpec>, IStatus<V1beta1CloudElasticsearchStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CloudElasticsearch";
    public const string KubeGroup = "elastic.azure.m.upbound.io";
    public const string KubePluralName = "cloudelasticsearches";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CloudElasticsearchSpec defines the desired state of CloudElasticsearch</summary>
    [JsonPropertyName("spec")]
    public V1beta1CloudElasticsearchSpec Spec { get; set; }

    /// <summary>CloudElasticsearchStatus defines the observed state of CloudElasticsearch.</summary>
    [JsonPropertyName("status")]
    public V1beta1CloudElasticsearchStatus? Status { get; set; }
}
#nullable disable
