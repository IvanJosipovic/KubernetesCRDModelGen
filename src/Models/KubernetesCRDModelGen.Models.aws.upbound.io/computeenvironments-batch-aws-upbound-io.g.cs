using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.batch.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderComputeResourcesEc2Configuration
{
    /// <summary>The AMI ID used for instances launched in the compute environment that match the image type. This setting overrides the image_id argument in the compute_resources block.</summary>
    [JsonPropertyName("imageIdOverride")]
    public string? ImageIdOverride { get; set; }

    /// <summary>The image type to match with the instance type to select an AMI. If the image_id_override parameter isn't specified, then a recent Amazon ECS-optimized Amazon Linux 2 AMI (ECS_AL2) is used.</summary>
    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderComputeResourcesInstanceRoleRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a InstanceProfile in iam to populate instanceRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderComputeResourcesInstanceRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecForProviderComputeResourcesInstanceRoleRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderComputeResourcesInstanceRoleSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a InstanceProfile in iam to populate instanceRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderComputeResourcesInstanceRoleSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecForProviderComputeResourcesInstanceRoleSelectorPolicy? Policy { get; set; }
}

/// <summary>The launch template to use for your compute resources. See details below. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderComputeResourcesLaunchTemplate
{
    /// <summary>ID of the launch template. You must specify either the launch template ID or launch template name in the request, but not both.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }

    /// <summary>Name of the launch template.</summary>
    [JsonPropertyName("launchTemplateName")]
    public string? LaunchTemplateName { get; set; }

    /// <summary>The version number of the launch template. Default: The default version of the launch template.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderComputeResourcesPlacementGroupRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a PlacementGroup in ec2 to populate placementGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderComputeResourcesPlacementGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecForProviderComputeResourcesPlacementGroupRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderComputeResourcesPlacementGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a PlacementGroup in ec2 to populate placementGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderComputeResourcesPlacementGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecForProviderComputeResourcesPlacementGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderComputeResourcesSecurityGroupIdsRefsPolicy
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
public partial class V1beta1ComputeEnvironmentSpecForProviderComputeResourcesSecurityGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecForProviderComputeResourcesSecurityGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderComputeResourcesSecurityGroupIdsSelectorPolicy
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
public partial class V1beta1ComputeEnvironmentSpecForProviderComputeResourcesSecurityGroupIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecForProviderComputeResourcesSecurityGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderComputeResourcesSubnetsRefsPolicy
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
public partial class V1beta1ComputeEnvironmentSpecForProviderComputeResourcesSubnetsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecForProviderComputeResourcesSubnetsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderComputeResourcesSubnetsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderComputeResourcesSubnetsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecForProviderComputeResourcesSubnetsSelectorPolicy? Policy { get; set; }
}

