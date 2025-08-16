using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.documentai.cnrm.cloud.google.com;
/// <summary>DocumentAIProcessor is the Schema for the DocumentAIProcessor API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DocumentAIProcessorList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DocumentAIProcessor>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DocumentAIProcessorList";
    public const string KubeGroup = "documentai.cnrm.cloud.google.com";
    public const string KubePluralName = "documentaiprocessors";
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
    public IList<V1alpha1DocumentAIProcessor> Items { get; set; }
}

/// <summary>The [KMS key](https://cloud.google.com/security-key-management) used for encryption and decryption in CMEK scenarios.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorSpecKmsKeyRef
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
public partial class V1alpha1DocumentAIProcessorSpecProjectRef
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

/// <summary>DocumentAIProcessorSpec defines the desired state of DocumentAIProcessor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorSpec
{
    /// <summary>The display name of the processor.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The [KMS key](https://cloud.google.com/security-key-management) used for encryption and decryption in CMEK scenarios.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1DocumentAIProcessorSpecKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1DocumentAIProcessorSpecProjectRef ProjectRef { get; set; }

    /// <summary>The GCP resource identifier. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The processor type, such as: `OCR_PROCESSOR`, `INVOICE_PROCESSOR`. To get a list of processor types, see [FetchProcessorTypes][google.cloud.documentai.v1.DocumentProcessorService.FetchProcessorTypes].</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorStatusConditions
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
public partial class V1alpha1DocumentAIProcessorStatusObservedStateProcessorVersionAliases
{
    /// <summary>The alias in the form of `processor_version` resource name.</summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>The resource name of aliased processor version.</summary>
    [JsonPropertyName("processorVersion")]
    public string? ProcessorVersion { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorStatusObservedState
{
    /// <summary>The time the processor was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The default processor version.</summary>
    [JsonPropertyName("defaultProcessorVersion")]
    public string? DefaultProcessorVersion { get; set; }

    /// <summary>Output only. Immutable. The resource name of the processor. Format: `projects/{project}/locations/{location}/processors/{processor}`</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. Immutable. The http endpoint that can be called to invoke processing.</summary>
    [JsonPropertyName("processEndpoint")]
    public string? ProcessEndpoint { get; set; }

    /// <summary>Output only. The processor version aliases.</summary>
    [JsonPropertyName("processorVersionAliases")]
    public IList<V1alpha1DocumentAIProcessorStatusObservedStateProcessorVersionAliases>? ProcessorVersionAliases { get; set; }

    /// <summary>Output only. The state of the processor.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>DocumentAIProcessorStatus defines the config connector machine state of DocumentAIProcessor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DocumentAIProcessorStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DocumentAIProcessorStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DocumentAIProcessor resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DocumentAIProcessorStatusObservedState? ObservedState { get; set; }
}

/// <summary>DocumentAIProcessor is the Schema for the DocumentAIProcessor API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DocumentAIProcessor : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DocumentAIProcessorSpec>, IStatus<V1alpha1DocumentAIProcessorStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DocumentAIProcessor";
    public const string KubeGroup = "documentai.cnrm.cloud.google.com";
    public const string KubePluralName = "documentaiprocessors";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DocumentAIProcessorSpec defines the desired state of DocumentAIProcessor</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DocumentAIProcessorSpec Spec { get; set; }

    /// <summary>DocumentAIProcessorStatus defines the config connector machine state of DocumentAIProcessor</summary>
    [JsonPropertyName("status")]
    public V1alpha1DocumentAIProcessorStatus? Status { get; set; }
}