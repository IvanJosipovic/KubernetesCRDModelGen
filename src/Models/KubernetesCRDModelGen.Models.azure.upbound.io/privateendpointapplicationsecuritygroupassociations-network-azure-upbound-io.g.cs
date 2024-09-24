using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderApplicationSecurityGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderApplicationSecurityGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderApplicationSecurityGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderApplicationSecurityGroupIdRefPolicyResolutionEnum>))]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderApplicationSecurityGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderApplicationSecurityGroupIdRefPolicyResolveEnum>))]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderApplicationSecurityGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ApplicationSecurityGroup in network to populate applicationSecurityGroupId.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderApplicationSecurityGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderApplicationSecurityGroupIdRefPolicy? Policy { get; set; }
}

public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderApplicationSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderApplicationSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderApplicationSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderApplicationSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderApplicationSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderApplicationSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderApplicationSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ApplicationSecurityGroup in network to populate applicationSecurityGroupId.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderApplicationSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderApplicationSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderPrivateEndpointIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderPrivateEndpointIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderPrivateEndpointIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderPrivateEndpointIdRefPolicyResolutionEnum>))]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderPrivateEndpointIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderPrivateEndpointIdRefPolicyResolveEnum>))]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderPrivateEndpointIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a PrivateEndpoint in network to populate privateEndpointId.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderPrivateEndpointIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderPrivateEndpointIdRefPolicy? Policy { get; set; }
}

public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderPrivateEndpointIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderPrivateEndpointIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderPrivateEndpointIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderPrivateEndpointIdSelectorPolicyResolutionEnum>))]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderPrivateEndpointIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderPrivateEndpointIdSelectorPolicyResolveEnum>))]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderPrivateEndpointIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a PrivateEndpoint in network to populate privateEndpointId.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderPrivateEndpointIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderPrivateEndpointIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProvider
{
    /// <summary>The id of application security group to associate. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("applicationSecurityGroupId")]
    public string? ApplicationSecurityGroupId { get; set; }

    /// <summary>Reference to a ApplicationSecurityGroup in network to populate applicationSecurityGroupId.</summary>
    [JsonPropertyName("applicationSecurityGroupIdRef")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderApplicationSecurityGroupIdRef? ApplicationSecurityGroupIdRef { get; set; }

    /// <summary>Selector for a ApplicationSecurityGroup in network to populate applicationSecurityGroupId.</summary>
    [JsonPropertyName("applicationSecurityGroupIdSelector")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderApplicationSecurityGroupIdSelector? ApplicationSecurityGroupIdSelector { get; set; }

    /// <summary>The id of private endpoint to associate. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateEndpointId")]
    public string? PrivateEndpointId { get; set; }

    /// <summary>Reference to a PrivateEndpoint in network to populate privateEndpointId.</summary>
    [JsonPropertyName("privateEndpointIdRef")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderPrivateEndpointIdRef? PrivateEndpointIdRef { get; set; }

    /// <summary>Selector for a PrivateEndpoint in network to populate privateEndpointId.</summary>
    [JsonPropertyName("privateEndpointIdSelector")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProviderPrivateEndpointIdSelector? PrivateEndpointIdSelector { get; set; }
}

public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderApplicationSecurityGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderApplicationSecurityGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderApplicationSecurityGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderApplicationSecurityGroupIdRefPolicyResolutionEnum>))]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderApplicationSecurityGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderApplicationSecurityGroupIdRefPolicyResolveEnum>))]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderApplicationSecurityGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ApplicationSecurityGroup in network to populate applicationSecurityGroupId.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderApplicationSecurityGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderApplicationSecurityGroupIdRefPolicy? Policy { get; set; }
}

