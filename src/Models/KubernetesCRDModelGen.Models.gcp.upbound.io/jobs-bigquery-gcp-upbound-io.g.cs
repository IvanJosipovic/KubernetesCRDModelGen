using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquery.gcp.upbound.io;
public enum V1beta1JobSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1JobSpecForProviderCopyDestinationEncryptionConfigurationKmsKeyNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecForProviderCopyDestinationEncryptionConfigurationKmsKeyNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecForProviderCopyDestinationEncryptionConfigurationKmsKeyNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderCopyDestinationEncryptionConfigurationKmsKeyNameRefPolicyResolutionEnum>))]
    public V1beta1JobSpecForProviderCopyDestinationEncryptionConfigurationKmsKeyNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderCopyDestinationEncryptionConfigurationKmsKeyNameRefPolicyResolveEnum>))]
    public V1beta1JobSpecForProviderCopyDestinationEncryptionConfigurationKmsKeyNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecForProviderCopyDestinationEncryptionConfigurationKmsKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderCopyDestinationEncryptionConfigurationKmsKeyNameRefPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecForProviderCopyDestinationEncryptionConfigurationKmsKeyNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecForProviderCopyDestinationEncryptionConfigurationKmsKeyNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecForProviderCopyDestinationEncryptionConfigurationKmsKeyNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderCopyDestinationEncryptionConfigurationKmsKeyNameSelectorPolicyResolutionEnum>))]
    public V1beta1JobSpecForProviderCopyDestinationEncryptionConfigurationKmsKeyNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderCopyDestinationEncryptionConfigurationKmsKeyNameSelectorPolicyResolveEnum>))]
    public V1beta1JobSpecForProviderCopyDestinationEncryptionConfigurationKmsKeyNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecForProviderCopyDestinationEncryptionConfigurationKmsKeyNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderCopyDestinationEncryptionConfigurationKmsKeyNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1JobSpecForProviderCopyDestinationEncryptionConfiguration
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public V1beta1JobSpecForProviderCopyDestinationEncryptionConfigurationKmsKeyNameRef? KmsKeyNameRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameSelector")]
    public V1beta1JobSpecForProviderCopyDestinationEncryptionConfigurationKmsKeyNameSelector? KmsKeyNameSelector { get; set; }
}

public enum V1beta1JobSpecForProviderCopyDestinationTableDatasetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecForProviderCopyDestinationTableDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecForProviderCopyDestinationTableDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderCopyDestinationTableDatasetIdRefPolicyResolutionEnum>))]
    public V1beta1JobSpecForProviderCopyDestinationTableDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderCopyDestinationTableDatasetIdRefPolicyResolveEnum>))]
    public V1beta1JobSpecForProviderCopyDestinationTableDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecForProviderCopyDestinationTableDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderCopyDestinationTableDatasetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecForProviderCopyDestinationTableDatasetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecForProviderCopyDestinationTableDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecForProviderCopyDestinationTableDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderCopyDestinationTableDatasetIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobSpecForProviderCopyDestinationTableDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderCopyDestinationTableDatasetIdSelectorPolicyResolveEnum>))]
    public V1beta1JobSpecForProviderCopyDestinationTableDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecForProviderCopyDestinationTableDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderCopyDestinationTableDatasetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecForProviderCopyDestinationTableTableIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecForProviderCopyDestinationTableTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecForProviderCopyDestinationTableTableIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderCopyDestinationTableTableIdRefPolicyResolutionEnum>))]
    public V1beta1JobSpecForProviderCopyDestinationTableTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderCopyDestinationTableTableIdRefPolicyResolveEnum>))]
    public V1beta1JobSpecForProviderCopyDestinationTableTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecForProviderCopyDestinationTableTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderCopyDestinationTableTableIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecForProviderCopyDestinationTableTableIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecForProviderCopyDestinationTableTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecForProviderCopyDestinationTableTableIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderCopyDestinationTableTableIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobSpecForProviderCopyDestinationTableTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderCopyDestinationTableTableIdSelectorPolicyResolveEnum>))]
    public V1beta1JobSpecForProviderCopyDestinationTableTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecForProviderCopyDestinationTableTableIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderCopyDestinationTableTableIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1JobSpecForProviderCopyDestinationTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1JobSpecForProviderCopyDestinationTableDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1JobSpecForProviderCopyDestinationTableDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The table. Can be specified {{table_id}} if project_id and dataset_id are also set, or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta1JobSpecForProviderCopyDestinationTableTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta1JobSpecForProviderCopyDestinationTableTableIdSelector? TableIdSelector { get; set; }
}

public partial class V1beta1JobSpecForProviderCopySourceTables
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The table. Can be specified {{table_id}} if project_id and dataset_id are also set, or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

public partial class V1beta1JobSpecForProviderCopy
{
    /// <summary>Specifies whether the job is allowed to create new tables. The following values are supported: CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table. CREATE_NEVER: The table must already exist. If it does not, a 'notFound' error is returned in the job result. Creation, truncation and append actions occur as one atomic update upon job completion Default value is CREATE_IF_NEEDED. Possible values are: CREATE_IF_NEEDED, CREATE_NEVER.</summary>
    [JsonPropertyName("createDisposition")]
    public string? CreateDisposition { get; set; }

    /// <summary>Custom encryption configuration (e.g., Cloud KMS keys) Structure is documented below.</summary>
    [JsonPropertyName("destinationEncryptionConfiguration")]
    public IList<V1beta1JobSpecForProviderCopyDestinationEncryptionConfiguration>? DestinationEncryptionConfiguration { get; set; }

    /// <summary>The destination table. Structure is documented below.</summary>
    [JsonPropertyName("destinationTable")]
    public IList<V1beta1JobSpecForProviderCopyDestinationTable>? DestinationTable { get; set; }

    /// <summary>Source tables to copy. Structure is documented below.</summary>
    [JsonPropertyName("sourceTables")]
    public IList<V1beta1JobSpecForProviderCopySourceTables>? SourceTables { get; set; }

    /// <summary>Specifies the action that occurs if the destination table already exists. The following values are supported: WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result. WRITE_APPEND: If the table already exists, BigQuery appends the data to the table. WRITE_EMPTY: If the table already exists and contains data, a 'duplicate' error is returned in the job result. Each action is atomic and only occurs if BigQuery is able to complete the job successfully. Creation, truncation and append actions occur as one atomic update upon job completion. Default value is WRITE_EMPTY. Possible values are: WRITE_TRUNCATE, WRITE_APPEND, WRITE_EMPTY.</summary>
    [JsonPropertyName("writeDisposition")]
    public string? WriteDisposition { get; set; }
}

public partial class V1beta1JobSpecForProviderExtractSourceModel
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the model.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

public enum V1beta1JobSpecForProviderExtractSourceTableDatasetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecForProviderExtractSourceTableDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecForProviderExtractSourceTableDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderExtractSourceTableDatasetIdRefPolicyResolutionEnum>))]
    public V1beta1JobSpecForProviderExtractSourceTableDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderExtractSourceTableDatasetIdRefPolicyResolveEnum>))]
    public V1beta1JobSpecForProviderExtractSourceTableDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecForProviderExtractSourceTableDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderExtractSourceTableDatasetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecForProviderExtractSourceTableDatasetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecForProviderExtractSourceTableDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecForProviderExtractSourceTableDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderExtractSourceTableDatasetIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobSpecForProviderExtractSourceTableDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderExtractSourceTableDatasetIdSelectorPolicyResolveEnum>))]
    public V1beta1JobSpecForProviderExtractSourceTableDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecForProviderExtractSourceTableDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderExtractSourceTableDatasetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecForProviderExtractSourceTableTableIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecForProviderExtractSourceTableTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecForProviderExtractSourceTableTableIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderExtractSourceTableTableIdRefPolicyResolutionEnum>))]
    public V1beta1JobSpecForProviderExtractSourceTableTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderExtractSourceTableTableIdRefPolicyResolveEnum>))]
    public V1beta1JobSpecForProviderExtractSourceTableTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecForProviderExtractSourceTableTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderExtractSourceTableTableIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecForProviderExtractSourceTableTableIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecForProviderExtractSourceTableTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecForProviderExtractSourceTableTableIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderExtractSourceTableTableIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobSpecForProviderExtractSourceTableTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderExtractSourceTableTableIdSelectorPolicyResolveEnum>))]
    public V1beta1JobSpecForProviderExtractSourceTableTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecForProviderExtractSourceTableTableIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderExtractSourceTableTableIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1JobSpecForProviderExtractSourceTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1JobSpecForProviderExtractSourceTableDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1JobSpecForProviderExtractSourceTableDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The table. Can be specified {{table_id}} if project_id and dataset_id are also set, or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta1JobSpecForProviderExtractSourceTableTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta1JobSpecForProviderExtractSourceTableTableIdSelector? TableIdSelector { get; set; }
}

public partial class V1beta1JobSpecForProviderExtract
{
    /// <summary>The compression type to use for exported files. Possible values include GZIP, DEFLATE, SNAPPY, and NONE. The default value is NONE. DEFLATE and SNAPPY are only supported for Avro.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>The exported file format. Possible values include CSV, NEWLINE_DELIMITED_JSON and AVRO for tables and SAVED_MODEL for models. The default value for tables is CSV. Tables with nested or repeated fields cannot be exported as CSV. The default value for models is SAVED_MODEL.</summary>
    [JsonPropertyName("destinationFormat")]
    public string? DestinationFormat { get; set; }

    /// <summary>A list of fully-qualified Google Cloud Storage URIs where the extracted table should be written.</summary>
    [JsonPropertyName("destinationUris")]
    public IList<string>? DestinationUris { get; set; }

    /// <summary>When extracting data in CSV format, this defines the delimiter to use between fields in the exported data. Default is ','</summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>Whether to print out a header row in the results. Default is true.</summary>
    [JsonPropertyName("printHeader")]
    public bool? PrintHeader { get; set; }

    /// <summary>A reference to the model being exported. Structure is documented below.</summary>
    [JsonPropertyName("sourceModel")]
    public IList<V1beta1JobSpecForProviderExtractSourceModel>? SourceModel { get; set; }

    /// <summary>A reference to the table being exported. Structure is documented below.</summary>
    [JsonPropertyName("sourceTable")]
    public IList<V1beta1JobSpecForProviderExtractSourceTable>? SourceTable { get; set; }

    /// <summary>Whether to use logical types when extracting to AVRO format.</summary>
    [JsonPropertyName("useAvroLogicalTypes")]
    public bool? UseAvroLogicalTypes { get; set; }
}

public partial class V1beta1JobSpecForProviderLoadDestinationEncryptionConfiguration
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

