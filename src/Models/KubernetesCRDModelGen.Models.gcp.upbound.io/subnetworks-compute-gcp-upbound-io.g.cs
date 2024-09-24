using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
public enum V1beta1SubnetworkSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1SubnetworkSpecForProviderLogConfig
{
    /// <summary>Can only be specified if VPC flow logging for this subnetwork is enabled. Toggles the aggregation interval for collecting flow logs. Increasing the interval time will reduce the amount of generated flow logs for long lasting connections. Default is an interval of 5 seconds per connection. Default value is INTERVAL_5_SEC. Possible values are: INTERVAL_5_SEC, INTERVAL_30_SEC, INTERVAL_1_MIN, INTERVAL_5_MIN, INTERVAL_10_MIN, INTERVAL_15_MIN.</summary>
    [JsonPropertyName("aggregationInterval")]
    public string? AggregationInterval { get; set; }

    /// <summary>Export filter used to define which VPC flow logs should be logged, as as CEL expression. See https://cloud.google.com/vpc/docs/flow-logs#filtering for details on how to format this field. The default value is 'true', which evaluates to include everything.</summary>
    [JsonPropertyName("filterExpr")]
    public string? FilterExpr { get; set; }

    /// <summary>Can only be specified if VPC flow logging for this subnetwork is enabled. The value of the field must be in [0, 1]. Set the sampling rate of VPC flow logs within the subnetwork where 1.0 means all collected logs are reported and 0.0 means no logs are reported. Default is 0.5 which means half of all collected logs are reported.</summary>
    [JsonPropertyName("flowSampling")]
    public double? FlowSampling { get; set; }

    /// <summary>Can only be specified if VPC flow logging for this subnetwork is enabled. Configures whether metadata fields should be added to the reported VPC flow logs. Default value is INCLUDE_ALL_METADATA. Possible values are: EXCLUDE_ALL_METADATA, INCLUDE_ALL_METADATA, CUSTOM_METADATA.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>List of metadata fields that should be added to reported logs. Can only be specified if VPC flow logs for this subnetwork is enabled and "metadata" is set to CUSTOM_METADATA.</summary>
    [JsonPropertyName("metadataFields")]
    public IList<string>? MetadataFields { get; set; }
}

public enum V1beta1SubnetworkSpecForProviderNetworkRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SubnetworkSpecForProviderNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SubnetworkSpecForProviderNetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubnetworkSpecForProviderNetworkRefPolicyResolutionEnum>))]
    public V1beta1SubnetworkSpecForProviderNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubnetworkSpecForProviderNetworkRefPolicyResolveEnum>))]
    public V1beta1SubnetworkSpecForProviderNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SubnetworkSpecForProviderNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubnetworkSpecForProviderNetworkRefPolicy? Policy { get; set; }
}

public enum V1beta1SubnetworkSpecForProviderNetworkSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SubnetworkSpecForProviderNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SubnetworkSpecForProviderNetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubnetworkSpecForProviderNetworkSelectorPolicyResolutionEnum>))]
    public V1beta1SubnetworkSpecForProviderNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubnetworkSpecForProviderNetworkSelectorPolicyResolveEnum>))]
    public V1beta1SubnetworkSpecForProviderNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SubnetworkSpecForProviderNetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubnetworkSpecForProviderNetworkSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1SubnetworkSpecForProviderSecondaryIpRange
{
    /// <summary>The range of IP addresses belonging to this subnetwork secondary range. Provide this property when you create the subnetwork. Ranges must be unique and non-overlapping with all primary and secondary IP ranges within a network. Only IPv4 is supported.</summary>
    [JsonPropertyName("ipCidrRange")]
    public string? IpCidrRange { get; set; }

    /// <summary>The name associated with this subnetwork secondary range, used when adding an alias IP range to a VM instance. The name must be 1-63 characters long, and comply with RFC1035. The name must be unique within the subnetwork.</summary>
    [JsonPropertyName("rangeName")]
    public string? RangeName { get; set; }
}

public partial class V1beta1SubnetworkSpecForProvider
{
    /// <summary>An optional description of this resource. Provide this property when you create the resource. This field can be set only at resource creation time.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The range of external IPv6 addresses that are owned by this subnetwork.</summary>
    [JsonPropertyName("externalIpv6Prefix")]
    public string? ExternalIpv6Prefix { get; set; }

