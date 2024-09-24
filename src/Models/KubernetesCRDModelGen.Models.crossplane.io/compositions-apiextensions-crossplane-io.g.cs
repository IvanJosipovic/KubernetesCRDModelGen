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
public partial class V1CompositionSpecCompositeTypeRef
{
    /// <summary>APIVersion of the type.</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary>Kind of the type.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }
}

/// <summary>Ref is a named reference to a single EnvironmentConfig. Either Ref or Selector is required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecEnvironmentEnvironmentConfigsRef
{
    /// <summary>The name of the object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecEnvironmentEnvironmentConfigsSelectorMatchLabelsFromFieldPathPolicyEnum
{
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional,
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecEnvironmentEnvironmentConfigsSelectorMatchLabelsTypeEnum
{
    [EnumMember(Value = "FromCompositeFieldPath"), JsonStringEnumMemberName("FromCompositeFieldPath")]
    /// <summary>FromCompositeFieldPath</summary>
    FromCompositeFieldPath,
    [EnumMember(Value = "Value"), JsonStringEnumMemberName("Value")]
    /// <summary>Value</summary>
    Value
}

/// <summary>An EnvironmentSourceSelectorLabelMatcher acts like a k8s label selector but can draw the label value from a different path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecEnvironmentEnvironmentConfigsSelectorMatchLabels
{
    /// <summary>FromFieldPathPolicy specifies the policy for the valueFromFieldPath. The default is Required, meaning that an error will be returned if the field is not found in the composite resource. Optional means that if the field is not found in the composite resource, that label pair will just be skipped. N.B. other specified label matchers will still be used to retrieve the desired environment config, if any.</summary>
    [JsonPropertyName("fromFieldPathPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecEnvironmentEnvironmentConfigsSelectorMatchLabelsFromFieldPathPolicyEnum>))]
    public V1CompositionSpecEnvironmentEnvironmentConfigsSelectorMatchLabelsFromFieldPathPolicyEnum? FromFieldPathPolicy { get; set; }

    /// <summary>Key of the label to match.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Type specifies where the value for a label comes from.</summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecEnvironmentEnvironmentConfigsSelectorMatchLabelsTypeEnum>))]
    public V1CompositionSpecEnvironmentEnvironmentConfigsSelectorMatchLabelsTypeEnum? Type { get; set; }

    /// <summary>Value specifies a literal label value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFromFieldPath specifies the field path to look for the label value.</summary>
    [JsonPropertyName("valueFromFieldPath")]
    public string? ValueFromFieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecEnvironmentEnvironmentConfigsSelectorModeEnum
{
    [EnumMember(Value = "Single"), JsonStringEnumMemberName("Single")]
    /// <summary>Single</summary>
    Single,
    [EnumMember(Value = "Multiple"), JsonStringEnumMemberName("Multiple")]
    /// <summary>Multiple</summary>
    Multiple
}

/// <summary>Selector selects EnvironmentConfig(s) via labels.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecEnvironmentEnvironmentConfigsSelector
{
    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IList<V1CompositionSpecEnvironmentEnvironmentConfigsSelectorMatchLabels>? MatchLabels { get; set; }

    /// <summary>MaxMatch specifies the number of extracted EnvironmentConfigs in Multiple mode, extracts all if nil.</summary>
    [JsonPropertyName("maxMatch")]
    public long? MaxMatch { get; set; }

    /// <summary>MinMatch specifies the required minimum of extracted EnvironmentConfigs in Multiple mode.</summary>
    [JsonPropertyName("minMatch")]
    public long? MinMatch { get; set; }

    /// <summary>Mode specifies retrieval strategy: "Single" or "Multiple".</summary>
    [JsonPropertyName("mode")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecEnvironmentEnvironmentConfigsSelectorModeEnum>))]
    public V1CompositionSpecEnvironmentEnvironmentConfigsSelectorModeEnum? Mode { get; set; }

    /// <summary>SortByFieldPath is the path to the field based on which list of EnvironmentConfigs is alphabetically sorted.</summary>
    [JsonPropertyName("sortByFieldPath")]
    public string? SortByFieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecEnvironmentEnvironmentConfigsTypeEnum
{
    [EnumMember(Value = "Reference"), JsonStringEnumMemberName("Reference")]
    /// <summary>Reference</summary>
    Reference,
    [EnumMember(Value = "Selector"), JsonStringEnumMemberName("Selector")]
    /// <summary>Selector</summary>
    Selector
}

/// <summary>EnvironmentSource selects a EnvironmentConfig resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecEnvironmentEnvironmentConfigs
{
    /// <summary>Ref is a named reference to a single EnvironmentConfig. Either Ref or Selector is required.</summary>
    [JsonPropertyName("ref")]
    public V1CompositionSpecEnvironmentEnvironmentConfigsRef? Ref { get; set; }

    /// <summary>Selector selects EnvironmentConfig(s) via labels.</summary>
    [JsonPropertyName("selector")]
    public V1CompositionSpecEnvironmentEnvironmentConfigsSelector? Selector { get; set; }

    /// <summary>Type specifies the way the EnvironmentConfig is selected. Default is `Reference`</summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecEnvironmentEnvironmentConfigsTypeEnum>))]
    public V1CompositionSpecEnvironmentEnvironmentConfigsTypeEnum? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecEnvironmentPatchesCombineStrategyEnum
{
    [EnumMember(Value = "string"), JsonStringEnumMemberName("string")]
    /// <summary>string</summary>
    String
}

/// <summary>String declares that input variables should be combined into a single string, using the relevant settings for formatting purposes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecEnvironmentPatchesCombineString
{
    /// <summary>Format the input using a Go format string. See https://golang.org/pkg/fmt/ for details.</summary>
    [JsonPropertyName("fmt")]
    public string Fmt { get; set; }
}

/// <summary>A CombineVariable defines the source of a value that is combined with others to form and patch an output value. Currently, this only supports retrieving values from a field path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecEnvironmentPatchesCombineVariables
{
    /// <summary>FromFieldPath is the path of the field on the source whose value is to be used as input.</summary>
    [JsonPropertyName("fromFieldPath")]
    public string FromFieldPath { get; set; }
}

/// <summary>Combine is the patch configuration for a CombineFromComposite or CombineToComposite patch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecEnvironmentPatchesCombine
{
    /// <summary>Strategy defines the strategy to use to combine the input variable values. Currently only string is supported.</summary>
    [JsonPropertyName("strategy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecEnvironmentPatchesCombineStrategyEnum>))]
    public V1CompositionSpecEnvironmentPatchesCombineStrategyEnum Strategy { get; set; }

    /// <summary>String declares that input variables should be combined into a single string, using the relevant settings for formatting purposes.</summary>
    [JsonPropertyName("string")]
    public V1CompositionSpecEnvironmentPatchesCombineString? String { get; set; }

    /// <summary>Variables are the list of variables whose values will be retrieved and combined.</summary>
    [JsonPropertyName("variables")]
    public IList<V1CompositionSpecEnvironmentPatchesCombineVariables> Variables { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecEnvironmentPatchesPolicyFromFieldPathEnum
{
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional,
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required
}

/// <summary>MergeOptions Specifies merge options on a field path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecEnvironmentPatchesPolicyMergeOptions
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
public partial class V1CompositionSpecEnvironmentPatchesPolicy
{
    /// <summary>FromFieldPath specifies how to patch from a field path. The default is 'Optional', which means the patch will be a no-op if the specified fromFieldPath does not exist. Use 'Required' if the patch should fail if the specified path does not exist.</summary>
    [JsonPropertyName("fromFieldPath")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecEnvironmentPatchesPolicyFromFieldPathEnum>))]
    public V1CompositionSpecEnvironmentPatchesPolicyFromFieldPathEnum? FromFieldPath { get; set; }

    /// <summary>MergeOptions Specifies merge options on a field path.</summary>
    [JsonPropertyName("mergeOptions")]
    public V1CompositionSpecEnvironmentPatchesPolicyMergeOptions? MergeOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecEnvironmentPatchesTransformsConvertFormatEnum
{
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    /// <summary>none</summary>
    None,
    [EnumMember(Value = "quantity"), JsonStringEnumMemberName("quantity")]
    /// <summary>quantity</summary>
    Quantity,
    [EnumMember(Value = "json"), JsonStringEnumMemberName("json")]
    /// <summary>json</summary>
    Json
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecEnvironmentPatchesTransformsConvertToTypeEnum
{
    [EnumMember(Value = "string"), JsonStringEnumMemberName("string")]
    /// <summary>string</summary>
    String,
    [EnumMember(Value = "int"), JsonStringEnumMemberName("int")]
    /// <summary>int</summary>
    Int,
    [EnumMember(Value = "int64"), JsonStringEnumMemberName("int64")]
    /// <summary>int64</summary>
    Int64,
    [EnumMember(Value = "bool"), JsonStringEnumMemberName("bool")]
    /// <summary>bool</summary>
    Bool,
    [EnumMember(Value = "float64"), JsonStringEnumMemberName("float64")]
    /// <summary>float64</summary>
    Float64,
    [EnumMember(Value = "object"), JsonStringEnumMemberName("object")]
    /// <summary>object</summary>
    Object,
    [EnumMember(Value = "array"), JsonStringEnumMemberName("array")]
    /// <summary>array</summary>
    Array
}

/// <summary>Convert is used to cast the input into the given output type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecEnvironmentPatchesTransformsConvert
{
    /// <summary>The expected input format.   * `quantity` - parses the input as a K8s [`resource.Quantity`](https://pkg.go.dev/k8s.io/apimachinery/pkg/api/resource#Quantity). Only used during `string -&gt; float64` conversions. * `json` - parses the input as a JSON string. Only used during `string -&gt; object` or `string -&gt; list` conversions.   If this property is null, the default conversion is applied.</summary>
    [JsonPropertyName("format")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecEnvironmentPatchesTransformsConvertFormatEnum>))]
    public V1CompositionSpecEnvironmentPatchesTransformsConvertFormatEnum? Format { get; set; }

    /// <summary>ToType is the type of the output of this transform.</summary>
    [JsonPropertyName("toType")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecEnvironmentPatchesTransformsConvertToTypeEnum>))]
    public V1CompositionSpecEnvironmentPatchesTransformsConvertToTypeEnum ToType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecEnvironmentPatchesTransformsMatchFallbackToEnum
{
    [EnumMember(Value = "Value"), JsonStringEnumMemberName("Value")]
    /// <summary>Value</summary>
    Value,
    [EnumMember(Value = "Input"), JsonStringEnumMemberName("Input")]
    /// <summary>Input</summary>
    Input
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecEnvironmentPatchesTransformsMatchPatternsTypeEnum
{
    [EnumMember(Value = "literal"), JsonStringEnumMemberName("literal")]
    /// <summary>literal</summary>
    Literal,
    [EnumMember(Value = "regexp"), JsonStringEnumMemberName("regexp")]
    /// <summary>regexp</summary>
    Regexp
}

/// <summary>MatchTransformPattern is a transform that returns the value that matches a pattern.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecEnvironmentPatchesTransformsMatchPatterns
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
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecEnvironmentPatchesTransformsMatchPatternsTypeEnum>))]
    public V1CompositionSpecEnvironmentPatchesTransformsMatchPatternsTypeEnum Type { get; set; }
}

/// <summary>Match is a more complex version of Map that matches a list of patterns.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecEnvironmentPatchesTransformsMatch
{
    /// <summary>Determines to what value the transform should fallback if no pattern matches.</summary>
    [JsonPropertyName("fallbackTo")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecEnvironmentPatchesTransformsMatchFallbackToEnum>))]
    public V1CompositionSpecEnvironmentPatchesTransformsMatchFallbackToEnum? FallbackTo { get; set; }

    /// <summary>The fallback value that should be returned by the transform if now pattern matches.</summary>
    [JsonPropertyName("fallbackValue")]
    public JsonNode? FallbackValue { get; set; }

    /// <summary>The patterns that should be tested against the input string. Patterns are tested in order. The value of the first match is used as result of this transform.</summary>
    [JsonPropertyName("patterns")]
    public IList<V1CompositionSpecEnvironmentPatchesTransformsMatchPatterns>? Patterns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecEnvironmentPatchesTransformsMathTypeEnum
{
    [EnumMember(Value = "Multiply"), JsonStringEnumMemberName("Multiply")]
    /// <summary>Multiply</summary>
    Multiply,
    [EnumMember(Value = "ClampMin"), JsonStringEnumMemberName("ClampMin")]
    /// <summary>ClampMin</summary>
    ClampMin,
    [EnumMember(Value = "ClampMax"), JsonStringEnumMemberName("ClampMax")]
    /// <summary>ClampMax</summary>
    ClampMax
}

/// <summary>Math is used to transform the input via mathematical operations such as multiplication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecEnvironmentPatchesTransformsMath
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
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecEnvironmentPatchesTransformsMathTypeEnum>))]
    public V1CompositionSpecEnvironmentPatchesTransformsMathTypeEnum? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecEnvironmentPatchesTransformsStringConvertEnum
{
    [EnumMember(Value = "ToUpper"), JsonStringEnumMemberName("ToUpper")]
    /// <summary>ToUpper</summary>
    ToUpper,
    [EnumMember(Value = "ToLower"), JsonStringEnumMemberName("ToLower")]
    /// <summary>ToLower</summary>
    ToLower,
    [EnumMember(Value = "ToBase64"), JsonStringEnumMemberName("ToBase64")]
    /// <summary>ToBase64</summary>
    ToBase64,
    [EnumMember(Value = "FromBase64"), JsonStringEnumMemberName("FromBase64")]
    /// <summary>FromBase64</summary>
    FromBase64,
    [EnumMember(Value = "ToJson"), JsonStringEnumMemberName("ToJson")]
    /// <summary>ToJson</summary>
    ToJson,
    [EnumMember(Value = "ToSha1"), JsonStringEnumMemberName("ToSha1")]
    /// <summary>ToSha1</summary>
    ToSha1,
    [EnumMember(Value = "ToSha256"), JsonStringEnumMemberName("ToSha256")]
    /// <summary>ToSha256</summary>
    ToSha256,
    [EnumMember(Value = "ToSha512"), JsonStringEnumMemberName("ToSha512")]
    /// <summary>ToSha512</summary>
    ToSha512,
    [EnumMember(Value = "ToAdler32"), JsonStringEnumMemberName("ToAdler32")]
    /// <summary>ToAdler32</summary>
    ToAdler32
}

