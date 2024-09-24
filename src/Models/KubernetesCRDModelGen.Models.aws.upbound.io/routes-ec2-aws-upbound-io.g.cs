using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.upbound.io;
public enum V1beta2RouteSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta2RouteSpecForProviderDestinationPrefixListIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecForProviderDestinationPrefixListIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RouteSpecForProviderDestinationPrefixListIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderDestinationPrefixListIdRefPolicyResolutionEnum>))]
    public V1beta2RouteSpecForProviderDestinationPrefixListIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderDestinationPrefixListIdRefPolicyResolveEnum>))]
    public V1beta2RouteSpecForProviderDestinationPrefixListIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ManagedPrefixList in ec2 to populate destinationPrefixListId.</summary>
public partial class V1beta2RouteSpecForProviderDestinationPrefixListIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderDestinationPrefixListIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecForProviderDestinationPrefixListIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecForProviderDestinationPrefixListIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RouteSpecForProviderDestinationPrefixListIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderDestinationPrefixListIdSelectorPolicyResolutionEnum>))]
    public V1beta2RouteSpecForProviderDestinationPrefixListIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderDestinationPrefixListIdSelectorPolicyResolveEnum>))]
    public V1beta2RouteSpecForProviderDestinationPrefixListIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ManagedPrefixList in ec2 to populate destinationPrefixListId.</summary>
public partial class V1beta2RouteSpecForProviderDestinationPrefixListIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderDestinationPrefixListIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecForProviderEgressOnlyGatewayIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecForProviderEgressOnlyGatewayIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RouteSpecForProviderEgressOnlyGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderEgressOnlyGatewayIdRefPolicyResolutionEnum>))]
    public V1beta2RouteSpecForProviderEgressOnlyGatewayIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderEgressOnlyGatewayIdRefPolicyResolveEnum>))]
    public V1beta2RouteSpecForProviderEgressOnlyGatewayIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a EgressOnlyInternetGateway in ec2 to populate egressOnlyGatewayId.</summary>
public partial class V1beta2RouteSpecForProviderEgressOnlyGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderEgressOnlyGatewayIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecForProviderEgressOnlyGatewayIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecForProviderEgressOnlyGatewayIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RouteSpecForProviderEgressOnlyGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderEgressOnlyGatewayIdSelectorPolicyResolutionEnum>))]
    public V1beta2RouteSpecForProviderEgressOnlyGatewayIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderEgressOnlyGatewayIdSelectorPolicyResolveEnum>))]
    public V1beta2RouteSpecForProviderEgressOnlyGatewayIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a EgressOnlyInternetGateway in ec2 to populate egressOnlyGatewayId.</summary>
public partial class V1beta2RouteSpecForProviderEgressOnlyGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderEgressOnlyGatewayIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecForProviderGatewayIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecForProviderGatewayIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RouteSpecForProviderGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderGatewayIdRefPolicyResolutionEnum>))]
    public V1beta2RouteSpecForProviderGatewayIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderGatewayIdRefPolicyResolveEnum>))]
    public V1beta2RouteSpecForProviderGatewayIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InternetGateway in ec2 to populate gatewayId.</summary>
public partial class V1beta2RouteSpecForProviderGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderGatewayIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecForProviderGatewayIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecForProviderGatewayIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RouteSpecForProviderGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderGatewayIdSelectorPolicyResolutionEnum>))]
    public V1beta2RouteSpecForProviderGatewayIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderGatewayIdSelectorPolicyResolveEnum>))]
    public V1beta2RouteSpecForProviderGatewayIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InternetGateway in ec2 to populate gatewayId.</summary>
public partial class V1beta2RouteSpecForProviderGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderGatewayIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecForProviderNatGatewayIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecForProviderNatGatewayIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RouteSpecForProviderNatGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderNatGatewayIdRefPolicyResolutionEnum>))]
    public V1beta2RouteSpecForProviderNatGatewayIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderNatGatewayIdRefPolicyResolveEnum>))]
    public V1beta2RouteSpecForProviderNatGatewayIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a NATGateway in ec2 to populate natGatewayId.</summary>
public partial class V1beta2RouteSpecForProviderNatGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderNatGatewayIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecForProviderNatGatewayIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecForProviderNatGatewayIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RouteSpecForProviderNatGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderNatGatewayIdSelectorPolicyResolutionEnum>))]
    public V1beta2RouteSpecForProviderNatGatewayIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderNatGatewayIdSelectorPolicyResolveEnum>))]
    public V1beta2RouteSpecForProviderNatGatewayIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a NATGateway in ec2 to populate natGatewayId.</summary>
public partial class V1beta2RouteSpecForProviderNatGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderNatGatewayIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecForProviderNetworkInterfaceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecForProviderNetworkInterfaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RouteSpecForProviderNetworkInterfaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderNetworkInterfaceIdRefPolicyResolutionEnum>))]
    public V1beta2RouteSpecForProviderNetworkInterfaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderNetworkInterfaceIdRefPolicyResolveEnum>))]
    public V1beta2RouteSpecForProviderNetworkInterfaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
