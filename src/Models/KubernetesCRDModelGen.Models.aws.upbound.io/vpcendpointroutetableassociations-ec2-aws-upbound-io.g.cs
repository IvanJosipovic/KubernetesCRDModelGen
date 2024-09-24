using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.upbound.io;
public enum V1beta1VPCEndpointRouteTableAssociationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1VPCEndpointRouteTableAssociationSpecForProviderRouteTableIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPCEndpointRouteTableAssociationSpecForProviderRouteTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecForProviderRouteTableIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointRouteTableAssociationSpecForProviderRouteTableIdRefPolicyResolutionEnum>))]
    public V1beta1VPCEndpointRouteTableAssociationSpecForProviderRouteTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointRouteTableAssociationSpecForProviderRouteTableIdRefPolicyResolveEnum>))]
    public V1beta1VPCEndpointRouteTableAssociationSpecForProviderRouteTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecForProviderRouteTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCEndpointRouteTableAssociationSpecForProviderRouteTableIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VPCEndpointRouteTableAssociationSpecForProviderRouteTableIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPCEndpointRouteTableAssociationSpecForProviderRouteTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecForProviderRouteTableIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointRouteTableAssociationSpecForProviderRouteTableIdSelectorPolicyResolutionEnum>))]
    public V1beta1VPCEndpointRouteTableAssociationSpecForProviderRouteTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointRouteTableAssociationSpecForProviderRouteTableIdSelectorPolicyResolveEnum>))]
    public V1beta1VPCEndpointRouteTableAssociationSpecForProviderRouteTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecForProviderRouteTableIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCEndpointRouteTableAssociationSpecForProviderRouteTableIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1VPCEndpointRouteTableAssociationSpecForProviderVpcEndpointIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPCEndpointRouteTableAssociationSpecForProviderVpcEndpointIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecForProviderVpcEndpointIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointRouteTableAssociationSpecForProviderVpcEndpointIdRefPolicyResolutionEnum>))]
    public V1beta1VPCEndpointRouteTableAssociationSpecForProviderVpcEndpointIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointRouteTableAssociationSpecForProviderVpcEndpointIdRefPolicyResolveEnum>))]
    public V1beta1VPCEndpointRouteTableAssociationSpecForProviderVpcEndpointIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecForProviderVpcEndpointIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCEndpointRouteTableAssociationSpecForProviderVpcEndpointIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VPCEndpointRouteTableAssociationSpecForProviderVpcEndpointIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPCEndpointRouteTableAssociationSpecForProviderVpcEndpointIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecForProviderVpcEndpointIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointRouteTableAssociationSpecForProviderVpcEndpointIdSelectorPolicyResolutionEnum>))]
    public V1beta1VPCEndpointRouteTableAssociationSpecForProviderVpcEndpointIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointRouteTableAssociationSpecForProviderVpcEndpointIdSelectorPolicyResolveEnum>))]
    public V1beta1VPCEndpointRouteTableAssociationSpecForProviderVpcEndpointIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecForProviderVpcEndpointIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCEndpointRouteTableAssociationSpecForProviderVpcEndpointIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecForProvider
{
    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Identifier of the EC2 Route Table to be associated with the VPC Endpoint.</summary>
    [JsonPropertyName("routeTableId")]
    public string? RouteTableId { get; set; }

    /// <summary>Reference to a RouteTable in ec2 to populate routeTableId.</summary>
    [JsonPropertyName("routeTableIdRef")]
    public V1beta1VPCEndpointRouteTableAssociationSpecForProviderRouteTableIdRef? RouteTableIdRef { get; set; }

    /// <summary>Selector for a RouteTable in ec2 to populate routeTableId.</summary>
    [JsonPropertyName("routeTableIdSelector")]
    public V1beta1VPCEndpointRouteTableAssociationSpecForProviderRouteTableIdSelector? RouteTableIdSelector { get; set; }

    /// <summary>Identifier of the VPC Endpoint with which the EC2 Route Table will be associated.</summary>
    [JsonPropertyName("vpcEndpointId")]
    public string? VpcEndpointId { get; set; }

    /// <summary>Reference to a VPCEndpoint in ec2 to populate vpcEndpointId.</summary>
    [JsonPropertyName("vpcEndpointIdRef")]
    public V1beta1VPCEndpointRouteTableAssociationSpecForProviderVpcEndpointIdRef? VpcEndpointIdRef { get; set; }

    /// <summary>Selector for a VPCEndpoint in ec2 to populate vpcEndpointId.</summary>
    [JsonPropertyName("vpcEndpointIdSelector")]
    public V1beta1VPCEndpointRouteTableAssociationSpecForProviderVpcEndpointIdSelector? VpcEndpointIdSelector { get; set; }
}

