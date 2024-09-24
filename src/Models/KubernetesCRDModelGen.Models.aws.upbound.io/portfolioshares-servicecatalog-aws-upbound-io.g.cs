using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicecatalog.aws.upbound.io;
public enum V1beta1PortfolioShareSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1PortfolioShareSpecForProviderPortfolioIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PortfolioShareSpecForProviderPortfolioIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PortfolioShareSpecForProviderPortfolioIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PortfolioShareSpecForProviderPortfolioIdRefPolicyResolutionEnum>))]
    public V1beta1PortfolioShareSpecForProviderPortfolioIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PortfolioShareSpecForProviderPortfolioIdRefPolicyResolveEnum>))]
    public V1beta1PortfolioShareSpecForProviderPortfolioIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Portfolio in servicecatalog to populate portfolioId.</summary>
public partial class V1beta1PortfolioShareSpecForProviderPortfolioIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PortfolioShareSpecForProviderPortfolioIdRefPolicy? Policy { get; set; }
}

public enum V1beta1PortfolioShareSpecForProviderPortfolioIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PortfolioShareSpecForProviderPortfolioIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PortfolioShareSpecForProviderPortfolioIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PortfolioShareSpecForProviderPortfolioIdSelectorPolicyResolutionEnum>))]
    public V1beta1PortfolioShareSpecForProviderPortfolioIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PortfolioShareSpecForProviderPortfolioIdSelectorPolicyResolveEnum>))]
    public V1beta1PortfolioShareSpecForProviderPortfolioIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Portfolio in servicecatalog to populate portfolioId.</summary>
public partial class V1beta1PortfolioShareSpecForProviderPortfolioIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PortfolioShareSpecForProviderPortfolioIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1PortfolioShareSpecForProvider
{
    /// <summary>Language code. Valid values: en (English), jp (Japanese), zh (Chinese). Default value is en.</summary>
    [JsonPropertyName("acceptLanguage")]
    public string? AcceptLanguage { get; set; }

    /// <summary>Portfolio identifier.</summary>
    [JsonPropertyName("portfolioId")]
    public string? PortfolioId { get; set; }

    /// <summary>Reference to a Portfolio in servicecatalog to populate portfolioId.</summary>
    [JsonPropertyName("portfolioIdRef")]
    public V1beta1PortfolioShareSpecForProviderPortfolioIdRef? PortfolioIdRef { get; set; }

    /// <summary>Selector for a Portfolio in servicecatalog to populate portfolioId.</summary>
    [JsonPropertyName("portfolioIdSelector")]
    public V1beta1PortfolioShareSpecForProviderPortfolioIdSelector? PortfolioIdSelector { get; set; }

    /// <summary>Identifier of the principal with whom you will share the portfolio. Valid values AWS account IDs and ARNs of AWS Organizations and organizational units.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Enables or disables Principal sharing when creating the portfolio share. If this flag is not provided, principal sharing is disabled.</summary>
    [JsonPropertyName("sharePrincipals")]
    public bool? SharePrincipals { get; set; }

    /// <summary>Whether to enable sharing of aws_servicecatalog_tag_option resources when creating the portfolio share.</summary>
    [JsonPropertyName("shareTagOptions")]
    public bool? ShareTagOptions { get; set; }

    /// <summary>Type of portfolio share. Valid values are ACCOUNT (an external account), ORGANIZATION (a share to every account in an organization), ORGANIZATIONAL_UNIT, ORGANIZATION_MEMBER_ACCOUNT (a share to an account in an organization).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Whether to wait (up to the timeout) for the share to be accepted. Organizational shares are automatically accepted.</summary>
    [JsonPropertyName("waitForAcceptance")]
    public bool? WaitForAcceptance { get; set; }
}

public enum V1beta1PortfolioShareSpecInitProviderPortfolioIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PortfolioShareSpecInitProviderPortfolioIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PortfolioShareSpecInitProviderPortfolioIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PortfolioShareSpecInitProviderPortfolioIdRefPolicyResolutionEnum>))]
    public V1beta1PortfolioShareSpecInitProviderPortfolioIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PortfolioShareSpecInitProviderPortfolioIdRefPolicyResolveEnum>))]
    public V1beta1PortfolioShareSpecInitProviderPortfolioIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Portfolio in servicecatalog to populate portfolioId.</summary>
public partial class V1beta1PortfolioShareSpecInitProviderPortfolioIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PortfolioShareSpecInitProviderPortfolioIdRefPolicy? Policy { get; set; }
}

public enum V1beta1PortfolioShareSpecInitProviderPortfolioIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PortfolioShareSpecInitProviderPortfolioIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PortfolioShareSpecInitProviderPortfolioIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PortfolioShareSpecInitProviderPortfolioIdSelectorPolicyResolutionEnum>))]
    public V1beta1PortfolioShareSpecInitProviderPortfolioIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PortfolioShareSpecInitProviderPortfolioIdSelectorPolicyResolveEnum>))]
    public V1beta1PortfolioShareSpecInitProviderPortfolioIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Portfolio in servicecatalog to populate portfolioId.</summary>
public partial class V1beta1PortfolioShareSpecInitProviderPortfolioIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PortfolioShareSpecInitProviderPortfolioIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1PortfolioShareSpecInitProvider
{
    /// <summary>Language code. Valid values: en (English), jp (Japanese), zh (Chinese). Default value is en.</summary>
    [JsonPropertyName("acceptLanguage")]
    public string? AcceptLanguage { get; set; }

