using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datastream.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileMetadata
{
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecForwardSshConnectivityPasswordValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecForwardSshConnectivityPasswordValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public DatastreamConnectionProfileSpecForwardSshConnectivityPasswordValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>Immutable. SSH password.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecForwardSshConnectivityPassword
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public DatastreamConnectionProfileSpecForwardSshConnectivityPasswordValueFrom? ValueFrom { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecForwardSshConnectivityPrivateKeyValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecForwardSshConnectivityPrivateKeyValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public DatastreamConnectionProfileSpecForwardSshConnectivityPrivateKeyValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>Immutable. SSH private key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecForwardSshConnectivityPrivateKey
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public DatastreamConnectionProfileSpecForwardSshConnectivityPrivateKeyValueFrom? ValueFrom { get; set; }
}

/// <summary>Forward SSH tunnel connectivity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecForwardSshConnectivity
{
    /// <summary>Hostname for the SSH tunnel.</summary>
    [JsonPropertyName("hostname")]
    public string Hostname { get; set; }

    /// <summary>Immutable. SSH password.</summary>
    [JsonPropertyName("password")]
    public DatastreamConnectionProfileSpecForwardSshConnectivityPassword? Password { get; set; }

    /// <summary>Port for the SSH tunnel.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Immutable. SSH private key.</summary>
    [JsonPropertyName("privateKey")]
    public DatastreamConnectionProfileSpecForwardSshConnectivityPrivateKey? PrivateKey { get; set; }

    /// <summary>Username for the SSH tunnel.</summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }
}

/// <summary>Cloud Storage bucket profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecGcsProfile
{
    /// <summary>The Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucket")]
    public string Bucket { get; set; }

    /// <summary>The root path inside the Cloud Storage bucket.</summary>
    [JsonPropertyName("rootPath")]
    public string? RootPath { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecMysqlProfilePasswordValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecMysqlProfilePasswordValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public DatastreamConnectionProfileSpecMysqlProfilePasswordValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>Password for the MySQL connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecMysqlProfilePassword
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public DatastreamConnectionProfileSpecMysqlProfilePasswordValueFrom? ValueFrom { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecMysqlProfileSslConfigCaCertificateValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecMysqlProfileSslConfigCaCertificateValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public DatastreamConnectionProfileSpecMysqlProfileSslConfigCaCertificateValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>Immutable. PEM-encoded certificate of the CA that signed the source database server's certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecMysqlProfileSslConfigCaCertificate
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public DatastreamConnectionProfileSpecMysqlProfileSslConfigCaCertificateValueFrom? ValueFrom { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecMysqlProfileSslConfigClientCertificateValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecMysqlProfileSslConfigClientCertificateValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public DatastreamConnectionProfileSpecMysqlProfileSslConfigClientCertificateValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>Immutable. PEM-encoded certificate that will be used by the replica to authenticate against the source database server. If this field is used then the 'clientKey' and the 'caCertificate' fields are mandatory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecMysqlProfileSslConfigClientCertificate
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public DatastreamConnectionProfileSpecMysqlProfileSslConfigClientCertificateValueFrom? ValueFrom { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecMysqlProfileSslConfigClientKeyValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecMysqlProfileSslConfigClientKeyValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public DatastreamConnectionProfileSpecMysqlProfileSslConfigClientKeyValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>Immutable. PEM-encoded private key associated with the Client Certificate. If this field is used then the 'client_certificate' and the 'ca_certificate' fields are mandatory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecMysqlProfileSslConfigClientKey
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public DatastreamConnectionProfileSpecMysqlProfileSslConfigClientKeyValueFrom? ValueFrom { get; set; }
}

/// <summary>SSL configuration for the MySQL connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecMysqlProfileSslConfig
{
    /// <summary>Immutable. PEM-encoded certificate of the CA that signed the source database server's certificate.</summary>
    [JsonPropertyName("caCertificate")]
    public DatastreamConnectionProfileSpecMysqlProfileSslConfigCaCertificate? CaCertificate { get; set; }

    /// <summary>Indicates whether the clientKey field is set.</summary>
    [JsonPropertyName("caCertificateSet")]
    public bool? CaCertificateSet { get; set; }

    /// <summary>Immutable. PEM-encoded certificate that will be used by the replica to authenticate against the source database server. If this field is used then the 'clientKey' and the 'caCertificate' fields are mandatory.</summary>
    [JsonPropertyName("clientCertificate")]
    public DatastreamConnectionProfileSpecMysqlProfileSslConfigClientCertificate? ClientCertificate { get; set; }

    /// <summary>Indicates whether the clientCertificate field is set.</summary>
    [JsonPropertyName("clientCertificateSet")]
    public bool? ClientCertificateSet { get; set; }

    /// <summary>Immutable. PEM-encoded private key associated with the Client Certificate. If this field is used then the 'client_certificate' and the 'ca_certificate' fields are mandatory.</summary>
    [JsonPropertyName("clientKey")]
    public DatastreamConnectionProfileSpecMysqlProfileSslConfigClientKey? ClientKey { get; set; }

    /// <summary>Indicates whether the clientKey field is set.</summary>
    [JsonPropertyName("clientKeySet")]
    public bool? ClientKeySet { get; set; }
}

/// <summary>MySQL database profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecMysqlProfile
{
    /// <summary>Hostname for the MySQL connection.</summary>
    [JsonPropertyName("hostname")]
    public string Hostname { get; set; }

    /// <summary>Password for the MySQL connection.</summary>
    [JsonPropertyName("password")]
    public DatastreamConnectionProfileSpecMysqlProfilePassword Password { get; set; }

    /// <summary>Port for the MySQL connection.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>SSL configuration for the MySQL connection.</summary>
    [JsonPropertyName("sslConfig")]
    public DatastreamConnectionProfileSpecMysqlProfileSslConfig? SslConfig { get; set; }

    /// <summary>Username for the MySQL connection.</summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecOracleProfilePasswordValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecOracleProfilePasswordValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public DatastreamConnectionProfileSpecOracleProfilePasswordValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>Password for the Oracle connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecOracleProfilePassword
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public DatastreamConnectionProfileSpecOracleProfilePasswordValueFrom? ValueFrom { get; set; }
}

/// <summary>Oracle database profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecOracleProfile
{
    /// <summary>Connection string attributes.</summary>
    [JsonPropertyName("connectionAttributes")]
    public IDictionary<string, string>? ConnectionAttributes { get; set; }

    /// <summary>Database for the Oracle connection.</summary>
    [JsonPropertyName("databaseService")]
    public string DatabaseService { get; set; }

    /// <summary>Hostname for the Oracle connection.</summary>
    [JsonPropertyName("hostname")]
    public string Hostname { get; set; }

    /// <summary>Password for the Oracle connection.</summary>
    [JsonPropertyName("password")]
    public DatastreamConnectionProfileSpecOracleProfilePassword Password { get; set; }

    /// <summary>Port for the Oracle connection.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Username for the Oracle connection.</summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecPostgresqlProfilePasswordValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecPostgresqlProfilePasswordValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public DatastreamConnectionProfileSpecPostgresqlProfilePasswordValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>Password for the PostgreSQL connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecPostgresqlProfilePassword
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public DatastreamConnectionProfileSpecPostgresqlProfilePasswordValueFrom? ValueFrom { get; set; }
}

/// <summary>PostgreSQL database profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecPostgresqlProfile
{
    /// <summary>Database for the PostgreSQL connection.</summary>
    [JsonPropertyName("database")]
    public string Database { get; set; }

    /// <summary>Hostname for the PostgreSQL connection.</summary>
    [JsonPropertyName("hostname")]
    public string Hostname { get; set; }

    /// <summary>Password for the PostgreSQL connection.</summary>
    [JsonPropertyName("password")]
    public DatastreamConnectionProfileSpecPostgresqlProfilePassword Password { get; set; }

    /// <summary>Port for the PostgreSQL connection.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Username for the PostgreSQL connection.</summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }
}

/// <summary>Private connectivity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecPrivateConnectivity
{
    /// <summary>A reference to a private connection resource. Format: 'projects/{project}/locations/{location}/privateConnections/{name}'.</summary>
    [JsonPropertyName("privateConnection")]
    public string PrivateConnection { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpecProjectRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileSpec
{
    /// <summary>BigQuery warehouse profile.</summary>
    [JsonPropertyName("bigqueryProfile")]
    public JsonNode? BigqueryProfile { get; set; }

    /// <summary>Display name.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>Forward SSH tunnel connectivity.</summary>
    [JsonPropertyName("forwardSshConnectivity")]
    public DatastreamConnectionProfileSpecForwardSshConnectivity? ForwardSshConnectivity { get; set; }

    /// <summary>Cloud Storage bucket profile.</summary>
    [JsonPropertyName("gcsProfile")]
    public DatastreamConnectionProfileSpecGcsProfile? GcsProfile { get; set; }

    /// <summary>Immutable. The name of the location this connection profile is located in.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>MySQL database profile.</summary>
    [JsonPropertyName("mysqlProfile")]
    public DatastreamConnectionProfileSpecMysqlProfile? MysqlProfile { get; set; }

    /// <summary>Oracle database profile.</summary>
    [JsonPropertyName("oracleProfile")]
    public DatastreamConnectionProfileSpecOracleProfile? OracleProfile { get; set; }

    /// <summary>PostgreSQL database profile.</summary>
    [JsonPropertyName("postgresqlProfile")]
    public DatastreamConnectionProfileSpecPostgresqlProfile? PostgresqlProfile { get; set; }

    /// <summary>Private connectivity.</summary>
    [JsonPropertyName("privateConnectivity")]
    public DatastreamConnectionProfileSpecPrivateConnectivity? PrivateConnectivity { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public DatastreamConnectionProfileSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The connectionProfileId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfileStatusConditions
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
public partial class DatastreamConnectionProfileStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<DatastreamConnectionProfileStatusConditions>? Conditions { get; set; }

    /// <summary>The resource's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamConnectionProfile
{
    /// <summary>apiVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public DatastreamConnectionProfileMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public DatastreamConnectionProfileSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public DatastreamConnectionProfileStatus? Status { get; set; }
}