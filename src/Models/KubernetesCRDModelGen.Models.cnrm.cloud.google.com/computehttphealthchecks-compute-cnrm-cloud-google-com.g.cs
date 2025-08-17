using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeHTTPHealthCheckList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeHTTPHealthCheck>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeHTTPHealthCheckList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computehttphealthchecks";
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
    public IList<V1beta1ComputeHTTPHealthCheck> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeHTTPHealthCheckSpec
{
    /// <summary>How often (in seconds) to send a health check. The default value is 5 seconds.</summary>
    [JsonPropertyName("checkIntervalSec")]
    public int? CheckIntervalSec { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A so-far unhealthy instance will be marked healthy after this many consecutive successes. The default value is 2.</summary>
    [JsonPropertyName("healthyThreshold")]
    public int? HealthyThreshold { get; set; }

    /// <summary>The value of the host header in the HTTP health check request. If left empty (default value), the public IP on behalf of which this health check is performed will be used.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The TCP port number for the HTTP health check request. The default value is 80.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>The request path of the HTTP health check request. The default value is /.</summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>How long (in seconds) to wait before claiming failure. The default value is 5 seconds.  It is invalid for timeoutSec to have greater value than checkIntervalSec.</summary>
    [JsonPropertyName("timeoutSec")]
    public int? TimeoutSec { get; set; }

    /// <summary>A so-far healthy instance will be marked unhealthy after this many consecutive failures. The default value is 2.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public int? UnhealthyThreshold { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeHTTPHealthCheckStatusConditions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeHTTPHealthCheckStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeHTTPHealthCheckStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeHTTPHealthCheck : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeHTTPHealthCheckSpec>, IStatus<V1beta1ComputeHTTPHealthCheckStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeHTTPHealthCheck";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computehttphealthchecks";
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
    public V1beta1ComputeHTTPHealthCheckSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeHTTPHealthCheckStatus? Status { get; set; }
}
#nullable disable
