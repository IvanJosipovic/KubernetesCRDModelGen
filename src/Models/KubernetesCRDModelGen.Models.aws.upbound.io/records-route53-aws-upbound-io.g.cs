using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.route53.aws.upbound.io;
public enum V1beta1RecordSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1RecordSpecForProviderAlias
{
    /// <summary>Set to true if you want Route 53 to determine whether to respond to DNS queries using this resource record set by checking the health of the resource record set. Some resources have special requirements, see related part of documentation.</summary>
    [JsonPropertyName("evaluateTargetHealth")]
    public bool? EvaluateTargetHealth { get; set; }

    /// <summary>The name of the record.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the hosted zone to contain this record.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

public partial class V1beta1RecordSpecForProviderCidrRoutingPolicy
{
    /// <summary>The CIDR collection ID. See the aws_route53_cidr_collection resource for more details.</summary>
    [JsonPropertyName("collectionId")]
    public string? CollectionId { get; set; }

    /// <summary>The CIDR collection location name. See the aws_route53_cidr_location resource for more details. A location_name with an asterisk "*" can be used to create a default CIDR record. collection_id is still required for default record.</summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }
}

public partial class V1beta1RecordSpecForProviderFailoverRoutingPolicy
{
    /// <summary>The record type. Valid values are A, AAAA, CAA, CNAME, DS, MX, NAPTR, NS, PTR, SOA, SPF, SRV and TXT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1RecordSpecForProviderGeolocationRoutingPolicy
{
    /// <summary>A two-letter continent code. See http://docs.aws.amazon.com/Route53/latest/APIReference/API_GetGeoLocation.html for code details. Either continent or country must be specified.</summary>
    [JsonPropertyName("continent")]
    public string? Continent { get; set; }

    /// <summary>A two-character country code or * to indicate a default resource record set.</summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>A subdivision code for a country.</summary>
    [JsonPropertyName("subdivision")]
    public string? Subdivision { get; set; }
}

public partial class V1beta1RecordSpecForProviderGeoproximityRoutingPolicyCoordinates
{
    /// <summary></summary>
    [JsonPropertyName("latitude")]
    public string? Latitude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("longitude")]
    public string? Longitude { get; set; }
}

public partial class V1beta1RecordSpecForProviderGeoproximityRoutingPolicy
{
    /// <summary>A AWS region where the resource is present.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>Route more traffic or less traffic to the resource by specifying a value ranges between -90 to 90. See https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-geoproximity.html for bias details.</summary>
    [JsonPropertyName("bias")]
    public double? Bias { get; set; }

    /// <summary>Specify latitude and longitude for routing traffic to non-AWS resources.</summary>
    [JsonPropertyName("coordinates")]
    public IList<V1beta1RecordSpecForProviderGeoproximityRoutingPolicyCoordinates>? Coordinates { get; set; }

    /// <summary>A AWS local zone group where the resource is present. See https://docs.aws.amazon.com/local-zones/latest/ug/available-local-zones.html for local zone group list.</summary>
    [JsonPropertyName("localZoneGroup")]
    public string? LocalZoneGroup { get; set; }
}

public enum V1beta1RecordSpecForProviderHealthCheckIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RecordSpecForProviderHealthCheckIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RecordSpecForProviderHealthCheckIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSpecForProviderHealthCheckIdRefPolicyResolutionEnum>))]
    public V1beta1RecordSpecForProviderHealthCheckIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSpecForProviderHealthCheckIdRefPolicyResolveEnum>))]
    public V1beta1RecordSpecForProviderHealthCheckIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RecordSpecForProviderHealthCheckIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSpecForProviderHealthCheckIdRefPolicy? Policy { get; set; }
}

public enum V1beta1RecordSpecForProviderHealthCheckIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RecordSpecForProviderHealthCheckIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RecordSpecForProviderHealthCheckIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSpecForProviderHealthCheckIdSelectorPolicyResolutionEnum>))]
    public V1beta1RecordSpecForProviderHealthCheckIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSpecForProviderHealthCheckIdSelectorPolicyResolveEnum>))]
    public V1beta1RecordSpecForProviderHealthCheckIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RecordSpecForProviderHealthCheckIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSpecForProviderHealthCheckIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1RecordSpecForProviderLatencyRoutingPolicy
{
    /// <summary>An AWS region from which to measure latency. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-latency</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}

public partial class V1beta1RecordSpecForProviderWeightedRoutingPolicy
{
    /// <summary>A numeric value indicating the relative weight of the record. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-weighted.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

public enum V1beta1RecordSpecForProviderZoneIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RecordSpecForProviderZoneIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RecordSpecForProviderZoneIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSpecForProviderZoneIdRefPolicyResolutionEnum>))]
    public V1beta1RecordSpecForProviderZoneIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSpecForProviderZoneIdRefPolicyResolveEnum>))]
    public V1beta1RecordSpecForProviderZoneIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RecordSpecForProviderZoneIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSpecForProviderZoneIdRefPolicy? Policy { get; set; }
}

public enum V1beta1RecordSpecForProviderZoneIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RecordSpecForProviderZoneIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RecordSpecForProviderZoneIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSpecForProviderZoneIdSelectorPolicyResolutionEnum>))]
    public V1beta1RecordSpecForProviderZoneIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSpecForProviderZoneIdSelectorPolicyResolveEnum>))]
    public V1beta1RecordSpecForProviderZoneIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RecordSpecForProviderZoneIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSpecForProviderZoneIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1RecordSpecForProvider
{
    /// <summary>An alias block. Conflicts with ttl & records. Documented below.</summary>
    [JsonPropertyName("alias")]
    public IList<V1beta1RecordSpecForProviderAlias>? Alias { get; set; }

    /// <summary>false by default. This configuration is not recommended for most environments.</summary>
    [JsonPropertyName("allowOverwrite")]
    public bool? AllowOverwrite { get; set; }

    /// <summary>A block indicating a routing policy based on the IP network ranges of requestors. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("cidrRoutingPolicy")]
    public IList<V1beta1RecordSpecForProviderCidrRoutingPolicy>? CidrRoutingPolicy { get; set; }

    /// <summary>A block indicating the routing behavior when associated health check fails. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("failoverRoutingPolicy")]
    public IList<V1beta1RecordSpecForProviderFailoverRoutingPolicy>? FailoverRoutingPolicy { get; set; }

    /// <summary>A block indicating a routing policy based on the geolocation of the requestor. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("geolocationRoutingPolicy")]
    public IList<V1beta1RecordSpecForProviderGeolocationRoutingPolicy>? GeolocationRoutingPolicy { get; set; }

    /// <summary>A block indicating a routing policy based on the geoproximity of the requestor. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("geoproximityRoutingPolicy")]
    public IList<V1beta1RecordSpecForProviderGeoproximityRoutingPolicy>? GeoproximityRoutingPolicy { get; set; }

    /// <summary>The health check the record should be associated with.</summary>
    [JsonPropertyName("healthCheckId")]
    public string? HealthCheckId { get; set; }

    /// <summary>Reference to a HealthCheck in route53 to populate healthCheckId.</summary>
    [JsonPropertyName("healthCheckIdRef")]
    public V1beta1RecordSpecForProviderHealthCheckIdRef? HealthCheckIdRef { get; set; }

    /// <summary>Selector for a HealthCheck in route53 to populate healthCheckId.</summary>
    [JsonPropertyName("healthCheckIdSelector")]
    public V1beta1RecordSpecForProviderHealthCheckIdSelector? HealthCheckIdSelector { get; set; }

    /// <summary>A block indicating a routing policy based on the latency between the requestor and an AWS region. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("latencyRoutingPolicy")]
    public IList<V1beta1RecordSpecForProviderLatencyRoutingPolicy>? LatencyRoutingPolicy { get; set; }

    /// <summary>Set to true to indicate a multivalue answer routing policy. Conflicts with any other routing policy.</summary>
    [JsonPropertyName("multivalueAnswerRoutingPolicy")]
    public bool? MultivalueAnswerRoutingPolicy { get; set; }

    /// <summary>The name of the record.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A string list of records.g., "first255characters\"\"morecharacters").</summary>
    [JsonPropertyName("records")]
    public IList<string>? Records { get; set; }

    /// <summary>An AWS region from which to measure latency. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-latency Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Unique identifier to differentiate records with routing policies from one another. Required if using cidr_routing_policy, failover_routing_policy, geolocation_routing_policy,geoproximity_routing_policy, latency_routing_policy, multivalue_answer_routing_policy, or weighted_routing_policy.</summary>
    [JsonPropertyName("setIdentifier")]
    public string? SetIdentifier { get; set; }

    /// <summary>The TTL of the record.</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }

    /// <summary>The record type. Valid values are A, AAAA, CAA, CNAME, DS, MX, NAPTR, NS, PTR, SOA, SPF, SRV and TXT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>A block indicating a weighted routing policy. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("weightedRoutingPolicy")]
    public IList<V1beta1RecordSpecForProviderWeightedRoutingPolicy>? WeightedRoutingPolicy { get; set; }

    /// <summary>The ID of the hosted zone to contain this record.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }

    /// <summary>Reference to a Zone in route53 to populate zoneId.</summary>
    [JsonPropertyName("zoneIdRef")]
    public V1beta1RecordSpecForProviderZoneIdRef? ZoneIdRef { get; set; }

    /// <summary>Selector for a Zone in route53 to populate zoneId.</summary>
    [JsonPropertyName("zoneIdSelector")]
    public V1beta1RecordSpecForProviderZoneIdSelector? ZoneIdSelector { get; set; }
}

