using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventhub.azure.m.upbound.io;
#nullable enable
/// <summary>EventHub is the Schema for the EventHubs API. Manages a Event Hubs as a nested resource within an Event Hubs namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EventHubList : IKubernetesObject<V1ListMeta>, IItems<V1beta1EventHub>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EventHubList";
    public const string KubeGroup = "eventhub.azure.m.upbound.io";
    public const string KubePluralName = "eventhubs";
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
    public IList<V1beta1EventHub> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A destination block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpecForProviderCaptureDescriptionDestination
{
    /// <summary>The Blob naming convention for archiving. e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order</summary>
    [JsonPropertyName("archiveNameFormat")]
    public string? ArchiveNameFormat { get; set; }

    /// <summary>The name of the Container within the Blob Storage Account where messages should be archived.</summary>
    [JsonPropertyName("blobContainerName")]
    public string? BlobContainerName { get; set; }

    /// <summary>Specifies the name of the EventHub resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Blob Storage Account where messages should be archived.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A capture_description block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpecForProviderCaptureDescription
{
    /// <summary>A destination block as defined below.</summary>
    [JsonPropertyName("destination")]
    public V1beta1EventHubSpecForProviderCaptureDescriptionDestination? Destination { get; set; }

    /// <summary>Specifies if the Capture Description is Enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the Encoding used for the Capture Description. Possible values are Avro and AvroDeflate.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Specifies the time interval in seconds at which the capture will happen. Values can be between 60 and 900 seconds. Defaults to 300 seconds.</summary>
    [JsonPropertyName("intervalInSeconds")]
    public double? IntervalInSeconds { get; set; }

    /// <summary>Specifies the amount of data built up in your EventHub before a Capture Operation occurs. Value should be between 10485760 and 524288000 bytes. Defaults to 314572800 bytes.</summary>
    [JsonPropertyName("sizeLimitInBytes")]
    public double? SizeLimitInBytes { get; set; }

    /// <summary>Specifies if empty files should not be emitted if no events occur during the Capture time window. Defaults to false.</summary>
    [JsonPropertyName("skipEmptyArchives")]
    public bool? SkipEmptyArchives { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpecForProviderNamespaceIdRefPolicy
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
/// <summary>Reference to a EventHubNamespace in eventhub to populate namespaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpecForProviderNamespaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventHubSpecForProviderNamespaceIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpecForProviderNamespaceIdSelectorPolicy
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
/// <summary>Selector for a EventHubNamespace in eventhub to populate namespaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpecForProviderNamespaceIdSelector
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
    public V1beta1EventHubSpecForProviderNamespaceIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpecForProviderNamespaceNameRefPolicy
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
/// <summary>Reference to a EventHubNamespace in eventhub to populate namespaceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpecForProviderNamespaceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventHubSpecForProviderNamespaceNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpecForProviderNamespaceNameSelectorPolicy
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
/// <summary>Selector for a EventHubNamespace in eventhub to populate namespaceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpecForProviderNamespaceNameSelector
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
    public V1beta1EventHubSpecForProviderNamespaceNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1EventHubSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventHubSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1EventHubSpecForProviderResourceGroupNameSelector
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
    public V1beta1EventHubSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpecForProvider
{
    /// <summary>A capture_description block as defined below.</summary>
    [JsonPropertyName("captureDescription")]
    public V1beta1EventHubSpecForProviderCaptureDescription? CaptureDescription { get; set; }

    /// <summary>Specifies the number of days to retain the events for this Event Hub.</summary>
    [JsonPropertyName("messageRetention")]
    public double? MessageRetention { get; set; }

    /// <summary>Specifies the ID of the EventHub Namespace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary>Reference to a EventHubNamespace in eventhub to populate namespaceId.</summary>
    [JsonPropertyName("namespaceIdRef")]
    public V1beta1EventHubSpecForProviderNamespaceIdRef? NamespaceIdRef { get; set; }

    /// <summary>Selector for a EventHubNamespace in eventhub to populate namespaceId.</summary>
    [JsonPropertyName("namespaceIdSelector")]
    public V1beta1EventHubSpecForProviderNamespaceIdSelector? NamespaceIdSelector { get; set; }

    /// <summary>Specifies the name of the EventHub resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("namespaceName")]
    public string? NamespaceName { get; set; }

    /// <summary>Reference to a EventHubNamespace in eventhub to populate namespaceName.</summary>
    [JsonPropertyName("namespaceNameRef")]
    public V1beta1EventHubSpecForProviderNamespaceNameRef? NamespaceNameRef { get; set; }

    /// <summary>Selector for a EventHubNamespace in eventhub to populate namespaceName.</summary>
    [JsonPropertyName("namespaceNameSelector")]
    public V1beta1EventHubSpecForProviderNamespaceNameSelector? NamespaceNameSelector { get; set; }

    /// <summary>Specifies the current number of shards on the Event Hub.</summary>
    [JsonPropertyName("partitionCount")]
    public double? PartitionCount { get; set; }

    /// <summary>Specifies the name of the EventHub resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1EventHubSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1EventHubSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Specifies the status of the Event Hub resource. Possible values are Active, Disabled and SendDisabled. Defaults to Active.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A destination block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpecInitProviderCaptureDescriptionDestination
{
    /// <summary>The Blob naming convention for archiving. e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order</summary>
    [JsonPropertyName("archiveNameFormat")]
    public string? ArchiveNameFormat { get; set; }

    /// <summary>The name of the Container within the Blob Storage Account where messages should be archived.</summary>
    [JsonPropertyName("blobContainerName")]
    public string? BlobContainerName { get; set; }

    /// <summary>Specifies the name of the EventHub resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Blob Storage Account where messages should be archived.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A capture_description block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpecInitProviderCaptureDescription
{
    /// <summary>A destination block as defined below.</summary>
    [JsonPropertyName("destination")]
    public V1beta1EventHubSpecInitProviderCaptureDescriptionDestination? Destination { get; set; }

    /// <summary>Specifies if the Capture Description is Enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the Encoding used for the Capture Description. Possible values are Avro and AvroDeflate.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Specifies the time interval in seconds at which the capture will happen. Values can be between 60 and 900 seconds. Defaults to 300 seconds.</summary>
    [JsonPropertyName("intervalInSeconds")]
    public double? IntervalInSeconds { get; set; }

    /// <summary>Specifies the amount of data built up in your EventHub before a Capture Operation occurs. Value should be between 10485760 and 524288000 bytes. Defaults to 314572800 bytes.</summary>
    [JsonPropertyName("sizeLimitInBytes")]
    public double? SizeLimitInBytes { get; set; }

    /// <summary>Specifies if empty files should not be emitted if no events occur during the Capture time window. Defaults to false.</summary>
    [JsonPropertyName("skipEmptyArchives")]
    public bool? SkipEmptyArchives { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpecInitProviderNamespaceIdRefPolicy
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
/// <summary>Reference to a EventHubNamespace in eventhub to populate namespaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpecInitProviderNamespaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventHubSpecInitProviderNamespaceIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpecInitProviderNamespaceIdSelectorPolicy
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
/// <summary>Selector for a EventHubNamespace in eventhub to populate namespaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpecInitProviderNamespaceIdSelector
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
    public V1beta1EventHubSpecInitProviderNamespaceIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpecInitProvider
{
    /// <summary>A capture_description block as defined below.</summary>
    [JsonPropertyName("captureDescription")]
    public V1beta1EventHubSpecInitProviderCaptureDescription? CaptureDescription { get; set; }

    /// <summary>Specifies the number of days to retain the events for this Event Hub.</summary>
    [JsonPropertyName("messageRetention")]
    public double? MessageRetention { get; set; }

    /// <summary>Specifies the ID of the EventHub Namespace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary>Reference to a EventHubNamespace in eventhub to populate namespaceId.</summary>
    [JsonPropertyName("namespaceIdRef")]
    public V1beta1EventHubSpecInitProviderNamespaceIdRef? NamespaceIdRef { get; set; }

    /// <summary>Selector for a EventHubNamespace in eventhub to populate namespaceId.</summary>
    [JsonPropertyName("namespaceIdSelector")]
    public V1beta1EventHubSpecInitProviderNamespaceIdSelector? NamespaceIdSelector { get; set; }

    /// <summary>Specifies the current number of shards on the Event Hub.</summary>
    [JsonPropertyName("partitionCount")]
    public double? PartitionCount { get; set; }

    /// <summary>Specifies the status of the Event Hub resource. Possible values are Active, Disabled and SendDisabled. Defaults to Active.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpecProviderConfigRef
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
public partial class V1beta1EventHubSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>EventHubSpec defines the desired state of EventHub</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1EventHubSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1EventHubSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EventHubSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EventHubSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A destination block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubStatusAtProviderCaptureDescriptionDestination
{
    /// <summary>The Blob naming convention for archiving. e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order</summary>
    [JsonPropertyName("archiveNameFormat")]
    public string? ArchiveNameFormat { get; set; }

    /// <summary>The name of the Container within the Blob Storage Account where messages should be archived.</summary>
    [JsonPropertyName("blobContainerName")]
    public string? BlobContainerName { get; set; }

    /// <summary>Specifies the name of the EventHub resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Blob Storage Account where messages should be archived.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A capture_description block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubStatusAtProviderCaptureDescription
{
    /// <summary>A destination block as defined below.</summary>
    [JsonPropertyName("destination")]
    public V1beta1EventHubStatusAtProviderCaptureDescriptionDestination? Destination { get; set; }

    /// <summary>Specifies if the Capture Description is Enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the Encoding used for the Capture Description. Possible values are Avro and AvroDeflate.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Specifies the time interval in seconds at which the capture will happen. Values can be between 60 and 900 seconds. Defaults to 300 seconds.</summary>
    [JsonPropertyName("intervalInSeconds")]
    public double? IntervalInSeconds { get; set; }

    /// <summary>Specifies the amount of data built up in your EventHub before a Capture Operation occurs. Value should be between 10485760 and 524288000 bytes. Defaults to 314572800 bytes.</summary>
    [JsonPropertyName("sizeLimitInBytes")]
    public double? SizeLimitInBytes { get; set; }

    /// <summary>Specifies if empty files should not be emitted if no events occur during the Capture time window. Defaults to false.</summary>
    [JsonPropertyName("skipEmptyArchives")]
    public bool? SkipEmptyArchives { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubStatusAtProvider
{
    /// <summary>A capture_description block as defined below.</summary>
    [JsonPropertyName("captureDescription")]
    public V1beta1EventHubStatusAtProviderCaptureDescription? CaptureDescription { get; set; }

    /// <summary>The ID of the EventHub.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the number of days to retain the events for this Event Hub.</summary>
    [JsonPropertyName("messageRetention")]
    public double? MessageRetention { get; set; }

    /// <summary>Specifies the ID of the EventHub Namespace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary>Specifies the name of the EventHub resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("namespaceName")]
    public string? NamespaceName { get; set; }

    /// <summary>Specifies the current number of shards on the Event Hub.</summary>
    [JsonPropertyName("partitionCount")]
    public double? PartitionCount { get; set; }

    /// <summary>The identifiers for partitions created for Event Hubs.</summary>
    [JsonPropertyName("partitionIds")]
    public IList<string>? PartitionIds { get; set; }

    /// <summary>Specifies the name of the EventHub resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Specifies the status of the Event Hub resource. Possible values are Active, Disabled and SendDisabled. Defaults to Active.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubStatusConditions
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
/// <summary>EventHubStatus defines the observed state of EventHub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventHubStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1EventHubStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EventHubStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>EventHub is the Schema for the EventHubs API. Manages a Event Hubs as a nested resource within an Event Hubs namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EventHub : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EventHubSpec>, IStatus<V1beta1EventHubStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EventHub";
    public const string KubeGroup = "eventhub.azure.m.upbound.io";
    public const string KubePluralName = "eventhubs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EventHubSpec defines the desired state of EventHub</summary>
    [JsonPropertyName("spec")]
    public V1beta1EventHubSpec Spec { get; set; }

    /// <summary>EventHubStatus defines the observed state of EventHub.</summary>
    [JsonPropertyName("status")]
    public V1beta1EventHubStatus? Status { get; set; }
}
#nullable disable