public enum V1beta1JobSpecForProviderLoadDestinationTableDatasetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecForProviderLoadDestinationTableDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecForProviderLoadDestinationTableDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderLoadDestinationTableDatasetIdRefPolicyResolutionEnum>))]
    public V1beta1JobSpecForProviderLoadDestinationTableDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderLoadDestinationTableDatasetIdRefPolicyResolveEnum>))]
    public V1beta1JobSpecForProviderLoadDestinationTableDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecForProviderLoadDestinationTableDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderLoadDestinationTableDatasetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecForProviderLoadDestinationTableDatasetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecForProviderLoadDestinationTableDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecForProviderLoadDestinationTableDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderLoadDestinationTableDatasetIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobSpecForProviderLoadDestinationTableDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderLoadDestinationTableDatasetIdSelectorPolicyResolveEnum>))]
    public V1beta1JobSpecForProviderLoadDestinationTableDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecForProviderLoadDestinationTableDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderLoadDestinationTableDatasetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecForProviderLoadDestinationTableTableIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecForProviderLoadDestinationTableTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecForProviderLoadDestinationTableTableIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderLoadDestinationTableTableIdRefPolicyResolutionEnum>))]
    public V1beta1JobSpecForProviderLoadDestinationTableTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderLoadDestinationTableTableIdRefPolicyResolveEnum>))]
    public V1beta1JobSpecForProviderLoadDestinationTableTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecForProviderLoadDestinationTableTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderLoadDestinationTableTableIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecForProviderLoadDestinationTableTableIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecForProviderLoadDestinationTableTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecForProviderLoadDestinationTableTableIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderLoadDestinationTableTableIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobSpecForProviderLoadDestinationTableTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderLoadDestinationTableTableIdSelectorPolicyResolveEnum>))]
    public V1beta1JobSpecForProviderLoadDestinationTableTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecForProviderLoadDestinationTableTableIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderLoadDestinationTableTableIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1JobSpecForProviderLoadDestinationTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1JobSpecForProviderLoadDestinationTableDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1JobSpecForProviderLoadDestinationTableDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The table. Can be specified {{table_id}} if project_id and dataset_id are also set, or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta1JobSpecForProviderLoadDestinationTableTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta1JobSpecForProviderLoadDestinationTableTableIdSelector? TableIdSelector { get; set; }
}

public partial class V1beta1JobSpecForProviderLoadParquetOptions
{
    /// <summary>If sourceFormat is set to PARQUET, indicates whether to use schema inference specifically for Parquet LIST logical type.</summary>
    [JsonPropertyName("enableListInference")]
    public bool? EnableListInference { get; set; }

    /// <summary>If sourceFormat is set to PARQUET, indicates whether to infer Parquet ENUM logical type as STRING instead of BYTES by default.</summary>
    [JsonPropertyName("enumAsString")]
    public bool? EnumAsString { get; set; }
}

public partial class V1beta1JobSpecForProviderLoadTimePartitioning
{
    /// <summary>Number of milliseconds for which to keep the storage for a partition. A wrapper is used here because 0 is an invalid value.</summary>
    [JsonPropertyName("expirationMs")]
    public string? ExpirationMs { get; set; }

    /// <summary>If not set, the table is partitioned by pseudo column '_PARTITIONTIME'; if set, the table is partitioned by this field. The field must be a top-level TIMESTAMP or DATE field. Its mode must be NULLABLE or REQUIRED. A wrapper is used here because an empty string is an invalid value.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>The only type supported is DAY, which will generate one partition per day. Providing an empty string used to cause an error, but in OnePlatform the field will be treated as unset.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1JobSpecForProviderLoad
{
    /// <summary>Accept rows that are missing trailing optional columns. The missing values are treated as nulls. If false, records with missing trailing columns are treated as bad records, and if there are too many bad records, an invalid error is returned in the job result. The default value is false. Only applicable to CSV, ignored for other formats.</summary>
    [JsonPropertyName("allowJaggedRows")]
    public bool? AllowJaggedRows { get; set; }

    /// <summary>Indicates if BigQuery should allow quoted data sections that contain newline characters in a CSV file. The default value is false.</summary>
    [JsonPropertyName("allowQuotedNewlines")]
    public bool? AllowQuotedNewlines { get; set; }

    /// <summary>Indicates if we should automatically infer the options and schema for CSV and JSON sources.</summary>
    [JsonPropertyName("autodetect")]
    public bool? Autodetect { get; set; }

    /// <summary>Specifies whether the job is allowed to create new tables. The following values are supported: CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table. CREATE_NEVER: The table must already exist. If it does not, a 'notFound' error is returned in the job result. Creation, truncation and append actions occur as one atomic update upon job completion Default value is CREATE_IF_NEEDED. Possible values are: CREATE_IF_NEEDED, CREATE_NEVER.</summary>
    [JsonPropertyName("createDisposition")]
    public string? CreateDisposition { get; set; }

    /// <summary>Custom encryption configuration (e.g., Cloud KMS keys) Structure is documented below.</summary>
    [JsonPropertyName("destinationEncryptionConfiguration")]
    public IList<V1beta1JobSpecForProviderLoadDestinationEncryptionConfiguration>? DestinationEncryptionConfiguration { get; set; }

    /// <summary>The destination table to load the data into. Structure is documented below.</summary>
    [JsonPropertyName("destinationTable")]
    public IList<V1beta1JobSpecForProviderLoadDestinationTable>? DestinationTable { get; set; }

    /// <summary>The character encoding of the data. The supported values are UTF-8 or ISO-8859-1. The default value is UTF-8. BigQuery decodes the data after the raw, binary data has been split using the values of the quote and fieldDelimiter properties.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The separator for fields in a CSV file. The separator can be any ISO-8859-1 single-byte character. To use a character in the range 128-255, you must encode the character as UTF8. BigQuery converts the string to ISO-8859-1 encoding, and then uses the first byte of the encoded string to split the data in its raw, binary state. BigQuery also supports the escape sequence "\t" to specify a tab separator. The default value is a comma (',').</summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>Indicates if BigQuery should allow extra values that are not represented in the table schema. If true, the extra values are ignored. If false, records with extra columns are treated as bad records, and if there are too many bad records, an invalid error is returned in the job result. The default value is false. The sourceFormat property determines what BigQuery treats as an extra value: CSV: Trailing columns JSON: Named values that don't match any column names</summary>
    [JsonPropertyName("ignoreUnknownValues")]
    public bool? IgnoreUnknownValues { get; set; }

    /// <summary>If sourceFormat is set to newline-delimited JSON, indicates whether it should be processed as a JSON variant such as GeoJSON. For a sourceFormat other than JSON, omit this field. If the sourceFormat is newline-delimited JSON: - for newline-delimited GeoJSON: set to GEOJSON.</summary>
    [JsonPropertyName("jsonExtension")]
    public string? JsonExtension { get; set; }

    /// <summary>The maximum number of bad records that BigQuery can ignore when running the job. If the number of bad records exceeds this value, an invalid error is returned in the job result. The default value is 0, which requires that all records are valid.</summary>
    [JsonPropertyName("maxBadRecords")]
    public double? MaxBadRecords { get; set; }

    /// <summary>Specifies a string that represents a null value in a CSV file. For example, if you specify "\N", BigQuery interprets "\N" as a null value when loading a CSV file. The default value is the empty string. If you set this property to a custom value, BigQuery throws an error if an empty string is present for all data types except for STRING and BYTE. For STRING and BYTE columns, BigQuery interprets the empty string as an empty value.</summary>
    [JsonPropertyName("nullMarker")]
    public string? NullMarker { get; set; }

    /// <summary>Parquet Options for load and make external tables. Structure is documented below.</summary>
    [JsonPropertyName("parquetOptions")]
    public IList<V1beta1JobSpecForProviderLoadParquetOptions>? ParquetOptions { get; set; }

    /// <summary>If sourceFormat is set to "DATASTORE_BACKUP", indicates which entity properties to load into BigQuery from a Cloud Datastore backup. Property names are case sensitive and must be top-level properties. If no properties are specified, BigQuery loads all properties. If any named property isn't found in the Cloud Datastore backup, an invalid error is returned in the job result.</summary>
    [JsonPropertyName("projectionFields")]
    public IList<string>? ProjectionFields { get; set; }

    /// <summary>The value that is used to quote data sections in a CSV file. BigQuery converts the string to ISO-8859-1 encoding, and then uses the first byte of the encoded string to split the data in its raw, binary state. The default value is a double-quote ('"'). If your data does not contain quoted sections, set the property value to an empty string. If your data contains quoted newline characters, you must also set the allowQuotedNewlines property to true.</summary>
    [JsonPropertyName("quote")]
    public string? Quote { get; set; }

    /// <summary>Allows the schema of the destination table to be updated as a side effect of the load job if a schema is autodetected or supplied in the job configuration. Schema update options are supported in two cases: when writeDisposition is WRITE_APPEND; when writeDisposition is WRITE_TRUNCATE and the destination table is a partition of a table, specified by partition decorators. For normal tables, WRITE_TRUNCATE will always overwrite the schema. One or more of the following values are specified: ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema. ALLOW_FIELD_RELAXATION: allow relaxing a required field in the original schema to nullable.</summary>
    [JsonPropertyName("schemaUpdateOptions")]
    public IList<string>? SchemaUpdateOptions { get; set; }

    /// <summary>The number of rows at the top of a CSV file that BigQuery will skip when loading the data. The default value is 0. This property is useful if you have header rows in the file that should be skipped. When autodetect is on, the behavior is the following: skipLeadingRows unspecified - Autodetect tries to detect headers in the first row. If they are not detected, the row is read as data. Otherwise data is read starting from the second row. skipLeadingRows is 0 - Instructs autodetect that there are no headers and data should be read starting from the first row. skipLeadingRows = N &gt; 0 - Autodetect skips N-1 rows and tries to detect headers in row N. If headers are not detected, row N is just skipped. Otherwise row N is used to extract column names for the detected schema.</summary>
    [JsonPropertyName("skipLeadingRows")]
    public double? SkipLeadingRows { get; set; }

    /// <summary>The format of the data files. For CSV files, specify "CSV". For datastore backups, specify "DATASTORE_BACKUP". For newline-delimited JSON, specify "NEWLINE_DELIMITED_JSON". For Avro, specify "AVRO". For parquet, specify "PARQUET". For orc, specify "ORC". [Beta] For Bigtable, specify "BIGTABLE". The default value is CSV.</summary>
    [JsonPropertyName("sourceFormat")]
    public string? SourceFormat { get; set; }

    /// <summary>The fully-qualified URIs that point to your data in Google Cloud. For Google Cloud Storage URIs: Each URI can contain one '*' wildcard character and it must come after the 'bucket' name. Size limits related to load jobs apply to external data sources. For Google Cloud Bigtable URIs: Exactly one URI can be specified and it has be a fully specified and valid HTTPS URL for a Google Cloud Bigtable table. For Google Cloud Datastore backups: Exactly one URI can be specified. Also, the '*' wildcard character is not allowed.</summary>
    [JsonPropertyName("sourceUris")]
    public IList<string>? SourceUris { get; set; }

    /// <summary>Time-based partitioning specification for the destination table. Structure is documented below.</summary>
    [JsonPropertyName("timePartitioning")]
    public IList<V1beta1JobSpecForProviderLoadTimePartitioning>? TimePartitioning { get; set; }

    /// <summary>Specifies the action that occurs if the destination table already exists. The following values are supported: WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result. WRITE_APPEND: If the table already exists, BigQuery appends the data to the table. WRITE_EMPTY: If the table already exists and contains data, a 'duplicate' error is returned in the job result. Each action is atomic and only occurs if BigQuery is able to complete the job successfully. Creation, truncation and append actions occur as one atomic update upon job completion. Default value is WRITE_EMPTY. Possible values are: WRITE_TRUNCATE, WRITE_APPEND, WRITE_EMPTY.</summary>
    [JsonPropertyName("writeDisposition")]
    public string? WriteDisposition { get; set; }
}

public enum V1beta1JobSpecForProviderQueryDefaultDatasetDatasetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecForProviderQueryDefaultDatasetDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecForProviderQueryDefaultDatasetDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderQueryDefaultDatasetDatasetIdRefPolicyResolutionEnum>))]
    public V1beta1JobSpecForProviderQueryDefaultDatasetDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderQueryDefaultDatasetDatasetIdRefPolicyResolveEnum>))]
    public V1beta1JobSpecForProviderQueryDefaultDatasetDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecForProviderQueryDefaultDatasetDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderQueryDefaultDatasetDatasetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecForProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecForProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecForProviderQueryDefaultDatasetDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobSpecForProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolveEnum>))]
    public V1beta1JobSpecForProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecForProviderQueryDefaultDatasetDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderQueryDefaultDatasetDatasetIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1JobSpecForProviderQueryDefaultDataset
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1JobSpecForProviderQueryDefaultDatasetDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1JobSpecForProviderQueryDefaultDatasetDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

