using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cognitoidentity.aws.upbound.io;
public enum V1beta1PoolRolesAttachmentSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1PoolRolesAttachmentSpecForProviderIdentityPoolIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PoolRolesAttachmentSpecForProviderIdentityPoolIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PoolRolesAttachmentSpecForProviderIdentityPoolIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PoolRolesAttachmentSpecForProviderIdentityPoolIdRefPolicyResolutionEnum>))]
    public V1beta1PoolRolesAttachmentSpecForProviderIdentityPoolIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PoolRolesAttachmentSpecForProviderIdentityPoolIdRefPolicyResolveEnum>))]
    public V1beta1PoolRolesAttachmentSpecForProviderIdentityPoolIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PoolRolesAttachmentSpecForProviderIdentityPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PoolRolesAttachmentSpecForProviderIdentityPoolIdRefPolicy? Policy { get; set; }
}

public enum V1beta1PoolRolesAttachmentSpecForProviderIdentityPoolIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PoolRolesAttachmentSpecForProviderIdentityPoolIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PoolRolesAttachmentSpecForProviderIdentityPoolIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PoolRolesAttachmentSpecForProviderIdentityPoolIdSelectorPolicyResolutionEnum>))]
    public V1beta1PoolRolesAttachmentSpecForProviderIdentityPoolIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PoolRolesAttachmentSpecForProviderIdentityPoolIdSelectorPolicyResolveEnum>))]
    public V1beta1PoolRolesAttachmentSpecForProviderIdentityPoolIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PoolRolesAttachmentSpecForProviderIdentityPoolIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PoolRolesAttachmentSpecForProviderIdentityPoolIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRuleRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRuleRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRuleRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRuleRoleArnRefPolicyResolutionEnum>))]
    public V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRuleRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRuleRoleArnRefPolicyResolveEnum>))]
    public V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRuleRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRuleRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRuleRoleArnRefPolicy? Policy { get; set; }
}

public enum V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRuleRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRuleRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRuleRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRuleRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRuleRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRuleRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRuleRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRuleRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRuleRoleArnSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRule
{
    /// <summary>The claim name that must be present in the token, for example, "isAdmin" or "paid".</summary>
    [JsonPropertyName("claim")]
    public string? Claim { get; set; }

    /// <summary>The match condition that specifies how closely the claim value in the IdP token must match Value.</summary>
    [JsonPropertyName("matchType")]
    public string? MatchType { get; set; }

    /// <summary>The role ARN.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRuleRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRuleRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>A brief string that the claim must match, for example, "paid" or "yes".</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1PoolRolesAttachmentSpecForProviderRoleMapping
{
    /// <summary>Specifies the action to be taken if either no rules match the claim value for the Rules type, or there is no cognito:preferred_role claim and there are multiple cognito:roles matches for the Token type. Required if you specify Token or Rules as the Type.</summary>
    [JsonPropertyName("ambiguousRoleResolution")]
    public string? AmbiguousRoleResolution { get; set; }

    /// <summary>A string identifying the identity provider, for example, "graph.facebook.com" or "cognito-idp.us-east-1.amazonaws.com/us-east-1_abcdefghi:app_client_id". Depends on cognito_identity_providers set on aws_cognito_identity_pool resource or a aws_cognito_identity_provider resource.</summary>
    [JsonPropertyName("identityProvider")]
    public string? IdentityProvider { get; set; }

    /// <summary>The Rules Configuration to be used for mapping users to roles. You can specify up to 25 rules per identity provider. Rules are evaluated in order. The first one to match specifies the role.</summary>
    [JsonPropertyName("mappingRule")]
    public IList<V1beta1PoolRolesAttachmentSpecForProviderRoleMappingMappingRule>? MappingRule { get; set; }

    /// <summary>The role mapping type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1PoolRolesAttachmentSpecForProvider
{
    /// <summary>An identity pool ID in the format REGION_GUID.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>Reference to a Pool in cognitoidentity to populate identityPoolId.</summary>
    [JsonPropertyName("identityPoolIdRef")]
    public V1beta1PoolRolesAttachmentSpecForProviderIdentityPoolIdRef? IdentityPoolIdRef { get; set; }

    /// <summary>Selector for a Pool in cognitoidentity to populate identityPoolId.</summary>
    [JsonPropertyName("identityPoolIdSelector")]
    public V1beta1PoolRolesAttachmentSpecForProviderIdentityPoolIdSelector? IdentityPoolIdSelector { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>A List of Role Mapping.</summary>
    [JsonPropertyName("roleMapping")]
    public IList<V1beta1PoolRolesAttachmentSpecForProviderRoleMapping>? RoleMapping { get; set; }

    /// <summary>The map of roles associated with this pool. For a given role, the key will be either "authenticated" or "unauthenticated" and the value will be the Role ARN.</summary>
    [JsonPropertyName("roles")]
    public IDictionary<string, string>? Roles { get; set; }
}

public enum V1beta1PoolRolesAttachmentSpecInitProviderIdentityPoolIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PoolRolesAttachmentSpecInitProviderIdentityPoolIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PoolRolesAttachmentSpecInitProviderIdentityPoolIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PoolRolesAttachmentSpecInitProviderIdentityPoolIdRefPolicyResolutionEnum>))]
    public V1beta1PoolRolesAttachmentSpecInitProviderIdentityPoolIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PoolRolesAttachmentSpecInitProviderIdentityPoolIdRefPolicyResolveEnum>))]
    public V1beta1PoolRolesAttachmentSpecInitProviderIdentityPoolIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PoolRolesAttachmentSpecInitProviderIdentityPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PoolRolesAttachmentSpecInitProviderIdentityPoolIdRefPolicy? Policy { get; set; }
}

