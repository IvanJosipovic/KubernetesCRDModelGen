using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.source.toolkit.fluxcd.io;
/// <summary>NamespaceSelector selects the namespaces to which this ACL applies. An empty map of MatchLabels matches all namespaces in a cluster.</summary>
public partial class V1HelmRepositorySpecAccessFromNamespaceSelectors
{
    /// <summary>MatchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>AccessFrom specifies an Access Control List for allowing cross-namespace references to this object. NOTE: Not implemented, provisional as of https://github.com/fluxcd/flux2/pull/2092</summary>
public partial class V1HelmRepositorySpecAccessFrom
{
    /// <summary>NamespaceSelectors is the list of namespace selectors to which this ACL applies. Items in this list are evaluated using a logical OR operation.</summary>
    [JsonPropertyName("namespaceSelectors")]
    public IList<V1HelmRepositorySpecAccessFromNamespaceSelectors> NamespaceSelectors { get; set; }
}

/// <summary>CertSecretRef can be given the name of a Secret containing either or both of   - a PEM-encoded client certificate (`tls.crt`) and private key (`tls.key`); - a PEM-encoded CA certificate (`ca.crt`)   and whichever are supplied, will be used for connecting to the registry. The client cert and key are useful if you are authenticating with a certificate; the CA cert is useful if you are using a self-signed server certificate. The Secret must be of type `Opaque` or `kubernetes.io/tls`.   It takes precedence over the values specified in the Secret referred to by `.spec.secretRef`.</summary>
public partial class V1HelmRepositorySpecCertSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public enum V1HelmRepositorySpecProviderEnum
{
    [EnumMember(Value = "generic"), JsonStringEnumMemberName("generic")]
    /// <summary>generic</summary>
    Generic,
    [EnumMember(Value = "aws"), JsonStringEnumMemberName("aws")]
    /// <summary>aws</summary>
    Aws,
    [EnumMember(Value = "azure"), JsonStringEnumMemberName("azure")]
    /// <summary>azure</summary>
    Azure,
    [EnumMember(Value = "gcp"), JsonStringEnumMemberName("gcp")]
    /// <summary>gcp</summary>
    Gcp
}

/// <summary>SecretRef specifies the Secret containing authentication credentials for the HelmRepository. For HTTP/S basic auth the secret must contain 'username' and 'password' fields. Support for TLS auth using the 'certFile' and 'keyFile', and/or 'caFile' keys is deprecated. Please use `.spec.certSecretRef` instead.</summary>
public partial class V1HelmRepositorySpecSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public enum V1HelmRepositorySpecTypeEnum
{
    [EnumMember(Value = "default"), JsonStringEnumMemberName("default")]
    /// <summary>default</summary>
    Default,
    [EnumMember(Value = "oci"), JsonStringEnumMemberName("oci")]
    /// <summary>oci</summary>
    Oci
}

/// <summary>HelmRepositorySpec specifies the required configuration to produce an Artifact for a Helm repository index YAML.</summary>
public partial class V1HelmRepositorySpec
{
    /// <summary>AccessFrom specifies an Access Control List for allowing cross-namespace references to this object. NOTE: Not implemented, provisional as of https://github.com/fluxcd/flux2/pull/2092</summary>
    [JsonPropertyName("accessFrom")]
    public V1HelmRepositorySpecAccessFrom? AccessFrom { get; set; }

    /// <summary>CertSecretRef can be given the name of a Secret containing either or both of   - a PEM-encoded client certificate (`tls.crt`) and private key (`tls.key`); - a PEM-encoded CA certificate (`ca.crt`)   and whichever are supplied, will be used for connecting to the registry. The client cert and key are useful if you are authenticating with a certificate; the CA cert is useful if you are using a self-signed server certificate. The Secret must be of type `Opaque` or `kubernetes.io/tls`.   It takes precedence over the values specified in the Secret referred to by `.spec.secretRef`.</summary>
    [JsonPropertyName("certSecretRef")]
    public V1HelmRepositorySpecCertSecretRef? CertSecretRef { get; set; }

    /// <summary>Insecure allows connecting to a non-TLS HTTP container registry. This field is only taken into account if the .spec.type field is set to 'oci'.</summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary>Interval at which the HelmRepository URL is checked for updates. This interval is approximate and may be subject to jitter to ensure efficient use of resources.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>PassCredentials allows the credentials from the SecretRef to be passed on to a host that does not match the host as defined in URL. This may be required if the host of the advertised chart URLs in the index differ from the defined URL. Enabling this should be done with caution, as it can potentially result in credentials getting stolen in a MITM-attack.</summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary>Provider used for authentication, can be 'aws', 'azure', 'gcp' or 'generic'. This field is optional, and only taken into account if the .spec.type field is set to 'oci'. When not specified, defaults to 'generic'.</summary>
    [JsonPropertyName("provider")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1HelmRepositorySpecProviderEnum>))]
    public V1HelmRepositorySpecProviderEnum? Provider { get; set; }

    /// <summary>SecretRef specifies the Secret containing authentication credentials for the HelmRepository. For HTTP/S basic auth the secret must contain 'username' and 'password' fields. Support for TLS auth using the 'certFile' and 'keyFile', and/or 'caFile' keys is deprecated. Please use `.spec.certSecretRef` instead.</summary>
    [JsonPropertyName("secretRef")]
    public V1HelmRepositorySpecSecretRef? SecretRef { get; set; }

    /// <summary>Suspend tells the controller to suspend the reconciliation of this HelmRepository.</summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>Timeout is used for the index fetch operation for an HTTPS helm repository, and for remote OCI Repository operations like pulling for an OCI helm chart by the associated HelmChart. Its default value is 60s.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>Type of the HelmRepository. When this field is set to  "oci", the URL field value must be prefixed with "oci://".</summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1HelmRepositorySpecTypeEnum>))]
    public V1HelmRepositorySpecTypeEnum? Type { get; set; }

    /// <summary>URL of the Helm repository, a valid URL contains at least a protocol and host.</summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

