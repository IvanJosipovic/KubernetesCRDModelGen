using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
#nullable enable
/// <summary>RouteMap is the Schema for the RouteMaps API. Manages a Route Map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RouteMapList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RouteMap>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RouteMapList";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "routemaps";
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
    public IList<V1beta1RouteMap> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapSpecForProviderRuleActionParameter
{
    /// <summary>A list of AS paths.</summary>
    [JsonPropertyName("asPath")]
    public IList<string>? AsPath { get; set; }

    /// <summary>A list of BGP communities.</summary>
    [JsonPropertyName("community")]
    public IList<string>? Community { get; set; }

    /// <summary>A list of route prefixes.</summary>
    [JsonPropertyName("routePrefix")]
    public IList<string>? RoutePrefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapSpecForProviderRuleAction
{
    /// <summary>A parameter block as defined below. Required if type is anything other than Drop.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1RouteMapSpecForProviderRuleActionParameter>? Parameter { get; set; }

    /// <summary>The type of the action to be taken. Possible values are Add, Drop, Remove, Replace and Unknown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapSpecForProviderRuleMatchCriterion
{
    /// <summary>A list of AS paths.</summary>
    [JsonPropertyName("asPath")]
    public IList<string>? AsPath { get; set; }

    /// <summary>A list of BGP communities.</summary>
    [JsonPropertyName("community")]
    public IList<string>? Community { get; set; }

    /// <summary>The match condition to apply the rule of the Route Map. Possible values are Contains, Equals, NotContains, NotEquals and Unknown.</summary>
    [JsonPropertyName("matchCondition")]
    public string? MatchCondition { get; set; }

    /// <summary>A list of route prefixes.</summary>
    [JsonPropertyName("routePrefix")]
    public IList<string>? RoutePrefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapSpecForProviderRule
{
    /// <summary>An action block as defined below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1RouteMapSpecForProviderRuleAction>? Action { get; set; }

    /// <summary>A match_criterion block as defined below.</summary>
    [JsonPropertyName("matchCriterion")]
    public IList<V1beta1RouteMapSpecForProviderRuleMatchCriterion>? MatchCriterion { get; set; }

    /// <summary>The unique name for the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The next step after the rule is evaluated. Possible values are Continue, Terminate and Unknown. Defaults to Unknown.</summary>
    [JsonPropertyName("nextStepIfMatched")]
    public string? NextStepIfMatched { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapSpecForProviderVirtualHubIdRefPolicy
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
/// <summary>Reference to a VirtualHub in network to populate virtualHubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapSpecForProviderVirtualHubIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouteMapSpecForProviderVirtualHubIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapSpecForProviderVirtualHubIdSelectorPolicy
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
/// <summary>Selector for a VirtualHub in network to populate virtualHubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapSpecForProviderVirtualHubIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouteMapSpecForProviderVirtualHubIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapSpecForProvider
{
    /// <summary>A rule block as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1RouteMapSpecForProviderRule>? Rule { get; set; }

    /// <summary>The resource ID of the Virtual Hub. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualHubId")]
    public string? VirtualHubId { get; set; }

    /// <summary>Reference to a VirtualHub in network to populate virtualHubId.</summary>
    [JsonPropertyName("virtualHubIdRef")]
    public V1beta1RouteMapSpecForProviderVirtualHubIdRef? VirtualHubIdRef { get; set; }

    /// <summary>Selector for a VirtualHub in network to populate virtualHubId.</summary>
    [JsonPropertyName("virtualHubIdSelector")]
    public V1beta1RouteMapSpecForProviderVirtualHubIdSelector? VirtualHubIdSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapSpecInitProviderRuleActionParameter
{
    /// <summary>A list of AS paths.</summary>
    [JsonPropertyName("asPath")]
    public IList<string>? AsPath { get; set; }

    /// <summary>A list of BGP communities.</summary>
    [JsonPropertyName("community")]
    public IList<string>? Community { get; set; }

    /// <summary>A list of route prefixes.</summary>
    [JsonPropertyName("routePrefix")]
    public IList<string>? RoutePrefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapSpecInitProviderRuleAction
{
    /// <summary>A parameter block as defined below. Required if type is anything other than Drop.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1RouteMapSpecInitProviderRuleActionParameter>? Parameter { get; set; }

    /// <summary>The type of the action to be taken. Possible values are Add, Drop, Remove, Replace and Unknown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapSpecInitProviderRuleMatchCriterion
{
    /// <summary>A list of AS paths.</summary>
    [JsonPropertyName("asPath")]
    public IList<string>? AsPath { get; set; }

    /// <summary>A list of BGP communities.</summary>
    [JsonPropertyName("community")]
    public IList<string>? Community { get; set; }

    /// <summary>The match condition to apply the rule of the Route Map. Possible values are Contains, Equals, NotContains, NotEquals and Unknown.</summary>
    [JsonPropertyName("matchCondition")]
    public string? MatchCondition { get; set; }

    /// <summary>A list of route prefixes.</summary>
    [JsonPropertyName("routePrefix")]
    public IList<string>? RoutePrefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapSpecInitProviderRule
{
    /// <summary>An action block as defined below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1RouteMapSpecInitProviderRuleAction>? Action { get; set; }

    /// <summary>A match_criterion block as defined below.</summary>
    [JsonPropertyName("matchCriterion")]
    public IList<V1beta1RouteMapSpecInitProviderRuleMatchCriterion>? MatchCriterion { get; set; }

    /// <summary>The unique name for the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The next step after the rule is evaluated. Possible values are Continue, Terminate and Unknown. Defaults to Unknown.</summary>
    [JsonPropertyName("nextStepIfMatched")]
    public string? NextStepIfMatched { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapSpecInitProvider
{
    /// <summary>A rule block as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1RouteMapSpecInitProviderRule>? Rule { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapSpecProviderConfigRefPolicy
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
public partial class V1beta1RouteMapSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouteMapSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapSpecWriteConnectionSecretToRef
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
/// <summary>RouteMapSpec defines the desired state of RouteMap</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RouteMapSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RouteMapSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RouteMapSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RouteMapSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapStatusAtProviderRuleActionParameter
{
    /// <summary>A list of AS paths.</summary>
    [JsonPropertyName("asPath")]
    public IList<string>? AsPath { get; set; }

    /// <summary>A list of BGP communities.</summary>
    [JsonPropertyName("community")]
    public IList<string>? Community { get; set; }

    /// <summary>A list of route prefixes.</summary>
    [JsonPropertyName("routePrefix")]
    public IList<string>? RoutePrefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapStatusAtProviderRuleAction
{
    /// <summary>A parameter block as defined below. Required if type is anything other than Drop.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1RouteMapStatusAtProviderRuleActionParameter>? Parameter { get; set; }

    /// <summary>The type of the action to be taken. Possible values are Add, Drop, Remove, Replace and Unknown.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapStatusAtProviderRuleMatchCriterion
{
    /// <summary>A list of AS paths.</summary>
    [JsonPropertyName("asPath")]
    public IList<string>? AsPath { get; set; }

    /// <summary>A list of BGP communities.</summary>
    [JsonPropertyName("community")]
    public IList<string>? Community { get; set; }

    /// <summary>The match condition to apply the rule of the Route Map. Possible values are Contains, Equals, NotContains, NotEquals and Unknown.</summary>
    [JsonPropertyName("matchCondition")]
    public string? MatchCondition { get; set; }

    /// <summary>A list of route prefixes.</summary>
    [JsonPropertyName("routePrefix")]
    public IList<string>? RoutePrefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapStatusAtProviderRule
{
    /// <summary>An action block as defined below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1RouteMapStatusAtProviderRuleAction>? Action { get; set; }

    /// <summary>A match_criterion block as defined below.</summary>
    [JsonPropertyName("matchCriterion")]
    public IList<V1beta1RouteMapStatusAtProviderRuleMatchCriterion>? MatchCriterion { get; set; }

    /// <summary>The unique name for the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The next step after the rule is evaluated. Possible values are Continue, Terminate and Unknown. Defaults to Unknown.</summary>
    [JsonPropertyName("nextStepIfMatched")]
    public string? NextStepIfMatched { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapStatusAtProvider
{
    /// <summary>The ID of the Route Map.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A rule block as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1RouteMapStatusAtProviderRule>? Rule { get; set; }

    /// <summary>The resource ID of the Virtual Hub. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualHubId")]
    public string? VirtualHubId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapStatusConditions
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
/// <summary>RouteMapStatus defines the observed state of RouteMap.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteMapStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RouteMapStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RouteMapStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>RouteMap is the Schema for the RouteMaps API. Manages a Route Map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RouteMap : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RouteMapSpec>, IStatus<V1beta1RouteMapStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RouteMap";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "routemaps";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RouteMapSpec defines the desired state of RouteMap</summary>
    [JsonPropertyName("spec")]
    public V1beta1RouteMapSpec Spec { get; set; }

    /// <summary>RouteMapStatus defines the observed state of RouteMap.</summary>
    [JsonPropertyName("status")]
    public V1beta1RouteMapStatus? Status { get; set; }
}
#nullable disable
