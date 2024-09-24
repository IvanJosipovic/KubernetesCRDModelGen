using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lakeformation.aws.upbound.io;
public enum V1beta1PermissionsSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1PermissionsSpecForProviderDataCellsFilter
{
    /// <summary>The name of the database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The name of the data cells filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Data Catalog.</summary>
    [JsonPropertyName("tableCatalogId")]
    public string? TableCatalogId { get; set; }

    /// <summary>The name of the table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

public enum V1beta1PermissionsSpecForProviderDataLocationArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionsSpecForProviderDataLocationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PermissionsSpecForProviderDataLocationArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecForProviderDataLocationArnRefPolicyResolutionEnum>))]
    public V1beta1PermissionsSpecForProviderDataLocationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecForProviderDataLocationArnRefPolicyResolveEnum>))]
    public V1beta1PermissionsSpecForProviderDataLocationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Resource in lakeformation to populate arn.</summary>
public partial class V1beta1PermissionsSpecForProviderDataLocationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionsSpecForProviderDataLocationArnRefPolicy? Policy { get; set; }
}

public enum V1beta1PermissionsSpecForProviderDataLocationArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionsSpecForProviderDataLocationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PermissionsSpecForProviderDataLocationArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecForProviderDataLocationArnSelectorPolicyResolutionEnum>))]
    public V1beta1PermissionsSpecForProviderDataLocationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecForProviderDataLocationArnSelectorPolicyResolveEnum>))]
    public V1beta1PermissionsSpecForProviderDataLocationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Resource in lakeformation to populate arn.</summary>
public partial class V1beta1PermissionsSpecForProviderDataLocationArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionsSpecForProviderDataLocationArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsSpecForProviderDataLocation
{
    /// <summary>–  Amazon Resource Name (ARN) that uniquely identifies the data location resource.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a Resource in lakeformation to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1PermissionsSpecForProviderDataLocationArnRef? ArnRef { get; set; }

    /// <summary>Selector for a Resource in lakeformation to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1PermissionsSpecForProviderDataLocationArnSelector? ArnSelector { get; set; }

    /// <summary>Identifier for the Data Catalog where the location is registered with Lake Formation. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }
}

public enum V1beta1PermissionsSpecForProviderDatabaseNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionsSpecForProviderDatabaseNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PermissionsSpecForProviderDatabaseNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecForProviderDatabaseNameRefPolicyResolutionEnum>))]
    public V1beta1PermissionsSpecForProviderDatabaseNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecForProviderDatabaseNameRefPolicyResolveEnum>))]
    public V1beta1PermissionsSpecForProviderDatabaseNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CatalogDatabase in glue to populate name.</summary>
public partial class V1beta1PermissionsSpecForProviderDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionsSpecForProviderDatabaseNameRefPolicy? Policy { get; set; }
}

public enum V1beta1PermissionsSpecForProviderDatabaseNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionsSpecForProviderDatabaseNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PermissionsSpecForProviderDatabaseNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecForProviderDatabaseNameSelectorPolicyResolutionEnum>))]
    public V1beta1PermissionsSpecForProviderDatabaseNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecForProviderDatabaseNameSelectorPolicyResolveEnum>))]
    public V1beta1PermissionsSpecForProviderDatabaseNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CatalogDatabase in glue to populate name.</summary>
public partial class V1beta1PermissionsSpecForProviderDatabaseNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionsSpecForProviderDatabaseNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsSpecForProviderDatabase
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>–  Name of the database resource. Unique to the Data Catalog.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a CatalogDatabase in glue to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1PermissionsSpecForProviderDatabaseNameRef? NameRef { get; set; }

    /// <summary>Selector for a CatalogDatabase in glue to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1PermissionsSpecForProviderDatabaseNameSelector? NameSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsSpecForProviderLfTag
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>name for the tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A list of possible values an attribute can take.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsSpecForProviderLfTagPolicyExpression
{
    /// <summary>name of an LF-Tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A list of possible values of an LF-Tag.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsSpecForProviderLfTagPolicy
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>A list of tag conditions that apply to the resource's tag policy. Configuration block for tag conditions that apply to the policy. See expression below.</summary>
    [JsonPropertyName("expression")]
    public IList<V1beta1PermissionsSpecForProviderLfTagPolicyExpression>? Expression { get; set; }

    /// <summary>–  The resource type for which the tag policy applies. Valid values are DATABASE and TABLE.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsSpecForProviderTable
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>–  Name of the database for the table. Unique to a Data Catalog.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Name of the table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether to use a wildcard representing every table under a database. Defaults to false.</summary>
    [JsonPropertyName("wildcard")]
    public bool? Wildcard { get; set; }
}