public partial class V1beta1RecordSpecInitProviderAlias
{
    /// <summary>Set to true if you want Route 53 to determine whether to respond to DNS queries using this resource record set by checking the health of the resource record set. Some resources have special requirements, see related part of documentation.</summary>
    [JsonPropertyName("evaluateTargetHealth")]
    public bool? EvaluateTargetHealth { get; set; }

    /// <summary>The name of the record.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the hosted zone to contain this record.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

public partial class V1beta1RecordSpecInitProviderCidrRoutingPolicy
{
    /// <summary>The CIDR collection ID. See the aws_route53_cidr_collection resource for more details.</summary>
    [JsonPropertyName("collectionId")]
    public string? CollectionId { get; set; }

    /// <summary>The CIDR collection location name. See the aws_route53_cidr_location resource for more details. A location_name with an asterisk "*" can be used to create a default CIDR record. collection_id is still required for default record.</summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }
}

public partial class V1beta1RecordSpecInitProviderFailoverRoutingPolicy
{
    /// <summary>The record type. Valid values are A, AAAA, CAA, CNAME, DS, MX, NAPTR, NS, PTR, SOA, SPF, SRV and TXT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1RecordSpecInitProviderGeolocationRoutingPolicy
{
    /// <summary>A two-letter continent code. See http://docs.aws.amazon.com/Route53/latest/APIReference/API_GetGeoLocation.html for code details. Either continent or country must be specified.</summary>
    [JsonPropertyName("continent")]
    public string? Continent { get; set; }

    /// <summary>A two-character country code or * to indicate a default resource record set.</summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>A subdivision code for a country.</summary>
    [JsonPropertyName("subdivision")]
    public string? Subdivision { get; set; }
}

public partial class V1beta1RecordSpecInitProviderGeoproximityRoutingPolicyCoordinates
{
    /// <summary></summary>
    [JsonPropertyName("latitude")]
    public string? Latitude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("longitude")]
    public string? Longitude { get; set; }
}

public partial class V1beta1RecordSpecInitProviderGeoproximityRoutingPolicy
{
    /// <summary>A AWS region where the resource is present.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>Route more traffic or less traffic to the resource by specifying a value ranges between -90 to 90. See https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-geoproximity.html for bias details.</summary>
    [JsonPropertyName("bias")]
    public double? Bias { get; set; }

    /// <summary>Specify latitude and longitude for routing traffic to non-AWS resources.</summary>
    [JsonPropertyName("coordinates")]
    public IList<V1beta1RecordSpecInitProviderGeoproximityRoutingPolicyCoordinates>? Coordinates { get; set; }

    /// <summary>A AWS local zone group where the resource is present. See https://docs.aws.amazon.com/local-zones/latest/ug/available-local-zones.html for local zone group list.</summary>
    [JsonPropertyName("localZoneGroup")]
    public string? LocalZoneGroup { get; set; }
}

public enum V1beta1RecordSpecInitProviderHealthCheckIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RecordSpecInitProviderHealthCheckIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RecordSpecInitProviderHealthCheckIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSpecInitProviderHealthCheckIdRefPolicyResolutionEnum>))]
    public V1beta1RecordSpecInitProviderHealthCheckIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSpecInitProviderHealthCheckIdRefPolicyResolveEnum>))]
    public V1beta1RecordSpecInitProviderHealthCheckIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RecordSpecInitProviderHealthCheckIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSpecInitProviderHealthCheckIdRefPolicy? Policy { get; set; }
}

