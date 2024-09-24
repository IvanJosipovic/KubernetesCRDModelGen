using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appmesh.aws.upbound.io;
public enum V1beta1VirtualServiceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1VirtualServiceSpecForProviderMeshNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualServiceSpecForProviderMeshNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VirtualServiceSpecForProviderMeshNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecForProviderMeshNameRefPolicyResolutionEnum>))]
    public V1beta1VirtualServiceSpecForProviderMeshNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecForProviderMeshNameRefPolicyResolveEnum>))]
    public V1beta1VirtualServiceSpecForProviderMeshNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mesh in appmesh to populate meshName.</summary>
public partial class V1beta1VirtualServiceSpecForProviderMeshNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualServiceSpecForProviderMeshNameRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualServiceSpecForProviderMeshNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualServiceSpecForProviderMeshNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VirtualServiceSpecForProviderMeshNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecForProviderMeshNameSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualServiceSpecForProviderMeshNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecForProviderMeshNameSelectorPolicyResolveEnum>))]
    public V1beta1VirtualServiceSpecForProviderMeshNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mesh in appmesh to populate meshName.</summary>
public partial class V1beta1VirtualServiceSpecForProviderMeshNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualServiceSpecForProviderMeshNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNodeVirtualNodeNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNodeVirtualNodeNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNodeVirtualNodeNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNodeVirtualNodeNameRefPolicyResolutionEnum>))]
    public V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNodeVirtualNodeNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNodeVirtualNodeNameRefPolicyResolveEnum>))]
    public V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNodeVirtualNodeNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualNode in appmesh to populate virtualNodeName.</summary>
public partial class V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNodeVirtualNodeNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNodeVirtualNodeNameRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNodeVirtualNodeNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNodeVirtualNodeNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNodeVirtualNodeNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNodeVirtualNodeNameSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNodeVirtualNodeNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNodeVirtualNodeNameSelectorPolicyResolveEnum>))]
    public V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNodeVirtualNodeNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualNode in appmesh to populate virtualNodeName.</summary>
public partial class V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNodeVirtualNodeNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNodeVirtualNodeNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNode
{
    /// <summary>Name of the virtual node that is acting as a service provider. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNodeName")]
    public string? VirtualNodeName { get; set; }

    /// <summary>Reference to a VirtualNode in appmesh to populate virtualNodeName.</summary>
    [JsonPropertyName("virtualNodeNameRef")]
    public V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNodeVirtualNodeNameRef? VirtualNodeNameRef { get; set; }

    /// <summary>Selector for a VirtualNode in appmesh to populate virtualNodeName.</summary>
    [JsonPropertyName("virtualNodeNameSelector")]
    public V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNodeVirtualNodeNameSelector? VirtualNodeNameSelector { get; set; }
}

public enum V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouterVirtualRouterNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouterVirtualRouterNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouterVirtualRouterNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouterVirtualRouterNameRefPolicyResolutionEnum>))]
    public V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouterVirtualRouterNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouterVirtualRouterNameRefPolicyResolveEnum>))]
    public V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouterVirtualRouterNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualRouter in appmesh to populate virtualRouterName.</summary>
public partial class V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouterVirtualRouterNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouterVirtualRouterNameRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouterVirtualRouterNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouterVirtualRouterNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouterVirtualRouterNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouterVirtualRouterNameSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouterVirtualRouterNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouterVirtualRouterNameSelectorPolicyResolveEnum>))]
    public V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouterVirtualRouterNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualRouter in appmesh to populate virtualRouterName.</summary>
public partial class V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouterVirtualRouterNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouterVirtualRouterNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouter
{
    /// <summary>Name of the virtual router that is acting as a service provider. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualRouterName")]
    public string? VirtualRouterName { get; set; }

    /// <summary>Reference to a VirtualRouter in appmesh to populate virtualRouterName.</summary>
    [JsonPropertyName("virtualRouterNameRef")]
    public V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouterVirtualRouterNameRef? VirtualRouterNameRef { get; set; }

