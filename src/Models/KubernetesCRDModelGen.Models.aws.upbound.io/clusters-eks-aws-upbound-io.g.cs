using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eks.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAccessConfig
{
    /// <summary>The authentication mode for the cluster. Valid values are CONFIG_MAP, API or API_AND_CONFIG_MAP</summary>
    [JsonPropertyName("authenticationMode")]
    public string? AuthenticationMode { get; set; }

    /// <summary>Whether or not to bootstrap the access config values to the cluster. Default is false.</summary>
    [JsonPropertyName("bootstrapClusterCreatorAdminPermissions")]
    public bool? BootstrapClusterCreatorAdminPermissions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderComputeConfig
{
    /// <summary>Request to enable or disable the compute capability on your EKS Auto Mode cluster. If the compute capability is enabled, EKS Auto Mode will create and delete EC2 Managed Instances in your Amazon Web Services account.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Configuration for node pools that defines the compute resources for your EKS Auto Mode cluster. Valid options are general-purpose and system.</summary>
    [JsonPropertyName("nodePools")]
    public IList<string>? NodePools { get; set; }

    /// <summary>The ARN of the IAM Role EKS will assign to EC2 Managed Instances in your EKS Auto Mode cluster. This value cannot be changed after the compute capability of EKS Auto Mode is enabled..</summary>
    [JsonPropertyName("nodeRoleArn")]
    public string? NodeRoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderEncryptionConfigProvider
{
    /// <summary>ARN of the Key Management Service (KMS) customer master key (CMK). The CMK must be symmetric, created in the same region as the cluster, and if the CMK was created in a different account, the user must have access to the CMK. For more information, see Allowing Users in Other Accounts to Use a CMK in the AWS Key Management Service Developer Guide.</summary>
    [JsonPropertyName("keyArn")]
    public string? KeyArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderEncryptionConfig
{
    /// <summary>Configuration block with provider for encryption. Detailed below.</summary>
    [JsonPropertyName("provider")]
    public IList<V1beta1ClusterSpecForProviderEncryptionConfigProvider>? Provider { get; set; }

    /// <summary>List of strings with resources to be encrypted. Valid values: secrets.</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderKubernetesNetworkConfigElasticLoadBalancing
{
    /// <summary>Whether zonal shift is enabled for the cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderKubernetesNetworkConfig
{
    /// <summary>Configuration block with elastic load balancing configuration for the cluster. Detailed below.</summary>
    [JsonPropertyName("elasticLoadBalancing")]
    public IList<V1beta1ClusterSpecForProviderKubernetesNetworkConfigElasticLoadBalancing>? ElasticLoadBalancing { get; set; }

    /// <summary>The IP family used to assign Kubernetes pod and service addresses. Valid values are ipv4 (default) and ipv6. You can only specify an IP family when you create a cluster, changing this value will force a new cluster to be created.</summary>
    [JsonPropertyName("ipFamily")]
    public string? IpFamily { get; set; }

    /// <summary>The CIDR block to assign Kubernetes pod and service IP addresses from. If you don't specify a block, Kubernetes assigns addresses from either the 10.100.0.0/16 or 172.20.0.0/16 CIDR blocks. We recommend that you specify a block that does not overlap with resources in other networks that are peered or connected to your VPC. You can only specify a custom CIDR block when you create a cluster, changing this value will force a new cluster to be created. The block must meet the following requirements:</summary>
    [JsonPropertyName("serviceIpv4Cidr")]
    public string? ServiceIpv4Cidr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderOutpostConfigControlPlanePlacement
{
    /// <summary>The name of the placement group for the Kubernetes control plane instances. This setting can't be changed after cluster creation.</summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderOutpostConfig
{
    /// <summary>The Amazon EC2 instance type that you want to use for your local Amazon EKS cluster on Outposts. The instance type that you specify is used for all Kubernetes control plane instances. The instance type can't be changed after cluster creation. Choose an instance type based on the number of nodes that your cluster will have. If your cluster will have:</summary>
    [JsonPropertyName("controlPlaneInstanceType")]
    public string? ControlPlaneInstanceType { get; set; }

    /// <summary>An object representing the placement configuration for all the control plane instances of your local Amazon EKS cluster on AWS Outpost. The control_plane_placement configuration block supports the following arguments:</summary>
    [JsonPropertyName("controlPlanePlacement")]
    public IList<V1beta1ClusterSpecForProviderOutpostConfigControlPlanePlacement>? ControlPlanePlacement { get; set; }

    /// <summary>The ARN of the Outpost that you want to use for your local Amazon EKS cluster on Outposts. This argument is a list of arns, but only a single Outpost ARN is supported currently.</summary>
    [JsonPropertyName("outpostArns")]
    public IList<string>? OutpostArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderRemoteNetworkConfigRemoteNodeNetworks
{
    /// <summary>List of network CIDRs that can contain hybrid nodes.</summary>
    [JsonPropertyName("cidrs")]
    public IList<string>? Cidrs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderRemoteNetworkConfigRemotePodNetworks
{
    /// <summary>List of network CIDRs that can contain pods that run Kubernetes webhooks on hybrid nodes.</summary>
    [JsonPropertyName("cidrs")]
    public IList<string>? Cidrs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderRemoteNetworkConfig
{
    /// <summary>Configuration block with remote node network configuration for EKS Hybrid Nodes. Detailed below.</summary>
    [JsonPropertyName("remoteNodeNetworks")]
    public IList<V1beta1ClusterSpecForProviderRemoteNetworkConfigRemoteNodeNetworks>? RemoteNodeNetworks { get; set; }

    /// <summary>Configuration block with remote pod network configuration for EKS Hybrid Nodes. Detailed below.</summary>
    [JsonPropertyName("remotePodNetworks")]
    public IList<V1beta1ClusterSpecForProviderRemoteNetworkConfigRemotePodNetworks>? RemotePodNetworks { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderStorageConfigBlockStorage
{
    /// <summary>Indicates if the block storage capability is enabled on your EKS Auto Mode cluster. If the block storage capability is enabled, EKS Auto Mode will create and delete block storage volumes in your Amazon Web Services account.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderStorageConfig
{
    /// <summary>Configuration block with block storage configuration for the cluster. Detailed below.</summary>
    [JsonPropertyName("blockStorage")]
    public IList<V1beta1ClusterSpecForProviderStorageConfigBlockStorage>? BlockStorage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderUpgradePolicy
{
    /// <summary>Support type to use for the cluster. If the cluster is set to EXTENDED, it will enter extended support at the end of standard support. If the cluster is set to STANDARD, it will be automatically upgraded at the end of standard support. Valid values are EXTENDED, STANDARD</summary>
    [JsonPropertyName("supportType")]
    public string? SupportType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVpcConfigSecurityGroupIdRefsPolicy
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
public partial class V1beta1ClusterSpecForProviderVpcConfigSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderVpcConfigSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVpcConfigSecurityGroupIdSelectorPolicy
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
public partial class V1beta1ClusterSpecForProviderVpcConfigSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderVpcConfigSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVpcConfigSubnetIdRefsPolicy
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
public partial class V1beta1ClusterSpecForProviderVpcConfigSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderVpcConfigSubnetIdRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVpcConfigSubnetIdSelectorPolicy
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
public partial class V1beta1ClusterSpecForProviderVpcConfigSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderVpcConfigSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVpcConfig
{
    /// <summary>Whether the Amazon EKS private API server endpoint is enabled. Default is false.</summary>
    [JsonPropertyName("endpointPrivateAccess")]
    public bool? EndpointPrivateAccess { get; set; }

    /// <summary>Whether the Amazon EKS public API server endpoint is enabled. Default is true.</summary>
    [JsonPropertyName("endpointPublicAccess")]
    public bool? EndpointPublicAccess { get; set; }

    /// <summary>This is an injected field with a default value for being able to merge items of the parent object list.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>List of CIDR blocks. Indicates which CIDR blocks can access the Amazon EKS public API server endpoint when enabled. EKS defaults this to a list with 0.0.0.0/0.</summary>
    [JsonPropertyName("publicAccessCidrs")]
    public IList<string>? PublicAccessCidrs { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdRefs")]
    public IList<V1beta1ClusterSpecForProviderVpcConfigSecurityGroupIdRefs>? SecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta1ClusterSpecForProviderVpcConfigSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>List of security group IDs for the cross-account elastic network interfaces that Amazon EKS creates to use to allow communication between your worker nodes and the Kubernetes control plane.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta1ClusterSpecForProviderVpcConfigSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1ClusterSpecForProviderVpcConfigSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>List of subnet IDs. Must be in at least two different availability zones. Amazon EKS creates cross-account elastic network interfaces in these subnets to allow communication between your worker nodes and the Kubernetes control plane.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderZonalShiftConfig
{
    /// <summary>Whether zonal shift is enabled for the cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProvider
{
    /// <summary>Configuration block for the access config associated with your cluster, see Amazon EKS Access Entries. Detailed below.</summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta1ClusterSpecForProviderAccessConfig>? AccessConfig { get; set; }

    /// <summary>Install default unmanaged add-ons, such as aws-cni, kube-proxy, and CoreDNS during cluster creation. If false, you must manually install desired add-ons. Changing this value will force a new cluster to be created. Defaults to true.</summary>
    [JsonPropertyName("bootstrapSelfManagedAddons")]
    public bool? BootstrapSelfManagedAddons { get; set; }

    /// <summary>Configuration block with compute configuration for EKS Auto Mode. Detailed below.</summary>
    [JsonPropertyName("computeConfig")]
    public IList<V1beta1ClusterSpecForProviderComputeConfig>? ComputeConfig { get; set; }

    /// <summary>List of the desired control plane logging to enable. For more information, see Amazon EKS Control Plane Logging.</summary>
    [JsonPropertyName("enabledClusterLogTypes")]
    public IList<string>? EnabledClusterLogTypes { get; set; }

    /// <summary>Configuration block with encryption configuration for the cluster. Detailed below.</summary>
    [JsonPropertyName("encryptionConfig")]
    public IList<V1beta1ClusterSpecForProviderEncryptionConfig>? EncryptionConfig { get; set; }

    /// <summary>Force version update by overriding upgrade-blocking readiness checks when updating a cluster.</summary>
    [JsonPropertyName("forceUpdateVersion")]
    public bool? ForceUpdateVersion { get; set; }

    /// <summary>Configuration block with kubernetes network configuration for the cluster. Detailed below.</summary>
    [JsonPropertyName("kubernetesNetworkConfig")]
    public IList<V1beta1ClusterSpecForProviderKubernetesNetworkConfig>? KubernetesNetworkConfig { get; set; }

    /// <summary>Configuration block representing the configuration of your local Amazon EKS cluster on an AWS Outpost. This block isn't available for creating Amazon EKS clusters on the AWS cloud.</summary>
    [JsonPropertyName("outpostConfig")]
    public IList<V1beta1ClusterSpecForProviderOutpostConfig>? OutpostConfig { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Configuration block with remote network configuration for EKS Hybrid Nodes. Detailed below.</summary>
    [JsonPropertyName("remoteNetworkConfig")]
    public IList<V1beta1ClusterSpecForProviderRemoteNetworkConfig>? RemoteNetworkConfig { get; set; }

    /// <summary>ARN of the IAM role that provides permissions for the Kubernetes control plane to make calls to AWS API operations on your behalf. Ensure the resource configuration includes explicit dependencies on the IAM Role permissions by adding depends_on if using the aws_iam_role_policy resource or aws_iam_role_policy_attachment resource, otherwise EKS cannot delete EKS managed EC2 infrastructure such as Security Groups on EKS Cluster deletion.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1ClusterSpecForProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1ClusterSpecForProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Configuration block with storage configuration for EKS Auto Mode. Detailed below.</summary>
    [JsonPropertyName("storageConfig")]
    public IList<V1beta1ClusterSpecForProviderStorageConfig>? StorageConfig { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for the support policy to use for the cluster.  See upgrade_policy for details.</summary>
    [JsonPropertyName("upgradePolicy")]
    public IList<V1beta1ClusterSpecForProviderUpgradePolicy>? UpgradePolicy { get; set; }

    /// <summary>Desired Kubernetes master version. If you do not specify a value, the latest available version at resource creation is used and no upgrades will occur except those automatically triggered by EKS. The value must be configured and increased to upgrade the version when desired. Downgrades are not supported by EKS.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Configuration block for the VPC associated with your cluster. Amazon EKS VPC resources have specific requirements to work properly with Kubernetes. For more information, see Cluster VPC Considerations and Cluster Security Group Considerations in the Amazon EKS User Guide. Detailed below. Also contains attributes detailed in the Attributes section.</summary>
    [JsonPropertyName("vpcConfig")]
    public IList<V1beta1ClusterSpecForProviderVpcConfig>? VpcConfig { get; set; }

    /// <summary>Configuration block with zonal shift configuration for the cluster. Detailed below.</summary>
    [JsonPropertyName("zonalShiftConfig")]
    public IList<V1beta1ClusterSpecForProviderZonalShiftConfig>? ZonalShiftConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAccessConfig
{
    /// <summary>The authentication mode for the cluster. Valid values are CONFIG_MAP, API or API_AND_CONFIG_MAP</summary>
    [JsonPropertyName("authenticationMode")]
    public string? AuthenticationMode { get; set; }

    /// <summary>Whether or not to bootstrap the access config values to the cluster. Default is false.</summary>
    [JsonPropertyName("bootstrapClusterCreatorAdminPermissions")]
    public bool? BootstrapClusterCreatorAdminPermissions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderComputeConfig
{
    /// <summary>Request to enable or disable the compute capability on your EKS Auto Mode cluster. If the compute capability is enabled, EKS Auto Mode will create and delete EC2 Managed Instances in your Amazon Web Services account.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Configuration for node pools that defines the compute resources for your EKS Auto Mode cluster. Valid options are general-purpose and system.</summary>
    [JsonPropertyName("nodePools")]
    public IList<string>? NodePools { get; set; }

    /// <summary>The ARN of the IAM Role EKS will assign to EC2 Managed Instances in your EKS Auto Mode cluster. This value cannot be changed after the compute capability of EKS Auto Mode is enabled..</summary>
    [JsonPropertyName("nodeRoleArn")]
    public string? NodeRoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderEncryptionConfigProvider
{
    /// <summary>ARN of the Key Management Service (KMS) customer master key (CMK). The CMK must be symmetric, created in the same region as the cluster, and if the CMK was created in a different account, the user must have access to the CMK. For more information, see Allowing Users in Other Accounts to Use a CMK in the AWS Key Management Service Developer Guide.</summary>
    [JsonPropertyName("keyArn")]
    public string? KeyArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderEncryptionConfig
{
    /// <summary>Configuration block with provider for encryption. Detailed below.</summary>
    [JsonPropertyName("provider")]
    public IList<V1beta1ClusterSpecInitProviderEncryptionConfigProvider>? Provider { get; set; }

    /// <summary>List of strings with resources to be encrypted. Valid values: secrets.</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderKubernetesNetworkConfigElasticLoadBalancing
{
    /// <summary>Whether zonal shift is enabled for the cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderKubernetesNetworkConfig
{
    /// <summary>Configuration block with elastic load balancing configuration for the cluster. Detailed below.</summary>
    [JsonPropertyName("elasticLoadBalancing")]
    public IList<V1beta1ClusterSpecInitProviderKubernetesNetworkConfigElasticLoadBalancing>? ElasticLoadBalancing { get; set; }

    /// <summary>The IP family used to assign Kubernetes pod and service addresses. Valid values are ipv4 (default) and ipv6. You can only specify an IP family when you create a cluster, changing this value will force a new cluster to be created.</summary>
    [JsonPropertyName("ipFamily")]
    public string? IpFamily { get; set; }

    /// <summary>The CIDR block to assign Kubernetes pod and service IP addresses from. If you don't specify a block, Kubernetes assigns addresses from either the 10.100.0.0/16 or 172.20.0.0/16 CIDR blocks. We recommend that you specify a block that does not overlap with resources in other networks that are peered or connected to your VPC. You can only specify a custom CIDR block when you create a cluster, changing this value will force a new cluster to be created. The block must meet the following requirements:</summary>
    [JsonPropertyName("serviceIpv4Cidr")]
    public string? ServiceIpv4Cidr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderOutpostConfigControlPlanePlacement
{
    /// <summary>The name of the placement group for the Kubernetes control plane instances. This setting can't be changed after cluster creation.</summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderOutpostConfig
{
    /// <summary>The Amazon EC2 instance type that you want to use for your local Amazon EKS cluster on Outposts. The instance type that you specify is used for all Kubernetes control plane instances. The instance type can't be changed after cluster creation. Choose an instance type based on the number of nodes that your cluster will have. If your cluster will have:</summary>
    [JsonPropertyName("controlPlaneInstanceType")]
    public string? ControlPlaneInstanceType { get; set; }

    /// <summary>An object representing the placement configuration for all the control plane instances of your local Amazon EKS cluster on AWS Outpost. The control_plane_placement configuration block supports the following arguments:</summary>
    [JsonPropertyName("controlPlanePlacement")]
    public IList<V1beta1ClusterSpecInitProviderOutpostConfigControlPlanePlacement>? ControlPlanePlacement { get; set; }

    /// <summary>The ARN of the Outpost that you want to use for your local Amazon EKS cluster on Outposts. This argument is a list of arns, but only a single Outpost ARN is supported currently.</summary>
    [JsonPropertyName("outpostArns")]
    public IList<string>? OutpostArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderRemoteNetworkConfigRemoteNodeNetworks
{
    /// <summary>List of network CIDRs that can contain hybrid nodes.</summary>
    [JsonPropertyName("cidrs")]
    public IList<string>? Cidrs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderRemoteNetworkConfigRemotePodNetworks
{
    /// <summary>List of network CIDRs that can contain pods that run Kubernetes webhooks on hybrid nodes.</summary>
    [JsonPropertyName("cidrs")]
    public IList<string>? Cidrs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderRemoteNetworkConfig
{
    /// <summary>Configuration block with remote node network configuration for EKS Hybrid Nodes. Detailed below.</summary>
    [JsonPropertyName("remoteNodeNetworks")]
    public IList<V1beta1ClusterSpecInitProviderRemoteNetworkConfigRemoteNodeNetworks>? RemoteNodeNetworks { get; set; }

    /// <summary>Configuration block with remote pod network configuration for EKS Hybrid Nodes. Detailed below.</summary>
    [JsonPropertyName("remotePodNetworks")]
    public IList<V1beta1ClusterSpecInitProviderRemoteNetworkConfigRemotePodNetworks>? RemotePodNetworks { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderStorageConfigBlockStorage
{
    /// <summary>Indicates if the block storage capability is enabled on your EKS Auto Mode cluster. If the block storage capability is enabled, EKS Auto Mode will create and delete block storage volumes in your Amazon Web Services account.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderStorageConfig
{
    /// <summary>Configuration block with block storage configuration for the cluster. Detailed below.</summary>
    [JsonPropertyName("blockStorage")]
    public IList<V1beta1ClusterSpecInitProviderStorageConfigBlockStorage>? BlockStorage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderUpgradePolicy
{
    /// <summary>Support type to use for the cluster. If the cluster is set to EXTENDED, it will enter extended support at the end of standard support. If the cluster is set to STANDARD, it will be automatically upgraded at the end of standard support. Valid values are EXTENDED, STANDARD</summary>
    [JsonPropertyName("supportType")]
    public string? SupportType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVpcConfigSecurityGroupIdRefsPolicy
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
public partial class V1beta1ClusterSpecInitProviderVpcConfigSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderVpcConfigSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVpcConfigSecurityGroupIdSelectorPolicy
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
public partial class V1beta1ClusterSpecInitProviderVpcConfigSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderVpcConfigSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVpcConfigSubnetIdRefsPolicy
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
public partial class V1beta1ClusterSpecInitProviderVpcConfigSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderVpcConfigSubnetIdRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVpcConfigSubnetIdSelectorPolicy
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
public partial class V1beta1ClusterSpecInitProviderVpcConfigSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderVpcConfigSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVpcConfig
{
    /// <summary>Whether the Amazon EKS private API server endpoint is enabled. Default is false.</summary>
    [JsonPropertyName("endpointPrivateAccess")]
    public bool? EndpointPrivateAccess { get; set; }

    /// <summary>Whether the Amazon EKS public API server endpoint is enabled. Default is true.</summary>
    [JsonPropertyName("endpointPublicAccess")]
    public bool? EndpointPublicAccess { get; set; }

    /// <summary>This is an injected field with a default value for being able to merge items of the parent object list.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>List of CIDR blocks. Indicates which CIDR blocks can access the Amazon EKS public API server endpoint when enabled. EKS defaults this to a list with 0.0.0.0/0.</summary>
    [JsonPropertyName("publicAccessCidrs")]
    public IList<string>? PublicAccessCidrs { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdRefs")]
    public IList<V1beta1ClusterSpecInitProviderVpcConfigSecurityGroupIdRefs>? SecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta1ClusterSpecInitProviderVpcConfigSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>List of security group IDs for the cross-account elastic network interfaces that Amazon EKS creates to use to allow communication between your worker nodes and the Kubernetes control plane.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta1ClusterSpecInitProviderVpcConfigSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1ClusterSpecInitProviderVpcConfigSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>List of subnet IDs. Must be in at least two different availability zones. Amazon EKS creates cross-account elastic network interfaces in these subnets to allow communication between your worker nodes and the Kubernetes control plane.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderZonalShiftConfig
{
    /// <summary>Whether zonal shift is enabled for the cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProvider
{
    /// <summary>Configuration block for the access config associated with your cluster, see Amazon EKS Access Entries. Detailed below.</summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta1ClusterSpecInitProviderAccessConfig>? AccessConfig { get; set; }

    /// <summary>Install default unmanaged add-ons, such as aws-cni, kube-proxy, and CoreDNS during cluster creation. If false, you must manually install desired add-ons. Changing this value will force a new cluster to be created. Defaults to true.</summary>
    [JsonPropertyName("bootstrapSelfManagedAddons")]
    public bool? BootstrapSelfManagedAddons { get; set; }

    /// <summary>Configuration block with compute configuration for EKS Auto Mode. Detailed below.</summary>
    [JsonPropertyName("computeConfig")]
    public IList<V1beta1ClusterSpecInitProviderComputeConfig>? ComputeConfig { get; set; }

    /// <summary>List of the desired control plane logging to enable. For more information, see Amazon EKS Control Plane Logging.</summary>
    [JsonPropertyName("enabledClusterLogTypes")]
    public IList<string>? EnabledClusterLogTypes { get; set; }

    /// <summary>Configuration block with encryption configuration for the cluster. Detailed below.</summary>
    [JsonPropertyName("encryptionConfig")]
    public IList<V1beta1ClusterSpecInitProviderEncryptionConfig>? EncryptionConfig { get; set; }

    /// <summary>Force version update by overriding upgrade-blocking readiness checks when updating a cluster.</summary>
    [JsonPropertyName("forceUpdateVersion")]
    public bool? ForceUpdateVersion { get; set; }

    /// <summary>Configuration block with kubernetes network configuration for the cluster. Detailed below.</summary>
    [JsonPropertyName("kubernetesNetworkConfig")]
    public IList<V1beta1ClusterSpecInitProviderKubernetesNetworkConfig>? KubernetesNetworkConfig { get; set; }

    /// <summary>Configuration block representing the configuration of your local Amazon EKS cluster on an AWS Outpost. This block isn't available for creating Amazon EKS clusters on the AWS cloud.</summary>
    [JsonPropertyName("outpostConfig")]
    public IList<V1beta1ClusterSpecInitProviderOutpostConfig>? OutpostConfig { get; set; }

    /// <summary>Configuration block with remote network configuration for EKS Hybrid Nodes. Detailed below.</summary>
    [JsonPropertyName("remoteNetworkConfig")]
    public IList<V1beta1ClusterSpecInitProviderRemoteNetworkConfig>? RemoteNetworkConfig { get; set; }

    /// <summary>ARN of the IAM role that provides permissions for the Kubernetes control plane to make calls to AWS API operations on your behalf. Ensure the resource configuration includes explicit dependencies on the IAM Role permissions by adding depends_on if using the aws_iam_role_policy resource or aws_iam_role_policy_attachment resource, otherwise EKS cannot delete EKS managed EC2 infrastructure such as Security Groups on EKS Cluster deletion.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1ClusterSpecInitProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1ClusterSpecInitProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Configuration block with storage configuration for EKS Auto Mode. Detailed below.</summary>
    [JsonPropertyName("storageConfig")]
    public IList<V1beta1ClusterSpecInitProviderStorageConfig>? StorageConfig { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for the support policy to use for the cluster.  See upgrade_policy for details.</summary>
    [JsonPropertyName("upgradePolicy")]
    public IList<V1beta1ClusterSpecInitProviderUpgradePolicy>? UpgradePolicy { get; set; }

    /// <summary>Desired Kubernetes master version. If you do not specify a value, the latest available version at resource creation is used and no upgrades will occur except those automatically triggered by EKS. The value must be configured and increased to upgrade the version when desired. Downgrades are not supported by EKS.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Configuration block for the VPC associated with your cluster. Amazon EKS VPC resources have specific requirements to work properly with Kubernetes. For more information, see Cluster VPC Considerations and Cluster Security Group Considerations in the Amazon EKS User Guide. Detailed below. Also contains attributes detailed in the Attributes section.</summary>
    [JsonPropertyName("vpcConfig")]
    public IList<V1beta1ClusterSpecInitProviderVpcConfig>? VpcConfig { get; set; }

    /// <summary>Configuration block with zonal shift configuration for the cluster. Detailed below.</summary>
    [JsonPropertyName("zonalShiftConfig")]
    public IList<V1beta1ClusterSpecInitProviderZonalShiftConfig>? ZonalShiftConfig { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecProviderConfigRefPolicy
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
public partial class V1beta1ClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1ClusterSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ClusterSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ClusterSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ClusterSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecWriteConnectionSecretToRef
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
public partial class V1beta1ClusterSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ClusterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ClusterSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAccessConfig
{
    /// <summary>The authentication mode for the cluster. Valid values are CONFIG_MAP, API or API_AND_CONFIG_MAP</summary>
    [JsonPropertyName("authenticationMode")]
    public string? AuthenticationMode { get; set; }

    /// <summary>Whether or not to bootstrap the access config values to the cluster. Default is false.</summary>
    [JsonPropertyName("bootstrapClusterCreatorAdminPermissions")]
    public bool? BootstrapClusterCreatorAdminPermissions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderCertificateAuthority
{
    /// <summary>Base64 encoded certificate data required to communicate with your cluster. Add this to the certificate-authority-data section of the kubeconfig file for your cluster.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderComputeConfig
{
    /// <summary>Request to enable or disable the compute capability on your EKS Auto Mode cluster. If the compute capability is enabled, EKS Auto Mode will create and delete EC2 Managed Instances in your Amazon Web Services account.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Configuration for node pools that defines the compute resources for your EKS Auto Mode cluster. Valid options are general-purpose and system.</summary>
    [JsonPropertyName("nodePools")]
    public IList<string>? NodePools { get; set; }

    /// <summary>The ARN of the IAM Role EKS will assign to EC2 Managed Instances in your EKS Auto Mode cluster. This value cannot be changed after the compute capability of EKS Auto Mode is enabled..</summary>
    [JsonPropertyName("nodeRoleArn")]
    public string? NodeRoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderEncryptionConfigProvider
{
    /// <summary>ARN of the Key Management Service (KMS) customer master key (CMK). The CMK must be symmetric, created in the same region as the cluster, and if the CMK was created in a different account, the user must have access to the CMK. For more information, see Allowing Users in Other Accounts to Use a CMK in the AWS Key Management Service Developer Guide.</summary>
    [JsonPropertyName("keyArn")]
    public string? KeyArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderEncryptionConfig
{
    /// <summary>Configuration block with provider for encryption. Detailed below.</summary>
    [JsonPropertyName("provider")]
    public IList<V1beta1ClusterStatusAtProviderEncryptionConfigProvider>? Provider { get; set; }

    /// <summary>List of strings with resources to be encrypted. Valid values: secrets.</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderIdentityOidc
{
    /// <summary>Issuer URL for the OpenID Connect identity provider.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderIdentity
{
    /// <summary>Nested block containing OpenID Connect identity provider information for the cluster. Detailed below.</summary>
    [JsonPropertyName("oidc")]
    public IList<V1beta1ClusterStatusAtProviderIdentityOidc>? Oidc { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderKubernetesNetworkConfigElasticLoadBalancing
{
    /// <summary>Whether zonal shift is enabled for the cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderKubernetesNetworkConfig
{
    /// <summary>Configuration block with elastic load balancing configuration for the cluster. Detailed below.</summary>
    [JsonPropertyName("elasticLoadBalancing")]
    public IList<V1beta1ClusterStatusAtProviderKubernetesNetworkConfigElasticLoadBalancing>? ElasticLoadBalancing { get; set; }

    /// <summary>The IP family used to assign Kubernetes pod and service addresses. Valid values are ipv4 (default) and ipv6. You can only specify an IP family when you create a cluster, changing this value will force a new cluster to be created.</summary>
    [JsonPropertyName("ipFamily")]
    public string? IpFamily { get; set; }

    /// <summary>The CIDR block to assign Kubernetes pod and service IP addresses from. If you don't specify a block, Kubernetes assigns addresses from either the 10.100.0.0/16 or 172.20.0.0/16 CIDR blocks. We recommend that you specify a block that does not overlap with resources in other networks that are peered or connected to your VPC. You can only specify a custom CIDR block when you create a cluster, changing this value will force a new cluster to be created. The block must meet the following requirements:</summary>
    [JsonPropertyName("serviceIpv4Cidr")]
    public string? ServiceIpv4Cidr { get; set; }

    /// <summary>(Computed) The CIDR block that Kubernetes pod and service IP addresses are assigned from if you specify ipv6 for ip_family when you create the cluster. Kubernetes assigns service addresses from the unique local address range (fc00::/7) because you can't specify a custom IPv6 CIDR block when you create the cluster.</summary>
    [JsonPropertyName("serviceIpv6Cidr")]
    public string? ServiceIpv6Cidr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderOutpostConfigControlPlanePlacement
{
    /// <summary>The name of the placement group for the Kubernetes control plane instances. This setting can't be changed after cluster creation.</summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderOutpostConfig
{
    /// <summary>The Amazon EC2 instance type that you want to use for your local Amazon EKS cluster on Outposts. The instance type that you specify is used for all Kubernetes control plane instances. The instance type can't be changed after cluster creation. Choose an instance type based on the number of nodes that your cluster will have. If your cluster will have:</summary>
    [JsonPropertyName("controlPlaneInstanceType")]
    public string? ControlPlaneInstanceType { get; set; }

    /// <summary>An object representing the placement configuration for all the control plane instances of your local Amazon EKS cluster on AWS Outpost. The control_plane_placement configuration block supports the following arguments:</summary>
    [JsonPropertyName("controlPlanePlacement")]
    public IList<V1beta1ClusterStatusAtProviderOutpostConfigControlPlanePlacement>? ControlPlanePlacement { get; set; }

    /// <summary>The ARN of the Outpost that you want to use for your local Amazon EKS cluster on Outposts. This argument is a list of arns, but only a single Outpost ARN is supported currently.</summary>
    [JsonPropertyName("outpostArns")]
    public IList<string>? OutpostArns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderRemoteNetworkConfigRemoteNodeNetworks
{
    /// <summary>List of network CIDRs that can contain hybrid nodes.</summary>
    [JsonPropertyName("cidrs")]
    public IList<string>? Cidrs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderRemoteNetworkConfigRemotePodNetworks
{
    /// <summary>List of network CIDRs that can contain pods that run Kubernetes webhooks on hybrid nodes.</summary>
    [JsonPropertyName("cidrs")]
    public IList<string>? Cidrs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderRemoteNetworkConfig
{
    /// <summary>Configuration block with remote node network configuration for EKS Hybrid Nodes. Detailed below.</summary>
    [JsonPropertyName("remoteNodeNetworks")]
    public IList<V1beta1ClusterStatusAtProviderRemoteNetworkConfigRemoteNodeNetworks>? RemoteNodeNetworks { get; set; }

    /// <summary>Configuration block with remote pod network configuration for EKS Hybrid Nodes. Detailed below.</summary>
    [JsonPropertyName("remotePodNetworks")]
    public IList<V1beta1ClusterStatusAtProviderRemoteNetworkConfigRemotePodNetworks>? RemotePodNetworks { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderStorageConfigBlockStorage
{
    /// <summary>Indicates if the block storage capability is enabled on your EKS Auto Mode cluster. If the block storage capability is enabled, EKS Auto Mode will create and delete block storage volumes in your Amazon Web Services account.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderStorageConfig
{
    /// <summary>Configuration block with block storage configuration for the cluster. Detailed below.</summary>
    [JsonPropertyName("blockStorage")]
    public IList<V1beta1ClusterStatusAtProviderStorageConfigBlockStorage>? BlockStorage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderUpgradePolicy
{
    /// <summary>Support type to use for the cluster. If the cluster is set to EXTENDED, it will enter extended support at the end of standard support. If the cluster is set to STANDARD, it will be automatically upgraded at the end of standard support. Valid values are EXTENDED, STANDARD</summary>
    [JsonPropertyName("supportType")]
    public string? SupportType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderVpcConfig
{
    /// <summary>(Computed) Cluster security group that is created by Amazon EKS for the cluster. Managed node groups use this security group for control-plane-to-data-plane communication.</summary>
    [JsonPropertyName("clusterSecurityGroupId")]
    public string? ClusterSecurityGroupId { get; set; }

    /// <summary>Whether the Amazon EKS private API server endpoint is enabled. Default is false.</summary>
    [JsonPropertyName("endpointPrivateAccess")]
    public bool? EndpointPrivateAccess { get; set; }

    /// <summary>Whether the Amazon EKS public API server endpoint is enabled. Default is true.</summary>
    [JsonPropertyName("endpointPublicAccess")]
    public bool? EndpointPublicAccess { get; set; }

    /// <summary>This is an injected field with a default value for being able to merge items of the parent object list.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>List of CIDR blocks. Indicates which CIDR blocks can access the Amazon EKS public API server endpoint when enabled. EKS defaults this to a list with 0.0.0.0/0.</summary>
    [JsonPropertyName("publicAccessCidrs")]
    public IList<string>? PublicAccessCidrs { get; set; }

    /// <summary>List of security group IDs for the cross-account elastic network interfaces that Amazon EKS creates to use to allow communication between your worker nodes and the Kubernetes control plane.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>List of subnet IDs. Must be in at least two different availability zones. Amazon EKS creates cross-account elastic network interfaces in these subnets to allow communication between your worker nodes and the Kubernetes control plane.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>(Computed) ID of the VPC associated with your cluster.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderZonalShiftConfig
{
    /// <summary>Whether zonal shift is enabled for the cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProvider
{
    /// <summary>Configuration block for the access config associated with your cluster, see Amazon EKS Access Entries. Detailed below.</summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta1ClusterStatusAtProviderAccessConfig>? AccessConfig { get; set; }

    /// <summary>ARN of the cluster.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Install default unmanaged add-ons, such as aws-cni, kube-proxy, and CoreDNS during cluster creation. If false, you must manually install desired add-ons. Changing this value will force a new cluster to be created. Defaults to true.</summary>
    [JsonPropertyName("bootstrapSelfManagedAddons")]
    public bool? BootstrapSelfManagedAddons { get; set; }

    /// <summary>Attribute block containing certificate-authority-data for your cluster. Detailed below.</summary>
    [JsonPropertyName("certificateAuthority")]
    public IList<V1beta1ClusterStatusAtProviderCertificateAuthority>? CertificateAuthority { get; set; }

    /// <summary>The ID of your local Amazon EKS cluster on the AWS Outpost. This attribute isn't available for an AWS EKS cluster on AWS cloud.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>Configuration block with compute configuration for EKS Auto Mode. Detailed below.</summary>
    [JsonPropertyName("computeConfig")]
    public IList<V1beta1ClusterStatusAtProviderComputeConfig>? ComputeConfig { get; set; }

    /// <summary>Unix epoch timestamp in seconds for when the cluster was created.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>List of the desired control plane logging to enable. For more information, see Amazon EKS Control Plane Logging.</summary>
    [JsonPropertyName("enabledClusterLogTypes")]
    public IList<string>? EnabledClusterLogTypes { get; set; }

    /// <summary>Configuration block with encryption configuration for the cluster. Detailed below.</summary>
    [JsonPropertyName("encryptionConfig")]
    public IList<V1beta1ClusterStatusAtProviderEncryptionConfig>? EncryptionConfig { get; set; }

    /// <summary>Endpoint for your Kubernetes API server.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>Force version update by overriding upgrade-blocking readiness checks when updating a cluster.</summary>
    [JsonPropertyName("forceUpdateVersion")]
    public bool? ForceUpdateVersion { get; set; }

    /// <summary>Name of the cluster.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Attribute block containing identity provider information for your cluster. Only available on Kubernetes version 1.13 and 1.14 clusters created or upgraded on or after September 3, 2019. Detailed below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ClusterStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>Configuration block with kubernetes network configuration for the cluster. Detailed below.</summary>
    [JsonPropertyName("kubernetesNetworkConfig")]
    public IList<V1beta1ClusterStatusAtProviderKubernetesNetworkConfig>? KubernetesNetworkConfig { get; set; }

    /// <summary>Configuration block representing the configuration of your local Amazon EKS cluster on an AWS Outpost. This block isn't available for creating Amazon EKS clusters on the AWS cloud.</summary>
    [JsonPropertyName("outpostConfig")]
    public IList<V1beta1ClusterStatusAtProviderOutpostConfig>? OutpostConfig { get; set; }

    /// <summary>Platform version for the cluster.</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Configuration block with remote network configuration for EKS Hybrid Nodes. Detailed below.</summary>
    [JsonPropertyName("remoteNetworkConfig")]
    public IList<V1beta1ClusterStatusAtProviderRemoteNetworkConfig>? RemoteNetworkConfig { get; set; }

    /// <summary>ARN of the IAM role that provides permissions for the Kubernetes control plane to make calls to AWS API operations on your behalf. Ensure the resource configuration includes explicit dependencies on the IAM Role permissions by adding depends_on if using the aws_iam_role_policy resource or aws_iam_role_policy_attachment resource, otherwise EKS cannot delete EKS managed EC2 infrastructure such as Security Groups on EKS Cluster deletion.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Status of the EKS cluster. One of CREATING, ACTIVE, DELETING, FAILED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Configuration block with storage configuration for EKS Auto Mode. Detailed below.</summary>
    [JsonPropertyName("storageConfig")]
    public IList<V1beta1ClusterStatusAtProviderStorageConfig>? StorageConfig { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Configuration block for the support policy to use for the cluster.  See upgrade_policy for details.</summary>
    [JsonPropertyName("upgradePolicy")]
    public IList<V1beta1ClusterStatusAtProviderUpgradePolicy>? UpgradePolicy { get; set; }

    /// <summary>Desired Kubernetes master version. If you do not specify a value, the latest available version at resource creation is used and no upgrades will occur except those automatically triggered by EKS. The value must be configured and increased to upgrade the version when desired. Downgrades are not supported by EKS.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Configuration block for the VPC associated with your cluster. Amazon EKS VPC resources have specific requirements to work properly with Kubernetes. For more information, see Cluster VPC Considerations and Cluster Security Group Considerations in the Amazon EKS User Guide. Detailed below. Also contains attributes detailed in the Attributes section.</summary>
    [JsonPropertyName("vpcConfig")]
    public IList<V1beta1ClusterStatusAtProviderVpcConfig>? VpcConfig { get; set; }

    /// <summary>Configuration block with zonal shift configuration for the cluster. Detailed below.</summary>
    [JsonPropertyName("zonalShiftConfig")]
    public IList<V1beta1ClusterStatusAtProviderZonalShiftConfig>? ZonalShiftConfig { get; set; }
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

/// <summary>Cluster is the Schema for the Clusters API. Manages an EKS Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClusterSpec>, IStatus<V1beta1ClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "eks.aws.upbound.io";
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

/// <summary>Cluster is the Schema for the Clusters API. Manages an EKS Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Cluster>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "eks.aws.upbound.io";
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