using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kafkaconnect.aws.upbound.io;
public enum V1beta1ConnectorSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1ConnectorSpecForProviderCapacityAutoscalingScaleInPolicy
{
    /// <summary>The CPU utilization percentage threshold at which you want connector scale out to be triggered.</summary>
    [JsonPropertyName("cpuUtilizationPercentage")]
    public double? CpuUtilizationPercentage { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderCapacityAutoscalingScaleOutPolicy
{
    /// <summary>The CPU utilization percentage threshold at which you want connector scale out to be triggered.</summary>
    [JsonPropertyName("cpuUtilizationPercentage")]
    public double? CpuUtilizationPercentage { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderCapacityAutoscaling
{
    /// <summary>The maximum number of workers allocated to the connector.</summary>
    [JsonPropertyName("maxWorkerCount")]
    public double? MaxWorkerCount { get; set; }

    /// <summary>The number of microcontroller units (MCUs) allocated to each connector worker. Valid values: 1, 2, 4, 8. The default value is 1.</summary>
    [JsonPropertyName("mcuCount")]
    public double? McuCount { get; set; }

    /// <summary>The minimum number of workers allocated to the connector.</summary>
    [JsonPropertyName("minWorkerCount")]
    public double? MinWorkerCount { get; set; }

    /// <summary>The scale-in policy for the connector. See below.</summary>
    [JsonPropertyName("scaleInPolicy")]
    public IList<V1beta1ConnectorSpecForProviderCapacityAutoscalingScaleInPolicy>? ScaleInPolicy { get; set; }

    /// <summary>The scale-out policy for the connector. See below.</summary>
    [JsonPropertyName("scaleOutPolicy")]
    public IList<V1beta1ConnectorSpecForProviderCapacityAutoscalingScaleOutPolicy>? ScaleOutPolicy { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderCapacityProvisionedCapacity
{
    /// <summary>The number of microcontroller units (MCUs) allocated to each connector worker. Valid values: 1, 2, 4, 8. The default value is 1.</summary>
    [JsonPropertyName("mcuCount")]
    public double? McuCount { get; set; }

    /// <summary>The number of workers that are allocated to the connector.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderCapacity
{
    /// <summary>Information about the auto scaling parameters for the connector. See below.</summary>
    [JsonPropertyName("autoscaling")]
    public IList<V1beta1ConnectorSpecForProviderCapacityAutoscaling>? Autoscaling { get; set; }

    /// <summary>Details about a fixed capacity allocated to a connector. See below.</summary>
    [JsonPropertyName("provisionedCapacity")]
    public IList<V1beta1ConnectorSpecForProviderCapacityProvisionedCapacity>? ProvisionedCapacity { get; set; }
}

public enum V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolveEnum>))]
    public V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicy? Policy { get; set; }
}

public enum V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolveEnum>))]
    public V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolveEnum>))]
    public V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicy? Policy { get; set; }
}

public enum V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolveEnum>))]
    public V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpc
{
    /// <summary>References to SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupSelector")]
    public V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelector? SecurityGroupSelector { get; set; }

    /// <summary>The security groups for the connector.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetRefs")]
    public IList<V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetRefs>? SubnetRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetSelector")]
    public V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetSelector? SubnetSelector { get; set; }

    /// <summary>The subnets for the connector.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaCluster
{
    /// <summary>The bootstrap servers of the cluster.</summary>
    [JsonPropertyName("bootstrapServers")]
    public string? BootstrapServers { get; set; }

    /// <summary>Details of an Amazon VPC which has network connectivity to the Apache Kafka cluster.</summary>
    [JsonPropertyName("vpc")]
    public IList<V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpc>? Vpc { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderKafkaCluster
{
    /// <summary>The Apache Kafka cluster to which the connector is connected.</summary>
    [JsonPropertyName("apacheKafkaCluster")]
    public IList<V1beta1ConnectorSpecForProviderKafkaClusterApacheKafkaCluster>? ApacheKafkaCluster { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderKafkaClusterClientAuthentication
{
    /// <summary>The type of client authentication used to connect to the Apache Kafka cluster. Valid values: IAM, NONE. A value of NONE means that no client authentication is used. The default value is NONE.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderKafkaClusterEncryptionInTransit
{
    /// <summary>The type of encryption in transit to the Apache Kafka cluster. Valid values: PLAINTEXT, TLS. The default values is PLAINTEXT.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }
}

public enum V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolveEnum>))]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolveEnum>))]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogs
{
    /// <summary>Specifies whether connector logs get sent to the specified Amazon S3 destination.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the CloudWatch log group that is the destination for log delivery.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupRef")]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRef? LogGroupRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupSelector")]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelector? LogGroupSelector { get; set; }
}