public partial class V1beta1JobSpecForProviderQueryDestinationEncryptionConfiguration
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

public enum V1beta1JobSpecForProviderQueryDestinationTableDatasetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecForProviderQueryDestinationTableDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecForProviderQueryDestinationTableDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderQueryDestinationTableDatasetIdRefPolicyResolutionEnum>))]
    public V1beta1JobSpecForProviderQueryDestinationTableDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderQueryDestinationTableDatasetIdRefPolicyResolveEnum>))]
    public V1beta1JobSpecForProviderQueryDestinationTableDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecForProviderQueryDestinationTableDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderQueryDestinationTableDatasetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecForProviderQueryDestinationTableDatasetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecForProviderQueryDestinationTableDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecForProviderQueryDestinationTableDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderQueryDestinationTableDatasetIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobSpecForProviderQueryDestinationTableDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderQueryDestinationTableDatasetIdSelectorPolicyResolveEnum>))]
    public V1beta1JobSpecForProviderQueryDestinationTableDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecForProviderQueryDestinationTableDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderQueryDestinationTableDatasetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecForProviderQueryDestinationTableTableIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecForProviderQueryDestinationTableTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecForProviderQueryDestinationTableTableIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderQueryDestinationTableTableIdRefPolicyResolutionEnum>))]
    public V1beta1JobSpecForProviderQueryDestinationTableTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderQueryDestinationTableTableIdRefPolicyResolveEnum>))]
    public V1beta1JobSpecForProviderQueryDestinationTableTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecForProviderQueryDestinationTableTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderQueryDestinationTableTableIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecForProviderQueryDestinationTableTableIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecForProviderQueryDestinationTableTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecForProviderQueryDestinationTableTableIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderQueryDestinationTableTableIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobSpecForProviderQueryDestinationTableTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderQueryDestinationTableTableIdSelectorPolicyResolveEnum>))]
    public V1beta1JobSpecForProviderQueryDestinationTableTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecForProviderQueryDestinationTableTableIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderQueryDestinationTableTableIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1JobSpecForProviderQueryDestinationTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1JobSpecForProviderQueryDestinationTableDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1JobSpecForProviderQueryDestinationTableDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The table. Can be specified {{table_id}} if project_id and dataset_id are also set, or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta1JobSpecForProviderQueryDestinationTableTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta1JobSpecForProviderQueryDestinationTableTableIdSelector? TableIdSelector { get; set; }
}

public partial class V1beta1JobSpecForProviderQueryScriptOptions
{
    /// <summary>Determines which statement in the script represents the "key result", used to populate the schema and query results of the script job. Possible values are: LAST, FIRST_SELECT.</summary>
    [JsonPropertyName("keyResultStatement")]
    public string? KeyResultStatement { get; set; }

    /// <summary>Limit on the number of bytes billed per statement. Exceeding this budget results in an error.</summary>
    [JsonPropertyName("statementByteBudget")]
    public string? StatementByteBudget { get; set; }

    /// <summary>Timeout period for each statement in a script.</summary>
    [JsonPropertyName("statementTimeoutMs")]
    public string? StatementTimeoutMs { get; set; }
}

public partial class V1beta1JobSpecForProviderQueryUserDefinedFunctionResources
{
    /// <summary>An inline resource that contains code for a user-defined function (UDF). Providing a inline code resource is equivalent to providing a URI for a file containing the same code.</summary>
    [JsonPropertyName("inlineCode")]
    public string? InlineCode { get; set; }

    /// <summary>A code resource to load from a Google Cloud Storage URI (gs://bucket/path).</summary>
    [JsonPropertyName("resourceUri")]
    public string? ResourceUri { get; set; }
}

public partial class V1beta1JobSpecForProviderQuery
{
    /// <summary>If true and query uses legacy SQL dialect, allows the query to produce arbitrarily large result tables at a slight cost in performance. Requires destinationTable to be set. For standard SQL queries, this flag is ignored and large results are always allowed. However, you must still set destinationTable when result size exceeds the allowed maximum response size.</summary>
    [JsonPropertyName("allowLargeResults")]
    public bool? AllowLargeResults { get; set; }

    /// <summary>Specifies whether the job is allowed to create new tables. The following values are supported: CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table. CREATE_NEVER: The table must already exist. If it does not, a 'notFound' error is returned in the job result. Creation, truncation and append actions occur as one atomic update upon job completion Default value is CREATE_IF_NEEDED. Possible values are: CREATE_IF_NEEDED, CREATE_NEVER.</summary>
    [JsonPropertyName("createDisposition")]
    public string? CreateDisposition { get; set; }

    /// <summary>Specifies the default dataset to use for unqualified table names in the query. Note that this does not alter behavior of unqualified dataset names. Structure is documented below.</summary>
    [JsonPropertyName("defaultDataset")]
    public IList<V1beta1JobSpecForProviderQueryDefaultDataset>? DefaultDataset { get; set; }

    /// <summary>Custom encryption configuration (e.g., Cloud KMS keys) Structure is documented below.</summary>
    [JsonPropertyName("destinationEncryptionConfiguration")]
    public IList<V1beta1JobSpecForProviderQueryDestinationEncryptionConfiguration>? DestinationEncryptionConfiguration { get; set; }

    /// <summary>Describes the table where the query results should be stored. This property must be set for large results that exceed the maximum response size. For queries that produce anonymous (cached) results, this field will be populated by BigQuery. Structure is documented below.</summary>
    [JsonPropertyName("destinationTable")]
    public IList<V1beta1JobSpecForProviderQueryDestinationTable>? DestinationTable { get; set; }

    /// <summary>If true and query uses legacy SQL dialect, flattens all nested and repeated fields in the query results. allowLargeResults must be true if this is set to false. For standard SQL queries, this flag is ignored and results are never flattened.</summary>
    [JsonPropertyName("flattenResults")]
    public bool? FlattenResults { get; set; }

    /// <summary>Limits the billing tier for this job. Queries that have resource usage beyond this tier will fail (without incurring a charge). If unspecified, this will be set to your project default.</summary>
    [JsonPropertyName("maximumBillingTier")]
    public double? MaximumBillingTier { get; set; }

    /// <summary>Limits the bytes billed for this job. Queries that will have bytes billed beyond this limit will fail (without incurring a charge). If unspecified, this will be set to your project default.</summary>
    [JsonPropertyName("maximumBytesBilled")]
    public string? MaximumBytesBilled { get; set; }

    /// <summary>Standard SQL only. Set to POSITIONAL to use positional (?) query parameters or to NAMED to use named (@myparam) query parameters in this query.</summary>
    [JsonPropertyName("parameterMode")]
    public string? ParameterMode { get; set; }

    /// <summary>Specifies a priority for the query. Default value is INTERACTIVE. Possible values are: INTERACTIVE, BATCH.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>SQL query text to execute. The useLegacySql field can be used to indicate whether the query uses legacy SQL or standard SQL. NOTE: queries containing DML language (DELETE, UPDATE, MERGE, INSERT) must specify create_disposition = "" and write_disposition = "".</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>Allows the schema of the destination table to be updated as a side effect of the query job. Schema update options are supported in two cases: when writeDisposition is WRITE_APPEND; when writeDisposition is WRITE_TRUNCATE and the destination table is a partition of a table, specified by partition decorators. For normal tables, WRITE_TRUNCATE will always overwrite the schema. One or more of the following values are specified: ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema. ALLOW_FIELD_RELAXATION: allow relaxing a required field in the original schema to nullable.</summary>
    [JsonPropertyName("schemaUpdateOptions")]
    public IList<string>? SchemaUpdateOptions { get; set; }

    /// <summary>Options controlling the execution of scripts. Structure is documented below.</summary>
    [JsonPropertyName("scriptOptions")]
    public IList<V1beta1JobSpecForProviderQueryScriptOptions>? ScriptOptions { get; set; }

    /// <summary>Specifies whether to use BigQuery's legacy SQL dialect for this query. The default value is true. If set to false, the query will use BigQuery's standard SQL.</summary>
    [JsonPropertyName("useLegacySql")]
    public bool? UseLegacySql { get; set; }

    /// <summary>Whether to look for the result in the query cache. The query cache is a best-effort cache that will be flushed whenever tables in the query are modified. Moreover, the query cache is only available when a query does not have a destination table specified. The default value is true.</summary>
    [JsonPropertyName("useQueryCache")]
    public bool? UseQueryCache { get; set; }

    /// <summary>Describes user-defined function resources used in the query. Structure is documented below.</summary>
    [JsonPropertyName("userDefinedFunctionResources")]
    public IList<V1beta1JobSpecForProviderQueryUserDefinedFunctionResources>? UserDefinedFunctionResources { get; set; }

    /// <summary>Specifies the action that occurs if the destination table already exists. The following values are supported: WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result. WRITE_APPEND: If the table already exists, BigQuery appends the data to the table. WRITE_EMPTY: If the table already exists and contains data, a 'duplicate' error is returned in the job result. Each action is atomic and only occurs if BigQuery is able to complete the job successfully. Creation, truncation and append actions occur as one atomic update upon job completion. Default value is WRITE_EMPTY. Possible values are: WRITE_TRUNCATE, WRITE_APPEND, WRITE_EMPTY.</summary>
    [JsonPropertyName("writeDisposition")]
    public string? WriteDisposition { get; set; }
}

public partial class V1beta1JobSpecForProvider
{
    /// <summary>Copies a table. Structure is documented below.</summary>
    [JsonPropertyName("copy")]
    public IList<V1beta1JobSpecForProviderCopy>? Copy { get; set; }

    /// <summary>Configures an extract job. Structure is documented below.</summary>
    [JsonPropertyName("extract")]
    public IList<V1beta1JobSpecForProviderExtract>? Extract { get; set; }

    /// <summary>The ID of the job. The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }

    /// <summary>Job timeout in milliseconds. If this time limit is exceeded, BigQuery may attempt to terminate the job.</summary>
    [JsonPropertyName("jobTimeoutMs")]
    public string? JobTimeoutMs { get; set; }

    /// <summary>The labels associated with this job. You can use these to organize and group your jobs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Configures a load job. Structure is documented below.</summary>
    [JsonPropertyName("load")]
    public IList<V1beta1JobSpecForProviderLoad>? Load { get; set; }

    /// <summary>The geographic location of the job. The default value is US.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Configures a query job. Structure is documented below.</summary>
    [JsonPropertyName("query")]
    public IList<V1beta1JobSpecForProviderQuery>? Query { get; set; }
}

public enum V1beta1JobSpecInitProviderCopyDestinationEncryptionConfigurationKmsKeyNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecInitProviderCopyDestinationEncryptionConfigurationKmsKeyNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecInitProviderCopyDestinationEncryptionConfigurationKmsKeyNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderCopyDestinationEncryptionConfigurationKmsKeyNameRefPolicyResolutionEnum>))]
    public V1beta1JobSpecInitProviderCopyDestinationEncryptionConfigurationKmsKeyNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderCopyDestinationEncryptionConfigurationKmsKeyNameRefPolicyResolveEnum>))]
    public V1beta1JobSpecInitProviderCopyDestinationEncryptionConfigurationKmsKeyNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecInitProviderCopyDestinationEncryptionConfigurationKmsKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderCopyDestinationEncryptionConfigurationKmsKeyNameRefPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecInitProviderCopyDestinationEncryptionConfigurationKmsKeyNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecInitProviderCopyDestinationEncryptionConfigurationKmsKeyNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecInitProviderCopyDestinationEncryptionConfigurationKmsKeyNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderCopyDestinationEncryptionConfigurationKmsKeyNameSelectorPolicyResolutionEnum>))]
    public V1beta1JobSpecInitProviderCopyDestinationEncryptionConfigurationKmsKeyNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderCopyDestinationEncryptionConfigurationKmsKeyNameSelectorPolicyResolveEnum>))]
    public V1beta1JobSpecInitProviderCopyDestinationEncryptionConfigurationKmsKeyNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecInitProviderCopyDestinationEncryptionConfigurationKmsKeyNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderCopyDestinationEncryptionConfigurationKmsKeyNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1JobSpecInitProviderCopyDestinationEncryptionConfiguration
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public V1beta1JobSpecInitProviderCopyDestinationEncryptionConfigurationKmsKeyNameRef? KmsKeyNameRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameSelector")]
    public V1beta1JobSpecInitProviderCopyDestinationEncryptionConfigurationKmsKeyNameSelector? KmsKeyNameSelector { get; set; }
}

