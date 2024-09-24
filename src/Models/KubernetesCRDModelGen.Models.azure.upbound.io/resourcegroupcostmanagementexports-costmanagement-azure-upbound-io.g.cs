using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.costmanagement.azure.upbound.io;
public enum V1beta1ResourceGroupCostManagementExportSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataOptions
{
    /// <summary>The time frame for pulling data for the query. If custom, then a specific time period must be provided. Possible values include: WeekToDate, MonthToDate, BillingMonthToDate, TheLast7Days, TheLastMonth, TheLastBillingMonth, Custom.</summary>
    [JsonPropertyName("timeFrame")]
    public string? TimeFrame { get; set; }

    /// <summary>The type of the query. Possible values are ActualCost, AmortizedCost and Usage.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicyResolutionEnum>))]
    public V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicyResolveEnum>))]
    public V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Container in storage to populate containerId.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicyResolutionEnum>))]
    public V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicyResolveEnum>))]
    public V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Container in storage to populate containerId.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocation
{
    /// <summary>The Resource Manager ID of the container where exports will be uploaded. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("containerId")]
    public string? ContainerId { get; set; }

    /// <summary>Reference to a Container in storage to populate containerId.</summary>
    [JsonPropertyName("containerIdRef")]
    public V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRef? ContainerIdRef { get; set; }

    /// <summary>Selector for a Container in storage to populate containerId.</summary>
    [JsonPropertyName("containerIdSelector")]
    public V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelector? ContainerIdSelector { get; set; }

    /// <summary>The path of the directory where exports will be uploaded. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("rootFolderPath")]
    public string? RootFolderPath { get; set; }
}

public enum V1beta1ResourceGroupCostManagementExportSpecForProviderResourceGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ResourceGroupCostManagementExportSpecForProviderResourceGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecForProviderResourceGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceGroupCostManagementExportSpecForProviderResourceGroupIdRefPolicyResolutionEnum>))]
    public V1beta1ResourceGroupCostManagementExportSpecForProviderResourceGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceGroupCostManagementExportSpecForProviderResourceGroupIdRefPolicyResolveEnum>))]
    public V1beta1ResourceGroupCostManagementExportSpecForProviderResourceGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupId.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecForProviderResourceGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourceGroupCostManagementExportSpecForProviderResourceGroupIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ResourceGroupCostManagementExportSpecForProviderResourceGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ResourceGroupCostManagementExportSpecForProviderResourceGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecForProviderResourceGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceGroupCostManagementExportSpecForProviderResourceGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1ResourceGroupCostManagementExportSpecForProviderResourceGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceGroupCostManagementExportSpecForProviderResourceGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1ResourceGroupCostManagementExportSpecForProviderResourceGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupId.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecForProviderResourceGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourceGroupCostManagementExportSpecForProviderResourceGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecForProvider
{
    /// <summary>Is the cost management export active? Default is true.</summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>A export_data_options block as defined below.</summary>
    [JsonPropertyName("exportDataOptions")]
    public IList<V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataOptions>? ExportDataOptions { get; set; }

    /// <summary>A export_data_storage_location block as defined below.</summary>
    [JsonPropertyName("exportDataStorageLocation")]
    public IList<V1beta1ResourceGroupCostManagementExportSpecForProviderExportDataStorageLocation>? ExportDataStorageLocation { get; set; }

    /// <summary>The date the export will stop capturing information.</summary>
    [JsonPropertyName("recurrencePeriodEndDate")]
    public string? RecurrencePeriodEndDate { get; set; }

    /// <summary>The date the export will start capturing information.</summary>
    [JsonPropertyName("recurrencePeriodStartDate")]
    public string? RecurrencePeriodStartDate { get; set; }

    /// <summary>How often the requested information will be exported. Valid values include Annually, Daily, Monthly, Weekly.</summary>
    [JsonPropertyName("recurrenceType")]
    public string? RecurrenceType { get; set; }

    /// <summary>The id of the resource group on which to create an export. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupId.</summary>
    [JsonPropertyName("resourceGroupIdRef")]
    public V1beta1ResourceGroupCostManagementExportSpecForProviderResourceGroupIdRef? ResourceGroupIdRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupId.</summary>
    [JsonPropertyName("resourceGroupIdSelector")]
    public V1beta1ResourceGroupCostManagementExportSpecForProviderResourceGroupIdSelector? ResourceGroupIdSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataOptions
{
    /// <summary>The time frame for pulling data for the query. If custom, then a specific time period must be provided. Possible values include: WeekToDate, MonthToDate, BillingMonthToDate, TheLast7Days, TheLastMonth, TheLastBillingMonth, Custom.</summary>
    [JsonPropertyName("timeFrame")]
    public string? TimeFrame { get; set; }

    /// <summary>The type of the query. Possible values are ActualCost, AmortizedCost and Usage.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicyResolutionEnum>))]
    public V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicyResolveEnum>))]
    public V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Container in storage to populate containerId.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicyResolutionEnum>))]
    public V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicyResolveEnum>))]
    public V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Container in storage to populate containerId.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocation
{
    /// <summary>The Resource Manager ID of the container where exports will be uploaded. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("containerId")]
    public string? ContainerId { get; set; }

    /// <summary>Reference to a Container in storage to populate containerId.</summary>
    [JsonPropertyName("containerIdRef")]
    public V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRef? ContainerIdRef { get; set; }

    /// <summary>Selector for a Container in storage to populate containerId.</summary>
    [JsonPropertyName("containerIdSelector")]
    public V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelector? ContainerIdSelector { get; set; }

    /// <summary>The path of the directory where exports will be uploaded. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("rootFolderPath")]
    public string? RootFolderPath { get; set; }
}