    /// <summary>The range of internal addresses that are owned by this subnetwork. Provide this property when you create the subnetwork. For example, 10.0.0.0/8 or 192.168.0.0/16. Ranges must be unique and non-overlapping within a network. Only IPv4 is supported.</summary>
    [JsonPropertyName("ipCidrRange")]
    public string? IpCidrRange { get; set; }

    /// <summary>The access type of IPv6 address this subnet holds. It's immutable and can only be specified during creation or the first time the subnet is updated into IPV4_IPV6 dual stack. If the ipv6_type is EXTERNAL then this subnet cannot enable direct path. Possible values are: EXTERNAL, INTERNAL.</summary>
    [JsonPropertyName("ipv6AccessType")]
    public string? Ipv6AccessType { get; set; }

    /// <summary>This field denotes the VPC flow logging options for this subnetwork. If logging is enabled, logs are exported to Cloud Logging. Flow logging isn't supported if the subnet purpose field is set to subnetwork is REGIONAL_MANAGED_PROXY or GLOBAL_MANAGED_PROXY. Structure is documented below.</summary>
    [JsonPropertyName("logConfig")]
    public IList<V1beta1SubnetworkSpecForProviderLogConfig>? LogConfig { get; set; }

    /// <summary>The network this subnet belongs to. Only networks that are in the distributed mode can have subnetworks.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1SubnetworkSpecForProviderNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1SubnetworkSpecForProviderNetworkSelector? NetworkSelector { get; set; }

    /// <summary>When enabled, VMs in this subnetwork without external IP addresses can access Google APIs and services by using Private Google Access.</summary>
    [JsonPropertyName("privateIpGoogleAccess")]
    public bool? PrivateIpGoogleAccess { get; set; }

    /// <summary>The private IPv6 google access type for the VMs in this subnet.</summary>
    [JsonPropertyName("privateIpv6GoogleAccess")]
    public string? PrivateIpv6GoogleAccess { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The purpose of the resource. This field can be either PRIVATE_RFC_1918, REGIONAL_MANAGED_PROXY, GLOBAL_MANAGED_PROXY, PRIVATE_SERVICE_CONNECT or PRIVATE_NAT(Beta). A subnet with purpose set to REGIONAL_MANAGED_PROXY is a user-created subnetwork that is reserved for regional Envoy-based load balancers. A subnetwork in a given region with purpose set to GLOBAL_MANAGED_PROXY is a proxy-only subnet and is shared between all the cross-regional Envoy-based load balancers. A subnetwork with purpose set to PRIVATE_SERVICE_CONNECT reserves the subnet for hosting a Private Service Connect published service. A subnetwork with purpose set to PRIVATE_NAT is used as source range for Private NAT gateways. Note that REGIONAL_MANAGED_PROXY is the preferred setting for all regional Envoy load balancers. If unspecified, the purpose defaults to PRIVATE_RFC_1918.</summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>The GCP region for this subnetwork.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The role of subnetwork. Currently, this field is only used when purpose is REGIONAL_MANAGED_PROXY. The value can be set to ACTIVE or BACKUP. An ACTIVE subnetwork is one that is currently being used for Envoy-based load balancers in a region. A BACKUP subnetwork is one that is ready to be promoted to ACTIVE or is currently draining. Possible values are: ACTIVE, BACKUP.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>An array of configurations for secondary IP ranges for VM instances contained in this subnetwork. The primary IP of such VM must belong to the primary ipCidrRange of the subnetwork. The alias IPs may belong to either primary or secondary ranges. Note: This field uses attr-as-block mode to avoid breaking users during the 0.12 upgrade. To explicitly send a list of zero objects you must use the following syntax: example=[] For more details about this behavior, see this section. Structure is documented below.</summary>
    [JsonPropertyName("secondaryIpRange")]
    public IList<V1beta1SubnetworkSpecForProviderSecondaryIpRange>? SecondaryIpRange { get; set; }

    /// <summary>The stack type for this subnet to identify whether the IPv6 feature is enabled or not. If not specified IPV4_ONLY will be used. Possible values are: IPV4_ONLY, IPV4_IPV6.</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }
}

public partial class V1beta1SubnetworkSpecInitProviderLogConfig
{
    /// <summary>Can only be specified if VPC flow logging for this subnetwork is enabled. Toggles the aggregation interval for collecting flow logs. Increasing the interval time will reduce the amount of generated flow logs for long lasting connections. Default is an interval of 5 seconds per connection. Default value is INTERVAL_5_SEC. Possible values are: INTERVAL_5_SEC, INTERVAL_30_SEC, INTERVAL_1_MIN, INTERVAL_5_MIN, INTERVAL_10_MIN, INTERVAL_15_MIN.</summary>
    [JsonPropertyName("aggregationInterval")]
    public string? AggregationInterval { get; set; }

