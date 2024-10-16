using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerattached.cnrm.cloud.google.com;
/// <summary>Optional. Configuration related to the cluster RBAC settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAttachedClusterSpecAuthorization
{
    /// <summary>Optional. Users that can perform operations as a cluster admin. A managed  ClusterRoleBinding will be created to grant the `cluster-admin` ClusterRole  to the users. Up to ten admin users can be provided.   For more info on RBAC, see  https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles</summary>
    [JsonPropertyName("adminUsers")]
    public IList<string>? AdminUsers { get; set; }
}

/// <summary>Optional. Binary Authorization configuration for this cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAttachedClusterSpecBinaryAuthorization
{
    /// <summary>Mode of operation for binauthz policy evaluation. If unspecified, defaults to DISABLED. Possible values: ["DISABLED", "PROJECT_SINGLETON_POLICY_ENFORCE"].</summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }
}

/// <summary>The id of the Fleet host project where this cluster will be registered.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAttachedClusterSpecFleetProjectRef
{
    /// <summary>The project of the fleet. Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the project resource. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the project resource. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. Fleet configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAttachedClusterSpecFleet
{
    /// <summary>Output only. The name of the managed Hub Membership resource associated to  this cluster.   Membership names are formatted as  `projects/&lt;project-number&gt;/locations/global/membership/&lt;cluster-id&gt;`.</summary>
    [JsonPropertyName("membership")]
    public string? Membership { get; set; }

    /// <summary>The id of the Fleet host project where this cluster will be registered.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1ContainerAttachedClusterSpecFleetProjectRef ProjectRef { get; set; }
}

/// <summary>The configuration of the logging components;</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAttachedClusterSpecLoggingConfigComponentConfig
{
    /// <summary>The components to be enabled. Possible values: ["SYSTEM_COMPONENTS", "WORKLOADS"].</summary>
    [JsonPropertyName("enableComponents")]
    public IList<string>? EnableComponents { get; set; }
}

/// <summary>Optional. Logging configuration for this cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAttachedClusterSpecLoggingConfig
{
    /// <summary>The configuration of the logging components;</summary>
    [JsonPropertyName("componentConfig")]
    public V1beta1ContainerAttachedClusterSpecLoggingConfigComponentConfig? ComponentConfig { get; set; }
}

/// <summary>Enable Google Cloud Managed Service for Prometheus in the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAttachedClusterSpecMonitoringConfigManagedPrometheusConfig
{
    /// <summary>Enable Managed Collection.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Optional. Monitoring configuration for this cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAttachedClusterSpecMonitoringConfig
{
    /// <summary>Enable Google Cloud Managed Service for Prometheus in the cluster.</summary>
    [JsonPropertyName("managedPrometheusConfig")]
    public V1beta1ContainerAttachedClusterSpecMonitoringConfigManagedPrometheusConfig? ManagedPrometheusConfig { get; set; }
}

/// <summary>Required. OpenID Connect (OIDC) discovery information of the target cluster.  Kubernetes Service Account (KSA) tokens are JWT tokens signed by the cluster API server. This field indicates how GCP services	validate KSA tokens in order to allow system workloads (such as GKE Connect and telemetry agents) to authenticate back to GCP.  Both clusters with public and private issuer URLs are supported. Clusters with public issuers only need to specify the 'issuerUrl' field while clusters with private issuers need to provide both 'issuerUrl' and 'jwks'.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAttachedClusterSpecOidcConfig
{
    /// <summary>Immutable. A JSON Web Token (JWT) issuer URI. `issuer` must start with `https://`.</summary>
    [JsonPropertyName("issuerUrl")]
    public string IssuerUrl { get; set; }

    /// <summary>Immutable, Optional. OIDC verification keys in JWKS format (RFC 7517).  It contains a list of OIDC verification keys that can be used to verify  OIDC JWTs.   This field is required for cluster that doesn't have a publicly available  discovery endpoint. When provided, it will be directly used  to verify the OIDC JWT asserted by the IDP.</summary>
    [JsonPropertyName("jwks")]
    public string? Jwks { get; set; }
}

/// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAttachedClusterSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ContainerAttachedClusterSpec defines the desired state of ContainerAttachedCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAttachedClusterSpec
{
    /// <summary>Optional. Annotations on the cluster.   This field has the same restrictions as Kubernetes annotations.  The total size of all keys and values combined is limited to 256k.  Key can have 2 segments: prefix (optional) and name (required),  separated by a slash (/).  Prefix must be a DNS subdomain.  Name must be 63 characters or less, begin and end with alphanumerics,  with dashes (-), underscores (_), dots (.), and alphanumerics between.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Optional. Configuration related to the cluster RBAC settings.</summary>
    [JsonPropertyName("authorization")]
    public V1beta1ContainerAttachedClusterSpecAuthorization? Authorization { get; set; }

    /// <summary>Optional. Binary Authorization configuration for this cluster.</summary>
    [JsonPropertyName("binaryAuthorization")]
    public V1beta1ContainerAttachedClusterSpecBinaryAuthorization? BinaryAuthorization { get; set; }

    /// <summary>Optional. Policy to determine what flags to send on delete.</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>Optional. A human readable description of this Attached cluster. Cannot be longer than 255 UTF-8 encoded bytes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The Kubernetes distribution of the underlying attached cluster.   Supported values: ["eks", "aks", "generic"].</summary>
    [JsonPropertyName("distribution")]
    public string Distribution { get; set; }

    /// <summary>Required. Fleet configuration.</summary>
    [JsonPropertyName("fleet")]
    public V1beta1ContainerAttachedClusterSpecFleet Fleet { get; set; }

    /// <summary>Immutable. The location for the resource.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Optional. Logging configuration for this cluster.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta1ContainerAttachedClusterSpecLoggingConfig? LoggingConfig { get; set; }

    /// <summary>Optional. Monitoring configuration for this cluster.</summary>
    [JsonPropertyName("monitoringConfig")]
    public V1beta1ContainerAttachedClusterSpecMonitoringConfig? MonitoringConfig { get; set; }

    /// <summary>Required. OpenID Connect (OIDC) discovery information of the target cluster.  Kubernetes Service Account (KSA) tokens are JWT tokens signed by the cluster API server. This field indicates how GCP services	validate KSA tokens in order to allow system workloads (such as GKE Connect and telemetry agents) to authenticate back to GCP.  Both clusters with public and private issuer URLs are supported. Clusters with public issuers only need to specify the 'issuerUrl' field while clusters with private issuers need to provide both 'issuerUrl' and 'jwks'.</summary>
    [JsonPropertyName("oidcConfig")]
    public V1beta1ContainerAttachedClusterSpecOidcConfig OidcConfig { get; set; }

    /// <summary>Required. The platform version for the cluster (e.g. `1.30.0-gke.1`).</summary>
    [JsonPropertyName("platformVersion")]
    public string PlatformVersion { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1ContainerAttachedClusterSpecProjectRef? ProjectRef { get; set; }

    /// <summary>Immutable, Optional. The ContainerAttachedCluster name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAttachedClusterStatusConditions
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAttachedClusterStatusErrors
{
    /// <summary>Human-friendly description of the error.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAttachedClusterStatusObservedState
{
    /// <summary>Output only. The name of the managed Hub Membership resource associated to  this cluster.   Membership names are formatted as  `projects/&lt;project-number&gt;/locations/global/membership/&lt;cluster-id&gt;`.  This field mirrors the Spec.Fleet.Membership field.</summary>
    [JsonPropertyName("fleetMembership")]
    public string? FleetMembership { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAttachedClusterStatusWorkloadIdentityConfig
{
    /// <summary>The ID of the OIDC Identity Provider (IdP) associated to the Workload Identity Pool.</summary>
    [JsonPropertyName("identityProvider")]
    public string? IdentityProvider { get; set; }

    /// <summary>The OIDC issuer URL for this cluster.</summary>
    [JsonPropertyName("issuerUri")]
    public string? IssuerUri { get; set; }

    /// <summary>The Workload Identity Pool associated to the cluster.</summary>
    [JsonPropertyName("workloadPool")]
    public string? WorkloadPool { get; set; }
}

/// <summary>ContainerAttachedClusterStatus defines the config connector machine state of ContainerAttachedCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAttachedClusterStatus
{
    /// <summary>The region where this cluster runs.   For EKS clusters, this is an AWS region. For AKS clusters,  this is an Azure region.</summary>
    [JsonPropertyName("clusterRegion")]
    public string? ClusterRegion { get; set; }

    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ContainerAttachedClusterStatusConditions>? Conditions { get; set; }

    /// <summary>The time at which this cluster was registered.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>A set of errors found in the cluster.</summary>
    [JsonPropertyName("errors")]
    public IList<V1beta1ContainerAttachedClusterStatusErrors>? Errors { get; set; }

    /// <summary>The Kubernetes version of the cluster.</summary>
    [JsonPropertyName("kubernetesVersion")]
    public string? KubernetesVersion { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1ContainerAttachedClusterStatusObservedState? ObservedState { get; set; }

    /// <summary>If set, there are currently changes in flight to the cluster.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>The current state of the cluster. Possible values:	STATE_UNSPECIFIED, PROVISIONING, RUNNING, RECONCILING, STOPPING, ERROR,	DEGRADED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>A globally unique identifier for the cluster.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>The time at which this cluster was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Workload Identity settings.</summary>
    [JsonPropertyName("workloadIdentityConfig")]
    public IList<V1beta1ContainerAttachedClusterStatusWorkloadIdentityConfig>? WorkloadIdentityConfig { get; set; }
}

/// <summary>ContainerAttachedCluster is the Schema for the ContainerAttachedCluster API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ContainerAttachedCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ContainerAttachedClusterSpec>, IStatus<V1beta1ContainerAttachedClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ContainerAttachedCluster";
    public const string KubeGroup = "containerattached.cnrm.cloud.google.com";
    public const string KubePluralName = "containerattachedclusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ContainerAttachedClusterSpec defines the desired state of ContainerAttachedCluster</summary>
    [JsonPropertyName("spec")]
    public V1beta1ContainerAttachedClusterSpec Spec { get; set; }

    /// <summary>ContainerAttachedClusterStatus defines the config connector machine state of ContainerAttachedCluster</summary>
    [JsonPropertyName("status")]
    public V1beta1ContainerAttachedClusterStatus? Status { get; set; }
}