public enum V1beta1VPCEndpointRouteTableAssociationSpecInitProviderRouteTableIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPCEndpointRouteTableAssociationSpecInitProviderRouteTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecInitProviderRouteTableIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointRouteTableAssociationSpecInitProviderRouteTableIdRefPolicyResolutionEnum>))]
    public V1beta1VPCEndpointRouteTableAssociationSpecInitProviderRouteTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointRouteTableAssociationSpecInitProviderRouteTableIdRefPolicyResolveEnum>))]
    public V1beta1VPCEndpointRouteTableAssociationSpecInitProviderRouteTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecInitProviderRouteTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCEndpointRouteTableAssociationSpecInitProviderRouteTableIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VPCEndpointRouteTableAssociationSpecInitProviderRouteTableIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPCEndpointRouteTableAssociationSpecInitProviderRouteTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecInitProviderRouteTableIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointRouteTableAssociationSpecInitProviderRouteTableIdSelectorPolicyResolutionEnum>))]
    public V1beta1VPCEndpointRouteTableAssociationSpecInitProviderRouteTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointRouteTableAssociationSpecInitProviderRouteTableIdSelectorPolicyResolveEnum>))]
    public V1beta1VPCEndpointRouteTableAssociationSpecInitProviderRouteTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecInitProviderRouteTableIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCEndpointRouteTableAssociationSpecInitProviderRouteTableIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1VPCEndpointRouteTableAssociationSpecInitProviderVpcEndpointIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPCEndpointRouteTableAssociationSpecInitProviderVpcEndpointIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecInitProviderVpcEndpointIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointRouteTableAssociationSpecInitProviderVpcEndpointIdRefPolicyResolutionEnum>))]
    public V1beta1VPCEndpointRouteTableAssociationSpecInitProviderVpcEndpointIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointRouteTableAssociationSpecInitProviderVpcEndpointIdRefPolicyResolveEnum>))]
    public V1beta1VPCEndpointRouteTableAssociationSpecInitProviderVpcEndpointIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecInitProviderVpcEndpointIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCEndpointRouteTableAssociationSpecInitProviderVpcEndpointIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VPCEndpointRouteTableAssociationSpecInitProviderVpcEndpointIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPCEndpointRouteTableAssociationSpecInitProviderVpcEndpointIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecInitProviderVpcEndpointIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointRouteTableAssociationSpecInitProviderVpcEndpointIdSelectorPolicyResolutionEnum>))]
    public V1beta1VPCEndpointRouteTableAssociationSpecInitProviderVpcEndpointIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointRouteTableAssociationSpecInitProviderVpcEndpointIdSelectorPolicyResolveEnum>))]
    public V1beta1VPCEndpointRouteTableAssociationSpecInitProviderVpcEndpointIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecInitProviderVpcEndpointIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCEndpointRouteTableAssociationSpecInitProviderVpcEndpointIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecInitProvider
{
    /// <summary>Identifier of the EC2 Route Table to be associated with the VPC Endpoint.</summary>
    [JsonPropertyName("routeTableId")]
    public string? RouteTableId { get; set; }

    /// <summary>Reference to a RouteTable in ec2 to populate routeTableId.</summary>
    [JsonPropertyName("routeTableIdRef")]
    public V1beta1VPCEndpointRouteTableAssociationSpecInitProviderRouteTableIdRef? RouteTableIdRef { get; set; }

    /// <summary>Selector for a RouteTable in ec2 to populate routeTableId.</summary>
    [JsonPropertyName("routeTableIdSelector")]
    public V1beta1VPCEndpointRouteTableAssociationSpecInitProviderRouteTableIdSelector? RouteTableIdSelector { get; set; }

    /// <summary>Identifier of the VPC Endpoint with which the EC2 Route Table will be associated.</summary>
    [JsonPropertyName("vpcEndpointId")]
    public string? VpcEndpointId { get; set; }

    /// <summary>Reference to a VPCEndpoint in ec2 to populate vpcEndpointId.</summary>
    [JsonPropertyName("vpcEndpointIdRef")]
    public V1beta1VPCEndpointRouteTableAssociationSpecInitProviderVpcEndpointIdRef? VpcEndpointIdRef { get; set; }

    /// <summary>Selector for a VPCEndpoint in ec2 to populate vpcEndpointId.</summary>
    [JsonPropertyName("vpcEndpointIdSelector")]
    public V1beta1VPCEndpointRouteTableAssociationSpecInitProviderVpcEndpointIdSelector? VpcEndpointIdSelector { get; set; }
}

