using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventhub.azure.com;
/// <summary>StorageAccountResourceReference: Resource id of the storage account to be used to create the blobs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageNamespacesEventhubSpecCaptureDescriptionDestinationStorageAccountResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20211101.Destination Capture storage details for capture description</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageNamespacesEventhubSpecCaptureDescriptionDestination
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("archiveNameFormat")]
    public string? ArchiveNameFormat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("blobContainer")]
    public string? BlobContainer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataLakeAccountName")]
    public string? DataLakeAccountName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataLakeFolderPath")]
    public string? DataLakeFolderPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataLakeSubscriptionId")]
    public string? DataLakeSubscriptionId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>StorageAccountResourceReference: Resource id of the storage account to be used to create the blobs</summary>
    [JsonPropertyName("storageAccountResourceReference")]
    public V1api20211101storageNamespacesEventhubSpecCaptureDescriptionDestinationStorageAccountResourceReference? StorageAccountResourceReference { get; set; }
}

/// <summary>Storage version of v1api20211101.CaptureDescription Properties to configure capture description for eventhub</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageNamespacesEventhubSpecCaptureDescription
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20211101.Destination Capture storage details for capture description</summary>
    [JsonPropertyName("destination")]
    public V1api20211101storageNamespacesEventhubSpecCaptureDescriptionDestination? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary></summary>
    [JsonPropertyName("intervalInSeconds")]
    public int? IntervalInSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sizeLimitInBytes")]
    public int? SizeLimitInBytes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipEmptyArchives")]
    public bool? SkipEmptyArchives { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a eventhub.azure.com/Namespace resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageNamespacesEventhubSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20211101.Namespaces_Eventhub_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageNamespacesEventhubSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20211101.CaptureDescription Properties to configure capture description for eventhub</summary>
    [JsonPropertyName("captureDescription")]
    public V1api20211101storageNamespacesEventhubSpecCaptureDescription? CaptureDescription { get; set; }

    /// <summary></summary>
    [JsonPropertyName("messageRetentionInDays")]
    public int? MessageRetentionInDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a eventhub.azure.com/Namespace resource</summary>
    [JsonPropertyName("owner")]
    public V1api20211101storageNamespacesEventhubSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("partitionCount")]
    public int? PartitionCount { get; set; }
}

/// <summary>Storage version of v1api20211101.Destination_STATUS Capture storage details for capture description</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageNamespacesEventhubStatusCaptureDescriptionDestination
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("archiveNameFormat")]
    public string? ArchiveNameFormat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("blobContainer")]
    public string? BlobContainer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataLakeAccountName")]
    public string? DataLakeAccountName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataLakeFolderPath")]
    public string? DataLakeFolderPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataLakeSubscriptionId")]
    public string? DataLakeSubscriptionId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountResourceId")]
    public string? StorageAccountResourceId { get; set; }
}

/// <summary>Storage version of v1api20211101.CaptureDescription_STATUS Properties to configure capture description for eventhub</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageNamespacesEventhubStatusCaptureDescription
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20211101.Destination_STATUS Capture storage details for capture description</summary>
    [JsonPropertyName("destination")]
    public V1api20211101storageNamespacesEventhubStatusCaptureDescriptionDestination? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary></summary>
    [JsonPropertyName("intervalInSeconds")]
    public int? IntervalInSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sizeLimitInBytes")]
    public int? SizeLimitInBytes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipEmptyArchives")]
    public bool? SkipEmptyArchives { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageNamespacesEventhubStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason for the condition's last transition. Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False. This is omitted in all cases when Status == Unknown</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Storage version of v1api20211101.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageNamespacesEventhubStatusSystemData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Storage version of v1api20211101.Namespaces_Eventhub_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageNamespacesEventhubStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20211101.CaptureDescription_STATUS Properties to configure capture description for eventhub</summary>
    [JsonPropertyName("captureDescription")]
    public V1api20211101storageNamespacesEventhubStatusCaptureDescription? CaptureDescription { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20211101storageNamespacesEventhubStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("messageRetentionInDays")]
    public int? MessageRetentionInDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("partitionCount")]
    public int? PartitionCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("partitionIds")]
    public IList<string>? PartitionIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Storage version of v1api20211101.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20211101storageNamespacesEventhubStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}

/// <summary>Storage version of v1api20211101.NamespacesEventhub Generator information: - Generated from: /eventhub/resource-manager/Microsoft.EventHub/stable/2021-11-01/eventhubs.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211101storageNamespacesEventhub : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20211101storageNamespacesEventhubSpec>, IStatus<V1api20211101storageNamespacesEventhubStatus>
{
    public const string KubeApiVersion = "v1api20211101storage";
    public const string KubeKind = "NamespacesEventhub";
    public const string KubeGroup = "eventhub.azure.com";
    public const string KubePluralName = "namespaceseventhubs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20211101.Namespaces_Eventhub_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20211101storageNamespacesEventhubSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20211101.Namespaces_Eventhub_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20211101storageNamespacesEventhubStatus? Status { get; set; }
}