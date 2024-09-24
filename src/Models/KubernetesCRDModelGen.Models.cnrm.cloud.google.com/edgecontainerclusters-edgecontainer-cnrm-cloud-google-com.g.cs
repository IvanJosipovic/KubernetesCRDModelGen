using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.edgecontainer.cnrm.cloud.google.com;
public partial class V1beta1EdgeContainerClusterSpecAuthorizationAdminUsersUsernameRef
{
    /// <summary>Allowed value: The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1EdgeContainerClusterSpecAuthorizationAdminUsers
{
    /// <summary></summary>
    [JsonPropertyName("usernameRef")]
    public V1beta1EdgeContainerClusterSpecAuthorizationAdminUsersUsernameRef UsernameRef { get; set; }
}

public partial class V1beta1EdgeContainerClusterSpecAuthorization
{
    /// <summary>User that will be granted the cluster-admin role on the cluster, providing full access to the cluster. Currently, this is a singular field, but will be expanded to allow multiple admins in the future.</summary>
    [JsonPropertyName("adminUsers")]
    public V1beta1EdgeContainerClusterSpecAuthorizationAdminUsers AdminUsers { get; set; }
}

public partial class V1beta1EdgeContainerClusterSpecControlPlaneLocal
{
    /// <summary>Only machines matching this filter will be allowed to host control plane nodes. The filtering language accepts strings like "name=&lt;name&gt;", and is documented here: [AIP-160](https://google.aip.dev/160).</summary>
    [JsonPropertyName("machineFilter")]
    public string? MachineFilter { get; set; }

    /// <summary>The number of nodes to serve as replicas of the Control Plane. Only 1 and 3 are supported.</summary>
    [JsonPropertyName("nodeCount")]
    public int? NodeCount { get; set; }

    /// <summary>Immutable. Name of the Google Distributed Cloud Edge zones where this node pool will be created. For example: 'us-central1-edge-customer-a'.</summary>
    [JsonPropertyName("nodeLocation")]
    public string? NodeLocation { get; set; }

    /// <summary>Policy configuration about how user applications are deployed. Possible values: ["SHARED_DEPLOYMENT_POLICY_UNSPECIFIED", "ALLOWED", "DISALLOWED"].</summary>
    [JsonPropertyName("sharedDeploymentPolicy")]
    public string? SharedDeploymentPolicy { get; set; }
}

public partial class V1beta1EdgeContainerClusterSpecControlPlaneRemote
{
    /// <summary>Immutable. Name of the Google Distributed Cloud Edge zones where this node pool will be created. For example: 'us-central1-edge-customer-a'.</summary>
    [JsonPropertyName("nodeLocation")]
    public string? NodeLocation { get; set; }
}

public partial class V1beta1EdgeContainerClusterSpecControlPlane
{
    /// <summary>Immutable. Local control plane configuration.</summary>
    [JsonPropertyName("local")]
    public V1beta1EdgeContainerClusterSpecControlPlaneLocal? Local { get; set; }

