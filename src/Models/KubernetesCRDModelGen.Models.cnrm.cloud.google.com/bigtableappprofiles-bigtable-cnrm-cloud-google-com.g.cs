using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigtable.cnrm.cloud.google.com;
/// <summary>BigtableAppProfile is the Schema for the BigtableAppProfile API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BigtableAppProfileList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BigtableAppProfile>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BigtableAppProfileList";
    public const string KubeGroup = "bigtable.cnrm.cloud.google.com";
    public const string KubePluralName = "bigtableappprofiles";
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
    public IList<V1beta1BigtableAppProfile> Items { get; set; }
}

/// <summary>Specifies that this app profile is intended for read-only usage via the Data Boost feature. Please opt-in to this feature by setting the `alpha.cnrm.cloud.google.com/reconciler: direct` annotation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigtableAppProfileSpecDataBoostIsolationReadOnly
{
    /// <summary>The Compute Billing Owner for this Data Boost App Profile.</summary>
    [JsonPropertyName("computeBillingOwner")]
    public string? ComputeBillingOwner { get; set; }
}

/// <summary>InstanceRef defines the resource reference to BigtableInstance, which "External" field holds the GCP identifier for the KRM object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigtableAppProfileSpecInstanceRef
{
    /// <summary>A reference to an externally managed BigtableInstance resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BigtableInstance resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BigtableInstance resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Use a single-cluster routing policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigtableAppProfileSpecSingleClusterRouting
{
    /// <summary>Whether or not `CheckAndMutateRow` and `ReadModifyWriteRow` requests are allowed by this app profile. It is unsafe to send these requests to the same table/row/column in multiple clusters.</summary>
    [JsonPropertyName("allowTransactionalWrites")]
    public bool? AllowTransactionalWrites { get; set; }

    /// <summary>The cluster to which read/write requests should be routed.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }
}

/// <summary>The standard options used for isolating this app profile's traffic from other use cases.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigtableAppProfileSpecStandardIsolation
{
    /// <summary>The priority of requests sent using this app profile.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }
}

/// <summary>BigtableAppProfileSpec defines the desired state of BigtableAppProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigtableAppProfileSpec
{
    /// <summary>Specifies that this app profile is intended for read-only usage via the Data Boost feature. Please opt-in to this feature by setting the `alpha.cnrm.cloud.google.com/reconciler: direct` annotation.</summary>
    [JsonPropertyName("dataBoostIsolationReadOnly")]
    public V1beta1BigtableAppProfileSpecDataBoostIsolationReadOnly? DataBoostIsolationReadOnly { get; set; }

    /// <summary>Long form description of the use case for this AppProfile.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>InstanceRef defines the resource reference to BigtableInstance, which "External" field holds the GCP identifier for the KRM object.</summary>
    [JsonPropertyName("instanceRef")]
    public V1beta1BigtableAppProfileSpecInstanceRef InstanceRef { get; set; }

    /// <summary>The set of clusters to route to, if using multi cluster routing. The order is ignored; clusters will be tried in order of distance. If left empty, all clusters are eligible.</summary>
    [JsonPropertyName("multiClusterRoutingClusterIds")]
    public IList<string>? MultiClusterRoutingClusterIds { get; set; }

    /// <summary>Use a multi-cluster routing policy.</summary>
    [JsonPropertyName("multiClusterRoutingUseAny")]
    public bool? MultiClusterRoutingUseAny { get; set; }

    /// <summary>The BigtableAppProfile name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Use a single-cluster routing policy.</summary>
    [JsonPropertyName("singleClusterRouting")]
    public V1beta1BigtableAppProfileSpecSingleClusterRouting? SingleClusterRouting { get; set; }

    /// <summary>The standard options used for isolating this app profile's traffic from other use cases.</summary>
    [JsonPropertyName("standardIsolation")]
    public V1beta1BigtableAppProfileSpecStandardIsolation? StandardIsolation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigtableAppProfileStatusConditions
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

/// <summary>BigtableAppProfileStatus defines the config connector machine state of BigtableAppProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigtableAppProfileStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BigtableAppProfileStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BigtableAppProfile resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>The unique name of the app profile. Values are of the form `projects/{project}/instances/{instance}/appProfiles/[_a-zA-Z0-9][-_.a-zA-Z0-9]*`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BigtableAppProfile is the Schema for the BigtableAppProfile API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BigtableAppProfile : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BigtableAppProfileSpec>, IStatus<V1beta1BigtableAppProfileStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BigtableAppProfile";
    public const string KubeGroup = "bigtable.cnrm.cloud.google.com";
    public const string KubePluralName = "bigtableappprofiles";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BigtableAppProfileSpec defines the desired state of BigtableAppProfile</summary>
    [JsonPropertyName("spec")]
    public V1beta1BigtableAppProfileSpec Spec { get; set; }

    /// <summary>BigtableAppProfileStatus defines the config connector machine state of BigtableAppProfile</summary>
    [JsonPropertyName("status")]
    public V1beta1BigtableAppProfileStatus? Status { get; set; }
}