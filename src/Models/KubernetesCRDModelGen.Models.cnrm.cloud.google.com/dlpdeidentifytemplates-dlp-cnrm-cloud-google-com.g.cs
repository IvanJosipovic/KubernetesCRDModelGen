using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dlp.cnrm.cloud.google.com;
public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypes
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue? DateValue { get; set; }

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
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue? DateValue { get; set; }

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
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue? DateValue { get; set; }

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
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>Upper bound of the range, exclusive; type must match min.</summary>
    [JsonPropertyName("max")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax? Max { get; set; }

    /// <summary>Lower bound of the range, inclusive. Type should be the same as max if used.</summary>
    [JsonPropertyName("min")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin? Min { get; set; }

    /// <summary>Required. Replacement value for this bucket.</summary>
    [JsonPropertyName("replacementValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue ReplacementValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>Set of buckets. Ranges must be non-overlapping.</summary>
    [JsonPropertyName("buckets")]
    public IList<V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>Common characters to not transform when masking. Useful to avoid removing punctuation. Possible values: COMMON_CHARS_TO_IGNORE_UNSPECIFIED, NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE</summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig
{
    /// <summary>When masking a string, items in this list will be skipped when replacing characters. For example, if the input string is `555-555-5555` and you instruct Cloud DLP to skip `-` and mask 5 characters with `*`, Cloud DLP returns `***-**5-5555`.</summary>
    [JsonPropertyName("charactersToIgnore")]
    public IList<V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrappedCryptoKeyRef
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>A context may be used for higher security and maintaining referential integrity such that the same identifier in two different contexts will be given a distinct surrogate. The context is appended to plaintext value being encrypted. On decryption the provided context is validated against the value used during encryption. If a context was provided during encryption, same context must be provided during decryption as well. If the context is not set, plaintext would be used as is for encryption. If the context is set but: 1. there is no record present when transforming a given value or 2. the field is not present when transforming a given value, plaintext would be used as is for encryption. Note that case (1) is expected when an `InfoTypeTransformation` is applied to both structured and non-structured `ContentItem`s.</summary>
    [JsonPropertyName("context")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext? Context { get; set; }

    /// <summary>The key used by the encryption function. For deterministic encryption using AES-SIV, the provided key is internally expanded to 64 bytes prior to use.</summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>The custom info type to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom info type followed by the number of characters comprising the surrogate. The following scheme defines the format: {info type name}({surrogate character count}):{surrogate} For example, if the name of custom info type is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom info type 'Surrogate'. This facilitates reversal of the surrogate when it occurs in free text. Note: For record transformations where the entire cell in a table is being transformed, surrogates are not mandatory. Surrogates are used to denote the location of the token and are necessary for re-identification in free form text. In order for inspection to work properly, the name of this info type must not occur naturally anywhere in your data; otherwise, inspection may either - reverse a surrogate that does not correspond to an actual identifier - be unable to parse the surrogate and result in an error Therefore, choose your custom info type name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrappedCryptoKeyRef
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>The key used by the hash function.</summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey? CryptoKey { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrappedCryptoKeyRef
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>Common alphabets. Possible values: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC</summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>The 'tweak', a context may be used for higher security since the same identifier in two different contexts won't be given the same surrogate. If the context is not set, a default tweak will be used. If the context is set but: 1. there is no record present when transforming a given value or 1. the field is not present when transforming a given value, a default tweak will be used. Note that case (1) is expected when an `InfoTypeTransformation` is applied to both structured and non-structured `ContentItem`s. Currently, the referenced field may be of value type integer or string. The tweak is constructed as a sequence of bytes in big endian byte order such that: - a 64 bit integer is encoded followed by a single byte of value 1 - a string is encoded in UTF-8 format followed by a single byte of value 2</summary>
    [JsonPropertyName("context")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext? Context { get; set; }

    /// <summary>Required. The key used by the encryption algorithm.</summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey CryptoKey { get; set; }

    /// <summary>This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is: ``0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&*()_-+={[}]|:;"'<,>.?/``</summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public long? Radix { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType [`SurrogateType`](https://cloud.google.com/dlp/docs/reference/rest/v2/InspectConfig#surrogatetype). This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE</summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrappedCryptoKeyRef
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context.</summary>
    [JsonPropertyName("context")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext? Context { get; set; }

    /// <summary>Causes the shift to be computed based on this key and the context. This results in the same shift for the same context and crypto_key. If set, must also set context. Can only be applied to table items.</summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>Required. For example, -5 means shift date to at most 5 days back in the past.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public long LowerBoundDays { get; set; }

    /// <summary>Required. Range of shift in days. Actual shift will be selected at random within this range (inclusive ends). Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction. For example, 3 means shift date to at most 3 days into the future.</summary>
    [JsonPropertyName("upperBoundDays")]
    public long UpperBoundDays { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue? DateValue { get; set; }

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
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue? DateValue { get; set; }

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
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>Required. Size of each bucket (except for minimum and maximum buckets). So if `lower_bound` = 10, `upper_bound` = 89, and `bucket_size` = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+. Precision up to 2 decimals works.</summary>
    [JsonPropertyName("bucketSize")]
    public double BucketSize { get; set; }

    /// <summary>Required. Lower bound value of buckets. All values less than `lower_bound` are grouped together into a single bucket; for example if `lower_bound` = 10, then all values less than 10 are replaced with the value "-10".</summary>
    [JsonPropertyName("lowerBound")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound LowerBound { get; set; }

    /// <summary>Required. Upper bound value of buckets. All values greater than upper_bound are grouped together into a single bucket; for example if `upper_bound` = 89, then all values greater than 89 are replaced with the value "89+".</summary>
    [JsonPropertyName("upperBound")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound UpperBound { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue? DateValue { get; set; }

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
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>Value to replace it with.</summary>
    [JsonPropertyName("newValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue? NewValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>The part of the time to keep. Possible values: TIME_PART_UNSPECIFIED, YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY</summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformation
{
    /// <summary>Bucketing</summary>
    [JsonPropertyName("bucketingConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig? BucketingConfig { get; set; }

    /// <summary>Mask</summary>
    [JsonPropertyName("characterMaskConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig? CharacterMaskConfig { get; set; }

    /// <summary>Deterministic Crypto</summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig? CryptoDeterministicConfig { get; set; }

    /// <summary>Crypto</summary>
    [JsonPropertyName("cryptoHashConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig? CryptoHashConfig { get; set; }

    /// <summary>Ffx-Fpe</summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>Date Shift</summary>
    [JsonPropertyName("dateShiftConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig? DateShiftConfig { get; set; }

    /// <summary>Fixed size bucketing</summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact</summary>
    [JsonPropertyName("redactConfig")]
    public JsonNode? RedactConfig { get; set; }

    /// <summary>Replace with a specified value.</summary>
    [JsonPropertyName("replaceConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig? ReplaceConfig { get; set; }

    /// <summary>Replace with infotype</summary>
    [JsonPropertyName("replaceWithInfoTypeConfig")]
    public JsonNode? ReplaceWithInfoTypeConfig { get; set; }

    /// <summary>Time extraction</summary>
    [JsonPropertyName("timePartConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig? TimePartConfig { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformations
{
    /// <summary>InfoTypes to apply the transformation to. An empty list will cause this transformation to apply to all findings that correspond to infoTypes that were requested in `InspectConfig`.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypes>? InfoTypes { get; set; }

    /// <summary>Required. Primitive transformation to apply to the infoType.</summary>
    [JsonPropertyName("primitiveTransformation")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformation PrimitiveTransformation { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformations
{
    /// <summary>Required. Transformation for each infoType. Cannot specify more than one for a given infoType.</summary>
    [JsonPropertyName("transformations")]
    public IList<V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformationsTransformations> Transformations { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsField
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueDateValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueTimeValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValue
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueDateValue? DateValue { get; set; }

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
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditions
{
    /// <summary>Required. Field within the record this condition is evaluated against.</summary>
    [JsonPropertyName("field")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsField Field { get; set; }

    /// <summary>Required. Operator used to compare the field or infoType to the value. Possible values: LOGICAL_OPERATOR_UNSPECIFIED, AND</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>Value to compare against. [Mandatory, except for `EXISTS` tests.]</summary>
    [JsonPropertyName("value")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValue? Value { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditions
{
    /// <summary>A collection of conditions.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditions>? Conditions { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressions
{
    /// <summary>Conditions to apply to the expression.</summary>
    [JsonPropertyName("conditions")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditions? Conditions { get; set; }

    /// <summary>The operator to apply to the result of conditions. Default and currently only supported value is `AND`. Possible values: LOGICAL_OPERATOR_UNSPECIFIED, AND</summary>
    [JsonPropertyName("logicalOperator")]
    public string? LogicalOperator { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsCondition
{
    /// <summary>An expression.</summary>
    [JsonPropertyName("expressions")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressions? Expressions { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsFields
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypes
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue? DateValue { get; set; }

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
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue? DateValue { get; set; }

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
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue? DateValue { get; set; }

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
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>Upper bound of the range, exclusive; type must match min.</summary>
    [JsonPropertyName("max")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax? Max { get; set; }

    /// <summary>Lower bound of the range, inclusive. Type should be the same as max if used.</summary>
    [JsonPropertyName("min")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin? Min { get; set; }

    /// <summary>Required. Replacement value for this bucket.</summary>
    [JsonPropertyName("replacementValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue ReplacementValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>Set of buckets. Ranges must be non-overlapping.</summary>
    [JsonPropertyName("buckets")]
    public IList<V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>Common characters to not transform when masking. Useful to avoid removing punctuation. Possible values: COMMON_CHARS_TO_IGNORE_UNSPECIFIED, NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE</summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig
{
    /// <summary>When masking a string, items in this list will be skipped when replacing characters. For example, if the input string is `555-555-5555` and you instruct Cloud DLP to skip `-` and mask 5 characters with `*`, Cloud DLP returns `***-**5-5555`.</summary>
    [JsonPropertyName("charactersToIgnore")]
    public IList<V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrappedCryptoKeyRef
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>A context may be used for higher security and maintaining referential integrity such that the same identifier in two different contexts will be given a distinct surrogate. The context is appended to plaintext value being encrypted. On decryption the provided context is validated against the value used during encryption. If a context was provided during encryption, same context must be provided during decryption as well. If the context is not set, plaintext would be used as is for encryption. If the context is set but: 1. there is no record present when transforming a given value or 2. the field is not present when transforming a given value, plaintext would be used as is for encryption. Note that case (1) is expected when an `InfoTypeTransformation` is applied to both structured and non-structured `ContentItem`s.</summary>
    [JsonPropertyName("context")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext? Context { get; set; }

    /// <summary>The key used by the encryption function. For deterministic encryption using AES-SIV, the provided key is internally expanded to 64 bytes prior to use.</summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>The custom info type to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom info type followed by the number of characters comprising the surrogate. The following scheme defines the format: {info type name}({surrogate character count}):{surrogate} For example, if the name of custom info type is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom info type 'Surrogate'. This facilitates reversal of the surrogate when it occurs in free text. Note: For record transformations where the entire cell in a table is being transformed, surrogates are not mandatory. Surrogates are used to denote the location of the token and are necessary for re-identification in free form text. In order for inspection to work properly, the name of this info type must not occur naturally anywhere in your data; otherwise, inspection may either - reverse a surrogate that does not correspond to an actual identifier - be unable to parse the surrogate and result in an error Therefore, choose your custom info type name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrappedCryptoKeyRef
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>The key used by the hash function.</summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey? CryptoKey { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrappedCryptoKeyRef
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>Common alphabets. Possible values: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC</summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>The 'tweak', a context may be used for higher security since the same identifier in two different contexts won't be given the same surrogate. If the context is not set, a default tweak will be used. If the context is set but: 1. there is no record present when transforming a given value or 1. the field is not present when transforming a given value, a default tweak will be used. Note that case (1) is expected when an `InfoTypeTransformation` is applied to both structured and non-structured `ContentItem`s. Currently, the referenced field may be of value type integer or string. The tweak is constructed as a sequence of bytes in big endian byte order such that: - a 64 bit integer is encoded followed by a single byte of value 1 - a string is encoded in UTF-8 format followed by a single byte of value 2</summary>
    [JsonPropertyName("context")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext? Context { get; set; }

    /// <summary>Required. The key used by the encryption algorithm.</summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey CryptoKey { get; set; }

    /// <summary>This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is: ``0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&*()_-+={[}]|:;"'<,>.?/``</summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public long? Radix { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType [`SurrogateType`](https://cloud.google.com/dlp/docs/reference/rest/v2/InspectConfig#surrogatetype). This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE</summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrappedCryptoKeyRef
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context.</summary>
    [JsonPropertyName("context")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext? Context { get; set; }

    /// <summary>Causes the shift to be computed based on this key and the context. This results in the same shift for the same context and crypto_key. If set, must also set context. Can only be applied to table items.</summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>Required. For example, -5 means shift date to at most 5 days back in the past.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public long LowerBoundDays { get; set; }

    /// <summary>Required. Range of shift in days. Actual shift will be selected at random within this range (inclusive ends). Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction. For example, 3 means shift date to at most 3 days into the future.</summary>
    [JsonPropertyName("upperBoundDays")]
    public long UpperBoundDays { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue? DateValue { get; set; }

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
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue? DateValue { get; set; }

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
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>Required. Size of each bucket (except for minimum and maximum buckets). So if `lower_bound` = 10, `upper_bound` = 89, and `bucket_size` = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+. Precision up to 2 decimals works.</summary>
    [JsonPropertyName("bucketSize")]
    public double BucketSize { get; set; }

    /// <summary>Required. Lower bound value of buckets. All values less than `lower_bound` are grouped together into a single bucket; for example if `lower_bound` = 10, then all values less than 10 are replaced with the value "-10".</summary>
    [JsonPropertyName("lowerBound")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound LowerBound { get; set; }

    /// <summary>Required. Upper bound value of buckets. All values greater than upper_bound are grouped together into a single bucket; for example if `upper_bound` = 89, then all values greater than 89 are replaced with the value "89+".</summary>
    [JsonPropertyName("upperBound")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound UpperBound { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue? DateValue { get; set; }

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
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>Value to replace it with.</summary>
    [JsonPropertyName("newValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue? NewValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>The part of the time to keep. Possible values: TIME_PART_UNSPECIFIED, YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY</summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformation
{
    /// <summary>Bucketing</summary>
    [JsonPropertyName("bucketingConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig? BucketingConfig { get; set; }

    /// <summary>Mask</summary>
    [JsonPropertyName("characterMaskConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig? CharacterMaskConfig { get; set; }

    /// <summary>Deterministic Crypto</summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig? CryptoDeterministicConfig { get; set; }

    /// <summary>Crypto</summary>
    [JsonPropertyName("cryptoHashConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig? CryptoHashConfig { get; set; }

    /// <summary>Ffx-Fpe</summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>Date Shift</summary>
    [JsonPropertyName("dateShiftConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig? DateShiftConfig { get; set; }

    /// <summary>Fixed size bucketing</summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact</summary>
    [JsonPropertyName("redactConfig")]
    public JsonNode? RedactConfig { get; set; }

    /// <summary>Replace with a specified value.</summary>
    [JsonPropertyName("replaceConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig? ReplaceConfig { get; set; }

    /// <summary>Replace with infotype</summary>
    [JsonPropertyName("replaceWithInfoTypeConfig")]
    public JsonNode? ReplaceWithInfoTypeConfig { get; set; }

    /// <summary>Time extraction</summary>
    [JsonPropertyName("timePartConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig? TimePartConfig { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformations
{
    /// <summary>InfoTypes to apply the transformation to. An empty list will cause this transformation to apply to all findings that correspond to infoTypes that were requested in `InspectConfig`.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypes>? InfoTypes { get; set; }

    /// <summary>Required. Primitive transformation to apply to the infoType.</summary>
    [JsonPropertyName("primitiveTransformation")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformation PrimitiveTransformation { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformations
{
    /// <summary>Required. Transformation for each infoType. Cannot specify more than one for a given infoType.</summary>
    [JsonPropertyName("transformations")]
    public IList<V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformations> Transformations { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue? DateValue { get; set; }

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
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue? DateValue { get; set; }

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
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue? DateValue { get; set; }

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
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>Upper bound of the range, exclusive; type must match min.</summary>
    [JsonPropertyName("max")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMax? Max { get; set; }

    /// <summary>Lower bound of the range, inclusive. Type should be the same as max if used.</summary>
    [JsonPropertyName("min")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMin? Min { get; set; }

    /// <summary>Required. Replacement value for this bucket.</summary>
    [JsonPropertyName("replacementValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue ReplacementValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>Set of buckets. Ranges must be non-overlapping.</summary>
    [JsonPropertyName("buckets")]
    public IList<V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>Common characters to not transform when masking. Useful to avoid removing punctuation. Possible values: COMMON_CHARS_TO_IGNORE_UNSPECIFIED, NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE</summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfig
{
    /// <summary>When masking a string, items in this list will be skipped when replacing characters. For example, if the input string is `555-555-5555` and you instruct Cloud DLP to skip `-` and mask 5 characters with `*`, Cloud DLP returns `***-**5-5555`.</summary>
    [JsonPropertyName("charactersToIgnore")]
    public IList<V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrappedCryptoKeyRef
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>A context may be used for higher security and maintaining referential integrity such that the same identifier in two different contexts will be given a distinct surrogate. The context is appended to plaintext value being encrypted. On decryption the provided context is validated against the value used during encryption. If a context was provided during encryption, same context must be provided during decryption as well. If the context is not set, plaintext would be used as is for encryption. If the context is set but: 1. there is no record present when transforming a given value or 2. the field is not present when transforming a given value, plaintext would be used as is for encryption. Note that case (1) is expected when an `InfoTypeTransformation` is applied to both structured and non-structured `ContentItem`s.</summary>
    [JsonPropertyName("context")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigContext? Context { get; set; }

    /// <summary>The key used by the encryption function. For deterministic encryption using AES-SIV, the provided key is internally expanded to 64 bytes prior to use.</summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>The custom info type to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom info type followed by the number of characters comprising the surrogate. The following scheme defines the format: {info type name}({surrogate character count}):{surrogate} For example, if the name of custom info type is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom info type 'Surrogate'. This facilitates reversal of the surrogate when it occurs in free text. Note: For record transformations where the entire cell in a table is being transformed, surrogates are not mandatory. Surrogates are used to denote the location of the token and are necessary for re-identification in free form text. In order for inspection to work properly, the name of this info type must not occur naturally anywhere in your data; otherwise, inspection may either - reverse a surrogate that does not correspond to an actual identifier - be unable to parse the surrogate and result in an error Therefore, choose your custom info type name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrappedCryptoKeyRef
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>The key used by the hash function.</summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey? CryptoKey { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrappedCryptoKeyRef
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern `[A-Za-z0-9$-_]{1,64}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>Common alphabets. Possible values: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC</summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>The 'tweak', a context may be used for higher security since the same identifier in two different contexts won't be given the same surrogate. If the context is not set, a default tweak will be used. If the context is set but: 1. there is no record present when transforming a given value or 1. the field is not present when transforming a given value, a default tweak will be used. Note that case (1) is expected when an `InfoTypeTransformation` is applied to both structured and non-structured `ContentItem`s. Currently, the referenced field may be of value type integer or string. The tweak is constructed as a sequence of bytes in big endian byte order such that: - a 64 bit integer is encoded followed by a single byte of value 1 - a string is encoded in UTF-8 format followed by a single byte of value 2</summary>
    [JsonPropertyName("context")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext? Context { get; set; }

    /// <summary>Required. The key used by the encryption algorithm.</summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey CryptoKey { get; set; }

    /// <summary>This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is: ``0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&*()_-+={[}]|:;"'<,>.?/``</summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public long? Radix { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType [`SurrogateType`](https://cloud.google.com/dlp/docs/reference/rest/v2/InspectConfig#surrogatetype). This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE</summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrappedCryptoKeyRef
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary></summary>
    [JsonPropertyName("cryptoKeyRef")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrappedCryptoKeyRef CryptoKeyRef { get; set; }

    /// <summary>Required. The wrapped data crypto key.</summary>
    [JsonPropertyName("wrappedKey")]
    public string WrappedKey { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>Required. A 128/192/256 bit key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>Key wrapped using Cloud KMS</summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>Transient crypto key</summary>
    [JsonPropertyName("transient")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>Unwrapped crypto key</summary>
    [JsonPropertyName("unwrapped")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context.</summary>
    [JsonPropertyName("context")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigContext? Context { get; set; }

    /// <summary>Causes the shift to be computed based on this key and the context. This results in the same shift for the same context and crypto_key. If set, must also set context. Can only be applied to table items.</summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>Required. For example, -5 means shift date to at most 5 days back in the past.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public long LowerBoundDays { get; set; }

    /// <summary>Required. Range of shift in days. Actual shift will be selected at random within this range (inclusive ends). Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction. For example, 3 means shift date to at most 3 days into the future.</summary>
    [JsonPropertyName("upperBoundDays")]
    public long UpperBoundDays { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue? DateValue { get; set; }

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
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue? DateValue { get; set; }

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
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>Required. Size of each bucket (except for minimum and maximum buckets). So if `lower_bound` = 10, `upper_bound` = 89, and `bucket_size` = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+. Precision up to 2 decimals works.</summary>
    [JsonPropertyName("bucketSize")]
    public double BucketSize { get; set; }

    /// <summary>Required. Lower bound value of buckets. All values less than `lower_bound` are grouped together into a single bucket; for example if `lower_bound` = 10, then all values less than 10 are replaced with the value "-10".</summary>
    [JsonPropertyName("lowerBound")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound LowerBound { get; set; }

    /// <summary>Required. Upper bound value of buckets. All values greater than upper_bound are grouped together into a single bucket; for example if `upper_bound` = 89, then all values greater than 89 are replaced with the value "89+".</summary>
    [JsonPropertyName("upperBound")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound UpperBound { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue? DateValue { get; set; }

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
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>Value to replace it with.</summary>
    [JsonPropertyName("newValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValue? NewValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>The part of the time to keep. Possible values: TIME_PART_UNSPECIFIED, YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY</summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformation
{
    /// <summary>Bucketing</summary>
    [JsonPropertyName("bucketingConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfig? BucketingConfig { get; set; }

    /// <summary>Mask</summary>
    [JsonPropertyName("characterMaskConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfig? CharacterMaskConfig { get; set; }

    /// <summary>Deterministic Crypto</summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfig? CryptoDeterministicConfig { get; set; }

    /// <summary>Crypto</summary>
    [JsonPropertyName("cryptoHashConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfig? CryptoHashConfig { get; set; }

    /// <summary>Ffx-Fpe</summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>Date Shift</summary>
    [JsonPropertyName("dateShiftConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfig? DateShiftConfig { get; set; }

    /// <summary>Fixed size bucketing</summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfig? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact</summary>
    [JsonPropertyName("redactConfig")]
    public JsonNode? RedactConfig { get; set; }

    /// <summary>Replace with a specified value.</summary>
    [JsonPropertyName("replaceConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfig? ReplaceConfig { get; set; }

    /// <summary>Replace with infotype</summary>
    [JsonPropertyName("replaceWithInfoTypeConfig")]
    public JsonNode? ReplaceWithInfoTypeConfig { get; set; }

    /// <summary>Time extraction</summary>
    [JsonPropertyName("timePartConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationTimePartConfig? TimePartConfig { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformations
{
    /// <summary>Only apply the transformation if the condition evaluates to true for the given `RecordCondition`. The conditions are allowed to reference fields that are not used in the actual transformation. Example Use Cases: - Apply a different bucket transformation to an age column if the zip code column for the same record is within a specific range. - Redact a field if the date of birth field is greater than 85.</summary>
    [JsonPropertyName("condition")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsCondition? Condition { get; set; }

    /// <summary>Required. Input field(s) to apply the transformation to. When you have columns that reference their position within a list, omit the index from the FieldId. FieldId name matching ignores the index. For example, instead of "contact.nums[0].type", use "contact.nums.type".</summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsFields> Fields { get; set; }

    /// <summary>Treat the contents of the field as free text, and selectively transform content that matches an `InfoType`.</summary>
    [JsonPropertyName("infoTypeTransformations")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformations? InfoTypeTransformations { get; set; }

    /// <summary>Apply the transformation to the entire field.</summary>
    [JsonPropertyName("primitiveTransformation")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformation? PrimitiveTransformation { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsField
{
    /// <summary>Name describing the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueDateValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueTimeValue
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

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValue
{
    /// <summary>boolean</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>date</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueDateValue? DateValue { get; set; }

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
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueTimeValue? TimeValue { get; set; }

    /// <summary>timestamp</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditions
{
    /// <summary>Required. Field within the record this condition is evaluated against.</summary>
    [JsonPropertyName("field")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsField Field { get; set; }

    /// <summary>Required. Operator used to compare the field or infoType to the value. Possible values: LOGICAL_OPERATOR_UNSPECIFIED, AND</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>Value to compare against. [Mandatory, except for `EXISTS` tests.]</summary>
    [JsonPropertyName("value")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValue? Value { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditions
{
    /// <summary>A collection of conditions.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditions>? Conditions { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressions
{
    /// <summary>Conditions to apply to the expression.</summary>
    [JsonPropertyName("conditions")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditions? Conditions { get; set; }

    /// <summary>The operator to apply to the result of conditions. Default and currently only supported value is `AND`. Possible values: LOGICAL_OPERATOR_UNSPECIFIED, AND</summary>
    [JsonPropertyName("logicalOperator")]
    public string? LogicalOperator { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsCondition
{
    /// <summary>An expression.</summary>
    [JsonPropertyName("expressions")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressions? Expressions { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressions
{
    /// <summary>A condition that when it evaluates to true will result in the record being evaluated to be suppressed from the transformed content.</summary>
    [JsonPropertyName("condition")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressionsCondition? Condition { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformations
{
    /// <summary>Transform the record by applying various field transformations.</summary>
    [JsonPropertyName("fieldTransformations")]
    public IList<V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsFieldTransformations>? FieldTransformations { get; set; }

    /// <summary>Configuration defining which records get suppressed entirely. Records that match any suppression rule are omitted from the output.</summary>
    [JsonPropertyName("recordSuppressions")]
    public IList<V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformationsRecordSuppressions>? RecordSuppressions { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigTransformationErrorHandling
{
    /// <summary>Ignore errors</summary>
    [JsonPropertyName("leaveUntransformed")]
    public JsonNode? LeaveUntransformed { get; set; }

    /// <summary>Throw an error</summary>
    [JsonPropertyName("throwError")]
    public JsonNode? ThrowError { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecDeidentifyConfig
{
    /// <summary>Treat the dataset as free-form text and apply the same free text transformation everywhere.</summary>
    [JsonPropertyName("infoTypeTransformations")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigInfoTypeTransformations? InfoTypeTransformations { get; set; }

    /// <summary>Treat the dataset as structured. Transformations can be applied to specific locations within structured datasets, such as transforming a column within a table.</summary>
    [JsonPropertyName("recordTransformations")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigRecordTransformations? RecordTransformations { get; set; }

    /// <summary>Mode for handling transformation errors. If left unspecified, the default mode is `TransformationErrorHandling.ThrowError`.</summary>
    [JsonPropertyName("transformationErrorHandling")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfigTransformationErrorHandling? TransformationErrorHandling { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateSpecOrganizationRef
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

public partial class V1beta1DLPDeidentifyTemplateSpecProjectRef
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

public partial class V1beta1DLPDeidentifyTemplateSpec
{
    /// <summary>The core content of the template.</summary>
    [JsonPropertyName("deidentifyConfig")]
    public V1beta1DLPDeidentifyTemplateSpecDeidentifyConfig? DeidentifyConfig { get; set; }

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
    public V1beta1DLPDeidentifyTemplateSpecOrganizationRef? OrganizationRef { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to. Only one of [organizationRef, projectRef] may be specified.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1DLPDeidentifyTemplateSpecProjectRef? ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

public partial class V1beta1DLPDeidentifyTemplateStatusConditions
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

public partial class V1beta1DLPDeidentifyTemplateStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DLPDeidentifyTemplateStatusConditions>? Conditions { get; set; }

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

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DLPDeidentifyTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DLPDeidentifyTemplateSpec>, IStatus<V1beta1DLPDeidentifyTemplateStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DLPDeidentifyTemplate";
    public const string KubeGroup = "dlp.cnrm.cloud.google.com";
    public const string KubePluralName = "dlpdeidentifytemplates";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1DLPDeidentifyTemplateSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1DLPDeidentifyTemplateStatus? Status { get; set; }
}