    /// <summary>Portfolio identifier.</summary>
    [JsonPropertyName("portfolioId")]
    public string? PortfolioId { get; set; }

    /// <summary>Reference to a Portfolio in servicecatalog to populate portfolioId.</summary>
    [JsonPropertyName("portfolioIdRef")]
    public V1beta1PortfolioShareSpecInitProviderPortfolioIdRef? PortfolioIdRef { get; set; }

    /// <summary>Selector for a Portfolio in servicecatalog to populate portfolioId.</summary>
    [JsonPropertyName("portfolioIdSelector")]
    public V1beta1PortfolioShareSpecInitProviderPortfolioIdSelector? PortfolioIdSelector { get; set; }

    /// <summary>Identifier of the principal with whom you will share the portfolio. Valid values AWS account IDs and ARNs of AWS Organizations and organizational units.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>Enables or disables Principal sharing when creating the portfolio share. If this flag is not provided, principal sharing is disabled.</summary>
    [JsonPropertyName("sharePrincipals")]
    public bool? SharePrincipals { get; set; }

    /// <summary>Whether to enable sharing of aws_servicecatalog_tag_option resources when creating the portfolio share.</summary>
    [JsonPropertyName("shareTagOptions")]
    public bool? ShareTagOptions { get; set; }

    /// <summary>Type of portfolio share. Valid values are ACCOUNT (an external account), ORGANIZATION (a share to every account in an organization), ORGANIZATIONAL_UNIT, ORGANIZATION_MEMBER_ACCOUNT (a share to an account in an organization).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Whether to wait (up to the timeout) for the share to be accepted. Organizational shares are automatically accepted.</summary>
    [JsonPropertyName("waitForAcceptance")]
    public bool? WaitForAcceptance { get; set; }
}

public enum V1beta1PortfolioShareSpecManagementPoliciesEnum
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

public enum V1beta1PortfolioShareSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PortfolioShareSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PortfolioShareSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PortfolioShareSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1PortfolioShareSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PortfolioShareSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1PortfolioShareSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1PortfolioShareSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PortfolioShareSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1PortfolioShareSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PortfolioShareSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PortfolioShareSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PortfolioShareSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1PortfolioShareSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PortfolioShareSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1PortfolioShareSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1PortfolioShareSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PortfolioShareSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1PortfolioShareSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1PortfolioShareSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1PortfolioShareSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1PortfolioShareSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1PortfolioShareSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>PortfolioShareSpec defines the desired state of PortfolioShare</summary>
public partial class V1beta1PortfolioShareSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PortfolioShareSpecDeletionPolicyEnum>))]
    public V1beta1PortfolioShareSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PortfolioShareSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PortfolioShareSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PortfolioShareSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PortfolioShareSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1PortfolioShareSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PortfolioShareSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1PortfolioShareStatusAtProvider
{
    /// <summary>Language code. Valid values: en (English), jp (Japanese), zh (Chinese). Default value is en.</summary>
    [JsonPropertyName("acceptLanguage")]
    public string? AcceptLanguage { get; set; }

    /// <summary>Whether the shared portfolio is imported by the recipient account. If the recipient is organizational, the share is automatically imported, and the field is always set to true.</summary>
    [JsonPropertyName("accepted")]
    public bool? Accepted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Portfolio identifier.</summary>
    [JsonPropertyName("portfolioId")]
    public string? PortfolioId { get; set; }

    /// <summary>Identifier of the principal with whom you will share the portfolio. Valid values AWS account IDs and ARNs of AWS Organizations and organizational units.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>Enables or disables Principal sharing when creating the portfolio share. If this flag is not provided, principal sharing is disabled.</summary>
    [JsonPropertyName("sharePrincipals")]
    public bool? SharePrincipals { get; set; }

    /// <summary>Whether to enable sharing of aws_servicecatalog_tag_option resources when creating the portfolio share.</summary>
    [JsonPropertyName("shareTagOptions")]
    public bool? ShareTagOptions { get; set; }

    /// <summary>Type of portfolio share. Valid values are ACCOUNT (an external account), ORGANIZATION (a share to every account in an organization), ORGANIZATIONAL_UNIT, ORGANIZATION_MEMBER_ACCOUNT (a share to an account in an organization).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Whether to wait (up to the timeout) for the share to be accepted. Organizational shares are automatically accepted.</summary>
    [JsonPropertyName("waitForAcceptance")]
    public bool? WaitForAcceptance { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1PortfolioShareStatusConditions
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

/// <summary>PortfolioShareStatus defines the observed state of PortfolioShare.</summary>
public partial class V1beta1PortfolioShareStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PortfolioShareStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PortfolioShareStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>PortfolioShare is the Schema for the PortfolioShares API. Manages a Service Catalog Portfolio Share</summary>
public partial class V1beta1PortfolioShare : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PortfolioShareSpec>, IStatus<V1beta1PortfolioShareStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PortfolioShare";
    public const string KubeGroup = "servicecatalog.aws.upbound.io";
    public const string KubePluralName = "portfolioshares";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PortfolioShareSpec defines the desired state of PortfolioShare</summary>
    [JsonPropertyName("spec")]
    public V1beta1PortfolioShareSpec Spec { get; set; }

    /// <summary>PortfolioShareStatus defines the observed state of PortfolioShare.</summary>
    [JsonPropertyName("status")]
    public V1beta1PortfolioShareStatus? Status { get; set; }
}