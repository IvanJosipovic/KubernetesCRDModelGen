using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datalossprevention.gcp.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DeidentifyTemplateSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsAllInfoTypes
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsAllText
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsRedactionColor
{
    /// <summary>The amount of blue in the color as a value in the interval [0, 1].</summary>
    [JsonPropertyName("blue")]
    public double? Blue { get; set; }

    /// <summary>The amount of green in the color as a value in the interval [0, 1].</summary>
    [JsonPropertyName("green")]
    public double? Green { get; set; }

    /// <summary>The amount of red in the color as a value in the interval [0, 1].</summary>
    [JsonPropertyName("red")]
    public double? Red { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypes
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypes
{
    /// <summary>InfoTypes to apply the transformation to. Leaving this empty will apply the transformation to apply to all findings that correspond to infoTypes that were requested in InspectConfig. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypes>? InfoTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransforms
{
    /// <summary>Apply transformation to all findings not specified in other ImageTransformation's selectedInfoTypes.</summary>
    [JsonPropertyName("allInfoTypes")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsAllInfoTypes>? AllInfoTypes { get; set; }

    /// <summary>Apply transformation to all text that doesn't match an infoType.</summary>
    [JsonPropertyName("allText")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsAllText>? AllText { get; set; }

    /// <summary>The color to use when redacting content from an image. If not specified, the default is black. Structure is documented below.</summary>
    [JsonPropertyName("redactionColor")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsRedactionColor>? RedactionColor { get; set; }

    /// <summary>Apply transformation to the selected infoTypes. Structure is documented below.</summary>
    [JsonPropertyName("selectedInfoTypes")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypes>? SelectedInfoTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformations
{
    /// <summary>For determination of how redaction of images should occur. Structure is documented below.</summary>
    [JsonPropertyName("transforms")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransforms>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypes
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>Upper bound of the range, exclusive; type must match min. The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("max")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax>? Max { get; set; }

    /// <summary>Lower bound of the range, inclusive. Type should be the same as max if used. The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("min")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin>? Min { get; set; }

    /// <summary>Replacement value for this bucket. The replacement_value block must only contain one argument. Structure is documented below.</summary>
    [JsonPropertyName("replacementValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue>? ReplacementValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>Set of buckets. Ranges must be non-overlapping. Bucket is represented as a range, along with replacement values. Structure is documented below.</summary>
    [JsonPropertyName("buckets")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>Common characters to not transform when masking. Useful to avoid removing punctuation. Possible values are: NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE.</summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig
{
    /// <summary></summary>
    [JsonPropertyName("charactersToIgnore")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

    /// <summary>is *</summary>
    [JsonPropertyName("maskingCharacter")]
    public string? MaskingCharacter { get; set; }

    /// <summary>4</summary>
    [JsonPropertyName("numberToMask")]
    public double? NumberToMask { get; set; }

    /// <summary>is false</summary>
    [JsonPropertyName("reverseOrder")]
    public bool? ReverseOrder { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE Structure is documented below.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType>? SurrogateInfoType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey>? CryptoKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>Common alphabets. Possible values are: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC.</summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is: 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&amp;*()_-+={[}]|:;"'&lt;,&gt;.?/</summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public double? Radix { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE Structure is documented below.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType>? SurrogateInfoType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>Range of shift in days. Negative means shift to earlier in time.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public double? LowerBoundDays { get; set; }

    /// <summary>Range of shift in days. Actual shift will be selected at random within this range (inclusive ends). Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction.</summary>
    [JsonPropertyName("upperBoundDays")]
    public double? UpperBoundDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>Size of each bucket (except for minimum and maximum buckets). So if lower_bound = 10, upper_bound = 89, and bucketSize = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+. Precision up to 2 decimals works.</summary>
    [JsonPropertyName("bucketSize")]
    public double? BucketSize { get; set; }

    /// <summary>Lower bound value of buckets. All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value "-10". The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("lowerBound")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound>? LowerBound { get; set; }

    /// <summary>Upper bound value of buckets. All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value "89+". The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("upperBound")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound>? UpperBound { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public double? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>Replace each input value with a given value. The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set. Structure is documented below.</summary>
    [JsonPropertyName("newValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue>? NewValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig
{
    /// <summary>A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList>? WordList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>The part of the time to keep. Possible values are: YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY.</summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformation
{
    /// <summary>Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH This can be used on data of type: number, long, string, timestamp. If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing. See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more. Structure is documented below.</summary>
    [JsonPropertyName("bucketingConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig>? BucketingConfig { get; set; }

    /// <summary>Partially mask a string by replacing a given number of characters with a fixed character. Masking can start from the beginning or end of the string. Structure is documented below.</summary>
    [JsonPropertyName("characterMaskConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig>? CharacterMaskConfig { get; set; }

    /// <summary>Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297. Structure is documented below.</summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig>? CryptoDeterministicConfig { get; set; }

    /// <summary>Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes. Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=). Currently, only string and integer values can be hashed. See https://cloud.google.com/dlp/docs/pseudonymization to learn more. Structure is documented below.</summary>
    [JsonPropertyName("cryptoHashConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig>? CryptoHashConfig { get; set; }

    /// <summary>Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more. Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity. Structure is documented below.</summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig>? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>Shifts dates by random number of days, with option to be consistent for the same context. Structure is documented below.</summary>
    [JsonPropertyName("dateShiftConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig>? DateShiftConfig { get; set; }

    /// <summary>Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies. The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with "10-20". This can be used on data of type: double, long. If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing. See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more. Structure is documented below.</summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig>? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input 'My phone number is 206-555-0123', the output would be 'My phone number is '.</summary>
    [JsonPropertyName("redactConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig>? RedactConfig { get; set; }

    /// <summary>Replace each input value with a given value. Structure is documented below.</summary>
    [JsonPropertyName("replaceConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig>? ReplaceConfig { get; set; }

    /// <summary>Replace with a value randomly drawn (with replacement) from a dictionary. Structure is documented below.</summary>
    [JsonPropertyName("replaceDictionaryConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig>? ReplaceDictionaryConfig { get; set; }

    /// <summary>Replace each matching finding with the name of the info type.</summary>
    [JsonPropertyName("replaceWithInfoTypeConfig")]
    public bool? ReplaceWithInfoTypeConfig { get; set; }

    /// <summary>For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value. Structure is documented below.</summary>
    [JsonPropertyName("timePartConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig>? TimePartConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformations
{
    /// <summary>InfoTypes to apply the transformation to. Leaving this empty will apply the transformation to apply to all findings that correspond to infoTypes that were requested in InspectConfig. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypes>? InfoTypes { get; set; }

    /// <summary>Primitive transformation to apply to the infoType. The primitive_transformation block must only contain one argument, corresponding to the type of transformation. Structure is documented below.</summary>
    [JsonPropertyName("primitiveTransformation")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformation>? PrimitiveTransformation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformations
{
    /// <summary>Transformation for each infoType. Cannot specify more than one for a given infoType. Structure is documented below.</summary>
    [JsonPropertyName("transformations")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformations>? Transformations { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsField
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditions
{
    /// <summary>Field within the record this condition is evaluated against. Structure is documented below.</summary>
    [JsonPropertyName("field")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsField>? Field { get; set; }

    /// <summary>Operator used to compare the field or infoType to the value. Possible values are: EQUAL_TO, NOT_EQUAL_TO, GREATER_THAN, LESS_THAN, GREATER_THAN_OR_EQUALS, LESS_THAN_OR_EQUALS, EXISTS.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Value to compare against. The value block must only contain one argument. For example when a condition is evaluated against a string-type field, only string_value should be set. This argument is mandatory, except for conditions using the EXISTS operator. Structure is documented below.</summary>
    [JsonPropertyName("value")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValue>? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditions
{
    /// <summary>Conditions to apply to the expression. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditions>? Conditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressions
{
    /// <summary>Conditions to apply to the expression. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditions>? Conditions { get; set; }

    /// <summary>The operator to apply to the result of conditions. Default and currently only supported value is AND. Default value is AND. Possible values are: AND.</summary>
    [JsonPropertyName("logicalOperator")]
    public string? LogicalOperator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsCondition
{
    /// <summary>An expression, consisting of an operator and conditions. Structure is documented below.</summary>
    [JsonPropertyName("expressions")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressions>? Expressions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsFields
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypes
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>Upper bound of the range, exclusive; type must match min. The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("max")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax>? Max { get; set; }

    /// <summary>Lower bound of the range, inclusive. Type should be the same as max if used. The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("min")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin>? Min { get; set; }

    /// <summary>Replacement value for this bucket. The replacement_value block must only contain one argument. Structure is documented below.</summary>
    [JsonPropertyName("replacementValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue>? ReplacementValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>Set of buckets. Ranges must be non-overlapping. Bucket is represented as a range, along with replacement values. Structure is documented below.</summary>
    [JsonPropertyName("buckets")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>Common characters to not transform when masking. Useful to avoid removing punctuation. Possible values are: NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE.</summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig
{
    /// <summary></summary>
    [JsonPropertyName("charactersToIgnore")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

    /// <summary>is *</summary>
    [JsonPropertyName("maskingCharacter")]
    public string? MaskingCharacter { get; set; }

    /// <summary>4</summary>
    [JsonPropertyName("numberToMask")]
    public double? NumberToMask { get; set; }

    /// <summary>is false</summary>
    [JsonPropertyName("reverseOrder")]
    public bool? ReverseOrder { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrappedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrappedKeySecretRef KeySecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE Structure is documented below.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType>? SurrogateInfoType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrappedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrappedKeySecretRef KeySecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey>? CryptoKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrappedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrappedKeySecretRef KeySecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>Common alphabets. Possible values are: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC.</summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is: 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&amp;*()_-+={[}]|:;"'&lt;,&gt;.?/</summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public double? Radix { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE Structure is documented below.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType>? SurrogateInfoType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrappedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrappedKeySecretRef KeySecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>Range of shift in days. Negative means shift to earlier in time.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public double? LowerBoundDays { get; set; }

    /// <summary>Range of shift in days. Actual shift will be selected at random within this range (inclusive ends). Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction.</summary>
    [JsonPropertyName("upperBoundDays")]
    public double? UpperBoundDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>Size of each bucket (except for minimum and maximum buckets). So if lower_bound = 10, upper_bound = 89, and bucketSize = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+. Precision up to 2 decimals works.</summary>
    [JsonPropertyName("bucketSize")]
    public double? BucketSize { get; set; }

    /// <summary>Lower bound value of buckets. All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value "-10". The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("lowerBound")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound>? LowerBound { get; set; }

    /// <summary>Upper bound value of buckets. All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value "89+". The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("upperBound")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound>? UpperBound { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>Replace each input value with a given value. The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set. Structure is documented below.</summary>
    [JsonPropertyName("newValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue>? NewValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig
{
    /// <summary>A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList>? WordList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceWithInfoTypeConfig
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>The part of the time to keep. Possible values are: YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY.</summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformation
{
    /// <summary>Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH This can be used on data of type: number, long, string, timestamp. If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing. See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more. Structure is documented below.</summary>
    [JsonPropertyName("bucketingConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig>? BucketingConfig { get; set; }

    /// <summary>Partially mask a string by replacing a given number of characters with a fixed character. Masking can start from the beginning or end of the string. Structure is documented below.</summary>
    [JsonPropertyName("characterMaskConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig>? CharacterMaskConfig { get; set; }

    /// <summary>Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297. Structure is documented below.</summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig>? CryptoDeterministicConfig { get; set; }

    /// <summary>Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes. Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=). Currently, only string and integer values can be hashed. See https://cloud.google.com/dlp/docs/pseudonymization to learn more. Structure is documented below.</summary>
    [JsonPropertyName("cryptoHashConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig>? CryptoHashConfig { get; set; }

    /// <summary>Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more. Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity. Structure is documented below.</summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig>? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>Shifts dates by random number of days, with option to be consistent for the same context. Structure is documented below.</summary>
    [JsonPropertyName("dateShiftConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig>? DateShiftConfig { get; set; }

    /// <summary>Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies. The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with "10-20". This can be used on data of type: double, long. If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing. See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more. Structure is documented below.</summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig>? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input 'My phone number is 206-555-0123', the output would be 'My phone number is '.</summary>
    [JsonPropertyName("redactConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig>? RedactConfig { get; set; }

    /// <summary>Replace each input value with a given value. Structure is documented below.</summary>
    [JsonPropertyName("replaceConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig>? ReplaceConfig { get; set; }

    /// <summary>Replace with a value randomly drawn (with replacement) from a dictionary. Structure is documented below.</summary>
    [JsonPropertyName("replaceDictionaryConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig>? ReplaceDictionaryConfig { get; set; }

    /// <summary>Replace each matching finding with the name of the info type.</summary>
    [JsonPropertyName("replaceWithInfoTypeConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceWithInfoTypeConfig>? ReplaceWithInfoTypeConfig { get; set; }

    /// <summary>For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value. Structure is documented below.</summary>
    [JsonPropertyName("timePartConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig>? TimePartConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformations
{
    /// <summary>InfoTypes to apply the transformation to. Leaving this empty will apply the transformation to apply to all findings that correspond to infoTypes that were requested in InspectConfig. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypes>? InfoTypes { get; set; }

    /// <summary>Primitive transformation to apply to the infoType. The primitive_transformation block must only contain one argument, corresponding to the type of transformation. Structure is documented below.</summary>
    [JsonPropertyName("primitiveTransformation")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformation>? PrimitiveTransformation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformations
{
    /// <summary>Transformation for each infoType. Cannot specify more than one for a given infoType. Structure is documented below.</summary>
    [JsonPropertyName("transformations")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformations>? Transformations { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>Upper bound of the range, exclusive; type must match min. The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("max")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMax>? Max { get; set; }

    /// <summary>Lower bound of the range, inclusive. Type should be the same as max if used. The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("min")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMin>? Min { get; set; }

    /// <summary>Replacement value for this bucket. The replacement_value block must only contain one argument. Structure is documented below.</summary>
    [JsonPropertyName("replacementValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue>? ReplacementValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>Set of buckets. Ranges must be non-overlapping. Bucket is represented as a range, along with replacement values. Structure is documented below.</summary>
    [JsonPropertyName("buckets")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>Common characters to not transform when masking. Useful to avoid removing punctuation. Possible values are: NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE.</summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfig
{
    /// <summary></summary>
    [JsonPropertyName("charactersToIgnore")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

    /// <summary>is *</summary>
    [JsonPropertyName("maskingCharacter")]
    public string? MaskingCharacter { get; set; }

    /// <summary>4</summary>
    [JsonPropertyName("numberToMask")]
    public double? NumberToMask { get; set; }

    /// <summary>is false</summary>
    [JsonPropertyName("reverseOrder")]
    public bool? ReverseOrder { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE Structure is documented below.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType>? SurrogateInfoType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey>? CryptoKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>Common alphabets. Possible values are: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC.</summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is: 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&amp;*()_-+={[}]|:;"'&lt;,&gt;.?/</summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public double? Radix { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE Structure is documented below.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType>? SurrogateInfoType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>Range of shift in days. Negative means shift to earlier in time.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public double? LowerBoundDays { get; set; }

    /// <summary>Range of shift in days. Actual shift will be selected at random within this range (inclusive ends). Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction.</summary>
    [JsonPropertyName("upperBoundDays")]
    public double? UpperBoundDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>Size of each bucket (except for minimum and maximum buckets). So if lower_bound = 10, upper_bound = 89, and bucketSize = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+. Precision up to 2 decimals works.</summary>
    [JsonPropertyName("bucketSize")]
    public double? BucketSize { get; set; }

    /// <summary>Lower bound value of buckets. All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value "-10". The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("lowerBound")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound>? LowerBound { get; set; }

    /// <summary>Upper bound value of buckets. All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value "89+". The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("upperBound")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound>? UpperBound { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationRedactConfig
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>Replace each input value with a given value. The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set. Structure is documented below.</summary>
    [JsonPropertyName("newValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValue>? NewValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfig
{
    /// <summary>A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList>? WordList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>The part of the time to keep. Possible values are: YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY.</summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformation
{
    /// <summary>Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH This can be used on data of type: number, long, string, timestamp. If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing. See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more. Structure is documented below.</summary>
    [JsonPropertyName("bucketingConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfig>? BucketingConfig { get; set; }

    /// <summary>Partially mask a string by replacing a given number of characters with a fixed character. Masking can start from the beginning or end of the string. Structure is documented below.</summary>
    [JsonPropertyName("characterMaskConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfig>? CharacterMaskConfig { get; set; }

    /// <summary>Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297. Structure is documented below.</summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfig>? CryptoDeterministicConfig { get; set; }

    /// <summary>Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes. Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=). Currently, only string and integer values can be hashed. See https://cloud.google.com/dlp/docs/pseudonymization to learn more. Structure is documented below.</summary>
    [JsonPropertyName("cryptoHashConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfig>? CryptoHashConfig { get; set; }

    /// <summary>Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more. Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity. Structure is documented below.</summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig>? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>Shifts dates by random number of days, with option to be consistent for the same context. Structure is documented below.</summary>
    [JsonPropertyName("dateShiftConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfig>? DateShiftConfig { get; set; }

    /// <summary>Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies. The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with "10-20". This can be used on data of type: double, long. If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing. See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more. Structure is documented below.</summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfig>? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input 'My phone number is 206-555-0123', the output would be 'My phone number is '.</summary>
    [JsonPropertyName("redactConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationRedactConfig>? RedactConfig { get; set; }

    /// <summary>Replace each input value with a given value. Structure is documented below.</summary>
    [JsonPropertyName("replaceConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfig>? ReplaceConfig { get; set; }

    /// <summary>Replace with a value randomly drawn (with replacement) from a dictionary. Structure is documented below.</summary>
    [JsonPropertyName("replaceDictionaryConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfig>? ReplaceDictionaryConfig { get; set; }

    /// <summary>For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value. Structure is documented below.</summary>
    [JsonPropertyName("timePartConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationTimePartConfig>? TimePartConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformations
{
    /// <summary>A condition that when it evaluates to true will result in the record being evaluated to be suppressed from the transformed content. Structure is documented below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsCondition>? Condition { get; set; }

    /// <summary>Input field(s) to apply the transformation to. When you have columns that reference their position within a list, omit the index from the FieldId. FieldId name matching ignores the index. For example, instead of "contact.nums[0].type", use "contact.nums.type". Structure is documented below.</summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsFields>? Fields { get; set; }

    /// <summary>Treat the contents of the field as free text, and selectively transform content that matches an InfoType. Only one of primitive_transformation or info_type_transformations must be specified. Structure is documented below.</summary>
    [JsonPropertyName("infoTypeTransformations")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformations>? InfoTypeTransformations { get; set; }

    /// <summary>Primitive transformation to apply to the infoType. The primitive_transformation block must only contain one argument, corresponding to the type of transformation. Structure is documented below.</summary>
    [JsonPropertyName("primitiveTransformation")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformation>? PrimitiveTransformation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsField
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditions
{
    /// <summary>Field within the record this condition is evaluated against. Structure is documented below.</summary>
    [JsonPropertyName("field")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsField>? Field { get; set; }

    /// <summary>Operator used to compare the field or infoType to the value. Possible values are: EQUAL_TO, NOT_EQUAL_TO, GREATER_THAN, LESS_THAN, GREATER_THAN_OR_EQUALS, LESS_THAN_OR_EQUALS, EXISTS.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Value to compare against. The value block must only contain one argument. For example when a condition is evaluated against a string-type field, only string_value should be set. This argument is mandatory, except for conditions using the EXISTS operator. Structure is documented below.</summary>
    [JsonPropertyName("value")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValue>? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditions
{
    /// <summary>Conditions to apply to the expression. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditions>? Conditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressions
{
    /// <summary>Conditions to apply to the expression. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditions>? Conditions { get; set; }

    /// <summary>The operator to apply to the result of conditions. Default and currently only supported value is AND. Default value is AND. Possible values are: AND.</summary>
    [JsonPropertyName("logicalOperator")]
    public string? LogicalOperator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsCondition
{
    /// <summary>An expression, consisting of an operator and conditions. Structure is documented below.</summary>
    [JsonPropertyName("expressions")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressions>? Expressions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressions
{
    /// <summary>A condition that when it evaluates to true will result in the record being evaluated to be suppressed from the transformed content. Structure is documented below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsCondition>? Condition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformations
{
    /// <summary>Transform the record by applying various field transformations. Structure is documented below.</summary>
    [JsonPropertyName("fieldTransformations")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformations>? FieldTransformations { get; set; }

    /// <summary>Configuration defining which records get suppressed entirely. Records that match any suppression rule are omitted from the output. Structure is documented below.</summary>
    [JsonPropertyName("recordSuppressions")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressions>? RecordSuppressions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfig
{
    /// <summary>Treat the dataset as an image and redact. Structure is documented below.</summary>
    [JsonPropertyName("imageTransformations")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformations>? ImageTransformations { get; set; }

    /// <summary>Treat the dataset as free-form text and apply the same free text transformation everywhere Structure is documented below.</summary>
    [JsonPropertyName("infoTypeTransformations")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformations>? InfoTypeTransformations { get; set; }

    /// <summary>Treat the dataset as structured. Transformations can be applied to specific locations within structured datasets, such as transforming a column within a table. Structure is documented below.</summary>
    [JsonPropertyName("recordTransformations")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformations>? RecordTransformations { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecForProvider
{
    /// <summary>Configuration of the deidentify template Structure is documented below.</summary>
    [JsonPropertyName("deidentifyConfig")]
    public IList<V1beta1DeidentifyTemplateSpecForProviderDeidentifyConfig>? DeidentifyConfig { get; set; }

    /// <summary>A description of the template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User set display name of the template.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The parent of the template in any of the following formats:</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>The template id can contain uppercase and lowercase letters, numbers, and hyphens; that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is 100 characters. Can be empty to allow the system to generate one.</summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsAllInfoTypes
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsAllText
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsRedactionColor
{
    /// <summary>The amount of blue in the color as a value in the interval [0, 1].</summary>
    [JsonPropertyName("blue")]
    public double? Blue { get; set; }

    /// <summary>The amount of green in the color as a value in the interval [0, 1].</summary>
    [JsonPropertyName("green")]
    public double? Green { get; set; }

    /// <summary>The amount of red in the color as a value in the interval [0, 1].</summary>
    [JsonPropertyName("red")]
    public double? Red { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypes
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypes
{
    /// <summary>InfoTypes to apply the transformation to. Leaving this empty will apply the transformation to apply to all findings that correspond to infoTypes that were requested in InspectConfig. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypes>? InfoTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransforms
{
    /// <summary>Apply transformation to all findings not specified in other ImageTransformation's selectedInfoTypes.</summary>
    [JsonPropertyName("allInfoTypes")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsAllInfoTypes>? AllInfoTypes { get; set; }

    /// <summary>Apply transformation to all text that doesn't match an infoType.</summary>
    [JsonPropertyName("allText")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsAllText>? AllText { get; set; }

    /// <summary>The color to use when redacting content from an image. If not specified, the default is black. Structure is documented below.</summary>
    [JsonPropertyName("redactionColor")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsRedactionColor>? RedactionColor { get; set; }

    /// <summary>Apply transformation to the selected infoTypes. Structure is documented below.</summary>
    [JsonPropertyName("selectedInfoTypes")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypes>? SelectedInfoTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformations
{
    /// <summary>For determination of how redaction of images should occur. Structure is documented below.</summary>
    [JsonPropertyName("transforms")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransforms>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypes
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>Upper bound of the range, exclusive; type must match min. The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("max")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax>? Max { get; set; }

    /// <summary>Lower bound of the range, inclusive. Type should be the same as max if used. The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("min")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin>? Min { get; set; }

    /// <summary>Replacement value for this bucket. The replacement_value block must only contain one argument. Structure is documented below.</summary>
    [JsonPropertyName("replacementValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue>? ReplacementValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>Set of buckets. Ranges must be non-overlapping. Bucket is represented as a range, along with replacement values. Structure is documented below.</summary>
    [JsonPropertyName("buckets")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>Common characters to not transform when masking. Useful to avoid removing punctuation. Possible values are: NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE.</summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig
{
    /// <summary></summary>
    [JsonPropertyName("charactersToIgnore")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

    /// <summary>is *</summary>
    [JsonPropertyName("maskingCharacter")]
    public string? MaskingCharacter { get; set; }

    /// <summary>4</summary>
    [JsonPropertyName("numberToMask")]
    public double? NumberToMask { get; set; }

    /// <summary>is false</summary>
    [JsonPropertyName("reverseOrder")]
    public bool? ReverseOrder { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE Structure is documented below.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType>? SurrogateInfoType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey>? CryptoKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>Common alphabets. Possible values are: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC.</summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is: 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&amp;*()_-+={[}]|:;"'&lt;,&gt;.?/</summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public double? Radix { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE Structure is documented below.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType>? SurrogateInfoType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>Range of shift in days. Negative means shift to earlier in time.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public double? LowerBoundDays { get; set; }

    /// <summary>Range of shift in days. Actual shift will be selected at random within this range (inclusive ends). Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction.</summary>
    [JsonPropertyName("upperBoundDays")]
    public double? UpperBoundDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>Size of each bucket (except for minimum and maximum buckets). So if lower_bound = 10, upper_bound = 89, and bucketSize = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+. Precision up to 2 decimals works.</summary>
    [JsonPropertyName("bucketSize")]
    public double? BucketSize { get; set; }

    /// <summary>Lower bound value of buckets. All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value "-10". The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("lowerBound")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound>? LowerBound { get; set; }

    /// <summary>Upper bound value of buckets. All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value "89+". The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("upperBound")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound>? UpperBound { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public double? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>Replace each input value with a given value. The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set. Structure is documented below.</summary>
    [JsonPropertyName("newValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue>? NewValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig
{
    /// <summary>A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList>? WordList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>The part of the time to keep. Possible values are: YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY.</summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformation
{
    /// <summary>Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH This can be used on data of type: number, long, string, timestamp. If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing. See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more. Structure is documented below.</summary>
    [JsonPropertyName("bucketingConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig>? BucketingConfig { get; set; }

    /// <summary>Partially mask a string by replacing a given number of characters with a fixed character. Masking can start from the beginning or end of the string. Structure is documented below.</summary>
    [JsonPropertyName("characterMaskConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig>? CharacterMaskConfig { get; set; }

    /// <summary>Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297. Structure is documented below.</summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig>? CryptoDeterministicConfig { get; set; }

    /// <summary>Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes. Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=). Currently, only string and integer values can be hashed. See https://cloud.google.com/dlp/docs/pseudonymization to learn more. Structure is documented below.</summary>
    [JsonPropertyName("cryptoHashConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig>? CryptoHashConfig { get; set; }

    /// <summary>Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more. Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity. Structure is documented below.</summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig>? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>Shifts dates by random number of days, with option to be consistent for the same context. Structure is documented below.</summary>
    [JsonPropertyName("dateShiftConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig>? DateShiftConfig { get; set; }

    /// <summary>Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies. The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with "10-20". This can be used on data of type: double, long. If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing. See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more. Structure is documented below.</summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig>? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input 'My phone number is 206-555-0123', the output would be 'My phone number is '.</summary>
    [JsonPropertyName("redactConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig>? RedactConfig { get; set; }

    /// <summary>Replace each input value with a given value. Structure is documented below.</summary>
    [JsonPropertyName("replaceConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig>? ReplaceConfig { get; set; }

    /// <summary>Replace with a value randomly drawn (with replacement) from a dictionary. Structure is documented below.</summary>
    [JsonPropertyName("replaceDictionaryConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig>? ReplaceDictionaryConfig { get; set; }

    /// <summary>Replace each matching finding with the name of the info type.</summary>
    [JsonPropertyName("replaceWithInfoTypeConfig")]
    public bool? ReplaceWithInfoTypeConfig { get; set; }

    /// <summary>For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value. Structure is documented below.</summary>
    [JsonPropertyName("timePartConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig>? TimePartConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformations
{
    /// <summary>InfoTypes to apply the transformation to. Leaving this empty will apply the transformation to apply to all findings that correspond to infoTypes that were requested in InspectConfig. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypes>? InfoTypes { get; set; }

    /// <summary>Primitive transformation to apply to the infoType. The primitive_transformation block must only contain one argument, corresponding to the type of transformation. Structure is documented below.</summary>
    [JsonPropertyName("primitiveTransformation")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformation>? PrimitiveTransformation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformations
{
    /// <summary>Transformation for each infoType. Cannot specify more than one for a given infoType. Structure is documented below.</summary>
    [JsonPropertyName("transformations")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformations>? Transformations { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsField
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditions
{
    /// <summary>Field within the record this condition is evaluated against. Structure is documented below.</summary>
    [JsonPropertyName("field")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsField>? Field { get; set; }

    /// <summary>Operator used to compare the field or infoType to the value. Possible values are: EQUAL_TO, NOT_EQUAL_TO, GREATER_THAN, LESS_THAN, GREATER_THAN_OR_EQUALS, LESS_THAN_OR_EQUALS, EXISTS.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Value to compare against. The value block must only contain one argument. For example when a condition is evaluated against a string-type field, only string_value should be set. This argument is mandatory, except for conditions using the EXISTS operator. Structure is documented below.</summary>
    [JsonPropertyName("value")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValue>? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditions
{
    /// <summary>Conditions to apply to the expression. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditions>? Conditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressions
{
    /// <summary>Conditions to apply to the expression. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditions>? Conditions { get; set; }

    /// <summary>The operator to apply to the result of conditions. Default and currently only supported value is AND. Default value is AND. Possible values are: AND.</summary>
    [JsonPropertyName("logicalOperator")]
    public string? LogicalOperator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsCondition
{
    /// <summary>An expression, consisting of an operator and conditions. Structure is documented below.</summary>
    [JsonPropertyName("expressions")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressions>? Expressions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsFields
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypes
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>Upper bound of the range, exclusive; type must match min. The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("max")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax>? Max { get; set; }

    /// <summary>Lower bound of the range, inclusive. Type should be the same as max if used. The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("min")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin>? Min { get; set; }

    /// <summary>Replacement value for this bucket. The replacement_value block must only contain one argument. Structure is documented below.</summary>
    [JsonPropertyName("replacementValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue>? ReplacementValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>Set of buckets. Ranges must be non-overlapping. Bucket is represented as a range, along with replacement values. Structure is documented below.</summary>
    [JsonPropertyName("buckets")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>Common characters to not transform when masking. Useful to avoid removing punctuation. Possible values are: NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE.</summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig
{
    /// <summary></summary>
    [JsonPropertyName("charactersToIgnore")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

    /// <summary>is *</summary>
    [JsonPropertyName("maskingCharacter")]
    public string? MaskingCharacter { get; set; }

    /// <summary>4</summary>
    [JsonPropertyName("numberToMask")]
    public double? NumberToMask { get; set; }

    /// <summary>is false</summary>
    [JsonPropertyName("reverseOrder")]
    public bool? ReverseOrder { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE Structure is documented below.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType>? SurrogateInfoType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey>? CryptoKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>Common alphabets. Possible values are: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC.</summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is: 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&amp;*()_-+={[}]|:;"'&lt;,&gt;.?/</summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public double? Radix { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE Structure is documented below.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType>? SurrogateInfoType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>Range of shift in days. Negative means shift to earlier in time.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public double? LowerBoundDays { get; set; }

    /// <summary>Range of shift in days. Actual shift will be selected at random within this range (inclusive ends). Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction.</summary>
    [JsonPropertyName("upperBoundDays")]
    public double? UpperBoundDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>Size of each bucket (except for minimum and maximum buckets). So if lower_bound = 10, upper_bound = 89, and bucketSize = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+. Precision up to 2 decimals works.</summary>
    [JsonPropertyName("bucketSize")]
    public double? BucketSize { get; set; }

    /// <summary>Lower bound value of buckets. All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value "-10". The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("lowerBound")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound>? LowerBound { get; set; }

    /// <summary>Upper bound value of buckets. All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value "89+". The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("upperBound")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound>? UpperBound { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>Replace each input value with a given value. The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set. Structure is documented below.</summary>
    [JsonPropertyName("newValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue>? NewValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig
{
    /// <summary>A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList>? WordList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceWithInfoTypeConfig
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>The part of the time to keep. Possible values are: YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY.</summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformation
{
    /// <summary>Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH This can be used on data of type: number, long, string, timestamp. If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing. See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more. Structure is documented below.</summary>
    [JsonPropertyName("bucketingConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig>? BucketingConfig { get; set; }

    /// <summary>Partially mask a string by replacing a given number of characters with a fixed character. Masking can start from the beginning or end of the string. Structure is documented below.</summary>
    [JsonPropertyName("characterMaskConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig>? CharacterMaskConfig { get; set; }

    /// <summary>Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297. Structure is documented below.</summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig>? CryptoDeterministicConfig { get; set; }

    /// <summary>Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes. Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=). Currently, only string and integer values can be hashed. See https://cloud.google.com/dlp/docs/pseudonymization to learn more. Structure is documented below.</summary>
    [JsonPropertyName("cryptoHashConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig>? CryptoHashConfig { get; set; }

    /// <summary>Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more. Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity. Structure is documented below.</summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig>? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>Shifts dates by random number of days, with option to be consistent for the same context. Structure is documented below.</summary>
    [JsonPropertyName("dateShiftConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig>? DateShiftConfig { get; set; }

    /// <summary>Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies. The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with "10-20". This can be used on data of type: double, long. If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing. See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more. Structure is documented below.</summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig>? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input 'My phone number is 206-555-0123', the output would be 'My phone number is '.</summary>
    [JsonPropertyName("redactConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig>? RedactConfig { get; set; }

    /// <summary>Replace each input value with a given value. Structure is documented below.</summary>
    [JsonPropertyName("replaceConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig>? ReplaceConfig { get; set; }

    /// <summary>Replace with a value randomly drawn (with replacement) from a dictionary. Structure is documented below.</summary>
    [JsonPropertyName("replaceDictionaryConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig>? ReplaceDictionaryConfig { get; set; }

    /// <summary>Replace each matching finding with the name of the info type.</summary>
    [JsonPropertyName("replaceWithInfoTypeConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceWithInfoTypeConfig>? ReplaceWithInfoTypeConfig { get; set; }

    /// <summary>For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value. Structure is documented below.</summary>
    [JsonPropertyName("timePartConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig>? TimePartConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformations
{
    /// <summary>InfoTypes to apply the transformation to. Leaving this empty will apply the transformation to apply to all findings that correspond to infoTypes that were requested in InspectConfig. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypes>? InfoTypes { get; set; }

    /// <summary>Primitive transformation to apply to the infoType. The primitive_transformation block must only contain one argument, corresponding to the type of transformation. Structure is documented below.</summary>
    [JsonPropertyName("primitiveTransformation")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformation>? PrimitiveTransformation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformations
{
    /// <summary>Transformation for each infoType. Cannot specify more than one for a given infoType. Structure is documented below.</summary>
    [JsonPropertyName("transformations")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformations>? Transformations { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>Upper bound of the range, exclusive; type must match min. The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("max")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMax>? Max { get; set; }

    /// <summary>Lower bound of the range, inclusive. Type should be the same as max if used. The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("min")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMin>? Min { get; set; }

    /// <summary>Replacement value for this bucket. The replacement_value block must only contain one argument. Structure is documented below.</summary>
    [JsonPropertyName("replacementValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue>? ReplacementValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>Set of buckets. Ranges must be non-overlapping. Bucket is represented as a range, along with replacement values. Structure is documented below.</summary>
    [JsonPropertyName("buckets")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>Common characters to not transform when masking. Useful to avoid removing punctuation. Possible values are: NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE.</summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfig
{
    /// <summary></summary>
    [JsonPropertyName("charactersToIgnore")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

    /// <summary>is *</summary>
    [JsonPropertyName("maskingCharacter")]
    public string? MaskingCharacter { get; set; }

    /// <summary>4</summary>
    [JsonPropertyName("numberToMask")]
    public double? NumberToMask { get; set; }

    /// <summary>is false</summary>
    [JsonPropertyName("reverseOrder")]
    public bool? ReverseOrder { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE Structure is documented below.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType>? SurrogateInfoType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey>? CryptoKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>Common alphabets. Possible values are: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC.</summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is: 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&amp;*()_-+={[}]|:;"'&lt;,&gt;.?/</summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public double? Radix { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE Structure is documented below.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType>? SurrogateInfoType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>Range of shift in days. Negative means shift to earlier in time.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public double? LowerBoundDays { get; set; }

    /// <summary>Range of shift in days. Actual shift will be selected at random within this range (inclusive ends). Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction.</summary>
    [JsonPropertyName("upperBoundDays")]
    public double? UpperBoundDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>Size of each bucket (except for minimum and maximum buckets). So if lower_bound = 10, upper_bound = 89, and bucketSize = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+. Precision up to 2 decimals works.</summary>
    [JsonPropertyName("bucketSize")]
    public double? BucketSize { get; set; }

    /// <summary>Lower bound value of buckets. All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value "-10". The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("lowerBound")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound>? LowerBound { get; set; }

    /// <summary>Upper bound value of buckets. All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value "89+". The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("upperBound")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound>? UpperBound { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationRedactConfig
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>Replace each input value with a given value. The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set. Structure is documented below.</summary>
    [JsonPropertyName("newValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValue>? NewValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfig
{
    /// <summary>A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList>? WordList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>The part of the time to keep. Possible values are: YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY.</summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformation
{
    /// <summary>Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH This can be used on data of type: number, long, string, timestamp. If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing. See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more. Structure is documented below.</summary>
    [JsonPropertyName("bucketingConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfig>? BucketingConfig { get; set; }

    /// <summary>Partially mask a string by replacing a given number of characters with a fixed character. Masking can start from the beginning or end of the string. Structure is documented below.</summary>
    [JsonPropertyName("characterMaskConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfig>? CharacterMaskConfig { get; set; }

    /// <summary>Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297. Structure is documented below.</summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfig>? CryptoDeterministicConfig { get; set; }

    /// <summary>Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes. Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=). Currently, only string and integer values can be hashed. See https://cloud.google.com/dlp/docs/pseudonymization to learn more. Structure is documented below.</summary>
    [JsonPropertyName("cryptoHashConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfig>? CryptoHashConfig { get; set; }

    /// <summary>Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more. Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity. Structure is documented below.</summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig>? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>Shifts dates by random number of days, with option to be consistent for the same context. Structure is documented below.</summary>
    [JsonPropertyName("dateShiftConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfig>? DateShiftConfig { get; set; }

    /// <summary>Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies. The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with "10-20". This can be used on data of type: double, long. If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing. See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more. Structure is documented below.</summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfig>? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input 'My phone number is 206-555-0123', the output would be 'My phone number is '.</summary>
    [JsonPropertyName("redactConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationRedactConfig>? RedactConfig { get; set; }

    /// <summary>Replace each input value with a given value. Structure is documented below.</summary>
    [JsonPropertyName("replaceConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfig>? ReplaceConfig { get; set; }

    /// <summary>Replace with a value randomly drawn (with replacement) from a dictionary. Structure is documented below.</summary>
    [JsonPropertyName("replaceDictionaryConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfig>? ReplaceDictionaryConfig { get; set; }

    /// <summary>For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value. Structure is documented below.</summary>
    [JsonPropertyName("timePartConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationTimePartConfig>? TimePartConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformations
{
    /// <summary>A condition that when it evaluates to true will result in the record being evaluated to be suppressed from the transformed content. Structure is documented below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsCondition>? Condition { get; set; }

    /// <summary>Input field(s) to apply the transformation to. When you have columns that reference their position within a list, omit the index from the FieldId. FieldId name matching ignores the index. For example, instead of "contact.nums[0].type", use "contact.nums.type". Structure is documented below.</summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsFields>? Fields { get; set; }

    /// <summary>Treat the contents of the field as free text, and selectively transform content that matches an InfoType. Only one of primitive_transformation or info_type_transformations must be specified. Structure is documented below.</summary>
    [JsonPropertyName("infoTypeTransformations")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformations>? InfoTypeTransformations { get; set; }

    /// <summary>Primitive transformation to apply to the infoType. The primitive_transformation block must only contain one argument, corresponding to the type of transformation. Structure is documented below.</summary>
    [JsonPropertyName("primitiveTransformation")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformation>? PrimitiveTransformation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsField
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditions
{
    /// <summary>Field within the record this condition is evaluated against. Structure is documented below.</summary>
    [JsonPropertyName("field")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsField>? Field { get; set; }

    /// <summary>Operator used to compare the field or infoType to the value. Possible values are: EQUAL_TO, NOT_EQUAL_TO, GREATER_THAN, LESS_THAN, GREATER_THAN_OR_EQUALS, LESS_THAN_OR_EQUALS, EXISTS.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Value to compare against. The value block must only contain one argument. For example when a condition is evaluated against a string-type field, only string_value should be set. This argument is mandatory, except for conditions using the EXISTS operator. Structure is documented below.</summary>
    [JsonPropertyName("value")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValue>? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditions
{
    /// <summary>Conditions to apply to the expression. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditions>? Conditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressions
{
    /// <summary>Conditions to apply to the expression. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditions>? Conditions { get; set; }

    /// <summary>The operator to apply to the result of conditions. Default and currently only supported value is AND. Default value is AND. Possible values are: AND.</summary>
    [JsonPropertyName("logicalOperator")]
    public string? LogicalOperator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsCondition
{
    /// <summary>An expression, consisting of an operator and conditions. Structure is documented below.</summary>
    [JsonPropertyName("expressions")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressions>? Expressions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressions
{
    /// <summary>A condition that when it evaluates to true will result in the record being evaluated to be suppressed from the transformed content. Structure is documented below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsCondition>? Condition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformations
{
    /// <summary>Transform the record by applying various field transformations. Structure is documented below.</summary>
    [JsonPropertyName("fieldTransformations")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformations>? FieldTransformations { get; set; }

    /// <summary>Configuration defining which records get suppressed entirely. Records that match any suppression rule are omitted from the output. Structure is documented below.</summary>
    [JsonPropertyName("recordSuppressions")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressions>? RecordSuppressions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfig
{
    /// <summary>Treat the dataset as an image and redact. Structure is documented below.</summary>
    [JsonPropertyName("imageTransformations")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformations>? ImageTransformations { get; set; }

    /// <summary>Treat the dataset as free-form text and apply the same free text transformation everywhere Structure is documented below.</summary>
    [JsonPropertyName("infoTypeTransformations")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformations>? InfoTypeTransformations { get; set; }

    /// <summary>Treat the dataset as structured. Transformations can be applied to specific locations within structured datasets, such as transforming a column within a table. Structure is documented below.</summary>
    [JsonPropertyName("recordTransformations")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformations>? RecordTransformations { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecInitProvider
{
    /// <summary>Configuration of the deidentify template Structure is documented below.</summary>
    [JsonPropertyName("deidentifyConfig")]
    public IList<V1beta1DeidentifyTemplateSpecInitProviderDeidentifyConfig>? DeidentifyConfig { get; set; }

    /// <summary>A description of the template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User set display name of the template.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The parent of the template in any of the following formats:</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>The template id can contain uppercase and lowercase letters, numbers, and hyphens; that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is 100 characters. Can be empty to allow the system to generate one.</summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DeidentifyTemplateSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DeidentifyTemplateSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DeidentifyTemplateSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DeidentifyTemplateSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1DeidentifyTemplateSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DeidentifyTemplateSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1DeidentifyTemplateSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeidentifyTemplateSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DeidentifyTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DeidentifyTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DeidentifyTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1DeidentifyTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DeidentifyTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1DeidentifyTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeidentifyTemplateSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1DeidentifyTemplateSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1DeidentifyTemplateSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>DeidentifyTemplateSpec defines the desired state of DeidentifyTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DeidentifyTemplateSpecDeletionPolicyEnum>))]
    public V1beta1DeidentifyTemplateSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DeidentifyTemplateSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DeidentifyTemplateSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DeidentifyTemplateSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DeidentifyTemplateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1DeidentifyTemplateSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DeidentifyTemplateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsAllInfoTypes
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsAllText
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsRedactionColor
{
    /// <summary>The amount of blue in the color as a value in the interval [0, 1].</summary>
    [JsonPropertyName("blue")]
    public double? Blue { get; set; }

    /// <summary>The amount of green in the color as a value in the interval [0, 1].</summary>
    [JsonPropertyName("green")]
    public double? Green { get; set; }

    /// <summary>The amount of red in the color as a value in the interval [0, 1].</summary>
    [JsonPropertyName("red")]
    public double? Red { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypes
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypes
{
    /// <summary>InfoTypes to apply the transformation to. Leaving this empty will apply the transformation to apply to all findings that correspond to infoTypes that were requested in InspectConfig. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypes>? InfoTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransforms
{
    /// <summary>Apply transformation to all findings not specified in other ImageTransformation's selectedInfoTypes.</summary>
    [JsonPropertyName("allInfoTypes")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsAllInfoTypes>? AllInfoTypes { get; set; }

    /// <summary>Apply transformation to all text that doesn't match an infoType.</summary>
    [JsonPropertyName("allText")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsAllText>? AllText { get; set; }

    /// <summary>The color to use when redacting content from an image. If not specified, the default is black. Structure is documented below.</summary>
    [JsonPropertyName("redactionColor")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsRedactionColor>? RedactionColor { get; set; }

    /// <summary>Apply transformation to the selected infoTypes. Structure is documented below.</summary>
    [JsonPropertyName("selectedInfoTypes")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypes>? SelectedInfoTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformations
{
    /// <summary>For determination of how redaction of images should occur. Structure is documented below.</summary>
    [JsonPropertyName("transforms")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransforms>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypes
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>Upper bound of the range, exclusive; type must match min. The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("max")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax>? Max { get; set; }

    /// <summary>Lower bound of the range, inclusive. Type should be the same as max if used. The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("min")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin>? Min { get; set; }

    /// <summary>Replacement value for this bucket. The replacement_value block must only contain one argument. Structure is documented below.</summary>
    [JsonPropertyName("replacementValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue>? ReplacementValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>Set of buckets. Ranges must be non-overlapping. Bucket is represented as a range, along with replacement values. Structure is documented below.</summary>
    [JsonPropertyName("buckets")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>Common characters to not transform when masking. Useful to avoid removing punctuation. Possible values are: NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE.</summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig
{
    /// <summary></summary>
    [JsonPropertyName("charactersToIgnore")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

    /// <summary>is *</summary>
    [JsonPropertyName("maskingCharacter")]
    public string? MaskingCharacter { get; set; }

    /// <summary>4</summary>
    [JsonPropertyName("numberToMask")]
    public double? NumberToMask { get; set; }

    /// <summary>is false</summary>
    [JsonPropertyName("reverseOrder")]
    public bool? ReverseOrder { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE Structure is documented below.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType>? SurrogateInfoType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey>? CryptoKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>Common alphabets. Possible values are: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC.</summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is: 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&amp;*()_-+={[}]|:;"'&lt;,&gt;.?/</summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public double? Radix { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE Structure is documented below.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType>? SurrogateInfoType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>Range of shift in days. Negative means shift to earlier in time.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public double? LowerBoundDays { get; set; }

    /// <summary>Range of shift in days. Actual shift will be selected at random within this range (inclusive ends). Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction.</summary>
    [JsonPropertyName("upperBoundDays")]
    public double? UpperBoundDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>Size of each bucket (except for minimum and maximum buckets). So if lower_bound = 10, upper_bound = 89, and bucketSize = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+. Precision up to 2 decimals works.</summary>
    [JsonPropertyName("bucketSize")]
    public double? BucketSize { get; set; }

    /// <summary>Lower bound value of buckets. All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value "-10". The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("lowerBound")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound>? LowerBound { get; set; }

    /// <summary>Upper bound value of buckets. All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value "89+". The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("upperBound")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound>? UpperBound { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public double? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>Replace each input value with a given value. The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set. Structure is documented below.</summary>
    [JsonPropertyName("newValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue>? NewValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig
{
    /// <summary>A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList>? WordList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>The part of the time to keep. Possible values are: YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY.</summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformation
{
    /// <summary>Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH This can be used on data of type: number, long, string, timestamp. If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing. See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more. Structure is documented below.</summary>
    [JsonPropertyName("bucketingConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig>? BucketingConfig { get; set; }

    /// <summary>Partially mask a string by replacing a given number of characters with a fixed character. Masking can start from the beginning or end of the string. Structure is documented below.</summary>
    [JsonPropertyName("characterMaskConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig>? CharacterMaskConfig { get; set; }

    /// <summary>Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297. Structure is documented below.</summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig>? CryptoDeterministicConfig { get; set; }

    /// <summary>Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes. Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=). Currently, only string and integer values can be hashed. See https://cloud.google.com/dlp/docs/pseudonymization to learn more. Structure is documented below.</summary>
    [JsonPropertyName("cryptoHashConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig>? CryptoHashConfig { get; set; }

    /// <summary>Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more. Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity. Structure is documented below.</summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig>? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>Shifts dates by random number of days, with option to be consistent for the same context. Structure is documented below.</summary>
    [JsonPropertyName("dateShiftConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig>? DateShiftConfig { get; set; }

    /// <summary>Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies. The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with "10-20". This can be used on data of type: double, long. If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing. See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more. Structure is documented below.</summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig>? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input 'My phone number is 206-555-0123', the output would be 'My phone number is '.</summary>
    [JsonPropertyName("redactConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig>? RedactConfig { get; set; }

    /// <summary>Replace each input value with a given value. Structure is documented below.</summary>
    [JsonPropertyName("replaceConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig>? ReplaceConfig { get; set; }

    /// <summary>Replace with a value randomly drawn (with replacement) from a dictionary. Structure is documented below.</summary>
    [JsonPropertyName("replaceDictionaryConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig>? ReplaceDictionaryConfig { get; set; }

    /// <summary>Replace each matching finding with the name of the info type.</summary>
    [JsonPropertyName("replaceWithInfoTypeConfig")]
    public bool? ReplaceWithInfoTypeConfig { get; set; }

    /// <summary>For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value. Structure is documented below.</summary>
    [JsonPropertyName("timePartConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig>? TimePartConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformations
{
    /// <summary>InfoTypes to apply the transformation to. Leaving this empty will apply the transformation to apply to all findings that correspond to infoTypes that were requested in InspectConfig. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypes>? InfoTypes { get; set; }

    /// <summary>Primitive transformation to apply to the infoType. The primitive_transformation block must only contain one argument, corresponding to the type of transformation. Structure is documented below.</summary>
    [JsonPropertyName("primitiveTransformation")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformation>? PrimitiveTransformation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformations
{
    /// <summary>Transformation for each infoType. Cannot specify more than one for a given infoType. Structure is documented below.</summary>
    [JsonPropertyName("transformations")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformations>? Transformations { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsField
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditions
{
    /// <summary>Field within the record this condition is evaluated against. Structure is documented below.</summary>
    [JsonPropertyName("field")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsField>? Field { get; set; }

    /// <summary>Operator used to compare the field or infoType to the value. Possible values are: EQUAL_TO, NOT_EQUAL_TO, GREATER_THAN, LESS_THAN, GREATER_THAN_OR_EQUALS, LESS_THAN_OR_EQUALS, EXISTS.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Value to compare against. The value block must only contain one argument. For example when a condition is evaluated against a string-type field, only string_value should be set. This argument is mandatory, except for conditions using the EXISTS operator. Structure is documented below.</summary>
    [JsonPropertyName("value")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValue>? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditions
{
    /// <summary>Conditions to apply to the expression. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditions>? Conditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressions
{
    /// <summary>Conditions to apply to the expression. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditions>? Conditions { get; set; }

    /// <summary>The operator to apply to the result of conditions. Default and currently only supported value is AND. Default value is AND. Possible values are: AND.</summary>
    [JsonPropertyName("logicalOperator")]
    public string? LogicalOperator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsCondition
{
    /// <summary>An expression, consisting of an operator and conditions. Structure is documented below.</summary>
    [JsonPropertyName("expressions")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressions>? Expressions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsFields
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypesSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypes
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypesSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>Upper bound of the range, exclusive; type must match min. The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("max")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax>? Max { get; set; }

    /// <summary>Lower bound of the range, inclusive. Type should be the same as max if used. The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("min")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin>? Min { get; set; }

    /// <summary>Replacement value for this bucket. The replacement_value block must only contain one argument. Structure is documented below.</summary>
    [JsonPropertyName("replacementValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue>? ReplacementValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>Set of buckets. Ranges must be non-overlapping. Bucket is represented as a range, along with replacement values. Structure is documented below.</summary>
    [JsonPropertyName("buckets")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>Common characters to not transform when masking. Useful to avoid removing punctuation. Possible values are: NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE.</summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig
{
    /// <summary></summary>
    [JsonPropertyName("charactersToIgnore")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

    /// <summary>is *</summary>
    [JsonPropertyName("maskingCharacter")]
    public string? MaskingCharacter { get; set; }

    /// <summary>4</summary>
    [JsonPropertyName("numberToMask")]
    public double? NumberToMask { get; set; }

    /// <summary>is false</summary>
    [JsonPropertyName("reverseOrder")]
    public bool? ReverseOrder { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrappedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrappedKeySecretRef KeySecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE Structure is documented below.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType>? SurrogateInfoType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrappedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrappedKeySecretRef KeySecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey>? CryptoKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrappedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrappedKeySecretRef KeySecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>Common alphabets. Possible values are: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC.</summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is: 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&amp;*()_-+={[}]|:;"'&lt;,&gt;.?/</summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public double? Radix { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE Structure is documented below.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType>? SurrogateInfoType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrappedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrappedKeySecretRef KeySecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>Range of shift in days. Negative means shift to earlier in time.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public double? LowerBoundDays { get; set; }

    /// <summary>Range of shift in days. Actual shift will be selected at random within this range (inclusive ends). Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction.</summary>
    [JsonPropertyName("upperBoundDays")]
    public double? UpperBoundDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>Size of each bucket (except for minimum and maximum buckets). So if lower_bound = 10, upper_bound = 89, and bucketSize = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+. Precision up to 2 decimals works.</summary>
    [JsonPropertyName("bucketSize")]
    public double? BucketSize { get; set; }

    /// <summary>Lower bound value of buckets. All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value "-10". The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("lowerBound")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound>? LowerBound { get; set; }

    /// <summary>Upper bound value of buckets. All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value "89+". The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("upperBound")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound>? UpperBound { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>Replace each input value with a given value. The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set. Structure is documented below.</summary>
    [JsonPropertyName("newValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue>? NewValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig
{
    /// <summary>A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList>? WordList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceWithInfoTypeConfig
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>The part of the time to keep. Possible values are: YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY.</summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformation
{
    /// <summary>Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH This can be used on data of type: number, long, string, timestamp. If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing. See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more. Structure is documented below.</summary>
    [JsonPropertyName("bucketingConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig>? BucketingConfig { get; set; }

    /// <summary>Partially mask a string by replacing a given number of characters with a fixed character. Masking can start from the beginning or end of the string. Structure is documented below.</summary>
    [JsonPropertyName("characterMaskConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig>? CharacterMaskConfig { get; set; }

    /// <summary>Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297. Structure is documented below.</summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig>? CryptoDeterministicConfig { get; set; }

    /// <summary>Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes. Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=). Currently, only string and integer values can be hashed. See https://cloud.google.com/dlp/docs/pseudonymization to learn more. Structure is documented below.</summary>
    [JsonPropertyName("cryptoHashConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig>? CryptoHashConfig { get; set; }

    /// <summary>Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more. Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity. Structure is documented below.</summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig>? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>Shifts dates by random number of days, with option to be consistent for the same context. Structure is documented below.</summary>
    [JsonPropertyName("dateShiftConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig>? DateShiftConfig { get; set; }

    /// <summary>Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies. The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with "10-20". This can be used on data of type: double, long. If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing. See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more. Structure is documented below.</summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig>? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input 'My phone number is 206-555-0123', the output would be 'My phone number is '.</summary>
    [JsonPropertyName("redactConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig>? RedactConfig { get; set; }

    /// <summary>Replace each input value with a given value. Structure is documented below.</summary>
    [JsonPropertyName("replaceConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig>? ReplaceConfig { get; set; }

    /// <summary>Replace with a value randomly drawn (with replacement) from a dictionary. Structure is documented below.</summary>
    [JsonPropertyName("replaceDictionaryConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig>? ReplaceDictionaryConfig { get; set; }

    /// <summary>Replace each matching finding with the name of the info type.</summary>
    [JsonPropertyName("replaceWithInfoTypeConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceWithInfoTypeConfig>? ReplaceWithInfoTypeConfig { get; set; }

    /// <summary>For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value. Structure is documented below.</summary>
    [JsonPropertyName("timePartConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig>? TimePartConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformations
{
    /// <summary>InfoTypes to apply the transformation to. Leaving this empty will apply the transformation to apply to all findings that correspond to infoTypes that were requested in InspectConfig. Structure is documented below.</summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypes>? InfoTypes { get; set; }

    /// <summary>Primitive transformation to apply to the infoType. The primitive_transformation block must only contain one argument, corresponding to the type of transformation. Structure is documented below.</summary>
    [JsonPropertyName("primitiveTransformation")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformation>? PrimitiveTransformation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformations
{
    /// <summary>Transformation for each infoType. Cannot specify more than one for a given infoType. Structure is documented below.</summary>
    [JsonPropertyName("transformations")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformations>? Transformations { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>Upper bound of the range, exclusive; type must match min. The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("max")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMax>? Max { get; set; }

    /// <summary>Lower bound of the range, inclusive. Type should be the same as max if used. The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("min")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMin>? Min { get; set; }

    /// <summary>Replacement value for this bucket. The replacement_value block must only contain one argument. Structure is documented below.</summary>
    [JsonPropertyName("replacementValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue>? ReplacementValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>Set of buckets. Ranges must be non-overlapping. Bucket is represented as a range, along with replacement values. Structure is documented below.</summary>
    [JsonPropertyName("buckets")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>Common characters to not transform when masking. Useful to avoid removing punctuation. Possible values are: NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE.</summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfig
{
    /// <summary></summary>
    [JsonPropertyName("charactersToIgnore")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

    /// <summary>is *</summary>
    [JsonPropertyName("maskingCharacter")]
    public string? MaskingCharacter { get; set; }

    /// <summary>4</summary>
    [JsonPropertyName("numberToMask")]
    public double? NumberToMask { get; set; }

    /// <summary>is false</summary>
    [JsonPropertyName("reverseOrder")]
    public bool? ReverseOrder { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE Structure is documented below.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType>? SurrogateInfoType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey>? CryptoKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>The sensitivity score applied to the resource. Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.</summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional custom sensitivity for this InfoType. This only applies to data profiling. Structure is documented below.</summary>
    [JsonPropertyName("sensitivityScore")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore>? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>Common alphabets. Possible values are: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC.</summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is: 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&amp;*()_-+={[}]|:;"'&lt;,&gt;.?/</summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public double? Radix { get; set; }

    /// <summary>The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE Structure is documented below.</summary>
    [JsonPropertyName("surrogateInfoType")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType>? SurrogateInfoType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>The wrapped data crypto key. A base64-encoded string.</summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>A 128/192/256 bit key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>KMS wrapped key. Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see Creating a wrapped key. Note: When you use Cloud KMS for cryptographic operations, charges apply. Structure is documented below.</summary>
    [JsonPropertyName("kmsWrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped>? KmsWrapped { get; set; }

    /// <summary>Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes. Structure is documented below.</summary>
    [JsonPropertyName("transient")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient>? Transient { get; set; }

    /// <summary>Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible. Structure is documented below.</summary>
    [JsonPropertyName("unwrapped")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped>? Unwrapped { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey. If set, shift will be consistent for the given context. Structure is documented below.</summary>
    [JsonPropertyName("context")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigContext>? Context { get; set; }

    /// <summary>The key used by the encryption function. Structure is documented below.</summary>
    [JsonPropertyName("cryptoKey")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKey>? CryptoKey { get; set; }

    /// <summary>Range of shift in days. Negative means shift to earlier in time.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public double? LowerBoundDays { get; set; }

    /// <summary>Range of shift in days. Actual shift will be selected at random within this range (inclusive ends). Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction.</summary>
    [JsonPropertyName("upperBoundDays")]
    public double? UpperBoundDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>Size of each bucket (except for minimum and maximum buckets). So if lower_bound = 10, upper_bound = 89, and bucketSize = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+. Precision up to 2 decimals works.</summary>
    [JsonPropertyName("bucketSize")]
    public double? BucketSize { get; set; }

    /// <summary>Lower bound value of buckets. All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value "-10". The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("lowerBound")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound>? LowerBound { get; set; }

    /// <summary>Upper bound value of buckets. All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value "89+". The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type. Structure is documented below.</summary>
    [JsonPropertyName("upperBound")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound>? UpperBound { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationRedactConfig
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>Replace each input value with a given value. The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set. Structure is documented below.</summary>
    [JsonPropertyName("newValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValue>? NewValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfig
{
    /// <summary>A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList>? WordList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>The part of the time to keep. Possible values are: YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY.</summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformation
{
    /// <summary>Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH This can be used on data of type: number, long, string, timestamp. If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing. See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more. Structure is documented below.</summary>
    [JsonPropertyName("bucketingConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfig>? BucketingConfig { get; set; }

    /// <summary>Partially mask a string by replacing a given number of characters with a fixed character. Masking can start from the beginning or end of the string. Structure is documented below.</summary>
    [JsonPropertyName("characterMaskConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfig>? CharacterMaskConfig { get; set; }

    /// <summary>Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297. Structure is documented below.</summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfig>? CryptoDeterministicConfig { get; set; }

    /// <summary>Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes. Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=). Currently, only string and integer values can be hashed. See https://cloud.google.com/dlp/docs/pseudonymization to learn more. Structure is documented below.</summary>
    [JsonPropertyName("cryptoHashConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfig>? CryptoHashConfig { get; set; }

    /// <summary>Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more. Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity. Structure is documented below.</summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig>? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>Shifts dates by random number of days, with option to be consistent for the same context. Structure is documented below.</summary>
    [JsonPropertyName("dateShiftConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfig>? DateShiftConfig { get; set; }

    /// <summary>Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies. The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with "10-20". This can be used on data of type: double, long. If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing. See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more. Structure is documented below.</summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfig>? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input 'My phone number is 206-555-0123', the output would be 'My phone number is '.</summary>
    [JsonPropertyName("redactConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationRedactConfig>? RedactConfig { get; set; }

    /// <summary>Replace each input value with a given value. Structure is documented below.</summary>
    [JsonPropertyName("replaceConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfig>? ReplaceConfig { get; set; }

    /// <summary>Replace with a value randomly drawn (with replacement) from a dictionary. Structure is documented below.</summary>
    [JsonPropertyName("replaceDictionaryConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfig>? ReplaceDictionaryConfig { get; set; }

    /// <summary>For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value. Structure is documented below.</summary>
    [JsonPropertyName("timePartConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationTimePartConfig>? TimePartConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformations
{
    /// <summary>A condition that when it evaluates to true will result in the record being evaluated to be suppressed from the transformed content. Structure is documented below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsCondition>? Condition { get; set; }

    /// <summary>Input field(s) to apply the transformation to. When you have columns that reference their position within a list, omit the index from the FieldId. FieldId name matching ignores the index. For example, instead of "contact.nums[0].type", use "contact.nums.type". Structure is documented below.</summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsFields>? Fields { get; set; }

    /// <summary>Treat the contents of the field as free text, and selectively transform content that matches an InfoType. Only one of primitive_transformation or info_type_transformations must be specified. Structure is documented below.</summary>
    [JsonPropertyName("infoTypeTransformations")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformations>? InfoTypeTransformations { get; set; }

    /// <summary>Primitive transformation to apply to the infoType. The primitive_transformation block must only contain one argument, corresponding to the type of transformation. Structure is documented below.</summary>
    [JsonPropertyName("primitiveTransformation")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformation>? PrimitiveTransformation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsField
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueDateValue
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by itself or a year and month where the day is not significant.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Represents a whole or partial calendar date. Structure is documented below.</summary>
    [JsonPropertyName("dateValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueDateValue>? DateValue { get; set; }

    /// <summary>Represents a day of the week. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Represents a time of day. Structure is documented below.</summary>
    [JsonPropertyName("timeValue")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueTimeValue>? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditions
{
    /// <summary>Field within the record this condition is evaluated against. Structure is documented below.</summary>
    [JsonPropertyName("field")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsField>? Field { get; set; }

    /// <summary>Operator used to compare the field or infoType to the value. Possible values are: EQUAL_TO, NOT_EQUAL_TO, GREATER_THAN, LESS_THAN, GREATER_THAN_OR_EQUALS, LESS_THAN_OR_EQUALS, EXISTS.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Value to compare against. The value block must only contain one argument. For example when a condition is evaluated against a string-type field, only string_value should be set. This argument is mandatory, except for conditions using the EXISTS operator. Structure is documented below.</summary>
    [JsonPropertyName("value")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValue>? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditions
{
    /// <summary>Conditions to apply to the expression. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditions>? Conditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressions
{
    /// <summary>Conditions to apply to the expression. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditions>? Conditions { get; set; }

    /// <summary>The operator to apply to the result of conditions. Default and currently only supported value is AND. Default value is AND. Possible values are: AND.</summary>
    [JsonPropertyName("logicalOperator")]
    public string? LogicalOperator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsCondition
{
    /// <summary>An expression, consisting of an operator and conditions. Structure is documented below.</summary>
    [JsonPropertyName("expressions")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressions>? Expressions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressions
{
    /// <summary>A condition that when it evaluates to true will result in the record being evaluated to be suppressed from the transformed content. Structure is documented below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsCondition>? Condition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformations
{
    /// <summary>Transform the record by applying various field transformations. Structure is documented below.</summary>
    [JsonPropertyName("fieldTransformations")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformations>? FieldTransformations { get; set; }

    /// <summary>Configuration defining which records get suppressed entirely. Records that match any suppression rule are omitted from the output. Structure is documented below.</summary>
    [JsonPropertyName("recordSuppressions")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressions>? RecordSuppressions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfig
{
    /// <summary>Treat the dataset as an image and redact. Structure is documented below.</summary>
    [JsonPropertyName("imageTransformations")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformations>? ImageTransformations { get; set; }

    /// <summary>Treat the dataset as free-form text and apply the same free text transformation everywhere Structure is documented below.</summary>
    [JsonPropertyName("infoTypeTransformations")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformations>? InfoTypeTransformations { get; set; }

    /// <summary>Treat the dataset as structured. Transformations can be applied to specific locations within structured datasets, such as transforming a column within a table. Structure is documented below.</summary>
    [JsonPropertyName("recordTransformations")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformations>? RecordTransformations { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusAtProvider
{
    /// <summary>The creation timestamp of an deidentifyTemplate. Set by the server.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Configuration of the deidentify template Structure is documented below.</summary>
    [JsonPropertyName("deidentifyConfig")]
    public IList<V1beta1DeidentifyTemplateStatusAtProviderDeidentifyConfig>? DeidentifyConfig { get; set; }

    /// <summary>A description of the template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User set display name of the template.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>an identifier for the resource with format {{parent}}/deidentifyTemplates/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The resource name of the template. Set by the server.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parent of the template in any of the following formats:</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>The template id can contain uppercase and lowercase letters, numbers, and hyphens; that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is 100 characters. Can be empty to allow the system to generate one.</summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }

    /// <summary>The last update timestamp of an deidentifyTemplate. Set by the server.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatusConditions
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

/// <summary>DeidentifyTemplateStatus defines the observed state of DeidentifyTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeidentifyTemplateStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DeidentifyTemplateStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DeidentifyTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DeidentifyTemplate is the Schema for the DeidentifyTemplates API. Allows creation of templates to de-identify content.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DeidentifyTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DeidentifyTemplateSpec>, IStatus<V1beta1DeidentifyTemplateStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DeidentifyTemplate";
    public const string KubeGroup = "datalossprevention.gcp.upbound.io";
    public const string KubePluralName = "deidentifytemplates";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DeidentifyTemplateSpec defines the desired state of DeidentifyTemplate</summary>
    [JsonPropertyName("spec")]
    public V1beta1DeidentifyTemplateSpec Spec { get; set; }

    /// <summary>DeidentifyTemplateStatus defines the observed state of DeidentifyTemplate.</summary>
    [JsonPropertyName("status")]
    public V1beta1DeidentifyTemplateStatus? Status { get; set; }
}