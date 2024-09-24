using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigee.gcp.upbound.io;
public enum V1beta1EnvgroupAttachmentSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1EnvgroupAttachmentSpecForProviderEnvgroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvgroupAttachmentSpecForProviderEnvgroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EnvgroupAttachmentSpecForProviderEnvgroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvgroupAttachmentSpecForProviderEnvgroupIdRefPolicyResolutionEnum>))]
    public V1beta1EnvgroupAttachmentSpecForProviderEnvgroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvgroupAttachmentSpecForProviderEnvgroupIdRefPolicyResolveEnum>))]
    public V1beta1EnvgroupAttachmentSpecForProviderEnvgroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Envgroup in apigee to populate envgroupId.</summary>
public partial class V1beta1EnvgroupAttachmentSpecForProviderEnvgroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvgroupAttachmentSpecForProviderEnvgroupIdRefPolicy? Policy { get; set; }
}

public enum V1beta1EnvgroupAttachmentSpecForProviderEnvgroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvgroupAttachmentSpecForProviderEnvgroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EnvgroupAttachmentSpecForProviderEnvgroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvgroupAttachmentSpecForProviderEnvgroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1EnvgroupAttachmentSpecForProviderEnvgroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvgroupAttachmentSpecForProviderEnvgroupIdSelectorPolicyResolveEnum>))]
    public V1beta1EnvgroupAttachmentSpecForProviderEnvgroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Envgroup in apigee to populate envgroupId.</summary>
public partial class V1beta1EnvgroupAttachmentSpecForProviderEnvgroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvgroupAttachmentSpecForProviderEnvgroupIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1EnvgroupAttachmentSpecForProviderEnvironmentRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvgroupAttachmentSpecForProviderEnvironmentRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EnvgroupAttachmentSpecForProviderEnvironmentRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvgroupAttachmentSpecForProviderEnvironmentRefPolicyResolutionEnum>))]
    public V1beta1EnvgroupAttachmentSpecForProviderEnvironmentRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvgroupAttachmentSpecForProviderEnvironmentRefPolicyResolveEnum>))]
    public V1beta1EnvgroupAttachmentSpecForProviderEnvironmentRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Environment in apigee to populate environment.</summary>
public partial class V1beta1EnvgroupAttachmentSpecForProviderEnvironmentRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvgroupAttachmentSpecForProviderEnvironmentRefPolicy? Policy { get; set; }
}

public enum V1beta1EnvgroupAttachmentSpecForProviderEnvironmentSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvgroupAttachmentSpecForProviderEnvironmentSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EnvgroupAttachmentSpecForProviderEnvironmentSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvgroupAttachmentSpecForProviderEnvironmentSelectorPolicyResolutionEnum>))]
    public V1beta1EnvgroupAttachmentSpecForProviderEnvironmentSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvgroupAttachmentSpecForProviderEnvironmentSelectorPolicyResolveEnum>))]
    public V1beta1EnvgroupAttachmentSpecForProviderEnvironmentSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Environment in apigee to populate environment.</summary>
public partial class V1beta1EnvgroupAttachmentSpecForProviderEnvironmentSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvgroupAttachmentSpecForProviderEnvironmentSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1EnvgroupAttachmentSpecForProvider
{
    /// <summary>The Apigee environment group associated with the Apigee environment, in the format organizations/{{org_name}}/envgroups/{{envgroup_name}}.</summary>
    [JsonPropertyName("envgroupId")]
    public string? EnvgroupId { get; set; }

    /// <summary>Reference to a Envgroup in apigee to populate envgroupId.</summary>
    [JsonPropertyName("envgroupIdRef")]
    public V1beta1EnvgroupAttachmentSpecForProviderEnvgroupIdRef? EnvgroupIdRef { get; set; }

    /// <summary>Selector for a Envgroup in apigee to populate envgroupId.</summary>
    [JsonPropertyName("envgroupIdSelector")]
    public V1beta1EnvgroupAttachmentSpecForProviderEnvgroupIdSelector? EnvgroupIdSelector { get; set; }