    /// <summary>Selector for a VirtualRouter in appmesh to populate virtualRouterName.</summary>
    [JsonPropertyName("virtualRouterNameSelector")]
    public V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouterVirtualRouterNameSelector? VirtualRouterNameSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1VirtualServiceSpecForProviderSpecProvider
{
    /// <summary>Virtual node associated with a virtual service.</summary>
    [JsonPropertyName("virtualNode")]
    public IList<V1beta1VirtualServiceSpecForProviderSpecProviderVirtualNode>? VirtualNode { get; set; }

    /// <summary>Virtual router associated with a virtual service.</summary>
    [JsonPropertyName("virtualRouter")]
    public IList<V1beta1VirtualServiceSpecForProviderSpecProviderVirtualRouter>? VirtualRouter { get; set; }
}

/// <summary></summary>
public partial class V1beta1VirtualServiceSpecForProviderSpec
{
    /// <summary>App Mesh object that is acting as the provider for a virtual service. You can specify a single virtual node or virtual router.</summary>
    [JsonPropertyName("provider")]
    public IList<V1beta1VirtualServiceSpecForProviderSpecProvider>? Provider { get; set; }
}

/// <summary></summary>
public partial class V1beta1VirtualServiceSpecForProvider
{
    /// <summary>Name of the service mesh in which to create the virtual service. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>Reference to a Mesh in appmesh to populate meshName.</summary>
    [JsonPropertyName("meshNameRef")]
    public V1beta1VirtualServiceSpecForProviderMeshNameRef? MeshNameRef { get; set; }

    /// <summary>Selector for a Mesh in appmesh to populate meshName.</summary>
    [JsonPropertyName("meshNameSelector")]
    public V1beta1VirtualServiceSpecForProviderMeshNameSelector? MeshNameSelector { get; set; }

    /// <summary>AWS account ID of the service mesh's owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the virtual service. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Virtual service specification to apply.</summary>
    [JsonPropertyName("spec")]
    public IList<V1beta1VirtualServiceSpecForProviderSpec>? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1VirtualServiceSpecInitProviderMeshNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualServiceSpecInitProviderMeshNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VirtualServiceSpecInitProviderMeshNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecInitProviderMeshNameRefPolicyResolutionEnum>))]
    public V1beta1VirtualServiceSpecInitProviderMeshNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecInitProviderMeshNameRefPolicyResolveEnum>))]
    public V1beta1VirtualServiceSpecInitProviderMeshNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mesh in appmesh to populate meshName.</summary>
public partial class V1beta1VirtualServiceSpecInitProviderMeshNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualServiceSpecInitProviderMeshNameRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualServiceSpecInitProviderMeshNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualServiceSpecInitProviderMeshNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VirtualServiceSpecInitProviderMeshNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecInitProviderMeshNameSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualServiceSpecInitProviderMeshNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecInitProviderMeshNameSelectorPolicyResolveEnum>))]
    public V1beta1VirtualServiceSpecInitProviderMeshNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mesh in appmesh to populate meshName.</summary>
public partial class V1beta1VirtualServiceSpecInitProviderMeshNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualServiceSpecInitProviderMeshNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNodeVirtualNodeNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNodeVirtualNodeNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNodeVirtualNodeNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNodeVirtualNodeNameRefPolicyResolutionEnum>))]
    public V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNodeVirtualNodeNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNodeVirtualNodeNameRefPolicyResolveEnum>))]
    public V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNodeVirtualNodeNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualNode in appmesh to populate virtualNodeName.</summary>
public partial class V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNodeVirtualNodeNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNodeVirtualNodeNameRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNodeVirtualNodeNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNodeVirtualNodeNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNodeVirtualNodeNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNodeVirtualNodeNameSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNodeVirtualNodeNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNodeVirtualNodeNameSelectorPolicyResolveEnum>))]
    public V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNodeVirtualNodeNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualNode in appmesh to populate virtualNodeName.</summary>
