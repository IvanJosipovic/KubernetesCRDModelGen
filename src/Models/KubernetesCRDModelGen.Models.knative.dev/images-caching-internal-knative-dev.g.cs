using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.caching.@internal.knative.dev;
public partial class V1alpha1ImageSpecImagePullSecrets
{
    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1alpha1ImageSpec
{
    /// <summary>Image is the name of the container image url to cache across the cluster.</summary>
    [JsonPropertyName("image")]
    public string Image { get; set; }

    /// <summary>ImagePullSecrets contains the names of the Kubernetes Secrets containing login information used by the Pods which will run this container.</summary>
    [JsonPropertyName("imagePullSecrets")]
    public IList<V1alpha1ImageSpecImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary>ServiceAccountName is the name of the Kubernetes ServiceAccount as which the Pods will run this container.  This is potentially used to authenticate the image pull if the service account has attached pull secrets.  For more information: https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/#add-imagepullsecrets-to-a-service-account</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }
}

public partial class V1alpha1ImageStatusConditions
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

public partial class V1alpha1ImageStatus
{
    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Conditions the latest available observations of a resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ImageStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the 'Generation' of the Service that was last processed by the controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Image : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ImageSpec>, IStatus<V1alpha1ImageStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Image";
    public const string KubeGroup = "caching.internal.knative.dev";
    public const string KubePluralName = "images";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec holds the desired state of the Image (from the client).</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ImageSpec? Spec { get; set; }

    /// <summary>Status communicates the observed state of the Image (from the controller).</summary>
    [JsonPropertyName("status")]
    public V1alpha1ImageStatus? Status { get; set; }
}