/// <summary>Join defines parameters to join a slice of values to a string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecEnvironmentPatchesTransformsStringJoin
{
    /// <summary>Separator defines the character that should separate the values from each other in the joined string.</summary>
    [JsonPropertyName("separator")]
    public string Separator { get; set; }
}

/// <summary>Extract a match from the input using a regular expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecEnvironmentPatchesTransformsStringRegexp
{
    /// <summary>Group number to match. 0 (the default) matches the entire expression.</summary>
    [JsonPropertyName("group")]
    public int? Group { get; set; }

    /// <summary>Match string. May optionally include submatches, aka capture groups. See https://pkg.go.dev/regexp/ for details.</summary>
    [JsonPropertyName("match")]
    public string Match { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecEnvironmentPatchesTransformsStringTypeEnum
{
    [EnumMember(Value = "Format"), JsonStringEnumMemberName("Format")]
    /// <summary>Format</summary>
    Format,
    [EnumMember(Value = "Convert"), JsonStringEnumMemberName("Convert")]
    /// <summary>Convert</summary>
    Convert,
    [EnumMember(Value = "TrimPrefix"), JsonStringEnumMemberName("TrimPrefix")]
    /// <summary>TrimPrefix</summary>
    TrimPrefix,
    [EnumMember(Value = "TrimSuffix"), JsonStringEnumMemberName("TrimSuffix")]
    /// <summary>TrimSuffix</summary>
    TrimSuffix,
    [EnumMember(Value = "Regexp"), JsonStringEnumMemberName("Regexp")]
    /// <summary>Regexp</summary>
    Regexp,
    [EnumMember(Value = "Join"), JsonStringEnumMemberName("Join")]
    /// <summary>Join</summary>
    Join
}

/// <summary>String is used to transform the input into a string or a different kind of string. Note that the input does not necessarily need to be a string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecEnvironmentPatchesTransformsString
{
    /// <summary>Optional conversion method to be specified. `ToUpper` and `ToLower` change the letter case of the input string. `ToBase64` and `FromBase64` perform a base64 conversion based on the input string. `ToJson` converts any input value into its raw JSON representation. `ToSha1`, `ToSha256` and `ToSha512` generate a hash value based on the input converted to JSON. `ToAdler32` generate a addler32 hash based on the input string.</summary>
    [JsonPropertyName("convert")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecEnvironmentPatchesTransformsStringConvertEnum>))]
    public V1CompositionSpecEnvironmentPatchesTransformsStringConvertEnum? Convert { get; set; }

    /// <summary>Format the input using a Go format string. See https://golang.org/pkg/fmt/ for details.</summary>
    [JsonPropertyName("fmt")]
    public string? Fmt { get; set; }

    /// <summary>Join defines parameters to join a slice of values to a string.</summary>
    [JsonPropertyName("join")]
    public V1CompositionSpecEnvironmentPatchesTransformsStringJoin? Join { get; set; }

    /// <summary>Extract a match from the input using a regular expression.</summary>
    [JsonPropertyName("regexp")]
    public V1CompositionSpecEnvironmentPatchesTransformsStringRegexp? Regexp { get; set; }

    /// <summary>Trim the prefix or suffix from the input</summary>
    [JsonPropertyName("trim")]
    public string? Trim { get; set; }

    /// <summary>Type of the string transform to be run.</summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecEnvironmentPatchesTransformsStringTypeEnum>))]
    public V1CompositionSpecEnvironmentPatchesTransformsStringTypeEnum? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecEnvironmentPatchesTransformsTypeEnum
{
    [EnumMember(Value = "map"), JsonStringEnumMemberName("map")]
    /// <summary>map</summary>
    Map,
    [EnumMember(Value = "match"), JsonStringEnumMemberName("match")]
    /// <summary>match</summary>
    Match,
    [EnumMember(Value = "math"), JsonStringEnumMemberName("math")]
    /// <summary>math</summary>
    Math,
    [EnumMember(Value = "string"), JsonStringEnumMemberName("string")]
    /// <summary>string</summary>
    String,
    [EnumMember(Value = "convert"), JsonStringEnumMemberName("convert")]
    /// <summary>convert</summary>
    Convert
}

/// <summary>Transform is a unit of process whose input is transformed into an output with the supplied configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecEnvironmentPatchesTransforms
{
    /// <summary>Convert is used to cast the input into the given output type.</summary>
    [JsonPropertyName("convert")]
    public V1CompositionSpecEnvironmentPatchesTransformsConvert? Convert { get; set; }

    /// <summary>Map uses the input as a key in the given map and returns the value.</summary>
    [JsonPropertyName("map")]
    public IDictionary<string, JsonNode>? Map { get; set; }

    /// <summary>Match is a more complex version of Map that matches a list of patterns.</summary>
    [JsonPropertyName("match")]
    public V1CompositionSpecEnvironmentPatchesTransformsMatch? Match { get; set; }

    /// <summary>Math is used to transform the input via mathematical operations such as multiplication.</summary>
    [JsonPropertyName("math")]
    public V1CompositionSpecEnvironmentPatchesTransformsMath? Math { get; set; }

    /// <summary>String is used to transform the input into a string or a different kind of string. Note that the input does not necessarily need to be a string.</summary>
    [JsonPropertyName("string")]
    public V1CompositionSpecEnvironmentPatchesTransformsString? String { get; set; }

    /// <summary>Type of the transform to be run.</summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecEnvironmentPatchesTransformsTypeEnum>))]
    public V1CompositionSpecEnvironmentPatchesTransformsTypeEnum Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecEnvironmentPatchesTypeEnum
{
    [EnumMember(Value = "FromCompositeFieldPath"), JsonStringEnumMemberName("FromCompositeFieldPath")]
    /// <summary>FromCompositeFieldPath</summary>
    FromCompositeFieldPath,
    [EnumMember(Value = "ToCompositeFieldPath"), JsonStringEnumMemberName("ToCompositeFieldPath")]
    /// <summary>ToCompositeFieldPath</summary>
    ToCompositeFieldPath,
    [EnumMember(Value = "CombineFromComposite"), JsonStringEnumMemberName("CombineFromComposite")]
    /// <summary>CombineFromComposite</summary>
    CombineFromComposite,
    [EnumMember(Value = "CombineToComposite"), JsonStringEnumMemberName("CombineToComposite")]
    /// <summary>CombineToComposite</summary>
    CombineToComposite
}

/// <summary>EnvironmentPatch is a patch for a Composition environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecEnvironmentPatches
{
    /// <summary>Combine is the patch configuration for a CombineFromComposite or CombineToComposite patch.</summary>
    [JsonPropertyName("combine")]
    public V1CompositionSpecEnvironmentPatchesCombine? Combine { get; set; }

    /// <summary>FromFieldPath is the path of the field on the resource whose value is to be used as input. Required when type is FromCompositeFieldPath or ToCompositeFieldPath.</summary>
    [JsonPropertyName("fromFieldPath")]
    public string? FromFieldPath { get; set; }

    /// <summary>Policy configures the specifics of patching behaviour.</summary>
    [JsonPropertyName("policy")]
    public V1CompositionSpecEnvironmentPatchesPolicy? Policy { get; set; }

    /// <summary>ToFieldPath is the path of the field on the resource whose value will be changed with the result of transforms. Leave empty if you'd like to propagate to the same path as fromFieldPath.</summary>
    [JsonPropertyName("toFieldPath")]
    public string? ToFieldPath { get; set; }

    /// <summary>Transforms are the list of functions that are used as a FIFO pipe for the input to be transformed.</summary>
    [JsonPropertyName("transforms")]
    public IList<V1CompositionSpecEnvironmentPatchesTransforms>? Transforms { get; set; }

    /// <summary>Type sets the patching behaviour to be used. Each patch type may require its own fields to be set on the Patch object.</summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecEnvironmentPatchesTypeEnum>))]
    public V1CompositionSpecEnvironmentPatchesTypeEnum? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecEnvironmentPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecEnvironmentPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policy represents the Resolve and Resolution policies which apply to all EnvironmentSourceReferences in EnvironmentConfigs list.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecEnvironmentPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecEnvironmentPolicyResolutionEnum>))]
    public V1CompositionSpecEnvironmentPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecEnvironmentPolicyResolveEnum>))]
    public V1CompositionSpecEnvironmentPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Environment configures the environment in which resources are rendered.   THIS IS AN ALPHA FIELD. Do not use it in production. It is not honored unless the relevant Crossplane feature flag is enabled, and may be changed or removed without notice.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecEnvironment
{
    /// <summary>DefaultData statically defines the initial state of the environment. It has the same schema-less structure as the data field in environment configs. It is overwritten by the selected environment configs.</summary>
    [JsonPropertyName("defaultData")]
    public IDictionary<string, JsonNode>? DefaultData { get; set; }

    /// <summary>EnvironmentConfigs selects a list of `EnvironmentConfig`s. The resolved resources are stored in the composite resource at `spec.environmentConfigRefs` and is only updated if it is null.   The list of references is used to compute an in-memory environment at compose time. The data of all object is merged in the order they are listed, meaning the values of EnvironmentConfigs with a larger index take priority over ones with smaller indices.   The computed environment can be accessed in a composition using `FromEnvironmentFieldPath` and `CombineFromEnvironment` patches.</summary>
    [JsonPropertyName("environmentConfigs")]
    public IList<V1CompositionSpecEnvironmentEnvironmentConfigs>? EnvironmentConfigs { get; set; }

    /// <summary>Patches is a list of environment patches that are executed before a composition's resources are composed.</summary>
    [JsonPropertyName("patches")]
    public IList<V1CompositionSpecEnvironmentPatches>? Patches { get; set; }

    /// <summary>Policy represents the Resolve and Resolution policies which apply to all EnvironmentSourceReferences in EnvironmentConfigs list.</summary>
    [JsonPropertyName("policy")]
    public V1CompositionSpecEnvironmentPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecModeEnum
{
    [EnumMember(Value = "Resources"), JsonStringEnumMemberName("Resources")]
    /// <summary>Resources</summary>
    Resources,
    [EnumMember(Value = "Pipeline"), JsonStringEnumMemberName("Pipeline")]
    /// <summary>Pipeline</summary>
    Pipeline
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecPatchSetsPatchesCombineStrategyEnum
{
    [EnumMember(Value = "string"), JsonStringEnumMemberName("string")]
    /// <summary>string</summary>
    String
}

/// <summary>String declares that input variables should be combined into a single string, using the relevant settings for formatting purposes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecPatchSetsPatchesCombineString
{
    /// <summary>Format the input using a Go format string. See https://golang.org/pkg/fmt/ for details.</summary>
    [JsonPropertyName("fmt")]
    public string Fmt { get; set; }
}

/// <summary>A CombineVariable defines the source of a value that is combined with others to form and patch an output value. Currently, this only supports retrieving values from a field path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecPatchSetsPatchesCombineVariables
{
    /// <summary>FromFieldPath is the path of the field on the source whose value is to be used as input.</summary>
    [JsonPropertyName("fromFieldPath")]
    public string FromFieldPath { get; set; }
}

/// <summary>Combine is the patch configuration for a CombineFromComposite, CombineFromEnvironment, CombineToComposite or CombineToEnvironment patch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecPatchSetsPatchesCombine
{
    /// <summary>Strategy defines the strategy to use to combine the input variable values. Currently only string is supported.</summary>
    [JsonPropertyName("strategy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecPatchSetsPatchesCombineStrategyEnum>))]
    public V1CompositionSpecPatchSetsPatchesCombineStrategyEnum Strategy { get; set; }

    /// <summary>String declares that input variables should be combined into a single string, using the relevant settings for formatting purposes.</summary>
    [JsonPropertyName("string")]
    public V1CompositionSpecPatchSetsPatchesCombineString? String { get; set; }

    /// <summary>Variables are the list of variables whose values will be retrieved and combined.</summary>
    [JsonPropertyName("variables")]
    public IList<V1CompositionSpecPatchSetsPatchesCombineVariables> Variables { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecPatchSetsPatchesPolicyFromFieldPathEnum
{
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional,
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required
}

/// <summary>MergeOptions Specifies merge options on a field path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecPatchSetsPatchesPolicyMergeOptions
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
public partial class V1CompositionSpecPatchSetsPatchesPolicy
{
    /// <summary>FromFieldPath specifies how to patch from a field path. The default is 'Optional', which means the patch will be a no-op if the specified fromFieldPath does not exist. Use 'Required' if the patch should fail if the specified path does not exist.</summary>
    [JsonPropertyName("fromFieldPath")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecPatchSetsPatchesPolicyFromFieldPathEnum>))]
    public V1CompositionSpecPatchSetsPatchesPolicyFromFieldPathEnum? FromFieldPath { get; set; }

    /// <summary>MergeOptions Specifies merge options on a field path.</summary>
    [JsonPropertyName("mergeOptions")]
    public V1CompositionSpecPatchSetsPatchesPolicyMergeOptions? MergeOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecPatchSetsPatchesTransformsConvertFormatEnum
{
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    /// <summary>none</summary>
    None,
    [EnumMember(Value = "quantity"), JsonStringEnumMemberName("quantity")]
    /// <summary>quantity</summary>
    Quantity,
    [EnumMember(Value = "json"), JsonStringEnumMemberName("json")]
    /// <summary>json</summary>
    Json
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecPatchSetsPatchesTransformsConvertToTypeEnum
{
    [EnumMember(Value = "string"), JsonStringEnumMemberName("string")]
    /// <summary>string</summary>
    String,
    [EnumMember(Value = "int"), JsonStringEnumMemberName("int")]
    /// <summary>int</summary>
    Int,
    [EnumMember(Value = "int64"), JsonStringEnumMemberName("int64")]
    /// <summary>int64</summary>
    Int64,
    [EnumMember(Value = "bool"), JsonStringEnumMemberName("bool")]
    /// <summary>bool</summary>
    Bool,
    [EnumMember(Value = "float64"), JsonStringEnumMemberName("float64")]
    /// <summary>float64</summary>
    Float64,
    [EnumMember(Value = "object"), JsonStringEnumMemberName("object")]
    /// <summary>object</summary>
    Object,
    [EnumMember(Value = "array"), JsonStringEnumMemberName("array")]
    /// <summary>array</summary>
    Array
}

/// <summary>Convert is used to cast the input into the given output type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecPatchSetsPatchesTransformsConvert
{
    /// <summary>The expected input format.   * `quantity` - parses the input as a K8s [`resource.Quantity`](https://pkg.go.dev/k8s.io/apimachinery/pkg/api/resource#Quantity). Only used during `string -&gt; float64` conversions. * `json` - parses the input as a JSON string. Only used during `string -&gt; object` or `string -&gt; list` conversions.   If this property is null, the default conversion is applied.</summary>
    [JsonPropertyName("format")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecPatchSetsPatchesTransformsConvertFormatEnum>))]
    public V1CompositionSpecPatchSetsPatchesTransformsConvertFormatEnum? Format { get; set; }

    /// <summary>ToType is the type of the output of this transform.</summary>
    [JsonPropertyName("toType")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecPatchSetsPatchesTransformsConvertToTypeEnum>))]
    public V1CompositionSpecPatchSetsPatchesTransformsConvertToTypeEnum ToType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecPatchSetsPatchesTransformsMatchFallbackToEnum
{
    [EnumMember(Value = "Value"), JsonStringEnumMemberName("Value")]
    /// <summary>Value</summary>
    Value,
    [EnumMember(Value = "Input"), JsonStringEnumMemberName("Input")]
    /// <summary>Input</summary>
    Input
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecPatchSetsPatchesTransformsMatchPatternsTypeEnum
{
    [EnumMember(Value = "literal"), JsonStringEnumMemberName("literal")]
    /// <summary>literal</summary>
    Literal,
    [EnumMember(Value = "regexp"), JsonStringEnumMemberName("regexp")]
    /// <summary>regexp</summary>
    Regexp
}

/// <summary>MatchTransformPattern is a transform that returns the value that matches a pattern.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecPatchSetsPatchesTransformsMatchPatterns
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
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecPatchSetsPatchesTransformsMatchPatternsTypeEnum>))]
    public V1CompositionSpecPatchSetsPatchesTransformsMatchPatternsTypeEnum Type { get; set; }
}