/// <summary>Details of the compute resources managed by the compute environment. This parameter is required for managed compute environments. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderComputeResources
{
    /// <summary>The allocation strategy to use for the compute resource in case not enough instances of the best fitting instance type can be allocated. For valid values, refer to the AWS documentation. Defaults to BEST_FIT. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary>Integer of maximum percentage that a Spot Instance price can be when compared with the On-Demand price for that instance type before instances are launched. For example, if your bid percentage is 20% (20), then the Spot price must be below 20% of the current On-Demand price for that EC2 instance. If you leave this field empty, the default value is 100% of the On-Demand price. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("bidPercentage")]
    public double? BidPercentage { get; set; }

    /// <summary>The desired number of EC2 vCPUS in the compute environment. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("desiredVcpus")]
    public double? DesiredVcpus { get; set; }

    /// <summary>Provides information used to select Amazon Machine Images (AMIs) for EC2 instances in the compute environment. If Ec2Configuration isn't specified, the default is ECS_AL2. This parameter isn't applicable to jobs that are running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("ec2Configuration")]
    public IList<V1beta1ComputeEnvironmentSpecForProviderComputeResourcesEc2Configuration>? Ec2Configuration { get; set; }

    /// <summary>The EC2 key pair that is used for instances launched in the compute environment. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("ec2KeyPair")]
    public string? Ec2KeyPair { get; set; }

    /// <summary>The Amazon Machine Image (AMI) ID used for instances launched in the compute environment. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified. (Deprecated, use ec2_configuration image_id_override instead)</summary>
    [JsonPropertyName("imageId")]
    public string? ImageId { get; set; }

    /// <summary>The Amazon ECS instance role applied to Amazon EC2 instances in a compute environment. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("instanceRole")]
    public string? InstanceRole { get; set; }

    /// <summary>Reference to a InstanceProfile in iam to populate instanceRole.</summary>
    [JsonPropertyName("instanceRoleRef")]
    public V1beta1ComputeEnvironmentSpecForProviderComputeResourcesInstanceRoleRef? InstanceRoleRef { get; set; }

    /// <summary>Selector for a InstanceProfile in iam to populate instanceRole.</summary>
    [JsonPropertyName("instanceRoleSelector")]
    public V1beta1ComputeEnvironmentSpecForProviderComputeResourcesInstanceRoleSelector? InstanceRoleSelector { get; set; }

    /// <summary>A list of instance types that may be launched. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("instanceType")]
    public IList<string>? InstanceType { get; set; }

    /// <summary>The launch template to use for your compute resources. See details below. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("launchTemplate")]
    public V1beta1ComputeEnvironmentSpecForProviderComputeResourcesLaunchTemplate? LaunchTemplate { get; set; }

    /// <summary>The maximum number of EC2 vCPUs that an environment can reach.</summary>
    [JsonPropertyName("maxVcpus")]
    public double? MaxVcpus { get; set; }

    /// <summary>The minimum number of EC2 vCPUs that an environment should maintain. For EC2 or SPOT compute environments, if the parameter is not explicitly defined, a 0 default value will be set. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("minVcpus")]
    public double? MinVcpus { get; set; }

    /// <summary>The Amazon EC2 placement group to associate with your compute resources.</summary>
    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary>Reference to a PlacementGroup in ec2 to populate placementGroup.</summary>
    [JsonPropertyName("placementGroupRef")]
    public V1beta1ComputeEnvironmentSpecForProviderComputeResourcesPlacementGroupRef? PlacementGroupRef { get; set; }

    /// <summary>Selector for a PlacementGroup in ec2 to populate placementGroup.</summary>
    [JsonPropertyName("placementGroupSelector")]
    public V1beta1ComputeEnvironmentSpecForProviderComputeResourcesPlacementGroupSelector? PlacementGroupSelector { get; set; }

    /// <summary>A list of EC2 security group that are associated with instances launched in the compute environment. This parameter is required for Fargate compute environments.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsRefs")]
    public IList<V1beta1ComputeEnvironmentSpecForProviderComputeResourcesSecurityGroupIdsRefs>? SecurityGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsSelector")]
    public V1beta1ComputeEnvironmentSpecForProviderComputeResourcesSecurityGroupIdsSelector? SecurityGroupIdsSelector { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Amazon EC2 Spot Fleet IAM role applied to a SPOT compute environment. This parameter is required for SPOT compute environments. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("spotIamFleetRole")]
    public string? SpotIamFleetRole { get; set; }

    /// <summary>A list of VPC subnets into which the compute resources are launched.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetsRefs")]
    public IList<V1beta1ComputeEnvironmentSpecForProviderComputeResourcesSubnetsRefs>? SubnetsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetsSelector")]
    public V1beta1ComputeEnvironmentSpecForProviderComputeResourcesSubnetsSelector? SubnetsSelector { get; set; }

    /// <summary>Key-value pair tags to be applied to resources that are launched in the compute environment. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of compute environment. Valid items are EC2, SPOT, FARGATE or FARGATE_SPOT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Details for the Amazon EKS cluster that supports the compute environment. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderEksConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) of the Amazon EKS cluster.</summary>
    [JsonPropertyName("eksClusterArn")]
    public string? EksClusterArn { get; set; }

    /// <summary>The namespace of the Amazon EKS cluster. AWS Batch manages pods in this namespace.</summary>
    [JsonPropertyName("kubernetesNamespace")]
    public string? KubernetesNamespace { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderServiceRoleRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderServiceRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecForProviderServiceRoleRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderServiceRoleSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderServiceRoleSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecForProviderServiceRoleSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies the infrastructure update policy for the compute environment. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProviderUpdatePolicy
{
    /// <summary>Specifies the job timeout (in minutes) when the compute environment infrastructure is updated.</summary>
    [JsonPropertyName("jobExecutionTimeoutMinutes")]
    public double? JobExecutionTimeoutMinutes { get; set; }

    /// <summary>Specifies whether jobs are automatically terminated when the computer environment infrastructure is updated.</summary>
    [JsonPropertyName("terminateJobsOnUpdate")]
    public bool? TerminateJobsOnUpdate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecForProvider
{
    /// <summary>Details of the compute resources managed by the compute environment. This parameter is required for managed compute environments. See details below.</summary>
    [JsonPropertyName("computeResources")]
    public V1beta1ComputeEnvironmentSpecForProviderComputeResources? ComputeResources { get; set; }

    /// <summary>Details for the Amazon EKS cluster that supports the compute environment. See details below.</summary>
    [JsonPropertyName("eksConfiguration")]
    public V1beta1ComputeEnvironmentSpecForProviderEksConfiguration? EksConfiguration { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The full Amazon Resource Name (ARN) of the IAM role that allows AWS Batch to make calls to other AWS services on your behalf.</summary>
    [JsonPropertyName("serviceRole")]
    public string? ServiceRole { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceRole.</summary>
    [JsonPropertyName("serviceRoleRef")]
    public V1beta1ComputeEnvironmentSpecForProviderServiceRoleRef? ServiceRoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceRole.</summary>
    [JsonPropertyName("serviceRoleSelector")]
    public V1beta1ComputeEnvironmentSpecForProviderServiceRoleSelector? ServiceRoleSelector { get; set; }

    /// <summary>The state of the compute environment. If the state is ENABLED, then the compute environment accepts jobs from a queue and can scale out automatically based on queues. Valid items are ENABLED or DISABLED. Defaults to ENABLED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of the compute environment. Valid items are MANAGED or UNMANAGED.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Specifies the infrastructure update policy for the compute environment. See details below.</summary>
    [JsonPropertyName("updatePolicy")]
    public V1beta1ComputeEnvironmentSpecForProviderUpdatePolicy? UpdatePolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesEc2Configuration
{
    /// <summary>The AMI ID used for instances launched in the compute environment that match the image type. This setting overrides the image_id argument in the compute_resources block.</summary>
    [JsonPropertyName("imageIdOverride")]
    public string? ImageIdOverride { get; set; }

    /// <summary>The image type to match with the instance type to select an AMI. If the image_id_override parameter isn't specified, then a recent Amazon ECS-optimized Amazon Linux 2 AMI (ECS_AL2) is used.</summary>
    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesInstanceRoleRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a InstanceProfile in iam to populate instanceRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesInstanceRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesInstanceRoleRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesInstanceRoleSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a InstanceProfile in iam to populate instanceRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesInstanceRoleSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesInstanceRoleSelectorPolicy? Policy { get; set; }
}

/// <summary>The launch template to use for your compute resources. See details below. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesLaunchTemplate
{
    /// <summary>ID of the launch template. You must specify either the launch template ID or launch template name in the request, but not both.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }

    /// <summary>Name of the launch template.</summary>
    [JsonPropertyName("launchTemplateName")]
    public string? LaunchTemplateName { get; set; }

    /// <summary>The version number of the launch template. Default: The default version of the launch template.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesPlacementGroupRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a PlacementGroup in ec2 to populate placementGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesPlacementGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesPlacementGroupRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesPlacementGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a PlacementGroup in ec2 to populate placementGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesPlacementGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesPlacementGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesSecurityGroupIdsRefsPolicy
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
public partial class V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesSecurityGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesSecurityGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesSecurityGroupIdsSelectorPolicy
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
public partial class V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesSecurityGroupIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesSecurityGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesSubnetsRefsPolicy
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
public partial class V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesSubnetsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesSubnetsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesSubnetsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesSubnetsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesSubnetsSelectorPolicy? Policy { get; set; }
}

/// <summary>Details of the compute resources managed by the compute environment. This parameter is required for managed compute environments. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderComputeResources
{
    /// <summary>The allocation strategy to use for the compute resource in case not enough instances of the best fitting instance type can be allocated. For valid values, refer to the AWS documentation. Defaults to BEST_FIT. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary>Integer of maximum percentage that a Spot Instance price can be when compared with the On-Demand price for that instance type before instances are launched. For example, if your bid percentage is 20% (20), then the Spot price must be below 20% of the current On-Demand price for that EC2 instance. If you leave this field empty, the default value is 100% of the On-Demand price. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("bidPercentage")]
    public double? BidPercentage { get; set; }

    /// <summary>The desired number of EC2 vCPUS in the compute environment. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("desiredVcpus")]
    public double? DesiredVcpus { get; set; }

    /// <summary>Provides information used to select Amazon Machine Images (AMIs) for EC2 instances in the compute environment. If Ec2Configuration isn't specified, the default is ECS_AL2. This parameter isn't applicable to jobs that are running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("ec2Configuration")]
    public IList<V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesEc2Configuration>? Ec2Configuration { get; set; }

    /// <summary>The EC2 key pair that is used for instances launched in the compute environment. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("ec2KeyPair")]
    public string? Ec2KeyPair { get; set; }

    /// <summary>The Amazon Machine Image (AMI) ID used for instances launched in the compute environment. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified. (Deprecated, use ec2_configuration image_id_override instead)</summary>
    [JsonPropertyName("imageId")]
    public string? ImageId { get; set; }

    /// <summary>The Amazon ECS instance role applied to Amazon EC2 instances in a compute environment. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("instanceRole")]
    public string? InstanceRole { get; set; }

    /// <summary>Reference to a InstanceProfile in iam to populate instanceRole.</summary>
    [JsonPropertyName("instanceRoleRef")]
    public V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesInstanceRoleRef? InstanceRoleRef { get; set; }

    /// <summary>Selector for a InstanceProfile in iam to populate instanceRole.</summary>
    [JsonPropertyName("instanceRoleSelector")]
    public V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesInstanceRoleSelector? InstanceRoleSelector { get; set; }

    /// <summary>A list of instance types that may be launched. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("instanceType")]
    public IList<string>? InstanceType { get; set; }

    /// <summary>The launch template to use for your compute resources. See details below. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("launchTemplate")]
    public V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesLaunchTemplate? LaunchTemplate { get; set; }

    /// <summary>The maximum number of EC2 vCPUs that an environment can reach.</summary>
    [JsonPropertyName("maxVcpus")]
    public double? MaxVcpus { get; set; }

    /// <summary>The minimum number of EC2 vCPUs that an environment should maintain. For EC2 or SPOT compute environments, if the parameter is not explicitly defined, a 0 default value will be set. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("minVcpus")]
    public double? MinVcpus { get; set; }

    /// <summary>The Amazon EC2 placement group to associate with your compute resources.</summary>
    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary>Reference to a PlacementGroup in ec2 to populate placementGroup.</summary>
    [JsonPropertyName("placementGroupRef")]
    public V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesPlacementGroupRef? PlacementGroupRef { get; set; }

    /// <summary>Selector for a PlacementGroup in ec2 to populate placementGroup.</summary>
    [JsonPropertyName("placementGroupSelector")]
    public V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesPlacementGroupSelector? PlacementGroupSelector { get; set; }

    /// <summary>A list of EC2 security group that are associated with instances launched in the compute environment. This parameter is required for Fargate compute environments.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsRefs")]
    public IList<V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesSecurityGroupIdsRefs>? SecurityGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsSelector")]
    public V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesSecurityGroupIdsSelector? SecurityGroupIdsSelector { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Amazon EC2 Spot Fleet IAM role applied to a SPOT compute environment. This parameter is required for SPOT compute environments. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("spotIamFleetRole")]
    public string? SpotIamFleetRole { get; set; }

    /// <summary>A list of VPC subnets into which the compute resources are launched.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetsRefs")]
    public IList<V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesSubnetsRefs>? SubnetsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetsSelector")]
    public V1beta1ComputeEnvironmentSpecInitProviderComputeResourcesSubnetsSelector? SubnetsSelector { get; set; }

    /// <summary>Key-value pair tags to be applied to resources that are launched in the compute environment. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of compute environment. Valid items are EC2, SPOT, FARGATE or FARGATE_SPOT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Details for the Amazon EKS cluster that supports the compute environment. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderEksConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) of the Amazon EKS cluster.</summary>
    [JsonPropertyName("eksClusterArn")]
    public string? EksClusterArn { get; set; }

    /// <summary>The namespace of the Amazon EKS cluster. AWS Batch manages pods in this namespace.</summary>
    [JsonPropertyName("kubernetesNamespace")]
    public string? KubernetesNamespace { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderServiceRoleRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderServiceRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecInitProviderServiceRoleRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderServiceRoleSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderServiceRoleSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecInitProviderServiceRoleSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies the infrastructure update policy for the compute environment. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProviderUpdatePolicy
{
    /// <summary>Specifies the job timeout (in minutes) when the compute environment infrastructure is updated.</summary>
    [JsonPropertyName("jobExecutionTimeoutMinutes")]
    public double? JobExecutionTimeoutMinutes { get; set; }

    /// <summary>Specifies whether jobs are automatically terminated when the computer environment infrastructure is updated.</summary>
    [JsonPropertyName("terminateJobsOnUpdate")]
    public bool? TerminateJobsOnUpdate { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecInitProvider
{
    /// <summary>Details of the compute resources managed by the compute environment. This parameter is required for managed compute environments. See details below.</summary>
    [JsonPropertyName("computeResources")]
    public V1beta1ComputeEnvironmentSpecInitProviderComputeResources? ComputeResources { get; set; }

    /// <summary>Details for the Amazon EKS cluster that supports the compute environment. See details below.</summary>
    [JsonPropertyName("eksConfiguration")]
    public V1beta1ComputeEnvironmentSpecInitProviderEksConfiguration? EksConfiguration { get; set; }

    /// <summary>The full Amazon Resource Name (ARN) of the IAM role that allows AWS Batch to make calls to other AWS services on your behalf.</summary>
    [JsonPropertyName("serviceRole")]
    public string? ServiceRole { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceRole.</summary>
    [JsonPropertyName("serviceRoleRef")]
    public V1beta1ComputeEnvironmentSpecInitProviderServiceRoleRef? ServiceRoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceRole.</summary>
    [JsonPropertyName("serviceRoleSelector")]
    public V1beta1ComputeEnvironmentSpecInitProviderServiceRoleSelector? ServiceRoleSelector { get; set; }

    /// <summary>The state of the compute environment. If the state is ENABLED, then the compute environment accepts jobs from a queue and can scale out automatically based on queues. Valid items are ENABLED or DISABLED. Defaults to ENABLED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of the compute environment. Valid items are MANAGED or UNMANAGED.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Specifies the infrastructure update policy for the compute environment. See details below.</summary>
    [JsonPropertyName("updatePolicy")]
    public V1beta1ComputeEnvironmentSpecInitProviderUpdatePolicy? UpdatePolicy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecProviderConfigRefPolicy
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
public partial class V1beta1ComputeEnvironmentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1ComputeEnvironmentSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeEnvironmentSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ComputeEnvironmentSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ComputeEnvironmentSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ComputeEnvironmentSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ComputeEnvironmentSpec defines the desired state of ComputeEnvironment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ComputeEnvironmentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ComputeEnvironmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ComputeEnvironmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ComputeEnvironmentSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ComputeEnvironmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentStatusAtProviderComputeResourcesEc2Configuration
{
    /// <summary>The AMI ID used for instances launched in the compute environment that match the image type. This setting overrides the image_id argument in the compute_resources block.</summary>
    [JsonPropertyName("imageIdOverride")]
    public string? ImageIdOverride { get; set; }

    /// <summary>The image type to match with the instance type to select an AMI. If the image_id_override parameter isn't specified, then a recent Amazon ECS-optimized Amazon Linux 2 AMI (ECS_AL2) is used.</summary>
    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }
}

/// <summary>The launch template to use for your compute resources. See details below. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentStatusAtProviderComputeResourcesLaunchTemplate
{
    /// <summary>ID of the launch template. You must specify either the launch template ID or launch template name in the request, but not both.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }

    /// <summary>Name of the launch template.</summary>
    [JsonPropertyName("launchTemplateName")]
    public string? LaunchTemplateName { get; set; }

    /// <summary>The version number of the launch template. Default: The default version of the launch template.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Details of the compute resources managed by the compute environment. This parameter is required for managed compute environments. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentStatusAtProviderComputeResources
{
    /// <summary>The allocation strategy to use for the compute resource in case not enough instances of the best fitting instance type can be allocated. For valid values, refer to the AWS documentation. Defaults to BEST_FIT. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary>Integer of maximum percentage that a Spot Instance price can be when compared with the On-Demand price for that instance type before instances are launched. For example, if your bid percentage is 20% (20), then the Spot price must be below 20% of the current On-Demand price for that EC2 instance. If you leave this field empty, the default value is 100% of the On-Demand price. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("bidPercentage")]
    public double? BidPercentage { get; set; }

    /// <summary>The desired number of EC2 vCPUS in the compute environment. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("desiredVcpus")]
    public double? DesiredVcpus { get; set; }

    /// <summary>Provides information used to select Amazon Machine Images (AMIs) for EC2 instances in the compute environment. If Ec2Configuration isn't specified, the default is ECS_AL2. This parameter isn't applicable to jobs that are running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("ec2Configuration")]
    public IList<V1beta1ComputeEnvironmentStatusAtProviderComputeResourcesEc2Configuration>? Ec2Configuration { get; set; }

    /// <summary>The EC2 key pair that is used for instances launched in the compute environment. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("ec2KeyPair")]
    public string? Ec2KeyPair { get; set; }

    /// <summary>The Amazon Machine Image (AMI) ID used for instances launched in the compute environment. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified. (Deprecated, use ec2_configuration image_id_override instead)</summary>
    [JsonPropertyName("imageId")]
    public string? ImageId { get; set; }

    /// <summary>The Amazon ECS instance role applied to Amazon EC2 instances in a compute environment. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("instanceRole")]
    public string? InstanceRole { get; set; }

    /// <summary>A list of instance types that may be launched. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("instanceType")]
    public IList<string>? InstanceType { get; set; }

    /// <summary>The launch template to use for your compute resources. See details below. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("launchTemplate")]
    public V1beta1ComputeEnvironmentStatusAtProviderComputeResourcesLaunchTemplate? LaunchTemplate { get; set; }

    /// <summary>The maximum number of EC2 vCPUs that an environment can reach.</summary>
    [JsonPropertyName("maxVcpus")]
    public double? MaxVcpus { get; set; }

    /// <summary>The minimum number of EC2 vCPUs that an environment should maintain. For EC2 or SPOT compute environments, if the parameter is not explicitly defined, a 0 default value will be set. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("minVcpus")]
    public double? MinVcpus { get; set; }

    /// <summary>The Amazon EC2 placement group to associate with your compute resources.</summary>
    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary>A list of EC2 security group that are associated with instances launched in the compute environment. This parameter is required for Fargate compute environments.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Amazon EC2 Spot Fleet IAM role applied to a SPOT compute environment. This parameter is required for SPOT compute environments. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("spotIamFleetRole")]
    public string? SpotIamFleetRole { get; set; }

    /// <summary>A list of VPC subnets into which the compute resources are launched.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }

    /// <summary>Key-value pair tags to be applied to resources that are launched in the compute environment. This parameter isn't applicable to jobs running on Fargate resources, and shouldn't be specified.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of compute environment. Valid items are EC2, SPOT, FARGATE or FARGATE_SPOT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Details for the Amazon EKS cluster that supports the compute environment. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentStatusAtProviderEksConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) of the Amazon EKS cluster.</summary>
    [JsonPropertyName("eksClusterArn")]
    public string? EksClusterArn { get; set; }

    /// <summary>The namespace of the Amazon EKS cluster. AWS Batch manages pods in this namespace.</summary>
    [JsonPropertyName("kubernetesNamespace")]
    public string? KubernetesNamespace { get; set; }
}

/// <summary>Specifies the infrastructure update policy for the compute environment. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentStatusAtProviderUpdatePolicy
{
    /// <summary>Specifies the job timeout (in minutes) when the compute environment infrastructure is updated.</summary>
    [JsonPropertyName("jobExecutionTimeoutMinutes")]
    public double? JobExecutionTimeoutMinutes { get; set; }

    /// <summary>Specifies whether jobs are automatically terminated when the computer environment infrastructure is updated.</summary>
    [JsonPropertyName("terminateJobsOnUpdate")]
    public bool? TerminateJobsOnUpdate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) of the compute environment.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Details of the compute resources managed by the compute environment. This parameter is required for managed compute environments. See details below.</summary>
    [JsonPropertyName("computeResources")]
    public V1beta1ComputeEnvironmentStatusAtProviderComputeResources? ComputeResources { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the underlying Amazon ECS cluster used by the compute environment.</summary>
    [JsonPropertyName("ecsClusterArn")]
    public string? EcsClusterArn { get; set; }

    /// <summary>Details for the Amazon EKS cluster that supports the compute environment. See details below.</summary>
    [JsonPropertyName("eksConfiguration")]
    public V1beta1ComputeEnvironmentStatusAtProviderEksConfiguration? EksConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The full Amazon Resource Name (ARN) of the IAM role that allows AWS Batch to make calls to other AWS services on your behalf.</summary>
    [JsonPropertyName("serviceRole")]
    public string? ServiceRole { get; set; }

    /// <summary>The state of the compute environment. If the state is ENABLED, then the compute environment accepts jobs from a queue and can scale out automatically based on queues. Valid items are ENABLED or DISABLED. Defaults to ENABLED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The current status of the compute environment (for example, CREATING or VALID).</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>A short, human-readable string to provide additional details about the current status of the compute environment.</summary>
    [JsonPropertyName("statusReason")]
    public string? StatusReason { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The type of the compute environment. Valid items are MANAGED or UNMANAGED.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Specifies the infrastructure update policy for the compute environment. See details below.</summary>
    [JsonPropertyName("updatePolicy")]
    public V1beta1ComputeEnvironmentStatusAtProviderUpdatePolicy? UpdatePolicy { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentStatusConditions
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

/// <summary>ComputeEnvironmentStatus defines the observed state of ComputeEnvironment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeEnvironmentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ComputeEnvironmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeEnvironmentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ComputeEnvironment is the Schema for the ComputeEnvironments API. Creates a AWS Batch compute environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeEnvironment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeEnvironmentSpec>, IStatus<V1beta1ComputeEnvironmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeEnvironment";
    public const string KubeGroup = "batch.aws.upbound.io";
    public const string KubePluralName = "computeenvironments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ComputeEnvironmentSpec defines the desired state of ComputeEnvironment</summary>
    [JsonPropertyName("spec")]
    public V1beta1ComputeEnvironmentSpec Spec { get; set; }

    /// <summary>ComputeEnvironmentStatus defines the observed state of ComputeEnvironment.</summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeEnvironmentStatus? Status { get; set; }
}