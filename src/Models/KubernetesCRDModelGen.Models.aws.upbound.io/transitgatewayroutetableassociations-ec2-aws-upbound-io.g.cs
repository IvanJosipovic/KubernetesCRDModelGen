using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.upbound.io;
public enum V1beta1TransitGatewayRouteTableAssociationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayAttachmentIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayAttachmentIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayAttachmentIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayAttachmentIdRefPolicyResolutionEnum>))]
    public V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayAttachmentIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayAttachmentIdRefPolicyResolveEnum>))]
    public V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayAttachmentIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayAttachmentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayAttachmentIdRefPolicy? Policy { get; set; }
}

public enum V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayAttachmentIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayAttachmentIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayAttachmentIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayAttachmentIdSelectorPolicyResolutionEnum>))]
    public V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayAttachmentIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayAttachmentIdSelectorPolicyResolveEnum>))]
    public V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayAttachmentIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayAttachmentIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayAttachmentIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayRouteTableIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayRouteTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayRouteTableIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayRouteTableIdRefPolicyResolutionEnum>))]
    public V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayRouteTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayRouteTableIdRefPolicyResolveEnum>))]
    public V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayRouteTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayRouteTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayRouteTableIdRefPolicy? Policy { get; set; }
}

public enum V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayRouteTableIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayRouteTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayRouteTableIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayRouteTableIdSelectorPolicyResolutionEnum>))]
    public V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayRouteTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayRouteTableIdSelectorPolicyResolveEnum>))]
    public V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayRouteTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayRouteTableIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayRouteTableIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecForProvider
{
    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Boolean whether the Gateway Attachment should remove any current Route Table association before associating with the specified Route Table. Default value: false. This argument is intended for use with EC2 Transit Gateways shared into the current account, otherwise the transit_gateway_default_route_table_association argument of the aws_ec2_transit_gateway_vpc_attachment resource should be used.</summary>
    [JsonPropertyName("replaceExistingAssociation")]
    public bool? ReplaceExistingAssociation { get; set; }

    /// <summary>Identifier of EC2 Transit Gateway Attachment.</summary>
    [JsonPropertyName("transitGatewayAttachmentId")]
    public string? TransitGatewayAttachmentId { get; set; }

    /// <summary>Reference to a TransitGatewayVPCAttachment in ec2 to populate transitGatewayAttachmentId.</summary>
    [JsonPropertyName("transitGatewayAttachmentIdRef")]
    public V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayAttachmentIdRef? TransitGatewayAttachmentIdRef { get; set; }

    /// <summary>Selector for a TransitGatewayVPCAttachment in ec2 to populate transitGatewayAttachmentId.</summary>
    [JsonPropertyName("transitGatewayAttachmentIdSelector")]
    public V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayAttachmentIdSelector? TransitGatewayAttachmentIdSelector { get; set; }

    /// <summary>Identifier of EC2 Transit Gateway Route Table.</summary>
    [JsonPropertyName("transitGatewayRouteTableId")]
    public string? TransitGatewayRouteTableId { get; set; }

    /// <summary>Reference to a TransitGatewayRouteTable in ec2 to populate transitGatewayRouteTableId.</summary>
    [JsonPropertyName("transitGatewayRouteTableIdRef")]
    public V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayRouteTableIdRef? TransitGatewayRouteTableIdRef { get; set; }

    /// <summary>Selector for a TransitGatewayRouteTable in ec2 to populate transitGatewayRouteTableId.</summary>
    [JsonPropertyName("transitGatewayRouteTableIdSelector")]
    public V1beta1TransitGatewayRouteTableAssociationSpecForProviderTransitGatewayRouteTableIdSelector? TransitGatewayRouteTableIdSelector { get; set; }
}

public enum V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayAttachmentIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayAttachmentIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayAttachmentIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayAttachmentIdRefPolicyResolutionEnum>))]
    public V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayAttachmentIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayAttachmentIdRefPolicyResolveEnum>))]
    public V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayAttachmentIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayAttachmentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayAttachmentIdRefPolicy? Policy { get; set; }
}

public enum V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayAttachmentIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayAttachmentIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayAttachmentIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayAttachmentIdSelectorPolicyResolutionEnum>))]
    public V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayAttachmentIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayAttachmentIdSelectorPolicyResolveEnum>))]
    public V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayAttachmentIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayAttachmentIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayAttachmentIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayRouteTableIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayRouteTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayRouteTableIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayRouteTableIdRefPolicyResolutionEnum>))]
    public V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayRouteTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayRouteTableIdRefPolicyResolveEnum>))]
    public V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayRouteTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayRouteTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayRouteTableIdRefPolicy? Policy { get; set; }
}