public enum V1beta1JobSpecInitProviderCopyDestinationTableDatasetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecInitProviderCopyDestinationTableDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecInitProviderCopyDestinationTableDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderCopyDestinationTableDatasetIdRefPolicyResolutionEnum>))]
    public V1beta1JobSpecInitProviderCopyDestinationTableDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderCopyDestinationTableDatasetIdRefPolicyResolveEnum>))]
    public V1beta1JobSpecInitProviderCopyDestinationTableDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecInitProviderCopyDestinationTableDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderCopyDestinationTableDatasetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecInitProviderCopyDestinationTableDatasetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecInitProviderCopyDestinationTableDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecInitProviderCopyDestinationTableDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderCopyDestinationTableDatasetIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobSpecInitProviderCopyDestinationTableDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderCopyDestinationTableDatasetIdSelectorPolicyResolveEnum>))]
    public V1beta1JobSpecInitProviderCopyDestinationTableDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecInitProviderCopyDestinationTableDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderCopyDestinationTableDatasetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecInitProviderCopyDestinationTableTableIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecInitProviderCopyDestinationTableTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecInitProviderCopyDestinationTableTableIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderCopyDestinationTableTableIdRefPolicyResolutionEnum>))]
    public V1beta1JobSpecInitProviderCopyDestinationTableTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderCopyDestinationTableTableIdRefPolicyResolveEnum>))]
    public V1beta1JobSpecInitProviderCopyDestinationTableTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecInitProviderCopyDestinationTableTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderCopyDestinationTableTableIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecInitProviderCopyDestinationTableTableIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecInitProviderCopyDestinationTableTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecInitProviderCopyDestinationTableTableIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderCopyDestinationTableTableIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobSpecInitProviderCopyDestinationTableTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderCopyDestinationTableTableIdSelectorPolicyResolveEnum>))]
    public V1beta1JobSpecInitProviderCopyDestinationTableTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecInitProviderCopyDestinationTableTableIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderCopyDestinationTableTableIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1JobSpecInitProviderCopyDestinationTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1JobSpecInitProviderCopyDestinationTableDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1JobSpecInitProviderCopyDestinationTableDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The table. Can be specified {{table_id}} if project_id and dataset_id are also set, or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta1JobSpecInitProviderCopyDestinationTableTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta1JobSpecInitProviderCopyDestinationTableTableIdSelector? TableIdSelector { get; set; }
}

public partial class V1beta1JobSpecInitProviderCopySourceTables
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The table. Can be specified {{table_id}} if project_id and dataset_id are also set, or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

public partial class V1beta1JobSpecInitProviderCopy
{
    /// <summary>Specifies whether the job is allowed to create new tables. The following values are supported: CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table. CREATE_NEVER: The table must already exist. If it does not, a 'notFound' error is returned in the job result. Creation, truncation and append actions occur as one atomic update upon job completion Default value is CREATE_IF_NEEDED. Possible values are: CREATE_IF_NEEDED, CREATE_NEVER.</summary>
    [JsonPropertyName("createDisposition")]
    public string? CreateDisposition { get; set; }

    /// <summary>Custom encryption configuration (e.g., Cloud KMS keys) Structure is documented below.</summary>
    [JsonPropertyName("destinationEncryptionConfiguration")]
    public IList<V1beta1JobSpecInitProviderCopyDestinationEncryptionConfiguration>? DestinationEncryptionConfiguration { get; set; }

    /// <summary>The destination table. Structure is documented below.</summary>
    [JsonPropertyName("destinationTable")]
    public IList<V1beta1JobSpecInitProviderCopyDestinationTable>? DestinationTable { get; set; }

    /// <summary>Source tables to copy. Structure is documented below.</summary>
    [JsonPropertyName("sourceTables")]
    public IList<V1beta1JobSpecInitProviderCopySourceTables>? SourceTables { get; set; }

    /// <summary>Specifies the action that occurs if the destination table already exists. The following values are supported: WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result. WRITE_APPEND: If the table already exists, BigQuery appends the data to the table. WRITE_EMPTY: If the table already exists and contains data, a 'duplicate' error is returned in the job result. Each action is atomic and only occurs if BigQuery is able to complete the job successfully. Creation, truncation and append actions occur as one atomic update upon job completion. Default value is WRITE_EMPTY. Possible values are: WRITE_TRUNCATE, WRITE_APPEND, WRITE_EMPTY.</summary>
    [JsonPropertyName("writeDisposition")]
    public string? WriteDisposition { get; set; }
}

public partial class V1beta1JobSpecInitProviderExtractSourceModel
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the model.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

public enum V1beta1JobSpecInitProviderExtractSourceTableDatasetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecInitProviderExtractSourceTableDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecInitProviderExtractSourceTableDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderExtractSourceTableDatasetIdRefPolicyResolutionEnum>))]
    public V1beta1JobSpecInitProviderExtractSourceTableDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderExtractSourceTableDatasetIdRefPolicyResolveEnum>))]
    public V1beta1JobSpecInitProviderExtractSourceTableDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecInitProviderExtractSourceTableDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderExtractSourceTableDatasetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecInitProviderExtractSourceTableDatasetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecInitProviderExtractSourceTableDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecInitProviderExtractSourceTableDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderExtractSourceTableDatasetIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobSpecInitProviderExtractSourceTableDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderExtractSourceTableDatasetIdSelectorPolicyResolveEnum>))]
    public V1beta1JobSpecInitProviderExtractSourceTableDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecInitProviderExtractSourceTableDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderExtractSourceTableDatasetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecInitProviderExtractSourceTableTableIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecInitProviderExtractSourceTableTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecInitProviderExtractSourceTableTableIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderExtractSourceTableTableIdRefPolicyResolutionEnum>))]
    public V1beta1JobSpecInitProviderExtractSourceTableTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderExtractSourceTableTableIdRefPolicyResolveEnum>))]
    public V1beta1JobSpecInitProviderExtractSourceTableTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecInitProviderExtractSourceTableTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderExtractSourceTableTableIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecInitProviderExtractSourceTableTableIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecInitProviderExtractSourceTableTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecInitProviderExtractSourceTableTableIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderExtractSourceTableTableIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobSpecInitProviderExtractSourceTableTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderExtractSourceTableTableIdSelectorPolicyResolveEnum>))]
    public V1beta1JobSpecInitProviderExtractSourceTableTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecInitProviderExtractSourceTableTableIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderExtractSourceTableTableIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1JobSpecInitProviderExtractSourceTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1JobSpecInitProviderExtractSourceTableDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1JobSpecInitProviderExtractSourceTableDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The table. Can be specified {{table_id}} if project_id and dataset_id are also set, or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta1JobSpecInitProviderExtractSourceTableTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta1JobSpecInitProviderExtractSourceTableTableIdSelector? TableIdSelector { get; set; }
}

public partial class V1beta1JobSpecInitProviderExtract
{
    /// <summary>The compression type to use for exported files. Possible values include GZIP, DEFLATE, SNAPPY, and NONE. The default value is NONE. DEFLATE and SNAPPY are only supported for Avro.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>The exported file format. Possible values include CSV, NEWLINE_DELIMITED_JSON and AVRO for tables and SAVED_MODEL for models. The default value for tables is CSV. Tables with nested or repeated fields cannot be exported as CSV. The default value for models is SAVED_MODEL.</summary>
    [JsonPropertyName("destinationFormat")]
    public string? DestinationFormat { get; set; }

    /// <summary>A list of fully-qualified Google Cloud Storage URIs where the extracted table should be written.</summary>
    [JsonPropertyName("destinationUris")]
    public IList<string>? DestinationUris { get; set; }

    /// <summary>When extracting data in CSV format, this defines the delimiter to use between fields in the exported data. Default is ','</summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>Whether to print out a header row in the results. Default is true.</summary>
    [JsonPropertyName("printHeader")]
    public bool? PrintHeader { get; set; }

    /// <summary>A reference to the model being exported. Structure is documented below.</summary>
    [JsonPropertyName("sourceModel")]
    public IList<V1beta1JobSpecInitProviderExtractSourceModel>? SourceModel { get; set; }

    /// <summary>A reference to the table being exported. Structure is documented below.</summary>
    [JsonPropertyName("sourceTable")]
    public IList<V1beta1JobSpecInitProviderExtractSourceTable>? SourceTable { get; set; }

    /// <summary>Whether to use logical types when extracting to AVRO format.</summary>
    [JsonPropertyName("useAvroLogicalTypes")]
    public bool? UseAvroLogicalTypes { get; set; }
}

public partial class V1beta1JobSpecInitProviderLoadDestinationEncryptionConfiguration
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

public enum V1beta1JobSpecInitProviderLoadDestinationTableDatasetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecInitProviderLoadDestinationTableDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecInitProviderLoadDestinationTableDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderLoadDestinationTableDatasetIdRefPolicyResolutionEnum>))]
    public V1beta1JobSpecInitProviderLoadDestinationTableDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderLoadDestinationTableDatasetIdRefPolicyResolveEnum>))]
    public V1beta1JobSpecInitProviderLoadDestinationTableDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecInitProviderLoadDestinationTableDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderLoadDestinationTableDatasetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecInitProviderLoadDestinationTableDatasetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecInitProviderLoadDestinationTableDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecInitProviderLoadDestinationTableDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderLoadDestinationTableDatasetIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobSpecInitProviderLoadDestinationTableDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderLoadDestinationTableDatasetIdSelectorPolicyResolveEnum>))]
    public V1beta1JobSpecInitProviderLoadDestinationTableDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecInitProviderLoadDestinationTableDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderLoadDestinationTableDatasetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecInitProviderLoadDestinationTableTableIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecInitProviderLoadDestinationTableTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecInitProviderLoadDestinationTableTableIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderLoadDestinationTableTableIdRefPolicyResolutionEnum>))]
    public V1beta1JobSpecInitProviderLoadDestinationTableTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderLoadDestinationTableTableIdRefPolicyResolveEnum>))]
    public V1beta1JobSpecInitProviderLoadDestinationTableTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecInitProviderLoadDestinationTableTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderLoadDestinationTableTableIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecInitProviderLoadDestinationTableTableIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecInitProviderLoadDestinationTableTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecInitProviderLoadDestinationTableTableIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderLoadDestinationTableTableIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobSpecInitProviderLoadDestinationTableTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderLoadDestinationTableTableIdSelectorPolicyResolveEnum>))]
    public V1beta1JobSpecInitProviderLoadDestinationTableTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecInitProviderLoadDestinationTableTableIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderLoadDestinationTableTableIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1JobSpecInitProviderLoadDestinationTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1JobSpecInitProviderLoadDestinationTableDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1JobSpecInitProviderLoadDestinationTableDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The table. Can be specified {{table_id}} if project_id and dataset_id are also set, or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta1JobSpecInitProviderLoadDestinationTableTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta1JobSpecInitProviderLoadDestinationTableTableIdSelector? TableIdSelector { get; set; }
}

