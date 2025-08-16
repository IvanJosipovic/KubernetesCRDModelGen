using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networkmanagement.cnrm.cloud.google.com;
/// <summary>NetworkManagementConnectivityTest is the Schema for the NetworkManagementConnectivityTest API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkManagementConnectivityTestList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1NetworkManagementConnectivityTest>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkManagementConnectivityTestList";
    public const string KubeGroup = "networkmanagement.cnrm.cloud.google.com";
    public const string KubePluralName = "networkmanagementconnectivitytests";
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
    public IList<V1alpha1NetworkManagementConnectivityTest> Items { get; set; }
}

/// <summary>An [App Engine](https://cloud.google.com/appengine) [service version](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecDestinationAppEngineVersion
{
    /// <summary>An [App Engine](https://cloud.google.com/appengine) [service version](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions) name.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A [Cloud Function](https://cloud.google.com/functions).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecDestinationCloudFunction
{
    /// <summary>A [Cloud Function](https://cloud.google.com/functions) name.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A [Cloud Run](https://cloud.google.com/run) [revision](https://cloud.google.com/run/docs/reference/rest/v1/namespaces.revisions/get) URI. The format is: projects/{project}/locations/{location}/revisions/{revision}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecDestinationCloudRunRevisionRunRevisionRef
{
    /// <summary>A reference to an externally managed RunRevision resource. Should be in the format "projects/{{project}}/locations/{{location}}/revisions/{{revision}}".</summary>
    [JsonPropertyName("external")]
    public string External { get; set; }
}

/// <summary>A [Cloud Run](https://cloud.google.com/run) [revision](https://cloud.google.com/run/docs/reference/rest/v1/namespaces.revisions/get)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecDestinationCloudRunRevision
{
    /// <summary>A [Cloud Run](https://cloud.google.com/run) [revision](https://cloud.google.com/run/docs/reference/rest/v1/namespaces.revisions/get) URI. The format is: projects/{project}/locations/{location}/revisions/{revision}</summary>
    [JsonPropertyName("runRevisionRef")]
    public V1alpha1NetworkManagementConnectivityTestSpecDestinationCloudRunRevisionRunRevisionRef? RunRevisionRef { get; set; }
}

/// <summary>A Compute Engine instance URI.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecDestinationComputeInstanceRef
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

/// <summary>A Compute Engine network URI.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecDestinationComputeNetworkRef
{
    /// <summary>A reference to an externally managed Compute Network resource. Should be in the format `projects/{{projectID}}/global/networks/{{network}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>A cluster URI for [Google Kubernetes Engine cluster control plane](https://cloud.google.com/kubernetes-engine/docs/concepts/cluster-architecture).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecDestinationContainerClusterRef
{
    /// <summary>The GKE cluster. Valid formats: `projects/{projectID}/locations/{location}/clusters/{clusterID}` `projects/{projectID}/zones/{zone}/clusters/{clusterID}`</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the project resource. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names */</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the project resource. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/ */</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Project ID where the endpoint is located. The Project ID can be derived from the URI if you provide a VM instance or network URI. The following are two cases where you must provide the project ID: 1. Only the IP address is specified, and the IP address is within a Google Cloud project. 2. When you are using Shared VPC and the IP address that you provide is from the service project. In this case, the network that the IP address resides in is defined in the host project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecDestinationProjectRef
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

/// <summary>A [Cloud SQL](https://cloud.google.com/sql) instance URI.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecDestinationSqlInstance
{
    /// <summary>The SQLInstance selfLink, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SQLInstance` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `SQLInstance` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. Destination specification of the Connectivity Test.   You can use a combination of destination IP address, Compute Engine  VM instance, or VPC network to uniquely identify the destination  location.   Even if the destination IP address is not unique, the source IP  location is unique. Usually, the analysis can infer the destination  endpoint from route information.   If the destination you specify is a VM instance and the instance has  multiple network interfaces, then you must also specify either  a destination IP address  or VPC network to identify the destination  interface.   A reachability analysis proceeds even if the destination location is  ambiguous. However, the result can include endpoints that you don't  intend to test.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecDestination
{
    /// <summary>An [App Engine](https://cloud.google.com/appengine) [service version](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions).</summary>
    [JsonPropertyName("appEngineVersion")]
    public V1alpha1NetworkManagementConnectivityTestSpecDestinationAppEngineVersion? AppEngineVersion { get; set; }

    /// <summary>A [Cloud Function](https://cloud.google.com/functions).</summary>
    [JsonPropertyName("cloudFunction")]
    public V1alpha1NetworkManagementConnectivityTestSpecDestinationCloudFunction? CloudFunction { get; set; }

    /// <summary>A [Cloud Run](https://cloud.google.com/run) [revision](https://cloud.google.com/run/docs/reference/rest/v1/namespaces.revisions/get)</summary>
    [JsonPropertyName("cloudRunRevision")]
    public V1alpha1NetworkManagementConnectivityTestSpecDestinationCloudRunRevision? CloudRunRevision { get; set; }

    /// <summary>A forwarding rule and its corresponding IP address represent the frontend configuration of a Google Cloud load balancer. Forwarding rules are also used for protocol forwarding, Private Service Connect and other network services to provide forwarding information in the control plane. Format: projects/{project}/global/forwardingRules/{id} or projects/{project}/regions/{region}/forwardingRules/{id}</summary>
    [JsonPropertyName("computeForwardingRuleRef")]
    public string? ComputeForwardingRuleRef { get; set; }

    /// <summary>A Compute Engine instance URI.</summary>
    [JsonPropertyName("computeInstanceRef")]
    public V1alpha1NetworkManagementConnectivityTestSpecDestinationComputeInstanceRef? ComputeInstanceRef { get; set; }

    /// <summary>A Compute Engine network URI.</summary>
    [JsonPropertyName("computeNetworkRef")]
    public V1alpha1NetworkManagementConnectivityTestSpecDestinationComputeNetworkRef? ComputeNetworkRef { get; set; }

    /// <summary>A cluster URI for [Google Kubernetes Engine cluster control plane](https://cloud.google.com/kubernetes-engine/docs/concepts/cluster-architecture).</summary>
    [JsonPropertyName("containerClusterRef")]
    public V1alpha1NetworkManagementConnectivityTestSpecDestinationContainerClusterRef? ContainerClusterRef { get; set; }

    /// <summary>DNS endpoint of [Google Kubernetes Engine cluster control plane](https://cloud.google.com/kubernetes-engine/docs/concepts/cluster-architecture). Requires gke_master_cluster to be set, can't be used simultaneoulsly with ip_address or network. Applicable only to destination endpoint.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>The IP address of the endpoint, which can be an external or internal IP.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>Type of the network where the endpoint is located. Applicable only to source endpoint, as destination network type can be inferred from the source.</summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>The IP protocol port of the endpoint. Only applicable when protocol is TCP or UDP.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Project ID where the endpoint is located. The Project ID can be derived from the URI if you provide a VM instance or network URI. The following are two cases where you must provide the project ID: 1. Only the IP address is specified, and the IP address is within a Google Cloud project. 2. When you are using Shared VPC and the IP address that you provide is from the service project. In this case, the network that the IP address resides in is defined in the host project.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1NetworkManagementConnectivityTestSpecDestinationProjectRef? ProjectRef { get; set; }

    /// <summary>A [Redis Cluster](https://cloud.google.com/memorystore/docs/cluster) URI.</summary>
    [JsonPropertyName("redisCluster")]
    public string? RedisCluster { get; set; }

    /// <summary>A [Redis Instance](https://cloud.google.com/memorystore/docs/redis) URI.</summary>
    [JsonPropertyName("redisInstance")]
    public string? RedisInstance { get; set; }

    /// <summary>A [Cloud SQL](https://cloud.google.com/sql) instance URI.</summary>
    [JsonPropertyName("sqlInstance")]
    public V1alpha1NetworkManagementConnectivityTestSpecDestinationSqlInstance? SqlInstance { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecProjectRef
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

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecRelatedProjects
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

/// <summary>An [App Engine](https://cloud.google.com/appengine) [service version](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecSourceAppEngineVersion
{
    /// <summary>An [App Engine](https://cloud.google.com/appengine) [service version](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions) name.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A [Cloud Function](https://cloud.google.com/functions).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecSourceCloudFunction
{
    /// <summary>A [Cloud Function](https://cloud.google.com/functions) name.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A [Cloud Run](https://cloud.google.com/run) [revision](https://cloud.google.com/run/docs/reference/rest/v1/namespaces.revisions/get) URI. The format is: projects/{project}/locations/{location}/revisions/{revision}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecSourceCloudRunRevisionRunRevisionRef
{
    /// <summary>A reference to an externally managed RunRevision resource. Should be in the format "projects/{{project}}/locations/{{location}}/revisions/{{revision}}".</summary>
    [JsonPropertyName("external")]
    public string External { get; set; }
}

/// <summary>A [Cloud Run](https://cloud.google.com/run) [revision](https://cloud.google.com/run/docs/reference/rest/v1/namespaces.revisions/get)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecSourceCloudRunRevision
{
    /// <summary>A [Cloud Run](https://cloud.google.com/run) [revision](https://cloud.google.com/run/docs/reference/rest/v1/namespaces.revisions/get) URI. The format is: projects/{project}/locations/{location}/revisions/{revision}</summary>
    [JsonPropertyName("runRevisionRef")]
    public V1alpha1NetworkManagementConnectivityTestSpecSourceCloudRunRevisionRunRevisionRef? RunRevisionRef { get; set; }
}

/// <summary>A Compute Engine instance URI.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecSourceComputeInstanceRef
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

/// <summary>A Compute Engine network URI.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecSourceComputeNetworkRef
{
    /// <summary>A reference to an externally managed Compute Network resource. Should be in the format `projects/{{projectID}}/global/networks/{{network}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>A cluster URI for [Google Kubernetes Engine cluster control plane](https://cloud.google.com/kubernetes-engine/docs/concepts/cluster-architecture).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecSourceContainerClusterRef
{
    /// <summary>The GKE cluster. Valid formats: `projects/{projectID}/locations/{location}/clusters/{clusterID}` `projects/{projectID}/zones/{zone}/clusters/{clusterID}`</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the project resource. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names */</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the project resource. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/ */</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Project ID where the endpoint is located. The Project ID can be derived from the URI if you provide a VM instance or network URI. The following are two cases where you must provide the project ID: 1. Only the IP address is specified, and the IP address is within a Google Cloud project. 2. When you are using Shared VPC and the IP address that you provide is from the service project. In this case, the network that the IP address resides in is defined in the host project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecSourceProjectRef
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

/// <summary>A [Cloud SQL](https://cloud.google.com/sql) instance URI.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecSourceSqlInstance
{
    /// <summary>The SQLInstance selfLink, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SQLInstance` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `SQLInstance` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. Source specification of the Connectivity Test.   You can use a combination of source IP address, virtual machine  (VM) instance, or Compute Engine network to uniquely identify  the source location.   Examples:  If the source IP address is an internal IP address within a Google Cloud  Virtual Private Cloud (VPC) network, then you must also specify the VPC  network. Otherwise, specify the VM instance, which already contains its  internal IP address and VPC network information.   If the source of the test is within an on-premises network, then you must  provide the destination VPC network.   If the source endpoint is a Compute Engine VM instance with multiple  network interfaces, the instance itself is not sufficient to identify the  endpoint. So, you must also specify the source IP address or VPC network.   A reachability analysis proceeds even if the source location is  ambiguous. However, the test result may include endpoints that you don't  intend to test.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpecSource
{
    /// <summary>An [App Engine](https://cloud.google.com/appengine) [service version](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions).</summary>
    [JsonPropertyName("appEngineVersion")]
    public V1alpha1NetworkManagementConnectivityTestSpecSourceAppEngineVersion? AppEngineVersion { get; set; }

    /// <summary>A [Cloud Function](https://cloud.google.com/functions).</summary>
    [JsonPropertyName("cloudFunction")]
    public V1alpha1NetworkManagementConnectivityTestSpecSourceCloudFunction? CloudFunction { get; set; }

    /// <summary>A [Cloud Run](https://cloud.google.com/run) [revision](https://cloud.google.com/run/docs/reference/rest/v1/namespaces.revisions/get)</summary>
    [JsonPropertyName("cloudRunRevision")]
    public V1alpha1NetworkManagementConnectivityTestSpecSourceCloudRunRevision? CloudRunRevision { get; set; }

    /// <summary>A forwarding rule and its corresponding IP address represent the frontend configuration of a Google Cloud load balancer. Forwarding rules are also used for protocol forwarding, Private Service Connect and other network services to provide forwarding information in the control plane. Format: projects/{project}/global/forwardingRules/{id} or projects/{project}/regions/{region}/forwardingRules/{id}</summary>
    [JsonPropertyName("computeForwardingRuleRef")]
    public string? ComputeForwardingRuleRef { get; set; }

    /// <summary>A Compute Engine instance URI.</summary>
    [JsonPropertyName("computeInstanceRef")]
    public V1alpha1NetworkManagementConnectivityTestSpecSourceComputeInstanceRef? ComputeInstanceRef { get; set; }

    /// <summary>A Compute Engine network URI.</summary>
    [JsonPropertyName("computeNetworkRef")]
    public V1alpha1NetworkManagementConnectivityTestSpecSourceComputeNetworkRef? ComputeNetworkRef { get; set; }

    /// <summary>A cluster URI for [Google Kubernetes Engine cluster control plane](https://cloud.google.com/kubernetes-engine/docs/concepts/cluster-architecture).</summary>
    [JsonPropertyName("containerClusterRef")]
    public V1alpha1NetworkManagementConnectivityTestSpecSourceContainerClusterRef? ContainerClusterRef { get; set; }

    /// <summary>DNS endpoint of [Google Kubernetes Engine cluster control plane](https://cloud.google.com/kubernetes-engine/docs/concepts/cluster-architecture). Requires gke_master_cluster to be set, can't be used simultaneoulsly with ip_address or network. Applicable only to destination endpoint.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>The IP address of the endpoint, which can be an external or internal IP.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>Type of the network where the endpoint is located. Applicable only to source endpoint, as destination network type can be inferred from the source.</summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>The IP protocol port of the endpoint. Only applicable when protocol is TCP or UDP.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Project ID where the endpoint is located. The Project ID can be derived from the URI if you provide a VM instance or network URI. The following are two cases where you must provide the project ID: 1. Only the IP address is specified, and the IP address is within a Google Cloud project. 2. When you are using Shared VPC and the IP address that you provide is from the service project. In this case, the network that the IP address resides in is defined in the host project.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1NetworkManagementConnectivityTestSpecSourceProjectRef? ProjectRef { get; set; }

    /// <summary>A [Redis Cluster](https://cloud.google.com/memorystore/docs/cluster) URI.</summary>
    [JsonPropertyName("redisCluster")]
    public string? RedisCluster { get; set; }

    /// <summary>A [Redis Instance](https://cloud.google.com/memorystore/docs/redis) URI.</summary>
    [JsonPropertyName("redisInstance")]
    public string? RedisInstance { get; set; }

    /// <summary>A [Cloud SQL](https://cloud.google.com/sql) instance URI.</summary>
    [JsonPropertyName("sqlInstance")]
    public V1alpha1NetworkManagementConnectivityTestSpecSourceSqlInstance? SqlInstance { get; set; }
}

/// <summary>NetworkManagementConnectivityTestSpec defines the desired state of NetworkManagementConnectivityTest</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestSpec
{
    /// <summary>Whether the test should skip firewall checking. If not provided, we assume false.</summary>
    [JsonPropertyName("bypassFirewallChecks")]
    public bool? BypassFirewallChecks { get; set; }

    /// <summary>The user-supplied description of the Connectivity Test. Maximum of 512 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. Destination specification of the Connectivity Test.   You can use a combination of destination IP address, Compute Engine  VM instance, or VPC network to uniquely identify the destination  location.   Even if the destination IP address is not unique, the source IP  location is unique. Usually, the analysis can infer the destination  endpoint from route information.   If the destination you specify is a VM instance and the instance has  multiple network interfaces, then you must also specify either  a destination IP address  or VPC network to identify the destination  interface.   A reachability analysis proceeds even if the destination location is  ambiguous. However, the result can include endpoints that you don't  intend to test.</summary>
    [JsonPropertyName("destination")]
    public V1alpha1NetworkManagementConnectivityTestSpecDestination Destination { get; set; }

    /// <summary>Resource labels to represent user-provided metadata.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Immutable. The name of the location where the RuntimeTemplate will be created.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1NetworkManagementConnectivityTestSpecProjectRef ProjectRef { get; set; }

    /// <summary>IP Protocol of the test. When not provided, "TCP" is assumed.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Other projects that may be relevant for reachability analysis. This is applicable to scenarios where a test can cross project boundaries.</summary>
    [JsonPropertyName("relatedProjects")]
    public IList<V1alpha1NetworkManagementConnectivityTestSpecRelatedProjects>? RelatedProjects { get; set; }

    /// <summary>The NetworkManagementConnectivityTest name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Whether run analysis for the return path from destination to source. Default value is false.</summary>
    [JsonPropertyName("roundTrip")]
    public bool? RoundTrip { get; set; }

    /// <summary>Required. Source specification of the Connectivity Test.   You can use a combination of source IP address, virtual machine  (VM) instance, or Compute Engine network to uniquely identify  the source location.   Examples:  If the source IP address is an internal IP address within a Google Cloud  Virtual Private Cloud (VPC) network, then you must also specify the VPC  network. Otherwise, specify the VM instance, which already contains its  internal IP address and VPC network information.   If the source of the test is within an on-premises network, then you must  provide the destination VPC network.   If the source endpoint is a Compute Engine VM instance with multiple  network interfaces, the instance itself is not sufficient to identify the  endpoint. So, you must also specify the source IP address or VPC network.   A reachability analysis proceeds even if the source location is  ambiguous. However, the test result may include endpoints that you don't  intend to test.</summary>
    [JsonPropertyName("source")]
    public V1alpha1NetworkManagementConnectivityTestSpecSource Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusConditions
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

/// <summary>Destination specification of the Connectivity Test.   You can use a combination of destination IP address, Compute Engine  VM instance, or VPC network to uniquely identify the destination  location.   Even if the destination IP address is not unique, the source IP  location is unique. Usually, the analysis can infer the destination  endpoint from route information.   If the destination you specify is a VM instance and the instance has  multiple network interfaces, then you must also specify either  a destination IP address  or VPC network to identify the destination  interface.   A reachability analysis proceeds even if the destination location is  ambiguous. However, the result can include endpoints that you don't  intend to test.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateDestination
{
    /// <summary>Output only. Specifies the type of the target of the forwarding rule.</summary>
    [JsonPropertyName("forwardingRuleTarget")]
    public string? ForwardingRuleTarget { get; set; }

    /// <summary>Output only. ID of the load balancer the forwarding rule points to. Empty for forwarding rules not related to load balancers.</summary>
    [JsonPropertyName("loadBalancerID")]
    public string? LoadBalancerID { get; set; }

    /// <summary>Output only. Type of the load balancer the forwarding rule points to.</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }
}

/// <summary>The EdgeLocation from which a packet destined for/originating from the internet will egress/ingress the Google network. This will only be populated for a connectivity test which has an internet destination/source address. The absence of this field *must not* be used as an indication that the destination/source is part of the Google network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateProbingDetailsDestinationEgressLocation
{
    /// <summary>Name of the metropolitan area.</summary>
    [JsonPropertyName("metropolitanArea")]
    public string? MetropolitanArea { get; set; }
}

/// <summary>The source and destination endpoints derived from the test input and used for active probing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateProbingDetailsEndpointInfo
{
    /// <summary>Destination IP address.</summary>
    [JsonPropertyName("destinationIP")]
    public string? DestinationIP { get; set; }

    /// <summary>URI of the network where this packet is sent to.</summary>
    [JsonPropertyName("destinationNetworkURI")]
    public string? DestinationNetworkURI { get; set; }

    /// <summary>Destination port. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("destinationPort")]
    public int? DestinationPort { get; set; }

    /// <summary>IP protocol in string format, for example: "TCP", "UDP", "ICMP".</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>URI of the source telemetry agent this packet originates from.</summary>
    [JsonPropertyName("sourceAgentURI")]
    public string? SourceAgentURI { get; set; }

    /// <summary>Source IP address.</summary>
    [JsonPropertyName("sourceIP")]
    public string? SourceIP { get; set; }

    /// <summary>URI of the network where this packet originates from.</summary>
    [JsonPropertyName("sourceNetworkURI")]
    public string? SourceNetworkURI { get; set; }

    /// <summary>Source port. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("sourcePort")]
    public int? SourcePort { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateProbingDetailsErrorDetails
{
    /// <summary>A URL/resource name that uniquely identifies the type of the serialized  protocol buffer message. This string must contain at least  one "/" character. The last segment of the URL's path must represent  the fully qualified name of the type (as in  `path/google.protobuf.Duration`). The name should be in a canonical form  (e.g., leading "." is not accepted).   In practice, teams usually precompile into the binary all types that they  expect it to use in the context of Any. However, for URLs which use the  scheme `http`, `https`, or no scheme, one can optionally set up a type  server that maps type URLs to message definitions as follows:   * If no scheme is provided, `https` is assumed.  * An HTTP GET on the URL must yield a [google.protobuf.Type][]    value in binary format, or produce an error.  * Applications are allowed to cache lookup results based on the    URL, or have them precompiled into a binary to avoid any    lookup. Therefore, binary compatibility needs to be preserved    on changes to types. (Use versioned type names to manage    breaking changes.)   Note: this functionality is not currently available in the official  protobuf release, and it is not used for type URLs beginning with  type.googleapis.com.   Schemes other than `http`, `https` (or the empty scheme) might be  used with implementation specific semantics.</summary>
    [JsonPropertyName("typeURL")]
    public string? TypeURL { get; set; }

    /// <summary>Must be a valid serialized protocol buffer of the above specified type.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Details about an internal failure or the cancellation of active probing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateProbingDetailsError
{
    /// <summary>The status code, which should be an enum value of [google.rpc.Code][google.rpc.Code].</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>A list of messages that carry the error details.  There is a common set of message types for APIs to use.</summary>
    [JsonPropertyName("details")]
    public IList<V1alpha1NetworkManagementConnectivityTestStatusObservedStateProbingDetailsErrorDetails>? Details { get; set; }

    /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should be localized and sent in the [google.rpc.Status.details][google.rpc.Status.details] field, or localized by the client.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateProbingDetailsProbingLatencyLatencyPercentiles
{
    /// <summary>percent-th percentile of latency observed, in microseconds. Fraction of percent/100 of samples have latency lower or equal to the value of this field.</summary>
    [JsonPropertyName("latencyMicros")]
    public long? LatencyMicros { get; set; }

    /// <summary>Percentage of samples this data point applies to.</summary>
    [JsonPropertyName("percent")]
    public int? Percent { get; set; }
}

/// <summary>Latency as measured by active probing in one direction: from the source to the destination endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateProbingDetailsProbingLatency
{
    /// <summary>Representative latency percentiles.</summary>
    [JsonPropertyName("latencyPercentiles")]
    public IList<V1alpha1NetworkManagementConnectivityTestStatusObservedStateProbingDetailsProbingLatencyLatencyPercentiles>? LatencyPercentiles { get; set; }
}

/// <summary>Output only. The probing details of this test from the latest run, present for applicable tests only. The details are updated when creating a new test, updating an existing test, or triggering a one-time rerun of an existing test.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateProbingDetails
{
    /// <summary>The reason probing was aborted.</summary>
    [JsonPropertyName("abortCause")]
    public string? AbortCause { get; set; }

    /// <summary>The EdgeLocation from which a packet destined for/originating from the internet will egress/ingress the Google network. This will only be populated for a connectivity test which has an internet destination/source address. The absence of this field *must not* be used as an indication that the destination/source is part of the Google network.</summary>
    [JsonPropertyName("destinationEgressLocation")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateProbingDetailsDestinationEgressLocation? DestinationEgressLocation { get; set; }

    /// <summary>The source and destination endpoints derived from the test input and used for active probing.</summary>
    [JsonPropertyName("endpointInfo")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateProbingDetailsEndpointInfo? EndpointInfo { get; set; }

    /// <summary>Details about an internal failure or the cancellation of active probing.</summary>
    [JsonPropertyName("error")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateProbingDetailsError? Error { get; set; }

    /// <summary>Latency as measured by active probing in one direction: from the source to the destination endpoint.</summary>
    [JsonPropertyName("probingLatency")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateProbingDetailsProbingLatency? ProbingLatency { get; set; }

    /// <summary>The overall result of active probing.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>Number of probes sent.</summary>
    [JsonPropertyName("sentProbeCount")]
    public int? SentProbeCount { get; set; }

    /// <summary>Number of probes that reached the destination.</summary>
    [JsonPropertyName("successfulProbeCount")]
    public int? SuccessfulProbeCount { get; set; }

    /// <summary>The time that reachability was assessed through active probing.</summary>
    [JsonPropertyName("verifyTime")]
    public string? VerifyTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsErrorDetails
{
    /// <summary>A URL/resource name that uniquely identifies the type of the serialized  protocol buffer message. This string must contain at least  one "/" character. The last segment of the URL's path must represent  the fully qualified name of the type (as in  `path/google.protobuf.Duration`). The name should be in a canonical form  (e.g., leading "." is not accepted).   In practice, teams usually precompile into the binary all types that they  expect it to use in the context of Any. However, for URLs which use the  scheme `http`, `https`, or no scheme, one can optionally set up a type  server that maps type URLs to message definitions as follows:   * If no scheme is provided, `https` is assumed.  * An HTTP GET on the URL must yield a [google.protobuf.Type][]    value in binary format, or produce an error.  * Applications are allowed to cache lookup results based on the    URL, or have them precompiled into a binary to avoid any    lookup. Therefore, binary compatibility needs to be preserved    on changes to types. (Use versioned type names to manage    breaking changes.)   Note: this functionality is not currently available in the official  protobuf release, and it is not used for type URLs beginning with  type.googleapis.com.   Schemes other than `http`, `https` (or the empty scheme) might be  used with implementation specific semantics.</summary>
    [JsonPropertyName("typeURL")]
    public string? TypeURL { get; set; }

    /// <summary>Must be a valid serialized protocol buffer of the above specified type.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The details of a failure or a cancellation of reachability analysis.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsError
{
    /// <summary>The status code, which should be an enum value of [google.rpc.Code][google.rpc.Code].</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>A list of messages that carry the error details.  There is a common set of message types for APIs to use.</summary>
    [JsonPropertyName("details")]
    public IList<V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsErrorDetails>? Details { get; set; }

    /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should be localized and sent in the [google.rpc.Status.details][google.rpc.Status.details] field, or localized by the client.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>Derived from the source and destination endpoints definition specified by user request, and validated by the data plane model. If there are multiple traces starting from different source locations, then the endpoint_info may be different between traces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesEndpointInfo
{
    /// <summary>Destination IP address.</summary>
    [JsonPropertyName("destinationIP")]
    public string? DestinationIP { get; set; }

    /// <summary>URI of the network where this packet is sent to.</summary>
    [JsonPropertyName("destinationNetworkURI")]
    public string? DestinationNetworkURI { get; set; }

    /// <summary>Destination port. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("destinationPort")]
    public int? DestinationPort { get; set; }

    /// <summary>IP protocol in string format, for example: "TCP", "UDP", "ICMP".</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>URI of the source telemetry agent this packet originates from.</summary>
    [JsonPropertyName("sourceAgentURI")]
    public string? SourceAgentURI { get; set; }

    /// <summary>Source IP address.</summary>
    [JsonPropertyName("sourceIP")]
    public string? SourceIP { get; set; }

    /// <summary>URI of the network where this packet originates from.</summary>
    [JsonPropertyName("sourceNetworkURI")]
    public string? SourceNetworkURI { get; set; }

    /// <summary>Source port. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("sourcePort")]
    public int? SourcePort { get; set; }
}

/// <summary>Display information of the final state "abort" and reason.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsAbort
{
    /// <summary>Causes that the analysis is aborted.</summary>
    [JsonPropertyName("cause")]
    public string? Cause { get; set; }

    /// <summary>IP address that caused the abort.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>List of project IDs the user specified in the request but lacks access to. In this case, analysis is aborted with the PERMISSION_DENIED cause.</summary>
    [JsonPropertyName("projectsMissingPermission")]
    public IList<string>? ProjectsMissingPermission { get; set; }

    /// <summary>URI of the resource that caused the abort.</summary>
    [JsonPropertyName("resourceURI")]
    public string? ResourceURI { get; set; }
}

/// <summary>Display information of an App Engine service version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsAppEngineVersion
{
    /// <summary>Name of an App Engine version.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>App Engine execution environment for a version.</summary>
    [JsonPropertyName("environment")]
    public string? Environment { get; set; }

    /// <summary>Runtime of the App Engine version.</summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>URI of an App Engine version.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Display information of a Cloud Function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsCloudFunction
{
    /// <summary>Name of a Cloud Function.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Location in which the Cloud Function is deployed.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>URI of a Cloud Function.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Latest successfully deployed version id of the Cloud Function.</summary>
    [JsonPropertyName("versionID")]
    public long? VersionID { get; set; }
}

/// <summary>Display information of a Cloud Run revision.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsCloudRunRevision
{
    /// <summary>Name of a Cloud Run revision.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Location in which this revision is deployed.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>URI of Cloud Run service this revision belongs to.</summary>
    [JsonPropertyName("serviceURI")]
    public string? ServiceURI { get; set; }

    /// <summary>URI of a Cloud Run revision.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Display information of a Cloud SQL instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsCloudSQLInstance
{
    /// <summary>Name of a Cloud SQL instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>External IP address of a Cloud SQL instance.</summary>
    [JsonPropertyName("externalIP")]
    public string? ExternalIP { get; set; }

    /// <summary>Internal IP address of a Cloud SQL instance.</summary>
    [JsonPropertyName("internalIP")]
    public string? InternalIP { get; set; }

    /// <summary>URI of a Cloud SQL instance network or empty string if the instance does not have one.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>Region in which the Cloud SQL instance is running.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>URI of a Cloud SQL instance.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Display information of the final state "deliver" and reason.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsDeliver
{
    /// <summary>IP address of the target (if applicable).</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>PSC Google API target the packet is delivered to (if applicable).</summary>
    [JsonPropertyName("pscGoogleAPITarget")]
    public string? PscGoogleAPITarget { get; set; }

    /// <summary>URI of the resource that the packet is delivered to.</summary>
    [JsonPropertyName("resourceURI")]
    public string? ResourceURI { get; set; }

    /// <summary>Name of the Cloud Storage Bucket the packet is delivered to (if applicable).</summary>
    [JsonPropertyName("storageBucket")]
    public string? StorageBucket { get; set; }

    /// <summary>Target type where the packet is delivered to.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Display information of the final state "drop" and reason.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsDrop
{
    /// <summary>Cause that the packet is dropped.</summary>
    [JsonPropertyName("cause")]
    public string? Cause { get; set; }

    /// <summary>Destination IP address of the dropped packet (if relevant).</summary>
    [JsonPropertyName("destinationIP")]
    public string? DestinationIP { get; set; }

    /// <summary>Region of the dropped packet (if relevant).</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>URI of the resource that caused the drop.</summary>
    [JsonPropertyName("resourceURI")]
    public string? ResourceURI { get; set; }

    /// <summary>Source IP address of the dropped packet (if relevant).</summary>
    [JsonPropertyName("sourceIP")]
    public string? SourceIP { get; set; }
}

/// <summary>Display information of the source and destination under analysis. The endpoint information in an intermediate state may differ with the initial input, as it might be modified by state like NAT, or Connection Proxy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsEndpoint
{
    /// <summary>Destination IP address.</summary>
    [JsonPropertyName("destinationIP")]
    public string? DestinationIP { get; set; }

    /// <summary>URI of the network where this packet is sent to.</summary>
    [JsonPropertyName("destinationNetworkURI")]
    public string? DestinationNetworkURI { get; set; }

    /// <summary>Destination port. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("destinationPort")]
    public int? DestinationPort { get; set; }

    /// <summary>IP protocol in string format, for example: "TCP", "UDP", "ICMP".</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>URI of the source telemetry agent this packet originates from.</summary>
    [JsonPropertyName("sourceAgentURI")]
    public string? SourceAgentURI { get; set; }

    /// <summary>Source IP address.</summary>
    [JsonPropertyName("sourceIP")]
    public string? SourceIP { get; set; }

    /// <summary>URI of the network where this packet originates from.</summary>
    [JsonPropertyName("sourceNetworkURI")]
    public string? SourceNetworkURI { get; set; }

    /// <summary>Source port. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("sourcePort")]
    public int? SourcePort { get; set; }
}

/// <summary>Display information of a Compute Engine firewall rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsFirewall
{
    /// <summary>Possible values: ALLOW, DENY, APPLY_SECURITY_PROFILE_GROUP</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Possible values: INGRESS, EGRESS</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>The display name of the firewall rule. This field might be empty for firewall policy rules.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The firewall rule's type.</summary>
    [JsonPropertyName("firewallRuleType")]
    public string? FirewallRuleType { get; set; }

    /// <summary>The URI of the VPC network that the firewall rule is associated with. This field is not applicable to hierarchical firewall policy rules.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>The name of the firewall policy that this rule is associated with. This field is not applicable to VPC firewall rules and implied VPC firewall rules.</summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    /// <summary>The URI of the firewall policy that this rule is associated with. This field is not applicable to VPC firewall rules and implied VPC firewall rules.</summary>
    [JsonPropertyName("policyURI")]
    public string? PolicyURI { get; set; }

    /// <summary>The priority of the firewall rule.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>The target service accounts specified by the firewall rule.</summary>
    [JsonPropertyName("targetServiceAccounts")]
    public IList<string>? TargetServiceAccounts { get; set; }

    /// <summary>The target tags defined by the VPC firewall rule. This field is not applicable to firewall policy rules.</summary>
    [JsonPropertyName("targetTags")]
    public IList<string>? TargetTags { get; set; }

    /// <summary>The URI of the firewall rule. This field is not applicable to implied VPC firewall rules.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Display information of the final state "forward" and reason.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsForward
{
    /// <summary>IP address of the target (if applicable).</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>URI of the resource that the packet is forwarded to.</summary>
    [JsonPropertyName("resourceURI")]
    public string? ResourceURI { get; set; }

    /// <summary>Target type where this packet is forwarded to.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Display information of a Compute Engine forwarding rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsForwardingRule
{
    /// <summary>Name of the forwarding rule.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Name of the load balancer the forwarding rule belongs to. Empty for forwarding rules not related to load balancers (like PSC forwarding rules).</summary>
    [JsonPropertyName("loadBalancerName")]
    public string? LoadBalancerName { get; set; }

    /// <summary>Port range defined in the forwarding rule that matches the packet.</summary>
    [JsonPropertyName("matchedPortRange")]
    public string? MatchedPortRange { get; set; }

    /// <summary>Protocol defined in the forwarding rule that matches the packet.</summary>
    [JsonPropertyName("matchedProtocol")]
    public string? MatchedProtocol { get; set; }

    /// <summary>Network URI.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>PSC Google API target this forwarding rule targets (if applicable).</summary>
    [JsonPropertyName("pscGoogleAPITarget")]
    public string? PscGoogleAPITarget { get; set; }

    /// <summary>URI of the PSC service attachment this forwarding rule targets (if applicable).</summary>
    [JsonPropertyName("pscServiceAttachmentURI")]
    public string? PscServiceAttachmentURI { get; set; }

    /// <summary>Region of the forwarding rule. Set only for regional forwarding rules.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Target type of the forwarding rule.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>URI of the forwarding rule.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>VIP of the forwarding rule.</summary>
    [JsonPropertyName("vip")]
    public string? Vip { get; set; }
}

/// <summary>Display information of a Google Kubernetes Engine cluster master.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsGkeMaster
{
    /// <summary>URI of a GKE cluster network.</summary>
    [JsonPropertyName("clusterNetworkURI")]
    public string? ClusterNetworkURI { get; set; }

    /// <summary>URI of a GKE cluster.</summary>
    [JsonPropertyName("clusterURI")]
    public string? ClusterURI { get; set; }

    /// <summary>DNS endpoint of a GKE cluster control plane.</summary>
    [JsonPropertyName("dnsEndpoint")]
    public string? DnsEndpoint { get; set; }

    /// <summary>External IP address of a GKE cluster control plane.</summary>
    [JsonPropertyName("externalIP")]
    public string? ExternalIP { get; set; }

    /// <summary>Internal IP address of a GKE cluster control plane.</summary>
    [JsonPropertyName("internalIP")]
    public string? InternalIP { get; set; }
}

/// <summary>Display information of a Google service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsGoogleService
{
    /// <summary>Recognized type of a Google Service.</summary>
    [JsonPropertyName("googleServiceType")]
    public string? GoogleServiceType { get; set; }

    /// <summary>Source IP address.</summary>
    [JsonPropertyName("sourceIP")]
    public string? SourceIP { get; set; }
}

/// <summary>Display information of a Compute Engine instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsInstance
{
    /// <summary>Name of a Compute Engine instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>External IP address of the network interface.</summary>
    [JsonPropertyName("externalIP")]
    public string? ExternalIP { get; set; }

    /// <summary>Name of the network interface of a Compute Engine instance.</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>Internal IP address of the network interface.</summary>
    [JsonPropertyName("internalIP")]
    public string? InternalIP { get; set; }

    /// <summary>Network tags configured on the instance.</summary>
    [JsonPropertyName("networkTags")]
    public IList<string>? NetworkTags { get; set; }

    /// <summary>URI of a Compute Engine network.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>URI of the PSC network attachment the NIC is attached to (if relevant).</summary>
    [JsonPropertyName("pscNetworkAttachmentURI")]
    public string? PscNetworkAttachmentURI { get; set; }

    /// <summary>Service account authorized for the instance.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>URI of a Compute Engine instance.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsLoadBalancerBackends
{
    /// <summary>Name of a Compute Engine instance or network endpoint.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A list of firewall rule URIs allowing probes from health check IP ranges.</summary>
    [JsonPropertyName("healthCheckAllowingFirewallRules")]
    public IList<string>? HealthCheckAllowingFirewallRules { get; set; }

    /// <summary>A list of firewall rule URIs blocking probes from health check IP ranges.</summary>
    [JsonPropertyName("healthCheckBlockingFirewallRules")]
    public IList<string>? HealthCheckBlockingFirewallRules { get; set; }

    /// <summary>State of the health check firewall configuration.</summary>
    [JsonPropertyName("healthCheckFirewallState")]
    public string? HealthCheckFirewallState { get; set; }

    /// <summary>URI of a Compute Engine instance or network endpoint.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Display information of the load balancers. Deprecated in favor of the `load_balancer_backend_info` field, not used in new tests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsLoadBalancer
{
    /// <summary>Type of load balancer's backend configuration.</summary>
    [JsonPropertyName("backendType")]
    public string? BackendType { get; set; }

    /// <summary>Backend configuration URI.</summary>
    [JsonPropertyName("backendURI")]
    public string? BackendURI { get; set; }

    /// <summary>Information for the loadbalancer backends.</summary>
    [JsonPropertyName("backends")]
    public IList<V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsLoadBalancerBackends>? Backends { get; set; }

    /// <summary>URI of the health check for the load balancer. Deprecated and no longer populated as different load balancer backends might have different health checks.</summary>
    [JsonPropertyName("healthCheckURI")]
    public string? HealthCheckURI { get; set; }

    /// <summary>Type of the load balancer.</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }
}

/// <summary>Display information of a specific load balancer backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsLoadBalancerBackendInfo
{
    /// <summary>URI of the backend bucket this backend targets (if applicable).</summary>
    [JsonPropertyName("backendBucketURI")]
    public string? BackendBucketURI { get; set; }

    /// <summary>URI of the backend service this backend belongs to (if applicable).</summary>
    [JsonPropertyName("backendServiceURI")]
    public string? BackendServiceURI { get; set; }

    /// <summary>Output only. Health check firewalls configuration state for the backend. This is a result of the static firewall analysis (verifying that health check traffic from required IP ranges to the backend is allowed or not). The backend might still be unhealthy even if these firewalls are configured. Please refer to the documentation for more information: https://cloud.google.com/load-balancing/docs/firewall-rules</summary>
    [JsonPropertyName("healthCheckFirewallsConfigState")]
    public string? HealthCheckFirewallsConfigState { get; set; }

    /// <summary>URI of the health check attached to this backend (if applicable).</summary>
    [JsonPropertyName("healthCheckURI")]
    public string? HealthCheckURI { get; set; }

    /// <summary>URI of the instance group this backend belongs to (if applicable).</summary>
    [JsonPropertyName("instanceGroupURI")]
    public string? InstanceGroupURI { get; set; }

    /// <summary>URI of the backend instance (if applicable). Populated for instance group backends, and zonal NEG backends.</summary>
    [JsonPropertyName("instanceURI")]
    public string? InstanceURI { get; set; }

    /// <summary>Display name of the backend. For example, it might be an instance name for the instance group backends, or an IP address and port for zonal network endpoint group backends.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>URI of the network endpoint group this backend belongs to (if applicable).</summary>
    [JsonPropertyName("networkEndpointGroupURI")]
    public string? NetworkEndpointGroupURI { get; set; }

    /// <summary>PSC Google API target this PSC NEG backend targets (if applicable).</summary>
    [JsonPropertyName("pscGoogleAPITarget")]
    public string? PscGoogleAPITarget { get; set; }

    /// <summary>URI of the PSC service attachment this PSC NEG backend targets (if applicable).</summary>
    [JsonPropertyName("pscServiceAttachmentURI")]
    public string? PscServiceAttachmentURI { get; set; }
}

/// <summary>Display information of a NAT.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsNat
{
    /// <summary>The name of Cloud NAT Gateway. Only valid when type is CLOUD_NAT.</summary>
    [JsonPropertyName("natGatewayName")]
    public string? NatGatewayName { get; set; }

    /// <summary>URI of the network where NAT translation takes place.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>Destination IP address after NAT translation.</summary>
    [JsonPropertyName("newDestinationIP")]
    public string? NewDestinationIP { get; set; }

    /// <summary>Destination port after NAT translation. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("newDestinationPort")]
    public int? NewDestinationPort { get; set; }

    /// <summary>Source IP address after NAT translation.</summary>
    [JsonPropertyName("newSourceIP")]
    public string? NewSourceIP { get; set; }

    /// <summary>Source port after NAT translation. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("newSourcePort")]
    public int? NewSourcePort { get; set; }

    /// <summary>Destination IP address before NAT translation.</summary>
    [JsonPropertyName("oldDestinationIP")]
    public string? OldDestinationIP { get; set; }

    /// <summary>Destination port before NAT translation. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("oldDestinationPort")]
    public int? OldDestinationPort { get; set; }

    /// <summary>Source IP address before NAT translation.</summary>
    [JsonPropertyName("oldSourceIP")]
    public string? OldSourceIP { get; set; }

    /// <summary>Source port before NAT translation. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("oldSourcePort")]
    public int? OldSourcePort { get; set; }

    /// <summary>IP protocol in string format, for example: "TCP", "UDP", "ICMP".</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Uri of the Cloud Router. Only valid when type is CLOUD_NAT.</summary>
    [JsonPropertyName("routerURI")]
    public string? RouterURI { get; set; }

    /// <summary>Type of NAT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Display information of a Google Cloud network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsNetwork
{
    /// <summary>Name of a Compute Engine network.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The IP range of the subnet matching the source IP address of the test.</summary>
    [JsonPropertyName("matchedIPRange")]
    public string? MatchedIPRange { get; set; }

    /// <summary>URI of the subnet matching the source IP address of the test.</summary>
    [JsonPropertyName("matchedSubnetURI")]
    public string? MatchedSubnetURI { get; set; }

    /// <summary>The region of the subnet matching the source IP address of the test.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>URI of a Compute Engine network.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Display information of a ProxyConnection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsProxyConnection
{
    /// <summary>URI of the network where connection is proxied.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>Destination IP address of a new connection.</summary>
    [JsonPropertyName("newDestinationIP")]
    public string? NewDestinationIP { get; set; }

    /// <summary>Destination port of a new connection. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("newDestinationPort")]
    public int? NewDestinationPort { get; set; }

    /// <summary>Source IP address of a new connection.</summary>
    [JsonPropertyName("newSourceIP")]
    public string? NewSourceIP { get; set; }

    /// <summary>Source port of a new connection. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("newSourcePort")]
    public int? NewSourcePort { get; set; }

    /// <summary>Destination IP address of an original connection</summary>
    [JsonPropertyName("oldDestinationIP")]
    public string? OldDestinationIP { get; set; }

    /// <summary>Destination port of an original connection. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("oldDestinationPort")]
    public int? OldDestinationPort { get; set; }

    /// <summary>Source IP address of an original connection.</summary>
    [JsonPropertyName("oldSourceIP")]
    public string? OldSourceIP { get; set; }

    /// <summary>Source port of an original connection. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("oldSourcePort")]
    public int? OldSourcePort { get; set; }

    /// <summary>IP protocol in string format, for example: "TCP", "UDP", "ICMP".</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Uri of proxy subnet.</summary>
    [JsonPropertyName("subnetURI")]
    public string? SubnetURI { get; set; }
}

/// <summary>Display information of a Redis Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsRedisCluster
{
    /// <summary>Discovery endpoint IP address of a Redis Cluster.</summary>
    [JsonPropertyName("discoveryEndpointIPAddress")]
    public string? DiscoveryEndpointIPAddress { get; set; }

    /// <summary>Name of a Redis Cluster.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Name of the region in which the Redis Cluster is defined. For example, "us-central1".</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>URI of a Redis Cluster network in format "projects/{project_id}/global/networks/{network_id}".</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>Secondary endpoint IP address of a Redis Cluster.</summary>
    [JsonPropertyName("secondaryEndpointIPAddress")]
    public string? SecondaryEndpointIPAddress { get; set; }

    /// <summary>URI of a Redis Cluster in format "projects/{project_id}/locations/{location}/clusters/{cluster_id}"</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Display information of a Redis Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsRedisInstance
{
    /// <summary>Name of a Cloud Redis Instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>URI of a Cloud Redis Instance network.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>Primary endpoint IP address of a Cloud Redis Instance.</summary>
    [JsonPropertyName("primaryEndpointIP")]
    public string? PrimaryEndpointIP { get; set; }

    /// <summary>Read endpoint IP address of a Cloud Redis Instance (if applicable).</summary>
    [JsonPropertyName("readEndpointIP")]
    public string? ReadEndpointIP { get; set; }

    /// <summary>Region in which the Cloud Redis Instance is defined.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>URI of a Cloud Redis Instance.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Display information of a Compute Engine route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsRoute
{
    /// <summary>For advertised routes, the URI of their next hop, i.e. the URI of the hybrid endpoint (VPN tunnel, Interconnect attachment, NCC router appliance) the advertised prefix is advertised through, or URI of the source peered network.</summary>
    [JsonPropertyName("advertisedRouteNextHopURI")]
    public string? AdvertisedRouteNextHopURI { get; set; }

    /// <summary>For advertised dynamic routes, the URI of the Cloud Router that advertised the corresponding IP prefix.</summary>
    [JsonPropertyName("advertisedRouteSourceRouterURI")]
    public string? AdvertisedRouteSourceRouterURI { get; set; }

    /// <summary>Destination IP range of the route.</summary>
    [JsonPropertyName("destIPRange")]
    public string? DestIPRange { get; set; }

    /// <summary>Destination port ranges of the route. Policy based routes only.</summary>
    [JsonPropertyName("destPortRanges")]
    public IList<string>? DestPortRanges { get; set; }

    /// <summary>Name of a route.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Instance tags of the route.</summary>
    [JsonPropertyName("instanceTags")]
    public IList<string>? InstanceTags { get; set; }

    /// <summary>URI of a NCC Hub. NCC_HUB routes only.</summary>
    [JsonPropertyName("nccHubURI")]
    public string? NccHubURI { get; set; }

    /// <summary>URI of a NCC Spoke. NCC_HUB routes only.</summary>
    [JsonPropertyName("nccSpokeURI")]
    public string? NccSpokeURI { get; set; }

    /// <summary>URI of a Compute Engine network. NETWORK routes only.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>Next hop of the route.</summary>
    [JsonPropertyName("nextHop")]
    public string? NextHop { get; set; }

    /// <summary>Type of next hop.</summary>
    [JsonPropertyName("nextHopType")]
    public string? NextHopType { get; set; }

    /// <summary>Priority of the route.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Protocols of the route. Policy based routes only.</summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary>Region of the route (if applicable).</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Indicates where route is applicable.</summary>
    [JsonPropertyName("routeScope")]
    public string? RouteScope { get; set; }

    /// <summary>Type of route.</summary>
    [JsonPropertyName("routeType")]
    public string? RouteType { get; set; }

    /// <summary>Source IP address range of the route. Policy based routes only.</summary>
    [JsonPropertyName("srcIPRange")]
    public string? SrcIPRange { get; set; }

    /// <summary>Source port ranges of the route. Policy based routes only.</summary>
    [JsonPropertyName("srcPortRanges")]
    public IList<string>? SrcPortRanges { get; set; }

    /// <summary>URI of a route (if applicable).</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Display information of a Serverless network endpoint group backend. Used only for return traces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsServerlessNeg
{
    /// <summary>URI of the serverless network endpoint group.</summary>
    [JsonPropertyName("negURI")]
    public string? NegURI { get; set; }
}

/// <summary>Display information of a Storage Bucket. Used only for return traces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsStorageBucket
{
    /// <summary>Cloud Storage Bucket name.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }
}

/// <summary>Display information of a VPC connector.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsVpcConnector
{
    /// <summary>Name of a VPC connector.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Location in which the VPC connector is deployed.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>URI of a VPC connector.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Display information of a Compute Engine VPN gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsVpnGateway
{
    /// <summary>Name of a VPN gateway.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>IP address of the VPN gateway.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>URI of a Compute Engine network where the VPN gateway is configured.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>Name of a Google Cloud region where this VPN gateway is configured.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>URI of a VPN gateway.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>A VPN tunnel that is associated with this VPN gateway. There may be multiple VPN tunnels configured on a VPN gateway, and only the one relevant to the test is displayed.</summary>
    [JsonPropertyName("vpnTunnelURI")]
    public string? VpnTunnelURI { get; set; }
}

/// <summary>Display information of a Compute Engine VPN tunnel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsVpnTunnel
{
    /// <summary>Name of a VPN tunnel.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>URI of a Compute Engine network where the VPN tunnel is configured.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>Name of a Google Cloud region where this VPN tunnel is configured.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>URI of a VPN gateway at remote end of the tunnel.</summary>
    [JsonPropertyName("remoteGateway")]
    public string? RemoteGateway { get; set; }

    /// <summary>Remote VPN gateway's IP address.</summary>
    [JsonPropertyName("remoteGatewayIP")]
    public string? RemoteGatewayIP { get; set; }

    /// <summary>Type of the routing policy.</summary>
    [JsonPropertyName("routingType")]
    public string? RoutingType { get; set; }

    /// <summary>URI of the VPN gateway at local end of the tunnel.</summary>
    [JsonPropertyName("sourceGateway")]
    public string? SourceGateway { get; set; }

    /// <summary>Local VPN gateway's IP address.</summary>
    [JsonPropertyName("sourceGatewayIP")]
    public string? SourceGatewayIP { get; set; }

    /// <summary>URI of a VPN tunnel.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesSteps
{
    /// <summary>Display information of the final state "abort" and reason.</summary>
    [JsonPropertyName("abort")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsAbort? Abort { get; set; }

    /// <summary>Display information of an App Engine service version.</summary>
    [JsonPropertyName("appEngineVersion")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsAppEngineVersion? AppEngineVersion { get; set; }

    /// <summary>This is a step that leads to the final state Drop.</summary>
    [JsonPropertyName("causesDrop")]
    public bool? CausesDrop { get; set; }

    /// <summary>Display information of a Cloud Function.</summary>
    [JsonPropertyName("cloudFunction")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsCloudFunction? CloudFunction { get; set; }

    /// <summary>Display information of a Cloud Run revision.</summary>
    [JsonPropertyName("cloudRunRevision")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsCloudRunRevision? CloudRunRevision { get; set; }

    /// <summary>Display information of a Cloud SQL instance.</summary>
    [JsonPropertyName("cloudSQLInstance")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsCloudSQLInstance? CloudSQLInstance { get; set; }

    /// <summary>Display information of the final state "deliver" and reason.</summary>
    [JsonPropertyName("deliver")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsDeliver? Deliver { get; set; }

    /// <summary>A description of the step. Usually this is a summary of the state.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display information of the final state "drop" and reason.</summary>
    [JsonPropertyName("drop")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsDrop? Drop { get; set; }

    /// <summary>Display information of the source and destination under analysis. The endpoint information in an intermediate state may differ with the initial input, as it might be modified by state like NAT, or Connection Proxy.</summary>
    [JsonPropertyName("endpoint")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsEndpoint? Endpoint { get; set; }

    /// <summary>Display information of a Compute Engine firewall rule.</summary>
    [JsonPropertyName("firewall")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsFirewall? Firewall { get; set; }

    /// <summary>Display information of the final state "forward" and reason.</summary>
    [JsonPropertyName("forward")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsForward? Forward { get; set; }

    /// <summary>Display information of a Compute Engine forwarding rule.</summary>
    [JsonPropertyName("forwardingRule")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsForwardingRule? ForwardingRule { get; set; }

    /// <summary>Display information of a Google Kubernetes Engine cluster master.</summary>
    [JsonPropertyName("gkeMaster")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsGkeMaster? GkeMaster { get; set; }

    /// <summary>Display information of a Google service</summary>
    [JsonPropertyName("googleService")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsGoogleService? GoogleService { get; set; }

    /// <summary>Display information of a Compute Engine instance.</summary>
    [JsonPropertyName("instance")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsInstance? Instance { get; set; }

    /// <summary>Display information of the load balancers. Deprecated in favor of the `load_balancer_backend_info` field, not used in new tests.</summary>
    [JsonPropertyName("loadBalancer")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsLoadBalancer? LoadBalancer { get; set; }

    /// <summary>Display information of a specific load balancer backend.</summary>
    [JsonPropertyName("loadBalancerBackendInfo")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsLoadBalancerBackendInfo? LoadBalancerBackendInfo { get; set; }

    /// <summary>Display information of a NAT.</summary>
    [JsonPropertyName("nat")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsNat? Nat { get; set; }

    /// <summary>Display information of a Google Cloud network.</summary>
    [JsonPropertyName("network")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsNetwork? Network { get; set; }

    /// <summary>Project ID that contains the configuration this step is validating.</summary>
    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }

    /// <summary>Display information of a ProxyConnection.</summary>
    [JsonPropertyName("proxyConnection")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsProxyConnection? ProxyConnection { get; set; }

    /// <summary>Display information of a Redis Cluster.</summary>
    [JsonPropertyName("redisCluster")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsRedisCluster? RedisCluster { get; set; }

    /// <summary>Display information of a Redis Instance.</summary>
    [JsonPropertyName("redisInstance")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsRedisInstance? RedisInstance { get; set; }

    /// <summary>Display information of a Compute Engine route.</summary>
    [JsonPropertyName("route")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsRoute? Route { get; set; }

    /// <summary>Display information of a Serverless network endpoint group backend. Used only for return traces.</summary>
    [JsonPropertyName("serverlessNeg")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsServerlessNeg? ServerlessNeg { get; set; }

    /// <summary>Each step is in one of the pre-defined states.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Display information of a Storage Bucket. Used only for return traces.</summary>
    [JsonPropertyName("storageBucket")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsStorageBucket? StorageBucket { get; set; }

    /// <summary>Display information of a VPC connector.</summary>
    [JsonPropertyName("vpcConnector")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsVpcConnector? VpcConnector { get; set; }

    /// <summary>Display information of a Compute Engine VPN gateway.</summary>
    [JsonPropertyName("vpnGateway")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsVpnGateway? VpnGateway { get; set; }

    /// <summary>Display information of a Compute Engine VPN tunnel.</summary>
    [JsonPropertyName("vpnTunnel")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesStepsVpnTunnel? VpnTunnel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTraces
{
    /// <summary>Derived from the source and destination endpoints definition specified by user request, and validated by the data plane model. If there are multiple traces starting from different source locations, then the endpoint_info may be different between traces.</summary>
    [JsonPropertyName("endpointInfo")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesEndpointInfo? EndpointInfo { get; set; }

    /// <summary>ID of trace. For forward traces, this ID is unique for each trace. For return traces, it matches ID of associated forward trace. A single forward trace can be associated with none, one or more than one return trace.</summary>
    [JsonPropertyName("forwardTraceID")]
    public int? ForwardTraceID { get; set; }

    /// <summary>A trace of a test contains multiple steps from the initial state to the  final state (delivered, dropped, forwarded, or aborted).   The steps are ordered by the processing sequence within the simulated  network state machine. It is critical to preserve the order of the steps  and avoid reordering or sorting them.</summary>
    [JsonPropertyName("steps")]
    public IList<V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTracesSteps>? Steps { get; set; }
}

/// <summary>Output only. The reachability details of this test from the latest run. The details are updated when creating a new test, updating an existing test, or triggering a one-time rerun of an existing test.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetails
{
    /// <summary>The details of a failure or a cancellation of reachability analysis.</summary>
    [JsonPropertyName("error")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsError? Error { get; set; }

    /// <summary>The overall result of the test's configuration analysis.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>Result may contain a list of traces if a test has multiple possible paths in the network, such as when destination endpoint is a load balancer with multiple backends.</summary>
    [JsonPropertyName("traces")]
    public IList<V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetailsTraces>? Traces { get; set; }

    /// <summary>The time of the configuration analysis.</summary>
    [JsonPropertyName("verifyTime")]
    public string? VerifyTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsErrorDetails
{
    /// <summary>A URL/resource name that uniquely identifies the type of the serialized  protocol buffer message. This string must contain at least  one "/" character. The last segment of the URL's path must represent  the fully qualified name of the type (as in  `path/google.protobuf.Duration`). The name should be in a canonical form  (e.g., leading "." is not accepted).   In practice, teams usually precompile into the binary all types that they  expect it to use in the context of Any. However, for URLs which use the  scheme `http`, `https`, or no scheme, one can optionally set up a type  server that maps type URLs to message definitions as follows:   * If no scheme is provided, `https` is assumed.  * An HTTP GET on the URL must yield a [google.protobuf.Type][]    value in binary format, or produce an error.  * Applications are allowed to cache lookup results based on the    URL, or have them precompiled into a binary to avoid any    lookup. Therefore, binary compatibility needs to be preserved    on changes to types. (Use versioned type names to manage    breaking changes.)   Note: this functionality is not currently available in the official  protobuf release, and it is not used for type URLs beginning with  type.googleapis.com.   Schemes other than `http`, `https` (or the empty scheme) might be  used with implementation specific semantics.</summary>
    [JsonPropertyName("typeURL")]
    public string? TypeURL { get; set; }

    /// <summary>Must be a valid serialized protocol buffer of the above specified type.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The details of a failure or a cancellation of reachability analysis.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsError
{
    /// <summary>The status code, which should be an enum value of [google.rpc.Code][google.rpc.Code].</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>A list of messages that carry the error details.  There is a common set of message types for APIs to use.</summary>
    [JsonPropertyName("details")]
    public IList<V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsErrorDetails>? Details { get; set; }

    /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should be localized and sent in the [google.rpc.Status.details][google.rpc.Status.details] field, or localized by the client.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>Derived from the source and destination endpoints definition specified by user request, and validated by the data plane model. If there are multiple traces starting from different source locations, then the endpoint_info may be different between traces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesEndpointInfo
{
    /// <summary>Destination IP address.</summary>
    [JsonPropertyName("destinationIP")]
    public string? DestinationIP { get; set; }

    /// <summary>URI of the network where this packet is sent to.</summary>
    [JsonPropertyName("destinationNetworkURI")]
    public string? DestinationNetworkURI { get; set; }

    /// <summary>Destination port. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("destinationPort")]
    public int? DestinationPort { get; set; }

    /// <summary>IP protocol in string format, for example: "TCP", "UDP", "ICMP".</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>URI of the source telemetry agent this packet originates from.</summary>
    [JsonPropertyName("sourceAgentURI")]
    public string? SourceAgentURI { get; set; }

    /// <summary>Source IP address.</summary>
    [JsonPropertyName("sourceIP")]
    public string? SourceIP { get; set; }

    /// <summary>URI of the network where this packet originates from.</summary>
    [JsonPropertyName("sourceNetworkURI")]
    public string? SourceNetworkURI { get; set; }

    /// <summary>Source port. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("sourcePort")]
    public int? SourcePort { get; set; }
}

/// <summary>Display information of the final state "abort" and reason.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsAbort
{
    /// <summary>Causes that the analysis is aborted.</summary>
    [JsonPropertyName("cause")]
    public string? Cause { get; set; }

    /// <summary>IP address that caused the abort.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>List of project IDs the user specified in the request but lacks access to. In this case, analysis is aborted with the PERMISSION_DENIED cause.</summary>
    [JsonPropertyName("projectsMissingPermission")]
    public IList<string>? ProjectsMissingPermission { get; set; }

    /// <summary>URI of the resource that caused the abort.</summary>
    [JsonPropertyName("resourceURI")]
    public string? ResourceURI { get; set; }
}

/// <summary>Display information of an App Engine service version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsAppEngineVersion
{
    /// <summary>Name of an App Engine version.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>App Engine execution environment for a version.</summary>
    [JsonPropertyName("environment")]
    public string? Environment { get; set; }

    /// <summary>Runtime of the App Engine version.</summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>URI of an App Engine version.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Display information of a Cloud Function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsCloudFunction
{
    /// <summary>Name of a Cloud Function.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Location in which the Cloud Function is deployed.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>URI of a Cloud Function.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Latest successfully deployed version id of the Cloud Function.</summary>
    [JsonPropertyName("versionID")]
    public long? VersionID { get; set; }
}

/// <summary>Display information of a Cloud Run revision.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsCloudRunRevision
{
    /// <summary>Name of a Cloud Run revision.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Location in which this revision is deployed.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>URI of Cloud Run service this revision belongs to.</summary>
    [JsonPropertyName("serviceURI")]
    public string? ServiceURI { get; set; }

    /// <summary>URI of a Cloud Run revision.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Display information of a Cloud SQL instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsCloudSQLInstance
{
    /// <summary>Name of a Cloud SQL instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>External IP address of a Cloud SQL instance.</summary>
    [JsonPropertyName("externalIP")]
    public string? ExternalIP { get; set; }

    /// <summary>Internal IP address of a Cloud SQL instance.</summary>
    [JsonPropertyName("internalIP")]
    public string? InternalIP { get; set; }

    /// <summary>URI of a Cloud SQL instance network or empty string if the instance does not have one.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>Region in which the Cloud SQL instance is running.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>URI of a Cloud SQL instance.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Display information of the final state "deliver" and reason.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsDeliver
{
    /// <summary>IP address of the target (if applicable).</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>PSC Google API target the packet is delivered to (if applicable).</summary>
    [JsonPropertyName("pscGoogleAPITarget")]
    public string? PscGoogleAPITarget { get; set; }

    /// <summary>URI of the resource that the packet is delivered to.</summary>
    [JsonPropertyName("resourceURI")]
    public string? ResourceURI { get; set; }

    /// <summary>Name of the Cloud Storage Bucket the packet is delivered to (if applicable).</summary>
    [JsonPropertyName("storageBucket")]
    public string? StorageBucket { get; set; }

    /// <summary>Target type where the packet is delivered to.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Display information of the final state "drop" and reason.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsDrop
{
    /// <summary>Cause that the packet is dropped.</summary>
    [JsonPropertyName("cause")]
    public string? Cause { get; set; }

    /// <summary>Destination IP address of the dropped packet (if relevant).</summary>
    [JsonPropertyName("destinationIP")]
    public string? DestinationIP { get; set; }

    /// <summary>Region of the dropped packet (if relevant).</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>URI of the resource that caused the drop.</summary>
    [JsonPropertyName("resourceURI")]
    public string? ResourceURI { get; set; }

    /// <summary>Source IP address of the dropped packet (if relevant).</summary>
    [JsonPropertyName("sourceIP")]
    public string? SourceIP { get; set; }
}

/// <summary>Display information of the source and destination under analysis. The endpoint information in an intermediate state may differ with the initial input, as it might be modified by state like NAT, or Connection Proxy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsEndpoint
{
    /// <summary>Destination IP address.</summary>
    [JsonPropertyName("destinationIP")]
    public string? DestinationIP { get; set; }

    /// <summary>URI of the network where this packet is sent to.</summary>
    [JsonPropertyName("destinationNetworkURI")]
    public string? DestinationNetworkURI { get; set; }

    /// <summary>Destination port. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("destinationPort")]
    public int? DestinationPort { get; set; }

    /// <summary>IP protocol in string format, for example: "TCP", "UDP", "ICMP".</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>URI of the source telemetry agent this packet originates from.</summary>
    [JsonPropertyName("sourceAgentURI")]
    public string? SourceAgentURI { get; set; }

    /// <summary>Source IP address.</summary>
    [JsonPropertyName("sourceIP")]
    public string? SourceIP { get; set; }

    /// <summary>URI of the network where this packet originates from.</summary>
    [JsonPropertyName("sourceNetworkURI")]
    public string? SourceNetworkURI { get; set; }

    /// <summary>Source port. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("sourcePort")]
    public int? SourcePort { get; set; }
}

/// <summary>Display information of a Compute Engine firewall rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsFirewall
{
    /// <summary>Possible values: ALLOW, DENY, APPLY_SECURITY_PROFILE_GROUP</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Possible values: INGRESS, EGRESS</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>The display name of the firewall rule. This field might be empty for firewall policy rules.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The firewall rule's type.</summary>
    [JsonPropertyName("firewallRuleType")]
    public string? FirewallRuleType { get; set; }

    /// <summary>The URI of the VPC network that the firewall rule is associated with. This field is not applicable to hierarchical firewall policy rules.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>The name of the firewall policy that this rule is associated with. This field is not applicable to VPC firewall rules and implied VPC firewall rules.</summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    /// <summary>The URI of the firewall policy that this rule is associated with. This field is not applicable to VPC firewall rules and implied VPC firewall rules.</summary>
    [JsonPropertyName("policyURI")]
    public string? PolicyURI { get; set; }

    /// <summary>The priority of the firewall rule.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>The target service accounts specified by the firewall rule.</summary>
    [JsonPropertyName("targetServiceAccounts")]
    public IList<string>? TargetServiceAccounts { get; set; }

    /// <summary>The target tags defined by the VPC firewall rule. This field is not applicable to firewall policy rules.</summary>
    [JsonPropertyName("targetTags")]
    public IList<string>? TargetTags { get; set; }

    /// <summary>The URI of the firewall rule. This field is not applicable to implied VPC firewall rules.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Display information of the final state "forward" and reason.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsForward
{
    /// <summary>IP address of the target (if applicable).</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>URI of the resource that the packet is forwarded to.</summary>
    [JsonPropertyName("resourceURI")]
    public string? ResourceURI { get; set; }

    /// <summary>Target type where this packet is forwarded to.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Display information of a Compute Engine forwarding rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsForwardingRule
{
    /// <summary>Name of the forwarding rule.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Name of the load balancer the forwarding rule belongs to. Empty for forwarding rules not related to load balancers (like PSC forwarding rules).</summary>
    [JsonPropertyName("loadBalancerName")]
    public string? LoadBalancerName { get; set; }

    /// <summary>Port range defined in the forwarding rule that matches the packet.</summary>
    [JsonPropertyName("matchedPortRange")]
    public string? MatchedPortRange { get; set; }

    /// <summary>Protocol defined in the forwarding rule that matches the packet.</summary>
    [JsonPropertyName("matchedProtocol")]
    public string? MatchedProtocol { get; set; }

    /// <summary>Network URI.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>PSC Google API target this forwarding rule targets (if applicable).</summary>
    [JsonPropertyName("pscGoogleAPITarget")]
    public string? PscGoogleAPITarget { get; set; }

    /// <summary>URI of the PSC service attachment this forwarding rule targets (if applicable).</summary>
    [JsonPropertyName("pscServiceAttachmentURI")]
    public string? PscServiceAttachmentURI { get; set; }

    /// <summary>Region of the forwarding rule. Set only for regional forwarding rules.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Target type of the forwarding rule.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>URI of the forwarding rule.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>VIP of the forwarding rule.</summary>
    [JsonPropertyName("vip")]
    public string? Vip { get; set; }
}

/// <summary>Display information of a Google Kubernetes Engine cluster master.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsGkeMaster
{
    /// <summary>URI of a GKE cluster network.</summary>
    [JsonPropertyName("clusterNetworkURI")]
    public string? ClusterNetworkURI { get; set; }

    /// <summary>URI of a GKE cluster.</summary>
    [JsonPropertyName("clusterURI")]
    public string? ClusterURI { get; set; }

    /// <summary>DNS endpoint of a GKE cluster control plane.</summary>
    [JsonPropertyName("dnsEndpoint")]
    public string? DnsEndpoint { get; set; }

    /// <summary>External IP address of a GKE cluster control plane.</summary>
    [JsonPropertyName("externalIP")]
    public string? ExternalIP { get; set; }

    /// <summary>Internal IP address of a GKE cluster control plane.</summary>
    [JsonPropertyName("internalIP")]
    public string? InternalIP { get; set; }
}

/// <summary>Display information of a Google service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsGoogleService
{
    /// <summary>Recognized type of a Google Service.</summary>
    [JsonPropertyName("googleServiceType")]
    public string? GoogleServiceType { get; set; }

    /// <summary>Source IP address.</summary>
    [JsonPropertyName("sourceIP")]
    public string? SourceIP { get; set; }
}

/// <summary>Display information of a Compute Engine instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsInstance
{
    /// <summary>Name of a Compute Engine instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>External IP address of the network interface.</summary>
    [JsonPropertyName("externalIP")]
    public string? ExternalIP { get; set; }

    /// <summary>Name of the network interface of a Compute Engine instance.</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>Internal IP address of the network interface.</summary>
    [JsonPropertyName("internalIP")]
    public string? InternalIP { get; set; }

    /// <summary>Network tags configured on the instance.</summary>
    [JsonPropertyName("networkTags")]
    public IList<string>? NetworkTags { get; set; }

    /// <summary>URI of a Compute Engine network.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>URI of the PSC network attachment the NIC is attached to (if relevant).</summary>
    [JsonPropertyName("pscNetworkAttachmentURI")]
    public string? PscNetworkAttachmentURI { get; set; }

    /// <summary>Service account authorized for the instance.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>URI of a Compute Engine instance.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsLoadBalancerBackends
{
    /// <summary>Name of a Compute Engine instance or network endpoint.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A list of firewall rule URIs allowing probes from health check IP ranges.</summary>
    [JsonPropertyName("healthCheckAllowingFirewallRules")]
    public IList<string>? HealthCheckAllowingFirewallRules { get; set; }

    /// <summary>A list of firewall rule URIs blocking probes from health check IP ranges.</summary>
    [JsonPropertyName("healthCheckBlockingFirewallRules")]
    public IList<string>? HealthCheckBlockingFirewallRules { get; set; }

    /// <summary>State of the health check firewall configuration.</summary>
    [JsonPropertyName("healthCheckFirewallState")]
    public string? HealthCheckFirewallState { get; set; }

    /// <summary>URI of a Compute Engine instance or network endpoint.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Display information of the load balancers. Deprecated in favor of the `load_balancer_backend_info` field, not used in new tests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsLoadBalancer
{
    /// <summary>Type of load balancer's backend configuration.</summary>
    [JsonPropertyName("backendType")]
    public string? BackendType { get; set; }

    /// <summary>Backend configuration URI.</summary>
    [JsonPropertyName("backendURI")]
    public string? BackendURI { get; set; }

    /// <summary>Information for the loadbalancer backends.</summary>
    [JsonPropertyName("backends")]
    public IList<V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsLoadBalancerBackends>? Backends { get; set; }

    /// <summary>URI of the health check for the load balancer. Deprecated and no longer populated as different load balancer backends might have different health checks.</summary>
    [JsonPropertyName("healthCheckURI")]
    public string? HealthCheckURI { get; set; }

    /// <summary>Type of the load balancer.</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }
}

/// <summary>Display information of a specific load balancer backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsLoadBalancerBackendInfo
{
    /// <summary>URI of the backend bucket this backend targets (if applicable).</summary>
    [JsonPropertyName("backendBucketURI")]
    public string? BackendBucketURI { get; set; }

    /// <summary>URI of the backend service this backend belongs to (if applicable).</summary>
    [JsonPropertyName("backendServiceURI")]
    public string? BackendServiceURI { get; set; }

    /// <summary>Output only. Health check firewalls configuration state for the backend. This is a result of the static firewall analysis (verifying that health check traffic from required IP ranges to the backend is allowed or not). The backend might still be unhealthy even if these firewalls are configured. Please refer to the documentation for more information: https://cloud.google.com/load-balancing/docs/firewall-rules</summary>
    [JsonPropertyName("healthCheckFirewallsConfigState")]
    public string? HealthCheckFirewallsConfigState { get; set; }

    /// <summary>URI of the health check attached to this backend (if applicable).</summary>
    [JsonPropertyName("healthCheckURI")]
    public string? HealthCheckURI { get; set; }

    /// <summary>URI of the instance group this backend belongs to (if applicable).</summary>
    [JsonPropertyName("instanceGroupURI")]
    public string? InstanceGroupURI { get; set; }

    /// <summary>URI of the backend instance (if applicable). Populated for instance group backends, and zonal NEG backends.</summary>
    [JsonPropertyName("instanceURI")]
    public string? InstanceURI { get; set; }

    /// <summary>Display name of the backend. For example, it might be an instance name for the instance group backends, or an IP address and port for zonal network endpoint group backends.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>URI of the network endpoint group this backend belongs to (if applicable).</summary>
    [JsonPropertyName("networkEndpointGroupURI")]
    public string? NetworkEndpointGroupURI { get; set; }

    /// <summary>PSC Google API target this PSC NEG backend targets (if applicable).</summary>
    [JsonPropertyName("pscGoogleAPITarget")]
    public string? PscGoogleAPITarget { get; set; }

    /// <summary>URI of the PSC service attachment this PSC NEG backend targets (if applicable).</summary>
    [JsonPropertyName("pscServiceAttachmentURI")]
    public string? PscServiceAttachmentURI { get; set; }
}

/// <summary>Display information of a NAT.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsNat
{
    /// <summary>The name of Cloud NAT Gateway. Only valid when type is CLOUD_NAT.</summary>
    [JsonPropertyName("natGatewayName")]
    public string? NatGatewayName { get; set; }

    /// <summary>URI of the network where NAT translation takes place.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>Destination IP address after NAT translation.</summary>
    [JsonPropertyName("newDestinationIP")]
    public string? NewDestinationIP { get; set; }

    /// <summary>Destination port after NAT translation. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("newDestinationPort")]
    public int? NewDestinationPort { get; set; }

    /// <summary>Source IP address after NAT translation.</summary>
    [JsonPropertyName("newSourceIP")]
    public string? NewSourceIP { get; set; }

    /// <summary>Source port after NAT translation. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("newSourcePort")]
    public int? NewSourcePort { get; set; }

    /// <summary>Destination IP address before NAT translation.</summary>
    [JsonPropertyName("oldDestinationIP")]
    public string? OldDestinationIP { get; set; }

    /// <summary>Destination port before NAT translation. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("oldDestinationPort")]
    public int? OldDestinationPort { get; set; }

    /// <summary>Source IP address before NAT translation.</summary>
    [JsonPropertyName("oldSourceIP")]
    public string? OldSourceIP { get; set; }

    /// <summary>Source port before NAT translation. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("oldSourcePort")]
    public int? OldSourcePort { get; set; }

    /// <summary>IP protocol in string format, for example: "TCP", "UDP", "ICMP".</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Uri of the Cloud Router. Only valid when type is CLOUD_NAT.</summary>
    [JsonPropertyName("routerURI")]
    public string? RouterURI { get; set; }

    /// <summary>Type of NAT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Display information of a Google Cloud network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsNetwork
{
    /// <summary>Name of a Compute Engine network.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The IP range of the subnet matching the source IP address of the test.</summary>
    [JsonPropertyName("matchedIPRange")]
    public string? MatchedIPRange { get; set; }

    /// <summary>URI of the subnet matching the source IP address of the test.</summary>
    [JsonPropertyName("matchedSubnetURI")]
    public string? MatchedSubnetURI { get; set; }

    /// <summary>The region of the subnet matching the source IP address of the test.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>URI of a Compute Engine network.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Display information of a ProxyConnection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsProxyConnection
{
    /// <summary>URI of the network where connection is proxied.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>Destination IP address of a new connection.</summary>
    [JsonPropertyName("newDestinationIP")]
    public string? NewDestinationIP { get; set; }

    /// <summary>Destination port of a new connection. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("newDestinationPort")]
    public int? NewDestinationPort { get; set; }

    /// <summary>Source IP address of a new connection.</summary>
    [JsonPropertyName("newSourceIP")]
    public string? NewSourceIP { get; set; }

    /// <summary>Source port of a new connection. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("newSourcePort")]
    public int? NewSourcePort { get; set; }

    /// <summary>Destination IP address of an original connection</summary>
    [JsonPropertyName("oldDestinationIP")]
    public string? OldDestinationIP { get; set; }

    /// <summary>Destination port of an original connection. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("oldDestinationPort")]
    public int? OldDestinationPort { get; set; }

    /// <summary>Source IP address of an original connection.</summary>
    [JsonPropertyName("oldSourceIP")]
    public string? OldSourceIP { get; set; }

    /// <summary>Source port of an original connection. Only valid when protocol is TCP or UDP.</summary>
    [JsonPropertyName("oldSourcePort")]
    public int? OldSourcePort { get; set; }

    /// <summary>IP protocol in string format, for example: "TCP", "UDP", "ICMP".</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Uri of proxy subnet.</summary>
    [JsonPropertyName("subnetURI")]
    public string? SubnetURI { get; set; }
}

/// <summary>Display information of a Redis Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsRedisCluster
{
    /// <summary>Discovery endpoint IP address of a Redis Cluster.</summary>
    [JsonPropertyName("discoveryEndpointIPAddress")]
    public string? DiscoveryEndpointIPAddress { get; set; }

    /// <summary>Name of a Redis Cluster.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Name of the region in which the Redis Cluster is defined. For example, "us-central1".</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>URI of a Redis Cluster network in format "projects/{project_id}/global/networks/{network_id}".</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>Secondary endpoint IP address of a Redis Cluster.</summary>
    [JsonPropertyName("secondaryEndpointIPAddress")]
    public string? SecondaryEndpointIPAddress { get; set; }

    /// <summary>URI of a Redis Cluster in format "projects/{project_id}/locations/{location}/clusters/{cluster_id}"</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Display information of a Redis Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsRedisInstance
{
    /// <summary>Name of a Cloud Redis Instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>URI of a Cloud Redis Instance network.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>Primary endpoint IP address of a Cloud Redis Instance.</summary>
    [JsonPropertyName("primaryEndpointIP")]
    public string? PrimaryEndpointIP { get; set; }

    /// <summary>Read endpoint IP address of a Cloud Redis Instance (if applicable).</summary>
    [JsonPropertyName("readEndpointIP")]
    public string? ReadEndpointIP { get; set; }

    /// <summary>Region in which the Cloud Redis Instance is defined.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>URI of a Cloud Redis Instance.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Display information of a Compute Engine route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsRoute
{
    /// <summary>For advertised routes, the URI of their next hop, i.e. the URI of the hybrid endpoint (VPN tunnel, Interconnect attachment, NCC router appliance) the advertised prefix is advertised through, or URI of the source peered network.</summary>
    [JsonPropertyName("advertisedRouteNextHopURI")]
    public string? AdvertisedRouteNextHopURI { get; set; }

    /// <summary>For advertised dynamic routes, the URI of the Cloud Router that advertised the corresponding IP prefix.</summary>
    [JsonPropertyName("advertisedRouteSourceRouterURI")]
    public string? AdvertisedRouteSourceRouterURI { get; set; }

    /// <summary>Destination IP range of the route.</summary>
    [JsonPropertyName("destIPRange")]
    public string? DestIPRange { get; set; }

    /// <summary>Destination port ranges of the route. Policy based routes only.</summary>
    [JsonPropertyName("destPortRanges")]
    public IList<string>? DestPortRanges { get; set; }

    /// <summary>Name of a route.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Instance tags of the route.</summary>
    [JsonPropertyName("instanceTags")]
    public IList<string>? InstanceTags { get; set; }

    /// <summary>URI of a NCC Hub. NCC_HUB routes only.</summary>
    [JsonPropertyName("nccHubURI")]
    public string? NccHubURI { get; set; }

    /// <summary>URI of a NCC Spoke. NCC_HUB routes only.</summary>
    [JsonPropertyName("nccSpokeURI")]
    public string? NccSpokeURI { get; set; }

    /// <summary>URI of a Compute Engine network. NETWORK routes only.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>Next hop of the route.</summary>
    [JsonPropertyName("nextHop")]
    public string? NextHop { get; set; }

    /// <summary>Type of next hop.</summary>
    [JsonPropertyName("nextHopType")]
    public string? NextHopType { get; set; }

    /// <summary>Priority of the route.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Protocols of the route. Policy based routes only.</summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary>Region of the route (if applicable).</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Indicates where route is applicable.</summary>
    [JsonPropertyName("routeScope")]
    public string? RouteScope { get; set; }

    /// <summary>Type of route.</summary>
    [JsonPropertyName("routeType")]
    public string? RouteType { get; set; }

    /// <summary>Source IP address range of the route. Policy based routes only.</summary>
    [JsonPropertyName("srcIPRange")]
    public string? SrcIPRange { get; set; }

    /// <summary>Source port ranges of the route. Policy based routes only.</summary>
    [JsonPropertyName("srcPortRanges")]
    public IList<string>? SrcPortRanges { get; set; }

    /// <summary>URI of a route (if applicable).</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Display information of a Serverless network endpoint group backend. Used only for return traces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsServerlessNeg
{
    /// <summary>URI of the serverless network endpoint group.</summary>
    [JsonPropertyName("negURI")]
    public string? NegURI { get; set; }
}

/// <summary>Display information of a Storage Bucket. Used only for return traces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsStorageBucket
{
    /// <summary>Cloud Storage Bucket name.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }
}

/// <summary>Display information of a VPC connector.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsVpcConnector
{
    /// <summary>Name of a VPC connector.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Location in which the VPC connector is deployed.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>URI of a VPC connector.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Display information of a Compute Engine VPN gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsVpnGateway
{
    /// <summary>Name of a VPN gateway.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>IP address of the VPN gateway.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>URI of a Compute Engine network where the VPN gateway is configured.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>Name of a Google Cloud region where this VPN gateway is configured.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>URI of a VPN gateway.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>A VPN tunnel that is associated with this VPN gateway. There may be multiple VPN tunnels configured on a VPN gateway, and only the one relevant to the test is displayed.</summary>
    [JsonPropertyName("vpnTunnelURI")]
    public string? VpnTunnelURI { get; set; }
}

/// <summary>Display information of a Compute Engine VPN tunnel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsVpnTunnel
{
    /// <summary>Name of a VPN tunnel.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>URI of a Compute Engine network where the VPN tunnel is configured.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>Name of a Google Cloud region where this VPN tunnel is configured.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>URI of a VPN gateway at remote end of the tunnel.</summary>
    [JsonPropertyName("remoteGateway")]
    public string? RemoteGateway { get; set; }

    /// <summary>Remote VPN gateway's IP address.</summary>
    [JsonPropertyName("remoteGatewayIP")]
    public string? RemoteGatewayIP { get; set; }

    /// <summary>Type of the routing policy.</summary>
    [JsonPropertyName("routingType")]
    public string? RoutingType { get; set; }

    /// <summary>URI of the VPN gateway at local end of the tunnel.</summary>
    [JsonPropertyName("sourceGateway")]
    public string? SourceGateway { get; set; }

    /// <summary>Local VPN gateway's IP address.</summary>
    [JsonPropertyName("sourceGatewayIP")]
    public string? SourceGatewayIP { get; set; }

    /// <summary>URI of a VPN tunnel.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesSteps
{
    /// <summary>Display information of the final state "abort" and reason.</summary>
    [JsonPropertyName("abort")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsAbort? Abort { get; set; }

    /// <summary>Display information of an App Engine service version.</summary>
    [JsonPropertyName("appEngineVersion")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsAppEngineVersion? AppEngineVersion { get; set; }

    /// <summary>This is a step that leads to the final state Drop.</summary>
    [JsonPropertyName("causesDrop")]
    public bool? CausesDrop { get; set; }

    /// <summary>Display information of a Cloud Function.</summary>
    [JsonPropertyName("cloudFunction")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsCloudFunction? CloudFunction { get; set; }

    /// <summary>Display information of a Cloud Run revision.</summary>
    [JsonPropertyName("cloudRunRevision")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsCloudRunRevision? CloudRunRevision { get; set; }

    /// <summary>Display information of a Cloud SQL instance.</summary>
    [JsonPropertyName("cloudSQLInstance")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsCloudSQLInstance? CloudSQLInstance { get; set; }

    /// <summary>Display information of the final state "deliver" and reason.</summary>
    [JsonPropertyName("deliver")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsDeliver? Deliver { get; set; }

    /// <summary>A description of the step. Usually this is a summary of the state.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display information of the final state "drop" and reason.</summary>
    [JsonPropertyName("drop")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsDrop? Drop { get; set; }

    /// <summary>Display information of the source and destination under analysis. The endpoint information in an intermediate state may differ with the initial input, as it might be modified by state like NAT, or Connection Proxy.</summary>
    [JsonPropertyName("endpoint")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsEndpoint? Endpoint { get; set; }

    /// <summary>Display information of a Compute Engine firewall rule.</summary>
    [JsonPropertyName("firewall")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsFirewall? Firewall { get; set; }

    /// <summary>Display information of the final state "forward" and reason.</summary>
    [JsonPropertyName("forward")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsForward? Forward { get; set; }

    /// <summary>Display information of a Compute Engine forwarding rule.</summary>
    [JsonPropertyName("forwardingRule")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsForwardingRule? ForwardingRule { get; set; }

    /// <summary>Display information of a Google Kubernetes Engine cluster master.</summary>
    [JsonPropertyName("gkeMaster")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsGkeMaster? GkeMaster { get; set; }

    /// <summary>Display information of a Google service</summary>
    [JsonPropertyName("googleService")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsGoogleService? GoogleService { get; set; }

    /// <summary>Display information of a Compute Engine instance.</summary>
    [JsonPropertyName("instance")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsInstance? Instance { get; set; }

    /// <summary>Display information of the load balancers. Deprecated in favor of the `load_balancer_backend_info` field, not used in new tests.</summary>
    [JsonPropertyName("loadBalancer")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsLoadBalancer? LoadBalancer { get; set; }

    /// <summary>Display information of a specific load balancer backend.</summary>
    [JsonPropertyName("loadBalancerBackendInfo")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsLoadBalancerBackendInfo? LoadBalancerBackendInfo { get; set; }

    /// <summary>Display information of a NAT.</summary>
    [JsonPropertyName("nat")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsNat? Nat { get; set; }

    /// <summary>Display information of a Google Cloud network.</summary>
    [JsonPropertyName("network")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsNetwork? Network { get; set; }

    /// <summary>Project ID that contains the configuration this step is validating.</summary>
    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }

    /// <summary>Display information of a ProxyConnection.</summary>
    [JsonPropertyName("proxyConnection")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsProxyConnection? ProxyConnection { get; set; }

    /// <summary>Display information of a Redis Cluster.</summary>
    [JsonPropertyName("redisCluster")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsRedisCluster? RedisCluster { get; set; }

    /// <summary>Display information of a Redis Instance.</summary>
    [JsonPropertyName("redisInstance")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsRedisInstance? RedisInstance { get; set; }

    /// <summary>Display information of a Compute Engine route.</summary>
    [JsonPropertyName("route")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsRoute? Route { get; set; }

    /// <summary>Display information of a Serverless network endpoint group backend. Used only for return traces.</summary>
    [JsonPropertyName("serverlessNeg")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsServerlessNeg? ServerlessNeg { get; set; }

    /// <summary>Each step is in one of the pre-defined states.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Display information of a Storage Bucket. Used only for return traces.</summary>
    [JsonPropertyName("storageBucket")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsStorageBucket? StorageBucket { get; set; }

    /// <summary>Display information of a VPC connector.</summary>
    [JsonPropertyName("vpcConnector")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsVpcConnector? VpcConnector { get; set; }

    /// <summary>Display information of a Compute Engine VPN gateway.</summary>
    [JsonPropertyName("vpnGateway")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsVpnGateway? VpnGateway { get; set; }

    /// <summary>Display information of a Compute Engine VPN tunnel.</summary>
    [JsonPropertyName("vpnTunnel")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesStepsVpnTunnel? VpnTunnel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTraces
{
    /// <summary>Derived from the source and destination endpoints definition specified by user request, and validated by the data plane model. If there are multiple traces starting from different source locations, then the endpoint_info may be different between traces.</summary>
    [JsonPropertyName("endpointInfo")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesEndpointInfo? EndpointInfo { get; set; }

    /// <summary>ID of trace. For forward traces, this ID is unique for each trace. For return traces, it matches ID of associated forward trace. A single forward trace can be associated with none, one or more than one return trace.</summary>
    [JsonPropertyName("forwardTraceID")]
    public int? ForwardTraceID { get; set; }

    /// <summary>A trace of a test contains multiple steps from the initial state to the  final state (delivered, dropped, forwarded, or aborted).   The steps are ordered by the processing sequence within the simulated  network state machine. It is critical to preserve the order of the steps  and avoid reordering or sorting them.</summary>
    [JsonPropertyName("steps")]
    public IList<V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTracesSteps>? Steps { get; set; }
}

/// <summary>Output only. The reachability details of this test from the latest run for the return path. The details are updated when creating a new test, updating an existing test, or triggering a one-time rerun of an existing test.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetails
{
    /// <summary>The details of a failure or a cancellation of reachability analysis.</summary>
    [JsonPropertyName("error")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsError? Error { get; set; }

    /// <summary>The overall result of the test's configuration analysis.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>Result may contain a list of traces if a test has multiple possible paths in the network, such as when destination endpoint is a load balancer with multiple backends.</summary>
    [JsonPropertyName("traces")]
    public IList<V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetailsTraces>? Traces { get; set; }

    /// <summary>The time of the configuration analysis.</summary>
    [JsonPropertyName("verifyTime")]
    public string? VerifyTime { get; set; }
}

/// <summary>Source specification of the Connectivity Test.   You can use a combination of source IP address, virtual machine  (VM) instance, or Compute Engine network to uniquely identify  the source location.   Examples:  If the source IP address is an internal IP address within a Google Cloud  Virtual Private Cloud (VPC) network, then you must also specify the VPC  network. Otherwise, specify the VM instance, which already contains its  internal IP address and VPC network information.   If the source of the test is within an on-premises network, then you must  provide the destination VPC network.   If the source endpoint is a Compute Engine VM instance with multiple  network interfaces, the instance itself is not sufficient to identify the  endpoint. So, you must also specify the source IP address or VPC network.   A reachability analysis proceeds even if the source location is  ambiguous. However, the test result may include endpoints that you don't  intend to test.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedStateSource
{
    /// <summary>Output only. Specifies the type of the target of the forwarding rule.</summary>
    [JsonPropertyName("forwardingRuleTarget")]
    public string? ForwardingRuleTarget { get; set; }

    /// <summary>Output only. ID of the load balancer the forwarding rule points to. Empty for forwarding rules not related to load balancers.</summary>
    [JsonPropertyName("loadBalancerID")]
    public string? LoadBalancerID { get; set; }

    /// <summary>Output only. Type of the load balancer the forwarding rule points to.</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatusObservedState
{
    /// <summary>Output only. The time the test was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Destination specification of the Connectivity Test.   You can use a combination of destination IP address, Compute Engine  VM instance, or VPC network to uniquely identify the destination  location.   Even if the destination IP address is not unique, the source IP  location is unique. Usually, the analysis can infer the destination  endpoint from route information.   If the destination you specify is a VM instance and the instance has  multiple network interfaces, then you must also specify either  a destination IP address  or VPC network to identify the destination  interface.   A reachability analysis proceeds even if the destination location is  ambiguous. However, the result can include endpoints that you don't  intend to test.</summary>
    [JsonPropertyName("destination")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateDestination? Destination { get; set; }

    /// <summary>Output only. The display name of a Connectivity Test.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Output only. The probing details of this test from the latest run, present for applicable tests only. The details are updated when creating a new test, updating an existing test, or triggering a one-time rerun of an existing test.</summary>
    [JsonPropertyName("probingDetails")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateProbingDetails? ProbingDetails { get; set; }

    /// <summary>Output only. The reachability details of this test from the latest run. The details are updated when creating a new test, updating an existing test, or triggering a one-time rerun of an existing test.</summary>
    [JsonPropertyName("reachabilityDetails")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReachabilityDetails? ReachabilityDetails { get; set; }

    /// <summary>Output only. The reachability details of this test from the latest run for the return path. The details are updated when creating a new test, updating an existing test, or triggering a one-time rerun of an existing test.</summary>
    [JsonPropertyName("returnReachabilityDetails")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateReturnReachabilityDetails? ReturnReachabilityDetails { get; set; }

    /// <summary>Source specification of the Connectivity Test.   You can use a combination of source IP address, virtual machine  (VM) instance, or Compute Engine network to uniquely identify  the source location.   Examples:  If the source IP address is an internal IP address within a Google Cloud  Virtual Private Cloud (VPC) network, then you must also specify the VPC  network. Otherwise, specify the VM instance, which already contains its  internal IP address and VPC network information.   If the source of the test is within an on-premises network, then you must  provide the destination VPC network.   If the source endpoint is a Compute Engine VM instance with multiple  network interfaces, the instance itself is not sufficient to identify the  endpoint. So, you must also specify the source IP address or VPC network.   A reachability analysis proceeds even if the source location is  ambiguous. However, the test result may include endpoints that you don't  intend to test.</summary>
    [JsonPropertyName("source")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedStateSource? Source { get; set; }

    /// <summary>Output only. The time the test's configuration was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>NetworkManagementConnectivityTestStatus defines the config connector machine state of NetworkManagementConnectivityTest</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkManagementConnectivityTestStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NetworkManagementConnectivityTestStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the NetworkManagementConnectivityTest resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1NetworkManagementConnectivityTestStatusObservedState? ObservedState { get; set; }
}

/// <summary>NetworkManagementConnectivityTest is the Schema for the NetworkManagementConnectivityTest API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkManagementConnectivityTest : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NetworkManagementConnectivityTestSpec>, IStatus<V1alpha1NetworkManagementConnectivityTestStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkManagementConnectivityTest";
    public const string KubeGroup = "networkmanagement.cnrm.cloud.google.com";
    public const string KubePluralName = "networkmanagementconnectivitytests";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetworkManagementConnectivityTestSpec defines the desired state of NetworkManagementConnectivityTest</summary>
    [JsonPropertyName("spec")]
    public V1alpha1NetworkManagementConnectivityTestSpec Spec { get; set; }

    /// <summary>NetworkManagementConnectivityTestStatus defines the config connector machine state of NetworkManagementConnectivityTest</summary>
    [JsonPropertyName("status")]
    public V1alpha1NetworkManagementConnectivityTestStatus? Status { get; set; }
}