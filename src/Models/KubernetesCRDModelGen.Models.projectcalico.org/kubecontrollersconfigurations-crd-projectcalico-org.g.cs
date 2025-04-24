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
public partial class V1KubeControllersConfigurationSpecControllersLoadBalancer
{
    /// <summary></summary>
    [JsonPropertyName("assignIPs")]
    public string? AssignIPs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersNamespace
{
    /// <summary></summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersNodeHostEndpointTemplates
{
    /// <summary></summary>
    [JsonPropertyName("generateName")]
    public string? GenerateName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("interfaceCIDRs")]
    public IList<string>? InterfaceCIDRs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSelector")]
    public string? NodeSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersNodeHostEndpoint
{
    /// <summary></summary>
    [JsonPropertyName("autoCreate")]
    public string? AutoCreate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createDefaultHostEndpoint")]
    public string? CreateDefaultHostEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("templates")]
    public IList<V1KubeControllersConfigurationSpecControllersNodeHostEndpointTemplates>? Templates { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersNode
{
    /// <summary></summary>
    [JsonPropertyName("hostEndpoint")]
    public V1KubeControllersConfigurationSpecControllersNodeHostEndpoint? HostEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("leakGracePeriod")]
    public string? LeakGracePeriod { get; set; }

    /// <summary></summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncLabels")]
    public string? SyncLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersPolicy
{
    /// <summary></summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersServiceAccount
{
    /// <summary></summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersWorkloadEndpoint
{
    /// <summary></summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllers
{
    /// <summary></summary>
    [JsonPropertyName("loadBalancer")]
    public V1KubeControllersConfigurationSpecControllersLoadBalancer? LoadBalancer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public V1KubeControllersConfigurationSpecControllersNamespace? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("node")]
    public V1KubeControllersConfigurationSpecControllersNode? Node { get; set; }

    /// <summary></summary>
    [JsonPropertyName("policy")]
    public V1KubeControllersConfigurationSpecControllersPolicy? Policy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccount")]
    public V1KubeControllersConfigurationSpecControllersServiceAccount? ServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workloadEndpoint")]
    public V1KubeControllersConfigurationSpecControllersWorkloadEndpoint? WorkloadEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpec
{
    /// <summary></summary>
    [JsonPropertyName("controllers")]
    public V1KubeControllersConfigurationSpecControllers Controllers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("debugProfilePort")]
    public int? DebugProfilePort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etcdV3CompactionPeriod")]
    public string? EtcdV3CompactionPeriod { get; set; }

    /// <summary></summary>
    [JsonPropertyName("healthChecks")]
    public string? HealthChecks { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logSeverityScreen")]
    public string? LogSeverityScreen { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prometheusMetricsPort")]
    public int? PrometheusMetricsPort { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersLoadBalancer
{
    /// <summary></summary>
    [JsonPropertyName("assignIPs")]
    public string? AssignIPs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersNamespace
{
    /// <summary></summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersNodeHostEndpointTemplates
{
    /// <summary></summary>
    [JsonPropertyName("generateName")]
    public string? GenerateName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("interfaceCIDRs")]
    public IList<string>? InterfaceCIDRs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSelector")]
    public string? NodeSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersNodeHostEndpoint
{
    /// <summary></summary>
    [JsonPropertyName("autoCreate")]
    public string? AutoCreate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createDefaultHostEndpoint")]
    public string? CreateDefaultHostEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("templates")]
    public IList<V1KubeControllersConfigurationStatusRunningConfigControllersNodeHostEndpointTemplates>? Templates { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersNode
{
    /// <summary></summary>
    [JsonPropertyName("hostEndpoint")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersNodeHostEndpoint? HostEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("leakGracePeriod")]
    public string? LeakGracePeriod { get; set; }

    /// <summary></summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncLabels")]
    public string? SyncLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersPolicy
{
    /// <summary></summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersServiceAccount
{
    /// <summary></summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersWorkloadEndpoint
{
    /// <summary></summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllers
{
    /// <summary></summary>
    [JsonPropertyName("loadBalancer")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersLoadBalancer? LoadBalancer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersNamespace? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("node")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersNode? Node { get; set; }

    /// <summary></summary>
    [JsonPropertyName("policy")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersPolicy? Policy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccount")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersServiceAccount? ServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workloadEndpoint")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersWorkloadEndpoint? WorkloadEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfig
{
    /// <summary></summary>
    [JsonPropertyName("controllers")]
    public V1KubeControllersConfigurationStatusRunningConfigControllers Controllers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("debugProfilePort")]
    public int? DebugProfilePort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etcdV3CompactionPeriod")]
    public string? EtcdV3CompactionPeriod { get; set; }

    /// <summary></summary>
    [JsonPropertyName("healthChecks")]
    public string? HealthChecks { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logSeverityScreen")]
    public string? LogSeverityScreen { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prometheusMetricsPort")]
    public int? PrometheusMetricsPort { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("environmentVars")]
    public IDictionary<string, string>? EnvironmentVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runningConfig")]
    public V1KubeControllersConfigurationStatusRunningConfig? RunningConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1KubeControllersConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1KubeControllersConfigurationSpec>, IStatus<V1KubeControllersConfigurationStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KubeControllersConfiguration";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "kubecontrollersconfigurations";
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
    public V1KubeControllersConfigurationSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1KubeControllersConfigurationStatus? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1KubeControllersConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1KubeControllersConfiguration>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KubeControllersConfigurationList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "kubecontrollersconfigurations";
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
    public IList<V1KubeControllersConfiguration> Items { get; set; }
}