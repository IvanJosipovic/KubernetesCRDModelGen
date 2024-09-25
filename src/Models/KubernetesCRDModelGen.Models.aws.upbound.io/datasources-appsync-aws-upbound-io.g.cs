using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appsync.aws.upbound.io;
/// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecForProviderApiIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecForProviderApiIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderApiIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecForProviderApiIdRefPolicyResolutionEnum>))]
    public V1beta1DatasourceSpecForProviderApiIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecForProviderApiIdRefPolicyResolveEnum>))]
    public V1beta1DatasourceSpecForProviderApiIdRefPolicyResolveEnum? Resolve { get; set; }
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecForProviderApiIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecForProviderApiIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderApiIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecForProviderApiIdSelectorPolicyResolutionEnum>))]
    public V1beta1DatasourceSpecForProviderApiIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecForProviderApiIdSelectorPolicyResolveEnum>))]
    public V1beta1DatasourceSpecForProviderApiIdSelectorPolicyResolveEnum? Resolve { get; set; }
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecForProviderDynamodbConfigTableNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecForProviderDynamodbConfigTableNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderDynamodbConfigTableNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecForProviderDynamodbConfigTableNameRefPolicyResolutionEnum>))]
    public V1beta1DatasourceSpecForProviderDynamodbConfigTableNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecForProviderDynamodbConfigTableNameRefPolicyResolveEnum>))]
    public V1beta1DatasourceSpecForProviderDynamodbConfigTableNameRefPolicyResolveEnum? Resolve { get; set; }
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecForProviderDynamodbConfigTableNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecForProviderDynamodbConfigTableNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderDynamodbConfigTableNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecForProviderDynamodbConfigTableNameSelectorPolicyResolutionEnum>))]
    public V1beta1DatasourceSpecForProviderDynamodbConfigTableNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecForProviderDynamodbConfigTableNameSelectorPolicyResolveEnum>))]
    public V1beta1DatasourceSpecForProviderDynamodbConfigTableNameSelectorPolicyResolveEnum? Resolve { get; set; }
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
    /// <summary>The DeltaSyncConfig for a versioned data source. See Delta Sync Config</summary>
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

    /// <summary>AWS region of the DynamoDB table. Defaults to current region.</summary>
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

    /// <summary>Identity and Access Management (IAM) settings. See AWS IAM Config.</summary>
    [JsonPropertyName("awsIamConfig")]
    public IList<V1beta1DatasourceSpecForProviderHttpConfigAuthorizationConfigAwsIamConfig>? AwsIamConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderHttpConfig
{
    /// <summary>Authorization configuration in case the HTTP endpoint requires authorization. See Authorization Config.</summary>
    [JsonPropertyName("authorizationConfig")]
    public IList<V1beta1DatasourceSpecForProviderHttpConfigAuthorizationConfig>? AuthorizationConfig { get; set; }

    /// <summary>HTTP endpoint of the Elasticsearch domain.</summary>
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
    /// <summary>HTTP endpoint of the Elasticsearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>AWS region of the DynamoDB table. Defaults to current region.</summary>
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

    /// <summary>AWS region of the DynamoDB table. Defaults to current region.</summary>
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
    /// <summary>Amazon RDS HTTP endpoint configuration. See HTTP Endpoint Config.</summary>
    [JsonPropertyName("httpEndpointConfig")]
    public IList<V1beta1DatasourceSpecForProviderRelationalDatabaseConfigHttpEndpointConfig>? HttpEndpointConfig { get; set; }

    /// <summary>Source type for the relational database. Valid values: RDS_HTTP_ENDPOINT.</summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecForProviderServiceRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecForProviderServiceRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderServiceRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecForProviderServiceRoleArnRefPolicyResolutionEnum>))]
    public V1beta1DatasourceSpecForProviderServiceRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecForProviderServiceRoleArnRefPolicyResolveEnum>))]
    public V1beta1DatasourceSpecForProviderServiceRoleArnRefPolicyResolveEnum? Resolve { get; set; }
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecForProviderServiceRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecForProviderServiceRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecForProviderServiceRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecForProviderServiceRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1DatasourceSpecForProviderServiceRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecForProviderServiceRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1DatasourceSpecForProviderServiceRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
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

    /// <summary>DynamoDB settings. See DynamoDB Config</summary>
    [JsonPropertyName("dynamodbConfig")]
    public IList<V1beta1DatasourceSpecForProviderDynamodbConfig>? DynamodbConfig { get; set; }

    /// <summary>Amazon Elasticsearch settings. See ElasticSearch Config</summary>
    [JsonPropertyName("elasticsearchConfig")]
    public IList<V1beta1DatasourceSpecForProviderElasticsearchConfig>? ElasticsearchConfig { get; set; }

    /// <summary>AWS EventBridge settings. See Event Bridge Config</summary>
    [JsonPropertyName("eventBridgeConfig")]
    public IList<V1beta1DatasourceSpecForProviderEventBridgeConfig>? EventBridgeConfig { get; set; }

    /// <summary>HTTP settings. See HTTP Config</summary>
    [JsonPropertyName("httpConfig")]
    public IList<V1beta1DatasourceSpecForProviderHttpConfig>? HttpConfig { get; set; }

    /// <summary>AWS Lambda settings. See Lambda Config</summary>
    [JsonPropertyName("lambdaConfig")]
    public IList<V1beta1DatasourceSpecForProviderLambdaConfig>? LambdaConfig { get; set; }

    /// <summary>Amazon OpenSearch Service settings. See OpenSearch Service Config</summary>
    [JsonPropertyName("opensearchserviceConfig")]
    public IList<V1beta1DatasourceSpecForProviderOpensearchserviceConfig>? OpensearchserviceConfig { get; set; }

    /// <summary>AWS region of the DynamoDB table. Defaults to current region. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>AWS RDS settings. See Relational Database Config</summary>
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameRefPolicyResolutionEnum>))]
    public V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameRefPolicyResolveEnum>))]
    public V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameRefPolicyResolveEnum? Resolve { get; set; }
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameSelectorPolicyResolutionEnum>))]
    public V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameSelectorPolicyResolveEnum>))]
    public V1beta1DatasourceSpecInitProviderDynamodbConfigTableNameSelectorPolicyResolveEnum? Resolve { get; set; }
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
    /// <summary>The DeltaSyncConfig for a versioned data source. See Delta Sync Config</summary>
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

    /// <summary>Identity and Access Management (IAM) settings. See AWS IAM Config.</summary>
    [JsonPropertyName("awsIamConfig")]
    public IList<V1beta1DatasourceSpecInitProviderHttpConfigAuthorizationConfigAwsIamConfig>? AwsIamConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderHttpConfig
{
    /// <summary>Authorization configuration in case the HTTP endpoint requires authorization. See Authorization Config.</summary>
    [JsonPropertyName("authorizationConfig")]
    public IList<V1beta1DatasourceSpecInitProviderHttpConfigAuthorizationConfig>? AuthorizationConfig { get; set; }

    /// <summary>HTTP endpoint of the Elasticsearch domain.</summary>
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
    /// <summary>HTTP endpoint of the Elasticsearch domain.</summary>
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
    /// <summary>Amazon RDS HTTP endpoint configuration. See HTTP Endpoint Config.</summary>
    [JsonPropertyName("httpEndpointConfig")]
    public IList<V1beta1DatasourceSpecInitProviderRelationalDatabaseConfigHttpEndpointConfig>? HttpEndpointConfig { get; set; }

    /// <summary>Source type for the relational database. Valid values: RDS_HTTP_ENDPOINT.</summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecInitProviderServiceRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecInitProviderServiceRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderServiceRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecInitProviderServiceRoleArnRefPolicyResolutionEnum>))]
    public V1beta1DatasourceSpecInitProviderServiceRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecInitProviderServiceRoleArnRefPolicyResolveEnum>))]
    public V1beta1DatasourceSpecInitProviderServiceRoleArnRefPolicyResolveEnum? Resolve { get; set; }
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecInitProviderServiceRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecInitProviderServiceRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecInitProviderServiceRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecInitProviderServiceRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1DatasourceSpecInitProviderServiceRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecInitProviderServiceRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1DatasourceSpecInitProviderServiceRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
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

    /// <summary>DynamoDB settings. See DynamoDB Config</summary>
    [JsonPropertyName("dynamodbConfig")]
    public IList<V1beta1DatasourceSpecInitProviderDynamodbConfig>? DynamodbConfig { get; set; }

    /// <summary>Amazon Elasticsearch settings. See ElasticSearch Config</summary>
    [JsonPropertyName("elasticsearchConfig")]
    public IList<V1beta1DatasourceSpecInitProviderElasticsearchConfig>? ElasticsearchConfig { get; set; }

    /// <summary>AWS EventBridge settings. See Event Bridge Config</summary>
    [JsonPropertyName("eventBridgeConfig")]
    public IList<V1beta1DatasourceSpecInitProviderEventBridgeConfig>? EventBridgeConfig { get; set; }

    /// <summary>HTTP settings. See HTTP Config</summary>
    [JsonPropertyName("httpConfig")]
    public IList<V1beta1DatasourceSpecInitProviderHttpConfig>? HttpConfig { get; set; }

    /// <summary>AWS Lambda settings. See Lambda Config</summary>
    [JsonPropertyName("lambdaConfig")]
    public IList<V1beta1DatasourceSpecInitProviderLambdaConfig>? LambdaConfig { get; set; }

    /// <summary>Amazon OpenSearch Service settings. See OpenSearch Service Config</summary>
    [JsonPropertyName("opensearchserviceConfig")]
    public IList<V1beta1DatasourceSpecInitProviderOpensearchserviceConfig>? OpensearchserviceConfig { get; set; }

    /// <summary>AWS RDS settings. See Relational Database Config</summary>
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

