using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudfront.aws.m.upbound.io;
#nullable enable
/// <summary>FieldLevelEncryptionProfile is the Schema for the FieldLevelEncryptionProfiles API. Provides a CloudFront Field-level Encryption Profile resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FieldLevelEncryptionProfileList : IKubernetesObject<V1ListMeta>, IItems<V1beta1FieldLevelEncryptionProfile>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FieldLevelEncryptionProfileList";
    public const string KubeGroup = "cloudfront.aws.m.upbound.io";
    public const string KubePluralName = "fieldlevelencryptionprofiles";
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
    public IList<V1beta1FieldLevelEncryptionProfile> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object that contains an attribute items that contains the list of field patterns in a field-level encryption content type profile specify the fields that you want to be encrypted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileSpecForProviderEncryptionEntitiesItemsFieldPatterns
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileSpecForProviderEncryptionEntitiesItemsPublicKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a PublicKey in cloudfront to populate publicKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileSpecForProviderEncryptionEntitiesItemsPublicKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FieldLevelEncryptionProfileSpecForProviderEncryptionEntitiesItemsPublicKeyIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileSpecForProviderEncryptionEntitiesItemsPublicKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a PublicKey in cloudfront to populate publicKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileSpecForProviderEncryptionEntitiesItemsPublicKeyIdSelector
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
    public V1beta1FieldLevelEncryptionProfileSpecForProviderEncryptionEntitiesItemsPublicKeyIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileSpecForProviderEncryptionEntitiesItems
{
    /// <summary>Object that contains an attribute items that contains the list of field patterns in a field-level encryption content type profile specify the fields that you want to be encrypted.</summary>
    [JsonPropertyName("fieldPatterns")]
    public V1beta1FieldLevelEncryptionProfileSpecForProviderEncryptionEntitiesItemsFieldPatterns? FieldPatterns { get; set; }

    /// <summary>The provider associated with the public key being used for encryption.</summary>
    [JsonPropertyName("providerId")]
    public string? ProviderId { get; set; }

    /// <summary>The public key associated with a set of field-level encryption patterns, to be used when encrypting the fields that match the patterns.</summary>
    [JsonPropertyName("publicKeyId")]
    public string? PublicKeyId { get; set; }

    /// <summary>Reference to a PublicKey in cloudfront to populate publicKeyId.</summary>
    [JsonPropertyName("publicKeyIdRef")]
    public V1beta1FieldLevelEncryptionProfileSpecForProviderEncryptionEntitiesItemsPublicKeyIdRef? PublicKeyIdRef { get; set; }

    /// <summary>Selector for a PublicKey in cloudfront to populate publicKeyId.</summary>
    [JsonPropertyName("publicKeyIdSelector")]
    public V1beta1FieldLevelEncryptionProfileSpecForProviderEncryptionEntitiesItemsPublicKeyIdSelector? PublicKeyIdSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The encryption entities config block for field-level encryption profiles that contains an attribute items which includes the encryption key and field pattern specifications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileSpecForProviderEncryptionEntities
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1FieldLevelEncryptionProfileSpecForProviderEncryptionEntitiesItems>? Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileSpecForProvider
{
    /// <summary>An optional comment about the Field Level Encryption Profile.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>The encryption entities config block for field-level encryption profiles that contains an attribute items which includes the encryption key and field pattern specifications.</summary>
    [JsonPropertyName("encryptionEntities")]
    public V1beta1FieldLevelEncryptionProfileSpecForProviderEncryptionEntities? EncryptionEntities { get; set; }

    /// <summary>The name of the Field Level Encryption Profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object that contains an attribute items that contains the list of field patterns in a field-level encryption content type profile specify the fields that you want to be encrypted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileSpecInitProviderEncryptionEntitiesItemsFieldPatterns
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileSpecInitProviderEncryptionEntitiesItemsPublicKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a PublicKey in cloudfront to populate publicKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileSpecInitProviderEncryptionEntitiesItemsPublicKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FieldLevelEncryptionProfileSpecInitProviderEncryptionEntitiesItemsPublicKeyIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileSpecInitProviderEncryptionEntitiesItemsPublicKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a PublicKey in cloudfront to populate publicKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileSpecInitProviderEncryptionEntitiesItemsPublicKeyIdSelector
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
    public V1beta1FieldLevelEncryptionProfileSpecInitProviderEncryptionEntitiesItemsPublicKeyIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileSpecInitProviderEncryptionEntitiesItems
{
    /// <summary>Object that contains an attribute items that contains the list of field patterns in a field-level encryption content type profile specify the fields that you want to be encrypted.</summary>
    [JsonPropertyName("fieldPatterns")]
    public V1beta1FieldLevelEncryptionProfileSpecInitProviderEncryptionEntitiesItemsFieldPatterns? FieldPatterns { get; set; }

    /// <summary>The provider associated with the public key being used for encryption.</summary>
    [JsonPropertyName("providerId")]
    public string? ProviderId { get; set; }

    /// <summary>The public key associated with a set of field-level encryption patterns, to be used when encrypting the fields that match the patterns.</summary>
    [JsonPropertyName("publicKeyId")]
    public string? PublicKeyId { get; set; }

    /// <summary>Reference to a PublicKey in cloudfront to populate publicKeyId.</summary>
    [JsonPropertyName("publicKeyIdRef")]
    public V1beta1FieldLevelEncryptionProfileSpecInitProviderEncryptionEntitiesItemsPublicKeyIdRef? PublicKeyIdRef { get; set; }

    /// <summary>Selector for a PublicKey in cloudfront to populate publicKeyId.</summary>
    [JsonPropertyName("publicKeyIdSelector")]
    public V1beta1FieldLevelEncryptionProfileSpecInitProviderEncryptionEntitiesItemsPublicKeyIdSelector? PublicKeyIdSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The encryption entities config block for field-level encryption profiles that contains an attribute items which includes the encryption key and field pattern specifications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileSpecInitProviderEncryptionEntities
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1FieldLevelEncryptionProfileSpecInitProviderEncryptionEntitiesItems>? Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileSpecInitProvider
{
    /// <summary>An optional comment about the Field Level Encryption Profile.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>The encryption entities config block for field-level encryption profiles that contains an attribute items which includes the encryption key and field pattern specifications.</summary>
    [JsonPropertyName("encryptionEntities")]
    public V1beta1FieldLevelEncryptionProfileSpecInitProviderEncryptionEntities? EncryptionEntities { get; set; }

    /// <summary>The name of the Field Level Encryption Profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>FieldLevelEncryptionProfileSpec defines the desired state of FieldLevelEncryptionProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FieldLevelEncryptionProfileSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FieldLevelEncryptionProfileSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FieldLevelEncryptionProfileSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FieldLevelEncryptionProfileSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object that contains an attribute items that contains the list of field patterns in a field-level encryption content type profile specify the fields that you want to be encrypted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileStatusAtProviderEncryptionEntitiesItemsFieldPatterns
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileStatusAtProviderEncryptionEntitiesItems
{
    /// <summary>Object that contains an attribute items that contains the list of field patterns in a field-level encryption content type profile specify the fields that you want to be encrypted.</summary>
    [JsonPropertyName("fieldPatterns")]
    public V1beta1FieldLevelEncryptionProfileStatusAtProviderEncryptionEntitiesItemsFieldPatterns? FieldPatterns { get; set; }

    /// <summary>The provider associated with the public key being used for encryption.</summary>
    [JsonPropertyName("providerId")]
    public string? ProviderId { get; set; }

    /// <summary>The public key associated with a set of field-level encryption patterns, to be used when encrypting the fields that match the patterns.</summary>
    [JsonPropertyName("publicKeyId")]
    public string? PublicKeyId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The encryption entities config block for field-level encryption profiles that contains an attribute items which includes the encryption key and field pattern specifications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileStatusAtProviderEncryptionEntities
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1FieldLevelEncryptionProfileStatusAtProviderEncryptionEntitiesItems>? Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileStatusAtProvider
{
    /// <summary>The Field Level Encryption Profile ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Internal value used by CloudFront to allow future updates to the Field Level Encryption Profile.</summary>
    [JsonPropertyName("callerReference")]
    public string? CallerReference { get; set; }

    /// <summary>An optional comment about the Field Level Encryption Profile.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>The encryption entities config block for field-level encryption profiles that contains an attribute items which includes the encryption key and field pattern specifications.</summary>
    [JsonPropertyName("encryptionEntities")]
    public V1beta1FieldLevelEncryptionProfileStatusAtProviderEncryptionEntities? EncryptionEntities { get; set; }

    /// <summary>The current version of the Field Level Encryption Profile. For example: E2QWRUHAPOMQZL.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>The identifier for the Field Level Encryption Profile. For example: K3D5EWEUDCCXON.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the Field Level Encryption Profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileStatusConditions
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
#nullable disable

#nullable enable
/// <summary>FieldLevelEncryptionProfileStatus defines the observed state of FieldLevelEncryptionProfile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionProfileStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FieldLevelEncryptionProfileStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FieldLevelEncryptionProfileStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>FieldLevelEncryptionProfile is the Schema for the FieldLevelEncryptionProfiles API. Provides a CloudFront Field-level Encryption Profile resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FieldLevelEncryptionProfile : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FieldLevelEncryptionProfileSpec>, IStatus<V1beta1FieldLevelEncryptionProfileStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FieldLevelEncryptionProfile";
    public const string KubeGroup = "cloudfront.aws.m.upbound.io";
    public const string KubePluralName = "fieldlevelencryptionprofiles";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FieldLevelEncryptionProfileSpec defines the desired state of FieldLevelEncryptionProfile</summary>
    [JsonPropertyName("spec")]
    public V1beta1FieldLevelEncryptionProfileSpec Spec { get; set; }

    /// <summary>FieldLevelEncryptionProfileStatus defines the observed state of FieldLevelEncryptionProfile.</summary>
    [JsonPropertyName("status")]
    public V1beta1FieldLevelEncryptionProfileStatus? Status { get; set; }
}
#nullable disable
