using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.users.azuread.upbound.io;
/// <summary>The password for the user. The password must satisfy minimum requirements as specified by the password policy. The maximum length is 256 characters. This property is required when creating a new user. The password for the user. The password must satisfy minimum requirements as specified by the password policy. The maximum length is 256 characters. This property is required when creating a new user</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecForProviderPasswordSecretRef
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
public partial class V1beta1UserSpecForProvider
{
    /// <summary>Whether or not the account should be enabled. Whether or not the account should be enabled</summary>
    [JsonPropertyName("accountEnabled")]
    public bool? AccountEnabled { get; set; }

    /// <summary>The age group of the user. Supported values are Adult, NotAdult and Minor. Omit this property or specify a blank string to unset. The age group of the user</summary>
    [JsonPropertyName("ageGroup")]
    public string? AgeGroup { get; set; }

    /// <summary>A list of telephone numbers for the user. Only one number can be set for this property. Read-only for users synced with Azure AD Connect. The telephone numbers for the user. Only one number can be set for this property. Read-only for users synced with Azure AD Connect</summary>
    [JsonPropertyName("businessPhones")]
    public IList<string>? BusinessPhones { get; set; }

    /// <summary>The city in which the user is located. The city in which the user is located</summary>
    [JsonPropertyName("city")]
    public string? City { get; set; }

    /// <summary>The company name which the user is associated. This property can be useful for describing the company that an external user comes from. The company name which the user is associated. This property can be useful for describing the company that an external user comes from</summary>
    [JsonPropertyName("companyName")]
    public string? CompanyName { get; set; }

    /// <summary>Whether consent has been obtained for minors. Supported values are Granted, Denied and NotRequired. Omit this property or specify a blank string to unset. Whether consent has been obtained for minors</summary>
    [JsonPropertyName("consentProvidedForMinor")]
    public string? ConsentProvidedForMinor { get; set; }

    /// <summary>The cost center associated with the user. The cost center associated with the user.</summary>
    [JsonPropertyName("costCenter")]
    public string? CostCenter { get; set; }

    /// <summary>The country/region in which the user is located. Examples include: NO, JP, and GB. The country/region in which the user is located, e.g. `US` or `UK`</summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>The name for the department in which the user works. The name for the department in which the user works</summary>
    [JsonPropertyName("department")]
    public string? Department { get; set; }

    /// <summary>Whether the user's password is exempt from expiring. Defaults to false. Whether the users password is exempt from expiring</summary>
    [JsonPropertyName("disablePasswordExpiration")]
    public bool? DisablePasswordExpiration { get; set; }

    /// <summary>Whether the user is allowed weaker passwords than the default policy to be specified. Defaults to false. Whether the user is allowed weaker passwords than the default policy to be specified.</summary>
    [JsonPropertyName("disableStrongPassword")]
    public bool? DisableStrongPassword { get; set; }

    /// <summary>The name to display in the address book for the user. The name to display in the address book for the user</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The name of the division in which the user works. The name of the division in which the user works.</summary>
    [JsonPropertyName("division")]
    public string? Division { get; set; }

    /// <summary>The employee identifier assigned to the user by the organisation. The employee identifier assigned to the user by the organisation</summary>
    [JsonPropertyName("employeeId")]
    public string? EmployeeId { get; set; }

    /// <summary>Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor. Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor.</summary>
    [JsonPropertyName("employeeType")]
    public string? EmployeeType { get; set; }

    /// <summary>The fax number of the user. The fax number of the user</summary>
    [JsonPropertyName("faxNumber")]
    public string? FaxNumber { get; set; }

    /// <summary>Whether the user is forced to change the password during the next sign-in. Only takes effect when also changing the password. Defaults to false. Whether the user is forced to change the password during the next sign-in. Only takes effect when also changing the password</summary>
    [JsonPropertyName("forcePasswordChange")]
    public bool? ForcePasswordChange { get; set; }

    /// <summary>The given name (first name) of the user. The given name (first name) of the user</summary>
    [JsonPropertyName("givenName")]
    public string? GivenName { get; set; }

    /// <summary>The user’s job title. The user’s job title</summary>
    [JsonPropertyName("jobTitle")]
    public string? JobTitle { get; set; }

    /// <summary>The SMTP address for the user. This property cannot be unset once specified. The SMTP address for the user. Cannot be unset.</summary>
    [JsonPropertyName("mail")]
    public string? Mail { get; set; }

