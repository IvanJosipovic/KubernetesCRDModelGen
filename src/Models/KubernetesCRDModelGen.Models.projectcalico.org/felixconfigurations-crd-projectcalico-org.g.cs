using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
/// <summary>ProtoPort is combination of protocol, port, and CIDR. Protocol and port must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1FelixConfigurationSpecFailsafeInboundHostPorts
{
    /// <summary></summary>
    [JsonPropertyName("net")]
    public string? Net { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string Protocol { get; set; }
}

/// <summary>ProtoPort is combination of protocol, port, and CIDR. Protocol and port must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1FelixConfigurationSpecFailsafeOutboundHostPorts
{
    /// <summary></summary>
    [JsonPropertyName("net")]
    public string? Net { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1FelixConfigurationSpecHealthTimeoutOverrides
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeout")]
    public string Timeout { get; set; }
}

/// <summary>Deprecated in favor of RouteTableRanges. Calico programs additional Linux route tables for various purposes. RouteTableRange specifies the indices of the route tables that Calico should use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1FelixConfigurationSpecRouteTableRange
{
    /// <summary></summary>
    [JsonPropertyName("max")]
    public int Max { get; set; }

    /// <summary></summary>
    [JsonPropertyName("min")]
    public int Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1FelixConfigurationSpecRouteTableRanges
{
    /// <summary></summary>
    [JsonPropertyName("max")]
    public int Max { get; set; }

    /// <summary></summary>
    [JsonPropertyName("min")]
    public int Min { get; set; }
}

/// <summary>FelixConfigurationSpec contains the values of the Felix configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1FelixConfigurationSpec
{
    /// <summary>AllowIPIPPacketsFromWorkloads controls whether Felix will add a rule to drop IPIP encapsulated traffic from workloads [Default: false]</summary>
    [JsonPropertyName("allowIPIPPacketsFromWorkloads")]
    public bool? AllowIPIPPacketsFromWorkloads { get; set; }

    /// <summary>AllowVXLANPacketsFromWorkloads controls whether Felix will add a rule to drop VXLAN encapsulated traffic from workloads [Default: false]</summary>
    [JsonPropertyName("allowVXLANPacketsFromWorkloads")]
    public bool? AllowVXLANPacketsFromWorkloads { get; set; }

    /// <summary>Set source-destination-check on AWS EC2 instances. Accepted value must be one of "DoNothing", "Enable" or "Disable". [Default: DoNothing]</summary>
    [JsonPropertyName("awsSrcDstCheck")]
    public string? AwsSrcDstCheck { get; set; }

    /// <summary>BPFCTLBLogFilter specifies, what is logged by connect time load balancer when BPFLogLevel is debug. Currently has to be specified as 'all' when BPFLogFilters is set to see CTLB logs. [Default: unset - means logs are emitted when BPFLogLevel id debug and BPFLogFilters not set.]</summary>
    [JsonPropertyName("bpfCTLBLogFilter")]
    public string? BpfCTLBLogFilter { get; set; }

    /// <summary>BPFConnectTimeLoadBalancing when in BPF mode, controls whether Felix installs the connect-time load balancer. The connect-time load balancer is required for the host to be able to reach Kubernetes services and it improves the performance of pod-to-service connections.When set to TCP, connect time load balancing is available only for services with TCP ports. [Default: TCP]</summary>
    [JsonPropertyName("bpfConnectTimeLoadBalancing")]
    public string? BpfConnectTimeLoadBalancing { get; set; }

    /// <summary>BPFConnectTimeLoadBalancingEnabled when in BPF mode, controls whether Felix installs the connection-time load balancer.  The connect-time load balancer is required for the host to be able to reach Kubernetes services and it improves the performance of pod-to-service connections.  The only reason to disable it is for debugging purposes. This will be deprecated. Use BPFConnectTimeLoadBalancing [Default: true]</summary>
    [JsonPropertyName("bpfConnectTimeLoadBalancingEnabled")]
    public bool? BpfConnectTimeLoadBalancingEnabled { get; set; }

    /// <summary>BPFDSROptoutCIDRs is a list of CIDRs which are excluded from DSR. That is, clients in those CIDRs will accesses nodeports as if BPFExternalServiceMode was set to Tunnel.</summary>
    [JsonPropertyName("bpfDSROptoutCIDRs")]
    public IList<string>? BpfDSROptoutCIDRs { get; set; }

    /// <summary>BPFDataIfacePattern is a regular expression that controls which interfaces Felix should attach BPF programs to in order to catch traffic to/from the network.  This needs to match the interfaces that Calico workload traffic flows over as well as any interfaces that handle incoming traffic to nodeports and services from outside the cluster.  It should not match the workload interfaces (usually named cali...).</summary>
    [JsonPropertyName("bpfDataIfacePattern")]
    public string? BpfDataIfacePattern { get; set; }

    /// <summary>BPFDisableGROForIfaces is a regular expression that controls which interfaces Felix should disable the Generic Receive Offload [GRO] option.  It should not match the workload interfaces (usually named cali...).</summary>
    [JsonPropertyName("bpfDisableGROForIfaces")]
    public string? BpfDisableGROForIfaces { get; set; }

    /// <summary>BPFDisableUnprivileged, if enabled, Felix sets the kernel.unprivileged_bpf_disabled sysctl to disable unprivileged use of BPF.  This ensures that unprivileged users cannot access Calico's BPF maps and cannot insert their own BPF programs to interfere with Calico's. [Default: true]</summary>
    [JsonPropertyName("bpfDisableUnprivileged")]
    public bool? BpfDisableUnprivileged { get; set; }

    /// <summary>BPFEnabled, if enabled Felix will use the BPF dataplane. [Default: false]</summary>
    [JsonPropertyName("bpfEnabled")]
    public bool? BpfEnabled { get; set; }

    /// <summary>BPFEnforceRPF enforce strict RPF on all host interfaces with BPF programs regardless of what is the per-interfaces or global setting. Possible values are Disabled, Strict or Loose. [Default: Loose]</summary>
    [JsonPropertyName("bpfEnforceRPF")]
    public string? BpfEnforceRPF { get; set; }

    /// <summary>BPFExcludeCIDRsFromNAT is a list of CIDRs that are to be excluded from NAT resolution so that host can handle them. A typical usecase is node local DNS cache.</summary>
    [JsonPropertyName("bpfExcludeCIDRsFromNAT")]
    public IList<string>? BpfExcludeCIDRsFromNAT { get; set; }

    /// <summary>BPFExtToServiceConnmark in BPF mode, control a 32bit mark that is set on connections from an external client to a local service. This mark allows us to control how packets of that connection are routed within the host and how is routing interpreted by RPF check. [Default: 0]</summary>
    [JsonPropertyName("bpfExtToServiceConnmark")]
    public int? BpfExtToServiceConnmark { get; set; }

    /// <summary>BPFExternalServiceMode in BPF mode, controls how connections from outside the cluster to services (node ports and cluster IPs) are forwarded to remote workloads.  If set to "Tunnel" then both request and response traffic is tunneled to the remote node.  If set to "DSR", the request traffic is tunneled but the response traffic is sent directly from the remote node.  In "DSR" mode, the remote node appears to use the IP of the ingress node; this requires a permissive L2 network.  [Default: Tunnel]</summary>
    [JsonPropertyName("bpfExternalServiceMode")]
    public string? BpfExternalServiceMode { get; set; }

    /// <summary>BPFForceTrackPacketsFromIfaces in BPF mode, forces traffic from these interfaces to skip Calico's iptables NOTRACK rule, allowing traffic from those interfaces to be tracked by Linux conntrack.  Should only be used for interfaces that are not used for the Calico fabric.  For example, a docker bridge device for non-Calico-networked containers. [Default: docker+]</summary>
    [JsonPropertyName("bpfForceTrackPacketsFromIfaces")]
    public IList<string>? BpfForceTrackPacketsFromIfaces { get; set; }

    /// <summary>BPFHostConntrackBypass Controls whether to bypass Linux conntrack in BPF mode for workloads and services. [Default: true - bypass Linux conntrack]</summary>
    [JsonPropertyName("bpfHostConntrackBypass")]
    public bool? BpfHostConntrackBypass { get; set; }

    /// <summary>BPFHostNetworkedNATWithoutCTLB when in BPF mode, controls whether Felix does a NAT without CTLB. This along with BPFConnectTimeLoadBalancing determines the CTLB behavior. [Default: Enabled]</summary>
    [JsonPropertyName("bpfHostNetworkedNATWithoutCTLB")]
    public string? BpfHostNetworkedNATWithoutCTLB { get; set; }

    /// <summary>BPFKubeProxyEndpointSlicesEnabled is deprecated and has no effect. BPF kube-proxy always accepts endpoint slices. This option will be removed in the next release.</summary>
    [JsonPropertyName("bpfKubeProxyEndpointSlicesEnabled")]
    public bool? BpfKubeProxyEndpointSlicesEnabled { get; set; }

    /// <summary>BPFKubeProxyIptablesCleanupEnabled, if enabled in BPF mode, Felix will proactively clean up the upstream Kubernetes kube-proxy's iptables chains.  Should only be enabled if kube-proxy is not running.  [Default: true]</summary>
    [JsonPropertyName("bpfKubeProxyIptablesCleanupEnabled")]
    public bool? BpfKubeProxyIptablesCleanupEnabled { get; set; }

    /// <summary>BPFKubeProxyMinSyncPeriod, in BPF mode, controls the minimum time between updates to the dataplane for Felix's embedded kube-proxy.  Lower values give reduced set-up latency.  Higher values reduce Felix CPU usage by batching up more work.  [Default: 1s]</summary>
    [JsonPropertyName("bpfKubeProxyMinSyncPeriod")]
    public string? BpfKubeProxyMinSyncPeriod { get; set; }

    /// <summary>BPFL3IfacePattern is a regular expression that allows to list tunnel devices like wireguard or vxlan (i.e., L3 devices) in addition to BPFDataIfacePattern. That is, tunnel interfaces not created by Calico, that Calico workload traffic flows over as well as any interfaces that handle incoming traffic to nodeports and services from outside the cluster.</summary>
    [JsonPropertyName("bpfL3IfacePattern")]
    public string? BpfL3IfacePattern { get; set; }

    /// <summary>BPFLogFilters is a map of key=values where the value is a pcap filter expression and the key is an interface name with 'all' denoting all interfaces, 'weps' all workload endpoints and 'heps' all host endpoints.   When specified as an env var, it accepts a comma-separated list of key=values. [Default: unset - means all debug logs are emitted]</summary>
    [JsonPropertyName("bpfLogFilters")]
    public IDictionary<string, string>? BpfLogFilters { get; set; }

    /// <summary>BPFLogLevel controls the log level of the BPF programs when in BPF dataplane mode.  One of "Off", "Info", or "Debug".  The logs are emitted to the BPF trace pipe, accessible with the command `tc exec bpf debug`. [Default: Off].</summary>
    [JsonPropertyName("bpfLogLevel")]
    public string? BpfLogLevel { get; set; }

    /// <summary>BPFMapSizeConntrack sets the size for the conntrack map.  This map must be large enough to hold an entry for each active connection.  Warning: changing the size of the conntrack map can cause disruption.</summary>
    [JsonPropertyName("bpfMapSizeConntrack")]
    public int? BpfMapSizeConntrack { get; set; }

    /// <summary>BPFMapSizeIPSets sets the size for ipsets map.  The IP sets map must be large enough to hold an entry for each endpoint matched by every selector in the source/destination matches in network policy.  Selectors such as "all()" can result in large numbers of entries (one entry per endpoint in that case).</summary>
    [JsonPropertyName("bpfMapSizeIPSets")]
    public int? BpfMapSizeIPSets { get; set; }

    /// <summary>BPFMapSizeIfState sets the size for ifstate map.  The ifstate map must be large enough to hold an entry for each device (host + workloads) on a host.</summary>
    [JsonPropertyName("bpfMapSizeIfState")]
    public int? BpfMapSizeIfState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bpfMapSizeNATAffinity")]
    public int? BpfMapSizeNATAffinity { get; set; }

    /// <summary>BPFMapSizeNATBackend sets the size for nat back end map. This is the total number of endpoints. This is mostly more than the size of the number of services.</summary>
    [JsonPropertyName("bpfMapSizeNATBackend")]
    public int? BpfMapSizeNATBackend { get; set; }

    /// <summary>BPFMapSizeNATFrontend sets the size for nat front end map. FrontendMap should be large enough to hold an entry for each nodeport, external IP and each port in each service.</summary>
    [JsonPropertyName("bpfMapSizeNATFrontend")]
    public int? BpfMapSizeNATFrontend { get; set; }

    /// <summary>BPFMapSizeRoute sets the size for the routes map.  The routes map should be large enough to hold one entry per workload and a handful of entries per host (enough to cover its own IPs and tunnel IPs).</summary>
    [JsonPropertyName("bpfMapSizeRoute")]
    public int? BpfMapSizeRoute { get; set; }

    /// <summary>BPFPSNATPorts sets the range from which we randomly pick a port if there is a source port collision. This should be within the ephemeral range as defined by RFC 6056 (1024–65535) and preferably outside the  ephemeral ranges used by common operating systems. Linux uses 32768–60999, while others mostly use the IANA defined range 49152–65535. It is not necessarily a problem if this range overlaps with the operating systems. Both ends of the range are inclusive. [Default: 20000:29999]</summary>
    [JsonPropertyName("bpfPSNATPorts")]
    public IntstrIntOrString? BpfPSNATPorts { get; set; }

    /// <summary>BPFPolicyDebugEnabled when true, Felix records detailed information about the BPF policy programs, which can be examined with the calico-bpf command-line tool.</summary>
    [JsonPropertyName("bpfPolicyDebugEnabled")]
    public bool? BpfPolicyDebugEnabled { get; set; }

    /// <summary>BPFRedirectToPeer controls which whether it is allowed to forward straight to the peer side of the workload devices. It is allowed for any host L2 devices by default (L2Only), but it breaks TCP dump on the host side of workload device as it bypasses it on ingress. Value of Enabled also allows redirection from L3 host devices like IPIP tunnel or Wireguard directly to the peer side of the workload's device. This makes redirection faster, however, it breaks tools like tcpdump on the peer side. Use Enabled with caution. [Default: L2Only]</summary>
    [JsonPropertyName("bpfRedirectToPeer")]
    public string? BpfRedirectToPeer { get; set; }

    /// <summary>ChainInsertMode controls whether Felix hooks the kernel's top-level iptables chains by inserting a rule at the top of the chain or by appending a rule at the bottom. insert is the safe default since it prevents Calico's rules from being bypassed. If you switch to append mode, be sure that the other rules in the chains signal acceptance by falling through to the Calico rules, otherwise the Calico policy will be bypassed. [Default: insert]</summary>
    [JsonPropertyName("chainInsertMode")]
    public string? ChainInsertMode { get; set; }

    /// <summary>DataplaneDriver filename of the external dataplane driver to use.  Only used if UseInternalDataplaneDriver is set to false.</summary>
    [JsonPropertyName("dataplaneDriver")]
    public string? DataplaneDriver { get; set; }

    /// <summary>DataplaneWatchdogTimeout is the readiness/liveness timeout used for Felix's (internal) dataplane driver. Increase this value if you experience spurious non-ready or non-live events when Felix is under heavy load. Decrease the value to get felix to report non-live or non-ready more quickly. [Default: 90s]   Deprecated: replaced by the generic HealthTimeoutOverrides.</summary>
    [JsonPropertyName("dataplaneWatchdogTimeout")]
    public string? DataplaneWatchdogTimeout { get; set; }

    /// <summary></summary>
    [JsonPropertyName("debugDisableLogDropping")]
    public bool? DebugDisableLogDropping { get; set; }

    /// <summary>DebugHost is the host IP or hostname to bind the debug port to.  Only used if DebugPort is set. [Default:localhost]</summary>
    [JsonPropertyName("debugHost")]
    public string? DebugHost { get; set; }

    /// <summary></summary>
    [JsonPropertyName("debugMemoryProfilePath")]
    public string? DebugMemoryProfilePath { get; set; }

    /// <summary>DebugPort if set, enables Felix's debug HTTP port, which allows memory and CPU profiles to be retrieved.  The debug port is not secure, it should not be exposed to the internet.</summary>
    [JsonPropertyName("debugPort")]
    public int? DebugPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("debugSimulateCalcGraphHangAfter")]
    public string? DebugSimulateCalcGraphHangAfter { get; set; }

    /// <summary></summary>
    [JsonPropertyName("debugSimulateDataplaneApplyDelay")]
    public string? DebugSimulateDataplaneApplyDelay { get; set; }

    /// <summary></summary>
    [JsonPropertyName("debugSimulateDataplaneHangAfter")]
    public string? DebugSimulateDataplaneHangAfter { get; set; }

    /// <summary>DefaultEndpointToHostAction controls what happens to traffic that goes from a workload endpoint to the host itself (after the traffic hits the endpoint egress policy). By default Calico blocks traffic from workload endpoints to the host itself with an iptables "DROP" action. If you want to allow some or all traffic from endpoint to host, set this parameter to RETURN or ACCEPT. Use RETURN if you have your own rules in the iptables "INPUT" chain; Calico will insert its rules at the top of that chain, then "RETURN" packets to the "INPUT" chain once it has completed processing workload endpoint egress policy. Use ACCEPT to unconditionally accept packets from workloads after processing workload endpoint egress policy. [Default: Drop]</summary>
    [JsonPropertyName("defaultEndpointToHostAction")]
    public string? DefaultEndpointToHostAction { get; set; }

    /// <summary>This defines the route protocol added to programmed device routes, by default this will be RTPROT_BOOT when left blank.</summary>
    [JsonPropertyName("deviceRouteProtocol")]
    public int? DeviceRouteProtocol { get; set; }

    /// <summary>This is the IPv4 source address to use on programmed device routes. By default the source address is left blank, leaving the kernel to choose the source address used.</summary>
    [JsonPropertyName("deviceRouteSourceAddress")]
    public string? DeviceRouteSourceAddress { get; set; }

    /// <summary>This is the IPv6 source address to use on programmed device routes. By default the source address is left blank, leaving the kernel to choose the source address used.</summary>
    [JsonPropertyName("deviceRouteSourceAddressIPv6")]
    public string? DeviceRouteSourceAddressIPv6 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableConntrackInvalidCheck")]
    public bool? DisableConntrackInvalidCheck { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpointReportingDelay")]
    public string? EndpointReportingDelay { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpointReportingEnabled")]
    public bool? EndpointReportingEnabled { get; set; }

    /// <summary>EndpointStatusPathPrefix is the path to the directory where endpoint status will be written. Endpoint status file reporting is disabled if field is left empty.   Chosen directory should match the directory used by the CNI for PodStartupDelay. [Default: ""]</summary>
    [JsonPropertyName("endpointStatusPathPrefix")]
    public string? EndpointStatusPathPrefix { get; set; }

    /// <summary>ExternalNodesCIDRList is a list of CIDR's of external-non-calico-nodes which may source tunnel traffic and have the tunneled traffic be accepted at calico nodes.</summary>
    [JsonPropertyName("externalNodesList")]
    public IList<string>? ExternalNodesList { get; set; }

    /// <summary>FailsafeInboundHostPorts is a list of PortProto struct objects including UDP/TCP/SCTP ports and CIDRs that Felix will allow incoming traffic to host endpoints on irrespective of the security policy. This is useful to avoid accidentally cutting off a host with incorrect configuration. For backwards compatibility, if the protocol is not specified, it defaults to "tcp". If a CIDR is not specified, it will allow traffic from all addresses. To disable all inbound host ports, use the value "[]". The default value allows ssh access, DHCP, BGP, etcd and the Kubernetes API. [Default: tcp:22, udp:68, tcp:179, tcp:2379, tcp:2380, tcp:5473, tcp:6443, tcp:6666, tcp:6667 ]</summary>
    [JsonPropertyName("failsafeInboundHostPorts")]
    public IList<V1FelixConfigurationSpecFailsafeInboundHostPorts>? FailsafeInboundHostPorts { get; set; }

    /// <summary>FailsafeOutboundHostPorts is a list of List of PortProto struct objects including UDP/TCP/SCTP ports and CIDRs that Felix will allow outgoing traffic from host endpoints to irrespective of the security policy. This is useful to avoid accidentally cutting off a host with incorrect configuration. For backwards compatibility, if the protocol is not specified, it defaults to "tcp". If a CIDR is not specified, it will allow traffic from all addresses. To disable all outbound host ports, use the value "[]". The default value opens etcd's standard ports to ensure that Felix does not get cut off from etcd as well as allowing DHCP, DNS, BGP and the Kubernetes API. [Default: udp:53, udp:67, tcp:179, tcp:2379, tcp:2380, tcp:5473, tcp:6443, tcp:6666, tcp:6667 ]</summary>
    [JsonPropertyName("failsafeOutboundHostPorts")]
    public IList<V1FelixConfigurationSpecFailsafeOutboundHostPorts>? FailsafeOutboundHostPorts { get; set; }

    /// <summary>FeatureDetectOverride is used to override feature detection based on auto-detected platform capabilities.  Values are specified in a comma separated list with no spaces, example; "SNATFullyRandom=true,MASQFullyRandom=false,RestoreSupportsLock=".  "true" or "false" will force the feature, empty or omitted values are auto-detected.</summary>
    [JsonPropertyName("featureDetectOverride")]
    public string? FeatureDetectOverride { get; set; }

    /// <summary>FeatureGates is used to enable or disable tech-preview Calico features. Values are specified in a comma separated list with no spaces, example; "BPFConnectTimeLoadBalancingWorkaround=enabled,XyZ=false". This is used to enable features that are not fully production ready.</summary>
    [JsonPropertyName("featureGates")]
    public string? FeatureGates { get; set; }

    /// <summary>FloatingIPs configures whether or not Felix will program non-OpenStack floating IP addresses.  (OpenStack-derived floating IPs are always programmed, regardless of this setting.)</summary>
    [JsonPropertyName("floatingIPs")]
    public string? FloatingIPs { get; set; }

    /// <summary>GenericXDPEnabled enables Generic XDP so network cards that don't support XDP offload or driver modes can use XDP. This is not recommended since it doesn't provide better performance than iptables. [Default: false]</summary>
    [JsonPropertyName("genericXDPEnabled")]
    public bool? GenericXDPEnabled { get; set; }

    /// <summary>GoGCThreshold Sets the Go runtime's garbage collection threshold.  I.e. the percentage that the heap is allowed to grow before garbage collection is triggered.  In general, doubling the value halves the CPU time spent doing GC, but it also doubles peak GC memory overhead.  A special value of -1 can be used to disable GC entirely; this should only be used in conjunction with the GoMemoryLimitMB setting.   This setting is overridden by the GOGC environment variable.   [Default: 40]</summary>
    [JsonPropertyName("goGCThreshold")]
    public int? GoGCThreshold { get; set; }

    /// <summary>GoMaxProcs sets the maximum number of CPUs that the Go runtime will use concurrently.  A value of -1 means "use the system default"; typically the number of real CPUs on the system.   this setting is overridden by the GOMAXPROCS environment variable.   [Default: -1]</summary>
    [JsonPropertyName("goMaxProcs")]
    public int? GoMaxProcs { get; set; }

    /// <summary>GoMemoryLimitMB sets a (soft) memory limit for the Go runtime in MB.  The Go runtime will try to keep its memory usage under the limit by triggering GC as needed.  To avoid thrashing, it will exceed the limit if GC starts to take more than 50% of the process's CPU time.  A value of -1 disables the memory limit.   Note that the memory limit, if used, must be considerably less than any hard resource limit set at the container or pod level.  This is because felix is not the only process that must run in the container or pod.   This setting is overridden by the GOMEMLIMIT environment variable.   [Default: -1]</summary>
    [JsonPropertyName("goMemoryLimitMB")]
    public int? GoMemoryLimitMB { get; set; }

    /// <summary></summary>
    [JsonPropertyName("healthEnabled")]
    public bool? HealthEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("healthHost")]
    public string? HealthHost { get; set; }

    /// <summary></summary>
    [JsonPropertyName("healthPort")]
    public int? HealthPort { get; set; }

    /// <summary>HealthTimeoutOverrides allows the internal watchdog timeouts of individual subcomponents to be overridden.  This is useful for working around "false positive" liveness timeouts that can occur in particularly stressful workloads or if CPU is constrained.  For a list of active subcomponents, see Felix's logs.</summary>
    [JsonPropertyName("healthTimeoutOverrides")]
    public IList<V1FelixConfigurationSpecHealthTimeoutOverrides>? HealthTimeoutOverrides { get; set; }

    /// <summary>InterfaceExclude is a comma-separated list of interfaces that Felix should exclude when monitoring for host endpoints. The default value ensures that Felix ignores Kubernetes' IPVS dummy interface, which is used internally by kube-proxy. If you want to exclude multiple interface names using a single value, the list supports regular expressions. For regular expressions you must wrap the value with '/'. For example having values '/^kube/,veth1' will exclude all interfaces that begin with 'kube' and also the interface 'veth1'. [Default: kube-ipvs0]</summary>
    [JsonPropertyName("interfaceExclude")]
    public string? InterfaceExclude { get; set; }

    /// <summary>InterfacePrefix is the interface name prefix that identifies workload endpoints and so distinguishes them from host endpoint interfaces. Note: in environments other than bare metal, the orchestrators configure this appropriately. For example our Kubernetes and Docker integrations set the 'cali' value, and our OpenStack integration sets the 'tap' value. [Default: cali]</summary>
    [JsonPropertyName("interfacePrefix")]
    public string? InterfacePrefix { get; set; }

    /// <summary>InterfaceRefreshInterval is the period at which Felix rescans local interfaces to verify their state. The rescan can be disabled by setting the interval to 0.</summary>
    [JsonPropertyName("interfaceRefreshInterval")]
    public string? InterfaceRefreshInterval { get; set; }

    /// <summary>IPForwarding controls whether Felix sets the host sysctls to enable IP forwarding.  IP forwarding is required when using Calico for workload networking.  This should only be disabled on hosts where Calico is used for host protection. In BPF mode, due to a kernel interaction, either IPForwarding must be enabled or BPFEnforceRPF must be disabled. [Default: Enabled]</summary>
    [JsonPropertyName("ipForwarding")]
    public string? IpForwarding { get; set; }

    /// <summary>IPIPEnabled overrides whether Felix should configure an IPIP interface on the host. Optional as Felix determines this based on the existing IP pools. [Default: nil (unset)]</summary>
    [JsonPropertyName("ipipEnabled")]
    public bool? IpipEnabled { get; set; }

    /// <summary>IPIPMTU is the MTU to set on the tunnel device. See Configuring MTU [Default: 1440]</summary>
    [JsonPropertyName("ipipMTU")]
    public int? IpipMTU { get; set; }

    /// <summary>IpsetsRefreshInterval is the period at which Felix re-checks all iptables state to ensure that no other process has accidentally broken Calico's rules. Set to 0 to disable iptables refresh. [Default: 90s]</summary>
    [JsonPropertyName("ipsetsRefreshInterval")]
    public string? IpsetsRefreshInterval { get; set; }

    /// <summary>IptablesBackend specifies which backend of iptables will be used. The default is Auto.</summary>
    [JsonPropertyName("iptablesBackend")]
    public string? IptablesBackend { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iptablesFilterAllowAction")]
    public string? IptablesFilterAllowAction { get; set; }

    /// <summary>IptablesFilterDenyAction controls what happens to traffic that is denied by network policy. By default Calico blocks traffic with an iptables "DROP" action. If you want to use "REJECT" action instead you can configure it in here.</summary>
    [JsonPropertyName("iptablesFilterDenyAction")]
    public string? IptablesFilterDenyAction { get; set; }

    /// <summary>IptablesLockFilePath is the location of the iptables lock file. You may need to change this if the lock file is not in its standard location (for example if you have mapped it into Felix's container at a different path). [Default: /run/xtables.lock]</summary>
    [JsonPropertyName("iptablesLockFilePath")]
    public string? IptablesLockFilePath { get; set; }

    /// <summary>IptablesLockProbeInterval is the time that Felix will wait between attempts to acquire the iptables lock if it is not available. Lower values make Felix more responsive when the lock is contended, but use more CPU. [Default: 50ms]</summary>
    [JsonPropertyName("iptablesLockProbeInterval")]
    public string? IptablesLockProbeInterval { get; set; }

    /// <summary>IptablesLockTimeout is the time that Felix will wait for the iptables lock, or 0, to disable. To use this feature, Felix must share the iptables lock file with all other processes that also take the lock. When running Felix inside a container, this requires the /run directory of the host to be mounted into the calico/node or calico/felix container. [Default: 0s disabled]</summary>
    [JsonPropertyName("iptablesLockTimeout")]
    public string? IptablesLockTimeout { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iptablesMangleAllowAction")]
    public string? IptablesMangleAllowAction { get; set; }

    /// <summary>IptablesMarkMask is the mask that Felix selects its IPTables Mark bits from. Should be a 32 bit hexadecimal number with at least 8 bits set, none of which clash with any other mark bits in use on the system. [Default: 0xff000000]</summary>
    [JsonPropertyName("iptablesMarkMask")]
    public int? IptablesMarkMask { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iptablesNATOutgoingInterfaceFilter")]
    public string? IptablesNATOutgoingInterfaceFilter { get; set; }

    /// <summary>IptablesPostWriteCheckInterval is the period after Felix has done a write to the dataplane that it schedules an extra read back in order to check the write was not clobbered by another process. This should only occur if another application on the system doesn't respect the iptables lock. [Default: 1s]</summary>
    [JsonPropertyName("iptablesPostWriteCheckInterval")]
    public string? IptablesPostWriteCheckInterval { get; set; }

    /// <summary>IptablesRefreshInterval is the period at which Felix re-checks the IP sets in the dataplane to ensure that no other process has accidentally broken Calico's rules. Set to 0 to disable IP sets refresh. Note: the default for this value is lower than the other refresh intervals as a workaround for a Linux kernel bug that was fixed in kernel version 4.11. If you are using v4.11 or greater you may want to set this to, a higher value to reduce Felix CPU usage. [Default: 10s]</summary>
    [JsonPropertyName("iptablesRefreshInterval")]
    public string? IptablesRefreshInterval { get; set; }

    /// <summary>IPv6Support controls whether Felix enables support for IPv6 (if supported by the in-use dataplane).</summary>
    [JsonPropertyName("ipv6Support")]
    public bool? Ipv6Support { get; set; }

    /// <summary>KubeNodePortRanges holds list of port ranges used for service node ports. Only used if felix detects kube-proxy running in ipvs mode. Felix uses these ranges to separate host and workload traffic. [Default: 30000:32767].</summary>
    [JsonPropertyName("kubeNodePortRanges")]
    public IList<IntstrIntOrString>? KubeNodePortRanges { get; set; }

    /// <summary>LogDebugFilenameRegex controls which source code files have their Debug log output included in the logs. Only logs from files with names that match the given regular expression are included.  The filter only applies to Debug level logs.</summary>
    [JsonPropertyName("logDebugFilenameRegex")]
    public string? LogDebugFilenameRegex { get; set; }

    /// <summary>LogFilePath is the full path to the Felix log. Set to none to disable file logging. [Default: /var/log/calico/felix.log]</summary>
    [JsonPropertyName("logFilePath")]
    public string? LogFilePath { get; set; }

    /// <summary>LogPrefix is the log prefix that Felix uses when rendering LOG rules. [Default: calico-packet]</summary>
    [JsonPropertyName("logPrefix")]
    public string? LogPrefix { get; set; }

    /// <summary>LogSeverityFile is the log severity above which logs are sent to the log file. [Default: Info]</summary>
    [JsonPropertyName("logSeverityFile")]
    public string? LogSeverityFile { get; set; }

    /// <summary>LogSeverityScreen is the log severity above which logs are sent to the stdout. [Default: Info]</summary>
    [JsonPropertyName("logSeverityScreen")]
    public string? LogSeverityScreen { get; set; }

    /// <summary>LogSeveritySys is the log severity above which logs are sent to the syslog. Set to None for no logging to syslog. [Default: Info]</summary>
    [JsonPropertyName("logSeveritySys")]
    public string? LogSeveritySys { get; set; }

    /// <summary>MaxIpsetSize is the maximum number of IP addresses that can be stored in an IP set. Not applicable if using the nftables backend.</summary>
    [JsonPropertyName("maxIpsetSize")]
    public int? MaxIpsetSize { get; set; }

    /// <summary>MetadataAddr is the IP address or domain name of the server that can answer VM queries for cloud-init metadata. In OpenStack, this corresponds to the machine running nova-api (or in Ubuntu, nova-api-metadata). A value of none (case-insensitive) means that Felix should not set up any NAT rule for the metadata path. [Default: 127.0.0.1]</summary>
    [JsonPropertyName("metadataAddr")]
    public string? MetadataAddr { get; set; }

    /// <summary>MetadataPort is the port of the metadata server. This, combined with global.MetadataAddr (if not 'None'), is used to set up a NAT rule, from 169.254.169.254:80 to MetadataAddr:MetadataPort. In most cases this should not need to be changed [Default: 8775].</summary>
    [JsonPropertyName("metadataPort")]
    public int? MetadataPort { get; set; }

    /// <summary>MTUIfacePattern is a regular expression that controls which interfaces Felix should scan in order to calculate the host's MTU. This should not match workload interfaces (usually named cali...).</summary>
    [JsonPropertyName("mtuIfacePattern")]
    public string? MtuIfacePattern { get; set; }

    /// <summary>NATOutgoingAddress specifies an address to use when performing source NAT for traffic in a natOutgoing pool that is leaving the network. By default the address used is an address on the interface the traffic is leaving on (ie it uses the iptables MASQUERADE target)</summary>
    [JsonPropertyName("natOutgoingAddress")]
    public string? NatOutgoingAddress { get; set; }

    /// <summary>NATPortRange specifies the range of ports that is used for port mapping when doing outgoing NAT. When unset the default behavior of the network stack is used.</summary>
    [JsonPropertyName("natPortRange")]
    public IntstrIntOrString? NatPortRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netlinkTimeout")]
    public string? NetlinkTimeout { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nftablesFilterAllowAction")]
    public string? NftablesFilterAllowAction { get; set; }

    /// <summary>FilterDenyAction controls what happens to traffic that is denied by network policy. By default Calico blocks traffic with a "drop" action. If you want to use a "reject" action instead you can configure it here.</summary>
    [JsonPropertyName("nftablesFilterDenyAction")]
    public string? NftablesFilterDenyAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nftablesMangleAllowAction")]
    public string? NftablesMangleAllowAction { get; set; }

    /// <summary>MarkMask is the mask that Felix selects its nftables Mark bits from. Should be a 32 bit hexadecimal number with at least 8 bits set, none of which clash with any other mark bits in use on the system. [Default: 0xffff0000]</summary>
    [JsonPropertyName("nftablesMarkMask")]
    public int? NftablesMarkMask { get; set; }

    /// <summary>NFTablesMode configures nftables support in Felix. [Default: Disabled]</summary>
    [JsonPropertyName("nftablesMode")]
    public string? NftablesMode { get; set; }

    /// <summary>NftablesRefreshInterval controls the interval at which Felix periodically refreshes the nftables rules. [Default: 90s]</summary>
    [JsonPropertyName("nftablesRefreshInterval")]
    public string? NftablesRefreshInterval { get; set; }

    /// <summary>OpenstackRegion is the name of the region that a particular Felix belongs to. In a multi-region Calico/OpenStack deployment, this must be configured somehow for each Felix (here in the datamodel, or in felix.cfg or the environment on each compute node), and must match the [calico] openstack_region value configured in neutron.conf on each node. [Default: Empty]</summary>
    [JsonPropertyName("openstackRegion")]
    public string? OpenstackRegion { get; set; }

    /// <summary>PolicySyncPathPrefix is used to by Felix to communicate policy changes to external services, like Application layer policy. [Default: Empty]</summary>
    [JsonPropertyName("policySyncPathPrefix")]
    public string? PolicySyncPathPrefix { get; set; }

    /// <summary>PrometheusGoMetricsEnabled disables Go runtime metrics collection, which the Prometheus client does by default, when set to false. This reduces the number of metrics reported, reducing Prometheus load. [Default: true]</summary>
    [JsonPropertyName("prometheusGoMetricsEnabled")]
    public bool? PrometheusGoMetricsEnabled { get; set; }

    /// <summary>PrometheusMetricsEnabled enables the Prometheus metrics server in Felix if set to true. [Default: false]</summary>
    [JsonPropertyName("prometheusMetricsEnabled")]
    public bool? PrometheusMetricsEnabled { get; set; }

    /// <summary>PrometheusMetricsHost is the host that the Prometheus metrics server should bind to. [Default: empty]</summary>
    [JsonPropertyName("prometheusMetricsHost")]
    public string? PrometheusMetricsHost { get; set; }

    /// <summary>PrometheusMetricsPort is the TCP port that the Prometheus metrics server should bind to. [Default: 9091]</summary>
    [JsonPropertyName("prometheusMetricsPort")]
    public int? PrometheusMetricsPort { get; set; }

    /// <summary>PrometheusProcessMetricsEnabled disables process metrics collection, which the Prometheus client does by default, when set to false. This reduces the number of metrics reported, reducing Prometheus load. [Default: true]</summary>
    [JsonPropertyName("prometheusProcessMetricsEnabled")]
    public bool? PrometheusProcessMetricsEnabled { get; set; }

    /// <summary>PrometheusWireGuardMetricsEnabled disables wireguard metrics collection, which the Prometheus client does by default, when set to false. This reduces the number of metrics reported, reducing Prometheus load. [Default: true]</summary>
    [JsonPropertyName("prometheusWireGuardMetricsEnabled")]
    public bool? PrometheusWireGuardMetricsEnabled { get; set; }

    /// <summary>Whether or not to remove device routes that have not been programmed by Felix. Disabling this will allow external applications to also add device routes. This is enabled by default which means we will remove externally added routes.</summary>
    [JsonPropertyName("removeExternalRoutes")]
    public bool? RemoveExternalRoutes { get; set; }

    /// <summary>ReportingInterval is the interval at which Felix reports its status into the datastore or 0 to disable. Must be non-zero in OpenStack deployments. [Default: 30s]</summary>
    [JsonPropertyName("reportingInterval")]
    public string? ReportingInterval { get; set; }

    /// <summary>ReportingTTL is the time-to-live setting for process-wide status reports. [Default: 90s]</summary>
    [JsonPropertyName("reportingTTL")]
    public string? ReportingTTL { get; set; }

    /// <summary>RouteRefreshInterval is the period at which Felix re-checks the routes in the dataplane to ensure that no other process has accidentally broken Calico's rules. Set to 0 to disable route refresh. [Default: 90s]</summary>
    [JsonPropertyName("routeRefreshInterval")]
    public string? RouteRefreshInterval { get; set; }

    /// <summary>RouteSource configures where Felix gets its routing information. - WorkloadIPs: use workload endpoints to construct routes. - CalicoIPAM: the default - use IPAM data to construct routes.</summary>
    [JsonPropertyName("routeSource")]
    public string? RouteSource { get; set; }

    /// <summary>RouteSyncDisabled will disable all operations performed on the route table. Set to true to run in network-policy mode only.</summary>
    [JsonPropertyName("routeSyncDisabled")]
    public bool? RouteSyncDisabled { get; set; }

    /// <summary>Deprecated in favor of RouteTableRanges. Calico programs additional Linux route tables for various purposes. RouteTableRange specifies the indices of the route tables that Calico should use.</summary>
    [JsonPropertyName("routeTableRange")]
    public V1FelixConfigurationSpecRouteTableRange? RouteTableRange { get; set; }

    /// <summary>Calico programs additional Linux route tables for various purposes. RouteTableRanges specifies a set of table index ranges that Calico should use. Deprecates`RouteTableRange`, overrides `RouteTableRange`.</summary>
    [JsonPropertyName("routeTableRanges")]
    public IList<V1FelixConfigurationSpecRouteTableRanges>? RouteTableRanges { get; set; }

    /// <summary>When service IP advertisement is enabled, prevent routing loops to service IPs that are not in use, by dropping or rejecting packets that do not get DNAT'd by kube-proxy. Unless set to "Disabled", in which case such routing loops continue to be allowed. [Default: Drop]</summary>
    [JsonPropertyName("serviceLoopPrevention")]
    public string? ServiceLoopPrevention { get; set; }

    /// <summary>SidecarAccelerationEnabled enables experimental sidecar acceleration [Default: false]</summary>
    [JsonPropertyName("sidecarAccelerationEnabled")]
    public bool? SidecarAccelerationEnabled { get; set; }

    /// <summary>UsageReportingEnabled reports anonymous Calico version number and cluster size to projectcalico.org. Logs warnings returned by the usage server. For example, if a significant security vulnerability has been discovered in the version of Calico being used. [Default: true]</summary>
    [JsonPropertyName("usageReportingEnabled")]
    public bool? UsageReportingEnabled { get; set; }

    /// <summary>UsageReportingInitialDelay controls the minimum delay before Felix makes a report. [Default: 300s]</summary>
    [JsonPropertyName("usageReportingInitialDelay")]
    public string? UsageReportingInitialDelay { get; set; }

    /// <summary>UsageReportingInterval controls the interval at which Felix makes reports. [Default: 86400s]</summary>
    [JsonPropertyName("usageReportingInterval")]
    public string? UsageReportingInterval { get; set; }

    /// <summary>UseInternalDataplaneDriver, if true, Felix will use its internal dataplane programming logic.  If false, it will launch an external dataplane driver and communicate with it over protobuf.</summary>
    [JsonPropertyName("useInternalDataplaneDriver")]
    public bool? UseInternalDataplaneDriver { get; set; }

    /// <summary>VXLANEnabled overrides whether Felix should create the VXLAN tunnel device for IPv4 VXLAN networking. Optional as Felix determines this based on the existing IP pools. [Default: nil (unset)]</summary>
    [JsonPropertyName("vxlanEnabled")]
    public bool? VxlanEnabled { get; set; }

    /// <summary>VXLANMTU is the MTU to set on the IPv4 VXLAN tunnel device. See Configuring MTU [Default: 1410]</summary>
    [JsonPropertyName("vxlanMTU")]
    public int? VxlanMTU { get; set; }

    /// <summary>VXLANMTUV6 is the MTU to set on the IPv6 VXLAN tunnel device. See Configuring MTU [Default: 1390]</summary>
    [JsonPropertyName("vxlanMTUV6")]
    public int? VxlanMTUV6 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vxlanPort")]
    public int? VxlanPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vxlanVNI")]
    public int? VxlanVNI { get; set; }

    /// <summary>WindowsManageFirewallRules configures whether or not Felix will program Windows Firewall rules. (to allow inbound access to its own metrics ports) [Default: Disabled]</summary>
    [JsonPropertyName("windowsManageFirewallRules")]
    public string? WindowsManageFirewallRules { get; set; }

    /// <summary>WireguardEnabled controls whether Wireguard is enabled for IPv4 (encapsulating IPv4 traffic over an IPv4 underlay network). [Default: false]</summary>
    [JsonPropertyName("wireguardEnabled")]
    public bool? WireguardEnabled { get; set; }

    /// <summary>WireguardEnabledV6 controls whether Wireguard is enabled for IPv6 (encapsulating IPv6 traffic over an IPv6 underlay network). [Default: false]</summary>
    [JsonPropertyName("wireguardEnabledV6")]
    public bool? WireguardEnabledV6 { get; set; }

    /// <summary>WireguardHostEncryptionEnabled controls whether Wireguard host-to-host encryption is enabled. [Default: false]</summary>
    [JsonPropertyName("wireguardHostEncryptionEnabled")]
    public bool? WireguardHostEncryptionEnabled { get; set; }

    /// <summary>WireguardInterfaceName specifies the name to use for the IPv4 Wireguard interface. [Default: wireguard.cali]</summary>
    [JsonPropertyName("wireguardInterfaceName")]
    public string? WireguardInterfaceName { get; set; }

    /// <summary>WireguardInterfaceNameV6 specifies the name to use for the IPv6 Wireguard interface. [Default: wg-v6.cali]</summary>
    [JsonPropertyName("wireguardInterfaceNameV6")]
    public string? WireguardInterfaceNameV6 { get; set; }

    /// <summary>WireguardKeepAlive controls Wireguard PersistentKeepalive option. Set 0 to disable. [Default: 0]</summary>
    [JsonPropertyName("wireguardKeepAlive")]
    public string? WireguardKeepAlive { get; set; }

    /// <summary>WireguardListeningPort controls the listening port used by IPv4 Wireguard. [Default: 51820]</summary>
    [JsonPropertyName("wireguardListeningPort")]
    public int? WireguardListeningPort { get; set; }

    /// <summary>WireguardListeningPortV6 controls the listening port used by IPv6 Wireguard. [Default: 51821]</summary>
    [JsonPropertyName("wireguardListeningPortV6")]
    public int? WireguardListeningPortV6 { get; set; }

    /// <summary>WireguardMTU controls the MTU on the IPv4 Wireguard interface. See Configuring MTU [Default: 1440]</summary>
    [JsonPropertyName("wireguardMTU")]
    public int? WireguardMTU { get; set; }

    /// <summary>WireguardMTUV6 controls the MTU on the IPv6 Wireguard interface. See Configuring MTU [Default: 1420]</summary>
    [JsonPropertyName("wireguardMTUV6")]
    public int? WireguardMTUV6 { get; set; }

    /// <summary>WireguardRoutingRulePriority controls the priority value to use for the Wireguard routing rule. [Default: 99]</summary>
    [JsonPropertyName("wireguardRoutingRulePriority")]
    public int? WireguardRoutingRulePriority { get; set; }

    /// <summary>WorkloadSourceSpoofing controls whether pods can use the allowedSourcePrefixes annotation to send traffic with a source IP address that is not theirs. This is disabled by default. When set to "Any", pods can request any prefix.</summary>
    [JsonPropertyName("workloadSourceSpoofing")]
    public string? WorkloadSourceSpoofing { get; set; }

    /// <summary>XDPEnabled enables XDP acceleration for suitable untracked incoming deny rules. [Default: true]</summary>
    [JsonPropertyName("xdpEnabled")]
    public bool? XdpEnabled { get; set; }

    /// <summary>XDPRefreshInterval is the period at which Felix re-checks all XDP state to ensure that no other process has accidentally broken Calico's BPF maps or attached programs. Set to 0 to disable XDP refresh. [Default: 90s]</summary>
    [JsonPropertyName("xdpRefreshInterval")]
    public string? XdpRefreshInterval { get; set; }
}

/// <summary>Felix Configuration contains the configuration for Felix.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1FelixConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1FelixConfigurationSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "FelixConfiguration";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "felixconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FelixConfigurationSpec contains the values of the Felix configuration.</summary>
    [JsonPropertyName("spec")]
    public V1FelixConfigurationSpec? Spec { get; set; }
}