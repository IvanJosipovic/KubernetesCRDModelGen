using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lexmodels.aws.m.upbound.io;
/// <summary>SlotType is the Schema for the SlotTypes API. Provides details about a specific Amazon Lex Slot Type</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SlotTypeList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SlotType>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SlotTypeList";
    public const string KubeGroup = "lexmodels.aws.m.upbound.io";
    public const string KubePluralName = "slottypes";
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
    public IList<V1beta1SlotType> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SlotTypeSpecForProviderEnumerationValue
{
    /// <summary>Additional values related to the slot type value. Each item must be less than or equal to 140 characters in length.</summary>
    [JsonPropertyName("synonyms")]
    public IList<string>? Synonyms { get; set; }

    /// <summary>The value of the slot type. Must be less than or equal to 140 characters in length.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SlotTypeSpecForProvider
{
    /// <summary>Determines if a new slot type version is created when the initial resource is created and on each update. Defaults to false.</summary>
    [JsonPropertyName("createVersion")]
    public bool? CreateVersion { get; set; }

    /// <summary>A description of the slot type. Must be less than or equal to 200 characters in length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A list of EnumerationValue objects that defines the values that the slot type can take. Each value can have a list of synonyms, which are additional values that help train the machine learning model about the values that it resolves for a slot. Attributes are documented under enumeration_value.</summary>
    [JsonPropertyName("enumerationValue")]
    public IList<V1beta1SlotTypeSpecForProviderEnumerationValue>? EnumerationValue { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Determines the slot resolution strategy that Amazon Lex uses to return slot type values. ORIGINAL_VALUE returns the value entered by the user if the user value is similar to the slot value. TOP_RESOLUTION returns the first value in the resolution list if there is a resolution list for the slot, otherwise null is returned. Defaults to ORIGINAL_VALUE.</summary>
    [JsonPropertyName("valueSelectionStrategy")]
    public string? ValueSelectionStrategy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SlotTypeSpecInitProviderEnumerationValue
{
    /// <summary>Additional values related to the slot type value. Each item must be less than or equal to 140 characters in length.</summary>
    [JsonPropertyName("synonyms")]
    public IList<string>? Synonyms { get; set; }

    /// <summary>The value of the slot type. Must be less than or equal to 140 characters in length.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SlotTypeSpecInitProvider
{
    /// <summary>Determines if a new slot type version is created when the initial resource is created and on each update. Defaults to false.</summary>
    [JsonPropertyName("createVersion")]
    public bool? CreateVersion { get; set; }

    /// <summary>A description of the slot type. Must be less than or equal to 200 characters in length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A list of EnumerationValue objects that defines the values that the slot type can take. Each value can have a list of synonyms, which are additional values that help train the machine learning model about the values that it resolves for a slot. Attributes are documented under enumeration_value.</summary>
    [JsonPropertyName("enumerationValue")]
    public IList<V1beta1SlotTypeSpecInitProviderEnumerationValue>? EnumerationValue { get; set; }

    /// <summary>Determines the slot resolution strategy that Amazon Lex uses to return slot type values. ORIGINAL_VALUE returns the value entered by the user if the user value is similar to the slot value. TOP_RESOLUTION returns the first value in the resolution list if there is a resolution list for the slot, otherwise null is returned. Defaults to ORIGINAL_VALUE.</summary>
    [JsonPropertyName("valueSelectionStrategy")]
    public string? ValueSelectionStrategy { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SlotTypeSpecProviderConfigRef
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
public partial class V1beta1SlotTypeSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SlotTypeSpec defines the desired state of SlotType</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SlotTypeSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SlotTypeSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SlotTypeSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SlotTypeSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SlotTypeSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SlotTypeStatusAtProviderEnumerationValue
{
    /// <summary>Additional values related to the slot type value. Each item must be less than or equal to 140 characters in length.</summary>
    [JsonPropertyName("synonyms")]
    public IList<string>? Synonyms { get; set; }

    /// <summary>The value of the slot type. Must be less than or equal to 140 characters in length.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SlotTypeStatusAtProvider
{
    /// <summary>Checksum identifying the version of the slot type that was created. The checksum is not included as an argument because the resource will add it automatically when updating the slot type.</summary>
    [JsonPropertyName("checksum")]
    public string? Checksum { get; set; }

    /// <summary>Determines if a new slot type version is created when the initial resource is created and on each update. Defaults to false.</summary>
    [JsonPropertyName("createVersion")]
    public bool? CreateVersion { get; set; }

    /// <summary>The date when the slot type version was created.</summary>
    [JsonPropertyName("createdDate")]
    public string? CreatedDate { get; set; }

    /// <summary>A description of the slot type. Must be less than or equal to 200 characters in length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A list of EnumerationValue objects that defines the values that the slot type can take. Each value can have a list of synonyms, which are additional values that help train the machine learning model about the values that it resolves for a slot. Attributes are documented under enumeration_value.</summary>
    [JsonPropertyName("enumerationValue")]
    public IList<V1beta1SlotTypeStatusAtProviderEnumerationValue>? EnumerationValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The date when the $LATEST version of this slot type was updated.</summary>
    [JsonPropertyName("lastUpdatedDate")]
    public string? LastUpdatedDate { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Determines the slot resolution strategy that Amazon Lex uses to return slot type values. ORIGINAL_VALUE returns the value entered by the user if the user value is similar to the slot value. TOP_RESOLUTION returns the first value in the resolution list if there is a resolution list for the slot, otherwise null is returned. Defaults to ORIGINAL_VALUE.</summary>
    [JsonPropertyName("valueSelectionStrategy")]
    public string? ValueSelectionStrategy { get; set; }

    /// <summary>The version of the slot type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SlotTypeStatusConditions
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

/// <summary>SlotTypeStatus defines the observed state of SlotType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SlotTypeStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SlotTypeStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SlotTypeStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SlotType is the Schema for the SlotTypes API. Provides details about a specific Amazon Lex Slot Type</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SlotType : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SlotTypeSpec>, IStatus<V1beta1SlotTypeStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SlotType";
    public const string KubeGroup = "lexmodels.aws.m.upbound.io";
    public const string KubePluralName = "slottypes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SlotTypeSpec defines the desired state of SlotType</summary>
    [JsonPropertyName("spec")]
    public V1beta1SlotTypeSpec Spec { get; set; }

    /// <summary>SlotTypeStatus defines the observed state of SlotType.</summary>
    [JsonPropertyName("status")]
    public V1beta1SlotTypeStatus? Status { get; set; }
}