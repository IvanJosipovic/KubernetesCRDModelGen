using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vertexai.gcp.m.upbound.io;
/// <summary>Featurestore is the Schema for the Featurestores API. A collection of DataItems and Annotations on them.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FeaturestoreList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Featurestore>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FeaturestoreList";
    public const string KubeGroup = "vertexai.gcp.m.upbound.io";
    public const string KubePluralName = "featurestores";
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
    public IList<V1beta1Featurestore> Items { get; set; }
}

/// <summary>If set, both of the online and offline data storage will be secured by this key. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreSpecForProviderEncryptionSpec
{
    /// <summary>The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. Has the form: projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key. The key needs to be in the same region as where the compute resource is created.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>Online serving scaling configuration. Only one of fixedNodeCount and scaling can be set. Setting one will reset the other. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreSpecForProviderOnlineServingConfigScaling
{
    /// <summary>The maximum number of nodes to scale up to. Must be greater than minNodeCount, and less than or equal to 10 times of 'minNodeCount'.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>The minimum number of nodes to scale down to. Must be greater than or equal to 1.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }
}

/// <summary>Config for online serving resources. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreSpecForProviderOnlineServingConfig
{
    /// <summary>The number of nodes for each cluster. The number of nodes will not scale automatically but can be scaled manually by providing different values when updating.</summary>
    [JsonPropertyName("fixedNodeCount")]
    public double? FixedNodeCount { get; set; }

    /// <summary>Online serving scaling configuration. Only one of fixedNodeCount and scaling can be set. Setting one will reset the other. Structure is documented below.</summary>
    [JsonPropertyName("scaling")]
    public V1beta1FeaturestoreSpecForProviderOnlineServingConfigScaling? Scaling { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreSpecForProvider
{
    /// <summary>If set, both of the online and offline data storage will be secured by this key. Structure is documented below.</summary>
    [JsonPropertyName("encryptionSpec")]
    public V1beta1FeaturestoreSpecForProviderEncryptionSpec? EncryptionSpec { get; set; }

    /// <summary>If set to true, any EntityTypes and Features for this Featurestore will also be deleted</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>A set of key/value label pairs to assign to this Featurestore.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The name of the Featurestore. This value may be up to 60 characters, and valid characters are [a-z0-9_]. The first character cannot be a number.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Config for online serving resources. Structure is documented below.</summary>
    [JsonPropertyName("onlineServingConfig")]
    public V1beta1FeaturestoreSpecForProviderOnlineServingConfig? OnlineServingConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the dataset. eg us-central1</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>If set, both of the online and offline data storage will be secured by this key. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreSpecInitProviderEncryptionSpec
{
    /// <summary>The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. Has the form: projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key. The key needs to be in the same region as where the compute resource is created.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>Online serving scaling configuration. Only one of fixedNodeCount and scaling can be set. Setting one will reset the other. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreSpecInitProviderOnlineServingConfigScaling
{
    /// <summary>The maximum number of nodes to scale up to. Must be greater than minNodeCount, and less than or equal to 10 times of 'minNodeCount'.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>The minimum number of nodes to scale down to. Must be greater than or equal to 1.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }
}

/// <summary>Config for online serving resources. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreSpecInitProviderOnlineServingConfig
{
    /// <summary>The number of nodes for each cluster. The number of nodes will not scale automatically but can be scaled manually by providing different values when updating.</summary>
    [JsonPropertyName("fixedNodeCount")]
    public double? FixedNodeCount { get; set; }

    /// <summary>Online serving scaling configuration. Only one of fixedNodeCount and scaling can be set. Setting one will reset the other. Structure is documented below.</summary>
    [JsonPropertyName("scaling")]
    public V1beta1FeaturestoreSpecInitProviderOnlineServingConfigScaling? Scaling { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreSpecInitProvider
{
    /// <summary>If set, both of the online and offline data storage will be secured by this key. Structure is documented below.</summary>
    [JsonPropertyName("encryptionSpec")]
    public V1beta1FeaturestoreSpecInitProviderEncryptionSpec? EncryptionSpec { get; set; }

    /// <summary>If set to true, any EntityTypes and Features for this Featurestore will also be deleted</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>A set of key/value label pairs to assign to this Featurestore.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The name of the Featurestore. This value may be up to 60 characters, and valid characters are [a-z0-9_]. The first character cannot be a number.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Config for online serving resources. Structure is documented below.</summary>
    [JsonPropertyName("onlineServingConfig")]
    public V1beta1FeaturestoreSpecInitProviderOnlineServingConfig? OnlineServingConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the dataset. eg us-central1</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreSpecProviderConfigRef
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
public partial class V1beta1FeaturestoreSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>FeaturestoreSpec defines the desired state of Featurestore</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FeaturestoreSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FeaturestoreSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FeaturestoreSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FeaturestoreSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>If set, both of the online and offline data storage will be secured by this key. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreStatusAtProviderEncryptionSpec
{
    /// <summary>The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. Has the form: projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key. The key needs to be in the same region as where the compute resource is created.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>Online serving scaling configuration. Only one of fixedNodeCount and scaling can be set. Setting one will reset the other. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreStatusAtProviderOnlineServingConfigScaling
{
    /// <summary>The maximum number of nodes to scale up to. Must be greater than minNodeCount, and less than or equal to 10 times of 'minNodeCount'.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>The minimum number of nodes to scale down to. Must be greater than or equal to 1.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }
}

/// <summary>Config for online serving resources. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreStatusAtProviderOnlineServingConfig
{
    /// <summary>The number of nodes for each cluster. The number of nodes will not scale automatically but can be scaled manually by providing different values when updating.</summary>
    [JsonPropertyName("fixedNodeCount")]
    public double? FixedNodeCount { get; set; }

    /// <summary>Online serving scaling configuration. Only one of fixedNodeCount and scaling can be set. Setting one will reset the other. Structure is documented below.</summary>
    [JsonPropertyName("scaling")]
    public V1beta1FeaturestoreStatusAtProviderOnlineServingConfigScaling? Scaling { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreStatusAtProvider
{
    /// <summary>The timestamp of when the featurestore was created in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>If set, both of the online and offline data storage will be secured by this key. Structure is documented below.</summary>
    [JsonPropertyName("encryptionSpec")]
    public V1beta1FeaturestoreStatusAtProviderEncryptionSpec? EncryptionSpec { get; set; }

    /// <summary>Used to perform consistent read-modify-write updates.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>If set to true, any EntityTypes and Features for this Featurestore will also be deleted</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{region}}/featurestores/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A set of key/value label pairs to assign to this Featurestore.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The name of the Featurestore. This value may be up to 60 characters, and valid characters are [a-z0-9_]. The first character cannot be a number.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Config for online serving resources. Structure is documented below.</summary>
    [JsonPropertyName("onlineServingConfig")]
    public V1beta1FeaturestoreStatusAtProviderOnlineServingConfig? OnlineServingConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the dataset. eg us-central1</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>The timestamp of when the featurestore was last updated in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreStatusConditions
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

/// <summary>FeaturestoreStatus defines the observed state of Featurestore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FeaturestoreStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FeaturestoreStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FeaturestoreStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Featurestore is the Schema for the Featurestores API. A collection of DataItems and Annotations on them.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Featurestore : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FeaturestoreSpec>, IStatus<V1beta1FeaturestoreStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Featurestore";
    public const string KubeGroup = "vertexai.gcp.m.upbound.io";
    public const string KubePluralName = "featurestores";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FeaturestoreSpec defines the desired state of Featurestore</summary>
    [JsonPropertyName("spec")]
    public V1beta1FeaturestoreSpec Spec { get; set; }

    /// <summary>FeaturestoreStatus defines the observed state of Featurestore.</summary>
    [JsonPropertyName("status")]
    public V1beta1FeaturestoreStatus? Status { get; set; }
}