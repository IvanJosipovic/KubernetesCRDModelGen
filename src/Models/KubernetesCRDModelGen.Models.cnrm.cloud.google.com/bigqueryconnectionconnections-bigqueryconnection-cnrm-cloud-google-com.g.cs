using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigqueryconnection.cnrm.cloud.google.com;
/// <summary>Authentication using Google owned service account to assume into customer's AWS IAM Role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionSpecAwsAccessRole
{
    /// <summary>The user’s AWS IAM Role that trusts the Google-owned AWS IAM user Connection.</summary>
    [JsonPropertyName("iamRoleID")]
    public string? IamRoleID { get; set; }
}

/// <summary>Amazon Web Services (AWS) properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionSpecAws
{
    /// <summary>Authentication using Google owned service account to assume into customer's AWS IAM Role.</summary>
    [JsonPropertyName("accessRole")]
    public V1alpha1BigQueryConnectionConnectionSpecAwsAccessRole? AccessRole { get; set; }
}

/// <summary>Azure properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionSpecAzure
{
    /// <summary>The id of customer's directory that host the data.</summary>
    [JsonPropertyName("customerTenantID")]
    public string CustomerTenantID { get; set; }

    /// <summary>The client ID of the user's Azure Active Directory Application used for a federated connection.</summary>
    [JsonPropertyName("federatedApplicationClientID")]
    public string? FederatedApplicationClientID { get; set; }
}

/// <summary>Use Cloud Resource properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionSpecCloudResource
{
}

