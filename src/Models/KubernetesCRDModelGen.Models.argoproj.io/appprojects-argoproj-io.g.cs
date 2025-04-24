using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.argoproj.io;
/// <summary>GroupKind specifies a Group and a Kind, but does not force a version.  This is useful for identifying concepts during lookup stages without having partially valid types</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppProjectSpecClusterResourceBlacklist
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }
}

/// <summary>GroupKind specifies a Group and a Kind, but does not force a version.  This is useful for identifying concepts during lookup stages without having partially valid types</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppProjectSpecClusterResourceWhitelist
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }
}

/// <summary>ApplicationDestinationServiceAccount holds information about the service account to be impersonated for the application sync operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppProjectSpecDestinationServiceAccounts
{
    /// <summary>DefaultServiceAccount to be used for impersonation during the sync operation</summary>
    [JsonPropertyName("defaultServiceAccount")]
    public string DefaultServiceAccount { get; set; }

    /// <summary>Namespace specifies the target namespace for the application's resources.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Server specifies the URL of the target cluster's Kubernetes control plane API.</summary>
    [JsonPropertyName("server")]
    public string Server { get; set; }
}

/// <summary>ApplicationDestination holds information about the application's destination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppProjectSpecDestinations
{
    /// <summary>Name is an alternate way of specifying the target cluster by its symbolic name. This must be set if Server is not set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies the target namespace for the application's resources. The namespace will only be set for namespace-scoped resources that have not set a value for .metadata.namespace</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Server specifies the URL of the target cluster's Kubernetes control plane API. This must be set if Name is not set.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary>GroupKind specifies a Group and a Kind, but does not force a version.  This is useful for identifying concepts during lookup stages without having partially valid types</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppProjectSpecNamespaceResourceBlacklist
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }
}

/// <summary>GroupKind specifies a Group and a Kind, but does not force a version.  This is useful for identifying concepts during lookup stages without having partially valid types</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppProjectSpecNamespaceResourceWhitelist
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }
}

/// <summary>OrphanedResourceKey is a reference to a resource to be ignored from</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppProjectSpecOrphanedResourcesIgnore
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>OrphanedResources specifies if controller should monitor orphaned resources of apps in this project</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppProjectSpecOrphanedResources
{
    /// <summary>Ignore contains a list of resources that are to be excluded from orphaned resources monitoring</summary>
    [JsonPropertyName("ignore")]
    public IList<V1alpha1AppProjectSpecOrphanedResourcesIgnore>? Ignore { get; set; }

    /// <summary>Warn indicates if warning condition should be created for apps which have orphaned resources</summary>
    [JsonPropertyName("warn")]
    public bool? Warn { get; set; }
}

