using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networking.@internal.knative.dev;
/// <summary>Spec is the desired state of the ClusterDomainClaim. More info: https://github.com/kubernetes/community/blob/master/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterDomainClaimSpec
{
    /// <summary>Namespace is the namespace which is allowed to create a DomainMapping using this ClusterDomainClaim's name.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ClusterDomainClaim is a cluster-wide reservation for a particular domain name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterDomainClaim : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ClusterDomainClaimSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterDomainClaim";
    public const string KubeGroup = "networking.internal.knative.dev";
    public const string KubePluralName = "clusterdomainclaims";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec is the desired state of the ClusterDomainClaim. More info: https://github.com/kubernetes/community/blob/master/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ClusterDomainClaimSpec? Spec { get; set; }
}

/// <summary>ClusterDomainClaim is a cluster-wide reservation for a particular domain name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterDomainClaimList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ClusterDomainClaim>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterDomainClaimList";
    public const string KubeGroup = "networking.internal.knative.dev";
    public const string KubePluralName = "clusterdomainclaims";
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
    public IList<V1alpha1ClusterDomainClaim> Items { get; set; }
}