    /// <summary>Export filter used to define which VPC flow logs should be logged, as as CEL expression. See https://cloud.google.com/vpc/docs/flow-logs#filtering for details on how to format this field. The default value is 'true', which evaluates to include everything.</summary>
    [JsonPropertyName("filterExpr")]
    public string? FilterExpr { get; set; }

    /// <summary>Can only be specified if VPC flow logging for this subnetwork is enabled. The value of the field must be in [0, 1]. Set the sampling rate of VPC flow logs within the subnetwork where 1.0 means all collected logs are reported and 0.0 means no logs are reported. Default is 0.5 which means half of all collected logs are reported.</summary>
    [JsonPropertyName("flowSampling")]
    public double? FlowSampling { get; set; }

    /// <summary>Can only be specified if VPC flow logging for this subnetwork is enabled. Configures whether metadata fields should be added to the reported VPC flow logs. Default value is INCLUDE_ALL_METADATA. Possible values are: EXCLUDE_ALL_METADATA, INCLUDE_ALL_METADATA, CUSTOM_METADATA.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>List of metadata fields that should be added to reported logs. Can only be specified if VPC flow logs for this subnetwork is enabled and "metadata" is set to CUSTOM_METADATA.</summary>
    [JsonPropertyName("metadataFields")]
    public IList<string>? MetadataFields { get; set; }
}

public enum V1beta1SubnetworkSpecInitProviderNetworkRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SubnetworkSpecInitProviderNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SubnetworkSpecInitProviderNetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubnetworkSpecInitProviderNetworkRefPolicyResolutionEnum>))]
    public V1beta1SubnetworkSpecInitProviderNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubnetworkSpecInitProviderNetworkRefPolicyResolveEnum>))]
    public V1beta1SubnetworkSpecInitProviderNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SubnetworkSpecInitProviderNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubnetworkSpecInitProviderNetworkRefPolicy? Policy { get; set; }
}

public enum V1beta1SubnetworkSpecInitProviderNetworkSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SubnetworkSpecInitProviderNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SubnetworkSpecInitProviderNetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubnetworkSpecInitProviderNetworkSelectorPolicyResolutionEnum>))]
    public V1beta1SubnetworkSpecInitProviderNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubnetworkSpecInitProviderNetworkSelectorPolicyResolveEnum>))]
    public V1beta1SubnetworkSpecInitProviderNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SubnetworkSpecInitProviderNetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubnetworkSpecInitProviderNetworkSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1SubnetworkSpecInitProviderSecondaryIpRange
{
    /// <summary>The range of IP addresses belonging to this subnetwork secondary range. Provide this property when you create the subnetwork. Ranges must be unique and non-overlapping with all primary and secondary IP ranges within a network. Only IPv4 is supported.</summary>
    [JsonPropertyName("ipCidrRange")]
    public string? IpCidrRange { get; set; }

    /// <summary>The name associated with this subnetwork secondary range, used when adding an alias IP range to a VM instance. The name must be 1-63 characters long, and comply with RFC1035. The name must be unique within the subnetwork.</summary>
    [JsonPropertyName("rangeName")]
    public string? RangeName { get; set; }
}

public partial class V1beta1SubnetworkSpecInitProvider
{
    /// <summary>An optional description of this resource. Provide this property when you create the resource. This field can be set only at resource creation time.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The range of external IPv6 addresses that are owned by this subnetwork.</summary>
    [JsonPropertyName("externalIpv6Prefix")]
    public string? ExternalIpv6Prefix { get; set; }

    /// <summary>The range of internal addresses that are owned by this subnetwork. Provide this property when you create the subnetwork. For example, 10.0.0.0/8 or 192.168.0.0/16. Ranges must be unique and non-overlapping within a network. Only IPv4 is supported.</summary>
    [JsonPropertyName("ipCidrRange")]
    public string? IpCidrRange { get; set; }