    /// <summary>The mail alias for the user. Defaults to the user name part of the user principal name (UPN). The mail alias for the user. Defaults to the user name part of the user principal name (UPN)</summary>
    [JsonPropertyName("mailNickname")]
    public string? MailNickname { get; set; }

    /// <summary>The object ID of the user's manager. The object ID of the user's manager</summary>
    [JsonPropertyName("managerId")]
    public string? ManagerId { get; set; }

    /// <summary>The primary cellular telephone number for the user. The primary cellular telephone number for the user</summary>
    [JsonPropertyName("mobilePhone")]
    public string? MobilePhone { get; set; }

    /// <summary>The office location in the user's place of business. The office location in the user's place of business</summary>
    [JsonPropertyName("officeLocation")]
    public string? OfficeLocation { get; set; }

    /// <summary>The value used to associate an on-premise Active Directory user account with their Azure AD user object. This must be specified if you are using a federated domain for the user's user_principal_name property when creating a new user account. The value used to associate an on-premise Active Directory user account with their Azure AD user object. This must be specified if you are using a federated domain for the user's `user_principal_name` property when creating a new user account</summary>
    [JsonPropertyName("onpremisesImmutableId")]
    public string? OnpremisesImmutableId { get; set; }

    /// <summary>A list of additional email addresses for the user. Additional email addresses for the user</summary>
    [JsonPropertyName("otherMails")]
    public IList<string>? OtherMails { get; set; }

    /// <summary>The password for the user. The password must satisfy minimum requirements as specified by the password policy. The maximum length is 256 characters. This property is required when creating a new user. The password for the user. The password must satisfy minimum requirements as specified by the password policy. The maximum length is 256 characters. This property is required when creating a new user</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1UserSpecForProviderPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The postal code for the user's postal address. The postal code is specific to the user's country/region. In the United States of America, this attribute contains the ZIP code. The postal code for the user's postal address. The postal code is specific to the user's country/region. In the United States of America, this attribute contains the ZIP code</summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>The user's preferred language, in ISO 639-1 notation. The user's preferred language, in ISO 639-1 notation</summary>
    [JsonPropertyName("preferredLanguage")]
    public string? PreferredLanguage { get; set; }

    /// <summary>Whether or not the Outlook global address list should include this user. Defaults to true. Whether or not the Outlook global address list should include this user</summary>
    [JsonPropertyName("showInAddressList")]
    public bool? ShowInAddressList { get; set; }

    /// <summary>The state or province in the user's address. The state or province in the user's address</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The street address of the user's place of business. The street address of the user's place of business</summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }

    /// <summary>The user's surname (family name or last name). The user's surname (family name or last name)</summary>
    [JsonPropertyName("surname")]
    public string? Surname { get; set; }

    /// <summary>The usage location of the user. Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries. The usage location is a two letter country code (ISO standard 3166). Examples include: NO, JP, and GB. Cannot be reset to null once set. The usage location of the user. Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries. The usage location is a two letter country code (ISO standard 3166). Examples include: `NO`, `JP`, and `GB`. Cannot be reset to null once set</summary>
    [JsonPropertyName("usageLocation")]
    public string? UsageLocation { get; set; }

    /// <summary>The user principal name (UPN) of the user. The user principal name (UPN) of the user</summary>
    [JsonPropertyName("userPrincipalName")]
    public string? UserPrincipalName { get; set; }
}