public enum V1beta1PoolRolesAttachmentSpecInitProviderIdentityPoolIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PoolRolesAttachmentSpecInitProviderIdentityPoolIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PoolRolesAttachmentSpecInitProviderIdentityPoolIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PoolRolesAttachmentSpecInitProviderIdentityPoolIdSelectorPolicyResolutionEnum>))]
    public V1beta1PoolRolesAttachmentSpecInitProviderIdentityPoolIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PoolRolesAttachmentSpecInitProviderIdentityPoolIdSelectorPolicyResolveEnum>))]
    public V1beta1PoolRolesAttachmentSpecInitProviderIdentityPoolIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PoolRolesAttachmentSpecInitProviderIdentityPoolIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PoolRolesAttachmentSpecInitProviderIdentityPoolIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRuleRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRuleRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRuleRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRuleRoleArnRefPolicyResolutionEnum>))]
    public V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRuleRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRuleRoleArnRefPolicyResolveEnum>))]
    public V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRuleRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRuleRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRuleRoleArnRefPolicy? Policy { get; set; }
}

public enum V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRuleRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRuleRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRuleRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRuleRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRuleRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRuleRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRuleRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRuleRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRuleRoleArnSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRule
{
    /// <summary>The claim name that must be present in the token, for example, "isAdmin" or "paid".</summary>
    [JsonPropertyName("claim")]
    public string? Claim { get; set; }

    /// <summary>The match condition that specifies how closely the claim value in the IdP token must match Value.</summary>
    [JsonPropertyName("matchType")]
    public string? MatchType { get; set; }