/// <summary>JWTToken holds the issuedAt and expiresAt values of a token</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppProjectSpecRolesJwtTokens
{
    /// <summary></summary>
    [JsonPropertyName("exp")]
    public long? Exp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iat")]
    public long Iat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>ProjectRole represents a role that has access to a project</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppProjectSpecRoles
{
    /// <summary>Description is a description of the role</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Groups are a list of OIDC group claims bound to this role</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary>JWTTokens are a list of generated JWT tokens bound to this role</summary>
    [JsonPropertyName("jwtTokens")]
    public IList<V1alpha1AppProjectSpecRolesJwtTokens>? JwtTokens { get; set; }

    /// <summary>Name is a name for this role</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies Stores a list of casbin formatted strings that define access policies for the role in the project</summary>
    [JsonPropertyName("policies")]
    public IList<string>? Policies { get; set; }
}

/// <summary>SignatureKey is the specification of a key required to verify commit signatures with</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppProjectSpecSignatureKeys
{
    /// <summary>The ID of the key in hexadecimal notation</summary>
    [JsonPropertyName("keyID")]
    public string KeyID { get; set; }
}

/// <summary>SyncWindow contains the kind, time, duration and attributes that are used to assign the syncWindows to apps</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppProjectSpecSyncWindows
{
    /// <summary>Applications contains a list of applications that the window will apply to</summary>
    [JsonPropertyName("applications")]
    public IList<string>? Applications { get; set; }

    /// <summary>Clusters contains a list of clusters that the window will apply to</summary>
    [JsonPropertyName("clusters")]
    public IList<string>? Clusters { get; set; }

    /// <summary>Duration is the amount of time the sync window will be open</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>Kind defines if the window allows or blocks syncs</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>ManualSync enables manual syncs when they would otherwise be blocked</summary>
    [JsonPropertyName("manualSync")]
    public bool? ManualSync { get; set; }

    /// <summary>Namespaces contains a list of namespaces that the window will apply to</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Schedule is the time the window will begin, specified in cron format</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>TimeZone of the sync that will be applied to the schedule</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>AppProjectSpec is the specification of an AppProject</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppProjectSpec
{
    /// <summary>ClusterResourceBlacklist contains list of blacklisted cluster level resources</summary>
    [JsonPropertyName("clusterResourceBlacklist")]
    public IList<V1alpha1AppProjectSpecClusterResourceBlacklist>? ClusterResourceBlacklist { get; set; }

    /// <summary>ClusterResourceWhitelist contains list of whitelisted cluster level resources</summary>
    [JsonPropertyName("clusterResourceWhitelist")]
    public IList<V1alpha1AppProjectSpecClusterResourceWhitelist>? ClusterResourceWhitelist { get; set; }

    /// <summary>Description contains optional project description</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DestinationServiceAccounts holds information about the service accounts to be impersonated for the application sync operation for each destination.</summary>
    [JsonPropertyName("destinationServiceAccounts")]
    public IList<V1alpha1AppProjectSpecDestinationServiceAccounts>? DestinationServiceAccounts { get; set; }

    /// <summary>Destinations contains list of destinations available for deployment</summary>
    [JsonPropertyName("destinations")]
    public IList<V1alpha1AppProjectSpecDestinations>? Destinations { get; set; }

    /// <summary>NamespaceResourceBlacklist contains list of blacklisted namespace level resources</summary>
    [JsonPropertyName("namespaceResourceBlacklist")]
    public IList<V1alpha1AppProjectSpecNamespaceResourceBlacklist>? NamespaceResourceBlacklist { get; set; }

    /// <summary>NamespaceResourceWhitelist contains list of whitelisted namespace level resources</summary>
    [JsonPropertyName("namespaceResourceWhitelist")]
    public IList<V1alpha1AppProjectSpecNamespaceResourceWhitelist>? NamespaceResourceWhitelist { get; set; }

    /// <summary>OrphanedResources specifies if controller should monitor orphaned resources of apps in this project</summary>
    [JsonPropertyName("orphanedResources")]
    public V1alpha1AppProjectSpecOrphanedResources? OrphanedResources { get; set; }

    /// <summary>PermitOnlyProjectScopedClusters determines whether destinations can only reference clusters which are project-scoped</summary>
    [JsonPropertyName("permitOnlyProjectScopedClusters")]
    public bool? PermitOnlyProjectScopedClusters { get; set; }

    /// <summary>Roles are user defined RBAC roles associated with this project</summary>
    [JsonPropertyName("roles")]
    public IList<V1alpha1AppProjectSpecRoles>? Roles { get; set; }

    /// <summary>SignatureKeys contains a list of PGP key IDs that commits in Git must be signed with in order to be allowed for sync</summary>
    [JsonPropertyName("signatureKeys")]
    public IList<V1alpha1AppProjectSpecSignatureKeys>? SignatureKeys { get; set; }

    /// <summary>SourceNamespaces defines the namespaces application resources are allowed to be created in</summary>
    [JsonPropertyName("sourceNamespaces")]
    public IList<string>? SourceNamespaces { get; set; }

    /// <summary>SourceRepos contains list of repository URLs which can be used for deployment</summary>
    [JsonPropertyName("sourceRepos")]
    public IList<string>? SourceRepos { get; set; }

    /// <summary>SyncWindows controls when syncs can be run for apps in this project</summary>
    [JsonPropertyName("syncWindows")]
    public IList<V1alpha1AppProjectSpecSyncWindows>? SyncWindows { get; set; }
}

/// <summary>JWTToken holds the issuedAt and expiresAt values of a token</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppProjectStatusJwtTokensByRoleItems
{
    /// <summary></summary>
    [JsonPropertyName("exp")]
    public long? Exp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iat")]
    public long Iat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>JWTTokens represents a list of JWT tokens</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppProjectStatusJwtTokensByRole
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1alpha1AppProjectStatusJwtTokensByRoleItems>? Items { get; set; }
}

/// <summary>AppProjectStatus contains status information for AppProject CRs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppProjectStatus
{
    /// <summary>JWTTokensByRole contains a list of JWT tokens issued for a given role</summary>
    [JsonPropertyName("jwtTokensByRole")]
    public IDictionary<string, V1alpha1AppProjectStatusJwtTokensByRole>? JwtTokensByRole { get; set; }
}

/// <summary>AppProject provides a logical grouping of applications, providing controls for: * where the apps may deploy to (cluster whitelist) * what may be deployed (repository whitelist, resource whitelist/blacklist) * who can access these applications (roles, OIDC group claims bindings) * and what they can do (RBAC policies) * automation access to these roles (JWT tokens)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AppProject : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AppProjectSpec>, IStatus<V1alpha1AppProjectStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AppProject";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "appprojects";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AppProjectSpec is the specification of an AppProject</summary>
    [JsonPropertyName("spec")]
    public V1alpha1AppProjectSpec Spec { get; set; }

    /// <summary>AppProjectStatus contains status information for AppProject CRs</summary>
    [JsonPropertyName("status")]
    public V1alpha1AppProjectStatus? Status { get; set; }
}

/// <summary>AppProject provides a logical grouping of applications, providing controls for: * where the apps may deploy to (cluster whitelist) * what may be deployed (repository whitelist, resource whitelist/blacklist) * who can access these applications (roles, OIDC group claims bindings) * and what they can do (RBAC policies) * automation access to these roles (JWT tokens)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AppProjectList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AppProject>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AppProjectList";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "appprojects";
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
    public IList<V1alpha1AppProject> Items { get; set; }
}