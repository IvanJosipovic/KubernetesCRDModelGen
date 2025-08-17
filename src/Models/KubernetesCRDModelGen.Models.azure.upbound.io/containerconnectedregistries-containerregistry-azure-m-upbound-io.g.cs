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
/// <summary>ContainerConnectedRegistry is the Schema for the ContainerConnectedRegistrys API. Manages a Container Connected Registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ContainerConnectedRegistryList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ContainerConnectedRegistry>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ContainerConnectedRegistryList";
    public const string KubeGroup = "containerregistry.azure.m.upbound.io";
    public const string KubePluralName = "containerconnectedregistries";
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
    public IList<V1beta1ContainerConnectedRegistry> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpecForProviderContainerRegistryIdRefPolicy
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
/// <summary>Reference to a Registry in containerregistry to populate containerRegistryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpecForProviderContainerRegistryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerConnectedRegistrySpecForProviderContainerRegistryIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpecForProviderContainerRegistryIdSelectorPolicy
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
/// <summary>Selector for a Registry in containerregistry to populate containerRegistryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpecForProviderContainerRegistryIdSelector
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
    public V1beta1ContainerConnectedRegistrySpecForProviderContainerRegistryIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpecForProviderNotification
{
    /// <summary>The action of the artifact that wants to be subscribed for the Connected Registry. Possible values are push, delete and * (i.e. any).</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The digest of the artifact that wants to be subscribed for the Connected Registry.</summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>The name of the artifact that wants to be subscribed for the Connected Registry.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The tag of the artifact that wants to be subscribed for the Connected Registry.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpecForProviderSyncTokenIdRefPolicy
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
/// <summary>Reference to a Token in containerregistry to populate syncTokenId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpecForProviderSyncTokenIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerConnectedRegistrySpecForProviderSyncTokenIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpecForProviderSyncTokenIdSelectorPolicy
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
/// <summary>Selector for a Token in containerregistry to populate syncTokenId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpecForProviderSyncTokenIdSelector
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
    public V1beta1ContainerConnectedRegistrySpecForProviderSyncTokenIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpecForProvider
{
    /// <summary>Should the log auditing be enabled?</summary>
    [JsonPropertyName("auditLogEnabled")]
    public bool? AuditLogEnabled { get; set; }

    /// <summary>Specifies a list of IDs of Container Registry Tokens, which are meant to be used by the clients to connect to the Connected Registry.</summary>
    [JsonPropertyName("clientTokenIds")]
    public IList<string>? ClientTokenIds { get; set; }

    /// <summary>The ID of the Container Registry that this Connected Registry will reside in. Changing this forces a new Container Connected Registry to be created.</summary>
    [JsonPropertyName("containerRegistryId")]
    public string? ContainerRegistryId { get; set; }

    /// <summary>Reference to a Registry in containerregistry to populate containerRegistryId.</summary>
    [JsonPropertyName("containerRegistryIdRef")]
    public V1beta1ContainerConnectedRegistrySpecForProviderContainerRegistryIdRef? ContainerRegistryIdRef { get; set; }

    /// <summary>Selector for a Registry in containerregistry to populate containerRegistryId.</summary>
    [JsonPropertyName("containerRegistryIdSelector")]
    public V1beta1ContainerConnectedRegistrySpecForProviderContainerRegistryIdSelector? ContainerRegistryIdSelector { get; set; }

    /// <summary>The verbosity of the logs. Possible values are None, Debug, Information, Warning and Error. Defaults to None.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>The mode of the Connected Registry. Possible values are Mirror, ReadOnly, ReadWrite and Registry. Changing this forces a new Container Connected Registry to be created. Defaults to ReadWrite.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>One or more notification blocks as defined below.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta1ContainerConnectedRegistrySpecForProviderNotification>? Notification { get; set; }

    /// <summary>The ID of the parent registry. This can be either a Container Registry ID or a Connected Registry ID. Changing this forces a new Container Connected Registry to be created.</summary>
    [JsonPropertyName("parentRegistryId")]
    public string? ParentRegistryId { get; set; }

    /// <summary>The period of time (in form of ISO8601) for which a message is available to sync before it is expired. Allowed range is from P1D to P90D. Defaults to P1D.</summary>
    [JsonPropertyName("syncMessageTtl")]
    public string? SyncMessageTtl { get; set; }

    /// <summary>The cron expression indicating the schedule that the Connected Registry will sync with its parent. Defaults to * * * * *.</summary>
    [JsonPropertyName("syncSchedule")]
    public string? SyncSchedule { get; set; }

    /// <summary>The ID of the Container Registry Token which is used for synchronizing the Connected Registry. Changing this forces a new Container Connected Registry to be created.</summary>
    [JsonPropertyName("syncTokenId")]
    public string? SyncTokenId { get; set; }

    /// <summary>Reference to a Token in containerregistry to populate syncTokenId.</summary>
    [JsonPropertyName("syncTokenIdRef")]
    public V1beta1ContainerConnectedRegistrySpecForProviderSyncTokenIdRef? SyncTokenIdRef { get; set; }

    /// <summary>Selector for a Token in containerregistry to populate syncTokenId.</summary>
    [JsonPropertyName("syncTokenIdSelector")]
    public V1beta1ContainerConnectedRegistrySpecForProviderSyncTokenIdSelector? SyncTokenIdSelector { get; set; }

    /// <summary>The time window (in form of ISO8601) during which sync is enabled for each schedule occurrence. Allowed range is from PT3H to P7D.</summary>
    [JsonPropertyName("syncWindow")]
    public string? SyncWindow { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpecInitProviderContainerRegistryIdRefPolicy
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
/// <summary>Reference to a Registry in containerregistry to populate containerRegistryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpecInitProviderContainerRegistryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerConnectedRegistrySpecInitProviderContainerRegistryIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpecInitProviderContainerRegistryIdSelectorPolicy
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
/// <summary>Selector for a Registry in containerregistry to populate containerRegistryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpecInitProviderContainerRegistryIdSelector
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
    public V1beta1ContainerConnectedRegistrySpecInitProviderContainerRegistryIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpecInitProviderNotification
{
    /// <summary>The action of the artifact that wants to be subscribed for the Connected Registry. Possible values are push, delete and * (i.e. any).</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The digest of the artifact that wants to be subscribed for the Connected Registry.</summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>The name of the artifact that wants to be subscribed for the Connected Registry.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The tag of the artifact that wants to be subscribed for the Connected Registry.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpecInitProviderSyncTokenIdRefPolicy
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
/// <summary>Reference to a Token in containerregistry to populate syncTokenId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpecInitProviderSyncTokenIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerConnectedRegistrySpecInitProviderSyncTokenIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpecInitProviderSyncTokenIdSelectorPolicy
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
/// <summary>Selector for a Token in containerregistry to populate syncTokenId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpecInitProviderSyncTokenIdSelector
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
    public V1beta1ContainerConnectedRegistrySpecInitProviderSyncTokenIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpecInitProvider
{
    /// <summary>Should the log auditing be enabled?</summary>
    [JsonPropertyName("auditLogEnabled")]
    public bool? AuditLogEnabled { get; set; }

    /// <summary>Specifies a list of IDs of Container Registry Tokens, which are meant to be used by the clients to connect to the Connected Registry.</summary>
    [JsonPropertyName("clientTokenIds")]
    public IList<string>? ClientTokenIds { get; set; }

    /// <summary>The ID of the Container Registry that this Connected Registry will reside in. Changing this forces a new Container Connected Registry to be created.</summary>
    [JsonPropertyName("containerRegistryId")]
    public string? ContainerRegistryId { get; set; }

    /// <summary>Reference to a Registry in containerregistry to populate containerRegistryId.</summary>
    [JsonPropertyName("containerRegistryIdRef")]
    public V1beta1ContainerConnectedRegistrySpecInitProviderContainerRegistryIdRef? ContainerRegistryIdRef { get; set; }

    /// <summary>Selector for a Registry in containerregistry to populate containerRegistryId.</summary>
    [JsonPropertyName("containerRegistryIdSelector")]
    public V1beta1ContainerConnectedRegistrySpecInitProviderContainerRegistryIdSelector? ContainerRegistryIdSelector { get; set; }

    /// <summary>The verbosity of the logs. Possible values are None, Debug, Information, Warning and Error. Defaults to None.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>The mode of the Connected Registry. Possible values are Mirror, ReadOnly, ReadWrite and Registry. Changing this forces a new Container Connected Registry to be created. Defaults to ReadWrite.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>One or more notification blocks as defined below.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta1ContainerConnectedRegistrySpecInitProviderNotification>? Notification { get; set; }

    /// <summary>The ID of the parent registry. This can be either a Container Registry ID or a Connected Registry ID. Changing this forces a new Container Connected Registry to be created.</summary>
    [JsonPropertyName("parentRegistryId")]
    public string? ParentRegistryId { get; set; }

    /// <summary>The period of time (in form of ISO8601) for which a message is available to sync before it is expired. Allowed range is from P1D to P90D. Defaults to P1D.</summary>
    [JsonPropertyName("syncMessageTtl")]
    public string? SyncMessageTtl { get; set; }

    /// <summary>The cron expression indicating the schedule that the Connected Registry will sync with its parent. Defaults to * * * * *.</summary>
    [JsonPropertyName("syncSchedule")]
    public string? SyncSchedule { get; set; }

    /// <summary>The ID of the Container Registry Token which is used for synchronizing the Connected Registry. Changing this forces a new Container Connected Registry to be created.</summary>
    [JsonPropertyName("syncTokenId")]
    public string? SyncTokenId { get; set; }

    /// <summary>Reference to a Token in containerregistry to populate syncTokenId.</summary>
    [JsonPropertyName("syncTokenIdRef")]
    public V1beta1ContainerConnectedRegistrySpecInitProviderSyncTokenIdRef? SyncTokenIdRef { get; set; }

    /// <summary>Selector for a Token in containerregistry to populate syncTokenId.</summary>
    [JsonPropertyName("syncTokenIdSelector")]
    public V1beta1ContainerConnectedRegistrySpecInitProviderSyncTokenIdSelector? SyncTokenIdSelector { get; set; }

    /// <summary>The time window (in form of ISO8601) during which sync is enabled for each schedule occurrence. Allowed range is from PT3H to P7D.</summary>
    [JsonPropertyName("syncWindow")]
    public string? SyncWindow { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpecProviderConfigRef
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
public partial class V1beta1ContainerConnectedRegistrySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ContainerConnectedRegistrySpec defines the desired state of ContainerConnectedRegistry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistrySpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ContainerConnectedRegistrySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ContainerConnectedRegistrySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ContainerConnectedRegistrySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ContainerConnectedRegistrySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistryStatusAtProviderNotification
{
    /// <summary>The action of the artifact that wants to be subscribed for the Connected Registry. Possible values are push, delete and * (i.e. any).</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The digest of the artifact that wants to be subscribed for the Connected Registry.</summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>The name of the artifact that wants to be subscribed for the Connected Registry.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The tag of the artifact that wants to be subscribed for the Connected Registry.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistryStatusAtProvider
{
    /// <summary>Should the log auditing be enabled?</summary>
    [JsonPropertyName("auditLogEnabled")]
    public bool? AuditLogEnabled { get; set; }

    /// <summary>Specifies a list of IDs of Container Registry Tokens, which are meant to be used by the clients to connect to the Connected Registry.</summary>
    [JsonPropertyName("clientTokenIds")]
    public IList<string>? ClientTokenIds { get; set; }

    /// <summary>The ID of the Container Registry that this Connected Registry will reside in. Changing this forces a new Container Connected Registry to be created.</summary>
    [JsonPropertyName("containerRegistryId")]
    public string? ContainerRegistryId { get; set; }

    /// <summary>The ID of the Container Connected Registry.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The verbosity of the logs. Possible values are None, Debug, Information, Warning and Error. Defaults to None.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>The mode of the Connected Registry. Possible values are Mirror, ReadOnly, ReadWrite and Registry. Changing this forces a new Container Connected Registry to be created. Defaults to ReadWrite.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>One or more notification blocks as defined below.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta1ContainerConnectedRegistryStatusAtProviderNotification>? Notification { get; set; }

    /// <summary>The ID of the parent registry. This can be either a Container Registry ID or a Connected Registry ID. Changing this forces a new Container Connected Registry to be created.</summary>
    [JsonPropertyName("parentRegistryId")]
    public string? ParentRegistryId { get; set; }

    /// <summary>The period of time (in form of ISO8601) for which a message is available to sync before it is expired. Allowed range is from P1D to P90D. Defaults to P1D.</summary>
    [JsonPropertyName("syncMessageTtl")]
    public string? SyncMessageTtl { get; set; }

    /// <summary>The cron expression indicating the schedule that the Connected Registry will sync with its parent. Defaults to * * * * *.</summary>
    [JsonPropertyName("syncSchedule")]
    public string? SyncSchedule { get; set; }

    /// <summary>The ID of the Container Registry Token which is used for synchronizing the Connected Registry. Changing this forces a new Container Connected Registry to be created.</summary>
    [JsonPropertyName("syncTokenId")]
    public string? SyncTokenId { get; set; }

    /// <summary>The time window (in form of ISO8601) during which sync is enabled for each schedule occurrence. Allowed range is from PT3H to P7D.</summary>
    [JsonPropertyName("syncWindow")]
    public string? SyncWindow { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistryStatusConditions
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
/// <summary>ContainerConnectedRegistryStatus defines the observed state of ContainerConnectedRegistry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerConnectedRegistryStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ContainerConnectedRegistryStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ContainerConnectedRegistryStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ContainerConnectedRegistry is the Schema for the ContainerConnectedRegistrys API. Manages a Container Connected Registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ContainerConnectedRegistry : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ContainerConnectedRegistrySpec>, IStatus<V1beta1ContainerConnectedRegistryStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ContainerConnectedRegistry";
    public const string KubeGroup = "containerregistry.azure.m.upbound.io";
    public const string KubePluralName = "containerconnectedregistries";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ContainerConnectedRegistrySpec defines the desired state of ContainerConnectedRegistry</summary>
    [JsonPropertyName("spec")]
    public V1beta1ContainerConnectedRegistrySpec Spec { get; set; }

    /// <summary>ContainerConnectedRegistryStatus defines the observed state of ContainerConnectedRegistry.</summary>
    [JsonPropertyName("status")]
    public V1beta1ContainerConnectedRegistryStatus? Status { get; set; }
}
#nullable disable
