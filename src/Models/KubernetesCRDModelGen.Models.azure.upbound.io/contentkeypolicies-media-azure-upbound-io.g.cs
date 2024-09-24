using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.media.azure.upbound.io;
public enum V1beta1ContentKeyPolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1ContentKeyPolicySpecForProviderMediaServicesAccountNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ContentKeyPolicySpecForProviderMediaServicesAccountNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ContentKeyPolicySpecForProviderMediaServicesAccountNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContentKeyPolicySpecForProviderMediaServicesAccountNameRefPolicyResolutionEnum>))]
    public V1beta1ContentKeyPolicySpecForProviderMediaServicesAccountNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContentKeyPolicySpecForProviderMediaServicesAccountNameRefPolicyResolveEnum>))]
    public V1beta1ContentKeyPolicySpecForProviderMediaServicesAccountNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServicesAccount in media to populate mediaServicesAccountName.</summary>
public partial class V1beta1ContentKeyPolicySpecForProviderMediaServicesAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContentKeyPolicySpecForProviderMediaServicesAccountNameRefPolicy? Policy { get; set; }
}

public enum V1beta1ContentKeyPolicySpecForProviderMediaServicesAccountNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ContentKeyPolicySpecForProviderMediaServicesAccountNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ContentKeyPolicySpecForProviderMediaServicesAccountNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContentKeyPolicySpecForProviderMediaServicesAccountNameSelectorPolicyResolutionEnum>))]
    public V1beta1ContentKeyPolicySpecForProviderMediaServicesAccountNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContentKeyPolicySpecForProviderMediaServicesAccountNameSelectorPolicyResolveEnum>))]
    public V1beta1ContentKeyPolicySpecForProviderMediaServicesAccountNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServicesAccount in media to populate mediaServicesAccountName.</summary>
public partial class V1beta1ContentKeyPolicySpecForProviderMediaServicesAccountNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContentKeyPolicySpecForProviderMediaServicesAccountNameSelectorPolicy? Policy { get; set; }
}

/// <summary>The key that must be used as FairPlay Application Secret key.</summary>
public partial class V1beta1ContentKeyPolicySpecForProviderPolicyOptionFairplayConfigurationAskSecretRef
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
public partial class V1beta1ContentKeyPolicySpecForProviderPolicyOptionFairplayConfigurationOfflineRentalConfiguration
{
    /// <summary>Playback duration.</summary>
    [JsonPropertyName("playbackDurationSeconds")]
    public double? PlaybackDurationSeconds { get; set; }

    /// <summary>Storage duration.</summary>
    [JsonPropertyName("storageDurationSeconds")]
    public double? StorageDurationSeconds { get; set; }
}

/// <summary>The password encrypting FairPlay certificate in PKCS 12 (pfx) format.</summary>
public partial class V1beta1ContentKeyPolicySpecForProviderPolicyOptionFairplayConfigurationPfxPasswordSecretRef
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

/// <summary>The Base64 representation of FairPlay certificate in PKCS 12 (pfx) format (including private key).</summary>
public partial class V1beta1ContentKeyPolicySpecForProviderPolicyOptionFairplayConfigurationPfxSecretRef
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
public partial class V1beta1ContentKeyPolicySpecForProviderPolicyOptionFairplayConfiguration
{
    /// <summary>The key that must be used as FairPlay Application Secret key.</summary>
    [JsonPropertyName("askSecretRef")]
    public V1beta1ContentKeyPolicySpecForProviderPolicyOptionFairplayConfigurationAskSecretRef? AskSecretRef { get; set; }

    /// <summary>A offline_rental_configuration block as defined below.</summary>
    [JsonPropertyName("offlineRentalConfiguration")]
    public IList<V1beta1ContentKeyPolicySpecForProviderPolicyOptionFairplayConfigurationOfflineRentalConfiguration>? OfflineRentalConfiguration { get; set; }

    /// <summary>The password encrypting FairPlay certificate in PKCS 12 (pfx) format.</summary>
    [JsonPropertyName("pfxPasswordSecretRef")]
    public V1beta1ContentKeyPolicySpecForProviderPolicyOptionFairplayConfigurationPfxPasswordSecretRef? PfxPasswordSecretRef { get; set; }

    /// <summary>The Base64 representation of FairPlay certificate in PKCS 12 (pfx) format (including private key).</summary>
    [JsonPropertyName("pfxSecretRef")]
    public V1beta1ContentKeyPolicySpecForProviderPolicyOptionFairplayConfigurationPfxSecretRef? PfxSecretRef { get; set; }

    /// <summary>The rental and lease key type. Supported values are DualExpiry, PersistentLimited, PersistentUnlimited or Undefined.</summary>
    [JsonPropertyName("rentalAndLeaseKeyType")]
    public string? RentalAndLeaseKeyType { get; set; }

    /// <summary>The rental duration. Must be greater than 0.</summary>
    [JsonPropertyName("rentalDurationSeconds")]
    public double? RentalDurationSeconds { get; set; }
}

/// <summary>The grace period of license.</summary>
public partial class V1beta1ContentKeyPolicySpecForProviderPolicyOptionPlayreadyConfigurationLicenseGracePeriodSecretRef
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
public partial class V1beta1ContentKeyPolicySpecForProviderPolicyOptionPlayreadyConfigurationLicensePlayRightExplicitAnalogTelevisionOutputRestriction
{
    /// <summary>Indicates whether this restriction is enforced on a best effort basis. Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("bestEffortEnforced")]
    public bool? BestEffortEnforced { get; set; }

