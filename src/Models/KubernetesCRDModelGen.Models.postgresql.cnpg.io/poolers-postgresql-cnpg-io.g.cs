using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.postgresql.cnpg.io;
/// <summary>This is the cluster reference on which the Pooler will work. Pooler name should never match with any cluster name within the same namespace.</summary>
public partial class V1PoolerSpecCluster
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Rolling update config params. Present only if DeploymentStrategyType = RollingUpdate. --- TODO: Update this to follow our convention for oneOf, whatever we decide it to be.</summary>
public partial class V1PoolerSpecDeploymentStrategyRollingUpdate
{
    /// <summary>The maximum number of pods that can be scheduled above the desired number of pods. Value can be an absolute number (ex: 5) or a percentage of desired pods (ex: 10%). This can not be 0 if MaxUnavailable is 0. Absolute number is calculated from percentage by rounding up. Defaults to 25%. Example: when this is set to 30%, the new ReplicaSet can be scaled up immediately when the rolling update starts, such that the total number of old and new pods do not exceed 130% of desired pods. Once old pods have been killed, new ReplicaSet can be scaled up further, ensuring that total number of pods running at any time during the update is at most 130% of desired pods.</summary>
    [JsonPropertyName("maxSurge")]
    public IntstrIntOrString? MaxSurge { get; set; }

    /// <summary>The maximum number of pods that can be unavailable during the update. Value can be an absolute number (ex: 5) or a percentage of desired pods (ex: 10%). Absolute number is calculated from percentage by rounding down. This can not be 0 if MaxSurge is 0. Defaults to 25%. Example: when this is set to 30%, the old ReplicaSet can be scaled down to 70% of desired pods immediately when the rolling update starts. Once new pods are ready, old ReplicaSet can be scaled down further, followed by scaling up the new ReplicaSet, ensuring that the total number of pods available at all times during the update is at least 70% of desired pods.</summary>
    [JsonPropertyName("maxUnavailable")]
    public IntstrIntOrString? MaxUnavailable { get; set; }
}

/// <summary>The deployment strategy to use for pgbouncer to replace existing pods with new ones</summary>
public partial class V1PoolerSpecDeploymentStrategy
{
    /// <summary>Rolling update config params. Present only if DeploymentStrategyType = RollingUpdate. --- TODO: Update this to follow our convention for oneOf, whatever we decide it to be.</summary>
    [JsonPropertyName("rollingUpdate")]
    public V1PoolerSpecDeploymentStrategyRollingUpdate? RollingUpdate { get; set; }

    /// <summary>Type of deployment. Can be "Recreate" or "RollingUpdate". Default is RollingUpdate.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1PoolerSpecMonitoringPodMonitorMetricRelabelingsActionEnum
{
    [EnumMember(Value = "replace"), JsonStringEnumMemberName("replace")]
    /// <summary>replace</summary>
    Replace,
    [EnumMember(Value = "Replace"), JsonStringEnumMemberName("Replace")]
    /// <summary>Replace</summary>
    Replace1,
    [EnumMember(Value = "keep"), JsonStringEnumMemberName("keep")]
    /// <summary>keep</summary>
    Keep,
    [EnumMember(Value = "Keep"), JsonStringEnumMemberName("Keep")]
    /// <summary>Keep</summary>
    Keep1,
    [EnumMember(Value = "drop"), JsonStringEnumMemberName("drop")]
    /// <summary>drop</summary>
    Drop,
    [EnumMember(Value = "Drop"), JsonStringEnumMemberName("Drop")]
    /// <summary>Drop</summary>
    Drop1,
    [EnumMember(Value = "hashmod"), JsonStringEnumMemberName("hashmod")]
    /// <summary>hashmod</summary>
    Hashmod,
    [EnumMember(Value = "HashMod"), JsonStringEnumMemberName("HashMod")]
    /// <summary>HashMod</summary>
    HashMod,
    [EnumMember(Value = "labelmap"), JsonStringEnumMemberName("labelmap")]
    /// <summary>labelmap</summary>
    Labelmap,
    [EnumMember(Value = "LabelMap"), JsonStringEnumMemberName("LabelMap")]
    /// <summary>LabelMap</summary>
    LabelMap,
    [EnumMember(Value = "labeldrop"), JsonStringEnumMemberName("labeldrop")]
    /// <summary>labeldrop</summary>
    Labeldrop,
    [EnumMember(Value = "LabelDrop"), JsonStringEnumMemberName("LabelDrop")]
    /// <summary>LabelDrop</summary>
    LabelDrop,
    [EnumMember(Value = "labelkeep"), JsonStringEnumMemberName("labelkeep")]
    /// <summary>labelkeep</summary>
    Labelkeep,
    [EnumMember(Value = "LabelKeep"), JsonStringEnumMemberName("LabelKeep")]
    /// <summary>LabelKeep</summary>
    LabelKeep,
    [EnumMember(Value = "lowercase"), JsonStringEnumMemberName("lowercase")]
    /// <summary>lowercase</summary>
    Lowercase,
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    /// <summary>Lowercase</summary>
    Lowercase1,
    [EnumMember(Value = "uppercase"), JsonStringEnumMemberName("uppercase")]
    /// <summary>uppercase</summary>
    Uppercase,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    /// <summary>Uppercase</summary>
    Uppercase1,
    [EnumMember(Value = "keepequal"), JsonStringEnumMemberName("keepequal")]
    /// <summary>keepequal</summary>
    Keepequal,
    [EnumMember(Value = "KeepEqual"), JsonStringEnumMemberName("KeepEqual")]
    /// <summary>KeepEqual</summary>
    KeepEqual,
    [EnumMember(Value = "dropequal"), JsonStringEnumMemberName("dropequal")]
    /// <summary>dropequal</summary>
    Dropequal,
    [EnumMember(Value = "DropEqual"), JsonStringEnumMemberName("DropEqual")]
    /// <summary>DropEqual</summary>
    DropEqual
}

/// <summary>RelabelConfig allows dynamic rewriting of the label set for targets, alerts, scraped samples and remote write samples.   More info: https://prometheus.io/docs/prometheus/latest/configuration/configuration/#relabel_config</summary>
public partial class V1PoolerSpecMonitoringPodMonitorMetricRelabelings
{
    /// <summary>Action to perform based on the regex matching.   `Uppercase` and `Lowercase` actions require Prometheus &gt;= v2.36.0. `DropEqual` and `KeepEqual` actions require Prometheus &gt;= v2.41.0.   Default: "Replace"</summary>
    [JsonPropertyName("action")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1PoolerSpecMonitoringPodMonitorMetricRelabelingsActionEnum>))]
    public V1PoolerSpecMonitoringPodMonitorMetricRelabelingsActionEnum? Action { get; set; }

    /// <summary>Modulus to take of the hash of the source label values.   Only applicable when the action is `HashMod`.</summary>
    [JsonPropertyName("modulus")]
    public long? Modulus { get; set; }

    /// <summary>Regular expression against which the extracted value is matched.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Replacement value against which a Replace action is performed if the regular expression matches.   Regex capture groups are available.</summary>
    [JsonPropertyName("replacement")]
    public string? Replacement { get; set; }

    /// <summary>Separator is the string between concatenated SourceLabels.</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary>The source labels select values from existing labels. Their content is concatenated using the configured Separator and matched against the configured regular expression.</summary>
    [JsonPropertyName("sourceLabels")]
    public IList<string>? SourceLabels { get; set; }

    /// <summary>Label to which the resulting string is written in a replacement.   It is mandatory for `Replace`, `HashMod`, `Lowercase`, `Uppercase`, `KeepEqual` and `DropEqual` actions.   Regex capture groups are available.</summary>
    [JsonPropertyName("targetLabel")]
    public string? TargetLabel { get; set; }
}

public enum V1PoolerSpecMonitoringPodMonitorRelabelingsActionEnum
{
    [EnumMember(Value = "replace"), JsonStringEnumMemberName("replace")]
    /// <summary>replace</summary>
    Replace,
    [EnumMember(Value = "Replace"), JsonStringEnumMemberName("Replace")]
    /// <summary>Replace</summary>
    Replace1,
    [EnumMember(Value = "keep"), JsonStringEnumMemberName("keep")]
    /// <summary>keep</summary>
    Keep,
    [EnumMember(Value = "Keep"), JsonStringEnumMemberName("Keep")]
    /// <summary>Keep</summary>
    Keep1,
    [EnumMember(Value = "drop"), JsonStringEnumMemberName("drop")]
    /// <summary>drop</summary>
    Drop,
    [EnumMember(Value = "Drop"), JsonStringEnumMemberName("Drop")]
    /// <summary>Drop</summary>
    Drop1,
    [EnumMember(Value = "hashmod"), JsonStringEnumMemberName("hashmod")]
    /// <summary>hashmod</summary>
    Hashmod,
    [EnumMember(Value = "HashMod"), JsonStringEnumMemberName("HashMod")]
    /// <summary>HashMod</summary>
    HashMod,
    [EnumMember(Value = "labelmap"), JsonStringEnumMemberName("labelmap")]
    /// <summary>labelmap</summary>
    Labelmap,
    [EnumMember(Value = "LabelMap"), JsonStringEnumMemberName("LabelMap")]
    /// <summary>LabelMap</summary>
    LabelMap,
    [EnumMember(Value = "labeldrop"), JsonStringEnumMemberName("labeldrop")]
    /// <summary>labeldrop</summary>
    Labeldrop,
    [EnumMember(Value = "LabelDrop"), JsonStringEnumMemberName("LabelDrop")]
    /// <summary>LabelDrop</summary>
    LabelDrop,
    [EnumMember(Value = "labelkeep"), JsonStringEnumMemberName("labelkeep")]
    /// <summary>labelkeep</summary>
    Labelkeep,
    [EnumMember(Value = "LabelKeep"), JsonStringEnumMemberName("LabelKeep")]
    /// <summary>LabelKeep</summary>
    LabelKeep,
    [EnumMember(Value = "lowercase"), JsonStringEnumMemberName("lowercase")]
    /// <summary>lowercase</summary>
    Lowercase,
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    /// <summary>Lowercase</summary>
    Lowercase1,
    [EnumMember(Value = "uppercase"), JsonStringEnumMemberName("uppercase")]
    /// <summary>uppercase</summary>
    Uppercase,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    /// <summary>Uppercase</summary>
    Uppercase1,
    [EnumMember(Value = "keepequal"), JsonStringEnumMemberName("keepequal")]
    /// <summary>keepequal</summary>
    Keepequal,
    [EnumMember(Value = "KeepEqual"), JsonStringEnumMemberName("KeepEqual")]
    /// <summary>KeepEqual</summary>
    KeepEqual,
    [EnumMember(Value = "dropequal"), JsonStringEnumMemberName("dropequal")]
    /// <summary>dropequal</summary>
    Dropequal,
    [EnumMember(Value = "DropEqual"), JsonStringEnumMemberName("DropEqual")]
    /// <summary>DropEqual</summary>
    DropEqual
}

/// <summary>RelabelConfig allows dynamic rewriting of the label set for targets, alerts, scraped samples and remote write samples.   More info: https://prometheus.io/docs/prometheus/latest/configuration/configuration/#relabel_config</summary>
public partial class V1PoolerSpecMonitoringPodMonitorRelabelings
{
    /// <summary>Action to perform based on the regex matching.   `Uppercase` and `Lowercase` actions require Prometheus &gt;= v2.36.0. `DropEqual` and `KeepEqual` actions require Prometheus &gt;= v2.41.0.   Default: "Replace"</summary>
    [JsonPropertyName("action")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1PoolerSpecMonitoringPodMonitorRelabelingsActionEnum>))]
    public V1PoolerSpecMonitoringPodMonitorRelabelingsActionEnum? Action { get; set; }

    /// <summary>Modulus to take of the hash of the source label values.   Only applicable when the action is `HashMod`.</summary>
    [JsonPropertyName("modulus")]
    public long? Modulus { get; set; }

    /// <summary>Regular expression against which the extracted value is matched.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Replacement value against which a Replace action is performed if the regular expression matches.   Regex capture groups are available.</summary>
    [JsonPropertyName("replacement")]
    public string? Replacement { get; set; }

    /// <summary>Separator is the string between concatenated SourceLabels.</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary>The source labels select values from existing labels. Their content is concatenated using the configured Separator and matched against the configured regular expression.</summary>
    [JsonPropertyName("sourceLabels")]
    public IList<string>? SourceLabels { get; set; }

    /// <summary>Label to which the resulting string is written in a replacement.   It is mandatory for `Replace`, `HashMod`, `Lowercase`, `Uppercase`, `KeepEqual` and `DropEqual` actions.   Regex capture groups are available.</summary>
    [JsonPropertyName("targetLabel")]
    public string? TargetLabel { get; set; }
}

/// <summary>The configuration of the monitoring infrastructure of this pooler.</summary>
public partial class V1PoolerSpecMonitoring
{
    /// <summary>Enable or disable the `PodMonitor`</summary>
    [JsonPropertyName("enablePodMonitor")]
    public bool? EnablePodMonitor { get; set; }

    /// <summary>The list of metric relabelings for the `PodMonitor`. Applied to samples before ingestion.</summary>
    [JsonPropertyName("podMonitorMetricRelabelings")]
    public IList<V1PoolerSpecMonitoringPodMonitorMetricRelabelings>? PodMonitorMetricRelabelings { get; set; }

    /// <summary>The list of relabelings for the `PodMonitor`. Applied to samples before scraping.</summary>
    [JsonPropertyName("podMonitorRelabelings")]
    public IList<V1PoolerSpecMonitoringPodMonitorRelabelings>? PodMonitorRelabelings { get; set; }
}

/// <summary>The credentials of the user that need to be used for the authentication query. In case it is specified, also an AuthQuery (e.g. "SELECT usename, passwd FROM pg_catalog.pg_shadow WHERE usename=$1") has to be specified and no automatic CNPG Cluster integration will be triggered.</summary>
public partial class V1PoolerSpecPgbouncerAuthQuerySecret
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public enum V1PoolerSpecPgbouncerPoolModeEnum
{
    [EnumMember(Value = "session"), JsonStringEnumMemberName("session")]
    /// <summary>session</summary>
    Session,
    [EnumMember(Value = "transaction"), JsonStringEnumMemberName("transaction")]
    /// <summary>transaction</summary>
    Transaction
}

/// <summary>The PgBouncer configuration</summary>
public partial class V1PoolerSpecPgbouncer
{
    /// <summary>The query that will be used to download the hash of the password of a certain user. Default: "SELECT usename, passwd FROM public.user_search($1)". In case it is specified, also an AuthQuerySecret has to be specified and no automatic CNPG Cluster integration will be triggered.</summary>
    [JsonPropertyName("authQuery")]
    public string? AuthQuery { get; set; }

    /// <summary>The credentials of the user that need to be used for the authentication query. In case it is specified, also an AuthQuery (e.g. "SELECT usename, passwd FROM pg_catalog.pg_shadow WHERE usename=$1") has to be specified and no automatic CNPG Cluster integration will be triggered.</summary>
    [JsonPropertyName("authQuerySecret")]
    public V1PoolerSpecPgbouncerAuthQuerySecret? AuthQuerySecret { get; set; }

    /// <summary>Additional parameters to be passed to PgBouncer - please check the CNPG documentation for a list of options you can configure</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>When set to `true`, PgBouncer will disconnect from the PostgreSQL server, first waiting for all queries to complete, and pause all new client connections until this value is set to `false` (default). Internally, the operator calls PgBouncer's `PAUSE` and `RESUME` commands.</summary>
    [JsonPropertyName("paused")]
    public bool? Paused { get; set; }

    /// <summary>PostgreSQL Host Based Authentication rules (lines to be appended to the pg_hba.conf file)</summary>
    [JsonPropertyName("pg_hba")]
    public IList<string>? PgHba { get; set; }

    /// <summary>The pool mode. Default: `session`.</summary>
    [JsonPropertyName("poolMode")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1PoolerSpecPgbouncerPoolModeEnum>))]
    public V1PoolerSpecPgbouncerPoolModeEnum? PoolMode { get; set; }
}

/// <summary>Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
public partial class V1PoolerSpecServiceTemplateMetadata
{
    /// <summary>Annotations is an unstructured key value map stored with a resource that may be set by external tools to store and retrieve arbitrary metadata. They are not queryable and should be preserved when modifying objects. More info: http://kubernetes.io/docs/user-guide/annotations</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Map of string keys and values that can be used to organize and categorize (scope and select) objects. May match selectors of replication controllers and services. More info: http://kubernetes.io/docs/user-guide/labels</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The name of the resource. Only supported for certain types</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ServicePort contains information on service's port.</summary>
public partial class V1PoolerSpecServiceTemplateSpecPorts
{
    /// <summary>The application protocol for this port. This is used as a hint for implementations to offer richer behavior for protocols that they understand. This field follows standard Kubernetes label syntax. Valid values are either:   * Un-prefixed protocol names - reserved for IANA standard service names (as per RFC-6335 and https://www.iana.org/assignments/service-names).   * Kubernetes-defined prefixed names:   * 'kubernetes.io/h2c' - HTTP/2 prior knowledge over cleartext as described in https://www.rfc-editor.org/rfc/rfc9113.html#name-starting-http-2-with-prior-   * 'kubernetes.io/ws'  - WebSocket over cleartext as described in https://www.rfc-editor.org/rfc/rfc6455   * 'kubernetes.io/wss' - WebSocket over TLS as described in https://www.rfc-editor.org/rfc/rfc6455   * Other protocols should use implementation-defined prefixed names such as mycompany.com/my-custom-protocol.</summary>
    [JsonPropertyName("appProtocol")]
    public string? AppProtocol { get; set; }

    /// <summary>The name of this port within the service. This must be a DNS_LABEL. All ports within a ServiceSpec must have unique names. When considering the endpoints for a Service, this must match the 'name' field in the EndpointPort. Optional if only one ServicePort is defined on this service.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The port on each node on which this service is exposed when type is NodePort or LoadBalancer.  Usually assigned by the system. If a value is specified, in-range, and not in use it will be used, otherwise the operation will fail.  If not specified, a port will be allocated if this Service requires one.  If this field is specified when creating a Service which does not need it, creation will fail. This field will be wiped when updating a Service to no longer need it (e.g. changing type from NodePort to ClusterIP). More info: https://kubernetes.io/docs/concepts/services-networking/service/#type-nodeport</summary>
    [JsonPropertyName("nodePort")]
    public int? NodePort { get; set; }

    /// <summary>The port that will be exposed by this service.</summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>The IP protocol for this port. Supports "TCP", "UDP", and "SCTP". Default is TCP.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Number or name of the port to access on the pods targeted by the service. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME. If this is a string, it will be looked up as a named port in the target Pod's container ports. If this is not specified, the value of the 'port' field is used (an identity map). This field is ignored for services with clusterIP=None, and should be omitted or set equal to the 'port' field. More info: https://kubernetes.io/docs/concepts/services-networking/service/#defining-a-service</summary>
    [JsonPropertyName("targetPort")]
    public IntstrIntOrString? TargetPort { get; set; }
}

/// <summary>clientIP contains the configurations of Client IP based session affinity.</summary>
public partial class V1PoolerSpecServiceTemplateSpecSessionAffinityConfigClientIP
{
    /// <summary>timeoutSeconds specifies the seconds of ClientIP type session sticky time. The value must be &gt;0 &amp;&amp; &lt;=86400(for 1 day) if ServiceAffinity == "ClientIP". Default value is 10800(for 3 hours).</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>sessionAffinityConfig contains the configurations of session affinity.</summary>
public partial class V1PoolerSpecServiceTemplateSpecSessionAffinityConfig
{
    /// <summary>clientIP contains the configurations of Client IP based session affinity.</summary>
    [JsonPropertyName("clientIP")]
    public V1PoolerSpecServiceTemplateSpecSessionAffinityConfigClientIP? ClientIP { get; set; }
}

/// <summary>Specification of the desired behavior of the service. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
public partial class V1PoolerSpecServiceTemplateSpec
{
    /// <summary>allocateLoadBalancerNodePorts defines if NodePorts will be automatically allocated for services with type LoadBalancer.  Default is "true". It may be set to "false" if the cluster load-balancer does not rely on NodePorts.  If the caller requests specific NodePorts (by specifying a value), those requests will be respected, regardless of this field. This field may only be set for services with type LoadBalancer and will be cleared if the type is changed to any other type.</summary>
    [JsonPropertyName("allocateLoadBalancerNodePorts")]
    public bool? AllocateLoadBalancerNodePorts { get; set; }

    /// <summary>clusterIP is the IP address of the service and is usually assigned randomly. If an address is specified manually, is in-range (as per system configuration), and is not in use, it will be allocated to the service; otherwise creation of the service will fail. This field may not be changed through updates unless the type field is also being changed to ExternalName (which requires this field to be blank) or the type field is being changed from ExternalName (in which case this field may optionally be specified, as describe above).  Valid values are "None", empty string (""), or a valid IP address. Setting this to "None" makes a "headless service" (no virtual IP), which is useful when direct endpoint connections are preferred and proxying is not required.  Only applies to types ClusterIP, NodePort, and LoadBalancer. If this field is specified when creating a Service of type ExternalName, creation will fail. This field will be wiped when updating a Service to type ExternalName. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies</summary>
    [JsonPropertyName("clusterIP")]
    public string? ClusterIP { get; set; }

    /// <summary>ClusterIPs is a list of IP addresses assigned to this service, and are usually assigned randomly.  If an address is specified manually, is in-range (as per system configuration), and is not in use, it will be allocated to the service; otherwise creation of the service will fail. This field may not be changed through updates unless the type field is also being changed to ExternalName (which requires this field to be empty) or the type field is being changed from ExternalName (in which case this field may optionally be specified, as describe above).  Valid values are "None", empty string (""), or a valid IP address.  Setting this to "None" makes a "headless service" (no virtual IP), which is useful when direct endpoint connections are preferred and proxying is not required.  Only applies to types ClusterIP, NodePort, and LoadBalancer. If this field is specified when creating a Service of type ExternalName, creation will fail. This field will be wiped when updating a Service to type ExternalName.  If this field is not specified, it will be initialized from the clusterIP field.  If this field is specified, clients must ensure that clusterIPs[0] and clusterIP have the same value.   This field may hold a maximum of two entries (dual-stack IPs, in either order). These IPs must correspond to the values of the ipFamilies field. Both clusterIPs and ipFamilies are governed by the ipFamilyPolicy field. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies</summary>
    [JsonPropertyName("clusterIPs")]
    public IList<string>? ClusterIPs { get; set; }

    /// <summary>externalIPs is a list of IP addresses for which nodes in the cluster will also accept traffic for this service.  These IPs are not managed by Kubernetes.  The user is responsible for ensuring that traffic arrives at a node with this IP.  A common example is external load-balancers that are not part of the Kubernetes system.</summary>
    [JsonPropertyName("externalIPs")]
    public IList<string>? ExternalIPs { get; set; }

    /// <summary>externalName is the external reference that discovery mechanisms will return as an alias for this service (e.g. a DNS CNAME record). No proxying will be involved.  Must be a lowercase RFC-1123 hostname (https://tools.ietf.org/html/rfc1123) and requires `type` to be "ExternalName".</summary>
    [JsonPropertyName("externalName")]
    public string? ExternalName { get; set; }

    /// <summary>externalTrafficPolicy describes how nodes distribute service traffic they receive on one of the Service's "externally-facing" addresses (NodePorts, ExternalIPs, and LoadBalancer IPs). If set to "Local", the proxy will configure the service in a way that assumes that external load balancers will take care of balancing the service traffic between nodes, and so each node will deliver traffic only to the node-local endpoints of the service, without masquerading the client source IP. (Traffic mistakenly sent to a node with no endpoints will be dropped.) The default value, "Cluster", uses the standard behavior of routing to all endpoints evenly (possibly modified by topology and other features). Note that traffic sent to an External IP or LoadBalancer IP from within the cluster will always get "Cluster" semantics, but clients sending to a NodePort from within the cluster may need to take traffic policy into account when picking a node.</summary>
    [JsonPropertyName("externalTrafficPolicy")]
    public string? ExternalTrafficPolicy { get; set; }

    /// <summary>healthCheckNodePort specifies the healthcheck nodePort for the service. This only applies when type is set to LoadBalancer and externalTrafficPolicy is set to Local. If a value is specified, is in-range, and is not in use, it will be used.  If not specified, a value will be automatically allocated.  External systems (e.g. load-balancers) can use this port to determine if a given node holds endpoints for this service or not.  If this field is specified when creating a Service which does not need it, creation will fail. This field will be wiped when updating a Service to no longer need it (e.g. changing type). This field cannot be updated once set.</summary>
    [JsonPropertyName("healthCheckNodePort")]
    public int? HealthCheckNodePort { get; set; }

    /// <summary>InternalTrafficPolicy describes how nodes distribute service traffic they receive on the ClusterIP. If set to "Local", the proxy will assume that pods only want to talk to endpoints of the service on the same node as the pod, dropping the traffic if there are no local endpoints. The default value, "Cluster", uses the standard behavior of routing to all endpoints evenly (possibly modified by topology and other features).</summary>
    [JsonPropertyName("internalTrafficPolicy")]
    public string? InternalTrafficPolicy { get; set; }

