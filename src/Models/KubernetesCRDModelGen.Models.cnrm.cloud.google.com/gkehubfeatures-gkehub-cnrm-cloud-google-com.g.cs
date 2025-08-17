using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.gkehub.cnrm.cloud.google.com;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GKEHubFeatureList : IKubernetesObject<V1ListMeta>, IItems<V1beta1GKEHubFeature>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GKEHubFeatureList";
    public const string KubeGroup = "gkehub.cnrm.cloud.google.com";
    public const string KubePluralName = "gkehubfeatures";
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
    public IList<V1beta1GKEHubFeature> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureSpecProjectRef
{
    /// <summary>The project for the resource  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specified if applying the default routing config to logs not specified in other configs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureSpecSpecFleetobservabilityLoggingConfigDefaultConfig
{
    /// <summary>The logs routing mode Possible values: MODE_UNSPECIFIED, COPY, MOVE</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specified if applying the routing config to all logs for all fleet scopes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureSpecSpecFleetobservabilityLoggingConfigFleetScopeLogsConfig
{
    /// <summary>The logs routing mode Possible values: MODE_UNSPECIFIED, COPY, MOVE</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Fleet Observability Logging-specific spec.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureSpecSpecFleetobservabilityLoggingConfig
{
    /// <summary>Specified if applying the default routing config to logs not specified in other configs.</summary>
    [JsonPropertyName("defaultConfig")]
    public V1beta1GKEHubFeatureSpecSpecFleetobservabilityLoggingConfigDefaultConfig? DefaultConfig { get; set; }

    /// <summary>Specified if applying the routing config to all logs for all fleet scopes.</summary>
    [JsonPropertyName("fleetScopeLogsConfig")]
    public V1beta1GKEHubFeatureSpecSpecFleetobservabilityLoggingConfigFleetScopeLogsConfig? FleetScopeLogsConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Fleet Observability spec.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureSpecSpecFleetobservability
{
    /// <summary>Fleet Observability Logging-specific spec.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta1GKEHubFeatureSpecSpecFleetobservabilityLoggingConfig? LoggingConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureSpecSpecMulticlusteringressConfigMembershipRef
{
    /// <summary>Fully-qualified Membership name which hosts the MultiClusterIngress CRD. Example: `projects/foo-proj/locations/global/memberships/bar`  Allowed value: The Google Cloud resource name of a `GKEHubMembership` resource (format: `projects/{{project}}/locations/{{location}}/memberships/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Multicluster Ingress-specific spec.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureSpecSpecMulticlusteringress
{
    /// <summary></summary>
    [JsonPropertyName("configMembershipRef")]
    public V1beta1GKEHubFeatureSpecSpecMulticlusteringressConfigMembershipRef ConfigMembershipRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Hub-wide Feature configuration. If this Feature does not support any Hub-wide configuration, this field may be unused.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureSpecSpec
{
    /// <summary>Fleet Observability spec.</summary>
    [JsonPropertyName("fleetobservability")]
    public V1beta1GKEHubFeatureSpecSpecFleetobservability? Fleetobservability { get; set; }

    /// <summary>Multicluster Ingress-specific spec.</summary>
    [JsonPropertyName("multiclusteringress")]
    public V1beta1GKEHubFeatureSpecSpecMulticlusteringress? Multiclusteringress { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureSpec
{
    /// <summary>Immutable. The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1GKEHubFeatureSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. Hub-wide Feature configuration. If this Feature does not support any Hub-wide configuration, this field may be unused.</summary>
    [JsonPropertyName("spec")]
    public V1beta1GKEHubFeatureSpecSpec? Spec { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>State of the Feature resource itself.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureStatusResourceState
{
    /// <summary>Whether this Feature has outstanding resources that need to be cleaned up before it can be disabled.</summary>
    [JsonPropertyName("hasResources")]
    public bool? HasResources { get; set; }

    /// <summary>The current state of the Feature resource in the Hub API. Possible values: STATE_UNSPECIFIED, ENABLING, ACTIVE, DISABLING, UPDATING, SERVICE_UPDATING</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. The "running state" of the Feature in this Hub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureStatusStateState
{
    /// <summary>The high-level, machine-readable status of this Feature. Possible values: CODE_UNSPECIFIED, OK, WARNING, ERROR</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>A human-readable description of the current status.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The time this status and any related Feature-specific details were updated. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z"</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. The Hub-wide Feature state</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureStatusState
{
    /// <summary>Output only. The "running state" of the Feature in this Hub.</summary>
    [JsonPropertyName("state")]
    public V1beta1GKEHubFeatureStatusStateState? State { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GKEHubFeatureStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1GKEHubFeatureStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. When the Feature resource was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. When the Feature resource was deleted.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>State of the Feature resource itself.</summary>
    [JsonPropertyName("resourceState")]
    public V1beta1GKEHubFeatureStatusResourceState? ResourceState { get; set; }

    /// <summary>Output only. The Hub-wide Feature state</summary>
    [JsonPropertyName("state")]
    public V1beta1GKEHubFeatureStatusState? State { get; set; }

    /// <summary>Output only. When the Feature resource was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GKEHubFeature : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1GKEHubFeatureSpec>, IStatus<V1beta1GKEHubFeatureStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GKEHubFeature";
    public const string KubeGroup = "gkehub.cnrm.cloud.google.com";
    public const string KubePluralName = "gkehubfeatures";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1GKEHubFeatureSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1GKEHubFeatureStatus? Status { get; set; }
}
#nullable disable