    /// <summary>The restriction control bits. Possible value is integer between 0 and 3 inclusive.</summary>
    [JsonPropertyName("controlBits")]
    public double? ControlBits { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicySpecForProviderPolicyOptionPlayreadyConfigurationLicensePlayRight
{
    /// <summary>Configures Automatic Gain Control (AGC) and Color Stripe in the license. Must be between 0 and 3 inclusive.</summary>
    [JsonPropertyName("agcAndColorStripeRestriction")]
    public double? AgcAndColorStripeRestriction { get; set; }

    /// <summary>Configures Unknown output handling settings of the license. Supported values are Allowed, AllowedWithVideoConstriction or NotAllowed.</summary>
    [JsonPropertyName("allowPassingVideoContentToUnknownOutput")]
    public string? AllowPassingVideoContentToUnknownOutput { get; set; }

    /// <summary>Specifies the output protection level for compressed digital audio. Supported values are 100, 150 or 200.</summary>
    [JsonPropertyName("analogVideoOpl")]
    public double? AnalogVideoOpl { get; set; }

    /// <summary>Specifies the output protection level for compressed digital audio.Supported values are 100, 150, 200, 250 or 300.</summary>
    [JsonPropertyName("compressedDigitalAudioOpl")]
    public double? CompressedDigitalAudioOpl { get; set; }

    /// <summary>Specifies the output protection level for compressed digital video. Supported values are 400 or 500.</summary>
    [JsonPropertyName("compressedDigitalVideoOpl")]
    public double? CompressedDigitalVideoOpl { get; set; }

    /// <summary>Enables the Image Constraint For Analog Component Video Restriction in the license.</summary>
    [JsonPropertyName("digitalVideoOnlyContentRestriction")]
    public bool? DigitalVideoOnlyContentRestriction { get; set; }

    /// <summary>An explicit_analog_television_output_restriction block as defined above.</summary>
    [JsonPropertyName("explicitAnalogTelevisionOutputRestriction")]
    public IList<V1beta1ContentKeyPolicySpecForProviderPolicyOptionPlayreadyConfigurationLicensePlayRightExplicitAnalogTelevisionOutputRestriction>? ExplicitAnalogTelevisionOutputRestriction { get; set; }

    /// <summary>The amount of time that the license is valid after the license is first used to play content.</summary>
    [JsonPropertyName("firstPlayExpiration")]
    public string? FirstPlayExpiration { get; set; }

    /// <summary>Enables the Image Constraint For Analog Component Video Restriction in the license.</summary>
    [JsonPropertyName("imageConstraintForAnalogComponentVideoRestriction")]
    public bool? ImageConstraintForAnalogComponentVideoRestriction { get; set; }

    /// <summary>Enables the Image Constraint For Analog Component Video Restriction in the license.</summary>
    [JsonPropertyName("imageConstraintForAnalogComputerMonitorRestriction")]
    public bool? ImageConstraintForAnalogComputerMonitorRestriction { get; set; }

    /// <summary>Configures the Serial Copy Management System (SCMS) in the license. Must be between 0 and 3 inclusive.</summary>
    [JsonPropertyName("scmsRestriction")]
    public double? ScmsRestriction { get; set; }

    /// <summary>Specifies the output protection level for uncompressed digital audio. Supported values are 100, 150, 200, 250 or 300.</summary>
    [JsonPropertyName("uncompressedDigitalAudioOpl")]
    public double? UncompressedDigitalAudioOpl { get; set; }

    /// <summary>Specifies the output protection level for uncompressed digital video. Supported values are 100, 250, 270 or 300.</summary>
    [JsonPropertyName("uncompressedDigitalVideoOpl")]
    public double? UncompressedDigitalVideoOpl { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicySpecForProviderPolicyOptionPlayreadyConfigurationLicense
{
    /// <summary>A flag indicating whether test devices can use the license.</summary>
    [JsonPropertyName("allowTestDevices")]
    public bool? AllowTestDevices { get; set; }

    /// <summary>The begin date of license.</summary>
    [JsonPropertyName("beginDate")]
    public string? BeginDate { get; set; }

    /// <summary>Specifies that the content key ID is in the PlayReady header.</summary>
    [JsonPropertyName("contentKeyLocationFromHeaderEnabled")]
    public bool? ContentKeyLocationFromHeaderEnabled { get; set; }

    /// <summary>The content key ID. Specifies that the content key ID is specified in the PlayReady configuration.</summary>
    [JsonPropertyName("contentKeyLocationFromKeyId")]
    public string? ContentKeyLocationFromKeyId { get; set; }

    /// <summary>The PlayReady content type. Supported values are UltraVioletDownload, UltraVioletStreaming or Unspecified.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>The expiration date of license.</summary>
    [JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; set; }

    /// <summary>The grace period of license.</summary>
    [JsonPropertyName("gracePeriodSecretRef")]
    public V1beta1ContentKeyPolicySpecForProviderPolicyOptionPlayreadyConfigurationLicenseGracePeriodSecretRef? GracePeriodSecretRef { get; set; }

    /// <summary>The license type. Supported values are NonPersistent or Persistent.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>A play_right block as defined above.</summary>
    [JsonPropertyName("playRight")]
    public IList<V1beta1ContentKeyPolicySpecForProviderPolicyOptionPlayreadyConfigurationLicensePlayRight>? PlayRight { get; set; }

    /// <summary>The relative begin date of license.</summary>
    [JsonPropertyName("relativeBeginDate")]
    public string? RelativeBeginDate { get; set; }

    /// <summary>The relative expiration date of license.</summary>
    [JsonPropertyName("relativeExpirationDate")]
    public string? RelativeExpirationDate { get; set; }

    /// <summary>The security level of the PlayReady license. Possible values are SL150, SL2000 and SL3000. Please see this document for more information about security level. See this document for more information about SL3000 support.</summary>
    [JsonPropertyName("securityLevel")]
    public string? SecurityLevel { get; set; }
}

/// <summary>The RSA parameter exponent.</summary>
public partial class V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestrictionAlternateKeyRsaTokenKeyExponentSecretRef
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

/// <summary>The RSA parameter modulus.</summary>
public partial class V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestrictionAlternateKeyRsaTokenKeyModulusSecretRef
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

/// <summary>The key value of the key. Specifies a symmetric key for token validation.</summary>
public partial class V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestrictionAlternateKeySymmetricTokenKeySecretRef
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

/// <summary>The raw data field of a certificate in PKCS 12 format (X509Certificate2 in .NET). Specifies a certificate for token validation.</summary>
public partial class V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestrictionAlternateKeyX509TokenKeyRawSecretRef
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
public partial class V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestrictionAlternateKey
{
    /// <summary>The RSA parameter exponent.</summary>
    [JsonPropertyName("rsaTokenKeyExponentSecretRef")]
    public V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestrictionAlternateKeyRsaTokenKeyExponentSecretRef? RsaTokenKeyExponentSecretRef { get; set; }

    /// <summary>The RSA parameter modulus.</summary>
    [JsonPropertyName("rsaTokenKeyModulusSecretRef")]
    public V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestrictionAlternateKeyRsaTokenKeyModulusSecretRef? RsaTokenKeyModulusSecretRef { get; set; }

    /// <summary>The key value of the key. Specifies a symmetric key for token validation.</summary>
    [JsonPropertyName("symmetricTokenKeySecretRef")]
    public V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestrictionAlternateKeySymmetricTokenKeySecretRef? SymmetricTokenKeySecretRef { get; set; }

    /// <summary>The raw data field of a certificate in PKCS 12 format (X509Certificate2 in .NET). Specifies a certificate for token validation.</summary>
    [JsonPropertyName("x509TokenKeyRawSecretRef")]
    public V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestrictionAlternateKeyX509TokenKeyRawSecretRef? X509TokenKeyRawSecretRef { get; set; }
}

/// <summary>The RSA parameter exponent.</summary>
public partial class V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestrictionPrimaryRsaTokenKeyExponentSecretRef
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

/// <summary>The RSA parameter modulus.</summary>
public partial class V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestrictionPrimaryRsaTokenKeyModulusSecretRef
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

/// <summary>The key value of the key. Specifies a symmetric key for token validation.</summary>
public partial class V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestrictionPrimarySymmetricTokenKeySecretRef
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

/// <summary>The raw data field of a certificate in PKCS 12 format (X509Certificate2 in .NET). Specifies a certificate for token validation.</summary>
public partial class V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestrictionPrimaryX509TokenKeyRawSecretRef
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
public partial class V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestrictionRequiredClaim
{
    /// <summary>Token claim type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Token claim value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestriction
{
    /// <summary>One or more alternate_key block as defined above.</summary>
    [JsonPropertyName("alternateKey")]
    public IList<V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestrictionAlternateKey>? AlternateKey { get; set; }

    /// <summary>The audience for the token.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>The token issuer.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>The OpenID connect discovery document.</summary>
    [JsonPropertyName("openIdConnectDiscoveryDocument")]
    public string? OpenIdConnectDiscoveryDocument { get; set; }

    /// <summary>The RSA parameter exponent.</summary>
    [JsonPropertyName("primaryRsaTokenKeyExponentSecretRef")]
    public V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestrictionPrimaryRsaTokenKeyExponentSecretRef? PrimaryRsaTokenKeyExponentSecretRef { get; set; }

    /// <summary>The RSA parameter modulus.</summary>
    [JsonPropertyName("primaryRsaTokenKeyModulusSecretRef")]
    public V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestrictionPrimaryRsaTokenKeyModulusSecretRef? PrimaryRsaTokenKeyModulusSecretRef { get; set; }

    /// <summary>The key value of the key. Specifies a symmetric key for token validation.</summary>
    [JsonPropertyName("primarySymmetricTokenKeySecretRef")]
    public V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestrictionPrimarySymmetricTokenKeySecretRef? PrimarySymmetricTokenKeySecretRef { get; set; }

    /// <summary>The raw data field of a certificate in PKCS 12 format (X509Certificate2 in .NET). Specifies a certificate for token validation.</summary>
    [JsonPropertyName("primaryX509TokenKeyRawSecretRef")]
    public V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestrictionPrimaryX509TokenKeyRawSecretRef? PrimaryX509TokenKeyRawSecretRef { get; set; }

    /// <summary>One or more required_claim blocks as defined above.</summary>
    [JsonPropertyName("requiredClaim")]
    public IList<V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestrictionRequiredClaim>? RequiredClaim { get; set; }

    /// <summary>The type of token. Supported values are Jwt or Swt.</summary>
    [JsonPropertyName("tokenType")]
    public string? TokenType { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicySpecForProviderPolicyOption
{
    /// <summary>Enable a configuration for non-DRM keys.</summary>
    [JsonPropertyName("clearKeyConfigurationEnabled")]
    public bool? ClearKeyConfigurationEnabled { get; set; }

    /// <summary>A fairplay_configuration block as defined above. Check license requirements here https://docs.microsoft.com/azure/media-services/latest/fairplay-license-overview.</summary>
    [JsonPropertyName("fairplayConfiguration")]
    public IList<V1beta1ContentKeyPolicySpecForProviderPolicyOptionFairplayConfiguration>? FairplayConfiguration { get; set; }

    /// <summary>The name which should be used for this Policy Option.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Enable an open restriction. License or key will be delivered on every request.</summary>
    [JsonPropertyName("openRestrictionEnabled")]
    public bool? OpenRestrictionEnabled { get; set; }

    /// <summary>One or more playready_configuration_license blocks as defined above.</summary>
    [JsonPropertyName("playreadyConfigurationLicense")]
    public IList<V1beta1ContentKeyPolicySpecForProviderPolicyOptionPlayreadyConfigurationLicense>? PlayreadyConfigurationLicense { get; set; }

    /// <summary>The custom response data of the PlayReady configuration. This only applies when playready_configuration_license is specified.</summary>
    [JsonPropertyName("playreadyResponseCustomData")]
    public string? PlayreadyResponseCustomData { get; set; }

    /// <summary>A token_restriction block as defined below.</summary>
    [JsonPropertyName("tokenRestriction")]
    public IList<V1beta1ContentKeyPolicySpecForProviderPolicyOptionTokenRestriction>? TokenRestriction { get; set; }

    /// <summary>The Widevine template.</summary>
    [JsonPropertyName("widevineConfigurationTemplate")]
    public string? WidevineConfigurationTemplate { get; set; }
}

public enum V1beta1ContentKeyPolicySpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ContentKeyPolicySpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ContentKeyPolicySpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContentKeyPolicySpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1ContentKeyPolicySpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContentKeyPolicySpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1ContentKeyPolicySpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1ContentKeyPolicySpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContentKeyPolicySpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1ContentKeyPolicySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ContentKeyPolicySpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ContentKeyPolicySpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContentKeyPolicySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1ContentKeyPolicySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContentKeyPolicySpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1ContentKeyPolicySpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1ContentKeyPolicySpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContentKeyPolicySpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicySpecForProvider
{
    /// <summary>A description for the Policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Media Services account name. Changing this forces a new Content Key Policy to be created.</summary>
    [JsonPropertyName("mediaServicesAccountName")]
    public string? MediaServicesAccountName { get; set; }

    /// <summary>Reference to a ServicesAccount in media to populate mediaServicesAccountName.</summary>
    [JsonPropertyName("mediaServicesAccountNameRef")]
    public V1beta1ContentKeyPolicySpecForProviderMediaServicesAccountNameRef? MediaServicesAccountNameRef { get; set; }

    /// <summary>Selector for a ServicesAccount in media to populate mediaServicesAccountName.</summary>
    [JsonPropertyName("mediaServicesAccountNameSelector")]
    public V1beta1ContentKeyPolicySpecForProviderMediaServicesAccountNameSelector? MediaServicesAccountNameSelector { get; set; }

    /// <summary>One or more policy_option blocks as defined below.</summary>
    [JsonPropertyName("policyOption")]
    public IList<V1beta1ContentKeyPolicySpecForProviderPolicyOption>? PolicyOption { get; set; }

    /// <summary>The name of the Resource Group where the Content Key Policy should exist. Changing this forces a new Content Key Policy to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1ContentKeyPolicySpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1ContentKeyPolicySpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicySpecInitProviderPolicyOptionFairplayConfigurationOfflineRentalConfiguration
{
    /// <summary>Playback duration.</summary>
    [JsonPropertyName("playbackDurationSeconds")]
    public double? PlaybackDurationSeconds { get; set; }

    /// <summary>Storage duration.</summary>
    [JsonPropertyName("storageDurationSeconds")]
    public double? StorageDurationSeconds { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicySpecInitProviderPolicyOptionFairplayConfiguration
{
    /// <summary>A offline_rental_configuration block as defined below.</summary>
    [JsonPropertyName("offlineRentalConfiguration")]
    public IList<V1beta1ContentKeyPolicySpecInitProviderPolicyOptionFairplayConfigurationOfflineRentalConfiguration>? OfflineRentalConfiguration { get; set; }

    /// <summary>The rental and lease key type. Supported values are DualExpiry, PersistentLimited, PersistentUnlimited or Undefined.</summary>
    [JsonPropertyName("rentalAndLeaseKeyType")]
    public string? RentalAndLeaseKeyType { get; set; }

    /// <summary>The rental duration. Must be greater than 0.</summary>
    [JsonPropertyName("rentalDurationSeconds")]
    public double? RentalDurationSeconds { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicySpecInitProviderPolicyOptionPlayreadyConfigurationLicensePlayRightExplicitAnalogTelevisionOutputRestriction
{
    /// <summary>Indicates whether this restriction is enforced on a best effort basis. Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("bestEffortEnforced")]
    public bool? BestEffortEnforced { get; set; }

    /// <summary>The restriction control bits. Possible value is integer between 0 and 3 inclusive.</summary>
    [JsonPropertyName("controlBits")]
    public double? ControlBits { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicySpecInitProviderPolicyOptionPlayreadyConfigurationLicensePlayRight
{
    /// <summary>Configures Automatic Gain Control (AGC) and Color Stripe in the license. Must be between 0 and 3 inclusive.</summary>
    [JsonPropertyName("agcAndColorStripeRestriction")]
    public double? AgcAndColorStripeRestriction { get; set; }

    /// <summary>Configures Unknown output handling settings of the license. Supported values are Allowed, AllowedWithVideoConstriction or NotAllowed.</summary>
    [JsonPropertyName("allowPassingVideoContentToUnknownOutput")]
    public string? AllowPassingVideoContentToUnknownOutput { get; set; }

    /// <summary>Specifies the output protection level for compressed digital audio. Supported values are 100, 150 or 200.</summary>
    [JsonPropertyName("analogVideoOpl")]
    public double? AnalogVideoOpl { get; set; }

    /// <summary>Specifies the output protection level for compressed digital audio.Supported values are 100, 150, 200, 250 or 300.</summary>
    [JsonPropertyName("compressedDigitalAudioOpl")]
    public double? CompressedDigitalAudioOpl { get; set; }

    /// <summary>Specifies the output protection level for compressed digital video. Supported values are 400 or 500.</summary>
    [JsonPropertyName("compressedDigitalVideoOpl")]
    public double? CompressedDigitalVideoOpl { get; set; }

    /// <summary>Enables the Image Constraint For Analog Component Video Restriction in the license.</summary>
    [JsonPropertyName("digitalVideoOnlyContentRestriction")]
    public bool? DigitalVideoOnlyContentRestriction { get; set; }

    /// <summary>An explicit_analog_television_output_restriction block as defined above.</summary>
    [JsonPropertyName("explicitAnalogTelevisionOutputRestriction")]
    public IList<V1beta1ContentKeyPolicySpecInitProviderPolicyOptionPlayreadyConfigurationLicensePlayRightExplicitAnalogTelevisionOutputRestriction>? ExplicitAnalogTelevisionOutputRestriction { get; set; }

    /// <summary>The amount of time that the license is valid after the license is first used to play content.</summary>
    [JsonPropertyName("firstPlayExpiration")]
    public string? FirstPlayExpiration { get; set; }

    /// <summary>Enables the Image Constraint For Analog Component Video Restriction in the license.</summary>
    [JsonPropertyName("imageConstraintForAnalogComponentVideoRestriction")]
    public bool? ImageConstraintForAnalogComponentVideoRestriction { get; set; }

    /// <summary>Enables the Image Constraint For Analog Component Video Restriction in the license.</summary>
    [JsonPropertyName("imageConstraintForAnalogComputerMonitorRestriction")]
    public bool? ImageConstraintForAnalogComputerMonitorRestriction { get; set; }

    /// <summary>Configures the Serial Copy Management System (SCMS) in the license. Must be between 0 and 3 inclusive.</summary>
    [JsonPropertyName("scmsRestriction")]
    public double? ScmsRestriction { get; set; }

    /// <summary>Specifies the output protection level for uncompressed digital audio. Supported values are 100, 150, 200, 250 or 300.</summary>
    [JsonPropertyName("uncompressedDigitalAudioOpl")]
    public double? UncompressedDigitalAudioOpl { get; set; }

    /// <summary>Specifies the output protection level for uncompressed digital video. Supported values are 100, 250, 270 or 300.</summary>
    [JsonPropertyName("uncompressedDigitalVideoOpl")]
    public double? UncompressedDigitalVideoOpl { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicySpecInitProviderPolicyOptionPlayreadyConfigurationLicense
{
    /// <summary>A flag indicating whether test devices can use the license.</summary>
    [JsonPropertyName("allowTestDevices")]
    public bool? AllowTestDevices { get; set; }

    /// <summary>The begin date of license.</summary>
    [JsonPropertyName("beginDate")]
    public string? BeginDate { get; set; }

    /// <summary>Specifies that the content key ID is in the PlayReady header.</summary>
    [JsonPropertyName("contentKeyLocationFromHeaderEnabled")]
    public bool? ContentKeyLocationFromHeaderEnabled { get; set; }

    /// <summary>The content key ID. Specifies that the content key ID is specified in the PlayReady configuration.</summary>
    [JsonPropertyName("contentKeyLocationFromKeyId")]
    public string? ContentKeyLocationFromKeyId { get; set; }

    /// <summary>The PlayReady content type. Supported values are UltraVioletDownload, UltraVioletStreaming or Unspecified.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>The expiration date of license.</summary>
    [JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; set; }

    /// <summary>The license type. Supported values are NonPersistent or Persistent.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>A play_right block as defined above.</summary>
    [JsonPropertyName("playRight")]
    public IList<V1beta1ContentKeyPolicySpecInitProviderPolicyOptionPlayreadyConfigurationLicensePlayRight>? PlayRight { get; set; }

    /// <summary>The relative begin date of license.</summary>
    [JsonPropertyName("relativeBeginDate")]
    public string? RelativeBeginDate { get; set; }

    /// <summary>The relative expiration date of license.</summary>
    [JsonPropertyName("relativeExpirationDate")]
    public string? RelativeExpirationDate { get; set; }

    /// <summary>The security level of the PlayReady license. Possible values are SL150, SL2000 and SL3000. Please see this document for more information about security level. See this document for more information about SL3000 support.</summary>
    [JsonPropertyName("securityLevel")]
    public string? SecurityLevel { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicySpecInitProviderPolicyOptionTokenRestrictionAlternateKey
{
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicySpecInitProviderPolicyOptionTokenRestrictionRequiredClaim
{
    /// <summary>Token claim type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Token claim value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicySpecInitProviderPolicyOptionTokenRestriction
{
    /// <summary>One or more alternate_key block as defined above.</summary>
    [JsonPropertyName("alternateKey")]
    public IList<V1beta1ContentKeyPolicySpecInitProviderPolicyOptionTokenRestrictionAlternateKey>? AlternateKey { get; set; }

    /// <summary>The audience for the token.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>The token issuer.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>The OpenID connect discovery document.</summary>
    [JsonPropertyName("openIdConnectDiscoveryDocument")]
    public string? OpenIdConnectDiscoveryDocument { get; set; }

    /// <summary>One or more required_claim blocks as defined above.</summary>
    [JsonPropertyName("requiredClaim")]
    public IList<V1beta1ContentKeyPolicySpecInitProviderPolicyOptionTokenRestrictionRequiredClaim>? RequiredClaim { get; set; }

    /// <summary>The type of token. Supported values are Jwt or Swt.</summary>
    [JsonPropertyName("tokenType")]
    public string? TokenType { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicySpecInitProviderPolicyOption
{
    /// <summary>Enable a configuration for non-DRM keys.</summary>
    [JsonPropertyName("clearKeyConfigurationEnabled")]
    public bool? ClearKeyConfigurationEnabled { get; set; }

    /// <summary>A fairplay_configuration block as defined above. Check license requirements here https://docs.microsoft.com/azure/media-services/latest/fairplay-license-overview.</summary>
    [JsonPropertyName("fairplayConfiguration")]
    public IList<V1beta1ContentKeyPolicySpecInitProviderPolicyOptionFairplayConfiguration>? FairplayConfiguration { get; set; }

    /// <summary>The name which should be used for this Policy Option.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Enable an open restriction. License or key will be delivered on every request.</summary>
    [JsonPropertyName("openRestrictionEnabled")]
    public bool? OpenRestrictionEnabled { get; set; }

    /// <summary>One or more playready_configuration_license blocks as defined above.</summary>
    [JsonPropertyName("playreadyConfigurationLicense")]
    public IList<V1beta1ContentKeyPolicySpecInitProviderPolicyOptionPlayreadyConfigurationLicense>? PlayreadyConfigurationLicense { get; set; }

    /// <summary>The custom response data of the PlayReady configuration. This only applies when playready_configuration_license is specified.</summary>
    [JsonPropertyName("playreadyResponseCustomData")]
    public string? PlayreadyResponseCustomData { get; set; }

    /// <summary>A token_restriction block as defined below.</summary>
    [JsonPropertyName("tokenRestriction")]
    public IList<V1beta1ContentKeyPolicySpecInitProviderPolicyOptionTokenRestriction>? TokenRestriction { get; set; }

    /// <summary>The Widevine template.</summary>
    [JsonPropertyName("widevineConfigurationTemplate")]
    public string? WidevineConfigurationTemplate { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1ContentKeyPolicySpecInitProvider
{
    /// <summary>A description for the Policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more policy_option blocks as defined below.</summary>
    [JsonPropertyName("policyOption")]
    public IList<V1beta1ContentKeyPolicySpecInitProviderPolicyOption>? PolicyOption { get; set; }
}

public enum V1beta1ContentKeyPolicySpecManagementPoliciesEnum
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

public enum V1beta1ContentKeyPolicySpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ContentKeyPolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ContentKeyPolicySpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContentKeyPolicySpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ContentKeyPolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContentKeyPolicySpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ContentKeyPolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1ContentKeyPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContentKeyPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1ContentKeyPolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ContentKeyPolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ContentKeyPolicySpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContentKeyPolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ContentKeyPolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContentKeyPolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ContentKeyPolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1ContentKeyPolicySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContentKeyPolicySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1ContentKeyPolicySpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ContentKeyPolicySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ContentKeyPolicySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ContentKeyPolicySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1ContentKeyPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ContentKeyPolicySpec defines the desired state of ContentKeyPolicy</summary>
public partial class V1beta1ContentKeyPolicySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContentKeyPolicySpecDeletionPolicyEnum>))]
    public V1beta1ContentKeyPolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ContentKeyPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ContentKeyPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ContentKeyPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ContentKeyPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ContentKeyPolicySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ContentKeyPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionFairplayConfigurationOfflineRentalConfiguration
{
    /// <summary>Playback duration.</summary>
    [JsonPropertyName("playbackDurationSeconds")]
    public double? PlaybackDurationSeconds { get; set; }

    /// <summary>Storage duration.</summary>
    [JsonPropertyName("storageDurationSeconds")]
    public double? StorageDurationSeconds { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionFairplayConfiguration
{
    /// <summary>A offline_rental_configuration block as defined below.</summary>
    [JsonPropertyName("offlineRentalConfiguration")]
    public IList<V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionFairplayConfigurationOfflineRentalConfiguration>? OfflineRentalConfiguration { get; set; }

    /// <summary>The rental and lease key type. Supported values are DualExpiry, PersistentLimited, PersistentUnlimited or Undefined.</summary>
    [JsonPropertyName("rentalAndLeaseKeyType")]
    public string? RentalAndLeaseKeyType { get; set; }

    /// <summary>The rental duration. Must be greater than 0.</summary>
    [JsonPropertyName("rentalDurationSeconds")]
    public double? RentalDurationSeconds { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionPlayreadyConfigurationLicensePlayRightExplicitAnalogTelevisionOutputRestriction
{
    /// <summary>Indicates whether this restriction is enforced on a best effort basis. Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("bestEffortEnforced")]
    public bool? BestEffortEnforced { get; set; }

    /// <summary>The restriction control bits. Possible value is integer between 0 and 3 inclusive.</summary>
    [JsonPropertyName("controlBits")]
    public double? ControlBits { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionPlayreadyConfigurationLicensePlayRight
{
    /// <summary>Configures Automatic Gain Control (AGC) and Color Stripe in the license. Must be between 0 and 3 inclusive.</summary>
    [JsonPropertyName("agcAndColorStripeRestriction")]
    public double? AgcAndColorStripeRestriction { get; set; }

    /// <summary>Configures Unknown output handling settings of the license. Supported values are Allowed, AllowedWithVideoConstriction or NotAllowed.</summary>
    [JsonPropertyName("allowPassingVideoContentToUnknownOutput")]
    public string? AllowPassingVideoContentToUnknownOutput { get; set; }

    /// <summary>Specifies the output protection level for compressed digital audio. Supported values are 100, 150 or 200.</summary>
    [JsonPropertyName("analogVideoOpl")]
    public double? AnalogVideoOpl { get; set; }

    /// <summary>Specifies the output protection level for compressed digital audio.Supported values are 100, 150, 200, 250 or 300.</summary>
    [JsonPropertyName("compressedDigitalAudioOpl")]
    public double? CompressedDigitalAudioOpl { get; set; }

    /// <summary>Specifies the output protection level for compressed digital video. Supported values are 400 or 500.</summary>
    [JsonPropertyName("compressedDigitalVideoOpl")]
    public double? CompressedDigitalVideoOpl { get; set; }

    /// <summary>Enables the Image Constraint For Analog Component Video Restriction in the license.</summary>
    [JsonPropertyName("digitalVideoOnlyContentRestriction")]
    public bool? DigitalVideoOnlyContentRestriction { get; set; }

    /// <summary>An explicit_analog_television_output_restriction block as defined above.</summary>
    [JsonPropertyName("explicitAnalogTelevisionOutputRestriction")]
    public IList<V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionPlayreadyConfigurationLicensePlayRightExplicitAnalogTelevisionOutputRestriction>? ExplicitAnalogTelevisionOutputRestriction { get; set; }

    /// <summary>The amount of time that the license is valid after the license is first used to play content.</summary>
    [JsonPropertyName("firstPlayExpiration")]
    public string? FirstPlayExpiration { get; set; }

    /// <summary>Enables the Image Constraint For Analog Component Video Restriction in the license.</summary>
    [JsonPropertyName("imageConstraintForAnalogComponentVideoRestriction")]
    public bool? ImageConstraintForAnalogComponentVideoRestriction { get; set; }

    /// <summary>Enables the Image Constraint For Analog Component Video Restriction in the license.</summary>
    [JsonPropertyName("imageConstraintForAnalogComputerMonitorRestriction")]
    public bool? ImageConstraintForAnalogComputerMonitorRestriction { get; set; }

    /// <summary>Configures the Serial Copy Management System (SCMS) in the license. Must be between 0 and 3 inclusive.</summary>
    [JsonPropertyName("scmsRestriction")]
    public double? ScmsRestriction { get; set; }

    /// <summary>Specifies the output protection level for uncompressed digital audio. Supported values are 100, 150, 200, 250 or 300.</summary>
    [JsonPropertyName("uncompressedDigitalAudioOpl")]
    public double? UncompressedDigitalAudioOpl { get; set; }

    /// <summary>Specifies the output protection level for uncompressed digital video. Supported values are 100, 250, 270 or 300.</summary>
    [JsonPropertyName("uncompressedDigitalVideoOpl")]
    public double? UncompressedDigitalVideoOpl { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionPlayreadyConfigurationLicense
{
    /// <summary>A flag indicating whether test devices can use the license.</summary>
    [JsonPropertyName("allowTestDevices")]
    public bool? AllowTestDevices { get; set; }

    /// <summary>The begin date of license.</summary>
    [JsonPropertyName("beginDate")]
    public string? BeginDate { get; set; }

    /// <summary>Specifies that the content key ID is in the PlayReady header.</summary>
    [JsonPropertyName("contentKeyLocationFromHeaderEnabled")]
    public bool? ContentKeyLocationFromHeaderEnabled { get; set; }

    /// <summary>The content key ID. Specifies that the content key ID is specified in the PlayReady configuration.</summary>
    [JsonPropertyName("contentKeyLocationFromKeyId")]
    public string? ContentKeyLocationFromKeyId { get; set; }

    /// <summary>The PlayReady content type. Supported values are UltraVioletDownload, UltraVioletStreaming or Unspecified.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>The expiration date of license.</summary>
    [JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; set; }

    /// <summary>The license type. Supported values are NonPersistent or Persistent.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>A play_right block as defined above.</summary>
    [JsonPropertyName("playRight")]
    public IList<V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionPlayreadyConfigurationLicensePlayRight>? PlayRight { get; set; }

    /// <summary>The relative begin date of license.</summary>
    [JsonPropertyName("relativeBeginDate")]
    public string? RelativeBeginDate { get; set; }

    /// <summary>The relative expiration date of license.</summary>
    [JsonPropertyName("relativeExpirationDate")]
    public string? RelativeExpirationDate { get; set; }

    /// <summary>The security level of the PlayReady license. Possible values are SL150, SL2000 and SL3000. Please see this document for more information about security level. See this document for more information about SL3000 support.</summary>
    [JsonPropertyName("securityLevel")]
    public string? SecurityLevel { get; set; }
}

/// <summary>The RSA parameter exponent.</summary>
public partial class V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionTokenRestrictionAlternateKeyRsaTokenKeyExponentSecretRef
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

/// <summary>The RSA parameter modulus.</summary>
public partial class V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionTokenRestrictionAlternateKeyRsaTokenKeyModulusSecretRef
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

/// <summary>The key value of the key. Specifies a symmetric key for token validation.</summary>
public partial class V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionTokenRestrictionAlternateKeySymmetricTokenKeySecretRef
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

/// <summary>The raw data field of a certificate in PKCS 12 format (X509Certificate2 in .NET). Specifies a certificate for token validation.</summary>
public partial class V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionTokenRestrictionAlternateKeyX509TokenKeyRawSecretRef
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
public partial class V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionTokenRestrictionAlternateKey
{
    /// <summary>The RSA parameter exponent.</summary>
    [JsonPropertyName("rsaTokenKeyExponentSecretRef")]
    public V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionTokenRestrictionAlternateKeyRsaTokenKeyExponentSecretRef? RsaTokenKeyExponentSecretRef { get; set; }

    /// <summary>The RSA parameter modulus.</summary>
    [JsonPropertyName("rsaTokenKeyModulusSecretRef")]
    public V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionTokenRestrictionAlternateKeyRsaTokenKeyModulusSecretRef? RsaTokenKeyModulusSecretRef { get; set; }

    /// <summary>The key value of the key. Specifies a symmetric key for token validation.</summary>
    [JsonPropertyName("symmetricTokenKeySecretRef")]
    public V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionTokenRestrictionAlternateKeySymmetricTokenKeySecretRef? SymmetricTokenKeySecretRef { get; set; }

    /// <summary>The raw data field of a certificate in PKCS 12 format (X509Certificate2 in .NET). Specifies a certificate for token validation.</summary>
    [JsonPropertyName("x509TokenKeyRawSecretRef")]
    public V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionTokenRestrictionAlternateKeyX509TokenKeyRawSecretRef? X509TokenKeyRawSecretRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionTokenRestrictionRequiredClaim
{
    /// <summary>Token claim type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Token claim value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionTokenRestriction
{
    /// <summary>One or more alternate_key block as defined above.</summary>
    [JsonPropertyName("alternateKey")]
    public IList<V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionTokenRestrictionAlternateKey>? AlternateKey { get; set; }

    /// <summary>The audience for the token.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>The token issuer.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>The OpenID connect discovery document.</summary>
    [JsonPropertyName("openIdConnectDiscoveryDocument")]
    public string? OpenIdConnectDiscoveryDocument { get; set; }

    /// <summary>One or more required_claim blocks as defined above.</summary>
    [JsonPropertyName("requiredClaim")]
    public IList<V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionTokenRestrictionRequiredClaim>? RequiredClaim { get; set; }

    /// <summary>The type of token. Supported values are Jwt or Swt.</summary>
    [JsonPropertyName("tokenType")]
    public string? TokenType { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicyStatusAtProviderPolicyOption
{
    /// <summary>Enable a configuration for non-DRM keys.</summary>
    [JsonPropertyName("clearKeyConfigurationEnabled")]
    public bool? ClearKeyConfigurationEnabled { get; set; }

    /// <summary>A fairplay_configuration block as defined above. Check license requirements here https://docs.microsoft.com/azure/media-services/latest/fairplay-license-overview.</summary>
    [JsonPropertyName("fairplayConfiguration")]
    public IList<V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionFairplayConfiguration>? FairplayConfiguration { get; set; }

    /// <summary>The name which should be used for this Policy Option.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Enable an open restriction. License or key will be delivered on every request.</summary>
    [JsonPropertyName("openRestrictionEnabled")]
    public bool? OpenRestrictionEnabled { get; set; }

    /// <summary>One or more playready_configuration_license blocks as defined above.</summary>
    [JsonPropertyName("playreadyConfigurationLicense")]
    public IList<V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionPlayreadyConfigurationLicense>? PlayreadyConfigurationLicense { get; set; }

    /// <summary>The custom response data of the PlayReady configuration. This only applies when playready_configuration_license is specified.</summary>
    [JsonPropertyName("playreadyResponseCustomData")]
    public string? PlayreadyResponseCustomData { get; set; }

    /// <summary>A token_restriction block as defined below.</summary>
    [JsonPropertyName("tokenRestriction")]
    public IList<V1beta1ContentKeyPolicyStatusAtProviderPolicyOptionTokenRestriction>? TokenRestriction { get; set; }

    /// <summary>The Widevine template.</summary>
    [JsonPropertyName("widevineConfigurationTemplate")]
    public string? WidevineConfigurationTemplate { get; set; }
}

/// <summary></summary>
public partial class V1beta1ContentKeyPolicyStatusAtProvider
{
    /// <summary>A description for the Policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of the Content Key Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Media Services account name. Changing this forces a new Content Key Policy to be created.</summary>
    [JsonPropertyName("mediaServicesAccountName")]
    public string? MediaServicesAccountName { get; set; }

    /// <summary>One or more policy_option blocks as defined below.</summary>
    [JsonPropertyName("policyOption")]
    public IList<V1beta1ContentKeyPolicyStatusAtProviderPolicyOption>? PolicyOption { get; set; }

    /// <summary>The name of the Resource Group where the Content Key Policy should exist. Changing this forces a new Content Key Policy to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1ContentKeyPolicyStatusConditions
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

/// <summary>ContentKeyPolicyStatus defines the observed state of ContentKeyPolicy.</summary>
public partial class V1beta1ContentKeyPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ContentKeyPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ContentKeyPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>ContentKeyPolicy is the Schema for the ContentKeyPolicys API. Manages a Content Key Policy.</summary>
public partial class V1beta1ContentKeyPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ContentKeyPolicySpec>, IStatus<V1beta1ContentKeyPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ContentKeyPolicy";
    public const string KubeGroup = "media.azure.upbound.io";
    public const string KubePluralName = "contentkeypolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ContentKeyPolicySpec defines the desired state of ContentKeyPolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1ContentKeyPolicySpec Spec { get; set; }

    /// <summary>ContentKeyPolicyStatus defines the observed state of ContentKeyPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1ContentKeyPolicyStatus? Status { get; set; }
}