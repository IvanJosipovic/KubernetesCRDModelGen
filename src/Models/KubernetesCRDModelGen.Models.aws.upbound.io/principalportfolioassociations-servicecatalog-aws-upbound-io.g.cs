using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicecatalog.aws.upbound.io;
public enum V1beta1PrincipalPortfolioAssociationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1PrincipalPortfolioAssociationSpecForProviderPortfolioIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PrincipalPortfolioAssociationSpecForProviderPortfolioIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PrincipalPortfolioAssociationSpecForProviderPortfolioIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrincipalPortfolioAssociationSpecForProviderPortfolioIdRefPolicyResolutionEnum>))]
    public V1beta1PrincipalPortfolioAssociationSpecForProviderPortfolioIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrincipalPortfolioAssociationSpecForProviderPortfolioIdRefPolicyResolveEnum>))]
    public V1beta1PrincipalPortfolioAssociationSpecForProviderPortfolioIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PrincipalPortfolioAssociationSpecForProviderPortfolioIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrincipalPortfolioAssociationSpecForProviderPortfolioIdRefPolicy? Policy { get; set; }
}

public enum V1beta1PrincipalPortfolioAssociationSpecForProviderPortfolioIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PrincipalPortfolioAssociationSpecForProviderPortfolioIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PrincipalPortfolioAssociationSpecForProviderPortfolioIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrincipalPortfolioAssociationSpecForProviderPortfolioIdSelectorPolicyResolutionEnum>))]
    public V1beta1PrincipalPortfolioAssociationSpecForProviderPortfolioIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrincipalPortfolioAssociationSpecForProviderPortfolioIdSelectorPolicyResolveEnum>))]
    public V1beta1PrincipalPortfolioAssociationSpecForProviderPortfolioIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PrincipalPortfolioAssociationSpecForProviderPortfolioIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrincipalPortfolioAssociationSpecForProviderPortfolioIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1PrincipalPortfolioAssociationSpecForProviderPrincipalArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PrincipalPortfolioAssociationSpecForProviderPrincipalArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PrincipalPortfolioAssociationSpecForProviderPrincipalArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrincipalPortfolioAssociationSpecForProviderPrincipalArnRefPolicyResolutionEnum>))]
    public V1beta1PrincipalPortfolioAssociationSpecForProviderPrincipalArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrincipalPortfolioAssociationSpecForProviderPrincipalArnRefPolicyResolveEnum>))]
    public V1beta1PrincipalPortfolioAssociationSpecForProviderPrincipalArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PrincipalPortfolioAssociationSpecForProviderPrincipalArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrincipalPortfolioAssociationSpecForProviderPrincipalArnRefPolicy? Policy { get; set; }
}

public enum V1beta1PrincipalPortfolioAssociationSpecForProviderPrincipalArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PrincipalPortfolioAssociationSpecForProviderPrincipalArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PrincipalPortfolioAssociationSpecForProviderPrincipalArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrincipalPortfolioAssociationSpecForProviderPrincipalArnSelectorPolicyResolutionEnum>))]
    public V1beta1PrincipalPortfolioAssociationSpecForProviderPrincipalArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrincipalPortfolioAssociationSpecForProviderPrincipalArnSelectorPolicyResolveEnum>))]
    public V1beta1PrincipalPortfolioAssociationSpecForProviderPrincipalArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PrincipalPortfolioAssociationSpecForProviderPrincipalArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrincipalPortfolioAssociationSpecForProviderPrincipalArnSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1PrincipalPortfolioAssociationSpecForProvider
{
    /// <summary>Language code. Valid values: en (English), jp (Japanese), zh (Chinese). Default value is en.</summary>
    [JsonPropertyName("acceptLanguage")]
    public string? AcceptLanguage { get; set; }

    /// <summary>Portfolio identifier.</summary>
    [JsonPropertyName("portfolioId")]
    public string? PortfolioId { get; set; }

    /// <summary>Reference to a Portfolio in servicecatalog to populate portfolioId.</summary>
    [JsonPropertyName("portfolioIdRef")]
    public V1beta1PrincipalPortfolioAssociationSpecForProviderPortfolioIdRef? PortfolioIdRef { get; set; }

    /// <summary>Selector for a Portfolio in servicecatalog to populate portfolioId.</summary>
    [JsonPropertyName("portfolioIdSelector")]
    public V1beta1PrincipalPortfolioAssociationSpecForProviderPortfolioIdSelector? PortfolioIdSelector { get; set; }

    /// <summary>Principal ARN.</summary>
    [JsonPropertyName("principalArn")]
    public string? PrincipalArn { get; set; }

    /// <summary>Reference to a User in iam to populate principalArn.</summary>
    [JsonPropertyName("principalArnRef")]
    public V1beta1PrincipalPortfolioAssociationSpecForProviderPrincipalArnRef? PrincipalArnRef { get; set; }

    /// <summary>Selector for a User in iam to populate principalArn.</summary>
    [JsonPropertyName("principalArnSelector")]
    public V1beta1PrincipalPortfolioAssociationSpecForProviderPrincipalArnSelector? PrincipalArnSelector { get; set; }

    /// <summary>Principal type. Setting this argument empty (e.g., principal_type = "") will result in an error. Valid values are IAM and IAM_PATTERN. Default is IAM.</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}

public enum V1beta1PrincipalPortfolioAssociationSpecInitProviderPortfolioIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PrincipalPortfolioAssociationSpecInitProviderPortfolioIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PrincipalPortfolioAssociationSpecInitProviderPortfolioIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrincipalPortfolioAssociationSpecInitProviderPortfolioIdRefPolicyResolutionEnum>))]
    public V1beta1PrincipalPortfolioAssociationSpecInitProviderPortfolioIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrincipalPortfolioAssociationSpecInitProviderPortfolioIdRefPolicyResolveEnum>))]
    public V1beta1PrincipalPortfolioAssociationSpecInitProviderPortfolioIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PrincipalPortfolioAssociationSpecInitProviderPortfolioIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrincipalPortfolioAssociationSpecInitProviderPortfolioIdRefPolicy? Policy { get; set; }
}