public partial class V1beta2RouteSpecForProviderNetworkInterfaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderNetworkInterfaceIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecForProviderNetworkInterfaceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecForProviderNetworkInterfaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RouteSpecForProviderNetworkInterfaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderNetworkInterfaceIdSelectorPolicyResolutionEnum>))]
    public V1beta2RouteSpecForProviderNetworkInterfaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderNetworkInterfaceIdSelectorPolicyResolveEnum>))]
    public V1beta2RouteSpecForProviderNetworkInterfaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
public partial class V1beta2RouteSpecForProviderNetworkInterfaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderNetworkInterfaceIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecForProviderRouteTableIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecForProviderRouteTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RouteSpecForProviderRouteTableIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderRouteTableIdRefPolicyResolutionEnum>))]
    public V1beta2RouteSpecForProviderRouteTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderRouteTableIdRefPolicyResolveEnum>))]
    public V1beta2RouteSpecForProviderRouteTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RouteTable in ec2 to populate routeTableId.</summary>
public partial class V1beta2RouteSpecForProviderRouteTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderRouteTableIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecForProviderRouteTableIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecForProviderRouteTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RouteSpecForProviderRouteTableIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderRouteTableIdSelectorPolicyResolutionEnum>))]
    public V1beta2RouteSpecForProviderRouteTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderRouteTableIdSelectorPolicyResolveEnum>))]
    public V1beta2RouteSpecForProviderRouteTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RouteTable in ec2 to populate routeTableId.</summary>
public partial class V1beta2RouteSpecForProviderRouteTableIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderRouteTableIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecForProviderTransitGatewayIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecForProviderTransitGatewayIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RouteSpecForProviderTransitGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderTransitGatewayIdRefPolicyResolutionEnum>))]
    public V1beta2RouteSpecForProviderTransitGatewayIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderTransitGatewayIdRefPolicyResolveEnum>))]
    public V1beta2RouteSpecForProviderTransitGatewayIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a TransitGateway in ec2 to populate transitGatewayId.</summary>
public partial class V1beta2RouteSpecForProviderTransitGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderTransitGatewayIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecForProviderTransitGatewayIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecForProviderTransitGatewayIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RouteSpecForProviderTransitGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderTransitGatewayIdSelectorPolicyResolutionEnum>))]
    public V1beta2RouteSpecForProviderTransitGatewayIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderTransitGatewayIdSelectorPolicyResolveEnum>))]
    public V1beta2RouteSpecForProviderTransitGatewayIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a TransitGateway in ec2 to populate transitGatewayId.</summary>
public partial class V1beta2RouteSpecForProviderTransitGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderTransitGatewayIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecForProviderVpcEndpointIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecForProviderVpcEndpointIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RouteSpecForProviderVpcEndpointIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderVpcEndpointIdRefPolicyResolutionEnum>))]
    public V1beta2RouteSpecForProviderVpcEndpointIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderVpcEndpointIdRefPolicyResolveEnum>))]
    public V1beta2RouteSpecForProviderVpcEndpointIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPCEndpoint in ec2 to populate vpcEndpointId.</summary>
public partial class V1beta2RouteSpecForProviderVpcEndpointIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderVpcEndpointIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecForProviderVpcEndpointIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecForProviderVpcEndpointIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RouteSpecForProviderVpcEndpointIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderVpcEndpointIdSelectorPolicyResolutionEnum>))]
    public V1beta2RouteSpecForProviderVpcEndpointIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderVpcEndpointIdSelectorPolicyResolveEnum>))]
    public V1beta2RouteSpecForProviderVpcEndpointIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPCEndpoint in ec2 to populate vpcEndpointId.</summary>
public partial class V1beta2RouteSpecForProviderVpcEndpointIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderVpcEndpointIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecForProviderVpcPeeringConnectionIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecForProviderVpcPeeringConnectionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RouteSpecForProviderVpcPeeringConnectionIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderVpcPeeringConnectionIdRefPolicyResolutionEnum>))]
    public V1beta2RouteSpecForProviderVpcPeeringConnectionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderVpcPeeringConnectionIdRefPolicyResolveEnum>))]
    public V1beta2RouteSpecForProviderVpcPeeringConnectionIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPCPeeringConnection in ec2 to populate vpcPeeringConnectionId.</summary>
public partial class V1beta2RouteSpecForProviderVpcPeeringConnectionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderVpcPeeringConnectionIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecForProviderVpcPeeringConnectionIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecForProviderVpcPeeringConnectionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RouteSpecForProviderVpcPeeringConnectionIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderVpcPeeringConnectionIdSelectorPolicyResolutionEnum>))]
    public V1beta2RouteSpecForProviderVpcPeeringConnectionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderVpcPeeringConnectionIdSelectorPolicyResolveEnum>))]
    public V1beta2RouteSpecForProviderVpcPeeringConnectionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPCPeeringConnection in ec2 to populate vpcPeeringConnectionId.</summary>
