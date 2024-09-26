using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.netapp.azure.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecForProviderAccountNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Account in netapp to populate accountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecForProviderAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SnapshotPolicySpecForProviderAccountNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecForProviderAccountNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Account in netapp to populate accountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecForProviderAccountNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SnapshotPolicySpecForProviderAccountNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecForProviderDailySchedule
{
    /// <summary>Hour of the day that the snapshots will be created, valid range is from 0 to 23.</summary>
    [JsonPropertyName("hour")]
    public double? Hour { get; set; }

    /// <summary>Minute of the hour that the snapshots will be created, valid range is from 0 to 59.</summary>
    [JsonPropertyName("minute")]
    public double? Minute { get; set; }

    /// <summary>How many hourly snapshots to keep, valid range is from 0 to 255.</summary>
    [JsonPropertyName("snapshotsToKeep")]
    public double? SnapshotsToKeep { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecForProviderHourlySchedule
{
    /// <summary>Minute of the hour that the snapshots will be created, valid range is from 0 to 59.</summary>
    [JsonPropertyName("minute")]
    public double? Minute { get; set; }

    /// <summary>How many hourly snapshots to keep, valid range is from 0 to 255.</summary>
    [JsonPropertyName("snapshotsToKeep")]
    public double? SnapshotsToKeep { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecForProviderMonthlySchedule
{
    /// <summary>List of the days of the month when the snapshots will be created, valid range is from 1 to 30.</summary>
    [JsonPropertyName("daysOfMonth")]
    public IList<double>? DaysOfMonth { get; set; }

    /// <summary>Hour of the day that the snapshots will be created, valid range is from 0 to 23.</summary>
    [JsonPropertyName("hour")]
    public double? Hour { get; set; }

    /// <summary>Minute of the hour that the snapshots will be created, valid range is from 0 to 59.</summary>
    [JsonPropertyName("minute")]
    public double? Minute { get; set; }

    /// <summary>How many hourly snapshots to keep, valid range is from 0 to 255.</summary>
    [JsonPropertyName("snapshotsToKeep")]
    public double? SnapshotsToKeep { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SnapshotPolicySpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SnapshotPolicySpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecForProviderWeeklySchedule
{
    /// <summary>List of the week days using English names when the snapshots will be created.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Hour of the day that the snapshots will be created, valid range is from 0 to 23.</summary>
    [JsonPropertyName("hour")]
    public double? Hour { get; set; }

    /// <summary>Minute of the hour that the snapshots will be created, valid range is from 0 to 59.</summary>
    [JsonPropertyName("minute")]
    public double? Minute { get; set; }

    /// <summary>How many hourly snapshots to keep, valid range is from 0 to 255.</summary>
    [JsonPropertyName("snapshotsToKeep")]
    public double? SnapshotsToKeep { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecForProvider
{
    /// <summary>The name of the NetApp Account in which the NetApp Snapshot Policy should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Reference to a Account in netapp to populate accountName.</summary>
    [JsonPropertyName("accountNameRef")]
    public V1beta1SnapshotPolicySpecForProviderAccountNameRef? AccountNameRef { get; set; }

    /// <summary>Selector for a Account in netapp to populate accountName.</summary>
    [JsonPropertyName("accountNameSelector")]
    public V1beta1SnapshotPolicySpecForProviderAccountNameSelector? AccountNameSelector { get; set; }

    /// <summary>Sets a daily snapshot schedule. A daily_schedule block as defined below.</summary>
    [JsonPropertyName("dailySchedule")]
    public IList<V1beta1SnapshotPolicySpecForProviderDailySchedule>? DailySchedule { get; set; }

    /// <summary>Defines that the NetApp Snapshot Policy is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Sets an hourly snapshot schedule. A hourly_schedule block as defined below.</summary>
    [JsonPropertyName("hourlySchedule")]
    public IList<V1beta1SnapshotPolicySpecForProviderHourlySchedule>? HourlySchedule { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Sets a monthly snapshot schedule. A monthly_schedule block as defined below.</summary>
    [JsonPropertyName("monthlySchedule")]
    public IList<V1beta1SnapshotPolicySpecForProviderMonthlySchedule>? MonthlySchedule { get; set; }

    /// <summary>The name of the resource group where the NetApp Snapshot Policy should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1SnapshotPolicySpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1SnapshotPolicySpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Sets a weekly snapshot schedule. A weekly_schedule block as defined below.</summary>
    [JsonPropertyName("weeklySchedule")]
    public IList<V1beta1SnapshotPolicySpecForProviderWeeklySchedule>? WeeklySchedule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecInitProviderDailySchedule
{
    /// <summary>Hour of the day that the snapshots will be created, valid range is from 0 to 23.</summary>
    [JsonPropertyName("hour")]
    public double? Hour { get; set; }

    /// <summary>Minute of the hour that the snapshots will be created, valid range is from 0 to 59.</summary>
    [JsonPropertyName("minute")]
    public double? Minute { get; set; }

    /// <summary>How many hourly snapshots to keep, valid range is from 0 to 255.</summary>
    [JsonPropertyName("snapshotsToKeep")]
    public double? SnapshotsToKeep { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecInitProviderHourlySchedule
{
    /// <summary>Minute of the hour that the snapshots will be created, valid range is from 0 to 59.</summary>
    [JsonPropertyName("minute")]
    public double? Minute { get; set; }

    /// <summary>How many hourly snapshots to keep, valid range is from 0 to 255.</summary>
    [JsonPropertyName("snapshotsToKeep")]
    public double? SnapshotsToKeep { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecInitProviderMonthlySchedule
{
    /// <summary>List of the days of the month when the snapshots will be created, valid range is from 1 to 30.</summary>
    [JsonPropertyName("daysOfMonth")]
    public IList<double>? DaysOfMonth { get; set; }

    /// <summary>Hour of the day that the snapshots will be created, valid range is from 0 to 23.</summary>
    [JsonPropertyName("hour")]
    public double? Hour { get; set; }

    /// <summary>Minute of the hour that the snapshots will be created, valid range is from 0 to 59.</summary>
    [JsonPropertyName("minute")]
    public double? Minute { get; set; }

    /// <summary>How many hourly snapshots to keep, valid range is from 0 to 255.</summary>
    [JsonPropertyName("snapshotsToKeep")]
    public double? SnapshotsToKeep { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecInitProviderWeeklySchedule
{
    /// <summary>List of the week days using English names when the snapshots will be created.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Hour of the day that the snapshots will be created, valid range is from 0 to 23.</summary>
    [JsonPropertyName("hour")]
    public double? Hour { get; set; }

    /// <summary>Minute of the hour that the snapshots will be created, valid range is from 0 to 59.</summary>
    [JsonPropertyName("minute")]
    public double? Minute { get; set; }

    /// <summary>How many hourly snapshots to keep, valid range is from 0 to 255.</summary>
    [JsonPropertyName("snapshotsToKeep")]
    public double? SnapshotsToKeep { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecInitProvider
{
    /// <summary>Sets a daily snapshot schedule. A daily_schedule block as defined below.</summary>
    [JsonPropertyName("dailySchedule")]
    public IList<V1beta1SnapshotPolicySpecInitProviderDailySchedule>? DailySchedule { get; set; }

    /// <summary>Defines that the NetApp Snapshot Policy is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Sets an hourly snapshot schedule. A hourly_schedule block as defined below.</summary>
    [JsonPropertyName("hourlySchedule")]
    public IList<V1beta1SnapshotPolicySpecInitProviderHourlySchedule>? HourlySchedule { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Sets a monthly snapshot schedule. A monthly_schedule block as defined below.</summary>
    [JsonPropertyName("monthlySchedule")]
    public IList<V1beta1SnapshotPolicySpecInitProviderMonthlySchedule>? MonthlySchedule { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Sets a weekly snapshot schedule. A weekly_schedule block as defined below.</summary>
    [JsonPropertyName("weeklySchedule")]
    public IList<V1beta1SnapshotPolicySpecInitProviderWeeklySchedule>? WeeklySchedule { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SnapshotPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SnapshotPolicySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1SnapshotPolicySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SnapshotPolicySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SnapshotPolicySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SnapshotPolicySpec defines the desired state of SnapshotPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SnapshotPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SnapshotPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SnapshotPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SnapshotPolicySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SnapshotPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicyStatusAtProviderDailySchedule
{
    /// <summary>Hour of the day that the snapshots will be created, valid range is from 0 to 23.</summary>
    [JsonPropertyName("hour")]
    public double? Hour { get; set; }

    /// <summary>Minute of the hour that the snapshots will be created, valid range is from 0 to 59.</summary>
    [JsonPropertyName("minute")]
    public double? Minute { get; set; }

    /// <summary>How many hourly snapshots to keep, valid range is from 0 to 255.</summary>
    [JsonPropertyName("snapshotsToKeep")]
    public double? SnapshotsToKeep { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicyStatusAtProviderHourlySchedule
{
    /// <summary>Minute of the hour that the snapshots will be created, valid range is from 0 to 59.</summary>
    [JsonPropertyName("minute")]
    public double? Minute { get; set; }

    /// <summary>How many hourly snapshots to keep, valid range is from 0 to 255.</summary>
    [JsonPropertyName("snapshotsToKeep")]
    public double? SnapshotsToKeep { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicyStatusAtProviderMonthlySchedule
{
    /// <summary>List of the days of the month when the snapshots will be created, valid range is from 1 to 30.</summary>
    [JsonPropertyName("daysOfMonth")]
    public IList<double>? DaysOfMonth { get; set; }

    /// <summary>Hour of the day that the snapshots will be created, valid range is from 0 to 23.</summary>
    [JsonPropertyName("hour")]
    public double? Hour { get; set; }

    /// <summary>Minute of the hour that the snapshots will be created, valid range is from 0 to 59.</summary>
    [JsonPropertyName("minute")]
    public double? Minute { get; set; }

    /// <summary>How many hourly snapshots to keep, valid range is from 0 to 255.</summary>
    [JsonPropertyName("snapshotsToKeep")]
    public double? SnapshotsToKeep { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicyStatusAtProviderWeeklySchedule
{
    /// <summary>List of the week days using English names when the snapshots will be created.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Hour of the day that the snapshots will be created, valid range is from 0 to 23.</summary>
    [JsonPropertyName("hour")]
    public double? Hour { get; set; }

    /// <summary>Minute of the hour that the snapshots will be created, valid range is from 0 to 59.</summary>
    [JsonPropertyName("minute")]
    public double? Minute { get; set; }

    /// <summary>How many hourly snapshots to keep, valid range is from 0 to 255.</summary>
    [JsonPropertyName("snapshotsToKeep")]
    public double? SnapshotsToKeep { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicyStatusAtProvider
{
    /// <summary>The name of the NetApp Account in which the NetApp Snapshot Policy should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Sets a daily snapshot schedule. A daily_schedule block as defined below.</summary>
    [JsonPropertyName("dailySchedule")]
    public IList<V1beta1SnapshotPolicyStatusAtProviderDailySchedule>? DailySchedule { get; set; }

    /// <summary>Defines that the NetApp Snapshot Policy is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Sets an hourly snapshot schedule. A hourly_schedule block as defined below.</summary>
    [JsonPropertyName("hourlySchedule")]
    public IList<V1beta1SnapshotPolicyStatusAtProviderHourlySchedule>? HourlySchedule { get; set; }

    /// <summary>The ID of the NetApp Snapshot.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Sets a monthly snapshot schedule. A monthly_schedule block as defined below.</summary>
    [JsonPropertyName("monthlySchedule")]
    public IList<V1beta1SnapshotPolicyStatusAtProviderMonthlySchedule>? MonthlySchedule { get; set; }

    /// <summary>The name of the resource group where the NetApp Snapshot Policy should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Sets a weekly snapshot schedule. A weekly_schedule block as defined below.</summary>
    [JsonPropertyName("weeklySchedule")]
    public IList<V1beta1SnapshotPolicyStatusAtProviderWeeklySchedule>? WeeklySchedule { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicyStatusConditions
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

/// <summary>SnapshotPolicyStatus defines the observed state of SnapshotPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SnapshotPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SnapshotPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SnapshotPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SnapshotPolicy is the Schema for the SnapshotPolicys API. Manages a NetApp Snapshot Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SnapshotPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SnapshotPolicySpec>, IStatus<V1beta1SnapshotPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SnapshotPolicy";
    public const string KubeGroup = "netapp.azure.upbound.io";
    public const string KubePluralName = "snapshotpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SnapshotPolicySpec defines the desired state of SnapshotPolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1SnapshotPolicySpec Spec { get; set; }

    /// <summary>SnapshotPolicyStatus defines the observed state of SnapshotPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1SnapshotPolicyStatus? Status { get; set; }
}