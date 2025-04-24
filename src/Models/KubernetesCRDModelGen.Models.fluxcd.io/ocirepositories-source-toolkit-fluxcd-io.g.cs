using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.source.toolkit.fluxcd.io;
/// <summary>CertSecretRef can be given the name of a Secret containing either or both of  - a PEM-encoded client certificate (`tls.crt`) and private key (`tls.key`); - a PEM-encoded CA certificate (`ca.crt`)  and whichever are supplied, will be used for connecting to the registry. The client cert and key are useful if you are authenticating with a certificate; the CA cert is useful if you are using a self-signed server certificate. The Secret must be of type `Opaque` or `kubernetes.io/tls`.  Note: Support for the `caFile`, `certFile` and `keyFile` keys have been deprecated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OCIRepositorySpecCertSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>LayerSelector specifies which layer should be extracted from the OCI artifact. When not specified, the first layer found in the artifact is selected.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OCIRepositorySpecLayerSelector
{
    /// <summary>MediaType specifies the OCI media type of the layer which should be extracted from the OCI Artifact. The first layer matching this type is selected.</summary>
    [JsonPropertyName("mediaType")]
    public string? MediaType { get; set; }

    /// <summary>Operation specifies how the selected layer should be processed. By default, the layer compressed content is extracted to storage. When the operation is set to 'copy', the layer compressed content is persisted to storage as it is.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }
}