public enum V1beta1PermissionsSpecForProviderTableWithColumnsNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionsSpecForProviderTableWithColumnsNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PermissionsSpecForProviderTableWithColumnsNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecForProviderTableWithColumnsNameRefPolicyResolutionEnum>))]
    public V1beta1PermissionsSpecForProviderTableWithColumnsNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecForProviderTableWithColumnsNameRefPolicyResolveEnum>))]
    public V1beta1PermissionsSpecForProviderTableWithColumnsNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CatalogTable in glue to populate name.</summary>
public partial class V1beta1PermissionsSpecForProviderTableWithColumnsNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionsSpecForProviderTableWithColumnsNameRefPolicy? Policy { get; set; }
}

public enum V1beta1PermissionsSpecForProviderTableWithColumnsNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionsSpecForProviderTableWithColumnsNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PermissionsSpecForProviderTableWithColumnsNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecForProviderTableWithColumnsNameSelectorPolicyResolutionEnum>))]
    public V1beta1PermissionsSpecForProviderTableWithColumnsNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecForProviderTableWithColumnsNameSelectorPolicyResolveEnum>))]
    public V1beta1PermissionsSpecForProviderTableWithColumnsNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CatalogTable in glue to populate name.</summary>
public partial class V1beta1PermissionsSpecForProviderTableWithColumnsNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionsSpecForProviderTableWithColumnsNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsSpecForProviderTableWithColumns
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Set of column names for the table.</summary>
    [JsonPropertyName("columnNames")]
    public IList<string>? ColumnNames { get; set; }

    /// <summary>–  Name of the database for the table with columns resource. Unique to the Data Catalog.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Set of column names for the table to exclude.</summary>
    [JsonPropertyName("excludedColumnNames")]
    public IList<string>? ExcludedColumnNames { get; set; }

    /// <summary>–  Name of the table resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a CatalogTable in glue to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1PermissionsSpecForProviderTableWithColumnsNameRef? NameRef { get; set; }

    /// <summary>Selector for a CatalogTable in glue to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1PermissionsSpecForProviderTableWithColumnsNameSelector? NameSelector { get; set; }

    /// <summary>Whether to use a column wildcard.</summary>
    [JsonPropertyName("wildcard")]
    public bool? Wildcard { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsSpecForProvider
{
    /// <summary>–  Identifier for the Data Catalog. By default, the account ID. The Data Catalog is the persistent metadata store. It contains database definitions, table definitions, and other control information to manage your Lake Formation environment.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Whether the permissions are to be granted for the Data Catalog. Defaults to false.</summary>
    [JsonPropertyName("catalogResource")]
    public bool? CatalogResource { get; set; }

    /// <summary>Configuration block for a data cells filter resource. Detailed below.</summary>
    [JsonPropertyName("dataCellsFilter")]
    public IList<V1beta1PermissionsSpecForProviderDataCellsFilter>? DataCellsFilter { get; set; }

    /// <summary>Configuration block for a data location resource. Detailed below.</summary>
    [JsonPropertyName("dataLocation")]
    public IList<V1beta1PermissionsSpecForProviderDataLocation>? DataLocation { get; set; }

    /// <summary>Configuration block for a database resource. Detailed below.</summary>
    [JsonPropertyName("database")]
    public IList<V1beta1PermissionsSpecForProviderDatabase>? Database { get; set; }

    /// <summary>Configuration block for an LF-tag resource. Detailed below.</summary>
    [JsonPropertyName("lfTag")]
    public IList<V1beta1PermissionsSpecForProviderLfTag>? LfTag { get; set; }

    /// <summary>Configuration block for an LF-tag policy resource. Detailed below.</summary>
    [JsonPropertyName("lfTagPolicy")]
    public IList<V1beta1PermissionsSpecForProviderLfTagPolicy>? LfTagPolicy { get; set; }

    /// <summary>–  List of permissions granted to the principal. Valid values may include ALL, ALTER, ASSOCIATE, CREATE_DATABASE, CREATE_TABLE, DATA_LOCATION_ACCESS, DELETE, DESCRIBE, DROP, INSERT, and SELECT. For details on each permission, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Subset of permissions which the principal can pass.</summary>
    [JsonPropertyName("permissionsWithGrantOption")]
    public IList<string>? PermissionsWithGrantOption { get; set; }

    /// <summary>account permissions. For more information, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Configuration block for a table resource. Detailed below.</summary>
    [JsonPropertyName("table")]
    public IList<V1beta1PermissionsSpecForProviderTable>? Table { get; set; }

    /// <summary>Configuration block for a table with columns resource. Detailed below.</summary>
    [JsonPropertyName("tableWithColumns")]
    public IList<V1beta1PermissionsSpecForProviderTableWithColumns>? TableWithColumns { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsSpecInitProviderDataCellsFilter
{
    /// <summary>The name of the database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The name of the data cells filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Data Catalog.</summary>
    [JsonPropertyName("tableCatalogId")]
    public string? TableCatalogId { get; set; }

    /// <summary>The name of the table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

public enum V1beta1PermissionsSpecInitProviderDataLocationArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionsSpecInitProviderDataLocationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PermissionsSpecInitProviderDataLocationArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecInitProviderDataLocationArnRefPolicyResolutionEnum>))]
    public V1beta1PermissionsSpecInitProviderDataLocationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecInitProviderDataLocationArnRefPolicyResolveEnum>))]
    public V1beta1PermissionsSpecInitProviderDataLocationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Resource in lakeformation to populate arn.</summary>
