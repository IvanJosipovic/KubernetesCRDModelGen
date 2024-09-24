using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquery.gcp.upbound.io;
public enum V1beta1DatasetAccessSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1DatasetAccessSpecForProviderDatasetDatasetDatasetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecForProviderDatasetDatasetDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecForProviderDatasetDatasetDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderDatasetDatasetDatasetIdRefPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecForProviderDatasetDatasetDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderDatasetDatasetDatasetIdRefPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecForProviderDatasetDatasetDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecForProviderDatasetDatasetDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecForProviderDatasetDatasetDatasetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecForProviderDatasetDatasetDatasetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecForProviderDatasetDatasetDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecForProviderDatasetDatasetDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderDatasetDatasetDatasetIdSelectorPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecForProviderDatasetDatasetDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderDatasetDatasetDatasetIdSelectorPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecForProviderDatasetDatasetDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecForProviderDatasetDatasetDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecForProviderDatasetDatasetDatasetIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1DatasetAccessSpecForProviderDatasetDataset
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1DatasetAccessSpecForProviderDatasetDatasetDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1DatasetAccessSpecForProviderDatasetDatasetDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

public partial class V1beta1DatasetAccessSpecForProviderDataset
{
    /// <summary>The dataset this entry applies to Structure is documented below.</summary>
    [JsonPropertyName("dataset")]
    public IList<V1beta1DatasetAccessSpecForProviderDatasetDataset>? Dataset { get; set; }

    /// <summary>Which resources in the dataset this entry applies to. Currently, only views are supported, but additional target types may be added in the future. Possible values: VIEWS</summary>
    [JsonPropertyName("targetTypes")]
    public IList<string>? TargetTypes { get; set; }
}

public enum V1beta1DatasetAccessSpecForProviderDatasetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecForProviderDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecForProviderDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderDatasetIdRefPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecForProviderDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderDatasetIdRefPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecForProviderDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecForProviderDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecForProviderDatasetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecForProviderDatasetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecForProviderDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecForProviderDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderDatasetIdSelectorPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecForProviderDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderDatasetIdSelectorPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecForProviderDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecForProviderDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecForProviderDatasetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecForProviderRoutineDatasetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecForProviderRoutineDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecForProviderRoutineDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderRoutineDatasetIdRefPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecForProviderRoutineDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderRoutineDatasetIdRefPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecForProviderRoutineDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecForProviderRoutineDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecForProviderRoutineDatasetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecForProviderRoutineDatasetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecForProviderRoutineDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecForProviderRoutineDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderRoutineDatasetIdSelectorPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecForProviderRoutineDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderRoutineDatasetIdSelectorPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecForProviderRoutineDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecForProviderRoutineDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecForProviderRoutineDatasetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecForProviderRoutineProjectIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecForProviderRoutineProjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecForProviderRoutineProjectIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderRoutineProjectIdRefPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecForProviderRoutineProjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderRoutineProjectIdRefPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecForProviderRoutineProjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecForProviderRoutineProjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecForProviderRoutineProjectIdRefPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecForProviderRoutineProjectIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecForProviderRoutineProjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecForProviderRoutineProjectIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderRoutineProjectIdSelectorPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecForProviderRoutineProjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderRoutineProjectIdSelectorPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecForProviderRoutineProjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecForProviderRoutineProjectIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecForProviderRoutineProjectIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecForProviderRoutineRoutineIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecForProviderRoutineRoutineIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecForProviderRoutineRoutineIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderRoutineRoutineIdRefPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecForProviderRoutineRoutineIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderRoutineRoutineIdRefPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecForProviderRoutineRoutineIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecForProviderRoutineRoutineIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecForProviderRoutineRoutineIdRefPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecForProviderRoutineRoutineIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecForProviderRoutineRoutineIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecForProviderRoutineRoutineIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderRoutineRoutineIdSelectorPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecForProviderRoutineRoutineIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderRoutineRoutineIdSelectorPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecForProviderRoutineRoutineIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecForProviderRoutineRoutineIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecForProviderRoutineRoutineIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1DatasetAccessSpecForProviderRoutine
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Routine in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1DatasetAccessSpecForProviderRoutineDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Routine in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1DatasetAccessSpecForProviderRoutineDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Reference to a Routine in bigquery to populate projectId.</summary>
    [JsonPropertyName("projectIdRef")]
    public V1beta1DatasetAccessSpecForProviderRoutineProjectIdRef? ProjectIdRef { get; set; }

    /// <summary>Selector for a Routine in bigquery to populate projectId.</summary>
    [JsonPropertyName("projectIdSelector")]
    public V1beta1DatasetAccessSpecForProviderRoutineProjectIdSelector? ProjectIdSelector { get; set; }

    /// <summary>The ID of the routine. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 256 characters.</summary>
    [JsonPropertyName("routineId")]
    public string? RoutineId { get; set; }

    /// <summary>Reference to a Routine in bigquery to populate routineId.</summary>
    [JsonPropertyName("routineIdRef")]
    public V1beta1DatasetAccessSpecForProviderRoutineRoutineIdRef? RoutineIdRef { get; set; }

    /// <summary>Selector for a Routine in bigquery to populate routineId.</summary>
    [JsonPropertyName("routineIdSelector")]
    public V1beta1DatasetAccessSpecForProviderRoutineRoutineIdSelector? RoutineIdSelector { get; set; }
}