    /// <summary>The resource ID of the environment.</summary>
    [JsonPropertyName("environment")]
    public string? Environment { get; set; }

    /// <summary>Reference to a Environment in apigee to populate environment.</summary>
    [JsonPropertyName("environmentRef")]
    public V1beta1EnvgroupAttachmentSpecForProviderEnvironmentRef? EnvironmentRef { get; set; }

    /// <summary>Selector for a Environment in apigee to populate environment.</summary>
    [JsonPropertyName("environmentSelector")]
    public V1beta1EnvgroupAttachmentSpecForProviderEnvironmentSelector? EnvironmentSelector { get; set; }
}

public enum V1beta1EnvgroupAttachmentSpecInitProviderEnvgroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvgroupAttachmentSpecInitProviderEnvgroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EnvgroupAttachmentSpecInitProviderEnvgroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvgroupAttachmentSpecInitProviderEnvgroupIdRefPolicyResolutionEnum>))]
    public V1beta1EnvgroupAttachmentSpecInitProviderEnvgroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvgroupAttachmentSpecInitProviderEnvgroupIdRefPolicyResolveEnum>))]
    public V1beta1EnvgroupAttachmentSpecInitProviderEnvgroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Envgroup in apigee to populate envgroupId.</summary>
public partial class V1beta1EnvgroupAttachmentSpecInitProviderEnvgroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvgroupAttachmentSpecInitProviderEnvgroupIdRefPolicy? Policy { get; set; }
}

public enum V1beta1EnvgroupAttachmentSpecInitProviderEnvgroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvgroupAttachmentSpecInitProviderEnvgroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EnvgroupAttachmentSpecInitProviderEnvgroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvgroupAttachmentSpecInitProviderEnvgroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1EnvgroupAttachmentSpecInitProviderEnvgroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvgroupAttachmentSpecInitProviderEnvgroupIdSelectorPolicyResolveEnum>))]
    public V1beta1EnvgroupAttachmentSpecInitProviderEnvgroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Envgroup in apigee to populate envgroupId.</summary>
public partial class V1beta1EnvgroupAttachmentSpecInitProviderEnvgroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvgroupAttachmentSpecInitProviderEnvgroupIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1EnvgroupAttachmentSpecInitProviderEnvironmentRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvgroupAttachmentSpecInitProviderEnvironmentRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EnvgroupAttachmentSpecInitProviderEnvironmentRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvgroupAttachmentSpecInitProviderEnvironmentRefPolicyResolutionEnum>))]
    public V1beta1EnvgroupAttachmentSpecInitProviderEnvironmentRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvgroupAttachmentSpecInitProviderEnvironmentRefPolicyResolveEnum>))]
    public V1beta1EnvgroupAttachmentSpecInitProviderEnvironmentRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Environment in apigee to populate environment.</summary>
public partial class V1beta1EnvgroupAttachmentSpecInitProviderEnvironmentRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvgroupAttachmentSpecInitProviderEnvironmentRefPolicy? Policy { get; set; }
}

public enum V1beta1EnvgroupAttachmentSpecInitProviderEnvironmentSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvgroupAttachmentSpecInitProviderEnvironmentSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EnvgroupAttachmentSpecInitProviderEnvironmentSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvgroupAttachmentSpecInitProviderEnvironmentSelectorPolicyResolutionEnum>))]
    public V1beta1EnvgroupAttachmentSpecInitProviderEnvironmentSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvgroupAttachmentSpecInitProviderEnvironmentSelectorPolicyResolveEnum>))]
    public V1beta1EnvgroupAttachmentSpecInitProviderEnvironmentSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Environment in apigee to populate environment.</summary>
public partial class V1beta1EnvgroupAttachmentSpecInitProviderEnvironmentSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvgroupAttachmentSpecInitProviderEnvironmentSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1EnvgroupAttachmentSpecInitProvider
{
    /// <summary>The Apigee environment group associated with the Apigee environment, in the format organizations/{{org_name}}/envgroups/{{envgroup_name}}.</summary>
    [JsonPropertyName("envgroupId")]
    public string? EnvgroupId { get; set; }

