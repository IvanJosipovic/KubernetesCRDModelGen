using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.glue.aws.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderCatalogTargetDatabaseNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderCatalogTargetDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecForProviderCatalogTargetDatabaseNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderCatalogTargetDatabaseNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderCatalogTargetDatabaseNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecForProviderCatalogTargetDatabaseNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderCatalogTargetTablesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderCatalogTargetTablesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecForProviderCatalogTargetTablesRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderCatalogTargetTablesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of CatalogTable in glue to populate tables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderCatalogTargetTablesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecForProviderCatalogTargetTablesSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderCatalogTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Glue database where results are written.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameRef")]
    public V1beta1CrawlerSpecForProviderCatalogTargetDatabaseNameRef? DatabaseNameRef { get; set; }

    /// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameSelector")]
    public V1beta1CrawlerSpecForProviderCatalogTargetDatabaseNameSelector? DatabaseNameSelector { get; set; }

    /// <summary>The ARN of the dead-letter SQS queue.</summary>
    [JsonPropertyName("dlqEventQueueArn")]
    public string? DlqEventQueueArn { get; set; }

    /// <summary>The ARN of the SQS queue to receive S3 notifications from.</summary>
    [JsonPropertyName("eventQueueArn")]
    public string? EventQueueArn { get; set; }

    /// <summary>A list of catalog tables to be synchronized.</summary>
    [JsonPropertyName("tables")]
    public IList<string>? Tables { get; set; }

    /// <summary>References to CatalogTable in glue to populate tables.</summary>
    [JsonPropertyName("tablesRefs")]
    public IList<V1beta1CrawlerSpecForProviderCatalogTargetTablesRefs>? TablesRefs { get; set; }

    /// <summary>Selector for a list of CatalogTable in glue to populate tables.</summary>
    [JsonPropertyName("tablesSelector")]
    public V1beta1CrawlerSpecForProviderCatalogTargetTablesSelector? TablesSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderDatabaseNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecForProviderDatabaseNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderDatabaseNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderDatabaseNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecForProviderDatabaseNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderDeltaTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Specifies whether the crawler will create native tables, to allow integration with query engines that support querying of the Delta transaction log directly.</summary>
    [JsonPropertyName("createNativeDeltaTable")]
    public bool? CreateNativeDeltaTable { get; set; }

    /// <summary>A list of the Amazon S3 paths to the Delta tables.</summary>
    [JsonPropertyName("deltaTables")]
    public IList<string>? DeltaTables { get; set; }

    /// <summary>Specifies whether to write the manifest files to the Delta table path.</summary>
    [JsonPropertyName("writeManifest")]
    public bool? WriteManifest { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderDynamodbTarget
{
    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Indicates whether to scan all the records, or to sample rows from the table. Scanning all the records can take a long time when the table is not a high throughput table.  defaults to true.</summary>
    [JsonPropertyName("scanAll")]
    public bool? ScanAll { get; set; }

    /// <summary>The percentage of the configured read capacity units to use by the AWS Glue crawler. The valid values are null or a value between 0.1 to 1.5.</summary>
    [JsonPropertyName("scanRate")]
    public double? ScanRate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderHudiTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The maximum depth of Amazon S3 paths that the crawler can traverse to discover the Hudi metadata folder in your Amazon S3 path. Used to limit the crawler run time. Valid values are between 1 and 20.</summary>
    [JsonPropertyName("maximumTraversalDepth")]
    public double? MaximumTraversalDepth { get; set; }

    /// <summary>One or more Amazon S3 paths that contains Hudi metadata folders as s3://bucket/prefix.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderIcebergTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The maximum depth of Amazon S3 paths that the crawler can traverse to discover the Hudi metadata folder in your Amazon S3 path. Used to limit the crawler run time. Valid values are between 1 and 20.</summary>
    [JsonPropertyName("maximumTraversalDepth")]
    public double? MaximumTraversalDepth { get; set; }

    /// <summary>One or more Amazon S3 paths that contains Hudi metadata folders as s3://bucket/prefix.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderJdbcTargetConnectionNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Connection in glue to populate connectionName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderJdbcTargetConnectionNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecForProviderJdbcTargetConnectionNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderJdbcTargetConnectionNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Connection in glue to populate connectionName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderJdbcTargetConnectionNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecForProviderJdbcTargetConnectionNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderJdbcTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Reference to a Connection in glue to populate connectionName.</summary>
    [JsonPropertyName("connectionNameRef")]
    public V1beta1CrawlerSpecForProviderJdbcTargetConnectionNameRef? ConnectionNameRef { get; set; }

    /// <summary>Selector for a Connection in glue to populate connectionName.</summary>
    [JsonPropertyName("connectionNameSelector")]
    public V1beta1CrawlerSpecForProviderJdbcTargetConnectionNameSelector? ConnectionNameSelector { get; set; }

    /// <summary>Specify a value of RAWTYPES or COMMENTS to enable additional metadata intable responses. RAWTYPES provides the native-level datatype. COMMENTS provides comments associated with a column or table in the database.</summary>
    [JsonPropertyName("enableAdditionalMetadata")]
    public IList<string>? EnableAdditionalMetadata { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderLakeFormationConfiguration
{
    /// <summary>Required for cross account crawls. For same account crawls as the target data, this can omitted.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Specifies whether to use Lake Formation credentials for the crawler instead of the IAM role credentials.</summary>
    [JsonPropertyName("useLakeFormationCredentials")]
    public bool? UseLakeFormationCredentials { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderLineageConfiguration
{
    /// <summary>Specifies whether data lineage is enabled for the crawler. Valid values are: ENABLE and DISABLE. Default value is DISABLE.</summary>
    [JsonPropertyName("crawlerLineageSettings")]
    public string? CrawlerLineageSettings { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderMongodbTargetConnectionNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Connection in glue to populate connectionName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderMongodbTargetConnectionNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecForProviderMongodbTargetConnectionNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderMongodbTargetConnectionNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Connection in glue to populate connectionName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderMongodbTargetConnectionNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecForProviderMongodbTargetConnectionNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderMongodbTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Reference to a Connection in glue to populate connectionName.</summary>
    [JsonPropertyName("connectionNameRef")]
    public V1beta1CrawlerSpecForProviderMongodbTargetConnectionNameRef? ConnectionNameRef { get; set; }

    /// <summary>Selector for a Connection in glue to populate connectionName.</summary>
    [JsonPropertyName("connectionNameSelector")]
    public V1beta1CrawlerSpecForProviderMongodbTargetConnectionNameSelector? ConnectionNameSelector { get; set; }

    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Indicates whether to scan all the records, or to sample rows from the table. Scanning all the records can take a long time when the table is not a high throughput table.  defaults to true.</summary>
    [JsonPropertyName("scanAll")]
    public bool? ScanAll { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderRecrawlPolicy
{
    /// <summary>Specifies whether to crawl the entire dataset again, crawl only folders that were added since the last crawler run, or crawl what S3 notifies the crawler of via SQS. Valid Values are: CRAWL_EVENT_MODE, CRAWL_EVERYTHING and CRAWL_NEW_FOLDERS_ONLY. Default value is CRAWL_EVERYTHING.</summary>
    [JsonPropertyName("recrawlBehavior")]
    public string? RecrawlBehavior { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderRoleRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecForProviderRoleRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderRoleSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderRoleSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecForProviderRoleSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderS3Target
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>The ARN of the dead-letter SQS queue.</summary>
    [JsonPropertyName("dlqEventQueueArn")]
    public string? DlqEventQueueArn { get; set; }

    /// <summary>The ARN of the SQS queue to receive S3 notifications from.</summary>
    [JsonPropertyName("eventQueueArn")]
    public string? EventQueueArn { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Sets the number of files in each leaf folder to be crawled when crawling sample files in a dataset. If not set, all the files are crawled. A valid value is an integer between 1 and 249.</summary>
    [JsonPropertyName("sampleSize")]
    public double? SampleSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProviderSchemaChangePolicy
{
    /// <summary>The deletion behavior when the crawler finds a deleted object. Valid values: LOG, DELETE_FROM_DATABASE, or DEPRECATE_IN_DATABASE. Defaults to DEPRECATE_IN_DATABASE.</summary>
    [JsonPropertyName("deleteBehavior")]
    public string? DeleteBehavior { get; set; }

    /// <summary>The update behavior when the crawler finds a changed schema. Valid values: LOG or UPDATE_IN_DATABASE. Defaults to UPDATE_IN_DATABASE.</summary>
    [JsonPropertyName("updateBehavior")]
    public string? UpdateBehavior { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecForProvider
{
    /// <summary>List of nested AWS Glue Data Catalog target arguments. See Catalog Target below.</summary>
    [JsonPropertyName("catalogTarget")]
    public IList<V1beta1CrawlerSpecForProviderCatalogTarget>? CatalogTarget { get; set; }

    /// <summary>List of custom classifiers. By default, all AWS classifiers are included in a crawl, but these custom classifiers always override the default classifiers for a given classification.</summary>
    [JsonPropertyName("classifiers")]
    public IList<string>? Classifiers { get; set; }

    /// <summary>JSON string of configuration information. For more details see Setting Crawler Configuration Options.</summary>
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    /// <summary>Glue database where results are written.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameRef")]
    public V1beta1CrawlerSpecForProviderDatabaseNameRef? DatabaseNameRef { get; set; }

    /// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameSelector")]
    public V1beta1CrawlerSpecForProviderDatabaseNameSelector? DatabaseNameSelector { get; set; }

    /// <summary>List of nested Delta Lake target arguments. See Delta Target below.</summary>
    [JsonPropertyName("deltaTarget")]
    public IList<V1beta1CrawlerSpecForProviderDeltaTarget>? DeltaTarget { get; set; }

    /// <summary>Description of the crawler.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>List of nested DynamoDB target arguments. See Dynamodb Target below.</summary>
    [JsonPropertyName("dynamodbTarget")]
    public IList<V1beta1CrawlerSpecForProviderDynamodbTarget>? DynamodbTarget { get; set; }

    /// <summary>List of nested Hudi target arguments. See Iceberg Target below.</summary>
    [JsonPropertyName("hudiTarget")]
    public IList<V1beta1CrawlerSpecForProviderHudiTarget>? HudiTarget { get; set; }

    /// <summary>List of nested Iceberg target arguments. See Iceberg Target below.</summary>
    [JsonPropertyName("icebergTarget")]
    public IList<V1beta1CrawlerSpecForProviderIcebergTarget>? IcebergTarget { get; set; }

    /// <summary>List of nested JDBC target arguments. See JDBC Target below.</summary>
    [JsonPropertyName("jdbcTarget")]
    public IList<V1beta1CrawlerSpecForProviderJdbcTarget>? JdbcTarget { get; set; }

    /// <summary>Specifies Lake Formation configuration settings for the crawler. See Lake Formation Configuration below.</summary>
    [JsonPropertyName("lakeFormationConfiguration")]
    public IList<V1beta1CrawlerSpecForProviderLakeFormationConfiguration>? LakeFormationConfiguration { get; set; }

    /// <summary>Specifies data lineage configuration settings for the crawler. See Lineage Configuration below.</summary>
    [JsonPropertyName("lineageConfiguration")]
    public IList<V1beta1CrawlerSpecForProviderLineageConfiguration>? LineageConfiguration { get; set; }

    /// <summary>List of nested MongoDB target arguments. See MongoDB Target below.</summary>
    [JsonPropertyName("mongodbTarget")]
    public IList<V1beta1CrawlerSpecForProviderMongodbTarget>? MongodbTarget { get; set; }

    /// <summary>A policy that specifies whether to crawl the entire dataset again, or to crawl only folders that were added since the last crawler run.. See Recrawl Policy below.</summary>
    [JsonPropertyName("recrawlPolicy")]
    public IList<V1beta1CrawlerSpecForProviderRecrawlPolicy>? RecrawlPolicy { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The IAM role friendly name (including path without leading slash), or ARN of an IAM role, used by the crawler to access other resources.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Reference to a Role in iam to populate role.</summary>
    [JsonPropertyName("roleRef")]
    public V1beta1CrawlerSpecForProviderRoleRef? RoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate role.</summary>
    [JsonPropertyName("roleSelector")]
    public V1beta1CrawlerSpecForProviderRoleSelector? RoleSelector { get; set; }

    /// <summary>List of nested Amazon S3 target arguments. See S3 Target below.</summary>
    [JsonPropertyName("s3Target")]
    public IList<V1beta1CrawlerSpecForProviderS3Target>? S3Target { get; set; }

    /// <summary>Based Schedules for Jobs and Crawlers. For example, to run something every day at 12:15 UTC, you would specify: cron(15 12 * * ? *).</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>Policy for the crawler's update and deletion behavior. See Schema Change Policy below.</summary>
    [JsonPropertyName("schemaChangePolicy")]
    public IList<V1beta1CrawlerSpecForProviderSchemaChangePolicy>? SchemaChangePolicy { get; set; }

    /// <summary>The name of Security Configuration to be used by the crawler</summary>
    [JsonPropertyName("securityConfiguration")]
    public string? SecurityConfiguration { get; set; }

    /// <summary>The table prefix used for catalog tables that are created.</summary>
    [JsonPropertyName("tablePrefix")]
    public string? TablePrefix { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderCatalogTargetDatabaseNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderCatalogTargetDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecInitProviderCatalogTargetDatabaseNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderCatalogTargetDatabaseNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderCatalogTargetDatabaseNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecInitProviderCatalogTargetDatabaseNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderCatalogTargetTablesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderCatalogTargetTablesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecInitProviderCatalogTargetTablesRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderCatalogTargetTablesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of CatalogTable in glue to populate tables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderCatalogTargetTablesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecInitProviderCatalogTargetTablesSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderCatalogTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Glue database where results are written.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameRef")]
    public V1beta1CrawlerSpecInitProviderCatalogTargetDatabaseNameRef? DatabaseNameRef { get; set; }

    /// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameSelector")]
    public V1beta1CrawlerSpecInitProviderCatalogTargetDatabaseNameSelector? DatabaseNameSelector { get; set; }

    /// <summary>The ARN of the dead-letter SQS queue.</summary>
    [JsonPropertyName("dlqEventQueueArn")]
    public string? DlqEventQueueArn { get; set; }

    /// <summary>The ARN of the SQS queue to receive S3 notifications from.</summary>
    [JsonPropertyName("eventQueueArn")]
    public string? EventQueueArn { get; set; }

    /// <summary>A list of catalog tables to be synchronized.</summary>
    [JsonPropertyName("tables")]
    public IList<string>? Tables { get; set; }

    /// <summary>References to CatalogTable in glue to populate tables.</summary>
    [JsonPropertyName("tablesRefs")]
    public IList<V1beta1CrawlerSpecInitProviderCatalogTargetTablesRefs>? TablesRefs { get; set; }

    /// <summary>Selector for a list of CatalogTable in glue to populate tables.</summary>
    [JsonPropertyName("tablesSelector")]
    public V1beta1CrawlerSpecInitProviderCatalogTargetTablesSelector? TablesSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderDatabaseNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecInitProviderDatabaseNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderDatabaseNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderDatabaseNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecInitProviderDatabaseNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderDeltaTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Specifies whether the crawler will create native tables, to allow integration with query engines that support querying of the Delta transaction log directly.</summary>
    [JsonPropertyName("createNativeDeltaTable")]
    public bool? CreateNativeDeltaTable { get; set; }

    /// <summary>A list of the Amazon S3 paths to the Delta tables.</summary>
    [JsonPropertyName("deltaTables")]
    public IList<string>? DeltaTables { get; set; }

    /// <summary>Specifies whether to write the manifest files to the Delta table path.</summary>
    [JsonPropertyName("writeManifest")]
    public bool? WriteManifest { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderDynamodbTarget
{
    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Indicates whether to scan all the records, or to sample rows from the table. Scanning all the records can take a long time when the table is not a high throughput table.  defaults to true.</summary>
    [JsonPropertyName("scanAll")]
    public bool? ScanAll { get; set; }

    /// <summary>The percentage of the configured read capacity units to use by the AWS Glue crawler. The valid values are null or a value between 0.1 to 1.5.</summary>
    [JsonPropertyName("scanRate")]
    public double? ScanRate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderHudiTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The maximum depth of Amazon S3 paths that the crawler can traverse to discover the Hudi metadata folder in your Amazon S3 path. Used to limit the crawler run time. Valid values are between 1 and 20.</summary>
    [JsonPropertyName("maximumTraversalDepth")]
    public double? MaximumTraversalDepth { get; set; }

    /// <summary>One or more Amazon S3 paths that contains Hudi metadata folders as s3://bucket/prefix.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderIcebergTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The maximum depth of Amazon S3 paths that the crawler can traverse to discover the Hudi metadata folder in your Amazon S3 path. Used to limit the crawler run time. Valid values are between 1 and 20.</summary>
    [JsonPropertyName("maximumTraversalDepth")]
    public double? MaximumTraversalDepth { get; set; }

    /// <summary>One or more Amazon S3 paths that contains Hudi metadata folders as s3://bucket/prefix.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderJdbcTargetConnectionNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Connection in glue to populate connectionName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderJdbcTargetConnectionNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecInitProviderJdbcTargetConnectionNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderJdbcTargetConnectionNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Connection in glue to populate connectionName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderJdbcTargetConnectionNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecInitProviderJdbcTargetConnectionNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderJdbcTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Reference to a Connection in glue to populate connectionName.</summary>
    [JsonPropertyName("connectionNameRef")]
    public V1beta1CrawlerSpecInitProviderJdbcTargetConnectionNameRef? ConnectionNameRef { get; set; }

    /// <summary>Selector for a Connection in glue to populate connectionName.</summary>
    [JsonPropertyName("connectionNameSelector")]
    public V1beta1CrawlerSpecInitProviderJdbcTargetConnectionNameSelector? ConnectionNameSelector { get; set; }

    /// <summary>Specify a value of RAWTYPES or COMMENTS to enable additional metadata intable responses. RAWTYPES provides the native-level datatype. COMMENTS provides comments associated with a column or table in the database.</summary>
    [JsonPropertyName("enableAdditionalMetadata")]
    public IList<string>? EnableAdditionalMetadata { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderLakeFormationConfiguration
{
    /// <summary>Required for cross account crawls. For same account crawls as the target data, this can omitted.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Specifies whether to use Lake Formation credentials for the crawler instead of the IAM role credentials.</summary>
    [JsonPropertyName("useLakeFormationCredentials")]
    public bool? UseLakeFormationCredentials { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderLineageConfiguration
{
    /// <summary>Specifies whether data lineage is enabled for the crawler. Valid values are: ENABLE and DISABLE. Default value is DISABLE.</summary>
    [JsonPropertyName("crawlerLineageSettings")]
    public string? CrawlerLineageSettings { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderMongodbTargetConnectionNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Connection in glue to populate connectionName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderMongodbTargetConnectionNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecInitProviderMongodbTargetConnectionNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderMongodbTargetConnectionNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Connection in glue to populate connectionName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderMongodbTargetConnectionNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecInitProviderMongodbTargetConnectionNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderMongodbTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Reference to a Connection in glue to populate connectionName.</summary>
    [JsonPropertyName("connectionNameRef")]
    public V1beta1CrawlerSpecInitProviderMongodbTargetConnectionNameRef? ConnectionNameRef { get; set; }

    /// <summary>Selector for a Connection in glue to populate connectionName.</summary>
    [JsonPropertyName("connectionNameSelector")]
    public V1beta1CrawlerSpecInitProviderMongodbTargetConnectionNameSelector? ConnectionNameSelector { get; set; }

    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Indicates whether to scan all the records, or to sample rows from the table. Scanning all the records can take a long time when the table is not a high throughput table.  defaults to true.</summary>
    [JsonPropertyName("scanAll")]
    public bool? ScanAll { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderRecrawlPolicy
{
    /// <summary>Specifies whether to crawl the entire dataset again, crawl only folders that were added since the last crawler run, or crawl what S3 notifies the crawler of via SQS. Valid Values are: CRAWL_EVENT_MODE, CRAWL_EVERYTHING and CRAWL_NEW_FOLDERS_ONLY. Default value is CRAWL_EVERYTHING.</summary>
    [JsonPropertyName("recrawlBehavior")]
    public string? RecrawlBehavior { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderRoleRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecInitProviderRoleRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderRoleSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderRoleSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecInitProviderRoleSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderS3Target
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>The ARN of the dead-letter SQS queue.</summary>
    [JsonPropertyName("dlqEventQueueArn")]
    public string? DlqEventQueueArn { get; set; }

    /// <summary>The ARN of the SQS queue to receive S3 notifications from.</summary>
    [JsonPropertyName("eventQueueArn")]
    public string? EventQueueArn { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Sets the number of files in each leaf folder to be crawled when crawling sample files in a dataset. If not set, all the files are crawled. A valid value is an integer between 1 and 249.</summary>
    [JsonPropertyName("sampleSize")]
    public double? SampleSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProviderSchemaChangePolicy
{
    /// <summary>The deletion behavior when the crawler finds a deleted object. Valid values: LOG, DELETE_FROM_DATABASE, or DEPRECATE_IN_DATABASE. Defaults to DEPRECATE_IN_DATABASE.</summary>
    [JsonPropertyName("deleteBehavior")]
    public string? DeleteBehavior { get; set; }

    /// <summary>The update behavior when the crawler finds a changed schema. Valid values: LOG or UPDATE_IN_DATABASE. Defaults to UPDATE_IN_DATABASE.</summary>
    [JsonPropertyName("updateBehavior")]
    public string? UpdateBehavior { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecInitProvider
{
    /// <summary>List of nested AWS Glue Data Catalog target arguments. See Catalog Target below.</summary>
    [JsonPropertyName("catalogTarget")]
    public IList<V1beta1CrawlerSpecInitProviderCatalogTarget>? CatalogTarget { get; set; }

    /// <summary>List of custom classifiers. By default, all AWS classifiers are included in a crawl, but these custom classifiers always override the default classifiers for a given classification.</summary>
    [JsonPropertyName("classifiers")]
    public IList<string>? Classifiers { get; set; }

    /// <summary>JSON string of configuration information. For more details see Setting Crawler Configuration Options.</summary>
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    /// <summary>Glue database where results are written.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameRef")]
    public V1beta1CrawlerSpecInitProviderDatabaseNameRef? DatabaseNameRef { get; set; }

    /// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameSelector")]
    public V1beta1CrawlerSpecInitProviderDatabaseNameSelector? DatabaseNameSelector { get; set; }

    /// <summary>List of nested Delta Lake target arguments. See Delta Target below.</summary>
    [JsonPropertyName("deltaTarget")]
    public IList<V1beta1CrawlerSpecInitProviderDeltaTarget>? DeltaTarget { get; set; }

    /// <summary>Description of the crawler.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>List of nested DynamoDB target arguments. See Dynamodb Target below.</summary>
    [JsonPropertyName("dynamodbTarget")]
    public IList<V1beta1CrawlerSpecInitProviderDynamodbTarget>? DynamodbTarget { get; set; }

    /// <summary>List of nested Hudi target arguments. See Iceberg Target below.</summary>
    [JsonPropertyName("hudiTarget")]
    public IList<V1beta1CrawlerSpecInitProviderHudiTarget>? HudiTarget { get; set; }

    /// <summary>List of nested Iceberg target arguments. See Iceberg Target below.</summary>
    [JsonPropertyName("icebergTarget")]
    public IList<V1beta1CrawlerSpecInitProviderIcebergTarget>? IcebergTarget { get; set; }

    /// <summary>List of nested JDBC target arguments. See JDBC Target below.</summary>
    [JsonPropertyName("jdbcTarget")]
    public IList<V1beta1CrawlerSpecInitProviderJdbcTarget>? JdbcTarget { get; set; }

    /// <summary>Specifies Lake Formation configuration settings for the crawler. See Lake Formation Configuration below.</summary>
    [JsonPropertyName("lakeFormationConfiguration")]
    public IList<V1beta1CrawlerSpecInitProviderLakeFormationConfiguration>? LakeFormationConfiguration { get; set; }

    /// <summary>Specifies data lineage configuration settings for the crawler. See Lineage Configuration below.</summary>
    [JsonPropertyName("lineageConfiguration")]
    public IList<V1beta1CrawlerSpecInitProviderLineageConfiguration>? LineageConfiguration { get; set; }

    /// <summary>List of nested MongoDB target arguments. See MongoDB Target below.</summary>
    [JsonPropertyName("mongodbTarget")]
    public IList<V1beta1CrawlerSpecInitProviderMongodbTarget>? MongodbTarget { get; set; }

    /// <summary>A policy that specifies whether to crawl the entire dataset again, or to crawl only folders that were added since the last crawler run.. See Recrawl Policy below.</summary>
    [JsonPropertyName("recrawlPolicy")]
    public IList<V1beta1CrawlerSpecInitProviderRecrawlPolicy>? RecrawlPolicy { get; set; }

    /// <summary>The IAM role friendly name (including path without leading slash), or ARN of an IAM role, used by the crawler to access other resources.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Reference to a Role in iam to populate role.</summary>
    [JsonPropertyName("roleRef")]
    public V1beta1CrawlerSpecInitProviderRoleRef? RoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate role.</summary>
    [JsonPropertyName("roleSelector")]
    public V1beta1CrawlerSpecInitProviderRoleSelector? RoleSelector { get; set; }

    /// <summary>List of nested Amazon S3 target arguments. See S3 Target below.</summary>
    [JsonPropertyName("s3Target")]
    public IList<V1beta1CrawlerSpecInitProviderS3Target>? S3Target { get; set; }

    /// <summary>Based Schedules for Jobs and Crawlers. For example, to run something every day at 12:15 UTC, you would specify: cron(15 12 * * ? *).</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>Policy for the crawler's update and deletion behavior. See Schema Change Policy below.</summary>
    [JsonPropertyName("schemaChangePolicy")]
    public IList<V1beta1CrawlerSpecInitProviderSchemaChangePolicy>? SchemaChangePolicy { get; set; }

    /// <summary>The name of Security Configuration to be used by the crawler</summary>
    [JsonPropertyName("securityConfiguration")]
    public string? SecurityConfiguration { get; set; }

    /// <summary>The table prefix used for catalog tables that are created.</summary>
    [JsonPropertyName("tablePrefix")]
    public string? TablePrefix { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecProviderConfigRefPolicy
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
public partial class V1beta1CrawlerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CrawlerSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>CrawlerSpec defines the desired state of Crawler</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CrawlerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CrawlerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CrawlerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CrawlerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerStatusAtProviderCatalogTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Glue database where results are written.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The ARN of the dead-letter SQS queue.</summary>
    [JsonPropertyName("dlqEventQueueArn")]
    public string? DlqEventQueueArn { get; set; }

    /// <summary>The ARN of the SQS queue to receive S3 notifications from.</summary>
    [JsonPropertyName("eventQueueArn")]
    public string? EventQueueArn { get; set; }

    /// <summary>A list of catalog tables to be synchronized.</summary>
    [JsonPropertyName("tables")]
    public IList<string>? Tables { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerStatusAtProviderDeltaTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Specifies whether the crawler will create native tables, to allow integration with query engines that support querying of the Delta transaction log directly.</summary>
    [JsonPropertyName("createNativeDeltaTable")]
    public bool? CreateNativeDeltaTable { get; set; }

    /// <summary>A list of the Amazon S3 paths to the Delta tables.</summary>
    [JsonPropertyName("deltaTables")]
    public IList<string>? DeltaTables { get; set; }

    /// <summary>Specifies whether to write the manifest files to the Delta table path.</summary>
    [JsonPropertyName("writeManifest")]
    public bool? WriteManifest { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerStatusAtProviderDynamodbTarget
{
    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Indicates whether to scan all the records, or to sample rows from the table. Scanning all the records can take a long time when the table is not a high throughput table.  defaults to true.</summary>
    [JsonPropertyName("scanAll")]
    public bool? ScanAll { get; set; }

    /// <summary>The percentage of the configured read capacity units to use by the AWS Glue crawler. The valid values are null or a value between 0.1 to 1.5.</summary>
    [JsonPropertyName("scanRate")]
    public double? ScanRate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerStatusAtProviderHudiTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The maximum depth of Amazon S3 paths that the crawler can traverse to discover the Hudi metadata folder in your Amazon S3 path. Used to limit the crawler run time. Valid values are between 1 and 20.</summary>
    [JsonPropertyName("maximumTraversalDepth")]
    public double? MaximumTraversalDepth { get; set; }

    /// <summary>One or more Amazon S3 paths that contains Hudi metadata folders as s3://bucket/prefix.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerStatusAtProviderIcebergTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The maximum depth of Amazon S3 paths that the crawler can traverse to discover the Hudi metadata folder in your Amazon S3 path. Used to limit the crawler run time. Valid values are between 1 and 20.</summary>
    [JsonPropertyName("maximumTraversalDepth")]
    public double? MaximumTraversalDepth { get; set; }

    /// <summary>One or more Amazon S3 paths that contains Hudi metadata folders as s3://bucket/prefix.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerStatusAtProviderJdbcTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Specify a value of RAWTYPES or COMMENTS to enable additional metadata intable responses. RAWTYPES provides the native-level datatype. COMMENTS provides comments associated with a column or table in the database.</summary>
    [JsonPropertyName("enableAdditionalMetadata")]
    public IList<string>? EnableAdditionalMetadata { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerStatusAtProviderLakeFormationConfiguration
{
    /// <summary>Required for cross account crawls. For same account crawls as the target data, this can omitted.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Specifies whether to use Lake Formation credentials for the crawler instead of the IAM role credentials.</summary>
    [JsonPropertyName("useLakeFormationCredentials")]
    public bool? UseLakeFormationCredentials { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerStatusAtProviderLineageConfiguration
{
    /// <summary>Specifies whether data lineage is enabled for the crawler. Valid values are: ENABLE and DISABLE. Default value is DISABLE.</summary>
    [JsonPropertyName("crawlerLineageSettings")]
    public string? CrawlerLineageSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerStatusAtProviderMongodbTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Indicates whether to scan all the records, or to sample rows from the table. Scanning all the records can take a long time when the table is not a high throughput table.  defaults to true.</summary>
    [JsonPropertyName("scanAll")]
    public bool? ScanAll { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerStatusAtProviderRecrawlPolicy
{
    /// <summary>Specifies whether to crawl the entire dataset again, crawl only folders that were added since the last crawler run, or crawl what S3 notifies the crawler of via SQS. Valid Values are: CRAWL_EVENT_MODE, CRAWL_EVERYTHING and CRAWL_NEW_FOLDERS_ONLY. Default value is CRAWL_EVERYTHING.</summary>
    [JsonPropertyName("recrawlBehavior")]
    public string? RecrawlBehavior { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerStatusAtProviderS3Target
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>The ARN of the dead-letter SQS queue.</summary>
    [JsonPropertyName("dlqEventQueueArn")]
    public string? DlqEventQueueArn { get; set; }

    /// <summary>The ARN of the SQS queue to receive S3 notifications from.</summary>
    [JsonPropertyName("eventQueueArn")]
    public string? EventQueueArn { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Sets the number of files in each leaf folder to be crawled when crawling sample files in a dataset. If not set, all the files are crawled. A valid value is an integer between 1 and 249.</summary>
    [JsonPropertyName("sampleSize")]
    public double? SampleSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerStatusAtProviderSchemaChangePolicy
{
    /// <summary>The deletion behavior when the crawler finds a deleted object. Valid values: LOG, DELETE_FROM_DATABASE, or DEPRECATE_IN_DATABASE. Defaults to DEPRECATE_IN_DATABASE.</summary>
    [JsonPropertyName("deleteBehavior")]
    public string? DeleteBehavior { get; set; }

    /// <summary>The update behavior when the crawler finds a changed schema. Valid values: LOG or UPDATE_IN_DATABASE. Defaults to UPDATE_IN_DATABASE.</summary>
    [JsonPropertyName("updateBehavior")]
    public string? UpdateBehavior { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerStatusAtProvider
{
    /// <summary>The ARN of the crawler</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>List of nested AWS Glue Data Catalog target arguments. See Catalog Target below.</summary>
    [JsonPropertyName("catalogTarget")]
    public IList<V1beta1CrawlerStatusAtProviderCatalogTarget>? CatalogTarget { get; set; }

    /// <summary>List of custom classifiers. By default, all AWS classifiers are included in a crawl, but these custom classifiers always override the default classifiers for a given classification.</summary>
    [JsonPropertyName("classifiers")]
    public IList<string>? Classifiers { get; set; }

    /// <summary>JSON string of configuration information. For more details see Setting Crawler Configuration Options.</summary>
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    /// <summary>Glue database where results are written.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>List of nested Delta Lake target arguments. See Delta Target below.</summary>
    [JsonPropertyName("deltaTarget")]
    public IList<V1beta1CrawlerStatusAtProviderDeltaTarget>? DeltaTarget { get; set; }

    /// <summary>Description of the crawler.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>List of nested DynamoDB target arguments. See Dynamodb Target below.</summary>
    [JsonPropertyName("dynamodbTarget")]
    public IList<V1beta1CrawlerStatusAtProviderDynamodbTarget>? DynamodbTarget { get; set; }

    /// <summary>List of nested Hudi target arguments. See Iceberg Target below.</summary>
    [JsonPropertyName("hudiTarget")]
    public IList<V1beta1CrawlerStatusAtProviderHudiTarget>? HudiTarget { get; set; }

    /// <summary>List of nested Iceberg target arguments. See Iceberg Target below.</summary>
    [JsonPropertyName("icebergTarget")]
    public IList<V1beta1CrawlerStatusAtProviderIcebergTarget>? IcebergTarget { get; set; }

    /// <summary>Crawler name</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>List of nested JDBC target arguments. See JDBC Target below.</summary>
    [JsonPropertyName("jdbcTarget")]
    public IList<V1beta1CrawlerStatusAtProviderJdbcTarget>? JdbcTarget { get; set; }

    /// <summary>Specifies Lake Formation configuration settings for the crawler. See Lake Formation Configuration below.</summary>
    [JsonPropertyName("lakeFormationConfiguration")]
    public IList<V1beta1CrawlerStatusAtProviderLakeFormationConfiguration>? LakeFormationConfiguration { get; set; }

    /// <summary>Specifies data lineage configuration settings for the crawler. See Lineage Configuration below.</summary>
    [JsonPropertyName("lineageConfiguration")]
    public IList<V1beta1CrawlerStatusAtProviderLineageConfiguration>? LineageConfiguration { get; set; }

    /// <summary>List of nested MongoDB target arguments. See MongoDB Target below.</summary>
    [JsonPropertyName("mongodbTarget")]
    public IList<V1beta1CrawlerStatusAtProviderMongodbTarget>? MongodbTarget { get; set; }

    /// <summary>A policy that specifies whether to crawl the entire dataset again, or to crawl only folders that were added since the last crawler run.. See Recrawl Policy below.</summary>
    [JsonPropertyName("recrawlPolicy")]
    public IList<V1beta1CrawlerStatusAtProviderRecrawlPolicy>? RecrawlPolicy { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The IAM role friendly name (including path without leading slash), or ARN of an IAM role, used by the crawler to access other resources.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>List of nested Amazon S3 target arguments. See S3 Target below.</summary>
    [JsonPropertyName("s3Target")]
    public IList<V1beta1CrawlerStatusAtProviderS3Target>? S3Target { get; set; }

    /// <summary>Based Schedules for Jobs and Crawlers. For example, to run something every day at 12:15 UTC, you would specify: cron(15 12 * * ? *).</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>Policy for the crawler's update and deletion behavior. See Schema Change Policy below.</summary>
    [JsonPropertyName("schemaChangePolicy")]
    public IList<V1beta1CrawlerStatusAtProviderSchemaChangePolicy>? SchemaChangePolicy { get; set; }

    /// <summary>The name of Security Configuration to be used by the crawler</summary>
    [JsonPropertyName("securityConfiguration")]
    public string? SecurityConfiguration { get; set; }

    /// <summary>The table prefix used for catalog tables that are created.</summary>
    [JsonPropertyName("tablePrefix")]
    public string? TablePrefix { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerStatusConditions
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

/// <summary>CrawlerStatus defines the observed state of Crawler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CrawlerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CrawlerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CrawlerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Crawler is the Schema for the Crawlers API. Manages a Glue Crawler</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Crawler : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CrawlerSpec>, IStatus<V1beta1CrawlerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Crawler";
    public const string KubeGroup = "glue.aws.upbound.io";
    public const string KubePluralName = "crawlers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CrawlerSpec defines the desired state of Crawler</summary>
    [JsonPropertyName("spec")]
    public V1beta1CrawlerSpec Spec { get; set; }

    /// <summary>CrawlerStatus defines the observed state of Crawler.</summary>
    [JsonPropertyName("status")]
    public V1beta1CrawlerStatus? Status { get; set; }
}

/// <summary>Crawler is the Schema for the Crawlers API. Manages a Glue Crawler</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CrawlerList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Crawler>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CrawlerList";
    public const string KubeGroup = "glue.aws.upbound.io";
    public const string KubePluralName = "crawlers";
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
    public IList<V1beta1Crawler> Items { get; set; }
}