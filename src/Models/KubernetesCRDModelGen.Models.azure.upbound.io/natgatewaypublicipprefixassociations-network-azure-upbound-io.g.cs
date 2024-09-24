using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderNatGatewayIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderNatGatewayIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderNatGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderNatGatewayIdRefPolicyResolutionEnum>))]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderNatGatewayIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderNatGatewayIdRefPolicyResolveEnum>))]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderNatGatewayIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a NATGateway in network to populate natGatewayId.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderNatGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderNatGatewayIdRefPolicy? Policy { get; set; }
}

public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderNatGatewayIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderNatGatewayIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderNatGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderNatGatewayIdSelectorPolicyResolutionEnum>))]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderNatGatewayIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderNatGatewayIdSelectorPolicyResolveEnum>))]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderNatGatewayIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a NATGateway in network to populate natGatewayId.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderNatGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderNatGatewayIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderPublicIpPrefixIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderPublicIpPrefixIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderPublicIpPrefixIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderPublicIpPrefixIdRefPolicyResolutionEnum>))]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderPublicIpPrefixIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderPublicIpPrefixIdRefPolicyResolveEnum>))]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderPublicIpPrefixIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a PublicIPPrefix in network to populate publicIpPrefixId.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderPublicIpPrefixIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderPublicIpPrefixIdRefPolicy? Policy { get; set; }
}

public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderPublicIpPrefixIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderPublicIpPrefixIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderPublicIpPrefixIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderPublicIpPrefixIdSelectorPolicyResolutionEnum>))]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderPublicIpPrefixIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderPublicIpPrefixIdSelectorPolicyResolveEnum>))]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderPublicIpPrefixIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a PublicIPPrefix in network to populate publicIpPrefixId.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderPublicIpPrefixIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderPublicIpPrefixIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecForProvider
{
    /// <summary>The ID of the NAT Gateway. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("natGatewayId")]
    public string? NatGatewayId { get; set; }

    /// <summary>Reference to a NATGateway in network to populate natGatewayId.</summary>
    [JsonPropertyName("natGatewayIdRef")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderNatGatewayIdRef? NatGatewayIdRef { get; set; }

    /// <summary>Selector for a NATGateway in network to populate natGatewayId.</summary>
    [JsonPropertyName("natGatewayIdSelector")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderNatGatewayIdSelector? NatGatewayIdSelector { get; set; }

    /// <summary>The ID of the Public IP Prefix which this NAT Gateway which should be connected to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpPrefixId")]
    public string? PublicIpPrefixId { get; set; }

    /// <summary>Reference to a PublicIPPrefix in network to populate publicIpPrefixId.</summary>
    [JsonPropertyName("publicIpPrefixIdRef")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderPublicIpPrefixIdRef? PublicIpPrefixIdRef { get; set; }

    /// <summary>Selector for a PublicIPPrefix in network to populate publicIpPrefixId.</summary>
    [JsonPropertyName("publicIpPrefixIdSelector")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecForProviderPublicIpPrefixIdSelector? PublicIpPrefixIdSelector { get; set; }
}

public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderNatGatewayIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderNatGatewayIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderNatGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderNatGatewayIdRefPolicyResolutionEnum>))]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderNatGatewayIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderNatGatewayIdRefPolicyResolveEnum>))]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderNatGatewayIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a NATGateway in network to populate natGatewayId.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderNatGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderNatGatewayIdRefPolicy? Policy { get; set; }
}

public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderNatGatewayIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderNatGatewayIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderNatGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderNatGatewayIdSelectorPolicyResolutionEnum>))]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderNatGatewayIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderNatGatewayIdSelectorPolicyResolveEnum>))]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderNatGatewayIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a NATGateway in network to populate natGatewayId.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderNatGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderNatGatewayIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderPublicIpPrefixIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderPublicIpPrefixIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderPublicIpPrefixIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderPublicIpPrefixIdRefPolicyResolutionEnum>))]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderPublicIpPrefixIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderPublicIpPrefixIdRefPolicyResolveEnum>))]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderPublicIpPrefixIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a PublicIPPrefix in network to populate publicIpPrefixId.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderPublicIpPrefixIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderPublicIpPrefixIdRefPolicy? Policy { get; set; }
}

