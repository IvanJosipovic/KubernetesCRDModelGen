using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.authorization.azure.m.upbound.io;
#nullable enable
/// <summary>ManagementGroupPolicyAssignment is the Schema for the ManagementGroupPolicyAssignments API. Manages a Policy Assignment to a Management Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ManagementGroupPolicyAssignmentList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ManagementGroupPolicyAssignment>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ManagementGroupPolicyAssignmentList";
    public const string KubeGroup = "authorization.azure.m.upbound.io";
    public const string KubePluralName = "managementgrouppolicyassignments";
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
    public IList<V1beta1ManagementGroupPolicyAssignment> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecForProviderIdentity
{
    /// <summary>A list of User Managed Identity IDs which should be assigned to the Policy Definition.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Type of Managed Identity which should be added to this Policy Definition. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecForProviderManagementGroupIdRefPolicy
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
/// <summary>Reference to a ManagementGroup in management to populate managementGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecForProviderManagementGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagementGroupPolicyAssignmentSpecForProviderManagementGroupIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecForProviderManagementGroupIdSelectorPolicy
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
/// <summary>Selector for a ManagementGroup in management to populate managementGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecForProviderManagementGroupIdSelector
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
    public V1beta1ManagementGroupPolicyAssignmentSpecForProviderManagementGroupIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecForProviderNonComplianceMessage
{
    /// <summary>The non-compliance message text. When assigning policy sets (initiatives), unless policy_definition_reference_id is specified then this message will be the default for all policies.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>When assigning policy sets (initiatives), this is the ID of the policy definition that the non-compliance message applies to.</summary>
    [JsonPropertyName("policyDefinitionReferenceId")]
    public string? PolicyDefinitionReferenceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecForProviderOverridesSelectors
{
    /// <summary>The list of allowed values for the specified kind. Cannot be used with not_in. Can contain up to 50 values.</summary>
    [JsonPropertyName("in")]
    public IList<string>? In { get; set; }

    /// <summary>The list of not-allowed values for the specified kind. Cannot be used with in. Can contain up to 50 values.</summary>
    [JsonPropertyName("notIn")]
    public IList<string>? NotIn { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecForProviderOverrides
{
    /// <summary>One or more override_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta1ManagementGroupPolicyAssignmentSpecForProviderOverridesSelectors>? Selectors { get; set; }

    /// <summary>Specifies the value to override the policy property. Possible values for policyEffect override listed policy effects.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecForProviderPolicyDefinitionIdRefPolicy
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
/// <summary>Reference to a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecForProviderPolicyDefinitionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagementGroupPolicyAssignmentSpecForProviderPolicyDefinitionIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecForProviderPolicyDefinitionIdSelectorPolicy
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
/// <summary>Selector for a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecForProviderPolicyDefinitionIdSelector
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
    public V1beta1ManagementGroupPolicyAssignmentSpecForProviderPolicyDefinitionIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecForProviderResourceSelectorsSelectors
{
    /// <summary>The list of allowed values for the specified kind. Cannot be used with not_in. Can contain up to 50 values.</summary>
    [JsonPropertyName("in")]
    public IList<string>? In { get; set; }

    /// <summary>Specifies which characteristic will narrow down the set of evaluated resources. Possible values are resourceLocation, resourceType and resourceWithoutLocation.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The list of not-allowed values for the specified kind. Cannot be used with in. Can contain up to 50 values.</summary>
    [JsonPropertyName("notIn")]
    public IList<string>? NotIn { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecForProviderResourceSelectors
{
    /// <summary>Specifies a name for the resource selector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more resource_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta1ManagementGroupPolicyAssignmentSpecForProviderResourceSelectorsSelectors>? Selectors { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecForProvider
{
    /// <summary>A description which should be used for this Policy Assignment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Display Name for this Policy Assignment.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Specifies if this Policy should be enforced or not? Defaults to true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ManagementGroupPolicyAssignmentSpecForProviderIdentity? Identity { get; set; }

    /// <summary>The Azure Region where the Policy Assignment should exist. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the Management Group. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("managementGroupId")]
    public string? ManagementGroupId { get; set; }

    /// <summary>Reference to a ManagementGroup in management to populate managementGroupId.</summary>
    [JsonPropertyName("managementGroupIdRef")]
    public V1beta1ManagementGroupPolicyAssignmentSpecForProviderManagementGroupIdRef? ManagementGroupIdRef { get; set; }

    /// <summary>Selector for a ManagementGroup in management to populate managementGroupId.</summary>
    [JsonPropertyName("managementGroupIdSelector")]
    public V1beta1ManagementGroupPolicyAssignmentSpecForProviderManagementGroupIdSelector? ManagementGroupIdSelector { get; set; }

    /// <summary>A JSON mapping of any Metadata for this Policy.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>One or more non_compliance_message blocks as defined below.</summary>
    [JsonPropertyName("nonComplianceMessage")]
    public IList<V1beta1ManagementGroupPolicyAssignmentSpecForProviderNonComplianceMessage>? NonComplianceMessage { get; set; }

    /// <summary>Specifies a list of Resource Scopes (for example a Subscription, or a Resource Group) within this Management Group which are excluded from this Policy.</summary>
    [JsonPropertyName("notScopes")]
    public IList<string>? NotScopes { get; set; }

    /// <summary>One or more overrides blocks as defined below. More detail about overrides and resource_selectors see policy assignment structure</summary>
    [JsonPropertyName("overrides")]
    public IList<V1beta1ManagementGroupPolicyAssignmentSpecForProviderOverrides>? Overrides { get; set; }

    /// <summary>A JSON mapping of any Parameters for this Policy.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The ID of the Policy Definition or Policy Definition Set. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("policyDefinitionId")]
    public string? PolicyDefinitionId { get; set; }

    /// <summary>Reference to a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
    [JsonPropertyName("policyDefinitionIdRef")]
    public V1beta1ManagementGroupPolicyAssignmentSpecForProviderPolicyDefinitionIdRef? PolicyDefinitionIdRef { get; set; }

    /// <summary>Selector for a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
    [JsonPropertyName("policyDefinitionIdSelector")]
    public V1beta1ManagementGroupPolicyAssignmentSpecForProviderPolicyDefinitionIdSelector? PolicyDefinitionIdSelector { get; set; }

    /// <summary>One or more resource_selectors blocks as defined below to filter polices by resource properties.</summary>
    [JsonPropertyName("resourceSelectors")]
    public IList<V1beta1ManagementGroupPolicyAssignmentSpecForProviderResourceSelectors>? ResourceSelectors { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecInitProviderIdentity
{
    /// <summary>A list of User Managed Identity IDs which should be assigned to the Policy Definition.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Type of Managed Identity which should be added to this Policy Definition. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecInitProviderNonComplianceMessage
{
    /// <summary>The non-compliance message text. When assigning policy sets (initiatives), unless policy_definition_reference_id is specified then this message will be the default for all policies.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>When assigning policy sets (initiatives), this is the ID of the policy definition that the non-compliance message applies to.</summary>
    [JsonPropertyName("policyDefinitionReferenceId")]
    public string? PolicyDefinitionReferenceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecInitProviderOverridesSelectors
{
    /// <summary>The list of allowed values for the specified kind. Cannot be used with not_in. Can contain up to 50 values.</summary>
    [JsonPropertyName("in")]
    public IList<string>? In { get; set; }

    /// <summary>The list of not-allowed values for the specified kind. Cannot be used with in. Can contain up to 50 values.</summary>
    [JsonPropertyName("notIn")]
    public IList<string>? NotIn { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecInitProviderOverrides
{
    /// <summary>One or more override_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta1ManagementGroupPolicyAssignmentSpecInitProviderOverridesSelectors>? Selectors { get; set; }

    /// <summary>Specifies the value to override the policy property. Possible values for policyEffect override listed policy effects.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecInitProviderPolicyDefinitionIdRefPolicy
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
/// <summary>Reference to a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecInitProviderPolicyDefinitionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagementGroupPolicyAssignmentSpecInitProviderPolicyDefinitionIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecInitProviderPolicyDefinitionIdSelectorPolicy
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
/// <summary>Selector for a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecInitProviderPolicyDefinitionIdSelector
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
    public V1beta1ManagementGroupPolicyAssignmentSpecInitProviderPolicyDefinitionIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecInitProviderResourceSelectorsSelectors
{
    /// <summary>The list of allowed values for the specified kind. Cannot be used with not_in. Can contain up to 50 values.</summary>
    [JsonPropertyName("in")]
    public IList<string>? In { get; set; }

    /// <summary>Specifies which characteristic will narrow down the set of evaluated resources. Possible values are resourceLocation, resourceType and resourceWithoutLocation.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The list of not-allowed values for the specified kind. Cannot be used with in. Can contain up to 50 values.</summary>
    [JsonPropertyName("notIn")]
    public IList<string>? NotIn { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecInitProviderResourceSelectors
{
    /// <summary>Specifies a name for the resource selector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more resource_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta1ManagementGroupPolicyAssignmentSpecInitProviderResourceSelectorsSelectors>? Selectors { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecInitProvider
{
    /// <summary>A description which should be used for this Policy Assignment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Display Name for this Policy Assignment.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Specifies if this Policy should be enforced or not? Defaults to true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ManagementGroupPolicyAssignmentSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>The Azure Region where the Policy Assignment should exist. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A JSON mapping of any Metadata for this Policy.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>One or more non_compliance_message blocks as defined below.</summary>
    [JsonPropertyName("nonComplianceMessage")]
    public IList<V1beta1ManagementGroupPolicyAssignmentSpecInitProviderNonComplianceMessage>? NonComplianceMessage { get; set; }

    /// <summary>Specifies a list of Resource Scopes (for example a Subscription, or a Resource Group) within this Management Group which are excluded from this Policy.</summary>
    [JsonPropertyName("notScopes")]
    public IList<string>? NotScopes { get; set; }

    /// <summary>One or more overrides blocks as defined below. More detail about overrides and resource_selectors see policy assignment structure</summary>
    [JsonPropertyName("overrides")]
    public IList<V1beta1ManagementGroupPolicyAssignmentSpecInitProviderOverrides>? Overrides { get; set; }

    /// <summary>A JSON mapping of any Parameters for this Policy.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The ID of the Policy Definition or Policy Definition Set. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("policyDefinitionId")]
    public string? PolicyDefinitionId { get; set; }

    /// <summary>Reference to a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
    [JsonPropertyName("policyDefinitionIdRef")]
    public V1beta1ManagementGroupPolicyAssignmentSpecInitProviderPolicyDefinitionIdRef? PolicyDefinitionIdRef { get; set; }

    /// <summary>Selector for a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
    [JsonPropertyName("policyDefinitionIdSelector")]
    public V1beta1ManagementGroupPolicyAssignmentSpecInitProviderPolicyDefinitionIdSelector? PolicyDefinitionIdSelector { get; set; }

    /// <summary>One or more resource_selectors blocks as defined below to filter polices by resource properties.</summary>
    [JsonPropertyName("resourceSelectors")]
    public IList<V1beta1ManagementGroupPolicyAssignmentSpecInitProviderResourceSelectors>? ResourceSelectors { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpecProviderConfigRef
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
public partial class V1beta1ManagementGroupPolicyAssignmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ManagementGroupPolicyAssignmentSpec defines the desired state of ManagementGroupPolicyAssignment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ManagementGroupPolicyAssignmentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ManagementGroupPolicyAssignmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ManagementGroupPolicyAssignmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ManagementGroupPolicyAssignmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentStatusAtProviderIdentity
{
    /// <summary>A list of User Managed Identity IDs which should be assigned to the Policy Definition.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID of the Policy Assignment for this Management Group.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID of the Policy Assignment for this Management Group.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>The Type of Managed Identity which should be added to this Policy Definition. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentStatusAtProviderNonComplianceMessage
{
    /// <summary>The non-compliance message text. When assigning policy sets (initiatives), unless policy_definition_reference_id is specified then this message will be the default for all policies.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>When assigning policy sets (initiatives), this is the ID of the policy definition that the non-compliance message applies to.</summary>
    [JsonPropertyName("policyDefinitionReferenceId")]
    public string? PolicyDefinitionReferenceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentStatusAtProviderOverridesSelectors
{
    /// <summary>The list of allowed values for the specified kind. Cannot be used with not_in. Can contain up to 50 values.</summary>
    [JsonPropertyName("in")]
    public IList<string>? In { get; set; }

    /// <summary>Specifies which characteristic will narrow down the set of evaluated resources. Possible values are resourceLocation, resourceType and resourceWithoutLocation.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The list of not-allowed values for the specified kind. Cannot be used with in. Can contain up to 50 values.</summary>
    [JsonPropertyName("notIn")]
    public IList<string>? NotIn { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentStatusAtProviderOverrides
{
    /// <summary>One or more override_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta1ManagementGroupPolicyAssignmentStatusAtProviderOverridesSelectors>? Selectors { get; set; }

    /// <summary>Specifies the value to override the policy property. Possible values for policyEffect override listed policy effects.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentStatusAtProviderResourceSelectorsSelectors
{
    /// <summary>The list of allowed values for the specified kind. Cannot be used with not_in. Can contain up to 50 values.</summary>
    [JsonPropertyName("in")]
    public IList<string>? In { get; set; }

    /// <summary>Specifies which characteristic will narrow down the set of evaluated resources. Possible values are resourceLocation, resourceType and resourceWithoutLocation.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The list of not-allowed values for the specified kind. Cannot be used with in. Can contain up to 50 values.</summary>
    [JsonPropertyName("notIn")]
    public IList<string>? NotIn { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentStatusAtProviderResourceSelectors
{
    /// <summary>Specifies a name for the resource selector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more resource_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta1ManagementGroupPolicyAssignmentStatusAtProviderResourceSelectorsSelectors>? Selectors { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentStatusAtProvider
{
    /// <summary>A description which should be used for this Policy Assignment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Display Name for this Policy Assignment.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Specifies if this Policy should be enforced or not? Defaults to true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>The ID of the Management Group Policy Assignment.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ManagementGroupPolicyAssignmentStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>The Azure Region where the Policy Assignment should exist. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the Management Group. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("managementGroupId")]
    public string? ManagementGroupId { get; set; }

    /// <summary>A JSON mapping of any Metadata for this Policy.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>One or more non_compliance_message blocks as defined below.</summary>
    [JsonPropertyName("nonComplianceMessage")]
    public IList<V1beta1ManagementGroupPolicyAssignmentStatusAtProviderNonComplianceMessage>? NonComplianceMessage { get; set; }

    /// <summary>Specifies a list of Resource Scopes (for example a Subscription, or a Resource Group) within this Management Group which are excluded from this Policy.</summary>
    [JsonPropertyName("notScopes")]
    public IList<string>? NotScopes { get; set; }

    /// <summary>One or more overrides blocks as defined below. More detail about overrides and resource_selectors see policy assignment structure</summary>
    [JsonPropertyName("overrides")]
    public IList<V1beta1ManagementGroupPolicyAssignmentStatusAtProviderOverrides>? Overrides { get; set; }

    /// <summary>A JSON mapping of any Parameters for this Policy.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The ID of the Policy Definition or Policy Definition Set. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("policyDefinitionId")]
    public string? PolicyDefinitionId { get; set; }

    /// <summary>One or more resource_selectors blocks as defined below to filter polices by resource properties.</summary>
    [JsonPropertyName("resourceSelectors")]
    public IList<V1beta1ManagementGroupPolicyAssignmentStatusAtProviderResourceSelectors>? ResourceSelectors { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentStatusConditions
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
/// <summary>ManagementGroupPolicyAssignmentStatus defines the observed state of ManagementGroupPolicyAssignment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagementGroupPolicyAssignmentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ManagementGroupPolicyAssignmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ManagementGroupPolicyAssignmentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ManagementGroupPolicyAssignment is the Schema for the ManagementGroupPolicyAssignments API. Manages a Policy Assignment to a Management Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ManagementGroupPolicyAssignment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ManagementGroupPolicyAssignmentSpec>, IStatus<V1beta1ManagementGroupPolicyAssignmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ManagementGroupPolicyAssignment";
    public const string KubeGroup = "authorization.azure.m.upbound.io";
    public const string KubePluralName = "managementgrouppolicyassignments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ManagementGroupPolicyAssignmentSpec defines the desired state of ManagementGroupPolicyAssignment</summary>
    [JsonPropertyName("spec")]
    public V1beta1ManagementGroupPolicyAssignmentSpec Spec { get; set; }

    /// <summary>ManagementGroupPolicyAssignmentStatus defines the observed state of ManagementGroupPolicyAssignment.</summary>
    [JsonPropertyName("status")]
    public V1beta1ManagementGroupPolicyAssignmentStatus? Status { get; set; }
}
#nullable disable
