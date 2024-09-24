using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquerydatapolicy.cnrm.cloud.google.com;
public partial class V1alpha1BigQueryDataPolicyDataPolicySpecDataMaskingPolicy
{
    /// <summary>The available masking rules. Learn more here: https://cloud.google.com/bigquery/docs/column-data-masking-intro#masking_options. Possible values: ["SHA256", "ALWAYS_NULL", "DEFAULT_MASKING_VALUE", "LAST_FOUR_CHARACTERS", "FIRST_FOUR_CHARACTERS", "EMAIL_MASK", "DATE_YEAR_MASK"].</summary>
    [JsonPropertyName("predefinedExpression")]
    public string PredefinedExpression { get; set; }
}

public partial class V1alpha1BigQueryDataPolicyDataPolicySpecProjectRef
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

public partial class V1alpha1BigQueryDataPolicyDataPolicySpec
{
    /// <summary>The data masking policy that specifies the data masking rule to use.</summary>
    [JsonPropertyName("dataMaskingPolicy")]
    public V1alpha1BigQueryDataPolicyDataPolicySpecDataMaskingPolicy? DataMaskingPolicy { get; set; }

    /// <summary>The enrollment level of the service. Possible values: ["COLUMN_LEVEL_SECURITY_POLICY", "DATA_MASKING_POLICY"].</summary>
    [JsonPropertyName("dataPolicyType")]
    public string DataPolicyType { get; set; }

    /// <summary>Immutable. The name of the location of the data policy.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Policy tag resource name, in the format of projects/{project_number}/locations/{locationId}/taxonomies/{taxonomyId}/policyTags/{policyTag_id}.</summary>
    [JsonPropertyName("policyTag")]
    public string PolicyTag { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1BigQueryDataPolicyDataPolicySpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The dataPolicyId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

public partial class V1alpha1BigQueryDataPolicyDataPolicyStatusConditions
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

public partial class V1alpha1BigQueryDataPolicyDataPolicyStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BigQueryDataPolicyDataPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>Resource name of this data policy, in the format of projects/{project_number}/locations/{locationId}/dataPolicies/{dataPolicyId}.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigQueryDataPolicyDataPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BigQueryDataPolicyDataPolicySpec>, IStatus<V1alpha1BigQueryDataPolicyDataPolicyStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigQueryDataPolicyDataPolicy";
    public const string KubeGroup = "bigquerydatapolicy.cnrm.cloud.google.com";
    public const string KubePluralName = "bigquerydatapolicydatapolicies";
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
    public V1alpha1BigQueryDataPolicyDataPolicySpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1BigQueryDataPolicyDataPolicyStatus? Status { get; set; }
}