public enum V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolveEnum>))]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolveEnum>))]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehose
{
    /// <summary>The name of the Kinesis Data Firehose delivery stream that is the destination for log delivery.</summary>
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamRef")]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRef? DeliveryStreamRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamSelector")]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelector? DeliveryStreamSelector { get; set; }

    /// <summary>Specifies whether connector logs get sent to the specified Amazon S3 destination.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public enum V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolveEnum>))]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolveEnum>))]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3
{
    /// <summary>The name of the S3 bucket that is the destination for log delivery.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketSelector? BucketSelector { get; set; }

    /// <summary>Specifies whether connector logs get sent to the specified Amazon S3 destination.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The S3 prefix that is the destination for log delivery.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDelivery
{
    /// <summary>Details about delivering logs to Amazon CloudWatch Logs. See below.</summary>
    [JsonPropertyName("cloudwatchLogs")]
    public IList<V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogs>? CloudwatchLogs { get; set; }

    /// <summary>Details about delivering logs to Amazon Kinesis Data Firehose. See below.</summary>
    [JsonPropertyName("firehose")]
    public IList<V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehose>? Firehose { get; set; }

    /// <summary>Details about delivering logs to Amazon S3. See below.</summary>
    [JsonPropertyName("s3")]
    public IList<V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3>? S3 { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderLogDelivery
{
    /// <summary>The workers can send worker logs to different destination types. This configuration specifies the details of these destinations. See below.</summary>
    [JsonPropertyName("workerLogDelivery")]
    public IList<V1beta1ConnectorSpecForProviderLogDeliveryWorkerLogDelivery>? WorkerLogDelivery { get; set; }
}

public enum V1beta1ConnectorSpecForProviderPluginCustomPluginArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecForProviderPluginCustomPluginArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecForProviderPluginCustomPluginArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderPluginCustomPluginArnRefPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecForProviderPluginCustomPluginArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderPluginCustomPluginArnRefPolicyResolveEnum>))]
    public V1beta1ConnectorSpecForProviderPluginCustomPluginArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderPluginCustomPluginArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecForProviderPluginCustomPluginArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectorSpecForProviderPluginCustomPluginArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecForProviderPluginCustomPluginArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecForProviderPluginCustomPluginArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderPluginCustomPluginArnSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecForProviderPluginCustomPluginArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderPluginCustomPluginArnSelectorPolicyResolveEnum>))]
    public V1beta1ConnectorSpecForProviderPluginCustomPluginArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderPluginCustomPluginArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecForProviderPluginCustomPluginArnSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderPluginCustomPlugin
{
    /// <summary>The Amazon Resource Name (ARN) of the worker configuration.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a CustomPlugin in kafkaconnect to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1ConnectorSpecForProviderPluginCustomPluginArnRef? ArnRef { get; set; }

    /// <summary>Selector for a CustomPlugin in kafkaconnect to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1ConnectorSpecForProviderPluginCustomPluginArnSelector? ArnSelector { get; set; }

    /// <summary>The revision of the worker configuration.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderPlugin
{
    /// <summary>Details about a custom plugin. See below.</summary>
    [JsonPropertyName("customPlugin")]
    public IList<V1beta1ConnectorSpecForProviderPluginCustomPlugin>? CustomPlugin { get; set; }
}

public enum V1beta1ConnectorSpecForProviderServiceExecutionRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecForProviderServiceExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecForProviderServiceExecutionRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderServiceExecutionRoleArnRefPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecForProviderServiceExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderServiceExecutionRoleArnRefPolicyResolveEnum>))]
    public V1beta1ConnectorSpecForProviderServiceExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderServiceExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecForProviderServiceExecutionRoleArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectorSpecForProviderServiceExecutionRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecForProviderServiceExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecForProviderServiceExecutionRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderServiceExecutionRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecForProviderServiceExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderServiceExecutionRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1ConnectorSpecForProviderServiceExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderServiceExecutionRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecForProviderServiceExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ConnectorSpecForProviderWorkerConfigurationArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecForProviderWorkerConfigurationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecForProviderWorkerConfigurationArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderWorkerConfigurationArnRefPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecForProviderWorkerConfigurationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderWorkerConfigurationArnRefPolicyResolveEnum>))]
    public V1beta1ConnectorSpecForProviderWorkerConfigurationArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderWorkerConfigurationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecForProviderWorkerConfigurationArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectorSpecForProviderWorkerConfigurationArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecForProviderWorkerConfigurationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecForProviderWorkerConfigurationArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderWorkerConfigurationArnSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecForProviderWorkerConfigurationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecForProviderWorkerConfigurationArnSelectorPolicyResolveEnum>))]
    public V1beta1ConnectorSpecForProviderWorkerConfigurationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderWorkerConfigurationArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecForProviderWorkerConfigurationArnSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ConnectorSpecForProviderWorkerConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) of the worker configuration.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a WorkerConfiguration in kafkaconnect to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1ConnectorSpecForProviderWorkerConfigurationArnRef? ArnRef { get; set; }

    /// <summary>Selector for a WorkerConfiguration in kafkaconnect to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1ConnectorSpecForProviderWorkerConfigurationArnSelector? ArnSelector { get; set; }

    /// <summary>The revision of the worker configuration.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }
}

