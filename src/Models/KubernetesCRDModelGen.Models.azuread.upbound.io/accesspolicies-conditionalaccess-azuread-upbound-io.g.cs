using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.conditionalaccess.azuread.upbound.io;
public enum V1beta1AccessPolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecForProviderConditionsApplications
{
    /// <summary>A list of application IDs explicitly excluded from the policy. Can also be set to Office365.</summary>
    [JsonPropertyName("excludedApplications")]
    public IList<string>? ExcludedApplications { get; set; }

    /// <summary>A list of application IDs the policy applies to, unless explicitly excluded (in excluded_applications). Can also be set to All, None or Office365. Cannot be specified with included_user_actions. One of included_applications or included_user_actions must be specified.</summary>
    [JsonPropertyName("includedApplications")]
    public IList<string>? IncludedApplications { get; set; }

    /// <summary>A list of user actions to include. Supported values are urn:user:registerdevice and urn:user:registersecurityinfo. Cannot be specified with included_applications. One of included_applications or included_user_actions must be specified.</summary>
    [JsonPropertyName("includedUserActions")]
    public IList<string>? IncludedUserActions { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecForProviderConditionsClientApplications
{
    /// <summary>A list of service principal IDs explicitly excluded in the policy.</summary>
    [JsonPropertyName("excludedServicePrincipals")]
    public IList<string>? ExcludedServicePrincipals { get; set; }

    /// <summary>A list of service principal IDs explicitly included in the policy. Can be set to ServicePrincipalsInMyTenant to include all service principals. This is mandatory value when at least one excluded_service_principals is set.</summary>
    [JsonPropertyName("includedServicePrincipals")]
    public IList<string>? IncludedServicePrincipals { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecForProviderConditionsDevicesFilter
{
    /// <summary>Whether to include in, or exclude from, matching devices from the policy. Supported values are include or exclude.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Condition filter to match devices. For more information, see official documentation.</summary>
    [JsonPropertyName("rule")]
    public string? Rule { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecForProviderConditionsDevices
{
    /// <summary>A filter block as described below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1AccessPolicySpecForProviderConditionsDevicesFilter>? Filter { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecForProviderConditionsLocations
{
    /// <summary>A list of location IDs excluded from scope of policy. Can also be set to AllTrusted.</summary>
    [JsonPropertyName("excludedLocations")]
    public IList<string>? ExcludedLocations { get; set; }

    /// <summary>A list of location IDs in scope of policy unless explicitly excluded. Can also be set to All, or AllTrusted.</summary>
    [JsonPropertyName("includedLocations")]
    public IList<string>? IncludedLocations { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecForProviderConditionsPlatforms
{
    /// <summary>A list of platforms explicitly excluded from the policy. Possible values are: all, android, iOS, linux, macOS, windows, windowsPhone or unknownFutureValue.</summary>
    [JsonPropertyName("excludedPlatforms")]
    public IList<string>? ExcludedPlatforms { get; set; }

    /// <summary>A list of platforms the policy applies to, unless explicitly excluded. Possible values are: all, android, iOS, linux, macOS, windows, windowsPhone or unknownFutureValue.</summary>
    [JsonPropertyName("includedPlatforms")]
    public IList<string>? IncludedPlatforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecForProviderConditionsUsersExcludedGuestsOrExternalUsersExternalTenants
{
    /// <summary>A list tenant IDs. Can only be specified if membership_kind is enumerated.</summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>The external tenant membership kind. Possible values are: all, enumerated, unknownFutureValue.</summary>
    [JsonPropertyName("membershipKind")]
    public string? MembershipKind { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecForProviderConditionsUsersExcludedGuestsOrExternalUsers
{
    /// <summary>An external_tenants block as documented below, which specifies external tenants in a policy scope.</summary>
    [JsonPropertyName("externalTenants")]
    public IList<V1beta1AccessPolicySpecForProviderConditionsUsersExcludedGuestsOrExternalUsersExternalTenants>? ExternalTenants { get; set; }

    /// <summary>A list of guest or external user types. Possible values are: b2bCollaborationGuest, b2bCollaborationMember, b2bDirectConnectUser, internalGuest, none, otherExternalUser, serviceProvider, unknownFutureValue.</summary>
    [JsonPropertyName("guestOrExternalUserTypes")]
    public IList<string>? GuestOrExternalUserTypes { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecForProviderConditionsUsersIncludedGuestsOrExternalUsersExternalTenants
{
    /// <summary>A list tenant IDs. Can only be specified if membership_kind is enumerated.</summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>The external tenant membership kind. Possible values are: all, enumerated, unknownFutureValue.</summary>
    [JsonPropertyName("membershipKind")]
    public string? MembershipKind { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecForProviderConditionsUsersIncludedGuestsOrExternalUsers
{
    /// <summary>An external_tenants block as documented below, which specifies external tenants in a policy scope.</summary>
    [JsonPropertyName("externalTenants")]
    public IList<V1beta1AccessPolicySpecForProviderConditionsUsersIncludedGuestsOrExternalUsersExternalTenants>? ExternalTenants { get; set; }

    /// <summary>A list of guest or external user types. Possible values are: b2bCollaborationGuest, b2bCollaborationMember, b2bDirectConnectUser, internalGuest, none, otherExternalUser, serviceProvider, unknownFutureValue.</summary>
    [JsonPropertyName("guestOrExternalUserTypes")]
    public IList<string>? GuestOrExternalUserTypes { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecForProviderConditionsUsers
{
    /// <summary>A list of group IDs excluded from scope of policy.</summary>
    [JsonPropertyName("excludedGroups")]
    public IList<string>? ExcludedGroups { get; set; }

    /// <summary>A guests_or_external_users block as documented below, which specifies internal guests and external users excluded from scope of policy.</summary>
    [JsonPropertyName("excludedGuestsOrExternalUsers")]
    public IList<V1beta1AccessPolicySpecForProviderConditionsUsersExcludedGuestsOrExternalUsers>? ExcludedGuestsOrExternalUsers { get; set; }

    /// <summary>A list of role IDs excluded from scope of policy.</summary>
    [JsonPropertyName("excludedRoles")]
    public IList<string>? ExcludedRoles { get; set; }

    /// <summary>A list of user IDs excluded from scope of policy and/or GuestsOrExternalUsers.</summary>
    [JsonPropertyName("excludedUsers")]
    public IList<string>? ExcludedUsers { get; set; }

    /// <summary>A list of group IDs in scope of policy unless explicitly excluded.</summary>
    [JsonPropertyName("includedGroups")]
    public IList<string>? IncludedGroups { get; set; }

    /// <summary>A guests_or_external_users block as documented below, which specifies internal guests and external users in scope of policy.</summary>
    [JsonPropertyName("includedGuestsOrExternalUsers")]
    public IList<V1beta1AccessPolicySpecForProviderConditionsUsersIncludedGuestsOrExternalUsers>? IncludedGuestsOrExternalUsers { get; set; }

    /// <summary>A list of role IDs in scope of policy unless explicitly excluded.</summary>
    [JsonPropertyName("includedRoles")]
    public IList<string>? IncludedRoles { get; set; }

    /// <summary>A list of user IDs in scope of policy unless explicitly excluded, or None or All or GuestsOrExternalUsers.</summary>
    [JsonPropertyName("includedUsers")]
    public IList<string>? IncludedUsers { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecForProviderConditions
{
    /// <summary>An applications block as documented below, which specifies applications and user actions included in and excluded from the policy.</summary>
    [JsonPropertyName("applications")]
    public IList<V1beta1AccessPolicySpecForProviderConditionsApplications>? Applications { get; set; }

    /// <summary>A list of client application types included in the policy. Possible values are: all, browser, mobileAppsAndDesktopClients, exchangeActiveSync, easSupported and other.</summary>
    [JsonPropertyName("clientAppTypes")]
    public IList<string>? ClientAppTypes { get; set; }

    /// <summary>An client_applications block as documented below, which specifies service principals included in and excluded from the policy.</summary>
    [JsonPropertyName("clientApplications")]
    public IList<V1beta1AccessPolicySpecForProviderConditionsClientApplications>? ClientApplications { get; set; }

    /// <summary>A devices block as documented below, which describes devices to be included in and excluded from the policy. A devices block can be added to an existing policy, but removing the devices block forces a new resource to be created.</summary>
    [JsonPropertyName("devices")]
    public IList<V1beta1AccessPolicySpecForProviderConditionsDevices>? Devices { get; set; }

    /// <summary>A locations block as documented below, which specifies locations included in and excluded from the policy.</summary>
    [JsonPropertyName("locations")]
    public IList<V1beta1AccessPolicySpecForProviderConditionsLocations>? Locations { get; set; }

    /// <summary>A platforms block as documented below, which specifies platforms included in and excluded from the policy.</summary>
    [JsonPropertyName("platforms")]
    public IList<V1beta1AccessPolicySpecForProviderConditionsPlatforms>? Platforms { get; set; }

    /// <summary>A list of service principal sign-in risk levels included in the policy. Possible values are: low, medium, high, none, unknownFutureValue.</summary>
    [JsonPropertyName("servicePrincipalRiskLevels")]
    public IList<string>? ServicePrincipalRiskLevels { get; set; }

    /// <summary>A list of user sign-in risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue.</summary>
    [JsonPropertyName("signInRiskLevels")]
    public IList<string>? SignInRiskLevels { get; set; }

    /// <summary>A list of user risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue.</summary>
    [JsonPropertyName("userRiskLevels")]
    public IList<string>? UserRiskLevels { get; set; }

    /// <summary>A users block as documented below, which specifies users, groups, and roles included in and excluded from the policy.</summary>
    [JsonPropertyName("users")]
    public IList<V1beta1AccessPolicySpecForProviderConditionsUsers>? Users { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecForProviderGrantControls
{
    /// <summary>ID of an Authentication Strength Policy to use in this policy.</summary>
    [JsonPropertyName("authenticationStrengthPolicyId")]
    public string? AuthenticationStrengthPolicyId { get; set; }

    /// <summary>List of built-in controls required by the policy. Possible values are: block, mfa, approvedApplication, compliantApplication, compliantDevice, domainJoinedDevice, passwordChange or unknownFutureValue.</summary>
    [JsonPropertyName("builtInControls")]
    public IList<string>? BuiltInControls { get; set; }

    /// <summary>List of custom controls IDs required by the policy.</summary>
    [JsonPropertyName("customAuthenticationFactors")]
    public IList<string>? CustomAuthenticationFactors { get; set; }

    /// <summary>Defines the relationship of the grant controls. Possible values are: AND, OR.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>List of terms of use IDs required by the policy.</summary>
    [JsonPropertyName("termsOfUse")]
    public IList<string>? TermsOfUse { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecForProviderSessionControls
{
    /// <summary>Whether application enforced restrictions are enabled. Defaults to false.</summary>
    [JsonPropertyName("applicationEnforcedRestrictionsEnabled")]
    public bool? ApplicationEnforcedRestrictionsEnabled { get; set; }

    /// <summary>Enables cloud app security and specifies the cloud app security policy to use. Possible values are: blockDownloads, mcasConfigured, monitorOnly or unknownFutureValue.</summary>
    [JsonPropertyName("cloudAppSecurityPolicy")]
    public string? CloudAppSecurityPolicy { get; set; }

    /// <summary>Disables resilience defaults. Defaults to false.</summary>
    [JsonPropertyName("disableResilienceDefaults")]
    public bool? DisableResilienceDefaults { get; set; }

    /// <summary>Session control to define whether to persist cookies. Possible values are: always or never.</summary>
    [JsonPropertyName("persistentBrowserMode")]
    public string? PersistentBrowserMode { get; set; }

    /// <summary>Number of days or hours to enforce sign-in frequency. Required when sign_in_frequency_period is specified.</summary>
    [JsonPropertyName("signInFrequency")]
    public double? SignInFrequency { get; set; }

    /// <summary>Authentication type for enforcing sign-in frequency. Possible values are: primaryAndSecondaryAuthentication or secondaryAuthentication. Defaults to primaryAndSecondaryAuthentication.</summary>
    [JsonPropertyName("signInFrequencyAuthenticationType")]
    public string? SignInFrequencyAuthenticationType { get; set; }

    /// <summary>The interval to apply to sign-in frequency control. Possible values are: timeBased or everyTime. Defaults to timeBased.</summary>
    [JsonPropertyName("signInFrequencyInterval")]
    public string? SignInFrequencyInterval { get; set; }

    /// <summary>The time period to enforce sign-in frequency. Possible values are: hours or days. Required when sign_in_frequency_period is specified.</summary>
    [JsonPropertyName("signInFrequencyPeriod")]
    public string? SignInFrequencyPeriod { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecForProvider
{
    /// <summary>A conditions block as documented below, which specifies the rules that must be met for the policy to apply.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccessPolicySpecForProviderConditions>? Conditions { get; set; }

    /// <summary>The friendly name for this Conditional Access Policy.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A grant_controls block as documented below, which specifies the grant controls that must be fulfilled to pass the policy.</summary>
    [JsonPropertyName("grantControls")]
    public IList<V1beta1AccessPolicySpecForProviderGrantControls>? GrantControls { get; set; }

    /// <summary>A session_controls block as documented below, which specifies the session controls that are enforced after sign-in.</summary>
    [JsonPropertyName("sessionControls")]
    public IList<V1beta1AccessPolicySpecForProviderSessionControls>? SessionControls { get; set; }

    /// <summary>Specifies the state of the policy object. Possible values are: enabled, disabled and enabledForReportingButNotEnforced</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecInitProviderConditionsApplications
{
    /// <summary>A list of application IDs explicitly excluded from the policy. Can also be set to Office365.</summary>
    [JsonPropertyName("excludedApplications")]
    public IList<string>? ExcludedApplications { get; set; }

    /// <summary>A list of application IDs the policy applies to, unless explicitly excluded (in excluded_applications). Can also be set to All, None or Office365. Cannot be specified with included_user_actions. One of included_applications or included_user_actions must be specified.</summary>
    [JsonPropertyName("includedApplications")]
    public IList<string>? IncludedApplications { get; set; }

    /// <summary>A list of user actions to include. Supported values are urn:user:registerdevice and urn:user:registersecurityinfo. Cannot be specified with included_applications. One of included_applications or included_user_actions must be specified.</summary>
    [JsonPropertyName("includedUserActions")]
    public IList<string>? IncludedUserActions { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecInitProviderConditionsClientApplications
{
    /// <summary>A list of service principal IDs explicitly excluded in the policy.</summary>
    [JsonPropertyName("excludedServicePrincipals")]
    public IList<string>? ExcludedServicePrincipals { get; set; }

    /// <summary>A list of service principal IDs explicitly included in the policy. Can be set to ServicePrincipalsInMyTenant to include all service principals. This is mandatory value when at least one excluded_service_principals is set.</summary>
    [JsonPropertyName("includedServicePrincipals")]
    public IList<string>? IncludedServicePrincipals { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecInitProviderConditionsDevicesFilter
{
    /// <summary>Whether to include in, or exclude from, matching devices from the policy. Supported values are include or exclude.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Condition filter to match devices. For more information, see official documentation.</summary>
    [JsonPropertyName("rule")]
    public string? Rule { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecInitProviderConditionsDevices
{
    /// <summary>A filter block as described below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1AccessPolicySpecInitProviderConditionsDevicesFilter>? Filter { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecInitProviderConditionsLocations
{
    /// <summary>A list of location IDs excluded from scope of policy. Can also be set to AllTrusted.</summary>
    [JsonPropertyName("excludedLocations")]
    public IList<string>? ExcludedLocations { get; set; }

    /// <summary>A list of location IDs in scope of policy unless explicitly excluded. Can also be set to All, or AllTrusted.</summary>
    [JsonPropertyName("includedLocations")]
    public IList<string>? IncludedLocations { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecInitProviderConditionsPlatforms
{
    /// <summary>A list of platforms explicitly excluded from the policy. Possible values are: all, android, iOS, linux, macOS, windows, windowsPhone or unknownFutureValue.</summary>
    [JsonPropertyName("excludedPlatforms")]
    public IList<string>? ExcludedPlatforms { get; set; }

    /// <summary>A list of platforms the policy applies to, unless explicitly excluded. Possible values are: all, android, iOS, linux, macOS, windows, windowsPhone or unknownFutureValue.</summary>
    [JsonPropertyName("includedPlatforms")]
    public IList<string>? IncludedPlatforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecInitProviderConditionsUsersExcludedGuestsOrExternalUsersExternalTenants
{
    /// <summary>A list tenant IDs. Can only be specified if membership_kind is enumerated.</summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>The external tenant membership kind. Possible values are: all, enumerated, unknownFutureValue.</summary>
    [JsonPropertyName("membershipKind")]
    public string? MembershipKind { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecInitProviderConditionsUsersExcludedGuestsOrExternalUsers
{
    /// <summary>An external_tenants block as documented below, which specifies external tenants in a policy scope.</summary>
    [JsonPropertyName("externalTenants")]
    public IList<V1beta1AccessPolicySpecInitProviderConditionsUsersExcludedGuestsOrExternalUsersExternalTenants>? ExternalTenants { get; set; }

    /// <summary>A list of guest or external user types. Possible values are: b2bCollaborationGuest, b2bCollaborationMember, b2bDirectConnectUser, internalGuest, none, otherExternalUser, serviceProvider, unknownFutureValue.</summary>
    [JsonPropertyName("guestOrExternalUserTypes")]
    public IList<string>? GuestOrExternalUserTypes { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecInitProviderConditionsUsersIncludedGuestsOrExternalUsersExternalTenants
{
    /// <summary>A list tenant IDs. Can only be specified if membership_kind is enumerated.</summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>The external tenant membership kind. Possible values are: all, enumerated, unknownFutureValue.</summary>
    [JsonPropertyName("membershipKind")]
    public string? MembershipKind { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecInitProviderConditionsUsersIncludedGuestsOrExternalUsers
{
    /// <summary>An external_tenants block as documented below, which specifies external tenants in a policy scope.</summary>
    [JsonPropertyName("externalTenants")]
    public IList<V1beta1AccessPolicySpecInitProviderConditionsUsersIncludedGuestsOrExternalUsersExternalTenants>? ExternalTenants { get; set; }

    /// <summary>A list of guest or external user types. Possible values are: b2bCollaborationGuest, b2bCollaborationMember, b2bDirectConnectUser, internalGuest, none, otherExternalUser, serviceProvider, unknownFutureValue.</summary>
    [JsonPropertyName("guestOrExternalUserTypes")]
    public IList<string>? GuestOrExternalUserTypes { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecInitProviderConditionsUsers
{
    /// <summary>A list of group IDs excluded from scope of policy.</summary>
    [JsonPropertyName("excludedGroups")]
    public IList<string>? ExcludedGroups { get; set; }

    /// <summary>A guests_or_external_users block as documented below, which specifies internal guests and external users excluded from scope of policy.</summary>
    [JsonPropertyName("excludedGuestsOrExternalUsers")]
    public IList<V1beta1AccessPolicySpecInitProviderConditionsUsersExcludedGuestsOrExternalUsers>? ExcludedGuestsOrExternalUsers { get; set; }

    /// <summary>A list of role IDs excluded from scope of policy.</summary>
    [JsonPropertyName("excludedRoles")]
    public IList<string>? ExcludedRoles { get; set; }

    /// <summary>A list of user IDs excluded from scope of policy and/or GuestsOrExternalUsers.</summary>
    [JsonPropertyName("excludedUsers")]
    public IList<string>? ExcludedUsers { get; set; }

    /// <summary>A list of group IDs in scope of policy unless explicitly excluded.</summary>
    [JsonPropertyName("includedGroups")]
    public IList<string>? IncludedGroups { get; set; }

    /// <summary>A guests_or_external_users block as documented below, which specifies internal guests and external users in scope of policy.</summary>
    [JsonPropertyName("includedGuestsOrExternalUsers")]
    public IList<V1beta1AccessPolicySpecInitProviderConditionsUsersIncludedGuestsOrExternalUsers>? IncludedGuestsOrExternalUsers { get; set; }

    /// <summary>A list of role IDs in scope of policy unless explicitly excluded.</summary>
    [JsonPropertyName("includedRoles")]
    public IList<string>? IncludedRoles { get; set; }

    /// <summary>A list of user IDs in scope of policy unless explicitly excluded, or None or All or GuestsOrExternalUsers.</summary>
    [JsonPropertyName("includedUsers")]
    public IList<string>? IncludedUsers { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecInitProviderConditions
{
    /// <summary>An applications block as documented below, which specifies applications and user actions included in and excluded from the policy.</summary>
    [JsonPropertyName("applications")]
    public IList<V1beta1AccessPolicySpecInitProviderConditionsApplications>? Applications { get; set; }

    /// <summary>A list of client application types included in the policy. Possible values are: all, browser, mobileAppsAndDesktopClients, exchangeActiveSync, easSupported and other.</summary>
    [JsonPropertyName("clientAppTypes")]
    public IList<string>? ClientAppTypes { get; set; }

    /// <summary>An client_applications block as documented below, which specifies service principals included in and excluded from the policy.</summary>
    [JsonPropertyName("clientApplications")]
    public IList<V1beta1AccessPolicySpecInitProviderConditionsClientApplications>? ClientApplications { get; set; }

    /// <summary>A devices block as documented below, which describes devices to be included in and excluded from the policy. A devices block can be added to an existing policy, but removing the devices block forces a new resource to be created.</summary>
    [JsonPropertyName("devices")]
    public IList<V1beta1AccessPolicySpecInitProviderConditionsDevices>? Devices { get; set; }

    /// <summary>A locations block as documented below, which specifies locations included in and excluded from the policy.</summary>
    [JsonPropertyName("locations")]
    public IList<V1beta1AccessPolicySpecInitProviderConditionsLocations>? Locations { get; set; }

    /// <summary>A platforms block as documented below, which specifies platforms included in and excluded from the policy.</summary>
    [JsonPropertyName("platforms")]
    public IList<V1beta1AccessPolicySpecInitProviderConditionsPlatforms>? Platforms { get; set; }

    /// <summary>A list of service principal sign-in risk levels included in the policy. Possible values are: low, medium, high, none, unknownFutureValue.</summary>
    [JsonPropertyName("servicePrincipalRiskLevels")]
    public IList<string>? ServicePrincipalRiskLevels { get; set; }

    /// <summary>A list of user sign-in risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue.</summary>
    [JsonPropertyName("signInRiskLevels")]
    public IList<string>? SignInRiskLevels { get; set; }

    /// <summary>A list of user risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue.</summary>
    [JsonPropertyName("userRiskLevels")]
    public IList<string>? UserRiskLevels { get; set; }

    /// <summary>A users block as documented below, which specifies users, groups, and roles included in and excluded from the policy.</summary>
    [JsonPropertyName("users")]
    public IList<V1beta1AccessPolicySpecInitProviderConditionsUsers>? Users { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecInitProviderGrantControls
{
    /// <summary>ID of an Authentication Strength Policy to use in this policy.</summary>
    [JsonPropertyName("authenticationStrengthPolicyId")]
    public string? AuthenticationStrengthPolicyId { get; set; }

    /// <summary>List of built-in controls required by the policy. Possible values are: block, mfa, approvedApplication, compliantApplication, compliantDevice, domainJoinedDevice, passwordChange or unknownFutureValue.</summary>
    [JsonPropertyName("builtInControls")]
    public IList<string>? BuiltInControls { get; set; }

    /// <summary>List of custom controls IDs required by the policy.</summary>
    [JsonPropertyName("customAuthenticationFactors")]
    public IList<string>? CustomAuthenticationFactors { get; set; }

    /// <summary>Defines the relationship of the grant controls. Possible values are: AND, OR.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>List of terms of use IDs required by the policy.</summary>
    [JsonPropertyName("termsOfUse")]
    public IList<string>? TermsOfUse { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicySpecInitProviderSessionControls
{
    /// <summary>Whether application enforced restrictions are enabled. Defaults to false.</summary>
    [JsonPropertyName("applicationEnforcedRestrictionsEnabled")]
    public bool? ApplicationEnforcedRestrictionsEnabled { get; set; }

    /// <summary>Enables cloud app security and specifies the cloud app security policy to use. Possible values are: blockDownloads, mcasConfigured, monitorOnly or unknownFutureValue.</summary>
    [JsonPropertyName("cloudAppSecurityPolicy")]
    public string? CloudAppSecurityPolicy { get; set; }

    /// <summary>Disables resilience defaults. Defaults to false.</summary>
    [JsonPropertyName("disableResilienceDefaults")]
    public bool? DisableResilienceDefaults { get; set; }

    /// <summary>Session control to define whether to persist cookies. Possible values are: always or never.</summary>
    [JsonPropertyName("persistentBrowserMode")]
    public string? PersistentBrowserMode { get; set; }

    /// <summary>Number of days or hours to enforce sign-in frequency. Required when sign_in_frequency_period is specified.</summary>
    [JsonPropertyName("signInFrequency")]
    public double? SignInFrequency { get; set; }

    /// <summary>Authentication type for enforcing sign-in frequency. Possible values are: primaryAndSecondaryAuthentication or secondaryAuthentication. Defaults to primaryAndSecondaryAuthentication.</summary>
    [JsonPropertyName("signInFrequencyAuthenticationType")]
    public string? SignInFrequencyAuthenticationType { get; set; }

    /// <summary>The interval to apply to sign-in frequency control. Possible values are: timeBased or everyTime. Defaults to timeBased.</summary>
    [JsonPropertyName("signInFrequencyInterval")]
    public string? SignInFrequencyInterval { get; set; }

    /// <summary>The time period to enforce sign-in frequency. Possible values are: hours or days. Required when sign_in_frequency_period is specified.</summary>
    [JsonPropertyName("signInFrequencyPeriod")]
    public string? SignInFrequencyPeriod { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1AccessPolicySpecInitProvider
{
    /// <summary>A conditions block as documented below, which specifies the rules that must be met for the policy to apply.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccessPolicySpecInitProviderConditions>? Conditions { get; set; }

    /// <summary>The friendly name for this Conditional Access Policy.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A grant_controls block as documented below, which specifies the grant controls that must be fulfilled to pass the policy.</summary>
    [JsonPropertyName("grantControls")]
    public IList<V1beta1AccessPolicySpecInitProviderGrantControls>? GrantControls { get; set; }

    /// <summary>A session_controls block as documented below, which specifies the session controls that are enforced after sign-in.</summary>
    [JsonPropertyName("sessionControls")]
    public IList<V1beta1AccessPolicySpecInitProviderSessionControls>? SessionControls { get; set; }

    /// <summary>Specifies the state of the policy object. Possible values are: enabled, disabled and enabledForReportingButNotEnforced</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

public enum V1beta1AccessPolicySpecManagementPoliciesEnum
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

public enum V1beta1AccessPolicySpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AccessPolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AccessPolicySpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPolicySpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1AccessPolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPolicySpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1AccessPolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1AccessPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1AccessPolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AccessPolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AccessPolicySpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1AccessPolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1AccessPolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1AccessPolicySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessPolicySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1AccessPolicySpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1AccessPolicySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1AccessPolicySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1AccessPolicySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1AccessPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AccessPolicySpec defines the desired state of AccessPolicy</summary>
public partial class V1beta1AccessPolicySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPolicySpecDeletionPolicyEnum>))]
    public V1beta1AccessPolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AccessPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AccessPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1AccessPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AccessPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1AccessPolicySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AccessPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicyStatusAtProviderConditionsApplications
{
    /// <summary>A list of application IDs explicitly excluded from the policy. Can also be set to Office365.</summary>
    [JsonPropertyName("excludedApplications")]
    public IList<string>? ExcludedApplications { get; set; }

    /// <summary>A list of application IDs the policy applies to, unless explicitly excluded (in excluded_applications). Can also be set to All, None or Office365. Cannot be specified with included_user_actions. One of included_applications or included_user_actions must be specified.</summary>
    [JsonPropertyName("includedApplications")]
    public IList<string>? IncludedApplications { get; set; }

    /// <summary>A list of user actions to include. Supported values are urn:user:registerdevice and urn:user:registersecurityinfo. Cannot be specified with included_applications. One of included_applications or included_user_actions must be specified.</summary>
    [JsonPropertyName("includedUserActions")]
    public IList<string>? IncludedUserActions { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicyStatusAtProviderConditionsClientApplications
{
    /// <summary>A list of service principal IDs explicitly excluded in the policy.</summary>
    [JsonPropertyName("excludedServicePrincipals")]
    public IList<string>? ExcludedServicePrincipals { get; set; }

    /// <summary>A list of service principal IDs explicitly included in the policy. Can be set to ServicePrincipalsInMyTenant to include all service principals. This is mandatory value when at least one excluded_service_principals is set.</summary>
    [JsonPropertyName("includedServicePrincipals")]
    public IList<string>? IncludedServicePrincipals { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicyStatusAtProviderConditionsDevicesFilter
{
    /// <summary>Whether to include in, or exclude from, matching devices from the policy. Supported values are include or exclude.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Condition filter to match devices. For more information, see official documentation.</summary>
    [JsonPropertyName("rule")]
    public string? Rule { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicyStatusAtProviderConditionsDevices
{
    /// <summary>A filter block as described below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1AccessPolicyStatusAtProviderConditionsDevicesFilter>? Filter { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicyStatusAtProviderConditionsLocations
{
    /// <summary>A list of location IDs excluded from scope of policy. Can also be set to AllTrusted.</summary>
    [JsonPropertyName("excludedLocations")]
    public IList<string>? ExcludedLocations { get; set; }

    /// <summary>A list of location IDs in scope of policy unless explicitly excluded. Can also be set to All, or AllTrusted.</summary>
    [JsonPropertyName("includedLocations")]
    public IList<string>? IncludedLocations { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicyStatusAtProviderConditionsPlatforms
{
    /// <summary>A list of platforms explicitly excluded from the policy. Possible values are: all, android, iOS, linux, macOS, windows, windowsPhone or unknownFutureValue.</summary>
    [JsonPropertyName("excludedPlatforms")]
    public IList<string>? ExcludedPlatforms { get; set; }

    /// <summary>A list of platforms the policy applies to, unless explicitly excluded. Possible values are: all, android, iOS, linux, macOS, windows, windowsPhone or unknownFutureValue.</summary>
    [JsonPropertyName("includedPlatforms")]
    public IList<string>? IncludedPlatforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicyStatusAtProviderConditionsUsersExcludedGuestsOrExternalUsersExternalTenants
{
    /// <summary>A list tenant IDs. Can only be specified if membership_kind is enumerated.</summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>The external tenant membership kind. Possible values are: all, enumerated, unknownFutureValue.</summary>
    [JsonPropertyName("membershipKind")]
    public string? MembershipKind { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicyStatusAtProviderConditionsUsersExcludedGuestsOrExternalUsers
{
    /// <summary>An external_tenants block as documented below, which specifies external tenants in a policy scope.</summary>
    [JsonPropertyName("externalTenants")]
    public IList<V1beta1AccessPolicyStatusAtProviderConditionsUsersExcludedGuestsOrExternalUsersExternalTenants>? ExternalTenants { get; set; }

    /// <summary>A list of guest or external user types. Possible values are: b2bCollaborationGuest, b2bCollaborationMember, b2bDirectConnectUser, internalGuest, none, otherExternalUser, serviceProvider, unknownFutureValue.</summary>
    [JsonPropertyName("guestOrExternalUserTypes")]
    public IList<string>? GuestOrExternalUserTypes { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicyStatusAtProviderConditionsUsersIncludedGuestsOrExternalUsersExternalTenants
{
    /// <summary>A list tenant IDs. Can only be specified if membership_kind is enumerated.</summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>The external tenant membership kind. Possible values are: all, enumerated, unknownFutureValue.</summary>
    [JsonPropertyName("membershipKind")]
    public string? MembershipKind { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicyStatusAtProviderConditionsUsersIncludedGuestsOrExternalUsers
{
    /// <summary>An external_tenants block as documented below, which specifies external tenants in a policy scope.</summary>
    [JsonPropertyName("externalTenants")]
    public IList<V1beta1AccessPolicyStatusAtProviderConditionsUsersIncludedGuestsOrExternalUsersExternalTenants>? ExternalTenants { get; set; }

    /// <summary>A list of guest or external user types. Possible values are: b2bCollaborationGuest, b2bCollaborationMember, b2bDirectConnectUser, internalGuest, none, otherExternalUser, serviceProvider, unknownFutureValue.</summary>
    [JsonPropertyName("guestOrExternalUserTypes")]
    public IList<string>? GuestOrExternalUserTypes { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicyStatusAtProviderConditionsUsers
{
    /// <summary>A list of group IDs excluded from scope of policy.</summary>
    [JsonPropertyName("excludedGroups")]
    public IList<string>? ExcludedGroups { get; set; }

    /// <summary>A guests_or_external_users block as documented below, which specifies internal guests and external users excluded from scope of policy.</summary>
    [JsonPropertyName("excludedGuestsOrExternalUsers")]
    public IList<V1beta1AccessPolicyStatusAtProviderConditionsUsersExcludedGuestsOrExternalUsers>? ExcludedGuestsOrExternalUsers { get; set; }

    /// <summary>A list of role IDs excluded from scope of policy.</summary>
    [JsonPropertyName("excludedRoles")]
    public IList<string>? ExcludedRoles { get; set; }

    /// <summary>A list of user IDs excluded from scope of policy and/or GuestsOrExternalUsers.</summary>
    [JsonPropertyName("excludedUsers")]
    public IList<string>? ExcludedUsers { get; set; }

    /// <summary>A list of group IDs in scope of policy unless explicitly excluded.</summary>
    [JsonPropertyName("includedGroups")]
    public IList<string>? IncludedGroups { get; set; }

    /// <summary>A guests_or_external_users block as documented below, which specifies internal guests and external users in scope of policy.</summary>
    [JsonPropertyName("includedGuestsOrExternalUsers")]
    public IList<V1beta1AccessPolicyStatusAtProviderConditionsUsersIncludedGuestsOrExternalUsers>? IncludedGuestsOrExternalUsers { get; set; }

    /// <summary>A list of role IDs in scope of policy unless explicitly excluded.</summary>
    [JsonPropertyName("includedRoles")]
    public IList<string>? IncludedRoles { get; set; }

    /// <summary>A list of user IDs in scope of policy unless explicitly excluded, or None or All or GuestsOrExternalUsers.</summary>
    [JsonPropertyName("includedUsers")]
    public IList<string>? IncludedUsers { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicyStatusAtProviderConditions
{
    /// <summary>An applications block as documented below, which specifies applications and user actions included in and excluded from the policy.</summary>
    [JsonPropertyName("applications")]
    public IList<V1beta1AccessPolicyStatusAtProviderConditionsApplications>? Applications { get; set; }

    /// <summary>A list of client application types included in the policy. Possible values are: all, browser, mobileAppsAndDesktopClients, exchangeActiveSync, easSupported and other.</summary>
    [JsonPropertyName("clientAppTypes")]
    public IList<string>? ClientAppTypes { get; set; }

    /// <summary>An client_applications block as documented below, which specifies service principals included in and excluded from the policy.</summary>
    [JsonPropertyName("clientApplications")]
    public IList<V1beta1AccessPolicyStatusAtProviderConditionsClientApplications>? ClientApplications { get; set; }

    /// <summary>A devices block as documented below, which describes devices to be included in and excluded from the policy. A devices block can be added to an existing policy, but removing the devices block forces a new resource to be created.</summary>
    [JsonPropertyName("devices")]
    public IList<V1beta1AccessPolicyStatusAtProviderConditionsDevices>? Devices { get; set; }

    /// <summary>A locations block as documented below, which specifies locations included in and excluded from the policy.</summary>
    [JsonPropertyName("locations")]
    public IList<V1beta1AccessPolicyStatusAtProviderConditionsLocations>? Locations { get; set; }

    /// <summary>A platforms block as documented below, which specifies platforms included in and excluded from the policy.</summary>
    [JsonPropertyName("platforms")]
    public IList<V1beta1AccessPolicyStatusAtProviderConditionsPlatforms>? Platforms { get; set; }

    /// <summary>A list of service principal sign-in risk levels included in the policy. Possible values are: low, medium, high, none, unknownFutureValue.</summary>
    [JsonPropertyName("servicePrincipalRiskLevels")]
    public IList<string>? ServicePrincipalRiskLevels { get; set; }

    /// <summary>A list of user sign-in risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue.</summary>
    [JsonPropertyName("signInRiskLevels")]
    public IList<string>? SignInRiskLevels { get; set; }

    /// <summary>A list of user risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue.</summary>
    [JsonPropertyName("userRiskLevels")]
    public IList<string>? UserRiskLevels { get; set; }

    /// <summary>A users block as documented below, which specifies users, groups, and roles included in and excluded from the policy.</summary>
    [JsonPropertyName("users")]
    public IList<V1beta1AccessPolicyStatusAtProviderConditionsUsers>? Users { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicyStatusAtProviderGrantControls
{
    /// <summary>ID of an Authentication Strength Policy to use in this policy.</summary>
    [JsonPropertyName("authenticationStrengthPolicyId")]
    public string? AuthenticationStrengthPolicyId { get; set; }

    /// <summary>List of built-in controls required by the policy. Possible values are: block, mfa, approvedApplication, compliantApplication, compliantDevice, domainJoinedDevice, passwordChange or unknownFutureValue.</summary>
    [JsonPropertyName("builtInControls")]
    public IList<string>? BuiltInControls { get; set; }

    /// <summary>List of custom controls IDs required by the policy.</summary>
    [JsonPropertyName("customAuthenticationFactors")]
    public IList<string>? CustomAuthenticationFactors { get; set; }

    /// <summary>Defines the relationship of the grant controls. Possible values are: AND, OR.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>List of terms of use IDs required by the policy.</summary>
    [JsonPropertyName("termsOfUse")]
    public IList<string>? TermsOfUse { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicyStatusAtProviderSessionControls
{
    /// <summary>Whether application enforced restrictions are enabled. Defaults to false.</summary>
    [JsonPropertyName("applicationEnforcedRestrictionsEnabled")]
    public bool? ApplicationEnforcedRestrictionsEnabled { get; set; }

    /// <summary>Enables cloud app security and specifies the cloud app security policy to use. Possible values are: blockDownloads, mcasConfigured, monitorOnly or unknownFutureValue.</summary>
    [JsonPropertyName("cloudAppSecurityPolicy")]
    public string? CloudAppSecurityPolicy { get; set; }

    /// <summary>Disables resilience defaults. Defaults to false.</summary>
    [JsonPropertyName("disableResilienceDefaults")]
    public bool? DisableResilienceDefaults { get; set; }

    /// <summary>Session control to define whether to persist cookies. Possible values are: always or never.</summary>
    [JsonPropertyName("persistentBrowserMode")]
    public string? PersistentBrowserMode { get; set; }

    /// <summary>Number of days or hours to enforce sign-in frequency. Required when sign_in_frequency_period is specified.</summary>
    [JsonPropertyName("signInFrequency")]
    public double? SignInFrequency { get; set; }

    /// <summary>Authentication type for enforcing sign-in frequency. Possible values are: primaryAndSecondaryAuthentication or secondaryAuthentication. Defaults to primaryAndSecondaryAuthentication.</summary>
    [JsonPropertyName("signInFrequencyAuthenticationType")]
    public string? SignInFrequencyAuthenticationType { get; set; }

    /// <summary>The interval to apply to sign-in frequency control. Possible values are: timeBased or everyTime. Defaults to timeBased.</summary>
    [JsonPropertyName("signInFrequencyInterval")]
    public string? SignInFrequencyInterval { get; set; }

    /// <summary>The time period to enforce sign-in frequency. Possible values are: hours or days. Required when sign_in_frequency_period is specified.</summary>
    [JsonPropertyName("signInFrequencyPeriod")]
    public string? SignInFrequencyPeriod { get; set; }
}

/// <summary></summary>
public partial class V1beta1AccessPolicyStatusAtProvider
{
    /// <summary>A conditions block as documented below, which specifies the rules that must be met for the policy to apply.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccessPolicyStatusAtProviderConditions>? Conditions { get; set; }

    /// <summary>The friendly name for this Conditional Access Policy.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A grant_controls block as documented below, which specifies the grant controls that must be fulfilled to pass the policy.</summary>
    [JsonPropertyName("grantControls")]
    public IList<V1beta1AccessPolicyStatusAtProviderGrantControls>? GrantControls { get; set; }

    /// <summary>The ID of the Conditional Access Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A session_controls block as documented below, which specifies the session controls that are enforced after sign-in.</summary>
    [JsonPropertyName("sessionControls")]
    public IList<V1beta1AccessPolicyStatusAtProviderSessionControls>? SessionControls { get; set; }

    /// <summary>Specifies the state of the policy object. Possible values are: enabled, disabled and enabledForReportingButNotEnforced</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1AccessPolicyStatusConditions
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

/// <summary>AccessPolicyStatus defines the observed state of AccessPolicy.</summary>
public partial class V1beta1AccessPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AccessPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccessPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>AccessPolicy is the Schema for the AccessPolicys API.</summary>
public partial class V1beta1AccessPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AccessPolicySpec>, IStatus<V1beta1AccessPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccessPolicy";
    public const string KubeGroup = "conditionalaccess.azuread.upbound.io";
    public const string KubePluralName = "accesspolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AccessPolicySpec defines the desired state of AccessPolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1AccessPolicySpec Spec { get; set; }

    /// <summary>AccessPolicyStatus defines the observed state of AccessPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1AccessPolicyStatus? Status { get; set; }
}