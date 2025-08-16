using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicediscovery.aws.m.upbound.io;
/// <summary>Service is the Schema for the Services API. Provides a Service Discovery Service resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Service>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServiceList";
    public const string KubeGroup = "servicediscovery.aws.m.upbound.io";
    public const string KubePluralName = "services";
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
    public IList<V1beta1Service> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderDnsConfigDnsRecords
{
    /// <summary>The amount of time, in seconds, that you want DNS resolvers to cache the settings for this resource record set.</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }

    /// <summary>The type of the resource, which indicates the value that Amazon Route 53 returns in response to DNS queries. Valid Values: A, AAAA, SRV, CNAME</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderDnsConfigNamespaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a PrivateDNSNamespace in servicediscovery to populate namespaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderDnsConfigNamespaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecForProviderDnsConfigNamespaceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderDnsConfigNamespaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a PrivateDNSNamespace in servicediscovery to populate namespaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderDnsConfigNamespaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecForProviderDnsConfigNamespaceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A complex type that contains information about the resource record sets that you want Amazon Route 53 to create when you register an instance. See dns_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderDnsConfig
{
    /// <summary>An array that contains one DnsRecord object for each resource record set. See dns_records Block for details.</summary>
    [JsonPropertyName("dnsRecords")]
    public IList<V1beta1ServiceSpecForProviderDnsConfigDnsRecords>? DnsRecords { get; set; }

    /// <summary>The ID of the namespace to use for DNS configuration.</summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary>Reference to a PrivateDNSNamespace in servicediscovery to populate namespaceId.</summary>
    [JsonPropertyName("namespaceIdRef")]
    public V1beta1ServiceSpecForProviderDnsConfigNamespaceIdRef? NamespaceIdRef { get; set; }

    /// <summary>Selector for a PrivateDNSNamespace in servicediscovery to populate namespaceId.</summary>
    [JsonPropertyName("namespaceIdSelector")]
    public V1beta1ServiceSpecForProviderDnsConfigNamespaceIdSelector? NamespaceIdSelector { get; set; }

    /// <summary>The routing policy that you want to apply to all records that Route 53 creates when you register an instance and specify the service. Valid Values: MULTIVALUE, WEIGHTED</summary>
    [JsonPropertyName("routingPolicy")]
    public string? RoutingPolicy { get; set; }
}

/// <summary>A complex type that contains settings for an optional health check. Only for Public DNS namespaces. See health_check_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderHealthCheckConfig
{
    /// <summary>The number of consecutive health checks. Maximum value of 10.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>The path that you want Route 53 to request when performing health checks. Route 53 automatically adds the DNS name for the service. If you don't specify a value, the default value is /.</summary>
    [JsonPropertyName("resourcePath")]
    public string? ResourcePath { get; set; }

    /// <summary>The type of health check that you want to create, which indicates how Route 53 determines whether an endpoint is healthy. Valid Values: HTTP, HTTPS, TCP</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A complex type that contains settings for ECS managed health checks. See health_check_custom_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderHealthCheckCustomConfig
{
    /// <summary>The number of 30-second intervals that you want service discovery to wait before it changes the health status of a service instance.  Value is always set to 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProvider
{
    /// <summary>The description of the service.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A complex type that contains information about the resource record sets that you want Amazon Route 53 to create when you register an instance. See dns_config Block for details.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1beta1ServiceSpecForProviderDnsConfig? DnsConfig { get; set; }

    /// <summary>A boolean that indicates all instances should be deleted from the service so that the service can be destroyed without error. These instances are not recoverable. Defaults to false.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>A complex type that contains settings for an optional health check. Only for Public DNS namespaces. See health_check_config Block for details.</summary>
    [JsonPropertyName("healthCheckConfig")]
    public V1beta1ServiceSpecForProviderHealthCheckConfig? HealthCheckConfig { get; set; }

    /// <summary>A complex type that contains settings for ECS managed health checks. See health_check_custom_config Block for details.</summary>
    [JsonPropertyName("healthCheckCustomConfig")]
    public V1beta1ServiceSpecForProviderHealthCheckCustomConfig? HealthCheckCustomConfig { get; set; }

    /// <summary>The name of the service.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the namespace that you want to use to create the service.</summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>If present, specifies that the service instances are only discoverable using the DiscoverInstances API operation. No DNS records is registered for the service instances. The only valid value is HTTP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderDnsConfigDnsRecords
{
    /// <summary>The amount of time, in seconds, that you want DNS resolvers to cache the settings for this resource record set.</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }

    /// <summary>The type of the resource, which indicates the value that Amazon Route 53 returns in response to DNS queries. Valid Values: A, AAAA, SRV, CNAME</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderDnsConfigNamespaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a PrivateDNSNamespace in servicediscovery to populate namespaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderDnsConfigNamespaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecInitProviderDnsConfigNamespaceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderDnsConfigNamespaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a PrivateDNSNamespace in servicediscovery to populate namespaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderDnsConfigNamespaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecInitProviderDnsConfigNamespaceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A complex type that contains information about the resource record sets that you want Amazon Route 53 to create when you register an instance. See dns_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderDnsConfig
{
    /// <summary>An array that contains one DnsRecord object for each resource record set. See dns_records Block for details.</summary>
    [JsonPropertyName("dnsRecords")]
    public IList<V1beta1ServiceSpecInitProviderDnsConfigDnsRecords>? DnsRecords { get; set; }

    /// <summary>The ID of the namespace to use for DNS configuration.</summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary>Reference to a PrivateDNSNamespace in servicediscovery to populate namespaceId.</summary>
    [JsonPropertyName("namespaceIdRef")]
    public V1beta1ServiceSpecInitProviderDnsConfigNamespaceIdRef? NamespaceIdRef { get; set; }

    /// <summary>Selector for a PrivateDNSNamespace in servicediscovery to populate namespaceId.</summary>
    [JsonPropertyName("namespaceIdSelector")]
    public V1beta1ServiceSpecInitProviderDnsConfigNamespaceIdSelector? NamespaceIdSelector { get; set; }

    /// <summary>The routing policy that you want to apply to all records that Route 53 creates when you register an instance and specify the service. Valid Values: MULTIVALUE, WEIGHTED</summary>
    [JsonPropertyName("routingPolicy")]
    public string? RoutingPolicy { get; set; }
}

/// <summary>A complex type that contains settings for an optional health check. Only for Public DNS namespaces. See health_check_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderHealthCheckConfig
{
    /// <summary>The number of consecutive health checks. Maximum value of 10.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>The path that you want Route 53 to request when performing health checks. Route 53 automatically adds the DNS name for the service. If you don't specify a value, the default value is /.</summary>
    [JsonPropertyName("resourcePath")]
    public string? ResourcePath { get; set; }

    /// <summary>The type of health check that you want to create, which indicates how Route 53 determines whether an endpoint is healthy. Valid Values: HTTP, HTTPS, TCP</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A complex type that contains settings for ECS managed health checks. See health_check_custom_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderHealthCheckCustomConfig
{
    /// <summary>The number of 30-second intervals that you want service discovery to wait before it changes the health status of a service instance.  Value is always set to 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProvider
{
    /// <summary>The description of the service.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A complex type that contains information about the resource record sets that you want Amazon Route 53 to create when you register an instance. See dns_config Block for details.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1beta1ServiceSpecInitProviderDnsConfig? DnsConfig { get; set; }

    /// <summary>A boolean that indicates all instances should be deleted from the service so that the service can be destroyed without error. These instances are not recoverable. Defaults to false.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>A complex type that contains settings for an optional health check. Only for Public DNS namespaces. See health_check_config Block for details.</summary>
    [JsonPropertyName("healthCheckConfig")]
    public V1beta1ServiceSpecInitProviderHealthCheckConfig? HealthCheckConfig { get; set; }

    /// <summary>A complex type that contains settings for ECS managed health checks. See health_check_custom_config Block for details.</summary>
    [JsonPropertyName("healthCheckCustomConfig")]
    public V1beta1ServiceSpecInitProviderHealthCheckCustomConfig? HealthCheckCustomConfig { get; set; }

    /// <summary>The name of the service.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the namespace that you want to use to create the service.</summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>If present, specifies that the service instances are only discoverable using the DiscoverInstances API operation. No DNS records is registered for the service instances. The only valid value is HTTP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ServiceSpec defines the desired state of Service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ServiceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ServiceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderDnsConfigDnsRecords
{
    /// <summary>The amount of time, in seconds, that you want DNS resolvers to cache the settings for this resource record set.</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }

    /// <summary>The type of the resource, which indicates the value that Amazon Route 53 returns in response to DNS queries. Valid Values: A, AAAA, SRV, CNAME</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A complex type that contains information about the resource record sets that you want Amazon Route 53 to create when you register an instance. See dns_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderDnsConfig
{
    /// <summary>An array that contains one DnsRecord object for each resource record set. See dns_records Block for details.</summary>
    [JsonPropertyName("dnsRecords")]
    public IList<V1beta1ServiceStatusAtProviderDnsConfigDnsRecords>? DnsRecords { get; set; }

    /// <summary>The ID of the namespace to use for DNS configuration.</summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary>The routing policy that you want to apply to all records that Route 53 creates when you register an instance and specify the service. Valid Values: MULTIVALUE, WEIGHTED</summary>
    [JsonPropertyName("routingPolicy")]
    public string? RoutingPolicy { get; set; }
}

/// <summary>A complex type that contains settings for an optional health check. Only for Public DNS namespaces. See health_check_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderHealthCheckConfig
{
    /// <summary>The number of consecutive health checks. Maximum value of 10.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>The path that you want Route 53 to request when performing health checks. Route 53 automatically adds the DNS name for the service. If you don't specify a value, the default value is /.</summary>
    [JsonPropertyName("resourcePath")]
    public string? ResourcePath { get; set; }

    /// <summary>The type of health check that you want to create, which indicates how Route 53 determines whether an endpoint is healthy. Valid Values: HTTP, HTTPS, TCP</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A complex type that contains settings for ECS managed health checks. See health_check_custom_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderHealthCheckCustomConfig
{
    /// <summary>The number of 30-second intervals that you want service discovery to wait before it changes the health status of a service instance.  Value is always set to 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProvider
{
    /// <summary>The ARN of the service.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The description of the service.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A complex type that contains information about the resource record sets that you want Amazon Route 53 to create when you register an instance. See dns_config Block for details.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1beta1ServiceStatusAtProviderDnsConfig? DnsConfig { get; set; }

    /// <summary>A boolean that indicates all instances should be deleted from the service so that the service can be destroyed without error. These instances are not recoverable. Defaults to false.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>A complex type that contains settings for an optional health check. Only for Public DNS namespaces. See health_check_config Block for details.</summary>
    [JsonPropertyName("healthCheckConfig")]
    public V1beta1ServiceStatusAtProviderHealthCheckConfig? HealthCheckConfig { get; set; }

    /// <summary>A complex type that contains settings for ECS managed health checks. See health_check_custom_config Block for details.</summary>
    [JsonPropertyName("healthCheckCustomConfig")]
    public V1beta1ServiceStatusAtProviderHealthCheckCustomConfig? HealthCheckCustomConfig { get; set; }

    /// <summary>The ID of the service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the service.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the namespace that you want to use to create the service.</summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>If present, specifies that the service instances are only discoverable using the DiscoverInstances API operation. No DNS records is registered for the service instances. The only valid value is HTTP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusConditions
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

/// <summary>ServiceStatus defines the observed state of Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ServiceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Service is the Schema for the Services API. Provides a Service Discovery Service resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Service : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ServiceSpec>, IStatus<V1beta1ServiceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Service";
    public const string KubeGroup = "servicediscovery.aws.m.upbound.io";
    public const string KubePluralName = "services";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ServiceSpec defines the desired state of Service</summary>
    [JsonPropertyName("spec")]
    public V1beta1ServiceSpec Spec { get; set; }

    /// <summary>ServiceStatus defines the observed state of Service.</summary>
    [JsonPropertyName("status")]
    public V1beta1ServiceStatus? Status { get; set; }
}