public partial class V1beta2RouteSpecForProviderVpcPeeringConnectionIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderVpcPeeringConnectionIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta2RouteSpecForProvider
{
    /// <summary>Identifier of a carrier gateway. This attribute can only be used when the VPC contains a subnet which is associated with a Wavelength Zone.</summary>
    [JsonPropertyName("carrierGatewayId")]
    public string? CarrierGatewayId { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a core network.</summary>
    [JsonPropertyName("coreNetworkArn")]
    public string? CoreNetworkArn { get; set; }

    /// <summary>The destination CIDR block.</summary>
    [JsonPropertyName("destinationCidrBlock")]
    public string? DestinationCidrBlock { get; set; }

    /// <summary>The destination IPv6 CIDR block.</summary>
    [JsonPropertyName("destinationIpv6CidrBlock")]
    public string? DestinationIpv6CidrBlock { get; set; }

    /// <summary>The ID of a managed prefix list destination.</summary>
    [JsonPropertyName("destinationPrefixListId")]
    public string? DestinationPrefixListId { get; set; }

    /// <summary>Reference to a ManagedPrefixList in ec2 to populate destinationPrefixListId.</summary>
    [JsonPropertyName("destinationPrefixListIdRef")]
    public V1beta2RouteSpecForProviderDestinationPrefixListIdRef? DestinationPrefixListIdRef { get; set; }

    /// <summary>Selector for a ManagedPrefixList in ec2 to populate destinationPrefixListId.</summary>
    [JsonPropertyName("destinationPrefixListIdSelector")]
    public V1beta2RouteSpecForProviderDestinationPrefixListIdSelector? DestinationPrefixListIdSelector { get; set; }

    /// <summary>Identifier of a VPC Egress Only Internet Gateway.</summary>
    [JsonPropertyName("egressOnlyGatewayId")]
    public string? EgressOnlyGatewayId { get; set; }

    /// <summary>Reference to a EgressOnlyInternetGateway in ec2 to populate egressOnlyGatewayId.</summary>
    [JsonPropertyName("egressOnlyGatewayIdRef")]
    public V1beta2RouteSpecForProviderEgressOnlyGatewayIdRef? EgressOnlyGatewayIdRef { get; set; }

    /// <summary>Selector for a EgressOnlyInternetGateway in ec2 to populate egressOnlyGatewayId.</summary>
    [JsonPropertyName("egressOnlyGatewayIdSelector")]
    public V1beta2RouteSpecForProviderEgressOnlyGatewayIdSelector? EgressOnlyGatewayIdSelector { get; set; }

    /// <summary>Identifier of a VPC internet gateway or a virtual private gateway. Specify local when updating a previously imported local route.</summary>
    [JsonPropertyName("gatewayId")]
    public string? GatewayId { get; set; }

    /// <summary>Reference to a InternetGateway in ec2 to populate gatewayId.</summary>
    [JsonPropertyName("gatewayIdRef")]
    public V1beta2RouteSpecForProviderGatewayIdRef? GatewayIdRef { get; set; }

    /// <summary>Selector for a InternetGateway in ec2 to populate gatewayId.</summary>
    [JsonPropertyName("gatewayIdSelector")]
    public V1beta2RouteSpecForProviderGatewayIdSelector? GatewayIdSelector { get; set; }

    /// <summary>Identifier of a Outpost local gateway.</summary>
    [JsonPropertyName("localGatewayId")]
    public string? LocalGatewayId { get; set; }

    /// <summary>Identifier of a VPC NAT gateway.</summary>
    [JsonPropertyName("natGatewayId")]
    public string? NatGatewayId { get; set; }

    /// <summary>Reference to a NATGateway in ec2 to populate natGatewayId.</summary>
    [JsonPropertyName("natGatewayIdRef")]
    public V1beta2RouteSpecForProviderNatGatewayIdRef? NatGatewayIdRef { get; set; }

    /// <summary>Selector for a NATGateway in ec2 to populate natGatewayId.</summary>
    [JsonPropertyName("natGatewayIdSelector")]
    public V1beta2RouteSpecForProviderNatGatewayIdSelector? NatGatewayIdSelector { get; set; }

    /// <summary>Identifier of an EC2 network interface.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    /// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdRef")]
    public V1beta2RouteSpecForProviderNetworkInterfaceIdRef? NetworkInterfaceIdRef { get; set; }

    /// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdSelector")]
    public V1beta2RouteSpecForProviderNetworkInterfaceIdSelector? NetworkInterfaceIdSelector { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The ID of the routing table.</summary>
    [JsonPropertyName("routeTableId")]
    public string? RouteTableId { get; set; }

    /// <summary>Reference to a RouteTable in ec2 to populate routeTableId.</summary>
    [JsonPropertyName("routeTableIdRef")]
    public V1beta2RouteSpecForProviderRouteTableIdRef? RouteTableIdRef { get; set; }

    /// <summary>Selector for a RouteTable in ec2 to populate routeTableId.</summary>
    [JsonPropertyName("routeTableIdSelector")]
    public V1beta2RouteSpecForProviderRouteTableIdSelector? RouteTableIdSelector { get; set; }

    /// <summary>Identifier of an EC2 Transit Gateway.</summary>
    [JsonPropertyName("transitGatewayId")]
    public string? TransitGatewayId { get; set; }

    /// <summary>Reference to a TransitGateway in ec2 to populate transitGatewayId.</summary>
    [JsonPropertyName("transitGatewayIdRef")]
    public V1beta2RouteSpecForProviderTransitGatewayIdRef? TransitGatewayIdRef { get; set; }

    /// <summary>Selector for a TransitGateway in ec2 to populate transitGatewayId.</summary>
    [JsonPropertyName("transitGatewayIdSelector")]
    public V1beta2RouteSpecForProviderTransitGatewayIdSelector? TransitGatewayIdSelector { get; set; }

    /// <summary>Identifier of a VPC Endpoint.</summary>
    [JsonPropertyName("vpcEndpointId")]
    public string? VpcEndpointId { get; set; }

    /// <summary>Reference to a VPCEndpoint in ec2 to populate vpcEndpointId.</summary>
    [JsonPropertyName("vpcEndpointIdRef")]
    public V1beta2RouteSpecForProviderVpcEndpointIdRef? VpcEndpointIdRef { get; set; }

    /// <summary>Selector for a VPCEndpoint in ec2 to populate vpcEndpointId.</summary>
    [JsonPropertyName("vpcEndpointIdSelector")]
    public V1beta2RouteSpecForProviderVpcEndpointIdSelector? VpcEndpointIdSelector { get; set; }

    /// <summary>Identifier of a VPC peering connection.</summary>
    [JsonPropertyName("vpcPeeringConnectionId")]
    public string? VpcPeeringConnectionId { get; set; }

    /// <summary>Reference to a VPCPeeringConnection in ec2 to populate vpcPeeringConnectionId.</summary>
    [JsonPropertyName("vpcPeeringConnectionIdRef")]
    public V1beta2RouteSpecForProviderVpcPeeringConnectionIdRef? VpcPeeringConnectionIdRef { get; set; }

    /// <summary>Selector for a VPCPeeringConnection in ec2 to populate vpcPeeringConnectionId.</summary>
    [JsonPropertyName("vpcPeeringConnectionIdSelector")]
    public V1beta2RouteSpecForProviderVpcPeeringConnectionIdSelector? VpcPeeringConnectionIdSelector { get; set; }
}

public enum V1beta2RouteSpecInitProviderDestinationPrefixListIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecInitProviderDestinationPrefixListIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RouteSpecInitProviderDestinationPrefixListIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderDestinationPrefixListIdRefPolicyResolutionEnum>))]
    public V1beta2RouteSpecInitProviderDestinationPrefixListIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderDestinationPrefixListIdRefPolicyResolveEnum>))]
    public V1beta2RouteSpecInitProviderDestinationPrefixListIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ManagedPrefixList in ec2 to populate destinationPrefixListId.</summary>
