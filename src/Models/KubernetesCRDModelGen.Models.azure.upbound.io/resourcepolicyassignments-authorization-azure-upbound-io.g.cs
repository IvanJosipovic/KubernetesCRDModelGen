using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.authorization.azure.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecForProviderIdentity
{
    /// <summary>A list of User Managed Identity IDs which should be assigned to the Policy Definition.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Type of Managed Identity which should be added to this Policy Definition. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecForProviderNonComplianceMessage
{
    /// <summary>The non-compliance message text. When assigning policy sets (initiatives), unless policy_definition_reference_id is specified then this message will be the default for all policies.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>When assigning policy sets (initiatives), this is the ID of the policy definition that the non-compliance message applies to.</summary>
    [JsonPropertyName("policyDefinitionReferenceId")]
    public string? PolicyDefinitionReferenceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecForProviderOverridesSelectors
{
    /// <summary>The list of allowed values for the specified kind. Cannot be used with not_in. Can contain up to 50 values.</summary>
    [JsonPropertyName("in")]
    public IList<string>? In { get; set; }

    /// <summary>The list of not-allowed values for the specified kind. Cannot be used with in. Can contain up to 50 values.</summary>
    [JsonPropertyName("notIn")]
    public IList<string>? NotIn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecForProviderOverrides
{
    /// <summary>One or more override_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta1ResourcePolicyAssignmentSpecForProviderOverridesSelectors>? Selectors { get; set; }

    /// <summary>Specifies the value to override the policy property. Possible values for policyEffect override listed policy effects.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecForProviderResourceSelectorsSelectors
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecForProviderResourceSelectors
{
    /// <summary>Specifies a name for the resource selector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more resource_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta1ResourcePolicyAssignmentSpecForProviderResourceSelectorsSelectors>? Selectors { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecForProvider
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
    public IList<V1beta1ResourcePolicyAssignmentSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>The Azure Region where the Policy Assignment should exist. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A JSON mapping of any Metadata for this Policy.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>The name which should be used for this Policy Assignment. Changing this forces a new Resource Policy Assignment to be created. Cannot exceed 64 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more non_compliance_message blocks as defined below.</summary>
    [JsonPropertyName("nonComplianceMessage")]
    public IList<V1beta1ResourcePolicyAssignmentSpecForProviderNonComplianceMessage>? NonComplianceMessage { get; set; }

    /// <summary>Specifies a list of Resource Scopes (for example a Subscription, or a Resource Group) within this Management Group which are excluded from this Policy.</summary>
    [JsonPropertyName("notScopes")]
    public IList<string>? NotScopes { get; set; }

    /// <summary>One or more overrides blocks as defined below. More detail about overrides and resource_selectors see policy assignment structure</summary>
    [JsonPropertyName("overrides")]
    public IList<V1beta1ResourcePolicyAssignmentSpecForProviderOverrides>? Overrides { get; set; }

    /// <summary>A JSON mapping of any Parameters for this Policy.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The ID of the Policy Definition or Policy Definition Set. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("policyDefinitionId")]
    public string? PolicyDefinitionId { get; set; }

    /// <summary>Reference to a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
    [JsonPropertyName("policyDefinitionIdRef")]
    public V1beta1ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdRef? PolicyDefinitionIdRef { get; set; }

    /// <summary>Selector for a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
    [JsonPropertyName("policyDefinitionIdSelector")]
    public V1beta1ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdSelector? PolicyDefinitionIdSelector { get; set; }

    /// <summary>The ID of the Resource (or Resource Scope) where this should be applied. Changing this forces a new Resource Policy Assignment to be created.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>One or more resource_selectors blocks as defined below to filter polices by resource properties.</summary>
    [JsonPropertyName("resourceSelectors")]
    public IList<V1beta1ResourcePolicyAssignmentSpecForProviderResourceSelectors>? ResourceSelectors { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecInitProviderIdentity
{
    /// <summary>A list of User Managed Identity IDs which should be assigned to the Policy Definition.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Type of Managed Identity which should be added to this Policy Definition. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecInitProviderNonComplianceMessage
{
    /// <summary>The non-compliance message text. When assigning policy sets (initiatives), unless policy_definition_reference_id is specified then this message will be the default for all policies.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>When assigning policy sets (initiatives), this is the ID of the policy definition that the non-compliance message applies to.</summary>
    [JsonPropertyName("policyDefinitionReferenceId")]
    public string? PolicyDefinitionReferenceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecInitProviderOverridesSelectors
{
    /// <summary>The list of allowed values for the specified kind. Cannot be used with not_in. Can contain up to 50 values.</summary>
    [JsonPropertyName("in")]
    public IList<string>? In { get; set; }

    /// <summary>The list of not-allowed values for the specified kind. Cannot be used with in. Can contain up to 50 values.</summary>
    [JsonPropertyName("notIn")]
    public IList<string>? NotIn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecInitProviderOverrides
{
    /// <summary>One or more override_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta1ResourcePolicyAssignmentSpecInitProviderOverridesSelectors>? Selectors { get; set; }

    /// <summary>Specifies the value to override the policy property. Possible values for policyEffect override listed policy effects.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecInitProviderResourceSelectorsSelectors
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecInitProviderResourceSelectors
{
    /// <summary>Specifies a name for the resource selector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more resource_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta1ResourcePolicyAssignmentSpecInitProviderResourceSelectorsSelectors>? Selectors { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecInitProvider
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
    public IList<V1beta1ResourcePolicyAssignmentSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>The Azure Region where the Policy Assignment should exist. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A JSON mapping of any Metadata for this Policy.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>The name which should be used for this Policy Assignment. Changing this forces a new Resource Policy Assignment to be created. Cannot exceed 64 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more non_compliance_message blocks as defined below.</summary>
    [JsonPropertyName("nonComplianceMessage")]
    public IList<V1beta1ResourcePolicyAssignmentSpecInitProviderNonComplianceMessage>? NonComplianceMessage { get; set; }

    /// <summary>Specifies a list of Resource Scopes (for example a Subscription, or a Resource Group) within this Management Group which are excluded from this Policy.</summary>
    [JsonPropertyName("notScopes")]
    public IList<string>? NotScopes { get; set; }

    /// <summary>One or more overrides blocks as defined below. More detail about overrides and resource_selectors see policy assignment structure</summary>
    [JsonPropertyName("overrides")]
    public IList<V1beta1ResourcePolicyAssignmentSpecInitProviderOverrides>? Overrides { get; set; }

    /// <summary>A JSON mapping of any Parameters for this Policy.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The ID of the Policy Definition or Policy Definition Set. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("policyDefinitionId")]
    public string? PolicyDefinitionId { get; set; }

    /// <summary>Reference to a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
    [JsonPropertyName("policyDefinitionIdRef")]
    public V1beta1ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdRef? PolicyDefinitionIdRef { get; set; }

    /// <summary>Selector for a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
    [JsonPropertyName("policyDefinitionIdSelector")]
    public V1beta1ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdSelector? PolicyDefinitionIdSelector { get; set; }

    /// <summary>The ID of the Resource (or Resource Scope) where this should be applied. Changing this forces a new Resource Policy Assignment to be created.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>One or more resource_selectors blocks as defined below to filter polices by resource properties.</summary>
    [JsonPropertyName("resourceSelectors")]
    public IList<V1beta1ResourcePolicyAssignmentSpecInitProviderResourceSelectors>? ResourceSelectors { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecProviderConfigRefPolicy
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
public partial class V1beta1ResourcePolicyAssignmentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourcePolicyAssignmentSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourcePolicyAssignmentSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ResourcePolicyAssignmentSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ResourcePolicyAssignmentSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ResourcePolicyAssignmentSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ResourcePolicyAssignmentSpec defines the desired state of ResourcePolicyAssignment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ResourcePolicyAssignmentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ResourcePolicyAssignmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ResourcePolicyAssignmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ResourcePolicyAssignmentSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ResourcePolicyAssignmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentStatusAtProviderIdentity
{
    /// <summary>A list of User Managed Identity IDs which should be assigned to the Policy Definition.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID of the Policy Assignment for this Resource.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID of the Policy Assignment for this Resource.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>The Type of Managed Identity which should be added to this Policy Definition. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentStatusAtProviderNonComplianceMessage
{
    /// <summary>The non-compliance message text. When assigning policy sets (initiatives), unless policy_definition_reference_id is specified then this message will be the default for all policies.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>When assigning policy sets (initiatives), this is the ID of the policy definition that the non-compliance message applies to.</summary>
    [JsonPropertyName("policyDefinitionReferenceId")]
    public string? PolicyDefinitionReferenceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentStatusAtProviderOverridesSelectors
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentStatusAtProviderOverrides
{
    /// <summary>One or more override_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta1ResourcePolicyAssignmentStatusAtProviderOverridesSelectors>? Selectors { get; set; }

    /// <summary>Specifies the value to override the policy property. Possible values for policyEffect override listed policy effects.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentStatusAtProviderResourceSelectorsSelectors
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentStatusAtProviderResourceSelectors
{
    /// <summary>Specifies a name for the resource selector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more resource_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta1ResourcePolicyAssignmentStatusAtProviderResourceSelectorsSelectors>? Selectors { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentStatusAtProvider
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

    /// <summary>The ID of the Resource Policy Assignment.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ResourcePolicyAssignmentStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>The Azure Region where the Policy Assignment should exist. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A JSON mapping of any Metadata for this Policy.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>The name which should be used for this Policy Assignment. Changing this forces a new Resource Policy Assignment to be created. Cannot exceed 64 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more non_compliance_message blocks as defined below.</summary>
    [JsonPropertyName("nonComplianceMessage")]
    public IList<V1beta1ResourcePolicyAssignmentStatusAtProviderNonComplianceMessage>? NonComplianceMessage { get; set; }

    /// <summary>Specifies a list of Resource Scopes (for example a Subscription, or a Resource Group) within this Management Group which are excluded from this Policy.</summary>
    [JsonPropertyName("notScopes")]
    public IList<string>? NotScopes { get; set; }

    /// <summary>One or more overrides blocks as defined below. More detail about overrides and resource_selectors see policy assignment structure</summary>
    [JsonPropertyName("overrides")]
    public IList<V1beta1ResourcePolicyAssignmentStatusAtProviderOverrides>? Overrides { get; set; }

    /// <summary>A JSON mapping of any Parameters for this Policy.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The ID of the Policy Definition or Policy Definition Set. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("policyDefinitionId")]
    public string? PolicyDefinitionId { get; set; }

    /// <summary>The ID of the Resource (or Resource Scope) where this should be applied. Changing this forces a new Resource Policy Assignment to be created.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>One or more resource_selectors blocks as defined below to filter polices by resource properties.</summary>
    [JsonPropertyName("resourceSelectors")]
    public IList<V1beta1ResourcePolicyAssignmentStatusAtProviderResourceSelectors>? ResourceSelectors { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentStatusConditions
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

/// <summary>ResourcePolicyAssignmentStatus defines the observed state of ResourcePolicyAssignment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyAssignmentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ResourcePolicyAssignmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ResourcePolicyAssignmentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ResourcePolicyAssignment is the Schema for the ResourcePolicyAssignments API. Manages a Policy Assignment to a Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ResourcePolicyAssignment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ResourcePolicyAssignmentSpec>, IStatus<V1beta1ResourcePolicyAssignmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ResourcePolicyAssignment";
    public const string KubeGroup = "authorization.azure.upbound.io";
    public const string KubePluralName = "resourcepolicyassignments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ResourcePolicyAssignmentSpec defines the desired state of ResourcePolicyAssignment</summary>
    [JsonPropertyName("spec")]
    public V1beta1ResourcePolicyAssignmentSpec Spec { get; set; }

    /// <summary>ResourcePolicyAssignmentStatus defines the observed state of ResourcePolicyAssignment.</summary>
    [JsonPropertyName("status")]
    public V1beta1ResourcePolicyAssignmentStatus? Status { get; set; }
}