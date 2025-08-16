using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.colab.cnrm.cloud.google.com;
/// <summary>ColabRuntime is the Schema for the ColabRuntime API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ColabRuntimeList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ColabRuntime>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ColabRuntimeList";
    public const string KubeGroup = "colab.cnrm.cloud.google.com";
    public const string KubePluralName = "colabruntimes";
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
    public IList<V1alpha1ColabRuntime> Items { get; set; }
}

/// <summary>The pointer to NotebookRuntimeTemplate this NotebookRuntime is created from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeSpecColabRuntimeTemplateRef
{
    /// <summary>A reference to an externally managed ColabRuntimeTemplate resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/notebookRuntimeTemplates/{{notebookruntimetemplateID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ColabRuntimeTemplate resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ColabRuntimeTemplate resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeSpecProjectRef
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

/// <summary>ColabRuntimeSpec defines the desired state of ColabRuntime</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeSpec
{
    /// <summary>The pointer to NotebookRuntimeTemplate this NotebookRuntime is created from.</summary>
    [JsonPropertyName("colabRuntimeTemplateRef")]
    public V1alpha1ColabRuntimeSpecColabRuntimeTemplateRef ColabRuntimeTemplateRef { get; set; }

    /// <summary>The description of the NotebookRuntime.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The display name of the NotebookRuntime. The name can be up to 128 characters long and can consist of any UTF-8 characters.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>The labels with user-defined metadata to organize your  NotebookRuntime.   Label keys and values can be no longer than 64 characters  (Unicode codepoints), can only contain lowercase letters, numeric  characters, underscores and dashes. International characters are allowed.  No more than 64 user labels can be associated with one NotebookRuntime  (System labels are excluded).   See https://goo.gl/xmQnxf for more information and examples of labels.  System reserved label keys are prefixed with "aiplatform.googleapis.com/"  and are immutable. Following system labels exist for NotebookRuntime:   * "aiplatform.googleapis.com/notebook_runtime_gce_instance_id": output  only, its value is the Compute Engine instance id.  * "aiplatform.googleapis.com/colab_enterprise_entry_service": its value is  either "bigquery" or "vertex"; if absent, it should be "vertex". This is to  describe the entry service, either BigQuery or Vertex.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Immutable. The name of the location where the Runtime will be created. Required.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Optional. The Compute Engine tags to add to runtime (see [Tagging instances](https://cloud.google.com/vpc/docs/add-remove-network-tags)).</summary>
    [JsonPropertyName("networkTags")]
    public IList<string>? NetworkTags { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1ColabRuntimeSpecProjectRef ProjectRef { get; set; }

    /// <summary>The ColabRuntime name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. The user email of the NotebookRuntime.</summary>
    [JsonPropertyName("runtimeUser")]
    public string RuntimeUser { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeStatusConditions
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

/// <summary>Output only. Customer-managed encryption key spec for the notebook runtime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeStatusObservedStateEncryptionSpec
{
    /// <summary>The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. Has the form: `projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key`. The key needs to be in the same region as where the compute resource is created.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>Output only. The idle shutdown configuration of the notebook runtime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeStatusObservedStateIdleShutdownConfig
{
    /// <summary>Whether Idle Shutdown is disabled in this NotebookRuntimeTemplate.</summary>
    [JsonPropertyName("idleShutdownDisabled")]
    public bool? IdleShutdownDisabled { get; set; }

    /// <summary>Required. Duration is accurate to the second. In Notebook, Idle Timeout is accurate to minute so the range of idle_timeout (second) is: 10 * 60 ~ 1440 * 60.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeStatusObservedState
{
    /// <summary>Output only. Timestamp when this NotebookRuntime was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Customer-managed encryption key spec for the notebook runtime.</summary>
    [JsonPropertyName("encryptionSpec")]
    public V1alpha1ColabRuntimeStatusObservedStateEncryptionSpec? EncryptionSpec { get; set; }

    /// <summary>Output only. Timestamp when this NotebookRuntime will be expired: 1. System Predefined NotebookRuntime: 24 hours after creation. After expiration, system predifined runtime will be deleted. 2. User created NotebookRuntime: 6 months after last upgrade. After expiration, user created runtime will be stopped and allowed for upgrade.</summary>
    [JsonPropertyName("expirationTime")]
    public string? ExpirationTime { get; set; }

    /// <summary>Output only. The health state of the NotebookRuntime.</summary>
    [JsonPropertyName("healthState")]
    public string? HealthState { get; set; }

    /// <summary>Output only. The idle shutdown configuration of the notebook runtime.</summary>
    [JsonPropertyName("idleShutdownConfig")]
    public V1alpha1ColabRuntimeStatusObservedStateIdleShutdownConfig? IdleShutdownConfig { get; set; }

    /// <summary>Output only. Whether NotebookRuntime is upgradable.</summary>
    [JsonPropertyName("isUpgradable")]
    public bool? IsUpgradable { get; set; }

    /// <summary>Output only. The type of the notebook runtime.</summary>
    [JsonPropertyName("notebookRuntimeType")]
    public string? NotebookRuntimeType { get; set; }

    /// <summary>Output only. The proxy endpoint used to access the NotebookRuntime.</summary>
    [JsonPropertyName("proxyURI")]
    public string? ProxyURI { get; set; }

    /// <summary>Output only. The runtime (instance) state of the NotebookRuntime.</summary>
    [JsonPropertyName("runtimeState")]
    public string? RuntimeState { get; set; }

    /// <summary>Output only. The service account that the NotebookRuntime workload runs as.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Output only. Timestamp when this NotebookRuntime was most recently updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Output only. The VM os image version of NotebookRuntime.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>ColabRuntimeStatus defines the config connector machine state of ColabRuntime</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ColabRuntimeStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ColabRuntimeStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ColabRuntime resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1ColabRuntimeStatusObservedState? ObservedState { get; set; }
}

/// <summary>ColabRuntime is the Schema for the ColabRuntime API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ColabRuntime : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ColabRuntimeSpec>, IStatus<V1alpha1ColabRuntimeStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ColabRuntime";
    public const string KubeGroup = "colab.cnrm.cloud.google.com";
    public const string KubePluralName = "colabruntimes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ColabRuntimeSpec defines the desired state of ColabRuntime</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ColabRuntimeSpec Spec { get; set; }

    /// <summary>ColabRuntimeStatus defines the config connector machine state of ColabRuntime</summary>
    [JsonPropertyName("status")]
    public V1alpha1ColabRuntimeStatus? Status { get; set; }
}