public partial class V1beta1PermissionsSpecInitProviderDataLocationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionsSpecInitProviderDataLocationArnRefPolicy? Policy { get; set; }
}

public enum V1beta1PermissionsSpecInitProviderDataLocationArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionsSpecInitProviderDataLocationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PermissionsSpecInitProviderDataLocationArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecInitProviderDataLocationArnSelectorPolicyResolutionEnum>))]
    public V1beta1PermissionsSpecInitProviderDataLocationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecInitProviderDataLocationArnSelectorPolicyResolveEnum>))]
    public V1beta1PermissionsSpecInitProviderDataLocationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Resource in lakeformation to populate arn.</summary>
public partial class V1beta1PermissionsSpecInitProviderDataLocationArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionsSpecInitProviderDataLocationArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsSpecInitProviderDataLocation
{
    /// <summary>–  Amazon Resource Name (ARN) that uniquely identifies the data location resource.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a Resource in lakeformation to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1PermissionsSpecInitProviderDataLocationArnRef? ArnRef { get; set; }

    /// <summary>Selector for a Resource in lakeformation to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1PermissionsSpecInitProviderDataLocationArnSelector? ArnSelector { get; set; }

    /// <summary>Identifier for the Data Catalog where the location is registered with Lake Formation. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }
}

public enum V1beta1PermissionsSpecInitProviderDatabaseNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionsSpecInitProviderDatabaseNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PermissionsSpecInitProviderDatabaseNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecInitProviderDatabaseNameRefPolicyResolutionEnum>))]
    public V1beta1PermissionsSpecInitProviderDatabaseNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecInitProviderDatabaseNameRefPolicyResolveEnum>))]
    public V1beta1PermissionsSpecInitProviderDatabaseNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CatalogDatabase in glue to populate name.</summary>
public partial class V1beta1PermissionsSpecInitProviderDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionsSpecInitProviderDatabaseNameRefPolicy? Policy { get; set; }
}

public enum V1beta1PermissionsSpecInitProviderDatabaseNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionsSpecInitProviderDatabaseNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PermissionsSpecInitProviderDatabaseNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecInitProviderDatabaseNameSelectorPolicyResolutionEnum>))]
    public V1beta1PermissionsSpecInitProviderDatabaseNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecInitProviderDatabaseNameSelectorPolicyResolveEnum>))]
    public V1beta1PermissionsSpecInitProviderDatabaseNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CatalogDatabase in glue to populate name.</summary>
