using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.alloydb.gcp.upbound.io;
#nullable enable
/// <summary>Instance is the Schema for the Instances API. A managed alloydb cluster instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Instance>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InstanceList";
    public const string KubeGroup = "alloydb.gcp.upbound.io";
    public const string KubePluralName = "instances";
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
    public IList<V1beta1Instance> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderClientConnectionConfigSslConfig
{
    /// <summary>SSL mode. Specifies client-server SSL/TLS connection behavior. Possible values are: ENCRYPTED_ONLY, ALLOW_UNENCRYPTED_AND_ENCRYPTED.</summary>
    [JsonPropertyName("sslMode")]
    public string? SslMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderClientConnectionConfig
{
    /// <summary>Configuration to enforce connectors only (ex: AuthProxy) connections to the database.</summary>
    [JsonPropertyName("requireConnectors")]
    public bool? RequireConnectors { get; set; }

    /// <summary>SSL config option for this instance. Structure is documented below.</summary>
    [JsonPropertyName("sslConfig")]
    public IList<V1beta1InstanceSpecForProviderClientConnectionConfigSslConfig>? SslConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderClusterRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Cluster in alloydb to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderClusterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderClusterRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderClusterSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Cluster in alloydb to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderClusterSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderClusterSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderInstanceTypeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Cluster in alloydb to populate instanceType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderInstanceTypeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderInstanceTypeRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderInstanceTypeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Cluster in alloydb to populate instanceType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderInstanceTypeSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderInstanceTypeSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderMachineConfig
{
    /// <summary>The number of CPU's in the VM instance.</summary>
    [JsonPropertyName("cpuCount")]
    public double? CpuCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderNetworkConfigAuthorizedExternalNetworks
{
    /// <summary>CIDR range for one authorized network of the instance.</summary>
    [JsonPropertyName("cidrRange")]
    public string? CidrRange { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderNetworkConfig
{
    /// <summary>Name of the allocated IP range for the private IP AlloyDB instance, for example: "google-managed-services-default". If set, the instance IPs will be created from this allocated range and will override the IP range used by the parent cluster. The range name must comply with RFC 1035. Specifically, the name must be 1-63 characters long and match the regular expression a-z?.</summary>
    [JsonPropertyName("allocatedIpRangeOverride")]
    public string? AllocatedIpRangeOverride { get; set; }

    /// <summary>A list of external networks authorized to access this instance. This field is only allowed to be set when enable_public_ip is set to true. Structure is documented below.</summary>
    [JsonPropertyName("authorizedExternalNetworks")]
    public IList<V1beta1InstanceSpecForProviderNetworkConfigAuthorizedExternalNetworks>? AuthorizedExternalNetworks { get; set; }

    /// <summary>Enabling outbound public ip for the instance.</summary>
    [JsonPropertyName("enableOutboundPublicIp")]
    public bool? EnableOutboundPublicIp { get; set; }

    /// <summary>Enabling public ip for the instance. If a user wishes to disable this, please also clear the list of the authorized external networks set on the same instance.</summary>
    [JsonPropertyName("enablePublicIp")]
    public bool? EnablePublicIp { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderPscInstanceConfigPscAutoConnections
{
    /// <summary>The consumer network for the PSC service automation, example: "projects/vpc-host-project/global/networks/default". The consumer network might be hosted a different project than the consumer project. The API expects the consumer project specified to be the project ID (and not the project number)</summary>
    [JsonPropertyName("consumerNetwork")]
    public string? ConsumerNetwork { get; set; }

    /// <summary>The consumer project to which the PSC service automation endpoint will be created. The API expects the consumer project to be the project ID( and not the project number).</summary>
    [JsonPropertyName("consumerProject")]
    public string? ConsumerProject { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderPscInstanceConfigPscInterfaceConfigs
{
    /// <summary>The network attachment resource created in the consumer project to which the PSC interface will be linked. This is of the format: "projects/${CONSUMER_PROJECT}/regions/${REGION}/networkAttachments/${NETWORK_ATTACHMENT_NAME}". The network attachment must be in the same region as the instance.</summary>
    [JsonPropertyName("networkAttachmentResource")]
    public string? NetworkAttachmentResource { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderPscInstanceConfig
{
    /// <summary>List of consumer projects that are allowed to create PSC endpoints to service-attachments to this instance. These should be specified as project numbers only.</summary>
    [JsonPropertyName("allowedConsumerProjects")]
    public IList<string>? AllowedConsumerProjects { get; set; }

    /// <summary>Configurations for setting up PSC service automation. Structure is documented below.</summary>
    [JsonPropertyName("pscAutoConnections")]
    public IList<V1beta1InstanceSpecForProviderPscInstanceConfigPscAutoConnections>? PscAutoConnections { get; set; }

    /// <summary>Configurations for setting up PSC interfaces attached to the instance which are used for outbound connectivity. Currently, AlloyDB supports only 0 or 1 PSC interface. Structure is documented below.</summary>
    [JsonPropertyName("pscInterfaceConfigs")]
    public IList<V1beta1InstanceSpecForProviderPscInstanceConfigPscInterfaceConfigs>? PscInterfaceConfigs { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderQueryInsightsConfig
{
    /// <summary>Number of query execution plans captured by Insights per minute for all queries combined. The default value is 5. Any integer between 0 and 20 is considered valid.</summary>
    [JsonPropertyName("queryPlansPerMinute")]
    public double? QueryPlansPerMinute { get; set; }

    /// <summary>Query string length. The default value is 1024. Any integer between 256 and 4500 is considered valid.</summary>
    [JsonPropertyName("queryStringLength")]
    public double? QueryStringLength { get; set; }

    /// <summary>Record application tags for an instance. This flag is turned "on" by default.</summary>
    [JsonPropertyName("recordApplicationTags")]
    public bool? RecordApplicationTags { get; set; }

    /// <summary>Record client address for an instance. Client address is PII information. This flag is turned "on" by default.</summary>
    [JsonPropertyName("recordClientAddress")]
    public bool? RecordClientAddress { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderReadPoolConfig
{
    /// <summary>Read capacity, i.e. number of nodes in a read pool instance.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProvider
{
    /// <summary>'Specifies whether an instance needs to spin up. Once the instance is active, the activation policy can be updated to the NEVER to stop the instance. Likewise, the activation policy can be updated to ALWAYS to start the instance. There are restrictions around when an instance can/cannot be activated (for example, a read pool instance should be stopped before stopping primary etc.). Please refer to the API documentation for more details. Possible values are: ACTIVATION_POLICY_UNSPECIFIED, ALWAYS, NEVER.' Possible values are: ACTIVATION_POLICY_UNSPECIFIED, ALWAYS, NEVER.</summary>
    [JsonPropertyName("activationPolicy")]
    public string? ActivationPolicy { get; set; }

    /// <summary>Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels. Note: This field is non-authoritative, and will only manage the annotations present in your configuration. Please refer to the field effective_annotations for all of the annotations present on the resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>'Availability type of an Instance. Defaults to REGIONAL for both primary and read instances. Note that primary and read instances can have different availability types. Only READ_POOL instance supports ZONAL type. Users can't specify the zone for READ_POOL instance. Zone is automatically chosen from the list of zones in the region specified. Read pool of size 1 can only have zonal availability. Read pools with node count of 2 or more can have regional availability (nodes are present in 2 or more zones in a region).' Possible values are: AVAILABILITY_TYPE_UNSPECIFIED, ZONAL, REGIONAL.</summary>
    [JsonPropertyName("availabilityType")]
    public string? AvailabilityType { get; set; }

    /// <summary>Client connection specific configurations. Structure is documented below.</summary>
    [JsonPropertyName("clientConnectionConfig")]
    public IList<V1beta1InstanceSpecForProviderClientConnectionConfig>? ClientConnectionConfig { get; set; }

    /// <summary>Identifies the alloydb cluster. Must be in the format 'projects/{project}/locations/{location}/clusters/{cluster_id}'</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Reference to a Cluster in alloydb to populate cluster.</summary>
    [JsonPropertyName("clusterRef")]
    public V1beta1InstanceSpecForProviderClusterRef? ClusterRef { get; set; }

    /// <summary>Selector for a Cluster in alloydb to populate cluster.</summary>
    [JsonPropertyName("clusterSelector")]
    public V1beta1InstanceSpecForProviderClusterSelector? ClusterSelector { get; set; }

    /// <summary>Database flags. Set at instance level. * They are copied from primary instance on read instance creation. * Read instances can set new or override existing flags that are relevant for reads, e.g. for enabling columnar cache on a read instance. Flags set on read instance may or may not be present on primary.</summary>
    [JsonPropertyName("databaseFlags")]
    public IDictionary<string, string>? DatabaseFlags { get; set; }

    /// <summary>User-settable and human-readable display name for the Instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The Compute Engine zone that the instance should serve from, per https://cloud.google.com/compute/docs/regions-zones This can ONLY be specified for ZONAL instances. If present for a REGIONAL instance, an error will be thrown. If this is absent for a ZONAL instance, instance is created in a random zone with available capacity.</summary>
    [JsonPropertyName("gceZone")]
    public string? GceZone { get; set; }

    /// <summary>The type of the instance. If the instance type is READ_POOL, provide the associated PRIMARY/SECONDARY instance in the depends_on meta-data attribute. If the instance type is SECONDARY, point to the cluster_type of the associated secondary cluster instead of mentioning SECONDARY. Example: {instance_type = google_alloydb_cluster.&lt;secondary_cluster_name&gt;. Use deletion_policy = "FORCE" in the associated secondary cluster and delete the cluster forcefully to delete the secondary cluster as well its associated secondary instance. Possible values are: PRIMARY, READ_POOL, SECONDARY.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Reference to a Cluster in alloydb to populate instanceType.</summary>
    [JsonPropertyName("instanceTypeRef")]
    public V1beta1InstanceSpecForProviderInstanceTypeRef? InstanceTypeRef { get; set; }

    /// <summary>Selector for a Cluster in alloydb to populate instanceType.</summary>
    [JsonPropertyName("instanceTypeSelector")]
    public V1beta1InstanceSpecForProviderInstanceTypeSelector? InstanceTypeSelector { get; set; }

    /// <summary>User-defined labels for the alloydb instance. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Configurations for the machines that host the underlying database engine. Structure is documented below.</summary>
    [JsonPropertyName("machineConfig")]
    public IList<V1beta1InstanceSpecForProviderMachineConfig>? MachineConfig { get; set; }

    /// <summary>Instance level network configuration. Structure is documented below.</summary>
    [JsonPropertyName("networkConfig")]
    public IList<V1beta1InstanceSpecForProviderNetworkConfig>? NetworkConfig { get; set; }

    /// <summary>Configuration for Private Service Connect (PSC) for the instance. Structure is documented below.</summary>
    [JsonPropertyName("pscInstanceConfig")]
    public IList<V1beta1InstanceSpecForProviderPscInstanceConfig>? PscInstanceConfig { get; set; }

    /// <summary>Configuration for query insights. Structure is documented below.</summary>
    [JsonPropertyName("queryInsightsConfig")]
    public IList<V1beta1InstanceSpecForProviderQueryInsightsConfig>? QueryInsightsConfig { get; set; }

    /// <summary>Read pool specific config. If the instance type is READ_POOL, this configuration must be provided. Structure is documented below.</summary>
    [JsonPropertyName("readPoolConfig")]
    public IList<V1beta1InstanceSpecForProviderReadPoolConfig>? ReadPoolConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderClientConnectionConfigSslConfig
{
    /// <summary>SSL mode. Specifies client-server SSL/TLS connection behavior. Possible values are: ENCRYPTED_ONLY, ALLOW_UNENCRYPTED_AND_ENCRYPTED.</summary>
    [JsonPropertyName("sslMode")]
    public string? SslMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderClientConnectionConfig
{
    /// <summary>Configuration to enforce connectors only (ex: AuthProxy) connections to the database.</summary>
    [JsonPropertyName("requireConnectors")]
    public bool? RequireConnectors { get; set; }

    /// <summary>SSL config option for this instance. Structure is documented below.</summary>
    [JsonPropertyName("sslConfig")]
    public IList<V1beta1InstanceSpecInitProviderClientConnectionConfigSslConfig>? SslConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderInstanceTypeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Cluster in alloydb to populate instanceType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderInstanceTypeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderInstanceTypeRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderInstanceTypeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Cluster in alloydb to populate instanceType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderInstanceTypeSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderInstanceTypeSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderMachineConfig
{
    /// <summary>The number of CPU's in the VM instance.</summary>
    [JsonPropertyName("cpuCount")]
    public double? CpuCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderNetworkConfigAuthorizedExternalNetworks
{
    /// <summary>CIDR range for one authorized network of the instance.</summary>
    [JsonPropertyName("cidrRange")]
    public string? CidrRange { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderNetworkConfig
{
    /// <summary>Name of the allocated IP range for the private IP AlloyDB instance, for example: "google-managed-services-default". If set, the instance IPs will be created from this allocated range and will override the IP range used by the parent cluster. The range name must comply with RFC 1035. Specifically, the name must be 1-63 characters long and match the regular expression a-z?.</summary>
    [JsonPropertyName("allocatedIpRangeOverride")]
    public string? AllocatedIpRangeOverride { get; set; }

    /// <summary>A list of external networks authorized to access this instance. This field is only allowed to be set when enable_public_ip is set to true. Structure is documented below.</summary>
    [JsonPropertyName("authorizedExternalNetworks")]
    public IList<V1beta1InstanceSpecInitProviderNetworkConfigAuthorizedExternalNetworks>? AuthorizedExternalNetworks { get; set; }

    /// <summary>Enabling outbound public ip for the instance.</summary>
    [JsonPropertyName("enableOutboundPublicIp")]
    public bool? EnableOutboundPublicIp { get; set; }

    /// <summary>Enabling public ip for the instance. If a user wishes to disable this, please also clear the list of the authorized external networks set on the same instance.</summary>
    [JsonPropertyName("enablePublicIp")]
    public bool? EnablePublicIp { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderPscInstanceConfigPscAutoConnections
{
    /// <summary>The consumer network for the PSC service automation, example: "projects/vpc-host-project/global/networks/default". The consumer network might be hosted a different project than the consumer project. The API expects the consumer project specified to be the project ID (and not the project number)</summary>
    [JsonPropertyName("consumerNetwork")]
    public string? ConsumerNetwork { get; set; }

    /// <summary>The consumer project to which the PSC service automation endpoint will be created. The API expects the consumer project to be the project ID( and not the project number).</summary>
    [JsonPropertyName("consumerProject")]
    public string? ConsumerProject { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderPscInstanceConfigPscInterfaceConfigs
{
    /// <summary>The network attachment resource created in the consumer project to which the PSC interface will be linked. This is of the format: "projects/${CONSUMER_PROJECT}/regions/${REGION}/networkAttachments/${NETWORK_ATTACHMENT_NAME}". The network attachment must be in the same region as the instance.</summary>
    [JsonPropertyName("networkAttachmentResource")]
    public string? NetworkAttachmentResource { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderPscInstanceConfig
{
    /// <summary>List of consumer projects that are allowed to create PSC endpoints to service-attachments to this instance. These should be specified as project numbers only.</summary>
    [JsonPropertyName("allowedConsumerProjects")]
    public IList<string>? AllowedConsumerProjects { get; set; }

    /// <summary>Configurations for setting up PSC service automation. Structure is documented below.</summary>
    [JsonPropertyName("pscAutoConnections")]
    public IList<V1beta1InstanceSpecInitProviderPscInstanceConfigPscAutoConnections>? PscAutoConnections { get; set; }

    /// <summary>Configurations for setting up PSC interfaces attached to the instance which are used for outbound connectivity. Currently, AlloyDB supports only 0 or 1 PSC interface. Structure is documented below.</summary>
    [JsonPropertyName("pscInterfaceConfigs")]
    public IList<V1beta1InstanceSpecInitProviderPscInstanceConfigPscInterfaceConfigs>? PscInterfaceConfigs { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderQueryInsightsConfig
{
    /// <summary>Number of query execution plans captured by Insights per minute for all queries combined. The default value is 5. Any integer between 0 and 20 is considered valid.</summary>
    [JsonPropertyName("queryPlansPerMinute")]
    public double? QueryPlansPerMinute { get; set; }

    /// <summary>Query string length. The default value is 1024. Any integer between 256 and 4500 is considered valid.</summary>
    [JsonPropertyName("queryStringLength")]
    public double? QueryStringLength { get; set; }

    /// <summary>Record application tags for an instance. This flag is turned "on" by default.</summary>
    [JsonPropertyName("recordApplicationTags")]
    public bool? RecordApplicationTags { get; set; }

    /// <summary>Record client address for an instance. Client address is PII information. This flag is turned "on" by default.</summary>
    [JsonPropertyName("recordClientAddress")]
    public bool? RecordClientAddress { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderReadPoolConfig
{
    /// <summary>Read capacity, i.e. number of nodes in a read pool instance.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProvider
{
    /// <summary>'Specifies whether an instance needs to spin up. Once the instance is active, the activation policy can be updated to the NEVER to stop the instance. Likewise, the activation policy can be updated to ALWAYS to start the instance. There are restrictions around when an instance can/cannot be activated (for example, a read pool instance should be stopped before stopping primary etc.). Please refer to the API documentation for more details. Possible values are: ACTIVATION_POLICY_UNSPECIFIED, ALWAYS, NEVER.' Possible values are: ACTIVATION_POLICY_UNSPECIFIED, ALWAYS, NEVER.</summary>
    [JsonPropertyName("activationPolicy")]
    public string? ActivationPolicy { get; set; }

    /// <summary>Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels. Note: This field is non-authoritative, and will only manage the annotations present in your configuration. Please refer to the field effective_annotations for all of the annotations present on the resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>'Availability type of an Instance. Defaults to REGIONAL for both primary and read instances. Note that primary and read instances can have different availability types. Only READ_POOL instance supports ZONAL type. Users can't specify the zone for READ_POOL instance. Zone is automatically chosen from the list of zones in the region specified. Read pool of size 1 can only have zonal availability. Read pools with node count of 2 or more can have regional availability (nodes are present in 2 or more zones in a region).' Possible values are: AVAILABILITY_TYPE_UNSPECIFIED, ZONAL, REGIONAL.</summary>
    [JsonPropertyName("availabilityType")]
    public string? AvailabilityType { get; set; }

    /// <summary>Client connection specific configurations. Structure is documented below.</summary>
    [JsonPropertyName("clientConnectionConfig")]
    public IList<V1beta1InstanceSpecInitProviderClientConnectionConfig>? ClientConnectionConfig { get; set; }

    /// <summary>Database flags. Set at instance level. * They are copied from primary instance on read instance creation. * Read instances can set new or override existing flags that are relevant for reads, e.g. for enabling columnar cache on a read instance. Flags set on read instance may or may not be present on primary.</summary>
    [JsonPropertyName("databaseFlags")]
    public IDictionary<string, string>? DatabaseFlags { get; set; }

    /// <summary>User-settable and human-readable display name for the Instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The Compute Engine zone that the instance should serve from, per https://cloud.google.com/compute/docs/regions-zones This can ONLY be specified for ZONAL instances. If present for a REGIONAL instance, an error will be thrown. If this is absent for a ZONAL instance, instance is created in a random zone with available capacity.</summary>
    [JsonPropertyName("gceZone")]
    public string? GceZone { get; set; }

    /// <summary>The type of the instance. If the instance type is READ_POOL, provide the associated PRIMARY/SECONDARY instance in the depends_on meta-data attribute. If the instance type is SECONDARY, point to the cluster_type of the associated secondary cluster instead of mentioning SECONDARY. Example: {instance_type = google_alloydb_cluster.&lt;secondary_cluster_name&gt;. Use deletion_policy = "FORCE" in the associated secondary cluster and delete the cluster forcefully to delete the secondary cluster as well its associated secondary instance. Possible values are: PRIMARY, READ_POOL, SECONDARY.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Reference to a Cluster in alloydb to populate instanceType.</summary>
    [JsonPropertyName("instanceTypeRef")]
    public V1beta1InstanceSpecInitProviderInstanceTypeRef? InstanceTypeRef { get; set; }

    /// <summary>Selector for a Cluster in alloydb to populate instanceType.</summary>
    [JsonPropertyName("instanceTypeSelector")]
    public V1beta1InstanceSpecInitProviderInstanceTypeSelector? InstanceTypeSelector { get; set; }

    /// <summary>User-defined labels for the alloydb instance. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Configurations for the machines that host the underlying database engine. Structure is documented below.</summary>
    [JsonPropertyName("machineConfig")]
    public IList<V1beta1InstanceSpecInitProviderMachineConfig>? MachineConfig { get; set; }

    /// <summary>Instance level network configuration. Structure is documented below.</summary>
    [JsonPropertyName("networkConfig")]
    public IList<V1beta1InstanceSpecInitProviderNetworkConfig>? NetworkConfig { get; set; }

    /// <summary>Configuration for Private Service Connect (PSC) for the instance. Structure is documented below.</summary>
    [JsonPropertyName("pscInstanceConfig")]
    public IList<V1beta1InstanceSpecInitProviderPscInstanceConfig>? PscInstanceConfig { get; set; }

    /// <summary>Configuration for query insights. Structure is documented below.</summary>
    [JsonPropertyName("queryInsightsConfig")]
    public IList<V1beta1InstanceSpecInitProviderQueryInsightsConfig>? QueryInsightsConfig { get; set; }

    /// <summary>Read pool specific config. If the instance type is READ_POOL, this configuration must be provided. Structure is documented below.</summary>
    [JsonPropertyName("readPoolConfig")]
    public IList<V1beta1InstanceSpecInitProviderReadPoolConfig>? ReadPoolConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>InstanceSpec defines the desired state of Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1InstanceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1InstanceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1InstanceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1InstanceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderClientConnectionConfigSslConfig
{
    /// <summary>SSL mode. Specifies client-server SSL/TLS connection behavior. Possible values are: ENCRYPTED_ONLY, ALLOW_UNENCRYPTED_AND_ENCRYPTED.</summary>
    [JsonPropertyName("sslMode")]
    public string? SslMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderClientConnectionConfig
{
    /// <summary>Configuration to enforce connectors only (ex: AuthProxy) connections to the database.</summary>
    [JsonPropertyName("requireConnectors")]
    public bool? RequireConnectors { get; set; }

    /// <summary>SSL config option for this instance. Structure is documented below.</summary>
    [JsonPropertyName("sslConfig")]
    public IList<V1beta1InstanceStatusAtProviderClientConnectionConfigSslConfig>? SslConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderMachineConfig
{
    /// <summary>The number of CPU's in the VM instance.</summary>
    [JsonPropertyName("cpuCount")]
    public double? CpuCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderNetworkConfigAuthorizedExternalNetworks
{
    /// <summary>CIDR range for one authorized network of the instance.</summary>
    [JsonPropertyName("cidrRange")]
    public string? CidrRange { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderNetworkConfig
{
    /// <summary>Name of the allocated IP range for the private IP AlloyDB instance, for example: "google-managed-services-default". If set, the instance IPs will be created from this allocated range and will override the IP range used by the parent cluster. The range name must comply with RFC 1035. Specifically, the name must be 1-63 characters long and match the regular expression a-z?.</summary>
    [JsonPropertyName("allocatedIpRangeOverride")]
    public string? AllocatedIpRangeOverride { get; set; }

    /// <summary>A list of external networks authorized to access this instance. This field is only allowed to be set when enable_public_ip is set to true. Structure is documented below.</summary>
    [JsonPropertyName("authorizedExternalNetworks")]
    public IList<V1beta1InstanceStatusAtProviderNetworkConfigAuthorizedExternalNetworks>? AuthorizedExternalNetworks { get; set; }

    /// <summary>Enabling outbound public ip for the instance.</summary>
    [JsonPropertyName("enableOutboundPublicIp")]
    public bool? EnableOutboundPublicIp { get; set; }

    /// <summary>Enabling public ip for the instance. If a user wishes to disable this, please also clear the list of the authorized external networks set on the same instance.</summary>
    [JsonPropertyName("enablePublicIp")]
    public bool? EnablePublicIp { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderPscInstanceConfigPscAutoConnections
{
    /// <summary>The consumer network for the PSC service automation, example: "projects/vpc-host-project/global/networks/default". The consumer network might be hosted a different project than the consumer project. The API expects the consumer project specified to be the project ID (and not the project number)</summary>
    [JsonPropertyName("consumerNetwork")]
    public string? ConsumerNetwork { get; set; }

    /// <summary>(Output) The status of the service connection policy.</summary>
    [JsonPropertyName("consumerNetworkStatus")]
    public string? ConsumerNetworkStatus { get; set; }

    /// <summary>The consumer project to which the PSC service automation endpoint will be created. The API expects the consumer project to be the project ID( and not the project number).</summary>
    [JsonPropertyName("consumerProject")]
    public string? ConsumerProject { get; set; }

    /// <summary>(Output) The IP address of the PSC service automation endpoint.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>(Output) The status of the PSC service automation connection.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderPscInstanceConfigPscInterfaceConfigs
{
    /// <summary>The network attachment resource created in the consumer project to which the PSC interface will be linked. This is of the format: "projects/${CONSUMER_PROJECT}/regions/${REGION}/networkAttachments/${NETWORK_ATTACHMENT_NAME}". The network attachment must be in the same region as the instance.</summary>
    [JsonPropertyName("networkAttachmentResource")]
    public string? NetworkAttachmentResource { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderPscInstanceConfig
{
    /// <summary>List of consumer projects that are allowed to create PSC endpoints to service-attachments to this instance. These should be specified as project numbers only.</summary>
    [JsonPropertyName("allowedConsumerProjects")]
    public IList<string>? AllowedConsumerProjects { get; set; }

    /// <summary>Configurations for setting up PSC service automation. Structure is documented below.</summary>
    [JsonPropertyName("pscAutoConnections")]
    public IList<V1beta1InstanceStatusAtProviderPscInstanceConfigPscAutoConnections>? PscAutoConnections { get; set; }

    /// <summary>(Output) The DNS name of the instance for PSC connectivity. Name convention: ...alloydb-psc.goog</summary>
    [JsonPropertyName("pscDnsName")]
    public string? PscDnsName { get; set; }

    /// <summary>Configurations for setting up PSC interfaces attached to the instance which are used for outbound connectivity. Currently, AlloyDB supports only 0 or 1 PSC interface. Structure is documented below.</summary>
    [JsonPropertyName("pscInterfaceConfigs")]
    public IList<V1beta1InstanceStatusAtProviderPscInstanceConfigPscInterfaceConfigs>? PscInterfaceConfigs { get; set; }

    /// <summary>(Output) The service attachment created when Private Service Connect (PSC) is enabled for the instance. The name of the resource will be in the format of projects/&lt;alloydb-tenant-project-number&gt;/regions/&lt;region-name&gt;/serviceAttachments/&lt;service-attachment-name&gt;</summary>
    [JsonPropertyName("serviceAttachmentLink")]
    public string? ServiceAttachmentLink { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderQueryInsightsConfig
{
    /// <summary>Number of query execution plans captured by Insights per minute for all queries combined. The default value is 5. Any integer between 0 and 20 is considered valid.</summary>
    [JsonPropertyName("queryPlansPerMinute")]
    public double? QueryPlansPerMinute { get; set; }

    /// <summary>Query string length. The default value is 1024. Any integer between 256 and 4500 is considered valid.</summary>
    [JsonPropertyName("queryStringLength")]
    public double? QueryStringLength { get; set; }

    /// <summary>Record application tags for an instance. This flag is turned "on" by default.</summary>
    [JsonPropertyName("recordApplicationTags")]
    public bool? RecordApplicationTags { get; set; }

    /// <summary>Record client address for an instance. Client address is PII information. This flag is turned "on" by default.</summary>
    [JsonPropertyName("recordClientAddress")]
    public bool? RecordClientAddress { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderReadPoolConfig
{
    /// <summary>Read capacity, i.e. number of nodes in a read pool instance.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProvider
{
    /// <summary>'Specifies whether an instance needs to spin up. Once the instance is active, the activation policy can be updated to the NEVER to stop the instance. Likewise, the activation policy can be updated to ALWAYS to start the instance. There are restrictions around when an instance can/cannot be activated (for example, a read pool instance should be stopped before stopping primary etc.). Please refer to the API documentation for more details. Possible values are: ACTIVATION_POLICY_UNSPECIFIED, ALWAYS, NEVER.' Possible values are: ACTIVATION_POLICY_UNSPECIFIED, ALWAYS, NEVER.</summary>
    [JsonPropertyName("activationPolicy")]
    public string? ActivationPolicy { get; set; }

    /// <summary>Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels. Note: This field is non-authoritative, and will only manage the annotations present in your configuration. Please refer to the field effective_annotations for all of the annotations present on the resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>'Availability type of an Instance. Defaults to REGIONAL for both primary and read instances. Note that primary and read instances can have different availability types. Only READ_POOL instance supports ZONAL type. Users can't specify the zone for READ_POOL instance. Zone is automatically chosen from the list of zones in the region specified. Read pool of size 1 can only have zonal availability. Read pools with node count of 2 or more can have regional availability (nodes are present in 2 or more zones in a region).' Possible values are: AVAILABILITY_TYPE_UNSPECIFIED, ZONAL, REGIONAL.</summary>
    [JsonPropertyName("availabilityType")]
    public string? AvailabilityType { get; set; }

    /// <summary>Client connection specific configurations. Structure is documented below.</summary>
    [JsonPropertyName("clientConnectionConfig")]
    public IList<V1beta1InstanceStatusAtProviderClientConnectionConfig>? ClientConnectionConfig { get; set; }

    /// <summary>Identifies the alloydb cluster. Must be in the format 'projects/{project}/locations/{location}/clusters/{cluster_id}'</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Time the Instance was created in UTC.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Database flags. Set at instance level. * They are copied from primary instance on read instance creation. * Read instances can set new or override existing flags that are relevant for reads, e.g. for enabling columnar cache on a read instance. Flags set on read instance may or may not be present on primary.</summary>
    [JsonPropertyName("databaseFlags")]
    public IDictionary<string, string>? DatabaseFlags { get; set; }

    /// <summary>User-settable and human-readable display name for the Instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveAnnotations")]
    public IDictionary<string, string>? EffectiveAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>The Compute Engine zone that the instance should serve from, per https://cloud.google.com/compute/docs/regions-zones This can ONLY be specified for ZONAL instances. If present for a REGIONAL instance, an error will be thrown. If this is absent for a ZONAL instance, instance is created in a random zone with available capacity.</summary>
    [JsonPropertyName("gceZone")]
    public string? GceZone { get; set; }

    /// <summary>an identifier for the resource with format {{cluster}}/instances/{{instance_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The type of the instance. If the instance type is READ_POOL, provide the associated PRIMARY/SECONDARY instance in the depends_on meta-data attribute. If the instance type is SECONDARY, point to the cluster_type of the associated secondary cluster instead of mentioning SECONDARY. Example: {instance_type = google_alloydb_cluster.&lt;secondary_cluster_name&gt;. Use deletion_policy = "FORCE" in the associated secondary cluster and delete the cluster forcefully to delete the secondary cluster as well its associated secondary instance. Possible values are: PRIMARY, READ_POOL, SECONDARY.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The IP address for the Instance. This is the connection endpoint for an end-user application.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>User-defined labels for the alloydb instance. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Configurations for the machines that host the underlying database engine. Structure is documented below.</summary>
    [JsonPropertyName("machineConfig")]
    public IList<V1beta1InstanceStatusAtProviderMachineConfig>? MachineConfig { get; set; }

    /// <summary>The name of the instance resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Instance level network configuration. Structure is documented below.</summary>
    [JsonPropertyName("networkConfig")]
    public IList<V1beta1InstanceStatusAtProviderNetworkConfig>? NetworkConfig { get; set; }

    /// <summary>The outbound public IP addresses for the instance. This is available ONLY when networkConfig.enableOutboundPublicIp is set to true. These IP addresses are used for outbound connections.</summary>
    [JsonPropertyName("outboundPublicIpAddresses")]
    public IList<string>? OutboundPublicIpAddresses { get; set; }

    /// <summary>Configuration for Private Service Connect (PSC) for the instance. Structure is documented below.</summary>
    [JsonPropertyName("pscInstanceConfig")]
    public IList<V1beta1InstanceStatusAtProviderPscInstanceConfig>? PscInstanceConfig { get; set; }

    /// <summary>The public IP addresses for the Instance. This is available ONLY when networkConfig.enablePublicIp is set to true. This is the connection endpoint for an end-user application.</summary>
    [JsonPropertyName("publicIpAddress")]
    public string? PublicIpAddress { get; set; }

    /// <summary>Configuration for query insights. Structure is documented below.</summary>
    [JsonPropertyName("queryInsightsConfig")]
    public IList<V1beta1InstanceStatusAtProviderQueryInsightsConfig>? QueryInsightsConfig { get; set; }

    /// <summary>Read pool specific config. If the instance type is READ_POOL, this configuration must be provided. Structure is documented below.</summary>
    [JsonPropertyName("readPoolConfig")]
    public IList<V1beta1InstanceStatusAtProviderReadPoolConfig>? ReadPoolConfig { get; set; }

    /// <summary>Set to true if the current state of Instance does not match the user's intended state, and the service is actively updating the resource to reconcile them. This can happen due to user-triggered updates or system actions like failover or maintenance.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>The current state of the alloydb instance.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>The system-generated UID of the resource.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Time the Instance was updated in UTC.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusConditions
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
#nullable disable

#nullable enable
/// <summary>InstanceStatus defines the observed state of Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1InstanceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1InstanceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Instance is the Schema for the Instances API. A managed alloydb cluster instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Instance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1InstanceSpec>, IStatus<V1beta1InstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Instance";
    public const string KubeGroup = "alloydb.gcp.upbound.io";
    public const string KubePluralName = "instances";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceSpec defines the desired state of Instance</summary>
    [JsonPropertyName("spec")]
    public V1beta1InstanceSpec Spec { get; set; }

    /// <summary>InstanceStatus defines the observed state of Instance.</summary>
    [JsonPropertyName("status")]
    public V1beta1InstanceStatus? Status { get; set; }
}
#nullable disable
