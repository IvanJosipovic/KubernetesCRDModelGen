using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datafusion.cnrm.cloud.google.com;
/// <summary></summary>
public partial class V1beta1DataFusionInstanceSpecDataprocServiceAccountRef
{
    /// <summary>User-managed service account to set on Dataproc when Cloud Data Fusion creates Dataproc to run data processing pipelines. This allows users to have fine-grained access control on Dataproc's accesses to cloud resources.  Allowed value: The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable.</summary>
public partial class V1beta1DataFusionInstanceSpecNetworkConfigNetworkRef
{
    /// <summary>Name of the network in the customer project with which the Tenant Project will be peered for executing pipelines. In case of shared VPC where the network resides in another host project the network should specified in the form of projects/{host-project-id}/global/networks/{network}  Allowed value: The Google Cloud resource name of a `ComputeNetwork` resource (format: `projects/{{project}}/global/networks/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Network configuration options. These are required when a private Data Fusion instance is to be created.</summary>
public partial class V1beta1DataFusionInstanceSpecNetworkConfig
{
    /// <summary>Immutable. The IP range in CIDR notation to use for the managed Data Fusion instance nodes. This range must not overlap with any other ranges used in the customer network.</summary>
    [JsonPropertyName("ipAllocation")]
    public string? IpAllocation { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1DataFusionInstanceSpecNetworkConfigNetworkRef? NetworkRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1DataFusionInstanceSpec
{
    /// <summary></summary>
    [JsonPropertyName("dataprocServiceAccountRef")]
    public V1beta1DataFusionInstanceSpecDataprocServiceAccountRef? DataprocServiceAccountRef { get; set; }

    /// <summary>Immutable. A description of this instance.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. Display name for an instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Option to enable Stackdriver Logging.</summary>
    [JsonPropertyName("enableStackdriverLogging")]
    public bool? EnableStackdriverLogging { get; set; }

    /// <summary>Option to enable Stackdriver Monitoring.</summary>
    [JsonPropertyName("enableStackdriverMonitoring")]
    public bool? EnableStackdriverMonitoring { get; set; }

    /// <summary>Immutable. The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. Network configuration options. These are required when a private Data Fusion instance is to be created.</summary>
    [JsonPropertyName("networkConfig")]
    public V1beta1DataFusionInstanceSpecNetworkConfig? NetworkConfig { get; set; }

    /// <summary>Immutable. Map of additional options used to configure the behavior of Data Fusion instance.</summary>
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    /// <summary>Immutable. Specifies whether the Data Fusion instance should be private. If set to true, all Data Fusion nodes will have private IP addresses and will not be able to access the public internet.</summary>
    [JsonPropertyName("privateInstance")]
    public bool? PrivateInstance { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Required. Instance type. Possible values: TYPE_UNSPECIFIED, BASIC, ENTERPRISE, DEVELOPER</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>Current version of the Data Fusion.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Immutable. Name of the zone in which the Data Fusion instance will be created. Only DEVELOPER instances use this field.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary></summary>
public partial class V1beta1DataFusionInstanceStatusAvailableVersion
{
    /// <summary>Represents a list of available feature names for a given version.</summary>
    [JsonPropertyName("availableFeatures")]
    public IList<string>? AvailableFeatures { get; set; }

    /// <summary>Whether this is currently the default version for Cloud Data Fusion</summary>
    [JsonPropertyName("defaultVersion")]
    public bool? DefaultVersion { get; set; }

    /// <summary>The version number of the Data Fusion instance, such as '6.0.1.0'.</summary>
    [JsonPropertyName("versionNumber")]
    public string? VersionNumber { get; set; }
}

/// <summary></summary>
public partial class V1beta1DataFusionInstanceStatusConditions
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
public partial class V1beta1DataFusionInstanceStatus
{
    /// <summary>Output only. Endpoint on which the REST APIs is accessible.</summary>
    [JsonPropertyName("apiEndpoint")]
    public string? ApiEndpoint { get; set; }

    /// <summary>Available versions that the instance can be upgraded to.</summary>
    [JsonPropertyName("availableVersion")]
    public IList<V1beta1DataFusionInstanceStatusAvailableVersion>? AvailableVersion { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DataFusionInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The time the instance was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Cloud Storage bucket generated by Data Fusion in the customer project.</summary>
    [JsonPropertyName("gcsBucket")]
    public string? GcsBucket { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. P4 service account for the customer project.</summary>
    [JsonPropertyName("p4ServiceAccount")]
    public string? P4ServiceAccount { get; set; }

    /// <summary>Output only. Endpoint on which the Data Fusion UI is accessible.</summary>
    [JsonPropertyName("serviceEndpoint")]
    public string? ServiceEndpoint { get; set; }

    /// <summary>Output only. The current state of this Data Fusion instance. Possible values: STATE_UNSPECIFIED, ENABLED, DISABLED, UNKNOWN</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Additional information about the current state of this Data Fusion instance if available.</summary>
    [JsonPropertyName("stateMessage")]
    public string? StateMessage { get; set; }

    /// <summary>Output only. The name of the tenant project.</summary>
    [JsonPropertyName("tenantProjectId")]
    public string? TenantProjectId { get; set; }

    /// <summary>Output only. The time the instance was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1beta1DataFusionInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DataFusionInstanceSpec>, IStatus<V1beta1DataFusionInstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataFusionInstance";
    public const string KubeGroup = "datafusion.cnrm.cloud.google.com";
    public const string KubePluralName = "datafusioninstances";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1DataFusionInstanceSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1DataFusionInstanceStatus? Status { get; set; }
}