public enum V1beta1DatasetAccessSpecForProviderUserByEmailRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecForProviderUserByEmailRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecForProviderUserByEmailRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderUserByEmailRefPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecForProviderUserByEmailRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderUserByEmailRefPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecForProviderUserByEmailRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecForProviderUserByEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecForProviderUserByEmailRefPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecForProviderUserByEmailSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecForProviderUserByEmailSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecForProviderUserByEmailSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderUserByEmailSelectorPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecForProviderUserByEmailSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderUserByEmailSelectorPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecForProviderUserByEmailSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecForProviderUserByEmailSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecForProviderUserByEmailSelectorPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecForProviderViewDatasetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecForProviderViewDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecForProviderViewDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderViewDatasetIdRefPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecForProviderViewDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderViewDatasetIdRefPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecForProviderViewDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecForProviderViewDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecForProviderViewDatasetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecForProviderViewDatasetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecForProviderViewDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecForProviderViewDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderViewDatasetIdSelectorPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecForProviderViewDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderViewDatasetIdSelectorPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecForProviderViewDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecForProviderViewDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecForProviderViewDatasetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecForProviderViewTableIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecForProviderViewTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecForProviderViewTableIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderViewTableIdRefPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecForProviderViewTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderViewTableIdRefPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecForProviderViewTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecForProviderViewTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecForProviderViewTableIdRefPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecForProviderViewTableIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecForProviderViewTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecForProviderViewTableIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderViewTableIdSelectorPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecForProviderViewTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecForProviderViewTableIdSelectorPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecForProviderViewTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecForProviderViewTableIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecForProviderViewTableIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1DatasetAccessSpecForProviderView
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1DatasetAccessSpecForProviderViewDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1DatasetAccessSpecForProviderViewDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The ID of the table. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta1DatasetAccessSpecForProviderViewTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta1DatasetAccessSpecForProviderViewTableIdSelector? TableIdSelector { get; set; }
}

public partial class V1beta1DatasetAccessSpecForProvider
{
    /// <summary>Grants all resources of particular types in a particular dataset read access to the current dataset. Structure is documented below.</summary>
    [JsonPropertyName("dataset")]
    public IList<V1beta1DatasetAccessSpecForProviderDataset>? Dataset { get; set; }

    /// <summary>A unique ID for this dataset, without the project name. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1DatasetAccessSpecForProviderDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1DatasetAccessSpecForProviderDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>A domain to grant access to. Any users signed in with the domain specified will be granted the specified access</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>An email address of a Google Group to grant access to.</summary>
    [JsonPropertyName("groupByEmail")]
    public string? GroupByEmail { get; set; }

