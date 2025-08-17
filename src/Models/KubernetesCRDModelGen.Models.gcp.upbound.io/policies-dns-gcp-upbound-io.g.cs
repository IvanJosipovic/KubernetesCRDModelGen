using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dns.gcp.upbound.io;
#nullable enable
/// <summary>Policy is the Schema for the Policys API. A policy is a collection of DNS rules applied to one or more Virtual Private Cloud resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Policy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PolicyList";
    public const string KubeGroup = "dns.gcp.upbound.io";
    public const string KubePluralName = "policies";
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
    public IList<V1beta1Policy> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderAlternativeNameServerConfigTargetNameServers
{
    /// <summary>Forwarding path for this TargetNameServer. If unset or default Cloud DNS will make forwarding decision based on address ranges, i.e. RFC1918 addresses go to the VPC, Non-RFC1918 addresses go to the Internet. When set to private, Cloud DNS will always send queries through VPC for this target Possible values are: default, private.</summary>
    [JsonPropertyName("forwardingPath")]
    public string? ForwardingPath { get; set; }

    /// <summary>IPv4 address to forward to.</summary>
    [JsonPropertyName("ipv4Address")]
    public string? Ipv4Address { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderAlternativeNameServerConfig
{
    /// <summary>Sets an alternative name server for the associated networks. When specified, all DNS queries are forwarded to a name server that you choose. Names such as .internal are not available when an alternative name server is specified. Structure is documented below.</summary>
    [JsonPropertyName("targetNameServers")]
    public IList<V1beta1PolicySpecForProviderAlternativeNameServerConfigTargetNameServers>? TargetNameServers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderDns64ConfigScope
{
    /// <summary>Controls whether DNS64 is enabled globally at the network level.</summary>
    [JsonPropertyName("allQueries")]
    public bool? AllQueries { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderDns64Config
{
    /// <summary>The scope to which DNS64 config will be applied to. Structure is documented below.</summary>
    [JsonPropertyName("scope")]
    public IList<V1beta1PolicySpecForProviderDns64ConfigScope>? Scope { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderNetworksNetworkRefPolicy
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
/// <summary>Reference to a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderNetworksNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PolicySpecForProviderNetworksNetworkRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderNetworksNetworkSelectorPolicy
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
/// <summary>Selector for a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderNetworksNetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PolicySpecForProviderNetworksNetworkSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderNetworks
{
    /// <summary>Reference to a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1PolicySpecForProviderNetworksNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1PolicySpecForProviderNetworksNetworkSelector? NetworkSelector { get; set; }

    /// <summary>The id or fully qualified URL of the VPC network to forward queries to. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProvider
{
    /// <summary>Sets an alternative name server for the associated networks. When specified, all DNS queries are forwarded to a name server that you choose. Names such as .internal are not available when an alternative name server is specified. Structure is documented below.</summary>
    [JsonPropertyName("alternativeNameServerConfig")]
    public IList<V1beta1PolicySpecForProviderAlternativeNameServerConfig>? AlternativeNameServerConfig { get; set; }

    /// <summary>A textual description field.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configurations related to DNS64 for this Policy. Structure is documented below.</summary>
    [JsonPropertyName("dns64Config")]
    public IList<V1beta1PolicySpecForProviderDns64Config>? Dns64Config { get; set; }

    /// <summary>Allows networks bound to this policy to receive DNS queries sent by VMs or applications over VPN connections. When enabled, a virtual IP address will be allocated from each of the sub-networks that are bound to this policy.</summary>
    [JsonPropertyName("enableInboundForwarding")]
    public bool? EnableInboundForwarding { get; set; }

    /// <summary>Controls whether logging is enabled for the networks bound to this policy. Defaults to no logging if not set.</summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }

    /// <summary>List of network names specifying networks to which this policy is applied. Structure is documented below.</summary>
    [JsonPropertyName("networks")]
    public IList<V1beta1PolicySpecForProviderNetworks>? Networks { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderAlternativeNameServerConfigTargetNameServers
{
    /// <summary>Forwarding path for this TargetNameServer. If unset or default Cloud DNS will make forwarding decision based on address ranges, i.e. RFC1918 addresses go to the VPC, Non-RFC1918 addresses go to the Internet. When set to private, Cloud DNS will always send queries through VPC for this target Possible values are: default, private.</summary>
    [JsonPropertyName("forwardingPath")]
    public string? ForwardingPath { get; set; }

    /// <summary>IPv4 address to forward to.</summary>
    [JsonPropertyName("ipv4Address")]
    public string? Ipv4Address { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderAlternativeNameServerConfig
{
    /// <summary>Sets an alternative name server for the associated networks. When specified, all DNS queries are forwarded to a name server that you choose. Names such as .internal are not available when an alternative name server is specified. Structure is documented below.</summary>
    [JsonPropertyName("targetNameServers")]
    public IList<V1beta1PolicySpecInitProviderAlternativeNameServerConfigTargetNameServers>? TargetNameServers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderDns64ConfigScope
{
    /// <summary>Controls whether DNS64 is enabled globally at the network level.</summary>
    [JsonPropertyName("allQueries")]
    public bool? AllQueries { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderDns64Config
{
    /// <summary>The scope to which DNS64 config will be applied to. Structure is documented below.</summary>
    [JsonPropertyName("scope")]
    public IList<V1beta1PolicySpecInitProviderDns64ConfigScope>? Scope { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderNetworksNetworkRefPolicy
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
/// <summary>Reference to a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderNetworksNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PolicySpecInitProviderNetworksNetworkRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderNetworksNetworkSelectorPolicy
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
/// <summary>Selector for a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderNetworksNetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PolicySpecInitProviderNetworksNetworkSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderNetworks
{
    /// <summary>Reference to a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1PolicySpecInitProviderNetworksNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1PolicySpecInitProviderNetworksNetworkSelector? NetworkSelector { get; set; }

    /// <summary>The id or fully qualified URL of the VPC network to forward queries to. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProvider
{
    /// <summary>Sets an alternative name server for the associated networks. When specified, all DNS queries are forwarded to a name server that you choose. Names such as .internal are not available when an alternative name server is specified. Structure is documented below.</summary>
    [JsonPropertyName("alternativeNameServerConfig")]
    public IList<V1beta1PolicySpecInitProviderAlternativeNameServerConfig>? AlternativeNameServerConfig { get; set; }

    /// <summary>A textual description field.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configurations related to DNS64 for this Policy. Structure is documented below.</summary>
    [JsonPropertyName("dns64Config")]
    public IList<V1beta1PolicySpecInitProviderDns64Config>? Dns64Config { get; set; }

    /// <summary>Allows networks bound to this policy to receive DNS queries sent by VMs or applications over VPN connections. When enabled, a virtual IP address will be allocated from each of the sub-networks that are bound to this policy.</summary>
    [JsonPropertyName("enableInboundForwarding")]
    public bool? EnableInboundForwarding { get; set; }

    /// <summary>Controls whether logging is enabled for the networks bound to this policy. Defaults to no logging if not set.</summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }

    /// <summary>List of network names specifying networks to which this policy is applied. Structure is documented below.</summary>
    [JsonPropertyName("networks")]
    public IList<V1beta1PolicySpecInitProviderNetworks>? Networks { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecProviderConfigRefPolicy
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
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PolicySpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>PolicySpec defines the desired state of Policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderAlternativeNameServerConfigTargetNameServers
{
    /// <summary>Forwarding path for this TargetNameServer. If unset or default Cloud DNS will make forwarding decision based on address ranges, i.e. RFC1918 addresses go to the VPC, Non-RFC1918 addresses go to the Internet. When set to private, Cloud DNS will always send queries through VPC for this target Possible values are: default, private.</summary>
    [JsonPropertyName("forwardingPath")]
    public string? ForwardingPath { get; set; }

    /// <summary>IPv4 address to forward to.</summary>
    [JsonPropertyName("ipv4Address")]
    public string? Ipv4Address { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderAlternativeNameServerConfig
{
    /// <summary>Sets an alternative name server for the associated networks. When specified, all DNS queries are forwarded to a name server that you choose. Names such as .internal are not available when an alternative name server is specified. Structure is documented below.</summary>
    [JsonPropertyName("targetNameServers")]
    public IList<V1beta1PolicyStatusAtProviderAlternativeNameServerConfigTargetNameServers>? TargetNameServers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderDns64ConfigScope
{
    /// <summary>Controls whether DNS64 is enabled globally at the network level.</summary>
    [JsonPropertyName("allQueries")]
    public bool? AllQueries { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderDns64Config
{
    /// <summary>The scope to which DNS64 config will be applied to. Structure is documented below.</summary>
    [JsonPropertyName("scope")]
    public IList<V1beta1PolicyStatusAtProviderDns64ConfigScope>? Scope { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderNetworks
{
    /// <summary>The id or fully qualified URL of the VPC network to forward queries to. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProvider
{
    /// <summary>Sets an alternative name server for the associated networks. When specified, all DNS queries are forwarded to a name server that you choose. Names such as .internal are not available when an alternative name server is specified. Structure is documented below.</summary>
    [JsonPropertyName("alternativeNameServerConfig")]
    public IList<V1beta1PolicyStatusAtProviderAlternativeNameServerConfig>? AlternativeNameServerConfig { get; set; }

    /// <summary>A textual description field.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configurations related to DNS64 for this Policy. Structure is documented below.</summary>
    [JsonPropertyName("dns64Config")]
    public IList<V1beta1PolicyStatusAtProviderDns64Config>? Dns64Config { get; set; }

    /// <summary>Allows networks bound to this policy to receive DNS queries sent by VMs or applications over VPN connections. When enabled, a virtual IP address will be allocated from each of the sub-networks that are bound to this policy.</summary>
    [JsonPropertyName("enableInboundForwarding")]
    public bool? EnableInboundForwarding { get; set; }

    /// <summary>Controls whether logging is enabled for the networks bound to this policy. Defaults to no logging if not set.</summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/policies/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>List of network names specifying networks to which this policy is applied. Structure is documented below.</summary>
    [JsonPropertyName("networks")]
    public IList<V1beta1PolicyStatusAtProviderNetworks>? Networks { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusConditions
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
/// <summary>PolicyStatus defines the observed state of Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policy is the Schema for the Policys API. A policy is a collection of DNS rules applied to one or more Virtual Private Cloud resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Policy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PolicySpec>, IStatus<V1beta1PolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Policy";
    public const string KubeGroup = "dns.gcp.upbound.io";
    public const string KubePluralName = "policies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PolicySpec defines the desired state of Policy</summary>
    [JsonPropertyName("spec")]
    public V1beta1PolicySpec Spec { get; set; }

    /// <summary>PolicyStatus defines the observed state of Policy.</summary>
    [JsonPropertyName("status")]
    public V1beta1PolicyStatus? Status { get; set; }
}
#nullable disable
