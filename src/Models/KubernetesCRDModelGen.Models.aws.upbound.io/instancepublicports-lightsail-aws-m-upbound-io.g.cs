using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lightsail.aws.m.upbound.io;
#nullable enable
/// <summary>InstancePublicPorts is the Schema for the InstancePublicPortss API. Manages public ports for a Lightsail instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InstancePublicPortsList : IKubernetesObject<V1ListMeta>, IItems<V1beta1InstancePublicPorts>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InstancePublicPortsList";
    public const string KubeGroup = "lightsail.aws.m.upbound.io";
    public const string KubePluralName = "instancepublicports";
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
    public IList<V1beta1InstancePublicPorts> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePublicPortsSpecForProviderInstanceNameRefPolicy
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
/// <summary>Reference to a Instance in lightsail to populate instanceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePublicPortsSpecForProviderInstanceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstancePublicPortsSpecForProviderInstanceNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePublicPortsSpecForProviderInstanceNameSelectorPolicy
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
/// <summary>Selector for a Instance in lightsail to populate instanceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePublicPortsSpecForProviderInstanceNameSelector
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
    public V1beta1InstancePublicPortsSpecForProviderInstanceNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePublicPortsSpecForProviderPortInfo
{
    /// <summary>Set of CIDR aliases that define access for a preconfigured range of IP addresses.</summary>
    [JsonPropertyName("cidrListAliases")]
    public IList<string>? CidrListAliases { get; set; }

    /// <summary>Set of IPv4 addresses or ranges of IPv4 addresses (in CIDR notation) that are allowed to connect to an instance through the ports, and the protocol.</summary>
    [JsonPropertyName("cidrs")]
    public IList<string>? Cidrs { get; set; }

    /// <summary>First port in a range of open ports on an instance. See PortInfo for details.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>Set of IPv6 addresses or ranges of IPv6 addresses (in CIDR notation) that are allowed to connect to an instance through the ports, and the protocol.</summary>
    [JsonPropertyName("ipv6Cidrs")]
    public IList<string>? Ipv6Cidrs { get; set; }

    /// <summary>IP protocol name. Valid values: tcp, all, udp, icmp, icmpv6. See PortInfo for details.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Last port in a range of open ports on an instance. See PortInfo for details.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePublicPortsSpecForProvider
{
    /// <summary>Name of the instance for which to open ports.</summary>
    [JsonPropertyName("instanceName")]
    public string? InstanceName { get; set; }

    /// <summary>Reference to a Instance in lightsail to populate instanceName.</summary>
    [JsonPropertyName("instanceNameRef")]
    public V1beta1InstancePublicPortsSpecForProviderInstanceNameRef? InstanceNameRef { get; set; }

    /// <summary>Selector for a Instance in lightsail to populate instanceName.</summary>
    [JsonPropertyName("instanceNameSelector")]
    public V1beta1InstancePublicPortsSpecForProviderInstanceNameSelector? InstanceNameSelector { get; set; }

    /// <summary>Descriptor of the ports to open for the specified instance. AWS closes all currently open ports that are not included in this argument. See port_info Block for details.</summary>
    [JsonPropertyName("portInfo")]
    public IList<V1beta1InstancePublicPortsSpecForProviderPortInfo>? PortInfo { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePublicPortsSpecInitProviderInstanceNameRefPolicy
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
/// <summary>Reference to a Instance in lightsail to populate instanceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePublicPortsSpecInitProviderInstanceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstancePublicPortsSpecInitProviderInstanceNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePublicPortsSpecInitProviderInstanceNameSelectorPolicy
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
/// <summary>Selector for a Instance in lightsail to populate instanceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePublicPortsSpecInitProviderInstanceNameSelector
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
    public V1beta1InstancePublicPortsSpecInitProviderInstanceNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePublicPortsSpecInitProviderPortInfo
{
    /// <summary>Set of CIDR aliases that define access for a preconfigured range of IP addresses.</summary>
    [JsonPropertyName("cidrListAliases")]
    public IList<string>? CidrListAliases { get; set; }

    /// <summary>Set of IPv4 addresses or ranges of IPv4 addresses (in CIDR notation) that are allowed to connect to an instance through the ports, and the protocol.</summary>
    [JsonPropertyName("cidrs")]
    public IList<string>? Cidrs { get; set; }

    /// <summary>First port in a range of open ports on an instance. See PortInfo for details.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>Set of IPv6 addresses or ranges of IPv6 addresses (in CIDR notation) that are allowed to connect to an instance through the ports, and the protocol.</summary>
    [JsonPropertyName("ipv6Cidrs")]
    public IList<string>? Ipv6Cidrs { get; set; }

    /// <summary>IP protocol name. Valid values: tcp, all, udp, icmp, icmpv6. See PortInfo for details.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Last port in a range of open ports on an instance. See PortInfo for details.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePublicPortsSpecInitProvider
{
    /// <summary>Name of the instance for which to open ports.</summary>
    [JsonPropertyName("instanceName")]
    public string? InstanceName { get; set; }

    /// <summary>Reference to a Instance in lightsail to populate instanceName.</summary>
    [JsonPropertyName("instanceNameRef")]
    public V1beta1InstancePublicPortsSpecInitProviderInstanceNameRef? InstanceNameRef { get; set; }

    /// <summary>Selector for a Instance in lightsail to populate instanceName.</summary>
    [JsonPropertyName("instanceNameSelector")]
    public V1beta1InstancePublicPortsSpecInitProviderInstanceNameSelector? InstanceNameSelector { get; set; }

    /// <summary>Descriptor of the ports to open for the specified instance. AWS closes all currently open ports that are not included in this argument. See port_info Block for details.</summary>
    [JsonPropertyName("portInfo")]
    public IList<V1beta1InstancePublicPortsSpecInitProviderPortInfo>? PortInfo { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePublicPortsSpecProviderConfigRef
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
public partial class V1beta1InstancePublicPortsSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>InstancePublicPortsSpec defines the desired state of InstancePublicPorts</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePublicPortsSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1InstancePublicPortsSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1InstancePublicPortsSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1InstancePublicPortsSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1InstancePublicPortsSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePublicPortsStatusAtProviderPortInfo
{
    /// <summary>Set of CIDR aliases that define access for a preconfigured range of IP addresses.</summary>
    [JsonPropertyName("cidrListAliases")]
    public IList<string>? CidrListAliases { get; set; }

    /// <summary>Set of IPv4 addresses or ranges of IPv4 addresses (in CIDR notation) that are allowed to connect to an instance through the ports, and the protocol.</summary>
    [JsonPropertyName("cidrs")]
    public IList<string>? Cidrs { get; set; }

    /// <summary>First port in a range of open ports on an instance. See PortInfo for details.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>Set of IPv6 addresses or ranges of IPv6 addresses (in CIDR notation) that are allowed to connect to an instance through the ports, and the protocol.</summary>
    [JsonPropertyName("ipv6Cidrs")]
    public IList<string>? Ipv6Cidrs { get; set; }

    /// <summary>IP protocol name. Valid values: tcp, all, udp, icmp, icmpv6. See PortInfo for details.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Last port in a range of open ports on an instance. See PortInfo for details.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePublicPortsStatusAtProvider
{
    /// <summary>ID of the resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the instance for which to open ports.</summary>
    [JsonPropertyName("instanceName")]
    public string? InstanceName { get; set; }

    /// <summary>Descriptor of the ports to open for the specified instance. AWS closes all currently open ports that are not included in this argument. See port_info Block for details.</summary>
    [JsonPropertyName("portInfo")]
    public IList<V1beta1InstancePublicPortsStatusAtProviderPortInfo>? PortInfo { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePublicPortsStatusConditions
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
/// <summary>InstancePublicPortsStatus defines the observed state of InstancePublicPorts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePublicPortsStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1InstancePublicPortsStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1InstancePublicPortsStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>InstancePublicPorts is the Schema for the InstancePublicPortss API. Manages public ports for a Lightsail instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InstancePublicPorts : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1InstancePublicPortsSpec>, IStatus<V1beta1InstancePublicPortsStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InstancePublicPorts";
    public const string KubeGroup = "lightsail.aws.m.upbound.io";
    public const string KubePluralName = "instancepublicports";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstancePublicPortsSpec defines the desired state of InstancePublicPorts</summary>
    [JsonPropertyName("spec")]
    public V1beta1InstancePublicPortsSpec Spec { get; set; }

    /// <summary>InstancePublicPortsStatus defines the observed state of InstancePublicPorts.</summary>
    [JsonPropertyName("status")]
    public V1beta1InstancePublicPortsStatus? Status { get; set; }
}
#nullable disable
