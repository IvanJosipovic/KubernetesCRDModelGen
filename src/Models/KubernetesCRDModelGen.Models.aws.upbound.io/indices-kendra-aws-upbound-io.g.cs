using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kendra.aws.upbound.io;
/// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1IndexSpecDeletionPolicyEnum
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
public partial class V1beta1IndexSpecForProviderCapacityUnits
{
    /// <summary>The amount of extra query capacity for an index and GetQuerySuggestions capacity. For more information, refer to QueryCapacityUnits.</summary>
    [JsonPropertyName("queryCapacityUnits")]
    public double? QueryCapacityUnits { get; set; }

    /// <summary>The amount of extra storage capacity for an index. A single capacity unit provides 30 GB of storage space or 100,000 documents, whichever is reached first. Minimum value of 0.</summary>
    [JsonPropertyName("storageCapacityUnits")]
    public double? StorageCapacityUnits { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProviderDocumentMetadataConfigurationUpdatesRelevance
{
    /// <summary>Specifies the time period that the boost applies to. For more information, refer to Duration.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>Indicates that this field determines how "fresh" a document is. For more information, refer to Freshness.</summary>
    [JsonPropertyName("freshness")]
    public bool? Freshness { get; set; }

    /// <summary>The relative importance of the field in the search. Larger numbers provide more of a boost than smaller numbers. Minimum value of 1. Maximum value of 10.</summary>
    [JsonPropertyName("importance")]
    public double? Importance { get; set; }

    /// <summary>Determines how values should be interpreted. For more information, refer to RankOrder.</summary>
    [JsonPropertyName("rankOrder")]
    public string? RankOrder { get; set; }

    /// <summary>A list of values that should be given a different boost when they appear in the result list. For more information, refer to ValueImportanceMap.</summary>
    [JsonPropertyName("valuesImportanceMap")]
    public IDictionary<string, double>? ValuesImportanceMap { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProviderDocumentMetadataConfigurationUpdatesSearch
{
    /// <summary>Determines whether the field is returned in the query response. The default is true.</summary>
    [JsonPropertyName("displayable")]
    public bool? Displayable { get; set; }

    /// <summary>Indicates that the field can be used to create search facets, a count of results for each value in the field. The default is false.</summary>
    [JsonPropertyName("facetable")]
    public bool? Facetable { get; set; }

    /// <summary>Determines whether the field is used in the search. If the Searchable field is true, you can use relevance tuning to manually tune how Amazon Kendra weights the field in the search. The default is true for string fields and false for number and date fields.</summary>
    [JsonPropertyName("searchable")]
    public bool? Searchable { get; set; }

    /// <summary>Determines whether the field can be used to sort the results of a query. If you specify sorting on a field that does not have Sortable set to true, Amazon Kendra returns an exception. The default is false.</summary>
    [JsonPropertyName("sortable")]
    public bool? Sortable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProviderDocumentMetadataConfigurationUpdates
{
    /// <summary>The name of the index field. Minimum length of 1. Maximum length of 30.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A block that provides manual tuning parameters to determine how the field affects the search results. Detailed below</summary>
    [JsonPropertyName("relevance")]
    public IList<V1beta1IndexSpecForProviderDocumentMetadataConfigurationUpdatesRelevance>? Relevance { get; set; }

    /// <summary>A block that provides information about how the field is used during a search. Documented below. Detailed below</summary>
    [JsonPropertyName("search")]
    public IList<V1beta1IndexSpecForProviderDocumentMetadataConfigurationUpdatesSearch>? Search { get; set; }

    /// <summary>The data type of the index field. Valid values are STRING_VALUE, STRING_LIST_VALUE, LONG_VALUE, DATE_VALUE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1IndexSpecForProviderRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1IndexSpecForProviderRoleArnRefPolicyResolveEnum
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
public partial class V1beta1IndexSpecForProviderRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecForProviderRoleArnRefPolicyResolutionEnum>))]
    public V1beta1IndexSpecForProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecForProviderRoleArnRefPolicyResolveEnum>))]
    public V1beta1IndexSpecForProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IndexSpecForProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1IndexSpecForProviderRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1IndexSpecForProviderRoleArnSelectorPolicyResolveEnum
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
public partial class V1beta1IndexSpecForProviderRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecForProviderRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1IndexSpecForProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecForProviderRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1IndexSpecForProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IndexSpecForProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProviderServerSideEncryptionConfiguration
{
    /// <summary>The identifier of the AWS KMScustomer master key (CMK). Amazon Kendra doesn't support asymmetric CMKs.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProviderUserGroupResolutionConfiguration
{
    /// <summary>The identity store provider (mode) you want to use to fetch access levels of groups and users. AWS Single Sign-On is currently the only available mode. Your users and groups must exist in an AWS SSO identity source in order to use this mode. Valid Values are AWS_SSO or NONE.</summary>
    [JsonPropertyName("userGroupResolutionMode")]
    public string? UserGroupResolutionMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProviderUserTokenConfigurationsJsonTokenTypeConfiguration
{
    /// <summary>The group attribute field. Minimum length of 1. Maximum length of 2048.</summary>
    [JsonPropertyName("groupAttributeField")]
    public string? GroupAttributeField { get; set; }

    /// <summary>The user name attribute field. Minimum length of 1. Maximum length of 2048.</summary>
    [JsonPropertyName("userNameAttributeField")]
    public string? UserNameAttributeField { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProviderUserTokenConfigurationsJwtTokenTypeConfiguration
{
    /// <summary>The regular expression that identifies the claim. Minimum length of 1. Maximum length of 100.</summary>
    [JsonPropertyName("claimRegex")]
    public string? ClaimRegex { get; set; }

    /// <summary>The group attribute field. Minimum length of 1. Maximum length of 2048.</summary>
    [JsonPropertyName("groupAttributeField")]
    public string? GroupAttributeField { get; set; }

    /// <summary>The issuer of the token. Minimum length of 1. Maximum length of 65.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>The location of the key. Valid values are URL or SECRET_MANAGER</summary>
    [JsonPropertyName("keyLocation")]
    public string? KeyLocation { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the secret.</summary>
    [JsonPropertyName("secretsManagerArn")]
    public string? SecretsManagerArn { get; set; }

    /// <summary>The signing key URL. Valid pattern is ^(https?|ftp|file):\/\/([^\s]*)</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The user name attribute field. Minimum length of 1. Maximum length of 2048.</summary>
    [JsonPropertyName("userNameAttributeField")]
    public string? UserNameAttributeField { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProviderUserTokenConfigurations
{
    /// <summary>A block that specifies the information about the JSON token type configuration. Detailed below.</summary>
    [JsonPropertyName("jsonTokenTypeConfiguration")]
    public IList<V1beta1IndexSpecForProviderUserTokenConfigurationsJsonTokenTypeConfiguration>? JsonTokenTypeConfiguration { get; set; }

    /// <summary>A block that specifies the information about the JWT token type configuration. Detailed below.</summary>
    [JsonPropertyName("jwtTokenTypeConfiguration")]
    public IList<V1beta1IndexSpecForProviderUserTokenConfigurationsJwtTokenTypeConfiguration>? JwtTokenTypeConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProvider
{
    /// <summary>A block that sets the number of additional document storage and query capacity units that should be used by the index. Detailed below.</summary>
    [JsonPropertyName("capacityUnits")]
    public IList<V1beta1IndexSpecForProviderCapacityUnits>? CapacityUnits { get; set; }

    /// <summary>The description of the Index.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more blocks that specify the configuration settings for any metadata applied to the documents in the index. Minimum number of 0 items. Maximum number of 500 items. If specified, you must define all elements, including those that are provided by default. These index fields are documented at Amazon Kendra Index documentation. For an example resource that defines these default index fields, refer to the default example above. For an example resource that appends additional index fields, refer to the append example above. All arguments for each block must be specified. Note that blocks cannot be removed since index fields cannot be deleted. This argument is detailed below.</summary>
    [JsonPropertyName("documentMetadataConfigurationUpdates")]
    public IList<V1beta1IndexSpecForProviderDocumentMetadataConfigurationUpdates>? DocumentMetadataConfigurationUpdates { get; set; }

    /// <summary>The Amazon Kendra edition to use for the index. Choose DEVELOPER_EDITION for indexes intended for development, testing, or proof of concept. Use ENTERPRISE_EDITION for your production databases. Once you set the edition for an index, it can't be changed. Defaults to ENTERPRISE_EDITION</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>Specifies the name of the Index.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>An AWS Identity and Access Management (IAM) role that gives Amazon Kendra permissions to access your Amazon CloudWatch logs and metrics. This is also the role you use when you call the BatchPutDocument API to index documents from an Amazon S3 bucket.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1IndexSpecForProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1IndexSpecForProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>A block that specifies the identifier of the AWS KMS customer managed key (CMK) that's used to encrypt data indexed by Amazon Kendra. Amazon Kendra doesn't support asymmetric CMKs. Detailed below.</summary>
    [JsonPropertyName("serverSideEncryptionConfiguration")]
    public IList<V1beta1IndexSpecForProviderServerSideEncryptionConfiguration>? ServerSideEncryptionConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The user context policy. Valid values are ATTRIBUTE_FILTER or USER_TOKEN. For more information, refer to UserContextPolicy. Defaults to ATTRIBUTE_FILTER.</summary>
    [JsonPropertyName("userContextPolicy")]
    public string? UserContextPolicy { get; set; }

    /// <summary>A block that enables fetching access levels of groups and users from an AWS Single Sign-On identity source. To configure this, see UserGroupResolutionConfiguration. Detailed below.</summary>
    [JsonPropertyName("userGroupResolutionConfiguration")]
    public IList<V1beta1IndexSpecForProviderUserGroupResolutionConfiguration>? UserGroupResolutionConfiguration { get; set; }

    /// <summary>A block that specifies the user token configuration. Detailed below.</summary>
    [JsonPropertyName("userTokenConfigurations")]
    public IList<V1beta1IndexSpecForProviderUserTokenConfigurations>? UserTokenConfigurations { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderCapacityUnits
{
    /// <summary>The amount of extra query capacity for an index and GetQuerySuggestions capacity. For more information, refer to QueryCapacityUnits.</summary>
    [JsonPropertyName("queryCapacityUnits")]
    public double? QueryCapacityUnits { get; set; }

    /// <summary>The amount of extra storage capacity for an index. A single capacity unit provides 30 GB of storage space or 100,000 documents, whichever is reached first. Minimum value of 0.</summary>
    [JsonPropertyName("storageCapacityUnits")]
    public double? StorageCapacityUnits { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderDocumentMetadataConfigurationUpdatesRelevance
{
    /// <summary>Specifies the time period that the boost applies to. For more information, refer to Duration.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>Indicates that this field determines how "fresh" a document is. For more information, refer to Freshness.</summary>
    [JsonPropertyName("freshness")]
    public bool? Freshness { get; set; }

    /// <summary>The relative importance of the field in the search. Larger numbers provide more of a boost than smaller numbers. Minimum value of 1. Maximum value of 10.</summary>
    [JsonPropertyName("importance")]
    public double? Importance { get; set; }

    /// <summary>Determines how values should be interpreted. For more information, refer to RankOrder.</summary>
    [JsonPropertyName("rankOrder")]
    public string? RankOrder { get; set; }

    /// <summary>A list of values that should be given a different boost when they appear in the result list. For more information, refer to ValueImportanceMap.</summary>
    [JsonPropertyName("valuesImportanceMap")]
    public IDictionary<string, double>? ValuesImportanceMap { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderDocumentMetadataConfigurationUpdatesSearch
{
    /// <summary>Determines whether the field is returned in the query response. The default is true.</summary>
    [JsonPropertyName("displayable")]
    public bool? Displayable { get; set; }

    /// <summary>Indicates that the field can be used to create search facets, a count of results for each value in the field. The default is false.</summary>
    [JsonPropertyName("facetable")]
    public bool? Facetable { get; set; }

    /// <summary>Determines whether the field is used in the search. If the Searchable field is true, you can use relevance tuning to manually tune how Amazon Kendra weights the field in the search. The default is true for string fields and false for number and date fields.</summary>
    [JsonPropertyName("searchable")]
    public bool? Searchable { get; set; }

    /// <summary>Determines whether the field can be used to sort the results of a query. If you specify sorting on a field that does not have Sortable set to true, Amazon Kendra returns an exception. The default is false.</summary>
    [JsonPropertyName("sortable")]
    public bool? Sortable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderDocumentMetadataConfigurationUpdates
{
    /// <summary>The name of the index field. Minimum length of 1. Maximum length of 30.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A block that provides manual tuning parameters to determine how the field affects the search results. Detailed below</summary>
    [JsonPropertyName("relevance")]
    public IList<V1beta1IndexSpecInitProviderDocumentMetadataConfigurationUpdatesRelevance>? Relevance { get; set; }

    /// <summary>A block that provides information about how the field is used during a search. Documented below. Detailed below</summary>
    [JsonPropertyName("search")]
    public IList<V1beta1IndexSpecInitProviderDocumentMetadataConfigurationUpdatesSearch>? Search { get; set; }

    /// <summary>The data type of the index field. Valid values are STRING_VALUE, STRING_LIST_VALUE, LONG_VALUE, DATE_VALUE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1IndexSpecInitProviderRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1IndexSpecInitProviderRoleArnRefPolicyResolveEnum
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
public partial class V1beta1IndexSpecInitProviderRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecInitProviderRoleArnRefPolicyResolutionEnum>))]
    public V1beta1IndexSpecInitProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecInitProviderRoleArnRefPolicyResolveEnum>))]
    public V1beta1IndexSpecInitProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IndexSpecInitProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1IndexSpecInitProviderRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1IndexSpecInitProviderRoleArnSelectorPolicyResolveEnum
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
public partial class V1beta1IndexSpecInitProviderRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecInitProviderRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1IndexSpecInitProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecInitProviderRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1IndexSpecInitProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IndexSpecInitProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderServerSideEncryptionConfiguration
{
    /// <summary>The identifier of the AWS KMScustomer master key (CMK). Amazon Kendra doesn't support asymmetric CMKs.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderUserGroupResolutionConfiguration
{
    /// <summary>The identity store provider (mode) you want to use to fetch access levels of groups and users. AWS Single Sign-On is currently the only available mode. Your users and groups must exist in an AWS SSO identity source in order to use this mode. Valid Values are AWS_SSO or NONE.</summary>
    [JsonPropertyName("userGroupResolutionMode")]
    public string? UserGroupResolutionMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderUserTokenConfigurationsJsonTokenTypeConfiguration
{
    /// <summary>The group attribute field. Minimum length of 1. Maximum length of 2048.</summary>
    [JsonPropertyName("groupAttributeField")]
    public string? GroupAttributeField { get; set; }

    /// <summary>The user name attribute field. Minimum length of 1. Maximum length of 2048.</summary>
    [JsonPropertyName("userNameAttributeField")]
    public string? UserNameAttributeField { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderUserTokenConfigurationsJwtTokenTypeConfiguration
{
    /// <summary>The regular expression that identifies the claim. Minimum length of 1. Maximum length of 100.</summary>
    [JsonPropertyName("claimRegex")]
    public string? ClaimRegex { get; set; }

    /// <summary>The group attribute field. Minimum length of 1. Maximum length of 2048.</summary>
    [JsonPropertyName("groupAttributeField")]
    public string? GroupAttributeField { get; set; }

    /// <summary>The issuer of the token. Minimum length of 1. Maximum length of 65.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>The location of the key. Valid values are URL or SECRET_MANAGER</summary>
    [JsonPropertyName("keyLocation")]
    public string? KeyLocation { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the secret.</summary>
    [JsonPropertyName("secretsManagerArn")]
    public string? SecretsManagerArn { get; set; }

    /// <summary>The signing key URL. Valid pattern is ^(https?|ftp|file):\/\/([^\s]*)</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The user name attribute field. Minimum length of 1. Maximum length of 2048.</summary>
    [JsonPropertyName("userNameAttributeField")]
    public string? UserNameAttributeField { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderUserTokenConfigurations
{
    /// <summary>A block that specifies the information about the JSON token type configuration. Detailed below.</summary>
    [JsonPropertyName("jsonTokenTypeConfiguration")]
    public IList<V1beta1IndexSpecInitProviderUserTokenConfigurationsJsonTokenTypeConfiguration>? JsonTokenTypeConfiguration { get; set; }

    /// <summary>A block that specifies the information about the JWT token type configuration. Detailed below.</summary>
    [JsonPropertyName("jwtTokenTypeConfiguration")]
    public IList<V1beta1IndexSpecInitProviderUserTokenConfigurationsJwtTokenTypeConfiguration>? JwtTokenTypeConfiguration { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProvider
{
    /// <summary>A block that sets the number of additional document storage and query capacity units that should be used by the index. Detailed below.</summary>
    [JsonPropertyName("capacityUnits")]
    public IList<V1beta1IndexSpecInitProviderCapacityUnits>? CapacityUnits { get; set; }

    /// <summary>The description of the Index.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more blocks that specify the configuration settings for any metadata applied to the documents in the index. Minimum number of 0 items. Maximum number of 500 items. If specified, you must define all elements, including those that are provided by default. These index fields are documented at Amazon Kendra Index documentation. For an example resource that defines these default index fields, refer to the default example above. For an example resource that appends additional index fields, refer to the append example above. All arguments for each block must be specified. Note that blocks cannot be removed since index fields cannot be deleted. This argument is detailed below.</summary>
    [JsonPropertyName("documentMetadataConfigurationUpdates")]
    public IList<V1beta1IndexSpecInitProviderDocumentMetadataConfigurationUpdates>? DocumentMetadataConfigurationUpdates { get; set; }

    /// <summary>The Amazon Kendra edition to use for the index. Choose DEVELOPER_EDITION for indexes intended for development, testing, or proof of concept. Use ENTERPRISE_EDITION for your production databases. Once you set the edition for an index, it can't be changed. Defaults to ENTERPRISE_EDITION</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>Specifies the name of the Index.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>An AWS Identity and Access Management (IAM) role that gives Amazon Kendra permissions to access your Amazon CloudWatch logs and metrics. This is also the role you use when you call the BatchPutDocument API to index documents from an Amazon S3 bucket.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1IndexSpecInitProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1IndexSpecInitProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>A block that specifies the identifier of the AWS KMS customer managed key (CMK) that's used to encrypt data indexed by Amazon Kendra. Amazon Kendra doesn't support asymmetric CMKs. Detailed below.</summary>
    [JsonPropertyName("serverSideEncryptionConfiguration")]
    public IList<V1beta1IndexSpecInitProviderServerSideEncryptionConfiguration>? ServerSideEncryptionConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The user context policy. Valid values are ATTRIBUTE_FILTER or USER_TOKEN. For more information, refer to UserContextPolicy. Defaults to ATTRIBUTE_FILTER.</summary>
    [JsonPropertyName("userContextPolicy")]
    public string? UserContextPolicy { get; set; }

    /// <summary>A block that enables fetching access levels of groups and users from an AWS Single Sign-On identity source. To configure this, see UserGroupResolutionConfiguration. Detailed below.</summary>
    [JsonPropertyName("userGroupResolutionConfiguration")]
    public IList<V1beta1IndexSpecInitProviderUserGroupResolutionConfiguration>? UserGroupResolutionConfiguration { get; set; }

    /// <summary>A block that specifies the user token configuration. Detailed below.</summary>
    [JsonPropertyName("userTokenConfigurations")]
    public IList<V1beta1IndexSpecInitProviderUserTokenConfigurations>? UserTokenConfigurations { get; set; }
}

/// <summary>A ManagementAction represents an action that the Crossplane controllers can take on an external resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1IndexSpecManagementPoliciesEnum
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1IndexSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1IndexSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1IndexSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1IndexSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1IndexSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IndexSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1IndexSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1IndexSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1IndexSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1IndexSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1IndexSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IndexSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1IndexSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1IndexSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1IndexSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>IndexSpec defines the desired state of Index</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecDeletionPolicyEnum>))]
    public V1beta1IndexSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1IndexSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1IndexSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1IndexSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1IndexSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1IndexSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1IndexSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusAtProviderCapacityUnits
{
    /// <summary>The amount of extra query capacity for an index and GetQuerySuggestions capacity. For more information, refer to QueryCapacityUnits.</summary>
    [JsonPropertyName("queryCapacityUnits")]
    public double? QueryCapacityUnits { get; set; }

    /// <summary>The amount of extra storage capacity for an index. A single capacity unit provides 30 GB of storage space or 100,000 documents, whichever is reached first. Minimum value of 0.</summary>
    [JsonPropertyName("storageCapacityUnits")]
    public double? StorageCapacityUnits { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusAtProviderDocumentMetadataConfigurationUpdatesRelevance
{
    /// <summary>Specifies the time period that the boost applies to. For more information, refer to Duration.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>Indicates that this field determines how "fresh" a document is. For more information, refer to Freshness.</summary>
    [JsonPropertyName("freshness")]
    public bool? Freshness { get; set; }

    /// <summary>The relative importance of the field in the search. Larger numbers provide more of a boost than smaller numbers. Minimum value of 1. Maximum value of 10.</summary>
    [JsonPropertyName("importance")]
    public double? Importance { get; set; }

    /// <summary>Determines how values should be interpreted. For more information, refer to RankOrder.</summary>
    [JsonPropertyName("rankOrder")]
    public string? RankOrder { get; set; }

    /// <summary>A list of values that should be given a different boost when they appear in the result list. For more information, refer to ValueImportanceMap.</summary>
    [JsonPropertyName("valuesImportanceMap")]
    public IDictionary<string, double>? ValuesImportanceMap { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusAtProviderDocumentMetadataConfigurationUpdatesSearch
{
    /// <summary>Determines whether the field is returned in the query response. The default is true.</summary>
    [JsonPropertyName("displayable")]
    public bool? Displayable { get; set; }

    /// <summary>Indicates that the field can be used to create search facets, a count of results for each value in the field. The default is false.</summary>
    [JsonPropertyName("facetable")]
    public bool? Facetable { get; set; }

    /// <summary>Determines whether the field is used in the search. If the Searchable field is true, you can use relevance tuning to manually tune how Amazon Kendra weights the field in the search. The default is true for string fields and false for number and date fields.</summary>
    [JsonPropertyName("searchable")]
    public bool? Searchable { get; set; }

    /// <summary>Determines whether the field can be used to sort the results of a query. If you specify sorting on a field that does not have Sortable set to true, Amazon Kendra returns an exception. The default is false.</summary>
    [JsonPropertyName("sortable")]
    public bool? Sortable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusAtProviderDocumentMetadataConfigurationUpdates
{
    /// <summary>The name of the index field. Minimum length of 1. Maximum length of 30.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A block that provides manual tuning parameters to determine how the field affects the search results. Detailed below</summary>
    [JsonPropertyName("relevance")]
    public IList<V1beta1IndexStatusAtProviderDocumentMetadataConfigurationUpdatesRelevance>? Relevance { get; set; }

    /// <summary>A block that provides information about how the field is used during a search. Documented below. Detailed below</summary>
    [JsonPropertyName("search")]
    public IList<V1beta1IndexStatusAtProviderDocumentMetadataConfigurationUpdatesSearch>? Search { get; set; }

    /// <summary>The data type of the index field. Valid values are STRING_VALUE, STRING_LIST_VALUE, LONG_VALUE, DATE_VALUE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusAtProviderIndexStatisticsFaqStatistics
{
    /// <summary>The total number of FAQ questions and answers contained in the index.</summary>
    [JsonPropertyName("indexedQuestionAnswersCount")]
    public double? IndexedQuestionAnswersCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusAtProviderIndexStatisticsTextDocumentStatistics
{
    /// <summary>The total size, in bytes, of the indexed documents.</summary>
    [JsonPropertyName("indexedTextBytes")]
    public double? IndexedTextBytes { get; set; }

    /// <summary>The number of text documents indexed.</summary>
    [JsonPropertyName("indexedTextDocumentsCount")]
    public double? IndexedTextDocumentsCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusAtProviderIndexStatistics
{
    /// <summary>A block that specifies the number of question and answer topics in the index. Detailed below.</summary>
    [JsonPropertyName("faqStatistics")]
    public IList<V1beta1IndexStatusAtProviderIndexStatisticsFaqStatistics>? FaqStatistics { get; set; }

    /// <summary>A block that specifies the number of text documents indexed. Detailed below.</summary>
    [JsonPropertyName("textDocumentStatistics")]
    public IList<V1beta1IndexStatusAtProviderIndexStatisticsTextDocumentStatistics>? TextDocumentStatistics { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusAtProviderServerSideEncryptionConfiguration
{
    /// <summary>The identifier of the AWS KMScustomer master key (CMK). Amazon Kendra doesn't support asymmetric CMKs.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusAtProviderUserGroupResolutionConfiguration
{
    /// <summary>The identity store provider (mode) you want to use to fetch access levels of groups and users. AWS Single Sign-On is currently the only available mode. Your users and groups must exist in an AWS SSO identity source in order to use this mode. Valid Values are AWS_SSO or NONE.</summary>
    [JsonPropertyName("userGroupResolutionMode")]
    public string? UserGroupResolutionMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusAtProviderUserTokenConfigurationsJsonTokenTypeConfiguration
{
    /// <summary>The group attribute field. Minimum length of 1. Maximum length of 2048.</summary>
    [JsonPropertyName("groupAttributeField")]
    public string? GroupAttributeField { get; set; }

    /// <summary>The user name attribute field. Minimum length of 1. Maximum length of 2048.</summary>
    [JsonPropertyName("userNameAttributeField")]
    public string? UserNameAttributeField { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusAtProviderUserTokenConfigurationsJwtTokenTypeConfiguration
{
    /// <summary>The regular expression that identifies the claim. Minimum length of 1. Maximum length of 100.</summary>
    [JsonPropertyName("claimRegex")]
    public string? ClaimRegex { get; set; }

    /// <summary>The group attribute field. Minimum length of 1. Maximum length of 2048.</summary>
    [JsonPropertyName("groupAttributeField")]
    public string? GroupAttributeField { get; set; }

    /// <summary>The issuer of the token. Minimum length of 1. Maximum length of 65.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>The location of the key. Valid values are URL or SECRET_MANAGER</summary>
    [JsonPropertyName("keyLocation")]
    public string? KeyLocation { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the secret.</summary>
    [JsonPropertyName("secretsManagerArn")]
    public string? SecretsManagerArn { get; set; }

    /// <summary>The signing key URL. Valid pattern is ^(https?|ftp|file):\/\/([^\s]*)</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The user name attribute field. Minimum length of 1. Maximum length of 2048.</summary>
    [JsonPropertyName("userNameAttributeField")]
    public string? UserNameAttributeField { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusAtProviderUserTokenConfigurations
{
    /// <summary>A block that specifies the information about the JSON token type configuration. Detailed below.</summary>
    [JsonPropertyName("jsonTokenTypeConfiguration")]
    public IList<V1beta1IndexStatusAtProviderUserTokenConfigurationsJsonTokenTypeConfiguration>? JsonTokenTypeConfiguration { get; set; }

    /// <summary>A block that specifies the information about the JWT token type configuration. Detailed below.</summary>
    [JsonPropertyName("jwtTokenTypeConfiguration")]
    public IList<V1beta1IndexStatusAtProviderUserTokenConfigurationsJwtTokenTypeConfiguration>? JwtTokenTypeConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) of the Index.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A block that sets the number of additional document storage and query capacity units that should be used by the index. Detailed below.</summary>
    [JsonPropertyName("capacityUnits")]
    public IList<V1beta1IndexStatusAtProviderCapacityUnits>? CapacityUnits { get; set; }

    /// <summary>The Unix datetime that the index was created.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>The description of the Index.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more blocks that specify the configuration settings for any metadata applied to the documents in the index. Minimum number of 0 items. Maximum number of 500 items. If specified, you must define all elements, including those that are provided by default. These index fields are documented at Amazon Kendra Index documentation. For an example resource that defines these default index fields, refer to the default example above. For an example resource that appends additional index fields, refer to the append example above. All arguments for each block must be specified. Note that blocks cannot be removed since index fields cannot be deleted. This argument is detailed below.</summary>
    [JsonPropertyName("documentMetadataConfigurationUpdates")]
    public IList<V1beta1IndexStatusAtProviderDocumentMetadataConfigurationUpdates>? DocumentMetadataConfigurationUpdates { get; set; }

    /// <summary>The Amazon Kendra edition to use for the index. Choose DEVELOPER_EDITION for indexes intended for development, testing, or proof of concept. Use ENTERPRISE_EDITION for your production databases. Once you set the edition for an index, it can't be changed. Defaults to ENTERPRISE_EDITION</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>When the Status field value is FAILED, this contains a message that explains why.</summary>
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary>The identifier of the Index.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A block that provides information about the number of FAQ questions and answers and the number of text documents indexed. Detailed below.</summary>
    [JsonPropertyName("indexStatistics")]
    public IList<V1beta1IndexStatusAtProviderIndexStatistics>? IndexStatistics { get; set; }

    /// <summary>Specifies the name of the Index.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>An AWS Identity and Access Management (IAM) role that gives Amazon Kendra permissions to access your Amazon CloudWatch logs and metrics. This is also the role you use when you call the BatchPutDocument API to index documents from an Amazon S3 bucket.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A block that specifies the identifier of the AWS KMS customer managed key (CMK) that's used to encrypt data indexed by Amazon Kendra. Amazon Kendra doesn't support asymmetric CMKs. Detailed below.</summary>
    [JsonPropertyName("serverSideEncryptionConfiguration")]
    public IList<V1beta1IndexStatusAtProviderServerSideEncryptionConfiguration>? ServerSideEncryptionConfiguration { get; set; }

    /// <summary>The current status of the index. When the value is ACTIVE, the index is ready for use. If the Status field value is FAILED, the error_message field contains a message that explains why.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The Unix datetime that the index was last updated.</summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }

    /// <summary>The user context policy. Valid values are ATTRIBUTE_FILTER or USER_TOKEN. For more information, refer to UserContextPolicy. Defaults to ATTRIBUTE_FILTER.</summary>
    [JsonPropertyName("userContextPolicy")]
    public string? UserContextPolicy { get; set; }

    /// <summary>A block that enables fetching access levels of groups and users from an AWS Single Sign-On identity source. To configure this, see UserGroupResolutionConfiguration. Detailed below.</summary>
    [JsonPropertyName("userGroupResolutionConfiguration")]
    public IList<V1beta1IndexStatusAtProviderUserGroupResolutionConfiguration>? UserGroupResolutionConfiguration { get; set; }

    /// <summary>A block that specifies the user token configuration. Detailed below.</summary>
    [JsonPropertyName("userTokenConfigurations")]
    public IList<V1beta1IndexStatusAtProviderUserTokenConfigurations>? UserTokenConfigurations { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusConditions
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

/// <summary>IndexStatus defines the observed state of Index.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1IndexStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IndexStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Index is the Schema for the Indexs API. Provides an Amazon Kendra Index resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Index : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IndexSpec>, IStatus<V1beta1IndexStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Index";
    public const string KubeGroup = "kendra.aws.upbound.io";
    public const string KubePluralName = "indices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IndexSpec defines the desired state of Index</summary>
    [JsonPropertyName("spec")]
    public V1beta1IndexSpec Spec { get; set; }

    /// <summary>IndexStatus defines the observed state of Index.</summary>
    [JsonPropertyName("status")]
    public V1beta1IndexStatus? Status { get; set; }
}