public partial class V1beta1ConnectorSpecForProvider
{
    /// <summary>Information about the capacity allocated to the connector. See below.</summary>
    [JsonPropertyName("capacity")]
    public IList<V1beta1ConnectorSpecForProviderCapacity>? Capacity { get; set; }

    /// <summary>A map of keys to values that represent the configuration for the connector.</summary>
    [JsonPropertyName("connectorConfiguration")]
    public IDictionary<string, string>? ConnectorConfiguration { get; set; }

    /// <summary>A summary description of the connector.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies which Apache Kafka cluster to connect to. See below.</summary>
    [JsonPropertyName("kafkaCluster")]
    public IList<V1beta1ConnectorSpecForProviderKafkaCluster>? KafkaCluster { get; set; }

    /// <summary>Details of the client authentication used by the Apache Kafka cluster. See below.</summary>
    [JsonPropertyName("kafkaClusterClientAuthentication")]
    public IList<V1beta1ConnectorSpecForProviderKafkaClusterClientAuthentication>? KafkaClusterClientAuthentication { get; set; }

    /// <summary>Details of encryption in transit to the Apache Kafka cluster. See below.</summary>
    [JsonPropertyName("kafkaClusterEncryptionInTransit")]
    public IList<V1beta1ConnectorSpecForProviderKafkaClusterEncryptionInTransit>? KafkaClusterEncryptionInTransit { get; set; }

    /// <summary>The version of Kafka Connect. It has to be compatible with both the Apache Kafka cluster's version and the plugins.</summary>
    [JsonPropertyName("kafkaconnectVersion")]
    public string? KafkaconnectVersion { get; set; }

    /// <summary>Details about log delivery. See below.</summary>
    [JsonPropertyName("logDelivery")]
    public IList<V1beta1ConnectorSpecForProviderLogDelivery>? LogDelivery { get; set; }

    /// <summary>The name of the connector.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Specifies which plugins to use for the connector. See below.</summary>
    [JsonPropertyName("plugin")]
    public IList<V1beta1ConnectorSpecForProviderPlugin>? Plugin { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role used by the connector to access the Amazon Web Services resources that it needs. The types of resources depends on the logic of the connector. For example, a connector that has Amazon S3 as a destination must have permissions that allow it to write to the S3 destination bucket.</summary>
    [JsonPropertyName("serviceExecutionRoleArn")]
    public string? ServiceExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceExecutionRoleArn.</summary>
    [JsonPropertyName("serviceExecutionRoleArnRef")]
    public V1beta1ConnectorSpecForProviderServiceExecutionRoleArnRef? ServiceExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceExecutionRoleArn.</summary>
    [JsonPropertyName("serviceExecutionRoleArnSelector")]
    public V1beta1ConnectorSpecForProviderServiceExecutionRoleArnSelector? ServiceExecutionRoleArnSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies which worker configuration to use with the connector. See below.</summary>
    [JsonPropertyName("workerConfiguration")]
    public IList<V1beta1ConnectorSpecForProviderWorkerConfiguration>? WorkerConfiguration { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderCapacityAutoscalingScaleInPolicy
{
    /// <summary>The CPU utilization percentage threshold at which you want connector scale out to be triggered.</summary>
    [JsonPropertyName("cpuUtilizationPercentage")]
    public double? CpuUtilizationPercentage { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderCapacityAutoscalingScaleOutPolicy
{
    /// <summary>The CPU utilization percentage threshold at which you want connector scale out to be triggered.</summary>
    [JsonPropertyName("cpuUtilizationPercentage")]
    public double? CpuUtilizationPercentage { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderCapacityAutoscaling
{
    /// <summary>The maximum number of workers allocated to the connector.</summary>
    [JsonPropertyName("maxWorkerCount")]
    public double? MaxWorkerCount { get; set; }

    /// <summary>The number of microcontroller units (MCUs) allocated to each connector worker. Valid values: 1, 2, 4, 8. The default value is 1.</summary>
    [JsonPropertyName("mcuCount")]
    public double? McuCount { get; set; }

    /// <summary>The minimum number of workers allocated to the connector.</summary>
    [JsonPropertyName("minWorkerCount")]
    public double? MinWorkerCount { get; set; }

    /// <summary>The scale-in policy for the connector. See below.</summary>
    [JsonPropertyName("scaleInPolicy")]
    public IList<V1beta1ConnectorSpecInitProviderCapacityAutoscalingScaleInPolicy>? ScaleInPolicy { get; set; }

    /// <summary>The scale-out policy for the connector. See below.</summary>
    [JsonPropertyName("scaleOutPolicy")]
    public IList<V1beta1ConnectorSpecInitProviderCapacityAutoscalingScaleOutPolicy>? ScaleOutPolicy { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderCapacityProvisionedCapacity
{
    /// <summary>The number of microcontroller units (MCUs) allocated to each connector worker. Valid values: 1, 2, 4, 8. The default value is 1.</summary>
    [JsonPropertyName("mcuCount")]
    public double? McuCount { get; set; }

    /// <summary>The number of workers that are allocated to the connector.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderCapacity
{
    /// <summary>Information about the auto scaling parameters for the connector. See below.</summary>
    [JsonPropertyName("autoscaling")]
    public IList<V1beta1ConnectorSpecInitProviderCapacityAutoscaling>? Autoscaling { get; set; }

    /// <summary>Details about a fixed capacity allocated to a connector. See below.</summary>
    [JsonPropertyName("provisionedCapacity")]
    public IList<V1beta1ConnectorSpecInitProviderCapacityProvisionedCapacity>? ProvisionedCapacity { get; set; }
}

public enum V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolveEnum>))]
    public V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicy? Policy { get; set; }
}

public enum V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolveEnum>))]
    public V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolveEnum>))]
    public V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicy? Policy { get; set; }
}