public partial class V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNodeVirtualNodeNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNodeVirtualNodeNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNode
{
    /// <summary>Name of the virtual node that is acting as a service provider. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNodeName")]
    public string? VirtualNodeName { get; set; }

    /// <summary>Reference to a VirtualNode in appmesh to populate virtualNodeName.</summary>
    [JsonPropertyName("virtualNodeNameRef")]
    public V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNodeVirtualNodeNameRef? VirtualNodeNameRef { get; set; }

    /// <summary>Selector for a VirtualNode in appmesh to populate virtualNodeName.</summary>
    [JsonPropertyName("virtualNodeNameSelector")]
    public V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNodeVirtualNodeNameSelector? VirtualNodeNameSelector { get; set; }
}

public enum V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouterVirtualRouterNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouterVirtualRouterNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouterVirtualRouterNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouterVirtualRouterNameRefPolicyResolutionEnum>))]
    public V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouterVirtualRouterNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouterVirtualRouterNameRefPolicyResolveEnum>))]
    public V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouterVirtualRouterNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualRouter in appmesh to populate virtualRouterName.</summary>
public partial class V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouterVirtualRouterNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouterVirtualRouterNameRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouterVirtualRouterNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouterVirtualRouterNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouterVirtualRouterNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouterVirtualRouterNameSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouterVirtualRouterNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouterVirtualRouterNameSelectorPolicyResolveEnum>))]
    public V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouterVirtualRouterNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualRouter in appmesh to populate virtualRouterName.</summary>
public partial class V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouterVirtualRouterNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouterVirtualRouterNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouter
{
    /// <summary>Name of the virtual router that is acting as a service provider. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualRouterName")]
    public string? VirtualRouterName { get; set; }

    /// <summary>Reference to a VirtualRouter in appmesh to populate virtualRouterName.</summary>
    [JsonPropertyName("virtualRouterNameRef")]
    public V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouterVirtualRouterNameRef? VirtualRouterNameRef { get; set; }

    /// <summary>Selector for a VirtualRouter in appmesh to populate virtualRouterName.</summary>
    [JsonPropertyName("virtualRouterNameSelector")]
    public V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouterVirtualRouterNameSelector? VirtualRouterNameSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1VirtualServiceSpecInitProviderSpecProvider
{
    /// <summary>Virtual node associated with a virtual service.</summary>
    [JsonPropertyName("virtualNode")]
    public IList<V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualNode>? VirtualNode { get; set; }

    /// <summary>Virtual router associated with a virtual service.</summary>
    [JsonPropertyName("virtualRouter")]
    public IList<V1beta1VirtualServiceSpecInitProviderSpecProviderVirtualRouter>? VirtualRouter { get; set; }
}

/// <summary></summary>
public partial class V1beta1VirtualServiceSpecInitProviderSpec
{
    /// <summary>App Mesh object that is acting as the provider for a virtual service. You can specify a single virtual node or virtual router.</summary>
    [JsonPropertyName("provider")]
    public IList<V1beta1VirtualServiceSpecInitProviderSpecProvider>? Provider { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1VirtualServiceSpecInitProvider
{
    /// <summary>Name of the service mesh in which to create the virtual service. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>Reference to a Mesh in appmesh to populate meshName.</summary>
    [JsonPropertyName("meshNameRef")]
    public V1beta1VirtualServiceSpecInitProviderMeshNameRef? MeshNameRef { get; set; }

    /// <summary>Selector for a Mesh in appmesh to populate meshName.</summary>
    [JsonPropertyName("meshNameSelector")]
    public V1beta1VirtualServiceSpecInitProviderMeshNameSelector? MeshNameSelector { get; set; }

    /// <summary>AWS account ID of the service mesh's owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the virtual service. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Virtual service specification to apply.</summary>
    [JsonPropertyName("spec")]
    public IList<V1beta1VirtualServiceSpecInitProviderSpec>? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1VirtualServiceSpecManagementPoliciesEnum
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

public enum V1beta1VirtualServiceSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualServiceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VirtualServiceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1VirtualServiceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1VirtualServiceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1VirtualServiceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualServiceSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualServiceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualServiceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VirtualServiceSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1VirtualServiceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1VirtualServiceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1VirtualServiceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualServiceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1VirtualServiceSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1VirtualServiceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1VirtualServiceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1VirtualServiceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1VirtualServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>VirtualServiceSpec defines the desired state of VirtualService</summary>
public partial class V1beta1VirtualServiceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecDeletionPolicyEnum>))]
    public V1beta1VirtualServiceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VirtualServiceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VirtualServiceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1VirtualServiceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VirtualServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1VirtualServiceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VirtualServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1VirtualServiceStatusAtProviderSpecProviderVirtualNode
{
    /// <summary>Name of the virtual node that is acting as a service provider. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNodeName")]
    public string? VirtualNodeName { get; set; }
}

/// <summary></summary>
public partial class V1beta1VirtualServiceStatusAtProviderSpecProviderVirtualRouter
{
    /// <summary>Name of the virtual router that is acting as a service provider. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualRouterName")]
    public string? VirtualRouterName { get; set; }
}

/// <summary></summary>
public partial class V1beta1VirtualServiceStatusAtProviderSpecProvider
{
    /// <summary>Virtual node associated with a virtual service.</summary>
    [JsonPropertyName("virtualNode")]
    public IList<V1beta1VirtualServiceStatusAtProviderSpecProviderVirtualNode>? VirtualNode { get; set; }