    /// <summary>The access type of IPv6 address this subnet holds. It's immutable and can only be specified during creation or the first time the subnet is updated into IPV4_IPV6 dual stack. If the ipv6_type is EXTERNAL then this subnet cannot enable direct path. Possible values are: EXTERNAL, INTERNAL.</summary>
    [JsonPropertyName("ipv6AccessType")]
    public string? Ipv6AccessType { get; set; }

    /// <summary>This field denotes the VPC flow logging options for this subnetwork. If logging is enabled, logs are exported to Cloud Logging. Flow logging isn't supported if the subnet purpose field is set to subnetwork is REGIONAL_MANAGED_PROXY or GLOBAL_MANAGED_PROXY. Structure is documented below.</summary>
    [JsonPropertyName("logConfig")]
    public IList<V1beta1SubnetworkSpecInitProviderLogConfig>? LogConfig { get; set; }

    /// <summary>The network this subnet belongs to. Only networks that are in the distributed mode can have subnetworks.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1SubnetworkSpecInitProviderNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1SubnetworkSpecInitProviderNetworkSelector? NetworkSelector { get; set; }

    /// <summary>When enabled, VMs in this subnetwork without external IP addresses can access Google APIs and services by using Private Google Access.</summary>
    [JsonPropertyName("privateIpGoogleAccess")]
    public bool? PrivateIpGoogleAccess { get; set; }

    /// <summary>The private IPv6 google access type for the VMs in this subnet.</summary>
    [JsonPropertyName("privateIpv6GoogleAccess")]
    public string? PrivateIpv6GoogleAccess { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The purpose of the resource. This field can be either PRIVATE_RFC_1918, REGIONAL_MANAGED_PROXY, GLOBAL_MANAGED_PROXY, PRIVATE_SERVICE_CONNECT or PRIVATE_NAT(Beta). A subnet with purpose set to REGIONAL_MANAGED_PROXY is a user-created subnetwork that is reserved for regional Envoy-based load balancers. A subnetwork in a given region with purpose set to GLOBAL_MANAGED_PROXY is a proxy-only subnet and is shared between all the cross-regional Envoy-based load balancers. A subnetwork with purpose set to PRIVATE_SERVICE_CONNECT reserves the subnet for hosting a Private Service Connect published service. A subnetwork with purpose set to PRIVATE_NAT is used as source range for Private NAT gateways. Note that REGIONAL_MANAGED_PROXY is the preferred setting for all regional Envoy load balancers. If unspecified, the purpose defaults to PRIVATE_RFC_1918.</summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>The role of subnetwork. Currently, this field is only used when purpose is REGIONAL_MANAGED_PROXY. The value can be set to ACTIVE or BACKUP. An ACTIVE subnetwork is one that is currently being used for Envoy-based load balancers in a region. A BACKUP subnetwork is one that is ready to be promoted to ACTIVE or is currently draining. Possible values are: ACTIVE, BACKUP.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>An array of configurations for secondary IP ranges for VM instances contained in this subnetwork. The primary IP of such VM must belong to the primary ipCidrRange of the subnetwork. The alias IPs may belong to either primary or secondary ranges. Note: This field uses attr-as-block mode to avoid breaking users during the 0.12 upgrade. To explicitly send a list of zero objects you must use the following syntax: example=[] For more details about this behavior, see this section. Structure is documented below.</summary>
    [JsonPropertyName("secondaryIpRange")]
    public IList<V1beta1SubnetworkSpecInitProviderSecondaryIpRange>? SecondaryIpRange { get; set; }

    /// <summary>The stack type for this subnet to identify whether the IPv6 feature is enabled or not. If not specified IPV4_ONLY will be used. Possible values are: IPV4_ONLY, IPV4_IPV6.</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }
}

public enum V1beta1SubnetworkSpecManagementPoliciesEnum
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

public enum V1beta1SubnetworkSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SubnetworkSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SubnetworkSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubnetworkSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1SubnetworkSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubnetworkSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1SubnetworkSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SubnetworkSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubnetworkSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1SubnetworkSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SubnetworkSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SubnetworkSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubnetworkSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1SubnetworkSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubnetworkSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1SubnetworkSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SubnetworkSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubnetworkSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1SubnetworkSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1SubnetworkSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SubnetworkSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SubnetworkSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1SubnetworkSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1SubnetworkSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubnetworkSpecDeletionPolicyEnum>))]
    public V1beta1SubnetworkSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SubnetworkSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SubnetworkSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SubnetworkSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SubnetworkSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SubnetworkSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SubnetworkSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1SubnetworkStatusAtProviderLogConfig
{
    /// <summary>Can only be specified if VPC flow logging for this subnetwork is enabled. Toggles the aggregation interval for collecting flow logs. Increasing the interval time will reduce the amount of generated flow logs for long lasting connections. Default is an interval of 5 seconds per connection. Default value is INTERVAL_5_SEC. Possible values are: INTERVAL_5_SEC, INTERVAL_30_SEC, INTERVAL_1_MIN, INTERVAL_5_MIN, INTERVAL_10_MIN, INTERVAL_15_MIN.</summary>
    [JsonPropertyName("aggregationInterval")]
    public string? AggregationInterval { get; set; }

    /// <summary>Export filter used to define which VPC flow logs should be logged, as as CEL expression. See https://cloud.google.com/vpc/docs/flow-logs#filtering for details on how to format this field. The default value is 'true', which evaluates to include everything.</summary>
    [JsonPropertyName("filterExpr")]
    public string? FilterExpr { get; set; }

    /// <summary>Can only be specified if VPC flow logging for this subnetwork is enabled. The value of the field must be in [0, 1]. Set the sampling rate of VPC flow logs within the subnetwork where 1.0 means all collected logs are reported and 0.0 means no logs are reported. Default is 0.5 which means half of all collected logs are reported.</summary>
    [JsonPropertyName("flowSampling")]
    public double? FlowSampling { get; set; }

    /// <summary>Can only be specified if VPC flow logging for this subnetwork is enabled. Configures whether metadata fields should be added to the reported VPC flow logs. Default value is INCLUDE_ALL_METADATA. Possible values are: EXCLUDE_ALL_METADATA, INCLUDE_ALL_METADATA, CUSTOM_METADATA.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>List of metadata fields that should be added to reported logs. Can only be specified if VPC flow logs for this subnetwork is enabled and "metadata" is set to CUSTOM_METADATA.</summary>
    [JsonPropertyName("metadataFields")]
    public IList<string>? MetadataFields { get; set; }
}