/// <summary>Reference to a spanner database ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionSpecCloudSpannerDatabaseRef
{
    /// <summary>The Spanner Database selfLink, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SpannerDatabase` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `SpannerDatabase` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Cloud Spanner properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionSpecCloudSpanner
{
    /// <summary>Reference to a spanner database ID.</summary>
    [JsonPropertyName("databaseRef")]
    public V1alpha1BigQueryConnectionConnectionSpecCloudSpannerDatabaseRef DatabaseRef { get; set; }

    /// <summary>Optional. Cloud Spanner database role for fine-grained access control.  The Cloud Spanner admin should have provisioned the database role with  appropriate permissions, such as `SELECT` and `INSERT`. Other users should  only use roles provided by their Cloud Spanner admins.   For more details, see [About fine-grained access control]  (https://cloud.google.com/spanner/docs/fgac-about).   REQUIRES: The database role name must start with a letter, and can only  contain letters, numbers, and underscores.</summary>
    [JsonPropertyName("databaseRole")]
    public string? DatabaseRole { get; set; }

    /// <summary>Allows setting max parallelism per query when executing on Spanner  independent compute resources. If unspecified, default values of  parallelism are chosen that are dependent on the Cloud Spanner instance  configuration.   REQUIRES: `use_parallelism` must be set.  REQUIRES: Either `use_data_boost` or `use_serverless_analytics` must be  set.</summary>
    [JsonPropertyName("maxParallelism")]
    public int? MaxParallelism { get; set; }

    /// <summary>If set, the request will be executed via Spanner independent compute  resources.  REQUIRES: `use_parallelism` must be set.   NOTE: `use_serverless_analytics` will be deprecated. Prefer  `use_data_boost` over `use_serverless_analytics`.</summary>
    [JsonPropertyName("useDataBoost")]
    public bool? UseDataBoost { get; set; }

    /// <summary>If parallelism should be used when reading from Cloud Spanner</summary>
    [JsonPropertyName("useParallelism")]
    public bool? UseParallelism { get; set; }

    /// <summary>If the serverless analytics service should be used to read data from Cloud Spanner. Note: `use_parallelism` must be set when using serverless analytics.</summary>
    [JsonPropertyName("useServerlessAnalytics")]
    public bool? UseServerlessAnalytics { get; set; }
}

/// <summary>Cloud SQL credential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionSpecCloudSqlCredential
{
    /// <summary>The password for the credential.</summary>
    [JsonPropertyName("password")]
    public string? Password { get; set; }

    /// <summary>The username for the credential.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Reference to the Cloud SQL instance ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionSpecCloudSqlInstanceRef
{
    /// <summary>The SQLInstance selfLink, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SQLInstance` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `SQLInstance` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Cloud SQL properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionSpecCloudSql
{
    /// <summary>Cloud SQL credential.</summary>
    [JsonPropertyName("credential")]
    public V1alpha1BigQueryConnectionConnectionSpecCloudSqlCredential? Credential { get; set; }

    /// <summary>Database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Reference to the Cloud SQL instance ID.</summary>
    [JsonPropertyName("instanceRef")]
    public V1alpha1BigQueryConnectionConnectionSpecCloudSqlInstanceRef? InstanceRef { get; set; }

    /// <summary>Type of the Cloud SQL database.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionSpecProjectRef
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

/// <summary>Optional. Resource name of an existing Dataproc Metastore service.   Example:   * `projects/[project_id]/locations/[region]/services/[service_id]`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionSpecSparkMetastoreServiceMetastoreServiceRef
{
    /// <summary>The self-link of an existing Dataproc Metastore service , when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string External { get; set; }
}

/// <summary>Optional. Dataproc Metastore Service configuration for the connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionSpecSparkMetastoreService
{
    /// <summary>Optional. Resource name of an existing Dataproc Metastore service.   Example:   * `projects/[project_id]/locations/[region]/services/[service_id]`</summary>
    [JsonPropertyName("metastoreServiceRef")]
    public V1alpha1BigQueryConnectionConnectionSpecSparkMetastoreServiceMetastoreServiceRef? MetastoreServiceRef { get; set; }
}

/// <summary>Optional. Resource name of an existing Dataproc Cluster to act as a Spark  History Server for the connection.   Example:   * `projects/[project_id]/regions/[region]/clusters/[cluster_name]`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionSpecSparkSparkHistoryServerDataprocClusterRef
{
    /// <summary>The self-link of an existing Dataproc Cluster to act as a Spark History Server for the connection , when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a Dataproc Cluster.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a Dataproc Cluster.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Spark History Server configuration for the connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionSpecSparkSparkHistoryServer
{
    /// <summary>Optional. Resource name of an existing Dataproc Cluster to act as a Spark  History Server for the connection.   Example:   * `projects/[project_id]/regions/[region]/clusters/[cluster_name]`</summary>
    [JsonPropertyName("dataprocClusterRef")]
    public V1alpha1BigQueryConnectionConnectionSpecSparkSparkHistoryServerDataprocClusterRef? DataprocClusterRef { get; set; }
}

/// <summary>Spark properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionSpecSpark
{
    /// <summary>Optional. Dataproc Metastore Service configuration for the connection.</summary>
    [JsonPropertyName("metastoreService")]
    public V1alpha1BigQueryConnectionConnectionSpecSparkMetastoreService? MetastoreService { get; set; }

    /// <summary>Optional. Spark History Server configuration for the connection.</summary>
    [JsonPropertyName("sparkHistoryServer")]
    public V1alpha1BigQueryConnectionConnectionSpecSparkSparkHistoryServer? SparkHistoryServer { get; set; }
}

/// <summary>BigQueryConnectionConnectionSpec defines the desired state to connect BigQuery to external resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionSpec
{
    /// <summary>Amazon Web Services (AWS) properties.</summary>
    [JsonPropertyName("aws")]
    public V1alpha1BigQueryConnectionConnectionSpecAws? Aws { get; set; }

    /// <summary>Azure properties.</summary>
    [JsonPropertyName("azure")]
    public V1alpha1BigQueryConnectionConnectionSpecAzure? Azure { get; set; }

    /// <summary>Use Cloud Resource properties.</summary>
    [JsonPropertyName("cloudResource")]
    public V1alpha1BigQueryConnectionConnectionSpecCloudResource? CloudResource { get; set; }

    /// <summary>Cloud Spanner properties.</summary>
    [JsonPropertyName("cloudSpanner")]
    public V1alpha1BigQueryConnectionConnectionSpecCloudSpanner? CloudSpanner { get; set; }

    /// <summary>Cloud SQL properties.</summary>
    [JsonPropertyName("cloudSql")]
    public V1alpha1BigQueryConnectionConnectionSpecCloudSql? CloudSql { get; set; }

    /// <summary>User provided description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User provided display name for the connection.</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1BigQueryConnectionConnectionSpecProjectRef ProjectRef { get; set; }

    /// <summary>The BigQuery ConnectionID. This is a server-generated ID in the UUID format. If not provided, ConfigConnector will create a new Connection and store the UUID in `status.serviceGeneratedID` field.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Spark properties.</summary>
    [JsonPropertyName("spark")]
    public V1alpha1BigQueryConnectionConnectionSpecSpark? Spark { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionStatusConditions
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionStatusObservedStateAwsAccessRole
{
    /// <summary>A unique Google-owned and Google-generated identity for the Connection. This identity will be used to access the user's AWS IAM Role.</summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionStatusObservedStateAws
{
    /// <summary></summary>
    [JsonPropertyName("accessRole")]
    public V1alpha1BigQueryConnectionConnectionStatusObservedStateAwsAccessRole? AccessRole { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionStatusObservedStateAzure
{
    /// <summary>The name of the Azure Active Directory Application.</summary>
    [JsonPropertyName("application")]
    public string? Application { get; set; }

    /// <summary>The client id of the Azure Active Directory Application.</summary>
    [JsonPropertyName("clientID")]
    public string? ClientID { get; set; }

    /// <summary>A unique Google-owned and Google-generated identity for the Connection. This identity will be used to access the user's Azure Active Directory Application.</summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>The object id of the Azure Active Directory Application.</summary>
    [JsonPropertyName("objectID")]
    public string? ObjectID { get; set; }

    /// <summary>The URL user will be redirected to after granting consent during connection setup.</summary>
    [JsonPropertyName("redirectUri")]
    public string? RedirectUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionStatusObservedStateCloudResource
{
    /// <summary> The account ID of the service created for the purpose of this  connection.   The service account does not have any permissions associated with it  when it is created. After creation, customers delegate permissions  to the service account. When the connection is used in the context of an  operation in BigQuery, the service account will be used to connect to the  desired resources in GCP.   The account ID is in the form of:    &lt;service-1234&gt;@gcp-sa-bigquery-cloudresource.iam.gserviceaccount.com</summary>
    [JsonPropertyName("serviceAccountID")]
    public string? ServiceAccountID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionStatusObservedStateCloudSql
{
    /// <summary>The account ID of the service used for the purpose of this connection.   When the connection is used in the context of an operation in  BigQuery, this service account will serve as the identity being used for  connecting to the CloudSQL instance specified in this connection.</summary>
    [JsonPropertyName("serviceAccountID")]
    public string? ServiceAccountID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionStatusObservedStateSpark
{
    /// <summary> The account ID of the service created for the purpose of this  connection.   The service account does not have any permissions associated with it when  it is created. After creation, customers delegate permissions to the  service account. When the connection is used in the context of a stored  procedure for Apache Spark in BigQuery, the service account is used to  connect to the desired resources in Google Cloud.   The account ID is in the form of:  bqcx-&lt;projectnumber&gt;-&lt;uniqueid&gt;@gcp-sa-bigquery-consp.iam.gserviceaccount.com</summary>
    [JsonPropertyName("serviceAccountID")]
    public string? ServiceAccountID { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionStatusObservedState
{
    /// <summary></summary>
    [JsonPropertyName("aws")]
    public V1alpha1BigQueryConnectionConnectionStatusObservedStateAws? Aws { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azure")]
    public V1alpha1BigQueryConnectionConnectionStatusObservedStateAzure? Azure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloudResource")]
    public V1alpha1BigQueryConnectionConnectionStatusObservedStateCloudResource? CloudResource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloudSql")]
    public V1alpha1BigQueryConnectionConnectionStatusObservedStateCloudSql? CloudSql { get; set; }

    /// <summary>The description for the connection.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name for the connection.</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>Output only. True, if credential is configured for this connection.</summary>
    [JsonPropertyName("hasCredential")]
    public bool? HasCredential { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spark")]
    public V1alpha1BigQueryConnectionConnectionStatusObservedStateSpark? Spark { get; set; }
}

/// <summary>BigQueryConnectionConnectionStatus defines the config connector machine state of BigQueryConnectionConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryConnectionConnectionStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BigQueryConnectionConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BigQueryConnectionConnection resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BigQueryConnectionConnectionStatusObservedState? ObservedState { get; set; }
}

/// <summary>BigQueryConnectionConnection is the Schema for the BigQueryConnectionConnection API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigQueryConnectionConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BigQueryConnectionConnectionSpec>, IStatus<V1alpha1BigQueryConnectionConnectionStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigQueryConnectionConnection";
    public const string KubeGroup = "bigqueryconnection.cnrm.cloud.google.com";
    public const string KubePluralName = "bigqueryconnectionconnections";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BigQueryConnectionConnectionSpec defines the desired state to connect BigQuery to external resources</summary>
    [JsonPropertyName("spec")]
    public V1alpha1BigQueryConnectionConnectionSpec? Spec { get; set; }

    /// <summary>BigQueryConnectionConnectionStatus defines the config connector machine state of BigQueryConnectionConnection</summary>
    [JsonPropertyName("status")]
    public V1alpha1BigQueryConnectionConnectionStatus? Status { get; set; }
}