    /// <summary>Reference to a Envgroup in apigee to populate envgroupId.</summary>
    [JsonPropertyName("envgroupIdRef")]
    public V1beta1EnvgroupAttachmentSpecInitProviderEnvgroupIdRef? EnvgroupIdRef { get; set; }

    /// <summary>Selector for a Envgroup in apigee to populate envgroupId.</summary>
    [JsonPropertyName("envgroupIdSelector")]
    public V1beta1EnvgroupAttachmentSpecInitProviderEnvgroupIdSelector? EnvgroupIdSelector { get; set; }

    /// <summary>The resource ID of the environment.</summary>
    [JsonPropertyName("environment")]
    public string? Environment { get; set; }

    /// <summary>Reference to a Environment in apigee to populate environment.</summary>
    [JsonPropertyName("environmentRef")]
    public V1beta1EnvgroupAttachmentSpecInitProviderEnvironmentRef? EnvironmentRef { get; set; }

    /// <summary>Selector for a Environment in apigee to populate environment.</summary>
    [JsonPropertyName("environmentSelector")]
    public V1beta1EnvgroupAttachmentSpecInitProviderEnvironmentSelector? EnvironmentSelector { get; set; }
}

public enum V1beta1EnvgroupAttachmentSpecManagementPoliciesEnum
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

public enum V1beta1EnvgroupAttachmentSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvgroupAttachmentSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EnvgroupAttachmentSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvgroupAttachmentSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1EnvgroupAttachmentSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvgroupAttachmentSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1EnvgroupAttachmentSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1EnvgroupAttachmentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvgroupAttachmentSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1EnvgroupAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvgroupAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EnvgroupAttachmentSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvgroupAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1EnvgroupAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvgroupAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1EnvgroupAttachmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1EnvgroupAttachmentSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvgroupAttachmentSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1EnvgroupAttachmentSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1EnvgroupAttachmentSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1EnvgroupAttachmentSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1EnvgroupAttachmentSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1EnvgroupAttachmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>EnvgroupAttachmentSpec defines the desired state of EnvgroupAttachment</summary>
public partial class V1beta1EnvgroupAttachmentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvgroupAttachmentSpecDeletionPolicyEnum>))]
    public V1beta1EnvgroupAttachmentSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1EnvgroupAttachmentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1EnvgroupAttachmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1EnvgroupAttachmentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EnvgroupAttachmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1EnvgroupAttachmentSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EnvgroupAttachmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1EnvgroupAttachmentStatusAtProvider
{
    /// <summary>The Apigee environment group associated with the Apigee environment, in the format organizations/{{org_name}}/envgroups/{{envgroup_name}}.</summary>
    [JsonPropertyName("envgroupId")]
    public string? EnvgroupId { get; set; }

    /// <summary>The resource ID of the environment.</summary>
    [JsonPropertyName("environment")]
    public string? Environment { get; set; }

    /// <summary>an identifier for the resource with format {{envgroup_id}}/attachments/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the newly created  attachment (output parameter).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1EnvgroupAttachmentStatusConditions
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

/// <summary>EnvgroupAttachmentStatus defines the observed state of EnvgroupAttachment.</summary>
public partial class V1beta1EnvgroupAttachmentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1EnvgroupAttachmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EnvgroupAttachmentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>EnvgroupAttachment is the Schema for the EnvgroupAttachments API. An</summary>
public partial class V1beta1EnvgroupAttachment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EnvgroupAttachmentSpec>, IStatus<V1beta1EnvgroupAttachmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EnvgroupAttachment";
    public const string KubeGroup = "apigee.gcp.upbound.io";
    public const string KubePluralName = "envgroupattachments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EnvgroupAttachmentSpec defines the desired state of EnvgroupAttachment</summary>
    [JsonPropertyName("spec")]
    public V1beta1EnvgroupAttachmentSpec Spec { get; set; }

    /// <summary>EnvgroupAttachmentStatus defines the observed state of EnvgroupAttachment.</summary>
    [JsonPropertyName("status")]
    public V1beta1EnvgroupAttachmentStatus? Status { get; set; }
}