    /// <summary>Some other type of member that appears in the IAM Policy but isn't a user, group, domain, or special group. For example: allUsers</summary>
    [JsonPropertyName("iamMember")]
    public string? IamMember { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Describes the rights granted to the user specified by the other member of the access object. Basic, predefined, and custom roles are supported. Predefined roles that have equivalent basic roles are swapped by the API to their basic counterparts, and will show a diff post-create. See official docs.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>A routine from a different dataset to grant access to. Queries executed against that routine will have read access to tables in this dataset. The role field is not required when this field is set. If that routine is updated by any user, access to the routine needs to be granted again via an update operation. Structure is documented below.</summary>
    [JsonPropertyName("routine")]
    public IList<V1beta1DatasetAccessSpecForProviderRoutine>? Routine { get; set; }

    /// <summary>A special group to grant access to. Possible values include:</summary>
    [JsonPropertyName("specialGroup")]
    public string? SpecialGroup { get; set; }

    /// <summary>An email address of a user to grant access to. For example: fred@example.com</summary>
    [JsonPropertyName("userByEmail")]
    public string? UserByEmail { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate userByEmail.</summary>
    [JsonPropertyName("userByEmailRef")]
    public V1beta1DatasetAccessSpecForProviderUserByEmailRef? UserByEmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate userByEmail.</summary>
    [JsonPropertyName("userByEmailSelector")]
    public V1beta1DatasetAccessSpecForProviderUserByEmailSelector? UserByEmailSelector { get; set; }

    /// <summary>A view from a different dataset to grant access to. Queries executed against that view will have read access to tables in this dataset. The role field is not required when this field is set. If that view is updated by any user, access to the view needs to be granted again via an update operation. Structure is documented below.</summary>
    [JsonPropertyName("view")]
    public IList<V1beta1DatasetAccessSpecForProviderView>? View { get; set; }
}

public enum V1beta1DatasetAccessSpecInitProviderDatasetDatasetDatasetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecInitProviderDatasetDatasetDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecInitProviderDatasetDatasetDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderDatasetDatasetDatasetIdRefPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecInitProviderDatasetDatasetDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderDatasetDatasetDatasetIdRefPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecInitProviderDatasetDatasetDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecInitProviderDatasetDatasetDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecInitProviderDatasetDatasetDatasetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecInitProviderDatasetDatasetDatasetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecInitProviderDatasetDatasetDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecInitProviderDatasetDatasetDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderDatasetDatasetDatasetIdSelectorPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecInitProviderDatasetDatasetDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderDatasetDatasetDatasetIdSelectorPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecInitProviderDatasetDatasetDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecInitProviderDatasetDatasetDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecInitProviderDatasetDatasetDatasetIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1DatasetAccessSpecInitProviderDatasetDataset
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1DatasetAccessSpecInitProviderDatasetDatasetDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1DatasetAccessSpecInitProviderDatasetDatasetDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

public partial class V1beta1DatasetAccessSpecInitProviderDataset
{
    /// <summary>The dataset this entry applies to Structure is documented below.</summary>
    [JsonPropertyName("dataset")]
    public IList<V1beta1DatasetAccessSpecInitProviderDatasetDataset>? Dataset { get; set; }

    /// <summary>Which resources in the dataset this entry applies to. Currently, only views are supported, but additional target types may be added in the future. Possible values: VIEWS</summary>
    [JsonPropertyName("targetTypes")]
    public IList<string>? TargetTypes { get; set; }
}

public enum V1beta1DatasetAccessSpecInitProviderDatasetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecInitProviderDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecInitProviderDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderDatasetIdRefPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecInitProviderDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderDatasetIdRefPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecInitProviderDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecInitProviderDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecInitProviderDatasetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecInitProviderDatasetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecInitProviderDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecInitProviderDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderDatasetIdSelectorPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecInitProviderDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderDatasetIdSelectorPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecInitProviderDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecInitProviderDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecInitProviderDatasetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecInitProviderRoutineDatasetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecInitProviderRoutineDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecInitProviderRoutineDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderRoutineDatasetIdRefPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecInitProviderRoutineDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderRoutineDatasetIdRefPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecInitProviderRoutineDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecInitProviderRoutineDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecInitProviderRoutineDatasetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecInitProviderRoutineDatasetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecInitProviderRoutineDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecInitProviderRoutineDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderRoutineDatasetIdSelectorPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecInitProviderRoutineDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderRoutineDatasetIdSelectorPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecInitProviderRoutineDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecInitProviderRoutineDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecInitProviderRoutineDatasetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecInitProviderRoutineProjectIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecInitProviderRoutineProjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecInitProviderRoutineProjectIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderRoutineProjectIdRefPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecInitProviderRoutineProjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderRoutineProjectIdRefPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecInitProviderRoutineProjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecInitProviderRoutineProjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecInitProviderRoutineProjectIdRefPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecInitProviderRoutineProjectIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecInitProviderRoutineProjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecInitProviderRoutineProjectIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderRoutineProjectIdSelectorPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecInitProviderRoutineProjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderRoutineProjectIdSelectorPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecInitProviderRoutineProjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecInitProviderRoutineProjectIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecInitProviderRoutineProjectIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecInitProviderRoutineRoutineIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecInitProviderRoutineRoutineIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecInitProviderRoutineRoutineIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderRoutineRoutineIdRefPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecInitProviderRoutineRoutineIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderRoutineRoutineIdRefPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecInitProviderRoutineRoutineIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecInitProviderRoutineRoutineIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecInitProviderRoutineRoutineIdRefPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecInitProviderRoutineRoutineIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecInitProviderRoutineRoutineIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecInitProviderRoutineRoutineIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderRoutineRoutineIdSelectorPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecInitProviderRoutineRoutineIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderRoutineRoutineIdSelectorPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecInitProviderRoutineRoutineIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecInitProviderRoutineRoutineIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecInitProviderRoutineRoutineIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1DatasetAccessSpecInitProviderRoutine
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Routine in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1DatasetAccessSpecInitProviderRoutineDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Routine in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1DatasetAccessSpecInitProviderRoutineDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Reference to a Routine in bigquery to populate projectId.</summary>
    [JsonPropertyName("projectIdRef")]
    public V1beta1DatasetAccessSpecInitProviderRoutineProjectIdRef? ProjectIdRef { get; set; }

    /// <summary>Selector for a Routine in bigquery to populate projectId.</summary>
    [JsonPropertyName("projectIdSelector")]
    public V1beta1DatasetAccessSpecInitProviderRoutineProjectIdSelector? ProjectIdSelector { get; set; }

    /// <summary>The ID of the routine. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 256 characters.</summary>
    [JsonPropertyName("routineId")]
    public string? RoutineId { get; set; }

    /// <summary>Reference to a Routine in bigquery to populate routineId.</summary>
    [JsonPropertyName("routineIdRef")]
    public V1beta1DatasetAccessSpecInitProviderRoutineRoutineIdRef? RoutineIdRef { get; set; }

    /// <summary>Selector for a Routine in bigquery to populate routineId.</summary>
    [JsonPropertyName("routineIdSelector")]
    public V1beta1DatasetAccessSpecInitProviderRoutineRoutineIdSelector? RoutineIdSelector { get; set; }
}

public enum V1beta1DatasetAccessSpecInitProviderUserByEmailRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecInitProviderUserByEmailRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecInitProviderUserByEmailRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderUserByEmailRefPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecInitProviderUserByEmailRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderUserByEmailRefPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecInitProviderUserByEmailRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecInitProviderUserByEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecInitProviderUserByEmailRefPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecInitProviderUserByEmailSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecInitProviderUserByEmailSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecInitProviderUserByEmailSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderUserByEmailSelectorPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecInitProviderUserByEmailSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderUserByEmailSelectorPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecInitProviderUserByEmailSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecInitProviderUserByEmailSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecInitProviderUserByEmailSelectorPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecInitProviderViewDatasetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecInitProviderViewDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecInitProviderViewDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderViewDatasetIdRefPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecInitProviderViewDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderViewDatasetIdRefPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecInitProviderViewDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecInitProviderViewDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecInitProviderViewDatasetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecInitProviderViewDatasetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecInitProviderViewDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecInitProviderViewDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderViewDatasetIdSelectorPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecInitProviderViewDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderViewDatasetIdSelectorPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecInitProviderViewDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecInitProviderViewDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecInitProviderViewDatasetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecInitProviderViewTableIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecInitProviderViewTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecInitProviderViewTableIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderViewTableIdRefPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecInitProviderViewTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderViewTableIdRefPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecInitProviderViewTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecInitProviderViewTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecInitProviderViewTableIdRefPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecInitProviderViewTableIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecInitProviderViewTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecInitProviderViewTableIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderViewTableIdSelectorPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecInitProviderViewTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecInitProviderViewTableIdSelectorPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecInitProviderViewTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecInitProviderViewTableIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecInitProviderViewTableIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1DatasetAccessSpecInitProviderView
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1DatasetAccessSpecInitProviderViewDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1DatasetAccessSpecInitProviderViewDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The ID of the table. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta1DatasetAccessSpecInitProviderViewTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta1DatasetAccessSpecInitProviderViewTableIdSelector? TableIdSelector { get; set; }
}

