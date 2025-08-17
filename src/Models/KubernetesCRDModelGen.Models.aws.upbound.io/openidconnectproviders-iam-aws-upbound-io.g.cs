using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iam.aws.upbound.io;
#nullable enable
/// <summary>OpenIDConnectProvider is the Schema for the OpenIDConnectProviders API. Provides an IAM OpenID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OpenIDConnectProviderList : IKubernetesObject<V1ListMeta>, IItems<V1beta1OpenIDConnectProvider>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OpenIDConnectProviderList";
    public const string KubeGroup = "iam.aws.upbound.io";
    public const string KubePluralName = "openidconnectproviders";
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
    public IList<V1beta1OpenIDConnectProvider> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OpenIDConnectProviderSpecForProvider
{
    /// <summary>List of client IDs (audiences) that identify the application registered with the OpenID Connect provider. This is the value sent as the client_id parameter in OAuth requests.</summary>
    [JsonPropertyName("clientIdList")]
    public IList<string>? ClientIdList { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>List of server certificate thumbprints for the OpenID Connect (OIDC) identity provider's server certificate(s). For certain OIDC identity providers (e.g., Auth0, GitHub, GitLab, Google, or those using an Amazon S3-hosted JWKS endpoint), AWS relies on its own library of trusted root certificate authorities (CAs) for validation instead of using any configured thumbprints. In these cases, any configured thumbprint_list is retained in the configuration but not used for verification. For other IdPs, if no thumbprint_list is provided, IAM automatically retrieves and uses the top intermediate CA thumbprint from the OIDC IdP server certificate. Instead, it continues using the original thumbprint list from the initial configuration. This differs from the behavior when creating an aws_iam_openid_connect_provider without a thumbprint_list.</summary>
    [JsonPropertyName("thumbprintList")]
    public IList<string>? ThumbprintList { get; set; }

    /// <summary>URL of the identity provider, corresponding to the iss claim.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OpenIDConnectProviderSpecInitProvider
{
    /// <summary>List of client IDs (audiences) that identify the application registered with the OpenID Connect provider. This is the value sent as the client_id parameter in OAuth requests.</summary>
    [JsonPropertyName("clientIdList")]
    public IList<string>? ClientIdList { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>List of server certificate thumbprints for the OpenID Connect (OIDC) identity provider's server certificate(s). For certain OIDC identity providers (e.g., Auth0, GitHub, GitLab, Google, or those using an Amazon S3-hosted JWKS endpoint), AWS relies on its own library of trusted root certificate authorities (CAs) for validation instead of using any configured thumbprints. In these cases, any configured thumbprint_list is retained in the configuration but not used for verification. For other IdPs, if no thumbprint_list is provided, IAM automatically retrieves and uses the top intermediate CA thumbprint from the OIDC IdP server certificate. Instead, it continues using the original thumbprint list from the initial configuration. This differs from the behavior when creating an aws_iam_openid_connect_provider without a thumbprint_list.</summary>
    [JsonPropertyName("thumbprintList")]
    public IList<string>? ThumbprintList { get; set; }

    /// <summary>URL of the identity provider, corresponding to the iss claim.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OpenIDConnectProviderSpecProviderConfigRefPolicy
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
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OpenIDConnectProviderSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OpenIDConnectProviderSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OpenIDConnectProviderSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>OpenIDConnectProviderSpec defines the desired state of OpenIDConnectProvider</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OpenIDConnectProviderSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1OpenIDConnectProviderSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1OpenIDConnectProviderSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1OpenIDConnectProviderSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1OpenIDConnectProviderSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OpenIDConnectProviderStatusAtProvider
{
    /// <summary>ARN assigned by AWS for this provider.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>List of client IDs (audiences) that identify the application registered with the OpenID Connect provider. This is the value sent as the client_id parameter in OAuth requests.</summary>
    [JsonPropertyName("clientIdList")]
    public IList<string>? ClientIdList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>List of server certificate thumbprints for the OpenID Connect (OIDC) identity provider's server certificate(s). For certain OIDC identity providers (e.g., Auth0, GitHub, GitLab, Google, or those using an Amazon S3-hosted JWKS endpoint), AWS relies on its own library of trusted root certificate authorities (CAs) for validation instead of using any configured thumbprints. In these cases, any configured thumbprint_list is retained in the configuration but not used for verification. For other IdPs, if no thumbprint_list is provided, IAM automatically retrieves and uses the top intermediate CA thumbprint from the OIDC IdP server certificate. Instead, it continues using the original thumbprint list from the initial configuration. This differs from the behavior when creating an aws_iam_openid_connect_provider without a thumbprint_list.</summary>
    [JsonPropertyName("thumbprintList")]
    public IList<string>? ThumbprintList { get; set; }

    /// <summary>URL of the identity provider, corresponding to the iss claim.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OpenIDConnectProviderStatusConditions
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
/// <summary>OpenIDConnectProviderStatus defines the observed state of OpenIDConnectProvider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OpenIDConnectProviderStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1OpenIDConnectProviderStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1OpenIDConnectProviderStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>OpenIDConnectProvider is the Schema for the OpenIDConnectProviders API. Provides an IAM OpenID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OpenIDConnectProvider : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1OpenIDConnectProviderSpec>, IStatus<V1beta1OpenIDConnectProviderStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OpenIDConnectProvider";
    public const string KubeGroup = "iam.aws.upbound.io";
    public const string KubePluralName = "openidconnectproviders";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OpenIDConnectProviderSpec defines the desired state of OpenIDConnectProvider</summary>
    [JsonPropertyName("spec")]
    public V1beta1OpenIDConnectProviderSpec Spec { get; set; }

    /// <summary>OpenIDConnectProviderStatus defines the observed state of OpenIDConnectProvider.</summary>
    [JsonPropertyName("status")]
    public V1beta1OpenIDConnectProviderStatus? Status { get; set; }
}
#nullable disable
