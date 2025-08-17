using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.connect.aws.upbound.io;
#nullable enable
/// <summary>Queue is the Schema for the Queues API. Provides details about a specific Amazon Connect Queue</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2QueueList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Queue>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "QueueList";
    public const string KubeGroup = "connect.aws.upbound.io";
    public const string KubePluralName = "queues";
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
    public IList<V1beta2Queue> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderHoursOfOperationIdRefPolicy
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
/// <summary>Reference to a HoursOfOperation in connect to populate hoursOfOperationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderHoursOfOperationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2QueueSpecForProviderHoursOfOperationIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderHoursOfOperationIdSelectorPolicy
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
/// <summary>Selector for a HoursOfOperation in connect to populate hoursOfOperationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderHoursOfOperationIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2QueueSpecForProviderHoursOfOperationIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderInstanceIdRefPolicy
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
/// <summary>Reference to a Instance in connect to populate instanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderInstanceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2QueueSpecForProviderInstanceIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderInstanceIdSelectorPolicy
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
/// <summary>Selector for a Instance in connect to populate instanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderInstanceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2QueueSpecForProviderInstanceIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderOutboundCallerConfig
{
    /// <summary>Specifies the caller ID name.</summary>
    [JsonPropertyName("outboundCallerIdName")]
    public string? OutboundCallerIdName { get; set; }

    /// <summary>Specifies the caller ID number.</summary>
    [JsonPropertyName("outboundCallerIdNumberId")]
    public string? OutboundCallerIdNumberId { get; set; }

    /// <summary>Specifies outbound whisper flow to be used during an outbound call.</summary>
    [JsonPropertyName("outboundFlowId")]
    public string? OutboundFlowId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProvider
{
    /// <summary>Specifies the description of the Queue.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the identifier of the Hours of Operation.</summary>
    [JsonPropertyName("hoursOfOperationId")]
    public string? HoursOfOperationId { get; set; }

    /// <summary>Reference to a HoursOfOperation in connect to populate hoursOfOperationId.</summary>
    [JsonPropertyName("hoursOfOperationIdRef")]
    public V1beta2QueueSpecForProviderHoursOfOperationIdRef? HoursOfOperationIdRef { get; set; }

    /// <summary>Selector for a HoursOfOperation in connect to populate hoursOfOperationId.</summary>
    [JsonPropertyName("hoursOfOperationIdSelector")]
    public V1beta2QueueSpecForProviderHoursOfOperationIdSelector? HoursOfOperationIdSelector { get; set; }

    /// <summary>Specifies the identifier of the hosting Amazon Connect Instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>Reference to a Instance in connect to populate instanceId.</summary>
    [JsonPropertyName("instanceIdRef")]
    public V1beta2QueueSpecForProviderInstanceIdRef? InstanceIdRef { get; set; }

    /// <summary>Selector for a Instance in connect to populate instanceId.</summary>
    [JsonPropertyName("instanceIdSelector")]
    public V1beta2QueueSpecForProviderInstanceIdSelector? InstanceIdSelector { get; set; }

    /// <summary>Specifies the maximum number of contacts that can be in the queue before it is considered full. Minimum value of 0.</summary>
    [JsonPropertyName("maxContacts")]
    public double? MaxContacts { get; set; }

    /// <summary>Specifies the name of the Queue.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A block that defines the outbound caller ID name, number, and outbound whisper flow. The Outbound Caller Config block is documented below.</summary>
    [JsonPropertyName("outboundCallerConfig")]
    public IList<V1beta2QueueSpecForProviderOutboundCallerConfig>? OutboundCallerConfig { get; set; }

    /// <summary>Specifies a list of quick connects ids that determine the quick connects available to agents who are working the queue.</summary>
    [JsonPropertyName("quickConnectIds")]
    public IList<string>? QuickConnectIds { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Specifies the description of the Queue. Valid values are ENABLED, DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderHoursOfOperationIdRefPolicy
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
/// <summary>Reference to a HoursOfOperation in connect to populate hoursOfOperationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderHoursOfOperationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2QueueSpecInitProviderHoursOfOperationIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderHoursOfOperationIdSelectorPolicy
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
/// <summary>Selector for a HoursOfOperation in connect to populate hoursOfOperationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderHoursOfOperationIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2QueueSpecInitProviderHoursOfOperationIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderInstanceIdRefPolicy
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
/// <summary>Reference to a Instance in connect to populate instanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderInstanceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2QueueSpecInitProviderInstanceIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderInstanceIdSelectorPolicy
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
/// <summary>Selector for a Instance in connect to populate instanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderInstanceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2QueueSpecInitProviderInstanceIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderOutboundCallerConfig
{
    /// <summary>Specifies the caller ID name.</summary>
    [JsonPropertyName("outboundCallerIdName")]
    public string? OutboundCallerIdName { get; set; }

    /// <summary>Specifies the caller ID number.</summary>
    [JsonPropertyName("outboundCallerIdNumberId")]
    public string? OutboundCallerIdNumberId { get; set; }

    /// <summary>Specifies outbound whisper flow to be used during an outbound call.</summary>
    [JsonPropertyName("outboundFlowId")]
    public string? OutboundFlowId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProvider
{
    /// <summary>Specifies the description of the Queue.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the identifier of the Hours of Operation.</summary>
    [JsonPropertyName("hoursOfOperationId")]
    public string? HoursOfOperationId { get; set; }

    /// <summary>Reference to a HoursOfOperation in connect to populate hoursOfOperationId.</summary>
    [JsonPropertyName("hoursOfOperationIdRef")]
    public V1beta2QueueSpecInitProviderHoursOfOperationIdRef? HoursOfOperationIdRef { get; set; }

    /// <summary>Selector for a HoursOfOperation in connect to populate hoursOfOperationId.</summary>
    [JsonPropertyName("hoursOfOperationIdSelector")]
    public V1beta2QueueSpecInitProviderHoursOfOperationIdSelector? HoursOfOperationIdSelector { get; set; }

    /// <summary>Specifies the identifier of the hosting Amazon Connect Instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>Reference to a Instance in connect to populate instanceId.</summary>
    [JsonPropertyName("instanceIdRef")]
    public V1beta2QueueSpecInitProviderInstanceIdRef? InstanceIdRef { get; set; }

    /// <summary>Selector for a Instance in connect to populate instanceId.</summary>
    [JsonPropertyName("instanceIdSelector")]
    public V1beta2QueueSpecInitProviderInstanceIdSelector? InstanceIdSelector { get; set; }

    /// <summary>Specifies the maximum number of contacts that can be in the queue before it is considered full. Minimum value of 0.</summary>
    [JsonPropertyName("maxContacts")]
    public double? MaxContacts { get; set; }

    /// <summary>Specifies the name of the Queue.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A block that defines the outbound caller ID name, number, and outbound whisper flow. The Outbound Caller Config block is documented below.</summary>
    [JsonPropertyName("outboundCallerConfig")]
    public IList<V1beta2QueueSpecInitProviderOutboundCallerConfig>? OutboundCallerConfig { get; set; }

    /// <summary>Specifies a list of quick connects ids that determine the quick connects available to agents who are working the queue.</summary>
    [JsonPropertyName("quickConnectIds")]
    public IList<string>? QuickConnectIds { get; set; }

    /// <summary>Specifies the description of the Queue. Valid values are ENABLED, DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecProviderConfigRefPolicy
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
public partial class V1beta2QueueSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2QueueSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecWriteConnectionSecretToRef
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
/// <summary>QueueSpec defines the desired state of Queue</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta2QueueSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta2QueueSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2QueueSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2QueueSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueStatusAtProviderOutboundCallerConfig
{
    /// <summary>Specifies the caller ID name.</summary>
    [JsonPropertyName("outboundCallerIdName")]
    public string? OutboundCallerIdName { get; set; }

    /// <summary>Specifies the caller ID number.</summary>
    [JsonPropertyName("outboundCallerIdNumberId")]
    public string? OutboundCallerIdNumberId { get; set; }

    /// <summary>Specifies outbound whisper flow to be used during an outbound call.</summary>
    [JsonPropertyName("outboundFlowId")]
    public string? OutboundFlowId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) of the Queue.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Specifies the description of the Queue.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the identifier of the Hours of Operation.</summary>
    [JsonPropertyName("hoursOfOperationId")]
    public string? HoursOfOperationId { get; set; }

    /// <summary>The identifier of the hosting Amazon Connect Instance and identifier of the Queue separated by a colon (:).</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the identifier of the hosting Amazon Connect Instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>Specifies the maximum number of contacts that can be in the queue before it is considered full. Minimum value of 0.</summary>
    [JsonPropertyName("maxContacts")]
    public double? MaxContacts { get; set; }

    /// <summary>Specifies the name of the Queue.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A block that defines the outbound caller ID name, number, and outbound whisper flow. The Outbound Caller Config block is documented below.</summary>
    [JsonPropertyName("outboundCallerConfig")]
    public IList<V1beta2QueueStatusAtProviderOutboundCallerConfig>? OutboundCallerConfig { get; set; }

    /// <summary>The identifier for the Queue.</summary>
    [JsonPropertyName("queueId")]
    public string? QueueId { get; set; }

    /// <summary>Specifies a list of quick connects ids that determine the quick connects available to agents who are working the queue.</summary>
    [JsonPropertyName("quickConnectIds")]
    public IList<string>? QuickConnectIds { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Specifies the description of the Queue. Valid values are ENABLED, DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueStatusConditions
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
/// <summary>QueueStatus defines the observed state of Queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta2QueueStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2QueueStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Queue is the Schema for the Queues API. Provides details about a specific Amazon Connect Queue</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Queue : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2QueueSpec>, IStatus<V1beta2QueueStatus>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Queue";
    public const string KubeGroup = "connect.aws.upbound.io";
    public const string KubePluralName = "queues";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>QueueSpec defines the desired state of Queue</summary>
    [JsonPropertyName("spec")]
    public V1beta2QueueSpec Spec { get; set; }

    /// <summary>QueueStatus defines the observed state of Queue.</summary>
    [JsonPropertyName("status")]
    public V1beta2QueueStatus? Status { get; set; }
}
#nullable disable