/// <summary>Match is a more complex version of Map that matches a list of patterns.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecPatchSetsPatchesTransformsMatch
{
    /// <summary>Determines to what value the transform should fallback if no pattern matches.</summary>
    [JsonPropertyName("fallbackTo")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecPatchSetsPatchesTransformsMatchFallbackToEnum>))]
    public V1CompositionSpecPatchSetsPatchesTransformsMatchFallbackToEnum? FallbackTo { get; set; }

    /// <summary>The fallback value that should be returned by the transform if now pattern matches.</summary>
    [JsonPropertyName("fallbackValue")]
    public JsonNode? FallbackValue { get; set; }

    /// <summary>The patterns that should be tested against the input string. Patterns are tested in order. The value of the first match is used as result of this transform.</summary>
    [JsonPropertyName("patterns")]
    public IList<V1CompositionSpecPatchSetsPatchesTransformsMatchPatterns>? Patterns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecPatchSetsPatchesTransformsMathTypeEnum
{
    [EnumMember(Value = "Multiply"), JsonStringEnumMemberName("Multiply")]
    /// <summary>Multiply</summary>
    Multiply,
    [EnumMember(Value = "ClampMin"), JsonStringEnumMemberName("ClampMin")]
    /// <summary>ClampMin</summary>
    ClampMin,
    [EnumMember(Value = "ClampMax"), JsonStringEnumMemberName("ClampMax")]
    /// <summary>ClampMax</summary>
    ClampMax
}