public enum V1beta1VPCEndpointRouteTableAssociationSpecManagementPoliciesEnum
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

public enum V1beta1VPCEndpointRouteTableAssociationSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPCEndpointRouteTableAssociationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointRouteTableAssociationSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1VPCEndpointRouteTableAssociationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointRouteTableAssociationSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1VPCEndpointRouteTableAssociationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCEndpointRouteTableAssociationSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1VPCEndpointRouteTableAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPCEndpointRouteTableAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointRouteTableAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1VPCEndpointRouteTableAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointRouteTableAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1VPCEndpointRouteTableAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCEndpointRouteTableAssociationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1VPCEndpointRouteTableAssociationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1VPCEndpointRouteTableAssociationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1VPCEndpointRouteTableAssociationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1VPCEndpointRouteTableAssociationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPCEndpointRouteTableAssociationSpecDeletionPolicyEnum>))]
    public V1beta1VPCEndpointRouteTableAssociationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VPCEndpointRouteTableAssociationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VPCEndpointRouteTableAssociationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1VPCEndpointRouteTableAssociationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VPCEndpointRouteTableAssociationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1VPCEndpointRouteTableAssociationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VPCEndpointRouteTableAssociationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1VPCEndpointRouteTableAssociationStatusAtProvider
{
    /// <summary>A hash of the EC2 Route Table and VPC Endpoint identifiers.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identifier of the EC2 Route Table to be associated with the VPC Endpoint.</summary>
    [JsonPropertyName("routeTableId")]
    public string? RouteTableId { get; set; }

    /// <summary>Identifier of the VPC Endpoint with which the EC2 Route Table will be associated.</summary>
    [JsonPropertyName("vpcEndpointId")]
    public string? VpcEndpointId { get; set; }
}

public partial class V1beta1VPCEndpointRouteTableAssociationStatusConditions
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

public partial class V1beta1VPCEndpointRouteTableAssociationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VPCEndpointRouteTableAssociationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VPCEndpointRouteTableAssociationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VPCEndpointRouteTableAssociation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VPCEndpointRouteTableAssociationSpec>, IStatus<V1beta1VPCEndpointRouteTableAssociationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPCEndpointRouteTableAssociation";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "vpcendpointroutetableassociations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VPCEndpointRouteTableAssociationSpec defines the desired state of VPCEndpointRouteTableAssociation</summary>
    [JsonPropertyName("spec")]
    public V1beta1VPCEndpointRouteTableAssociationSpec Spec { get; set; }

    /// <summary>VPCEndpointRouteTableAssociationStatus defines the observed state of VPCEndpointRouteTableAssociation.</summary>
    [JsonPropertyName("status")]
    public V1beta1VPCEndpointRouteTableAssociationStatus? Status { get; set; }
}