public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderPublicIpPrefixIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderPublicIpPrefixIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderPublicIpPrefixIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderPublicIpPrefixIdSelectorPolicyResolutionEnum>))]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderPublicIpPrefixIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderPublicIpPrefixIdSelectorPolicyResolveEnum>))]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderPublicIpPrefixIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a PublicIPPrefix in network to populate publicIpPrefixId.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderPublicIpPrefixIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderPublicIpPrefixIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProvider
{
    /// <summary>The ID of the NAT Gateway. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("natGatewayId")]
    public string? NatGatewayId { get; set; }

    /// <summary>Reference to a NATGateway in network to populate natGatewayId.</summary>
    [JsonPropertyName("natGatewayIdRef")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderNatGatewayIdRef? NatGatewayIdRef { get; set; }

    /// <summary>Selector for a NATGateway in network to populate natGatewayId.</summary>
    [JsonPropertyName("natGatewayIdSelector")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderNatGatewayIdSelector? NatGatewayIdSelector { get; set; }

    /// <summary>The ID of the Public IP Prefix which this NAT Gateway which should be connected to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpPrefixId")]
    public string? PublicIpPrefixId { get; set; }

    /// <summary>Reference to a PublicIPPrefix in network to populate publicIpPrefixId.</summary>
    [JsonPropertyName("publicIpPrefixIdRef")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderPublicIpPrefixIdRef? PublicIpPrefixIdRef { get; set; }

    /// <summary>Selector for a PublicIPPrefix in network to populate publicIpPrefixId.</summary>
    [JsonPropertyName("publicIpPrefixIdSelector")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProviderPublicIpPrefixIdSelector? PublicIpPrefixIdSelector { get; set; }
}

public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecManagementPoliciesEnum
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

public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NATGatewayPublicIPPrefixAssociationSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NATGatewayPublicIPPrefixAssociationSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NATGatewayPublicIPPrefixAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NATGatewayPublicIPPrefixAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NATGatewayPublicIPPrefixAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>NATGatewayPublicIPPrefixAssociationSpec defines the desired state of NATGatewayPublicIPPrefixAssociation</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NATGatewayPublicIPPrefixAssociationSpecDeletionPolicyEnum>))]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1NATGatewayPublicIPPrefixAssociationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationStatusAtProvider
{
    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the NAT Gateway. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("natGatewayId")]
    public string? NatGatewayId { get; set; }

    /// <summary>The ID of the Public IP Prefix which this NAT Gateway which should be connected to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpPrefixId")]
    public string? PublicIpPrefixId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationStatusConditions
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

/// <summary>NATGatewayPublicIPPrefixAssociationStatus defines the observed state of NATGatewayPublicIPPrefixAssociation.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1NATGatewayPublicIPPrefixAssociationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NATGatewayPublicIPPrefixAssociationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>NATGatewayPublicIPPrefixAssociation is the Schema for the NATGatewayPublicIPPrefixAssociations API. Manages the association between a NAT Gateway and a Public IP Prefix.</summary>
public partial class V1beta1NATGatewayPublicIPPrefixAssociation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NATGatewayPublicIPPrefixAssociationSpec>, IStatus<V1beta1NATGatewayPublicIPPrefixAssociationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NATGatewayPublicIPPrefixAssociation";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "natgatewaypublicipprefixassociations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NATGatewayPublicIPPrefixAssociationSpec defines the desired state of NATGatewayPublicIPPrefixAssociation</summary>
    [JsonPropertyName("spec")]
    public V1beta1NATGatewayPublicIPPrefixAssociationSpec Spec { get; set; }

    /// <summary>NATGatewayPublicIPPrefixAssociationStatus defines the observed state of NATGatewayPublicIPPrefixAssociation.</summary>
    [JsonPropertyName("status")]
    public V1beta1NATGatewayPublicIPPrefixAssociationStatus? Status { get; set; }
}