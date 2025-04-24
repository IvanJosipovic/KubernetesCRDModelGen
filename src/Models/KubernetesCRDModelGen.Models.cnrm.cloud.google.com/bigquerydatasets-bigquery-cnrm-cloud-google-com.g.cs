using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquery.cnrm.cloud.google.com;
/// <summary>The dataset this entry applies to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryDatasetSpecAccessDatasetDataset
{
    /// <summary>A unique Id for this dataset, without the project name. The Id must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("datasetId")]
    public string DatasetId { get; set; }

    /// <summary>The ID of the project containing this dataset.</summary>
    [JsonPropertyName("projectId")]
    public string ProjectId { get; set; }
}

/// <summary>[Pick one] A grant authorizing all resources of a particular type in a particular dataset access to this dataset. Only views are supported for now. The role field is not required when this field is set. If that dataset is deleted and re-created, its access needs to be granted again via an update operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryDatasetSpecAccessDataset
{
    /// <summary>The dataset this entry applies to.</summary>
    [JsonPropertyName("dataset")]
    public V1beta1BigQueryDatasetSpecAccessDatasetDataset Dataset { get; set; }

    /// <summary>Which resources in the dataset this entry applies to. Currently, only views are supported, but additional target types may be added in the future.</summary>
    [JsonPropertyName("targetTypes")]
    public IList<string> TargetTypes { get; set; }
}

/// <summary>[Pick one] A routine from a different dataset to grant access to. Queries executed against that routine will have read access to views/tables/routines in this dataset. Only UDF is supported for now. The role field is not required when this field is set. If that routine is updated by any user, access to the routine needs to be granted again via an update operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryDatasetSpecAccessRoutine
{
    /// <summary>The ID of the dataset containing this routine.</summary>
    [JsonPropertyName("datasetId")]
    public string DatasetId { get; set; }

    /// <summary>The ID of the project containing this routine.</summary>
    [JsonPropertyName("projectId")]
    public string ProjectId { get; set; }

    /// <summary>The Id of the routine. The Id must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 256 characters.</summary>
    [JsonPropertyName("routineId")]
    public string RoutineId { get; set; }
}

/// <summary>[Pick one] A view from a different dataset to grant access to. Queries executed against that view will have read access to views/tables/routines in this dataset. The role field is not required when this field is set. If that view is updated by any user, access to the view needs to be granted again via an update operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryDatasetSpecAccessView
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string ProjectId { get; set; }

    /// <summary>The Id of the table. The Id can contain Unicode characters in category L (letter), M (mark), N (number), Pc (connector, including underscore), Pd (dash), and Zs (space). For more information, see [General Category](https://wikipedia.org/wiki/Unicode_character_property#General_Category). The maximum length is 1,024 characters.  Certain operations allow suffixing of the table Id with a partition decorator, such as `sample_table$20190123`.</summary>
    [JsonPropertyName("tableId")]
    public string TableId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryDatasetSpecAccess
{
    /// <summary>[Pick one] A grant authorizing all resources of a particular type in a particular dataset access to this dataset. Only views are supported for now. The role field is not required when this field is set. If that dataset is deleted and re-created, its access needs to be granted again via an update operation.</summary>
    [JsonPropertyName("dataset")]
    public V1beta1BigQueryDatasetSpecAccessDataset? Dataset { get; set; }

    /// <summary>[Pick one] A domain to grant access to. Any users signed in with the domain specified will be granted the specified access. Example: "example.com". Maps to IAM policy member "domain:DOMAIN".</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>[Pick one] An email address of a Google Group to grant access to. Maps to IAM policy member "group:GROUP".</summary>
    [JsonPropertyName("groupByEmail")]
    public string? GroupByEmail { get; set; }

    /// <summary>[Pick one] Some other type of member that appears in the IAM Policy but isn't a user, group, domain, or special group.</summary>
    [JsonPropertyName("iamMember")]
    public string? IamMember { get; set; }

    /// <summary>An IAM role ID that should be granted to the user, group,  or domain specified in this access entry.  The following legacy mappings will be applied:   * `OWNER`: `roles/bigquery.dataOwner`  * `WRITER`: `roles/bigquery.dataEditor`  * `READER`: `roles/bigquery.dataViewer`   This field will accept any of the above formats, but will return only  the legacy format. For example, if you set this field to  "roles/bigquery.dataOwner", it will be returned back as "OWNER".</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>[Pick one] A routine from a different dataset to grant access to. Queries executed against that routine will have read access to views/tables/routines in this dataset. Only UDF is supported for now. The role field is not required when this field is set. If that routine is updated by any user, access to the routine needs to be granted again via an update operation.</summary>
    [JsonPropertyName("routine")]
    public V1beta1BigQueryDatasetSpecAccessRoutine? Routine { get; set; }

    /// <summary>[Pick one] A special group to grant access to. Possible values include:     * projectOwners: Owners of the enclosing project.    * projectReaders: Readers of the enclosing project.    * projectWriters: Writers of the enclosing project.    * allAuthenticatedUsers: All authenticated BigQuery users.   Maps to similarly-named IAM members.</summary>
    [JsonPropertyName("specialGroup")]
    public string? SpecialGroup { get; set; }

    /// <summary>[Pick one] An email address of a user to grant access to. For example: fred@example.com. Maps to IAM policy member "user:EMAIL" or "serviceAccount:EMAIL".</summary>
    [JsonPropertyName("userByEmail")]
    public string? UserByEmail { get; set; }

    /// <summary>[Pick one] A view from a different dataset to grant access to. Queries executed against that view will have read access to views/tables/routines in this dataset. The role field is not required when this field is set. If that view is updated by any user, access to the view needs to be granted again via an update operation.</summary>
    [JsonPropertyName("view")]
    public V1beta1BigQueryDatasetSpecAccessView? View { get; set; }
}

