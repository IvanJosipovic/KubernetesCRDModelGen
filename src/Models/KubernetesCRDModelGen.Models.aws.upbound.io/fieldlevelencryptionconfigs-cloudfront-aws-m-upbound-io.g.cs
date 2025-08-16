using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudfront.aws.m.upbound.io;
/// <summary>FieldLevelEncryptionConfig is the Schema for the FieldLevelEncryptionConfigs API. Provides a CloudFront Field-level Encryption Config resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FieldLevelEncryptionConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta1FieldLevelEncryptionConfig>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FieldLevelEncryptionConfigList";
    public const string KubeGroup = "cloudfront.aws.m.upbound.io";
    public const string KubePluralName = "fieldlevelencryptionconfigs";
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
    public IList<V1beta1FieldLevelEncryptionConfig> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecForProviderContentTypeProfileConfigContentTypeProfilesItems
{
    /// <summary>he content type for a field-level encryption content type-profile mapping. Valid value is application/x-www-form-urlencoded.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>The format for a field-level encryption content type-profile mapping. Valid value is URLEncoded.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The profile ID for a field-level encryption content type-profile mapping.</summary>
    [JsonPropertyName("profileId")]
    public string? ProfileId { get; set; }
}

/// <summary>Object that contains an attribute items that contains the list of configurations for a field-level encryption content type-profile. See Content Type Profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecForProviderContentTypeProfileConfigContentTypeProfiles
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1FieldLevelEncryptionConfigSpecForProviderContentTypeProfileConfigContentTypeProfilesItems>? Items { get; set; }
}