public enum V1beta1RecordSpecInitProviderHealthCheckIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RecordSpecInitProviderHealthCheckIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RecordSpecInitProviderHealthCheckIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSpecInitProviderHealthCheckIdSelectorPolicyResolutionEnum>))]
    public V1beta1RecordSpecInitProviderHealthCheckIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSpecInitProviderHealthCheckIdSelectorPolicyResolveEnum>))]
    public V1beta1RecordSpecInitProviderHealthCheckIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RecordSpecInitProviderHealthCheckIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSpecInitProviderHealthCheckIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1RecordSpecInitProviderLatencyRoutingPolicy
{
}

public partial class V1beta1RecordSpecInitProviderWeightedRoutingPolicy
{
    /// <summary>A numeric value indicating the relative weight of the record. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-weighted.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

public enum V1beta1RecordSpecInitProviderZoneIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RecordSpecInitProviderZoneIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RecordSpecInitProviderZoneIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSpecInitProviderZoneIdRefPolicyResolutionEnum>))]
    public V1beta1RecordSpecInitProviderZoneIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSpecInitProviderZoneIdRefPolicyResolveEnum>))]
    public V1beta1RecordSpecInitProviderZoneIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RecordSpecInitProviderZoneIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSpecInitProviderZoneIdRefPolicy? Policy { get; set; }
}

public enum V1beta1RecordSpecInitProviderZoneIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RecordSpecInitProviderZoneIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RecordSpecInitProviderZoneIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSpecInitProviderZoneIdSelectorPolicyResolutionEnum>))]
    public V1beta1RecordSpecInitProviderZoneIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSpecInitProviderZoneIdSelectorPolicyResolveEnum>))]
    public V1beta1RecordSpecInitProviderZoneIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RecordSpecInitProviderZoneIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSpecInitProviderZoneIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1RecordSpecInitProvider
{
    /// <summary>An alias block. Conflicts with ttl & records. Documented below.</summary>
    [JsonPropertyName("alias")]
    public IList<V1beta1RecordSpecInitProviderAlias>? Alias { get; set; }

    /// <summary>false by default. This configuration is not recommended for most environments.</summary>
    [JsonPropertyName("allowOverwrite")]
    public bool? AllowOverwrite { get; set; }

    /// <summary>A block indicating a routing policy based on the IP network ranges of requestors. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("cidrRoutingPolicy")]
    public IList<V1beta1RecordSpecInitProviderCidrRoutingPolicy>? CidrRoutingPolicy { get; set; }

    /// <summary>A block indicating the routing behavior when associated health check fails. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("failoverRoutingPolicy")]
    public IList<V1beta1RecordSpecInitProviderFailoverRoutingPolicy>? FailoverRoutingPolicy { get; set; }

    /// <summary>A block indicating a routing policy based on the geolocation of the requestor. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("geolocationRoutingPolicy")]
    public IList<V1beta1RecordSpecInitProviderGeolocationRoutingPolicy>? GeolocationRoutingPolicy { get; set; }

    /// <summary>A block indicating a routing policy based on the geoproximity of the requestor. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("geoproximityRoutingPolicy")]
    public IList<V1beta1RecordSpecInitProviderGeoproximityRoutingPolicy>? GeoproximityRoutingPolicy { get; set; }

    /// <summary>The health check the record should be associated with.</summary>
    [JsonPropertyName("healthCheckId")]
    public string? HealthCheckId { get; set; }

    /// <summary>Reference to a HealthCheck in route53 to populate healthCheckId.</summary>
    [JsonPropertyName("healthCheckIdRef")]
    public V1beta1RecordSpecInitProviderHealthCheckIdRef? HealthCheckIdRef { get; set; }

    /// <summary>Selector for a HealthCheck in route53 to populate healthCheckId.</summary>
    [JsonPropertyName("healthCheckIdSelector")]
    public V1beta1RecordSpecInitProviderHealthCheckIdSelector? HealthCheckIdSelector { get; set; }

    /// <summary>A block indicating a routing policy based on the latency between the requestor and an AWS region. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("latencyRoutingPolicy")]
    public IList<V1beta1RecordSpecInitProviderLatencyRoutingPolicy>? LatencyRoutingPolicy { get; set; }

    /// <summary>Set to true to indicate a multivalue answer routing policy. Conflicts with any other routing policy.</summary>
    [JsonPropertyName("multivalueAnswerRoutingPolicy")]
    public bool? MultivalueAnswerRoutingPolicy { get; set; }

    /// <summary>The name of the record.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A string list of records.g., "first255characters\"\"morecharacters").</summary>
    [JsonPropertyName("records")]
    public IList<string>? Records { get; set; }

    /// <summary>Unique identifier to differentiate records with routing policies from one another. Required if using cidr_routing_policy, failover_routing_policy, geolocation_routing_policy,geoproximity_routing_policy, latency_routing_policy, multivalue_answer_routing_policy, or weighted_routing_policy.</summary>
    [JsonPropertyName("setIdentifier")]
    public string? SetIdentifier { get; set; }

    /// <summary>The TTL of the record.</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }

    /// <summary>The record type. Valid values are A, AAAA, CAA, CNAME, DS, MX, NAPTR, NS, PTR, SOA, SPF, SRV and TXT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>A block indicating a weighted routing policy. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("weightedRoutingPolicy")]
    public IList<V1beta1RecordSpecInitProviderWeightedRoutingPolicy>? WeightedRoutingPolicy { get; set; }

    /// <summary>The ID of the hosted zone to contain this record.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }

    /// <summary>Reference to a Zone in route53 to populate zoneId.</summary>
    [JsonPropertyName("zoneIdRef")]
    public V1beta1RecordSpecInitProviderZoneIdRef? ZoneIdRef { get; set; }

    /// <summary>Selector for a Zone in route53 to populate zoneId.</summary>
    [JsonPropertyName("zoneIdSelector")]
    public V1beta1RecordSpecInitProviderZoneIdSelector? ZoneIdSelector { get; set; }
}