public partial class V1beta2RouteSpecInitProviderDestinationPrefixListIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderDestinationPrefixListIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecInitProviderDestinationPrefixListIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecInitProviderDestinationPrefixListIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RouteSpecInitProviderDestinationPrefixListIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderDestinationPrefixListIdSelectorPolicyResolutionEnum>))]
    public V1beta2RouteSpecInitProviderDestinationPrefixListIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderDestinationPrefixListIdSelectorPolicyResolveEnum>))]
    public V1beta2RouteSpecInitProviderDestinationPrefixListIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ManagedPrefixList in ec2 to populate destinationPrefixListId.</summary>
public partial class V1beta2RouteSpecInitProviderDestinationPrefixListIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderDestinationPrefixListIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecInitProviderEgressOnlyGatewayIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecInitProviderEgressOnlyGatewayIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RouteSpecInitProviderEgressOnlyGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderEgressOnlyGatewayIdRefPolicyResolutionEnum>))]
    public V1beta2RouteSpecInitProviderEgressOnlyGatewayIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderEgressOnlyGatewayIdRefPolicyResolveEnum>))]
    public V1beta2RouteSpecInitProviderEgressOnlyGatewayIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a EgressOnlyInternetGateway in ec2 to populate egressOnlyGatewayId.</summary>
public partial class V1beta2RouteSpecInitProviderEgressOnlyGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderEgressOnlyGatewayIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecInitProviderEgressOnlyGatewayIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecInitProviderEgressOnlyGatewayIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RouteSpecInitProviderEgressOnlyGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderEgressOnlyGatewayIdSelectorPolicyResolutionEnum>))]
    public V1beta2RouteSpecInitProviderEgressOnlyGatewayIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderEgressOnlyGatewayIdSelectorPolicyResolveEnum>))]
    public V1beta2RouteSpecInitProviderEgressOnlyGatewayIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a EgressOnlyInternetGateway in ec2 to populate egressOnlyGatewayId.</summary>