/// <summary>A ManagementAction represents an action that the Crossplane controllers can take on an external resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecManagementPoliciesEnum
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1DatasourceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1DatasourceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DatasourceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1DatasourceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1DatasourceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatasourceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1DatasourceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1DatasourceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1DatasourceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
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
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatasourceSpecDeletionPolicyEnum>))]
    public V1beta1DatasourceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DatasourceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DatasourceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DatasourceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DatasourceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1DatasourceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
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
    /// <summary>The DeltaSyncConfig for a versioned data source. See Delta Sync Config</summary>
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

    /// <summary>AWS region of the DynamoDB table. Defaults to current region.</summary>
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

    /// <summary>Identity and Access Management (IAM) settings. See AWS IAM Config.</summary>
    [JsonPropertyName("awsIamConfig")]
    public IList<V1beta1DatasourceStatusAtProviderHttpConfigAuthorizationConfigAwsIamConfig>? AwsIamConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatasourceStatusAtProviderHttpConfig
{
    /// <summary>Authorization configuration in case the HTTP endpoint requires authorization. See Authorization Config.</summary>
    [JsonPropertyName("authorizationConfig")]
    public IList<V1beta1DatasourceStatusAtProviderHttpConfigAuthorizationConfig>? AuthorizationConfig { get; set; }

    /// <summary>HTTP endpoint of the Elasticsearch domain.</summary>
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
    /// <summary>HTTP endpoint of the Elasticsearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>AWS region of the DynamoDB table. Defaults to current region.</summary>
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

    /// <summary>AWS region of the DynamoDB table. Defaults to current region.</summary>
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
    /// <summary>Amazon RDS HTTP endpoint configuration. See HTTP Endpoint Config.</summary>
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

    /// <summary>DynamoDB settings. See DynamoDB Config</summary>
    [JsonPropertyName("dynamodbConfig")]
    public IList<V1beta1DatasourceStatusAtProviderDynamodbConfig>? DynamodbConfig { get; set; }

    /// <summary>Amazon Elasticsearch settings. See ElasticSearch Config</summary>
    [JsonPropertyName("elasticsearchConfig")]
    public IList<V1beta1DatasourceStatusAtProviderElasticsearchConfig>? ElasticsearchConfig { get; set; }

    /// <summary>AWS EventBridge settings. See Event Bridge Config</summary>
    [JsonPropertyName("eventBridgeConfig")]
    public IList<V1beta1DatasourceStatusAtProviderEventBridgeConfig>? EventBridgeConfig { get; set; }

    /// <summary>HTTP settings. See HTTP Config</summary>
    [JsonPropertyName("httpConfig")]
    public IList<V1beta1DatasourceStatusAtProviderHttpConfig>? HttpConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>AWS Lambda settings. See Lambda Config</summary>
    [JsonPropertyName("lambdaConfig")]
    public IList<V1beta1DatasourceStatusAtProviderLambdaConfig>? LambdaConfig { get; set; }

    /// <summary>Amazon OpenSearch Service settings. See OpenSearch Service Config</summary>
    [JsonPropertyName("opensearchserviceConfig")]
    public IList<V1beta1DatasourceStatusAtProviderOpensearchserviceConfig>? OpensearchserviceConfig { get; set; }

    /// <summary>AWS RDS settings. See Relational Database Config</summary>
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