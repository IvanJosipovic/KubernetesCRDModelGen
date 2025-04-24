using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dbformysql.azure.com;
/// <summary>AADUser contains details for creating an AAD user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1UserSpecAadUser
{
    /// <summary>Alias is the short name associated with the user. This is required if the AzureName is longer than 32 characters. Note that Alias denotes the name used to manage the SQL user in MySQL, NOT the name used to log in to the SQL server. When logging in to the SQL server and prompted to provider the username, supply the AzureName.</summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>ServerAdminUsername is the username of the Server administrator. If your server admin was configured with Azure Service Operator, this should match the value of the Administrator's $.spec.login field. If the administrator is a group, the ServerAdminUsername should be the group name, not the actual username of the identity to log in with. For example if the administrator group is "admin-group" and identity "my-identity" is a member of that group, the ServerAdminUsername should be "admin-group"</summary>
    [JsonPropertyName("serverAdminUsername")]
    public string ServerAdminUsername { get; set; }
}

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

/// <summary>ServerAdminPassword is a reference to a secret containing the servers administrator password. If specified, the operator uses the ServerAdminUsername and ServerAdminPassword to log into the server as a local administrator. If NOT specified, the operator uses its identity to log into the server. The operator can only successfully log into the server if its identity is the administrator of the server or if its identity is a member of a group which is the administrator of the server. If the administrator is a group, the ServerAdminUsername should be the group name, not the actual username of the identity to log in with. For example if the administrator group is "admin-group" and identity "my-identity" is a member of that group, the ServerAdminUsername should be "admin-group"</summary>
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

/// <summary>LocalUser contains details for creating a standard (non-aad) MySQL User</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1UserSpecLocalUser
{
    /// <summary>Password is the password to use for the user</summary>
    [JsonPropertyName("password")]
    public V1UserSpecLocalUserPassword Password { get; set; }

    /// <summary>ServerAdminPassword is a reference to a secret containing the servers administrator password. If specified, the operator uses the ServerAdminUsername and ServerAdminPassword to log into the server as a local administrator. If NOT specified, the operator uses its identity to log into the server. The operator can only successfully log into the server if its identity is the administrator of the server or if its identity is a member of a group which is the administrator of the server. If the administrator is a group, the ServerAdminUsername should be the group name, not the actual username of the identity to log in with. For example if the administrator group is "admin-group" and identity "my-identity" is a member of that group, the ServerAdminUsername should be "admin-group"</summary>
    [JsonPropertyName("serverAdminPassword")]
    public V1UserSpecLocalUserServerAdminPassword? ServerAdminPassword { get; set; }

    /// <summary>ServerAdminUsername is the username of the Server administrator. If the administrator is a group, the ServerAdminUsername should be the group name, not the actual username of the identity to log in with. For example if the administrator group is "admin-group" and identity "my-identity" is a member of that group, the ServerAdminUsername should be "admin-group".</summary>
    [JsonPropertyName("serverAdminUsername")]
    public string ServerAdminUsername { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a dbformysql.azure.com/FlexibleServer resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1UserSpecOwner
{
    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1UserSpec
{
    /// <summary>AADUser contains details for creating an AAD user.</summary>
    [JsonPropertyName("aadUser")]
    public V1UserSpecAadUser? AadUser { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be. If not specified, the default is the name of the Kubernetes object. When creating a local user, this will be the name of the user created. When creating an AAD user, this must have a specific format depending on the type of AAD user being created. For managed identity: "my-managed-identity-name" For standard AAD user: "myuser@mydomain.onmicrosoft.com" For AAD group: "my-group"</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>The database-level roles assigned to the user (keyed by database name). Privileges include the following: SELECT, INSERT, UPDATE, DELETE, CREATE, DROP, REFERENCES, INDEX, ALTER, CREATE TEMPORARY TABLES, LOCK TABLES, EXECUTE, CREATE VIEW, SHOW VIEW, CREATE ROUTINE, ALTER ROUTINE, EVENT, TRIGGER</summary>
    [JsonPropertyName("databasePrivileges")]
    public IDictionary<string, IList<string>>? DatabasePrivileges { get; set; }

    /// <summary>Hostname is the host the user will connect from. If omitted, the default is to allow connection from any hostname.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>LocalUser contains details for creating a standard (non-aad) MySQL User</summary>
    [JsonPropertyName("localUser")]
    public V1UserSpecLocalUser? LocalUser { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a dbformysql.azure.com/FlexibleServer resource</summary>
    [JsonPropertyName("owner")]
    public V1UserSpecOwner Owner { get; set; }

    /// <summary>The server-level roles assigned to the user. Privileges include the following: RELOAD, PROCESS, SHOW DATABASES, REPLICATION SLAVE, REPLICATION CLIENT, CREATE USER</summary>
    [JsonPropertyName("privileges")]
    public IList<string>? Privileges { get; set; }
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

/// <summary>User is a MySQL user</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1User : IKubernetesObject<V1ObjectMeta>, ISpec<V1UserSpec>, IStatus<V1UserStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "User";
    public const string KubeGroup = "dbformysql.azure.com";
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

/// <summary>User is a MySQL user</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1UserList : IKubernetesObject<V1ListMeta>, IItems<V1User>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "UserList";
    public const string KubeGroup = "dbformysql.azure.com";
    public const string KubePluralName = "users";
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
    public IList<V1User> Items { get; set; }
}