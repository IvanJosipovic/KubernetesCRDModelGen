using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.macie2.aws.m.upbound.io;
#nullable enable
/// <summary>FindingsFilter is the Schema for the FindingsFilters API. Provides a resource to manage an Amazon Macie Findings Filter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FindingsFilterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1FindingsFilter>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FindingsFilterList";
    public const string KubeGroup = "macie2.aws.m.upbound.io";
    public const string KubePluralName = "findingsfilters";
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
    public IList<V1beta1FindingsFilter> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FindingsFilterSpecForProviderFindingCriteriaCriterion
{
    /// <summary>The value for the property matches (equals) the specified value. If you specify multiple values, Amazon Macie uses OR logic to join the values.</summary>
    [JsonPropertyName("eq")]
    public IList<string>? Eq { get; set; }

    /// <summary>The value for the property exclusively matches (equals an exact match for) all the specified values. If you specify multiple values, Amazon Macie uses AND logic to join the values.</summary>
    [JsonPropertyName("eqExactMatch")]
    public IList<string>? EqExactMatch { get; set; }

    /// <summary>The name of the field to be evaluated.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>The value for the property is greater than the specified value.</summary>
    [JsonPropertyName("gt")]
    public string? Gt { get; set; }

    /// <summary>The value for the property is greater than or equal to the specified value.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The value for the property is less than the specified value.</summary>
    [JsonPropertyName("lt")]
    public string? Lt { get; set; }

    /// <summary>The value for the property is less than or equal to the specified value.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }

    /// <summary>The value for the property doesn't match (doesn't equal) the specified value. If you specify multiple values, Amazon Macie uses OR logic to join the values.</summary>
    [JsonPropertyName("neq")]
    public IList<string>? Neq { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The criteria to use to filter findings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FindingsFilterSpecForProviderFindingCriteria
{
    /// <summary>A condition that specifies the property, operator, and one or more values to use to filter the results.  (documented below)</summary>
    [JsonPropertyName("criterion")]
    public IList<V1beta1FindingsFilterSpecForProviderFindingCriteriaCriterion>? Criterion { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FindingsFilterSpecForProvider
{
    /// <summary>The action to perform on findings that meet the filter criteria (finding_criteria). Valid values are: ARCHIVE, suppress (automatically archive) the findings; and, NOOP, don't perform any action on the findings.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A custom description of the filter. The description can contain as many as 512 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The criteria to use to filter findings.</summary>
    [JsonPropertyName("findingCriteria")]
    public V1beta1FindingsFilterSpecForProviderFindingCriteria? FindingCriteria { get; set; }

    /// <summary>A custom name for the filter. The name must contain at least 3 characters and can contain as many as 64 characters. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The position of the filter in the list of saved filters on the Amazon Macie console. This value also determines the order in which the filter is applied to findings, relative to other filters that are also applied to the findings.</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FindingsFilterSpecInitProviderFindingCriteriaCriterion
{
    /// <summary>The value for the property matches (equals) the specified value. If you specify multiple values, Amazon Macie uses OR logic to join the values.</summary>
    [JsonPropertyName("eq")]
    public IList<string>? Eq { get; set; }

    /// <summary>The value for the property exclusively matches (equals an exact match for) all the specified values. If you specify multiple values, Amazon Macie uses AND logic to join the values.</summary>
    [JsonPropertyName("eqExactMatch")]
    public IList<string>? EqExactMatch { get; set; }

    /// <summary>The name of the field to be evaluated.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>The value for the property is greater than the specified value.</summary>
    [JsonPropertyName("gt")]
    public string? Gt { get; set; }

    /// <summary>The value for the property is greater than or equal to the specified value.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The value for the property is less than the specified value.</summary>
    [JsonPropertyName("lt")]
    public string? Lt { get; set; }

    /// <summary>The value for the property is less than or equal to the specified value.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }

    /// <summary>The value for the property doesn't match (doesn't equal) the specified value. If you specify multiple values, Amazon Macie uses OR logic to join the values.</summary>
    [JsonPropertyName("neq")]
    public IList<string>? Neq { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The criteria to use to filter findings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FindingsFilterSpecInitProviderFindingCriteria
{
    /// <summary>A condition that specifies the property, operator, and one or more values to use to filter the results.  (documented below)</summary>
    [JsonPropertyName("criterion")]
    public IList<V1beta1FindingsFilterSpecInitProviderFindingCriteriaCriterion>? Criterion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FindingsFilterSpecInitProvider
{
    /// <summary>The action to perform on findings that meet the filter criteria (finding_criteria). Valid values are: ARCHIVE, suppress (automatically archive) the findings; and, NOOP, don't perform any action on the findings.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A custom description of the filter. The description can contain as many as 512 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The criteria to use to filter findings.</summary>
    [JsonPropertyName("findingCriteria")]
    public V1beta1FindingsFilterSpecInitProviderFindingCriteria? FindingCriteria { get; set; }

    /// <summary>A custom name for the filter. The name must contain at least 3 characters and can contain as many as 64 characters. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The position of the filter in the list of saved filters on the Amazon Macie console. This value also determines the order in which the filter is applied to findings, relative to other filters that are also applied to the findings.</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FindingsFilterSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FindingsFilterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>FindingsFilterSpec defines the desired state of FindingsFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FindingsFilterSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FindingsFilterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FindingsFilterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FindingsFilterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FindingsFilterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FindingsFilterStatusAtProviderFindingCriteriaCriterion
{
    /// <summary>The value for the property matches (equals) the specified value. If you specify multiple values, Amazon Macie uses OR logic to join the values.</summary>
    [JsonPropertyName("eq")]
    public IList<string>? Eq { get; set; }

    /// <summary>The value for the property exclusively matches (equals an exact match for) all the specified values. If you specify multiple values, Amazon Macie uses AND logic to join the values.</summary>
    [JsonPropertyName("eqExactMatch")]
    public IList<string>? EqExactMatch { get; set; }

    /// <summary>The name of the field to be evaluated.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>The value for the property is greater than the specified value.</summary>
    [JsonPropertyName("gt")]
    public string? Gt { get; set; }

    /// <summary>The value for the property is greater than or equal to the specified value.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The value for the property is less than the specified value.</summary>
    [JsonPropertyName("lt")]
    public string? Lt { get; set; }

    /// <summary>The value for the property is less than or equal to the specified value.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }

    /// <summary>The value for the property doesn't match (doesn't equal) the specified value. If you specify multiple values, Amazon Macie uses OR logic to join the values.</summary>
    [JsonPropertyName("neq")]
    public IList<string>? Neq { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The criteria to use to filter findings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FindingsFilterStatusAtProviderFindingCriteria
{
    /// <summary>A condition that specifies the property, operator, and one or more values to use to filter the results.  (documented below)</summary>
    [JsonPropertyName("criterion")]
    public IList<V1beta1FindingsFilterStatusAtProviderFindingCriteriaCriterion>? Criterion { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FindingsFilterStatusAtProvider
{
    /// <summary>The action to perform on findings that meet the filter criteria (finding_criteria). Valid values are: ARCHIVE, suppress (automatically archive) the findings; and, NOOP, don't perform any action on the findings.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Findings Filter.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A custom description of the filter. The description can contain as many as 512 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The criteria to use to filter findings.</summary>
    [JsonPropertyName("findingCriteria")]
    public V1beta1FindingsFilterStatusAtProviderFindingCriteria? FindingCriteria { get; set; }

    /// <summary>The unique identifier (ID) of the macie Findings Filter.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A custom name for the filter. The name must contain at least 3 characters and can contain as many as 64 characters. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The position of the filter in the list of saved filters on the Amazon Macie console. This value also determines the order in which the filter is applied to findings, relative to other filters that are also applied to the findings.</summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FindingsFilterStatusConditions
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
#nullable disable

#nullable enable
/// <summary>FindingsFilterStatus defines the observed state of FindingsFilter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FindingsFilterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FindingsFilterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FindingsFilterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>FindingsFilter is the Schema for the FindingsFilters API. Provides a resource to manage an Amazon Macie Findings Filter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FindingsFilter : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FindingsFilterSpec>, IStatus<V1beta1FindingsFilterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FindingsFilter";
    public const string KubeGroup = "macie2.aws.m.upbound.io";
    public const string KubePluralName = "findingsfilters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FindingsFilterSpec defines the desired state of FindingsFilter</summary>
    [JsonPropertyName("spec")]
    public V1beta1FindingsFilterSpec Spec { get; set; }

    /// <summary>FindingsFilterStatus defines the observed state of FindingsFilter.</summary>
    [JsonPropertyName("status")]
    public V1beta1FindingsFilterStatus? Status { get; set; }
}
#nullable disable
