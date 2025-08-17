using Microsoft.OpenApi;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.SourceGenerator;

public class V1ObjectMeta
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public class V1CustomResourceDefinitionNames
{
    [JsonPropertyName("categories")]
    public IList<string> Categories { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("listKind")]
    public string? ListKind { get; set; }

    [JsonPropertyName("plural")]
    public string Plural { get; set; }

    [JsonPropertyName("shortNames")]
    public IList<string> ShortNames { get; set; }

    [JsonPropertyName("singular")]
    public string Singular { get; set; }
}

public class V1CustomResourceValidation
{
    [JsonPropertyName("openAPIV3Schema")]
    public JsonNode OpenAPIV3Schema { get; set; }
}

public class V1CustomResourceDefinitionVersion
{
    //[JsonPropertyName("additionalPrinterColumns")]
    //public IList<V1CustomResourceColumnDefinition> AdditionalPrinterColumns { get; set; }

    [JsonPropertyName("deprecated")]
    public bool? Deprecated { get; set; }

    [JsonPropertyName("deprecationWarning")]
    public string DeprecationWarning { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("schema")]
    public V1CustomResourceValidation Schema { get; set; }

    [JsonPropertyName("served")]
    public bool Served { get; set; }

    [JsonPropertyName("storage")]
    public bool Storage { get; set; }
}

public class V1CustomResourceDefinitionSpec
{
    [JsonPropertyName("group")]
    public string Group { get; set; }

    [JsonPropertyName("names")]
    public V1CustomResourceDefinitionNames Names { get; set; }

    [JsonPropertyName("preserveUnknownFields")]
    public bool? PreserveUnknownFields { get; set; }

    [JsonPropertyName("scope")]
    public string Scope { get; set; }

    [JsonPropertyName("versions")]
    public IList<V1CustomResourceDefinitionVersion> Versions { get; set; }
}

public class V1CustomResourceDefinition
{
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1CustomResourceDefinitionSpec Spec { get; set; }
}