    /// <summary>The role ARN.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRuleRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRuleRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>A brief string that the claim must match, for example, "paid" or "yes".</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1PoolRolesAttachmentSpecInitProviderRoleMapping
{
    /// <summary>Specifies the action to be taken if either no rules match the claim value for the Rules type, or there is no cognito:preferred_role claim and there are multiple cognito:roles matches for the Token type. Required if you specify Token or Rules as the Type.</summary>
    [JsonPropertyName("ambiguousRoleResolution")]
    public string? AmbiguousRoleResolution { get; set; }

    /// <summary>A string identifying the identity provider, for example, "graph.facebook.com" or "cognito-idp.us-east-1.amazonaws.com/us-east-1_abcdefghi:app_client_id". Depends on cognito_identity_providers set on aws_cognito_identity_pool resource or a aws_cognito_identity_provider resource.</summary>
    [JsonPropertyName("identityProvider")]
    public string? IdentityProvider { get; set; }

    /// <summary>The Rules Configuration to be used for mapping users to roles. You can specify up to 25 rules per identity provider. Rules are evaluated in order. The first one to match specifies the role.</summary>
    [JsonPropertyName("mappingRule")]
    public IList<V1beta1PoolRolesAttachmentSpecInitProviderRoleMappingMappingRule>? MappingRule { get; set; }

    /// <summary>The role mapping type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1PoolRolesAttachmentSpecInitProvider
{
    /// <summary>An identity pool ID in the format REGION_GUID.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>Reference to a Pool in cognitoidentity to populate identityPoolId.</summary>
    [JsonPropertyName("identityPoolIdRef")]
    public V1beta1PoolRolesAttachmentSpecInitProviderIdentityPoolIdRef? IdentityPoolIdRef { get; set; }

    /// <summary>Selector for a Pool in cognitoidentity to populate identityPoolId.</summary>
    [JsonPropertyName("identityPoolIdSelector")]
    public V1beta1PoolRolesAttachmentSpecInitProviderIdentityPoolIdSelector? IdentityPoolIdSelector { get; set; }

    /// <summary>A List of Role Mapping.</summary>
    [JsonPropertyName("roleMapping")]
    public IList<V1beta1PoolRolesAttachmentSpecInitProviderRoleMapping>? RoleMapping { get; set; }

    /// <summary>The map of roles associated with this pool. For a given role, the key will be either "authenticated" or "unauthenticated" and the value will be the Role ARN.</summary>
    [JsonPropertyName("roles")]
    public IDictionary<string, string>? Roles { get; set; }
}

public enum V1beta1PoolRolesAttachmentSpecManagementPoliciesEnum
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

public enum V1beta1PoolRolesAttachmentSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PoolRolesAttachmentSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PoolRolesAttachmentSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PoolRolesAttachmentSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1PoolRolesAttachmentSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PoolRolesAttachmentSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1PoolRolesAttachmentSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PoolRolesAttachmentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PoolRolesAttachmentSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1PoolRolesAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PoolRolesAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PoolRolesAttachmentSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PoolRolesAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1PoolRolesAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PoolRolesAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1PoolRolesAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PoolRolesAttachmentSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PoolRolesAttachmentSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1PoolRolesAttachmentSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1PoolRolesAttachmentSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1PoolRolesAttachmentSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1PoolRolesAttachmentSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1PoolRolesAttachmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1PoolRolesAttachmentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PoolRolesAttachmentSpecDeletionPolicyEnum>))]
    public V1beta1PoolRolesAttachmentSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PoolRolesAttachmentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PoolRolesAttachmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PoolRolesAttachmentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PoolRolesAttachmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1PoolRolesAttachmentSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PoolRolesAttachmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1PoolRolesAttachmentStatusAtProviderRoleMappingMappingRule
{
    /// <summary>The claim name that must be present in the token, for example, "isAdmin" or "paid".</summary>
    [JsonPropertyName("claim")]
    public string? Claim { get; set; }

    /// <summary>The match condition that specifies how closely the claim value in the IdP token must match Value.</summary>
    [JsonPropertyName("matchType")]
    public string? MatchType { get; set; }

    /// <summary>The role ARN.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A brief string that the claim must match, for example, "paid" or "yes".</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1PoolRolesAttachmentStatusAtProviderRoleMapping
{
    /// <summary>Specifies the action to be taken if either no rules match the claim value for the Rules type, or there is no cognito:preferred_role claim and there are multiple cognito:roles matches for the Token type. Required if you specify Token or Rules as the Type.</summary>
    [JsonPropertyName("ambiguousRoleResolution")]
    public string? AmbiguousRoleResolution { get; set; }

    /// <summary>A string identifying the identity provider, for example, "graph.facebook.com" or "cognito-idp.us-east-1.amazonaws.com/us-east-1_abcdefghi:app_client_id". Depends on cognito_identity_providers set on aws_cognito_identity_pool resource or a aws_cognito_identity_provider resource.</summary>
    [JsonPropertyName("identityProvider")]
    public string? IdentityProvider { get; set; }

    /// <summary>The Rules Configuration to be used for mapping users to roles. You can specify up to 25 rules per identity provider. Rules are evaluated in order. The first one to match specifies the role.</summary>
    [JsonPropertyName("mappingRule")]
    public IList<V1beta1PoolRolesAttachmentStatusAtProviderRoleMappingMappingRule>? MappingRule { get; set; }

    /// <summary>The role mapping type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1PoolRolesAttachmentStatusAtProvider
{
    /// <summary>The identity pool ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity pool ID in the format REGION_GUID.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>A List of Role Mapping.</summary>
    [JsonPropertyName("roleMapping")]
    public IList<V1beta1PoolRolesAttachmentStatusAtProviderRoleMapping>? RoleMapping { get; set; }

    /// <summary>The map of roles associated with this pool. For a given role, the key will be either "authenticated" or "unauthenticated" and the value will be the Role ARN.</summary>
    [JsonPropertyName("roles")]
    public IDictionary<string, string>? Roles { get; set; }
}

public partial class V1beta1PoolRolesAttachmentStatusConditions
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

public partial class V1beta1PoolRolesAttachmentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PoolRolesAttachmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PoolRolesAttachmentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PoolRolesAttachment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PoolRolesAttachmentSpec>, IStatus<V1beta1PoolRolesAttachmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PoolRolesAttachment";
    public const string KubeGroup = "cognitoidentity.aws.upbound.io";
    public const string KubePluralName = "poolrolesattachments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PoolRolesAttachmentSpec defines the desired state of PoolRolesAttachment</summary>
    [JsonPropertyName("spec")]
    public V1beta1PoolRolesAttachmentSpec Spec { get; set; }

    /// <summary>PoolRolesAttachmentStatus defines the observed state of PoolRolesAttachment.</summary>
    [JsonPropertyName("status")]
    public V1beta1PoolRolesAttachmentStatus? Status { get; set; }
}