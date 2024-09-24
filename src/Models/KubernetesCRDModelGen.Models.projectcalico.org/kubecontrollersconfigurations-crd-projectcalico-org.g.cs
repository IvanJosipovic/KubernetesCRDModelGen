using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
/// <summary>Namespace enables and configures the namespace controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersNamespace
{
    /// <summary>ReconcilerPeriod is the period to perform reconciliation with the Calico datastore. [Default: 5m]</summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary>HostEndpoint controls syncing nodes to host endpoints. Disabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersNodeHostEndpoint
{
    /// <summary>AutoCreate enables automatic creation of host endpoints for every node. [Default: Disabled]</summary>
    [JsonPropertyName("autoCreate")]
    public string? AutoCreate { get; set; }
}

/// <summary>Node enables and configures the node controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersNode
{
    /// <summary>HostEndpoint controls syncing nodes to host endpoints. Disabled by default, set to nil to disable.</summary>
    [JsonPropertyName("hostEndpoint")]
    public V1KubeControllersConfigurationSpecControllersNodeHostEndpoint? HostEndpoint { get; set; }

    /// <summary>LeakGracePeriod is the period used by the controller to determine if an IP address has been leaked. Set to 0 to disable IP garbage collection. [Default: 15m]</summary>
    [JsonPropertyName("leakGracePeriod")]
    public string? LeakGracePeriod { get; set; }

    /// <summary>ReconcilerPeriod is the period to perform reconciliation with the Calico datastore. [Default: 5m]</summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }

    /// <summary>SyncLabels controls whether to copy Kubernetes node labels to Calico nodes. [Default: Enabled]</summary>
    [JsonPropertyName("syncLabels")]
    public string? SyncLabels { get; set; }
}

/// <summary>Policy enables and configures the policy controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersPolicy
{
    /// <summary>ReconcilerPeriod is the period to perform reconciliation with the Calico datastore. [Default: 5m]</summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary>ServiceAccount enables and configures the service account controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersServiceAccount
{
    /// <summary>ReconcilerPeriod is the period to perform reconciliation with the Calico datastore. [Default: 5m]</summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary>WorkloadEndpoint enables and configures the workload endpoint controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersWorkloadEndpoint
{
    /// <summary>ReconcilerPeriod is the period to perform reconciliation with the Calico datastore. [Default: 5m]</summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary>Controllers enables and configures individual Kubernetes controllers</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllers
{
    /// <summary>Namespace enables and configures the namespace controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("namespace")]
    public V1KubeControllersConfigurationSpecControllersNamespace? Namespace { get; set; }

    /// <summary>Node enables and configures the node controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("node")]
    public V1KubeControllersConfigurationSpecControllersNode? Node { get; set; }

    /// <summary>Policy enables and configures the policy controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("policy")]
    public V1KubeControllersConfigurationSpecControllersPolicy? Policy { get; set; }

    /// <summary>ServiceAccount enables and configures the service account controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1KubeControllersConfigurationSpecControllersServiceAccount? ServiceAccount { get; set; }

    /// <summary>WorkloadEndpoint enables and configures the workload endpoint controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("workloadEndpoint")]
    public V1KubeControllersConfigurationSpecControllersWorkloadEndpoint? WorkloadEndpoint { get; set; }
}

/// <summary>KubeControllersConfigurationSpec contains the values of the Kubernetes controllers configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpec
{
    /// <summary>Controllers enables and configures individual Kubernetes controllers</summary>
    [JsonPropertyName("controllers")]
    public V1KubeControllersConfigurationSpecControllers Controllers { get; set; }

    /// <summary>DebugProfilePort configures the port to serve memory and cpu profiles on. If not specified, profiling is disabled.</summary>
    [JsonPropertyName("debugProfilePort")]
    public int? DebugProfilePort { get; set; }

    /// <summary>EtcdV3CompactionPeriod is the period between etcdv3 compaction requests. Set to 0 to disable. [Default: 10m]</summary>
    [JsonPropertyName("etcdV3CompactionPeriod")]
    public string? EtcdV3CompactionPeriod { get; set; }

    /// <summary>HealthChecks enables or disables support for health checks [Default: Enabled]</summary>
    [JsonPropertyName("healthChecks")]
    public string? HealthChecks { get; set; }

    /// <summary>LogSeverityScreen is the log severity above which logs are sent to the stdout. [Default: Info]</summary>
    [JsonPropertyName("logSeverityScreen")]
    public string? LogSeverityScreen { get; set; }

    /// <summary>PrometheusMetricsPort is the TCP port that the Prometheus metrics server should bind to. Set to 0 to disable. [Default: 9094]</summary>
    [JsonPropertyName("prometheusMetricsPort")]
    public int? PrometheusMetricsPort { get; set; }
}

/// <summary>Namespace enables and configures the namespace controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersNamespace
{
    /// <summary>ReconcilerPeriod is the period to perform reconciliation with the Calico datastore. [Default: 5m]</summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary>HostEndpoint controls syncing nodes to host endpoints. Disabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersNodeHostEndpoint
{
    /// <summary>AutoCreate enables automatic creation of host endpoints for every node. [Default: Disabled]</summary>
    [JsonPropertyName("autoCreate")]
    public string? AutoCreate { get; set; }
}

/// <summary>Node enables and configures the node controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersNode
{
    /// <summary>HostEndpoint controls syncing nodes to host endpoints. Disabled by default, set to nil to disable.</summary>
    [JsonPropertyName("hostEndpoint")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersNodeHostEndpoint? HostEndpoint { get; set; }

    /// <summary>LeakGracePeriod is the period used by the controller to determine if an IP address has been leaked. Set to 0 to disable IP garbage collection. [Default: 15m]</summary>
    [JsonPropertyName("leakGracePeriod")]
    public string? LeakGracePeriod { get; set; }

    /// <summary>ReconcilerPeriod is the period to perform reconciliation with the Calico datastore. [Default: 5m]</summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }

    /// <summary>SyncLabels controls whether to copy Kubernetes node labels to Calico nodes. [Default: Enabled]</summary>
    [JsonPropertyName("syncLabels")]
    public string? SyncLabels { get; set; }
}

/// <summary>Policy enables and configures the policy controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersPolicy
{
    /// <summary>ReconcilerPeriod is the period to perform reconciliation with the Calico datastore. [Default: 5m]</summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary>ServiceAccount enables and configures the service account controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersServiceAccount
{
    /// <summary>ReconcilerPeriod is the period to perform reconciliation with the Calico datastore. [Default: 5m]</summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary>WorkloadEndpoint enables and configures the workload endpoint controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersWorkloadEndpoint
{
    /// <summary>ReconcilerPeriod is the period to perform reconciliation with the Calico datastore. [Default: 5m]</summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary>Controllers enables and configures individual Kubernetes controllers</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllers
{
    /// <summary>Namespace enables and configures the namespace controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("namespace")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersNamespace? Namespace { get; set; }

    /// <summary>Node enables and configures the node controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("node")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersNode? Node { get; set; }

    /// <summary>Policy enables and configures the policy controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("policy")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersPolicy? Policy { get; set; }

    /// <summary>ServiceAccount enables and configures the service account controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersServiceAccount? ServiceAccount { get; set; }

    /// <summary>WorkloadEndpoint enables and configures the workload endpoint controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("workloadEndpoint")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersWorkloadEndpoint? WorkloadEndpoint { get; set; }
}

/// <summary>RunningConfig contains the effective config that is running in the kube-controllers pod, after merging the API resource with any environment variables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfig
{
    /// <summary>Controllers enables and configures individual Kubernetes controllers</summary>
    [JsonPropertyName("controllers")]
    public V1KubeControllersConfigurationStatusRunningConfigControllers Controllers { get; set; }

    /// <summary>DebugProfilePort configures the port to serve memory and cpu profiles on. If not specified, profiling is disabled.</summary>
    [JsonPropertyName("debugProfilePort")]
    public int? DebugProfilePort { get; set; }

    /// <summary>EtcdV3CompactionPeriod is the period between etcdv3 compaction requests. Set to 0 to disable. [Default: 10m]</summary>
    [JsonPropertyName("etcdV3CompactionPeriod")]
    public string? EtcdV3CompactionPeriod { get; set; }

    /// <summary>HealthChecks enables or disables support for health checks [Default: Enabled]</summary>
    [JsonPropertyName("healthChecks")]
    public string? HealthChecks { get; set; }

    /// <summary>LogSeverityScreen is the log severity above which logs are sent to the stdout. [Default: Info]</summary>
    [JsonPropertyName("logSeverityScreen")]
    public string? LogSeverityScreen { get; set; }

    /// <summary>PrometheusMetricsPort is the TCP port that the Prometheus metrics server should bind to. Set to 0 to disable. [Default: 9094]</summary>
    [JsonPropertyName("prometheusMetricsPort")]
    public int? PrometheusMetricsPort { get; set; }
}

/// <summary>KubeControllersConfigurationStatus represents the status of the configuration. It's useful for admins to be able to see the actual config that was applied, which can be modified by environment variables on the kube-controllers process.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatus
{
    /// <summary>EnvironmentVars contains the environment variables on the kube-controllers that influenced the RunningConfig.</summary>
    [JsonPropertyName("environmentVars")]
    public IDictionary<string, string>? EnvironmentVars { get; set; }

    /// <summary>RunningConfig contains the effective config that is running in the kube-controllers pod, after merging the API resource with any environment variables.</summary>
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

    /// <summary>KubeControllersConfigurationSpec contains the values of the Kubernetes controllers configuration.</summary>
    [JsonPropertyName("spec")]
    public V1KubeControllersConfigurationSpec? Spec { get; set; }

    /// <summary>KubeControllersConfigurationStatus represents the status of the configuration. It's useful for admins to be able to see the actual config that was applied, which can be modified by environment variables on the kube-controllers process.</summary>
    [JsonPropertyName("status")]
    public V1KubeControllersConfigurationStatus? Status { get; set; }
}