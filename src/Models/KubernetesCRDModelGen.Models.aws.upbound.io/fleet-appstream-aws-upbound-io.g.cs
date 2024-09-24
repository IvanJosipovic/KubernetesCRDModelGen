using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appstream.aws.upbound.io;
public enum V1beta1FleetSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1FleetSpecForProviderComputeCapacity
{
    /// <summary>Desired number of streaming instances.</summary>
    [JsonPropertyName("desiredInstances")]
    public double? DesiredInstances { get; set; }

    /// <summary>Desired number of user sessions for a multi-session fleet. This is not allowed for single-session fleets.</summary>
    [JsonPropertyName("desiredSessions")]
    public double? DesiredSessions { get; set; }
}

/// <summary></summary>
public partial class V1beta1FleetSpecForProviderDomainJoinInfo
{
    /// <summary>Fully qualified name of the directory (for example, corp.example.com).</summary>
    [JsonPropertyName("directoryName")]
    public string? DirectoryName { get; set; }

    /// <summary>Distinguished name of the organizational unit for computer accounts.</summary>
    [JsonPropertyName("organizationalUnitDistinguishedName")]
    public string? OrganizationalUnitDistinguishedName { get; set; }
}

public enum V1beta1FleetSpecForProviderIamRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FleetSpecForProviderIamRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1FleetSpecForProviderIamRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecForProviderIamRoleArnRefPolicyResolutionEnum>))]
    public V1beta1FleetSpecForProviderIamRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecForProviderIamRoleArnRefPolicyResolveEnum>))]
    public V1beta1FleetSpecForProviderIamRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate iamRoleArn.</summary>
public partial class V1beta1FleetSpecForProviderIamRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecForProviderIamRoleArnRefPolicy? Policy { get; set; }
}

public enum V1beta1FleetSpecForProviderIamRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FleetSpecForProviderIamRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1FleetSpecForProviderIamRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecForProviderIamRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1FleetSpecForProviderIamRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecForProviderIamRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1FleetSpecForProviderIamRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate iamRoleArn.</summary>
public partial class V1beta1FleetSpecForProviderIamRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecForProviderIamRoleArnSelectorPolicy? Policy { get; set; }
}

public enum V1beta1FleetSpecForProviderVpcConfigSubnetIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FleetSpecForProviderVpcConfigSubnetIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1FleetSpecForProviderVpcConfigSubnetIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecForProviderVpcConfigSubnetIdRefsPolicyResolutionEnum>))]
    public V1beta1FleetSpecForProviderVpcConfigSubnetIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecForProviderVpcConfigSubnetIdRefsPolicyResolveEnum>))]
    public V1beta1FleetSpecForProviderVpcConfigSubnetIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1FleetSpecForProviderVpcConfigSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecForProviderVpcConfigSubnetIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1FleetSpecForProviderVpcConfigSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FleetSpecForProviderVpcConfigSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1FleetSpecForProviderVpcConfigSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecForProviderVpcConfigSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1FleetSpecForProviderVpcConfigSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecForProviderVpcConfigSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1FleetSpecForProviderVpcConfigSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
public partial class V1beta1FleetSpecForProviderVpcConfigSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecForProviderVpcConfigSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1FleetSpecForProviderVpcConfig
{
    /// <summary>Identifiers of the security groups for the fleet or image builder.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta1FleetSpecForProviderVpcConfigSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1FleetSpecForProviderVpcConfigSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Identifiers of the subnets to which a network interface is attached from the fleet instance or image builder instance.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

/// <summary></summary>
public partial class V1beta1FleetSpecForProvider
{
    /// <summary>Configuration block for the desired capacity of the fleet. See below.</summary>
    [JsonPropertyName("computeCapacity")]
    public IList<V1beta1FleetSpecForProviderComputeCapacity>? ComputeCapacity { get; set; }

    /// <summary>Description to display.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Amount of time that a streaming session remains active after users disconnect.</summary>
    [JsonPropertyName("disconnectTimeoutInSeconds")]
    public double? DisconnectTimeoutInSeconds { get; set; }

