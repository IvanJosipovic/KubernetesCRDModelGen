using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataflow.gcp.m.upbound.io;
#nullable enable
/// <summary>Job is the Schema for the Jobs API. Creates a job in Dataflow according to a provided config file. Dataflow jobs are different from most other Google resources. The Dataflow resource is considered 'existing' while it is in a nonterminal state. If it reaches a terminal state (e.g. 'FAILED', 'COMPLETE', 'CANCELLED'), it will be recreated on the next 'reconcile'. This resource does not support import</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1JobList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Job>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "JobList";
    public const string KubeGroup = "dataflow.gcp.m.upbound.io";
    public const string KubePluralName = "jobs";
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
    public IList<V1beta1Job> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProvider
{
    /// <summary>List of experiments that should be used by the job. An example value is ["enable_stackdriver_agent_metrics"].</summary>
    [JsonPropertyName("additionalExperiments")]
    public IList<string>? AdditionalExperiments { get; set; }

    /// <summary>Enable/disable the use of Streaming Engine for the job. Note that Streaming Engine is enabled by default for pipelines developed against the Beam SDK for Python v2.21.0 or later when using Python 3.</summary>
    [JsonPropertyName("enableStreamingEngine")]
    public bool? EnableStreamingEngine { get; set; }

    /// <summary>The configuration for VM IPs.  Options are "WORKER_IP_PUBLIC" or "WORKER_IP_PRIVATE".</summary>
    [JsonPropertyName("ipConfiguration")]
    public string? IpConfiguration { get; set; }

    /// <summary>The name for the Cloud KMS key for the job. Key format is: projects/PROJECT_ID/locations/LOCATION/keyRings/KEY_RING/cryptoKeys/KEY</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>User labels to be specified for the job. Keys and values should follow the restrictions specified in the labeling restrictions page. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The machine type to use for the job.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The number of workers permitted to work on the job.  More workers may improve processing speed at additional cost.</summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary>A unique name for the resource, required by Dataflow.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The network to which VMs will be assigned. If it is not provided, "default" will be used.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>One of "drain" or "cancel".  See above note.</summary>
    [JsonPropertyName("onDelete")]
    public string? OnDelete { get; set; }

    /// <summary>Template specific Key/Value pairs to be forwarded to the pipeline's options; keys are case-sensitive based on the language on which the pipeline is coded, mostly Java. Note: do not configure Dataflow options here in parameters.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>The project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region in which the created job should run.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The Service Account email used to create the job. This should be just an email e.g. myserviceaccount@myproject.iam.gserviceaccount.com. Do not include any serviceAccount: or other prefix.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>See above note.</summary>
    [JsonPropertyName("skipWaitOnJobTermination")]
    public bool? SkipWaitOnJobTermination { get; set; }

    /// <summary>The subnetwork to which VMs will be assigned. Should be of the form "regions/REGION/subnetworks/SUBNETWORK". If the subnetwork is located in a Shared VPC network, you must use the complete URL. For example "googleapis.com/compute/v1/projects/PROJECT_ID/regions/REGION/subnetworks/SUBNET_NAME"</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>A writeable location on GCS for the Dataflow job to dump its temporary data.</summary>
    [JsonPropertyName("tempGcsLocation")]
    public string? TempGcsLocation { get; set; }

    /// <summary>The GCS path to the Dataflow job template.</summary>
    [JsonPropertyName("templateGcsPath")]
    public string? TemplateGcsPath { get; set; }

    /// <summary>Only applicable when updating a pipeline. Map of transform name prefixes of the job to be replaced with the corresponding name prefixes of the new job. This field is not used outside of update.</summary>
    [JsonPropertyName("transformNameMapping")]
    public IDictionary<string, string>? TransformNameMapping { get; set; }

    /// <summary>The zone in which the created job should run. If it is not provided, the provider zone is used.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProvider
{
    /// <summary>List of experiments that should be used by the job. An example value is ["enable_stackdriver_agent_metrics"].</summary>
    [JsonPropertyName("additionalExperiments")]
    public IList<string>? AdditionalExperiments { get; set; }

    /// <summary>Enable/disable the use of Streaming Engine for the job. Note that Streaming Engine is enabled by default for pipelines developed against the Beam SDK for Python v2.21.0 or later when using Python 3.</summary>
    [JsonPropertyName("enableStreamingEngine")]
    public bool? EnableStreamingEngine { get; set; }

    /// <summary>The configuration for VM IPs.  Options are "WORKER_IP_PUBLIC" or "WORKER_IP_PRIVATE".</summary>
    [JsonPropertyName("ipConfiguration")]
    public string? IpConfiguration { get; set; }

    /// <summary>The name for the Cloud KMS key for the job. Key format is: projects/PROJECT_ID/locations/LOCATION/keyRings/KEY_RING/cryptoKeys/KEY</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>User labels to be specified for the job. Keys and values should follow the restrictions specified in the labeling restrictions page. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The machine type to use for the job.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The number of workers permitted to work on the job.  More workers may improve processing speed at additional cost.</summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary>A unique name for the resource, required by Dataflow.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The network to which VMs will be assigned. If it is not provided, "default" will be used.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>One of "drain" or "cancel".  See above note.</summary>
    [JsonPropertyName("onDelete")]
    public string? OnDelete { get; set; }

    /// <summary>Template specific Key/Value pairs to be forwarded to the pipeline's options; keys are case-sensitive based on the language on which the pipeline is coded, mostly Java. Note: do not configure Dataflow options here in parameters.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>The project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region in which the created job should run.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The Service Account email used to create the job. This should be just an email e.g. myserviceaccount@myproject.iam.gserviceaccount.com. Do not include any serviceAccount: or other prefix.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>See above note.</summary>
    [JsonPropertyName("skipWaitOnJobTermination")]
    public bool? SkipWaitOnJobTermination { get; set; }

    /// <summary>The subnetwork to which VMs will be assigned. Should be of the form "regions/REGION/subnetworks/SUBNETWORK". If the subnetwork is located in a Shared VPC network, you must use the complete URL. For example "googleapis.com/compute/v1/projects/PROJECT_ID/regions/REGION/subnetworks/SUBNET_NAME"</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>A writeable location on GCS for the Dataflow job to dump its temporary data.</summary>
    [JsonPropertyName("tempGcsLocation")]
    public string? TempGcsLocation { get; set; }

    /// <summary>The GCS path to the Dataflow job template.</summary>
    [JsonPropertyName("templateGcsPath")]
    public string? TemplateGcsPath { get; set; }

    /// <summary>Only applicable when updating a pipeline. Map of transform name prefixes of the job to be replaced with the corresponding name prefixes of the new job. This field is not used outside of update.</summary>
    [JsonPropertyName("transformNameMapping")]
    public IDictionary<string, string>? TransformNameMapping { get; set; }

    /// <summary>The zone in which the created job should run. If it is not provided, the provider zone is used.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecProviderConfigRef
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
public partial class V1beta1JobSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>JobSpec defines the desired state of Job</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1JobSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1JobSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1JobSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1JobSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProvider
{
    /// <summary>List of experiments that should be used by the job. An example value is ["enable_stackdriver_agent_metrics"].</summary>
    [JsonPropertyName("additionalExperiments")]
    public IList<string>? AdditionalExperiments { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>Enable/disable the use of Streaming Engine for the job. Note that Streaming Engine is enabled by default for pipelines developed against the Beam SDK for Python v2.21.0 or later when using Python 3.</summary>
    [JsonPropertyName("enableStreamingEngine")]
    public bool? EnableStreamingEngine { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The configuration for VM IPs.  Options are "WORKER_IP_PUBLIC" or "WORKER_IP_PRIVATE".</summary>
    [JsonPropertyName("ipConfiguration")]
    public string? IpConfiguration { get; set; }

    /// <summary>The unique ID of this job.</summary>
    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }

    /// <summary>The name for the Cloud KMS key for the job. Key format is: projects/PROJECT_ID/locations/LOCATION/keyRings/KEY_RING/cryptoKeys/KEY</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>User labels to be specified for the job. Keys and values should follow the restrictions specified in the labeling restrictions page. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The machine type to use for the job.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The number of workers permitted to work on the job.  More workers may improve processing speed at additional cost.</summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary>A unique name for the resource, required by Dataflow.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The network to which VMs will be assigned. If it is not provided, "default" will be used.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>One of "drain" or "cancel".  See above note.</summary>
    [JsonPropertyName("onDelete")]
    public string? OnDelete { get; set; }

    /// <summary>Template specific Key/Value pairs to be forwarded to the pipeline's options; keys are case-sensitive based on the language on which the pipeline is coded, mostly Java. Note: do not configure Dataflow options here in parameters.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>The project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region in which the created job should run.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The Service Account email used to create the job. This should be just an email e.g. myserviceaccount@myproject.iam.gserviceaccount.com. Do not include any serviceAccount: or other prefix.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>See above note.</summary>
    [JsonPropertyName("skipWaitOnJobTermination")]
    public bool? SkipWaitOnJobTermination { get; set; }

    /// <summary>The current state of the resource, selected from the JobState enum</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The subnetwork to which VMs will be assigned. Should be of the form "regions/REGION/subnetworks/SUBNETWORK". If the subnetwork is located in a Shared VPC network, you must use the complete URL. For example "googleapis.com/compute/v1/projects/PROJECT_ID/regions/REGION/subnetworks/SUBNET_NAME"</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>A writeable location on GCS for the Dataflow job to dump its temporary data.</summary>
    [JsonPropertyName("tempGcsLocation")]
    public string? TempGcsLocation { get; set; }

    /// <summary>The GCS path to the Dataflow job template.</summary>
    [JsonPropertyName("templateGcsPath")]
    public string? TemplateGcsPath { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>Only applicable when updating a pipeline. Map of transform name prefixes of the job to be replaced with the corresponding name prefixes of the new job. This field is not used outside of update.</summary>
    [JsonPropertyName("transformNameMapping")]
    public IDictionary<string, string>? TransformNameMapping { get; set; }

    /// <summary>The type of this job, selected from the JobType enum</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The zone in which the created job should run. If it is not provided, the provider zone is used.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusConditions
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
/// <summary>JobStatus defines the observed state of Job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1JobStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1JobStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Job is the Schema for the Jobs API. Creates a job in Dataflow according to a provided config file. Dataflow jobs are different from most other Google resources. The Dataflow resource is considered 'existing' while it is in a nonterminal state. If it reaches a terminal state (e.g. 'FAILED', 'COMPLETE', 'CANCELLED'), it will be recreated on the next 'reconcile'. This resource does not support import</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Job : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1JobSpec>, IStatus<V1beta1JobStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Job";
    public const string KubeGroup = "dataflow.gcp.m.upbound.io";
    public const string KubePluralName = "jobs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>JobSpec defines the desired state of Job</summary>
    [JsonPropertyName("spec")]
    public V1beta1JobSpec Spec { get; set; }

    /// <summary>JobStatus defines the observed state of Job.</summary>
    [JsonPropertyName("status")]
    public V1beta1JobStatus? Status { get; set; }
}
#nullable disable
