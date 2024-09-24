using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
/// <summary>ClusterInformationSpec contains the values of describing the cluster.</summary>
public partial class V1ClusterInformationSpec
{
    /// <summary>CalicoVersion is the version of Calico that the cluster is running</summary>
    [JsonPropertyName("calicoVersion")]
    public string? CalicoVersion { get; set; }

    /// <summary>ClusterGUID is the GUID of the cluster</summary>
    [JsonPropertyName("clusterGUID")]
    public string? ClusterGUID { get; set; }

    /// <summary>ClusterType describes the type of the cluster</summary>
    [JsonPropertyName("clusterType")]
    public string? ClusterType { get; set; }

    /// <summary>DatastoreReady is used during significant datastore migrations to signal to components such as Felix that it should wait before accessing the datastore.</summary>
    [JsonPropertyName("datastoreReady")]
    public bool? DatastoreReady { get; set; }

    /// <summary>Variant declares which variant of Calico should be active.</summary>
    [JsonPropertyName("variant")]
    public string? Variant { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>ClusterInformation contains the cluster specific information.</summary>
public partial class V1ClusterInformation : IKubernetesObject<V1ObjectMeta>, ISpec<V1ClusterInformationSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ClusterInformation";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "clusterinformations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClusterInformationSpec contains the values of describing the cluster.</summary>
    [JsonPropertyName("spec")]
    public V1ClusterInformationSpec? Spec { get; set; }
}