public enum V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayRouteTableIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayRouteTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayRouteTableIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayRouteTableIdSelectorPolicyResolutionEnum>))]
    public V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayRouteTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayRouteTableIdSelectorPolicyResolveEnum>))]
    public V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayRouteTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayRouteTableIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayRouteTableIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecInitProvider
{
    /// <summary>Boolean whether the Gateway Attachment should remove any current Route Table association before associating with the specified Route Table. Default value: false. This argument is intended for use with EC2 Transit Gateways shared into the current account, otherwise the transit_gateway_default_route_table_association argument of the aws_ec2_transit_gateway_vpc_attachment resource should be used.</summary>
    [JsonPropertyName("replaceExistingAssociation")]
    public bool? ReplaceExistingAssociation { get; set; }

    /// <summary>Identifier of EC2 Transit Gateway Attachment.</summary>
    [JsonPropertyName("transitGatewayAttachmentId")]
    public string? TransitGatewayAttachmentId { get; set; }

    /// <summary>Reference to a TransitGatewayVPCAttachment in ec2 to populate transitGatewayAttachmentId.</summary>
    [JsonPropertyName("transitGatewayAttachmentIdRef")]
    public V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayAttachmentIdRef? TransitGatewayAttachmentIdRef { get; set; }

    /// <summary>Selector for a TransitGatewayVPCAttachment in ec2 to populate transitGatewayAttachmentId.</summary>
    [JsonPropertyName("transitGatewayAttachmentIdSelector")]
    public V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayAttachmentIdSelector? TransitGatewayAttachmentIdSelector { get; set; }

    /// <summary>Identifier of EC2 Transit Gateway Route Table.</summary>
    [JsonPropertyName("transitGatewayRouteTableId")]
    public string? TransitGatewayRouteTableId { get; set; }

    /// <summary>Reference to a TransitGatewayRouteTable in ec2 to populate transitGatewayRouteTableId.</summary>
    [JsonPropertyName("transitGatewayRouteTableIdRef")]
    public V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayRouteTableIdRef? TransitGatewayRouteTableIdRef { get; set; }

    /// <summary>Selector for a TransitGatewayRouteTable in ec2 to populate transitGatewayRouteTableId.</summary>
    [JsonPropertyName("transitGatewayRouteTableIdSelector")]
    public V1beta1TransitGatewayRouteTableAssociationSpecInitProviderTransitGatewayRouteTableIdSelector? TransitGatewayRouteTableIdSelector { get; set; }
}

public enum V1beta1TransitGatewayRouteTableAssociationSpecManagementPoliciesEnum
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

public enum V1beta1TransitGatewayRouteTableAssociationSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayRouteTableAssociationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayRouteTableAssociationSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1TransitGatewayRouteTableAssociationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayRouteTableAssociationSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1TransitGatewayRouteTableAssociationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayRouteTableAssociationSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1TransitGatewayRouteTableAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransitGatewayRouteTableAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayRouteTableAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1TransitGatewayRouteTableAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayRouteTableAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1TransitGatewayRouteTableAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayRouteTableAssociationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1TransitGatewayRouteTableAssociationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1TransitGatewayRouteTableAssociationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1TransitGatewayRouteTableAssociationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1TransitGatewayRouteTableAssociationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransitGatewayRouteTableAssociationSpecDeletionPolicyEnum>))]
    public V1beta1TransitGatewayRouteTableAssociationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TransitGatewayRouteTableAssociationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TransitGatewayRouteTableAssociationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1TransitGatewayRouteTableAssociationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TransitGatewayRouteTableAssociationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1TransitGatewayRouteTableAssociationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TransitGatewayRouteTableAssociationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1TransitGatewayRouteTableAssociationStatusAtProvider
{
    /// <summary>EC2 Transit Gateway Route Table identifier combined with EC2 Transit Gateway Attachment identifier</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Boolean whether the Gateway Attachment should remove any current Route Table association before associating with the specified Route Table. Default value: false. This argument is intended for use with EC2 Transit Gateways shared into the current account, otherwise the transit_gateway_default_route_table_association argument of the aws_ec2_transit_gateway_vpc_attachment resource should be used.</summary>
    [JsonPropertyName("replaceExistingAssociation")]
    public bool? ReplaceExistingAssociation { get; set; }

    /// <summary>Identifier of the resource</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>Type of the resource</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>Identifier of EC2 Transit Gateway Attachment.</summary>
    [JsonPropertyName("transitGatewayAttachmentId")]
    public string? TransitGatewayAttachmentId { get; set; }

    /// <summary>Identifier of EC2 Transit Gateway Route Table.</summary>
    [JsonPropertyName("transitGatewayRouteTableId")]
    public string? TransitGatewayRouteTableId { get; set; }
}

public partial class V1beta1TransitGatewayRouteTableAssociationStatusConditions
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

public partial class V1beta1TransitGatewayRouteTableAssociationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TransitGatewayRouteTableAssociationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TransitGatewayRouteTableAssociationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TransitGatewayRouteTableAssociation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TransitGatewayRouteTableAssociationSpec>, IStatus<V1beta1TransitGatewayRouteTableAssociationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TransitGatewayRouteTableAssociation";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "transitgatewayroutetableassociations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TransitGatewayRouteTableAssociationSpec defines the desired state of TransitGatewayRouteTableAssociation</summary>
    [JsonPropertyName("spec")]
    public V1beta1TransitGatewayRouteTableAssociationSpec Spec { get; set; }

    /// <summary>TransitGatewayRouteTableAssociationStatus defines the observed state of TransitGatewayRouteTableAssociation.</summary>
    [JsonPropertyName("status")]
    public V1beta1TransitGatewayRouteTableAssociationStatus? Status { get; set; }
}