public partial class V1beta2RouteSpecInitProviderEgressOnlyGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderEgressOnlyGatewayIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecInitProviderGatewayIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecInitProviderGatewayIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RouteSpecInitProviderGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderGatewayIdRefPolicyResolutionEnum>))]
    public V1beta2RouteSpecInitProviderGatewayIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderGatewayIdRefPolicyResolveEnum>))]
    public V1beta2RouteSpecInitProviderGatewayIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InternetGateway in ec2 to populate gatewayId.</summary>
public partial class V1beta2RouteSpecInitProviderGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderGatewayIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecInitProviderGatewayIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecInitProviderGatewayIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RouteSpecInitProviderGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderGatewayIdSelectorPolicyResolutionEnum>))]
    public V1beta2RouteSpecInitProviderGatewayIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderGatewayIdSelectorPolicyResolveEnum>))]
    public V1beta2RouteSpecInitProviderGatewayIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InternetGateway in ec2 to populate gatewayId.</summary>
public partial class V1beta2RouteSpecInitProviderGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderGatewayIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecInitProviderNatGatewayIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecInitProviderNatGatewayIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RouteSpecInitProviderNatGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderNatGatewayIdRefPolicyResolutionEnum>))]
    public V1beta2RouteSpecInitProviderNatGatewayIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderNatGatewayIdRefPolicyResolveEnum>))]
    public V1beta2RouteSpecInitProviderNatGatewayIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a NATGateway in ec2 to populate natGatewayId.</summary>
public partial class V1beta2RouteSpecInitProviderNatGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderNatGatewayIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecInitProviderNatGatewayIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecInitProviderNatGatewayIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RouteSpecInitProviderNatGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderNatGatewayIdSelectorPolicyResolutionEnum>))]
    public V1beta2RouteSpecInitProviderNatGatewayIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderNatGatewayIdSelectorPolicyResolveEnum>))]
    public V1beta2RouteSpecInitProviderNatGatewayIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a NATGateway in ec2 to populate natGatewayId.</summary>
public partial class V1beta2RouteSpecInitProviderNatGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderNatGatewayIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecInitProviderNetworkInterfaceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecInitProviderNetworkInterfaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RouteSpecInitProviderNetworkInterfaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderNetworkInterfaceIdRefPolicyResolutionEnum>))]
    public V1beta2RouteSpecInitProviderNetworkInterfaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderNetworkInterfaceIdRefPolicyResolveEnum>))]
    public V1beta2RouteSpecInitProviderNetworkInterfaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
public partial class V1beta2RouteSpecInitProviderNetworkInterfaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderNetworkInterfaceIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecInitProviderNetworkInterfaceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecInitProviderNetworkInterfaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RouteSpecInitProviderNetworkInterfaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderNetworkInterfaceIdSelectorPolicyResolutionEnum>))]
    public V1beta2RouteSpecInitProviderNetworkInterfaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderNetworkInterfaceIdSelectorPolicyResolveEnum>))]
    public V1beta2RouteSpecInitProviderNetworkInterfaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
public partial class V1beta2RouteSpecInitProviderNetworkInterfaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderNetworkInterfaceIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecInitProviderRouteTableIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecInitProviderRouteTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RouteSpecInitProviderRouteTableIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderRouteTableIdRefPolicyResolutionEnum>))]
    public V1beta2RouteSpecInitProviderRouteTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderRouteTableIdRefPolicyResolveEnum>))]
    public V1beta2RouteSpecInitProviderRouteTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RouteTable in ec2 to populate routeTableId.</summary>
public partial class V1beta2RouteSpecInitProviderRouteTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderRouteTableIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecInitProviderRouteTableIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecInitProviderRouteTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RouteSpecInitProviderRouteTableIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderRouteTableIdSelectorPolicyResolutionEnum>))]
    public V1beta2RouteSpecInitProviderRouteTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderRouteTableIdSelectorPolicyResolveEnum>))]
    public V1beta2RouteSpecInitProviderRouteTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RouteTable in ec2 to populate routeTableId.</summary>
public partial class V1beta2RouteSpecInitProviderRouteTableIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderRouteTableIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecInitProviderTransitGatewayIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecInitProviderTransitGatewayIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RouteSpecInitProviderTransitGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderTransitGatewayIdRefPolicyResolutionEnum>))]
    public V1beta2RouteSpecInitProviderTransitGatewayIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderTransitGatewayIdRefPolicyResolveEnum>))]
    public V1beta2RouteSpecInitProviderTransitGatewayIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a TransitGateway in ec2 to populate transitGatewayId.</summary>
