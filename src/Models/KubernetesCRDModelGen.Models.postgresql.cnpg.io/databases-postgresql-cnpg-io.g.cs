using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.postgresql.cnpg.io;
/// <summary>The name of the PostgreSQL cluster hosting the database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseSpecCluster
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Specification of the desired Database. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseSpec
{
    /// <summary>Maps to the `ALLOW_CONNECTIONS` parameter of `CREATE DATABASE` and `ALTER DATABASE`. If false then no one can connect to this database.</summary>
    [JsonPropertyName("allowConnections")]
    public bool? AllowConnections { get; set; }

    /// <summary>Maps to the `BUILTIN_LOCALE` parameter of `CREATE DATABASE`. This setting cannot be changed. Specifies the locale name when the builtin provider is used. This option requires `localeProvider` to be set to `builtin`. Available from PostgreSQL 17.</summary>
    [JsonPropertyName("builtinLocale")]
    public string? BuiltinLocale { get; set; }

    /// <summary>The name of the PostgreSQL cluster hosting the database.</summary>
    [JsonPropertyName("cluster")]
    public V1DatabaseSpecCluster Cluster { get; set; }

    /// <summary>Maps to the `COLLATION_VERSION` parameter of `CREATE DATABASE`. This setting cannot be changed.</summary>
    [JsonPropertyName("collationVersion")]
    public string? CollationVersion { get; set; }

    /// <summary>Maps to the `CONNECTION LIMIT` clause of `CREATE DATABASE` and `ALTER DATABASE`. How many concurrent connections can be made to this database. -1 (the default) means no limit.</summary>
    [JsonPropertyName("connectionLimit")]
    public int? ConnectionLimit { get; set; }

    /// <summary>The policy for end-of-life maintenance of this database.</summary>
    [JsonPropertyName("databaseReclaimPolicy")]
    public string? DatabaseReclaimPolicy { get; set; }

    /// <summary>Maps to the `ENCODING` parameter of `CREATE DATABASE`. This setting cannot be changed. Character set encoding to use in the database.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Ensure the PostgreSQL database is `present` or `absent` - defaults to "present".</summary>
    [JsonPropertyName("ensure")]
    public string? Ensure { get; set; }

    /// <summary>Maps to the `ICU_LOCALE` parameter of `CREATE DATABASE`. This setting cannot be changed. Specifies the ICU locale when the ICU provider is used. This option requires `localeProvider` to be set to `icu`. Available from PostgreSQL 15.</summary>
    [JsonPropertyName("icuLocale")]
    public string? IcuLocale { get; set; }

    /// <summary>Maps to the `ICU_RULES` parameter of `CREATE DATABASE`. This setting cannot be changed. Specifies additional collation rules to customize the behavior of the default collation. This option requires `localeProvider` to be set to `icu`. Available from PostgreSQL 16.</summary>
    [JsonPropertyName("icuRules")]
    public string? IcuRules { get; set; }

    /// <summary>Maps to the `IS_TEMPLATE` parameter of `CREATE DATABASE` and `ALTER DATABASE`. If true, this database is considered a template and can be cloned by any user with `CREATEDB` privileges.</summary>
    [JsonPropertyName("isTemplate")]
    public bool? IsTemplate { get; set; }

    /// <summary>Maps to the `LOCALE` parameter of `CREATE DATABASE`. This setting cannot be changed. Sets the default collation order and character classification in the new database.</summary>
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    /// <summary>Maps to the `LC_CTYPE` parameter of `CREATE DATABASE`. This setting cannot be changed.</summary>
    [JsonPropertyName("localeCType")]
    public string? LocaleCType { get; set; }

    /// <summary>Maps to the `LC_COLLATE` parameter of `CREATE DATABASE`. This setting cannot be changed.</summary>
    [JsonPropertyName("localeCollate")]
    public string? LocaleCollate { get; set; }

    /// <summary>Maps to the `LOCALE_PROVIDER` parameter of `CREATE DATABASE`. This setting cannot be changed. This option sets the locale provider for databases created in the new cluster. Available from PostgreSQL 16.</summary>
    [JsonPropertyName("localeProvider")]
    public string? LocaleProvider { get; set; }

    /// <summary>The name of the database to create inside PostgreSQL. This setting cannot be changed.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Maps to the `OWNER` parameter of `CREATE DATABASE`. Maps to the `OWNER TO` command of `ALTER DATABASE`. The role name of the user who owns the database inside PostgreSQL.</summary>
    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    /// <summary>Maps to the `TABLESPACE` parameter of `CREATE DATABASE`. Maps to the `SET TABLESPACE` command of `ALTER DATABASE`. The name of the tablespace (in PostgreSQL) that will be associated with the new database. This tablespace will be the default tablespace used for objects created in this database.</summary>
    [JsonPropertyName("tablespace")]
    public string? Tablespace { get; set; }

    /// <summary>Maps to the `TEMPLATE` parameter of `CREATE DATABASE`. This setting cannot be changed. The name of the template from which to create this database.</summary>
    [JsonPropertyName("template")]
    public string? Template { get; set; }
}

/// <summary>Most recently observed status of the Database. This data may not be up to date. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseStatus
{
    /// <summary>Applied is true if the database was reconciled correctly</summary>
    [JsonPropertyName("applied")]
    public bool? Applied { get; set; }

    /// <summary>Message is the reconciliation output message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>A sequence number representing the latest desired state that was synchronized</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Database is the Schema for the databases API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Database : IKubernetesObject<V1ObjectMeta>, ISpec<V1DatabaseSpec>, IStatus<V1DatabaseStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Database";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "databases";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Specification of the desired Database. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("spec")]
    public V1DatabaseSpec Spec { get; set; }

    /// <summary>Most recently observed status of the Database. This data may not be up to date. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("status")]
    public V1DatabaseStatus? Status { get; set; }
}

/// <summary>Database is the Schema for the databases API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1DatabaseList : IKubernetesObject<V1ListMeta>, IItems<V1Database>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "DatabaseList";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "databases";
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
    public IList<V1Database> Items { get; set; }
}