using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kafka.aws.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in kafka to populate mskClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in kafka to populate mskClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Details of an Amazon MSK cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskCluster
{
    /// <summary>The ARN of an Amazon MSK cluster.</summary>
    [JsonPropertyName("mskClusterArn")]
    public string? MskClusterArn { get; set; }

    /// <summary>Reference to a Cluster in kafka to populate mskClusterArn.</summary>
    [JsonPropertyName("mskClusterArnRef")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnRef? MskClusterArnRef { get; set; }

    /// <summary>Selector for a Cluster in kafka to populate mskClusterArn.</summary>
    [JsonPropertyName("mskClusterArnSelector")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskClusterMskClusterArnSelector? MskClusterArnSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsRefsPolicy
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
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupsIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsRefsPolicy
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
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Details of an Amazon VPC which has network connectivity to the Apache Kafka cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfig
{
    /// <summary>The AWS security groups to associate with the ENIs used by the replicator. If a security group is not specified, the default security group associated with the VPC is used.</summary>
    [JsonPropertyName("securityGroupsIds")]
    public IList<string>? SecurityGroupsIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupsIds.</summary>
    [JsonPropertyName("securityGroupsIdsRefs")]
    public IList<V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsRefs>? SecurityGroupsIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupsIds.</summary>
    [JsonPropertyName("securityGroupsIdsSelector")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSecurityGroupsIdsSelector? SecurityGroupsIdsSelector { get; set; }

    /// <summary>The list of subnets to connect to in the virtual private cloud (VPC). AWS creates elastic network interfaces inside these subnets to allow communication between your Kafka Cluster and the replicator.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsRefs")]
    public IList<V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsRefs>? SubnetIdsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsSelector")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfigSubnetIdsSelector? SubnetIdsSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderKafkaCluster
{
    /// <summary>Details of an Amazon MSK cluster.</summary>
    [JsonPropertyName("amazonMskCluster")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterAmazonMskCluster? AmazonMskCluster { get; set; }

    /// <summary>Details of an Amazon VPC which has network connectivity to the Apache Kafka cluster.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta1ReplicatorSpecForProviderKafkaClusterVpcConfig? VpcConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListConsumerGroupReplication
{
    /// <summary>List of regular expression patterns indicating the consumer groups that should not be replicated.</summary>
    [JsonPropertyName("consumerGroupsToExclude")]
    public IList<string>? ConsumerGroupsToExclude { get; set; }

    /// <summary>List of regular expression patterns indicating the consumer groups to copy.</summary>
    [JsonPropertyName("consumerGroupsToReplicate")]
    public IList<string>? ConsumerGroupsToReplicate { get; set; }

    /// <summary>Whether to periodically check for new consumer groups.</summary>
    [JsonPropertyName("detectAndCopyNewConsumerGroups")]
    public bool? DetectAndCopyNewConsumerGroups { get; set; }

    /// <summary>Whether to periodically write the translated offsets to __consumer_offsets topic in target cluster.</summary>
    [JsonPropertyName("synchroniseConsumerGroupOffsets")]
    public bool? SynchroniseConsumerGroupOffsets { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in kafka to populate sourceKafkaClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in kafka to populate sourceKafkaClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in kafka to populate targetKafkaClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in kafka to populate targetKafkaClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration for specifying the position in the topics to start replicating from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListTopicReplicationStartingPosition
{
    /// <summary>The type of topic configuration name. Supports PREFIXED_WITH_SOURCE_CLUSTER_ALIAS and IDENTICAL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListTopicReplicationTopicNameConfiguration
{
    /// <summary>The type of topic configuration name. Supports PREFIXED_WITH_SOURCE_CLUSTER_ALIAS and IDENTICAL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoListTopicReplication
{
    /// <summary>Whether to periodically configure remote topic ACLs to match their corresponding upstream topics.</summary>
    [JsonPropertyName("copyAccessControlListsForTopics")]
    public bool? CopyAccessControlListsForTopics { get; set; }

    /// <summary>Whether to periodically configure remote topics to match their corresponding upstream topics.</summary>
    [JsonPropertyName("copyTopicConfigurations")]
    public bool? CopyTopicConfigurations { get; set; }

    /// <summary>Whether to periodically check for new topics and partitions.</summary>
    [JsonPropertyName("detectAndCopyNewTopics")]
    public bool? DetectAndCopyNewTopics { get; set; }

    /// <summary>Configuration for specifying the position in the topics to start replicating from.</summary>
    [JsonPropertyName("startingPosition")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListTopicReplicationStartingPosition? StartingPosition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topicNameConfiguration")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListTopicReplicationTopicNameConfiguration? TopicNameConfiguration { get; set; }

    /// <summary>List of regular expression patterns indicating the topics that should not be replica.</summary>
    [JsonPropertyName("topicsToExclude")]
    public IList<string>? TopicsToExclude { get; set; }

    /// <summary>List of regular expression patterns indicating the topics to copy.</summary>
    [JsonPropertyName("topicsToReplicate")]
    public IList<string>? TopicsToReplicate { get; set; }
}

/// <summary>A list of replication configurations, where each configuration targets a given source cluster to target cluster replication flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderReplicationInfoList
{
    /// <summary>Configuration relating to consumer group replication.</summary>
    [JsonPropertyName("consumerGroupReplication")]
    public IList<V1beta1ReplicatorSpecForProviderReplicationInfoListConsumerGroupReplication>? ConsumerGroupReplication { get; set; }

    /// <summary>The ARN of the source Kafka cluster.</summary>
    [JsonPropertyName("sourceKafkaClusterArn")]
    public string? SourceKafkaClusterArn { get; set; }

    /// <summary>Reference to a Cluster in kafka to populate sourceKafkaClusterArn.</summary>
    [JsonPropertyName("sourceKafkaClusterArnRef")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnRef? SourceKafkaClusterArnRef { get; set; }

    /// <summary>Selector for a Cluster in kafka to populate sourceKafkaClusterArn.</summary>
    [JsonPropertyName("sourceKafkaClusterArnSelector")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListSourceKafkaClusterArnSelector? SourceKafkaClusterArnSelector { get; set; }

    /// <summary>The type of compression to use writing records to target Kafka cluster.</summary>
    [JsonPropertyName("targetCompressionType")]
    public string? TargetCompressionType { get; set; }

    /// <summary>The ARN of the target Kafka cluster.</summary>
    [JsonPropertyName("targetKafkaClusterArn")]
    public string? TargetKafkaClusterArn { get; set; }

    /// <summary>Reference to a Cluster in kafka to populate targetKafkaClusterArn.</summary>
    [JsonPropertyName("targetKafkaClusterArnRef")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnRef? TargetKafkaClusterArnRef { get; set; }

    /// <summary>Selector for a Cluster in kafka to populate targetKafkaClusterArn.</summary>
    [JsonPropertyName("targetKafkaClusterArnSelector")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoListTargetKafkaClusterArnSelector? TargetKafkaClusterArnSelector { get; set; }

    /// <summary>Configuration relating to topic replication.</summary>
    [JsonPropertyName("topicReplication")]
    public IList<V1beta1ReplicatorSpecForProviderReplicationInfoListTopicReplication>? TopicReplication { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecForProvider
{
    /// <summary>A summary description of the replicator.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A list of Kafka clusters which are targets of the replicator.</summary>
    [JsonPropertyName("kafkaCluster")]
    public IList<V1beta1ReplicatorSpecForProviderKafkaCluster>? KafkaCluster { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>A list of replication configurations, where each configuration targets a given source cluster to target cluster replication flow.</summary>
    [JsonPropertyName("replicationInfoList")]
    public V1beta1ReplicatorSpecForProviderReplicationInfoList? ReplicationInfoList { get; set; }

    /// <summary>The name of the replicator.</summary>
    [JsonPropertyName("replicatorName")]
    public string? ReplicatorName { get; set; }

    /// <summary>The ARN of the IAM role used by the replicator to access resources in the customer's account (e.g source and target clusters).</summary>
    [JsonPropertyName("serviceExecutionRoleArn")]
    public string? ServiceExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceExecutionRoleArn.</summary>
    [JsonPropertyName("serviceExecutionRoleArnRef")]
    public V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnRef? ServiceExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceExecutionRoleArn.</summary>
    [JsonPropertyName("serviceExecutionRoleArnSelector")]
    public V1beta1ReplicatorSpecForProviderServiceExecutionRoleArnSelector? ServiceExecutionRoleArnSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in kafka to populate mskClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in kafka to populate mskClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Details of an Amazon MSK cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskCluster
{
    /// <summary>The ARN of an Amazon MSK cluster.</summary>
    [JsonPropertyName("mskClusterArn")]
    public string? MskClusterArn { get; set; }

    /// <summary>Reference to a Cluster in kafka to populate mskClusterArn.</summary>
    [JsonPropertyName("mskClusterArnRef")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnRef? MskClusterArnRef { get; set; }

    /// <summary>Selector for a Cluster in kafka to populate mskClusterArn.</summary>
    [JsonPropertyName("mskClusterArnSelector")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskClusterMskClusterArnSelector? MskClusterArnSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsRefsPolicy
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
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupsIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsRefsPolicy
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
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Details of an Amazon VPC which has network connectivity to the Apache Kafka cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfig
{
    /// <summary>The AWS security groups to associate with the ENIs used by the replicator. If a security group is not specified, the default security group associated with the VPC is used.</summary>
    [JsonPropertyName("securityGroupsIds")]
    public IList<string>? SecurityGroupsIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupsIds.</summary>
    [JsonPropertyName("securityGroupsIdsRefs")]
    public IList<V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsRefs>? SecurityGroupsIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupsIds.</summary>
    [JsonPropertyName("securityGroupsIdsSelector")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSecurityGroupsIdsSelector? SecurityGroupsIdsSelector { get; set; }

    /// <summary>The list of subnets to connect to in the virtual private cloud (VPC). AWS creates elastic network interfaces inside these subnets to allow communication between your Kafka Cluster and the replicator.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsRefs")]
    public IList<V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsRefs>? SubnetIdsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsSelector")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfigSubnetIdsSelector? SubnetIdsSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderKafkaCluster
{
    /// <summary>Details of an Amazon MSK cluster.</summary>
    [JsonPropertyName("amazonMskCluster")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterAmazonMskCluster? AmazonMskCluster { get; set; }

    /// <summary>Details of an Amazon VPC which has network connectivity to the Apache Kafka cluster.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta1ReplicatorSpecInitProviderKafkaClusterVpcConfig? VpcConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListConsumerGroupReplication
{
    /// <summary>List of regular expression patterns indicating the consumer groups that should not be replicated.</summary>
    [JsonPropertyName("consumerGroupsToExclude")]
    public IList<string>? ConsumerGroupsToExclude { get; set; }

    /// <summary>List of regular expression patterns indicating the consumer groups to copy.</summary>
    [JsonPropertyName("consumerGroupsToReplicate")]
    public IList<string>? ConsumerGroupsToReplicate { get; set; }

    /// <summary>Whether to periodically check for new consumer groups.</summary>
    [JsonPropertyName("detectAndCopyNewConsumerGroups")]
    public bool? DetectAndCopyNewConsumerGroups { get; set; }

    /// <summary>Whether to periodically write the translated offsets to __consumer_offsets topic in target cluster.</summary>
    [JsonPropertyName("synchroniseConsumerGroupOffsets")]
    public bool? SynchroniseConsumerGroupOffsets { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in kafka to populate sourceKafkaClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in kafka to populate sourceKafkaClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in kafka to populate targetKafkaClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in kafka to populate targetKafkaClusterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration for specifying the position in the topics to start replicating from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListTopicReplicationStartingPosition
{
    /// <summary>The type of topic configuration name. Supports PREFIXED_WITH_SOURCE_CLUSTER_ALIAS and IDENTICAL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListTopicReplicationTopicNameConfiguration
{
    /// <summary>The type of topic configuration name. Supports PREFIXED_WITH_SOURCE_CLUSTER_ALIAS and IDENTICAL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoListTopicReplication
{
    /// <summary>Whether to periodically configure remote topic ACLs to match their corresponding upstream topics.</summary>
    [JsonPropertyName("copyAccessControlListsForTopics")]
    public bool? CopyAccessControlListsForTopics { get; set; }

    /// <summary>Whether to periodically configure remote topics to match their corresponding upstream topics.</summary>
    [JsonPropertyName("copyTopicConfigurations")]
    public bool? CopyTopicConfigurations { get; set; }

    /// <summary>Whether to periodically check for new topics and partitions.</summary>
    [JsonPropertyName("detectAndCopyNewTopics")]
    public bool? DetectAndCopyNewTopics { get; set; }

    /// <summary>Configuration for specifying the position in the topics to start replicating from.</summary>
    [JsonPropertyName("startingPosition")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListTopicReplicationStartingPosition? StartingPosition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topicNameConfiguration")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListTopicReplicationTopicNameConfiguration? TopicNameConfiguration { get; set; }

    /// <summary>List of regular expression patterns indicating the topics that should not be replica.</summary>
    [JsonPropertyName("topicsToExclude")]
    public IList<string>? TopicsToExclude { get; set; }

    /// <summary>List of regular expression patterns indicating the topics to copy.</summary>
    [JsonPropertyName("topicsToReplicate")]
    public IList<string>? TopicsToReplicate { get; set; }
}

/// <summary>A list of replication configurations, where each configuration targets a given source cluster to target cluster replication flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderReplicationInfoList
{
    /// <summary>Configuration relating to consumer group replication.</summary>
    [JsonPropertyName("consumerGroupReplication")]
    public IList<V1beta1ReplicatorSpecInitProviderReplicationInfoListConsumerGroupReplication>? ConsumerGroupReplication { get; set; }

    /// <summary>The ARN of the source Kafka cluster.</summary>
    [JsonPropertyName("sourceKafkaClusterArn")]
    public string? SourceKafkaClusterArn { get; set; }

    /// <summary>Reference to a Cluster in kafka to populate sourceKafkaClusterArn.</summary>
    [JsonPropertyName("sourceKafkaClusterArnRef")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnRef? SourceKafkaClusterArnRef { get; set; }

    /// <summary>Selector for a Cluster in kafka to populate sourceKafkaClusterArn.</summary>
    [JsonPropertyName("sourceKafkaClusterArnSelector")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListSourceKafkaClusterArnSelector? SourceKafkaClusterArnSelector { get; set; }

    /// <summary>The type of compression to use writing records to target Kafka cluster.</summary>
    [JsonPropertyName("targetCompressionType")]
    public string? TargetCompressionType { get; set; }

    /// <summary>The ARN of the target Kafka cluster.</summary>
    [JsonPropertyName("targetKafkaClusterArn")]
    public string? TargetKafkaClusterArn { get; set; }

    /// <summary>Reference to a Cluster in kafka to populate targetKafkaClusterArn.</summary>
    [JsonPropertyName("targetKafkaClusterArnRef")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnRef? TargetKafkaClusterArnRef { get; set; }

    /// <summary>Selector for a Cluster in kafka to populate targetKafkaClusterArn.</summary>
    [JsonPropertyName("targetKafkaClusterArnSelector")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoListTargetKafkaClusterArnSelector? TargetKafkaClusterArnSelector { get; set; }

    /// <summary>Configuration relating to topic replication.</summary>
    [JsonPropertyName("topicReplication")]
    public IList<V1beta1ReplicatorSpecInitProviderReplicationInfoListTopicReplication>? TopicReplication { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecInitProvider
{
    /// <summary>A summary description of the replicator.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A list of Kafka clusters which are targets of the replicator.</summary>
    [JsonPropertyName("kafkaCluster")]
    public IList<V1beta1ReplicatorSpecInitProviderKafkaCluster>? KafkaCluster { get; set; }

    /// <summary>A list of replication configurations, where each configuration targets a given source cluster to target cluster replication flow.</summary>
    [JsonPropertyName("replicationInfoList")]
    public V1beta1ReplicatorSpecInitProviderReplicationInfoList? ReplicationInfoList { get; set; }

    /// <summary>The name of the replicator.</summary>
    [JsonPropertyName("replicatorName")]
    public string? ReplicatorName { get; set; }

    /// <summary>The ARN of the IAM role used by the replicator to access resources in the customer's account (e.g source and target clusters).</summary>
    [JsonPropertyName("serviceExecutionRoleArn")]
    public string? ServiceExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceExecutionRoleArn.</summary>
    [JsonPropertyName("serviceExecutionRoleArnRef")]
    public V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnRef? ServiceExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceExecutionRoleArn.</summary>
    [JsonPropertyName("serviceExecutionRoleArnSelector")]
    public V1beta1ReplicatorSpecInitProviderServiceExecutionRoleArnSelector? ServiceExecutionRoleArnSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecProviderConfigRefPolicy
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
public partial class V1beta1ReplicatorSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1ReplicatorSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicatorSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ReplicatorSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ReplicatorSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ReplicatorSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ReplicatorSpec defines the desired state of Replicator</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ReplicatorSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ReplicatorSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ReplicatorSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ReplicatorSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ReplicatorSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Details of an Amazon MSK cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderKafkaClusterAmazonMskCluster
{
    /// <summary>The ARN of an Amazon MSK cluster.</summary>
    [JsonPropertyName("mskClusterArn")]
    public string? MskClusterArn { get; set; }
}

/// <summary>Details of an Amazon VPC which has network connectivity to the Apache Kafka cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderKafkaClusterVpcConfig
{
    /// <summary>The AWS security groups to associate with the ENIs used by the replicator. If a security group is not specified, the default security group associated with the VPC is used.</summary>
    [JsonPropertyName("securityGroupsIds")]
    public IList<string>? SecurityGroupsIds { get; set; }

    /// <summary>The list of subnets to connect to in the virtual private cloud (VPC). AWS creates elastic network interfaces inside these subnets to allow communication between your Kafka Cluster and the replicator.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderKafkaCluster
{
    /// <summary>Details of an Amazon MSK cluster.</summary>
    [JsonPropertyName("amazonMskCluster")]
    public V1beta1ReplicatorStatusAtProviderKafkaClusterAmazonMskCluster? AmazonMskCluster { get; set; }

    /// <summary>Details of an Amazon VPC which has network connectivity to the Apache Kafka cluster.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta1ReplicatorStatusAtProviderKafkaClusterVpcConfig? VpcConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderReplicationInfoListConsumerGroupReplication
{
    /// <summary>List of regular expression patterns indicating the consumer groups that should not be replicated.</summary>
    [JsonPropertyName("consumerGroupsToExclude")]
    public IList<string>? ConsumerGroupsToExclude { get; set; }

    /// <summary>List of regular expression patterns indicating the consumer groups to copy.</summary>
    [JsonPropertyName("consumerGroupsToReplicate")]
    public IList<string>? ConsumerGroupsToReplicate { get; set; }

    /// <summary>Whether to periodically check for new consumer groups.</summary>
    [JsonPropertyName("detectAndCopyNewConsumerGroups")]
    public bool? DetectAndCopyNewConsumerGroups { get; set; }

    /// <summary>Whether to periodically write the translated offsets to __consumer_offsets topic in target cluster.</summary>
    [JsonPropertyName("synchroniseConsumerGroupOffsets")]
    public bool? SynchroniseConsumerGroupOffsets { get; set; }
}

/// <summary>Configuration for specifying the position in the topics to start replicating from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderReplicationInfoListTopicReplicationStartingPosition
{
    /// <summary>The type of topic configuration name. Supports PREFIXED_WITH_SOURCE_CLUSTER_ALIAS and IDENTICAL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderReplicationInfoListTopicReplicationTopicNameConfiguration
{
    /// <summary>The type of topic configuration name. Supports PREFIXED_WITH_SOURCE_CLUSTER_ALIAS and IDENTICAL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderReplicationInfoListTopicReplication
{
    /// <summary>Whether to periodically configure remote topic ACLs to match their corresponding upstream topics.</summary>
    [JsonPropertyName("copyAccessControlListsForTopics")]
    public bool? CopyAccessControlListsForTopics { get; set; }

    /// <summary>Whether to periodically configure remote topics to match their corresponding upstream topics.</summary>
    [JsonPropertyName("copyTopicConfigurations")]
    public bool? CopyTopicConfigurations { get; set; }

    /// <summary>Whether to periodically check for new topics and partitions.</summary>
    [JsonPropertyName("detectAndCopyNewTopics")]
    public bool? DetectAndCopyNewTopics { get; set; }

    /// <summary>Configuration for specifying the position in the topics to start replicating from.</summary>
    [JsonPropertyName("startingPosition")]
    public V1beta1ReplicatorStatusAtProviderReplicationInfoListTopicReplicationStartingPosition? StartingPosition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topicNameConfiguration")]
    public V1beta1ReplicatorStatusAtProviderReplicationInfoListTopicReplicationTopicNameConfiguration? TopicNameConfiguration { get; set; }

    /// <summary>List of regular expression patterns indicating the topics that should not be replica.</summary>
    [JsonPropertyName("topicsToExclude")]
    public IList<string>? TopicsToExclude { get; set; }

    /// <summary>List of regular expression patterns indicating the topics to copy.</summary>
    [JsonPropertyName("topicsToReplicate")]
    public IList<string>? TopicsToReplicate { get; set; }
}

/// <summary>A list of replication configurations, where each configuration targets a given source cluster to target cluster replication flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProviderReplicationInfoList
{
    /// <summary>Configuration relating to consumer group replication.</summary>
    [JsonPropertyName("consumerGroupReplication")]
    public IList<V1beta1ReplicatorStatusAtProviderReplicationInfoListConsumerGroupReplication>? ConsumerGroupReplication { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceKafkaClusterAlias")]
    public string? SourceKafkaClusterAlias { get; set; }

    /// <summary>The ARN of the source Kafka cluster.</summary>
    [JsonPropertyName("sourceKafkaClusterArn")]
    public string? SourceKafkaClusterArn { get; set; }

    /// <summary>The type of compression to use writing records to target Kafka cluster.</summary>
    [JsonPropertyName("targetCompressionType")]
    public string? TargetCompressionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetKafkaClusterAlias")]
    public string? TargetKafkaClusterAlias { get; set; }

    /// <summary>The ARN of the target Kafka cluster.</summary>
    [JsonPropertyName("targetKafkaClusterArn")]
    public string? TargetKafkaClusterArn { get; set; }

    /// <summary>Configuration relating to topic replication.</summary>
    [JsonPropertyName("topicReplication")]
    public IList<V1beta1ReplicatorStatusAtProviderReplicationInfoListTopicReplication>? TopicReplication { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusAtProvider
{
    /// <summary>ARN of the Replicator. Do not begin the description with "An", "The", "Defines", "Indicates", or "Specifies," as these are verbose. In other words, "Indicates the amount of storage," can be rewritten as "Amount of storage," without losing any information.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("currentVersion")]
    public string? CurrentVersion { get; set; }

    /// <summary>A summary description of the replicator.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of Kafka clusters which are targets of the replicator.</summary>
    [JsonPropertyName("kafkaCluster")]
    public IList<V1beta1ReplicatorStatusAtProviderKafkaCluster>? KafkaCluster { get; set; }

    /// <summary>A list of replication configurations, where each configuration targets a given source cluster to target cluster replication flow.</summary>
    [JsonPropertyName("replicationInfoList")]
    public V1beta1ReplicatorStatusAtProviderReplicationInfoList? ReplicationInfoList { get; set; }

    /// <summary>The name of the replicator.</summary>
    [JsonPropertyName("replicatorName")]
    public string? ReplicatorName { get; set; }

    /// <summary>The ARN of the IAM role used by the replicator to access resources in the customer's account (e.g source and target clusters).</summary>
    [JsonPropertyName("serviceExecutionRoleArn")]
    public string? ServiceExecutionRoleArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatusConditions
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

/// <summary>ReplicatorStatus defines the observed state of Replicator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReplicatorStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ReplicatorStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ReplicatorStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Replicator is the Schema for the Replicators API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Replicator : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ReplicatorSpec>, IStatus<V1beta1ReplicatorStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Replicator";
    public const string KubeGroup = "kafka.aws.upbound.io";
    public const string KubePluralName = "replicators";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ReplicatorSpec defines the desired state of Replicator</summary>
    [JsonPropertyName("spec")]
    public V1beta1ReplicatorSpec Spec { get; set; }

    /// <summary>ReplicatorStatus defines the observed state of Replicator.</summary>
    [JsonPropertyName("status")]
    public V1beta1ReplicatorStatus? Status { get; set; }
}

/// <summary>Replicator is the Schema for the Replicators API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ReplicatorList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Replicator>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ReplicatorList";
    public const string KubeGroup = "kafka.aws.upbound.io";
    public const string KubePluralName = "replicators";
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
    public IList<V1beta1Replicator> Items { get; set; }
}