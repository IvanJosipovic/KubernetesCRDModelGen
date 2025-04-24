using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquery.gcp.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAwsAccessRole
{
    /// <summary>The user’s AWS IAM Role that trusts the Google-owned AWS IAM user Connection.</summary>
    [JsonPropertyName("iamRoleId")]
    public string? IamRoleId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAws
{
    /// <summary>Authentication using Google owned service account to assume into customer's AWS IAM Role. Structure is documented below.</summary>
    [JsonPropertyName("accessRole")]
    public IList<V1beta1ConnectionSpecForProviderAwsAccessRole>? AccessRole { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderAzure
{
    /// <summary>The id of customer's directory that host the data.</summary>
    [JsonPropertyName("customerTenantId")]
    public string? CustomerTenantId { get; set; }

    /// <summary>The Azure Application (client) ID where the federated credentials will be hosted.</summary>
    [JsonPropertyName("federatedApplicationClientId")]
    public string? FederatedApplicationClientId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderCloudResource
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderCloudSpanner
{
    /// <summary>Cloud Spanner database in the form `project/instance/database'.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Cloud Spanner database role for fine-grained access control. The Cloud Spanner admin should have provisioned the database role with appropriate permissions, such as SELECT and INSERT. Other users should only use roles provided by their Cloud Spanner admins. The database role name must start with a letter, and can only contain letters, numbers, and underscores. For more details, see https://cloud.google.com/spanner/docs/fgac-about.</summary>
    [JsonPropertyName("databaseRole")]
    public string? DatabaseRole { get; set; }

    /// <summary>Allows setting max parallelism per query when executing on Spanner independent compute resources. If unspecified, default values of parallelism are chosen that are dependent on the Cloud Spanner instance configuration. useParallelism and useDataBoost must be set when setting max parallelism.</summary>
    [JsonPropertyName("maxParallelism")]
    public double? MaxParallelism { get; set; }

    /// <summary>If set, the request will be executed via Spanner independent compute resources. use_parallelism must be set when using data boost.</summary>
    [JsonPropertyName("useDataBoost")]
    public bool? UseDataBoost { get; set; }

    /// <summary>If parallelism should be used when reading from Cloud Spanner.</summary>
    [JsonPropertyName("useParallelism")]
    public bool? UseParallelism { get; set; }

    /// <summary>If the serverless analytics service should be used to read data from Cloud Spanner. useParallelism must be set when using serverless analytics.</summary>
    [JsonPropertyName("useServerlessAnalytics")]
    public bool? UseServerlessAnalytics { get; set; }
}

/// <summary>Password for database. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderCloudSqlCredentialPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderCloudSqlCredentialUsernameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a User in sql to populate username.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderCloudSqlCredentialUsernameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecForProviderCloudSqlCredentialUsernameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderCloudSqlCredentialUsernameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a User in sql to populate username.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderCloudSqlCredentialUsernameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecForProviderCloudSqlCredentialUsernameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderCloudSqlCredential
{
    /// <summary>Password for database. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1ConnectionSpecForProviderCloudSqlCredentialPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>Username for database.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>Reference to a User in sql to populate username.</summary>
    [JsonPropertyName("usernameRef")]
    public V1beta1ConnectionSpecForProviderCloudSqlCredentialUsernameRef? UsernameRef { get; set; }

    /// <summary>Selector for a User in sql to populate username.</summary>
    [JsonPropertyName("usernameSelector")]
    public V1beta1ConnectionSpecForProviderCloudSqlCredentialUsernameSelector? UsernameSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderCloudSqlDatabaseRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Database in sql to populate database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderCloudSqlDatabaseRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecForProviderCloudSqlDatabaseRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderCloudSqlDatabaseSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Database in sql to populate database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderCloudSqlDatabaseSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecForProviderCloudSqlDatabaseSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderCloudSqlInstanceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a DatabaseInstance in sql to populate instanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderCloudSqlInstanceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecForProviderCloudSqlInstanceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderCloudSqlInstanceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a DatabaseInstance in sql to populate instanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderCloudSqlInstanceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecForProviderCloudSqlInstanceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderCloudSql
{
    /// <summary>Cloud SQL properties. Structure is documented below.</summary>
    [JsonPropertyName("credential")]
    public IList<V1beta1ConnectionSpecForProviderCloudSqlCredential>? Credential { get; set; }

    /// <summary>Database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Reference to a Database in sql to populate database.</summary>
    [JsonPropertyName("databaseRef")]
    public V1beta1ConnectionSpecForProviderCloudSqlDatabaseRef? DatabaseRef { get; set; }

    /// <summary>Selector for a Database in sql to populate database.</summary>
    [JsonPropertyName("databaseSelector")]
    public V1beta1ConnectionSpecForProviderCloudSqlDatabaseSelector? DatabaseSelector { get; set; }

    /// <summary>Cloud SQL instance ID in the form project:location:instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>Reference to a DatabaseInstance in sql to populate instanceId.</summary>
    [JsonPropertyName("instanceIdRef")]
    public V1beta1ConnectionSpecForProviderCloudSqlInstanceIdRef? InstanceIdRef { get; set; }

    /// <summary>Selector for a DatabaseInstance in sql to populate instanceId.</summary>
    [JsonPropertyName("instanceIdSelector")]
    public V1beta1ConnectionSpecForProviderCloudSqlInstanceIdSelector? InstanceIdSelector { get; set; }

    /// <summary>Type of the Cloud SQL database. Possible values are: DATABASE_TYPE_UNSPECIFIED, POSTGRES, MYSQL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderSparkMetastoreServiceConfig
{
    /// <summary>Resource name of an existing Dataproc Metastore service in the form of projects/[projectId]/locations/[region]/services/[serviceId].</summary>
    [JsonPropertyName("metastoreService")]
    public string? MetastoreService { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in dataproc to populate dataprocCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in dataproc to populate dataprocCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderSparkSparkHistoryServerConfig
{
    /// <summary>Resource name of an existing Dataproc Cluster to act as a Spark History Server for the connection if the form of projects/[projectId]/regions/[region]/clusters/[cluster_name].</summary>
    [JsonPropertyName("dataprocCluster")]
    public string? DataprocCluster { get; set; }

    /// <summary>Reference to a Cluster in dataproc to populate dataprocCluster.</summary>
    [JsonPropertyName("dataprocClusterRef")]
    public V1beta1ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterRef? DataprocClusterRef { get; set; }

    /// <summary>Selector for a Cluster in dataproc to populate dataprocCluster.</summary>
    [JsonPropertyName("dataprocClusterSelector")]
    public V1beta1ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterSelector? DataprocClusterSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProviderSpark
{
    /// <summary>Dataproc Metastore Service configuration for the connection. Structure is documented below.</summary>
    [JsonPropertyName("metastoreServiceConfig")]
    public IList<V1beta1ConnectionSpecForProviderSparkMetastoreServiceConfig>? MetastoreServiceConfig { get; set; }

    /// <summary>Spark History Server configuration for the connection. Structure is documented below.</summary>
    [JsonPropertyName("sparkHistoryServerConfig")]
    public IList<V1beta1ConnectionSpecForProviderSparkSparkHistoryServerConfig>? SparkHistoryServerConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecForProvider
{
    /// <summary>Connection properties specific to Amazon Web Services. Structure is documented below.</summary>
    [JsonPropertyName("aws")]
    public IList<V1beta1ConnectionSpecForProviderAws>? Aws { get; set; }

    /// <summary>Container for connection properties specific to Azure. Structure is documented below.</summary>
    [JsonPropertyName("azure")]
    public IList<V1beta1ConnectionSpecForProviderAzure>? Azure { get; set; }

    /// <summary>Container for connection properties for delegation of access to GCP resources. Structure is documented below.</summary>
    [JsonPropertyName("cloudResource")]
    public IList<V1beta1ConnectionSpecForProviderCloudResource>? CloudResource { get; set; }

    /// <summary>Connection properties specific to Cloud Spanner Structure is documented below.</summary>
    [JsonPropertyName("cloudSpanner")]
    public IList<V1beta1ConnectionSpecForProviderCloudSpanner>? CloudSpanner { get; set; }

    /// <summary>Connection properties specific to the Cloud SQL. Structure is documented below.</summary>
    [JsonPropertyName("cloudSql")]
    public IList<V1beta1ConnectionSpecForProviderCloudSql>? CloudSql { get; set; }

    /// <summary>Optional connection id that should be assigned to the created connection.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>A descriptive description for the connection</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A descriptive name for the connection</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>Optional. The Cloud KMS key that is used for encryption. Example: projects/[kms_project_id]/locations/[region]/keyRings/[key_region]/cryptoKeys/[key]</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>The geographic location where the connection should reside. Cloud SQL instance must be in the same location as the connection with following exceptions: Cloud SQL us-central1 maps to BigQuery US, Cloud SQL europe-west1 maps to BigQuery EU. Examples: US, EU, asia-northeast1, us-central1, europe-west1. Spanner Connections same as spanner region AWS allowed regions are aws-us-east-1 Azure allowed regions are azure-eastus2</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Container for connection properties to execute stored procedures for Apache Spark. resources. Structure is documented below.</summary>
    [JsonPropertyName("spark")]
    public IList<V1beta1ConnectionSpecForProviderSpark>? Spark { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAwsAccessRole
{
    /// <summary>The user’s AWS IAM Role that trusts the Google-owned AWS IAM user Connection.</summary>
    [JsonPropertyName("iamRoleId")]
    public string? IamRoleId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAws
{
    /// <summary>Authentication using Google owned service account to assume into customer's AWS IAM Role. Structure is documented below.</summary>
    [JsonPropertyName("accessRole")]
    public IList<V1beta1ConnectionSpecInitProviderAwsAccessRole>? AccessRole { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderAzure
{
    /// <summary>The id of customer's directory that host the data.</summary>
    [JsonPropertyName("customerTenantId")]
    public string? CustomerTenantId { get; set; }

    /// <summary>The Azure Application (client) ID where the federated credentials will be hosted.</summary>
    [JsonPropertyName("federatedApplicationClientId")]
    public string? FederatedApplicationClientId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderCloudResource
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderCloudSpanner
{
    /// <summary>Cloud Spanner database in the form `project/instance/database'.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Cloud Spanner database role for fine-grained access control. The Cloud Spanner admin should have provisioned the database role with appropriate permissions, such as SELECT and INSERT. Other users should only use roles provided by their Cloud Spanner admins. The database role name must start with a letter, and can only contain letters, numbers, and underscores. For more details, see https://cloud.google.com/spanner/docs/fgac-about.</summary>
    [JsonPropertyName("databaseRole")]
    public string? DatabaseRole { get; set; }

    /// <summary>Allows setting max parallelism per query when executing on Spanner independent compute resources. If unspecified, default values of parallelism are chosen that are dependent on the Cloud Spanner instance configuration. useParallelism and useDataBoost must be set when setting max parallelism.</summary>
    [JsonPropertyName("maxParallelism")]
    public double? MaxParallelism { get; set; }

    /// <summary>If set, the request will be executed via Spanner independent compute resources. use_parallelism must be set when using data boost.</summary>
    [JsonPropertyName("useDataBoost")]
    public bool? UseDataBoost { get; set; }

    /// <summary>If parallelism should be used when reading from Cloud Spanner.</summary>
    [JsonPropertyName("useParallelism")]
    public bool? UseParallelism { get; set; }

    /// <summary>If the serverless analytics service should be used to read data from Cloud Spanner. useParallelism must be set when using serverless analytics.</summary>
    [JsonPropertyName("useServerlessAnalytics")]
    public bool? UseServerlessAnalytics { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderCloudSqlCredentialUsernameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a User in sql to populate username.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderCloudSqlCredentialUsernameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecInitProviderCloudSqlCredentialUsernameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderCloudSqlCredentialUsernameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a User in sql to populate username.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderCloudSqlCredentialUsernameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecInitProviderCloudSqlCredentialUsernameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderCloudSqlCredential
{
    /// <summary>Username for database.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>Reference to a User in sql to populate username.</summary>
    [JsonPropertyName("usernameRef")]
    public V1beta1ConnectionSpecInitProviderCloudSqlCredentialUsernameRef? UsernameRef { get; set; }

    /// <summary>Selector for a User in sql to populate username.</summary>
    [JsonPropertyName("usernameSelector")]
    public V1beta1ConnectionSpecInitProviderCloudSqlCredentialUsernameSelector? UsernameSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderCloudSqlDatabaseRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Database in sql to populate database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderCloudSqlDatabaseRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecInitProviderCloudSqlDatabaseRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderCloudSqlDatabaseSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Database in sql to populate database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderCloudSqlDatabaseSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecInitProviderCloudSqlDatabaseSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderCloudSqlInstanceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a DatabaseInstance in sql to populate instanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderCloudSqlInstanceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecInitProviderCloudSqlInstanceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderCloudSqlInstanceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a DatabaseInstance in sql to populate instanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderCloudSqlInstanceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecInitProviderCloudSqlInstanceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderCloudSql
{
    /// <summary>Cloud SQL properties. Structure is documented below.</summary>
    [JsonPropertyName("credential")]
    public IList<V1beta1ConnectionSpecInitProviderCloudSqlCredential>? Credential { get; set; }

    /// <summary>Database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Reference to a Database in sql to populate database.</summary>
    [JsonPropertyName("databaseRef")]
    public V1beta1ConnectionSpecInitProviderCloudSqlDatabaseRef? DatabaseRef { get; set; }

    /// <summary>Selector for a Database in sql to populate database.</summary>
    [JsonPropertyName("databaseSelector")]
    public V1beta1ConnectionSpecInitProviderCloudSqlDatabaseSelector? DatabaseSelector { get; set; }

    /// <summary>Cloud SQL instance ID in the form project:location:instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>Reference to a DatabaseInstance in sql to populate instanceId.</summary>
    [JsonPropertyName("instanceIdRef")]
    public V1beta1ConnectionSpecInitProviderCloudSqlInstanceIdRef? InstanceIdRef { get; set; }

    /// <summary>Selector for a DatabaseInstance in sql to populate instanceId.</summary>
    [JsonPropertyName("instanceIdSelector")]
    public V1beta1ConnectionSpecInitProviderCloudSqlInstanceIdSelector? InstanceIdSelector { get; set; }

    /// <summary>Type of the Cloud SQL database. Possible values are: DATABASE_TYPE_UNSPECIFIED, POSTGRES, MYSQL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderSparkMetastoreServiceConfig
{
    /// <summary>Resource name of an existing Dataproc Metastore service in the form of projects/[projectId]/locations/[region]/services/[serviceId].</summary>
    [JsonPropertyName("metastoreService")]
    public string? MetastoreService { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in dataproc to populate dataprocCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in dataproc to populate dataprocCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderSparkSparkHistoryServerConfig
{
    /// <summary>Resource name of an existing Dataproc Cluster to act as a Spark History Server for the connection if the form of projects/[projectId]/regions/[region]/clusters/[cluster_name].</summary>
    [JsonPropertyName("dataprocCluster")]
    public string? DataprocCluster { get; set; }

    /// <summary>Reference to a Cluster in dataproc to populate dataprocCluster.</summary>
    [JsonPropertyName("dataprocClusterRef")]
    public V1beta1ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterRef? DataprocClusterRef { get; set; }

    /// <summary>Selector for a Cluster in dataproc to populate dataprocCluster.</summary>
    [JsonPropertyName("dataprocClusterSelector")]
    public V1beta1ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterSelector? DataprocClusterSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProviderSpark
{
    /// <summary>Dataproc Metastore Service configuration for the connection. Structure is documented below.</summary>
    [JsonPropertyName("metastoreServiceConfig")]
    public IList<V1beta1ConnectionSpecInitProviderSparkMetastoreServiceConfig>? MetastoreServiceConfig { get; set; }

    /// <summary>Spark History Server configuration for the connection. Structure is documented below.</summary>
    [JsonPropertyName("sparkHistoryServerConfig")]
    public IList<V1beta1ConnectionSpecInitProviderSparkSparkHistoryServerConfig>? SparkHistoryServerConfig { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecInitProvider
{
    /// <summary>Connection properties specific to Amazon Web Services. Structure is documented below.</summary>
    [JsonPropertyName("aws")]
    public IList<V1beta1ConnectionSpecInitProviderAws>? Aws { get; set; }

    /// <summary>Container for connection properties specific to Azure. Structure is documented below.</summary>
    [JsonPropertyName("azure")]
    public IList<V1beta1ConnectionSpecInitProviderAzure>? Azure { get; set; }

    /// <summary>Container for connection properties for delegation of access to GCP resources. Structure is documented below.</summary>
    [JsonPropertyName("cloudResource")]
    public IList<V1beta1ConnectionSpecInitProviderCloudResource>? CloudResource { get; set; }

    /// <summary>Connection properties specific to Cloud Spanner Structure is documented below.</summary>
    [JsonPropertyName("cloudSpanner")]
    public IList<V1beta1ConnectionSpecInitProviderCloudSpanner>? CloudSpanner { get; set; }

    /// <summary>Connection properties specific to the Cloud SQL. Structure is documented below.</summary>
    [JsonPropertyName("cloudSql")]
    public IList<V1beta1ConnectionSpecInitProviderCloudSql>? CloudSql { get; set; }

    /// <summary>Optional connection id that should be assigned to the created connection.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>A descriptive description for the connection</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A descriptive name for the connection</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>Optional. The Cloud KMS key that is used for encryption. Example: projects/[kms_project_id]/locations/[region]/keyRings/[key_region]/cryptoKeys/[key]</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>The geographic location where the connection should reside. Cloud SQL instance must be in the same location as the connection with following exceptions: Cloud SQL us-central1 maps to BigQuery US, Cloud SQL europe-west1 maps to BigQuery EU. Examples: US, EU, asia-northeast1, us-central1, europe-west1. Spanner Connections same as spanner region AWS allowed regions are aws-us-east-1 Azure allowed regions are azure-eastus2</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Container for connection properties to execute stored procedures for Apache Spark. resources. Structure is documented below.</summary>
    [JsonPropertyName("spark")]
    public IList<V1beta1ConnectionSpecInitProviderSpark>? Spark { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecProviderConfigRefPolicy
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
public partial class V1beta1ConnectionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1ConnectionSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ConnectionSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ConnectionSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ConnectionSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ConnectionSpec defines the desired state of Connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ConnectionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ConnectionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ConnectionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ConnectionSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ConnectionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderAwsAccessRole
{
    /// <summary>The user’s AWS IAM Role that trusts the Google-owned AWS IAM user Connection.</summary>
    [JsonPropertyName("iamRoleId")]
    public string? IamRoleId { get; set; }

    /// <summary>(Output) A unique Google-owned and Google-generated identity for the Connection. This identity will be used to access the user's AWS IAM Role.</summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderAws
{
    /// <summary>Authentication using Google owned service account to assume into customer's AWS IAM Role. Structure is documented below.</summary>
    [JsonPropertyName("accessRole")]
    public IList<V1beta1ConnectionStatusAtProviderAwsAccessRole>? AccessRole { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderAzure
{
    /// <summary>(Output) The name of the Azure Active Directory Application.</summary>
    [JsonPropertyName("application")]
    public string? Application { get; set; }

    /// <summary>(Output) The client id of the Azure Active Directory Application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The id of customer's directory that host the data.</summary>
    [JsonPropertyName("customerTenantId")]
    public string? CustomerTenantId { get; set; }

    /// <summary>The Azure Application (client) ID where the federated credentials will be hosted.</summary>
    [JsonPropertyName("federatedApplicationClientId")]
    public string? FederatedApplicationClientId { get; set; }

    /// <summary>(Output) A unique Google-owned and Google-generated identity for the Connection. This identity will be used to access the user's Azure Active Directory Application.</summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>(Output) The object id of the Azure Active Directory Application.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>(Output) The URL user will be redirected to after granting consent during connection setup.</summary>
    [JsonPropertyName("redirectUri")]
    public string? RedirectUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderCloudResource
{
    /// <summary>(Output) The account ID of the service created for the purpose of this connection.</summary>
    [JsonPropertyName("serviceAccountId")]
    public string? ServiceAccountId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderCloudSpanner
{
    /// <summary>Cloud Spanner database in the form `project/instance/database'.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Cloud Spanner database role for fine-grained access control. The Cloud Spanner admin should have provisioned the database role with appropriate permissions, such as SELECT and INSERT. Other users should only use roles provided by their Cloud Spanner admins. The database role name must start with a letter, and can only contain letters, numbers, and underscores. For more details, see https://cloud.google.com/spanner/docs/fgac-about.</summary>
    [JsonPropertyName("databaseRole")]
    public string? DatabaseRole { get; set; }

    /// <summary>Allows setting max parallelism per query when executing on Spanner independent compute resources. If unspecified, default values of parallelism are chosen that are dependent on the Cloud Spanner instance configuration. useParallelism and useDataBoost must be set when setting max parallelism.</summary>
    [JsonPropertyName("maxParallelism")]
    public double? MaxParallelism { get; set; }

    /// <summary>If set, the request will be executed via Spanner independent compute resources. use_parallelism must be set when using data boost.</summary>
    [JsonPropertyName("useDataBoost")]
    public bool? UseDataBoost { get; set; }

    /// <summary>If parallelism should be used when reading from Cloud Spanner.</summary>
    [JsonPropertyName("useParallelism")]
    public bool? UseParallelism { get; set; }

    /// <summary>If the serverless analytics service should be used to read data from Cloud Spanner. useParallelism must be set when using serverless analytics.</summary>
    [JsonPropertyName("useServerlessAnalytics")]
    public bool? UseServerlessAnalytics { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderCloudSqlCredential
{
    /// <summary>Username for database.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderCloudSql
{
    /// <summary>Cloud SQL properties. Structure is documented below.</summary>
    [JsonPropertyName("credential")]
    public IList<V1beta1ConnectionStatusAtProviderCloudSqlCredential>? Credential { get; set; }

    /// <summary>Database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Cloud SQL instance ID in the form project:location:instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>(Output) When the connection is used in the context of an operation in BigQuery, this service account will serve as the identity being used for connecting to the CloudSQL instance specified in this connection.</summary>
    [JsonPropertyName("serviceAccountId")]
    public string? ServiceAccountId { get; set; }

    /// <summary>Type of the Cloud SQL database. Possible values are: DATABASE_TYPE_UNSPECIFIED, POSTGRES, MYSQL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderSparkMetastoreServiceConfig
{
    /// <summary>Resource name of an existing Dataproc Metastore service in the form of projects/[projectId]/locations/[region]/services/[serviceId].</summary>
    [JsonPropertyName("metastoreService")]
    public string? MetastoreService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderSparkSparkHistoryServerConfig
{
    /// <summary>Resource name of an existing Dataproc Cluster to act as a Spark History Server for the connection if the form of projects/[projectId]/regions/[region]/clusters/[cluster_name].</summary>
    [JsonPropertyName("dataprocCluster")]
    public string? DataprocCluster { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProviderSpark
{
    /// <summary>Dataproc Metastore Service configuration for the connection. Structure is documented below.</summary>
    [JsonPropertyName("metastoreServiceConfig")]
    public IList<V1beta1ConnectionStatusAtProviderSparkMetastoreServiceConfig>? MetastoreServiceConfig { get; set; }

    /// <summary>(Output) The account ID of the service created for the purpose of this connection.</summary>
    [JsonPropertyName("serviceAccountId")]
    public string? ServiceAccountId { get; set; }

    /// <summary>Spark History Server configuration for the connection. Structure is documented below.</summary>
    [JsonPropertyName("sparkHistoryServerConfig")]
    public IList<V1beta1ConnectionStatusAtProviderSparkSparkHistoryServerConfig>? SparkHistoryServerConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusAtProvider
{
    /// <summary>Connection properties specific to Amazon Web Services. Structure is documented below.</summary>
    [JsonPropertyName("aws")]
    public IList<V1beta1ConnectionStatusAtProviderAws>? Aws { get; set; }

    /// <summary>Container for connection properties specific to Azure. Structure is documented below.</summary>
    [JsonPropertyName("azure")]
    public IList<V1beta1ConnectionStatusAtProviderAzure>? Azure { get; set; }

    /// <summary>Container for connection properties for delegation of access to GCP resources. Structure is documented below.</summary>
    [JsonPropertyName("cloudResource")]
    public IList<V1beta1ConnectionStatusAtProviderCloudResource>? CloudResource { get; set; }

    /// <summary>Connection properties specific to Cloud Spanner Structure is documented below.</summary>
    [JsonPropertyName("cloudSpanner")]
    public IList<V1beta1ConnectionStatusAtProviderCloudSpanner>? CloudSpanner { get; set; }

    /// <summary>Connection properties specific to the Cloud SQL. Structure is documented below.</summary>
    [JsonPropertyName("cloudSql")]
    public IList<V1beta1ConnectionStatusAtProviderCloudSql>? CloudSql { get; set; }

    /// <summary>Optional connection id that should be assigned to the created connection.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>A descriptive description for the connection</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A descriptive name for the connection</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>True if the connection has credential assigned.</summary>
    [JsonPropertyName("hasCredential")]
    public bool? HasCredential { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/connections/{{connection_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Optional. The Cloud KMS key that is used for encryption. Example: projects/[kms_project_id]/locations/[region]/keyRings/[key_region]/cryptoKeys/[key]</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>The geographic location where the connection should reside. Cloud SQL instance must be in the same location as the connection with following exceptions: Cloud SQL us-central1 maps to BigQuery US, Cloud SQL europe-west1 maps to BigQuery EU. Examples: US, EU, asia-northeast1, us-central1, europe-west1. Spanner Connections same as spanner region AWS allowed regions are aws-us-east-1 Azure allowed regions are azure-eastus2</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The resource name of the connection in the form of: "projects/{project_id}/locations/{location_id}/connections/{connectionId}"</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Container for connection properties to execute stored procedures for Apache Spark. resources. Structure is documented below.</summary>
    [JsonPropertyName("spark")]
    public IList<V1beta1ConnectionStatusAtProviderSpark>? Spark { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatusConditions
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

/// <summary>ConnectionStatus defines the observed state of Connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ConnectionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Connection is the Schema for the Connections API. A connection allows BigQuery connections to external data sources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Connection : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ConnectionSpec>, IStatus<V1beta1ConnectionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Connection";
    public const string KubeGroup = "bigquery.gcp.upbound.io";
    public const string KubePluralName = "connections";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConnectionSpec defines the desired state of Connection</summary>
    [JsonPropertyName("spec")]
    public V1beta1ConnectionSpec Spec { get; set; }

    /// <summary>ConnectionStatus defines the observed state of Connection.</summary>
    [JsonPropertyName("status")]
    public V1beta1ConnectionStatus? Status { get; set; }
}

/// <summary>Connection is the Schema for the Connections API. A connection allows BigQuery connections to external data sources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Connection>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ConnectionList";
    public const string KubeGroup = "bigquery.gcp.upbound.io";
    public const string KubePluralName = "connections";
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
    public IList<V1beta1Connection> Items { get; set; }
}