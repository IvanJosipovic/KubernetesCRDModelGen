using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataflow.cnrm.cloud.google.com;
/// <summary>The Cloud KMS key for the job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataflowFlexTemplateJobSpecKmsKeyNameRef
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

/// <summary>Network to which VMs will be assigned.  If empty or unspecified, the service will use the network "default".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataflowFlexTemplateJobSpecNetworkRef
{
    /// <summary>A reference to an externally managed Compute Network resource. Should be in the format `projects/&lt;projectID&gt;/global/networks/&lt;network&gt;`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The email address of the service account to run the job as.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataflowFlexTemplateJobSpecServiceAccountEmailRef
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

/// <summary>Subnetwork to which VMs will be assigned, if desired. You can specify a subnetwork using either a complete URL or an abbreviated path. Expected to be of the form "https://www.googleapis.com/compute/v1/projects/HOST_PROJECT_ID/regions/REGION/subnetworks/SUBNETWORK" or "regions/REGION/subnetworks/SUBNETWORK". If the subnetwork is located in a Shared VPC network, you must use the complete URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataflowFlexTemplateJobSpecSubnetworkRef
{
    /// <summary>The ComputeSubnetwork selflink of form "projects/{{project}}/regions/{{region}}/subnetworks/{{name}}", when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>DataflowFlexTemplateJobSpec defines the desired state of DataflowFlexTemplateJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataflowFlexTemplateJobSpec
{
    /// <summary>Additional experiment flags for the job.</summary>
    [JsonPropertyName("additionalExperiments")]
    public IList<string>? AdditionalExperiments { get; set; }

    /// <summary>The algorithm to use for autoscaling</summary>
    [JsonPropertyName("autoscalingAlgorithm")]
    public string? AutoscalingAlgorithm { get; set; }

    /// <summary>Cloud Storage path to a file with json serialized ContainerSpec as content.</summary>
    [JsonPropertyName("containerSpecGcsPath")]
    public string ContainerSpecGcsPath { get; set; }

    /// <summary>Whether to enable Streaming Engine for the job.</summary>
    [JsonPropertyName("enableStreamingEngine")]
    public bool? EnableStreamingEngine { get; set; }

    /// <summary>Configuration for VM IPs.</summary>
    [JsonPropertyName("ipConfiguration")]
    public string? IpConfiguration { get; set; }

    /// <summary>The Cloud KMS key for the job.</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public V1beta1DataflowFlexTemplateJobSpecKmsKeyNameRef? KmsKeyNameRef { get; set; }

    /// <summary>The machine type to use for launching the job. The default is n1-standard-1.</summary>
    [JsonPropertyName("launcherMachineType")]
    public string? LauncherMachineType { get; set; }

    /// <summary>The machine type to use for the job. Defaults to the value from the template if not specified.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The maximum number of Google Compute Engine instances to be made available to your pipeline during execution, from 1 to 1000.</summary>
    [JsonPropertyName("maxWorkers")]
    public int? MaxWorkers { get; set; }

    /// <summary>Network to which VMs will be assigned.  If empty or unspecified, the service will use the network "default".</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1DataflowFlexTemplateJobSpecNetworkRef? NetworkRef { get; set; }

    /// <summary>The initial number of Google Compute Engine instances for the job.</summary>
    [JsonPropertyName("numWorkers")]
    public int? NumWorkers { get; set; }

    /// <summary>The parameters for FlexTemplate. Ex. {"num_workers":"5"}</summary>
    [JsonPropertyName("parameters")]
    public JsonNode? Parameters { get; set; }

    /// <summary>Immutable. The region in which the created job should run.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Docker registry location of container image to use for the 'worker harness. Default is the container for the version of the SDK. Note this field is only valid for portable pipelines.</summary>
    [JsonPropertyName("sdkContainerImage")]
    public string? SdkContainerImage { get; set; }

    /// <summary>The email address of the service account to run the job as.</summary>
    [JsonPropertyName("serviceAccountEmailRef")]
    public V1beta1DataflowFlexTemplateJobSpecServiceAccountEmailRef? ServiceAccountEmailRef { get; set; }

    /// <summary>The Cloud Storage path for staging local files. Must be a valid Cloud Storage URL, beginning with `gs://`.</summary>
    [JsonPropertyName("stagingLocation")]
    public string? StagingLocation { get; set; }

    /// <summary>Subnetwork to which VMs will be assigned, if desired. You can specify a subnetwork using either a complete URL or an abbreviated path. Expected to be of the form "https://www.googleapis.com/compute/v1/projects/HOST_PROJECT_ID/regions/REGION/subnetworks/SUBNETWORK" or "regions/REGION/subnetworks/SUBNETWORK". If the subnetwork is located in a Shared VPC network, you must use the complete URL.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1DataflowFlexTemplateJobSpecSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>The Cloud Storage path to use for temporary files. Must be a valid Cloud Storage URL, beginning with `gs://`.</summary>
    [JsonPropertyName("tempLocation")]
    public string? TempLocation { get; set; }

    /// <summary>Map of transform name prefixes of the job to be replaced with the corresponding name prefixes of the new job. Only applicable when updating a pipeline.</summary>
    [JsonPropertyName("transformNameMapping")]
    public JsonNode? TransformNameMapping { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataflowFlexTemplateJobStatusConditions
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

/// <summary>DataflowFlexTemplateJobStatus defines the config connector machine state of DataflowFlexTemplateJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataflowFlexTemplateJobStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DataflowFlexTemplateJobStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>The current state of the job.   Jobs are created in the `JOB_STATE_STOPPED` state unless otherwise  specified.   A job in the `JOB_STATE_RUNNING` state may asynchronously enter a  terminal state. After a job has reached a terminal state, no  further state updates may be made.   This field may be mutated by the Cloud Dataflow service;  callers cannot mutate it.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The type of Cloud Dataflow job.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>DataflowFlexTemplateJob is the Schema for the DataflowFlexTemplateJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataflowFlexTemplateJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DataflowFlexTemplateJobSpec>, IStatus<V1beta1DataflowFlexTemplateJobStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataflowFlexTemplateJob";
    public const string KubeGroup = "dataflow.cnrm.cloud.google.com";
    public const string KubePluralName = "dataflowflextemplatejobs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataflowFlexTemplateJobSpec defines the desired state of DataflowFlexTemplateJob</summary>
    [JsonPropertyName("spec")]
    public V1beta1DataflowFlexTemplateJobSpec Spec { get; set; }

    /// <summary>DataflowFlexTemplateJobStatus defines the config connector machine state of DataflowFlexTemplateJob</summary>
    [JsonPropertyName("status")]
    public V1beta1DataflowFlexTemplateJobStatus? Status { get; set; }
}