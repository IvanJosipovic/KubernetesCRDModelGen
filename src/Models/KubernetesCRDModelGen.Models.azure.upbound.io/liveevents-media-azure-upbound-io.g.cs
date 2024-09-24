using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.media.azure.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LiveEventSpecDeletionPolicyEnum
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
public partial class V1beta1LiveEventSpecForProviderCrossSiteAccessPolicy
{
    /// <summary>The content of clientaccesspolicy.xml used by Silverlight.</summary>
    [JsonPropertyName("clientAccessPolicy")]
    public string? ClientAccessPolicy { get; set; }

    /// <summary>The content of the Cross Domain Policy (crossdomain.xml).</summary>
    [JsonPropertyName("crossDomainPolicy")]
    public string? CrossDomainPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecForProviderEncoding
{
    /// <summary>Use an ISO 8601 time value between 0.5 to 20 seconds to specify the output fragment length for the video and audio tracks of an encoding live event. For example, use PT2S to indicate 2 seconds. For the video track it also defines the key frame interval, or the length of a GoP (group of pictures). The value cannot be set for pass-through live events. Defaults to PT2S.</summary>
    [JsonPropertyName("keyFrameInterval")]
    public string? KeyFrameInterval { get; set; }

    /// <summary>The optional encoding preset name, used when type is not None. If the type is set to Standard, then the default preset name is Default720p. Else if the type is set to Premium1080p, Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("presetName")]
    public string? PresetName { get; set; }

    /// <summary>Specifies how the input video will be resized to fit the desired output resolution(s). Allowed values are None, AutoFit or AutoSize. Default is None.</summary>
    [JsonPropertyName("stretchMode")]
    public string? StretchMode { get; set; }

    /// <summary>Live event type. Possible values are None, Premium1080p, PassthroughBasic, PassthroughStandard and Standard. When set to None, the service simply passes through the incoming video and audio layer(s) to the output. When type is set to Standard or Premium1080p, a live encoder transcodes the incoming stream into multiple bitrates or layers. Defaults to None. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecForProviderInputIpAccessControlAllow
{
    /// <summary>The IP address or CIDR range.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The name which should be used for this Live Event. Changing this forces a new Live Event to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The subnet mask prefix length (see CIDR notation).</summary>
    [JsonPropertyName("subnetPrefixLength")]
    public double? SubnetPrefixLength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecForProviderInput
{
    /// <summary>A UUID in string form to uniquely identify the stream. If omitted, the service will generate a unique value. Changing this forces a new value to be created.</summary>
    [JsonPropertyName("accessToken")]
    public string? AccessToken { get; set; }

    /// <summary>One or more ip_access_control_allow blocks as defined below.</summary>
    [JsonPropertyName("ipAccessControlAllow")]
    public IList<V1beta1LiveEventSpecForProviderInputIpAccessControlAllow>? IpAccessControlAllow { get; set; }

    /// <summary>ISO 8601 time duration of the key frame interval duration of the input. This value sets the EXT-X-TARGETDURATION property in the HLS output. For example, use PT2S to indicate 2 seconds. This field cannot be set when type is set to Encoding.</summary>
    [JsonPropertyName("keyFrameIntervalDuration")]
    public string? KeyFrameIntervalDuration { get; set; }

    /// <summary>The input protocol for the live event. Allowed values are FragmentedMP4 and RTMP. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("streamingProtocol")]
    public string? StreamingProtocol { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LiveEventSpecForProviderMediaServicesAccountNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LiveEventSpecForProviderMediaServicesAccountNameRefPolicyResolveEnum
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
public partial class V1beta1LiveEventSpecForProviderMediaServicesAccountNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiveEventSpecForProviderMediaServicesAccountNameRefPolicyResolutionEnum>))]
    public V1beta1LiveEventSpecForProviderMediaServicesAccountNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiveEventSpecForProviderMediaServicesAccountNameRefPolicyResolveEnum>))]
    public V1beta1LiveEventSpecForProviderMediaServicesAccountNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServicesAccount in media to populate mediaServicesAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecForProviderMediaServicesAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LiveEventSpecForProviderMediaServicesAccountNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LiveEventSpecForProviderMediaServicesAccountNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LiveEventSpecForProviderMediaServicesAccountNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecForProviderMediaServicesAccountNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiveEventSpecForProviderMediaServicesAccountNameSelectorPolicyResolutionEnum>))]
    public V1beta1LiveEventSpecForProviderMediaServicesAccountNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiveEventSpecForProviderMediaServicesAccountNameSelectorPolicyResolveEnum>))]
    public V1beta1LiveEventSpecForProviderMediaServicesAccountNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServicesAccount in media to populate mediaServicesAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecForProviderMediaServicesAccountNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LiveEventSpecForProviderMediaServicesAccountNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecForProviderPreviewIpAccessControlAllow
{
    /// <summary>The IP address or CIDR range.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The name which should be used for this Live Event. Changing this forces a new Live Event to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The subnet mask prefix length (see CIDR notation).</summary>
    [JsonPropertyName("subnetPrefixLength")]
    public double? SubnetPrefixLength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecForProviderPreview
{
    /// <summary>An alternative media identifier associated with the streaming locator created for the preview. The identifier can be used in the CustomLicenseAcquisitionUrlTemplate or the CustomKeyAcquisitionUrlTemplate of the Streaming Policy specified in the streaming_policy_name field.</summary>
    [JsonPropertyName("alternativeMediaId")]
    public string? AlternativeMediaId { get; set; }

    /// <summary>One or more ip_access_control_allow blocks as defined above.</summary>
    [JsonPropertyName("ipAccessControlAllow")]
    public IList<V1beta1LiveEventSpecForProviderPreviewIpAccessControlAllow>? IpAccessControlAllow { get; set; }

    /// <summary>The identifier of the preview locator in GUID format. Specifying this at creation time allows the caller to know the preview locator url before the event is created. If omitted, the service will generate a random identifier. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("previewLocator")]
    public string? PreviewLocator { get; set; }

    /// <summary>The name of streaming policy used for the live event preview. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("streamingPolicyName")]
    public string? StreamingPolicyName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LiveEventSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LiveEventSpecForProviderResourceGroupNameRefPolicyResolveEnum
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
public partial class V1beta1LiveEventSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiveEventSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1LiveEventSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiveEventSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1LiveEventSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LiveEventSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LiveEventSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LiveEventSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiveEventSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1LiveEventSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiveEventSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1LiveEventSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LiveEventSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecForProvider
{
    /// <summary>The flag indicates if the resource should be automatically started on creation. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("autoStartEnabled")]
    public bool? AutoStartEnabled { get; set; }

    /// <summary>A cross_site_access_policy block as defined below.</summary>
    [JsonPropertyName("crossSiteAccessPolicy")]
    public IList<V1beta1LiveEventSpecForProviderCrossSiteAccessPolicy>? CrossSiteAccessPolicy { get; set; }

    /// <summary>A description for the live event.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A encoding block as defined below.</summary>
    [JsonPropertyName("encoding")]
    public IList<V1beta1LiveEventSpecForProviderEncoding>? Encoding { get; set; }

    /// <summary>When use_static_hostname is set to true, the hostname_prefix specifies the first part of the hostname assigned to the live event preview and ingest endpoints. The final hostname would be a combination of this prefix, the media service account name and a short code for the Azure Media Services data center.</summary>
    [JsonPropertyName("hostnamePrefix")]
    public string? HostnamePrefix { get; set; }

    /// <summary>A input block as defined below.</summary>
    [JsonPropertyName("input")]
    public IList<V1beta1LiveEventSpecForProviderInput>? Input { get; set; }

    /// <summary>The Azure Region where the Live Event should exist. Changing this forces a new Live Event to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The Media Services account name. Changing this forces a new Live Event to be created.</summary>
    [JsonPropertyName("mediaServicesAccountName")]
    public string? MediaServicesAccountName { get; set; }

    /// <summary>Reference to a ServicesAccount in media to populate mediaServicesAccountName.</summary>
    [JsonPropertyName("mediaServicesAccountNameRef")]
    public V1beta1LiveEventSpecForProviderMediaServicesAccountNameRef? MediaServicesAccountNameRef { get; set; }

    /// <summary>Selector for a ServicesAccount in media to populate mediaServicesAccountName.</summary>
    [JsonPropertyName("mediaServicesAccountNameSelector")]
    public V1beta1LiveEventSpecForProviderMediaServicesAccountNameSelector? MediaServicesAccountNameSelector { get; set; }

    /// <summary>A preview block as defined below.</summary>
    [JsonPropertyName("preview")]
    public IList<V1beta1LiveEventSpecForProviderPreview>? Preview { get; set; }

    /// <summary>The name of the Resource Group where the Live Event should exist. Changing this forces a new Live Event to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1LiveEventSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1LiveEventSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A list of options to use for the LiveEvent. Possible values are Default, LowLatency, LowLatencyV2. Please see more at this document. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("streamOptions")]
    public IList<string>? StreamOptions { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Live Event.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies a list of languages (locale) to be used for speech-to-text transcription – it should match the spoken language in the audio track. The value should be in BCP-47 format (e.g: en-US). See the Microsoft Documentation for more information about the live transcription feature and the list of supported languages.</summary>
    [JsonPropertyName("transcriptionLanguages")]
    public IList<string>? TranscriptionLanguages { get; set; }

    /// <summary>Specifies whether a static hostname would be assigned to the live event preview and ingest endpoints. Changing this forces a new Live Event to be created.</summary>
    [JsonPropertyName("useStaticHostname")]
    public bool? UseStaticHostname { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecInitProviderCrossSiteAccessPolicy
{
    /// <summary>The content of clientaccesspolicy.xml used by Silverlight.</summary>
    [JsonPropertyName("clientAccessPolicy")]
    public string? ClientAccessPolicy { get; set; }

    /// <summary>The content of the Cross Domain Policy (crossdomain.xml).</summary>
    [JsonPropertyName("crossDomainPolicy")]
    public string? CrossDomainPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecInitProviderEncoding
{
    /// <summary>Use an ISO 8601 time value between 0.5 to 20 seconds to specify the output fragment length for the video and audio tracks of an encoding live event. For example, use PT2S to indicate 2 seconds. For the video track it also defines the key frame interval, or the length of a GoP (group of pictures). The value cannot be set for pass-through live events. Defaults to PT2S.</summary>
    [JsonPropertyName("keyFrameInterval")]
    public string? KeyFrameInterval { get; set; }

    /// <summary>The optional encoding preset name, used when type is not None. If the type is set to Standard, then the default preset name is Default720p. Else if the type is set to Premium1080p, Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("presetName")]
    public string? PresetName { get; set; }

    /// <summary>Specifies how the input video will be resized to fit the desired output resolution(s). Allowed values are None, AutoFit or AutoSize. Default is None.</summary>
    [JsonPropertyName("stretchMode")]
    public string? StretchMode { get; set; }

    /// <summary>Live event type. Possible values are None, Premium1080p, PassthroughBasic, PassthroughStandard and Standard. When set to None, the service simply passes through the incoming video and audio layer(s) to the output. When type is set to Standard or Premium1080p, a live encoder transcodes the incoming stream into multiple bitrates or layers. Defaults to None. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecInitProviderInputIpAccessControlAllow
{
    /// <summary>The IP address or CIDR range.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The name which should be used for this Live Event. Changing this forces a new Live Event to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The subnet mask prefix length (see CIDR notation).</summary>
    [JsonPropertyName("subnetPrefixLength")]
    public double? SubnetPrefixLength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecInitProviderInput
{
    /// <summary>A UUID in string form to uniquely identify the stream. If omitted, the service will generate a unique value. Changing this forces a new value to be created.</summary>
    [JsonPropertyName("accessToken")]
    public string? AccessToken { get; set; }

    /// <summary>One or more ip_access_control_allow blocks as defined below.</summary>
    [JsonPropertyName("ipAccessControlAllow")]
    public IList<V1beta1LiveEventSpecInitProviderInputIpAccessControlAllow>? IpAccessControlAllow { get; set; }

    /// <summary>ISO 8601 time duration of the key frame interval duration of the input. This value sets the EXT-X-TARGETDURATION property in the HLS output. For example, use PT2S to indicate 2 seconds. This field cannot be set when type is set to Encoding.</summary>
    [JsonPropertyName("keyFrameIntervalDuration")]
    public string? KeyFrameIntervalDuration { get; set; }

    /// <summary>The input protocol for the live event. Allowed values are FragmentedMP4 and RTMP. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("streamingProtocol")]
    public string? StreamingProtocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecInitProviderPreviewIpAccessControlAllow
{
    /// <summary>The IP address or CIDR range.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The name which should be used for this Live Event. Changing this forces a new Live Event to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The subnet mask prefix length (see CIDR notation).</summary>
    [JsonPropertyName("subnetPrefixLength")]
    public double? SubnetPrefixLength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecInitProviderPreview
{
    /// <summary>An alternative media identifier associated with the streaming locator created for the preview. The identifier can be used in the CustomLicenseAcquisitionUrlTemplate or the CustomKeyAcquisitionUrlTemplate of the Streaming Policy specified in the streaming_policy_name field.</summary>
    [JsonPropertyName("alternativeMediaId")]
    public string? AlternativeMediaId { get; set; }

    /// <summary>One or more ip_access_control_allow blocks as defined above.</summary>
    [JsonPropertyName("ipAccessControlAllow")]
    public IList<V1beta1LiveEventSpecInitProviderPreviewIpAccessControlAllow>? IpAccessControlAllow { get; set; }

    /// <summary>The identifier of the preview locator in GUID format. Specifying this at creation time allows the caller to know the preview locator url before the event is created. If omitted, the service will generate a random identifier. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("previewLocator")]
    public string? PreviewLocator { get; set; }

    /// <summary>The name of streaming policy used for the live event preview. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("streamingPolicyName")]
    public string? StreamingPolicyName { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecInitProvider
{
    /// <summary>The flag indicates if the resource should be automatically started on creation. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("autoStartEnabled")]
    public bool? AutoStartEnabled { get; set; }

    /// <summary>A cross_site_access_policy block as defined below.</summary>
    [JsonPropertyName("crossSiteAccessPolicy")]
    public IList<V1beta1LiveEventSpecInitProviderCrossSiteAccessPolicy>? CrossSiteAccessPolicy { get; set; }

    /// <summary>A description for the live event.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A encoding block as defined below.</summary>
    [JsonPropertyName("encoding")]
    public IList<V1beta1LiveEventSpecInitProviderEncoding>? Encoding { get; set; }

    /// <summary>When use_static_hostname is set to true, the hostname_prefix specifies the first part of the hostname assigned to the live event preview and ingest endpoints. The final hostname would be a combination of this prefix, the media service account name and a short code for the Azure Media Services data center.</summary>
    [JsonPropertyName("hostnamePrefix")]
    public string? HostnamePrefix { get; set; }

    /// <summary>A input block as defined below.</summary>
    [JsonPropertyName("input")]
    public IList<V1beta1LiveEventSpecInitProviderInput>? Input { get; set; }

    /// <summary>The Azure Region where the Live Event should exist. Changing this forces a new Live Event to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A preview block as defined below.</summary>
    [JsonPropertyName("preview")]
    public IList<V1beta1LiveEventSpecInitProviderPreview>? Preview { get; set; }

    /// <summary>A list of options to use for the LiveEvent. Possible values are Default, LowLatency, LowLatencyV2. Please see more at this document. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("streamOptions")]
    public IList<string>? StreamOptions { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Live Event.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies a list of languages (locale) to be used for speech-to-text transcription – it should match the spoken language in the audio track. The value should be in BCP-47 format (e.g: en-US). See the Microsoft Documentation for more information about the live transcription feature and the list of supported languages.</summary>
    [JsonPropertyName("transcriptionLanguages")]
    public IList<string>? TranscriptionLanguages { get; set; }

    /// <summary>Specifies whether a static hostname would be assigned to the live event preview and ingest endpoints. Changing this forces a new Live Event to be created.</summary>
    [JsonPropertyName("useStaticHostname")]
    public bool? UseStaticHostname { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LiveEventSpecManagementPoliciesEnum
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
public enum V1beta1LiveEventSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LiveEventSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1LiveEventSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiveEventSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1LiveEventSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiveEventSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1LiveEventSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LiveEventSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LiveEventSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1LiveEventSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1LiveEventSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiveEventSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1LiveEventSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiveEventSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1LiveEventSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LiveEventSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1LiveEventSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1LiveEventSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1LiveEventSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>LiveEventSpec defines the desired state of LiveEvent</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LiveEventSpecDeletionPolicyEnum>))]
    public V1beta1LiveEventSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LiveEventSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LiveEventSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1LiveEventSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LiveEventSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1LiveEventSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LiveEventSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventStatusAtProviderCrossSiteAccessPolicy
{
    /// <summary>The content of clientaccesspolicy.xml used by Silverlight.</summary>
    [JsonPropertyName("clientAccessPolicy")]
    public string? ClientAccessPolicy { get; set; }

    /// <summary>The content of the Cross Domain Policy (crossdomain.xml).</summary>
    [JsonPropertyName("crossDomainPolicy")]
    public string? CrossDomainPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventStatusAtProviderEncoding
{
    /// <summary>Use an ISO 8601 time value between 0.5 to 20 seconds to specify the output fragment length for the video and audio tracks of an encoding live event. For example, use PT2S to indicate 2 seconds. For the video track it also defines the key frame interval, or the length of a GoP (group of pictures). The value cannot be set for pass-through live events. Defaults to PT2S.</summary>
    [JsonPropertyName("keyFrameInterval")]
    public string? KeyFrameInterval { get; set; }

    /// <summary>The optional encoding preset name, used when type is not None. If the type is set to Standard, then the default preset name is Default720p. Else if the type is set to Premium1080p, Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("presetName")]
    public string? PresetName { get; set; }

    /// <summary>Specifies how the input video will be resized to fit the desired output resolution(s). Allowed values are None, AutoFit or AutoSize. Default is None.</summary>
    [JsonPropertyName("stretchMode")]
    public string? StretchMode { get; set; }

    /// <summary>Live event type. Possible values are None, Premium1080p, PassthroughBasic, PassthroughStandard and Standard. When set to None, the service simply passes through the incoming video and audio layer(s) to the output. When type is set to Standard or Premium1080p, a live encoder transcodes the incoming stream into multiple bitrates or layers. Defaults to None. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventStatusAtProviderInputEndpoint
{
    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventStatusAtProviderInputIpAccessControlAllow
{
    /// <summary>The IP address or CIDR range.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The name which should be used for this Live Event. Changing this forces a new Live Event to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The subnet mask prefix length (see CIDR notation).</summary>
    [JsonPropertyName("subnetPrefixLength")]
    public double? SubnetPrefixLength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventStatusAtProviderInput
{
    /// <summary>A UUID in string form to uniquely identify the stream. If omitted, the service will generate a unique value. Changing this forces a new value to be created.</summary>
    [JsonPropertyName("accessToken")]
    public string? AccessToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public IList<V1beta1LiveEventStatusAtProviderInputEndpoint>? Endpoint { get; set; }

    /// <summary>One or more ip_access_control_allow blocks as defined below.</summary>
    [JsonPropertyName("ipAccessControlAllow")]
    public IList<V1beta1LiveEventStatusAtProviderInputIpAccessControlAllow>? IpAccessControlAllow { get; set; }

    /// <summary>ISO 8601 time duration of the key frame interval duration of the input. This value sets the EXT-X-TARGETDURATION property in the HLS output. For example, use PT2S to indicate 2 seconds. This field cannot be set when type is set to Encoding.</summary>
    [JsonPropertyName("keyFrameIntervalDuration")]
    public string? KeyFrameIntervalDuration { get; set; }

    /// <summary>The input protocol for the live event. Allowed values are FragmentedMP4 and RTMP. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("streamingProtocol")]
    public string? StreamingProtocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventStatusAtProviderPreviewEndpoint
{
    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventStatusAtProviderPreviewIpAccessControlAllow
{
    /// <summary>The IP address or CIDR range.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The name which should be used for this Live Event. Changing this forces a new Live Event to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The subnet mask prefix length (see CIDR notation).</summary>
    [JsonPropertyName("subnetPrefixLength")]
    public double? SubnetPrefixLength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventStatusAtProviderPreview
{
    /// <summary>An alternative media identifier associated with the streaming locator created for the preview. The identifier can be used in the CustomLicenseAcquisitionUrlTemplate or the CustomKeyAcquisitionUrlTemplate of the Streaming Policy specified in the streaming_policy_name field.</summary>
    [JsonPropertyName("alternativeMediaId")]
    public string? AlternativeMediaId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public IList<V1beta1LiveEventStatusAtProviderPreviewEndpoint>? Endpoint { get; set; }

    /// <summary>One or more ip_access_control_allow blocks as defined above.</summary>
    [JsonPropertyName("ipAccessControlAllow")]
    public IList<V1beta1LiveEventStatusAtProviderPreviewIpAccessControlAllow>? IpAccessControlAllow { get; set; }

    /// <summary>The identifier of the preview locator in GUID format. Specifying this at creation time allows the caller to know the preview locator url before the event is created. If omitted, the service will generate a random identifier. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("previewLocator")]
    public string? PreviewLocator { get; set; }

    /// <summary>The name of streaming policy used for the live event preview. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("streamingPolicyName")]
    public string? StreamingPolicyName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventStatusAtProvider
{
    /// <summary>The flag indicates if the resource should be automatically started on creation. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("autoStartEnabled")]
    public bool? AutoStartEnabled { get; set; }

    /// <summary>A cross_site_access_policy block as defined below.</summary>
    [JsonPropertyName("crossSiteAccessPolicy")]
    public IList<V1beta1LiveEventStatusAtProviderCrossSiteAccessPolicy>? CrossSiteAccessPolicy { get; set; }

    /// <summary>A description for the live event.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A encoding block as defined below.</summary>
    [JsonPropertyName("encoding")]
    public IList<V1beta1LiveEventStatusAtProviderEncoding>? Encoding { get; set; }

    /// <summary>When use_static_hostname is set to true, the hostname_prefix specifies the first part of the hostname assigned to the live event preview and ingest endpoints. The final hostname would be a combination of this prefix, the media service account name and a short code for the Azure Media Services data center.</summary>
    [JsonPropertyName("hostnamePrefix")]
    public string? HostnamePrefix { get; set; }

    /// <summary>The ID of the Live Event.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A input block as defined below.</summary>
    [JsonPropertyName("input")]
    public IList<V1beta1LiveEventStatusAtProviderInput>? Input { get; set; }

    /// <summary>The Azure Region where the Live Event should exist. Changing this forces a new Live Event to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The Media Services account name. Changing this forces a new Live Event to be created.</summary>
    [JsonPropertyName("mediaServicesAccountName")]
    public string? MediaServicesAccountName { get; set; }

    /// <summary>A preview block as defined below.</summary>
    [JsonPropertyName("preview")]
    public IList<V1beta1LiveEventStatusAtProviderPreview>? Preview { get; set; }

    /// <summary>The name of the Resource Group where the Live Event should exist. Changing this forces a new Live Event to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A list of options to use for the LiveEvent. Possible values are Default, LowLatency, LowLatencyV2. Please see more at this document. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("streamOptions")]
    public IList<string>? StreamOptions { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Live Event.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies a list of languages (locale) to be used for speech-to-text transcription – it should match the spoken language in the audio track. The value should be in BCP-47 format (e.g: en-US). See the Microsoft Documentation for more information about the live transcription feature and the list of supported languages.</summary>
    [JsonPropertyName("transcriptionLanguages")]
    public IList<string>? TranscriptionLanguages { get; set; }

    /// <summary>Specifies whether a static hostname would be assigned to the live event preview and ingest endpoints. Changing this forces a new Live Event to be created.</summary>
    [JsonPropertyName("useStaticHostname")]
    public bool? UseStaticHostname { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventStatusConditions
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

/// <summary>LiveEventStatus defines the observed state of LiveEvent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LiveEventStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LiveEventStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LiveEventStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LiveEvent is the Schema for the LiveEvents API. Manages a Live Event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LiveEvent : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LiveEventSpec>, IStatus<V1beta1LiveEventStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LiveEvent";
    public const string KubeGroup = "media.azure.upbound.io";
    public const string KubePluralName = "liveevents";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LiveEventSpec defines the desired state of LiveEvent</summary>
    [JsonPropertyName("spec")]
    public V1beta1LiveEventSpec Spec { get; set; }

    /// <summary>LiveEventStatus defines the observed state of LiveEvent.</summary>
    [JsonPropertyName("status")]
    public V1beta1LiveEventStatus? Status { get; set; }
}