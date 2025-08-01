using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.identitystore.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecForProviderAddresses
{
    /// <summary>The country that this address is in.</summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>The name that is typically displayed when the address is shown for display.</summary>
    [JsonPropertyName("formatted")]
    public string? Formatted { get; set; }

    /// <summary>The address locality.</summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>The postal code of the address.</summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>When true, this is the primary address associated with the user.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The region of the address.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The street of the address.</summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }

    /// <summary>The type of address.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecForProviderEmails
{
    /// <summary>When true, this is the primary email associated with the user.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The type of email.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The email address. This value must be unique across the identity store.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecForProviderName
{
    /// <summary>The family name of the user.</summary>
    [JsonPropertyName("familyName")]
    public string? FamilyName { get; set; }

    /// <summary>The name that is typically displayed when the name is shown for display.</summary>
    [JsonPropertyName("formatted")]
    public string? Formatted { get; set; }

    /// <summary>The given name of the user.</summary>
    [JsonPropertyName("givenName")]
    public string? GivenName { get; set; }

    /// <summary>The honorific prefix of the user.</summary>
    [JsonPropertyName("honorificPrefix")]
    public string? HonorificPrefix { get; set; }

    /// <summary>The honorific suffix of the user.</summary>
    [JsonPropertyName("honorificSuffix")]
    public string? HonorificSuffix { get; set; }

    /// <summary>The middle name of the user.</summary>
    [JsonPropertyName("middleName")]
    public string? MiddleName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecForProviderPhoneNumbers
{
    /// <summary>When true, this is the primary phone number associated with the user.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The type of phone number.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The user's phone number.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecForProvider
{
    /// <summary>Details about the user's address. At most 1 address is allowed. Detailed below.</summary>
    [JsonPropertyName("addresses")]
    public IList<V1beta1UserSpecForProviderAddresses>? Addresses { get; set; }

    /// <summary>The name that is typically displayed when the user is referenced.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Details about the user's email. At most 1 email is allowed. Detailed below.</summary>
    [JsonPropertyName("emails")]
    public IList<V1beta1UserSpecForProviderEmails>? Emails { get; set; }

    /// <summary>The globally unique identifier for the identity store that this user is in.</summary>
    [JsonPropertyName("identityStoreId")]
    public string IdentityStoreId { get; set; }

    /// <summary>The user's geographical region or location.</summary>
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    /// <summary>Details about the user's full name. Detailed below.</summary>
    [JsonPropertyName("name")]
    public IList<V1beta1UserSpecForProviderName>? Name { get; set; }

    /// <summary>An alternate name for the user.</summary>
    [JsonPropertyName("nickname")]
    public string? Nickname { get; set; }

    /// <summary>Details about the user's phone number. At most 1 phone number is allowed. Detailed below.</summary>
    [JsonPropertyName("phoneNumbers")]
    public IList<V1beta1UserSpecForProviderPhoneNumbers>? PhoneNumbers { get; set; }

    /// <summary>The preferred language of the user.</summary>
    [JsonPropertyName("preferredLanguage")]
    public string? PreferredLanguage { get; set; }

    /// <summary>An URL that may be associated with the user.</summary>
    [JsonPropertyName("profileUrl")]
    public string? ProfileUrl { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The user's time zone.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>The user's title.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>A unique string used to identify the user. This value can consist of letters, accented characters, symbols, numbers, and punctuation. This value is specified at the time the user is created and stored as an attribute of the user object in the identity store. The limit is 128 characters.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }

    /// <summary>The user type.</summary>
    [JsonPropertyName("userType")]
    public string? UserType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecInitProviderAddresses
{
    /// <summary>The country that this address is in.</summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>The name that is typically displayed when the address is shown for display.</summary>
    [JsonPropertyName("formatted")]
    public string? Formatted { get; set; }

    /// <summary>The address locality.</summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>The postal code of the address.</summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>When true, this is the primary address associated with the user.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The street of the address.</summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }

    /// <summary>The type of address.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecInitProviderEmails
{
    /// <summary>When true, this is the primary email associated with the user.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The type of email.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The email address. This value must be unique across the identity store.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecInitProviderName
{
    /// <summary>The family name of the user.</summary>
    [JsonPropertyName("familyName")]
    public string? FamilyName { get; set; }

    /// <summary>The name that is typically displayed when the name is shown for display.</summary>
    [JsonPropertyName("formatted")]
    public string? Formatted { get; set; }

    /// <summary>The given name of the user.</summary>
    [JsonPropertyName("givenName")]
    public string? GivenName { get; set; }

    /// <summary>The honorific prefix of the user.</summary>
    [JsonPropertyName("honorificPrefix")]
    public string? HonorificPrefix { get; set; }

    /// <summary>The honorific suffix of the user.</summary>
    [JsonPropertyName("honorificSuffix")]
    public string? HonorificSuffix { get; set; }

    /// <summary>The middle name of the user.</summary>
    [JsonPropertyName("middleName")]
    public string? MiddleName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecInitProviderPhoneNumbers
{
    /// <summary>When true, this is the primary phone number associated with the user.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The type of phone number.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The user's phone number.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecInitProvider
{
    /// <summary>Details about the user's address. At most 1 address is allowed. Detailed below.</summary>
    [JsonPropertyName("addresses")]
    public IList<V1beta1UserSpecInitProviderAddresses>? Addresses { get; set; }

    /// <summary>The name that is typically displayed when the user is referenced.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Details about the user's email. At most 1 email is allowed. Detailed below.</summary>
    [JsonPropertyName("emails")]
    public IList<V1beta1UserSpecInitProviderEmails>? Emails { get; set; }

    /// <summary>The user's geographical region or location.</summary>
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    /// <summary>Details about the user's full name. Detailed below.</summary>
    [JsonPropertyName("name")]
    public IList<V1beta1UserSpecInitProviderName>? Name { get; set; }

    /// <summary>An alternate name for the user.</summary>
    [JsonPropertyName("nickname")]
    public string? Nickname { get; set; }

    /// <summary>Details about the user's phone number. At most 1 phone number is allowed. Detailed below.</summary>
    [JsonPropertyName("phoneNumbers")]
    public IList<V1beta1UserSpecInitProviderPhoneNumbers>? PhoneNumbers { get; set; }

    /// <summary>The preferred language of the user.</summary>
    [JsonPropertyName("preferredLanguage")]
    public string? PreferredLanguage { get; set; }

    /// <summary>An URL that may be associated with the user.</summary>
    [JsonPropertyName("profileUrl")]
    public string? ProfileUrl { get; set; }

    /// <summary>The user's time zone.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>The user's title.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>A unique string used to identify the user. This value can consist of letters, accented characters, symbols, numbers, and punctuation. This value is specified at the time the user is created and stored as an attribute of the user object in the identity store. The limit is 128 characters.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }

    /// <summary>The user type.</summary>
    [JsonPropertyName("userType")]
    public string? UserType { get; set; }
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
public partial class V1beta1UserStatusAtProviderAddresses
{
    /// <summary>The country that this address is in.</summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>The name that is typically displayed when the address is shown for display.</summary>
    [JsonPropertyName("formatted")]
    public string? Formatted { get; set; }

    /// <summary>The address locality.</summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>The postal code of the address.</summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>When true, this is the primary address associated with the user.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The region of the address.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The street of the address.</summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }

    /// <summary>The type of address.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserStatusAtProviderEmails
{
    /// <summary>When true, this is the primary email associated with the user.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The type of email.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The email address. This value must be unique across the identity store.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserStatusAtProviderExternalIds
{
    /// <summary>The identifier issued to this resource by an external identity provider.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The issuer for an external identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserStatusAtProviderName
{
    /// <summary>The family name of the user.</summary>
    [JsonPropertyName("familyName")]
    public string? FamilyName { get; set; }

    /// <summary>The name that is typically displayed when the name is shown for display.</summary>
    [JsonPropertyName("formatted")]
    public string? Formatted { get; set; }

    /// <summary>The given name of the user.</summary>
    [JsonPropertyName("givenName")]
    public string? GivenName { get; set; }

    /// <summary>The honorific prefix of the user.</summary>
    [JsonPropertyName("honorificPrefix")]
    public string? HonorificPrefix { get; set; }

    /// <summary>The honorific suffix of the user.</summary>
    [JsonPropertyName("honorificSuffix")]
    public string? HonorificSuffix { get; set; }

    /// <summary>The middle name of the user.</summary>
    [JsonPropertyName("middleName")]
    public string? MiddleName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserStatusAtProviderPhoneNumbers
{
    /// <summary>When true, this is the primary phone number associated with the user.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The type of phone number.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The user's phone number.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserStatusAtProvider
{
    /// <summary>Details about the user's address. At most 1 address is allowed. Detailed below.</summary>
    [JsonPropertyName("addresses")]
    public IList<V1beta1UserStatusAtProviderAddresses>? Addresses { get; set; }

    /// <summary>The name that is typically displayed when the user is referenced.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Details about the user's email. At most 1 email is allowed. Detailed below.</summary>
    [JsonPropertyName("emails")]
    public IList<V1beta1UserStatusAtProviderEmails>? Emails { get; set; }

    /// <summary>A list of identifiers issued to this resource by an external identity provider.</summary>
    [JsonPropertyName("externalIds")]
    public IList<V1beta1UserStatusAtProviderExternalIds>? ExternalIds { get; set; }

    /// <summary>The identifier issued to this resource by an external identity provider.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The globally unique identifier for the identity store that this user is in.</summary>
    [JsonPropertyName("identityStoreId")]
    public string? IdentityStoreId { get; set; }

    /// <summary>The user's geographical region or location.</summary>
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    /// <summary>Details about the user's full name. Detailed below.</summary>
    [JsonPropertyName("name")]
    public IList<V1beta1UserStatusAtProviderName>? Name { get; set; }

    /// <summary>An alternate name for the user.</summary>
    [JsonPropertyName("nickname")]
    public string? Nickname { get; set; }

    /// <summary>Details about the user's phone number. At most 1 phone number is allowed. Detailed below.</summary>
    [JsonPropertyName("phoneNumbers")]
    public IList<V1beta1UserStatusAtProviderPhoneNumbers>? PhoneNumbers { get; set; }

    /// <summary>The preferred language of the user.</summary>
    [JsonPropertyName("preferredLanguage")]
    public string? PreferredLanguage { get; set; }

    /// <summary>An URL that may be associated with the user.</summary>
    [JsonPropertyName("profileUrl")]
    public string? ProfileUrl { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The user's time zone.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>The user's title.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>The identifier for this user in the identity store.</summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>A unique string used to identify the user. This value can consist of letters, accented characters, symbols, numbers, and punctuation. This value is specified at the time the user is created and stored as an attribute of the user object in the identity store. The limit is 128 characters.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }

    /// <summary>The user type.</summary>
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
    public const string KubeGroup = "identitystore.aws.upbound.io";
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

/// <summary>User is the Schema for the Users API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1UserList : IKubernetesObject<V1ListMeta>, IItems<V1beta1User>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "UserList";
    public const string KubeGroup = "identitystore.aws.upbound.io";
    public const string KubePluralName = "users";
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
    public IList<V1beta1User> Items { get; set; }
}