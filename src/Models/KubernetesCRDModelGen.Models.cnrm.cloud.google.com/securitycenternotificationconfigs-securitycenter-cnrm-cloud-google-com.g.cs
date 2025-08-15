using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.securitycenter.cnrm.cloud.google.com;
/// <summary>The organization that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityCenterNotificationConfigSpecOrganizationRef
{
    /// <summary>Allowed value: The `name` field of an `Organization` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The config for triggering streaming-based notifications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityCenterNotificationConfigSpecStreamingConfig
{
    /// <summary>Expression that defines the filter to apply across create/update events of assets or findings as specified by the event type. The expression is a list of zero or more restrictions combined via logical operators AND and OR. Parentheses are supported, and OR has higher precedence than AND.  Restrictions have the form &lt;field&gt; &lt;operator&gt; &lt;value&gt; and may have a - character in front of them to indicate negation. The fields map to those defined in the corresponding resource.  The supported operators are:  * = for all value types. * &gt;, &lt;, &gt;=, &lt;= for integer values. * :, meaning substring matching, for strings.  The supported value types are:  * string literals in quotes. * integer literals without quotes. * boolean literals true and false without quotes.  See [Filtering notifications](https://cloud.google.com/security-command-center/docs/how-to-api-filter-notifications) for information on how to write a filter.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityCenterNotificationConfigSpec
{
    /// <summary>Immutable. This must be unique within the organization.</summary>
    [JsonPropertyName("configId")]
    public string ConfigId { get; set; }

    /// <summary>The description of the notification config (max of 1024 characters).</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The organization that this resource belongs to.</summary>
    [JsonPropertyName("organizationRef")]
    public V1alpha1SecurityCenterNotificationConfigSpecOrganizationRef OrganizationRef { get; set; }

    /// <summary>The Pub/Sub topic to send notifications to. Its format is "projects/[project_id]/topics/[topic]".</summary>
    [JsonPropertyName("pubsubTopic")]
    public string PubsubTopic { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The config for triggering streaming-based notifications.</summary>
    [JsonPropertyName("streamingConfig")]
    public V1alpha1SecurityCenterNotificationConfigSpecStreamingConfig StreamingConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityCenterNotificationConfigStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityCenterNotificationConfigStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SecurityCenterNotificationConfigStatusConditions>? Conditions { get; set; }

    /// <summary>The resource name of this notification config, in the format 'organizations/{{organization}}/notificationConfigs/{{config_id}}'.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The service account that needs "pubsub.topics.publish" permission to publish to the Pub/Sub topic.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecurityCenterNotificationConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SecurityCenterNotificationConfigSpec>, IStatus<V1alpha1SecurityCenterNotificationConfigStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecurityCenterNotificationConfig";
    public const string KubeGroup = "securitycenter.cnrm.cloud.google.com";
    public const string KubePluralName = "securitycenternotificationconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1SecurityCenterNotificationConfigSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1SecurityCenterNotificationConfigStatus? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecurityCenterNotificationConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SecurityCenterNotificationConfig>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecurityCenterNotificationConfigList";
    public const string KubeGroup = "securitycenter.cnrm.cloud.google.com";
    public const string KubePluralName = "securitycenternotificationconfigs";
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
    public IList<V1alpha1SecurityCenterNotificationConfig> Items { get; set; }
}