using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kafka.aws.upbound.io;
/// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecDeletionPolicyEnum
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
public enum V1beta2ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolutionEnum
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
public enum V1beta2ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolveEnum
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
public partial class V1beta2ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolutionEnum>))]
    public V1beta2ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolveEnum>))]
    public V1beta2ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefsPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolutionEnum
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
public enum V1beta2ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolveEnum
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
public partial class V1beta2ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolutionEnum>))]
    public V1beta2ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolveEnum>))]
    public V1beta2ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate clientSubnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoPublicAccess
{
    /// <summary>Public access type. Valid values: DISABLED, SERVICE_PROVIDED_EIPS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthenticationSasl
{
    /// <summary>Enables SASL/IAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("iam")]
    public bool? Iam { get; set; }

    /// <summary>Enables SASL/SCRAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("scram")]
    public bool? Scram { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication
{
    /// <summary>SASL authentication type details for VPC connectivity. See below.</summary>
    [JsonPropertyName("sasl")]
    public IList<V1beta2ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthenticationSasl>? Sasl { get; set; }

    /// <summary>Enables TLS authentication for VPC connectivity.</summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivity
{
    /// <summary>Configuration block for specifying a client authentication. See below.</summary>
    [JsonPropertyName("clientAuthentication")]
    public IList<V1beta2ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication>? ClientAuthentication { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfo
{
    /// <summary>Access control settings for brokers. See below.</summary>
    [JsonPropertyName("publicAccess")]
    public IList<V1beta2ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoPublicAccess>? PublicAccess { get; set; }

    /// <summary>VPC connectivity access control for brokers. See below.</summary>
    [JsonPropertyName("vpcConnectivity")]
    public IList<V1beta2ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivity>? VpcConnectivity { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolutionEnum
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
public enum V1beta2ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolveEnum
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
public partial class V1beta2ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolutionEnum>))]
    public V1beta2ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolveEnum>))]
    public V1beta2ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolutionEnum
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
public enum V1beta2ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolveEnum
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
public partial class V1beta2ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolutionEnum>))]
    public V1beta2ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolveEnum>))]
    public V1beta2ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput
{
    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Throughput value of the EBS volumes for the data drive on each kafka broker node in MiB per second. The minimum value is 250. The maximum value varies between broker type. You can refer to the valid values for the maximum volume throughput at the following documentation on throughput bottlenecks</summary>
    [JsonPropertyName("volumeThroughput")]
    public double? VolumeThroughput { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfo
{
    /// <summary>A block that contains EBS volume provisioned throughput information. To provision storage throughput, you must choose broker type kafka.m5.4xlarge or larger. See below.</summary>
    [JsonPropertyName("provisionedThroughput")]
    public IList<V1beta2ClusterSpecForProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput>? ProvisionedThroughput { get; set; }

    /// <summary>The size in GiB of the EBS volume for the data drive on each broker node. Minimum value of 1 and maximum value of 16384.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderBrokerNodeGroupInfoStorageInfo
{
    /// <summary>A block that contains EBS volume information. See below.</summary>
    [JsonPropertyName("ebsStorageInfo")]
    public IList<V1beta2ClusterSpecForProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfo>? EbsStorageInfo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderBrokerNodeGroupInfo
{
    /// <summary>The distribution of broker nodes across availability zones (documentation). Currently the only valid value is DEFAULT.</summary>
    [JsonPropertyName("azDistribution")]
    public string? AzDistribution { get; set; }

    /// <summary>A list of subnets to connect to in client VPC (documentation).</summary>
    [JsonPropertyName("clientSubnets")]
    public IList<string>? ClientSubnets { get; set; }

    /// <summary>References to Subnet in ec2 to populate clientSubnets.</summary>
    [JsonPropertyName("clientSubnetsRefs")]
    public IList<V1beta2ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefs>? ClientSubnetsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate clientSubnets.</summary>
    [JsonPropertyName("clientSubnetsSelector")]
    public V1beta2ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelector? ClientSubnetsSelector { get; set; }

    /// <summary>Information about the cluster access configuration. See below. For security reasons, you can't turn on public access while creating an MSK cluster. However, you can update an existing cluster to make it publicly accessible. You can also create a new cluster and then update it to make it publicly accessible (documentation).</summary>
    [JsonPropertyName("connectivityInfo")]
    public IList<V1beta2ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfo>? ConnectivityInfo { get; set; }

    /// <summary>Specify the instance type to use for the kafka brokersE.g., kafka.m5.large. (Pricing info)</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>A list of the security groups to associate with the elastic network interfaces to control who can communicate with the cluster.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupsRefs")]
    public IList<V1beta2ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefs>? SecurityGroupsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupsSelector")]
    public V1beta2ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelector? SecurityGroupsSelector { get; set; }

    /// <summary>A block that contains information about storage volumes attached to MSK broker nodes. See below.</summary>
    [JsonPropertyName("storageInfo")]
    public IList<V1beta2ClusterSpecForProviderBrokerNodeGroupInfoStorageInfo>? StorageInfo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClientAuthenticationSasl
{
    /// <summary>Enables SASL/IAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("iam")]
    public bool? Iam { get; set; }

    /// <summary>Enables SASL/SCRAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("scram")]
    public bool? Scram { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClientAuthenticationTls
{
    /// <summary>List of ACM Certificate Authority Amazon Resource Names (ARNs).</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClientAuthentication
{
    /// <summary>SASL authentication type details for VPC connectivity. See below.</summary>
    [JsonPropertyName("sasl")]
    public IList<V1beta2ClusterSpecForProviderClientAuthenticationSasl>? Sasl { get; set; }

    /// <summary>Enables TLS authentication for VPC connectivity.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta2ClusterSpecForProviderClientAuthenticationTls>? Tls { get; set; }

    /// <summary>Enables unauthenticated access.</summary>
    [JsonPropertyName("unauthenticated")]
    public bool? Unauthenticated { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecForProviderConfigurationInfoArnRefPolicyResolutionEnum
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
public enum V1beta2ClusterSpecForProviderConfigurationInfoArnRefPolicyResolveEnum
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
public partial class V1beta2ClusterSpecForProviderConfigurationInfoArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderConfigurationInfoArnRefPolicyResolutionEnum>))]
    public V1beta2ClusterSpecForProviderConfigurationInfoArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderConfigurationInfoArnRefPolicyResolveEnum>))]
    public V1beta2ClusterSpecForProviderConfigurationInfoArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Configuration in kafka to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderConfigurationInfoArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderConfigurationInfoArnRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecForProviderConfigurationInfoArnSelectorPolicyResolutionEnum
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
public enum V1beta2ClusterSpecForProviderConfigurationInfoArnSelectorPolicyResolveEnum
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
public partial class V1beta2ClusterSpecForProviderConfigurationInfoArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderConfigurationInfoArnSelectorPolicyResolutionEnum>))]
    public V1beta2ClusterSpecForProviderConfigurationInfoArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderConfigurationInfoArnSelectorPolicyResolveEnum>))]
    public V1beta2ClusterSpecForProviderConfigurationInfoArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Configuration in kafka to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderConfigurationInfoArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderConfigurationInfoArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderConfigurationInfo
{
    /// <summary>Amazon Resource Name (ARN) of the MSK Configuration to use in the cluster.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a Configuration in kafka to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta2ClusterSpecForProviderConfigurationInfoArnRef? ArnRef { get; set; }

    /// <summary>Selector for a Configuration in kafka to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta2ClusterSpecForProviderConfigurationInfoArnSelector? ArnSelector { get; set; }

    /// <summary>Revision of the MSK Configuration to use in the cluster.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolutionEnum
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
public enum V1beta2ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolveEnum
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
public partial class V1beta2ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolutionEnum>))]
    public V1beta2ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolveEnum>))]
    public V1beta2ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolutionEnum
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
public enum V1beta2ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolveEnum
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
public partial class V1beta2ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolutionEnum>))]
    public V1beta2ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolveEnum>))]
    public V1beta2ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderEncryptionInfoEncryptionInTransit
{
    /// <summary>Encryption setting for data in transit between clients and brokers. Valid values: TLS, TLS_PLAINTEXT, and PLAINTEXT. Default value is TLS.</summary>
    [JsonPropertyName("clientBroker")]
    public string? ClientBroker { get; set; }

    /// <summary>Whether data communication among broker nodes is encrypted. Default value: true.</summary>
    [JsonPropertyName("inCluster")]
    public bool? InCluster { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderEncryptionInfo
{
    /// <summary>The ARN of the KMS key used for encryption at rest of the broker data volumes.</summary>
    [JsonPropertyName("encryptionAtRestKmsKeyArn")]
    public string? EncryptionAtRestKmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
    [JsonPropertyName("encryptionAtRestKmsKeyArnRef")]
    public V1beta2ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRef? EncryptionAtRestKmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
    [JsonPropertyName("encryptionAtRestKmsKeyArnSelector")]
    public V1beta2ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelector? EncryptionAtRestKmsKeyArnSelector { get; set; }

    /// <summary>Configuration block to specify encryption in transit. See below.</summary>
    [JsonPropertyName("encryptionInTransit")]
    public IList<V1beta2ClusterSpecForProviderEncryptionInfoEncryptionInTransit>? EncryptionInTransit { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolutionEnum
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
public enum V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolveEnum
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
public partial class V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolutionEnum>))]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolveEnum>))]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolutionEnum
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
public enum V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolveEnum
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
public partial class V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolutionEnum>))]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolveEnum>))]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogs
{
    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Name of the Cloudwatch Log Group to deliver logs to.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupRef")]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRef? LogGroupRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupSelector")]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelector? LogGroupSelector { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolutionEnum
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
public enum V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolveEnum
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
public partial class V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolutionEnum>))]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolveEnum>))]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolutionEnum
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
public enum V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolveEnum
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
public partial class V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolutionEnum>))]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolveEnum>))]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehose
{
    /// <summary>Name of the Kinesis Data Firehose delivery stream to deliver logs to.</summary>
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamRef")]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRef? DeliveryStreamRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamSelector")]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelector? DeliveryStreamSelector { get; set; }

    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolutionEnum
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
public enum V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolveEnum
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
public partial class V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolutionEnum>))]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolveEnum>))]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolutionEnum
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
public enum V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolveEnum
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
public partial class V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolutionEnum>))]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolveEnum>))]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3
{
    /// <summary>Name of the S3 bucket to deliver logs to.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelector? BucketSelector { get; set; }

    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Prefix to append to the folder name.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderLoggingInfoBrokerLogs
{
    /// <summary></summary>
    [JsonPropertyName("cloudwatchLogs")]
    public IList<V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogs>? CloudwatchLogs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firehose")]
    public IList<V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsFirehose>? Firehose { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1beta2ClusterSpecForProviderLoggingInfoBrokerLogsS3>? S3 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderLoggingInfo
{
    /// <summary>Configuration block for Broker Logs settings for logging info. See below.</summary>
    [JsonPropertyName("brokerLogs")]
    public IList<V1beta2ClusterSpecForProviderLoggingInfoBrokerLogs>? BrokerLogs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderOpenMonitoringPrometheusJmxExporter
{
    /// <summary>Indicates whether you want to enable or disable the JMX Exporter.</summary>
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderOpenMonitoringPrometheusNodeExporter
{
    /// <summary>Indicates whether you want to enable or disable the JMX Exporter.</summary>
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderOpenMonitoringPrometheus
{
    /// <summary>Configuration block for JMX Exporter. See below.</summary>
    [JsonPropertyName("jmxExporter")]
    public IList<V1beta2ClusterSpecForProviderOpenMonitoringPrometheusJmxExporter>? JmxExporter { get; set; }

    /// <summary>Configuration block for Node Exporter. See below.</summary>
    [JsonPropertyName("nodeExporter")]
    public IList<V1beta2ClusterSpecForProviderOpenMonitoringPrometheusNodeExporter>? NodeExporter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderOpenMonitoring
{
    /// <summary>Configuration block for Prometheus settings for open monitoring. See below.</summary>
    [JsonPropertyName("prometheus")]
    public IList<V1beta2ClusterSpecForProviderOpenMonitoringPrometheus>? Prometheus { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProvider
{
    /// <summary>Configuration block for the broker nodes of the Kafka cluster.</summary>
    [JsonPropertyName("brokerNodeGroupInfo")]
    public IList<V1beta2ClusterSpecForProviderBrokerNodeGroupInfo>? BrokerNodeGroupInfo { get; set; }

    /// <summary>Configuration block for specifying a client authentication. See below.</summary>
    [JsonPropertyName("clientAuthentication")]
    public IList<V1beta2ClusterSpecForProviderClientAuthentication>? ClientAuthentication { get; set; }

    /// <summary>Name of the MSK cluster.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Configuration block for specifying a MSK Configuration to attach to Kafka brokers. See below.</summary>
    [JsonPropertyName("configurationInfo")]
    public IList<V1beta2ClusterSpecForProviderConfigurationInfo>? ConfigurationInfo { get; set; }

    /// <summary>Configuration block for specifying encryption. See below.</summary>
    [JsonPropertyName("encryptionInfo")]
    public IList<V1beta2ClusterSpecForProviderEncryptionInfo>? EncryptionInfo { get; set; }

    /// <summary>Specify the desired enhanced MSK CloudWatch monitoring level. See Monitoring Amazon MSK with Amazon CloudWatch</summary>
    [JsonPropertyName("enhancedMonitoring")]
    public string? EnhancedMonitoring { get; set; }

    /// <summary>Specify the desired Kafka software version.</summary>
    [JsonPropertyName("kafkaVersion")]
    public string? KafkaVersion { get; set; }

    /// <summary>Configuration block for streaming broker logs to Cloudwatch/S3/Kinesis Firehose. See below.</summary>
    [JsonPropertyName("loggingInfo")]
    public IList<V1beta2ClusterSpecForProviderLoggingInfo>? LoggingInfo { get; set; }

    /// <summary>The desired total number of broker nodes in the kafka cluster.  It must be a multiple of the number of specified client subnets.</summary>
    [JsonPropertyName("numberOfBrokerNodes")]
    public double? NumberOfBrokerNodes { get; set; }

    /// <summary>Configuration block for JMX and Node monitoring for the MSK cluster. See below.</summary>
    [JsonPropertyName("openMonitoring")]
    public IList<V1beta2ClusterSpecForProviderOpenMonitoring>? OpenMonitoring { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Controls storage mode for supported storage tiers. Valid values are: LOCAL or TIERED.</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolutionEnum
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
public enum V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolveEnum
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
public partial class V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolutionEnum>))]
    public V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolveEnum>))]
    public V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefsPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolutionEnum
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
public enum V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolveEnum
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
public partial class V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolutionEnum>))]
    public V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolveEnum>))]
    public V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate clientSubnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoPublicAccess
{
    /// <summary>Public access type. Valid values: DISABLED, SERVICE_PROVIDED_EIPS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthenticationSasl
{
    /// <summary>Enables SASL/IAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("iam")]
    public bool? Iam { get; set; }

    /// <summary>Enables SASL/SCRAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("scram")]
    public bool? Scram { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication
{
    /// <summary>SASL authentication type details for VPC connectivity. See below.</summary>
    [JsonPropertyName("sasl")]
    public IList<V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthenticationSasl>? Sasl { get; set; }

    /// <summary>Enables TLS authentication for VPC connectivity.</summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivity
{
    /// <summary>Configuration block for specifying a client authentication. See below.</summary>
    [JsonPropertyName("clientAuthentication")]
    public IList<V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication>? ClientAuthentication { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfo
{
    /// <summary>Access control settings for brokers. See below.</summary>
    [JsonPropertyName("publicAccess")]
    public IList<V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoPublicAccess>? PublicAccess { get; set; }

    /// <summary>VPC connectivity access control for brokers. See below.</summary>
    [JsonPropertyName("vpcConnectivity")]
    public IList<V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivity>? VpcConnectivity { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolutionEnum
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
public enum V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolveEnum
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
public partial class V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolutionEnum>))]
    public V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolveEnum>))]
    public V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolutionEnum
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
public enum V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolveEnum
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
public partial class V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolutionEnum>))]
    public V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolveEnum>))]
    public V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput
{
    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Throughput value of the EBS volumes for the data drive on each kafka broker node in MiB per second. The minimum value is 250. The maximum value varies between broker type. You can refer to the valid values for the maximum volume throughput at the following documentation on throughput bottlenecks</summary>
    [JsonPropertyName("volumeThroughput")]
    public double? VolumeThroughput { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfo
{
    /// <summary>A block that contains EBS volume provisioned throughput information. To provision storage throughput, you must choose broker type kafka.m5.4xlarge or larger. See below.</summary>
    [JsonPropertyName("provisionedThroughput")]
    public IList<V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput>? ProvisionedThroughput { get; set; }

    /// <summary>The size in GiB of the EBS volume for the data drive on each broker node. Minimum value of 1 and maximum value of 16384.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoStorageInfo
{
    /// <summary>A block that contains EBS volume information. See below.</summary>
    [JsonPropertyName("ebsStorageInfo")]
    public IList<V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfo>? EbsStorageInfo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderBrokerNodeGroupInfo
{
    /// <summary>The distribution of broker nodes across availability zones (documentation). Currently the only valid value is DEFAULT.</summary>
    [JsonPropertyName("azDistribution")]
    public string? AzDistribution { get; set; }

    /// <summary>A list of subnets to connect to in client VPC (documentation).</summary>
    [JsonPropertyName("clientSubnets")]
    public IList<string>? ClientSubnets { get; set; }

    /// <summary>References to Subnet in ec2 to populate clientSubnets.</summary>
    [JsonPropertyName("clientSubnetsRefs")]
    public IList<V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefs>? ClientSubnetsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate clientSubnets.</summary>
    [JsonPropertyName("clientSubnetsSelector")]
    public V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelector? ClientSubnetsSelector { get; set; }

    /// <summary>Information about the cluster access configuration. See below. For security reasons, you can't turn on public access while creating an MSK cluster. However, you can update an existing cluster to make it publicly accessible. You can also create a new cluster and then update it to make it publicly accessible (documentation).</summary>
    [JsonPropertyName("connectivityInfo")]
    public IList<V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfo>? ConnectivityInfo { get; set; }

    /// <summary>Specify the instance type to use for the kafka brokersE.g., kafka.m5.large. (Pricing info)</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>A list of the security groups to associate with the elastic network interfaces to control who can communicate with the cluster.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupsRefs")]
    public IList<V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefs>? SecurityGroupsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupsSelector")]
    public V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelector? SecurityGroupsSelector { get; set; }

    /// <summary>A block that contains information about storage volumes attached to MSK broker nodes. See below.</summary>
    [JsonPropertyName("storageInfo")]
    public IList<V1beta2ClusterSpecInitProviderBrokerNodeGroupInfoStorageInfo>? StorageInfo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClientAuthenticationSasl
{
    /// <summary>Enables SASL/IAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("iam")]
    public bool? Iam { get; set; }

    /// <summary>Enables SASL/SCRAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("scram")]
    public bool? Scram { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClientAuthenticationTls
{
    /// <summary>List of ACM Certificate Authority Amazon Resource Names (ARNs).</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClientAuthentication
{
    /// <summary>SASL authentication type details for VPC connectivity. See below.</summary>
    [JsonPropertyName("sasl")]
    public IList<V1beta2ClusterSpecInitProviderClientAuthenticationSasl>? Sasl { get; set; }

    /// <summary>Enables TLS authentication for VPC connectivity.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta2ClusterSpecInitProviderClientAuthenticationTls>? Tls { get; set; }

    /// <summary>Enables unauthenticated access.</summary>
    [JsonPropertyName("unauthenticated")]
    public bool? Unauthenticated { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecInitProviderConfigurationInfoArnRefPolicyResolutionEnum
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
public enum V1beta2ClusterSpecInitProviderConfigurationInfoArnRefPolicyResolveEnum
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
public partial class V1beta2ClusterSpecInitProviderConfigurationInfoArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderConfigurationInfoArnRefPolicyResolutionEnum>))]
    public V1beta2ClusterSpecInitProviderConfigurationInfoArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderConfigurationInfoArnRefPolicyResolveEnum>))]
    public V1beta2ClusterSpecInitProviderConfigurationInfoArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Configuration in kafka to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderConfigurationInfoArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderConfigurationInfoArnRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecInitProviderConfigurationInfoArnSelectorPolicyResolutionEnum
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
public enum V1beta2ClusterSpecInitProviderConfigurationInfoArnSelectorPolicyResolveEnum
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
public partial class V1beta2ClusterSpecInitProviderConfigurationInfoArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderConfigurationInfoArnSelectorPolicyResolutionEnum>))]
    public V1beta2ClusterSpecInitProviderConfigurationInfoArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderConfigurationInfoArnSelectorPolicyResolveEnum>))]
    public V1beta2ClusterSpecInitProviderConfigurationInfoArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Configuration in kafka to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderConfigurationInfoArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderConfigurationInfoArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderConfigurationInfo
{
    /// <summary>Amazon Resource Name (ARN) of the MSK Configuration to use in the cluster.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a Configuration in kafka to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta2ClusterSpecInitProviderConfigurationInfoArnRef? ArnRef { get; set; }

    /// <summary>Selector for a Configuration in kafka to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta2ClusterSpecInitProviderConfigurationInfoArnSelector? ArnSelector { get; set; }

    /// <summary>Revision of the MSK Configuration to use in the cluster.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolutionEnum
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
public enum V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolveEnum
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
public partial class V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolutionEnum>))]
    public V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolveEnum>))]
    public V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolutionEnum
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
public enum V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolveEnum
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
public partial class V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolutionEnum>))]
    public V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolveEnum>))]
    public V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionInTransit
{
    /// <summary>Encryption setting for data in transit between clients and brokers. Valid values: TLS, TLS_PLAINTEXT, and PLAINTEXT. Default value is TLS.</summary>
    [JsonPropertyName("clientBroker")]
    public string? ClientBroker { get; set; }

    /// <summary>Whether data communication among broker nodes is encrypted. Default value: true.</summary>
    [JsonPropertyName("inCluster")]
    public bool? InCluster { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderEncryptionInfo
{
    /// <summary>The ARN of the KMS key used for encryption at rest of the broker data volumes.</summary>
    [JsonPropertyName("encryptionAtRestKmsKeyArn")]
    public string? EncryptionAtRestKmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
    [JsonPropertyName("encryptionAtRestKmsKeyArnRef")]
    public V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRef? EncryptionAtRestKmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
    [JsonPropertyName("encryptionAtRestKmsKeyArnSelector")]
    public V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelector? EncryptionAtRestKmsKeyArnSelector { get; set; }

    /// <summary>Configuration block to specify encryption in transit. See below.</summary>
    [JsonPropertyName("encryptionInTransit")]
    public IList<V1beta2ClusterSpecInitProviderEncryptionInfoEncryptionInTransit>? EncryptionInTransit { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolutionEnum
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
public enum V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolveEnum
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
public partial class V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolutionEnum>))]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolveEnum>))]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolutionEnum
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
public enum V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolveEnum
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
public partial class V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolutionEnum>))]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolveEnum>))]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogs
{
    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Name of the Cloudwatch Log Group to deliver logs to.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupRef")]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRef? LogGroupRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupSelector")]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelector? LogGroupSelector { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolutionEnum
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
public enum V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolveEnum
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
public partial class V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolutionEnum>))]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolveEnum>))]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolutionEnum
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
public enum V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolveEnum
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
public partial class V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolutionEnum>))]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolveEnum>))]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehose
{
    /// <summary>Name of the Kinesis Data Firehose delivery stream to deliver logs to.</summary>
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamRef")]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRef? DeliveryStreamRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamSelector")]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelector? DeliveryStreamSelector { get; set; }

    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolutionEnum
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
public enum V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolveEnum
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
public partial class V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolutionEnum>))]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolveEnum>))]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolutionEnum
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
public enum V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolveEnum
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
public partial class V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolutionEnum>))]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolveEnum>))]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3
{
    /// <summary>Name of the S3 bucket to deliver logs to.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelector? BucketSelector { get; set; }

    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Prefix to append to the folder name.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogs
{
    /// <summary></summary>
    [JsonPropertyName("cloudwatchLogs")]
    public IList<V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogs>? CloudwatchLogs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firehose")]
    public IList<V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsFirehose>? Firehose { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogsS3>? S3 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderLoggingInfo
{
    /// <summary>Configuration block for Broker Logs settings for logging info. See below.</summary>
    [JsonPropertyName("brokerLogs")]
    public IList<V1beta2ClusterSpecInitProviderLoggingInfoBrokerLogs>? BrokerLogs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderOpenMonitoringPrometheusJmxExporter
{
    /// <summary>Indicates whether you want to enable or disable the JMX Exporter.</summary>
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderOpenMonitoringPrometheusNodeExporter
{
    /// <summary>Indicates whether you want to enable or disable the JMX Exporter.</summary>
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderOpenMonitoringPrometheus
{
    /// <summary>Configuration block for JMX Exporter. See below.</summary>
    [JsonPropertyName("jmxExporter")]
    public IList<V1beta2ClusterSpecInitProviderOpenMonitoringPrometheusJmxExporter>? JmxExporter { get; set; }

    /// <summary>Configuration block for Node Exporter. See below.</summary>
    [JsonPropertyName("nodeExporter")]
    public IList<V1beta2ClusterSpecInitProviderOpenMonitoringPrometheusNodeExporter>? NodeExporter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderOpenMonitoring
{
    /// <summary>Configuration block for Prometheus settings for open monitoring. See below.</summary>
    [JsonPropertyName("prometheus")]
    public IList<V1beta2ClusterSpecInitProviderOpenMonitoringPrometheus>? Prometheus { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProvider
{
    /// <summary>Configuration block for the broker nodes of the Kafka cluster.</summary>
    [JsonPropertyName("brokerNodeGroupInfo")]
    public IList<V1beta2ClusterSpecInitProviderBrokerNodeGroupInfo>? BrokerNodeGroupInfo { get; set; }

    /// <summary>Configuration block for specifying a client authentication. See below.</summary>
    [JsonPropertyName("clientAuthentication")]
    public IList<V1beta2ClusterSpecInitProviderClientAuthentication>? ClientAuthentication { get; set; }

    /// <summary>Name of the MSK cluster.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Configuration block for specifying a MSK Configuration to attach to Kafka brokers. See below.</summary>
    [JsonPropertyName("configurationInfo")]
    public IList<V1beta2ClusterSpecInitProviderConfigurationInfo>? ConfigurationInfo { get; set; }

    /// <summary>Configuration block for specifying encryption. See below.</summary>
    [JsonPropertyName("encryptionInfo")]
    public IList<V1beta2ClusterSpecInitProviderEncryptionInfo>? EncryptionInfo { get; set; }

    /// <summary>Specify the desired enhanced MSK CloudWatch monitoring level. See Monitoring Amazon MSK with Amazon CloudWatch</summary>
    [JsonPropertyName("enhancedMonitoring")]
    public string? EnhancedMonitoring { get; set; }

    /// <summary>Specify the desired Kafka software version.</summary>
    [JsonPropertyName("kafkaVersion")]
    public string? KafkaVersion { get; set; }

    /// <summary>Configuration block for streaming broker logs to Cloudwatch/S3/Kinesis Firehose. See below.</summary>
    [JsonPropertyName("loggingInfo")]
    public IList<V1beta2ClusterSpecInitProviderLoggingInfo>? LoggingInfo { get; set; }

    /// <summary>The desired total number of broker nodes in the kafka cluster.  It must be a multiple of the number of specified client subnets.</summary>
    [JsonPropertyName("numberOfBrokerNodes")]
    public double? NumberOfBrokerNodes { get; set; }

    /// <summary>Configuration block for JMX and Node monitoring for the MSK cluster. See below.</summary>
    [JsonPropertyName("openMonitoring")]
    public IList<V1beta2ClusterSpecInitProviderOpenMonitoring>? OpenMonitoring { get; set; }

    /// <summary>Controls storage mode for supported storage tiers. Valid values are: LOCAL or TIERED.</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A ManagementAction represents an action that the Crossplane controllers can take on an external resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecManagementPoliciesEnum
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
public enum V1beta2ClusterSpecProviderConfigRefPolicyResolutionEnum
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
public enum V1beta2ClusterSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta2ClusterSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta2ClusterSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta2ClusterSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ClusterSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
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
public enum V1beta2ClusterSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta2ClusterSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta2ClusterSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta2ClusterSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta2ClusterSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta2ClusterSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta2ClusterSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ClusterSpec defines the desired state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecDeletionPolicyEnum>))]
    public V1beta2ClusterSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta2ClusterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta2ClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta2ClusterSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta2ClusterSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoPublicAccess
{
    /// <summary>Public access type. Valid values: DISABLED, SERVICE_PROVIDED_EIPS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthenticationSasl
{
    /// <summary>Enables SASL/IAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("iam")]
    public bool? Iam { get; set; }

    /// <summary>Enables SASL/SCRAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("scram")]
    public bool? Scram { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication
{
    /// <summary>SASL authentication type details for VPC connectivity. See below.</summary>
    [JsonPropertyName("sasl")]
    public IList<V1beta2ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthenticationSasl>? Sasl { get; set; }

    /// <summary>Enables TLS authentication for VPC connectivity.</summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivity
{
    /// <summary>Configuration block for specifying a client authentication. See below.</summary>
    [JsonPropertyName("clientAuthentication")]
    public IList<V1beta2ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication>? ClientAuthentication { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfo
{
    /// <summary>Access control settings for brokers. See below.</summary>
    [JsonPropertyName("publicAccess")]
    public IList<V1beta2ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoPublicAccess>? PublicAccess { get; set; }

    /// <summary>VPC connectivity access control for brokers. See below.</summary>
    [JsonPropertyName("vpcConnectivity")]
    public IList<V1beta2ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivity>? VpcConnectivity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput
{
    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Throughput value of the EBS volumes for the data drive on each kafka broker node in MiB per second. The minimum value is 250. The maximum value varies between broker type. You can refer to the valid values for the maximum volume throughput at the following documentation on throughput bottlenecks</summary>
    [JsonPropertyName("volumeThroughput")]
    public double? VolumeThroughput { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfo
{
    /// <summary>A block that contains EBS volume provisioned throughput information. To provision storage throughput, you must choose broker type kafka.m5.4xlarge or larger. See below.</summary>
    [JsonPropertyName("provisionedThroughput")]
    public IList<V1beta2ClusterStatusAtProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput>? ProvisionedThroughput { get; set; }

    /// <summary>The size in GiB of the EBS volume for the data drive on each broker node. Minimum value of 1 and maximum value of 16384.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderBrokerNodeGroupInfoStorageInfo
{
    /// <summary>A block that contains EBS volume information. See below.</summary>
    [JsonPropertyName("ebsStorageInfo")]
    public IList<V1beta2ClusterStatusAtProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfo>? EbsStorageInfo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderBrokerNodeGroupInfo
{
    /// <summary>The distribution of broker nodes across availability zones (documentation). Currently the only valid value is DEFAULT.</summary>
    [JsonPropertyName("azDistribution")]
    public string? AzDistribution { get; set; }

    /// <summary>A list of subnets to connect to in client VPC (documentation).</summary>
    [JsonPropertyName("clientSubnets")]
    public IList<string>? ClientSubnets { get; set; }

    /// <summary>Information about the cluster access configuration. See below. For security reasons, you can't turn on public access while creating an MSK cluster. However, you can update an existing cluster to make it publicly accessible. You can also create a new cluster and then update it to make it publicly accessible (documentation).</summary>
    [JsonPropertyName("connectivityInfo")]
    public IList<V1beta2ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfo>? ConnectivityInfo { get; set; }

    /// <summary>Specify the instance type to use for the kafka brokersE.g., kafka.m5.large. (Pricing info)</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>A list of the security groups to associate with the elastic network interfaces to control who can communicate with the cluster.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>A block that contains information about storage volumes attached to MSK broker nodes. See below.</summary>
    [JsonPropertyName("storageInfo")]
    public IList<V1beta2ClusterStatusAtProviderBrokerNodeGroupInfoStorageInfo>? StorageInfo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClientAuthenticationSasl
{
    /// <summary>Enables SASL/IAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("iam")]
    public bool? Iam { get; set; }

    /// <summary>Enables SASL/SCRAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("scram")]
    public bool? Scram { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClientAuthenticationTls
{
    /// <summary>List of ACM Certificate Authority Amazon Resource Names (ARNs).</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClientAuthentication
{
    /// <summary>SASL authentication type details for VPC connectivity. See below.</summary>
    [JsonPropertyName("sasl")]
    public IList<V1beta2ClusterStatusAtProviderClientAuthenticationSasl>? Sasl { get; set; }

    /// <summary>Enables TLS authentication for VPC connectivity.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta2ClusterStatusAtProviderClientAuthenticationTls>? Tls { get; set; }

    /// <summary>Enables unauthenticated access.</summary>
    [JsonPropertyName("unauthenticated")]
    public bool? Unauthenticated { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderConfigurationInfo
{
    /// <summary>Amazon Resource Name (ARN) of the MSK Configuration to use in the cluster.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Revision of the MSK Configuration to use in the cluster.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderEncryptionInfoEncryptionInTransit
{
    /// <summary>Encryption setting for data in transit between clients and brokers. Valid values: TLS, TLS_PLAINTEXT, and PLAINTEXT. Default value is TLS.</summary>
    [JsonPropertyName("clientBroker")]
    public string? ClientBroker { get; set; }

    /// <summary>Whether data communication among broker nodes is encrypted. Default value: true.</summary>
    [JsonPropertyName("inCluster")]
    public bool? InCluster { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderEncryptionInfo
{
    /// <summary>The ARN of the KMS key used for encryption at rest of the broker data volumes.</summary>
    [JsonPropertyName("encryptionAtRestKmsKeyArn")]
    public string? EncryptionAtRestKmsKeyArn { get; set; }

    /// <summary>Configuration block to specify encryption in transit. See below.</summary>
    [JsonPropertyName("encryptionInTransit")]
    public IList<V1beta2ClusterStatusAtProviderEncryptionInfoEncryptionInTransit>? EncryptionInTransit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderLoggingInfoBrokerLogsCloudwatchLogs
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
public partial class V1beta2ClusterStatusAtProviderLoggingInfoBrokerLogsFirehose
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
public partial class V1beta2ClusterStatusAtProviderLoggingInfoBrokerLogsS3
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderLoggingInfoBrokerLogs
{
    /// <summary></summary>
    [JsonPropertyName("cloudwatchLogs")]
    public IList<V1beta2ClusterStatusAtProviderLoggingInfoBrokerLogsCloudwatchLogs>? CloudwatchLogs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firehose")]
    public IList<V1beta2ClusterStatusAtProviderLoggingInfoBrokerLogsFirehose>? Firehose { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1beta2ClusterStatusAtProviderLoggingInfoBrokerLogsS3>? S3 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderLoggingInfo
{
    /// <summary>Configuration block for Broker Logs settings for logging info. See below.</summary>
    [JsonPropertyName("brokerLogs")]
    public IList<V1beta2ClusterStatusAtProviderLoggingInfoBrokerLogs>? BrokerLogs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderOpenMonitoringPrometheusJmxExporter
{
    /// <summary>Indicates whether you want to enable or disable the JMX Exporter.</summary>
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderOpenMonitoringPrometheusNodeExporter
{
    /// <summary>Indicates whether you want to enable or disable the JMX Exporter.</summary>
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderOpenMonitoringPrometheus
{
    /// <summary>Configuration block for JMX Exporter. See below.</summary>
    [JsonPropertyName("jmxExporter")]
    public IList<V1beta2ClusterStatusAtProviderOpenMonitoringPrometheusJmxExporter>? JmxExporter { get; set; }

    /// <summary>Configuration block for Node Exporter. See below.</summary>
    [JsonPropertyName("nodeExporter")]
    public IList<V1beta2ClusterStatusAtProviderOpenMonitoringPrometheusNodeExporter>? NodeExporter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderOpenMonitoring
{
    /// <summary>Configuration block for Prometheus settings for open monitoring. See below.</summary>
    [JsonPropertyName("prometheus")]
    public IList<V1beta2ClusterStatusAtProviderOpenMonitoringPrometheus>? Prometheus { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProvider
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
    public IList<V1beta2ClusterStatusAtProviderBrokerNodeGroupInfo>? BrokerNodeGroupInfo { get; set; }

    /// <summary>Configuration block for specifying a client authentication. See below.</summary>
    [JsonPropertyName("clientAuthentication")]
    public IList<V1beta2ClusterStatusAtProviderClientAuthentication>? ClientAuthentication { get; set; }

    /// <summary>Name of the MSK cluster.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>UUID of the MSK cluster, for use in IAM policies.</summary>
    [JsonPropertyName("clusterUuid")]
    public string? ClusterUuid { get; set; }

    /// <summary>Configuration block for specifying a MSK Configuration to attach to Kafka brokers. See below.</summary>
    [JsonPropertyName("configurationInfo")]
    public IList<V1beta2ClusterStatusAtProviderConfigurationInfo>? ConfigurationInfo { get; set; }

    /// <summary>Current version of the MSK Cluster used for updates, e.g., K13V1IB3VIYZZH</summary>
    [JsonPropertyName("currentVersion")]
    public string? CurrentVersion { get; set; }

    /// <summary>Configuration block for specifying encryption. See below.</summary>
    [JsonPropertyName("encryptionInfo")]
    public IList<V1beta2ClusterStatusAtProviderEncryptionInfo>? EncryptionInfo { get; set; }

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
    public IList<V1beta2ClusterStatusAtProviderLoggingInfo>? LoggingInfo { get; set; }

    /// <summary>The desired total number of broker nodes in the kafka cluster.  It must be a multiple of the number of specified client subnets.</summary>
    [JsonPropertyName("numberOfBrokerNodes")]
    public double? NumberOfBrokerNodes { get; set; }

    /// <summary>Configuration block for JMX and Node monitoring for the MSK cluster. See below.</summary>
    [JsonPropertyName("openMonitoring")]
    public IList<V1beta2ClusterStatusAtProviderOpenMonitoring>? OpenMonitoring { get; set; }

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
public partial class V1beta2ClusterStatusConditions
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
public partial class V1beta2ClusterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta2ClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Cluster is the Schema for the Clusters API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ClusterSpec>, IStatus<V1beta2ClusterStatus>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "kafka.aws.upbound.io";
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
    public V1beta2ClusterSpec Spec { get; set; }

    /// <summary>ClusterStatus defines the observed state of Cluster.</summary>
    [JsonPropertyName("status")]
    public V1beta2ClusterStatus? Status { get; set; }
}