public partial class V1beta1JobSpecInitProviderLoadParquetOptions
{
    /// <summary>If sourceFormat is set to PARQUET, indicates whether to use schema inference specifically for Parquet LIST logical type.</summary>
    [JsonPropertyName("enableListInference")]
    public bool? EnableListInference { get; set; }

    /// <summary>If sourceFormat is set to PARQUET, indicates whether to infer Parquet ENUM logical type as STRING instead of BYTES by default.</summary>
    [JsonPropertyName("enumAsString")]
    public bool? EnumAsString { get; set; }
}

public partial class V1beta1JobSpecInitProviderLoadTimePartitioning
{
    /// <summary>Number of milliseconds for which to keep the storage for a partition. A wrapper is used here because 0 is an invalid value.</summary>
    [JsonPropertyName("expirationMs")]
    public string? ExpirationMs { get; set; }

    /// <summary>If not set, the table is partitioned by pseudo column '_PARTITIONTIME'; if set, the table is partitioned by this field. The field must be a top-level TIMESTAMP or DATE field. Its mode must be NULLABLE or REQUIRED. A wrapper is used here because an empty string is an invalid value.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>The only type supported is DAY, which will generate one partition per day. Providing an empty string used to cause an error, but in OnePlatform the field will be treated as unset.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1JobSpecInitProviderLoad
{
    /// <summary>Accept rows that are missing trailing optional columns. The missing values are treated as nulls. If false, records with missing trailing columns are treated as bad records, and if there are too many bad records, an invalid error is returned in the job result. The default value is false. Only applicable to CSV, ignored for other formats.</summary>
    [JsonPropertyName("allowJaggedRows")]
    public bool? AllowJaggedRows { get; set; }

    /// <summary>Indicates if BigQuery should allow quoted data sections that contain newline characters in a CSV file. The default value is false.</summary>
    [JsonPropertyName("allowQuotedNewlines")]
    public bool? AllowQuotedNewlines { get; set; }

    /// <summary>Indicates if we should automatically infer the options and schema for CSV and JSON sources.</summary>
    [JsonPropertyName("autodetect")]
    public bool? Autodetect { get; set; }

    /// <summary>Specifies whether the job is allowed to create new tables. The following values are supported: CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table. CREATE_NEVER: The table must already exist. If it does not, a 'notFound' error is returned in the job result. Creation, truncation and append actions occur as one atomic update upon job completion Default value is CREATE_IF_NEEDED. Possible values are: CREATE_IF_NEEDED, CREATE_NEVER.</summary>
    [JsonPropertyName("createDisposition")]
    public string? CreateDisposition { get; set; }

    /// <summary>Custom encryption configuration (e.g., Cloud KMS keys) Structure is documented below.</summary>
    [JsonPropertyName("destinationEncryptionConfiguration")]
    public IList<V1beta1JobSpecInitProviderLoadDestinationEncryptionConfiguration>? DestinationEncryptionConfiguration { get; set; }

    /// <summary>The destination table to load the data into. Structure is documented below.</summary>
    [JsonPropertyName("destinationTable")]
    public IList<V1beta1JobSpecInitProviderLoadDestinationTable>? DestinationTable { get; set; }

    /// <summary>The character encoding of the data. The supported values are UTF-8 or ISO-8859-1. The default value is UTF-8. BigQuery decodes the data after the raw, binary data has been split using the values of the quote and fieldDelimiter properties.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The separator for fields in a CSV file. The separator can be any ISO-8859-1 single-byte character. To use a character in the range 128-255, you must encode the character as UTF8. BigQuery converts the string to ISO-8859-1 encoding, and then uses the first byte of the encoded string to split the data in its raw, binary state. BigQuery also supports the escape sequence "\t" to specify a tab separator. The default value is a comma (',').</summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>Indicates if BigQuery should allow extra values that are not represented in the table schema. If true, the extra values are ignored. If false, records with extra columns are treated as bad records, and if there are too many bad records, an invalid error is returned in the job result. The default value is false. The sourceFormat property determines what BigQuery treats as an extra value: CSV: Trailing columns JSON: Named values that don't match any column names</summary>
    [JsonPropertyName("ignoreUnknownValues")]
    public bool? IgnoreUnknownValues { get; set; }

    /// <summary>If sourceFormat is set to newline-delimited JSON, indicates whether it should be processed as a JSON variant such as GeoJSON. For a sourceFormat other than JSON, omit this field. If the sourceFormat is newline-delimited JSON: - for newline-delimited GeoJSON: set to GEOJSON.</summary>
    [JsonPropertyName("jsonExtension")]
    public string? JsonExtension { get; set; }

    /// <summary>The maximum number of bad records that BigQuery can ignore when running the job. If the number of bad records exceeds this value, an invalid error is returned in the job result. The default value is 0, which requires that all records are valid.</summary>
    [JsonPropertyName("maxBadRecords")]
    public double? MaxBadRecords { get; set; }

    /// <summary>Specifies a string that represents a null value in a CSV file. For example, if you specify "\N", BigQuery interprets "\N" as a null value when loading a CSV file. The default value is the empty string. If you set this property to a custom value, BigQuery throws an error if an empty string is present for all data types except for STRING and BYTE. For STRING and BYTE columns, BigQuery interprets the empty string as an empty value.</summary>
    [JsonPropertyName("nullMarker")]
    public string? NullMarker { get; set; }

    /// <summary>Parquet Options for load and make external tables. Structure is documented below.</summary>
    [JsonPropertyName("parquetOptions")]
    public IList<V1beta1JobSpecInitProviderLoadParquetOptions>? ParquetOptions { get; set; }

    /// <summary>If sourceFormat is set to "DATASTORE_BACKUP", indicates which entity properties to load into BigQuery from a Cloud Datastore backup. Property names are case sensitive and must be top-level properties. If no properties are specified, BigQuery loads all properties. If any named property isn't found in the Cloud Datastore backup, an invalid error is returned in the job result.</summary>
    [JsonPropertyName("projectionFields")]
    public IList<string>? ProjectionFields { get; set; }

    /// <summary>The value that is used to quote data sections in a CSV file. BigQuery converts the string to ISO-8859-1 encoding, and then uses the first byte of the encoded string to split the data in its raw, binary state. The default value is a double-quote ('"'). If your data does not contain quoted sections, set the property value to an empty string. If your data contains quoted newline characters, you must also set the allowQuotedNewlines property to true.</summary>
    [JsonPropertyName("quote")]
    public string? Quote { get; set; }

    /// <summary>Allows the schema of the destination table to be updated as a side effect of the load job if a schema is autodetected or supplied in the job configuration. Schema update options are supported in two cases: when writeDisposition is WRITE_APPEND; when writeDisposition is WRITE_TRUNCATE and the destination table is a partition of a table, specified by partition decorators. For normal tables, WRITE_TRUNCATE will always overwrite the schema. One or more of the following values are specified: ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema. ALLOW_FIELD_RELAXATION: allow relaxing a required field in the original schema to nullable.</summary>
    [JsonPropertyName("schemaUpdateOptions")]
    public IList<string>? SchemaUpdateOptions { get; set; }

    /// <summary>The number of rows at the top of a CSV file that BigQuery will skip when loading the data. The default value is 0. This property is useful if you have header rows in the file that should be skipped. When autodetect is on, the behavior is the following: skipLeadingRows unspecified - Autodetect tries to detect headers in the first row. If they are not detected, the row is read as data. Otherwise data is read starting from the second row. skipLeadingRows is 0 - Instructs autodetect that there are no headers and data should be read starting from the first row. skipLeadingRows = N &gt; 0 - Autodetect skips N-1 rows and tries to detect headers in row N. If headers are not detected, row N is just skipped. Otherwise row N is used to extract column names for the detected schema.</summary>
    [JsonPropertyName("skipLeadingRows")]
    public double? SkipLeadingRows { get; set; }

    /// <summary>The format of the data files. For CSV files, specify "CSV". For datastore backups, specify "DATASTORE_BACKUP". For newline-delimited JSON, specify "NEWLINE_DELIMITED_JSON". For Avro, specify "AVRO". For parquet, specify "PARQUET". For orc, specify "ORC". [Beta] For Bigtable, specify "BIGTABLE". The default value is CSV.</summary>
    [JsonPropertyName("sourceFormat")]
    public string? SourceFormat { get; set; }

    /// <summary>The fully-qualified URIs that point to your data in Google Cloud. For Google Cloud Storage URIs: Each URI can contain one '*' wildcard character and it must come after the 'bucket' name. Size limits related to load jobs apply to external data sources. For Google Cloud Bigtable URIs: Exactly one URI can be specified and it has be a fully specified and valid HTTPS URL for a Google Cloud Bigtable table. For Google Cloud Datastore backups: Exactly one URI can be specified. Also, the '*' wildcard character is not allowed.</summary>
    [JsonPropertyName("sourceUris")]
    public IList<string>? SourceUris { get; set; }

    /// <summary>Time-based partitioning specification for the destination table. Structure is documented below.</summary>
    [JsonPropertyName("timePartitioning")]
    public IList<V1beta1JobSpecInitProviderLoadTimePartitioning>? TimePartitioning { get; set; }

    /// <summary>Specifies the action that occurs if the destination table already exists. The following values are supported: WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result. WRITE_APPEND: If the table already exists, BigQuery appends the data to the table. WRITE_EMPTY: If the table already exists and contains data, a 'duplicate' error is returned in the job result. Each action is atomic and only occurs if BigQuery is able to complete the job successfully. Creation, truncation and append actions occur as one atomic update upon job completion. Default value is WRITE_EMPTY. Possible values are: WRITE_TRUNCATE, WRITE_APPEND, WRITE_EMPTY.</summary>
    [JsonPropertyName("writeDisposition")]
    public string? WriteDisposition { get; set; }
}

public enum V1beta1JobSpecInitProviderQueryDefaultDatasetDatasetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecInitProviderQueryDefaultDatasetDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecInitProviderQueryDefaultDatasetDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderQueryDefaultDatasetDatasetIdRefPolicyResolutionEnum>))]
    public V1beta1JobSpecInitProviderQueryDefaultDatasetDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderQueryDefaultDatasetDatasetIdRefPolicyResolveEnum>))]
    public V1beta1JobSpecInitProviderQueryDefaultDatasetDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecInitProviderQueryDefaultDatasetDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderQueryDefaultDatasetDatasetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecInitProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecInitProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecInitProviderQueryDefaultDatasetDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobSpecInitProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolveEnum>))]
    public V1beta1JobSpecInitProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecInitProviderQueryDefaultDatasetDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderQueryDefaultDatasetDatasetIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1JobSpecInitProviderQueryDefaultDataset
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1JobSpecInitProviderQueryDefaultDatasetDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1JobSpecInitProviderQueryDefaultDatasetDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

public partial class V1beta1JobSpecInitProviderQueryDestinationEncryptionConfiguration
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

