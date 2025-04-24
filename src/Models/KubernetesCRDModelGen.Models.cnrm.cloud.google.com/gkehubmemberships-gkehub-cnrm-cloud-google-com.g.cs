using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.gkehub.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class GKEHubMembershipMetadata
{
}

/// <summary>Optional. How to identify workloads from this Membership. See the documentation on Workload Identity for more details: https://cloud.google.com/kubernetes-engine/docs/how-to/workload-identity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class GKEHubMembershipSpecAuthority
{
    /// <summary>Optional. A JSON Web Token (JWT) issuer URI. `issuer` must start with `https://` and be a valid URL with length &lt;2000 characters. If set, then Google will allow valid OIDC tokens from this issuer to authenticate within the workload_identity_pool. OIDC discovery will be performed on this URI to validate tokens from the issuer. Clearing `issuer` disables Workload Identity. `issuer` cannot be directly modified; it must be cleared (and Workload Identity disabled) before using a new issuer (and re-enabling Workload Identity).</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class GKEHubMembershipSpecEndpointGkeClusterResourceRef
{
    /// <summary>Immutable. Self-link of the GCP resource for the GKE cluster. For example: //container.googleapis.com/projects/my-project/locations/us-west1-a/clusters/my-cluster Zonal clusters are also supported.  Allowed value: The `selfLink` field of a `ContainerCluster` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. GKE-specific information. Only present if this Membership is a GKE cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class GKEHubMembershipSpecEndpointGkeCluster
{
    /// <summary></summary>
    [JsonPropertyName("resourceRef")]
    public GKEHubMembershipSpecEndpointGkeClusterResourceRef? ResourceRef { get; set; }
}

/// <summary>Optional. Options for Kubernetes resource generation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class GKEHubMembershipSpecEndpointKubernetesResourceResourceOptions
{
    /// <summary>Optional. The Connect agent version to use for connect_resources. Defaults to the latest GKE Connect version. The version must be a currently supported version, obsolete versions will be rejected.</summary>
    [JsonPropertyName("connectVersion")]
    public string? ConnectVersion { get; set; }

    /// <summary>Optional. Use `apiextensions/v1beta1` instead of `apiextensions/v1` for CustomResourceDefinition resources. This option should be set for clusters with Kubernetes apiserver versions &lt;1.16.</summary>
    [JsonPropertyName("v1beta1Crd")]
    public bool? V1beta1Crd { get; set; }
}

/// <summary>Optional. The in-cluster Kubernetes Resources that should be applied for a correctly registered cluster, in the steady state. These resources: * Ensure that the cluster is exclusively registered to one and only one Hub Membership. * Propagate Workload Pool Information available in the Membership Authority field. * Ensure proper initial configuration of default Hub Features.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class GKEHubMembershipSpecEndpointKubernetesResource
{
    /// <summary>Input only. The YAML representation of the Membership CR. This field is ignored for GKE clusters where Hub can read the CR directly. Callers should provide the CR that is currently present in the cluster during CreateMembership or UpdateMembership, or leave this field empty if none exists. The CR manifest is used to validate the cluster has not been registered with another Membership.</summary>
    [JsonPropertyName("membershipCrManifest")]
    public string? MembershipCrManifest { get; set; }

    /// <summary>Optional. Options for Kubernetes resource generation.</summary>
    [JsonPropertyName("resourceOptions")]
    public GKEHubMembershipSpecEndpointKubernetesResourceResourceOptions? ResourceOptions { get; set; }
}

/// <summary>Optional. Endpoint information to reach this member.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class GKEHubMembershipSpecEndpoint
{
    /// <summary>Optional. GKE-specific information. Only present if this Membership is a GKE cluster.</summary>
    [JsonPropertyName("gkeCluster")]
    public GKEHubMembershipSpecEndpointGkeCluster? GkeCluster { get; set; }

    /// <summary>Optional. The in-cluster Kubernetes Resources that should be applied for a correctly registered cluster, in the steady state. These resources: * Ensure that the cluster is exclusively registered to one and only one Hub Membership. * Propagate Workload Pool Information available in the Membership Authority field. * Ensure proper initial configuration of default Hub Features.</summary>
    [JsonPropertyName("kubernetesResource")]
    public GKEHubMembershipSpecEndpointKubernetesResource? KubernetesResource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class GKEHubMembershipSpec
{
    /// <summary>Optional. How to identify workloads from this Membership. See the documentation on Workload Identity for more details: https://cloud.google.com/kubernetes-engine/docs/how-to/workload-identity</summary>
    [JsonPropertyName("authority")]
    public GKEHubMembershipSpecAuthority? Authority { get; set; }

    /// <summary>Description of this membership, limited to 63 characters. Must match the regex: `*` This field is present for legacy purposes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. Endpoint information to reach this member.</summary>
    [JsonPropertyName("endpoint")]
    public GKEHubMembershipSpecEndpoint? Endpoint { get; set; }

    /// <summary>Optional. An externally-generated and managed ID for this Membership. This ID may be modified after creation, but this is not recommended. The ID must match the regex: `*` If this Membership represents a Kubernetes cluster, this value should be set to the UID of the `kube-system` namespace object.</summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>Optional. The infrastructure type this Membership is running on. Possible values: INFRASTRUCTURE_TYPE_UNSPECIFIED, ON_PREM, MULTI_CLOUD</summary>
    [JsonPropertyName("infrastructureType")]
    public string? InfrastructureType { get; set; }

    /// <summary>Immutable. The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class GKEHubMembershipStatusAuthority
{
    /// <summary>Output only. An identity provider that reflects the `issuer` in the workload identity pool.</summary>
    [JsonPropertyName("identityProvider")]
    public string? IdentityProvider { get; set; }

    /// <summary>Output only. The name of the workload identity pool in which `issuer` will be recognized. There is a single Workload Identity Pool per Hub that is shared between all Memberships that belong to that Hub. For a Hub hosted in: {PROJECT_ID}, the workload pool format is `{PROJECT_ID}.hub.id.goog`, although this is subject to change in newer versions of this API.</summary>
    [JsonPropertyName("workloadIdentityPool")]
    public string? WorkloadIdentityPool { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class GKEHubMembershipStatusConditions
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

/// <summary>Output only. Useful Kubernetes-specific metadata.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class GKEHubMembershipStatusEndpointKubernetesMetadata
{
    /// <summary>Output only. Kubernetes API server version string as reported by `/version`.</summary>
    [JsonPropertyName("kubernetesApiServerVersion")]
    public string? KubernetesApiServerVersion { get; set; }

    /// <summary>Output only. The total memory capacity as reported by the sum of all Kubernetes nodes resources, defined in MB.</summary>
    [JsonPropertyName("memoryMb")]
    public long? MemoryMb { get; set; }

    /// <summary>Output only. Node count as reported by Kubernetes nodes resources.</summary>
    [JsonPropertyName("nodeCount")]
    public long? NodeCount { get; set; }

    /// <summary>Output only. Node providerID as reported by the first node in the list of nodes on the Kubernetes endpoint. On Kubernetes platforms that support zero-node clusters (like GKE-on-GCP), the node_count will be zero and the node_provider_id will be empty.</summary>
    [JsonPropertyName("nodeProviderId")]
    public string? NodeProviderId { get; set; }

    /// <summary>Output only. The time at which these details were last updated. This update_time is different from the Membership-level update_time since EndpointDetails are updated internally for API consumers.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Output only. vCPU count as reported by Kubernetes nodes resources.</summary>
    [JsonPropertyName("vcpuCount")]
    public long? VcpuCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class GKEHubMembershipStatusEndpointKubernetesResourceConnectResources
{
    /// <summary>Whether the resource provided in the manifest is `cluster_scoped`. If unset, the manifest is assumed to be namespace scoped. This field is used for REST mapping when applying the resource in a cluster.</summary>
    [JsonPropertyName("clusterScoped")]
    public bool? ClusterScoped { get; set; }

    /// <summary>YAML manifest of the resource.</summary>
    [JsonPropertyName("manifest")]
    public string? Manifest { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class GKEHubMembershipStatusEndpointKubernetesResourceMembershipResources
{
    /// <summary>Whether the resource provided in the manifest is `cluster_scoped`. If unset, the manifest is assumed to be namespace scoped. This field is used for REST mapping when applying the resource in a cluster.</summary>
    [JsonPropertyName("clusterScoped")]
    public bool? ClusterScoped { get; set; }

    /// <summary>YAML manifest of the resource.</summary>
    [JsonPropertyName("manifest")]
    public string? Manifest { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class GKEHubMembershipStatusEndpointKubernetesResource
{
    /// <summary>Output only. The Kubernetes resources for installing the GKE Connect agent This field is only populated in the Membership returned from a successful long-running operation from CreateMembership or UpdateMembership. It is not populated during normal GetMembership or ListMemberships requests. To get the resource manifest after the initial registration, the caller should make a UpdateMembership call with an empty field mask.</summary>
    [JsonPropertyName("connectResources")]
    public IList<GKEHubMembershipStatusEndpointKubernetesResourceConnectResources>? ConnectResources { get; set; }

    /// <summary>Output only. Additional Kubernetes resources that need to be applied to the cluster after Membership creation, and after every update. This field is only populated in the Membership returned from a successful long-running operation from CreateMembership or UpdateMembership. It is not populated during normal GetMembership or ListMemberships requests. To get the resource manifest after the initial registration, the caller should make a UpdateMembership call with an empty field mask.</summary>
    [JsonPropertyName("membershipResources")]
    public IList<GKEHubMembershipStatusEndpointKubernetesResourceMembershipResources>? MembershipResources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class GKEHubMembershipStatusEndpoint
{
    /// <summary>Output only. Useful Kubernetes-specific metadata.</summary>
    [JsonPropertyName("kubernetesMetadata")]
    public GKEHubMembershipStatusEndpointKubernetesMetadata? KubernetesMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kubernetesResource")]
    public GKEHubMembershipStatusEndpointKubernetesResource? KubernetesResource { get; set; }
}

/// <summary>Output only. State of the Membership resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class GKEHubMembershipStatusState
{
    /// <summary>Output only. The current state of the Membership resource. Possible values: CODE_UNSPECIFIED, CREATING, READY, DELETING, UPDATING, SERVICE_UPDATING</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class GKEHubMembershipStatus
{
    /// <summary></summary>
    [JsonPropertyName("authority")]
    public GKEHubMembershipStatusAuthority? Authority { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<GKEHubMembershipStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. When the Membership was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. When the Membership was deleted.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public GKEHubMembershipStatusEndpoint? Endpoint { get; set; }

    /// <summary>Output only. For clusters using Connect, the timestamp of the most recent connection established with Google Cloud. This time is updated every several minutes, not continuously. For clusters that do not use GKE Connect, or that have never connected successfully, this field will be unset.</summary>
    [JsonPropertyName("lastConnectionTime")]
    public string? LastConnectionTime { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. State of the Membership resource.</summary>
    [JsonPropertyName("state")]
    public GKEHubMembershipStatusState? State { get; set; }

    /// <summary>Output only. Google-generated UUID for this resource. This is unique across all Membership resources. If a Membership resource is deleted and another resource with the same name is created, it gets a different unique_id.</summary>
    [JsonPropertyName("uniqueId")]
    public string? UniqueId { get; set; }

    /// <summary>Output only. When the Membership was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class GKEHubMembership
{
    /// <summary>apiVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public GKEHubMembershipMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public GKEHubMembershipSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public GKEHubMembershipStatus? Status { get; set; }
}