public enum V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolveEnum>))]
    public V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpc
{
    /// <summary>References to SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupSelector")]
    public V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelector? SecurityGroupSelector { get; set; }

    /// <summary>The security groups for the connector.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetRefs")]
    public IList<V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetRefs>? SubnetRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetSelector")]
    public V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetSelector? SubnetSelector { get; set; }

    /// <summary>The subnets for the connector.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaCluster
{
    /// <summary>The bootstrap servers of the cluster.</summary>
    [JsonPropertyName("bootstrapServers")]
    public string? BootstrapServers { get; set; }

    /// <summary>Details of an Amazon VPC which has network connectivity to the Apache Kafka cluster.</summary>
    [JsonPropertyName("vpc")]
    public IList<V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpc>? Vpc { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderKafkaCluster
{
    /// <summary>The Apache Kafka cluster to which the connector is connected.</summary>
    [JsonPropertyName("apacheKafkaCluster")]
    public IList<V1beta1ConnectorSpecInitProviderKafkaClusterApacheKafkaCluster>? ApacheKafkaCluster { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderKafkaClusterClientAuthentication
{
    /// <summary>The type of client authentication used to connect to the Apache Kafka cluster. Valid values: IAM, NONE. A value of NONE means that no client authentication is used. The default value is NONE.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderKafkaClusterEncryptionInTransit
{
    /// <summary>The type of encryption in transit to the Apache Kafka cluster. Valid values: PLAINTEXT, TLS. The default values is PLAINTEXT.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }
}

public enum V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolveEnum>))]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolveEnum>))]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogs
{
    /// <summary>Specifies whether connector logs get sent to the specified Amazon S3 destination.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the CloudWatch log group that is the destination for log delivery.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupRef")]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRef? LogGroupRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupSelector")]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelector? LogGroupSelector { get; set; }
}