public enum V1beta1JobSpecInitProviderQueryDestinationTableDatasetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecInitProviderQueryDestinationTableDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecInitProviderQueryDestinationTableDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderQueryDestinationTableDatasetIdRefPolicyResolutionEnum>))]
    public V1beta1JobSpecInitProviderQueryDestinationTableDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderQueryDestinationTableDatasetIdRefPolicyResolveEnum>))]
    public V1beta1JobSpecInitProviderQueryDestinationTableDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecInitProviderQueryDestinationTableDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderQueryDestinationTableDatasetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecInitProviderQueryDestinationTableDatasetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecInitProviderQueryDestinationTableDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecInitProviderQueryDestinationTableDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderQueryDestinationTableDatasetIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobSpecInitProviderQueryDestinationTableDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderQueryDestinationTableDatasetIdSelectorPolicyResolveEnum>))]
    public V1beta1JobSpecInitProviderQueryDestinationTableDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecInitProviderQueryDestinationTableDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderQueryDestinationTableDatasetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecInitProviderQueryDestinationTableTableIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecInitProviderQueryDestinationTableTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecInitProviderQueryDestinationTableTableIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderQueryDestinationTableTableIdRefPolicyResolutionEnum>))]
    public V1beta1JobSpecInitProviderQueryDestinationTableTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderQueryDestinationTableTableIdRefPolicyResolveEnum>))]
    public V1beta1JobSpecInitProviderQueryDestinationTableTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecInitProviderQueryDestinationTableTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderQueryDestinationTableTableIdRefPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecInitProviderQueryDestinationTableTableIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecInitProviderQueryDestinationTableTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecInitProviderQueryDestinationTableTableIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderQueryDestinationTableTableIdSelectorPolicyResolutionEnum>))]
    public V1beta1JobSpecInitProviderQueryDestinationTableTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderQueryDestinationTableTableIdSelectorPolicyResolveEnum>))]
    public V1beta1JobSpecInitProviderQueryDestinationTableTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecInitProviderQueryDestinationTableTableIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderQueryDestinationTableTableIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1JobSpecInitProviderQueryDestinationTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1JobSpecInitProviderQueryDestinationTableDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1JobSpecInitProviderQueryDestinationTableDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The table. Can be specified {{table_id}} if project_id and dataset_id are also set, or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta1JobSpecInitProviderQueryDestinationTableTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta1JobSpecInitProviderQueryDestinationTableTableIdSelector? TableIdSelector { get; set; }
}

public partial class V1beta1JobSpecInitProviderQueryScriptOptions
{
    /// <summary>Determines which statement in the script represents the "key result", used to populate the schema and query results of the script job. Possible values are: LAST, FIRST_SELECT.</summary>
    [JsonPropertyName("keyResultStatement")]
    public string? KeyResultStatement { get; set; }

    /// <summary>Limit on the number of bytes billed per statement. Exceeding this budget results in an error.</summary>
    [JsonPropertyName("statementByteBudget")]
    public string? StatementByteBudget { get; set; }

    /// <summary>Timeout period for each statement in a script.</summary>
    [JsonPropertyName("statementTimeoutMs")]
    public string? StatementTimeoutMs { get; set; }
}

public partial class V1beta1JobSpecInitProviderQueryUserDefinedFunctionResources
{
    /// <summary>An inline resource that contains code for a user-defined function (UDF). Providing a inline code resource is equivalent to providing a URI for a file containing the same code.</summary>
    [JsonPropertyName("inlineCode")]
    public string? InlineCode { get; set; }

    /// <summary>A code resource to load from a Google Cloud Storage URI (gs://bucket/path).</summary>
    [JsonPropertyName("resourceUri")]
    public string? ResourceUri { get; set; }
}

public partial class V1beta1JobSpecInitProviderQuery
{
    /// <summary>If true and query uses legacy SQL dialect, allows the query to produce arbitrarily large result tables at a slight cost in performance. Requires destinationTable to be set. For standard SQL queries, this flag is ignored and large results are always allowed. However, you must still set destinationTable when result size exceeds the allowed maximum response size.</summary>
    [JsonPropertyName("allowLargeResults")]
    public bool? AllowLargeResults { get; set; }

    /// <summary>Specifies whether the job is allowed to create new tables. The following values are supported: CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table. CREATE_NEVER: The table must already exist. If it does not, a 'notFound' error is returned in the job result. Creation, truncation and append actions occur as one atomic update upon job completion Default value is CREATE_IF_NEEDED. Possible values are: CREATE_IF_NEEDED, CREATE_NEVER.</summary>
    [JsonPropertyName("createDisposition")]
    public string? CreateDisposition { get; set; }

    /// <summary>Specifies the default dataset to use for unqualified table names in the query. Note that this does not alter behavior of unqualified dataset names. Structure is documented below.</summary>
    [JsonPropertyName("defaultDataset")]
    public IList<V1beta1JobSpecInitProviderQueryDefaultDataset>? DefaultDataset { get; set; }

    /// <summary>Custom encryption configuration (e.g., Cloud KMS keys) Structure is documented below.</summary>
    [JsonPropertyName("destinationEncryptionConfiguration")]
    public IList<V1beta1JobSpecInitProviderQueryDestinationEncryptionConfiguration>? DestinationEncryptionConfiguration { get; set; }

    /// <summary>Describes the table where the query results should be stored. This property must be set for large results that exceed the maximum response size. For queries that produce anonymous (cached) results, this field will be populated by BigQuery. Structure is documented below.</summary>
    [JsonPropertyName("destinationTable")]
    public IList<V1beta1JobSpecInitProviderQueryDestinationTable>? DestinationTable { get; set; }

    /// <summary>If true and query uses legacy SQL dialect, flattens all nested and repeated fields in the query results. allowLargeResults must be true if this is set to false. For standard SQL queries, this flag is ignored and results are never flattened.</summary>
    [JsonPropertyName("flattenResults")]
    public bool? FlattenResults { get; set; }

    /// <summary>Limits the billing tier for this job. Queries that have resource usage beyond this tier will fail (without incurring a charge). If unspecified, this will be set to your project default.</summary>
    [JsonPropertyName("maximumBillingTier")]
    public double? MaximumBillingTier { get; set; }

    /// <summary>Limits the bytes billed for this job. Queries that will have bytes billed beyond this limit will fail (without incurring a charge). If unspecified, this will be set to your project default.</summary>
    [JsonPropertyName("maximumBytesBilled")]
    public string? MaximumBytesBilled { get; set; }

    /// <summary>Standard SQL only. Set to POSITIONAL to use positional (?) query parameters or to NAMED to use named (@myparam) query parameters in this query.</summary>
    [JsonPropertyName("parameterMode")]
    public string? ParameterMode { get; set; }

    /// <summary>Specifies a priority for the query. Default value is INTERACTIVE. Possible values are: INTERACTIVE, BATCH.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>SQL query text to execute. The useLegacySql field can be used to indicate whether the query uses legacy SQL or standard SQL. NOTE: queries containing DML language (DELETE, UPDATE, MERGE, INSERT) must specify create_disposition = "" and write_disposition = "".</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>Allows the schema of the destination table to be updated as a side effect of the query job. Schema update options are supported in two cases: when writeDisposition is WRITE_APPEND; when writeDisposition is WRITE_TRUNCATE and the destination table is a partition of a table, specified by partition decorators. For normal tables, WRITE_TRUNCATE will always overwrite the schema. One or more of the following values are specified: ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema. ALLOW_FIELD_RELAXATION: allow relaxing a required field in the original schema to nullable.</summary>
    [JsonPropertyName("schemaUpdateOptions")]
    public IList<string>? SchemaUpdateOptions { get; set; }

    /// <summary>Options controlling the execution of scripts. Structure is documented below.</summary>
    [JsonPropertyName("scriptOptions")]
    public IList<V1beta1JobSpecInitProviderQueryScriptOptions>? ScriptOptions { get; set; }

    /// <summary>Specifies whether to use BigQuery's legacy SQL dialect for this query. The default value is true. If set to false, the query will use BigQuery's standard SQL.</summary>
    [JsonPropertyName("useLegacySql")]
    public bool? UseLegacySql { get; set; }

    /// <summary>Whether to look for the result in the query cache. The query cache is a best-effort cache that will be flushed whenever tables in the query are modified. Moreover, the query cache is only available when a query does not have a destination table specified. The default value is true.</summary>
    [JsonPropertyName("useQueryCache")]
    public bool? UseQueryCache { get; set; }

    /// <summary>Describes user-defined function resources used in the query. Structure is documented below.</summary>
    [JsonPropertyName("userDefinedFunctionResources")]
    public IList<V1beta1JobSpecInitProviderQueryUserDefinedFunctionResources>? UserDefinedFunctionResources { get; set; }

    /// <summary>Specifies the action that occurs if the destination table already exists. The following values are supported: WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result. WRITE_APPEND: If the table already exists, BigQuery appends the data to the table. WRITE_EMPTY: If the table already exists and contains data, a 'duplicate' error is returned in the job result. Each action is atomic and only occurs if BigQuery is able to complete the job successfully. Creation, truncation and append actions occur as one atomic update upon job completion. Default value is WRITE_EMPTY. Possible values are: WRITE_TRUNCATE, WRITE_APPEND, WRITE_EMPTY.</summary>
    [JsonPropertyName("writeDisposition")]
    public string? WriteDisposition { get; set; }
}

public partial class V1beta1JobSpecInitProvider
{
    /// <summary>Copies a table. Structure is documented below.</summary>
    [JsonPropertyName("copy")]
    public IList<V1beta1JobSpecInitProviderCopy>? Copy { get; set; }

    /// <summary>Configures an extract job. Structure is documented below.</summary>
    [JsonPropertyName("extract")]
    public IList<V1beta1JobSpecInitProviderExtract>? Extract { get; set; }

    /// <summary>The ID of the job. The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }

    /// <summary>Job timeout in milliseconds. If this time limit is exceeded, BigQuery may attempt to terminate the job.</summary>
    [JsonPropertyName("jobTimeoutMs")]
    public string? JobTimeoutMs { get; set; }

    /// <summary>The labels associated with this job. You can use these to organize and group your jobs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Configures a load job. Structure is documented below.</summary>
    [JsonPropertyName("load")]
    public IList<V1beta1JobSpecInitProviderLoad>? Load { get; set; }

    /// <summary>The geographic location of the job. The default value is US.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Configures a query job. Structure is documented below.</summary>
    [JsonPropertyName("query")]
    public IList<V1beta1JobSpecInitProviderQuery>? Query { get; set; }
}

public enum V1beta1JobSpecManagementPoliciesEnum
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

public enum V1beta1JobSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1JobSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1JobSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1JobSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1JobSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1JobSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1JobSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1JobSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1JobSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1JobSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1JobSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1JobSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1JobSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1JobSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1JobSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecDeletionPolicyEnum>))]
    public V1beta1JobSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1JobSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1JobSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1JobSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1JobSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1JobSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1JobSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1JobStatusAtProviderCopyDestinationEncryptionConfiguration
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>(Output) Describes the Cloud KMS encryption key version used to protect destination BigQuery table.</summary>
    [JsonPropertyName("kmsKeyVersion")]
    public string? KmsKeyVersion { get; set; }
}

public partial class V1beta1JobStatusAtProviderCopyDestinationTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The table. Can be specified {{table_id}} if project_id and dataset_id are also set, or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

public partial class V1beta1JobStatusAtProviderCopySourceTables
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The table. Can be specified {{table_id}} if project_id and dataset_id are also set, or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

public partial class V1beta1JobStatusAtProviderCopy
{
    /// <summary>Specifies whether the job is allowed to create new tables. The following values are supported: CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table. CREATE_NEVER: The table must already exist. If it does not, a 'notFound' error is returned in the job result. Creation, truncation and append actions occur as one atomic update upon job completion Default value is CREATE_IF_NEEDED. Possible values are: CREATE_IF_NEEDED, CREATE_NEVER.</summary>
    [JsonPropertyName("createDisposition")]
    public string? CreateDisposition { get; set; }

    /// <summary>Custom encryption configuration (e.g., Cloud KMS keys) Structure is documented below.</summary>
    [JsonPropertyName("destinationEncryptionConfiguration")]
    public IList<V1beta1JobStatusAtProviderCopyDestinationEncryptionConfiguration>? DestinationEncryptionConfiguration { get; set; }

    /// <summary>The destination table. Structure is documented below.</summary>
    [JsonPropertyName("destinationTable")]
    public IList<V1beta1JobStatusAtProviderCopyDestinationTable>? DestinationTable { get; set; }

    /// <summary>Source tables to copy. Structure is documented below.</summary>
    [JsonPropertyName("sourceTables")]
    public IList<V1beta1JobStatusAtProviderCopySourceTables>? SourceTables { get; set; }

