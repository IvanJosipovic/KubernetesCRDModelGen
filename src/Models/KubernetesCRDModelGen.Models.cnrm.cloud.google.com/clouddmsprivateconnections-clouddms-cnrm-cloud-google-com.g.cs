using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.clouddms.cnrm.cloud.google.com;
#nullable enable
/// <summary>CloudDMSPrivateConnection is the Schema for the CloudDMSPrivateConnection API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudDMSPrivateConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CloudDMSPrivateConnection>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudDMSPrivateConnectionList";
    public const string KubeGroup = "clouddms.cnrm.cloud.google.com";
    public const string KubePluralName = "clouddmsprivateconnections";
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
    public IList<V1alpha1CloudDMSPrivateConnection> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. The host project of the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSPrivateConnectionSpecProjectRef
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
#nullable disable

#nullable enable
/// <summary>Required. Fully qualified name of the VPC that Database Migration Service will peer to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSPrivateConnectionSpecVpcPeeringConfigVpcNameRef
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
#nullable disable

#nullable enable
/// <summary>VPC peering configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSPrivateConnectionSpecVpcPeeringConfig
{
    /// <summary>Required. A free subnet for peering. (CIDR of /29)</summary>
    [JsonPropertyName("subnet")]
    public string? Subnet { get; set; }

    /// <summary>Required. Fully qualified name of the VPC that Database Migration Service will peer to.</summary>
    [JsonPropertyName("vpcNameRef")]
    public V1alpha1CloudDMSPrivateConnectionSpecVpcPeeringConfigVpcNameRef? VpcNameRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CloudDMSPrivateConnectionSpec defines the desired state of CloudDMSPrivateConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSPrivateConnectionSpec
{
    /// <summary>The private connection display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The resource labels for private connections to use to annotate any related  underlying resources such as Compute Engine VMs. An object containing a  list of "key": "value" pairs.   Example: `{ "name": "wrench", "mass": "1.3kg", "count": "3" }`.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Required. The location of the application.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Required. The host project of the application.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1CloudDMSPrivateConnectionSpecProjectRef? ProjectRef { get; set; }

    /// <summary>The CloudDMSPrivateConnection name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>VPC peering configuration.</summary>
    [JsonPropertyName("vpcPeeringConfig")]
    public V1alpha1CloudDMSPrivateConnectionSpecVpcPeeringConfig? VpcPeeringConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSPrivateConnectionStatusConditions
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
#nullable disable

#nullable enable
/// <summary>Output only. The error details in case of state FAILED.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSPrivateConnectionStatusObservedStateError
{
    /// <summary>The status code, which should be an enum value of [google.rpc.Code][google.rpc.Code].</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should be localized and sent in the [google.rpc.Status.details][google.rpc.Status.details] field, or localized by the client.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSPrivateConnectionStatusObservedState
{
    /// <summary>Output only. The create time of the resource.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The error details in case of state FAILED.</summary>
    [JsonPropertyName("error")]
    public V1alpha1CloudDMSPrivateConnectionStatusObservedStateError? Error { get; set; }

    /// <summary>Output only. The state of the private connection.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The last update time of the resource.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CloudDMSPrivateConnectionStatus defines the config connector machine state of CloudDMSPrivateConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSPrivateConnectionStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudDMSPrivateConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the CloudDMSPrivateConnection resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1CloudDMSPrivateConnectionStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CloudDMSPrivateConnection is the Schema for the CloudDMSPrivateConnection API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudDMSPrivateConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudDMSPrivateConnectionSpec>, IStatus<V1alpha1CloudDMSPrivateConnectionStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudDMSPrivateConnection";
    public const string KubeGroup = "clouddms.cnrm.cloud.google.com";
    public const string KubePluralName = "clouddmsprivateconnections";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CloudDMSPrivateConnectionSpec defines the desired state of CloudDMSPrivateConnection</summary>
    [JsonPropertyName("spec")]
    public V1alpha1CloudDMSPrivateConnectionSpec Spec { get; set; }

    /// <summary>CloudDMSPrivateConnectionStatus defines the config connector machine state of CloudDMSPrivateConnection</summary>
    [JsonPropertyName("status")]
    public V1alpha1CloudDMSPrivateConnectionStatus? Status { get; set; }
}
#nullable disable
