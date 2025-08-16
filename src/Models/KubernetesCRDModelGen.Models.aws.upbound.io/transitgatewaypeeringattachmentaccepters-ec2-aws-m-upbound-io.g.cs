using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.m.upbound.io;
/// <summary>TransitGatewayPeeringAttachmentAccepter is the Schema for the TransitGatewayPeeringAttachmentAccepters API. Manages the accepter's side of an EC2 Transit Gateway peering Attachment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TransitGatewayPeeringAttachmentAccepterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1TransitGatewayPeeringAttachmentAccepter>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TransitGatewayPeeringAttachmentAccepterList";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "transitgatewaypeeringattachmentaccepters";
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
    public IList<V1beta1TransitGatewayPeeringAttachmentAccepter> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayPeeringAttachmentAccepterSpecForProviderTransitGatewayAttachmentIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a TransitGatewayPeeringAttachment in ec2 to populate transitGatewayAttachmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayPeeringAttachmentAccepterSpecForProviderTransitGatewayAttachmentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayPeeringAttachmentAccepterSpecForProviderTransitGatewayAttachmentIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayPeeringAttachmentAccepterSpecForProviderTransitGatewayAttachmentIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a TransitGatewayPeeringAttachment in ec2 to populate transitGatewayAttachmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayPeeringAttachmentAccepterSpecForProviderTransitGatewayAttachmentIdSelector
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
    public V1beta1TransitGatewayPeeringAttachmentAccepterSpecForProviderTransitGatewayAttachmentIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayPeeringAttachmentAccepterSpecForProvider
{
    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the EC2 Transit Gateway Peering Attachment to manage.</summary>
    [JsonPropertyName("transitGatewayAttachmentId")]
    public string? TransitGatewayAttachmentId { get; set; }

    /// <summary>Reference to a TransitGatewayPeeringAttachment in ec2 to populate transitGatewayAttachmentId.</summary>
    [JsonPropertyName("transitGatewayAttachmentIdRef")]
    public V1beta1TransitGatewayPeeringAttachmentAccepterSpecForProviderTransitGatewayAttachmentIdRef? TransitGatewayAttachmentIdRef { get; set; }

    /// <summary>Selector for a TransitGatewayPeeringAttachment in ec2 to populate transitGatewayAttachmentId.</summary>
    [JsonPropertyName("transitGatewayAttachmentIdSelector")]
    public V1beta1TransitGatewayPeeringAttachmentAccepterSpecForProviderTransitGatewayAttachmentIdSelector? TransitGatewayAttachmentIdSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayPeeringAttachmentAccepterSpecInitProviderTransitGatewayAttachmentIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a TransitGatewayPeeringAttachment in ec2 to populate transitGatewayAttachmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayPeeringAttachmentAccepterSpecInitProviderTransitGatewayAttachmentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayPeeringAttachmentAccepterSpecInitProviderTransitGatewayAttachmentIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayPeeringAttachmentAccepterSpecInitProviderTransitGatewayAttachmentIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a TransitGatewayPeeringAttachment in ec2 to populate transitGatewayAttachmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayPeeringAttachmentAccepterSpecInitProviderTransitGatewayAttachmentIdSelector
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
    public V1beta1TransitGatewayPeeringAttachmentAccepterSpecInitProviderTransitGatewayAttachmentIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayPeeringAttachmentAccepterSpecInitProvider
{
    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the EC2 Transit Gateway Peering Attachment to manage.</summary>
    [JsonPropertyName("transitGatewayAttachmentId")]
    public string? TransitGatewayAttachmentId { get; set; }

    /// <summary>Reference to a TransitGatewayPeeringAttachment in ec2 to populate transitGatewayAttachmentId.</summary>
    [JsonPropertyName("transitGatewayAttachmentIdRef")]
    public V1beta1TransitGatewayPeeringAttachmentAccepterSpecInitProviderTransitGatewayAttachmentIdRef? TransitGatewayAttachmentIdRef { get; set; }

    /// <summary>Selector for a TransitGatewayPeeringAttachment in ec2 to populate transitGatewayAttachmentId.</summary>
    [JsonPropertyName("transitGatewayAttachmentIdSelector")]
    public V1beta1TransitGatewayPeeringAttachmentAccepterSpecInitProviderTransitGatewayAttachmentIdSelector? TransitGatewayAttachmentIdSelector { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayPeeringAttachmentAccepterSpecProviderConfigRef
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
public partial class V1beta1TransitGatewayPeeringAttachmentAccepterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>TransitGatewayPeeringAttachmentAccepterSpec defines the desired state of TransitGatewayPeeringAttachmentAccepter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayPeeringAttachmentAccepterSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TransitGatewayPeeringAttachmentAccepterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TransitGatewayPeeringAttachmentAccepterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TransitGatewayPeeringAttachmentAccepterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TransitGatewayPeeringAttachmentAccepterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayPeeringAttachmentAccepterStatusAtProvider
{
    /// <summary>EC2 Transit Gateway Attachment identifier</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identifier of the AWS account that owns the EC2 TGW peering.</summary>
    [JsonPropertyName("peerAccountId")]
    public string? PeerAccountId { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration.</summary>
    [JsonPropertyName("peerRegion")]
    public string? PeerRegion { get; set; }

    /// <summary>Identifier of EC2 Transit Gateway to peer with.</summary>
    [JsonPropertyName("peerTransitGatewayId")]
    public string? PeerTransitGatewayId { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The ID of the EC2 Transit Gateway Peering Attachment to manage.</summary>
    [JsonPropertyName("transitGatewayAttachmentId")]
    public string? TransitGatewayAttachmentId { get; set; }

    /// <summary>Identifier of EC2 Transit Gateway.</summary>
    [JsonPropertyName("transitGatewayId")]
    public string? TransitGatewayId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayPeeringAttachmentAccepterStatusConditions
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

/// <summary>TransitGatewayPeeringAttachmentAccepterStatus defines the observed state of TransitGatewayPeeringAttachmentAccepter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayPeeringAttachmentAccepterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TransitGatewayPeeringAttachmentAccepterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TransitGatewayPeeringAttachmentAccepterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>TransitGatewayPeeringAttachmentAccepter is the Schema for the TransitGatewayPeeringAttachmentAccepters API. Manages the accepter's side of an EC2 Transit Gateway peering Attachment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TransitGatewayPeeringAttachmentAccepter : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TransitGatewayPeeringAttachmentAccepterSpec>, IStatus<V1beta1TransitGatewayPeeringAttachmentAccepterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TransitGatewayPeeringAttachmentAccepter";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "transitgatewaypeeringattachmentaccepters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TransitGatewayPeeringAttachmentAccepterSpec defines the desired state of TransitGatewayPeeringAttachmentAccepter</summary>
    [JsonPropertyName("spec")]
    public V1beta1TransitGatewayPeeringAttachmentAccepterSpec Spec { get; set; }

    /// <summary>TransitGatewayPeeringAttachmentAccepterStatus defines the observed state of TransitGatewayPeeringAttachmentAccepter.</summary>
    [JsonPropertyName("status")]
    public V1beta1TransitGatewayPeeringAttachmentAccepterStatus? Status { get; set; }
}