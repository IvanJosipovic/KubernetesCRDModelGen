using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.route53resolver.aws.m.upbound.io;
/// <summary>Rule is the Schema for the Rules API. Provides a Route53 Resolver rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RuleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Rule>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RuleList";
    public const string KubeGroup = "route53resolver.aws.m.upbound.io";
    public const string KubePluralName = "rules";
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
    public IList<V1beta1Rule> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleSpecForProviderResolverEndpointIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Endpoint in route53resolver to populate resolverEndpointId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleSpecForProviderResolverEndpointIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RuleSpecForProviderResolverEndpointIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleSpecForProviderResolverEndpointIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Endpoint in route53resolver to populate resolverEndpointId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleSpecForProviderResolverEndpointIdSelector
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
    public V1beta1RuleSpecForProviderResolverEndpointIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleSpecForProviderTargetIp
{
    /// <summary>One IPv4 address that you want to forward DNS queries to.</summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    /// <summary>One IPv6 address that you want to forward DNS queries to.</summary>
    [JsonPropertyName("ipv6")]
    public string? Ipv6 { get; set; }

    /// <summary>Port at ip that you want to forward DNS queries to. Default value is 53.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol for the resolver endpoint. Valid values can be found in the AWS documentation. Default value is Do53.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleSpecForProvider
{
    /// <summary>DNS queries for this domain name are forwarded to the IP addresses that are specified using target_ip.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Friendly name that lets you easily find a rule in the Resolver dashboard in the Route 53 console.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>ID of the outbound resolver endpoint that you want to use to route DNS queries to the IP addresses that you specify using target_ip. This argument should only be specified for FORWARD type rules.</summary>
    [JsonPropertyName("resolverEndpointId")]
    public string? ResolverEndpointId { get; set; }

    /// <summary>Reference to a Endpoint in route53resolver to populate resolverEndpointId.</summary>
    [JsonPropertyName("resolverEndpointIdRef")]
    public V1beta1RuleSpecForProviderResolverEndpointIdRef? ResolverEndpointIdRef { get; set; }

    /// <summary>Selector for a Endpoint in route53resolver to populate resolverEndpointId.</summary>
    [JsonPropertyName("resolverEndpointIdSelector")]
    public V1beta1RuleSpecForProviderResolverEndpointIdSelector? ResolverEndpointIdSelector { get; set; }

    /// <summary>Rule type. Valid values are FORWARD, SYSTEM and RECURSIVE.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block(s) indicating the IPs that you want Resolver to forward DNS queries to (documented below). This argument should only be specified for FORWARD type rules.</summary>
    [JsonPropertyName("targetIp")]
    public IList<V1beta1RuleSpecForProviderTargetIp>? TargetIp { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleSpecInitProviderResolverEndpointIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Endpoint in route53resolver to populate resolverEndpointId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleSpecInitProviderResolverEndpointIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RuleSpecInitProviderResolverEndpointIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleSpecInitProviderResolverEndpointIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Endpoint in route53resolver to populate resolverEndpointId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleSpecInitProviderResolverEndpointIdSelector
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
    public V1beta1RuleSpecInitProviderResolverEndpointIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleSpecInitProviderTargetIp
{
    /// <summary>One IPv4 address that you want to forward DNS queries to.</summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    /// <summary>One IPv6 address that you want to forward DNS queries to.</summary>
    [JsonPropertyName("ipv6")]
    public string? Ipv6 { get; set; }

    /// <summary>Port at ip that you want to forward DNS queries to. Default value is 53.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol for the resolver endpoint. Valid values can be found in the AWS documentation. Default value is Do53.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleSpecInitProvider
{
    /// <summary>DNS queries for this domain name are forwarded to the IP addresses that are specified using target_ip.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Friendly name that lets you easily find a rule in the Resolver dashboard in the Route 53 console.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ID of the outbound resolver endpoint that you want to use to route DNS queries to the IP addresses that you specify using target_ip. This argument should only be specified for FORWARD type rules.</summary>
    [JsonPropertyName("resolverEndpointId")]
    public string? ResolverEndpointId { get; set; }

    /// <summary>Reference to a Endpoint in route53resolver to populate resolverEndpointId.</summary>
    [JsonPropertyName("resolverEndpointIdRef")]
    public V1beta1RuleSpecInitProviderResolverEndpointIdRef? ResolverEndpointIdRef { get; set; }

    /// <summary>Selector for a Endpoint in route53resolver to populate resolverEndpointId.</summary>
    [JsonPropertyName("resolverEndpointIdSelector")]
    public V1beta1RuleSpecInitProviderResolverEndpointIdSelector? ResolverEndpointIdSelector { get; set; }

    /// <summary>Rule type. Valid values are FORWARD, SYSTEM and RECURSIVE.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block(s) indicating the IPs that you want Resolver to forward DNS queries to (documented below). This argument should only be specified for FORWARD type rules.</summary>
    [JsonPropertyName("targetIp")]
    public IList<V1beta1RuleSpecInitProviderTargetIp>? TargetIp { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleSpecProviderConfigRef
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
public partial class V1beta1RuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>RuleSpec defines the desired state of Rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RuleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleStatusAtProviderTargetIp
{
    /// <summary>One IPv4 address that you want to forward DNS queries to.</summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    /// <summary>One IPv6 address that you want to forward DNS queries to.</summary>
    [JsonPropertyName("ipv6")]
    public string? Ipv6 { get; set; }

    /// <summary>Port at ip that you want to forward DNS queries to. Default value is 53.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol for the resolver endpoint. Valid values can be found in the AWS documentation. Default value is Do53.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleStatusAtProvider
{
    /// <summary>ARN (Amazon Resource Name) for the resolver rule.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>DNS queries for this domain name are forwarded to the IP addresses that are specified using target_ip.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>ID of the resolver rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Friendly name that lets you easily find a rule in the Resolver dashboard in the Route 53 console.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>When a rule is shared with another AWS account, the account ID of the account that the rule is shared with.</summary>
    [JsonPropertyName("ownerId")]
    public string? OwnerId { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>ID of the outbound resolver endpoint that you want to use to route DNS queries to the IP addresses that you specify using target_ip. This argument should only be specified for FORWARD type rules.</summary>
    [JsonPropertyName("resolverEndpointId")]
    public string? ResolverEndpointId { get; set; }

    /// <summary>Rule type. Valid values are FORWARD, SYSTEM and RECURSIVE.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    /// <summary>Whether the rules is shared and, if so, whether the current account is sharing the rule with another account, or another account is sharing the rule with the current account. Values are NOT_SHARED, SHARED_BY_ME or SHARED_WITH_ME</summary>
    [JsonPropertyName("shareStatus")]
    public string? ShareStatus { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Configuration block(s) indicating the IPs that you want Resolver to forward DNS queries to (documented below). This argument should only be specified for FORWARD type rules.</summary>
    [JsonPropertyName("targetIp")]
    public IList<V1beta1RuleStatusAtProviderTargetIp>? TargetIp { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleStatusConditions
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

/// <summary>RuleStatus defines the observed state of Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Rule is the Schema for the Rules API. Provides a Route53 Resolver rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Rule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RuleSpec>, IStatus<V1beta1RuleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Rule";
    public const string KubeGroup = "route53resolver.aws.m.upbound.io";
    public const string KubePluralName = "rules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RuleSpec defines the desired state of Rule</summary>
    [JsonPropertyName("spec")]
    public V1beta1RuleSpec Spec { get; set; }

    /// <summary>RuleStatus defines the observed state of Rule.</summary>
    [JsonPropertyName("status")]
    public V1beta1RuleStatus? Status { get; set; }
}