/// <summary>Artifact represents the last successful HelmRepository reconciliation.</summary>
public partial class V1HelmRepositoryStatusArtifact
{
    /// <summary>Digest is the digest of the file in the form of '&lt;algorithm&gt;:&lt;checksum&gt;'.</summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>LastUpdateTime is the timestamp corresponding to the last update of the Artifact.</summary>
    [JsonPropertyName("lastUpdateTime")]
    public string LastUpdateTime { get; set; }

    /// <summary>Metadata holds upstream information such as OCI annotations.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Path is the relative file path of the Artifact. It can be used to locate the file in the root of the Artifact storage on the local file system of the controller managing the Source.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>Revision is a human-readable identifier traceable in the origin source system. It can be a Git commit SHA, Git tag, a Helm chart version, etc.</summary>
    [JsonPropertyName("revision")]
    public string Revision { get; set; }

    /// <summary>Size is the number of bytes in the file.</summary>
    [JsonPropertyName("size")]
    public long? Size { get; set; }

    /// <summary>URL is the HTTP address of the Artifact as exposed by the controller managing the Source. It can be used to retrieve the Artifact for consumption, e.g. by another controller applying the Artifact contents.</summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

public enum V1HelmRepositoryStatusConditionsStatusEnum
{
    [EnumMember(Value = "true"), JsonStringEnumMemberName("true")]
    /// <summary>true</summary>
    True,
    [EnumMember(Value = "false"), JsonStringEnumMemberName("false")]
    /// <summary>false</summary>
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    /// <summary>Unknown</summary>
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource. --- This struct is intended for direct use as an array at the field path .status.conditions.  For example,   	type FooStatus struct{ 	    // Represents the observations of a foo's current state. 	    // Known .status.conditions.type are: "Available", "Progressing", and "Degraded" 	    // +patchMergeKey=type 	    // +patchStrategy=merge 	    // +listType=map 	    // +listMapKey=type 	    Conditions []metav1.Condition `json:"conditions,omitempty" patchStrategy:"merge" patchMergeKey:"type" protobuf:"bytes,1,rep,name=conditions"`   	    // other fields 	}</summary>
public partial class V1HelmRepositoryStatusConditions
{
    /// <summary>lastTransitionTime is the last time the condition transitioned from one status to another. This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>message is a human readable message indicating details about the transition. This may be an empty string.</summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>observedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>reason contains a programmatic identifier indicating the reason for the condition's last transition. Producers of specific condition types may define expected values and meanings for this field, and whether the values are considered a guaranteed API. The value should be a CamelCase string. This field may not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1HelmRepositoryStatusConditionsStatusEnum>))]
    public V1HelmRepositoryStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase. --- Many .condition.type values are consistent across resources like Available, but because arbitrary conditions can be useful (see .node.status.conditions), the ability to deconflict is important. The regex it matches is (dns1123SubdomainFmt/)?(qualifiedNameFmt)</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>HelmRepositoryStatus records the observed state of the HelmRepository.</summary>
public partial class V1HelmRepositoryStatus
{
    /// <summary>Artifact represents the last successful HelmRepository reconciliation.</summary>
    [JsonPropertyName("artifact")]
    public V1HelmRepositoryStatusArtifact? Artifact { get; set; }

    /// <summary>Conditions holds the conditions for the HelmRepository.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1HelmRepositoryStatusConditions>? Conditions { get; set; }

    /// <summary>LastHandledReconcileAt holds the value of the most recent reconcile request value, so a change of the annotation value can be detected.</summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>ObservedGeneration is the last observed generation of the HelmRepository object.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>URL is the dynamic fetch link for the latest Artifact. It is provided on a "best effort" basis, and using the precise HelmRepositoryStatus.Artifact data is recommended.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>HelmRepository is the Schema for the helmrepositories API.</summary>
public partial class V1HelmRepository : IKubernetesObject<V1ObjectMeta>, ISpec<V1HelmRepositorySpec>, IStatus<V1HelmRepositoryStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "HelmRepository";
    public const string KubeGroup = "source.toolkit.fluxcd.io";
    public const string KubePluralName = "helmrepositories";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HelmRepositorySpec specifies the required configuration to produce an Artifact for a Helm repository index YAML.</summary>
    [JsonPropertyName("spec")]
    public V1HelmRepositorySpec? Spec { get; set; }

    /// <summary>HelmRepositoryStatus records the observed state of the HelmRepository.</summary>
    [JsonPropertyName("status")]
    public V1HelmRepositoryStatus? Status { get; set; }
}