    /// <summary>Immutable. Remote control plane configuration.</summary>
    [JsonPropertyName("remote")]
    public V1beta1EdgeContainerClusterSpecControlPlaneRemote? Remote { get; set; }
}

public partial class V1beta1EdgeContainerClusterSpecControlPlaneEncryptionKmsKeyRef
{
    /// <summary>Allowed value: The `selfLink` field of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1EdgeContainerClusterSpecControlPlaneEncryptionKmsStatus
{
    /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should be localized and sent in the google.rpc.Status.details field, or localized by the client.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

public partial class V1beta1EdgeContainerClusterSpecControlPlaneEncryption
{
    /// <summary>The Cloud KMS CryptoKeyVersion currently in use for protecting control plane disks. Only applicable if kms_key is set.</summary>
    [JsonPropertyName("kmsKeyActiveVersion")]
    public string? KmsKeyActiveVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1EdgeContainerClusterSpecControlPlaneEncryptionKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Availability of the Cloud KMS CryptoKey. If not 'KEY_AVAILABLE', then nodes may go offline as they cannot access their local data. This can be caused by a lack of permissions to use the key, or if the key is disabled or deleted.</summary>
    [JsonPropertyName("kmsKeyState")]
    public string? KmsKeyState { get; set; }

    /// <summary>Error status returned by Cloud KMS when using this key. This field may be populated only if 'kms_key_state' is not 'KMS_KEY_STATE_KEY_AVAILABLE'. If populated, this field contains the error status reported by Cloud KMS.</summary>
    [JsonPropertyName("kmsStatus")]
    public IList<V1beta1EdgeContainerClusterSpecControlPlaneEncryptionKmsStatus>? KmsStatus { get; set; }
}

public partial class V1beta1EdgeContainerClusterSpecFleetProjectRef
{
    /// <summary>Allowed value: string of the format `projects/{{value}}`, where {{value}} is the `number` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1EdgeContainerClusterSpecFleet
{
    /// <summary>The name of the managed Hub Membership resource associated to this cluster. Membership names are formatted as 'projects/&lt;project-number&gt;/locations/global/membership/&lt;cluster-id&gt;'.</summary>
    [JsonPropertyName("membership")]
    public string? Membership { get; set; }

    /// <summary>The number of the Fleet host project where this cluster will be registered.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1EdgeContainerClusterSpecFleetProjectRef ProjectRef { get; set; }
}

public partial class V1beta1EdgeContainerClusterSpecMaintenancePolicyWindowRecurringWindowWindow
{
    /// <summary>The time that the window ends. The end time must take place after the start time.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>The time that the window first starts.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

public partial class V1beta1EdgeContainerClusterSpecMaintenancePolicyWindowRecurringWindow
{
    /// <summary>An RRULE (https://tools.ietf.org/html/rfc5545#section-3.8.5.3) for how this window recurs. They go on for the span of time between the start and end time.</summary>
    [JsonPropertyName("recurrence")]
    public string? Recurrence { get; set; }

    /// <summary>Represents an arbitrary window of time.</summary>
    [JsonPropertyName("window")]
    public V1beta1EdgeContainerClusterSpecMaintenancePolicyWindowRecurringWindowWindow? Window { get; set; }
}

public partial class V1beta1EdgeContainerClusterSpecMaintenancePolicyWindow
{
    /// <summary>Represents an arbitrary window of time that recurs.</summary>
    [JsonPropertyName("recurringWindow")]
    public V1beta1EdgeContainerClusterSpecMaintenancePolicyWindowRecurringWindow RecurringWindow { get; set; }
}

public partial class V1beta1EdgeContainerClusterSpecMaintenancePolicy
{
    /// <summary>Specifies the maintenance window in which maintenance may be performed.</summary>
    [JsonPropertyName("window")]
    public V1beta1EdgeContainerClusterSpecMaintenancePolicyWindow Window { get; set; }
}

public partial class V1beta1EdgeContainerClusterSpecNetworking
{
    /// <summary>Immutable. All pods in the cluster are assigned an RFC1918 IPv4 address from these blocks. Only a single block is supported. This field cannot be changed after creation.</summary>
    [JsonPropertyName("clusterIpv4CidrBlocks")]
    public IList<string> ClusterIpv4CidrBlocks { get; set; }

    /// <summary>Immutable. If specified, dual stack mode is enabled and all pods in the cluster are assigned an IPv6 address from these blocks alongside from an IPv4 address. Only a single block is supported. This field cannot be changed after creation.</summary>
    [JsonPropertyName("clusterIpv6CidrBlocks")]
    public IList<string>? ClusterIpv6CidrBlocks { get; set; }

    /// <summary>IP addressing type of this cluster i.e. SINGLESTACK_V4 vs DUALSTACK_V4_V6.</summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>Immutable. All services in the cluster are assigned an RFC1918 IPv4 address from these blocks. Only a single block is supported. This field cannot be changed after creation.</summary>
    [JsonPropertyName("servicesIpv4CidrBlocks")]
    public IList<string> ServicesIpv4CidrBlocks { get; set; }

    /// <summary>Immutable. If specified, dual stack mode is enabled and all services in the cluster are assigned an IPv6 address from these blocks alongside from an IPv4 address. Only a single block is supported. This field cannot be changed after creation.</summary>
    [JsonPropertyName("servicesIpv6CidrBlocks")]
    public IList<string>? ServicesIpv6CidrBlocks { get; set; }
}

public partial class V1beta1EdgeContainerClusterSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1EdgeContainerClusterSpecSystemAddonsConfigIngress
{
    /// <summary>Whether Ingress is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Ingress VIP.</summary>
    [JsonPropertyName("ipv4Vip")]
    public string? Ipv4Vip { get; set; }
}

public partial class V1beta1EdgeContainerClusterSpecSystemAddonsConfig
{
    /// <summary>Config for the Ingress add-on which allows customers to create an Ingress object to manage external access to the servers in a cluster. The add-on consists of istiod and istio-ingress.</summary>
    [JsonPropertyName("ingress")]
    public V1beta1EdgeContainerClusterSpecSystemAddonsConfigIngress? Ingress { get; set; }
}

public partial class V1beta1EdgeContainerClusterSpec
{
    /// <summary>Immutable. RBAC policy that will be applied and managed by GEC.</summary>
    [JsonPropertyName("authorization")]
    public V1beta1EdgeContainerClusterSpecAuthorization Authorization { get; set; }

    /// <summary>The configuration of the cluster control plane.</summary>
    [JsonPropertyName("controlPlane")]
    public V1beta1EdgeContainerClusterSpecControlPlane? ControlPlane { get; set; }

    /// <summary>Remote control plane disk encryption options. This field is only used when enabling CMEK support.</summary>
    [JsonPropertyName("controlPlaneEncryption")]
    public V1beta1EdgeContainerClusterSpecControlPlaneEncryption? ControlPlaneEncryption { get; set; }

    /// <summary>The default maximum number of pods per node used if a maximum value is not specified explicitly for a node pool in this cluster. If unspecified, the Kubernetes default value will be used.</summary>
    [JsonPropertyName("defaultMaxPodsPerNode")]
    public int? DefaultMaxPodsPerNode { get; set; }

    /// <summary>Address pools for cluster data plane external load balancing.</summary>
    [JsonPropertyName("externalLoadBalancerIpv4AddressPools")]
    public IList<string>? ExternalLoadBalancerIpv4AddressPools { get; set; }

    /// <summary>Immutable. Fleet related configuration. Fleets are a Google Cloud concept for logically organizing clusters, letting you use and manage multi-cluster capabilities and apply consistent policies across your systems.</summary>
    [JsonPropertyName("fleet")]
    public V1beta1EdgeContainerClusterSpecFleet Fleet { get; set; }

    /// <summary>Immutable. The location of the resource.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Cluster-wide maintenance policy configuration.</summary>
    [JsonPropertyName("maintenancePolicy")]
    public V1beta1EdgeContainerClusterSpecMaintenancePolicy? MaintenancePolicy { get; set; }

    /// <summary>Fleet related configuration. Fleets are a Google Cloud concept for logically organizing clusters, letting you use and manage multi-cluster capabilities and apply consistent policies across your systems.</summary>
    [JsonPropertyName("networking")]
    public V1beta1EdgeContainerClusterSpecNetworking Networking { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1EdgeContainerClusterSpecProjectRef ProjectRef { get; set; }

    /// <summary>The release channel a cluster is subscribed to. Possible values: ["RELEASE_CHANNEL_UNSPECIFIED", "NONE", "REGULAR"].</summary>
    [JsonPropertyName("releaseChannel")]
    public string? ReleaseChannel { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Config that customers are allowed to define for GDCE system add-ons.</summary>
    [JsonPropertyName("systemAddonsConfig")]
    public V1beta1EdgeContainerClusterSpecSystemAddonsConfig? SystemAddonsConfig { get; set; }

    /// <summary>The target cluster version. For example: "1.5.0".</summary>
    [JsonPropertyName("targetVersion")]
    public string? TargetVersion { get; set; }
}

public partial class V1beta1EdgeContainerClusterStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1EdgeContainerClusterStatusMaintenanceEvents
{
    /// <summary>The time when the maintenance event request was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The time when the maintenance event ended, either successfully or not. If the maintenance event is split into multiple maintenance windows, end_time is only updated when the whole flow ends.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>The operation for running the maintenance event. Specified in the format projects/*/locations/*/operations/*. If the maintenance event is split into multiple operations (e.g. due to maintenance windows), the latest one is recorded.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The schedule of the maintenance event.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The time when the maintenance event started.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Indicates the maintenance event state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The target version of the cluster.</summary>
    [JsonPropertyName("targetVersion")]
    public string? TargetVersion { get; set; }

    /// <summary>Indicates the maintenance event type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The time when the maintenance event message was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>UUID of the maintenance event.</summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

public partial class V1beta1EdgeContainerClusterStatus
{
    /// <summary>The PEM-encoded public certificate of the cluster's CA.</summary>
    [JsonPropertyName("clusterCaCertificate")]
    public string? ClusterCaCertificate { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EdgeContainerClusterStatusConditions>? Conditions { get; set; }

    /// <summary>The control plane release version.</summary>
    [JsonPropertyName("controlPlaneVersion")]
    public string? ControlPlaneVersion { get; set; }

    /// <summary>The time the cluster was created, in RFC3339 text format.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The IP address of the Kubernetes API server.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>All the maintenance events scheduled for the cluster, including the ones ongoing, planned for the future and done in the past (up to 90 days).</summary>
    [JsonPropertyName("maintenanceEvents")]
    public IList<V1beta1EdgeContainerClusterStatusMaintenanceEvents>? MaintenanceEvents { get; set; }

    /// <summary>The lowest release version among all worker nodes. This field can be empty if the cluster does not have any worker nodes.</summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The port number of the Kubernetes API server.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Indicates the status of the cluster.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The time the cluster was last updated, in RFC3339 text format.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EdgeContainerCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EdgeContainerClusterSpec>, IStatus<V1beta1EdgeContainerClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EdgeContainerCluster";
    public const string KubeGroup = "edgecontainer.cnrm.cloud.google.com";
    public const string KubePluralName = "edgecontainerclusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1EdgeContainerClusterSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1EdgeContainerClusterStatus? Status { get; set; }
}