public partial class V1beta1DatasetAccessSpecInitProvider
{
    /// <summary>Grants all resources of particular types in a particular dataset read access to the current dataset. Structure is documented below.</summary>
    [JsonPropertyName("dataset")]
    public IList<V1beta1DatasetAccessSpecInitProviderDataset>? Dataset { get; set; }

    /// <summary>A unique ID for this dataset, without the project name. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1DatasetAccessSpecInitProviderDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1DatasetAccessSpecInitProviderDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>A domain to grant access to. Any users signed in with the domain specified will be granted the specified access</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>An email address of a Google Group to grant access to.</summary>
    [JsonPropertyName("groupByEmail")]
    public string? GroupByEmail { get; set; }

    /// <summary>Some other type of member that appears in the IAM Policy but isn't a user, group, domain, or special group. For example: allUsers</summary>
    [JsonPropertyName("iamMember")]
    public string? IamMember { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Describes the rights granted to the user specified by the other member of the access object. Basic, predefined, and custom roles are supported. Predefined roles that have equivalent basic roles are swapped by the API to their basic counterparts, and will show a diff post-create. See official docs.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>A routine from a different dataset to grant access to. Queries executed against that routine will have read access to tables in this dataset. The role field is not required when this field is set. If that routine is updated by any user, access to the routine needs to be granted again via an update operation. Structure is documented below.</summary>
    [JsonPropertyName("routine")]
    public IList<V1beta1DatasetAccessSpecInitProviderRoutine>? Routine { get; set; }

    /// <summary>A special group to grant access to. Possible values include:</summary>
    [JsonPropertyName("specialGroup")]
    public string? SpecialGroup { get; set; }

    /// <summary>An email address of a user to grant access to. For example: fred@example.com</summary>
    [JsonPropertyName("userByEmail")]
    public string? UserByEmail { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate userByEmail.</summary>
    [JsonPropertyName("userByEmailRef")]
    public V1beta1DatasetAccessSpecInitProviderUserByEmailRef? UserByEmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate userByEmail.</summary>
    [JsonPropertyName("userByEmailSelector")]
    public V1beta1DatasetAccessSpecInitProviderUserByEmailSelector? UserByEmailSelector { get; set; }

    /// <summary>A view from a different dataset to grant access to. Queries executed against that view will have read access to tables in this dataset. The role field is not required when this field is set. If that view is updated by any user, access to the view needs to be granted again via an update operation. Structure is documented below.</summary>
    [JsonPropertyName("view")]
    public IList<V1beta1DatasetAccessSpecInitProviderView>? View { get; set; }
}

public enum V1beta1DatasetAccessSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

public enum V1beta1DatasetAccessSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1DatasetAccessSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DatasetAccessSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DatasetAccessSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1DatasetAccessSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1DatasetAccessSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DatasetAccessSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetAccessSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1DatasetAccessSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1DatasetAccessSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1DatasetAccessSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1DatasetAccessSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1DatasetAccessSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1DatasetAccessSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasetAccessSpecDeletionPolicyEnum>))]
    public V1beta1DatasetAccessSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DatasetAccessSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DatasetAccessSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DatasetAccessSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DatasetAccessSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1DatasetAccessSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DatasetAccessSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1DatasetAccessStatusAtProviderDatasetDataset
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