public enum V1beta1ResourceGroupCostManagementExportSpecInitProviderResourceGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ResourceGroupCostManagementExportSpecInitProviderResourceGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecInitProviderResourceGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceGroupCostManagementExportSpecInitProviderResourceGroupIdRefPolicyResolutionEnum>))]
    public V1beta1ResourceGroupCostManagementExportSpecInitProviderResourceGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceGroupCostManagementExportSpecInitProviderResourceGroupIdRefPolicyResolveEnum>))]
    public V1beta1ResourceGroupCostManagementExportSpecInitProviderResourceGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupId.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecInitProviderResourceGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourceGroupCostManagementExportSpecInitProviderResourceGroupIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ResourceGroupCostManagementExportSpecInitProviderResourceGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ResourceGroupCostManagementExportSpecInitProviderResourceGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecInitProviderResourceGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceGroupCostManagementExportSpecInitProviderResourceGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1ResourceGroupCostManagementExportSpecInitProviderResourceGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceGroupCostManagementExportSpecInitProviderResourceGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1ResourceGroupCostManagementExportSpecInitProviderResourceGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupId.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecInitProviderResourceGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourceGroupCostManagementExportSpecInitProviderResourceGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecInitProvider
{
    /// <summary>Is the cost management export active? Default is true.</summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>A export_data_options block as defined below.</summary>
    [JsonPropertyName("exportDataOptions")]
    public IList<V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataOptions>? ExportDataOptions { get; set; }

    /// <summary>A export_data_storage_location block as defined below.</summary>
    [JsonPropertyName("exportDataStorageLocation")]
    public IList<V1beta1ResourceGroupCostManagementExportSpecInitProviderExportDataStorageLocation>? ExportDataStorageLocation { get; set; }

    /// <summary>The date the export will stop capturing information.</summary>
    [JsonPropertyName("recurrencePeriodEndDate")]
    public string? RecurrencePeriodEndDate { get; set; }

    /// <summary>The date the export will start capturing information.</summary>
    [JsonPropertyName("recurrencePeriodStartDate")]
    public string? RecurrencePeriodStartDate { get; set; }

    /// <summary>How often the requested information will be exported. Valid values include Annually, Daily, Monthly, Weekly.</summary>
    [JsonPropertyName("recurrenceType")]
    public string? RecurrenceType { get; set; }

    /// <summary>The id of the resource group on which to create an export. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupId.</summary>
    [JsonPropertyName("resourceGroupIdRef")]
    public V1beta1ResourceGroupCostManagementExportSpecInitProviderResourceGroupIdRef? ResourceGroupIdRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupId.</summary>
    [JsonPropertyName("resourceGroupIdSelector")]
    public V1beta1ResourceGroupCostManagementExportSpecInitProviderResourceGroupIdSelector? ResourceGroupIdSelector { get; set; }
}

public enum V1beta1ResourceGroupCostManagementExportSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

public enum V1beta1ResourceGroupCostManagementExportSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ResourceGroupCostManagementExportSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceGroupCostManagementExportSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ResourceGroupCostManagementExportSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceGroupCostManagementExportSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ResourceGroupCostManagementExportSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourceGroupCostManagementExportSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1ResourceGroupCostManagementExportSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ResourceGroupCostManagementExportSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceGroupCostManagementExportSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ResourceGroupCostManagementExportSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceGroupCostManagementExportSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ResourceGroupCostManagementExportSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourceGroupCostManagementExportSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ResourceGroupCostManagementExportSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ResourceGroupCostManagementExportSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ResourceGroupCostManagementExportSpec defines the desired state of ResourceGroupCostManagementExport</summary>
public partial class V1beta1ResourceGroupCostManagementExportSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceGroupCostManagementExportSpecDeletionPolicyEnum>))]
    public V1beta1ResourceGroupCostManagementExportSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ResourceGroupCostManagementExportSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ResourceGroupCostManagementExportSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ResourceGroupCostManagementExportSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ResourceGroupCostManagementExportSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ResourceGroupCostManagementExportSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ResourceGroupCostManagementExportSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1ResourceGroupCostManagementExportStatusAtProviderExportDataOptions
{
    /// <summary>The time frame for pulling data for the query. If custom, then a specific time period must be provided. Possible values include: WeekToDate, MonthToDate, BillingMonthToDate, TheLast7Days, TheLastMonth, TheLastBillingMonth, Custom.</summary>
    [JsonPropertyName("timeFrame")]
    public string? TimeFrame { get; set; }

    /// <summary>The type of the query. Possible values are ActualCost, AmortizedCost and Usage.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ResourceGroupCostManagementExportStatusAtProviderExportDataStorageLocation
{
    /// <summary>The Resource Manager ID of the container where exports will be uploaded. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("containerId")]
    public string? ContainerId { get; set; }

    /// <summary>The path of the directory where exports will be uploaded. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("rootFolderPath")]
    public string? RootFolderPath { get; set; }
}

/// <summary></summary>
public partial class V1beta1ResourceGroupCostManagementExportStatusAtProvider
{
    /// <summary>Is the cost management export active? Default is true.</summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>A export_data_options block as defined below.</summary>
    [JsonPropertyName("exportDataOptions")]
    public IList<V1beta1ResourceGroupCostManagementExportStatusAtProviderExportDataOptions>? ExportDataOptions { get; set; }

    /// <summary>A export_data_storage_location block as defined below.</summary>
    [JsonPropertyName("exportDataStorageLocation")]
    public IList<V1beta1ResourceGroupCostManagementExportStatusAtProviderExportDataStorageLocation>? ExportDataStorageLocation { get; set; }

    /// <summary>The ID of the Cost Management Export for this Resource Group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The date the export will stop capturing information.</summary>
    [JsonPropertyName("recurrencePeriodEndDate")]
    public string? RecurrencePeriodEndDate { get; set; }

    /// <summary>The date the export will start capturing information.</summary>
    [JsonPropertyName("recurrencePeriodStartDate")]
    public string? RecurrencePeriodStartDate { get; set; }

    /// <summary>How often the requested information will be exported. Valid values include Annually, Daily, Monthly, Weekly.</summary>
    [JsonPropertyName("recurrenceType")]
    public string? RecurrenceType { get; set; }

    /// <summary>The id of the resource group on which to create an export. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1ResourceGroupCostManagementExportStatusConditions
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

/// <summary>ResourceGroupCostManagementExportStatus defines the observed state of ResourceGroupCostManagementExport.</summary>
public partial class V1beta1ResourceGroupCostManagementExportStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ResourceGroupCostManagementExportStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ResourceGroupCostManagementExportStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>ResourceGroupCostManagementExport is the Schema for the ResourceGroupCostManagementExports API. Manages an Azure Cost Management Export for a Resource Group.</summary>
public partial class V1beta1ResourceGroupCostManagementExport : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ResourceGroupCostManagementExportSpec>, IStatus<V1beta1ResourceGroupCostManagementExportStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ResourceGroupCostManagementExport";
    public const string KubeGroup = "costmanagement.azure.upbound.io";
    public const string KubePluralName = "resourcegroupcostmanagementexports";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ResourceGroupCostManagementExportSpec defines the desired state of ResourceGroupCostManagementExport</summary>
    [JsonPropertyName("spec")]
    public V1beta1ResourceGroupCostManagementExportSpec Spec { get; set; }

    /// <summary>ResourceGroupCostManagementExportStatus defines the observed state of ResourceGroupCostManagementExport.</summary>
    [JsonPropertyName("status")]
    public V1beta1ResourceGroupCostManagementExportStatus? Status { get; set; }
}