public enum V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolveEnum>))]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolveEnum>))]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehose
{
    /// <summary>The name of the Kinesis Data Firehose delivery stream that is the destination for log delivery.</summary>
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamRef")]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRef? DeliveryStreamRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamSelector")]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelector? DeliveryStreamSelector { get; set; }

    /// <summary>Specifies whether connector logs get sent to the specified Amazon S3 destination.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public enum V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolveEnum>))]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolveEnum>))]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3
{
    /// <summary>The name of the S3 bucket that is the destination for log delivery.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketSelector? BucketSelector { get; set; }

    /// <summary>Specifies whether connector logs get sent to the specified Amazon S3 destination.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The S3 prefix that is the destination for log delivery.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDelivery
{
    /// <summary>Details about delivering logs to Amazon CloudWatch Logs. See below.</summary>
    [JsonPropertyName("cloudwatchLogs")]
    public IList<V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogs>? CloudwatchLogs { get; set; }

    /// <summary>Details about delivering logs to Amazon Kinesis Data Firehose. See below.</summary>
    [JsonPropertyName("firehose")]
    public IList<V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehose>? Firehose { get; set; }

    /// <summary>Details about delivering logs to Amazon S3. See below.</summary>
    [JsonPropertyName("s3")]
    public IList<V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3>? S3 { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderLogDelivery
{
    /// <summary>The workers can send worker logs to different destination types. This configuration specifies the details of these destinations. See below.</summary>
    [JsonPropertyName("workerLogDelivery")]
    public IList<V1beta1ConnectorSpecInitProviderLogDeliveryWorkerLogDelivery>? WorkerLogDelivery { get; set; }
}

public enum V1beta1ConnectorSpecInitProviderPluginCustomPluginArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecInitProviderPluginCustomPluginArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecInitProviderPluginCustomPluginArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderPluginCustomPluginArnRefPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecInitProviderPluginCustomPluginArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderPluginCustomPluginArnRefPolicyResolveEnum>))]
    public V1beta1ConnectorSpecInitProviderPluginCustomPluginArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderPluginCustomPluginArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecInitProviderPluginCustomPluginArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectorSpecInitProviderPluginCustomPluginArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecInitProviderPluginCustomPluginArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecInitProviderPluginCustomPluginArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderPluginCustomPluginArnSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecInitProviderPluginCustomPluginArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderPluginCustomPluginArnSelectorPolicyResolveEnum>))]
    public V1beta1ConnectorSpecInitProviderPluginCustomPluginArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderPluginCustomPluginArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecInitProviderPluginCustomPluginArnSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderPluginCustomPlugin
{
    /// <summary>The Amazon Resource Name (ARN) of the worker configuration.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a CustomPlugin in kafkaconnect to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1ConnectorSpecInitProviderPluginCustomPluginArnRef? ArnRef { get; set; }

    /// <summary>Selector for a CustomPlugin in kafkaconnect to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1ConnectorSpecInitProviderPluginCustomPluginArnSelector? ArnSelector { get; set; }

    /// <summary>The revision of the worker configuration.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderPlugin
{
    /// <summary>Details about a custom plugin. See below.</summary>
    [JsonPropertyName("customPlugin")]
    public IList<V1beta1ConnectorSpecInitProviderPluginCustomPlugin>? CustomPlugin { get; set; }
}

public enum V1beta1ConnectorSpecInitProviderServiceExecutionRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecInitProviderServiceExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecInitProviderServiceExecutionRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderServiceExecutionRoleArnRefPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecInitProviderServiceExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderServiceExecutionRoleArnRefPolicyResolveEnum>))]
    public V1beta1ConnectorSpecInitProviderServiceExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderServiceExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecInitProviderServiceExecutionRoleArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectorSpecInitProviderServiceExecutionRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecInitProviderServiceExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecInitProviderServiceExecutionRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderServiceExecutionRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecInitProviderServiceExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderServiceExecutionRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1ConnectorSpecInitProviderServiceExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderServiceExecutionRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecInitProviderServiceExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ConnectorSpecInitProviderWorkerConfigurationArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecInitProviderWorkerConfigurationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecInitProviderWorkerConfigurationArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderWorkerConfigurationArnRefPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecInitProviderWorkerConfigurationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderWorkerConfigurationArnRefPolicyResolveEnum>))]
    public V1beta1ConnectorSpecInitProviderWorkerConfigurationArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderWorkerConfigurationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecInitProviderWorkerConfigurationArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectorSpecInitProviderWorkerConfigurationArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecInitProviderWorkerConfigurationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecInitProviderWorkerConfigurationArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderWorkerConfigurationArnSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecInitProviderWorkerConfigurationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecInitProviderWorkerConfigurationArnSelectorPolicyResolveEnum>))]
    public V1beta1ConnectorSpecInitProviderWorkerConfigurationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderWorkerConfigurationArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecInitProviderWorkerConfigurationArnSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ConnectorSpecInitProviderWorkerConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) of the worker configuration.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a WorkerConfiguration in kafkaconnect to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1ConnectorSpecInitProviderWorkerConfigurationArnRef? ArnRef { get; set; }

    /// <summary>Selector for a WorkerConfiguration in kafkaconnect to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1ConnectorSpecInitProviderWorkerConfigurationArnSelector? ArnSelector { get; set; }

    /// <summary>The revision of the worker configuration.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }
}

public partial class V1beta1ConnectorSpecInitProvider
{
    /// <summary>Information about the capacity allocated to the connector. See below.</summary>
    [JsonPropertyName("capacity")]
    public IList<V1beta1ConnectorSpecInitProviderCapacity>? Capacity { get; set; }

