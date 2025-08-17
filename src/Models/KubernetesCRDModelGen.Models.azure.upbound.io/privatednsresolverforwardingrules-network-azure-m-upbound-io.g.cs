using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.m.upbound.io;
#nullable enable
/// <summary>PrivateDNSResolverForwardingRule is the Schema for the PrivateDNSResolverForwardingRules API. Manages a Private DNS Resolver Forwarding Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrivateDNSResolverForwardingRuleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PrivateDNSResolverForwardingRule>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivateDNSResolverForwardingRuleList";
    public const string KubeGroup = "network.azure.m.upbound.io";
    public const string KubePluralName = "privatednsresolverforwardingrules";
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
    public IList<V1beta1PrivateDNSResolverForwardingRule> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverForwardingRuleSpecForProviderDnsForwardingRulesetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a PrivateDNSResolverDNSForwardingRuleset in network to populate dnsForwardingRulesetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverForwardingRuleSpecForProviderDnsForwardingRulesetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateDNSResolverForwardingRuleSpecForProviderDnsForwardingRulesetIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverForwardingRuleSpecForProviderDnsForwardingRulesetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a PrivateDNSResolverDNSForwardingRuleset in network to populate dnsForwardingRulesetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverForwardingRuleSpecForProviderDnsForwardingRulesetIdSelector
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
    public V1beta1PrivateDNSResolverForwardingRuleSpecForProviderDnsForwardingRulesetIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverForwardingRuleSpecForProviderTargetDnsServers
{
    /// <summary>DNS server IP address.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>DNS server port.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverForwardingRuleSpecForProvider
{
    /// <summary>Specifies the ID of the Private DNS Resolver Forwarding Ruleset. Changing this forces a new Private DNS Resolver Forwarding Rule to be created.</summary>
    [JsonPropertyName("dnsForwardingRulesetId")]
    public string? DnsForwardingRulesetId { get; set; }

    /// <summary>Reference to a PrivateDNSResolverDNSForwardingRuleset in network to populate dnsForwardingRulesetId.</summary>
    [JsonPropertyName("dnsForwardingRulesetIdRef")]
    public V1beta1PrivateDNSResolverForwardingRuleSpecForProviderDnsForwardingRulesetIdRef? DnsForwardingRulesetIdRef { get; set; }

    /// <summary>Selector for a PrivateDNSResolverDNSForwardingRuleset in network to populate dnsForwardingRulesetId.</summary>
    [JsonPropertyName("dnsForwardingRulesetIdSelector")]
    public V1beta1PrivateDNSResolverForwardingRuleSpecForProviderDnsForwardingRulesetIdSelector? DnsForwardingRulesetIdSelector { get; set; }

    /// <summary>Specifies the domain name for the Private DNS Resolver Forwarding Rule. Changing this forces a new Private DNS Resolver Forwarding Rule to be created.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Specifies the state of the Private DNS Resolver Forwarding Rule. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Metadata attached to the Private DNS Resolver Forwarding Rule.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Can be specified multiple times to define multiple target DNS servers. Each target_dns_servers block as defined below.</summary>
    [JsonPropertyName("targetDnsServers")]
    public IList<V1beta1PrivateDNSResolverForwardingRuleSpecForProviderTargetDnsServers>? TargetDnsServers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverForwardingRuleSpecInitProviderTargetDnsServers
{
    /// <summary>DNS server IP address.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>DNS server port.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverForwardingRuleSpecInitProvider
{
    /// <summary>Specifies the domain name for the Private DNS Resolver Forwarding Rule. Changing this forces a new Private DNS Resolver Forwarding Rule to be created.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Specifies the state of the Private DNS Resolver Forwarding Rule. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Metadata attached to the Private DNS Resolver Forwarding Rule.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Can be specified multiple times to define multiple target DNS servers. Each target_dns_servers block as defined below.</summary>
    [JsonPropertyName("targetDnsServers")]
    public IList<V1beta1PrivateDNSResolverForwardingRuleSpecInitProviderTargetDnsServers>? TargetDnsServers { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverForwardingRuleSpecProviderConfigRef
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
public partial class V1beta1PrivateDNSResolverForwardingRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>PrivateDNSResolverForwardingRuleSpec defines the desired state of PrivateDNSResolverForwardingRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverForwardingRuleSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PrivateDNSResolverForwardingRuleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PrivateDNSResolverForwardingRuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PrivateDNSResolverForwardingRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PrivateDNSResolverForwardingRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverForwardingRuleStatusAtProviderTargetDnsServers
{
    /// <summary>DNS server IP address.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>DNS server port.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverForwardingRuleStatusAtProvider
{
    /// <summary>Specifies the ID of the Private DNS Resolver Forwarding Ruleset. Changing this forces a new Private DNS Resolver Forwarding Rule to be created.</summary>
    [JsonPropertyName("dnsForwardingRulesetId")]
    public string? DnsForwardingRulesetId { get; set; }

    /// <summary>Specifies the domain name for the Private DNS Resolver Forwarding Rule. Changing this forces a new Private DNS Resolver Forwarding Rule to be created.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Specifies the state of the Private DNS Resolver Forwarding Rule. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ID of the Private DNS Resolver Forwarding Rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Metadata attached to the Private DNS Resolver Forwarding Rule.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Can be specified multiple times to define multiple target DNS servers. Each target_dns_servers block as defined below.</summary>
    [JsonPropertyName("targetDnsServers")]
    public IList<V1beta1PrivateDNSResolverForwardingRuleStatusAtProviderTargetDnsServers>? TargetDnsServers { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverForwardingRuleStatusConditions
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
/// <summary>PrivateDNSResolverForwardingRuleStatus defines the observed state of PrivateDNSResolverForwardingRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateDNSResolverForwardingRuleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PrivateDNSResolverForwardingRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PrivateDNSResolverForwardingRuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>PrivateDNSResolverForwardingRule is the Schema for the PrivateDNSResolverForwardingRules API. Manages a Private DNS Resolver Forwarding Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrivateDNSResolverForwardingRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PrivateDNSResolverForwardingRuleSpec>, IStatus<V1beta1PrivateDNSResolverForwardingRuleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivateDNSResolverForwardingRule";
    public const string KubeGroup = "network.azure.m.upbound.io";
    public const string KubePluralName = "privatednsresolverforwardingrules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PrivateDNSResolverForwardingRuleSpec defines the desired state of PrivateDNSResolverForwardingRule</summary>
    [JsonPropertyName("spec")]
    public V1beta1PrivateDNSResolverForwardingRuleSpec Spec { get; set; }

    /// <summary>PrivateDNSResolverForwardingRuleStatus defines the observed state of PrivateDNSResolverForwardingRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1PrivateDNSResolverForwardingRuleStatus? Status { get; set; }
}
#nullable disable
