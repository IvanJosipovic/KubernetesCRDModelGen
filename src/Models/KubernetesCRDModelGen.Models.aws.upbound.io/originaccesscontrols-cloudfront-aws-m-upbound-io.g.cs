using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudfront.aws.m.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginAccessControlSpecForProvider
{
    /// <summary>The description of the Origin Access Control.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A name that identifies the Origin Access Control.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of origin that this Origin Access Control is for. Valid values are lambda, mediapackagev2, mediastore, and s3.</summary>
    [JsonPropertyName("originAccessControlOriginType")]
    public string? OriginAccessControlOriginType { get; set; }

    /// <summary>Specifies which requests CloudFront signs. Specify always for the most common use case. Allowed values: always, never, and no-override.</summary>
    [JsonPropertyName("signingBehavior")]
    public string? SigningBehavior { get; set; }

    /// <summary>Determines how CloudFront signs (authenticates) requests. The only valid value is sigv4.</summary>
    [JsonPropertyName("signingProtocol")]
    public string? SigningProtocol { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginAccessControlSpecInitProvider
{
    /// <summary>The description of the Origin Access Control.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A name that identifies the Origin Access Control.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of origin that this Origin Access Control is for. Valid values are lambda, mediapackagev2, mediastore, and s3.</summary>
    [JsonPropertyName("originAccessControlOriginType")]
    public string? OriginAccessControlOriginType { get; set; }

    /// <summary>Specifies which requests CloudFront signs. Specify always for the most common use case. Allowed values: always, never, and no-override.</summary>
    [JsonPropertyName("signingBehavior")]
    public string? SigningBehavior { get; set; }

    /// <summary>Determines how CloudFront signs (authenticates) requests. The only valid value is sigv4.</summary>
    [JsonPropertyName("signingProtocol")]
    public string? SigningProtocol { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginAccessControlSpecProviderConfigRef
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
public partial class V1beta1OriginAccessControlSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>OriginAccessControlSpec defines the desired state of OriginAccessControl</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginAccessControlSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1OriginAccessControlSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1OriginAccessControlSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1OriginAccessControlSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1OriginAccessControlSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginAccessControlStatusAtProvider
{
    /// <summary>The Origin Access Control ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The description of the Origin Access Control.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The current version of this Origin Access Control.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>The unique identifier of this Origin Access Control.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A name that identifies the Origin Access Control.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of origin that this Origin Access Control is for. Valid values are lambda, mediapackagev2, mediastore, and s3.</summary>
    [JsonPropertyName("originAccessControlOriginType")]
    public string? OriginAccessControlOriginType { get; set; }

    /// <summary>Specifies which requests CloudFront signs. Specify always for the most common use case. Allowed values: always, never, and no-override.</summary>
    [JsonPropertyName("signingBehavior")]
    public string? SigningBehavior { get; set; }

    /// <summary>Determines how CloudFront signs (authenticates) requests. The only valid value is sigv4.</summary>
    [JsonPropertyName("signingProtocol")]
    public string? SigningProtocol { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginAccessControlStatusConditions
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

/// <summary>OriginAccessControlStatus defines the observed state of OriginAccessControl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginAccessControlStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1OriginAccessControlStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1OriginAccessControlStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>OriginAccessControl is the Schema for the OriginAccessControls API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OriginAccessControl : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1OriginAccessControlSpec>, IStatus<V1beta1OriginAccessControlStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OriginAccessControl";
    public const string KubeGroup = "cloudfront.aws.m.upbound.io";
    public const string KubePluralName = "originaccesscontrols";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OriginAccessControlSpec defines the desired state of OriginAccessControl</summary>
    [JsonPropertyName("spec")]
    public V1beta1OriginAccessControlSpec Spec { get; set; }

    /// <summary>OriginAccessControlStatus defines the observed state of OriginAccessControl.</summary>
    [JsonPropertyName("status")]
    public V1beta1OriginAccessControlStatus? Status { get; set; }
}

/// <summary>OriginAccessControl is the Schema for the OriginAccessControls API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OriginAccessControlList : IKubernetesObject<V1ListMeta>, IItems<V1beta1OriginAccessControl>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OriginAccessControlList";
    public const string KubeGroup = "cloudfront.aws.m.upbound.io";
    public const string KubePluralName = "originaccesscontrols";
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
    public IList<V1beta1OriginAccessControl> Items { get; set; }
}