    /// <summary>A map of keys to values that represent the configuration for the connector.</summary>
    [JsonPropertyName("connectorConfiguration")]
    public IDictionary<string, string>? ConnectorConfiguration { get; set; }

    /// <summary>A summary description of the connector.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies which Apache Kafka cluster to connect to. See below.</summary>
    [JsonPropertyName("kafkaCluster")]
    public IList<V1beta1ConnectorSpecInitProviderKafkaCluster>? KafkaCluster { get; set; }

    /// <summary>Details of the client authentication used by the Apache Kafka cluster. See below.</summary>
    [JsonPropertyName("kafkaClusterClientAuthentication")]
    public IList<V1beta1ConnectorSpecInitProviderKafkaClusterClientAuthentication>? KafkaClusterClientAuthentication { get; set; }

    /// <summary>Details of encryption in transit to the Apache Kafka cluster. See below.</summary>
    [JsonPropertyName("kafkaClusterEncryptionInTransit")]
    public IList<V1beta1ConnectorSpecInitProviderKafkaClusterEncryptionInTransit>? KafkaClusterEncryptionInTransit { get; set; }

    /// <summary>The version of Kafka Connect. It has to be compatible with both the Apache Kafka cluster's version and the plugins.</summary>
    [JsonPropertyName("kafkaconnectVersion")]
    public string? KafkaconnectVersion { get; set; }

    /// <summary>Details about log delivery. See below.</summary>
    [JsonPropertyName("logDelivery")]
    public IList<V1beta1ConnectorSpecInitProviderLogDelivery>? LogDelivery { get; set; }

    /// <summary>Specifies which plugins to use for the connector. See below.</summary>
    [JsonPropertyName("plugin")]
    public IList<V1beta1ConnectorSpecInitProviderPlugin>? Plugin { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role used by the connector to access the Amazon Web Services resources that it needs. The types of resources depends on the logic of the connector. For example, a connector that has Amazon S3 as a destination must have permissions that allow it to write to the S3 destination bucket.</summary>
    [JsonPropertyName("serviceExecutionRoleArn")]
    public string? ServiceExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceExecutionRoleArn.</summary>
    [JsonPropertyName("serviceExecutionRoleArnRef")]
    public V1beta1ConnectorSpecInitProviderServiceExecutionRoleArnRef? ServiceExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceExecutionRoleArn.</summary>
    [JsonPropertyName("serviceExecutionRoleArnSelector")]
    public V1beta1ConnectorSpecInitProviderServiceExecutionRoleArnSelector? ServiceExecutionRoleArnSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies which worker configuration to use with the connector. See below.</summary>
    [JsonPropertyName("workerConfiguration")]
    public IList<V1beta1ConnectorSpecInitProviderWorkerConfiguration>? WorkerConfiguration { get; set; }
}

public enum V1beta1ConnectorSpecManagementPoliciesEnum
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

public enum V1beta1ConnectorSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ConnectorSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectorSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectorSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ConnectorSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ConnectorSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ConnectorSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ConnectorSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectorSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1ConnectorSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1ConnectorSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ConnectorSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ConnectorSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1ConnectorSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1ConnectorSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectorSpecDeletionPolicyEnum>))]
    public V1beta1ConnectorSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ConnectorSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ConnectorSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ConnectorSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ConnectorSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ConnectorSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ConnectorSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1ConnectorStatusAtProviderCapacityAutoscalingScaleInPolicy
{
    /// <summary>The CPU utilization percentage threshold at which you want connector scale out to be triggered.</summary>
    [JsonPropertyName("cpuUtilizationPercentage")]
    public double? CpuUtilizationPercentage { get; set; }
}

public partial class V1beta1ConnectorStatusAtProviderCapacityAutoscalingScaleOutPolicy
{
    /// <summary>The CPU utilization percentage threshold at which you want connector scale out to be triggered.</summary>
    [JsonPropertyName("cpuUtilizationPercentage")]
    public double? CpuUtilizationPercentage { get; set; }
}

public partial class V1beta1ConnectorStatusAtProviderCapacityAutoscaling
{
    /// <summary>The maximum number of workers allocated to the connector.</summary>
    [JsonPropertyName("maxWorkerCount")]
    public double? MaxWorkerCount { get; set; }

    /// <summary>The number of microcontroller units (MCUs) allocated to each connector worker. Valid values: 1, 2, 4, 8. The default value is 1.</summary>
    [JsonPropertyName("mcuCount")]
    public double? McuCount { get; set; }

    /// <summary>The minimum number of workers allocated to the connector.</summary>
    [JsonPropertyName("minWorkerCount")]
    public double? MinWorkerCount { get; set; }