public partial class V1beta1PermissionsSpecInitProviderDatabaseNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionsSpecInitProviderDatabaseNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsSpecInitProviderDatabase
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>–  Name of the database resource. Unique to the Data Catalog.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a CatalogDatabase in glue to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1PermissionsSpecInitProviderDatabaseNameRef? NameRef { get; set; }

    /// <summary>Selector for a CatalogDatabase in glue to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1PermissionsSpecInitProviderDatabaseNameSelector? NameSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsSpecInitProviderLfTag
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>name for the tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A list of possible values an attribute can take.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsSpecInitProviderLfTagPolicyExpression
{
    /// <summary>name of an LF-Tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A list of possible values of an LF-Tag.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsSpecInitProviderLfTagPolicy
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>A list of tag conditions that apply to the resource's tag policy. Configuration block for tag conditions that apply to the policy. See expression below.</summary>
    [JsonPropertyName("expression")]
    public IList<V1beta1PermissionsSpecInitProviderLfTagPolicyExpression>? Expression { get; set; }

    /// <summary>–  The resource type for which the tag policy applies. Valid values are DATABASE and TABLE.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsSpecInitProviderTable
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>–  Name of the database for the table. Unique to a Data Catalog.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Name of the table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether to use a wildcard representing every table under a database. Defaults to false.</summary>
    [JsonPropertyName("wildcard")]
    public bool? Wildcard { get; set; }
}

public enum V1beta1PermissionsSpecInitProviderTableWithColumnsNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionsSpecInitProviderTableWithColumnsNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PermissionsSpecInitProviderTableWithColumnsNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecInitProviderTableWithColumnsNameRefPolicyResolutionEnum>))]
    public V1beta1PermissionsSpecInitProviderTableWithColumnsNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecInitProviderTableWithColumnsNameRefPolicyResolveEnum>))]
    public V1beta1PermissionsSpecInitProviderTableWithColumnsNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CatalogTable in glue to populate name.</summary>
public partial class V1beta1PermissionsSpecInitProviderTableWithColumnsNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionsSpecInitProviderTableWithColumnsNameRefPolicy? Policy { get; set; }
}

public enum V1beta1PermissionsSpecInitProviderTableWithColumnsNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionsSpecInitProviderTableWithColumnsNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PermissionsSpecInitProviderTableWithColumnsNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecInitProviderTableWithColumnsNameSelectorPolicyResolutionEnum>))]
    public V1beta1PermissionsSpecInitProviderTableWithColumnsNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecInitProviderTableWithColumnsNameSelectorPolicyResolveEnum>))]
    public V1beta1PermissionsSpecInitProviderTableWithColumnsNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CatalogTable in glue to populate name.</summary>