    /// <summary>IPFamilies is a list of IP families (e.g. IPv4, IPv6) assigned to this service. This field is usually assigned automatically based on cluster configuration and the ipFamilyPolicy field. If this field is specified manually, the requested family is available in the cluster, and ipFamilyPolicy allows it, it will be used; otherwise creation of the service will fail. This field is conditionally mutable: it allows for adding or removing a secondary IP family, but it does not allow changing the primary IP family of the Service. Valid values are "IPv4" and "IPv6".  This field only applies to Services of types ClusterIP, NodePort, and LoadBalancer, and does apply to "headless" services. This field will be wiped when updating a Service to type ExternalName.   This field may hold a maximum of two entries (dual-stack families, in either order).  These families must correspond to the values of the clusterIPs field, if specified. Both clusterIPs and ipFamilies are governed by the ipFamilyPolicy field.</summary>
    [JsonPropertyName("ipFamilies")]
    public IList<string>? IpFamilies { get; set; }

    /// <summary>IPFamilyPolicy represents the dual-stack-ness requested or required by this Service. If there is no value provided, then this field will be set to SingleStack. Services can be "SingleStack" (a single IP family), "PreferDualStack" (two IP families on dual-stack configured clusters or a single IP family on single-stack clusters), or "RequireDualStack" (two IP families on dual-stack configured clusters, otherwise fail). The ipFamilies and clusterIPs fields depend on the value of this field. This field will be wiped when updating a service to type ExternalName.</summary>
    [JsonPropertyName("ipFamilyPolicy")]
    public string? IpFamilyPolicy { get; set; }

    /// <summary>loadBalancerClass is the class of the load balancer implementation this Service belongs to. If specified, the value of this field must be a label-style identifier, with an optional prefix, e.g. "internal-vip" or "example.com/internal-vip". Unprefixed names are reserved for end-users. This field can only be set when the Service type is 'LoadBalancer'. If not set, the default load balancer implementation is used, today this is typically done through the cloud provider integration, but should apply for any default implementation. If set, it is assumed that a load balancer implementation is watching for Services with a matching class. Any default load balancer implementation (e.g. cloud providers) should ignore Services that set this field. This field can only be set when creating or updating a Service to type 'LoadBalancer'. Once set, it can not be changed. This field will be wiped when a service is updated to a non 'LoadBalancer' type.</summary>
    [JsonPropertyName("loadBalancerClass")]
    public string? LoadBalancerClass { get; set; }

    /// <summary>Only applies to Service Type: LoadBalancer. This feature depends on whether the underlying cloud-provider supports specifying the loadBalancerIP when a load balancer is created. This field will be ignored if the cloud-provider does not support the feature. Deprecated: This field was under-specified and its meaning varies across implementations. Using it is non-portable and it may not support dual-stack. Users are encouraged to use implementation-specific annotations when available.</summary>
    [JsonPropertyName("loadBalancerIP")]
    public string? LoadBalancerIP { get; set; }

    /// <summary>If specified and supported by the platform, this will restrict traffic through the cloud-provider load-balancer will be restricted to the specified client IPs. This field will be ignored if the cloud-provider does not support the feature." More info: https://kubernetes.io/docs/tasks/access-application-cluster/create-external-load-balancer/</summary>
    [JsonPropertyName("loadBalancerSourceRanges")]
    public IList<string>? LoadBalancerSourceRanges { get; set; }

    /// <summary>The list of ports that are exposed by this service. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies</summary>
    [JsonPropertyName("ports")]
    public IList<V1PoolerSpecServiceTemplateSpecPorts>? Ports { get; set; }

    /// <summary>publishNotReadyAddresses indicates that any agent which deals with endpoints for this Service should disregard any indications of ready/not-ready. The primary use case for setting this field is for a StatefulSet's Headless Service to propagate SRV DNS records for its Pods for the purpose of peer discovery. The Kubernetes controllers that generate Endpoints and EndpointSlice resources for Services interpret this to mean that all endpoints are considered "ready" even if the Pods themselves are not. Agents which consume only Kubernetes generated endpoints through the Endpoints or EndpointSlice resources can safely assume this behavior.</summary>
    [JsonPropertyName("publishNotReadyAddresses")]
    public bool? PublishNotReadyAddresses { get; set; }

    /// <summary>Route service traffic to pods with label keys and values matching this selector. If empty or not present, the service is assumed to have an external process managing its endpoints, which Kubernetes will not modify. Only applies to types ClusterIP, NodePort, and LoadBalancer. Ignored if type is ExternalName. More info: https://kubernetes.io/docs/concepts/services-networking/service/</summary>
    [JsonPropertyName("selector")]
    public IDictionary<string, string>? Selector { get; set; }

    /// <summary>Supports "ClientIP" and "None". Used to maintain session affinity. Enable client IP based session affinity. Must be ClientIP or None. Defaults to None. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies</summary>
    [JsonPropertyName("sessionAffinity")]
    public string? SessionAffinity { get; set; }

    /// <summary>sessionAffinityConfig contains the configurations of session affinity.</summary>
    [JsonPropertyName("sessionAffinityConfig")]
    public V1PoolerSpecServiceTemplateSpecSessionAffinityConfig? SessionAffinityConfig { get; set; }

    /// <summary>TrafficDistribution offers a way to express preferences for how traffic is distributed to Service endpoints. Implementations can use this field as a hint, but are not required to guarantee strict adherence. If the field is not set, the implementation will apply its default routing strategy. If set to "PreferClose", implementations should prioritize endpoints that are topologically close (e.g., same zone). This is an alpha field and requires enabling ServiceTrafficDistribution feature.</summary>
    [JsonPropertyName("trafficDistribution")]
    public string? TrafficDistribution { get; set; }

    /// <summary>type determines how the Service is exposed. Defaults to ClusterIP. Valid options are ExternalName, ClusterIP, NodePort, and LoadBalancer. "ClusterIP" allocates a cluster-internal IP address for load-balancing to endpoints. Endpoints are determined by the selector or if that is not specified, by manual construction of an Endpoints object or EndpointSlice objects. If clusterIP is "None", no virtual IP is allocated and the endpoints are published as a set of endpoints rather than a virtual IP. "NodePort" builds on ClusterIP and allocates a port on every node which routes to the same endpoints as the clusterIP. "LoadBalancer" builds on NodePort and creates an external load-balancer (if supported in the current cloud) which routes to the same endpoints as the clusterIP. "ExternalName" aliases this service to the specified externalName. Several other fields do not apply to ExternalName services. More info: https://kubernetes.io/docs/concepts/services-networking/service/#publishing-services-service-types</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Template for the Service to be created</summary>
public partial class V1PoolerSpecServiceTemplate
{
    /// <summary>Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1PoolerSpecServiceTemplateMetadata? Metadata { get; set; }

    /// <summary>Specification of the desired behavior of the service. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("spec")]
    public V1PoolerSpecServiceTemplateSpec? Spec { get; set; }
}

/// <summary>Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
public partial class V1PoolerSpecTemplateMetadata
{
    /// <summary>Annotations is an unstructured key value map stored with a resource that may be set by external tools to store and retrieve arbitrary metadata. They are not queryable and should be preserved when modifying objects. More info: http://kubernetes.io/docs/user-guide/annotations</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Map of string keys and values that can be used to organize and categorize (scope and select) objects. May match selectors of replication controllers and services. More info: http://kubernetes.io/docs/user-guide/labels</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The name of the resource. Only supported for certain types</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A node selector term, associated with the corresponding weight.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    /// <summary>A list of node selector requirements by node's labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PoolerSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node's fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1PoolerSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

/// <summary>An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).</summary>
public partial class V1PoolerSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A node selector term, associated with the corresponding weight.</summary>
    [JsonPropertyName("preference")]
    public V1PoolerSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

