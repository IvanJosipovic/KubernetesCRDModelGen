using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dbforpostgresql.azure.com;
/// <summary>Password is the password to use for the user</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1UserSpecLocalUserPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ServerAdminPassword is a reference to a secret containing the servers administrator password</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1UserSpecLocalUserServerAdminPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>LocalUser contains details for creating a standard (non-aad) postgresql User</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1UserSpecLocalUser
{
    /// <summary>Password is the password to use for the user</summary>
    [JsonPropertyName("password")]
    public V1UserSpecLocalUserPassword Password { get; set; }

    /// <summary>ServerAdminPassword is a reference to a secret containing the servers administrator password</summary>
    [JsonPropertyName("serverAdminPassword")]
    public V1UserSpecLocalUserServerAdminPassword ServerAdminPassword { get; set; }

    /// <summary>ServerAdminUsername is the user name of the Server administrator</summary>
    [JsonPropertyName("serverAdminUsername")]
    public string ServerAdminUsername { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a dbforpostgresql.azure.com/FlexibleServer resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1UserSpecOwner
{
    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The with options of the user role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1UserSpecRoleOptions
{
    /// <summary>WITH CREATEDB or NOCREATEDB</summary>
    [JsonPropertyName("createDb")]
    public bool? CreateDb { get; set; }

    /// <summary>WITH CREATEROLE or NOCREATEROLE</summary>
    [JsonPropertyName("createRole")]
    public bool? CreateRole { get; set; }

    /// <summary>WITH LOGIN or NOLOGIN</summary>
    [JsonPropertyName("login")]
    public bool? Login { get; set; }

    /// <summary>WITH REPLICATION or NOREPLICATION</summary>
    [JsonPropertyName("replication")]
    public bool? Replication { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1UserSpec
{
    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>LocalUser contains details for creating a standard (non-aad) postgresql User</summary>
    [JsonPropertyName("localUser")]
    public V1UserSpecLocalUser LocalUser { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a dbforpostgresql.azure.com/FlexibleServer resource</summary>
    [JsonPropertyName("owner")]
    public V1UserSpecOwner Owner { get; set; }

    /// <summary>The with options of the user role.</summary>
    [JsonPropertyName("roleOptions")]
    public V1UserSpecRoleOptions? RoleOptions { get; set; }

    /// <summary>The Azure Database for PostgreSQL server is created with the 3 default roles defined. azure_pg_admin azure_superuser your server admin user</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1UserStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason for the condition's last transition. Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False. This is omitted in all cases when Status == Unknown</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1UserStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1UserStatusConditions>? Conditions { get; set; }
}

/// <summary>User is a postgresql user</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1User : IKubernetesObject<V1ObjectMeta>, ISpec<V1UserSpec>, IStatus<V1UserStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "User";
    public const string KubeGroup = "dbforpostgresql.azure.com";
    public const string KubePluralName = "users";
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
    public V1UserSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1UserStatus? Status { get; set; }
}