public partial class V1beta1PermissionsSpecInitProviderTableWithColumnsNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionsSpecInitProviderTableWithColumnsNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsSpecInitProviderTableWithColumns
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Set of column names for the table.</summary>
    [JsonPropertyName("columnNames")]
    public IList<string>? ColumnNames { get; set; }

    /// <summary>–  Name of the database for the table with columns resource. Unique to the Data Catalog.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Set of column names for the table to exclude.</summary>
    [JsonPropertyName("excludedColumnNames")]
    public IList<string>? ExcludedColumnNames { get; set; }

    /// <summary>–  Name of the table resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a CatalogTable in glue to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1PermissionsSpecInitProviderTableWithColumnsNameRef? NameRef { get; set; }

    /// <summary>Selector for a CatalogTable in glue to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1PermissionsSpecInitProviderTableWithColumnsNameSelector? NameSelector { get; set; }

    /// <summary>Whether to use a column wildcard.</summary>
    [JsonPropertyName("wildcard")]
    public bool? Wildcard { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1PermissionsSpecInitProvider
{
    /// <summary>–  Identifier for the Data Catalog. By default, the account ID. The Data Catalog is the persistent metadata store. It contains database definitions, table definitions, and other control information to manage your Lake Formation environment.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Whether the permissions are to be granted for the Data Catalog. Defaults to false.</summary>
    [JsonPropertyName("catalogResource")]
    public bool? CatalogResource { get; set; }

    /// <summary>Configuration block for a data cells filter resource. Detailed below.</summary>
    [JsonPropertyName("dataCellsFilter")]
    public IList<V1beta1PermissionsSpecInitProviderDataCellsFilter>? DataCellsFilter { get; set; }

    /// <summary>Configuration block for a data location resource. Detailed below.</summary>
    [JsonPropertyName("dataLocation")]
    public IList<V1beta1PermissionsSpecInitProviderDataLocation>? DataLocation { get; set; }

    /// <summary>Configuration block for a database resource. Detailed below.</summary>
    [JsonPropertyName("database")]
    public IList<V1beta1PermissionsSpecInitProviderDatabase>? Database { get; set; }

    /// <summary>Configuration block for an LF-tag resource. Detailed below.</summary>
    [JsonPropertyName("lfTag")]
    public IList<V1beta1PermissionsSpecInitProviderLfTag>? LfTag { get; set; }

    /// <summary>Configuration block for an LF-tag policy resource. Detailed below.</summary>
    [JsonPropertyName("lfTagPolicy")]
    public IList<V1beta1PermissionsSpecInitProviderLfTagPolicy>? LfTagPolicy { get; set; }

    /// <summary>–  List of permissions granted to the principal. Valid values may include ALL, ALTER, ASSOCIATE, CREATE_DATABASE, CREATE_TABLE, DATA_LOCATION_ACCESS, DELETE, DESCRIBE, DROP, INSERT, and SELECT. For details on each permission, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Subset of permissions which the principal can pass.</summary>
    [JsonPropertyName("permissionsWithGrantOption")]
    public IList<string>? PermissionsWithGrantOption { get; set; }

    /// <summary>account permissions. For more information, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }

    /// <summary>Configuration block for a table resource. Detailed below.</summary>
    [JsonPropertyName("table")]
    public IList<V1beta1PermissionsSpecInitProviderTable>? Table { get; set; }

    /// <summary>Configuration block for a table with columns resource. Detailed below.</summary>
    [JsonPropertyName("tableWithColumns")]
    public IList<V1beta1PermissionsSpecInitProviderTableWithColumns>? TableWithColumns { get; set; }
}

public enum V1beta1PermissionsSpecManagementPoliciesEnum
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

public enum V1beta1PermissionsSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionsSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PermissionsSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1PermissionsSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1PermissionsSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1PermissionsSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionsSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1PermissionsSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PermissionsSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PermissionsSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1PermissionsSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1PermissionsSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1PermissionsSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionsSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1PermissionsSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1PermissionsSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1PermissionsSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1PermissionsSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1PermissionsSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>PermissionsSpec defines the desired state of Permissions</summary>
public partial class V1beta1PermissionsSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PermissionsSpecDeletionPolicyEnum>))]
    public V1beta1PermissionsSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PermissionsSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PermissionsSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PermissionsSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PermissionsSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1PermissionsSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PermissionsSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsStatusAtProviderDataCellsFilter
{
    /// <summary>The name of the database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The name of the data cells filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Data Catalog.</summary>
    [JsonPropertyName("tableCatalogId")]
    public string? TableCatalogId { get; set; }

    /// <summary>The name of the table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsStatusAtProviderDataLocation
{
    /// <summary>–  Amazon Resource Name (ARN) that uniquely identifies the data location resource.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Identifier for the Data Catalog where the location is registered with Lake Formation. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsStatusAtProviderDatabase
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>–  Name of the database resource. Unique to the Data Catalog.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsStatusAtProviderLfTag
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>name for the tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A list of possible values an attribute can take.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsStatusAtProviderLfTagPolicyExpression
{
    /// <summary>name of an LF-Tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A list of possible values of an LF-Tag.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsStatusAtProviderLfTagPolicy
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>A list of tag conditions that apply to the resource's tag policy. Configuration block for tag conditions that apply to the policy. See expression below.</summary>
    [JsonPropertyName("expression")]
    public IList<V1beta1PermissionsStatusAtProviderLfTagPolicyExpression>? Expression { get; set; }

    /// <summary>–  The resource type for which the tag policy applies. Valid values are DATABASE and TABLE.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsStatusAtProviderTable
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>–  Name of the database for the table. Unique to a Data Catalog.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Name of the table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether to use a wildcard representing every table under a database. Defaults to false.</summary>
    [JsonPropertyName("wildcard")]
    public bool? Wildcard { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsStatusAtProviderTableWithColumns
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Set of column names for the table.</summary>
    [JsonPropertyName("columnNames")]
    public IList<string>? ColumnNames { get; set; }

    /// <summary>–  Name of the database for the table with columns resource. Unique to the Data Catalog.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Set of column names for the table to exclude.</summary>
    [JsonPropertyName("excludedColumnNames")]
    public IList<string>? ExcludedColumnNames { get; set; }

    /// <summary>–  Name of the table resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether to use a column wildcard.</summary>
    [JsonPropertyName("wildcard")]
    public bool? Wildcard { get; set; }
}

/// <summary></summary>
public partial class V1beta1PermissionsStatusAtProvider
{
    /// <summary>–  Identifier for the Data Catalog. By default, the account ID. The Data Catalog is the persistent metadata store. It contains database definitions, table definitions, and other control information to manage your Lake Formation environment.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Whether the permissions are to be granted for the Data Catalog. Defaults to false.</summary>
    [JsonPropertyName("catalogResource")]
    public bool? CatalogResource { get; set; }

    /// <summary>Configuration block for a data cells filter resource. Detailed below.</summary>
    [JsonPropertyName("dataCellsFilter")]
    public IList<V1beta1PermissionsStatusAtProviderDataCellsFilter>? DataCellsFilter { get; set; }

    /// <summary>Configuration block for a data location resource. Detailed below.</summary>
    [JsonPropertyName("dataLocation")]
    public IList<V1beta1PermissionsStatusAtProviderDataLocation>? DataLocation { get; set; }

    /// <summary>Configuration block for a database resource. Detailed below.</summary>
    [JsonPropertyName("database")]
    public IList<V1beta1PermissionsStatusAtProviderDatabase>? Database { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block for an LF-tag resource. Detailed below.</summary>
    [JsonPropertyName("lfTag")]
    public IList<V1beta1PermissionsStatusAtProviderLfTag>? LfTag { get; set; }

    /// <summary>Configuration block for an LF-tag policy resource. Detailed below.</summary>
    [JsonPropertyName("lfTagPolicy")]
    public IList<V1beta1PermissionsStatusAtProviderLfTagPolicy>? LfTagPolicy { get; set; }

    /// <summary>–  List of permissions granted to the principal. Valid values may include ALL, ALTER, ASSOCIATE, CREATE_DATABASE, CREATE_TABLE, DATA_LOCATION_ACCESS, DELETE, DESCRIBE, DROP, INSERT, and SELECT. For details on each permission, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Subset of permissions which the principal can pass.</summary>
    [JsonPropertyName("permissionsWithGrantOption")]
    public IList<string>? PermissionsWithGrantOption { get; set; }

    /// <summary>account permissions. For more information, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }

    /// <summary>Configuration block for a table resource. Detailed below.</summary>
    [JsonPropertyName("table")]
    public IList<V1beta1PermissionsStatusAtProviderTable>? Table { get; set; }

    /// <summary>Configuration block for a table with columns resource. Detailed below.</summary>
    [JsonPropertyName("tableWithColumns")]
    public IList<V1beta1PermissionsStatusAtProviderTableWithColumns>? TableWithColumns { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1PermissionsStatusConditions
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

/// <summary>PermissionsStatus defines the observed state of Permissions.</summary>
public partial class V1beta1PermissionsStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PermissionsStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PermissionsStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Permissions is the Schema for the Permissionss API. Grants permissions to the principal to access metadata in the Data Catalog and data organized in underlying data storage such as Amazon S3.</summary>
public partial class V1beta1Permissions : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PermissionsSpec>, IStatus<V1beta1PermissionsStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Permissions";
    public const string KubeGroup = "lakeformation.aws.upbound.io";
    public const string KubePluralName = "permissions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PermissionsSpec defines the desired state of Permissions</summary>
    [JsonPropertyName("spec")]
    public V1beta1PermissionsSpec Spec { get; set; }

    /// <summary>PermissionsStatus defines the observed state of Permissions.</summary>
    [JsonPropertyName("status")]
    public V1beta1PermissionsStatus? Status { get; set; }
}