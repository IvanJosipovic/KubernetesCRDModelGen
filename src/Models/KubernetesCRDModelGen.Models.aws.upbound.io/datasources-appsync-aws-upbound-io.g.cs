using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appsync.aws.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderApiIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a GraphQLAPI in appsync to populate apiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderApiIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasourceSpecForProviderApiIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderApiIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a GraphQLAPI in appsync to populate apiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderApiIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasourceSpecForProviderApiIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderDynamodbConfigDeltaSyncConfig
{
    /// <summary>The number of minutes that an Item is stored in the data source.</summary>
    [JsonPropertyName("baseTableTtl")]
    public double? BaseTableTtl { get; set; }

    /// <summary>The table name.</summary>
    [JsonPropertyName("deltaSyncTableName")]
    public string? DeltaSyncTableName { get; set; }

    /// <summary>The number of minutes that a Delta Sync log entry is stored in the Delta Sync table.</summary>
    [JsonPropertyName("deltaSyncTableTtl")]
    public double? DeltaSyncTableTtl { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderDynamodbConfigTableNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Table in dynamodb to populate tableName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderDynamodbConfigTableNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasourceSpecForProviderDynamodbConfigTableNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderDynamodbConfigTableNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Table in dynamodb to populate tableName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderDynamodbConfigTableNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasourceSpecForProviderDynamodbConfigTableNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderDynamodbConfig
{
    /// <summary>The DeltaSyncConfig for a versioned data source. See delta_sync_config Block for details.</summary>
    [JsonPropertyName("deltaSyncConfig")]
    public IList<V1beta1DatasourceSpecForProviderDynamodbConfigDeltaSyncConfig>? DeltaSyncConfig { get; set; }

    /// <summary>AWS region of the DynamoDB table. Defaults to current region.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Reference to a Table in dynamodb to populate tableName.</summary>
    [JsonPropertyName("tableNameRef")]
    public V1beta1DatasourceSpecForProviderDynamodbConfigTableNameRef? TableNameRef { get; set; }

    /// <summary>Selector for a Table in dynamodb to populate tableName.</summary>
    [JsonPropertyName("tableNameSelector")]
    public V1beta1DatasourceSpecForProviderDynamodbConfigTableNameSelector? TableNameSelector { get; set; }

    /// <summary>Set to true to use Amazon Cognito credentials with this data source.</summary>
    [JsonPropertyName("useCallerCredentials")]
    public bool? UseCallerCredentials { get; set; }

    /// <summary>Detects Conflict Detection and Resolution with this data source.</summary>
    [JsonPropertyName("versioned")]
    public bool? Versioned { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderElasticsearchConfig
{
    /// <summary>HTTP endpoint of the Elasticsearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>AWS region of Elasticsearch domain. Defaults to current region.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderEventBridgeConfig
{
    /// <summary>ARN for the EventBridge bus.</summary>
    [JsonPropertyName("eventBusArn")]
    public string? EventBusArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderHttpConfigAuthorizationConfigAwsIamConfig
{
    /// <summary>Signing Amazon Web Services Region for IAM authorization.</summary>
    [JsonPropertyName("signingRegion")]
    public string? SigningRegion { get; set; }

    /// <summary>Signing service name for IAM authorization.</summary>
    [JsonPropertyName("signingServiceName")]
    public string? SigningServiceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderHttpConfigAuthorizationConfig
{
    /// <summary>Authorization type that the HTTP endpoint requires. Default values is AWS_IAM.</summary>
    [JsonPropertyName("authorizationType")]
    public string? AuthorizationType { get; set; }

    /// <summary>Identity and Access Management (IAM) settings. See aws_iam_config Block for details.</summary>
    [JsonPropertyName("awsIamConfig")]
    public IList<V1beta1DatasourceSpecForProviderHttpConfigAuthorizationConfigAwsIamConfig>? AwsIamConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderHttpConfig
{
    /// <summary>Authorization configuration in case the HTTP endpoint requires authorization. See authorization_config Block for details.</summary>
    [JsonPropertyName("authorizationConfig")]
    public IList<V1beta1DatasourceSpecForProviderHttpConfigAuthorizationConfig>? AuthorizationConfig { get; set; }

    /// <summary>HTTP URL.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderLambdaConfig
{
    /// <summary>ARN for the Lambda function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderOpensearchserviceConfig
{
    /// <summary>HTTP endpoint of the OpenSearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>AWS region of the OpenSearch domain. Defaults to current region.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderRelationalDatabaseConfigHttpEndpointConfig
{
    /// <summary>AWS secret store ARN for database credentials.</summary>
    [JsonPropertyName("awsSecretStoreArn")]
    public string? AwsSecretStoreArn { get; set; }

    /// <summary>Logical database name.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Amazon RDS cluster identifier.</summary>
    [JsonPropertyName("dbClusterIdentifier")]
    public string? DbClusterIdentifier { get; set; }

    /// <summary>AWS Region for RDS HTTP endpoint. Defaults to current region.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Logical schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderRelationalDatabaseConfig
{
    /// <summary>Amazon RDS HTTP endpoint configuration. See http_endpoint_config Block for details.</summary>
    [JsonPropertyName("httpEndpointConfig")]
    public IList<V1beta1DatasourceSpecForProviderRelationalDatabaseConfigHttpEndpointConfig>? HttpEndpointConfig { get; set; }

    /// <summary>Source type for the relational database. Valid values: RDS_HTTP_ENDPOINT.</summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderServiceRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderServiceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasourceSpecForProviderServiceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderServiceRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderServiceRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasourceSpecForProviderServiceRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProvider
{
    /// <summary>API ID for the GraphQL API for the data source.</summary>
    [JsonPropertyName("apiId")]
    public string? ApiId { get; set; }

    /// <summary>Reference to a GraphQLAPI in appsync to populate apiId.</summary>
    [JsonPropertyName("apiIdRef")]
    public V1beta1DatasourceSpecForProviderApiIdRef? ApiIdRef { get; set; }

    /// <summary>Selector for a GraphQLAPI in appsync to populate apiId.</summary>
    [JsonPropertyName("apiIdSelector")]
    public V1beta1DatasourceSpecForProviderApiIdSelector? ApiIdSelector { get; set; }

    /// <summary>Description of the data source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DynamoDB settings. See dynamodb_config Block for details.</summary>
    [JsonPropertyName("dynamodbConfig")]
    public IList<V1beta1DatasourceSpecForProviderDynamodbConfig>? DynamodbConfig { get; set; }

    /// <summary>Amazon Elasticsearch settings. See elasticsearch_config Block for details.</summary>
    [JsonPropertyName("elasticsearchConfig")]
    public IList<V1beta1DatasourceSpecForProviderElasticsearchConfig>? ElasticsearchConfig { get; set; }

    /// <summary>AWS EventBridge settings. See event_bridge_config Block for details.</summary>
    [JsonPropertyName("eventBridgeConfig")]
    public IList<V1beta1DatasourceSpecForProviderEventBridgeConfig>? EventBridgeConfig { get; set; }

    /// <summary>HTTP settings. See http_config Block for details.</summary>
    [JsonPropertyName("httpConfig")]
    public IList<V1beta1DatasourceSpecForProviderHttpConfig>? HttpConfig { get; set; }

    /// <summary>AWS Lambda settings. See lambda_config Block for details.</summary>
    [JsonPropertyName("lambdaConfig")]
    public IList<V1beta1DatasourceSpecForProviderLambdaConfig>? LambdaConfig { get; set; }

    /// <summary>Amazon OpenSearch Service settings. See opensearchservice_config Block for details.</summary>
    [JsonPropertyName("opensearchserviceConfig")]
    public IList<V1beta1DatasourceSpecForProviderOpensearchserviceConfig>? OpensearchserviceConfig { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>AWS RDS settings. See relational_database_config Block for details.</summary>
    [JsonPropertyName("relationalDatabaseConfig")]
    public IList<V1beta1DatasourceSpecForProviderRelationalDatabaseConfig>? RelationalDatabaseConfig { get; set; }

    /// <summary>IAM service role ARN for the data source. Required if type is specified as AWS_LAMBDA, AMAZON_DYNAMODB, AMAZON_ELASTICSEARCH, AMAZON_EVENTBRIDGE, or AMAZON_OPENSEARCH_SERVICE.</summary>
    [JsonPropertyName("serviceRoleArn")]
    public string? ServiceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnRef")]
    public V1beta1DatasourceSpecForProviderServiceRoleArnRef? ServiceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnSelector")]
    public V1beta1DatasourceSpecForProviderServiceRoleArnSelector? ServiceRoleArnSelector { get; set; }

    /// <summary>Type of the Data Source. Valid values: AWS_LAMBDA, AMAZON_DYNAMODB, AMAZON_ELASTICSEARCH, HTTP, NONE, RELATIONAL_DATABASE, AMAZON_EVENTBRIDGE, AMAZON_OPENSEARCH_SERVICE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderDynamodbConfigDeltaSyncConfig
{
    /// <summary>The number of minutes that an Item is stored in the data source.</summary>
    [JsonPropertyName("baseTableTtl")]
    public double? BaseTableTtl { get; set; }

    /// <summary>The table name.</summary>
    [JsonPropertyName("deltaSyncTableName")]
    public string? DeltaSyncTableName { get; set; }

    /// <summary>The number of minutes that a Delta Sync log entry is stored in the Delta Sync table.</summary>
    [JsonPropertyName("deltaSyncTableTtl")]
    public double? DeltaSyncTableTtl { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Table in dynamodb to populate tableName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Table in dynamodb to populate tableName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderDynamodbConfig
{
    /// <summary>The DeltaSyncConfig for a versioned data source. See delta_sync_config Block for details.</summary>
    [JsonPropertyName("deltaSyncConfig")]
    public IList<V1beta1DatasourceSpecInitProviderDynamodbConfigDeltaSyncConfig>? DeltaSyncConfig { get; set; }

    /// <summary>Name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Reference to a Table in dynamodb to populate tableName.</summary>
    [JsonPropertyName("tableNameRef")]
    public V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameRef? TableNameRef { get; set; }

    /// <summary>Selector for a Table in dynamodb to populate tableName.</summary>
    [JsonPropertyName("tableNameSelector")]
    public V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameSelector? TableNameSelector { get; set; }

    /// <summary>Set to true to use Amazon Cognito credentials with this data source.</summary>
    [JsonPropertyName("useCallerCredentials")]
    public bool? UseCallerCredentials { get; set; }

    /// <summary>Detects Conflict Detection and Resolution with this data source.</summary>
    [JsonPropertyName("versioned")]
    public bool? Versioned { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderElasticsearchConfig
{
    /// <summary>HTTP endpoint of the Elasticsearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderEventBridgeConfig
{
    /// <summary>ARN for the EventBridge bus.</summary>
    [JsonPropertyName("eventBusArn")]
    public string? EventBusArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderHttpConfigAuthorizationConfigAwsIamConfig
{
    /// <summary>Signing Amazon Web Services Region for IAM authorization.</summary>
    [JsonPropertyName("signingRegion")]
    public string? SigningRegion { get; set; }

    /// <summary>Signing service name for IAM authorization.</summary>
    [JsonPropertyName("signingServiceName")]
    public string? SigningServiceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderHttpConfigAuthorizationConfig
{
    /// <summary>Authorization type that the HTTP endpoint requires. Default values is AWS_IAM.</summary>
    [JsonPropertyName("authorizationType")]
    public string? AuthorizationType { get; set; }

    /// <summary>Identity and Access Management (IAM) settings. See aws_iam_config Block for details.</summary>
    [JsonPropertyName("awsIamConfig")]
    public IList<V1beta1DatasourceSpecInitProviderHttpConfigAuthorizationConfigAwsIamConfig>? AwsIamConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderHttpConfig
{
    /// <summary>Authorization configuration in case the HTTP endpoint requires authorization. See authorization_config Block for details.</summary>
    [JsonPropertyName("authorizationConfig")]
    public IList<V1beta1DatasourceSpecInitProviderHttpConfigAuthorizationConfig>? AuthorizationConfig { get; set; }

    /// <summary>HTTP URL.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderLambdaConfig
{
    /// <summary>ARN for the Lambda function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderOpensearchserviceConfig
{
    /// <summary>HTTP endpoint of the OpenSearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderRelationalDatabaseConfigHttpEndpointConfig
{
    /// <summary>AWS secret store ARN for database credentials.</summary>
    [JsonPropertyName("awsSecretStoreArn")]
    public string? AwsSecretStoreArn { get; set; }

    /// <summary>Logical database name.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Amazon RDS cluster identifier.</summary>
    [JsonPropertyName("dbClusterIdentifier")]
    public string? DbClusterIdentifier { get; set; }

    /// <summary>Logical schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderRelationalDatabaseConfig
{
    /// <summary>Amazon RDS HTTP endpoint configuration. See http_endpoint_config Block for details.</summary>
    [JsonPropertyName("httpEndpointConfig")]
    public IList<V1beta1DatasourceSpecInitProviderRelationalDatabaseConfigHttpEndpointConfig>? HttpEndpointConfig { get; set; }

    /// <summary>Source type for the relational database. Valid values: RDS_HTTP_ENDPOINT.</summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderServiceRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderServiceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasourceSpecInitProviderServiceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderServiceRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderServiceRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasourceSpecInitProviderServiceRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProvider
{
    /// <summary>Description of the data source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DynamoDB settings. See dynamodb_config Block for details.</summary>
    [JsonPropertyName("dynamodbConfig")]
    public IList<V1beta1DatasourceSpecInitProviderDynamodbConfig>? DynamodbConfig { get; set; }

    /// <summary>Amazon Elasticsearch settings. See elasticsearch_config Block for details.</summary>
    [JsonPropertyName("elasticsearchConfig")]
    public IList<V1beta1DatasourceSpecInitProviderElasticsearchConfig>? ElasticsearchConfig { get; set; }

    /// <summary>AWS EventBridge settings. See event_bridge_config Block for details.</summary>
    [JsonPropertyName("eventBridgeConfig")]
    public IList<V1beta1DatasourceSpecInitProviderEventBridgeConfig>? EventBridgeConfig { get; set; }

    /// <summary>HTTP settings. See http_config Block for details.</summary>
    [JsonPropertyName("httpConfig")]
    public IList<V1beta1DatasourceSpecInitProviderHttpConfig>? HttpConfig { get; set; }

    /// <summary>AWS Lambda settings. See lambda_config Block for details.</summary>
    [JsonPropertyName("lambdaConfig")]
    public IList<V1beta1DatasourceSpecInitProviderLambdaConfig>? LambdaConfig { get; set; }

    /// <summary>Amazon OpenSearch Service settings. See opensearchservice_config Block for details.</summary>
    [JsonPropertyName("opensearchserviceConfig")]
    public IList<V1beta1DatasourceSpecInitProviderOpensearchserviceConfig>? OpensearchserviceConfig { get; set; }

    /// <summary>AWS RDS settings. See relational_database_config Block for details.</summary>
    [JsonPropertyName("relationalDatabaseConfig")]
    public IList<V1beta1DatasourceSpecInitProviderRelationalDatabaseConfig>? RelationalDatabaseConfig { get; set; }

    /// <summary>IAM service role ARN for the data source. Required if type is specified as AWS_LAMBDA, AMAZON_DYNAMODB, AMAZON_ELASTICSEARCH, AMAZON_EVENTBRIDGE, or AMAZON_OPENSEARCH_SERVICE.</summary>
    [JsonPropertyName("serviceRoleArn")]
    public string? ServiceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnRef")]
    public V1beta1DatasourceSpecInitProviderServiceRoleArnRef? ServiceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnSelector")]
    public V1beta1DatasourceSpecInitProviderServiceRoleArnSelector? ServiceRoleArnSelector { get; set; }

    /// <summary>Type of the Data Source. Valid values: AWS_LAMBDA, AMAZON_DYNAMODB, AMAZON_ELASTICSEARCH, HTTP, NONE, RELATIONAL_DATABASE, AMAZON_EVENTBRIDGE, AMAZON_OPENSEARCH_SERVICE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecProviderConfigRefPolicy
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
public partial class V1beta1DatasourceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasourceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>DatasourceSpec defines the desired state of Datasource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DatasourceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DatasourceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DatasourceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DatasourceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceStatusAtProviderDynamodbConfigDeltaSyncConfig
{
    /// <summary>The number of minutes that an Item is stored in the data source.</summary>
    [JsonPropertyName("baseTableTtl")]
    public double? BaseTableTtl { get; set; }

    /// <summary>The table name.</summary>
    [JsonPropertyName("deltaSyncTableName")]
    public string? DeltaSyncTableName { get; set; }

    /// <summary>The number of minutes that a Delta Sync log entry is stored in the Delta Sync table.</summary>
    [JsonPropertyName("deltaSyncTableTtl")]
    public double? DeltaSyncTableTtl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceStatusAtProviderDynamodbConfig
{
    /// <summary>The DeltaSyncConfig for a versioned data source. See delta_sync_config Block for details.</summary>
    [JsonPropertyName("deltaSyncConfig")]
    public IList<V1beta1DatasourceStatusAtProviderDynamodbConfigDeltaSyncConfig>? DeltaSyncConfig { get; set; }

    /// <summary>AWS region of the DynamoDB table. Defaults to current region.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Set to true to use Amazon Cognito credentials with this data source.</summary>
    [JsonPropertyName("useCallerCredentials")]
    public bool? UseCallerCredentials { get; set; }

    /// <summary>Detects Conflict Detection and Resolution with this data source.</summary>
    [JsonPropertyName("versioned")]
    public bool? Versioned { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceStatusAtProviderElasticsearchConfig
{
    /// <summary>HTTP endpoint of the Elasticsearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>AWS region of Elasticsearch domain. Defaults to current region.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceStatusAtProviderEventBridgeConfig
{
    /// <summary>ARN for the EventBridge bus.</summary>
    [JsonPropertyName("eventBusArn")]
    public string? EventBusArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceStatusAtProviderHttpConfigAuthorizationConfigAwsIamConfig
{
    /// <summary>Signing Amazon Web Services Region for IAM authorization.</summary>
    [JsonPropertyName("signingRegion")]
    public string? SigningRegion { get; set; }

    /// <summary>Signing service name for IAM authorization.</summary>
    [JsonPropertyName("signingServiceName")]
    public string? SigningServiceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceStatusAtProviderHttpConfigAuthorizationConfig
{
    /// <summary>Authorization type that the HTTP endpoint requires. Default values is AWS_IAM.</summary>
    [JsonPropertyName("authorizationType")]
    public string? AuthorizationType { get; set; }

    /// <summary>Identity and Access Management (IAM) settings. See aws_iam_config Block for details.</summary>
    [JsonPropertyName("awsIamConfig")]
    public IList<V1beta1DatasourceStatusAtProviderHttpConfigAuthorizationConfigAwsIamConfig>? AwsIamConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceStatusAtProviderHttpConfig
{
    /// <summary>Authorization configuration in case the HTTP endpoint requires authorization. See authorization_config Block for details.</summary>
    [JsonPropertyName("authorizationConfig")]
    public IList<V1beta1DatasourceStatusAtProviderHttpConfigAuthorizationConfig>? AuthorizationConfig { get; set; }

    /// <summary>HTTP URL.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceStatusAtProviderLambdaConfig
{
    /// <summary>ARN for the Lambda function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceStatusAtProviderOpensearchserviceConfig
{
    /// <summary>HTTP endpoint of the OpenSearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>AWS region of the OpenSearch domain. Defaults to current region.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceStatusAtProviderRelationalDatabaseConfigHttpEndpointConfig
{
    /// <summary>AWS secret store ARN for database credentials.</summary>
    [JsonPropertyName("awsSecretStoreArn")]
    public string? AwsSecretStoreArn { get; set; }

    /// <summary>Logical database name.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Amazon RDS cluster identifier.</summary>
    [JsonPropertyName("dbClusterIdentifier")]
    public string? DbClusterIdentifier { get; set; }

    /// <summary>AWS Region for RDS HTTP endpoint. Defaults to current region.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Logical schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceStatusAtProviderRelationalDatabaseConfig
{
    /// <summary>Amazon RDS HTTP endpoint configuration. See http_endpoint_config Block for details.</summary>
    [JsonPropertyName("httpEndpointConfig")]
    public IList<V1beta1DatasourceStatusAtProviderRelationalDatabaseConfigHttpEndpointConfig>? HttpEndpointConfig { get; set; }

    /// <summary>Source type for the relational database. Valid values: RDS_HTTP_ENDPOINT.</summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceStatusAtProvider
{
    /// <summary>API ID for the GraphQL API for the data source.</summary>
    [JsonPropertyName("apiId")]
    public string? ApiId { get; set; }

    /// <summary>ARN</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Description of the data source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DynamoDB settings. See dynamodb_config Block for details.</summary>
    [JsonPropertyName("dynamodbConfig")]
    public IList<V1beta1DatasourceStatusAtProviderDynamodbConfig>? DynamodbConfig { get; set; }

    /// <summary>Amazon Elasticsearch settings. See elasticsearch_config Block for details.</summary>
    [JsonPropertyName("elasticsearchConfig")]
    public IList<V1beta1DatasourceStatusAtProviderElasticsearchConfig>? ElasticsearchConfig { get; set; }

    /// <summary>AWS EventBridge settings. See event_bridge_config Block for details.</summary>
    [JsonPropertyName("eventBridgeConfig")]
    public IList<V1beta1DatasourceStatusAtProviderEventBridgeConfig>? EventBridgeConfig { get; set; }

    /// <summary>HTTP settings. See http_config Block for details.</summary>
    [JsonPropertyName("httpConfig")]
    public IList<V1beta1DatasourceStatusAtProviderHttpConfig>? HttpConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>AWS Lambda settings. See lambda_config Block for details.</summary>
    [JsonPropertyName("lambdaConfig")]
    public IList<V1beta1DatasourceStatusAtProviderLambdaConfig>? LambdaConfig { get; set; }

    /// <summary>Amazon OpenSearch Service settings. See opensearchservice_config Block for details.</summary>
    [JsonPropertyName("opensearchserviceConfig")]
    public IList<V1beta1DatasourceStatusAtProviderOpensearchserviceConfig>? OpensearchserviceConfig { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>AWS RDS settings. See relational_database_config Block for details.</summary>
    [JsonPropertyName("relationalDatabaseConfig")]
    public IList<V1beta1DatasourceStatusAtProviderRelationalDatabaseConfig>? RelationalDatabaseConfig { get; set; }

    /// <summary>IAM service role ARN for the data source. Required if type is specified as AWS_LAMBDA, AMAZON_DYNAMODB, AMAZON_ELASTICSEARCH, AMAZON_EVENTBRIDGE, or AMAZON_OPENSEARCH_SERVICE.</summary>
    [JsonPropertyName("serviceRoleArn")]
    public string? ServiceRoleArn { get; set; }

    /// <summary>Type of the Data Source. Valid values: AWS_LAMBDA, AMAZON_DYNAMODB, AMAZON_ELASTICSEARCH, HTTP, NONE, RELATIONAL_DATABASE, AMAZON_EVENTBRIDGE, AMAZON_OPENSEARCH_SERVICE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceStatusConditions
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

/// <summary>DatasourceStatus defines the observed state of Datasource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DatasourceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DatasourceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Datasource is the Schema for the Datasources API. Provides an AppSync Data Source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Datasource : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DatasourceSpec>, IStatus<V1beta1DatasourceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Datasource";
    public const string KubeGroup = "appsync.aws.upbound.io";
    public const string KubePluralName = "datasources";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DatasourceSpec defines the desired state of Datasource</summary>
    [JsonPropertyName("spec")]
    public V1beta1DatasourceSpec Spec { get; set; }

    /// <summary>DatasourceStatus defines the observed state of Datasource.</summary>
    [JsonPropertyName("status")]
    public V1beta1DatasourceStatus? Status { get; set; }
}

/// <summary>Datasource is the Schema for the Datasources API. Provides an AppSync Data Source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DatasourceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Datasource>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DatasourceList";
    public const string KubeGroup = "appsync.aws.upbound.io";
    public const string KubePluralName = "datasources";
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
    public IList<V1beta1Datasource> Items { get; set; }
}