    /// <summary>Specifies the action that occurs if the destination table already exists. The following values are supported: WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result. WRITE_APPEND: If the table already exists, BigQuery appends the data to the table. WRITE_EMPTY: If the table already exists and contains data, a 'duplicate' error is returned in the job result. Each action is atomic and only occurs if BigQuery is able to complete the job successfully. Creation, truncation and append actions occur as one atomic update upon job completion. Default value is WRITE_EMPTY. Possible values are: WRITE_TRUNCATE, WRITE_APPEND, WRITE_EMPTY.</summary>
    [JsonPropertyName("writeDisposition")]
    public string? WriteDisposition { get; set; }
}

public partial class V1beta1JobStatusAtProviderExtractSourceModel
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the model.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

public partial class V1beta1JobStatusAtProviderExtractSourceTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The table. Can be specified {{table_id}} if project_id and dataset_id are also set, or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

public partial class V1beta1JobStatusAtProviderExtract
{
    /// <summary>The compression type to use for exported files. Possible values include GZIP, DEFLATE, SNAPPY, and NONE. The default value is NONE. DEFLATE and SNAPPY are only supported for Avro.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>The exported file format. Possible values include CSV, NEWLINE_DELIMITED_JSON and AVRO for tables and SAVED_MODEL for models. The default value for tables is CSV. Tables with nested or repeated fields cannot be exported as CSV. The default value for models is SAVED_MODEL.</summary>
    [JsonPropertyName("destinationFormat")]
    public string? DestinationFormat { get; set; }

    /// <summary>A list of fully-qualified Google Cloud Storage URIs where the extracted table should be written.</summary>
    [JsonPropertyName("destinationUris")]
    public IList<string>? DestinationUris { get; set; }

    /// <summary>When extracting data in CSV format, this defines the delimiter to use between fields in the exported data. Default is ','</summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>Whether to print out a header row in the results. Default is true.</summary>
    [JsonPropertyName("printHeader")]
    public bool? PrintHeader { get; set; }

    /// <summary>A reference to the model being exported. Structure is documented below.</summary>
    [JsonPropertyName("sourceModel")]
    public IList<V1beta1JobStatusAtProviderExtractSourceModel>? SourceModel { get; set; }

    /// <summary>A reference to the table being exported. Structure is documented below.</summary>
    [JsonPropertyName("sourceTable")]
    public IList<V1beta1JobStatusAtProviderExtractSourceTable>? SourceTable { get; set; }

    /// <summary>Whether to use logical types when extracting to AVRO format.</summary>
    [JsonPropertyName("useAvroLogicalTypes")]
    public bool? UseAvroLogicalTypes { get; set; }
}

public partial class V1beta1JobStatusAtProviderLoadDestinationEncryptionConfiguration
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>(Output) Describes the Cloud KMS encryption key version used to protect destination BigQuery table.</summary>
    [JsonPropertyName("kmsKeyVersion")]
    public string? KmsKeyVersion { get; set; }
}

public partial class V1beta1JobStatusAtProviderLoadDestinationTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The table. Can be specified {{table_id}} if project_id and dataset_id are also set, or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

public partial class V1beta1JobStatusAtProviderLoadParquetOptions
{
    /// <summary>If sourceFormat is set to PARQUET, indicates whether to use schema inference specifically for Parquet LIST logical type.</summary>
    [JsonPropertyName("enableListInference")]
    public bool? EnableListInference { get; set; }

    /// <summary>If sourceFormat is set to PARQUET, indicates whether to infer Parquet ENUM logical type as STRING instead of BYTES by default.</summary>
    [JsonPropertyName("enumAsString")]
    public bool? EnumAsString { get; set; }
}

public partial class V1beta1JobStatusAtProviderLoadTimePartitioning
{
    /// <summary>Number of milliseconds for which to keep the storage for a partition. A wrapper is used here because 0 is an invalid value.</summary>
    [JsonPropertyName("expirationMs")]
    public string? ExpirationMs { get; set; }

    /// <summary>If not set, the table is partitioned by pseudo column '_PARTITIONTIME'; if set, the table is partitioned by this field. The field must be a top-level TIMESTAMP or DATE field. Its mode must be NULLABLE or REQUIRED. A wrapper is used here because an empty string is an invalid value.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>The only type supported is DAY, which will generate one partition per day. Providing an empty string used to cause an error, but in OnePlatform the field will be treated as unset.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1JobStatusAtProviderLoad
{
    /// <summary>Accept rows that are missing trailing optional columns. The missing values are treated as nulls. If false, records with missing trailing columns are treated as bad records, and if there are too many bad records, an invalid error is returned in the job result. The default value is false. Only applicable to CSV, ignored for other formats.</summary>
    [JsonPropertyName("allowJaggedRows")]
    public bool? AllowJaggedRows { get; set; }

    /// <summary>Indicates if BigQuery should allow quoted data sections that contain newline characters in a CSV file. The default value is false.</summary>
    [JsonPropertyName("allowQuotedNewlines")]
    public bool? AllowQuotedNewlines { get; set; }

    /// <summary>Indicates if we should automatically infer the options and schema for CSV and JSON sources.</summary>
    [JsonPropertyName("autodetect")]
    public bool? Autodetect { get; set; }

    /// <summary>Specifies whether the job is allowed to create new tables. The following values are supported: CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table. CREATE_NEVER: The table must already exist. If it does not, a 'notFound' error is returned in the job result. Creation, truncation and append actions occur as one atomic update upon job completion Default value is CREATE_IF_NEEDED. Possible values are: CREATE_IF_NEEDED, CREATE_NEVER.</summary>
    [JsonPropertyName("createDisposition")]
    public string? CreateDisposition { get; set; }

    /// <summary>Custom encryption configuration (e.g., Cloud KMS keys) Structure is documented below.</summary>
    [JsonPropertyName("destinationEncryptionConfiguration")]
    public IList<V1beta1JobStatusAtProviderLoadDestinationEncryptionConfiguration>? DestinationEncryptionConfiguration { get; set; }

    /// <summary>The destination table to load the data into. Structure is documented below.</summary>
    [JsonPropertyName("destinationTable")]
    public IList<V1beta1JobStatusAtProviderLoadDestinationTable>? DestinationTable { get; set; }

    /// <summary>The character encoding of the data. The supported values are UTF-8 or ISO-8859-1. The default value is UTF-8. BigQuery decodes the data after the raw, binary data has been split using the values of the quote and fieldDelimiter properties.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The separator for fields in a CSV file. The separator can be any ISO-8859-1 single-byte character. To use a character in the range 128-255, you must encode the character as UTF8. BigQuery converts the string to ISO-8859-1 encoding, and then uses the first byte of the encoded string to split the data in its raw, binary state. BigQuery also supports the escape sequence "\t" to specify a tab separator. The default value is a comma (',').</summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>Indicates if BigQuery should allow extra values that are not represented in the table schema. If true, the extra values are ignored. If false, records with extra columns are treated as bad records, and if there are too many bad records, an invalid error is returned in the job result. The default value is false. The sourceFormat property determines what BigQuery treats as an extra value: CSV: Trailing columns JSON: Named values that don't match any column names</summary>
    [JsonPropertyName("ignoreUnknownValues")]
    public bool? IgnoreUnknownValues { get; set; }

    /// <summary>If sourceFormat is set to newline-delimited JSON, indicates whether it should be processed as a JSON variant such as GeoJSON. For a sourceFormat other than JSON, omit this field. If the sourceFormat is newline-delimited JSON: - for newline-delimited GeoJSON: set to GEOJSON.</summary>
    [JsonPropertyName("jsonExtension")]
    public string? JsonExtension { get; set; }

    /// <summary>The maximum number of bad records that BigQuery can ignore when running the job. If the number of bad records exceeds this value, an invalid error is returned in the job result. The default value is 0, which requires that all records are valid.</summary>
    [JsonPropertyName("maxBadRecords")]
    public double? MaxBadRecords { get; set; }

    /// <summary>Specifies a string that represents a null value in a CSV file. For example, if you specify "\N", BigQuery interprets "\N" as a null value when loading a CSV file. The default value is the empty string. If you set this property to a custom value, BigQuery throws an error if an empty string is present for all data types except for STRING and BYTE. For STRING and BYTE columns, BigQuery interprets the empty string as an empty value.</summary>
    [JsonPropertyName("nullMarker")]
    public string? NullMarker { get; set; }

    /// <summary>Parquet Options for load and make external tables. Structure is documented below.</summary>
    [JsonPropertyName("parquetOptions")]
    public IList<V1beta1JobStatusAtProviderLoadParquetOptions>? ParquetOptions { get; set; }

    /// <summary>If sourceFormat is set to "DATASTORE_BACKUP", indicates which entity properties to load into BigQuery from a Cloud Datastore backup. Property names are case sensitive and must be top-level properties. If no properties are specified, BigQuery loads all properties. If any named property isn't found in the Cloud Datastore backup, an invalid error is returned in the job result.</summary>
    [JsonPropertyName("projectionFields")]
    public IList<string>? ProjectionFields { get; set; }

    /// <summary>The value that is used to quote data sections in a CSV file. BigQuery converts the string to ISO-8859-1 encoding, and then uses the first byte of the encoded string to split the data in its raw, binary state. The default value is a double-quote ('"'). If your data does not contain quoted sections, set the property value to an empty string. If your data contains quoted newline characters, you must also set the allowQuotedNewlines property to true.</summary>
    [JsonPropertyName("quote")]
    public string? Quote { get; set; }

    /// <summary>Allows the schema of the destination table to be updated as a side effect of the load job if a schema is autodetected or supplied in the job configuration. Schema update options are supported in two cases: when writeDisposition is WRITE_APPEND; when writeDisposition is WRITE_TRUNCATE and the destination table is a partition of a table, specified by partition decorators. For normal tables, WRITE_TRUNCATE will always overwrite the schema. One or more of the following values are specified: ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema. ALLOW_FIELD_RELAXATION: allow relaxing a required field in the original schema to nullable.</summary>
    [JsonPropertyName("schemaUpdateOptions")]
    public IList<string>? SchemaUpdateOptions { get; set; }

    /// <summary>The number of rows at the top of a CSV file that BigQuery will skip when loading the data. The default value is 0. This property is useful if you have header rows in the file that should be skipped. When autodetect is on, the behavior is the following: skipLeadingRows unspecified - Autodetect tries to detect headers in the first row. If they are not detected, the row is read as data. Otherwise data is read starting from the second row. skipLeadingRows is 0 - Instructs autodetect that there are no headers and data should be read starting from the first row. skipLeadingRows = N &gt; 0 - Autodetect skips N-1 rows and tries to detect headers in row N. If headers are not detected, row N is just skipped. Otherwise row N is used to extract column names for the detected schema.</summary>
    [JsonPropertyName("skipLeadingRows")]
    public double? SkipLeadingRows { get; set; }

    /// <summary>The format of the data files. For CSV files, specify "CSV". For datastore backups, specify "DATASTORE_BACKUP". For newline-delimited JSON, specify "NEWLINE_DELIMITED_JSON". For Avro, specify "AVRO". For parquet, specify "PARQUET". For orc, specify "ORC". [Beta] For Bigtable, specify "BIGTABLE". The default value is CSV.</summary>
    [JsonPropertyName("sourceFormat")]
    public string? SourceFormat { get; set; }

    /// <summary>The fully-qualified URIs that point to your data in Google Cloud. For Google Cloud Storage URIs: Each URI can contain one '*' wildcard character and it must come after the 'bucket' name. Size limits related to load jobs apply to external data sources. For Google Cloud Bigtable URIs: Exactly one URI can be specified and it has be a fully specified and valid HTTPS URL for a Google Cloud Bigtable table. For Google Cloud Datastore backups: Exactly one URI can be specified. Also, the '*' wildcard character is not allowed.</summary>
    [JsonPropertyName("sourceUris")]
    public IList<string>? SourceUris { get; set; }

    /// <summary>Time-based partitioning specification for the destination table. Structure is documented below.</summary>
    [JsonPropertyName("timePartitioning")]
    public IList<V1beta1JobStatusAtProviderLoadTimePartitioning>? TimePartitioning { get; set; }

    /// <summary>Specifies the action that occurs if the destination table already exists. The following values are supported: WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result. WRITE_APPEND: If the table already exists, BigQuery appends the data to the table. WRITE_EMPTY: If the table already exists and contains data, a 'duplicate' error is returned in the job result. Each action is atomic and only occurs if BigQuery is able to complete the job successfully. Creation, truncation and append actions occur as one atomic update upon job completion. Default value is WRITE_EMPTY. Possible values are: WRITE_TRUNCATE, WRITE_APPEND, WRITE_EMPTY.</summary>
    [JsonPropertyName("writeDisposition")]
    public string? WriteDisposition { get; set; }
}

public partial class V1beta1JobStatusAtProviderQueryDefaultDataset
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

public partial class V1beta1JobStatusAtProviderQueryDestinationEncryptionConfiguration
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>(Output) Describes the Cloud KMS encryption key version used to protect destination BigQuery table.</summary>
    [JsonPropertyName("kmsKeyVersion")]
    public string? KmsKeyVersion { get; set; }
}

