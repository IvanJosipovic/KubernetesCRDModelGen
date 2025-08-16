using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appmesh.aws.m.upbound.io;
/// <summary>Mesh is the Schema for the Meshs API. Provides an AWS App Mesh service mesh resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MeshList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Mesh>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MeshList";
    public const string KubeGroup = "appmesh.aws.m.upbound.io";
    public const string KubePluralName = "meshes";
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
    public IList<V1beta1Mesh> Items { get; set; }
}

/// <summary>Egress filter rules for the service mesh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MeshSpecForProviderSpecEgressFilter
{
    /// <summary>Egress filter type. By default, the type is DROP_ALL. Valid values are ALLOW_ALL and DROP_ALL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The service discovery information for the service mesh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MeshSpecForProviderSpecServiceDiscovery
{
    /// <summary>The IP version to use to control traffic within the mesh. Valid values are IPv6_PREFERRED, IPv4_PREFERRED, IPv4_ONLY, and IPv6_ONLY.</summary>
    [JsonPropertyName("ipPreference")]
    public string? IpPreference { get; set; }
}

/// <summary>Service mesh specification to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MeshSpecForProviderSpec
{
    /// <summary>Egress filter rules for the service mesh.</summary>
    [JsonPropertyName("egressFilter")]
    public V1beta1MeshSpecForProviderSpecEgressFilter? EgressFilter { get; set; }

    /// <summary>The service discovery information for the service mesh.</summary>
    [JsonPropertyName("serviceDiscovery")]
    public V1beta1MeshSpecForProviderSpecServiceDiscovery? ServiceDiscovery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MeshSpecForProvider
{
    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Service mesh specification to apply.</summary>
    [JsonPropertyName("spec")]
    public V1beta1MeshSpecForProviderSpec? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Egress filter rules for the service mesh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MeshSpecInitProviderSpecEgressFilter
{
    /// <summary>Egress filter type. By default, the type is DROP_ALL. Valid values are ALLOW_ALL and DROP_ALL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The service discovery information for the service mesh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MeshSpecInitProviderSpecServiceDiscovery
{
    /// <summary>The IP version to use to control traffic within the mesh. Valid values are IPv6_PREFERRED, IPv4_PREFERRED, IPv4_ONLY, and IPv6_ONLY.</summary>
    [JsonPropertyName("ipPreference")]
    public string? IpPreference { get; set; }
}

/// <summary>Service mesh specification to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MeshSpecInitProviderSpec
{
    /// <summary>Egress filter rules for the service mesh.</summary>
    [JsonPropertyName("egressFilter")]
    public V1beta1MeshSpecInitProviderSpecEgressFilter? EgressFilter { get; set; }

    /// <summary>The service discovery information for the service mesh.</summary>
    [JsonPropertyName("serviceDiscovery")]
    public V1beta1MeshSpecInitProviderSpecServiceDiscovery? ServiceDiscovery { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MeshSpecInitProvider
{
    /// <summary>Service mesh specification to apply.</summary>
    [JsonPropertyName("spec")]
    public V1beta1MeshSpecInitProviderSpec? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MeshSpecProviderConfigRef
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
public partial class V1beta1MeshSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>MeshSpec defines the desired state of Mesh</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MeshSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MeshSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MeshSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MeshSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MeshSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Egress filter rules for the service mesh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MeshStatusAtProviderSpecEgressFilter
{
    /// <summary>Egress filter type. By default, the type is DROP_ALL. Valid values are ALLOW_ALL and DROP_ALL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The service discovery information for the service mesh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MeshStatusAtProviderSpecServiceDiscovery
{
    /// <summary>The IP version to use to control traffic within the mesh. Valid values are IPv6_PREFERRED, IPv4_PREFERRED, IPv4_ONLY, and IPv6_ONLY.</summary>
    [JsonPropertyName("ipPreference")]
    public string? IpPreference { get; set; }
}

/// <summary>Service mesh specification to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MeshStatusAtProviderSpec
{
    /// <summary>Egress filter rules for the service mesh.</summary>
    [JsonPropertyName("egressFilter")]
    public V1beta1MeshStatusAtProviderSpecEgressFilter? EgressFilter { get; set; }

    /// <summary>The service discovery information for the service mesh.</summary>
    [JsonPropertyName("serviceDiscovery")]
    public V1beta1MeshStatusAtProviderSpecServiceDiscovery? ServiceDiscovery { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MeshStatusAtProvider
{
    /// <summary>ARN of the service mesh.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Creation date of the service mesh.</summary>
    [JsonPropertyName("createdDate")]
    public string? CreatedDate { get; set; }

    /// <summary>ID of the service mesh.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Last update date of the service mesh.</summary>
    [JsonPropertyName("lastUpdatedDate")]
    public string? LastUpdatedDate { get; set; }

    /// <summary>AWS account ID of the service mesh's owner.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Resource owner's AWS account ID.</summary>
    [JsonPropertyName("resourceOwner")]
    public string? ResourceOwner { get; set; }

    /// <summary>Service mesh specification to apply.</summary>
    [JsonPropertyName("spec")]
    public V1beta1MeshStatusAtProviderSpec? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MeshStatusConditions
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

/// <summary>MeshStatus defines the observed state of Mesh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MeshStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MeshStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MeshStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Mesh is the Schema for the Meshs API. Provides an AWS App Mesh service mesh resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Mesh : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MeshSpec>, IStatus<V1beta1MeshStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Mesh";
    public const string KubeGroup = "appmesh.aws.m.upbound.io";
    public const string KubePluralName = "meshes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MeshSpec defines the desired state of Mesh</summary>
    [JsonPropertyName("spec")]
    public V1beta1MeshSpec Spec { get; set; }

    /// <summary>MeshStatus defines the observed state of Mesh.</summary>
    [JsonPropertyName("status")]
    public V1beta1MeshStatus? Status { get; set; }
}