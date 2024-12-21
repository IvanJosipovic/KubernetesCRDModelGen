using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.elasticsearch.aws.upbound.io;
/// <summary>Main user's password, which is stored in the Amazon Elasticsearch Service domain's internal database. Only specify if internal_user_database_enabled is set to true.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderAdvancedSecurityOptionsMasterUserOptionsMasterUserPasswordSecretRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderAdvancedSecurityOptionsMasterUserOptions
{
    /// <summary>ARN for the main user. Only specify if internal_user_database_enabled is not set or set to false.</summary>
    [JsonPropertyName("masterUserArn")]
    public string? MasterUserArn { get; set; }

    /// <summary>Main user's username, which is stored in the Amazon Elasticsearch Service domain's internal database. Only specify if internal_user_database_enabled is set to true.</summary>
    [JsonPropertyName("masterUserName")]
    public string? MasterUserName { get; set; }

    /// <summary>Main user's password, which is stored in the Amazon Elasticsearch Service domain's internal database. Only specify if internal_user_database_enabled is set to true.</summary>
    [JsonPropertyName("masterUserPasswordSecretRef")]
    public V1beta1DomainSpecForProviderAdvancedSecurityOptionsMasterUserOptionsMasterUserPasswordSecretRef? MasterUserPasswordSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderAdvancedSecurityOptions
{
    /// <summary>Whether advanced security is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether the internal user database is enabled. If not set, defaults to false by the AWS API.</summary>
    [JsonPropertyName("internalUserDatabaseEnabled")]
    public bool? InternalUserDatabaseEnabled { get; set; }

    /// <summary>Configuration block for the main user. Detailed below.</summary>
    [JsonPropertyName("masterUserOptions")]
    public IList<V1beta1DomainSpecForProviderAdvancedSecurityOptionsMasterUserOptions>? MasterUserOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderAutoTuneOptionsMaintenanceScheduleDuration
{
    /// <summary>The unit of time specifying the duration of an Auto-Tune maintenance window. Valid values: HOURS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>An integer specifying the value of the duration of an Auto-Tune maintenance window.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderAutoTuneOptionsMaintenanceSchedule
{
    /// <summary>A cron expression specifying the recurrence pattern for an Auto-Tune maintenance schedule.</summary>
    [JsonPropertyName("cronExpressionForRecurrence")]
    public string? CronExpressionForRecurrence { get; set; }

    /// <summary>Configuration block for the duration of the Auto-Tune maintenance window. Detailed below.</summary>
    [JsonPropertyName("duration")]
    public IList<V1beta1DomainSpecForProviderAutoTuneOptionsMaintenanceScheduleDuration>? Duration { get; set; }

    /// <summary>Date and time at which to start the Auto-Tune maintenance schedule in RFC3339 format.</summary>
    [JsonPropertyName("startAt")]
    public string? StartAt { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderAutoTuneOptions
{
    /// <summary>The Auto-Tune desired state for the domain. Valid values: ENABLED or DISABLED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>Configuration block for Auto-Tune maintenance windows. Can be specified multiple times for each maintenance window. Detailed below.</summary>
    [JsonPropertyName("maintenanceSchedule")]
    public IList<V1beta1DomainSpecForProviderAutoTuneOptionsMaintenanceSchedule>? MaintenanceSchedule { get; set; }

    /// <summary>Whether to roll back to default Auto-Tune settings when disabling Auto-Tune. Valid values: DEFAULT_ROLLBACK or NO_ROLLBACK.</summary>
    [JsonPropertyName("rollbackOnDisable")]
    public string? RollbackOnDisable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderClusterConfigColdStorageOptions
{
    /// <summary>Boolean to enable cold storage for an Elasticsearch domain. Defaults to false. Master and ultrawarm nodes must be enabled for cold storage.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderClusterConfigZoneAwarenessConfig
{
    /// <summary>Number of Availability Zones for the domain to use with zone_awareness_enabled. Defaults to 2. Valid values: 2 or 3.</summary>
    [JsonPropertyName("availabilityZoneCount")]
    public double? AvailabilityZoneCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderClusterConfig
{
    /// <summary>Configuration block containing cold storage configuration. Detailed below.</summary>
    [JsonPropertyName("coldStorageOptions")]
    public IList<V1beta1DomainSpecForProviderClusterConfigColdStorageOptions>? ColdStorageOptions { get; set; }

    /// <summary>Number of dedicated main nodes in the cluster.</summary>
    [JsonPropertyName("dedicatedMasterCount")]
    public double? DedicatedMasterCount { get; set; }

    /// <summary>Whether dedicated main nodes are enabled for the cluster.</summary>
    [JsonPropertyName("dedicatedMasterEnabled")]
    public bool? DedicatedMasterEnabled { get; set; }

    /// <summary>Instance type of the dedicated main nodes in the cluster.</summary>
    [JsonPropertyName("dedicatedMasterType")]
    public string? DedicatedMasterType { get; set; }

    /// <summary>Number of instances in the cluster.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>Instance type of data nodes in the cluster.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Number of warm nodes in the cluster. Valid values are between 2 and 150. warm_count can be only and must be set when warm_enabled is set to true.</summary>
    [JsonPropertyName("warmCount")]
    public double? WarmCount { get; set; }

    /// <summary>Whether to enable warm storage.</summary>
    [JsonPropertyName("warmEnabled")]
    public bool? WarmEnabled { get; set; }

    /// <summary>Instance type for the Elasticsearch cluster's warm nodes. Valid values are ultrawarm1.medium.elasticsearch, ultrawarm1.large.elasticsearch and ultrawarm1.xlarge.elasticsearch. warm_type can be only and must be set when warm_enabled is set to true.</summary>
    [JsonPropertyName("warmType")]
    public string? WarmType { get; set; }

    /// <summary>Configuration block containing zone awareness settings. Detailed below.</summary>
    [JsonPropertyName("zoneAwarenessConfig")]
    public IList<V1beta1DomainSpecForProviderClusterConfigZoneAwarenessConfig>? ZoneAwarenessConfig { get; set; }

    /// <summary>Whether zone awareness is enabled, set to true for multi-az deployment. To enable awareness with three Availability Zones, the availability_zone_count within the zone_awareness_config must be set to 3.</summary>
    [JsonPropertyName("zoneAwarenessEnabled")]
    public bool? ZoneAwarenessEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderCognitoOptions
{
    /// <summary>Whether Amazon Cognito authentication with Kibana is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ID of the Cognito Identity Pool to use.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>ARN of the IAM role that has the AmazonESCognitoAccess policy attached.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>ID of the Cognito User Pool to use.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderDomainEndpointOptions
{
    /// <summary>Fully qualified domain for your custom endpoint.</summary>
    [JsonPropertyName("customEndpoint")]
    public string? CustomEndpoint { get; set; }

    /// <summary>ACM certificate ARN for your custom endpoint.</summary>
    [JsonPropertyName("customEndpointCertificateArn")]
    public string? CustomEndpointCertificateArn { get; set; }

    /// <summary>Whether to enable custom endpoint for the Elasticsearch domain.</summary>
    [JsonPropertyName("customEndpointEnabled")]
    public bool? CustomEndpointEnabled { get; set; }

    /// <summary>Whether or not to require HTTPS. Defaults to true.</summary>
    [JsonPropertyName("enforceHttps")]
    public bool? EnforceHttps { get; set; }

    /// <summary>Name of the TLS security policy that needs to be applied to the HTTPS endpoint. Valid values:  Policy-Min-TLS-1-0-2019-07 and Policy-Min-TLS-1-2-2019-07.</summary>
    [JsonPropertyName("tlsSecurityPolicy")]
    public string? TlsSecurityPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderEbsOptions
{
    /// <summary>Whether EBS volumes are attached to data nodes in the domain.</summary>
    [JsonPropertyName("ebsEnabled")]
    public bool? EbsEnabled { get; set; }

    /// <summary>Baseline input/output (I/O) performance of EBS volumes attached to data nodes. Applicable only for the GP3 and Provisioned IOPS EBS volume types.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Specifies the throughput (in MiB/s) of the EBS volumes attached to data nodes. Applicable only for the gp3 volume type.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of EBS volumes attached to data nodes (in GiB).</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of EBS volumes attached to data nodes.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderEncryptAtRest
{
    /// <summary>Whether to enable encryption at rest. If the encrypt_at_rest block is not provided then this defaults to false. Enabling encryption on new domains requires elasticsearch_version 5.1 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KMS key ARN to encrypt the Elasticsearch domain with. If not specified then it defaults to using the aws/es service KMS key. Note that KMS will accept a KMS key ID but will return the key ARN.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderLogPublishingOptions
{
    /// <summary>ARN of the Cloudwatch log group to which log needs to be published.</summary>
    [JsonPropertyName("cloudwatchLogGroupArn")]
    public string? CloudwatchLogGroupArn { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
    [JsonPropertyName("cloudwatchLogGroupArnRef")]
    public V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnRef? CloudwatchLogGroupArnRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
    [JsonPropertyName("cloudwatchLogGroupArnSelector")]
    public V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnSelector? CloudwatchLogGroupArnSelector { get; set; }

    /// <summary>Whether given log publishing option is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Type of Elasticsearch log. Valid values: INDEX_SLOW_LOGS, SEARCH_SLOW_LOGS, ES_APPLICATION_LOGS, AUDIT_LOGS.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderNodeToNodeEncryption
{
    /// <summary>Whether to enable node-to-node encryption. If the node_to_node_encryption block is not provided then this defaults to false. Enabling node-to-node encryption of a new domain requires an elasticsearch_version of 6.0 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderSnapshotOptions
{
    /// <summary>Hour during which the service takes an automated daily snapshot of the indices in the domain.</summary>
    [JsonPropertyName("automatedSnapshotStartHour")]
    public double? AutomatedSnapshotStartHour { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdsRefsPolicy
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
public partial class V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderVpcOptions
{
    /// <summary>List of VPC Security Group IDs to be applied to the Elasticsearch domain endpoints. If omitted, the default Security Group for the VPC will be used.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsRefs")]
    public IList<V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdsRefs>? SecurityGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsSelector")]
    public V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdsSelector? SecurityGroupIdsSelector { get; set; }

    /// <summary>List of VPC Subnet IDs for the Elasticsearch domain endpoints to be created in.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProvider
{
    /// <summary>IAM policy document specifying the access policies for the domain.</summary>
    [JsonPropertyName("accessPolicies")]
    public string? AccessPolicies { get; set; }

    /// <summary>Key-value string pairs to specify advanced configuration options.</summary>
    [JsonPropertyName("advancedOptions")]
    public IDictionary<string, string>? AdvancedOptions { get; set; }

    /// <summary>Configuration block for fine-grained access control. Detailed below.</summary>
    [JsonPropertyName("advancedSecurityOptions")]
    public IList<V1beta1DomainSpecForProviderAdvancedSecurityOptions>? AdvancedSecurityOptions { get; set; }

    /// <summary>Configuration block for the Auto-Tune options of the domain. Detailed below.</summary>
    [JsonPropertyName("autoTuneOptions")]
    public IList<V1beta1DomainSpecForProviderAutoTuneOptions>? AutoTuneOptions { get; set; }

    /// <summary>Configuration block for the cluster of the domain. Detailed below.</summary>
    [JsonPropertyName("clusterConfig")]
    public IList<V1beta1DomainSpecForProviderClusterConfig>? ClusterConfig { get; set; }

    /// <summary>Configuration block for authenticating Kibana with Cognito. Detailed below.</summary>
    [JsonPropertyName("cognitoOptions")]
    public IList<V1beta1DomainSpecForProviderCognitoOptions>? CognitoOptions { get; set; }

    /// <summary>Configuration block for domain endpoint HTTP(S) related options. Detailed below.</summary>
    [JsonPropertyName("domainEndpointOptions")]
    public IList<V1beta1DomainSpecForProviderDomainEndpointOptions>? DomainEndpointOptions { get; set; }

    /// <summary>Configuration block for EBS related options, may be required based on chosen instance size. Detailed below.</summary>
    [JsonPropertyName("ebsOptions")]
    public IList<V1beta1DomainSpecForProviderEbsOptions>? EbsOptions { get; set; }

    /// <summary>Version of Elasticsearch to deploy. Defaults to 1.5.</summary>
    [JsonPropertyName("elasticsearchVersion")]
    public string? ElasticsearchVersion { get; set; }

    /// <summary>Configuration block for encrypt at rest options. Only available for certain instance types. Detailed below.</summary>
    [JsonPropertyName("encryptAtRest")]
    public IList<V1beta1DomainSpecForProviderEncryptAtRest>? EncryptAtRest { get; set; }

    /// <summary>Configuration block for publishing slow and application logs to CloudWatch Logs. This block can be declared multiple times, for each log_type, within the same resource. Detailed below.</summary>
    [JsonPropertyName("logPublishingOptions")]
    public IList<V1beta1DomainSpecForProviderLogPublishingOptions>? LogPublishingOptions { get; set; }

    /// <summary>Configuration block for node-to-node encryption options. Detailed below.</summary>
    [JsonPropertyName("nodeToNodeEncryption")]
    public IList<V1beta1DomainSpecForProviderNodeToNodeEncryption>? NodeToNodeEncryption { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Configuration block for snapshot related options. Detailed below. DEPRECATED. For domains running Elasticsearch 5.3 and later, Amazon ES takes hourly automated snapshots, making this setting irrelevant. For domains running earlier versions of Elasticsearch, Amazon ES takes daily automated snapshots.</summary>
    [JsonPropertyName("snapshotOptions")]
    public IList<V1beta1DomainSpecForProviderSnapshotOptions>? SnapshotOptions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for VPC related options. Adding or removing this configuration forces a new resource (documentation). Detailed below.</summary>
    [JsonPropertyName("vpcOptions")]
    public IList<V1beta1DomainSpecForProviderVpcOptions>? VpcOptions { get; set; }
}

/// <summary>Main user's password, which is stored in the Amazon Elasticsearch Service domain's internal database. Only specify if internal_user_database_enabled is set to true.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderAdvancedSecurityOptionsMasterUserOptionsMasterUserPasswordSecretRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderAdvancedSecurityOptionsMasterUserOptions
{
    /// <summary>ARN for the main user. Only specify if internal_user_database_enabled is not set or set to false.</summary>
    [JsonPropertyName("masterUserArn")]
    public string? MasterUserArn { get; set; }

    /// <summary>Main user's username, which is stored in the Amazon Elasticsearch Service domain's internal database. Only specify if internal_user_database_enabled is set to true.</summary>
    [JsonPropertyName("masterUserName")]
    public string? MasterUserName { get; set; }

    /// <summary>Main user's password, which is stored in the Amazon Elasticsearch Service domain's internal database. Only specify if internal_user_database_enabled is set to true.</summary>
    [JsonPropertyName("masterUserPasswordSecretRef")]
    public V1beta1DomainSpecInitProviderAdvancedSecurityOptionsMasterUserOptionsMasterUserPasswordSecretRef? MasterUserPasswordSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderAdvancedSecurityOptions
{
    /// <summary>Whether advanced security is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether the internal user database is enabled. If not set, defaults to false by the AWS API.</summary>
    [JsonPropertyName("internalUserDatabaseEnabled")]
    public bool? InternalUserDatabaseEnabled { get; set; }

    /// <summary>Configuration block for the main user. Detailed below.</summary>
    [JsonPropertyName("masterUserOptions")]
    public IList<V1beta1DomainSpecInitProviderAdvancedSecurityOptionsMasterUserOptions>? MasterUserOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderAutoTuneOptionsMaintenanceScheduleDuration
{
    /// <summary>The unit of time specifying the duration of an Auto-Tune maintenance window. Valid values: HOURS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>An integer specifying the value of the duration of an Auto-Tune maintenance window.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderAutoTuneOptionsMaintenanceSchedule
{
    /// <summary>A cron expression specifying the recurrence pattern for an Auto-Tune maintenance schedule.</summary>
    [JsonPropertyName("cronExpressionForRecurrence")]
    public string? CronExpressionForRecurrence { get; set; }

    /// <summary>Configuration block for the duration of the Auto-Tune maintenance window. Detailed below.</summary>
    [JsonPropertyName("duration")]
    public IList<V1beta1DomainSpecInitProviderAutoTuneOptionsMaintenanceScheduleDuration>? Duration { get; set; }

    /// <summary>Date and time at which to start the Auto-Tune maintenance schedule in RFC3339 format.</summary>
    [JsonPropertyName("startAt")]
    public string? StartAt { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderAutoTuneOptions
{
    /// <summary>The Auto-Tune desired state for the domain. Valid values: ENABLED or DISABLED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>Configuration block for Auto-Tune maintenance windows. Can be specified multiple times for each maintenance window. Detailed below.</summary>
    [JsonPropertyName("maintenanceSchedule")]
    public IList<V1beta1DomainSpecInitProviderAutoTuneOptionsMaintenanceSchedule>? MaintenanceSchedule { get; set; }

    /// <summary>Whether to roll back to default Auto-Tune settings when disabling Auto-Tune. Valid values: DEFAULT_ROLLBACK or NO_ROLLBACK.</summary>
    [JsonPropertyName("rollbackOnDisable")]
    public string? RollbackOnDisable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderClusterConfigColdStorageOptions
{
    /// <summary>Boolean to enable cold storage for an Elasticsearch domain. Defaults to false. Master and ultrawarm nodes must be enabled for cold storage.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderClusterConfigZoneAwarenessConfig
{
    /// <summary>Number of Availability Zones for the domain to use with zone_awareness_enabled. Defaults to 2. Valid values: 2 or 3.</summary>
    [JsonPropertyName("availabilityZoneCount")]
    public double? AvailabilityZoneCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderClusterConfig
{
    /// <summary>Configuration block containing cold storage configuration. Detailed below.</summary>
    [JsonPropertyName("coldStorageOptions")]
    public IList<V1beta1DomainSpecInitProviderClusterConfigColdStorageOptions>? ColdStorageOptions { get; set; }

    /// <summary>Number of dedicated main nodes in the cluster.</summary>
    [JsonPropertyName("dedicatedMasterCount")]
    public double? DedicatedMasterCount { get; set; }

    /// <summary>Whether dedicated main nodes are enabled for the cluster.</summary>
    [JsonPropertyName("dedicatedMasterEnabled")]
    public bool? DedicatedMasterEnabled { get; set; }

    /// <summary>Instance type of the dedicated main nodes in the cluster.</summary>
    [JsonPropertyName("dedicatedMasterType")]
    public string? DedicatedMasterType { get; set; }

    /// <summary>Number of instances in the cluster.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>Instance type of data nodes in the cluster.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Number of warm nodes in the cluster. Valid values are between 2 and 150. warm_count can be only and must be set when warm_enabled is set to true.</summary>
    [JsonPropertyName("warmCount")]
    public double? WarmCount { get; set; }

    /// <summary>Whether to enable warm storage.</summary>
    [JsonPropertyName("warmEnabled")]
    public bool? WarmEnabled { get; set; }

    /// <summary>Instance type for the Elasticsearch cluster's warm nodes. Valid values are ultrawarm1.medium.elasticsearch, ultrawarm1.large.elasticsearch and ultrawarm1.xlarge.elasticsearch. warm_type can be only and must be set when warm_enabled is set to true.</summary>
    [JsonPropertyName("warmType")]
    public string? WarmType { get; set; }

    /// <summary>Configuration block containing zone awareness settings. Detailed below.</summary>
    [JsonPropertyName("zoneAwarenessConfig")]
    public IList<V1beta1DomainSpecInitProviderClusterConfigZoneAwarenessConfig>? ZoneAwarenessConfig { get; set; }

    /// <summary>Whether zone awareness is enabled, set to true for multi-az deployment. To enable awareness with three Availability Zones, the availability_zone_count within the zone_awareness_config must be set to 3.</summary>
    [JsonPropertyName("zoneAwarenessEnabled")]
    public bool? ZoneAwarenessEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderCognitoOptions
{
    /// <summary>Whether Amazon Cognito authentication with Kibana is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ID of the Cognito Identity Pool to use.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>ARN of the IAM role that has the AmazonESCognitoAccess policy attached.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>ID of the Cognito User Pool to use.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderDomainEndpointOptions
{
    /// <summary>Fully qualified domain for your custom endpoint.</summary>
    [JsonPropertyName("customEndpoint")]
    public string? CustomEndpoint { get; set; }

    /// <summary>ACM certificate ARN for your custom endpoint.</summary>
    [JsonPropertyName("customEndpointCertificateArn")]
    public string? CustomEndpointCertificateArn { get; set; }

    /// <summary>Whether to enable custom endpoint for the Elasticsearch domain.</summary>
    [JsonPropertyName("customEndpointEnabled")]
    public bool? CustomEndpointEnabled { get; set; }

    /// <summary>Whether or not to require HTTPS. Defaults to true.</summary>
    [JsonPropertyName("enforceHttps")]
    public bool? EnforceHttps { get; set; }

    /// <summary>Name of the TLS security policy that needs to be applied to the HTTPS endpoint. Valid values:  Policy-Min-TLS-1-0-2019-07 and Policy-Min-TLS-1-2-2019-07.</summary>
    [JsonPropertyName("tlsSecurityPolicy")]
    public string? TlsSecurityPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderEbsOptions
{
    /// <summary>Whether EBS volumes are attached to data nodes in the domain.</summary>
    [JsonPropertyName("ebsEnabled")]
    public bool? EbsEnabled { get; set; }

    /// <summary>Baseline input/output (I/O) performance of EBS volumes attached to data nodes. Applicable only for the GP3 and Provisioned IOPS EBS volume types.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Specifies the throughput (in MiB/s) of the EBS volumes attached to data nodes. Applicable only for the gp3 volume type.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of EBS volumes attached to data nodes (in GiB).</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of EBS volumes attached to data nodes.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderEncryptAtRest
{
    /// <summary>Whether to enable encryption at rest. If the encrypt_at_rest block is not provided then this defaults to false. Enabling encryption on new domains requires elasticsearch_version 5.1 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KMS key ARN to encrypt the Elasticsearch domain with. If not specified then it defaults to using the aws/es service KMS key. Note that KMS will accept a KMS key ID but will return the key ARN.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderLogPublishingOptions
{
    /// <summary>ARN of the Cloudwatch log group to which log needs to be published.</summary>
    [JsonPropertyName("cloudwatchLogGroupArn")]
    public string? CloudwatchLogGroupArn { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
    [JsonPropertyName("cloudwatchLogGroupArnRef")]
    public V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnRef? CloudwatchLogGroupArnRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
    [JsonPropertyName("cloudwatchLogGroupArnSelector")]
    public V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnSelector? CloudwatchLogGroupArnSelector { get; set; }

    /// <summary>Whether given log publishing option is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Type of Elasticsearch log. Valid values: INDEX_SLOW_LOGS, SEARCH_SLOW_LOGS, ES_APPLICATION_LOGS, AUDIT_LOGS.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderNodeToNodeEncryption
{
    /// <summary>Whether to enable node-to-node encryption. If the node_to_node_encryption block is not provided then this defaults to false. Enabling node-to-node encryption of a new domain requires an elasticsearch_version of 6.0 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderSnapshotOptions
{
    /// <summary>Hour during which the service takes an automated daily snapshot of the indices in the domain.</summary>
    [JsonPropertyName("automatedSnapshotStartHour")]
    public double? AutomatedSnapshotStartHour { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdsRefsPolicy
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
public partial class V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderVpcOptions
{
    /// <summary>List of VPC Security Group IDs to be applied to the Elasticsearch domain endpoints. If omitted, the default Security Group for the VPC will be used.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsRefs")]
    public IList<V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdsRefs>? SecurityGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsSelector")]
    public V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdsSelector? SecurityGroupIdsSelector { get; set; }

    /// <summary>List of VPC Subnet IDs for the Elasticsearch domain endpoints to be created in.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProvider
{
    /// <summary>IAM policy document specifying the access policies for the domain.</summary>
    [JsonPropertyName("accessPolicies")]
    public string? AccessPolicies { get; set; }

    /// <summary>Key-value string pairs to specify advanced configuration options.</summary>
    [JsonPropertyName("advancedOptions")]
    public IDictionary<string, string>? AdvancedOptions { get; set; }

    /// <summary>Configuration block for fine-grained access control. Detailed below.</summary>
    [JsonPropertyName("advancedSecurityOptions")]
    public IList<V1beta1DomainSpecInitProviderAdvancedSecurityOptions>? AdvancedSecurityOptions { get; set; }

    /// <summary>Configuration block for the Auto-Tune options of the domain. Detailed below.</summary>
    [JsonPropertyName("autoTuneOptions")]
    public IList<V1beta1DomainSpecInitProviderAutoTuneOptions>? AutoTuneOptions { get; set; }

    /// <summary>Configuration block for the cluster of the domain. Detailed below.</summary>
    [JsonPropertyName("clusterConfig")]
    public IList<V1beta1DomainSpecInitProviderClusterConfig>? ClusterConfig { get; set; }

    /// <summary>Configuration block for authenticating Kibana with Cognito. Detailed below.</summary>
    [JsonPropertyName("cognitoOptions")]
    public IList<V1beta1DomainSpecInitProviderCognitoOptions>? CognitoOptions { get; set; }

    /// <summary>Configuration block for domain endpoint HTTP(S) related options. Detailed below.</summary>
    [JsonPropertyName("domainEndpointOptions")]
    public IList<V1beta1DomainSpecInitProviderDomainEndpointOptions>? DomainEndpointOptions { get; set; }

    /// <summary>Configuration block for EBS related options, may be required based on chosen instance size. Detailed below.</summary>
    [JsonPropertyName("ebsOptions")]
    public IList<V1beta1DomainSpecInitProviderEbsOptions>? EbsOptions { get; set; }

    /// <summary>Version of Elasticsearch to deploy. Defaults to 1.5.</summary>
    [JsonPropertyName("elasticsearchVersion")]
    public string? ElasticsearchVersion { get; set; }

    /// <summary>Configuration block for encrypt at rest options. Only available for certain instance types. Detailed below.</summary>
    [JsonPropertyName("encryptAtRest")]
    public IList<V1beta1DomainSpecInitProviderEncryptAtRest>? EncryptAtRest { get; set; }

    /// <summary>Configuration block for publishing slow and application logs to CloudWatch Logs. This block can be declared multiple times, for each log_type, within the same resource. Detailed below.</summary>
    [JsonPropertyName("logPublishingOptions")]
    public IList<V1beta1DomainSpecInitProviderLogPublishingOptions>? LogPublishingOptions { get; set; }

    /// <summary>Configuration block for node-to-node encryption options. Detailed below.</summary>
    [JsonPropertyName("nodeToNodeEncryption")]
    public IList<V1beta1DomainSpecInitProviderNodeToNodeEncryption>? NodeToNodeEncryption { get; set; }

    /// <summary>Configuration block for snapshot related options. Detailed below. DEPRECATED. For domains running Elasticsearch 5.3 and later, Amazon ES takes hourly automated snapshots, making this setting irrelevant. For domains running earlier versions of Elasticsearch, Amazon ES takes daily automated snapshots.</summary>
    [JsonPropertyName("snapshotOptions")]
    public IList<V1beta1DomainSpecInitProviderSnapshotOptions>? SnapshotOptions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for VPC related options. Adding or removing this configuration forces a new resource (documentation). Detailed below.</summary>
    [JsonPropertyName("vpcOptions")]
    public IList<V1beta1DomainSpecInitProviderVpcOptions>? VpcOptions { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecProviderConfigRefPolicy
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
public partial class V1beta1DomainSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1DomainSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1DomainSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1DomainSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1DomainSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>DomainSpec defines the desired state of Domain</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DomainSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DomainSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DomainSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1DomainSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DomainSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderAdvancedSecurityOptionsMasterUserOptions
{
    /// <summary>ARN for the main user. Only specify if internal_user_database_enabled is not set or set to false.</summary>
    [JsonPropertyName("masterUserArn")]
    public string? MasterUserArn { get; set; }

    /// <summary>Main user's username, which is stored in the Amazon Elasticsearch Service domain's internal database. Only specify if internal_user_database_enabled is set to true.</summary>
    [JsonPropertyName("masterUserName")]
    public string? MasterUserName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderAdvancedSecurityOptions
{
    /// <summary>Whether advanced security is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether the internal user database is enabled. If not set, defaults to false by the AWS API.</summary>
    [JsonPropertyName("internalUserDatabaseEnabled")]
    public bool? InternalUserDatabaseEnabled { get; set; }

    /// <summary>Configuration block for the main user. Detailed below.</summary>
    [JsonPropertyName("masterUserOptions")]
    public IList<V1beta1DomainStatusAtProviderAdvancedSecurityOptionsMasterUserOptions>? MasterUserOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderAutoTuneOptionsMaintenanceScheduleDuration
{
    /// <summary>The unit of time specifying the duration of an Auto-Tune maintenance window. Valid values: HOURS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>An integer specifying the value of the duration of an Auto-Tune maintenance window.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderAutoTuneOptionsMaintenanceSchedule
{
    /// <summary>A cron expression specifying the recurrence pattern for an Auto-Tune maintenance schedule.</summary>
    [JsonPropertyName("cronExpressionForRecurrence")]
    public string? CronExpressionForRecurrence { get; set; }

    /// <summary>Configuration block for the duration of the Auto-Tune maintenance window. Detailed below.</summary>
    [JsonPropertyName("duration")]
    public IList<V1beta1DomainStatusAtProviderAutoTuneOptionsMaintenanceScheduleDuration>? Duration { get; set; }

    /// <summary>Date and time at which to start the Auto-Tune maintenance schedule in RFC3339 format.</summary>
    [JsonPropertyName("startAt")]
    public string? StartAt { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderAutoTuneOptions
{
    /// <summary>The Auto-Tune desired state for the domain. Valid values: ENABLED or DISABLED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>Configuration block for Auto-Tune maintenance windows. Can be specified multiple times for each maintenance window. Detailed below.</summary>
    [JsonPropertyName("maintenanceSchedule")]
    public IList<V1beta1DomainStatusAtProviderAutoTuneOptionsMaintenanceSchedule>? MaintenanceSchedule { get; set; }

    /// <summary>Whether to roll back to default Auto-Tune settings when disabling Auto-Tune. Valid values: DEFAULT_ROLLBACK or NO_ROLLBACK.</summary>
    [JsonPropertyName("rollbackOnDisable")]
    public string? RollbackOnDisable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderClusterConfigColdStorageOptions
{
    /// <summary>Boolean to enable cold storage for an Elasticsearch domain. Defaults to false. Master and ultrawarm nodes must be enabled for cold storage.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderClusterConfigZoneAwarenessConfig
{
    /// <summary>Number of Availability Zones for the domain to use with zone_awareness_enabled. Defaults to 2. Valid values: 2 or 3.</summary>
    [JsonPropertyName("availabilityZoneCount")]
    public double? AvailabilityZoneCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderClusterConfig
{
    /// <summary>Configuration block containing cold storage configuration. Detailed below.</summary>
    [JsonPropertyName("coldStorageOptions")]
    public IList<V1beta1DomainStatusAtProviderClusterConfigColdStorageOptions>? ColdStorageOptions { get; set; }

    /// <summary>Number of dedicated main nodes in the cluster.</summary>
    [JsonPropertyName("dedicatedMasterCount")]
    public double? DedicatedMasterCount { get; set; }

    /// <summary>Whether dedicated main nodes are enabled for the cluster.</summary>
    [JsonPropertyName("dedicatedMasterEnabled")]
    public bool? DedicatedMasterEnabled { get; set; }

    /// <summary>Instance type of the dedicated main nodes in the cluster.</summary>
    [JsonPropertyName("dedicatedMasterType")]
    public string? DedicatedMasterType { get; set; }

    /// <summary>Number of instances in the cluster.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>Instance type of data nodes in the cluster.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Number of warm nodes in the cluster. Valid values are between 2 and 150. warm_count can be only and must be set when warm_enabled is set to true.</summary>
    [JsonPropertyName("warmCount")]
    public double? WarmCount { get; set; }

    /// <summary>Whether to enable warm storage.</summary>
    [JsonPropertyName("warmEnabled")]
    public bool? WarmEnabled { get; set; }

    /// <summary>Instance type for the Elasticsearch cluster's warm nodes. Valid values are ultrawarm1.medium.elasticsearch, ultrawarm1.large.elasticsearch and ultrawarm1.xlarge.elasticsearch. warm_type can be only and must be set when warm_enabled is set to true.</summary>
    [JsonPropertyName("warmType")]
    public string? WarmType { get; set; }

    /// <summary>Configuration block containing zone awareness settings. Detailed below.</summary>
    [JsonPropertyName("zoneAwarenessConfig")]
    public IList<V1beta1DomainStatusAtProviderClusterConfigZoneAwarenessConfig>? ZoneAwarenessConfig { get; set; }

    /// <summary>Whether zone awareness is enabled, set to true for multi-az deployment. To enable awareness with three Availability Zones, the availability_zone_count within the zone_awareness_config must be set to 3.</summary>
    [JsonPropertyName("zoneAwarenessEnabled")]
    public bool? ZoneAwarenessEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderCognitoOptions
{
    /// <summary>Whether Amazon Cognito authentication with Kibana is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ID of the Cognito Identity Pool to use.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>ARN of the IAM role that has the AmazonESCognitoAccess policy attached.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>ID of the Cognito User Pool to use.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderDomainEndpointOptions
{
    /// <summary>Fully qualified domain for your custom endpoint.</summary>
    [JsonPropertyName("customEndpoint")]
    public string? CustomEndpoint { get; set; }

    /// <summary>ACM certificate ARN for your custom endpoint.</summary>
    [JsonPropertyName("customEndpointCertificateArn")]
    public string? CustomEndpointCertificateArn { get; set; }

    /// <summary>Whether to enable custom endpoint for the Elasticsearch domain.</summary>
    [JsonPropertyName("customEndpointEnabled")]
    public bool? CustomEndpointEnabled { get; set; }

    /// <summary>Whether or not to require HTTPS. Defaults to true.</summary>
    [JsonPropertyName("enforceHttps")]
    public bool? EnforceHttps { get; set; }

    /// <summary>Name of the TLS security policy that needs to be applied to the HTTPS endpoint. Valid values:  Policy-Min-TLS-1-0-2019-07 and Policy-Min-TLS-1-2-2019-07.</summary>
    [JsonPropertyName("tlsSecurityPolicy")]
    public string? TlsSecurityPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderEbsOptions
{
    /// <summary>Whether EBS volumes are attached to data nodes in the domain.</summary>
    [JsonPropertyName("ebsEnabled")]
    public bool? EbsEnabled { get; set; }

    /// <summary>Baseline input/output (I/O) performance of EBS volumes attached to data nodes. Applicable only for the GP3 and Provisioned IOPS EBS volume types.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Specifies the throughput (in MiB/s) of the EBS volumes attached to data nodes. Applicable only for the gp3 volume type.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of EBS volumes attached to data nodes (in GiB).</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of EBS volumes attached to data nodes.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderEncryptAtRest
{
    /// <summary>Whether to enable encryption at rest. If the encrypt_at_rest block is not provided then this defaults to false. Enabling encryption on new domains requires elasticsearch_version 5.1 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KMS key ARN to encrypt the Elasticsearch domain with. If not specified then it defaults to using the aws/es service KMS key. Note that KMS will accept a KMS key ID but will return the key ARN.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderLogPublishingOptions
{
    /// <summary>ARN of the Cloudwatch log group to which log needs to be published.</summary>
    [JsonPropertyName("cloudwatchLogGroupArn")]
    public string? CloudwatchLogGroupArn { get; set; }

    /// <summary>Whether given log publishing option is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Type of Elasticsearch log. Valid values: INDEX_SLOW_LOGS, SEARCH_SLOW_LOGS, ES_APPLICATION_LOGS, AUDIT_LOGS.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderNodeToNodeEncryption
{
    /// <summary>Whether to enable node-to-node encryption. If the node_to_node_encryption block is not provided then this defaults to false. Enabling node-to-node encryption of a new domain requires an elasticsearch_version of 6.0 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderSnapshotOptions
{
    /// <summary>Hour during which the service takes an automated daily snapshot of the indices in the domain.</summary>
    [JsonPropertyName("automatedSnapshotStartHour")]
    public double? AutomatedSnapshotStartHour { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderVpcOptions
{
    /// <summary>If the domain was created inside a VPC, the names of the availability zones the configured subnet_ids were created inside.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>List of VPC Security Group IDs to be applied to the Elasticsearch domain endpoints. If omitted, the default Security Group for the VPC will be used.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>List of VPC Subnet IDs for the Elasticsearch domain endpoints to be created in.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>If the domain was created inside a VPC, the ID of the VPC.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProvider
{
    /// <summary>IAM policy document specifying the access policies for the domain.</summary>
    [JsonPropertyName("accessPolicies")]
    public string? AccessPolicies { get; set; }

    /// <summary>Key-value string pairs to specify advanced configuration options.</summary>
    [JsonPropertyName("advancedOptions")]
    public IDictionary<string, string>? AdvancedOptions { get; set; }

    /// <summary>Configuration block for fine-grained access control. Detailed below.</summary>
    [JsonPropertyName("advancedSecurityOptions")]
    public IList<V1beta1DomainStatusAtProviderAdvancedSecurityOptions>? AdvancedSecurityOptions { get; set; }

    /// <summary>ARN of the domain.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Configuration block for the Auto-Tune options of the domain. Detailed below.</summary>
    [JsonPropertyName("autoTuneOptions")]
    public IList<V1beta1DomainStatusAtProviderAutoTuneOptions>? AutoTuneOptions { get; set; }

    /// <summary>Configuration block for the cluster of the domain. Detailed below.</summary>
    [JsonPropertyName("clusterConfig")]
    public IList<V1beta1DomainStatusAtProviderClusterConfig>? ClusterConfig { get; set; }

    /// <summary>Configuration block for authenticating Kibana with Cognito. Detailed below.</summary>
    [JsonPropertyName("cognitoOptions")]
    public IList<V1beta1DomainStatusAtProviderCognitoOptions>? CognitoOptions { get; set; }

    /// <summary>Configuration block for domain endpoint HTTP(S) related options. Detailed below.</summary>
    [JsonPropertyName("domainEndpointOptions")]
    public IList<V1beta1DomainStatusAtProviderDomainEndpointOptions>? DomainEndpointOptions { get; set; }

    /// <summary>Unique identifier for the domain.</summary>
    [JsonPropertyName("domainId")]
    public string? DomainId { get; set; }

    /// <summary>Configuration block for EBS related options, may be required based on chosen instance size. Detailed below.</summary>
    [JsonPropertyName("ebsOptions")]
    public IList<V1beta1DomainStatusAtProviderEbsOptions>? EbsOptions { get; set; }

    /// <summary>Version of Elasticsearch to deploy. Defaults to 1.5.</summary>
    [JsonPropertyName("elasticsearchVersion")]
    public string? ElasticsearchVersion { get; set; }

    /// <summary>Configuration block for encrypt at rest options. Only available for certain instance types. Detailed below.</summary>
    [JsonPropertyName("encryptAtRest")]
    public IList<V1beta1DomainStatusAtProviderEncryptAtRest>? EncryptAtRest { get; set; }

    /// <summary>Domain-specific endpoint used to submit index, search, and data upload requests.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Domain-specific endpoint for kibana without https scheme.</summary>
    [JsonPropertyName("kibanaEndpoint")]
    public string? KibanaEndpoint { get; set; }

    /// <summary>Configuration block for publishing slow and application logs to CloudWatch Logs. This block can be declared multiple times, for each log_type, within the same resource. Detailed below.</summary>
    [JsonPropertyName("logPublishingOptions")]
    public IList<V1beta1DomainStatusAtProviderLogPublishingOptions>? LogPublishingOptions { get; set; }

    /// <summary>Configuration block for node-to-node encryption options. Detailed below.</summary>
    [JsonPropertyName("nodeToNodeEncryption")]
    public IList<V1beta1DomainStatusAtProviderNodeToNodeEncryption>? NodeToNodeEncryption { get; set; }

    /// <summary>Configuration block for snapshot related options. Detailed below. DEPRECATED. For domains running Elasticsearch 5.3 and later, Amazon ES takes hourly automated snapshots, making this setting irrelevant. For domains running earlier versions of Elasticsearch, Amazon ES takes daily automated snapshots.</summary>
    [JsonPropertyName("snapshotOptions")]
    public IList<V1beta1DomainStatusAtProviderSnapshotOptions>? SnapshotOptions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Configuration block for VPC related options. Adding or removing this configuration forces a new resource (documentation). Detailed below.</summary>
    [JsonPropertyName("vpcOptions")]
    public IList<V1beta1DomainStatusAtProviderVpcOptions>? VpcOptions { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusConditions
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

/// <summary>DomainStatus defines the observed state of Domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DomainStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DomainStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Domain is the Schema for the Domains API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Domain : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DomainSpec>, IStatus<V1beta1DomainStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Domain";
    public const string KubeGroup = "elasticsearch.aws.upbound.io";
    public const string KubePluralName = "domains";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DomainSpec defines the desired state of Domain</summary>
    [JsonPropertyName("spec")]
    public V1beta1DomainSpec Spec { get; set; }

    /// <summary>DomainStatus defines the observed state of Domain.</summary>
    [JsonPropertyName("status")]
    public V1beta1DomainStatus? Status { get; set; }
}