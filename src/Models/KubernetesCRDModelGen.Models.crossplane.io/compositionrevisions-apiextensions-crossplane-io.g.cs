using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apiextensions.crossplane.io;
/// <summary>CompositeTypeRef specifies the type of composite resource that this composition is compatible with.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecCompositeTypeRef
{
    /// <summary>APIVersion of the type.</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary>Kind of the type.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }
}

/// <summary>String declares that input variables should be combined into a single string, using the relevant settings for formatting purposes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPatchSetsPatchesCombineString
{
    /// <summary>Format the input using a Go format string. See https://golang.org/pkg/fmt/ for details.</summary>
    [JsonPropertyName("fmt")]
    public string Fmt { get; set; }
}

/// <summary>A CombineVariable defines the source of a value that is combined with others to form and patch an output value. Currently, this only supports retrieving values from a field path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPatchSetsPatchesCombineVariables
{
    /// <summary>FromFieldPath is the path of the field on the source whose value is to be used as input.</summary>
    [JsonPropertyName("fromFieldPath")]
    public string FromFieldPath { get; set; }
}

/// <summary>Combine is the patch configuration for a CombineFromComposite or CombineToComposite patch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPatchSetsPatchesCombine
{
    /// <summary>Strategy defines the strategy to use to combine the input variable values. Currently only string is supported.</summary>
    [JsonPropertyName("strategy")]
    public string Strategy { get; set; }

    /// <summary>String declares that input variables should be combined into a single string, using the relevant settings for formatting purposes.</summary>
    [JsonPropertyName("string")]
    public V1CompositionRevisionSpecPatchSetsPatchesCombineString? String { get; set; }

    /// <summary>Variables are the list of variables whose values will be retrieved and combined.</summary>
    [JsonPropertyName("variables")]
    public IList<V1CompositionRevisionSpecPatchSetsPatchesCombineVariables> Variables { get; set; }
}

/// <summary>MergeOptions Specifies merge options on a field path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPatchSetsPatchesPolicyMergeOptions
{
    /// <summary>Specifies that already existing elements in a merged slice should be preserved</summary>
    [JsonPropertyName("appendSlice")]
    public bool? AppendSlice { get; set; }

    /// <summary>Specifies that already existing values in a merged map should be preserved</summary>
    [JsonPropertyName("keepMapValues")]
    public bool? KeepMapValues { get; set; }
}

/// <summary>Policy configures the specifics of patching behaviour.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPatchSetsPatchesPolicy
{
    /// <summary>FromFieldPath specifies how to patch from a field path. The default is 'Optional', which means the patch will be a no-op if the specified fromFieldPath does not exist. Use 'Required' if the patch should fail if the specified path does not exist.</summary>
    [JsonPropertyName("fromFieldPath")]
    public string? FromFieldPath { get; set; }

    /// <summary>MergeOptions Specifies merge options on a field path.</summary>
    [JsonPropertyName("mergeOptions")]
    public V1CompositionRevisionSpecPatchSetsPatchesPolicyMergeOptions? MergeOptions { get; set; }
}

/// <summary>Convert is used to cast the input into the given output type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPatchSetsPatchesTransformsConvert
{
    /// <summary>The expected input format.   * `quantity` - parses the input as a K8s [`resource.Quantity`](https://pkg.go.dev/k8s.io/apimachinery/pkg/api/resource#Quantity). Only used during `string -&gt; float64` conversions. * `json` - parses the input as a JSON string. Only used during `string -&gt; object` or `string -&gt; list` conversions.   If this property is null, the default conversion is applied.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>ToType is the type of the output of this transform.</summary>
    [JsonPropertyName("toType")]
    public string ToType { get; set; }
}