/// <summary>Optional. Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryDatasetSpecDefaultEncryptionConfigurationKmsKeyRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The default encryption key for all tables in the dataset. After this property is set, the encryption key of all newly-created tables in the dataset is set to this value unless the table creation request or query explicitly overrides the key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryDatasetSpecDefaultEncryptionConfiguration
{
    /// <summary>Optional. Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1BigQueryDatasetSpecDefaultEncryptionConfigurationKmsKeyRef? KmsKeyRef { get; set; }
}

/// <summary> Optional. The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryDatasetSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>BigQueryDatasetSpec defines the desired state of BigQueryDataset</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryDatasetSpec
{
    /// <summary>An array of objects that define dataset access for one or more entities.</summary>
    [JsonPropertyName("access")]
    public IList<V1beta1BigQueryDatasetSpecAccess>? Access { get; set; }

    /// <summary>Optional. Defines the default collation specification of future tables  created in the dataset. If a table is created in this dataset without  table-level default collation, then the table inherits the dataset default  collation, which is applied to the string fields that do not have explicit  collation specified. A change to this field affects only tables created  afterwards, and does not alter the existing tables.  The following values are supported:   * 'und:ci': undetermined locale, case-insensitive.  * '': empty string. Default to case-sensitive behavior.</summary>
    [JsonPropertyName("defaultCollation")]
    public string? DefaultCollation { get; set; }

    /// <summary>The default encryption key for all tables in the dataset. After this property is set, the encryption key of all newly-created tables in the dataset is set to this value unless the table creation request or query explicitly overrides the key.</summary>
    [JsonPropertyName("defaultEncryptionConfiguration")]
    public V1beta1BigQueryDatasetSpecDefaultEncryptionConfiguration? DefaultEncryptionConfiguration { get; set; }

    /// <summary>This default partition expiration, expressed in milliseconds.   When new time-partitioned tables are created in a dataset where this  property is set, the table will inherit this value, propagated as the  `TimePartitioning.expirationMs` property on the new table.  If you set  `TimePartitioning.expirationMs` explicitly when creating a table,  the `defaultPartitionExpirationMs` of the containing dataset is ignored.   When creating a partitioned table, if `defaultPartitionExpirationMs`  is set, the `defaultTableExpirationMs` value is ignored and the table  will not be inherit a table expiration deadline.</summary>
    [JsonPropertyName("defaultPartitionExpirationMs")]
    public long? DefaultPartitionExpirationMs { get; set; }

    /// <summary>Optional. The default lifetime of all tables in the dataset, in milliseconds. The minimum lifetime value is 3600000 milliseconds (one hour). To clear an existing default expiration with a PATCH request, set to 0. Once this property is set, all newly-created tables in the dataset will have an expirationTime property set to the creation time plus the value in this property, and changing the value will only affect new tables, not existing ones. When the expirationTime for a given table is reached, that table will be deleted automatically. If a table's expirationTime is modified or removed before the table expires, or if you provide an explicit expirationTime when creating a table, that value takes precedence over the default expiration time indicated by this property.</summary>
    [JsonPropertyName("defaultTableExpirationMs")]
    public long? DefaultTableExpirationMs { get; set; }

    /// <summary>Optional. A user-friendly description of the dataset.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. A descriptive name for the dataset.</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>Optional. TRUE if the dataset and its table names are case-insensitive, otherwise FALSE. By default, this is FALSE, which means the dataset and its table names are case-sensitive. This field does not affect routine references.</summary>
    [JsonPropertyName("isCaseInsensitive")]
    public bool? IsCaseInsensitive { get; set; }

    /// <summary>Optional. The geographic location where the dataset should reside. See https://cloud.google.com/bigquery/docs/locations for supported locations.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Optional. Defines the time travel window in hours. The value can be from 48 to 168 hours (2 to 7 days). The default value is 168 hours if this is not set.</summary>
    [JsonPropertyName("maxTimeTravelHours")]
    public string? MaxTimeTravelHours { get; set; }

    /// <summary> Optional. The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1BigQueryDatasetSpecProjectRef? ProjectRef { get; set; }

    /// <summary>The BigQueryDataset name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. Updates storage_billing_model for the dataset.</summary>
    [JsonPropertyName("storageBillingModel")]
    public string? StorageBillingModel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryDatasetStatusConditions
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryDatasetStatusObservedState
{
    /// <summary>Optional. If the location is not specified in the spec, the GCP server defaults to a location and will be captured here.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }
}

/// <summary>BigQueryDatasetStatus defines the config connector machine state of BigQueryDataset</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryDatasetStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BigQueryDatasetStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The time when this dataset was created, in milliseconds since the epoch.</summary>
    [JsonPropertyName("creationTime")]
    public long? CreationTime { get; set; }

    /// <summary>Output only. A hash of the resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>A unique specifier for the BigQueryAnalyticsHubDataExchangeListing resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>Output only. The date when this dataset was last modified, in milliseconds since the epoch.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public long? LastModifiedTime { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1BigQueryDatasetStatusObservedState? ObservedState { get; set; }

    /// <summary>Output only. A URL that can be used to access the resource again. You can use this URL in Get or Update requests to the resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

/// <summary>BigQueryDataset is the Schema for the BigQueryDataset API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BigQueryDataset : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BigQueryDatasetSpec>, IStatus<V1beta1BigQueryDatasetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BigQueryDataset";
    public const string KubeGroup = "bigquery.cnrm.cloud.google.com";
    public const string KubePluralName = "bigquerydatasets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BigQueryDatasetSpec defines the desired state of BigQueryDataset</summary>
    [JsonPropertyName("spec")]
    public V1beta1BigQueryDatasetSpec? Spec { get; set; }

    /// <summary>BigQueryDatasetStatus defines the config connector machine state of BigQueryDataset</summary>
    [JsonPropertyName("status")]
    public V1beta1BigQueryDatasetStatus? Status { get; set; }
}

/// <summary>BigQueryDataset is the Schema for the BigQueryDataset API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BigQueryDatasetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BigQueryDataset>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BigQueryDatasetList";
    public const string KubeGroup = "bigquery.cnrm.cloud.google.com";
    public const string KubePluralName = "bigquerydatasets";
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
    public IList<V1beta1BigQueryDataset> Items { get; set; }
}