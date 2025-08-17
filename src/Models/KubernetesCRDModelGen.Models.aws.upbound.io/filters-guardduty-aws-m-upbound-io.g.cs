using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.guardduty.aws.m.upbound.io;
#nullable enable
/// <summary>Filter is the Schema for the Filters API. Provides a resource to manage a GuardDuty filter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FilterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Filter>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FilterList";
    public const string KubeGroup = "guardduty.aws.m.upbound.io";
    public const string KubePluralName = "filters";
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
    public IList<V1beta1Filter> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpecForProviderDetectorIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Detector in guardduty to populate detectorId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpecForProviderDetectorIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FilterSpecForProviderDetectorIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpecForProviderDetectorIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Detector in guardduty to populate detectorId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpecForProviderDetectorIdSelector
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
    public V1beta1FilterSpecForProviderDetectorIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpecForProviderFindingCriteriaCriterion
{
    /// <summary>List of string values to be evaluated.</summary>
    [JsonPropertyName("equals")]
    public IList<string>? Equals { get; set; }

    /// <summary>The name of the field to be evaluated. The full list of field names can be found in AWS documentation.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("greaterThan")]
    public string? GreaterThan { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("greaterThanOrEqual")]
    public string? GreaterThanOrEqual { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("lessThan")]
    public string? LessThan { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("lessThanOrEqual")]
    public string? LessThanOrEqual { get; set; }

    /// <summary>List of string values to be evaluated.</summary>
    [JsonPropertyName("notEquals")]
    public IList<string>? NotEquals { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Represents the criteria to be used in the filter for querying findings. Contains one or more criterion blocks, documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpecForProviderFindingCriteria
{
    /// <summary></summary>
    [JsonPropertyName("criterion")]
    public IList<V1beta1FilterSpecForProviderFindingCriteriaCriterion>? Criterion { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpecForProvider
{
    /// <summary>Specifies the action that is to be applied to the findings that match the filter. Can be one of ARCHIVE or NOOP.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Description of the filter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>ID of a GuardDuty detector, attached to your account.</summary>
    [JsonPropertyName("detectorId")]
    public string? DetectorId { get; set; }

    /// <summary>Reference to a Detector in guardduty to populate detectorId.</summary>
    [JsonPropertyName("detectorIdRef")]
    public V1beta1FilterSpecForProviderDetectorIdRef? DetectorIdRef { get; set; }

    /// <summary>Selector for a Detector in guardduty to populate detectorId.</summary>
    [JsonPropertyName("detectorIdSelector")]
    public V1beta1FilterSpecForProviderDetectorIdSelector? DetectorIdSelector { get; set; }

    /// <summary>Represents the criteria to be used in the filter for querying findings. Contains one or more criterion blocks, documented below.</summary>
    [JsonPropertyName("findingCriteria")]
    public V1beta1FilterSpecForProviderFindingCriteria? FindingCriteria { get; set; }

    /// <summary>Specifies the position of the filter in the list of current filters. Also specifies the order in which this filter is applied to the findings.</summary>
    [JsonPropertyName("rank")]
    public double? Rank { get; set; }

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
public partial class V1beta1FilterSpecInitProviderFindingCriteriaCriterion
{
    /// <summary>List of string values to be evaluated.</summary>
    [JsonPropertyName("equals")]
    public IList<string>? Equals { get; set; }

    /// <summary>The name of the field to be evaluated. The full list of field names can be found in AWS documentation.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("greaterThan")]
    public string? GreaterThan { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("greaterThanOrEqual")]
    public string? GreaterThanOrEqual { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("lessThan")]
    public string? LessThan { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("lessThanOrEqual")]
    public string? LessThanOrEqual { get; set; }

    /// <summary>List of string values to be evaluated.</summary>
    [JsonPropertyName("notEquals")]
    public IList<string>? NotEquals { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Represents the criteria to be used in the filter for querying findings. Contains one or more criterion blocks, documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpecInitProviderFindingCriteria
{
    /// <summary></summary>
    [JsonPropertyName("criterion")]
    public IList<V1beta1FilterSpecInitProviderFindingCriteriaCriterion>? Criterion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpecInitProvider
{
    /// <summary>Specifies the action that is to be applied to the findings that match the filter. Can be one of ARCHIVE or NOOP.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Description of the filter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Represents the criteria to be used in the filter for querying findings. Contains one or more criterion blocks, documented below.</summary>
    [JsonPropertyName("findingCriteria")]
    public V1beta1FilterSpecInitProviderFindingCriteria? FindingCriteria { get; set; }

    /// <summary>Specifies the position of the filter in the list of current filters. Also specifies the order in which this filter is applied to the findings.</summary>
    [JsonPropertyName("rank")]
    public double? Rank { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpecProviderConfigRef
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
public partial class V1beta1FilterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>FilterSpec defines the desired state of Filter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FilterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FilterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FilterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FilterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterStatusAtProviderFindingCriteriaCriterion
{
    /// <summary>List of string values to be evaluated.</summary>
    [JsonPropertyName("equals")]
    public IList<string>? Equals { get; set; }

    /// <summary>The name of the field to be evaluated. The full list of field names can be found in AWS documentation.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("greaterThan")]
    public string? GreaterThan { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("greaterThanOrEqual")]
    public string? GreaterThanOrEqual { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("lessThan")]
    public string? LessThan { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("lessThanOrEqual")]
    public string? LessThanOrEqual { get; set; }

    /// <summary>List of string values to be evaluated.</summary>
    [JsonPropertyName("notEquals")]
    public IList<string>? NotEquals { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Represents the criteria to be used in the filter for querying findings. Contains one or more criterion blocks, documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterStatusAtProviderFindingCriteria
{
    /// <summary></summary>
    [JsonPropertyName("criterion")]
    public IList<V1beta1FilterStatusAtProviderFindingCriteriaCriterion>? Criterion { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterStatusAtProvider
{
    /// <summary>Specifies the action that is to be applied to the findings that match the filter. Can be one of ARCHIVE or NOOP.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The ARN of the GuardDuty filter.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Description of the filter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>ID of a GuardDuty detector, attached to your account.</summary>
    [JsonPropertyName("detectorId")]
    public string? DetectorId { get; set; }

    /// <summary>Represents the criteria to be used in the filter for querying findings. Contains one or more criterion blocks, documented below.</summary>
    [JsonPropertyName("findingCriteria")]
    public V1beta1FilterStatusAtProviderFindingCriteria? FindingCriteria { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the position of the filter in the list of current filters. Also specifies the order in which this filter is applied to the findings.</summary>
    [JsonPropertyName("rank")]
    public double? Rank { get; set; }

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
public partial class V1beta1FilterStatusConditions
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
/// <summary>FilterStatus defines the observed state of Filter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FilterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FilterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Filter is the Schema for the Filters API. Provides a resource to manage a GuardDuty filter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Filter : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FilterSpec>, IStatus<V1beta1FilterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Filter";
    public const string KubeGroup = "guardduty.aws.m.upbound.io";
    public const string KubePluralName = "filters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FilterSpec defines the desired state of Filter</summary>
    [JsonPropertyName("spec")]
    public V1beta1FilterSpec Spec { get; set; }

    /// <summary>FilterStatus defines the observed state of Filter.</summary>
    [JsonPropertyName("status")]
    public V1beta1FilterStatus? Status { get; set; }
}
#nullable disable
