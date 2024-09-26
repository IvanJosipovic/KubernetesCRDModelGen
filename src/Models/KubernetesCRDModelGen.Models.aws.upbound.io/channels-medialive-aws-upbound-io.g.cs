using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.medialive.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderCdiInputSpecification
{
    /// <summary>- Maximum CDI input resolution.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderDestinationsMediaPackageSettings
{
    /// <summary>ID of the channel in MediaPackage that is the destination for this output group.</summary>
    [JsonPropertyName("channelId")]
    public string? ChannelId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderDestinationsMultiplexSettings
{
    /// <summary>The ID of the Multiplex that the encoder is providing output to.</summary>
    [JsonPropertyName("multiplexId")]
    public string? MultiplexId { get; set; }

    /// <summary>The program name of the Multiplex program that the encoder is providing output to.</summary>
    [JsonPropertyName("programName")]
    public string? ProgramName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderDestinationsSettings
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Stream name RTMP destinations (URLs of type rtmp://)</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }

    /// <summary>A URL specifying a destination.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderDestinations
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Destination settings for a MediaPackage output; one destination for both encoders. See Media Package Settings for more details.</summary>
    [JsonPropertyName("mediaPackageSettings")]
    public IList<V1beta1ChannelSpecForProviderDestinationsMediaPackageSettings>? MediaPackageSettings { get; set; }

    /// <summary>Destination settings for a Multiplex output; one destination for both encoders. See Multiplex Settings for more details.</summary>
    [JsonPropertyName("multiplexSettings")]
    public IList<V1beta1ChannelSpecForProviderDestinationsMultiplexSettings>? MultiplexSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("settings")]
    public IList<V1beta1ChannelSpecForProviderDestinationsSettings>? Settings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsAudioNormalizationSettings
{
    /// <summary>Audio normalization algorithm to use. itu17701 conforms to the CALM Act specification, itu17702 to the EBU R-128 specification.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Algorithm control for the audio description.</summary>
    [JsonPropertyName("algorithmControl")]
    public string? AlgorithmControl { get; set; }

    /// <summary>Target LKFS (loudness) to adjust volume to.</summary>
    [JsonPropertyName("targetLkfs")]
    public double? TargetLkfs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenCbetSettings
{
    /// <summary></summary>
    [JsonPropertyName("cbetCheckDigitString")]
    public string? CbetCheckDigitString { get; set; }

    /// <summary>Determines the method of CBET insertion mode when prior encoding is detected on the same layer.</summary>
    [JsonPropertyName("cbetStepaside")]
    public string? CbetStepaside { get; set; }

    /// <summary>CBET source ID to use in the watermark.</summary>
    [JsonPropertyName("csid")]
    public string? Csid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenNaesIiNwSettings
{
    /// <summary></summary>
    [JsonPropertyName("checkDigitString")]
    public string? CheckDigitString { get; set; }

    /// <summary>The Nielsen Source ID to include in the watermark.</summary>
    [JsonPropertyName("sid")]
    public double? Sid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettings
{
    /// <summary>Used to insert watermarks of type Nielsen CBET. See Nielsen CBET Settings for more details.</summary>
    [JsonPropertyName("nielsenCbetSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenCbetSettings>? NielsenCbetSettings { get; set; }

    /// <summary>Distribution types to assign to the watermarks. Options are PROGRAM_CONTENT and FINAL_DISTRIBUTOR.</summary>
    [JsonPropertyName("nielsenDistributionType")]
    public string? NielsenDistributionType { get; set; }

    /// <summary>Used to insert watermarks of type Nielsen NAES, II (N2) and Nielsen NAES VI (NW). See Nielsen NAES II NW Settings for more details.</summary>
    [JsonPropertyName("nielsenNaesIiNwSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenNaesIiNwSettings>? NielsenNaesIiNwSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("nielsenWatermarksSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettings>? NielsenWatermarksSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsAacSettings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Set to "broadcasterMixedAd" when input contains pre-mixed main audio + AD (narration) as a stereo pair.</summary>
    [JsonPropertyName("inputType")]
    public string? InputType { get; set; }

    /// <summary>AAC profile.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>The rate control mode.</summary>
    [JsonPropertyName("rateControlMode")]
    public string? RateControlMode { get; set; }

    /// <summary>Sets LATM/LOAS AAC output for raw containers.</summary>
    [JsonPropertyName("rawFormat")]
    public string? RawFormat { get; set; }

    /// <summary>Sample rate in Hz.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }

    /// <summary>Use MPEG-2 AAC audio instead of MPEG-4 AAC audio for raw or MPEG-2 Transport Stream containers.</summary>
    [JsonPropertyName("spec")]
    public string? Spec { get; set; }

    /// <summary>VBR Quality Level - Only used if rateControlMode is VBR.</summary>
    [JsonPropertyName("vbrQuality")]
    public string? VbrQuality { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsAc3Settings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Specifies the bitstream mode (bsmod) for the emitted AC-3 stream.</summary>
    [JsonPropertyName("bitstreamMode")]
    public string? BitstreamMode { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sets the dialnorm of the output.</summary>
    [JsonPropertyName("dialnorm")]
    public double? Dialnorm { get; set; }

    /// <summary>If set to filmStandard, adds dynamic range compression signaling to the output bitstream as defined in the Dolby Digital specification.</summary>
    [JsonPropertyName("drcProfile")]
    public string? DrcProfile { get; set; }

    /// <summary>When set to enabled, applies a 120Hz lowpass filter to the LFE channel prior to encoding.</summary>
    [JsonPropertyName("lfeFilter")]
    public string? LfeFilter { get; set; }

    /// <summary>Metadata control.</summary>
    [JsonPropertyName("metadataControl")]
    public string? MetadataControl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sets the dialnorm of the output.</summary>
    [JsonPropertyName("dialnorm")]
    public double? Dialnorm { get; set; }

    /// <summary>Sets the Dolby dynamic range compression profile.</summary>
    [JsonPropertyName("drcLine")]
    public string? DrcLine { get; set; }

    /// <summary>Sets the profile for heavy Dolby dynamic range compression.</summary>
    [JsonPropertyName("drcRf")]
    public string? DrcRf { get; set; }

    /// <summary>Height dimensional trim.</summary>
    [JsonPropertyName("heightTrim")]
    public double? HeightTrim { get; set; }

    /// <summary>Surround dimensional trim.</summary>
    [JsonPropertyName("surroundTrim")]
    public double? SurroundTrim { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3Settings
{
    /// <summary>Sets the attenuation control.</summary>
    [JsonPropertyName("attenuationControl")]
    public string? AttenuationControl { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Specifies the bitstream mode (bsmod) for the emitted AC-3 stream.</summary>
    [JsonPropertyName("bitstreamMode")]
    public string? BitstreamMode { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dcFilter")]
    public string? DcFilter { get; set; }

    /// <summary>Sets the dialnorm of the output.</summary>
    [JsonPropertyName("dialnorm")]
    public double? Dialnorm { get; set; }

    /// <summary>Sets the Dolby dynamic range compression profile.</summary>
    [JsonPropertyName("drcLine")]
    public string? DrcLine { get; set; }

    /// <summary>Sets the profile for heavy Dolby dynamic range compression.</summary>
    [JsonPropertyName("drcRf")]
    public string? DrcRf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lfeControl")]
    public string? LfeControl { get; set; }

    /// <summary>When set to enabled, applies a 120Hz lowpass filter to the LFE channel prior to encoding.</summary>
    [JsonPropertyName("lfeFilter")]
    public string? LfeFilter { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("loRoCenterMixLevel")]
    public double? LoRoCenterMixLevel { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("loRoSurroundMixLevel")]
    public double? LoRoSurroundMixLevel { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("ltRtCenterMixLevel")]
    public double? LtRtCenterMixLevel { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("ltRtSurroundMixLevel")]
    public double? LtRtSurroundMixLevel { get; set; }

    /// <summary>Metadata control.</summary>
    [JsonPropertyName("metadataControl")]
    public string? MetadataControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passthroughControl")]
    public string? PassthroughControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("phaseControl")]
    public string? PhaseControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stereoDownmix")]
    public string? StereoDownmix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("surroundExMode")]
    public string? SurroundExMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("surroundMode")]
    public string? SurroundMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsMp2Settings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sample rate in Hz.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsPassThroughSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsWavSettings
{
    /// <summary></summary>
    [JsonPropertyName("bitDepth")]
    public double? BitDepth { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sample rate in Hz.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettings
{
    /// <summary>Aac Settings. See AAC Settings for more details.</summary>
    [JsonPropertyName("aacSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsAacSettings>? AacSettings { get; set; }

    /// <summary>Ac3 Settings. See AC3 Settings for more details.</summary>
    [JsonPropertyName("ac3Settings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsAc3Settings>? Ac3Settings { get; set; }

    /// <summary>- Eac3 Atmos Settings. See EAC3 Atmos Settings</summary>
    [JsonPropertyName("eac3AtmosSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings>? Eac3AtmosSettings { get; set; }

    /// <summary>- Eac3 Settings. See EAC3 Settings</summary>
    [JsonPropertyName("eac3Settings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3Settings>? Eac3Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("mp2Settings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsMp2Settings>? Mp2Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("passThroughSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsPassThroughSettings>? PassThroughSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("wavSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsWavSettings>? WavSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappingsInputChannelLevels
{
    /// <summary></summary>
    [JsonPropertyName("gain")]
    public double? Gain { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inputChannel")]
    public double? InputChannel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings
{
    /// <summary></summary>
    [JsonPropertyName("inputChannelLevels")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappingsInputChannelLevels>? InputChannelLevels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outputChannel")]
    public double? OutputChannel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsRemixSettings
{
    /// <summary></summary>
    [JsonPropertyName("channelMappings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings>? ChannelMappings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("channelsIn")]
    public double? ChannelsIn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("channelsOut")]
    public double? ChannelsOut { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptions
{
    /// <summary>Advanced audio normalization settings. See Audio Normalization Settings for more details.</summary>
    [JsonPropertyName("audioNormalizationSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsAudioNormalizationSettings>? AudioNormalizationSettings { get; set; }

    /// <summary>The name of the audio selector in the input that MediaLive should monitor to detect silence. Select your most important rendition. If you didn't create an audio selector in this input, leave blank.</summary>
    [JsonPropertyName("audioSelectorName")]
    public string? AudioSelectorName { get; set; }

    /// <summary>Applies only if audioTypeControl is useConfigured. The values for audioType are defined in ISO-IEC 13818-1.</summary>
    [JsonPropertyName("audioType")]
    public string? AudioType { get; set; }

    /// <summary>Determined how audio type is determined.</summary>
    [JsonPropertyName("audioTypeControl")]
    public string? AudioTypeControl { get; set; }

    /// <summary>Settings to configure one or more solutions that insert audio watermarks in the audio encode. See Audio Watermark Settings for more details.</summary>
    [JsonPropertyName("audioWatermarkSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettings>? AudioWatermarkSettings { get; set; }

    /// <summary>Audio codec settings. See Audio Codec Settings for more details.</summary>
    [JsonPropertyName("codecSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettings>? CodecSettings { get; set; }

    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("languageCodeControl")]
    public string? LanguageCodeControl { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("remixSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptionsRemixSettings>? RemixSettings { get; set; }

    /// <summary>Stream name RTMP destinations (URLs of type rtmp://)</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsAvailBlankingAvailBlankingImage
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>–  Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsAvailBlanking
{
    /// <summary>Blanking image to be used. See Avail Blanking Image for more details.</summary>
    [JsonPropertyName("availBlankingImage")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsAvailBlankingAvailBlankingImage>? AvailBlankingImage { get; set; }

    /// <summary>When set to enabled, causes video, audio and captions to be blanked when insertion metadata is added.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsAribDestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettingsFont
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>–  Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettings
{
    /// <summary>justify live subtitles and center-justify pre-recorded subtitles. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("alignment")]
    public string? Alignment { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundOpacity")]
    public double? BackgroundOpacity { get; set; }

    /// <summary>in. File extension must be ‘ttf’ or ‘tte’. Although the user can select output fonts for many different types of input captions, embedded, STL and teletext sources use a strict grid system. Using external fonts with these caption sources could cause unexpected display of proportional fonts. All burn-in and DVB-Sub font settings must match. See Font for more details.</summary>
    [JsonPropertyName("font")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettingsFont>? Font { get; set; }

    /// <summary>in captions. This option is not valid for source captions that are STL, 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontColor")]
    public string? FontColor { get; set; }

    /// <summary>in captions. 255 is opaque; 0 is transparent. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontOpacity")]
    public double? FontOpacity { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontResolution")]
    public double? FontResolution { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontSize")]
    public string? FontSize { get; set; }

    /// <summary>defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineColor")]
    public string? OutlineColor { get; set; }

    /// <summary>defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineSize")]
    public double? OutlineSize { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowColor")]
    public string? ShadowColor { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowOpacity")]
    public double? ShadowOpacity { get; set; }

    /// <summary>2 would result in a shadow offset 2 pixels to the left. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowXOffset")]
    public double? ShadowXOffset { get; set; }

    /// <summary>2 would result in a shadow offset 2 pixels above the text. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowYOffset")]
    public double? ShadowYOffset { get; set; }

    /// <summary>Sub/Burn-in outputs.</summary>
    [JsonPropertyName("teletextGridControl")]
    public string? TeletextGridControl { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("xPosition")]
    public double? XPosition { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("yPosition")]
    public double? YPosition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettingsFont
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>–  Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettings
{
    /// <summary>justify live subtitles and center-justify pre-recorded subtitles. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("alignment")]
    public string? Alignment { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundOpacity")]
    public double? BackgroundOpacity { get; set; }

    /// <summary>in. File extension must be ‘ttf’ or ‘tte’. Although the user can select output fonts for many different types of input captions, embedded, STL and teletext sources use a strict grid system. Using external fonts with these caption sources could cause unexpected display of proportional fonts. All burn-in and DVB-Sub font settings must match. See Font for more details.</summary>
    [JsonPropertyName("font")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettingsFont>? Font { get; set; }

    /// <summary>in captions. This option is not valid for source captions that are STL, 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontColor")]
    public string? FontColor { get; set; }

    /// <summary>in captions. 255 is opaque; 0 is transparent. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontOpacity")]
    public double? FontOpacity { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontResolution")]
    public double? FontResolution { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontSize")]
    public string? FontSize { get; set; }

    /// <summary>defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineColor")]
    public string? OutlineColor { get; set; }

    /// <summary>defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineSize")]
    public double? OutlineSize { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowColor")]
    public string? ShadowColor { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowOpacity")]
    public double? ShadowOpacity { get; set; }

    /// <summary>2 would result in a shadow offset 2 pixels to the left. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowXOffset")]
    public double? ShadowXOffset { get; set; }

    /// <summary>2 would result in a shadow offset 2 pixels above the text. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowYOffset")]
    public double? ShadowYOffset { get; set; }

    /// <summary>Sub/Burn-in outputs.</summary>
    [JsonPropertyName("teletextGridControl")]
    public string? TeletextGridControl { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("xPosition")]
    public double? XPosition { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("yPosition")]
    public double? YPosition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEbuTtDDestinationSettings
{
    /// <summary>–  Complete this field if you want to include the name of the copyright holder in the copyright tag in the captions metadata.</summary>
    [JsonPropertyName("copyrightHolder")]
    public string? CopyrightHolder { get; set; }

    /// <summary>line captions). - enabled: Fill with the captions background color (as specified in the input captions). - disabled: Leave the gap unfilled.</summary>
    [JsonPropertyName("fillLineGap")]
    public string? FillLineGap { get; set; }

    /// <summary>TT captions. Valid only if styleControl is set to include. If you leave this field empty, the font family is set to “monospaced”. (If styleControl is set to exclude, the font family is always set to “monospaced”.) You specify only the font family. All other style information (color, bold, position and so on) is copied from the input captions. The size is always set to 100% to allow the downstream player to choose the size. - Enter a list of font families, as a comma-separated list of font names, in order of preference. The name can be a font family (such as “Arial”), or a generic font family (such as “serif”), or “default” (to let the downstream player choose the font). - Leave blank to set the family to “monospace”.</summary>
    [JsonPropertyName("fontFamily")]
    public string? FontFamily { get; set; }

    /// <summary>TT captions. - include: Take the style information (font color, font position, and so on) from the source captions and include that information in the font data attached to the EBU-TT captions. This option is valid only if the source captions are Embedded or Teletext. - exclude: In the font data attached to the EBU-TT captions, set the font family to “monospaced”. Do not include any other style information.</summary>
    [JsonPropertyName("styleControl")]
    public string? StyleControl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedDestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedPlusScte20DestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsRtmpCaptionInfoDestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte20PlusEmbeddedDestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte27DestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsSmpteTtDestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTeletextDestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTtmlDestinationSettings
{
    /// <summary>TT captions. - include: Take the style information (font color, font position, and so on) from the source captions and include that information in the font data attached to the EBU-TT captions. This option is valid only if the source captions are Embedded or Teletext. - exclude: In the font data attached to the EBU-TT captions, set the font family to “monospaced”. Do not include any other style information.</summary>
    [JsonPropertyName("styleControl")]
    public string? StyleControl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsWebvttDestinationSettings
{
    /// <summary>TT captions. - include: Take the style information (font color, font position, and so on) from the source captions and include that information in the font data attached to the EBU-TT captions. This option is valid only if the source captions are Embedded or Teletext. - exclude: In the font data attached to the EBU-TT captions, set the font family to “monospaced”. Do not include any other style information.</summary>
    [JsonPropertyName("styleControl")]
    public string? StyleControl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettings
{
    /// <summary>ARIB Destination Settings.</summary>
    [JsonPropertyName("aribDestinationSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsAribDestinationSettings>? AribDestinationSettings { get; set; }

    /// <summary>Burn In Destination Settings. See Burn In Destination Settings for more details.</summary>
    [JsonPropertyName("burnInDestinationSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettings>? BurnInDestinationSettings { get; set; }

    /// <summary>DVB Sub Destination Settings. See DVB Sub Destination Settings for more details.</summary>
    [JsonPropertyName("dvbSubDestinationSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettings>? DvbSubDestinationSettings { get; set; }

    /// <summary>EBU TT D Destination Settings. See EBU TT D Destination Settings for more details.</summary>
    [JsonPropertyName("ebuTtDDestinationSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEbuTtDDestinationSettings>? EbuTtDDestinationSettings { get; set; }

    /// <summary>Embedded Destination Settings.</summary>
    [JsonPropertyName("embeddedDestinationSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedDestinationSettings>? EmbeddedDestinationSettings { get; set; }

    /// <summary>Embedded Plus SCTE20 Destination Settings.</summary>
    [JsonPropertyName("embeddedPlusScte20DestinationSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedPlusScte20DestinationSettings>? EmbeddedPlusScte20DestinationSettings { get; set; }

    /// <summary>RTMP Caption Info Destination Settings.</summary>
    [JsonPropertyName("rtmpCaptionInfoDestinationSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsRtmpCaptionInfoDestinationSettings>? RtmpCaptionInfoDestinationSettings { get; set; }

    /// <summary>SCTE20 Plus Embedded Destination Settings.</summary>
    [JsonPropertyName("scte20PlusEmbeddedDestinationSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte20PlusEmbeddedDestinationSettings>? Scte20PlusEmbeddedDestinationSettings { get; set; }

    /// <summary>–  SCTE27 Destination Settings.</summary>
    [JsonPropertyName("scte27DestinationSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte27DestinationSettings>? Scte27DestinationSettings { get; set; }

    /// <summary>–  SMPTE TT Destination Settings.</summary>
    [JsonPropertyName("smpteTtDestinationSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsSmpteTtDestinationSettings>? SmpteTtDestinationSettings { get; set; }

    /// <summary>–  Teletext Destination Settings.</summary>
    [JsonPropertyName("teletextDestinationSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTeletextDestinationSettings>? TeletextDestinationSettings { get; set; }

    /// <summary>–  TTML Destination Settings. See TTML Destination Settings for more details.</summary>
    [JsonPropertyName("ttmlDestinationSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTtmlDestinationSettings>? TtmlDestinationSettings { get; set; }

    /// <summary>WebVTT Destination Settings. See WebVTT Destination Settings for more details.</summary>
    [JsonPropertyName("webvttDestinationSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsWebvttDestinationSettings>? WebvttDestinationSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptions
{
    /// <summary>Indicates whether the caption track implements accessibility features such as written descriptions of spoken dialog, music, and sounds.</summary>
    [JsonPropertyName("accessibility")]
    public string? Accessibility { get; set; }

    /// <summary>Specifies which input caption selector to use as a caption source when generating output captions. This field should match a captionSelector name.</summary>
    [JsonPropertyName("captionSelectorName")]
    public string? CaptionSelectorName { get; set; }

    /// <summary>Additional settings for captions destination that depend on the destination type. See Destination Settings for more details.</summary>
    [JsonPropertyName("destinationSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettings>? DestinationSettings { get; set; }

    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Human readable information to indicate captions available for players (eg. English, or Spanish).</summary>
    [JsonPropertyName("languageDescription")]
    public string? LanguageDescription { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>–  Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsGlobalConfigurationInputLossBehavior
{
    /// <summary></summary>
    [JsonPropertyName("blackFrameMsec")]
    public double? BlackFrameMsec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inputLossImageColor")]
    public string? InputLossImageColor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inputLossImageSlate")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate>? InputLossImageSlate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inputLossImageType")]
    public string? InputLossImageType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repeatFrameMsec")]
    public double? RepeatFrameMsec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsGlobalConfiguration
{
    /// <summary>–  Value to set the initial audio gain for the Live Event.</summary>
    [JsonPropertyName("initialAudioGain")]
    public double? InitialAudioGain { get; set; }

    /// <summary>of-file). When switchAndLoopInputs is configured the encoder will restart at the beginning of the first input. When “none” is configured the encoder will transcode either black, a solid color, or a user specified slate images per the “Input Loss Behavior” configuration until the next input switch occurs (which is controlled through the Channel Schedule API).</summary>
    [JsonPropertyName("inputEndAction")]
    public string? InputEndAction { get; set; }

    /// <summary>Settings for system actions when input is lost. See Input Loss Behavior for more details.</summary>
    [JsonPropertyName("inputLossBehavior")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsGlobalConfigurationInputLossBehavior>? InputLossBehavior { get; set; }

    /// <summary>MediaLive will attempt to synchronize the output of each pipeline to the other. EPOCH_LOCKING - MediaLive will attempt to synchronize the output of each pipeline to the Unix epoch.</summary>
    [JsonPropertyName("outputLockingMode")]
    public string? OutputLockingMode { get; set; }

    /// <summary>–  Indicates whether the rate of frames emitted by the Live encoder should be paced by its system clock (which optionally may be locked to another source via NTP) or should be locked to the clock of the source that is providing the input stream.</summary>
    [JsonPropertyName("outputTimingSource")]
    public string? OutputTimingSource { get; set; }

    /// <summary>–  Adjusts video input buffer for streams with very low video framerates. This is commonly set to enabled for music channels with less than one video frame per second.</summary>
    [JsonPropertyName("supportLowFramerateInputs")]
    public string? SupportLowFramerateInputs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettingsHtmlMotionGraphicsSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings
{
    /// <summary>–  Html Motion Graphics Settings.</summary>
    [JsonPropertyName("htmlMotionGraphicsSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettingsHtmlMotionGraphicsSettings>? HtmlMotionGraphicsSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsMotionGraphicsConfiguration
{
    /// <summary>–  Motion Graphics Insertion.</summary>
    [JsonPropertyName("motionGraphicsInsertion")]
    public string? MotionGraphicsInsertion { get; set; }

    /// <summary>–  Motion Graphics Settings. See Motion Graphics Settings for more details.</summary>
    [JsonPropertyName("motionGraphicsSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings>? MotionGraphicsSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsNielsenConfiguration
{
    /// <summary>–  Enter the Distributor ID assigned to your organization by Nielsen.</summary>
    [JsonPropertyName("distributorId")]
    public string? DistributorId { get; set; }

    /// <summary>–  Enables Nielsen PCM to ID3 tagging.</summary>
    [JsonPropertyName("nielsenPcmToId3Tagging")]
    public string? NielsenPcmToId3Tagging { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettingsArchiveS3Settings
{
    /// <summary>Specify the canned ACL to apply to each S3 request.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettings
{
    /// <summary>Archive S3 Settings. See Archive S3 Settings for more details.</summary>
    [JsonPropertyName("archiveS3Settings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettingsArchiveS3Settings>? ArchiveS3Settings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettings
{
    /// <summary>Parameters that control the interactions with the CDN. See Archive CDN Settings for more details.</summary>
    [JsonPropertyName("archiveCdnSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettings>? ArchiveCdnSettings { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsDestination>? Destination { get; set; }

    /// <summary>Number of seconds to write to archive file before closing and starting a new one.</summary>
    [JsonPropertyName("rolloverInterval")]
    public double? RolloverInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettingsFrameCaptureS3Settings
{
    /// <summary>Specify the canned ACL to apply to each S3 request.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureS3Settings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettingsFrameCaptureS3Settings>? FrameCaptureS3Settings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettings
{
    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsDestination>? Destination { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureCdnSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettings>? FrameCaptureCdnSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsCaptionLanguageMappings
{
    /// <summary></summary>
    [JsonPropertyName("captionChannel")]
    public double? CaptionChannel { get; set; }

    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Human readable information to indicate captions available for players (eg. English, or Spanish).</summary>
    [JsonPropertyName("languageDescription")]
    public string? LanguageDescription { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsAkamaiSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpTransferMode")]
    public string? HttpTransferMode { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }

    /// <summary></summary>
    [JsonPropertyName("salt")]
    public string? Salt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsBasicPutSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsMediaStoreSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mediaStoreStorageClass")]
    public string? MediaStoreStorageClass { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsS3Settings
{
    /// <summary>Specify the canned ACL to apply to each S3 request.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsWebdavSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpTransferMode")]
    public string? HttpTransferMode { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsAkamaiSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsAkamaiSettings>? HlsAkamaiSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsBasicPutSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsBasicPutSettings>? HlsBasicPutSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsMediaStoreSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsMediaStoreSettings>? HlsMediaStoreSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsS3Settings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsS3Settings>? HlsS3Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsWebdavSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsWebdavSettings>? HlsWebdavSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettingsKeyProviderServer
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>–  Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettings
{
    /// <summary></summary>
    [JsonPropertyName("keyProviderServer")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettingsKeyProviderServer>? KeyProviderServer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("staticKeyValue")]
    public string? StaticKeyValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("staticKeySettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettings>? StaticKeySettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings
{
    /// <summary>The ad marker type for this output group.</summary>
    [JsonPropertyName("adMarkers")]
    public IList<string>? AdMarkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("baseUrlContent")]
    public string? BaseUrlContent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("baseUrlContent1")]
    public string? BaseUrlContent1 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("baseUrlManifest")]
    public string? BaseUrlManifest { get; set; }

    /// <summary></summary>
    [JsonPropertyName("baseUrlManifest1")]
    public string? BaseUrlManifest1 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("captionLanguageMappings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsCaptionLanguageMappings>? CaptionLanguageMappings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("captionLanguageSetting")]
    public string? CaptionLanguageSetting { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientCache")]
    public string? ClientCache { get; set; }

    /// <summary></summary>
    [JsonPropertyName("codecSpecification")]
    public string? CodecSpecification { get; set; }

    /// <summary></summary>
    [JsonPropertyName("constantIv")]
    public string? ConstantIv { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsDestination>? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directoryStructure")]
    public string? DirectoryStructure { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("discontinuityTags")]
    public string? DiscontinuityTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsCdnSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettings>? HlsCdnSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hlsId3SegmentTagging")]
    public string? HlsId3SegmentTagging { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iframeOnlyPlaylists")]
    public string? IframeOnlyPlaylists { get; set; }

    /// <summary></summary>
    [JsonPropertyName("incompleteSegmentBehavior")]
    public string? IncompleteSegmentBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("indexNSegments")]
    public double? IndexNSegments { get; set; }

    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ivInManifest")]
    public string? IvInManifest { get; set; }

    /// <summary>The source for the timecode that will be associated with the events outputs.</summary>
    [JsonPropertyName("ivSource")]
    public string? IvSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keepSegments")]
    public double? KeepSegments { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyFormat")]
    public string? KeyFormat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyFormatVersions")]
    public string? KeyFormatVersions { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("keyProviderSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettings>? KeyProviderSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("manifestCompression")]
    public string? ManifestCompression { get; set; }

    /// <summary></summary>
    [JsonPropertyName("manifestDurationFormat")]
    public string? ManifestDurationFormat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minSegmentLength")]
    public double? MinSegmentLength { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outputSelection")]
    public string? OutputSelection { get; set; }

    /// <summary></summary>
    [JsonPropertyName("programDateTime")]
    public string? ProgramDateTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("programDateTimeClock")]
    public string? ProgramDateTimeClock { get; set; }

    /// <summary></summary>
    [JsonPropertyName("programDateTimePeriod")]
    public double? ProgramDateTimePeriod { get; set; }

    /// <summary></summary>
    [JsonPropertyName("redundantManifest")]
    public string? RedundantManifest { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentLength")]
    public double? SegmentLength { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentsPerSubdirectory")]
    public double? SegmentsPerSubdirectory { get; set; }

    /// <summary>- Maximum CDI input resolution.</summary>
    [JsonPropertyName("streamInfResolution")]
    public string? StreamInfResolution { get; set; }

    /// <summary>Indicates ID3 frame that has the timecode.</summary>
    [JsonPropertyName("timedMetadataId3Frame")]
    public string? TimedMetadataId3Frame { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timedMetadataId3Period")]
    public double? TimedMetadataId3Period { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestampDeltaMilliseconds")]
    public double? TimestampDeltaMilliseconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tsFileMode")]
    public string? TsFileMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings
{
    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsDestination>? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("acquisitionPointId")]
    public string? AcquisitionPointId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioOnlyTimecodeControl")]
    public string? AudioOnlyTimecodeControl { get; set; }

    /// <summary>Setting to allow self signed or verified RTMP certificates.</summary>
    [JsonPropertyName("certificateMode")]
    public string? CertificateMode { get; set; }

    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestination>? Destination { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("eventId")]
    public string? EventId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventIdMode")]
    public string? EventIdMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventStopBehavior")]
    public string? EventStopBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fragmentLength")]
    public double? FragmentLength { get; set; }

    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentationMode")]
    public string? SegmentationMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sendDelayMs")]
    public double? SendDelayMs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparseTrackType")]
    public string? SparseTrackType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("streamManifestBehavior")]
    public string? StreamManifestBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestampOffset")]
    public string? TimestampOffset { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestampOffsetMode")]
    public string? TimestampOffsetMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsMultiplexGroupSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings
{
    /// <summary>The ad marker type for this output group.</summary>
    [JsonPropertyName("adMarkers")]
    public IList<string>? AdMarkers { get; set; }

    /// <summary>Authentication scheme to use when connecting with CDN.</summary>
    [JsonPropertyName("authenticationScheme")]
    public string? AuthenticationScheme { get; set; }

    /// <summary>Controls behavior when content cache fills up.</summary>
    [JsonPropertyName("cacheFullBehavior")]
    public string? CacheFullBehavior { get; set; }

    /// <summary>Cache length in seconds, is used to calculate buffer size.</summary>
    [JsonPropertyName("cacheLength")]
    public double? CacheLength { get; set; }

    /// <summary>Controls the types of data that passes to onCaptionInfo outputs.</summary>
    [JsonPropertyName("captionData")]
    public string? CaptionData { get; set; }

    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsUdpGroupSettings
{
    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    /// <summary>Indicates ID3 frame that has the timecode.</summary>
    [JsonPropertyName("timedMetadataId3Frame")]
    public string? TimedMetadataId3Frame { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timedMetadataId3Period")]
    public double? TimedMetadataId3Period { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettings
{
    /// <summary>Archive group settings. See Archive Group Settings for more details.</summary>
    [JsonPropertyName("archiveGroupSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettings>? ArchiveGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureGroupSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettings>? FrameCaptureGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsGroupSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings>? HlsGroupSettings { get; set; }

    /// <summary>Media package group settings. See Media Package Group Settings for more details.</summary>
    [JsonPropertyName("mediaPackageGroupSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings>? MediaPackageGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("msSmoothGroupSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings>? MsSmoothGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("multiplexGroupSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsMultiplexGroupSettings>? MultiplexGroupSettings { get; set; }

    /// <summary>RTMP group settings. See RTMP Group Settings for more details.</summary>
    [JsonPropertyName("rtmpGroupSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings>? RtmpGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("udpGroupSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsUdpGroupSettings>? UdpGroupSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("networkId")]
    public double? NetworkId { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("networkName")]
    public string? NetworkName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings
{
    /// <summary></summary>
    [JsonPropertyName("outputSdt")]
    public string? OutputSdt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceProviderName")]
    public string? ServiceProviderName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings
{
    /// <summary></summary>
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettings
{
    /// <summary></summary>
    [JsonPropertyName("absentInputAudioBehavior")]
    public string? AbsentInputAudioBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("arib")]
    public string? Arib { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("aribCaptionsPid")]
    public string? AribCaptionsPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("aribCaptionsPidControl")]
    public string? AribCaptionsPidControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioBufferModel")]
    public string? AudioBufferModel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioFramesPerPes")]
    public double? AudioFramesPerPes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioPids")]
    public string? AudioPids { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioStreamType")]
    public string? AudioStreamType { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bufferModel")]
    public string? BufferModel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ccDescriptor")]
    public string? CcDescriptor { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbNitSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings>? DvbNitSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbSdtSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings>? DvbSdtSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dvbSubPids")]
    public string? DvbSubPids { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbTdtSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings>? DvbTdtSettings { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("dvbTeletextPid")]
    public string? DvbTeletextPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebif")]
    public string? Ebif { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebpAudioInterval")]
    public string? EbpAudioInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebpLookaheadMs")]
    public double? EbpLookaheadMs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebpPlacement")]
    public string? EbpPlacement { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("ecmPid")]
    public string? EcmPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("esRateInPes")]
    public string? EsRateInPes { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvPlatformPid")]
    public string? EtvPlatformPid { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvSignalPid")]
    public string? EtvSignalPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fragmentTime")]
    public double? FragmentTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("klv")]
    public string? Klv { get; set; }

    /// <summary></summary>
    [JsonPropertyName("klvDataPids")]
    public string? KlvDataPids { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("nullPacketBitrate")]
    public double? NullPacketBitrate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patInterval")]
    public double? PatInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pcrControl")]
    public string? PcrControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pcrPeriod")]
    public double? PcrPeriod { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pcrPid")]
    public string? PcrPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pmtInterval")]
    public double? PmtInterval { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pmtPid")]
    public string? PmtPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("programNum")]
    public double? ProgramNum { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rateMode")]
    public string? RateMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scte27Pids")]
    public string? Scte27Pids { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scte35Control")]
    public string? Scte35Control { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public string? Scte35Pid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentationMarkers")]
    public string? SegmentationMarkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentationStyle")]
    public string? SegmentationStyle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentationTime")]
    public double? SegmentationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("timedMetadataPid")]
    public string? TimedMetadataPid { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("transportStreamId")]
    public double? TransportStreamId { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("videoPid")]
    public string? VideoPid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsRawSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettings
{
    /// <summary>M2TS Settings. See M2TS Settings for more details.</summary>
    [JsonPropertyName("m2tsSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettings>? M2tsSettings { get; set; }

    /// <summary>Raw Settings. This can be set as an empty block.</summary>
    [JsonPropertyName("rawSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsRawSettings>? RawSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettings
{
    /// <summary>Settings specific to the container type of the file. See Container Settings for more details.</summary>
    [JsonPropertyName("containerSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettings>? ContainerSettings { get; set; }

    /// <summary>Output file extension.</summary>
    [JsonPropertyName("extension")]
    public string? Extension { get; set; }

    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsFrameCaptureOutputSettings
{
    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettingsAudioOnlyImage
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>–  Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettings
{
    /// <summary>Specifies the GROUP-ID in the #EXT-X-MEDIA tag of the target HLS audio rendition.</summary>
    [JsonPropertyName("audioGroupId")]
    public string? AudioGroupId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioOnlyImage")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettingsAudioOnlyImage>? AudioOnlyImage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioTrackType")]
    public string? AudioTrackType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentType")]
    public string? SegmentType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFmp4HlsSettings
{
    /// <summary></summary>
    [JsonPropertyName("audioRenditionSets")]
    public string? AudioRenditionSets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFrameCaptureHlsSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3u8Settings
{
    /// <summary></summary>
    [JsonPropertyName("audioFramesPerPes")]
    public double? AudioFramesPerPes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioPids")]
    public string? AudioPids { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("ecmPid")]
    public string? EcmPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patInterval")]
    public double? PatInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pcrControl")]
    public string? PcrControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pcrPeriod")]
    public double? PcrPeriod { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pcrPid")]
    public string? PcrPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pmtInterval")]
    public double? PmtInterval { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pmtPid")]
    public string? PmtPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("programNum")]
    public double? ProgramNum { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scte35Behavior")]
    public string? Scte35Behavior { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public string? Scte35Pid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("timedMetadataPid")]
    public string? TimedMetadataPid { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("transportStreamId")]
    public double? TransportStreamId { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("videoPid")]
    public string? VideoPid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettings
{
    /// <summary></summary>
    [JsonPropertyName("audioRenditionSets")]
    public string? AudioRenditionSets { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("m3u8Settings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3u8Settings>? M3u8Settings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("audioOnlyHlsSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettings>? AudioOnlyHlsSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("fmp4HlsSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFmp4HlsSettings>? Fmp4HlsSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureHlsSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFrameCaptureHlsSettings>? FrameCaptureHlsSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("standardHlsSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettings>? StandardHlsSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettings
{
    /// <summary></summary>
    [JsonPropertyName("h265PackagingType")]
    public string? H265PackagingType { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettings>? HlsSettings { get; set; }

    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentModifier")]
    public string? SegmentModifier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMediaPackageOutputSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMsSmoothOutputSettings
{
    /// <summary></summary>
    [JsonPropertyName("h265PackagingType")]
    public string? H265PackagingType { get; set; }

    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettings
{
    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettingsDestination>? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettings
{
    /// <summary>Setting to allow self signed or verified RTMP certificates.</summary>
    [JsonPropertyName("certificateMode")]
    public string? CertificateMode { get; set; }

    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsDestination>? Destination { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("networkId")]
    public double? NetworkId { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("networkName")]
    public string? NetworkName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings
{
    /// <summary></summary>
    [JsonPropertyName("outputSdt")]
    public string? OutputSdt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceProviderName")]
    public string? ServiceProviderName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings
{
    /// <summary></summary>
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettings
{
    /// <summary></summary>
    [JsonPropertyName("absentInputAudioBehavior")]
    public string? AbsentInputAudioBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("arib")]
    public string? Arib { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("aribCaptionsPid")]
    public string? AribCaptionsPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("aribCaptionsPidControl")]
    public string? AribCaptionsPidControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioBufferModel")]
    public string? AudioBufferModel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioFramesPerPes")]
    public double? AudioFramesPerPes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioPids")]
    public string? AudioPids { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioStreamType")]
    public string? AudioStreamType { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bufferModel")]
    public string? BufferModel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ccDescriptor")]
    public string? CcDescriptor { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbNitSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings>? DvbNitSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbSdtSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings>? DvbSdtSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dvbSubPids")]
    public string? DvbSubPids { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbTdtSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings>? DvbTdtSettings { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("dvbTeletextPid")]
    public string? DvbTeletextPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebif")]
    public string? Ebif { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebpAudioInterval")]
    public string? EbpAudioInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebpLookaheadMs")]
    public double? EbpLookaheadMs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebpPlacement")]
    public string? EbpPlacement { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("ecmPid")]
    public string? EcmPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("esRateInPes")]
    public string? EsRateInPes { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvPlatformPid")]
    public string? EtvPlatformPid { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvSignalPid")]
    public string? EtvSignalPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fragmentTime")]
    public double? FragmentTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("klv")]
    public string? Klv { get; set; }

    /// <summary></summary>
    [JsonPropertyName("klvDataPids")]
    public string? KlvDataPids { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("nullPacketBitrate")]
    public double? NullPacketBitrate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patInterval")]
    public double? PatInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pcrControl")]
    public string? PcrControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pcrPeriod")]
    public double? PcrPeriod { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pcrPid")]
    public string? PcrPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pmtInterval")]
    public double? PmtInterval { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pmtPid")]
    public string? PmtPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("programNum")]
    public double? ProgramNum { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rateMode")]
    public string? RateMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scte27Pids")]
    public string? Scte27Pids { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scte35Control")]
    public string? Scte35Control { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public string? Scte35Pid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentationMarkers")]
    public string? SegmentationMarkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentationStyle")]
    public string? SegmentationStyle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentationTime")]
    public double? SegmentationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("timedMetadataPid")]
    public string? TimedMetadataPid { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("transportStreamId")]
    public double? TransportStreamId { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("videoPid")]
    public string? VideoPid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettings
{
    /// <summary>M2TS Settings. See M2TS Settings for more details.</summary>
    [JsonPropertyName("m2tsSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettings>? M2tsSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsFecOutputSettings
{
    /// <summary>The height of the FEC protection matrix.</summary>
    [JsonPropertyName("columnDepth")]
    public double? ColumnDepth { get; set; }

    /// <summary>Enables column only or column and row based FEC.</summary>
    [JsonPropertyName("includeFec")]
    public string? IncludeFec { get; set; }

    /// <summary>The width of the FEC protection matrix.</summary>
    [JsonPropertyName("rowLength")]
    public double? RowLength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettings
{
    /// <summary>UDP output buffering in milliseconds.</summary>
    [JsonPropertyName("bufferMsec")]
    public double? BufferMsec { get; set; }

    /// <summary>Settings specific to the container type of the file. See Container Settings for more details.</summary>
    [JsonPropertyName("containerSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettings>? ContainerSettings { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsDestination>? Destination { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("fecOutputSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsFecOutputSettings>? FecOutputSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettings
{
    /// <summary>Archive output settings. See Archive Output Settings for more details.</summary>
    [JsonPropertyName("archiveOutputSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettings>? ArchiveOutputSettings { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("frameCaptureOutputSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsFrameCaptureOutputSettings>? FrameCaptureOutputSettings { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("hlsOutputSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettings>? HlsOutputSettings { get; set; }

    /// <summary>Media package output settings. This can be set as an empty block.</summary>
    [JsonPropertyName("mediaPackageOutputSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMediaPackageOutputSettings>? MediaPackageOutputSettings { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("msSmoothOutputSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMsSmoothOutputSettings>? MsSmoothOutputSettings { get; set; }

    /// <summary>Multiplex output settings. See Multiplex Output Settings for more details.</summary>
    [JsonPropertyName("multiplexOutputSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettings>? MultiplexOutputSettings { get; set; }

    /// <summary>RTMP output settings. See RTMP Output Settings for more details.</summary>
    [JsonPropertyName("rtmpOutputSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettings>? RtmpOutputSettings { get; set; }

    /// <summary>UDP output settings. See UDP Output Settings for more details.</summary>
    [JsonPropertyName("udpOutputSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettings>? UdpOutputSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputs
{
    /// <summary>The names of the audio descriptions used as audio sources for the output.</summary>
    [JsonPropertyName("audioDescriptionNames")]
    public IList<string>? AudioDescriptionNames { get; set; }

    /// <summary>The names of the caption descriptions used as caption sources for the output.</summary>
    [JsonPropertyName("captionDescriptionNames")]
    public IList<string>? CaptionDescriptionNames { get; set; }

    /// <summary>The name used to identify an output.</summary>
    [JsonPropertyName("outputName")]
    public string? OutputName { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("outputSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettings>? OutputSettings { get; set; }

    /// <summary>The name of the video description used as video source for the output.</summary>
    [JsonPropertyName("videoDescriptionName")]
    public string? VideoDescriptionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsOutputGroups
{
    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Settings associated with the output group. See Output Group Settings for more details.</summary>
    [JsonPropertyName("outputGroupSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettings>? OutputGroupSettings { get; set; }

    /// <summary>List of outputs. See Outputs for more details.</summary>
    [JsonPropertyName("outputs")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroupsOutputs>? Outputs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsTimecodeConfig
{
    /// <summary>The source for the timecode that will be associated with the events outputs.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Threshold in frames beyond which output timecode is resynchronized to the input timecode.</summary>
    [JsonPropertyName("syncThreshold")]
    public double? SyncThreshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings
{
    /// <summary>The frequency at which to capture frames for inclusion in the output.</summary>
    [JsonPropertyName("captureInterval")]
    public double? CaptureInterval { get; set; }

    /// <summary>Unit for the frame capture interval.</summary>
    [JsonPropertyName("captureIntervalUnits")]
    public string? CaptureIntervalUnits { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettingsTemporalFilterSettings
{
    /// <summary>Post filter sharpening.</summary>
    [JsonPropertyName("postFilterSharpening")]
    public string? PostFilterSharpening { get; set; }

    /// <summary>Filter strength.</summary>
    [JsonPropertyName("strength")]
    public string? Strength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettings
{
    /// <summary>Temporal filter settings. See Temporal Filter Settings</summary>
    [JsonPropertyName("temporalFilterSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettingsTemporalFilterSettings>? TemporalFilterSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH264Settings
{
    /// <summary>Enables or disables adaptive quantization.</summary>
    [JsonPropertyName("adaptiveQuantization")]
    public string? AdaptiveQuantization { get; set; }

    /// <summary>Indicates that AFD values will be written into the output stream.</summary>
    [JsonPropertyName("afdSignaling")]
    public string? AfdSignaling { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bufFillPct")]
    public double? BufFillPct { get; set; }

    /// <summary>Size of buffer in bits.</summary>
    [JsonPropertyName("bufSize")]
    public double? BufSize { get; set; }

    /// <summary>Includes color space metadata in the output.</summary>
    [JsonPropertyName("colorMetadata")]
    public string? ColorMetadata { get; set; }

    /// <summary>Entropy encoding mode.</summary>
    [JsonPropertyName("entropyEncoding")]
    public string? EntropyEncoding { get; set; }

    /// <summary>Filters to apply to an encode. See H264 Filter Settings for more details.</summary>
    [JsonPropertyName("filterSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettings>? FilterSettings { get; set; }

    /// <summary>Four bit AFD value to write on all frames of video in the output stream.</summary>
    [JsonPropertyName("fixedAfd")]
    public string? FixedAfd { get; set; }

    /// <summary></summary>
    [JsonPropertyName("flickerAq")]
    public string? FlickerAq { get; set; }

    /// <summary>Controls whether coding is performed on a field basis or on a frame basis.</summary>
    [JsonPropertyName("forceFieldPictures")]
    public string? ForceFieldPictures { get; set; }

    /// <summary>Indicates how the output video frame rate is specified.</summary>
    [JsonPropertyName("framerateControl")]
    public string? FramerateControl { get; set; }

    /// <summary>Framerate denominator.</summary>
    [JsonPropertyName("framerateDenominator")]
    public double? FramerateDenominator { get; set; }

    /// <summary>Framerate numerator.</summary>
    [JsonPropertyName("framerateNumerator")]
    public double? FramerateNumerator { get; set; }

    /// <summary>GOP-B reference.</summary>
    [JsonPropertyName("gopBReference")]
    public string? GopBReference { get; set; }

    /// <summary>Frequency of closed GOPs.</summary>
    [JsonPropertyName("gopClosedCadence")]
    public double? GopClosedCadence { get; set; }

    /// <summary>Number of B-frames between reference frames.</summary>
    [JsonPropertyName("gopNumBFrames")]
    public double? GopNumBFrames { get; set; }

    /// <summary>GOP size in units of either frames of seconds per gop_size_units.</summary>
    [JsonPropertyName("gopSize")]
    public double? GopSize { get; set; }

    /// <summary>Indicates if the gop_size is specified in frames or seconds.</summary>
    [JsonPropertyName("gopSizeUnits")]
    public string? GopSizeUnits { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Amount of lookahead.</summary>
    [JsonPropertyName("lookAheadRateControl")]
    public string? LookAheadRateControl { get; set; }

    /// <summary>Set the maximum bitrate in order to accommodate expected spikes in the complexity of the video.</summary>
    [JsonPropertyName("maxBitrate")]
    public double? MaxBitrate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minIInterval")]
    public double? MinIInterval { get; set; }

    /// <summary>Number of reference frames to use.</summary>
    [JsonPropertyName("numRefFrames")]
    public double? NumRefFrames { get; set; }

    /// <summary>Indicates how the output pixel aspect ratio is specified.</summary>
    [JsonPropertyName("parControl")]
    public string? ParControl { get; set; }

    /// <summary>Pixel Aspect Ratio denominator.</summary>
    [JsonPropertyName("parDenominator")]
    public double? ParDenominator { get; set; }

    /// <summary>Pixel Aspect Ratio numerator.</summary>
    [JsonPropertyName("parNumerator")]
    public double? ParNumerator { get; set; }

    /// <summary>AAC profile.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>Quality level.</summary>
    [JsonPropertyName("qualityLevel")]
    public string? QualityLevel { get; set; }

    /// <summary>Controls the target quality for the video encode.</summary>
    [JsonPropertyName("qvbrQualityLevel")]
    public double? QvbrQualityLevel { get; set; }

    /// <summary>The rate control mode.</summary>
    [JsonPropertyName("rateControlMode")]
    public string? RateControlMode { get; set; }

    /// <summary>Sets the scan type of the output.</summary>
    [JsonPropertyName("scanType")]
    public string? ScanType { get; set; }

    /// <summary>Scene change detection.</summary>
    [JsonPropertyName("sceneChangeDetect")]
    public string? SceneChangeDetect { get; set; }

    /// <summary>Number of slices per picture.</summary>
    [JsonPropertyName("slices")]
    public double? Slices { get; set; }

    /// <summary>Softness.</summary>
    [JsonPropertyName("softness")]
    public double? Softness { get; set; }

    /// <summary>Makes adjustments within each frame based on spatial variation of content complexity.</summary>
    [JsonPropertyName("spatialAq")]
    public string? SpatialAq { get; set; }

    /// <summary>Subgop length.</summary>
    [JsonPropertyName("subgopLength")]
    public string? SubgopLength { get; set; }

    /// <summary>Produces a bitstream compliant with SMPTE RP-2027.</summary>
    [JsonPropertyName("syntax")]
    public string? Syntax { get; set; }

    /// <summary>Makes adjustments within each frame based on temporal variation of content complexity.</summary>
    [JsonPropertyName("temporalAq")]
    public string? TemporalAq { get; set; }

    /// <summary>Determines how timecodes should be inserted into the video elementary stream.</summary>
    [JsonPropertyName("timecodeInsertion")]
    public string? TimecodeInsertion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsColorSpacePassthroughSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsDolbyVision81Settings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsHdr10Settings
{
    /// <summary>Sets the MaxCLL value for HDR10.</summary>
    [JsonPropertyName("maxCll")]
    public double? MaxCll { get; set; }

    /// <summary>Sets the MaxFALL value for HDR10.</summary>
    [JsonPropertyName("maxFall")]
    public double? MaxFall { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec601Settings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec709Settings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettings
{
    /// <summary>Sets the colorspace metadata to be passed through.</summary>
    [JsonPropertyName("colorSpacePassthroughSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsColorSpacePassthroughSettings>? ColorSpacePassthroughSettings { get; set; }

    /// <summary>Set the colorspace to Dolby Vision81.</summary>
    [JsonPropertyName("dolbyVision81Settings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsDolbyVision81Settings>? DolbyVision81Settings { get; set; }

    /// <summary>Set the colorspace to be HDR10. See H265 HDR10 Settings for more details.</summary>
    [JsonPropertyName("hdr10Settings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsHdr10Settings>? Hdr10Settings { get; set; }

    /// <summary>Set the colorspace to Rec. 601.</summary>
    [JsonPropertyName("rec601Settings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec601Settings>? Rec601Settings { get; set; }

    /// <summary>Set the colorspace to Rec. 709.</summary>
    [JsonPropertyName("rec709Settings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec709Settings>? Rec709Settings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettingsTemporalFilterSettings
{
    /// <summary>Post filter sharpening.</summary>
    [JsonPropertyName("postFilterSharpening")]
    public string? PostFilterSharpening { get; set; }

    /// <summary>Filter strength.</summary>
    [JsonPropertyName("strength")]
    public string? Strength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettings
{
    /// <summary>Temporal filter settings. See Temporal Filter Settings</summary>
    [JsonPropertyName("temporalFilterSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettingsTemporalFilterSettings>? TemporalFilterSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsTimecodeBurninSettings
{
    /// <summary>Set a prefix on the burned in timecode.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Sets the size of the burned in timecode.</summary>
    [JsonPropertyName("timecodeBurninFontSize")]
    public string? TimecodeBurninFontSize { get; set; }

    /// <summary>Sets the position of the burned in timecode.</summary>
    [JsonPropertyName("timecodeBurninPosition")]
    public string? TimecodeBurninPosition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265Settings
{
    /// <summary>Enables or disables adaptive quantization.</summary>
    [JsonPropertyName("adaptiveQuantization")]
    public string? AdaptiveQuantization { get; set; }

    /// <summary>Indicates that AFD values will be written into the output stream.</summary>
    [JsonPropertyName("afdSignaling")]
    public string? AfdSignaling { get; set; }

    /// <summary>Whether or not EML should insert an Alternative Transfer Function SEI message.</summary>
    [JsonPropertyName("alternativeTransferFunction")]
    public string? AlternativeTransferFunction { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Size of buffer in bits.</summary>
    [JsonPropertyName("bufSize")]
    public double? BufSize { get; set; }

    /// <summary>Includes color space metadata in the output.</summary>
    [JsonPropertyName("colorMetadata")]
    public string? ColorMetadata { get; set; }

    /// <summary>Define the color metadata for the output. H265 Color Space Settings for more details.</summary>
    [JsonPropertyName("colorSpaceSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettings>? ColorSpaceSettings { get; set; }

    /// <summary>Filters to apply to an encode. See H264 Filter Settings for more details.</summary>
    [JsonPropertyName("filterSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettings>? FilterSettings { get; set; }

    /// <summary>Four bit AFD value to write on all frames of video in the output stream.</summary>
    [JsonPropertyName("fixedAfd")]
    public string? FixedAfd { get; set; }

    /// <summary></summary>
    [JsonPropertyName("flickerAq")]
    public string? FlickerAq { get; set; }

    /// <summary>Framerate denominator.</summary>
    [JsonPropertyName("framerateDenominator")]
    public double? FramerateDenominator { get; set; }

    /// <summary>Framerate numerator.</summary>
    [JsonPropertyName("framerateNumerator")]
    public double? FramerateNumerator { get; set; }

    /// <summary>Frequency of closed GOPs.</summary>
    [JsonPropertyName("gopClosedCadence")]
    public double? GopClosedCadence { get; set; }

    /// <summary>GOP size in units of either frames of seconds per gop_size_units.</summary>
    [JsonPropertyName("gopSize")]
    public double? GopSize { get; set; }

    /// <summary>Indicates if the gop_size is specified in frames or seconds.</summary>
    [JsonPropertyName("gopSizeUnits")]
    public string? GopSizeUnits { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Amount of lookahead.</summary>
    [JsonPropertyName("lookAheadRateControl")]
    public string? LookAheadRateControl { get; set; }

    /// <summary>Set the maximum bitrate in order to accommodate expected spikes in the complexity of the video.</summary>
    [JsonPropertyName("maxBitrate")]
    public double? MaxBitrate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minIInterval")]
    public double? MinIInterval { get; set; }

    /// <summary>Pixel Aspect Ratio denominator.</summary>
    [JsonPropertyName("parDenominator")]
    public double? ParDenominator { get; set; }

    /// <summary>Pixel Aspect Ratio numerator.</summary>
    [JsonPropertyName("parNumerator")]
    public double? ParNumerator { get; set; }

    /// <summary>AAC profile.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>Controls the target quality for the video encode.</summary>
    [JsonPropertyName("qvbrQualityLevel")]
    public double? QvbrQualityLevel { get; set; }

    /// <summary>The rate control mode.</summary>
    [JsonPropertyName("rateControlMode")]
    public string? RateControlMode { get; set; }

    /// <summary>Sets the scan type of the output.</summary>
    [JsonPropertyName("scanType")]
    public string? ScanType { get; set; }

    /// <summary>Scene change detection.</summary>
    [JsonPropertyName("sceneChangeDetect")]
    public string? SceneChangeDetect { get; set; }

    /// <summary>Number of slices per picture.</summary>
    [JsonPropertyName("slices")]
    public double? Slices { get; set; }

    /// <summary>Set the H265 tier in the output.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>Apply a burned in timecode. See H265 Timecode Burnin Settings for more details.</summary>
    [JsonPropertyName("timecodeBurninSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsTimecodeBurninSettings>? TimecodeBurninSettings { get; set; }

    /// <summary>Determines how timecodes should be inserted into the video elementary stream.</summary>
    [JsonPropertyName("timecodeInsertion")]
    public string? TimecodeInsertion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettings
{
    /// <summary>Frame capture settings. See Frame Capture Settings for more details.</summary>
    [JsonPropertyName("frameCaptureSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings>? FrameCaptureSettings { get; set; }

    /// <summary>H264 settings. See H264 Settings for more details.</summary>
    [JsonPropertyName("h264Settings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH264Settings>? H264Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("h265Settings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265Settings>? H265Settings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptions
{
    /// <summary>Audio codec settings. See Audio Codec Settings for more details.</summary>
    [JsonPropertyName("codecSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettings>? CodecSettings { get; set; }

    /// <summary>See the description in left_offset. For height, specify the entire height of the rectangle as a percentage of the underlying frame height. For example, "80" means the rectangle height is 80% of the underlying frame height. The top_offset and rectangle_height must add up to 100% or less. This field corresponds to tts:extent - Y in the TTML standard.</summary>
    [JsonPropertyName("height")]
    public double? Height { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Indicate how to respond to the AFD values that might be in the input video.</summary>
    [JsonPropertyName("respondToAfd")]
    public string? RespondToAfd { get; set; }

    /// <summary>Behavior on how to scale.</summary>
    [JsonPropertyName("scalingBehavior")]
    public string? ScalingBehavior { get; set; }

    /// <summary>Changes the strength of the anti-alias filter used for scaling.</summary>
    [JsonPropertyName("sharpness")]
    public double? Sharpness { get; set; }

    /// <summary>See the description in left_offset. For width, specify the entire width of the rectangle as a percentage of the underlying frame width. For example, "80" means the rectangle width is 80% of the underlying frame width. The left_offset and rectangle_width must add up to 100% or less. This field corresponds to tts:extent - X in the TTML standard.</summary>
    [JsonPropertyName("width")]
    public double? Width { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderEncoderSettings
{
    /// <summary>Audio descriptions for the channel. See Audio Descriptions for more details.</summary>
    [JsonPropertyName("audioDescriptions")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsAudioDescriptions>? AudioDescriptions { get; set; }

    /// <summary>Settings for ad avail blanking. See Avail Blanking for more details.</summary>
    [JsonPropertyName("availBlanking")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsAvailBlanking>? AvailBlanking { get; set; }

    /// <summary>Caption Descriptions. See Caption Descriptions for more details.</summary>
    [JsonPropertyName("captionDescriptions")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsCaptionDescriptions>? CaptionDescriptions { get; set; }

    /// <summary>Configuration settings that apply to the event as a whole. See Global Configuration for more details.</summary>
    [JsonPropertyName("globalConfiguration")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsGlobalConfiguration>? GlobalConfiguration { get; set; }

    /// <summary>Settings for motion graphics. See Motion Graphics Configuration for more details.</summary>
    [JsonPropertyName("motionGraphicsConfiguration")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsMotionGraphicsConfiguration>? MotionGraphicsConfiguration { get; set; }

    /// <summary>Nielsen configuration settings. See Nielsen Configuration for more details.</summary>
    [JsonPropertyName("nielsenConfiguration")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsNielsenConfiguration>? NielsenConfiguration { get; set; }

    /// <summary>Output groups for the channel. See Output Groups for more details.</summary>
    [JsonPropertyName("outputGroups")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsOutputGroups>? OutputGroups { get; set; }

    /// <summary>Contains settings used to acquire and adjust timecode information from inputs. See Timecode Config for more details.</summary>
    [JsonPropertyName("timecodeConfig")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsTimecodeConfig>? TimecodeConfig { get; set; }

    /// <summary>Video Descriptions. See Video Descriptions for more details.</summary>
    [JsonPropertyName("videoDescriptions")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettingsVideoDescriptions>? VideoDescriptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings
{
    /// <summary>The name of the audio selector in the input that MediaLive should monitor to detect silence. Select your most important rendition. If you didn't create an audio selector in this input, leave blank.</summary>
    [JsonPropertyName("audioSelectorName")]
    public string? AudioSelectorName { get; set; }

    /// <summary>The amount of time (in milliseconds) that the active input must be silent before automatic input failover occurs. Silence is defined as audio loss or audio quieter than -50 dBFS.</summary>
    [JsonPropertyName("audioSilenceThresholdMsec")]
    public double? AudioSilenceThresholdMsec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsInputLossSettings
{
    /// <summary>The amount of time (in milliseconds) that no input is detected. After that time, an input failover will occur.</summary>
    [JsonPropertyName("inputLossThresholdMsec")]
    public double? InputLossThresholdMsec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsVideoBlackSettings
{
    /// <summary>A value used in calculating the threshold below which MediaLive considers a pixel to be 'black'. For the input to be considered black, every pixel in a frame must be below this threshold. The threshold is calculated as a percentage (expressed as a decimal) of white. Therefore .1 means 10% white (or 90% black). Note how the formula works for any color depth. For example, if you set this field to 0.1 in 10-bit color depth: (10230.1=102.3), which means a pixel value of 102 or less is 'black'. If you set this field to .1 in an 8-bit color depth: (2550.1=25.5), which means a pixel value of 25 or less is 'black'. The range is 0.0 to 1.0, with any number of decimal places.</summary>
    [JsonPropertyName("blackDetectThreshold")]
    public double? BlackDetectThreshold { get; set; }

    /// <summary>The amount of time (in milliseconds) that the active input must be black before automatic input failover occurs.</summary>
    [JsonPropertyName("videoBlackThresholdMsec")]
    public double? VideoBlackThresholdMsec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettings
{
    /// <summary>MediaLive will perform a failover if the specified audio selector is silent for the specified period. See Audio Silence Failover Settings for more details.</summary>
    [JsonPropertyName("audioSilenceSettings")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings>? AudioSilenceSettings { get; set; }

    /// <summary>MediaLive will perform a failover if content is not detected in this input for the specified period. See Input Loss Failover Settings for more details.</summary>
    [JsonPropertyName("inputLossSettings")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsInputLossSettings>? InputLossSettings { get; set; }

    /// <summary>MediaLive will perform a failover if content is considered black for the specified period. See Video Black Failover Settings for more details.</summary>
    [JsonPropertyName("videoBlackSettings")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsVideoBlackSettings>? VideoBlackSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverCondition
{
    /// <summary>Failover condition type-specific settings. See Failover Condition Settings for more details.</summary>
    [JsonPropertyName("failoverConditionSettings")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettings>? FailoverConditionSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettings
{
    /// <summary>This clear time defines the requirement a recovered input must meet to be considered healthy. The input must have no failover conditions for this length of time. Enter a time in milliseconds. This value is particularly important if the input_preference for the failover pair is set to PRIMARY_INPUT_PREFERRED, because after this time, MediaLive will switch back to the primary input.</summary>
    [JsonPropertyName("errorClearTimeMsec")]
    public double? ErrorClearTimeMsec { get; set; }

    /// <summary>A list of failover conditions. If any of these conditions occur, MediaLive will perform a failover to the other input. See Failover Condition Block for more details.</summary>
    [JsonPropertyName("failoverCondition")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverCondition>? FailoverCondition { get; set; }

    /// <summary>Input preference when deciding which input to make active when a previously failed input has recovered.</summary>
    [JsonPropertyName("inputPreference")]
    public string? InputPreference { get; set; }

    /// <summary>The input ID of the secondary input in the automatic input failover pair.</summary>
    [JsonPropertyName("secondaryInputId")]
    public string? SecondaryInputId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Input in medialive to populate inputId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ChannelSpecForProviderInputAttachmentsInputIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Input in medialive to populate inputId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ChannelSpecForProviderInputAttachmentsInputIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioHlsRenditionSelection
{
    /// <summary>Specifies the GROUP-ID in the #EXT-X-MEDIA tag of the target HLS audio rendition.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection
{
    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>When set to “strict”, the transport stream demux strictly identifies audio streams by their language descriptor. If a PMT update occurs such that an audio stream matching the initially selected language is no longer present then mute will be encoded until the language returns. If “loose”, then on a PMT update the demux will choose another audio stream in the program with the same stream type if it can’t find one with the same language.</summary>
    [JsonPropertyName("languageSelectionPolicy")]
    public string? LanguageSelectionPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioPidSelection
{
    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pid")]
    public double? Pid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionDolbyEDecode
{
    /// <summary>Applies only to Dolby E. Enter the program ID (according to the metadata in the audio) of the Dolby E program to extract from the specified track. One program extracted per audio selector. To select multiple programs, create multiple selectors with the same Track and different Program numbers. “All channels” means to ignore the program IDs and include all the channels in this selector; useful if metadata is known to be incorrect.</summary>
    [JsonPropertyName("programSelection")]
    public string? ProgramSelection { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionTracks
{
    /// <summary>1-based integer value that maps to a specific audio track.</summary>
    [JsonPropertyName("track")]
    public double? Track { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelection
{
    /// <summary>Configure decoding options for Dolby E streams - these should be Dolby E frames carried in PCM streams tagged with SMPTE-337. See Dolby E Decode for more details.</summary>
    [JsonPropertyName("dolbyEDecode")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionDolbyEDecode>? DolbyEDecode { get; set; }

    /// <summary>Selects one or more unique audio tracks from within a source. See Audio Tracks for more details.</summary>
    [JsonPropertyName("tracks")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionTracks>? Tracks { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettings
{
    /// <summary>Audio HLS Rendition Selection. See Audio HLS Rendition Selection for more details.</summary>
    [JsonPropertyName("audioHlsRenditionSelection")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioHlsRenditionSelection>? AudioHlsRenditionSelection { get; set; }

    /// <summary>Audio Language Selection. See Audio Language Selection for more details.</summary>
    [JsonPropertyName("audioLanguageSelection")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection>? AudioLanguageSelection { get; set; }

    /// <summary>Audio Pid Selection. See Audio PID Selection for more details.</summary>
    [JsonPropertyName("audioPidSelection")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioPidSelection>? AudioPidSelection { get; set; }

    /// <summary>Audio Track Selection. See Audio Track Selection for more details.</summary>
    [JsonPropertyName("audioTrackSelection")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelection>? AudioTrackSelection { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelector
{
    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The audio selector settings. See Audio Selector Settings for more details.</summary>
    [JsonPropertyName("selectorSettings")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettings>? SelectorSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAncillarySourceSettings
{
    /// <summary>Specifies the number (1 to 4) of the captions channel you want to extract from the ancillary captions. If you plan to convert the ancillary captions to another format, complete this field. If you plan to choose Embedded as the captions destination in the output (to pass through all the channels in the ancillary captions), leave this field blank because MediaLive ignores the field.</summary>
    [JsonPropertyName("sourceAncillaryChannelNumber")]
    public double? SourceAncillaryChannelNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAribSourceSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsDvbSubSourceSettings
{
    /// <summary>If you will configure a WebVTT caption description that references this caption selector, use this field to provide the language to consider when translating the image-based source to text.</summary>
    [JsonPropertyName("ocrLanguage")]
    public string? OcrLanguage { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pid")]
    public double? Pid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsEmbeddedSourceSettings
{
    /// <summary>If upconvert, 608 data is both passed through via the “608 compatibility bytes” fields of the 708 wrapper as well as translated into 708. 708 data present in the source content will be discarded.</summary>
    [JsonPropertyName("convert608To708")]
    public string? Convert608To708 { get; set; }

    /// <summary>Set to “auto” to handle streams with intermittent and/or non-aligned SCTE-20 and Embedded captions.</summary>
    [JsonPropertyName("scte20Detection")]
    public string? Scte20Detection { get; set; }

    /// <summary>Specifies the 608/708 channel number within the video track from which to extract captions. Unused for passthrough.</summary>
    [JsonPropertyName("source608ChannelNumber")]
    public double? Source608ChannelNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte20SourceSettings
{
    /// <summary>If upconvert, 608 data is both passed through via the “608 compatibility bytes” fields of the 708 wrapper as well as translated into 708. 708 data present in the source content will be discarded.</summary>
    [JsonPropertyName("convert608To708")]
    public string? Convert608To708 { get; set; }

    /// <summary>Specifies the 608/708 channel number within the video track from which to extract captions. Unused for passthrough.</summary>
    [JsonPropertyName("source608ChannelNumber")]
    public double? Source608ChannelNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte27SourceSettings
{
    /// <summary>If you will configure a WebVTT caption description that references this caption selector, use this field to provide the language to consider when translating the image-based source to text.</summary>
    [JsonPropertyName("ocrLanguage")]
    public string? OcrLanguage { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pid")]
    public double? Pid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle
{
    /// <summary>See the description in left_offset. For height, specify the entire height of the rectangle as a percentage of the underlying frame height. For example, "80" means the rectangle height is 80% of the underlying frame height. The top_offset and rectangle_height must add up to 100% or less. This field corresponds to tts:extent - Y in the TTML standard.</summary>
    [JsonPropertyName("height")]
    public double? Height { get; set; }

    /// <summary>Applies only if you plan to convert these source captions to EBU-TT-D or TTML in an output. (Make sure to leave the default if you don’t have either of these formats in the output.) You can define a display rectangle for the captions that is smaller than the underlying video frame. You define the rectangle by specifying the position of the left edge, top edge, bottom edge, and right edge of the rectangle, all within the underlying video frame. The units for the measurements are percentages. If you specify a value for one of these fields, you must specify a value for all of them. For leftOffset, specify the position of the left edge of the rectangle, as a percentage of the underlying frame width, and relative to the left edge of the frame. For example, "10" means the measurement is 10% of the underlying frame width. The rectangle left edge starts at that position from the left edge of the frame. This field corresponds to tts:origin - X in the TTML standard.</summary>
    [JsonPropertyName("leftOffset")]
    public double? LeftOffset { get; set; }

    /// <summary>See the description in left_offset. For top_offset, specify the position of the top edge of the rectangle, as a percentage of the underlying frame height, and relative to the top edge of the frame. For example, "10" means the measurement is 10% of the underlying frame height. The rectangle top edge starts at that position from the top edge of the frame. This field corresponds to tts:origin - Y in the TTML standard.</summary>
    [JsonPropertyName("topOffset")]
    public double? TopOffset { get; set; }

    /// <summary>See the description in left_offset. For width, specify the entire width of the rectangle as a percentage of the underlying frame width. For example, "80" means the rectangle width is 80% of the underlying frame width. The left_offset and rectangle_width must add up to 100% or less. This field corresponds to tts:extent - X in the TTML standard.</summary>
    [JsonPropertyName("width")]
    public double? Width { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettings
{
    /// <summary>Optionally defines a region where TTML style captions will be displayed. See Caption Rectangle for more details.</summary>
    [JsonPropertyName("outputRectangle")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle>? OutputRectangle { get; set; }

    /// <summary>Specifies the teletext page number within the data stream from which to extract captions. Range of 0x100 (256) to 0x8FF (2303). Unused for passthrough. Should be specified as a hexadecimal string with no “0x” prefix.</summary>
    [JsonPropertyName("pageNumber")]
    public string? PageNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettings
{
    /// <summary>Ancillary Source Settings. See Ancillary Source Settings for more details.</summary>
    [JsonPropertyName("ancillarySourceSettings")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAncillarySourceSettings>? AncillarySourceSettings { get; set; }

    /// <summary>ARIB Source Settings.</summary>
    [JsonPropertyName("aribSourceSettings")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAribSourceSettings>? AribSourceSettings { get; set; }

    /// <summary>DVB Sub Source Settings. See DVB Sub Source Settings for more details.</summary>
    [JsonPropertyName("dvbSubSourceSettings")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsDvbSubSourceSettings>? DvbSubSourceSettings { get; set; }

    /// <summary>Embedded Source Settings. See Embedded Source Settings for more details.</summary>
    [JsonPropertyName("embeddedSourceSettings")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsEmbeddedSourceSettings>? EmbeddedSourceSettings { get; set; }

    /// <summary>SCTE20 Source Settings. See SCTE 20 Source Settings for more details.</summary>
    [JsonPropertyName("scte20SourceSettings")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte20SourceSettings>? Scte20SourceSettings { get; set; }

    /// <summary>SCTE27 Source Settings. See SCTE 27 Source Settings for more details.</summary>
    [JsonPropertyName("scte27SourceSettings")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte27SourceSettings>? Scte27SourceSettings { get; set; }

    /// <summary>Teletext Source Settings. See Teletext Source Settings for more details.</summary>
    [JsonPropertyName("teletextSourceSettings")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettings>? TeletextSourceSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelector
{
    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The audio selector settings. See Audio Selector Settings for more details.</summary>
    [JsonPropertyName("selectorSettings")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettings>? SelectorSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsNetworkInputSettingsHlsInputSettings
{
    /// <summary>The bitrate is specified in bits per second, as in an HLS manifest.</summary>
    [JsonPropertyName("bandwidth")]
    public double? Bandwidth { get; set; }

    /// <summary>Buffer segments.</summary>
    [JsonPropertyName("bufferSegments")]
    public double? BufferSegments { get; set; }

    /// <summary>The number of consecutive times that attempts to read a manifest or segment must fail before the input is considered unavailable.</summary>
    [JsonPropertyName("retries")]
    public double? Retries { get; set; }

    /// <summary>The number of seconds between retries when an attempt to read a manifest or segment fails.</summary>
    [JsonPropertyName("retryInterval")]
    public double? RetryInterval { get; set; }

    /// <summary>The source for the timecode that will be associated with the events outputs.</summary>
    [JsonPropertyName("scte35Source")]
    public string? Scte35Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsNetworkInputSettings
{
    /// <summary>Specifies HLS input settings when the uri is for a HLS manifest. See HLS Input Settings for more details.</summary>
    [JsonPropertyName("hlsInputSettings")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsNetworkInputSettingsHlsInputSettings>? HlsInputSettings { get; set; }

    /// <summary>Check HTTPS server certificates.</summary>
    [JsonPropertyName("serverValidation")]
    public string? ServerValidation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsVideoSelector
{
    /// <summary></summary>
    [JsonPropertyName("colorSpace")]
    public string? ColorSpace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("colorSpaceUsage")]
    public string? ColorSpaceUsage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachmentsInputSettings
{
    /// <summary></summary>
    [JsonPropertyName("audioSelector")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelector>? AudioSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("captionSelector")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelector>? CaptionSelector { get; set; }

    /// <summary>Enable or disable the deblock filter when filtering.</summary>
    [JsonPropertyName("deblockFilter")]
    public string? DeblockFilter { get; set; }

    /// <summary>Enable or disable the denoise filter when filtering.</summary>
    [JsonPropertyName("denoiseFilter")]
    public string? DenoiseFilter { get; set; }

    /// <summary>Adjusts the magnitude of filtering from 1 (minimal) to 5 (strongest).</summary>
    [JsonPropertyName("filterStrength")]
    public double? FilterStrength { get; set; }

    /// <summary>Turns on the filter for the input.</summary>
    [JsonPropertyName("inputFilter")]
    public string? InputFilter { get; set; }

    /// <summary>Input settings. See Network Input Settings for more details.</summary>
    [JsonPropertyName("networkInputSettings")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsNetworkInputSettings>? NetworkInputSettings { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public double? Scte35Pid { get; set; }

    /// <summary>Specifies whether to extract applicable ancillary data from a SMPTE-2038 source in the input.</summary>
    [JsonPropertyName("smpte2038DataPreference")]
    public string? Smpte2038DataPreference { get; set; }

    /// <summary>Loop input if it is a file.</summary>
    [JsonPropertyName("sourceEndBehavior")]
    public string? SourceEndBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("videoSelector")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettingsVideoSelector>? VideoSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputAttachments
{
    /// <summary>User-specified settings for defining what the conditions are for declaring the input unhealthy and failing over to a different input. See Automatic Input Failover Settings for more details.</summary>
    [JsonPropertyName("automaticInputFailoverSettings")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettings>? AutomaticInputFailoverSettings { get; set; }

    /// <summary>User-specified name for the attachment.</summary>
    [JsonPropertyName("inputAttachmentName")]
    public string? InputAttachmentName { get; set; }

    /// <summary>The ID of the input.</summary>
    [JsonPropertyName("inputId")]
    public string? InputId { get; set; }

    /// <summary>Reference to a Input in medialive to populate inputId.</summary>
    [JsonPropertyName("inputIdRef")]
    public V1beta1ChannelSpecForProviderInputAttachmentsInputIdRef? InputIdRef { get; set; }

    /// <summary>Selector for a Input in medialive to populate inputId.</summary>
    [JsonPropertyName("inputIdSelector")]
    public V1beta1ChannelSpecForProviderInputAttachmentsInputIdSelector? InputIdSelector { get; set; }

    /// <summary>Settings of an input. See Input Settings for more details.</summary>
    [JsonPropertyName("inputSettings")]
    public IList<V1beta1ChannelSpecForProviderInputAttachmentsInputSettings>? InputSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderInputSpecification
{
    /// <summary></summary>
    [JsonPropertyName("codec")]
    public string? Codec { get; set; }

    /// <summary>- Maximum CDI input resolution.</summary>
    [JsonPropertyName("inputResolution")]
    public string? InputResolution { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("maximumBitrate")]
    public string? MaximumBitrate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderMaintenance
{
    /// <summary>The day of the week to use for maintenance.</summary>
    [JsonPropertyName("maintenanceDay")]
    public string? MaintenanceDay { get; set; }

    /// <summary>The hour maintenance will start.</summary>
    [JsonPropertyName("maintenanceStartTime")]
    public string? MaintenanceStartTime { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ChannelSpecForProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ChannelSpecForProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProviderVpc
{
    /// <summary>List of public address allocation ids to associate with ENIs that will be created in Output VPC. Must specify one for SINGLE_PIPELINE, two for STANDARD channels.</summary>
    [JsonPropertyName("publicAddressAllocationIds")]
    public IList<string>? PublicAddressAllocationIds { get; set; }

    /// <summary>A list of up to 5 EC2 VPC security group IDs to attach to the Output VPC network interfaces. If none are specified then the VPC default security group will be used.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>A list of VPC subnet IDs from the same VPC. If STANDARD channel, subnet IDs must be mapped to two unique availability zones (AZ).</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecForProvider
{
    /// <summary>Specification of CDI inputs for this channel. See CDI Input Specification for more details.</summary>
    [JsonPropertyName("cdiInputSpecification")]
    public IList<V1beta1ChannelSpecForProviderCdiInputSpecification>? CdiInputSpecification { get; set; }

    /// <summary>Concise argument description.</summary>
    [JsonPropertyName("channelClass")]
    public string? ChannelClass { get; set; }

    /// <summary>Destinations for channel. See Destinations for more details.</summary>
    [JsonPropertyName("destinations")]
    public IList<V1beta1ChannelSpecForProviderDestinations>? Destinations { get; set; }

    /// <summary>Encoder settings. See Encoder Settings for more details.</summary>
    [JsonPropertyName("encoderSettings")]
    public IList<V1beta1ChannelSpecForProviderEncoderSettings>? EncoderSettings { get; set; }

    /// <summary>Input attachments for the channel. See Input Attachments for more details.</summary>
    [JsonPropertyName("inputAttachments")]
    public IList<V1beta1ChannelSpecForProviderInputAttachments>? InputAttachments { get; set; }

    /// <summary>Specification of network and file inputs for the channel.</summary>
    [JsonPropertyName("inputSpecification")]
    public IList<V1beta1ChannelSpecForProviderInputSpecification>? InputSpecification { get; set; }

    /// <summary>The log level to write to Cloudwatch logs.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>Maintenance settings for this channel. See Maintenance for more details.</summary>
    [JsonPropertyName("maintenance")]
    public IList<V1beta1ChannelSpecForProviderMaintenance>? Maintenance { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Concise argument description.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1ChannelSpecForProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1ChannelSpecForProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Whether to start/stop channel. Default: false</summary>
    [JsonPropertyName("startChannel")]
    public bool? StartChannel { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Settings for the VPC outputs. See VPC for more details.</summary>
    [JsonPropertyName("vpc")]
    public IList<V1beta1ChannelSpecForProviderVpc>? Vpc { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderCdiInputSpecification
{
    /// <summary>- Maximum CDI input resolution.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderDestinationsMediaPackageSettings
{
    /// <summary>ID of the channel in MediaPackage that is the destination for this output group.</summary>
    [JsonPropertyName("channelId")]
    public string? ChannelId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderDestinationsMultiplexSettings
{
    /// <summary>The ID of the Multiplex that the encoder is providing output to.</summary>
    [JsonPropertyName("multiplexId")]
    public string? MultiplexId { get; set; }

    /// <summary>The program name of the Multiplex program that the encoder is providing output to.</summary>
    [JsonPropertyName("programName")]
    public string? ProgramName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderDestinationsSettings
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Stream name RTMP destinations (URLs of type rtmp://)</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }

    /// <summary>A URL specifying a destination.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderDestinations
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Destination settings for a MediaPackage output; one destination for both encoders. See Media Package Settings for more details.</summary>
    [JsonPropertyName("mediaPackageSettings")]
    public IList<V1beta1ChannelSpecInitProviderDestinationsMediaPackageSettings>? MediaPackageSettings { get; set; }

    /// <summary>Destination settings for a Multiplex output; one destination for both encoders. See Multiplex Settings for more details.</summary>
    [JsonPropertyName("multiplexSettings")]
    public IList<V1beta1ChannelSpecInitProviderDestinationsMultiplexSettings>? MultiplexSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("settings")]
    public IList<V1beta1ChannelSpecInitProviderDestinationsSettings>? Settings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsAudioNormalizationSettings
{
    /// <summary>Audio normalization algorithm to use. itu17701 conforms to the CALM Act specification, itu17702 to the EBU R-128 specification.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Algorithm control for the audio description.</summary>
    [JsonPropertyName("algorithmControl")]
    public string? AlgorithmControl { get; set; }

    /// <summary>Target LKFS (loudness) to adjust volume to.</summary>
    [JsonPropertyName("targetLkfs")]
    public double? TargetLkfs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenCbetSettings
{
    /// <summary></summary>
    [JsonPropertyName("cbetCheckDigitString")]
    public string? CbetCheckDigitString { get; set; }

    /// <summary>Determines the method of CBET insertion mode when prior encoding is detected on the same layer.</summary>
    [JsonPropertyName("cbetStepaside")]
    public string? CbetStepaside { get; set; }

    /// <summary>CBET source ID to use in the watermark.</summary>
    [JsonPropertyName("csid")]
    public string? Csid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenNaesIiNwSettings
{
    /// <summary></summary>
    [JsonPropertyName("checkDigitString")]
    public string? CheckDigitString { get; set; }

    /// <summary>The Nielsen Source ID to include in the watermark.</summary>
    [JsonPropertyName("sid")]
    public double? Sid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettings
{
    /// <summary>Used to insert watermarks of type Nielsen CBET. See Nielsen CBET Settings for more details.</summary>
    [JsonPropertyName("nielsenCbetSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenCbetSettings>? NielsenCbetSettings { get; set; }

    /// <summary>Distribution types to assign to the watermarks. Options are PROGRAM_CONTENT and FINAL_DISTRIBUTOR.</summary>
    [JsonPropertyName("nielsenDistributionType")]
    public string? NielsenDistributionType { get; set; }

    /// <summary>Used to insert watermarks of type Nielsen NAES, II (N2) and Nielsen NAES VI (NW). See Nielsen NAES II NW Settings for more details.</summary>
    [JsonPropertyName("nielsenNaesIiNwSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenNaesIiNwSettings>? NielsenNaesIiNwSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("nielsenWatermarksSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettings>? NielsenWatermarksSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsAacSettings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Set to "broadcasterMixedAd" when input contains pre-mixed main audio + AD (narration) as a stereo pair.</summary>
    [JsonPropertyName("inputType")]
    public string? InputType { get; set; }

    /// <summary>AAC profile.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>The rate control mode.</summary>
    [JsonPropertyName("rateControlMode")]
    public string? RateControlMode { get; set; }

    /// <summary>Sets LATM/LOAS AAC output for raw containers.</summary>
    [JsonPropertyName("rawFormat")]
    public string? RawFormat { get; set; }

    /// <summary>Sample rate in Hz.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }

    /// <summary>Use MPEG-2 AAC audio instead of MPEG-4 AAC audio for raw or MPEG-2 Transport Stream containers.</summary>
    [JsonPropertyName("spec")]
    public string? Spec { get; set; }

    /// <summary>VBR Quality Level - Only used if rateControlMode is VBR.</summary>
    [JsonPropertyName("vbrQuality")]
    public string? VbrQuality { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsAc3Settings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Specifies the bitstream mode (bsmod) for the emitted AC-3 stream.</summary>
    [JsonPropertyName("bitstreamMode")]
    public string? BitstreamMode { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sets the dialnorm of the output.</summary>
    [JsonPropertyName("dialnorm")]
    public double? Dialnorm { get; set; }

    /// <summary>If set to filmStandard, adds dynamic range compression signaling to the output bitstream as defined in the Dolby Digital specification.</summary>
    [JsonPropertyName("drcProfile")]
    public string? DrcProfile { get; set; }

    /// <summary>When set to enabled, applies a 120Hz lowpass filter to the LFE channel prior to encoding.</summary>
    [JsonPropertyName("lfeFilter")]
    public string? LfeFilter { get; set; }

    /// <summary>Metadata control.</summary>
    [JsonPropertyName("metadataControl")]
    public string? MetadataControl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sets the dialnorm of the output.</summary>
    [JsonPropertyName("dialnorm")]
    public double? Dialnorm { get; set; }

    /// <summary>Sets the Dolby dynamic range compression profile.</summary>
    [JsonPropertyName("drcLine")]
    public string? DrcLine { get; set; }

    /// <summary>Sets the profile for heavy Dolby dynamic range compression.</summary>
    [JsonPropertyName("drcRf")]
    public string? DrcRf { get; set; }

    /// <summary>Height dimensional trim.</summary>
    [JsonPropertyName("heightTrim")]
    public double? HeightTrim { get; set; }

    /// <summary>Surround dimensional trim.</summary>
    [JsonPropertyName("surroundTrim")]
    public double? SurroundTrim { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3Settings
{
    /// <summary>Sets the attenuation control.</summary>
    [JsonPropertyName("attenuationControl")]
    public string? AttenuationControl { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Specifies the bitstream mode (bsmod) for the emitted AC-3 stream.</summary>
    [JsonPropertyName("bitstreamMode")]
    public string? BitstreamMode { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dcFilter")]
    public string? DcFilter { get; set; }

    /// <summary>Sets the dialnorm of the output.</summary>
    [JsonPropertyName("dialnorm")]
    public double? Dialnorm { get; set; }

    /// <summary>Sets the Dolby dynamic range compression profile.</summary>
    [JsonPropertyName("drcLine")]
    public string? DrcLine { get; set; }

    /// <summary>Sets the profile for heavy Dolby dynamic range compression.</summary>
    [JsonPropertyName("drcRf")]
    public string? DrcRf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lfeControl")]
    public string? LfeControl { get; set; }

    /// <summary>When set to enabled, applies a 120Hz lowpass filter to the LFE channel prior to encoding.</summary>
    [JsonPropertyName("lfeFilter")]
    public string? LfeFilter { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("loRoCenterMixLevel")]
    public double? LoRoCenterMixLevel { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("loRoSurroundMixLevel")]
    public double? LoRoSurroundMixLevel { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("ltRtCenterMixLevel")]
    public double? LtRtCenterMixLevel { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("ltRtSurroundMixLevel")]
    public double? LtRtSurroundMixLevel { get; set; }

    /// <summary>Metadata control.</summary>
    [JsonPropertyName("metadataControl")]
    public string? MetadataControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passthroughControl")]
    public string? PassthroughControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("phaseControl")]
    public string? PhaseControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stereoDownmix")]
    public string? StereoDownmix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("surroundExMode")]
    public string? SurroundExMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("surroundMode")]
    public string? SurroundMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsMp2Settings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sample rate in Hz.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsPassThroughSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsWavSettings
{
    /// <summary></summary>
    [JsonPropertyName("bitDepth")]
    public double? BitDepth { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sample rate in Hz.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettings
{
    /// <summary>Aac Settings. See AAC Settings for more details.</summary>
    [JsonPropertyName("aacSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsAacSettings>? AacSettings { get; set; }

    /// <summary>Ac3 Settings. See AC3 Settings for more details.</summary>
    [JsonPropertyName("ac3Settings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsAc3Settings>? Ac3Settings { get; set; }

    /// <summary>- Eac3 Atmos Settings. See EAC3 Atmos Settings</summary>
    [JsonPropertyName("eac3AtmosSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings>? Eac3AtmosSettings { get; set; }

    /// <summary>- Eac3 Settings. See EAC3 Settings</summary>
    [JsonPropertyName("eac3Settings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3Settings>? Eac3Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("mp2Settings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsMp2Settings>? Mp2Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("passThroughSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsPassThroughSettings>? PassThroughSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("wavSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsWavSettings>? WavSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappingsInputChannelLevels
{
    /// <summary></summary>
    [JsonPropertyName("gain")]
    public double? Gain { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inputChannel")]
    public double? InputChannel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings
{
    /// <summary></summary>
    [JsonPropertyName("inputChannelLevels")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappingsInputChannelLevels>? InputChannelLevels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outputChannel")]
    public double? OutputChannel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsRemixSettings
{
    /// <summary></summary>
    [JsonPropertyName("channelMappings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings>? ChannelMappings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("channelsIn")]
    public double? ChannelsIn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("channelsOut")]
    public double? ChannelsOut { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptions
{
    /// <summary>Advanced audio normalization settings. See Audio Normalization Settings for more details.</summary>
    [JsonPropertyName("audioNormalizationSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsAudioNormalizationSettings>? AudioNormalizationSettings { get; set; }

    /// <summary>The name of the audio selector in the input that MediaLive should monitor to detect silence. Select your most important rendition. If you didn't create an audio selector in this input, leave blank.</summary>
    [JsonPropertyName("audioSelectorName")]
    public string? AudioSelectorName { get; set; }

    /// <summary>Applies only if audioTypeControl is useConfigured. The values for audioType are defined in ISO-IEC 13818-1.</summary>
    [JsonPropertyName("audioType")]
    public string? AudioType { get; set; }

    /// <summary>Determined how audio type is determined.</summary>
    [JsonPropertyName("audioTypeControl")]
    public string? AudioTypeControl { get; set; }

    /// <summary>Settings to configure one or more solutions that insert audio watermarks in the audio encode. See Audio Watermark Settings for more details.</summary>
    [JsonPropertyName("audioWatermarkSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettings>? AudioWatermarkSettings { get; set; }

    /// <summary>Audio codec settings. See Audio Codec Settings for more details.</summary>
    [JsonPropertyName("codecSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettings>? CodecSettings { get; set; }

    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("languageCodeControl")]
    public string? LanguageCodeControl { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("remixSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptionsRemixSettings>? RemixSettings { get; set; }

    /// <summary>Stream name RTMP destinations (URLs of type rtmp://)</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsAvailBlankingAvailBlankingImage
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>–  Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsAvailBlanking
{
    /// <summary>Blanking image to be used. See Avail Blanking Image for more details.</summary>
    [JsonPropertyName("availBlankingImage")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsAvailBlankingAvailBlankingImage>? AvailBlankingImage { get; set; }

    /// <summary>When set to enabled, causes video, audio and captions to be blanked when insertion metadata is added.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsAribDestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettingsFont
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>–  Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettings
{
    /// <summary>justify live subtitles and center-justify pre-recorded subtitles. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("alignment")]
    public string? Alignment { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundOpacity")]
    public double? BackgroundOpacity { get; set; }

    /// <summary>in. File extension must be ‘ttf’ or ‘tte’. Although the user can select output fonts for many different types of input captions, embedded, STL and teletext sources use a strict grid system. Using external fonts with these caption sources could cause unexpected display of proportional fonts. All burn-in and DVB-Sub font settings must match. See Font for more details.</summary>
    [JsonPropertyName("font")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettingsFont>? Font { get; set; }

    /// <summary>in captions. This option is not valid for source captions that are STL, 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontColor")]
    public string? FontColor { get; set; }

    /// <summary>in captions. 255 is opaque; 0 is transparent. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontOpacity")]
    public double? FontOpacity { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontResolution")]
    public double? FontResolution { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontSize")]
    public string? FontSize { get; set; }

    /// <summary>defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineColor")]
    public string? OutlineColor { get; set; }

    /// <summary>defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineSize")]
    public double? OutlineSize { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowColor")]
    public string? ShadowColor { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowOpacity")]
    public double? ShadowOpacity { get; set; }

    /// <summary>2 would result in a shadow offset 2 pixels to the left. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowXOffset")]
    public double? ShadowXOffset { get; set; }

    /// <summary>2 would result in a shadow offset 2 pixels above the text. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowYOffset")]
    public double? ShadowYOffset { get; set; }

    /// <summary>Sub/Burn-in outputs.</summary>
    [JsonPropertyName("teletextGridControl")]
    public string? TeletextGridControl { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("xPosition")]
    public double? XPosition { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("yPosition")]
    public double? YPosition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettingsFont
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>–  Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettings
{
    /// <summary>justify live subtitles and center-justify pre-recorded subtitles. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("alignment")]
    public string? Alignment { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundOpacity")]
    public double? BackgroundOpacity { get; set; }

    /// <summary>in. File extension must be ‘ttf’ or ‘tte’. Although the user can select output fonts for many different types of input captions, embedded, STL and teletext sources use a strict grid system. Using external fonts with these caption sources could cause unexpected display of proportional fonts. All burn-in and DVB-Sub font settings must match. See Font for more details.</summary>
    [JsonPropertyName("font")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettingsFont>? Font { get; set; }

    /// <summary>in captions. This option is not valid for source captions that are STL, 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontColor")]
    public string? FontColor { get; set; }

    /// <summary>in captions. 255 is opaque; 0 is transparent. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontOpacity")]
    public double? FontOpacity { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontResolution")]
    public double? FontResolution { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontSize")]
    public string? FontSize { get; set; }

    /// <summary>defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineColor")]
    public string? OutlineColor { get; set; }

    /// <summary>defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineSize")]
    public double? OutlineSize { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowColor")]
    public string? ShadowColor { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowOpacity")]
    public double? ShadowOpacity { get; set; }

    /// <summary>2 would result in a shadow offset 2 pixels to the left. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowXOffset")]
    public double? ShadowXOffset { get; set; }

    /// <summary>2 would result in a shadow offset 2 pixels above the text. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowYOffset")]
    public double? ShadowYOffset { get; set; }

    /// <summary>Sub/Burn-in outputs.</summary>
    [JsonPropertyName("teletextGridControl")]
    public string? TeletextGridControl { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("xPosition")]
    public double? XPosition { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("yPosition")]
    public double? YPosition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEbuTtDDestinationSettings
{
    /// <summary>–  Complete this field if you want to include the name of the copyright holder in the copyright tag in the captions metadata.</summary>
    [JsonPropertyName("copyrightHolder")]
    public string? CopyrightHolder { get; set; }

    /// <summary>line captions). - enabled: Fill with the captions background color (as specified in the input captions). - disabled: Leave the gap unfilled.</summary>
    [JsonPropertyName("fillLineGap")]
    public string? FillLineGap { get; set; }

    /// <summary>TT captions. Valid only if styleControl is set to include. If you leave this field empty, the font family is set to “monospaced”. (If styleControl is set to exclude, the font family is always set to “monospaced”.) You specify only the font family. All other style information (color, bold, position and so on) is copied from the input captions. The size is always set to 100% to allow the downstream player to choose the size. - Enter a list of font families, as a comma-separated list of font names, in order of preference. The name can be a font family (such as “Arial”), or a generic font family (such as “serif”), or “default” (to let the downstream player choose the font). - Leave blank to set the family to “monospace”.</summary>
    [JsonPropertyName("fontFamily")]
    public string? FontFamily { get; set; }

    /// <summary>TT captions. - include: Take the style information (font color, font position, and so on) from the source captions and include that information in the font data attached to the EBU-TT captions. This option is valid only if the source captions are Embedded or Teletext. - exclude: In the font data attached to the EBU-TT captions, set the font family to “monospaced”. Do not include any other style information.</summary>
    [JsonPropertyName("styleControl")]
    public string? StyleControl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedDestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedPlusScte20DestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsRtmpCaptionInfoDestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte20PlusEmbeddedDestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte27DestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsSmpteTtDestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTeletextDestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTtmlDestinationSettings
{
    /// <summary>TT captions. - include: Take the style information (font color, font position, and so on) from the source captions and include that information in the font data attached to the EBU-TT captions. This option is valid only if the source captions are Embedded or Teletext. - exclude: In the font data attached to the EBU-TT captions, set the font family to “monospaced”. Do not include any other style information.</summary>
    [JsonPropertyName("styleControl")]
    public string? StyleControl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsWebvttDestinationSettings
{
    /// <summary>TT captions. - include: Take the style information (font color, font position, and so on) from the source captions and include that information in the font data attached to the EBU-TT captions. This option is valid only if the source captions are Embedded or Teletext. - exclude: In the font data attached to the EBU-TT captions, set the font family to “monospaced”. Do not include any other style information.</summary>
    [JsonPropertyName("styleControl")]
    public string? StyleControl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettings
{
    /// <summary>ARIB Destination Settings.</summary>
    [JsonPropertyName("aribDestinationSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsAribDestinationSettings>? AribDestinationSettings { get; set; }

    /// <summary>Burn In Destination Settings. See Burn In Destination Settings for more details.</summary>
    [JsonPropertyName("burnInDestinationSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettings>? BurnInDestinationSettings { get; set; }

    /// <summary>DVB Sub Destination Settings. See DVB Sub Destination Settings for more details.</summary>
    [JsonPropertyName("dvbSubDestinationSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettings>? DvbSubDestinationSettings { get; set; }

    /// <summary>EBU TT D Destination Settings. See EBU TT D Destination Settings for more details.</summary>
    [JsonPropertyName("ebuTtDDestinationSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEbuTtDDestinationSettings>? EbuTtDDestinationSettings { get; set; }

    /// <summary>Embedded Destination Settings.</summary>
    [JsonPropertyName("embeddedDestinationSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedDestinationSettings>? EmbeddedDestinationSettings { get; set; }

    /// <summary>Embedded Plus SCTE20 Destination Settings.</summary>
    [JsonPropertyName("embeddedPlusScte20DestinationSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedPlusScte20DestinationSettings>? EmbeddedPlusScte20DestinationSettings { get; set; }

    /// <summary>RTMP Caption Info Destination Settings.</summary>
    [JsonPropertyName("rtmpCaptionInfoDestinationSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsRtmpCaptionInfoDestinationSettings>? RtmpCaptionInfoDestinationSettings { get; set; }

    /// <summary>SCTE20 Plus Embedded Destination Settings.</summary>
    [JsonPropertyName("scte20PlusEmbeddedDestinationSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte20PlusEmbeddedDestinationSettings>? Scte20PlusEmbeddedDestinationSettings { get; set; }

    /// <summary>–  SCTE27 Destination Settings.</summary>
    [JsonPropertyName("scte27DestinationSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte27DestinationSettings>? Scte27DestinationSettings { get; set; }

    /// <summary>–  SMPTE TT Destination Settings.</summary>
    [JsonPropertyName("smpteTtDestinationSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsSmpteTtDestinationSettings>? SmpteTtDestinationSettings { get; set; }

    /// <summary>–  Teletext Destination Settings.</summary>
    [JsonPropertyName("teletextDestinationSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTeletextDestinationSettings>? TeletextDestinationSettings { get; set; }

    /// <summary>–  TTML Destination Settings. See TTML Destination Settings for more details.</summary>
    [JsonPropertyName("ttmlDestinationSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTtmlDestinationSettings>? TtmlDestinationSettings { get; set; }

    /// <summary>WebVTT Destination Settings. See WebVTT Destination Settings for more details.</summary>
    [JsonPropertyName("webvttDestinationSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsWebvttDestinationSettings>? WebvttDestinationSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptions
{
    /// <summary>Indicates whether the caption track implements accessibility features such as written descriptions of spoken dialog, music, and sounds.</summary>
    [JsonPropertyName("accessibility")]
    public string? Accessibility { get; set; }

    /// <summary>Specifies which input caption selector to use as a caption source when generating output captions. This field should match a captionSelector name.</summary>
    [JsonPropertyName("captionSelectorName")]
    public string? CaptionSelectorName { get; set; }

    /// <summary>Additional settings for captions destination that depend on the destination type. See Destination Settings for more details.</summary>
    [JsonPropertyName("destinationSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettings>? DestinationSettings { get; set; }

    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Human readable information to indicate captions available for players (eg. English, or Spanish).</summary>
    [JsonPropertyName("languageDescription")]
    public string? LanguageDescription { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>–  Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsGlobalConfigurationInputLossBehavior
{
    /// <summary></summary>
    [JsonPropertyName("blackFrameMsec")]
    public double? BlackFrameMsec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inputLossImageColor")]
    public string? InputLossImageColor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inputLossImageSlate")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate>? InputLossImageSlate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inputLossImageType")]
    public string? InputLossImageType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repeatFrameMsec")]
    public double? RepeatFrameMsec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsGlobalConfiguration
{
    /// <summary>–  Value to set the initial audio gain for the Live Event.</summary>
    [JsonPropertyName("initialAudioGain")]
    public double? InitialAudioGain { get; set; }

    /// <summary>of-file). When switchAndLoopInputs is configured the encoder will restart at the beginning of the first input. When “none” is configured the encoder will transcode either black, a solid color, or a user specified slate images per the “Input Loss Behavior” configuration until the next input switch occurs (which is controlled through the Channel Schedule API).</summary>
    [JsonPropertyName("inputEndAction")]
    public string? InputEndAction { get; set; }

    /// <summary>Settings for system actions when input is lost. See Input Loss Behavior for more details.</summary>
    [JsonPropertyName("inputLossBehavior")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsGlobalConfigurationInputLossBehavior>? InputLossBehavior { get; set; }

    /// <summary>MediaLive will attempt to synchronize the output of each pipeline to the other. EPOCH_LOCKING - MediaLive will attempt to synchronize the output of each pipeline to the Unix epoch.</summary>
    [JsonPropertyName("outputLockingMode")]
    public string? OutputLockingMode { get; set; }

    /// <summary>–  Indicates whether the rate of frames emitted by the Live encoder should be paced by its system clock (which optionally may be locked to another source via NTP) or should be locked to the clock of the source that is providing the input stream.</summary>
    [JsonPropertyName("outputTimingSource")]
    public string? OutputTimingSource { get; set; }

    /// <summary>–  Adjusts video input buffer for streams with very low video framerates. This is commonly set to enabled for music channels with less than one video frame per second.</summary>
    [JsonPropertyName("supportLowFramerateInputs")]
    public string? SupportLowFramerateInputs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettingsHtmlMotionGraphicsSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings
{
    /// <summary>–  Html Motion Graphics Settings.</summary>
    [JsonPropertyName("htmlMotionGraphicsSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettingsHtmlMotionGraphicsSettings>? HtmlMotionGraphicsSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsMotionGraphicsConfiguration
{
    /// <summary>–  Motion Graphics Insertion.</summary>
    [JsonPropertyName("motionGraphicsInsertion")]
    public string? MotionGraphicsInsertion { get; set; }

    /// <summary>–  Motion Graphics Settings. See Motion Graphics Settings for more details.</summary>
    [JsonPropertyName("motionGraphicsSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings>? MotionGraphicsSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsNielsenConfiguration
{
    /// <summary>–  Enter the Distributor ID assigned to your organization by Nielsen.</summary>
    [JsonPropertyName("distributorId")]
    public string? DistributorId { get; set; }

    /// <summary>–  Enables Nielsen PCM to ID3 tagging.</summary>
    [JsonPropertyName("nielsenPcmToId3Tagging")]
    public string? NielsenPcmToId3Tagging { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettingsArchiveS3Settings
{
    /// <summary>Specify the canned ACL to apply to each S3 request.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettings
{
    /// <summary>Archive S3 Settings. See Archive S3 Settings for more details.</summary>
    [JsonPropertyName("archiveS3Settings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettingsArchiveS3Settings>? ArchiveS3Settings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettings
{
    /// <summary>Parameters that control the interactions with the CDN. See Archive CDN Settings for more details.</summary>
    [JsonPropertyName("archiveCdnSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettings>? ArchiveCdnSettings { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsDestination>? Destination { get; set; }

    /// <summary>Number of seconds to write to archive file before closing and starting a new one.</summary>
    [JsonPropertyName("rolloverInterval")]
    public double? RolloverInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettingsFrameCaptureS3Settings
{
    /// <summary>Specify the canned ACL to apply to each S3 request.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureS3Settings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettingsFrameCaptureS3Settings>? FrameCaptureS3Settings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettings
{
    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsDestination>? Destination { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureCdnSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettings>? FrameCaptureCdnSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsCaptionLanguageMappings
{
    /// <summary></summary>
    [JsonPropertyName("captionChannel")]
    public double? CaptionChannel { get; set; }

    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Human readable information to indicate captions available for players (eg. English, or Spanish).</summary>
    [JsonPropertyName("languageDescription")]
    public string? LanguageDescription { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsAkamaiSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpTransferMode")]
    public string? HttpTransferMode { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }

    /// <summary></summary>
    [JsonPropertyName("salt")]
    public string? Salt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsBasicPutSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsMediaStoreSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mediaStoreStorageClass")]
    public string? MediaStoreStorageClass { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsS3Settings
{
    /// <summary>Specify the canned ACL to apply to each S3 request.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsWebdavSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpTransferMode")]
    public string? HttpTransferMode { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsAkamaiSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsAkamaiSettings>? HlsAkamaiSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsBasicPutSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsBasicPutSettings>? HlsBasicPutSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsMediaStoreSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsMediaStoreSettings>? HlsMediaStoreSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsS3Settings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsS3Settings>? HlsS3Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsWebdavSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsWebdavSettings>? HlsWebdavSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettingsKeyProviderServer
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>–  Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettings
{
    /// <summary></summary>
    [JsonPropertyName("keyProviderServer")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettingsKeyProviderServer>? KeyProviderServer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("staticKeyValue")]
    public string? StaticKeyValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("staticKeySettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettings>? StaticKeySettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings
{
    /// <summary>The ad marker type for this output group.</summary>
    [JsonPropertyName("adMarkers")]
    public IList<string>? AdMarkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("baseUrlContent")]
    public string? BaseUrlContent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("baseUrlContent1")]
    public string? BaseUrlContent1 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("baseUrlManifest")]
    public string? BaseUrlManifest { get; set; }

    /// <summary></summary>
    [JsonPropertyName("baseUrlManifest1")]
    public string? BaseUrlManifest1 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("captionLanguageMappings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsCaptionLanguageMappings>? CaptionLanguageMappings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("captionLanguageSetting")]
    public string? CaptionLanguageSetting { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientCache")]
    public string? ClientCache { get; set; }

    /// <summary></summary>
    [JsonPropertyName("codecSpecification")]
    public string? CodecSpecification { get; set; }

    /// <summary></summary>
    [JsonPropertyName("constantIv")]
    public string? ConstantIv { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsDestination>? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directoryStructure")]
    public string? DirectoryStructure { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("discontinuityTags")]
    public string? DiscontinuityTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsCdnSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettings>? HlsCdnSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hlsId3SegmentTagging")]
    public string? HlsId3SegmentTagging { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iframeOnlyPlaylists")]
    public string? IframeOnlyPlaylists { get; set; }

    /// <summary></summary>
    [JsonPropertyName("incompleteSegmentBehavior")]
    public string? IncompleteSegmentBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("indexNSegments")]
    public double? IndexNSegments { get; set; }

    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ivInManifest")]
    public string? IvInManifest { get; set; }

    /// <summary>The source for the timecode that will be associated with the events outputs.</summary>
    [JsonPropertyName("ivSource")]
    public string? IvSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keepSegments")]
    public double? KeepSegments { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyFormat")]
    public string? KeyFormat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyFormatVersions")]
    public string? KeyFormatVersions { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("keyProviderSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettings>? KeyProviderSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("manifestCompression")]
    public string? ManifestCompression { get; set; }

    /// <summary></summary>
    [JsonPropertyName("manifestDurationFormat")]
    public string? ManifestDurationFormat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minSegmentLength")]
    public double? MinSegmentLength { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outputSelection")]
    public string? OutputSelection { get; set; }

    /// <summary></summary>
    [JsonPropertyName("programDateTime")]
    public string? ProgramDateTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("programDateTimeClock")]
    public string? ProgramDateTimeClock { get; set; }

    /// <summary></summary>
    [JsonPropertyName("programDateTimePeriod")]
    public double? ProgramDateTimePeriod { get; set; }

    /// <summary></summary>
    [JsonPropertyName("redundantManifest")]
    public string? RedundantManifest { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentLength")]
    public double? SegmentLength { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentsPerSubdirectory")]
    public double? SegmentsPerSubdirectory { get; set; }

    /// <summary>- Maximum CDI input resolution.</summary>
    [JsonPropertyName("streamInfResolution")]
    public string? StreamInfResolution { get; set; }

    /// <summary>Indicates ID3 frame that has the timecode.</summary>
    [JsonPropertyName("timedMetadataId3Frame")]
    public string? TimedMetadataId3Frame { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timedMetadataId3Period")]
    public double? TimedMetadataId3Period { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestampDeltaMilliseconds")]
    public double? TimestampDeltaMilliseconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tsFileMode")]
    public string? TsFileMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings
{
    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsDestination>? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("acquisitionPointId")]
    public string? AcquisitionPointId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioOnlyTimecodeControl")]
    public string? AudioOnlyTimecodeControl { get; set; }

    /// <summary>Setting to allow self signed or verified RTMP certificates.</summary>
    [JsonPropertyName("certificateMode")]
    public string? CertificateMode { get; set; }

    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestination>? Destination { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("eventId")]
    public string? EventId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventIdMode")]
    public string? EventIdMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventStopBehavior")]
    public string? EventStopBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fragmentLength")]
    public double? FragmentLength { get; set; }

    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentationMode")]
    public string? SegmentationMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sendDelayMs")]
    public double? SendDelayMs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparseTrackType")]
    public string? SparseTrackType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("streamManifestBehavior")]
    public string? StreamManifestBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestampOffset")]
    public string? TimestampOffset { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestampOffsetMode")]
    public string? TimestampOffsetMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsMultiplexGroupSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings
{
    /// <summary>The ad marker type for this output group.</summary>
    [JsonPropertyName("adMarkers")]
    public IList<string>? AdMarkers { get; set; }

    /// <summary>Authentication scheme to use when connecting with CDN.</summary>
    [JsonPropertyName("authenticationScheme")]
    public string? AuthenticationScheme { get; set; }

    /// <summary>Controls behavior when content cache fills up.</summary>
    [JsonPropertyName("cacheFullBehavior")]
    public string? CacheFullBehavior { get; set; }

    /// <summary>Cache length in seconds, is used to calculate buffer size.</summary>
    [JsonPropertyName("cacheLength")]
    public double? CacheLength { get; set; }

    /// <summary>Controls the types of data that passes to onCaptionInfo outputs.</summary>
    [JsonPropertyName("captionData")]
    public string? CaptionData { get; set; }

    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsUdpGroupSettings
{
    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    /// <summary>Indicates ID3 frame that has the timecode.</summary>
    [JsonPropertyName("timedMetadataId3Frame")]
    public string? TimedMetadataId3Frame { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timedMetadataId3Period")]
    public double? TimedMetadataId3Period { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettings
{
    /// <summary>Archive group settings. See Archive Group Settings for more details.</summary>
    [JsonPropertyName("archiveGroupSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettings>? ArchiveGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureGroupSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettings>? FrameCaptureGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsGroupSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings>? HlsGroupSettings { get; set; }

    /// <summary>Media package group settings. See Media Package Group Settings for more details.</summary>
    [JsonPropertyName("mediaPackageGroupSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings>? MediaPackageGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("msSmoothGroupSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings>? MsSmoothGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("multiplexGroupSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsMultiplexGroupSettings>? MultiplexGroupSettings { get; set; }

    /// <summary>RTMP group settings. See RTMP Group Settings for more details.</summary>
    [JsonPropertyName("rtmpGroupSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings>? RtmpGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("udpGroupSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsUdpGroupSettings>? UdpGroupSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("networkId")]
    public double? NetworkId { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("networkName")]
    public string? NetworkName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings
{
    /// <summary></summary>
    [JsonPropertyName("outputSdt")]
    public string? OutputSdt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceProviderName")]
    public string? ServiceProviderName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings
{
    /// <summary></summary>
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettings
{
    /// <summary></summary>
    [JsonPropertyName("absentInputAudioBehavior")]
    public string? AbsentInputAudioBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("arib")]
    public string? Arib { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("aribCaptionsPid")]
    public string? AribCaptionsPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("aribCaptionsPidControl")]
    public string? AribCaptionsPidControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioBufferModel")]
    public string? AudioBufferModel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioFramesPerPes")]
    public double? AudioFramesPerPes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioPids")]
    public string? AudioPids { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioStreamType")]
    public string? AudioStreamType { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bufferModel")]
    public string? BufferModel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ccDescriptor")]
    public string? CcDescriptor { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbNitSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings>? DvbNitSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbSdtSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings>? DvbSdtSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dvbSubPids")]
    public string? DvbSubPids { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbTdtSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings>? DvbTdtSettings { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("dvbTeletextPid")]
    public string? DvbTeletextPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebif")]
    public string? Ebif { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebpAudioInterval")]
    public string? EbpAudioInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebpLookaheadMs")]
    public double? EbpLookaheadMs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebpPlacement")]
    public string? EbpPlacement { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("ecmPid")]
    public string? EcmPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("esRateInPes")]
    public string? EsRateInPes { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvPlatformPid")]
    public string? EtvPlatformPid { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvSignalPid")]
    public string? EtvSignalPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fragmentTime")]
    public double? FragmentTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("klv")]
    public string? Klv { get; set; }

    /// <summary></summary>
    [JsonPropertyName("klvDataPids")]
    public string? KlvDataPids { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("nullPacketBitrate")]
    public double? NullPacketBitrate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patInterval")]
    public double? PatInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pcrControl")]
    public string? PcrControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pcrPeriod")]
    public double? PcrPeriod { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pcrPid")]
    public string? PcrPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pmtInterval")]
    public double? PmtInterval { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pmtPid")]
    public string? PmtPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("programNum")]
    public double? ProgramNum { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rateMode")]
    public string? RateMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scte27Pids")]
    public string? Scte27Pids { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scte35Control")]
    public string? Scte35Control { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public string? Scte35Pid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentationMarkers")]
    public string? SegmentationMarkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentationStyle")]
    public string? SegmentationStyle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentationTime")]
    public double? SegmentationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("timedMetadataPid")]
    public string? TimedMetadataPid { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("transportStreamId")]
    public double? TransportStreamId { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("videoPid")]
    public string? VideoPid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsRawSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettings
{
    /// <summary>M2TS Settings. See M2TS Settings for more details.</summary>
    [JsonPropertyName("m2tsSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettings>? M2tsSettings { get; set; }

    /// <summary>Raw Settings. This can be set as an empty block.</summary>
    [JsonPropertyName("rawSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsRawSettings>? RawSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettings
{
    /// <summary>Settings specific to the container type of the file. See Container Settings for more details.</summary>
    [JsonPropertyName("containerSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettings>? ContainerSettings { get; set; }

    /// <summary>Output file extension.</summary>
    [JsonPropertyName("extension")]
    public string? Extension { get; set; }

    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsFrameCaptureOutputSettings
{
    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettingsAudioOnlyImage
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>–  Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettings
{
    /// <summary>Specifies the GROUP-ID in the #EXT-X-MEDIA tag of the target HLS audio rendition.</summary>
    [JsonPropertyName("audioGroupId")]
    public string? AudioGroupId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioOnlyImage")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettingsAudioOnlyImage>? AudioOnlyImage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioTrackType")]
    public string? AudioTrackType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentType")]
    public string? SegmentType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFmp4HlsSettings
{
    /// <summary></summary>
    [JsonPropertyName("audioRenditionSets")]
    public string? AudioRenditionSets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFrameCaptureHlsSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3u8Settings
{
    /// <summary></summary>
    [JsonPropertyName("audioFramesPerPes")]
    public double? AudioFramesPerPes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioPids")]
    public string? AudioPids { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("ecmPid")]
    public string? EcmPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patInterval")]
    public double? PatInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pcrControl")]
    public string? PcrControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pcrPeriod")]
    public double? PcrPeriod { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pcrPid")]
    public string? PcrPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pmtInterval")]
    public double? PmtInterval { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pmtPid")]
    public string? PmtPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("programNum")]
    public double? ProgramNum { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scte35Behavior")]
    public string? Scte35Behavior { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public string? Scte35Pid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("timedMetadataPid")]
    public string? TimedMetadataPid { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("transportStreamId")]
    public double? TransportStreamId { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("videoPid")]
    public string? VideoPid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettings
{
    /// <summary></summary>
    [JsonPropertyName("audioRenditionSets")]
    public string? AudioRenditionSets { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("m3u8Settings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3u8Settings>? M3u8Settings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("audioOnlyHlsSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettings>? AudioOnlyHlsSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("fmp4HlsSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFmp4HlsSettings>? Fmp4HlsSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureHlsSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFrameCaptureHlsSettings>? FrameCaptureHlsSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("standardHlsSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettings>? StandardHlsSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettings
{
    /// <summary></summary>
    [JsonPropertyName("h265PackagingType")]
    public string? H265PackagingType { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettings>? HlsSettings { get; set; }

    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentModifier")]
    public string? SegmentModifier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMediaPackageOutputSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMsSmoothOutputSettings
{
    /// <summary></summary>
    [JsonPropertyName("h265PackagingType")]
    public string? H265PackagingType { get; set; }

    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettings
{
    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettingsDestination>? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettings
{
    /// <summary>Setting to allow self signed or verified RTMP certificates.</summary>
    [JsonPropertyName("certificateMode")]
    public string? CertificateMode { get; set; }

    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsDestination>? Destination { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("networkId")]
    public double? NetworkId { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("networkName")]
    public string? NetworkName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings
{
    /// <summary></summary>
    [JsonPropertyName("outputSdt")]
    public string? OutputSdt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceProviderName")]
    public string? ServiceProviderName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings
{
    /// <summary></summary>
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettings
{
    /// <summary></summary>
    [JsonPropertyName("absentInputAudioBehavior")]
    public string? AbsentInputAudioBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("arib")]
    public string? Arib { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("aribCaptionsPid")]
    public string? AribCaptionsPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("aribCaptionsPidControl")]
    public string? AribCaptionsPidControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioBufferModel")]
    public string? AudioBufferModel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioFramesPerPes")]
    public double? AudioFramesPerPes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioPids")]
    public string? AudioPids { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioStreamType")]
    public string? AudioStreamType { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bufferModel")]
    public string? BufferModel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ccDescriptor")]
    public string? CcDescriptor { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbNitSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings>? DvbNitSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbSdtSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings>? DvbSdtSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dvbSubPids")]
    public string? DvbSubPids { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbTdtSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings>? DvbTdtSettings { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("dvbTeletextPid")]
    public string? DvbTeletextPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebif")]
    public string? Ebif { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebpAudioInterval")]
    public string? EbpAudioInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebpLookaheadMs")]
    public double? EbpLookaheadMs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebpPlacement")]
    public string? EbpPlacement { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("ecmPid")]
    public string? EcmPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("esRateInPes")]
    public string? EsRateInPes { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvPlatformPid")]
    public string? EtvPlatformPid { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvSignalPid")]
    public string? EtvSignalPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fragmentTime")]
    public double? FragmentTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("klv")]
    public string? Klv { get; set; }

    /// <summary></summary>
    [JsonPropertyName("klvDataPids")]
    public string? KlvDataPids { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("nullPacketBitrate")]
    public double? NullPacketBitrate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patInterval")]
    public double? PatInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pcrControl")]
    public string? PcrControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pcrPeriod")]
    public double? PcrPeriod { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pcrPid")]
    public string? PcrPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pmtInterval")]
    public double? PmtInterval { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pmtPid")]
    public string? PmtPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("programNum")]
    public double? ProgramNum { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rateMode")]
    public string? RateMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scte27Pids")]
    public string? Scte27Pids { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scte35Control")]
    public string? Scte35Control { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public string? Scte35Pid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentationMarkers")]
    public string? SegmentationMarkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentationStyle")]
    public string? SegmentationStyle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentationTime")]
    public double? SegmentationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("timedMetadataPid")]
    public string? TimedMetadataPid { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("transportStreamId")]
    public double? TransportStreamId { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("videoPid")]
    public string? VideoPid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettings
{
    /// <summary>M2TS Settings. See M2TS Settings for more details.</summary>
    [JsonPropertyName("m2tsSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettings>? M2tsSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsFecOutputSettings
{
    /// <summary>The height of the FEC protection matrix.</summary>
    [JsonPropertyName("columnDepth")]
    public double? ColumnDepth { get; set; }

    /// <summary>Enables column only or column and row based FEC.</summary>
    [JsonPropertyName("includeFec")]
    public string? IncludeFec { get; set; }

    /// <summary>The width of the FEC protection matrix.</summary>
    [JsonPropertyName("rowLength")]
    public double? RowLength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettings
{
    /// <summary>UDP output buffering in milliseconds.</summary>
    [JsonPropertyName("bufferMsec")]
    public double? BufferMsec { get; set; }

    /// <summary>Settings specific to the container type of the file. See Container Settings for more details.</summary>
    [JsonPropertyName("containerSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettings>? ContainerSettings { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsDestination>? Destination { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("fecOutputSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsFecOutputSettings>? FecOutputSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettings
{
    /// <summary>Archive output settings. See Archive Output Settings for more details.</summary>
    [JsonPropertyName("archiveOutputSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettings>? ArchiveOutputSettings { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("frameCaptureOutputSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsFrameCaptureOutputSettings>? FrameCaptureOutputSettings { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("hlsOutputSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettings>? HlsOutputSettings { get; set; }

    /// <summary>Media package output settings. This can be set as an empty block.</summary>
    [JsonPropertyName("mediaPackageOutputSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMediaPackageOutputSettings>? MediaPackageOutputSettings { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("msSmoothOutputSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMsSmoothOutputSettings>? MsSmoothOutputSettings { get; set; }

    /// <summary>Multiplex output settings. See Multiplex Output Settings for more details.</summary>
    [JsonPropertyName("multiplexOutputSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettings>? MultiplexOutputSettings { get; set; }

    /// <summary>RTMP output settings. See RTMP Output Settings for more details.</summary>
    [JsonPropertyName("rtmpOutputSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettings>? RtmpOutputSettings { get; set; }

    /// <summary>UDP output settings. See UDP Output Settings for more details.</summary>
    [JsonPropertyName("udpOutputSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettings>? UdpOutputSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputs
{
    /// <summary>The names of the audio descriptions used as audio sources for the output.</summary>
    [JsonPropertyName("audioDescriptionNames")]
    public IList<string>? AudioDescriptionNames { get; set; }

    /// <summary>The names of the caption descriptions used as caption sources for the output.</summary>
    [JsonPropertyName("captionDescriptionNames")]
    public IList<string>? CaptionDescriptionNames { get; set; }

    /// <summary>The name used to identify an output.</summary>
    [JsonPropertyName("outputName")]
    public string? OutputName { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("outputSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettings>? OutputSettings { get; set; }

    /// <summary>The name of the video description used as video source for the output.</summary>
    [JsonPropertyName("videoDescriptionName")]
    public string? VideoDescriptionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroups
{
    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Settings associated with the output group. See Output Group Settings for more details.</summary>
    [JsonPropertyName("outputGroupSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettings>? OutputGroupSettings { get; set; }

    /// <summary>List of outputs. See Outputs for more details.</summary>
    [JsonPropertyName("outputs")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputs>? Outputs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsTimecodeConfig
{
    /// <summary>The source for the timecode that will be associated with the events outputs.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Threshold in frames beyond which output timecode is resynchronized to the input timecode.</summary>
    [JsonPropertyName("syncThreshold")]
    public double? SyncThreshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings
{
    /// <summary>The frequency at which to capture frames for inclusion in the output.</summary>
    [JsonPropertyName("captureInterval")]
    public double? CaptureInterval { get; set; }

    /// <summary>Unit for the frame capture interval.</summary>
    [JsonPropertyName("captureIntervalUnits")]
    public string? CaptureIntervalUnits { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettingsTemporalFilterSettings
{
    /// <summary>Post filter sharpening.</summary>
    [JsonPropertyName("postFilterSharpening")]
    public string? PostFilterSharpening { get; set; }

    /// <summary>Filter strength.</summary>
    [JsonPropertyName("strength")]
    public string? Strength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettings
{
    /// <summary>Temporal filter settings. See Temporal Filter Settings</summary>
    [JsonPropertyName("temporalFilterSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettingsTemporalFilterSettings>? TemporalFilterSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH264Settings
{
    /// <summary>Enables or disables adaptive quantization.</summary>
    [JsonPropertyName("adaptiveQuantization")]
    public string? AdaptiveQuantization { get; set; }

    /// <summary>Indicates that AFD values will be written into the output stream.</summary>
    [JsonPropertyName("afdSignaling")]
    public string? AfdSignaling { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bufFillPct")]
    public double? BufFillPct { get; set; }

    /// <summary>Size of buffer in bits.</summary>
    [JsonPropertyName("bufSize")]
    public double? BufSize { get; set; }

    /// <summary>Includes color space metadata in the output.</summary>
    [JsonPropertyName("colorMetadata")]
    public string? ColorMetadata { get; set; }

    /// <summary>Entropy encoding mode.</summary>
    [JsonPropertyName("entropyEncoding")]
    public string? EntropyEncoding { get; set; }

    /// <summary>Filters to apply to an encode. See H264 Filter Settings for more details.</summary>
    [JsonPropertyName("filterSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettings>? FilterSettings { get; set; }

    /// <summary>Four bit AFD value to write on all frames of video in the output stream.</summary>
    [JsonPropertyName("fixedAfd")]
    public string? FixedAfd { get; set; }

    /// <summary></summary>
    [JsonPropertyName("flickerAq")]
    public string? FlickerAq { get; set; }

    /// <summary>Controls whether coding is performed on a field basis or on a frame basis.</summary>
    [JsonPropertyName("forceFieldPictures")]
    public string? ForceFieldPictures { get; set; }

    /// <summary>Indicates how the output video frame rate is specified.</summary>
    [JsonPropertyName("framerateControl")]
    public string? FramerateControl { get; set; }

    /// <summary>Framerate denominator.</summary>
    [JsonPropertyName("framerateDenominator")]
    public double? FramerateDenominator { get; set; }

    /// <summary>Framerate numerator.</summary>
    [JsonPropertyName("framerateNumerator")]
    public double? FramerateNumerator { get; set; }

    /// <summary>GOP-B reference.</summary>
    [JsonPropertyName("gopBReference")]
    public string? GopBReference { get; set; }

    /// <summary>Frequency of closed GOPs.</summary>
    [JsonPropertyName("gopClosedCadence")]
    public double? GopClosedCadence { get; set; }

    /// <summary>Number of B-frames between reference frames.</summary>
    [JsonPropertyName("gopNumBFrames")]
    public double? GopNumBFrames { get; set; }

    /// <summary>GOP size in units of either frames of seconds per gop_size_units.</summary>
    [JsonPropertyName("gopSize")]
    public double? GopSize { get; set; }

    /// <summary>Indicates if the gop_size is specified in frames or seconds.</summary>
    [JsonPropertyName("gopSizeUnits")]
    public string? GopSizeUnits { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Amount of lookahead.</summary>
    [JsonPropertyName("lookAheadRateControl")]
    public string? LookAheadRateControl { get; set; }

    /// <summary>Set the maximum bitrate in order to accommodate expected spikes in the complexity of the video.</summary>
    [JsonPropertyName("maxBitrate")]
    public double? MaxBitrate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minIInterval")]
    public double? MinIInterval { get; set; }

    /// <summary>Number of reference frames to use.</summary>
    [JsonPropertyName("numRefFrames")]
    public double? NumRefFrames { get; set; }

    /// <summary>Indicates how the output pixel aspect ratio is specified.</summary>
    [JsonPropertyName("parControl")]
    public string? ParControl { get; set; }

    /// <summary>Pixel Aspect Ratio denominator.</summary>
    [JsonPropertyName("parDenominator")]
    public double? ParDenominator { get; set; }

    /// <summary>Pixel Aspect Ratio numerator.</summary>
    [JsonPropertyName("parNumerator")]
    public double? ParNumerator { get; set; }

    /// <summary>AAC profile.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>Quality level.</summary>
    [JsonPropertyName("qualityLevel")]
    public string? QualityLevel { get; set; }

    /// <summary>Controls the target quality for the video encode.</summary>
    [JsonPropertyName("qvbrQualityLevel")]
    public double? QvbrQualityLevel { get; set; }

    /// <summary>The rate control mode.</summary>
    [JsonPropertyName("rateControlMode")]
    public string? RateControlMode { get; set; }

    /// <summary>Sets the scan type of the output.</summary>
    [JsonPropertyName("scanType")]
    public string? ScanType { get; set; }

    /// <summary>Scene change detection.</summary>
    [JsonPropertyName("sceneChangeDetect")]
    public string? SceneChangeDetect { get; set; }

    /// <summary>Number of slices per picture.</summary>
    [JsonPropertyName("slices")]
    public double? Slices { get; set; }

    /// <summary>Softness.</summary>
    [JsonPropertyName("softness")]
    public double? Softness { get; set; }

    /// <summary>Makes adjustments within each frame based on spatial variation of content complexity.</summary>
    [JsonPropertyName("spatialAq")]
    public string? SpatialAq { get; set; }

    /// <summary>Subgop length.</summary>
    [JsonPropertyName("subgopLength")]
    public string? SubgopLength { get; set; }

    /// <summary>Produces a bitstream compliant with SMPTE RP-2027.</summary>
    [JsonPropertyName("syntax")]
    public string? Syntax { get; set; }

    /// <summary>Makes adjustments within each frame based on temporal variation of content complexity.</summary>
    [JsonPropertyName("temporalAq")]
    public string? TemporalAq { get; set; }

    /// <summary>Determines how timecodes should be inserted into the video elementary stream.</summary>
    [JsonPropertyName("timecodeInsertion")]
    public string? TimecodeInsertion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsColorSpacePassthroughSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsDolbyVision81Settings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsHdr10Settings
{
    /// <summary>Sets the MaxCLL value for HDR10.</summary>
    [JsonPropertyName("maxCll")]
    public double? MaxCll { get; set; }

    /// <summary>Sets the MaxFALL value for HDR10.</summary>
    [JsonPropertyName("maxFall")]
    public double? MaxFall { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec601Settings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec709Settings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettings
{
    /// <summary>Sets the colorspace metadata to be passed through.</summary>
    [JsonPropertyName("colorSpacePassthroughSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsColorSpacePassthroughSettings>? ColorSpacePassthroughSettings { get; set; }

    /// <summary>Set the colorspace to Dolby Vision81.</summary>
    [JsonPropertyName("dolbyVision81Settings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsDolbyVision81Settings>? DolbyVision81Settings { get; set; }

    /// <summary>Set the colorspace to be HDR10. See H265 HDR10 Settings for more details.</summary>
    [JsonPropertyName("hdr10Settings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsHdr10Settings>? Hdr10Settings { get; set; }

    /// <summary>Set the colorspace to Rec. 601.</summary>
    [JsonPropertyName("rec601Settings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec601Settings>? Rec601Settings { get; set; }

    /// <summary>Set the colorspace to Rec. 709.</summary>
    [JsonPropertyName("rec709Settings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec709Settings>? Rec709Settings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettingsTemporalFilterSettings
{
    /// <summary>Post filter sharpening.</summary>
    [JsonPropertyName("postFilterSharpening")]
    public string? PostFilterSharpening { get; set; }

    /// <summary>Filter strength.</summary>
    [JsonPropertyName("strength")]
    public string? Strength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettings
{
    /// <summary>Temporal filter settings. See Temporal Filter Settings</summary>
    [JsonPropertyName("temporalFilterSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettingsTemporalFilterSettings>? TemporalFilterSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsTimecodeBurninSettings
{
    /// <summary>Set a prefix on the burned in timecode.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Sets the size of the burned in timecode.</summary>
    [JsonPropertyName("timecodeBurninFontSize")]
    public string? TimecodeBurninFontSize { get; set; }

    /// <summary>Sets the position of the burned in timecode.</summary>
    [JsonPropertyName("timecodeBurninPosition")]
    public string? TimecodeBurninPosition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265Settings
{
    /// <summary>Enables or disables adaptive quantization.</summary>
    [JsonPropertyName("adaptiveQuantization")]
    public string? AdaptiveQuantization { get; set; }

    /// <summary>Indicates that AFD values will be written into the output stream.</summary>
    [JsonPropertyName("afdSignaling")]
    public string? AfdSignaling { get; set; }

    /// <summary>Whether or not EML should insert an Alternative Transfer Function SEI message.</summary>
    [JsonPropertyName("alternativeTransferFunction")]
    public string? AlternativeTransferFunction { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Size of buffer in bits.</summary>
    [JsonPropertyName("bufSize")]
    public double? BufSize { get; set; }

    /// <summary>Includes color space metadata in the output.</summary>
    [JsonPropertyName("colorMetadata")]
    public string? ColorMetadata { get; set; }

    /// <summary>Define the color metadata for the output. H265 Color Space Settings for more details.</summary>
    [JsonPropertyName("colorSpaceSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettings>? ColorSpaceSettings { get; set; }

    /// <summary>Filters to apply to an encode. See H264 Filter Settings for more details.</summary>
    [JsonPropertyName("filterSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettings>? FilterSettings { get; set; }

    /// <summary>Four bit AFD value to write on all frames of video in the output stream.</summary>
    [JsonPropertyName("fixedAfd")]
    public string? FixedAfd { get; set; }

    /// <summary></summary>
    [JsonPropertyName("flickerAq")]
    public string? FlickerAq { get; set; }

    /// <summary>Framerate denominator.</summary>
    [JsonPropertyName("framerateDenominator")]
    public double? FramerateDenominator { get; set; }

    /// <summary>Framerate numerator.</summary>
    [JsonPropertyName("framerateNumerator")]
    public double? FramerateNumerator { get; set; }

    /// <summary>Frequency of closed GOPs.</summary>
    [JsonPropertyName("gopClosedCadence")]
    public double? GopClosedCadence { get; set; }

    /// <summary>GOP size in units of either frames of seconds per gop_size_units.</summary>
    [JsonPropertyName("gopSize")]
    public double? GopSize { get; set; }

    /// <summary>Indicates if the gop_size is specified in frames or seconds.</summary>
    [JsonPropertyName("gopSizeUnits")]
    public string? GopSizeUnits { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Amount of lookahead.</summary>
    [JsonPropertyName("lookAheadRateControl")]
    public string? LookAheadRateControl { get; set; }

    /// <summary>Set the maximum bitrate in order to accommodate expected spikes in the complexity of the video.</summary>
    [JsonPropertyName("maxBitrate")]
    public double? MaxBitrate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minIInterval")]
    public double? MinIInterval { get; set; }

    /// <summary>Pixel Aspect Ratio denominator.</summary>
    [JsonPropertyName("parDenominator")]
    public double? ParDenominator { get; set; }

    /// <summary>Pixel Aspect Ratio numerator.</summary>
    [JsonPropertyName("parNumerator")]
    public double? ParNumerator { get; set; }

    /// <summary>AAC profile.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>Controls the target quality for the video encode.</summary>
    [JsonPropertyName("qvbrQualityLevel")]
    public double? QvbrQualityLevel { get; set; }

    /// <summary>The rate control mode.</summary>
    [JsonPropertyName("rateControlMode")]
    public string? RateControlMode { get; set; }

    /// <summary>Sets the scan type of the output.</summary>
    [JsonPropertyName("scanType")]
    public string? ScanType { get; set; }

    /// <summary>Scene change detection.</summary>
    [JsonPropertyName("sceneChangeDetect")]
    public string? SceneChangeDetect { get; set; }

    /// <summary>Number of slices per picture.</summary>
    [JsonPropertyName("slices")]
    public double? Slices { get; set; }

    /// <summary>Set the H265 tier in the output.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>Apply a burned in timecode. See H265 Timecode Burnin Settings for more details.</summary>
    [JsonPropertyName("timecodeBurninSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsTimecodeBurninSettings>? TimecodeBurninSettings { get; set; }

    /// <summary>Determines how timecodes should be inserted into the video elementary stream.</summary>
    [JsonPropertyName("timecodeInsertion")]
    public string? TimecodeInsertion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettings
{
    /// <summary>Frame capture settings. See Frame Capture Settings for more details.</summary>
    [JsonPropertyName("frameCaptureSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings>? FrameCaptureSettings { get; set; }

    /// <summary>H264 settings. See H264 Settings for more details.</summary>
    [JsonPropertyName("h264Settings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH264Settings>? H264Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("h265Settings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265Settings>? H265Settings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptions
{
    /// <summary>Audio codec settings. See Audio Codec Settings for more details.</summary>
    [JsonPropertyName("codecSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettings>? CodecSettings { get; set; }

    /// <summary>See the description in left_offset. For height, specify the entire height of the rectangle as a percentage of the underlying frame height. For example, "80" means the rectangle height is 80% of the underlying frame height. The top_offset and rectangle_height must add up to 100% or less. This field corresponds to tts:extent - Y in the TTML standard.</summary>
    [JsonPropertyName("height")]
    public double? Height { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Indicate how to respond to the AFD values that might be in the input video.</summary>
    [JsonPropertyName("respondToAfd")]
    public string? RespondToAfd { get; set; }

    /// <summary>Behavior on how to scale.</summary>
    [JsonPropertyName("scalingBehavior")]
    public string? ScalingBehavior { get; set; }

    /// <summary>Changes the strength of the anti-alias filter used for scaling.</summary>
    [JsonPropertyName("sharpness")]
    public double? Sharpness { get; set; }

    /// <summary>See the description in left_offset. For width, specify the entire width of the rectangle as a percentage of the underlying frame width. For example, "80" means the rectangle width is 80% of the underlying frame width. The left_offset and rectangle_width must add up to 100% or less. This field corresponds to tts:extent - X in the TTML standard.</summary>
    [JsonPropertyName("width")]
    public double? Width { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderEncoderSettings
{
    /// <summary>Audio descriptions for the channel. See Audio Descriptions for more details.</summary>
    [JsonPropertyName("audioDescriptions")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsAudioDescriptions>? AudioDescriptions { get; set; }

    /// <summary>Settings for ad avail blanking. See Avail Blanking for more details.</summary>
    [JsonPropertyName("availBlanking")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsAvailBlanking>? AvailBlanking { get; set; }

    /// <summary>Caption Descriptions. See Caption Descriptions for more details.</summary>
    [JsonPropertyName("captionDescriptions")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsCaptionDescriptions>? CaptionDescriptions { get; set; }

    /// <summary>Configuration settings that apply to the event as a whole. See Global Configuration for more details.</summary>
    [JsonPropertyName("globalConfiguration")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsGlobalConfiguration>? GlobalConfiguration { get; set; }

    /// <summary>Settings for motion graphics. See Motion Graphics Configuration for more details.</summary>
    [JsonPropertyName("motionGraphicsConfiguration")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsMotionGraphicsConfiguration>? MotionGraphicsConfiguration { get; set; }

    /// <summary>Nielsen configuration settings. See Nielsen Configuration for more details.</summary>
    [JsonPropertyName("nielsenConfiguration")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsNielsenConfiguration>? NielsenConfiguration { get; set; }

    /// <summary>Output groups for the channel. See Output Groups for more details.</summary>
    [JsonPropertyName("outputGroups")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsOutputGroups>? OutputGroups { get; set; }

    /// <summary>Contains settings used to acquire and adjust timecode information from inputs. See Timecode Config for more details.</summary>
    [JsonPropertyName("timecodeConfig")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsTimecodeConfig>? TimecodeConfig { get; set; }

    /// <summary>Video Descriptions. See Video Descriptions for more details.</summary>
    [JsonPropertyName("videoDescriptions")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettingsVideoDescriptions>? VideoDescriptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings
{
    /// <summary>The name of the audio selector in the input that MediaLive should monitor to detect silence. Select your most important rendition. If you didn't create an audio selector in this input, leave blank.</summary>
    [JsonPropertyName("audioSelectorName")]
    public string? AudioSelectorName { get; set; }

    /// <summary>The amount of time (in milliseconds) that the active input must be silent before automatic input failover occurs. Silence is defined as audio loss or audio quieter than -50 dBFS.</summary>
    [JsonPropertyName("audioSilenceThresholdMsec")]
    public double? AudioSilenceThresholdMsec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsInputLossSettings
{
    /// <summary>The amount of time (in milliseconds) that no input is detected. After that time, an input failover will occur.</summary>
    [JsonPropertyName("inputLossThresholdMsec")]
    public double? InputLossThresholdMsec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsVideoBlackSettings
{
    /// <summary>A value used in calculating the threshold below which MediaLive considers a pixel to be 'black'. For the input to be considered black, every pixel in a frame must be below this threshold. The threshold is calculated as a percentage (expressed as a decimal) of white. Therefore .1 means 10% white (or 90% black). Note how the formula works for any color depth. For example, if you set this field to 0.1 in 10-bit color depth: (10230.1=102.3), which means a pixel value of 102 or less is 'black'. If you set this field to .1 in an 8-bit color depth: (2550.1=25.5), which means a pixel value of 25 or less is 'black'. The range is 0.0 to 1.0, with any number of decimal places.</summary>
    [JsonPropertyName("blackDetectThreshold")]
    public double? BlackDetectThreshold { get; set; }

    /// <summary>The amount of time (in milliseconds) that the active input must be black before automatic input failover occurs.</summary>
    [JsonPropertyName("videoBlackThresholdMsec")]
    public double? VideoBlackThresholdMsec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettings
{
    /// <summary>MediaLive will perform a failover if the specified audio selector is silent for the specified period. See Audio Silence Failover Settings for more details.</summary>
    [JsonPropertyName("audioSilenceSettings")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings>? AudioSilenceSettings { get; set; }

    /// <summary>MediaLive will perform a failover if content is not detected in this input for the specified period. See Input Loss Failover Settings for more details.</summary>
    [JsonPropertyName("inputLossSettings")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsInputLossSettings>? InputLossSettings { get; set; }

    /// <summary>MediaLive will perform a failover if content is considered black for the specified period. See Video Black Failover Settings for more details.</summary>
    [JsonPropertyName("videoBlackSettings")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsVideoBlackSettings>? VideoBlackSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverCondition
{
    /// <summary>Failover condition type-specific settings. See Failover Condition Settings for more details.</summary>
    [JsonPropertyName("failoverConditionSettings")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettings>? FailoverConditionSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettings
{
    /// <summary>This clear time defines the requirement a recovered input must meet to be considered healthy. The input must have no failover conditions for this length of time. Enter a time in milliseconds. This value is particularly important if the input_preference for the failover pair is set to PRIMARY_INPUT_PREFERRED, because after this time, MediaLive will switch back to the primary input.</summary>
    [JsonPropertyName("errorClearTimeMsec")]
    public double? ErrorClearTimeMsec { get; set; }

    /// <summary>A list of failover conditions. If any of these conditions occur, MediaLive will perform a failover to the other input. See Failover Condition Block for more details.</summary>
    [JsonPropertyName("failoverCondition")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverCondition>? FailoverCondition { get; set; }

    /// <summary>Input preference when deciding which input to make active when a previously failed input has recovered.</summary>
    [JsonPropertyName("inputPreference")]
    public string? InputPreference { get; set; }

    /// <summary>The input ID of the secondary input in the automatic input failover pair.</summary>
    [JsonPropertyName("secondaryInputId")]
    public string? SecondaryInputId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Input in medialive to populate inputId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ChannelSpecInitProviderInputAttachmentsInputIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Input in medialive to populate inputId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ChannelSpecInitProviderInputAttachmentsInputIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioHlsRenditionSelection
{
    /// <summary>Specifies the GROUP-ID in the #EXT-X-MEDIA tag of the target HLS audio rendition.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection
{
    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>When set to “strict”, the transport stream demux strictly identifies audio streams by their language descriptor. If a PMT update occurs such that an audio stream matching the initially selected language is no longer present then mute will be encoded until the language returns. If “loose”, then on a PMT update the demux will choose another audio stream in the program with the same stream type if it can’t find one with the same language.</summary>
    [JsonPropertyName("languageSelectionPolicy")]
    public string? LanguageSelectionPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioPidSelection
{
    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pid")]
    public double? Pid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionDolbyEDecode
{
    /// <summary>Applies only to Dolby E. Enter the program ID (according to the metadata in the audio) of the Dolby E program to extract from the specified track. One program extracted per audio selector. To select multiple programs, create multiple selectors with the same Track and different Program numbers. “All channels” means to ignore the program IDs and include all the channels in this selector; useful if metadata is known to be incorrect.</summary>
    [JsonPropertyName("programSelection")]
    public string? ProgramSelection { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionTracks
{
    /// <summary>1-based integer value that maps to a specific audio track.</summary>
    [JsonPropertyName("track")]
    public double? Track { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelection
{
    /// <summary>Configure decoding options for Dolby E streams - these should be Dolby E frames carried in PCM streams tagged with SMPTE-337. See Dolby E Decode for more details.</summary>
    [JsonPropertyName("dolbyEDecode")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionDolbyEDecode>? DolbyEDecode { get; set; }

    /// <summary>Selects one or more unique audio tracks from within a source. See Audio Tracks for more details.</summary>
    [JsonPropertyName("tracks")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionTracks>? Tracks { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettings
{
    /// <summary>Audio HLS Rendition Selection. See Audio HLS Rendition Selection for more details.</summary>
    [JsonPropertyName("audioHlsRenditionSelection")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioHlsRenditionSelection>? AudioHlsRenditionSelection { get; set; }

    /// <summary>Audio Language Selection. See Audio Language Selection for more details.</summary>
    [JsonPropertyName("audioLanguageSelection")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection>? AudioLanguageSelection { get; set; }

    /// <summary>Audio Pid Selection. See Audio PID Selection for more details.</summary>
    [JsonPropertyName("audioPidSelection")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioPidSelection>? AudioPidSelection { get; set; }

    /// <summary>Audio Track Selection. See Audio Track Selection for more details.</summary>
    [JsonPropertyName("audioTrackSelection")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelection>? AudioTrackSelection { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelector
{
    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The audio selector settings. See Audio Selector Settings for more details.</summary>
    [JsonPropertyName("selectorSettings")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettings>? SelectorSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAncillarySourceSettings
{
    /// <summary>Specifies the number (1 to 4) of the captions channel you want to extract from the ancillary captions. If you plan to convert the ancillary captions to another format, complete this field. If you plan to choose Embedded as the captions destination in the output (to pass through all the channels in the ancillary captions), leave this field blank because MediaLive ignores the field.</summary>
    [JsonPropertyName("sourceAncillaryChannelNumber")]
    public double? SourceAncillaryChannelNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAribSourceSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsDvbSubSourceSettings
{
    /// <summary>If you will configure a WebVTT caption description that references this caption selector, use this field to provide the language to consider when translating the image-based source to text.</summary>
    [JsonPropertyName("ocrLanguage")]
    public string? OcrLanguage { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pid")]
    public double? Pid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsEmbeddedSourceSettings
{
    /// <summary>If upconvert, 608 data is both passed through via the “608 compatibility bytes” fields of the 708 wrapper as well as translated into 708. 708 data present in the source content will be discarded.</summary>
    [JsonPropertyName("convert608To708")]
    public string? Convert608To708 { get; set; }

    /// <summary>Set to “auto” to handle streams with intermittent and/or non-aligned SCTE-20 and Embedded captions.</summary>
    [JsonPropertyName("scte20Detection")]
    public string? Scte20Detection { get; set; }

    /// <summary>Specifies the 608/708 channel number within the video track from which to extract captions. Unused for passthrough.</summary>
    [JsonPropertyName("source608ChannelNumber")]
    public double? Source608ChannelNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte20SourceSettings
{
    /// <summary>If upconvert, 608 data is both passed through via the “608 compatibility bytes” fields of the 708 wrapper as well as translated into 708. 708 data present in the source content will be discarded.</summary>
    [JsonPropertyName("convert608To708")]
    public string? Convert608To708 { get; set; }

    /// <summary>Specifies the 608/708 channel number within the video track from which to extract captions. Unused for passthrough.</summary>
    [JsonPropertyName("source608ChannelNumber")]
    public double? Source608ChannelNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte27SourceSettings
{
    /// <summary>If you will configure a WebVTT caption description that references this caption selector, use this field to provide the language to consider when translating the image-based source to text.</summary>
    [JsonPropertyName("ocrLanguage")]
    public string? OcrLanguage { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pid")]
    public double? Pid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle
{
    /// <summary>See the description in left_offset. For height, specify the entire height of the rectangle as a percentage of the underlying frame height. For example, "80" means the rectangle height is 80% of the underlying frame height. The top_offset and rectangle_height must add up to 100% or less. This field corresponds to tts:extent - Y in the TTML standard.</summary>
    [JsonPropertyName("height")]
    public double? Height { get; set; }

    /// <summary>Applies only if you plan to convert these source captions to EBU-TT-D or TTML in an output. (Make sure to leave the default if you don’t have either of these formats in the output.) You can define a display rectangle for the captions that is smaller than the underlying video frame. You define the rectangle by specifying the position of the left edge, top edge, bottom edge, and right edge of the rectangle, all within the underlying video frame. The units for the measurements are percentages. If you specify a value for one of these fields, you must specify a value for all of them. For leftOffset, specify the position of the left edge of the rectangle, as a percentage of the underlying frame width, and relative to the left edge of the frame. For example, "10" means the measurement is 10% of the underlying frame width. The rectangle left edge starts at that position from the left edge of the frame. This field corresponds to tts:origin - X in the TTML standard.</summary>
    [JsonPropertyName("leftOffset")]
    public double? LeftOffset { get; set; }

    /// <summary>See the description in left_offset. For top_offset, specify the position of the top edge of the rectangle, as a percentage of the underlying frame height, and relative to the top edge of the frame. For example, "10" means the measurement is 10% of the underlying frame height. The rectangle top edge starts at that position from the top edge of the frame. This field corresponds to tts:origin - Y in the TTML standard.</summary>
    [JsonPropertyName("topOffset")]
    public double? TopOffset { get; set; }

    /// <summary>See the description in left_offset. For width, specify the entire width of the rectangle as a percentage of the underlying frame width. For example, "80" means the rectangle width is 80% of the underlying frame width. The left_offset and rectangle_width must add up to 100% or less. This field corresponds to tts:extent - X in the TTML standard.</summary>
    [JsonPropertyName("width")]
    public double? Width { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettings
{
    /// <summary>Optionally defines a region where TTML style captions will be displayed. See Caption Rectangle for more details.</summary>
    [JsonPropertyName("outputRectangle")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle>? OutputRectangle { get; set; }

    /// <summary>Specifies the teletext page number within the data stream from which to extract captions. Range of 0x100 (256) to 0x8FF (2303). Unused for passthrough. Should be specified as a hexadecimal string with no “0x” prefix.</summary>
    [JsonPropertyName("pageNumber")]
    public string? PageNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettings
{
    /// <summary>Ancillary Source Settings. See Ancillary Source Settings for more details.</summary>
    [JsonPropertyName("ancillarySourceSettings")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAncillarySourceSettings>? AncillarySourceSettings { get; set; }

    /// <summary>ARIB Source Settings.</summary>
    [JsonPropertyName("aribSourceSettings")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAribSourceSettings>? AribSourceSettings { get; set; }

    /// <summary>DVB Sub Source Settings. See DVB Sub Source Settings for more details.</summary>
    [JsonPropertyName("dvbSubSourceSettings")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsDvbSubSourceSettings>? DvbSubSourceSettings { get; set; }

    /// <summary>Embedded Source Settings. See Embedded Source Settings for more details.</summary>
    [JsonPropertyName("embeddedSourceSettings")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsEmbeddedSourceSettings>? EmbeddedSourceSettings { get; set; }

    /// <summary>SCTE20 Source Settings. See SCTE 20 Source Settings for more details.</summary>
    [JsonPropertyName("scte20SourceSettings")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte20SourceSettings>? Scte20SourceSettings { get; set; }

    /// <summary>SCTE27 Source Settings. See SCTE 27 Source Settings for more details.</summary>
    [JsonPropertyName("scte27SourceSettings")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte27SourceSettings>? Scte27SourceSettings { get; set; }

    /// <summary>Teletext Source Settings. See Teletext Source Settings for more details.</summary>
    [JsonPropertyName("teletextSourceSettings")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettings>? TeletextSourceSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelector
{
    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The audio selector settings. See Audio Selector Settings for more details.</summary>
    [JsonPropertyName("selectorSettings")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettings>? SelectorSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsNetworkInputSettingsHlsInputSettings
{
    /// <summary>The bitrate is specified in bits per second, as in an HLS manifest.</summary>
    [JsonPropertyName("bandwidth")]
    public double? Bandwidth { get; set; }

    /// <summary>Buffer segments.</summary>
    [JsonPropertyName("bufferSegments")]
    public double? BufferSegments { get; set; }

    /// <summary>The number of consecutive times that attempts to read a manifest or segment must fail before the input is considered unavailable.</summary>
    [JsonPropertyName("retries")]
    public double? Retries { get; set; }

    /// <summary>The number of seconds between retries when an attempt to read a manifest or segment fails.</summary>
    [JsonPropertyName("retryInterval")]
    public double? RetryInterval { get; set; }

    /// <summary>The source for the timecode that will be associated with the events outputs.</summary>
    [JsonPropertyName("scte35Source")]
    public string? Scte35Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsNetworkInputSettings
{
    /// <summary>Specifies HLS input settings when the uri is for a HLS manifest. See HLS Input Settings for more details.</summary>
    [JsonPropertyName("hlsInputSettings")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsNetworkInputSettingsHlsInputSettings>? HlsInputSettings { get; set; }

    /// <summary>Check HTTPS server certificates.</summary>
    [JsonPropertyName("serverValidation")]
    public string? ServerValidation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsVideoSelector
{
    /// <summary></summary>
    [JsonPropertyName("colorSpace")]
    public string? ColorSpace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("colorSpaceUsage")]
    public string? ColorSpaceUsage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachmentsInputSettings
{
    /// <summary></summary>
    [JsonPropertyName("audioSelector")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelector>? AudioSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("captionSelector")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelector>? CaptionSelector { get; set; }

    /// <summary>Enable or disable the deblock filter when filtering.</summary>
    [JsonPropertyName("deblockFilter")]
    public string? DeblockFilter { get; set; }

    /// <summary>Enable or disable the denoise filter when filtering.</summary>
    [JsonPropertyName("denoiseFilter")]
    public string? DenoiseFilter { get; set; }

    /// <summary>Adjusts the magnitude of filtering from 1 (minimal) to 5 (strongest).</summary>
    [JsonPropertyName("filterStrength")]
    public double? FilterStrength { get; set; }

    /// <summary>Turns on the filter for the input.</summary>
    [JsonPropertyName("inputFilter")]
    public string? InputFilter { get; set; }

    /// <summary>Input settings. See Network Input Settings for more details.</summary>
    [JsonPropertyName("networkInputSettings")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsNetworkInputSettings>? NetworkInputSettings { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public double? Scte35Pid { get; set; }

    /// <summary>Specifies whether to extract applicable ancillary data from a SMPTE-2038 source in the input.</summary>
    [JsonPropertyName("smpte2038DataPreference")]
    public string? Smpte2038DataPreference { get; set; }

    /// <summary>Loop input if it is a file.</summary>
    [JsonPropertyName("sourceEndBehavior")]
    public string? SourceEndBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("videoSelector")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettingsVideoSelector>? VideoSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputAttachments
{
    /// <summary>User-specified settings for defining what the conditions are for declaring the input unhealthy and failing over to a different input. See Automatic Input Failover Settings for more details.</summary>
    [JsonPropertyName("automaticInputFailoverSettings")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettings>? AutomaticInputFailoverSettings { get; set; }

    /// <summary>User-specified name for the attachment.</summary>
    [JsonPropertyName("inputAttachmentName")]
    public string? InputAttachmentName { get; set; }

    /// <summary>The ID of the input.</summary>
    [JsonPropertyName("inputId")]
    public string? InputId { get; set; }

    /// <summary>Reference to a Input in medialive to populate inputId.</summary>
    [JsonPropertyName("inputIdRef")]
    public V1beta1ChannelSpecInitProviderInputAttachmentsInputIdRef? InputIdRef { get; set; }

    /// <summary>Selector for a Input in medialive to populate inputId.</summary>
    [JsonPropertyName("inputIdSelector")]
    public V1beta1ChannelSpecInitProviderInputAttachmentsInputIdSelector? InputIdSelector { get; set; }

    /// <summary>Settings of an input. See Input Settings for more details.</summary>
    [JsonPropertyName("inputSettings")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachmentsInputSettings>? InputSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderInputSpecification
{
    /// <summary></summary>
    [JsonPropertyName("codec")]
    public string? Codec { get; set; }

    /// <summary>- Maximum CDI input resolution.</summary>
    [JsonPropertyName("inputResolution")]
    public string? InputResolution { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("maximumBitrate")]
    public string? MaximumBitrate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderMaintenance
{
    /// <summary>The day of the week to use for maintenance.</summary>
    [JsonPropertyName("maintenanceDay")]
    public string? MaintenanceDay { get; set; }

    /// <summary>The hour maintenance will start.</summary>
    [JsonPropertyName("maintenanceStartTime")]
    public string? MaintenanceStartTime { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ChannelSpecInitProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ChannelSpecInitProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProviderVpc
{
    /// <summary>List of public address allocation ids to associate with ENIs that will be created in Output VPC. Must specify one for SINGLE_PIPELINE, two for STANDARD channels.</summary>
    [JsonPropertyName("publicAddressAllocationIds")]
    public IList<string>? PublicAddressAllocationIds { get; set; }

    /// <summary>A list of up to 5 EC2 VPC security group IDs to attach to the Output VPC network interfaces. If none are specified then the VPC default security group will be used.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>A list of VPC subnet IDs from the same VPC. If STANDARD channel, subnet IDs must be mapped to two unique availability zones (AZ).</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecInitProvider
{
    /// <summary>Specification of CDI inputs for this channel. See CDI Input Specification for more details.</summary>
    [JsonPropertyName("cdiInputSpecification")]
    public IList<V1beta1ChannelSpecInitProviderCdiInputSpecification>? CdiInputSpecification { get; set; }

    /// <summary>Concise argument description.</summary>
    [JsonPropertyName("channelClass")]
    public string? ChannelClass { get; set; }

    /// <summary>Destinations for channel. See Destinations for more details.</summary>
    [JsonPropertyName("destinations")]
    public IList<V1beta1ChannelSpecInitProviderDestinations>? Destinations { get; set; }

    /// <summary>Encoder settings. See Encoder Settings for more details.</summary>
    [JsonPropertyName("encoderSettings")]
    public IList<V1beta1ChannelSpecInitProviderEncoderSettings>? EncoderSettings { get; set; }

    /// <summary>Input attachments for the channel. See Input Attachments for more details.</summary>
    [JsonPropertyName("inputAttachments")]
    public IList<V1beta1ChannelSpecInitProviderInputAttachments>? InputAttachments { get; set; }

    /// <summary>Specification of network and file inputs for the channel.</summary>
    [JsonPropertyName("inputSpecification")]
    public IList<V1beta1ChannelSpecInitProviderInputSpecification>? InputSpecification { get; set; }

    /// <summary>The log level to write to Cloudwatch logs.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>Maintenance settings for this channel. See Maintenance for more details.</summary>
    [JsonPropertyName("maintenance")]
    public IList<V1beta1ChannelSpecInitProviderMaintenance>? Maintenance { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Concise argument description.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1ChannelSpecInitProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1ChannelSpecInitProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Whether to start/stop channel. Default: false</summary>
    [JsonPropertyName("startChannel")]
    public bool? StartChannel { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Settings for the VPC outputs. See VPC for more details.</summary>
    [JsonPropertyName("vpc")]
    public IList<V1beta1ChannelSpecInitProviderVpc>? Vpc { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecProviderConfigRefPolicy
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
public partial class V1beta1ChannelSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ChannelSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ChannelSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ChannelSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ChannelSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ChannelSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ChannelSpec defines the desired state of Channel</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ChannelSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ChannelSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ChannelSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ChannelSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ChannelSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderCdiInputSpecification
{
    /// <summary>- Maximum CDI input resolution.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderDestinationsMediaPackageSettings
{
    /// <summary>ID of the channel in MediaPackage that is the destination for this output group.</summary>
    [JsonPropertyName("channelId")]
    public string? ChannelId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderDestinationsMultiplexSettings
{
    /// <summary>The ID of the Multiplex that the encoder is providing output to.</summary>
    [JsonPropertyName("multiplexId")]
    public string? MultiplexId { get; set; }

    /// <summary>The program name of the Multiplex program that the encoder is providing output to.</summary>
    [JsonPropertyName("programName")]
    public string? ProgramName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderDestinationsSettings
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Stream name RTMP destinations (URLs of type rtmp://)</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }

    /// <summary>A URL specifying a destination.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderDestinations
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Destination settings for a MediaPackage output; one destination for both encoders. See Media Package Settings for more details.</summary>
    [JsonPropertyName("mediaPackageSettings")]
    public IList<V1beta1ChannelStatusAtProviderDestinationsMediaPackageSettings>? MediaPackageSettings { get; set; }

    /// <summary>Destination settings for a Multiplex output; one destination for both encoders. See Multiplex Settings for more details.</summary>
    [JsonPropertyName("multiplexSettings")]
    public IList<V1beta1ChannelStatusAtProviderDestinationsMultiplexSettings>? MultiplexSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("settings")]
    public IList<V1beta1ChannelStatusAtProviderDestinationsSettings>? Settings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsAudioNormalizationSettings
{
    /// <summary>Audio normalization algorithm to use. itu17701 conforms to the CALM Act specification, itu17702 to the EBU R-128 specification.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Algorithm control for the audio description.</summary>
    [JsonPropertyName("algorithmControl")]
    public string? AlgorithmControl { get; set; }

    /// <summary>Target LKFS (loudness) to adjust volume to.</summary>
    [JsonPropertyName("targetLkfs")]
    public double? TargetLkfs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenCbetSettings
{
    /// <summary></summary>
    [JsonPropertyName("cbetCheckDigitString")]
    public string? CbetCheckDigitString { get; set; }

    /// <summary>Determines the method of CBET insertion mode when prior encoding is detected on the same layer.</summary>
    [JsonPropertyName("cbetStepaside")]
    public string? CbetStepaside { get; set; }

    /// <summary>CBET source ID to use in the watermark.</summary>
    [JsonPropertyName("csid")]
    public string? Csid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenNaesIiNwSettings
{
    /// <summary></summary>
    [JsonPropertyName("checkDigitString")]
    public string? CheckDigitString { get; set; }

    /// <summary>The Nielsen Source ID to include in the watermark.</summary>
    [JsonPropertyName("sid")]
    public double? Sid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettings
{
    /// <summary>Used to insert watermarks of type Nielsen CBET. See Nielsen CBET Settings for more details.</summary>
    [JsonPropertyName("nielsenCbetSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenCbetSettings>? NielsenCbetSettings { get; set; }

    /// <summary>Distribution types to assign to the watermarks. Options are PROGRAM_CONTENT and FINAL_DISTRIBUTOR.</summary>
    [JsonPropertyName("nielsenDistributionType")]
    public string? NielsenDistributionType { get; set; }

    /// <summary>Used to insert watermarks of type Nielsen NAES, II (N2) and Nielsen NAES VI (NW). See Nielsen NAES II NW Settings for more details.</summary>
    [JsonPropertyName("nielsenNaesIiNwSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenNaesIiNwSettings>? NielsenNaesIiNwSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("nielsenWatermarksSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettings>? NielsenWatermarksSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsAacSettings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Set to "broadcasterMixedAd" when input contains pre-mixed main audio + AD (narration) as a stereo pair.</summary>
    [JsonPropertyName("inputType")]
    public string? InputType { get; set; }

    /// <summary>AAC profile.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>The rate control mode.</summary>
    [JsonPropertyName("rateControlMode")]
    public string? RateControlMode { get; set; }

    /// <summary>Sets LATM/LOAS AAC output for raw containers.</summary>
    [JsonPropertyName("rawFormat")]
    public string? RawFormat { get; set; }

    /// <summary>Sample rate in Hz.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }

    /// <summary>Use MPEG-2 AAC audio instead of MPEG-4 AAC audio for raw or MPEG-2 Transport Stream containers.</summary>
    [JsonPropertyName("spec")]
    public string? Spec { get; set; }

    /// <summary>VBR Quality Level - Only used if rateControlMode is VBR.</summary>
    [JsonPropertyName("vbrQuality")]
    public string? VbrQuality { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsAc3Settings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Specifies the bitstream mode (bsmod) for the emitted AC-3 stream.</summary>
    [JsonPropertyName("bitstreamMode")]
    public string? BitstreamMode { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sets the dialnorm of the output.</summary>
    [JsonPropertyName("dialnorm")]
    public double? Dialnorm { get; set; }

    /// <summary>If set to filmStandard, adds dynamic range compression signaling to the output bitstream as defined in the Dolby Digital specification.</summary>
    [JsonPropertyName("drcProfile")]
    public string? DrcProfile { get; set; }

    /// <summary>When set to enabled, applies a 120Hz lowpass filter to the LFE channel prior to encoding.</summary>
    [JsonPropertyName("lfeFilter")]
    public string? LfeFilter { get; set; }

    /// <summary>Metadata control.</summary>
    [JsonPropertyName("metadataControl")]
    public string? MetadataControl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sets the dialnorm of the output.</summary>
    [JsonPropertyName("dialnorm")]
    public double? Dialnorm { get; set; }

    /// <summary>Sets the Dolby dynamic range compression profile.</summary>
    [JsonPropertyName("drcLine")]
    public string? DrcLine { get; set; }

    /// <summary>Sets the profile for heavy Dolby dynamic range compression.</summary>
    [JsonPropertyName("drcRf")]
    public string? DrcRf { get; set; }

    /// <summary>Height dimensional trim.</summary>
    [JsonPropertyName("heightTrim")]
    public double? HeightTrim { get; set; }

    /// <summary>Surround dimensional trim.</summary>
    [JsonPropertyName("surroundTrim")]
    public double? SurroundTrim { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3Settings
{
    /// <summary>Sets the attenuation control.</summary>
    [JsonPropertyName("attenuationControl")]
    public string? AttenuationControl { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Specifies the bitstream mode (bsmod) for the emitted AC-3 stream.</summary>
    [JsonPropertyName("bitstreamMode")]
    public string? BitstreamMode { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dcFilter")]
    public string? DcFilter { get; set; }

    /// <summary>Sets the dialnorm of the output.</summary>
    [JsonPropertyName("dialnorm")]
    public double? Dialnorm { get; set; }

    /// <summary>Sets the Dolby dynamic range compression profile.</summary>
    [JsonPropertyName("drcLine")]
    public string? DrcLine { get; set; }

    /// <summary>Sets the profile for heavy Dolby dynamic range compression.</summary>
    [JsonPropertyName("drcRf")]
    public string? DrcRf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lfeControl")]
    public string? LfeControl { get; set; }

    /// <summary>When set to enabled, applies a 120Hz lowpass filter to the LFE channel prior to encoding.</summary>
    [JsonPropertyName("lfeFilter")]
    public string? LfeFilter { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("loRoCenterMixLevel")]
    public double? LoRoCenterMixLevel { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("loRoSurroundMixLevel")]
    public double? LoRoSurroundMixLevel { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("ltRtCenterMixLevel")]
    public double? LtRtCenterMixLevel { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("ltRtSurroundMixLevel")]
    public double? LtRtSurroundMixLevel { get; set; }

    /// <summary>Metadata control.</summary>
    [JsonPropertyName("metadataControl")]
    public string? MetadataControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passthroughControl")]
    public string? PassthroughControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("phaseControl")]
    public string? PhaseControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stereoDownmix")]
    public string? StereoDownmix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("surroundExMode")]
    public string? SurroundExMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("surroundMode")]
    public string? SurroundMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsMp2Settings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sample rate in Hz.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsPassThroughSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsWavSettings
{
    /// <summary></summary>
    [JsonPropertyName("bitDepth")]
    public double? BitDepth { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sample rate in Hz.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettings
{
    /// <summary>Aac Settings. See AAC Settings for more details.</summary>
    [JsonPropertyName("aacSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsAacSettings>? AacSettings { get; set; }

    /// <summary>Ac3 Settings. See AC3 Settings for more details.</summary>
    [JsonPropertyName("ac3Settings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsAc3Settings>? Ac3Settings { get; set; }

    /// <summary>- Eac3 Atmos Settings. See EAC3 Atmos Settings</summary>
    [JsonPropertyName("eac3AtmosSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings>? Eac3AtmosSettings { get; set; }

    /// <summary>- Eac3 Settings. See EAC3 Settings</summary>
    [JsonPropertyName("eac3Settings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3Settings>? Eac3Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("mp2Settings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsMp2Settings>? Mp2Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("passThroughSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsPassThroughSettings>? PassThroughSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("wavSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsWavSettings>? WavSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappingsInputChannelLevels
{
    /// <summary></summary>
    [JsonPropertyName("gain")]
    public double? Gain { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inputChannel")]
    public double? InputChannel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings
{
    /// <summary></summary>
    [JsonPropertyName("inputChannelLevels")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappingsInputChannelLevels>? InputChannelLevels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outputChannel")]
    public double? OutputChannel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsRemixSettings
{
    /// <summary></summary>
    [JsonPropertyName("channelMappings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings>? ChannelMappings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("channelsIn")]
    public double? ChannelsIn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("channelsOut")]
    public double? ChannelsOut { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptions
{
    /// <summary>Advanced audio normalization settings. See Audio Normalization Settings for more details.</summary>
    [JsonPropertyName("audioNormalizationSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsAudioNormalizationSettings>? AudioNormalizationSettings { get; set; }

    /// <summary>The name of the audio selector in the input that MediaLive should monitor to detect silence. Select your most important rendition. If you didn't create an audio selector in this input, leave blank.</summary>
    [JsonPropertyName("audioSelectorName")]
    public string? AudioSelectorName { get; set; }

    /// <summary>Applies only if audioTypeControl is useConfigured. The values for audioType are defined in ISO-IEC 13818-1.</summary>
    [JsonPropertyName("audioType")]
    public string? AudioType { get; set; }

    /// <summary>Determined how audio type is determined.</summary>
    [JsonPropertyName("audioTypeControl")]
    public string? AudioTypeControl { get; set; }

    /// <summary>Settings to configure one or more solutions that insert audio watermarks in the audio encode. See Audio Watermark Settings for more details.</summary>
    [JsonPropertyName("audioWatermarkSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettings>? AudioWatermarkSettings { get; set; }

    /// <summary>Audio codec settings. See Audio Codec Settings for more details.</summary>
    [JsonPropertyName("codecSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettings>? CodecSettings { get; set; }

    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("languageCodeControl")]
    public string? LanguageCodeControl { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("remixSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptionsRemixSettings>? RemixSettings { get; set; }

    /// <summary>Stream name RTMP destinations (URLs of type rtmp://)</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsAvailBlankingAvailBlankingImage
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>–  Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsAvailBlanking
{
    /// <summary>Blanking image to be used. See Avail Blanking Image for more details.</summary>
    [JsonPropertyName("availBlankingImage")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsAvailBlankingAvailBlankingImage>? AvailBlankingImage { get; set; }

    /// <summary>When set to enabled, causes video, audio and captions to be blanked when insertion metadata is added.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsAribDestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettingsFont
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>–  Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettings
{
    /// <summary>justify live subtitles and center-justify pre-recorded subtitles. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("alignment")]
    public string? Alignment { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundOpacity")]
    public double? BackgroundOpacity { get; set; }

    /// <summary>in. File extension must be ‘ttf’ or ‘tte’. Although the user can select output fonts for many different types of input captions, embedded, STL and teletext sources use a strict grid system. Using external fonts with these caption sources could cause unexpected display of proportional fonts. All burn-in and DVB-Sub font settings must match. See Font for more details.</summary>
    [JsonPropertyName("font")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettingsFont>? Font { get; set; }

    /// <summary>in captions. This option is not valid for source captions that are STL, 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontColor")]
    public string? FontColor { get; set; }

    /// <summary>in captions. 255 is opaque; 0 is transparent. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontOpacity")]
    public double? FontOpacity { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontResolution")]
    public double? FontResolution { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontSize")]
    public string? FontSize { get; set; }

    /// <summary>defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineColor")]
    public string? OutlineColor { get; set; }

    /// <summary>defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineSize")]
    public double? OutlineSize { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowColor")]
    public string? ShadowColor { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowOpacity")]
    public double? ShadowOpacity { get; set; }

    /// <summary>2 would result in a shadow offset 2 pixels to the left. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowXOffset")]
    public double? ShadowXOffset { get; set; }

    /// <summary>2 would result in a shadow offset 2 pixels above the text. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowYOffset")]
    public double? ShadowYOffset { get; set; }

    /// <summary>Sub/Burn-in outputs.</summary>
    [JsonPropertyName("teletextGridControl")]
    public string? TeletextGridControl { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("xPosition")]
    public double? XPosition { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("yPosition")]
    public double? YPosition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettingsFont
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>–  Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettings
{
    /// <summary>justify live subtitles and center-justify pre-recorded subtitles. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("alignment")]
    public string? Alignment { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundOpacity")]
    public double? BackgroundOpacity { get; set; }

    /// <summary>in. File extension must be ‘ttf’ or ‘tte’. Although the user can select output fonts for many different types of input captions, embedded, STL and teletext sources use a strict grid system. Using external fonts with these caption sources could cause unexpected display of proportional fonts. All burn-in and DVB-Sub font settings must match. See Font for more details.</summary>
    [JsonPropertyName("font")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettingsFont>? Font { get; set; }

    /// <summary>in captions. This option is not valid for source captions that are STL, 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontColor")]
    public string? FontColor { get; set; }

    /// <summary>in captions. 255 is opaque; 0 is transparent. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontOpacity")]
    public double? FontOpacity { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontResolution")]
    public double? FontResolution { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontSize")]
    public string? FontSize { get; set; }

    /// <summary>defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineColor")]
    public string? OutlineColor { get; set; }

    /// <summary>defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineSize")]
    public double? OutlineSize { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowColor")]
    public string? ShadowColor { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowOpacity")]
    public double? ShadowOpacity { get; set; }

    /// <summary>2 would result in a shadow offset 2 pixels to the left. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowXOffset")]
    public double? ShadowXOffset { get; set; }

    /// <summary>2 would result in a shadow offset 2 pixels above the text. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowYOffset")]
    public double? ShadowYOffset { get; set; }

    /// <summary>Sub/Burn-in outputs.</summary>
    [JsonPropertyName("teletextGridControl")]
    public string? TeletextGridControl { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("xPosition")]
    public double? XPosition { get; set; }

    /// <summary>in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("yPosition")]
    public double? YPosition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEbuTtDDestinationSettings
{
    /// <summary>–  Complete this field if you want to include the name of the copyright holder in the copyright tag in the captions metadata.</summary>
    [JsonPropertyName("copyrightHolder")]
    public string? CopyrightHolder { get; set; }

    /// <summary>line captions). - enabled: Fill with the captions background color (as specified in the input captions). - disabled: Leave the gap unfilled.</summary>
    [JsonPropertyName("fillLineGap")]
    public string? FillLineGap { get; set; }

    /// <summary>TT captions. Valid only if styleControl is set to include. If you leave this field empty, the font family is set to “monospaced”. (If styleControl is set to exclude, the font family is always set to “monospaced”.) You specify only the font family. All other style information (color, bold, position and so on) is copied from the input captions. The size is always set to 100% to allow the downstream player to choose the size. - Enter a list of font families, as a comma-separated list of font names, in order of preference. The name can be a font family (such as “Arial”), or a generic font family (such as “serif”), or “default” (to let the downstream player choose the font). - Leave blank to set the family to “monospace”.</summary>
    [JsonPropertyName("fontFamily")]
    public string? FontFamily { get; set; }

    /// <summary>TT captions. - include: Take the style information (font color, font position, and so on) from the source captions and include that information in the font data attached to the EBU-TT captions. This option is valid only if the source captions are Embedded or Teletext. - exclude: In the font data attached to the EBU-TT captions, set the font family to “monospaced”. Do not include any other style information.</summary>
    [JsonPropertyName("styleControl")]
    public string? StyleControl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedDestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedPlusScte20DestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsRtmpCaptionInfoDestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte20PlusEmbeddedDestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte27DestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsSmpteTtDestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTeletextDestinationSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTtmlDestinationSettings
{
    /// <summary>TT captions. - include: Take the style information (font color, font position, and so on) from the source captions and include that information in the font data attached to the EBU-TT captions. This option is valid only if the source captions are Embedded or Teletext. - exclude: In the font data attached to the EBU-TT captions, set the font family to “monospaced”. Do not include any other style information.</summary>
    [JsonPropertyName("styleControl")]
    public string? StyleControl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsWebvttDestinationSettings
{
    /// <summary>TT captions. - include: Take the style information (font color, font position, and so on) from the source captions and include that information in the font data attached to the EBU-TT captions. This option is valid only if the source captions are Embedded or Teletext. - exclude: In the font data attached to the EBU-TT captions, set the font family to “monospaced”. Do not include any other style information.</summary>
    [JsonPropertyName("styleControl")]
    public string? StyleControl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettings
{
    /// <summary>ARIB Destination Settings.</summary>
    [JsonPropertyName("aribDestinationSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsAribDestinationSettings>? AribDestinationSettings { get; set; }

    /// <summary>Burn In Destination Settings. See Burn In Destination Settings for more details.</summary>
    [JsonPropertyName("burnInDestinationSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettings>? BurnInDestinationSettings { get; set; }

    /// <summary>DVB Sub Destination Settings. See DVB Sub Destination Settings for more details.</summary>
    [JsonPropertyName("dvbSubDestinationSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettings>? DvbSubDestinationSettings { get; set; }

    /// <summary>EBU TT D Destination Settings. See EBU TT D Destination Settings for more details.</summary>
    [JsonPropertyName("ebuTtDDestinationSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEbuTtDDestinationSettings>? EbuTtDDestinationSettings { get; set; }

    /// <summary>Embedded Destination Settings.</summary>
    [JsonPropertyName("embeddedDestinationSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedDestinationSettings>? EmbeddedDestinationSettings { get; set; }

    /// <summary>Embedded Plus SCTE20 Destination Settings.</summary>
    [JsonPropertyName("embeddedPlusScte20DestinationSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedPlusScte20DestinationSettings>? EmbeddedPlusScte20DestinationSettings { get; set; }

    /// <summary>RTMP Caption Info Destination Settings.</summary>
    [JsonPropertyName("rtmpCaptionInfoDestinationSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsRtmpCaptionInfoDestinationSettings>? RtmpCaptionInfoDestinationSettings { get; set; }

    /// <summary>SCTE20 Plus Embedded Destination Settings.</summary>
    [JsonPropertyName("scte20PlusEmbeddedDestinationSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte20PlusEmbeddedDestinationSettings>? Scte20PlusEmbeddedDestinationSettings { get; set; }

    /// <summary>–  SCTE27 Destination Settings.</summary>
    [JsonPropertyName("scte27DestinationSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte27DestinationSettings>? Scte27DestinationSettings { get; set; }

    /// <summary>–  SMPTE TT Destination Settings.</summary>
    [JsonPropertyName("smpteTtDestinationSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsSmpteTtDestinationSettings>? SmpteTtDestinationSettings { get; set; }

    /// <summary>–  Teletext Destination Settings.</summary>
    [JsonPropertyName("teletextDestinationSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTeletextDestinationSettings>? TeletextDestinationSettings { get; set; }

    /// <summary>–  TTML Destination Settings. See TTML Destination Settings for more details.</summary>
    [JsonPropertyName("ttmlDestinationSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTtmlDestinationSettings>? TtmlDestinationSettings { get; set; }

    /// <summary>WebVTT Destination Settings. See WebVTT Destination Settings for more details.</summary>
    [JsonPropertyName("webvttDestinationSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsWebvttDestinationSettings>? WebvttDestinationSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptions
{
    /// <summary>Indicates whether the caption track implements accessibility features such as written descriptions of spoken dialog, music, and sounds.</summary>
    [JsonPropertyName("accessibility")]
    public string? Accessibility { get; set; }

    /// <summary>Specifies which input caption selector to use as a caption source when generating output captions. This field should match a captionSelector name.</summary>
    [JsonPropertyName("captionSelectorName")]
    public string? CaptionSelectorName { get; set; }

    /// <summary>Additional settings for captions destination that depend on the destination type. See Destination Settings for more details.</summary>
    [JsonPropertyName("destinationSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettings>? DestinationSettings { get; set; }

    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Human readable information to indicate captions available for players (eg. English, or Spanish).</summary>
    [JsonPropertyName("languageDescription")]
    public string? LanguageDescription { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>–  Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsGlobalConfigurationInputLossBehavior
{
    /// <summary></summary>
    [JsonPropertyName("blackFrameMsec")]
    public double? BlackFrameMsec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inputLossImageColor")]
    public string? InputLossImageColor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inputLossImageSlate")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate>? InputLossImageSlate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inputLossImageType")]
    public string? InputLossImageType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repeatFrameMsec")]
    public double? RepeatFrameMsec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsGlobalConfiguration
{
    /// <summary>–  Value to set the initial audio gain for the Live Event.</summary>
    [JsonPropertyName("initialAudioGain")]
    public double? InitialAudioGain { get; set; }

    /// <summary>of-file). When switchAndLoopInputs is configured the encoder will restart at the beginning of the first input. When “none” is configured the encoder will transcode either black, a solid color, or a user specified slate images per the “Input Loss Behavior” configuration until the next input switch occurs (which is controlled through the Channel Schedule API).</summary>
    [JsonPropertyName("inputEndAction")]
    public string? InputEndAction { get; set; }

    /// <summary>Settings for system actions when input is lost. See Input Loss Behavior for more details.</summary>
    [JsonPropertyName("inputLossBehavior")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsGlobalConfigurationInputLossBehavior>? InputLossBehavior { get; set; }

    /// <summary>MediaLive will attempt to synchronize the output of each pipeline to the other. EPOCH_LOCKING - MediaLive will attempt to synchronize the output of each pipeline to the Unix epoch.</summary>
    [JsonPropertyName("outputLockingMode")]
    public string? OutputLockingMode { get; set; }

    /// <summary>–  Indicates whether the rate of frames emitted by the Live encoder should be paced by its system clock (which optionally may be locked to another source via NTP) or should be locked to the clock of the source that is providing the input stream.</summary>
    [JsonPropertyName("outputTimingSource")]
    public string? OutputTimingSource { get; set; }

    /// <summary>–  Adjusts video input buffer for streams with very low video framerates. This is commonly set to enabled for music channels with less than one video frame per second.</summary>
    [JsonPropertyName("supportLowFramerateInputs")]
    public string? SupportLowFramerateInputs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettingsHtmlMotionGraphicsSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings
{
    /// <summary>–  Html Motion Graphics Settings.</summary>
    [JsonPropertyName("htmlMotionGraphicsSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettingsHtmlMotionGraphicsSettings>? HtmlMotionGraphicsSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsMotionGraphicsConfiguration
{
    /// <summary>–  Motion Graphics Insertion.</summary>
    [JsonPropertyName("motionGraphicsInsertion")]
    public string? MotionGraphicsInsertion { get; set; }

    /// <summary>–  Motion Graphics Settings. See Motion Graphics Settings for more details.</summary>
    [JsonPropertyName("motionGraphicsSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings>? MotionGraphicsSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsNielsenConfiguration
{
    /// <summary>–  Enter the Distributor ID assigned to your organization by Nielsen.</summary>
    [JsonPropertyName("distributorId")]
    public string? DistributorId { get; set; }

    /// <summary>–  Enables Nielsen PCM to ID3 tagging.</summary>
    [JsonPropertyName("nielsenPcmToId3Tagging")]
    public string? NielsenPcmToId3Tagging { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettingsArchiveS3Settings
{
    /// <summary>Specify the canned ACL to apply to each S3 request.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettings
{
    /// <summary>Archive S3 Settings. See Archive S3 Settings for more details.</summary>
    [JsonPropertyName("archiveS3Settings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettingsArchiveS3Settings>? ArchiveS3Settings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettings
{
    /// <summary>Parameters that control the interactions with the CDN. See Archive CDN Settings for more details.</summary>
    [JsonPropertyName("archiveCdnSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettings>? ArchiveCdnSettings { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsDestination>? Destination { get; set; }

    /// <summary>Number of seconds to write to archive file before closing and starting a new one.</summary>
    [JsonPropertyName("rolloverInterval")]
    public double? RolloverInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettingsFrameCaptureS3Settings
{
    /// <summary>Specify the canned ACL to apply to each S3 request.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureS3Settings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettingsFrameCaptureS3Settings>? FrameCaptureS3Settings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettings
{
    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsDestination>? Destination { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureCdnSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettings>? FrameCaptureCdnSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsCaptionLanguageMappings
{
    /// <summary></summary>
    [JsonPropertyName("captionChannel")]
    public double? CaptionChannel { get; set; }

    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Human readable information to indicate captions available for players (eg. English, or Spanish).</summary>
    [JsonPropertyName("languageDescription")]
    public string? LanguageDescription { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsAkamaiSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpTransferMode")]
    public string? HttpTransferMode { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }

    /// <summary></summary>
    [JsonPropertyName("salt")]
    public string? Salt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsBasicPutSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsMediaStoreSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mediaStoreStorageClass")]
    public string? MediaStoreStorageClass { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsS3Settings
{
    /// <summary>Specify the canned ACL to apply to each S3 request.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsWebdavSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpTransferMode")]
    public string? HttpTransferMode { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsAkamaiSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsAkamaiSettings>? HlsAkamaiSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsBasicPutSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsBasicPutSettings>? HlsBasicPutSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsMediaStoreSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsMediaStoreSettings>? HlsMediaStoreSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsS3Settings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsS3Settings>? HlsS3Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsWebdavSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsWebdavSettings>? HlsWebdavSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettingsKeyProviderServer
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>–  Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettings
{
    /// <summary></summary>
    [JsonPropertyName("keyProviderServer")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettingsKeyProviderServer>? KeyProviderServer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("staticKeyValue")]
    public string? StaticKeyValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("staticKeySettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettings>? StaticKeySettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings
{
    /// <summary>The ad marker type for this output group.</summary>
    [JsonPropertyName("adMarkers")]
    public IList<string>? AdMarkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("baseUrlContent")]
    public string? BaseUrlContent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("baseUrlContent1")]
    public string? BaseUrlContent1 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("baseUrlManifest")]
    public string? BaseUrlManifest { get; set; }

    /// <summary></summary>
    [JsonPropertyName("baseUrlManifest1")]
    public string? BaseUrlManifest1 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("captionLanguageMappings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsCaptionLanguageMappings>? CaptionLanguageMappings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("captionLanguageSetting")]
    public string? CaptionLanguageSetting { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientCache")]
    public string? ClientCache { get; set; }

    /// <summary></summary>
    [JsonPropertyName("codecSpecification")]
    public string? CodecSpecification { get; set; }

    /// <summary></summary>
    [JsonPropertyName("constantIv")]
    public string? ConstantIv { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsDestination>? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directoryStructure")]
    public string? DirectoryStructure { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("discontinuityTags")]
    public string? DiscontinuityTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsCdnSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettings>? HlsCdnSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hlsId3SegmentTagging")]
    public string? HlsId3SegmentTagging { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iframeOnlyPlaylists")]
    public string? IframeOnlyPlaylists { get; set; }

    /// <summary></summary>
    [JsonPropertyName("incompleteSegmentBehavior")]
    public string? IncompleteSegmentBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("indexNSegments")]
    public double? IndexNSegments { get; set; }

    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ivInManifest")]
    public string? IvInManifest { get; set; }

    /// <summary>The source for the timecode that will be associated with the events outputs.</summary>
    [JsonPropertyName("ivSource")]
    public string? IvSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keepSegments")]
    public double? KeepSegments { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyFormat")]
    public string? KeyFormat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyFormatVersions")]
    public string? KeyFormatVersions { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("keyProviderSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettings>? KeyProviderSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("manifestCompression")]
    public string? ManifestCompression { get; set; }

    /// <summary></summary>
    [JsonPropertyName("manifestDurationFormat")]
    public string? ManifestDurationFormat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minSegmentLength")]
    public double? MinSegmentLength { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outputSelection")]
    public string? OutputSelection { get; set; }

    /// <summary></summary>
    [JsonPropertyName("programDateTime")]
    public string? ProgramDateTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("programDateTimeClock")]
    public string? ProgramDateTimeClock { get; set; }

    /// <summary></summary>
    [JsonPropertyName("programDateTimePeriod")]
    public double? ProgramDateTimePeriod { get; set; }

    /// <summary></summary>
    [JsonPropertyName("redundantManifest")]
    public string? RedundantManifest { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentLength")]
    public double? SegmentLength { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentsPerSubdirectory")]
    public double? SegmentsPerSubdirectory { get; set; }

    /// <summary>- Maximum CDI input resolution.</summary>
    [JsonPropertyName("streamInfResolution")]
    public string? StreamInfResolution { get; set; }

    /// <summary>Indicates ID3 frame that has the timecode.</summary>
    [JsonPropertyName("timedMetadataId3Frame")]
    public string? TimedMetadataId3Frame { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timedMetadataId3Period")]
    public double? TimedMetadataId3Period { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestampDeltaMilliseconds")]
    public double? TimestampDeltaMilliseconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tsFileMode")]
    public string? TsFileMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings
{
    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsDestination>? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("acquisitionPointId")]
    public string? AcquisitionPointId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioOnlyTimecodeControl")]
    public string? AudioOnlyTimecodeControl { get; set; }

    /// <summary>Setting to allow self signed or verified RTMP certificates.</summary>
    [JsonPropertyName("certificateMode")]
    public string? CertificateMode { get; set; }

    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestination>? Destination { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("eventId")]
    public string? EventId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventIdMode")]
    public string? EventIdMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventStopBehavior")]
    public string? EventStopBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fragmentLength")]
    public double? FragmentLength { get; set; }

    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentationMode")]
    public string? SegmentationMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sendDelayMs")]
    public double? SendDelayMs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparseTrackType")]
    public string? SparseTrackType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("streamManifestBehavior")]
    public string? StreamManifestBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestampOffset")]
    public string? TimestampOffset { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestampOffsetMode")]
    public string? TimestampOffsetMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsMultiplexGroupSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings
{
    /// <summary>The ad marker type for this output group.</summary>
    [JsonPropertyName("adMarkers")]
    public IList<string>? AdMarkers { get; set; }

    /// <summary>Authentication scheme to use when connecting with CDN.</summary>
    [JsonPropertyName("authenticationScheme")]
    public string? AuthenticationScheme { get; set; }

    /// <summary>Controls behavior when content cache fills up.</summary>
    [JsonPropertyName("cacheFullBehavior")]
    public string? CacheFullBehavior { get; set; }

    /// <summary>Cache length in seconds, is used to calculate buffer size.</summary>
    [JsonPropertyName("cacheLength")]
    public double? CacheLength { get; set; }

    /// <summary>Controls the types of data that passes to onCaptionInfo outputs.</summary>
    [JsonPropertyName("captionData")]
    public string? CaptionData { get; set; }

    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsUdpGroupSettings
{
    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    /// <summary>Indicates ID3 frame that has the timecode.</summary>
    [JsonPropertyName("timedMetadataId3Frame")]
    public string? TimedMetadataId3Frame { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timedMetadataId3Period")]
    public double? TimedMetadataId3Period { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettings
{
    /// <summary>Archive group settings. See Archive Group Settings for more details.</summary>
    [JsonPropertyName("archiveGroupSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettings>? ArchiveGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureGroupSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettings>? FrameCaptureGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsGroupSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings>? HlsGroupSettings { get; set; }

    /// <summary>Media package group settings. See Media Package Group Settings for more details.</summary>
    [JsonPropertyName("mediaPackageGroupSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings>? MediaPackageGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("msSmoothGroupSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings>? MsSmoothGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("multiplexGroupSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsMultiplexGroupSettings>? MultiplexGroupSettings { get; set; }

    /// <summary>RTMP group settings. See RTMP Group Settings for more details.</summary>
    [JsonPropertyName("rtmpGroupSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings>? RtmpGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("udpGroupSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsUdpGroupSettings>? UdpGroupSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("networkId")]
    public double? NetworkId { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("networkName")]
    public string? NetworkName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings
{
    /// <summary></summary>
    [JsonPropertyName("outputSdt")]
    public string? OutputSdt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceProviderName")]
    public string? ServiceProviderName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings
{
    /// <summary></summary>
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettings
{
    /// <summary></summary>
    [JsonPropertyName("absentInputAudioBehavior")]
    public string? AbsentInputAudioBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("arib")]
    public string? Arib { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("aribCaptionsPid")]
    public string? AribCaptionsPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("aribCaptionsPidControl")]
    public string? AribCaptionsPidControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioBufferModel")]
    public string? AudioBufferModel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioFramesPerPes")]
    public double? AudioFramesPerPes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioPids")]
    public string? AudioPids { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioStreamType")]
    public string? AudioStreamType { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bufferModel")]
    public string? BufferModel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ccDescriptor")]
    public string? CcDescriptor { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbNitSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings>? DvbNitSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbSdtSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings>? DvbSdtSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dvbSubPids")]
    public string? DvbSubPids { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbTdtSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings>? DvbTdtSettings { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("dvbTeletextPid")]
    public string? DvbTeletextPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebif")]
    public string? Ebif { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebpAudioInterval")]
    public string? EbpAudioInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebpLookaheadMs")]
    public double? EbpLookaheadMs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebpPlacement")]
    public string? EbpPlacement { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("ecmPid")]
    public string? EcmPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("esRateInPes")]
    public string? EsRateInPes { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvPlatformPid")]
    public string? EtvPlatformPid { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvSignalPid")]
    public string? EtvSignalPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fragmentTime")]
    public double? FragmentTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("klv")]
    public string? Klv { get; set; }

    /// <summary></summary>
    [JsonPropertyName("klvDataPids")]
    public string? KlvDataPids { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("nullPacketBitrate")]
    public double? NullPacketBitrate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patInterval")]
    public double? PatInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pcrControl")]
    public string? PcrControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pcrPeriod")]
    public double? PcrPeriod { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pcrPid")]
    public string? PcrPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pmtInterval")]
    public double? PmtInterval { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pmtPid")]
    public string? PmtPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("programNum")]
    public double? ProgramNum { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rateMode")]
    public string? RateMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scte27Pids")]
    public string? Scte27Pids { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scte35Control")]
    public string? Scte35Control { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public string? Scte35Pid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentationMarkers")]
    public string? SegmentationMarkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentationStyle")]
    public string? SegmentationStyle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentationTime")]
    public double? SegmentationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("timedMetadataPid")]
    public string? TimedMetadataPid { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("transportStreamId")]
    public double? TransportStreamId { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("videoPid")]
    public string? VideoPid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsRawSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettings
{
    /// <summary>M2TS Settings. See M2TS Settings for more details.</summary>
    [JsonPropertyName("m2tsSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettings>? M2tsSettings { get; set; }

    /// <summary>Raw Settings. This can be set as an empty block.</summary>
    [JsonPropertyName("rawSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsRawSettings>? RawSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettings
{
    /// <summary>Settings specific to the container type of the file. See Container Settings for more details.</summary>
    [JsonPropertyName("containerSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettings>? ContainerSettings { get; set; }

    /// <summary>Output file extension.</summary>
    [JsonPropertyName("extension")]
    public string? Extension { get; set; }

    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsFrameCaptureOutputSettings
{
    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettingsAudioOnlyImage
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>–  Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettings
{
    /// <summary>Specifies the GROUP-ID in the #EXT-X-MEDIA tag of the target HLS audio rendition.</summary>
    [JsonPropertyName("audioGroupId")]
    public string? AudioGroupId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioOnlyImage")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettingsAudioOnlyImage>? AudioOnlyImage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioTrackType")]
    public string? AudioTrackType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentType")]
    public string? SegmentType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFmp4HlsSettings
{
    /// <summary></summary>
    [JsonPropertyName("audioRenditionSets")]
    public string? AudioRenditionSets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFrameCaptureHlsSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3u8Settings
{
    /// <summary></summary>
    [JsonPropertyName("audioFramesPerPes")]
    public double? AudioFramesPerPes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioPids")]
    public string? AudioPids { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("ecmPid")]
    public string? EcmPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patInterval")]
    public double? PatInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pcrControl")]
    public string? PcrControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pcrPeriod")]
    public double? PcrPeriod { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pcrPid")]
    public string? PcrPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pmtInterval")]
    public double? PmtInterval { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pmtPid")]
    public string? PmtPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("programNum")]
    public double? ProgramNum { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scte35Behavior")]
    public string? Scte35Behavior { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public string? Scte35Pid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("timedMetadataPid")]
    public string? TimedMetadataPid { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("transportStreamId")]
    public double? TransportStreamId { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("videoPid")]
    public string? VideoPid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettings
{
    /// <summary></summary>
    [JsonPropertyName("audioRenditionSets")]
    public string? AudioRenditionSets { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("m3u8Settings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3u8Settings>? M3u8Settings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("audioOnlyHlsSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettings>? AudioOnlyHlsSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("fmp4HlsSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFmp4HlsSettings>? Fmp4HlsSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureHlsSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFrameCaptureHlsSettings>? FrameCaptureHlsSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("standardHlsSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettings>? StandardHlsSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettings
{
    /// <summary></summary>
    [JsonPropertyName("h265PackagingType")]
    public string? H265PackagingType { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettings>? HlsSettings { get; set; }

    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentModifier")]
    public string? SegmentModifier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMediaPackageOutputSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMsSmoothOutputSettings
{
    /// <summary></summary>
    [JsonPropertyName("h265PackagingType")]
    public string? H265PackagingType { get; set; }

    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettings
{
    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettingsDestination>? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettings
{
    /// <summary>Setting to allow self signed or verified RTMP certificates.</summary>
    [JsonPropertyName("certificateMode")]
    public string? CertificateMode { get; set; }

    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsDestination>? Destination { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("networkId")]
    public double? NetworkId { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("networkName")]
    public string? NetworkName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings
{
    /// <summary></summary>
    [JsonPropertyName("outputSdt")]
    public string? OutputSdt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceProviderName")]
    public string? ServiceProviderName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings
{
    /// <summary></summary>
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettings
{
    /// <summary></summary>
    [JsonPropertyName("absentInputAudioBehavior")]
    public string? AbsentInputAudioBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("arib")]
    public string? Arib { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("aribCaptionsPid")]
    public string? AribCaptionsPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("aribCaptionsPidControl")]
    public string? AribCaptionsPidControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioBufferModel")]
    public string? AudioBufferModel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioFramesPerPes")]
    public double? AudioFramesPerPes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioPids")]
    public string? AudioPids { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audioStreamType")]
    public string? AudioStreamType { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bufferModel")]
    public string? BufferModel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ccDescriptor")]
    public string? CcDescriptor { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbNitSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings>? DvbNitSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbSdtSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings>? DvbSdtSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dvbSubPids")]
    public string? DvbSubPids { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbTdtSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings>? DvbTdtSettings { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("dvbTeletextPid")]
    public string? DvbTeletextPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebif")]
    public string? Ebif { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebpAudioInterval")]
    public string? EbpAudioInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebpLookaheadMs")]
    public double? EbpLookaheadMs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebpPlacement")]
    public string? EbpPlacement { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("ecmPid")]
    public string? EcmPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("esRateInPes")]
    public string? EsRateInPes { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvPlatformPid")]
    public string? EtvPlatformPid { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvSignalPid")]
    public string? EtvSignalPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fragmentTime")]
    public double? FragmentTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("klv")]
    public string? Klv { get; set; }

    /// <summary></summary>
    [JsonPropertyName("klvDataPids")]
    public string? KlvDataPids { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("nullPacketBitrate")]
    public double? NullPacketBitrate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patInterval")]
    public double? PatInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pcrControl")]
    public string? PcrControl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pcrPeriod")]
    public double? PcrPeriod { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pcrPid")]
    public string? PcrPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pmtInterval")]
    public double? PmtInterval { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pmtPid")]
    public string? PmtPid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("programNum")]
    public double? ProgramNum { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rateMode")]
    public string? RateMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scte27Pids")]
    public string? Scte27Pids { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scte35Control")]
    public string? Scte35Control { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public string? Scte35Pid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentationMarkers")]
    public string? SegmentationMarkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentationStyle")]
    public string? SegmentationStyle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("segmentationTime")]
    public double? SegmentationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("timedMetadataPid")]
    public string? TimedMetadataPid { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("transportStreamId")]
    public double? TransportStreamId { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("videoPid")]
    public string? VideoPid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettings
{
    /// <summary>M2TS Settings. See M2TS Settings for more details.</summary>
    [JsonPropertyName("m2tsSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettings>? M2tsSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsFecOutputSettings
{
    /// <summary>The height of the FEC protection matrix.</summary>
    [JsonPropertyName("columnDepth")]
    public double? ColumnDepth { get; set; }

    /// <summary>Enables column only or column and row based FEC.</summary>
    [JsonPropertyName("includeFec")]
    public string? IncludeFec { get; set; }

    /// <summary>The width of the FEC protection matrix.</summary>
    [JsonPropertyName("rowLength")]
    public double? RowLength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettings
{
    /// <summary>UDP output buffering in milliseconds.</summary>
    [JsonPropertyName("bufferMsec")]
    public double? BufferMsec { get; set; }

    /// <summary>Settings specific to the container type of the file. See Container Settings for more details.</summary>
    [JsonPropertyName("containerSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettings>? ContainerSettings { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsDestination>? Destination { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("fecOutputSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsFecOutputSettings>? FecOutputSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettings
{
    /// <summary>Archive output settings. See Archive Output Settings for more details.</summary>
    [JsonPropertyName("archiveOutputSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettings>? ArchiveOutputSettings { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("frameCaptureOutputSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsFrameCaptureOutputSettings>? FrameCaptureOutputSettings { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("hlsOutputSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettings>? HlsOutputSettings { get; set; }

    /// <summary>Media package output settings. This can be set as an empty block.</summary>
    [JsonPropertyName("mediaPackageOutputSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMediaPackageOutputSettings>? MediaPackageOutputSettings { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("msSmoothOutputSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMsSmoothOutputSettings>? MsSmoothOutputSettings { get; set; }

    /// <summary>Multiplex output settings. See Multiplex Output Settings for more details.</summary>
    [JsonPropertyName("multiplexOutputSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettings>? MultiplexOutputSettings { get; set; }

    /// <summary>RTMP output settings. See RTMP Output Settings for more details.</summary>
    [JsonPropertyName("rtmpOutputSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettings>? RtmpOutputSettings { get; set; }

    /// <summary>UDP output settings. See UDP Output Settings for more details.</summary>
    [JsonPropertyName("udpOutputSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettings>? UdpOutputSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputs
{
    /// <summary>The names of the audio descriptions used as audio sources for the output.</summary>
    [JsonPropertyName("audioDescriptionNames")]
    public IList<string>? AudioDescriptionNames { get; set; }

    /// <summary>The names of the caption descriptions used as caption sources for the output.</summary>
    [JsonPropertyName("captionDescriptionNames")]
    public IList<string>? CaptionDescriptionNames { get; set; }

    /// <summary>The name used to identify an output.</summary>
    [JsonPropertyName("outputName")]
    public string? OutputName { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("outputSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettings>? OutputSettings { get; set; }

    /// <summary>The name of the video description used as video source for the output.</summary>
    [JsonPropertyName("videoDescriptionName")]
    public string? VideoDescriptionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroups
{
    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Settings associated with the output group. See Output Group Settings for more details.</summary>
    [JsonPropertyName("outputGroupSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettings>? OutputGroupSettings { get; set; }

    /// <summary>List of outputs. See Outputs for more details.</summary>
    [JsonPropertyName("outputs")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputs>? Outputs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsTimecodeConfig
{
    /// <summary>The source for the timecode that will be associated with the events outputs.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Threshold in frames beyond which output timecode is resynchronized to the input timecode.</summary>
    [JsonPropertyName("syncThreshold")]
    public double? SyncThreshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings
{
    /// <summary>The frequency at which to capture frames for inclusion in the output.</summary>
    [JsonPropertyName("captureInterval")]
    public double? CaptureInterval { get; set; }

    /// <summary>Unit for the frame capture interval.</summary>
    [JsonPropertyName("captureIntervalUnits")]
    public string? CaptureIntervalUnits { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettingsTemporalFilterSettings
{
    /// <summary>Post filter sharpening.</summary>
    [JsonPropertyName("postFilterSharpening")]
    public string? PostFilterSharpening { get; set; }

    /// <summary>Filter strength.</summary>
    [JsonPropertyName("strength")]
    public string? Strength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettings
{
    /// <summary>Temporal filter settings. See Temporal Filter Settings</summary>
    [JsonPropertyName("temporalFilterSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettingsTemporalFilterSettings>? TemporalFilterSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH264Settings
{
    /// <summary>Enables or disables adaptive quantization.</summary>
    [JsonPropertyName("adaptiveQuantization")]
    public string? AdaptiveQuantization { get; set; }

    /// <summary>Indicates that AFD values will be written into the output stream.</summary>
    [JsonPropertyName("afdSignaling")]
    public string? AfdSignaling { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bufFillPct")]
    public double? BufFillPct { get; set; }

    /// <summary>Size of buffer in bits.</summary>
    [JsonPropertyName("bufSize")]
    public double? BufSize { get; set; }

    /// <summary>Includes color space metadata in the output.</summary>
    [JsonPropertyName("colorMetadata")]
    public string? ColorMetadata { get; set; }

    /// <summary>Entropy encoding mode.</summary>
    [JsonPropertyName("entropyEncoding")]
    public string? EntropyEncoding { get; set; }

    /// <summary>Filters to apply to an encode. See H264 Filter Settings for more details.</summary>
    [JsonPropertyName("filterSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettings>? FilterSettings { get; set; }

    /// <summary>Four bit AFD value to write on all frames of video in the output stream.</summary>
    [JsonPropertyName("fixedAfd")]
    public string? FixedAfd { get; set; }

    /// <summary></summary>
    [JsonPropertyName("flickerAq")]
    public string? FlickerAq { get; set; }

    /// <summary>Controls whether coding is performed on a field basis or on a frame basis.</summary>
    [JsonPropertyName("forceFieldPictures")]
    public string? ForceFieldPictures { get; set; }

    /// <summary>Indicates how the output video frame rate is specified.</summary>
    [JsonPropertyName("framerateControl")]
    public string? FramerateControl { get; set; }

    /// <summary>Framerate denominator.</summary>
    [JsonPropertyName("framerateDenominator")]
    public double? FramerateDenominator { get; set; }

    /// <summary>Framerate numerator.</summary>
    [JsonPropertyName("framerateNumerator")]
    public double? FramerateNumerator { get; set; }

    /// <summary>GOP-B reference.</summary>
    [JsonPropertyName("gopBReference")]
    public string? GopBReference { get; set; }

    /// <summary>Frequency of closed GOPs.</summary>
    [JsonPropertyName("gopClosedCadence")]
    public double? GopClosedCadence { get; set; }

    /// <summary>Number of B-frames between reference frames.</summary>
    [JsonPropertyName("gopNumBFrames")]
    public double? GopNumBFrames { get; set; }

    /// <summary>GOP size in units of either frames of seconds per gop_size_units.</summary>
    [JsonPropertyName("gopSize")]
    public double? GopSize { get; set; }

    /// <summary>Indicates if the gop_size is specified in frames or seconds.</summary>
    [JsonPropertyName("gopSizeUnits")]
    public string? GopSizeUnits { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Amount of lookahead.</summary>
    [JsonPropertyName("lookAheadRateControl")]
    public string? LookAheadRateControl { get; set; }

    /// <summary>Set the maximum bitrate in order to accommodate expected spikes in the complexity of the video.</summary>
    [JsonPropertyName("maxBitrate")]
    public double? MaxBitrate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minIInterval")]
    public double? MinIInterval { get; set; }

    /// <summary>Number of reference frames to use.</summary>
    [JsonPropertyName("numRefFrames")]
    public double? NumRefFrames { get; set; }

    /// <summary>Indicates how the output pixel aspect ratio is specified.</summary>
    [JsonPropertyName("parControl")]
    public string? ParControl { get; set; }

    /// <summary>Pixel Aspect Ratio denominator.</summary>
    [JsonPropertyName("parDenominator")]
    public double? ParDenominator { get; set; }

    /// <summary>Pixel Aspect Ratio numerator.</summary>
    [JsonPropertyName("parNumerator")]
    public double? ParNumerator { get; set; }

    /// <summary>AAC profile.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>Quality level.</summary>
    [JsonPropertyName("qualityLevel")]
    public string? QualityLevel { get; set; }

    /// <summary>Controls the target quality for the video encode.</summary>
    [JsonPropertyName("qvbrQualityLevel")]
    public double? QvbrQualityLevel { get; set; }

    /// <summary>The rate control mode.</summary>
    [JsonPropertyName("rateControlMode")]
    public string? RateControlMode { get; set; }

    /// <summary>Sets the scan type of the output.</summary>
    [JsonPropertyName("scanType")]
    public string? ScanType { get; set; }

    /// <summary>Scene change detection.</summary>
    [JsonPropertyName("sceneChangeDetect")]
    public string? SceneChangeDetect { get; set; }

    /// <summary>Number of slices per picture.</summary>
    [JsonPropertyName("slices")]
    public double? Slices { get; set; }

    /// <summary>Softness.</summary>
    [JsonPropertyName("softness")]
    public double? Softness { get; set; }

    /// <summary>Makes adjustments within each frame based on spatial variation of content complexity.</summary>
    [JsonPropertyName("spatialAq")]
    public string? SpatialAq { get; set; }

    /// <summary>Subgop length.</summary>
    [JsonPropertyName("subgopLength")]
    public string? SubgopLength { get; set; }

    /// <summary>Produces a bitstream compliant with SMPTE RP-2027.</summary>
    [JsonPropertyName("syntax")]
    public string? Syntax { get; set; }

    /// <summary>Makes adjustments within each frame based on temporal variation of content complexity.</summary>
    [JsonPropertyName("temporalAq")]
    public string? TemporalAq { get; set; }

    /// <summary>Determines how timecodes should be inserted into the video elementary stream.</summary>
    [JsonPropertyName("timecodeInsertion")]
    public string? TimecodeInsertion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsColorSpacePassthroughSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsDolbyVision81Settings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsHdr10Settings
{
    /// <summary>Sets the MaxCLL value for HDR10.</summary>
    [JsonPropertyName("maxCll")]
    public double? MaxCll { get; set; }

    /// <summary>Sets the MaxFALL value for HDR10.</summary>
    [JsonPropertyName("maxFall")]
    public double? MaxFall { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec601Settings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec709Settings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettings
{
    /// <summary>Sets the colorspace metadata to be passed through.</summary>
    [JsonPropertyName("colorSpacePassthroughSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsColorSpacePassthroughSettings>? ColorSpacePassthroughSettings { get; set; }

    /// <summary>Set the colorspace to Dolby Vision81.</summary>
    [JsonPropertyName("dolbyVision81Settings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsDolbyVision81Settings>? DolbyVision81Settings { get; set; }

    /// <summary>Set the colorspace to be HDR10. See H265 HDR10 Settings for more details.</summary>
    [JsonPropertyName("hdr10Settings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsHdr10Settings>? Hdr10Settings { get; set; }

    /// <summary>Set the colorspace to Rec. 601.</summary>
    [JsonPropertyName("rec601Settings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec601Settings>? Rec601Settings { get; set; }

    /// <summary>Set the colorspace to Rec. 709.</summary>
    [JsonPropertyName("rec709Settings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec709Settings>? Rec709Settings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettingsTemporalFilterSettings
{
    /// <summary>Post filter sharpening.</summary>
    [JsonPropertyName("postFilterSharpening")]
    public string? PostFilterSharpening { get; set; }

    /// <summary>Filter strength.</summary>
    [JsonPropertyName("strength")]
    public string? Strength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettings
{
    /// <summary>Temporal filter settings. See Temporal Filter Settings</summary>
    [JsonPropertyName("temporalFilterSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettingsTemporalFilterSettings>? TemporalFilterSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsTimecodeBurninSettings
{
    /// <summary>Set a prefix on the burned in timecode.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Sets the size of the burned in timecode.</summary>
    [JsonPropertyName("timecodeBurninFontSize")]
    public string? TimecodeBurninFontSize { get; set; }

    /// <summary>Sets the position of the burned in timecode.</summary>
    [JsonPropertyName("timecodeBurninPosition")]
    public string? TimecodeBurninPosition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265Settings
{
    /// <summary>Enables or disables adaptive quantization.</summary>
    [JsonPropertyName("adaptiveQuantization")]
    public string? AdaptiveQuantization { get; set; }

    /// <summary>Indicates that AFD values will be written into the output stream.</summary>
    [JsonPropertyName("afdSignaling")]
    public string? AfdSignaling { get; set; }

    /// <summary>Whether or not EML should insert an Alternative Transfer Function SEI message.</summary>
    [JsonPropertyName("alternativeTransferFunction")]
    public string? AlternativeTransferFunction { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Size of buffer in bits.</summary>
    [JsonPropertyName("bufSize")]
    public double? BufSize { get; set; }

    /// <summary>Includes color space metadata in the output.</summary>
    [JsonPropertyName("colorMetadata")]
    public string? ColorMetadata { get; set; }

    /// <summary>Define the color metadata for the output. H265 Color Space Settings for more details.</summary>
    [JsonPropertyName("colorSpaceSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettings>? ColorSpaceSettings { get; set; }

    /// <summary>Filters to apply to an encode. See H264 Filter Settings for more details.</summary>
    [JsonPropertyName("filterSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettings>? FilterSettings { get; set; }

    /// <summary>Four bit AFD value to write on all frames of video in the output stream.</summary>
    [JsonPropertyName("fixedAfd")]
    public string? FixedAfd { get; set; }

    /// <summary></summary>
    [JsonPropertyName("flickerAq")]
    public string? FlickerAq { get; set; }

    /// <summary>Framerate denominator.</summary>
    [JsonPropertyName("framerateDenominator")]
    public double? FramerateDenominator { get; set; }

    /// <summary>Framerate numerator.</summary>
    [JsonPropertyName("framerateNumerator")]
    public double? FramerateNumerator { get; set; }

    /// <summary>Frequency of closed GOPs.</summary>
    [JsonPropertyName("gopClosedCadence")]
    public double? GopClosedCadence { get; set; }

    /// <summary>GOP size in units of either frames of seconds per gop_size_units.</summary>
    [JsonPropertyName("gopSize")]
    public double? GopSize { get; set; }

    /// <summary>Indicates if the gop_size is specified in frames or seconds.</summary>
    [JsonPropertyName("gopSizeUnits")]
    public string? GopSizeUnits { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Amount of lookahead.</summary>
    [JsonPropertyName("lookAheadRateControl")]
    public string? LookAheadRateControl { get; set; }

    /// <summary>Set the maximum bitrate in order to accommodate expected spikes in the complexity of the video.</summary>
    [JsonPropertyName("maxBitrate")]
    public double? MaxBitrate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minIInterval")]
    public double? MinIInterval { get; set; }

    /// <summary>Pixel Aspect Ratio denominator.</summary>
    [JsonPropertyName("parDenominator")]
    public double? ParDenominator { get; set; }

    /// <summary>Pixel Aspect Ratio numerator.</summary>
    [JsonPropertyName("parNumerator")]
    public double? ParNumerator { get; set; }

    /// <summary>AAC profile.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>Controls the target quality for the video encode.</summary>
    [JsonPropertyName("qvbrQualityLevel")]
    public double? QvbrQualityLevel { get; set; }

    /// <summary>The rate control mode.</summary>
    [JsonPropertyName("rateControlMode")]
    public string? RateControlMode { get; set; }

    /// <summary>Sets the scan type of the output.</summary>
    [JsonPropertyName("scanType")]
    public string? ScanType { get; set; }

    /// <summary>Scene change detection.</summary>
    [JsonPropertyName("sceneChangeDetect")]
    public string? SceneChangeDetect { get; set; }

    /// <summary>Number of slices per picture.</summary>
    [JsonPropertyName("slices")]
    public double? Slices { get; set; }

    /// <summary>Set the H265 tier in the output.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>Apply a burned in timecode. See H265 Timecode Burnin Settings for more details.</summary>
    [JsonPropertyName("timecodeBurninSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsTimecodeBurninSettings>? TimecodeBurninSettings { get; set; }

    /// <summary>Determines how timecodes should be inserted into the video elementary stream.</summary>
    [JsonPropertyName("timecodeInsertion")]
    public string? TimecodeInsertion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettings
{
    /// <summary>Frame capture settings. See Frame Capture Settings for more details.</summary>
    [JsonPropertyName("frameCaptureSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings>? FrameCaptureSettings { get; set; }

    /// <summary>H264 settings. See H264 Settings for more details.</summary>
    [JsonPropertyName("h264Settings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH264Settings>? H264Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("h265Settings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265Settings>? H265Settings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptions
{
    /// <summary>Audio codec settings. See Audio Codec Settings for more details.</summary>
    [JsonPropertyName("codecSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettings>? CodecSettings { get; set; }

    /// <summary>See the description in left_offset. For height, specify the entire height of the rectangle as a percentage of the underlying frame height. For example, "80" means the rectangle height is 80% of the underlying frame height. The top_offset and rectangle_height must add up to 100% or less. This field corresponds to tts:extent - Y in the TTML standard.</summary>
    [JsonPropertyName("height")]
    public double? Height { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Indicate how to respond to the AFD values that might be in the input video.</summary>
    [JsonPropertyName("respondToAfd")]
    public string? RespondToAfd { get; set; }

    /// <summary>Behavior on how to scale.</summary>
    [JsonPropertyName("scalingBehavior")]
    public string? ScalingBehavior { get; set; }

    /// <summary>Changes the strength of the anti-alias filter used for scaling.</summary>
    [JsonPropertyName("sharpness")]
    public double? Sharpness { get; set; }

    /// <summary>See the description in left_offset. For width, specify the entire width of the rectangle as a percentage of the underlying frame width. For example, "80" means the rectangle width is 80% of the underlying frame width. The left_offset and rectangle_width must add up to 100% or less. This field corresponds to tts:extent - X in the TTML standard.</summary>
    [JsonPropertyName("width")]
    public double? Width { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderEncoderSettings
{
    /// <summary>Audio descriptions for the channel. See Audio Descriptions for more details.</summary>
    [JsonPropertyName("audioDescriptions")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsAudioDescriptions>? AudioDescriptions { get; set; }

    /// <summary>Settings for ad avail blanking. See Avail Blanking for more details.</summary>
    [JsonPropertyName("availBlanking")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsAvailBlanking>? AvailBlanking { get; set; }

    /// <summary>Caption Descriptions. See Caption Descriptions for more details.</summary>
    [JsonPropertyName("captionDescriptions")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsCaptionDescriptions>? CaptionDescriptions { get; set; }

    /// <summary>Configuration settings that apply to the event as a whole. See Global Configuration for more details.</summary>
    [JsonPropertyName("globalConfiguration")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsGlobalConfiguration>? GlobalConfiguration { get; set; }

    /// <summary>Settings for motion graphics. See Motion Graphics Configuration for more details.</summary>
    [JsonPropertyName("motionGraphicsConfiguration")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsMotionGraphicsConfiguration>? MotionGraphicsConfiguration { get; set; }

    /// <summary>Nielsen configuration settings. See Nielsen Configuration for more details.</summary>
    [JsonPropertyName("nielsenConfiguration")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsNielsenConfiguration>? NielsenConfiguration { get; set; }

    /// <summary>Output groups for the channel. See Output Groups for more details.</summary>
    [JsonPropertyName("outputGroups")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsOutputGroups>? OutputGroups { get; set; }

    /// <summary>Contains settings used to acquire and adjust timecode information from inputs. See Timecode Config for more details.</summary>
    [JsonPropertyName("timecodeConfig")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsTimecodeConfig>? TimecodeConfig { get; set; }

    /// <summary>Video Descriptions. See Video Descriptions for more details.</summary>
    [JsonPropertyName("videoDescriptions")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettingsVideoDescriptions>? VideoDescriptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings
{
    /// <summary>The name of the audio selector in the input that MediaLive should monitor to detect silence. Select your most important rendition. If you didn't create an audio selector in this input, leave blank.</summary>
    [JsonPropertyName("audioSelectorName")]
    public string? AudioSelectorName { get; set; }

    /// <summary>The amount of time (in milliseconds) that the active input must be silent before automatic input failover occurs. Silence is defined as audio loss or audio quieter than -50 dBFS.</summary>
    [JsonPropertyName("audioSilenceThresholdMsec")]
    public double? AudioSilenceThresholdMsec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsInputLossSettings
{
    /// <summary>The amount of time (in milliseconds) that no input is detected. After that time, an input failover will occur.</summary>
    [JsonPropertyName("inputLossThresholdMsec")]
    public double? InputLossThresholdMsec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsVideoBlackSettings
{
    /// <summary>A value used in calculating the threshold below which MediaLive considers a pixel to be 'black'. For the input to be considered black, every pixel in a frame must be below this threshold. The threshold is calculated as a percentage (expressed as a decimal) of white. Therefore .1 means 10% white (or 90% black). Note how the formula works for any color depth. For example, if you set this field to 0.1 in 10-bit color depth: (10230.1=102.3), which means a pixel value of 102 or less is 'black'. If you set this field to .1 in an 8-bit color depth: (2550.1=25.5), which means a pixel value of 25 or less is 'black'. The range is 0.0 to 1.0, with any number of decimal places.</summary>
    [JsonPropertyName("blackDetectThreshold")]
    public double? BlackDetectThreshold { get; set; }

    /// <summary>The amount of time (in milliseconds) that the active input must be black before automatic input failover occurs.</summary>
    [JsonPropertyName("videoBlackThresholdMsec")]
    public double? VideoBlackThresholdMsec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettings
{
    /// <summary>MediaLive will perform a failover if the specified audio selector is silent for the specified period. See Audio Silence Failover Settings for more details.</summary>
    [JsonPropertyName("audioSilenceSettings")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings>? AudioSilenceSettings { get; set; }

    /// <summary>MediaLive will perform a failover if content is not detected in this input for the specified period. See Input Loss Failover Settings for more details.</summary>
    [JsonPropertyName("inputLossSettings")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsInputLossSettings>? InputLossSettings { get; set; }

    /// <summary>MediaLive will perform a failover if content is considered black for the specified period. See Video Black Failover Settings for more details.</summary>
    [JsonPropertyName("videoBlackSettings")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsVideoBlackSettings>? VideoBlackSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverCondition
{
    /// <summary>Failover condition type-specific settings. See Failover Condition Settings for more details.</summary>
    [JsonPropertyName("failoverConditionSettings")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettings>? FailoverConditionSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettings
{
    /// <summary>This clear time defines the requirement a recovered input must meet to be considered healthy. The input must have no failover conditions for this length of time. Enter a time in milliseconds. This value is particularly important if the input_preference for the failover pair is set to PRIMARY_INPUT_PREFERRED, because after this time, MediaLive will switch back to the primary input.</summary>
    [JsonPropertyName("errorClearTimeMsec")]
    public double? ErrorClearTimeMsec { get; set; }

    /// <summary>A list of failover conditions. If any of these conditions occur, MediaLive will perform a failover to the other input. See Failover Condition Block for more details.</summary>
    [JsonPropertyName("failoverCondition")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverCondition>? FailoverCondition { get; set; }

    /// <summary>Input preference when deciding which input to make active when a previously failed input has recovered.</summary>
    [JsonPropertyName("inputPreference")]
    public string? InputPreference { get; set; }

    /// <summary>The input ID of the secondary input in the automatic input failover pair.</summary>
    [JsonPropertyName("secondaryInputId")]
    public string? SecondaryInputId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioHlsRenditionSelection
{
    /// <summary>Specifies the GROUP-ID in the #EXT-X-MEDIA tag of the target HLS audio rendition.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection
{
    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>When set to “strict”, the transport stream demux strictly identifies audio streams by their language descriptor. If a PMT update occurs such that an audio stream matching the initially selected language is no longer present then mute will be encoded until the language returns. If “loose”, then on a PMT update the demux will choose another audio stream in the program with the same stream type if it can’t find one with the same language.</summary>
    [JsonPropertyName("languageSelectionPolicy")]
    public string? LanguageSelectionPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioPidSelection
{
    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pid")]
    public double? Pid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionDolbyEDecode
{
    /// <summary>Applies only to Dolby E. Enter the program ID (according to the metadata in the audio) of the Dolby E program to extract from the specified track. One program extracted per audio selector. To select multiple programs, create multiple selectors with the same Track and different Program numbers. “All channels” means to ignore the program IDs and include all the channels in this selector; useful if metadata is known to be incorrect.</summary>
    [JsonPropertyName("programSelection")]
    public string? ProgramSelection { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionTracks
{
    /// <summary>1-based integer value that maps to a specific audio track.</summary>
    [JsonPropertyName("track")]
    public double? Track { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelection
{
    /// <summary>Configure decoding options for Dolby E streams - these should be Dolby E frames carried in PCM streams tagged with SMPTE-337. See Dolby E Decode for more details.</summary>
    [JsonPropertyName("dolbyEDecode")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionDolbyEDecode>? DolbyEDecode { get; set; }

    /// <summary>Selects one or more unique audio tracks from within a source. See Audio Tracks for more details.</summary>
    [JsonPropertyName("tracks")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionTracks>? Tracks { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettings
{
    /// <summary>Audio HLS Rendition Selection. See Audio HLS Rendition Selection for more details.</summary>
    [JsonPropertyName("audioHlsRenditionSelection")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioHlsRenditionSelection>? AudioHlsRenditionSelection { get; set; }

    /// <summary>Audio Language Selection. See Audio Language Selection for more details.</summary>
    [JsonPropertyName("audioLanguageSelection")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection>? AudioLanguageSelection { get; set; }

    /// <summary>Audio Pid Selection. See Audio PID Selection for more details.</summary>
    [JsonPropertyName("audioPidSelection")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioPidSelection>? AudioPidSelection { get; set; }

    /// <summary>Audio Track Selection. See Audio Track Selection for more details.</summary>
    [JsonPropertyName("audioTrackSelection")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelection>? AudioTrackSelection { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelector
{
    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The audio selector settings. See Audio Selector Settings for more details.</summary>
    [JsonPropertyName("selectorSettings")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettings>? SelectorSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAncillarySourceSettings
{
    /// <summary>Specifies the number (1 to 4) of the captions channel you want to extract from the ancillary captions. If you plan to convert the ancillary captions to another format, complete this field. If you plan to choose Embedded as the captions destination in the output (to pass through all the channels in the ancillary captions), leave this field blank because MediaLive ignores the field.</summary>
    [JsonPropertyName("sourceAncillaryChannelNumber")]
    public double? SourceAncillaryChannelNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAribSourceSettings
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsDvbSubSourceSettings
{
    /// <summary>If you will configure a WebVTT caption description that references this caption selector, use this field to provide the language to consider when translating the image-based source to text.</summary>
    [JsonPropertyName("ocrLanguage")]
    public string? OcrLanguage { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pid")]
    public double? Pid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsEmbeddedSourceSettings
{
    /// <summary>If upconvert, 608 data is both passed through via the “608 compatibility bytes” fields of the 708 wrapper as well as translated into 708. 708 data present in the source content will be discarded.</summary>
    [JsonPropertyName("convert608To708")]
    public string? Convert608To708 { get; set; }

    /// <summary>Set to “auto” to handle streams with intermittent and/or non-aligned SCTE-20 and Embedded captions.</summary>
    [JsonPropertyName("scte20Detection")]
    public string? Scte20Detection { get; set; }

    /// <summary>Specifies the 608/708 channel number within the video track from which to extract captions. Unused for passthrough.</summary>
    [JsonPropertyName("source608ChannelNumber")]
    public double? Source608ChannelNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte20SourceSettings
{
    /// <summary>If upconvert, 608 data is both passed through via the “608 compatibility bytes” fields of the 708 wrapper as well as translated into 708. 708 data present in the source content will be discarded.</summary>
    [JsonPropertyName("convert608To708")]
    public string? Convert608To708 { get; set; }

    /// <summary>Specifies the 608/708 channel number within the video track from which to extract captions. Unused for passthrough.</summary>
    [JsonPropertyName("source608ChannelNumber")]
    public double? Source608ChannelNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte27SourceSettings
{
    /// <summary>If you will configure a WebVTT caption description that references this caption selector, use this field to provide the language to consider when translating the image-based source to text.</summary>
    [JsonPropertyName("ocrLanguage")]
    public string? OcrLanguage { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pid")]
    public double? Pid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle
{
    /// <summary>See the description in left_offset. For height, specify the entire height of the rectangle as a percentage of the underlying frame height. For example, "80" means the rectangle height is 80% of the underlying frame height. The top_offset and rectangle_height must add up to 100% or less. This field corresponds to tts:extent - Y in the TTML standard.</summary>
    [JsonPropertyName("height")]
    public double? Height { get; set; }

    /// <summary>Applies only if you plan to convert these source captions to EBU-TT-D or TTML in an output. (Make sure to leave the default if you don’t have either of these formats in the output.) You can define a display rectangle for the captions that is smaller than the underlying video frame. You define the rectangle by specifying the position of the left edge, top edge, bottom edge, and right edge of the rectangle, all within the underlying video frame. The units for the measurements are percentages. If you specify a value for one of these fields, you must specify a value for all of them. For leftOffset, specify the position of the left edge of the rectangle, as a percentage of the underlying frame width, and relative to the left edge of the frame. For example, "10" means the measurement is 10% of the underlying frame width. The rectangle left edge starts at that position from the left edge of the frame. This field corresponds to tts:origin - X in the TTML standard.</summary>
    [JsonPropertyName("leftOffset")]
    public double? LeftOffset { get; set; }

    /// <summary>See the description in left_offset. For top_offset, specify the position of the top edge of the rectangle, as a percentage of the underlying frame height, and relative to the top edge of the frame. For example, "10" means the measurement is 10% of the underlying frame height. The rectangle top edge starts at that position from the top edge of the frame. This field corresponds to tts:origin - Y in the TTML standard.</summary>
    [JsonPropertyName("topOffset")]
    public double? TopOffset { get; set; }

    /// <summary>See the description in left_offset. For width, specify the entire width of the rectangle as a percentage of the underlying frame width. For example, "80" means the rectangle width is 80% of the underlying frame width. The left_offset and rectangle_width must add up to 100% or less. This field corresponds to tts:extent - X in the TTML standard.</summary>
    [JsonPropertyName("width")]
    public double? Width { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettings
{
    /// <summary>Optionally defines a region where TTML style captions will be displayed. See Caption Rectangle for more details.</summary>
    [JsonPropertyName("outputRectangle")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle>? OutputRectangle { get; set; }

    /// <summary>Specifies the teletext page number within the data stream from which to extract captions. Range of 0x100 (256) to 0x8FF (2303). Unused for passthrough. Should be specified as a hexadecimal string with no “0x” prefix.</summary>
    [JsonPropertyName("pageNumber")]
    public string? PageNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettings
{
    /// <summary>Ancillary Source Settings. See Ancillary Source Settings for more details.</summary>
    [JsonPropertyName("ancillarySourceSettings")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAncillarySourceSettings>? AncillarySourceSettings { get; set; }

    /// <summary>ARIB Source Settings.</summary>
    [JsonPropertyName("aribSourceSettings")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAribSourceSettings>? AribSourceSettings { get; set; }

    /// <summary>DVB Sub Source Settings. See DVB Sub Source Settings for more details.</summary>
    [JsonPropertyName("dvbSubSourceSettings")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsDvbSubSourceSettings>? DvbSubSourceSettings { get; set; }

    /// <summary>Embedded Source Settings. See Embedded Source Settings for more details.</summary>
    [JsonPropertyName("embeddedSourceSettings")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsEmbeddedSourceSettings>? EmbeddedSourceSettings { get; set; }

    /// <summary>SCTE20 Source Settings. See SCTE 20 Source Settings for more details.</summary>
    [JsonPropertyName("scte20SourceSettings")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte20SourceSettings>? Scte20SourceSettings { get; set; }

    /// <summary>SCTE27 Source Settings. See SCTE 27 Source Settings for more details.</summary>
    [JsonPropertyName("scte27SourceSettings")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte27SourceSettings>? Scte27SourceSettings { get; set; }

    /// <summary>Teletext Source Settings. See Teletext Source Settings for more details.</summary>
    [JsonPropertyName("teletextSourceSettings")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettings>? TeletextSourceSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelector
{
    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The audio selector settings. See Audio Selector Settings for more details.</summary>
    [JsonPropertyName("selectorSettings")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettings>? SelectorSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsNetworkInputSettingsHlsInputSettings
{
    /// <summary>The bitrate is specified in bits per second, as in an HLS manifest.</summary>
    [JsonPropertyName("bandwidth")]
    public double? Bandwidth { get; set; }

    /// <summary>Buffer segments.</summary>
    [JsonPropertyName("bufferSegments")]
    public double? BufferSegments { get; set; }

    /// <summary>The number of consecutive times that attempts to read a manifest or segment must fail before the input is considered unavailable.</summary>
    [JsonPropertyName("retries")]
    public double? Retries { get; set; }

    /// <summary>The number of seconds between retries when an attempt to read a manifest or segment fails.</summary>
    [JsonPropertyName("retryInterval")]
    public double? RetryInterval { get; set; }

    /// <summary>The source for the timecode that will be associated with the events outputs.</summary>
    [JsonPropertyName("scte35Source")]
    public string? Scte35Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsNetworkInputSettings
{
    /// <summary>Specifies HLS input settings when the uri is for a HLS manifest. See HLS Input Settings for more details.</summary>
    [JsonPropertyName("hlsInputSettings")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsNetworkInputSettingsHlsInputSettings>? HlsInputSettings { get; set; }

    /// <summary>Check HTTPS server certificates.</summary>
    [JsonPropertyName("serverValidation")]
    public string? ServerValidation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsVideoSelector
{
    /// <summary></summary>
    [JsonPropertyName("colorSpace")]
    public string? ColorSpace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("colorSpaceUsage")]
    public string? ColorSpaceUsage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachmentsInputSettings
{
    /// <summary></summary>
    [JsonPropertyName("audioSelector")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelector>? AudioSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("captionSelector")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelector>? CaptionSelector { get; set; }

    /// <summary>Enable or disable the deblock filter when filtering.</summary>
    [JsonPropertyName("deblockFilter")]
    public string? DeblockFilter { get; set; }

    /// <summary>Enable or disable the denoise filter when filtering.</summary>
    [JsonPropertyName("denoiseFilter")]
    public string? DenoiseFilter { get; set; }

    /// <summary>Adjusts the magnitude of filtering from 1 (minimal) to 5 (strongest).</summary>
    [JsonPropertyName("filterStrength")]
    public double? FilterStrength { get; set; }

    /// <summary>Turns on the filter for the input.</summary>
    [JsonPropertyName("inputFilter")]
    public string? InputFilter { get; set; }

    /// <summary>Input settings. See Network Input Settings for more details.</summary>
    [JsonPropertyName("networkInputSettings")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsNetworkInputSettings>? NetworkInputSettings { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public double? Scte35Pid { get; set; }

    /// <summary>Specifies whether to extract applicable ancillary data from a SMPTE-2038 source in the input.</summary>
    [JsonPropertyName("smpte2038DataPreference")]
    public string? Smpte2038DataPreference { get; set; }

    /// <summary>Loop input if it is a file.</summary>
    [JsonPropertyName("sourceEndBehavior")]
    public string? SourceEndBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("videoSelector")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettingsVideoSelector>? VideoSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputAttachments
{
    /// <summary>User-specified settings for defining what the conditions are for declaring the input unhealthy and failing over to a different input. See Automatic Input Failover Settings for more details.</summary>
    [JsonPropertyName("automaticInputFailoverSettings")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettings>? AutomaticInputFailoverSettings { get; set; }

    /// <summary>User-specified name for the attachment.</summary>
    [JsonPropertyName("inputAttachmentName")]
    public string? InputAttachmentName { get; set; }

    /// <summary>The ID of the input.</summary>
    [JsonPropertyName("inputId")]
    public string? InputId { get; set; }

    /// <summary>Settings of an input. See Input Settings for more details.</summary>
    [JsonPropertyName("inputSettings")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachmentsInputSettings>? InputSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderInputSpecification
{
    /// <summary></summary>
    [JsonPropertyName("codec")]
    public string? Codec { get; set; }

    /// <summary>- Maximum CDI input resolution.</summary>
    [JsonPropertyName("inputResolution")]
    public string? InputResolution { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("maximumBitrate")]
    public string? MaximumBitrate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderMaintenance
{
    /// <summary>The day of the week to use for maintenance.</summary>
    [JsonPropertyName("maintenanceDay")]
    public string? MaintenanceDay { get; set; }

    /// <summary>The hour maintenance will start.</summary>
    [JsonPropertyName("maintenanceStartTime")]
    public string? MaintenanceStartTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProviderVpc
{
    /// <summary></summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkInterfaceIds")]
    public IList<string>? NetworkInterfaceIds { get; set; }

    /// <summary>List of public address allocation ids to associate with ENIs that will be created in Output VPC. Must specify one for SINGLE_PIPELINE, two for STANDARD channels.</summary>
    [JsonPropertyName("publicAddressAllocationIds")]
    public IList<string>? PublicAddressAllocationIds { get; set; }

    /// <summary>A list of up to 5 EC2 VPC security group IDs to attach to the Output VPC network interfaces. If none are specified then the VPC default security group will be used.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>A list of VPC subnet IDs from the same VPC. If STANDARD channel, subnet IDs must be mapped to two unique availability zones (AZ).</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusAtProvider
{
    /// <summary>ARN of the Channel.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Specification of CDI inputs for this channel. See CDI Input Specification for more details.</summary>
    [JsonPropertyName("cdiInputSpecification")]
    public IList<V1beta1ChannelStatusAtProviderCdiInputSpecification>? CdiInputSpecification { get; set; }

    /// <summary>Concise argument description.</summary>
    [JsonPropertyName("channelClass")]
    public string? ChannelClass { get; set; }

    /// <summary>ID of the channel in MediaPackage that is the destination for this output group.</summary>
    [JsonPropertyName("channelId")]
    public string? ChannelId { get; set; }

    /// <summary>Destinations for channel. See Destinations for more details.</summary>
    [JsonPropertyName("destinations")]
    public IList<V1beta1ChannelStatusAtProviderDestinations>? Destinations { get; set; }

    /// <summary>Encoder settings. See Encoder Settings for more details.</summary>
    [JsonPropertyName("encoderSettings")]
    public IList<V1beta1ChannelStatusAtProviderEncoderSettings>? EncoderSettings { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Input attachments for the channel. See Input Attachments for more details.</summary>
    [JsonPropertyName("inputAttachments")]
    public IList<V1beta1ChannelStatusAtProviderInputAttachments>? InputAttachments { get; set; }

    /// <summary>Specification of network and file inputs for the channel.</summary>
    [JsonPropertyName("inputSpecification")]
    public IList<V1beta1ChannelStatusAtProviderInputSpecification>? InputSpecification { get; set; }

    /// <summary>The log level to write to Cloudwatch logs.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>Maintenance settings for this channel. See Maintenance for more details.</summary>
    [JsonPropertyName("maintenance")]
    public IList<V1beta1ChannelStatusAtProviderMaintenance>? Maintenance { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Concise argument description.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Whether to start/stop channel. Default: false</summary>
    [JsonPropertyName("startChannel")]
    public bool? StartChannel { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Settings for the VPC outputs. See VPC for more details.</summary>
    [JsonPropertyName("vpc")]
    public IList<V1beta1ChannelStatusAtProviderVpc>? Vpc { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatusConditions
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

/// <summary>ChannelStatus defines the observed state of Channel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ChannelStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ChannelStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ChannelStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Channel is the Schema for the Channels API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Channel : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ChannelSpec>, IStatus<V1beta1ChannelStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Channel";
    public const string KubeGroup = "medialive.aws.upbound.io";
    public const string KubePluralName = "channels";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ChannelSpec defines the desired state of Channel</summary>
    [JsonPropertyName("spec")]
    public V1beta1ChannelSpec Spec { get; set; }

    /// <summary>ChannelStatus defines the observed state of Channel.</summary>
    [JsonPropertyName("status")]
    public V1beta1ChannelStatus? Status { get; set; }
}