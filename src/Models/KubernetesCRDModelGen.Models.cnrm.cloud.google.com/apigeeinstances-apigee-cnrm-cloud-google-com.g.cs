using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigee.cnrm.cloud.google.com;
/// <summary>Optional. Access logging configuration enables the access logging feature at the instance. Apigee customers can enable access logging to ship the access logs to their own project's cloud logging.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeInstanceSpecAccessLoggingConfig
{
    /// <summary>Optional. Boolean flag that specifies whether the customer access log feature is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional. Ship the access log entries that match the status_code defined in the filter. The status_code is the only expected/supported filter field. (Ex: status_code) The filter will parse it to the Common Expression Language semantics for expression evaluation to build the filter condition. (Ex: "filter": status_code &gt;= 200 &amp;&amp; status_code &lt; 300 )</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }
}

/// <summary>Customer Managed Encryption Key (CMEK) used for disk and volume encryption. If not specified, a Google-Managed encryption key will be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeInstanceSpecDiskEncryptionKMSCryptoKeyRef
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

/// <summary>Reference to parent Apigee Organization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeInstanceSpecOrganizationRef
{
    /// <summary>A reference to an externally managed ApigeeOrganization resource. Should be in the format "organizations/{{organizationID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ApigeeOrganization resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ApigeeOrganization resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ApigeeInstanceSpec defines the desired state of ApigeeInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeInstanceSpec
{
    /// <summary>Optional. Access logging configuration enables the access logging feature at the instance. Apigee customers can enable access logging to ship the access logs to their own project's cloud logging.</summary>
    [JsonPropertyName("accessLoggingConfig")]
    public V1beta1ApigeeInstanceSpecAccessLoggingConfig? AccessLoggingConfig { get; set; }

    /// <summary>Optional. Customer accept list represents the list of projects (id/number) on customer side that can privately connect to the service attachment. It is an optional field which the customers can provide during the instance creation. By default, the customer project associated with the Apigee organization will be included to the list.</summary>
    [JsonPropertyName("consumerAcceptList")]
    public IList<string>? ConsumerAcceptList { get; set; }

    /// <summary>Optional. Description of the instance.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Customer Managed Encryption Key (CMEK) used for disk and volume encryption. If not specified, a Google-Managed encryption key will be used.</summary>
    [JsonPropertyName("diskEncryptionKMSCryptoKeyRef")]
    public V1beta1ApigeeInstanceSpecDiskEncryptionKMSCryptoKeyRef? DiskEncryptionKMSCryptoKeyRef { get; set; }

    /// <summary>Optional. Display name for the instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. Comma-separated list of CIDR blocks of length 22 and/or 28 used to create the Apigee instance. Providing CIDR ranges is optional. You can provide just /22 or /28 or both (or neither). Ranges you provide should be freely available as part of a larger named range you have allocated to the Service Networking peering. If this parameter is not provided, Apigee automatically requests an available /22 and /28 CIDR block from Service Networking. Use the /22 CIDR block for configuring your firewall needs to allow traffic from Apigee. Input formats: `a.b.c.d/22` or `e.f.g.h/28` or `a.b.c.d/22,e.f.g.h/28`</summary>
    [JsonPropertyName("ipRange")]
    public string? IpRange { get; set; }

    /// <summary>Required. Compute Engine location where the instance resides.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Reference to parent Apigee Organization.</summary>
    [JsonPropertyName("organizationRef")]
    public V1beta1ApigeeInstanceSpecOrganizationRef OrganizationRef { get; set; }

    /// <summary>Optional. Size of the CIDR block range that will be reserved by the instance. PAID organizations support `SLASH_16` to `SLASH_20` and defaults to `SLASH_16`. Evaluation organizations support only `SLASH_23`.</summary>
    [JsonPropertyName("peeringCIDRRange")]
    public string? PeeringCIDRRange { get; set; }

    /// <summary>The ApigeeInstance name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeInstanceStatusConditions
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeInstanceStatusObservedState
{
    /// <summary>Output only. Time the instance was created in milliseconds since epoch.</summary>
    [JsonPropertyName("createdAt")]
    public long? CreatedAt { get; set; }

    /// <summary>Output only. Internal hostname or IP address of the Apigee endpoint used by clients to connect to the service.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Output only. Time the instance was last modified in milliseconds since epoch.</summary>
    [JsonPropertyName("lastModifiedAt")]
    public long? LastModifiedAt { get; set; }

    /// <summary>Output only. Port number of the exposed Apigee endpoint.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Output only. Version of the runtime system running in the instance. The runtime system is the set of components that serve the API Proxy traffic in your Environments.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>Output only. Resource name of the service attachment created for the instance in the format: `projects/{{project-id}}/regions/{{region-id}}/serviceAttachments/{{service-attachment-id}}` Apigee customers can privately forward traffic to this service attachment using the PSC endpoints.</summary>
    [JsonPropertyName("serviceAttachment")]
    public string? ServiceAttachment { get; set; }

    /// <summary>Output only. State of the instance. Values other than `ACTIVE` means the resource is not ready to use.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>ApigeeInstanceStatus defines the config connector machine state of ApigeeInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeInstanceStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ApigeeInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ApigeeInstance resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1ApigeeInstanceStatusObservedState? ObservedState { get; set; }
}

/// <summary>ApigeeInstance is the Schema for the ApigeeInstance API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ApigeeInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ApigeeInstanceSpec>, IStatus<V1beta1ApigeeInstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ApigeeInstance";
    public const string KubeGroup = "apigee.cnrm.cloud.google.com";
    public const string KubePluralName = "apigeeinstances";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ApigeeInstanceSpec defines the desired state of ApigeeInstance</summary>
    [JsonPropertyName("spec")]
    public V1beta1ApigeeInstanceSpec Spec { get; set; }

    /// <summary>ApigeeInstanceStatus defines the config connector machine state of ApigeeInstance</summary>
    [JsonPropertyName("status")]
    public V1beta1ApigeeInstanceStatus? Status { get; set; }
}

/// <summary>ApigeeInstance is the Schema for the ApigeeInstance API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ApigeeInstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ApigeeInstance>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ApigeeInstanceList";
    public const string KubeGroup = "apigee.cnrm.cloud.google.com";
    public const string KubePluralName = "apigeeinstances";
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
    public IList<V1beta1ApigeeInstance> Items { get; set; }
}