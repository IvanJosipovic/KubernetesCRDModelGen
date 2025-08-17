using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.streamanalytics.azure.m.upbound.io;
#nullable enable
/// <summary>OutputServiceBusQueue is the Schema for the OutputServiceBusQueues API. Manages a Stream Analytics Output to a ServiceBus Queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OutputServiceBusQueueList : IKubernetesObject<V1ListMeta>, IItems<V1beta1OutputServiceBusQueue>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OutputServiceBusQueueList";
    public const string KubeGroup = "streamanalytics.azure.m.upbound.io";
    public const string KubePluralName = "outputservicebusqueues";
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
    public IList<V1beta1OutputServiceBusQueue> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecForProviderQueueNameRefPolicy
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
/// <summary>Reference to a Queue in servicebus to populate queueName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecForProviderQueueNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusQueueSpecForProviderQueueNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecForProviderQueueNameSelectorPolicy
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
/// <summary>Selector for a Queue in servicebus to populate queueName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecForProviderQueueNameSelector
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
    public V1beta1OutputServiceBusQueueSpecForProviderQueueNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecForProviderResourceGroupNameRefPolicy
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
/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusQueueSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecForProviderResourceGroupNameSelectorPolicy
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
/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecForProviderResourceGroupNameSelector
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
    public V1beta1OutputServiceBusQueueSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A serialization block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecForProviderSerialization
{
    /// <summary>The encoding of the incoming data in the case of input and the encoding of outgoing data in the case of output. It currently can only be set to UTF8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The delimiter that will be used to separate comma-separated value (CSV) records. Possible values are   (space), , (comma), 	 (tab), | (pipe) and ;.</summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>Specifies the format of the JSON the output will be written in. Possible values are Array and LineSeparated.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The serialization format used for outgoing data streams. Possible values are Avro, Csv, Json and Parquet.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecForProviderServicebusNamespaceRefPolicy
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
/// <summary>Reference to a ServiceBusNamespace in servicebus to populate servicebusNamespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecForProviderServicebusNamespaceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusQueueSpecForProviderServicebusNamespaceRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecForProviderServicebusNamespaceSelectorPolicy
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
/// <summary>Selector for a ServiceBusNamespace in servicebus to populate servicebusNamespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecForProviderServicebusNamespaceSelector
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
    public V1beta1OutputServiceBusQueueSpecForProviderServicebusNamespaceSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The shared access policy key for the specified shared access policy. Required if authentication_mode is ConnectionString.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecForProviderSharedAccessPolicyKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecForProviderStreamAnalyticsJobNameRefPolicy
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
/// <summary>Reference to a Job in streamanalytics to populate streamAnalyticsJobName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecForProviderStreamAnalyticsJobNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusQueueSpecForProviderStreamAnalyticsJobNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecForProviderStreamAnalyticsJobNameSelectorPolicy
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
/// <summary>Selector for a Job in streamanalytics to populate streamAnalyticsJobName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecForProviderStreamAnalyticsJobNameSelector
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
    public V1beta1OutputServiceBusQueueSpecForProviderStreamAnalyticsJobNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecForProvider
{
    /// <summary>The authentication mode for the Stream Output. Possible values are Msi and ConnectionString. Defaults to ConnectionString.</summary>
    [JsonPropertyName("authenticationMode")]
    public string? AuthenticationMode { get; set; }

    /// <summary>The name of the Stream Output. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of property columns to add to the Service Bus Queue output.</summary>
    [JsonPropertyName("propertyColumns")]
    public IList<string>? PropertyColumns { get; set; }

    /// <summary>The name of the Service Bus Queue.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    /// <summary>Reference to a Queue in servicebus to populate queueName.</summary>
    [JsonPropertyName("queueNameRef")]
    public V1beta1OutputServiceBusQueueSpecForProviderQueueNameRef? QueueNameRef { get; set; }

    /// <summary>Selector for a Queue in servicebus to populate queueName.</summary>
    [JsonPropertyName("queueNameSelector")]
    public V1beta1OutputServiceBusQueueSpecForProviderQueueNameSelector? QueueNameSelector { get; set; }

    /// <summary>The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1OutputServiceBusQueueSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1OutputServiceBusQueueSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A serialization block as defined below.</summary>
    [JsonPropertyName("serialization")]
    public V1beta1OutputServiceBusQueueSpecForProviderSerialization? Serialization { get; set; }

    /// <summary>The namespace that is associated with the desired Event Hub, Service Bus Queue, Service Bus Topic, etc.</summary>
    [JsonPropertyName("servicebusNamespace")]
    public string? ServicebusNamespace { get; set; }

    /// <summary>Reference to a ServiceBusNamespace in servicebus to populate servicebusNamespace.</summary>
    [JsonPropertyName("servicebusNamespaceRef")]
    public V1beta1OutputServiceBusQueueSpecForProviderServicebusNamespaceRef? ServicebusNamespaceRef { get; set; }

    /// <summary>Selector for a ServiceBusNamespace in servicebus to populate servicebusNamespace.</summary>
    [JsonPropertyName("servicebusNamespaceSelector")]
    public V1beta1OutputServiceBusQueueSpecForProviderServicebusNamespaceSelector? ServicebusNamespaceSelector { get; set; }

    /// <summary>The shared access policy key for the specified shared access policy. Required if authentication_mode is ConnectionString.</summary>
    [JsonPropertyName("sharedAccessPolicyKeySecretRef")]
    public V1beta1OutputServiceBusQueueSpecForProviderSharedAccessPolicyKeySecretRef? SharedAccessPolicyKeySecretRef { get; set; }

    /// <summary>The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc. Required if authentication_mode is ConnectionString.</summary>
    [JsonPropertyName("sharedAccessPolicyName")]
    public string? SharedAccessPolicyName { get; set; }

    /// <summary>The name of the Stream Analytics Job. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("streamAnalyticsJobName")]
    public string? StreamAnalyticsJobName { get; set; }

    /// <summary>Reference to a Job in streamanalytics to populate streamAnalyticsJobName.</summary>
    [JsonPropertyName("streamAnalyticsJobNameRef")]
    public V1beta1OutputServiceBusQueueSpecForProviderStreamAnalyticsJobNameRef? StreamAnalyticsJobNameRef { get; set; }

    /// <summary>Selector for a Job in streamanalytics to populate streamAnalyticsJobName.</summary>
    [JsonPropertyName("streamAnalyticsJobNameSelector")]
    public V1beta1OutputServiceBusQueueSpecForProviderStreamAnalyticsJobNameSelector? StreamAnalyticsJobNameSelector { get; set; }

    /// <summary>A key-value pair of system property columns that will be attached to the outgoing messages for the Service Bus Queue Output.</summary>
    [JsonPropertyName("systemPropertyColumns")]
    public IDictionary<string, string>? SystemPropertyColumns { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecInitProviderQueueNameRefPolicy
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
/// <summary>Reference to a Queue in servicebus to populate queueName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecInitProviderQueueNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusQueueSpecInitProviderQueueNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecInitProviderQueueNameSelectorPolicy
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
/// <summary>Selector for a Queue in servicebus to populate queueName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecInitProviderQueueNameSelector
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
    public V1beta1OutputServiceBusQueueSpecInitProviderQueueNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecInitProviderResourceGroupNameRefPolicy
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
/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecInitProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusQueueSpecInitProviderResourceGroupNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecInitProviderResourceGroupNameSelectorPolicy
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
/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecInitProviderResourceGroupNameSelector
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
    public V1beta1OutputServiceBusQueueSpecInitProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A serialization block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecInitProviderSerialization
{
    /// <summary>The encoding of the incoming data in the case of input and the encoding of outgoing data in the case of output. It currently can only be set to UTF8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The delimiter that will be used to separate comma-separated value (CSV) records. Possible values are   (space), , (comma), 	 (tab), | (pipe) and ;.</summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>Specifies the format of the JSON the output will be written in. Possible values are Array and LineSeparated.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The serialization format used for outgoing data streams. Possible values are Avro, Csv, Json and Parquet.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecInitProviderServicebusNamespaceRefPolicy
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
/// <summary>Reference to a ServiceBusNamespace in servicebus to populate servicebusNamespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecInitProviderServicebusNamespaceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusQueueSpecInitProviderServicebusNamespaceRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecInitProviderServicebusNamespaceSelectorPolicy
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
/// <summary>Selector for a ServiceBusNamespace in servicebus to populate servicebusNamespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecInitProviderServicebusNamespaceSelector
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
    public V1beta1OutputServiceBusQueueSpecInitProviderServicebusNamespaceSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The shared access policy key for the specified shared access policy. Required if authentication_mode is ConnectionString.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecInitProviderSharedAccessPolicyKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecInitProviderStreamAnalyticsJobNameRefPolicy
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
/// <summary>Reference to a Job in streamanalytics to populate streamAnalyticsJobName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecInitProviderStreamAnalyticsJobNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusQueueSpecInitProviderStreamAnalyticsJobNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecInitProviderStreamAnalyticsJobNameSelectorPolicy
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
/// <summary>Selector for a Job in streamanalytics to populate streamAnalyticsJobName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecInitProviderStreamAnalyticsJobNameSelector
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
    public V1beta1OutputServiceBusQueueSpecInitProviderStreamAnalyticsJobNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecInitProvider
{
    /// <summary>The authentication mode for the Stream Output. Possible values are Msi and ConnectionString. Defaults to ConnectionString.</summary>
    [JsonPropertyName("authenticationMode")]
    public string? AuthenticationMode { get; set; }

    /// <summary>The name of the Stream Output. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of property columns to add to the Service Bus Queue output.</summary>
    [JsonPropertyName("propertyColumns")]
    public IList<string>? PropertyColumns { get; set; }

    /// <summary>The name of the Service Bus Queue.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    /// <summary>Reference to a Queue in servicebus to populate queueName.</summary>
    [JsonPropertyName("queueNameRef")]
    public V1beta1OutputServiceBusQueueSpecInitProviderQueueNameRef? QueueNameRef { get; set; }

    /// <summary>Selector for a Queue in servicebus to populate queueName.</summary>
    [JsonPropertyName("queueNameSelector")]
    public V1beta1OutputServiceBusQueueSpecInitProviderQueueNameSelector? QueueNameSelector { get; set; }

    /// <summary>The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1OutputServiceBusQueueSpecInitProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1OutputServiceBusQueueSpecInitProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A serialization block as defined below.</summary>
    [JsonPropertyName("serialization")]
    public V1beta1OutputServiceBusQueueSpecInitProviderSerialization? Serialization { get; set; }

    /// <summary>The namespace that is associated with the desired Event Hub, Service Bus Queue, Service Bus Topic, etc.</summary>
    [JsonPropertyName("servicebusNamespace")]
    public string? ServicebusNamespace { get; set; }

    /// <summary>Reference to a ServiceBusNamespace in servicebus to populate servicebusNamespace.</summary>
    [JsonPropertyName("servicebusNamespaceRef")]
    public V1beta1OutputServiceBusQueueSpecInitProviderServicebusNamespaceRef? ServicebusNamespaceRef { get; set; }

    /// <summary>Selector for a ServiceBusNamespace in servicebus to populate servicebusNamespace.</summary>
    [JsonPropertyName("servicebusNamespaceSelector")]
    public V1beta1OutputServiceBusQueueSpecInitProviderServicebusNamespaceSelector? ServicebusNamespaceSelector { get; set; }

    /// <summary>The shared access policy key for the specified shared access policy. Required if authentication_mode is ConnectionString.</summary>
    [JsonPropertyName("sharedAccessPolicyKeySecretRef")]
    public V1beta1OutputServiceBusQueueSpecInitProviderSharedAccessPolicyKeySecretRef? SharedAccessPolicyKeySecretRef { get; set; }

    /// <summary>The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc. Required if authentication_mode is ConnectionString.</summary>
    [JsonPropertyName("sharedAccessPolicyName")]
    public string? SharedAccessPolicyName { get; set; }

    /// <summary>The name of the Stream Analytics Job. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("streamAnalyticsJobName")]
    public string? StreamAnalyticsJobName { get; set; }

    /// <summary>Reference to a Job in streamanalytics to populate streamAnalyticsJobName.</summary>
    [JsonPropertyName("streamAnalyticsJobNameRef")]
    public V1beta1OutputServiceBusQueueSpecInitProviderStreamAnalyticsJobNameRef? StreamAnalyticsJobNameRef { get; set; }

    /// <summary>Selector for a Job in streamanalytics to populate streamAnalyticsJobName.</summary>
    [JsonPropertyName("streamAnalyticsJobNameSelector")]
    public V1beta1OutputServiceBusQueueSpecInitProviderStreamAnalyticsJobNameSelector? StreamAnalyticsJobNameSelector { get; set; }

    /// <summary>A key-value pair of system property columns that will be attached to the outgoing messages for the Service Bus Queue Output.</summary>
    [JsonPropertyName("systemPropertyColumns")]
    public IDictionary<string, string>? SystemPropertyColumns { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpecProviderConfigRef
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
public partial class V1beta1OutputServiceBusQueueSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>OutputServiceBusQueueSpec defines the desired state of OutputServiceBusQueue</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1OutputServiceBusQueueSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1OutputServiceBusQueueSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1OutputServiceBusQueueSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1OutputServiceBusQueueSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A serialization block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueStatusAtProviderSerialization
{
    /// <summary>The encoding of the incoming data in the case of input and the encoding of outgoing data in the case of output. It currently can only be set to UTF8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The delimiter that will be used to separate comma-separated value (CSV) records. Possible values are   (space), , (comma), 	 (tab), | (pipe) and ;.</summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>Specifies the format of the JSON the output will be written in. Possible values are Array and LineSeparated.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The serialization format used for outgoing data streams. Possible values are Avro, Csv, Json and Parquet.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueStatusAtProvider
{
    /// <summary>The authentication mode for the Stream Output. Possible values are Msi and ConnectionString. Defaults to ConnectionString.</summary>
    [JsonPropertyName("authenticationMode")]
    public string? AuthenticationMode { get; set; }

    /// <summary>The ID of the Stream Analytics Output ServiceBus Queue.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the Stream Output. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of property columns to add to the Service Bus Queue output.</summary>
    [JsonPropertyName("propertyColumns")]
    public IList<string>? PropertyColumns { get; set; }

    /// <summary>The name of the Service Bus Queue.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    /// <summary>The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A serialization block as defined below.</summary>
    [JsonPropertyName("serialization")]
    public V1beta1OutputServiceBusQueueStatusAtProviderSerialization? Serialization { get; set; }

    /// <summary>The namespace that is associated with the desired Event Hub, Service Bus Queue, Service Bus Topic, etc.</summary>
    [JsonPropertyName("servicebusNamespace")]
    public string? ServicebusNamespace { get; set; }

    /// <summary>The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc. Required if authentication_mode is ConnectionString.</summary>
    [JsonPropertyName("sharedAccessPolicyName")]
    public string? SharedAccessPolicyName { get; set; }

    /// <summary>The name of the Stream Analytics Job. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("streamAnalyticsJobName")]
    public string? StreamAnalyticsJobName { get; set; }

    /// <summary>A key-value pair of system property columns that will be attached to the outgoing messages for the Service Bus Queue Output.</summary>
    [JsonPropertyName("systemPropertyColumns")]
    public IDictionary<string, string>? SystemPropertyColumns { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueStatusConditions
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
/// <summary>OutputServiceBusQueueStatus defines the observed state of OutputServiceBusQueue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OutputServiceBusQueueStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1OutputServiceBusQueueStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1OutputServiceBusQueueStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>OutputServiceBusQueue is the Schema for the OutputServiceBusQueues API. Manages a Stream Analytics Output to a ServiceBus Queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OutputServiceBusQueue : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1OutputServiceBusQueueSpec>, IStatus<V1beta1OutputServiceBusQueueStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OutputServiceBusQueue";
    public const string KubeGroup = "streamanalytics.azure.m.upbound.io";
    public const string KubePluralName = "outputservicebusqueues";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OutputServiceBusQueueSpec defines the desired state of OutputServiceBusQueue</summary>
    [JsonPropertyName("spec")]
    public V1beta1OutputServiceBusQueueSpec Spec { get; set; }

    /// <summary>OutputServiceBusQueueStatus defines the observed state of OutputServiceBusQueue.</summary>
    [JsonPropertyName("status")]
    public V1beta1OutputServiceBusQueueStatus? Status { get; set; }
}
#nullable disable