/// <summary>The password for the user. The password must satisfy minimum requirements as specified by the password policy. The maximum length is 256 characters. This property is required when creating a new user. The password for the user. The password must satisfy minimum requirements as specified by the password policy. The maximum length is 256 characters. This property is required when creating a new user</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecInitProviderPasswordSecretRef
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

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecInitProvider
{
    /// <summary>Whether or not the account should be enabled. Whether or not the account should be enabled</summary>
    [JsonPropertyName("accountEnabled")]
    public bool? AccountEnabled { get; set; }

    /// <summary>The age group of the user. Supported values are Adult, NotAdult and Minor. Omit this property or specify a blank string to unset. The age group of the user</summary>
    [JsonPropertyName("ageGroup")]
    public string? AgeGroup { get; set; }

    /// <summary>A list of telephone numbers for the user. Only one number can be set for this property. Read-only for users synced with Azure AD Connect. The telephone numbers for the user. Only one number can be set for this property. Read-only for users synced with Azure AD Connect</summary>
    [JsonPropertyName("businessPhones")]
    public IList<string>? BusinessPhones { get; set; }

    /// <summary>The city in which the user is located. The city in which the user is located</summary>
    [JsonPropertyName("city")]
    public string? City { get; set; }

    /// <summary>The company name which the user is associated. This property can be useful for describing the company that an external user comes from. The company name which the user is associated. This property can be useful for describing the company that an external user comes from</summary>
    [JsonPropertyName("companyName")]
    public string? CompanyName { get; set; }

    /// <summary>Whether consent has been obtained for minors. Supported values are Granted, Denied and NotRequired. Omit this property or specify a blank string to unset. Whether consent has been obtained for minors</summary>
    [JsonPropertyName("consentProvidedForMinor")]
    public string? ConsentProvidedForMinor { get; set; }

    /// <summary>The cost center associated with the user. The cost center associated with the user.</summary>
    [JsonPropertyName("costCenter")]
    public string? CostCenter { get; set; }

    /// <summary>The country/region in which the user is located. Examples include: NO, JP, and GB. The country/region in which the user is located, e.g. `US` or `UK`</summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>The name for the department in which the user works. The name for the department in which the user works</summary>
    [JsonPropertyName("department")]
    public string? Department { get; set; }

    /// <summary>Whether the user's password is exempt from expiring. Defaults to false. Whether the users password is exempt from expiring</summary>
    [JsonPropertyName("disablePasswordExpiration")]
    public bool? DisablePasswordExpiration { get; set; }

    /// <summary>Whether the user is allowed weaker passwords than the default policy to be specified. Defaults to false. Whether the user is allowed weaker passwords than the default policy to be specified.</summary>
    [JsonPropertyName("disableStrongPassword")]
    public bool? DisableStrongPassword { get; set; }

    /// <summary>The name to display in the address book for the user. The name to display in the address book for the user</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The name of the division in which the user works. The name of the division in which the user works.</summary>
    [JsonPropertyName("division")]
    public string? Division { get; set; }

    /// <summary>The employee identifier assigned to the user by the organisation. The employee identifier assigned to the user by the organisation</summary>
    [JsonPropertyName("employeeId")]
    public string? EmployeeId { get; set; }

    /// <summary>Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor. Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor.</summary>
    [JsonPropertyName("employeeType")]
    public string? EmployeeType { get; set; }

    /// <summary>The fax number of the user. The fax number of the user</summary>
    [JsonPropertyName("faxNumber")]
    public string? FaxNumber { get; set; }

    /// <summary>Whether the user is forced to change the password during the next sign-in. Only takes effect when also changing the password. Defaults to false. Whether the user is forced to change the password during the next sign-in. Only takes effect when also changing the password</summary>
    [JsonPropertyName("forcePasswordChange")]
    public bool? ForcePasswordChange { get; set; }

    /// <summary>The given name (first name) of the user. The given name (first name) of the user</summary>
    [JsonPropertyName("givenName")]
    public string? GivenName { get; set; }

    /// <summary>The user’s job title. The user’s job title</summary>
    [JsonPropertyName("jobTitle")]
    public string? JobTitle { get; set; }

    /// <summary>The SMTP address for the user. This property cannot be unset once specified. The SMTP address for the user. Cannot be unset.</summary>
    [JsonPropertyName("mail")]
    public string? Mail { get; set; }

    /// <summary>The mail alias for the user. Defaults to the user name part of the user principal name (UPN). The mail alias for the user. Defaults to the user name part of the user principal name (UPN)</summary>
    [JsonPropertyName("mailNickname")]
    public string? MailNickname { get; set; }

    /// <summary>The object ID of the user's manager. The object ID of the user's manager</summary>
    [JsonPropertyName("managerId")]
    public string? ManagerId { get; set; }

    /// <summary>The primary cellular telephone number for the user. The primary cellular telephone number for the user</summary>
    [JsonPropertyName("mobilePhone")]
    public string? MobilePhone { get; set; }

    /// <summary>The office location in the user's place of business. The office location in the user's place of business</summary>
    [JsonPropertyName("officeLocation")]
    public string? OfficeLocation { get; set; }

    /// <summary>The value used to associate an on-premise Active Directory user account with their Azure AD user object. This must be specified if you are using a federated domain for the user's user_principal_name property when creating a new user account. The value used to associate an on-premise Active Directory user account with their Azure AD user object. This must be specified if you are using a federated domain for the user's `user_principal_name` property when creating a new user account</summary>
    [JsonPropertyName("onpremisesImmutableId")]
    public string? OnpremisesImmutableId { get; set; }

    /// <summary>A list of additional email addresses for the user. Additional email addresses for the user</summary>
    [JsonPropertyName("otherMails")]
    public IList<string>? OtherMails { get; set; }

    /// <summary>The password for the user. The password must satisfy minimum requirements as specified by the password policy. The maximum length is 256 characters. This property is required when creating a new user. The password for the user. The password must satisfy minimum requirements as specified by the password policy. The maximum length is 256 characters. This property is required when creating a new user</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1UserSpecInitProviderPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The postal code for the user's postal address. The postal code is specific to the user's country/region. In the United States of America, this attribute contains the ZIP code. The postal code for the user's postal address. The postal code is specific to the user's country/region. In the United States of America, this attribute contains the ZIP code</summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>The user's preferred language, in ISO 639-1 notation. The user's preferred language, in ISO 639-1 notation</summary>
    [JsonPropertyName("preferredLanguage")]
    public string? PreferredLanguage { get; set; }

    /// <summary>Whether or not the Outlook global address list should include this user. Defaults to true. Whether or not the Outlook global address list should include this user</summary>
    [JsonPropertyName("showInAddressList")]
    public bool? ShowInAddressList { get; set; }

    /// <summary>The state or province in the user's address. The state or province in the user's address</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The street address of the user's place of business. The street address of the user's place of business</summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }

    /// <summary>The user's surname (family name or last name). The user's surname (family name or last name)</summary>
    [JsonPropertyName("surname")]
    public string? Surname { get; set; }

    /// <summary>The usage location of the user. Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries. The usage location is a two letter country code (ISO standard 3166). Examples include: NO, JP, and GB. Cannot be reset to null once set. The usage location of the user. Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries. The usage location is a two letter country code (ISO standard 3166). Examples include: `NO`, `JP`, and `GB`. Cannot be reset to null once set</summary>
    [JsonPropertyName("usageLocation")]
    public string? UsageLocation { get; set; }

    /// <summary>The user principal name (UPN) of the user. The user principal name (UPN) of the user</summary>
    [JsonPropertyName("userPrincipalName")]
    public string? UserPrincipalName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecProviderConfigRefPolicy
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
public partial class V1beta1UserSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1UserSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1UserSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1UserSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1UserSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>UserSpec defines the desired state of User</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1UserSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1UserSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1UserSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1UserSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1UserSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserStatusAtProvider
{
    /// <summary>A freeform field for the user to describe themselves</summary>
    [JsonPropertyName("aboutMe")]
    public string? AboutMe { get; set; }

    /// <summary>Whether or not the account should be enabled. Whether or not the account should be enabled</summary>
    [JsonPropertyName("accountEnabled")]
    public bool? AccountEnabled { get; set; }

    /// <summary>The age group of the user. Supported values are Adult, NotAdult and Minor. Omit this property or specify a blank string to unset. The age group of the user</summary>
    [JsonPropertyName("ageGroup")]
    public string? AgeGroup { get; set; }

    /// <summary>A list of telephone numbers for the user. Only one number can be set for this property. Read-only for users synced with Azure AD Connect. The telephone numbers for the user. Only one number can be set for this property. Read-only for users synced with Azure AD Connect</summary>
    [JsonPropertyName("businessPhones")]
    public IList<string>? BusinessPhones { get; set; }

    /// <summary>The city in which the user is located. The city in which the user is located</summary>
    [JsonPropertyName("city")]
    public string? City { get; set; }

    /// <summary>The company name which the user is associated. This property can be useful for describing the company that an external user comes from. The company name which the user is associated. This property can be useful for describing the company that an external user comes from</summary>
    [JsonPropertyName("companyName")]
    public string? CompanyName { get; set; }

    /// <summary>Whether consent has been obtained for minors. Supported values are Granted, Denied and NotRequired. Omit this property or specify a blank string to unset. Whether consent has been obtained for minors</summary>
    [JsonPropertyName("consentProvidedForMinor")]
    public string? ConsentProvidedForMinor { get; set; }

    /// <summary>The cost center associated with the user. The cost center associated with the user.</summary>
    [JsonPropertyName("costCenter")]
    public string? CostCenter { get; set; }

    /// <summary>The country/region in which the user is located. Examples include: NO, JP, and GB. The country/region in which the user is located, e.g. `US` or `UK`</summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>Indicates whether the user account was created as a regular school or work account (null), an external account (Invitation), a local account for an Azure Active Directory B2C tenant (LocalAccount) or self-service sign-up using email verification (EmailVerified). Indicates whether the user account was created as a regular school or work account (`null`), an external account (`Invitation`), a local account for an Azure Active Directory B2C tenant (`LocalAccount`) or self-service sign-up using email verification (`EmailVerified`)</summary>
    [JsonPropertyName("creationType")]
    public string? CreationType { get; set; }

    /// <summary>The name for the department in which the user works. The name for the department in which the user works</summary>
    [JsonPropertyName("department")]
    public string? Department { get; set; }

    /// <summary>Whether the user's password is exempt from expiring. Defaults to false. Whether the users password is exempt from expiring</summary>
    [JsonPropertyName("disablePasswordExpiration")]
    public bool? DisablePasswordExpiration { get; set; }

    /// <summary>Whether the user is allowed weaker passwords than the default policy to be specified. Defaults to false. Whether the user is allowed weaker passwords than the default policy to be specified.</summary>
    [JsonPropertyName("disableStrongPassword")]
    public bool? DisableStrongPassword { get; set; }

    /// <summary>The name to display in the address book for the user. The name to display in the address book for the user</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The name of the division in which the user works. The name of the division in which the user works.</summary>
    [JsonPropertyName("division")]
    public string? Division { get; set; }

    /// <summary>The employee identifier assigned to the user by the organisation. The employee identifier assigned to the user by the organisation</summary>
    [JsonPropertyName("employeeId")]
    public string? EmployeeId { get; set; }

    /// <summary>Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor. Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor.</summary>
    [JsonPropertyName("employeeType")]
    public string? EmployeeType { get; set; }

    /// <summary>For an external user invited to the tenant, this property represents the invited user's invitation status. Possible values are PendingAcceptance or Accepted. For an external user invited to the tenant, this property represents the invited user's invitation status</summary>
    [JsonPropertyName("externalUserState")]
    public string? ExternalUserState { get; set; }

    /// <summary>The fax number of the user. The fax number of the user</summary>
    [JsonPropertyName("faxNumber")]
    public string? FaxNumber { get; set; }

    /// <summary>Whether the user is forced to change the password during the next sign-in. Only takes effect when also changing the password. Defaults to false. Whether the user is forced to change the password during the next sign-in. Only takes effect when also changing the password</summary>
    [JsonPropertyName("forcePasswordChange")]
    public bool? ForcePasswordChange { get; set; }

    /// <summary>The given name (first name) of the user. The given name (first name) of the user</summary>
    [JsonPropertyName("givenName")]
    public string? GivenName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of instant message voice over IP (VOIP) session initiation protocol (SIP) addresses for the user. The instant message voice over IP (VOIP) session initiation protocol (SIP) addresses for the user</summary>
    [JsonPropertyName("imAddresses")]
    public IList<string>? ImAddresses { get; set; }

    /// <summary>The user’s job title. The user’s job title</summary>
    [JsonPropertyName("jobTitle")]
    public string? JobTitle { get; set; }

    /// <summary>The SMTP address for the user. This property cannot be unset once specified. The SMTP address for the user. Cannot be unset.</summary>
    [JsonPropertyName("mail")]
    public string? Mail { get; set; }

    /// <summary>The mail alias for the user. Defaults to the user name part of the user principal name (UPN). The mail alias for the user. Defaults to the user name part of the user principal name (UPN)</summary>
    [JsonPropertyName("mailNickname")]
    public string? MailNickname { get; set; }

    /// <summary>The object ID of the user's manager. The object ID of the user's manager</summary>
    [JsonPropertyName("managerId")]
    public string? ManagerId { get; set; }

    /// <summary>The primary cellular telephone number for the user. The primary cellular telephone number for the user</summary>
    [JsonPropertyName("mobilePhone")]
    public string? MobilePhone { get; set; }

    /// <summary>The object ID of the user. The object ID of the user</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The office location in the user's place of business. The office location in the user's place of business</summary>
    [JsonPropertyName("officeLocation")]
    public string? OfficeLocation { get; set; }

    /// <summary>The on-premises distinguished name (DN) of the user, synchronised from the on-premises directory when Azure AD Connect is used. The on-premise Active Directory distinguished name (DN) of the user</summary>
    [JsonPropertyName("onpremisesDistinguishedName")]
    public string? OnpremisesDistinguishedName { get; set; }

    /// <summary>The on-premises FQDN, also called dnsDomainName, synchronised from the on-premises directory when Azure AD Connect is used. The on-premise FQDN (i.e. dnsDomainName) of the user</summary>
    [JsonPropertyName("onpremisesDomainName")]
    public string? OnpremisesDomainName { get; set; }

    /// <summary>The value used to associate an on-premise Active Directory user account with their Azure AD user object. This must be specified if you are using a federated domain for the user's user_principal_name property when creating a new user account. The value used to associate an on-premise Active Directory user account with their Azure AD user object. This must be specified if you are using a federated domain for the user's `user_principal_name` property when creating a new user account</summary>
    [JsonPropertyName("onpremisesImmutableId")]
    public string? OnpremisesImmutableId { get; set; }

    /// <summary>The on-premise SAM account name of the user. The on-premise SAM account name of the user</summary>
    [JsonPropertyName("onpremisesSamAccountName")]
    public string? OnpremisesSamAccountName { get; set; }

    /// <summary>The on-premises security identifier (SID), synchronised from the on-premises directory when Azure AD Connect is used. The on-premise security identifier (SID) of the user</summary>
    [JsonPropertyName("onpremisesSecurityIdentifier")]
    public string? OnpremisesSecurityIdentifier { get; set; }

    /// <summary>Whether this user is synchronised from an on-premises directory (true), no longer synchronised (false), or has never been synchronised (null). Whether this user is synchronized from an on-premises directory (true), no longer synchronized (false), or has never been synchronized (null)</summary>
    [JsonPropertyName("onpremisesSyncEnabled")]
    public bool? OnpremisesSyncEnabled { get; set; }

    /// <summary>The on-premise user principal name of the user. The on-premise user principal name of the user</summary>
    [JsonPropertyName("onpremisesUserPrincipalName")]
    public string? OnpremisesUserPrincipalName { get; set; }

    /// <summary>A list of additional email addresses for the user. Additional email addresses for the user</summary>
    [JsonPropertyName("otherMails")]
    public IList<string>? OtherMails { get; set; }

    /// <summary>The postal code for the user's postal address. The postal code is specific to the user's country/region. In the United States of America, this attribute contains the ZIP code. The postal code for the user's postal address. The postal code is specific to the user's country/region. In the United States of America, this attribute contains the ZIP code</summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>The user's preferred language, in ISO 639-1 notation. The user's preferred language, in ISO 639-1 notation</summary>
    [JsonPropertyName("preferredLanguage")]
    public string? PreferredLanguage { get; set; }

    /// <summary>List of email addresses for the user that direct to the same mailbox. Email addresses for the user that direct to the same mailbox</summary>
    [JsonPropertyName("proxyAddresses")]
    public IList<string>? ProxyAddresses { get; set; }

    /// <summary>Whether or not the Outlook global address list should include this user. Defaults to true. Whether or not the Outlook global address list should include this user</summary>
    [JsonPropertyName("showInAddressList")]
    public bool? ShowInAddressList { get; set; }

    /// <summary>The state or province in the user's address. The state or province in the user's address</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The street address of the user's place of business. The street address of the user's place of business</summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }

    /// <summary>The user's surname (family name or last name). The user's surname (family name or last name)</summary>
    [JsonPropertyName("surname")]
    public string? Surname { get; set; }

    /// <summary>The usage location of the user. Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries. The usage location is a two letter country code (ISO standard 3166). Examples include: NO, JP, and GB. Cannot be reset to null once set. The usage location of the user. Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries. The usage location is a two letter country code (ISO standard 3166). Examples include: `NO`, `JP`, and `GB`. Cannot be reset to null once set</summary>
    [JsonPropertyName("usageLocation")]
    public string? UsageLocation { get; set; }

    /// <summary>The user principal name (UPN) of the user. The user principal name (UPN) of the user</summary>
    [JsonPropertyName("userPrincipalName")]
    public string? UserPrincipalName { get; set; }

    /// <summary>The user type in the directory. Possible values are Guest or Member. The user type in the directory. Possible values are `Guest` or `Member`</summary>
    [JsonPropertyName("userType")]
    public string? UserType { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserStatusConditions
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

/// <summary>UserStatus defines the observed state of User.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1UserStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1UserStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>User is the Schema for the Users API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1User : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1UserSpec>, IStatus<V1beta1UserStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "User";
    public const string KubeGroup = "users.azuread.upbound.io";
    public const string KubePluralName = "users";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>UserSpec defines the desired state of User</summary>
    [JsonPropertyName("spec")]
    public V1beta1UserSpec Spec { get; set; }

    /// <summary>UserStatus defines the observed state of User.</summary>
    [JsonPropertyName("status")]
    public V1beta1UserStatus? Status { get; set; }
}