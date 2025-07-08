using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datastream.cnrm.cloud.google.com;
/// <summary>BigQuery Connection Profile configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileSpecBigQueryProfile
{
}

/// <summary>The Kubernetes Secret object that stores the "username" and "password" information for the SSH tunnel. The Secret type has to be `kubernetes.io/basic-auth`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileSpecForwardSSHConnectivitySecretRef
{
    /// <summary>The `metadata.name` field of a Kubernetes `Secret`</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The `metadata.namespace` field of a Kubernetes `Secret`.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Forward SSH tunnel connectivity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileSpecForwardSSHConnectivity
{
    /// <summary>Required. Hostname for the SSH tunnel.</summary>
    [JsonPropertyName("hostname")]
    public string Hostname { get; set; }

    /// <summary>Port for the SSH tunnel, default value is 22.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Input only. SSH private key.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }

    /// <summary>The Kubernetes Secret object that stores the "username" and "password" information for the SSH tunnel. The Secret type has to be `kubernetes.io/basic-auth`.</summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1DatastreamConnectionProfileSpecForwardSSHConnectivitySecretRef SecretRef { get; set; }
}

/// <summary>Cloud Storage ConnectionProfile configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileSpecGcsProfile
{
    /// <summary>Required. The Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucket")]
    public string Bucket { get; set; }

    /// <summary>The root path inside the Cloud Storage bucket.</summary>
    [JsonPropertyName("rootPath")]
    public string? RootPath { get; set; }
}

/// <summary>The Kubernetes Secret object that stores the "username" and "password" information for the MySQL connection. The Secret type has to be `kubernetes.io/basic-auth`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileSpecMySQLProfileSecretRef
{
    /// <summary>The `metadata.name` field of a Kubernetes `Secret`</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The `metadata.namespace` field of a Kubernetes `Secret`.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>SSL configuration for the MySQL connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileSpecMySQLProfileSslConfig
{
    /// <summary>Input only. PEM-encoded certificate of the CA that signed the source database server's certificate.</summary>
    [JsonPropertyName("caCertificate")]
    public string? CaCertificate { get; set; }

    /// <summary>Input only. PEM-encoded certificate that will be used by the replica to authenticate against the source database server. If this field is used then the 'client_key' and the 'ca_certificate' fields are mandatory.</summary>
    [JsonPropertyName("clientCertificate")]
    public string? ClientCertificate { get; set; }

    /// <summary>Input only. PEM-encoded private key associated with the Client Certificate. If this field is used then the 'client_certificate' and the 'ca_certificate' fields are mandatory.</summary>
    [JsonPropertyName("clientKey")]
    public string? ClientKey { get; set; }
}

/// <summary>MySQL ConnectionProfile configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileSpecMySQLProfile
{
    /// <summary>Required. Hostname for the MySQL connection.</summary>
    [JsonPropertyName("hostname")]
    public string Hostname { get; set; }

    /// <summary>Port for the MySQL connection, default value is 3306.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>The Kubernetes Secret object that stores the "username" and "password" information for the MySQL connection. The Secret type has to be `kubernetes.io/basic-auth`.</summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1DatastreamConnectionProfileSpecMySQLProfileSecretRef SecretRef { get; set; }

    /// <summary>SSL configuration for the MySQL connection.</summary>
    [JsonPropertyName("sslConfig")]
    public V1alpha1DatastreamConnectionProfileSpecMySQLProfileSslConfig? SslConfig { get; set; }
}

/// <summary>Optional. SSL configuration for the Oracle connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileSpecOracleProfileOracleASMConfigOracleSSLConfig
{
    /// <summary>Input only. PEM-encoded certificate of the CA that signed the source database server's certificate.</summary>
    [JsonPropertyName("caCertificate")]
    public string? CaCertificate { get; set; }
}

/// <summary>The Kubernetes Secret object that stores the "username" and "password" information for the Oracle ASM connection. The Secret type has to be `kubernetes.io/basic-auth`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileSpecOracleProfileOracleASMConfigSecretRef
{
    /// <summary>The `metadata.name` field of a Kubernetes `Secret`</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The `metadata.namespace` field of a Kubernetes `Secret`.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Configuration for Oracle ASM connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileSpecOracleProfileOracleASMConfig
{
    /// <summary>Required. ASM service name for the Oracle ASM connection.</summary>
    [JsonPropertyName("asmService")]
    public string AsmService { get; set; }

    /// <summary>Optional. Connection string attributes</summary>
    [JsonPropertyName("connectionAttributes")]
    public IDictionary<string, string>? ConnectionAttributes { get; set; }

    /// <summary>Required. Hostname for the Oracle ASM connection.</summary>
    [JsonPropertyName("hostname")]
    public string Hostname { get; set; }

    /// <summary>Optional. SSL configuration for the Oracle connection.</summary>
    [JsonPropertyName("oracleSSLConfig")]
    public V1alpha1DatastreamConnectionProfileSpecOracleProfileOracleASMConfigOracleSSLConfig? OracleSSLConfig { get; set; }

    /// <summary>Required. Port for the Oracle ASM connection.</summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>The Kubernetes Secret object that stores the "username" and "password" information for the Oracle ASM connection. The Secret type has to be `kubernetes.io/basic-auth`.</summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1DatastreamConnectionProfileSpecOracleProfileOracleASMConfigSecretRef SecretRef { get; set; }
}

/// <summary>Optional. SSL configuration for the Oracle connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileSpecOracleProfileOracleSSLConfig
{
    /// <summary>Input only. PEM-encoded certificate of the CA that signed the source database server's certificate.</summary>
    [JsonPropertyName("caCertificate")]
    public string? CaCertificate { get; set; }
}

/// <summary>Optional. A reference to a Secret Manager resource name storing the Oracle connection password. Mutually exclusive with the `secretRef` field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileSpecOracleProfileSecretManagerSecretRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecret` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecret` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The Kubernetes Secret object that stores the "username" and "password" information for the Oracle connection. The Secret type has to be `kubernetes.io/basic-auth`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileSpecOracleProfileSecretRef
{
    /// <summary>The `metadata.name` field of a Kubernetes `Secret`</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The `metadata.namespace` field of a Kubernetes `Secret`.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Oracle ConnectionProfile configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileSpecOracleProfile
{
    /// <summary>Connection string attributes</summary>
    [JsonPropertyName("connectionAttributes")]
    public IDictionary<string, string>? ConnectionAttributes { get; set; }

    /// <summary>Required. Database for the Oracle connection.</summary>
    [JsonPropertyName("databaseService")]
    public string DatabaseService { get; set; }

    /// <summary>Required. Hostname for the Oracle connection.</summary>
    [JsonPropertyName("hostname")]
    public string Hostname { get; set; }

    /// <summary>Optional. Configuration for Oracle ASM connection.</summary>
    [JsonPropertyName("oracleASMConfig")]
    public V1alpha1DatastreamConnectionProfileSpecOracleProfileOracleASMConfig? OracleASMConfig { get; set; }

    /// <summary>Optional. SSL configuration for the Oracle connection.</summary>
    [JsonPropertyName("oracleSSLConfig")]
    public V1alpha1DatastreamConnectionProfileSpecOracleProfileOracleSSLConfig? OracleSSLConfig { get; set; }

    /// <summary>Port for the Oracle connection, default value is 1521.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Optional. A reference to a Secret Manager resource name storing the Oracle connection password. Mutually exclusive with the `secretRef` field.</summary>
    [JsonPropertyName("secretManagerSecretRef")]
    public V1alpha1DatastreamConnectionProfileSpecOracleProfileSecretManagerSecretRef? SecretManagerSecretRef { get; set; }

    /// <summary>The Kubernetes Secret object that stores the "username" and "password" information for the Oracle connection. The Secret type has to be `kubernetes.io/basic-auth`.</summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1DatastreamConnectionProfileSpecOracleProfileSecretRef SecretRef { get; set; }
}

/// <summary>Required. A reference to a private connection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileSpecPrivateConnectivityPrivateConnectionRef
{
    /// <summary>A reference to an externally managed DatastreamPrivateConnection resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/privateConnections/{{privateconnectionID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DatastreamPrivateConnection resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DatastreamPrivateConnection resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Private connectivity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileSpecPrivateConnectivity
{
    /// <summary>Required. A reference to a private connection resource.</summary>
    [JsonPropertyName("privateConnectionRef")]
    public V1alpha1DatastreamConnectionProfileSpecPrivateConnectivityPrivateConnectionRef PrivateConnectionRef { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileSpecProjectRef
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

/// <summary>The Kubernetes Secret object that stores the "username" and "password" information for the SQLServer connection. The Secret type has to be `kubernetes.io/basic-auth`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileSpecSqlServerProfileSecretRef
{
    /// <summary>The `metadata.name` field of a Kubernetes `Secret`</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The `metadata.namespace` field of a Kubernetes `Secret`.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>SQLServer Connection Profile configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileSpecSqlServerProfile
{
    /// <summary>Required. Database for the SQLServer connection.</summary>
    [JsonPropertyName("database")]
    public string Database { get; set; }

    /// <summary>Required. Hostname for the SQLServer connection.</summary>
    [JsonPropertyName("hostname")]
    public string Hostname { get; set; }

    /// <summary>Port for the SQLServer connection, default value is 1433.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>The Kubernetes Secret object that stores the "username" and "password" information for the SQLServer connection. The Secret type has to be `kubernetes.io/basic-auth`.</summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1DatastreamConnectionProfileSpecSqlServerProfileSecretRef SecretRef { get; set; }
}

/// <summary>Static Service IP connectivity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileSpecStaticServiceIPConnectivity
{
}

/// <summary>DatastreamConnectionProfileSpec defines the desired state of DatastreamConnectionProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileSpec
{
    /// <summary>BigQuery Connection Profile configuration.</summary>
    [JsonPropertyName("bigQueryProfile")]
    public V1alpha1DatastreamConnectionProfileSpecBigQueryProfile? BigQueryProfile { get; set; }

    /// <summary>Required. Display name.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>Forward SSH tunnel connectivity.</summary>
    [JsonPropertyName("forwardSSHConnectivity")]
    public V1alpha1DatastreamConnectionProfileSpecForwardSSHConnectivity? ForwardSSHConnectivity { get; set; }

    /// <summary>Cloud Storage ConnectionProfile configuration.</summary>
    [JsonPropertyName("gcsProfile")]
    public V1alpha1DatastreamConnectionProfileSpecGcsProfile? GcsProfile { get; set; }

    /// <summary>Labels.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>MySQL ConnectionProfile configuration.</summary>
    [JsonPropertyName("mySQLProfile")]
    public V1alpha1DatastreamConnectionProfileSpecMySQLProfile? MySQLProfile { get; set; }

    /// <summary>Oracle ConnectionProfile configuration.</summary>
    [JsonPropertyName("oracleProfile")]
    public V1alpha1DatastreamConnectionProfileSpecOracleProfile? OracleProfile { get; set; }

    /// <summary>Private connectivity.</summary>
    [JsonPropertyName("privateConnectivity")]
    public V1alpha1DatastreamConnectionProfileSpecPrivateConnectivity? PrivateConnectivity { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1DatastreamConnectionProfileSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DatastreamConnectionProfile name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>SQLServer Connection Profile configuration.</summary>
    [JsonPropertyName("sqlServerProfile")]
    public V1alpha1DatastreamConnectionProfileSpecSqlServerProfile? SqlServerProfile { get; set; }

    /// <summary>Static Service IP connectivity.</summary>
    [JsonPropertyName("staticServiceIPConnectivity")]
    public V1alpha1DatastreamConnectionProfileSpecStaticServiceIPConnectivity? StaticServiceIPConnectivity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>SSL configuration for the MySQL connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileStatusObservedStateMySQLProfileSslConfig
{
    /// <summary>Output only. Indicates whether the ca_certificate field is set.</summary>
    [JsonPropertyName("caCertificateSet")]
    public bool? CaCertificateSet { get; set; }

    /// <summary>Output only. Indicates whether the client_certificate field is set.</summary>
    [JsonPropertyName("clientCertificateSet")]
    public bool? ClientCertificateSet { get; set; }

    /// <summary>Output only. Indicates whether the client_key field is set.</summary>
    [JsonPropertyName("clientKeySet")]
    public bool? ClientKeySet { get; set; }
}

/// <summary>MySQL ConnectionProfile configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileStatusObservedStateMySQLProfile
{
    /// <summary>SSL configuration for the MySQL connection.</summary>
    [JsonPropertyName("sslConfig")]
    public V1alpha1DatastreamConnectionProfileStatusObservedStateMySQLProfileSslConfig? SslConfig { get; set; }
}

/// <summary>Optional. SSL configuration for the Oracle connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileStatusObservedStateOracleProfileOracleSSLConfig
{
    /// <summary>Output only. Indicates whether the ca_certificate field has been set for this Connection-Profile.</summary>
    [JsonPropertyName("caCertificateSet")]
    public bool? CaCertificateSet { get; set; }
}

/// <summary>Oracle ConnectionProfile configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileStatusObservedStateOracleProfile
{
    /// <summary>Optional. SSL configuration for the Oracle connection.</summary>
    [JsonPropertyName("oracleSSLConfig")]
    public V1alpha1DatastreamConnectionProfileStatusObservedStateOracleProfileOracleSSLConfig? OracleSSLConfig { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileStatusObservedState
{
    /// <summary>Output only. The create time of the resource.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>MySQL ConnectionProfile configuration.</summary>
    [JsonPropertyName("mySQLProfile")]
    public V1alpha1DatastreamConnectionProfileStatusObservedStateMySQLProfile? MySQLProfile { get; set; }

    /// <summary>Oracle ConnectionProfile configuration.</summary>
    [JsonPropertyName("oracleProfile")]
    public V1alpha1DatastreamConnectionProfileStatusObservedStateOracleProfile? OracleProfile { get; set; }

    /// <summary>Output only. The update time of the resource.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>DatastreamConnectionProfileStatus defines the config connector machine state of DatastreamConnectionProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamConnectionProfileStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DatastreamConnectionProfileStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DatastreamConnectionProfile resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DatastreamConnectionProfileStatusObservedState? ObservedState { get; set; }
}

/// <summary>DatastreamConnectionProfile is the Schema for the DatastreamConnectionProfile API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

    /// <summary>DatastreamConnectionProfileSpec defines the desired state of DatastreamConnectionProfile</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DatastreamConnectionProfileSpec Spec { get; set; }

    /// <summary>DatastreamConnectionProfileStatus defines the config connector machine state of DatastreamConnectionProfile</summary>
    [JsonPropertyName("status")]
    public V1alpha1DatastreamConnectionProfileStatus? Status { get; set; }
}

/// <summary>DatastreamConnectionProfile is the Schema for the DatastreamConnectionProfile API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DatastreamConnectionProfileList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DatastreamConnectionProfile>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DatastreamConnectionProfileList";
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
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1alpha1DatastreamConnectionProfile> Items { get; set; }
}