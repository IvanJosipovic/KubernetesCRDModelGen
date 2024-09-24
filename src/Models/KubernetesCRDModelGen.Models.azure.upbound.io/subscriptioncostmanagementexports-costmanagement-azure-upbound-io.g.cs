using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.costmanagement.azure.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecForProviderExportDataOptions
{
    /// <summary>The time frame for pulling data for the query. If custom, then a specific time period must be provided. Possible values include: WeekToDate, MonthToDate, BillingMonthToDate, TheLast7Days, TheLastMonth, TheLastBillingMonth, Custom.</summary>
    [JsonPropertyName("timeFrame")]
    public string? TimeFrame { get; set; }

    /// <summary>The type of the query. Possible values are ActualCost, AmortizedCost and Usage.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicyResolutionEnum>))]
    public V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicyResolveEnum>))]
    public V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Container in storage to populate containerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicyResolutionEnum>))]
    public V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicyResolveEnum>))]
    public V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Container in storage to populate containerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocation
{
    /// <summary>The Resource Manager ID of the container where exports will be uploaded. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("containerId")]
    public string? ContainerId { get; set; }

    /// <summary>Reference to a Container in storage to populate containerId.</summary>
    [JsonPropertyName("containerIdRef")]
    public V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRef? ContainerIdRef { get; set; }

    /// <summary>Selector for a Container in storage to populate containerId.</summary>
    [JsonPropertyName("containerIdSelector")]
    public V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelector? ContainerIdSelector { get; set; }

    /// <summary>The path of the directory where exports will be uploaded. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("rootFolderPath")]
    public string? RootFolderPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecForProviderSubscriptionIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecForProviderSubscriptionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecForProviderSubscriptionIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionCostManagementExportSpecForProviderSubscriptionIdRefPolicyResolutionEnum>))]
    public V1beta1SubscriptionCostManagementExportSpecForProviderSubscriptionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionCostManagementExportSpecForProviderSubscriptionIdRefPolicyResolveEnum>))]
    public V1beta1SubscriptionCostManagementExportSpecForProviderSubscriptionIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subscription in azure to populate subscriptionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecForProviderSubscriptionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionCostManagementExportSpecForProviderSubscriptionIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecForProviderSubscriptionIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecForProviderSubscriptionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecForProviderSubscriptionIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionCostManagementExportSpecForProviderSubscriptionIdSelectorPolicyResolutionEnum>))]
    public V1beta1SubscriptionCostManagementExportSpecForProviderSubscriptionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionCostManagementExportSpecForProviderSubscriptionIdSelectorPolicyResolveEnum>))]
    public V1beta1SubscriptionCostManagementExportSpecForProviderSubscriptionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subscription in azure to populate subscriptionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecForProviderSubscriptionIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionCostManagementExportSpecForProviderSubscriptionIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecForProvider
{
    /// <summary>Is the cost management export active? Default is true.</summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>A export_data_options block as defined below.</summary>
    [JsonPropertyName("exportDataOptions")]
    public IList<V1beta1SubscriptionCostManagementExportSpecForProviderExportDataOptions>? ExportDataOptions { get; set; }

    /// <summary>A export_data_storage_location block as defined below.</summary>
    [JsonPropertyName("exportDataStorageLocation")]
    public IList<V1beta1SubscriptionCostManagementExportSpecForProviderExportDataStorageLocation>? ExportDataStorageLocation { get; set; }

    /// <summary>Specifies the name of the Cost Management Export. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The date the export will stop capturing information.</summary>
    [JsonPropertyName("recurrencePeriodEndDate")]
    public string? RecurrencePeriodEndDate { get; set; }

    /// <summary>The date the export will start capturing information.</summary>
    [JsonPropertyName("recurrencePeriodStartDate")]
    public string? RecurrencePeriodStartDate { get; set; }

    /// <summary>How often the requested information will be exported. Valid values include Annually, Daily, Monthly, Weekly.</summary>
    [JsonPropertyName("recurrenceType")]
    public string? RecurrenceType { get; set; }

    /// <summary>The id of the subscription on which to create an export. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>Reference to a Subscription in azure to populate subscriptionId.</summary>
    [JsonPropertyName("subscriptionIdRef")]
    public V1beta1SubscriptionCostManagementExportSpecForProviderSubscriptionIdRef? SubscriptionIdRef { get; set; }

    /// <summary>Selector for a Subscription in azure to populate subscriptionId.</summary>
    [JsonPropertyName("subscriptionIdSelector")]
    public V1beta1SubscriptionCostManagementExportSpecForProviderSubscriptionIdSelector? SubscriptionIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataOptions
{
    /// <summary>The time frame for pulling data for the query. If custom, then a specific time period must be provided. Possible values include: WeekToDate, MonthToDate, BillingMonthToDate, TheLast7Days, TheLastMonth, TheLastBillingMonth, Custom.</summary>
    [JsonPropertyName("timeFrame")]
    public string? TimeFrame { get; set; }

    /// <summary>The type of the query. Possible values are ActualCost, AmortizedCost and Usage.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicyResolutionEnum>))]
    public V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicyResolveEnum>))]
    public V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Container in storage to populate containerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicyResolutionEnum>))]
    public V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicyResolveEnum>))]
    public V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Container in storage to populate containerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocation
{
    /// <summary>The Resource Manager ID of the container where exports will be uploaded. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("containerId")]
    public string? ContainerId { get; set; }

    /// <summary>Reference to a Container in storage to populate containerId.</summary>
    [JsonPropertyName("containerIdRef")]
    public V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRef? ContainerIdRef { get; set; }

    /// <summary>Selector for a Container in storage to populate containerId.</summary>
    [JsonPropertyName("containerIdSelector")]
    public V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelector? ContainerIdSelector { get; set; }

    /// <summary>The path of the directory where exports will be uploaded. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("rootFolderPath")]
    public string? RootFolderPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecInitProviderSubscriptionIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecInitProviderSubscriptionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecInitProviderSubscriptionIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionCostManagementExportSpecInitProviderSubscriptionIdRefPolicyResolutionEnum>))]
    public V1beta1SubscriptionCostManagementExportSpecInitProviderSubscriptionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionCostManagementExportSpecInitProviderSubscriptionIdRefPolicyResolveEnum>))]
    public V1beta1SubscriptionCostManagementExportSpecInitProviderSubscriptionIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subscription in azure to populate subscriptionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecInitProviderSubscriptionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionCostManagementExportSpecInitProviderSubscriptionIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecInitProviderSubscriptionIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecInitProviderSubscriptionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecInitProviderSubscriptionIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionCostManagementExportSpecInitProviderSubscriptionIdSelectorPolicyResolutionEnum>))]
    public V1beta1SubscriptionCostManagementExportSpecInitProviderSubscriptionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionCostManagementExportSpecInitProviderSubscriptionIdSelectorPolicyResolveEnum>))]
    public V1beta1SubscriptionCostManagementExportSpecInitProviderSubscriptionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subscription in azure to populate subscriptionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecInitProviderSubscriptionIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionCostManagementExportSpecInitProviderSubscriptionIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecInitProvider
{
    /// <summary>Is the cost management export active? Default is true.</summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>A export_data_options block as defined below.</summary>
    [JsonPropertyName("exportDataOptions")]
    public IList<V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataOptions>? ExportDataOptions { get; set; }

    /// <summary>A export_data_storage_location block as defined below.</summary>
    [JsonPropertyName("exportDataStorageLocation")]
    public IList<V1beta1SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocation>? ExportDataStorageLocation { get; set; }

    /// <summary>Specifies the name of the Cost Management Export. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The date the export will stop capturing information.</summary>
    [JsonPropertyName("recurrencePeriodEndDate")]
    public string? RecurrencePeriodEndDate { get; set; }

    /// <summary>The date the export will start capturing information.</summary>
    [JsonPropertyName("recurrencePeriodStartDate")]
    public string? RecurrencePeriodStartDate { get; set; }

    /// <summary>How often the requested information will be exported. Valid values include Annually, Daily, Monthly, Weekly.</summary>
    [JsonPropertyName("recurrenceType")]
    public string? RecurrenceType { get; set; }

    /// <summary>The id of the subscription on which to create an export. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>Reference to a Subscription in azure to populate subscriptionId.</summary>
    [JsonPropertyName("subscriptionIdRef")]
    public V1beta1SubscriptionCostManagementExportSpecInitProviderSubscriptionIdRef? SubscriptionIdRef { get; set; }

    /// <summary>Selector for a Subscription in azure to populate subscriptionId.</summary>
    [JsonPropertyName("subscriptionIdSelector")]
    public V1beta1SubscriptionCostManagementExportSpecInitProviderSubscriptionIdSelector? SubscriptionIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecManagementPoliciesEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionCostManagementExportSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1SubscriptionCostManagementExportSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionCostManagementExportSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1SubscriptionCostManagementExportSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionCostManagementExportSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SubscriptionCostManagementExportSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionCostManagementExportSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1SubscriptionCostManagementExportSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionCostManagementExportSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1SubscriptionCostManagementExportSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionCostManagementExportSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecPublishConnectionDetailsToMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SubscriptionCostManagementExportSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SubscriptionCostManagementExportSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SubscriptionCostManagementExportSpec defines the desired state of SubscriptionCostManagementExport</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SubscriptionCostManagementExportSpecDeletionPolicyEnum>))]
    public V1beta1SubscriptionCostManagementExportSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SubscriptionCostManagementExportSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SubscriptionCostManagementExportSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SubscriptionCostManagementExportSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SubscriptionCostManagementExportSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SubscriptionCostManagementExportSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SubscriptionCostManagementExportSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportStatusAtProviderExportDataOptions
{
    /// <summary>The time frame for pulling data for the query. If custom, then a specific time period must be provided. Possible values include: WeekToDate, MonthToDate, BillingMonthToDate, TheLast7Days, TheLastMonth, TheLastBillingMonth, Custom.</summary>
    [JsonPropertyName("timeFrame")]
    public string? TimeFrame { get; set; }

    /// <summary>The type of the query. Possible values are ActualCost, AmortizedCost and Usage.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportStatusAtProviderExportDataStorageLocation
{
    /// <summary>The Resource Manager ID of the container where exports will be uploaded. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("containerId")]
    public string? ContainerId { get; set; }

    /// <summary>The path of the directory where exports will be uploaded. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("rootFolderPath")]
    public string? RootFolderPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportStatusAtProvider
{
    /// <summary>Is the cost management export active? Default is true.</summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>A export_data_options block as defined below.</summary>
    [JsonPropertyName("exportDataOptions")]
    public IList<V1beta1SubscriptionCostManagementExportStatusAtProviderExportDataOptions>? ExportDataOptions { get; set; }

    /// <summary>A export_data_storage_location block as defined below.</summary>
    [JsonPropertyName("exportDataStorageLocation")]
    public IList<V1beta1SubscriptionCostManagementExportStatusAtProviderExportDataStorageLocation>? ExportDataStorageLocation { get; set; }

    /// <summary>The ID of the Cost Management Export for this Subscription.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the name of the Cost Management Export. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The date the export will stop capturing information.</summary>
    [JsonPropertyName("recurrencePeriodEndDate")]
    public string? RecurrencePeriodEndDate { get; set; }

    /// <summary>The date the export will start capturing information.</summary>
    [JsonPropertyName("recurrencePeriodStartDate")]
    public string? RecurrencePeriodStartDate { get; set; }

    /// <summary>How often the requested information will be exported. Valid values include Annually, Daily, Monthly, Weekly.</summary>
    [JsonPropertyName("recurrenceType")]
    public string? RecurrenceType { get; set; }

    /// <summary>The id of the subscription on which to create an export. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportStatusConditions
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

/// <summary>SubscriptionCostManagementExportStatus defines the observed state of SubscriptionCostManagementExport.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionCostManagementExportStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SubscriptionCostManagementExportStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SubscriptionCostManagementExportStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SubscriptionCostManagementExport is the Schema for the SubscriptionCostManagementExports API. Manages an Azure Cost Management Export for a Subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SubscriptionCostManagementExport : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SubscriptionCostManagementExportSpec>, IStatus<V1beta1SubscriptionCostManagementExportStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SubscriptionCostManagementExport";
    public const string KubeGroup = "costmanagement.azure.upbound.io";
    public const string KubePluralName = "subscriptioncostmanagementexports";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SubscriptionCostManagementExportSpec defines the desired state of SubscriptionCostManagementExport</summary>
    [JsonPropertyName("spec")]
    public V1beta1SubscriptionCostManagementExportSpec Spec { get; set; }

    /// <summary>SubscriptionCostManagementExportStatus defines the observed state of SubscriptionCostManagementExport.</summary>
    [JsonPropertyName("status")]
    public V1beta1SubscriptionCostManagementExportStatus? Status { get; set; }
}