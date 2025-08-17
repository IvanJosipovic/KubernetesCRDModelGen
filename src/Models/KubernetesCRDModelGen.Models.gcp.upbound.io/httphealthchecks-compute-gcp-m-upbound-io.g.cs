using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.m.upbound.io;
#nullable enable
/// <summary>HTTPHealthCheck is the Schema for the HTTPHealthChecks API. An HttpHealthCheck resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1HTTPHealthCheckList : IKubernetesObject<V1ListMeta>, IItems<V1beta1HTTPHealthCheck>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HTTPHealthCheckList";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "httphealthchecks";
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
    public IList<V1beta1HTTPHealthCheck> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPHealthCheckSpecForProvider
{
    /// <summary>How often (in seconds) to send a health check. The default value is 5 seconds.</summary>
    [JsonPropertyName("checkIntervalSec")]
    public double? CheckIntervalSec { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A so-far unhealthy instance will be marked healthy after this many consecutive successes. The default value is 2.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>The value of the host header in the HTTP health check request. If left empty (default value), the public IP on behalf of which this health check is performed will be used.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The TCP port number for the HTTP health check request. The default value is 80.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The request path of the HTTP health check request. The default value is /.</summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>How long (in seconds) to wait before claiming failure. The default value is 5 seconds.  It is invalid for timeoutSec to have greater value than checkIntervalSec.</summary>
    [JsonPropertyName("timeoutSec")]
    public double? TimeoutSec { get; set; }

    /// <summary>A so-far healthy instance will be marked unhealthy after this many consecutive failures. The default value is 2.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPHealthCheckSpecInitProvider
{
    /// <summary>How often (in seconds) to send a health check. The default value is 5 seconds.</summary>
    [JsonPropertyName("checkIntervalSec")]
    public double? CheckIntervalSec { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A so-far unhealthy instance will be marked healthy after this many consecutive successes. The default value is 2.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>The value of the host header in the HTTP health check request. If left empty (default value), the public IP on behalf of which this health check is performed will be used.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The TCP port number for the HTTP health check request. The default value is 80.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The request path of the HTTP health check request. The default value is /.</summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>How long (in seconds) to wait before claiming failure. The default value is 5 seconds.  It is invalid for timeoutSec to have greater value than checkIntervalSec.</summary>
    [JsonPropertyName("timeoutSec")]
    public double? TimeoutSec { get; set; }

    /// <summary>A so-far healthy instance will be marked unhealthy after this many consecutive failures. The default value is 2.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPHealthCheckSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPHealthCheckSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>HTTPHealthCheckSpec defines the desired state of HTTPHealthCheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPHealthCheckSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1HTTPHealthCheckSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1HTTPHealthCheckSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1HTTPHealthCheckSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1HTTPHealthCheckSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPHealthCheckStatusAtProvider
{
    /// <summary>How often (in seconds) to send a health check. The default value is 5 seconds.</summary>
    [JsonPropertyName("checkIntervalSec")]
    public double? CheckIntervalSec { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A so-far unhealthy instance will be marked healthy after this many consecutive successes. The default value is 2.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>The value of the host header in the HTTP health check request. If left empty (default value), the public IP on behalf of which this health check is performed will be used.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/global/httpHealthChecks/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The TCP port number for the HTTP health check request. The default value is 80.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The request path of the HTTP health check request. The default value is /.</summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>How long (in seconds) to wait before claiming failure. The default value is 5 seconds.  It is invalid for timeoutSec to have greater value than checkIntervalSec.</summary>
    [JsonPropertyName("timeoutSec")]
    public double? TimeoutSec { get; set; }

    /// <summary>A so-far healthy instance will be marked unhealthy after this many consecutive failures. The default value is 2.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPHealthCheckStatusConditions
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
#nullable disable

#nullable enable
/// <summary>HTTPHealthCheckStatus defines the observed state of HTTPHealthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPHealthCheckStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1HTTPHealthCheckStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1HTTPHealthCheckStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>HTTPHealthCheck is the Schema for the HTTPHealthChecks API. An HttpHealthCheck resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1HTTPHealthCheck : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1HTTPHealthCheckSpec>, IStatus<V1beta1HTTPHealthCheckStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HTTPHealthCheck";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "httphealthchecks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HTTPHealthCheckSpec defines the desired state of HTTPHealthCheck</summary>
    [JsonPropertyName("spec")]
    public V1beta1HTTPHealthCheckSpec Spec { get; set; }

    /// <summary>HTTPHealthCheckStatus defines the observed state of HTTPHealthCheck.</summary>
    [JsonPropertyName("status")]
    public V1beta1HTTPHealthCheckStatus? Status { get; set; }
}
#nullable disable