public enum V1beta1PrincipalPortfolioAssociationSpecInitProviderPortfolioIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PrincipalPortfolioAssociationSpecInitProviderPortfolioIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PrincipalPortfolioAssociationSpecInitProviderPortfolioIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrincipalPortfolioAssociationSpecInitProviderPortfolioIdSelectorPolicyResolutionEnum>))]
    public V1beta1PrincipalPortfolioAssociationSpecInitProviderPortfolioIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrincipalPortfolioAssociationSpecInitProviderPortfolioIdSelectorPolicyResolveEnum>))]
    public V1beta1PrincipalPortfolioAssociationSpecInitProviderPortfolioIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PrincipalPortfolioAssociationSpecInitProviderPortfolioIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrincipalPortfolioAssociationSpecInitProviderPortfolioIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1PrincipalPortfolioAssociationSpecInitProviderPrincipalArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PrincipalPortfolioAssociationSpecInitProviderPrincipalArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PrincipalPortfolioAssociationSpecInitProviderPrincipalArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrincipalPortfolioAssociationSpecInitProviderPrincipalArnRefPolicyResolutionEnum>))]
    public V1beta1PrincipalPortfolioAssociationSpecInitProviderPrincipalArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrincipalPortfolioAssociationSpecInitProviderPrincipalArnRefPolicyResolveEnum>))]
    public V1beta1PrincipalPortfolioAssociationSpecInitProviderPrincipalArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PrincipalPortfolioAssociationSpecInitProviderPrincipalArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrincipalPortfolioAssociationSpecInitProviderPrincipalArnRefPolicy? Policy { get; set; }
}