public partial class V1beta1SubnetworkStatusAtProviderSecondaryIpRange
{
    /// <summary>The range of IP addresses belonging to this subnetwork secondary range. Provide this property when you create the subnetwork. Ranges must be unique and non-overlapping with all primary and secondary IP ranges within a network. Only IPv4 is supported.</summary>
    [JsonPropertyName("ipCidrRange")]
    public string? IpCidrRange { get; set; }

    /// <summary>The name associated with this subnetwork secondary range, used when adding an alias IP range to a VM instance. The name must be 1-63 characters long, and comply with RFC1035. The name must be unique within the subnetwork.</summary>
    [JsonPropertyName("rangeName")]
    public string? RangeName { get; set; }
}

public partial class V1beta1SubnetworkStatusAtProvider
{
    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource. This field can be set only at resource creation time.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The range of external IPv6 addresses that are owned by this subnetwork.</summary>
    [JsonPropertyName("externalIpv6Prefix")]
    public string? ExternalIpv6Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>The gateway address for default routes to reach destination addresses outside this subnetwork.</summary>
    [JsonPropertyName("gatewayAddress")]
    public string? GatewayAddress { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/subnetworks/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The internal IPv6 address range that is assigned to this subnetwork.</summary>
    [JsonPropertyName("internalIpv6Prefix")]
    public string? InternalIpv6Prefix { get; set; }

    /// <summary>The range of internal addresses that are owned by this subnetwork. Provide this property when you create the subnetwork. For example, 10.0.0.0/8 or 192.168.0.0/16. Ranges must be unique and non-overlapping within a network. Only IPv4 is supported.</summary>
    [JsonPropertyName("ipCidrRange")]
    public string? IpCidrRange { get; set; }

    /// <summary>The access type of IPv6 address this subnet holds. It's immutable and can only be specified during creation or the first time the subnet is updated into IPV4_IPV6 dual stack. If the ipv6_type is EXTERNAL then this subnet cannot enable direct path. Possible values are: EXTERNAL, INTERNAL.</summary>
    [JsonPropertyName("ipv6AccessType")]
    public string? Ipv6AccessType { get; set; }

    /// <summary>The range of internal IPv6 addresses that are owned by this subnetwork.</summary>
    [JsonPropertyName("ipv6CidrRange")]
    public string? Ipv6CidrRange { get; set; }

    /// <summary>This field denotes the VPC flow logging options for this subnetwork. If logging is enabled, logs are exported to Cloud Logging. Flow logging isn't supported if the subnet purpose field is set to subnetwork is REGIONAL_MANAGED_PROXY or GLOBAL_MANAGED_PROXY. Structure is documented below.</summary>
    [JsonPropertyName("logConfig")]
    public IList<V1beta1SubnetworkStatusAtProviderLogConfig>? LogConfig { get; set; }

    /// <summary>The network this subnet belongs to. Only networks that are in the distributed mode can have subnetworks.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>When enabled, VMs in this subnetwork without external IP addresses can access Google APIs and services by using Private Google Access.</summary>
    [JsonPropertyName("privateIpGoogleAccess")]
    public bool? PrivateIpGoogleAccess { get; set; }

    /// <summary>The private IPv6 google access type for the VMs in this subnet.</summary>
    [JsonPropertyName("privateIpv6GoogleAccess")]
    public string? PrivateIpv6GoogleAccess { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The purpose of the resource. This field can be either PRIVATE_RFC_1918, REGIONAL_MANAGED_PROXY, GLOBAL_MANAGED_PROXY, PRIVATE_SERVICE_CONNECT or PRIVATE_NAT(Beta). A subnet with purpose set to REGIONAL_MANAGED_PROXY is a user-created subnetwork that is reserved for regional Envoy-based load balancers. A subnetwork in a given region with purpose set to GLOBAL_MANAGED_PROXY is a proxy-only subnet and is shared between all the cross-regional Envoy-based load balancers. A subnetwork with purpose set to PRIVATE_SERVICE_CONNECT reserves the subnet for hosting a Private Service Connect published service. A subnetwork with purpose set to PRIVATE_NAT is used as source range for Private NAT gateways. Note that REGIONAL_MANAGED_PROXY is the preferred setting for all regional Envoy load balancers. If unspecified, the purpose defaults to PRIVATE_RFC_1918.</summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>The GCP region for this subnetwork.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The role of subnetwork. Currently, this field is only used when purpose is REGIONAL_MANAGED_PROXY. The value can be set to ACTIVE or BACKUP. An ACTIVE subnetwork is one that is currently being used for Envoy-based load balancers in a region. A BACKUP subnetwork is one that is ready to be promoted to ACTIVE or is currently draining. Possible values are: ACTIVE, BACKUP.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>An array of configurations for secondary IP ranges for VM instances contained in this subnetwork. The primary IP of such VM must belong to the primary ipCidrRange of the subnetwork. The alias IPs may belong to either primary or secondary ranges. Note: This field uses attr-as-block mode to avoid breaking users during the 0.12 upgrade. To explicitly send a list of zero objects you must use the following syntax: example=[] For more details about this behavior, see this section. Structure is documented below.</summary>
    [JsonPropertyName("secondaryIpRange")]
    public IList<V1beta1SubnetworkStatusAtProviderSecondaryIpRange>? SecondaryIpRange { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The stack type for this subnet to identify whether the IPv6 feature is enabled or not. If not specified IPV4_ONLY will be used. Possible values are: IPV4_ONLY, IPV4_IPV6.</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }
}

public partial class V1beta1SubnetworkStatusConditions
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

public partial class V1beta1SubnetworkStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SubnetworkStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SubnetworkStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Subnetwork : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SubnetworkSpec>, IStatus<V1beta1SubnetworkStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Subnetwork";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "subnetworks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SubnetworkSpec defines the desired state of Subnetwork</summary>
    [JsonPropertyName("spec")]
    public V1beta1SubnetworkSpec Spec { get; set; }

    /// <summary>SubnetworkStatus defines the observed state of Subnetwork.</summary>
    [JsonPropertyName("status")]
    public V1beta1SubnetworkStatus? Status { get; set; }
}