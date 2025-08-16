using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.authorization.azure.m.upbound.io;
/// <summary>PolicySetDefinition is the Schema for the PolicySetDefinitions API. Manages a policy set definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PolicySetDefinitionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PolicySetDefinition>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PolicySetDefinitionList";
    public const string KubeGroup = "authorization.azure.m.upbound.io";
    public const string KubePluralName = "policysetdefinitions";
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
    public IList<V1beta1PolicySetDefinition> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionSpecForProviderManagementGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ManagementGroup in management to populate managementGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionSpecForProviderManagementGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PolicySetDefinitionSpecForProviderManagementGroupIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionSpecForProviderManagementGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ManagementGroup in management to populate managementGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionSpecForProviderManagementGroupIdSelector
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
    public V1beta1PolicySetDefinitionSpecForProviderManagementGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionSpecForProviderPolicyDefinitionGroup
{
    /// <summary>The ID of a resource that contains additional metadata for this Policy Definition Group.</summary>
    [JsonPropertyName("additionalMetadataResourceId")]
    public string? AdditionalMetadataResourceId { get; set; }

    /// <summary>The category of this Policy Definition Group.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The description of this Policy Definition Group.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of this Policy Definition Group.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The name which should be used for this Policy Definition Group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionSpecForProviderPolicyDefinitionReference
{
    /// <summary>Parameter values for the references Policy Definition in JSON format.</summary>
    [JsonPropertyName("parameterValues")]
    public string? ParameterValues { get; set; }

    /// <summary>The ID of the Policy Definition to include in this Policy Set Definition.</summary>
    [JsonPropertyName("policyDefinitionId")]
    public string? PolicyDefinitionId { get; set; }

    /// <summary>Specifies a list of Policy Definition Groups names that this Policy Definition Reference belongs to.</summary>
    [JsonPropertyName("policyGroupNames")]
    public IList<string>? PolicyGroupNames { get; set; }

    /// <summary>A unique ID within this Policy Set Definition for this Policy Definition Reference.</summary>
    [JsonPropertyName("referenceId")]
    public string? ReferenceId { get; set; }

    /// <summary>The version of the Policy Definition to use.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionSpecForProvider
{
    /// <summary>The description of this Policy Set Definition.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of this Policy Set Definition.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The ID of the Policy Set Definition.</summary>
    [JsonPropertyName("managementGroupId")]
    public string? ManagementGroupId { get; set; }

    /// <summary>Reference to a ManagementGroup in management to populate managementGroupId.</summary>
    [JsonPropertyName("managementGroupIdRef")]
    public V1beta1PolicySetDefinitionSpecForProviderManagementGroupIdRef? ManagementGroupIdRef { get; set; }

    /// <summary>Selector for a ManagementGroup in management to populate managementGroupId.</summary>
    [JsonPropertyName("managementGroupIdSelector")]
    public V1beta1PolicySetDefinitionSpecForProviderManagementGroupIdSelector? ManagementGroupIdSelector { get; set; }

    /// <summary>The metadata for the Policy Set Definition in JSON format.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>The parameters for the Policy Set Definition in JSON format.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>One or more policy_definition_group blocks as defined below.</summary>
    [JsonPropertyName("policyDefinitionGroup")]
    public IList<V1beta1PolicySetDefinitionSpecForProviderPolicyDefinitionGroup>? PolicyDefinitionGroup { get; set; }

    /// <summary>One or more policy_definition_reference blocks as defined below.</summary>
    [JsonPropertyName("policyDefinitionReference")]
    public IList<V1beta1PolicySetDefinitionSpecForProviderPolicyDefinitionReference>? PolicyDefinitionReference { get; set; }

    /// <summary>The Policy Set Definition type. Possible values are BuiltIn, Custom, NotSpecified, and Static. Changing this forces a new Policy Set Definition to be created.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionSpecInitProviderManagementGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ManagementGroup in management to populate managementGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionSpecInitProviderManagementGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PolicySetDefinitionSpecInitProviderManagementGroupIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionSpecInitProviderManagementGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ManagementGroup in management to populate managementGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionSpecInitProviderManagementGroupIdSelector
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
    public V1beta1PolicySetDefinitionSpecInitProviderManagementGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionSpecInitProviderPolicyDefinitionGroup
{
    /// <summary>The ID of a resource that contains additional metadata for this Policy Definition Group.</summary>
    [JsonPropertyName("additionalMetadataResourceId")]
    public string? AdditionalMetadataResourceId { get; set; }

    /// <summary>The category of this Policy Definition Group.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The description of this Policy Definition Group.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of this Policy Definition Group.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The name which should be used for this Policy Definition Group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionSpecInitProviderPolicyDefinitionReference
{
    /// <summary>Parameter values for the references Policy Definition in JSON format.</summary>
    [JsonPropertyName("parameterValues")]
    public string? ParameterValues { get; set; }

    /// <summary>The ID of the Policy Definition to include in this Policy Set Definition.</summary>
    [JsonPropertyName("policyDefinitionId")]
    public string? PolicyDefinitionId { get; set; }

    /// <summary>Specifies a list of Policy Definition Groups names that this Policy Definition Reference belongs to.</summary>
    [JsonPropertyName("policyGroupNames")]
    public IList<string>? PolicyGroupNames { get; set; }

    /// <summary>A unique ID within this Policy Set Definition for this Policy Definition Reference.</summary>
    [JsonPropertyName("referenceId")]
    public string? ReferenceId { get; set; }

    /// <summary>The version of the Policy Definition to use.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionSpecInitProvider
{
    /// <summary>The description of this Policy Set Definition.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of this Policy Set Definition.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The ID of the Policy Set Definition.</summary>
    [JsonPropertyName("managementGroupId")]
    public string? ManagementGroupId { get; set; }

    /// <summary>Reference to a ManagementGroup in management to populate managementGroupId.</summary>
    [JsonPropertyName("managementGroupIdRef")]
    public V1beta1PolicySetDefinitionSpecInitProviderManagementGroupIdRef? ManagementGroupIdRef { get; set; }

    /// <summary>Selector for a ManagementGroup in management to populate managementGroupId.</summary>
    [JsonPropertyName("managementGroupIdSelector")]
    public V1beta1PolicySetDefinitionSpecInitProviderManagementGroupIdSelector? ManagementGroupIdSelector { get; set; }

    /// <summary>The metadata for the Policy Set Definition in JSON format.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>The parameters for the Policy Set Definition in JSON format.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>One or more policy_definition_group blocks as defined below.</summary>
    [JsonPropertyName("policyDefinitionGroup")]
    public IList<V1beta1PolicySetDefinitionSpecInitProviderPolicyDefinitionGroup>? PolicyDefinitionGroup { get; set; }

    /// <summary>One or more policy_definition_reference blocks as defined below.</summary>
    [JsonPropertyName("policyDefinitionReference")]
    public IList<V1beta1PolicySetDefinitionSpecInitProviderPolicyDefinitionReference>? PolicyDefinitionReference { get; set; }

    /// <summary>The Policy Set Definition type. Possible values are BuiltIn, Custom, NotSpecified, and Static. Changing this forces a new Policy Set Definition to be created.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>PolicySetDefinitionSpec defines the desired state of PolicySetDefinition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PolicySetDefinitionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PolicySetDefinitionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PolicySetDefinitionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PolicySetDefinitionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionStatusAtProviderPolicyDefinitionGroup
{
    /// <summary>The ID of a resource that contains additional metadata for this Policy Definition Group.</summary>
    [JsonPropertyName("additionalMetadataResourceId")]
    public string? AdditionalMetadataResourceId { get; set; }

    /// <summary>The category of this Policy Definition Group.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The description of this Policy Definition Group.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of this Policy Definition Group.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The name which should be used for this Policy Definition Group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionStatusAtProviderPolicyDefinitionReference
{
    /// <summary>Parameter values for the references Policy Definition in JSON format.</summary>
    [JsonPropertyName("parameterValues")]
    public string? ParameterValues { get; set; }

    /// <summary>The ID of the Policy Definition to include in this Policy Set Definition.</summary>
    [JsonPropertyName("policyDefinitionId")]
    public string? PolicyDefinitionId { get; set; }

    /// <summary>Specifies a list of Policy Definition Groups names that this Policy Definition Reference belongs to.</summary>
    [JsonPropertyName("policyGroupNames")]
    public IList<string>? PolicyGroupNames { get; set; }

    /// <summary>A unique ID within this Policy Set Definition for this Policy Definition Reference.</summary>
    [JsonPropertyName("referenceId")]
    public string? ReferenceId { get; set; }

    /// <summary>The version of the Policy Definition to use.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionStatusAtProvider
{
    /// <summary>The description of this Policy Set Definition.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of this Policy Set Definition.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The ID of the Policy Set Definition.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the Policy Set Definition.</summary>
    [JsonPropertyName("managementGroupId")]
    public string? ManagementGroupId { get; set; }

    /// <summary>The metadata for the Policy Set Definition in JSON format.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>The parameters for the Policy Set Definition in JSON format.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>One or more policy_definition_group blocks as defined below.</summary>
    [JsonPropertyName("policyDefinitionGroup")]
    public IList<V1beta1PolicySetDefinitionStatusAtProviderPolicyDefinitionGroup>? PolicyDefinitionGroup { get; set; }

    /// <summary>One or more policy_definition_reference blocks as defined below.</summary>
    [JsonPropertyName("policyDefinitionReference")]
    public IList<V1beta1PolicySetDefinitionStatusAtProviderPolicyDefinitionReference>? PolicyDefinitionReference { get; set; }

    /// <summary>The Policy Set Definition type. Possible values are BuiltIn, Custom, NotSpecified, and Static. Changing this forces a new Policy Set Definition to be created.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionStatusConditions
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

/// <summary>PolicySetDefinitionStatus defines the observed state of PolicySetDefinition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySetDefinitionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PolicySetDefinitionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PolicySetDefinitionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>PolicySetDefinition is the Schema for the PolicySetDefinitions API. Manages a policy set definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PolicySetDefinition : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PolicySetDefinitionSpec>, IStatus<V1beta1PolicySetDefinitionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PolicySetDefinition";
    public const string KubeGroup = "authorization.azure.m.upbound.io";
    public const string KubePluralName = "policysetdefinitions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PolicySetDefinitionSpec defines the desired state of PolicySetDefinition</summary>
    [JsonPropertyName("spec")]
    public V1beta1PolicySetDefinitionSpec Spec { get; set; }

    /// <summary>PolicySetDefinitionStatus defines the observed state of PolicySetDefinition.</summary>
    [JsonPropertyName("status")]
    public V1beta1PolicySetDefinitionStatus? Status { get; set; }
}