public partial class V1beta1JobStatusAtProviderQueryDestinationTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The table. Can be specified {{table_id}} if project_id and dataset_id are also set, or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

public partial class V1beta1JobStatusAtProviderQueryScriptOptions
{
    /// <summary>Determines which statement in the script represents the "key result", used to populate the schema and query results of the script job. Possible values are: LAST, FIRST_SELECT.</summary>
    [JsonPropertyName("keyResultStatement")]
    public string? KeyResultStatement { get; set; }

    /// <summary>Limit on the number of bytes billed per statement. Exceeding this budget results in an error.</summary>
    [JsonPropertyName("statementByteBudget")]
    public string? StatementByteBudget { get; set; }

    /// <summary>Timeout period for each statement in a script.</summary>
    [JsonPropertyName("statementTimeoutMs")]
    public string? StatementTimeoutMs { get; set; }
}

public partial class V1beta1JobStatusAtProviderQueryUserDefinedFunctionResources
{
    /// <summary>An inline resource that contains code for a user-defined function (UDF). Providing a inline code resource is equivalent to providing a URI for a file containing the same code.</summary>
    [JsonPropertyName("inlineCode")]
    public string? InlineCode { get; set; }

    /// <summary>A code resource to load from a Google Cloud Storage URI (gs://bucket/path).</summary>
    [JsonPropertyName("resourceUri")]
    public string? ResourceUri { get; set; }
}

public partial class V1beta1JobStatusAtProviderQuery
{
    /// <summary>If true and query uses legacy SQL dialect, allows the query to produce arbitrarily large result tables at a slight cost in performance. Requires destinationTable to be set. For standard SQL queries, this flag is ignored and large results are always allowed. However, you must still set destinationTable when result size exceeds the allowed maximum response size.</summary>
    [JsonPropertyName("allowLargeResults")]
    public bool? AllowLargeResults { get; set; }

    /// <summary>Specifies whether the job is allowed to create new tables. The following values are supported: CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table. CREATE_NEVER: The table must already exist. If it does not, a 'notFound' error is returned in the job result. Creation, truncation and append actions occur as one atomic update upon job completion Default value is CREATE_IF_NEEDED. Possible values are: CREATE_IF_NEEDED, CREATE_NEVER.</summary>
    [JsonPropertyName("createDisposition")]
    public string? CreateDisposition { get; set; }

    /// <summary>Specifies the default dataset to use for unqualified table names in the query. Note that this does not alter behavior of unqualified dataset names. Structure is documented below.</summary>
    [JsonPropertyName("defaultDataset")]
    public IList<V1beta1JobStatusAtProviderQueryDefaultDataset>? DefaultDataset { get; set; }

    /// <summary>Custom encryption configuration (e.g., Cloud KMS keys) Structure is documented below.</summary>
    [JsonPropertyName("destinationEncryptionConfiguration")]
    public IList<V1beta1JobStatusAtProviderQueryDestinationEncryptionConfiguration>? DestinationEncryptionConfiguration { get; set; }

    /// <summary>Describes the table where the query results should be stored. This property must be set for large results that exceed the maximum response size. For queries that produce anonymous (cached) results, this field will be populated by BigQuery. Structure is documented below.</summary>
    [JsonPropertyName("destinationTable")]
    public IList<V1beta1JobStatusAtProviderQueryDestinationTable>? DestinationTable { get; set; }

    /// <summary>If true and query uses legacy SQL dialect, flattens all nested and repeated fields in the query results. allowLargeResults must be true if this is set to false. For standard SQL queries, this flag is ignored and results are never flattened.</summary>
    [JsonPropertyName("flattenResults")]
    public bool? FlattenResults { get; set; }

    /// <summary>Limits the billing tier for this job. Queries that have resource usage beyond this tier will fail (without incurring a charge). If unspecified, this will be set to your project default.</summary>
    [JsonPropertyName("maximumBillingTier")]
    public double? MaximumBillingTier { get; set; }

    /// <summary>Limits the bytes billed for this job. Queries that will have bytes billed beyond this limit will fail (without incurring a charge). If unspecified, this will be set to your project default.</summary>
    [JsonPropertyName("maximumBytesBilled")]
    public string? MaximumBytesBilled { get; set; }

    /// <summary>Standard SQL only. Set to POSITIONAL to use positional (?) query parameters or to NAMED to use named (@myparam) query parameters in this query.</summary>
    [JsonPropertyName("parameterMode")]
    public string? ParameterMode { get; set; }

    /// <summary>Specifies a priority for the query. Default value is INTERACTIVE. Possible values are: INTERACTIVE, BATCH.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>SQL query text to execute. The useLegacySql field can be used to indicate whether the query uses legacy SQL or standard SQL. NOTE: queries containing DML language (DELETE, UPDATE, MERGE, INSERT) must specify create_disposition = "" and write_disposition = "".</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>Allows the schema of the destination table to be updated as a side effect of the query job. Schema update options are supported in two cases: when writeDisposition is WRITE_APPEND; when writeDisposition is WRITE_TRUNCATE and the destination table is a partition of a table, specified by partition decorators. For normal tables, WRITE_TRUNCATE will always overwrite the schema. One or more of the following values are specified: ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema. ALLOW_FIELD_RELAXATION: allow relaxing a required field in the original schema to nullable.</summary>
    [JsonPropertyName("schemaUpdateOptions")]
    public IList<string>? SchemaUpdateOptions { get; set; }

    /// <summary>Options controlling the execution of scripts. Structure is documented below.</summary>
    [JsonPropertyName("scriptOptions")]
    public IList<V1beta1JobStatusAtProviderQueryScriptOptions>? ScriptOptions { get; set; }

    /// <summary>Specifies whether to use BigQuery's legacy SQL dialect for this query. The default value is true. If set to false, the query will use BigQuery's standard SQL.</summary>
    [JsonPropertyName("useLegacySql")]
    public bool? UseLegacySql { get; set; }

    /// <summary>Whether to look for the result in the query cache. The query cache is a best-effort cache that will be flushed whenever tables in the query are modified. Moreover, the query cache is only available when a query does not have a destination table specified. The default value is true.</summary>
    [JsonPropertyName("useQueryCache")]
    public bool? UseQueryCache { get; set; }

    /// <summary>Describes user-defined function resources used in the query. Structure is documented below.</summary>
    [JsonPropertyName("userDefinedFunctionResources")]
    public IList<V1beta1JobStatusAtProviderQueryUserDefinedFunctionResources>? UserDefinedFunctionResources { get; set; }

    /// <summary>Specifies the action that occurs if the destination table already exists. The following values are supported: WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result. WRITE_APPEND: If the table already exists, BigQuery appends the data to the table. WRITE_EMPTY: If the table already exists and contains data, a 'duplicate' error is returned in the job result. Each action is atomic and only occurs if BigQuery is able to complete the job successfully. Creation, truncation and append actions occur as one atomic update upon job completion. Default value is WRITE_EMPTY. Possible values are: WRITE_TRUNCATE, WRITE_APPEND, WRITE_EMPTY.</summary>
    [JsonPropertyName("writeDisposition")]
    public string? WriteDisposition { get; set; }
}

public partial class V1beta1JobStatusAtProviderStatusErrorResult
{
    /// <summary>The geographic location of the job. The default value is US.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A human-readable description of the error.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>A short error code that summarizes the error.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

public partial class V1beta1JobStatusAtProviderStatusErrors
{
    /// <summary>The geographic location of the job. The default value is US.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A human-readable description of the error.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>A short error code that summarizes the error.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

public partial class V1beta1JobStatusAtProviderStatus
{
    /// <summary>(Output) Final error result of the job. If present, indicates that the job has completed and was unsuccessful. Structure is documented below.</summary>
    [JsonPropertyName("errorResult")]
    public IList<V1beta1JobStatusAtProviderStatusErrorResult>? ErrorResult { get; set; }

    /// <summary>(Output) The first errors encountered during the running of the job. The final message includes the number of errors that caused the process to stop. Errors here do not necessarily mean that the job has not completed or was unsuccessful. Structure is documented below.</summary>
    [JsonPropertyName("errors")]
    public IList<V1beta1JobStatusAtProviderStatusErrors>? Errors { get; set; }

    /// <summary>(Output) Running state of the job. Valid states include 'PENDING', 'RUNNING', and 'DONE'.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

public partial class V1beta1JobStatusAtProvider
{
    /// <summary>Copies a table. Structure is documented below.</summary>
    [JsonPropertyName("copy")]
    public IList<V1beta1JobStatusAtProviderCopy>? Copy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>Configures an extract job. Structure is documented below.</summary>
    [JsonPropertyName("extract")]
    public IList<V1beta1JobStatusAtProviderExtract>? Extract { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/jobs/{{job_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the job. The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }

    /// <summary>Job timeout in milliseconds. If this time limit is exceeded, BigQuery may attempt to terminate the job.</summary>
    [JsonPropertyName("jobTimeoutMs")]
    public string? JobTimeoutMs { get; set; }

    /// <summary>(Output) The type of the job.</summary>
    [JsonPropertyName("jobType")]
    public string? JobType { get; set; }

    /// <summary>The labels associated with this job. You can use these to organize and group your jobs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Configures a load job. Structure is documented below.</summary>
    [JsonPropertyName("load")]
    public IList<V1beta1JobStatusAtProviderLoad>? Load { get; set; }

    /// <summary>The geographic location of the job. The default value is US.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Configures a query job. Structure is documented below.</summary>
    [JsonPropertyName("query")]
    public IList<V1beta1JobStatusAtProviderQuery>? Query { get; set; }

    /// <summary>The status of this job. Examine this value when polling an asynchronous job to see if the job is complete. Structure is documented below.</summary>
    [JsonPropertyName("status")]
    public IList<V1beta1JobStatusAtProviderStatus>? Status { get; set; }

    /// <summary>(Output) The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>Email address of the user who ran the job.</summary>
    [JsonPropertyName("userEmail")]
    public string? UserEmail { get; set; }
}

public partial class V1beta1JobStatusConditions
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

public partial class V1beta1JobStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1JobStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1JobStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Job : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1JobSpec>, IStatus<V1beta1JobStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Job";
    public const string KubeGroup = "bigquery.gcp.upbound.io";
    public const string KubePluralName = "jobs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>JobSpec defines the desired state of Job</summary>
    [JsonPropertyName("spec")]
    public V1beta1JobSpec Spec { get; set; }

    /// <summary>JobStatus defines the observed state of Job.</summary>
    [JsonPropertyName("status")]
    public V1beta1JobStatus? Status { get; set; }
}