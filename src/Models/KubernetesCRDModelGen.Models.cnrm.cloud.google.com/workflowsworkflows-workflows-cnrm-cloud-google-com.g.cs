using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.workflows.cnrm.cloud.google.com;
/// <summary>Optional. The resource name of a KMS crypto key used to encrypt or decrypt the data associated with the workflow. If not provided, data associated with the workflow will not be CMEK-encrypted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowsWorkflowSpecKmsCryptoKeyRef
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

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowsWorkflowSpecProjectRef
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

/// <summary>The service account associated with the latest workflow version. This service account represents the identity of the workflow and determines what permissions the workflow has. If not provided, workflow will use the project's default service account. Modifying this field for an existing workflow results in a new workflow revision.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowsWorkflowSpecServiceAccountRef
{
    /// <summary>The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>WorkflowsWorkflowSpec defines the desired state of Workflow</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowsWorkflowSpec
{
    /// <summary>Optional. Describes the level of platform logging to apply to calls and call responses during executions of this workflow. If both the workflow and the execution specify a logging level, the execution level takes precedence.</summary>
    [JsonPropertyName("callLogLevel")]
    public string? CallLogLevel { get; set; }

    /// <summary>Description of the workflow provided by the user. Must be at most 1000 unicode characters long.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. The resource name of a KMS crypto key used to encrypt or decrypt the data associated with the workflow. If not provided, data associated with the workflow will not be CMEK-encrypted.</summary>
    [JsonPropertyName("kmsCryptoKeyRef")]
    public V1alpha1WorkflowsWorkflowSpecKmsCryptoKeyRef? KmsCryptoKeyRef { get; set; }

    /// <summary>Labels associated with this workflow. Labels can contain at most 64 entries. Keys and values can be no longer than 63 characters and can only contain lowercase letters, numeric characters, underscores, and dashes. Label keys must start with a letter. International characters are allowed.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1WorkflowsWorkflowSpecProjectRef ProjectRef { get; set; }

    /// <summary>The Workflow name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The service account associated with the latest workflow version. This service account represents the identity of the workflow and determines what permissions the workflow has. If not provided, workflow will use the project's default service account. Modifying this field for an existing workflow results in a new workflow revision.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1alpha1WorkflowsWorkflowSpecServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Required. Workflow code to be executed. The size limit is 128KB.</summary>
    [JsonPropertyName("sourceContents")]
    public string SourceContents { get; set; }

    /// <summary>Optional.User-defined environment variables associated with this workflow revision. This map has a maximum length of 20. Each string can take up to 40KiB. Keys cannot be empty strings and cannot start with “GOOGLE” or “WORKFLOWS".</summary>
    [JsonPropertyName("userEnvVars")]
    public IDictionary<string, string>? UserEnvVars { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowsWorkflowStatusConditions
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

/// <summary>Error regarding the state of the workflow. For example, this field will have error details if the execution data is unavailable due to revoked KMS key permissions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowsWorkflowStatusObservedStateStateError
{
    /// <summary>Provides specifics about the error.</summary>
    [JsonPropertyName("details")]
    public string? Details { get; set; }

    /// <summary>The type of this state error.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowsWorkflowStatusObservedState
{
    /// <summary>The timestamp for when the workflow was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The timestamp for the latest revision of the workflow's creation.</summary>
    [JsonPropertyName("revisionCreateTime")]
    public string? RevisionCreateTime { get; set; }

    /// <summary>The revision of the workflow. A new revision of a workflow is created as a result of updating the following properties of a workflow: - service_account - source_content The format is "000001-a4d", where the first six characters define the zero-padded revision ordinal number. They are followed by a hyphen and three hexadecimal random characters.</summary>
    [JsonPropertyName("revisionId")]
    public string? RevisionId { get; set; }

    /// <summary>State of the workflow deployment.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Error regarding the state of the workflow. For example, this field will have error details if the execution data is unavailable due to revoked KMS key permissions.</summary>
    [JsonPropertyName("stateError")]
    public V1alpha1WorkflowsWorkflowStatusObservedStateStateError? StateError { get; set; }

    /// <summary>The timestamp for when the workflow was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>WorkflowsWorkflowStatus defines the config connector machine state of Workflow</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowsWorkflowStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1WorkflowsWorkflowStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the Workflow resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1WorkflowsWorkflowStatusObservedState? ObservedState { get; set; }
}

/// <summary>Workflow is the Schema for the Workflow API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WorkflowsWorkflow : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1WorkflowsWorkflowSpec>, IStatus<V1alpha1WorkflowsWorkflowStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WorkflowsWorkflow";
    public const string KubeGroup = "workflows.cnrm.cloud.google.com";
    public const string KubePluralName = "workflowsworkflows";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WorkflowsWorkflowSpec defines the desired state of Workflow</summary>
    [JsonPropertyName("spec")]
    public V1alpha1WorkflowsWorkflowSpec Spec { get; set; }

    /// <summary>WorkflowsWorkflowStatus defines the config connector machine state of Workflow</summary>
    [JsonPropertyName("status")]
    public V1alpha1WorkflowsWorkflowStatus? Status { get; set; }
}

/// <summary>Workflow is the Schema for the Workflow API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WorkflowsWorkflowList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1WorkflowsWorkflow>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WorkflowsWorkflowList";
    public const string KubeGroup = "workflows.cnrm.cloud.google.com";
    public const string KubePluralName = "workflowsworkflows";
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
    public IList<V1alpha1WorkflowsWorkflow> Items { get; set; }
}