/// <summary>Math is used to transform the input via mathematical operations such as multiplication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecPatchSetsPatchesTransformsMath
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
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecPatchSetsPatchesTransformsMathTypeEnum>))]
    public V1CompositionSpecPatchSetsPatchesTransformsMathTypeEnum? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecPatchSetsPatchesTransformsStringConvertEnum
{
    [EnumMember(Value = "ToUpper"), JsonStringEnumMemberName("ToUpper")]
    /// <summary>ToUpper</summary>
    ToUpper,
    [EnumMember(Value = "ToLower"), JsonStringEnumMemberName("ToLower")]
    /// <summary>ToLower</summary>
    ToLower,
    [EnumMember(Value = "ToBase64"), JsonStringEnumMemberName("ToBase64")]
    /// <summary>ToBase64</summary>
    ToBase64,
    [EnumMember(Value = "FromBase64"), JsonStringEnumMemberName("FromBase64")]
    /// <summary>FromBase64</summary>
    FromBase64,
    [EnumMember(Value = "ToJson"), JsonStringEnumMemberName("ToJson")]
    /// <summary>ToJson</summary>
    ToJson,
    [EnumMember(Value = "ToSha1"), JsonStringEnumMemberName("ToSha1")]
    /// <summary>ToSha1</summary>
    ToSha1,
    [EnumMember(Value = "ToSha256"), JsonStringEnumMemberName("ToSha256")]
    /// <summary>ToSha256</summary>
    ToSha256,
    [EnumMember(Value = "ToSha512"), JsonStringEnumMemberName("ToSha512")]
    /// <summary>ToSha512</summary>
    ToSha512,
    [EnumMember(Value = "ToAdler32"), JsonStringEnumMemberName("ToAdler32")]
    /// <summary>ToAdler32</summary>
    ToAdler32
}

/// <summary>Join defines parameters to join a slice of values to a string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecPatchSetsPatchesTransformsStringJoin
{
    /// <summary>Separator defines the character that should separate the values from each other in the joined string.</summary>
    [JsonPropertyName("separator")]
    public string Separator { get; set; }
}

