using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hub.traefik.io;
#nullable enable
/// <summary>API defines an HTTP interface that is exposed to external clients. It specifies the supported versions and provides instructions for accessing its documentation. Once instantiated, an API object is associated with an Ingress, IngressRoute, or HTTPRoute resource, enabling the exposure of the described API to the outside world.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1API>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIList";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apis";
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
    public IList<V1alpha1API> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Cors defines the Cross-Origin Resource Sharing configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APISpecCors
{
    /// <summary>AddVaryHeader defines whether the Vary header is automatically added/updated when the AllowOriginsList is set.</summary>
    [JsonPropertyName("addVaryHeader")]
    public bool? AddVaryHeader { get; set; }

    /// <summary>AllowCredentials defines whether the request can include user credentials.</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>AllowHeadersList defines the Access-Control-Request-Headers values sent in preflight response.</summary>
    [JsonPropertyName("allowHeadersList")]
    public IList<string>? AllowHeadersList { get; set; }

    /// <summary>AllowMethodsList defines the Access-Control-Request-Method values sent in preflight response.</summary>
    [JsonPropertyName("allowMethodsList")]
    public IList<string>? AllowMethodsList { get; set; }

    /// <summary>AllowOriginListRegex is a list of allowable origins written following the Regular Expression syntax (https://golang.org/pkg/regexp/).</summary>
    [JsonPropertyName("allowOriginListRegex")]
    public IList<string>? AllowOriginListRegex { get; set; }

    /// <summary>AllowOriginsList is a list of allowable origins. Can also be a wildcard origin "*".</summary>
    [JsonPropertyName("allowOriginsList")]
    public IList<string>? AllowOriginsList { get; set; }

    /// <summary>ExposeHeadersList defines the Access-Control-Expose-Headers values sent in preflight response.</summary>
    [JsonPropertyName("exposeHeadersList")]
    public IList<string>? ExposeHeadersList { get; set; }

    /// <summary>MaxAge defines the time that a preflight request may be cached.</summary>
    [JsonPropertyName("maxAge")]
    public long? MaxAge { get; set; }
}
#nullable disable

#nullable enable
/// <summary>OperationMatcher defines criteria for matching an OpenAPI operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APISpecOpenApiSpecOperationSetsMatchers
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
#nullable disable

#nullable enable
/// <summary>OperationSet gives a name to a set of matching OpenAPI operations. This set of operations can then be referenced for granular filtering in APICatalogItems or ManagedSubscriptions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APISpecOpenApiSpecOperationSets
{
    /// <summary>Matchers defines a list of alternative rules for matching OpenAPI operations.</summary>
    [JsonPropertyName("matchers")]
    public IList<V1alpha1APISpecOpenApiSpecOperationSetsMatchers> Matchers { get; set; }

    /// <summary>Name is the name of the OperationSet to reference in APICatalogItems or ManagedSubscriptions.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APISpecOpenApiSpecOverrideServers
{
    /// <summary></summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Override holds data used to override OpenAPI specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APISpecOpenApiSpecOverride
{
    /// <summary></summary>
    [JsonPropertyName("servers")]
    public IList<V1alpha1APISpecOpenApiSpecOverrideServers> Servers { get; set; }
}
#nullable disable

#nullable enable
/// <summary>OpenAPISpec defines the API contract as an OpenAPI specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APISpecOpenApiSpec
{
    /// <summary>OperationSets defines the sets of operations to be referenced for granular filtering in APICatalogItems or ManagedSubscriptions.</summary>
    [JsonPropertyName("operationSets")]
    public IList<V1alpha1APISpecOpenApiSpecOperationSets>? OperationSets { get; set; }

    /// <summary>Override holds data used to override OpenAPI specification.</summary>
    [JsonPropertyName("override")]
    public V1alpha1APISpecOpenApiSpecOverride? Override { get; set; }

    /// <summary>Path specifies the endpoint path within the Kubernetes Service where the OpenAPI specification can be obtained. The Service queried is determined by the associated Ingress, IngressRoute, or HTTPRoute resource to which the API is attached. It's important to note that this option is incompatible if the Ingress or IngressRoute specifies multiple backend services. The Path must be accessible via a GET request method and should serve a YAML or JSON document containing the OpenAPI specification.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>URL is a Traefik Hub agent accessible URL for obtaining the OpenAPI specification. The URL must be accessible via a GET request method and should serve a YAML or JSON document containing the OpenAPI specification.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>ValidateRequestMethodAndPath validates that the path and method matches an operation defined in the OpenAPI specification. This option overrides the default behavior configured in the static configuration.</summary>
    [JsonPropertyName("validateRequestMethodAndPath")]
    public bool? ValidateRequestMethodAndPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>APIVersionRef references an APIVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APISpecVersions
{
    /// <summary>Name of the APIVersion.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>APISpec describes the API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APISpec
{
    /// <summary>Cors defines the Cross-Origin Resource Sharing configuration.</summary>
    [JsonPropertyName("cors")]
    public V1alpha1APISpecCors? Cors { get; set; }

    /// <summary>Description explains what the API does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>OpenAPISpec defines the API contract as an OpenAPI specification.</summary>
    [JsonPropertyName("openApiSpec")]
    public V1alpha1APISpecOpenApiSpec? OpenApiSpec { get; set; }

    /// <summary>Title is the human-readable name of the API that will be used on the portal.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>Versions are the different APIVersions available.</summary>
    [JsonPropertyName("versions")]
    public IList<V1alpha1APISpecVersions>? Versions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The current status of this API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIStatus
{
    /// <summary>Hash is a hash representing the API.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncedAt")]
    public string? SyncedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>API defines an HTTP interface that is exposed to external clients. It specifies the supported versions and provides instructions for accessing its documentation. Once instantiated, an API object is associated with an Ingress, IngressRoute, or HTTPRoute resource, enabling the exposure of the described API to the outside world.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1API : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APISpec>, IStatus<V1alpha1APIStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "API";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apis";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>APISpec describes the API.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1APISpec? Spec { get; set; }

    /// <summary>The current status of this API.</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIStatus? Status { get; set; }
}
#nullable disable
