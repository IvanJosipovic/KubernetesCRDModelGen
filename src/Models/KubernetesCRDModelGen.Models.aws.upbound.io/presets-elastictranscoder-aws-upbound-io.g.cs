using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.elastictranscoder.aws.upbound.io;
/// <summary>Preset is the Schema for the Presets API. Provides an Elastic Transcoder preset resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PresetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Preset>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PresetList";
    public const string KubeGroup = "elastictranscoder.aws.upbound.io";
    public const string KubePluralName = "presets";
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
    public IList<V1beta1Preset> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetSpecForProviderAudio
{
    /// <summary>The method of organizing audio channels and tracks. Use Audio:Channels to specify the number of channels in your output, and Audio:AudioPackingMode to specify the number of tracks and their relation to the channels. If you do not specify an Audio:AudioPackingMode, Elastic Transcoder uses SingleTrack.</summary>
    [JsonPropertyName("audioPackingMode")]
    public string? AudioPackingMode { get; set; }

    /// <summary>The bit rate of the audio stream in the output file, in kilobits/second. Enter an integer between 64 and 320, inclusive.</summary>
    [JsonPropertyName("bitRate")]
    public string? BitRate { get; set; }

    /// <summary>The number of audio channels in the output file</summary>
    [JsonPropertyName("channels")]
    public string? Channels { get; set; }

    /// <summary>The audio codec for the output file. Valid values are AAC, flac, mp2, mp3, pcm, and vorbis.</summary>
    [JsonPropertyName("codec")]
    public string? Codec { get; set; }

    /// <summary>The sample rate of the audio stream in the output file, in hertz. Valid values are: auto, 22050, 32000, 44100, 48000, 96000</summary>
    [JsonPropertyName("sampleRate")]
    public string? SampleRate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetSpecForProviderAudioCodecOptions
{
    /// <summary>The bit depth of a sample is how many bits of information are included in the audio samples. Valid values are 16 and 24. (FLAC/PCM Only)</summary>
    [JsonPropertyName("bitDepth")]
    public string? BitDepth { get; set; }

    /// <summary>The order the bits of a PCM sample are stored in. The supported value is LittleEndian. (PCM Only)</summary>
    [JsonPropertyName("bitOrder")]
    public string? BitOrder { get; set; }

    /// <summary>If you specified AAC for Audio:Codec, choose the AAC profile for the output file.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>Whether audio samples are represented with negative and positive numbers (signed) or only positive numbers (unsigned). The supported value is Signed. (PCM Only)</summary>
    [JsonPropertyName("signed")]
    public string? Signed { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetSpecForProviderThumbnails
{
    /// <summary>The aspect ratio of thumbnails. The following values are valid: auto, 1:1, 4:3, 3:2, 16:9</summary>
    [JsonPropertyName("aspectRatio")]
    public string? AspectRatio { get; set; }

    /// <summary>The format of thumbnails, if any. Valid formats are jpg and png.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The approximate number of seconds between thumbnails. The value must be an integer. The actual interval can vary by several seconds from one thumbnail to the next.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>The maximum height of thumbnails, in pixels. If you specify auto, Elastic Transcoder uses 1080 (Full HD) as the default value. If you specify a numeric value, enter an even integer between 32 and 3072, inclusive.</summary>
    [JsonPropertyName("maxHeight")]
    public string? MaxHeight { get; set; }

    /// <summary>The maximum width of thumbnails, in pixels. If you specify auto, Elastic Transcoder uses 1920 (Full HD) as the default value. If you specify a numeric value, enter an even integer between 32 and 4096, inclusive.</summary>
    [JsonPropertyName("maxWidth")]
    public string? MaxWidth { get; set; }

    /// <summary>When you set PaddingPolicy to Pad, Elastic Transcoder might add black bars to the top and bottom and/or left and right sides of thumbnails to make the total size of the thumbnails match the values that you specified for thumbnail MaxWidth and MaxHeight settings.</summary>
    [JsonPropertyName("paddingPolicy")]
    public string? PaddingPolicy { get; set; }

    /// <summary>The width and height of thumbnail files in pixels, in the format WidthxHeight, where both values are even integers. The values cannot exceed the width and height that you specified in the Video:Resolution object. (To better control resolution and aspect ratio of thumbnails, we recommend that you use the thumbnail values max_width, max_height, sizing_policy, and padding_policy instead of resolution and aspect_ratio. The two groups of settings are mutually exclusive. Do not use them together)</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>A value that controls scaling of thumbnails. Valid values are: Fit, Fill, Stretch, Keep, ShrinkToFit, and ShrinkToFill.</summary>
    [JsonPropertyName("sizingPolicy")]
    public string? SizingPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetSpecForProviderVideo
{
    /// <summary>The aspect ratio of thumbnails. The following values are valid: auto, 1:1, 4:3, 3:2, 16:9</summary>
    [JsonPropertyName("aspectRatio")]
    public string? AspectRatio { get; set; }

    /// <summary>The bit rate of the audio stream in the output file, in kilobits/second. Enter an integer between 64 and 320, inclusive.</summary>
    [JsonPropertyName("bitRate")]
    public string? BitRate { get; set; }

    /// <summary>The audio codec for the output file. Valid values are AAC, flac, mp2, mp3, pcm, and vorbis.</summary>
    [JsonPropertyName("codec")]
    public string? Codec { get; set; }

    /// <summary>The value that Elastic Transcoder adds to the metadata in the output file. If you set DisplayAspectRatio to auto, Elastic Transcoder chooses an aspect ratio that ensures square pixels. If you specify another option, Elastic Transcoder sets that value in the output file.</summary>
    [JsonPropertyName("displayAspectRatio")]
    public string? DisplayAspectRatio { get; set; }

    /// <summary>Whether to use a fixed value for Video:FixedGOP. Not applicable for containers of type gif. Valid values are true and false. Also known as, Fixed Number of Frames Between Keyframes.</summary>
    [JsonPropertyName("fixedGop")]
    public string? FixedGop { get; set; }

    /// <summary>The frames per second for the video stream in the output file. The following values are valid: auto, 10, 15, 23.97, 24, 25, 29.97, 30, 50, 60.</summary>
    [JsonPropertyName("frameRate")]
    public string? FrameRate { get; set; }

    /// <summary>The maximum number of frames between key frames. Not applicable for containers of type gif.</summary>
    [JsonPropertyName("keyframesMaxDist")]
    public string? KeyframesMaxDist { get; set; }

    /// <summary>If you specify auto for FrameRate, Elastic Transcoder uses the frame rate of the input video for the frame rate of the output video, up to the maximum frame rate. If you do not specify a MaxFrameRate, Elastic Transcoder will use a default of 30.</summary>
    [JsonPropertyName("maxFrameRate")]
    public string? MaxFrameRate { get; set; }

    /// <summary>The maximum height of thumbnails, in pixels. If you specify auto, Elastic Transcoder uses 1080 (Full HD) as the default value. If you specify a numeric value, enter an even integer between 32 and 3072, inclusive.</summary>
    [JsonPropertyName("maxHeight")]
    public string? MaxHeight { get; set; }

    /// <summary>The maximum width of thumbnails, in pixels. If you specify auto, Elastic Transcoder uses 1920 (Full HD) as the default value. If you specify a numeric value, enter an even integer between 32 and 4096, inclusive.</summary>
    [JsonPropertyName("maxWidth")]
    public string? MaxWidth { get; set; }

    /// <summary>When you set PaddingPolicy to Pad, Elastic Transcoder might add black bars to the top and bottom and/or left and right sides of thumbnails to make the total size of the thumbnails match the values that you specified for thumbnail MaxWidth and MaxHeight settings.</summary>
    [JsonPropertyName("paddingPolicy")]
    public string? PaddingPolicy { get; set; }

    /// <summary>The width and height of thumbnail files in pixels, in the format WidthxHeight, where both values are even integers. The values cannot exceed the width and height that you specified in the Video:Resolution object. (To better control resolution and aspect ratio of thumbnails, we recommend that you use the thumbnail values max_width, max_height, sizing_policy, and padding_policy instead of resolution and aspect_ratio. The two groups of settings are mutually exclusive. Do not use them together)</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>A value that controls scaling of thumbnails. Valid values are: Fit, Fill, Stretch, Keep, ShrinkToFit, and ShrinkToFill.</summary>
    [JsonPropertyName("sizingPolicy")]
    public string? SizingPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetSpecForProviderVideoWatermarks
{
    /// <summary>The horizontal position of the watermark unless you specify a nonzero value for horzontal_offset.</summary>
    [JsonPropertyName("horizontalAlign")]
    public string? HorizontalAlign { get; set; }

    /// <summary>The amount by which you want the horizontal position of the watermark to be offset from the position specified by horizontal_align.</summary>
    [JsonPropertyName("horizontalOffset")]
    public string? HorizontalOffset { get; set; }

    /// <summary>A unique identifier for the settings for one watermark. The value of Id can be up to 40 characters long. You can specify settings for up to four watermarks.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The maximum height of thumbnails, in pixels. If you specify auto, Elastic Transcoder uses 1080 (Full HD) as the default value. If you specify a numeric value, enter an even integer between 32 and 3072, inclusive.</summary>
    [JsonPropertyName("maxHeight")]
    public string? MaxHeight { get; set; }

    /// <summary>The maximum width of thumbnails, in pixels. If you specify auto, Elastic Transcoder uses 1920 (Full HD) as the default value. If you specify a numeric value, enter an even integer between 32 and 4096, inclusive.</summary>
    [JsonPropertyName("maxWidth")]
    public string? MaxWidth { get; set; }

    /// <summary>A percentage that indicates how much you want a watermark to obscure the video in the location where it appears.</summary>
    [JsonPropertyName("opacity")]
    public string? Opacity { get; set; }

    /// <summary>A value that controls scaling of thumbnails. Valid values are: Fit, Fill, Stretch, Keep, ShrinkToFit, and ShrinkToFill.</summary>
    [JsonPropertyName("sizingPolicy")]
    public string? SizingPolicy { get; set; }

    /// <summary>A value that determines how Elastic Transcoder interprets values that you specified for video_watermarks.horizontal_offset, video_watermarks.vertical_offset, video_watermarks.max_width, and video_watermarks.max_height. Valid values are Content and Frame.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>The vertical position of the watermark unless you specify a nonzero value for vertical_align. Valid values are Top, Bottom, Center.</summary>
    [JsonPropertyName("verticalAlign")]
    public string? VerticalAlign { get; set; }

    /// <summary>The amount by which you want the vertical position of the watermark to be offset from the position specified by vertical_align</summary>
    [JsonPropertyName("verticalOffset")]
    public string? VerticalOffset { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetSpecForProvider
{
    /// <summary>Audio parameters object (documented below).</summary>
    [JsonPropertyName("audio")]
    public IList<V1beta1PresetSpecForProviderAudio>? Audio { get; set; }

    /// <summary>Codec options for the audio parameters (documented below)</summary>
    [JsonPropertyName("audioCodecOptions")]
    public IList<V1beta1PresetSpecForProviderAudioCodecOptions>? AudioCodecOptions { get; set; }

    /// <summary>The container type for the output file. Valid values are flac, flv, fmp4, gif, mp3, mp4, mpg, mxf, oga, ogg, ts, and webm.</summary>
    [JsonPropertyName("container")]
    public string? Container { get; set; }

    /// <summary>A description of the preset (maximum 255 characters)</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the preset. (maximum 40 characters)</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Thumbnail parameters object (documented below)</summary>
    [JsonPropertyName("thumbnails")]
    public IList<V1beta1PresetSpecForProviderThumbnails>? Thumbnails { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Video parameters object (documented below)</summary>
    [JsonPropertyName("video")]
    public IList<V1beta1PresetSpecForProviderVideo>? Video { get; set; }

    /// <summary>Codec options for the video parameters</summary>
    [JsonPropertyName("videoCodecOptions")]
    public IDictionary<string, string>? VideoCodecOptions { get; set; }

    /// <summary>Watermark parameters for the video parameters (documented below)</summary>
    [JsonPropertyName("videoWatermarks")]
    public IList<V1beta1PresetSpecForProviderVideoWatermarks>? VideoWatermarks { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetSpecInitProviderAudio
{
    /// <summary>The method of organizing audio channels and tracks. Use Audio:Channels to specify the number of channels in your output, and Audio:AudioPackingMode to specify the number of tracks and their relation to the channels. If you do not specify an Audio:AudioPackingMode, Elastic Transcoder uses SingleTrack.</summary>
    [JsonPropertyName("audioPackingMode")]
    public string? AudioPackingMode { get; set; }

    /// <summary>The bit rate of the audio stream in the output file, in kilobits/second. Enter an integer between 64 and 320, inclusive.</summary>
    [JsonPropertyName("bitRate")]
    public string? BitRate { get; set; }

    /// <summary>The number of audio channels in the output file</summary>
    [JsonPropertyName("channels")]
    public string? Channels { get; set; }

    /// <summary>The audio codec for the output file. Valid values are AAC, flac, mp2, mp3, pcm, and vorbis.</summary>
    [JsonPropertyName("codec")]
    public string? Codec { get; set; }

    /// <summary>The sample rate of the audio stream in the output file, in hertz. Valid values are: auto, 22050, 32000, 44100, 48000, 96000</summary>
    [JsonPropertyName("sampleRate")]
    public string? SampleRate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetSpecInitProviderAudioCodecOptions
{
    /// <summary>The bit depth of a sample is how many bits of information are included in the audio samples. Valid values are 16 and 24. (FLAC/PCM Only)</summary>
    [JsonPropertyName("bitDepth")]
    public string? BitDepth { get; set; }

    /// <summary>The order the bits of a PCM sample are stored in. The supported value is LittleEndian. (PCM Only)</summary>
    [JsonPropertyName("bitOrder")]
    public string? BitOrder { get; set; }

    /// <summary>If you specified AAC for Audio:Codec, choose the AAC profile for the output file.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>Whether audio samples are represented with negative and positive numbers (signed) or only positive numbers (unsigned). The supported value is Signed. (PCM Only)</summary>
    [JsonPropertyName("signed")]
    public string? Signed { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetSpecInitProviderThumbnails
{
    /// <summary>The aspect ratio of thumbnails. The following values are valid: auto, 1:1, 4:3, 3:2, 16:9</summary>
    [JsonPropertyName("aspectRatio")]
    public string? AspectRatio { get; set; }

    /// <summary>The format of thumbnails, if any. Valid formats are jpg and png.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The approximate number of seconds between thumbnails. The value must be an integer. The actual interval can vary by several seconds from one thumbnail to the next.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>The maximum height of thumbnails, in pixels. If you specify auto, Elastic Transcoder uses 1080 (Full HD) as the default value. If you specify a numeric value, enter an even integer between 32 and 3072, inclusive.</summary>
    [JsonPropertyName("maxHeight")]
    public string? MaxHeight { get; set; }

    /// <summary>The maximum width of thumbnails, in pixels. If you specify auto, Elastic Transcoder uses 1920 (Full HD) as the default value. If you specify a numeric value, enter an even integer between 32 and 4096, inclusive.</summary>
    [JsonPropertyName("maxWidth")]
    public string? MaxWidth { get; set; }

    /// <summary>When you set PaddingPolicy to Pad, Elastic Transcoder might add black bars to the top and bottom and/or left and right sides of thumbnails to make the total size of the thumbnails match the values that you specified for thumbnail MaxWidth and MaxHeight settings.</summary>
    [JsonPropertyName("paddingPolicy")]
    public string? PaddingPolicy { get; set; }

    /// <summary>The width and height of thumbnail files in pixels, in the format WidthxHeight, where both values are even integers. The values cannot exceed the width and height that you specified in the Video:Resolution object. (To better control resolution and aspect ratio of thumbnails, we recommend that you use the thumbnail values max_width, max_height, sizing_policy, and padding_policy instead of resolution and aspect_ratio. The two groups of settings are mutually exclusive. Do not use them together)</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>A value that controls scaling of thumbnails. Valid values are: Fit, Fill, Stretch, Keep, ShrinkToFit, and ShrinkToFill.</summary>
    [JsonPropertyName("sizingPolicy")]
    public string? SizingPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetSpecInitProviderVideo
{
    /// <summary>The aspect ratio of thumbnails. The following values are valid: auto, 1:1, 4:3, 3:2, 16:9</summary>
    [JsonPropertyName("aspectRatio")]
    public string? AspectRatio { get; set; }

    /// <summary>The bit rate of the audio stream in the output file, in kilobits/second. Enter an integer between 64 and 320, inclusive.</summary>
    [JsonPropertyName("bitRate")]
    public string? BitRate { get; set; }

    /// <summary>The audio codec for the output file. Valid values are AAC, flac, mp2, mp3, pcm, and vorbis.</summary>
    [JsonPropertyName("codec")]
    public string? Codec { get; set; }

    /// <summary>The value that Elastic Transcoder adds to the metadata in the output file. If you set DisplayAspectRatio to auto, Elastic Transcoder chooses an aspect ratio that ensures square pixels. If you specify another option, Elastic Transcoder sets that value in the output file.</summary>
    [JsonPropertyName("displayAspectRatio")]
    public string? DisplayAspectRatio { get; set; }

    /// <summary>Whether to use a fixed value for Video:FixedGOP. Not applicable for containers of type gif. Valid values are true and false. Also known as, Fixed Number of Frames Between Keyframes.</summary>
    [JsonPropertyName("fixedGop")]
    public string? FixedGop { get; set; }

    /// <summary>The frames per second for the video stream in the output file. The following values are valid: auto, 10, 15, 23.97, 24, 25, 29.97, 30, 50, 60.</summary>
    [JsonPropertyName("frameRate")]
    public string? FrameRate { get; set; }

    /// <summary>The maximum number of frames between key frames. Not applicable for containers of type gif.</summary>
    [JsonPropertyName("keyframesMaxDist")]
    public string? KeyframesMaxDist { get; set; }

    /// <summary>If you specify auto for FrameRate, Elastic Transcoder uses the frame rate of the input video for the frame rate of the output video, up to the maximum frame rate. If you do not specify a MaxFrameRate, Elastic Transcoder will use a default of 30.</summary>
    [JsonPropertyName("maxFrameRate")]
    public string? MaxFrameRate { get; set; }

    /// <summary>The maximum height of thumbnails, in pixels. If you specify auto, Elastic Transcoder uses 1080 (Full HD) as the default value. If you specify a numeric value, enter an even integer between 32 and 3072, inclusive.</summary>
    [JsonPropertyName("maxHeight")]
    public string? MaxHeight { get; set; }

    /// <summary>The maximum width of thumbnails, in pixels. If you specify auto, Elastic Transcoder uses 1920 (Full HD) as the default value. If you specify a numeric value, enter an even integer between 32 and 4096, inclusive.</summary>
    [JsonPropertyName("maxWidth")]
    public string? MaxWidth { get; set; }

    /// <summary>When you set PaddingPolicy to Pad, Elastic Transcoder might add black bars to the top and bottom and/or left and right sides of thumbnails to make the total size of the thumbnails match the values that you specified for thumbnail MaxWidth and MaxHeight settings.</summary>
    [JsonPropertyName("paddingPolicy")]
    public string? PaddingPolicy { get; set; }

    /// <summary>The width and height of thumbnail files in pixels, in the format WidthxHeight, where both values are even integers. The values cannot exceed the width and height that you specified in the Video:Resolution object. (To better control resolution and aspect ratio of thumbnails, we recommend that you use the thumbnail values max_width, max_height, sizing_policy, and padding_policy instead of resolution and aspect_ratio. The two groups of settings are mutually exclusive. Do not use them together)</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>A value that controls scaling of thumbnails. Valid values are: Fit, Fill, Stretch, Keep, ShrinkToFit, and ShrinkToFill.</summary>
    [JsonPropertyName("sizingPolicy")]
    public string? SizingPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetSpecInitProviderVideoWatermarks
{
    /// <summary>The horizontal position of the watermark unless you specify a nonzero value for horzontal_offset.</summary>
    [JsonPropertyName("horizontalAlign")]
    public string? HorizontalAlign { get; set; }

    /// <summary>The amount by which you want the horizontal position of the watermark to be offset from the position specified by horizontal_align.</summary>
    [JsonPropertyName("horizontalOffset")]
    public string? HorizontalOffset { get; set; }

    /// <summary>A unique identifier for the settings for one watermark. The value of Id can be up to 40 characters long. You can specify settings for up to four watermarks.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The maximum height of thumbnails, in pixels. If you specify auto, Elastic Transcoder uses 1080 (Full HD) as the default value. If you specify a numeric value, enter an even integer between 32 and 3072, inclusive.</summary>
    [JsonPropertyName("maxHeight")]
    public string? MaxHeight { get; set; }

    /// <summary>The maximum width of thumbnails, in pixels. If you specify auto, Elastic Transcoder uses 1920 (Full HD) as the default value. If you specify a numeric value, enter an even integer between 32 and 4096, inclusive.</summary>
    [JsonPropertyName("maxWidth")]
    public string? MaxWidth { get; set; }

    /// <summary>A percentage that indicates how much you want a watermark to obscure the video in the location where it appears.</summary>
    [JsonPropertyName("opacity")]
    public string? Opacity { get; set; }

    /// <summary>A value that controls scaling of thumbnails. Valid values are: Fit, Fill, Stretch, Keep, ShrinkToFit, and ShrinkToFill.</summary>
    [JsonPropertyName("sizingPolicy")]
    public string? SizingPolicy { get; set; }

    /// <summary>A value that determines how Elastic Transcoder interprets values that you specified for video_watermarks.horizontal_offset, video_watermarks.vertical_offset, video_watermarks.max_width, and video_watermarks.max_height. Valid values are Content and Frame.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>The vertical position of the watermark unless you specify a nonzero value for vertical_align. Valid values are Top, Bottom, Center.</summary>
    [JsonPropertyName("verticalAlign")]
    public string? VerticalAlign { get; set; }

    /// <summary>The amount by which you want the vertical position of the watermark to be offset from the position specified by vertical_align</summary>
    [JsonPropertyName("verticalOffset")]
    public string? VerticalOffset { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetSpecInitProvider
{
    /// <summary>Audio parameters object (documented below).</summary>
    [JsonPropertyName("audio")]
    public IList<V1beta1PresetSpecInitProviderAudio>? Audio { get; set; }

    /// <summary>Codec options for the audio parameters (documented below)</summary>
    [JsonPropertyName("audioCodecOptions")]
    public IList<V1beta1PresetSpecInitProviderAudioCodecOptions>? AudioCodecOptions { get; set; }

    /// <summary>The container type for the output file. Valid values are flac, flv, fmp4, gif, mp3, mp4, mpg, mxf, oga, ogg, ts, and webm.</summary>
    [JsonPropertyName("container")]
    public string? Container { get; set; }

    /// <summary>A description of the preset (maximum 255 characters)</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the preset. (maximum 40 characters)</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Thumbnail parameters object (documented below)</summary>
    [JsonPropertyName("thumbnails")]
    public IList<V1beta1PresetSpecInitProviderThumbnails>? Thumbnails { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Video parameters object (documented below)</summary>
    [JsonPropertyName("video")]
    public IList<V1beta1PresetSpecInitProviderVideo>? Video { get; set; }

    /// <summary>Codec options for the video parameters</summary>
    [JsonPropertyName("videoCodecOptions")]
    public IDictionary<string, string>? VideoCodecOptions { get; set; }

    /// <summary>Watermark parameters for the video parameters (documented below)</summary>
    [JsonPropertyName("videoWatermarks")]
    public IList<V1beta1PresetSpecInitProviderVideoWatermarks>? VideoWatermarks { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PresetSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>PresetSpec defines the desired state of Preset</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PresetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PresetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PresetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PresetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetStatusAtProviderAudio
{
    /// <summary>The method of organizing audio channels and tracks. Use Audio:Channels to specify the number of channels in your output, and Audio:AudioPackingMode to specify the number of tracks and their relation to the channels. If you do not specify an Audio:AudioPackingMode, Elastic Transcoder uses SingleTrack.</summary>
    [JsonPropertyName("audioPackingMode")]
    public string? AudioPackingMode { get; set; }

    /// <summary>The bit rate of the audio stream in the output file, in kilobits/second. Enter an integer between 64 and 320, inclusive.</summary>
    [JsonPropertyName("bitRate")]
    public string? BitRate { get; set; }

    /// <summary>The number of audio channels in the output file</summary>
    [JsonPropertyName("channels")]
    public string? Channels { get; set; }

    /// <summary>The audio codec for the output file. Valid values are AAC, flac, mp2, mp3, pcm, and vorbis.</summary>
    [JsonPropertyName("codec")]
    public string? Codec { get; set; }

    /// <summary>The sample rate of the audio stream in the output file, in hertz. Valid values are: auto, 22050, 32000, 44100, 48000, 96000</summary>
    [JsonPropertyName("sampleRate")]
    public string? SampleRate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetStatusAtProviderAudioCodecOptions
{
    /// <summary>The bit depth of a sample is how many bits of information are included in the audio samples. Valid values are 16 and 24. (FLAC/PCM Only)</summary>
    [JsonPropertyName("bitDepth")]
    public string? BitDepth { get; set; }

    /// <summary>The order the bits of a PCM sample are stored in. The supported value is LittleEndian. (PCM Only)</summary>
    [JsonPropertyName("bitOrder")]
    public string? BitOrder { get; set; }

    /// <summary>If you specified AAC for Audio:Codec, choose the AAC profile for the output file.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>Whether audio samples are represented with negative and positive numbers (signed) or only positive numbers (unsigned). The supported value is Signed. (PCM Only)</summary>
    [JsonPropertyName("signed")]
    public string? Signed { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetStatusAtProviderThumbnails
{
    /// <summary>The aspect ratio of thumbnails. The following values are valid: auto, 1:1, 4:3, 3:2, 16:9</summary>
    [JsonPropertyName("aspectRatio")]
    public string? AspectRatio { get; set; }

    /// <summary>The format of thumbnails, if any. Valid formats are jpg and png.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The approximate number of seconds between thumbnails. The value must be an integer. The actual interval can vary by several seconds from one thumbnail to the next.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>The maximum height of thumbnails, in pixels. If you specify auto, Elastic Transcoder uses 1080 (Full HD) as the default value. If you specify a numeric value, enter an even integer between 32 and 3072, inclusive.</summary>
    [JsonPropertyName("maxHeight")]
    public string? MaxHeight { get; set; }

    /// <summary>The maximum width of thumbnails, in pixels. If you specify auto, Elastic Transcoder uses 1920 (Full HD) as the default value. If you specify a numeric value, enter an even integer between 32 and 4096, inclusive.</summary>
    [JsonPropertyName("maxWidth")]
    public string? MaxWidth { get; set; }

    /// <summary>When you set PaddingPolicy to Pad, Elastic Transcoder might add black bars to the top and bottom and/or left and right sides of thumbnails to make the total size of the thumbnails match the values that you specified for thumbnail MaxWidth and MaxHeight settings.</summary>
    [JsonPropertyName("paddingPolicy")]
    public string? PaddingPolicy { get; set; }

    /// <summary>The width and height of thumbnail files in pixels, in the format WidthxHeight, where both values are even integers. The values cannot exceed the width and height that you specified in the Video:Resolution object. (To better control resolution and aspect ratio of thumbnails, we recommend that you use the thumbnail values max_width, max_height, sizing_policy, and padding_policy instead of resolution and aspect_ratio. The two groups of settings are mutually exclusive. Do not use them together)</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>A value that controls scaling of thumbnails. Valid values are: Fit, Fill, Stretch, Keep, ShrinkToFit, and ShrinkToFill.</summary>
    [JsonPropertyName("sizingPolicy")]
    public string? SizingPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetStatusAtProviderVideo
{
    /// <summary>The aspect ratio of thumbnails. The following values are valid: auto, 1:1, 4:3, 3:2, 16:9</summary>
    [JsonPropertyName("aspectRatio")]
    public string? AspectRatio { get; set; }

    /// <summary>The bit rate of the audio stream in the output file, in kilobits/second. Enter an integer between 64 and 320, inclusive.</summary>
    [JsonPropertyName("bitRate")]
    public string? BitRate { get; set; }

    /// <summary>The audio codec for the output file. Valid values are AAC, flac, mp2, mp3, pcm, and vorbis.</summary>
    [JsonPropertyName("codec")]
    public string? Codec { get; set; }

    /// <summary>The value that Elastic Transcoder adds to the metadata in the output file. If you set DisplayAspectRatio to auto, Elastic Transcoder chooses an aspect ratio that ensures square pixels. If you specify another option, Elastic Transcoder sets that value in the output file.</summary>
    [JsonPropertyName("displayAspectRatio")]
    public string? DisplayAspectRatio { get; set; }

    /// <summary>Whether to use a fixed value for Video:FixedGOP. Not applicable for containers of type gif. Valid values are true and false. Also known as, Fixed Number of Frames Between Keyframes.</summary>
    [JsonPropertyName("fixedGop")]
    public string? FixedGop { get; set; }

    /// <summary>The frames per second for the video stream in the output file. The following values are valid: auto, 10, 15, 23.97, 24, 25, 29.97, 30, 50, 60.</summary>
    [JsonPropertyName("frameRate")]
    public string? FrameRate { get; set; }

    /// <summary>The maximum number of frames between key frames. Not applicable for containers of type gif.</summary>
    [JsonPropertyName("keyframesMaxDist")]
    public string? KeyframesMaxDist { get; set; }

    /// <summary>If you specify auto for FrameRate, Elastic Transcoder uses the frame rate of the input video for the frame rate of the output video, up to the maximum frame rate. If you do not specify a MaxFrameRate, Elastic Transcoder will use a default of 30.</summary>
    [JsonPropertyName("maxFrameRate")]
    public string? MaxFrameRate { get; set; }

    /// <summary>The maximum height of thumbnails, in pixels. If you specify auto, Elastic Transcoder uses 1080 (Full HD) as the default value. If you specify a numeric value, enter an even integer between 32 and 3072, inclusive.</summary>
    [JsonPropertyName("maxHeight")]
    public string? MaxHeight { get; set; }

    /// <summary>The maximum width of thumbnails, in pixels. If you specify auto, Elastic Transcoder uses 1920 (Full HD) as the default value. If you specify a numeric value, enter an even integer between 32 and 4096, inclusive.</summary>
    [JsonPropertyName("maxWidth")]
    public string? MaxWidth { get; set; }

    /// <summary>When you set PaddingPolicy to Pad, Elastic Transcoder might add black bars to the top and bottom and/or left and right sides of thumbnails to make the total size of the thumbnails match the values that you specified for thumbnail MaxWidth and MaxHeight settings.</summary>
    [JsonPropertyName("paddingPolicy")]
    public string? PaddingPolicy { get; set; }

    /// <summary>The width and height of thumbnail files in pixels, in the format WidthxHeight, where both values are even integers. The values cannot exceed the width and height that you specified in the Video:Resolution object. (To better control resolution and aspect ratio of thumbnails, we recommend that you use the thumbnail values max_width, max_height, sizing_policy, and padding_policy instead of resolution and aspect_ratio. The two groups of settings are mutually exclusive. Do not use them together)</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>A value that controls scaling of thumbnails. Valid values are: Fit, Fill, Stretch, Keep, ShrinkToFit, and ShrinkToFill.</summary>
    [JsonPropertyName("sizingPolicy")]
    public string? SizingPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetStatusAtProviderVideoWatermarks
{
    /// <summary>The horizontal position of the watermark unless you specify a nonzero value for horzontal_offset.</summary>
    [JsonPropertyName("horizontalAlign")]
    public string? HorizontalAlign { get; set; }

    /// <summary>The amount by which you want the horizontal position of the watermark to be offset from the position specified by horizontal_align.</summary>
    [JsonPropertyName("horizontalOffset")]
    public string? HorizontalOffset { get; set; }

    /// <summary>A unique identifier for the settings for one watermark. The value of Id can be up to 40 characters long. You can specify settings for up to four watermarks.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The maximum height of thumbnails, in pixels. If you specify auto, Elastic Transcoder uses 1080 (Full HD) as the default value. If you specify a numeric value, enter an even integer between 32 and 3072, inclusive.</summary>
    [JsonPropertyName("maxHeight")]
    public string? MaxHeight { get; set; }

    /// <summary>The maximum width of thumbnails, in pixels. If you specify auto, Elastic Transcoder uses 1920 (Full HD) as the default value. If you specify a numeric value, enter an even integer between 32 and 4096, inclusive.</summary>
    [JsonPropertyName("maxWidth")]
    public string? MaxWidth { get; set; }

    /// <summary>A percentage that indicates how much you want a watermark to obscure the video in the location where it appears.</summary>
    [JsonPropertyName("opacity")]
    public string? Opacity { get; set; }

    /// <summary>A value that controls scaling of thumbnails. Valid values are: Fit, Fill, Stretch, Keep, ShrinkToFit, and ShrinkToFill.</summary>
    [JsonPropertyName("sizingPolicy")]
    public string? SizingPolicy { get; set; }

    /// <summary>A value that determines how Elastic Transcoder interprets values that you specified for video_watermarks.horizontal_offset, video_watermarks.vertical_offset, video_watermarks.max_width, and video_watermarks.max_height. Valid values are Content and Frame.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>The vertical position of the watermark unless you specify a nonzero value for vertical_align. Valid values are Top, Bottom, Center.</summary>
    [JsonPropertyName("verticalAlign")]
    public string? VerticalAlign { get; set; }

    /// <summary>The amount by which you want the vertical position of the watermark to be offset from the position specified by vertical_align</summary>
    [JsonPropertyName("verticalOffset")]
    public string? VerticalOffset { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of the Elastic Transcoder Preset.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Audio parameters object (documented below).</summary>
    [JsonPropertyName("audio")]
    public IList<V1beta1PresetStatusAtProviderAudio>? Audio { get; set; }

    /// <summary>Codec options for the audio parameters (documented below)</summary>
    [JsonPropertyName("audioCodecOptions")]
    public IList<V1beta1PresetStatusAtProviderAudioCodecOptions>? AudioCodecOptions { get; set; }

    /// <summary>The container type for the output file. Valid values are flac, flv, fmp4, gif, mp3, mp4, mpg, mxf, oga, ogg, ts, and webm.</summary>
    [JsonPropertyName("container")]
    public string? Container { get; set; }

    /// <summary>A description of the preset (maximum 255 characters)</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A unique identifier for the settings for one watermark. The value of Id can be up to 40 characters long. You can specify settings for up to four watermarks.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the preset. (maximum 40 characters)</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Thumbnail parameters object (documented below)</summary>
    [JsonPropertyName("thumbnails")]
    public IList<V1beta1PresetStatusAtProviderThumbnails>? Thumbnails { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Video parameters object (documented below)</summary>
    [JsonPropertyName("video")]
    public IList<V1beta1PresetStatusAtProviderVideo>? Video { get; set; }

    /// <summary>Codec options for the video parameters</summary>
    [JsonPropertyName("videoCodecOptions")]
    public IDictionary<string, string>? VideoCodecOptions { get; set; }

    /// <summary>Watermark parameters for the video parameters (documented below)</summary>
    [JsonPropertyName("videoWatermarks")]
    public IList<V1beta1PresetStatusAtProviderVideoWatermarks>? VideoWatermarks { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetStatusConditions
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

/// <summary>PresetStatus defines the observed state of Preset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PresetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PresetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PresetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Preset is the Schema for the Presets API. Provides an Elastic Transcoder preset resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Preset : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PresetSpec>, IStatus<V1beta1PresetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Preset";
    public const string KubeGroup = "elastictranscoder.aws.upbound.io";
    public const string KubePluralName = "presets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PresetSpec defines the desired state of Preset</summary>
    [JsonPropertyName("spec")]
    public V1beta1PresetSpec Spec { get; set; }

    /// <summary>PresetStatus defines the observed state of Preset.</summary>
    [JsonPropertyName("status")]
    public V1beta1PresetStatus? Status { get; set; }
}