/// <summary>Extract a match from the input using a regular expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecPatchSetsPatchesTransformsStringRegexp
{
    /// <summary>Group number to match. 0 (the default) matches the entire expression.</summary>
    [JsonPropertyName("group")]
    public int? Group { get; set; }

    /// <summary>Match string. May optionally include submatches, aka capture groups. See https://pkg.go.dev/regexp/ for details.</summary>
    [JsonPropertyName("match")]
    public string Match { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecPatchSetsPatchesTransformsStringTypeEnum
{
    [EnumMember(Value = "Format"), JsonStringEnumMemberName("Format")]
    /// <summary>Format</summary>
    Format,
    [EnumMember(Value = "Convert"), JsonStringEnumMemberName("Convert")]
    /// <summary>Convert</summary>
    Convert,
    [EnumMember(Value = "TrimPrefix"), JsonStringEnumMemberName("TrimPrefix")]
    /// <summary>TrimPrefix</summary>
    TrimPrefix,
    [EnumMember(Value = "TrimSuffix"), JsonStringEnumMemberName("TrimSuffix")]
    /// <summary>TrimSuffix</summary>
    TrimSuffix,
    [EnumMember(Value = "Regexp"), JsonStringEnumMemberName("Regexp")]
    /// <summary>Regexp</summary>
    Regexp,
    [EnumMember(Value = "Join"), JsonStringEnumMemberName("Join")]
    /// <summary>Join</summary>
    Join
}

/// <summary>String is used to transform the input into a string or a different kind of string. Note that the input does not necessarily need to be a string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecPatchSetsPatchesTransformsString
{
    /// <summary>Optional conversion method to be specified. `ToUpper` and `ToLower` change the letter case of the input string. `ToBase64` and `FromBase64` perform a base64 conversion based on the input string. `ToJson` converts any input value into its raw JSON representation. `ToSha1`, `ToSha256` and `ToSha512` generate a hash value based on the input converted to JSON. `ToAdler32` generate a addler32 hash based on the input string.</summary>
    [JsonPropertyName("convert")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecPatchSetsPatchesTransformsStringConvertEnum>))]
    public V1CompositionSpecPatchSetsPatchesTransformsStringConvertEnum? Convert { get; set; }

    /// <summary>Format the input using a Go format string. See https://golang.org/pkg/fmt/ for details.</summary>
    [JsonPropertyName("fmt")]
    public string? Fmt { get; set; }

    /// <summary>Join defines parameters to join a slice of values to a string.</summary>
    [JsonPropertyName("join")]
    public V1CompositionSpecPatchSetsPatchesTransformsStringJoin? Join { get; set; }

    /// <summary>Extract a match from the input using a regular expression.</summary>
    [JsonPropertyName("regexp")]
    public V1CompositionSpecPatchSetsPatchesTransformsStringRegexp? Regexp { get; set; }

    /// <summary>Trim the prefix or suffix from the input</summary>
    [JsonPropertyName("trim")]
    public string? Trim { get; set; }

    /// <summary>Type of the string transform to be run.</summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecPatchSetsPatchesTransformsStringTypeEnum>))]
    public V1CompositionSpecPatchSetsPatchesTransformsStringTypeEnum? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecPatchSetsPatchesTransformsTypeEnum
{
    [EnumMember(Value = "map"), JsonStringEnumMemberName("map")]
    /// <summary>map</summary>
    Map,
    [EnumMember(Value = "match"), JsonStringEnumMemberName("match")]
    /// <summary>match</summary>
    Match,
    [EnumMember(Value = "math"), JsonStringEnumMemberName("math")]
    /// <summary>math</summary>
    Math,
    [EnumMember(Value = "string"), JsonStringEnumMemberName("string")]
    /// <summary>string</summary>
    String,
    [EnumMember(Value = "convert"), JsonStringEnumMemberName("convert")]
    /// <summary>convert</summary>
    Convert
}

/// <summary>Transform is a unit of process whose input is transformed into an output with the supplied configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecPatchSetsPatchesTransforms
{
    /// <summary>Convert is used to cast the input into the given output type.</summary>
    [JsonPropertyName("convert")]
    public V1CompositionSpecPatchSetsPatchesTransformsConvert? Convert { get; set; }

    /// <summary>Map uses the input as a key in the given map and returns the value.</summary>
    [JsonPropertyName("map")]
    public IDictionary<string, JsonNode>? Map { get; set; }

    /// <summary>Match is a more complex version of Map that matches a list of patterns.</summary>
    [JsonPropertyName("match")]
    public V1CompositionSpecPatchSetsPatchesTransformsMatch? Match { get; set; }

    /// <summary>Math is used to transform the input via mathematical operations such as multiplication.</summary>
    [JsonPropertyName("math")]
    public V1CompositionSpecPatchSetsPatchesTransformsMath? Math { get; set; }

    /// <summary>String is used to transform the input into a string or a different kind of string. Note that the input does not necessarily need to be a string.</summary>
    [JsonPropertyName("string")]
    public V1CompositionSpecPatchSetsPatchesTransformsString? String { get; set; }

    /// <summary>Type of the transform to be run.</summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecPatchSetsPatchesTransformsTypeEnum>))]
    public V1CompositionSpecPatchSetsPatchesTransformsTypeEnum Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecPatchSetsPatchesTypeEnum
{
    [EnumMember(Value = "FromCompositeFieldPath"), JsonStringEnumMemberName("FromCompositeFieldPath")]
    /// <summary>FromCompositeFieldPath</summary>
    FromCompositeFieldPath,
    [EnumMember(Value = "FromEnvironmentFieldPath"), JsonStringEnumMemberName("FromEnvironmentFieldPath")]
    /// <summary>FromEnvironmentFieldPath</summary>
    FromEnvironmentFieldPath,
    [EnumMember(Value = "PatchSet"), JsonStringEnumMemberName("PatchSet")]
    /// <summary>PatchSet</summary>
    PatchSet,
    [EnumMember(Value = "ToCompositeFieldPath"), JsonStringEnumMemberName("ToCompositeFieldPath")]
    /// <summary>ToCompositeFieldPath</summary>
    ToCompositeFieldPath,
    [EnumMember(Value = "ToEnvironmentFieldPath"), JsonStringEnumMemberName("ToEnvironmentFieldPath")]
    /// <summary>ToEnvironmentFieldPath</summary>
    ToEnvironmentFieldPath,
    [EnumMember(Value = "CombineFromEnvironment"), JsonStringEnumMemberName("CombineFromEnvironment")]
    /// <summary>CombineFromEnvironment</summary>
    CombineFromEnvironment,
    [EnumMember(Value = "CombineFromComposite"), JsonStringEnumMemberName("CombineFromComposite")]
    /// <summary>CombineFromComposite</summary>
    CombineFromComposite,
    [EnumMember(Value = "CombineToComposite"), JsonStringEnumMemberName("CombineToComposite")]
    /// <summary>CombineToComposite</summary>
    CombineToComposite,
    [EnumMember(Value = "CombineToEnvironment"), JsonStringEnumMemberName("CombineToEnvironment")]
    /// <summary>CombineToEnvironment</summary>
    CombineToEnvironment
}

/// <summary>Patch objects are applied between composite and composed resources. Their behaviour depends on the Type selected. The default Type, FromCompositeFieldPath, copies a value from the composite resource to the composed resource, applying any defined transformers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecPatchSetsPatches
{
    /// <summary>Combine is the patch configuration for a CombineFromComposite, CombineFromEnvironment, CombineToComposite or CombineToEnvironment patch.</summary>
    [JsonPropertyName("combine")]
    public V1CompositionSpecPatchSetsPatchesCombine? Combine { get; set; }

    /// <summary>FromFieldPath is the path of the field on the resource whose value is to be used as input. Required when type is FromCompositeFieldPath, FromEnvironmentFieldPath, ToCompositeFieldPath, ToEnvironmentFieldPath.</summary>
    [JsonPropertyName("fromFieldPath")]
    public string? FromFieldPath { get; set; }

    /// <summary>PatchSetName to include patches from. Required when type is PatchSet.</summary>
    [JsonPropertyName("patchSetName")]
    public string? PatchSetName { get; set; }

    /// <summary>Policy configures the specifics of patching behaviour.</summary>
    [JsonPropertyName("policy")]
    public V1CompositionSpecPatchSetsPatchesPolicy? Policy { get; set; }

    /// <summary>ToFieldPath is the path of the field on the resource whose value will be changed with the result of transforms. Leave empty if you'd like to propagate to the same path as fromFieldPath.</summary>
    [JsonPropertyName("toFieldPath")]
    public string? ToFieldPath { get; set; }

    /// <summary>Transforms are the list of functions that are used as a FIFO pipe for the input to be transformed.</summary>
    [JsonPropertyName("transforms")]
    public IList<V1CompositionSpecPatchSetsPatchesTransforms>? Transforms { get; set; }

    /// <summary>Type sets the patching behaviour to be used. Each patch type may require its own fields to be set on the Patch object.</summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecPatchSetsPatchesTypeEnum>))]
    public V1CompositionSpecPatchSetsPatchesTypeEnum? Type { get; set; }
}

/// <summary>A PatchSet is a set of patches that can be reused from all resources within a Composition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecPatchSets
{
    /// <summary>Name of this PatchSet.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Patches will be applied as an overlay to the base resource.</summary>
    [JsonPropertyName("patches")]
    public IList<V1CompositionSpecPatchSetsPatches> Patches { get; set; }
}

/// <summary>A SecretRef is a reference to a secret containing credentials that should be supplied to the function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecPipelineCredentialsSecretRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecPipelineCredentialsSourceEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    /// <summary>None</summary>
    None,
    [EnumMember(Value = "Secret"), JsonStringEnumMemberName("Secret")]
    /// <summary>Secret</summary>
    Secret
}

/// <summary>FunctionCredentials are optional credentials that a Composition Function needs to run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecPipelineCredentials
{
    /// <summary>Name of this set of credentials.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>A SecretRef is a reference to a secret containing credentials that should be supplied to the function.</summary>
    [JsonPropertyName("secretRef")]
    public V1CompositionSpecPipelineCredentialsSecretRef? SecretRef { get; set; }

    /// <summary>Source of the function credentials.</summary>
    [JsonPropertyName("source")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecPipelineCredentialsSourceEnum>))]
    public V1CompositionSpecPipelineCredentialsSourceEnum Source { get; set; }
}

