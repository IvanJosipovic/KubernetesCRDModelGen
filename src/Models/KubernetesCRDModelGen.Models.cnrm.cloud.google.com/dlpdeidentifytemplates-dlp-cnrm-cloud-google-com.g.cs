using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dlp.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateMetadata
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypes
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>date</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>time of day</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public long? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public long? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Upper bound of the range, exclusive; type must match min.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue? DateValue { get; set; }

    /// <summary>day of week Possible values: DAY_OF_WEEK_UNSPECIFIED, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>float</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>integer</summary>
    [JsonPropertyName("integerValue")]
    public long? IntegerValue { get; set; }

    /// <summary>string</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>time of day</summary>
    [JsonPropertyName("timeValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>date</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>time of day</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public long? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public long? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Lower bound of the range, inclusive. Type should be the same as max if used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue? DateValue { get; set; }

    /// <summary>day of week Possible values: DAY_OF_WEEK_UNSPECIFIED, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>float</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>integer</summary>
    [JsonPropertyName("integerValue")]
    public long? IntegerValue { get; set; }

    /// <summary>string</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>time of day</summary>
    [JsonPropertyName("timeValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>date</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>time of day</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public long? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public long? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Required. Replacement value for this bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue? DateValue { get; set; }

    /// <summary>day of week Possible values: DAY_OF_WEEK_UNSPECIFIED, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>float</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>integer</summary>
    [JsonPropertyName("integerValue")]
    public long? IntegerValue { get; set; }

    /// <summary>string</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>time of day</summary>
    [JsonPropertyName("timeValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>Upper bound of the range, exclusive; type must match min.</summary>
    [JsonPropertyName("max")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax? Max { get; set; }

    /// <summary>Lower bound of the range, inclusive. Type should be the same as max if used.</summary>
    [JsonPropertyName("min")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin? Min { get; set; }

    /// <summary>Required. Replacement value for this bucket.</summary>
    [JsonPropertyName("replacementValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue ReplacementValue { get; set; }
}

/// <summary>Bucketing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>Set of buckets. Ranges must be non-overlapping.</summary>
    [JsonPropertyName("buckets")]
    public IList<DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>Common characters to not transform when masking. Useful to avoid removing punctuation. Possible values: COMMON_CHARS_TO_IGNORE_UNSPECIFIED, NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE</summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

/// <summary>Mask</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig
{
    /// <summary>When masking a string, items in this list will be skipped when replacing characters. For example, if the input string is `555-555-5555` and you instruct Cloud DLP to skip `-` and mask 5 characters with `*`, Cloud DLP returns `***-**5-5555`.</summary>
    [JsonPropertyName("charactersToIgnore")]
    public IList<DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

    /// <summary>Character to use to mask the sensitive values—for example, `*` for an alphabetic string such as a name, or `0` for a numeric string such as ZIP code or credit card number. This string must have a length of 1. If not supplied, this value defaults to `*` for strings, and `0` for digits.</summary>
    [JsonPropertyName("maskingCharacter")]
    public string? MaskingCharacter { get; set; }

    /// <summary>Number of characters to mask. If not set, all matching chars will be masked. Skipped characters do not count towards this tally.</summary>
    [JsonPropertyName("numberToMask")]
    public long? NumberToMask { get; set; }

    /// <summary>Mask characters in reverse order. For example, if `masking_character` is `0`, `number_to_mask` is `14`, and `reverse_order` is `false`, then the input string `1234-5678-9012-3456` is masked as `00000000000000-3456`. If `masking_character` is `*`, `number_to_mask` is `3`, and `reverse_order` is `true`, then the string `12345` is masked as `12***`.</summary>
    [JsonPropertyName("reverseOrder")]
    public bool? ReverseOrder { get; set; }
}

/// <summary>A context may be used for higher security and maintaining referential integrity such that the same identifier in two different contexts will be given a distinct surrogate. The context is appended to plaintext value being encrypted. On decryption the provided context is validated against the value used during encryption. If a context was provided during encryption, same context must be provided during decryption as well. If the context is not set, plaintext would be used as is for encryption. If the context is set but: 1. there is no record present when transforming a given value or 2. the field is not present when transforming a given value, plaintext would be used as is for encryption. Note that case (1) is expected when an `InfoTypeTransformation` is applied to both structured and non-structured `ContentItem`s.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrappedCryptoKeyRef
{
    /// <summary>Required. The resource name of the KMS CryptoKey to use for unwrapping.  Allowed value: The Google Cloud resource name of a `KMSCryptoKey` resource (format: `{{selfLink}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Key wrapped using Cloud KMS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

/// <summary>Transient crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Unwrapped crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

/// <summary>The key used by the encryption function. For deterministic encryption using AES-SIV, the provided key is internally expanded to 64 bytes prior to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>The custom info type to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom info type followed by the number of characters comprising the surrogate. The following scheme defines the format: {info type name}({surrogate character count}):{surrogate} For example, if the name of custom info type is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom info type 'Surrogate'. This facilitates reversal of the surrogate when it occurs in free text. Note: For record transformations where the entire cell in a table is being transformed, surrogates are not mandatory. Surrogates are used to denote the location of the token and are necessary for re-identification in free form text. In order for inspection to work properly, the name of this info type must not occur naturally anywhere in your data; otherwise, inspection may either - reverse a surrogate that does not correspond to an actual identifier - be unable to parse the surrogate and result in an error Therefore, choose your custom info type name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Deterministic Crypto</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>A context may be used for higher security and maintaining referential integrity such that the same identifier in two different contexts will be given a distinct surrogate. The context is appended to plaintext value being encrypted. On decryption the provided context is validated against the value used during encryption. If a context was provided during encryption, same context must be provided during decryption as well. If the context is not set, plaintext would be used as is for encryption. If the context is set but: 1. there is no record present when transforming a given value or 2. the field is not present when transforming a given value, plaintext would be used as is for encryption. Note that case (1) is expected when an `InfoTypeTransformation` is applied to both structured and non-structured `ContentItem`s.</summary>
    [JsonPropertyName("context")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext? Context { get; set; }

    /// <summary>The key used by the encryption function. For deterministic encryption using AES-SIV, the provided key is internally expanded to 64 bytes prior to use.</summary>
    [JsonPropertyName("cryptoKey")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>The custom info type to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom info type followed by the number of characters comprising the surrogate. The following scheme defines the format: {info type name}({surrogate character count}):{surrogate} For example, if the name of custom info type is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom info type 'Surrogate'. This facilitates reversal of the surrogate when it occurs in free text. Note: For record transformations where the entire cell in a table is being transformed, surrogates are not mandatory. Surrogates are used to denote the location of the token and are necessary for re-identification in free form text. In order for inspection to work properly, the name of this info type must not occur naturally anywhere in your data; otherwise, inspection may either - reverse a surrogate that does not correspond to an actual identifier - be unable to parse the surrogate and result in an error Therefore, choose your custom info type name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrappedCryptoKeyRef
{
    /// <summary>Required. The resource name of the KMS CryptoKey to use for unwrapping.  Allowed value: The Google Cloud resource name of a `KMSCryptoKey` resource (format: `{{selfLink}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Key wrapped using Cloud KMS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

/// <summary>Transient crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Unwrapped crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

/// <summary>The key used by the hash function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>Crypto</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>The key used by the hash function.</summary>
    [JsonPropertyName("cryptoKey")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey? CryptoKey { get; set; }
}

/// <summary>The 'tweak', a context may be used for higher security since the same identifier in two different contexts won't be given the same surrogate. If the context is not set, a default tweak will be used. If the context is set but: 1. there is no record present when transforming a given value or 1. the field is not present when transforming a given value, a default tweak will be used. Note that case (1) is expected when an `InfoTypeTransformation` is applied to both structured and non-structured `ContentItem`s. Currently, the referenced field may be of value type integer or string. The tweak is constructed as a sequence of bytes in big endian byte order such that: - a 64 bit integer is encoded followed by a single byte of value 1 - a string is encoded in UTF-8 format followed by a single byte of value 2</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrappedCryptoKeyRef
{
    /// <summary>Required. The resource name of the KMS CryptoKey to use for unwrapping.  Allowed value: The Google Cloud resource name of a `KMSCryptoKey` resource (format: `{{selfLink}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Key wrapped using Cloud KMS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

/// <summary>Transient crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Unwrapped crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

/// <summary>Required. The key used by the encryption algorithm.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType [`SurrogateType`](https://cloud.google.com/dlp/docs/reference/rest/v2/InspectConfig#surrogatetype). This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Ffx-Fpe</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>Common alphabets. Possible values: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC</summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>The 'tweak', a context may be used for higher security since the same identifier in two different contexts won't be given the same surrogate. If the context is not set, a default tweak will be used. If the context is set but: 1. there is no record present when transforming a given value or 1. the field is not present when transforming a given value, a default tweak will be used. Note that case (1) is expected when an `InfoTypeTransformation` is applied to both structured and non-structured `ContentItem`s. Currently, the referenced field may be of value type integer or string. The tweak is constructed as a sequence of bytes in big endian byte order such that: - a 64 bit integer is encoded followed by a single byte of value 1 - a string is encoded in UTF-8 format followed by a single byte of value 2</summary>
    [JsonPropertyName("context")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext? Context { get; set; }

    /// <summary>Required. The key used by the encryption algorithm.</summary>
    [JsonPropertyName("cryptoKey")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey CryptoKey { get; set; }

    /// <summary>This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is: ``0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&amp;*()_-+={[}]|:;"'&lt;,&gt;.?/``</summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public long? Radix { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType [`SurrogateType`](https://cloud.google.com/dlp/docs/reference/rest/v2/InspectConfig#surrogatetype). This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE</summary>
    [JsonPropertyName("surrogateInfoType")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrappedCryptoKeyRef
{
    /// <summary>Required. The resource name of the KMS CryptoKey to use for unwrapping.  Allowed value: The Google Cloud resource name of a `KMSCryptoKey` resource (format: `{{selfLink}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Key wrapped using Cloud KMS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

/// <summary>Transient crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Unwrapped crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

/// <summary>Causes the shift to be computed based on this key and the context. This results in the same shift for the same context and crypto_key. If set, must also set context. Can only be applied to table items.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>Date Shift</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context.</summary>
    [JsonPropertyName("context")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext? Context { get; set; }

    /// <summary>Causes the shift to be computed based on this key and the context. This results in the same shift for the same context and crypto_key. If set, must also set context. Can only be applied to table items.</summary>
    [JsonPropertyName("cryptoKey")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>Required. For example, -5 means shift date to at most 5 days back in the past.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public long LowerBoundDays { get; set; }

    /// <summary>Required. Range of shift in days. Actual shift will be selected at random within this range (inclusive ends). Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction. For example, 3 means shift date to at most 3 days into the future.</summary>
    [JsonPropertyName("upperBoundDays")]
    public long UpperBoundDays { get; set; }
}

/// <summary>date</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>time of day</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public long? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public long? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Required. Lower bound value of buckets. All values less than `lower_bound` are grouped together into a single bucket; for example if `lower_bound` = 10, then all values less than 10 are replaced with the value "-10".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue? DateValue { get; set; }

    /// <summary>day of week Possible values: DAY_OF_WEEK_UNSPECIFIED, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>float</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>integer</summary>
    [JsonPropertyName("integerValue")]
    public long? IntegerValue { get; set; }

    /// <summary>string</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>time of day</summary>
    [JsonPropertyName("timeValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>date</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>time of day</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public long? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public long? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Required. Upper bound value of buckets. All values greater than upper_bound are grouped together into a single bucket; for example if `upper_bound` = 89, then all values greater than 89 are replaced with the value "89+".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue? DateValue { get; set; }

    /// <summary>day of week Possible values: DAY_OF_WEEK_UNSPECIFIED, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>float</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>integer</summary>
    [JsonPropertyName("integerValue")]
    public long? IntegerValue { get; set; }

    /// <summary>string</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>time of day</summary>
    [JsonPropertyName("timeValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>Fixed size bucketing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>Required. Size of each bucket (except for minimum and maximum buckets). So if `lower_bound` = 10, `upper_bound` = 89, and `bucket_size` = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+. Precision up to 2 decimals works.</summary>
    [JsonPropertyName("bucketSize")]
    public double BucketSize { get; set; }

    /// <summary>Required. Lower bound value of buckets. All values less than `lower_bound` are grouped together into a single bucket; for example if `lower_bound` = 10, then all values less than 10 are replaced with the value "-10".</summary>
    [JsonPropertyName("lowerBound")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound LowerBound { get; set; }

    /// <summary>Required. Upper bound value of buckets. All values greater than upper_bound are grouped together into a single bucket; for example if `upper_bound` = 89, then all values greater than 89 are replaced with the value "89+".</summary>
    [JsonPropertyName("upperBound")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound UpperBound { get; set; }
}

/// <summary>date</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>time of day</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public long? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public long? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Value to replace it with.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue? DateValue { get; set; }

    /// <summary>day of week Possible values: DAY_OF_WEEK_UNSPECIFIED, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>float</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>integer</summary>
    [JsonPropertyName("integerValue")]
    public long? IntegerValue { get; set; }

    /// <summary>string</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>time of day</summary>
    [JsonPropertyName("timeValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>Replace with a specified value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>Value to replace it with.</summary>
    [JsonPropertyName("newValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue? NewValue { get; set; }
}

/// <summary>Time extraction</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>The part of the time to keep. Possible values: TIME_PART_UNSPECIFIED, YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY</summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

/// <summary>Required. Primitive transformation to apply to the infoType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformation
{
    /// <summary>Bucketing</summary>
    [JsonPropertyName("bucketingConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig? BucketingConfig { get; set; }

    /// <summary>Mask</summary>
    [JsonPropertyName("characterMaskConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig? CharacterMaskConfig { get; set; }

    /// <summary>Deterministic Crypto</summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig? CryptoDeterministicConfig { get; set; }

    /// <summary>Crypto</summary>
    [JsonPropertyName("cryptoHashConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig? CryptoHashConfig { get; set; }

    /// <summary>Ffx-Fpe</summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>Date Shift</summary>
    [JsonPropertyName("dateShiftConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig? DateShiftConfig { get; set; }

    /// <summary>Fixed size bucketing</summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact</summary>
    [JsonPropertyName("redactConfig")]
    public JsonNode? RedactConfig { get; set; }

    /// <summary>Replace with a specified value.</summary>
    [JsonPropertyName("replaceConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig? ReplaceConfig { get; set; }

    /// <summary>Replace with infotype</summary>
    [JsonPropertyName("replaceWithInfoTypeConfig")]
    public JsonNode? ReplaceWithInfoTypeConfig { get; set; }

    /// <summary>Time extraction</summary>
    [JsonPropertyName("timePartConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig? TimePartConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformations
{
    /// <summary>InfoTypes to apply the transformation to. An empty list will cause this transformation to apply to all findings that correspond to infoTypes that were requested in `InspectConfig`.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypes>? InfoTypes { get; set; }

    /// <summary>Required. Primitive transformation to apply to the infoType.</summary>
    [JsonPropertyName("primitiveTransformation")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformation PrimitiveTransformation { get; set; }
}

/// <summary>Treat the dataset as free-form text and apply the same free text transformation everywhere.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformations
{
    /// <summary>Required. Transformation for each infoType. Cannot specify more than one for a given infoType.</summary>
    [JsonPropertyName("transformations")]
    public IList<DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformations> Transformations { get; set; }
}

/// <summary>Required. Field within the record this condition is evaluated against.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsField
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>date</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueDateValue
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>time of day</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public long? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public long? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Value to compare against. [Mandatory, except for `EXISTS` tests.]</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValue
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueDateValue? DateValue { get; set; }

    /// <summary>day of week Possible values: DAY_OF_WEEK_UNSPECIFIED, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>float</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>integer</summary>
    [JsonPropertyName("integerValue")]
    public long? IntegerValue { get; set; }

    /// <summary>string</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>time of day</summary>
    [JsonPropertyName("timeValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditions
{
    /// <summary>Required. Field within the record this condition is evaluated against.</summary>
    [JsonPropertyName("field")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsField Field { get; set; }

    /// <summary>Required. Operator used to compare the field or infoType to the value. Possible values: LOGICAL_OPERATOR_UNSPECIFIED, AND</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>Value to compare against. [Mandatory, except for `EXISTS` tests.]</summary>
    [JsonPropertyName("value")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValue? Value { get; set; }
}

/// <summary>Conditions to apply to the expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditions
{
    /// <summary>A collection of conditions.</summary>
    [JsonPropertyName("conditions")]
    public IList<DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditions>? Conditions { get; set; }
}

/// <summary>An expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressions
{
    /// <summary>Conditions to apply to the expression.</summary>
    [JsonPropertyName("conditions")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditions? Conditions { get; set; }

    /// <summary>The operator to apply to the result of conditions. Default and currently only supported value is `AND`. Possible values: LOGICAL_OPERATOR_UNSPECIFIED, AND</summary>
    [JsonPropertyName("logicalOperator")]
    public string? LogicalOperator { get; set; }
}

/// <summary>Only apply the transformation if the condition evaluates to true for the given `RecordCondition`. The conditions are allowed to reference fields that are not used in the actual transformation. Example Use Cases: - Apply a different bucket transformation to an age column if the zip code column for the same record is within a specific range. - Redact a field if the date of birth field is greater than 85.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsCondition
{
    /// <summary>An expression.</summary>
    [JsonPropertyName("expressions")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressions? Expressions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsFields
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypes
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>date</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>time of day</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public long? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public long? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Upper bound of the range, exclusive; type must match min.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue? DateValue { get; set; }

    /// <summary>day of week Possible values: DAY_OF_WEEK_UNSPECIFIED, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>float</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>integer</summary>
    [JsonPropertyName("integerValue")]
    public long? IntegerValue { get; set; }

    /// <summary>string</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>time of day</summary>
    [JsonPropertyName("timeValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>date</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>time of day</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public long? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public long? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Lower bound of the range, inclusive. Type should be the same as max if used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue? DateValue { get; set; }

    /// <summary>day of week Possible values: DAY_OF_WEEK_UNSPECIFIED, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>float</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>integer</summary>
    [JsonPropertyName("integerValue")]
    public long? IntegerValue { get; set; }

    /// <summary>string</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>time of day</summary>
    [JsonPropertyName("timeValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>date</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>time of day</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public long? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public long? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Required. Replacement value for this bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue? DateValue { get; set; }

    /// <summary>day of week Possible values: DAY_OF_WEEK_UNSPECIFIED, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>float</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>integer</summary>
    [JsonPropertyName("integerValue")]
    public long? IntegerValue { get; set; }

    /// <summary>string</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>time of day</summary>
    [JsonPropertyName("timeValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>Upper bound of the range, exclusive; type must match min.</summary>
    [JsonPropertyName("max")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax? Max { get; set; }

    /// <summary>Lower bound of the range, inclusive. Type should be the same as max if used.</summary>
    [JsonPropertyName("min")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin? Min { get; set; }

    /// <summary>Required. Replacement value for this bucket.</summary>
    [JsonPropertyName("replacementValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue ReplacementValue { get; set; }
}

/// <summary>Bucketing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>Set of buckets. Ranges must be non-overlapping.</summary>
    [JsonPropertyName("buckets")]
    public IList<DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>Common characters to not transform when masking. Useful to avoid removing punctuation. Possible values: COMMON_CHARS_TO_IGNORE_UNSPECIFIED, NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE</summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

/// <summary>Mask</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig
{
    /// <summary>When masking a string, items in this list will be skipped when replacing characters. For example, if the input string is `555-555-5555` and you instruct Cloud DLP to skip `-` and mask 5 characters with `*`, Cloud DLP returns `***-**5-5555`.</summary>
    [JsonPropertyName("charactersToIgnore")]
    public IList<DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

    /// <summary>Character to use to mask the sensitive values—for example, `*` for an alphabetic string such as a name, or `0` for a numeric string such as ZIP code or credit card number. This string must have a length of 1. If not supplied, this value defaults to `*` for strings, and `0` for digits.</summary>
    [JsonPropertyName("maskingCharacter")]
    public string? MaskingCharacter { get; set; }

    /// <summary>Number of characters to mask. If not set, all matching chars will be masked. Skipped characters do not count towards this tally.</summary>
    [JsonPropertyName("numberToMask")]
    public long? NumberToMask { get; set; }

    /// <summary>Mask characters in reverse order. For example, if `masking_character` is `0`, `number_to_mask` is `14`, and `reverse_order` is `false`, then the input string `1234-5678-9012-3456` is masked as `00000000000000-3456`. If `masking_character` is `*`, `number_to_mask` is `3`, and `reverse_order` is `true`, then the string `12345` is masked as `12***`.</summary>
    [JsonPropertyName("reverseOrder")]
    public bool? ReverseOrder { get; set; }
}

/// <summary>A context may be used for higher security and maintaining referential integrity such that the same identifier in two different contexts will be given a distinct surrogate. The context is appended to plaintext value being encrypted. On decryption the provided context is validated against the value used during encryption. If a context was provided during encryption, same context must be provided during decryption as well. If the context is not set, plaintext would be used as is for encryption. If the context is set but: 1. there is no record present when transforming a given value or 2. the field is not present when transforming a given value, plaintext would be used as is for encryption. Note that case (1) is expected when an `InfoTypeTransformation` is applied to both structured and non-structured `ContentItem`s.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrappedCryptoKeyRef
{
    /// <summary>Required. The resource name of the KMS CryptoKey to use for unwrapping.  Allowed value: The Google Cloud resource name of a `KMSCryptoKey` resource (format: `{{selfLink}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Key wrapped using Cloud KMS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

/// <summary>Transient crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Unwrapped crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

/// <summary>The key used by the encryption function. For deterministic encryption using AES-SIV, the provided key is internally expanded to 64 bytes prior to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>The custom info type to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom info type followed by the number of characters comprising the surrogate. The following scheme defines the format: {info type name}({surrogate character count}):{surrogate} For example, if the name of custom info type is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom info type 'Surrogate'. This facilitates reversal of the surrogate when it occurs in free text. Note: For record transformations where the entire cell in a table is being transformed, surrogates are not mandatory. Surrogates are used to denote the location of the token and are necessary for re-identification in free form text. In order for inspection to work properly, the name of this info type must not occur naturally anywhere in your data; otherwise, inspection may either - reverse a surrogate that does not correspond to an actual identifier - be unable to parse the surrogate and result in an error Therefore, choose your custom info type name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Deterministic Crypto</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>A context may be used for higher security and maintaining referential integrity such that the same identifier in two different contexts will be given a distinct surrogate. The context is appended to plaintext value being encrypted. On decryption the provided context is validated against the value used during encryption. If a context was provided during encryption, same context must be provided during decryption as well. If the context is not set, plaintext would be used as is for encryption. If the context is set but: 1. there is no record present when transforming a given value or 2. the field is not present when transforming a given value, plaintext would be used as is for encryption. Note that case (1) is expected when an `InfoTypeTransformation` is applied to both structured and non-structured `ContentItem`s.</summary>
    [JsonPropertyName("context")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext? Context { get; set; }

    /// <summary>The key used by the encryption function. For deterministic encryption using AES-SIV, the provided key is internally expanded to 64 bytes prior to use.</summary>
    [JsonPropertyName("cryptoKey")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>The custom info type to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom info type followed by the number of characters comprising the surrogate. The following scheme defines the format: {info type name}({surrogate character count}):{surrogate} For example, if the name of custom info type is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom info type 'Surrogate'. This facilitates reversal of the surrogate when it occurs in free text. Note: For record transformations where the entire cell in a table is being transformed, surrogates are not mandatory. Surrogates are used to denote the location of the token and are necessary for re-identification in free form text. In order for inspection to work properly, the name of this info type must not occur naturally anywhere in your data; otherwise, inspection may either - reverse a surrogate that does not correspond to an actual identifier - be unable to parse the surrogate and result in an error Therefore, choose your custom info type name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrappedCryptoKeyRef
{
    /// <summary>Required. The resource name of the KMS CryptoKey to use for unwrapping.  Allowed value: The Google Cloud resource name of a `KMSCryptoKey` resource (format: `{{selfLink}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Key wrapped using Cloud KMS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

/// <summary>Transient crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Unwrapped crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

/// <summary>The key used by the hash function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>Crypto</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>The key used by the hash function.</summary>
    [JsonPropertyName("cryptoKey")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey? CryptoKey { get; set; }
}

/// <summary>The 'tweak', a context may be used for higher security since the same identifier in two different contexts won't be given the same surrogate. If the context is not set, a default tweak will be used. If the context is set but: 1. there is no record present when transforming a given value or 1. the field is not present when transforming a given value, a default tweak will be used. Note that case (1) is expected when an `InfoTypeTransformation` is applied to both structured and non-structured `ContentItem`s. Currently, the referenced field may be of value type integer or string. The tweak is constructed as a sequence of bytes in big endian byte order such that: - a 64 bit integer is encoded followed by a single byte of value 1 - a string is encoded in UTF-8 format followed by a single byte of value 2</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrappedCryptoKeyRef
{
    /// <summary>Required. The resource name of the KMS CryptoKey to use for unwrapping.  Allowed value: The Google Cloud resource name of a `KMSCryptoKey` resource (format: `{{selfLink}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Key wrapped using Cloud KMS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

/// <summary>Transient crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Unwrapped crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

/// <summary>Required. The key used by the encryption algorithm.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType [`SurrogateType`](https://cloud.google.com/dlp/docs/reference/rest/v2/InspectConfig#surrogatetype). This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Ffx-Fpe</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>Common alphabets. Possible values: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC</summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>The 'tweak', a context may be used for higher security since the same identifier in two different contexts won't be given the same surrogate. If the context is not set, a default tweak will be used. If the context is set but: 1. there is no record present when transforming a given value or 1. the field is not present when transforming a given value, a default tweak will be used. Note that case (1) is expected when an `InfoTypeTransformation` is applied to both structured and non-structured `ContentItem`s. Currently, the referenced field may be of value type integer or string. The tweak is constructed as a sequence of bytes in big endian byte order such that: - a 64 bit integer is encoded followed by a single byte of value 1 - a string is encoded in UTF-8 format followed by a single byte of value 2</summary>
    [JsonPropertyName("context")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext? Context { get; set; }

    /// <summary>Required. The key used by the encryption algorithm.</summary>
    [JsonPropertyName("cryptoKey")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey CryptoKey { get; set; }

    /// <summary>This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is: ``0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&amp;*()_-+={[}]|:;"'&lt;,&gt;.?/``</summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public long? Radix { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType [`SurrogateType`](https://cloud.google.com/dlp/docs/reference/rest/v2/InspectConfig#surrogatetype). This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE</summary>
    [JsonPropertyName("surrogateInfoType")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrappedCryptoKeyRef
{
    /// <summary>Required. The resource name of the KMS CryptoKey to use for unwrapping.  Allowed value: The Google Cloud resource name of a `KMSCryptoKey` resource (format: `{{selfLink}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Key wrapped using Cloud KMS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

/// <summary>Transient crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Unwrapped crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

/// <summary>Causes the shift to be computed based on this key and the context. This results in the same shift for the same context and crypto_key. If set, must also set context. Can only be applied to table items.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>Date Shift</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context.</summary>
    [JsonPropertyName("context")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext? Context { get; set; }

    /// <summary>Causes the shift to be computed based on this key and the context. This results in the same shift for the same context and crypto_key. If set, must also set context. Can only be applied to table items.</summary>
    [JsonPropertyName("cryptoKey")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>Required. For example, -5 means shift date to at most 5 days back in the past.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public long LowerBoundDays { get; set; }

    /// <summary>Required. Range of shift in days. Actual shift will be selected at random within this range (inclusive ends). Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction. For example, 3 means shift date to at most 3 days into the future.</summary>
    [JsonPropertyName("upperBoundDays")]
    public long UpperBoundDays { get; set; }
}

/// <summary>date</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>time of day</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public long? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public long? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Required. Lower bound value of buckets. All values less than `lower_bound` are grouped together into a single bucket; for example if `lower_bound` = 10, then all values less than 10 are replaced with the value "-10".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue? DateValue { get; set; }

    /// <summary>day of week Possible values: DAY_OF_WEEK_UNSPECIFIED, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>float</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>integer</summary>
    [JsonPropertyName("integerValue")]
    public long? IntegerValue { get; set; }

    /// <summary>string</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>time of day</summary>
    [JsonPropertyName("timeValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>date</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>time of day</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public long? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public long? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Required. Upper bound value of buckets. All values greater than upper_bound are grouped together into a single bucket; for example if `upper_bound` = 89, then all values greater than 89 are replaced with the value "89+".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue? DateValue { get; set; }

    /// <summary>day of week Possible values: DAY_OF_WEEK_UNSPECIFIED, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>float</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>integer</summary>
    [JsonPropertyName("integerValue")]
    public long? IntegerValue { get; set; }

    /// <summary>string</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>time of day</summary>
    [JsonPropertyName("timeValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>Fixed size bucketing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>Required. Size of each bucket (except for minimum and maximum buckets). So if `lower_bound` = 10, `upper_bound` = 89, and `bucket_size` = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+. Precision up to 2 decimals works.</summary>
    [JsonPropertyName("bucketSize")]
    public double BucketSize { get; set; }

    /// <summary>Required. Lower bound value of buckets. All values less than `lower_bound` are grouped together into a single bucket; for example if `lower_bound` = 10, then all values less than 10 are replaced with the value "-10".</summary>
    [JsonPropertyName("lowerBound")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound LowerBound { get; set; }

    /// <summary>Required. Upper bound value of buckets. All values greater than upper_bound are grouped together into a single bucket; for example if `upper_bound` = 89, then all values greater than 89 are replaced with the value "89+".</summary>
    [JsonPropertyName("upperBound")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound UpperBound { get; set; }
}

/// <summary>date</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>time of day</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public long? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public long? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Value to replace it with.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue? DateValue { get; set; }

    /// <summary>day of week Possible values: DAY_OF_WEEK_UNSPECIFIED, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>float</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>integer</summary>
    [JsonPropertyName("integerValue")]
    public long? IntegerValue { get; set; }

    /// <summary>string</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>time of day</summary>
    [JsonPropertyName("timeValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>Replace with a specified value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>Value to replace it with.</summary>
    [JsonPropertyName("newValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue? NewValue { get; set; }
}

/// <summary>Time extraction</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>The part of the time to keep. Possible values: TIME_PART_UNSPECIFIED, YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY</summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

/// <summary>Required. Primitive transformation to apply to the infoType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformation
{
    /// <summary>Bucketing</summary>
    [JsonPropertyName("bucketingConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig? BucketingConfig { get; set; }

    /// <summary>Mask</summary>
    [JsonPropertyName("characterMaskConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig? CharacterMaskConfig { get; set; }

    /// <summary>Deterministic Crypto</summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig? CryptoDeterministicConfig { get; set; }

    /// <summary>Crypto</summary>
    [JsonPropertyName("cryptoHashConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig? CryptoHashConfig { get; set; }

    /// <summary>Ffx-Fpe</summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>Date Shift</summary>
    [JsonPropertyName("dateShiftConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig? DateShiftConfig { get; set; }

    /// <summary>Fixed size bucketing</summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact</summary>
    [JsonPropertyName("redactConfig")]
    public JsonNode? RedactConfig { get; set; }

    /// <summary>Replace with a specified value.</summary>
    [JsonPropertyName("replaceConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig? ReplaceConfig { get; set; }

    /// <summary>Replace with infotype</summary>
    [JsonPropertyName("replaceWithInfoTypeConfig")]
    public JsonNode? ReplaceWithInfoTypeConfig { get; set; }

    /// <summary>Time extraction</summary>
    [JsonPropertyName("timePartConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig? TimePartConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformations
{
    /// <summary>InfoTypes to apply the transformation to. An empty list will cause this transformation to apply to all findings that correspond to infoTypes that were requested in `InspectConfig`.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypes>? InfoTypes { get; set; }

    /// <summary>Required. Primitive transformation to apply to the infoType.</summary>
    [JsonPropertyName("primitiveTransformation")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformation PrimitiveTransformation { get; set; }
}

/// <summary>Treat the contents of the field as free text, and selectively transform content that matches an `InfoType`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformations
{
    /// <summary>Required. Transformation for each infoType. Cannot specify more than one for a given infoType.</summary>
    [JsonPropertyName("transformations")]
    public IList<DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformations> Transformations { get; set; }
}

/// <summary>date</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>time of day</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public long? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public long? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Upper bound of the range, exclusive; type must match min.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue? DateValue { get; set; }

    /// <summary>day of week Possible values: DAY_OF_WEEK_UNSPECIFIED, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>float</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>integer</summary>
    [JsonPropertyName("integerValue")]
    public long? IntegerValue { get; set; }

    /// <summary>string</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>time of day</summary>
    [JsonPropertyName("timeValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>date</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>time of day</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public long? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public long? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Lower bound of the range, inclusive. Type should be the same as max if used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue? DateValue { get; set; }

    /// <summary>day of week Possible values: DAY_OF_WEEK_UNSPECIFIED, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>float</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>integer</summary>
    [JsonPropertyName("integerValue")]
    public long? IntegerValue { get; set; }

    /// <summary>string</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>time of day</summary>
    [JsonPropertyName("timeValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>date</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>time of day</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public long? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public long? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Required. Replacement value for this bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue? DateValue { get; set; }

    /// <summary>day of week Possible values: DAY_OF_WEEK_UNSPECIFIED, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>float</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>integer</summary>
    [JsonPropertyName("integerValue")]
    public long? IntegerValue { get; set; }

    /// <summary>string</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>time of day</summary>
    [JsonPropertyName("timeValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>Upper bound of the range, exclusive; type must match min.</summary>
    [JsonPropertyName("max")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMax? Max { get; set; }

    /// <summary>Lower bound of the range, inclusive. Type should be the same as max if used.</summary>
    [JsonPropertyName("min")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMin? Min { get; set; }

    /// <summary>Required. Replacement value for this bucket.</summary>
    [JsonPropertyName("replacementValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue ReplacementValue { get; set; }
}

/// <summary>Bucketing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>Set of buckets. Ranges must be non-overlapping.</summary>
    [JsonPropertyName("buckets")]
    public IList<DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>Common characters to not transform when masking. Useful to avoid removing punctuation. Possible values: COMMON_CHARS_TO_IGNORE_UNSPECIFIED, NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE</summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

/// <summary>Mask</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfig
{
    /// <summary>When masking a string, items in this list will be skipped when replacing characters. For example, if the input string is `555-555-5555` and you instruct Cloud DLP to skip `-` and mask 5 characters with `*`, Cloud DLP returns `***-**5-5555`.</summary>
    [JsonPropertyName("charactersToIgnore")]
    public IList<DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

    /// <summary>Character to use to mask the sensitive values—for example, `*` for an alphabetic string such as a name, or `0` for a numeric string such as ZIP code or credit card number. This string must have a length of 1. If not supplied, this value defaults to `*` for strings, and `0` for digits.</summary>
    [JsonPropertyName("maskingCharacter")]
    public string? MaskingCharacter { get; set; }

    /// <summary>Number of characters to mask. If not set, all matching chars will be masked. Skipped characters do not count towards this tally.</summary>
    [JsonPropertyName("numberToMask")]
    public long? NumberToMask { get; set; }

    /// <summary>Mask characters in reverse order. For example, if `masking_character` is `0`, `number_to_mask` is `14`, and `reverse_order` is `false`, then the input string `1234-5678-9012-3456` is masked as `00000000000000-3456`. If `masking_character` is `*`, `number_to_mask` is `3`, and `reverse_order` is `true`, then the string `12345` is masked as `12***`.</summary>
    [JsonPropertyName("reverseOrder")]
    public bool? ReverseOrder { get; set; }
}

/// <summary>A context may be used for higher security and maintaining referential integrity such that the same identifier in two different contexts will be given a distinct surrogate. The context is appended to plaintext value being encrypted. On decryption the provided context is validated against the value used during encryption. If a context was provided during encryption, same context must be provided during decryption as well. If the context is not set, plaintext would be used as is for encryption. If the context is set but: 1. there is no record present when transforming a given value or 2. the field is not present when transforming a given value, plaintext would be used as is for encryption. Note that case (1) is expected when an `InfoTypeTransformation` is applied to both structured and non-structured `ContentItem`s.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrappedCryptoKeyRef
{
    /// <summary>Required. The resource name of the KMS CryptoKey to use for unwrapping.  Allowed value: The Google Cloud resource name of a `KMSCryptoKey` resource (format: `{{selfLink}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Key wrapped using Cloud KMS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

/// <summary>Transient crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Unwrapped crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

/// <summary>The key used by the encryption function. For deterministic encryption using AES-SIV, the provided key is internally expanded to 64 bytes prior to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>The custom info type to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom info type followed by the number of characters comprising the surrogate. The following scheme defines the format: {info type name}({surrogate character count}):{surrogate} For example, if the name of custom info type is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom info type 'Surrogate'. This facilitates reversal of the surrogate when it occurs in free text. Note: For record transformations where the entire cell in a table is being transformed, surrogates are not mandatory. Surrogates are used to denote the location of the token and are necessary for re-identification in free form text. In order for inspection to work properly, the name of this info type must not occur naturally anywhere in your data; otherwise, inspection may either - reverse a surrogate that does not correspond to an actual identifier - be unable to parse the surrogate and result in an error Therefore, choose your custom info type name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Deterministic Crypto</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>A context may be used for higher security and maintaining referential integrity such that the same identifier in two different contexts will be given a distinct surrogate. The context is appended to plaintext value being encrypted. On decryption the provided context is validated against the value used during encryption. If a context was provided during encryption, same context must be provided during decryption as well. If the context is not set, plaintext would be used as is for encryption. If the context is set but: 1. there is no record present when transforming a given value or 2. the field is not present when transforming a given value, plaintext would be used as is for encryption. Note that case (1) is expected when an `InfoTypeTransformation` is applied to both structured and non-structured `ContentItem`s.</summary>
    [JsonPropertyName("context")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigContext? Context { get; set; }

    /// <summary>The key used by the encryption function. For deterministic encryption using AES-SIV, the provided key is internally expanded to 64 bytes prior to use.</summary>
    [JsonPropertyName("cryptoKey")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>The custom info type to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom info type followed by the number of characters comprising the surrogate. The following scheme defines the format: {info type name}({surrogate character count}):{surrogate} For example, if the name of custom info type is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom info type 'Surrogate'. This facilitates reversal of the surrogate when it occurs in free text. Note: For record transformations where the entire cell in a table is being transformed, surrogates are not mandatory. Surrogates are used to denote the location of the token and are necessary for re-identification in free form text. In order for inspection to work properly, the name of this info type must not occur naturally anywhere in your data; otherwise, inspection may either - reverse a surrogate that does not correspond to an actual identifier - be unable to parse the surrogate and result in an error Therefore, choose your custom info type name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrappedCryptoKeyRef
{
    /// <summary>Required. The resource name of the KMS CryptoKey to use for unwrapping.  Allowed value: The Google Cloud resource name of a `KMSCryptoKey` resource (format: `{{selfLink}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Key wrapped using Cloud KMS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

/// <summary>Transient crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Unwrapped crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

/// <summary>The key used by the hash function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>Crypto</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>The key used by the hash function.</summary>
    [JsonPropertyName("cryptoKey")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey? CryptoKey { get; set; }
}

/// <summary>The 'tweak', a context may be used for higher security since the same identifier in two different contexts won't be given the same surrogate. If the context is not set, a default tweak will be used. If the context is set but: 1. there is no record present when transforming a given value or 1. the field is not present when transforming a given value, a default tweak will be used. Note that case (1) is expected when an `InfoTypeTransformation` is applied to both structured and non-structured `ContentItem`s. Currently, the referenced field may be of value type integer or string. The tweak is constructed as a sequence of bytes in big endian byte order such that: - a 64 bit integer is encoded followed by a single byte of value 1 - a string is encoded in UTF-8 format followed by a single byte of value 2</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrappedCryptoKeyRef
{
    /// <summary>Required. The resource name of the KMS CryptoKey to use for unwrapping.  Allowed value: The Google Cloud resource name of a `KMSCryptoKey` resource (format: `{{selfLink}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Key wrapped using Cloud KMS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

/// <summary>Transient crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Unwrapped crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

/// <summary>Required. The key used by the encryption algorithm.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType [`SurrogateType`](https://cloud.google.com/dlp/docs/reference/rest/v2/InspectConfig#surrogatetype). This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Ffx-Fpe</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>Common alphabets. Possible values: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC</summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>The 'tweak', a context may be used for higher security since the same identifier in two different contexts won't be given the same surrogate. If the context is not set, a default tweak will be used. If the context is set but: 1. there is no record present when transforming a given value or 1. the field is not present when transforming a given value, a default tweak will be used. Note that case (1) is expected when an `InfoTypeTransformation` is applied to both structured and non-structured `ContentItem`s. Currently, the referenced field may be of value type integer or string. The tweak is constructed as a sequence of bytes in big endian byte order such that: - a 64 bit integer is encoded followed by a single byte of value 1 - a string is encoded in UTF-8 format followed by a single byte of value 2</summary>
    [JsonPropertyName("context")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext? Context { get; set; }

    /// <summary>Required. The key used by the encryption algorithm.</summary>
    [JsonPropertyName("cryptoKey")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey CryptoKey { get; set; }

    /// <summary>This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is: ``0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&amp;*()_-+={[}]|:;"'&lt;,&gt;.?/``</summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public long? Radix { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType [`SurrogateType`](https://cloud.google.com/dlp/docs/reference/rest/v2/InspectConfig#surrogatetype). This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE</summary>
    [JsonPropertyName("surrogateInfoType")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrappedCryptoKeyRef
{
    /// <summary>Required. The resource name of the KMS CryptoKey to use for unwrapping.  Allowed value: The Google Cloud resource name of a `KMSCryptoKey` resource (format: `{{selfLink}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Key wrapped using Cloud KMS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

/// <summary>Transient crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Unwrapped crypto key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

/// <summary>Causes the shift to be computed based on this key and the context. This results in the same shift for the same context and crypto_key. If set, must also set context. Can only be applied to table items.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>Date Shift</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context.</summary>
    [JsonPropertyName("context")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigContext? Context { get; set; }

    /// <summary>Causes the shift to be computed based on this key and the context. This results in the same shift for the same context and crypto_key. If set, must also set context. Can only be applied to table items.</summary>
    [JsonPropertyName("cryptoKey")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>Required. For example, -5 means shift date to at most 5 days back in the past.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public long LowerBoundDays { get; set; }

    /// <summary>Required. Range of shift in days. Actual shift will be selected at random within this range (inclusive ends). Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction. For example, 3 means shift date to at most 3 days into the future.</summary>
    [JsonPropertyName("upperBoundDays")]
    public long UpperBoundDays { get; set; }
}

/// <summary>date</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>time of day</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public long? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public long? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Required. Lower bound value of buckets. All values less than `lower_bound` are grouped together into a single bucket; for example if `lower_bound` = 10, then all values less than 10 are replaced with the value "-10".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue? DateValue { get; set; }

    /// <summary>day of week Possible values: DAY_OF_WEEK_UNSPECIFIED, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>float</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>integer</summary>
    [JsonPropertyName("integerValue")]
    public long? IntegerValue { get; set; }

    /// <summary>string</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>time of day</summary>
    [JsonPropertyName("timeValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>date</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>time of day</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public long? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public long? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Required. Upper bound value of buckets. All values greater than upper_bound are grouped together into a single bucket; for example if `upper_bound` = 89, then all values greater than 89 are replaced with the value "89+".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue? DateValue { get; set; }

    /// <summary>day of week Possible values: DAY_OF_WEEK_UNSPECIFIED, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>float</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>integer</summary>
    [JsonPropertyName("integerValue")]
    public long? IntegerValue { get; set; }

    /// <summary>string</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>time of day</summary>
    [JsonPropertyName("timeValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>Fixed size bucketing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>Required. Size of each bucket (except for minimum and maximum buckets). So if `lower_bound` = 10, `upper_bound` = 89, and `bucket_size` = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+. Precision up to 2 decimals works.</summary>
    [JsonPropertyName("bucketSize")]
    public double BucketSize { get; set; }

    /// <summary>Required. Lower bound value of buckets. All values less than `lower_bound` are grouped together into a single bucket; for example if `lower_bound` = 10, then all values less than 10 are replaced with the value "-10".</summary>
    [JsonPropertyName("lowerBound")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound LowerBound { get; set; }

    /// <summary>Required. Upper bound value of buckets. All values greater than upper_bound are grouped together into a single bucket; for example if `upper_bound` = 89, then all values greater than 89 are replaced with the value "89+".</summary>
    [JsonPropertyName("upperBound")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound UpperBound { get; set; }
}

/// <summary>date</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>time of day</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public long? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public long? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Value to replace it with.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue? DateValue { get; set; }

    /// <summary>day of week Possible values: DAY_OF_WEEK_UNSPECIFIED, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>float</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>integer</summary>
    [JsonPropertyName("integerValue")]
    public long? IntegerValue { get; set; }

    /// <summary>string</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>time of day</summary>
    [JsonPropertyName("timeValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>Replace with a specified value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>Value to replace it with.</summary>
    [JsonPropertyName("newValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValue? NewValue { get; set; }
}

/// <summary>Time extraction</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>The part of the time to keep. Possible values: TIME_PART_UNSPECIFIED, YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY</summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

/// <summary>Apply the transformation to the entire field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformation
{
    /// <summary>Bucketing</summary>
    [JsonPropertyName("bucketingConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfig? BucketingConfig { get; set; }

    /// <summary>Mask</summary>
    [JsonPropertyName("characterMaskConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfig? CharacterMaskConfig { get; set; }

    /// <summary>Deterministic Crypto</summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfig? CryptoDeterministicConfig { get; set; }

    /// <summary>Crypto</summary>
    [JsonPropertyName("cryptoHashConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfig? CryptoHashConfig { get; set; }

    /// <summary>Ffx-Fpe</summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>Date Shift</summary>
    [JsonPropertyName("dateShiftConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfig? DateShiftConfig { get; set; }

    /// <summary>Fixed size bucketing</summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfig? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact</summary>
    [JsonPropertyName("redactConfig")]
    public JsonNode? RedactConfig { get; set; }

    /// <summary>Replace with a specified value.</summary>
    [JsonPropertyName("replaceConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfig? ReplaceConfig { get; set; }

    /// <summary>Replace with infotype</summary>
    [JsonPropertyName("replaceWithInfoTypeConfig")]
    public JsonNode? ReplaceWithInfoTypeConfig { get; set; }

    /// <summary>Time extraction</summary>
    [JsonPropertyName("timePartConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationTimePartConfig? TimePartConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformations
{
    /// <summary>Only apply the transformation if the condition evaluates to true for the given `RecordCondition`. The conditions are allowed to reference fields that are not used in the actual transformation. Example Use Cases: - Apply a different bucket transformation to an age column if the zip code column for the same record is within a specific range. - Redact a field if the date of birth field is greater than 85.</summary>
    [JsonPropertyName("condition")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsCondition? Condition { get; set; }

    /// <summary>Required. Input field(s) to apply the transformation to. When you have columns that reference their position within a list, omit the index from the FieldId. FieldId name matching ignores the index. For example, instead of "contact.nums[0].type", use "contact.nums.type".</summary>
    [JsonPropertyName("fields")]
    public IList<DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsFields> Fields { get; set; }

    /// <summary>Treat the contents of the field as free text, and selectively transform content that matches an `InfoType`.</summary>
    [JsonPropertyName("infoTypeTransformations")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformations? InfoTypeTransformations { get; set; }

    /// <summary>Apply the transformation to the entire field.</summary>
    [JsonPropertyName("primitiveTransformation")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformation? PrimitiveTransformation { get; set; }
}

/// <summary>Required. Field within the record this condition is evaluated against.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsField
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>date</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueDateValue
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>time of day</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public long? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public long? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public long? Seconds { get; set; }
}

/// <summary>Value to compare against. [Mandatory, except for `EXISTS` tests.]</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValue
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueDateValue? DateValue { get; set; }

    /// <summary>day of week Possible values: DAY_OF_WEEK_UNSPECIFIED, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>float</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>integer</summary>
    [JsonPropertyName("integerValue")]
    public long? IntegerValue { get; set; }

    /// <summary>string</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>time of day</summary>
    [JsonPropertyName("timeValue")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditions
{
    /// <summary>Required. Field within the record this condition is evaluated against.</summary>
    [JsonPropertyName("field")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsField Field { get; set; }

    /// <summary>Required. Operator used to compare the field or infoType to the value. Possible values: LOGICAL_OPERATOR_UNSPECIFIED, AND</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>Value to compare against. [Mandatory, except for `EXISTS` tests.]</summary>
    [JsonPropertyName("value")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValue? Value { get; set; }
}

/// <summary>Conditions to apply to the expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditions
{
    /// <summary>A collection of conditions.</summary>
    [JsonPropertyName("conditions")]
    public IList<DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditions>? Conditions { get; set; }
}

/// <summary>An expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressions
{
    /// <summary>Conditions to apply to the expression.</summary>
    [JsonPropertyName("conditions")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditions? Conditions { get; set; }

    /// <summary>The operator to apply to the result of conditions. Default and currently only supported value is `AND`. Possible values: LOGICAL_OPERATOR_UNSPECIFIED, AND</summary>
    [JsonPropertyName("logicalOperator")]
    public string? LogicalOperator { get; set; }
}

/// <summary>A condition that when it evaluates to true will result in the record being evaluated to be suppressed from the transformed content.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsCondition
{
    /// <summary>An expression.</summary>
    [JsonPropertyName("expressions")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressions? Expressions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressions
{
    /// <summary>A condition that when it evaluates to true will result in the record being evaluated to be suppressed from the transformed content.</summary>
    [JsonPropertyName("condition")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsCondition? Condition { get; set; }
}

/// <summary>Treat the dataset as structured. Transformations can be applied to specific locations within structured datasets, such as transforming a column within a table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformations
{
    /// <summary>Transform the record by applying various field transformations.</summary>
    [JsonPropertyName("fieldTransformations")]
    public IList<DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformations>? FieldTransformations { get; set; }

    /// <summary>Configuration defining which records get suppressed entirely. Records that match any suppression rule are omitted from the output.</summary>
    [JsonPropertyName("recordSuppressions")]
    public IList<DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressions>? RecordSuppressions { get; set; }
}

/// <summary>Mode for handling transformation errors. If left unspecified, the default mode is `TransformationErrorHandling.ThrowError`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfigTransformationErrorHandling
{
    /// <summary>Ignore errors</summary>
    [JsonPropertyName("leaveUntransformed")]
    public JsonNode? LeaveUntransformed { get; set; }

    /// <summary>Throw an error</summary>
    [JsonPropertyName("throwError")]
    public JsonNode? ThrowError { get; set; }
}

/// <summary>The core content of the template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecDeidentifyConfig
{
    /// <summary>Treat the dataset as free-form text and apply the same free text transformation everywhere.</summary>
    [JsonPropertyName("infoTypeTransformations")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformations? InfoTypeTransformations { get; set; }

    /// <summary>Treat the dataset as structured. Transformations can be applied to specific locations within structured datasets, such as transforming a column within a table.</summary>
    [JsonPropertyName("recordTransformations")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformations? RecordTransformations { get; set; }

    /// <summary>Mode for handling transformation errors. If left unspecified, the default mode is `TransformationErrorHandling.ThrowError`.</summary>
    [JsonPropertyName("transformationErrorHandling")]
    public DLPDeidentifyTemplateSpecDeidentifyConfigTransformationErrorHandling? TransformationErrorHandling { get; set; }
}

/// <summary>Immutable. The Organization that this resource belongs to. Only one of [organizationRef, projectRef] may be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecOrganizationRef
{
    /// <summary>Allowed value: The Google Cloud resource name of a Google Cloud Organization (format: `organizations/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>[WARNING] Organization not yet supported in Config Connector, use 'external' field to reference existing resources. Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to. Only one of [organizationRef, projectRef] may be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpecProjectRef
{
    /// <summary>Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateSpec
{
    /// <summary>The core content of the template.</summary>
    [JsonPropertyName("deidentifyConfig")]
    public DLPDeidentifyTemplateSpecDeidentifyConfig? DeidentifyConfig { get; set; }

    /// <summary>Short description (max 256 chars).</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display name (max 256 chars).</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Immutable. The location of the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Immutable. The Organization that this resource belongs to. Only one of [organizationRef, projectRef] may be specified.</summary>
    [JsonPropertyName("organizationRef")]
    public DLPDeidentifyTemplateSpecOrganizationRef? OrganizationRef { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to. Only one of [organizationRef, projectRef] may be specified.</summary>
    [JsonPropertyName("projectRef")]
    public DLPDeidentifyTemplateSpecProjectRef? ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplateStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<DLPDeidentifyTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The creation timestamp of an inspectTemplate.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The geographic location where this resource is stored.</summary>
    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. The last update timestamp of an inspectTemplate.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DLPDeidentifyTemplate
{
    /// <summary>apiVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public DLPDeidentifyTemplateMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public DLPDeidentifyTemplateSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public DLPDeidentifyTemplateStatus? Status { get; set; }
}