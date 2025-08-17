using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerattached.gcp.m.upbound.io;
#nullable enable
/// <summary>Cluster is the Schema for the Clusters API. An Anthos cluster running on customer owned infrastructure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Cluster>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "containerattached.gcp.m.upbound.io";
    public const string KubePluralName = "clusters";
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
    public IList<V1beta1Cluster> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration related to the cluster RBAC settings. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAuthorization
{
    /// <summary>Groups that can perform operations as a cluster admin. A managed ClusterRoleBinding will be created to grant the cluster-admin ClusterRole to the groups. Up to ten admin groups can be provided. For more info on RBAC, see https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles</summary>
    [JsonPropertyName("adminGroups")]
    public IList<string>? AdminGroups { get; set; }

    /// <summary>Users that can perform operations as a cluster admin. A managed ClusterRoleBinding will be created to grant the cluster-admin ClusterRole to the users. Up to ten admin users can be provided. For more info on RBAC, see https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles</summary>
    [JsonPropertyName("adminUsers")]
    public IList<string>? AdminUsers { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Binary Authorization configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderBinaryAuthorization
{
    /// <summary>Configure Binary Authorization evaluation mode. Possible values are: DISABLED, PROJECT_SINGLETON_POLICY_ENFORCE.</summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Fleet configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderFleet
{
    /// <summary>The number of the Fleet host project where this cluster will be registered.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration of the logging components Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingConfigComponentConfig
{
    /// <summary>The components to be enabled. Each value may be one of: SYSTEM_COMPONENTS, WORKLOADS.</summary>
    [JsonPropertyName("enableComponents")]
    public IList<string>? EnableComponents { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Logging configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingConfig
{
    /// <summary>The configuration of the logging components Structure is documented below.</summary>
    [JsonPropertyName("componentConfig")]
    public V1beta1ClusterSpecForProviderLoggingConfigComponentConfig? ComponentConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Enable Google Cloud Managed Service for Prometheus in the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMonitoringConfigManagedPrometheusConfig
{
    /// <summary>Enable Managed Collection.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Monitoring configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMonitoringConfig
{
    /// <summary>Enable Google Cloud Managed Service for Prometheus in the cluster. Structure is documented below.</summary>
    [JsonPropertyName("managedPrometheusConfig")]
    public V1beta1ClusterSpecForProviderMonitoringConfigManagedPrometheusConfig? ManagedPrometheusConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>OIDC discovery information of the target cluster. Kubernetes Service Account (KSA) tokens are JWT tokens signed by the cluster API server. This fields indicates how GCP services validate KSA tokens in order to allow system workloads (such as GKE Connect and telemetry agents) to authenticate back to GCP. Both clusters with public and private issuer URLs are supported. Clusters with public issuers only need to specify the issuer_url field while clusters with private issuers need to provide both issuer_url and jwks. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderOidcConfig
{
    /// <summary>A JSON Web Token (JWT) issuer URI. issuer must start with https://</summary>
    [JsonPropertyName("issuerUrl")]
    public string? IssuerUrl { get; set; }

    /// <summary>OIDC verification keys in JWKS format (RFC 7517).</summary>
    [JsonPropertyName("jwks")]
    public string? Jwks { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Kubernetes Secret resource that contains the HTTP(S) proxy configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderProxyConfigKubernetesSecret
{
    /// <summary>Name of the kubernetes secret containing the proxy config.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the kubernetes secret containing the proxy config.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Support for proxy configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderProxyConfig
{
    /// <summary>The Kubernetes Secret resource that contains the HTTP(S) proxy configuration. Structure is documented below.</summary>
    [JsonPropertyName("kubernetesSecret")]
    public V1beta1ClusterSpecForProviderProxyConfigKubernetesSecret? KubernetesSecret { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Enable/Disable Security Posture API features for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderSecurityPostureConfig
{
    /// <summary>Sets the mode of the Kubernetes security posture API's workload vulnerability scanning. Possible values are: VULNERABILITY_DISABLED, VULNERABILITY_ENTERPRISE.</summary>
    [JsonPropertyName("vulnerabilityMode")]
    public string? VulnerabilityMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProvider
{
    /// <summary>Optional. Annotations on the cluster. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Key can have 2 segments: prefix and name , separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Configuration related to the cluster RBAC settings. Structure is documented below.</summary>
    [JsonPropertyName("authorization")]
    public V1beta1ClusterSpecForProviderAuthorization? Authorization { get; set; }

    /// <summary>Binary Authorization configuration. Structure is documented below.</summary>
    [JsonPropertyName("binaryAuthorization")]
    public V1beta1ClusterSpecForProviderBinaryAuthorization? BinaryAuthorization { get; set; }

    /// <summary>Policy to determine what flags to send on delete. Possible values: DELETE, DELETE_IGNORE_ERRORS</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>A human readable description of this attached cluster. Cannot be longer than 255 UTF-8 encoded bytes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Kubernetes distribution of the underlying attached cluster. Supported values: "eks", "aks", "generic". The generic distribution provides the ability to register or migrate any CNCF conformant cluster.</summary>
    [JsonPropertyName("distribution")]
    public string? Distribution { get; set; }

    /// <summary>Fleet configuration. Structure is documented below.</summary>
    [JsonPropertyName("fleet")]
    public V1beta1ClusterSpecForProviderFleet? Fleet { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Logging configuration. Structure is documented below.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta1ClusterSpecForProviderLoggingConfig? LoggingConfig { get; set; }

    /// <summary>Monitoring configuration. Structure is documented below.</summary>
    [JsonPropertyName("monitoringConfig")]
    public V1beta1ClusterSpecForProviderMonitoringConfig? MonitoringConfig { get; set; }

    /// <summary>OIDC discovery information of the target cluster. Kubernetes Service Account (KSA) tokens are JWT tokens signed by the cluster API server. This fields indicates how GCP services validate KSA tokens in order to allow system workloads (such as GKE Connect and telemetry agents) to authenticate back to GCP. Both clusters with public and private issuer URLs are supported. Clusters with public issuers only need to specify the issuer_url field while clusters with private issuers need to provide both issuer_url and jwks. Structure is documented below.</summary>
    [JsonPropertyName("oidcConfig")]
    public V1beta1ClusterSpecForProviderOidcConfig? OidcConfig { get; set; }

    /// <summary>The platform version for the cluster (e.g. 1.23.0-gke.1).</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Support for proxy configuration. Structure is documented below.</summary>
    [JsonPropertyName("proxyConfig")]
    public V1beta1ClusterSpecForProviderProxyConfig? ProxyConfig { get; set; }

    /// <summary>Enable/Disable Security Posture API features for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("securityPostureConfig")]
    public V1beta1ClusterSpecForProviderSecurityPostureConfig? SecurityPostureConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration related to the cluster RBAC settings. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAuthorization
{
    /// <summary>Groups that can perform operations as a cluster admin. A managed ClusterRoleBinding will be created to grant the cluster-admin ClusterRole to the groups. Up to ten admin groups can be provided. For more info on RBAC, see https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles</summary>
    [JsonPropertyName("adminGroups")]
    public IList<string>? AdminGroups { get; set; }

    /// <summary>Users that can perform operations as a cluster admin. A managed ClusterRoleBinding will be created to grant the cluster-admin ClusterRole to the users. Up to ten admin users can be provided. For more info on RBAC, see https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles</summary>
    [JsonPropertyName("adminUsers")]
    public IList<string>? AdminUsers { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Binary Authorization configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderBinaryAuthorization
{
    /// <summary>Configure Binary Authorization evaluation mode. Possible values are: DISABLED, PROJECT_SINGLETON_POLICY_ENFORCE.</summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Fleet configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderFleet
{
    /// <summary>The number of the Fleet host project where this cluster will be registered.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration of the logging components Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingConfigComponentConfig
{
    /// <summary>The components to be enabled. Each value may be one of: SYSTEM_COMPONENTS, WORKLOADS.</summary>
    [JsonPropertyName("enableComponents")]
    public IList<string>? EnableComponents { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Logging configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingConfig
{
    /// <summary>The configuration of the logging components Structure is documented below.</summary>
    [JsonPropertyName("componentConfig")]
    public V1beta1ClusterSpecInitProviderLoggingConfigComponentConfig? ComponentConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Enable Google Cloud Managed Service for Prometheus in the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMonitoringConfigManagedPrometheusConfig
{
    /// <summary>Enable Managed Collection.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Monitoring configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMonitoringConfig
{
    /// <summary>Enable Google Cloud Managed Service for Prometheus in the cluster. Structure is documented below.</summary>
    [JsonPropertyName("managedPrometheusConfig")]
    public V1beta1ClusterSpecInitProviderMonitoringConfigManagedPrometheusConfig? ManagedPrometheusConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>OIDC discovery information of the target cluster. Kubernetes Service Account (KSA) tokens are JWT tokens signed by the cluster API server. This fields indicates how GCP services validate KSA tokens in order to allow system workloads (such as GKE Connect and telemetry agents) to authenticate back to GCP. Both clusters with public and private issuer URLs are supported. Clusters with public issuers only need to specify the issuer_url field while clusters with private issuers need to provide both issuer_url and jwks. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderOidcConfig
{
    /// <summary>A JSON Web Token (JWT) issuer URI. issuer must start with https://</summary>
    [JsonPropertyName("issuerUrl")]
    public string? IssuerUrl { get; set; }

    /// <summary>OIDC verification keys in JWKS format (RFC 7517).</summary>
    [JsonPropertyName("jwks")]
    public string? Jwks { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Kubernetes Secret resource that contains the HTTP(S) proxy configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderProxyConfigKubernetesSecret
{
    /// <summary>Name of the kubernetes secret containing the proxy config.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the kubernetes secret containing the proxy config.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Support for proxy configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderProxyConfig
{
    /// <summary>The Kubernetes Secret resource that contains the HTTP(S) proxy configuration. Structure is documented below.</summary>
    [JsonPropertyName("kubernetesSecret")]
    public V1beta1ClusterSpecInitProviderProxyConfigKubernetesSecret? KubernetesSecret { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Enable/Disable Security Posture API features for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderSecurityPostureConfig
{
    /// <summary>Sets the mode of the Kubernetes security posture API's workload vulnerability scanning. Possible values are: VULNERABILITY_DISABLED, VULNERABILITY_ENTERPRISE.</summary>
    [JsonPropertyName("vulnerabilityMode")]
    public string? VulnerabilityMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProvider
{
    /// <summary>Optional. Annotations on the cluster. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Key can have 2 segments: prefix and name , separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Configuration related to the cluster RBAC settings. Structure is documented below.</summary>
    [JsonPropertyName("authorization")]
    public V1beta1ClusterSpecInitProviderAuthorization? Authorization { get; set; }

    /// <summary>Binary Authorization configuration. Structure is documented below.</summary>
    [JsonPropertyName("binaryAuthorization")]
    public V1beta1ClusterSpecInitProviderBinaryAuthorization? BinaryAuthorization { get; set; }

    /// <summary>Policy to determine what flags to send on delete. Possible values: DELETE, DELETE_IGNORE_ERRORS</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>A human readable description of this attached cluster. Cannot be longer than 255 UTF-8 encoded bytes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Kubernetes distribution of the underlying attached cluster. Supported values: "eks", "aks", "generic". The generic distribution provides the ability to register or migrate any CNCF conformant cluster.</summary>
    [JsonPropertyName("distribution")]
    public string? Distribution { get; set; }

    /// <summary>Fleet configuration. Structure is documented below.</summary>
    [JsonPropertyName("fleet")]
    public V1beta1ClusterSpecInitProviderFleet? Fleet { get; set; }

    /// <summary>Logging configuration. Structure is documented below.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta1ClusterSpecInitProviderLoggingConfig? LoggingConfig { get; set; }

    /// <summary>Monitoring configuration. Structure is documented below.</summary>
    [JsonPropertyName("monitoringConfig")]
    public V1beta1ClusterSpecInitProviderMonitoringConfig? MonitoringConfig { get; set; }

    /// <summary>OIDC discovery information of the target cluster. Kubernetes Service Account (KSA) tokens are JWT tokens signed by the cluster API server. This fields indicates how GCP services validate KSA tokens in order to allow system workloads (such as GKE Connect and telemetry agents) to authenticate back to GCP. Both clusters with public and private issuer URLs are supported. Clusters with public issuers only need to specify the issuer_url field while clusters with private issuers need to provide both issuer_url and jwks. Structure is documented below.</summary>
    [JsonPropertyName("oidcConfig")]
    public V1beta1ClusterSpecInitProviderOidcConfig? OidcConfig { get; set; }

    /// <summary>The platform version for the cluster (e.g. 1.23.0-gke.1).</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Support for proxy configuration. Structure is documented below.</summary>
    [JsonPropertyName("proxyConfig")]
    public V1beta1ClusterSpecInitProviderProxyConfig? ProxyConfig { get; set; }

    /// <summary>Enable/Disable Security Posture API features for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("securityPostureConfig")]
    public V1beta1ClusterSpecInitProviderSecurityPostureConfig? SecurityPostureConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ClusterSpec defines the desired state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ClusterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration related to the cluster RBAC settings. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAuthorization
{
    /// <summary>Groups that can perform operations as a cluster admin. A managed ClusterRoleBinding will be created to grant the cluster-admin ClusterRole to the groups. Up to ten admin groups can be provided. For more info on RBAC, see https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles</summary>
    [JsonPropertyName("adminGroups")]
    public IList<string>? AdminGroups { get; set; }

    /// <summary>Users that can perform operations as a cluster admin. A managed ClusterRoleBinding will be created to grant the cluster-admin ClusterRole to the users. Up to ten admin users can be provided. For more info on RBAC, see https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles</summary>
    [JsonPropertyName("adminUsers")]
    public IList<string>? AdminUsers { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Binary Authorization configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderBinaryAuthorization
{
    /// <summary>Configure Binary Authorization evaluation mode. Possible values are: DISABLED, PROJECT_SINGLETON_POLICY_ENFORCE.</summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderErrors
{
    /// <summary>Human-friendly description of the error.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Fleet configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderFleet
{
    /// <summary>(Output) The name of the managed Hub Membership resource associated to this cluster. Membership names are formatted as projects//locations/global/membership/.</summary>
    [JsonPropertyName("membership")]
    public string? Membership { get; set; }

    /// <summary>The number of the Fleet host project where this cluster will be registered.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration of the logging components Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderLoggingConfigComponentConfig
{
    /// <summary>The components to be enabled. Each value may be one of: SYSTEM_COMPONENTS, WORKLOADS.</summary>
    [JsonPropertyName("enableComponents")]
    public IList<string>? EnableComponents { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Logging configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderLoggingConfig
{
    /// <summary>The configuration of the logging components Structure is documented below.</summary>
    [JsonPropertyName("componentConfig")]
    public V1beta1ClusterStatusAtProviderLoggingConfigComponentConfig? ComponentConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Enable Google Cloud Managed Service for Prometheus in the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMonitoringConfigManagedPrometheusConfig
{
    /// <summary>Enable Managed Collection.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Monitoring configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMonitoringConfig
{
    /// <summary>Enable Google Cloud Managed Service for Prometheus in the cluster. Structure is documented below.</summary>
    [JsonPropertyName("managedPrometheusConfig")]
    public V1beta1ClusterStatusAtProviderMonitoringConfigManagedPrometheusConfig? ManagedPrometheusConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>OIDC discovery information of the target cluster. Kubernetes Service Account (KSA) tokens are JWT tokens signed by the cluster API server. This fields indicates how GCP services validate KSA tokens in order to allow system workloads (such as GKE Connect and telemetry agents) to authenticate back to GCP. Both clusters with public and private issuer URLs are supported. Clusters with public issuers only need to specify the issuer_url field while clusters with private issuers need to provide both issuer_url and jwks. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderOidcConfig
{
    /// <summary>A JSON Web Token (JWT) issuer URI. issuer must start with https://</summary>
    [JsonPropertyName("issuerUrl")]
    public string? IssuerUrl { get; set; }

    /// <summary>OIDC verification keys in JWKS format (RFC 7517).</summary>
    [JsonPropertyName("jwks")]
    public string? Jwks { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Kubernetes Secret resource that contains the HTTP(S) proxy configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderProxyConfigKubernetesSecret
{
    /// <summary>Name of the kubernetes secret containing the proxy config.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the kubernetes secret containing the proxy config.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Support for proxy configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderProxyConfig
{
    /// <summary>The Kubernetes Secret resource that contains the HTTP(S) proxy configuration. Structure is documented below.</summary>
    [JsonPropertyName("kubernetesSecret")]
    public V1beta1ClusterStatusAtProviderProxyConfigKubernetesSecret? KubernetesSecret { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Enable/Disable Security Posture API features for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderSecurityPostureConfig
{
    /// <summary>Sets the mode of the Kubernetes security posture API's workload vulnerability scanning. Possible values are: VULNERABILITY_DISABLED, VULNERABILITY_ENTERPRISE.</summary>
    [JsonPropertyName("vulnerabilityMode")]
    public string? VulnerabilityMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderWorkloadIdentityConfig
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProvider
{
    /// <summary>Optional. Annotations on the cluster. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Key can have 2 segments: prefix and name , separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Configuration related to the cluster RBAC settings. Structure is documented below.</summary>
    [JsonPropertyName("authorization")]
    public V1beta1ClusterStatusAtProviderAuthorization? Authorization { get; set; }

    /// <summary>Binary Authorization configuration. Structure is documented below.</summary>
    [JsonPropertyName("binaryAuthorization")]
    public V1beta1ClusterStatusAtProviderBinaryAuthorization? BinaryAuthorization { get; set; }

    /// <summary>Output only. The region where this cluster runs. For EKS clusters, this is an AWS region. For AKS clusters, this is an Azure region.</summary>
    [JsonPropertyName("clusterRegion")]
    public string? ClusterRegion { get; set; }

    /// <summary>Output only. The time at which this cluster was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Policy to determine what flags to send on delete. Possible values: DELETE, DELETE_IGNORE_ERRORS</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>A human readable description of this attached cluster. Cannot be longer than 255 UTF-8 encoded bytes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Kubernetes distribution of the underlying attached cluster. Supported values: "eks", "aks", "generic". The generic distribution provides the ability to register or migrate any CNCF conformant cluster.</summary>
    [JsonPropertyName("distribution")]
    public string? Distribution { get; set; }

    /// <summary>for all of the annotations present on the resource.</summary>
    [JsonPropertyName("effectiveAnnotations")]
    public IDictionary<string, string>? EffectiveAnnotations { get; set; }

    /// <summary>A set of errors found in the cluster. Structure is documented below.</summary>
    [JsonPropertyName("errors")]
    public IList<V1beta1ClusterStatusAtProviderErrors>? Errors { get; set; }

    /// <summary>Fleet configuration. Structure is documented below.</summary>
    [JsonPropertyName("fleet")]
    public V1beta1ClusterStatusAtProviderFleet? Fleet { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/attachedClusters/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Kubernetes version of the cluster.</summary>
    [JsonPropertyName("kubernetesVersion")]
    public string? KubernetesVersion { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Logging configuration. Structure is documented below.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta1ClusterStatusAtProviderLoggingConfig? LoggingConfig { get; set; }

    /// <summary>Monitoring configuration. Structure is documented below.</summary>
    [JsonPropertyName("monitoringConfig")]
    public V1beta1ClusterStatusAtProviderMonitoringConfig? MonitoringConfig { get; set; }

    /// <summary>OIDC discovery information of the target cluster. Kubernetes Service Account (KSA) tokens are JWT tokens signed by the cluster API server. This fields indicates how GCP services validate KSA tokens in order to allow system workloads (such as GKE Connect and telemetry agents) to authenticate back to GCP. Both clusters with public and private issuer URLs are supported. Clusters with public issuers only need to specify the issuer_url field while clusters with private issuers need to provide both issuer_url and jwks. Structure is documented below.</summary>
    [JsonPropertyName("oidcConfig")]
    public V1beta1ClusterStatusAtProviderOidcConfig? OidcConfig { get; set; }

    /// <summary>The platform version for the cluster (e.g. 1.23.0-gke.1).</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Support for proxy configuration. Structure is documented below.</summary>
    [JsonPropertyName("proxyConfig")]
    public V1beta1ClusterStatusAtProviderProxyConfig? ProxyConfig { get; set; }

    /// <summary>If set, there are currently changes in flight to the cluster.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>Enable/Disable Security Posture API features for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("securityPostureConfig")]
    public V1beta1ClusterStatusAtProviderSecurityPostureConfig? SecurityPostureConfig { get; set; }

    /// <summary>The current state of the cluster. Possible values: STATE_UNSPECIFIED, PROVISIONING, RUNNING, RECONCILING, STOPPING, ERROR, DEGRADED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>A globally unique identifier for the cluster.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>The time at which this cluster was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Workload Identity settings. Structure is documented below.</summary>
    [JsonPropertyName("workloadIdentityConfig")]
    public IList<V1beta1ClusterStatusAtProviderWorkloadIdentityConfig>? WorkloadIdentityConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusConditions
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
/// <summary>ClusterStatus defines the observed state of Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Cluster is the Schema for the Clusters API. An Anthos cluster running on customer owned infrastructure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClusterSpec>, IStatus<V1beta1ClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "containerattached.gcp.m.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClusterSpec defines the desired state of Cluster</summary>
    [JsonPropertyName("spec")]
    public V1beta1ClusterSpec Spec { get; set; }

    /// <summary>ClusterStatus defines the observed state of Cluster.</summary>
    [JsonPropertyName("status")]
    public V1beta1ClusterStatus? Status { get; set; }
}
#nullable disable
