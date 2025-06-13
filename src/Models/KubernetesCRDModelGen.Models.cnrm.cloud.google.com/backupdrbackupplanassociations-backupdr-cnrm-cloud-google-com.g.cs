using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.backupdr.cnrm.cloud.google.com;
/// <summary>Required. The backup plan which needs to be applied on workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupPlanAssociationSpecBackupPlanRef
{
    /// <summary>A reference to an externally managed BackupDRBackupPlan resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/backupplans/{{backupplanID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BackupDRBackupPlan resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BackupDRBackupPlan resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupPlanAssociationSpecProjectRef
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

/// <summary>InstanceRef defines the resource reference to ComputeInstance, which "External" field holds the GCP identifier for the KRM object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupPlanAssociationSpecResourceComputeInstanceRef
{
    /// <summary>A reference to an externally managed ComputeInstance resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/instances/{{instanceID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeInstance resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeInstance resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. Immutable. Resource name of workload on which backupplan is applied</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupPlanAssociationSpecResource
{
    /// <summary>InstanceRef defines the resource reference to ComputeInstance, which "External" field holds the GCP identifier for the KRM object.</summary>
    [JsonPropertyName("computeInstanceRef")]
    public V1alpha1BackupDRBackupPlanAssociationSpecResourceComputeInstanceRef? ComputeInstanceRef { get; set; }
}

/// <summary>BackupDRBackupPlanAssociationSpec defines the desired state of BackupDRBackupPlanAssociation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupPlanAssociationSpec
{
    /// <summary>Required. The backup plan which needs to be applied on workload.</summary>
    [JsonPropertyName("backupPlanRef")]
    public V1alpha1BackupDRBackupPlanAssociationSpecBackupPlanRef BackupPlanRef { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1BackupDRBackupPlanAssociationSpecProjectRef ProjectRef { get; set; }

    /// <summary>Required. Immutable. Resource name of workload on which backupplan is applied</summary>
    [JsonPropertyName("resource")]
    public V1alpha1BackupDRBackupPlanAssociationSpecResource Resource { get; set; }

    /// <summary>The BackupDRBackupPlanAssociation name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. Immutable. Resource type of workload on which backupplan is applied</summary>
    [JsonPropertyName("resourceType")]
    public string ResourceType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupPlanAssociationStatusConditions
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupPlanAssociationStatusObservedStateRulesConfigInfoLastBackupErrorDetails
{
    /// <summary>A URL/resource name that uniquely identifies the type of the serialized  protocol buffer message. This string must contain at least  one "/" character. The last segment of the URL's path must represent  the fully qualified name of the type (as in  `path/google.protobuf.Duration`). The name should be in a canonical form  (e.g., leading "." is not accepted).   In practice, teams usually precompile into the binary all types that they  expect it to use in the context of Any. However, for URLs which use the  scheme `http`, `https`, or no scheme, one can optionally set up a type  server that maps type URLs to message definitions as follows:   * If no scheme is provided, `https` is assumed.  * An HTTP GET on the URL must yield a [google.protobuf.Type][]    value in binary format, or produce an error.  * Applications are allowed to cache lookup results based on the    URL, or have them precompiled into a binary to avoid any    lookup. Therefore, binary compatibility needs to be preserved    on changes to types. (Use versioned type names to manage    breaking changes.)   Note: this functionality is not currently available in the official  protobuf release, and it is not used for type URLs beginning with  type.googleapis.com.   Schemes other than `http`, `https` (or the empty scheme) might be  used with implementation specific semantics.</summary>
    [JsonPropertyName("typeURL")]
    public string? TypeURL { get; set; }

    /// <summary>Must be a valid serialized protocol buffer of the above specified type.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Output only. google.rpc.Status object to store the last backup error.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupPlanAssociationStatusObservedStateRulesConfigInfoLastBackupError
{
    /// <summary>The status code, which should be an enum value of [google.rpc.Code][google.rpc.Code].</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>A list of messages that carry the error details.  There is a common set of message types for APIs to use.</summary>
    [JsonPropertyName("details")]
    public IList<V1alpha1BackupDRBackupPlanAssociationStatusObservedStateRulesConfigInfoLastBackupErrorDetails>? Details { get; set; }

    /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should be localized and sent in the [google.rpc.Status.details][google.rpc.Status.details] field, or localized by the client.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupPlanAssociationStatusObservedStateRulesConfigInfo
{
    /// <summary>Output only. google.rpc.Status object to store the last backup error.</summary>
    [JsonPropertyName("lastBackupError")]
    public V1alpha1BackupDRBackupPlanAssociationStatusObservedStateRulesConfigInfoLastBackupError? LastBackupError { get; set; }

    /// <summary>Output only. The last backup state for rule.</summary>
    [JsonPropertyName("lastBackupState")]
    public string? LastBackupState { get; set; }

    /// <summary>Output only. The point in time when the last successful backup was captured from the source.</summary>
    [JsonPropertyName("lastSuccessfulBackupConsistencyTime")]
    public string? LastSuccessfulBackupConsistencyTime { get; set; }

    /// <summary>Output only. Backup Rule id fetched from backup plan.</summary>
    [JsonPropertyName("ruleID")]
    public string? RuleID { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupPlanAssociationStatusObservedState
{
    /// <summary>Output only. The time when the instance was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Resource name of data source which will be used as storage location for backups taken. Format : projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}</summary>
    [JsonPropertyName("dataSource")]
    public string? DataSource { get; set; }

    /// <summary>Output only. The config info related to backup rules.</summary>
    [JsonPropertyName("rulesConfigInfo")]
    public IList<V1alpha1BackupDRBackupPlanAssociationStatusObservedStateRulesConfigInfo>? RulesConfigInfo { get; set; }

    /// <summary>Output only. The BackupPlanAssociation resource state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The time when the instance was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>BackupDRBackupPlanAssociationStatus defines the config connector machine state of BackupDRBackupPlanAssociation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupPlanAssociationStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BackupDRBackupPlanAssociationStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BackupDRBackupPlanAssociation resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BackupDRBackupPlanAssociationStatusObservedState? ObservedState { get; set; }
}

/// <summary>BackupDRBackupPlanAssociation is the Schema for the BackupDRBackupPlanAssociation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BackupDRBackupPlanAssociation : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BackupDRBackupPlanAssociationSpec>, IStatus<V1alpha1BackupDRBackupPlanAssociationStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BackupDRBackupPlanAssociation";
    public const string KubeGroup = "backupdr.cnrm.cloud.google.com";
    public const string KubePluralName = "backupdrbackupplanassociations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackupDRBackupPlanAssociationSpec defines the desired state of BackupDRBackupPlanAssociation</summary>
    [JsonPropertyName("spec")]
    public V1alpha1BackupDRBackupPlanAssociationSpec Spec { get; set; }

    /// <summary>BackupDRBackupPlanAssociationStatus defines the config connector machine state of BackupDRBackupPlanAssociation</summary>
    [JsonPropertyName("status")]
    public V1alpha1BackupDRBackupPlanAssociationStatus? Status { get; set; }
}

/// <summary>BackupDRBackupPlanAssociation is the Schema for the BackupDRBackupPlanAssociation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BackupDRBackupPlanAssociationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BackupDRBackupPlanAssociation>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BackupDRBackupPlanAssociationList";
    public const string KubeGroup = "backupdr.cnrm.cloud.google.com";
    public const string KubePluralName = "backupdrbackupplanassociations";
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
    public IList<V1alpha1BackupDRBackupPlanAssociation> Items { get; set; }
}