/// <summary>Content Type Profile Config specifies when to forward content if a content type isn't recognized and profiles to use as by default in a request if a query argument doesn't specify a profile to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecForProviderContentTypeProfileConfig
{
    /// <summary>Object that contains an attribute items that contains the list of configurations for a field-level encryption content type-profile. See Content Type Profile.</summary>
    [JsonPropertyName("contentTypeProfiles")]
    public V1beta1FieldLevelEncryptionConfigSpecForProviderContentTypeProfileConfigContentTypeProfiles? ContentTypeProfiles { get; set; }

    /// <summary>specifies what to do when an unknown content type is provided for the profile. If true, content is forwarded without being encrypted when the content type is unknown. If false (the default), an error is returned when the content type is unknown.</summary>
    [JsonPropertyName("forwardWhenContentTypeIsUnknown")]
    public bool? ForwardWhenContentTypeIsUnknown { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a FieldLevelEncryptionProfile in cloudfront to populate profileId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a FieldLevelEncryptionProfile in cloudfront to populate profileId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelector
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
    public V1beta1FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItems
{
    /// <summary>The profile ID for a field-level encryption content type-profile mapping.</summary>
    [JsonPropertyName("profileId")]
    public string? ProfileId { get; set; }

    /// <summary>Reference to a FieldLevelEncryptionProfile in cloudfront to populate profileId.</summary>
    [JsonPropertyName("profileIdRef")]
    public V1beta1FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRef? ProfileIdRef { get; set; }

    /// <summary>Selector for a FieldLevelEncryptionProfile in cloudfront to populate profileId.</summary>
    [JsonPropertyName("profileIdSelector")]
    public V1beta1FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelector? ProfileIdSelector { get; set; }

    /// <summary>Query argument for field-level encryption query argument-profile mapping.</summary>
    [JsonPropertyName("queryArg")]
    public string? QueryArg { get; set; }
}

/// <summary>Object that contains an attribute items that contains the list ofrofiles specified for query argument-profile mapping for field-level encryption. see Query Arg Profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfiles
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItems>? Items { get; set; }
}

/// <summary>Query Arg Profile Config that specifies when to forward content if a profile isn't found and the profile that can be provided as a query argument in a request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfig
{
    /// <summary>Flag to set if you want a request to be forwarded to the origin even if the profile specified by the field-level encryption query argument, fle-profile, is unknown.</summary>
    [JsonPropertyName("forwardWhenQueryArgProfileIsUnknown")]
    public bool? ForwardWhenQueryArgProfileIsUnknown { get; set; }

    /// <summary>Object that contains an attribute items that contains the list ofrofiles specified for query argument-profile mapping for field-level encryption. see Query Arg Profile.</summary>
    [JsonPropertyName("queryArgProfiles")]
    public V1beta1FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfiles? QueryArgProfiles { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecForProvider
{
    /// <summary>An optional comment about the Field Level Encryption Config.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Content Type Profile Config specifies when to forward content if a content type isn't recognized and profiles to use as by default in a request if a query argument doesn't specify a profile to use.</summary>
    [JsonPropertyName("contentTypeProfileConfig")]
    public V1beta1FieldLevelEncryptionConfigSpecForProviderContentTypeProfileConfig? ContentTypeProfileConfig { get; set; }

    /// <summary>Query Arg Profile Config that specifies when to forward content if a profile isn't found and the profile that can be provided as a query argument in a request.</summary>
    [JsonPropertyName("queryArgProfileConfig")]
    public V1beta1FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfig? QueryArgProfileConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecInitProviderContentTypeProfileConfigContentTypeProfilesItems
{
    /// <summary>he content type for a field-level encryption content type-profile mapping. Valid value is application/x-www-form-urlencoded.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>The format for a field-level encryption content type-profile mapping. Valid value is URLEncoded.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The profile ID for a field-level encryption content type-profile mapping.</summary>
    [JsonPropertyName("profileId")]
    public string? ProfileId { get; set; }
}

/// <summary>Object that contains an attribute items that contains the list of configurations for a field-level encryption content type-profile. See Content Type Profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecInitProviderContentTypeProfileConfigContentTypeProfiles
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1FieldLevelEncryptionConfigSpecInitProviderContentTypeProfileConfigContentTypeProfilesItems>? Items { get; set; }
}

/// <summary>Content Type Profile Config specifies when to forward content if a content type isn't recognized and profiles to use as by default in a request if a query argument doesn't specify a profile to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecInitProviderContentTypeProfileConfig
{
    /// <summary>Object that contains an attribute items that contains the list of configurations for a field-level encryption content type-profile. See Content Type Profile.</summary>
    [JsonPropertyName("contentTypeProfiles")]
    public V1beta1FieldLevelEncryptionConfigSpecInitProviderContentTypeProfileConfigContentTypeProfiles? ContentTypeProfiles { get; set; }

    /// <summary>specifies what to do when an unknown content type is provided for the profile. If true, content is forwarded without being encrypted when the content type is unknown. If false (the default), an error is returned when the content type is unknown.</summary>
    [JsonPropertyName("forwardWhenContentTypeIsUnknown")]
    public bool? ForwardWhenContentTypeIsUnknown { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a FieldLevelEncryptionProfile in cloudfront to populate profileId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a FieldLevelEncryptionProfile in cloudfront to populate profileId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelector
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
    public V1beta1FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItems
{
    /// <summary>The profile ID for a field-level encryption content type-profile mapping.</summary>
    [JsonPropertyName("profileId")]
    public string? ProfileId { get; set; }

    /// <summary>Reference to a FieldLevelEncryptionProfile in cloudfront to populate profileId.</summary>
    [JsonPropertyName("profileIdRef")]
    public V1beta1FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRef? ProfileIdRef { get; set; }

    /// <summary>Selector for a FieldLevelEncryptionProfile in cloudfront to populate profileId.</summary>
    [JsonPropertyName("profileIdSelector")]
    public V1beta1FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelector? ProfileIdSelector { get; set; }

    /// <summary>Query argument for field-level encryption query argument-profile mapping.</summary>
    [JsonPropertyName("queryArg")]
    public string? QueryArg { get; set; }
}

/// <summary>Object that contains an attribute items that contains the list ofrofiles specified for query argument-profile mapping for field-level encryption. see Query Arg Profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfiles
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItems>? Items { get; set; }
}

/// <summary>Query Arg Profile Config that specifies when to forward content if a profile isn't found and the profile that can be provided as a query argument in a request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfig
{
    /// <summary>Flag to set if you want a request to be forwarded to the origin even if the profile specified by the field-level encryption query argument, fle-profile, is unknown.</summary>
    [JsonPropertyName("forwardWhenQueryArgProfileIsUnknown")]
    public bool? ForwardWhenQueryArgProfileIsUnknown { get; set; }

    /// <summary>Object that contains an attribute items that contains the list ofrofiles specified for query argument-profile mapping for field-level encryption. see Query Arg Profile.</summary>
    [JsonPropertyName("queryArgProfiles")]
    public V1beta1FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfiles? QueryArgProfiles { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecInitProvider
{
    /// <summary>An optional comment about the Field Level Encryption Config.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Content Type Profile Config specifies when to forward content if a content type isn't recognized and profiles to use as by default in a request if a query argument doesn't specify a profile to use.</summary>
    [JsonPropertyName("contentTypeProfileConfig")]
    public V1beta1FieldLevelEncryptionConfigSpecInitProviderContentTypeProfileConfig? ContentTypeProfileConfig { get; set; }

    /// <summary>Query Arg Profile Config that specifies when to forward content if a profile isn't found and the profile that can be provided as a query argument in a request.</summary>
    [JsonPropertyName("queryArgProfileConfig")]
    public V1beta1FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfig? QueryArgProfileConfig { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpecProviderConfigRef
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
public partial class V1beta1FieldLevelEncryptionConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>FieldLevelEncryptionConfigSpec defines the desired state of FieldLevelEncryptionConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FieldLevelEncryptionConfigSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FieldLevelEncryptionConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FieldLevelEncryptionConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FieldLevelEncryptionConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigStatusAtProviderContentTypeProfileConfigContentTypeProfilesItems
{
    /// <summary>he content type for a field-level encryption content type-profile mapping. Valid value is application/x-www-form-urlencoded.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>The format for a field-level encryption content type-profile mapping. Valid value is URLEncoded.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The profile ID for a field-level encryption content type-profile mapping.</summary>
    [JsonPropertyName("profileId")]
    public string? ProfileId { get; set; }
}

/// <summary>Object that contains an attribute items that contains the list of configurations for a field-level encryption content type-profile. See Content Type Profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigStatusAtProviderContentTypeProfileConfigContentTypeProfiles
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1FieldLevelEncryptionConfigStatusAtProviderContentTypeProfileConfigContentTypeProfilesItems>? Items { get; set; }
}

/// <summary>Content Type Profile Config specifies when to forward content if a content type isn't recognized and profiles to use as by default in a request if a query argument doesn't specify a profile to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigStatusAtProviderContentTypeProfileConfig
{
    /// <summary>Object that contains an attribute items that contains the list of configurations for a field-level encryption content type-profile. See Content Type Profile.</summary>
    [JsonPropertyName("contentTypeProfiles")]
    public V1beta1FieldLevelEncryptionConfigStatusAtProviderContentTypeProfileConfigContentTypeProfiles? ContentTypeProfiles { get; set; }

    /// <summary>specifies what to do when an unknown content type is provided for the profile. If true, content is forwarded without being encrypted when the content type is unknown. If false (the default), an error is returned when the content type is unknown.</summary>
    [JsonPropertyName("forwardWhenContentTypeIsUnknown")]
    public bool? ForwardWhenContentTypeIsUnknown { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigStatusAtProviderQueryArgProfileConfigQueryArgProfilesItems
{
    /// <summary>The profile ID for a field-level encryption content type-profile mapping.</summary>
    [JsonPropertyName("profileId")]
    public string? ProfileId { get; set; }

    /// <summary>Query argument for field-level encryption query argument-profile mapping.</summary>
    [JsonPropertyName("queryArg")]
    public string? QueryArg { get; set; }
}

/// <summary>Object that contains an attribute items that contains the list ofrofiles specified for query argument-profile mapping for field-level encryption. see Query Arg Profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigStatusAtProviderQueryArgProfileConfigQueryArgProfiles
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1FieldLevelEncryptionConfigStatusAtProviderQueryArgProfileConfigQueryArgProfilesItems>? Items { get; set; }
}

/// <summary>Query Arg Profile Config that specifies when to forward content if a profile isn't found and the profile that can be provided as a query argument in a request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigStatusAtProviderQueryArgProfileConfig
{
    /// <summary>Flag to set if you want a request to be forwarded to the origin even if the profile specified by the field-level encryption query argument, fle-profile, is unknown.</summary>
    [JsonPropertyName("forwardWhenQueryArgProfileIsUnknown")]
    public bool? ForwardWhenQueryArgProfileIsUnknown { get; set; }

    /// <summary>Object that contains an attribute items that contains the list ofrofiles specified for query argument-profile mapping for field-level encryption. see Query Arg Profile.</summary>
    [JsonPropertyName("queryArgProfiles")]
    public V1beta1FieldLevelEncryptionConfigStatusAtProviderQueryArgProfileConfigQueryArgProfiles? QueryArgProfiles { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigStatusAtProvider
{
    /// <summary>The Field Level Encryption Config ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Internal value used by CloudFront to allow future updates to the Field Level Encryption Config.</summary>
    [JsonPropertyName("callerReference")]
    public string? CallerReference { get; set; }

    /// <summary>An optional comment about the Field Level Encryption Config.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Content Type Profile Config specifies when to forward content if a content type isn't recognized and profiles to use as by default in a request if a query argument doesn't specify a profile to use.</summary>
    [JsonPropertyName("contentTypeProfileConfig")]
    public V1beta1FieldLevelEncryptionConfigStatusAtProviderContentTypeProfileConfig? ContentTypeProfileConfig { get; set; }

    /// <summary>The current version of the Field Level Encryption Config. For example: E2QWRUHAPOMQZL.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>The identifier for the Field Level Encryption Config. For example: K3D5EWEUDCCXON.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Query Arg Profile Config that specifies when to forward content if a profile isn't found and the profile that can be provided as a query argument in a request.</summary>
    [JsonPropertyName("queryArgProfileConfig")]
    public V1beta1FieldLevelEncryptionConfigStatusAtProviderQueryArgProfileConfig? QueryArgProfileConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigStatusConditions
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

/// <summary>FieldLevelEncryptionConfigStatus defines the observed state of FieldLevelEncryptionConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldLevelEncryptionConfigStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FieldLevelEncryptionConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FieldLevelEncryptionConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FieldLevelEncryptionConfig is the Schema for the FieldLevelEncryptionConfigs API. Provides a CloudFront Field-level Encryption Config resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FieldLevelEncryptionConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FieldLevelEncryptionConfigSpec>, IStatus<V1beta1FieldLevelEncryptionConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FieldLevelEncryptionConfig";
    public const string KubeGroup = "cloudfront.aws.m.upbound.io";
    public const string KubePluralName = "fieldlevelencryptionconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FieldLevelEncryptionConfigSpec defines the desired state of FieldLevelEncryptionConfig</summary>
    [JsonPropertyName("spec")]
    public V1beta1FieldLevelEncryptionConfigSpec Spec { get; set; }

    /// <summary>FieldLevelEncryptionConfigStatus defines the observed state of FieldLevelEncryptionConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1FieldLevelEncryptionConfigStatus? Status { get; set; }
}