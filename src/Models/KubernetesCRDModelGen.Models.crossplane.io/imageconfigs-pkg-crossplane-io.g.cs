using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pkg.crossplane.io;
/// <summary>ImageMatch defines a rule for matching image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageConfigSpecMatchImages
{
    /// <summary>Prefix is the prefix that should be matched.</summary>
    [JsonPropertyName("prefix")]
    public string Prefix { get; set; }

    /// <summary>Type is the type of match.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PullSecretRef is a reference to a secret that contains the credentials for the registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageConfigSpecRegistryAuthenticationPullSecretRef
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. TODO: Add other useful fields. apiVersion, kind, uid? More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Drop `kubebuilder:default` when controller-gen doesn't need it https://github.com/kubernetes-sigs/kubebuilder/issues/3896.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Authentication is the authentication information for the registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageConfigSpecRegistryAuthentication
{
    /// <summary>PullSecretRef is a reference to a secret that contains the credentials for the registry.</summary>
    [JsonPropertyName("pullSecretRef")]
    public V1beta1ImageConfigSpecRegistryAuthenticationPullSecretRef PullSecretRef { get; set; }
}

/// <summary>Registry is the configuration for the registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageConfigSpecRegistry
{
    /// <summary>Authentication is the authentication information for the registry.</summary>
    [JsonPropertyName("authentication")]
    public V1beta1ImageConfigSpecRegistryAuthentication? Authentication { get; set; }
}

/// <summary>ImageConfigSpec contains the configuration for matching images.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageConfigSpec
{
    /// <summary>MatchImages is a list of image matching rules that should be satisfied.</summary>
    [JsonPropertyName("matchImages")]
    public IList<V1beta1ImageConfigSpecMatchImages> MatchImages { get; set; }

    /// <summary>Registry is the configuration for the registry.</summary>
    [JsonPropertyName("registry")]
    public V1beta1ImageConfigSpecRegistry? Registry { get; set; }
}

/// <summary>The ImageConfig resource is used to configure settings for package images.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ImageConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ImageConfigSpec>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ImageConfig";
    public const string KubeGroup = "pkg.crossplane.io";
    public const string KubePluralName = "imageconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ImageConfigSpec contains the configuration for matching images.</summary>
    [JsonPropertyName("spec")]
    public V1beta1ImageConfigSpec? Spec { get; set; }
}