public enum V1beta1PrincipalPortfolioAssociationSpecInitProviderPrincipalArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PrincipalPortfolioAssociationSpecInitProviderPrincipalArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PrincipalPortfolioAssociationSpecInitProviderPrincipalArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrincipalPortfolioAssociationSpecInitProviderPrincipalArnSelectorPolicyResolutionEnum>))]
    public V1beta1PrincipalPortfolioAssociationSpecInitProviderPrincipalArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrincipalPortfolioAssociationSpecInitProviderPrincipalArnSelectorPolicyResolveEnum>))]
    public V1beta1PrincipalPortfolioAssociationSpecInitProviderPrincipalArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PrincipalPortfolioAssociationSpecInitProviderPrincipalArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrincipalPortfolioAssociationSpecInitProviderPrincipalArnSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1PrincipalPortfolioAssociationSpecInitProvider
{
    /// <summary>Language code. Valid values: en (English), jp (Japanese), zh (Chinese). Default value is en.</summary>
    [JsonPropertyName("acceptLanguage")]
    public string? AcceptLanguage { get; set; }

    /// <summary>Portfolio identifier.</summary>
    [JsonPropertyName("portfolioId")]
    public string? PortfolioId { get; set; }

    /// <summary>Reference to a Portfolio in servicecatalog to populate portfolioId.</summary>
    [JsonPropertyName("portfolioIdRef")]
    public V1beta1PrincipalPortfolioAssociationSpecInitProviderPortfolioIdRef? PortfolioIdRef { get; set; }

    /// <summary>Selector for a Portfolio in servicecatalog to populate portfolioId.</summary>
    [JsonPropertyName("portfolioIdSelector")]
    public V1beta1PrincipalPortfolioAssociationSpecInitProviderPortfolioIdSelector? PortfolioIdSelector { get; set; }

    /// <summary>Principal ARN.</summary>
    [JsonPropertyName("principalArn")]
    public string? PrincipalArn { get; set; }

    /// <summary>Reference to a User in iam to populate principalArn.</summary>
    [JsonPropertyName("principalArnRef")]
    public V1beta1PrincipalPortfolioAssociationSpecInitProviderPrincipalArnRef? PrincipalArnRef { get; set; }

    /// <summary>Selector for a User in iam to populate principalArn.</summary>
    [JsonPropertyName("principalArnSelector")]
    public V1beta1PrincipalPortfolioAssociationSpecInitProviderPrincipalArnSelector? PrincipalArnSelector { get; set; }

    /// <summary>Principal type. Setting this argument empty (e.g., principal_type = "") will result in an error. Valid values are IAM and IAM_PATTERN. Default is IAM.</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

public enum V1beta1PrincipalPortfolioAssociationSpecManagementPoliciesEnum
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

public enum V1beta1PrincipalPortfolioAssociationSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PrincipalPortfolioAssociationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PrincipalPortfolioAssociationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrincipalPortfolioAssociationSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1PrincipalPortfolioAssociationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrincipalPortfolioAssociationSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1PrincipalPortfolioAssociationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PrincipalPortfolioAssociationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrincipalPortfolioAssociationSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1PrincipalPortfolioAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PrincipalPortfolioAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1PrincipalPortfolioAssociationSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrincipalPortfolioAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1PrincipalPortfolioAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrincipalPortfolioAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1PrincipalPortfolioAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1PrincipalPortfolioAssociationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrincipalPortfolioAssociationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1PrincipalPortfolioAssociationSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1PrincipalPortfolioAssociationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1PrincipalPortfolioAssociationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1PrincipalPortfolioAssociationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1PrincipalPortfolioAssociationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1PrincipalPortfolioAssociationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrincipalPortfolioAssociationSpecDeletionPolicyEnum>))]
    public V1beta1PrincipalPortfolioAssociationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PrincipalPortfolioAssociationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PrincipalPortfolioAssociationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PrincipalPortfolioAssociationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PrincipalPortfolioAssociationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1PrincipalPortfolioAssociationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PrincipalPortfolioAssociationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1PrincipalPortfolioAssociationStatusAtProvider
{
    /// <summary>Language code. Valid values: en (English), jp (Japanese), zh (Chinese). Default value is en.</summary>
    [JsonPropertyName("acceptLanguage")]
    public string? AcceptLanguage { get; set; }

    /// <summary>Identifier of the association.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Portfolio identifier.</summary>
    [JsonPropertyName("portfolioId")]
    public string? PortfolioId { get; set; }

    /// <summary>Principal ARN.</summary>
    [JsonPropertyName("principalArn")]
    public string? PrincipalArn { get; set; }

    /// <summary>Principal type. Setting this argument empty (e.g., principal_type = "") will result in an error. Valid values are IAM and IAM_PATTERN. Default is IAM.</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

public partial class V1beta1PrincipalPortfolioAssociationStatusConditions
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

public partial class V1beta1PrincipalPortfolioAssociationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PrincipalPortfolioAssociationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PrincipalPortfolioAssociationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrincipalPortfolioAssociation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PrincipalPortfolioAssociationSpec>, IStatus<V1beta1PrincipalPortfolioAssociationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrincipalPortfolioAssociation";
    public const string KubeGroup = "servicecatalog.aws.upbound.io";
    public const string KubePluralName = "principalportfolioassociations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PrincipalPortfolioAssociationSpec defines the desired state of PrincipalPortfolioAssociation</summary>
    [JsonPropertyName("spec")]
    public V1beta1PrincipalPortfolioAssociationSpec Spec { get; set; }

    /// <summary>PrincipalPortfolioAssociationStatus defines the observed state of PrincipalPortfolioAssociation.</summary>
    [JsonPropertyName("status")]
    public V1beta1PrincipalPortfolioAssociationStatus? Status { get; set; }
}