/// <summary>ProxySecretRef specifies the Secret containing the proxy configuration to use while communicating with the container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OCIRepositorySpecProxySecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The OCI reference to pull and monitor for changes, defaults to the latest tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OCIRepositorySpecRef
{
    /// <summary>Digest is the image digest to pull, takes precedence over SemVer. The value should be in the format 'sha256:&lt;HASH&gt;'.</summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>SemVer is the range of tags to pull selecting the latest within the range, takes precedence over Tag.</summary>
    [JsonPropertyName("semver")]
    public string? Semver { get; set; }

    /// <summary>SemverFilter is a regex pattern to filter the tags within the SemVer range.</summary>
    [JsonPropertyName("semverFilter")]
    public string? SemverFilter { get; set; }

    /// <summary>Tag is the image tag to pull, defaults to latest.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>SecretRef contains the secret name containing the registry login credentials to resolve image metadata. The secret must be of type kubernetes.io/dockerconfigjson.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OCIRepositorySpecSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>OIDCIdentityMatch specifies options for verifying the certificate identity, i.e. the issuer and the subject of the certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OCIRepositorySpecVerifyMatchOIDCIdentity
{
    /// <summary>Issuer specifies the regex pattern to match against to verify the OIDC issuer in the Fulcio certificate. The pattern must be a valid Go regular expression.</summary>
    [JsonPropertyName("issuer")]
    public string Issuer { get; set; }

    /// <summary>Subject specifies the regex pattern to match against to verify the identity subject in the Fulcio certificate. The pattern must be a valid Go regular expression.</summary>
    [JsonPropertyName("subject")]
    public string Subject { get; set; }
}

/// <summary>SecretRef specifies the Kubernetes Secret containing the trusted public keys.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OCIRepositorySpecVerifySecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Verify contains the secret name containing the trusted public keys used to verify the signature and specifies which provider to use to check whether OCI image is authentic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OCIRepositorySpecVerify
{
    /// <summary>MatchOIDCIdentity specifies the identity matching criteria to use while verifying an OCI artifact which was signed using Cosign keyless signing. The artifact's identity is deemed to be verified if any of the specified matchers match against the identity.</summary>
    [JsonPropertyName("matchOIDCIdentity")]
    public IList<V1beta2OCIRepositorySpecVerifyMatchOIDCIdentity>? MatchOIDCIdentity { get; set; }

    /// <summary>Provider specifies the technology used to sign the OCI Artifact.</summary>
    [JsonPropertyName("provider")]
    public string Provider { get; set; }

    /// <summary>SecretRef specifies the Kubernetes Secret containing the trusted public keys.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta2OCIRepositorySpecVerifySecretRef? SecretRef { get; set; }
}

/// <summary>OCIRepositorySpec defines the desired state of OCIRepository</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OCIRepositorySpec
{
    /// <summary>CertSecretRef can be given the name of a Secret containing either or both of  - a PEM-encoded client certificate (`tls.crt`) and private key (`tls.key`); - a PEM-encoded CA certificate (`ca.crt`)  and whichever are supplied, will be used for connecting to the registry. The client cert and key are useful if you are authenticating with a certificate; the CA cert is useful if you are using a self-signed server certificate. The Secret must be of type `Opaque` or `kubernetes.io/tls`.  Note: Support for the `caFile`, `certFile` and `keyFile` keys have been deprecated.</summary>
    [JsonPropertyName("certSecretRef")]
    public V1beta2OCIRepositorySpecCertSecretRef? CertSecretRef { get; set; }

    /// <summary>Ignore overrides the set of excluded patterns in the .sourceignore format (which is the same as .gitignore). If not provided, a default will be used, consult the documentation for your version to find out what those are.</summary>
    [JsonPropertyName("ignore")]
    public string? Ignore { get; set; }

    /// <summary>Insecure allows connecting to a non-TLS HTTP container registry.</summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary>Interval at which the OCIRepository URL is checked for updates. This interval is approximate and may be subject to jitter to ensure efficient use of resources.</summary>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }

    /// <summary>LayerSelector specifies which layer should be extracted from the OCI artifact. When not specified, the first layer found in the artifact is selected.</summary>
    [JsonPropertyName("layerSelector")]
    public V1beta2OCIRepositorySpecLayerSelector? LayerSelector { get; set; }

    /// <summary>The provider used for authentication, can be 'aws', 'azure', 'gcp' or 'generic'. When not specified, defaults to 'generic'.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>ProxySecretRef specifies the Secret containing the proxy configuration to use while communicating with the container registry.</summary>
    [JsonPropertyName("proxySecretRef")]
    public V1beta2OCIRepositorySpecProxySecretRef? ProxySecretRef { get; set; }

    /// <summary>The OCI reference to pull and monitor for changes, defaults to the latest tag.</summary>
    [JsonPropertyName("ref")]
    public V1beta2OCIRepositorySpecRef? Ref { get; set; }

    /// <summary>SecretRef contains the secret name containing the registry login credentials to resolve image metadata. The secret must be of type kubernetes.io/dockerconfigjson.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta2OCIRepositorySpecSecretRef? SecretRef { get; set; }

    /// <summary>ServiceAccountName is the name of the Kubernetes ServiceAccount used to authenticate the image pull if the service account has attached pull secrets. For more information: https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/#add-imagepullsecrets-to-a-service-account</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>This flag tells the controller to suspend the reconciliation of this source.</summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>The timeout for remote OCI Repository operations like pulling, defaults to 60s.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>URL is a reference to an OCI artifact repository hosted on a remote container registry.</summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <summary>Verify contains the secret name containing the trusted public keys used to verify the signature and specifies which provider to use to check whether OCI image is authentic.</summary>
    [JsonPropertyName("verify")]
    public V1beta2OCIRepositorySpecVerify? Verify { get; set; }
}

/// <summary>Artifact represents the output of the last successful OCI Repository sync.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OCIRepositoryStatusArtifact
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

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OCIRepositoryStatusConditions
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

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>ObservedLayerSelector is the observed layer selector used for constructing the source artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OCIRepositoryStatusObservedLayerSelector
{
    /// <summary>MediaType specifies the OCI media type of the layer which should be extracted from the OCI Artifact. The first layer matching this type is selected.</summary>
    [JsonPropertyName("mediaType")]
    public string? MediaType { get; set; }

    /// <summary>Operation specifies how the selected layer should be processed. By default, the layer compressed content is extracted to storage. When the operation is set to 'copy', the layer compressed content is persisted to storage as it is.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }
}

/// <summary>OCIRepositoryStatus defines the observed state of OCIRepository</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OCIRepositoryStatus
{
    /// <summary>Artifact represents the output of the last successful OCI Repository sync.</summary>
    [JsonPropertyName("artifact")]
    public V1beta2OCIRepositoryStatusArtifact? Artifact { get; set; }

    /// <summary>Conditions holds the conditions for the OCIRepository.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2OCIRepositoryStatusConditions>? Conditions { get; set; }

    /// <summary>ContentConfigChecksum is a checksum of all the configurations related to the content of the source artifact:  - .spec.ignore  - .spec.layerSelector observed in .status.observedGeneration version of the object. This can be used to determine if the content configuration has changed and the artifact needs to be rebuilt. It has the format of `&lt;algo&gt;:&lt;checksum&gt;`, for example: `sha256:&lt;checksum&gt;`.  Deprecated: Replaced with explicit fields for observed artifact content config in the status.</summary>
    [JsonPropertyName("contentConfigChecksum")]
    public string? ContentConfigChecksum { get; set; }

    /// <summary>LastHandledReconcileAt holds the value of the most recent reconcile request value, so a change of the annotation value can be detected.</summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>ObservedGeneration is the last observed generation.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedIgnore is the observed exclusion patterns used for constructing the source artifact.</summary>
    [JsonPropertyName("observedIgnore")]
    public string? ObservedIgnore { get; set; }

    /// <summary>ObservedLayerSelector is the observed layer selector used for constructing the source artifact.</summary>
    [JsonPropertyName("observedLayerSelector")]
    public V1beta2OCIRepositoryStatusObservedLayerSelector? ObservedLayerSelector { get; set; }

    /// <summary>URL is the download link for the artifact output of the last OCI Repository sync.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>OCIRepository is the Schema for the ocirepositories API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2OCIRepository : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2OCIRepositorySpec>, IStatus<V1beta2OCIRepositoryStatus>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "OCIRepository";
    public const string KubeGroup = "source.toolkit.fluxcd.io";
    public const string KubePluralName = "ocirepositories";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OCIRepositorySpec defines the desired state of OCIRepository</summary>
    [JsonPropertyName("spec")]
    public V1beta2OCIRepositorySpec? Spec { get; set; }

    /// <summary>OCIRepositoryStatus defines the observed state of OCIRepository</summary>
    [JsonPropertyName("status")]
    public V1beta2OCIRepositoryStatus? Status { get; set; }
}

/// <summary>OCIRepository is the Schema for the ocirepositories API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2OCIRepositoryList : IKubernetesObject<V1ListMeta>, IItems<V1beta2OCIRepository>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "OCIRepositoryList";
    public const string KubeGroup = "source.toolkit.fluxcd.io";
    public const string KubePluralName = "ocirepositories";
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
    public IList<V1beta2OCIRepository> Items { get; set; }
}