    /// <summary>The scale-in policy for the connector. See below.</summary>
    [JsonPropertyName("scaleInPolicy")]
    public IList<V1beta1ConnectorStatusAtProviderCapacityAutoscalingScaleInPolicy>? ScaleInPolicy { get; set; }

    /// <summary>The scale-out policy for the connector. See below.</summary>
    [JsonPropertyName("scaleOutPolicy")]
    public IList<V1beta1ConnectorStatusAtProviderCapacityAutoscalingScaleOutPolicy>? ScaleOutPolicy { get; set; }
}

public partial class V1beta1ConnectorStatusAtProviderCapacityProvisionedCapacity
{
    /// <summary>The number of microcontroller units (MCUs) allocated to each connector worker. Valid values: 1, 2, 4, 8. The default value is 1.</summary>
    [JsonPropertyName("mcuCount")]
    public double? McuCount { get; set; }

    /// <summary>The number of workers that are allocated to the connector.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

public partial class V1beta1ConnectorStatusAtProviderCapacity
{
    /// <summary>Information about the auto scaling parameters for the connector. See below.</summary>
    [JsonPropertyName("autoscaling")]
    public IList<V1beta1ConnectorStatusAtProviderCapacityAutoscaling>? Autoscaling { get; set; }

    /// <summary>Details about a fixed capacity allocated to a connector. See below.</summary>
    [JsonPropertyName("provisionedCapacity")]
    public IList<V1beta1ConnectorStatusAtProviderCapacityProvisionedCapacity>? ProvisionedCapacity { get; set; }
}

public partial class V1beta1ConnectorStatusAtProviderKafkaClusterApacheKafkaClusterVpc
{
    /// <summary>The security groups for the connector.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The subnets for the connector.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

public partial class V1beta1ConnectorStatusAtProviderKafkaClusterApacheKafkaCluster
{
    /// <summary>The bootstrap servers of the cluster.</summary>
    [JsonPropertyName("bootstrapServers")]
    public string? BootstrapServers { get; set; }

    /// <summary>Details of an Amazon VPC which has network connectivity to the Apache Kafka cluster.</summary>
    [JsonPropertyName("vpc")]
    public IList<V1beta1ConnectorStatusAtProviderKafkaClusterApacheKafkaClusterVpc>? Vpc { get; set; }
}

public partial class V1beta1ConnectorStatusAtProviderKafkaCluster
{
    /// <summary>The Apache Kafka cluster to which the connector is connected.</summary>
    [JsonPropertyName("apacheKafkaCluster")]
    public IList<V1beta1ConnectorStatusAtProviderKafkaClusterApacheKafkaCluster>? ApacheKafkaCluster { get; set; }
}

public partial class V1beta1ConnectorStatusAtProviderKafkaClusterClientAuthentication
{
    /// <summary>The type of client authentication used to connect to the Apache Kafka cluster. Valid values: IAM, NONE. A value of NONE means that no client authentication is used. The default value is NONE.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }
}

public partial class V1beta1ConnectorStatusAtProviderKafkaClusterEncryptionInTransit
{
    /// <summary>The type of encryption in transit to the Apache Kafka cluster. Valid values: PLAINTEXT, TLS. The default values is PLAINTEXT.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }
}

public partial class V1beta1ConnectorStatusAtProviderLogDeliveryWorkerLogDeliveryCloudwatchLogs
{
    /// <summary>Specifies whether connector logs get sent to the specified Amazon S3 destination.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the CloudWatch log group that is the destination for log delivery.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }
}

public partial class V1beta1ConnectorStatusAtProviderLogDeliveryWorkerLogDeliveryFirehose
{
    /// <summary>The name of the Kinesis Data Firehose delivery stream that is the destination for log delivery.</summary>
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }

