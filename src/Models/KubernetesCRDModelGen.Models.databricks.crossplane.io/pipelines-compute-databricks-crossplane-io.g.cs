using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.databricks.crossplane.io;
/// <summary>Pipeline is the Schema for the Pipelines API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PipelineList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Pipeline>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PipelineList";
    public const string KubeGroup = "compute.databricks.crossplane.io";
    public const string KubePluralName = "pipelines";
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
    public IList<V1alpha1Pipeline> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderClusterAutoscale
{
    /// <summary></summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderClusterAwsAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderClusterAzureAttributesLogAnalyticsInfo
{
    /// <summary></summary>
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderClusterAzureAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logAnalyticsInfo")]
    public IList<V1alpha1PipelineSpecForProviderClusterAzureAttributesLogAnalyticsInfo>? LogAnalyticsInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderClusterClusterLogConfDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderClusterClusterLogConfS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderClusterClusterLogConfVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderClusterClusterLogConf
{
    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1PipelineSpecForProviderClusterClusterLogConfDbfs>? Dbfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1PipelineSpecForProviderClusterClusterLogConfS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1PipelineSpecForProviderClusterClusterLogConfVolumes>? Volumes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderClusterGcpAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderClusterInitScriptsAbfss
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderClusterInitScriptsDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderClusterInitScriptsFile
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderClusterInitScriptsGcs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderClusterInitScriptsS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderClusterInitScriptsVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderClusterInitScriptsWorkspace
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderClusterInitScripts
{
    /// <summary></summary>
    [JsonPropertyName("abfss")]
    public IList<V1alpha1PipelineSpecForProviderClusterInitScriptsAbfss>? Abfss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1PipelineSpecForProviderClusterInitScriptsDbfs>? Dbfs { get; set; }

    /// <summary>specifies path to a file in Databricks Workspace to include as source. Actual path is specified as path attribute inside the block.</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1PipelineSpecForProviderClusterInitScriptsFile>? File { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcs")]
    public IList<V1alpha1PipelineSpecForProviderClusterInitScriptsGcs>? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1PipelineSpecForProviderClusterInitScriptsS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1PipelineSpecForProviderClusterInitScriptsVolumes>? Volumes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspace")]
    public IList<V1alpha1PipelineSpecForProviderClusterInitScriptsWorkspace>? Workspace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderCluster
{
    /// <summary></summary>
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoscale")]
    public IList<V1alpha1PipelineSpecForProviderClusterAutoscale>? Autoscale { get; set; }

    /// <summary></summary>
    [JsonPropertyName("awsAttributes")]
    public IList<V1alpha1PipelineSpecForProviderClusterAwsAttributes>? AwsAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAttributes")]
    public IList<V1alpha1PipelineSpecForProviderClusterAzureAttributes>? AzureAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterLogConf")]
    public IList<V1alpha1PipelineSpecForProviderClusterClusterLogConf>? ClusterLogConf { get; set; }

    /// <summary>A map of tags associated with the pipeline. These are forwarded to the cluster as cluster tags, and are therefore subject to the same limitations. A maximum of 25 tags can be added to the pipeline.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpAttributes")]
    public IList<V1alpha1PipelineSpecForProviderClusterGcpAttributes>? GcpAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initScripts")]
    public IList<V1alpha1PipelineSpecForProviderClusterInitScripts>? InitScripts { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderDeployment
{
    /// <summary>The deployment method that manages the pipeline.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The path to the file containing metadata about the deployment.</summary>
    [JsonPropertyName("metadataFilePath")]
    public string? MetadataFilePath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderEnvironment
{
    /// <summary></summary>
    [JsonPropertyName("dependencies")]
    public IList<string>? Dependencies { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderEventLog
{
    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderFilters
{
    /// <summary>Paths to exclude.</summary>
    [JsonPropertyName("exclude")]
    public IList<string>? Exclude { get; set; }

    /// <summary>Paths to include.</summary>
    [JsonPropertyName("include")]
    public IList<string>? Include { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderGatewayDefinition
{
    /// <summary>Immutable. The Unity Catalog connection this gateway pipeline uses to communicate with the source.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>Immutable. The Unity Catalog connection this ingestion pipeline uses to communicate with the source. Specify either ingestion_gateway_id or connection_name.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Required, Immutable. The name of the catalog for the gateway pipeline's storage location.</summary>
    [JsonPropertyName("gatewayStorageCatalog")]
    public string? GatewayStorageCatalog { get; set; }

    /// <summary>Required. The Unity Catalog-compatible naming for the gateway storage location. This is the destination to use for the data that is extracted by the gateway. Lakeflow Declarative Pipelines system will automatically create the storage location under the catalog and schema.</summary>
    [JsonPropertyName("gatewayStorageName")]
    public string? GatewayStorageName { get; set; }

    /// <summary>Required, Immutable. The name of the schema for the gateway pipelines's storage location.</summary>
    [JsonPropertyName("gatewayStorageSchema")]
    public string? GatewayStorageSchema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderIngestionDefinitionObjectsReportTableConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("excludeColumns")]
    public IList<string>? ExcludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includeColumns")]
    public IList<string>? IncludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderIngestionDefinitionObjectsReport
{
    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("destinationCatalog")]
    public string? DestinationCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("destinationSchema")]
    public string? DestinationSchema { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destinationTable")]
    public string? DestinationTable { get; set; }

    /// <summary>URL of the Lakeflow Declarative Pipeline on the given workspace.</summary>
    [JsonPropertyName("sourceUrl")]
    public string? SourceUrl { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public IList<V1alpha1PipelineSpecForProviderIngestionDefinitionObjectsReportTableConfiguration>? TableConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderIngestionDefinitionObjectsSchemaTableConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("excludeColumns")]
    public IList<string>? ExcludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includeColumns")]
    public IList<string>? IncludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderIngestionDefinitionObjectsSchema
{
    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("destinationCatalog")]
    public string? DestinationCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("destinationSchema")]
    public string? DestinationSchema { get; set; }

    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("sourceCatalog")]
    public string? SourceCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("sourceSchema")]
    public string? SourceSchema { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public IList<V1alpha1PipelineSpecForProviderIngestionDefinitionObjectsSchemaTableConfiguration>? TableConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderIngestionDefinitionObjectsTableTableConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("excludeColumns")]
    public IList<string>? ExcludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includeColumns")]
    public IList<string>? IncludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderIngestionDefinitionObjectsTable
{
    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("destinationCatalog")]
    public string? DestinationCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("destinationSchema")]
    public string? DestinationSchema { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destinationTable")]
    public string? DestinationTable { get; set; }

    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("sourceCatalog")]
    public string? SourceCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("sourceSchema")]
    public string? SourceSchema { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceTable")]
    public string? SourceTable { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public IList<V1alpha1PipelineSpecForProviderIngestionDefinitionObjectsTableTableConfiguration>? TableConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderIngestionDefinitionObjects
{
    /// <summary></summary>
    [JsonPropertyName("report")]
    public IList<V1alpha1PipelineSpecForProviderIngestionDefinitionObjectsReport>? Report { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("schema")]
    public IList<V1alpha1PipelineSpecForProviderIngestionDefinitionObjectsSchema>? Schema { get; set; }

    /// <summary></summary>
    [JsonPropertyName("table")]
    public IList<V1alpha1PipelineSpecForProviderIngestionDefinitionObjectsTable>? Table { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderIngestionDefinitionTableConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("excludeColumns")]
    public IList<string>? ExcludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includeColumns")]
    public IList<string>? IncludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderIngestionDefinition
{
    /// <summary>Immutable. The Unity Catalog connection this ingestion pipeline uses to communicate with the source. Specify either ingestion_gateway_id or connection_name.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Immutable. Identifier for the ingestion gateway used by this ingestion pipeline to communicate with the source. Specify either ingestion_gateway_id or connection_name.</summary>
    [JsonPropertyName("ingestionGatewayId")]
    public string? IngestionGatewayId { get; set; }

    /// <summary>Required. Settings specifying tables to replicate and the destination for the replicated tables.</summary>
    [JsonPropertyName("objects")]
    public IList<V1alpha1PipelineSpecForProviderIngestionDefinitionObjects>? Objects { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public IList<V1alpha1PipelineSpecForProviderIngestionDefinitionTableConfiguration>? TableConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderLatestUpdates
{
    /// <summary></summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("updateId")]
    public string? UpdateId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderLibraryFile
{
    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderLibraryGlob
{
    /// <summary>Paths to include.</summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderLibraryNotebook
{
    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderLibrary
{
    /// <summary>specifies path to a file in Databricks Workspace to include as source. Actual path is specified as path attribute inside the block.</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1PipelineSpecForProviderLibraryFile>? File { get; set; }

    /// <summary>The unified field to include source code. Each entry should have the include attribute that can specify a notebook path, a file path, or a folder path that ends /** (to include everything from that folder). This field cannot be used together with notebook or file.</summary>
    [JsonPropertyName("glob")]
    public IList<V1alpha1PipelineSpecForProviderLibraryGlob>? Glob { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1PipelineSpecForProviderLibraryMaven>? Maven { get; set; }

    /// <summary>specifies path to a Databricks Notebook to include as source. Actual path is specified as path attribute inside the block.</summary>
    [JsonPropertyName("notebook")]
    public IList<V1alpha1PipelineSpecForProviderLibraryNotebook>? Notebook { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderNotification
{
    /// <summary>empty list of alert types. Right now following alert types are supported, consult documentation for actual list</summary>
    [JsonPropertyName("alerts")]
    public IList<string>? Alerts { get; set; }

    /// <summary>empty list of emails to notify.</summary>
    [JsonPropertyName("emailRecipients")]
    public IList<string>? EmailRecipients { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderRestartWindow
{
    /// <summary></summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startHour")]
    public double? StartHour { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("timeZoneId")]
    public string? TimeZoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderRunAs
{
    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("servicePrincipalName")]
    public string? ServicePrincipalName { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderTriggerCron
{
    /// <summary></summary>
    [JsonPropertyName("quartzCronSchedule")]
    public string? QuartzCronSchedule { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderTriggerManual
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProviderTrigger
{
    /// <summary></summary>
    [JsonPropertyName("cron")]
    public IList<V1alpha1PipelineSpecForProviderTriggerCron>? Cron { get; set; }

    /// <summary></summary>
    [JsonPropertyName("manual")]
    public IList<V1alpha1PipelineSpecForProviderTriggerManual>? Manual { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecForProvider
{
    /// <summary>Optional boolean flag. If false, deployment will fail if name conflicts with that of another pipeline. default is false.</summary>
    [JsonPropertyName("allowDuplicateNames")]
    public bool? AllowDuplicateNames { get; set; }

    /// <summary>optional string specifying ID of the budget policy for this Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cause")]
    public string? Cause { get; set; }

    /// <summary>optional name of the release channel for Spark version used by Lakeflow Declarative Pipeline.  Supported values are: CURRENT (default) and PREVIEW.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Clusters to run the pipeline. If none is specified, pipelines will automatically select a default cluster configuration for the pipeline. Please note that Lakeflow Declarative Pipeline clusters are supporting only subset of attributes as described in   Also, note that autoscale block is extended with the mode parameter that controls the autoscaling algorithm (possible values are ENHANCED for new, enhanced autoscaling algorithm, or LEGACY for old algorithm).</summary>
    [JsonPropertyName("cluster")]
    public IList<V1alpha1PipelineSpecForProviderCluster>? Cluster { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>An optional list of values to apply to the entire pipeline. Elements must be formatted as key:value pairs.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A flag indicating whether to run the pipeline continuously. The default value is false.</summary>
    [JsonPropertyName("continuous")]
    public bool? Continuous { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("creatorUserName")]
    public string? CreatorUserName { get; set; }

    /// <summary>Deployment type of this pipeline. Supports following attributes:</summary>
    [JsonPropertyName("deployment")]
    public IList<V1alpha1PipelineSpecForProviderDeployment>? Deployment { get; set; }

    /// <summary>A flag indicating whether to run the pipeline in development mode. The default value is false.</summary>
    [JsonPropertyName("development")]
    public bool? Development { get; set; }

    /// <summary>optional name of the product edition. Supported values are: CORE, PRO, ADVANCED (default).  Not required when serverless is set to true.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("environment")]
    public IList<V1alpha1PipelineSpecForProviderEnvironment>? Environment { get; set; }

    /// <summary>an optional block specifying a table where LDP Event Log will be stored.  Consists of the following fields:</summary>
    [JsonPropertyName("eventLog")]
    public IList<V1alpha1PipelineSpecForProviderEventLog>? EventLog { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expectedLastModified")]
    public double? ExpectedLastModified { get; set; }

    /// <summary>Filters on which Pipeline packages to include in the deployed graph.  This block consists of following attributes:</summary>
    [JsonPropertyName("filters")]
    public IList<V1alpha1PipelineSpecForProviderFilters>? Filters { get; set; }

    /// <summary>The definition of a gateway pipeline to support CDC. Consists of following attributes:</summary>
    [JsonPropertyName("gatewayDefinition")]
    public IList<V1alpha1PipelineSpecForProviderGatewayDefinition>? GatewayDefinition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("health")]
    public string? Health { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ingestionDefinition")]
    public IList<V1alpha1PipelineSpecForProviderIngestionDefinition>? IngestionDefinition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModified")]
    public double? LastModified { get; set; }

    /// <summary></summary>
    [JsonPropertyName("latestUpdates")]
    public IList<V1alpha1PipelineSpecForProviderLatestUpdates>? LatestUpdates { get; set; }

    /// <summary>Specifies pipeline code.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1PipelineSpecForProviderLibrary>? Library { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notification")]
    public IList<V1alpha1PipelineSpecForProviderNotification>? Notification { get; set; }

    /// <summary>A flag indicating whether to use Photon engine. The default value is false.</summary>
    [JsonPropertyName("photon")]
    public bool? Photon { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartWindow")]
    public IList<V1alpha1PipelineSpecForProviderRestartWindow>? RestartWindow { get; set; }

    /// <summary>An optional string specifying the root path for this pipeline. This is used as the root directory when editing the pipeline in the Databricks user interface and it is added to sys.path when executing Python sources during pipeline execution.</summary>
    [JsonPropertyName("rootPath")]
    public string? RootPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAs")]
    public IList<V1alpha1PipelineSpecForProviderRunAs>? RunAs { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>An optional flag indicating if serverless compute should be used for this Lakeflow Declarative Pipeline.  Requires catalog to be set, as it could be used only with Unity Catalog.</summary>
    [JsonPropertyName("serverless")]
    public bool? Serverless { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>A location on DBFS or cloud storage where output data and metadata required for pipeline execution are stored. By default, tables are stored in a subdirectory of this location. Change of this parameter forces recreation of the pipeline. (Conflicts with catalog).</summary>
    [JsonPropertyName("storage")]
    public string? Storage { get; set; }

    /// <summary>A map of tags associated with the pipeline. These are forwarded to the cluster as cluster tags, and are therefore subject to the same limitations. A maximum of 25 tags can be added to the pipeline.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The name of a database (in either the Hive metastore or in a UC catalog) for persisting pipeline output data. Configuring the target setting allows you to view and query the pipeline output data from the Databricks UI.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trigger")]
    public IList<V1alpha1PipelineSpecForProviderTrigger>? Trigger { get; set; }

    /// <summary>URL of the Lakeflow Declarative Pipeline on the given workspace.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderClusterAutoscale
{
    /// <summary></summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderClusterAwsAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderClusterAzureAttributesLogAnalyticsInfo
{
    /// <summary></summary>
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderClusterAzureAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logAnalyticsInfo")]
    public IList<V1alpha1PipelineSpecInitProviderClusterAzureAttributesLogAnalyticsInfo>? LogAnalyticsInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderClusterClusterLogConfDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderClusterClusterLogConfS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderClusterClusterLogConfVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderClusterClusterLogConf
{
    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1PipelineSpecInitProviderClusterClusterLogConfDbfs>? Dbfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1PipelineSpecInitProviderClusterClusterLogConfS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1PipelineSpecInitProviderClusterClusterLogConfVolumes>? Volumes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderClusterGcpAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderClusterInitScriptsAbfss
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderClusterInitScriptsDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderClusterInitScriptsFile
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderClusterInitScriptsGcs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderClusterInitScriptsS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderClusterInitScriptsVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderClusterInitScriptsWorkspace
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderClusterInitScripts
{
    /// <summary></summary>
    [JsonPropertyName("abfss")]
    public IList<V1alpha1PipelineSpecInitProviderClusterInitScriptsAbfss>? Abfss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1PipelineSpecInitProviderClusterInitScriptsDbfs>? Dbfs { get; set; }

    /// <summary>specifies path to a file in Databricks Workspace to include as source. Actual path is specified as path attribute inside the block.</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1PipelineSpecInitProviderClusterInitScriptsFile>? File { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcs")]
    public IList<V1alpha1PipelineSpecInitProviderClusterInitScriptsGcs>? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1PipelineSpecInitProviderClusterInitScriptsS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1PipelineSpecInitProviderClusterInitScriptsVolumes>? Volumes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspace")]
    public IList<V1alpha1PipelineSpecInitProviderClusterInitScriptsWorkspace>? Workspace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderCluster
{
    /// <summary></summary>
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoscale")]
    public IList<V1alpha1PipelineSpecInitProviderClusterAutoscale>? Autoscale { get; set; }

    /// <summary></summary>
    [JsonPropertyName("awsAttributes")]
    public IList<V1alpha1PipelineSpecInitProviderClusterAwsAttributes>? AwsAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAttributes")]
    public IList<V1alpha1PipelineSpecInitProviderClusterAzureAttributes>? AzureAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterLogConf")]
    public IList<V1alpha1PipelineSpecInitProviderClusterClusterLogConf>? ClusterLogConf { get; set; }

    /// <summary>A map of tags associated with the pipeline. These are forwarded to the cluster as cluster tags, and are therefore subject to the same limitations. A maximum of 25 tags can be added to the pipeline.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpAttributes")]
    public IList<V1alpha1PipelineSpecInitProviderClusterGcpAttributes>? GcpAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initScripts")]
    public IList<V1alpha1PipelineSpecInitProviderClusterInitScripts>? InitScripts { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderDeployment
{
    /// <summary>The deployment method that manages the pipeline.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The path to the file containing metadata about the deployment.</summary>
    [JsonPropertyName("metadataFilePath")]
    public string? MetadataFilePath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderEnvironment
{
    /// <summary></summary>
    [JsonPropertyName("dependencies")]
    public IList<string>? Dependencies { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderEventLog
{
    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderFilters
{
    /// <summary>Paths to exclude.</summary>
    [JsonPropertyName("exclude")]
    public IList<string>? Exclude { get; set; }

    /// <summary>Paths to include.</summary>
    [JsonPropertyName("include")]
    public IList<string>? Include { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderGatewayDefinition
{
    /// <summary>Immutable. The Unity Catalog connection this gateway pipeline uses to communicate with the source.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>Immutable. The Unity Catalog connection this ingestion pipeline uses to communicate with the source. Specify either ingestion_gateway_id or connection_name.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Required, Immutable. The name of the catalog for the gateway pipeline's storage location.</summary>
    [JsonPropertyName("gatewayStorageCatalog")]
    public string? GatewayStorageCatalog { get; set; }

    /// <summary>Required. The Unity Catalog-compatible naming for the gateway storage location. This is the destination to use for the data that is extracted by the gateway. Lakeflow Declarative Pipelines system will automatically create the storage location under the catalog and schema.</summary>
    [JsonPropertyName("gatewayStorageName")]
    public string? GatewayStorageName { get; set; }

    /// <summary>Required, Immutable. The name of the schema for the gateway pipelines's storage location.</summary>
    [JsonPropertyName("gatewayStorageSchema")]
    public string? GatewayStorageSchema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderIngestionDefinitionObjectsReportTableConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("excludeColumns")]
    public IList<string>? ExcludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includeColumns")]
    public IList<string>? IncludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderIngestionDefinitionObjectsReport
{
    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("destinationCatalog")]
    public string? DestinationCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("destinationSchema")]
    public string? DestinationSchema { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destinationTable")]
    public string? DestinationTable { get; set; }

    /// <summary>URL of the Lakeflow Declarative Pipeline on the given workspace.</summary>
    [JsonPropertyName("sourceUrl")]
    public string? SourceUrl { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public IList<V1alpha1PipelineSpecInitProviderIngestionDefinitionObjectsReportTableConfiguration>? TableConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderIngestionDefinitionObjectsSchemaTableConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("excludeColumns")]
    public IList<string>? ExcludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includeColumns")]
    public IList<string>? IncludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderIngestionDefinitionObjectsSchema
{
    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("destinationCatalog")]
    public string? DestinationCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("destinationSchema")]
    public string? DestinationSchema { get; set; }

    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("sourceCatalog")]
    public string? SourceCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("sourceSchema")]
    public string? SourceSchema { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public IList<V1alpha1PipelineSpecInitProviderIngestionDefinitionObjectsSchemaTableConfiguration>? TableConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderIngestionDefinitionObjectsTableTableConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("excludeColumns")]
    public IList<string>? ExcludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includeColumns")]
    public IList<string>? IncludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderIngestionDefinitionObjectsTable
{
    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("destinationCatalog")]
    public string? DestinationCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("destinationSchema")]
    public string? DestinationSchema { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destinationTable")]
    public string? DestinationTable { get; set; }

    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("sourceCatalog")]
    public string? SourceCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("sourceSchema")]
    public string? SourceSchema { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceTable")]
    public string? SourceTable { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public IList<V1alpha1PipelineSpecInitProviderIngestionDefinitionObjectsTableTableConfiguration>? TableConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderIngestionDefinitionObjects
{
    /// <summary></summary>
    [JsonPropertyName("report")]
    public IList<V1alpha1PipelineSpecInitProviderIngestionDefinitionObjectsReport>? Report { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("schema")]
    public IList<V1alpha1PipelineSpecInitProviderIngestionDefinitionObjectsSchema>? Schema { get; set; }

    /// <summary></summary>
    [JsonPropertyName("table")]
    public IList<V1alpha1PipelineSpecInitProviderIngestionDefinitionObjectsTable>? Table { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderIngestionDefinitionTableConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("excludeColumns")]
    public IList<string>? ExcludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includeColumns")]
    public IList<string>? IncludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderIngestionDefinition
{
    /// <summary>Immutable. The Unity Catalog connection this ingestion pipeline uses to communicate with the source. Specify either ingestion_gateway_id or connection_name.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Immutable. Identifier for the ingestion gateway used by this ingestion pipeline to communicate with the source. Specify either ingestion_gateway_id or connection_name.</summary>
    [JsonPropertyName("ingestionGatewayId")]
    public string? IngestionGatewayId { get; set; }

    /// <summary>Required. Settings specifying tables to replicate and the destination for the replicated tables.</summary>
    [JsonPropertyName("objects")]
    public IList<V1alpha1PipelineSpecInitProviderIngestionDefinitionObjects>? Objects { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public IList<V1alpha1PipelineSpecInitProviderIngestionDefinitionTableConfiguration>? TableConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderLatestUpdates
{
    /// <summary></summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("updateId")]
    public string? UpdateId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderLibraryFile
{
    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderLibraryGlob
{
    /// <summary>Paths to include.</summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderLibraryNotebook
{
    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderLibrary
{
    /// <summary>specifies path to a file in Databricks Workspace to include as source. Actual path is specified as path attribute inside the block.</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1PipelineSpecInitProviderLibraryFile>? File { get; set; }

    /// <summary>The unified field to include source code. Each entry should have the include attribute that can specify a notebook path, a file path, or a folder path that ends /** (to include everything from that folder). This field cannot be used together with notebook or file.</summary>
    [JsonPropertyName("glob")]
    public IList<V1alpha1PipelineSpecInitProviderLibraryGlob>? Glob { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1PipelineSpecInitProviderLibraryMaven>? Maven { get; set; }

    /// <summary>specifies path to a Databricks Notebook to include as source. Actual path is specified as path attribute inside the block.</summary>
    [JsonPropertyName("notebook")]
    public IList<V1alpha1PipelineSpecInitProviderLibraryNotebook>? Notebook { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderNotification
{
    /// <summary>empty list of alert types. Right now following alert types are supported, consult documentation for actual list</summary>
    [JsonPropertyName("alerts")]
    public IList<string>? Alerts { get; set; }

    /// <summary>empty list of emails to notify.</summary>
    [JsonPropertyName("emailRecipients")]
    public IList<string>? EmailRecipients { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderRestartWindow
{
    /// <summary></summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startHour")]
    public double? StartHour { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("timeZoneId")]
    public string? TimeZoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderRunAs
{
    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("servicePrincipalName")]
    public string? ServicePrincipalName { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderTriggerCron
{
    /// <summary></summary>
    [JsonPropertyName("quartzCronSchedule")]
    public string? QuartzCronSchedule { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderTriggerManual
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProviderTrigger
{
    /// <summary></summary>
    [JsonPropertyName("cron")]
    public IList<V1alpha1PipelineSpecInitProviderTriggerCron>? Cron { get; set; }

    /// <summary></summary>
    [JsonPropertyName("manual")]
    public IList<V1alpha1PipelineSpecInitProviderTriggerManual>? Manual { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecInitProvider
{
    /// <summary>Optional boolean flag. If false, deployment will fail if name conflicts with that of another pipeline. default is false.</summary>
    [JsonPropertyName("allowDuplicateNames")]
    public bool? AllowDuplicateNames { get; set; }

    /// <summary>optional string specifying ID of the budget policy for this Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cause")]
    public string? Cause { get; set; }

    /// <summary>optional name of the release channel for Spark version used by Lakeflow Declarative Pipeline.  Supported values are: CURRENT (default) and PREVIEW.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Clusters to run the pipeline. If none is specified, pipelines will automatically select a default cluster configuration for the pipeline. Please note that Lakeflow Declarative Pipeline clusters are supporting only subset of attributes as described in   Also, note that autoscale block is extended with the mode parameter that controls the autoscaling algorithm (possible values are ENHANCED for new, enhanced autoscaling algorithm, or LEGACY for old algorithm).</summary>
    [JsonPropertyName("cluster")]
    public IList<V1alpha1PipelineSpecInitProviderCluster>? Cluster { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>An optional list of values to apply to the entire pipeline. Elements must be formatted as key:value pairs.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A flag indicating whether to run the pipeline continuously. The default value is false.</summary>
    [JsonPropertyName("continuous")]
    public bool? Continuous { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("creatorUserName")]
    public string? CreatorUserName { get; set; }

    /// <summary>Deployment type of this pipeline. Supports following attributes:</summary>
    [JsonPropertyName("deployment")]
    public IList<V1alpha1PipelineSpecInitProviderDeployment>? Deployment { get; set; }

    /// <summary>A flag indicating whether to run the pipeline in development mode. The default value is false.</summary>
    [JsonPropertyName("development")]
    public bool? Development { get; set; }

    /// <summary>optional name of the product edition. Supported values are: CORE, PRO, ADVANCED (default).  Not required when serverless is set to true.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("environment")]
    public IList<V1alpha1PipelineSpecInitProviderEnvironment>? Environment { get; set; }

    /// <summary>an optional block specifying a table where LDP Event Log will be stored.  Consists of the following fields:</summary>
    [JsonPropertyName("eventLog")]
    public IList<V1alpha1PipelineSpecInitProviderEventLog>? EventLog { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expectedLastModified")]
    public double? ExpectedLastModified { get; set; }

    /// <summary>Filters on which Pipeline packages to include in the deployed graph.  This block consists of following attributes:</summary>
    [JsonPropertyName("filters")]
    public IList<V1alpha1PipelineSpecInitProviderFilters>? Filters { get; set; }

    /// <summary>The definition of a gateway pipeline to support CDC. Consists of following attributes:</summary>
    [JsonPropertyName("gatewayDefinition")]
    public IList<V1alpha1PipelineSpecInitProviderGatewayDefinition>? GatewayDefinition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("health")]
    public string? Health { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ingestionDefinition")]
    public IList<V1alpha1PipelineSpecInitProviderIngestionDefinition>? IngestionDefinition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModified")]
    public double? LastModified { get; set; }

    /// <summary></summary>
    [JsonPropertyName("latestUpdates")]
    public IList<V1alpha1PipelineSpecInitProviderLatestUpdates>? LatestUpdates { get; set; }

    /// <summary>Specifies pipeline code.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1PipelineSpecInitProviderLibrary>? Library { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notification")]
    public IList<V1alpha1PipelineSpecInitProviderNotification>? Notification { get; set; }

    /// <summary>A flag indicating whether to use Photon engine. The default value is false.</summary>
    [JsonPropertyName("photon")]
    public bool? Photon { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartWindow")]
    public IList<V1alpha1PipelineSpecInitProviderRestartWindow>? RestartWindow { get; set; }

    /// <summary>An optional string specifying the root path for this pipeline. This is used as the root directory when editing the pipeline in the Databricks user interface and it is added to sys.path when executing Python sources during pipeline execution.</summary>
    [JsonPropertyName("rootPath")]
    public string? RootPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAs")]
    public IList<V1alpha1PipelineSpecInitProviderRunAs>? RunAs { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>An optional flag indicating if serverless compute should be used for this Lakeflow Declarative Pipeline.  Requires catalog to be set, as it could be used only with Unity Catalog.</summary>
    [JsonPropertyName("serverless")]
    public bool? Serverless { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>A location on DBFS or cloud storage where output data and metadata required for pipeline execution are stored. By default, tables are stored in a subdirectory of this location. Change of this parameter forces recreation of the pipeline. (Conflicts with catalog).</summary>
    [JsonPropertyName("storage")]
    public string? Storage { get; set; }

    /// <summary>A map of tags associated with the pipeline. These are forwarded to the cluster as cluster tags, and are therefore subject to the same limitations. A maximum of 25 tags can be added to the pipeline.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The name of a database (in either the Hive metastore or in a UC catalog) for persisting pipeline output data. Configuring the target setting allows you to view and query the pipeline output data from the Databricks UI.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trigger")]
    public IList<V1alpha1PipelineSpecInitProviderTrigger>? Trigger { get; set; }

    /// <summary>URL of the Lakeflow Declarative Pipeline on the given workspace.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecProviderConfigRefPolicy
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
public partial class V1alpha1PipelineSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1PipelineSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1alpha1PipelineSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1PipelineSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecPublishConnectionDetailsToMetadata
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
public partial class V1alpha1PipelineSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1PipelineSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1PipelineSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>PipelineSpec defines the desired state of Pipeline</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1PipelineSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1PipelineSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1PipelineSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1PipelineSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1PipelineSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderClusterAutoscale
{
    /// <summary></summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderClusterAwsAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderClusterAzureAttributesLogAnalyticsInfo
{
    /// <summary></summary>
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderClusterAzureAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logAnalyticsInfo")]
    public IList<V1alpha1PipelineStatusAtProviderClusterAzureAttributesLogAnalyticsInfo>? LogAnalyticsInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderClusterClusterLogConfDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderClusterClusterLogConfS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderClusterClusterLogConfVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderClusterClusterLogConf
{
    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1PipelineStatusAtProviderClusterClusterLogConfDbfs>? Dbfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1PipelineStatusAtProviderClusterClusterLogConfS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1PipelineStatusAtProviderClusterClusterLogConfVolumes>? Volumes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderClusterGcpAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderClusterInitScriptsAbfss
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderClusterInitScriptsDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderClusterInitScriptsFile
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderClusterInitScriptsGcs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderClusterInitScriptsS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderClusterInitScriptsVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderClusterInitScriptsWorkspace
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderClusterInitScripts
{
    /// <summary></summary>
    [JsonPropertyName("abfss")]
    public IList<V1alpha1PipelineStatusAtProviderClusterInitScriptsAbfss>? Abfss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1PipelineStatusAtProviderClusterInitScriptsDbfs>? Dbfs { get; set; }

    /// <summary>specifies path to a file in Databricks Workspace to include as source. Actual path is specified as path attribute inside the block.</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1PipelineStatusAtProviderClusterInitScriptsFile>? File { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcs")]
    public IList<V1alpha1PipelineStatusAtProviderClusterInitScriptsGcs>? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1PipelineStatusAtProviderClusterInitScriptsS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1PipelineStatusAtProviderClusterInitScriptsVolumes>? Volumes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspace")]
    public IList<V1alpha1PipelineStatusAtProviderClusterInitScriptsWorkspace>? Workspace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderCluster
{
    /// <summary></summary>
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoscale")]
    public IList<V1alpha1PipelineStatusAtProviderClusterAutoscale>? Autoscale { get; set; }

    /// <summary></summary>
    [JsonPropertyName("awsAttributes")]
    public IList<V1alpha1PipelineStatusAtProviderClusterAwsAttributes>? AwsAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAttributes")]
    public IList<V1alpha1PipelineStatusAtProviderClusterAzureAttributes>? AzureAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterLogConf")]
    public IList<V1alpha1PipelineStatusAtProviderClusterClusterLogConf>? ClusterLogConf { get; set; }

    /// <summary>A map of tags associated with the pipeline. These are forwarded to the cluster as cluster tags, and are therefore subject to the same limitations. A maximum of 25 tags can be added to the pipeline.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpAttributes")]
    public IList<V1alpha1PipelineStatusAtProviderClusterGcpAttributes>? GcpAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initScripts")]
    public IList<V1alpha1PipelineStatusAtProviderClusterInitScripts>? InitScripts { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderDeployment
{
    /// <summary>The deployment method that manages the pipeline.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The path to the file containing metadata about the deployment.</summary>
    [JsonPropertyName("metadataFilePath")]
    public string? MetadataFilePath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderEnvironment
{
    /// <summary></summary>
    [JsonPropertyName("dependencies")]
    public IList<string>? Dependencies { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderEventLog
{
    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderFilters
{
    /// <summary>Paths to exclude.</summary>
    [JsonPropertyName("exclude")]
    public IList<string>? Exclude { get; set; }

    /// <summary>Paths to include.</summary>
    [JsonPropertyName("include")]
    public IList<string>? Include { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderGatewayDefinition
{
    /// <summary>Immutable. The Unity Catalog connection this gateway pipeline uses to communicate with the source.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>Immutable. The Unity Catalog connection this ingestion pipeline uses to communicate with the source. Specify either ingestion_gateway_id or connection_name.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Required, Immutable. The name of the catalog for the gateway pipeline's storage location.</summary>
    [JsonPropertyName("gatewayStorageCatalog")]
    public string? GatewayStorageCatalog { get; set; }

    /// <summary>Required. The Unity Catalog-compatible naming for the gateway storage location. This is the destination to use for the data that is extracted by the gateway. Lakeflow Declarative Pipelines system will automatically create the storage location under the catalog and schema.</summary>
    [JsonPropertyName("gatewayStorageName")]
    public string? GatewayStorageName { get; set; }

    /// <summary>Required, Immutable. The name of the schema for the gateway pipelines's storage location.</summary>
    [JsonPropertyName("gatewayStorageSchema")]
    public string? GatewayStorageSchema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderIngestionDefinitionObjectsReportTableConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("excludeColumns")]
    public IList<string>? ExcludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includeColumns")]
    public IList<string>? IncludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderIngestionDefinitionObjectsReport
{
    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("destinationCatalog")]
    public string? DestinationCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("destinationSchema")]
    public string? DestinationSchema { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destinationTable")]
    public string? DestinationTable { get; set; }

    /// <summary>URL of the Lakeflow Declarative Pipeline on the given workspace.</summary>
    [JsonPropertyName("sourceUrl")]
    public string? SourceUrl { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public IList<V1alpha1PipelineStatusAtProviderIngestionDefinitionObjectsReportTableConfiguration>? TableConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderIngestionDefinitionObjectsSchemaTableConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("excludeColumns")]
    public IList<string>? ExcludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includeColumns")]
    public IList<string>? IncludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderIngestionDefinitionObjectsSchema
{
    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("destinationCatalog")]
    public string? DestinationCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("destinationSchema")]
    public string? DestinationSchema { get; set; }

    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("sourceCatalog")]
    public string? SourceCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("sourceSchema")]
    public string? SourceSchema { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public IList<V1alpha1PipelineStatusAtProviderIngestionDefinitionObjectsSchemaTableConfiguration>? TableConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderIngestionDefinitionObjectsTableTableConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("excludeColumns")]
    public IList<string>? ExcludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includeColumns")]
    public IList<string>? IncludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderIngestionDefinitionObjectsTable
{
    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("destinationCatalog")]
    public string? DestinationCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("destinationSchema")]
    public string? DestinationSchema { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destinationTable")]
    public string? DestinationTable { get; set; }

    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("sourceCatalog")]
    public string? SourceCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("sourceSchema")]
    public string? SourceSchema { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceTable")]
    public string? SourceTable { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public IList<V1alpha1PipelineStatusAtProviderIngestionDefinitionObjectsTableTableConfiguration>? TableConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderIngestionDefinitionObjects
{
    /// <summary></summary>
    [JsonPropertyName("report")]
    public IList<V1alpha1PipelineStatusAtProviderIngestionDefinitionObjectsReport>? Report { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("schema")]
    public IList<V1alpha1PipelineStatusAtProviderIngestionDefinitionObjectsSchema>? Schema { get; set; }

    /// <summary></summary>
    [JsonPropertyName("table")]
    public IList<V1alpha1PipelineStatusAtProviderIngestionDefinitionObjectsTable>? Table { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderIngestionDefinitionTableConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("excludeColumns")]
    public IList<string>? ExcludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includeColumns")]
    public IList<string>? IncludeColumns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderIngestionDefinition
{
    /// <summary>Immutable. The Unity Catalog connection this ingestion pipeline uses to communicate with the source. Specify either ingestion_gateway_id or connection_name.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Immutable. Identifier for the ingestion gateway used by this ingestion pipeline to communicate with the source. Specify either ingestion_gateway_id or connection_name.</summary>
    [JsonPropertyName("ingestionGatewayId")]
    public string? IngestionGatewayId { get; set; }

    /// <summary>Required. Settings specifying tables to replicate and the destination for the replicated tables.</summary>
    [JsonPropertyName("objects")]
    public IList<V1alpha1PipelineStatusAtProviderIngestionDefinitionObjects>? Objects { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public IList<V1alpha1PipelineStatusAtProviderIngestionDefinitionTableConfiguration>? TableConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderLatestUpdates
{
    /// <summary></summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("updateId")]
    public string? UpdateId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderLibraryFile
{
    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderLibraryGlob
{
    /// <summary>Paths to include.</summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderLibraryNotebook
{
    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderLibrary
{
    /// <summary>specifies path to a file in Databricks Workspace to include as source. Actual path is specified as path attribute inside the block.</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1PipelineStatusAtProviderLibraryFile>? File { get; set; }

    /// <summary>The unified field to include source code. Each entry should have the include attribute that can specify a notebook path, a file path, or a folder path that ends /** (to include everything from that folder). This field cannot be used together with notebook or file.</summary>
    [JsonPropertyName("glob")]
    public IList<V1alpha1PipelineStatusAtProviderLibraryGlob>? Glob { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1PipelineStatusAtProviderLibraryMaven>? Maven { get; set; }

    /// <summary>specifies path to a Databricks Notebook to include as source. Actual path is specified as path attribute inside the block.</summary>
    [JsonPropertyName("notebook")]
    public IList<V1alpha1PipelineStatusAtProviderLibraryNotebook>? Notebook { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderNotification
{
    /// <summary>empty list of alert types. Right now following alert types are supported, consult documentation for actual list</summary>
    [JsonPropertyName("alerts")]
    public IList<string>? Alerts { get; set; }

    /// <summary>empty list of emails to notify.</summary>
    [JsonPropertyName("emailRecipients")]
    public IList<string>? EmailRecipients { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderRestartWindow
{
    /// <summary></summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startHour")]
    public double? StartHour { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("timeZoneId")]
    public string? TimeZoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderRunAs
{
    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("servicePrincipalName")]
    public string? ServicePrincipalName { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderTriggerCron
{
    /// <summary></summary>
    [JsonPropertyName("quartzCronSchedule")]
    public string? QuartzCronSchedule { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderTriggerManual
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProviderTrigger
{
    /// <summary></summary>
    [JsonPropertyName("cron")]
    public IList<V1alpha1PipelineStatusAtProviderTriggerCron>? Cron { get; set; }

    /// <summary></summary>
    [JsonPropertyName("manual")]
    public IList<V1alpha1PipelineStatusAtProviderTriggerManual>? Manual { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusAtProvider
{
    /// <summary>Optional boolean flag. If false, deployment will fail if name conflicts with that of another pipeline. default is false.</summary>
    [JsonPropertyName("allowDuplicateNames")]
    public bool? AllowDuplicateNames { get; set; }

    /// <summary>optional string specifying ID of the budget policy for this Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cause")]
    public string? Cause { get; set; }

    /// <summary>optional name of the release channel for Spark version used by Lakeflow Declarative Pipeline.  Supported values are: CURRENT (default) and PREVIEW.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Clusters to run the pipeline. If none is specified, pipelines will automatically select a default cluster configuration for the pipeline. Please note that Lakeflow Declarative Pipeline clusters are supporting only subset of attributes as described in   Also, note that autoscale block is extended with the mode parameter that controls the autoscaling algorithm (possible values are ENHANCED for new, enhanced autoscaling algorithm, or LEGACY for old algorithm).</summary>
    [JsonPropertyName("cluster")]
    public IList<V1alpha1PipelineStatusAtProviderCluster>? Cluster { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>An optional list of values to apply to the entire pipeline. Elements must be formatted as key:value pairs.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A flag indicating whether to run the pipeline continuously. The default value is false.</summary>
    [JsonPropertyName("continuous")]
    public bool? Continuous { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("creatorUserName")]
    public string? CreatorUserName { get; set; }

    /// <summary>Deployment type of this pipeline. Supports following attributes:</summary>
    [JsonPropertyName("deployment")]
    public IList<V1alpha1PipelineStatusAtProviderDeployment>? Deployment { get; set; }

    /// <summary>A flag indicating whether to run the pipeline in development mode. The default value is false.</summary>
    [JsonPropertyName("development")]
    public bool? Development { get; set; }

    /// <summary>optional name of the product edition. Supported values are: CORE, PRO, ADVANCED (default).  Not required when serverless is set to true.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("environment")]
    public IList<V1alpha1PipelineStatusAtProviderEnvironment>? Environment { get; set; }

    /// <summary>an optional block specifying a table where LDP Event Log will be stored.  Consists of the following fields:</summary>
    [JsonPropertyName("eventLog")]
    public IList<V1alpha1PipelineStatusAtProviderEventLog>? EventLog { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expectedLastModified")]
    public double? ExpectedLastModified { get; set; }

    /// <summary>Filters on which Pipeline packages to include in the deployed graph.  This block consists of following attributes:</summary>
    [JsonPropertyName("filters")]
    public IList<V1alpha1PipelineStatusAtProviderFilters>? Filters { get; set; }

    /// <summary>The definition of a gateway pipeline to support CDC. Consists of following attributes:</summary>
    [JsonPropertyName("gatewayDefinition")]
    public IList<V1alpha1PipelineStatusAtProviderGatewayDefinition>? GatewayDefinition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("health")]
    public string? Health { get; set; }

    /// <summary>Canonical unique identifier of the Lakeflow Declarative Pipeline.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ingestionDefinition")]
    public IList<V1alpha1PipelineStatusAtProviderIngestionDefinition>? IngestionDefinition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModified")]
    public double? LastModified { get; set; }

    /// <summary></summary>
    [JsonPropertyName("latestUpdates")]
    public IList<V1alpha1PipelineStatusAtProviderLatestUpdates>? LatestUpdates { get; set; }

    /// <summary>Specifies pipeline code.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1PipelineStatusAtProviderLibrary>? Library { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notification")]
    public IList<V1alpha1PipelineStatusAtProviderNotification>? Notification { get; set; }

    /// <summary>A flag indicating whether to use Photon engine. The default value is false.</summary>
    [JsonPropertyName("photon")]
    public bool? Photon { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartWindow")]
    public IList<V1alpha1PipelineStatusAtProviderRestartWindow>? RestartWindow { get; set; }

    /// <summary>An optional string specifying the root path for this pipeline. This is used as the root directory when editing the pipeline in the Databricks user interface and it is added to sys.path when executing Python sources during pipeline execution.</summary>
    [JsonPropertyName("rootPath")]
    public string? RootPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAs")]
    public IList<V1alpha1PipelineStatusAtProviderRunAs>? RunAs { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>An optional flag indicating if serverless compute should be used for this Lakeflow Declarative Pipeline.  Requires catalog to be set, as it could be used only with Unity Catalog.</summary>
    [JsonPropertyName("serverless")]
    public bool? Serverless { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>A location on DBFS or cloud storage where output data and metadata required for pipeline execution are stored. By default, tables are stored in a subdirectory of this location. Change of this parameter forces recreation of the pipeline. (Conflicts with catalog).</summary>
    [JsonPropertyName("storage")]
    public string? Storage { get; set; }

    /// <summary>A map of tags associated with the pipeline. These are forwarded to the cluster as cluster tags, and are therefore subject to the same limitations. A maximum of 25 tags can be added to the pipeline.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The name of a database (in either the Hive metastore or in a UC catalog) for persisting pipeline output data. Configuring the target setting allows you to view and query the pipeline output data from the Databricks UI.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trigger")]
    public IList<V1alpha1PipelineStatusAtProviderTrigger>? Trigger { get; set; }

    /// <summary>URL of the Lakeflow Declarative Pipeline on the given workspace.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatusConditions
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

/// <summary>PipelineStatus defines the observed state of Pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1PipelineStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1PipelineStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Pipeline is the Schema for the Pipelines API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Pipeline : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1PipelineSpec>, IStatus<V1alpha1PipelineStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Pipeline";
    public const string KubeGroup = "compute.databricks.crossplane.io";
    public const string KubePluralName = "pipelines";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PipelineSpec defines the desired state of Pipeline</summary>
    [JsonPropertyName("spec")]
    public V1alpha1PipelineSpec Spec { get; set; }

    /// <summary>PipelineStatus defines the observed state of Pipeline.</summary>
    [JsonPropertyName("status")]
    public V1alpha1PipelineStatus? Status { get; set; }
}