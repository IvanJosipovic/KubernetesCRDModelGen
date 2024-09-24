using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.media.azure.upbound.io;
public enum V1beta1TransformSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1TransformSpecForProviderMediaServicesAccountNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransformSpecForProviderMediaServicesAccountNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransformSpecForProviderMediaServicesAccountNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransformSpecForProviderMediaServicesAccountNameRefPolicyResolutionEnum>))]
    public V1beta1TransformSpecForProviderMediaServicesAccountNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransformSpecForProviderMediaServicesAccountNameRefPolicyResolveEnum>))]
    public V1beta1TransformSpecForProviderMediaServicesAccountNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransformSpecForProviderMediaServicesAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransformSpecForProviderMediaServicesAccountNameRefPolicy? Policy { get; set; }
}

public enum V1beta1TransformSpecForProviderMediaServicesAccountNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransformSpecForProviderMediaServicesAccountNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransformSpecForProviderMediaServicesAccountNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransformSpecForProviderMediaServicesAccountNameSelectorPolicyResolutionEnum>))]
    public V1beta1TransformSpecForProviderMediaServicesAccountNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransformSpecForProviderMediaServicesAccountNameSelectorPolicyResolveEnum>))]
    public V1beta1TransformSpecForProviderMediaServicesAccountNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransformSpecForProviderMediaServicesAccountNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransformSpecForProviderMediaServicesAccountNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputAudioAnalyzerPreset
{
    /// <summary>Possible values are Basic or Standard. Determines the set of audio analysis operations to be performed. Default to Standard.</summary>
    [JsonPropertyName("audioAnalysisMode")]
    public string? AudioAnalysisMode { get; set; }

    /// <summary>The language for the audio payload in the input using the BCP-47 format of 'language tag-region' (e.g: 'en-US'). If you know the language of your content, it is recommended that you specify it. The language must be specified explicitly for AudioAnalysisMode:Basic, since automatic language detection is not included in basic mode. If the language isn't specified, automatic language detection will choose the first language detected and process with the selected language for the duration of the file. It does not currently support dynamically switching between languages after the first language is detected. The automatic detection works best with audio recordings with clearly discernible speech. If automatic detection fails to find the language, transcription would fall back to en-US. The list of supported languages is available here: https://go.microsoft.com/fwlink/?linkid=2109463.</summary>
    [JsonPropertyName("audioLanguage")]
    public string? AudioLanguage { get; set; }

    /// <summary>Dictionary containing key value pairs for parameters not exposed in the preset itself.</summary>
    [JsonPropertyName("experimentalOptions")]
    public IDictionary<string, string>? ExperimentalOptions { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputBuiltinPresetPresetConfiguration
{
    /// <summary>The complexity of the encoding. Possible values are Balanced, Speed or Quality.</summary>
    [JsonPropertyName("complexity")]
    public string? Complexity { get; set; }

    /// <summary>Specifies the interleave mode of the output to control how audio are stored in the container format. Possible values are InterleavedOutput and NonInterleavedOutput.</summary>
    [JsonPropertyName("interleaveOutput")]
    public string? InterleaveOutput { get; set; }

    /// <summary>The key frame interval in seconds. Possible value is a positive float. For example, set as 2.0 to reduce the playback buffering for some players.</summary>
    [JsonPropertyName("keyFrameIntervalInSeconds")]
    public double? KeyFrameIntervalInSeconds { get; set; }

    /// <summary>The maximum bitrate in bits per second (threshold for the top video layer). For example, set as 6000000 to avoid producing very high bitrate outputs for contents with high complexity.</summary>
    [JsonPropertyName("maxBitrateBps")]
    public double? MaxBitrateBps { get; set; }

    /// <summary>The maximum height of output video layers. For example, set as 720 to produce output layers up to 720P even if the input is 4K.</summary>
    [JsonPropertyName("maxHeight")]
    public double? MaxHeight { get; set; }

    /// <summary>The maximum number of output video layers. For example, set as 4 to make sure at most 4 output layers are produced to control the overall cost of the encoding job.</summary>
    [JsonPropertyName("maxLayers")]
    public double? MaxLayers { get; set; }

    /// <summary>The minimum bitrate in bits per second (threshold for the bottom video layer). For example, set as 200000 to have a bottom layer that covers users with low network bandwidth.</summary>
    [JsonPropertyName("minBitrateBps")]
    public double? MinBitrateBps { get; set; }

    /// <summary>The minimum height of output video layers. For example, set as 360 to avoid output layers of smaller resolutions like 180P.</summary>
    [JsonPropertyName("minHeight")]
    public double? MinHeight { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputBuiltinPreset
{
    /// <summary>A preset_configuration block as defined below.</summary>
    [JsonPropertyName("presetConfiguration")]
    public IList<V1beta1TransformSpecForProviderOutputBuiltinPresetPresetConfiguration>? PresetConfiguration { get; set; }

    /// <summary>The built-in preset to be used for encoding videos. The Possible values are AACGoodQualityAudio, AdaptiveStreaming, ContentAwareEncoding, ContentAwareEncodingExperimental, CopyAllBitrateNonInterleaved, DDGoodQualityAudio, H265AdaptiveStreaming, H265ContentAwareEncoding, H265SingleBitrate4K, H265SingleBitrate1080p, H265SingleBitrate720p, H264MultipleBitrate1080p, H264MultipleBitrateSD, H264MultipleBitrate720p, H264SingleBitrate1080p, H264SingleBitrateSD and H264SingleBitrate720p.</summary>
    [JsonPropertyName("presetName")]
    public string? PresetName { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetCodecAacAudio
{
    /// <summary>The average bitrate in bits per second at which to encode the input video when generating this layer.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>The number of audio channels. Default to 2.</summary>
    [JsonPropertyName("channels")]
    public double? Channels { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The H.264 profile. Possible values are Auto, Baseline, High, High422, High444,or Main. Default to Auto.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>The sampling rate to use for encoding in Hertz. Default to 48000.</summary>
    [JsonPropertyName("samplingRate")]
    public double? SamplingRate { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetCodecCopyAudio
{
    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetCodecCopyVideo
{
    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetCodecDdAudio
{
    /// <summary>The average bitrate in bits per second at which to encode the input video when generating this layer.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>The number of audio channels. Default to 2.</summary>
    [JsonPropertyName("channels")]
    public double? Channels { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The sampling rate to use for encoding in Hertz. Default to 48000.</summary>
    [JsonPropertyName("samplingRate")]
    public double? SamplingRate { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetCodecH264VideoLayer
{
    /// <summary>Whether adaptive B-frames are used when encoding this layer. If not specified, the encoder will turn it on whenever the video profile permits its use. Default to true.</summary>
    [JsonPropertyName("adaptiveBFrameEnabled")]
    public bool? AdaptiveBFrameEnabled { get; set; }

    /// <summary>The number of B-frames to use when encoding this layer. If not specified, the encoder chooses an appropriate number based on the video profile and level.</summary>
    [JsonPropertyName("bFrames")]
    public double? BFrames { get; set; }

    /// <summary>The average bitrate in bits per second at which to encode the input video when generating this layer.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Specifies the maximum amount of time that the encoder should buffer frames before encoding. The value should be in ISO 8601 format. The value should be in the range 0.1 to 100 seconds. Defaults to PT5S.</summary>
    [JsonPropertyName("bufferWindow")]
    public string? BufferWindow { get; set; }

    /// <summary>The value of CRF to be used when encoding this layer. This setting takes effect when rate_control_mode is set CRF. The range of CRF value is between 0 and 51, where lower values would result in better quality, at the expense of higher file sizes. Higher values mean more compression, but at some point quality degradation will be noticed. Default to 23.</summary>
    [JsonPropertyName("crf")]
    public double? Crf { get; set; }

    /// <summary>The entropy mode to be used for this layer. Possible values are Cabac or Cavlc. If not specified, the encoder chooses the mode that is appropriate for the profile and level.</summary>
    [JsonPropertyName("entropyMode")]
    public string? EntropyMode { get; set; }

    /// <summary>The frame rate (in frames per second) at which to encode this layer. The value can be in the form of M/N where M and N are integers (For example, 30000/1001), or in the form of a number (For example, 30, or 29.97). The encoder enforces constraints on allowed frame rates based on the profile and level. If it is not specified, the encoder will use the same frame rate as the input video.</summary>
    [JsonPropertyName("frameRate")]
    public string? FrameRate { get; set; }

    /// <summary>The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("height")]
    public string? Height { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The H.264 levels. Currently, the resource support Level up to 6.2. The value can be auto, or a number that matches the H.264 profile. If not specified, the default is auto, which lets the encoder choose the Level that is appropriate for this layer.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>The maximum bitrate (in bits per second), at which the VBV buffer should be assumed to refill. If not specified, defaults to the same value as bitrate.</summary>
    [JsonPropertyName("maxBitrate")]
    public double? MaxBitrate { get; set; }

    /// <summary>The H.264 profile. Possible values are Auto, Baseline, High, High422, High444,or Main. Default to Auto.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>The number of reference frames to be used when encoding this layer. If not specified, the encoder determines an appropriate number based on the encoder complexity setting.</summary>
    [JsonPropertyName("referenceFrames")]
    public double? ReferenceFrames { get; set; }

    /// <summary>The number of slices to be used when encoding this layer. If not specified, default is 1, which means that encoder will use a single slice for each frame.</summary>
    [JsonPropertyName("slices")]
    public double? Slices { get; set; }

    /// <summary>The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("width")]
    public string? Width { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetCodecH264Video
{
    /// <summary>The complexity of the encoding. Possible values are Balanced, Speed or Quality.</summary>
    [JsonPropertyName("complexity")]
    public string? Complexity { get; set; }

    /// <summary>The distance between two key frames. The value should be non-zero in the range 0.5 to 20 seconds, specified in ISO 8601 format. Note that this setting is ignored if sync_mode is set to Passthrough, where the KeyFrameInterval value will follow the input source setting. Defaults to PT2S.</summary>
    [JsonPropertyName("keyFrameInterval")]
    public string? KeyFrameInterval { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>One or more layer blocks as defined below.</summary>
    [JsonPropertyName("layer")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetCodecH264VideoLayer>? Layer { get; set; }

    /// <summary>The rate control mode. Possible values are ABR, CBR or CRF. Default to ABR.</summary>
    [JsonPropertyName("rateControlMode")]
    public string? RateControlMode { get; set; }

    /// <summary>Whether the encoder should insert key frames at scene changes. This flag should be set to true only when the encoder is being configured to produce a single output video. Default to false.</summary>
    [JsonPropertyName("sceneChangeDetectionEnabled")]
    public bool? SceneChangeDetectionEnabled { get; set; }

    /// <summary>The resizing mode, which indicates how the input video will be resized to fit the desired output resolution(s). Possible values are AutoFit, AutoSize or None. Default to AutoSize.</summary>
    [JsonPropertyName("stretchMode")]
    public string? StretchMode { get; set; }

    /// <summary>Specifies the synchronization mode for the video. Possible values are Auto, Cfr, Passthrough or Vfr. Default to Auto.</summary>
    [JsonPropertyName("syncMode")]
    public string? SyncMode { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetCodecH265VideoLayer
{
    /// <summary>Whether adaptive B-frames are used when encoding this layer. If not specified, the encoder will turn it on whenever the video profile permits its use. Default to true.</summary>
    [JsonPropertyName("adaptiveBFrameEnabled")]
    public bool? AdaptiveBFrameEnabled { get; set; }

    /// <summary>The number of B-frames to use when encoding this layer. If not specified, the encoder chooses an appropriate number based on the video profile and level.</summary>
    [JsonPropertyName("bFrames")]
    public double? BFrames { get; set; }

    /// <summary>The average bitrate in bits per second at which to encode the input video when generating this layer.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Specifies the maximum amount of time that the encoder should buffer frames before encoding. The value should be in ISO 8601 format. The value should be in the range 0.1 to 100 seconds. Defaults to PT5S.</summary>
    [JsonPropertyName("bufferWindow")]
    public string? BufferWindow { get; set; }

    /// <summary>The value of CRF to be used when encoding this layer. This setting takes effect when rate_control_mode is set CRF. The range of CRF value is between 0 and 51, where lower values would result in better quality, at the expense of higher file sizes. Higher values mean more compression, but at some point quality degradation will be noticed. Default to 23.</summary>
    [JsonPropertyName("crf")]
    public double? Crf { get; set; }

    /// <summary>The frame rate (in frames per second) at which to encode this layer. The value can be in the form of M/N where M and N are integers (For example, 30000/1001), or in the form of a number (For example, 30, or 29.97). The encoder enforces constraints on allowed frame rates based on the profile and level. If it is not specified, the encoder will use the same frame rate as the input video.</summary>
    [JsonPropertyName("frameRate")]
    public string? FrameRate { get; set; }

    /// <summary>The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("height")]
    public string? Height { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The H.264 levels. Currently, the resource support Level up to 6.2. The value can be auto, or a number that matches the H.264 profile. If not specified, the default is auto, which lets the encoder choose the Level that is appropriate for this layer.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>The maximum bitrate (in bits per second), at which the VBV buffer should be assumed to refill. If not specified, defaults to the same value as bitrate.</summary>
    [JsonPropertyName("maxBitrate")]
    public double? MaxBitrate { get; set; }

    /// <summary>The H.264 profile. Possible values are Auto, Baseline, High, High422, High444,or Main. Default to Auto.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>The number of reference frames to be used when encoding this layer. If not specified, the encoder determines an appropriate number based on the encoder complexity setting.</summary>
    [JsonPropertyName("referenceFrames")]
    public double? ReferenceFrames { get; set; }

    /// <summary>The number of slices to be used when encoding this layer. If not specified, default is 1, which means that encoder will use a single slice for each frame.</summary>
    [JsonPropertyName("slices")]
    public double? Slices { get; set; }

    /// <summary>The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("width")]
    public string? Width { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetCodecH265Video
{
    /// <summary>The complexity of the encoding. Possible values are Balanced, Speed or Quality.</summary>
    [JsonPropertyName("complexity")]
    public string? Complexity { get; set; }

    /// <summary>The distance between two key frames. The value should be non-zero in the range 0.5 to 20 seconds, specified in ISO 8601 format. Note that this setting is ignored if sync_mode is set to Passthrough, where the KeyFrameInterval value will follow the input source setting. Defaults to PT2S.</summary>
    [JsonPropertyName("keyFrameInterval")]
    public string? KeyFrameInterval { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>One or more layer blocks as defined below.</summary>
    [JsonPropertyName("layer")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetCodecH265VideoLayer>? Layer { get; set; }

    /// <summary>Whether the encoder should insert key frames at scene changes. This flag should be set to true only when the encoder is being configured to produce a single output video. Default to false.</summary>
    [JsonPropertyName("sceneChangeDetectionEnabled")]
    public bool? SceneChangeDetectionEnabled { get; set; }

    /// <summary>The resizing mode, which indicates how the input video will be resized to fit the desired output resolution(s). Possible values are AutoFit, AutoSize or None. Default to AutoSize.</summary>
    [JsonPropertyName("stretchMode")]
    public string? StretchMode { get; set; }

    /// <summary>Specifies the synchronization mode for the video. Possible values are Auto, Cfr, Passthrough or Vfr. Default to Auto.</summary>
    [JsonPropertyName("syncMode")]
    public string? SyncMode { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetCodecJpgImageLayer
{
    /// <summary>The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("height")]
    public string? Height { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The compression quality of the JPEG output. Range is from 0 to 100 and the default is 70.</summary>
    [JsonPropertyName("quality")]
    public double? Quality { get; set; }

    /// <summary>The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("width")]
    public string? Width { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetCodecJpgImage
{
    /// <summary>The distance between two key frames. The value should be non-zero in the range 0.5 to 20 seconds, specified in ISO 8601 format. Note that this setting is ignored if sync_mode is set to Passthrough, where the KeyFrameInterval value will follow the input source setting. Defaults to PT2S.</summary>
    [JsonPropertyName("keyFrameInterval")]
    public string? KeyFrameInterval { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>One or more layer blocks as defined below.</summary>
    [JsonPropertyName("layer")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetCodecJpgImageLayer>? Layer { get; set; }

    /// <summary>The position relative to transform preset start time in the input video at which to stop generating thumbnails. The value can be in ISO 8601 format (For example, PT5M30S to stop at 5 minutes and 30 seconds from start time), or a frame count (For example, 300 to stop at the 300th frame from the frame at start time. If this value is 1, it means only producing one thumbnail at start time), or a relative value to the stream duration (For example, 50% to stop at half of stream duration from start time). The default value is 100%, which means to stop at the end of the stream.</summary>
    [JsonPropertyName("range")]
    public string? Range { get; set; }

    /// <summary>Sets the number of columns used in thumbnail sprite image. The number of rows are automatically calculated and a VTT file is generated with the coordinate mappings for each thumbnail in the sprite. Note: this value should be a positive integer and a proper value is recommended so that the output image resolution will not go beyond JPEG maximum pixel resolution limit 65535x65535.</summary>
    [JsonPropertyName("spriteColumn")]
    public double? SpriteColumn { get; set; }

    /// <summary>The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }

    /// <summary>The intervals at which thumbnails are generated. The value can be in ISO 8601 format (For example, PT05S for one image every 5 seconds), or a frame count (For example, 30 for one image every 30 frames), or a relative value to stream duration (For example, 10% for one image every 10% of stream duration). Note: Step value will affect the first generated thumbnail, which may not be exactly the one specified at transform preset start time. This is due to the encoder, which tries to select the best thumbnail between start time and Step position from start time as the first output. As the default value is 10%, it means if stream has long duration, the first generated thumbnail might be far away from the one specified at start time. Try to select reasonable value for Step if the first thumbnail is expected close to start time, or set Range value at 1 if only one thumbnail is needed at start time.</summary>
    [JsonPropertyName("step")]
    public string? Step { get; set; }

    /// <summary>The resizing mode, which indicates how the input video will be resized to fit the desired output resolution(s). Possible values are AutoFit, AutoSize or None. Default to AutoSize.</summary>
    [JsonPropertyName("stretchMode")]
    public string? StretchMode { get; set; }

    /// <summary>Specifies the synchronization mode for the video. Possible values are Auto, Cfr, Passthrough or Vfr. Default to Auto.</summary>
    [JsonPropertyName("syncMode")]
    public string? SyncMode { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetCodecPngImageLayer
{
    /// <summary>The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("height")]
    public string? Height { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("width")]
    public string? Width { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetCodecPngImage
{
    /// <summary>The distance between two key frames. The value should be non-zero in the range 0.5 to 20 seconds, specified in ISO 8601 format. Note that this setting is ignored if sync_mode is set to Passthrough, where the KeyFrameInterval value will follow the input source setting. Defaults to PT2S.</summary>
    [JsonPropertyName("keyFrameInterval")]
    public string? KeyFrameInterval { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>One or more layer blocks as defined below.</summary>
    [JsonPropertyName("layer")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetCodecPngImageLayer>? Layer { get; set; }

    /// <summary>The position relative to transform preset start time in the input video at which to stop generating thumbnails. The value can be in ISO 8601 format (For example, PT5M30S to stop at 5 minutes and 30 seconds from start time), or a frame count (For example, 300 to stop at the 300th frame from the frame at start time. If this value is 1, it means only producing one thumbnail at start time), or a relative value to the stream duration (For example, 50% to stop at half of stream duration from start time). The default value is 100%, which means to stop at the end of the stream.</summary>
    [JsonPropertyName("range")]
    public string? Range { get; set; }

    /// <summary>The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }

    /// <summary>The intervals at which thumbnails are generated. The value can be in ISO 8601 format (For example, PT05S for one image every 5 seconds), or a frame count (For example, 30 for one image every 30 frames), or a relative value to stream duration (For example, 10% for one image every 10% of stream duration). Note: Step value will affect the first generated thumbnail, which may not be exactly the one specified at transform preset start time. This is due to the encoder, which tries to select the best thumbnail between start time and Step position from start time as the first output. As the default value is 10%, it means if stream has long duration, the first generated thumbnail might be far away from the one specified at start time. Try to select reasonable value for Step if the first thumbnail is expected close to start time, or set Range value at 1 if only one thumbnail is needed at start time.</summary>
    [JsonPropertyName("step")]
    public string? Step { get; set; }

    /// <summary>The resizing mode, which indicates how the input video will be resized to fit the desired output resolution(s). Possible values are AutoFit, AutoSize or None. Default to AutoSize.</summary>
    [JsonPropertyName("stretchMode")]
    public string? StretchMode { get; set; }

    /// <summary>Specifies the synchronization mode for the video. Possible values are Auto, Cfr, Passthrough or Vfr. Default to Auto.</summary>
    [JsonPropertyName("syncMode")]
    public string? SyncMode { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetCodec
{
    /// <summary>A aac_audio block as defined above.</summary>
    [JsonPropertyName("aacAudio")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetCodecAacAudio>? AacAudio { get; set; }

    /// <summary>A copy_audio block as defined below.</summary>
    [JsonPropertyName("copyAudio")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetCodecCopyAudio>? CopyAudio { get; set; }

    /// <summary>A copy_video block as defined below.</summary>
    [JsonPropertyName("copyVideo")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetCodecCopyVideo>? CopyVideo { get; set; }

    /// <summary>A dd_audio block as defined below.</summary>
    [JsonPropertyName("ddAudio")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetCodecDdAudio>? DdAudio { get; set; }

    /// <summary>A h264_video block as defined below.</summary>
    [JsonPropertyName("h264Video")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetCodecH264Video>? H264Video { get; set; }

    /// <summary>A h265_video block as defined below.</summary>
    [JsonPropertyName("h265Video")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetCodecH265Video>? H265Video { get; set; }

    /// <summary>A jpg_image block as defined below.</summary>
    [JsonPropertyName("jpgImage")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetCodecJpgImage>? JpgImage { get; set; }

    /// <summary>A png_image block as defined below.</summary>
    [JsonPropertyName("pngImage")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetCodecPngImage>? PngImage { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetFilterCropRectangle
{
    /// <summary>The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("height")]
    public string? Height { get; set; }

    /// <summary>The number of pixels from the left-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("left")]
    public string? Left { get; set; }

    /// <summary>The number of pixels from the top-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("top")]
    public string? Top { get; set; }

    /// <summary>The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("width")]
    public string? Width { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetFilterDeinterlace
{
    /// <summary>The deinterlacing mode. Possible values are AutoPixelAdaptive or Off. Default to AutoPixelAdaptive.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The field parity to use for deinterlacing. Possible values are Auto, TopFieldFirst or BottomFieldFirst. Default to Auto.</summary>
    [JsonPropertyName("parity")]
    public string? Parity { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetFilterFadeIn
{
    /// <summary>The duration of the fade effect in the video. The value can be in ISO 8601 format (For example, PT05S to fade In/Out a color during 5 seconds), or a frame count (For example, 10 to fade 10 frames from the start time), or a relative value to stream duration (For example, 10% to fade 10% of stream duration).</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>The color for the fade in/out. It can be on the CSS Level1 colors or an RGB/hex value: e.g: rgb(255,0,0), 0xFF0000 or #FF0000.</summary>
    [JsonPropertyName("fadeColor")]
    public string? FadeColor { get; set; }

    /// <summary>The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetFilterFadeOut
{
    /// <summary>The duration of the fade effect in the video. The value can be in ISO 8601 format (For example, PT05S to fade In/Out a color during 5 seconds), or a frame count (For example, 10 to fade 10 frames from the start time), or a relative value to stream duration (For example, 10% to fade 10% of stream duration).</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>The color for the fade in/out. It can be on the CSS Level1 colors or an RGB/hex value: e.g: rgb(255,0,0), 0xFF0000 or #FF0000.</summary>
    [JsonPropertyName("fadeColor")]
    public string? FadeColor { get; set; }

    /// <summary>The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetFilterOverlayAudio
{
    /// <summary>The gain level of audio in the overlay. The value should be in range between 0 to 1.0. The default is 1.0.</summary>
    [JsonPropertyName("audioGainLevel")]
    public double? AudioGainLevel { get; set; }

    /// <summary>The end position, with reference to the input video, at which the overlay ends. The value should be in ISO 8601 format. For example, PT30S to end the overlay at 30 seconds into the input video. If not specified or the value is greater than the input video duration, the overlay will be applied until the end of the input video if the overlay media duration is greater than the input video duration, else the overlay will last as long as the overlay media duration.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>The duration over which the overlay fades in onto the input video. The value should be in ISO 8601 duration format. If not specified the default behavior is to have no fade in (same as PT0S).</summary>
    [JsonPropertyName("fadeInDuration")]
    public string? FadeInDuration { get; set; }

    /// <summary>The duration over which the overlay fades out of the input video. The value should be in ISO 8601 duration format. If not specified the default behavior is to have no fade out (same as PT0S).</summary>
    [JsonPropertyName("fadeOutDuration")]
    public string? FadeOutDuration { get; set; }

    /// <summary>The label of the job input which is to be used as an overlay. The input must specify exact one file. You can specify an image file in JPG, PNG, GIF or BMP format, or an audio file (such as a WAV, MP3, WMA or M4A file), or a video file.</summary>
    [JsonPropertyName("inputLabel")]
    public string? InputLabel { get; set; }

    /// <summary>The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetFilterOverlayVideoCropRectangle
{
    /// <summary>The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("height")]
    public string? Height { get; set; }

    /// <summary>The number of pixels from the left-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("left")]
    public string? Left { get; set; }

    /// <summary>The number of pixels from the top-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("top")]
    public string? Top { get; set; }

    /// <summary>The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("width")]
    public string? Width { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetFilterOverlayVideoPosition
{
    /// <summary>The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("height")]
    public string? Height { get; set; }

    /// <summary>The number of pixels from the left-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("left")]
    public string? Left { get; set; }

    /// <summary>The number of pixels from the top-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("top")]
    public string? Top { get; set; }

    /// <summary>The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("width")]
    public string? Width { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetFilterOverlayVideo
{
    /// <summary>The gain level of audio in the overlay. The value should be in range between 0 to 1.0. The default is 1.0.</summary>
    [JsonPropertyName("audioGainLevel")]
    public double? AudioGainLevel { get; set; }

    /// <summary>A crop_rectangle block as defined above.</summary>
    [JsonPropertyName("cropRectangle")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetFilterOverlayVideoCropRectangle>? CropRectangle { get; set; }

    /// <summary>The end position, with reference to the input video, at which the overlay ends. The value should be in ISO 8601 format. For example, PT30S to end the overlay at 30 seconds into the input video. If not specified or the value is greater than the input video duration, the overlay will be applied until the end of the input video if the overlay media duration is greater than the input video duration, else the overlay will last as long as the overlay media duration.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>The duration over which the overlay fades in onto the input video. The value should be in ISO 8601 duration format. If not specified the default behavior is to have no fade in (same as PT0S).</summary>
    [JsonPropertyName("fadeInDuration")]
    public string? FadeInDuration { get; set; }

    /// <summary>The duration over which the overlay fades out of the input video. The value should be in ISO 8601 duration format. If not specified the default behavior is to have no fade out (same as PT0S).</summary>
    [JsonPropertyName("fadeOutDuration")]
    public string? FadeOutDuration { get; set; }

    /// <summary>The label of the job input which is to be used as an overlay. The input must specify exact one file. You can specify an image file in JPG, PNG, GIF or BMP format, or an audio file (such as a WAV, MP3, WMA or M4A file), or a video file.</summary>
    [JsonPropertyName("inputLabel")]
    public string? InputLabel { get; set; }

    /// <summary>The opacity of the overlay. The value should be in the range between 0 to 1.0. Default to 1.0, which means the overlay is opaque.</summary>
    [JsonPropertyName("opacity")]
    public double? Opacity { get; set; }

    /// <summary>A position block as defined above.</summary>
    [JsonPropertyName("position")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetFilterOverlayVideoPosition>? Position { get; set; }

    /// <summary>The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetFilterOverlay
{
    /// <summary>An audio block as defined above.</summary>
    [JsonPropertyName("audio")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetFilterOverlayAudio>? Audio { get; set; }

    /// <summary>A video block as defined below.</summary>
    [JsonPropertyName("video")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetFilterOverlayVideo>? Video { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetFilter
{
    /// <summary>A crop_rectangle block as defined above.</summary>
    [JsonPropertyName("cropRectangle")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetFilterCropRectangle>? CropRectangle { get; set; }

    /// <summary>A deinterlace block as defined below.</summary>
    [JsonPropertyName("deinterlace")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetFilterDeinterlace>? Deinterlace { get; set; }

    /// <summary>A fade_in block as defined above.</summary>
    [JsonPropertyName("fadeIn")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetFilterFadeIn>? FadeIn { get; set; }

    /// <summary>A fade_out block as defined above.</summary>
    [JsonPropertyName("fadeOut")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetFilterFadeOut>? FadeOut { get; set; }

    /// <summary>One or more overlay blocks as defined below.</summary>
    [JsonPropertyName("overlay")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetFilterOverlay>? Overlay { get; set; }

    /// <summary>The rotation to be applied to the input video before it is encoded. Possible values are Auto, None, Rotate90, Rotate180, Rotate270,or Rotate0. Default to Auto.</summary>
    [JsonPropertyName("rotation")]
    public string? Rotation { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetFormatJpg
{
    /// <summary>The file naming pattern used for the creation of output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {AudioStream} - string "Audio" plus audio stream number(start from 1). {Bitrate} - The audio/video bitrate in kbps. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename.</summary>
    [JsonPropertyName("filenamePattern")]
    public string? FilenamePattern { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetFormatMp4OutputFile
{
    /// <summary>The list of labels that describe how the encoder should multiplex video and audio into an output file. For example, if the encoder is producing two video layers with labels v1 and v2, and one audio layer with label a1, then an array like ["v1", "a1"] tells the encoder to produce an output file with the video track represented by v1 and the audio track represented by a1.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetFormatMp4
{
    /// <summary>The file naming pattern used for the creation of output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {AudioStream} - string "Audio" plus audio stream number(start from 1). {Bitrate} - The audio/video bitrate in kbps. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename.</summary>
    [JsonPropertyName("filenamePattern")]
    public string? FilenamePattern { get; set; }

    /// <summary>One or more output_file blocks as defined above.</summary>
    [JsonPropertyName("outputFile")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetFormatMp4OutputFile>? OutputFile { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetFormatPng
{
    /// <summary>The file naming pattern used for the creation of output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {AudioStream} - string "Audio" plus audio stream number(start from 1). {Bitrate} - The audio/video bitrate in kbps. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename.</summary>
    [JsonPropertyName("filenamePattern")]
    public string? FilenamePattern { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetFormatTransportStreamOutputFile
{
    /// <summary>The list of labels that describe how the encoder should multiplex video and audio into an output file. For example, if the encoder is producing two video layers with labels v1 and v2, and one audio layer with label a1, then an array like ["v1", "a1"] tells the encoder to produce an output file with the video track represented by v1 and the audio track represented by a1.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetFormatTransportStream
{
    /// <summary>The file naming pattern used for the creation of output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {AudioStream} - string "Audio" plus audio stream number(start from 1). {Bitrate} - The audio/video bitrate in kbps. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename.</summary>
    [JsonPropertyName("filenamePattern")]
    public string? FilenamePattern { get; set; }

    /// <summary>One or more output_file blocks as defined above.</summary>
    [JsonPropertyName("outputFile")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetFormatTransportStreamOutputFile>? OutputFile { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPresetFormat
{
    /// <summary>A jpg block as defined below.</summary>
    [JsonPropertyName("jpg")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetFormatJpg>? Jpg { get; set; }

    /// <summary>A mp4 block as defined below.</summary>
    [JsonPropertyName("mp4")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetFormatMp4>? Mp4 { get; set; }

    /// <summary>A png block as defined below.</summary>
    [JsonPropertyName("png")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetFormatPng>? Png { get; set; }

    /// <summary>A transport_stream block as defined below.</summary>
    [JsonPropertyName("transportStream")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetFormatTransportStream>? TransportStream { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputCustomPreset
{
    /// <summary>One or more codec blocks as defined above.</summary>
    [JsonPropertyName("codec")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetCodec>? Codec { get; set; }

    /// <summary>Dictionary containing key value pairs for parameters not exposed in the preset itself.</summary>
    [JsonPropertyName("experimentalOptions")]
    public IDictionary<string, string>? ExperimentalOptions { get; set; }

    /// <summary>A filter block as defined below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetFilter>? Filter { get; set; }

    /// <summary>One or more format blocks as defined below.</summary>
    [JsonPropertyName("format")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPresetFormat>? Format { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputFaceDetectorPreset
{
    /// <summary>Possible values are SourceResolution or StandardDefinition. Specifies the maximum resolution at which your video is analyzed. which will keep the input video at its original resolution when analyzed. Using StandardDefinition will resize input videos to standard definition while preserving the appropriate aspect ratio. It will only resize if the video is of higher resolution. For example, a 1920x1080 input would be scaled to 640x360 before processing. Switching to StandardDefinition will reduce the time it takes to process high resolution video. It may also reduce the cost of using this component (see https://azure.microsoft.com/en-us/pricing/details/media-services/#analytics for details). However, faces that end up being too small in the resized video may not be detected. Default to SourceResolution.</summary>
    [JsonPropertyName("analysisResolution")]
    public string? AnalysisResolution { get; set; }

    /// <summary>Specifies the type of blur to apply to faces in the output video. Possible values are Black, Box, High, Low,and Med.</summary>
    [JsonPropertyName("blurType")]
    public string? BlurType { get; set; }

    /// <summary>Dictionary containing key value pairs for parameters not exposed in the preset itself.</summary>
    [JsonPropertyName("experimentalOptions")]
    public IDictionary<string, string>? ExperimentalOptions { get; set; }

    /// <summary>This mode provides the ability to choose between the following settings: 1) Analyze - For detection only. This mode generates a metadata JSON file marking appearances of faces throughout the video. Where possible, appearances of the same person are assigned the same ID. 2) Combined - Additionally redacts(blurs) detected faces. 3) Redact - This enables a 2-pass process, allowing for selective redaction of a subset of detected faces. It takes in the metadata file from a prior analyze pass, along with the source video, and a user-selected subset of IDs that require redaction. Default to Analyze.</summary>
    [JsonPropertyName("faceRedactorMode")]
    public string? FaceRedactorMode { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutputVideoAnalyzerPreset
{
    /// <summary>Possible values are Basic or Standard. Determines the set of audio analysis operations to be performed. Default to Standard.</summary>
    [JsonPropertyName("audioAnalysisMode")]
    public string? AudioAnalysisMode { get; set; }

    /// <summary>The language for the audio payload in the input using the BCP-47 format of 'language tag-region' (e.g: 'en-US'). If you know the language of your content, it is recommended that you specify it. The language must be specified explicitly for AudioAnalysisMode:Basic, since automatic language detection is not included in basic mode. If the language isn't specified, automatic language detection will choose the first language detected and process with the selected language for the duration of the file. It does not currently support dynamically switching between languages after the first language is detected. The automatic detection works best with audio recordings with clearly discernible speech. If automatic detection fails to find the language, transcription would fall back to en-US. The list of supported languages is available here: https://go.microsoft.com/fwlink/?linkid=2109463.</summary>
    [JsonPropertyName("audioLanguage")]
    public string? AudioLanguage { get; set; }

    /// <summary>Dictionary containing key value pairs for parameters not exposed in the preset itself.</summary>
    [JsonPropertyName("experimentalOptions")]
    public IDictionary<string, string>? ExperimentalOptions { get; set; }

    /// <summary>Defines the type of insights that you want the service to generate. The allowed values are AudioInsightsOnly, VideoInsightsOnly, and AllInsights. If you set this to AllInsights and the input is audio only, then only audio insights are generated. Similarly, if the input is video only, then only video insights are generated. It is recommended that you not use AudioInsightsOnly if you expect some of your inputs to be video only; or use VideoInsightsOnly if you expect some of your inputs to be audio only. Your Jobs in such conditions would error out. Default to AllInsights.</summary>
    [JsonPropertyName("insightsType")]
    public string? InsightsType { get; set; }
}

public partial class V1beta1TransformSpecForProviderOutput
{
    /// <summary>An audio_analyzer_preset block as defined above.</summary>
    [JsonPropertyName("audioAnalyzerPreset")]
    public IList<V1beta1TransformSpecForProviderOutputAudioAnalyzerPreset>? AudioAnalyzerPreset { get; set; }

    /// <summary>A builtin_preset block as defined above.</summary>
    [JsonPropertyName("builtinPreset")]
    public IList<V1beta1TransformSpecForProviderOutputBuiltinPreset>? BuiltinPreset { get; set; }

    /// <summary>A custom_preset block as defined above.</summary>
    [JsonPropertyName("customPreset")]
    public IList<V1beta1TransformSpecForProviderOutputCustomPreset>? CustomPreset { get; set; }

    /// <summary>A face_detector_preset block as defined above.</summary>
    [JsonPropertyName("faceDetectorPreset")]
    public IList<V1beta1TransformSpecForProviderOutputFaceDetectorPreset>? FaceDetectorPreset { get; set; }

    /// <summary>A Transform can define more than one outputs. This property defines what the service should do when one output fails - either continue to produce other outputs, or, stop the other outputs. The overall Job state will not reflect failures of outputs that are specified with ContinueJob. Possible values are StopProcessingJob or ContinueJob. Defaults to StopProcessingJob.</summary>
    [JsonPropertyName("onErrorAction")]
    public string? OnErrorAction { get; set; }

    /// <summary>Sets the relative priority of the TransformOutputs within a Transform. This sets the priority that the service uses for processing Transform Outputs. Possible values are High, Normal or Low. Defaults to Normal.</summary>
    [JsonPropertyName("relativePriority")]
    public string? RelativePriority { get; set; }

    /// <summary>A video_analyzer_preset block as defined below.</summary>
    [JsonPropertyName("videoAnalyzerPreset")]
    public IList<V1beta1TransformSpecForProviderOutputVideoAnalyzerPreset>? VideoAnalyzerPreset { get; set; }
}

public enum V1beta1TransformSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransformSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransformSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransformSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1TransformSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransformSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1TransformSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransformSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransformSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1TransformSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransformSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransformSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransformSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1TransformSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransformSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1TransformSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransformSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransformSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1TransformSpecForProvider
{
    /// <summary>An optional verbose description of the Transform.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Media Services account name. Changing this forces a new Transform to be created.</summary>
    [JsonPropertyName("mediaServicesAccountName")]
    public string? MediaServicesAccountName { get; set; }

    /// <summary>Reference to a ServicesAccount in media to populate mediaServicesAccountName.</summary>
    [JsonPropertyName("mediaServicesAccountNameRef")]
    public V1beta1TransformSpecForProviderMediaServicesAccountNameRef? MediaServicesAccountNameRef { get; set; }

    /// <summary>Selector for a ServicesAccount in media to populate mediaServicesAccountName.</summary>
    [JsonPropertyName("mediaServicesAccountNameSelector")]
    public V1beta1TransformSpecForProviderMediaServicesAccountNameSelector? MediaServicesAccountNameSelector { get; set; }

    /// <summary>One or more output blocks as defined below. At least one output must be defined.</summary>
    [JsonPropertyName("output")]
    public IList<V1beta1TransformSpecForProviderOutput>? Output { get; set; }

    /// <summary>The name of the Resource Group where the Transform should exist. Changing this forces a new Transform to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1TransformSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1TransformSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputAudioAnalyzerPreset
{
    /// <summary>Possible values are Basic or Standard. Determines the set of audio analysis operations to be performed. Default to Standard.</summary>
    [JsonPropertyName("audioAnalysisMode")]
    public string? AudioAnalysisMode { get; set; }

    /// <summary>The language for the audio payload in the input using the BCP-47 format of 'language tag-region' (e.g: 'en-US'). If you know the language of your content, it is recommended that you specify it. The language must be specified explicitly for AudioAnalysisMode:Basic, since automatic language detection is not included in basic mode. If the language isn't specified, automatic language detection will choose the first language detected and process with the selected language for the duration of the file. It does not currently support dynamically switching between languages after the first language is detected. The automatic detection works best with audio recordings with clearly discernible speech. If automatic detection fails to find the language, transcription would fall back to en-US. The list of supported languages is available here: https://go.microsoft.com/fwlink/?linkid=2109463.</summary>
    [JsonPropertyName("audioLanguage")]
    public string? AudioLanguage { get; set; }

    /// <summary>Dictionary containing key value pairs for parameters not exposed in the preset itself.</summary>
    [JsonPropertyName("experimentalOptions")]
    public IDictionary<string, string>? ExperimentalOptions { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputBuiltinPresetPresetConfiguration
{
    /// <summary>The complexity of the encoding. Possible values are Balanced, Speed or Quality.</summary>
    [JsonPropertyName("complexity")]
    public string? Complexity { get; set; }

    /// <summary>Specifies the interleave mode of the output to control how audio are stored in the container format. Possible values are InterleavedOutput and NonInterleavedOutput.</summary>
    [JsonPropertyName("interleaveOutput")]
    public string? InterleaveOutput { get; set; }

    /// <summary>The key frame interval in seconds. Possible value is a positive float. For example, set as 2.0 to reduce the playback buffering for some players.</summary>
    [JsonPropertyName("keyFrameIntervalInSeconds")]
    public double? KeyFrameIntervalInSeconds { get; set; }

    /// <summary>The maximum bitrate in bits per second (threshold for the top video layer). For example, set as 6000000 to avoid producing very high bitrate outputs for contents with high complexity.</summary>
    [JsonPropertyName("maxBitrateBps")]
    public double? MaxBitrateBps { get; set; }

    /// <summary>The maximum height of output video layers. For example, set as 720 to produce output layers up to 720P even if the input is 4K.</summary>
    [JsonPropertyName("maxHeight")]
    public double? MaxHeight { get; set; }

    /// <summary>The maximum number of output video layers. For example, set as 4 to make sure at most 4 output layers are produced to control the overall cost of the encoding job.</summary>
    [JsonPropertyName("maxLayers")]
    public double? MaxLayers { get; set; }

    /// <summary>The minimum bitrate in bits per second (threshold for the bottom video layer). For example, set as 200000 to have a bottom layer that covers users with low network bandwidth.</summary>
    [JsonPropertyName("minBitrateBps")]
    public double? MinBitrateBps { get; set; }

    /// <summary>The minimum height of output video layers. For example, set as 360 to avoid output layers of smaller resolutions like 180P.</summary>
    [JsonPropertyName("minHeight")]
    public double? MinHeight { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputBuiltinPreset
{
    /// <summary>A preset_configuration block as defined below.</summary>
    [JsonPropertyName("presetConfiguration")]
    public IList<V1beta1TransformSpecInitProviderOutputBuiltinPresetPresetConfiguration>? PresetConfiguration { get; set; }

    /// <summary>The built-in preset to be used for encoding videos. The Possible values are AACGoodQualityAudio, AdaptiveStreaming, ContentAwareEncoding, ContentAwareEncodingExperimental, CopyAllBitrateNonInterleaved, DDGoodQualityAudio, H265AdaptiveStreaming, H265ContentAwareEncoding, H265SingleBitrate4K, H265SingleBitrate1080p, H265SingleBitrate720p, H264MultipleBitrate1080p, H264MultipleBitrateSD, H264MultipleBitrate720p, H264SingleBitrate1080p, H264SingleBitrateSD and H264SingleBitrate720p.</summary>
    [JsonPropertyName("presetName")]
    public string? PresetName { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetCodecAacAudio
{
    /// <summary>The average bitrate in bits per second at which to encode the input video when generating this layer.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>The number of audio channels. Default to 2.</summary>
    [JsonPropertyName("channels")]
    public double? Channels { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The H.264 profile. Possible values are Auto, Baseline, High, High422, High444,or Main. Default to Auto.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>The sampling rate to use for encoding in Hertz. Default to 48000.</summary>
    [JsonPropertyName("samplingRate")]
    public double? SamplingRate { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetCodecCopyAudio
{
    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetCodecCopyVideo
{
    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetCodecDdAudio
{
    /// <summary>The average bitrate in bits per second at which to encode the input video when generating this layer.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>The number of audio channels. Default to 2.</summary>
    [JsonPropertyName("channels")]
    public double? Channels { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The sampling rate to use for encoding in Hertz. Default to 48000.</summary>
    [JsonPropertyName("samplingRate")]
    public double? SamplingRate { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetCodecH264VideoLayer
{
    /// <summary>Whether adaptive B-frames are used when encoding this layer. If not specified, the encoder will turn it on whenever the video profile permits its use. Default to true.</summary>
    [JsonPropertyName("adaptiveBFrameEnabled")]
    public bool? AdaptiveBFrameEnabled { get; set; }

    /// <summary>The number of B-frames to use when encoding this layer. If not specified, the encoder chooses an appropriate number based on the video profile and level.</summary>
    [JsonPropertyName("bFrames")]
    public double? BFrames { get; set; }

    /// <summary>The average bitrate in bits per second at which to encode the input video when generating this layer.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Specifies the maximum amount of time that the encoder should buffer frames before encoding. The value should be in ISO 8601 format. The value should be in the range 0.1 to 100 seconds. Defaults to PT5S.</summary>
    [JsonPropertyName("bufferWindow")]
    public string? BufferWindow { get; set; }

    /// <summary>The value of CRF to be used when encoding this layer. This setting takes effect when rate_control_mode is set CRF. The range of CRF value is between 0 and 51, where lower values would result in better quality, at the expense of higher file sizes. Higher values mean more compression, but at some point quality degradation will be noticed. Default to 23.</summary>
    [JsonPropertyName("crf")]
    public double? Crf { get; set; }

    /// <summary>The entropy mode to be used for this layer. Possible values are Cabac or Cavlc. If not specified, the encoder chooses the mode that is appropriate for the profile and level.</summary>
    [JsonPropertyName("entropyMode")]
    public string? EntropyMode { get; set; }

    /// <summary>The frame rate (in frames per second) at which to encode this layer. The value can be in the form of M/N where M and N are integers (For example, 30000/1001), or in the form of a number (For example, 30, or 29.97). The encoder enforces constraints on allowed frame rates based on the profile and level. If it is not specified, the encoder will use the same frame rate as the input video.</summary>
    [JsonPropertyName("frameRate")]
    public string? FrameRate { get; set; }

    /// <summary>The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("height")]
    public string? Height { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The H.264 levels. Currently, the resource support Level up to 6.2. The value can be auto, or a number that matches the H.264 profile. If not specified, the default is auto, which lets the encoder choose the Level that is appropriate for this layer.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>The maximum bitrate (in bits per second), at which the VBV buffer should be assumed to refill. If not specified, defaults to the same value as bitrate.</summary>
    [JsonPropertyName("maxBitrate")]
    public double? MaxBitrate { get; set; }

    /// <summary>The H.264 profile. Possible values are Auto, Baseline, High, High422, High444,or Main. Default to Auto.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>The number of reference frames to be used when encoding this layer. If not specified, the encoder determines an appropriate number based on the encoder complexity setting.</summary>
    [JsonPropertyName("referenceFrames")]
    public double? ReferenceFrames { get; set; }

    /// <summary>The number of slices to be used when encoding this layer. If not specified, default is 1, which means that encoder will use a single slice for each frame.</summary>
    [JsonPropertyName("slices")]
    public double? Slices { get; set; }

    /// <summary>The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("width")]
    public string? Width { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetCodecH264Video
{
    /// <summary>The complexity of the encoding. Possible values are Balanced, Speed or Quality.</summary>
    [JsonPropertyName("complexity")]
    public string? Complexity { get; set; }

    /// <summary>The distance between two key frames. The value should be non-zero in the range 0.5 to 20 seconds, specified in ISO 8601 format. Note that this setting is ignored if sync_mode is set to Passthrough, where the KeyFrameInterval value will follow the input source setting. Defaults to PT2S.</summary>
    [JsonPropertyName("keyFrameInterval")]
    public string? KeyFrameInterval { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>One or more layer blocks as defined below.</summary>
    [JsonPropertyName("layer")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetCodecH264VideoLayer>? Layer { get; set; }

    /// <summary>The rate control mode. Possible values are ABR, CBR or CRF. Default to ABR.</summary>
    [JsonPropertyName("rateControlMode")]
    public string? RateControlMode { get; set; }

    /// <summary>Whether the encoder should insert key frames at scene changes. This flag should be set to true only when the encoder is being configured to produce a single output video. Default to false.</summary>
    [JsonPropertyName("sceneChangeDetectionEnabled")]
    public bool? SceneChangeDetectionEnabled { get; set; }

    /// <summary>The resizing mode, which indicates how the input video will be resized to fit the desired output resolution(s). Possible values are AutoFit, AutoSize or None. Default to AutoSize.</summary>
    [JsonPropertyName("stretchMode")]
    public string? StretchMode { get; set; }

    /// <summary>Specifies the synchronization mode for the video. Possible values are Auto, Cfr, Passthrough or Vfr. Default to Auto.</summary>
    [JsonPropertyName("syncMode")]
    public string? SyncMode { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetCodecH265VideoLayer
{
    /// <summary>Whether adaptive B-frames are used when encoding this layer. If not specified, the encoder will turn it on whenever the video profile permits its use. Default to true.</summary>
    [JsonPropertyName("adaptiveBFrameEnabled")]
    public bool? AdaptiveBFrameEnabled { get; set; }

    /// <summary>The number of B-frames to use when encoding this layer. If not specified, the encoder chooses an appropriate number based on the video profile and level.</summary>
    [JsonPropertyName("bFrames")]
    public double? BFrames { get; set; }

    /// <summary>The average bitrate in bits per second at which to encode the input video when generating this layer.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Specifies the maximum amount of time that the encoder should buffer frames before encoding. The value should be in ISO 8601 format. The value should be in the range 0.1 to 100 seconds. Defaults to PT5S.</summary>
    [JsonPropertyName("bufferWindow")]
    public string? BufferWindow { get; set; }

    /// <summary>The value of CRF to be used when encoding this layer. This setting takes effect when rate_control_mode is set CRF. The range of CRF value is between 0 and 51, where lower values would result in better quality, at the expense of higher file sizes. Higher values mean more compression, but at some point quality degradation will be noticed. Default to 23.</summary>
    [JsonPropertyName("crf")]
    public double? Crf { get; set; }

    /// <summary>The frame rate (in frames per second) at which to encode this layer. The value can be in the form of M/N where M and N are integers (For example, 30000/1001), or in the form of a number (For example, 30, or 29.97). The encoder enforces constraints on allowed frame rates based on the profile and level. If it is not specified, the encoder will use the same frame rate as the input video.</summary>
    [JsonPropertyName("frameRate")]
    public string? FrameRate { get; set; }

    /// <summary>The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("height")]
    public string? Height { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The H.264 levels. Currently, the resource support Level up to 6.2. The value can be auto, or a number that matches the H.264 profile. If not specified, the default is auto, which lets the encoder choose the Level that is appropriate for this layer.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>The maximum bitrate (in bits per second), at which the VBV buffer should be assumed to refill. If not specified, defaults to the same value as bitrate.</summary>
    [JsonPropertyName("maxBitrate")]
    public double? MaxBitrate { get; set; }

    /// <summary>The H.264 profile. Possible values are Auto, Baseline, High, High422, High444,or Main. Default to Auto.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>The number of reference frames to be used when encoding this layer. If not specified, the encoder determines an appropriate number based on the encoder complexity setting.</summary>
    [JsonPropertyName("referenceFrames")]
    public double? ReferenceFrames { get; set; }

    /// <summary>The number of slices to be used when encoding this layer. If not specified, default is 1, which means that encoder will use a single slice for each frame.</summary>
    [JsonPropertyName("slices")]
    public double? Slices { get; set; }

    /// <summary>The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("width")]
    public string? Width { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetCodecH265Video
{
    /// <summary>The complexity of the encoding. Possible values are Balanced, Speed or Quality.</summary>
    [JsonPropertyName("complexity")]
    public string? Complexity { get; set; }

    /// <summary>The distance between two key frames. The value should be non-zero in the range 0.5 to 20 seconds, specified in ISO 8601 format. Note that this setting is ignored if sync_mode is set to Passthrough, where the KeyFrameInterval value will follow the input source setting. Defaults to PT2S.</summary>
    [JsonPropertyName("keyFrameInterval")]
    public string? KeyFrameInterval { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>One or more layer blocks as defined below.</summary>
    [JsonPropertyName("layer")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetCodecH265VideoLayer>? Layer { get; set; }

    /// <summary>Whether the encoder should insert key frames at scene changes. This flag should be set to true only when the encoder is being configured to produce a single output video. Default to false.</summary>
    [JsonPropertyName("sceneChangeDetectionEnabled")]
    public bool? SceneChangeDetectionEnabled { get; set; }

    /// <summary>The resizing mode, which indicates how the input video will be resized to fit the desired output resolution(s). Possible values are AutoFit, AutoSize or None. Default to AutoSize.</summary>
    [JsonPropertyName("stretchMode")]
    public string? StretchMode { get; set; }

    /// <summary>Specifies the synchronization mode for the video. Possible values are Auto, Cfr, Passthrough or Vfr. Default to Auto.</summary>
    [JsonPropertyName("syncMode")]
    public string? SyncMode { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetCodecJpgImageLayer
{
    /// <summary>The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("height")]
    public string? Height { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The compression quality of the JPEG output. Range is from 0 to 100 and the default is 70.</summary>
    [JsonPropertyName("quality")]
    public double? Quality { get; set; }

    /// <summary>The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("width")]
    public string? Width { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetCodecJpgImage
{
    /// <summary>The distance between two key frames. The value should be non-zero in the range 0.5 to 20 seconds, specified in ISO 8601 format. Note that this setting is ignored if sync_mode is set to Passthrough, where the KeyFrameInterval value will follow the input source setting. Defaults to PT2S.</summary>
    [JsonPropertyName("keyFrameInterval")]
    public string? KeyFrameInterval { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>One or more layer blocks as defined below.</summary>
    [JsonPropertyName("layer")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetCodecJpgImageLayer>? Layer { get; set; }

    /// <summary>The position relative to transform preset start time in the input video at which to stop generating thumbnails. The value can be in ISO 8601 format (For example, PT5M30S to stop at 5 minutes and 30 seconds from start time), or a frame count (For example, 300 to stop at the 300th frame from the frame at start time. If this value is 1, it means only producing one thumbnail at start time), or a relative value to the stream duration (For example, 50% to stop at half of stream duration from start time). The default value is 100%, which means to stop at the end of the stream.</summary>
    [JsonPropertyName("range")]
    public string? Range { get; set; }

    /// <summary>Sets the number of columns used in thumbnail sprite image. The number of rows are automatically calculated and a VTT file is generated with the coordinate mappings for each thumbnail in the sprite. Note: this value should be a positive integer and a proper value is recommended so that the output image resolution will not go beyond JPEG maximum pixel resolution limit 65535x65535.</summary>
    [JsonPropertyName("spriteColumn")]
    public double? SpriteColumn { get; set; }

    /// <summary>The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }

    /// <summary>The intervals at which thumbnails are generated. The value can be in ISO 8601 format (For example, PT05S for one image every 5 seconds), or a frame count (For example, 30 for one image every 30 frames), or a relative value to stream duration (For example, 10% for one image every 10% of stream duration). Note: Step value will affect the first generated thumbnail, which may not be exactly the one specified at transform preset start time. This is due to the encoder, which tries to select the best thumbnail between start time and Step position from start time as the first output. As the default value is 10%, it means if stream has long duration, the first generated thumbnail might be far away from the one specified at start time. Try to select reasonable value for Step if the first thumbnail is expected close to start time, or set Range value at 1 if only one thumbnail is needed at start time.</summary>
    [JsonPropertyName("step")]
    public string? Step { get; set; }

    /// <summary>The resizing mode, which indicates how the input video will be resized to fit the desired output resolution(s). Possible values are AutoFit, AutoSize or None. Default to AutoSize.</summary>
    [JsonPropertyName("stretchMode")]
    public string? StretchMode { get; set; }

    /// <summary>Specifies the synchronization mode for the video. Possible values are Auto, Cfr, Passthrough or Vfr. Default to Auto.</summary>
    [JsonPropertyName("syncMode")]
    public string? SyncMode { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetCodecPngImageLayer
{
    /// <summary>The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("height")]
    public string? Height { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("width")]
    public string? Width { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetCodecPngImage
{
    /// <summary>The distance between two key frames. The value should be non-zero in the range 0.5 to 20 seconds, specified in ISO 8601 format. Note that this setting is ignored if sync_mode is set to Passthrough, where the KeyFrameInterval value will follow the input source setting. Defaults to PT2S.</summary>
    [JsonPropertyName("keyFrameInterval")]
    public string? KeyFrameInterval { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>One or more layer blocks as defined below.</summary>
    [JsonPropertyName("layer")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetCodecPngImageLayer>? Layer { get; set; }

    /// <summary>The position relative to transform preset start time in the input video at which to stop generating thumbnails. The value can be in ISO 8601 format (For example, PT5M30S to stop at 5 minutes and 30 seconds from start time), or a frame count (For example, 300 to stop at the 300th frame from the frame at start time. If this value is 1, it means only producing one thumbnail at start time), or a relative value to the stream duration (For example, 50% to stop at half of stream duration from start time). The default value is 100%, which means to stop at the end of the stream.</summary>
    [JsonPropertyName("range")]
    public string? Range { get; set; }

    /// <summary>The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }

    /// <summary>The intervals at which thumbnails are generated. The value can be in ISO 8601 format (For example, PT05S for one image every 5 seconds), or a frame count (For example, 30 for one image every 30 frames), or a relative value to stream duration (For example, 10% for one image every 10% of stream duration). Note: Step value will affect the first generated thumbnail, which may not be exactly the one specified at transform preset start time. This is due to the encoder, which tries to select the best thumbnail between start time and Step position from start time as the first output. As the default value is 10%, it means if stream has long duration, the first generated thumbnail might be far away from the one specified at start time. Try to select reasonable value for Step if the first thumbnail is expected close to start time, or set Range value at 1 if only one thumbnail is needed at start time.</summary>
    [JsonPropertyName("step")]
    public string? Step { get; set; }

    /// <summary>The resizing mode, which indicates how the input video will be resized to fit the desired output resolution(s). Possible values are AutoFit, AutoSize or None. Default to AutoSize.</summary>
    [JsonPropertyName("stretchMode")]
    public string? StretchMode { get; set; }

    /// <summary>Specifies the synchronization mode for the video. Possible values are Auto, Cfr, Passthrough or Vfr. Default to Auto.</summary>
    [JsonPropertyName("syncMode")]
    public string? SyncMode { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetCodec
{
    /// <summary>A aac_audio block as defined above.</summary>
    [JsonPropertyName("aacAudio")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetCodecAacAudio>? AacAudio { get; set; }

    /// <summary>A copy_audio block as defined below.</summary>
    [JsonPropertyName("copyAudio")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetCodecCopyAudio>? CopyAudio { get; set; }

    /// <summary>A copy_video block as defined below.</summary>
    [JsonPropertyName("copyVideo")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetCodecCopyVideo>? CopyVideo { get; set; }

    /// <summary>A dd_audio block as defined below.</summary>
    [JsonPropertyName("ddAudio")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetCodecDdAudio>? DdAudio { get; set; }

    /// <summary>A h264_video block as defined below.</summary>
    [JsonPropertyName("h264Video")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetCodecH264Video>? H264Video { get; set; }

    /// <summary>A h265_video block as defined below.</summary>
    [JsonPropertyName("h265Video")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetCodecH265Video>? H265Video { get; set; }

    /// <summary>A jpg_image block as defined below.</summary>
    [JsonPropertyName("jpgImage")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetCodecJpgImage>? JpgImage { get; set; }

    /// <summary>A png_image block as defined below.</summary>
    [JsonPropertyName("pngImage")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetCodecPngImage>? PngImage { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetFilterCropRectangle
{
    /// <summary>The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("height")]
    public string? Height { get; set; }

    /// <summary>The number of pixels from the left-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("left")]
    public string? Left { get; set; }

    /// <summary>The number of pixels from the top-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("top")]
    public string? Top { get; set; }

    /// <summary>The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("width")]
    public string? Width { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetFilterDeinterlace
{
    /// <summary>The deinterlacing mode. Possible values are AutoPixelAdaptive or Off. Default to AutoPixelAdaptive.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The field parity to use for deinterlacing. Possible values are Auto, TopFieldFirst or BottomFieldFirst. Default to Auto.</summary>
    [JsonPropertyName("parity")]
    public string? Parity { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetFilterFadeIn
{
    /// <summary>The duration of the fade effect in the video. The value can be in ISO 8601 format (For example, PT05S to fade In/Out a color during 5 seconds), or a frame count (For example, 10 to fade 10 frames from the start time), or a relative value to stream duration (For example, 10% to fade 10% of stream duration).</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>The color for the fade in/out. It can be on the CSS Level1 colors or an RGB/hex value: e.g: rgb(255,0,0), 0xFF0000 or #FF0000.</summary>
    [JsonPropertyName("fadeColor")]
    public string? FadeColor { get; set; }

    /// <summary>The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetFilterFadeOut
{
    /// <summary>The duration of the fade effect in the video. The value can be in ISO 8601 format (For example, PT05S to fade In/Out a color during 5 seconds), or a frame count (For example, 10 to fade 10 frames from the start time), or a relative value to stream duration (For example, 10% to fade 10% of stream duration).</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>The color for the fade in/out. It can be on the CSS Level1 colors or an RGB/hex value: e.g: rgb(255,0,0), 0xFF0000 or #FF0000.</summary>
    [JsonPropertyName("fadeColor")]
    public string? FadeColor { get; set; }

    /// <summary>The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetFilterOverlayAudio
{
    /// <summary>The gain level of audio in the overlay. The value should be in range between 0 to 1.0. The default is 1.0.</summary>
    [JsonPropertyName("audioGainLevel")]
    public double? AudioGainLevel { get; set; }

    /// <summary>The end position, with reference to the input video, at which the overlay ends. The value should be in ISO 8601 format. For example, PT30S to end the overlay at 30 seconds into the input video. If not specified or the value is greater than the input video duration, the overlay will be applied until the end of the input video if the overlay media duration is greater than the input video duration, else the overlay will last as long as the overlay media duration.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>The duration over which the overlay fades in onto the input video. The value should be in ISO 8601 duration format. If not specified the default behavior is to have no fade in (same as PT0S).</summary>
    [JsonPropertyName("fadeInDuration")]
    public string? FadeInDuration { get; set; }

    /// <summary>The duration over which the overlay fades out of the input video. The value should be in ISO 8601 duration format. If not specified the default behavior is to have no fade out (same as PT0S).</summary>
    [JsonPropertyName("fadeOutDuration")]
    public string? FadeOutDuration { get; set; }

    /// <summary>The label of the job input which is to be used as an overlay. The input must specify exact one file. You can specify an image file in JPG, PNG, GIF or BMP format, or an audio file (such as a WAV, MP3, WMA or M4A file), or a video file.</summary>
    [JsonPropertyName("inputLabel")]
    public string? InputLabel { get; set; }

    /// <summary>The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetFilterOverlayVideoCropRectangle
{
    /// <summary>The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("height")]
    public string? Height { get; set; }

    /// <summary>The number of pixels from the left-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("left")]
    public string? Left { get; set; }

    /// <summary>The number of pixels from the top-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("top")]
    public string? Top { get; set; }

    /// <summary>The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("width")]
    public string? Width { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetFilterOverlayVideoPosition
{
    /// <summary>The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("height")]
    public string? Height { get; set; }

    /// <summary>The number of pixels from the left-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("left")]
    public string? Left { get; set; }

    /// <summary>The number of pixels from the top-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("top")]
    public string? Top { get; set; }

    /// <summary>The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("width")]
    public string? Width { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetFilterOverlayVideo
{
    /// <summary>The gain level of audio in the overlay. The value should be in range between 0 to 1.0. The default is 1.0.</summary>
    [JsonPropertyName("audioGainLevel")]
    public double? AudioGainLevel { get; set; }

    /// <summary>A crop_rectangle block as defined above.</summary>
    [JsonPropertyName("cropRectangle")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetFilterOverlayVideoCropRectangle>? CropRectangle { get; set; }

    /// <summary>The end position, with reference to the input video, at which the overlay ends. The value should be in ISO 8601 format. For example, PT30S to end the overlay at 30 seconds into the input video. If not specified or the value is greater than the input video duration, the overlay will be applied until the end of the input video if the overlay media duration is greater than the input video duration, else the overlay will last as long as the overlay media duration.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>The duration over which the overlay fades in onto the input video. The value should be in ISO 8601 duration format. If not specified the default behavior is to have no fade in (same as PT0S).</summary>
    [JsonPropertyName("fadeInDuration")]
    public string? FadeInDuration { get; set; }

    /// <summary>The duration over which the overlay fades out of the input video. The value should be in ISO 8601 duration format. If not specified the default behavior is to have no fade out (same as PT0S).</summary>
    [JsonPropertyName("fadeOutDuration")]
    public string? FadeOutDuration { get; set; }

    /// <summary>The label of the job input which is to be used as an overlay. The input must specify exact one file. You can specify an image file in JPG, PNG, GIF or BMP format, or an audio file (such as a WAV, MP3, WMA or M4A file), or a video file.</summary>
    [JsonPropertyName("inputLabel")]
    public string? InputLabel { get; set; }

    /// <summary>The opacity of the overlay. The value should be in the range between 0 to 1.0. Default to 1.0, which means the overlay is opaque.</summary>
    [JsonPropertyName("opacity")]
    public double? Opacity { get; set; }

    /// <summary>A position block as defined above.</summary>
    [JsonPropertyName("position")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetFilterOverlayVideoPosition>? Position { get; set; }

    /// <summary>The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetFilterOverlay
{
    /// <summary>An audio block as defined above.</summary>
    [JsonPropertyName("audio")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetFilterOverlayAudio>? Audio { get; set; }

    /// <summary>A video block as defined below.</summary>
    [JsonPropertyName("video")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetFilterOverlayVideo>? Video { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetFilter
{
    /// <summary>A crop_rectangle block as defined above.</summary>
    [JsonPropertyName("cropRectangle")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetFilterCropRectangle>? CropRectangle { get; set; }

    /// <summary>A deinterlace block as defined below.</summary>
    [JsonPropertyName("deinterlace")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetFilterDeinterlace>? Deinterlace { get; set; }

    /// <summary>A fade_in block as defined above.</summary>
    [JsonPropertyName("fadeIn")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetFilterFadeIn>? FadeIn { get; set; }

    /// <summary>A fade_out block as defined above.</summary>
    [JsonPropertyName("fadeOut")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetFilterFadeOut>? FadeOut { get; set; }

    /// <summary>One or more overlay blocks as defined below.</summary>
    [JsonPropertyName("overlay")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetFilterOverlay>? Overlay { get; set; }

    /// <summary>The rotation to be applied to the input video before it is encoded. Possible values are Auto, None, Rotate90, Rotate180, Rotate270,or Rotate0. Default to Auto.</summary>
    [JsonPropertyName("rotation")]
    public string? Rotation { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetFormatJpg
{
    /// <summary>The file naming pattern used for the creation of output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {AudioStream} - string "Audio" plus audio stream number(start from 1). {Bitrate} - The audio/video bitrate in kbps. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename.</summary>
    [JsonPropertyName("filenamePattern")]
    public string? FilenamePattern { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetFormatMp4OutputFile
{
    /// <summary>The list of labels that describe how the encoder should multiplex video and audio into an output file. For example, if the encoder is producing two video layers with labels v1 and v2, and one audio layer with label a1, then an array like ["v1", "a1"] tells the encoder to produce an output file with the video track represented by v1 and the audio track represented by a1.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetFormatMp4
{
    /// <summary>The file naming pattern used for the creation of output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {AudioStream} - string "Audio" plus audio stream number(start from 1). {Bitrate} - The audio/video bitrate in kbps. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename.</summary>
    [JsonPropertyName("filenamePattern")]
    public string? FilenamePattern { get; set; }

    /// <summary>One or more output_file blocks as defined above.</summary>
    [JsonPropertyName("outputFile")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetFormatMp4OutputFile>? OutputFile { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetFormatPng
{
    /// <summary>The file naming pattern used for the creation of output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {AudioStream} - string "Audio" plus audio stream number(start from 1). {Bitrate} - The audio/video bitrate in kbps. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename.</summary>
    [JsonPropertyName("filenamePattern")]
    public string? FilenamePattern { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetFormatTransportStreamOutputFile
{
    /// <summary>The list of labels that describe how the encoder should multiplex video and audio into an output file. For example, if the encoder is producing two video layers with labels v1 and v2, and one audio layer with label a1, then an array like ["v1", "a1"] tells the encoder to produce an output file with the video track represented by v1 and the audio track represented by a1.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetFormatTransportStream
{
    /// <summary>The file naming pattern used for the creation of output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {AudioStream} - string "Audio" plus audio stream number(start from 1). {Bitrate} - The audio/video bitrate in kbps. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename.</summary>
    [JsonPropertyName("filenamePattern")]
    public string? FilenamePattern { get; set; }

    /// <summary>One or more output_file blocks as defined above.</summary>
    [JsonPropertyName("outputFile")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetFormatTransportStreamOutputFile>? OutputFile { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPresetFormat
{
    /// <summary>A jpg block as defined below.</summary>
    [JsonPropertyName("jpg")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetFormatJpg>? Jpg { get; set; }

    /// <summary>A mp4 block as defined below.</summary>
    [JsonPropertyName("mp4")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetFormatMp4>? Mp4 { get; set; }

    /// <summary>A png block as defined below.</summary>
    [JsonPropertyName("png")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetFormatPng>? Png { get; set; }

    /// <summary>A transport_stream block as defined below.</summary>
    [JsonPropertyName("transportStream")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetFormatTransportStream>? TransportStream { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputCustomPreset
{
    /// <summary>One or more codec blocks as defined above.</summary>
    [JsonPropertyName("codec")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetCodec>? Codec { get; set; }

    /// <summary>Dictionary containing key value pairs for parameters not exposed in the preset itself.</summary>
    [JsonPropertyName("experimentalOptions")]
    public IDictionary<string, string>? ExperimentalOptions { get; set; }

    /// <summary>A filter block as defined below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetFilter>? Filter { get; set; }

    /// <summary>One or more format blocks as defined below.</summary>
    [JsonPropertyName("format")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPresetFormat>? Format { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputFaceDetectorPreset
{
    /// <summary>Possible values are SourceResolution or StandardDefinition. Specifies the maximum resolution at which your video is analyzed. which will keep the input video at its original resolution when analyzed. Using StandardDefinition will resize input videos to standard definition while preserving the appropriate aspect ratio. It will only resize if the video is of higher resolution. For example, a 1920x1080 input would be scaled to 640x360 before processing. Switching to StandardDefinition will reduce the time it takes to process high resolution video. It may also reduce the cost of using this component (see https://azure.microsoft.com/en-us/pricing/details/media-services/#analytics for details). However, faces that end up being too small in the resized video may not be detected. Default to SourceResolution.</summary>
    [JsonPropertyName("analysisResolution")]
    public string? AnalysisResolution { get; set; }

    /// <summary>Specifies the type of blur to apply to faces in the output video. Possible values are Black, Box, High, Low,and Med.</summary>
    [JsonPropertyName("blurType")]
    public string? BlurType { get; set; }

    /// <summary>Dictionary containing key value pairs for parameters not exposed in the preset itself.</summary>
    [JsonPropertyName("experimentalOptions")]
    public IDictionary<string, string>? ExperimentalOptions { get; set; }

    /// <summary>This mode provides the ability to choose between the following settings: 1) Analyze - For detection only. This mode generates a metadata JSON file marking appearances of faces throughout the video. Where possible, appearances of the same person are assigned the same ID. 2) Combined - Additionally redacts(blurs) detected faces. 3) Redact - This enables a 2-pass process, allowing for selective redaction of a subset of detected faces. It takes in the metadata file from a prior analyze pass, along with the source video, and a user-selected subset of IDs that require redaction. Default to Analyze.</summary>
    [JsonPropertyName("faceRedactorMode")]
    public string? FaceRedactorMode { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutputVideoAnalyzerPreset
{
    /// <summary>Possible values are Basic or Standard. Determines the set of audio analysis operations to be performed. Default to Standard.</summary>
    [JsonPropertyName("audioAnalysisMode")]
    public string? AudioAnalysisMode { get; set; }

    /// <summary>The language for the audio payload in the input using the BCP-47 format of 'language tag-region' (e.g: 'en-US'). If you know the language of your content, it is recommended that you specify it. The language must be specified explicitly for AudioAnalysisMode:Basic, since automatic language detection is not included in basic mode. If the language isn't specified, automatic language detection will choose the first language detected and process with the selected language for the duration of the file. It does not currently support dynamically switching between languages after the first language is detected. The automatic detection works best with audio recordings with clearly discernible speech. If automatic detection fails to find the language, transcription would fall back to en-US. The list of supported languages is available here: https://go.microsoft.com/fwlink/?linkid=2109463.</summary>
    [JsonPropertyName("audioLanguage")]
    public string? AudioLanguage { get; set; }

    /// <summary>Dictionary containing key value pairs for parameters not exposed in the preset itself.</summary>
    [JsonPropertyName("experimentalOptions")]
    public IDictionary<string, string>? ExperimentalOptions { get; set; }

    /// <summary>Defines the type of insights that you want the service to generate. The allowed values are AudioInsightsOnly, VideoInsightsOnly, and AllInsights. If you set this to AllInsights and the input is audio only, then only audio insights are generated. Similarly, if the input is video only, then only video insights are generated. It is recommended that you not use AudioInsightsOnly if you expect some of your inputs to be video only; or use VideoInsightsOnly if you expect some of your inputs to be audio only. Your Jobs in such conditions would error out. Default to AllInsights.</summary>
    [JsonPropertyName("insightsType")]
    public string? InsightsType { get; set; }
}

public partial class V1beta1TransformSpecInitProviderOutput
{
    /// <summary>An audio_analyzer_preset block as defined above.</summary>
    [JsonPropertyName("audioAnalyzerPreset")]
    public IList<V1beta1TransformSpecInitProviderOutputAudioAnalyzerPreset>? AudioAnalyzerPreset { get; set; }

    /// <summary>A builtin_preset block as defined above.</summary>
    [JsonPropertyName("builtinPreset")]
    public IList<V1beta1TransformSpecInitProviderOutputBuiltinPreset>? BuiltinPreset { get; set; }

    /// <summary>A custom_preset block as defined above.</summary>
    [JsonPropertyName("customPreset")]
    public IList<V1beta1TransformSpecInitProviderOutputCustomPreset>? CustomPreset { get; set; }

    /// <summary>A face_detector_preset block as defined above.</summary>
    [JsonPropertyName("faceDetectorPreset")]
    public IList<V1beta1TransformSpecInitProviderOutputFaceDetectorPreset>? FaceDetectorPreset { get; set; }

    /// <summary>A Transform can define more than one outputs. This property defines what the service should do when one output fails - either continue to produce other outputs, or, stop the other outputs. The overall Job state will not reflect failures of outputs that are specified with ContinueJob. Possible values are StopProcessingJob or ContinueJob. Defaults to StopProcessingJob.</summary>
    [JsonPropertyName("onErrorAction")]
    public string? OnErrorAction { get; set; }

    /// <summary>Sets the relative priority of the TransformOutputs within a Transform. This sets the priority that the service uses for processing Transform Outputs. Possible values are High, Normal or Low. Defaults to Normal.</summary>
    [JsonPropertyName("relativePriority")]
    public string? RelativePriority { get; set; }

    /// <summary>A video_analyzer_preset block as defined below.</summary>
    [JsonPropertyName("videoAnalyzerPreset")]
    public IList<V1beta1TransformSpecInitProviderOutputVideoAnalyzerPreset>? VideoAnalyzerPreset { get; set; }
}

public partial class V1beta1TransformSpecInitProvider
{
    /// <summary>An optional verbose description of the Transform.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more output blocks as defined below. At least one output must be defined.</summary>
    [JsonPropertyName("output")]
    public IList<V1beta1TransformSpecInitProviderOutput>? Output { get; set; }
}

public enum V1beta1TransformSpecManagementPoliciesEnum
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

public enum V1beta1TransformSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransformSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransformSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransformSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1TransformSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransformSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1TransformSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransformSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransformSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1TransformSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TransformSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TransformSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransformSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1TransformSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransformSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1TransformSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TransformSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransformSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1TransformSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1TransformSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1TransformSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1TransformSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1TransformSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1TransformSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TransformSpecDeletionPolicyEnum>))]
    public V1beta1TransformSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TransformSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TransformSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1TransformSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TransformSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1TransformSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TransformSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputAudioAnalyzerPreset
{
    /// <summary>Possible values are Basic or Standard. Determines the set of audio analysis operations to be performed. Default to Standard.</summary>
    [JsonPropertyName("audioAnalysisMode")]
    public string? AudioAnalysisMode { get; set; }

    /// <summary>The language for the audio payload in the input using the BCP-47 format of 'language tag-region' (e.g: 'en-US'). If you know the language of your content, it is recommended that you specify it. The language must be specified explicitly for AudioAnalysisMode:Basic, since automatic language detection is not included in basic mode. If the language isn't specified, automatic language detection will choose the first language detected and process with the selected language for the duration of the file. It does not currently support dynamically switching between languages after the first language is detected. The automatic detection works best with audio recordings with clearly discernible speech. If automatic detection fails to find the language, transcription would fall back to en-US. The list of supported languages is available here: https://go.microsoft.com/fwlink/?linkid=2109463.</summary>
    [JsonPropertyName("audioLanguage")]
    public string? AudioLanguage { get; set; }

    /// <summary>Dictionary containing key value pairs for parameters not exposed in the preset itself.</summary>
    [JsonPropertyName("experimentalOptions")]
    public IDictionary<string, string>? ExperimentalOptions { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputBuiltinPresetPresetConfiguration
{
    /// <summary>The complexity of the encoding. Possible values are Balanced, Speed or Quality.</summary>
    [JsonPropertyName("complexity")]
    public string? Complexity { get; set; }

    /// <summary>Specifies the interleave mode of the output to control how audio are stored in the container format. Possible values are InterleavedOutput and NonInterleavedOutput.</summary>
    [JsonPropertyName("interleaveOutput")]
    public string? InterleaveOutput { get; set; }

    /// <summary>The key frame interval in seconds. Possible value is a positive float. For example, set as 2.0 to reduce the playback buffering for some players.</summary>
    [JsonPropertyName("keyFrameIntervalInSeconds")]
    public double? KeyFrameIntervalInSeconds { get; set; }

    /// <summary>The maximum bitrate in bits per second (threshold for the top video layer). For example, set as 6000000 to avoid producing very high bitrate outputs for contents with high complexity.</summary>
    [JsonPropertyName("maxBitrateBps")]
    public double? MaxBitrateBps { get; set; }

    /// <summary>The maximum height of output video layers. For example, set as 720 to produce output layers up to 720P even if the input is 4K.</summary>
    [JsonPropertyName("maxHeight")]
    public double? MaxHeight { get; set; }

    /// <summary>The maximum number of output video layers. For example, set as 4 to make sure at most 4 output layers are produced to control the overall cost of the encoding job.</summary>
    [JsonPropertyName("maxLayers")]
    public double? MaxLayers { get; set; }

    /// <summary>The minimum bitrate in bits per second (threshold for the bottom video layer). For example, set as 200000 to have a bottom layer that covers users with low network bandwidth.</summary>
    [JsonPropertyName("minBitrateBps")]
    public double? MinBitrateBps { get; set; }

    /// <summary>The minimum height of output video layers. For example, set as 360 to avoid output layers of smaller resolutions like 180P.</summary>
    [JsonPropertyName("minHeight")]
    public double? MinHeight { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputBuiltinPreset
{
    /// <summary>A preset_configuration block as defined below.</summary>
    [JsonPropertyName("presetConfiguration")]
    public IList<V1beta1TransformStatusAtProviderOutputBuiltinPresetPresetConfiguration>? PresetConfiguration { get; set; }

    /// <summary>The built-in preset to be used for encoding videos. The Possible values are AACGoodQualityAudio, AdaptiveStreaming, ContentAwareEncoding, ContentAwareEncodingExperimental, CopyAllBitrateNonInterleaved, DDGoodQualityAudio, H265AdaptiveStreaming, H265ContentAwareEncoding, H265SingleBitrate4K, H265SingleBitrate1080p, H265SingleBitrate720p, H264MultipleBitrate1080p, H264MultipleBitrateSD, H264MultipleBitrate720p, H264SingleBitrate1080p, H264SingleBitrateSD and H264SingleBitrate720p.</summary>
    [JsonPropertyName("presetName")]
    public string? PresetName { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetCodecAacAudio
{
    /// <summary>The average bitrate in bits per second at which to encode the input video when generating this layer.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>The number of audio channels. Default to 2.</summary>
    [JsonPropertyName("channels")]
    public double? Channels { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The H.264 profile. Possible values are Auto, Baseline, High, High422, High444,or Main. Default to Auto.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>The sampling rate to use for encoding in Hertz. Default to 48000.</summary>
    [JsonPropertyName("samplingRate")]
    public double? SamplingRate { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetCodecCopyAudio
{
    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetCodecCopyVideo
{
    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetCodecDdAudio
{
    /// <summary>The average bitrate in bits per second at which to encode the input video when generating this layer.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>The number of audio channels. Default to 2.</summary>
    [JsonPropertyName("channels")]
    public double? Channels { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The sampling rate to use for encoding in Hertz. Default to 48000.</summary>
    [JsonPropertyName("samplingRate")]
    public double? SamplingRate { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetCodecH264VideoLayer
{
    /// <summary>Whether adaptive B-frames are used when encoding this layer. If not specified, the encoder will turn it on whenever the video profile permits its use. Default to true.</summary>
    [JsonPropertyName("adaptiveBFrameEnabled")]
    public bool? AdaptiveBFrameEnabled { get; set; }

    /// <summary>The number of B-frames to use when encoding this layer. If not specified, the encoder chooses an appropriate number based on the video profile and level.</summary>
    [JsonPropertyName("bFrames")]
    public double? BFrames { get; set; }

    /// <summary>The average bitrate in bits per second at which to encode the input video when generating this layer.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Specifies the maximum amount of time that the encoder should buffer frames before encoding. The value should be in ISO 8601 format. The value should be in the range 0.1 to 100 seconds. Defaults to PT5S.</summary>
    [JsonPropertyName("bufferWindow")]
    public string? BufferWindow { get; set; }

    /// <summary>The value of CRF to be used when encoding this layer. This setting takes effect when rate_control_mode is set CRF. The range of CRF value is between 0 and 51, where lower values would result in better quality, at the expense of higher file sizes. Higher values mean more compression, but at some point quality degradation will be noticed. Default to 23.</summary>
    [JsonPropertyName("crf")]
    public double? Crf { get; set; }

    /// <summary>The entropy mode to be used for this layer. Possible values are Cabac or Cavlc. If not specified, the encoder chooses the mode that is appropriate for the profile and level.</summary>
    [JsonPropertyName("entropyMode")]
    public string? EntropyMode { get; set; }

    /// <summary>The frame rate (in frames per second) at which to encode this layer. The value can be in the form of M/N where M and N are integers (For example, 30000/1001), or in the form of a number (For example, 30, or 29.97). The encoder enforces constraints on allowed frame rates based on the profile and level. If it is not specified, the encoder will use the same frame rate as the input video.</summary>
    [JsonPropertyName("frameRate")]
    public string? FrameRate { get; set; }

    /// <summary>The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("height")]
    public string? Height { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The H.264 levels. Currently, the resource support Level up to 6.2. The value can be auto, or a number that matches the H.264 profile. If not specified, the default is auto, which lets the encoder choose the Level that is appropriate for this layer.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>The maximum bitrate (in bits per second), at which the VBV buffer should be assumed to refill. If not specified, defaults to the same value as bitrate.</summary>
    [JsonPropertyName("maxBitrate")]
    public double? MaxBitrate { get; set; }

    /// <summary>The H.264 profile. Possible values are Auto, Baseline, High, High422, High444,or Main. Default to Auto.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>The number of reference frames to be used when encoding this layer. If not specified, the encoder determines an appropriate number based on the encoder complexity setting.</summary>
    [JsonPropertyName("referenceFrames")]
    public double? ReferenceFrames { get; set; }

    /// <summary>The number of slices to be used when encoding this layer. If not specified, default is 1, which means that encoder will use a single slice for each frame.</summary>
    [JsonPropertyName("slices")]
    public double? Slices { get; set; }

    /// <summary>The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("width")]
    public string? Width { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetCodecH264Video
{
    /// <summary>The complexity of the encoding. Possible values are Balanced, Speed or Quality.</summary>
    [JsonPropertyName("complexity")]
    public string? Complexity { get; set; }

    /// <summary>The distance between two key frames. The value should be non-zero in the range 0.5 to 20 seconds, specified in ISO 8601 format. Note that this setting is ignored if sync_mode is set to Passthrough, where the KeyFrameInterval value will follow the input source setting. Defaults to PT2S.</summary>
    [JsonPropertyName("keyFrameInterval")]
    public string? KeyFrameInterval { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>One or more layer blocks as defined below.</summary>
    [JsonPropertyName("layer")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetCodecH264VideoLayer>? Layer { get; set; }

    /// <summary>The rate control mode. Possible values are ABR, CBR or CRF. Default to ABR.</summary>
    [JsonPropertyName("rateControlMode")]
    public string? RateControlMode { get; set; }

    /// <summary>Whether the encoder should insert key frames at scene changes. This flag should be set to true only when the encoder is being configured to produce a single output video. Default to false.</summary>
    [JsonPropertyName("sceneChangeDetectionEnabled")]
    public bool? SceneChangeDetectionEnabled { get; set; }

    /// <summary>The resizing mode, which indicates how the input video will be resized to fit the desired output resolution(s). Possible values are AutoFit, AutoSize or None. Default to AutoSize.</summary>
    [JsonPropertyName("stretchMode")]
    public string? StretchMode { get; set; }

    /// <summary>Specifies the synchronization mode for the video. Possible values are Auto, Cfr, Passthrough or Vfr. Default to Auto.</summary>
    [JsonPropertyName("syncMode")]
    public string? SyncMode { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetCodecH265VideoLayer
{
    /// <summary>Whether adaptive B-frames are used when encoding this layer. If not specified, the encoder will turn it on whenever the video profile permits its use. Default to true.</summary>
    [JsonPropertyName("adaptiveBFrameEnabled")]
    public bool? AdaptiveBFrameEnabled { get; set; }

    /// <summary>The number of B-frames to use when encoding this layer. If not specified, the encoder chooses an appropriate number based on the video profile and level.</summary>
    [JsonPropertyName("bFrames")]
    public double? BFrames { get; set; }

    /// <summary>The average bitrate in bits per second at which to encode the input video when generating this layer.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Specifies the maximum amount of time that the encoder should buffer frames before encoding. The value should be in ISO 8601 format. The value should be in the range 0.1 to 100 seconds. Defaults to PT5S.</summary>
    [JsonPropertyName("bufferWindow")]
    public string? BufferWindow { get; set; }

    /// <summary>The value of CRF to be used when encoding this layer. This setting takes effect when rate_control_mode is set CRF. The range of CRF value is between 0 and 51, where lower values would result in better quality, at the expense of higher file sizes. Higher values mean more compression, but at some point quality degradation will be noticed. Default to 23.</summary>
    [JsonPropertyName("crf")]
    public double? Crf { get; set; }

    /// <summary>The frame rate (in frames per second) at which to encode this layer. The value can be in the form of M/N where M and N are integers (For example, 30000/1001), or in the form of a number (For example, 30, or 29.97). The encoder enforces constraints on allowed frame rates based on the profile and level. If it is not specified, the encoder will use the same frame rate as the input video.</summary>
    [JsonPropertyName("frameRate")]
    public string? FrameRate { get; set; }

    /// <summary>The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("height")]
    public string? Height { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The H.264 levels. Currently, the resource support Level up to 6.2. The value can be auto, or a number that matches the H.264 profile. If not specified, the default is auto, which lets the encoder choose the Level that is appropriate for this layer.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>The maximum bitrate (in bits per second), at which the VBV buffer should be assumed to refill. If not specified, defaults to the same value as bitrate.</summary>
    [JsonPropertyName("maxBitrate")]
    public double? MaxBitrate { get; set; }

    /// <summary>The H.264 profile. Possible values are Auto, Baseline, High, High422, High444,or Main. Default to Auto.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>The number of reference frames to be used when encoding this layer. If not specified, the encoder determines an appropriate number based on the encoder complexity setting.</summary>
    [JsonPropertyName("referenceFrames")]
    public double? ReferenceFrames { get; set; }

    /// <summary>The number of slices to be used when encoding this layer. If not specified, default is 1, which means that encoder will use a single slice for each frame.</summary>
    [JsonPropertyName("slices")]
    public double? Slices { get; set; }

    /// <summary>The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("width")]
    public string? Width { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetCodecH265Video
{
    /// <summary>The complexity of the encoding. Possible values are Balanced, Speed or Quality.</summary>
    [JsonPropertyName("complexity")]
    public string? Complexity { get; set; }

    /// <summary>The distance between two key frames. The value should be non-zero in the range 0.5 to 20 seconds, specified in ISO 8601 format. Note that this setting is ignored if sync_mode is set to Passthrough, where the KeyFrameInterval value will follow the input source setting. Defaults to PT2S.</summary>
    [JsonPropertyName("keyFrameInterval")]
    public string? KeyFrameInterval { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>One or more layer blocks as defined below.</summary>
    [JsonPropertyName("layer")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetCodecH265VideoLayer>? Layer { get; set; }

    /// <summary>Whether the encoder should insert key frames at scene changes. This flag should be set to true only when the encoder is being configured to produce a single output video. Default to false.</summary>
    [JsonPropertyName("sceneChangeDetectionEnabled")]
    public bool? SceneChangeDetectionEnabled { get; set; }

    /// <summary>The resizing mode, which indicates how the input video will be resized to fit the desired output resolution(s). Possible values are AutoFit, AutoSize or None. Default to AutoSize.</summary>
    [JsonPropertyName("stretchMode")]
    public string? StretchMode { get; set; }

    /// <summary>Specifies the synchronization mode for the video. Possible values are Auto, Cfr, Passthrough or Vfr. Default to Auto.</summary>
    [JsonPropertyName("syncMode")]
    public string? SyncMode { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetCodecJpgImageLayer
{
    /// <summary>The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("height")]
    public string? Height { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The compression quality of the JPEG output. Range is from 0 to 100 and the default is 70.</summary>
    [JsonPropertyName("quality")]
    public double? Quality { get; set; }

    /// <summary>The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("width")]
    public string? Width { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetCodecJpgImage
{
    /// <summary>The distance between two key frames. The value should be non-zero in the range 0.5 to 20 seconds, specified in ISO 8601 format. Note that this setting is ignored if sync_mode is set to Passthrough, where the KeyFrameInterval value will follow the input source setting. Defaults to PT2S.</summary>
    [JsonPropertyName("keyFrameInterval")]
    public string? KeyFrameInterval { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>One or more layer blocks as defined below.</summary>
    [JsonPropertyName("layer")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetCodecJpgImageLayer>? Layer { get; set; }

    /// <summary>The position relative to transform preset start time in the input video at which to stop generating thumbnails. The value can be in ISO 8601 format (For example, PT5M30S to stop at 5 minutes and 30 seconds from start time), or a frame count (For example, 300 to stop at the 300th frame from the frame at start time. If this value is 1, it means only producing one thumbnail at start time), or a relative value to the stream duration (For example, 50% to stop at half of stream duration from start time). The default value is 100%, which means to stop at the end of the stream.</summary>
    [JsonPropertyName("range")]
    public string? Range { get; set; }

    /// <summary>Sets the number of columns used in thumbnail sprite image. The number of rows are automatically calculated and a VTT file is generated with the coordinate mappings for each thumbnail in the sprite. Note: this value should be a positive integer and a proper value is recommended so that the output image resolution will not go beyond JPEG maximum pixel resolution limit 65535x65535.</summary>
    [JsonPropertyName("spriteColumn")]
    public double? SpriteColumn { get; set; }

    /// <summary>The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }

    /// <summary>The intervals at which thumbnails are generated. The value can be in ISO 8601 format (For example, PT05S for one image every 5 seconds), or a frame count (For example, 30 for one image every 30 frames), or a relative value to stream duration (For example, 10% for one image every 10% of stream duration). Note: Step value will affect the first generated thumbnail, which may not be exactly the one specified at transform preset start time. This is due to the encoder, which tries to select the best thumbnail between start time and Step position from start time as the first output. As the default value is 10%, it means if stream has long duration, the first generated thumbnail might be far away from the one specified at start time. Try to select reasonable value for Step if the first thumbnail is expected close to start time, or set Range value at 1 if only one thumbnail is needed at start time.</summary>
    [JsonPropertyName("step")]
    public string? Step { get; set; }

    /// <summary>The resizing mode, which indicates how the input video will be resized to fit the desired output resolution(s). Possible values are AutoFit, AutoSize or None. Default to AutoSize.</summary>
    [JsonPropertyName("stretchMode")]
    public string? StretchMode { get; set; }

    /// <summary>Specifies the synchronization mode for the video. Possible values are Auto, Cfr, Passthrough or Vfr. Default to Auto.</summary>
    [JsonPropertyName("syncMode")]
    public string? SyncMode { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetCodecPngImageLayer
{
    /// <summary>The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("height")]
    public string? Height { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("width")]
    public string? Width { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetCodecPngImage
{
    /// <summary>The distance between two key frames. The value should be non-zero in the range 0.5 to 20 seconds, specified in ISO 8601 format. Note that this setting is ignored if sync_mode is set to Passthrough, where the KeyFrameInterval value will follow the input source setting. Defaults to PT2S.</summary>
    [JsonPropertyName("keyFrameInterval")]
    public string? KeyFrameInterval { get; set; }

    /// <summary>Specifies the label for the codec. The label can be used to control muxing behavior.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>One or more layer blocks as defined below.</summary>
    [JsonPropertyName("layer")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetCodecPngImageLayer>? Layer { get; set; }

    /// <summary>The position relative to transform preset start time in the input video at which to stop generating thumbnails. The value can be in ISO 8601 format (For example, PT5M30S to stop at 5 minutes and 30 seconds from start time), or a frame count (For example, 300 to stop at the 300th frame from the frame at start time. If this value is 1, it means only producing one thumbnail at start time), or a relative value to the stream duration (For example, 50% to stop at half of stream duration from start time). The default value is 100%, which means to stop at the end of the stream.</summary>
    [JsonPropertyName("range")]
    public string? Range { get; set; }

    /// <summary>The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }

    /// <summary>The intervals at which thumbnails are generated. The value can be in ISO 8601 format (For example, PT05S for one image every 5 seconds), or a frame count (For example, 30 for one image every 30 frames), or a relative value to stream duration (For example, 10% for one image every 10% of stream duration). Note: Step value will affect the first generated thumbnail, which may not be exactly the one specified at transform preset start time. This is due to the encoder, which tries to select the best thumbnail between start time and Step position from start time as the first output. As the default value is 10%, it means if stream has long duration, the first generated thumbnail might be far away from the one specified at start time. Try to select reasonable value for Step if the first thumbnail is expected close to start time, or set Range value at 1 if only one thumbnail is needed at start time.</summary>
    [JsonPropertyName("step")]
    public string? Step { get; set; }

    /// <summary>The resizing mode, which indicates how the input video will be resized to fit the desired output resolution(s). Possible values are AutoFit, AutoSize or None. Default to AutoSize.</summary>
    [JsonPropertyName("stretchMode")]
    public string? StretchMode { get; set; }

    /// <summary>Specifies the synchronization mode for the video. Possible values are Auto, Cfr, Passthrough or Vfr. Default to Auto.</summary>
    [JsonPropertyName("syncMode")]
    public string? SyncMode { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetCodec
{
    /// <summary>A aac_audio block as defined above.</summary>
    [JsonPropertyName("aacAudio")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetCodecAacAudio>? AacAudio { get; set; }

    /// <summary>A copy_audio block as defined below.</summary>
    [JsonPropertyName("copyAudio")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetCodecCopyAudio>? CopyAudio { get; set; }

    /// <summary>A copy_video block as defined below.</summary>
    [JsonPropertyName("copyVideo")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetCodecCopyVideo>? CopyVideo { get; set; }

    /// <summary>A dd_audio block as defined below.</summary>
    [JsonPropertyName("ddAudio")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetCodecDdAudio>? DdAudio { get; set; }

    /// <summary>A h264_video block as defined below.</summary>
    [JsonPropertyName("h264Video")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetCodecH264Video>? H264Video { get; set; }

    /// <summary>A h265_video block as defined below.</summary>
    [JsonPropertyName("h265Video")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetCodecH265Video>? H265Video { get; set; }

    /// <summary>A jpg_image block as defined below.</summary>
    [JsonPropertyName("jpgImage")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetCodecJpgImage>? JpgImage { get; set; }

    /// <summary>A png_image block as defined below.</summary>
    [JsonPropertyName("pngImage")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetCodecPngImage>? PngImage { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetFilterCropRectangle
{
    /// <summary>The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("height")]
    public string? Height { get; set; }

    /// <summary>The number of pixels from the left-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("left")]
    public string? Left { get; set; }

    /// <summary>The number of pixels from the top-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("top")]
    public string? Top { get; set; }

    /// <summary>The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("width")]
    public string? Width { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetFilterDeinterlace
{
    /// <summary>The deinterlacing mode. Possible values are AutoPixelAdaptive or Off. Default to AutoPixelAdaptive.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The field parity to use for deinterlacing. Possible values are Auto, TopFieldFirst or BottomFieldFirst. Default to Auto.</summary>
    [JsonPropertyName("parity")]
    public string? Parity { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetFilterFadeIn
{
    /// <summary>The duration of the fade effect in the video. The value can be in ISO 8601 format (For example, PT05S to fade In/Out a color during 5 seconds), or a frame count (For example, 10 to fade 10 frames from the start time), or a relative value to stream duration (For example, 10% to fade 10% of stream duration).</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>The color for the fade in/out. It can be on the CSS Level1 colors or an RGB/hex value: e.g: rgb(255,0,0), 0xFF0000 or #FF0000.</summary>
    [JsonPropertyName("fadeColor")]
    public string? FadeColor { get; set; }

    /// <summary>The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetFilterFadeOut
{
    /// <summary>The duration of the fade effect in the video. The value can be in ISO 8601 format (For example, PT05S to fade In/Out a color during 5 seconds), or a frame count (For example, 10 to fade 10 frames from the start time), or a relative value to stream duration (For example, 10% to fade 10% of stream duration).</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>The color for the fade in/out. It can be on the CSS Level1 colors or an RGB/hex value: e.g: rgb(255,0,0), 0xFF0000 or #FF0000.</summary>
    [JsonPropertyName("fadeColor")]
    public string? FadeColor { get; set; }

    /// <summary>The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetFilterOverlayAudio
{
    /// <summary>The gain level of audio in the overlay. The value should be in range between 0 to 1.0. The default is 1.0.</summary>
    [JsonPropertyName("audioGainLevel")]
    public double? AudioGainLevel { get; set; }

    /// <summary>The end position, with reference to the input video, at which the overlay ends. The value should be in ISO 8601 format. For example, PT30S to end the overlay at 30 seconds into the input video. If not specified or the value is greater than the input video duration, the overlay will be applied until the end of the input video if the overlay media duration is greater than the input video duration, else the overlay will last as long as the overlay media duration.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>The duration over which the overlay fades in onto the input video. The value should be in ISO 8601 duration format. If not specified the default behavior is to have no fade in (same as PT0S).</summary>
    [JsonPropertyName("fadeInDuration")]
    public string? FadeInDuration { get; set; }

    /// <summary>The duration over which the overlay fades out of the input video. The value should be in ISO 8601 duration format. If not specified the default behavior is to have no fade out (same as PT0S).</summary>
    [JsonPropertyName("fadeOutDuration")]
    public string? FadeOutDuration { get; set; }

    /// <summary>The label of the job input which is to be used as an overlay. The input must specify exact one file. You can specify an image file in JPG, PNG, GIF or BMP format, or an audio file (such as a WAV, MP3, WMA or M4A file), or a video file.</summary>
    [JsonPropertyName("inputLabel")]
    public string? InputLabel { get; set; }

    /// <summary>The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetFilterOverlayVideoCropRectangle
{
    /// <summary>The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("height")]
    public string? Height { get; set; }

    /// <summary>The number of pixels from the left-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("left")]
    public string? Left { get; set; }

    /// <summary>The number of pixels from the top-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("top")]
    public string? Top { get; set; }

    /// <summary>The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("width")]
    public string? Width { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetFilterOverlayVideoPosition
{
    /// <summary>The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("height")]
    public string? Height { get; set; }

    /// <summary>The number of pixels from the left-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("left")]
    public string? Left { get; set; }

    /// <summary>The number of pixels from the top-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("top")]
    public string? Top { get; set; }

    /// <summary>The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%).</summary>
    [JsonPropertyName("width")]
    public string? Width { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetFilterOverlayVideo
{
    /// <summary>The gain level of audio in the overlay. The value should be in range between 0 to 1.0. The default is 1.0.</summary>
    [JsonPropertyName("audioGainLevel")]
    public double? AudioGainLevel { get; set; }

    /// <summary>A crop_rectangle block as defined above.</summary>
    [JsonPropertyName("cropRectangle")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetFilterOverlayVideoCropRectangle>? CropRectangle { get; set; }

    /// <summary>The end position, with reference to the input video, at which the overlay ends. The value should be in ISO 8601 format. For example, PT30S to end the overlay at 30 seconds into the input video. If not specified or the value is greater than the input video duration, the overlay will be applied until the end of the input video if the overlay media duration is greater than the input video duration, else the overlay will last as long as the overlay media duration.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>The duration over which the overlay fades in onto the input video. The value should be in ISO 8601 duration format. If not specified the default behavior is to have no fade in (same as PT0S).</summary>
    [JsonPropertyName("fadeInDuration")]
    public string? FadeInDuration { get; set; }

    /// <summary>The duration over which the overlay fades out of the input video. The value should be in ISO 8601 duration format. If not specified the default behavior is to have no fade out (same as PT0S).</summary>
    [JsonPropertyName("fadeOutDuration")]
    public string? FadeOutDuration { get; set; }

    /// <summary>The label of the job input which is to be used as an overlay. The input must specify exact one file. You can specify an image file in JPG, PNG, GIF or BMP format, or an audio file (such as a WAV, MP3, WMA or M4A file), or a video file.</summary>
    [JsonPropertyName("inputLabel")]
    public string? InputLabel { get; set; }

    /// <summary>The opacity of the overlay. The value should be in the range between 0 to 1.0. Default to 1.0, which means the overlay is opaque.</summary>
    [JsonPropertyName("opacity")]
    public double? Opacity { get; set; }

    /// <summary>A position block as defined above.</summary>
    [JsonPropertyName("position")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetFilterOverlayVideoPosition>? Position { get; set; }

    /// <summary>The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetFilterOverlay
{
    /// <summary>An audio block as defined above.</summary>
    [JsonPropertyName("audio")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetFilterOverlayAudio>? Audio { get; set; }

    /// <summary>A video block as defined below.</summary>
    [JsonPropertyName("video")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetFilterOverlayVideo>? Video { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetFilter
{
    /// <summary>A crop_rectangle block as defined above.</summary>
    [JsonPropertyName("cropRectangle")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetFilterCropRectangle>? CropRectangle { get; set; }

    /// <summary>A deinterlace block as defined below.</summary>
    [JsonPropertyName("deinterlace")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetFilterDeinterlace>? Deinterlace { get; set; }

    /// <summary>A fade_in block as defined above.</summary>
    [JsonPropertyName("fadeIn")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetFilterFadeIn>? FadeIn { get; set; }

    /// <summary>A fade_out block as defined above.</summary>
    [JsonPropertyName("fadeOut")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetFilterFadeOut>? FadeOut { get; set; }

    /// <summary>One or more overlay blocks as defined below.</summary>
    [JsonPropertyName("overlay")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetFilterOverlay>? Overlay { get; set; }

    /// <summary>The rotation to be applied to the input video before it is encoded. Possible values are Auto, None, Rotate90, Rotate180, Rotate270,or Rotate0. Default to Auto.</summary>
    [JsonPropertyName("rotation")]
    public string? Rotation { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetFormatJpg
{
    /// <summary>The file naming pattern used for the creation of output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {AudioStream} - string "Audio" plus audio stream number(start from 1). {Bitrate} - The audio/video bitrate in kbps. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename.</summary>
    [JsonPropertyName("filenamePattern")]
    public string? FilenamePattern { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetFormatMp4OutputFile
{
    /// <summary>The list of labels that describe how the encoder should multiplex video and audio into an output file. For example, if the encoder is producing two video layers with labels v1 and v2, and one audio layer with label a1, then an array like ["v1", "a1"] tells the encoder to produce an output file with the video track represented by v1 and the audio track represented by a1.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetFormatMp4
{
    /// <summary>The file naming pattern used for the creation of output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {AudioStream} - string "Audio" plus audio stream number(start from 1). {Bitrate} - The audio/video bitrate in kbps. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename.</summary>
    [JsonPropertyName("filenamePattern")]
    public string? FilenamePattern { get; set; }

    /// <summary>One or more output_file blocks as defined above.</summary>
    [JsonPropertyName("outputFile")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetFormatMp4OutputFile>? OutputFile { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetFormatPng
{
    /// <summary>The file naming pattern used for the creation of output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {AudioStream} - string "Audio" plus audio stream number(start from 1). {Bitrate} - The audio/video bitrate in kbps. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename.</summary>
    [JsonPropertyName("filenamePattern")]
    public string? FilenamePattern { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetFormatTransportStreamOutputFile
{
    /// <summary>The list of labels that describe how the encoder should multiplex video and audio into an output file. For example, if the encoder is producing two video layers with labels v1 and v2, and one audio layer with label a1, then an array like ["v1", "a1"] tells the encoder to produce an output file with the video track represented by v1 and the audio track represented by a1.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetFormatTransportStream
{
    /// <summary>The file naming pattern used for the creation of output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {AudioStream} - string "Audio" plus audio stream number(start from 1). {Bitrate} - The audio/video bitrate in kbps. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename.</summary>
    [JsonPropertyName("filenamePattern")]
    public string? FilenamePattern { get; set; }

    /// <summary>One or more output_file blocks as defined above.</summary>
    [JsonPropertyName("outputFile")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetFormatTransportStreamOutputFile>? OutputFile { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPresetFormat
{
    /// <summary>A jpg block as defined below.</summary>
    [JsonPropertyName("jpg")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetFormatJpg>? Jpg { get; set; }

    /// <summary>A mp4 block as defined below.</summary>
    [JsonPropertyName("mp4")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetFormatMp4>? Mp4 { get; set; }

    /// <summary>A png block as defined below.</summary>
    [JsonPropertyName("png")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetFormatPng>? Png { get; set; }

    /// <summary>A transport_stream block as defined below.</summary>
    [JsonPropertyName("transportStream")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetFormatTransportStream>? TransportStream { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputCustomPreset
{
    /// <summary>One or more codec blocks as defined above.</summary>
    [JsonPropertyName("codec")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetCodec>? Codec { get; set; }

    /// <summary>Dictionary containing key value pairs for parameters not exposed in the preset itself.</summary>
    [JsonPropertyName("experimentalOptions")]
    public IDictionary<string, string>? ExperimentalOptions { get; set; }

    /// <summary>A filter block as defined below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetFilter>? Filter { get; set; }

    /// <summary>One or more format blocks as defined below.</summary>
    [JsonPropertyName("format")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPresetFormat>? Format { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputFaceDetectorPreset
{
    /// <summary>Possible values are SourceResolution or StandardDefinition. Specifies the maximum resolution at which your video is analyzed. which will keep the input video at its original resolution when analyzed. Using StandardDefinition will resize input videos to standard definition while preserving the appropriate aspect ratio. It will only resize if the video is of higher resolution. For example, a 1920x1080 input would be scaled to 640x360 before processing. Switching to StandardDefinition will reduce the time it takes to process high resolution video. It may also reduce the cost of using this component (see https://azure.microsoft.com/en-us/pricing/details/media-services/#analytics for details). However, faces that end up being too small in the resized video may not be detected. Default to SourceResolution.</summary>
    [JsonPropertyName("analysisResolution")]
    public string? AnalysisResolution { get; set; }

    /// <summary>Specifies the type of blur to apply to faces in the output video. Possible values are Black, Box, High, Low,and Med.</summary>
    [JsonPropertyName("blurType")]
    public string? BlurType { get; set; }

    /// <summary>Dictionary containing key value pairs for parameters not exposed in the preset itself.</summary>
    [JsonPropertyName("experimentalOptions")]
    public IDictionary<string, string>? ExperimentalOptions { get; set; }

    /// <summary>This mode provides the ability to choose between the following settings: 1) Analyze - For detection only. This mode generates a metadata JSON file marking appearances of faces throughout the video. Where possible, appearances of the same person are assigned the same ID. 2) Combined - Additionally redacts(blurs) detected faces. 3) Redact - This enables a 2-pass process, allowing for selective redaction of a subset of detected faces. It takes in the metadata file from a prior analyze pass, along with the source video, and a user-selected subset of IDs that require redaction. Default to Analyze.</summary>
    [JsonPropertyName("faceRedactorMode")]
    public string? FaceRedactorMode { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutputVideoAnalyzerPreset
{
    /// <summary>Possible values are Basic or Standard. Determines the set of audio analysis operations to be performed. Default to Standard.</summary>
    [JsonPropertyName("audioAnalysisMode")]
    public string? AudioAnalysisMode { get; set; }

    /// <summary>The language for the audio payload in the input using the BCP-47 format of 'language tag-region' (e.g: 'en-US'). If you know the language of your content, it is recommended that you specify it. The language must be specified explicitly for AudioAnalysisMode:Basic, since automatic language detection is not included in basic mode. If the language isn't specified, automatic language detection will choose the first language detected and process with the selected language for the duration of the file. It does not currently support dynamically switching between languages after the first language is detected. The automatic detection works best with audio recordings with clearly discernible speech. If automatic detection fails to find the language, transcription would fall back to en-US. The list of supported languages is available here: https://go.microsoft.com/fwlink/?linkid=2109463.</summary>
    [JsonPropertyName("audioLanguage")]
    public string? AudioLanguage { get; set; }

    /// <summary>Dictionary containing key value pairs for parameters not exposed in the preset itself.</summary>
    [JsonPropertyName("experimentalOptions")]
    public IDictionary<string, string>? ExperimentalOptions { get; set; }

    /// <summary>Defines the type of insights that you want the service to generate. The allowed values are AudioInsightsOnly, VideoInsightsOnly, and AllInsights. If you set this to AllInsights and the input is audio only, then only audio insights are generated. Similarly, if the input is video only, then only video insights are generated. It is recommended that you not use AudioInsightsOnly if you expect some of your inputs to be video only; or use VideoInsightsOnly if you expect some of your inputs to be audio only. Your Jobs in such conditions would error out. Default to AllInsights.</summary>
    [JsonPropertyName("insightsType")]
    public string? InsightsType { get; set; }
}

public partial class V1beta1TransformStatusAtProviderOutput
{
    /// <summary>An audio_analyzer_preset block as defined above.</summary>
    [JsonPropertyName("audioAnalyzerPreset")]
    public IList<V1beta1TransformStatusAtProviderOutputAudioAnalyzerPreset>? AudioAnalyzerPreset { get; set; }

    /// <summary>A builtin_preset block as defined above.</summary>
    [JsonPropertyName("builtinPreset")]
    public IList<V1beta1TransformStatusAtProviderOutputBuiltinPreset>? BuiltinPreset { get; set; }

    /// <summary>A custom_preset block as defined above.</summary>
    [JsonPropertyName("customPreset")]
    public IList<V1beta1TransformStatusAtProviderOutputCustomPreset>? CustomPreset { get; set; }

    /// <summary>A face_detector_preset block as defined above.</summary>
    [JsonPropertyName("faceDetectorPreset")]
    public IList<V1beta1TransformStatusAtProviderOutputFaceDetectorPreset>? FaceDetectorPreset { get; set; }

    /// <summary>A Transform can define more than one outputs. This property defines what the service should do when one output fails - either continue to produce other outputs, or, stop the other outputs. The overall Job state will not reflect failures of outputs that are specified with ContinueJob. Possible values are StopProcessingJob or ContinueJob. Defaults to StopProcessingJob.</summary>
    [JsonPropertyName("onErrorAction")]
    public string? OnErrorAction { get; set; }

    /// <summary>Sets the relative priority of the TransformOutputs within a Transform. This sets the priority that the service uses for processing Transform Outputs. Possible values are High, Normal or Low. Defaults to Normal.</summary>
    [JsonPropertyName("relativePriority")]
    public string? RelativePriority { get; set; }

    /// <summary>A video_analyzer_preset block as defined below.</summary>
    [JsonPropertyName("videoAnalyzerPreset")]
    public IList<V1beta1TransformStatusAtProviderOutputVideoAnalyzerPreset>? VideoAnalyzerPreset { get; set; }
}

public partial class V1beta1TransformStatusAtProvider
{
    /// <summary>An optional verbose description of the Transform.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of the Transform.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Media Services account name. Changing this forces a new Transform to be created.</summary>
    [JsonPropertyName("mediaServicesAccountName")]
    public string? MediaServicesAccountName { get; set; }

    /// <summary>One or more output blocks as defined below. At least one output must be defined.</summary>
    [JsonPropertyName("output")]
    public IList<V1beta1TransformStatusAtProviderOutput>? Output { get; set; }

    /// <summary>The name of the Resource Group where the Transform should exist. Changing this forces a new Transform to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }
}

public partial class V1beta1TransformStatusConditions
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

public partial class V1beta1TransformStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TransformStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TransformStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Transform : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TransformSpec>, IStatus<V1beta1TransformStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Transform";
    public const string KubeGroup = "media.azure.upbound.io";
    public const string KubePluralName = "transforms";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TransformSpec defines the desired state of Transform</summary>
    [JsonPropertyName("spec")]
    public V1beta1TransformSpec Spec { get; set; }

    /// <summary>TransformStatus defines the observed state of Transform.</summary>
    [JsonPropertyName("status")]
    public V1beta1TransformStatus? Status { get; set; }
}