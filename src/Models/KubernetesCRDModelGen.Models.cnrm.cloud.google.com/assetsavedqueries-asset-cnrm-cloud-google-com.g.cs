using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.asset.cnrm.cloud.google.com;
/// <summary>Optional. Specifies roles or permissions for analysis. This is optional.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetSavedQuerySpecContentIamPolicyAnalysisQueryAccessSelector
{
    /// <summary>Optional. The permissions to appear in result.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Optional. The roles to appear in result.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}

/// <summary>Optional. The hypothetical context for IAM conditions evaluation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetSavedQuerySpecContentIamPolicyAnalysisQueryConditionContext
{
    /// <summary>The hypothetical access timestamp to evaluate IAM conditions. Note that this value must not be earlier than the current time; otherwise, an INVALID_ARGUMENT error will be returned.</summary>
    [JsonPropertyName("accessTime")]
    public string? AccessTime { get; set; }
}

/// <summary>Optional. Specifies an identity for analysis.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetSavedQuerySpecContentIamPolicyAnalysisQueryIdentitySelector
{
    /// <summary>Required. The identity appear in the form of principals in  [IAM policy  binding](https://cloud.google.com/iam/reference/rest/v1/Binding).   The examples of supported forms are:  "user:mike@example.com",  "group:admins@example.com",  "domain:google.com",  "serviceAccount:my-project-id@appspot.gserviceaccount.com".   Notice that wildcard characters (such as * and ?) are not supported.  You must give a specific identity.</summary>
    [JsonPropertyName("identity")]
    public string Identity { get; set; }
}

/// <summary>Optional. The query options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetSavedQuerySpecContentIamPolicyAnalysisQueryOptions
{
    /// <summary>Optional. If true, the response will include access analysis from  identities to resources via service account impersonation. This is a very  expensive operation, because many derived queries will be executed. We  highly recommend you use  [AssetService.AnalyzeIamPolicyLongrunning][google.cloud.asset.v1.AssetService.AnalyzeIamPolicyLongrunning]  RPC instead.   For example, if the request analyzes for which resources user A has  permission P, and there's an IAM policy states user A has  iam.serviceAccounts.getAccessToken permission to a service account SA,  and there's another IAM policy states service account SA has permission P  to a Google Cloud folder F, then user A potentially has access to the  Google Cloud folder F. And those advanced analysis results will be  included in  [AnalyzeIamPolicyResponse.service_account_impersonation_analysis][google.cloud.asset.v1.AnalyzeIamPolicyResponse.service_account_impersonation_analysis].   Another example, if the request analyzes for who has  permission P to a Google Cloud folder F, and there's an IAM policy states  user A has iam.serviceAccounts.actAs permission to a service account SA,  and there's another IAM policy states service account SA has permission P  to the Google Cloud folder F, then user A potentially has access to the  Google Cloud folder F. And those advanced analysis results will be  included in  [AnalyzeIamPolicyResponse.service_account_impersonation_analysis][google.cloud.asset.v1.AnalyzeIamPolicyResponse.service_account_impersonation_analysis].   Only the following permissions are considered in this analysis:   * `iam.serviceAccounts.actAs`  * `iam.serviceAccounts.signBlob`  * `iam.serviceAccounts.signJwt`  * `iam.serviceAccounts.getAccessToken`  * `iam.serviceAccounts.getOpenIdToken`  * `iam.serviceAccounts.implicitDelegation`   Default is false.</summary>
    [JsonPropertyName("analyzeServiceAccountImpersonation")]
    public bool? AnalyzeServiceAccountImpersonation { get; set; }

    /// <summary>Optional. If true, the identities section of the result will expand any  Google groups appearing in an IAM policy binding.   If  [IamPolicyAnalysisQuery.identity_selector][google.cloud.asset.v1.IamPolicyAnalysisQuery.identity_selector]  is specified, the identity in the result will be determined by the  selector, and this flag is not allowed to set.   If true, the default max expansion per group is 1000 for  AssetService.AnalyzeIamPolicy][].   Default is false.</summary>
    [JsonPropertyName("expandGroups")]
    public bool? ExpandGroups { get; set; }

    /// <summary>Optional. If true and  [IamPolicyAnalysisQuery.resource_selector][google.cloud.asset.v1.IamPolicyAnalysisQuery.resource_selector]  is not specified, the resource section of the result will expand any  resource attached to an IAM policy to include resources lower in the  resource hierarchy.   For example, if the request analyzes for which resources user A has  permission P, and the results include an IAM policy with P on a Google  Cloud folder, the results will also include resources in that folder with  permission P.   If true and  [IamPolicyAnalysisQuery.resource_selector][google.cloud.asset.v1.IamPolicyAnalysisQuery.resource_selector]  is specified, the resource section of the result will expand the  specified resource to include resources lower in the resource hierarchy.  Only project or lower resources are supported. Folder and organization  resources cannot be used together with this option.   For example, if the request analyzes for which users have permission P on  a Google Cloud project with this option enabled, the results will include  all users who have permission P on that project or any lower resource.   If true, the default max expansion per resource is 1000 for  AssetService.AnalyzeIamPolicy][] and 100000 for  AssetService.AnalyzeIamPolicyLongrunning][].   Default is false.</summary>
    [JsonPropertyName("expandResources")]
    public bool? ExpandResources { get; set; }

    /// <summary>Optional. If true, the access section of result will expand any roles  appearing in IAM policy bindings to include their permissions.   If  [IamPolicyAnalysisQuery.access_selector][google.cloud.asset.v1.IamPolicyAnalysisQuery.access_selector]  is specified, the access section of the result will be determined by the  selector, and this flag is not allowed to set.   Default is false.</summary>
    [JsonPropertyName("expandRoles")]
    public bool? ExpandRoles { get; set; }

    /// <summary>Optional. If true, the result will output the relevant membership relationships between groups and other groups, and between groups and principals. Default is false.</summary>
    [JsonPropertyName("outputGroupEdges")]
    public bool? OutputGroupEdges { get; set; }

    /// <summary>Optional. If true, the result will output the relevant parent/child relationships between resources. Default is false.</summary>
    [JsonPropertyName("outputResourceEdges")]
    public bool? OutputResourceEdges { get; set; }
}

/// <summary>Optional. Specifies a resource for analysis.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetSavedQuerySpecContentIamPolicyAnalysisQueryResourceSelector
{
    /// <summary>Required. The [full resource name] (https://cloud.google.com/asset-inventory/docs/resource-name-format) of a resource of [supported resource types](https://cloud.google.com/asset-inventory/docs/supported-asset-types#analyzable_asset_types).</summary>
    [JsonPropertyName("fullResourceName")]
    public string FullResourceName { get; set; }
}

/// <summary>An IAM Policy Analysis query, which could be used in the [AssetService.AnalyzeIamPolicy][google.cloud.asset.v1.AssetService.AnalyzeIamPolicy] RPC or the [AssetService.AnalyzeIamPolicyLongrunning][google.cloud.asset.v1.AssetService.AnalyzeIamPolicyLongrunning] RPC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetSavedQuerySpecContentIamPolicyAnalysisQuery
{
    /// <summary>Optional. Specifies roles or permissions for analysis. This is optional.</summary>
    [JsonPropertyName("accessSelector")]
    public V1alpha1AssetSavedQuerySpecContentIamPolicyAnalysisQueryAccessSelector? AccessSelector { get; set; }

    /// <summary>Optional. The hypothetical context for IAM conditions evaluation.</summary>
    [JsonPropertyName("conditionContext")]
    public V1alpha1AssetSavedQuerySpecContentIamPolicyAnalysisQueryConditionContext? ConditionContext { get; set; }

    /// <summary>Optional. Specifies an identity for analysis.</summary>
    [JsonPropertyName("identitySelector")]
    public V1alpha1AssetSavedQuerySpecContentIamPolicyAnalysisQueryIdentitySelector? IdentitySelector { get; set; }

    /// <summary>Optional. The query options.</summary>
    [JsonPropertyName("options")]
    public V1alpha1AssetSavedQuerySpecContentIamPolicyAnalysisQueryOptions? Options { get; set; }

    /// <summary>Optional. Specifies a resource for analysis.</summary>
    [JsonPropertyName("resourceSelector")]
    public V1alpha1AssetSavedQuerySpecContentIamPolicyAnalysisQueryResourceSelector? ResourceSelector { get; set; }

    /// <summary>Required. The relative name of the root asset. Only resources and IAM  policies within the scope will be analyzed.   This can only be an organization number (such as "organizations/123"), a  folder number (such as "folders/123"), a project ID (such as  "projects/my-project-id"), or a project number (such as "projects/12345").   To know how to get organization ID, visit [here  ](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).   To know how to get folder or project ID, visit [here  ](https://cloud.google.com/resource-manager/docs/creating-managing-folders#viewing_or_listing_folders_and_projects).</summary>
    [JsonPropertyName("scope")]
    public string Scope { get; set; }
}

/// <summary>The query content.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetSavedQuerySpecContent
{
    /// <summary>An IAM Policy Analysis query, which could be used in the [AssetService.AnalyzeIamPolicy][google.cloud.asset.v1.AssetService.AnalyzeIamPolicy] RPC or the [AssetService.AnalyzeIamPolicyLongrunning][google.cloud.asset.v1.AssetService.AnalyzeIamPolicyLongrunning] RPC.</summary>
    [JsonPropertyName("iamPolicyAnalysisQuery")]
    public V1alpha1AssetSavedQuerySpecContentIamPolicyAnalysisQuery? IamPolicyAnalysisQuery { get; set; }
}

/// <summary>FolderRef represents the Folder that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetSavedQuerySpecFolderRef
{
    /// <summary>The 'name' field of a folder, when not managed by Config Connector. This field must be set when 'name' field is not set.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The 'name' field of a 'Folder' resource. This field must be set when 'external' field is not set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The 'namespace' field of a 'Folder' resource. If unset, the namespace is defaulted to the namespace of the referencer resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>OrganizationRef represents the Organization that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetSavedQuerySpecOrganizationRef
{
    /// <summary>The 'name' field of an organization, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string External { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetSavedQuerySpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>AssetSavedQuerySpec defines the desired state of AssetSavedQuery</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetSavedQuerySpec
{
    /// <summary>The query content.</summary>
    [JsonPropertyName("content")]
    public V1alpha1AssetSavedQuerySpecContent? Content { get; set; }

    /// <summary>The description of this saved query. This value should be fewer than 255 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>FolderRef represents the Folder that this resource belongs to.</summary>
    [JsonPropertyName("folderRef")]
    public V1alpha1AssetSavedQuerySpecFolderRef? FolderRef { get; set; }

    /// <summary>Labels applied on the resource. This value should not contain more than 10 entries. The key and value of each entry must be non-empty and fewer than 64 characters.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>OrganizationRef represents the Organization that this resource belongs to.</summary>
    [JsonPropertyName("organizationRef")]
    public V1alpha1AssetSavedQuerySpecOrganizationRef? OrganizationRef { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1AssetSavedQuerySpecProjectRef? ProjectRef { get; set; }

    /// <summary>The AssetSavedQuery name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetSavedQueryStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetSavedQueryStatusObservedState
{
    /// <summary>Output only. The create time of this saved query.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The account's email address who has created this saved query.</summary>
    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

    /// <summary>Output only. The last update time of this saved query.</summary>
    [JsonPropertyName("lastUpdateTime")]
    public string? LastUpdateTime { get; set; }

    /// <summary>Output only. The account's email address who has updated this saved query most recently.</summary>
    [JsonPropertyName("lastUpdater")]
    public string? LastUpdater { get; set; }
}

/// <summary>AssetSavedQueryStatus defines the config connector machine state of AssetSavedQuery</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AssetSavedQueryStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AssetSavedQueryStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the AssetSavedQuery resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1AssetSavedQueryStatusObservedState? ObservedState { get; set; }
}

/// <summary>AssetSavedQuery is the Schema for the AssetSavedQuery API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AssetSavedQuery : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AssetSavedQuerySpec>, IStatus<V1alpha1AssetSavedQueryStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AssetSavedQuery";
    public const string KubeGroup = "asset.cnrm.cloud.google.com";
    public const string KubePluralName = "assetsavedqueries";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AssetSavedQuerySpec defines the desired state of AssetSavedQuery</summary>
    [JsonPropertyName("spec")]
    public V1alpha1AssetSavedQuerySpec Spec { get; set; }

    /// <summary>AssetSavedQueryStatus defines the config connector machine state of AssetSavedQuery</summary>
    [JsonPropertyName("status")]
    public V1alpha1AssetSavedQueryStatus? Status { get; set; }
}

/// <summary>AssetSavedQuery is the Schema for the AssetSavedQuery API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AssetSavedQueryList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AssetSavedQuery>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AssetSavedQueryList";
    public const string KubeGroup = "asset.cnrm.cloud.google.com";
    public const string KubePluralName = "assetsavedqueries";
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
    public IList<V1alpha1AssetSavedQuery> Items { get; set; }
}