public partial class V1beta2RouteSpecInitProviderTransitGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderTransitGatewayIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecInitProviderTransitGatewayIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecInitProviderTransitGatewayIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RouteSpecInitProviderTransitGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderTransitGatewayIdSelectorPolicyResolutionEnum>))]
    public V1beta2RouteSpecInitProviderTransitGatewayIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderTransitGatewayIdSelectorPolicyResolveEnum>))]
    public V1beta2RouteSpecInitProviderTransitGatewayIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a TransitGateway in ec2 to populate transitGatewayId.</summary>
public partial class V1beta2RouteSpecInitProviderTransitGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderTransitGatewayIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecInitProviderVpcEndpointIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecInitProviderVpcEndpointIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RouteSpecInitProviderVpcEndpointIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderVpcEndpointIdRefPolicyResolutionEnum>))]
    public V1beta2RouteSpecInitProviderVpcEndpointIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderVpcEndpointIdRefPolicyResolveEnum>))]
    public V1beta2RouteSpecInitProviderVpcEndpointIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPCEndpoint in ec2 to populate vpcEndpointId.</summary>
public partial class V1beta2RouteSpecInitProviderVpcEndpointIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderVpcEndpointIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecInitProviderVpcEndpointIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecInitProviderVpcEndpointIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RouteSpecInitProviderVpcEndpointIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderVpcEndpointIdSelectorPolicyResolutionEnum>))]
    public V1beta2RouteSpecInitProviderVpcEndpointIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderVpcEndpointIdSelectorPolicyResolveEnum>))]
    public V1beta2RouteSpecInitProviderVpcEndpointIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPCEndpoint in ec2 to populate vpcEndpointId.</summary>
public partial class V1beta2RouteSpecInitProviderVpcEndpointIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderVpcEndpointIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecInitProviderVpcPeeringConnectionIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecInitProviderVpcPeeringConnectionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RouteSpecInitProviderVpcPeeringConnectionIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderVpcPeeringConnectionIdRefPolicyResolutionEnum>))]
    public V1beta2RouteSpecInitProviderVpcPeeringConnectionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderVpcPeeringConnectionIdRefPolicyResolveEnum>))]
    public V1beta2RouteSpecInitProviderVpcPeeringConnectionIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPCPeeringConnection in ec2 to populate vpcPeeringConnectionId.</summary>
public partial class V1beta2RouteSpecInitProviderVpcPeeringConnectionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderVpcPeeringConnectionIdRefPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecInitProviderVpcPeeringConnectionIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecInitProviderVpcPeeringConnectionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta2RouteSpecInitProviderVpcPeeringConnectionIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderVpcPeeringConnectionIdSelectorPolicyResolutionEnum>))]
    public V1beta2RouteSpecInitProviderVpcPeeringConnectionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderVpcPeeringConnectionIdSelectorPolicyResolveEnum>))]
    public V1beta2RouteSpecInitProviderVpcPeeringConnectionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPCPeeringConnection in ec2 to populate vpcPeeringConnectionId.</summary>
