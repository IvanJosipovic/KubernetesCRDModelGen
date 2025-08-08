using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.serviceprincipals.azuread.m.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalSpecForProviderClientIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Application in applications to populate clientId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalSpecForProviderClientIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrincipalSpecForProviderClientIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalSpecForProviderClientIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Application in applications to populate clientId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalSpecForProviderClientIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrincipalSpecForProviderClientIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalSpecForProviderFeatureTags
{
    /// <summary>Whether this service principal represents a custom SAML application. Enabling this will assign the WindowsAzureActiveDirectoryCustomSingleSignOnApplication tag. Defaults to false. Whether this service principal represents a custom SAML application</summary>
    [JsonPropertyName("customSingleSignOn")]
    public bool? CustomSingleSignOn { get; set; }

    /// <summary>Whether this service principal represents an Enterprise Application. Enabling this will assign the WindowsAzureActiveDirectoryIntegratedApp tag. Defaults to false. Whether this service principal represents an Enterprise Application</summary>
    [JsonPropertyName("enterprise")]
    public bool? Enterprise { get; set; }

    /// <summary>Whether this service principal represents a gallery application. Enabling this will assign the WindowsAzureActiveDirectoryGalleryApplicationNonPrimaryV1 tag. Defaults to false. Whether this service principal represents a gallery application</summary>
    [JsonPropertyName("gallery")]
    public bool? Gallery { get; set; }

    /// <summary>Whether this app is invisible to users in My Apps and Office 365 Launcher. Enabling this will assign the HideApp tag. Defaults to false. Whether this app is invisible to users in My Apps and Office 365 Launcher</summary>
    [JsonPropertyName("hide")]
    public bool? Hide { get; set; }
}