    /// <summary>Human-readable friendly name for the AppStream fleet.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Configuration block for the name of the directory and organizational unit (OU) to use to join the fleet to a Microsoft Active Directory domain. See below.</summary>
    [JsonPropertyName("domainJoinInfo")]
    public IList<V1beta1FleetSpecForProviderDomainJoinInfo>? DomainJoinInfo { get; set; }

    /// <summary>Enables or disables default internet access for the fleet.</summary>
    [JsonPropertyName("enableDefaultInternetAccess")]
    public bool? EnableDefaultInternetAccess { get; set; }

    /// <summary>Fleet type. Valid values are: ON_DEMAND, ALWAYS_ON</summary>
    [JsonPropertyName("fleetType")]
    public string? FleetType { get; set; }

    /// <summary>ARN of the IAM role to apply to the fleet.</summary>
    [JsonPropertyName("iamRoleArn")]
    public string? IamRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate iamRoleArn.</summary>
    [JsonPropertyName("iamRoleArnRef")]
    public V1beta1FleetSpecForProviderIamRoleArnRef? IamRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate iamRoleArn.</summary>
    [JsonPropertyName("iamRoleArnSelector")]
    public V1beta1FleetSpecForProviderIamRoleArnSelector? IamRoleArnSelector { get; set; }

    /// <summary>Amount of time that users can be idle (inactive) before they are disconnected from their streaming session and the disconnect_timeout_in_seconds time interval begins. Defaults to 60 seconds.</summary>
    [JsonPropertyName("idleDisconnectTimeoutInSeconds")]
    public double? IdleDisconnectTimeoutInSeconds { get; set; }

    /// <summary>ARN of the public, private, or shared image to use.</summary>
    [JsonPropertyName("imageArn")]
    public string? ImageArn { get; set; }

    /// <summary>Name of the image used to create the fleet.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>Instance type to use when launching fleet instances.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The maximum number of user sessions on an instance. This only applies to multi-session fleets.</summary>
    [JsonPropertyName("maxSessionsPerInstance")]
    public double? MaxSessionsPerInstance { get; set; }

    /// <summary>Maximum amount of time that a streaming session can remain active, in seconds.</summary>
    [JsonPropertyName("maxUserDurationInSeconds")]
    public double? MaxUserDurationInSeconds { get; set; }

    /// <summary>Unique name for the fleet.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>AppStream 2.0 view that is displayed to your users when they stream from the fleet. When APP is specified, only the windows of applications opened by users display. When DESKTOP is specified, the standard desktop that is provided by the operating system displays. If not specified, defaults to APP.</summary>
    [JsonPropertyName("streamView")]
    public string? StreamView { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for the VPC configuration for the image builder. See below.</summary>
    [JsonPropertyName("vpcConfig")]
    public IList<V1beta1FleetSpecForProviderVpcConfig>? VpcConfig { get; set; }
}

/// <summary></summary>
public partial class V1beta1FleetSpecInitProviderComputeCapacity
{
    /// <summary>Desired number of streaming instances.</summary>
    [JsonPropertyName("desiredInstances")]
    public double? DesiredInstances { get; set; }

    /// <summary>Desired number of user sessions for a multi-session fleet. This is not allowed for single-session fleets.</summary>
    [JsonPropertyName("desiredSessions")]
    public double? DesiredSessions { get; set; }
}

/// <summary></summary>
public partial class V1beta1FleetSpecInitProviderDomainJoinInfo
{
    /// <summary>Fully qualified name of the directory (for example, corp.example.com).</summary>
    [JsonPropertyName("directoryName")]
    public string? DirectoryName { get; set; }

    /// <summary>Distinguished name of the organizational unit for computer accounts.</summary>
    [JsonPropertyName("organizationalUnitDistinguishedName")]
    public string? OrganizationalUnitDistinguishedName { get; set; }
}

public enum V1beta1FleetSpecInitProviderIamRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FleetSpecInitProviderIamRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1FleetSpecInitProviderIamRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecInitProviderIamRoleArnRefPolicyResolutionEnum>))]
    public V1beta1FleetSpecInitProviderIamRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecInitProviderIamRoleArnRefPolicyResolveEnum>))]
    public V1beta1FleetSpecInitProviderIamRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate iamRoleArn.</summary>