public partial class V1beta2RouteSpecInitProviderVpcPeeringConnectionIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderVpcPeeringConnectionIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta2RouteSpecInitProvider
{
    /// <summary>Identifier of a carrier gateway. This attribute can only be used when the VPC contains a subnet which is associated with a Wavelength Zone.</summary>
    [JsonPropertyName("carrierGatewayId")]
    public string? CarrierGatewayId { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a core network.</summary>
    [JsonPropertyName("coreNetworkArn")]
    public string? CoreNetworkArn { get; set; }

    /// <summary>The destination CIDR block.</summary>
    [JsonPropertyName("destinationCidrBlock")]
    public string? DestinationCidrBlock { get; set; }

    /// <summary>The destination IPv6 CIDR block.</summary>
    [JsonPropertyName("destinationIpv6CidrBlock")]
    public string? DestinationIpv6CidrBlock { get; set; }

    /// <summary>The ID of a managed prefix list destination.</summary>
    [JsonPropertyName("destinationPrefixListId")]
    public string? DestinationPrefixListId { get; set; }

    /// <summary>Reference to a ManagedPrefixList in ec2 to populate destinationPrefixListId.</summary>
    [JsonPropertyName("destinationPrefixListIdRef")]
    public V1beta2RouteSpecInitProviderDestinationPrefixListIdRef? DestinationPrefixListIdRef { get; set; }

    /// <summary>Selector for a ManagedPrefixList in ec2 to populate destinationPrefixListId.</summary>
    [JsonPropertyName("destinationPrefixListIdSelector")]
    public V1beta2RouteSpecInitProviderDestinationPrefixListIdSelector? DestinationPrefixListIdSelector { get; set; }

    /// <summary>Identifier of a VPC Egress Only Internet Gateway.</summary>
    [JsonPropertyName("egressOnlyGatewayId")]
    public string? EgressOnlyGatewayId { get; set; }

    /// <summary>Reference to a EgressOnlyInternetGateway in ec2 to populate egressOnlyGatewayId.</summary>
    [JsonPropertyName("egressOnlyGatewayIdRef")]
    public V1beta2RouteSpecInitProviderEgressOnlyGatewayIdRef? EgressOnlyGatewayIdRef { get; set; }

    /// <summary>Selector for a EgressOnlyInternetGateway in ec2 to populate egressOnlyGatewayId.</summary>
    [JsonPropertyName("egressOnlyGatewayIdSelector")]
    public V1beta2RouteSpecInitProviderEgressOnlyGatewayIdSelector? EgressOnlyGatewayIdSelector { get; set; }

    /// <summary>Identifier of a VPC internet gateway or a virtual private gateway. Specify local when updating a previously imported local route.</summary>
    [JsonPropertyName("gatewayId")]
    public string? GatewayId { get; set; }

    /// <summary>Reference to a InternetGateway in ec2 to populate gatewayId.</summary>
    [JsonPropertyName("gatewayIdRef")]
    public V1beta2RouteSpecInitProviderGatewayIdRef? GatewayIdRef { get; set; }

    /// <summary>Selector for a InternetGateway in ec2 to populate gatewayId.</summary>
    [JsonPropertyName("gatewayIdSelector")]
    public V1beta2RouteSpecInitProviderGatewayIdSelector? GatewayIdSelector { get; set; }

    /// <summary>Identifier of a Outpost local gateway.</summary>
    [JsonPropertyName("localGatewayId")]
    public string? LocalGatewayId { get; set; }

    /// <summary>Identifier of a VPC NAT gateway.</summary>
    [JsonPropertyName("natGatewayId")]
    public string? NatGatewayId { get; set; }

    /// <summary>Reference to a NATGateway in ec2 to populate natGatewayId.</summary>
    [JsonPropertyName("natGatewayIdRef")]
    public V1beta2RouteSpecInitProviderNatGatewayIdRef? NatGatewayIdRef { get; set; }

    /// <summary>Selector for a NATGateway in ec2 to populate natGatewayId.</summary>
    [JsonPropertyName("natGatewayIdSelector")]
    public V1beta2RouteSpecInitProviderNatGatewayIdSelector? NatGatewayIdSelector { get; set; }

    /// <summary>Identifier of an EC2 network interface.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    /// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdRef")]
    public V1beta2RouteSpecInitProviderNetworkInterfaceIdRef? NetworkInterfaceIdRef { get; set; }

    /// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdSelector")]
    public V1beta2RouteSpecInitProviderNetworkInterfaceIdSelector? NetworkInterfaceIdSelector { get; set; }

    /// <summary>The ID of the routing table.</summary>
    [JsonPropertyName("routeTableId")]
    public string? RouteTableId { get; set; }

    /// <summary>Reference to a RouteTable in ec2 to populate routeTableId.</summary>
    [JsonPropertyName("routeTableIdRef")]
    public V1beta2RouteSpecInitProviderRouteTableIdRef? RouteTableIdRef { get; set; }

    /// <summary>Selector for a RouteTable in ec2 to populate routeTableId.</summary>
    [JsonPropertyName("routeTableIdSelector")]
    public V1beta2RouteSpecInitProviderRouteTableIdSelector? RouteTableIdSelector { get; set; }

    /// <summary>Identifier of an EC2 Transit Gateway.</summary>
    [JsonPropertyName("transitGatewayId")]
    public string? TransitGatewayId { get; set; }

    /// <summary>Reference to a TransitGateway in ec2 to populate transitGatewayId.</summary>
    [JsonPropertyName("transitGatewayIdRef")]
    public V1beta2RouteSpecInitProviderTransitGatewayIdRef? TransitGatewayIdRef { get; set; }

    /// <summary>Selector for a TransitGateway in ec2 to populate transitGatewayId.</summary>
    [JsonPropertyName("transitGatewayIdSelector")]
    public V1beta2RouteSpecInitProviderTransitGatewayIdSelector? TransitGatewayIdSelector { get; set; }

    /// <summary>Identifier of a VPC Endpoint.</summary>
    [JsonPropertyName("vpcEndpointId")]
    public string? VpcEndpointId { get; set; }

    /// <summary>Reference to a VPCEndpoint in ec2 to populate vpcEndpointId.</summary>
    [JsonPropertyName("vpcEndpointIdRef")]
    public V1beta2RouteSpecInitProviderVpcEndpointIdRef? VpcEndpointIdRef { get; set; }

    /// <summary>Selector for a VPCEndpoint in ec2 to populate vpcEndpointId.</summary>
    [JsonPropertyName("vpcEndpointIdSelector")]
    public V1beta2RouteSpecInitProviderVpcEndpointIdSelector? VpcEndpointIdSelector { get; set; }

    /// <summary>Identifier of a VPC peering connection.</summary>
    [JsonPropertyName("vpcPeeringConnectionId")]
    public string? VpcPeeringConnectionId { get; set; }

    /// <summary>Reference to a VPCPeeringConnection in ec2 to populate vpcPeeringConnectionId.</summary>
    [JsonPropertyName("vpcPeeringConnectionIdRef")]
    public V1beta2RouteSpecInitProviderVpcPeeringConnectionIdRef? VpcPeeringConnectionIdRef { get; set; }

    /// <summary>Selector for a VPCPeeringConnection in ec2 to populate vpcPeeringConnectionId.</summary>
    [JsonPropertyName("vpcPeeringConnectionIdSelector")]
    public V1beta2RouteSpecInitProviderVpcPeeringConnectionIdSelector? VpcPeeringConnectionIdSelector { get; set; }
}

public enum V1beta2RouteSpecManagementPoliciesEnum
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

public enum V1beta2RouteSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RouteSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta2RouteSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta2RouteSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta2RouteSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta2RouteSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta2RouteSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta2RouteSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta2RouteSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta2RouteSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta2RouteSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta2RouteSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta2RouteSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta2RouteSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta2RouteSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta2RouteSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>RouteSpec defines the desired state of Route</summary>
public partial class V1beta2RouteSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecDeletionPolicyEnum>))]
    public V1beta2RouteSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta2RouteSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta2RouteSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta2RouteSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2RouteSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta2RouteSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2RouteSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta2RouteStatusAtProvider
{
    /// <summary>Identifier of a carrier gateway. This attribute can only be used when the VPC contains a subnet which is associated with a Wavelength Zone.</summary>
    [JsonPropertyName("carrierGatewayId")]
    public string? CarrierGatewayId { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a core network.</summary>
    [JsonPropertyName("coreNetworkArn")]
    public string? CoreNetworkArn { get; set; }

    /// <summary>The destination CIDR block.</summary>
    [JsonPropertyName("destinationCidrBlock")]
    public string? DestinationCidrBlock { get; set; }

    /// <summary>The destination IPv6 CIDR block.</summary>
    [JsonPropertyName("destinationIpv6CidrBlock")]
    public string? DestinationIpv6CidrBlock { get; set; }

    /// <summary>The ID of a managed prefix list destination.</summary>
    [JsonPropertyName("destinationPrefixListId")]
    public string? DestinationPrefixListId { get; set; }

    /// <summary>Identifier of a VPC Egress Only Internet Gateway.</summary>
    [JsonPropertyName("egressOnlyGatewayId")]
    public string? EgressOnlyGatewayId { get; set; }

    /// <summary>Identifier of a VPC internet gateway or a virtual private gateway. Specify local when updating a previously imported local route.</summary>
    [JsonPropertyName("gatewayId")]
    public string? GatewayId { get; set; }

    /// <summary>Route identifier computed from the routing table identifier and route destination.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identifier of an EC2 instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>The AWS account ID of the owner of the EC2 instance.</summary>
    [JsonPropertyName("instanceOwnerId")]
    public string? InstanceOwnerId { get; set; }

    /// <summary>Identifier of a Outpost local gateway.</summary>
    [JsonPropertyName("localGatewayId")]
    public string? LocalGatewayId { get; set; }

    /// <summary>Identifier of a VPC NAT gateway.</summary>
    [JsonPropertyName("natGatewayId")]
    public string? NatGatewayId { get; set; }

    /// <summary>Identifier of an EC2 network interface.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    /// <summary>How the route was created - CreateRouteTable, CreateRoute or EnableVgwRoutePropagation.</summary>
    [JsonPropertyName("origin")]
    public string? Origin { get; set; }

    /// <summary>The ID of the routing table.</summary>
    [JsonPropertyName("routeTableId")]
    public string? RouteTableId { get; set; }

    /// <summary>The state of the route - active or blackhole.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Identifier of an EC2 Transit Gateway.</summary>
    [JsonPropertyName("transitGatewayId")]
    public string? TransitGatewayId { get; set; }

    /// <summary>Identifier of a VPC Endpoint.</summary>
    [JsonPropertyName("vpcEndpointId")]
    public string? VpcEndpointId { get; set; }

    /// <summary>Identifier of a VPC peering connection.</summary>
    [JsonPropertyName("vpcPeeringConnectionId")]
    public string? VpcPeeringConnectionId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta2RouteStatusConditions
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

/// <summary>RouteStatus defines the observed state of Route.</summary>
public partial class V1beta2RouteStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta2RouteStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2RouteStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Route is the Schema for the Routes API. Provides a resource to create a routing entry in a VPC routing table.</summary>
public partial class V1beta2Route : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2RouteSpec>, IStatus<V1beta2RouteStatus>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Route";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "routes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RouteSpec defines the desired state of Route</summary>
    [JsonPropertyName("spec")]
    public V1beta2RouteSpec Spec { get; set; }

    /// <summary>RouteStatus defines the observed state of Route.</summary>
    [JsonPropertyName("status")]
    public V1beta2RouteStatus? Status { get; set; }
}