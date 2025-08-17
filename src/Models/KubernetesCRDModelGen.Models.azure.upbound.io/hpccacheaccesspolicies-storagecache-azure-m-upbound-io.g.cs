using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storagecache.azure.m.upbound.io;
#nullable enable
/// <summary>HPCCacheAccessPolicy is the Schema for the HPCCacheAccessPolicys API. Manages a HPC Cache Access Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1HPCCacheAccessPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1HPCCacheAccessPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HPCCacheAccessPolicyList";
    public const string KubeGroup = "storagecache.azure.m.upbound.io";
    public const string KubePluralName = "hpccacheaccesspolicies";
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
    public IList<V1beta1HPCCacheAccessPolicy> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheAccessPolicySpecForProviderAccessRule
{
    /// <summary>The access level for this rule. Possible values are: rw, ro, no.</summary>
    [JsonPropertyName("access")]
    public string? Access { get; set; }

    /// <summary>The anonymous GID used when root_squash_enabled is true.</summary>
    [JsonPropertyName("anonymousGid")]
    public double? AnonymousGid { get; set; }

    /// <summary>The anonymous UID used when root_squash_enabled is true.</summary>
    [JsonPropertyName("anonymousUid")]
    public double? AnonymousUid { get; set; }

    /// <summary>The filter applied to the scope for this rule. The filter's format depends on its scope: default scope matches all clients and has no filter value; network scope takes a CIDR format; host takes an IP address or fully qualified domain name. If a client does not match any filter rule and there is no default rule, access is denied.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>Whether to enable root squash?</summary>
    [JsonPropertyName("rootSquashEnabled")]
    public bool? RootSquashEnabled { get; set; }

    /// <summary>The scope of this rule. The scope and (potentially) the filter determine which clients match the rule. Possible values are: default, network, host.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Whether allow access to subdirectories under the root export?</summary>
    [JsonPropertyName("submountAccessEnabled")]
    public bool? SubmountAccessEnabled { get; set; }

    /// <summary>Whether SUID is allowed?</summary>
    [JsonPropertyName("suidEnabled")]
    public bool? SuidEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheAccessPolicySpecForProviderHpcCacheIdRefPolicy
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
/// <summary>Reference to a HPCCache in storagecache to populate hpcCacheId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheAccessPolicySpecForProviderHpcCacheIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HPCCacheAccessPolicySpecForProviderHpcCacheIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheAccessPolicySpecForProviderHpcCacheIdSelectorPolicy
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
/// <summary>Selector for a HPCCache in storagecache to populate hpcCacheId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheAccessPolicySpecForProviderHpcCacheIdSelector
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
    public V1beta1HPCCacheAccessPolicySpecForProviderHpcCacheIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheAccessPolicySpecForProvider
{
    /// <summary>One or more access_rule blocks (up to three) as defined below.</summary>
    [JsonPropertyName("accessRule")]
    public IList<V1beta1HPCCacheAccessPolicySpecForProviderAccessRule>? AccessRule { get; set; }

    /// <summary>The ID of the HPC Cache that this HPC Cache Access Policy resides in. Changing this forces a new HPC Cache Access Policy to be created.</summary>
    [JsonPropertyName("hpcCacheId")]
    public string? HpcCacheId { get; set; }

    /// <summary>Reference to a HPCCache in storagecache to populate hpcCacheId.</summary>
    [JsonPropertyName("hpcCacheIdRef")]
    public V1beta1HPCCacheAccessPolicySpecForProviderHpcCacheIdRef? HpcCacheIdRef { get; set; }

    /// <summary>Selector for a HPCCache in storagecache to populate hpcCacheId.</summary>
    [JsonPropertyName("hpcCacheIdSelector")]
    public V1beta1HPCCacheAccessPolicySpecForProviderHpcCacheIdSelector? HpcCacheIdSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheAccessPolicySpecInitProviderAccessRule
{
    /// <summary>The access level for this rule. Possible values are: rw, ro, no.</summary>
    [JsonPropertyName("access")]
    public string? Access { get; set; }

    /// <summary>The anonymous GID used when root_squash_enabled is true.</summary>
    [JsonPropertyName("anonymousGid")]
    public double? AnonymousGid { get; set; }

    /// <summary>The anonymous UID used when root_squash_enabled is true.</summary>
    [JsonPropertyName("anonymousUid")]
    public double? AnonymousUid { get; set; }

    /// <summary>The filter applied to the scope for this rule. The filter's format depends on its scope: default scope matches all clients and has no filter value; network scope takes a CIDR format; host takes an IP address or fully qualified domain name. If a client does not match any filter rule and there is no default rule, access is denied.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>Whether to enable root squash?</summary>
    [JsonPropertyName("rootSquashEnabled")]
    public bool? RootSquashEnabled { get; set; }

    /// <summary>The scope of this rule. The scope and (potentially) the filter determine which clients match the rule. Possible values are: default, network, host.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Whether allow access to subdirectories under the root export?</summary>
    [JsonPropertyName("submountAccessEnabled")]
    public bool? SubmountAccessEnabled { get; set; }

    /// <summary>Whether SUID is allowed?</summary>
    [JsonPropertyName("suidEnabled")]
    public bool? SuidEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheAccessPolicySpecInitProviderHpcCacheIdRefPolicy
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
/// <summary>Reference to a HPCCache in storagecache to populate hpcCacheId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheAccessPolicySpecInitProviderHpcCacheIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HPCCacheAccessPolicySpecInitProviderHpcCacheIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheAccessPolicySpecInitProviderHpcCacheIdSelectorPolicy
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
/// <summary>Selector for a HPCCache in storagecache to populate hpcCacheId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheAccessPolicySpecInitProviderHpcCacheIdSelector
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
    public V1beta1HPCCacheAccessPolicySpecInitProviderHpcCacheIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheAccessPolicySpecInitProvider
{
    /// <summary>One or more access_rule blocks (up to three) as defined below.</summary>
    [JsonPropertyName("accessRule")]
    public IList<V1beta1HPCCacheAccessPolicySpecInitProviderAccessRule>? AccessRule { get; set; }

    /// <summary>The ID of the HPC Cache that this HPC Cache Access Policy resides in. Changing this forces a new HPC Cache Access Policy to be created.</summary>
    [JsonPropertyName("hpcCacheId")]
    public string? HpcCacheId { get; set; }

    /// <summary>Reference to a HPCCache in storagecache to populate hpcCacheId.</summary>
    [JsonPropertyName("hpcCacheIdRef")]
    public V1beta1HPCCacheAccessPolicySpecInitProviderHpcCacheIdRef? HpcCacheIdRef { get; set; }

    /// <summary>Selector for a HPCCache in storagecache to populate hpcCacheId.</summary>
    [JsonPropertyName("hpcCacheIdSelector")]
    public V1beta1HPCCacheAccessPolicySpecInitProviderHpcCacheIdSelector? HpcCacheIdSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheAccessPolicySpecProviderConfigRef
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
public partial class V1beta1HPCCacheAccessPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>HPCCacheAccessPolicySpec defines the desired state of HPCCacheAccessPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheAccessPolicySpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1HPCCacheAccessPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1HPCCacheAccessPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1HPCCacheAccessPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1HPCCacheAccessPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheAccessPolicyStatusAtProviderAccessRule
{
    /// <summary>The access level for this rule. Possible values are: rw, ro, no.</summary>
    [JsonPropertyName("access")]
    public string? Access { get; set; }

    /// <summary>The anonymous GID used when root_squash_enabled is true.</summary>
    [JsonPropertyName("anonymousGid")]
    public double? AnonymousGid { get; set; }

    /// <summary>The anonymous UID used when root_squash_enabled is true.</summary>
    [JsonPropertyName("anonymousUid")]
    public double? AnonymousUid { get; set; }

    /// <summary>The filter applied to the scope for this rule. The filter's format depends on its scope: default scope matches all clients and has no filter value; network scope takes a CIDR format; host takes an IP address or fully qualified domain name. If a client does not match any filter rule and there is no default rule, access is denied.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>Whether to enable root squash?</summary>
    [JsonPropertyName("rootSquashEnabled")]
    public bool? RootSquashEnabled { get; set; }

    /// <summary>The scope of this rule. The scope and (potentially) the filter determine which clients match the rule. Possible values are: default, network, host.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Whether allow access to subdirectories under the root export?</summary>
    [JsonPropertyName("submountAccessEnabled")]
    public bool? SubmountAccessEnabled { get; set; }

    /// <summary>Whether SUID is allowed?</summary>
    [JsonPropertyName("suidEnabled")]
    public bool? SuidEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheAccessPolicyStatusAtProvider
{
    /// <summary>One or more access_rule blocks (up to three) as defined below.</summary>
    [JsonPropertyName("accessRule")]
    public IList<V1beta1HPCCacheAccessPolicyStatusAtProviderAccessRule>? AccessRule { get; set; }

    /// <summary>The ID of the HPC Cache that this HPC Cache Access Policy resides in. Changing this forces a new HPC Cache Access Policy to be created.</summary>
    [JsonPropertyName("hpcCacheId")]
    public string? HpcCacheId { get; set; }

    /// <summary>The ID of the HPC Cache Access Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheAccessPolicyStatusConditions
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
/// <summary>HPCCacheAccessPolicyStatus defines the observed state of HPCCacheAccessPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HPCCacheAccessPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1HPCCacheAccessPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1HPCCacheAccessPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>HPCCacheAccessPolicy is the Schema for the HPCCacheAccessPolicys API. Manages a HPC Cache Access Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1HPCCacheAccessPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1HPCCacheAccessPolicySpec>, IStatus<V1beta1HPCCacheAccessPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HPCCacheAccessPolicy";
    public const string KubeGroup = "storagecache.azure.m.upbound.io";
    public const string KubePluralName = "hpccacheaccesspolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HPCCacheAccessPolicySpec defines the desired state of HPCCacheAccessPolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1HPCCacheAccessPolicySpec Spec { get; set; }

    /// <summary>HPCCacheAccessPolicyStatus defines the observed state of HPCCacheAccessPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1HPCCacheAccessPolicyStatus? Status { get; set; }
}
#nullable disable