    /// <summary>Virtual router associated with a virtual service.</summary>
    [JsonPropertyName("virtualRouter")]
    public IList<V1beta1VirtualServiceStatusAtProviderSpecProviderVirtualRouter>? VirtualRouter { get; set; }
}

/// <summary></summary>
public partial class V1beta1VirtualServiceStatusAtProviderSpec
{
    /// <summary>App Mesh object that is acting as the provider for a virtual service. You can specify a single virtual node or virtual router.</summary>
    [JsonPropertyName("provider")]
    public IList<V1beta1VirtualServiceStatusAtProviderSpecProvider>? Provider { get; set; }
}

/// <summary></summary>
public partial class V1beta1VirtualServiceStatusAtProvider
{
    /// <summary>ARN of the virtual service.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Creation date of the virtual service.</summary>
    [JsonPropertyName("createdDate")]
    public string? CreatedDate { get; set; }

    /// <summary>ID of the virtual service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Last update date of the virtual service.</summary>
    [JsonPropertyName("lastUpdatedDate")]
    public string? LastUpdatedDate { get; set; }

    /// <summary>Name of the service mesh in which to create the virtual service. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>AWS account ID of the service mesh's owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the virtual service. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Resource owner's AWS account ID.</summary>
    [JsonPropertyName("resourceOwner")]
    public string? ResourceOwner { get; set; }

    /// <summary>Virtual service specification to apply.</summary>
    [JsonPropertyName("spec")]
    public IList<V1beta1VirtualServiceStatusAtProviderSpec>? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1VirtualServiceStatusConditions
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

/// <summary>VirtualServiceStatus defines the observed state of VirtualService.</summary>
public partial class V1beta1VirtualServiceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VirtualServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VirtualServiceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>VirtualService is the Schema for the VirtualServices API. Provides an AWS App Mesh virtual service resource.</summary>
public partial class V1beta1VirtualService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VirtualServiceSpec>, IStatus<V1beta1VirtualServiceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VirtualService";
    public const string KubeGroup = "appmesh.aws.upbound.io";
    public const string KubePluralName = "virtualservices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VirtualServiceSpec defines the desired state of VirtualService</summary>
    [JsonPropertyName("spec")]
    public V1beta1VirtualServiceSpec Spec { get; set; }

    /// <summary>VirtualServiceStatus defines the observed state of VirtualService.</summary>
    [JsonPropertyName("status")]
    public V1beta1VirtualServiceStatus? Status { get; set; }
}