using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lakeformation.aws.upbound.io;
/// <summary>Permissions is the Schema for the Permissionss API. Grants permissions to the principal to access metadata in the Data Catalog and data organized in underlying data storage such as Amazon S3.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PermissionsList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Permissions>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PermissionsList";
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
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1Permissions> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecForProviderDataLocationArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Resource in lakeformation to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecForProviderDataLocationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionsSpecForProviderDataLocationArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecForProviderDataLocationArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Resource in lakeformation to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecForProviderDataLocation
{
    /// <summary>Amazon Resource Name (ARN) that uniquely identifies the data location resource.</summary>
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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecForProviderDatabaseNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CatalogDatabase in glue to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecForProviderDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionsSpecForProviderDatabaseNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecForProviderDatabaseNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CatalogDatabase in glue to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecForProviderDatabase
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Name of the database resource. Unique to the Data Catalog.</summary>
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecForProviderLfTag
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>The key-name for the tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A list of possible values an attribute can take.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecForProviderLfTagPolicyExpression
{
    /// <summary>The key-name of an LF-Tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A list of possible values of an LF-Tag.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecForProviderLfTagPolicy
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>A list of tag conditions that apply to the resource's tag policy. Configuration block for tag conditions that apply to the policy. See expression below.</summary>
    [JsonPropertyName("expression")]
    public IList<V1beta1PermissionsSpecForProviderLfTagPolicyExpression>? Expression { get; set; }

    /// <summary>The resource type for which the tag policy applies. Valid values are DATABASE and TABLE.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecForProviderTable
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Name of the database for the table. Unique to a Data Catalog.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Name of the table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether to use a wildcard representing every table under a database. Defaults to false.</summary>
    [JsonPropertyName("wildcard")]
    public bool? Wildcard { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecForProviderTableWithColumnsNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CatalogTable in glue to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecForProviderTableWithColumnsNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionsSpecForProviderTableWithColumnsNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecForProviderTableWithColumnsNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CatalogTable in glue to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecForProviderTableWithColumns
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Set of column names for the table.</summary>
    [JsonPropertyName("columnNames")]
    public IList<string>? ColumnNames { get; set; }

    /// <summary>Name of the database for the table with columns resource. Unique to the Data Catalog.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Set of column names for the table to exclude.</summary>
    [JsonPropertyName("excludedColumnNames")]
    public IList<string>? ExcludedColumnNames { get; set; }

    /// <summary>Name of the table resource.</summary>
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecForProvider
{
    /// <summary>Identifier for the Data Catalog. By default, the account ID. The Data Catalog is the persistent metadata store. It contains database definitions, table definitions, and other control information to manage your Lake Formation environment.</summary>
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

    /// <summary>List of permissions granted to the principal. Valid values may include ALL, ALTER, ASSOCIATE, CREATE_DATABASE, CREATE_TABLE, DATA_LOCATION_ACCESS, DELETE, DESCRIBE, DROP, INSERT, and SELECT. For details on each permission, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Subset of permissions which the principal can pass.</summary>
    [JsonPropertyName("permissionsWithGrantOption")]
    public IList<string>? PermissionsWithGrantOption { get; set; }

    /// <summary>Principal to be granted the permissions on the resource. Supported principals include IAM_ALLOWED_PRINCIPALS (see Default Behavior and  above), IAM roles, users, groups, Federated Users, SAML groups and users, QuickSight groups, OUs, and organizations as well as AWS account IDs for cross-account permissions. For more information, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecInitProviderDataLocationArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Resource in lakeformation to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecInitProviderDataLocationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionsSpecInitProviderDataLocationArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecInitProviderDataLocationArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Resource in lakeformation to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecInitProviderDataLocation
{
    /// <summary>Amazon Resource Name (ARN) that uniquely identifies the data location resource.</summary>
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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecInitProviderDatabaseNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CatalogDatabase in glue to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecInitProviderDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionsSpecInitProviderDatabaseNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecInitProviderDatabaseNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CatalogDatabase in glue to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecInitProviderDatabase
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Name of the database resource. Unique to the Data Catalog.</summary>
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecInitProviderLfTag
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>The key-name for the tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A list of possible values an attribute can take.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecInitProviderLfTagPolicyExpression
{
    /// <summary>The key-name of an LF-Tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A list of possible values of an LF-Tag.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecInitProviderLfTagPolicy
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>A list of tag conditions that apply to the resource's tag policy. Configuration block for tag conditions that apply to the policy. See expression below.</summary>
    [JsonPropertyName("expression")]
    public IList<V1beta1PermissionsSpecInitProviderLfTagPolicyExpression>? Expression { get; set; }

    /// <summary>The resource type for which the tag policy applies. Valid values are DATABASE and TABLE.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecInitProviderTable
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Name of the database for the table. Unique to a Data Catalog.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Name of the table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether to use a wildcard representing every table under a database. Defaults to false.</summary>
    [JsonPropertyName("wildcard")]
    public bool? Wildcard { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecInitProviderTableWithColumnsNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CatalogTable in glue to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecInitProviderTableWithColumnsNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionsSpecInitProviderTableWithColumnsNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecInitProviderTableWithColumnsNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CatalogTable in glue to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecInitProviderTableWithColumns
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Set of column names for the table.</summary>
    [JsonPropertyName("columnNames")]
    public IList<string>? ColumnNames { get; set; }

    /// <summary>Name of the database for the table with columns resource. Unique to the Data Catalog.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Set of column names for the table to exclude.</summary>
    [JsonPropertyName("excludedColumnNames")]
    public IList<string>? ExcludedColumnNames { get; set; }

    /// <summary>Name of the table resource.</summary>
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecInitProvider
{
    /// <summary>Identifier for the Data Catalog. By default, the account ID. The Data Catalog is the persistent metadata store. It contains database definitions, table definitions, and other control information to manage your Lake Formation environment.</summary>
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

    /// <summary>List of permissions granted to the principal. Valid values may include ALL, ALTER, ASSOCIATE, CREATE_DATABASE, CREATE_TABLE, DATA_LOCATION_ACCESS, DELETE, DESCRIBE, DROP, INSERT, and SELECT. For details on each permission, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Subset of permissions which the principal can pass.</summary>
    [JsonPropertyName("permissionsWithGrantOption")]
    public IList<string>? PermissionsWithGrantOption { get; set; }

    /// <summary>Principal to be granted the permissions on the resource. Supported principals include IAM_ALLOWED_PRINCIPALS (see Default Behavior and  above), IAM roles, users, groups, Federated Users, SAML groups and users, QuickSight groups, OUs, and organizations as well as AWS account IDs for cross-account permissions. For more information, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }

    /// <summary>Configuration block for a table resource. Detailed below.</summary>
    [JsonPropertyName("table")]
    public IList<V1beta1PermissionsSpecInitProviderTable>? Table { get; set; }

    /// <summary>Configuration block for a table with columns resource. Detailed below.</summary>
    [JsonPropertyName("tableWithColumns")]
    public IList<V1beta1PermissionsSpecInitProviderTableWithColumns>? TableWithColumns { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpecProviderConfigRefPolicy
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
public partial class V1beta1PermissionsSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PermissionsSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PermissionsSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PermissionsSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PermissionsSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PermissionsSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsStatusAtProviderDataLocation
{
    /// <summary>Amazon Resource Name (ARN) that uniquely identifies the data location resource.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Identifier for the Data Catalog where the location is registered with Lake Formation. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsStatusAtProviderDatabase
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Name of the database resource. Unique to the Data Catalog.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsStatusAtProviderLfTag
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>The key-name for the tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A list of possible values an attribute can take.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsStatusAtProviderLfTagPolicyExpression
{
    /// <summary>The key-name of an LF-Tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A list of possible values of an LF-Tag.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsStatusAtProviderLfTagPolicy
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>A list of tag conditions that apply to the resource's tag policy. Configuration block for tag conditions that apply to the policy. See expression below.</summary>
    [JsonPropertyName("expression")]
    public IList<V1beta1PermissionsStatusAtProviderLfTagPolicyExpression>? Expression { get; set; }

    /// <summary>The resource type for which the tag policy applies. Valid values are DATABASE and TABLE.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsStatusAtProviderTable
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Name of the database for the table. Unique to a Data Catalog.</summary>
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsStatusAtProviderTableWithColumns
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Set of column names for the table.</summary>
    [JsonPropertyName("columnNames")]
    public IList<string>? ColumnNames { get; set; }

    /// <summary>Name of the database for the table with columns resource. Unique to the Data Catalog.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Set of column names for the table to exclude.</summary>
    [JsonPropertyName("excludedColumnNames")]
    public IList<string>? ExcludedColumnNames { get; set; }

    /// <summary>Name of the table resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether to use a column wildcard.</summary>
    [JsonPropertyName("wildcard")]
    public bool? Wildcard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PermissionsStatusAtProvider
{
    /// <summary>Identifier for the Data Catalog. By default, the account ID. The Data Catalog is the persistent metadata store. It contains database definitions, table definitions, and other control information to manage your Lake Formation environment.</summary>
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

    /// <summary>List of permissions granted to the principal. Valid values may include ALL, ALTER, ASSOCIATE, CREATE_DATABASE, CREATE_TABLE, DATA_LOCATION_ACCESS, DELETE, DESCRIBE, DROP, INSERT, and SELECT. For details on each permission, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Subset of permissions which the principal can pass.</summary>
    [JsonPropertyName("permissionsWithGrantOption")]
    public IList<string>? PermissionsWithGrantOption { get; set; }

    /// <summary>Principal to be granted the permissions on the resource. Supported principals include IAM_ALLOWED_PRINCIPALS (see Default Behavior and  above), IAM roles, users, groups, Federated Users, SAML groups and users, QuickSight groups, OUs, and organizations as well as AWS account IDs for cross-account permissions. For more information, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Configuration block for a table resource. Detailed below.</summary>
    [JsonPropertyName("table")]
    public IList<V1beta1PermissionsStatusAtProviderTable>? Table { get; set; }

    /// <summary>Configuration block for a table with columns resource. Detailed below.</summary>
    [JsonPropertyName("tableWithColumns")]
    public IList<V1beta1PermissionsStatusAtProviderTableWithColumns>? TableWithColumns { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>Permissions is the Schema for the Permissionss API. Grants permissions to the principal to access metadata in the Data Catalog and data organized in underlying data storage such as Amazon S3.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
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