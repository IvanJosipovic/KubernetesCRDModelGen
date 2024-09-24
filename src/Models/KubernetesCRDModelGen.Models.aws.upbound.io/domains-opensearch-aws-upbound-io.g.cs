using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.opensearch.aws.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary>Main user's password, which is stored in the Amazon OpenSearch Service domain's internal database. Only specify if internal_user_database_enabled is set to true.</summary>
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

    /// <summary>Main user's username, which is stored in the Amazon OpenSearch Service domain's internal database. Only specify if internal_user_database_enabled is set to true.</summary>
    [JsonPropertyName("masterUserName")]
    public string? MasterUserName { get; set; }

    /// <summary>Main user's password, which is stored in the Amazon OpenSearch Service domain's internal database. Only specify if internal_user_database_enabled is set to true.</summary>
    [JsonPropertyName("masterUserPasswordSecretRef")]
    public V1beta1DomainSpecForProviderAdvancedSecurityOptionsMasterUserOptionsMasterUserPasswordSecretRef? MasterUserPasswordSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderAdvancedSecurityOptions
{
    /// <summary>Whether Anonymous auth is enabled. Enables fine-grained access control on an existing domain. Ignored unless advanced_security_options are enabled. Can only be enabled on an existing domain.</summary>
    [JsonPropertyName("anonymousAuthEnabled")]
    public bool? AnonymousAuthEnabled { get; set; }

    /// <summary>Whether advanced security is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether the internal user database is enabled. Default is false.</summary>
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
    /// <summary>Unit of time specifying the duration of an Auto-Tune maintenance window. Valid values: HOURS.</summary>
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
    /// <summary>Auto-Tune desired state for the domain. Valid values: ENABLED or DISABLED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>Configuration block for Auto-Tune maintenance windows. Can be specified multiple times for each maintenance window. Detailed below.</summary>
    [JsonPropertyName("maintenanceSchedule")]
    public IList<V1beta1DomainSpecForProviderAutoTuneOptionsMaintenanceSchedule>? MaintenanceSchedule { get; set; }

    /// <summary>Whether to roll back to default Auto-Tune settings when disabling Auto-Tune. Valid values: DEFAULT_ROLLBACK or NO_ROLLBACK.</summary>
    [JsonPropertyName("rollbackOnDisable")]
    public string? RollbackOnDisable { get; set; }

    /// <summary>Whether to schedule Auto-Tune optimizations that require blue/green deployments during the domain's configured daily off-peak window. Defaults to false.</summary>
    [JsonPropertyName("useOffPeakWindow")]
    public bool? UseOffPeakWindow { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderClusterConfigColdStorageOptions
{
    /// <summary>Boolean to enable cold storage for an OpenSearch domain. Defaults to false. Master and ultrawarm nodes must be enabled for cold storage.</summary>
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

    /// <summary>Whether a multi-AZ domain is turned on with a standby AZ. For more information, see Configuring a multi-AZ domain in Amazon OpenSearch Service.</summary>
    [JsonPropertyName("multiAzWithStandbyEnabled")]
    public bool? MultiAzWithStandbyEnabled { get; set; }

    /// <summary>Number of warm nodes in the cluster. Valid values are between 2 and 150. warm_count can be only and must be set when warm_enabled is set to true.</summary>
    [JsonPropertyName("warmCount")]
    public double? WarmCount { get; set; }

    /// <summary>Whether to enable warm storage.</summary>
    [JsonPropertyName("warmEnabled")]
    public bool? WarmEnabled { get; set; }

    /// <summary>Instance type for the OpenSearch cluster's warm nodes. Valid values are ultrawarm1.medium.search, ultrawarm1.large.search and ultrawarm1.xlarge.search. warm_type can be only and must be set when warm_enabled is set to true.</summary>
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
    /// <summary>Whether Amazon Cognito authentication with Dashboard is enabled or not. Default is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ID of the Cognito Identity Pool to use.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>ARN of the IAM role that has the AmazonOpenSearchServiceCognitoAccess policy attached.</summary>
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

    /// <summary>Whether to enable custom endpoint for the OpenSearch domain.</summary>
    [JsonPropertyName("customEndpointEnabled")]
    public bool? CustomEndpointEnabled { get; set; }

    /// <summary>Whether or not to require HTTPS. Defaults to true.</summary>
    [JsonPropertyName("enforceHttps")]
    public bool? EnforceHttps { get; set; }

    /// <summary>Name of the TLS security policy that needs to be applied to the HTTPS endpoint. For valid values, refer to the AWS documentation.</summary>
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecForProviderEncryptAtRestKmsKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecForProviderEncryptAtRestKmsKeyIdRefPolicyResolveEnum
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
public partial class V1beta1DomainSpecForProviderEncryptAtRestKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderEncryptAtRestKmsKeyIdRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderEncryptAtRestKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderEncryptAtRestKmsKeyIdRefPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderEncryptAtRestKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderEncryptAtRestKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderEncryptAtRestKmsKeyIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecForProviderEncryptAtRestKmsKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecForProviderEncryptAtRestKmsKeyIdSelectorPolicyResolveEnum
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
public partial class V1beta1DomainSpecForProviderEncryptAtRestKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderEncryptAtRestKmsKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderEncryptAtRestKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderEncryptAtRestKmsKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderEncryptAtRestKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderEncryptAtRestKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderEncryptAtRestKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderEncryptAtRest
{
    /// <summary>Whether to enable encryption at rest. If the encrypt_at_rest block is not provided then this defaults to false. Enabling encryption on new domains requires an engine_version of OpenSearch_X.Y or Elasticsearch_5.1 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KMS key ARN to encrypt the Elasticsearch domain with. If not specified then it defaults to using the aws/es service KMS key. Note that KMS will accept a KMS key ID but will return the key ARN.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1DomainSpecForProviderEncryptAtRestKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1DomainSpecForProviderEncryptAtRestKmsKeyIdSelector? KmsKeyIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolveEnum
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
public partial class V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolveEnum? Resolve { get; set; }
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolveEnum
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
public partial class V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolveEnum? Resolve { get; set; }
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

    /// <summary>Type of OpenSearch log. Valid values: INDEX_SLOW_LOGS, SEARCH_SLOW_LOGS, ES_APPLICATION_LOGS, AUDIT_LOGS.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderNodeToNodeEncryption
{
    /// <summary>Whether to enable node-to-node encryption. If the node_to_node_encryption block is not provided then this defaults to false. Enabling node-to-node encryption of a new domain requires an engine_version of OpenSearch_X.Y or Elasticsearch_6.0 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderOffPeakWindowOptionsOffPeakWindowWindowStartTime
{
    /// <summary>Starting hour of the 10-hour window for updates</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Starting minute of the 10-hour window for updates</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderOffPeakWindowOptionsOffPeakWindow
{
    /// <summary>10h window for updates</summary>
    [JsonPropertyName("windowStartTime")]
    public IList<V1beta1DomainSpecForProviderOffPeakWindowOptionsOffPeakWindowWindowStartTime>? WindowStartTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderOffPeakWindowOptions
{
    /// <summary>Enabled disabled toggle for off-peak update window.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("offPeakWindow")]
    public IList<V1beta1DomainSpecForProviderOffPeakWindowOptionsOffPeakWindow>? OffPeakWindow { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderSnapshotOptions
{
    /// <summary>Hour during which the service takes an automated daily snapshot of the indices in the domain.</summary>
    [JsonPropertyName("automatedSnapshotStartHour")]
    public double? AutomatedSnapshotStartHour { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderSoftwareUpdateOptions
{
    /// <summary>Whether automatic service software updates are enabled for the domain. Defaults to false.</summary>
    [JsonPropertyName("autoSoftwareUpdateEnabled")]
    public bool? AutoSoftwareUpdateEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdRefsPolicyResolveEnum
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
public partial class V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdRefsPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdSelectorPolicyResolveEnum
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
public partial class V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecForProviderVpcOptionsSubnetIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecForProviderVpcOptionsSubnetIdRefsPolicyResolveEnum
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
public partial class V1beta1DomainSpecForProviderVpcOptionsSubnetIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderVpcOptionsSubnetIdRefsPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderVpcOptionsSubnetIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderVpcOptionsSubnetIdRefsPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderVpcOptionsSubnetIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderVpcOptionsSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderVpcOptionsSubnetIdRefsPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecForProviderVpcOptionsSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecForProviderVpcOptionsSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1DomainSpecForProviderVpcOptionsSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderVpcOptionsSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1DomainSpecForProviderVpcOptionsSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecForProviderVpcOptionsSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1DomainSpecForProviderVpcOptionsSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderVpcOptionsSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecForProviderVpcOptionsSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderVpcOptions
{
    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdRefs")]
    public IList<V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdRefs>? SecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta1DomainSpecForProviderVpcOptionsSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>List of VPC Security Group IDs to be applied to the OpenSearch domain endpoints. If omitted, the default Security Group for the VPC will be used.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta1DomainSpecForProviderVpcOptionsSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1DomainSpecForProviderVpcOptionsSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>List of VPC Subnet IDs for the OpenSearch domain endpoints to be created in.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProvider
{
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

    /// <summary>Configuration block for authenticating dashboard with Cognito. Detailed below.</summary>
    [JsonPropertyName("cognitoOptions")]
    public IList<V1beta1DomainSpecForProviderCognitoOptions>? CognitoOptions { get; set; }

    /// <summary>Configuration block for domain endpoint HTTP(S) related options. Detailed below.</summary>
    [JsonPropertyName("domainEndpointOptions")]
    public IList<V1beta1DomainSpecForProviderDomainEndpointOptions>? DomainEndpointOptions { get; set; }

    /// <summary>Name of the domain.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Configuration block for EBS related options, may be required based on chosen instance size. Detailed below.</summary>
    [JsonPropertyName("ebsOptions")]
    public IList<V1beta1DomainSpecForProviderEbsOptions>? EbsOptions { get; set; }

    /// <summary>Configuration block for encrypt at rest options. Only available for certain instance types. Detailed below.</summary>
    [JsonPropertyName("encryptAtRest")]
    public IList<V1beta1DomainSpecForProviderEncryptAtRest>? EncryptAtRest { get; set; }

    /// <summary>while Elasticsearch has elasticsearch_version</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>The IP address type for the endpoint. Valid values are ipv4 and dualstack.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>Configuration block for publishing slow and application logs to CloudWatch Logs. This block can be declared multiple times, for each log_type, within the same resource. Detailed below.</summary>
    [JsonPropertyName("logPublishingOptions")]
    public IList<V1beta1DomainSpecForProviderLogPublishingOptions>? LogPublishingOptions { get; set; }

    /// <summary>Configuration block for node-to-node encryption options. Detailed below.</summary>
    [JsonPropertyName("nodeToNodeEncryption")]
    public IList<V1beta1DomainSpecForProviderNodeToNodeEncryption>? NodeToNodeEncryption { get; set; }

    /// <summary>Configuration to add Off Peak update options. (documentation). Detailed below.</summary>
    [JsonPropertyName("offPeakWindowOptions")]
    public IList<V1beta1DomainSpecForProviderOffPeakWindowOptions>? OffPeakWindowOptions { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Configuration block for snapshot related options. Detailed below. DEPRECATED. For domains running OpenSearch 5.3 and later, Amazon OpenSearch takes hourly automated snapshots, making this setting irrelevant. For domains running earlier versions, OpenSearch takes daily automated snapshots.</summary>
    [JsonPropertyName("snapshotOptions")]
    public IList<V1beta1DomainSpecForProviderSnapshotOptions>? SnapshotOptions { get; set; }

    /// <summary>Software update options for the domain. Detailed below.</summary>
    [JsonPropertyName("softwareUpdateOptions")]
    public IList<V1beta1DomainSpecForProviderSoftwareUpdateOptions>? SoftwareUpdateOptions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for VPC related options. Adding or removing this configuration forces a new resource (documentation). Detailed below.</summary>
    [JsonPropertyName("vpcOptions")]
    public IList<V1beta1DomainSpecForProviderVpcOptions>? VpcOptions { get; set; }
}

/// <summary>Main user's password, which is stored in the Amazon OpenSearch Service domain's internal database. Only specify if internal_user_database_enabled is set to true.</summary>
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

    /// <summary>Main user's username, which is stored in the Amazon OpenSearch Service domain's internal database. Only specify if internal_user_database_enabled is set to true.</summary>
    [JsonPropertyName("masterUserName")]
    public string? MasterUserName { get; set; }

    /// <summary>Main user's password, which is stored in the Amazon OpenSearch Service domain's internal database. Only specify if internal_user_database_enabled is set to true.</summary>
    [JsonPropertyName("masterUserPasswordSecretRef")]
    public V1beta1DomainSpecInitProviderAdvancedSecurityOptionsMasterUserOptionsMasterUserPasswordSecretRef? MasterUserPasswordSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderAdvancedSecurityOptions
{
    /// <summary>Whether Anonymous auth is enabled. Enables fine-grained access control on an existing domain. Ignored unless advanced_security_options are enabled. Can only be enabled on an existing domain.</summary>
    [JsonPropertyName("anonymousAuthEnabled")]
    public bool? AnonymousAuthEnabled { get; set; }

    /// <summary>Whether advanced security is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether the internal user database is enabled. Default is false.</summary>
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
    /// <summary>Unit of time specifying the duration of an Auto-Tune maintenance window. Valid values: HOURS.</summary>
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
    /// <summary>Auto-Tune desired state for the domain. Valid values: ENABLED or DISABLED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>Configuration block for Auto-Tune maintenance windows. Can be specified multiple times for each maintenance window. Detailed below.</summary>
    [JsonPropertyName("maintenanceSchedule")]
    public IList<V1beta1DomainSpecInitProviderAutoTuneOptionsMaintenanceSchedule>? MaintenanceSchedule { get; set; }

    /// <summary>Whether to roll back to default Auto-Tune settings when disabling Auto-Tune. Valid values: DEFAULT_ROLLBACK or NO_ROLLBACK.</summary>
    [JsonPropertyName("rollbackOnDisable")]
    public string? RollbackOnDisable { get; set; }

    /// <summary>Whether to schedule Auto-Tune optimizations that require blue/green deployments during the domain's configured daily off-peak window. Defaults to false.</summary>
    [JsonPropertyName("useOffPeakWindow")]
    public bool? UseOffPeakWindow { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderClusterConfigColdStorageOptions
{
    /// <summary>Boolean to enable cold storage for an OpenSearch domain. Defaults to false. Master and ultrawarm nodes must be enabled for cold storage.</summary>
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

    /// <summary>Whether a multi-AZ domain is turned on with a standby AZ. For more information, see Configuring a multi-AZ domain in Amazon OpenSearch Service.</summary>
    [JsonPropertyName("multiAzWithStandbyEnabled")]
    public bool? MultiAzWithStandbyEnabled { get; set; }

    /// <summary>Number of warm nodes in the cluster. Valid values are between 2 and 150. warm_count can be only and must be set when warm_enabled is set to true.</summary>
    [JsonPropertyName("warmCount")]
    public double? WarmCount { get; set; }

    /// <summary>Whether to enable warm storage.</summary>
    [JsonPropertyName("warmEnabled")]
    public bool? WarmEnabled { get; set; }

    /// <summary>Instance type for the OpenSearch cluster's warm nodes. Valid values are ultrawarm1.medium.search, ultrawarm1.large.search and ultrawarm1.xlarge.search. warm_type can be only and must be set when warm_enabled is set to true.</summary>
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
    /// <summary>Whether Amazon Cognito authentication with Dashboard is enabled or not. Default is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ID of the Cognito Identity Pool to use.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>ARN of the IAM role that has the AmazonOpenSearchServiceCognitoAccess policy attached.</summary>
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

    /// <summary>Whether to enable custom endpoint for the OpenSearch domain.</summary>
    [JsonPropertyName("customEndpointEnabled")]
    public bool? CustomEndpointEnabled { get; set; }

    /// <summary>Whether or not to require HTTPS. Defaults to true.</summary>
    [JsonPropertyName("enforceHttps")]
    public bool? EnforceHttps { get; set; }

    /// <summary>Name of the TLS security policy that needs to be applied to the HTTPS endpoint. For valid values, refer to the AWS documentation.</summary>
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecInitProviderEncryptAtRestKmsKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecInitProviderEncryptAtRestKmsKeyIdRefPolicyResolveEnum
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
public partial class V1beta1DomainSpecInitProviderEncryptAtRestKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderEncryptAtRestKmsKeyIdRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecInitProviderEncryptAtRestKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderEncryptAtRestKmsKeyIdRefPolicyResolveEnum>))]
    public V1beta1DomainSpecInitProviderEncryptAtRestKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderEncryptAtRestKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderEncryptAtRestKmsKeyIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecInitProviderEncryptAtRestKmsKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecInitProviderEncryptAtRestKmsKeyIdSelectorPolicyResolveEnum
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
public partial class V1beta1DomainSpecInitProviderEncryptAtRestKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderEncryptAtRestKmsKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1DomainSpecInitProviderEncryptAtRestKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderEncryptAtRestKmsKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1DomainSpecInitProviderEncryptAtRestKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderEncryptAtRestKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderEncryptAtRestKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderEncryptAtRest
{
    /// <summary>Whether to enable encryption at rest. If the encrypt_at_rest block is not provided then this defaults to false. Enabling encryption on new domains requires an engine_version of OpenSearch_X.Y or Elasticsearch_5.1 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KMS key ARN to encrypt the Elasticsearch domain with. If not specified then it defaults to using the aws/es service KMS key. Note that KMS will accept a KMS key ID but will return the key ARN.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1DomainSpecInitProviderEncryptAtRestKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1DomainSpecInitProviderEncryptAtRestKmsKeyIdSelector? KmsKeyIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolveEnum
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
public partial class V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolveEnum>))]
    public V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolveEnum? Resolve { get; set; }
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolveEnum
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
public partial class V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolutionEnum>))]
    public V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolveEnum>))]
    public V1beta1DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolveEnum? Resolve { get; set; }
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

    /// <summary>Type of OpenSearch log. Valid values: INDEX_SLOW_LOGS, SEARCH_SLOW_LOGS, ES_APPLICATION_LOGS, AUDIT_LOGS.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderNodeToNodeEncryption
{
    /// <summary>Whether to enable node-to-node encryption. If the node_to_node_encryption block is not provided then this defaults to false. Enabling node-to-node encryption of a new domain requires an engine_version of OpenSearch_X.Y or Elasticsearch_6.0 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderOffPeakWindowOptionsOffPeakWindowWindowStartTime
{
    /// <summary>Starting hour of the 10-hour window for updates</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Starting minute of the 10-hour window for updates</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderOffPeakWindowOptionsOffPeakWindow
{
    /// <summary>10h window for updates</summary>
    [JsonPropertyName("windowStartTime")]
    public IList<V1beta1DomainSpecInitProviderOffPeakWindowOptionsOffPeakWindowWindowStartTime>? WindowStartTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderOffPeakWindowOptions
{
    /// <summary>Enabled disabled toggle for off-peak update window.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("offPeakWindow")]
    public IList<V1beta1DomainSpecInitProviderOffPeakWindowOptionsOffPeakWindow>? OffPeakWindow { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderSnapshotOptions
{
    /// <summary>Hour during which the service takes an automated daily snapshot of the indices in the domain.</summary>
    [JsonPropertyName("automatedSnapshotStartHour")]
    public double? AutomatedSnapshotStartHour { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderSoftwareUpdateOptions
{
    /// <summary>Whether automatic service software updates are enabled for the domain. Defaults to false.</summary>
    [JsonPropertyName("autoSoftwareUpdateEnabled")]
    public bool? AutoSoftwareUpdateEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdRefsPolicyResolveEnum
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
public partial class V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdRefsPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdSelectorPolicyResolveEnum
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
public partial class V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecInitProviderVpcOptionsSubnetIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecInitProviderVpcOptionsSubnetIdRefsPolicyResolveEnum
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
public partial class V1beta1DomainSpecInitProviderVpcOptionsSubnetIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderVpcOptionsSubnetIdRefsPolicyResolutionEnum>))]
    public V1beta1DomainSpecInitProviderVpcOptionsSubnetIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderVpcOptionsSubnetIdRefsPolicyResolveEnum>))]
    public V1beta1DomainSpecInitProviderVpcOptionsSubnetIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderVpcOptionsSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderVpcOptionsSubnetIdRefsPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecInitProviderVpcOptionsSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecInitProviderVpcOptionsSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1DomainSpecInitProviderVpcOptionsSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderVpcOptionsSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1DomainSpecInitProviderVpcOptionsSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecInitProviderVpcOptionsSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1DomainSpecInitProviderVpcOptionsSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderVpcOptionsSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecInitProviderVpcOptionsSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderVpcOptions
{
    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdRefs")]
    public IList<V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdRefs>? SecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta1DomainSpecInitProviderVpcOptionsSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>List of VPC Security Group IDs to be applied to the OpenSearch domain endpoints. If omitted, the default Security Group for the VPC will be used.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta1DomainSpecInitProviderVpcOptionsSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1DomainSpecInitProviderVpcOptionsSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>List of VPC Subnet IDs for the OpenSearch domain endpoints to be created in.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProvider
{
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

    /// <summary>Configuration block for authenticating dashboard with Cognito. Detailed below.</summary>
    [JsonPropertyName("cognitoOptions")]
    public IList<V1beta1DomainSpecInitProviderCognitoOptions>? CognitoOptions { get; set; }

    /// <summary>Configuration block for domain endpoint HTTP(S) related options. Detailed below.</summary>
    [JsonPropertyName("domainEndpointOptions")]
    public IList<V1beta1DomainSpecInitProviderDomainEndpointOptions>? DomainEndpointOptions { get; set; }

    /// <summary>Name of the domain.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Configuration block for EBS related options, may be required based on chosen instance size. Detailed below.</summary>
    [JsonPropertyName("ebsOptions")]
    public IList<V1beta1DomainSpecInitProviderEbsOptions>? EbsOptions { get; set; }

    /// <summary>Configuration block for encrypt at rest options. Only available for certain instance types. Detailed below.</summary>
    [JsonPropertyName("encryptAtRest")]
    public IList<V1beta1DomainSpecInitProviderEncryptAtRest>? EncryptAtRest { get; set; }

    /// <summary>while Elasticsearch has elasticsearch_version</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>The IP address type for the endpoint. Valid values are ipv4 and dualstack.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>Configuration block for publishing slow and application logs to CloudWatch Logs. This block can be declared multiple times, for each log_type, within the same resource. Detailed below.</summary>
    [JsonPropertyName("logPublishingOptions")]
    public IList<V1beta1DomainSpecInitProviderLogPublishingOptions>? LogPublishingOptions { get; set; }

    /// <summary>Configuration block for node-to-node encryption options. Detailed below.</summary>
    [JsonPropertyName("nodeToNodeEncryption")]
    public IList<V1beta1DomainSpecInitProviderNodeToNodeEncryption>? NodeToNodeEncryption { get; set; }

    /// <summary>Configuration to add Off Peak update options. (documentation). Detailed below.</summary>
    [JsonPropertyName("offPeakWindowOptions")]
    public IList<V1beta1DomainSpecInitProviderOffPeakWindowOptions>? OffPeakWindowOptions { get; set; }

    /// <summary>Configuration block for snapshot related options. Detailed below. DEPRECATED. For domains running OpenSearch 5.3 and later, Amazon OpenSearch takes hourly automated snapshots, making this setting irrelevant. For domains running earlier versions, OpenSearch takes daily automated snapshots.</summary>
    [JsonPropertyName("snapshotOptions")]
    public IList<V1beta1DomainSpecInitProviderSnapshotOptions>? SnapshotOptions { get; set; }

    /// <summary>Software update options for the domain. Detailed below.</summary>
    [JsonPropertyName("softwareUpdateOptions")]
    public IList<V1beta1DomainSpecInitProviderSoftwareUpdateOptions>? SoftwareUpdateOptions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for VPC related options. Adding or removing this configuration forces a new resource (documentation). Detailed below.</summary>
    [JsonPropertyName("vpcOptions")]
    public IList<V1beta1DomainSpecInitProviderVpcOptions>? VpcOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecManagementPoliciesEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1DomainSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1DomainSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
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
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecDeletionPolicyEnum>))]
    public V1beta1DomainSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DomainSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DomainSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DomainSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

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

    /// <summary>Main user's username, which is stored in the Amazon OpenSearch Service domain's internal database. Only specify if internal_user_database_enabled is set to true.</summary>
    [JsonPropertyName("masterUserName")]
    public string? MasterUserName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderAdvancedSecurityOptions
{
    /// <summary>Whether Anonymous auth is enabled. Enables fine-grained access control on an existing domain. Ignored unless advanced_security_options are enabled. Can only be enabled on an existing domain.</summary>
    [JsonPropertyName("anonymousAuthEnabled")]
    public bool? AnonymousAuthEnabled { get; set; }

    /// <summary>Whether advanced security is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether the internal user database is enabled. Default is false.</summary>
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
    /// <summary>Unit of time specifying the duration of an Auto-Tune maintenance window. Valid values: HOURS.</summary>
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
    /// <summary>Auto-Tune desired state for the domain. Valid values: ENABLED or DISABLED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>Configuration block for Auto-Tune maintenance windows. Can be specified multiple times for each maintenance window. Detailed below.</summary>
    [JsonPropertyName("maintenanceSchedule")]
    public IList<V1beta1DomainStatusAtProviderAutoTuneOptionsMaintenanceSchedule>? MaintenanceSchedule { get; set; }

    /// <summary>Whether to roll back to default Auto-Tune settings when disabling Auto-Tune. Valid values: DEFAULT_ROLLBACK or NO_ROLLBACK.</summary>
    [JsonPropertyName("rollbackOnDisable")]
    public string? RollbackOnDisable { get; set; }

    /// <summary>Whether to schedule Auto-Tune optimizations that require blue/green deployments during the domain's configured daily off-peak window. Defaults to false.</summary>
    [JsonPropertyName("useOffPeakWindow")]
    public bool? UseOffPeakWindow { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderClusterConfigColdStorageOptions
{
    /// <summary>Boolean to enable cold storage for an OpenSearch domain. Defaults to false. Master and ultrawarm nodes must be enabled for cold storage.</summary>
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

    /// <summary>Whether a multi-AZ domain is turned on with a standby AZ. For more information, see Configuring a multi-AZ domain in Amazon OpenSearch Service.</summary>
    [JsonPropertyName("multiAzWithStandbyEnabled")]
    public bool? MultiAzWithStandbyEnabled { get; set; }

    /// <summary>Number of warm nodes in the cluster. Valid values are between 2 and 150. warm_count can be only and must be set when warm_enabled is set to true.</summary>
    [JsonPropertyName("warmCount")]
    public double? WarmCount { get; set; }

    /// <summary>Whether to enable warm storage.</summary>
    [JsonPropertyName("warmEnabled")]
    public bool? WarmEnabled { get; set; }

    /// <summary>Instance type for the OpenSearch cluster's warm nodes. Valid values are ultrawarm1.medium.search, ultrawarm1.large.search and ultrawarm1.xlarge.search. warm_type can be only and must be set when warm_enabled is set to true.</summary>
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
    /// <summary>Whether Amazon Cognito authentication with Dashboard is enabled or not. Default is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ID of the Cognito Identity Pool to use.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>ARN of the IAM role that has the AmazonOpenSearchServiceCognitoAccess policy attached.</summary>
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

    /// <summary>Whether to enable custom endpoint for the OpenSearch domain.</summary>
    [JsonPropertyName("customEndpointEnabled")]
    public bool? CustomEndpointEnabled { get; set; }

    /// <summary>Whether or not to require HTTPS. Defaults to true.</summary>
    [JsonPropertyName("enforceHttps")]
    public bool? EnforceHttps { get; set; }

    /// <summary>Name of the TLS security policy that needs to be applied to the HTTPS endpoint. For valid values, refer to the AWS documentation.</summary>
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
    /// <summary>Whether to enable encryption at rest. If the encrypt_at_rest block is not provided then this defaults to false. Enabling encryption on new domains requires an engine_version of OpenSearch_X.Y or Elasticsearch_5.1 or greater.</summary>
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

    /// <summary>Type of OpenSearch log. Valid values: INDEX_SLOW_LOGS, SEARCH_SLOW_LOGS, ES_APPLICATION_LOGS, AUDIT_LOGS.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderNodeToNodeEncryption
{
    /// <summary>Whether to enable node-to-node encryption. If the node_to_node_encryption block is not provided then this defaults to false. Enabling node-to-node encryption of a new domain requires an engine_version of OpenSearch_X.Y or Elasticsearch_6.0 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderOffPeakWindowOptionsOffPeakWindowWindowStartTime
{
    /// <summary>Starting hour of the 10-hour window for updates</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Starting minute of the 10-hour window for updates</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderOffPeakWindowOptionsOffPeakWindow
{
    /// <summary>10h window for updates</summary>
    [JsonPropertyName("windowStartTime")]
    public IList<V1beta1DomainStatusAtProviderOffPeakWindowOptionsOffPeakWindowWindowStartTime>? WindowStartTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderOffPeakWindowOptions
{
    /// <summary>Enabled disabled toggle for off-peak update window.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("offPeakWindow")]
    public IList<V1beta1DomainStatusAtProviderOffPeakWindowOptionsOffPeakWindow>? OffPeakWindow { get; set; }
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
public partial class V1beta1DomainStatusAtProviderSoftwareUpdateOptions
{
    /// <summary>Whether automatic service software updates are enabled for the domain. Defaults to false.</summary>
    [JsonPropertyName("autoSoftwareUpdateEnabled")]
    public bool? AutoSoftwareUpdateEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderVpcOptions
{
    /// <summary>If the domain was created inside a VPC, the names of the availability zones the configured subnet_ids were created inside.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>List of VPC Security Group IDs to be applied to the OpenSearch domain endpoints. If omitted, the default Security Group for the VPC will be used.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>List of VPC Subnet IDs for the OpenSearch domain endpoints to be created in.</summary>
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
    /// <summary>, are prefaced with es: for both.</summary>
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

    /// <summary>Configuration block for authenticating dashboard with Cognito. Detailed below.</summary>
    [JsonPropertyName("cognitoOptions")]
    public IList<V1beta1DomainStatusAtProviderCognitoOptions>? CognitoOptions { get; set; }

    /// <summary>Domain-specific endpoint for Dashboard without https scheme.</summary>
    [JsonPropertyName("dashboardEndpoint")]
    public string? DashboardEndpoint { get; set; }

    /// <summary>Configuration block for domain endpoint HTTP(S) related options. Detailed below.</summary>
    [JsonPropertyName("domainEndpointOptions")]
    public IList<V1beta1DomainStatusAtProviderDomainEndpointOptions>? DomainEndpointOptions { get; set; }

    /// <summary>Unique identifier for the domain.</summary>
    [JsonPropertyName("domainId")]
    public string? DomainId { get; set; }

    /// <summary>Name of the domain.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Configuration block for EBS related options, may be required based on chosen instance size. Detailed below.</summary>
    [JsonPropertyName("ebsOptions")]
    public IList<V1beta1DomainStatusAtProviderEbsOptions>? EbsOptions { get; set; }

    /// <summary>Configuration block for encrypt at rest options. Only available for certain instance types. Detailed below.</summary>
    [JsonPropertyName("encryptAtRest")]
    public IList<V1beta1DomainStatusAtProviderEncryptAtRest>? EncryptAtRest { get; set; }

    /// <summary>Domain-specific endpoint used to submit index, search, and data upload requests.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>while Elasticsearch has elasticsearch_version</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The IP address type for the endpoint. Valid values are ipv4 and dualstack.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>(Deprecated) Domain-specific endpoint for kibana without https scheme. Use the dashboard_endpoint attribute instead.</summary>
    [JsonPropertyName("kibanaEndpoint")]
    public string? KibanaEndpoint { get; set; }

    /// <summary>Configuration block for publishing slow and application logs to CloudWatch Logs. This block can be declared multiple times, for each log_type, within the same resource. Detailed below.</summary>
    [JsonPropertyName("logPublishingOptions")]
    public IList<V1beta1DomainStatusAtProviderLogPublishingOptions>? LogPublishingOptions { get; set; }

    /// <summary>Configuration block for node-to-node encryption options. Detailed below.</summary>
    [JsonPropertyName("nodeToNodeEncryption")]
    public IList<V1beta1DomainStatusAtProviderNodeToNodeEncryption>? NodeToNodeEncryption { get; set; }

    /// <summary>Configuration to add Off Peak update options. (documentation). Detailed below.</summary>
    [JsonPropertyName("offPeakWindowOptions")]
    public IList<V1beta1DomainStatusAtProviderOffPeakWindowOptions>? OffPeakWindowOptions { get; set; }

    /// <summary>Configuration block for snapshot related options. Detailed below. DEPRECATED. For domains running OpenSearch 5.3 and later, Amazon OpenSearch takes hourly automated snapshots, making this setting irrelevant. For domains running earlier versions, OpenSearch takes daily automated snapshots.</summary>
    [JsonPropertyName("snapshotOptions")]
    public IList<V1beta1DomainStatusAtProviderSnapshotOptions>? SnapshotOptions { get; set; }

    /// <summary>Software update options for the domain. Detailed below.</summary>
    [JsonPropertyName("softwareUpdateOptions")]
    public IList<V1beta1DomainStatusAtProviderSoftwareUpdateOptions>? SoftwareUpdateOptions { get; set; }

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
    public const string KubeGroup = "opensearch.aws.upbound.io";
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