public partial class V1beta1DatasetAccessStatusAtProviderDataset
{
    /// <summary>The dataset this entry applies to Structure is documented below.</summary>
    [JsonPropertyName("dataset")]
    public IList<V1beta1DatasetAccessStatusAtProviderDatasetDataset>? Dataset { get; set; }

    /// <summary>Which resources in the dataset this entry applies to. Currently, only views are supported, but additional target types may be added in the future. Possible values: VIEWS</summary>
    [JsonPropertyName("targetTypes")]
    public IList<string>? TargetTypes { get; set; }
}

public partial class V1beta1DatasetAccessStatusAtProviderRoutine
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The ID of the routine. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 256 characters.</summary>
    [JsonPropertyName("routineId")]
    public string? RoutineId { get; set; }
}

public partial class V1beta1DatasetAccessStatusAtProviderView
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The ID of the table. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

public partial class V1beta1DatasetAccessStatusAtProvider
{
    /// <summary></summary>
    [JsonPropertyName("apiUpdatedMember")]
    public bool? ApiUpdatedMember { get; set; }

    /// <summary>Grants all resources of particular types in a particular dataset read access to the current dataset. Structure is documented below.</summary>
    [JsonPropertyName("dataset")]
    public IList<V1beta1DatasetAccessStatusAtProviderDataset>? Dataset { get; set; }

