using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kafka.aws.m.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate clientSubnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicy? Policy { get; set; }
}

/// <summary>Access control settings for brokers. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoPublicAccess
{
    /// <summary>Public access type. Valid values: DISABLED, SERVICE_PROVIDED_EIPS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>SASL authentication type details for VPC connectivity. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthenticationSasl
{
    /// <summary>Enables SASL/IAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("iam")]
    public bool? Iam { get; set; }

    /// <summary>Enables SASL/SCRAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("scram")]
    public bool? Scram { get; set; }
}

/// <summary>Configuration block for specifying a client authentication. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication
{
    /// <summary>SASL authentication type details for VPC connectivity. See below.</summary>
    [JsonPropertyName("sasl")]
    public V1beta1ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthenticationSasl? Sasl { get; set; }

    /// <summary>Enables TLS authentication for VPC connectivity.</summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }
}

/// <summary>VPC connectivity access control for brokers. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivity
{
    /// <summary>Configuration block for specifying a client authentication. See below.</summary>
    [JsonPropertyName("clientAuthentication")]
    public V1beta1ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication? ClientAuthentication { get; set; }
}

/// <summary>Information about the cluster access configuration. See below. For security reasons, you can't turn on public access while creating an MSK cluster. However, you can update an existing cluster to make it publicly accessible. You can also create a new cluster and then update it to make it publicly accessible (documentation).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfo
{
    /// <summary>Access control settings for brokers. See below.</summary>
    [JsonPropertyName("publicAccess")]
    public V1beta1ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoPublicAccess? PublicAccess { get; set; }

    /// <summary>VPC connectivity access control for brokers. See below.</summary>
    [JsonPropertyName("vpcConnectivity")]
    public V1beta1ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivity? VpcConnectivity { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicy? Policy { get; set; }
}

/// <summary>A block that contains EBS volume provisioned throughput information. To provision storage throughput, you must choose broker type kafka.m5.4xlarge or larger. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput
{
    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Throughput value of the EBS volumes for the data drive on each kafka broker node in MiB per second. The minimum value is 250. The maximum value varies between broker type. You can refer to the valid values for the maximum volume throughput at the following documentation on throughput bottlenecks</summary>
    [JsonPropertyName("volumeThroughput")]
    public double? VolumeThroughput { get; set; }
}

/// <summary>A block that contains EBS volume information. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfo
{
    /// <summary>A block that contains EBS volume provisioned throughput information. To provision storage throughput, you must choose broker type kafka.m5.4xlarge or larger. See below.</summary>
    [JsonPropertyName("provisionedThroughput")]
    public V1beta1ClusterSpecForProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput? ProvisionedThroughput { get; set; }

    /// <summary>The size in GiB of the EBS volume for the data drive on each broker node. Minimum value of 1 and maximum value of 16384.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }
}

/// <summary>A block that contains information about storage volumes attached to MSK broker nodes. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderBrokerNodeGroupInfoStorageInfo
{
    /// <summary>A block that contains EBS volume information. See below.</summary>
    [JsonPropertyName("ebsStorageInfo")]
    public V1beta1ClusterSpecForProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfo? EbsStorageInfo { get; set; }
}

/// <summary>Configuration block for the broker nodes of the Kafka cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderBrokerNodeGroupInfo
{
    /// <summary>The distribution of broker nodes across availability zones (documentation). Currently the only valid value is DEFAULT.</summary>
    [JsonPropertyName("azDistribution")]
    public string? AzDistribution { get; set; }

    /// <summary>A list of subnets to connect to in client VPC (documentation).</summary>
    [JsonPropertyName("clientSubnets")]
    public IList<string>? ClientSubnets { get; set; }

    /// <summary>References to Subnet in ec2 to populate clientSubnets.</summary>
    [JsonPropertyName("clientSubnetsRefs")]
    public IList<V1beta1ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefs>? ClientSubnetsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate clientSubnets.</summary>
    [JsonPropertyName("clientSubnetsSelector")]
    public V1beta1ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelector? ClientSubnetsSelector { get; set; }

    /// <summary>Information about the cluster access configuration. See below. For security reasons, you can't turn on public access while creating an MSK cluster. However, you can update an existing cluster to make it publicly accessible. You can also create a new cluster and then update it to make it publicly accessible (documentation).</summary>
    [JsonPropertyName("connectivityInfo")]
    public V1beta1ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfo? ConnectivityInfo { get; set; }

    /// <summary>Specify the instance type to use for the kafka brokersE.g., kafka.m5.large. (Pricing info)</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>A list of the security groups to associate with the elastic network interfaces to control who can communicate with the cluster.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupsRefs")]
    public IList<V1beta1ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefs>? SecurityGroupsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupsSelector")]
    public V1beta1ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelector? SecurityGroupsSelector { get; set; }

    /// <summary>A block that contains information about storage volumes attached to MSK broker nodes. See below.</summary>
    [JsonPropertyName("storageInfo")]
    public V1beta1ClusterSpecForProviderBrokerNodeGroupInfoStorageInfo? StorageInfo { get; set; }
}

/// <summary>SASL authentication type details for VPC connectivity. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClientAuthenticationSasl
{
    /// <summary>Enables SASL/IAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("iam")]
    public bool? Iam { get; set; }

    /// <summary>Enables SASL/SCRAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("scram")]
    public bool? Scram { get; set; }
}

/// <summary>Enables TLS authentication for VPC connectivity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClientAuthenticationTls
{
    /// <summary>List of ACM Certificate Authority Amazon Resource Names (ARNs).</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary>Configuration block for specifying a client authentication. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClientAuthentication
{
    /// <summary>SASL authentication type details for VPC connectivity. See below.</summary>
    [JsonPropertyName("sasl")]
    public V1beta1ClusterSpecForProviderClientAuthenticationSasl? Sasl { get; set; }

    /// <summary>Enables TLS authentication for VPC connectivity.</summary>
    [JsonPropertyName("tls")]
    public V1beta1ClusterSpecForProviderClientAuthenticationTls? Tls { get; set; }

    /// <summary>Enables unauthenticated access.</summary>
    [JsonPropertyName("unauthenticated")]
    public bool? Unauthenticated { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderConfigurationInfoArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Configuration in kafka to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderConfigurationInfoArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderConfigurationInfoArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderConfigurationInfoArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Configuration in kafka to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderConfigurationInfoArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderConfigurationInfoArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for specifying a MSK Configuration to attach to Kafka brokers. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderConfigurationInfo
{
    /// <summary>Amazon Resource Name (ARN) of the MSK Configuration to use in the cluster.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a Configuration in kafka to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1ClusterSpecForProviderConfigurationInfoArnRef? ArnRef { get; set; }

    /// <summary>Selector for a Configuration in kafka to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1ClusterSpecForProviderConfigurationInfoArnSelector? ArnSelector { get; set; }

    /// <summary>Revision of the MSK Configuration to use in the cluster.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block to specify encryption in transit. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderEncryptionInfoEncryptionInTransit
{
    /// <summary>Encryption setting for data in transit between clients and brokers. Valid values: TLS, TLS_PLAINTEXT, and PLAINTEXT. Default value is TLS.</summary>
    [JsonPropertyName("clientBroker")]
    public string? ClientBroker { get; set; }

    /// <summary>Whether data communication among broker nodes is encrypted. Default value: true.</summary>
    [JsonPropertyName("inCluster")]
    public bool? InCluster { get; set; }
}

/// <summary>Configuration block for specifying encryption. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderEncryptionInfo
{
    /// <summary>The ARN of the KMS key used for encryption at rest of the broker data volumes.</summary>
    [JsonPropertyName("encryptionAtRestKmsKeyArn")]
    public string? EncryptionAtRestKmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
    [JsonPropertyName("encryptionAtRestKmsKeyArnRef")]
    public V1beta1ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRef? EncryptionAtRestKmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
    [JsonPropertyName("encryptionAtRestKmsKeyArnSelector")]
    public V1beta1ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelector? EncryptionAtRestKmsKeyArnSelector { get; set; }

    /// <summary>Configuration block to specify encryption in transit. See below.</summary>
    [JsonPropertyName("encryptionInTransit")]
    public V1beta1ClusterSpecForProviderEncryptionInfoEncryptionInTransit? EncryptionInTransit { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogs
{
    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Name of the Cloudwatch Log Group to deliver logs to.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupRef")]
    public V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRef? LogGroupRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupSelector")]
    public V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelector? LogGroupSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsFirehose
{
    /// <summary>Name of the Kinesis Data Firehose delivery stream to deliver logs to.</summary>
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamRef")]
    public V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRef? DeliveryStreamRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamSelector")]
    public V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelector? DeliveryStreamSelector { get; set; }

    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsS3
{
    /// <summary>Name of the S3 bucket to deliver logs to.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelector? BucketSelector { get; set; }

    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Prefix to append to the folder name.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Configuration block for Broker Logs settings for logging info. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingInfoBrokerLogs
{
    /// <summary></summary>
    [JsonPropertyName("cloudwatchLogs")]
    public V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogs? CloudwatchLogs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firehose")]
    public V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsFirehose? Firehose { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public V1beta1ClusterSpecForProviderLoggingInfoBrokerLogsS3? S3 { get; set; }
}

/// <summary>Configuration block for streaming broker logs to Cloudwatch/S3/Kinesis Firehose. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingInfo
{
    /// <summary>Configuration block for Broker Logs settings for logging info. See below.</summary>
    [JsonPropertyName("brokerLogs")]
    public V1beta1ClusterSpecForProviderLoggingInfoBrokerLogs? BrokerLogs { get; set; }
}

/// <summary>Configuration block for JMX Exporter. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderOpenMonitoringPrometheusJmxExporter
{
    /// <summary>Indicates whether you want to enable or disable the JMX Exporter.</summary>
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary>Configuration block for Node Exporter. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderOpenMonitoringPrometheusNodeExporter
{
    /// <summary>Indicates whether you want to enable or disable the JMX Exporter.</summary>
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary>Configuration block for Prometheus settings for open monitoring. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderOpenMonitoringPrometheus
{
    /// <summary>Configuration block for JMX Exporter. See below.</summary>
    [JsonPropertyName("jmxExporter")]
    public V1beta1ClusterSpecForProviderOpenMonitoringPrometheusJmxExporter? JmxExporter { get; set; }

    /// <summary>Configuration block for Node Exporter. See below.</summary>
    [JsonPropertyName("nodeExporter")]
    public V1beta1ClusterSpecForProviderOpenMonitoringPrometheusNodeExporter? NodeExporter { get; set; }
}

/// <summary>Configuration block for JMX and Node monitoring for the MSK cluster. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderOpenMonitoring
{
    /// <summary>Configuration block for Prometheus settings for open monitoring. See below.</summary>
    [JsonPropertyName("prometheus")]
    public V1beta1ClusterSpecForProviderOpenMonitoringPrometheus? Prometheus { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProvider
{
    /// <summary>Configuration block for the broker nodes of the Kafka cluster.</summary>
    [JsonPropertyName("brokerNodeGroupInfo")]
    public V1beta1ClusterSpecForProviderBrokerNodeGroupInfo? BrokerNodeGroupInfo { get; set; }

    /// <summary>Configuration block for specifying a client authentication. See below.</summary>
    [JsonPropertyName("clientAuthentication")]
    public V1beta1ClusterSpecForProviderClientAuthentication? ClientAuthentication { get; set; }

    /// <summary>Name of the MSK cluster.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Configuration block for specifying a MSK Configuration to attach to Kafka brokers. See below.</summary>
    [JsonPropertyName("configurationInfo")]
    public V1beta1ClusterSpecForProviderConfigurationInfo? ConfigurationInfo { get; set; }

    /// <summary>Configuration block for specifying encryption. See below.</summary>
    [JsonPropertyName("encryptionInfo")]
    public V1beta1ClusterSpecForProviderEncryptionInfo? EncryptionInfo { get; set; }

    /// <summary>Specify the desired enhanced MSK CloudWatch monitoring level. See Monitoring Amazon MSK with Amazon CloudWatch</summary>
    [JsonPropertyName("enhancedMonitoring")]
    public string? EnhancedMonitoring { get; set; }

    /// <summary>Specify the desired Kafka software version.</summary>
    [JsonPropertyName("kafkaVersion")]
    public string? KafkaVersion { get; set; }

    /// <summary>Configuration block for streaming broker logs to Cloudwatch/S3/Kinesis Firehose. See below.</summary>
    [JsonPropertyName("loggingInfo")]
    public V1beta1ClusterSpecForProviderLoggingInfo? LoggingInfo { get; set; }

    /// <summary>The desired total number of broker nodes in the kafka cluster.  It must be a multiple of the number of specified client subnets.</summary>
    [JsonPropertyName("numberOfBrokerNodes")]
    public double? NumberOfBrokerNodes { get; set; }

    /// <summary>Configuration block for JMX and Node monitoring for the MSK cluster. See below.</summary>
    [JsonPropertyName("openMonitoring")]
    public V1beta1ClusterSpecForProviderOpenMonitoring? OpenMonitoring { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Controls storage mode for supported storage tiers. Valid values are: LOCAL or TIERED.</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate clientSubnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicy? Policy { get; set; }
}

/// <summary>Access control settings for brokers. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoPublicAccess
{
    /// <summary>Public access type. Valid values: DISABLED, SERVICE_PROVIDED_EIPS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>SASL authentication type details for VPC connectivity. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthenticationSasl
{
    /// <summary>Enables SASL/IAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("iam")]
    public bool? Iam { get; set; }

    /// <summary>Enables SASL/SCRAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("scram")]
    public bool? Scram { get; set; }
}

/// <summary>Configuration block for specifying a client authentication. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication
{
    /// <summary>SASL authentication type details for VPC connectivity. See below.</summary>
    [JsonPropertyName("sasl")]
    public V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthenticationSasl? Sasl { get; set; }

    /// <summary>Enables TLS authentication for VPC connectivity.</summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }
}

/// <summary>VPC connectivity access control for brokers. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivity
{
    /// <summary>Configuration block for specifying a client authentication. See below.</summary>
    [JsonPropertyName("clientAuthentication")]
    public V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication? ClientAuthentication { get; set; }
}

/// <summary>Information about the cluster access configuration. See below. For security reasons, you can't turn on public access while creating an MSK cluster. However, you can update an existing cluster to make it publicly accessible. You can also create a new cluster and then update it to make it publicly accessible (documentation).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfo
{
    /// <summary>Access control settings for brokers. See below.</summary>
    [JsonPropertyName("publicAccess")]
    public V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoPublicAccess? PublicAccess { get; set; }

    /// <summary>VPC connectivity access control for brokers. See below.</summary>
    [JsonPropertyName("vpcConnectivity")]
    public V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivity? VpcConnectivity { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicy? Policy { get; set; }
}

/// <summary>A block that contains EBS volume provisioned throughput information. To provision storage throughput, you must choose broker type kafka.m5.4xlarge or larger. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput
{
    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Throughput value of the EBS volumes for the data drive on each kafka broker node in MiB per second. The minimum value is 250. The maximum value varies between broker type. You can refer to the valid values for the maximum volume throughput at the following documentation on throughput bottlenecks</summary>
    [JsonPropertyName("volumeThroughput")]
    public double? VolumeThroughput { get; set; }
}

/// <summary>A block that contains EBS volume information. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfo
{
    /// <summary>A block that contains EBS volume provisioned throughput information. To provision storage throughput, you must choose broker type kafka.m5.4xlarge or larger. See below.</summary>
    [JsonPropertyName("provisionedThroughput")]
    public V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput? ProvisionedThroughput { get; set; }

    /// <summary>The size in GiB of the EBS volume for the data drive on each broker node. Minimum value of 1 and maximum value of 16384.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }
}

/// <summary>A block that contains information about storage volumes attached to MSK broker nodes. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoStorageInfo
{
    /// <summary>A block that contains EBS volume information. See below.</summary>
    [JsonPropertyName("ebsStorageInfo")]
    public V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfo? EbsStorageInfo { get; set; }
}

/// <summary>Configuration block for the broker nodes of the Kafka cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderBrokerNodeGroupInfo
{
    /// <summary>The distribution of broker nodes across availability zones (documentation). Currently the only valid value is DEFAULT.</summary>
    [JsonPropertyName("azDistribution")]
    public string? AzDistribution { get; set; }

    /// <summary>A list of subnets to connect to in client VPC (documentation).</summary>
    [JsonPropertyName("clientSubnets")]
    public IList<string>? ClientSubnets { get; set; }

    /// <summary>References to Subnet in ec2 to populate clientSubnets.</summary>
    [JsonPropertyName("clientSubnetsRefs")]
    public IList<V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefs>? ClientSubnetsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate clientSubnets.</summary>
    [JsonPropertyName("clientSubnetsSelector")]
    public V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelector? ClientSubnetsSelector { get; set; }

    /// <summary>Information about the cluster access configuration. See below. For security reasons, you can't turn on public access while creating an MSK cluster. However, you can update an existing cluster to make it publicly accessible. You can also create a new cluster and then update it to make it publicly accessible (documentation).</summary>
    [JsonPropertyName("connectivityInfo")]
    public V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfo? ConnectivityInfo { get; set; }

    /// <summary>Specify the instance type to use for the kafka brokersE.g., kafka.m5.large. (Pricing info)</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>A list of the security groups to associate with the elastic network interfaces to control who can communicate with the cluster.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupsRefs")]
    public IList<V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefs>? SecurityGroupsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupsSelector")]
    public V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelector? SecurityGroupsSelector { get; set; }

    /// <summary>A block that contains information about storage volumes attached to MSK broker nodes. See below.</summary>
    [JsonPropertyName("storageInfo")]
    public V1beta1ClusterSpecInitProviderBrokerNodeGroupInfoStorageInfo? StorageInfo { get; set; }
}

/// <summary>SASL authentication type details for VPC connectivity. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClientAuthenticationSasl
{
    /// <summary>Enables SASL/IAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("iam")]
    public bool? Iam { get; set; }

    /// <summary>Enables SASL/SCRAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("scram")]
    public bool? Scram { get; set; }
}

/// <summary>Enables TLS authentication for VPC connectivity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClientAuthenticationTls
{
    /// <summary>List of ACM Certificate Authority Amazon Resource Names (ARNs).</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary>Configuration block for specifying a client authentication. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClientAuthentication
{
    /// <summary>SASL authentication type details for VPC connectivity. See below.</summary>
    [JsonPropertyName("sasl")]
    public V1beta1ClusterSpecInitProviderClientAuthenticationSasl? Sasl { get; set; }

    /// <summary>Enables TLS authentication for VPC connectivity.</summary>
    [JsonPropertyName("tls")]
    public V1beta1ClusterSpecInitProviderClientAuthenticationTls? Tls { get; set; }

    /// <summary>Enables unauthenticated access.</summary>
    [JsonPropertyName("unauthenticated")]
    public bool? Unauthenticated { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderConfigurationInfoArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Configuration in kafka to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderConfigurationInfoArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderConfigurationInfoArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderConfigurationInfoArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Configuration in kafka to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderConfigurationInfoArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderConfigurationInfoArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for specifying a MSK Configuration to attach to Kafka brokers. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderConfigurationInfo
{
    /// <summary>Amazon Resource Name (ARN) of the MSK Configuration to use in the cluster.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a Configuration in kafka to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1ClusterSpecInitProviderConfigurationInfoArnRef? ArnRef { get; set; }

    /// <summary>Selector for a Configuration in kafka to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1ClusterSpecInitProviderConfigurationInfoArnSelector? ArnSelector { get; set; }

    /// <summary>Revision of the MSK Configuration to use in the cluster.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block to specify encryption in transit. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderEncryptionInfoEncryptionInTransit
{
    /// <summary>Encryption setting for data in transit between clients and brokers. Valid values: TLS, TLS_PLAINTEXT, and PLAINTEXT. Default value is TLS.</summary>
    [JsonPropertyName("clientBroker")]
    public string? ClientBroker { get; set; }

    /// <summary>Whether data communication among broker nodes is encrypted. Default value: true.</summary>
    [JsonPropertyName("inCluster")]
    public bool? InCluster { get; set; }
}

/// <summary>Configuration block for specifying encryption. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderEncryptionInfo
{
    /// <summary>The ARN of the KMS key used for encryption at rest of the broker data volumes.</summary>
    [JsonPropertyName("encryptionAtRestKmsKeyArn")]
    public string? EncryptionAtRestKmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
    [JsonPropertyName("encryptionAtRestKmsKeyArnRef")]
    public V1beta1ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRef? EncryptionAtRestKmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
    [JsonPropertyName("encryptionAtRestKmsKeyArnSelector")]
    public V1beta1ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelector? EncryptionAtRestKmsKeyArnSelector { get; set; }

    /// <summary>Configuration block to specify encryption in transit. See below.</summary>
    [JsonPropertyName("encryptionInTransit")]
    public V1beta1ClusterSpecInitProviderEncryptionInfoEncryptionInTransit? EncryptionInTransit { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogs
{
    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Name of the Cloudwatch Log Group to deliver logs to.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupRef")]
    public V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRef? LogGroupRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupSelector")]
    public V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelector? LogGroupSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsFirehose
{
    /// <summary>Name of the Kinesis Data Firehose delivery stream to deliver logs to.</summary>
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamRef")]
    public V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRef? DeliveryStreamRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamSelector")]
    public V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelector? DeliveryStreamSelector { get; set; }

    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsS3
{
    /// <summary>Name of the S3 bucket to deliver logs to.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelector? BucketSelector { get; set; }

    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Prefix to append to the folder name.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Configuration block for Broker Logs settings for logging info. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogs
{
    /// <summary></summary>
    [JsonPropertyName("cloudwatchLogs")]
    public V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogs? CloudwatchLogs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firehose")]
    public V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsFirehose? Firehose { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogsS3? S3 { get; set; }
}

/// <summary>Configuration block for streaming broker logs to Cloudwatch/S3/Kinesis Firehose. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingInfo
{
    /// <summary>Configuration block for Broker Logs settings for logging info. See below.</summary>
    [JsonPropertyName("brokerLogs")]
    public V1beta1ClusterSpecInitProviderLoggingInfoBrokerLogs? BrokerLogs { get; set; }
}

/// <summary>Configuration block for JMX Exporter. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderOpenMonitoringPrometheusJmxExporter
{
    /// <summary>Indicates whether you want to enable or disable the JMX Exporter.</summary>
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary>Configuration block for Node Exporter. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderOpenMonitoringPrometheusNodeExporter
{
    /// <summary>Indicates whether you want to enable or disable the JMX Exporter.</summary>
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary>Configuration block for Prometheus settings for open monitoring. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderOpenMonitoringPrometheus
{
    /// <summary>Configuration block for JMX Exporter. See below.</summary>
    [JsonPropertyName("jmxExporter")]
    public V1beta1ClusterSpecInitProviderOpenMonitoringPrometheusJmxExporter? JmxExporter { get; set; }

    /// <summary>Configuration block for Node Exporter. See below.</summary>
    [JsonPropertyName("nodeExporter")]
    public V1beta1ClusterSpecInitProviderOpenMonitoringPrometheusNodeExporter? NodeExporter { get; set; }
}

/// <summary>Configuration block for JMX and Node monitoring for the MSK cluster. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderOpenMonitoring
{
    /// <summary>Configuration block for Prometheus settings for open monitoring. See below.</summary>
    [JsonPropertyName("prometheus")]
    public V1beta1ClusterSpecInitProviderOpenMonitoringPrometheus? Prometheus { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProvider
{
    /// <summary>Configuration block for the broker nodes of the Kafka cluster.</summary>
    [JsonPropertyName("brokerNodeGroupInfo")]
    public V1beta1ClusterSpecInitProviderBrokerNodeGroupInfo? BrokerNodeGroupInfo { get; set; }

    /// <summary>Configuration block for specifying a client authentication. See below.</summary>
    [JsonPropertyName("clientAuthentication")]
    public V1beta1ClusterSpecInitProviderClientAuthentication? ClientAuthentication { get; set; }

    /// <summary>Name of the MSK cluster.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Configuration block for specifying a MSK Configuration to attach to Kafka brokers. See below.</summary>
    [JsonPropertyName("configurationInfo")]
    public V1beta1ClusterSpecInitProviderConfigurationInfo? ConfigurationInfo { get; set; }

    /// <summary>Configuration block for specifying encryption. See below.</summary>
    [JsonPropertyName("encryptionInfo")]
    public V1beta1ClusterSpecInitProviderEncryptionInfo? EncryptionInfo { get; set; }

    /// <summary>Specify the desired enhanced MSK CloudWatch monitoring level. See Monitoring Amazon MSK with Amazon CloudWatch</summary>
    [JsonPropertyName("enhancedMonitoring")]
    public string? EnhancedMonitoring { get; set; }

    /// <summary>Specify the desired Kafka software version.</summary>
    [JsonPropertyName("kafkaVersion")]
    public string? KafkaVersion { get; set; }

    /// <summary>Configuration block for streaming broker logs to Cloudwatch/S3/Kinesis Firehose. See below.</summary>
    [JsonPropertyName("loggingInfo")]
    public V1beta1ClusterSpecInitProviderLoggingInfo? LoggingInfo { get; set; }

    /// <summary>The desired total number of broker nodes in the kafka cluster.  It must be a multiple of the number of specified client subnets.</summary>
    [JsonPropertyName("numberOfBrokerNodes")]
    public double? NumberOfBrokerNodes { get; set; }

    /// <summary>Configuration block for JMX and Node monitoring for the MSK cluster. See below.</summary>
    [JsonPropertyName("openMonitoring")]
    public V1beta1ClusterSpecInitProviderOpenMonitoring? OpenMonitoring { get; set; }

    /// <summary>Controls storage mode for supported storage tiers. Valid values are: LOCAL or TIERED.</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ClusterSpec defines the desired state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ClusterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Access control settings for brokers. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoPublicAccess
{
    /// <summary>Public access type. Valid values: DISABLED, SERVICE_PROVIDED_EIPS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>SASL authentication type details for VPC connectivity. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthenticationSasl
{
    /// <summary>Enables SASL/IAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("iam")]
    public bool? Iam { get; set; }

    /// <summary>Enables SASL/SCRAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("scram")]
    public bool? Scram { get; set; }
}

/// <summary>Configuration block for specifying a client authentication. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication
{
    /// <summary>SASL authentication type details for VPC connectivity. See below.</summary>
    [JsonPropertyName("sasl")]
    public V1beta1ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthenticationSasl? Sasl { get; set; }

    /// <summary>Enables TLS authentication for VPC connectivity.</summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }
}

/// <summary>VPC connectivity access control for brokers. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivity
{
    /// <summary>Configuration block for specifying a client authentication. See below.</summary>
    [JsonPropertyName("clientAuthentication")]
    public V1beta1ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication? ClientAuthentication { get; set; }
}

/// <summary>Information about the cluster access configuration. See below. For security reasons, you can't turn on public access while creating an MSK cluster. However, you can update an existing cluster to make it publicly accessible. You can also create a new cluster and then update it to make it publicly accessible (documentation).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfo
{
    /// <summary>Access control settings for brokers. See below.</summary>
    [JsonPropertyName("publicAccess")]
    public V1beta1ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoPublicAccess? PublicAccess { get; set; }

    /// <summary>VPC connectivity access control for brokers. See below.</summary>
    [JsonPropertyName("vpcConnectivity")]
    public V1beta1ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivity? VpcConnectivity { get; set; }
}

/// <summary>A block that contains EBS volume provisioned throughput information. To provision storage throughput, you must choose broker type kafka.m5.4xlarge or larger. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput
{
    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Throughput value of the EBS volumes for the data drive on each kafka broker node in MiB per second. The minimum value is 250. The maximum value varies between broker type. You can refer to the valid values for the maximum volume throughput at the following documentation on throughput bottlenecks</summary>
    [JsonPropertyName("volumeThroughput")]
    public double? VolumeThroughput { get; set; }
}

/// <summary>A block that contains EBS volume information. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfo
{
    /// <summary>A block that contains EBS volume provisioned throughput information. To provision storage throughput, you must choose broker type kafka.m5.4xlarge or larger. See below.</summary>
    [JsonPropertyName("provisionedThroughput")]
    public V1beta1ClusterStatusAtProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput? ProvisionedThroughput { get; set; }

    /// <summary>The size in GiB of the EBS volume for the data drive on each broker node. Minimum value of 1 and maximum value of 16384.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }
}

/// <summary>A block that contains information about storage volumes attached to MSK broker nodes. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderBrokerNodeGroupInfoStorageInfo
{
    /// <summary>A block that contains EBS volume information. See below.</summary>
    [JsonPropertyName("ebsStorageInfo")]
    public V1beta1ClusterStatusAtProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfo? EbsStorageInfo { get; set; }
}

/// <summary>Configuration block for the broker nodes of the Kafka cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderBrokerNodeGroupInfo
{
    /// <summary>The distribution of broker nodes across availability zones (documentation). Currently the only valid value is DEFAULT.</summary>
    [JsonPropertyName("azDistribution")]
    public string? AzDistribution { get; set; }

    /// <summary>A list of subnets to connect to in client VPC (documentation).</summary>
    [JsonPropertyName("clientSubnets")]
    public IList<string>? ClientSubnets { get; set; }

    /// <summary>Information about the cluster access configuration. See below. For security reasons, you can't turn on public access while creating an MSK cluster. However, you can update an existing cluster to make it publicly accessible. You can also create a new cluster and then update it to make it publicly accessible (documentation).</summary>
    [JsonPropertyName("connectivityInfo")]
    public V1beta1ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfo? ConnectivityInfo { get; set; }

    /// <summary>Specify the instance type to use for the kafka brokersE.g., kafka.m5.large. (Pricing info)</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>A list of the security groups to associate with the elastic network interfaces to control who can communicate with the cluster.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>A block that contains information about storage volumes attached to MSK broker nodes. See below.</summary>
    [JsonPropertyName("storageInfo")]
    public V1beta1ClusterStatusAtProviderBrokerNodeGroupInfoStorageInfo? StorageInfo { get; set; }
}

/// <summary>SASL authentication type details for VPC connectivity. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClientAuthenticationSasl
{
    /// <summary>Enables SASL/IAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("iam")]
    public bool? Iam { get; set; }

    /// <summary>Enables SASL/SCRAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("scram")]
    public bool? Scram { get; set; }
}

/// <summary>Enables TLS authentication for VPC connectivity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClientAuthenticationTls
{
    /// <summary>List of ACM Certificate Authority Amazon Resource Names (ARNs).</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary>Configuration block for specifying a client authentication. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClientAuthentication
{
    /// <summary>SASL authentication type details for VPC connectivity. See below.</summary>
    [JsonPropertyName("sasl")]
    public V1beta1ClusterStatusAtProviderClientAuthenticationSasl? Sasl { get; set; }

    /// <summary>Enables TLS authentication for VPC connectivity.</summary>
    [JsonPropertyName("tls")]
    public V1beta1ClusterStatusAtProviderClientAuthenticationTls? Tls { get; set; }

    /// <summary>Enables unauthenticated access.</summary>
    [JsonPropertyName("unauthenticated")]
    public bool? Unauthenticated { get; set; }
}

/// <summary>Configuration block for specifying a MSK Configuration to attach to Kafka brokers. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderConfigurationInfo
{
    /// <summary>Amazon Resource Name (ARN) of the MSK Configuration to use in the cluster.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Revision of the MSK Configuration to use in the cluster.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }
}

/// <summary>Configuration block to specify encryption in transit. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderEncryptionInfoEncryptionInTransit
{
    /// <summary>Encryption setting for data in transit between clients and brokers. Valid values: TLS, TLS_PLAINTEXT, and PLAINTEXT. Default value is TLS.</summary>
    [JsonPropertyName("clientBroker")]
    public string? ClientBroker { get; set; }

    /// <summary>Whether data communication among broker nodes is encrypted. Default value: true.</summary>
    [JsonPropertyName("inCluster")]
    public bool? InCluster { get; set; }
}

/// <summary>Configuration block for specifying encryption. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderEncryptionInfo
{
    /// <summary>The ARN of the KMS key used for encryption at rest of the broker data volumes.</summary>
    [JsonPropertyName("encryptionAtRestKmsKeyArn")]
    public string? EncryptionAtRestKmsKeyArn { get; set; }

    /// <summary>Configuration block to specify encryption in transit. See below.</summary>
    [JsonPropertyName("encryptionInTransit")]
    public V1beta1ClusterStatusAtProviderEncryptionInfoEncryptionInTransit? EncryptionInTransit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderLoggingInfoBrokerLogsCloudwatchLogs
{
    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Name of the Cloudwatch Log Group to deliver logs to.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderLoggingInfoBrokerLogsFirehose
{
    /// <summary>Name of the Kinesis Data Firehose delivery stream to deliver logs to.</summary>
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }

    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderLoggingInfoBrokerLogsS3
{
    /// <summary>Name of the S3 bucket to deliver logs to.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Prefix to append to the folder name.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Configuration block for Broker Logs settings for logging info. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderLoggingInfoBrokerLogs
{
    /// <summary></summary>
    [JsonPropertyName("cloudwatchLogs")]
    public V1beta1ClusterStatusAtProviderLoggingInfoBrokerLogsCloudwatchLogs? CloudwatchLogs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firehose")]
    public V1beta1ClusterStatusAtProviderLoggingInfoBrokerLogsFirehose? Firehose { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public V1beta1ClusterStatusAtProviderLoggingInfoBrokerLogsS3? S3 { get; set; }
}

/// <summary>Configuration block for streaming broker logs to Cloudwatch/S3/Kinesis Firehose. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderLoggingInfo
{
    /// <summary>Configuration block for Broker Logs settings for logging info. See below.</summary>
    [JsonPropertyName("brokerLogs")]
    public V1beta1ClusterStatusAtProviderLoggingInfoBrokerLogs? BrokerLogs { get; set; }
}

/// <summary>Configuration block for JMX Exporter. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderOpenMonitoringPrometheusJmxExporter
{
    /// <summary>Indicates whether you want to enable or disable the JMX Exporter.</summary>
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary>Configuration block for Node Exporter. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderOpenMonitoringPrometheusNodeExporter
{
    /// <summary>Indicates whether you want to enable or disable the JMX Exporter.</summary>
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary>Configuration block for Prometheus settings for open monitoring. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderOpenMonitoringPrometheus
{
    /// <summary>Configuration block for JMX Exporter. See below.</summary>
    [JsonPropertyName("jmxExporter")]
    public V1beta1ClusterStatusAtProviderOpenMonitoringPrometheusJmxExporter? JmxExporter { get; set; }

    /// <summary>Configuration block for Node Exporter. See below.</summary>
    [JsonPropertyName("nodeExporter")]
    public V1beta1ClusterStatusAtProviderOpenMonitoringPrometheusNodeExporter? NodeExporter { get; set; }
}

/// <summary>Configuration block for JMX and Node monitoring for the MSK cluster. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderOpenMonitoring
{
    /// <summary>Configuration block for Prometheus settings for open monitoring. See below.</summary>
    [JsonPropertyName("prometheus")]
    public V1beta1ClusterStatusAtProviderOpenMonitoringPrometheus? Prometheus { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of the MSK Configuration to use in the cluster.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Comma separated list of one or more hostname:port pairs of kafka brokers suitable to bootstrap connectivity to the kafka cluster. Contains a value if encryption_info.0.encryption_in_transit.0.client_broker is set to PLAINTEXT or TLS_PLAINTEXT. The resource sorts values alphabetically. AWS may not always return all endpoints so this value is not guaranteed to be stable across applies.</summary>
    [JsonPropertyName("bootstrapBrokers")]
    public string? BootstrapBrokers { get; set; }

    /// <summary>One or more DNS names (or IP addresses) and SASL IAM port pairs. For example, b-1-public.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9198,b-2-public.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9198,b-3-public.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9198. This attribute will have a value if encryption_info.0.encryption_in_transit.0.client_broker is set to TLS_PLAINTEXT or TLS and client_authentication.0.sasl.0.iam is set to true and broker_node_group_info.0.connectivity_info.0.public_access.0.type is set to SERVICE_PROVIDED_EIPS and the cluster fulfill all other requirements for public access. The resource sorts the list alphabetically. AWS may not always return all endpoints so the values may not be stable across applies.</summary>
    [JsonPropertyName("bootstrapBrokersPublicSaslIam")]
    public string? BootstrapBrokersPublicSaslIam { get; set; }

    /// <summary>One or more DNS names (or IP addresses) and SASL SCRAM port pairs. For example, b-1-public.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9196,b-2-public.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9196,b-3-public.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9196. This attribute will have a value if encryption_info.0.encryption_in_transit.0.client_broker is set to TLS_PLAINTEXT or TLS and client_authentication.0.sasl.0.scram is set to true and broker_node_group_info.0.connectivity_info.0.public_access.0.type is set to SERVICE_PROVIDED_EIPS and the cluster fulfill all other requirements for public access. The resource sorts the list alphabetically. AWS may not always return all endpoints so the values may not be stable across applies.</summary>
    [JsonPropertyName("bootstrapBrokersPublicSaslScram")]
    public string? BootstrapBrokersPublicSaslScram { get; set; }

    /// <summary>One or more DNS names (or IP addresses) and TLS port pairs. For example, b-1-public.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9194,b-2-public.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9194,b-3-public.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9194. This attribute will have a value if encryption_info.0.encryption_in_transit.0.client_broker is set to TLS_PLAINTEXT or TLS and broker_node_group_info.0.connectivity_info.0.public_access.0.type is set to SERVICE_PROVIDED_EIPS and the cluster fulfill all other requirements for public access. The resource sorts the list alphabetically. AWS may not always return all endpoints so the values may not be stable across applies.</summary>
    [JsonPropertyName("bootstrapBrokersPublicTls")]
    public string? BootstrapBrokersPublicTls { get; set; }

    /// <summary>One or more DNS names (or IP addresses) and SASL IAM port pairs. For example, b-1.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9098,b-2.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9098,b-3.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9098. This attribute will have a value if encryption_info.0.encryption_in_transit.0.client_broker is set to TLS_PLAINTEXT or TLS and client_authentication.0.sasl.0.iam is set to true. The resource sorts the list alphabetically. AWS may not always return all endpoints so the values may not be stable across applies.</summary>
    [JsonPropertyName("bootstrapBrokersSaslIam")]
    public string? BootstrapBrokersSaslIam { get; set; }

    /// <summary>One or more DNS names (or IP addresses) and SASL SCRAM port pairs. For example, b-1.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9096,b-2.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9096,b-3.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9096. This attribute will have a value if encryption_info.0.encryption_in_transit.0.client_broker is set to TLS_PLAINTEXT or TLS and client_authentication.0.sasl.0.scram is set to true. The resource sorts the list alphabetically. AWS may not always return all endpoints so the values may not be stable across applies.</summary>
    [JsonPropertyName("bootstrapBrokersSaslScram")]
    public string? BootstrapBrokersSaslScram { get; set; }

    /// <summary>One or more DNS names (or IP addresses) and TLS port pairs. For example, b-1.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9094,b-2.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9094,b-3.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9094. This attribute will have a value if encryption_info.0.encryption_in_transit.0.client_broker is set to TLS_PLAINTEXT or TLS. The resource sorts the list alphabetically. AWS may not always return all endpoints so the values may not be stable across applies.</summary>
    [JsonPropertyName("bootstrapBrokersTls")]
    public string? BootstrapBrokersTls { get; set; }

    /// <summary>A string containing one or more DNS names (or IP addresses) and SASL IAM port pairs for VPC connectivity. AWS may not always return all endpoints so the values may not be stable across applies.</summary>
    [JsonPropertyName("bootstrapBrokersVpcConnectivitySaslIam")]
    public string? BootstrapBrokersVpcConnectivitySaslIam { get; set; }

    /// <summary>A string containing one or more DNS names (or IP addresses) and SASL SCRAM port pairs for VPC connectivity. AWS may not always return all endpoints so the values may not be stable across applies.</summary>
    [JsonPropertyName("bootstrapBrokersVpcConnectivitySaslScram")]
    public string? BootstrapBrokersVpcConnectivitySaslScram { get; set; }

    /// <summary>A string containing one or more DNS names (or IP addresses) and TLS port pairs for VPC connectivity. AWS may not always return all endpoints so the values may not be stable across applies.</summary>
    [JsonPropertyName("bootstrapBrokersVpcConnectivityTls")]
    public string? BootstrapBrokersVpcConnectivityTls { get; set; }

    /// <summary>Configuration block for the broker nodes of the Kafka cluster.</summary>
    [JsonPropertyName("brokerNodeGroupInfo")]
    public V1beta1ClusterStatusAtProviderBrokerNodeGroupInfo? BrokerNodeGroupInfo { get; set; }

    /// <summary>Configuration block for specifying a client authentication. See below.</summary>
    [JsonPropertyName("clientAuthentication")]
    public V1beta1ClusterStatusAtProviderClientAuthentication? ClientAuthentication { get; set; }

    /// <summary>Name of the MSK cluster.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>UUID of the MSK cluster, for use in IAM policies.</summary>
    [JsonPropertyName("clusterUuid")]
    public string? ClusterUuid { get; set; }

    /// <summary>Configuration block for specifying a MSK Configuration to attach to Kafka brokers. See below.</summary>
    [JsonPropertyName("configurationInfo")]
    public V1beta1ClusterStatusAtProviderConfigurationInfo? ConfigurationInfo { get; set; }

    /// <summary>Current version of the MSK Cluster used for updates, e.g., K13V1IB3VIYZZH</summary>
    [JsonPropertyName("currentVersion")]
    public string? CurrentVersion { get; set; }

    /// <summary>Configuration block for specifying encryption. See below.</summary>
    [JsonPropertyName("encryptionInfo")]
    public V1beta1ClusterStatusAtProviderEncryptionInfo? EncryptionInfo { get; set; }

    /// <summary>Specify the desired enhanced MSK CloudWatch monitoring level. See Monitoring Amazon MSK with Amazon CloudWatch</summary>
    [JsonPropertyName("enhancedMonitoring")]
    public string? EnhancedMonitoring { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specify the desired Kafka software version.</summary>
    [JsonPropertyName("kafkaVersion")]
    public string? KafkaVersion { get; set; }

    /// <summary>Configuration block for streaming broker logs to Cloudwatch/S3/Kinesis Firehose. See below.</summary>
    [JsonPropertyName("loggingInfo")]
    public V1beta1ClusterStatusAtProviderLoggingInfo? LoggingInfo { get; set; }

    /// <summary>The desired total number of broker nodes in the kafka cluster.  It must be a multiple of the number of specified client subnets.</summary>
    [JsonPropertyName("numberOfBrokerNodes")]
    public double? NumberOfBrokerNodes { get; set; }

    /// <summary>Configuration block for JMX and Node monitoring for the MSK cluster. See below.</summary>
    [JsonPropertyName("openMonitoring")]
    public V1beta1ClusterStatusAtProviderOpenMonitoring? OpenMonitoring { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Controls storage mode for supported storage tiers. Valid values are: LOCAL or TIERED.</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>A comma separated list of one or more hostname:port pairs to use to connect to the Apache Zookeeper cluster. The returned values are sorted alphabetically. The AWS API may not return all endpoints, so this value is not guaranteed to be stable across applies.</summary>
    [JsonPropertyName("zookeeperConnectString")]
    public string? ZookeeperConnectString { get; set; }

    /// <summary>A comma separated list of one or more hostname:port pairs to use to connect to the Apache Zookeeper cluster via TLS. The returned values are sorted alphabetically. The AWS API may not return all endpoints, so this value is not guaranteed to be stable across applies.</summary>
    [JsonPropertyName("zookeeperConnectStringTls")]
    public string? ZookeeperConnectStringTls { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusConditions
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

/// <summary>ClusterStatus defines the observed state of Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Cluster is the Schema for the Clusters API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClusterSpec>, IStatus<V1beta1ClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "kafka.aws.m.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClusterSpec defines the desired state of Cluster</summary>
    [JsonPropertyName("spec")]
    public V1beta1ClusterSpec Spec { get; set; }

    /// <summary>ClusterStatus defines the observed state of Cluster.</summary>
    [JsonPropertyName("status")]
    public V1beta1ClusterStatus? Status { get; set; }
}

/// <summary>Cluster is the Schema for the Clusters API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Cluster>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "kafka.aws.m.upbound.io";
    public const string KubePluralName = "clusters";
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
    public IList<V1beta1Cluster> Items { get; set; }
}