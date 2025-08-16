using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networkconnectivity.cnrm.cloud.google.com;
/// <summary>NetworkConnectivityInternalRange is the Schema for the NetworkConnectivityInternalRange API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkConnectivityInternalRangeList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1NetworkConnectivityInternalRange>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkConnectivityInternalRangeList";
    public const string KubeGroup = "networkconnectivity.cnrm.cloud.google.com";
    public const string KubePluralName = "networkconnectivityinternalranges";
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
    public IList<V1alpha1NetworkConnectivityInternalRange> Items { get; set; }
}

/// <summary>Optional. Must be present if usage is set to FOR_MIGRATION. This field is for internal use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityInternalRangeSpecMigration
{
    /// <summary>Immutable. Resource path as an URI of the source resource, for example a subnet. The project for the source resource should match the project for the InternalRange. An example: /projects/{project}/regions/{region}/subnetworks/{subnet}</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Immutable. Resource path of the target resource. The target project can be different, as in the cases when migrating to peer networks. The resource For example: /projects/{project}/regions/{region}/subnetworks/{subnet}</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>The network in which to reserve the internal range. The network cannot be deleted if there are any reserved internal ranges referring to it. Legacy networks are not supported. For example: https://www.googleapis.com/compute/v1/projects/{project}/locations/global/networks/{network} projects/{project}/locations/global/networks/{network} {network}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityInternalRangeSpecNetworkRef
{
    /// <summary>A reference to an externally managed Compute Network resource. Should be in the format `projects/{{projectID}}/global/networks/{{network}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. The host project of the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityInternalRangeSpecProjectRef
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

/// <summary>NetworkConnectivityInternalRangeSpec defines the desired state of NetworkConnectivityInternalRange</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityInternalRangeSpec
{
    /// <summary>A description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The IP range that this internal range defines. NOTE: IPv6 ranges are limited to usage=EXTERNAL_TO_VPC and peering=FOR_SELF. NOTE: For IPv6 Ranges this field is compulsory, i.e. the address range must be specified explicitly.</summary>
    [JsonPropertyName("ipCIDRRange")]
    public string? IpCIDRRange { get; set; }

    /// <summary>User-defined labels.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Required. The location of the application.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Optional. Must be present if usage is set to FOR_MIGRATION. This field is for internal use.</summary>
    [JsonPropertyName("migration")]
    public V1alpha1NetworkConnectivityInternalRangeSpecMigration? Migration { get; set; }

    /// <summary>The network in which to reserve the internal range. The network cannot be deleted if there are any reserved internal ranges referring to it. Legacy networks are not supported. For example: https://www.googleapis.com/compute/v1/projects/{project}/locations/global/networks/{network} projects/{project}/locations/global/networks/{network} {network}</summary>
    [JsonPropertyName("networkRef")]
    public V1alpha1NetworkConnectivityInternalRangeSpecNetworkRef? NetworkRef { get; set; }

    /// <summary>Optional. Types of resources that are allowed to overlap with the current internal range.</summary>
    [JsonPropertyName("overlaps")]
    public IList<string>? Overlaps { get; set; }

    /// <summary>The type of peering set for this internal range.</summary>
    [JsonPropertyName("peering")]
    public string? Peering { get; set; }

    /// <summary>An alternate to ip_cidr_range. Can be set when trying to create an IPv4 reservation that automatically finds a free range of the given size. If both ip_cidr_range and prefix_length are set, there is an error if the range sizes do not match. Can also be used during updates to change the range size. NOTE: For IPv6 this field only works if ip_cidr_range is set as well, and both fields must match. In other words, with IPv6 this field only works as a redundant parameter.</summary>
    [JsonPropertyName("prefixLength")]
    public int? PrefixLength { get; set; }

    /// <summary>Required. The host project of the application.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1NetworkConnectivityInternalRangeSpecProjectRef? ProjectRef { get; set; }

    /// <summary>The NetworkConnectivityInternalRange name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. Can be set to narrow down or pick a different address space while searching for a free range. If not set, defaults to the "10.0.0.0/8" address space. This can be used to search in other rfc-1918 address spaces like "172.16.0.0/12" and "192.168.0.0/16" or non-rfc-1918 address spaces used in the VPC.</summary>
    [JsonPropertyName("targetCIDRRange")]
    public IList<string>? TargetCIDRRange { get; set; }

    /// <summary>The type of usage set for this InternalRange.</summary>
    [JsonPropertyName("usage")]
    public string? Usage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityInternalRangeStatusConditions
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
public partial class V1alpha1NetworkConnectivityInternalRangeStatusObservedState
{
    /// <summary>Time when the internal range was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Time when the internal range was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Output only. The list of resources that refer to this internal range. Resources that use the internal range for their range allocation are referred to as users of the range. Other resources mark themselves as users while doing so by creating a reference to this internal range. Having a user, based on this reference, prevents deletion of the internal range referred to. Can be empty.</summary>
    [JsonPropertyName("users")]
    public IList<string>? Users { get; set; }
}

/// <summary>NetworkConnectivityInternalRangeStatus defines the config connector machine state of NetworkConnectivityInternalRange</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityInternalRangeStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NetworkConnectivityInternalRangeStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the NetworkConnectivityInternalRange resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1NetworkConnectivityInternalRangeStatusObservedState? ObservedState { get; set; }
}

/// <summary>NetworkConnectivityInternalRange is the Schema for the NetworkConnectivityInternalRange API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkConnectivityInternalRange : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NetworkConnectivityInternalRangeSpec>, IStatus<V1alpha1NetworkConnectivityInternalRangeStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkConnectivityInternalRange";
    public const string KubeGroup = "networkconnectivity.cnrm.cloud.google.com";
    public const string KubePluralName = "networkconnectivityinternalranges";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetworkConnectivityInternalRangeSpec defines the desired state of NetworkConnectivityInternalRange</summary>
    [JsonPropertyName("spec")]
    public V1alpha1NetworkConnectivityInternalRangeSpec Spec { get; set; }

    /// <summary>NetworkConnectivityInternalRangeStatus defines the config connector machine state of NetworkConnectivityInternalRange</summary>
    [JsonPropertyName("status")]
    public V1alpha1NetworkConnectivityInternalRangeStatus? Status { get; set; }
}