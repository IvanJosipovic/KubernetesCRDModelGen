using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.azure.com;
/// <summary>Password is the password to use for the user</summary>
public partial class V1UserSpecLocalUserPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ServerAdminPassword is a reference to a secret containing the servers administrator password.</summary>
public partial class V1UserSpecLocalUserServerAdminPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>LocalUser contains details for creating a standard (non-aad) Azure SQL User</summary>
public partial class V1UserSpecLocalUser
{
    /// <summary>Password is the password to use for the user</summary>
    [JsonPropertyName("password")]
    public V1UserSpecLocalUserPassword Password { get; set; }

    /// <summary>ServerAdminPassword is a reference to a secret containing the servers administrator password.</summary>
    [JsonPropertyName("serverAdminPassword")]
    public V1UserSpecLocalUserServerAdminPassword ServerAdminPassword { get; set; }

    /// <summary>ServerAdminUsername is the username of the Server administrator. If the administrator is a group, the ServerAdminUsername should be the group name, not the actual username of the identity to log in with. For example if the administrator group is "admin-group" and identity "my-identity" is a member of that group, the ServerAdminUsername should be "admin-group".</summary>
    [JsonPropertyName("serverAdminUsername")]
    public string ServerAdminUsername { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to an sql.azure.com/ServersDatabase resource</summary>
public partial class V1UserSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
public partial class V1UserSpec
{
    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be. If not specified, the default is the name of the Kubernetes object. When creating a local user, this will be the name of the user created. When creating an AAD user, this must have a specific format depending on the type of AAD user being created. For managed identity: "my-managed-identity-name" For standard AAD user: "myuser@mydomain.onmicrosoft.com" For AAD group: "my-group"</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>LocalUser contains details for creating a standard (non-aad) Azure SQL User</summary>
    [JsonPropertyName("localUser")]
    public V1UserSpecLocalUser LocalUser { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to an sql.azure.com/ServersDatabase resource</summary>
    [JsonPropertyName("owner")]
    public V1UserSpecOwner Owner { get; set; }

    /// <summary>The roles assigned to the user. See https://learn.microsoft.com/sql/relational-databases/security/authentication-access/database-level-roles?view=sql-server-ver16#fixed-database-roles for the fixed set of roles supported by Azure SQL. Roles include the following: db_owner, db_securityadmin, db_accessadmin, db_backupoperator, db_ddladmin, db_datawriter, db_datareader, db_denydatawriter, and db_denydatareader.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
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
public partial class V1UserStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1UserStatusConditions>? Conditions { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>User is an Azure SQL user</summary>
public partial class V1User : IKubernetesObject<V1ObjectMeta>, ISpec<V1UserSpec>, IStatus<V1UserStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "User";
    public const string KubeGroup = "sql.azure.com";
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