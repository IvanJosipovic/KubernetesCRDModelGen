using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1BGPFilterList : IKubernetesObject<V1ListMeta>, IItems<V1BGPFilter>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BGPFilterList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "bgpfilters";
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
    public IList<V1BGPFilter> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV4PrefixLength
{
    /// <summary></summary>
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    /// <summary></summary>
    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV4
{
    /// <summary></summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    /// <summary></summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchOperator")]
    public string? MatchOperator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefixLength")]
    public V1BGPFilterSpecExportV4PrefixLength? PrefixLength { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV6PrefixLength
{
    /// <summary></summary>
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    /// <summary></summary>
    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV6
{
    /// <summary></summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    /// <summary></summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchOperator")]
    public string? MatchOperator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefixLength")]
    public V1BGPFilterSpecExportV6PrefixLength? PrefixLength { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV4PrefixLength
{
    /// <summary></summary>
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    /// <summary></summary>
    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV4
{
    /// <summary></summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    /// <summary></summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchOperator")]
    public string? MatchOperator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefixLength")]
    public V1BGPFilterSpecImportV4PrefixLength? PrefixLength { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV6PrefixLength
{
    /// <summary></summary>
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    /// <summary></summary>
    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV6
{
    /// <summary></summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    /// <summary></summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchOperator")]
    public string? MatchOperator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefixLength")]
    public V1BGPFilterSpecImportV6PrefixLength? PrefixLength { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpec
{
    /// <summary></summary>
    [JsonPropertyName("exportV4")]
    public IList<V1BGPFilterSpecExportV4>? ExportV4 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exportV6")]
    public IList<V1BGPFilterSpecExportV6>? ExportV6 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("importV4")]
    public IList<V1BGPFilterSpecImportV4>? ImportV4 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("importV6")]
    public IList<V1BGPFilterSpecImportV6>? ImportV6 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1BGPFilter : IKubernetesObject<V1ObjectMeta>, ISpec<V1BGPFilterSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BGPFilter";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "bgpfilters";
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
    public V1BGPFilterSpec? Spec { get; set; }
}