using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datastream.cnrm.cloud.google.com;
public partial class V1alpha1DatastreamConnectionProfileSpecForwardSshConnectivityPasswordValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecForwardSshConnectivityPasswordValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1DatastreamConnectionProfileSpecForwardSshConnectivityPasswordValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecForwardSshConnectivityPassword
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1DatastreamConnectionProfileSpecForwardSshConnectivityPasswordValueFrom? ValueFrom { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecForwardSshConnectivityPrivateKeyValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecForwardSshConnectivityPrivateKeyValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1DatastreamConnectionProfileSpecForwardSshConnectivityPrivateKeyValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecForwardSshConnectivityPrivateKey
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1DatastreamConnectionProfileSpecForwardSshConnectivityPrivateKeyValueFrom? ValueFrom { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecForwardSshConnectivity
{
    /// <summary>Hostname for the SSH tunnel.</summary>
    [JsonPropertyName("hostname")]
    public string Hostname { get; set; }

    /// <summary>Immutable. SSH password.</summary>
    [JsonPropertyName("password")]
    public V1alpha1DatastreamConnectionProfileSpecForwardSshConnectivityPassword? Password { get; set; }

    /// <summary>Port for the SSH tunnel.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Immutable. SSH private key.</summary>
    [JsonPropertyName("privateKey")]
    public V1alpha1DatastreamConnectionProfileSpecForwardSshConnectivityPrivateKey? PrivateKey { get; set; }

    /// <summary>Username for the SSH tunnel.</summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecGcsProfile
{
    /// <summary>The Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucket")]
    public string Bucket { get; set; }

    /// <summary>The root path inside the Cloud Storage bucket.</summary>
    [JsonPropertyName("rootPath")]
    public string? RootPath { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecMysqlProfilePasswordValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecMysqlProfilePasswordValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1DatastreamConnectionProfileSpecMysqlProfilePasswordValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecMysqlProfilePassword
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1DatastreamConnectionProfileSpecMysqlProfilePasswordValueFrom? ValueFrom { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecMysqlProfileSslConfigCaCertificateValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecMysqlProfileSslConfigCaCertificateValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1DatastreamConnectionProfileSpecMysqlProfileSslConfigCaCertificateValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecMysqlProfileSslConfigCaCertificate
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1DatastreamConnectionProfileSpecMysqlProfileSslConfigCaCertificateValueFrom? ValueFrom { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecMysqlProfileSslConfigClientCertificateValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecMysqlProfileSslConfigClientCertificateValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1DatastreamConnectionProfileSpecMysqlProfileSslConfigClientCertificateValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecMysqlProfileSslConfigClientCertificate
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1DatastreamConnectionProfileSpecMysqlProfileSslConfigClientCertificateValueFrom? ValueFrom { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecMysqlProfileSslConfigClientKeyValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecMysqlProfileSslConfigClientKeyValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1DatastreamConnectionProfileSpecMysqlProfileSslConfigClientKeyValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecMysqlProfileSslConfigClientKey
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1DatastreamConnectionProfileSpecMysqlProfileSslConfigClientKeyValueFrom? ValueFrom { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecMysqlProfileSslConfig
{
    /// <summary>Immutable. PEM-encoded certificate of the CA that signed the source database server's certificate.</summary>
    [JsonPropertyName("caCertificate")]
    public V1alpha1DatastreamConnectionProfileSpecMysqlProfileSslConfigCaCertificate? CaCertificate { get; set; }

    /// <summary>Indicates whether the clientKey field is set.</summary>
    [JsonPropertyName("caCertificateSet")]
    public bool? CaCertificateSet { get; set; }

    /// <summary>Immutable. PEM-encoded certificate that will be used by the replica to authenticate against the source database server. If this field is used then the 'clientKey' and the 'caCertificate' fields are mandatory.</summary>
    [JsonPropertyName("clientCertificate")]
    public V1alpha1DatastreamConnectionProfileSpecMysqlProfileSslConfigClientCertificate? ClientCertificate { get; set; }

    /// <summary>Indicates whether the clientCertificate field is set.</summary>
    [JsonPropertyName("clientCertificateSet")]
    public bool? ClientCertificateSet { get; set; }

    /// <summary>Immutable. PEM-encoded private key associated with the Client Certificate. If this field is used then the 'client_certificate' and the 'ca_certificate' fields are mandatory.</summary>
    [JsonPropertyName("clientKey")]
    public V1alpha1DatastreamConnectionProfileSpecMysqlProfileSslConfigClientKey? ClientKey { get; set; }

    /// <summary>Indicates whether the clientKey field is set.</summary>
    [JsonPropertyName("clientKeySet")]
    public bool? ClientKeySet { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecMysqlProfile
{
    /// <summary>Hostname for the MySQL connection.</summary>
    [JsonPropertyName("hostname")]
    public string Hostname { get; set; }

    /// <summary>Password for the MySQL connection.</summary>
    [JsonPropertyName("password")]
    public V1alpha1DatastreamConnectionProfileSpecMysqlProfilePassword Password { get; set; }

    /// <summary>Port for the MySQL connection.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>SSL configuration for the MySQL connection.</summary>
    [JsonPropertyName("sslConfig")]
    public V1alpha1DatastreamConnectionProfileSpecMysqlProfileSslConfig? SslConfig { get; set; }

    /// <summary>Username for the MySQL connection.</summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecOracleProfilePasswordValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecOracleProfilePasswordValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1DatastreamConnectionProfileSpecOracleProfilePasswordValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecOracleProfilePassword
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1DatastreamConnectionProfileSpecOracleProfilePasswordValueFrom? ValueFrom { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecOracleProfile
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
    public V1alpha1DatastreamConnectionProfileSpecOracleProfilePassword Password { get; set; }

    /// <summary>Port for the Oracle connection.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Username for the Oracle connection.</summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecPostgresqlProfilePasswordValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecPostgresqlProfilePasswordValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1DatastreamConnectionProfileSpecPostgresqlProfilePasswordValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecPostgresqlProfilePassword
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1DatastreamConnectionProfileSpecPostgresqlProfilePasswordValueFrom? ValueFrom { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecPostgresqlProfile
{
    /// <summary>Database for the PostgreSQL connection.</summary>
    [JsonPropertyName("database")]
    public string Database { get; set; }

    /// <summary>Hostname for the PostgreSQL connection.</summary>
    [JsonPropertyName("hostname")]
    public string Hostname { get; set; }

    /// <summary>Password for the PostgreSQL connection.</summary>
    [JsonPropertyName("password")]
    public V1alpha1DatastreamConnectionProfileSpecPostgresqlProfilePassword Password { get; set; }

    /// <summary>Port for the PostgreSQL connection.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Username for the PostgreSQL connection.</summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecPrivateConnectivity
{
    /// <summary>A reference to a private connection resource. Format: 'projects/{project}/locations/{location}/privateConnections/{name}'.</summary>
    [JsonPropertyName("privateConnection")]
    public string PrivateConnection { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileSpecProjectRef
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

public partial class V1alpha1DatastreamConnectionProfileSpec
{
    /// <summary>BigQuery warehouse profile.</summary>
    [JsonPropertyName("bigqueryProfile")]
    public JsonNode? BigqueryProfile { get; set; }

    /// <summary>Display name.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>Forward SSH tunnel connectivity.</summary>
    [JsonPropertyName("forwardSshConnectivity")]
    public V1alpha1DatastreamConnectionProfileSpecForwardSshConnectivity? ForwardSshConnectivity { get; set; }

    /// <summary>Cloud Storage bucket profile.</summary>
    [JsonPropertyName("gcsProfile")]
    public V1alpha1DatastreamConnectionProfileSpecGcsProfile? GcsProfile { get; set; }

    /// <summary>Immutable. The name of the location this connection profile is located in.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>MySQL database profile.</summary>
    [JsonPropertyName("mysqlProfile")]
    public V1alpha1DatastreamConnectionProfileSpecMysqlProfile? MysqlProfile { get; set; }

    /// <summary>Oracle database profile.</summary>
    [JsonPropertyName("oracleProfile")]
    public V1alpha1DatastreamConnectionProfileSpecOracleProfile? OracleProfile { get; set; }

    /// <summary>PostgreSQL database profile.</summary>
    [JsonPropertyName("postgresqlProfile")]
    public V1alpha1DatastreamConnectionProfileSpecPostgresqlProfile? PostgresqlProfile { get; set; }

    /// <summary>Private connectivity.</summary>
    [JsonPropertyName("privateConnectivity")]
    public V1alpha1DatastreamConnectionProfileSpecPrivateConnectivity? PrivateConnectivity { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1DatastreamConnectionProfileSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The connectionProfileId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

public partial class V1alpha1DatastreamConnectionProfileStatusConditions
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

public partial class V1alpha1DatastreamConnectionProfileStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DatastreamConnectionProfileStatusConditions>? Conditions { get; set; }

    /// <summary>The resource's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DatastreamConnectionProfile : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DatastreamConnectionProfileSpec>, IStatus<V1alpha1DatastreamConnectionProfileStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DatastreamConnectionProfile";
    public const string KubeGroup = "datastream.cnrm.cloud.google.com";
    public const string KubePluralName = "datastreamconnectionprofiles";
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
    public V1alpha1DatastreamConnectionProfileSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1DatastreamConnectionProfileStatus? Status { get; set; }
}