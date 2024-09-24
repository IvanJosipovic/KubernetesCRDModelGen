using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerattached.gcp.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ClusterSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderBinaryAuthorization
{
    /// <summary>Configure Binary Authorization evaluation mode. Possible values are: DISABLED, PROJECT_SINGLETON_POLICY_ENFORCE.</summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderFleet
{
    /// <summary>The number of the Fleet host project where this cluster will be registered.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingConfigComponentConfig
{
    /// <summary>The components to be enabled. Each value may be one of: SYSTEM_COMPONENTS, WORKLOADS.</summary>
    [JsonPropertyName("enableComponents")]
    public IList<string>? EnableComponents { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingConfig
{
    /// <summary>The configuration of the logging components Structure is documented below.</summary>
    [JsonPropertyName("componentConfig")]
    public IList<V1beta1ClusterSpecForProviderLoggingConfigComponentConfig>? ComponentConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMonitoringConfigManagedPrometheusConfig
{
    /// <summary>Enable Managed Collection.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMonitoringConfig
{
    /// <summary>Enable Google Cloud Managed Service for Prometheus in the cluster. Structure is documented below.</summary>
    [JsonPropertyName("managedPrometheusConfig")]
    public IList<V1beta1ClusterSpecForProviderMonitoringConfigManagedPrometheusConfig>? ManagedPrometheusConfig { get; set; }
}

/// <summary></summary>
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

/// <summary></summary>
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderProxyConfig
{
    /// <summary>The Kubernetes Secret resource that contains the HTTP(S) proxy configuration. Structure is documented below.</summary>
    [JsonPropertyName("kubernetesSecret")]
    public IList<V1beta1ClusterSpecForProviderProxyConfigKubernetesSecret>? KubernetesSecret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProvider
{
    /// <summary>Optional. Annotations on the cluster. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Key can have 2 segments: prefix and name , separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Configuration related to the cluster RBAC settings. Structure is documented below.</summary>
    [JsonPropertyName("authorization")]
    public IList<V1beta1ClusterSpecForProviderAuthorization>? Authorization { get; set; }

    /// <summary>Binary Authorization configuration. Structure is documented below.</summary>
    [JsonPropertyName("binaryAuthorization")]
    public IList<V1beta1ClusterSpecForProviderBinaryAuthorization>? BinaryAuthorization { get; set; }

    /// <summary>Policy to determine what flags to send on delete.</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>A human readable description of this attached cluster. Cannot be longer than 255 UTF-8 encoded bytes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Kubernetes distribution of the underlying attached cluster. Supported values: "eks", "aks".</summary>
    [JsonPropertyName("distribution")]
    public string? Distribution { get; set; }

    /// <summary>Fleet configuration. Structure is documented below.</summary>
    [JsonPropertyName("fleet")]
    public IList<V1beta1ClusterSpecForProviderFleet>? Fleet { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Logging configuration. Structure is documented below.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1ClusterSpecForProviderLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>Monitoring configuration. Structure is documented below.</summary>
    [JsonPropertyName("monitoringConfig")]
    public IList<V1beta1ClusterSpecForProviderMonitoringConfig>? MonitoringConfig { get; set; }

    /// <summary>OIDC discovery information of the target cluster. Kubernetes Service Account (KSA) tokens are JWT tokens signed by the cluster API server. This fields indicates how GCP services validate KSA tokens in order to allow system workloads (such as GKE Connect and telemetry agents) to authenticate back to GCP. Both clusters with public and private issuer URLs are supported. Clusters with public issuers only need to specify the issuer_url field while clusters with private issuers need to provide both issuer_url and jwks. Structure is documented below.</summary>
    [JsonPropertyName("oidcConfig")]
    public IList<V1beta1ClusterSpecForProviderOidcConfig>? OidcConfig { get; set; }

    /// <summary>The platform version for the cluster (e.g. 1.23.0-gke.1).</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>The number of the Fleet host project where this cluster will be registered.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Support for proxy configuration. Structure is documented below.</summary>
    [JsonPropertyName("proxyConfig")]
    public IList<V1beta1ClusterSpecForProviderProxyConfig>? ProxyConfig { get; set; }
}

/// <summary></summary>
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderBinaryAuthorization
{
    /// <summary>Configure Binary Authorization evaluation mode. Possible values are: DISABLED, PROJECT_SINGLETON_POLICY_ENFORCE.</summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderFleet
{
    /// <summary>The number of the Fleet host project where this cluster will be registered.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingConfigComponentConfig
{
    /// <summary>The components to be enabled. Each value may be one of: SYSTEM_COMPONENTS, WORKLOADS.</summary>
    [JsonPropertyName("enableComponents")]
    public IList<string>? EnableComponents { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingConfig
{
    /// <summary>The configuration of the logging components Structure is documented below.</summary>
    [JsonPropertyName("componentConfig")]
    public IList<V1beta1ClusterSpecInitProviderLoggingConfigComponentConfig>? ComponentConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMonitoringConfigManagedPrometheusConfig
{
    /// <summary>Enable Managed Collection.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMonitoringConfig
{
    /// <summary>Enable Google Cloud Managed Service for Prometheus in the cluster. Structure is documented below.</summary>
    [JsonPropertyName("managedPrometheusConfig")]
    public IList<V1beta1ClusterSpecInitProviderMonitoringConfigManagedPrometheusConfig>? ManagedPrometheusConfig { get; set; }
}

/// <summary></summary>
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

/// <summary></summary>
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderProxyConfig
{
    /// <summary>The Kubernetes Secret resource that contains the HTTP(S) proxy configuration. Structure is documented below.</summary>
    [JsonPropertyName("kubernetesSecret")]
    public IList<V1beta1ClusterSpecInitProviderProxyConfigKubernetesSecret>? KubernetesSecret { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProvider
{
    /// <summary>Optional. Annotations on the cluster. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Key can have 2 segments: prefix and name , separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Configuration related to the cluster RBAC settings. Structure is documented below.</summary>
    [JsonPropertyName("authorization")]
    public IList<V1beta1ClusterSpecInitProviderAuthorization>? Authorization { get; set; }

    /// <summary>Binary Authorization configuration. Structure is documented below.</summary>
    [JsonPropertyName("binaryAuthorization")]
    public IList<V1beta1ClusterSpecInitProviderBinaryAuthorization>? BinaryAuthorization { get; set; }

    /// <summary>Policy to determine what flags to send on delete.</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>A human readable description of this attached cluster. Cannot be longer than 255 UTF-8 encoded bytes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Kubernetes distribution of the underlying attached cluster. Supported values: "eks", "aks".</summary>
    [JsonPropertyName("distribution")]
    public string? Distribution { get; set; }

    /// <summary>Fleet configuration. Structure is documented below.</summary>
    [JsonPropertyName("fleet")]
    public IList<V1beta1ClusterSpecInitProviderFleet>? Fleet { get; set; }

    /// <summary>Logging configuration. Structure is documented below.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1ClusterSpecInitProviderLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>Monitoring configuration. Structure is documented below.</summary>
    [JsonPropertyName("monitoringConfig")]
    public IList<V1beta1ClusterSpecInitProviderMonitoringConfig>? MonitoringConfig { get; set; }

    /// <summary>OIDC discovery information of the target cluster. Kubernetes Service Account (KSA) tokens are JWT tokens signed by the cluster API server. This fields indicates how GCP services validate KSA tokens in order to allow system workloads (such as GKE Connect and telemetry agents) to authenticate back to GCP. Both clusters with public and private issuer URLs are supported. Clusters with public issuers only need to specify the issuer_url field while clusters with private issuers need to provide both issuer_url and jwks. Structure is documented below.</summary>
    [JsonPropertyName("oidcConfig")]
    public IList<V1beta1ClusterSpecInitProviderOidcConfig>? OidcConfig { get; set; }

    /// <summary>The platform version for the cluster (e.g. 1.23.0-gke.1).</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>The number of the Fleet host project where this cluster will be registered.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Support for proxy configuration. Structure is documented below.</summary>
    [JsonPropertyName("proxyConfig")]
    public IList<V1beta1ClusterSpecInitProviderProxyConfig>? ProxyConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ClusterSpecManagementPoliciesEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ClusterSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ClusterSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ClusterSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ClusterSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ClusterSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ClusterSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ClusterSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ClusterSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecPublishConnectionDetailsToMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ClusterSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ClusterSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ClusterSpec defines the desired state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecDeletionPolicyEnum>))]
    public V1beta1ClusterSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ClusterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ClusterSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ClusterSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderBinaryAuthorization
{
    /// <summary>Configure Binary Authorization evaluation mode. Possible values are: DISABLED, PROJECT_SINGLETON_POLICY_ENFORCE.</summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderErrors
{
    /// <summary>Human-friendly description of the error.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary></summary>
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderLoggingConfigComponentConfig
{
    /// <summary>The components to be enabled. Each value may be one of: SYSTEM_COMPONENTS, WORKLOADS.</summary>
    [JsonPropertyName("enableComponents")]
    public IList<string>? EnableComponents { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderLoggingConfig
{
    /// <summary>The configuration of the logging components Structure is documented below.</summary>
    [JsonPropertyName("componentConfig")]
    public IList<V1beta1ClusterStatusAtProviderLoggingConfigComponentConfig>? ComponentConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMonitoringConfigManagedPrometheusConfig
{
    /// <summary>Enable Managed Collection.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMonitoringConfig
{
    /// <summary>Enable Google Cloud Managed Service for Prometheus in the cluster. Structure is documented below.</summary>
    [JsonPropertyName("managedPrometheusConfig")]
    public IList<V1beta1ClusterStatusAtProviderMonitoringConfigManagedPrometheusConfig>? ManagedPrometheusConfig { get; set; }
}

/// <summary></summary>
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

/// <summary></summary>
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderProxyConfig
{
    /// <summary>The Kubernetes Secret resource that contains the HTTP(S) proxy configuration. Structure is documented below.</summary>
    [JsonPropertyName("kubernetesSecret")]
    public IList<V1beta1ClusterStatusAtProviderProxyConfigKubernetesSecret>? KubernetesSecret { get; set; }
}

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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProvider
{
    /// <summary>Optional. Annotations on the cluster. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Key can have 2 segments: prefix and name , separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Configuration related to the cluster RBAC settings. Structure is documented below.</summary>
    [JsonPropertyName("authorization")]
    public IList<V1beta1ClusterStatusAtProviderAuthorization>? Authorization { get; set; }

    /// <summary>Binary Authorization configuration. Structure is documented below.</summary>
    [JsonPropertyName("binaryAuthorization")]
    public IList<V1beta1ClusterStatusAtProviderBinaryAuthorization>? BinaryAuthorization { get; set; }

    /// <summary>Output only. The region where this cluster runs. For EKS clusters, this is an AWS region. For AKS clusters, this is an Azure region.</summary>
    [JsonPropertyName("clusterRegion")]
    public string? ClusterRegion { get; set; }

    /// <summary>Output only. The time at which this cluster was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Policy to determine what flags to send on delete.</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>A human readable description of this attached cluster. Cannot be longer than 255 UTF-8 encoded bytes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Kubernetes distribution of the underlying attached cluster. Supported values: "eks", "aks".</summary>
    [JsonPropertyName("distribution")]
    public string? Distribution { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveAnnotations")]
    public IDictionary<string, string>? EffectiveAnnotations { get; set; }

    /// <summary>A set of errors found in the cluster. Structure is documented below.</summary>
    [JsonPropertyName("errors")]
    public IList<V1beta1ClusterStatusAtProviderErrors>? Errors { get; set; }

    /// <summary>Fleet configuration. Structure is documented below.</summary>
    [JsonPropertyName("fleet")]
    public IList<V1beta1ClusterStatusAtProviderFleet>? Fleet { get; set; }

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
    public IList<V1beta1ClusterStatusAtProviderLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>Monitoring configuration. Structure is documented below.</summary>
    [JsonPropertyName("monitoringConfig")]
    public IList<V1beta1ClusterStatusAtProviderMonitoringConfig>? MonitoringConfig { get; set; }

    /// <summary>OIDC discovery information of the target cluster. Kubernetes Service Account (KSA) tokens are JWT tokens signed by the cluster API server. This fields indicates how GCP services validate KSA tokens in order to allow system workloads (such as GKE Connect and telemetry agents) to authenticate back to GCP. Both clusters with public and private issuer URLs are supported. Clusters with public issuers only need to specify the issuer_url field while clusters with private issuers need to provide both issuer_url and jwks. Structure is documented below.</summary>
    [JsonPropertyName("oidcConfig")]
    public IList<V1beta1ClusterStatusAtProviderOidcConfig>? OidcConfig { get; set; }

    /// <summary>The platform version for the cluster (e.g. 1.23.0-gke.1).</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>The number of the Fleet host project where this cluster will be registered.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Support for proxy configuration. Structure is documented below.</summary>
    [JsonPropertyName("proxyConfig")]
    public IList<V1beta1ClusterStatusAtProviderProxyConfig>? ProxyConfig { get; set; }

    /// <summary>If set, there are currently changes in flight to the cluster.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

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

/// <summary>Cluster is the Schema for the Clusters API. An Anthos cluster running on customer owned infrastructure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClusterSpec>, IStatus<V1beta1ClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "containerattached.gcp.upbound.io";
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