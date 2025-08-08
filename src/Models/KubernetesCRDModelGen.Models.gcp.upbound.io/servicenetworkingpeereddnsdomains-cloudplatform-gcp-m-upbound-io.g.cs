using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudplatform.gcp.m.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceNetworkingPeeredDNSDomainSpecForProvider
{
    /// <summary>The DNS domain suffix of the peered DNS domain. Make sure to suffix with a . (dot).</summary>
    [JsonPropertyName("dnsSuffix")]
    public string? DnsSuffix { get; set; }

    /// <summary>The network in the consumer project.</summary>
    [JsonPropertyName("network")]
    public string Network { get; set; }

    /// <summary>The producer project number. If not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Private service connection between service and consumer network, defaults to servicenetworking.googleapis.com</summary>
    [JsonPropertyName("service")]
    public string Service { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceNetworkingPeeredDNSDomainSpecInitProvider
{
    /// <summary>The DNS domain suffix of the peered DNS domain. Make sure to suffix with a . (dot).</summary>
    [JsonPropertyName("dnsSuffix")]
    public string? DnsSuffix { get; set; }

    /// <summary>The producer project number. If not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceNetworkingPeeredDNSDomainSpecProviderConfigRef
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
public partial class V1beta1ServiceNetworkingPeeredDNSDomainSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ServiceNetworkingPeeredDNSDomainSpec defines the desired state of ServiceNetworkingPeeredDNSDomain</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceNetworkingPeeredDNSDomainSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ServiceNetworkingPeeredDNSDomainSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ServiceNetworkingPeeredDNSDomainSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ServiceNetworkingPeeredDNSDomainSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ServiceNetworkingPeeredDNSDomainSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceNetworkingPeeredDNSDomainStatusAtProvider
{
    /// <summary>The DNS domain suffix of the peered DNS domain. Make sure to suffix with a . (dot).</summary>
    [JsonPropertyName("dnsSuffix")]
    public string? DnsSuffix { get; set; }

    /// <summary>an identifier for the resource with format services/{{service}}/projects/{{project}}/global/networks/{{network}}/peeredDnsDomains/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The network in the consumer project.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>an identifier for the resource with format services/{{service}}/projects/{{project}}/global/networks/{{network}}</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>The producer project number. If not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Private service connection between service and consumer network, defaults to servicenetworking.googleapis.com</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceNetworkingPeeredDNSDomainStatusConditions
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

/// <summary>ServiceNetworkingPeeredDNSDomainStatus defines the observed state of ServiceNetworkingPeeredDNSDomain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceNetworkingPeeredDNSDomainStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ServiceNetworkingPeeredDNSDomainStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ServiceNetworkingPeeredDNSDomainStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ServiceNetworkingPeeredDNSDomain is the Schema for the ServiceNetworkingPeeredDNSDomains API. Allows management of a single peered DNS domain on a project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ServiceNetworkingPeeredDNSDomain : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ServiceNetworkingPeeredDNSDomainSpec>, IStatus<V1beta1ServiceNetworkingPeeredDNSDomainStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServiceNetworkingPeeredDNSDomain";
    public const string KubeGroup = "cloudplatform.gcp.m.upbound.io";
    public const string KubePluralName = "servicenetworkingpeereddnsdomains";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ServiceNetworkingPeeredDNSDomainSpec defines the desired state of ServiceNetworkingPeeredDNSDomain</summary>
    [JsonPropertyName("spec")]
    public V1beta1ServiceNetworkingPeeredDNSDomainSpec Spec { get; set; }

    /// <summary>ServiceNetworkingPeeredDNSDomainStatus defines the observed state of ServiceNetworkingPeeredDNSDomain.</summary>
    [JsonPropertyName("status")]
    public V1beta1ServiceNetworkingPeeredDNSDomainStatus? Status { get; set; }
}

/// <summary>ServiceNetworkingPeeredDNSDomain is the Schema for the ServiceNetworkingPeeredDNSDomains API. Allows management of a single peered DNS domain on a project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ServiceNetworkingPeeredDNSDomainList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ServiceNetworkingPeeredDNSDomain>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServiceNetworkingPeeredDNSDomainList";
    public const string KubeGroup = "cloudplatform.gcp.m.upbound.io";
    public const string KubePluralName = "servicenetworkingpeereddnsdomains";
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
    public IList<V1beta1ServiceNetworkingPeeredDNSDomain> Items { get; set; }
}