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
/// <summary>OriginRequestPolicy is the Schema for the OriginRequestPolicys API. Determines the values that CloudFront includes in requests that it sends to the origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OriginRequestPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1OriginRequestPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OriginRequestPolicyList";
    public const string KubeGroup = "cloudfront.aws.m.upbound.io";
    public const string KubePluralName = "originrequestpolicies";
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
    public IList<V1beta1OriginRequestPolicy> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicySpecForProviderCookiesConfigCookies
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object that determines whether any cookies in viewer requests (and if so, which cookies) are included in the origin request key and automatically included in requests that CloudFront sends to the origin. See Cookies Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicySpecForProviderCookiesConfig
{
    /// <summary></summary>
    [JsonPropertyName("cookieBehavior")]
    public string? CookieBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cookies")]
    public V1beta1OriginRequestPolicySpecForProviderCookiesConfigCookies? Cookies { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicySpecForProviderHeadersConfigHeaders
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object that determines whether any HTTP headers (and if so, which headers) are included in the origin request key and automatically included in requests that CloudFront sends to the origin. See Headers Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicySpecForProviderHeadersConfig
{
    /// <summary></summary>
    [JsonPropertyName("headerBehavior")]
    public string? HeaderBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headers")]
    public V1beta1OriginRequestPolicySpecForProviderHeadersConfigHeaders? Headers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicySpecForProviderQueryStringsConfigQueryStrings
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object that determines whether any URL query strings in viewer requests (and if so, which query strings) are included in the origin request key and automatically included in requests that CloudFront sends to the origin. See Query String Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicySpecForProviderQueryStringsConfig
{
    /// <summary></summary>
    [JsonPropertyName("queryStringBehavior")]
    public string? QueryStringBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("queryStrings")]
    public V1beta1OriginRequestPolicySpecForProviderQueryStringsConfigQueryStrings? QueryStrings { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicySpecForProvider
{
    /// <summary>Comment to describe the origin request policy.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Object that determines whether any cookies in viewer requests (and if so, which cookies) are included in the origin request key and automatically included in requests that CloudFront sends to the origin. See Cookies Config for more information.</summary>
    [JsonPropertyName("cookiesConfig")]
    public V1beta1OriginRequestPolicySpecForProviderCookiesConfig? CookiesConfig { get; set; }

    /// <summary>Object that determines whether any HTTP headers (and if so, which headers) are included in the origin request key and automatically included in requests that CloudFront sends to the origin. See Headers Config for more information.</summary>
    [JsonPropertyName("headersConfig")]
    public V1beta1OriginRequestPolicySpecForProviderHeadersConfig? HeadersConfig { get; set; }

    /// <summary>Object that determines whether any URL query strings in viewer requests (and if so, which query strings) are included in the origin request key and automatically included in requests that CloudFront sends to the origin. See Query String Config for more information.</summary>
    [JsonPropertyName("queryStringsConfig")]
    public V1beta1OriginRequestPolicySpecForProviderQueryStringsConfig? QueryStringsConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicySpecInitProviderCookiesConfigCookies
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object that determines whether any cookies in viewer requests (and if so, which cookies) are included in the origin request key and automatically included in requests that CloudFront sends to the origin. See Cookies Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicySpecInitProviderCookiesConfig
{
    /// <summary></summary>
    [JsonPropertyName("cookieBehavior")]
    public string? CookieBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cookies")]
    public V1beta1OriginRequestPolicySpecInitProviderCookiesConfigCookies? Cookies { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicySpecInitProviderHeadersConfigHeaders
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object that determines whether any HTTP headers (and if so, which headers) are included in the origin request key and automatically included in requests that CloudFront sends to the origin. See Headers Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicySpecInitProviderHeadersConfig
{
    /// <summary></summary>
    [JsonPropertyName("headerBehavior")]
    public string? HeaderBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headers")]
    public V1beta1OriginRequestPolicySpecInitProviderHeadersConfigHeaders? Headers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicySpecInitProviderQueryStringsConfigQueryStrings
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object that determines whether any URL query strings in viewer requests (and if so, which query strings) are included in the origin request key and automatically included in requests that CloudFront sends to the origin. See Query String Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicySpecInitProviderQueryStringsConfig
{
    /// <summary></summary>
    [JsonPropertyName("queryStringBehavior")]
    public string? QueryStringBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("queryStrings")]
    public V1beta1OriginRequestPolicySpecInitProviderQueryStringsConfigQueryStrings? QueryStrings { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicySpecInitProvider
{
    /// <summary>Comment to describe the origin request policy.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Object that determines whether any cookies in viewer requests (and if so, which cookies) are included in the origin request key and automatically included in requests that CloudFront sends to the origin. See Cookies Config for more information.</summary>
    [JsonPropertyName("cookiesConfig")]
    public V1beta1OriginRequestPolicySpecInitProviderCookiesConfig? CookiesConfig { get; set; }

    /// <summary>Object that determines whether any HTTP headers (and if so, which headers) are included in the origin request key and automatically included in requests that CloudFront sends to the origin. See Headers Config for more information.</summary>
    [JsonPropertyName("headersConfig")]
    public V1beta1OriginRequestPolicySpecInitProviderHeadersConfig? HeadersConfig { get; set; }

    /// <summary>Object that determines whether any URL query strings in viewer requests (and if so, which query strings) are included in the origin request key and automatically included in requests that CloudFront sends to the origin. See Query String Config for more information.</summary>
    [JsonPropertyName("queryStringsConfig")]
    public V1beta1OriginRequestPolicySpecInitProviderQueryStringsConfig? QueryStringsConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicySpecProviderConfigRef
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
public partial class V1beta1OriginRequestPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>OriginRequestPolicySpec defines the desired state of OriginRequestPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicySpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1OriginRequestPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1OriginRequestPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1OriginRequestPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1OriginRequestPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicyStatusAtProviderCookiesConfigCookies
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object that determines whether any cookies in viewer requests (and if so, which cookies) are included in the origin request key and automatically included in requests that CloudFront sends to the origin. See Cookies Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicyStatusAtProviderCookiesConfig
{
    /// <summary></summary>
    [JsonPropertyName("cookieBehavior")]
    public string? CookieBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cookies")]
    public V1beta1OriginRequestPolicyStatusAtProviderCookiesConfigCookies? Cookies { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicyStatusAtProviderHeadersConfigHeaders
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object that determines whether any HTTP headers (and if so, which headers) are included in the origin request key and automatically included in requests that CloudFront sends to the origin. See Headers Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicyStatusAtProviderHeadersConfig
{
    /// <summary></summary>
    [JsonPropertyName("headerBehavior")]
    public string? HeaderBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headers")]
    public V1beta1OriginRequestPolicyStatusAtProviderHeadersConfigHeaders? Headers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicyStatusAtProviderQueryStringsConfigQueryStrings
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object that determines whether any URL query strings in viewer requests (and if so, which query strings) are included in the origin request key and automatically included in requests that CloudFront sends to the origin. See Query String Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicyStatusAtProviderQueryStringsConfig
{
    /// <summary></summary>
    [JsonPropertyName("queryStringBehavior")]
    public string? QueryStringBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("queryStrings")]
    public V1beta1OriginRequestPolicyStatusAtProviderQueryStringsConfigQueryStrings? QueryStrings { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicyStatusAtProvider
{
    /// <summary>The origin request policy ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Comment to describe the origin request policy.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Object that determines whether any cookies in viewer requests (and if so, which cookies) are included in the origin request key and automatically included in requests that CloudFront sends to the origin. See Cookies Config for more information.</summary>
    [JsonPropertyName("cookiesConfig")]
    public V1beta1OriginRequestPolicyStatusAtProviderCookiesConfig? CookiesConfig { get; set; }

    /// <summary>The current version of the origin request policy.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Object that determines whether any HTTP headers (and if so, which headers) are included in the origin request key and automatically included in requests that CloudFront sends to the origin. See Headers Config for more information.</summary>
    [JsonPropertyName("headersConfig")]
    public V1beta1OriginRequestPolicyStatusAtProviderHeadersConfig? HeadersConfig { get; set; }

    /// <summary>The identifier for the origin request policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Object that determines whether any URL query strings in viewer requests (and if so, which query strings) are included in the origin request key and automatically included in requests that CloudFront sends to the origin. See Query String Config for more information.</summary>
    [JsonPropertyName("queryStringsConfig")]
    public V1beta1OriginRequestPolicyStatusAtProviderQueryStringsConfig? QueryStringsConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicyStatusConditions
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
/// <summary>OriginRequestPolicyStatus defines the observed state of OriginRequestPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OriginRequestPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1OriginRequestPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1OriginRequestPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>OriginRequestPolicy is the Schema for the OriginRequestPolicys API. Determines the values that CloudFront includes in requests that it sends to the origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OriginRequestPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1OriginRequestPolicySpec>, IStatus<V1beta1OriginRequestPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OriginRequestPolicy";
    public const string KubeGroup = "cloudfront.aws.m.upbound.io";
    public const string KubePluralName = "originrequestpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OriginRequestPolicySpec defines the desired state of OriginRequestPolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1OriginRequestPolicySpec Spec { get; set; }

    /// <summary>OriginRequestPolicyStatus defines the observed state of OriginRequestPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1OriginRequestPolicyStatus? Status { get; set; }
}
#nullable disable
