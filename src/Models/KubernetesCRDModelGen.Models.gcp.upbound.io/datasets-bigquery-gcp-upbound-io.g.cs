using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquery.gcp.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessDatasetDatasetDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessDatasetDatasetDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecForProviderAccessDatasetDatasetDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessDatasetDatasetDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessDatasetDatasetDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecForProviderAccessDatasetDatasetDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessDatasetDataset
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1DatasetSpecForProviderAccessDatasetDatasetDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1DatasetSpecForProviderAccessDatasetDatasetDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessDataset
{
    /// <summary>The dataset this entry applies to Structure is documented below.</summary>
    [JsonPropertyName("dataset")]
    public IList<V1beta1DatasetSpecForProviderAccessDatasetDataset>? Dataset { get; set; }

    /// <summary>Which resources in the dataset this entry applies to. Currently, only views are supported, but additional target types may be added in the future. Possible values: VIEWS</summary>
    [JsonPropertyName("targetTypes")]
    public IList<string>? TargetTypes { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessRoutineDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Routine in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessRoutineDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecForProviderAccessRoutineDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessRoutineDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Routine in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessRoutineDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecForProviderAccessRoutineDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessRoutineProjectIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Routine in bigquery to populate projectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessRoutineProjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecForProviderAccessRoutineProjectIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessRoutineProjectIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Routine in bigquery to populate projectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessRoutineProjectIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecForProviderAccessRoutineProjectIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessRoutineRoutineIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Routine in bigquery to populate routineId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessRoutineRoutineIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecForProviderAccessRoutineRoutineIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessRoutineRoutineIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Routine in bigquery to populate routineId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessRoutineRoutineIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecForProviderAccessRoutineRoutineIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessRoutine
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Routine in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1DatasetSpecForProviderAccessRoutineDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Routine in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1DatasetSpecForProviderAccessRoutineDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Reference to a Routine in bigquery to populate projectId.</summary>
    [JsonPropertyName("projectIdRef")]
    public V1beta1DatasetSpecForProviderAccessRoutineProjectIdRef? ProjectIdRef { get; set; }

    /// <summary>Selector for a Routine in bigquery to populate projectId.</summary>
    [JsonPropertyName("projectIdSelector")]
    public V1beta1DatasetSpecForProviderAccessRoutineProjectIdSelector? ProjectIdSelector { get; set; }

    /// <summary>The ID of the routine. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 256 characters.</summary>
    [JsonPropertyName("routineId")]
    public string? RoutineId { get; set; }

    /// <summary>Reference to a Routine in bigquery to populate routineId.</summary>
    [JsonPropertyName("routineIdRef")]
    public V1beta1DatasetSpecForProviderAccessRoutineRoutineIdRef? RoutineIdRef { get; set; }

    /// <summary>Selector for a Routine in bigquery to populate routineId.</summary>
    [JsonPropertyName("routineIdSelector")]
    public V1beta1DatasetSpecForProviderAccessRoutineRoutineIdSelector? RoutineIdSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessUserByEmailRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate userByEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessUserByEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecForProviderAccessUserByEmailRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessUserByEmailSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate userByEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessUserByEmailSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecForProviderAccessUserByEmailSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccessView
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderAccess
{
    /// <summary>Grants all resources of particular types in a particular dataset read access to the current dataset. Structure is documented below.</summary>
    [JsonPropertyName("dataset")]
    public IList<V1beta1DatasetSpecForProviderAccessDataset>? Dataset { get; set; }

    /// <summary>A domain to grant access to. Any users signed in with the domain specified will be granted the specified access</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>An email address of a Google Group to grant access to.</summary>
    [JsonPropertyName("groupByEmail")]
    public string? GroupByEmail { get; set; }

    /// <summary>Some other type of member that appears in the IAM Policy but isn't a user, group, domain, or special group. For example: allUsers</summary>
    [JsonPropertyName("iamMember")]
    public string? IamMember { get; set; }

    /// <summary>Describes the rights granted to the user specified by the other member of the access object. Basic, predefined, and custom roles are supported. Predefined roles that have equivalent basic roles are swapped by the API to their basic counterparts. See official docs.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>A routine from a different dataset to grant access to. Queries executed against that routine will have read access to tables in this dataset. The role field is not required when this field is set. If that routine is updated by any user, access to the routine needs to be granted again via an update operation. Structure is documented below.</summary>
    [JsonPropertyName("routine")]
    public IList<V1beta1DatasetSpecForProviderAccessRoutine>? Routine { get; set; }

    /// <summary>A special group to grant access to. Possible values include:</summary>
    [JsonPropertyName("specialGroup")]
    public string? SpecialGroup { get; set; }

    /// <summary>An email address of a user to grant access to. For example: fred@example.com</summary>
    [JsonPropertyName("userByEmail")]
    public string? UserByEmail { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate userByEmail.</summary>
    [JsonPropertyName("userByEmailRef")]
    public V1beta1DatasetSpecForProviderAccessUserByEmailRef? UserByEmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate userByEmail.</summary>
    [JsonPropertyName("userByEmailSelector")]
    public V1beta1DatasetSpecForProviderAccessUserByEmailSelector? UserByEmailSelector { get; set; }

    /// <summary>A view from a different dataset to grant access to. Queries executed against that view will have read access to tables in this dataset. The role field is not required when this field is set. If that view is updated by any user, access to the view needs to be granted again via an update operation. Structure is documented below.</summary>
    [JsonPropertyName("view")]
    public IList<V1beta1DatasetSpecForProviderAccessView>? View { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderDefaultEncryptionConfigurationKmsKeyNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderDefaultEncryptionConfigurationKmsKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecForProviderDefaultEncryptionConfigurationKmsKeyNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderDefaultEncryptionConfigurationKmsKeyNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderDefaultEncryptionConfigurationKmsKeyNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecForProviderDefaultEncryptionConfigurationKmsKeyNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderDefaultEncryptionConfiguration
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public V1beta1DatasetSpecForProviderDefaultEncryptionConfigurationKmsKeyNameRef? KmsKeyNameRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameSelector")]
    public V1beta1DatasetSpecForProviderDefaultEncryptionConfigurationKmsKeyNameSelector? KmsKeyNameSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProviderExternalDatasetReference
{
    /// <summary>The connection id that is used to access the externalSource. Format: projects/{projectId}/locations/{locationId}/connections/{connectionId}</summary>
    [JsonPropertyName("connection")]
    public string? Connection { get; set; }

    /// <summary>External source that backs this dataset.</summary>
    [JsonPropertyName("externalSource")]
    public string? ExternalSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecForProvider
{
    /// <summary>An array of objects that define dataset access for one or more entities. Structure is documented below.</summary>
    [JsonPropertyName("access")]
    public IList<V1beta1DatasetSpecForProviderAccess>? Access { get; set; }

    /// <summary>Defines the default collation specification of future tables created in the dataset. If a table is created in this dataset without table-level default collation, then the table inherits the dataset default collation, which is applied to the string fields that do not have explicit collation specified. A change to this field affects only tables created afterwards, and does not alter the existing tables. The following values are supported:</summary>
    [JsonPropertyName("defaultCollation")]
    public string? DefaultCollation { get; set; }

    /// <summary>The default encryption key for all tables in the dataset. Once this property is set, all newly-created partitioned tables in the dataset will have encryption key set to this value, unless table creation request (or query) overrides the key. Structure is documented below.</summary>
    [JsonPropertyName("defaultEncryptionConfiguration")]
    public IList<V1beta1DatasetSpecForProviderDefaultEncryptionConfiguration>? DefaultEncryptionConfiguration { get; set; }

    /// <summary>The default partition expiration for all partitioned tables in the dataset, in milliseconds.</summary>
    [JsonPropertyName("defaultPartitionExpirationMs")]
    public double? DefaultPartitionExpirationMs { get; set; }

    /// <summary>The default lifetime of all tables in the dataset, in milliseconds. The minimum value is 3600000 milliseconds (one hour).</summary>
    [JsonPropertyName("defaultTableExpirationMs")]
    public double? DefaultTableExpirationMs { get; set; }

    /// <summary>If set to true, delete all the tables in the dataset when destroying the resource; otherwise, destroying the resource will fail if tables are present.</summary>
    [JsonPropertyName("deleteContentsOnDestroy")]
    public bool? DeleteContentsOnDestroy { get; set; }

    /// <summary>A user-friendly description of the dataset</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Information about the external metadata storage where the dataset is defined. Structure is documented below.</summary>
    [JsonPropertyName("externalDatasetReference")]
    public IList<V1beta1DatasetSpecForProviderExternalDatasetReference>? ExternalDatasetReference { get; set; }

    /// <summary>A descriptive name for the dataset</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>TRUE if the dataset and its table names are case-insensitive, otherwise FALSE. By default, this is FALSE, which means the dataset and its table names are case-sensitive. This field does not affect routine references.</summary>
    [JsonPropertyName("isCaseInsensitive")]
    public bool? IsCaseInsensitive { get; set; }

    /// <summary>The labels associated with this dataset. You can use these to organize and group your datasets.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The geographic location where the dataset should reside. See official docs.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Defines the time travel window in hours. The value can be from 48 to 168 hours (2 to 7 days).</summary>
    [JsonPropertyName("maxTimeTravelHours")]
    public string? MaxTimeTravelHours { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The tags attached to this table. Tag keys are globally unique. Tag key is expected to be in the namespaced format, for example "123456789012/environment" where 123456789012 is the ID of the parent organization or project resource for this tag key. Tag value is expected to be the short name, for example "Production". See Tag definitions for more details.</summary>
    [JsonPropertyName("resourceTags")]
    public IDictionary<string, string>? ResourceTags { get; set; }

    /// <summary>Specifies the storage billing model for the dataset. Set this flag value to LOGICAL to use logical bytes for storage billing, or to PHYSICAL to use physical bytes instead. LOGICAL is the default if this flag isn't specified.</summary>
    [JsonPropertyName("storageBillingModel")]
    public string? StorageBillingModel { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessDatasetDatasetDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessDatasetDatasetDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecInitProviderAccessDatasetDatasetDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessDatasetDatasetDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessDatasetDatasetDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecInitProviderAccessDatasetDatasetDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessDatasetDataset
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1DatasetSpecInitProviderAccessDatasetDatasetDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1DatasetSpecInitProviderAccessDatasetDatasetDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessDataset
{
    /// <summary>The dataset this entry applies to Structure is documented below.</summary>
    [JsonPropertyName("dataset")]
    public IList<V1beta1DatasetSpecInitProviderAccessDatasetDataset>? Dataset { get; set; }

    /// <summary>Which resources in the dataset this entry applies to. Currently, only views are supported, but additional target types may be added in the future. Possible values: VIEWS</summary>
    [JsonPropertyName("targetTypes")]
    public IList<string>? TargetTypes { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessRoutineDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Routine in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessRoutineDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecInitProviderAccessRoutineDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessRoutineDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Routine in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessRoutineDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecInitProviderAccessRoutineDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessRoutineProjectIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Routine in bigquery to populate projectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessRoutineProjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecInitProviderAccessRoutineProjectIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessRoutineProjectIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Routine in bigquery to populate projectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessRoutineProjectIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecInitProviderAccessRoutineProjectIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessRoutineRoutineIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Routine in bigquery to populate routineId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessRoutineRoutineIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecInitProviderAccessRoutineRoutineIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessRoutineRoutineIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Routine in bigquery to populate routineId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessRoutineRoutineIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecInitProviderAccessRoutineRoutineIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessRoutine
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Routine in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1DatasetSpecInitProviderAccessRoutineDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Routine in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1DatasetSpecInitProviderAccessRoutineDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Reference to a Routine in bigquery to populate projectId.</summary>
    [JsonPropertyName("projectIdRef")]
    public V1beta1DatasetSpecInitProviderAccessRoutineProjectIdRef? ProjectIdRef { get; set; }

    /// <summary>Selector for a Routine in bigquery to populate projectId.</summary>
    [JsonPropertyName("projectIdSelector")]
    public V1beta1DatasetSpecInitProviderAccessRoutineProjectIdSelector? ProjectIdSelector { get; set; }

    /// <summary>The ID of the routine. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 256 characters.</summary>
    [JsonPropertyName("routineId")]
    public string? RoutineId { get; set; }

    /// <summary>Reference to a Routine in bigquery to populate routineId.</summary>
    [JsonPropertyName("routineIdRef")]
    public V1beta1DatasetSpecInitProviderAccessRoutineRoutineIdRef? RoutineIdRef { get; set; }

    /// <summary>Selector for a Routine in bigquery to populate routineId.</summary>
    [JsonPropertyName("routineIdSelector")]
    public V1beta1DatasetSpecInitProviderAccessRoutineRoutineIdSelector? RoutineIdSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessUserByEmailRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate userByEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessUserByEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecInitProviderAccessUserByEmailRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessUserByEmailSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate userByEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessUserByEmailSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecInitProviderAccessUserByEmailSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccessView
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderAccess
{
    /// <summary>Grants all resources of particular types in a particular dataset read access to the current dataset. Structure is documented below.</summary>
    [JsonPropertyName("dataset")]
    public IList<V1beta1DatasetSpecInitProviderAccessDataset>? Dataset { get; set; }

    /// <summary>A domain to grant access to. Any users signed in with the domain specified will be granted the specified access</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>An email address of a Google Group to grant access to.</summary>
    [JsonPropertyName("groupByEmail")]
    public string? GroupByEmail { get; set; }

    /// <summary>Some other type of member that appears in the IAM Policy but isn't a user, group, domain, or special group. For example: allUsers</summary>
    [JsonPropertyName("iamMember")]
    public string? IamMember { get; set; }

    /// <summary>Describes the rights granted to the user specified by the other member of the access object. Basic, predefined, and custom roles are supported. Predefined roles that have equivalent basic roles are swapped by the API to their basic counterparts. See official docs.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>A routine from a different dataset to grant access to. Queries executed against that routine will have read access to tables in this dataset. The role field is not required when this field is set. If that routine is updated by any user, access to the routine needs to be granted again via an update operation. Structure is documented below.</summary>
    [JsonPropertyName("routine")]
    public IList<V1beta1DatasetSpecInitProviderAccessRoutine>? Routine { get; set; }

    /// <summary>A special group to grant access to. Possible values include:</summary>
    [JsonPropertyName("specialGroup")]
    public string? SpecialGroup { get; set; }

    /// <summary>An email address of a user to grant access to. For example: fred@example.com</summary>
    [JsonPropertyName("userByEmail")]
    public string? UserByEmail { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate userByEmail.</summary>
    [JsonPropertyName("userByEmailRef")]
    public V1beta1DatasetSpecInitProviderAccessUserByEmailRef? UserByEmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate userByEmail.</summary>
    [JsonPropertyName("userByEmailSelector")]
    public V1beta1DatasetSpecInitProviderAccessUserByEmailSelector? UserByEmailSelector { get; set; }

    /// <summary>A view from a different dataset to grant access to. Queries executed against that view will have read access to tables in this dataset. The role field is not required when this field is set. If that view is updated by any user, access to the view needs to be granted again via an update operation. Structure is documented below.</summary>
    [JsonPropertyName("view")]
    public IList<V1beta1DatasetSpecInitProviderAccessView>? View { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderDefaultEncryptionConfigurationKmsKeyNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderDefaultEncryptionConfigurationKmsKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecInitProviderDefaultEncryptionConfigurationKmsKeyNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderDefaultEncryptionConfigurationKmsKeyNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderDefaultEncryptionConfigurationKmsKeyNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecInitProviderDefaultEncryptionConfigurationKmsKeyNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderDefaultEncryptionConfiguration
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public V1beta1DatasetSpecInitProviderDefaultEncryptionConfigurationKmsKeyNameRef? KmsKeyNameRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameSelector")]
    public V1beta1DatasetSpecInitProviderDefaultEncryptionConfigurationKmsKeyNameSelector? KmsKeyNameSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProviderExternalDatasetReference
{
    /// <summary>The connection id that is used to access the externalSource. Format: projects/{projectId}/locations/{locationId}/connections/{connectionId}</summary>
    [JsonPropertyName("connection")]
    public string? Connection { get; set; }

    /// <summary>External source that backs this dataset.</summary>
    [JsonPropertyName("externalSource")]
    public string? ExternalSource { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecInitProvider
{
    /// <summary>An array of objects that define dataset access for one or more entities. Structure is documented below.</summary>
    [JsonPropertyName("access")]
    public IList<V1beta1DatasetSpecInitProviderAccess>? Access { get; set; }

    /// <summary>Defines the default collation specification of future tables created in the dataset. If a table is created in this dataset without table-level default collation, then the table inherits the dataset default collation, which is applied to the string fields that do not have explicit collation specified. A change to this field affects only tables created afterwards, and does not alter the existing tables. The following values are supported:</summary>
    [JsonPropertyName("defaultCollation")]
    public string? DefaultCollation { get; set; }

    /// <summary>The default encryption key for all tables in the dataset. Once this property is set, all newly-created partitioned tables in the dataset will have encryption key set to this value, unless table creation request (or query) overrides the key. Structure is documented below.</summary>
    [JsonPropertyName("defaultEncryptionConfiguration")]
    public IList<V1beta1DatasetSpecInitProviderDefaultEncryptionConfiguration>? DefaultEncryptionConfiguration { get; set; }

    /// <summary>The default partition expiration for all partitioned tables in the dataset, in milliseconds.</summary>
    [JsonPropertyName("defaultPartitionExpirationMs")]
    public double? DefaultPartitionExpirationMs { get; set; }

    /// <summary>The default lifetime of all tables in the dataset, in milliseconds. The minimum value is 3600000 milliseconds (one hour).</summary>
    [JsonPropertyName("defaultTableExpirationMs")]
    public double? DefaultTableExpirationMs { get; set; }

    /// <summary>If set to true, delete all the tables in the dataset when destroying the resource; otherwise, destroying the resource will fail if tables are present.</summary>
    [JsonPropertyName("deleteContentsOnDestroy")]
    public bool? DeleteContentsOnDestroy { get; set; }

    /// <summary>A user-friendly description of the dataset</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Information about the external metadata storage where the dataset is defined. Structure is documented below.</summary>
    [JsonPropertyName("externalDatasetReference")]
    public IList<V1beta1DatasetSpecInitProviderExternalDatasetReference>? ExternalDatasetReference { get; set; }

    /// <summary>A descriptive name for the dataset</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>TRUE if the dataset and its table names are case-insensitive, otherwise FALSE. By default, this is FALSE, which means the dataset and its table names are case-sensitive. This field does not affect routine references.</summary>
    [JsonPropertyName("isCaseInsensitive")]
    public bool? IsCaseInsensitive { get; set; }

    /// <summary>The labels associated with this dataset. You can use these to organize and group your datasets.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The geographic location where the dataset should reside. See official docs.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Defines the time travel window in hours. The value can be from 48 to 168 hours (2 to 7 days).</summary>
    [JsonPropertyName("maxTimeTravelHours")]
    public string? MaxTimeTravelHours { get; set; }

    /// <summary>The tags attached to this table. Tag keys are globally unique. Tag key is expected to be in the namespaced format, for example "123456789012/environment" where 123456789012 is the ID of the parent organization or project resource for this tag key. Tag value is expected to be the short name, for example "Production". See Tag definitions for more details.</summary>
    [JsonPropertyName("resourceTags")]
    public IDictionary<string, string>? ResourceTags { get; set; }

    /// <summary>Specifies the storage billing model for the dataset. Set this flag value to LOGICAL to use logical bytes for storage billing, or to PHYSICAL to use physical bytes instead. LOGICAL is the default if this flag isn't specified.</summary>
    [JsonPropertyName("storageBillingModel")]
    public string? StorageBillingModel { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasetSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecPublishConnectionDetailsToMetadata
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

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1DatasetSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1DatasetSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>DatasetSpec defines the desired state of Dataset</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DatasetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DatasetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DatasetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1DatasetSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DatasetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetStatusAtProviderAccessDatasetDataset
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetStatusAtProviderAccessDataset
{
    /// <summary>The dataset this entry applies to Structure is documented below.</summary>
    [JsonPropertyName("dataset")]
    public IList<V1beta1DatasetStatusAtProviderAccessDatasetDataset>? Dataset { get; set; }

    /// <summary>Which resources in the dataset this entry applies to. Currently, only views are supported, but additional target types may be added in the future. Possible values: VIEWS</summary>
    [JsonPropertyName("targetTypes")]
    public IList<string>? TargetTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetStatusAtProviderAccessRoutine
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetStatusAtProviderAccessView
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetStatusAtProviderAccess
{
    /// <summary>Grants all resources of particular types in a particular dataset read access to the current dataset. Structure is documented below.</summary>
    [JsonPropertyName("dataset")]
    public IList<V1beta1DatasetStatusAtProviderAccessDataset>? Dataset { get; set; }

    /// <summary>A domain to grant access to. Any users signed in with the domain specified will be granted the specified access</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>An email address of a Google Group to grant access to.</summary>
    [JsonPropertyName("groupByEmail")]
    public string? GroupByEmail { get; set; }

    /// <summary>Some other type of member that appears in the IAM Policy but isn't a user, group, domain, or special group. For example: allUsers</summary>
    [JsonPropertyName("iamMember")]
    public string? IamMember { get; set; }

    /// <summary>Describes the rights granted to the user specified by the other member of the access object. Basic, predefined, and custom roles are supported. Predefined roles that have equivalent basic roles are swapped by the API to their basic counterparts. See official docs.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>A routine from a different dataset to grant access to. Queries executed against that routine will have read access to tables in this dataset. The role field is not required when this field is set. If that routine is updated by any user, access to the routine needs to be granted again via an update operation. Structure is documented below.</summary>
    [JsonPropertyName("routine")]
    public IList<V1beta1DatasetStatusAtProviderAccessRoutine>? Routine { get; set; }

    /// <summary>A special group to grant access to. Possible values include:</summary>
    [JsonPropertyName("specialGroup")]
    public string? SpecialGroup { get; set; }

    /// <summary>An email address of a user to grant access to. For example: fred@example.com</summary>
    [JsonPropertyName("userByEmail")]
    public string? UserByEmail { get; set; }

    /// <summary>A view from a different dataset to grant access to. Queries executed against that view will have read access to tables in this dataset. The role field is not required when this field is set. If that view is updated by any user, access to the view needs to be granted again via an update operation. Structure is documented below.</summary>
    [JsonPropertyName("view")]
    public IList<V1beta1DatasetStatusAtProviderAccessView>? View { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetStatusAtProviderDefaultEncryptionConfiguration
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetStatusAtProviderExternalDatasetReference
{
    /// <summary>The connection id that is used to access the externalSource. Format: projects/{projectId}/locations/{locationId}/connections/{connectionId}</summary>
    [JsonPropertyName("connection")]
    public string? Connection { get; set; }

    /// <summary>External source that backs this dataset.</summary>
    [JsonPropertyName("externalSource")]
    public string? ExternalSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetStatusAtProvider
{
    /// <summary>An array of objects that define dataset access for one or more entities. Structure is documented below.</summary>
    [JsonPropertyName("access")]
    public IList<V1beta1DatasetStatusAtProviderAccess>? Access { get; set; }

    /// <summary>The time when this dataset was created, in milliseconds since the epoch.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>Defines the default collation specification of future tables created in the dataset. If a table is created in this dataset without table-level default collation, then the table inherits the dataset default collation, which is applied to the string fields that do not have explicit collation specified. A change to this field affects only tables created afterwards, and does not alter the existing tables. The following values are supported:</summary>
    [JsonPropertyName("defaultCollation")]
    public string? DefaultCollation { get; set; }

    /// <summary>The default encryption key for all tables in the dataset. Once this property is set, all newly-created partitioned tables in the dataset will have encryption key set to this value, unless table creation request (or query) overrides the key. Structure is documented below.</summary>
    [JsonPropertyName("defaultEncryptionConfiguration")]
    public IList<V1beta1DatasetStatusAtProviderDefaultEncryptionConfiguration>? DefaultEncryptionConfiguration { get; set; }

    /// <summary>The default partition expiration for all partitioned tables in the dataset, in milliseconds.</summary>
    [JsonPropertyName("defaultPartitionExpirationMs")]
    public double? DefaultPartitionExpirationMs { get; set; }

    /// <summary>The default lifetime of all tables in the dataset, in milliseconds. The minimum value is 3600000 milliseconds (one hour).</summary>
    [JsonPropertyName("defaultTableExpirationMs")]
    public double? DefaultTableExpirationMs { get; set; }

    /// <summary>If set to true, delete all the tables in the dataset when destroying the resource; otherwise, destroying the resource will fail if tables are present.</summary>
    [JsonPropertyName("deleteContentsOnDestroy")]
    public bool? DeleteContentsOnDestroy { get; set; }

    /// <summary>A user-friendly description of the dataset</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>A hash of the resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Information about the external metadata storage where the dataset is defined. Structure is documented below.</summary>
    [JsonPropertyName("externalDatasetReference")]
    public IList<V1beta1DatasetStatusAtProviderExternalDatasetReference>? ExternalDatasetReference { get; set; }

    /// <summary>A descriptive name for the dataset</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/datasets/{{dataset_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>TRUE if the dataset and its table names are case-insensitive, otherwise FALSE. By default, this is FALSE, which means the dataset and its table names are case-sensitive. This field does not affect routine references.</summary>
    [JsonPropertyName("isCaseInsensitive")]
    public bool? IsCaseInsensitive { get; set; }

    /// <summary>The labels associated with this dataset. You can use these to organize and group your datasets.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The date when this dataset or any of its tables was last modified, in milliseconds since the epoch.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public double? LastModifiedTime { get; set; }

    /// <summary>The geographic location where the dataset should reside. See official docs.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Defines the time travel window in hours. The value can be from 48 to 168 hours (2 to 7 days).</summary>
    [JsonPropertyName("maxTimeTravelHours")]
    public string? MaxTimeTravelHours { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The tags attached to this table. Tag keys are globally unique. Tag key is expected to be in the namespaced format, for example "123456789012/environment" where 123456789012 is the ID of the parent organization or project resource for this tag key. Tag value is expected to be the short name, for example "Production". See Tag definitions for more details.</summary>
    [JsonPropertyName("resourceTags")]
    public IDictionary<string, string>? ResourceTags { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Specifies the storage billing model for the dataset. Set this flag value to LOGICAL to use logical bytes for storage billing, or to PHYSICAL to use physical bytes instead. LOGICAL is the default if this flag isn't specified.</summary>
    [JsonPropertyName("storageBillingModel")]
    public string? StorageBillingModel { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetStatusConditions
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

/// <summary>DatasetStatus defines the observed state of Dataset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DatasetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DatasetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Dataset is the Schema for the Datasets API. Datasets allow you to organize and control access to your tables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Dataset : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DatasetSpec>, IStatus<V1beta1DatasetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Dataset";
    public const string KubeGroup = "bigquery.gcp.upbound.io";
    public const string KubePluralName = "datasets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DatasetSpec defines the desired state of Dataset</summary>
    [JsonPropertyName("spec")]
    public V1beta1DatasetSpec Spec { get; set; }

    /// <summary>DatasetStatus defines the observed state of Dataset.</summary>
    [JsonPropertyName("status")]
    public V1beta1DatasetStatus? Status { get; set; }
}