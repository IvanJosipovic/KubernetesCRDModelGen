using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1BGPConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1BGPConfiguration>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BGPConfigurationList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "bgpconfigurations";
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
    public IList<V1BGPConfiguration> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecCommunities
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecNodeMeshPasswordSecretKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecNodeMeshPassword
{
    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1BGPConfigurationSpecNodeMeshPasswordSecretKeyRef? SecretKeyRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecPrefixAdvertisements
{
    /// <summary></summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    /// <summary></summary>
    [JsonPropertyName("communities")]
    public IList<string>? Communities { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecServiceClusterIPs
{
    /// <summary></summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecServiceExternalIPs
{
    /// <summary></summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecServiceLoadBalancerIPs
{
    /// <summary></summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpec
{
    /// <summary></summary>
    [JsonPropertyName("asNumber")]
    public int? AsNumber { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bindMode")]
    public string? BindMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("communities")]
    public IList<V1BGPConfigurationSpecCommunities>? Communities { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoredInterfaces")]
    public IList<string>? IgnoredInterfaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("listenPort")]
    public int? ListenPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localWorkloadPeeringIPV4")]
    public string? LocalWorkloadPeeringIPV4 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localWorkloadPeeringIPV6")]
    public string? LocalWorkloadPeeringIPV6 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logSeverityScreen")]
    public string? LogSeverityScreen { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeMeshMaxRestartTime")]
    public string? NodeMeshMaxRestartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeMeshPassword")]
    public V1BGPConfigurationSpecNodeMeshPassword? NodeMeshPassword { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeToNodeMeshEnabled")]
    public bool? NodeToNodeMeshEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefixAdvertisements")]
    public IList<V1BGPConfigurationSpecPrefixAdvertisements>? PrefixAdvertisements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceClusterIPs")]
    public IList<V1BGPConfigurationSpecServiceClusterIPs>? ServiceClusterIPs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceExternalIPs")]
    public IList<V1BGPConfigurationSpecServiceExternalIPs>? ServiceExternalIPs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceLoadBalancerAggregation")]
    public string? ServiceLoadBalancerAggregation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceLoadBalancerIPs")]
    public IList<V1BGPConfigurationSpecServiceLoadBalancerIPs>? ServiceLoadBalancerIPs { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1BGPConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1BGPConfigurationSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BGPConfiguration";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "bgpconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1BGPConfigurationSpec? Spec { get; set; }
}
#nullable disable
