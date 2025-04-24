using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.media.azure.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderCommonEncryptionCbcsClearKeyEncryption
{
    /// <summary>The URL template for the custom service that delivers content keys to the end user. This is not required when using Azure Media Services for issuing keys. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("customKeysAcquisitionUrlTemplate")]
    public string? CustomKeysAcquisitionUrlTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderCommonEncryptionCbcsDefaultContentKey
{
    /// <summary>Label can be used to specify Content Key when creating a Streaming Locator. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Policy used by Default Key. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderCommonEncryptionCbcsDrmFairplay
{
    /// <summary>All license to be persistent or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("allowPersistentLicense")]
    public bool? AllowPersistentLicense { get; set; }

    /// <summary>The URL template for the custom service that delivers licenses to the end user. This is not required when using Azure Media Services for issuing licenses. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("customLicenseAcquisitionUrlTemplate")]
    public string? CustomLicenseAcquisitionUrlTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderCommonEncryptionCbcsEnabledProtocols
{
    /// <summary>Enable DASH protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("dash")]
    public bool? Dash { get; set; }

    /// <summary>Enable Download protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("download")]
    public bool? Download { get; set; }

    /// <summary>Enable HLS protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("hls")]
    public bool? Hls { get; set; }

    /// <summary>Enable SmoothStreaming protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderCommonEncryptionCbcs
{
    /// <summary>A clear_key_encryption block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("clearKeyEncryption")]
    public IList<V1beta1StreamingPolicySpecForProviderCommonEncryptionCbcsClearKeyEncryption>? ClearKeyEncryption { get; set; }

    /// <summary>A default_content_key block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("defaultContentKey")]
    public IList<V1beta1StreamingPolicySpecForProviderCommonEncryptionCbcsDefaultContentKey>? DefaultContentKey { get; set; }

    /// <summary>A drm_fairplay block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("drmFairplay")]
    public IList<V1beta1StreamingPolicySpecForProviderCommonEncryptionCbcsDrmFairplay>? DrmFairplay { get; set; }

    /// <summary>A enabled_protocols block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("enabledProtocols")]
    public IList<V1beta1StreamingPolicySpecForProviderCommonEncryptionCbcsEnabledProtocols>? EnabledProtocols { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderCommonEncryptionCencClearKeyEncryption
{
    /// <summary>The URL template for the custom service that delivers content keys to the end user. This is not required when using Azure Media Services for issuing keys. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("customKeysAcquisitionUrlTemplate")]
    public string? CustomKeysAcquisitionUrlTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderCommonEncryptionCencClearTrackCondition
{
    /// <summary>The track property condition operation. Possible value is Equal. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The track property type. Possible value is FourCC. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("property")]
    public string? Property { get; set; }

    /// <summary>The track property value. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderCommonEncryptionCencClearTrack
{
    /// <summary>One or more condition blocks as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1StreamingPolicySpecForProviderCommonEncryptionCencClearTrackCondition>? Condition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderCommonEncryptionCencContentKeyToTrackMappingTrackCondition
{
    /// <summary>The track property condition operation. Possible value is Equal. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The track property type. Possible value is FourCC. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("property")]
    public string? Property { get; set; }

    /// <summary>The track property value. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderCommonEncryptionCencContentKeyToTrackMappingTrack
{
    /// <summary>One or more condition blocks as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1StreamingPolicySpecForProviderCommonEncryptionCencContentKeyToTrackMappingTrackCondition>? Condition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderCommonEncryptionCencContentKeyToTrackMapping
{
    /// <summary>Label can be used to specify Content Key when creating a Streaming Locator. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Policy used by Default Key. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>One or more track blocks as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("track")]
    public IList<V1beta1StreamingPolicySpecForProviderCommonEncryptionCencContentKeyToTrackMappingTrack>? Track { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderCommonEncryptionCencDefaultContentKeyPolicyNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ContentKeyPolicy in media to populate policyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderCommonEncryptionCencDefaultContentKeyPolicyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamingPolicySpecForProviderCommonEncryptionCencDefaultContentKeyPolicyNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderCommonEncryptionCencDefaultContentKeyPolicyNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ContentKeyPolicy in media to populate policyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderCommonEncryptionCencDefaultContentKeyPolicyNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamingPolicySpecForProviderCommonEncryptionCencDefaultContentKeyPolicyNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderCommonEncryptionCencDefaultContentKey
{
    /// <summary>Label can be used to specify Content Key when creating a Streaming Locator. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Policy used by Default Key. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>Reference to a ContentKeyPolicy in media to populate policyName.</summary>
    [JsonPropertyName("policyNameRef")]
    public V1beta1StreamingPolicySpecForProviderCommonEncryptionCencDefaultContentKeyPolicyNameRef? PolicyNameRef { get; set; }

    /// <summary>Selector for a ContentKeyPolicy in media to populate policyName.</summary>
    [JsonPropertyName("policyNameSelector")]
    public V1beta1StreamingPolicySpecForProviderCommonEncryptionCencDefaultContentKeyPolicyNameSelector? PolicyNameSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderCommonEncryptionCencDrmPlayready
{
    /// <summary>Custom attributes for PlayReady. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("customAttributes")]
    public string? CustomAttributes { get; set; }

    /// <summary>The URL template for the custom service that delivers licenses to the end user. This is not required when using Azure Media Services for issuing licenses. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("customLicenseAcquisitionUrlTemplate")]
    public string? CustomLicenseAcquisitionUrlTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderCommonEncryptionCencEnabledProtocols
{
    /// <summary>Enable DASH protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("dash")]
    public bool? Dash { get; set; }

    /// <summary>Enable Download protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("download")]
    public bool? Download { get; set; }

    /// <summary>Enable HLS protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("hls")]
    public bool? Hls { get; set; }

    /// <summary>Enable SmoothStreaming protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderCommonEncryptionCenc
{
    /// <summary>A clear_key_encryption block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("clearKeyEncryption")]
    public IList<V1beta1StreamingPolicySpecForProviderCommonEncryptionCencClearKeyEncryption>? ClearKeyEncryption { get; set; }

    /// <summary>One or more clear_track blocks as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("clearTrack")]
    public IList<V1beta1StreamingPolicySpecForProviderCommonEncryptionCencClearTrack>? ClearTrack { get; set; }

    /// <summary>One or more content_key_to_track_mapping blocks as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("contentKeyToTrackMapping")]
    public IList<V1beta1StreamingPolicySpecForProviderCommonEncryptionCencContentKeyToTrackMapping>? ContentKeyToTrackMapping { get; set; }

    /// <summary>A default_content_key block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("defaultContentKey")]
    public IList<V1beta1StreamingPolicySpecForProviderCommonEncryptionCencDefaultContentKey>? DefaultContentKey { get; set; }

    /// <summary>A drm_playready block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("drmPlayready")]
    public IList<V1beta1StreamingPolicySpecForProviderCommonEncryptionCencDrmPlayready>? DrmPlayready { get; set; }

    /// <summary>The URL template for the custom service that delivers licenses to the end user. This is not required when using Azure Media Services for issuing licenses. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("drmWidevineCustomLicenseAcquisitionUrlTemplate")]
    public string? DrmWidevineCustomLicenseAcquisitionUrlTemplate { get; set; }

    /// <summary>A enabled_protocols block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("enabledProtocols")]
    public IList<V1beta1StreamingPolicySpecForProviderCommonEncryptionCencEnabledProtocols>? EnabledProtocols { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderEnvelopeEncryptionDefaultContentKey
{
    /// <summary>Label can be used to specify Content Key when creating a Streaming Locator. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Policy used by Default Key. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderEnvelopeEncryptionEnabledProtocols
{
    /// <summary>Enable DASH protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("dash")]
    public bool? Dash { get; set; }

    /// <summary>Enable Download protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("download")]
    public bool? Download { get; set; }

    /// <summary>Enable HLS protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("hls")]
    public bool? Hls { get; set; }

    /// <summary>Enable SmoothStreaming protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderEnvelopeEncryption
{
    /// <summary>The URL template for the custom service that delivers content keys to the end user. This is not required when using Azure Media Services for issuing keys. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("customKeysAcquisitionUrlTemplate")]
    public string? CustomKeysAcquisitionUrlTemplate { get; set; }

    /// <summary>A default_content_key block as defined above. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("defaultContentKey")]
    public IList<V1beta1StreamingPolicySpecForProviderEnvelopeEncryptionDefaultContentKey>? DefaultContentKey { get; set; }

    /// <summary>A enabled_protocols block as defined above. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("enabledProtocols")]
    public IList<V1beta1StreamingPolicySpecForProviderEnvelopeEncryptionEnabledProtocols>? EnabledProtocols { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderMediaServicesAccountNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ServicesAccount in media to populate mediaServicesAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderMediaServicesAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamingPolicySpecForProviderMediaServicesAccountNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderMediaServicesAccountNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ServicesAccount in media to populate mediaServicesAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderMediaServicesAccountNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamingPolicySpecForProviderMediaServicesAccountNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderNoEncryptionEnabledProtocols
{
    /// <summary>Enable DASH protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("dash")]
    public bool? Dash { get; set; }

    /// <summary>Enable Download protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("download")]
    public bool? Download { get; set; }

    /// <summary>Enable HLS protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("hls")]
    public bool? Hls { get; set; }

    /// <summary>Enable SmoothStreaming protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamingPolicySpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamingPolicySpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecForProvider
{
    /// <summary>A common_encryption_cbcs block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("commonEncryptionCbcs")]
    public IList<V1beta1StreamingPolicySpecForProviderCommonEncryptionCbcs>? CommonEncryptionCbcs { get; set; }

    /// <summary>A common_encryption_cenc block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("commonEncryptionCenc")]
    public IList<V1beta1StreamingPolicySpecForProviderCommonEncryptionCenc>? CommonEncryptionCenc { get; set; }

    /// <summary>Default Content Key used by current Streaming Policy. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("defaultContentKeyPolicyName")]
    public string? DefaultContentKeyPolicyName { get; set; }

    /// <summary>A envelope_encryption block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("envelopeEncryption")]
    public IList<V1beta1StreamingPolicySpecForProviderEnvelopeEncryption>? EnvelopeEncryption { get; set; }

    /// <summary>The Media Services account name. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("mediaServicesAccountName")]
    public string? MediaServicesAccountName { get; set; }

    /// <summary>Reference to a ServicesAccount in media to populate mediaServicesAccountName.</summary>
    [JsonPropertyName("mediaServicesAccountNameRef")]
    public V1beta1StreamingPolicySpecForProviderMediaServicesAccountNameRef? MediaServicesAccountNameRef { get; set; }

    /// <summary>Selector for a ServicesAccount in media to populate mediaServicesAccountName.</summary>
    [JsonPropertyName("mediaServicesAccountNameSelector")]
    public V1beta1StreamingPolicySpecForProviderMediaServicesAccountNameSelector? MediaServicesAccountNameSelector { get; set; }

    /// <summary>A no_encryption_enabled_protocols block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("noEncryptionEnabledProtocols")]
    public IList<V1beta1StreamingPolicySpecForProviderNoEncryptionEnabledProtocols>? NoEncryptionEnabledProtocols { get; set; }

    /// <summary>The name of the Resource Group where the Streaming Policy should exist. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1StreamingPolicySpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1StreamingPolicySpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderCommonEncryptionCbcsClearKeyEncryption
{
    /// <summary>The URL template for the custom service that delivers content keys to the end user. This is not required when using Azure Media Services for issuing keys. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("customKeysAcquisitionUrlTemplate")]
    public string? CustomKeysAcquisitionUrlTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderCommonEncryptionCbcsDefaultContentKey
{
    /// <summary>Label can be used to specify Content Key when creating a Streaming Locator. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Policy used by Default Key. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderCommonEncryptionCbcsDrmFairplay
{
    /// <summary>All license to be persistent or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("allowPersistentLicense")]
    public bool? AllowPersistentLicense { get; set; }

    /// <summary>The URL template for the custom service that delivers licenses to the end user. This is not required when using Azure Media Services for issuing licenses. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("customLicenseAcquisitionUrlTemplate")]
    public string? CustomLicenseAcquisitionUrlTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderCommonEncryptionCbcsEnabledProtocols
{
    /// <summary>Enable DASH protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("dash")]
    public bool? Dash { get; set; }

    /// <summary>Enable Download protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("download")]
    public bool? Download { get; set; }

    /// <summary>Enable HLS protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("hls")]
    public bool? Hls { get; set; }

    /// <summary>Enable SmoothStreaming protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderCommonEncryptionCbcs
{
    /// <summary>A clear_key_encryption block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("clearKeyEncryption")]
    public IList<V1beta1StreamingPolicySpecInitProviderCommonEncryptionCbcsClearKeyEncryption>? ClearKeyEncryption { get; set; }

    /// <summary>A default_content_key block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("defaultContentKey")]
    public IList<V1beta1StreamingPolicySpecInitProviderCommonEncryptionCbcsDefaultContentKey>? DefaultContentKey { get; set; }

    /// <summary>A drm_fairplay block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("drmFairplay")]
    public IList<V1beta1StreamingPolicySpecInitProviderCommonEncryptionCbcsDrmFairplay>? DrmFairplay { get; set; }

    /// <summary>A enabled_protocols block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("enabledProtocols")]
    public IList<V1beta1StreamingPolicySpecInitProviderCommonEncryptionCbcsEnabledProtocols>? EnabledProtocols { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencClearKeyEncryption
{
    /// <summary>The URL template for the custom service that delivers content keys to the end user. This is not required when using Azure Media Services for issuing keys. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("customKeysAcquisitionUrlTemplate")]
    public string? CustomKeysAcquisitionUrlTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencClearTrackCondition
{
    /// <summary>The track property condition operation. Possible value is Equal. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The track property type. Possible value is FourCC. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("property")]
    public string? Property { get; set; }

    /// <summary>The track property value. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencClearTrack
{
    /// <summary>One or more condition blocks as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencClearTrackCondition>? Condition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencContentKeyToTrackMappingTrackCondition
{
    /// <summary>The track property condition operation. Possible value is Equal. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The track property type. Possible value is FourCC. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("property")]
    public string? Property { get; set; }

    /// <summary>The track property value. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencContentKeyToTrackMappingTrack
{
    /// <summary>One or more condition blocks as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencContentKeyToTrackMappingTrackCondition>? Condition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencContentKeyToTrackMapping
{
    /// <summary>Label can be used to specify Content Key when creating a Streaming Locator. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Policy used by Default Key. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>One or more track blocks as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("track")]
    public IList<V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencContentKeyToTrackMappingTrack>? Track { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencDefaultContentKeyPolicyNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ContentKeyPolicy in media to populate policyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencDefaultContentKeyPolicyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencDefaultContentKeyPolicyNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencDefaultContentKeyPolicyNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ContentKeyPolicy in media to populate policyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencDefaultContentKeyPolicyNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencDefaultContentKeyPolicyNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencDefaultContentKey
{
    /// <summary>Label can be used to specify Content Key when creating a Streaming Locator. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Policy used by Default Key. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>Reference to a ContentKeyPolicy in media to populate policyName.</summary>
    [JsonPropertyName("policyNameRef")]
    public V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencDefaultContentKeyPolicyNameRef? PolicyNameRef { get; set; }

    /// <summary>Selector for a ContentKeyPolicy in media to populate policyName.</summary>
    [JsonPropertyName("policyNameSelector")]
    public V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencDefaultContentKeyPolicyNameSelector? PolicyNameSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencDrmPlayready
{
    /// <summary>Custom attributes for PlayReady. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("customAttributes")]
    public string? CustomAttributes { get; set; }

    /// <summary>The URL template for the custom service that delivers licenses to the end user. This is not required when using Azure Media Services for issuing licenses. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("customLicenseAcquisitionUrlTemplate")]
    public string? CustomLicenseAcquisitionUrlTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencEnabledProtocols
{
    /// <summary>Enable DASH protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("dash")]
    public bool? Dash { get; set; }

    /// <summary>Enable Download protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("download")]
    public bool? Download { get; set; }

    /// <summary>Enable HLS protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("hls")]
    public bool? Hls { get; set; }

    /// <summary>Enable SmoothStreaming protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderCommonEncryptionCenc
{
    /// <summary>A clear_key_encryption block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("clearKeyEncryption")]
    public IList<V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencClearKeyEncryption>? ClearKeyEncryption { get; set; }

    /// <summary>One or more clear_track blocks as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("clearTrack")]
    public IList<V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencClearTrack>? ClearTrack { get; set; }

    /// <summary>One or more content_key_to_track_mapping blocks as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("contentKeyToTrackMapping")]
    public IList<V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencContentKeyToTrackMapping>? ContentKeyToTrackMapping { get; set; }

    /// <summary>A default_content_key block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("defaultContentKey")]
    public IList<V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencDefaultContentKey>? DefaultContentKey { get; set; }

    /// <summary>A drm_playready block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("drmPlayready")]
    public IList<V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencDrmPlayready>? DrmPlayready { get; set; }

    /// <summary>The URL template for the custom service that delivers licenses to the end user. This is not required when using Azure Media Services for issuing licenses. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("drmWidevineCustomLicenseAcquisitionUrlTemplate")]
    public string? DrmWidevineCustomLicenseAcquisitionUrlTemplate { get; set; }

    /// <summary>A enabled_protocols block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("enabledProtocols")]
    public IList<V1beta1StreamingPolicySpecInitProviderCommonEncryptionCencEnabledProtocols>? EnabledProtocols { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderEnvelopeEncryptionDefaultContentKey
{
    /// <summary>Label can be used to specify Content Key when creating a Streaming Locator. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Policy used by Default Key. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderEnvelopeEncryptionEnabledProtocols
{
    /// <summary>Enable DASH protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("dash")]
    public bool? Dash { get; set; }

    /// <summary>Enable Download protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("download")]
    public bool? Download { get; set; }

    /// <summary>Enable HLS protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("hls")]
    public bool? Hls { get; set; }

    /// <summary>Enable SmoothStreaming protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderEnvelopeEncryption
{
    /// <summary>The URL template for the custom service that delivers content keys to the end user. This is not required when using Azure Media Services for issuing keys. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("customKeysAcquisitionUrlTemplate")]
    public string? CustomKeysAcquisitionUrlTemplate { get; set; }

    /// <summary>A default_content_key block as defined above. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("defaultContentKey")]
    public IList<V1beta1StreamingPolicySpecInitProviderEnvelopeEncryptionDefaultContentKey>? DefaultContentKey { get; set; }

    /// <summary>A enabled_protocols block as defined above. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("enabledProtocols")]
    public IList<V1beta1StreamingPolicySpecInitProviderEnvelopeEncryptionEnabledProtocols>? EnabledProtocols { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProviderNoEncryptionEnabledProtocols
{
    /// <summary>Enable DASH protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("dash")]
    public bool? Dash { get; set; }

    /// <summary>Enable Download protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("download")]
    public bool? Download { get; set; }

    /// <summary>Enable HLS protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("hls")]
    public bool? Hls { get; set; }

    /// <summary>Enable SmoothStreaming protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecInitProvider
{
    /// <summary>A common_encryption_cbcs block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("commonEncryptionCbcs")]
    public IList<V1beta1StreamingPolicySpecInitProviderCommonEncryptionCbcs>? CommonEncryptionCbcs { get; set; }

    /// <summary>A common_encryption_cenc block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("commonEncryptionCenc")]
    public IList<V1beta1StreamingPolicySpecInitProviderCommonEncryptionCenc>? CommonEncryptionCenc { get; set; }

    /// <summary>Default Content Key used by current Streaming Policy. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("defaultContentKeyPolicyName")]
    public string? DefaultContentKeyPolicyName { get; set; }

    /// <summary>A envelope_encryption block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("envelopeEncryption")]
    public IList<V1beta1StreamingPolicySpecInitProviderEnvelopeEncryption>? EnvelopeEncryption { get; set; }

    /// <summary>A no_encryption_enabled_protocols block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("noEncryptionEnabledProtocols")]
    public IList<V1beta1StreamingPolicySpecInitProviderNoEncryptionEnabledProtocols>? NoEncryptionEnabledProtocols { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecProviderConfigRefPolicy
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
public partial class V1beta1StreamingPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamingPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1StreamingPolicySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamingPolicySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1StreamingPolicySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1StreamingPolicySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1StreamingPolicySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>StreamingPolicySpec defines the desired state of StreamingPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1StreamingPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1StreamingPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1StreamingPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1StreamingPolicySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1StreamingPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCbcsClearKeyEncryption
{
    /// <summary>The URL template for the custom service that delivers content keys to the end user. This is not required when using Azure Media Services for issuing keys. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("customKeysAcquisitionUrlTemplate")]
    public string? CustomKeysAcquisitionUrlTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCbcsDefaultContentKey
{
    /// <summary>Label can be used to specify Content Key when creating a Streaming Locator. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Policy used by Default Key. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCbcsDrmFairplay
{
    /// <summary>All license to be persistent or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("allowPersistentLicense")]
    public bool? AllowPersistentLicense { get; set; }

    /// <summary>The URL template for the custom service that delivers licenses to the end user. This is not required when using Azure Media Services for issuing licenses. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("customLicenseAcquisitionUrlTemplate")]
    public string? CustomLicenseAcquisitionUrlTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCbcsEnabledProtocols
{
    /// <summary>Enable DASH protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("dash")]
    public bool? Dash { get; set; }

    /// <summary>Enable Download protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("download")]
    public bool? Download { get; set; }

    /// <summary>Enable HLS protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("hls")]
    public bool? Hls { get; set; }

    /// <summary>Enable SmoothStreaming protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCbcs
{
    /// <summary>A clear_key_encryption block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("clearKeyEncryption")]
    public IList<V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCbcsClearKeyEncryption>? ClearKeyEncryption { get; set; }

    /// <summary>A default_content_key block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("defaultContentKey")]
    public IList<V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCbcsDefaultContentKey>? DefaultContentKey { get; set; }

    /// <summary>A drm_fairplay block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("drmFairplay")]
    public IList<V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCbcsDrmFairplay>? DrmFairplay { get; set; }

    /// <summary>A enabled_protocols block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("enabledProtocols")]
    public IList<V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCbcsEnabledProtocols>? EnabledProtocols { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCencClearKeyEncryption
{
    /// <summary>The URL template for the custom service that delivers content keys to the end user. This is not required when using Azure Media Services for issuing keys. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("customKeysAcquisitionUrlTemplate")]
    public string? CustomKeysAcquisitionUrlTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCencClearTrackCondition
{
    /// <summary>The track property condition operation. Possible value is Equal. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The track property type. Possible value is FourCC. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("property")]
    public string? Property { get; set; }

    /// <summary>The track property value. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCencClearTrack
{
    /// <summary>One or more condition blocks as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCencClearTrackCondition>? Condition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCencContentKeyToTrackMappingTrackCondition
{
    /// <summary>The track property condition operation. Possible value is Equal. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The track property type. Possible value is FourCC. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("property")]
    public string? Property { get; set; }

    /// <summary>The track property value. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCencContentKeyToTrackMappingTrack
{
    /// <summary>One or more condition blocks as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCencContentKeyToTrackMappingTrackCondition>? Condition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCencContentKeyToTrackMapping
{
    /// <summary>Label can be used to specify Content Key when creating a Streaming Locator. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Policy used by Default Key. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>One or more track blocks as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("track")]
    public IList<V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCencContentKeyToTrackMappingTrack>? Track { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCencDefaultContentKey
{
    /// <summary>Label can be used to specify Content Key when creating a Streaming Locator. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Policy used by Default Key. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCencDrmPlayready
{
    /// <summary>Custom attributes for PlayReady. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("customAttributes")]
    public string? CustomAttributes { get; set; }

    /// <summary>The URL template for the custom service that delivers licenses to the end user. This is not required when using Azure Media Services for issuing licenses. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("customLicenseAcquisitionUrlTemplate")]
    public string? CustomLicenseAcquisitionUrlTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCencEnabledProtocols
{
    /// <summary>Enable DASH protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("dash")]
    public bool? Dash { get; set; }

    /// <summary>Enable Download protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("download")]
    public bool? Download { get; set; }

    /// <summary>Enable HLS protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("hls")]
    public bool? Hls { get; set; }

    /// <summary>Enable SmoothStreaming protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCenc
{
    /// <summary>A clear_key_encryption block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("clearKeyEncryption")]
    public IList<V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCencClearKeyEncryption>? ClearKeyEncryption { get; set; }

    /// <summary>One or more clear_track blocks as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("clearTrack")]
    public IList<V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCencClearTrack>? ClearTrack { get; set; }

    /// <summary>One or more content_key_to_track_mapping blocks as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("contentKeyToTrackMapping")]
    public IList<V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCencContentKeyToTrackMapping>? ContentKeyToTrackMapping { get; set; }

    /// <summary>A default_content_key block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("defaultContentKey")]
    public IList<V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCencDefaultContentKey>? DefaultContentKey { get; set; }

    /// <summary>A drm_playready block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("drmPlayready")]
    public IList<V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCencDrmPlayready>? DrmPlayready { get; set; }

    /// <summary>The URL template for the custom service that delivers licenses to the end user. This is not required when using Azure Media Services for issuing licenses. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("drmWidevineCustomLicenseAcquisitionUrlTemplate")]
    public string? DrmWidevineCustomLicenseAcquisitionUrlTemplate { get; set; }

    /// <summary>A enabled_protocols block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("enabledProtocols")]
    public IList<V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCencEnabledProtocols>? EnabledProtocols { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatusAtProviderEnvelopeEncryptionDefaultContentKey
{
    /// <summary>Label can be used to specify Content Key when creating a Streaming Locator. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Policy used by Default Key. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatusAtProviderEnvelopeEncryptionEnabledProtocols
{
    /// <summary>Enable DASH protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("dash")]
    public bool? Dash { get; set; }

    /// <summary>Enable Download protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("download")]
    public bool? Download { get; set; }

    /// <summary>Enable HLS protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("hls")]
    public bool? Hls { get; set; }

    /// <summary>Enable SmoothStreaming protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatusAtProviderEnvelopeEncryption
{
    /// <summary>The URL template for the custom service that delivers content keys to the end user. This is not required when using Azure Media Services for issuing keys. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("customKeysAcquisitionUrlTemplate")]
    public string? CustomKeysAcquisitionUrlTemplate { get; set; }

    /// <summary>A default_content_key block as defined above. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("defaultContentKey")]
    public IList<V1beta1StreamingPolicyStatusAtProviderEnvelopeEncryptionDefaultContentKey>? DefaultContentKey { get; set; }

    /// <summary>A enabled_protocols block as defined above. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("enabledProtocols")]
    public IList<V1beta1StreamingPolicyStatusAtProviderEnvelopeEncryptionEnabledProtocols>? EnabledProtocols { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatusAtProviderNoEncryptionEnabledProtocols
{
    /// <summary>Enable DASH protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("dash")]
    public bool? Dash { get; set; }

    /// <summary>Enable Download protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("download")]
    public bool? Download { get; set; }

    /// <summary>Enable HLS protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("hls")]
    public bool? Hls { get; set; }

    /// <summary>Enable SmoothStreaming protocol or not. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatusAtProvider
{
    /// <summary>A common_encryption_cbcs block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("commonEncryptionCbcs")]
    public IList<V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCbcs>? CommonEncryptionCbcs { get; set; }

    /// <summary>A common_encryption_cenc block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("commonEncryptionCenc")]
    public IList<V1beta1StreamingPolicyStatusAtProviderCommonEncryptionCenc>? CommonEncryptionCenc { get; set; }

    /// <summary>Default Content Key used by current Streaming Policy. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("defaultContentKeyPolicyName")]
    public string? DefaultContentKeyPolicyName { get; set; }

    /// <summary>A envelope_encryption block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("envelopeEncryption")]
    public IList<V1beta1StreamingPolicyStatusAtProviderEnvelopeEncryption>? EnvelopeEncryption { get; set; }

    /// <summary>The ID of the Streaming Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Media Services account name. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("mediaServicesAccountName")]
    public string? MediaServicesAccountName { get; set; }

    /// <summary>A no_encryption_enabled_protocols block as defined below. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("noEncryptionEnabledProtocols")]
    public IList<V1beta1StreamingPolicyStatusAtProviderNoEncryptionEnabledProtocols>? NoEncryptionEnabledProtocols { get; set; }

    /// <summary>The name of the Resource Group where the Streaming Policy should exist. Changing this forces a new Streaming Policy to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatusConditions
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

/// <summary>StreamingPolicyStatus defines the observed state of StreamingPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1StreamingPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StreamingPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>StreamingPolicy is the Schema for the StreamingPolicys API. Manages a Streaming Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StreamingPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StreamingPolicySpec>, IStatus<V1beta1StreamingPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StreamingPolicy";
    public const string KubeGroup = "media.azure.upbound.io";
    public const string KubePluralName = "streamingpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>StreamingPolicySpec defines the desired state of StreamingPolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1StreamingPolicySpec Spec { get; set; }

    /// <summary>StreamingPolicyStatus defines the observed state of StreamingPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1StreamingPolicyStatus? Status { get; set; }
}

/// <summary>StreamingPolicy is the Schema for the StreamingPolicys API. Manages a Streaming Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StreamingPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1StreamingPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StreamingPolicyList";
    public const string KubeGroup = "media.azure.upbound.io";
    public const string KubePluralName = "streamingpolicies";
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
    public IList<V1beta1StreamingPolicy> Items { get; set; }
}