using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.m.upbound.io;
/// <summary>TransitGatewayConnect is the Schema for the TransitGatewayConnects API. Manages an EC2 Transit Gateway Connect</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TransitGatewayConnectList : IKubernetesObject<V1ListMeta>, IItems<V1beta1TransitGatewayConnect>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TransitGatewayConnectList";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "transitgatewayconnects";
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
    public IList<V1beta1TransitGatewayConnect> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectSpecForProviderTransitGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a TransitGateway in ec2 to populate transitGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectSpecForProviderTransitGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayConnectSpecForProviderTransitGatewayIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectSpecForProviderTransitGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a TransitGateway in ec2 to populate transitGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectSpecForProviderTransitGatewayIdSelector
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
    public V1beta1TransitGatewayConnectSpecForProviderTransitGatewayIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectSpecForProviderTransportAttachmentIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a TransitGatewayVPCAttachment in ec2 to populate transportAttachmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectSpecForProviderTransportAttachmentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayConnectSpecForProviderTransportAttachmentIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectSpecForProviderTransportAttachmentIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a TransitGatewayVPCAttachment in ec2 to populate transportAttachmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectSpecForProviderTransportAttachmentIdSelector
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
    public V1beta1TransitGatewayConnectSpecForProviderTransportAttachmentIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectSpecForProvider
{
    /// <summary>The tunnel protocol. Valid values: gre. Default is gre.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Boolean whether the Connect should be associated with the EC2 Transit Gateway association default route table. This cannot be configured or perform drift detection with Resource Access Manager shared EC2 Transit Gateways. Default value: true.</summary>
    [JsonPropertyName("transitGatewayDefaultRouteTableAssociation")]
    public bool? TransitGatewayDefaultRouteTableAssociation { get; set; }

    /// <summary>Boolean whether the Connect should propagate routes with the EC2 Transit Gateway propagation default route table. This cannot be configured or perform drift detection with Resource Access Manager shared EC2 Transit Gateways. Default value: true.</summary>
    [JsonPropertyName("transitGatewayDefaultRouteTablePropagation")]
    public bool? TransitGatewayDefaultRouteTablePropagation { get; set; }

    /// <summary>Identifier of EC2 Transit Gateway.</summary>
    [JsonPropertyName("transitGatewayId")]
    public string? TransitGatewayId { get; set; }

    /// <summary>Reference to a TransitGateway in ec2 to populate transitGatewayId.</summary>
    [JsonPropertyName("transitGatewayIdRef")]
    public V1beta1TransitGatewayConnectSpecForProviderTransitGatewayIdRef? TransitGatewayIdRef { get; set; }

    /// <summary>Selector for a TransitGateway in ec2 to populate transitGatewayId.</summary>
    [JsonPropertyName("transitGatewayIdSelector")]
    public V1beta1TransitGatewayConnectSpecForProviderTransitGatewayIdSelector? TransitGatewayIdSelector { get; set; }

    /// <summary>The underlaying VPC attachment</summary>
    [JsonPropertyName("transportAttachmentId")]
    public string? TransportAttachmentId { get; set; }

    /// <summary>Reference to a TransitGatewayVPCAttachment in ec2 to populate transportAttachmentId.</summary>
    [JsonPropertyName("transportAttachmentIdRef")]
    public V1beta1TransitGatewayConnectSpecForProviderTransportAttachmentIdRef? TransportAttachmentIdRef { get; set; }

    /// <summary>Selector for a TransitGatewayVPCAttachment in ec2 to populate transportAttachmentId.</summary>
    [JsonPropertyName("transportAttachmentIdSelector")]
    public V1beta1TransitGatewayConnectSpecForProviderTransportAttachmentIdSelector? TransportAttachmentIdSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectSpecInitProviderTransitGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a TransitGateway in ec2 to populate transitGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectSpecInitProviderTransitGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayConnectSpecInitProviderTransitGatewayIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectSpecInitProviderTransitGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a TransitGateway in ec2 to populate transitGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectSpecInitProviderTransitGatewayIdSelector
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
    public V1beta1TransitGatewayConnectSpecInitProviderTransitGatewayIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectSpecInitProviderTransportAttachmentIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a TransitGatewayVPCAttachment in ec2 to populate transportAttachmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectSpecInitProviderTransportAttachmentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TransitGatewayConnectSpecInitProviderTransportAttachmentIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectSpecInitProviderTransportAttachmentIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a TransitGatewayVPCAttachment in ec2 to populate transportAttachmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectSpecInitProviderTransportAttachmentIdSelector
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
    public V1beta1TransitGatewayConnectSpecInitProviderTransportAttachmentIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectSpecInitProvider
{
    /// <summary>The tunnel protocol. Valid values: gre. Default is gre.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Boolean whether the Connect should be associated with the EC2 Transit Gateway association default route table. This cannot be configured or perform drift detection with Resource Access Manager shared EC2 Transit Gateways. Default value: true.</summary>
    [JsonPropertyName("transitGatewayDefaultRouteTableAssociation")]
    public bool? TransitGatewayDefaultRouteTableAssociation { get; set; }

    /// <summary>Boolean whether the Connect should propagate routes with the EC2 Transit Gateway propagation default route table. This cannot be configured or perform drift detection with Resource Access Manager shared EC2 Transit Gateways. Default value: true.</summary>
    [JsonPropertyName("transitGatewayDefaultRouteTablePropagation")]
    public bool? TransitGatewayDefaultRouteTablePropagation { get; set; }

    /// <summary>Identifier of EC2 Transit Gateway.</summary>
    [JsonPropertyName("transitGatewayId")]
    public string? TransitGatewayId { get; set; }

    /// <summary>Reference to a TransitGateway in ec2 to populate transitGatewayId.</summary>
    [JsonPropertyName("transitGatewayIdRef")]
    public V1beta1TransitGatewayConnectSpecInitProviderTransitGatewayIdRef? TransitGatewayIdRef { get; set; }

    /// <summary>Selector for a TransitGateway in ec2 to populate transitGatewayId.</summary>
    [JsonPropertyName("transitGatewayIdSelector")]
    public V1beta1TransitGatewayConnectSpecInitProviderTransitGatewayIdSelector? TransitGatewayIdSelector { get; set; }

    /// <summary>The underlaying VPC attachment</summary>
    [JsonPropertyName("transportAttachmentId")]
    public string? TransportAttachmentId { get; set; }

    /// <summary>Reference to a TransitGatewayVPCAttachment in ec2 to populate transportAttachmentId.</summary>
    [JsonPropertyName("transportAttachmentIdRef")]
    public V1beta1TransitGatewayConnectSpecInitProviderTransportAttachmentIdRef? TransportAttachmentIdRef { get; set; }

    /// <summary>Selector for a TransitGatewayVPCAttachment in ec2 to populate transportAttachmentId.</summary>
    [JsonPropertyName("transportAttachmentIdSelector")]
    public V1beta1TransitGatewayConnectSpecInitProviderTransportAttachmentIdSelector? TransportAttachmentIdSelector { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectSpecProviderConfigRef
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
public partial class V1beta1TransitGatewayConnectSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>TransitGatewayConnectSpec defines the desired state of TransitGatewayConnect</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TransitGatewayConnectSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TransitGatewayConnectSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TransitGatewayConnectSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TransitGatewayConnectSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectStatusAtProvider
{
    /// <summary>EC2 Transit Gateway Attachment identifier</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The tunnel protocol. Valid values: gre. Default is gre.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Boolean whether the Connect should be associated with the EC2 Transit Gateway association default route table. This cannot be configured or perform drift detection with Resource Access Manager shared EC2 Transit Gateways. Default value: true.</summary>
    [JsonPropertyName("transitGatewayDefaultRouteTableAssociation")]
    public bool? TransitGatewayDefaultRouteTableAssociation { get; set; }

    /// <summary>Boolean whether the Connect should propagate routes with the EC2 Transit Gateway propagation default route table. This cannot be configured or perform drift detection with Resource Access Manager shared EC2 Transit Gateways. Default value: true.</summary>
    [JsonPropertyName("transitGatewayDefaultRouteTablePropagation")]
    public bool? TransitGatewayDefaultRouteTablePropagation { get; set; }

    /// <summary>Identifier of EC2 Transit Gateway.</summary>
    [JsonPropertyName("transitGatewayId")]
    public string? TransitGatewayId { get; set; }

    /// <summary>The underlaying VPC attachment</summary>
    [JsonPropertyName("transportAttachmentId")]
    public string? TransportAttachmentId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectStatusConditions
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

/// <summary>TransitGatewayConnectStatus defines the observed state of TransitGatewayConnect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TransitGatewayConnectStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TransitGatewayConnectStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TransitGatewayConnectStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>TransitGatewayConnect is the Schema for the TransitGatewayConnects API. Manages an EC2 Transit Gateway Connect</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TransitGatewayConnect : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TransitGatewayConnectSpec>, IStatus<V1beta1TransitGatewayConnectStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TransitGatewayConnect";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "transitgatewayconnects";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TransitGatewayConnectSpec defines the desired state of TransitGatewayConnect</summary>
    [JsonPropertyName("spec")]
    public V1beta1TransitGatewayConnectSpec Spec { get; set; }

    /// <summary>TransitGatewayConnectStatus defines the observed state of TransitGatewayConnect.</summary>
    [JsonPropertyName("status")]
    public V1beta1TransitGatewayConnectStatus? Status { get; set; }
}