    /// <summary>Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A null or empty node selector term matches no objects. The requirements of them are ANDed. The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    /// <summary>A list of node selector requirements by node's labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PoolerSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node's fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1PoolerSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

/// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A list of node selector terms. The terms are ORed.</summary>
    [JsonPropertyName("nodeSelectorTerms")]
    public IList<V1PoolerSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

/// <summary>Describes node affinity scheduling rules for the pod.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityNodeAffinity
{
    /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node matches the corresponding matchExpressions; the node(s) with the highest sum are the most preferred.</summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1PoolerSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.</summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1PoolerSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PoolerSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PoolerSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1PoolerSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1PoolerSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1PoolerSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>weight associated with matching the corresponding podAffinityTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PoolerSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PoolerSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key &lt;topologyKey&gt; matches that of any node on which a pod of the set of pods is running</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1PoolerSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1PoolerSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAffinity
{
    /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.</summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1PoolerSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.</summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1PoolerSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PoolerSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PoolerSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1PoolerSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1PoolerSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1PoolerSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>weight associated with matching the corresponding podAffinityTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PoolerSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PoolerSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key &lt;topologyKey&gt; matches that of any node on which a pod of the set of pods is running</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1PoolerSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1PoolerSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
public partial class V1PoolerSpecTemplateSpecAffinityPodAntiAffinity
{
    /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the anti-affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling anti-affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.</summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1PoolerSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>If the anti-affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the anti-affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.</summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1PoolerSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>If specified, the pod's scheduling constraints</summary>
public partial class V1PoolerSpecTemplateSpecAffinity
{
    /// <summary>Describes node affinity scheduling rules for the pod.</summary>
    [JsonPropertyName("nodeAffinity")]
    public V1PoolerSpecTemplateSpecAffinityNodeAffinity? NodeAffinity { get; set; }

    /// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAffinity")]
    public V1PoolerSpecTemplateSpecAffinityPodAffinity? PodAffinity { get; set; }

    /// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAntiAffinity")]
    public V1PoolerSpecTemplateSpecAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

/// <summary>Selects a key of a ConfigMap.</summary>
public partial class V1PoolerSpecTemplateSpecContainersEnvValueFromConfigMapKeyRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the ConfigMap or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Selects a field of the pod: supports metadata.name, metadata.namespace, `metadata.labels['&lt;KEY&gt;']`, `metadata.annotations['&lt;KEY&gt;']`, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP, status.podIPs.</summary>
public partial class V1PoolerSpecTemplateSpecContainersEnvValueFromFieldRef
{
    /// <summary>Version of the schema the FieldPath is written in terms of, defaults to "v1".</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Path of the field to select in the specified API version.</summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}

/// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.</summary>
public partial class V1PoolerSpecTemplateSpecContainersEnvValueFromResourceFieldRef
{
    /// <summary>Container name: required for volumes, optional for env vars</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Specifies the output format of the exposed resources, defaults to "1"</summary>
    [JsonPropertyName("divisor")]
    public IntstrIntOrString? Divisor { get; set; }

    /// <summary>Required: resource to select</summary>
    [JsonPropertyName("resource")]
    public string Resource { get; set; }
}

/// <summary>Selects a key of a secret in the pod's namespace</summary>
public partial class V1PoolerSpecTemplateSpecContainersEnvValueFromSecretKeyRef
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Source for the environment variable's value. Cannot be used if value is not empty.</summary>
public partial class V1PoolerSpecTemplateSpecContainersEnvValueFrom
{
    /// <summary>Selects a key of a ConfigMap.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1PoolerSpecTemplateSpecContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary>Selects a field of the pod: supports metadata.name, metadata.namespace, `metadata.labels['&lt;KEY&gt;']`, `metadata.annotations['&lt;KEY&gt;']`, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP, status.podIPs.</summary>
    [JsonPropertyName("fieldRef")]
    public V1PoolerSpecTemplateSpecContainersEnvValueFromFieldRef? FieldRef { get; set; }

    /// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.</summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1PoolerSpecTemplateSpecContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    /// <summary>Selects a key of a secret in the pod's namespace</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1PoolerSpecTemplateSpecContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>EnvVar represents an environment variable present in a Container.</summary>
public partial class V1PoolerSpecTemplateSpecContainersEnv
{
    /// <summary>Name of the environment variable. Must be a C_IDENTIFIER.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Variable references $(VAR_NAME) are expanded using the previously defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to "".</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the environment variable's value. Cannot be used if value is not empty.</summary>
    [JsonPropertyName("valueFrom")]
    public V1PoolerSpecTemplateSpecContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary>The ConfigMap to select from</summary>
public partial class V1PoolerSpecTemplateSpecContainersEnvFromConfigMapRef
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the ConfigMap must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>The Secret to select from</summary>
public partial class V1PoolerSpecTemplateSpecContainersEnvFromSecretRef
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>EnvFromSource represents the source of a set of ConfigMaps</summary>
public partial class V1PoolerSpecTemplateSpecContainersEnvFrom
{
    /// <summary>The ConfigMap to select from</summary>
    [JsonPropertyName("configMapRef")]
    public V1PoolerSpecTemplateSpecContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary>An optional identifier to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The Secret to select from</summary>
    [JsonPropertyName("secretRef")]
    public V1PoolerSpecTemplateSpecContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary>Exec specifies the action to take.</summary>
public partial class V1PoolerSpecTemplateSpecContainersLifecyclePostStartExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
public partial class V1PoolerSpecTemplateSpecContainersLifecyclePostStartHttpGetHttpHeaders
{
    /// <summary>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>HTTPGet specifies the http request to perform.</summary>
public partial class V1PoolerSpecTemplateSpecContainersLifecyclePostStartHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1PoolerSpecTemplateSpecContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary>Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>Sleep represents the duration that the container should sleep before being terminated.</summary>
public partial class V1PoolerSpecTemplateSpecContainersLifecyclePostStartSleep
{
    /// <summary>Seconds is the number of seconds to sleep.</summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary>Deprecated. TCPSocket is NOT supported as a LifecycleHandler and kept for the backward compatibility. There are no validation of this field and lifecycle hooks will fail in runtime when tcp handler is specified.</summary>
public partial class V1PoolerSpecTemplateSpecContainersLifecyclePostStartTcpSocket
{
    /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary>PostStart is called immediately after a container is created. If the handler fails, the container is terminated and restarted according to its restart policy. Other management of the container blocks until the hook completes. More info: https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks</summary>
public partial class V1PoolerSpecTemplateSpecContainersLifecyclePostStart
{
    /// <summary>Exec specifies the action to take.</summary>
    [JsonPropertyName("exec")]
    public V1PoolerSpecTemplateSpecContainersLifecyclePostStartExec? Exec { get; set; }

    /// <summary>HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1PoolerSpecTemplateSpecContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    /// <summary>Sleep represents the duration that the container should sleep before being terminated.</summary>
    [JsonPropertyName("sleep")]
    public V1PoolerSpecTemplateSpecContainersLifecyclePostStartSleep? Sleep { get; set; }

    /// <summary>Deprecated. TCPSocket is NOT supported as a LifecycleHandler and kept for the backward compatibility. There are no validation of this field and lifecycle hooks will fail in runtime when tcp handler is specified.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1PoolerSpecTemplateSpecContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

/// <summary>Exec specifies the action to take.</summary>
public partial class V1PoolerSpecTemplateSpecContainersLifecyclePreStopExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
public partial class V1PoolerSpecTemplateSpecContainersLifecyclePreStopHttpGetHttpHeaders
{
    /// <summary>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>HTTPGet specifies the http request to perform.</summary>
public partial class V1PoolerSpecTemplateSpecContainersLifecyclePreStopHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1PoolerSpecTemplateSpecContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary>Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>Sleep represents the duration that the container should sleep before being terminated.</summary>
public partial class V1PoolerSpecTemplateSpecContainersLifecyclePreStopSleep
{
    /// <summary>Seconds is the number of seconds to sleep.</summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary>Deprecated. TCPSocket is NOT supported as a LifecycleHandler and kept for the backward compatibility. There are no validation of this field and lifecycle hooks will fail in runtime when tcp handler is specified.</summary>
public partial class V1PoolerSpecTemplateSpecContainersLifecyclePreStopTcpSocket
{
    /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary>PreStop is called immediately before a container is terminated due to an API request or management event such as liveness/startup probe failure, preemption, resource contention, etc. The handler is not called if the container crashes or exits. The Pod's termination grace period countdown begins before the PreStop hook is executed. Regardless of the outcome of the handler, the container will eventually terminate within the Pod's termination grace period (unless delayed by finalizers). Other management of the container blocks until the hook completes or until the termination grace period is reached. More info: https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks</summary>
public partial class V1PoolerSpecTemplateSpecContainersLifecyclePreStop
{
    /// <summary>Exec specifies the action to take.</summary>
    [JsonPropertyName("exec")]
    public V1PoolerSpecTemplateSpecContainersLifecyclePreStopExec? Exec { get; set; }

    /// <summary>HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1PoolerSpecTemplateSpecContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    /// <summary>Sleep represents the duration that the container should sleep before being terminated.</summary>
    [JsonPropertyName("sleep")]
    public V1PoolerSpecTemplateSpecContainersLifecyclePreStopSleep? Sleep { get; set; }

    /// <summary>Deprecated. TCPSocket is NOT supported as a LifecycleHandler and kept for the backward compatibility. There are no validation of this field and lifecycle hooks will fail in runtime when tcp handler is specified.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1PoolerSpecTemplateSpecContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

/// <summary>Actions that the management system should take in response to container lifecycle events. Cannot be updated.</summary>
public partial class V1PoolerSpecTemplateSpecContainersLifecycle
{
    /// <summary>PostStart is called immediately after a container is created. If the handler fails, the container is terminated and restarted according to its restart policy. Other management of the container blocks until the hook completes. More info: https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks</summary>
    [JsonPropertyName("postStart")]
    public V1PoolerSpecTemplateSpecContainersLifecyclePostStart? PostStart { get; set; }

    /// <summary>PreStop is called immediately before a container is terminated due to an API request or management event such as liveness/startup probe failure, preemption, resource contention, etc. The handler is not called if the container crashes or exits. The Pod's termination grace period countdown begins before the PreStop hook is executed. Regardless of the outcome of the handler, the container will eventually terminate within the Pod's termination grace period (unless delayed by finalizers). Other management of the container blocks until the hook completes or until the termination grace period is reached. More info: https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks</summary>
    [JsonPropertyName("preStop")]
    public V1PoolerSpecTemplateSpecContainersLifecyclePreStop? PreStop { get; set; }
}

/// <summary>Exec specifies the action to take.</summary>
public partial class V1PoolerSpecTemplateSpecContainersLivenessProbeExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>GRPC specifies an action involving a GRPC port.</summary>
public partial class V1PoolerSpecTemplateSpecContainersLivenessProbeGrpc
{
    /// <summary>Port number of the gRPC service. Number must be in the range 1 to 65535.</summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).   If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
public partial class V1PoolerSpecTemplateSpecContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>HTTPGet specifies the http request to perform.</summary>
public partial class V1PoolerSpecTemplateSpecContainersLivenessProbeHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1PoolerSpecTemplateSpecContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary>Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>TCPSocket specifies an action involving a TCP port.</summary>
public partial class V1PoolerSpecTemplateSpecContainersLivenessProbeTcpSocket
{
    /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
public partial class V1PoolerSpecTemplateSpecContainersLivenessProbe
{
    /// <summary>Exec specifies the action to take.</summary>
    [JsonPropertyName("exec")]
    public V1PoolerSpecTemplateSpecContainersLivenessProbeExec? Exec { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port.</summary>
    [JsonPropertyName("grpc")]
    public V1PoolerSpecTemplateSpecContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary>HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1PoolerSpecTemplateSpecContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TCPSocket specifies an action involving a TCP port.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1PoolerSpecTemplateSpecContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Optional duration in seconds the pod needs to terminate gracefully upon probe failure. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. If this value is nil, the pod's terminationGracePeriodSeconds will be used. Otherwise, this value overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). This is a beta field and requires enabling ProbeTerminationGracePeriod feature gate. Minimum value is 1. spec.terminationGracePeriodSeconds is used if unset.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>ContainerPort represents a network port in a single container.</summary>
public partial class V1PoolerSpecTemplateSpecContainersPorts
{
    /// <summary>Number of port to expose on the pod's IP address. This must be a valid port number, 0 &lt; x &lt; 65536.</summary>
    [JsonPropertyName("containerPort")]
    public int ContainerPort { get; set; }

    /// <summary>What host IP to bind the external port to.</summary>
    [JsonPropertyName("hostIP")]
    public string? HostIP { get; set; }

    /// <summary>Number of port to expose on the host. If specified, this must be a valid port number, 0 &lt; x &lt; 65536. If HostNetwork is specified, this must match ContainerPort. Most containers do not need this.</summary>
    [JsonPropertyName("hostPort")]
    public int? HostPort { get; set; }

    /// <summary>If specified, this must be an IANA_SVC_NAME and unique within the pod. Each named port in a pod must have a unique name. Name for the port that can be referred to by services.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol for port. Must be UDP, TCP, or SCTP. Defaults to "TCP".</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Exec specifies the action to take.</summary>
public partial class V1PoolerSpecTemplateSpecContainersReadinessProbeExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>GRPC specifies an action involving a GRPC port.</summary>
public partial class V1PoolerSpecTemplateSpecContainersReadinessProbeGrpc
{
    /// <summary>Port number of the gRPC service. Number must be in the range 1 to 65535.</summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).   If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
public partial class V1PoolerSpecTemplateSpecContainersReadinessProbeHttpGetHttpHeaders
{
    /// <summary>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>HTTPGet specifies the http request to perform.</summary>
public partial class V1PoolerSpecTemplateSpecContainersReadinessProbeHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1PoolerSpecTemplateSpecContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary>Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>TCPSocket specifies an action involving a TCP port.</summary>
public partial class V1PoolerSpecTemplateSpecContainersReadinessProbeTcpSocket
{
    /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary>Periodic probe of container service readiness. Container will be removed from service endpoints if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
public partial class V1PoolerSpecTemplateSpecContainersReadinessProbe
{
    /// <summary>Exec specifies the action to take.</summary>
    [JsonPropertyName("exec")]
    public V1PoolerSpecTemplateSpecContainersReadinessProbeExec? Exec { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port.</summary>
    [JsonPropertyName("grpc")]
    public V1PoolerSpecTemplateSpecContainersReadinessProbeGrpc? Grpc { get; set; }

    /// <summary>HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1PoolerSpecTemplateSpecContainersReadinessProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TCPSocket specifies an action involving a TCP port.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1PoolerSpecTemplateSpecContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Optional duration in seconds the pod needs to terminate gracefully upon probe failure. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. If this value is nil, the pod's terminationGracePeriodSeconds will be used. Otherwise, this value overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). This is a beta field and requires enabling ProbeTerminationGracePeriod feature gate. Minimum value is 1. spec.terminationGracePeriodSeconds is used if unset.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>ContainerResizePolicy represents resource resize policy for the container.</summary>
public partial class V1PoolerSpecTemplateSpecContainersResizePolicy
{
    /// <summary>Name of the resource to which this resource resize policy applies. Supported values: cpu, memory.</summary>
    [JsonPropertyName("resourceName")]
    public string ResourceName { get; set; }

    /// <summary>Restart policy to apply when specified resource is resized. If not specified, it defaults to NotRequired.</summary>
    [JsonPropertyName("restartPolicy")]
    public string RestartPolicy { get; set; }
}

/// <summary>ResourceClaim references one entry in PodSpec.ResourceClaims.</summary>
public partial class V1PoolerSpecTemplateSpecContainersResourcesClaims
{
    /// <summary>Name must match the name of one entry in pod.spec.resourceClaims of the Pod where this field is used. It makes that resource available inside a container.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Compute Resources required by this container. Cannot be updated. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
public partial class V1PoolerSpecTemplateSpecContainersResources
{
    /// <summary>Claims lists the names of resources, defined in spec.resourceClaims, that are used by this container.   This is an alpha field and requires enabling the DynamicResourceAllocation feature gate.   This field is immutable. It can only be set for containers.</summary>
    [JsonPropertyName("claims")]
    public IList<V1PoolerSpecTemplateSpecContainersResourcesClaims>? Claims { get; set; }

    /// <summary>Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, IntstrIntOrString>? Limits { get; set; }

    /// <summary>Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. Requests cannot exceed Limits. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, IntstrIntOrString>? Requests { get; set; }
}

/// <summary>appArmorProfile is the AppArmor options to use by this container. If set, this profile overrides the pod's appArmorProfile. Note that this field cannot be set when spec.os.name is windows.</summary>
public partial class V1PoolerSpecTemplateSpecContainersSecurityContextAppArmorProfile
{
    /// <summary>localhostProfile indicates a profile loaded on the node that should be used. The profile must be preconfigured on the node to work. Must match the loaded name of the profile. Must be set if and only if type is "Localhost".</summary>
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    /// <summary>type indicates which kind of AppArmor profile will be applied. Valid options are:   Localhost - a profile pre-loaded on the node.   RuntimeDefault - the container runtime's default profile.   Unconfined - no AppArmor enforcement.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>The capabilities to add/drop when running containers. Defaults to the default set of capabilities granted by the container runtime. Note that this field cannot be set when spec.os.name is windows.</summary>
public partial class V1PoolerSpecTemplateSpecContainersSecurityContextCapabilities
{
    /// <summary>Added capabilities</summary>
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    /// <summary>Removed capabilities</summary>
    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

/// <summary>The SELinux context to be applied to the container. If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.</summary>
public partial class V1PoolerSpecTemplateSpecContainersSecurityContextSeLinuxOptions
{
    /// <summary>Level is SELinux level label that applies to the container.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Role is a SELinux role label that applies to the container.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Type is a SELinux type label that applies to the container.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>User is a SELinux user label that applies to the container.</summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary>The seccomp options to use by this container. If seccomp options are provided at both the pod &amp; container level, the container options override the pod options. Note that this field cannot be set when spec.os.name is windows.</summary>
public partial class V1PoolerSpecTemplateSpecContainersSecurityContextSeccompProfile
{
    /// <summary>localhostProfile indicates a profile defined in a file on the node should be used. The profile must be preconfigured on the node to work. Must be a descending path, relative to the kubelet's configured seccomp profile location. Must be set if type is "Localhost". Must NOT be set for any other type.</summary>
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    /// <summary>type indicates which kind of seccomp profile will be applied. Valid options are:   Localhost - a profile defined in a file on the node should be used. RuntimeDefault - the container runtime default profile should be used. Unconfined - no profile should be applied.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>The Windows specific settings applied to all containers. If unspecified, the options from the PodSecurityContext will be used. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is linux.</summary>
public partial class V1PoolerSpecTemplateSpecContainersSecurityContextWindowsOptions
{
    /// <summary>GMSACredentialSpec is where the GMSA admission webhook (https://github.com/kubernetes-sigs/windows-gmsa) inlines the contents of the GMSA credential spec named by the GMSACredentialSpecName field.</summary>
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    /// <summary>GMSACredentialSpecName is the name of the GMSA credential spec to use.</summary>
    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    /// <summary>HostProcess determines if a container should be run as a 'Host Process' container. All of a Pod's containers must have the same effective HostProcess value (it is not allowed to have a mix of HostProcess containers and non-HostProcess containers). In addition, if HostProcess is true then HostNetwork must also be set to true.</summary>
    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    /// <summary>The UserName in Windows to run the entrypoint of the container process. Defaults to the user specified in image metadata if unspecified. May also be set in PodSecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</summary>
    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>SecurityContext defines the security options the container should be run with. If set, the fields of SecurityContext override the equivalent fields of PodSecurityContext. More info: https://kubernetes.io/docs/tasks/configure-pod-container/security-context/</summary>
public partial class V1PoolerSpecTemplateSpecContainersSecurityContext
{
    /// <summary>AllowPrivilegeEscalation controls whether a process can gain more privileges than its parent process. This bool directly controls if the no_new_privs flag will be set on the container process. AllowPrivilegeEscalation is true always when the container is: 1) run as Privileged 2) has CAP_SYS_ADMIN Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary>appArmorProfile is the AppArmor options to use by this container. If set, this profile overrides the pod's appArmorProfile. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("appArmorProfile")]
    public V1PoolerSpecTemplateSpecContainersSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    /// <summary>The capabilities to add/drop when running containers. Defaults to the default set of capabilities granted by the container runtime. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("capabilities")]
    public V1PoolerSpecTemplateSpecContainersSecurityContextCapabilities? Capabilities { get; set; }

    /// <summary>Run container in privileged mode. Processes in privileged containers are essentially equivalent to root on the host. Defaults to false. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    /// <summary>procMount denotes the type of proc mount to use for the containers. The default is DefaultProcMount which uses the container runtime defaults for readonly paths and masked paths. This requires the ProcMountType feature flag to be enabled. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("procMount")]
    public string? ProcMount { get; set; }

    /// <summary>Whether this container has a read-only root filesystem. Default is false. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    /// <summary>The GID to run the entrypoint of the container process. Uses runtime default if unset. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("runAsGroup")]
    public long? RunAsGroup { get; set; }

    /// <summary>Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</summary>
    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    /// <summary>The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if unspecified. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("runAsUser")]
    public long? RunAsUser { get; set; }

    /// <summary>The SELinux context to be applied to the container. If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("seLinuxOptions")]
    public V1PoolerSpecTemplateSpecContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary>The seccomp options to use by this container. If seccomp options are provided at both the pod &amp; container level, the container options override the pod options. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("seccompProfile")]
    public V1PoolerSpecTemplateSpecContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary>The Windows specific settings applied to all containers. If unspecified, the options from the PodSecurityContext will be used. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is linux.</summary>
    [JsonPropertyName("windowsOptions")]
    public V1PoolerSpecTemplateSpecContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

/// <summary>Exec specifies the action to take.</summary>
public partial class V1PoolerSpecTemplateSpecContainersStartupProbeExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>GRPC specifies an action involving a GRPC port.</summary>
public partial class V1PoolerSpecTemplateSpecContainersStartupProbeGrpc
{
    /// <summary>Port number of the gRPC service. Number must be in the range 1 to 65535.</summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).   If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
public partial class V1PoolerSpecTemplateSpecContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>HTTPGet specifies the http request to perform.</summary>
public partial class V1PoolerSpecTemplateSpecContainersStartupProbeHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1PoolerSpecTemplateSpecContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary>Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>TCPSocket specifies an action involving a TCP port.</summary>
public partial class V1PoolerSpecTemplateSpecContainersStartupProbeTcpSocket
{
    /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary>StartupProbe indicates that the Pod has successfully initialized. If specified, no other probes are executed until this completes successfully. If this probe fails, the Pod will be restarted, just as if the livenessProbe failed. This can be used to provide different probe parameters at the beginning of a Pod's lifecycle, when it might take a long time to load data or warm a cache, than during steady-state operation. This cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
public partial class V1PoolerSpecTemplateSpecContainersStartupProbe
{
    /// <summary>Exec specifies the action to take.</summary>
    [JsonPropertyName("exec")]
    public V1PoolerSpecTemplateSpecContainersStartupProbeExec? Exec { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port.</summary>
    [JsonPropertyName("grpc")]
    public V1PoolerSpecTemplateSpecContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary>HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1PoolerSpecTemplateSpecContainersStartupProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TCPSocket specifies an action involving a TCP port.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1PoolerSpecTemplateSpecContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Optional duration in seconds the pod needs to terminate gracefully upon probe failure. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. If this value is nil, the pod's terminationGracePeriodSeconds will be used. Otherwise, this value overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). This is a beta field and requires enabling ProbeTerminationGracePeriod feature gate. Minimum value is 1. spec.terminationGracePeriodSeconds is used if unset.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>volumeDevice describes a mapping of a raw block device within a container.</summary>
public partial class V1PoolerSpecTemplateSpecContainersVolumeDevices
{
    /// <summary>devicePath is the path inside of the container that the device will be mapped to.</summary>
    [JsonPropertyName("devicePath")]
    public string DevicePath { get; set; }

    /// <summary>name must match the name of a persistentVolumeClaim in the pod</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>VolumeMount describes a mounting of a Volume within a container.</summary>
public partial class V1PoolerSpecTemplateSpecContainersVolumeMounts
{
    /// <summary>Path within the container at which the volume should be mounted.  Must not contain ':'.</summary>
    [JsonPropertyName("mountPath")]
    public string MountPath { get; set; }

    /// <summary>mountPropagation determines how mounts are propagated from the host to container and the other way around. When not set, MountPropagationNone is used. This field is beta in 1.10. When RecursiveReadOnly is set to IfPossible or to Enabled, MountPropagation must be None or unspecified (which defaults to None).</summary>
    [JsonPropertyName("mountPropagation")]
    public string? MountPropagation { get; set; }

    /// <summary>This must match the Name of a Volume.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Mounted read-only if true, read-write otherwise (false or unspecified). Defaults to false.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>RecursiveReadOnly specifies whether read-only mounts should be handled recursively.   If ReadOnly is false, this field has no meaning and must be unspecified.   If ReadOnly is true, and this field is set to Disabled, the mount is not made recursively read-only.  If this field is set to IfPossible, the mount is made recursively read-only, if it is supported by the container runtime.  If this field is set to Enabled, the mount is made recursively read-only if it is supported by the container runtime, otherwise the pod will not be started and an error will be generated to indicate the reason.   If this field is set to IfPossible or Enabled, MountPropagation must be set to None (or be unspecified, which defaults to None).   If this field is not specified, it is treated as an equivalent of Disabled.</summary>
    [JsonPropertyName("recursiveReadOnly")]
    public string? RecursiveReadOnly { get; set; }

    /// <summary>Path within the volume from which the container's volume should be mounted. Defaults to "" (volume's root).</summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    /// <summary>Expanded path within the volume from which the container's volume should be mounted. Behaves similarly to SubPath but environment variable references $(VAR_NAME) are expanded using the container's environment. Defaults to "" (volume's root). SubPathExpr and SubPath are mutually exclusive.</summary>
    [JsonPropertyName("subPathExpr")]
    public string? SubPathExpr { get; set; }
}

/// <summary>A single application container that you want to run within a pod.</summary>
public partial class V1PoolerSpecTemplateSpecContainers
{
    /// <summary>Arguments to the entrypoint. The container image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint array. Not executed within a shell. The container image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>List of environment variables to set in the container. Cannot be updated.</summary>
    [JsonPropertyName("env")]
    public IList<V1PoolerSpecTemplateSpecContainersEnv>? Env { get; set; }

    /// <summary>List of sources to populate environment variables in the container. The keys defined within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Cannot be updated.</summary>
    [JsonPropertyName("envFrom")]
    public IList<V1PoolerSpecTemplateSpecContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary>Container image name. More info: https://kubernetes.io/docs/concepts/containers/images This field is optional to allow higher level config management to default or override container images in workload controllers like Deployments and StatefulSets.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images</summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary>Actions that the management system should take in response to container lifecycle events. Cannot be updated.</summary>
    [JsonPropertyName("lifecycle")]
    public V1PoolerSpecTemplateSpecContainersLifecycle? Lifecycle { get; set; }

    /// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("livenessProbe")]
    public V1PoolerSpecTemplateSpecContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Name of the container specified as a DNS_LABEL. Each container in a pod must have a unique name (DNS_LABEL). Cannot be updated.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>List of ports to expose from the container. Not specifying a port here DOES NOT prevent that port from being exposed. Any port which is listening on the default "0.0.0.0" address inside a container will be accessible from the network. Modifying this array with strategic merge patch may corrupt the data. For more information See https://github.com/kubernetes/kubernetes/issues/108255. Cannot be updated.</summary>
    [JsonPropertyName("ports")]
    public IList<V1PoolerSpecTemplateSpecContainersPorts>? Ports { get; set; }

    /// <summary>Periodic probe of container service readiness. Container will be removed from service endpoints if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("readinessProbe")]
    public V1PoolerSpecTemplateSpecContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary>Resources resize policy for the container.</summary>
    [JsonPropertyName("resizePolicy")]
    public IList<V1PoolerSpecTemplateSpecContainersResizePolicy>? ResizePolicy { get; set; }

    /// <summary>Compute Resources required by this container. Cannot be updated. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("resources")]
    public V1PoolerSpecTemplateSpecContainersResources? Resources { get; set; }

    /// <summary>RestartPolicy defines the restart behavior of individual containers in a pod. This field may only be set for init containers, and the only allowed value is "Always". For non-init containers or when this field is not specified, the restart behavior is defined by the Pod's restart policy and the container type. Setting the RestartPolicy as "Always" for the init container will have the following effect: this init container will be continually restarted on exit until all regular containers have terminated. Once all regular containers have completed, all init containers with restartPolicy "Always" will be shut down. This lifecycle differs from normal init containers and is often referred to as a "sidecar" container. Although this init container still starts in the init container sequence, it does not wait for the container to complete before proceeding to the next init container. Instead, the next init container starts immediately after this init container is started, or after any startupProbe has successfully completed.</summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary>SecurityContext defines the security options the container should be run with. If set, the fields of SecurityContext override the equivalent fields of PodSecurityContext. More info: https://kubernetes.io/docs/tasks/configure-pod-container/security-context/</summary>
    [JsonPropertyName("securityContext")]
    public V1PoolerSpecTemplateSpecContainersSecurityContext? SecurityContext { get; set; }

    /// <summary>StartupProbe indicates that the Pod has successfully initialized. If specified, no other probes are executed until this completes successfully. If this probe fails, the Pod will be restarted, just as if the livenessProbe failed. This can be used to provide different probe parameters at the beginning of a Pod's lifecycle, when it might take a long time to load data or warm a cache, than during steady-state operation. This cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("startupProbe")]
    public V1PoolerSpecTemplateSpecContainersStartupProbe? StartupProbe { get; set; }

    /// <summary>Whether this container should allocate a buffer for stdin in the container runtime. If this is not set, reads from stdin in the container will always result in EOF. Default is false.</summary>
    [JsonPropertyName("stdin")]
    public bool? Stdin { get; set; }

    /// <summary>Whether the container runtime should close the stdin channel after it has been opened by a single attach. When stdin is true the stdin stream will remain open across multiple attach sessions. If stdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and accepts data until the client disconnects, at which time stdin is closed and remains closed until the container is restarted. If this flag is false, a container processes that reads from stdin will never receive an EOF. Default is false</summary>
    [JsonPropertyName("stdinOnce")]
    public bool? StdinOnce { get; set; }

    /// <summary>Optional: Path at which the file to which the container's termination message will be written is mounted into the container's filesystem. Message written is intended to be brief final status, such as an assertion failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across all containers will be limited to 12kb. Defaults to /dev/termination-log. Cannot be updated.</summary>
    [JsonPropertyName("terminationMessagePath")]
    public string? TerminationMessagePath { get; set; }

    /// <summary>Indicate how the termination message should be populated. File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated.</summary>
    [JsonPropertyName("terminationMessagePolicy")]
    public string? TerminationMessagePolicy { get; set; }

    /// <summary>Whether this container should allocate a TTY for itself, also requires 'stdin' to be true. Default is false.</summary>
    [JsonPropertyName("tty")]
    public bool? Tty { get; set; }

    /// <summary>volumeDevices is the list of block devices to be used by the container.</summary>
    [JsonPropertyName("volumeDevices")]
    public IList<V1PoolerSpecTemplateSpecContainersVolumeDevices>? VolumeDevices { get; set; }

    /// <summary>Pod volumes to mount into the container's filesystem. Cannot be updated.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1PoolerSpecTemplateSpecContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary>Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image. Cannot be updated.</summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary>PodDNSConfigOption defines DNS resolver options of a pod.</summary>
public partial class V1PoolerSpecTemplateSpecDnsConfigOptions
{
    /// <summary>Required.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Specifies the DNS parameters of a pod. Parameters specified here will be merged to the generated DNS configuration based on DNSPolicy.</summary>
public partial class V1PoolerSpecTemplateSpecDnsConfig
{
    /// <summary>A list of DNS name server IP addresses. This will be appended to the base nameservers generated from DNSPolicy. Duplicated nameservers will be removed.</summary>
    [JsonPropertyName("nameservers")]
    public IList<string>? Nameservers { get; set; }

    /// <summary>A list of DNS resolver options. This will be merged with the base options generated from DNSPolicy. Duplicated entries will be removed. Resolution options given in Options will override those that appear in the base DNSPolicy.</summary>
    [JsonPropertyName("options")]
    public IList<V1PoolerSpecTemplateSpecDnsConfigOptions>? Options { get; set; }

    /// <summary>A list of DNS search domains for host-name lookup. This will be appended to the base search paths generated from DNSPolicy. Duplicated search paths will be removed.</summary>
    [JsonPropertyName("searches")]
    public IList<string>? Searches { get; set; }
}

/// <summary>Selects a key of a ConfigMap.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersEnvValueFromConfigMapKeyRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the ConfigMap or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Selects a field of the pod: supports metadata.name, metadata.namespace, `metadata.labels['&lt;KEY&gt;']`, `metadata.annotations['&lt;KEY&gt;']`, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP, status.podIPs.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersEnvValueFromFieldRef
{
    /// <summary>Version of the schema the FieldPath is written in terms of, defaults to "v1".</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Path of the field to select in the specified API version.</summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}

/// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersEnvValueFromResourceFieldRef
{
    /// <summary>Container name: required for volumes, optional for env vars</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Specifies the output format of the exposed resources, defaults to "1"</summary>
    [JsonPropertyName("divisor")]
    public IntstrIntOrString? Divisor { get; set; }

    /// <summary>Required: resource to select</summary>
    [JsonPropertyName("resource")]
    public string Resource { get; set; }
}

/// <summary>Selects a key of a secret in the pod's namespace</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersEnvValueFromSecretKeyRef
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Source for the environment variable's value. Cannot be used if value is not empty.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersEnvValueFrom
{
    /// <summary>Selects a key of a ConfigMap.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1PoolerSpecTemplateSpecEphemeralContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary>Selects a field of the pod: supports metadata.name, metadata.namespace, `metadata.labels['&lt;KEY&gt;']`, `metadata.annotations['&lt;KEY&gt;']`, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP, status.podIPs.</summary>
    [JsonPropertyName("fieldRef")]
    public V1PoolerSpecTemplateSpecEphemeralContainersEnvValueFromFieldRef? FieldRef { get; set; }

    /// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.</summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1PoolerSpecTemplateSpecEphemeralContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    /// <summary>Selects a key of a secret in the pod's namespace</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1PoolerSpecTemplateSpecEphemeralContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>EnvVar represents an environment variable present in a Container.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersEnv
{
    /// <summary>Name of the environment variable. Must be a C_IDENTIFIER.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Variable references $(VAR_NAME) are expanded using the previously defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to "".</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the environment variable's value. Cannot be used if value is not empty.</summary>
    [JsonPropertyName("valueFrom")]
    public V1PoolerSpecTemplateSpecEphemeralContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary>The ConfigMap to select from</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersEnvFromConfigMapRef
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the ConfigMap must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>The Secret to select from</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersEnvFromSecretRef
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>EnvFromSource represents the source of a set of ConfigMaps</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersEnvFrom
{
    /// <summary>The ConfigMap to select from</summary>
    [JsonPropertyName("configMapRef")]
    public V1PoolerSpecTemplateSpecEphemeralContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary>An optional identifier to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The Secret to select from</summary>
    [JsonPropertyName("secretRef")]
    public V1PoolerSpecTemplateSpecEphemeralContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary>Exec specifies the action to take.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePostStartExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGetHttpHeaders
{
    /// <summary>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>HTTPGet specifies the http request to perform.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary>Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>Sleep represents the duration that the container should sleep before being terminated.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePostStartSleep
{
    /// <summary>Seconds is the number of seconds to sleep.</summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary>Deprecated. TCPSocket is NOT supported as a LifecycleHandler and kept for the backward compatibility. There are no validation of this field and lifecycle hooks will fail in runtime when tcp handler is specified.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePostStartTcpSocket
{
    /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary>PostStart is called immediately after a container is created. If the handler fails, the container is terminated and restarted according to its restart policy. Other management of the container blocks until the hook completes. More info: https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePostStart
{
    /// <summary>Exec specifies the action to take.</summary>
    [JsonPropertyName("exec")]
    public V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePostStartExec? Exec { get; set; }

    /// <summary>HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    /// <summary>Sleep represents the duration that the container should sleep before being terminated.</summary>
    [JsonPropertyName("sleep")]
    public V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePostStartSleep? Sleep { get; set; }

    /// <summary>Deprecated. TCPSocket is NOT supported as a LifecycleHandler and kept for the backward compatibility. There are no validation of this field and lifecycle hooks will fail in runtime when tcp handler is specified.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

/// <summary>Exec specifies the action to take.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePreStopExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGetHttpHeaders
{
    /// <summary>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>HTTPGet specifies the http request to perform.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary>Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>Sleep represents the duration that the container should sleep before being terminated.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePreStopSleep
{
    /// <summary>Seconds is the number of seconds to sleep.</summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary>Deprecated. TCPSocket is NOT supported as a LifecycleHandler and kept for the backward compatibility. There are no validation of this field and lifecycle hooks will fail in runtime when tcp handler is specified.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePreStopTcpSocket
{
    /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary>PreStop is called immediately before a container is terminated due to an API request or management event such as liveness/startup probe failure, preemption, resource contention, etc. The handler is not called if the container crashes or exits. The Pod's termination grace period countdown begins before the PreStop hook is executed. Regardless of the outcome of the handler, the container will eventually terminate within the Pod's termination grace period (unless delayed by finalizers). Other management of the container blocks until the hook completes or until the termination grace period is reached. More info: https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePreStop
{
    /// <summary>Exec specifies the action to take.</summary>
    [JsonPropertyName("exec")]
    public V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePreStopExec? Exec { get; set; }

    /// <summary>HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    /// <summary>Sleep represents the duration that the container should sleep before being terminated.</summary>
    [JsonPropertyName("sleep")]
    public V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePreStopSleep? Sleep { get; set; }

    /// <summary>Deprecated. TCPSocket is NOT supported as a LifecycleHandler and kept for the backward compatibility. There are no validation of this field and lifecycle hooks will fail in runtime when tcp handler is specified.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

/// <summary>Lifecycle is not allowed for ephemeral containers.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersLifecycle
{
    /// <summary>PostStart is called immediately after a container is created. If the handler fails, the container is terminated and restarted according to its restart policy. Other management of the container blocks until the hook completes. More info: https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks</summary>
    [JsonPropertyName("postStart")]
    public V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePostStart? PostStart { get; set; }

    /// <summary>PreStop is called immediately before a container is terminated due to an API request or management event such as liveness/startup probe failure, preemption, resource contention, etc. The handler is not called if the container crashes or exits. The Pod's termination grace period countdown begins before the PreStop hook is executed. Regardless of the outcome of the handler, the container will eventually terminate within the Pod's termination grace period (unless delayed by finalizers). Other management of the container blocks until the hook completes or until the termination grace period is reached. More info: https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks</summary>
    [JsonPropertyName("preStop")]
    public V1PoolerSpecTemplateSpecEphemeralContainersLifecyclePreStop? PreStop { get; set; }
}

/// <summary>Exec specifies the action to take.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersLivenessProbeExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>GRPC specifies an action involving a GRPC port.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersLivenessProbeGrpc
{
    /// <summary>Port number of the gRPC service. Number must be in the range 1 to 65535.</summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).   If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>HTTPGet specifies the http request to perform.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersLivenessProbeHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1PoolerSpecTemplateSpecEphemeralContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary>Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>TCPSocket specifies an action involving a TCP port.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersLivenessProbeTcpSocket
{
    /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary>Probes are not allowed for ephemeral containers.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersLivenessProbe
{
    /// <summary>Exec specifies the action to take.</summary>
    [JsonPropertyName("exec")]
    public V1PoolerSpecTemplateSpecEphemeralContainersLivenessProbeExec? Exec { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port.</summary>
    [JsonPropertyName("grpc")]
    public V1PoolerSpecTemplateSpecEphemeralContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary>HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1PoolerSpecTemplateSpecEphemeralContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TCPSocket specifies an action involving a TCP port.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1PoolerSpecTemplateSpecEphemeralContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Optional duration in seconds the pod needs to terminate gracefully upon probe failure. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. If this value is nil, the pod's terminationGracePeriodSeconds will be used. Otherwise, this value overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). This is a beta field and requires enabling ProbeTerminationGracePeriod feature gate. Minimum value is 1. spec.terminationGracePeriodSeconds is used if unset.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>ContainerPort represents a network port in a single container.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersPorts
{
    /// <summary>Number of port to expose on the pod's IP address. This must be a valid port number, 0 &lt; x &lt; 65536.</summary>
    [JsonPropertyName("containerPort")]
    public int ContainerPort { get; set; }

    /// <summary>What host IP to bind the external port to.</summary>
    [JsonPropertyName("hostIP")]
    public string? HostIP { get; set; }

    /// <summary>Number of port to expose on the host. If specified, this must be a valid port number, 0 &lt; x &lt; 65536. If HostNetwork is specified, this must match ContainerPort. Most containers do not need this.</summary>
    [JsonPropertyName("hostPort")]
    public int? HostPort { get; set; }

    /// <summary>If specified, this must be an IANA_SVC_NAME and unique within the pod. Each named port in a pod must have a unique name. Name for the port that can be referred to by services.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol for port. Must be UDP, TCP, or SCTP. Defaults to "TCP".</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Exec specifies the action to take.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersReadinessProbeExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>GRPC specifies an action involving a GRPC port.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersReadinessProbeGrpc
{
    /// <summary>Port number of the gRPC service. Number must be in the range 1 to 65535.</summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).   If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersReadinessProbeHttpGetHttpHeaders
{
    /// <summary>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>HTTPGet specifies the http request to perform.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersReadinessProbeHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1PoolerSpecTemplateSpecEphemeralContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary>Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>TCPSocket specifies an action involving a TCP port.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersReadinessProbeTcpSocket
{
    /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary>Probes are not allowed for ephemeral containers.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersReadinessProbe
{
    /// <summary>Exec specifies the action to take.</summary>
    [JsonPropertyName("exec")]
    public V1PoolerSpecTemplateSpecEphemeralContainersReadinessProbeExec? Exec { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port.</summary>
    [JsonPropertyName("grpc")]
    public V1PoolerSpecTemplateSpecEphemeralContainersReadinessProbeGrpc? Grpc { get; set; }

    /// <summary>HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1PoolerSpecTemplateSpecEphemeralContainersReadinessProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TCPSocket specifies an action involving a TCP port.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1PoolerSpecTemplateSpecEphemeralContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Optional duration in seconds the pod needs to terminate gracefully upon probe failure. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. If this value is nil, the pod's terminationGracePeriodSeconds will be used. Otherwise, this value overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). This is a beta field and requires enabling ProbeTerminationGracePeriod feature gate. Minimum value is 1. spec.terminationGracePeriodSeconds is used if unset.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>ContainerResizePolicy represents resource resize policy for the container.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersResizePolicy
{
    /// <summary>Name of the resource to which this resource resize policy applies. Supported values: cpu, memory.</summary>
    [JsonPropertyName("resourceName")]
    public string ResourceName { get; set; }

    /// <summary>Restart policy to apply when specified resource is resized. If not specified, it defaults to NotRequired.</summary>
    [JsonPropertyName("restartPolicy")]
    public string RestartPolicy { get; set; }
}

/// <summary>ResourceClaim references one entry in PodSpec.ResourceClaims.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersResourcesClaims
{
    /// <summary>Name must match the name of one entry in pod.spec.resourceClaims of the Pod where this field is used. It makes that resource available inside a container.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Resources are not allowed for ephemeral containers. Ephemeral containers use spare resources already allocated to the pod.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersResources
{
    /// <summary>Claims lists the names of resources, defined in spec.resourceClaims, that are used by this container.   This is an alpha field and requires enabling the DynamicResourceAllocation feature gate.   This field is immutable. It can only be set for containers.</summary>
    [JsonPropertyName("claims")]
    public IList<V1PoolerSpecTemplateSpecEphemeralContainersResourcesClaims>? Claims { get; set; }

    /// <summary>Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, IntstrIntOrString>? Limits { get; set; }

    /// <summary>Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. Requests cannot exceed Limits. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, IntstrIntOrString>? Requests { get; set; }
}

/// <summary>appArmorProfile is the AppArmor options to use by this container. If set, this profile overrides the pod's appArmorProfile. Note that this field cannot be set when spec.os.name is windows.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersSecurityContextAppArmorProfile
{
    /// <summary>localhostProfile indicates a profile loaded on the node that should be used. The profile must be preconfigured on the node to work. Must match the loaded name of the profile. Must be set if and only if type is "Localhost".</summary>
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    /// <summary>type indicates which kind of AppArmor profile will be applied. Valid options are:   Localhost - a profile pre-loaded on the node.   RuntimeDefault - the container runtime's default profile.   Unconfined - no AppArmor enforcement.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>The capabilities to add/drop when running containers. Defaults to the default set of capabilities granted by the container runtime. Note that this field cannot be set when spec.os.name is windows.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersSecurityContextCapabilities
{
    /// <summary>Added capabilities</summary>
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    /// <summary>Removed capabilities</summary>
    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

/// <summary>The SELinux context to be applied to the container. If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersSecurityContextSeLinuxOptions
{
    /// <summary>Level is SELinux level label that applies to the container.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Role is a SELinux role label that applies to the container.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Type is a SELinux type label that applies to the container.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>User is a SELinux user label that applies to the container.</summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary>The seccomp options to use by this container. If seccomp options are provided at both the pod &amp; container level, the container options override the pod options. Note that this field cannot be set when spec.os.name is windows.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersSecurityContextSeccompProfile
{
    /// <summary>localhostProfile indicates a profile defined in a file on the node should be used. The profile must be preconfigured on the node to work. Must be a descending path, relative to the kubelet's configured seccomp profile location. Must be set if type is "Localhost". Must NOT be set for any other type.</summary>
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    /// <summary>type indicates which kind of seccomp profile will be applied. Valid options are:   Localhost - a profile defined in a file on the node should be used. RuntimeDefault - the container runtime default profile should be used. Unconfined - no profile should be applied.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>The Windows specific settings applied to all containers. If unspecified, the options from the PodSecurityContext will be used. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is linux.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersSecurityContextWindowsOptions
{
    /// <summary>GMSACredentialSpec is where the GMSA admission webhook (https://github.com/kubernetes-sigs/windows-gmsa) inlines the contents of the GMSA credential spec named by the GMSACredentialSpecName field.</summary>
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    /// <summary>GMSACredentialSpecName is the name of the GMSA credential spec to use.</summary>
    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    /// <summary>HostProcess determines if a container should be run as a 'Host Process' container. All of a Pod's containers must have the same effective HostProcess value (it is not allowed to have a mix of HostProcess containers and non-HostProcess containers). In addition, if HostProcess is true then HostNetwork must also be set to true.</summary>
    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    /// <summary>The UserName in Windows to run the entrypoint of the container process. Defaults to the user specified in image metadata if unspecified. May also be set in PodSecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</summary>
    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>Optional: SecurityContext defines the security options the ephemeral container should be run with. If set, the fields of SecurityContext override the equivalent fields of PodSecurityContext.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersSecurityContext
{
    /// <summary>AllowPrivilegeEscalation controls whether a process can gain more privileges than its parent process. This bool directly controls if the no_new_privs flag will be set on the container process. AllowPrivilegeEscalation is true always when the container is: 1) run as Privileged 2) has CAP_SYS_ADMIN Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary>appArmorProfile is the AppArmor options to use by this container. If set, this profile overrides the pod's appArmorProfile. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("appArmorProfile")]
    public V1PoolerSpecTemplateSpecEphemeralContainersSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    /// <summary>The capabilities to add/drop when running containers. Defaults to the default set of capabilities granted by the container runtime. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("capabilities")]
    public V1PoolerSpecTemplateSpecEphemeralContainersSecurityContextCapabilities? Capabilities { get; set; }

    /// <summary>Run container in privileged mode. Processes in privileged containers are essentially equivalent to root on the host. Defaults to false. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    /// <summary>procMount denotes the type of proc mount to use for the containers. The default is DefaultProcMount which uses the container runtime defaults for readonly paths and masked paths. This requires the ProcMountType feature flag to be enabled. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("procMount")]
    public string? ProcMount { get; set; }

    /// <summary>Whether this container has a read-only root filesystem. Default is false. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    /// <summary>The GID to run the entrypoint of the container process. Uses runtime default if unset. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("runAsGroup")]
    public long? RunAsGroup { get; set; }

    /// <summary>Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</summary>
    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    /// <summary>The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if unspecified. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("runAsUser")]
    public long? RunAsUser { get; set; }

    /// <summary>The SELinux context to be applied to the container. If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("seLinuxOptions")]
    public V1PoolerSpecTemplateSpecEphemeralContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary>The seccomp options to use by this container. If seccomp options are provided at both the pod &amp; container level, the container options override the pod options. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("seccompProfile")]
    public V1PoolerSpecTemplateSpecEphemeralContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary>The Windows specific settings applied to all containers. If unspecified, the options from the PodSecurityContext will be used. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is linux.</summary>
    [JsonPropertyName("windowsOptions")]
    public V1PoolerSpecTemplateSpecEphemeralContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

/// <summary>Exec specifies the action to take.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersStartupProbeExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>GRPC specifies an action involving a GRPC port.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersStartupProbeGrpc
{
    /// <summary>Port number of the gRPC service. Number must be in the range 1 to 65535.</summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).   If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>HTTPGet specifies the http request to perform.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersStartupProbeHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1PoolerSpecTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary>Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>TCPSocket specifies an action involving a TCP port.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersStartupProbeTcpSocket
{
    /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary>Probes are not allowed for ephemeral containers.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersStartupProbe
{
    /// <summary>Exec specifies the action to take.</summary>
    [JsonPropertyName("exec")]
    public V1PoolerSpecTemplateSpecEphemeralContainersStartupProbeExec? Exec { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port.</summary>
    [JsonPropertyName("grpc")]
    public V1PoolerSpecTemplateSpecEphemeralContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary>HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1PoolerSpecTemplateSpecEphemeralContainersStartupProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TCPSocket specifies an action involving a TCP port.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1PoolerSpecTemplateSpecEphemeralContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Optional duration in seconds the pod needs to terminate gracefully upon probe failure. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. If this value is nil, the pod's terminationGracePeriodSeconds will be used. Otherwise, this value overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). This is a beta field and requires enabling ProbeTerminationGracePeriod feature gate. Minimum value is 1. spec.terminationGracePeriodSeconds is used if unset.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>volumeDevice describes a mapping of a raw block device within a container.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersVolumeDevices
{
    /// <summary>devicePath is the path inside of the container that the device will be mapped to.</summary>
    [JsonPropertyName("devicePath")]
    public string DevicePath { get; set; }

    /// <summary>name must match the name of a persistentVolumeClaim in the pod</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>VolumeMount describes a mounting of a Volume within a container.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainersVolumeMounts
{
    /// <summary>Path within the container at which the volume should be mounted.  Must not contain ':'.</summary>
    [JsonPropertyName("mountPath")]
    public string MountPath { get; set; }

    /// <summary>mountPropagation determines how mounts are propagated from the host to container and the other way around. When not set, MountPropagationNone is used. This field is beta in 1.10. When RecursiveReadOnly is set to IfPossible or to Enabled, MountPropagation must be None or unspecified (which defaults to None).</summary>
    [JsonPropertyName("mountPropagation")]
    public string? MountPropagation { get; set; }

    /// <summary>This must match the Name of a Volume.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Mounted read-only if true, read-write otherwise (false or unspecified). Defaults to false.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>RecursiveReadOnly specifies whether read-only mounts should be handled recursively.   If ReadOnly is false, this field has no meaning and must be unspecified.   If ReadOnly is true, and this field is set to Disabled, the mount is not made recursively read-only.  If this field is set to IfPossible, the mount is made recursively read-only, if it is supported by the container runtime.  If this field is set to Enabled, the mount is made recursively read-only if it is supported by the container runtime, otherwise the pod will not be started and an error will be generated to indicate the reason.   If this field is set to IfPossible or Enabled, MountPropagation must be set to None (or be unspecified, which defaults to None).   If this field is not specified, it is treated as an equivalent of Disabled.</summary>
    [JsonPropertyName("recursiveReadOnly")]
    public string? RecursiveReadOnly { get; set; }

    /// <summary>Path within the volume from which the container's volume should be mounted. Defaults to "" (volume's root).</summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    /// <summary>Expanded path within the volume from which the container's volume should be mounted. Behaves similarly to SubPath but environment variable references $(VAR_NAME) are expanded using the container's environment. Defaults to "" (volume's root). SubPathExpr and SubPath are mutually exclusive.</summary>
    [JsonPropertyName("subPathExpr")]
    public string? SubPathExpr { get; set; }
}

/// <summary>An EphemeralContainer is a temporary container that you may add to an existing Pod for user-initiated activities such as debugging. Ephemeral containers have no resource or scheduling guarantees, and they will not be restarted when they exit or when a Pod is removed or restarted. The kubelet may evict a Pod if an ephemeral container causes the Pod to exceed its resource allocation.   To add an ephemeral container, use the ephemeralcontainers subresource of an existing Pod. Ephemeral containers may not be removed or restarted.</summary>
public partial class V1PoolerSpecTemplateSpecEphemeralContainers
{
    /// <summary>Arguments to the entrypoint. The image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint array. Not executed within a shell. The image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>List of environment variables to set in the container. Cannot be updated.</summary>
    [JsonPropertyName("env")]
    public IList<V1PoolerSpecTemplateSpecEphemeralContainersEnv>? Env { get; set; }

    /// <summary>List of sources to populate environment variables in the container. The keys defined within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Cannot be updated.</summary>
    [JsonPropertyName("envFrom")]
    public IList<V1PoolerSpecTemplateSpecEphemeralContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary>Container image name. More info: https://kubernetes.io/docs/concepts/containers/images</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images</summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary>Lifecycle is not allowed for ephemeral containers.</summary>
    [JsonPropertyName("lifecycle")]
    public V1PoolerSpecTemplateSpecEphemeralContainersLifecycle? Lifecycle { get; set; }

    /// <summary>Probes are not allowed for ephemeral containers.</summary>
    [JsonPropertyName("livenessProbe")]
    public V1PoolerSpecTemplateSpecEphemeralContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Name of the ephemeral container specified as a DNS_LABEL. This name must be unique among all containers, init containers and ephemeral containers.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Ports are not allowed for ephemeral containers.</summary>
    [JsonPropertyName("ports")]
    public IList<V1PoolerSpecTemplateSpecEphemeralContainersPorts>? Ports { get; set; }

    /// <summary>Probes are not allowed for ephemeral containers.</summary>
    [JsonPropertyName("readinessProbe")]
    public V1PoolerSpecTemplateSpecEphemeralContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary>Resources resize policy for the container.</summary>
    [JsonPropertyName("resizePolicy")]
    public IList<V1PoolerSpecTemplateSpecEphemeralContainersResizePolicy>? ResizePolicy { get; set; }

    /// <summary>Resources are not allowed for ephemeral containers. Ephemeral containers use spare resources already allocated to the pod.</summary>
    [JsonPropertyName("resources")]
    public V1PoolerSpecTemplateSpecEphemeralContainersResources? Resources { get; set; }

    /// <summary>Restart policy for the container to manage the restart behavior of each container within a pod. This may only be set for init containers. You cannot set this field on ephemeral containers.</summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary>Optional: SecurityContext defines the security options the ephemeral container should be run with. If set, the fields of SecurityContext override the equivalent fields of PodSecurityContext.</summary>
    [JsonPropertyName("securityContext")]
    public V1PoolerSpecTemplateSpecEphemeralContainersSecurityContext? SecurityContext { get; set; }

    /// <summary>Probes are not allowed for ephemeral containers.</summary>
    [JsonPropertyName("startupProbe")]
    public V1PoolerSpecTemplateSpecEphemeralContainersStartupProbe? StartupProbe { get; set; }

    /// <summary>Whether this container should allocate a buffer for stdin in the container runtime. If this is not set, reads from stdin in the container will always result in EOF. Default is false.</summary>
    [JsonPropertyName("stdin")]
    public bool? Stdin { get; set; }

    /// <summary>Whether the container runtime should close the stdin channel after it has been opened by a single attach. When stdin is true the stdin stream will remain open across multiple attach sessions. If stdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and accepts data until the client disconnects, at which time stdin is closed and remains closed until the container is restarted. If this flag is false, a container processes that reads from stdin will never receive an EOF. Default is false</summary>
    [JsonPropertyName("stdinOnce")]
    public bool? StdinOnce { get; set; }

    /// <summary>If set, the name of the container from PodSpec that this ephemeral container targets. The ephemeral container will be run in the namespaces (IPC, PID, etc) of this container. If not set then the ephemeral container uses the namespaces configured in the Pod spec.   The container runtime must implement support for this feature. If the runtime does not support namespace targeting then the result of setting this field is undefined.</summary>
    [JsonPropertyName("targetContainerName")]
    public string? TargetContainerName { get; set; }

    /// <summary>Optional: Path at which the file to which the container's termination message will be written is mounted into the container's filesystem. Message written is intended to be brief final status, such as an assertion failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across all containers will be limited to 12kb. Defaults to /dev/termination-log. Cannot be updated.</summary>
    [JsonPropertyName("terminationMessagePath")]
    public string? TerminationMessagePath { get; set; }

    /// <summary>Indicate how the termination message should be populated. File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated.</summary>
    [JsonPropertyName("terminationMessagePolicy")]
    public string? TerminationMessagePolicy { get; set; }

    /// <summary>Whether this container should allocate a TTY for itself, also requires 'stdin' to be true. Default is false.</summary>
    [JsonPropertyName("tty")]
    public bool? Tty { get; set; }

    /// <summary>volumeDevices is the list of block devices to be used by the container.</summary>
    [JsonPropertyName("volumeDevices")]
    public IList<V1PoolerSpecTemplateSpecEphemeralContainersVolumeDevices>? VolumeDevices { get; set; }

    /// <summary>Pod volumes to mount into the container's filesystem. Subpath mounts are not allowed for ephemeral containers. Cannot be updated.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1PoolerSpecTemplateSpecEphemeralContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary>Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image. Cannot be updated.</summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary>HostAlias holds the mapping between IP and hostnames that will be injected as an entry in the pod's hosts file.</summary>
public partial class V1PoolerSpecTemplateSpecHostAliases
{
    /// <summary>Hostnames for the above IP address.</summary>
    [JsonPropertyName("hostnames")]
    public IList<string>? Hostnames { get; set; }

    /// <summary>IP address of the host file entry.</summary>
    [JsonPropertyName("ip")]
    public string Ip { get; set; }
}

/// <summary>LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.</summary>
public partial class V1PoolerSpecTemplateSpecImagePullSecrets
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Selects a key of a ConfigMap.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersEnvValueFromConfigMapKeyRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the ConfigMap or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Selects a field of the pod: supports metadata.name, metadata.namespace, `metadata.labels['&lt;KEY&gt;']`, `metadata.annotations['&lt;KEY&gt;']`, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP, status.podIPs.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersEnvValueFromFieldRef
{
    /// <summary>Version of the schema the FieldPath is written in terms of, defaults to "v1".</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Path of the field to select in the specified API version.</summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}

/// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersEnvValueFromResourceFieldRef
{
    /// <summary>Container name: required for volumes, optional for env vars</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Specifies the output format of the exposed resources, defaults to "1"</summary>
    [JsonPropertyName("divisor")]
    public IntstrIntOrString? Divisor { get; set; }

    /// <summary>Required: resource to select</summary>
    [JsonPropertyName("resource")]
    public string Resource { get; set; }
}

/// <summary>Selects a key of a secret in the pod's namespace</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersEnvValueFromSecretKeyRef
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Source for the environment variable's value. Cannot be used if value is not empty.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersEnvValueFrom
{
    /// <summary>Selects a key of a ConfigMap.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1PoolerSpecTemplateSpecInitContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary>Selects a field of the pod: supports metadata.name, metadata.namespace, `metadata.labels['&lt;KEY&gt;']`, `metadata.annotations['&lt;KEY&gt;']`, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP, status.podIPs.</summary>
    [JsonPropertyName("fieldRef")]
    public V1PoolerSpecTemplateSpecInitContainersEnvValueFromFieldRef? FieldRef { get; set; }

    /// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.</summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1PoolerSpecTemplateSpecInitContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    /// <summary>Selects a key of a secret in the pod's namespace</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1PoolerSpecTemplateSpecInitContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>EnvVar represents an environment variable present in a Container.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersEnv
{
    /// <summary>Name of the environment variable. Must be a C_IDENTIFIER.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Variable references $(VAR_NAME) are expanded using the previously defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to "".</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the environment variable's value. Cannot be used if value is not empty.</summary>
    [JsonPropertyName("valueFrom")]
    public V1PoolerSpecTemplateSpecInitContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary>The ConfigMap to select from</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersEnvFromConfigMapRef
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the ConfigMap must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>The Secret to select from</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersEnvFromSecretRef
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>EnvFromSource represents the source of a set of ConfigMaps</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersEnvFrom
{
    /// <summary>The ConfigMap to select from</summary>
    [JsonPropertyName("configMapRef")]
    public V1PoolerSpecTemplateSpecInitContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary>An optional identifier to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The Secret to select from</summary>
    [JsonPropertyName("secretRef")]
    public V1PoolerSpecTemplateSpecInitContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary>Exec specifies the action to take.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersLifecyclePostStartExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeaders
{
    /// <summary>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>HTTPGet specifies the http request to perform.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersLifecyclePostStartHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1PoolerSpecTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary>Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>Sleep represents the duration that the container should sleep before being terminated.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersLifecyclePostStartSleep
{
    /// <summary>Seconds is the number of seconds to sleep.</summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary>Deprecated. TCPSocket is NOT supported as a LifecycleHandler and kept for the backward compatibility. There are no validation of this field and lifecycle hooks will fail in runtime when tcp handler is specified.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersLifecyclePostStartTcpSocket
{
    /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary>PostStart is called immediately after a container is created. If the handler fails, the container is terminated and restarted according to its restart policy. Other management of the container blocks until the hook completes. More info: https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersLifecyclePostStart
{
    /// <summary>Exec specifies the action to take.</summary>
    [JsonPropertyName("exec")]
    public V1PoolerSpecTemplateSpecInitContainersLifecyclePostStartExec? Exec { get; set; }

    /// <summary>HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1PoolerSpecTemplateSpecInitContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    /// <summary>Sleep represents the duration that the container should sleep before being terminated.</summary>
    [JsonPropertyName("sleep")]
    public V1PoolerSpecTemplateSpecInitContainersLifecyclePostStartSleep? Sleep { get; set; }

    /// <summary>Deprecated. TCPSocket is NOT supported as a LifecycleHandler and kept for the backward compatibility. There are no validation of this field and lifecycle hooks will fail in runtime when tcp handler is specified.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1PoolerSpecTemplateSpecInitContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

/// <summary>Exec specifies the action to take.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersLifecyclePreStopExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersLifecyclePreStopHttpGetHttpHeaders
{
    /// <summary>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>HTTPGet specifies the http request to perform.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersLifecyclePreStopHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1PoolerSpecTemplateSpecInitContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary>Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>Sleep represents the duration that the container should sleep before being terminated.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersLifecyclePreStopSleep
{
    /// <summary>Seconds is the number of seconds to sleep.</summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary>Deprecated. TCPSocket is NOT supported as a LifecycleHandler and kept for the backward compatibility. There are no validation of this field and lifecycle hooks will fail in runtime when tcp handler is specified.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersLifecyclePreStopTcpSocket
{
    /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary>PreStop is called immediately before a container is terminated due to an API request or management event such as liveness/startup probe failure, preemption, resource contention, etc. The handler is not called if the container crashes or exits. The Pod's termination grace period countdown begins before the PreStop hook is executed. Regardless of the outcome of the handler, the container will eventually terminate within the Pod's termination grace period (unless delayed by finalizers). Other management of the container blocks until the hook completes or until the termination grace period is reached. More info: https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersLifecyclePreStop
{
    /// <summary>Exec specifies the action to take.</summary>
    [JsonPropertyName("exec")]
    public V1PoolerSpecTemplateSpecInitContainersLifecyclePreStopExec? Exec { get; set; }

    /// <summary>HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1PoolerSpecTemplateSpecInitContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    /// <summary>Sleep represents the duration that the container should sleep before being terminated.</summary>
    [JsonPropertyName("sleep")]
    public V1PoolerSpecTemplateSpecInitContainersLifecyclePreStopSleep? Sleep { get; set; }

    /// <summary>Deprecated. TCPSocket is NOT supported as a LifecycleHandler and kept for the backward compatibility. There are no validation of this field and lifecycle hooks will fail in runtime when tcp handler is specified.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1PoolerSpecTemplateSpecInitContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

/// <summary>Actions that the management system should take in response to container lifecycle events. Cannot be updated.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersLifecycle
{
    /// <summary>PostStart is called immediately after a container is created. If the handler fails, the container is terminated and restarted according to its restart policy. Other management of the container blocks until the hook completes. More info: https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks</summary>
    [JsonPropertyName("postStart")]
    public V1PoolerSpecTemplateSpecInitContainersLifecyclePostStart? PostStart { get; set; }

    /// <summary>PreStop is called immediately before a container is terminated due to an API request or management event such as liveness/startup probe failure, preemption, resource contention, etc. The handler is not called if the container crashes or exits. The Pod's termination grace period countdown begins before the PreStop hook is executed. Regardless of the outcome of the handler, the container will eventually terminate within the Pod's termination grace period (unless delayed by finalizers). Other management of the container blocks until the hook completes or until the termination grace period is reached. More info: https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks</summary>
    [JsonPropertyName("preStop")]
    public V1PoolerSpecTemplateSpecInitContainersLifecyclePreStop? PreStop { get; set; }
}

/// <summary>Exec specifies the action to take.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersLivenessProbeExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>GRPC specifies an action involving a GRPC port.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersLivenessProbeGrpc
{
    /// <summary>Port number of the gRPC service. Number must be in the range 1 to 65535.</summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).   If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>HTTPGet specifies the http request to perform.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersLivenessProbeHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1PoolerSpecTemplateSpecInitContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary>Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>TCPSocket specifies an action involving a TCP port.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersLivenessProbeTcpSocket
{
    /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersLivenessProbe
{
    /// <summary>Exec specifies the action to take.</summary>
    [JsonPropertyName("exec")]
    public V1PoolerSpecTemplateSpecInitContainersLivenessProbeExec? Exec { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port.</summary>
    [JsonPropertyName("grpc")]
    public V1PoolerSpecTemplateSpecInitContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary>HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1PoolerSpecTemplateSpecInitContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TCPSocket specifies an action involving a TCP port.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1PoolerSpecTemplateSpecInitContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Optional duration in seconds the pod needs to terminate gracefully upon probe failure. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. If this value is nil, the pod's terminationGracePeriodSeconds will be used. Otherwise, this value overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). This is a beta field and requires enabling ProbeTerminationGracePeriod feature gate. Minimum value is 1. spec.terminationGracePeriodSeconds is used if unset.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>ContainerPort represents a network port in a single container.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersPorts
{
    /// <summary>Number of port to expose on the pod's IP address. This must be a valid port number, 0 &lt; x &lt; 65536.</summary>
    [JsonPropertyName("containerPort")]
    public int ContainerPort { get; set; }

    /// <summary>What host IP to bind the external port to.</summary>
    [JsonPropertyName("hostIP")]
    public string? HostIP { get; set; }

    /// <summary>Number of port to expose on the host. If specified, this must be a valid port number, 0 &lt; x &lt; 65536. If HostNetwork is specified, this must match ContainerPort. Most containers do not need this.</summary>
    [JsonPropertyName("hostPort")]
    public int? HostPort { get; set; }

    /// <summary>If specified, this must be an IANA_SVC_NAME and unique within the pod. Each named port in a pod must have a unique name. Name for the port that can be referred to by services.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol for port. Must be UDP, TCP, or SCTP. Defaults to "TCP".</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Exec specifies the action to take.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersReadinessProbeExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>GRPC specifies an action involving a GRPC port.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersReadinessProbeGrpc
{
    /// <summary>Port number of the gRPC service. Number must be in the range 1 to 65535.</summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).   If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersReadinessProbeHttpGetHttpHeaders
{
    /// <summary>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>HTTPGet specifies the http request to perform.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersReadinessProbeHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1PoolerSpecTemplateSpecInitContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary>Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>TCPSocket specifies an action involving a TCP port.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersReadinessProbeTcpSocket
{
    /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary>Periodic probe of container service readiness. Container will be removed from service endpoints if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersReadinessProbe
{
    /// <summary>Exec specifies the action to take.</summary>
    [JsonPropertyName("exec")]
    public V1PoolerSpecTemplateSpecInitContainersReadinessProbeExec? Exec { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port.</summary>
    [JsonPropertyName("grpc")]
    public V1PoolerSpecTemplateSpecInitContainersReadinessProbeGrpc? Grpc { get; set; }

    /// <summary>HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1PoolerSpecTemplateSpecInitContainersReadinessProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TCPSocket specifies an action involving a TCP port.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1PoolerSpecTemplateSpecInitContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Optional duration in seconds the pod needs to terminate gracefully upon probe failure. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. If this value is nil, the pod's terminationGracePeriodSeconds will be used. Otherwise, this value overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). This is a beta field and requires enabling ProbeTerminationGracePeriod feature gate. Minimum value is 1. spec.terminationGracePeriodSeconds is used if unset.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>ContainerResizePolicy represents resource resize policy for the container.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersResizePolicy
{
    /// <summary>Name of the resource to which this resource resize policy applies. Supported values: cpu, memory.</summary>
    [JsonPropertyName("resourceName")]
    public string ResourceName { get; set; }

    /// <summary>Restart policy to apply when specified resource is resized. If not specified, it defaults to NotRequired.</summary>
    [JsonPropertyName("restartPolicy")]
    public string RestartPolicy { get; set; }
}

/// <summary>ResourceClaim references one entry in PodSpec.ResourceClaims.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersResourcesClaims
{
    /// <summary>Name must match the name of one entry in pod.spec.resourceClaims of the Pod where this field is used. It makes that resource available inside a container.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Compute Resources required by this container. Cannot be updated. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersResources
{
    /// <summary>Claims lists the names of resources, defined in spec.resourceClaims, that are used by this container.   This is an alpha field and requires enabling the DynamicResourceAllocation feature gate.   This field is immutable. It can only be set for containers.</summary>
    [JsonPropertyName("claims")]
    public IList<V1PoolerSpecTemplateSpecInitContainersResourcesClaims>? Claims { get; set; }

    /// <summary>Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, IntstrIntOrString>? Limits { get; set; }

    /// <summary>Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. Requests cannot exceed Limits. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, IntstrIntOrString>? Requests { get; set; }
}

/// <summary>appArmorProfile is the AppArmor options to use by this container. If set, this profile overrides the pod's appArmorProfile. Note that this field cannot be set when spec.os.name is windows.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersSecurityContextAppArmorProfile
{
    /// <summary>localhostProfile indicates a profile loaded on the node that should be used. The profile must be preconfigured on the node to work. Must match the loaded name of the profile. Must be set if and only if type is "Localhost".</summary>
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    /// <summary>type indicates which kind of AppArmor profile will be applied. Valid options are:   Localhost - a profile pre-loaded on the node.   RuntimeDefault - the container runtime's default profile.   Unconfined - no AppArmor enforcement.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>The capabilities to add/drop when running containers. Defaults to the default set of capabilities granted by the container runtime. Note that this field cannot be set when spec.os.name is windows.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersSecurityContextCapabilities
{
    /// <summary>Added capabilities</summary>
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    /// <summary>Removed capabilities</summary>
    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

/// <summary>The SELinux context to be applied to the container. If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersSecurityContextSeLinuxOptions
{
    /// <summary>Level is SELinux level label that applies to the container.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Role is a SELinux role label that applies to the container.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Type is a SELinux type label that applies to the container.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>User is a SELinux user label that applies to the container.</summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary>The seccomp options to use by this container. If seccomp options are provided at both the pod &amp; container level, the container options override the pod options. Note that this field cannot be set when spec.os.name is windows.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersSecurityContextSeccompProfile
{
    /// <summary>localhostProfile indicates a profile defined in a file on the node should be used. The profile must be preconfigured on the node to work. Must be a descending path, relative to the kubelet's configured seccomp profile location. Must be set if type is "Localhost". Must NOT be set for any other type.</summary>
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    /// <summary>type indicates which kind of seccomp profile will be applied. Valid options are:   Localhost - a profile defined in a file on the node should be used. RuntimeDefault - the container runtime default profile should be used. Unconfined - no profile should be applied.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>The Windows specific settings applied to all containers. If unspecified, the options from the PodSecurityContext will be used. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is linux.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersSecurityContextWindowsOptions
{
    /// <summary>GMSACredentialSpec is where the GMSA admission webhook (https://github.com/kubernetes-sigs/windows-gmsa) inlines the contents of the GMSA credential spec named by the GMSACredentialSpecName field.</summary>
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    /// <summary>GMSACredentialSpecName is the name of the GMSA credential spec to use.</summary>
    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    /// <summary>HostProcess determines if a container should be run as a 'Host Process' container. All of a Pod's containers must have the same effective HostProcess value (it is not allowed to have a mix of HostProcess containers and non-HostProcess containers). In addition, if HostProcess is true then HostNetwork must also be set to true.</summary>
    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    /// <summary>The UserName in Windows to run the entrypoint of the container process. Defaults to the user specified in image metadata if unspecified. May also be set in PodSecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</summary>
    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>SecurityContext defines the security options the container should be run with. If set, the fields of SecurityContext override the equivalent fields of PodSecurityContext. More info: https://kubernetes.io/docs/tasks/configure-pod-container/security-context/</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersSecurityContext
{
    /// <summary>AllowPrivilegeEscalation controls whether a process can gain more privileges than its parent process. This bool directly controls if the no_new_privs flag will be set on the container process. AllowPrivilegeEscalation is true always when the container is: 1) run as Privileged 2) has CAP_SYS_ADMIN Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary>appArmorProfile is the AppArmor options to use by this container. If set, this profile overrides the pod's appArmorProfile. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("appArmorProfile")]
    public V1PoolerSpecTemplateSpecInitContainersSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    /// <summary>The capabilities to add/drop when running containers. Defaults to the default set of capabilities granted by the container runtime. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("capabilities")]
    public V1PoolerSpecTemplateSpecInitContainersSecurityContextCapabilities? Capabilities { get; set; }

    /// <summary>Run container in privileged mode. Processes in privileged containers are essentially equivalent to root on the host. Defaults to false. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    /// <summary>procMount denotes the type of proc mount to use for the containers. The default is DefaultProcMount which uses the container runtime defaults for readonly paths and masked paths. This requires the ProcMountType feature flag to be enabled. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("procMount")]
    public string? ProcMount { get; set; }

    /// <summary>Whether this container has a read-only root filesystem. Default is false. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    /// <summary>The GID to run the entrypoint of the container process. Uses runtime default if unset. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("runAsGroup")]
    public long? RunAsGroup { get; set; }

    /// <summary>Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</summary>
    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    /// <summary>The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if unspecified. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("runAsUser")]
    public long? RunAsUser { get; set; }

    /// <summary>The SELinux context to be applied to the container. If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("seLinuxOptions")]
    public V1PoolerSpecTemplateSpecInitContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary>The seccomp options to use by this container. If seccomp options are provided at both the pod &amp; container level, the container options override the pod options. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("seccompProfile")]
    public V1PoolerSpecTemplateSpecInitContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary>The Windows specific settings applied to all containers. If unspecified, the options from the PodSecurityContext will be used. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is linux.</summary>
    [JsonPropertyName("windowsOptions")]
    public V1PoolerSpecTemplateSpecInitContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

/// <summary>Exec specifies the action to take.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersStartupProbeExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>GRPC specifies an action involving a GRPC port.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersStartupProbeGrpc
{
    /// <summary>Port number of the gRPC service. Number must be in the range 1 to 65535.</summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).   If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>HTTPGet specifies the http request to perform.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersStartupProbeHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1PoolerSpecTemplateSpecInitContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary>Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>TCPSocket specifies an action involving a TCP port.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersStartupProbeTcpSocket
{
    /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary>StartupProbe indicates that the Pod has successfully initialized. If specified, no other probes are executed until this completes successfully. If this probe fails, the Pod will be restarted, just as if the livenessProbe failed. This can be used to provide different probe parameters at the beginning of a Pod's lifecycle, when it might take a long time to load data or warm a cache, than during steady-state operation. This cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersStartupProbe
{
    /// <summary>Exec specifies the action to take.</summary>
    [JsonPropertyName("exec")]
    public V1PoolerSpecTemplateSpecInitContainersStartupProbeExec? Exec { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port.</summary>
    [JsonPropertyName("grpc")]
    public V1PoolerSpecTemplateSpecInitContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary>HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1PoolerSpecTemplateSpecInitContainersStartupProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TCPSocket specifies an action involving a TCP port.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1PoolerSpecTemplateSpecInitContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Optional duration in seconds the pod needs to terminate gracefully upon probe failure. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. If this value is nil, the pod's terminationGracePeriodSeconds will be used. Otherwise, this value overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). This is a beta field and requires enabling ProbeTerminationGracePeriod feature gate. Minimum value is 1. spec.terminationGracePeriodSeconds is used if unset.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>volumeDevice describes a mapping of a raw block device within a container.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersVolumeDevices
{
    /// <summary>devicePath is the path inside of the container that the device will be mapped to.</summary>
    [JsonPropertyName("devicePath")]
    public string DevicePath { get; set; }

    /// <summary>name must match the name of a persistentVolumeClaim in the pod</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>VolumeMount describes a mounting of a Volume within a container.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainersVolumeMounts
{
    /// <summary>Path within the container at which the volume should be mounted.  Must not contain ':'.</summary>
    [JsonPropertyName("mountPath")]
    public string MountPath { get; set; }

    /// <summary>mountPropagation determines how mounts are propagated from the host to container and the other way around. When not set, MountPropagationNone is used. This field is beta in 1.10. When RecursiveReadOnly is set to IfPossible or to Enabled, MountPropagation must be None or unspecified (which defaults to None).</summary>
    [JsonPropertyName("mountPropagation")]
    public string? MountPropagation { get; set; }

    /// <summary>This must match the Name of a Volume.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Mounted read-only if true, read-write otherwise (false or unspecified). Defaults to false.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>RecursiveReadOnly specifies whether read-only mounts should be handled recursively.   If ReadOnly is false, this field has no meaning and must be unspecified.   If ReadOnly is true, and this field is set to Disabled, the mount is not made recursively read-only.  If this field is set to IfPossible, the mount is made recursively read-only, if it is supported by the container runtime.  If this field is set to Enabled, the mount is made recursively read-only if it is supported by the container runtime, otherwise the pod will not be started and an error will be generated to indicate the reason.   If this field is set to IfPossible or Enabled, MountPropagation must be set to None (or be unspecified, which defaults to None).   If this field is not specified, it is treated as an equivalent of Disabled.</summary>
    [JsonPropertyName("recursiveReadOnly")]
    public string? RecursiveReadOnly { get; set; }

    /// <summary>Path within the volume from which the container's volume should be mounted. Defaults to "" (volume's root).</summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    /// <summary>Expanded path within the volume from which the container's volume should be mounted. Behaves similarly to SubPath but environment variable references $(VAR_NAME) are expanded using the container's environment. Defaults to "" (volume's root). SubPathExpr and SubPath are mutually exclusive.</summary>
    [JsonPropertyName("subPathExpr")]
    public string? SubPathExpr { get; set; }
}

/// <summary>A single application container that you want to run within a pod.</summary>
public partial class V1PoolerSpecTemplateSpecInitContainers
{
    /// <summary>Arguments to the entrypoint. The container image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint array. Not executed within a shell. The container image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>List of environment variables to set in the container. Cannot be updated.</summary>
    [JsonPropertyName("env")]
    public IList<V1PoolerSpecTemplateSpecInitContainersEnv>? Env { get; set; }

    /// <summary>List of sources to populate environment variables in the container. The keys defined within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Cannot be updated.</summary>
    [JsonPropertyName("envFrom")]
    public IList<V1PoolerSpecTemplateSpecInitContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary>Container image name. More info: https://kubernetes.io/docs/concepts/containers/images This field is optional to allow higher level config management to default or override container images in workload controllers like Deployments and StatefulSets.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images</summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary>Actions that the management system should take in response to container lifecycle events. Cannot be updated.</summary>
    [JsonPropertyName("lifecycle")]
    public V1PoolerSpecTemplateSpecInitContainersLifecycle? Lifecycle { get; set; }

    /// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("livenessProbe")]
    public V1PoolerSpecTemplateSpecInitContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Name of the container specified as a DNS_LABEL. Each container in a pod must have a unique name (DNS_LABEL). Cannot be updated.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>List of ports to expose from the container. Not specifying a port here DOES NOT prevent that port from being exposed. Any port which is listening on the default "0.0.0.0" address inside a container will be accessible from the network. Modifying this array with strategic merge patch may corrupt the data. For more information See https://github.com/kubernetes/kubernetes/issues/108255. Cannot be updated.</summary>
    [JsonPropertyName("ports")]
    public IList<V1PoolerSpecTemplateSpecInitContainersPorts>? Ports { get; set; }

    /// <summary>Periodic probe of container service readiness. Container will be removed from service endpoints if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("readinessProbe")]
    public V1PoolerSpecTemplateSpecInitContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary>Resources resize policy for the container.</summary>
    [JsonPropertyName("resizePolicy")]
    public IList<V1PoolerSpecTemplateSpecInitContainersResizePolicy>? ResizePolicy { get; set; }

    /// <summary>Compute Resources required by this container. Cannot be updated. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("resources")]
    public V1PoolerSpecTemplateSpecInitContainersResources? Resources { get; set; }

    /// <summary>RestartPolicy defines the restart behavior of individual containers in a pod. This field may only be set for init containers, and the only allowed value is "Always". For non-init containers or when this field is not specified, the restart behavior is defined by the Pod's restart policy and the container type. Setting the RestartPolicy as "Always" for the init container will have the following effect: this init container will be continually restarted on exit until all regular containers have terminated. Once all regular containers have completed, all init containers with restartPolicy "Always" will be shut down. This lifecycle differs from normal init containers and is often referred to as a "sidecar" container. Although this init container still starts in the init container sequence, it does not wait for the container to complete before proceeding to the next init container. Instead, the next init container starts immediately after this init container is started, or after any startupProbe has successfully completed.</summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary>SecurityContext defines the security options the container should be run with. If set, the fields of SecurityContext override the equivalent fields of PodSecurityContext. More info: https://kubernetes.io/docs/tasks/configure-pod-container/security-context/</summary>
    [JsonPropertyName("securityContext")]
    public V1PoolerSpecTemplateSpecInitContainersSecurityContext? SecurityContext { get; set; }

    /// <summary>StartupProbe indicates that the Pod has successfully initialized. If specified, no other probes are executed until this completes successfully. If this probe fails, the Pod will be restarted, just as if the livenessProbe failed. This can be used to provide different probe parameters at the beginning of a Pod's lifecycle, when it might take a long time to load data or warm a cache, than during steady-state operation. This cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("startupProbe")]
    public V1PoolerSpecTemplateSpecInitContainersStartupProbe? StartupProbe { get; set; }

    /// <summary>Whether this container should allocate a buffer for stdin in the container runtime. If this is not set, reads from stdin in the container will always result in EOF. Default is false.</summary>
    [JsonPropertyName("stdin")]
    public bool? Stdin { get; set; }

    /// <summary>Whether the container runtime should close the stdin channel after it has been opened by a single attach. When stdin is true the stdin stream will remain open across multiple attach sessions. If stdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and accepts data until the client disconnects, at which time stdin is closed and remains closed until the container is restarted. If this flag is false, a container processes that reads from stdin will never receive an EOF. Default is false</summary>
    [JsonPropertyName("stdinOnce")]
    public bool? StdinOnce { get; set; }

    /// <summary>Optional: Path at which the file to which the container's termination message will be written is mounted into the container's filesystem. Message written is intended to be brief final status, such as an assertion failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across all containers will be limited to 12kb. Defaults to /dev/termination-log. Cannot be updated.</summary>
    [JsonPropertyName("terminationMessagePath")]
    public string? TerminationMessagePath { get; set; }

    /// <summary>Indicate how the termination message should be populated. File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated.</summary>
    [JsonPropertyName("terminationMessagePolicy")]
    public string? TerminationMessagePolicy { get; set; }

    /// <summary>Whether this container should allocate a TTY for itself, also requires 'stdin' to be true. Default is false.</summary>
    [JsonPropertyName("tty")]
    public bool? Tty { get; set; }

    /// <summary>volumeDevices is the list of block devices to be used by the container.</summary>
    [JsonPropertyName("volumeDevices")]
    public IList<V1PoolerSpecTemplateSpecInitContainersVolumeDevices>? VolumeDevices { get; set; }

    /// <summary>Pod volumes to mount into the container's filesystem. Cannot be updated.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1PoolerSpecTemplateSpecInitContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary>Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image. Cannot be updated.</summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary>Specifies the OS of the containers in the pod. Some pod and container fields are restricted if this is set.   If the OS field is set to linux, the following fields must be unset: -securityContext.windowsOptions   If the OS field is set to windows, following fields must be unset: - spec.hostPID - spec.hostIPC - spec.hostUsers - spec.securityContext.appArmorProfile - spec.securityContext.seLinuxOptions - spec.securityContext.seccompProfile - spec.securityContext.fsGroup - spec.securityContext.fsGroupChangePolicy - spec.securityContext.sysctls - spec.shareProcessNamespace - spec.securityContext.runAsUser - spec.securityContext.runAsGroup - spec.securityContext.supplementalGroups - spec.containers[*].securityContext.appArmorProfile - spec.containers[*].securityContext.seLinuxOptions - spec.containers[*].securityContext.seccompProfile - spec.containers[*].securityContext.capabilities - spec.containers[*].securityContext.readOnlyRootFilesystem - spec.containers[*].securityContext.privileged - spec.containers[*].securityContext.allowPrivilegeEscalation - spec.containers[*].securityContext.procMount - spec.containers[*].securityContext.runAsUser - spec.containers[*].securityContext.runAsGroup</summary>
public partial class V1PoolerSpecTemplateSpecOs
{
    /// <summary>Name is the name of the operating system. The currently supported values are linux and windows. Additional value may be defined in future and can be one of: https://github.com/opencontainers/runtime-spec/blob/master/config.md#platform-specific-configuration Clients should expect to handle additional values and treat unrecognized values in this field as os: null</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>PodReadinessGate contains the reference to a pod condition</summary>
public partial class V1PoolerSpecTemplateSpecReadinessGates
{
    /// <summary>ConditionType refers to a condition in the pod's condition list with matching type.</summary>
    [JsonPropertyName("conditionType")]
    public string ConditionType { get; set; }
}

/// <summary>Source describes where to find the ResourceClaim.</summary>
public partial class V1PoolerSpecTemplateSpecResourceClaimsSource
{
    /// <summary>ResourceClaimName is the name of a ResourceClaim object in the same namespace as this pod.</summary>
    [JsonPropertyName("resourceClaimName")]
    public string? ResourceClaimName { get; set; }

    /// <summary>ResourceClaimTemplateName is the name of a ResourceClaimTemplate object in the same namespace as this pod.   The template will be used to create a new ResourceClaim, which will be bound to this pod. When this pod is deleted, the ResourceClaim will also be deleted. The pod name and resource name, along with a generated component, will be used to form a unique name for the ResourceClaim, which will be recorded in pod.status.resourceClaimStatuses.   This field is immutable and no changes will be made to the corresponding ResourceClaim by the control plane after creating the ResourceClaim.</summary>
    [JsonPropertyName("resourceClaimTemplateName")]
    public string? ResourceClaimTemplateName { get; set; }
}

/// <summary>PodResourceClaim references exactly one ResourceClaim through a ClaimSource. It adds a name to it that uniquely identifies the ResourceClaim inside the Pod. Containers that need access to the ResourceClaim reference it with this name.</summary>
public partial class V1PoolerSpecTemplateSpecResourceClaims
{
    /// <summary>Name uniquely identifies this resource claim inside the pod. This must be a DNS_LABEL.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Source describes where to find the ResourceClaim.</summary>
    [JsonPropertyName("source")]
    public V1PoolerSpecTemplateSpecResourceClaimsSource? Source { get; set; }
}

/// <summary>PodSchedulingGate is associated to a Pod to guard its scheduling.</summary>
public partial class V1PoolerSpecTemplateSpecSchedulingGates
{
    /// <summary>Name of the scheduling gate. Each scheduling gate must have a unique name field.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>appArmorProfile is the AppArmor options to use by the containers in this pod. Note that this field cannot be set when spec.os.name is windows.</summary>
public partial class V1PoolerSpecTemplateSpecSecurityContextAppArmorProfile
{
    /// <summary>localhostProfile indicates a profile loaded on the node that should be used. The profile must be preconfigured on the node to work. Must match the loaded name of the profile. Must be set if and only if type is "Localhost".</summary>
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    /// <summary>type indicates which kind of AppArmor profile will be applied. Valid options are:   Localhost - a profile pre-loaded on the node.   RuntimeDefault - the container runtime's default profile.   Unconfined - no AppArmor enforcement.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>The SELinux context to be applied to all containers. If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container. Note that this field cannot be set when spec.os.name is windows.</summary>
public partial class V1PoolerSpecTemplateSpecSecurityContextSeLinuxOptions
{
    /// <summary>Level is SELinux level label that applies to the container.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Role is a SELinux role label that applies to the container.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Type is a SELinux type label that applies to the container.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>User is a SELinux user label that applies to the container.</summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary>The seccomp options to use by the containers in this pod. Note that this field cannot be set when spec.os.name is windows.</summary>
public partial class V1PoolerSpecTemplateSpecSecurityContextSeccompProfile
{
    /// <summary>localhostProfile indicates a profile defined in a file on the node should be used. The profile must be preconfigured on the node to work. Must be a descending path, relative to the kubelet's configured seccomp profile location. Must be set if type is "Localhost". Must NOT be set for any other type.</summary>
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    /// <summary>type indicates which kind of seccomp profile will be applied. Valid options are:   Localhost - a profile defined in a file on the node should be used. RuntimeDefault - the container runtime default profile should be used. Unconfined - no profile should be applied.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Sysctl defines a kernel parameter to be set</summary>
public partial class V1PoolerSpecTemplateSpecSecurityContextSysctls
{
    /// <summary>Name of a property to set</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value of a property to set</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>The Windows specific settings applied to all containers. If unspecified, the options within a container's SecurityContext will be used. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is linux.</summary>
public partial class V1PoolerSpecTemplateSpecSecurityContextWindowsOptions
{
    /// <summary>GMSACredentialSpec is where the GMSA admission webhook (https://github.com/kubernetes-sigs/windows-gmsa) inlines the contents of the GMSA credential spec named by the GMSACredentialSpecName field.</summary>
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    /// <summary>GMSACredentialSpecName is the name of the GMSA credential spec to use.</summary>
    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    /// <summary>HostProcess determines if a container should be run as a 'Host Process' container. All of a Pod's containers must have the same effective HostProcess value (it is not allowed to have a mix of HostProcess containers and non-HostProcess containers). In addition, if HostProcess is true then HostNetwork must also be set to true.</summary>
    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    /// <summary>The UserName in Windows to run the entrypoint of the container process. Defaults to the user specified in image metadata if unspecified. May also be set in PodSecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</summary>
    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>SecurityContext holds pod-level security attributes and common container settings. Optional: Defaults to empty.  See type description for default values of each field.</summary>
public partial class V1PoolerSpecTemplateSpecSecurityContext
{
    /// <summary>appArmorProfile is the AppArmor options to use by the containers in this pod. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("appArmorProfile")]
    public V1PoolerSpecTemplateSpecSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    /// <summary>A special supplemental group that applies to all containers in a pod. Some volume types allow the Kubelet to change the ownership of that volume to be owned by the pod:   1. The owning GID will be the FSGroup 2. The setgid bit is set (new files created in the volume will be owned by FSGroup) 3. The permission bits are OR'd with rw-rw----   If unset, the Kubelet will not modify the ownership and permissions of any volume. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("fsGroup")]
    public long? FsGroup { get; set; }

    /// <summary>fsGroupChangePolicy defines behavior of changing ownership and permission of the volume before being exposed inside Pod. This field will only apply to volume types which support fsGroup based ownership(and permissions). It will have no effect on ephemeral volume types such as: secret, configmaps and emptydir. Valid values are "OnRootMismatch" and "Always". If not specified, "Always" is used. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("fsGroupChangePolicy")]
    public string? FsGroupChangePolicy { get; set; }

    /// <summary>The GID to run the entrypoint of the container process. Uses runtime default if unset. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("runAsGroup")]
    public long? RunAsGroup { get; set; }

    /// <summary>Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</summary>
    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    /// <summary>The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if unspecified. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("runAsUser")]
    public long? RunAsUser { get; set; }

    /// <summary>The SELinux context to be applied to all containers. If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("seLinuxOptions")]
    public V1PoolerSpecTemplateSpecSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary>The seccomp options to use by the containers in this pod. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("seccompProfile")]
    public V1PoolerSpecTemplateSpecSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary>A list of groups applied to the first process run in each container, in addition to the container's primary GID, the fsGroup (if specified), and group memberships defined in the container image for the uid of the container process. If unspecified, no additional groups are added to any container. Note that group memberships defined in the container image for the uid of the container process are still effective, even if they are not included in this list. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("supplementalGroups")]
    public IList<long>? SupplementalGroups { get; set; }

    /// <summary>Sysctls hold a list of namespaced sysctls used for the pod. Pods with unsupported sysctls (by the container runtime) might fail to launch. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("sysctls")]
    public IList<V1PoolerSpecTemplateSpecSecurityContextSysctls>? Sysctls { get; set; }

    /// <summary>The Windows specific settings applied to all containers. If unspecified, the options within a container's SecurityContext will be used. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is linux.</summary>
    [JsonPropertyName("windowsOptions")]
    public V1PoolerSpecTemplateSpecSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

/// <summary>The pod this Toleration is attached to tolerates any taint that matches the triple &lt;key,value,effect&gt; using the matching operator &lt;operator&gt;.</summary>
public partial class V1PoolerSpecTemplateSpecTolerations
{
    /// <summary>Effect indicates the taint effect to match. Empty means match all taint effects. When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>Key is the taint key that the toleration applies to. Empty means match all taint keys. If the key is empty, operator must be Exists; this combination means to match all values and all keys.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Operator represents a key's relationship to the value. Valid operators are Exists and Equal. Defaults to Equal. Exists is equivalent to wildcard for value, so that a pod can tolerate all taints of a particular category.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>TolerationSeconds represents the period of time the toleration (which must be of effect NoExecute, otherwise this field is ignored) tolerates the taint. By default, it is not set, which means tolerate the taint forever (do not evict). Zero and negative values will be treated as 0 (evict immediately) by the system.</summary>
    [JsonPropertyName("tolerationSeconds")]
    public long? TolerationSeconds { get; set; }

    /// <summary>Value is the taint value the toleration matches to. If the operator is Exists, the value should be empty, otherwise just a regular string.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
public partial class V1PoolerSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>LabelSelector is used to find matching pods. Pods that match this label selector are counted to determine the number of pods in their corresponding topology domain.</summary>
public partial class V1PoolerSpecTemplateSpecTopologySpreadConstraintsLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PoolerSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>TopologySpreadConstraint specifies how to spread matching pods among the given topology.</summary>
public partial class V1PoolerSpecTemplateSpecTopologySpreadConstraints
{
    /// <summary>LabelSelector is used to find matching pods. Pods that match this label selector are counted to determine the number of pods in their corresponding topology domain.</summary>
    [JsonPropertyName("labelSelector")]
    public V1PoolerSpecTemplateSpecTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select the pods over which spreading will be calculated. The keys are used to lookup values from the incoming pod labels, those key-value labels are ANDed with labelSelector to select the group of existing pods over which spreading will be calculated for the incoming pod. The same key is forbidden to exist in both MatchLabelKeys and LabelSelector. MatchLabelKeys cannot be set when LabelSelector isn't set. Keys that don't exist in the incoming pod labels will be ignored. A null or empty list means only match against labelSelector.   This is a beta field and requires the MatchLabelKeysInPodTopologySpread feature gate to be enabled (enabled by default).</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MaxSkew describes the degree to which pods may be unevenly distributed. When `whenUnsatisfiable=DoNotSchedule`, it is the maximum permitted difference between the number of matching pods in the target topology and the global minimum. The global minimum is the minimum number of matching pods in an eligible domain or zero if the number of eligible domains is less than MinDomains. For example, in a 3-zone cluster, MaxSkew is set to 1, and pods with the same labelSelector spread as 2/2/1: In this case, the global minimum is 1. | zone1 | zone2 | zone3 | |  P P  |  P P  |   P   | - if MaxSkew is 1, incoming pod can only be scheduled to zone3 to become 2/2/2; scheduling it onto zone1(zone2) would make the ActualSkew(3-1) on zone1(zone2) violate MaxSkew(1). - if MaxSkew is 2, incoming pod can be scheduled onto any zone. When `whenUnsatisfiable=ScheduleAnyway`, it is used to give higher precedence to topologies that satisfy it. It's a required field. Default value is 1 and 0 is not allowed.</summary>
    [JsonPropertyName("maxSkew")]
    public int MaxSkew { get; set; }

    /// <summary>MinDomains indicates a minimum number of eligible domains. When the number of eligible domains with matching topology keys is less than minDomains, Pod Topology Spread treats "global minimum" as 0, and then the calculation of Skew is performed. And when the number of eligible domains with matching topology keys equals or greater than minDomains, this value has no effect on scheduling. As a result, when the number of eligible domains is less than minDomains, scheduler won't schedule more than maxSkew Pods to those domains. If value is nil, the constraint behaves as if MinDomains is equal to 1. Valid values are integers greater than 0. When value is not nil, WhenUnsatisfiable must be DoNotSchedule.   For example, in a 3-zone cluster, MaxSkew is set to 2, MinDomains is set to 5 and pods with the same labelSelector spread as 2/2/2: | zone1 | zone2 | zone3 | |  P P  |  P P  |  P P  | The number of domains is less than 5(MinDomains), so "global minimum" is treated as 0. In this situation, new pod with the same labelSelector cannot be scheduled, because computed skew will be 3(3 - 0) if new Pod is scheduled to any of the three zones, it will violate MaxSkew.</summary>
    [JsonPropertyName("minDomains")]
    public int? MinDomains { get; set; }

    /// <summary>NodeAffinityPolicy indicates how we will treat Pod's nodeAffinity/nodeSelector when calculating pod topology spread skew. Options are: - Honor: only nodes matching nodeAffinity/nodeSelector are included in the calculations. - Ignore: nodeAffinity/nodeSelector are ignored. All nodes are included in the calculations.   If this value is nil, the behavior is equivalent to the Honor policy. This is a beta-level feature default enabled by the NodeInclusionPolicyInPodTopologySpread feature flag.</summary>
    [JsonPropertyName("nodeAffinityPolicy")]
    public string? NodeAffinityPolicy { get; set; }

    /// <summary>NodeTaintsPolicy indicates how we will treat node taints when calculating pod topology spread skew. Options are: - Honor: nodes without taints, along with tainted nodes for which the incoming pod has a toleration, are included. - Ignore: node taints are ignored. All nodes are included.   If this value is nil, the behavior is equivalent to the Ignore policy. This is a beta-level feature default enabled by the NodeInclusionPolicyInPodTopologySpread feature flag.</summary>
    [JsonPropertyName("nodeTaintsPolicy")]
    public string? NodeTaintsPolicy { get; set; }

    /// <summary>TopologyKey is the key of node labels. Nodes that have a label with this key and identical values are considered to be in the same topology. We consider each &lt;key, value&gt; as a "bucket", and try to put balanced number of pods into each bucket. We define a domain as a particular instance of a topology. Also, we define an eligible domain as a domain whose nodes meet the requirements of nodeAffinityPolicy and nodeTaintsPolicy. e.g. If TopologyKey is "kubernetes.io/hostname", each Node is a domain of that topology. And, if TopologyKey is "topology.kubernetes.io/zone", each zone is a domain of that topology. It's a required field.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }

    /// <summary>WhenUnsatisfiable indicates how to deal with a pod if it doesn't satisfy the spread constraint. - DoNotSchedule (default) tells the scheduler not to schedule it. - ScheduleAnyway tells the scheduler to schedule the pod in any location,   but giving higher precedence to topologies that would help reduce the   skew. A constraint is considered "Unsatisfiable" for an incoming pod if and only if every possible node assignment for that pod would violate "MaxSkew" on some topology. For example, in a 3-zone cluster, MaxSkew is set to 1, and pods with the same labelSelector spread as 3/1/1: | zone1 | zone2 | zone3 | | P P P |   P   |   P   | If WhenUnsatisfiable is set to DoNotSchedule, incoming pod can only be scheduled to zone2(zone3) to become 3/2/1(3/1/2) as ActualSkew(2-1) on zone2(zone3) satisfies MaxSkew(1). In other words, the cluster can still be imbalanced, but scheduler won't make it *more* imbalanced. It's a required field.</summary>
    [JsonPropertyName("whenUnsatisfiable")]
    public string WhenUnsatisfiable { get; set; }
}

/// <summary>awsElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore</summary>
public partial class V1PoolerSpecTemplateSpecVolumesAwsElasticBlockStore
{
    /// <summary>fsType is the filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore TODO: how do we prevent errors in the filesystem from compromising the machine</summary>
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    /// <summary>partition is the partition in the volume that you want to mount. If omitted, the default is to mount by volume name. Examples: For volume /dev/sda1, you specify the partition as "1". Similarly, the volume partition for /dev/sda is "0" (or you can leave the property empty).</summary>
    [JsonPropertyName("partition")]
    public int? Partition { get; set; }

    /// <summary>readOnly value true will force the readOnly setting in VolumeMounts. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>volumeID is unique ID of the persistent disk resource in AWS (Amazon EBS volume). More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore</summary>
    [JsonPropertyName("volumeID")]
    public string VolumeID { get; set; }
}

/// <summary>azureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesAzureDisk
{
    /// <summary>cachingMode is the Host Caching mode: None, Read Only, Read Write.</summary>
    [JsonPropertyName("cachingMode")]
    public string? CachingMode { get; set; }

    /// <summary>diskName is the Name of the data disk in the blob storage</summary>
    [JsonPropertyName("diskName")]
    public string DiskName { get; set; }

    /// <summary>diskURI is the URI of data disk in the blob storage</summary>
    [JsonPropertyName("diskURI")]
    public string DiskURI { get; set; }

    /// <summary>fsType is Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.</summary>
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    /// <summary>kind expected values are Shared: multiple blob disks per storage account  Dedicated: single blob disk per storage account  Managed: azure managed data disk (only in managed availability set). defaults to shared</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>readOnly Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

/// <summary>azureFile represents an Azure File Service mount on the host and bind mount to the pod.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesAzureFile
{
    /// <summary>readOnly defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>secretName is the  name of secret that contains Azure Storage Account Name and Key</summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }

    /// <summary>shareName is the azure share Name</summary>
    [JsonPropertyName("shareName")]
    public string ShareName { get; set; }
}

/// <summary>secretRef is Optional: SecretRef is reference to the authentication secret for User, default is empty. More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it</summary>
public partial class V1PoolerSpecTemplateSpecVolumesCephfsSecretRef
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>cephFS represents a Ceph FS mount on the host that shares a pod's lifetime</summary>
public partial class V1PoolerSpecTemplateSpecVolumesCephfs
{
    /// <summary>monitors is Required: Monitors is a collection of Ceph monitors More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it</summary>
    [JsonPropertyName("monitors")]
    public IList<string> Monitors { get; set; }

    /// <summary>path is Optional: Used as the mounted root, rather than the full Ceph tree, default is /</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>readOnly is Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>secretFile is Optional: SecretFile is the path to key ring for User, default is /etc/ceph/user.secret More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it</summary>
    [JsonPropertyName("secretFile")]
    public string? SecretFile { get; set; }

    /// <summary>secretRef is Optional: SecretRef is reference to the authentication secret for User, default is empty. More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it</summary>
    [JsonPropertyName("secretRef")]
    public V1PoolerSpecTemplateSpecVolumesCephfsSecretRef? SecretRef { get; set; }

    /// <summary>user is optional: User is the rados user name, default is admin More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it</summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary>secretRef is optional: points to a secret object containing parameters used to connect to OpenStack.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesCinderSecretRef
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>cinder represents a cinder volume attached and mounted on kubelets host machine. More info: https://examples.k8s.io/mysql-cinder-pd/README.md</summary>
public partial class V1PoolerSpecTemplateSpecVolumesCinder
{
    /// <summary>fsType is the filesystem type to mount. Must be a filesystem type supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://examples.k8s.io/mysql-cinder-pd/README.md</summary>
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    /// <summary>readOnly defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://examples.k8s.io/mysql-cinder-pd/README.md</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>secretRef is optional: points to a secret object containing parameters used to connect to OpenStack.</summary>
    [JsonPropertyName("secretRef")]
    public V1PoolerSpecTemplateSpecVolumesCinderSecretRef? SecretRef { get; set; }

    /// <summary>volumeID used to identify the volume in cinder. More info: https://examples.k8s.io/mysql-cinder-pd/README.md</summary>
    [JsonPropertyName("volumeID")]
    public string VolumeID { get; set; }
}

/// <summary>Maps a string key to a path within a volume.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesConfigMapItems
{
    /// <summary>key is the key to project.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>mode is Optional: mode bits used to set permissions on this file. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary>path is the relative path of the file to map the key to. May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary>configMap represents a configMap that should populate this volume</summary>
public partial class V1PoolerSpecTemplateSpecVolumesConfigMap
{
    /// <summary>defaultMode is optional: mode bits used to set permissions on created files by default. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    /// <summary>items if unspecified, each key-value pair in the Data field of the referenced ConfigMap will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the ConfigMap, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.</summary>
    [JsonPropertyName("items")]
    public IList<V1PoolerSpecTemplateSpecVolumesConfigMapItems>? Items { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>optional specify whether the ConfigMap or its keys must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>nodePublishSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodePublishVolume and NodeUnpublishVolume calls. This field is optional, and  may be empty if no secret is required. If the secret object contains more than one secret, all secret references are passed.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesCsiNodePublishSecretRef
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>csi (Container Storage Interface) represents ephemeral storage that is handled by certain external CSI drivers (Beta feature).</summary>
public partial class V1PoolerSpecTemplateSpecVolumesCsi
{
    /// <summary>driver is the name of the CSI driver that handles this volume. Consult with your admin for the correct name as registered in the cluster.</summary>
    [JsonPropertyName("driver")]
    public string Driver { get; set; }

    /// <summary>fsType to mount. Ex. "ext4", "xfs", "ntfs". If not provided, the empty value is passed to the associated CSI driver which will determine the default filesystem to apply.</summary>
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    /// <summary>nodePublishSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodePublishVolume and NodeUnpublishVolume calls. This field is optional, and  may be empty if no secret is required. If the secret object contains more than one secret, all secret references are passed.</summary>
    [JsonPropertyName("nodePublishSecretRef")]
    public V1PoolerSpecTemplateSpecVolumesCsiNodePublishSecretRef? NodePublishSecretRef { get; set; }

    /// <summary>readOnly specifies a read-only configuration for the volume. Defaults to false (read/write).</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>volumeAttributes stores driver-specific properties that are passed to the CSI driver. Consult your driver's documentation for supported values.</summary>
    [JsonPropertyName("volumeAttributes")]
    public IDictionary<string, string>? VolumeAttributes { get; set; }
}

/// <summary>Required: Selects a field of the pod: only annotations, labels, name, namespace and uid are supported.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesDownwardAPIItemsFieldRef
{
    /// <summary>Version of the schema the FieldPath is written in terms of, defaults to "v1".</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Path of the field to select in the specified API version.</summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}

/// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesDownwardAPIItemsResourceFieldRef
{
    /// <summary>Container name: required for volumes, optional for env vars</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Specifies the output format of the exposed resources, defaults to "1"</summary>
    [JsonPropertyName("divisor")]
    public IntstrIntOrString? Divisor { get; set; }

    /// <summary>Required: resource to select</summary>
    [JsonPropertyName("resource")]
    public string Resource { get; set; }
}

/// <summary>DownwardAPIVolumeFile represents information to create the file containing the pod field</summary>
public partial class V1PoolerSpecTemplateSpecVolumesDownwardAPIItems
{
    /// <summary>Required: Selects a field of the pod: only annotations, labels, name, namespace and uid are supported.</summary>
    [JsonPropertyName("fieldRef")]
    public V1PoolerSpecTemplateSpecVolumesDownwardAPIItemsFieldRef? FieldRef { get; set; }

    /// <summary>Optional: mode bits used to set permissions on this file, must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary>Required: Path is  the relative path name of the file to be created. Must not be absolute or contain the '..' path. Must be utf-8 encoded. The first item of the relative path must not start with '..'</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.</summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1PoolerSpecTemplateSpecVolumesDownwardAPIItemsResourceFieldRef? ResourceFieldRef { get; set; }
}

/// <summary>downwardAPI represents downward API about the pod that should populate this volume</summary>
public partial class V1PoolerSpecTemplateSpecVolumesDownwardAPI
{
    /// <summary>Optional: mode bits to use on created files by default. Must be a Optional: mode bits used to set permissions on created files by default. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    /// <summary>Items is a list of downward API volume file</summary>
    [JsonPropertyName("items")]
    public IList<V1PoolerSpecTemplateSpecVolumesDownwardAPIItems>? Items { get; set; }
}

/// <summary>emptyDir represents a temporary directory that shares a pod's lifetime. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir</summary>
public partial class V1PoolerSpecTemplateSpecVolumesEmptyDir
{
    /// <summary>medium represents what type of storage medium should back this directory. The default is "" which means to use the node's default medium. Must be an empty string (default) or Memory. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir</summary>
    [JsonPropertyName("medium")]
    public string? Medium { get; set; }

    /// <summary>sizeLimit is the total amount of local storage required for this EmptyDir volume. The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers in a pod. The default is nil which means that the limit is undefined. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir</summary>
    [JsonPropertyName("sizeLimit")]
    public IntstrIntOrString? SizeLimit { get; set; }
}

/// <summary>May contain labels and annotations that will be copied into the PVC when creating it. No other fields are allowed and will be rejected during validation.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateMetadata
{
}

/// <summary>dataSource field can be used to specify either: * An existing VolumeSnapshot object (snapshot.storage.k8s.io/VolumeSnapshot) * An existing PVC (PersistentVolumeClaim) If the provisioner or an external controller can support the specified data source, it will create a new volume based on the contents of the specified data source. When the AnyVolumeDataSource feature gate is enabled, dataSource contents will be copied to dataSourceRef, and dataSourceRef contents will be copied to dataSource when dataSourceRef.namespace is not specified. If the namespace is specified, then dataSourceRef will not be copied to dataSource.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecDataSource
{
    /// <summary>APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.</summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>Kind is the type of resource being referenced</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name is the name of resource being referenced</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>dataSourceRef specifies the object from which to populate the volume with data, if a non-empty volume is desired. This may be any object from a non-empty API group (non core object) or a PersistentVolumeClaim object. When this field is specified, volume binding will only succeed if the type of the specified object matches some installed volume populator or dynamic provisioner. This field will replace the functionality of the dataSource field and as such if both fields are non-empty, they must have the same value. For backwards compatibility, when namespace isn't specified in dataSourceRef, both fields (dataSource and dataSourceRef) will be set to the same value automatically if one of them is empty and the other is non-empty. When namespace is specified in dataSourceRef, dataSource isn't set to the same value and must be empty. There are three important differences between dataSource and dataSourceRef: * While dataSource only allows two specific types of objects, dataSourceRef   allows any non-core object, as well as PersistentVolumeClaim objects. * While dataSource ignores disallowed values (dropping them), dataSourceRef   preserves all values, and generates an error if a disallowed value is   specified. * While dataSource only allows local objects, dataSourceRef allows objects   in any namespaces. (Beta) Using this field requires the AnyVolumeDataSource feature gate to be enabled. (Alpha) Using the namespace field of dataSourceRef requires the CrossNamespaceVolumeDataSource feature gate to be enabled.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecDataSourceRef
{
    /// <summary>APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.</summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>Kind is the type of resource being referenced</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name is the name of resource being referenced</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace is the namespace of resource being referenced Note that when a namespace is specified, a gateway.networking.k8s.io/ReferenceGrant object is required in the referent namespace to allow that namespace's owner to accept the reference. See the ReferenceGrant documentation for details. (Alpha) This field requires the CrossNamespaceVolumeDataSource feature gate to be enabled.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>resources represents the minimum resources the volume should have. If RecoverVolumeExpansionFailure feature is enabled users are allowed to specify resource requirements that are lower than previous value but must still be higher than capacity recorded in the status field of the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources</summary>
public partial class V1PoolerSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecResources
{
    /// <summary>Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, IntstrIntOrString>? Limits { get; set; }

    /// <summary>Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. Requests cannot exceed Limits. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, IntstrIntOrString>? Requests { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>selector is a label query over volumes to consider for binding.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PoolerSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>The specification for the PersistentVolumeClaim. The entire content is copied unchanged into the PVC that gets created from this template. The same fields as in a PersistentVolumeClaim are also valid here.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpec
{
    /// <summary>accessModes contains the desired access modes the volume should have. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1</summary>
    [JsonPropertyName("accessModes")]
    public IList<string>? AccessModes { get; set; }

    /// <summary>dataSource field can be used to specify either: * An existing VolumeSnapshot object (snapshot.storage.k8s.io/VolumeSnapshot) * An existing PVC (PersistentVolumeClaim) If the provisioner or an external controller can support the specified data source, it will create a new volume based on the contents of the specified data source. When the AnyVolumeDataSource feature gate is enabled, dataSource contents will be copied to dataSourceRef, and dataSourceRef contents will be copied to dataSource when dataSourceRef.namespace is not specified. If the namespace is specified, then dataSourceRef will not be copied to dataSource.</summary>
    [JsonPropertyName("dataSource")]
    public V1PoolerSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecDataSource? DataSource { get; set; }

    /// <summary>dataSourceRef specifies the object from which to populate the volume with data, if a non-empty volume is desired. This may be any object from a non-empty API group (non core object) or a PersistentVolumeClaim object. When this field is specified, volume binding will only succeed if the type of the specified object matches some installed volume populator or dynamic provisioner. This field will replace the functionality of the dataSource field and as such if both fields are non-empty, they must have the same value. For backwards compatibility, when namespace isn't specified in dataSourceRef, both fields (dataSource and dataSourceRef) will be set to the same value automatically if one of them is empty and the other is non-empty. When namespace is specified in dataSourceRef, dataSource isn't set to the same value and must be empty. There are three important differences between dataSource and dataSourceRef: * While dataSource only allows two specific types of objects, dataSourceRef   allows any non-core object, as well as PersistentVolumeClaim objects. * While dataSource ignores disallowed values (dropping them), dataSourceRef   preserves all values, and generates an error if a disallowed value is   specified. * While dataSource only allows local objects, dataSourceRef allows objects   in any namespaces. (Beta) Using this field requires the AnyVolumeDataSource feature gate to be enabled. (Alpha) Using the namespace field of dataSourceRef requires the CrossNamespaceVolumeDataSource feature gate to be enabled.</summary>
    [JsonPropertyName("dataSourceRef")]
    public V1PoolerSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecDataSourceRef? DataSourceRef { get; set; }

    /// <summary>resources represents the minimum resources the volume should have. If RecoverVolumeExpansionFailure feature is enabled users are allowed to specify resource requirements that are lower than previous value but must still be higher than capacity recorded in the status field of the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources</summary>
    [JsonPropertyName("resources")]
    public V1PoolerSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecResources? Resources { get; set; }

    /// <summary>selector is a label query over volumes to consider for binding.</summary>
    [JsonPropertyName("selector")]
    public V1PoolerSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecSelector? Selector { get; set; }

    /// <summary>storageClassName is the name of the StorageClass required by the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#class-1</summary>
    [JsonPropertyName("storageClassName")]
    public string? StorageClassName { get; set; }

    /// <summary>volumeAttributesClassName may be used to set the VolumeAttributesClass used by this claim. If specified, the CSI driver will create or update the volume with the attributes defined in the corresponding VolumeAttributesClass. This has a different purpose than storageClassName, it can be changed after the claim is created. An empty string value means that no VolumeAttributesClass will be applied to the claim but it's not allowed to reset this field to empty string once it is set. If unspecified and the PersistentVolumeClaim is unbound, the default VolumeAttributesClass will be set by the persistentvolume controller if it exists. If the resource referred to by volumeAttributesClass does not exist, this PersistentVolumeClaim will be set to a Pending state, as reflected by the modifyVolumeStatus field, until such as a resource exists. More info: https://kubernetes.io/docs/concepts/storage/volume-attributes-classes/ (Alpha) Using this field requires the VolumeAttributesClass feature gate to be enabled.</summary>
    [JsonPropertyName("volumeAttributesClassName")]
    public string? VolumeAttributesClassName { get; set; }

    /// <summary>volumeMode defines what type of volume is required by the claim. Value of Filesystem is implied when not included in claim spec.</summary>
    [JsonPropertyName("volumeMode")]
    public string? VolumeMode { get; set; }

    /// <summary>volumeName is the binding reference to the PersistentVolume backing this claim.</summary>
    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

/// <summary>Will be used to create a stand-alone PVC to provision the volume. The pod in which this EphemeralVolumeSource is embedded will be the owner of the PVC, i.e. the PVC will be deleted together with the pod.  The name of the PVC will be `&lt;pod name&gt;-&lt;volume name&gt;` where `&lt;volume name&gt;` is the name from the `PodSpec.Volumes` array entry. Pod validation will reject the pod if the concatenated name is not valid for a PVC (for example, too long).   An existing PVC with that name that is not owned by the pod will *not* be used for the pod to avoid using an unrelated volume by mistake. Starting the pod is then blocked until the unrelated PVC is removed. If such a pre-created PVC is meant to be used by the pod, the PVC has to updated with an owner reference to the pod once the pod exists. Normally this should not be necessary, but it may be useful when manually reconstructing a broken cluster.   This field is read-only and no changes will be made by Kubernetes to the PVC after it has been created.   Required, must not be nil.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesEphemeralVolumeClaimTemplate
{
    /// <summary>May contain labels and annotations that will be copied into the PVC when creating it. No other fields are allowed and will be rejected during validation.</summary>
    [JsonPropertyName("metadata")]
    public V1PoolerSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateMetadata? Metadata { get; set; }

    /// <summary>The specification for the PersistentVolumeClaim. The entire content is copied unchanged into the PVC that gets created from this template. The same fields as in a PersistentVolumeClaim are also valid here.</summary>
    [JsonPropertyName("spec")]
    public V1PoolerSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpec Spec { get; set; }
}

/// <summary>ephemeral represents a volume that is handled by a cluster storage driver. The volume's lifecycle is tied to the pod that defines it - it will be created before the pod starts, and deleted when the pod is removed.   Use this if: a) the volume is only needed while the pod runs, b) features of normal volumes like restoring from snapshot or capacity    tracking are needed, c) the storage driver is specified through a storage class, and d) the storage driver supports dynamic volume provisioning through    a PersistentVolumeClaim (see EphemeralVolumeSource for more    information on the connection between this volume type    and PersistentVolumeClaim).   Use PersistentVolumeClaim or one of the vendor-specific APIs for volumes that persist for longer than the lifecycle of an individual pod.   Use CSI for light-weight local ephemeral volumes if the CSI driver is meant to be used that way - see the documentation of the driver for more information.   A pod can use both types of ephemeral volumes and persistent volumes at the same time.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesEphemeral
{
    /// <summary>Will be used to create a stand-alone PVC to provision the volume. The pod in which this EphemeralVolumeSource is embedded will be the owner of the PVC, i.e. the PVC will be deleted together with the pod.  The name of the PVC will be `&lt;pod name&gt;-&lt;volume name&gt;` where `&lt;volume name&gt;` is the name from the `PodSpec.Volumes` array entry. Pod validation will reject the pod if the concatenated name is not valid for a PVC (for example, too long).   An existing PVC with that name that is not owned by the pod will *not* be used for the pod to avoid using an unrelated volume by mistake. Starting the pod is then blocked until the unrelated PVC is removed. If such a pre-created PVC is meant to be used by the pod, the PVC has to updated with an owner reference to the pod once the pod exists. Normally this should not be necessary, but it may be useful when manually reconstructing a broken cluster.   This field is read-only and no changes will be made by Kubernetes to the PVC after it has been created.   Required, must not be nil.</summary>
    [JsonPropertyName("volumeClaimTemplate")]
    public V1PoolerSpecTemplateSpecVolumesEphemeralVolumeClaimTemplate? VolumeClaimTemplate { get; set; }
}

/// <summary>fc represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesFc
{
    /// <summary>fsType is the filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. TODO: how do we prevent errors in the filesystem from compromising the machine</summary>
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    /// <summary>lun is Optional: FC target lun number</summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>readOnly is Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>targetWWNs is Optional: FC target worldwide names (WWNs)</summary>
    [JsonPropertyName("targetWWNs")]
    public IList<string>? TargetWWNs { get; set; }

    /// <summary>wwids Optional: FC volume world wide identifiers (wwids) Either wwids or combination of targetWWNs and lun must be set, but not both simultaneously.</summary>
    [JsonPropertyName("wwids")]
    public IList<string>? Wwids { get; set; }
}

/// <summary>secretRef is Optional: secretRef is reference to the secret object containing sensitive information to pass to the plugin scripts. This may be empty if no secret object is specified. If the secret object contains more than one secret, all secrets are passed to the plugin scripts.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesFlexVolumeSecretRef
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>flexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesFlexVolume
{
    /// <summary>driver is the name of the driver to use for this volume.</summary>
    [JsonPropertyName("driver")]
    public string Driver { get; set; }

    /// <summary>fsType is the filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". The default filesystem depends on FlexVolume script.</summary>
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    /// <summary>options is Optional: this field holds extra command options if any.</summary>
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    /// <summary>readOnly is Optional: defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>secretRef is Optional: secretRef is reference to the secret object containing sensitive information to pass to the plugin scripts. This may be empty if no secret object is specified. If the secret object contains more than one secret, all secrets are passed to the plugin scripts.</summary>
    [JsonPropertyName("secretRef")]
    public V1PoolerSpecTemplateSpecVolumesFlexVolumeSecretRef? SecretRef { get; set; }
}

/// <summary>flocker represents a Flocker volume attached to a kubelet's host machine. This depends on the Flocker control service being running</summary>
public partial class V1PoolerSpecTemplateSpecVolumesFlocker
{
    /// <summary>datasetName is Name of the dataset stored as metadata -&gt; name on the dataset for Flocker should be considered as deprecated</summary>
    [JsonPropertyName("datasetName")]
    public string? DatasetName { get; set; }

    /// <summary>datasetUUID is the UUID of the dataset. This is unique identifier of a Flocker dataset</summary>
    [JsonPropertyName("datasetUUID")]
    public string? DatasetUUID { get; set; }
}

/// <summary>gcePersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk</summary>
public partial class V1PoolerSpecTemplateSpecVolumesGcePersistentDisk
{
    /// <summary>fsType is filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk TODO: how do we prevent errors in the filesystem from compromising the machine</summary>
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    /// <summary>partition is the partition in the volume that you want to mount. If omitted, the default is to mount by volume name. Examples: For volume /dev/sda1, you specify the partition as "1". Similarly, the volume partition for /dev/sda is "0" (or you can leave the property empty). More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk</summary>
    [JsonPropertyName("partition")]
    public int? Partition { get; set; }

    /// <summary>pdName is unique name of the PD resource in GCE. Used to identify the disk in GCE. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk</summary>
    [JsonPropertyName("pdName")]
    public string PdName { get; set; }

    /// <summary>readOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

/// <summary>gitRepo represents a git repository at a particular revision. DEPRECATED: GitRepo is deprecated. To provision a container with a git repo, mount an EmptyDir into an InitContainer that clones the repo using git, then mount the EmptyDir into the Pod's container.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesGitRepo
{
    /// <summary>directory is the target directory name. Must not contain or start with '..'.  If '.' is supplied, the volume directory will be the git repository.  Otherwise, if specified, the volume will contain the git repository in the subdirectory with the given name.</summary>
    [JsonPropertyName("directory")]
    public string? Directory { get; set; }

    /// <summary>repository is the URL</summary>
    [JsonPropertyName("repository")]
    public string Repository { get; set; }

    /// <summary>revision is the commit hash for the specified revision.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }
}

/// <summary>glusterfs represents a Glusterfs mount on the host that shares a pod's lifetime. More info: https://examples.k8s.io/volumes/glusterfs/README.md</summary>
public partial class V1PoolerSpecTemplateSpecVolumesGlusterfs
{
    /// <summary>endpoints is the endpoint name that details Glusterfs topology. More info: https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod</summary>
    [JsonPropertyName("endpoints")]
    public string Endpoints { get; set; }

    /// <summary>path is the Glusterfs volume path. More info: https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>readOnly here will force the Glusterfs volume to be mounted with read-only permissions. Defaults to false. More info: https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

/// <summary>hostPath represents a pre-existing file or directory on the host machine that is directly exposed to the container. This is generally used for system agents or other privileged things that are allowed to see the host machine. Most containers will NOT need this. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath --- TODO(jonesdl) We need to restrict who can use host directory mounts and who can/can not mount host directories as read/write.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesHostPath
{
    /// <summary>path of the directory on the host. If the path is a symlink, it will follow the link to the real path. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>type for HostPath Volume Defaults to "" More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>secretRef is the CHAP Secret for iSCSI target and initiator authentication</summary>
public partial class V1PoolerSpecTemplateSpecVolumesIscsiSecretRef
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>iscsi represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://examples.k8s.io/volumes/iscsi/README.md</summary>
public partial class V1PoolerSpecTemplateSpecVolumesIscsi
{
    /// <summary>chapAuthDiscovery defines whether support iSCSI Discovery CHAP authentication</summary>
    [JsonPropertyName("chapAuthDiscovery")]
    public bool? ChapAuthDiscovery { get; set; }

    /// <summary>chapAuthSession defines whether support iSCSI Session CHAP authentication</summary>
    [JsonPropertyName("chapAuthSession")]
    public bool? ChapAuthSession { get; set; }

    /// <summary>fsType is the filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#iscsi TODO: how do we prevent errors in the filesystem from compromising the machine</summary>
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    /// <summary>initiatorName is the custom iSCSI Initiator Name. If initiatorName is specified with iscsiInterface simultaneously, new iSCSI interface &lt;target portal&gt;:&lt;volume name&gt; will be created for the connection.</summary>
    [JsonPropertyName("initiatorName")]
    public string? InitiatorName { get; set; }

    /// <summary>iqn is the target iSCSI Qualified Name.</summary>
    [JsonPropertyName("iqn")]
    public string Iqn { get; set; }

    /// <summary>iscsiInterface is the interface Name that uses an iSCSI transport. Defaults to 'default' (tcp).</summary>
    [JsonPropertyName("iscsiInterface")]
    public string? IscsiInterface { get; set; }

    /// <summary>lun represents iSCSI Target Lun number.</summary>
    [JsonPropertyName("lun")]
    public int Lun { get; set; }

    /// <summary>portals is the iSCSI Target Portal List. The portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).</summary>
    [JsonPropertyName("portals")]
    public IList<string>? Portals { get; set; }

    /// <summary>readOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>secretRef is the CHAP Secret for iSCSI target and initiator authentication</summary>
    [JsonPropertyName("secretRef")]
    public V1PoolerSpecTemplateSpecVolumesIscsiSecretRef? SecretRef { get; set; }

    /// <summary>targetPortal is iSCSI Target Portal. The Portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).</summary>
    [JsonPropertyName("targetPortal")]
    public string TargetPortal { get; set; }
}

/// <summary>nfs represents an NFS mount on the host that shares a pod's lifetime More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs</summary>
public partial class V1PoolerSpecTemplateSpecVolumesNfs
{
    /// <summary>path that is exported by the NFS server. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>readOnly here will force the NFS export to be mounted with read-only permissions. Defaults to false. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>server is the hostname or IP address of the NFS server. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs</summary>
    [JsonPropertyName("server")]
    public string Server { get; set; }
}

/// <summary>persistentVolumeClaimVolumeSource represents a reference to a PersistentVolumeClaim in the same namespace. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims</summary>
public partial class V1PoolerSpecTemplateSpecVolumesPersistentVolumeClaim
{
    /// <summary>claimName is the name of a PersistentVolumeClaim in the same namespace as the pod using this volume. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims</summary>
    [JsonPropertyName("claimName")]
    public string ClaimName { get; set; }

    /// <summary>readOnly Will force the ReadOnly setting in VolumeMounts. Default false.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

/// <summary>photonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine</summary>
public partial class V1PoolerSpecTemplateSpecVolumesPhotonPersistentDisk
{
    /// <summary>fsType is the filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.</summary>
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    /// <summary>pdID is the ID that identifies Photon Controller persistent disk</summary>
    [JsonPropertyName("pdID")]
    public string PdID { get; set; }
}

/// <summary>portworxVolume represents a portworx volume attached and mounted on kubelets host machine</summary>
public partial class V1PoolerSpecTemplateSpecVolumesPortworxVolume
{
    /// <summary>fSType represents the filesystem type to mount Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs". Implicitly inferred to be "ext4" if unspecified.</summary>
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    /// <summary>readOnly defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>volumeID uniquely identifies a Portworx volume</summary>
    [JsonPropertyName("volumeID")]
    public string VolumeID { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesProjectedSourcesClusterTrustBundleLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Select all ClusterTrustBundles that match this label selector.  Only has effect if signerName is set.  Mutually-exclusive with name.  If unset, interpreted as "match nothing".  If set but empty, interpreted as "match everything".</summary>
public partial class V1PoolerSpecTemplateSpecVolumesProjectedSourcesClusterTrustBundleLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PoolerSpecTemplateSpecVolumesProjectedSourcesClusterTrustBundleLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>ClusterTrustBundle allows a pod to access the `.spec.trustBundle` field of ClusterTrustBundle objects in an auto-updating file.   Alpha, gated by the ClusterTrustBundleProjection feature gate.   ClusterTrustBundle objects can either be selected by name, or by the combination of signer name and a label selector.   Kubelet performs aggressive normalization of the PEM contents written into the pod filesystem.  Esoteric PEM features such as inter-block comments and block headers are stripped.  Certificates are deduplicated. The ordering of certificates within the file is arbitrary, and Kubelet may change the order over time.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesProjectedSourcesClusterTrustBundle
{
    /// <summary>Select all ClusterTrustBundles that match this label selector.  Only has effect if signerName is set.  Mutually-exclusive with name.  If unset, interpreted as "match nothing".  If set but empty, interpreted as "match everything".</summary>
    [JsonPropertyName("labelSelector")]
    public V1PoolerSpecTemplateSpecVolumesProjectedSourcesClusterTrustBundleLabelSelector? LabelSelector { get; set; }

    /// <summary>Select a single ClusterTrustBundle by object name.  Mutually-exclusive with signerName and labelSelector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>If true, don't block pod startup if the referenced ClusterTrustBundle(s) aren't available.  If using name, then the named ClusterTrustBundle is allowed not to exist.  If using signerName, then the combination of signerName and labelSelector is allowed to match zero ClusterTrustBundles.</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    /// <summary>Relative path from the volume root to write the bundle.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>Select all ClusterTrustBundles that match this signer name. Mutually-exclusive with name.  The contents of all selected ClusterTrustBundles will be unified and deduplicated.</summary>
    [JsonPropertyName("signerName")]
    public string? SignerName { get; set; }
}

/// <summary>Maps a string key to a path within a volume.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesProjectedSourcesConfigMapItems
{
    /// <summary>key is the key to project.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>mode is Optional: mode bits used to set permissions on this file. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary>path is the relative path of the file to map the key to. May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary>configMap information about the configMap data to project</summary>
public partial class V1PoolerSpecTemplateSpecVolumesProjectedSourcesConfigMap
{
    /// <summary>items if unspecified, each key-value pair in the Data field of the referenced ConfigMap will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the ConfigMap, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.</summary>
    [JsonPropertyName("items")]
    public IList<V1PoolerSpecTemplateSpecVolumesProjectedSourcesConfigMapItems>? Items { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>optional specify whether the ConfigMap or its keys must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Required: Selects a field of the pod: only annotations, labels, name, namespace and uid are supported.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItemsFieldRef
{
    /// <summary>Version of the schema the FieldPath is written in terms of, defaults to "v1".</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Path of the field to select in the specified API version.</summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}

/// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItemsResourceFieldRef
{
    /// <summary>Container name: required for volumes, optional for env vars</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Specifies the output format of the exposed resources, defaults to "1"</summary>
    [JsonPropertyName("divisor")]
    public IntstrIntOrString? Divisor { get; set; }

    /// <summary>Required: resource to select</summary>
    [JsonPropertyName("resource")]
    public string Resource { get; set; }
}

/// <summary>DownwardAPIVolumeFile represents information to create the file containing the pod field</summary>
public partial class V1PoolerSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItems
{
    /// <summary>Required: Selects a field of the pod: only annotations, labels, name, namespace and uid are supported.</summary>
    [JsonPropertyName("fieldRef")]
    public V1PoolerSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItemsFieldRef? FieldRef { get; set; }

    /// <summary>Optional: mode bits used to set permissions on this file, must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary>Required: Path is  the relative path name of the file to be created. Must not be absolute or contain the '..' path. Must be utf-8 encoded. The first item of the relative path must not start with '..'</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.</summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1PoolerSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItemsResourceFieldRef? ResourceFieldRef { get; set; }
}

/// <summary>downwardAPI information about the downwardAPI data to project</summary>
public partial class V1PoolerSpecTemplateSpecVolumesProjectedSourcesDownwardAPI
{
    /// <summary>Items is a list of DownwardAPIVolume file</summary>
    [JsonPropertyName("items")]
    public IList<V1PoolerSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItems>? Items { get; set; }
}

/// <summary>Maps a string key to a path within a volume.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesProjectedSourcesSecretItems
{
    /// <summary>key is the key to project.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>mode is Optional: mode bits used to set permissions on this file. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary>path is the relative path of the file to map the key to. May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary>secret information about the secret data to project</summary>
public partial class V1PoolerSpecTemplateSpecVolumesProjectedSourcesSecret
{
    /// <summary>items if unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.</summary>
    [JsonPropertyName("items")]
    public IList<V1PoolerSpecTemplateSpecVolumesProjectedSourcesSecretItems>? Items { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>optional field specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>serviceAccountToken is information about the serviceAccountToken data to project</summary>
public partial class V1PoolerSpecTemplateSpecVolumesProjectedSourcesServiceAccountToken
{
    /// <summary>audience is the intended audience of the token. A recipient of a token must identify itself with an identifier specified in the audience of the token, and otherwise should reject the token. The audience defaults to the identifier of the apiserver.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>expirationSeconds is the requested duration of validity of the service account token. As the token approaches expiration, the kubelet volume plugin will proactively rotate the service account token. The kubelet will start trying to rotate the token if the token is older than 80 percent of its time to live or if the token is older than 24 hours.Defaults to 1 hour and must be at least 10 minutes.</summary>
    [JsonPropertyName("expirationSeconds")]
    public long? ExpirationSeconds { get; set; }

    /// <summary>path is the path relative to the mount point of the file to project the token into.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary>Projection that may be projected along with other supported volume types</summary>
public partial class V1PoolerSpecTemplateSpecVolumesProjectedSources
{
    /// <summary>ClusterTrustBundle allows a pod to access the `.spec.trustBundle` field of ClusterTrustBundle objects in an auto-updating file.   Alpha, gated by the ClusterTrustBundleProjection feature gate.   ClusterTrustBundle objects can either be selected by name, or by the combination of signer name and a label selector.   Kubelet performs aggressive normalization of the PEM contents written into the pod filesystem.  Esoteric PEM features such as inter-block comments and block headers are stripped.  Certificates are deduplicated. The ordering of certificates within the file is arbitrary, and Kubelet may change the order over time.</summary>
    [JsonPropertyName("clusterTrustBundle")]
    public V1PoolerSpecTemplateSpecVolumesProjectedSourcesClusterTrustBundle? ClusterTrustBundle { get; set; }

    /// <summary>configMap information about the configMap data to project</summary>
    [JsonPropertyName("configMap")]
    public V1PoolerSpecTemplateSpecVolumesProjectedSourcesConfigMap? ConfigMap { get; set; }

    /// <summary>downwardAPI information about the downwardAPI data to project</summary>
    [JsonPropertyName("downwardAPI")]
    public V1PoolerSpecTemplateSpecVolumesProjectedSourcesDownwardAPI? DownwardAPI { get; set; }

    /// <summary>secret information about the secret data to project</summary>
    [JsonPropertyName("secret")]
    public V1PoolerSpecTemplateSpecVolumesProjectedSourcesSecret? Secret { get; set; }

    /// <summary>serviceAccountToken is information about the serviceAccountToken data to project</summary>
    [JsonPropertyName("serviceAccountToken")]
    public V1PoolerSpecTemplateSpecVolumesProjectedSourcesServiceAccountToken? ServiceAccountToken { get; set; }
}

/// <summary>projected items for all in one resources secrets, configmaps, and downward API</summary>
public partial class V1PoolerSpecTemplateSpecVolumesProjected
{
    /// <summary>defaultMode are the mode bits used to set permissions on created files by default. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    /// <summary>sources is the list of volume projections</summary>
    [JsonPropertyName("sources")]
    public IList<V1PoolerSpecTemplateSpecVolumesProjectedSources>? Sources { get; set; }
}

/// <summary>quobyte represents a Quobyte mount on the host that shares a pod's lifetime</summary>
public partial class V1PoolerSpecTemplateSpecVolumesQuobyte
{
    /// <summary>group to map volume access to Default is no group</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>readOnly here will force the Quobyte volume to be mounted with read-only permissions. Defaults to false.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>registry represents a single or multiple Quobyte Registry services specified as a string as host:port pair (multiple entries are separated with commas) which acts as the central registry for volumes</summary>
    [JsonPropertyName("registry")]
    public string Registry { get; set; }

    /// <summary>tenant owning the given Quobyte volume in the Backend Used with dynamically provisioned Quobyte volumes, value is set by the plugin</summary>
    [JsonPropertyName("tenant")]
    public string? Tenant { get; set; }

    /// <summary>user to map volume access to Defaults to serivceaccount user</summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }

    /// <summary>volume is a string that references an already created Quobyte volume by name.</summary>
    [JsonPropertyName("volume")]
    public string Volume { get; set; }
}

/// <summary>secretRef is name of the authentication secret for RBDUser. If provided overrides keyring. Default is nil. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it</summary>
public partial class V1PoolerSpecTemplateSpecVolumesRbdSecretRef
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>rbd represents a Rados Block Device mount on the host that shares a pod's lifetime. More info: https://examples.k8s.io/volumes/rbd/README.md</summary>
public partial class V1PoolerSpecTemplateSpecVolumesRbd
{
    /// <summary>fsType is the filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#rbd TODO: how do we prevent errors in the filesystem from compromising the machine</summary>
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    /// <summary>image is the rados image name. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it</summary>
    [JsonPropertyName("image")]
    public string Image { get; set; }

    /// <summary>keyring is the path to key ring for RBDUser. Default is /etc/ceph/keyring. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it</summary>
    [JsonPropertyName("keyring")]
    public string? Keyring { get; set; }

    /// <summary>monitors is a collection of Ceph monitors. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it</summary>
    [JsonPropertyName("monitors")]
    public IList<string> Monitors { get; set; }

    /// <summary>pool is the rados pool name. Default is rbd. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it</summary>
    [JsonPropertyName("pool")]
    public string? Pool { get; set; }

    /// <summary>readOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>secretRef is name of the authentication secret for RBDUser. If provided overrides keyring. Default is nil. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it</summary>
    [JsonPropertyName("secretRef")]
    public V1PoolerSpecTemplateSpecVolumesRbdSecretRef? SecretRef { get; set; }

    /// <summary>user is the rados user name. Default is admin. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it</summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary>secretRef references to the secret for ScaleIO user and other sensitive information. If this is not provided, Login operation will fail.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesScaleIOSecretRef
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>scaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesScaleIO
{
    /// <summary>fsType is the filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Default is "xfs".</summary>
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    /// <summary>gateway is the host address of the ScaleIO API Gateway.</summary>
    [JsonPropertyName("gateway")]
    public string Gateway { get; set; }

    /// <summary>protectionDomain is the name of the ScaleIO Protection Domain for the configured storage.</summary>
    [JsonPropertyName("protectionDomain")]
    public string? ProtectionDomain { get; set; }

    /// <summary>readOnly Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>secretRef references to the secret for ScaleIO user and other sensitive information. If this is not provided, Login operation will fail.</summary>
    [JsonPropertyName("secretRef")]
    public V1PoolerSpecTemplateSpecVolumesScaleIOSecretRef SecretRef { get; set; }

    /// <summary>sslEnabled Flag enable/disable SSL communication with Gateway, default false</summary>
    [JsonPropertyName("sslEnabled")]
    public bool? SslEnabled { get; set; }

    /// <summary>storageMode indicates whether the storage for a volume should be ThickProvisioned or ThinProvisioned. Default is ThinProvisioned.</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }

    /// <summary>storagePool is the ScaleIO Storage Pool associated with the protection domain.</summary>
    [JsonPropertyName("storagePool")]
    public string? StoragePool { get; set; }

    /// <summary>system is the name of the storage system as configured in ScaleIO.</summary>
    [JsonPropertyName("system")]
    public string System { get; set; }

    /// <summary>volumeName is the name of a volume already created in the ScaleIO system that is associated with this volume source.</summary>
    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

/// <summary>Maps a string key to a path within a volume.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesSecretItems
{
    /// <summary>key is the key to project.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>mode is Optional: mode bits used to set permissions on this file. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary>path is the relative path of the file to map the key to. May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary>secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret</summary>
public partial class V1PoolerSpecTemplateSpecVolumesSecret
{
    /// <summary>defaultMode is Optional: mode bits used to set permissions on created files by default. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    /// <summary>items If unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.</summary>
    [JsonPropertyName("items")]
    public IList<V1PoolerSpecTemplateSpecVolumesSecretItems>? Items { get; set; }

    /// <summary>optional field specify whether the Secret or its keys must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    /// <summary>secretName is the name of the secret in the pod's namespace to use. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>secretRef specifies the secret to use for obtaining the StorageOS API credentials.  If not specified, default values will be attempted.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesStorageosSecretRef
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>storageOS represents a StorageOS volume attached and mounted on Kubernetes nodes.</summary>
public partial class V1PoolerSpecTemplateSpecVolumesStorageos
{
    /// <summary>fsType is the filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.</summary>
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    /// <summary>readOnly defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>secretRef specifies the secret to use for obtaining the StorageOS API credentials.  If not specified, default values will be attempted.</summary>
    [JsonPropertyName("secretRef")]
    public V1PoolerSpecTemplateSpecVolumesStorageosSecretRef? SecretRef { get; set; }

    /// <summary>volumeName is the human-readable name of the StorageOS volume.  Volume names are only unique within a namespace.</summary>
    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }

    /// <summary>volumeNamespace specifies the scope of the volume within StorageOS.  If no namespace is specified then the Pod's namespace will be used.  This allows the Kubernetes name scoping to be mirrored within StorageOS for tighter integration. Set VolumeName to any name to override the default behaviour. Set to "default" if you are not using namespaces within StorageOS. Namespaces that do not pre-exist within StorageOS will be created.</summary>
    [JsonPropertyName("volumeNamespace")]
    public string? VolumeNamespace { get; set; }
}

/// <summary>vsphereVolume represents a vSphere volume attached and mounted on kubelets host machine</summary>
public partial class V1PoolerSpecTemplateSpecVolumesVsphereVolume
{
    /// <summary>fsType is filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.</summary>
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    /// <summary>storagePolicyID is the storage Policy Based Management (SPBM) profile ID associated with the StoragePolicyName.</summary>
    [JsonPropertyName("storagePolicyID")]
    public string? StoragePolicyID { get; set; }

    /// <summary>storagePolicyName is the storage Policy Based Management (SPBM) profile name.</summary>
    [JsonPropertyName("storagePolicyName")]
    public string? StoragePolicyName { get; set; }

    /// <summary>volumePath is the path that identifies vSphere volume vmdk</summary>
    [JsonPropertyName("volumePath")]
    public string VolumePath { get; set; }
}

/// <summary>Volume represents a named volume in a pod that may be accessed by any container in the pod.</summary>
public partial class V1PoolerSpecTemplateSpecVolumes
{
    /// <summary>awsElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore</summary>
    [JsonPropertyName("awsElasticBlockStore")]
    public V1PoolerSpecTemplateSpecVolumesAwsElasticBlockStore? AwsElasticBlockStore { get; set; }

    /// <summary>azureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.</summary>
    [JsonPropertyName("azureDisk")]
    public V1PoolerSpecTemplateSpecVolumesAzureDisk? AzureDisk { get; set; }

    /// <summary>azureFile represents an Azure File Service mount on the host and bind mount to the pod.</summary>
    [JsonPropertyName("azureFile")]
    public V1PoolerSpecTemplateSpecVolumesAzureFile? AzureFile { get; set; }

    /// <summary>cephFS represents a Ceph FS mount on the host that shares a pod's lifetime</summary>
    [JsonPropertyName("cephfs")]
    public V1PoolerSpecTemplateSpecVolumesCephfs? Cephfs { get; set; }

    /// <summary>cinder represents a cinder volume attached and mounted on kubelets host machine. More info: https://examples.k8s.io/mysql-cinder-pd/README.md</summary>
    [JsonPropertyName("cinder")]
    public V1PoolerSpecTemplateSpecVolumesCinder? Cinder { get; set; }

    /// <summary>configMap represents a configMap that should populate this volume</summary>
    [JsonPropertyName("configMap")]
    public V1PoolerSpecTemplateSpecVolumesConfigMap? ConfigMap { get; set; }

    /// <summary>csi (Container Storage Interface) represents ephemeral storage that is handled by certain external CSI drivers (Beta feature).</summary>
    [JsonPropertyName("csi")]
    public V1PoolerSpecTemplateSpecVolumesCsi? Csi { get; set; }

    /// <summary>downwardAPI represents downward API about the pod that should populate this volume</summary>
    [JsonPropertyName("downwardAPI")]
    public V1PoolerSpecTemplateSpecVolumesDownwardAPI? DownwardAPI { get; set; }

    /// <summary>emptyDir represents a temporary directory that shares a pod's lifetime. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir</summary>
    [JsonPropertyName("emptyDir")]
    public V1PoolerSpecTemplateSpecVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>ephemeral represents a volume that is handled by a cluster storage driver. The volume's lifecycle is tied to the pod that defines it - it will be created before the pod starts, and deleted when the pod is removed.   Use this if: a) the volume is only needed while the pod runs, b) features of normal volumes like restoring from snapshot or capacity    tracking are needed, c) the storage driver is specified through a storage class, and d) the storage driver supports dynamic volume provisioning through    a PersistentVolumeClaim (see EphemeralVolumeSource for more    information on the connection between this volume type    and PersistentVolumeClaim).   Use PersistentVolumeClaim or one of the vendor-specific APIs for volumes that persist for longer than the lifecycle of an individual pod.   Use CSI for light-weight local ephemeral volumes if the CSI driver is meant to be used that way - see the documentation of the driver for more information.   A pod can use both types of ephemeral volumes and persistent volumes at the same time.</summary>
    [JsonPropertyName("ephemeral")]
    public V1PoolerSpecTemplateSpecVolumesEphemeral? Ephemeral { get; set; }

    /// <summary>fc represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.</summary>
    [JsonPropertyName("fc")]
    public V1PoolerSpecTemplateSpecVolumesFc? Fc { get; set; }

    /// <summary>flexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin.</summary>
    [JsonPropertyName("flexVolume")]
    public V1PoolerSpecTemplateSpecVolumesFlexVolume? FlexVolume { get; set; }

    /// <summary>flocker represents a Flocker volume attached to a kubelet's host machine. This depends on the Flocker control service being running</summary>
    [JsonPropertyName("flocker")]
    public V1PoolerSpecTemplateSpecVolumesFlocker? Flocker { get; set; }

    /// <summary>gcePersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk</summary>
    [JsonPropertyName("gcePersistentDisk")]
    public V1PoolerSpecTemplateSpecVolumesGcePersistentDisk? GcePersistentDisk { get; set; }

    /// <summary>gitRepo represents a git repository at a particular revision. DEPRECATED: GitRepo is deprecated. To provision a container with a git repo, mount an EmptyDir into an InitContainer that clones the repo using git, then mount the EmptyDir into the Pod's container.</summary>
    [JsonPropertyName("gitRepo")]
    public V1PoolerSpecTemplateSpecVolumesGitRepo? GitRepo { get; set; }

    /// <summary>glusterfs represents a Glusterfs mount on the host that shares a pod's lifetime. More info: https://examples.k8s.io/volumes/glusterfs/README.md</summary>
    [JsonPropertyName("glusterfs")]
    public V1PoolerSpecTemplateSpecVolumesGlusterfs? Glusterfs { get; set; }

    /// <summary>hostPath represents a pre-existing file or directory on the host machine that is directly exposed to the container. This is generally used for system agents or other privileged things that are allowed to see the host machine. Most containers will NOT need this. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath --- TODO(jonesdl) We need to restrict who can use host directory mounts and who can/can not mount host directories as read/write.</summary>
    [JsonPropertyName("hostPath")]
    public V1PoolerSpecTemplateSpecVolumesHostPath? HostPath { get; set; }

    /// <summary>iscsi represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://examples.k8s.io/volumes/iscsi/README.md</summary>
    [JsonPropertyName("iscsi")]
    public V1PoolerSpecTemplateSpecVolumesIscsi? Iscsi { get; set; }

    /// <summary>name of the volume. Must be a DNS_LABEL and unique within the pod. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>nfs represents an NFS mount on the host that shares a pod's lifetime More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs</summary>
    [JsonPropertyName("nfs")]
    public V1PoolerSpecTemplateSpecVolumesNfs? Nfs { get; set; }

    /// <summary>persistentVolumeClaimVolumeSource represents a reference to a PersistentVolumeClaim in the same namespace. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims</summary>
    [JsonPropertyName("persistentVolumeClaim")]
    public V1PoolerSpecTemplateSpecVolumesPersistentVolumeClaim? PersistentVolumeClaim { get; set; }

    /// <summary>photonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine</summary>
    [JsonPropertyName("photonPersistentDisk")]
    public V1PoolerSpecTemplateSpecVolumesPhotonPersistentDisk? PhotonPersistentDisk { get; set; }

    /// <summary>portworxVolume represents a portworx volume attached and mounted on kubelets host machine</summary>
    [JsonPropertyName("portworxVolume")]
    public V1PoolerSpecTemplateSpecVolumesPortworxVolume? PortworxVolume { get; set; }

    /// <summary>projected items for all in one resources secrets, configmaps, and downward API</summary>
    [JsonPropertyName("projected")]
    public V1PoolerSpecTemplateSpecVolumesProjected? Projected { get; set; }

    /// <summary>quobyte represents a Quobyte mount on the host that shares a pod's lifetime</summary>
    [JsonPropertyName("quobyte")]
    public V1PoolerSpecTemplateSpecVolumesQuobyte? Quobyte { get; set; }

    /// <summary>rbd represents a Rados Block Device mount on the host that shares a pod's lifetime. More info: https://examples.k8s.io/volumes/rbd/README.md</summary>
    [JsonPropertyName("rbd")]
    public V1PoolerSpecTemplateSpecVolumesRbd? Rbd { get; set; }

    /// <summary>scaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.</summary>
    [JsonPropertyName("scaleIO")]
    public V1PoolerSpecTemplateSpecVolumesScaleIO? ScaleIO { get; set; }

    /// <summary>secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret</summary>
    [JsonPropertyName("secret")]
    public V1PoolerSpecTemplateSpecVolumesSecret? Secret { get; set; }

    /// <summary>storageOS represents a StorageOS volume attached and mounted on Kubernetes nodes.</summary>
    [JsonPropertyName("storageos")]
    public V1PoolerSpecTemplateSpecVolumesStorageos? Storageos { get; set; }

    /// <summary>vsphereVolume represents a vSphere volume attached and mounted on kubelets host machine</summary>
    [JsonPropertyName("vsphereVolume")]
    public V1PoolerSpecTemplateSpecVolumesVsphereVolume? VsphereVolume { get; set; }
}

/// <summary>Specification of the desired behavior of the pod. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
public partial class V1PoolerSpecTemplateSpec
{
    /// <summary>Optional duration in seconds the pod may be active on the node relative to StartTime before the system will actively try to mark it failed and kill associated containers. Value must be a positive integer.</summary>
    [JsonPropertyName("activeDeadlineSeconds")]
    public long? ActiveDeadlineSeconds { get; set; }

    /// <summary>If specified, the pod's scheduling constraints</summary>
    [JsonPropertyName("affinity")]
    public V1PoolerSpecTemplateSpecAffinity? Affinity { get; set; }

    /// <summary>AutomountServiceAccountToken indicates whether a service account token should be automatically mounted.</summary>
    [JsonPropertyName("automountServiceAccountToken")]
    public bool? AutomountServiceAccountToken { get; set; }

    /// <summary>List of containers belonging to the pod. Containers cannot currently be added or removed. There must be at least one container in a Pod. Cannot be updated.</summary>
    [JsonPropertyName("containers")]
    public IList<V1PoolerSpecTemplateSpecContainers> Containers { get; set; }

    /// <summary>Specifies the DNS parameters of a pod. Parameters specified here will be merged to the generated DNS configuration based on DNSPolicy.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1PoolerSpecTemplateSpecDnsConfig? DnsConfig { get; set; }

    /// <summary>Set DNS policy for the pod. Defaults to "ClusterFirst". Valid values are 'ClusterFirstWithHostNet', 'ClusterFirst', 'Default' or 'None'. DNS parameters given in DNSConfig will be merged with the policy selected with DNSPolicy. To have DNS options set along with hostNetwork, you have to specify DNS policy explicitly to 'ClusterFirstWithHostNet'.</summary>
    [JsonPropertyName("dnsPolicy")]
    public string? DnsPolicy { get; set; }

    /// <summary>EnableServiceLinks indicates whether information about services should be injected into pod's environment variables, matching the syntax of Docker links. Optional: Defaults to true.</summary>
    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    /// <summary>List of ephemeral containers run in this pod. Ephemeral containers may be run in an existing pod to perform user-initiated actions such as debugging. This list cannot be specified when creating a pod, and it cannot be modified by updating the pod spec. In order to add an ephemeral container to an existing pod, use the pod's ephemeralcontainers subresource.</summary>
    [JsonPropertyName("ephemeralContainers")]
    public IList<V1PoolerSpecTemplateSpecEphemeralContainers>? EphemeralContainers { get; set; }

    /// <summary>HostAliases is an optional list of hosts and IPs that will be injected into the pod's hosts file if specified.</summary>
    [JsonPropertyName("hostAliases")]
    public IList<V1PoolerSpecTemplateSpecHostAliases>? HostAliases { get; set; }

    /// <summary>Use the host's ipc namespace. Optional: Default to false.</summary>
    [JsonPropertyName("hostIPC")]
    public bool? HostIPC { get; set; }

    /// <summary>Host networking requested for this pod. Use the host's network namespace. If this option is set, the ports that will be used must be specified. Default to false.</summary>
    [JsonPropertyName("hostNetwork")]
    public bool? HostNetwork { get; set; }

    /// <summary>Use the host's pid namespace. Optional: Default to false.</summary>
    [JsonPropertyName("hostPID")]
    public bool? HostPID { get; set; }

    /// <summary>Use the host's user namespace. Optional: Default to true. If set to true or not present, the pod will be run in the host user namespace, useful for when the pod needs a feature only available to the host user namespace, such as loading a kernel module with CAP_SYS_MODULE. When set to false, a new userns is created for the pod. Setting false is useful for mitigating container breakout vulnerabilities even allowing users to run their containers as root without actually having root privileges on the host. This field is alpha-level and is only honored by servers that enable the UserNamespacesSupport feature.</summary>
    [JsonPropertyName("hostUsers")]
    public bool? HostUsers { get; set; }

    /// <summary>Specifies the hostname of the Pod If not specified, the pod's hostname will be set to a system-defined value.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>ImagePullSecrets is an optional list of references to secrets in the same namespace to use for pulling any of the images used by this PodSpec. If specified, these secrets will be passed to individual puller implementations for them to use. More info: https://kubernetes.io/docs/concepts/containers/images#specifying-imagepullsecrets-on-a-pod</summary>
    [JsonPropertyName("imagePullSecrets")]
    public IList<V1PoolerSpecTemplateSpecImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary>List of initialization containers belonging to the pod. Init containers are executed in order prior to containers being started. If any init container fails, the pod is considered to have failed and is handled according to its restartPolicy. The name for an init container or normal container must be unique among all containers. Init containers may not have Lifecycle actions, Readiness probes, Liveness probes, or Startup probes. The resourceRequirements of an init container are taken into account during scheduling by finding the highest request/limit for each resource type, and then using the max of of that value or the sum of the normal containers. Limits are applied to init containers in a similar fashion. Init containers cannot currently be added or removed. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/init-containers/</summary>
    [JsonPropertyName("initContainers")]
    public IList<V1PoolerSpecTemplateSpecInitContainers>? InitContainers { get; set; }

    /// <summary>NodeName is a request to schedule this pod onto a specific node. If it is non-empty, the scheduler simply schedules this pod onto that node, assuming that it fits resource requirements.</summary>
    [JsonPropertyName("nodeName")]
    public string? NodeName { get; set; }

    /// <summary>NodeSelector is a selector which must be true for the pod to fit on a node. Selector which must match a node's labels for the pod to be scheduled on that node. More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/</summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>Specifies the OS of the containers in the pod. Some pod and container fields are restricted if this is set.   If the OS field is set to linux, the following fields must be unset: -securityContext.windowsOptions   If the OS field is set to windows, following fields must be unset: - spec.hostPID - spec.hostIPC - spec.hostUsers - spec.securityContext.appArmorProfile - spec.securityContext.seLinuxOptions - spec.securityContext.seccompProfile - spec.securityContext.fsGroup - spec.securityContext.fsGroupChangePolicy - spec.securityContext.sysctls - spec.shareProcessNamespace - spec.securityContext.runAsUser - spec.securityContext.runAsGroup - spec.securityContext.supplementalGroups - spec.containers[*].securityContext.appArmorProfile - spec.containers[*].securityContext.seLinuxOptions - spec.containers[*].securityContext.seccompProfile - spec.containers[*].securityContext.capabilities - spec.containers[*].securityContext.readOnlyRootFilesystem - spec.containers[*].securityContext.privileged - spec.containers[*].securityContext.allowPrivilegeEscalation - spec.containers[*].securityContext.procMount - spec.containers[*].securityContext.runAsUser - spec.containers[*].securityContext.runAsGroup</summary>
    [JsonPropertyName("os")]
    public V1PoolerSpecTemplateSpecOs? Os { get; set; }

    /// <summary>Overhead represents the resource overhead associated with running a pod for a given RuntimeClass. This field will be autopopulated at admission time by the RuntimeClass admission controller. If the RuntimeClass admission controller is enabled, overhead must not be set in Pod create requests. The RuntimeClass admission controller will reject Pod create requests which have the overhead already set. If RuntimeClass is configured and selected in the PodSpec, Overhead will be set to the value defined in the corresponding RuntimeClass, otherwise it will remain unset and treated as zero. More info: https://git.k8s.io/enhancements/keps/sig-node/688-pod-overhead/README.md</summary>
    [JsonPropertyName("overhead")]
    public IDictionary<string, IntstrIntOrString>? Overhead { get; set; }

    /// <summary>PreemptionPolicy is the Policy for preempting pods with lower priority. One of Never, PreemptLowerPriority. Defaults to PreemptLowerPriority if unset.</summary>
    [JsonPropertyName("preemptionPolicy")]
    public string? PreemptionPolicy { get; set; }

    /// <summary>The priority value. Various system components use this field to find the priority of the pod. When Priority Admission Controller is enabled, it prevents users from setting this field. The admission controller populates this field from PriorityClassName. The higher the value, the higher the priority.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>If specified, indicates the pod's priority. "system-node-critical" and "system-cluster-critical" are two special keywords which indicate the highest priorities with the former being the highest priority. Any other name must be defined by creating a PriorityClass object with that name. If not specified, the pod priority will be default or zero if there is no default.</summary>
    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    /// <summary>If specified, all readiness gates will be evaluated for pod readiness. A pod is ready when all its containers are ready AND all conditions specified in the readiness gates have status equal to "True" More info: https://git.k8s.io/enhancements/keps/sig-network/580-pod-readiness-gates</summary>
    [JsonPropertyName("readinessGates")]
    public IList<V1PoolerSpecTemplateSpecReadinessGates>? ReadinessGates { get; set; }

    /// <summary>ResourceClaims defines which ResourceClaims must be allocated and reserved before the Pod is allowed to start. The resources will be made available to those containers which consume them by name.   This is an alpha field and requires enabling the DynamicResourceAllocation feature gate.   This field is immutable.</summary>
    [JsonPropertyName("resourceClaims")]
    public IList<V1PoolerSpecTemplateSpecResourceClaims>? ResourceClaims { get; set; }

    /// <summary>Restart policy for all containers within the pod. One of Always, OnFailure, Never. In some contexts, only a subset of those values may be permitted. Default to Always. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle/#restart-policy</summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary>RuntimeClassName refers to a RuntimeClass object in the node.k8s.io group, which should be used to run this pod.  If no RuntimeClass resource matches the named class, the pod will not be run. If unset or empty, the "legacy" RuntimeClass will be used, which is an implicit class with an empty definition that uses the default runtime handler. More info: https://git.k8s.io/enhancements/keps/sig-node/585-runtime-class</summary>
    [JsonPropertyName("runtimeClassName")]
    public string? RuntimeClassName { get; set; }

    /// <summary>If specified, the pod will be dispatched by specified scheduler. If not specified, the pod will be dispatched by default scheduler.</summary>
    [JsonPropertyName("schedulerName")]
    public string? SchedulerName { get; set; }

    /// <summary>SchedulingGates is an opaque list of values that if specified will block scheduling the pod. If schedulingGates is not empty, the pod will stay in the SchedulingGated state and the scheduler will not attempt to schedule the pod.   SchedulingGates can only be set at pod creation time, and be removed only afterwards.</summary>
    [JsonPropertyName("schedulingGates")]
    public IList<V1PoolerSpecTemplateSpecSchedulingGates>? SchedulingGates { get; set; }

    /// <summary>SecurityContext holds pod-level security attributes and common container settings. Optional: Defaults to empty.  See type description for default values of each field.</summary>
    [JsonPropertyName("securityContext")]
    public V1PoolerSpecTemplateSpecSecurityContext? SecurityContext { get; set; }

    /// <summary>DeprecatedServiceAccount is a deprecated alias for ServiceAccountName. Deprecated: Use serviceAccountName instead.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>ServiceAccountName is the name of the ServiceAccount to use to run this pod. More info: https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>If true the pod's hostname will be configured as the pod's FQDN, rather than the leaf name (the default). In Linux containers, this means setting the FQDN in the hostname field of the kernel (the nodename field of struct utsname). In Windows containers, this means setting the registry value of hostname for the registry key HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters to FQDN. If a pod does not have FQDN, this has no effect. Default to false.</summary>
    [JsonPropertyName("setHostnameAsFQDN")]
    public bool? SetHostnameAsFQDN { get; set; }

    /// <summary>Share a single process namespace between all of the containers in a pod. When this is set containers will be able to view and signal processes from other containers in the same pod, and the first process in each container will not be assigned PID 1. HostPID and ShareProcessNamespace cannot both be set. Optional: Default to false.</summary>
    [JsonPropertyName("shareProcessNamespace")]
    public bool? ShareProcessNamespace { get; set; }

    /// <summary>If specified, the fully qualified Pod hostname will be "&lt;hostname&gt;.&lt;subdomain&gt;.&lt;pod namespace&gt;.svc.&lt;cluster domain&gt;". If not specified, the pod will not have a domainname at all.</summary>
    [JsonPropertyName("subdomain")]
    public string? Subdomain { get; set; }

    /// <summary>Optional duration in seconds the pod needs to terminate gracefully. May be decreased in delete request. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). If this value is nil, the default grace period will be used instead. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. Defaults to 30 seconds.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary>If specified, the pod's tolerations.</summary>
    [JsonPropertyName("tolerations")]
    public IList<V1PoolerSpecTemplateSpecTolerations>? Tolerations { get; set; }

    /// <summary>TopologySpreadConstraints describes how a group of pods ought to spread across topology domains. Scheduler will schedule pods in a way which abides by the constraints. All topologySpreadConstraints are ANDed.</summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1PoolerSpecTemplateSpecTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }

    /// <summary>List of volumes that can be mounted by containers belonging to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes</summary>
    [JsonPropertyName("volumes")]
    public IList<V1PoolerSpecTemplateSpecVolumes>? Volumes { get; set; }
}

/// <summary>The template of the Pod to be created</summary>
public partial class V1PoolerSpecTemplate
{
    /// <summary>Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1PoolerSpecTemplateMetadata? Metadata { get; set; }

    /// <summary>Specification of the desired behavior of the pod. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("spec")]
    public V1PoolerSpecTemplateSpec? Spec { get; set; }
}

public enum V1PoolerSpecTypeEnum
{
    [EnumMember(Value = "rw"), JsonStringEnumMemberName("rw")]
    /// <summary>rw</summary>
    Rw,
    [EnumMember(Value = "ro"), JsonStringEnumMemberName("ro")]
    /// <summary>ro</summary>
    Ro
}

/// <summary>Specification of the desired behavior of the Pooler. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
public partial class V1PoolerSpec
{
    /// <summary>This is the cluster reference on which the Pooler will work. Pooler name should never match with any cluster name within the same namespace.</summary>
    [JsonPropertyName("cluster")]
    public V1PoolerSpecCluster Cluster { get; set; }

    /// <summary>The deployment strategy to use for pgbouncer to replace existing pods with new ones</summary>
    [JsonPropertyName("deploymentStrategy")]
    public V1PoolerSpecDeploymentStrategy? DeploymentStrategy { get; set; }

    /// <summary>The number of replicas we want. Default: 1.</summary>
    [JsonPropertyName("instances")]
    public int? Instances { get; set; }

    /// <summary>The configuration of the monitoring infrastructure of this pooler.</summary>
    [JsonPropertyName("monitoring")]
    public V1PoolerSpecMonitoring? Monitoring { get; set; }

    /// <summary>The PgBouncer configuration</summary>
    [JsonPropertyName("pgbouncer")]
    public V1PoolerSpecPgbouncer Pgbouncer { get; set; }

    /// <summary>Template for the Service to be created</summary>
    [JsonPropertyName("serviceTemplate")]
    public V1PoolerSpecServiceTemplate? ServiceTemplate { get; set; }

    /// <summary>The template of the Pod to be created</summary>
    [JsonPropertyName("template")]
    public V1PoolerSpecTemplate? Template { get; set; }

    /// <summary>Type of service to forward traffic to. Default: `rw`.</summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1PoolerSpecTypeEnum>))]
    public V1PoolerSpecTypeEnum? Type { get; set; }
}

/// <summary>The client CA secret version</summary>
public partial class V1PoolerStatusSecretsClientCA
{
    /// <summary>The name of the secret</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ResourceVersion of the secret</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>The auth query secret version</summary>
public partial class V1PoolerStatusSecretsPgBouncerSecretsAuthQuery
{
    /// <summary>The name of the secret</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ResourceVersion of the secret</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>The version of the secrets used by PgBouncer</summary>
public partial class V1PoolerStatusSecretsPgBouncerSecrets
{
    /// <summary>The auth query secret version</summary>
    [JsonPropertyName("authQuery")]
    public V1PoolerStatusSecretsPgBouncerSecretsAuthQuery? AuthQuery { get; set; }
}

/// <summary>The server CA secret version</summary>
public partial class V1PoolerStatusSecretsServerCA
{
    /// <summary>The name of the secret</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ResourceVersion of the secret</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>The server TLS secret version</summary>
public partial class V1PoolerStatusSecretsServerTLS
{
    /// <summary>The name of the secret</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ResourceVersion of the secret</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>The resource version of the config object</summary>
public partial class V1PoolerStatusSecrets
{
    /// <summary>The client CA secret version</summary>
    [JsonPropertyName("clientCA")]
    public V1PoolerStatusSecretsClientCA? ClientCA { get; set; }

    /// <summary>The version of the secrets used by PgBouncer</summary>
    [JsonPropertyName("pgBouncerSecrets")]
    public V1PoolerStatusSecretsPgBouncerSecrets? PgBouncerSecrets { get; set; }

    /// <summary>The server CA secret version</summary>
    [JsonPropertyName("serverCA")]
    public V1PoolerStatusSecretsServerCA? ServerCA { get; set; }

    /// <summary>The server TLS secret version</summary>
    [JsonPropertyName("serverTLS")]
    public V1PoolerStatusSecretsServerTLS? ServerTLS { get; set; }
}

/// <summary>Most recently observed status of the Pooler. This data may not be up to date. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
public partial class V1PoolerStatus
{
    /// <summary>The number of pods trying to be scheduled</summary>
    [JsonPropertyName("instances")]
    public int? Instances { get; set; }

    /// <summary>The resource version of the config object</summary>
    [JsonPropertyName("secrets")]
    public V1PoolerStatusSecrets? Secrets { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Pooler is the Schema for the poolers API</summary>
public partial class V1Pooler : IKubernetesObject<V1ObjectMeta>, ISpec<V1PoolerSpec>, IStatus<V1PoolerStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Pooler";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "poolers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Specification of the desired behavior of the Pooler. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("spec")]
    public V1PoolerSpec Spec { get; set; }

    /// <summary>Most recently observed status of the Pooler. This data may not be up to date. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("status")]
    public V1PoolerStatus? Status { get; set; }
}