    /// <summary>Specifies whether connector logs get sent to the specified Amazon S3 destination.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public partial class V1beta1ConnectorStatusAtProviderLogDeliveryWorkerLogDeliveryS3
{
    /// <summary>The name of the S3 bucket that is the destination for log delivery.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Specifies whether connector logs get sent to the specified Amazon S3 destination.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The S3 prefix that is the destination for log delivery.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

public partial class V1beta1ConnectorStatusAtProviderLogDeliveryWorkerLogDelivery
{
    /// <summary>Details about delivering logs to Amazon CloudWatch Logs. See below.</summary>
    [JsonPropertyName("cloudwatchLogs")]
    public IList<V1beta1ConnectorStatusAtProviderLogDeliveryWorkerLogDeliveryCloudwatchLogs>? CloudwatchLogs { get; set; }

    /// <summary>Details about delivering logs to Amazon Kinesis Data Firehose. See below.</summary>
    [JsonPropertyName("firehose")]
    public IList<V1beta1ConnectorStatusAtProviderLogDeliveryWorkerLogDeliveryFirehose>? Firehose { get; set; }

    /// <summary>Details about delivering logs to Amazon S3. See below.</summary>
    [JsonPropertyName("s3")]
    public IList<V1beta1ConnectorStatusAtProviderLogDeliveryWorkerLogDeliveryS3>? S3 { get; set; }
}

public partial class V1beta1ConnectorStatusAtProviderLogDelivery
{
    /// <summary>The workers can send worker logs to different destination types. This configuration specifies the details of these destinations. See below.</summary>
    [JsonPropertyName("workerLogDelivery")]
    public IList<V1beta1ConnectorStatusAtProviderLogDeliveryWorkerLogDelivery>? WorkerLogDelivery { get; set; }
}

public partial class V1beta1ConnectorStatusAtProviderPluginCustomPlugin
{
    /// <summary>The Amazon Resource Name (ARN) of the worker configuration.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The revision of the worker configuration.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }
}

public partial class V1beta1ConnectorStatusAtProviderPlugin
{
    /// <summary>Details about a custom plugin. See below.</summary>
    [JsonPropertyName("customPlugin")]
    public IList<V1beta1ConnectorStatusAtProviderPluginCustomPlugin>? CustomPlugin { get; set; }
}

public partial class V1beta1ConnectorStatusAtProviderWorkerConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) of the worker configuration.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The revision of the worker configuration.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }
}

public partial class V1beta1ConnectorStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) of the custom plugin.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Information about the capacity allocated to the connector. See below.</summary>
    [JsonPropertyName("capacity")]
    public IList<V1beta1ConnectorStatusAtProviderCapacity>? Capacity { get; set; }

    /// <summary>A map of keys to values that represent the configuration for the connector.</summary>
    [JsonPropertyName("connectorConfiguration")]
    public IDictionary<string, string>? ConnectorConfiguration { get; set; }

    /// <summary>A summary description of the connector.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies which Apache Kafka cluster to connect to. See below.</summary>
    [JsonPropertyName("kafkaCluster")]
    public IList<V1beta1ConnectorStatusAtProviderKafkaCluster>? KafkaCluster { get; set; }

    /// <summary>Details of the client authentication used by the Apache Kafka cluster. See below.</summary>
    [JsonPropertyName("kafkaClusterClientAuthentication")]
    public IList<V1beta1ConnectorStatusAtProviderKafkaClusterClientAuthentication>? KafkaClusterClientAuthentication { get; set; }

    /// <summary>Details of encryption in transit to the Apache Kafka cluster. See below.</summary>
    [JsonPropertyName("kafkaClusterEncryptionInTransit")]
    public IList<V1beta1ConnectorStatusAtProviderKafkaClusterEncryptionInTransit>? KafkaClusterEncryptionInTransit { get; set; }

    /// <summary>The version of Kafka Connect. It has to be compatible with both the Apache Kafka cluster's version and the plugins.</summary>
    [JsonPropertyName("kafkaconnectVersion")]
    public string? KafkaconnectVersion { get; set; }

    /// <summary>Details about log delivery. See below.</summary>
    [JsonPropertyName("logDelivery")]
    public IList<V1beta1ConnectorStatusAtProviderLogDelivery>? LogDelivery { get; set; }

    /// <summary>The name of the connector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies which plugins to use for the connector. See below.</summary>
    [JsonPropertyName("plugin")]
    public IList<V1beta1ConnectorStatusAtProviderPlugin>? Plugin { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role used by the connector to access the Amazon Web Services resources that it needs. The types of resources depends on the logic of the connector. For example, a connector that has Amazon S3 as a destination must have permissions that allow it to write to the S3 destination bucket.</summary>
    [JsonPropertyName("serviceExecutionRoleArn")]
    public string? ServiceExecutionRoleArn { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The current version of the connector.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Specifies which worker configuration to use with the connector. See below.</summary>
    [JsonPropertyName("workerConfiguration")]
    public IList<V1beta1ConnectorStatusAtProviderWorkerConfiguration>? WorkerConfiguration { get; set; }
}

public partial class V1beta1ConnectorStatusConditions
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

public partial class V1beta1ConnectorStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ConnectorStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ConnectorStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Connector : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ConnectorSpec>, IStatus<V1beta1ConnectorStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Connector";
    public const string KubeGroup = "kafkaconnect.aws.upbound.io";
    public const string KubePluralName = "connectors";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConnectorSpec defines the desired state of Connector</summary>
    [JsonPropertyName("spec")]
    public V1beta1ConnectorSpec Spec { get; set; }

    /// <summary>ConnectorStatus defines the observed state of Connector.</summary>
    [JsonPropertyName("status")]
    public V1beta1ConnectorStatus? Status { get; set; }
}