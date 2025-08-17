using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.orgpolicy.cnrm.cloud.google.com;
#nullable enable
/// <summary>OrgPolicyCustomConstraint is the Schema for the OrgPolicyCustomConstraint API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1OrgPolicyCustomConstraintList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1OrgPolicyCustomConstraint>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "OrgPolicyCustomConstraintList";
    public const string KubeGroup = "orgpolicy.cnrm.cloud.google.com";
    public const string KubePluralName = "orgpolicycustomconstraints";
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
    public IList<V1alpha1OrgPolicyCustomConstraint> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Organization that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrgPolicyCustomConstraintSpecOrganizationRef
{
    /// <summary>The 'name' field of an organization, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string External { get; set; }
}
#nullable disable

#nullable enable
/// <summary>OrgPolicyCustomConstraintSpec defines the desired state of OrgPolicyCustomConstraint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrgPolicyCustomConstraintSpec
{
    /// <summary>Allow or deny type.</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>Org policy condition/expression. For example:  `resource.instanceName.matches("[production|test]_.*_(\d)+")` or,  `resource.management.auto_upgrade == true`   The max length of the condition is 1000 characters.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>Detailed information about this custom policy constraint. The max length of the description is 2000 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One line display name for the UI. The max length of the display_name is 200 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>All the operations being applied for this constraint.</summary>
    [JsonPropertyName("methodTypes")]
    public IList<string>? MethodTypes { get; set; }

    /// <summary>The Organization that this resource belongs to.</summary>
    [JsonPropertyName("organizationRef")]
    public V1alpha1OrgPolicyCustomConstraintSpecOrganizationRef OrganizationRef { get; set; }

    /// <summary>The OrgPolicyCustomConstraint name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. The resource instance type on which this policy applies. Format  will be of the form : `&lt;canonical service name&gt;/&lt;type&gt;` Example:    * `compute.googleapis.com/Instance`.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrgPolicyCustomConstraintStatusConditions
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
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrgPolicyCustomConstraintStatusObservedState
{
    /// <summary>Output only. The last time this custom constraint was updated. This represents the last time that the `CreateCustomConstraint` or `UpdateCustomConstraint` RPC was called</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>OrgPolicyCustomConstraintStatus defines the config connector machine state of OrgPolicyCustomConstraint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrgPolicyCustomConstraintStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1OrgPolicyCustomConstraintStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the OrgPolicyCustomConstraint resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1OrgPolicyCustomConstraintStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>OrgPolicyCustomConstraint is the Schema for the OrgPolicyCustomConstraint API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1OrgPolicyCustomConstraint : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1OrgPolicyCustomConstraintSpec>, IStatus<V1alpha1OrgPolicyCustomConstraintStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "OrgPolicyCustomConstraint";
    public const string KubeGroup = "orgpolicy.cnrm.cloud.google.com";
    public const string KubePluralName = "orgpolicycustomconstraints";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OrgPolicyCustomConstraintSpec defines the desired state of OrgPolicyCustomConstraint</summary>
    [JsonPropertyName("spec")]
    public V1alpha1OrgPolicyCustomConstraintSpec Spec { get; set; }

    /// <summary>OrgPolicyCustomConstraintStatus defines the config connector machine state of OrgPolicyCustomConstraint</summary>
    [JsonPropertyName("status")]
    public V1alpha1OrgPolicyCustomConstraintStatus? Status { get; set; }
}
#nullable disable
