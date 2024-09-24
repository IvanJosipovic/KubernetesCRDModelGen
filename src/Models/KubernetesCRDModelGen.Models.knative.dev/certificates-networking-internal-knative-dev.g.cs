using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networking.@internal.knative.dev;
public partial class V1alpha1CertificateSpec
{
    /// <summary>DNSNames is a list of DNS names the Certificate could support. The wildcard format of DNSNames (e.g. *.default.example.com) is supported.</summary>
    [JsonPropertyName("dnsNames")]
    public IList<string> DnsNames { get; set; }

    /// <summary>Domain is the top level domain of the values for DNSNames.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>SecretName is the name of the secret resource to store the SSL certificate in.</summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

public partial class V1alpha1CertificateStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another. We use VolatileTime in place of metav1.Time to exclude this from creating equality.Semantic differences (all other things held constant).</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. When this is not specified, it defaults to Error.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

public partial class V1alpha1CertificateStatusHttp01Challenges
{
    /// <summary>ServiceName is the name of the service to serve HTTP01 challenge requests.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>ServiceNamespace is the namespace of the service to serve HTTP01 challenge requests.</summary>
    [JsonPropertyName("serviceNamespace")]
    public string? ServiceNamespace { get; set; }

    /// <summary>ServicePort is the port of the service to serve HTTP01 challenge requests.</summary>
    [JsonPropertyName("servicePort")]
    public IntstrIntOrString? ServicePort { get; set; }

    /// <summary>URL is the URL that the HTTP01 challenge is expected to serve on.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

public partial class V1alpha1CertificateStatus
{
    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Conditions the latest available observations of a resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CertificateStatusConditions>? Conditions { get; set; }

    /// <summary>HTTP01Challenges is a list of HTTP01 challenges that need to be fulfilled in order to get the TLS certificate..</summary>
    [JsonPropertyName("http01Challenges")]
    public IList<V1alpha1CertificateStatusHttp01Challenges>? Http01Challenges { get; set; }

    /// <summary>The expiration time of the TLS certificate stored in the secret named by this resource in spec.secretName.</summary>
    [JsonPropertyName("notAfter")]
    public string? NotAfter { get; set; }

    /// <summary>ObservedGeneration is the 'Generation' of the Service that was last processed by the controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Certificate : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CertificateSpec>, IStatus<V1alpha1CertificateStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Certificate";
    public const string KubeGroup = "networking.internal.knative.dev";
    public const string KubePluralName = "certificates";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec is the desired state of the Certificate. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("spec")]
    public V1alpha1CertificateSpec? Spec { get; set; }

    /// <summary>Status is the current state of the Certificate. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("status")]
    public V1alpha1CertificateStatus? Status { get; set; }
}