public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderApplicationSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderApplicationSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderApplicationSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderApplicationSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderApplicationSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderApplicationSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderApplicationSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ApplicationSecurityGroup in network to populate applicationSecurityGroupId.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderApplicationSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderApplicationSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderPrivateEndpointIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderPrivateEndpointIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderPrivateEndpointIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderPrivateEndpointIdRefPolicyResolutionEnum>))]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderPrivateEndpointIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderPrivateEndpointIdRefPolicyResolveEnum>))]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderPrivateEndpointIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a PrivateEndpoint in network to populate privateEndpointId.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderPrivateEndpointIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderPrivateEndpointIdRefPolicy? Policy { get; set; }
}

public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderPrivateEndpointIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderPrivateEndpointIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderPrivateEndpointIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderPrivateEndpointIdSelectorPolicyResolutionEnum>))]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderPrivateEndpointIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderPrivateEndpointIdSelectorPolicyResolveEnum>))]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderPrivateEndpointIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a PrivateEndpoint in network to populate privateEndpointId.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderPrivateEndpointIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderPrivateEndpointIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProvider
{
    /// <summary>The id of application security group to associate. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("applicationSecurityGroupId")]
    public string? ApplicationSecurityGroupId { get; set; }

    /// <summary>Reference to a ApplicationSecurityGroup in network to populate applicationSecurityGroupId.</summary>
    [JsonPropertyName("applicationSecurityGroupIdRef")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderApplicationSecurityGroupIdRef? ApplicationSecurityGroupIdRef { get; set; }

    /// <summary>Selector for a ApplicationSecurityGroup in network to populate applicationSecurityGroupId.</summary>
    [JsonPropertyName("applicationSecurityGroupIdSelector")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderApplicationSecurityGroupIdSelector? ApplicationSecurityGroupIdSelector { get; set; }

    /// <summary>The id of private endpoint to associate. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateEndpointId")]
    public string? PrivateEndpointId { get; set; }

    /// <summary>Reference to a PrivateEndpoint in network to populate privateEndpointId.</summary>
    [JsonPropertyName("privateEndpointIdRef")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderPrivateEndpointIdRef? PrivateEndpointIdRef { get; set; }

    /// <summary>Selector for a PrivateEndpoint in network to populate privateEndpointId.</summary>
    [JsonPropertyName("privateEndpointIdSelector")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProviderPrivateEndpointIdSelector? PrivateEndpointIdSelector { get; set; }
}

public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecManagementPoliciesEnum
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

public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>PrivateEndpointApplicationSecurityGroupAssociationSpec defines the desired state of PrivateEndpointApplicationSecurityGroupAssociation</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecDeletionPolicyEnum>))]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationStatusAtProvider
{
    /// <summary>The id of application security group to associate. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("applicationSecurityGroupId")]
    public string? ApplicationSecurityGroupId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The id of private endpoint to associate. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateEndpointId")]
    public string? PrivateEndpointId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationStatusConditions
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

/// <summary>PrivateEndpointApplicationSecurityGroupAssociationStatus defines the observed state of PrivateEndpointApplicationSecurityGroupAssociation.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PrivateEndpointApplicationSecurityGroupAssociationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>PrivateEndpointApplicationSecurityGroupAssociation is the Schema for the PrivateEndpointApplicationSecurityGroupAssociations API. Manages an association between Private Endpoint and Application Security Group.</summary>
public partial class V1beta1PrivateEndpointApplicationSecurityGroupAssociation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpec>, IStatus<V1beta1PrivateEndpointApplicationSecurityGroupAssociationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivateEndpointApplicationSecurityGroupAssociation";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "privateendpointapplicationsecuritygroupassociations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PrivateEndpointApplicationSecurityGroupAssociationSpec defines the desired state of PrivateEndpointApplicationSecurityGroupAssociation</summary>
    [JsonPropertyName("spec")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationSpec Spec { get; set; }

    /// <summary>PrivateEndpointApplicationSecurityGroupAssociationStatus defines the observed state of PrivateEndpointApplicationSecurityGroupAssociation.</summary>
    [JsonPropertyName("status")]
    public V1beta1PrivateEndpointApplicationSecurityGroupAssociationStatus? Status { get; set; }
}