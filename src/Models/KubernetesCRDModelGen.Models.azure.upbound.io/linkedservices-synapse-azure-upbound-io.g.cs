using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.synapse.azure.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSpecForProviderIntegrationRuntimeNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a IntegrationRuntimeAzure in synapse to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSpecForProviderIntegrationRuntimeNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceSpecForProviderIntegrationRuntimeNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSpecForProviderIntegrationRuntimeNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a IntegrationRuntimeAzure in synapse to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSpecForProviderIntegrationRuntimeNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceSpecForProviderIntegrationRuntimeNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSpecForProviderIntegrationRuntime
{
    /// <summary>The integration runtime reference to associate with the Synapse Linked Service.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a IntegrationRuntimeAzure in synapse to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1LinkedServiceSpecForProviderIntegrationRuntimeNameRef? NameRef { get; set; }

    /// <summary>Selector for a IntegrationRuntimeAzure in synapse to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1LinkedServiceSpecForProviderIntegrationRuntimeNameSelector? NameSelector { get; set; }

    /// <summary>A map of parameters to associate with the integration runtime.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSpecForProviderSynapseWorkspaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Workspace in synapse to populate synapseWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSpecForProviderSynapseWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceSpecForProviderSynapseWorkspaceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSpecForProviderSynapseWorkspaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Workspace in synapse to populate synapseWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSpecForProviderSynapseWorkspaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceSpecForProviderSynapseWorkspaceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSpecForProvider
{
    /// <summary>A map of additional properties to associate with the Synapse Linked Service.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Synapse Linked Service.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The description for the Synapse Linked Service.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A integration_runtime block as defined below.</summary>
    [JsonPropertyName("integrationRuntime")]
    public IList<V1beta1LinkedServiceSpecForProviderIntegrationRuntime>? IntegrationRuntime { get; set; }

    /// <summary>A map of parameters to associate with the Synapse Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>The Synapse Workspace ID in which to associate the Linked Service with. Changing this forces a new Synapse Linked Service to be created.</summary>
    [JsonPropertyName("synapseWorkspaceId")]
    public string? SynapseWorkspaceId { get; set; }

    /// <summary>Reference to a Workspace in synapse to populate synapseWorkspaceId.</summary>
    [JsonPropertyName("synapseWorkspaceIdRef")]
    public V1beta1LinkedServiceSpecForProviderSynapseWorkspaceIdRef? SynapseWorkspaceIdRef { get; set; }

    /// <summary>Selector for a Workspace in synapse to populate synapseWorkspaceId.</summary>
    [JsonPropertyName("synapseWorkspaceIdSelector")]
    public V1beta1LinkedServiceSpecForProviderSynapseWorkspaceIdSelector? SynapseWorkspaceIdSelector { get; set; }

    /// <summary>The type of data stores that will be connected to Synapse. Valid Values include AmazonMWS, AmazonRdsForOracle, AmazonRdsForSqlServer, AmazonRedshift, AmazonS3, AzureBatch. Changing this forces a new resource to be created. AzureBlobFS, AzureBlobStorage, AzureDataExplorer, AzureDataLakeAnalytics, AzureDataLakeStore, AzureDatabricks, AzureDatabricksDeltaLake, AzureFileStorage, AzureFunction, AzureKeyVault, AzureML, AzureMLService, AzureMariaDB, AzureMySql, AzurePostgreSql, AzureSqlDW, AzureSqlDatabase, AzureSqlMI, AzureSearch, AzureStorage, AzureTableStorage, Cassandra, CommonDataServiceForApps, Concur, CosmosDb, CosmosDbMongoDbApi, Couchbase, CustomDataSource, Db2, Drill, Dynamics, DynamicsAX, DynamicsCrm, Eloqua, FileServer, FtpServer, GoogleAdWords, GoogleBigQuery, GoogleCloudStorage, Greenplum, HBase, HDInsight, HDInsightOnDemand, HttpServer, Hdfs, Hive, Hubspot, Impala, Informix, Jira, LinkedService, Magento, MariaDB, Marketo, MicrosoftAccess, MongoDb, MongoDbAtlas, MongoDbV2, MySql, Netezza, OData, Odbc, Office365, Oracle, OracleServiceCloud, Paypal, Phoenix, PostgreSql, Presto, QuickBooks, Responsys, RestService, SqlServer, Salesforce, SalesforceMarketingCloud, SalesforceServiceCloud, SapBW, SapCloudForCustomer, SapEcc, SapHana, SapOpenHub, SapTable, ServiceNow, Sftp, SharePointOnlineList, Shopify, Snowflake, Spark, Square, Sybase, Teradata, Vertica, Web, Xero, Zoho.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>A JSON object that contains the properties of the Synapse Linked Service.</summary>
    [JsonPropertyName("typePropertiesJson")]
    public string? TypePropertiesJson { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSpecInitProviderIntegrationRuntimeNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a IntegrationRuntimeAzure in synapse to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSpecInitProviderIntegrationRuntimeNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceSpecInitProviderIntegrationRuntimeNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSpecInitProviderIntegrationRuntimeNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a IntegrationRuntimeAzure in synapse to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSpecInitProviderIntegrationRuntimeNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceSpecInitProviderIntegrationRuntimeNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSpecInitProviderIntegrationRuntime
{
    /// <summary>The integration runtime reference to associate with the Synapse Linked Service.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a IntegrationRuntimeAzure in synapse to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1LinkedServiceSpecInitProviderIntegrationRuntimeNameRef? NameRef { get; set; }

    /// <summary>Selector for a IntegrationRuntimeAzure in synapse to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1LinkedServiceSpecInitProviderIntegrationRuntimeNameSelector? NameSelector { get; set; }

    /// <summary>A map of parameters to associate with the integration runtime.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSpecInitProvider
{
    /// <summary>A map of additional properties to associate with the Synapse Linked Service.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Synapse Linked Service.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The description for the Synapse Linked Service.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A integration_runtime block as defined below.</summary>
    [JsonPropertyName("integrationRuntime")]
    public IList<V1beta1LinkedServiceSpecInitProviderIntegrationRuntime>? IntegrationRuntime { get; set; }

    /// <summary>A map of parameters to associate with the Synapse Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>The type of data stores that will be connected to Synapse. Valid Values include AmazonMWS, AmazonRdsForOracle, AmazonRdsForSqlServer, AmazonRedshift, AmazonS3, AzureBatch. Changing this forces a new resource to be created. AzureBlobFS, AzureBlobStorage, AzureDataExplorer, AzureDataLakeAnalytics, AzureDataLakeStore, AzureDatabricks, AzureDatabricksDeltaLake, AzureFileStorage, AzureFunction, AzureKeyVault, AzureML, AzureMLService, AzureMariaDB, AzureMySql, AzurePostgreSql, AzureSqlDW, AzureSqlDatabase, AzureSqlMI, AzureSearch, AzureStorage, AzureTableStorage, Cassandra, CommonDataServiceForApps, Concur, CosmosDb, CosmosDbMongoDbApi, Couchbase, CustomDataSource, Db2, Drill, Dynamics, DynamicsAX, DynamicsCrm, Eloqua, FileServer, FtpServer, GoogleAdWords, GoogleBigQuery, GoogleCloudStorage, Greenplum, HBase, HDInsight, HDInsightOnDemand, HttpServer, Hdfs, Hive, Hubspot, Impala, Informix, Jira, LinkedService, Magento, MariaDB, Marketo, MicrosoftAccess, MongoDb, MongoDbAtlas, MongoDbV2, MySql, Netezza, OData, Odbc, Office365, Oracle, OracleServiceCloud, Paypal, Phoenix, PostgreSql, Presto, QuickBooks, Responsys, RestService, SqlServer, Salesforce, SalesforceMarketingCloud, SalesforceServiceCloud, SapBW, SapCloudForCustomer, SapEcc, SapHana, SapOpenHub, SapTable, ServiceNow, Sftp, SharePointOnlineList, Shopify, Snowflake, Spark, Square, Sybase, Teradata, Vertica, Web, Xero, Zoho.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>A JSON object that contains the properties of the Synapse Linked Service.</summary>
    [JsonPropertyName("typePropertiesJson")]
    public string? TypePropertiesJson { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSpecProviderConfigRefPolicy
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
public partial class V1beta1LinkedServiceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1LinkedServiceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1LinkedServiceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1LinkedServiceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1LinkedServiceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>LinkedServiceSpec defines the desired state of LinkedService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LinkedServiceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LinkedServiceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LinkedServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1LinkedServiceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LinkedServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceStatusAtProviderIntegrationRuntime
{
    /// <summary>The integration runtime reference to associate with the Synapse Linked Service.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the integration runtime.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceStatusAtProvider
{
    /// <summary>A map of additional properties to associate with the Synapse Linked Service.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Synapse Linked Service.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The description for the Synapse Linked Service.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of the Synapse Linked Service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A integration_runtime block as defined below.</summary>
    [JsonPropertyName("integrationRuntime")]
    public IList<V1beta1LinkedServiceStatusAtProviderIntegrationRuntime>? IntegrationRuntime { get; set; }

    /// <summary>A map of parameters to associate with the Synapse Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>The Synapse Workspace ID in which to associate the Linked Service with. Changing this forces a new Synapse Linked Service to be created.</summary>
    [JsonPropertyName("synapseWorkspaceId")]
    public string? SynapseWorkspaceId { get; set; }

    /// <summary>The type of data stores that will be connected to Synapse. Valid Values include AmazonMWS, AmazonRdsForOracle, AmazonRdsForSqlServer, AmazonRedshift, AmazonS3, AzureBatch. Changing this forces a new resource to be created. AzureBlobFS, AzureBlobStorage, AzureDataExplorer, AzureDataLakeAnalytics, AzureDataLakeStore, AzureDatabricks, AzureDatabricksDeltaLake, AzureFileStorage, AzureFunction, AzureKeyVault, AzureML, AzureMLService, AzureMariaDB, AzureMySql, AzurePostgreSql, AzureSqlDW, AzureSqlDatabase, AzureSqlMI, AzureSearch, AzureStorage, AzureTableStorage, Cassandra, CommonDataServiceForApps, Concur, CosmosDb, CosmosDbMongoDbApi, Couchbase, CustomDataSource, Db2, Drill, Dynamics, DynamicsAX, DynamicsCrm, Eloqua, FileServer, FtpServer, GoogleAdWords, GoogleBigQuery, GoogleCloudStorage, Greenplum, HBase, HDInsight, HDInsightOnDemand, HttpServer, Hdfs, Hive, Hubspot, Impala, Informix, Jira, LinkedService, Magento, MariaDB, Marketo, MicrosoftAccess, MongoDb, MongoDbAtlas, MongoDbV2, MySql, Netezza, OData, Odbc, Office365, Oracle, OracleServiceCloud, Paypal, Phoenix, PostgreSql, Presto, QuickBooks, Responsys, RestService, SqlServer, Salesforce, SalesforceMarketingCloud, SalesforceServiceCloud, SapBW, SapCloudForCustomer, SapEcc, SapHana, SapOpenHub, SapTable, ServiceNow, Sftp, SharePointOnlineList, Shopify, Snowflake, Spark, Square, Sybase, Teradata, Vertica, Web, Xero, Zoho.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>A JSON object that contains the properties of the Synapse Linked Service.</summary>
    [JsonPropertyName("typePropertiesJson")]
    public string? TypePropertiesJson { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceStatusConditions
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

/// <summary>LinkedServiceStatus defines the observed state of LinkedService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LinkedServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LinkedServiceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LinkedService is the Schema for the LinkedServices API. Manages a Linked Service (connection) between a resource and Azure Synapse. This is a generic resource that supports all different Linked Service Types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LinkedService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LinkedServiceSpec>, IStatus<V1beta1LinkedServiceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LinkedService";
    public const string KubeGroup = "synapse.azure.upbound.io";
    public const string KubePluralName = "linkedservices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LinkedServiceSpec defines the desired state of LinkedService</summary>
    [JsonPropertyName("spec")]
    public V1beta1LinkedServiceSpec Spec { get; set; }

    /// <summary>LinkedServiceStatus defines the observed state of LinkedService.</summary>
    [JsonPropertyName("status")]
    public V1beta1LinkedServiceStatus? Status { get; set; }
}