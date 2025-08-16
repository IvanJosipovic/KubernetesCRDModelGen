using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.redshiftserverless.aws.m.upbound.io;
/// <summary>Workgroup is the Schema for the Workgroups API. Provides a Redshift Serverless Workgroup resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WorkgroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Workgroup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WorkgroupList";
    public const string KubeGroup = "redshiftserverless.aws.m.upbound.io";
    public const string KubePluralName = "workgroups";
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
    public IList<V1beta1Workgroup> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecForProviderConfigParameter
{
    /// <summary>The key of the parameter. The options are auto_mv, datestyle, enable_case_sensitive_identifier, enable_user_activity_logging, query_group, search_path, require_ssl, use_fips_ssl, and query monitoring metrics that let you define performance boundaries: max_query_cpu_time, max_query_blocks_read, max_scan_row_count, max_query_execution_time, max_query_queue_time, max_query_cpu_usage_percent, max_query_temp_blocks_to_disk, max_join_row_count and max_nested_loop_join_row_count.</summary>
    [JsonPropertyName("parameterKey")]
    public string? ParameterKey { get; set; }

    /// <summary>The value of the parameter to set.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary>Price-performance scaling for the workgroup. See Price Performance Target below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecForProviderPricePerformanceTarget
{
    /// <summary>Whether to enable price-performance scaling.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The price-performance scaling level. Valid values are 1 (LOW_COST), 25 (ECONOMICAL), 50 (BALANCED), 75 (RESOURCEFUL), and 100 (HIGH_PERFORMANCE).</summary>
    [JsonPropertyName("level")]
    public double? Level { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecForProviderSecurityGroupIdRefsPolicy
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
public partial class V1beta1WorkgroupSpecForProviderSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkgroupSpecForProviderSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecForProviderSecurityGroupIdSelectorPolicy
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
public partial class V1beta1WorkgroupSpecForProviderSecurityGroupIdSelector
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
    public V1beta1WorkgroupSpecForProviderSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecForProviderSubnetIdRefsPolicy
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
public partial class V1beta1WorkgroupSpecForProviderSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkgroupSpecForProviderSubnetIdRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecForProviderSubnetIdSelectorPolicy
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
public partial class V1beta1WorkgroupSpecForProviderSubnetIdSelector
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
    public V1beta1WorkgroupSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecForProvider
{
    /// <summary>The base data warehouse capacity of the workgroup in Redshift Processing Units (RPUs).</summary>
    [JsonPropertyName("baseCapacity")]
    public double? BaseCapacity { get; set; }

    /// <summary>An array of parameters to set for more control over a serverless database. See Config Parameter below.</summary>
    [JsonPropertyName("configParameter")]
    public IList<V1beta1WorkgroupSpecForProviderConfigParameter>? ConfigParameter { get; set; }

    /// <summary>The value that specifies whether to turn on enhanced virtual private cloud (VPC) routing, which forces Amazon Redshift Serverless to route traffic through your VPC instead of over the internet.</summary>
    [JsonPropertyName("enhancedVpcRouting")]
    public bool? EnhancedVpcRouting { get; set; }

    /// <summary>The maximum data-warehouse capacity Amazon Redshift Serverless uses to serve queries, specified in Redshift Processing Units (RPUs).</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>The name of the namespace.</summary>
    [JsonPropertyName("namespaceName")]
    public string? NamespaceName { get; set; }

    /// <summary>The port number on which the cluster accepts incoming connections.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Price-performance scaling for the workgroup. See Price Performance Target below.</summary>
    [JsonPropertyName("pricePerformanceTarget")]
    public V1beta1WorkgroupSpecForProviderPricePerformanceTarget? PricePerformanceTarget { get; set; }

    /// <summary>A value that specifies whether the workgroup can be accessed from a public network.</summary>
    [JsonPropertyName("publiclyAccessible")]
    public bool? PubliclyAccessible { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdRefs")]
    public IList<V1beta1WorkgroupSpecForProviderSecurityGroupIdRefs>? SecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta1WorkgroupSpecForProviderSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>An array of security group IDs to associate with the workgroup.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta1WorkgroupSpecForProviderSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1WorkgroupSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>An array of VPC subnet IDs to associate with the workgroup. When set, must contain at least three subnets spanning three Availability Zones. A minimum number of IP addresses is required and scales with the Base Capacity. For more information, see the following AWS document.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The name of the track for the workgroup. If it is current, you get the most up-to-date certified release version with the latest features, security updates, and performance enhancements. If it is trailing, you will be on the previous certified release. For more information, see the following AWS document.</summary>
    [JsonPropertyName("trackName")]
    public string? TrackName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecInitProviderConfigParameter
{
    /// <summary>The key of the parameter. The options are auto_mv, datestyle, enable_case_sensitive_identifier, enable_user_activity_logging, query_group, search_path, require_ssl, use_fips_ssl, and query monitoring metrics that let you define performance boundaries: max_query_cpu_time, max_query_blocks_read, max_scan_row_count, max_query_execution_time, max_query_queue_time, max_query_cpu_usage_percent, max_query_temp_blocks_to_disk, max_join_row_count and max_nested_loop_join_row_count.</summary>
    [JsonPropertyName("parameterKey")]
    public string? ParameterKey { get; set; }

    /// <summary>The value of the parameter to set.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary>Price-performance scaling for the workgroup. See Price Performance Target below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecInitProviderPricePerformanceTarget
{
    /// <summary>Whether to enable price-performance scaling.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The price-performance scaling level. Valid values are 1 (LOW_COST), 25 (ECONOMICAL), 50 (BALANCED), 75 (RESOURCEFUL), and 100 (HIGH_PERFORMANCE).</summary>
    [JsonPropertyName("level")]
    public double? Level { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecInitProviderSecurityGroupIdRefsPolicy
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
public partial class V1beta1WorkgroupSpecInitProviderSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkgroupSpecInitProviderSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecInitProviderSecurityGroupIdSelectorPolicy
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
public partial class V1beta1WorkgroupSpecInitProviderSecurityGroupIdSelector
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
    public V1beta1WorkgroupSpecInitProviderSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecInitProviderSubnetIdRefsPolicy
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
public partial class V1beta1WorkgroupSpecInitProviderSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkgroupSpecInitProviderSubnetIdRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecInitProviderSubnetIdSelectorPolicy
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
public partial class V1beta1WorkgroupSpecInitProviderSubnetIdSelector
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
    public V1beta1WorkgroupSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecInitProvider
{
    /// <summary>The base data warehouse capacity of the workgroup in Redshift Processing Units (RPUs).</summary>
    [JsonPropertyName("baseCapacity")]
    public double? BaseCapacity { get; set; }

    /// <summary>An array of parameters to set for more control over a serverless database. See Config Parameter below.</summary>
    [JsonPropertyName("configParameter")]
    public IList<V1beta1WorkgroupSpecInitProviderConfigParameter>? ConfigParameter { get; set; }

    /// <summary>The value that specifies whether to turn on enhanced virtual private cloud (VPC) routing, which forces Amazon Redshift Serverless to route traffic through your VPC instead of over the internet.</summary>
    [JsonPropertyName("enhancedVpcRouting")]
    public bool? EnhancedVpcRouting { get; set; }

    /// <summary>The maximum data-warehouse capacity Amazon Redshift Serverless uses to serve queries, specified in Redshift Processing Units (RPUs).</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>The name of the namespace.</summary>
    [JsonPropertyName("namespaceName")]
    public string? NamespaceName { get; set; }

    /// <summary>The port number on which the cluster accepts incoming connections.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Price-performance scaling for the workgroup. See Price Performance Target below.</summary>
    [JsonPropertyName("pricePerformanceTarget")]
    public V1beta1WorkgroupSpecInitProviderPricePerformanceTarget? PricePerformanceTarget { get; set; }

    /// <summary>A value that specifies whether the workgroup can be accessed from a public network.</summary>
    [JsonPropertyName("publiclyAccessible")]
    public bool? PubliclyAccessible { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdRefs")]
    public IList<V1beta1WorkgroupSpecInitProviderSecurityGroupIdRefs>? SecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta1WorkgroupSpecInitProviderSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>An array of security group IDs to associate with the workgroup.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta1WorkgroupSpecInitProviderSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1WorkgroupSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>An array of VPC subnet IDs to associate with the workgroup. When set, must contain at least three subnets spanning three Availability Zones. A minimum number of IP addresses is required and scales with the Base Capacity. For more information, see the following AWS document.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The name of the track for the workgroup. If it is current, you get the most up-to-date certified release version with the latest features, security updates, and performance enhancements. If it is trailing, you will be on the previous certified release. For more information, see the following AWS document.</summary>
    [JsonPropertyName("trackName")]
    public string? TrackName { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecProviderConfigRef
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
public partial class V1beta1WorkgroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WorkgroupSpec defines the desired state of Workgroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1WorkgroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1WorkgroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WorkgroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WorkgroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupStatusAtProviderConfigParameter
{
    /// <summary>The key of the parameter. The options are auto_mv, datestyle, enable_case_sensitive_identifier, enable_user_activity_logging, query_group, search_path, require_ssl, use_fips_ssl, and query monitoring metrics that let you define performance boundaries: max_query_cpu_time, max_query_blocks_read, max_scan_row_count, max_query_execution_time, max_query_queue_time, max_query_cpu_usage_percent, max_query_temp_blocks_to_disk, max_join_row_count and max_nested_loop_join_row_count.</summary>
    [JsonPropertyName("parameterKey")]
    public string? ParameterKey { get; set; }

    /// <summary>The value of the parameter to set.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupStatusAtProviderEndpointVpcEndpointNetworkInterface
{
    /// <summary>The availability Zone.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The unique identifier of the network interface.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    /// <summary>The IPv4 address of the network interface within the subnet.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The unique identifier of the subnet.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupStatusAtProviderEndpointVpcEndpoint
{
    /// <summary>The network interfaces of the endpoint.. See Network Interface below.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1WorkgroupStatusAtProviderEndpointVpcEndpointNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>The DNS address of the VPC endpoint.</summary>
    [JsonPropertyName("vpcEndpointId")]
    public string? VpcEndpointId { get; set; }

    /// <summary>The port that Amazon Redshift Serverless listens on.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupStatusAtProviderEndpoint
{
    /// <summary>The DNS address of the VPC endpoint.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The port number on which the cluster accepts incoming connections.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The VPC endpoint or the Redshift Serverless workgroup. See VPC Endpoint below.</summary>
    [JsonPropertyName("vpcEndpoint")]
    public IList<V1beta1WorkgroupStatusAtProviderEndpointVpcEndpoint>? VpcEndpoint { get; set; }
}

/// <summary>Price-performance scaling for the workgroup. See Price Performance Target below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupStatusAtProviderPricePerformanceTarget
{
    /// <summary>Whether to enable price-performance scaling.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The price-performance scaling level. Valid values are 1 (LOW_COST), 25 (ECONOMICAL), 50 (BALANCED), 75 (RESOURCEFUL), and 100 (HIGH_PERFORMANCE).</summary>
    [JsonPropertyName("level")]
    public double? Level { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of the Redshift Serverless Workgroup.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The base data warehouse capacity of the workgroup in Redshift Processing Units (RPUs).</summary>
    [JsonPropertyName("baseCapacity")]
    public double? BaseCapacity { get; set; }

    /// <summary>An array of parameters to set for more control over a serverless database. See Config Parameter below.</summary>
    [JsonPropertyName("configParameter")]
    public IList<V1beta1WorkgroupStatusAtProviderConfigParameter>? ConfigParameter { get; set; }

    /// <summary>The endpoint that is created from the workgroup. See Endpoint below.</summary>
    [JsonPropertyName("endpoint")]
    public IList<V1beta1WorkgroupStatusAtProviderEndpoint>? Endpoint { get; set; }

    /// <summary>The value that specifies whether to turn on enhanced virtual private cloud (VPC) routing, which forces Amazon Redshift Serverless to route traffic through your VPC instead of over the internet.</summary>
    [JsonPropertyName("enhancedVpcRouting")]
    public bool? EnhancedVpcRouting { get; set; }

    /// <summary>The Redshift Workgroup Name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The maximum data-warehouse capacity Amazon Redshift Serverless uses to serve queries, specified in Redshift Processing Units (RPUs).</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>The name of the namespace.</summary>
    [JsonPropertyName("namespaceName")]
    public string? NamespaceName { get; set; }

    /// <summary>The port number on which the cluster accepts incoming connections.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Price-performance scaling for the workgroup. See Price Performance Target below.</summary>
    [JsonPropertyName("pricePerformanceTarget")]
    public V1beta1WorkgroupStatusAtProviderPricePerformanceTarget? PricePerformanceTarget { get; set; }

    /// <summary>A value that specifies whether the workgroup can be accessed from a public network.</summary>
    [JsonPropertyName("publiclyAccessible")]
    public bool? PubliclyAccessible { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>An array of security group IDs to associate with the workgroup.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>An array of VPC subnet IDs to associate with the workgroup. When set, must contain at least three subnets spanning three Availability Zones. A minimum number of IP addresses is required and scales with the Base Capacity. For more information, see the following AWS document.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The name of the track for the workgroup. If it is current, you get the most up-to-date certified release version with the latest features, security updates, and performance enhancements. If it is trailing, you will be on the previous certified release. For more information, see the following AWS document.</summary>
    [JsonPropertyName("trackName")]
    public string? TrackName { get; set; }

    /// <summary>The Redshift Workgroup ID.</summary>
    [JsonPropertyName("workgroupId")]
    public string? WorkgroupId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupStatusConditions
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

/// <summary>WorkgroupStatus defines the observed state of Workgroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1WorkgroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WorkgroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Workgroup is the Schema for the Workgroups API. Provides a Redshift Serverless Workgroup resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Workgroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WorkgroupSpec>, IStatus<V1beta1WorkgroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Workgroup";
    public const string KubeGroup = "redshiftserverless.aws.m.upbound.io";
    public const string KubePluralName = "workgroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WorkgroupSpec defines the desired state of Workgroup</summary>
    [JsonPropertyName("spec")]
    public V1beta1WorkgroupSpec Spec { get; set; }

    /// <summary>WorkgroupStatus defines the observed state of Workgroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1WorkgroupStatus? Status { get; set; }
}