/// <summary>FunctionRef is a reference to the Composition Function this step should execute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecPipelineFunctionRef
{
    /// <summary>Name of the referenced Function.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A PipelineStep in a Composition Function pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecPipeline
{
    /// <summary>Credentials are optional credentials that the Composition Function needs.</summary>
    [JsonPropertyName("credentials")]
    public IList<V1CompositionSpecPipelineCredentials>? Credentials { get; set; }

    /// <summary>FunctionRef is a reference to the Composition Function this step should execute.</summary>
    [JsonPropertyName("functionRef")]
    public V1CompositionSpecPipelineFunctionRef FunctionRef { get; set; }

    /// <summary>Input is an optional, arbitrary Kubernetes resource (i.e. a resource with an apiVersion and kind) that will be passed to the Composition Function as the 'input' of its RunFunctionRequest.</summary>
    [JsonPropertyName("input")]
    public JsonNode? Input { get; set; }

    /// <summary>Step name. Must be unique within its Pipeline.</summary>
    [JsonPropertyName("step")]
    public string Step { get; set; }
}

/// <summary>PublishConnectionDetailsWithStoreConfig specifies the secret store config with which the connection details of composite resources dynamically provisioned using this composition will be published.   THIS IS AN ALPHA FIELD. Do not use it in production. It is not honored unless the relevant Crossplane feature flag is enabled, and may be changed or removed without notice.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecPublishConnectionDetailsWithStoreConfigRef
{
    /// <summary>Name of the referenced StoreConfig.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecResourcesConnectionDetailsTypeEnum
{
    [EnumMember(Value = "FromConnectionSecretKey"), JsonStringEnumMemberName("FromConnectionSecretKey")]
    /// <summary>FromConnectionSecretKey</summary>
    FromConnectionSecretKey,
    [EnumMember(Value = "FromFieldPath"), JsonStringEnumMemberName("FromFieldPath")]
    /// <summary>FromFieldPath</summary>
    FromFieldPath,
    [EnumMember(Value = "FromValue"), JsonStringEnumMemberName("FromValue")]
    /// <summary>FromValue</summary>
    FromValue
}

/// <summary>ConnectionDetail includes the information about the propagation of the connection information from one secret to another.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecResourcesConnectionDetails
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
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecResourcesConnectionDetailsTypeEnum>))]
    public V1CompositionSpecResourcesConnectionDetailsTypeEnum? Type { get; set; }

    /// <summary>Value that will be propagated to the connection secret of the composite resource. May be set to inject a fixed, non-sensitive connection secret value, for example a well-known port.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecResourcesPatchesCombineStrategyEnum
{
    [EnumMember(Value = "string"), JsonStringEnumMemberName("string")]
    /// <summary>string</summary>
    String
}

/// <summary>String declares that input variables should be combined into a single string, using the relevant settings for formatting purposes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecResourcesPatchesCombineString
{
    /// <summary>Format the input using a Go format string. See https://golang.org/pkg/fmt/ for details.</summary>
    [JsonPropertyName("fmt")]
    public string Fmt { get; set; }
}

/// <summary>A CombineVariable defines the source of a value that is combined with others to form and patch an output value. Currently, this only supports retrieving values from a field path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecResourcesPatchesCombineVariables
{
    /// <summary>FromFieldPath is the path of the field on the source whose value is to be used as input.</summary>
    [JsonPropertyName("fromFieldPath")]
    public string FromFieldPath { get; set; }
}

/// <summary>Combine is the patch configuration for a CombineFromComposite, CombineFromEnvironment, CombineToComposite or CombineToEnvironment patch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecResourcesPatchesCombine
{
    /// <summary>Strategy defines the strategy to use to combine the input variable values. Currently only string is supported.</summary>
    [JsonPropertyName("strategy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecResourcesPatchesCombineStrategyEnum>))]
    public V1CompositionSpecResourcesPatchesCombineStrategyEnum Strategy { get; set; }

    /// <summary>String declares that input variables should be combined into a single string, using the relevant settings for formatting purposes.</summary>
    [JsonPropertyName("string")]
    public V1CompositionSpecResourcesPatchesCombineString? String { get; set; }

    /// <summary>Variables are the list of variables whose values will be retrieved and combined.</summary>
    [JsonPropertyName("variables")]
    public IList<V1CompositionSpecResourcesPatchesCombineVariables> Variables { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecResourcesPatchesPolicyFromFieldPathEnum
{
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional,
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required
}

/// <summary>MergeOptions Specifies merge options on a field path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecResourcesPatchesPolicyMergeOptions
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
public partial class V1CompositionSpecResourcesPatchesPolicy
{
    /// <summary>FromFieldPath specifies how to patch from a field path. The default is 'Optional', which means the patch will be a no-op if the specified fromFieldPath does not exist. Use 'Required' if the patch should fail if the specified path does not exist.</summary>
    [JsonPropertyName("fromFieldPath")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecResourcesPatchesPolicyFromFieldPathEnum>))]
    public V1CompositionSpecResourcesPatchesPolicyFromFieldPathEnum? FromFieldPath { get; set; }

    /// <summary>MergeOptions Specifies merge options on a field path.</summary>
    [JsonPropertyName("mergeOptions")]
    public V1CompositionSpecResourcesPatchesPolicyMergeOptions? MergeOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecResourcesPatchesTransformsConvertFormatEnum
{
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    /// <summary>none</summary>
    None,
    [EnumMember(Value = "quantity"), JsonStringEnumMemberName("quantity")]
    /// <summary>quantity</summary>
    Quantity,
    [EnumMember(Value = "json"), JsonStringEnumMemberName("json")]
    /// <summary>json</summary>
    Json
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecResourcesPatchesTransformsConvertToTypeEnum
{
    [EnumMember(Value = "string"), JsonStringEnumMemberName("string")]
    /// <summary>string</summary>
    String,
    [EnumMember(Value = "int"), JsonStringEnumMemberName("int")]
    /// <summary>int</summary>
    Int,
    [EnumMember(Value = "int64"), JsonStringEnumMemberName("int64")]
    /// <summary>int64</summary>
    Int64,
    [EnumMember(Value = "bool"), JsonStringEnumMemberName("bool")]
    /// <summary>bool</summary>
    Bool,
    [EnumMember(Value = "float64"), JsonStringEnumMemberName("float64")]
    /// <summary>float64</summary>
    Float64,
    [EnumMember(Value = "object"), JsonStringEnumMemberName("object")]
    /// <summary>object</summary>
    Object,
    [EnumMember(Value = "array"), JsonStringEnumMemberName("array")]
    /// <summary>array</summary>
    Array
}

/// <summary>Convert is used to cast the input into the given output type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecResourcesPatchesTransformsConvert
{
    /// <summary>The expected input format.   * `quantity` - parses the input as a K8s [`resource.Quantity`](https://pkg.go.dev/k8s.io/apimachinery/pkg/api/resource#Quantity). Only used during `string -&gt; float64` conversions. * `json` - parses the input as a JSON string. Only used during `string -&gt; object` or `string -&gt; list` conversions.   If this property is null, the default conversion is applied.</summary>
    [JsonPropertyName("format")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecResourcesPatchesTransformsConvertFormatEnum>))]
    public V1CompositionSpecResourcesPatchesTransformsConvertFormatEnum? Format { get; set; }

    /// <summary>ToType is the type of the output of this transform.</summary>
    [JsonPropertyName("toType")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecResourcesPatchesTransformsConvertToTypeEnum>))]
    public V1CompositionSpecResourcesPatchesTransformsConvertToTypeEnum ToType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecResourcesPatchesTransformsMatchFallbackToEnum
{
    [EnumMember(Value = "Value"), JsonStringEnumMemberName("Value")]
    /// <summary>Value</summary>
    Value,
    [EnumMember(Value = "Input"), JsonStringEnumMemberName("Input")]
    /// <summary>Input</summary>
    Input
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecResourcesPatchesTransformsMatchPatternsTypeEnum
{
    [EnumMember(Value = "literal"), JsonStringEnumMemberName("literal")]
    /// <summary>literal</summary>
    Literal,
    [EnumMember(Value = "regexp"), JsonStringEnumMemberName("regexp")]
    /// <summary>regexp</summary>
    Regexp
}

/// <summary>MatchTransformPattern is a transform that returns the value that matches a pattern.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecResourcesPatchesTransformsMatchPatterns
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
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecResourcesPatchesTransformsMatchPatternsTypeEnum>))]
    public V1CompositionSpecResourcesPatchesTransformsMatchPatternsTypeEnum Type { get; set; }
}

/// <summary>Match is a more complex version of Map that matches a list of patterns.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecResourcesPatchesTransformsMatch
{
    /// <summary>Determines to what value the transform should fallback if no pattern matches.</summary>
    [JsonPropertyName("fallbackTo")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecResourcesPatchesTransformsMatchFallbackToEnum>))]
    public V1CompositionSpecResourcesPatchesTransformsMatchFallbackToEnum? FallbackTo { get; set; }

    /// <summary>The fallback value that should be returned by the transform if now pattern matches.</summary>
    [JsonPropertyName("fallbackValue")]
    public JsonNode? FallbackValue { get; set; }

    /// <summary>The patterns that should be tested against the input string. Patterns are tested in order. The value of the first match is used as result of this transform.</summary>
    [JsonPropertyName("patterns")]
    public IList<V1CompositionSpecResourcesPatchesTransformsMatchPatterns>? Patterns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecResourcesPatchesTransformsMathTypeEnum
{
    [EnumMember(Value = "Multiply"), JsonStringEnumMemberName("Multiply")]
    /// <summary>Multiply</summary>
    Multiply,
    [EnumMember(Value = "ClampMin"), JsonStringEnumMemberName("ClampMin")]
    /// <summary>ClampMin</summary>
    ClampMin,
    [EnumMember(Value = "ClampMax"), JsonStringEnumMemberName("ClampMax")]
    /// <summary>ClampMax</summary>
    ClampMax
}

