using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventarc.cnrm.cloud.google.com;
#nullable enable
/// <summary>EventarcGoogleChannelConfig is the Schema for the EventarcGoogleChannelConfig API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EventarcGoogleChannelConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1EventarcGoogleChannelConfig>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EventarcGoogleChannelConfigList";
    public const string KubeGroup = "eventarc.cnrm.cloud.google.com";
    public const string KubePluralName = "eventarcgooglechannelconfigs";
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
    public IList<V1alpha1EventarcGoogleChannelConfig> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt their event data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventarcGoogleChannelConfigSpecCryptoKeyRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventarcGoogleChannelConfigSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>EventarcGoogleChannelConfigSpec defines the desired state of EventarcGoogleChannelConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventarcGoogleChannelConfigSpec
{
    /// <summary>Optional. Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt their event data.</summary>
    [JsonPropertyName("cryptoKeyRef")]
    public V1alpha1EventarcGoogleChannelConfigSpecCryptoKeyRef? CryptoKeyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1EventarcGoogleChannelConfigSpecProjectRef ProjectRef { get; set; }

    /// <summary>The user-provided name of the EventarcGoogleChannelConfig. If not specified, the name of the KRM resource will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventarcGoogleChannelConfigStatusConditions
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
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventarcGoogleChannelConfigStatusObservedState
{
    /// <summary>Output only. The last-modified time.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>EventarcGoogleChannelConfigStatus defines the config connector machine state of EventarcGoogleChannelConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventarcGoogleChannelConfigStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1EventarcGoogleChannelConfigStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the EventarcGoogleChannelConfig resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1EventarcGoogleChannelConfigStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>EventarcGoogleChannelConfig is the Schema for the EventarcGoogleChannelConfig API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EventarcGoogleChannelConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1EventarcGoogleChannelConfigSpec>, IStatus<V1alpha1EventarcGoogleChannelConfigStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EventarcGoogleChannelConfig";
    public const string KubeGroup = "eventarc.cnrm.cloud.google.com";
    public const string KubePluralName = "eventarcgooglechannelconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EventarcGoogleChannelConfigSpec defines the desired state of EventarcGoogleChannelConfig</summary>
    [JsonPropertyName("spec")]
    public V1alpha1EventarcGoogleChannelConfigSpec Spec { get; set; }

    /// <summary>EventarcGoogleChannelConfigStatus defines the config connector machine state of EventarcGoogleChannelConfig</summary>
    [JsonPropertyName("status")]
    public V1alpha1EventarcGoogleChannelConfigStatus? Status { get; set; }
}
#nullable disable