public partial class V1beta1FleetSpecInitProviderIamRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecInitProviderIamRoleArnRefPolicy? Policy { get; set; }
}

public enum V1beta1FleetSpecInitProviderIamRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FleetSpecInitProviderIamRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1FleetSpecInitProviderIamRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecInitProviderIamRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1FleetSpecInitProviderIamRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecInitProviderIamRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1FleetSpecInitProviderIamRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate iamRoleArn.</summary>
public partial class V1beta1FleetSpecInitProviderIamRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecInitProviderIamRoleArnSelectorPolicy? Policy { get; set; }
}

public enum V1beta1FleetSpecInitProviderVpcConfigSubnetIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FleetSpecInitProviderVpcConfigSubnetIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1FleetSpecInitProviderVpcConfigSubnetIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecInitProviderVpcConfigSubnetIdRefsPolicyResolutionEnum>))]
    public V1beta1FleetSpecInitProviderVpcConfigSubnetIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecInitProviderVpcConfigSubnetIdRefsPolicyResolveEnum>))]
    public V1beta1FleetSpecInitProviderVpcConfigSubnetIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1FleetSpecInitProviderVpcConfigSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecInitProviderVpcConfigSubnetIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1FleetSpecInitProviderVpcConfigSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FleetSpecInitProviderVpcConfigSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1FleetSpecInitProviderVpcConfigSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecInitProviderVpcConfigSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1FleetSpecInitProviderVpcConfigSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecInitProviderVpcConfigSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1FleetSpecInitProviderVpcConfigSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
