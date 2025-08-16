using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary>ComputeNetworkEdgeSecurityService is the Schema for the ComputeNetworkEdgeSecurityService API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ComputeNetworkEdgeSecurityServiceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ComputeNetworkEdgeSecurityService>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ComputeNetworkEdgeSecurityServiceList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computenetworkedgesecurityservices";
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
    public IList<V1alpha1ComputeNetworkEdgeSecurityService> Items { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeNetworkEdgeSecurityServiceSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The resource URL for the network edge security service associated with this network edge security service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeNetworkEdgeSecurityServiceSpecSecurityPolicyRef
{
    /// <summary>The value of an externally managed ComputeSecurityPolicy resource</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeSecurityPolicy resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeSecurityPolicy resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ComputeNetworkEdgeSecurityServiceSpec defines the desired state of ComputeNetworkEdgeSecurityService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeNetworkEdgeSecurityServiceSpec
{
    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Fingerprint of this resource. A hash of the contents stored in this object. This field is used in optimistic locking. This field will be ignored when inserting a NetworkEdgeSecurityService. An up-to-date fingerprint must be provided in order to update the NetworkEdgeSecurityService, otherwise the request will fail with error 412 conditionNotMet. To see the latest fingerprint, make a get() request to retrieve a NetworkEdgeSecurityService.</summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1ComputeNetworkEdgeSecurityServiceSpecProjectRef ProjectRef { get; set; }

    /// <summary>The ComputeNetworkEdgeSecurityService name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The resource URL for the network edge security service associated with this network edge security service.</summary>
    [JsonPropertyName("securityPolicyRef")]
    public V1alpha1ComputeNetworkEdgeSecurityServiceSpecSecurityPolicyRef? SecurityPolicyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeNetworkEdgeSecurityServiceStatusConditions
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeNetworkEdgeSecurityServiceStatusObservedState
{
    /// <summary>[Output Only] Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>[Output Only] The unique identifier for the resource. This identifier is defined by the server.</summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>[Output only] Type of the resource. Always compute#networkEdgeSecurityService for NetworkEdgeSecurityServices</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>[Output Only] URL of the region where the resource resides. You must specify this field as part of the HTTP request URL. It is not settable as a field in the request body.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>[Output Only] Server-defined URL for the resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>[Output Only] Server-defined URL for this resource with the resource id.</summary>
    [JsonPropertyName("selfLinkWithID")]
    public string? SelfLinkWithID { get; set; }
}

/// <summary>ComputeNetworkEdgeSecurityServiceStatus defines the config connector machine state of ComputeNetworkEdgeSecurityService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeNetworkEdgeSecurityServiceStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ComputeNetworkEdgeSecurityServiceStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ComputeNetworkEdgeSecurityService resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1ComputeNetworkEdgeSecurityServiceStatusObservedState? ObservedState { get; set; }
}

/// <summary>ComputeNetworkEdgeSecurityService is the Schema for the ComputeNetworkEdgeSecurityService API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ComputeNetworkEdgeSecurityService : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ComputeNetworkEdgeSecurityServiceSpec>, IStatus<V1alpha1ComputeNetworkEdgeSecurityServiceStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ComputeNetworkEdgeSecurityService";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computenetworkedgesecurityservices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ComputeNetworkEdgeSecurityServiceSpec defines the desired state of ComputeNetworkEdgeSecurityService</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ComputeNetworkEdgeSecurityServiceSpec Spec { get; set; }

    /// <summary>ComputeNetworkEdgeSecurityServiceStatus defines the config connector machine state of ComputeNetworkEdgeSecurityService</summary>
    [JsonPropertyName("status")]
    public V1alpha1ComputeNetworkEdgeSecurityServiceStatus? Status { get; set; }
}