/// <summary>Math is used to transform the input via mathematical operations such as multiplication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecResourcesPatchesTransformsMath
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
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecResourcesPatchesTransformsMathTypeEnum>))]
    public V1CompositionSpecResourcesPatchesTransformsMathTypeEnum? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecResourcesPatchesTransformsStringConvertEnum
{
    [EnumMember(Value = "ToUpper"), JsonStringEnumMemberName("ToUpper")]
    /// <summary>ToUpper</summary>
    ToUpper,
    [EnumMember(Value = "ToLower"), JsonStringEnumMemberName("ToLower")]
    /// <summary>ToLower</summary>
    ToLower,
    [EnumMember(Value = "ToBase64"), JsonStringEnumMemberName("ToBase64")]
    /// <summary>ToBase64</summary>
    ToBase64,
    [EnumMember(Value = "FromBase64"), JsonStringEnumMemberName("FromBase64")]
    /// <summary>FromBase64</summary>
    FromBase64,
    [EnumMember(Value = "ToJson"), JsonStringEnumMemberName("ToJson")]
    /// <summary>ToJson</summary>
    ToJson,
    [EnumMember(Value = "ToSha1"), JsonStringEnumMemberName("ToSha1")]
    /// <summary>ToSha1</summary>
    ToSha1,
    [EnumMember(Value = "ToSha256"), JsonStringEnumMemberName("ToSha256")]
    /// <summary>ToSha256</summary>
    ToSha256,
    [EnumMember(Value = "ToSha512"), JsonStringEnumMemberName("ToSha512")]
    /// <summary>ToSha512</summary>
    ToSha512,
    [EnumMember(Value = "ToAdler32"), JsonStringEnumMemberName("ToAdler32")]
    /// <summary>ToAdler32</summary>
    ToAdler32
}

/// <summary>Join defines parameters to join a slice of values to a string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecResourcesPatchesTransformsStringJoin
{
    /// <summary>Separator defines the character that should separate the values from each other in the joined string.</summary>
    [JsonPropertyName("separator")]
    public string Separator { get; set; }
}

