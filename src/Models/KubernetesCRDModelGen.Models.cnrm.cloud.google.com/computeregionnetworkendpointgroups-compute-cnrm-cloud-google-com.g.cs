using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary>Immutable. A user-defined name of the Cloud Function. The function name is case-sensitive and must be 1-63 characters long. Example value: "func1".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRegionNetworkEndpointGroupSpecCloudFunctionFunctionRef
{
    /// <summary>Allowed value: The `name` field of a `CloudFunctionsFunction` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Only valid when networkEndpointType is "SERVERLESS". Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRegionNetworkEndpointGroupSpecCloudFunction
{
    /// <summary>Immutable. A user-defined name of the Cloud Function. The function name is case-sensitive and must be 1-63 characters long. Example value: "func1".</summary>
    [JsonPropertyName("functionRef")]
    public V1beta1ComputeRegionNetworkEndpointGroupSpecCloudFunctionFunctionRef? FunctionRef { get; set; }

    /// <summary>Immutable. A template to parse function field from a request URL. URL mask allows for routing to multiple Cloud Functions without having to create multiple Network Endpoint Groups and backend services.  For example, request URLs "mydomain.com/function1" and "mydomain.com/function2" can be backed by the same Serverless NEG with URL mask "/". The URL mask will parse them to { function = "function1" } and { function = "function2" } respectively.</summary>
    [JsonPropertyName("urlMask")]
    public string? UrlMask { get; set; }
}

/// <summary>Immutable. Cloud Run service is the main resource of Cloud Run. The service must be 1-63 characters long, and comply with RFC1035. Example value: "run-service".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRegionNetworkEndpointGroupSpecCloudRunServiceRef
{
    /// <summary>Allowed value: The `name` field of a `RunService` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Only valid when networkEndpointType is "SERVERLESS". Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRegionNetworkEndpointGroupSpecCloudRun
{
    /// <summary>Immutable. Cloud Run service is the main resource of Cloud Run. The service must be 1-63 characters long, and comply with RFC1035. Example value: "run-service".</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta1ComputeRegionNetworkEndpointGroupSpecCloudRunServiceRef? ServiceRef { get; set; }

    /// <summary>Immutable. Cloud Run tag represents the "named-revision" to provide additional fine-grained traffic routing information. The tag must be 1-63 characters long, and comply with RFC1035. Example value: "revision-0010".</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>Immutable. A template to parse service and tag fields from a request URL. URL mask allows for routing to multiple Run services without having to create multiple network endpoint groups and backend services.  For example, request URLs "foo1.domain.com/bar1" and "foo1.domain.com/bar2" an be backed by the same Serverless Network Endpoint Group (NEG) with URL mask ".domain.com/". The URL mask will parse them to { service="bar1", tag="foo1" } and { service="bar2", tag="foo2" } respectively.</summary>
    [JsonPropertyName("urlMask")]
    public string? UrlMask { get; set; }
}

/// <summary>Immutable. This field is only used for PSC. The URL of the network to which all network endpoints in the NEG belong. Uses "default" project network if unspecified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRegionNetworkEndpointGroupSpecNetworkRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. This field is only used for PSC. Optional URL of the subnetwork to which all network endpoints in the NEG belong.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRegionNetworkEndpointGroupSpecSubnetworkRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRegionNetworkEndpointGroupSpec
{
    /// <summary>Immutable. Only valid when networkEndpointType is "SERVERLESS". Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.</summary>
    [JsonPropertyName("cloudFunction")]
    public V1beta1ComputeRegionNetworkEndpointGroupSpecCloudFunction? CloudFunction { get; set; }

    /// <summary>Immutable. Only valid when networkEndpointType is "SERVERLESS". Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.</summary>
    [JsonPropertyName("cloudRun")]
    public V1beta1ComputeRegionNetworkEndpointGroupSpecCloudRun? CloudRun { get; set; }

    /// <summary>Immutable. An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. Type of network endpoints in this network endpoint group. Defaults to SERVERLESS Default value: "SERVERLESS" Possible values: ["SERVERLESS", "PRIVATE_SERVICE_CONNECT"].</summary>
    [JsonPropertyName("networkEndpointType")]
    public string? NetworkEndpointType { get; set; }

    /// <summary>Immutable. This field is only used for PSC. The URL of the network to which all network endpoints in the NEG belong. Uses "default" project network if unspecified.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ComputeRegionNetworkEndpointGroupSpecNetworkRef? NetworkRef { get; set; }

    /// <summary>Immutable. The target service url used to set up private service connection to a Google API or a PSC Producer Service Attachment.</summary>
    [JsonPropertyName("pscTargetService")]
    public string? PscTargetService { get; set; }

    /// <summary>Immutable. A reference to the region where the Serverless NEGs Reside.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. This field is only used for PSC. Optional URL of the subnetwork to which all network endpoints in the NEG belong.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1ComputeRegionNetworkEndpointGroupSpecSubnetworkRef? SubnetworkRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRegionNetworkEndpointGroupStatusConditions
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
public partial class V1beta1ComputeRegionNetworkEndpointGroupStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeRegionNetworkEndpointGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeRegionNetworkEndpointGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeRegionNetworkEndpointGroupSpec>, IStatus<V1beta1ComputeRegionNetworkEndpointGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeRegionNetworkEndpointGroup";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeregionnetworkendpointgroups";
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
    public V1beta1ComputeRegionNetworkEndpointGroupSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeRegionNetworkEndpointGroupStatus? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeRegionNetworkEndpointGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeRegionNetworkEndpointGroup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeRegionNetworkEndpointGroupList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeregionnetworkendpointgroups";
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
    public IList<V1beta1ComputeRegionNetworkEndpointGroup> Items { get; set; }
}