public partial class V1beta1FleetSpecInitProviderVpcConfigSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecInitProviderVpcConfigSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1FleetSpecInitProviderVpcConfig
{
    /// <summary>Identifiers of the security groups for the fleet or image builder.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta1FleetSpecInitProviderVpcConfigSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1FleetSpecInitProviderVpcConfigSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Identifiers of the subnets to which a network interface is attached from the fleet instance or image builder instance.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1FleetSpecInitProvider
{
    /// <summary>Configuration block for the desired capacity of the fleet. See below.</summary>
    [JsonPropertyName("computeCapacity")]
    public IList<V1beta1FleetSpecInitProviderComputeCapacity>? ComputeCapacity { get; set; }

    /// <summary>Description to display.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Amount of time that a streaming session remains active after users disconnect.</summary>
    [JsonPropertyName("disconnectTimeoutInSeconds")]
    public double? DisconnectTimeoutInSeconds { get; set; }

    /// <summary>Human-readable friendly name for the AppStream fleet.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Configuration block for the name of the directory and organizational unit (OU) to use to join the fleet to a Microsoft Active Directory domain. See below.</summary>
    [JsonPropertyName("domainJoinInfo")]
    public IList<V1beta1FleetSpecInitProviderDomainJoinInfo>? DomainJoinInfo { get; set; }

    /// <summary>Enables or disables default internet access for the fleet.</summary>
    [JsonPropertyName("enableDefaultInternetAccess")]
    public bool? EnableDefaultInternetAccess { get; set; }

    /// <summary>Fleet type. Valid values are: ON_DEMAND, ALWAYS_ON</summary>
    [JsonPropertyName("fleetType")]
    public string? FleetType { get; set; }

    /// <summary>ARN of the IAM role to apply to the fleet.</summary>
    [JsonPropertyName("iamRoleArn")]
    public string? IamRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate iamRoleArn.</summary>
    [JsonPropertyName("iamRoleArnRef")]
    public V1beta1FleetSpecInitProviderIamRoleArnRef? IamRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate iamRoleArn.</summary>
    [JsonPropertyName("iamRoleArnSelector")]
    public V1beta1FleetSpecInitProviderIamRoleArnSelector? IamRoleArnSelector { get; set; }

    /// <summary>Amount of time that users can be idle (inactive) before they are disconnected from their streaming session and the disconnect_timeout_in_seconds time interval begins. Defaults to 60 seconds.</summary>
    [JsonPropertyName("idleDisconnectTimeoutInSeconds")]
    public double? IdleDisconnectTimeoutInSeconds { get; set; }

    /// <summary>ARN of the public, private, or shared image to use.</summary>
    [JsonPropertyName("imageArn")]
    public string? ImageArn { get; set; }

    /// <summary>Name of the image used to create the fleet.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>Instance type to use when launching fleet instances.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The maximum number of user sessions on an instance. This only applies to multi-session fleets.</summary>
    [JsonPropertyName("maxSessionsPerInstance")]
    public double? MaxSessionsPerInstance { get; set; }

    /// <summary>Maximum amount of time that a streaming session can remain active, in seconds.</summary>
    [JsonPropertyName("maxUserDurationInSeconds")]
    public double? MaxUserDurationInSeconds { get; set; }

    /// <summary>Unique name for the fleet.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>AppStream 2.0 view that is displayed to your users when they stream from the fleet. When APP is specified, only the windows of applications opened by users display. When DESKTOP is specified, the standard desktop that is provided by the operating system displays. If not specified, defaults to APP.</summary>
    [JsonPropertyName("streamView")]
    public string? StreamView { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for the VPC configuration for the image builder. See below.</summary>
    [JsonPropertyName("vpcConfig")]
    public IList<V1beta1FleetSpecInitProviderVpcConfig>? VpcConfig { get; set; }
}

public enum V1beta1FleetSpecManagementPoliciesEnum
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

public enum V1beta1FleetSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FleetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1FleetSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1FleetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1FleetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1FleetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1FleetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FleetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1FleetSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1FleetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1FleetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1FleetSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1FleetSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1FleetSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1FleetSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1FleetSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1FleetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>FleetSpec defines the desired state of Fleet</summary>
public partial class V1beta1FleetSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecDeletionPolicyEnum>))]
    public V1beta1FleetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FleetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FleetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1FleetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FleetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1FleetSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FleetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1FleetStatusAtProviderComputeCapacity
{
    /// <summary>Number of currently available instances that can be used to stream sessions.</summary>
    [JsonPropertyName("available")]
    public double? Available { get; set; }

    /// <summary>Desired number of streaming instances.</summary>
    [JsonPropertyName("desiredInstances")]
    public double? DesiredInstances { get; set; }

    /// <summary>Desired number of user sessions for a multi-session fleet. This is not allowed for single-session fleets.</summary>
    [JsonPropertyName("desiredSessions")]
    public double? DesiredSessions { get; set; }

    /// <summary>Number of instances in use for streaming.</summary>
    [JsonPropertyName("inUse")]
    public double? InUse { get; set; }

    /// <summary>Total number of simultaneous streaming instances that are running.</summary>
    [JsonPropertyName("running")]
    public double? Running { get; set; }
}

/// <summary></summary>
public partial class V1beta1FleetStatusAtProviderDomainJoinInfo
{
    /// <summary>Fully qualified name of the directory (for example, corp.example.com).</summary>
    [JsonPropertyName("directoryName")]
    public string? DirectoryName { get; set; }

    /// <summary>Distinguished name of the organizational unit for computer accounts.</summary>
    [JsonPropertyName("organizationalUnitDistinguishedName")]
    public string? OrganizationalUnitDistinguishedName { get; set; }
}

/// <summary></summary>
public partial class V1beta1FleetStatusAtProviderVpcConfig
{
    /// <summary>Identifiers of the security groups for the fleet or image builder.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>Identifiers of the subnets to which a network interface is attached from the fleet instance or image builder instance.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

/// <summary></summary>
public partial class V1beta1FleetStatusAtProvider
{
    /// <summary>ARN of the appstream fleet.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Configuration block for the desired capacity of the fleet. See below.</summary>
    [JsonPropertyName("computeCapacity")]
    public IList<V1beta1FleetStatusAtProviderComputeCapacity>? ComputeCapacity { get; set; }