/// <summary>Extract a match from the input using a regular expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecResourcesPatchesTransformsStringRegexp
{
    /// <summary>Group number to match. 0 (the default) matches the entire expression.</summary>
    [JsonPropertyName("group")]
    public int? Group { get; set; }

    /// <summary>Match string. May optionally include submatches, aka capture groups. See https://pkg.go.dev/regexp/ for details.</summary>
    [JsonPropertyName("match")]
    public string Match { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecResourcesPatchesTransformsStringTypeEnum
{
    [EnumMember(Value = "Format"), JsonStringEnumMemberName("Format")]
    /// <summary>Format</summary>
    Format,
    [EnumMember(Value = "Convert"), JsonStringEnumMemberName("Convert")]
    /// <summary>Convert</summary>
    Convert,
    [EnumMember(Value = "TrimPrefix"), JsonStringEnumMemberName("TrimPrefix")]
    /// <summary>TrimPrefix</summary>
    TrimPrefix,
    [EnumMember(Value = "TrimSuffix"), JsonStringEnumMemberName("TrimSuffix")]
    /// <summary>TrimSuffix</summary>
    TrimSuffix,
    [EnumMember(Value = "Regexp"), JsonStringEnumMemberName("Regexp")]
    /// <summary>Regexp</summary>
    Regexp,
    [EnumMember(Value = "Join"), JsonStringEnumMemberName("Join")]
    /// <summary>Join</summary>
    Join
}

/// <summary>String is used to transform the input into a string or a different kind of string. Note that the input does not necessarily need to be a string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecResourcesPatchesTransformsString
{
    /// <summary>Optional conversion method to be specified. `ToUpper` and `ToLower` change the letter case of the input string. `ToBase64` and `FromBase64` perform a base64 conversion based on the input string. `ToJson` converts any input value into its raw JSON representation. `ToSha1`, `ToSha256` and `ToSha512` generate a hash value based on the input converted to JSON. `ToAdler32` generate a addler32 hash based on the input string.</summary>
    [JsonPropertyName("convert")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecResourcesPatchesTransformsStringConvertEnum>))]
    public V1CompositionSpecResourcesPatchesTransformsStringConvertEnum? Convert { get; set; }

    /// <summary>Format the input using a Go format string. See https://golang.org/pkg/fmt/ for details.</summary>
    [JsonPropertyName("fmt")]
    public string? Fmt { get; set; }

    /// <summary>Join defines parameters to join a slice of values to a string.</summary>
    [JsonPropertyName("join")]
    public V1CompositionSpecResourcesPatchesTransformsStringJoin? Join { get; set; }

    /// <summary>Extract a match from the input using a regular expression.</summary>
    [JsonPropertyName("regexp")]
    public V1CompositionSpecResourcesPatchesTransformsStringRegexp? Regexp { get; set; }

    /// <summary>Trim the prefix or suffix from the input</summary>
    [JsonPropertyName("trim")]
    public string? Trim { get; set; }

    /// <summary>Type of the string transform to be run.</summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecResourcesPatchesTransformsStringTypeEnum>))]
    public V1CompositionSpecResourcesPatchesTransformsStringTypeEnum? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecResourcesPatchesTransformsTypeEnum
{
    [EnumMember(Value = "map"), JsonStringEnumMemberName("map")]
    /// <summary>map</summary>
    Map,
    [EnumMember(Value = "match"), JsonStringEnumMemberName("match")]
    /// <summary>match</summary>
    Match,
    [EnumMember(Value = "math"), JsonStringEnumMemberName("math")]
    /// <summary>math</summary>
    Math,
    [EnumMember(Value = "string"), JsonStringEnumMemberName("string")]
    /// <summary>string</summary>
    String,
    [EnumMember(Value = "convert"), JsonStringEnumMemberName("convert")]
    /// <summary>convert</summary>
    Convert
}

/// <summary>Transform is a unit of process whose input is transformed into an output with the supplied configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecResourcesPatchesTransforms
{
    /// <summary>Convert is used to cast the input into the given output type.</summary>
    [JsonPropertyName("convert")]
    public V1CompositionSpecResourcesPatchesTransformsConvert? Convert { get; set; }

    /// <summary>Map uses the input as a key in the given map and returns the value.</summary>
    [JsonPropertyName("map")]
    public IDictionary<string, JsonNode>? Map { get; set; }

    /// <summary>Match is a more complex version of Map that matches a list of patterns.</summary>
    [JsonPropertyName("match")]
    public V1CompositionSpecResourcesPatchesTransformsMatch? Match { get; set; }

    /// <summary>Math is used to transform the input via mathematical operations such as multiplication.</summary>
    [JsonPropertyName("math")]
    public V1CompositionSpecResourcesPatchesTransformsMath? Math { get; set; }

    /// <summary>String is used to transform the input into a string or a different kind of string. Note that the input does not necessarily need to be a string.</summary>
    [JsonPropertyName("string")]
    public V1CompositionSpecResourcesPatchesTransformsString? String { get; set; }

    /// <summary>Type of the transform to be run.</summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecResourcesPatchesTransformsTypeEnum>))]
    public V1CompositionSpecResourcesPatchesTransformsTypeEnum Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecResourcesPatchesTypeEnum
{
    [EnumMember(Value = "FromCompositeFieldPath"), JsonStringEnumMemberName("FromCompositeFieldPath")]
    /// <summary>FromCompositeFieldPath</summary>
    FromCompositeFieldPath,
    [EnumMember(Value = "FromEnvironmentFieldPath"), JsonStringEnumMemberName("FromEnvironmentFieldPath")]
    /// <summary>FromEnvironmentFieldPath</summary>
    FromEnvironmentFieldPath,
    [EnumMember(Value = "PatchSet"), JsonStringEnumMemberName("PatchSet")]
    /// <summary>PatchSet</summary>
    PatchSet,
    [EnumMember(Value = "ToCompositeFieldPath"), JsonStringEnumMemberName("ToCompositeFieldPath")]
    /// <summary>ToCompositeFieldPath</summary>
    ToCompositeFieldPath,
    [EnumMember(Value = "ToEnvironmentFieldPath"), JsonStringEnumMemberName("ToEnvironmentFieldPath")]
    /// <summary>ToEnvironmentFieldPath</summary>
    ToEnvironmentFieldPath,
    [EnumMember(Value = "CombineFromEnvironment"), JsonStringEnumMemberName("CombineFromEnvironment")]
    /// <summary>CombineFromEnvironment</summary>
    CombineFromEnvironment,
    [EnumMember(Value = "CombineFromComposite"), JsonStringEnumMemberName("CombineFromComposite")]
    /// <summary>CombineFromComposite</summary>
    CombineFromComposite,
    [EnumMember(Value = "CombineToComposite"), JsonStringEnumMemberName("CombineToComposite")]
    /// <summary>CombineToComposite</summary>
    CombineToComposite,
    [EnumMember(Value = "CombineToEnvironment"), JsonStringEnumMemberName("CombineToEnvironment")]
    /// <summary>CombineToEnvironment</summary>
    CombineToEnvironment
}

/// <summary>Patch objects are applied between composite and composed resources. Their behaviour depends on the Type selected. The default Type, FromCompositeFieldPath, copies a value from the composite resource to the composed resource, applying any defined transformers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecResourcesPatches
{
    /// <summary>Combine is the patch configuration for a CombineFromComposite, CombineFromEnvironment, CombineToComposite or CombineToEnvironment patch.</summary>
    [JsonPropertyName("combine")]
    public V1CompositionSpecResourcesPatchesCombine? Combine { get; set; }

    /// <summary>FromFieldPath is the path of the field on the resource whose value is to be used as input. Required when type is FromCompositeFieldPath, FromEnvironmentFieldPath, ToCompositeFieldPath, ToEnvironmentFieldPath.</summary>
    [JsonPropertyName("fromFieldPath")]
    public string? FromFieldPath { get; set; }

    /// <summary>PatchSetName to include patches from. Required when type is PatchSet.</summary>
    [JsonPropertyName("patchSetName")]
    public string? PatchSetName { get; set; }

    /// <summary>Policy configures the specifics of patching behaviour.</summary>
    [JsonPropertyName("policy")]
    public V1CompositionSpecResourcesPatchesPolicy? Policy { get; set; }

    /// <summary>ToFieldPath is the path of the field on the resource whose value will be changed with the result of transforms. Leave empty if you'd like to propagate to the same path as fromFieldPath.</summary>
    [JsonPropertyName("toFieldPath")]
    public string? ToFieldPath { get; set; }

    /// <summary>Transforms are the list of functions that are used as a FIFO pipe for the input to be transformed.</summary>
    [JsonPropertyName("transforms")]
    public IList<V1CompositionSpecResourcesPatchesTransforms>? Transforms { get; set; }

    /// <summary>Type sets the patching behaviour to be used. Each patch type may require its own fields to be set on the Patch object.</summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecResourcesPatchesTypeEnum>))]
    public V1CompositionSpecResourcesPatchesTypeEnum? Type { get; set; }
}

/// <summary>MatchCondition specifies the condition you'd like to match if you're using "MatchCondition" type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecResourcesReadinessChecksMatchCondition
{
    /// <summary>Status is the status of the condition you'd like to match.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type indicates the type of condition you'd like to use.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1CompositionSpecResourcesReadinessChecksTypeEnum
{
    [EnumMember(Value = "MatchString"), JsonStringEnumMemberName("MatchString")]
    /// <summary>MatchString</summary>
    MatchString,
    [EnumMember(Value = "MatchInteger"), JsonStringEnumMemberName("MatchInteger")]
    /// <summary>MatchInteger</summary>
    MatchInteger,
    [EnumMember(Value = "NonEmpty"), JsonStringEnumMemberName("NonEmpty")]
    /// <summary>NonEmpty</summary>
    NonEmpty,
    [EnumMember(Value = "MatchCondition"), JsonStringEnumMemberName("MatchCondition")]
    /// <summary>MatchCondition</summary>
    MatchCondition,
    [EnumMember(Value = "MatchTrue"), JsonStringEnumMemberName("MatchTrue")]
    /// <summary>MatchTrue</summary>
    MatchTrue,
    [EnumMember(Value = "MatchFalse"), JsonStringEnumMemberName("MatchFalse")]
    /// <summary>MatchFalse</summary>
    MatchFalse,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    /// <summary>None</summary>
    None
}

/// <summary>ReadinessCheck is used to indicate how to tell whether a resource is ready for consumption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecResourcesReadinessChecks
{
    /// <summary>FieldPath shows the path of the field whose value will be used.</summary>
    [JsonPropertyName("fieldPath")]
    public string? FieldPath { get; set; }

    /// <summary>MatchCondition specifies the condition you'd like to match if you're using "MatchCondition" type.</summary>
    [JsonPropertyName("matchCondition")]
    public V1CompositionSpecResourcesReadinessChecksMatchCondition? MatchCondition { get; set; }

    /// <summary>MatchInt is the value you'd like to match if you're using "MatchInt" type.</summary>
    [JsonPropertyName("matchInteger")]
    public long? MatchInteger { get; set; }

    /// <summary>MatchString is the value you'd like to match if you're using "MatchString" type.</summary>
    [JsonPropertyName("matchString")]
    public string? MatchString { get; set; }

    /// <summary>Type indicates the type of probe you'd like to use.</summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecResourcesReadinessChecksTypeEnum>))]
    public V1CompositionSpecResourcesReadinessChecksTypeEnum Type { get; set; }
}

/// <summary>ComposedTemplate is used to provide information about how the composed resource should be processed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpecResources
{
    /// <summary>Base is the target resource that the patches will be applied on.</summary>
    [JsonPropertyName("base")]
    public JsonNode Base { get; set; }

    /// <summary>ConnectionDetails lists the propagation secret keys from this target resource to the composition instance connection secret.</summary>
    [JsonPropertyName("connectionDetails")]
    public IList<V1CompositionSpecResourcesConnectionDetails>? ConnectionDetails { get; set; }

    /// <summary>A Name uniquely identifies this entry within its Composition's resources array. Names are optional but *strongly* recommended. When all entries in the resources array are named entries may added, deleted, and reordered as long as their names do not change. When entries are not named the length and order of the resources array should be treated as immutable. Either all or no entries must be named.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Patches will be applied as overlay to the base resource.</summary>
    [JsonPropertyName("patches")]
    public IList<V1CompositionSpecResourcesPatches>? Patches { get; set; }

    /// <summary>ReadinessChecks allows users to define custom readiness checks. All checks have to return true in order for resource to be considered ready. The default readiness check is to have the "Ready" condition to be "True".</summary>
    [JsonPropertyName("readinessChecks")]
    public IList<V1CompositionSpecResourcesReadinessChecks>? ReadinessChecks { get; set; }
}

/// <summary>CompositionSpec specifies desired state of a composition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CompositionSpec
{
    /// <summary>CompositeTypeRef specifies the type of composite resource that this composition is compatible with.</summary>
    [JsonPropertyName("compositeTypeRef")]
    public V1CompositionSpecCompositeTypeRef CompositeTypeRef { get; set; }

    /// <summary>Environment configures the environment in which resources are rendered.   THIS IS AN ALPHA FIELD. Do not use it in production. It is not honored unless the relevant Crossplane feature flag is enabled, and may be changed or removed without notice.</summary>
    [JsonPropertyName("environment")]
    public V1CompositionSpecEnvironment? Environment { get; set; }

    /// <summary>Mode controls what type or "mode" of Composition will be used.   "Pipeline" indicates that a Composition specifies a pipeline of Composition Functions, each of which is responsible for producing composed resources that Crossplane should create or update.   "Resources" indicates that a Composition uses what is commonly referred to as "Patch &amp; Transform" or P&amp;T composition. This mode of Composition uses an array of resources, each a template for a composed resource.   All Compositions should use Pipeline mode. Resources mode is deprecated. Resources mode won't be removed in Crossplane 1.x, and will remain the default to avoid breaking legacy Compositions. However, it's no longer accepting new features, and only accepting security related bug fixes.</summary>
    [JsonPropertyName("mode")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1CompositionSpecModeEnum>))]
    public V1CompositionSpecModeEnum? Mode { get; set; }

    /// <summary>PatchSets define a named set of patches that may be included by any resource in this Composition. PatchSets cannot themselves refer to other PatchSets.   PatchSets are only used by the "Resources" mode of Composition. They are ignored by other modes.   Deprecated: Use Composition Functions instead.</summary>
    [JsonPropertyName("patchSets")]
    public IList<V1CompositionSpecPatchSets>? PatchSets { get; set; }

    /// <summary>Pipeline is a list of composition function steps that will be used when a composite resource referring to this composition is created. One of resources and pipeline must be specified - you cannot specify both.   The Pipeline is only used by the "Pipeline" mode of Composition. It is ignored by other modes.</summary>
    [JsonPropertyName("pipeline")]
    public IList<V1CompositionSpecPipeline>? Pipeline { get; set; }

    /// <summary>PublishConnectionDetailsWithStoreConfig specifies the secret store config with which the connection details of composite resources dynamically provisioned using this composition will be published.   THIS IS AN ALPHA FIELD. Do not use it in production. It is not honored unless the relevant Crossplane feature flag is enabled, and may be changed or removed without notice.</summary>
    [JsonPropertyName("publishConnectionDetailsWithStoreConfigRef")]
    public V1CompositionSpecPublishConnectionDetailsWithStoreConfigRef? PublishConnectionDetailsWithStoreConfigRef { get; set; }

    /// <summary>Resources is a list of resource templates that will be used when a composite resource referring to this composition is created.   Resources are only used by the "Resources" mode of Composition. They are ignored by other modes.   Deprecated: Use Composition Functions instead.</summary>
    [JsonPropertyName("resources")]
    public IList<V1CompositionSpecResources>? Resources { get; set; }

    /// <summary>WriteConnectionSecretsToNamespace specifies the namespace in which the connection secrets of composite resource dynamically provisioned using this composition will be created. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsWithStoreConfigRef. Currently, both could be set independently and connection details would be published to both without affecting each other as long as related fields at MR level specified.</summary>
    [JsonPropertyName("writeConnectionSecretsToNamespace")]
    public string? WriteConnectionSecretsToNamespace { get; set; }
}

/// <summary>A Composition defines a collection of managed resources or functions that Crossplane uses to create and manage new composite resources.   Read the Crossplane documentation for [more information about Compositions](https://docs.crossplane.io/latest/concepts/compositions).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Composition : IKubernetesObject<V1ObjectMeta>, ISpec<V1CompositionSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Composition";
    public const string KubeGroup = "apiextensions.crossplane.io";
    public const string KubePluralName = "compositions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CompositionSpec specifies desired state of a composition.</summary>
    [JsonPropertyName("spec")]
    public V1CompositionSpec? Spec { get; set; }
}