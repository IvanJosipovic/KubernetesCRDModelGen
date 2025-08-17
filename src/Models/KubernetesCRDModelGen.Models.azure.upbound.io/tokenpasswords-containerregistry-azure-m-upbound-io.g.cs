using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerregistry.azure.m.upbound.io;
#nullable enable
/// <summary>TokenPassword is the Schema for the TokenPasswords API. Manages a Container Registry Token Password.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TokenPasswordList : IKubernetesObject<V1ListMeta>, IItems<V1beta1TokenPassword>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TokenPasswordList";
    public const string KubeGroup = "containerregistry.azure.m.upbound.io";
    public const string KubePluralName = "tokenpasswords";
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
    public IList<V1beta1TokenPassword> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdRefPolicy
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
/// <summary>Reference to a Token in containerregistry to populate containerRegistryTokenId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdSelectorPolicy
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
/// <summary>Selector for a Token in containerregistry to populate containerRegistryTokenId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdSelector
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
    public V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>One password block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TokenPasswordSpecForProviderPassword1
{
    /// <summary>The expiration date of the password in RFC3339 format. If not specified, the password never expires. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }
}
#nullable disable

#nullable enable
/// <summary>One password block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TokenPasswordSpecForProviderPassword2
{
    /// <summary>The expiration date of the password in RFC3339 format. If not specified, the password never expires. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TokenPasswordSpecForProvider
{
    /// <summary>The ID of the Container Registry Token that this Container Registry Token Password resides in. Changing this forces a new Container Registry Token Password to be created.</summary>
    [JsonPropertyName("containerRegistryTokenId")]
    public string? ContainerRegistryTokenId { get; set; }

    /// <summary>Reference to a Token in containerregistry to populate containerRegistryTokenId.</summary>
    [JsonPropertyName("containerRegistryTokenIdRef")]
    public V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdRef? ContainerRegistryTokenIdRef { get; set; }

    /// <summary>Selector for a Token in containerregistry to populate containerRegistryTokenId.</summary>
    [JsonPropertyName("containerRegistryTokenIdSelector")]
    public V1beta1TokenPasswordSpecForProviderContainerRegistryTokenIdSelector? ContainerRegistryTokenIdSelector { get; set; }

    /// <summary>One password block as defined below.</summary>
    [JsonPropertyName("password1")]
    public V1beta1TokenPasswordSpecForProviderPassword1? Password1 { get; set; }

    /// <summary>One password block as defined below.</summary>
    [JsonPropertyName("password2")]
    public V1beta1TokenPasswordSpecForProviderPassword2? Password2 { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdRefPolicy
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
/// <summary>Reference to a Token in containerregistry to populate containerRegistryTokenId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdSelectorPolicy
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
/// <summary>Selector for a Token in containerregistry to populate containerRegistryTokenId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdSelector
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
    public V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>One password block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TokenPasswordSpecInitProviderPassword1
{
    /// <summary>The expiration date of the password in RFC3339 format. If not specified, the password never expires. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }
}
#nullable disable

#nullable enable
/// <summary>One password block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TokenPasswordSpecInitProviderPassword2
{
    /// <summary>The expiration date of the password in RFC3339 format. If not specified, the password never expires. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TokenPasswordSpecInitProvider
{
    /// <summary>The ID of the Container Registry Token that this Container Registry Token Password resides in. Changing this forces a new Container Registry Token Password to be created.</summary>
    [JsonPropertyName("containerRegistryTokenId")]
    public string? ContainerRegistryTokenId { get; set; }

    /// <summary>Reference to a Token in containerregistry to populate containerRegistryTokenId.</summary>
    [JsonPropertyName("containerRegistryTokenIdRef")]
    public V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdRef? ContainerRegistryTokenIdRef { get; set; }

    /// <summary>Selector for a Token in containerregistry to populate containerRegistryTokenId.</summary>
    [JsonPropertyName("containerRegistryTokenIdSelector")]
    public V1beta1TokenPasswordSpecInitProviderContainerRegistryTokenIdSelector? ContainerRegistryTokenIdSelector { get; set; }

    /// <summary>One password block as defined below.</summary>
    [JsonPropertyName("password1")]
    public V1beta1TokenPasswordSpecInitProviderPassword1? Password1 { get; set; }

    /// <summary>One password block as defined below.</summary>
    [JsonPropertyName("password2")]
    public V1beta1TokenPasswordSpecInitProviderPassword2? Password2 { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TokenPasswordSpecProviderConfigRef
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
public partial class V1beta1TokenPasswordSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>TokenPasswordSpec defines the desired state of TokenPassword</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TokenPasswordSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TokenPasswordSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TokenPasswordSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TokenPasswordSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TokenPasswordSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>One password block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TokenPasswordStatusAtProviderPassword1
{
    /// <summary>The expiration date of the password in RFC3339 format. If not specified, the password never expires. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }
}
#nullable disable

#nullable enable
/// <summary>One password block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TokenPasswordStatusAtProviderPassword2
{
    /// <summary>The expiration date of the password in RFC3339 format. If not specified, the password never expires. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TokenPasswordStatusAtProvider
{
    /// <summary>The ID of the Container Registry Token that this Container Registry Token Password resides in. Changing this forces a new Container Registry Token Password to be created.</summary>
    [JsonPropertyName("containerRegistryTokenId")]
    public string? ContainerRegistryTokenId { get; set; }

    /// <summary>The ID of the Container Registry Token Password.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>One password block as defined below.</summary>
    [JsonPropertyName("password1")]
    public V1beta1TokenPasswordStatusAtProviderPassword1? Password1 { get; set; }

    /// <summary>One password block as defined below.</summary>
    [JsonPropertyName("password2")]
    public V1beta1TokenPasswordStatusAtProviderPassword2? Password2 { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TokenPasswordStatusConditions
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
/// <summary>TokenPasswordStatus defines the observed state of TokenPassword.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TokenPasswordStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TokenPasswordStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TokenPasswordStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>TokenPassword is the Schema for the TokenPasswords API. Manages a Container Registry Token Password.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TokenPassword : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TokenPasswordSpec>, IStatus<V1beta1TokenPasswordStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TokenPassword";
    public const string KubeGroup = "containerregistry.azure.m.upbound.io";
    public const string KubePluralName = "tokenpasswords";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TokenPasswordSpec defines the desired state of TokenPassword</summary>
    [JsonPropertyName("spec")]
    public V1beta1TokenPasswordSpec Spec { get; set; }

    /// <summary>TokenPasswordStatus defines the observed state of TokenPassword.</summary>
    [JsonPropertyName("status")]
    public V1beta1TokenPasswordStatus? Status { get; set; }
}
#nullable disable
