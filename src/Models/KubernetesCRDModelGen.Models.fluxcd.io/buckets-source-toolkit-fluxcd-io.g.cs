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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecAccessFromNamespaceSelectors
{
    /// <summary>MatchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>AccessFrom specifies an Access Control List for allowing cross-namespace references to this object. NOTE: Not implemented, provisional as of https://github.com/fluxcd/flux2/pull/2092</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecAccessFrom
{
    /// <summary>NamespaceSelectors is the list of namespace selectors to which this ACL applies. Items in this list are evaluated using a logical OR operation.</summary>
    [JsonPropertyName("namespaceSelectors")]
    public IList<V1beta2BucketSpecAccessFromNamespaceSelectors> NamespaceSelectors { get; set; }
}

/// <summary>SecretRef specifies the Secret containing authentication credentials for the Bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>BucketSpec specifies the required configuration to produce an Artifact for an object storage bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpec
{
    /// <summary>AccessFrom specifies an Access Control List for allowing cross-namespace references to this object. NOTE: Not implemented, provisional as of https://github.com/fluxcd/flux2/pull/2092</summary>
    [JsonPropertyName("accessFrom")]
    public V1beta2BucketSpecAccessFrom? AccessFrom { get; set; }

    /// <summary>BucketName is the name of the object storage bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string BucketName { get; set; }

    /// <summary>Endpoint is the object storage address the BucketName is located at.</summary>
    [JsonPropertyName("endpoint")]
    public string Endpoint { get; set; }

    /// <summary>Ignore overrides the set of excluded patterns in the .sourceignore format (which is the same as .gitignore). If not provided, a default will be used, consult the documentation for your version to find out what those are.</summary>
    [JsonPropertyName("ignore")]
    public string? Ignore { get; set; }

    /// <summary>Insecure allows connecting to a non-TLS HTTP Endpoint.</summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary>Interval at which the Bucket Endpoint is checked for updates. This interval is approximate and may be subject to jitter to ensure efficient use of resources.</summary>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }

    /// <summary>Prefix to use for server-side filtering of files in the Bucket.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Provider of the object storage bucket. Defaults to 'generic', which expects an S3 (API) compatible object storage.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>Region of the Endpoint where the BucketName is located in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>SecretRef specifies the Secret containing authentication credentials for the Bucket.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta2BucketSpecSecretRef? SecretRef { get; set; }

    /// <summary>Suspend tells the controller to suspend the reconciliation of this Bucket.</summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>Timeout for fetch operations, defaults to 60s.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>Artifact represents the last successful Bucket reconciliation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatusArtifact
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

/// <summary>Condition contains details for one aspect of the current state of this API Resource. --- This struct is intended for direct use as an array at the field path .status.conditions.  For example,   	type FooStatus struct{ 	    // Represents the observations of a foo's current state. 	    // Known .status.conditions.type are: "Available", "Progressing", and "Degraded" 	    // +patchMergeKey=type 	    // +patchStrategy=merge 	    // +listType=map 	    // +listMapKey=type 	    Conditions []metav1.Condition `json:"conditions,omitempty" patchStrategy:"merge" patchMergeKey:"type" protobuf:"bytes,1,rep,name=conditions"`   	    // other fields 	}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatusConditions
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
    public string Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase. --- Many .condition.type values are consistent across resources like Available, but because arbitrary conditions can be useful (see .node.status.conditions), the ability to deconflict is important. The regex it matches is (dns1123SubdomainFmt/)?(qualifiedNameFmt)</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>BucketStatus records the observed state of a Bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatus
{
    /// <summary>Artifact represents the last successful Bucket reconciliation.</summary>
    [JsonPropertyName("artifact")]
    public V1beta2BucketStatusArtifact? Artifact { get; set; }

    /// <summary>Conditions holds the conditions for the Bucket.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2BucketStatusConditions>? Conditions { get; set; }

    /// <summary>LastHandledReconcileAt holds the value of the most recent reconcile request value, so a change of the annotation value can be detected.</summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>ObservedGeneration is the last observed generation of the Bucket object.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedIgnore is the observed exclusion patterns used for constructing the source artifact.</summary>
    [JsonPropertyName("observedIgnore")]
    public string? ObservedIgnore { get; set; }

    /// <summary>URL is the dynamic fetch link for the latest Artifact. It is provided on a "best effort" basis, and using the precise BucketStatus.Artifact data is recommended.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Bucket is the Schema for the buckets API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Bucket : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2BucketSpec>, IStatus<V1beta2BucketStatus>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Bucket";
    public const string KubeGroup = "source.toolkit.fluxcd.io";
    public const string KubePluralName = "buckets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BucketSpec specifies the required configuration to produce an Artifact for an object storage bucket.</summary>
    [JsonPropertyName("spec")]
    public V1beta2BucketSpec? Spec { get; set; }

    /// <summary>BucketStatus records the observed state of a Bucket.</summary>
    [JsonPropertyName("status")]
    public V1beta2BucketStatus? Status { get; set; }
}