    /// <summary>Date and time, in UTC and extended RFC 3339 format, when the fleet was created.</summary>
    [JsonPropertyName("createdTime")]
    public string? CreatedTime { get; set; }

    /// <summary>Description to display.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Amount of time that a streaming session remains active after users disconnect.</summary>
    [JsonPropertyName("disconnectTimeoutInSeconds")]
    public double? DisconnectTimeoutInSeconds { get; set; }

    /// <summary>Human-readable friendly name for the AppStream fleet.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Configuration block for the name of the directory and organizational unit (OU) to use to join the fleet to a Microsoft Active Directory domain. See below.</summary>
    [JsonPropertyName("domainJoinInfo")]
    public IList<V1beta1FleetStatusAtProviderDomainJoinInfo>? DomainJoinInfo { get; set; }

    /// <summary>Enables or disables default internet access for the fleet.</summary>
    [JsonPropertyName("enableDefaultInternetAccess")]
    public bool? EnableDefaultInternetAccess { get; set; }

    /// <summary>Fleet type. Valid values are: ON_DEMAND, ALWAYS_ON</summary>
    [JsonPropertyName("fleetType")]
    public string? FleetType { get; set; }

    /// <summary>ARN of the IAM role to apply to the fleet.</summary>
    [JsonPropertyName("iamRoleArn")]
    public string? IamRoleArn { get; set; }

    /// <summary>Unique identifier (ID) of the appstream fleet.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Amount of time that users can be idle (inactive) before they are disconnected from their streaming session and the disconnect_timeout_in_seconds time interval begins. Defaults to 60 seconds.</summary>
    [JsonPropertyName("idleDisconnectTimeoutInSeconds")]
    public double? IdleDisconnectTimeoutInSeconds { get; set; }

    /// <summary>ARN of the public, private, or shared image to use.</summary>
    [JsonPropertyName("imageArn")]
    public string? ImageArn { get; set; }

    /// <summary>Name of the image used to create the fleet.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>Instance type to use when launching fleet instances.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The maximum number of user sessions on an instance. This only applies to multi-session fleets.</summary>
    [JsonPropertyName("maxSessionsPerInstance")]
    public double? MaxSessionsPerInstance { get; set; }

    /// <summary>Maximum amount of time that a streaming session can remain active, in seconds.</summary>
    [JsonPropertyName("maxUserDurationInSeconds")]
    public double? MaxUserDurationInSeconds { get; set; }

    /// <summary>Unique name for the fleet.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>State of the fleet. Can be STARTING, RUNNING, STOPPING or STOPPED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>AppStream 2.0 view that is displayed to your users when they stream from the fleet. When APP is specified, only the windows of applications opened by users display. When DESKTOP is specified, the standard desktop that is provided by the operating system displays. If not specified, defaults to APP.</summary>
    [JsonPropertyName("streamView")]
    public string? StreamView { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Configuration block for the VPC configuration for the image builder. See below.</summary>
    [JsonPropertyName("vpcConfig")]
    public IList<V1beta1FleetStatusAtProviderVpcConfig>? VpcConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1FleetStatusConditions
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

/// <summary>FleetStatus defines the observed state of Fleet.</summary>
public partial class V1beta1FleetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FleetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FleetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Fleet is the Schema for the Fleets API. Provides an AppStream fleet</summary>
public partial class V1beta1Fleet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FleetSpec>, IStatus<V1beta1FleetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Fleet";
    public const string KubeGroup = "appstream.aws.upbound.io";
    public const string KubePluralName = "fleet";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FleetSpec defines the desired state of Fleet</summary>
    [JsonPropertyName("spec")]
    public V1beta1FleetSpec Spec { get; set; }

    /// <summary>FleetStatus defines the observed state of Fleet.</summary>
    [JsonPropertyName("status")]
    public V1beta1FleetStatus? Status { get; set; }
}