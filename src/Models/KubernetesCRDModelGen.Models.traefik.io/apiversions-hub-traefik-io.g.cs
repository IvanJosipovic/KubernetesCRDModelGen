using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hub.traefik.io;
/// <summary>OperationMatcher defines criteria for matching an OpenAPI operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIVersionSpecOpenApiSpecOperationSetsMatchers
{
    /// <summary>Methods specifies the HTTP methods to be included for selection.</summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary>Path specifies the exact path of the operations to select.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>PathPrefix specifies the path prefix of the operations to select.</summary>
    [JsonPropertyName("pathPrefix")]
    public string? PathPrefix { get; set; }

    /// <summary>PathRegex specifies a regular expression pattern for matching operations based on their paths.</summary>
    [JsonPropertyName("pathRegex")]
    public string? PathRegex { get; set; }
}

/// <summary>OperationSet gives a name to a set of matching OpenAPI operations. This set of operations can then be referenced for granular filtering in APIAccesses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIVersionSpecOpenApiSpecOperationSets
{
    /// <summary>Matchers defines a list of alternative rules for matching OpenAPI operations.</summary>
    [JsonPropertyName("matchers")]
    public IList<V1alpha1APIVersionSpecOpenApiSpecOperationSetsMatchers> Matchers { get; set; }

    /// <summary>Name is the name of the OperationSet to reference in APIAccesses.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIVersionSpecOpenApiSpecOverrideServers
{
    /// <summary></summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

/// <summary>Override holds data used to override OpenAPI specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIVersionSpecOpenApiSpecOverride
{
    /// <summary></summary>
    [JsonPropertyName("servers")]
    public IList<V1alpha1APIVersionSpecOpenApiSpecOverrideServers> Servers { get; set; }
}

/// <summary>OpenAPISpec defines the API contract as an OpenAPI specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIVersionSpecOpenApiSpec
{
    /// <summary>OperationSets defines the sets of operations to be referenced for granular filtering in APIAccesses.</summary>
    [JsonPropertyName("operationSets")]
    public IList<V1alpha1APIVersionSpecOpenApiSpecOperationSets>? OperationSets { get; set; }

    /// <summary>Override holds data used to override OpenAPI specification.</summary>
    [JsonPropertyName("override")]
    public V1alpha1APIVersionSpecOpenApiSpecOverride? Override { get; set; }

    /// <summary>Path specifies the endpoint path within the Kubernetes Service where the OpenAPI specification can be obtained. The Service queried is determined by the associated Ingress, IngressRoute, or HTTPRoute resource to which the API is attached. It's important to note that this option is incompatible if the Ingress or IngressRoute specifies multiple backend services. The Path must be accessible via a GET request method and should serve a YAML or JSON document containing the OpenAPI specification.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>URL is a Traefik Hub agent accessible URL for obtaining the OpenAPI specification. The URL must be accessible via a GET request method and should serve a YAML or JSON document containing the OpenAPI specification.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>The desired behavior of this APIVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIVersionSpec
{
    /// <summary>OpenAPISpec defines the API contract as an OpenAPI specification.</summary>
    [JsonPropertyName("openApiSpec")]
    public V1alpha1APIVersionSpecOpenApiSpec? OpenApiSpec { get; set; }

    /// <summary>Release is the version number of the API. This value must follow the SemVer format: https://semver.org/</summary>
    [JsonPropertyName("release")]
    public string Release { get; set; }

    /// <summary>Title is the public facing name of the APIVersion.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>The current status of this APIVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIVersionStatus
{
    /// <summary>Hash is a hash representing the APIVersion.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncedAt")]
    public string? SyncedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>APIVersion defines a version of an API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIVersion : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APIVersionSpec>, IStatus<V1alpha1APIVersionStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIVersion";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apiversions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The desired behavior of this APIVersion.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1APIVersionSpec? Spec { get; set; }

    /// <summary>The current status of this APIVersion.</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIVersionStatus? Status { get; set; }
}