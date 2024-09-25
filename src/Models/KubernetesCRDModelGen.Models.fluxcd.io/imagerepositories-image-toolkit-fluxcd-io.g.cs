using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.image.toolkit.fluxcd.io;
/// <summary>NamespaceSelector selects the namespaces to which this ACL applies. An empty map of MatchLabels matches all namespaces in a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRepositorySpecAccessFromNamespaceSelectors
{
    /// <summary>MatchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>AccessFrom defines an ACL for allowing cross-namespace references to the ImageRepository object based on the caller's namespace labels.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRepositorySpecAccessFrom
{
    /// <summary>NamespaceSelectors is the list of namespace selectors to which this ACL applies. Items in this list are evaluated using a logical OR operation.</summary>
    [JsonPropertyName("namespaceSelectors")]
    public IList<V1beta2ImageRepositorySpecAccessFromNamespaceSelectors> NamespaceSelectors { get; set; }
}

/// <summary>CertSecretRef can be given the name of a Secret containing either or both of   - a PEM-encoded client certificate (`tls.crt`) and private key (`tls.key`); - a PEM-encoded CA certificate (`ca.crt`)   and whichever are supplied, will be used for connecting to the registry. The client cert and key are useful if you are authenticating with a certificate; the CA cert is useful if you are using a self-signed server certificate. The Secret must be of type `Opaque` or `kubernetes.io/tls`.   Note: Support for the `caFile`, `certFile` and `keyFile` keys has been deprecated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRepositorySpecCertSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The provider used for authentication, can be 'aws', 'azure', 'gcp' or 'generic'. When not specified, defaults to 'generic'.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ImageRepositorySpecProviderEnum
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

/// <summary>SecretRef can be given the name of a secret containing credentials to use for the image registry. The secret should be created with `kubectl create secret docker-registry`, or the equivalent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRepositorySpecSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ImageRepositorySpec defines the parameters for scanning an image repository, e.g., `fluxcd/flux`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRepositorySpec
{
    /// <summary>AccessFrom defines an ACL for allowing cross-namespace references to the ImageRepository object based on the caller's namespace labels.</summary>
    [JsonPropertyName("accessFrom")]
    public V1beta2ImageRepositorySpecAccessFrom? AccessFrom { get; set; }

    /// <summary>CertSecretRef can be given the name of a Secret containing either or both of   - a PEM-encoded client certificate (`tls.crt`) and private key (`tls.key`); - a PEM-encoded CA certificate (`ca.crt`)   and whichever are supplied, will be used for connecting to the registry. The client cert and key are useful if you are authenticating with a certificate; the CA cert is useful if you are using a self-signed server certificate. The Secret must be of type `Opaque` or `kubernetes.io/tls`.   Note: Support for the `caFile`, `certFile` and `keyFile` keys has been deprecated.</summary>
    [JsonPropertyName("certSecretRef")]
    public V1beta2ImageRepositorySpecCertSecretRef? CertSecretRef { get; set; }

    /// <summary>ExclusionList is a list of regex strings used to exclude certain tags from being stored in the database.</summary>
    [JsonPropertyName("exclusionList")]
    public IList<string>? ExclusionList { get; set; }

    /// <summary>Image is the name of the image repository</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Insecure allows connecting to a non-TLS HTTP container registry.</summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary>Interval is the length of time to wait between scans of the image repository.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>The provider used for authentication, can be 'aws', 'azure', 'gcp' or 'generic'. When not specified, defaults to 'generic'.</summary>
    [JsonPropertyName("provider")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageRepositorySpecProviderEnum>))]
    public V1beta2ImageRepositorySpecProviderEnum? Provider { get; set; }

    /// <summary>SecretRef can be given the name of a secret containing credentials to use for the image registry. The secret should be created with `kubectl create secret docker-registry`, or the equivalent.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta2ImageRepositorySpecSecretRef? SecretRef { get; set; }

    /// <summary>ServiceAccountName is the name of the Kubernetes ServiceAccount used to authenticate the image pull if the service account has attached pull secrets.</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>This flag tells the controller to suspend subsequent image scans. It does not apply to already started scans. Defaults to false.</summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>Timeout for image scanning. Defaults to 'Interval' duration.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ImageRepositoryStatusConditionsStatusEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRepositoryStatusConditions
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
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageRepositoryStatusConditionsStatusEnum>))]
    public V1beta2ImageRepositoryStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase. --- Many .condition.type values are consistent across resources like Available, but because arbitrary conditions can be useful (see .node.status.conditions), the ability to deconflict is important. The regex it matches is (dns1123SubdomainFmt/)?(qualifiedNameFmt)</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>LastScanResult contains the number of fetched tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRepositoryStatusLastScanResult
{
    /// <summary></summary>
    [JsonPropertyName("latestTags")]
    public IList<string>? LatestTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scanTime")]
    public string? ScanTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tagCount")]
    public int TagCount { get; set; }
}

/// <summary>ImageRepositoryStatus defines the observed state of ImageRepository</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageRepositoryStatus
{
    /// <summary>CanonicalName is the name of the image repository with all the implied bits made explicit; e.g., `docker.io/library/alpine` rather than `alpine`.</summary>
    [JsonPropertyName("canonicalImageName")]
    public string? CanonicalImageName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ImageRepositoryStatusConditions>? Conditions { get; set; }

    /// <summary>LastHandledReconcileAt holds the value of the most recent reconcile request value, so a change of the annotation value can be detected.</summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>LastScanResult contains the number of fetched tags.</summary>
    [JsonPropertyName("lastScanResult")]
    public V1beta2ImageRepositoryStatusLastScanResult? LastScanResult { get; set; }

    /// <summary>ObservedExclusionList is a list of observed exclusion list. It reflects the exclusion rules used for the observed scan result in spec.lastScanResult.</summary>
    [JsonPropertyName("observedExclusionList")]
    public IList<string>? ObservedExclusionList { get; set; }

    /// <summary>ObservedGeneration is the last reconciled generation.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ImageRepository is the Schema for the imagerepositories API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ImageRepository : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ImageRepositorySpec>, IStatus<V1beta2ImageRepositoryStatus>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ImageRepository";
    public const string KubeGroup = "image.toolkit.fluxcd.io";
    public const string KubePluralName = "imagerepositories";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ImageRepositorySpec defines the parameters for scanning an image repository, e.g., `fluxcd/flux`.</summary>
    [JsonPropertyName("spec")]
    public V1beta2ImageRepositorySpec? Spec { get; set; }

    /// <summary>ImageRepositoryStatus defines the observed state of ImageRepository</summary>
    [JsonPropertyName("status")]
    public V1beta2ImageRepositoryStatus? Status { get; set; }
}