/// <summary>MatchTransformPattern is a transform that returns the value that matches a pattern.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPatchSetsPatchesTransformsMatchPatterns
{
    /// <summary>Literal exactly matches the input string (case sensitive). Is required if `type` is `literal`.</summary>
    [JsonPropertyName("literal")]
    public string? Literal { get; set; }

    /// <summary>Regexp to match against the input string. Is required if `type` is `regexp`.</summary>
    [JsonPropertyName("regexp")]
    public string? Regexp { get; set; }

    /// <summary>The value that is used as result of the transform if the pattern matches.</summary>
    [JsonPropertyName("result")]
    public JsonNode Result { get; set; }

    /// <summary>Type specifies how the pattern matches the input.   * `literal` - the pattern value has to exactly match (case sensitive) the input string. This is the default.   * `regexp` - the pattern treated as a regular expression against which the input string is tested. Crossplane will throw an error if the key is not a valid regexp.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Match is a more complex version of Map that matches a list of patterns.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPatchSetsPatchesTransformsMatch
{
    /// <summary>Determines to what value the transform should fallback if no pattern matches.</summary>
    [JsonPropertyName("fallbackTo")]
    public string? FallbackTo { get; set; }

    /// <summary>The fallback value that should be returned by the transform if now pattern matches.</summary>
    [JsonPropertyName("fallbackValue")]
    public JsonNode? FallbackValue { get; set; }

    /// <summary>The patterns that should be tested against the input string. Patterns are tested in order. The value of the first match is used as result of this transform.</summary>
    [JsonPropertyName("patterns")]
    public IList<V1CompositionRevisionSpecPatchSetsPatchesTransformsMatchPatterns>? Patterns { get; set; }
}

/// <summary>Math is used to transform the input via mathematical operations such as multiplication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPatchSetsPatchesTransformsMath
{
    /// <summary>ClampMax makes sure that the value is not bigger than the given value.</summary>
    [JsonPropertyName("clampMax")]
    public long? ClampMax { get; set; }

    /// <summary>ClampMin makes sure that the value is not smaller than the given value.</summary>
    [JsonPropertyName("clampMin")]
    public long? ClampMin { get; set; }

    /// <summary>Multiply the value.</summary>
    [JsonPropertyName("multiply")]
    public long? Multiply { get; set; }

    /// <summary>Type of the math transform to be run.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Join defines parameters to join a slice of values to a string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPatchSetsPatchesTransformsStringJoin
{
    /// <summary>Separator defines the character that should separate the values from each other in the joined string.</summary>
    [JsonPropertyName("separator")]
    public string Separator { get; set; }
}

/// <summary>Extract a match from the input using a regular expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPatchSetsPatchesTransformsStringRegexp
{
    /// <summary>Group number to match. 0 (the default) matches the entire expression.</summary>
    [JsonPropertyName("group")]
    public int? Group { get; set; }

    /// <summary>Match string. May optionally include submatches, aka capture groups. See https://pkg.go.dev/regexp/ for details.</summary>
    [JsonPropertyName("match")]
    public string Match { get; set; }
}

/// <summary>String is used to transform the input into a string or a different kind of string. Note that the input does not necessarily need to be a string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPatchSetsPatchesTransformsString
{
    /// <summary>Optional conversion method to be specified. `ToUpper` and `ToLower` change the letter case of the input string. `ToBase64` and `FromBase64` perform a base64 conversion based on the input string. `ToJson` converts any input value into its raw JSON representation. `ToSha1`, `ToSha256` and `ToSha512` generate a hash value based on the input converted to JSON. `ToAdler32` generate a addler32 hash based on the input string.</summary>
    [JsonPropertyName("convert")]
    public string? Convert { get; set; }

    /// <summary>Format the input using a Go format string. See https://golang.org/pkg/fmt/ for details.</summary>
    [JsonPropertyName("fmt")]
    public string? Fmt { get; set; }

    /// <summary>Join defines parameters to join a slice of values to a string.</summary>
    [JsonPropertyName("join")]
    public V1CompositionRevisionSpecPatchSetsPatchesTransformsStringJoin? Join { get; set; }

    /// <summary>Extract a match from the input using a regular expression.</summary>
    [JsonPropertyName("regexp")]
    public V1CompositionRevisionSpecPatchSetsPatchesTransformsStringRegexp? Regexp { get; set; }

    /// <summary>Trim the prefix or suffix from the input</summary>
    [JsonPropertyName("trim")]
    public string? Trim { get; set; }

    /// <summary>Type of the string transform to be run.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Transform is a unit of process whose input is transformed into an output with the supplied configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPatchSetsPatchesTransforms
{
    /// <summary>Convert is used to cast the input into the given output type.</summary>
    [JsonPropertyName("convert")]
    public V1CompositionRevisionSpecPatchSetsPatchesTransformsConvert? Convert { get; set; }

    /// <summary>Map uses the input as a key in the given map and returns the value.</summary>
    [JsonPropertyName("map")]
    public IDictionary<string, JsonNode>? Map { get; set; }

    /// <summary>Match is a more complex version of Map that matches a list of patterns.</summary>
    [JsonPropertyName("match")]
    public V1CompositionRevisionSpecPatchSetsPatchesTransformsMatch? Match { get; set; }

    /// <summary>Math is used to transform the input via mathematical operations such as multiplication.</summary>
    [JsonPropertyName("math")]
    public V1CompositionRevisionSpecPatchSetsPatchesTransformsMath? Math { get; set; }

    /// <summary>String is used to transform the input into a string or a different kind of string. Note that the input does not necessarily need to be a string.</summary>
    [JsonPropertyName("string")]
    public V1CompositionRevisionSpecPatchSetsPatchesTransformsString? String { get; set; }

    /// <summary>Type of the transform to be run.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Patch objects are applied between composite and composed resources. Their behaviour depends on the Type selected. The default Type, FromCompositeFieldPath, copies a value from the composite resource to the composed resource, applying any defined transformers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPatchSetsPatches
{
    /// <summary>Combine is the patch configuration for a CombineFromComposite or CombineToComposite patch.</summary>
    [JsonPropertyName("combine")]
    public V1CompositionRevisionSpecPatchSetsPatchesCombine? Combine { get; set; }

    /// <summary>FromFieldPath is the path of the field on the resource whose value is to be used as input. Required when type is FromCompositeFieldPath or ToCompositeFieldPath.</summary>
    [JsonPropertyName("fromFieldPath")]
    public string? FromFieldPath { get; set; }

    /// <summary>PatchSetName to include patches from. Required when type is PatchSet.</summary>
    [JsonPropertyName("patchSetName")]
    public string? PatchSetName { get; set; }

    /// <summary>Policy configures the specifics of patching behaviour.</summary>
    [JsonPropertyName("policy")]
    public V1CompositionRevisionSpecPatchSetsPatchesPolicy? Policy { get; set; }

    /// <summary>ToFieldPath is the path of the field on the resource whose value will be changed with the result of transforms. Leave empty if you'd like to propagate to the same path as fromFieldPath.</summary>
    [JsonPropertyName("toFieldPath")]
    public string? ToFieldPath { get; set; }

    /// <summary>Transforms are the list of functions that are used as a FIFO pipe for the input to be transformed.</summary>
    [JsonPropertyName("transforms")]
    public IList<V1CompositionRevisionSpecPatchSetsPatchesTransforms>? Transforms { get; set; }

    /// <summary>Type sets the patching behaviour to be used. Each patch type may require its own fields to be set on the Patch object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A PatchSet is a set of patches that can be reused from all resources within a Composition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPatchSets
{
    /// <summary>Name of this PatchSet.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Patches will be applied as an overlay to the base resource.</summary>
    [JsonPropertyName("patches")]
    public IList<V1CompositionRevisionSpecPatchSetsPatches> Patches { get; set; }
}

/// <summary>A SecretRef is a reference to a secret containing credentials that should be supplied to the function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPipelineCredentialsSecretRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>FunctionCredentials are optional credentials that a Composition Function needs to run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPipelineCredentials
{
    /// <summary>Name of this set of credentials.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>A SecretRef is a reference to a secret containing credentials that should be supplied to the function.</summary>
    [JsonPropertyName("secretRef")]
    public V1CompositionRevisionSpecPipelineCredentialsSecretRef? SecretRef { get; set; }

    /// <summary>Source of the function credentials.</summary>
    [JsonPropertyName("source")]
    public string Source { get; set; }
}

/// <summary>FunctionRef is a reference to the Composition Function this step should execute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPipelineFunctionRef
{
    /// <summary>Name of the referenced Function.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A PipelineStep in a Composition Function pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPipeline
{
    /// <summary>Credentials are optional credentials that the Composition Function needs.</summary>
    [JsonPropertyName("credentials")]
    public IList<V1CompositionRevisionSpecPipelineCredentials>? Credentials { get; set; }

    /// <summary>FunctionRef is a reference to the Composition Function this step should execute.</summary>
    [JsonPropertyName("functionRef")]
    public V1CompositionRevisionSpecPipelineFunctionRef FunctionRef { get; set; }

    /// <summary>Input is an optional, arbitrary Kubernetes resource (i.e. a resource with an apiVersion and kind) that will be passed to the Composition Function as the 'input' of its RunFunctionRequest.</summary>
    [JsonPropertyName("input")]
    public JsonNode? Input { get; set; }

    /// <summary>Step name. Must be unique within its Pipeline.</summary>
    [JsonPropertyName("step")]
    public string Step { get; set; }
}

/// <summary>PublishConnectionDetailsWithStoreConfig specifies the secret store config with which the connection details of composite resources dynamically provisioned using this composition will be published.   THIS IS AN ALPHA FIELD. Do not use it in production. It is not honored unless the relevant Crossplane feature flag is enabled, and may be changed or removed without notice.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecPublishConnectionDetailsWithStoreConfigRef
{
    /// <summary>Name of the referenced StoreConfig.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ConnectionDetail includes the information about the propagation of the connection information from one secret to another.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecResourcesConnectionDetails
{
    /// <summary>FromConnectionSecretKey is the key that will be used to fetch the value from the composed resource's connection secret.</summary>
    [JsonPropertyName("fromConnectionSecretKey")]
    public string? FromConnectionSecretKey { get; set; }

    /// <summary>FromFieldPath is the path of the field on the composed resource whose value to be used as input. Name must be specified if the type is FromFieldPath.</summary>
    [JsonPropertyName("fromFieldPath")]
    public string? FromFieldPath { get; set; }

    /// <summary>Name of the connection secret key that will be propagated to the connection secret of the composition instance. Leave empty if you'd like to use the same key name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type sets the connection detail fetching behaviour to be used. Each connection detail type may require its own fields to be set on the ConnectionDetail object. If the type is omitted Crossplane will attempt to infer it based on which other fields were specified. If multiple fields are specified the order of precedence is: 1. FromValue 2. FromConnectionSecretKey 3. FromFieldPath</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value that will be propagated to the connection secret of the composite resource. May be set to inject a fixed, non-sensitive connection secret value, for example a well-known port.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>String declares that input variables should be combined into a single string, using the relevant settings for formatting purposes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecResourcesPatchesCombineString
{
    /// <summary>Format the input using a Go format string. See https://golang.org/pkg/fmt/ for details.</summary>
    [JsonPropertyName("fmt")]
    public string Fmt { get; set; }
}

/// <summary>A CombineVariable defines the source of a value that is combined with others to form and patch an output value. Currently, this only supports retrieving values from a field path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecResourcesPatchesCombineVariables
{
    /// <summary>FromFieldPath is the path of the field on the source whose value is to be used as input.</summary>
    [JsonPropertyName("fromFieldPath")]
    public string FromFieldPath { get; set; }
}

/// <summary>Combine is the patch configuration for a CombineFromComposite or CombineToComposite patch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecResourcesPatchesCombine
{
    /// <summary>Strategy defines the strategy to use to combine the input variable values. Currently only string is supported.</summary>
    [JsonPropertyName("strategy")]
    public string Strategy { get; set; }

    /// <summary>String declares that input variables should be combined into a single string, using the relevant settings for formatting purposes.</summary>
    [JsonPropertyName("string")]
    public V1CompositionRevisionSpecResourcesPatchesCombineString? String { get; set; }

    /// <summary>Variables are the list of variables whose values will be retrieved and combined.</summary>
    [JsonPropertyName("variables")]
    public IList<V1CompositionRevisionSpecResourcesPatchesCombineVariables> Variables { get; set; }
}

/// <summary>MergeOptions Specifies merge options on a field path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecResourcesPatchesPolicyMergeOptions
{
    /// <summary>Specifies that already existing elements in a merged slice should be preserved</summary>
    [JsonPropertyName("appendSlice")]
    public bool? AppendSlice { get; set; }

    /// <summary>Specifies that already existing values in a merged map should be preserved</summary>
    [JsonPropertyName("keepMapValues")]
    public bool? KeepMapValues { get; set; }
}

/// <summary>Policy configures the specifics of patching behaviour.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecResourcesPatchesPolicy
{
    /// <summary>FromFieldPath specifies how to patch from a field path. The default is 'Optional', which means the patch will be a no-op if the specified fromFieldPath does not exist. Use 'Required' if the patch should fail if the specified path does not exist.</summary>
    [JsonPropertyName("fromFieldPath")]
    public string? FromFieldPath { get; set; }

    /// <summary>MergeOptions Specifies merge options on a field path.</summary>
    [JsonPropertyName("mergeOptions")]
    public V1CompositionRevisionSpecResourcesPatchesPolicyMergeOptions? MergeOptions { get; set; }
}

/// <summary>Convert is used to cast the input into the given output type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecResourcesPatchesTransformsConvert
{
    /// <summary>The expected input format.   * `quantity` - parses the input as a K8s [`resource.Quantity`](https://pkg.go.dev/k8s.io/apimachinery/pkg/api/resource#Quantity). Only used during `string -&gt; float64` conversions. * `json` - parses the input as a JSON string. Only used during `string -&gt; object` or `string -&gt; list` conversions.   If this property is null, the default conversion is applied.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>ToType is the type of the output of this transform.</summary>
    [JsonPropertyName("toType")]
    public string ToType { get; set; }
}

/// <summary>MatchTransformPattern is a transform that returns the value that matches a pattern.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecResourcesPatchesTransformsMatchPatterns
{
    /// <summary>Literal exactly matches the input string (case sensitive). Is required if `type` is `literal`.</summary>
    [JsonPropertyName("literal")]
    public string? Literal { get; set; }

    /// <summary>Regexp to match against the input string. Is required if `type` is `regexp`.</summary>
    [JsonPropertyName("regexp")]
    public string? Regexp { get; set; }

    /// <summary>The value that is used as result of the transform if the pattern matches.</summary>
    [JsonPropertyName("result")]
    public JsonNode Result { get; set; }

    /// <summary>Type specifies how the pattern matches the input.   * `literal` - the pattern value has to exactly match (case sensitive) the input string. This is the default.   * `regexp` - the pattern treated as a regular expression against which the input string is tested. Crossplane will throw an error if the key is not a valid regexp.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Match is a more complex version of Map that matches a list of patterns.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecResourcesPatchesTransformsMatch
{
    /// <summary>Determines to what value the transform should fallback if no pattern matches.</summary>
    [JsonPropertyName("fallbackTo")]
    public string? FallbackTo { get; set; }

    /// <summary>The fallback value that should be returned by the transform if now pattern matches.</summary>
    [JsonPropertyName("fallbackValue")]
    public JsonNode? FallbackValue { get; set; }

    /// <summary>The patterns that should be tested against the input string. Patterns are tested in order. The value of the first match is used as result of this transform.</summary>
    [JsonPropertyName("patterns")]
    public IList<V1CompositionRevisionSpecResourcesPatchesTransformsMatchPatterns>? Patterns { get; set; }
}

/// <summary>Math is used to transform the input via mathematical operations such as multiplication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecResourcesPatchesTransformsMath
{
    /// <summary>ClampMax makes sure that the value is not bigger than the given value.</summary>
    [JsonPropertyName("clampMax")]
    public long? ClampMax { get; set; }

    /// <summary>ClampMin makes sure that the value is not smaller than the given value.</summary>
    [JsonPropertyName("clampMin")]
    public long? ClampMin { get; set; }

    /// <summary>Multiply the value.</summary>
    [JsonPropertyName("multiply")]
    public long? Multiply { get; set; }

    /// <summary>Type of the math transform to be run.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Join defines parameters to join a slice of values to a string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecResourcesPatchesTransformsStringJoin
{
    /// <summary>Separator defines the character that should separate the values from each other in the joined string.</summary>
    [JsonPropertyName("separator")]
    public string Separator { get; set; }
}

/// <summary>Extract a match from the input using a regular expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecResourcesPatchesTransformsStringRegexp
{
    /// <summary>Group number to match. 0 (the default) matches the entire expression.</summary>
    [JsonPropertyName("group")]
    public int? Group { get; set; }

    /// <summary>Match string. May optionally include submatches, aka capture groups. See https://pkg.go.dev/regexp/ for details.</summary>
    [JsonPropertyName("match")]
    public string Match { get; set; }
}

/// <summary>String is used to transform the input into a string or a different kind of string. Note that the input does not necessarily need to be a string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecResourcesPatchesTransformsString
{
    /// <summary>Optional conversion method to be specified. `ToUpper` and `ToLower` change the letter case of the input string. `ToBase64` and `FromBase64` perform a base64 conversion based on the input string. `ToJson` converts any input value into its raw JSON representation. `ToSha1`, `ToSha256` and `ToSha512` generate a hash value based on the input converted to JSON. `ToAdler32` generate a addler32 hash based on the input string.</summary>
    [JsonPropertyName("convert")]
    public string? Convert { get; set; }

    /// <summary>Format the input using a Go format string. See https://golang.org/pkg/fmt/ for details.</summary>
    [JsonPropertyName("fmt")]
    public string? Fmt { get; set; }

    /// <summary>Join defines parameters to join a slice of values to a string.</summary>
    [JsonPropertyName("join")]
    public V1CompositionRevisionSpecResourcesPatchesTransformsStringJoin? Join { get; set; }

    /// <summary>Extract a match from the input using a regular expression.</summary>
    [JsonPropertyName("regexp")]
    public V1CompositionRevisionSpecResourcesPatchesTransformsStringRegexp? Regexp { get; set; }

    /// <summary>Trim the prefix or suffix from the input</summary>
    [JsonPropertyName("trim")]
    public string? Trim { get; set; }

    /// <summary>Type of the string transform to be run.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Transform is a unit of process whose input is transformed into an output with the supplied configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecResourcesPatchesTransforms
{
    /// <summary>Convert is used to cast the input into the given output type.</summary>
    [JsonPropertyName("convert")]
    public V1CompositionRevisionSpecResourcesPatchesTransformsConvert? Convert { get; set; }

    /// <summary>Map uses the input as a key in the given map and returns the value.</summary>
    [JsonPropertyName("map")]
    public IDictionary<string, JsonNode>? Map { get; set; }

    /// <summary>Match is a more complex version of Map that matches a list of patterns.</summary>
    [JsonPropertyName("match")]
    public V1CompositionRevisionSpecResourcesPatchesTransformsMatch? Match { get; set; }

    /// <summary>Math is used to transform the input via mathematical operations such as multiplication.</summary>
    [JsonPropertyName("math")]
    public V1CompositionRevisionSpecResourcesPatchesTransformsMath? Math { get; set; }

    /// <summary>String is used to transform the input into a string or a different kind of string. Note that the input does not necessarily need to be a string.</summary>
    [JsonPropertyName("string")]
    public V1CompositionRevisionSpecResourcesPatchesTransformsString? String { get; set; }

    /// <summary>Type of the transform to be run.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Patch objects are applied between composite and composed resources. Their behaviour depends on the Type selected. The default Type, FromCompositeFieldPath, copies a value from the composite resource to the composed resource, applying any defined transformers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecResourcesPatches
{
    /// <summary>Combine is the patch configuration for a CombineFromComposite or CombineToComposite patch.</summary>
    [JsonPropertyName("combine")]
    public V1CompositionRevisionSpecResourcesPatchesCombine? Combine { get; set; }

    /// <summary>FromFieldPath is the path of the field on the resource whose value is to be used as input. Required when type is FromCompositeFieldPath or ToCompositeFieldPath.</summary>
    [JsonPropertyName("fromFieldPath")]
    public string? FromFieldPath { get; set; }

    /// <summary>PatchSetName to include patches from. Required when type is PatchSet.</summary>
    [JsonPropertyName("patchSetName")]
    public string? PatchSetName { get; set; }

    /// <summary>Policy configures the specifics of patching behaviour.</summary>
    [JsonPropertyName("policy")]
    public V1CompositionRevisionSpecResourcesPatchesPolicy? Policy { get; set; }

    /// <summary>ToFieldPath is the path of the field on the resource whose value will be changed with the result of transforms. Leave empty if you'd like to propagate to the same path as fromFieldPath.</summary>
    [JsonPropertyName("toFieldPath")]
    public string? ToFieldPath { get; set; }

    /// <summary>Transforms are the list of functions that are used as a FIFO pipe for the input to be transformed.</summary>
    [JsonPropertyName("transforms")]
    public IList<V1CompositionRevisionSpecResourcesPatchesTransforms>? Transforms { get; set; }

    /// <summary>Type sets the patching behaviour to be used. Each patch type may require its own fields to be set on the Patch object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>MatchCondition specifies the condition you'd like to match if you're using "MatchCondition" type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecResourcesReadinessChecksMatchCondition
{
    /// <summary>Status is the status of the condition you'd like to match.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type indicates the type of condition you'd like to use.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>ReadinessCheck is used to indicate how to tell whether a resource is ready for consumption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecResourcesReadinessChecks
{
    /// <summary>FieldPath shows the path of the field whose value will be used.</summary>
    [JsonPropertyName("fieldPath")]
    public string? FieldPath { get; set; }

    /// <summary>MatchCondition specifies the condition you'd like to match if you're using "MatchCondition" type.</summary>
    [JsonPropertyName("matchCondition")]
    public V1CompositionRevisionSpecResourcesReadinessChecksMatchCondition? MatchCondition { get; set; }

    /// <summary>MatchInt is the value you'd like to match if you're using "MatchInt" type.</summary>
    [JsonPropertyName("matchInteger")]
    public long? MatchInteger { get; set; }

    /// <summary>MatchString is the value you'd like to match if you're using "MatchString" type.</summary>
    [JsonPropertyName("matchString")]
    public string? MatchString { get; set; }

    /// <summary>Type indicates the type of probe you'd like to use.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>ComposedTemplate is used to provide information about how the composed resource should be processed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpecResources
{
    /// <summary>Base is the target resource that the patches will be applied on.</summary>
    [JsonPropertyName("base")]
    public JsonNode Base { get; set; }

    /// <summary>ConnectionDetails lists the propagation secret keys from this target resource to the composition instance connection secret.</summary>
    [JsonPropertyName("connectionDetails")]
    public IList<V1CompositionRevisionSpecResourcesConnectionDetails>? ConnectionDetails { get; set; }

    /// <summary>A Name uniquely identifies this entry within its Composition's resources array. Names are optional but *strongly* recommended. When all entries in the resources array are named entries may added, deleted, and reordered as long as their names do not change. When entries are not named the length and order of the resources array should be treated as immutable. Either all or no entries must be named.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Patches will be applied as overlay to the base resource.</summary>
    [JsonPropertyName("patches")]
    public IList<V1CompositionRevisionSpecResourcesPatches>? Patches { get; set; }

    /// <summary>ReadinessChecks allows users to define custom readiness checks. All checks have to return true in order for resource to be considered ready. The default readiness check is to have the "Ready" condition to be "True".</summary>
    [JsonPropertyName("readinessChecks")]
    public IList<V1CompositionRevisionSpecResourcesReadinessChecks>? ReadinessChecks { get; set; }
}

/// <summary>CompositionRevisionSpec specifies the desired state of the composition revision.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionSpec
{
    /// <summary>CompositeTypeRef specifies the type of composite resource that this composition is compatible with.</summary>
    [JsonPropertyName("compositeTypeRef")]
    public V1CompositionRevisionSpecCompositeTypeRef CompositeTypeRef { get; set; }

    /// <summary>Mode controls what type or "mode" of Composition will be used.   "Pipeline" indicates that a Composition specifies a pipeline of Composition Functions, each of which is responsible for producing composed resources that Crossplane should create or update.   "Resources" indicates that a Composition uses what is commonly referred to as "Patch &amp; Transform" or P&amp;T composition. This mode of Composition uses an array of resources, each a template for a composed resource.   All Compositions should use Pipeline mode. Resources mode is deprecated. Resources mode won't be removed in Crossplane 1.x, and will remain the default to avoid breaking legacy Compositions. However, it's no longer accepting new features, and only accepting security related bug fixes.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>PatchSets define a named set of patches that may be included by any resource in this Composition. PatchSets cannot themselves refer to other PatchSets.   PatchSets are only used by the "Resources" mode of Composition. They are ignored by other modes.   Deprecated: Use Composition Functions instead.</summary>
    [JsonPropertyName("patchSets")]
    public IList<V1CompositionRevisionSpecPatchSets>? PatchSets { get; set; }

    /// <summary>Pipeline is a list of composition function steps that will be used when a composite resource referring to this composition is created. One of resources and pipeline must be specified - you cannot specify both.   The Pipeline is only used by the "Pipeline" mode of Composition. It is ignored by other modes.</summary>
    [JsonPropertyName("pipeline")]
    public IList<V1CompositionRevisionSpecPipeline>? Pipeline { get; set; }

    /// <summary>PublishConnectionDetailsWithStoreConfig specifies the secret store config with which the connection details of composite resources dynamically provisioned using this composition will be published.   THIS IS AN ALPHA FIELD. Do not use it in production. It is not honored unless the relevant Crossplane feature flag is enabled, and may be changed or removed without notice.</summary>
    [JsonPropertyName("publishConnectionDetailsWithStoreConfigRef")]
    public V1CompositionRevisionSpecPublishConnectionDetailsWithStoreConfigRef? PublishConnectionDetailsWithStoreConfigRef { get; set; }

    /// <summary>Resources is a list of resource templates that will be used when a composite resource referring to this composition is created.   Resources are only used by the "Resources" mode of Composition. They are ignored by other modes.   Deprecated: Use Composition Functions instead.</summary>
    [JsonPropertyName("resources")]
    public IList<V1CompositionRevisionSpecResources>? Resources { get; set; }

    /// <summary>Revision number. Newer revisions have larger numbers.   This number can change. When a Composition transitions from state A -&gt; B -&gt; A there will be only two CompositionRevisions. Crossplane will edit the original CompositionRevision to change its revision number from 0 to 2.</summary>
    [JsonPropertyName("revision")]
    public long Revision { get; set; }

    /// <summary>WriteConnectionSecretsToNamespace specifies the namespace in which the connection secrets of composite resource dynamically provisioned using this composition will be created. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsWithStoreConfigRef. Currently, both could be set independently and connection details would be published to both without affecting each other as long as related fields at MR level specified.</summary>
    [JsonPropertyName("writeConnectionSecretsToNamespace")]
    public string? WriteConnectionSecretsToNamespace { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionStatusConditions
{
    /// <summary>LastTransitionTime is the last time this condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>A Message containing details about this condition's last transition from one status to another, if any.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition's last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of this condition. At most one of each condition type may apply to a resource at any point in time.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>CompositionRevisionStatus shows the observed state of the composition revision.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionRevisionStatus
{
    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1CompositionRevisionStatusConditions>? Conditions { get; set; }
}

/// <summary>A CompositionRevision represents a revision of a Composition. Crossplane creates new revisions when there are changes to the Composition.   Crossplane creates and manages CompositionRevisions. Don't directly edit CompositionRevisions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1CompositionRevision : IKubernetesObject<V1ObjectMeta>, ISpec<V1CompositionRevisionSpec>, IStatus<V1CompositionRevisionStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "CompositionRevision";
    public const string KubeGroup = "apiextensions.crossplane.io";
    public const string KubePluralName = "compositionrevisions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CompositionRevisionSpec specifies the desired state of the composition revision.</summary>
    [JsonPropertyName("spec")]
    public V1CompositionRevisionSpec? Spec { get; set; }

    /// <summary>CompositionRevisionStatus shows the observed state of the composition revision.</summary>
    [JsonPropertyName("status")]
    public V1CompositionRevisionStatus? Status { get; set; }
}