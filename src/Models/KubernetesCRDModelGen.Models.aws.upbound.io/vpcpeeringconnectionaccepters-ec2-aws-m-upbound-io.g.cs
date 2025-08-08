using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.m.upbound.io;
/// <summary>A configuration block that describes [VPC Peering Connection] (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options set for the accepter VPC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterSpecForProviderAccepter
{
    /// <summary>Indicates whether a local VPC can resolve public DNS hostnames to private IP addresses when queried from instances in a peer VPC.</summary>
    [JsonPropertyName("allowRemoteVpcDnsResolution")]
    public bool? AllowRemoteVpcDnsResolution { get; set; }
}

/// <summary>A configuration block that describes [VPC Peering Connection] (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options set for the requester VPC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterSpecForProviderRequester
{
    /// <summary>Indicates whether a local VPC can resolve public DNS hostnames to private IP addresses when queried from instances in a peer VPC.</summary>
    [JsonPropertyName("allowRemoteVpcDnsResolution")]
    public bool? AllowRemoteVpcDnsResolution { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterSpecForProviderVpcPeeringConnectionIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VPCPeeringConnection in ec2 to populate vpcPeeringConnectionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterSpecForProviderVpcPeeringConnectionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCPeeringConnectionAccepterSpecForProviderVpcPeeringConnectionIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterSpecForProviderVpcPeeringConnectionIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VPCPeeringConnection in ec2 to populate vpcPeeringConnectionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterSpecForProviderVpcPeeringConnectionIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCPeeringConnectionAccepterSpecForProviderVpcPeeringConnectionIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterSpecForProvider
{
    /// <summary>A configuration block that describes [VPC Peering Connection] (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options set for the accepter VPC.</summary>
    [JsonPropertyName("accepter")]
    public V1beta1VPCPeeringConnectionAccepterSpecForProviderAccepter? Accepter { get; set; }

    /// <summary>Whether or not to accept the peering request. Defaults to false.</summary>
    [JsonPropertyName("autoAccept")]
    public bool? AutoAccept { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>A configuration block that describes [VPC Peering Connection] (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options set for the requester VPC.</summary>
    [JsonPropertyName("requester")]
    public V1beta1VPCPeeringConnectionAccepterSpecForProviderRequester? Requester { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The VPC Peering Connection ID to manage.</summary>
    [JsonPropertyName("vpcPeeringConnectionId")]
    public string? VpcPeeringConnectionId { get; set; }

    /// <summary>Reference to a VPCPeeringConnection in ec2 to populate vpcPeeringConnectionId.</summary>
    [JsonPropertyName("vpcPeeringConnectionIdRef")]
    public V1beta1VPCPeeringConnectionAccepterSpecForProviderVpcPeeringConnectionIdRef? VpcPeeringConnectionIdRef { get; set; }

    /// <summary>Selector for a VPCPeeringConnection in ec2 to populate vpcPeeringConnectionId.</summary>
    [JsonPropertyName("vpcPeeringConnectionIdSelector")]
    public V1beta1VPCPeeringConnectionAccepterSpecForProviderVpcPeeringConnectionIdSelector? VpcPeeringConnectionIdSelector { get; set; }
}

/// <summary>A configuration block that describes [VPC Peering Connection] (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options set for the accepter VPC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterSpecInitProviderAccepter
{
    /// <summary>Indicates whether a local VPC can resolve public DNS hostnames to private IP addresses when queried from instances in a peer VPC.</summary>
    [JsonPropertyName("allowRemoteVpcDnsResolution")]
    public bool? AllowRemoteVpcDnsResolution { get; set; }
}

/// <summary>A configuration block that describes [VPC Peering Connection] (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options set for the requester VPC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterSpecInitProviderRequester
{
    /// <summary>Indicates whether a local VPC can resolve public DNS hostnames to private IP addresses when queried from instances in a peer VPC.</summary>
    [JsonPropertyName("allowRemoteVpcDnsResolution")]
    public bool? AllowRemoteVpcDnsResolution { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterSpecInitProviderVpcPeeringConnectionIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VPCPeeringConnection in ec2 to populate vpcPeeringConnectionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterSpecInitProviderVpcPeeringConnectionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCPeeringConnectionAccepterSpecInitProviderVpcPeeringConnectionIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterSpecInitProviderVpcPeeringConnectionIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VPCPeeringConnection in ec2 to populate vpcPeeringConnectionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterSpecInitProviderVpcPeeringConnectionIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCPeeringConnectionAccepterSpecInitProviderVpcPeeringConnectionIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterSpecInitProvider
{
    /// <summary>A configuration block that describes [VPC Peering Connection] (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options set for the accepter VPC.</summary>
    [JsonPropertyName("accepter")]
    public V1beta1VPCPeeringConnectionAccepterSpecInitProviderAccepter? Accepter { get; set; }

    /// <summary>Whether or not to accept the peering request. Defaults to false.</summary>
    [JsonPropertyName("autoAccept")]
    public bool? AutoAccept { get; set; }

    /// <summary>A configuration block that describes [VPC Peering Connection] (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options set for the requester VPC.</summary>
    [JsonPropertyName("requester")]
    public V1beta1VPCPeeringConnectionAccepterSpecInitProviderRequester? Requester { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The VPC Peering Connection ID to manage.</summary>
    [JsonPropertyName("vpcPeeringConnectionId")]
    public string? VpcPeeringConnectionId { get; set; }

    /// <summary>Reference to a VPCPeeringConnection in ec2 to populate vpcPeeringConnectionId.</summary>
    [JsonPropertyName("vpcPeeringConnectionIdRef")]
    public V1beta1VPCPeeringConnectionAccepterSpecInitProviderVpcPeeringConnectionIdRef? VpcPeeringConnectionIdRef { get; set; }

    /// <summary>Selector for a VPCPeeringConnection in ec2 to populate vpcPeeringConnectionId.</summary>
    [JsonPropertyName("vpcPeeringConnectionIdSelector")]
    public V1beta1VPCPeeringConnectionAccepterSpecInitProviderVpcPeeringConnectionIdSelector? VpcPeeringConnectionIdSelector { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>VPCPeeringConnectionAccepterSpec defines the desired state of VPCPeeringConnectionAccepter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VPCPeeringConnectionAccepterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VPCPeeringConnectionAccepterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VPCPeeringConnectionAccepterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VPCPeeringConnectionAccepterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A configuration block that describes [VPC Peering Connection] (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options set for the accepter VPC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterStatusAtProviderAccepter
{
    /// <summary>Indicates whether a local VPC can resolve public DNS hostnames to private IP addresses when queried from instances in a peer VPC.</summary>
    [JsonPropertyName("allowRemoteVpcDnsResolution")]
    public bool? AllowRemoteVpcDnsResolution { get; set; }
}

/// <summary>A configuration block that describes [VPC Peering Connection] (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options set for the requester VPC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterStatusAtProviderRequester
{
    /// <summary>Indicates whether a local VPC can resolve public DNS hostnames to private IP addresses when queried from instances in a peer VPC.</summary>
    [JsonPropertyName("allowRemoteVpcDnsResolution")]
    public bool? AllowRemoteVpcDnsResolution { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterStatusAtProvider
{
    /// <summary>The status of the VPC Peering Connection request.</summary>
    [JsonPropertyName("acceptStatus")]
    public string? AcceptStatus { get; set; }

    /// <summary>A configuration block that describes [VPC Peering Connection] (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options set for the accepter VPC.</summary>
    [JsonPropertyName("accepter")]
    public V1beta1VPCPeeringConnectionAccepterStatusAtProviderAccepter? Accepter { get; set; }

    /// <summary>Whether or not to accept the peering request. Defaults to false.</summary>
    [JsonPropertyName("autoAccept")]
    public bool? AutoAccept { get; set; }

    /// <summary>The ID of the VPC Peering Connection.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The AWS account ID of the owner of the requester VPC.</summary>
    [JsonPropertyName("peerOwnerId")]
    public string? PeerOwnerId { get; set; }

    /// <summary>The region of the accepter VPC.</summary>
    [JsonPropertyName("peerRegion")]
    public string? PeerRegion { get; set; }

    /// <summary>The ID of the requester VPC.</summary>
    [JsonPropertyName("peerVpcId")]
    public string? PeerVpcId { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>A configuration block that describes [VPC Peering Connection] (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options set for the requester VPC.</summary>
    [JsonPropertyName("requester")]
    public V1beta1VPCPeeringConnectionAccepterStatusAtProviderRequester? Requester { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The ID of the accepter VPC.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>The VPC Peering Connection ID to manage.</summary>
    [JsonPropertyName("vpcPeeringConnectionId")]
    public string? VpcPeeringConnectionId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterStatusConditions
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

/// <summary>VPCPeeringConnectionAccepterStatus defines the observed state of VPCPeeringConnectionAccepter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCPeeringConnectionAccepterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VPCPeeringConnectionAccepterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VPCPeeringConnectionAccepterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>VPCPeeringConnectionAccepter is the Schema for the VPCPeeringConnectionAccepters API. Manage the accepter's side of a VPC Peering Connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VPCPeeringConnectionAccepter : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VPCPeeringConnectionAccepterSpec>, IStatus<V1beta1VPCPeeringConnectionAccepterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPCPeeringConnectionAccepter";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "vpcpeeringconnectionaccepters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VPCPeeringConnectionAccepterSpec defines the desired state of VPCPeeringConnectionAccepter</summary>
    [JsonPropertyName("spec")]
    public V1beta1VPCPeeringConnectionAccepterSpec Spec { get; set; }

    /// <summary>VPCPeeringConnectionAccepterStatus defines the observed state of VPCPeeringConnectionAccepter.</summary>
    [JsonPropertyName("status")]
    public V1beta1VPCPeeringConnectionAccepterStatus? Status { get; set; }
}

/// <summary>VPCPeeringConnectionAccepter is the Schema for the VPCPeeringConnectionAccepters API. Manage the accepter's side of a VPC Peering Connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VPCPeeringConnectionAccepterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1VPCPeeringConnectionAccepter>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPCPeeringConnectionAccepterList";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "vpcpeeringconnectionaccepters";
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
    public IList<V1beta1VPCPeeringConnectionAccepter> Items { get; set; }
}