public enum V1beta1RecordSpecManagementPoliciesEnum
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

public enum V1beta1RecordSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RecordSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RecordSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1RecordSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1RecordSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RecordSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1RecordSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RecordSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1RecordSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1RecordSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1RecordSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1RecordSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1RecordSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1RecordSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1RecordSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1RecordSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1RecordSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1RecordSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSpecDeletionPolicyEnum>))]
    public V1beta1RecordSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RecordSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RecordSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1RecordSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RecordSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1RecordSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RecordSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1RecordStatusAtProviderAlias
{
    /// <summary>Set to true if you want Route 53 to determine whether to respond to DNS queries using this resource record set by checking the health of the resource record set. Some resources have special requirements, see related part of documentation.</summary>
    [JsonPropertyName("evaluateTargetHealth")]
    public bool? EvaluateTargetHealth { get; set; }

    /// <summary>The name of the record.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the hosted zone to contain this record.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

public partial class V1beta1RecordStatusAtProviderCidrRoutingPolicy
{
    /// <summary>The CIDR collection ID. See the aws_route53_cidr_collection resource for more details.</summary>
    [JsonPropertyName("collectionId")]
    public string? CollectionId { get; set; }

    /// <summary>The CIDR collection location name. See the aws_route53_cidr_location resource for more details. A location_name with an asterisk "*" can be used to create a default CIDR record. collection_id is still required for default record.</summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }
}

public partial class V1beta1RecordStatusAtProviderFailoverRoutingPolicy
{
    /// <summary>The record type. Valid values are A, AAAA, CAA, CNAME, DS, MX, NAPTR, NS, PTR, SOA, SPF, SRV and TXT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1RecordStatusAtProviderGeolocationRoutingPolicy
{
    /// <summary>A two-letter continent code. See http://docs.aws.amazon.com/Route53/latest/APIReference/API_GetGeoLocation.html for code details. Either continent or country must be specified.</summary>
    [JsonPropertyName("continent")]
    public string? Continent { get; set; }

    /// <summary>A two-character country code or * to indicate a default resource record set.</summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>A subdivision code for a country.</summary>
    [JsonPropertyName("subdivision")]
    public string? Subdivision { get; set; }
}

public partial class V1beta1RecordStatusAtProviderGeoproximityRoutingPolicyCoordinates
{
    /// <summary></summary>
    [JsonPropertyName("latitude")]
    public string? Latitude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("longitude")]
    public string? Longitude { get; set; }
}

public partial class V1beta1RecordStatusAtProviderGeoproximityRoutingPolicy
{
    /// <summary>A AWS region where the resource is present.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>Route more traffic or less traffic to the resource by specifying a value ranges between -90 to 90. See https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-geoproximity.html for bias details.</summary>
    [JsonPropertyName("bias")]
    public double? Bias { get; set; }

    /// <summary>Specify latitude and longitude for routing traffic to non-AWS resources.</summary>
    [JsonPropertyName("coordinates")]
    public IList<V1beta1RecordStatusAtProviderGeoproximityRoutingPolicyCoordinates>? Coordinates { get; set; }

    /// <summary>A AWS local zone group where the resource is present. See https://docs.aws.amazon.com/local-zones/latest/ug/available-local-zones.html for local zone group list.</summary>
    [JsonPropertyName("localZoneGroup")]
    public string? LocalZoneGroup { get; set; }
}

public partial class V1beta1RecordStatusAtProviderLatencyRoutingPolicy
{
    /// <summary>An AWS region from which to measure latency. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-latency</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

public partial class V1beta1RecordStatusAtProviderWeightedRoutingPolicy
{
    /// <summary>A numeric value indicating the relative weight of the record. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-weighted.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

public partial class V1beta1RecordStatusAtProvider
{
    /// <summary>An alias block. Conflicts with ttl & records. Documented below.</summary>
    [JsonPropertyName("alias")]
    public IList<V1beta1RecordStatusAtProviderAlias>? Alias { get; set; }

    /// <summary>false by default. This configuration is not recommended for most environments.</summary>
    [JsonPropertyName("allowOverwrite")]
    public bool? AllowOverwrite { get; set; }

    /// <summary>A block indicating a routing policy based on the IP network ranges of requestors. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("cidrRoutingPolicy")]
    public IList<V1beta1RecordStatusAtProviderCidrRoutingPolicy>? CidrRoutingPolicy { get; set; }

    /// <summary>A block indicating the routing behavior when associated health check fails. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("failoverRoutingPolicy")]
    public IList<V1beta1RecordStatusAtProviderFailoverRoutingPolicy>? FailoverRoutingPolicy { get; set; }

    /// <summary>FQDN built using the zone domain and name.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>A block indicating a routing policy based on the geolocation of the requestor. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("geolocationRoutingPolicy")]
    public IList<V1beta1RecordStatusAtProviderGeolocationRoutingPolicy>? GeolocationRoutingPolicy { get; set; }

    /// <summary>A block indicating a routing policy based on the geoproximity of the requestor. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("geoproximityRoutingPolicy")]
    public IList<V1beta1RecordStatusAtProviderGeoproximityRoutingPolicy>? GeoproximityRoutingPolicy { get; set; }

    /// <summary>The health check the record should be associated with.</summary>
    [JsonPropertyName("healthCheckId")]
    public string? HealthCheckId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A block indicating a routing policy based on the latency between the requestor and an AWS region. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("latencyRoutingPolicy")]
    public IList<V1beta1RecordStatusAtProviderLatencyRoutingPolicy>? LatencyRoutingPolicy { get; set; }

    /// <summary>Set to true to indicate a multivalue answer routing policy. Conflicts with any other routing policy.</summary>
    [JsonPropertyName("multivalueAnswerRoutingPolicy")]
    public bool? MultivalueAnswerRoutingPolicy { get; set; }

    /// <summary>The name of the record.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A string list of records.g., "first255characters\"\"morecharacters").</summary>
    [JsonPropertyName("records")]
    public IList<string>? Records { get; set; }

    /// <summary>Unique identifier to differentiate records with routing policies from one another. Required if using cidr_routing_policy, failover_routing_policy, geolocation_routing_policy,geoproximity_routing_policy, latency_routing_policy, multivalue_answer_routing_policy, or weighted_routing_policy.</summary>
    [JsonPropertyName("setIdentifier")]
    public string? SetIdentifier { get; set; }

    /// <summary>The TTL of the record.</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }

    /// <summary>The record type. Valid values are A, AAAA, CAA, CNAME, DS, MX, NAPTR, NS, PTR, SOA, SPF, SRV and TXT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>A block indicating a weighted routing policy. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("weightedRoutingPolicy")]
    public IList<V1beta1RecordStatusAtProviderWeightedRoutingPolicy>? WeightedRoutingPolicy { get; set; }

    /// <summary>The ID of the hosted zone to contain this record.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

public partial class V1beta1RecordStatusConditions
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

public partial class V1beta1RecordStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RecordStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RecordStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Record : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RecordSpec>, IStatus<V1beta1RecordStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Record";
    public const string KubeGroup = "route53.aws.upbound.io";
    public const string KubePluralName = "records";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RecordSpec defines the desired state of Record</summary>
    [JsonPropertyName("spec")]
    public V1beta1RecordSpec Spec { get; set; }

    /// <summary>RecordStatus defines the observed state of Record.</summary>
    [JsonPropertyName("status")]
    public V1beta1RecordStatus? Status { get; set; }
}