    /// <summary>A unique ID for this dataset, without the project name. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>A domain to grant access to. Any users signed in with the domain specified will be granted the specified access</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>An email address of a Google Group to grant access to.</summary>
    [JsonPropertyName("groupByEmail")]
    public string? GroupByEmail { get; set; }

    /// <summary>Some other type of member that appears in the IAM Policy but isn't a user, group, domain, or special group. For example: allUsers</summary>
    [JsonPropertyName("iamMember")]
    public string? IamMember { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/datasets/{{dataset_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Describes the rights granted to the user specified by the other member of the access object. Basic, predefined, and custom roles are supported. Predefined roles that have equivalent basic roles are swapped by the API to their basic counterparts, and will show a diff post-create. See official docs.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>A routine from a different dataset to grant access to. Queries executed against that routine will have read access to tables in this dataset. The role field is not required when this field is set. If that routine is updated by any user, access to the routine needs to be granted again via an update operation. Structure is documented below.</summary>
    [JsonPropertyName("routine")]
    public IList<V1beta1DatasetAccessStatusAtProviderRoutine>? Routine { get; set; }

    /// <summary>A special group to grant access to. Possible values include:</summary>
    [JsonPropertyName("specialGroup")]
    public string? SpecialGroup { get; set; }

    /// <summary>An email address of a user to grant access to. For example: fred@example.com</summary>
    [JsonPropertyName("userByEmail")]
    public string? UserByEmail { get; set; }

    /// <summary>A view from a different dataset to grant access to. Queries executed against that view will have read access to tables in this dataset. The role field is not required when this field is set. If that view is updated by any user, access to the view needs to be granted again via an update operation. Structure is documented below.</summary>
    [JsonPropertyName("view")]
    public IList<V1beta1DatasetAccessStatusAtProviderView>? View { get; set; }
}

public partial class V1beta1DatasetAccessStatusConditions
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

public partial class V1beta1DatasetAccessStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DatasetAccessStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DatasetAccessStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DatasetAccess : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DatasetAccessSpec>, IStatus<V1beta1DatasetAccessStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DatasetAccess";
    public const string KubeGroup = "bigquery.gcp.upbound.io";
    public const string KubePluralName = "datasetaccesses";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DatasetAccessSpec defines the desired state of DatasetAccess</summary>
    [JsonPropertyName("spec")]
    public V1beta1DatasetAccessSpec Spec { get; set; }

    /// <summary>DatasetAccessStatus defines the observed state of DatasetAccess.</summary>
    [JsonPropertyName("status")]
    public V1beta1DatasetAccessStatus? Status { get; set; }
}