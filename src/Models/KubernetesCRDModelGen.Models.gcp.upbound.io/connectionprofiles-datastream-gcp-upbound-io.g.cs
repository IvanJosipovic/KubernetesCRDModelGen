using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datastream.gcp.upbound.io;
public enum V1beta1ConnectionProfileSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileSpecForProviderBigqueryProfile
{
}

/// <summary>SSH password. Note: This property is sensitive and will not be displayed in the plan.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderForwardSshConnectivityPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SSH private key. Note: This property is sensitive and will not be displayed in the plan.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderForwardSshConnectivityPrivateKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileSpecForProviderForwardSshConnectivity
{
    /// <summary>Hostname for the SSH tunnel.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>SSH password. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1ConnectionProfileSpecForProviderForwardSshConnectivityPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>Port for the SSH tunnel.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>SSH private key. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1beta1ConnectionProfileSpecForProviderForwardSshConnectivityPrivateKeySecretRef? PrivateKeySecretRef { get; set; }

    /// <summary>Username for the SSH tunnel.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileSpecForProviderGcsProfile
{
    /// <summary>The Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The root path inside the Cloud Storage bucket.</summary>
    [JsonPropertyName("rootPath")]
    public string? RootPath { get; set; }
}

/// <summary>Password for the MySQL connection. Note: This property is sensitive and will not be displayed in the plan.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderMysqlProfilePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>PEM-encoded certificate of the CA that signed the source database server's certificate. Note: This property is sensitive and will not be displayed in the plan.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderMysqlProfileSslConfigCaCertificateSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>PEM-encoded certificate that will be used by the replica to authenticate against the source database server. If this field is used then the 'clientKey' and the 'caCertificate' fields are mandatory. Note: This property is sensitive and will not be displayed in the plan.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderMysqlProfileSslConfigClientCertificateSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>PEM-encoded private key associated with the Client Certificate. If this field is used then the 'client_certificate' and the 'ca_certificate' fields are mandatory. Note: This property is sensitive and will not be displayed in the plan.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderMysqlProfileSslConfigClientKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileSpecForProviderMysqlProfileSslConfig
{
    /// <summary>PEM-encoded certificate of the CA that signed the source database server's certificate. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("caCertificateSecretRef")]
    public V1beta1ConnectionProfileSpecForProviderMysqlProfileSslConfigCaCertificateSecretRef? CaCertificateSecretRef { get; set; }

    /// <summary>PEM-encoded certificate that will be used by the replica to authenticate against the source database server. If this field is used then the 'clientKey' and the 'caCertificate' fields are mandatory. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("clientCertificateSecretRef")]
    public V1beta1ConnectionProfileSpecForProviderMysqlProfileSslConfigClientCertificateSecretRef? ClientCertificateSecretRef { get; set; }

    /// <summary>PEM-encoded private key associated with the Client Certificate. If this field is used then the 'client_certificate' and the 'ca_certificate' fields are mandatory. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("clientKeySecretRef")]
    public V1beta1ConnectionProfileSpecForProviderMysqlProfileSslConfigClientKeySecretRef? ClientKeySecretRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileSpecForProviderMysqlProfile
{
    /// <summary>Hostname for the MySQL connection.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Password for the MySQL connection. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1ConnectionProfileSpecForProviderMysqlProfilePasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>Port for the MySQL connection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>SSL configuration for the MySQL connection. Structure is documented below.</summary>
    [JsonPropertyName("sslConfig")]
    public IList<V1beta1ConnectionProfileSpecForProviderMysqlProfileSslConfig>? SslConfig { get; set; }

    /// <summary>Username for the MySQL connection.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Password for the Oracle connection. Note: This property is sensitive and will not be displayed in the plan.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderOracleProfilePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileSpecForProviderOracleProfile
{
    /// <summary>Connection string attributes</summary>
    [JsonPropertyName("connectionAttributes")]
    public IDictionary<string, string>? ConnectionAttributes { get; set; }

    /// <summary>Database for the Oracle connection.</summary>
    [JsonPropertyName("databaseService")]
    public string? DatabaseService { get; set; }

    /// <summary>Hostname for the Oracle connection.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Password for the Oracle connection. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1ConnectionProfileSpecForProviderOracleProfilePasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>Port for the Oracle connection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Username for the Oracle connection.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public enum V1beta1ConnectionProfileSpecForProviderPostgresqlProfileDatabaseRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecForProviderPostgresqlProfileDatabaseRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderPostgresqlProfileDatabaseRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderPostgresqlProfileDatabaseRefPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileDatabaseRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderPostgresqlProfileDatabaseRefPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileDatabaseRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Database in sql to populate database.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderPostgresqlProfileDatabaseRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileDatabaseRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectionProfileSpecForProviderPostgresqlProfileDatabaseSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecForProviderPostgresqlProfileDatabaseSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderPostgresqlProfileDatabaseSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderPostgresqlProfileDatabaseSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileDatabaseSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderPostgresqlProfileDatabaseSelectorPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileDatabaseSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Database in sql to populate database.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderPostgresqlProfileDatabaseSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileDatabaseSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ConnectionProfileSpecForProviderPostgresqlProfileHostnameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecForProviderPostgresqlProfileHostnameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderPostgresqlProfileHostnameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderPostgresqlProfileHostnameRefPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileHostnameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderPostgresqlProfileHostnameRefPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileHostnameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DatabaseInstance in sql to populate hostname.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderPostgresqlProfileHostnameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileHostnameRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectionProfileSpecForProviderPostgresqlProfileHostnameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecForProviderPostgresqlProfileHostnameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderPostgresqlProfileHostnameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderPostgresqlProfileHostnameSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileHostnameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderPostgresqlProfileHostnameSelectorPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileHostnameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DatabaseInstance in sql to populate hostname.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderPostgresqlProfileHostnameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileHostnameSelectorPolicy? Policy { get; set; }
}

/// <summary>Password for the PostgreSQL connection. Note: This property is sensitive and will not be displayed in the plan.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderPostgresqlProfilePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public enum V1beta1ConnectionProfileSpecForProviderPostgresqlProfileUsernameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecForProviderPostgresqlProfileUsernameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderPostgresqlProfileUsernameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderPostgresqlProfileUsernameRefPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileUsernameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderPostgresqlProfileUsernameRefPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileUsernameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a User in sql to populate username.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderPostgresqlProfileUsernameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileUsernameRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectionProfileSpecForProviderPostgresqlProfileUsernameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecForProviderPostgresqlProfileUsernameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderPostgresqlProfileUsernameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderPostgresqlProfileUsernameSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileUsernameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderPostgresqlProfileUsernameSelectorPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileUsernameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a User in sql to populate username.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderPostgresqlProfileUsernameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileUsernameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileSpecForProviderPostgresqlProfile
{
    /// <summary>Database for the PostgreSQL connection.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Reference to a Database in sql to populate database.</summary>
    [JsonPropertyName("databaseRef")]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileDatabaseRef? DatabaseRef { get; set; }

    /// <summary>Selector for a Database in sql to populate database.</summary>
    [JsonPropertyName("databaseSelector")]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileDatabaseSelector? DatabaseSelector { get; set; }

    /// <summary>Hostname for the PostgreSQL connection.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Reference to a DatabaseInstance in sql to populate hostname.</summary>
    [JsonPropertyName("hostnameRef")]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileHostnameRef? HostnameRef { get; set; }

    /// <summary>Selector for a DatabaseInstance in sql to populate hostname.</summary>
    [JsonPropertyName("hostnameSelector")]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileHostnameSelector? HostnameSelector { get; set; }

    /// <summary>Password for the PostgreSQL connection. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfilePasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>Port for the PostgreSQL connection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Username for the PostgreSQL connection.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>Reference to a User in sql to populate username.</summary>
    [JsonPropertyName("usernameRef")]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileUsernameRef? UsernameRef { get; set; }

    /// <summary>Selector for a User in sql to populate username.</summary>
    [JsonPropertyName("usernameSelector")]
    public V1beta1ConnectionProfileSpecForProviderPostgresqlProfileUsernameSelector? UsernameSelector { get; set; }
}

public enum V1beta1ConnectionProfileSpecForProviderPrivateConnectivityPrivateConnectionRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecForProviderPrivateConnectivityPrivateConnectionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderPrivateConnectivityPrivateConnectionRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderPrivateConnectivityPrivateConnectionRefPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecForProviderPrivateConnectivityPrivateConnectionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderPrivateConnectivityPrivateConnectionRefPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecForProviderPrivateConnectivityPrivateConnectionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a PrivateConnection in datastream to populate privateConnection.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderPrivateConnectivityPrivateConnectionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecForProviderPrivateConnectivityPrivateConnectionRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectionProfileSpecForProviderPrivateConnectivityPrivateConnectionSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecForProviderPrivateConnectivityPrivateConnectionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderPrivateConnectivityPrivateConnectionSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderPrivateConnectivityPrivateConnectionSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecForProviderPrivateConnectivityPrivateConnectionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderPrivateConnectivityPrivateConnectionSelectorPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecForProviderPrivateConnectivityPrivateConnectionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a PrivateConnection in datastream to populate privateConnection.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderPrivateConnectivityPrivateConnectionSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecForProviderPrivateConnectivityPrivateConnectionSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileSpecForProviderPrivateConnectivity
{
    /// <summary>A reference to a private connection resource. Format: projects/{project}/locations/{location}/privateConnections/{name}</summary>
    [JsonPropertyName("privateConnection")]
    public string? PrivateConnection { get; set; }

    /// <summary>Reference to a PrivateConnection in datastream to populate privateConnection.</summary>
    [JsonPropertyName("privateConnectionRef")]
    public V1beta1ConnectionProfileSpecForProviderPrivateConnectivityPrivateConnectionRef? PrivateConnectionRef { get; set; }

    /// <summary>Selector for a PrivateConnection in datastream to populate privateConnection.</summary>
    [JsonPropertyName("privateConnectionSelector")]
    public V1beta1ConnectionProfileSpecForProviderPrivateConnectivityPrivateConnectionSelector? PrivateConnectionSelector { get; set; }
}

public enum V1beta1ConnectionProfileSpecForProviderSqlServerProfileDatabaseRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecForProviderSqlServerProfileDatabaseRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderSqlServerProfileDatabaseRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderSqlServerProfileDatabaseRefPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileDatabaseRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderSqlServerProfileDatabaseRefPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileDatabaseRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Database in sql to populate database.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderSqlServerProfileDatabaseRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileDatabaseRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectionProfileSpecForProviderSqlServerProfileDatabaseSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecForProviderSqlServerProfileDatabaseSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderSqlServerProfileDatabaseSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderSqlServerProfileDatabaseSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileDatabaseSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderSqlServerProfileDatabaseSelectorPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileDatabaseSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Database in sql to populate database.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderSqlServerProfileDatabaseSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileDatabaseSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ConnectionProfileSpecForProviderSqlServerProfileHostnameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecForProviderSqlServerProfileHostnameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderSqlServerProfileHostnameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderSqlServerProfileHostnameRefPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileHostnameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderSqlServerProfileHostnameRefPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileHostnameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DatabaseInstance in sql to populate hostname.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderSqlServerProfileHostnameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileHostnameRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectionProfileSpecForProviderSqlServerProfileHostnameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecForProviderSqlServerProfileHostnameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderSqlServerProfileHostnameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderSqlServerProfileHostnameSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileHostnameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderSqlServerProfileHostnameSelectorPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileHostnameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DatabaseInstance in sql to populate hostname.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderSqlServerProfileHostnameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileHostnameSelectorPolicy? Policy { get; set; }
}

/// <summary>Password for the SQL Server connection. Note: This property is sensitive and will not be displayed in the plan.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderSqlServerProfilePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public enum V1beta1ConnectionProfileSpecForProviderSqlServerProfileUsernameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecForProviderSqlServerProfileUsernameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderSqlServerProfileUsernameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderSqlServerProfileUsernameRefPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileUsernameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderSqlServerProfileUsernameRefPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileUsernameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a User in sql to populate username.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderSqlServerProfileUsernameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileUsernameRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectionProfileSpecForProviderSqlServerProfileUsernameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecForProviderSqlServerProfileUsernameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderSqlServerProfileUsernameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderSqlServerProfileUsernameSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileUsernameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecForProviderSqlServerProfileUsernameSelectorPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileUsernameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a User in sql to populate username.</summary>
public partial class V1beta1ConnectionProfileSpecForProviderSqlServerProfileUsernameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileUsernameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileSpecForProviderSqlServerProfile
{
    /// <summary>Database for the SQL Server connection.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Reference to a Database in sql to populate database.</summary>
    [JsonPropertyName("databaseRef")]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileDatabaseRef? DatabaseRef { get; set; }

    /// <summary>Selector for a Database in sql to populate database.</summary>
    [JsonPropertyName("databaseSelector")]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileDatabaseSelector? DatabaseSelector { get; set; }

    /// <summary>Hostname for the SQL Server connection.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Reference to a DatabaseInstance in sql to populate hostname.</summary>
    [JsonPropertyName("hostnameRef")]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileHostnameRef? HostnameRef { get; set; }

    /// <summary>Selector for a DatabaseInstance in sql to populate hostname.</summary>
    [JsonPropertyName("hostnameSelector")]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileHostnameSelector? HostnameSelector { get; set; }

    /// <summary>Password for the SQL Server connection. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfilePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>Port for the SQL Server connection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Username for the SQL Server connection.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>Reference to a User in sql to populate username.</summary>
    [JsonPropertyName("usernameRef")]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileUsernameRef? UsernameRef { get; set; }

    /// <summary>Selector for a User in sql to populate username.</summary>
    [JsonPropertyName("usernameSelector")]
    public V1beta1ConnectionProfileSpecForProviderSqlServerProfileUsernameSelector? UsernameSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileSpecForProvider
{
    /// <summary>BigQuery warehouse profile.</summary>
    [JsonPropertyName("bigqueryProfile")]
    public IList<V1beta1ConnectionProfileSpecForProviderBigqueryProfile>? BigqueryProfile { get; set; }

    /// <summary>Create the connection profile without validating it.</summary>
    [JsonPropertyName("createWithoutValidation")]
    public bool? CreateWithoutValidation { get; set; }

    /// <summary>Display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Forward SSH tunnel connectivity. Structure is documented below.</summary>
    [JsonPropertyName("forwardSshConnectivity")]
    public IList<V1beta1ConnectionProfileSpecForProviderForwardSshConnectivity>? ForwardSshConnectivity { get; set; }

    /// <summary>Cloud Storage bucket profile. Structure is documented below.</summary>
    [JsonPropertyName("gcsProfile")]
    public IList<V1beta1ConnectionProfileSpecForProviderGcsProfile>? GcsProfile { get; set; }

    /// <summary>Labels. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The name of the location this connection profile is located in.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>MySQL database profile. Structure is documented below.</summary>
    [JsonPropertyName("mysqlProfile")]
    public IList<V1beta1ConnectionProfileSpecForProviderMysqlProfile>? MysqlProfile { get; set; }

    /// <summary>Oracle database profile. Structure is documented below.</summary>
    [JsonPropertyName("oracleProfile")]
    public IList<V1beta1ConnectionProfileSpecForProviderOracleProfile>? OracleProfile { get; set; }

    /// <summary>PostgreSQL database profile. Structure is documented below.</summary>
    [JsonPropertyName("postgresqlProfile")]
    public IList<V1beta1ConnectionProfileSpecForProviderPostgresqlProfile>? PostgresqlProfile { get; set; }

    /// <summary>Private connectivity. Structure is documented below.</summary>
    [JsonPropertyName("privateConnectivity")]
    public IList<V1beta1ConnectionProfileSpecForProviderPrivateConnectivity>? PrivateConnectivity { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>SQL Server database profile. Structure is documented below.</summary>
    [JsonPropertyName("sqlServerProfile")]
    public IList<V1beta1ConnectionProfileSpecForProviderSqlServerProfile>? SqlServerProfile { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileSpecInitProviderBigqueryProfile
{
}

/// <summary>SSH password. Note: This property is sensitive and will not be displayed in the plan.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderForwardSshConnectivityPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SSH private key. Note: This property is sensitive and will not be displayed in the plan.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderForwardSshConnectivityPrivateKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileSpecInitProviderForwardSshConnectivity
{
    /// <summary>Hostname for the SSH tunnel.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>SSH password. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1ConnectionProfileSpecInitProviderForwardSshConnectivityPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>Port for the SSH tunnel.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>SSH private key. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1beta1ConnectionProfileSpecInitProviderForwardSshConnectivityPrivateKeySecretRef? PrivateKeySecretRef { get; set; }

    /// <summary>Username for the SSH tunnel.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileSpecInitProviderGcsProfile
{
    /// <summary>The Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The root path inside the Cloud Storage bucket.</summary>
    [JsonPropertyName("rootPath")]
    public string? RootPath { get; set; }
}

/// <summary>PEM-encoded certificate of the CA that signed the source database server's certificate. Note: This property is sensitive and will not be displayed in the plan.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderMysqlProfileSslConfigCaCertificateSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>PEM-encoded certificate that will be used by the replica to authenticate against the source database server. If this field is used then the 'clientKey' and the 'caCertificate' fields are mandatory. Note: This property is sensitive and will not be displayed in the plan.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderMysqlProfileSslConfigClientCertificateSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>PEM-encoded private key associated with the Client Certificate. If this field is used then the 'client_certificate' and the 'ca_certificate' fields are mandatory. Note: This property is sensitive and will not be displayed in the plan.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderMysqlProfileSslConfigClientKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileSpecInitProviderMysqlProfileSslConfig
{
    /// <summary>PEM-encoded certificate of the CA that signed the source database server's certificate. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("caCertificateSecretRef")]
    public V1beta1ConnectionProfileSpecInitProviderMysqlProfileSslConfigCaCertificateSecretRef? CaCertificateSecretRef { get; set; }

    /// <summary>PEM-encoded certificate that will be used by the replica to authenticate against the source database server. If this field is used then the 'clientKey' and the 'caCertificate' fields are mandatory. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("clientCertificateSecretRef")]
    public V1beta1ConnectionProfileSpecInitProviderMysqlProfileSslConfigClientCertificateSecretRef? ClientCertificateSecretRef { get; set; }

    /// <summary>PEM-encoded private key associated with the Client Certificate. If this field is used then the 'client_certificate' and the 'ca_certificate' fields are mandatory. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("clientKeySecretRef")]
    public V1beta1ConnectionProfileSpecInitProviderMysqlProfileSslConfigClientKeySecretRef? ClientKeySecretRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileSpecInitProviderMysqlProfile
{
    /// <summary>Hostname for the MySQL connection.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Port for the MySQL connection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>SSL configuration for the MySQL connection. Structure is documented below.</summary>
    [JsonPropertyName("sslConfig")]
    public IList<V1beta1ConnectionProfileSpecInitProviderMysqlProfileSslConfig>? SslConfig { get; set; }

    /// <summary>Username for the MySQL connection.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileSpecInitProviderOracleProfile
{
    /// <summary>Connection string attributes</summary>
    [JsonPropertyName("connectionAttributes")]
    public IDictionary<string, string>? ConnectionAttributes { get; set; }

    /// <summary>Database for the Oracle connection.</summary>
    [JsonPropertyName("databaseService")]
    public string? DatabaseService { get; set; }

    /// <summary>Hostname for the Oracle connection.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Port for the Oracle connection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Username for the Oracle connection.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public enum V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileDatabaseRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileDatabaseRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileDatabaseRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileDatabaseRefPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileDatabaseRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileDatabaseRefPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileDatabaseRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Database in sql to populate database.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileDatabaseRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileDatabaseRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileDatabaseSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileDatabaseSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileDatabaseSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileDatabaseSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileDatabaseSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileDatabaseSelectorPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileDatabaseSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Database in sql to populate database.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileDatabaseSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileDatabaseSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileHostnameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileHostnameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileHostnameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileHostnameRefPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileHostnameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileHostnameRefPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileHostnameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DatabaseInstance in sql to populate hostname.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileHostnameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileHostnameRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileHostnameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileHostnameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileHostnameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileHostnameSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileHostnameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileHostnameSelectorPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileHostnameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DatabaseInstance in sql to populate hostname.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileHostnameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileHostnameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileUsernameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileUsernameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileUsernameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileUsernameRefPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileUsernameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileUsernameRefPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileUsernameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a User in sql to populate username.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileUsernameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileUsernameRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileUsernameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileUsernameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileUsernameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileUsernameSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileUsernameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileUsernameSelectorPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileUsernameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a User in sql to populate username.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileUsernameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileUsernameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileSpecInitProviderPostgresqlProfile
{
    /// <summary>Database for the PostgreSQL connection.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Reference to a Database in sql to populate database.</summary>
    [JsonPropertyName("databaseRef")]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileDatabaseRef? DatabaseRef { get; set; }

    /// <summary>Selector for a Database in sql to populate database.</summary>
    [JsonPropertyName("databaseSelector")]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileDatabaseSelector? DatabaseSelector { get; set; }

    /// <summary>Hostname for the PostgreSQL connection.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Reference to a DatabaseInstance in sql to populate hostname.</summary>
    [JsonPropertyName("hostnameRef")]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileHostnameRef? HostnameRef { get; set; }

    /// <summary>Selector for a DatabaseInstance in sql to populate hostname.</summary>
    [JsonPropertyName("hostnameSelector")]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileHostnameSelector? HostnameSelector { get; set; }

    /// <summary>Port for the PostgreSQL connection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Username for the PostgreSQL connection.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>Reference to a User in sql to populate username.</summary>
    [JsonPropertyName("usernameRef")]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileUsernameRef? UsernameRef { get; set; }

    /// <summary>Selector for a User in sql to populate username.</summary>
    [JsonPropertyName("usernameSelector")]
    public V1beta1ConnectionProfileSpecInitProviderPostgresqlProfileUsernameSelector? UsernameSelector { get; set; }
}

public enum V1beta1ConnectionProfileSpecInitProviderPrivateConnectivityPrivateConnectionRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecInitProviderPrivateConnectivityPrivateConnectionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderPrivateConnectivityPrivateConnectionRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderPrivateConnectivityPrivateConnectionRefPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderPrivateConnectivityPrivateConnectionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderPrivateConnectivityPrivateConnectionRefPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderPrivateConnectivityPrivateConnectionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a PrivateConnection in datastream to populate privateConnection.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderPrivateConnectivityPrivateConnectionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecInitProviderPrivateConnectivityPrivateConnectionRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectionProfileSpecInitProviderPrivateConnectivityPrivateConnectionSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecInitProviderPrivateConnectivityPrivateConnectionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderPrivateConnectivityPrivateConnectionSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderPrivateConnectivityPrivateConnectionSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderPrivateConnectivityPrivateConnectionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderPrivateConnectivityPrivateConnectionSelectorPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderPrivateConnectivityPrivateConnectionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a PrivateConnection in datastream to populate privateConnection.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderPrivateConnectivityPrivateConnectionSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecInitProviderPrivateConnectivityPrivateConnectionSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileSpecInitProviderPrivateConnectivity
{
    /// <summary>A reference to a private connection resource. Format: projects/{project}/locations/{location}/privateConnections/{name}</summary>
    [JsonPropertyName("privateConnection")]
    public string? PrivateConnection { get; set; }

    /// <summary>Reference to a PrivateConnection in datastream to populate privateConnection.</summary>
    [JsonPropertyName("privateConnectionRef")]
    public V1beta1ConnectionProfileSpecInitProviderPrivateConnectivityPrivateConnectionRef? PrivateConnectionRef { get; set; }

    /// <summary>Selector for a PrivateConnection in datastream to populate privateConnection.</summary>
    [JsonPropertyName("privateConnectionSelector")]
    public V1beta1ConnectionProfileSpecInitProviderPrivateConnectivityPrivateConnectionSelector? PrivateConnectionSelector { get; set; }
}

public enum V1beta1ConnectionProfileSpecInitProviderSqlServerProfileDatabaseRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecInitProviderSqlServerProfileDatabaseRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderSqlServerProfileDatabaseRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderSqlServerProfileDatabaseRefPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileDatabaseRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderSqlServerProfileDatabaseRefPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileDatabaseRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Database in sql to populate database.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderSqlServerProfileDatabaseRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileDatabaseRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectionProfileSpecInitProviderSqlServerProfileDatabaseSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecInitProviderSqlServerProfileDatabaseSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderSqlServerProfileDatabaseSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderSqlServerProfileDatabaseSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileDatabaseSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderSqlServerProfileDatabaseSelectorPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileDatabaseSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Database in sql to populate database.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderSqlServerProfileDatabaseSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileDatabaseSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ConnectionProfileSpecInitProviderSqlServerProfileHostnameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecInitProviderSqlServerProfileHostnameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderSqlServerProfileHostnameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderSqlServerProfileHostnameRefPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileHostnameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderSqlServerProfileHostnameRefPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileHostnameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DatabaseInstance in sql to populate hostname.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderSqlServerProfileHostnameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileHostnameRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectionProfileSpecInitProviderSqlServerProfileHostnameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecInitProviderSqlServerProfileHostnameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderSqlServerProfileHostnameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderSqlServerProfileHostnameSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileHostnameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderSqlServerProfileHostnameSelectorPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileHostnameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DatabaseInstance in sql to populate hostname.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderSqlServerProfileHostnameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileHostnameSelectorPolicy? Policy { get; set; }
}

/// <summary>Password for the SQL Server connection. Note: This property is sensitive and will not be displayed in the plan.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderSqlServerProfilePasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public enum V1beta1ConnectionProfileSpecInitProviderSqlServerProfileUsernameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecInitProviderSqlServerProfileUsernameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderSqlServerProfileUsernameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderSqlServerProfileUsernameRefPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileUsernameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderSqlServerProfileUsernameRefPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileUsernameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a User in sql to populate username.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderSqlServerProfileUsernameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileUsernameRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectionProfileSpecInitProviderSqlServerProfileUsernameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecInitProviderSqlServerProfileUsernameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderSqlServerProfileUsernameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderSqlServerProfileUsernameSelectorPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileUsernameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecInitProviderSqlServerProfileUsernameSelectorPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileUsernameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a User in sql to populate username.</summary>
public partial class V1beta1ConnectionProfileSpecInitProviderSqlServerProfileUsernameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileUsernameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileSpecInitProviderSqlServerProfile
{
    /// <summary>Database for the SQL Server connection.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Reference to a Database in sql to populate database.</summary>
    [JsonPropertyName("databaseRef")]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileDatabaseRef? DatabaseRef { get; set; }

    /// <summary>Selector for a Database in sql to populate database.</summary>
    [JsonPropertyName("databaseSelector")]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileDatabaseSelector? DatabaseSelector { get; set; }

    /// <summary>Hostname for the SQL Server connection.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Reference to a DatabaseInstance in sql to populate hostname.</summary>
    [JsonPropertyName("hostnameRef")]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileHostnameRef? HostnameRef { get; set; }

    /// <summary>Selector for a DatabaseInstance in sql to populate hostname.</summary>
    [JsonPropertyName("hostnameSelector")]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileHostnameSelector? HostnameSelector { get; set; }

    /// <summary>Password for the SQL Server connection. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfilePasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>Port for the SQL Server connection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Username for the SQL Server connection.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>Reference to a User in sql to populate username.</summary>
    [JsonPropertyName("usernameRef")]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileUsernameRef? UsernameRef { get; set; }

    /// <summary>Selector for a User in sql to populate username.</summary>
    [JsonPropertyName("usernameSelector")]
    public V1beta1ConnectionProfileSpecInitProviderSqlServerProfileUsernameSelector? UsernameSelector { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1ConnectionProfileSpecInitProvider
{
    /// <summary>BigQuery warehouse profile.</summary>
    [JsonPropertyName("bigqueryProfile")]
    public IList<V1beta1ConnectionProfileSpecInitProviderBigqueryProfile>? BigqueryProfile { get; set; }

    /// <summary>Create the connection profile without validating it.</summary>
    [JsonPropertyName("createWithoutValidation")]
    public bool? CreateWithoutValidation { get; set; }

    /// <summary>Display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Forward SSH tunnel connectivity. Structure is documented below.</summary>
    [JsonPropertyName("forwardSshConnectivity")]
    public IList<V1beta1ConnectionProfileSpecInitProviderForwardSshConnectivity>? ForwardSshConnectivity { get; set; }

    /// <summary>Cloud Storage bucket profile. Structure is documented below.</summary>
    [JsonPropertyName("gcsProfile")]
    public IList<V1beta1ConnectionProfileSpecInitProviderGcsProfile>? GcsProfile { get; set; }

    /// <summary>Labels. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>MySQL database profile. Structure is documented below.</summary>
    [JsonPropertyName("mysqlProfile")]
    public IList<V1beta1ConnectionProfileSpecInitProviderMysqlProfile>? MysqlProfile { get; set; }

    /// <summary>Oracle database profile. Structure is documented below.</summary>
    [JsonPropertyName("oracleProfile")]
    public IList<V1beta1ConnectionProfileSpecInitProviderOracleProfile>? OracleProfile { get; set; }

    /// <summary>PostgreSQL database profile. Structure is documented below.</summary>
    [JsonPropertyName("postgresqlProfile")]
    public IList<V1beta1ConnectionProfileSpecInitProviderPostgresqlProfile>? PostgresqlProfile { get; set; }

    /// <summary>Private connectivity. Structure is documented below.</summary>
    [JsonPropertyName("privateConnectivity")]
    public IList<V1beta1ConnectionProfileSpecInitProviderPrivateConnectivity>? PrivateConnectivity { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>SQL Server database profile. Structure is documented below.</summary>
    [JsonPropertyName("sqlServerProfile")]
    public IList<V1beta1ConnectionProfileSpecInitProviderSqlServerProfile>? SqlServerProfile { get; set; }
}

public enum V1beta1ConnectionProfileSpecManagementPoliciesEnum
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

public enum V1beta1ConnectionProfileSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ConnectionProfileSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1ConnectionProfileSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1ConnectionProfileSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConnectionProfileSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ConnectionProfileSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ConnectionProfileSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ConnectionProfileSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1ConnectionProfileSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionProfileSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1ConnectionProfileSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ConnectionProfileSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ConnectionProfileSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ConnectionProfileSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1ConnectionProfileSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ConnectionProfileSpec defines the desired state of ConnectionProfile</summary>
public partial class V1beta1ConnectionProfileSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectionProfileSpecDeletionPolicyEnum>))]
    public V1beta1ConnectionProfileSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ConnectionProfileSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ConnectionProfileSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ConnectionProfileSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ConnectionProfileSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ConnectionProfileSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ConnectionProfileSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileStatusAtProviderBigqueryProfile
{
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileStatusAtProviderForwardSshConnectivity
{
    /// <summary>Hostname for the SSH tunnel.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Port for the SSH tunnel.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Username for the SSH tunnel.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileStatusAtProviderGcsProfile
{
    /// <summary>The Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The root path inside the Cloud Storage bucket.</summary>
    [JsonPropertyName("rootPath")]
    public string? RootPath { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileStatusAtProviderMysqlProfileSslConfig
{
    /// <summary>(Output) Indicates whether the clientKey field is set.</summary>
    [JsonPropertyName("caCertificateSet")]
    public bool? CaCertificateSet { get; set; }

    /// <summary>(Output) Indicates whether the clientCertificate field is set.</summary>
    [JsonPropertyName("clientCertificateSet")]
    public bool? ClientCertificateSet { get; set; }

    /// <summary>(Output) Indicates whether the clientKey field is set.</summary>
    [JsonPropertyName("clientKeySet")]
    public bool? ClientKeySet { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileStatusAtProviderMysqlProfile
{
    /// <summary>Hostname for the MySQL connection.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Port for the MySQL connection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>SSL configuration for the MySQL connection. Structure is documented below.</summary>
    [JsonPropertyName("sslConfig")]
    public IList<V1beta1ConnectionProfileStatusAtProviderMysqlProfileSslConfig>? SslConfig { get; set; }

    /// <summary>Username for the MySQL connection.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileStatusAtProviderOracleProfile
{
    /// <summary>Connection string attributes</summary>
    [JsonPropertyName("connectionAttributes")]
    public IDictionary<string, string>? ConnectionAttributes { get; set; }

    /// <summary>Database for the Oracle connection.</summary>
    [JsonPropertyName("databaseService")]
    public string? DatabaseService { get; set; }

    /// <summary>Hostname for the Oracle connection.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Port for the Oracle connection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Username for the Oracle connection.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileStatusAtProviderPostgresqlProfile
{
    /// <summary>Database for the PostgreSQL connection.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Hostname for the PostgreSQL connection.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Port for the PostgreSQL connection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Username for the PostgreSQL connection.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileStatusAtProviderPrivateConnectivity
{
    /// <summary>A reference to a private connection resource. Format: projects/{project}/locations/{location}/privateConnections/{name}</summary>
    [JsonPropertyName("privateConnection")]
    public string? PrivateConnection { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileStatusAtProviderSqlServerProfile
{
    /// <summary>Database for the SQL Server connection.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Hostname for the SQL Server connection.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Port for the SQL Server connection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Username for the SQL Server connection.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConnectionProfileStatusAtProvider
{
    /// <summary>BigQuery warehouse profile.</summary>
    [JsonPropertyName("bigqueryProfile")]
    public IList<V1beta1ConnectionProfileStatusAtProviderBigqueryProfile>? BigqueryProfile { get; set; }

    /// <summary>Create the connection profile without validating it.</summary>
    [JsonPropertyName("createWithoutValidation")]
    public bool? CreateWithoutValidation { get; set; }

    /// <summary>Display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>Forward SSH tunnel connectivity. Structure is documented below.</summary>
    [JsonPropertyName("forwardSshConnectivity")]
    public IList<V1beta1ConnectionProfileStatusAtProviderForwardSshConnectivity>? ForwardSshConnectivity { get; set; }

    /// <summary>Cloud Storage bucket profile. Structure is documented below.</summary>
    [JsonPropertyName("gcsProfile")]
    public IList<V1beta1ConnectionProfileStatusAtProviderGcsProfile>? GcsProfile { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/connectionProfiles/{{connection_profile_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Labels. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The name of the location this connection profile is located in.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MySQL database profile. Structure is documented below.</summary>
    [JsonPropertyName("mysqlProfile")]
    public IList<V1beta1ConnectionProfileStatusAtProviderMysqlProfile>? MysqlProfile { get; set; }

    /// <summary>The resource's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Oracle database profile. Structure is documented below.</summary>
    [JsonPropertyName("oracleProfile")]
    public IList<V1beta1ConnectionProfileStatusAtProviderOracleProfile>? OracleProfile { get; set; }

    /// <summary>PostgreSQL database profile. Structure is documented below.</summary>
    [JsonPropertyName("postgresqlProfile")]
    public IList<V1beta1ConnectionProfileStatusAtProviderPostgresqlProfile>? PostgresqlProfile { get; set; }

    /// <summary>Private connectivity. Structure is documented below.</summary>
    [JsonPropertyName("privateConnectivity")]
    public IList<V1beta1ConnectionProfileStatusAtProviderPrivateConnectivity>? PrivateConnectivity { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>SQL Server database profile. Structure is documented below.</summary>
    [JsonPropertyName("sqlServerProfile")]
    public IList<V1beta1ConnectionProfileStatusAtProviderSqlServerProfile>? SqlServerProfile { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1ConnectionProfileStatusConditions
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

/// <summary>ConnectionProfileStatus defines the observed state of ConnectionProfile.</summary>
public partial class V1beta1ConnectionProfileStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ConnectionProfileStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ConnectionProfileStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>ConnectionProfile is the Schema for the ConnectionProfiles API. A set of reusable connection configurations to be used as a source or destination for a stream.</summary>
public partial class V1beta1ConnectionProfile : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ConnectionProfileSpec>, IStatus<V1beta1ConnectionProfileStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ConnectionProfile";
    public const string KubeGroup = "datastream.gcp.upbound.io";
    public const string KubePluralName = "connectionprofiles";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConnectionProfileSpec defines the desired state of ConnectionProfile</summary>
    [JsonPropertyName("spec")]
    public V1beta1ConnectionProfileSpec Spec { get; set; }

    /// <summary>ConnectionProfileStatus defines the observed state of ConnectionProfile.</summary>
    [JsonPropertyName("status")]
    public V1beta1ConnectionProfileStatus? Status { get; set; }
}