using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.serviceusage.cnrm.cloud.google.com;
public partial class V1alpha1ServiceUsageConsumerQuotaOverrideSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1alpha1ServiceUsageConsumerQuotaOverrideSpec
{
    /// <summary>Immutable. If this map is nonempty, then this override applies only to specific values for dimensions defined in the limit unit.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>If the new quota would decrease the existing quota by more than 10%, the request is rejected. If 'force' is 'true', that safety check is ignored.</summary>
    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    /// <summary>Immutable. The limit on the metric, e.g. '/project/region'.  ~&gt; Make sure that 'limit' is in a format that doesn't start with '1/' or contain curly braces. E.g. use '/project/user' instead of '1/{project}/{user}'.</summary>
    [JsonPropertyName("limit")]
    public string Limit { get; set; }

    /// <summary>Immutable. The metric that should be limited, e.g. 'compute.googleapis.com/cpus'.</summary>
    [JsonPropertyName("metric")]
    public string Metric { get; set; }

    /// <summary>The overriding quota limit value. Can be any nonnegative integer, or -1 (unlimited quota).</summary>
    [JsonPropertyName("overrideValue")]
    public string OverrideValue { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1ServiceUsageConsumerQuotaOverrideSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. The service that the metrics belong to, e.g. 'compute.googleapis.com'.</summary>
    [JsonPropertyName("service")]
    public string Service { get; set; }
}

public partial class V1alpha1ServiceUsageConsumerQuotaOverrideStatusConditions
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

public partial class V1alpha1ServiceUsageConsumerQuotaOverrideStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ServiceUsageConsumerQuotaOverrideStatusConditions>? Conditions { get; set; }

    /// <summary>The server-generated name of the quota override.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ServiceUsageConsumerQuotaOverride : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ServiceUsageConsumerQuotaOverrideSpec>, IStatus<V1alpha1ServiceUsageConsumerQuotaOverrideStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ServiceUsageConsumerQuotaOverride";
    public const string KubeGroup = "serviceusage.cnrm.cloud.google.com";
    public const string KubePluralName = "serviceusageconsumerquotaoverrides";
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
    public V1alpha1ServiceUsageConsumerQuotaOverrideSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1ServiceUsageConsumerQuotaOverrideStatus? Status { get; set; }
}