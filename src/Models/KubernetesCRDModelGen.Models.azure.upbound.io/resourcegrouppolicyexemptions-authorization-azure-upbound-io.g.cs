using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.authorization.azure.upbound.io;
/// <summary>ResourceGroupPolicyExemption is the Schema for the ResourceGroupPolicyExemptions API. Manages a Resource Group Policy Exemption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ResourceGroupPolicyExemptionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ResourceGroupPolicyExemption>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ResourceGroupPolicyExemptionList";
    public const string KubeGroup = "authorization.azure.upbound.io";
    public const string KubePluralName = "resourcegrouppolicyexemptions";
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
    public IList<V1beta1ResourceGroupPolicyExemption> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceGroupPolicyExemptionSpecForProviderPolicyAssignmentIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroupPolicyAssignment in authorization to populate policyAssignmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceGroupPolicyExemptionSpecForProviderPolicyAssignmentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourceGroupPolicyExemptionSpecForProviderPolicyAssignmentIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceGroupPolicyExemptionSpecForProviderPolicyAssignmentIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroupPolicyAssignment in authorization to populate policyAssignmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceGroupPolicyExemptionSpecForProviderPolicyAssignmentIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourceGroupPolicyExemptionSpecForProviderPolicyAssignmentIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceGroupPolicyExemptionSpecForProviderResourceGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceGroupPolicyExemptionSpecForProviderResourceGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourceGroupPolicyExemptionSpecForProviderResourceGroupIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceGroupPolicyExemptionSpecForProviderResourceGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceGroupPolicyExemptionSpecForProviderResourceGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourceGroupPolicyExemptionSpecForProviderResourceGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceGroupPolicyExemptionSpecForProvider
{
    /// <summary>A description to use for this Policy Exemption.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A friendly display name to use for this Policy Exemption.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The category of this policy exemption. Possible values are Waiver and Mitigated.</summary>
    [JsonPropertyName("exemptionCategory")]
    public string? ExemptionCategory { get; set; }

    /// <summary>The expiration date and time in UTC ISO 8601 format of this policy exemption.</summary>
    [JsonPropertyName("expiresOn")]
    public string? ExpiresOn { get; set; }

    /// <summary>The metadata for this policy exemption. This is a JSON string representing additional metadata that should be stored with the policy exemption.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>The ID of the Policy Assignment to be exempted at the specified Scope. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("policyAssignmentId")]
    public string? PolicyAssignmentId { get; set; }

    /// <summary>Reference to a ResourceGroupPolicyAssignment in authorization to populate policyAssignmentId.</summary>
    [JsonPropertyName("policyAssignmentIdRef")]
    public V1beta1ResourceGroupPolicyExemptionSpecForProviderPolicyAssignmentIdRef? PolicyAssignmentIdRef { get; set; }

    /// <summary>Selector for a ResourceGroupPolicyAssignment in authorization to populate policyAssignmentId.</summary>
    [JsonPropertyName("policyAssignmentIdSelector")]
    public V1beta1ResourceGroupPolicyExemptionSpecForProviderPolicyAssignmentIdSelector? PolicyAssignmentIdSelector { get; set; }

    /// <summary>The policy definition reference ID list when the associated policy assignment is an assignment of a policy set definition.</summary>
    [JsonPropertyName("policyDefinitionReferenceIds")]
    public IList<string>? PolicyDefinitionReferenceIds { get; set; }

    /// <summary>The Resource Group ID where the Policy Exemption should be applied. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupId.</summary>
    [JsonPropertyName("resourceGroupIdRef")]
    public V1beta1ResourceGroupPolicyExemptionSpecForProviderResourceGroupIdRef? ResourceGroupIdRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupId.</summary>
    [JsonPropertyName("resourceGroupIdSelector")]
    public V1beta1ResourceGroupPolicyExemptionSpecForProviderResourceGroupIdSelector? ResourceGroupIdSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceGroupPolicyExemptionSpecInitProviderPolicyAssignmentIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroupPolicyAssignment in authorization to populate policyAssignmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceGroupPolicyExemptionSpecInitProviderPolicyAssignmentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourceGroupPolicyExemptionSpecInitProviderPolicyAssignmentIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceGroupPolicyExemptionSpecInitProviderPolicyAssignmentIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroupPolicyAssignment in authorization to populate policyAssignmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceGroupPolicyExemptionSpecInitProviderPolicyAssignmentIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourceGroupPolicyExemptionSpecInitProviderPolicyAssignmentIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceGroupPolicyExemptionSpecInitProvider
{
    /// <summary>A description to use for this Policy Exemption.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A friendly display name to use for this Policy Exemption.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The category of this policy exemption. Possible values are Waiver and Mitigated.</summary>
    [JsonPropertyName("exemptionCategory")]
    public string? ExemptionCategory { get; set; }

    /// <summary>The expiration date and time in UTC ISO 8601 format of this policy exemption.</summary>
    [JsonPropertyName("expiresOn")]
    public string? ExpiresOn { get; set; }

    /// <summary>The metadata for this policy exemption. This is a JSON string representing additional metadata that should be stored with the policy exemption.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>The ID of the Policy Assignment to be exempted at the specified Scope. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("policyAssignmentId")]
    public string? PolicyAssignmentId { get; set; }

    /// <summary>Reference to a ResourceGroupPolicyAssignment in authorization to populate policyAssignmentId.</summary>
    [JsonPropertyName("policyAssignmentIdRef")]
    public V1beta1ResourceGroupPolicyExemptionSpecInitProviderPolicyAssignmentIdRef? PolicyAssignmentIdRef { get; set; }

    /// <summary>Selector for a ResourceGroupPolicyAssignment in authorization to populate policyAssignmentId.</summary>
    [JsonPropertyName("policyAssignmentIdSelector")]
    public V1beta1ResourceGroupPolicyExemptionSpecInitProviderPolicyAssignmentIdSelector? PolicyAssignmentIdSelector { get; set; }

    /// <summary>The policy definition reference ID list when the associated policy assignment is an assignment of a policy set definition.</summary>
    [JsonPropertyName("policyDefinitionReferenceIds")]
    public IList<string>? PolicyDefinitionReferenceIds { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceGroupPolicyExemptionSpecProviderConfigRefPolicy
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
public partial class V1beta1ResourceGroupPolicyExemptionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourceGroupPolicyExemptionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceGroupPolicyExemptionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ResourceGroupPolicyExemptionSpec defines the desired state of ResourceGroupPolicyExemption</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceGroupPolicyExemptionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ResourceGroupPolicyExemptionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ResourceGroupPolicyExemptionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ResourceGroupPolicyExemptionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ResourceGroupPolicyExemptionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceGroupPolicyExemptionStatusAtProvider
{
    /// <summary>A description to use for this Policy Exemption.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A friendly display name to use for this Policy Exemption.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The category of this policy exemption. Possible values are Waiver and Mitigated.</summary>
    [JsonPropertyName("exemptionCategory")]
    public string? ExemptionCategory { get; set; }

    /// <summary>The expiration date and time in UTC ISO 8601 format of this policy exemption.</summary>
    [JsonPropertyName("expiresOn")]
    public string? ExpiresOn { get; set; }

    /// <summary>The Policy Exemption id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The metadata for this policy exemption. This is a JSON string representing additional metadata that should be stored with the policy exemption.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>The ID of the Policy Assignment to be exempted at the specified Scope. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("policyAssignmentId")]
    public string? PolicyAssignmentId { get; set; }

    /// <summary>The policy definition reference ID list when the associated policy assignment is an assignment of a policy set definition.</summary>
    [JsonPropertyName("policyDefinitionReferenceIds")]
    public IList<string>? PolicyDefinitionReferenceIds { get; set; }

    /// <summary>The Resource Group ID where the Policy Exemption should be applied. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceGroupPolicyExemptionStatusConditions
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

/// <summary>ResourceGroupPolicyExemptionStatus defines the observed state of ResourceGroupPolicyExemption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceGroupPolicyExemptionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ResourceGroupPolicyExemptionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ResourceGroupPolicyExemptionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ResourceGroupPolicyExemption is the Schema for the ResourceGroupPolicyExemptions API. Manages a Resource Group Policy Exemption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ResourceGroupPolicyExemption : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ResourceGroupPolicyExemptionSpec>, IStatus<V1beta1ResourceGroupPolicyExemptionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ResourceGroupPolicyExemption";
    public const string KubeGroup = "authorization.azure.upbound.io";
    public const string KubePluralName = "resourcegrouppolicyexemptions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ResourceGroupPolicyExemptionSpec defines the desired state of ResourceGroupPolicyExemption</summary>
    [JsonPropertyName("spec")]
    public V1beta1ResourceGroupPolicyExemptionSpec Spec { get; set; }

    /// <summary>ResourceGroupPolicyExemptionStatus defines the observed state of ResourceGroupPolicyExemption.</summary>
    [JsonPropertyName("status")]
    public V1beta1ResourceGroupPolicyExemptionStatus? Status { get; set; }
}