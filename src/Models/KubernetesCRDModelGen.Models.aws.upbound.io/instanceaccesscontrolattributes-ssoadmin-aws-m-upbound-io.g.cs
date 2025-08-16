using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ssoadmin.aws.m.upbound.io;
/// <summary>InstanceAccessControlAttributes is the Schema for the InstanceAccessControlAttributess API. Provides a Single Sign-On (SSO) ABAC Resource: https://docs.aws.amazon.com/singlesignon/latest/userguide/abac.html</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InstanceAccessControlAttributesList : IKubernetesObject<V1ListMeta>, IItems<V1beta1InstanceAccessControlAttributes>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InstanceAccessControlAttributesList";
    public const string KubeGroup = "ssoadmin.aws.m.upbound.io";
    public const string KubePluralName = "instanceaccesscontrolattributes";
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
    public IList<V1beta1InstanceAccessControlAttributes> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceAccessControlAttributesSpecForProviderAttributeValue
{
    /// <summary>The identity source to use when mapping a specified attribute to AWS SSO.</summary>
    [JsonPropertyName("source")]
    public IList<string>? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceAccessControlAttributesSpecForProviderAttribute
{
    /// <summary>The name of the attribute associated with your identities in your identity source. This is used to map a specified attribute in your identity source with an attribute in AWS SSO.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value used for mapping a specified attribute to an identity source. See AccessControlAttributeValue</summary>
    [JsonPropertyName("value")]
    public IList<V1beta1InstanceAccessControlAttributesSpecForProviderAttributeValue>? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceAccessControlAttributesSpecForProvider
{
    /// <summary>See AccessControlAttribute for more details.</summary>
    [JsonPropertyName("attribute")]
    public IList<V1beta1InstanceAccessControlAttributesSpecForProviderAttribute>? Attribute { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SSO Instance.</summary>
    [JsonPropertyName("instanceArn")]
    public string InstanceArn { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceAccessControlAttributesSpecInitProviderAttributeValue
{
    /// <summary>The identity source to use when mapping a specified attribute to AWS SSO.</summary>
    [JsonPropertyName("source")]
    public IList<string>? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceAccessControlAttributesSpecInitProviderAttribute
{
    /// <summary>The name of the attribute associated with your identities in your identity source. This is used to map a specified attribute in your identity source with an attribute in AWS SSO.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value used for mapping a specified attribute to an identity source. See AccessControlAttributeValue</summary>
    [JsonPropertyName("value")]
    public IList<V1beta1InstanceAccessControlAttributesSpecInitProviderAttributeValue>? Value { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceAccessControlAttributesSpecInitProvider
{
    /// <summary>See AccessControlAttribute for more details.</summary>
    [JsonPropertyName("attribute")]
    public IList<V1beta1InstanceAccessControlAttributesSpecInitProviderAttribute>? Attribute { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceAccessControlAttributesSpecProviderConfigRef
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
public partial class V1beta1InstanceAccessControlAttributesSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>InstanceAccessControlAttributesSpec defines the desired state of InstanceAccessControlAttributes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceAccessControlAttributesSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1InstanceAccessControlAttributesSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1InstanceAccessControlAttributesSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1InstanceAccessControlAttributesSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1InstanceAccessControlAttributesSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceAccessControlAttributesStatusAtProviderAttributeValue
{
    /// <summary>The identity source to use when mapping a specified attribute to AWS SSO.</summary>
    [JsonPropertyName("source")]
    public IList<string>? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceAccessControlAttributesStatusAtProviderAttribute
{
    /// <summary>The name of the attribute associated with your identities in your identity source. This is used to map a specified attribute in your identity source with an attribute in AWS SSO.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value used for mapping a specified attribute to an identity source. See AccessControlAttributeValue</summary>
    [JsonPropertyName("value")]
    public IList<V1beta1InstanceAccessControlAttributesStatusAtProviderAttributeValue>? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceAccessControlAttributesStatusAtProvider
{
    /// <summary>See AccessControlAttribute for more details.</summary>
    [JsonPropertyName("attribute")]
    public IList<V1beta1InstanceAccessControlAttributesStatusAtProviderAttribute>? Attribute { get; set; }

    /// <summary>The identifier of the Instance Access Control Attribute instance_arn.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SSO Instance.</summary>
    [JsonPropertyName("instanceArn")]
    public string? InstanceArn { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("statusReason")]
    public string? StatusReason { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceAccessControlAttributesStatusConditions
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

/// <summary>InstanceAccessControlAttributesStatus defines the observed state of InstanceAccessControlAttributes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceAccessControlAttributesStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1InstanceAccessControlAttributesStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1InstanceAccessControlAttributesStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>InstanceAccessControlAttributes is the Schema for the InstanceAccessControlAttributess API. Provides a Single Sign-On (SSO) ABAC Resource: https://docs.aws.amazon.com/singlesignon/latest/userguide/abac.html</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InstanceAccessControlAttributes : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1InstanceAccessControlAttributesSpec>, IStatus<V1beta1InstanceAccessControlAttributesStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InstanceAccessControlAttributes";
    public const string KubeGroup = "ssoadmin.aws.m.upbound.io";
    public const string KubePluralName = "instanceaccesscontrolattributes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceAccessControlAttributesSpec defines the desired state of InstanceAccessControlAttributes</summary>
    [JsonPropertyName("spec")]
    public V1beta1InstanceAccessControlAttributesSpec Spec { get; set; }

    /// <summary>InstanceAccessControlAttributesStatus defines the observed state of InstanceAccessControlAttributes.</summary>
    [JsonPropertyName("status")]
    public V1beta1InstanceAccessControlAttributesStatus? Status { get; set; }
}