/// <summary>A saml_single_sign_on block as documented below. Settings related to SAML single sign-on</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalSpecForProviderSamlSingleSignOn
{
    /// <summary>The relative URI the service provider would redirect to after completion of the single sign-on flow. The relative URI the service provider would redirect to after completion of the single sign-on flow</summary>
    [JsonPropertyName("relayState")]
    public string? RelayState { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalSpecForProvider
{
    /// <summary>Whether or not the service principal account is enabled. Defaults to true. Whether or not the service principal account is enabled</summary>
    [JsonPropertyName("accountEnabled")]
    public bool? AccountEnabled { get; set; }

    /// <summary>A set of alternative names, used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities. A list of alternative names, used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities</summary>
    [JsonPropertyName("alternativeNames")]
    public IList<string>? AlternativeNames { get; set; }

    /// <summary>Whether this service principal requires an app role assignment to a user or group before Azure AD will issue a user or access token to the application. Defaults to false. Whether this service principal requires an app role assignment to a user or group before Azure AD will issue a user or access token to the application</summary>
    [JsonPropertyName("appRoleAssignmentRequired")]
    public bool? AppRoleAssignmentRequired { get; set; }

    /// <summary>The client ID of the application for which to create a service principal. The client ID of the application for which to create a service principal</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Reference to a Application in applications to populate clientId.</summary>
    [JsonPropertyName("clientIdRef")]
    public V1beta1PrincipalSpecForProviderClientIdRef? ClientIdRef { get; set; }

    /// <summary>Selector for a Application in applications to populate clientId.</summary>
    [JsonPropertyName("clientIdSelector")]
    public V1beta1PrincipalSpecForProviderClientIdSelector? ClientIdSelector { get; set; }

    /// <summary>A description of the service principal provided for internal end-users. Description of the service principal provided for internal end-users</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A feature_tags block as described below. Cannot be used together with the tags property. Block of features to configure for this service principal using tags</summary>
    [JsonPropertyName("featureTags")]
    public IList<V1beta1PrincipalSpecForProviderFeatureTags>? FeatureTags { get; set; }

    /// <summary>The URL where the service provider redirects the user to Azure AD to authenticate. Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps. When blank, Azure AD performs IdP-initiated sign-on for applications configured with SAML-based single sign-on. The URL where the service provider redirects the user to Azure AD to authenticate. Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps. When blank, Azure AD performs IdP-initiated sign-on for applications configured with SAML-based single sign-on</summary>
    [JsonPropertyName("loginUrl")]
    public string? LoginUrl { get; set; }

    /// <summary>A free text field to capture information about the service principal, typically used for operational purposes. Free text field to capture information about the service principal, typically used for operational purposes</summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>A set of email addresses where Azure AD sends a notification when the active certificate is near the expiration date. This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications. List of email addresses where Azure AD sends a notification when the active certificate is near the expiration date. This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications</summary>
    [JsonPropertyName("notificationEmailAddresses")]
    public IList<string>? NotificationEmailAddresses { get; set; }

    /// <summary>A set of object IDs of principals that will be granted ownership of the service principal. Supported object types are users or service principals. By default, no owners are assigned. A list of object IDs of principals that will be granted ownership of the service principal</summary>
    [JsonPropertyName("owners")]
    public IList<string>? Owners { get; set; }

    /// <summary>The single sign-on mode configured for this application. Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps. Supported values are oidc, password, saml or notSupported. Omit this property or specify a blank string to unset. The single sign-on mode configured for this application. Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps</summary>
    [JsonPropertyName("preferredSingleSignOnMode")]
    public string? PreferredSingleSignOnMode { get; set; }

    /// <summary>A saml_single_sign_on block as documented below. Settings related to SAML single sign-on</summary>
    [JsonPropertyName("samlSingleSignOn")]
    public V1beta1PrincipalSpecForProviderSamlSingleSignOn? SamlSingleSignOn { get; set; }

    /// <summary>A set of tags to apply to the service principal for configuring specific behaviours of the service principal. Note that these are not provided for use by practitioners. Cannot be used together with the feature_tags block. A set of tags to apply to the service principal</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>When true, any existing service principal linked to the same application will be automatically imported. When false, an import error will be raised for any pre-existing service principal. When true, the resource will return an existing service principal instead of failing with an error</summary>
    [JsonPropertyName("useExisting")]
    public bool? UseExisting { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalSpecInitProviderClientIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Application in applications to populate clientId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalSpecInitProviderClientIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrincipalSpecInitProviderClientIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalSpecInitProviderClientIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Application in applications to populate clientId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalSpecInitProviderClientIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrincipalSpecInitProviderClientIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalSpecInitProviderFeatureTags
{
    /// <summary>Whether this service principal represents a custom SAML application. Enabling this will assign the WindowsAzureActiveDirectoryCustomSingleSignOnApplication tag. Defaults to false. Whether this service principal represents a custom SAML application</summary>
    [JsonPropertyName("customSingleSignOn")]
    public bool? CustomSingleSignOn { get; set; }

    /// <summary>Whether this service principal represents an Enterprise Application. Enabling this will assign the WindowsAzureActiveDirectoryIntegratedApp tag. Defaults to false. Whether this service principal represents an Enterprise Application</summary>
    [JsonPropertyName("enterprise")]
    public bool? Enterprise { get; set; }

    /// <summary>Whether this service principal represents a gallery application. Enabling this will assign the WindowsAzureActiveDirectoryGalleryApplicationNonPrimaryV1 tag. Defaults to false. Whether this service principal represents a gallery application</summary>
    [JsonPropertyName("gallery")]
    public bool? Gallery { get; set; }

    /// <summary>Whether this app is invisible to users in My Apps and Office 365 Launcher. Enabling this will assign the HideApp tag. Defaults to false. Whether this app is invisible to users in My Apps and Office 365 Launcher</summary>
    [JsonPropertyName("hide")]
    public bool? Hide { get; set; }
}

/// <summary>A saml_single_sign_on block as documented below. Settings related to SAML single sign-on</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalSpecInitProviderSamlSingleSignOn
{
    /// <summary>The relative URI the service provider would redirect to after completion of the single sign-on flow. The relative URI the service provider would redirect to after completion of the single sign-on flow</summary>
    [JsonPropertyName("relayState")]
    public string? RelayState { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalSpecInitProvider
{
    /// <summary>Whether or not the service principal account is enabled. Defaults to true. Whether or not the service principal account is enabled</summary>
    [JsonPropertyName("accountEnabled")]
    public bool? AccountEnabled { get; set; }

    /// <summary>A set of alternative names, used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities. A list of alternative names, used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities</summary>
    [JsonPropertyName("alternativeNames")]
    public IList<string>? AlternativeNames { get; set; }

    /// <summary>Whether this service principal requires an app role assignment to a user or group before Azure AD will issue a user or access token to the application. Defaults to false. Whether this service principal requires an app role assignment to a user or group before Azure AD will issue a user or access token to the application</summary>
    [JsonPropertyName("appRoleAssignmentRequired")]
    public bool? AppRoleAssignmentRequired { get; set; }

    /// <summary>The client ID of the application for which to create a service principal. The client ID of the application for which to create a service principal</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Reference to a Application in applications to populate clientId.</summary>
    [JsonPropertyName("clientIdRef")]
    public V1beta1PrincipalSpecInitProviderClientIdRef? ClientIdRef { get; set; }

    /// <summary>Selector for a Application in applications to populate clientId.</summary>
    [JsonPropertyName("clientIdSelector")]
    public V1beta1PrincipalSpecInitProviderClientIdSelector? ClientIdSelector { get; set; }

    /// <summary>A description of the service principal provided for internal end-users. Description of the service principal provided for internal end-users</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A feature_tags block as described below. Cannot be used together with the tags property. Block of features to configure for this service principal using tags</summary>
    [JsonPropertyName("featureTags")]
    public IList<V1beta1PrincipalSpecInitProviderFeatureTags>? FeatureTags { get; set; }

    /// <summary>The URL where the service provider redirects the user to Azure AD to authenticate. Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps. When blank, Azure AD performs IdP-initiated sign-on for applications configured with SAML-based single sign-on. The URL where the service provider redirects the user to Azure AD to authenticate. Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps. When blank, Azure AD performs IdP-initiated sign-on for applications configured with SAML-based single sign-on</summary>
    [JsonPropertyName("loginUrl")]
    public string? LoginUrl { get; set; }

    /// <summary>A free text field to capture information about the service principal, typically used for operational purposes. Free text field to capture information about the service principal, typically used for operational purposes</summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>A set of email addresses where Azure AD sends a notification when the active certificate is near the expiration date. This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications. List of email addresses where Azure AD sends a notification when the active certificate is near the expiration date. This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications</summary>
    [JsonPropertyName("notificationEmailAddresses")]
    public IList<string>? NotificationEmailAddresses { get; set; }

    /// <summary>A set of object IDs of principals that will be granted ownership of the service principal. Supported object types are users or service principals. By default, no owners are assigned. A list of object IDs of principals that will be granted ownership of the service principal</summary>
    [JsonPropertyName("owners")]
    public IList<string>? Owners { get; set; }

    /// <summary>The single sign-on mode configured for this application. Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps. Supported values are oidc, password, saml or notSupported. Omit this property or specify a blank string to unset. The single sign-on mode configured for this application. Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps</summary>
    [JsonPropertyName("preferredSingleSignOnMode")]
    public string? PreferredSingleSignOnMode { get; set; }

    /// <summary>A saml_single_sign_on block as documented below. Settings related to SAML single sign-on</summary>
    [JsonPropertyName("samlSingleSignOn")]
    public V1beta1PrincipalSpecInitProviderSamlSingleSignOn? SamlSingleSignOn { get; set; }

    /// <summary>A set of tags to apply to the service principal for configuring specific behaviours of the service principal. Note that these are not provided for use by practitioners. Cannot be used together with the feature_tags block. A set of tags to apply to the service principal</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>When true, any existing service principal linked to the same application will be automatically imported. When false, an import error will be raised for any pre-existing service principal. When true, the resource will return an existing service principal instead of failing with an error</summary>
    [JsonPropertyName("useExisting")]
    public bool? UseExisting { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>PrincipalSpec defines the desired state of Principal</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PrincipalSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PrincipalSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PrincipalSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PrincipalSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalStatusAtProviderAppRoles
{
    /// <summary>Specifies whether this app role definition can be assigned to users and groups, or to other applications (that are accessing this application in a standalone scenario). Possible values are: User and Application, or both.</summary>
    [JsonPropertyName("allowedMemberTypes")]
    public IList<string>? AllowedMemberTypes { get; set; }

    /// <summary>A description of the service principal provided for internal end-users.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the application associated with this service principal.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Determines if the app role is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The unique identifier of the app_role.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The value that is used for the roles claim in ID tokens and OAuth 2.0 access tokens that are authenticating an assigned service or user principal.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalStatusAtProviderFeatureTags
{
    /// <summary>Whether this service principal represents a custom SAML application. Enabling this will assign the WindowsAzureActiveDirectoryCustomSingleSignOnApplication tag. Defaults to false. Whether this service principal represents a custom SAML application</summary>
    [JsonPropertyName("customSingleSignOn")]
    public bool? CustomSingleSignOn { get; set; }

    /// <summary>Whether this service principal represents an Enterprise Application. Enabling this will assign the WindowsAzureActiveDirectoryIntegratedApp tag. Defaults to false. Whether this service principal represents an Enterprise Application</summary>
    [JsonPropertyName("enterprise")]
    public bool? Enterprise { get; set; }

    /// <summary>Whether this service principal represents a gallery application. Enabling this will assign the WindowsAzureActiveDirectoryGalleryApplicationNonPrimaryV1 tag. Defaults to false. Whether this service principal represents a gallery application</summary>
    [JsonPropertyName("gallery")]
    public bool? Gallery { get; set; }

    /// <summary>Whether this app is invisible to users in My Apps and Office 365 Launcher. Enabling this will assign the HideApp tag. Defaults to false. Whether this app is invisible to users in My Apps and Office 365 Launcher</summary>
    [JsonPropertyName("hide")]
    public bool? Hide { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalStatusAtProviderOauth2PermissionScopes
{
    /// <summary>Delegated permission description that appears in all tenant-wide admin consent experiences, intended to be read by an administrator granting the permission on behalf of all users.</summary>
    [JsonPropertyName("adminConsentDescription")]
    public string? AdminConsentDescription { get; set; }

    /// <summary>Display name for the delegated permission, intended to be read by an administrator granting the permission on behalf of all users.</summary>
    [JsonPropertyName("adminConsentDisplayName")]
    public string? AdminConsentDisplayName { get; set; }

    /// <summary>Determines if the app role is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The unique identifier of the app_role.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identifies whether the service principal represents an application or a managed identity. Possible values include Application or ManagedIdentity.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Delegated permission description that appears in the end user consent experience, intended to be read by a user consenting on their own behalf.</summary>
    [JsonPropertyName("userConsentDescription")]
    public string? UserConsentDescription { get; set; }

    /// <summary>Display name for the delegated permission that appears in the end user consent experience.</summary>
    [JsonPropertyName("userConsentDisplayName")]
    public string? UserConsentDisplayName { get; set; }

    /// <summary>The value that is used for the roles claim in ID tokens and OAuth 2.0 access tokens that are authenticating an assigned service or user principal.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A saml_single_sign_on block as documented below. Settings related to SAML single sign-on</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalStatusAtProviderSamlSingleSignOn
{
    /// <summary>The relative URI the service provider would redirect to after completion of the single sign-on flow. The relative URI the service provider would redirect to after completion of the single sign-on flow</summary>
    [JsonPropertyName("relayState")]
    public string? RelayState { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalStatusAtProvider
{
    /// <summary>Whether or not the service principal account is enabled. Defaults to true. Whether or not the service principal account is enabled</summary>
    [JsonPropertyName("accountEnabled")]
    public bool? AccountEnabled { get; set; }

    /// <summary>A set of alternative names, used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities. A list of alternative names, used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities</summary>
    [JsonPropertyName("alternativeNames")]
    public IList<string>? AlternativeNames { get; set; }

    /// <summary>Whether this service principal requires an app role assignment to a user or group before Azure AD will issue a user or access token to the application. Defaults to false. Whether this service principal requires an app role assignment to a user or group before Azure AD will issue a user or access token to the application</summary>
    [JsonPropertyName("appRoleAssignmentRequired")]
    public bool? AppRoleAssignmentRequired { get; set; }

    /// <summary>A mapping of app role values to app role IDs, as published by the associated application, intended to be useful when referencing app roles in other resources in your configuration. Mapping of app role names to UUIDs</summary>
    [JsonPropertyName("appRoleIds")]
    public IDictionary<string, string>? AppRoleIds { get; set; }

    /// <summary>A list of app roles published by the associated application, as documented below. For more information official documentation.</summary>
    [JsonPropertyName("appRoles")]
    public IList<V1beta1PrincipalStatusAtProviderAppRoles>? AppRoles { get; set; }

    /// <summary>The tenant ID where the associated application is registered. The tenant ID where the associated application is registered</summary>
    [JsonPropertyName("applicationTenantId")]
    public string? ApplicationTenantId { get; set; }

    /// <summary>The client ID of the application for which to create a service principal. The client ID of the application for which to create a service principal</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>A description of the service principal provided for internal end-users. Description of the service principal provided for internal end-users</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the application associated with this service principal. The display name of the application associated with this service principal</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A feature_tags block as described below. Cannot be used together with the tags property. Block of features to configure for this service principal using tags</summary>
    [JsonPropertyName("featureTags")]
    public IList<V1beta1PrincipalStatusAtProviderFeatureTags>? FeatureTags { get; set; }

    /// <summary>Home page or landing page of the associated application. Home page or landing page of the application</summary>
    [JsonPropertyName("homepageUrl")]
    public string? HomepageUrl { get; set; }

    /// <summary>The unique identifier of the app_role.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The URL where the service provider redirects the user to Azure AD to authenticate. Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps. When blank, Azure AD performs IdP-initiated sign-on for applications configured with SAML-based single sign-on. The URL where the service provider redirects the user to Azure AD to authenticate. Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps. When blank, Azure AD performs IdP-initiated sign-on for applications configured with SAML-based single sign-on</summary>
    [JsonPropertyName("loginUrl")]
    public string? LoginUrl { get; set; }

    /// <summary>The URL that will be used by Microsoft's authorization service to log out an user using OpenId Connect front-channel, back-channel or SAML logout protocols, taken from the associated application. The URL that will be used by Microsoft's authorization service to sign out a user using front-channel, back-channel or SAML logout protocols</summary>
    [JsonPropertyName("logoutUrl")]
    public string? LogoutUrl { get; set; }

    /// <summary>A free text field to capture information about the service principal, typically used for operational purposes. Free text field to capture information about the service principal, typically used for operational purposes</summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>A set of email addresses where Azure AD sends a notification when the active certificate is near the expiration date. This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications. List of email addresses where Azure AD sends a notification when the active certificate is near the expiration date. This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications</summary>
    [JsonPropertyName("notificationEmailAddresses")]
    public IList<string>? NotificationEmailAddresses { get; set; }

    /// <summary>A mapping of OAuth2.0 permission scope values to scope IDs, as exposed by the associated application, intended to be useful when referencing permission scopes in other resources in your configuration. Mapping of OAuth2.0 permission scope names to UUIDs</summary>
    [JsonPropertyName("oauth2PermissionScopeIds")]
    public IDictionary<string, string>? Oauth2PermissionScopeIds { get; set; }

    /// <summary>A list of OAuth 2.0 delegated permission scopes exposed by the associated application, as documented below.</summary>
    [JsonPropertyName("oauth2PermissionScopes")]
    public IList<V1beta1PrincipalStatusAtProviderOauth2PermissionScopes>? Oauth2PermissionScopes { get; set; }

    /// <summary>The object ID of the service principal. The object ID of the service principal</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>A set of object IDs of principals that will be granted ownership of the service principal. Supported object types are users or service principals. By default, no owners are assigned. A list of object IDs of principals that will be granted ownership of the service principal</summary>
    [JsonPropertyName("owners")]
    public IList<string>? Owners { get; set; }

    /// <summary>The single sign-on mode configured for this application. Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps. Supported values are oidc, password, saml or notSupported. Omit this property or specify a blank string to unset. The single sign-on mode configured for this application. Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps</summary>
    [JsonPropertyName("preferredSingleSignOnMode")]
    public string? PreferredSingleSignOnMode { get; set; }

    /// <summary>A list of URLs where user tokens are sent for sign-in with the associated application, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent for the associated application. The URLs where user tokens are sent for sign-in with the associated application, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent for the associated application</summary>
    [JsonPropertyName("redirectUris")]
    public IList<string>? RedirectUris { get; set; }

    /// <summary>The URL where the service exposes SAML metadata for federation. The URL where the service exposes SAML metadata for federation</summary>
    [JsonPropertyName("samlMetadataUrl")]
    public string? SamlMetadataUrl { get; set; }

    /// <summary>A saml_single_sign_on block as documented below. Settings related to SAML single sign-on</summary>
    [JsonPropertyName("samlSingleSignOn")]
    public V1beta1PrincipalStatusAtProviderSamlSingleSignOn? SamlSingleSignOn { get; set; }

    /// <summary>A list of identifier URI(s), copied over from the associated application. A list of identifier URI(s), copied over from the associated application</summary>
    [JsonPropertyName("servicePrincipalNames")]
    public IList<string>? ServicePrincipalNames { get; set; }

    /// <summary>The Microsoft account types that are supported for the associated application. Possible values include AzureADMyOrg, AzureADMultipleOrgs, AzureADandPersonalMicrosoftAccount or PersonalMicrosoftAccount. The Microsoft account types that are supported for the associated application</summary>
    [JsonPropertyName("signInAudience")]
    public string? SignInAudience { get; set; }

    /// <summary>A set of tags to apply to the service principal for configuring specific behaviours of the service principal. Note that these are not provided for use by practitioners. Cannot be used together with the feature_tags block. A set of tags to apply to the service principal</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>Identifies whether the service principal represents an application or a managed identity. Possible values include Application or ManagedIdentity. Identifies whether the service principal represents an application or a managed identity</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>When true, any existing service principal linked to the same application will be automatically imported. When false, an import error will be raised for any pre-existing service principal. When true, the resource will return an existing service principal instead of failing with an error</summary>
    [JsonPropertyName("useExisting")]
    public bool? UseExisting { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalStatusConditions
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

/// <summary>PrincipalStatus defines the observed state of Principal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrincipalStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PrincipalStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PrincipalStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Principal is the Schema for the Principals API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Principal : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PrincipalSpec>, IStatus<V1beta1PrincipalStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Principal";
    public const string KubeGroup = "serviceprincipals.azuread.m.upbound.io";
    public const string KubePluralName = "principals";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PrincipalSpec defines the desired state of Principal</summary>
    [JsonPropertyName("spec")]
    public V1beta1PrincipalSpec Spec { get; set; }

    /// <summary>PrincipalStatus defines the observed state of Principal.</summary>
    [JsonPropertyName("status")]
    public V1beta1PrincipalStatus? Status { get; set; }
}

/// <summary>Principal is the Schema for the Principals API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrincipalList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Principal>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrincipalList";
    public const string KubeGroup = "serviceprincipals.azuread.m.upbound.io";
    public const string KubePluralName = "principals";
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
    public IList<V1beta1Principal> Items { get; set; }
}